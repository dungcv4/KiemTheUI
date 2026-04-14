// Master controller: manages Login → LoginServer (lobby) → SelectServer → SelectRole/CreateRole flow.
// Instantiates UI prefabs and toggles panels based on LoginManager state.
using UnityEngine;
using UnityEngine.UI;
using KTO.Network;

public class LoginSceneController : MonoBehaviour
{
    [Header("Prefab Refs (auto-loaded from Imported)")]
    public GameObject loginPrefab;
    public GameObject loginServerPrefab;   // UILoginServer — lobby screen
    public GameObject selectServerPrefab;  // UISelectServer — server list popup
    public GameObject selectZonePrefab;    // UISelectZone (legacy, unused now)

    [Header("Existing Scene Refs (auto-found)")]
    public GameObject selectRoleExistRoot;
    public GameObject createRoleRoot;

    // Instantiated panels
    private GameObject _loginPanel;
    private GameObject _loginServerPanel;   // lobby
    private GameObject _selectServerPanel;  // server list popup
    private GameObject _loginBG;            // UILoginBG character background
    private GameObject _backgroundCanvas;   // Background_Canvas with landscape image

    private LoginController        _loginCtrl;
    private LoginServerController  _loginServerCtrl;

    void Awake()
    {
        // Auto-load prefabs
        if (loginPrefab == null)
            loginPrefab = LoadPrefab("UILoginChannelInner");
        if (loginServerPrefab == null)
            loginServerPrefab = LoadPrefab("UILoginServer");
        if (selectServerPrefab == null)
            selectServerPrefab = LoadPrefab("UISelectServer");
        if (selectZonePrefab == null)
            selectZonePrefab = LoadPrefab("UISelectZone");

        // Find existing scene roots
        if (selectRoleExistRoot == null)
        {
            selectRoleExistRoot = FindCanvasRoot("UISelectRoleExist")
                               ?? FindCanvasRoot("UISelectRoleExist_Canvas");
        }
        // Spawn from prefab if not in scene
        if (selectRoleExistRoot == null)
        {
            var prefab = LoadPrefab("UISelectRoleExist");
            if (prefab != null)
            {
                var go = Instantiate(prefab);
                go.name = "UISelectRoleExist_Canvas";
                selectRoleExistRoot = go;
                Debug.Log("[Scene] Spawned UISelectRoleExist from prefab");
            }
        }
        if (createRoleRoot == null)
        {
            createRoleRoot = FindCanvasRoot("UICreateRole_Canvas")
                          ?? FindCanvasRoot("UICreateRole");
        }
    }

    void Start()
    {
        // Ensure network singletons exist
        EnsureSingleton<NetworkManager>("NetworkManager");
        EnsureSingleton<LoginManager>("LoginManager");

        // Subscribe to state changes
        if (LoginManager.Instance != null)
        {
            LoginManager.Instance.OnStateChanged      += OnLoginStateChanged;
            LoginManager.Instance.OnError              += OnLoginError;
            LoginManager.Instance.OnRoleListReceived   += OnRoleListReceived;
        }

        // Instantiate login panel
        SpawnLoginPanel();

        // Hide other panels initially
        SetPanelActive(_loginServerPanel, false);
        SetPanelActive(_selectServerPanel, false);
        SetPanelActive(selectRoleExistRoot, false);
        SetPanelActive(createRoleRoot, false);

        // UILoginBG has characters + VFX — only show on SelectRole/CreateRole
        _loginBG = FindCanvasRoot("UILoginBG");
        SetPanelActive(_loginBG, false);

        // Background_Canvas has landscape image (createrole_bg.png) — always show
        _backgroundCanvas = FindCanvasRoot("Background_Canvas");
        SetPanelActive(_backgroundCanvas, true);

        Debug.Log($"[Scene] Panels: createRole={createRoleRoot != null}, selectRole={selectRoleExistRoot != null}, bg={_backgroundCanvas != null}");

        // Show login
        SetPanelActive(_loginPanel, true);

        #if UNITY_EDITOR
        StartCoroutine(_DebugAutoLogin());
        #endif
    }
    #if UNITY_EDITOR
    System.Collections.IEnumerator _DebugAutoLogin()
    {
        yield return new WaitForSeconds(2f);
        var lm = LoginManager.Instance;
        if (lm == null) yield break;

        lm.DoLogin("testuser", "12345678");

        // Wait for server list
        while (lm.State != LoginState.ServerList && lm.State != LoginState.Error)
            yield return new WaitForSeconds(0.5f);

        if (lm.State == LoginState.Error)
        {
            Debug.LogError($"[DebugLogin] Failed: {lm.ErrorMessage}");
            yield break;
        }

        yield return new WaitForSeconds(1f);

        // Auto-select first server and connect
        if (lm.Servers.Count > 0)
        {
            var server = lm.LastServer ?? lm.Servers[0];
            Debug.Log($"[DebugLogin] Auto-connecting to {server.ServerName} ({server.URL}:{server.Port})");
            OnServerSelected(server);
            yield return new WaitForSeconds(0.5f);
            lm.ConnectToServer(server);
        }
    }
    #endif

    void OnDestroy()
    {
        if (LoginManager.Instance != null)
        {
            LoginManager.Instance.OnStateChanged      -= OnLoginStateChanged;
            LoginManager.Instance.OnError              -= OnLoginError;
            LoginManager.Instance.OnRoleListReceived   -= OnRoleListReceived;
        }
    }

    // ══════════════════════════════════════════════════════════
    // PANEL SPAWNING
    // ══════════════════════════════════════════════════════════

    void SpawnLoginPanel()
    {
        if (loginPrefab == null) { Debug.LogError("[Scene] loginPrefab null!"); return; }

        _loginPanel = Instantiate(loginPrefab);
        _loginPanel.name = "UILoginChannelInner";
        FixCanvas(_loginPanel);

        _loginCtrl = _loginPanel.GetComponent<LoginController>();
        if (_loginCtrl == null)
            _loginCtrl = _loginPanel.AddComponent<LoginController>();

        _loginCtrl.OnSelectZoneClicked = () => {}; // Not used in new flow
        _loginCtrl.OnRegisterClicked   = ShowRegister;
    }

