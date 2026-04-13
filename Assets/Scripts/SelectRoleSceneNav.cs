using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif

// Wires SelectRoleScene runtime behavior without needing the Lua engine.
//
// Mirrors UISelectRoleExist.lua + UILoginBG.lua:
//   - btnCreateRole → Ui:OpenWindow("UICreateRole"); Ui:CloseWindow("UISelectRoleExist")
//   - btnReturn (UICreateRole) → CloseByDefault back to select-role
//   - Each Role_* item → toggles imgBgSelected, updates txtRoleName/txtRoleLv,
//                        and activates the matching character preview prefab.
//
// Character previews are imported via the standard pipeline from
// KTO_Resources/.../ui/loginbg/res_p_<id>.ab and instantiated as children of imgBG.
// Each prefab carries its bundle-exact RectTransform (sizeDelta + pivot). The
// duo-mode anchoredPosition baked in the bundle is overridden with the
// single-character avatar center from Setting/Faction/faction.tab
// (game_data/extracted_tabs/dat_549_nId_15c_21r.tab) — same value the lua
// applies via UILoginBG.Play() → Object_SetLocalPosition(CharacterMidPos[...]).
public class SelectRoleSceneNav : MonoBehaviour
{
    sealed class RoleEntry
    {
        public string PrefabPath;       // Assets/Prefabs/Imported/<name>.prefab
        public string StandPrefix;       // sprite frame name prefix (e.g. F2_5D)
        public Vector2 SinglePos;        // szMale/FemaleAvatarCenter from faction.tab
        public GameObject Instance;
        public SpriteFrameAnimator Animator;
    }

    // Sourced from:
    //   - res_p_43.ab / res_p_76.ab / res_p_9.ab (ui/loginbg/) → sizeDelta + pivot, baked into prefab
    //   - dat_549_nId_15c_21r.tab → szMale/FemaleAvatarCenter for single-character mode
    static readonly Dictionary<string, RoleEntry> Roles = new Dictionary<string, RoleEntry>
    {
        // Wudu (faction 4) - F_5D - szFemaleAvatarCenter = "59,-276"
        { "Role_MinhNguyệt", new RoleEntry { PrefabPath = "Assets/Prefabs/Imported/F_5D.prefab",  StandPrefix = "F2_5D",  SinglePos = new Vector2(59f,  -276f)    } },
        // WuHunTang (faction 20) - M_WHT - szMaleAvatarCenter = "45,-240"
        { "Role_HànThiên",   new RoleEntry { PrefabPath = "Assets/Prefabs/Imported/M_WHT.prefab", StandPrefix = "M2_WHT", SinglePos = new Vector2(45f,  -240f)    } },
        // TianWang (faction 2) - F_TW - szFemaleAvatarCenter = "100,-325.5"
        { "Role_PhongVân",   new RoleEntry { PrefabPath = "Assets/Prefabs/Imported/F_TW.prefab",  StandPrefix = "F2_TW",  SinglePos = new Vector2(100f, -325.5f) } },
    };

    void Awake() { Wire(); }

    // Runtime entry: when the SelectRoleScene loads in Play mode, kick Wire() so
    // the role list listeners + character prefab instances are present even if no
    // SelectRoleSceneNav MonoBehaviour exists in the scene.
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
    static void RuntimeBoot()
    {
        // Defer one frame to let the scene's Awake/Start finish first.
        var go = new GameObject("__SelectRoleSceneNavBoot");
        Object.DontDestroyOnLoad(go);
        var helper = go.AddComponent<BootHelper>();
        helper.StartCoroutine(helper.Boot());
    }

