// Runtime bridge: populates UISelectRoleExist with data from LoginManager.Roles.
// Wires btnEnterGame → LoginManager.SelectRole, btnCreateRole → show CreateRole panel.
// Loads single character avatar based on selected role's faction + sex (mirrors Lua UILoginBG:Play).
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using KTO.Network;

public class SelectRoleRuntimeBridge : MonoBehaviour
{
    private int _selectedRoleID;
    private Transform _roleListContainer; // Viewport/List
    private GameObject _roleTemplate;     // First Role_* item, cloned for additional roles
    private Transform _characterContainer; // UILoginBG/Character
    private GameObject _currentAvatar;

    // Faction ID → avatar abbreviation (from faction.tab)
    static readonly Dictionary<int, string> FACTION_AVATAR = new()
    {
        {1, "SL"}, {2, "TW"}, {3, "TM"}, {4, "5D"}, {5, "EM"},
        {6, "CY"}, {7, "GB"}, {8, "TR"}, {9, "WD"}, {10, "KL"},
        {11, "MJ"}, {12, "DL"}, {13, "GM"}, {14, "BD"}, {15, "XY"},
        {16, "BTS"}, {17, "THD"}, {18, "CGM"}, {19, "YP"}, {20, "WHT"}
    };

    // Faction ID → icon sprite file name (under Assets/Sprite/faction_icon/)
    static readonly Dictionary<int, string> FACTION_ICON = new()
    {
        {1, "faction_shaolin"}, {2, "faction_tianwang"}, {3, "faction_tangmen"},
        {4, "faction_wudu"}, {5, "faction_emei"}, {6, "faction_cuiyan"},
        {7, "faction_gaibang"}, {8, "faction_tianren"}, {9, "faction_wudang"},
        {10, "faction_kunlun"}, {11, "faction_mingjiao"}, {12, "faction_duanshi"},
        {13, "faction_gumu"}, {14, "faction_badao"}, {15, "faction_xiaoyao"},
        {16, "faction_baituosha"}, {17, "faction_taohua"}, {18, "faction_changge"},
        {19, "faction_YiPinTang"}, {20, "faction_WuHuntang"}
    };

    void OnEnable()
    {
        if (LoginManager.Instance != null)
        {
            LoginManager.Instance.OnRoleListReceived += PopulateRoles;
            LoginManager.Instance.OnCreateRoleResult += OnCreateResult;
        }

        // Wire buttons every activation (runtime listeners are lost on domain reload
        // and Start() only runs once / not at all if object was inactive during reload)
        FindCharacterContainer();
        WireButtons();
        TranslateUI();

        // If roles already loaded (e.g., returning from create role), populate now
        if (LoginManager.Instance != null && LoginManager.Instance.Roles.Count > 0)
            PopulateRoles(LoginManager.Instance.Roles);
    }

    void OnDisable()
    {
        if (LoginManager.Instance != null)
        {
            LoginManager.Instance.OnRoleListReceived -= PopulateRoles;
            LoginManager.Instance.OnCreateRoleResult -= OnCreateResult;
        }
    }

    void Start()
    {
        // Primary init handled in OnEnable to survive domain reloads
    }

    void TranslateUI()
    {
        // Translate Chinese texts to Vietnamese (bundle has original Chinese)
        foreach (var txt in GetComponentsInChildren<Text>(true))
        {
            switch (txt.text)
            {
                case "进入游戏": txt.text = "Vào Giang Hồ"; break;
                case "创建角色": txt.text = "Tạo Nhân Vật"; break;
                case "删除角色": txt.text = "Xóa Nhân Vật"; break;
                case "返回": txt.text = "Quay Lại"; break;
                case "当前角色": txt.text = "Nhân vật"; break;
            }
        }

        // Hide VFX ring effects from UILoginBG (matches Lua OnCreate: all VFX inactive)
        HideLoginBGVFX();
    }

    void HideLoginBGVFX()
    {
        // In original Lua, UILoginBG:OnCreate sets all VFX and TY_frame to inactive.
        // They're only shown by Select() action animation, not by Play().
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
        {
            if (t.parent == null) continue;
            string pName = t.parent.name;
            // Hide VFX_TY_frame (ring effect) and series VFX
            if (pName == "VFX_after" || pName == "VFX_front")
            {
                if (t.gameObject.activeSelf)
                {
                    t.gameObject.SetActive(false);
                    Debug.Log($"[SelectRole] Hid VFX: {pName}/{t.name}");
                }
            }
        }
    }

