using UnityEngine;
using UnityEngine.UI;
using MoonSharp.Interpreter;
using System.Collections.Generic;

/// <summary>
/// Main Lua Engine — loads all Lua files, creates windows, binds click handlers.
/// Attach this to Canvas in scene.
/// 
/// Architecture (mirrors game original):
///   Ui:CreateWindow(name) → creates a window table with tbControls, tbOnClick
///   Ui:OpenWindow(name)   → SetActive(window, true) + calls OnOpen()
///   Ui:CloseWindow(name)  → SetActive(window, false) + calls OnClose()
///   Button clicks          → lookup tbOnClick[btnName] + call with self
/// </summary>
public class LuaEngine : MonoBehaviour
{
    // Plain field (NOT [SerializeField]) so the array below is always authoritative —
    // otherwise Unity restores a stale list from the scene/prefab serialization and our
    // edits here have no effect at runtime.
    private string[] _loadOrder = {
        // NOTE: Faction.lua intentionally NOT loaded — it depends on Lib:LoadTabFileEx
        // (game-only tab file loader) which we don't stub. Without that, Faction:Init()
        // exits early leaving Faction.tbFactionInfo == nil, then UICreateRole crashes
        // on Faction:IsFactionOpen / GetSeries. Our C# Faction stub in LuaGameStubs.cs
        // provides the same surface (MAX_FACTION_COUNT, IsFactionOpen, GetSeries,
        // IsOpenSex, GetIcon, GetDesc, GetRadarChartPath, GetName) and is used instead.

        // Login / select-role flow
        "UILoginBG",
        "UISelectRoleExist",
        "UICreateRole",
        // HUD windows
        "UIHud",
        "UIHudRightBottom",
        "UIHudRightSkill",
        "UIHudChat",
        "UIHudLeftFrameExt",
        "UIHudMinimap",
        "UIHudRightTopWelfare",
        "UIHudRightCenter",
        "UIHudLeftPanelTask",
        "UIHudLeftPanelTeam",
        "UIHudLeftPanelFuben",
        "UIHudLeftPanelBattle",
        "UIHudLeftPanelDungeon",
        "UIHudLeftPanelFunnyPlay",
        "UIHudLeftPanelWedding",
        "UIHudLeftPanelXiakedao",
        "UIHudHanWuYiJi",
        "UIHudDomainScore",
        "UIHudLegionDomainScore",
        "UIHudTieFuChengScore",
        "UIHudOutputInfo",
        "UIHudTeamMember",
        "UIHUD_Tip"
    };

    private Script _lua;
    private Transform _canvas;

    // Static access for bridges that need to call into Lua callbacks
    // without carrying a Script reference through every constructor.
    public static LuaEngine Instance { get; private set; }
    public Script Script { get { return _lua; } }

    // Window registry: name → { table, bridge, gameObject }
    private Dictionary<string, LuaWindowInfo> _windows = new Dictionary<string, LuaWindowInfo>();

    private class LuaWindowInfo
    {
        public Table windowTable;
        public LuaUIBridge bridge;
        public GameObject root;
        public Dictionary<string, Closure> onClickHandlers;
    }

    void Awake()
    {
        Instance = this;
        // Find the Canvas — use parent if LuaEngine is child of Canvas, else search
        var canvas = GetComponentInParent<Canvas>();
        _canvas = canvas != null ? canvas.transform : transform;
        InitializeLua();
    }

    void OnDestroy()
    {
        if (Instance == this) Instance = null;
    }

