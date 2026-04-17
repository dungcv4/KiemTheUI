// =======================================================================
//  UIBagController.cs — Port of Script_Ui_Window_UIBag.lua
//
//  Source: KiemTheOrigin_DeepExtract/04_Bag/Lua/Script_Ui_Window_UIBag.lua
//          (~473 lines)
//
//  ORIGINAL FLOW (what we're porting):
//    1. Ui:CreateWindow("UIBag") — registers the window class
//    2. tbControls table maps control names → prefab paths
//    3. tbWnd.PANEL_SETTING defines 5 tabs:
//         PANEL_TYPE_BAG        (1)  — UIBagPanel       inventory grid
//         PANEL_TYPE_ATTR       (2)  — UIAttributePanel character stats
//         PANEL_TYPE_REPUTE     (3)  — UIReputePanel    reputation
//         PANEL_TYPE_HORSE      (4)  — UIHorsePanel     mount
//         PANEL_TYPE_APPEARANCE (5)  — UIAppearancePanel3 closet/fashion
//    4. OnCreate — instantiate money panel + sub-windows (JingZhuInfo, etc.)
//    5. OnOpen(nSelectPanel) — switch to given tab
//    6. tbTabControl:OnOpen/OnClose dispatch to active sub-panel
//
//  SCOPE OF THIS PORT (Phase 1 — faithful structure, pragmatic content):
//    ✅ Instantiate UIBag.prefab from bundle
//    ✅ Tab switching (5 tabs, show/hide panels)
//    ✅ Close button wiring
//    ✅ Hotkey 'B' to open/toggle
//    ✅ Currency display (Gold/YuanBao/Coin from PlayerData)
//
//  DEFERRED (Phase 2+):
//    ❌ RedPointMgr red-dot notifications (needs full red-point system)
//    ❌ Sub-window overlays (wndJingZhuInfo, wndSubAttribute, etc.)
//    ❌ Horse/Appearance panel content (needs Horse/Fashion modules)
//    ❌ EventNotify bindings (needs full notify pipeline)
//    ❌ OnLateUpdate / OnFixedUpdate tick callbacks
//    ❌ Bag item grid (needs BagMgr + Item metadata from pack0 config)
//
//  DEVIATIONS:
//    - We instantiate the UIBag prefab directly via ResourceModule
//      instead of going through Ui:CreateWindow's Lua-managed registry.
//      The prefab asset IS the same — just a different entry point.
// =======================================================================

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// Alias to disambiguate from the AssetRipper stub `ResourceModule` in the
// global namespace (Assets/Scripts/Assembly-CSharp/ResourceModule.cs).
using KResourceModule = KTO.Resource.ResourceModule;
// Alias to the real KTO.Localization.LanguageModule (avoiding name clash with
// the AssetRipper stub `LanguageModule` at Assets/Scripts/Assembly-CSharp/
// LanguageModule.cs in the global namespace, which has no Get()).
using Lang = KTO.Localization.LanguageModule;

namespace KTO.UI
{
    public class UIBagController : MonoBehaviour
    {
        // ----- tab enum mirrors Lua PANEL_TYPE_* -----
        public enum PanelType
        {
            Bag        = 1, // PANEL_TYPE_BAG
            Attribute  = 2, // PANEL_TYPE_ATTR
            Reputation = 3, // PANEL_TYPE_REPUTE
            Horse      = 4, // PANEL_TYPE_HORSE
            Appearance = 5, // PANEL_TYPE_APPEARANCE
        }

        // ----- singleton so hotkey handler can toggle -----
        //
        // Lazy self-healing singleton — matches the pattern used by
        // MapObstacleGrid and PlayerMotor. Robust to Unity's domain reload,
        // which clears static state but does NOT re-fire Awake on existing
        // MonoBehaviours. Without this, after any Assets/Scripts edit the
        // _instance field is null even though the controller GO still lives.
        static UIBagController _instance;
        public static UIBagController Instance
        {
            get
            {
                if (_instance == null)
                    _instance = UnityEngine.Object.FindObjectOfType<UIBagController>(includeInactive: true);
                return _instance;
            }
        }

        // ----- Lua tbControls → prefab path mapping -----
        // Keys here exactly match the Lua tbControls table names so any
        // future diff against the Lua source is trivially grep-able.
        static readonly Dictionary<string, string> tbControls = new Dictionary<string, string>
        {
            { "btnClose",        "imgBG/btnClose" },
            { "UIMoneyPanel",    "imgBG/UIMoneyPanel" },
            { "btnHelp",         "imgBG/BG/btnHelp" },
            { "btnBag",          "imgBG/TabGroup/btnBag" },
            { "BagPanel",        "imgBG/BagPanel" },
            { "btnAttribute",    "imgBG/TabGroup/btnAttribute" },
            { "AttributePanel",  "imgBG/AttributePanel" },
            { "btnReputation",   "imgBG/TabGroup/btnReputation" },
            { "ReputationPanel", "imgBG/ReputationPanel" },
            { "btnHorse",        "imgBG/TabGroup/btnHorse" },
            { "HorsePanel",      "imgBG/HorsePanel" },
            { "ClosetPanel3",    "imgBG/ClosetPanel3" },
            { "btnCloset",       "imgBG/TabGroup/btnCloset" },
        };