    void FindCharacterContainer()
    {
        // UILoginBG/Character is the container where avatar prefabs are placed
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
        {
            if (t.name == "Character" && t.parent != null && t.parent.name == "UILoginBG")
            {
                _characterContainer = t;
                Debug.Log("[SelectRole] Found character container: UILoginBG/Character");

                // Ensure Character canvas is enabled with override sorting so the
                // avatar Image actually renders. Without overrideSorting, the
                // sub-canvas merges into UILoginBG's render group and the avatar
                // Image silently fails to draw (Unity sub-canvas merge ordering
                // quirk). order MUST be > UILoginBG canvas order (1): when both
                // are at 1, hierarchy tiebreak puts UILoginBG/bg AFTER Character
                // and the createrole_bg sprite covers the avatar batch. Same fix
                // as UICreateRoleAvatarController.EnsureCanvasSetup uses.
                var charCanvas = t.GetComponent<Canvas>();
                if (charCanvas != null)
                {
                    charCanvas.enabled = true;
                    charCanvas.overrideSorting = true;
                    charCanvas.sortingLayerName = "UI";
                    charCanvas.sortingOrder = 5;
                }
                break;
            }
        }
    }

    void WireButtons()
    {
        // Wire btnEnterGame
        var btnEnter = FindButtonInChildren("btnEnterGame");
        if (btnEnter != null)
        {
            btnEnter.onClick.RemoveAllListeners();
            btnEnter.onClick.AddListener(OnEnterGame);
        }

        // Wire btnCreateRole — toggle to CreateRole panel
        var btnCreate = FindButtonInChildren("btnCreateRole");
        if (btnCreate != null)
        {
            btnCreate.onClick.RemoveAllListeners();
            btnCreate.onClick.AddListener(OnCreateRole);
        }

        // Wire btnDeleteRole (optional, just log for now)
        var btnDelete = FindButtonInChildren("btnDeleteRole");
        if (btnDelete != null)
        {
            btnDelete.onClick.RemoveAllListeners();
            btnDelete.onClick.AddListener(() => Debug.Log("[SelectRole] Delete role not implemented"));
        }

        // Find the role list container
        foreach (var t in GetComponentsInChildren<Transform>(true))
        {
            if (t.name == "List" && t.parent != null && t.parent.name == "Viewport")
            {
                _roleListContainer = t;
                break;
            }
        }
    }

    void PopulateRoles(List<RoleInfo> roles)
    {
        if (_roleListContainer == null) return;

        // Find template item (named "Template" or "Role_*")
        var existingItems = new List<Transform>();
        Transform templateItem = null;
        foreach (Transform child in _roleListContainer)
        {
            if (child.name == "Template" || child.name.StartsWith("Role_"))
            {
                if (templateItem == null) templateItem = child;
                existingItems.Add(child);
            }
        }

        if (templateItem == null)
        {
            Debug.LogWarning("[SelectRole] No template items found in List");
            return;
        }

        // Use first item as template
        if (_roleTemplate == null)
            _roleTemplate = templateItem.gameObject;

        // Ensure we have enough items (clone or deactivate extras)
        while (existingItems.Count < roles.Count)
        {
            var clone = Instantiate(_roleTemplate, _roleListContainer);
            clone.name = $"Role_{existingItems.Count}";
            existingItems.Add(clone.transform);
        }

        // Populate each item
        for (int i = 0; i < existingItems.Count; i++)
        {
            var item = existingItems[i];

            if (i < roles.Count)
            {
                item.gameObject.SetActive(true);
                var role = roles[i];

                // Set name
                var txtName = item.Find("txtName")?.GetComponent<Text>();
                if (txtName != null) txtName.text = role.RoleName;

                // Set level (mirrors Lua: "{0}级" format)
                var txtLevel = item.Find("txtLevel")?.GetComponent<Text>();
                if (txtLevel != null) txtLevel.text = $"Lv.{role.Level}";

                // Set faction icon
                var imgFaction = item.Find("imgFactionIcon")?.GetComponent<Image>();
                if (imgFaction != null)
                    SetFactionIcon(imgFaction, role.FactionID);

                // Wire click
                var btn = item.GetComponent<Button>();
                if (btn != null)
                {
                    int roleID = role.RoleID;
                    int factionID = role.FactionID;
                    int sex = role.Sex;
                    int index = i;
                    btn.onClick.RemoveAllListeners();
                    btn.onClick.AddListener(() => SelectRole(roleID, factionID, sex, index, existingItems));
                }

                // Auto-select first role
                if (i == 0)
                    SelectRole(role.RoleID, role.FactionID, role.Sex, 0, existingItems);
            }
            else
            {
                item.gameObject.SetActive(false);
            }
        }

        Debug.Log($"[SelectRole] Populated {roles.Count} roles in UI");
    }