    void InitializeLua()
    {
        // Register proxy types
        UserData.RegisterType<LuaUIBridge>();
        UserData.RegisterType<LuaGameObjectProxy>();
        UserData.RegisterType<LuaTransformProxy>();
        UserData.RegisterType<LuaRectTransformProxy>();
        UserData.RegisterType<LuaRect>();
        UserData.RegisterType<LuaTextProxy>();
        UserData.RegisterType<LuaAnimatorProxy>();
        
        _lua = new Script(CoreModules.Preset_Complete);
        Debug.Log("[LuaEngine] XLua backend ready (MoonSharp-compat shim)");

        // Register game stubs
        LuaGameStubs.RegisterAll(_lua);

        // Phase A "fake gate": expose this Lua script to LuaEventBridge so
        // CMD_SPR_FIRE_EVENT packets from server can be replayed into Lua.
        KTO.Network.LuaEventBridge.Bind(_lua);
        
        // Setup Ui framework
        SetupUiFramework();
        
        // Load all Lua files
        int loaded = 0;
        int failed = 0;
        foreach (var name in _loadOrder)
        {
            if (LoadLuaFile(name))
                loaded++;
            else
                failed++;
        }
        
        Debug.Log($"[LuaEngine] Loaded {loaded}/{_loadOrder.Length} Lua files ({failed} skipped)");
        
        // Merge tbControls keys into window tables (game engine normally does this)
        foreach (var kvp in _windows)
        {
            var wndTable = kvp.Value.windowTable;
            var controls = wndTable.Get("tbControls");
            if (controls.Type == DataType.Table)
            {
                foreach (var kv in controls.Table.Pairs)
                {
                    if (wndTable.Get(kv.Key).Type == DataType.Nil)
                        wndTable.Set(kv.Key, kv.Value);
                }
            }
        }
        
        // Call OnCreate + OnOpen for all windows. UICreateRole now runs both:
        // OnCreate populates self.FactionView (Ui:NewScrollView wraps the
        // existing baked Faction_<key> children) + tbFaction2Idx +
        // nCurFactionId, which the toggle handlers (Metal/Wood/.../Fire and
        // sex toggles) need to function. OnOpen calls ChooseNewFaction →
        // FactionView:SelectElement → _SelectFaction, which dynamically
        // re-renders the right-panel radar / series text / faction title via
        // pPanel:Sprite_SetSprite + Label_SetText. The bake remains as the
        // edit-mode visual; lua overrides it at play-time, matching the
        // real game's runtime behavior.
        var skipOnCreate = new HashSet<string> {
        };
        foreach (var kvp in _windows)
        {
            if (!skipOnCreate.Contains(kvp.Key))
                CallWindowMethod(kvp.Key, "OnCreate");
        }
        // Windows that require parameters in OnOpen - skip auto-open
        var skipOnOpen = new HashSet<string> {
            "UIHUD_Tip", "UIHudOutputInfo", "UIHudLeftPanelXiakedao",
            "UIHudTieFuChengScore",
            // SelectRoleExist needs a role list from the server (tbRoleList).
            // Without it, OnOpen errors at the ipairs(self.tbRoleList) loop.
            "UISelectRoleExist",
        };
        foreach (var kvp in _windows)
        {
            if (!skipOnOpen.Contains(kvp.Key))
                CallWindowMethod(kvp.Key, "OnOpen");
        }

        // Bind all click handlers from Lua (Button.OnClick / Toggle.OnValueChanged).
        // UICreateRole now binds via lua: btnRandRoleName, btnArrowUp/Down,
        // btnFemale2/Male2, plus the 5-element series toggles + sex toggles.
        // btnCreateRole and btnReturn remain SelectRoleSceneNav's job in
        // legacy MainUIScene mode (its Wire() RemoveAllListeners on those
        // two specific buttons after lua binds, which is fine — popup-toggle
        // wins for legacy, lua wins for standalone CreateRoleScene).
        var skipBindings = new HashSet<string> {
        };
        int boundButtons = 0;
        int boundToggles = 0;
        foreach (var kvp in _windows)
        {
            if (skipBindings.Contains(kvp.Key)) continue;
            boundButtons += BindClickHandlers(kvp.Key);
            boundToggles += BindToggleHandlers(kvp.Key);
        }

        Debug.Log($"[LuaEngine] Bound {boundButtons} button click + {boundToggles} toggle handlers from Lua");
    }

