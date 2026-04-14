// Lightweight protobuf reader/writer matching SDK server wire format.
// Supports wire-type 0 (varint) and 2 (length-delimited).
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace KTO.Network
{
    // ── Writer ──────────────────────────────────────────────────────
    public class PbWriter
    {
        private readonly MemoryStream _ms = new MemoryStream();

        public byte[] ToArray()
        {
            return _ms.ToArray();
        }

        // ── Tag ──
        private void WriteTag(int fieldNumber, int wireType)
        {
            WriteRawVarint((uint)((fieldNumber << 3) | wireType));
        }

        // ── Varint (LEB128) ──
        private void WriteRawVarint(uint value)
        {
            while (value > 0x7F)
            {
                _ms.WriteByte((byte)(value | 0x80));
                value >>= 7;
            }
            _ms.WriteByte((byte)value);
        }

        private void WriteRawVarint64(ulong value)
        {
            while (value > 0x7F)
            {
                _ms.WriteByte((byte)(value | 0x80));
                value >>= 7;
            }
            _ms.WriteByte((byte)value);
        }

        // ── Int32  (field, wire-type 0) ──
        public void WriteInt32(int fieldNumber, int value)
        {
            if (value == 0) return;                       // SDK skips zero
            WriteTag(fieldNumber, 0);
            if (value >= 0)
                WriteRawVarint((uint)value);
            else
                WriteRawVarint64((ulong)(long)value);     // 10-byte two's complement
        }

        // ── Int64  (field, wire-type 0) ──
        public void WriteInt64(int fieldNumber, long value)
        {
            if (value == 0) return;
            WriteTag(fieldNumber, 0);
            WriteRawVarint64((ulong)value);
        }

        // ── String (field, wire-type 2) ──
        public void WriteString(int fieldNumber, string value)
        {
            if (string.IsNullOrEmpty(value)) return;      // SDK skips empty
            WriteTag(fieldNumber, 2);
            byte[] bytes = Encoding.UTF8.GetBytes(value);
            WriteRawVarint((uint)bytes.Length);
            _ms.Write(bytes, 0, bytes.Length);
        }

        // ── Bytes  (field, wire-type 2) ──
        public void WriteBytes(int fieldNumber, byte[] value)
        {
            if (value == null || value.Length == 0) return;
            WriteTag(fieldNumber, 2);
            WriteRawVarint((uint)value.Length);
            _ms.Write(value, 0, value.Length);
        }

        // ── Embedded message (field, wire-type 2) ──
        public void WriteMessage(int fieldNumber, byte[] embeddedBytes)
        {
            if (embeddedBytes == null || embeddedBytes.Length == 0) return;
            WriteTag(fieldNumber, 2);
            WriteRawVarint((uint)embeddedBytes.Length);
            _ms.Write(embeddedBytes, 0, embeddedBytes.Length);
        }
    }

    // ── Reader ──────────────────────────────────────────────────────
    public class PbReader
    {
        private readonly byte[] _buf;
        private int _pos;
        private readonly int _end;

        public PbReader(byte[] data) : this(data, 0, data.Length) { }
        public PbReader(byte[] data, int offset, int length)
        {
            _buf = data;
            _pos = offset;
            _end = offset + length;
        }

        public bool HasMore => _pos < _end;

        // ── Read tag → (fieldNumber, wireType) ──
        public (int fieldNumber, int wireType) ReadTag()
        {
            uint tag = ReadRawVarint32();
            return ((int)(tag >> 3), (int)(tag & 0x7));
        }

        // ── Varint ──
        private uint ReadRawVarint32()
        {
            uint result = 0;
            int shift = 0;
            while (_pos < _end)
            {
                byte b = _buf[_pos++];
                result |= (uint)(b & 0x7F) << shift;
                if ((b & 0x80) == 0) return result;
                shift += 7;
                if (shift >= 35) throw new FormatException("Varint too long");
            }
            throw new EndOfStreamException("Truncated varint");
        }

        private ulong ReadRawVarint64()
        {
            ulong result = 0;
            int shift = 0;
            while (_pos < _end)
            {
                byte b = _buf[_pos++];
                result |= (ulong)(b & 0x7F) << shift;
                if ((b & 0x80) == 0) return result;
                shift += 7;
                if (shift >= 70) throw new FormatException("Varint too long");
            }
            throw new EndOfStreamException("Truncated varint");
        }

        // ── Int32 ──
        // Protobuf encodes negative int32 as 10-byte sign-extended varint,
        // so we must read as varint64 and truncate to int32.
        public int ReadInt32()
        {
            return (int)ReadRawVarint64();
        }

        // ── Int64 ──
        public long ReadInt64()
        {
            return (long)ReadRawVarint64();
        }

        // ── String ──
        public string ReadString()
        {
            int len = (int)ReadRawVarint32();
            if (len == 0) return "";
            string s = Encoding.UTF8.GetString(_buf, _pos, len);
            _pos += len;
            return s;
        }

        // ── Bytes ──
        public byte[] ReadBytes()
        {
            int len = (int)ReadRawVarint32();
            if (len == 0) return Array.Empty<byte>();
            byte[] result = new byte[len];
            Buffer.BlockCopy(_buf, _pos, result, 0, len);
            _pos += len;
            return result;
        }

        // ── Embedded message → sub-reader ──
        public PbReader ReadEmbedded()
        {
            int len = (int)ReadRawVarint32();
            var sub = new PbReader(_buf, _pos, len);
            _pos += len;
            return sub;
        }

        // ── Skip unknown field ──
        public void Skip(int wireType)
        {
            switch (wireType)
            {
                case 0: ReadRawVarint64(); break;
                case 1: _pos += 8; break;           // 64-bit fixed
                case 2:
                    int len = (int)ReadRawVarint32();
                    _pos += len;
                    break;
                case 5: _pos += 4; break;           // 32-bit fixed
                default:
                    throw new FormatException($"Unknown wire type {wireType}");
            }
        }
    }

    // ── Data models ─────────────────────────────────────────────────

    public class SDKLoginResponse
    {
        public int    ErrorCode;
        public string ErrorMsg     = "";
        public string AccessToken  = "";
        public string LastLoginTime = "";
        public string LastLoginIP   = "";

        public static SDKLoginResponse Parse(byte[] data)
        {
            var r = new SDKLoginResponse();
            var pb = new PbReader(data);
            while (pb.HasMore)
            {
                var (fn, wt) = pb.ReadTag();
                switch (fn)
                {
                    case 1: r.ErrorCode     = pb.ReadInt32();  break;
                    case 2: r.ErrorMsg      = pb.ReadString(); break;
                    case 3: r.AccessToken   = pb.ReadString(); break;
                    case 4: r.LastLoginTime = pb.ReadString(); break;
                    case 5: r.LastLoginIP   = pb.ReadString(); break;
                    default: pb.Skip(wt); break;
                }
            }
            return r;
        }
    }

    public class SDKRegisterResponse
    {
        public int    ErrorCode;
        public string ErrorMsg = "";

        public static SDKRegisterResponse Parse(byte[] data)
        {
            var r = new SDKRegisterResponse();
            var pb = new PbReader(data);
            while (pb.HasMore)
            {
                var (fn, wt) = pb.ReadTag();
                switch (fn)
                {
                    case 1: r.ErrorCode = pb.ReadInt32();  break;
                    case 2: r.ErrorMsg  = pb.ReadString(); break;
                    default: pb.Skip(wt); break;
                }
            }
            return r;
        }
    }

    public class SDKVerifyResponse
    {
        public string PlatformUserID = "";
        public string AccountName    = "";
        public long   LTime;
        public string CM             = "";
        public string SignToken      = "";

        public static SDKVerifyResponse Parse(byte[] data)
        {
            var r = new SDKVerifyResponse();
            var pb = new PbReader(data);
            while (pb.HasMore)
            {
                var (fn, wt) = pb.ReadTag();
                switch (fn)
                {
                    case 1: r.PlatformUserID = pb.ReadString(); break;
                    case 2: r.AccountName    = pb.ReadString(); break;
                    case 3: r.LTime          = pb.ReadInt64();  break;
                    case 4: r.CM             = pb.ReadString(); break;
                    case 5: r.SignToken      = pb.ReadString(); break;
                    default: pb.Skip(wt); break;
                }
            }
            return r;
        }
    }

    public class ServerInfo
    {
        public int    ServerOrder;
        public int    ServerID;
        public int    OnlineNum;
        public string ServerName    = "";
        public int    Status;
        public string URL           = "";
        public int    Port;
        public string MaintainTxt   = "";
        public string MaintainStart = "";
        public string MaintainEnd   = "";
        public string Message       = "";

        public static ServerInfo Parse(PbReader pb)
        {
            var s = new ServerInfo();
            while (pb.HasMore)
            {
                var (fn, wt) = pb.ReadTag();
                switch (fn)
                {
                    case 1:  s.ServerOrder   = pb.ReadInt32();  break;
                    case 2:  s.ServerID      = pb.ReadInt32();  break;
                    case 3:  s.OnlineNum     = pb.ReadInt32();  break;
                    case 5:  s.ServerName    = pb.ReadString(); break;
                    case 7:  s.Status        = pb.ReadInt32();  break;
                    case 8:  s.URL           = pb.ReadString(); break;
                    case 9:  s.Port          = pb.ReadInt32();  break;
                    case 10: s.MaintainTxt   = pb.ReadString(); break;
                    case 11: s.MaintainStart = pb.ReadString(); break;
                    case 12: s.MaintainEnd   = pb.ReadString(); break;
                    case 13: s.Message       = pb.ReadString(); break;
                    default: pb.Skip(wt); break;
                }
            }
            return s;
        }
    }

    public class SDKServerListResponse
    {
        public List<ServerInfo> Servers    = new List<ServerInfo>();
        public ServerInfo       LastServer;
        public int              ErrorCode;
        public string           ErrorMsg   = "";

        public static SDKServerListResponse Parse(byte[] data)
        {
            var r = new SDKServerListResponse();
            var pb = new PbReader(data);
            bool firstGroup = true;
            while (pb.HasMore)
            {
                var (fn, wt) = pb.ReadTag();
                switch (fn)
                {
                    case 1:
                        // First group of servers — use these
                        var sub1 = pb.ReadEmbedded();
                        if (firstGroup)
                            r.Servers.Add(ServerInfo.Parse(sub1));
                        break;
                    case 2:
                        // Second group (duplicate) — skip
                        pb.ReadEmbedded();
                        break;
                    case 3:
                        // Last logged server
                        var sub3 = pb.ReadEmbedded();
                        r.LastServer = ServerInfo.Parse(sub3);
                        break;
                    case 4:
                        // Error code (auth failure, etc.)
                        r.ErrorCode = pb.ReadInt32();
                        break;
                    case 5:
                        // Error message
                        r.ErrorMsg = pb.ReadString();
                        break;
                    default:
                        pb.Skip(wt);
                        break;
                }
            }
            return r;
        }
    }
}
