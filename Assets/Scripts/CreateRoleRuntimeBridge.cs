// Runtime bridge: wires UICreateRole buttons to LoginManager.CreateRole.
// Reads input name, selected faction/gender from UI state and sends to server.
//
// Gender selection pipeline (single path, matching original Lua UICreateRole):
//   SelectGender Toggle.onValueChanged → SelectSex(sex)
//   SelectGender2 Button.onClick       → SelectSex(sex)
//   Faction auto-gender                → SelectSex(sex)
//   ApplyDefaults                      → SelectSex(sex)
//
// SelectSex is THE single entry point. It:
//   1. Sets _selectedSex
//   2. Updates Toggle states (isOn + interactable) = Lua's SetSex
//   3. Updates SelectGender2 overlay interactable = Lua's Button_SetEnable
//   4. Calls UICreateRoleAvatarController.Apply = Lua's emNOTIFY_UILOGINBG_ACTION
using UnityEngine;
using UnityEngine.UI;
using KTO.Network;

public class CreateRoleRuntimeBridge : MonoBehaviour
{
    private InputField _inputName;
    private int _selectedSex = 0;       // 0=male, 1=female
    private int _selectedFactionID = 20; // default Vũ Huân Đường
    private bool _started = false;
    private bool _inFactionChange = false; // guard: prevent Lua-triggered toggle re-entry

    // Faction IDs grouped by elemental series (matching UICreateRole layout)
    // Series: Kim=1, Mộc=2, Thủy=3, Hỏa=4, Thổ=5
    static readonly int[][] SERIES_FACTIONS = {
        new[]{ 1, 2, 14, 19 },        // Kim (Metal): Thiếu Lâm, Thiên Vương, Bá Đao, Nhất Phẩm Đường
        new[]{ 3, 4, 11, 16 },        // Mộc (Wood): Đường Môn, Ngũ Độc, Minh Giáo, Bạch Đà Sơn
        new[]{ 5, 6, 12, 17 },        // Thủy (Water): Nga My, Thúy Yên, Đoàn Thị, Đào Hoa
        new[]{ 7, 8, 15, 20 },        // Hỏa (Fire): Cái Bang, Thiên Nhẫn, Tiêu Dao, Vũ Huân Đường
        new[]{ 9, 10, 13, 18 },       // Thổ (Earth): Võ Đang, Côn Lôn, Cổ Mộ, Trường Ca
    };

    void Start()
    {
        // Find input field
        foreach (var input in GetComponentsInChildren<InputField>(true))
        {
            if (input.name == "inputRoleName")
            {
                _inputName = input;
                if (input.textComponent == null)
                {
                    var txt = input.transform.Find("Text")?.GetComponent<Text>();
                    if (txt != null) input.textComponent = txt;
                }
                if (input.placeholder == null)
                {
                    var ph = input.transform.Find("Placeholder")?.GetComponent<Text>();
                    if (ph != null) input.placeholder = ph;
                }
                break;
            }
        }

        // Listen for create result
        if (LoginManager.Instance != null)
            LoginManager.Instance.OnCreateRoleResult += OnCreateResult;

        _started = true;
    }

    void OnEnable()
    {
        WireAllButtons();
        ApplyDefaults();
    }

    void OnDestroy()
    {
        if (LoginManager.Instance != null)
            LoginManager.Instance.OnCreateRoleResult -= OnCreateResult;
    }

    // =========================================================================
    //  BUTTON WIRING
    // =========================================================================

    void WireAllButtons()
    {
        WireButton("btnCreateRole", OnSubmitCreate);
        WireButton("btnReturn", OnReturn);
        WireGenderButtons();
        WireSeriesTogles();
        WireFactionButtons();
        Debug.Log("[CreateRole] All buttons wired");
    }

    /// <summary>
    /// Wire gender buttons matching original Lua:
    ///   SelectGender  → Toggle.onValueChanged (Lua tbOnToggleClick)
    ///   SelectGender2 → Button.onClick        (Lua Button click areas)
    /// Each object has BOTH Toggle + Button from bundle import.
    /// We disable the UNUSED Selectable on each to avoid conflicts.
    /// </summary>
    void WireGenderButtons()
    {
        // --- SelectGender (small icon toggles in bottom panel) ---
        foreach (var t in GetComponentsInChildren<Transform>(true))
        {
            if (t.name == "SelectGender" && t.parent != null && t.parent.name == "imgBG")
            {
                WireGenderToggle(t.Find("btnMale"), 0);
                WireGenderToggle(t.Find("btnFemale"), 1);
                break;
            }
        }

        // --- SelectGender2 (large overlay click areas on characters) ---
        foreach (var t in GetComponentsInChildren<Transform>(true))
        {
            if (t.name == "SelectGender2")
            {
                t.gameObject.SetActive(true);
                WireGenderOverlay(t.Find("btnMale"), 0);
                WireGenderOverlay(t.Find("btnFemale"), 1);
                break;
            }
        }
    }

