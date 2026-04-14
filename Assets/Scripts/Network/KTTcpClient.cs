// Async TCP client for KTO Game Server.
// Packet framing: [4B int32 LE = payloadLen+2][2B uint16 LE = cmdID][payload UTF-8]
using System;
using System.Collections.Concurrent;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

namespace KTO.Network
{
    public class KTTcpClient
    {
        public bool IsConnected => _tcp != null && _tcp.Connected && _connected;

        public event Action OnConnected;
        public event Action<string> OnDisconnected;
        public event Action<ushort, string> OnPacketReceived;

        private TcpClient _tcp;
        private NetworkStream _stream;
        private CancellationTokenSource _cts;
        private volatile bool _connected;

        private readonly byte[] _recvBuffer = new byte[8192];
        private byte[] _pendingData = new byte[0];

        // ── Connect ──────────────────────────────────────────────
        public async Task<bool> Connect(string host, int port, int timeoutMs = 5000)
        {
            Disconnect();

            try
            {
                _tcp = new TcpClient();
                _tcp.NoDelay = true;
                _tcp.ReceiveBufferSize = 65536;
                _tcp.SendBufferSize = 65536;

                _cts = new CancellationTokenSource();

                var connectTask = _tcp.ConnectAsync(host, port);
                var timeoutTask = Task.Delay(timeoutMs);

                if (await Task.WhenAny(connectTask, timeoutTask) == timeoutTask)
                {
                    Debug.LogWarning($"[KTTcp] Connect timeout {host}:{port}");
                    _tcp.Close();
                    return false;
                }

                if (connectTask.IsFaulted)
                {
                    Debug.LogWarning($"[KTTcp] Connect failed: {connectTask.Exception?.InnerException?.Message}");
                    return false;
                }

                _stream = _tcp.GetStream();
                _connected = true;

                Debug.Log($"[KTTcp] Connected to {host}:{port}");
                OnConnected?.Invoke();

                // Start receive loop
                _ = ReceiveLoop(_cts.Token);

                return true;
            }
            catch (Exception ex)
            {
                Debug.LogWarning($"[KTTcp] Connect error: {ex.Message}");
                return false;
            }
        }

        // ── Send ─────────────────────────────────────────────────
        public void Send(ushort cmdID, string payload)
        {
            if (!IsConnected)
            {
                Debug.LogWarning($"[KTTcp] Not connected, cannot send CMD {cmdID}");
                return;
            }

            try
            {
                byte[] packet = KTPacket.Build(cmdID, payload);
                _stream.Write(packet, 0, packet.Length);
                Debug.Log($"[KTTcp] Sent CMD {cmdID}, payload={payload}");
            }
            catch (Exception ex)
            {
                Debug.LogWarning($"[KTTcp] Send error: {ex.Message}");
                HandleDisconnect("Send error");
            }
        }

        // ── Disconnect ───────────────────────────────────────────
        public void Disconnect()
        {
            _connected = false;
            _cts?.Cancel();
            _cts?.Dispose();
            _cts = null;

            try { _stream?.Close(); } catch { }
            try { _tcp?.Close(); }    catch { }

            _stream = null;
            _tcp = null;
            _pendingData = new byte[0];
        }

        // ── Receive loop ─────────────────────────────────────────
        private async Task ReceiveLoop(CancellationToken ct)
        {
            try
            {
                while (!ct.IsCancellationRequested && _connected)
                {
                    int bytesRead = await _stream.ReadAsync(_recvBuffer, 0, _recvBuffer.Length, ct);
                    if (bytesRead == 0)
                    {
                        HandleDisconnect("Server closed connection");
                        return;
                    }

                    // Append to pending data
                    byte[] newPending = new byte[_pendingData.Length + bytesRead];
                    Buffer.BlockCopy(_pendingData, 0, newPending, 0, _pendingData.Length);
                    Buffer.BlockCopy(_recvBuffer, 0, newPending, _pendingData.Length, bytesRead);
                    _pendingData = newPending;

                    // Parse all complete packets
                    int offset = 0;
                    while (KTPacket.TryParse(_pendingData, _pendingData.Length, ref offset,
                                              out ushort cmdID, out string payload))
                    {
                        Debug.Log($"[KTTcp] Recv CMD {cmdID}, payload={payload}");
                        try
                        {
                            OnPacketReceived?.Invoke(cmdID, payload);
                        }
                        catch (Exception ex)
                        {
                            Debug.LogError($"[KTTcp] Handler error CMD {cmdID}: {ex}");
                        }
                    }

                    // Keep unprocessed bytes
                    if (offset > 0 && offset < _pendingData.Length)
                    {
                        byte[] leftover = new byte[_pendingData.Length - offset];
                        Buffer.BlockCopy(_pendingData, offset, leftover, 0, leftover.Length);
                        _pendingData = leftover;
                    }
                    else if (offset >= _pendingData.Length)
                    {
                        _pendingData = new byte[0];
                    }
                }
            }
            catch (OperationCanceledException) { }
            catch (Exception ex)
            {
                if (_connected)
                {
                    Debug.LogWarning($"[KTTcp] Receive error: {ex.Message}");
                    HandleDisconnect("Receive error");
                }
            }
        }

        private void HandleDisconnect(string reason)
        {
            if (!_connected) return;
            _connected = false;
            Debug.Log($"[KTTcp] Disconnected: {reason}");
            OnDisconnected?.Invoke(reason);
        }
    }
}