    /// <summary>
    /// Setup Ui global table with CreateWindow/OpenWindow/CloseWindow
    /// </summary>
    void SetupUiFramework()
    {
        var ui = _lua.Globals.Get("Ui");
        Table uiTable;
        if (ui.Type == DataType.Table)
            uiTable = ui.Table;
        else
        {
            uiTable = new Table(_lua);
            _lua.Globals["Ui"] = uiTable;
        }

        // Ui:CreateWindow(name) → returns window table + registers it
        uiTable["CreateWindow"] = DynValue.NewCallback((ctx, args) => {
            // args[0] = Ui table (self), args[1] = window name
            string wndName = args.Count > 1 ? args[1].CastToString() : args[0].CastToString();
            return DynValue.NewTable(BuildWindowTable(wndName));
        });

        // Ui:CreateClass(name, baseClass) — also used by panels (Task, Team, ...).
        // Same registration semantics for our purposes: bind a lua table to the GO.
        uiTable["CreateClass"] = DynValue.NewCallback((ctx, args) => {
            string wndName = args.Count > 1 ? args[1].CastToString() : args[0].CastToString();
            return DynValue.NewTable(BuildWindowTable(wndName));
        });
        
        // Ui:OpenWindow(name, ...)
        uiTable["OpenWindow"] = DynValue.NewCallback((ctx, args) => {
            string name = args.Count > 1 ? args[1].CastToString() : args[0].CastToString();
            Debug.Log($"[Lua] Ui:OpenWindow(\"{name}\")");
            
            if (_windows.TryGetValue(name, out var info) && info.root != null)
            {
                info.root.SetActive(true);
                CallWindowMethod(name, "OnOpen");
            }
            return DynValue.Nil;
        });
        
        // Ui:CloseWindow(name)
        uiTable["CloseWindow"] = DynValue.NewCallback((ctx, args) => {
            string name = args.Count > 1 ? args[1].CastToString() : args[0].CastToString();
            Debug.Log($"[Lua] Ui:CloseWindow(\"{name}\")");
            
            if (_windows.TryGetValue(name, out var info) && info.root != null)
            {
                CallWindowMethod(name, "OnClose");
                info.root.SetActive(false);
            }
            return DynValue.Nil;
        });
        
        // Ui:WindowVisible(name) → bool
        uiTable["WindowVisible"] = DynValue.NewCallback((ctx, args) => {
            string name = args.Count > 1 ? args[1].CastToString() : args[0].CastToString();
            if (_windows.TryGetValue(name, out var info) && info.root != null)
                return DynValue.NewBoolean(info.root.activeSelf);
            return DynValue.False;
        });

        // Ui:OpenWindowWithCallback — stub  
        uiTable["OpenWindowWithCallback"] = DynValue.NewCallback((ctx, args) => {
            string name = args.Count > 1 ? args[1].CastToString() : args[0].CastToString();
            Debug.Log($"[Lua] Ui:OpenWindowWithCallback(\"{name}\")");
            return DynValue.Nil;
        });

        // Ui:CreatePanel — stub
        uiTable["CreatePanel"] = DynValue.NewCallback((ctx, args) => {
            var panel = new Table(_lua);
            panel["ResetMapPoints"] = DynValue.NewCallback((c,a) => DynValue.Nil);
            panel["ShowMapPoints"] = DynValue.NewCallback((c,a) => DynValue.Nil);
            panel["OnOpen"] = DynValue.NewCallback((c,a) => DynValue.Nil);
            panel["OnClose"] = DynValue.NewCallback((c,a) => DynValue.Nil);
            panel["OnMapEnter"] = DynValue.NewCallback((c,a) => DynValue.Nil);
            panel["OnActivate"] = DynValue.NewCallback((c,a) => DynValue.Nil);
            panel["OnDeactivate"] = DynValue.NewCallback((c,a) => DynValue.Nil);
            panel["OnActivityStateChange"] = DynValue.NewCallback((c,a) => DynValue.Nil);
            return DynValue.NewTable(panel);
        });
        uiTable["NewScrollView"] = DynValue.NewCallback((ctx, args) => {
            // Lua call shape: `Ui:NewScrollView(self, templatePath, callback)`.
            // The `:` colon inserts `Ui` as args[0]; real args start at args[1].
            //   args[1] = owner window table (has pPanel = LuaUIBridge)
            //   args[2] = template path string (e.g. "imgBG/FactionSeriesList/FactionList/FactionTemplate")
            //   args[3] = element-select callback (function(self, idx, tbElement))
            //
            // Each scrollview element wraps a real Unity child of the template's
            // parent (FactionList → Faction_<key> clones already in the prefab).
            // After lua's per-element init closure assigns nFactionId, we re-bind
            // the element's pPanel to the matching real Faction_<key> GameObject
            // by name suffix, so SetActive("Main", false) and Sprite_SetSprite
            // calls hit the live UI.
            var sv = new Table(_lua);
            DynValue ownerSelf = args.Count > 1 ? args[1] : DynValue.Nil;
            string templatePath = args.Count > 2 && args[2].Type == DataType.String ? args[2].String : null;
            DynValue selectCb  = args.Count > 3 ? args[3] : DynValue.Nil;
            var elements = new Dictionary<int, Table>();

            // Resolve listRoot = parent of template (the FactionList container).
            Transform listRoot = null;
            if (ownerSelf.Type == DataType.Table)
            {
                var pPanelDv = ownerSelf.Table.Get("pPanel");
                if (pPanelDv.Type == DataType.UserData && pPanelDv.UserData.Object is LuaUIBridge ownerBridge)
                {
                    var ownerRoot = ownerBridge.unityTransform;
                    if (ownerRoot != null && !string.IsNullOrEmpty(templatePath))
                    {
                        var tmpl = ownerRoot.Find(templatePath);
                        if (tmpl != null) listRoot = tmpl.parent;
                    }
                }
            }

            // Build factionId → real Faction_<key> Transform map by name suffix.
            // Faction.Define ids 1..20 → Unity child name suffix (case-insensitive).
            var idToSuffix = new[] {
                "shaolin",   // 1
                "tianwang",  // 2
                "tangmen",   // 3
                "wudu",      // 4
                "emei",      // 5
                "cuiyan",    // 6
                "gaibang",   // 7
                "tianren",   // 8
                "wudang",    // 9
                "kunlun",    // 10
                "mingjiao",  // 11
                "duanshi",   // 12
                "gumu",      // 13
                "badao",     // 14
                "xiaoyao",   // 15
                "baituosha", // 16
                "taohua",    // 17
                "changge",   // 18
                "yipintang", // 19
                "wuhuntang", // 20
            };
            var idToTransform = new Dictionary<int, Transform>();
            if (listRoot != null)
            {
                // Index Faction_<key> children by lowercased suffix
                var byName = new Dictionary<string, Transform>();
                for (int i = 0; i < listRoot.childCount; i++)
                {
                    var c = listRoot.GetChild(i);
                    if (!c.name.StartsWith("Faction_")) continue;
                    byName[c.name.Substring("Faction_".Length).ToLowerInvariant()] = c;
                }
                for (int i = 0; i < idToSuffix.Length; i++)
                {
                    if (byName.TryGetValue(idToSuffix[i], out var t))
                        idToTransform[i + 1] = t;
                }
            }

            // Track which real Transforms are currently bound so SelectElement can
            // toggle imgSelected highlight across all faction icons.
            Table MakeElement(int idx)
            {
                var el = new Table(_lua);
                el["nFactionId"] = idx; // overwritten by lua init closure
                // Default pPanel: bridge over listRoot (no-op fallback). Will be
                // replaced after init closure assigns real nFactionId.
                if (listRoot != null)
                    el["pPanel"] = UserData.Create(new LuaUIBridge(listRoot, "FactionElement"));
                return el;
            }

            // Capture for the click handler closure below.
            Table svRef = sv;

            void RebindElementToFaction(Table el, int slotIdx)
            {
                int fid = (int)el.Get("nFactionId").Number;
                if (!idToTransform.TryGetValue(fid, out var realT)) return;
                el["pPanel"] = UserData.Create(new LuaUIBridge(realT, $"Faction_{idToSuffix[fid - 1]}"));

                // Wire the faction icon's Button onClick → svRef:SelectElement(slotIdx).
                // The bake's Faction_<key> children already have a Button component
                // (Empty4Raycast / Image hit-target). We hook it here so clicking
                // any faction icon dispatches into lua's _SelectFaction handler,
                // which updates radar / title / banner / description.
                var btn = realT.GetComponent<Button>();
                if (btn == null) btn = realT.gameObject.AddComponent<Button>();
                btn.onClick.RemoveAllListeners();
                int capturedSlot = slotIdx;
                Debug.Log($"[LuaEngine.Rebind] slot={capturedSlot} fid={fid} Faction_{idToSuffix[fid - 1]}");
                btn.onClick.AddListener(() =>
                {
                    Debug.Log($"[LuaEngine.OnClick] capturedSlot={capturedSlot}");
                    var sel = svRef.Get("SelectElement");
                    // SelectElement can be either DataType.Function (lua) or
                    // DataType.ClrFunction (our DynValue.NewCallback). Both are
                    // callable via _lua.Call.
                    if (sel.Type != DataType.Function && sel.Type != DataType.ClrFunction)
                    {
                        Debug.LogWarning($"[LuaEngine.OnClick] SelectElement not callable (type={sel.Type})");
                        return;
                    }
                    try { _lua.Call(sel, DynValue.NewTable(svRef), DynValue.NewNumber(capturedSlot)); }
                    catch (ScriptRuntimeException ex) {
                        Debug.LogWarning($"[LuaEngine] FactionIcon click({capturedSlot}): {ex.DecoratedMessage}");
                    }
                });
            }

            sv["Reset"]    = DynValue.NewCallback((c,a) => { elements.Clear(); return DynValue.Nil; });
            sv["Clear"]    = DynValue.NewCallback((c,a) => { elements.Clear(); return DynValue.Nil; });
            sv["AddItems"] = DynValue.NewCallback((c,a) => DynValue.Nil);
            sv["SetAllElement"] = DynValue.NewCallback((c,a) => DynValue.Nil);
            sv["SetElement"] = DynValue.NewCallback((c,a) => {
                if (a.Count < 3) return DynValue.Nil;
                int idx = (int)a[1].Number;
                var el = MakeElement(idx);
                elements[idx] = el;
                if (a[2].Type == DataType.Function) {
                    try { _lua.Call(a[2], DynValue.NewTable(el)); }
                    catch (ScriptRuntimeException ex) {
                        Debug.LogWarning($"[LuaEngine] ScrollView SetElement init: {ex.DecoratedMessage}");
                    }
                }
                // After lua init: rebind pPanel to the real Faction_<key> GO + wire button click
                RebindElementToFaction(el, idx);
                return DynValue.Nil;
            });
            sv["MovePanelToLastItem"] = DynValue.NewCallback((c,a) => DynValue.Nil);
            sv["RefreshAllItem"] = DynValue.NewCallback((c,a) => DynValue.False);
            sv["SelectElement"] = DynValue.NewCallback((c,a) => {
                int idx = a.Count > 1 && a[1].Type == DataType.Number ? (int)a[1].Number : -1;
                if (!elements.TryGetValue(idx, out var el)) return DynValue.Nil;
                Debug.Log($"[LuaEngine.SelectElement] idx={idx} fid={(int)el.Get("nFactionId").Number} elementsCount={elements.Count}");
                // Toggle imgSelected highlight on all faction children: only the
                // selected one shows imgSelected; the rest hide it.
                int selectedFid = (int)el.Get("nFactionId").Number;
                foreach (var kv in idToTransform)
                {
                    var imgSel = kv.Value.Find("imgSelected");
                    if (imgSel != null) imgSel.gameObject.SetActive(kv.Key == selectedFid);
                }
                if (selectCb.Type == DataType.Function)
                {
                    try { _lua.Call(selectCb, ownerSelf, DynValue.NewNumber(idx), DynValue.NewTable(el)); }
                    catch (ScriptRuntimeException ex) {
                        Debug.LogWarning($"[LuaEngine] ScrollView SelectElement cb: {ex.DecoratedMessage}");
                    }
                }
                return DynValue.Nil;
            });
            sv["GetCount"] = DynValue.NewCallback((c,a) => DynValue.NewNumber(elements.Count));
            sv["GetElement"] = DynValue.NewCallback((c,a) => {
                if (a.Count < 2) return DynValue.Nil;
                int idx = (int)a[1].Number;
                return elements.TryGetValue(idx, out var el) ? DynValue.NewTable(el) : DynValue.Nil;
            });
            return DynValue.NewTable(sv);
        });
        uiTable["ResetCamera"] = DynValue.NewCallback((ctx, args) => DynValue.Nil);
        uiTable["BackToLogin"] = DynValue.NewCallback((ctx, args) => DynValue.Nil);
        uiTable["ReturnToLogin"] = DynValue.NewCallback((ctx, args) => DynValue.Nil);
        uiTable["NewExistPortraitObjPanel"] = DynValue.NewCallback((ctx, args) => {
            var t = new Table(_lua);
            t["SetRoleIcon"] = DynValue.NewCallback((c,a) => DynValue.Nil);
            t["SetLevel"] = DynValue.NewCallback((c,a) => DynValue.Nil);
            t["SetFactionIcon"] = DynValue.NewCallback((c,a) => DynValue.Nil);
            t["SetPortraitFrame"] = DynValue.NewCallback((c,a) => DynValue.Nil);
            return DynValue.NewTable(t);
        });
        uiTable["NewExistItemGrid"] = DynValue.NewCallback((ctx, args) => {
            var ig = new Table(_lua);
            ig["SetGenericItemTemplate"] = DynValue.NewCallback((c,a) => DynValue.Nil);
            ig["SetClickEnable"] = DynValue.NewCallback((c,a) => DynValue.Nil);
            ig["SetItem"] = DynValue.NewCallback((c,a) => DynValue.Nil);
            ig["SetItemByTemplate"] = DynValue.NewCallback((c,a) => DynValue.Nil);
            return DynValue.NewTable(ig);
        });
        uiTable["NewButtonGroup"] = DynValue.NewCallback((ctx, args) => {
            var bg = new Table(_lua);
            bg["Select"] = DynValue.NewCallback((c,a) => DynValue.Nil);
            bg["GetIndex"] = DynValue.NewCallback((c,a) => DynValue.NewNumber(1));
            return DynValue.NewTable(bg);
        });
        uiTable["NewLoopScrollView"] = DynValue.NewCallback((ctx, args) => {
            var lsv = new Table(_lua);
            lsv["Reset"] = DynValue.NewCallback((c,a) => DynValue.Nil);
            lsv["Clear"] = DynValue.NewCallback((c,a) => DynValue.Nil);
            lsv["AddItems"] = DynValue.NewCallback((c,a) => DynValue.Nil);
            lsv["SetAllElement"] = DynValue.NewCallback((c,a) => DynValue.Nil);
            lsv["SetElement"] = DynValue.NewCallback((c,a) => DynValue.Nil);
            lsv["SetTotal"] = DynValue.NewCallback((c,a) => DynValue.Nil);
            lsv["RefreshAllItem"] = DynValue.NewCallback((c,a) => DynValue.False);
            lsv["MovePanelToLastItem"] = DynValue.NewCallback((c,a) => DynValue.Nil);
            return DynValue.NewTable(lsv);
        });
        uiTable["NewSuperListView"] = DynValue.NewCallback((ctx, args) => {
            var sv = new Table(_lua);
            sv["SetAllElement"] = DynValue.NewCallback((c,a) => DynValue.Nil);
            sv["MovePanelToLastItem"] = DynValue.NewCallback((c,a) => DynValue.Nil);
            sv["RefreshAllItem"] = DynValue.NewCallback((c,a) => DynValue.False);
            return DynValue.NewTable(sv);
        });
        uiTable["NewExistAddAndSubGroup"] = DynValue.NewCallback((ctx, args) => {
            var asg = new Table(_lua);
            asg["BindEvent"] = DynValue.NewCallback((c,a) => DynValue.Nil);
            asg["SetNumRange"] = DynValue.NewCallback((c,a) => DynValue.Nil);
            asg["SetInputValue"] = DynValue.NewCallback((c,a) => DynValue.Nil);
            return DynValue.NewTable(asg);
        });
        uiTable["Button_BindEvent"] = DynValue.NewCallback((ctx, args) => DynValue.Nil);
        uiTable["WindowVisible"] = DynValue.NewCallback((ctx, args) => DynValue.False);
        uiTable["OnHelpClicked"] = DynValue.NewCallback((ctx, args) => DynValue.Nil);
        uiTable["GetKeyBoardTipActiveSetting"] = DynValue.NewCallback((ctx, args) => DynValue.NewNumber(0));
        uiTable["CheckSavePowerMode"] = DynValue.NewCallback((ctx, args) => DynValue.Nil);
        uiTable["LeaveSavePowerMode"] = DynValue.NewCallback((ctx, args) => DynValue.Nil);
        uiTable["CheckIdle"] = DynValue.NewCallback((ctx, args) => DynValue.Nil);
        uiTable["SetClickEmptyToClose"] = DynValue.Nil;
        uiTable["SetVipLevelEffect"] = DynValue.NewCallback((ctx, args) => DynValue.Nil);
        uiTable["bInZone"] = false;

        // Ui.PlayerPrefs
        var playerPrefs = new Table(_lua);
        playerPrefs["GetInt"] = DynValue.NewCallback((c,a) => {
            // Return default value if provided, or 0
            return a.Count > 1 ? a[1] : DynValue.NewNumber(0);
        });
        playerPrefs["SetInt"] = DynValue.NewCallback((c,a) => DynValue.Nil);
        playerPrefs["GetString"] = DynValue.NewCallback((c,a) => a.Count > 1 ? a[1] : DynValue.NewString(""));
        uiTable["PlayerPrefs"] = playerPrefs;

        // Ui.tbSettingType
        var tbSettingType = new Table(_lua);
        var tbCastTypeEnum = new Table(_lua);
        tbCastTypeEnum["Action"] = 1;
        tbCastTypeEnum["Direction"] = 2;
        tbSettingType["tbCastTypeEnum"] = tbCastTypeEnum;
        uiTable["tbSettingType"] = tbSettingType;

        // Component type stubs (string markers for GetComponent)
        uiTable["MiniMap"] = "MiniMap";
        uiTable["MapPathLine"] = "MapPathLine";
        uiTable["ManualSkillCaster"] = "ManualSkillCaster";
        uiTable["UISkillCountDown"] = "UISkillCountDown";
        
        _lua.Globals["Ui"] = uiTable;
    }