    /// <summary>
    /// Wire SelectGender toggle (small icon). Matches Lua's tbOnToggleClick.
    /// Disable Button (unused), keep Toggle for input + visual.
    /// Override Toggle colors: enabled=bright, disabled=dim.
    /// </summary>
    void WireGenderToggle(Transform btnT, int sex)
    {
        if (btnT == null) return;

        // Disable Button — only Toggle is used for SelectGender (matching Lua)
        var btn = btnT.GetComponent<Button>();
        if (btn != null) btn.enabled = false;

        // Enable Toggle — primary input + visual for gender icons
        var toggle = btnT.GetComponent<Toggle>();
        if (toggle != null)
        {
            toggle.enabled = true;
            toggle.transition = Selectable.Transition.ColorTint;

            // CRITICAL: targetGraphic must point to the VISIBLE Image, not Empty4Raycast.
            // Both btnMale/btnFemale have two Graphic subclasses from the bundle import:
            //   - Empty4Raycast (invisible raycast target, inherits Graphic)
            //   - Image (visible gender icon)
            // Toggle.targetGraphic defaults to the first Graphic, which is often
            // Empty4Raycast. Color tint then applies to the INVISIBLE component,
            // making dim/bright inconsistent between male and female icons.
            var img = btnT.GetComponent<Image>();
            if (img != null) toggle.targetGraphic = img;

            // Override ColorBlock for correct dim/bright visual:
            //   normal = bright (white) → unselected, clickable
            //   disabled = dim (half-alpha) → selected, can't re-click
            // Matches user expectation: "icon bấm thì mờ đi, icon kia sáng lên"
            var cb = toggle.colors;
            cb.normalColor      = Color.white;
            cb.highlightedColor = new Color(0.9f, 0.9f, 0.9f, 1f);
            cb.pressedColor     = new Color(0.75f, 0.75f, 0.75f, 1f);
            cb.selectedColor    = Color.white;
            cb.disabledColor    = new Color(1f, 1f, 1f, 0.4f);
            toggle.colors = cb;

            toggle.onValueChanged.RemoveAllListeners();
            // Guard: Lua's ToggleGroup_SetSelect fires toggle.isOn=true during faction
            // change. If we're inside SetFaction, ignore — SetFaction calls SelectSex itself.
            toggle.onValueChanged.AddListener(isOn => {
                if (isOn && !_inFactionChange) SelectSex(sex);
            });
        }
    }

    /// <summary>
    /// Wire SelectGender2 overlay button. Matches Lua's Button click + Button_SetEnable.
    /// Disable Toggle (unused), keep Button for input.
    /// </summary>
    void WireGenderOverlay(Transform btnT, int sex)
    {
        if (btnT == null) return;

        // Disable Toggle — only Button is used for SelectGender2
        var toggle = btnT.GetComponent<Toggle>();
        if (toggle != null)
        {
            toggle.onValueChanged.RemoveAllListeners();
            toggle.enabled = false;
        }

        // Wire Button
        var btn = btnT.GetComponent<Button>();
        if (btn == null) btn = btnT.gameObject.AddComponent<Button>();
        btn.interactable = true;
        var graphic = btnT.GetComponent<Graphic>();
        if (graphic != null)
        {
            graphic.raycastTarget = true;
            btn.targetGraphic = graphic;
        }
        else
        {
            var img = btnT.gameObject.AddComponent<Image>();
            img.color = new Color(0, 0, 0, 0);
            img.raycastTarget = true;
            btn.targetGraphic = img;
        }
        btn.onClick.RemoveAllListeners();
        btn.onClick.AddListener(() => SelectSex(sex));
    }

    // =========================================================================
    //  GENDER SELECTION — SINGLE PIPELINE (matching Lua SelectSex + SetSex)
    // =========================================================================