    void SpawnLoginServerPanel()
    {
        if (_loginServerPanel != null) return;
        if (loginServerPrefab == null) { Debug.LogError("[Scene] loginServerPrefab null!"); return; }

        _loginServerPanel = Instantiate(loginServerPrefab);
        _loginServerPanel.name = "UILoginServer";
        FixCanvas(_loginServerPanel, 15); // Above login

        _loginServerCtrl = _loginServerPanel.GetComponent<LoginServerController>();
        if (_loginServerCtrl == null)
            _loginServerCtrl = _loginServerPanel.AddComponent<LoginServerController>();

        _loginServerCtrl.OnChangeServerClicked = ShowSelectServer;
        _loginServerCtrl.OnEnterGameClicked    = OnEnterGame;
    }

    void SpawnSelectServerPanel()
    {
        if (_selectServerPanel != null) return;
        if (selectServerPrefab == null) { Debug.LogError("[Scene] selectServerPrefab null!"); return; }

        _selectServerPanel = Instantiate(selectServerPrefab);
        _selectServerPanel.name = "UISelectServer";
        FixCanvas(_selectServerPanel, 20); // Above lobby

        // Wire close button — return to lobby
        var btnClose = _selectServerPanel.transform.Find("node/imgBG/btnClose");
        if (btnClose != null)
        {
            var btn = btnClose.GetComponent<Button>();
            if (btn != null)
                btn.onClick.AddListener(CloseSelectServer);
        }

        // Wire server template clicks
        WireSelectServerPanel();
    }

    // ══════════════════════════════════════════════════════════
    // NAVIGATION
    // ══════════════════════════════════════════════════════════

    void ShowLogin()
    {
        SetPanelActive(_loginPanel, true);
        SetPanelActive(_loginServerPanel, false);
        SetPanelActive(_selectServerPanel, false);
        SetPanelActive(selectRoleExistRoot, false);
        SetPanelActive(createRoleRoot, false);
        SetPanelActive(_loginBG, false);
    }

    /// <summary>
    /// Show the lobby screen (UILoginServer) after SDK login.
    /// Auto-selects last/recommended server and displays it.
    /// </summary>
    void ShowLoginServer()
    {
        SpawnLoginServerPanel();

        SetPanelActive(_loginPanel, false);
        SetPanelActive(_loginServerPanel, true);
        SetPanelActive(_selectServerPanel, false);
        SetPanelActive(_loginBG, false);  // No characters on lobby

        _loginServerCtrl?.UpdateServerDisplay();

        Debug.Log("[Scene] Showing LoginServer (lobby)");
    }

    /// <summary>
    /// Show UISelectServer popup (server list with categories).
    /// </summary>
    void ShowSelectServer()
    {
        SpawnSelectServerPanel();
        SetPanelActive(_selectServerPanel, true);
        SetPanelActive(_loginBG, false);  // No characters on server select
        Debug.Log("[Scene] Showing SelectServer popup");
    }

    void CloseSelectServer()
    {
        SetPanelActive(_selectServerPanel, false);
        // Return to lobby
        SetPanelActive(_loginServerPanel, true);
    }

    void ShowRegister()
    {
        Debug.Log("[Scene] Register button clicked — TODO: implement registration panel");
    }

    void ShowSelectRole()
    {
        SetPanelActive(_loginPanel, false);
        SetPanelActive(_loginServerPanel, false);
        SetPanelActive(_selectServerPanel, false);
        SetPanelActive(_loginBG, true);
        SetPanelActive(selectRoleExistRoot, true);
        SetPanelActive(createRoleRoot, false);

        // Explicitly hide UICreateRole_Canvas — it uses ScreenSpaceOverlay and renders on top
        // createRoleRoot may point to the child UICreateRole, so also find the root canvas
        HideCreateRoleCanvas();

        // Setup canvas if spawned from prefab
        if (selectRoleExistRoot != null)
        {
            var canvas = selectRoleExistRoot.GetComponent<Canvas>();
            if (canvas == null) canvas = selectRoleExistRoot.AddComponent<Canvas>();
            if (canvas.renderMode != RenderMode.ScreenSpaceCamera)
            {
                canvas.renderMode = RenderMode.ScreenSpaceCamera;
                canvas.worldCamera = Camera.main;
                canvas.sortingLayerName = "UI";
                canvas.sortingOrder = 10;
            }
            var scaler = selectRoleExistRoot.GetComponent<UnityEngine.UI.CanvasScaler>();
            if (scaler == null)
            {
                scaler = selectRoleExistRoot.AddComponent<UnityEngine.UI.CanvasScaler>();
                scaler.uiScaleMode = UnityEngine.UI.CanvasScaler.ScaleMode.ScaleWithScreenSize;
                scaler.referenceResolution = new Vector2(1280, 720);
                scaler.screenMatchMode = UnityEngine.UI.CanvasScaler.ScreenMatchMode.Expand;
            }
            if (selectRoleExistRoot.GetComponent<UnityEngine.UI.GraphicRaycaster>() == null)
                selectRoleExistRoot.AddComponent<UnityEngine.UI.GraphicRaycaster>();
        }

        // Fix Background_Canvas: ScreenSpaceCamera with low sortOrder
        if (_backgroundCanvas != null)
        {
            var bgCanvas = _backgroundCanvas.GetComponent<Canvas>();
            if (bgCanvas != null && bgCanvas.renderMode == RenderMode.ScreenSpaceOverlay)
            {
                bgCanvas.renderMode = RenderMode.ScreenSpaceCamera;
                bgCanvas.worldCamera = Camera.main;
                bgCanvas.sortingLayerName = "UI";
            }
            if (bgCanvas != null) bgCanvas.sortingOrder = 0;
        }

        // UILoginBG Character canvas: between background and UI
        if (_loginBG != null)
        {
            foreach (var c in _loginBG.GetComponentsInChildren<Canvas>(true))
            {
                if (c.overrideSorting && c.gameObject.name == "Character")
                {
                    c.sortingOrder = 8;
                }
            }
        }

        // Ensure runtime bridge is attached for dynamic role data
        if (selectRoleExistRoot != null && selectRoleExistRoot.GetComponent<SelectRoleRuntimeBridge>() == null)
            selectRoleExistRoot.AddComponent<SelectRoleRuntimeBridge>();

        Debug.Log("[Scene] ShowSelectRole");
    }