    /// <summary>
    /// Load a Lua file from Resources/Lua/
    /// </summary>
    bool LoadLuaFile(string name)
    {
        var asset = Resources.Load<TextAsset>($"Lua/{name}.lua");
        if (asset == null)
        {
            Debug.LogWarning($"[LuaEngine] File not found: Lua/{name}.lua.txt");
            return false;
        }
        
        try
        {
            _lua.DoString(asset.text, null, name);
            return true;
        }
        catch (ScriptRuntimeException ex)
        {
            Debug.LogWarning($"[LuaEngine] Runtime error in {name}: {ex.DecoratedMessage}");
            return false;
        }
        catch (SyntaxErrorException ex)
        {
            Debug.LogError($"[LuaEngine] Syntax error in {name}: {ex.DecoratedMessage}");
            return false;
        }
    }

    /// <summary>
    /// Call a method on a window table (OnCreate, OnOpen, OnClose, etc.)
    /// </summary>
    void CallWindowMethod(string windowName, string methodName)
    {
        if (!_windows.TryGetValue(windowName, out var info)) return;
        
        var method = info.windowTable.Get(methodName);
        if (method.Type != DataType.Function) return;
        
        try
        {
            _lua.Call(method, info.windowTable);
        }
        catch (ScriptRuntimeException ex)
        {
            Debug.LogWarning($"[LuaEngine] {windowName}:{methodName}() error: {ex.DecoratedMessage}");
        }
    }