    /// <summary>
    /// THE single entry point for ALL gender changes.
    /// Mirrors Lua UICreateRole:SelectSex → SetSex → emNOTIFY_UILOGINBG_ACTION.
    /// Called from: toggle click, overlay click, faction auto-gender, defaults.
    /// </summary>
    void SelectSex(int sex)
    {
        _selectedSex = sex;

        // Faction gender restriction
        bool maleAvail = _selectedFactionID != 5;   // Emei = female-only
        bool femaleAvail = _selectedFactionID != 1;  // Shaolin = male-only

        // --- SetSex visual: SelectGender toggle states ---
        // Lua: Toggle_SetEnable(selected, false) + ToggleGroup_SetSelect(selected, true)
        //      Toggle_SetEnable(unselected, true) + ToggleGroup_SetSelect(unselected, false)
        // Result: selected icon = disabled+checked = DIM, unselected = enabled+unchecked = BRIGHT
        foreach (var t in GetComponentsInChildren<Transform>(true))
        {
            if (t.name == "SelectGender" && t.parent != null && t.parent.name == "imgBG")
            {
                ApplyToggleState(t.Find("btnMale"), sex == 0, maleAvail);
                ApplyToggleState(t.Find("btnFemale"), sex == 1, femaleAvail);
                break;
            }
        }

        // --- SetSex visual: SelectGender2 overlay states ---
        // Lua: Button_SetEnable(selected, false) + Button_SetEnable(unselected, true)
        foreach (var t in GetComponentsInChildren<Transform>(true))
        {
            if (t.name == "SelectGender2")
            {
                ApplyOverlayState(t.Find("btnMale"), sex == 0, maleAvail);
                ApplyOverlayState(t.Find("btnFemale"), sex == 1, femaleAvail);
                break;
            }
        }

        Debug.Log($"[CreateRole] SelectSex({sex}) faction={_selectedFactionID}");

        // --- Avatar display (equivalent to Lua's emNOTIFY_UILOGINBG_ACTION "Select") ---
        UICreateRoleAvatarController.Apply(_selectedFactionID, sex == 0 ? 1 : 2, forceAction: true);
    }

    /// <summary>
    /// Set toggle state for a SelectGender icon.
    /// selected=true  → checked + disabled (DIM/mờ)
    /// selected=false → unchecked + enabled (BRIGHT/sáng)
    /// </summary>
    static void ApplyToggleState(Transform btnT, bool selected, bool available)
    {
        if (btnT == null) return;
        btnT.gameObject.SetActive(available);
        var toggle = btnT.GetComponent<Toggle>();
        if (toggle == null) return;
        toggle.SetIsOnWithoutNotify(selected);
        toggle.interactable = !selected;
    }

    /// <summary>
    /// Set button state for a SelectGender2 overlay.
    /// selected=true  → disabled (can't re-click selected gender)
    /// selected=false → enabled (can click to switch)
    /// </summary>
    static void ApplyOverlayState(Transform btnT, bool selected, bool available)
    {
        if (btnT == null) return;
        btnT.gameObject.SetActive(available);
        var btn = btnT.GetComponent<Button>();
        if (btn != null) btn.interactable = !selected;
    }

    // =========================================================================
    //  FACTION SELECTION
    // =========================================================================

    public void SetFaction(int factionID)
    {
        // Guard: Lua's _SelectFaction also runs and calls SetSex → ToggleGroup_SetSelect
        // which fires our toggle handler. The guard prevents that handler from calling
        // SelectSex with stale _selectedFactionID before we update it here.
        _inFactionChange = true;

        _selectedFactionID = factionID;
        // Auto-set gender for single-gender factions
        if (factionID == 1 && _selectedSex != 0) _selectedSex = 0;  // Shaolin male-only
        if (factionID == 5 && _selectedSex != 1) _selectedSex = 1;  // Emei female-only
        Debug.Log($"[CreateRole] SetFaction({factionID}), sex={_selectedSex}");
        // Single pipeline: SelectSex updates gender visuals + calls Apply for avatar
        SelectSex(_selectedSex);

        _inFactionChange = false;
    }

    void OnFactionSelected(int factionID)
    {
        SetFaction(factionID);

        // Update imgSelected visuals in FactionList
        Transform factionList = null;
        foreach (var t in GetComponentsInChildren<Transform>(true))
            if (t.name == "FactionList") { factionList = t; break; }
        if (factionList == null) return;

        foreach (var kvp in FACTION_BTN)
        {
            var btnT = factionList.Find(kvp.Value);
            if (btnT == null) continue;
            var sel = btnT.Find("imgSelected");
            if (sel != null) sel.gameObject.SetActive(kvp.Key == factionID);
        }
    }