    sealed class BootHelper : MonoBehaviour
    {
        public System.Collections.IEnumerator Boot()
        {
            yield return null;
            // Only wire when SelectRoleScene's UI roots are present.
            if (FindByPath("UISelectRoleExist_Canvas/UISelectRoleExist") != null)
                Wire();
            Destroy(gameObject);
        }
    }

#if UNITY_EDITOR
    // Edit-mode auto-boot. UICreateRole's internals (faction list, gender
    // buttons, series toggles, etc.) are now driven by the imported prefab +
    // Lua engine. We only need Wire() to run so the popup-toggle between
    // UISelectRoleExist and UICreateRole is hooked up and the role-list
    // character previews are instantiated. Hook sceneOpened + a one-shot
    // delayCall on assembly reload so Wire() runs automatically whenever the
    // create-role scene is open in the editor.
    [UnityEditor.InitializeOnLoadMethod]
    static void EditorBoot()
    {
        UnityEditor.SceneManagement.EditorSceneManager.sceneOpened += (scene, mode) =>
        {
            ScheduleEditorWire();
        };
        ScheduleEditorWire();
    }

    static void ScheduleEditorWire()
    {
        UnityEditor.EditorApplication.delayCall += () =>
        {
            try
            {
                if (Application.isPlaying) return; // Play mode uses RuntimeBoot
                if (FindByPath("UICreateRole_Canvas/UICreateRole") == null) return;
                Wire();
            }
            catch (System.Exception e)
            {
                Debug.LogWarning($"[SelectRoleSceneNav] EditorBoot Wire failed: {e.Message}");
            }
        };
    }
#endif

    public static void Wire()
    {
        var selectRoot = FindByPath("UISelectRoleExist_Canvas/UISelectRoleExist");
        var createRoot = FindByPath("UICreateRole_Canvas/UICreateRole");
        if (createRoot == null)
        {
            Debug.LogWarning("[SelectRoleSceneNav] missing UICreateRole root — wiring skipped");
            return;
        }

        // Two scene shapes:
        //   - Legacy MainUIScene: UISelectRoleExist + UICreateRole side by side,
        //     popup toggle between them, role list with character previews.
        //   - CreateRoleScene: standalone UICreateRole only — no select-role
        //     layer, no popup toggling, just wire the create-role panel.
        if (selectRoot != null)
        {
            // Popup-closed default: UISelectRoleExist visible, UICreateRole hidden.
            // The saved scene has both panels active at once (render orders 1 and 2),
            // so the Vietnamese create-role layer draws on top of the Chinese
            // select-role layer. Force the default every time Wire() runs so the
            // scene can never be saved in a doubled state again.
            selectRoot.SetActive(true);
            createRoot.SetActive(false);

            var btnCreate = FindButton(selectRoot, "btnCreateRole");
            if (btnCreate != null)
            {
                btnCreate.onClick.RemoveAllListeners();
                btnCreate.onClick.AddListener(() =>
                {
                    selectRoot.SetActive(false);
                    createRoot.SetActive(true);
                });
            }

            var btnReturn = FindButton(createRoot, "btnReturn");
            if (btnReturn != null)
            {
                btnReturn.onClick.RemoveAllListeners();
                btnReturn.onClick.AddListener(() =>
                {
                    createRoot.SetActive(false);
                    selectRoot.SetActive(true);
                });
            }

            EnsureCharacterInstances(selectRoot);
            WireRoleListSelection(selectRoot);

            Debug.Log($"[SelectRoleSceneNav] wired btnCreateRole={(btnCreate != null)} btnReturn={(btnReturn != null)} + role-list + character prefabs");
        }
        else
        {
            // CreateRoleScene-only path. Just keep create-root active; the
            // imported UICreateRole prefab + Lua engine handle everything else.
            createRoot.SetActive(true);
            Debug.Log("[SelectRoleSceneNav] wired CreateRoleScene-only path (no UISelectRoleExist present)");
        }
    }