    void SelectRole(int roleID, int factionID, int sex, int index, List<Transform> allItems)
    {
        _selectedRoleID = roleID;

        // Update selection highlight
        for (int i = 0; i < allItems.Count; i++)
        {
            var sel = allItems[i].Find("imgBgSelected");
            if (sel != null) sel.gameObject.SetActive(i == index);
        }

        // Update header
        var lm = LoginManager.Instance;
        if (lm != null)
        {
            foreach (var role in lm.Roles)
            {
                if (role.RoleID == roleID)
                {
                    var txtRoleName = FindTextInChildren("txtRoleName");
                    var txtRoleLv = FindTextInChildren("txtRoleLv");
                    if (txtRoleName != null) txtRoleName.text = role.RoleName;
                    if (txtRoleLv != null) txtRoleLv.text = $"Lv.{role.Level}";
                    break;
                }
            }
        }

        // Show character avatar for this role (mirrors Lua UILoginBG:Play)
        ShowCharacter(factionID, sex);

        Debug.Log($"[SelectRole] Selected roleID={roleID}, faction={factionID}, sex={sex}");
    }

    // ── Character Avatar Display (mirrors Lua UILoginBG:Play) ──

    // CharacterMidPos from faction.tab (szMaleAvatarCenter / szFemaleAvatarCenter)
    // Key = avatar name, Value = (x, y) center position for single-character mode
    static readonly Dictionary<string, Vector2> CHAR_MID_POS = new()
    {
        {"M_SL",  new Vector2(50, -265)},
        {"M_TW",  new Vector2(63, -322.5f)}, {"F_TW",  new Vector2(100, -325.5f)},
        {"M_TM",  new Vector2(40, -276)},    {"F_TM",  new Vector2(30, -268)},
        {"M_5D",  new Vector2(0, -276)},     {"F_5D",  new Vector2(59, -276)},
        {"F_EM",  new Vector2(77, -305)},
        {"M_CY",  new Vector2(17, -268)},    {"F_CY",  new Vector2(30, -268)},
        {"M_GB",  new Vector2(48, -276)},    {"F_GB",  new Vector2(90, -274)},
        {"M_TR",  new Vector2(-26, -389)},   {"F_TR",  new Vector2(74, -283)},
        {"M_WD",  new Vector2(21, -311.5f)}, {"F_WD",  new Vector2(53, -283)},
        {"M_KL",  new Vector2(31, -265)},    {"F_KL",  new Vector2(28, -274)},
        {"M_MJ",  new Vector2(11, -268)},    {"F_MJ",  new Vector2(51, -258)},
        {"M_DL",  new Vector2(57, -276)},    {"F_DL",  new Vector2(92, -296)},
        {"M_GM",  new Vector2(30, -270)},    {"F_GM",  new Vector2(36, -274)},
        {"M_BD",  new Vector2(30, -300)},    {"F_BD",  new Vector2(45, -296)},
        {"M_XY",  new Vector2(15, -300)},    {"F_XY",  new Vector2(28, -296)},
        {"M_BTS", new Vector2(40, -319)},    {"F_BTS", new Vector2(40, -285)},
        {"M_THD", new Vector2(15, -300)},    {"F_THD", new Vector2(28, -296)},
        {"M_CGM", new Vector2(15, -300)},    {"F_CGM", new Vector2(28, -296)},
        {"M_YP",  new Vector2(15, -300)},    {"F_YP",  new Vector2(28, -296)},
        {"M_WHT", new Vector2(45, -240)},    {"F_WHT", new Vector2(45, -240)},
    };