    /// <summary>
    /// Explicitly find and deactivate UICreateRole_Canvas by scene search.
    /// Needed because createRoleRoot may point to child UICreateRole, leaving the canvas active.
    /// </summary>
    void HideCreateRoleCanvas()
    {
        var roots = UnityEngine.SceneManagement.SceneManager.GetActiveScene().GetRootGameObjects();
        foreach (var root in roots)
        {
            if (root.name == "UICreateRole_Canvas" || root.name == "UICreateRole")
            {
                if (root.activeSelf)
                {
                    root.SetActive(false);
                    Debug.Log($"[Scene] Explicitly hid {root.name}");
                }
            }
        }
    }

    void ShowCreateRole()
    {
        SetPanelActive(_loginPanel, false);
        SetPanelActive(_loginServerPanel, false);
        SetPanelActive(_selectServerPanel, false);
        SetPanelActive(_loginBG, true);
        SetPanelActive(selectRoleExistRoot, false);

        // Background_Canvas is ScreenSpaceOverlay which renders ON TOP of ScreenSpaceCamera canvases.
        // Switch it to ScreenSpaceCamera with lower sortOrder so it renders BEHIND UICreateRole_Canvas.
        if (_backgroundCanvas != null)
        {
            var bgCanvas = _backgroundCanvas.GetComponent<Canvas>();
            if (bgCanvas != null && bgCanvas.renderMode == RenderMode.ScreenSpaceOverlay)
            {
                bgCanvas.renderMode = RenderMode.ScreenSpaceCamera;
                bgCanvas.worldCamera = Camera.main;
                bgCanvas.sortingLayerName = "UI";
            }
            if (bgCanvas != null)
            {
                bgCanvas.sortingOrder = 0; // Below UILoginBG Character(1) and UICreateRole(10)
                Debug.Log("[Scene] Fixed Background_Canvas: sortOrder=0");
            }
        }

        // Ensure Character sub-canvas in UILoginBG renders above background but below CreateRole UI
        if (_loginBG != null)
        {
            foreach (var c in _loginBG.GetComponentsInChildren<Canvas>(true))
            {
                if (c.overrideSorting && c.gameObject.name == "Character")
                {
                    c.sortingOrder = 8; // Between Background(0) and UICreateRole(10)
                    Debug.Log("[Scene] Character canvas sortOrder → 8");
                }
            }
        }

        // Activate createRoleRoot and ensure its parent canvas is also active
        if (createRoleRoot != null)
        {
            createRoleRoot.SetActive(true);
            // If createRoleRoot is nested under a Canvas that might be inactive, activate up the chain
            var parent = createRoleRoot.transform.parent;
            while (parent != null)
            {
                if (!parent.gameObject.activeSelf)
                {
                    Debug.Log($"[Scene] Activating parent: {parent.name}");
                    parent.gameObject.SetActive(true);
                }
                parent = parent.parent;
            }

            // Ensure runtime bridge is attached for create role flow
            if (createRoleRoot.GetComponent<CreateRoleRuntimeBridge>() == null)
                createRoleRoot.AddComponent<CreateRoleRuntimeBridge>();
        }

        Debug.Log($"[Scene] ShowCreateRole: createRoleRoot={createRoleRoot?.name}, active={createRoleRoot?.activeSelf}");
    }

    // ══════════════════════════════════════════════════════════
    // EVENT HANDLERS
    // ══════════════════════════════════════════════════════════

    void OnServerSelected(ServerInfo server)
    {
        Debug.Log($"[Scene] Server selected: {server.ServerName}");
        var lm = LoginManager.Instance;
        if (lm == null) return;

        lm.SelectedServer = server;

        // Save last selected server
        PlayerPrefs.SetInt("KTO_LastServerID", server.ServerID);
        PlayerPrefs.SetString("KTO_LastServerName", server.ServerName);

        // Close select server popup
        SetPanelActive(_selectServerPanel, false);

        // Update server name on lobby screen
        _loginServerCtrl?.UpdateServerDisplay();

        // Write last server to SDK
        _ = NetworkManager.Instance.SDK.WriteLastServer(server.ServerID,
            lm.PlatformUserID?.Split('_')[0] ?? "");
    }

    /// <summary>
    /// Called when user clicks "Vào giang hồ" on lobby screen.
    /// Connects to the selected game server.
    /// </summary>
    void OnEnterGame()
    {
        var lm = LoginManager.Instance;
        if (lm == null || lm.SelectedServer == null) return;

        Debug.Log($"[Scene] Entering game: {lm.SelectedServer.ServerName}");
        lm.ConnectToServer(lm.SelectedServer);
    }

    void OnLoginStateChanged(LoginState state)
    {
        Debug.Log($"[Scene] Login state: {state}");

        switch (state)
        {
            case LoginState.ServerList:
                // SDK login done, got server list → show lobby screen
                ShowLoginServer();
                break;

            case LoginState.Connecting:
            case LoginState.LoginOn2:
            case LoginState.LoginOn:
                // Connecting to game server — show loading indicator
                break;

            case LoginState.RoleList:
                // Waiting for role list
                break;

            case LoginState.Ready:
                // Role list received — handled in OnRoleListReceived
                break;
        }
    }

    void OnLoginError(string error)
    {
        Debug.LogError($"[Scene] Login error: {error}");
        // TODO: show error dialog
    }

    void OnRoleListReceived(System.Collections.Generic.List<RoleInfo> roles)
    {
        Debug.Log($"[Scene] Got {roles.Count} roles, selectRolePanel={selectRoleExistRoot != null}, createRolePanel={createRoleRoot != null}");

        if (roles.Count > 0 && selectRoleExistRoot != null)
            ShowSelectRole();
        else
            ShowCreateRole();
    }