    /// <summary>
    /// Read tbOnClick table from window and bind to actual Unity buttons
    /// </summary>
    int BindClickHandlers(string windowName)
    {
        if (!_windows.TryGetValue(windowName, out var info)) return 0;
        
        // Get tbControls
        var controlsVal = info.windowTable.Get("tbControls");
        if (controlsVal.Type != DataType.Table) return 0;
        var tbControls = controlsVal.Table;
        
        // Get tbOnClick
        var onClickVal = info.windowTable.Get("tbOnClick");
        if (onClickVal.Type != DataType.Table) return 0;
        var tbOnClick = onClickVal.Table;
        
        int bound = 0;
        
        foreach (var pair in tbOnClick.Pairs)
        {
            string btnKey = pair.Key.CastToString();
            if (pair.Value.Type != DataType.Function) continue;
            
            // Find path from tbControls
            var pathVal = tbControls.Get(btnKey);
            string path = pathVal.Type == DataType.String ? pathVal.String : btnKey;
            
            // Find transform 
            Transform btnTransform = null;
            
            // Try imgBG/ prefix first (common pattern)
            if (info.bridge != null)
            {
                var bridgeTransform = info.bridge.unityTransform;
                btnTransform = bridgeTransform.Find(path);
                if (btnTransform == null)
                    btnTransform = bridgeTransform.Find($"imgBG/{btnKey}");
            }
            
            if (btnTransform == null) continue;
            
            // Add Button component if missing
            var btn = btnTransform.GetComponent<Button>();
            if (btn == null) btn = btnTransform.gameObject.AddComponent<Button>();
            
            // Capture closure for lambda
            var handler = pair.Value;
            var wndTable = info.windowTable;
            string capturedBtn = btnKey;
            
            btn.onClick.AddListener(() => {
                try
                {
                    _lua.Call(handler, wndTable);
                }
                catch (ScriptRuntimeException ex)
                {
                    Debug.LogWarning($"[LuaEngine] onClick({capturedBtn}): {ex.DecoratedMessage}");
                }
            });
            
            info.onClickHandlers[btnKey] = handler.Function;
            bound++;
        }
        
        return bound;
    }

