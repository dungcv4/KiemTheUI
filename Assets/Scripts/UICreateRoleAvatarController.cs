// UICreateRoleAvatarController
// ============================
// Mirrors UILoginBG.lua behavior:
//   - RequestAvatarRes → DynamicLoadGameObjectAsync(Character, UI/loginbg/{name}.prefab)
//   - PlayDuo(factionId) → show both male+female under Character mount
//   - Select(factionId, sex) → SetTrigger("action") + sync VFX X position
//
// Original bundle structure (from res_p_134 UILoginBG.prefab):
//   UILoginBG (Canvas SSC, sortingLayer="UI" ID=194136777, order=-1)
//     bg (Image)
//     VFX_after (SortingGroup, sortingLayer="UI", order=0) → particles behind
//     Character (Canvas, sortingLayer="UI", order=1) → avatar prefabs
//     VFX_front (SortingGroup, sortingLayer="UI", order=2) → particles front
//
// Avatar prefab structure (from loginbg bundles):
//   GameObject with RectTransform + CanvasRenderer + Image + Animator
//   AnimatorController: stand (loop) ←→ action (trigger)
//   AnimationClip: PPtrCurve swaps Image.m_Sprite through frame sequence
//
// DEVIATION from original:
//   Character Canvas overrideSorting set to true at runtime.
//   Original has overrideSorting=false because it uses 3D models (camera Z-depth).
//   We use 2D sprite Images that need Canvas sorting to render between VFX layers.