    // ══════════════════════════════════════════════════════════
    // SELECT SERVER PANEL
    // ══════════════════════════════════════════════════════════
    //
    // ── Architecture ──
    // Server API (/api/servers) trả về flat list servers, mỗi server có:
    //   nStatus: 0=NORMAL, 1=OFFLINE, 2=RECOMMEND, 3=NEW, 4=FULL
    //   + LastServer (field 3) = server gần nhất user đã chơi
    //
    // Client-side grouping (không cần BE hỗ trợ region):
    //   - "Máy chủ của tôi": LastServer + servers user đã có nhân vật
    //   - "Đề cử": servers có status RECOMMEND(2) hoặc NEW(3)
    //   - "Tất cả": toàn bộ server (sau filter)
    //   - Region tabs: nhóm theo REGION_SIZE, CHỈ hiện region có server
    //
    // Filter (cài đặt hiển thị): client-side, KHÔNG gọi API
    //   Checkbox: Mới(3), Đề cử(2), Bảo trì(1), Đầy(4)
    //   → NeedShow() lọc server trước khi hiển thị
    //   → Refresh() rebuild toàn bộ kind list + server list
    //
    // ══════════════════════════════════════════════════════════

    // ── Configurable: số server mỗi nhóm region ──
    private const int REGION_SIZE = 10;

    // ── Kind indices (fixed tabs) ──
    private const int KIND_MY_SERVER  = 1;
    private const int KIND_RECOMMEND  = 2;
    private const int KIND_ALL        = 3;
    private const int KIND_REGION_START = 4; // region tabs start from index 4

    // ── Filter state — controlled by "Cài đặt hiển thị máy chủ" popup ──
    private bool _filterNew = true, _filterRecommend = true,
                 _filterMaintain = true, _filterFull = true;
    private int _kindIndex = KIND_RECOMMEND; // default tab on first open

    // ── Region data — built dynamically from actual server list ──
    private System.Collections.Generic.List<RegionInfo> _regionList
        = new System.Collections.Generic.List<RegionInfo>();

    private class RegionInfo
    {
        public int dwIndex;       // region start ID (e.g. 1, 11, 381)
        public string szName;     // display name (e.g. "1-10", "381-390")
        public System.Collections.Generic.List<ServerInfo> tbServers
            = new System.Collections.Generic.List<ServerInfo>();
    }

    private readonly System.Collections.Generic.List<GameObject> _spawnedKindBtns
        = new System.Collections.Generic.List<GameObject>();
    private readonly System.Collections.Generic.List<GameObject> _spawnedServerBtns
        = new System.Collections.Generic.List<GameObject>();

    // Sprites for kind button selected/normal states (mirrors ButtonGroupTransition)
    private Sprite _kindSpriteNormal;   // btn_tap5_2 — white with teal border
    private Sprite _kindSpriteSelected; // btn_tap5_1 — solid teal
    // Colors from original ButtonGroupTransition component data
    private readonly Color _kindTextNormal   = new Color(0.161f, 0.357f, 0.337f, 1f);
    private readonly Color _kindTextSelected = new Color(0.941f, 0.941f, 0.941f, 1f);

    // ─────────────────────────────────────────────────────────
    //  WireSelectServerPanel — mirrors UISelectServer.lua OnCreate
    // ─────────────────────────────────────────────────────────

    void WireSelectServerPanel()
    {
        if (_selectServerPanel == null) return;
        var root = _selectServerPanel.transform;

        // ── Translate main panel ──
        SetChildText(root, "node/imgBG/txtTitle", "Chọn Máy Chủ");

        // ── Popularity legend ──
        var pop = root.Find("node/imgBG/Content/panelPopularity");
        if (pop != null)
        {
            pop.gameObject.SetActive(true);
            SetChildText(pop, "txtFull", "Đầy");
            SetChildText(pop, "txtNormal", "Thông suốt");
            SetChildText(pop, "txtMaintain", "Bảo trì");
        }

        // ── btnServerSetting → open setting popup (Lua: btnServerSetting onClick) ──
        var btnSetting = root.Find("node/imgBG/Content/btnServerSetting");
        if (btnSetting != null)
        {
            btnSetting.gameObject.SetActive(true);
            var btn = btnSetting.GetComponent<Button>();
            if (btn != null) btn.onClick.AddListener(OpenSetting);
        }

        // ── Wire wndServerSetting popup ──
        WireServerSettingPopup();

        // ── Ensure PanelKindList visible ──
        SetChildActive(root, "node/imgBG/Content/PanelKindList", true);

        // ── Add ScrollRect to PanelKindList/MaskView (original has it, importer skips) ──
        FixKindListScrollRect(root);

        // ── Cache kind button sprites (selected/normal) ──
        // Both must come from the SAME atlas (common atlas, texture e78af3ae).
        // btn_tap5_1 exists in TWO atlases: common (teal=correct) and common_btn (golden=wrong).
        _kindSpriteNormal = LookupSpriteRuntime("btn_tap5_2");
        _kindSpriteSelected = LookupSpriteRuntime("btn_tap5_1", _kindSpriteNormal);

        // ── Refresh = build regions + populate ──
        Refresh();

        if (LoginManager.Instance != null)
            LoginManager.Instance.OnServerListReceived += (_) => Refresh();
    }

    // ─────────────────────────────────────────────────────────
    //  wndServerSetting — mirrors Lua OpenSetting/CloseSetting/ClickSettingOK
    // ─────────────────────────────────────────────────────────

    void WireServerSettingPopup()
    {
        var wnd = _selectServerPanel.transform.Find("node/wndServerSetting");
        if (wnd == null) return;
        wnd.gameObject.SetActive(false);

        // Translate
        SetChildText(wnd, "imgBG/txtTitle", "Cài đặt hiển thị máy chủ");
        SetChildText(wnd, "txtDes", "Chọn loại máy chủ muốn hiển thị");
        SetChildText(wnd, "txtTips", "※Cài đặt này sẽ đưa ứng dụng đến tất cả máy chủ");
        SetChildText(wnd, "btnOK/Text", "Đồng ý");

        SetChildText(wnd, "ToggleServerList/ToggleNew/Label", "Máy chủ mới");
        SetChildText(wnd, "ToggleServerList/ToggleRecommend/Label", "Đề cử");
        SetChildText(wnd, "ToggleServerList/ToggleMaintain/Label", "Bảo trì");
        SetChildText(wnd, "ToggleServerList/ToggleFull/Label", "Đầy");

        // Hide WhiteList (Lua: self.pPanel:SetActive(self.ToggleWhiteList, false))
        SetChildActive(wnd, "ToggleServerList/ToggleWhiteList", false);

        // Fix toggle graphics (importer doesn't wire them)
        FixToggleGraphic(wnd, "ToggleServerList/ToggleNew");
        FixToggleGraphic(wnd, "ToggleServerList/ToggleRecommend");
        FixToggleGraphic(wnd, "ToggleServerList/ToggleMaintain");
        FixToggleGraphic(wnd, "ToggleServerList/ToggleFull");

        // btnOK = ClickSettingOK + CloseSetting
        WireButton(wnd, "btnOK", () => { ClickSettingOK(); CloseSetting(); });
        WireButton(wnd, "imgBG/btnClose", CloseSetting);
        WireButton(wnd, "ClickEmptyToClose", CloseSetting);
    }