    /// <summary>
    /// Read tbOnToggleClick from window and bind to Toggle (or Button-as-toggle)
    /// click events. Each handler receives (self, isOn).
    /// Used by UICreateRole for the 5-elements series filter and gender select.
    /// </summary>
    int BindToggleHandlers(string windowName)
    {
        if (!_windows.TryGetValue(windowName, out var info)) return 0;

        var controlsVal = info.windowTable.Get("tbControls");
        if (controlsVal.Type != DataType.Table) return 0;
        var tbControls = controlsVal.Table;

        var onToggleVal = info.windowTable.Get("tbOnToggleClick");
        if (onToggleVal.Type != DataType.Table) return 0;
        var tbOnToggleClick = onToggleVal.Table;

        int bound = 0;

        foreach (var pair in tbOnToggleClick.Pairs)
        {
            string btnKey = pair.Key.CastToString();
            if (pair.Value.Type != DataType.Function) continue;

            var pathVal = tbControls.Get(btnKey);
            string path = pathVal.Type == DataType.String ? pathVal.String : btnKey;

            Transform target = null;
            if (info.bridge != null)
            {
                var bridgeTransform = info.bridge.unityTransform;
                target = bridgeTransform.Find(path);
                if (target == null)
                    target = bridgeTransform.Find($"imgBG/{btnKey}");
            }
            if (target == null) continue;

            var handler = pair.Value;
            var wndTable = info.windowTable;
            string capturedBtn = btnKey;

            // Prefer Toggle if present, else fall back to Button (toggling state ourselves)
            var toggle = target.GetComponent<Toggle>();
            if (toggle != null)
            {
                toggle.onValueChanged.AddListener(isOn => {
                    try { _lua.Call(handler, wndTable, DynValue.NewBoolean(isOn)); }
                    catch (ScriptRuntimeException ex) {
                        Debug.LogWarning($"[LuaEngine] onToggle({capturedBtn}): {ex.DecoratedMessage}");
                    }
                });
            }
            else
            {
                var btn = target.GetComponent<Button>();
                if (btn == null) btn = target.gameObject.AddComponent<Button>();
                btn.onClick.AddListener(() => {
                    try { _lua.Call(handler, wndTable, DynValue.True); }
                    catch (ScriptRuntimeException ex) {
                        Debug.LogWarning($"[LuaEngine] onToggle({capturedBtn}): {ex.DecoratedMessage}");
                    }
                });
            }
            bound++;
        }

        return bound;
    }

