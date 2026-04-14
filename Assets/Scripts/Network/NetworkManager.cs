// Singleton network manager: owns SDK client + TCP client.
// Dispatches TCP packets to registered handlers on the main thread.
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using UnityEngine;

namespace KTO.Network
{
    public class NetworkManager : MonoBehaviour
    {
        public static NetworkManager Instance { get; private set; }

        [Header("SDK Server")]
        public string sdkHost = "127.0.0.1";
        public int    sdkPort = 8887;

        [Header("Current Game Server (set after server select)")]
        public string gameHost = "";
        public int    gamePort = 0;

        public SDKClient   SDK  { get; private set; }
        public KTTcpClient TCP  { get; private set; }

        // ── Events ──
        public event Action OnTcpConnected;
        public event Action<string> OnTcpDisconnected;

        // ── Packet dispatch ──
        private readonly Dictionary<ushort, Action<string>> _handlers
            = new Dictionary<ushort, Action<string>>();

        // Main-thread dispatch queue
        private readonly ConcurrentQueue<(ushort cmd, string payload)> _packetQueue
            = new ConcurrentQueue<(ushort, string)>();

        // ── Lifecycle ────────────────────────────────────────────

        void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }
            Instance = this;
            DontDestroyOnLoad(gameObject);

            SDK = new SDKClient(sdkHost, sdkPort);
            TCP = new KTTcpClient();

            TCP.OnConnected    += () => _packetQueue.Enqueue((0xFFFF, "__CONNECTED__"));
            TCP.OnDisconnected += r  => _packetQueue.Enqueue((0xFFFE, r));
            TCP.OnPacketReceived += (cmd, payload) => _packetQueue.Enqueue((cmd, payload));
        }

        void Update()
        {
            // Dispatch queued packets on main thread
            while (_packetQueue.TryDequeue(out var pkt))
            {
                if (pkt.cmd == 0xFFFF)
                {
                    OnTcpConnected?.Invoke();
                    continue;
                }
                if (pkt.cmd == 0xFFFE)
                {
                    OnTcpDisconnected?.Invoke(pkt.payload);
                    continue;
                }

                if (_handlers.TryGetValue(pkt.cmd, out var handler))
                {
                    try { handler(pkt.payload); }
                    catch (Exception ex) { Debug.LogError($"[Net] Handler CMD {pkt.cmd}: {ex}"); }
                }
                else
                {
                    Debug.LogWarning($"[Net] Unhandled CMD {pkt.cmd}");
                }
            }
        }

        void OnDestroy()
        {
            TCP?.Disconnect();
            if (Instance == this) Instance = null;
        }

        // ── Public API ───────────────────────────────────────────

        /// <summary>
        /// Register a handler for a specific CMD ID.
        /// </summary>
        public void RegisterHandler(ushort cmdID, Action<string> handler)
        {
            _handlers[cmdID] = handler;
        }

        public void UnregisterHandler(ushort cmdID)
        {
            _handlers.Remove(cmdID);
        }

        /// <summary>
        /// Connect TCP to the selected game server.
        /// </summary>
        public async void ConnectGameServer(string host, int port)
        {
            gameHost = host;
            gamePort = port;
            TCP.Disconnect();
            bool ok = await TCP.Connect(host, port);
            if (!ok) Debug.LogError($"[Net] Failed to connect game server {host}:{port}");
        }

        /// <summary>
        /// Send a TCP command with colon-separated payload.
        /// </summary>
        public void SendCmd(ushort cmdID, params object[] fields)
        {
            string payload = KTPacket.JoinFields(fields);
            TCP.Send(cmdID, payload);
        }
    }
}