    // Lua: OpenSetting — restore toggle states then show
    void OpenSetting()
    {
        var wnd = _selectServerPanel.transform.Find("node/wndServerSetting");
        if (wnd == null) return;
        SetToggle(wnd, "ToggleServerList/ToggleNew", _filterNew);
        SetToggle(wnd, "ToggleServerList/ToggleRecommend", _filterRecommend);
        SetToggle(wnd, "ToggleServerList/ToggleMaintain", _filterMaintain);
        SetToggle(wnd, "ToggleServerList/ToggleFull", _filterFull);
        wnd.gameObject.SetActive(true);
    }

    void CloseSetting()
    {
        var wnd = _selectServerPanel.transform.Find("node/wndServerSetting");
        if (wnd != null) wnd.gameObject.SetActive(false);
    }

    // Lua: ClickSettingOK — read toggles, save, refresh
    void ClickSettingOK()
    {
        var wnd = _selectServerPanel.transform.Find("node/wndServerSetting");
        if (wnd == null) return;
        _filterNew       = GetToggle(wnd, "ToggleServerList/ToggleNew");
        _filterRecommend = GetToggle(wnd, "ToggleServerList/ToggleRecommend");
        _filterMaintain  = GetToggle(wnd, "ToggleServerList/ToggleMaintain");
        _filterFull      = GetToggle(wnd, "ToggleServerList/ToggleFull");
        Debug.Log($"[Filter] Applied: New={_filterNew} Recommend={_filterRecommend} Maintain={_filterMaintain} Full={_filterFull}");

        // Count visible servers to give feedback
        int totalVisible = 0;
        var lm = LoginManager.Instance;
        if (lm?.Servers != null)
        {
            foreach (var s in lm.Servers)
                if (NeedShow(s)) totalVisible++;
        }
        Debug.Log($"[Filter] Visible servers: {totalVisible} / {lm?.Servers?.Count ?? 0}");

        Refresh();
    }

    // ─────────────────────────────────────────────────────────
    //  Refresh — rebuild toàn bộ UI từ dữ liệu server
    //
    //  Flow:
    //  1. Lấy danh sách server từ LoginManager (đã fetch từ API)
    //  2. Apply NeedShow filter (theo checkbox cài đặt)
    //  3. Nhóm server vào regions ĐỘNG — chỉ tạo region có server
    //  4. Build kind list: [Của tôi, Đề cử, Tất cả, Region1, Region2, ...]
    //  5. Auto-select tab thông minh
    //
    //  Không gọi API — filter hoàn toàn client-side.
    //  API chỉ gọi 1 lần khi login, trả về full server list.
    // ─────────────────────────────────────────────────────────

    void Refresh()
    {
        var lm = LoginManager.Instance;
        if (lm == null || lm.Servers == null) return;

        // ── Build region map — CHỈ từ server thực, không pre-create ──
        var regionMap = new System.Collections.Generic.Dictionary<int, RegionInfo>();

        foreach (var s in lm.Servers)
        {
            // Apply filter checkboxes (Cài đặt hiển thị máy chủ)
            if (!NeedShow(s)) continue;

            // Dynamic region key: serverID 1-10 → key 1, 11-20 → key 11, 381-390 → key 381
            int regionKey = ((s.ServerID - 1) / REGION_SIZE) * REGION_SIZE + 1;
            if (!regionMap.ContainsKey(regionKey))
            {
                int regionEnd = regionKey + REGION_SIZE - 1;
                regionMap[regionKey] = new RegionInfo
                {
                    dwIndex = regionKey,
                    szName = $"{regionKey}-{regionEnd}"
                };
            }
            regionMap[regionKey].tbServers.Add(s);
        }

        // Sort regions by dwIndex descending (newest servers first)
        _regionList.Clear();
        foreach (var r in regionMap.Values)
            _regionList.Add(r);
        _regionList.Sort((a, b) => b.dwIndex.CompareTo(a.dwIndex));

        // Rebuild kind list (left panel)
        RebuildKindList();

        // ── Smart auto-select ──
        int maxKind = KIND_REGION_START - 1 + _regionList.Count;
        if (_kindIndex < 1 || _kindIndex > maxKind)
        {
            // First open: pick best tab
            if (lm.LastServer != null)
                _kindIndex = KIND_MY_SERVER;    // có server gần đây → chọn "Của tôi"
            else if (HasRecommendServers())
                _kindIndex = KIND_RECOMMEND;    // có server đề cử → chọn "Đề cử"
            else
                _kindIndex = KIND_ALL;          // fallback → "Tất cả"
        }
        SelectKind(_kindIndex);
    }

    /// <summary>
    /// Check if any visible servers have RECOMMEND or NEW status.
    /// </summary>
    bool HasRecommendServers()
    {
        var lm = LoginManager.Instance;
        if (lm?.Servers == null) return false;
        foreach (var s in lm.Servers)
        {
            if (!NeedShow(s)) continue;
            if (s.Status == LoginProtocol.STATUS_RECOMMEND || s.Status == LoginProtocol.STATUS_NEW)
                return true;
        }
        return false;
    }