        // Map PanelType → (panelPath, buttonPath) — Lua PANEL_SETTING shape
        static readonly Dictionary<PanelType, (string panel, string button)> PANEL_SETTING =
            new Dictionary<PanelType, (string, string)>
            {
                { PanelType.Bag,        (tbControls["BagPanel"],        tbControls["btnBag"]) },
                { PanelType.Attribute,  (tbControls["AttributePanel"],  tbControls["btnAttribute"]) },
                { PanelType.Reputation, (tbControls["ReputationPanel"], tbControls["btnReputation"]) },
                { PanelType.Horse,      (tbControls["HorsePanel"],      tbControls["btnHorse"]) },
                { PanelType.Appearance, (tbControls["ClosetPanel3"],    tbControls["btnCloset"]) },
            };

        // ----- runtime state -----
        GameObject _rootGo;
        PanelType _currentPanel = PanelType.Bag;

        // ----- sub-panel controllers (lazily initialized on first SelectPanel) -----
        UIBagPanel          _bagPanelCtrl;
        UIAttributePanel    _attrPanelCtrl;
        UIReputePanel       _reputePanelCtrl;
        UIHorsePanel        _horsePanelCtrl;
        UIAppearancePanel   _appearanceCtrl;

        // ----- lifecycle -----
        void Awake()
        {
            // Claim singleton; destroy self if a duplicate slipped in.
            if (_instance != null && _instance != this)
            {
                Destroy(gameObject);
                return;
            }
            _instance = this;
        }

        void OnDestroy()
        {
            if (_instance == this) _instance = null;
        }

        void Update()
        {
            // Hotkey 'B' toggles the bag — standard MMO convention. The original
            // client doesn't have a literal 'B' binding (touch-first design) but
            // IL2CPP has HOTKEY_OPEN_BAG in its keycode enum, suggesting desktop
            // support was planned. This is a desktop QoL — wired to 'B'.
            if (Input.GetKeyDown(KeyCode.B))
                Toggle();
        }

        // ----- public API -----
        public static void Open(PanelType startTab = PanelType.Bag)
        {
            if (Instance == null)
            {
                var go = new GameObject("[UIBagController]");
                go.AddComponent<UIBagController>();
            }
            Instance.OpenInternal(startTab);
        }

        public static void Toggle()
        {
            if (Instance == null || Instance._rootGo == null) Open();
            else Instance.Close();
        }

        public void Close()
        {
            if (_rootGo != null)
            {
                // Matches Lua tbWnd:OnClose — tbTabControl:OnClose, UnRegistRedPoint,
                // close nShowModelTimer. All three are trimmed here (no red-point /
                // no show-model timer / no per-tab cleanup).
                Destroy(_rootGo);
                _rootGo = null;
            }
        }

        // ----- open + instantiate -----
        void OpenInternal(PanelType startTab)
        {
            // If already open, just switch tabs.
            if (_rootGo != null)
            {
                SelectPanel(startTab);
                return;
            }

            // Load the prefab from bundle (ui/views/uibag).
            // Source: KTO_Resources/assets/Bundles/Android/ui/views/res_p_27.ab
            GameObject prefab = KResourceModule.LoadPrefabSync("ui/views/uibag", "UIBag");
            if (prefab == null)
            {
                Debug.LogError("[UIBagController] UIBag prefab not found");
                return;
            }

            // Parent under the HUD root so it inherits the Canvas scaler.
            Transform parent = GameObject.Find("HudRoot")?.transform;
            _rootGo = Instantiate(prefab, parent);
            _rootGo.name = "UIBag";

            // Wire the close button.
            var btnClose = FindComponent<Button>(tbControls["btnClose"]);
            if (btnClose != null)
            {
                btnClose.onClick.RemoveAllListeners();
                btnClose.onClick.AddListener(() => Close());
            }

            // Wire the 5 tab buttons.
            // Lua: tbTabControl:UpdateButtonGroup → SelectPanel on click
            foreach (var kv in PANEL_SETTING)
            {
                var pt = kv.Key;
                var btn = FindComponent<Button>(kv.Value.button);
                if (btn != null)
                {
                    btn.onClick.RemoveAllListeners();
                    var captured = pt;
                    btn.onClick.AddListener(() => SelectPanel(captured));
                }
            }

            // ── Port of Lua `UIBag:OnCreate` label setup ──
            //
            // Tab button labels in the original prefab have
            //   Localize.locKey = "dynamic_change_from_script"
            // (designer didn't wire a real term, and no corresponding Lua
            // call populates them either — grep for btnBag/btnAttribute/
            // btnReputation/btnHorse/btnCloset in Script_Ui_Window_UIBag.lua
            // finds only red-point wiring, no Label_SetText).
            //
            // Faithful fix: route the labels through LanguageModule (same
            // mechanism I2.Loc uses in the original), with UIBAG_TAB_* as
            // the terms. See Assets/Resources/language/translations_vi-VN.json.
            //
            // Source: KiemTheOrigin_DeepExtract/_all_detailed_json/
            //         UIBag_res_p_27.json — confirms locKey values; Lua
            //         doesn't overwrite them (04_Bag/Lua/Script_Ui_Window_UIBag.lua).
            SetButtonLabel(tbControls["btnBag"],        Lang.Get("UIBAG_TAB_BAG"));
            SetButtonLabel(tbControls["btnAttribute"],  Lang.Get("UIBAG_TAB_ATTRIBUTE"));
            SetButtonLabel(tbControls["btnReputation"], Lang.Get("UIBAG_TAB_REPUTATION"));
            SetButtonLabel(tbControls["btnHorse"],      Lang.Get("UIBAG_TAB_HORSE"));
            SetButtonLabel(tbControls["btnCloset"],     Lang.Get("UIBAG_TAB_CLOSET"));

            // Window title — same story: baked as placeholder, nothing sets
            // it at runtime in the original Lua.
            SetWindowLabel("imgBG/BG/txtTitle", Lang.Get("UIBAG_TITLE"));

            SelectPanel(startTab);
        }

