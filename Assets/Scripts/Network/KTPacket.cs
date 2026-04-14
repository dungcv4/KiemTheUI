// TCP packet framing for KTO Game Server.
// Outgoing wire format:
//   [4B int32 LE = dataLen+2] [2B uint16 LE = cmdID] [1B CRC32_check] [4B ticks] [N bytes UTF-8 payload]
//   where dataLen = 1 + 4 + payloadLen + 2
//   CRC32_check = CRC32(ticksBytes + payloadBytes) % 255 XOR (cmdID % 255)
// Incoming (from server):
//   [4B int32 LE = dataLen+2] [2B uint16 LE = cmdID] [N bytes UTF-8 payload]
//   Server does NOT add CRC32+ticks to its outgoing packets.
using System;
using System.Text;

namespace KTO.Network
{
    public static class KTPacket
    {
        public const int HEADER_SIZE = 6;      // 4 (length) + 2 (cmdID)
        public const int MAX_PACKET  = 131072; // 128 KB

        // Monotonically increasing tick counter for CRC32 packet signing
        private static int _tickCounter = 0;

        /// <summary>
        /// Build a complete packet ready to send over TCP.
        /// Server expects: [4B len][2B cmd][1B crc_check][4B ticks][payload]
        /// </summary>
        public static byte[] Build(ushort cmdID, string payload)
        {
            byte[] payloadBytes = string.IsNullOrEmpty(payload)
                ? Array.Empty<byte>()
                : Encoding.UTF8.GetBytes(payload);
            return Build(cmdID, payloadBytes);
        }

        /// <summary>
        /// Build a complete packet from raw payload bytes with CRC32 signing.
        /// </summary>
        public static byte[] Build(ushort cmdID, byte[] payloadBytes)
        {
            // Increment tick counter (must be monotonically increasing)
            int ticks = ++_tickCounter;
            byte[] tickBytes = BitConverter.GetBytes(ticks);

            // CRC32 over [tickBytes + payloadBytes]
            uint crc = CRC32(tickBytes, 0, 4, payloadBytes, 0, payloadBytes.Length);
            uint cc  = crc % 255;
            uint cc2 = (uint)(cmdID % 255);
            byte crcCheck = (byte)(cc ^ cc2);

            // Total data after cmdID: 1 (crc) + 4 (ticks) + payloadLen
            int innerLen = 1 + 4 + payloadBytes.Length;
            int dataLen = innerLen + 2; // +2 for cmdID
            byte[] packet = new byte[4 + 2 + innerLen];

            // [4B length]
            BitConverter.GetBytes(dataLen).CopyTo(packet, 0);
            // [2B cmdID]
            BitConverter.GetBytes(cmdID).CopyTo(packet, 4);
            // [1B CRC32 check]
            packet[6] = crcCheck;
            // [4B ticks]
            Buffer.BlockCopy(tickBytes, 0, packet, 7, 4);
            // [payload]
            if (payloadBytes.Length > 0)
                Buffer.BlockCopy(payloadBytes, 0, packet, 11, payloadBytes.Length);

            return packet;
        }

        // CRC32 (polynomial 0xEDB88320) over two concatenated byte ranges
        private static uint[] _crcTable;
        private static uint[] GetCrcTable()
        {
            if (_crcTable != null) return _crcTable;
            _crcTable = new uint[256];
            for (int n = 0; n < 256; n++)
            {
                uint c = (uint)n;
                for (int k = 0; k < 8; k++)
                    c = (c & 1) != 0 ? 0xEDB88320 ^ (c >> 1) : c >> 1;
                _crcTable[n] = c;
            }
            return _crcTable;
        }

        private static uint CRC32(byte[] buf1, int off1, int len1, byte[] buf2, int off2, int len2)
        {
            var table = GetCrcTable();
            uint c = 0xFFFFFFFF;
            for (int i = 0; i < len1; i++)
                c = table[(c ^ buf1[off1 + i]) & 0xFF] ^ (c >> 8);
            for (int i = 0; i < len2; i++)
                c = table[(c ^ buf2[off2 + i]) & 0xFF] ^ (c >> 8);
            return ~c;
        }

        /// <summary>
        /// Try to parse one complete packet from a buffer.
        /// Returns true if a full packet was parsed; advances offset.
        /// </summary>
        public static bool TryParse(byte[] buffer, int available, ref int offset,
                                     out ushort cmdID, out string payload)
        {
            cmdID = 0;
            payload = null;

            int remaining = available - offset;
            if (remaining < HEADER_SIZE) return false;

            int dataLen = BitConverter.ToInt32(buffer, offset);
            if (dataLen < 2 || dataLen > MAX_PACKET) // malformed
            {
                offset = available; // discard
                return false;
            }

            int payloadLen = dataLen - 2;
            int totalPacketLen = 4 + dataLen; // header bytes + dataLen

            if (remaining < totalPacketLen) return false;

            cmdID = BitConverter.ToUInt16(buffer, offset + 4);

            if (payloadLen > 0)
                payload = Encoding.UTF8.GetString(buffer, offset + 6, payloadLen);
            else
                payload = "";

            offset += totalPacketLen;
            return true;
        }

        /// <summary>
        /// Helper: build colon-separated payload from string fields.
        /// </summary>
        public static string JoinFields(params object[] fields)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < fields.Length; i++)
            {
                if (i > 0) sb.Append(':');
                sb.Append(fields[i]?.ToString() ?? "");
            }
            return sb.ToString();
        }

        /// <summary>
        /// Helper: split colon-separated payload.
        /// </summary>
        public static string[] SplitFields(string payload)
        {
            if (string.IsNullOrEmpty(payload)) return Array.Empty<string>();
            return payload.Split(':');
        }
    }
}