    // ─────────────────────────────────────────────────────────
    //  NeedShow — client-side filter theo checkbox "Cài đặt hiển thị"
    //
    //  Logic:
    //    ☑ Tất cả 4 checkbox checked → hiện TẤT CẢ server (kể cả Normal)
    //    ☐ Có checkbox nào uncheck → CHỈ hiện server có status đã check
    //
    //  Mapping:
    //    ☑ Máy chủ mới  → STATUS_NEW (3)
    //    ☑ Đề cử        → STATUS_RECOMMEND (2)
    //    ☑ Bảo trì      → STATUS_OFFLINE (1) + STATUS_MAINTAIN (5)
    //    ☑ Đầy          → STATUS_FULL (4)
    //    STATUS_NORMAL (0) → chỉ hiện khi tất cả 4 checkbox ON
    // ─────────────────────────────────────────────────────────
    bool NeedShow(ServerInfo s)
    {
        // All 4 checked → no filter, show everything including Normal
        if (_filterNew && _filterRecommend && _filterMaintain && _filterFull)
            return true;

        // Selective mode — only show status types that are checked
        if (_filterNew && s.Status == LoginProtocol.STATUS_NEW) return true;
        if (_filterRecommend && s.Status == LoginProtocol.STATUS_RECOMMEND) return true;
        if (_filterFull && s.Status == LoginProtocol.STATUS_FULL) return true;
        if (_filterMaintain && (s.Status == LoginProtocol.STATUS_OFFLINE ||
            s.Status == LoginProtocol.STATUS_MAINTAIN)) return true;

        return false;
    }

    // ─────────────────────────────────────────────────────────
    //  KindList (left panel) — tab categories
    //
    //  Tab layout:
    //    [1] Máy chủ của tôi  — server gần đây / đã có nhân vật
    //    [2] Đề cử            — server status RECOMMEND(2) + NEW(3)
    //    [3] Tất cả           — toàn bộ server (sau filter)
    //    [4+] 381-390, etc.   — nhóm theo REGION_SIZE, chỉ hiện nếu có data
    // ─────────────────────────────────────────────────────────

    void RebuildKindList()
    {
        var kindListT = _selectServerPanel.transform.Find(
            "node/imgBG/Content/PanelKindList/MaskView/List");
        if (kindListT == null) return;

        var tmplT = kindListT.Find("KindTemplate");
        if (tmplT == null) return;
        tmplT.gameObject.SetActive(false);

        foreach (var go in _spawnedKindBtns)
            if (go != null) Object.Destroy(go);
        _spawnedKindBtns.Clear();

        // Fixed tabs
        CreateKindButton(kindListT, tmplT.gameObject, "Máy chủ của tôi", KIND_MY_SERVER);
        CreateKindButton(kindListT, tmplT.gameObject, "Đề cử", KIND_RECOMMEND);
        CreateKindButton(kindListT, tmplT.gameObject, "Tất cả", KIND_ALL);

        // Dynamic region tabs — only regions that have visible servers
        for (int i = 0; i < _regionList.Count; i++)
        {
            CreateKindButton(kindListT, tmplT.gameObject,
                _regionList[i].szName, KIND_REGION_START + i);
        }
    }

    void CreateKindButton(Transform parent, GameObject template, string label, int index)
    {
        var btn = Instantiate(template, parent);
        btn.SetActive(true);

        var txt = btn.GetComponentInChildren<Text>();
        if (txt != null)
        {
            txt.text = label;
            txt.color = _kindTextNormal; // default normal color
        }

        int idx = index;
        var button = btn.GetComponent<Button>();
        if (button != null)
        {
            // Original uses SpriteSwap transition (m_Transition=2)
            // But we handle selection manually in SelectKind() so keep ColorTint disabled
            button.transition = Selectable.Transition.None;
            button.onClick.AddListener(() => SelectKind(idx));
        }

        _spawnedKindBtns.Add(btn);
    }

    /// <summary>
    /// Tab selected — update button visuals + populate server list.
    /// Maps kindIndex to data source:
    ///   KIND_MY_SERVER(1) → LastServer + servers with characters
    ///   KIND_RECOMMEND(2) → status RECOMMEND + NEW
    ///   KIND_ALL(3)       → all visible servers
    ///   KIND_REGION_START(4)+ → specific region
    /// </summary>
    void SelectKind(int index)
    {
        _kindIndex = index;

        // ── Update button visuals ──
        // Map kindIndex → button list index
        // Buttons: [0]=KIND_MY_SERVER(1), [1]=KIND_RECOMMEND(2), [2]=KIND_ALL(3), [3+]=regions
        for (int i = 0; i < _spawnedKindBtns.Count; i++)
        {
            var go = _spawnedKindBtns[i];
            if (go == null) continue;
            int btnKindIndex = KindIndexForButton(i);
            bool isSel = btnKindIndex == index;
            var img = go.GetComponent<Image>();
            if (img != null && _kindSpriteNormal != null && _kindSpriteSelected != null)
                img.sprite = isSel ? _kindSpriteSelected : _kindSpriteNormal;
            var txt = go.GetComponentInChildren<Text>();
            if (txt != null)
                txt.color = isSel ? _kindTextSelected : _kindTextNormal;
        }

        // ── Populate server list based on selected tab ──
        switch (index)
        {
            case KIND_MY_SERVER:
                UpdateMyServer();
                break;
            case KIND_RECOMMEND:
                UpdateRecommend();
                break;
            case KIND_ALL:
                UpdateAllServers();
                break;
            default:
                int regionIdx = index - KIND_REGION_START;
                if (regionIdx >= 0 && regionIdx < _regionList.Count)
                    UpdateRegionServer(_regionList[regionIdx].tbServers);
                else
                    PopulateServerList(new System.Collections.Generic.List<ServerInfo>());
                break;
        }
    }

    /// <summary>
    /// Convert button list index (0-based) to kindIndex.
    /// </summary>
    int KindIndexForButton(int buttonIndex)
    {
        // Buttons 0,1,2 = fixed tabs (1,2,3)
        if (buttonIndex < 3) return buttonIndex + 1;
        // Buttons 3+ = region tabs
        return KIND_REGION_START + (buttonIndex - 3);
    }

    // ─────────────────────────────────────────────────────────
    //  UpdateMyServer — Lua line 229-249
    //  Shows servers where player has characters
    // ─────────────────────────────────────────────────────────

    void UpdateMyServer()
    {
        // We don't have AccSerInfo (player character data per server) yet.
        // Show LastServer if available, otherwise empty.
        var lm = LoginManager.Instance;
        var myServers = new System.Collections.Generic.List<ServerInfo>();

        if (lm?.LastServer != null)
        {
            foreach (var s in lm.Servers)
                if (s.ServerID == lm.LastServer.ServerID && NeedShow(s))
                    myServers.Add(s);
        }

        PopulateServerList(myServers);
    }