    static void EnsureCharacterInstances(GameObject selectRoot)
    {
#if UNITY_EDITOR
        var imgBG = selectRoot.transform.Find("imgBG");
        if (imgBG == null) { Debug.LogWarning("[SelectRoleSceneNav] imgBG not found"); return; }

        // Render order: above the role list / panel, below the bottom buttons.
        var panel = imgBG.Find("PanelSelectRole");
        int siblingIndex = panel != null ? panel.GetSiblingIndex() : 0;

        // Drop the legacy single-Image preview if a previous run left one.
        var legacy = imgBG.Find("CharacterPreview");
        if (legacy != null) DestroyImmediate(legacy.gameObject);

        foreach (var kv in Roles)
        {
            var entry = kv.Value;
            string instName = System.IO.Path.GetFileNameWithoutExtension(entry.PrefabPath);

            var existing = imgBG.Find(instName);
            GameObject inst;
            if (existing != null)
            {
                inst = existing.gameObject;
            }
            else
            {
                var prefab = AssetDatabase.LoadAssetAtPath<GameObject>(entry.PrefabPath);
                if (prefab == null) { Debug.LogWarning($"[SelectRoleSceneNav] missing prefab: {entry.PrefabPath}"); continue; }
                inst = (GameObject)PrefabUtility.InstantiatePrefab(prefab, imgBG);
                inst.name = instName;
                inst.transform.SetSiblingIndex(siblingIndex);
            }

            // Override the bundle's duo-mode anchoredPosition with the single-character
            // value from faction.tab. The bundle's sizeDelta + pivot stay untouched —
            // they're already exactly what the source has.
            var rt = inst.GetComponent<RectTransform>();
            if (rt != null) rt.anchoredPosition = entry.SinglePos;

            var img = inst.GetComponent<Image>();
            if (img != null) img.raycastTarget = false;

            // SpriteFrameAnimator drives the stand-frame swap. Bundle prefabs use a real
            // Animator + AnimationClip; that pipeline is not wired here. We sequence the
            // imported PNG frames at fps=12 instead.
            var anim = inst.GetComponent<SpriteFrameAnimator>();
            if (anim == null) anim = inst.AddComponent<SpriteFrameAnimator>();
            anim.fps = 12f;
            anim.loop = true;
            var frames = LoadStandFrames(entry.StandPrefix);
            if (frames != null && frames.Length > 0) anim.SetFrames(frames);

            inst.SetActive(false);
            entry.Instance = inst;
            entry.Animator = anim;
        }
#endif
    }

    static void WireRoleListSelection(GameObject selectRoot)
    {
        Transform list = null;
        foreach (var t in selectRoot.GetComponentsInChildren<Transform>(true))
        {
            if (t.name == "List" && t.parent != null && t.parent.name == "Viewport") { list = t; break; }
        }
        if (list == null) { Debug.LogWarning("[SelectRoleSceneNav] List not found"); return; }

        // The imported Viewport's Mask Image has sprite=null, which makes the Mask
        // generate no geometry → all child Role_* entries get clipped to nothing.
        // Assign Unity's default UISprite so the mask uses the RectTransform bounds.
        var viewport = list.parent;
        var vpImg = viewport != null ? viewport.GetComponent<Image>() : null;
        if (vpImg != null && vpImg.sprite == null)
        {
#if UNITY_EDITOR
            var defaultSprite = UnityEditor.AssetDatabase.GetBuiltinExtraResource<Sprite>("UI/Skin/UISprite.psd");
            if (defaultSprite != null)
            {
                vpImg.sprite = defaultSprite;
                vpImg.type = Image.Type.Sliced;
            }
#endif
            vpImg.color = new Color(1f, 1f, 1f, 1f);
            vpImg.raycastTarget = false;
        }

        Text txtRoleName = null, txtRoleLevel = null;
        foreach (var t in selectRoot.GetComponentsInChildren<Text>(true))
        {
            if (t.name == "txtRoleName") txtRoleName = t;
            if (t.name == "txtRoleLv")   txtRoleLevel = t;
        }

        var entries = new List<Transform>();
        foreach (Transform child in list)
        {
            if (child.name.StartsWith("Role_")) entries.Add(child);
        }
        if (entries.Count == 0) { Debug.LogWarning("[SelectRoleSceneNav] no Role_* entries found"); return; }

        foreach (var entry in entries)
        {
            var btn = entry.GetComponent<Button>();
            if (btn == null) continue;
            var captured = entry;
            btn.onClick.RemoveAllListeners();
            btn.onClick.AddListener(() => SelectRole(captured, entries, txtRoleName, txtRoleLevel));
        }

        SelectRole(entries[0], entries, txtRoleName, txtRoleLevel);
    }

