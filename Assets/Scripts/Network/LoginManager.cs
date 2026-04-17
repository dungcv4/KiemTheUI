// Orchestrates the full login flow:
// SDK Login → Verify → Server List → TCP Connect → CMD_LOGIN_ON2 → CMD_LOGIN_ON → CMD_ROLE_LIST
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace KTO.Network
{
    // ── Role data from server ──
    [Serializable]
    public class RoleInfo
    {
        public int    RoleID;
        public string RoleName  = "";
        public int    Level;
        public int    FactionID;
        public int    Sex;
        public string Extra     = "";
    }

    // ── Login state ──
    public enum LoginState
    {
        Idle,
        LoggingIn,
        Verifying,
        ServerList,
        Connecting,
        LoginOn2,
        LoginOn,
        RoleList,
        Ready,
        Error
    }

    public class LoginManager : MonoBehaviour
    {
        public static LoginManager Instance { get; private set; }

        // ── State ──
        public LoginState State { get; private set; } = LoginState.Idle;
        public string     ErrorMessage { get; private set; } = "";

        // ── SDK login results ──
        public string AccessToken     { get; private set; } = "";
        public string PlatformUserID  { get; private set; } = "";
        public string AccountName     { get; private set; } = "";
        public long   LTime           { get; private set; }
        public string CM              { get; private set; } = "";
        public string SignToken       { get; private set; } = "";

        // ── Server list ──
        public List<ServerInfo> Servers    { get; private set; } = new List<ServerInfo>();
        public ServerInfo       LastServer { get; private set; }
        public ServerInfo       SelectedServer { get; set; }

        // ── Game server session ──
        public string UserToken      { get; private set; } = "";
        public string IsAdult        { get; private set; } = "1";
        public int    RandToken      { get; private set; }

        // ── Role list ──
        public List<RoleInfo> Roles { get; private set; } = new List<RoleInfo>();

        // ── Events ──
        public event Action<LoginState>   OnStateChanged;
        public event Action<string>       OnError;
        public event Action<List<ServerInfo>> OnServerListReceived;
        public event Action<List<RoleInfo>>   OnRoleListReceived;
        public event Action<int, string>      OnCreateRoleResult;

        void Awake()
        {
            if (Instance != null && Instance != this) { Destroy(gameObject); return; }
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        void Start()
        {
            var net = NetworkManager.Instance;
            if (net == null) return;

            // Register TCP handlers
            net.RegisterHandler(LoginProtocol.CMD_LOGIN_ON2, OnRecvLoginOn2);
            net.RegisterHandler(LoginProtocol.CMD_LOGIN_ON,  OnRecvLoginOn);
            net.RegisterHandler(LoginProtocol.CMD_ROLE_LIST, OnRecvRoleList);
            net.RegisterHandler(LoginProtocol.CMD_CREATE_ROLE, OnRecvCreateRole);
            net.RegisterHandler(LoginProtocol.CMD_INIT_GAME,  OnRecvInitGameAck);
            net.RegisterHandler(LoginProtocol.CMD_PLAY_GAME,  OnRecvPlayGameAck);
            net.RegisterHandler(LoginProtocol.CMD_SPR_FIRE_EVENT, OnRecvFireEvent);

            net.OnTcpConnected    += OnTcpConnected;
            net.OnTcpDisconnected += OnTcpDisconnected;
        }

        void OnDestroy()
        {
            var net = NetworkManager.Instance;
            if (net != null)
            {
                net.UnregisterHandler(LoginProtocol.CMD_LOGIN_ON2);
                net.UnregisterHandler(LoginProtocol.CMD_LOGIN_ON);
                net.UnregisterHandler(LoginProtocol.CMD_ROLE_LIST);
                net.UnregisterHandler(LoginProtocol.CMD_CREATE_ROLE);
                net.UnregisterHandler(LoginProtocol.CMD_INIT_GAME);
                net.UnregisterHandler(LoginProtocol.CMD_PLAY_GAME);
                net.UnregisterHandler(LoginProtocol.CMD_SPR_FIRE_EVENT);
                net.OnTcpConnected    -= OnTcpConnected;
                net.OnTcpDisconnected -= OnTcpDisconnected;
            }
            if (Instance == this) Instance = null;
        }

        // ══════════════════════════════════════════════════════════
        // PUBLIC FLOW METHODS
        // ══════════════════════════════════════════════════════════

        /// <summary>
        /// Step 1: SDK Login → Verify → get server list.
        /// Call this from Login UI when user presses "Login".
        /// </summary>
        public async void DoLogin(string userName, string password)
        {
            SetState(LoginState.LoggingIn);
            var sdk = NetworkManager.Instance.SDK;

            // 1. Login
            Debug.Log($"[Login] SDK Login: {userName}");
            var loginResp = await sdk.Login(userName, password);
            if (loginResp.ErrorCode != 0)
            {
                SetError($"Login failed: {loginResp.ErrorMsg} (code {loginResp.ErrorCode})");
                return;
            }
            AccessToken = loginResp.AccessToken;
            Debug.Log($"[Login] Got token: {AccessToken.Substring(0, Math.Min(10, AccessToken.Length))}...");

            // 2. Verify
            SetState(LoginState.Verifying);
            var verifyResp = await sdk.Verify(AccessToken);
            if (verifyResp == null || string.IsNullOrEmpty(verifyResp.PlatformUserID))
            {
                SetError("Verify failed");
                return;
            }
            PlatformUserID = verifyResp.PlatformUserID;
            AccountName    = verifyResp.AccountName;
            LTime          = verifyResp.LTime;
            CM             = verifyResp.CM;
            SignToken      = verifyResp.SignToken;
            Debug.Log($"[Login] Verified: uid={PlatformUserID}, name={AccountName}, time={LTime}");

            // 3. Server list
            SetState(LoginState.ServerList);
            string uid = PlatformUserID.Contains("_")
                ? PlatformUserID.Substring(0, PlatformUserID.IndexOf('_'))
                : PlatformUserID;
            var listResp = await sdk.GetServerList(uid, AccessToken);
            if (listResp == null)
            {
                SetError("No servers available");
                return;
            }
            // Check for auth error from server
            if (listResp.ErrorCode != 0)
            {
                SetError($"Server list: {listResp.ErrorMsg} (code {listResp.ErrorCode})");
                return;
            }
            if (listResp.Servers.Count == 0)
            {
                SetError("No servers available");
                return;
            }
            Servers    = listResp.Servers;
            LastServer = listResp.LastServer;
            Debug.Log($"[Login] Got {Servers.Count} servers, last={LastServer?.ServerName}");

            OnServerListReceived?.Invoke(Servers);
            SetState(LoginState.ServerList);
        }

        /// <summary>
        /// Step 2: Connect to selected game server + send CMD_LOGIN_ON2.
        /// Call this from SelectServer UI when user picks a server.
        /// </summary>
        public void ConnectToServer(ServerInfo server)
        {
            SelectedServer = server;
            SetState(LoginState.Connecting);
            Debug.Log($"[Login] Connecting to {server.ServerName} ({server.URL}:{server.Port})");
            NetworkManager.Instance.ConnectGameServer(server.URL, server.Port);
        }

        /// <summary>
        /// Step 3 (after role list): Select a role and enter game.
        /// </summary>
        public void SelectRole(int roleID)
        {
            _pendingRoleID = roleID;
            var net = NetworkManager.Instance;
            net.SendCmd(LoginProtocol.CMD_INIT_GAME,
                PlatformUserID, roleID, SystemInfo.deviceUniqueIdentifier, SystemInfo.deviceModel);
        }

        // Phase A: roleID we're handing off init→play with
        private int _pendingRoleID;

        // ── CMD_INIT_GAME ack (cmd 104) ──
        private void OnRecvInitGameAck(string payload)
        {
            Debug.Log($"[Login] CMD_INIT_GAME ack: {payload}");
            // For fake gate we ignore the body and immediately send CMD_PLAY_GAME
            // with the roleID we remembered in SelectRole().
            NetworkManager.Instance.SendCmd(LoginProtocol.CMD_PLAY_GAME, _pendingRoleID);
        }

        // ── CMD_PLAY_GAME ack (cmd 106) ──
        private void OnRecvPlayGameAck(string payload)
        {
            Debug.Log($"[Login] CMD_PLAY_GAME ack: {payload} — loading MainUIScene");
            // Server has now placed us in the world; switch to HUD scene.
            // The follow-up CMD_SPR_FIRE_EVENT(7) will arrive after scene load and be
            // forwarded to LuaEventBridge.
            SceneManager.LoadScene("MainUIScene");
        }

        // ── CMD_SPR_FIRE_EVENT (cmd 32200) ──
        private void OnRecvFireEvent(string payload)
        {
            if (!int.TryParse(payload, out int eventId))
            {
                Debug.LogWarning($"[Login] CMD_SPR_FIRE_EVENT bad payload: {payload}");
                return;
            }
            Debug.Log($"[Login] CMD_SPR_FIRE_EVENT → EventNotify:OnNotify({eventId})");
            LuaEventBridge.Fire(eventId);
        }

        /// <summary>
        /// Create a new role.
        /// </summary>
        public void CreateRole(string roleName, int sex, int factionID, int serverID = 0)
        {
            if (serverID == 0 && SelectedServer != null) serverID = SelectedServer.ServerID;
            string nameAndPlatform = $"{roleName}$0";
            int villageID = 1;

            var net = NetworkManager.Instance;
            net.SendCmd(LoginProtocol.CMD_CREATE_ROLE,
                PlatformUserID, AccountName, sex, factionID, nameAndPlatform, serverID, villageID);
        }

        /// <summary>
        /// Request role list for current server.
        /// </summary>
        public void RequestRoleList()
        {
            int zoneID = SelectedServer?.ServerID ?? 1;
            NetworkManager.Instance.SendCmd(LoginProtocol.CMD_ROLE_LIST, PlatformUserID, zoneID);
        }

        // ══════════════════════════════════════════════════════════
        // TCP EVENT HANDLERS
        // ══════════════════════════════════════════════════════════

        private void OnTcpConnected()
        {
            Debug.Log("[Login] TCP connected, sending CMD_LOGIN_ON2");
            SetState(LoginState.LoginOn2);
            SendLoginOn2();
        }

        private void OnTcpDisconnected(string reason)
        {
            if (State != LoginState.Idle && State != LoginState.Error)
                SetError($"Disconnected: {reason}");
        }

        // ── CMD_LOGIN_ON2 (cmd 20) ──
        private void SendLoginOn2()
        {
            string signData = PlatformUserID + AccountName + LTime + IsAdult + LoginProtocol.WEB_KEY;
            string signCode = ComputeMD5(signData).ToLower();

            NetworkManager.Instance.SendCmd(LoginProtocol.CMD_LOGIN_ON2,
                LoginProtocol.VER_SIGN, PlatformUserID, AccountName, LTime, IsAdult, signCode);
        }

        private void OnRecvLoginOn2(string payload)
        {
            Debug.Log($"[Login] CMD_LOGIN_ON2 response: {payload}");
            var fields = KTPacket.SplitFields(payload);
            if (fields.Length < 4)
            {
                SetError("LOGIN_ON2 invalid response");
                return;
            }

            // Check for error: if first field is a negative number or small number
            if (int.TryParse(fields[0], out int code) && code <= 2 && string.IsNullOrEmpty(fields[2]))
            {
                // Error response: errorCode:::
                string errMsg = code switch
                {
                    0 => "Connection disabled",
                    1 => "Token expired",
                    2 => "Version mismatch",
                    _ => $"Login error {code}"
                };
                SetError(errMsg);
                return;
            }

            // Success: userID:userName:userToken:isAdult
            UserToken = fields[2];
            IsAdult   = fields[3];
            Debug.Log($"[Login] LOGIN_ON2 OK, token={UserToken.Substring(0, Math.Min(10, UserToken.Length))}...");

            // Proceed to CMD_LOGIN_ON
            SetState(LoginState.LoginOn);
            SendLoginOn();
        }

        // ── CMD_LOGIN_ON (cmd 100) ──
        private void SendLoginOn()
        {
            int roleRandToken = UnityEngine.Random.Range(1000, 999999);

            NetworkManager.Instance.SendCmd(LoginProtocol.CMD_LOGIN_ON,
                PlatformUserID, AccountName, UserToken, roleRandToken,
                LoginProtocol.VER_SIGN, IsAdult);
        }

        private void OnRecvLoginOn(string payload)
        {
            Debug.Log($"[Login] CMD_LOGIN_ON response: {payload}");
            var fields = KTPacket.SplitFields(payload);

            if (fields.Length >= 2)
            {
                // Success: randToken:waitSecs
                if (int.TryParse(fields[0], out int rt))
                {
                    RandToken = rt;
                    Debug.Log($"[Login] LOGIN_ON OK, randToken={RandToken}");

                    // Request role list
                    SetState(LoginState.RoleList);
                    RequestRoleList();
                    return;
                }
            }

            if (fields.Length >= 1 && int.TryParse(fields[0], out int errCode))
            {
                string errMsg = errCode switch
                {
                    0 => "Token expired",
                    1 => "Server full",
                    2 => "Version mismatch",
                    _ => $"Login error {errCode}"
                };
                SetError(errMsg);
                return;
            }

            SetError("LOGIN_ON unknown response");
        }

        // ── CMD_ROLE_LIST (cmd 101) ──
        private void OnRecvRoleList(string payload)
        {
            Debug.Log($"[Login] CMD_ROLE_LIST response: {payload}");
            Roles.Clear();

            if (!string.IsNullOrEmpty(payload))
            {
                // Server format: "roleCount:roleID$sex$faction$roleName$level$delSeconds$equipString|..."
                var colonSplit = payload.Split(new char[]{':'}, 2);
                string roleData = colonSplit.Length > 1 ? colonSplit[1] : colonSplit[0];

                if (!string.IsNullOrEmpty(roleData))
                {
                    var entries = roleData.Split('|');
                    foreach (var entry in entries)
                    {
                        if (string.IsNullOrEmpty(entry)) continue;
                        var parts = entry.Split('$');
                        if (parts.Length >= 5)
                        {
                            // Server order: roleID$sex$faction$roleName$level$delSeconds$equipString
                            Roles.Add(new RoleInfo
                            {
                                RoleID    = int.TryParse(parts[0], out int rid) ? rid : 0,
                                Sex       = int.TryParse(parts[1], out int sx) ? sx : 0,
                                FactionID = int.TryParse(parts[2], out int fid) ? fid : 0,
                                RoleName  = parts[3],
                                Level     = int.TryParse(parts[4], out int lv) ? lv : 1,
                                Extra     = parts.Length > 6 ? parts[6] : ""
                            });
                        }
                    }
                }
            }

            Debug.Log($"[Login] Got {Roles.Count} roles");
            OnRoleListReceived?.Invoke(Roles);
            SetState(LoginState.Ready);
        }

        // ── CMD_CREATE_ROLE (cmd 102) ──
        private void OnRecvCreateRole(string payload)
        {
            Debug.Log($"[Login] CMD_CREATE_ROLE response: {payload}");
            var fields = KTPacket.SplitFields(payload);
            if (fields.Length >= 2)
            {
                int resultCode = int.TryParse(fields[0], out int rc) ? rc : -999;
                string roleData = fields[1];

                if (resultCode == 1)
                {
                    Debug.Log("[Login] Role created successfully!");
                    // Re-request role list
                    RequestRoleList();
                }
                else
                {
                    string errMsg = resultCode switch
                    {
                        -1  => "Invalid name",
                        -7  => "Create limit reached",
                        -12 => "Operation denied",
                        _   => $"Create failed ({resultCode})"
                    };
                    Debug.LogWarning($"[Login] Create role error: {errMsg}");
                }

                OnCreateRoleResult?.Invoke(resultCode, roleData);
            }
        }

        // ══════════════════════════════════════════════════════════
        // HELPERS
        // ══════════════════════════════════════════════════════════

        private void SetState(LoginState state)
        {
            State = state;
            Debug.Log($"[Login] State → {state}");
            OnStateChanged?.Invoke(state);
        }

        private void SetError(string msg)
        {
            ErrorMessage = msg;
            SetState(LoginState.Error);
            Debug.LogError($"[Login] ERROR: {msg}");
            OnError?.Invoke(msg);
        }

        public static string ComputeMD5(string input)
        {
            using (var md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes  = md5.ComputeHash(inputBytes);
                var sb = new StringBuilder(32);
                foreach (byte b in hashBytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }
    }
}