    // ─────────────────────────────────────────────────────────
    //  UpdateRecommend — Tab "Đề cử"
    //  Hiển thị: RECOMMEND(2) + NEW(3) servers
    //  BE quyết định server nào là RECOMMEND bằng nStatus field
    // ─────────────────────────────────────────────────────────

    void UpdateRecommend()
    {
        var lm = LoginManager.Instance;
        var result = new System.Collections.Generic.List<ServerInfo>();

        if (lm?.Servers != null)
        {
            foreach (var s in lm.Servers)
            {
                if (!NeedShow(s)) continue;
                if (s.Status == LoginProtocol.STATUS_RECOMMEND ||
                    s.Status == LoginProtocol.STATUS_NEW)
                    result.Add(s);
            }
        }

        PopulateServerList(result);
    }

    // ─────────────────────────────────────────────────────────
    //  UpdateAllServers — Tab "Tất cả"
    //  Hiển thị TOÀN BỘ server (sau NeedShow filter)
    //  Sort by ServerOrder descending (mới nhất trước)
    // ─────────────────────────────────────────────────────────

    void UpdateAllServers()
    {
        var lm = LoginManager.Instance;
        var result = new System.Collections.Generic.List<ServerInfo>();

        if (lm?.Servers != null)
        {
            foreach (var s in lm.Servers)
            {
                if (NeedShow(s))
                    result.Add(s);
            }
            // Sort by ServerOrder descending — newest servers first
            result.Sort((a, b) => b.ServerOrder.CompareTo(a.ServerOrder));
        }

        PopulateServerList(result);
    }

    // ─────────────────────────────────────────────────────────
    //  UpdateRegionServer — Tab region (e.g. "381-390")
    //  Hiển thị servers trong 1 nhóm region cụ thể
    // ─────────────────────────────────────────────────────────

    void UpdateRegionServer(System.Collections.Generic.List<ServerInfo> regionServers)
    {
        PopulateServerList(regionServers);
    }

    // ─────────────────────────────────────────────────────────
    //  PopulateServerList — mirrors Lua SetElementInfo
    // ─────────────────────────────────────────────────────────

    void PopulateServerList(System.Collections.Generic.List<ServerInfo> servers)
    {
        var listT = _selectServerPanel.transform.Find(
            "node/imgBG/Content/PanelServerList/MaskView/List");
        if (listT == null) return;

        var tmplT = listT.Find("ServerTemplate");
        if (tmplT == null) return;
        tmplT.gameObject.SetActive(false);

        foreach (var go in _spawnedServerBtns)
            if (go != null) Object.Destroy(go);
        _spawnedServerBtns.Clear();

        foreach (var server in servers)
        {
            var btn = Instantiate(tmplT.gameObject, listT);
            btn.SetActive(true);

            // Lua: pPanel:Label_SetText("ServerIndex", dwIndex .. " Máy chủ")
            SetChildText(btn.transform, "ServerIndex",
                $"{(server.ServerOrder > 0 ? server.ServerOrder : server.ServerID)} Máy chủ");

            // Lua: pPanel:Label_SetText("ServerName", tbServer.szName)
            SetChildText(btn.transform, "ServerName", server.ServerName);

            // Lua: pPanel:Label_SetText("ServerRoleLevel", self:GetServerRoleLevelInfo(...))
            // No role data yet → empty
            SetChildText(btn.transform, "ServerRoleLevel", "");

            // Lua: SetElementInfo — status flag logic
            string flagText = "";
            bool flagGreen = false, flagRed = false, flagGray = false;

            switch (server.Status)
            {
                case LoginProtocol.STATUS_NEW:
                    flagText = "Mới"; flagGreen = true;
                    break;
                case LoginProtocol.STATUS_OFFLINE:
                case LoginProtocol.STATUS_MAINTAIN:
                    flagText = "Bảo trì"; flagGray = true;
                    break;
                case LoginProtocol.STATUS_RECOMMEND:
                    flagText = "Đề nghị"; flagGreen = true;
                    break;
                case LoginProtocol.STATUS_FULL:
                    flagText = "Đầy"; flagRed = true;
                    break;
                case LoginProtocol.STATUS_NORMAL:
                default:
                    flagText = "Thông suốt"; flagGreen = true;
                    break;
            }

            SetChildText(btn.transform, "ServerFlag", flagText);
            SetChildActive(btn.transform, "ServerFlagGreen", flagGreen);
            SetChildActive(btn.transform, "ServerFlagRed", flagRed);
            SetChildActive(btn.transform, "ServerFlagGray", flagGray);
            // imgNew badge: hide always — sprite not imported, status shown in flag text
            SetChildActive(btn.transform, "imgNew", false);

            // Wire click — Lua: UpdateServerShow + save LastServerID + close
            var serverRef = server;
            var button = btn.GetComponent<Button>();
            if (button != null)
            {
                button.onClick.AddListener(() =>
                {
                    Debug.Log($"[SelectServer] Selected: {serverRef.ServerName}");
                    OnServerSelected(serverRef);
                });
            }

            _spawnedServerBtns.Add(btn);
        }

        // Lua: self.pPanel:SetActive(self.NotInfo, isEmpty)
        SetChildActive(_selectServerPanel.transform,
            "node/imgBG/Content/PanelServerList/NotInfo", servers.Count == 0);

        // Translate NotInfo text
        SetChildText(_selectServerPanel.transform,
            "node/imgBG/Content/PanelServerList/NotInfo/Text", "Không có thông tin");

        Debug.Log($"[Scene] Populated {servers.Count} servers");
    }

    // ── Shared helpers ──

    void SetChildText(Transform parent, string path, string text)
    {
        var child = parent.Find(path);
        if (child == null) return;
        var t = child.GetComponent<Text>();
        if (t != null) t.text = text;
    }

    static void SetChildActive(Transform parent, string path, bool active)
    {
        var child = parent.Find(path);
        if (child != null) child.gameObject.SetActive(active);
    }

    void FixToggleGraphic(Transform root, string path)
    {
        var t = root.Find(path);
        if (t == null) return;
        var toggle = t.GetComponent<Toggle>();
        if (toggle == null || toggle.graphic != null) return;
        var checkmark = t.Find("Background/Checkmark");
        if (checkmark != null)
            toggle.graphic = checkmark.GetComponent<Graphic>();
    }