    void ShowCharacter(int factionID, int sex)
    {
        if (_characterContainer == null)
        {
            FindCharacterContainer();
            if (_characterContainer == null) return;
        }

        // Hide ALL existing children in Character container (including _AvatarHost from CreateRole)
        foreach (Transform child in _characterContainer)
            child.gameObject.SetActive(false);

        // Destroy previous avatar we spawned
        if (_currentAvatar != null)
            Destroy(_currentAvatar);

        string avatarName = GetAvatarName(factionID, sex);
        if (string.IsNullOrEmpty(avatarName))
        {
            Debug.LogWarning($"[SelectRole] No avatar for faction={factionID}, sex={sex}");
            return;
        }

        // Load avatar prefab
        GameObject prefab = null;
        #if UNITY_EDITOR
        string path = $"Assets/game/ui/loginbg/{avatarName}.prefab";
        prefab = UnityEditor.AssetDatabase.LoadAssetAtPath<GameObject>(path);
        #endif

        if (prefab == null)
        {
            Debug.LogWarning($"[SelectRole] Avatar prefab not found: {avatarName}");
            return;
        }

        _currentAvatar = Instantiate(prefab, _characterContainer);
        _currentAvatar.name = avatarName;
        _currentAvatar.SetActive(true);

        // Issue 3 fix — F2_WHT_stand_0007.asset has rect.y=11.149 while other frames
        // have rect.y=0. Unity's standard Image quad uses rect.y as padding → that
        // single frame renders ~11px higher than its siblings → up/down flicker each
        // time the Animator swaps to it. useSpriteMesh=true makes Image build the
        // mesh from the sprite's actual vertex data instead, which aligns identically
        // across frames. Apply to every Image inside the avatar so the same
        // bad-frame-metadata bug can't bite future sprites either.
        foreach (var img in _currentAvatar.GetComponentsInChildren<Image>(true))
            img.useSpriteMesh = true;

        // Issue 4 fix (F_EM oversize) — RUNTIME ONLY, prefab untouched to match
        // RippedProject_APK source. The original prefab has sizeDelta=(604,604)
        // but the animation frames have sprite rect ~(352,446). In Tuanjie Unity
        // the sprite renders at native rect; in standard Unity the sprite mesh
        // stretches to fill sizeDelta → 1.72x horizontal stretch → character
        // looks distorted. Force animator to first frame so .asset sprite is
        // active, then override sizeDelta to the sprite's actual rect.
        var animator = _currentAvatar.GetComponent<Animator>();
        if (animator != null && animator.runtimeAnimatorController != null)
            animator.Update(0f);
        var rootImg = _currentAvatar.GetComponent<Image>();
        var rootRT  = _currentAvatar.GetComponent<RectTransform>();
        if (rootImg != null && rootImg.sprite != null && rootRT != null)
        {
            // Only shrink — never grow — the rect, so avatars whose prefab
            // sizeDelta already matches their sprite (M_SL etc.) are left alone.
            Vector2 spriteSize = rootImg.sprite.rect.size;
            if (spriteSize.x > 0 && spriteSize.y > 0
                && (spriteSize.x < rootRT.sizeDelta.x * 0.85f
                 || spriteSize.y < rootRT.sizeDelta.y * 0.85f))
            {
                rootRT.sizeDelta = spriteSize;
            }
        }

        // Apply CharacterMidPos (mirrors Lua UILoginBG:Play → Object_SetLocalPosition)
        var rt = _currentAvatar.GetComponent<RectTransform>();
        if (rt != null)
        {
            if (CHAR_MID_POS.TryGetValue(avatarName, out Vector2 midPos))
                rt.anchoredPosition = midPos;
            else
                rt.anchoredPosition = new Vector2(30, -280); // sensible fallback
        }

        Debug.Log($"[SelectRole] Showing avatar: {avatarName} at {rt?.anchoredPosition}");
    }

    static string GetAvatarName(int factionID, int sex)
    {
        if (!FACTION_AVATAR.TryGetValue(factionID, out string abbr)) return null;
        // sex: 0=male, 1=female
        // ShaoLin(1) is male-only, EMei(5) is female-only
        if (factionID == 1 && sex == 1) return null; // no female ShaoLin
        if (factionID == 5 && sex == 0) return null; // no male EMei
        return (sex == 0 ? "M_" : "F_") + abbr;
    }