    // =========================================================================
    //  SERIES SELECTION
    // =========================================================================

    void WireSeriesTogles()
    {
        Transform seriesList = null;
        foreach (var t in GetComponentsInChildren<Transform>(true))
            if (t.name == "SeriesList") { seriesList = t; break; }
        if (seriesList == null) return;

        string[] names = { "Metal", "Wood", "Water", "Fire", "Earth" };
        for (int i = 0; i < names.Length; i++)
        {
            var toggleT = seriesList.Find(names[i]);
            if (toggleT == null) continue;

            int seriesIdx = i;
            var toggle = toggleT.GetComponent<Toggle>();
            if (toggle != null)
            {
                toggle.onValueChanged.RemoveAllListeners();
                toggle.onValueChanged.AddListener(isOn => { if (isOn) OnSeriesSelected(seriesIdx); });
            }
        }
    }

    void OnSeriesSelected(int seriesIdx)
    {
        if (seriesIdx < 0 || seriesIdx >= SERIES_FACTIONS.Length) return;

        Transform seriesList = null;
        foreach (var t in GetComponentsInChildren<Transform>(true))
            if (t.name == "SeriesList") { seriesList = t; break; }
        if (seriesList != null)
        {
            string[] names = { "Metal", "Wood", "Water", "Fire", "Earth" };
            for (int i = 0; i < names.Length; i++)
            {
                var toggleT = seriesList.Find(names[i]);
                if (toggleT == null) continue;
                var toggle = toggleT.GetComponent<Toggle>();
                if (toggle != null) toggle.SetIsOnWithoutNotify(i == seriesIdx);
                var imgSel = toggleT.Find("imgSelect");
                if (imgSel != null) imgSel.gameObject.SetActive(i == seriesIdx);
            }
        }

        ApplySeriesFilter(seriesIdx, SERIES_FACTIONS[seriesIdx][0]);
        Debug.Log($"[CreateRole] Series {seriesIdx} selected");
    }

    void WireFactionButtons()
    {
        Transform factionList = null;
        foreach (var t in GetComponentsInChildren<Transform>(true))
            if (t.name == "FactionList") { factionList = t; break; }
        if (factionList == null) return;

        foreach (var kvp in FACTION_BTN)
        {
            var btnT = factionList.Find(kvp.Value);
            if (btnT == null) continue;
            int fid = kvp.Key;
            var btn = btnT.GetComponent<Button>();
            if (btn == null)
            {
                var graphic = btnT.GetComponent<Graphic>();
                if (graphic != null) graphic.raycastTarget = true;
                btn = btnT.gameObject.AddComponent<Button>();
                if (graphic != null) btn.targetGraphic = graphic;
            }
            btn.onClick.RemoveAllListeners();
            btn.onClick.AddListener(() => OnFactionSelected(fid));
        }
    }

    // Faction button names in FactionList matching hierarchy
    static readonly System.Collections.Generic.Dictionary<int, string> FACTION_BTN = new() {
        {1,"Faction_shaolin"},{2,"Faction_tianwang"},{3,"Faction_tangmen"},{4,"Faction_wudu"},
        {5,"Faction_emei"},{6,"Faction_cuiyan"},{7,"Faction_gaibang"},{8,"Faction_tianren"},
        {9,"Faction_wudang"},{10,"Faction_kunlun"},{11,"Faction_mingjiao"},{12,"Faction_duanshi"},
        {13,"Faction_gumu"},{14,"Faction_badao"},{15,"Faction_xiaoyao"},{16,"Faction_baituosha"},
        {17,"Faction_taohua"},{18,"Faction_changge"},{19,"Faction_YiPinTang"},{20,"Faction_WuHuntang"},
    };

    void ApplySeriesFilter(int seriesIdx, int selectFactionID)
    {
        Transform factionList = null;
        foreach (var t in GetComponentsInChildren<Transform>(true))
            if (t.name == "FactionList") { factionList = t; break; }
        if (factionList == null) return;

        var seriesSet = new System.Collections.Generic.HashSet<int>(SERIES_FACTIONS[seriesIdx]);

        foreach (var kvp in FACTION_BTN)
        {
            var btnT = factionList.Find(kvp.Value);
            if (btnT == null) continue;
            btnT.gameObject.SetActive(seriesSet.Contains(kvp.Key));

            var sel = btnT.Find("imgSelected");
            if (sel != null) sel.gameObject.SetActive(kvp.Key == selectFactionID);
        }

        var template = factionList.Find("FactionTemplate");
        if (template != null) template.gameObject.SetActive(false);

        SetFaction(selectFactionID);
    }