    void SetToggle(Transform root, string path, bool isOn)
    {
        var t = root.Find(path);
        if (t == null) return;
        var tog = t.GetComponent<Toggle>();
        if (tog != null) tog.isOn = isOn;
    }

    bool GetToggle(Transform root, string path)
    {
        var t = root.Find(path);
        if (t == null) return true;
        var tog = t.GetComponent<Toggle>();
        return tog != null ? tog.isOn : true;
    }

    void WireButton(Transform root, string path, System.Action action)
    {
        var child = root.Find(path);
        if (child == null) return;
        var btn = child.GetComponent<Button>();
        if (btn != null) btn.onClick.AddListener(() => action());
    }

    /// <summary>
    /// Add ScrollRect to PanelKindList/MaskView — original bundle has it,
    /// but importer doesn't emit custom MonoBehaviour (ScrollRect).
    /// Also add ScrollRect to PanelServerList/MaskView.
    /// </summary>
    void FixKindListScrollRect(Transform root)
    {
        // Kind list scrollrect
        var kindMask = root.Find("node/imgBG/Content/PanelKindList/MaskView");
        if (kindMask != null && kindMask.GetComponent<ScrollRect>() == null)
        {
            var sr = kindMask.gameObject.AddComponent<ScrollRect>();
            sr.horizontal = false;
            sr.vertical = true;
            sr.movementType = ScrollRect.MovementType.Clamped;
            sr.inertia = true;
            sr.decelerationRate = 0.135f;
            sr.scrollSensitivity = 1f;
            var listT = kindMask.Find("List");
            if (listT != null)
                sr.content = listT.GetComponent<RectTransform>();
        }

        // Server list scrollrect
        var serverMask = root.Find("node/imgBG/Content/PanelServerList/MaskView");
        if (serverMask != null && serverMask.GetComponent<ScrollRect>() == null)
        {
            var sr = serverMask.gameObject.AddComponent<ScrollRect>();
            sr.horizontal = false;
            sr.vertical = true;
            sr.movementType = ScrollRect.MovementType.Clamped;
            sr.inertia = true;
            sr.decelerationRate = 0.135f;
            sr.scrollSensitivity = 1f;
            var listT = serverMask.Find("List");
            if (listT != null)
                sr.content = listT.GetComponent<RectTransform>();
        }
    }

    /// <summary>
    /// Look up a sprite by name from the project at runtime.
    /// When sameAtlasAs is provided, prefer a sprite whose texture matches
    /// (avoids cross-atlas name collisions: e.g. btn_tap5_1 exists in both
    /// "common" atlas (teal) and "common_btn" atlas (golden)).
    /// </summary>
    static Sprite LookupSpriteRuntime(string spriteName, Sprite sameAtlasAs = null)
    {
        #if UNITY_EDITOR
        Sprite fallback = null;
        string[] guids = UnityEditor.AssetDatabase.FindAssets(
            $"{spriteName} t:Sprite", new[] { "Assets/Sprite" });
        foreach (var guid in guids)
        {
            string path = UnityEditor.AssetDatabase.GUIDToAssetPath(guid);
            // Load all sub-assets (for .asset atlas files)
            var objs = UnityEditor.AssetDatabase.LoadAllAssetsAtPath(path);
            foreach (var obj in objs)
            {
                if (obj is Sprite sp && sp.name == spriteName)
                {
                    // If same-atlas matching requested, prefer texture match
                    if (sameAtlasAs != null && sameAtlasAs.texture != null
                        && sp.texture == sameAtlasAs.texture)
                        return sp;
                    if (fallback == null) fallback = sp;
                }
            }
            // Try direct load (for .png files)
            var direct = UnityEditor.AssetDatabase.LoadAssetAtPath<Sprite>(path);
            if (direct != null && direct.name == spriteName)
            {
                if (sameAtlasAs != null && sameAtlasAs.texture != null
                    && direct.texture == sameAtlasAs.texture)
                    return direct;
                if (fallback == null) fallback = direct;
            }
        }
        return fallback;
        #else
        return null;
        #endif
    }

    // ══════════════════════════════════════════════════════════
    // HELPERS
    // ══════════════════════════════════════════════════════════

    /// <summary>
    /// Imported prefabs have nested Canvas components set to WorldSpace (from bundle data).
    /// These override the parent ScreenSpaceCamera canvas and render off-screen.
    /// Fix: disable any child Canvas that is WorldSpace so UI inherits the parent's render mode.
    /// </summary>

    static void SetPanelActive(GameObject panel, bool active)
    {
        if (panel != null) panel.SetActive(active);
    }

    static GameObject LoadPrefab(string name)
    {
        #if UNITY_EDITOR
        string path = $"Assets/Prefabs/Imported/{name}.prefab";
        var prefab = UnityEditor.AssetDatabase.LoadAssetAtPath<GameObject>(path);
        if (prefab != null) return prefab;
        #endif
        return Resources.Load<GameObject>(name);
    }

    static GameObject FindCanvasRoot(string name)
    {
        var roots = UnityEngine.SceneManagement.SceneManager.GetActiveScene().GetRootGameObjects();
        foreach (var root in roots)
        {
            if (root.name == name) return root;
            var found = root.transform.Find(name);
            if (found != null) return found.gameObject;
        }
        var allGOs = Resources.FindObjectsOfTypeAll<GameObject>();
        foreach (var go in allGOs)
        {
            if (go.name == name && go.scene.IsValid()) return go;
        }
        return null;
    }

    void EnsureSingleton<T>(string goName) where T : MonoBehaviour
    {
        if (Object.FindObjectOfType<T>() == null)
        {
            var go = new GameObject(goName);
            go.AddComponent<T>();
        }
    }

    /// <summary>
    /// Bundle canvases use renderMode=1 (ScreenSpace-Camera) but no camera assigned.
    /// Switch to Overlay so they render. Also set sorting order so panels layer correctly.
    /// </summary>
    static void FixCanvas(GameObject panel, int sortingOrder = 10)
    {
        var canvas = panel.GetComponent<Canvas>();
        if (canvas != null)
        {
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            canvas.sortingOrder = sortingOrder;
        }

        var scaler = panel.GetComponent<CanvasScaler>();
        if (scaler != null)
        {
            scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
            scaler.referenceResolution = new Vector2(1280f, 720f);
            scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;
            scaler.matchWidthOrHeight = 1f;
        }
    }
}