    /// <summary>
    /// Build a window table for a given name and register it. Used by both
    /// Ui:CreateWindow (top-level windows) and Ui:CreateClass (sub-panels).
    /// </summary>
    Table BuildWindowTable(string wndName)
    {
        var wndTable = new Table(_lua);

        // Window-level method stubs
        wndTable["SetClickEmptyToClose"] = DynValue.NewCallback((c, a) => DynValue.Nil);
        wndTable["SetFubenBtnImageAndText"] = DynValue.NewCallback((c, a) => DynValue.Nil);
        wndTable["SetFubenBtnShowStatus"] = DynValue.NewCallback((c, a) => DynValue.Nil);
        wndTable["SetFubenStateSwitchCancel"] = DynValue.NewCallback((c, a) => DynValue.Nil);

        // PanelPlayerGuide stub
        var panelGuide = new Table(_lua);
        panelGuide["OnOpen"] = DynValue.NewCallback((c, a) => DynValue.Nil);
        panelGuide["OnClose"] = DynValue.NewCallback((c, a) => DynValue.Nil);
        panelGuide["OnMapEnter"] = DynValue.NewCallback((c, a) => DynValue.Nil);
        wndTable["PanelPlayerGuide"] = panelGuide;

        // tbEntranceSV stub (for UIHudRightTopWelfare)
        var entranceSV = new Table(_lua);
        entranceSV["Reset"] = DynValue.NewCallback((c, a) => DynValue.Nil);
        entranceSV["AddItems"] = DynValue.NewCallback((c, a) => DynValue.Nil);
        wndTable["tbEntranceSV"] = entranceSV;

        // Find the GameObject in scene by name (search all transforms,
        // including inactive — wrapper-canvas siblings live outside _canvas)
        var rootObj = FindWindowRoot(wndName);
        if (rootObj != null)
        {
            var bridge = new LuaUIBridge(rootObj, wndName);
            wndTable["pPanel"] = UserData.Create(bridge);

            var info = new LuaWindowInfo
            {
                windowTable = wndTable,
                bridge = bridge,
                root = rootObj.gameObject,
                onClickHandlers = new Dictionary<string, Closure>()
            };
            _windows[wndName] = info;

            Debug.Log($"[LuaEngine] Created window: {wndName} ✓ (root={rootObj.name})");
        }
        else
        {
            Debug.LogWarning($"[LuaEngine] Window not found in scene: {wndName}");
            // Still create the table so Lua doesn't error
            var dummyBridge = new LuaUIBridge(_canvas, wndName);
            wndTable["pPanel"] = UserData.Create(dummyBridge);
        }

        return wndTable;
    }