        // ── Helpers for setting labels on the prefab ──
        void SetButtonLabel(string buttonPath, string label)
        {
            var tr = FindChild(buttonPath);
            if (tr == null) return;
            var t = tr.Find("Text")?.GetComponent<Text>();
            if (t != null) t.text = label;
        }

        void SetWindowLabel(string path, string label)
        {
            var tr = FindChild(path);
            if (tr == null) return;
            var t = tr.GetComponent<Text>() ?? tr.GetComponentInChildren<Text>(true);
            if (t != null) t.text = label;
        }

        // ----- tab switching (Lua: tbTabControl:SelectPanel) -----
        public void SelectPanel(PanelType pt)
        {
            _currentPanel = pt;
            foreach (var kv in PANEL_SETTING)
            {
                var panelTr = FindChild(kv.Value.panel);
                if (panelTr != null) panelTr.gameObject.SetActive(kv.Key == pt);
            }
            // Initialize + Open the sub-controller for the selected tab.
            InitSubController(pt);
        }

        void InitSubController(PanelType pt)
        {
            if (_rootGo == null) return;
            switch (pt)
            {
                case PanelType.Bag:
                    if (_bagPanelCtrl == null)
                    {
                        var tr = FindChild(PANEL_SETTING[PanelType.Bag].panel);
                        if (tr != null)
                        {
                            _bagPanelCtrl = tr.gameObject.GetComponent<UIBagPanel>() ?? tr.gameObject.AddComponent<UIBagPanel>();
                            _bagPanelCtrl.Init(tr);
                        }
                    }
                    _bagPanelCtrl?.OnOpen();
                    break;
                case PanelType.Attribute:
                    if (_attrPanelCtrl == null)
                    {
                        var tr = FindChild(PANEL_SETTING[PanelType.Attribute].panel);
                        if (tr != null)
                        {
                            _attrPanelCtrl = tr.gameObject.GetComponent<UIAttributePanel>() ?? tr.gameObject.AddComponent<UIAttributePanel>();
                            _attrPanelCtrl.Init(tr);
                        }
                    }
                    _attrPanelCtrl?.OnOpen();
                    break;
                case PanelType.Reputation:
                    if (_reputePanelCtrl == null)
                    {
                        var tr = FindChild(PANEL_SETTING[PanelType.Reputation].panel);
                        if (tr != null)
                        {
                            _reputePanelCtrl = tr.gameObject.GetComponent<UIReputePanel>() ?? tr.gameObject.AddComponent<UIReputePanel>();
                            _reputePanelCtrl.Init(tr);
                        }
                    }
                    _reputePanelCtrl?.OnOpen();
                    break;
                case PanelType.Horse:
                    if (_horsePanelCtrl == null)
                    {
                        var tr = FindChild(PANEL_SETTING[PanelType.Horse].panel);
                        if (tr != null)
                        {
                            _horsePanelCtrl = tr.gameObject.GetComponent<UIHorsePanel>() ?? tr.gameObject.AddComponent<UIHorsePanel>();
                            _horsePanelCtrl.Init(tr);
                        }
                    }
                    _horsePanelCtrl?.OnOpen();
                    break;
                case PanelType.Appearance:
                    if (_appearanceCtrl == null)
                    {
                        var tr = FindChild(PANEL_SETTING[PanelType.Appearance].panel);
                        if (tr != null)
                        {
                            _appearanceCtrl = tr.gameObject.GetComponent<UIAppearancePanel>() ?? tr.gameObject.AddComponent<UIAppearancePanel>();
                            _appearanceCtrl.Init(tr);
                        }
                    }
                    _appearanceCtrl?.OnOpen();
                    break;
            }
        }

        // ----- helpers -----
        Transform FindChild(string path)
        {
            if (_rootGo == null) return null;
            return _rootGo.transform.Find(path);
        }

        T FindComponent<T>(string path) where T : Component
        {
            var tr = FindChild(path);
            return tr != null ? tr.GetComponent<T>() : null;
        }
    }
}