using UnityEngine;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public static class UICreateRoleAvatarController
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
    static void ResetStaticState()
    {
        s_canvasSetupDone = false;
        s_sortingFixed = false;
        s_lastFid = -1;
    }

    // factionId (1-based) → avatar prefab name (from Faction.tbFactionInfo)
    static readonly string[] kMaleAvatar = {
        "M_SL",  // 1  shaolin
        "M_TW",  // 2  tianwang
        "M_TM",  // 3  tangmen
        "M_5D",  // 4  wudu
        null,    // 5  emei (female only)
        "M_CY",  // 6  cuiyan
        "M_GB",  // 7  gaibang
        "M_TR",  // 8  tianren
        "M_WD",  // 9  wudang
        "M_KL",  // 10 kunlun
        "M_MJ",  // 11 mingjiao
        "M_DL",  // 12 duanshi
        "M_GM",  // 13 gumu
        "M_BD",  // 14 badao
        "M_XY",  // 15 xiaoyao
        "M_BTS", // 16 baituosha
        "M_THD", // 17 taohua
        "M_CGM", // 18 changge
        "M_YP",  // 19 yipintang
        "M_WHT", // 20 wuhuntang
    };
    static readonly string[] kFemaleAvatar = {
        null,    // 1  shaolin (male only)
        "F_TW",  // 2  tianwang
        "F_TM",  // 3  tangmen
        "F_5D",  // 4  wudu
        "F_EM",  // 5  emei
        "F_CY",  // 6  cuiyan
        "F_GB",  // 7  gaibang
        "F_TR",  // 8  tianren
        "F_WD",  // 9  wudang
        "F_KL",  // 10 kunlun
        "F_MJ",  // 11 mingjiao
        "F_DL",  // 12 duanshi
        "F_GM",  // 13 gumu
        "F_BD",  // 14 badao
        "F_XY",  // 15 xiaoyao
        "F_BTS", // 16 baituosha
        "F_THD", // 17 taohua
        "F_CGM", // 18 changge
        "F_YP",  // 19 yipintang
        "F_WHT", // 20 wuhuntang
    };

    // factionId (1-based) → radar polygon sprite asset name
    static readonly string[] kRadarSprite = {
        "img_factioninfo_shaolin",     // 1
        "img_factioninfo_tianwang",    // 2
        "img_factioninfo_tangmen",     // 3
        "img_factioninfo_wudu",        // 4
        "img_factioninfo_emei",        // 5
        "img_factioninfo_cuiyan",      // 6
        "img_factioninfo_gaibang",     // 7
        "img_factioninfo_tianren",     // 8
        "img_factioninfo_wudang",      // 9
        "img_factioninfo_kunlun",      // 10
        "img_factioninfo_mingjiao",    // 11
        "img_factioninfo_duanshi",     // 12
        "img_factioninfo_gumu",        // 13
        "img_factioninfo_badao",       // 14
        "img_factioninfo_xiaoyao",     // 15
        "img_factioninfo_baituoshan",  // 16
        "img_factioninfo_taohua",      // 17
        "img_factioninfo_changge",     // 18
        "img_factioninfo_YiPintang",   // 19
        "img_factioninfo_Wuhuntang",   // 20
    };
    const string kRadarPath = "imgBG/FactionInfo/FactionInfo/imgFactionInfo";

    const int kSexMale   = 1;
    const int kSexFemale = 2;

    const string kHostName     = "_AvatarHost";
    const string kPrefabFolder = "Assets/Prefabs/Imported/Avatars";

    // factionId (1-based) → series index (nSeries from faction.tab)
    static readonly int[] kFactionSeries = {
        1, 1, 2, 2, 3, 3, 4, 4, 5, 5,
        2, 3, 5, 1, 4, 2, 3, 5, 1, 4,
    };

    // VFX paths inside UILoginBG (mirrors tbControls in UILoginBG.lua)
    const string kLoginBgRoot = "UILoginBG";
    static readonly string[] kVfxFrames = {
        "VFX_after/VFX_TY_frame_after",
        "VFX_front/VFX_TY_frame_front",
    };
    static readonly string[][] kVfxSeries = {
        new[] { "VFX_after/VFX_jin_after",  "VFX_front/VFX_jin_front"  },
        new[] { "VFX_after/VFX_mu_after",   "VFX_front/VFX_mu_front"   },
        new[] { "VFX_after/VFX_shui_after", "VFX_front/VFX_shui_front" },
        new[] { "VFX_after/VFX_huo_after",  "VFX_front/VFX_huo_front"  },
        new[] { "VFX_after/VFX_tu_after",   "VFX_front/VFX_tu_front"   },
    };

    // Gender icon paths + sprite names
    const string kBtnMalePath   = "imgBG/SelectGender/btnMale";
    const string kBtnFemalePath = "imgBG/SelectGender/btnFemale";
    const string kSpriteMaleSelect    = "btn_gender_male_select";
    const string kSpriteMaleUnselect  = "btn_gender_male_unselect";
    const string kSpriteFemaleSelect  = "btn_gender_female_select";
    const string kSpriteFemaleUnselect = "btn_gender_female_unselect";

    // Legacy baked char_male/char_female in UICreateRole (hide them)
    static readonly string[] kLegacyPortraitChildren = {
        "imgBG/CharacterPortrait/char_male",
        "imgBG/CharacterPortrait/char_female"
    };

    static int s_lastFid = -1;

    // --- Main entry point (mirrors UILoginBG.lua Select) ---
    public static void Apply(int factionId, int sex, bool forceAction = false)
    {
        if (factionId < 1 || factionId > 20) return;
        if (sex != kSexMale && sex != kSexFemale) sex = kSexMale;

        string maleName   = kMaleAvatar[factionId - 1];
        string femaleName = kFemaleAvatar[factionId - 1];
        if (string.IsNullOrEmpty(maleName) && string.IsNullOrEmpty(femaleName)) return;

        // Update UI elements on UICreateRole (SSO canvas)
        var createRoleRoot = GameObject.Find("UICreateRole_Canvas/UICreateRole")
                               ?? GameObject.Find("UICreateRole");
        if (createRoleRoot != null)
        {
            foreach (var p in kLegacyPortraitChildren)
            {
                var t = createRoleRoot.transform.Find(p);
                if (t != null && t.gameObject.activeSelf) t.gameObject.SetActive(false);
            }
            ApplyRadarSprite(createRoleRoot.transform, factionId);
            ApplyGenderIcons(createRoleRoot.transform, sex);
        }

        // Get or create avatar host under UILoginBG/Character
        var host = GetOrCreateHost();
        if (host == null) return;

        bool factionChanged = (factionId != s_lastFid);
        s_lastFid = factionId;

        // Mirrors UILoginBG.lua PlayDuo: spawn both male+female on faction change
        if (factionChanged || host.childCount == 0)
        {
            for (int i = host.childCount - 1; i >= 0; i--)
                Object.DestroyImmediate(host.GetChild(i).gameObject);

            if (!string.IsNullOrEmpty(maleName))   SpawnAvatar(host, maleName);
            if (!string.IsNullOrEmpty(femaleName)) SpawnAvatar(host, femaleName);
        }

        string selectedName = (sex == kSexMale) ? maleName : femaleName;
        if (string.IsNullOrEmpty(selectedName))
            selectedName = (sex == kSexMale) ? femaleName : maleName;
        if (string.IsNullOrEmpty(selectedName)) return;

        // Mirrors UILoginBG.lua Select: SetTrigger("action") on selected avatar
        if (factionChanged || forceAction)
        {
            var sel = host.Find(selectedName);
            if (sel != null)
            {
                var animator = sel.GetComponent<Animator>();
                if (animator != null)
                    animator.SetTrigger("action");
            }
        }

        // Activate VFX and sync position (mirrors UILoginBG.lua Select lines 203-218)
        ApplyLoginBgVfx(host, factionId, selectedName);
    }

    static void SpawnAvatar(Transform host, string avatarName)
    {
        string prefabPath = kPrefabFolder + "/" + avatarName + ".prefab";
        GameObject prefab = LoadPrefab(prefabPath);
        if (prefab == null)
        {
            Debug.LogWarning("[AvatarCtrl] Missing prefab " + prefabPath);
            return;
        }
        GameObject instance;
#if UNITY_EDITOR
        instance = (GameObject)PrefabUtility.InstantiatePrefab(prefab, host);
#else
        instance = Object.Instantiate(prefab, host);
#endif
        instance.name = avatarName;
        var rt = instance.GetComponent<RectTransform>();
        if (rt != null)
            rt.localRotation = Quaternion.identity;
    }

    static Transform GetOrCreateHost()
    {
        var lbg = GameObject.Find(kLoginBgRoot);
        if (lbg == null) return null;

        EnsureCanvasSetup(lbg);

        var charTransform = lbg.transform.Find("Character");
        if (charTransform == null) return null;

        // Clean up orphan _AvatarHost from old approach
        var createRole = GameObject.Find("UICreateRole");
        if (createRole != null)
        {
            var oldHosts = createRole.GetComponentsInChildren<RectTransform>(true);
            for (int i = 0; i < oldHosts.Length; i++)
            {
                if (oldHosts[i] != null && oldHosts[i].name == kHostName)
                    Object.DestroyImmediate(oldHosts[i].gameObject);
            }
            var oldRing = createRole.transform.Find("imgBG/CharacterPortrait/SelectionRing");
            if (oldRing != null) Object.DestroyImmediate(oldRing.gameObject);
        }

        var host = charTransform.Find(kHostName);
        if (host == null)
        {
            var hostGO = new GameObject(kHostName, typeof(RectTransform));
            host = hostGO.transform;
            host.SetParent(charTransform, false);
            var hrt = (RectTransform)host;
            hrt.anchorMin = new Vector2(0.5f, 0.5f);
            hrt.anchorMax = new Vector2(0.5f, 0.5f);
            hrt.pivot     = new Vector2(0.5f, 0.5f);
            hrt.anchoredPosition = Vector2.zero;
            hrt.sizeDelta = Vector2.zero;
        }
        return host;
    }

    static void ApplyLoginBgVfx(Transform avatarHost, int factionId, string selectedAvatarName)
    {
        var lbg = GameObject.Find(kLoginBgRoot);
        if (lbg == null) return;

        EnsureVfxSortingLayers(lbg.transform);

        // Ensure VFX containers are active and Y position is reset
        var vfxAfter = lbg.transform.Find("VFX_after");
        var vfxFront = lbg.transform.Find("VFX_front");
        if (vfxAfter != null)
        {
            if (!vfxAfter.gameObject.activeSelf) vfxAfter.gameObject.SetActive(true);
            var rt = vfxAfter.GetComponent<RectTransform>();
            if (rt != null && Mathf.Abs(rt.anchoredPosition.y) > 0.01f)
                rt.anchoredPosition = new Vector2(rt.anchoredPosition.x, 0f);
        }
        if (vfxFront != null)
        {
            if (!vfxFront.gameObject.activeSelf) vfxFront.gameObject.SetActive(true);
            var rt = vfxFront.GetComponent<RectTransform>();
            if (rt != null && Mathf.Abs(rt.anchoredPosition.y) > 0.01f)
                rt.anchoredPosition = new Vector2(rt.anchoredPosition.x, 0f);
        }

        // Activate foot-circle frames
        // Original Select (lines 208-211): SetActive(true) after Stop() deactivated them.
        // We use false→true to ensure particle restart via OnDisable→OnEnable→playOnAwake.
        foreach (var framePath in kVfxFrames)
        {
            var t = lbg.transform.Find(framePath.Trim());
            if (t != null)
            {
                t.gameObject.SetActive(false);
                t.gameObject.SetActive(true);
            }
        }

        // Activate correct series VFX for faction, deactivate others.
        // Original Select (lines 214-218): SetActive(false) → SetActive(true) restarts
        // particle systems via OnDisable→OnEnable→playOnAwake. This is critical —
        // SetActive(true) on already-active object is a no-op and won't restart particles.
        int series = (factionId >= 1 && factionId <= kFactionSeries.Length)
            ? kFactionSeries[factionId - 1] : 1;
        for (int i = 0; i < kVfxSeries.Length; i++)
        {
            bool active = (i == series - 1);
            foreach (var path in kVfxSeries[i])
            {
                var t = lbg.transform.Find(path.Trim());
                if (t != null)
                {
                    if (active)
                    {
                        t.gameObject.SetActive(false);
                        t.gameObject.SetActive(true);
                    }
                    else
                    {
                        t.gameObject.SetActive(false);
                    }
                }
            }
        }

        // Sync VFX X position to selected avatar (mirrors UILoginBG.lua lines 210-218)
        var selAvatar = avatarHost.Find(selectedAvatarName);
        if (selAvatar != null)
        {
            var avatarRT = selAvatar.GetComponent<RectTransform>();
            if (avatarRT != null)
            {
                float x = avatarRT.anchoredPosition.x;
                SyncVfxXPosition(lbg.transform, "VFX_after", x);
                SyncVfxXPosition(lbg.transform, "VFX_front", x);
            }
        }
    }

    static void SyncVfxXPosition(Transform lbgRoot, string containerName, float x)
    {
        var container = lbgRoot.Find(containerName);
        if (container == null) return;
        var rt = container.GetComponent<RectTransform>();
        if (rt != null)
        {
            // Original prefab has VFX at (0,0); only X is synced to avatar position.
            // Y stays at 0 (VFX particles handle vertical positioning internally).
            rt.anchoredPosition = new Vector2(x, 0f);
        }
    }

    // Canvas setup — keeps original structure, only sets overrideSorting on Character.
    //
    // DEVIATION: Character Canvas overrideSorting=true (original is false).
    // Reason: original uses 3D models sorted by camera Z-depth. We use 2D Image
    // sorted by Canvas system. overrideSorting=true makes Character render at
    // sortingOrder=1 between VFX_after(0) and VFX_front(2).
    static bool s_canvasSetupDone;
    static void EnsureCanvasSetup(GameObject lbg)
    {
        if (s_canvasSetupDone) return;
        s_canvasSetupDone = true;

        // UILoginBG root Canvas: ensure sortingLayer="UI" (original uses sortingLayerID=194136777)
        var lbgCanvas = lbg.GetComponent<Canvas>();
        if (lbgCanvas != null)
        {
            lbgCanvas.sortingLayerName = "UI";
        }

        // Swap UILoginBG/bg sprite to createrole_bg
        var lbgBg = lbg.transform.Find("bg");
        if (lbgBg != null)
        {
            var bgImg = lbgBg.GetComponent<Image>();
            if (bgImg != null)
            {
#if UNITY_EDITOR
                var guids = AssetDatabase.FindAssets("t:Sprite createrole_bg");
                foreach (var g in guids)
                {
                    var path = AssetDatabase.GUIDToAssetPath(g);
                    var spr = AssetDatabase.LoadAssetAtPath<Sprite>(path);
                    if (spr != null && spr.name == "createrole_bg")
                    {
                        bgImg.sprite = spr;
                        bgImg.type = Image.Type.Simple;
                        bgImg.preserveAspect = false;
                        bgImg.enabled = true;
                        break;
                    }
                }
#endif
            }
        }

        // Character Canvas: keep original, enable overrideSorting + ensure enabled.
        // Original bundle has: Canvas(m_RenderMode=2, m_Enabled=1, overrideSorting=0, sortingOrder=1, sortingLayerID=194136777)
        // We set overrideSorting=true so Image avatars sort at order=1 between VFX layers.
        var charTransform = lbg.transform.Find("Character");
        if (charTransform != null)
        {
            var charCanvas = charTransform.GetComponent<Canvas>();
            if (charCanvas != null)
            {
                charCanvas.enabled = true;
                charCanvas.overrideSorting = true;
                charCanvas.sortingLayerName = "UI";
                charCanvas.sortingOrder = 1;
            }
        }

        // UICreateRole_Canvas must be SSC (not SSO) so UILoginBG renders behind it.
        // SSO always covers SSC, making UILoginBG invisible.
        // Original: both UILoginBG and UICreateRole use SSC with same camera.
        var createRoleCanvasGO = GameObject.Find("UICreateRole_Canvas");
        if (createRoleCanvasGO != null)
        {
            var crc = createRoleCanvasGO.GetComponent<Canvas>();
            if (crc != null && crc.renderMode == RenderMode.ScreenSpaceOverlay)
            {
                crc.renderMode = RenderMode.ScreenSpaceCamera;
                crc.worldCamera = Camera.main;
                crc.sortingLayerName = "UI";
                crc.sortingOrder = 10;
            }
            // Make imgBG transparent so UILoginBG shows through
            var imgBG = createRoleCanvasGO.transform.Find("UICreateRole/imgBG");
            if (imgBG != null)
            {
                var bgImage = imgBG.GetComponent<Image>();
                if (bgImage != null)
                    bgImage.color = new Color(0, 0, 0, 0);
            }
        }

        // Disable Background_Canvas
        var bgCanvasGO = GameObject.Find("Background_Canvas");
        if (bgCanvasGO != null)
            bgCanvasGO.SetActive(false);
    }

    // Fix sorting layers on VFX: bundle uses sortingLayerID=194136777 ("UI")
    // which now exists in TagManager.
    static bool s_sortingFixed;
    static void EnsureVfxSortingLayers(Transform lbgRoot)
    {
        if (s_sortingFixed) return;
        s_sortingFixed = true;

        var sortingGroups = lbgRoot.GetComponentsInChildren<UnityEngine.Rendering.SortingGroup>(true);
        foreach (var sg in sortingGroups)
            sg.sortingLayerName = "UI";

        var renderers = lbgRoot.GetComponentsInChildren<ParticleSystemRenderer>(true);
        foreach (var psr in renderers)
        {
            psr.sortingLayerName = "UI";

            if (psr.sharedMaterial == null)
            {
                psr.enabled = false;
                continue;
            }

            // Runtime swap: if material still uses old dummy shader, find URP version
            // Note: "C_EffectStandard_URP" is our URP port — don't swap it
            if (psr.sharedMaterial.shader != null
                && psr.sharedMaterial.shader.name == "effect/C_EffectStandard")
            {
#if UNITY_EDITOR
                string urpPath = "Assets/Material/VFX_URP/" + psr.sharedMaterial.name + "_URP.mat";
                var urpMat = UnityEditor.AssetDatabase.LoadAssetAtPath<Material>(urpPath);
                if (urpMat != null)
                    psr.sharedMaterial = urpMat;
                else
                    psr.enabled = false;
#else
                psr.enabled = false;
#endif
            }

            // Also fix trail/secondary materials using old dummy shader
#if UNITY_EDITOR
            var mats = psr.sharedMaterials;
            bool matsChanged = false;
            for (int i = 1; i < mats.Length; i++)
            {
                if (mats[i] == null || mats[i].shader == null) continue;
                if (mats[i].shader.name != "effect/C_EffectStandard") continue;
                string trailUrpPath = "Assets/Material/VFX_URP/" + mats[i].name + "_URP.mat";
                var trailUrp = UnityEditor.AssetDatabase.LoadAssetAtPath<Material>(trailUrpPath);
                if (trailUrp != null) { mats[i] = trailUrp; matsChanged = true; }
            }
            if (matsChanged) psr.sharedMaterials = mats;

            if (psr.trailMaterial != null && psr.trailMaterial.shader != null
                && psr.trailMaterial.shader.name == "effect/C_EffectStandard")
            {
                string tPath = "Assets/Material/VFX_URP/" + psr.trailMaterial.name + "_URP.mat";
                var tUrp = UnityEditor.AssetDatabase.LoadAssetAtPath<Material>(tPath);
                if (tUrp != null) psr.trailMaterial = tUrp;
            }
#endif
        }
    }

    static void ApplyRadarSprite(Transform createRoleRoot, int factionId)
    {
        if (factionId < 1 || factionId > kRadarSprite.Length) return;
        var radar = createRoleRoot.Find(kRadarPath);
        if (radar == null) return;
        var img = radar.GetComponent<Image>();
        if (img == null) return;
        string spriteName = kRadarSprite[factionId - 1];
        if (img.sprite != null && img.sprite.name == spriteName) return;
#if UNITY_EDITOR
        Sprite assetMatch = null, pngMatch = null;
        var guids = AssetDatabase.FindAssets("t:Sprite " + spriteName);
        foreach (var g in guids)
        {
            var p = AssetDatabase.GUIDToAssetPath(g);
            var s = AssetDatabase.LoadAssetAtPath<Sprite>(p);
            if (s == null || s.name != spriteName) continue;
            if (p.EndsWith(".asset")) { assetMatch = s; break; }
            if (pngMatch == null) pngMatch = s;
        }
        var picked = assetMatch ?? pngMatch;
        if (picked != null)
        {
            img.sprite = picked;
            img.SetNativeSize();
            img.SetAllDirty();
        }
#endif
    }

    static GameObject LoadPrefab(string path)
    {
#if UNITY_EDITOR
        return AssetDatabase.LoadAssetAtPath<GameObject>(path);
#else
        return null;
#endif
    }

    static void ApplyGenderIcons(Transform createRoleRoot, int sex)
    {
        var btnMale   = createRoleRoot.Find(kBtnMalePath);
        var btnFemale = createRoleRoot.Find(kBtnFemalePath);
        if (btnMale == null || btnFemale == null) return;
        var imgMale   = btnMale.GetComponent<Image>();
        var imgFemale = btnFemale.GetComponent<Image>();
        if (imgMale == null || imgFemale == null) return;
        bool male = (sex == kSexMale);
        SetSpritePreferAtlas(imgMale,   male ? kSpriteMaleSelect   : kSpriteMaleUnselect);
        SetSpritePreferAtlas(imgFemale, male ? kSpriteFemaleUnselect : kSpriteFemaleSelect);
    }

    static void SetSpritePreferAtlas(Image img, string spriteName)
    {
        if (img == null || string.IsNullOrEmpty(spriteName)) return;
        if (img.sprite != null && img.sprite.name == spriteName) return;
#if UNITY_EDITOR
        Sprite assetMatch = null, pngMatch = null;
        var guids = AssetDatabase.FindAssets("t:Sprite " + spriteName);
        foreach (var g in guids)
        {
            var p = AssetDatabase.GUIDToAssetPath(g);
            var s = AssetDatabase.LoadAssetAtPath<Sprite>(p);
            if (s == null || s.name != spriteName) continue;
            if (p.EndsWith(".asset")) { assetMatch = s; break; }
            if (pngMatch == null) pngMatch = s;
        }
        var picked = assetMatch ?? pngMatch;
        if (picked != null) { img.sprite = picked; img.SetAllDirty(); }
#endif
    }
}