    void SetFactionIcon(Image img, int factionID)
    {
        if (!FACTION_ICON.TryGetValue(factionID, out string spriteName)) return;

        #if UNITY_EDITOR
        string path = $"Assets/Sprite/faction_icon/{spriteName}.png";
        var sprite = UnityEditor.AssetDatabase.LoadAssetAtPath<Sprite>(path);
        if (sprite != null)
            img.sprite = sprite;
        #endif
    }

    // ── Button handlers ──

    void OnEnterGame()
    {
        if (_selectedRoleID <= 0)
        {
            Debug.LogWarning("[SelectRole] No role selected");
            return;
        }
        Debug.Log($"[SelectRole] Entering game with roleID={_selectedRoleID}");
        LoginManager.Instance?.SelectRole(_selectedRoleID);
    }

    void OnCreateRole()
    {
        // Clean up avatar
        if (_currentAvatar != null)
            Destroy(_currentAvatar);

        // Hide SelectRole canvas
        var selectRoot = transform;
        while (selectRoot.parent != null) selectRoot = selectRoot.parent;
        selectRoot.gameObject.SetActive(false);

        // Find and show CreateRole canvas
        var createRoot = FindByName("UICreateRole_Canvas");
        if (createRoot == null)
            createRoot = FindByName("UICreateRole");

        if (createRoot != null)
        {
            createRoot.SetActive(true);

            // Fix canvas render mode (must be ScreenSpaceCamera to layer correctly)
            var canvas = createRoot.GetComponent<Canvas>();
            if (canvas != null && canvas.renderMode == RenderMode.ScreenSpaceOverlay)
            {
                canvas.renderMode = RenderMode.ScreenSpaceCamera;
                canvas.worldCamera = Camera.main;
                canvas.sortingLayerName = "UI";
                canvas.sortingOrder = 10;
            }

            // Ensure runtime bridge is attached
            if (createRoot.GetComponent<CreateRoleRuntimeBridge>() == null)
            {
                // Search in children too (UICreateRole child of UICreateRole_Canvas)
                var bridge = createRoot.GetComponentInChildren<CreateRoleRuntimeBridge>(true);
                if (bridge == null)
                    createRoot.AddComponent<CreateRoleRuntimeBridge>();
            }

            Debug.Log("[SelectRole] Switched to CreateRole");
        }
        else
        {
            Debug.LogWarning("[SelectRole] UICreateRole not found");
        }
    }

    void OnCreateResult(int resultCode, string data)
    {
        if (resultCode == 1)
        {
            Debug.Log("[SelectRole] Role created, waiting for updated role list...");
        }
    }

    // ── Helpers ──

    Button FindButtonInChildren(string name)
    {
        foreach (var b in GetComponentsInChildren<Button>(true))
            if (b.name == name) return b;
        return null;
    }

    Text FindTextInChildren(string name)
    {
        foreach (var t in GetComponentsInChildren<Text>(true))
            if (t.name == name) return t;
        return null;
    }

    static GameObject FindByName(string name)
    {
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
            if (t.name == name && t.parent == null) return t.gameObject;
        // Also check nested
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
            if (t.name == name) return t.gameObject;
        return null;
    }

    static string GetFactionName(int factionID)
    {
        return factionID switch
        {
            1  => "Thiếu Lâm",
            2  => "Thiên Vương",
            3  => "Đường Môn",
            4  => "Ngũ Độc",
            5  => "Nga My",
            6  => "Thúy Yên",
            7  => "Cái Bang",
            8  => "Thiên Nhẫn",
            9  => "Võ Đang",
            10 => "Côn Lôn",
            11 => "Minh Giáo",
            12 => "Đoàn Thị",
            13 => "Cổ Mộ",
            14 => "Bá Đao",
            15 => "Tiêu Dao",
            16 => "Bạch Đà Sơn",
            17 => "Đào Hoa",
            18 => "Trường Ca",
            19 => "Nhất Phẩm Đường",
            20 => "Vũ Huân Đường",
            _  => $"Faction {factionID}"
        };
    }
}