    /// <summary>
    /// Find a window root GameObject by name across the entire scene,
    /// including inactive ones. Prefers an exact name match on the
    /// nested prefab instance, not on the wrapper Canvas.
    /// </summary>
    Transform FindWindowRoot(string wndName)
    {
        Transform best = null;
        var all = UnityEngine.Object.FindObjectsOfType<Transform>(true);
        foreach (var t in all)
        {
            if (t.name != wndName) continue;
            // Skip wrappers like "<name>_Canvas" or "<name>_Slot" — those don't equal wndName,
            // so they're already excluded by the name check. Pick the deepest match
            // (the actual prefab instance is a child of the wrapper).
            if (best == null || GetDepth(t) > GetDepth(best))
                best = t;
        }
        return best;
    }

    static int GetDepth(Transform t)
    {
        int d = 0;
        for (var p = t.parent; p != null; p = p.parent) d++;
        return d;
    }

    /// <summary>
    /// Public: call window method from C# (e.g., trigger fight state change)
    /// </summary>
    public void NotifyWindow(string windowName, string methodName, params DynValue[] args)
    {
        if (!_windows.TryGetValue(windowName, out var info)) return;
        
        var method = info.windowTable.Get(methodName);
        if (method.Type != DataType.Function) return;
        
        var callArgs = new List<DynValue> { DynValue.NewTable(info.windowTable) };
        callArgs.AddRange(args);
        
        try
        {
            _lua.Call(method, callArgs.ToArray());
        }
        catch (ScriptRuntimeException ex)
        {
            Debug.LogWarning($"[LuaEngine] {windowName}:{methodName}() error: {ex.DecoratedMessage}");
        }
    }
}