    // =========================================================================
    //  DEFAULTS
    // =========================================================================

    void ApplyDefaults()
    {
        _selectedSex = 0;
        _selectedFactionID = 20;

        // Reset input field
        if (_inputName == null)
        {
            foreach (var input in GetComponentsInChildren<InputField>(true))
            {
                if (input.name == "inputRoleName") { _inputName = input; break; }
            }
        }
        if (_inputName != null)
        {
            var placeholder = _inputName.placeholder as Text;
            if (placeholder != null)
                placeholder.text = "Nhap ten nhan vat";
            _inputName.text = "";
        }

        // Apply default faction (Hỏa series, Vũ Huân Đường)
        // This calls SetFaction → SelectSex → Apply (single pipeline)
        ApplyDefaultFactionFilter();

        UpdateReturnButton();
        Debug.Log("[CreateRole] Defaults applied");
    }

    void ApplyDefaultFactionFilter()
    {
        OnSeriesSelected(3);
        OnFactionSelected(20);
    }

    void UpdateReturnButton()
    {
        bool hasRoles = LoginManager.Instance != null && LoginManager.Instance.Roles.Count > 0;
        foreach (var b in GetComponentsInChildren<Button>(true))
        {
            if (b.name == "btnReturn")
            {
                b.gameObject.SetActive(hasRoles);
                break;
            }
        }
    }

    // =========================================================================
    //  SUBMIT / RETURN / RESULT
    // =========================================================================

    void OnSubmitCreate()
    {
        string roleName = _inputName != null ? _inputName.text.Trim() : "";
        if (string.IsNullOrEmpty(roleName))
        {
            Debug.LogWarning("[CreateRole] Name is empty");
            return;
        }

        Debug.Log($"[CreateRole] Creating role: name={roleName}, sex={_selectedSex}, faction={_selectedFactionID}");
        LoginManager.Instance?.CreateRole(roleName, _selectedSex, _selectedFactionID);
    }

    void OnReturn()
    {
        bool hasRoles = LoginManager.Instance != null && LoginManager.Instance.Roles.Count > 0;
        if (!hasRoles)
        {
            Debug.Log("[CreateRole] No roles, cannot return");
            return;
        }

        var selectRoot = FindByName("UISelectRoleExist_Canvas");
        if (selectRoot == null)
            selectRoot = FindByName("UISelectRoleExist");

        if (selectRoot != null)
        {
            var myCanvas = transform;
            while (myCanvas.parent != null) myCanvas = myCanvas.parent;
            myCanvas.gameObject.SetActive(false);

            selectRoot.SetActive(true);

            if (LoginManager.Instance != null && LoginManager.Instance.Roles.Count > 0)
            {
                var bridge = selectRoot.GetComponent<SelectRoleRuntimeBridge>();
                if (bridge == null)
                    bridge = selectRoot.AddComponent<SelectRoleRuntimeBridge>();
            }

            Debug.Log("[CreateRole] Returned to SelectRole");
        }
        else
        {
            Debug.LogWarning("[CreateRole] UISelectRoleExist not found");
        }
    }

    void OnCreateResult(int resultCode, string data)
    {
        if (resultCode == 1)
        {
            Debug.Log("[CreateRole] Success! Switching to SelectRole...");
        }
        else
        {
            string msg = resultCode switch
            {
                -1  => "Tên không hợp lệ",
                -7  => "Đã đạt giới hạn số nhân vật",
                -12 => "Thao tác bị từ chối",
                _   => $"Tạo nhân vật thất bại ({resultCode})"
            };
            Debug.LogWarning($"[CreateRole] {msg}");
        }
    }

    // =========================================================================
    //  HELPERS
    // =========================================================================

    void WireButton(string name, UnityEngine.Events.UnityAction action)
    {
        foreach (var b in GetComponentsInChildren<Button>(true))
        {
            if (b.name == name)
            {
                b.onClick.RemoveAllListeners();
                b.onClick.AddListener(action);
                return;
            }
        }
    }

    static GameObject FindByName(string name)
    {
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
            if (t.name == name) return t.gameObject;
        return null;
    }
}