    static void SelectRole(Transform picked, List<Transform> all, Text txtRoleName, Text txtRoleLevel)
    {
        foreach (var entry in all)
        {
            var sel = entry.Find("imgBgSelected");
            if (sel != null) sel.gameObject.SetActive(entry == picked);
        }

        var pickedName = picked.Find("txtName")?.GetComponent<Text>();
        var pickedLvl  = picked.Find("txtLevel")?.GetComponent<Text>();
        if (txtRoleName != null && pickedName != null) txtRoleName.text = pickedName.text;
        if (txtRoleLevel != null && pickedLvl != null) txtRoleLevel.text = pickedLvl.text;

        // Activate only the picked role's character prefab; hide the others.
        if (Roles.TryGetValue(picked.name, out var pickedRole))
        {
            foreach (var kv in Roles)
                if (kv.Value.Instance != null) kv.Value.Instance.SetActive(kv.Value == pickedRole);
        }
    }

    static Sprite[] LoadStandFrames(string prefix)
    {
#if UNITY_EDITOR
        // Find every sprite asset whose filename starts with "<prefix>_stand_"
        // and whose remaining tail is purely a frame number (e.g. 0001), skipping
        // layered variants like _1/_2/_3 (those are decoration overlays).
        // The same frame may exist in multiple folders (Sprite/loginbg + Texture2D);
        // dedupe by filename so each frame plays only once per loop.
        var guids = AssetDatabase.FindAssets($"t:Sprite {prefix}_stand");
        var byFrame = new Dictionary<string, string>(); // fileName → preferred path
        var head = prefix + "_stand_";
        foreach (var g in guids)
        {
            var path = AssetDatabase.GUIDToAssetPath(g);
            var fileName = System.IO.Path.GetFileNameWithoutExtension(path);
            if (!fileName.StartsWith(head)) continue;
            var rest = fileName.Substring(head.Length);
            if (rest.Contains("_")) continue; // _1/_2/_3 layer variants — skip
            // Prefer Assets/Sprite/loginbg copies (already imported as Sprite); fall back otherwise.
            if (!byFrame.TryGetValue(fileName, out var existing) || path.Contains("/Sprite/loginbg/"))
                byFrame[fileName] = path;
        }
        var keys = new List<string>(byFrame.Keys);
        keys.Sort(); // padded numbers → lexical sort == numeric sort
        var arr = new Sprite[keys.Count];
        for (int i = 0; i < keys.Count; i++) arr[i] = AssetDatabase.LoadAssetAtPath<Sprite>(byFrame[keys[i]]);
        return arr;
#else
        return new Sprite[0];
#endif
    }

    static GameObject FindByPath(string path)
    {
        var parts = path.Split('/');
        GameObject go = null;
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
            if (t.name == parts[0] && t.parent == null) { go = t.gameObject; break; }
        if (go == null) return null;
        for (int i = 1; i < parts.Length; i++)
        {
            Transform child = null;
            foreach (Transform c in go.transform)
                if (c.name == parts[i]) { child = c; break; }
            if (child == null) return null;
            go = child.gameObject;
        }
        return go;
    }

    static Button FindButton(GameObject root, string name)
    {
        foreach (var b in root.GetComponentsInChildren<Button>(true))
            if (b.name == name) return b;
        return null;
    }
}
