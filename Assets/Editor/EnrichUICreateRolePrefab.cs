using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

// One-shot prefab enricher: bakes the runtime-injected content into
// Assets/Prefabs/Imported/UICreateRole.prefab so it looks like the in-game
// reference at edit-time without needing the Lua engine to populate it.
//
// Bakes:
//   1. FactionList × 20 (cloned from FactionTemplate, VN names + icons,
//      default-selected = Cái Bang)
//   2. Banner *_Effect children → ripped uicreaterole_effect prefabs
//   3. Center character preview portrait (Cái Bang female) + glow ring
//   4. Static Chinese text → Vietnamese (radar attribs, input placeholder,
//      "全门派" dropdown, series text)
//   5. Hides spriteless white quads
//   6. Single active *_Effect (Fire = Cái Bang)
public static class EnrichUICreateRolePrefab
{
    const string PrefabPath = "Assets/Prefabs/Imported/UICreateRole.prefab";
    const string DefaultEffect = "Fire_Effect";   // Cái Bang
    const string DefaultSeriesKey = "txtFire";
    const int DefaultFactionIndex = 16;            // gaibang in Factions[]

    static readonly (string key, string vnName)[] Factions = new[]
    {
        ("shaolin",   "Thiếu Lâm"),
        ("wudang",    "Võ Đang"),
        ("tianwang",  "Thiên Vương"),
        ("tianren",   "Thiên Nhẫn"),
        ("wudu",      "Ngũ Độc"),
        ("mingjiao",  "Minh Giáo"),
        ("tangmen",   "Đường Môn"),
        ("changge",   "Trường Ca"),
        ("xiaoyao",   "Tiêu Dao"),
        ("emei",      "Nga Mi"),
        ("cuiyan",    "Thuý Yên"),
        ("taohua",    "Đào Hoa"),
        ("kunlun",    "Côn Lôn"),
        ("baituosha", "Bạch Đà Sơn"),
        ("duanshi",   "Đoàn Thị"),
        ("badao",     "Bá Đao"),
        ("gaibang",   "Cái Bang"),
        ("YiPinTang", "Nhất Phẩm Đường"),
        ("WuHuntang", "Vũ Huân Đường"),
        ("gumu",      "Cổ Mộ"),
    };

    public static void Execute()
    {
        var contents = PrefabUtility.LoadPrefabContents(PrefabPath);
        if (contents == null) { Debug.LogError("[Enrich] cannot load prefab"); return; }

        var imgBG = contents.transform.Find("imgBG");
        if (imgBG == null) { Debug.LogError("[Enrich] imgBG not found"); return; }

        ExpandFactionListContainer(imgBG);
        BakeFactionList(imgBG);
        BakeBannerEffects(imgBG);
        ScrubBannerPlaceholders(imgBG);
        BakeCharacterPortrait(contents.transform);
        BakeLocalization(imgBG);
        BakeSeriesAndEffects(imgBG);
        WidenSelectedSeriesText(imgBG);
        int stripped = StripAllLocalizers(imgBG);
        Debug.Log($"[Enrich] Stripped {stripped} Localize components");
        BakeLocalization(imgBG); // re-apply VN text after stripping localizers
        HideSpritelessWhites(contents);

        PrefabUtility.SaveAsPrefabAsset(contents, PrefabPath);
        PrefabUtility.UnloadPrefabContents(contents);
        AssetDatabase.SaveAssets();
        Debug.Log("[Enrich] done — prefab fully baked");
    }

    // Bundle's FactionList sizeDelta is 176×501, only fits ~12 buttons in 2 cols.
    // Expand vertical so all 20 fit. Also tighten the cell spacing slightly.
    static void ExpandFactionListContainer(Transform imgBG)
    {
        var list = imgBG.Find("FactionSeriesList/FactionList");
        if (list == null) return;
        var rt = list.GetComponent<RectTransform>();
        rt.sizeDelta = new Vector2(176.8f, 1020f);
        var grid = list.GetComponent<GridLayoutGroup>();
        if (grid != null)
        {
            grid.constraint = GridLayoutGroup.Constraint.FixedColumnCount;
            grid.constraintCount = 2;
            grid.spacing = new Vector2(20f, 12f);
        }
        Debug.Log("[Enrich] FactionList container expanded to 176×1020");
    }

    // Bundle banner placeholders (BG/RaoDong/LiuGuang/FireStar) reference
    // missing shaders → Unity falls back to magenta/red error material. We
    // already have the proper ripped *_Effect.prefab as a child, so hide all
    // bundle placeholder Images and clear their material references.
    static void ScrubBannerPlaceholders(Transform imgBG)
    {
        var faction = imgBG.Find("FactionInfo/Faction");
        if (faction == null) return;
        int hidden = 0;
        foreach (Transform child in faction)
        {
            if (!child.name.EndsWith("_Effect")) continue;
            foreach (var img in child.GetComponentsInChildren<Image>(true))
            {
                // Don't scrub wired banner layers (BG / LiuGuang / RaoDong) —
                // those now hold KTO/UI_ImageEffect materials and must keep
                // their alpha intact so the shader actually renders.
                if (img.material != null && img.material.shader != null &&
                    img.material.shader.name == "KTO/UI_ImageEffect") continue;
                // Also skip anything still under a leftover _Ripped subtree.
                if (img.transform.IsChildOf(child) && img.transform != child &&
                    IsUnderRipped(img.transform, child)) continue;
                img.material = null;
                // Disable rather than alpha=0: the Animator clip overrides
                // m_Color.a at runtime, so a baked alpha is meaningless.
                img.enabled = false;
                hidden++;
            }
        }
        Debug.Log($"[Enrich] Banner placeholders scrubbed: {hidden} Images");
    }

    static bool IsUnderRipped(Transform t, Transform stopParent)
    {
        var p = t;
        while (p != null && p != stopParent)
        {
            if (p.name.EndsWith("_Ripped")) return true;
            p = p.parent;
        }
        return false;
    }

    // The dropdown bundle has imgSelectFactionBg at (49.80, 161.60) size (176×50)
    // and arrow at (-37, 162) size (53×53). Text must start just right of arrow
    // and fit inside bg. Also strip [Localize] (I2.Loc) which overrides our text.
    static void WidenSelectedSeriesText(Transform imgBG)
    {
        var t = imgBG.Find("SelectSeries/txtSelectedSeries");
        if (t == null) return;
        var rt = t.GetComponent<RectTransform>();
        var txt = t.GetComponent<Text>();
        rt.pivot = new Vector2(0f, 0.5f);
        rt.sizeDelta = new Vector2(140f, 46f);
        rt.anchoredPosition = new Vector2(-5f, 161.61f);
        if (txt != null)
        {
            txt.fontSize = 18;
            txt.horizontalOverflow = HorizontalWrapMode.Overflow;
            txt.alignment = TextAnchor.MiddleLeft;
            txt.text = "Tất cả môn phái";
        }
        StripLocalize(t);
        Debug.Log("[Enrich] txtSelectedSeries repositioned + Localize stripped");
    }

    // Removes any I2.Loc Localize component (or other localizers) so our baked
    // Vietnamese text isn't clobbered at runtime. Walks all texts in imgBG
    // because most translated strings have the same problem.
    static int StripAllLocalizers(Transform imgBG)
    {
        int n = 0;
        foreach (var txt in imgBG.GetComponentsInChildren<Text>(true))
            n += StripLocalize(txt.transform);
        return n;
    }

    static int StripLocalize(Transform t)
    {
        int n = 0;
        foreach (var c in t.GetComponents<Component>())
        {
            if (c == null) continue;
            var name = c.GetType().Name;
            if (name == "Localize" || name == "I2Localize" || name == "LocalizeText")
            {
                Object.DestroyImmediate(c);
                n++;
            }
        }
        return n;
    }

    // ---------- 1. FactionList ----------
    static void BakeFactionList(Transform imgBG)
    {
        var factionList = imgBG.Find("FactionSeriesList/FactionList");
        if (factionList == null) { Debug.LogWarning("[Enrich] FactionList not found"); return; }

        Transform template = factionList.Find("FactionTemplate");
        if (template == null) { Debug.LogWarning("[Enrich] FactionTemplate not found"); return; }

        // Wipe any previous bakes (children whose name starts with "Faction_").
        for (int i = factionList.childCount - 1; i >= 0; i--)
        {
            var ch = factionList.GetChild(i);
            if (ch.name.StartsWith("Faction_")) Object.DestroyImmediate(ch.gameObject);
        }

        template.gameObject.SetActive(true);
        for (int i = 0; i < Factions.Length; i++)
        {
            var f = Factions[i];
            var clone = Object.Instantiate(template.gameObject, factionList);
            clone.name = $"Faction_{f.key}";
            clone.SetActive(true);

            // Icon
            var imgIcon = clone.transform.Find("imgIcon");
            if (imgIcon != null)
            {
                var img = imgIcon.GetComponent<Image>();
                if (img != null)
                {
                    var sprite = AssetDatabase.LoadAssetAtPath<Sprite>(
                        $"Assets/Sprite/faction_icon/faction_{f.key}.png");
                    if (sprite != null)
                    {
                        img.sprite = sprite;
                        var c = img.color; c.a = 1f; img.color = c;
                    }
                }
            }

            // Faction name label (if present)
            var label = clone.GetComponentInChildren<Text>(true);
            if (label != null) label.text = f.vnName;

            // Selection ring: only on default-selected faction
            var imgSelected = clone.transform.Find("imgSelected");
            if (imgSelected != null) imgSelected.gameObject.SetActive(i == DefaultFactionIndex);
        }
        // Hide template
        template.gameObject.SetActive(false);
        Debug.Log($"[Enrich] FactionList: cloned {Factions.Length} buttons");
    }

    // ---------- 2. Banner effects ----------
    // Bundle has 5 generic Wuxing-named effect slots that map to 5 specific
    // factions in the visual rip:
    //   Fire_Effect  -> TianRen (Thiên Nhẫn)
    //   Metal_Effect -> ShaoLin (Thiếu Lâm)
    //   Wood_Effect  -> TangMen (Đường Môn)
    //   Water_Effect -> EMei    (Nga Mi)
    //   Earth_Effect -> WuDang  (Võ Đang)
    static readonly System.Collections.Generic.Dictionary<string, string> EffectFactionSuffix = new()
    {
        { "Fire_Effect",  "TianRen" },
        { "Metal_Effect", "ShaoLin" },
        { "Wood_Effect",  "TangMen" },
        { "Water_Effect", "EMei" },
        { "Earth_Effect", "WuDang" },
    };

    static void BakeBannerEffects(Transform imgBG)
    {
        var faction = imgBG.Find("FactionInfo/Faction");
        if (faction == null) { Debug.LogWarning("[Enrich] FactionInfo/Faction not found"); return; }

        int n = 0;
        foreach (Transform child in faction)
        {
            if (!child.name.EndsWith("_Effect")) continue;

            // Earlier versions of this enricher instantiated a duplicate
            // <Effect>_Ripped subtree from uicreaterole_effect/<Effect>.prefab.
            // That left the outer subtree unwired AND the inner duplicate had
            // sprite=null (so its Image generated no mesh — invisible). We now
            // wire the outer subtree directly: its Image components already
            // have valid sprites, mesh, transforms and an Animator clip
            // bound by relative path. Tear down any leftover _Ripped child.
            var old = child.Find($"{child.name}_Ripped");
            if (old != null) Object.DestroyImmediate(old.gameObject);

            string suffix = EffectFactionSuffix.TryGetValue(child.name, out var s) ? s : null;
            int wired = WireBannerLayers(child, suffix);
            n++;
            Debug.Log($"[Enrich]   {child.name} -> {suffix}: {wired} layer(s) wired");
        }
        Debug.Log($"[Enrich] Banner effects baked: {n}/5");
    }

    static int WireBannerLayers(Transform effectRoot, string factionSuffix)
    {
        if (factionSuffix == null) return 0;
        const string MatRoot = "Assets/game/ui/effect/uicreaterole_effect/materials/";
        int wired = 0;
        foreach (var layer in new[] { "BG", "LiuGuang", "RaoDong" })
        {
            var node = effectRoot.Find(layer);
            if (node == null) continue;
            var img = node.GetComponent<Image>();
            if (img == null) continue;

            var mat = AssetDatabase.LoadAssetAtPath<Material>($"{MatRoot}{layer}_{factionSuffix}.mat");
            if (mat == null)
            {
                // Some factions only have a partial set (e.g. Metal has only
                // LiuGuang_ShaoLin — BG_ShaoLin and RaoDong_ShaoLin don't
                // exist in our project). The Metal_Effect Animator clip
                // animates "BG.m_Color.a" between ~0.31 and 0.60 — at
                // runtime this OVERRIDES any baked color we set here, so
                // alpha=0 is not enough to keep the layer hidden. Disabling
                // the Image entirely makes the Animator's color writes
                // harmless (the renderer skips disabled Images). Without
                // this, Kim-series factions (Thiếu Lâm, Thiên Vương, Bá Đao
                // — all routed through Metal_Effect) showed a flickering
                // untextured quad over the banner title.
                img.enabled = false;
                img.material = null;
                continue;
            }

            // Hard-reset the material reference to the asset (NOT a clone).
            // Multiple play sessions had snowballed nested " (Clone) (Clone)…"
            // material instances on these graphics; assigning the asset
            // here breaks that chain.
            img.material = mat;

            // KEEP the existing sprite — UGUI Image needs a sprite to
            // generate the quad mesh that the shader draws into. The shader
            // samples its OWN _Diffuse texture from the material; the
            // sprite's _MainTex is unused by the visual but required for
            // mesh generation.
            if (img.sprite == null)
            {
                // Fallback: assign a built-in 4x4 white sprite so we still
                // get a renderable mesh.
                img.sprite = AssetDatabase.GetBuiltinExtraResource<Sprite>("UI/Skin/Background.psd");
            }

            // Animator clip drives BG.m_Color.a between ~0.31 and 0.60 at
            // runtime — start at white opaque so the static editor preview
            // shows the banner.
            img.color = Color.white;
            img.raycastTarget = false;
            wired++;

            // ---- Pre-populate the ImageEffectAnimationController fields ----
            // The Animator captures "default values" for every animated field
            // when it OnEnables. If the controller's field initializers
            // (HDRColor=white, Brightness=1, …) are still in place at that
            // moment, the animator captures white as the default and clobbers
            // the material's actual color whenever a clip transition needs a
            // default. To prevent that, we copy each material property into
            // the controller's serialized field NOW so the prefab persists
            // the right defaults.
            var ctrl = node.GetComponent<ImageEffectAnimationController>();
            if (ctrl != null)
            {
                if (mat.HasProperty("_Color"))     ctrl.HDRColor    = mat.GetColor("_Color");
                if (mat.HasProperty("_EdgeColor")) ctrl.EdgeColor   = mat.GetColor("_EdgeColor");
                if (mat.HasProperty("_Brightness"))ctrl.Brightness  = mat.GetFloat("_Brightness");
                if (mat.HasProperty("_AlphaCutout"))ctrl.AlphaCutout = mat.GetFloat("_AlphaCutout");
                if (mat.HasProperty("_Uspeed"))    ctrl.Uspeed      = mat.GetFloat("_Uspeed");
                if (mat.HasProperty("_Vspeed"))    ctrl.Vspeed      = mat.GetFloat("_Vspeed");
                if (mat.HasProperty("_DiffuseRo")) ctrl.DiffuseRo   = mat.GetFloat("_DiffuseRo")  > 0.5f;
                if (mat.HasProperty("_DiffuseAng"))ctrl.DiffuseAng  = mat.GetFloat("_DiffuseAng");
                if (mat.HasProperty("_BlendSet"))  ctrl.BlendSet    = (BlendSetOption)(int)mat.GetFloat("_BlendSet");
                if (mat.HasProperty("_TwoSide"))   ctrl.TwoSide     = (TwoSideOption)(int)mat.GetFloat("_TwoSide");
                if (mat.HasProperty("_DiffuseMaskRo"))   ctrl.DiffuseMaskRo     = mat.GetFloat("_DiffuseMaskRo") > 0.5f;
                if (mat.HasProperty("_DiffuseMaskAng"))  ctrl.DiffuseMaskAng    = mat.GetFloat("_DiffuseMaskAng");
                if (mat.HasProperty("_USpeed_diffusem")) ctrl.DiffuseMaskUspeed = mat.GetFloat("_USpeed_diffusem");
                if (mat.HasProperty("_VSpeed_diffusem")) ctrl.DiffuseMaskVspeed = mat.GetFloat("_VSpeed_diffusem");
                if (mat.HasProperty("_DissolveProgress"))ctrl.DissolveProgress  = mat.GetFloat("_DissolveProgress");
                if (mat.HasProperty("_EdgeWidth"))       ctrl.EdgeWidth         = mat.GetFloat("_EdgeWidth");
                if (mat.HasProperty("_DissolveUSpeed"))  ctrl.DissolveUspeed    = mat.GetFloat("_DissolveUSpeed");
                if (mat.HasProperty("_DissolveVSpeed"))  ctrl.DissolveVspeed    = mat.GetFloat("_DissolveVSpeed");
                if (mat.HasProperty("_ForceX"))          ctrl.DistortForceX     = mat.GetFloat("_ForceX");
                if (mat.HasProperty("_ForceY"))          ctrl.DistortForceY     = mat.GetFloat("_ForceY");
                if (mat.HasProperty("_USpeed_distort"))  ctrl.DistortUspeed     = mat.GetFloat("_USpeed_distort");
                if (mat.HasProperty("_VSpeed_distort"))  ctrl.DistortVspeed     = mat.GetFloat("_VSpeed_distort");
                EditorUtility.SetDirty(ctrl);
            }

            // Make sure the layer covers the parent if its rect was zero'd.
            var rt = img.rectTransform;
            if (rt.sizeDelta == Vector2.zero && rt.anchorMin == rt.anchorMax)
            {
                rt.anchorMin = Vector2.zero;
                rt.anchorMax = Vector2.one;
                rt.offsetMin = Vector2.zero;
                rt.offsetMax = Vector2.zero;
            }
        }
        return wired;
    }

    // ---------- 3. Character portrait ----------
    static void BakeCharacterPortrait(Transform root)
    {
        var imgBG = root.Find("imgBG");
        if (imgBG == null) return;

        // Remove previous bake
        var existing = imgBG.Find("CharacterPortrait");
        if (existing != null) Object.DestroyImmediate(existing.gameObject);

        var container = new GameObject("CharacterPortrait", typeof(RectTransform));
        container.transform.SetParent(imgBG, false);
        container.transform.SetSiblingIndex(1);
        var crt = container.GetComponent<RectTransform>();
        crt.anchorMin = new Vector2(0.5f, 0.5f);
        crt.anchorMax = new Vector2(0.5f, 0.5f);
        crt.pivot     = new Vector2(0.5f, 0.5f);
        crt.anchoredPosition = Vector2.zero;
        crt.sizeDelta = new Vector2(1334f, 750f);

        // Cái Bang duo: M2_GB on left, ring + F2_GB (selected) on right.
        var maleStand   = "Assets/Sprite/character_stand/M2_GB/M2_GB_stand_0001.png";
        var femaleStand = "Assets/Sprite/character_stand/F2_GB/F2_GB_stand_0001.png";

        AddPortrait(container.transform, "char_male", maleStand, new Vector2(-160f, -30f));
        AddRing(container.transform, new Vector2(170f, -210f));
        AddPortrait(container.transform, "char_female", femaleStand, new Vector2(170f, -30f));
        Debug.Log("[Enrich] Character portrait baked (Cái Bang duo + ring)");
    }

    static void AddPortrait(Transform parent, string name, string spritePath, Vector2 pos)
    {
        var sprite = AssetDatabase.LoadAssetAtPath<Sprite>(spritePath);
        if (sprite == null) { Debug.LogWarning($"[Enrich] missing portrait: {spritePath}"); return; }
        var go = new GameObject(name, typeof(RectTransform), typeof(CanvasRenderer), typeof(Image));
        go.transform.SetParent(parent, false);
        var img = go.GetComponent<Image>();
        img.sprite = sprite;
        img.preserveAspect = true;
        img.raycastTarget = false;
        var rt = go.GetComponent<RectTransform>();
        rt.anchorMin = new Vector2(0.5f, 0.5f);
        rt.anchorMax = new Vector2(0.5f, 0.5f);
        rt.pivot     = new Vector2(0.5f, 0.5f);
        rt.anchoredPosition = pos;
        rt.sizeDelta = new Vector2(420f, 640f);
    }

    static void AddRing(Transform parent, Vector2 pos)
    {
        var sprite = AssetDatabase.LoadAssetAtPath<Sprite>("Assets/Sprite/createrole/Glow_053.png");
        if (sprite == null) { Debug.LogWarning("[Enrich] missing Glow_053"); return; }
        var go = new GameObject("SelectionRing", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image));
        go.transform.SetParent(parent, false);
        var img = go.GetComponent<Image>();
        img.sprite = sprite;
        img.preserveAspect = true;
        img.raycastTarget = false;
        img.color = new Color(1f, 0.9f, 0.4f, 0.95f);
        var rt = go.GetComponent<RectTransform>();
        rt.anchorMin = new Vector2(0.5f, 0.5f);
        rt.anchorMax = new Vector2(0.5f, 0.5f);
        rt.pivot     = new Vector2(0.5f, 0.5f);
        rt.anchoredPosition = pos;
        rt.sizeDelta = new Vector2(280f, 70f);
    }

    // ---------- 4. Localization ----------
    static void BakeLocalization(Transform imgBG)
    {
        // Radar attribute labels
        SetText(imgBG, "FactionInfo/FactionInfo/txtAttribute1", "Sinh tồn");
        SetText(imgBG, "FactionInfo/FactionInfo/txtAttribute2", "Quần chiến");
        SetText(imgBG, "FactionInfo/FactionInfo/txtAttribute3", "Cơ động");
        SetText(imgBG, "FactionInfo/FactionInfo/txtAttribute4", "Thao tác");
        SetText(imgBG, "FactionInfo/FactionInfo/txtAttribute5", "Hỗ trợ");
        SetText(imgBG, "FactionInfo/FactionInfo/txtAttribute6", "Đơn chiến");

        // Series buttons (left column, Hán → VN) — both possible paths
        SetText(imgBG, "FactionInfo/SeriesText/txtMetal", "Kim");
        SetText(imgBG, "FactionInfo/SeriesText/txtWood",  "Mộc");
        SetText(imgBG, "FactionInfo/SeriesText/txtWater", "Thủy");
        SetText(imgBG, "FactionInfo/SeriesText/txtFire",  "Hỏa");
        SetText(imgBG, "FactionInfo/SeriesText/txtEarth", "Thổ");
        SetText(imgBG, "FactionSeriesList/SeriesList/Metal/Text", "Kim");
        SetText(imgBG, "FactionSeriesList/SeriesList/Wood/Text",  "Mộc");
        SetText(imgBG, "FactionSeriesList/SeriesList/Water/Text", "Thủy");
        SetText(imgBG, "FactionSeriesList/SeriesList/Fire/Text",  "Hỏa");
        SetText(imgBG, "FactionSeriesList/SeriesList/Earth/Text", "Thổ");

        // Faction description (Cái Bang)
        SetText(imgBG, "FactionInfo/txtFactionDesc",
            "Đệ tử Cái Bang đều đến từ trong phố xá, không câu nệ tiểu tiết, " +
            "tự do thẳng thắn. Ở thời loạn thế, Cái Bang luôn diệt ác, trừ tham, " +
            "chống địch, sau trở thành võ lâm Bắc Đẩu.");

        // Default faction name in the banner (Cái Bang)
        // The bundle names this label inside FactionInfo/Faction/<*_Effect>/Text or similar
        foreach (var t in imgBG.GetComponentsInChildren<Text>(true))
        {
            if (t.text == null) continue;
            // Common Chinese leftovers from bundle prefab dump:
            if (t.text.Contains("dynamic_change_from_script")) t.text = "";
            if (t.text == "输入角色昵称") t.text = "Nhập tên nhân vật";
            if (t.text == "全门派")      t.text = "Tất cả môn phái";
            if (t.text == "返回")        t.text = "Quay lại";
            if (t.text == "创建角色")    t.text = "Tạo nhân vật";
            if (t.text == "随机")        t.text = "Ngẫu nhiên";
            if (t.text == "男")          t.text = "Nam";
            if (t.text == "女")          t.text = "Nữ";
        }

        // Banner faction-name labels under each *_Effect — bundle has these as
        // hard-coded Hán (天忍/少林/武当/...). Only Fire_Effect is active (Cái Bang)
        // so we set its label; for completeness map the other 4 too in case the
        // user toggles which effect is active.
        SetBannerName(imgBG, "Fire_Effect",  "Cái Bang");
        SetBannerName(imgBG, "Metal_Effect", "Thiếu Lâm");
        SetBannerName(imgBG, "Wood_Effect",  "Đường Môn");
        SetBannerName(imgBG, "Water_Effect", "Nga Mi");
        SetBannerName(imgBG, "Earth_Effect", "Võ Đang");

        Debug.Log("[Enrich] Localization baked");
    }

    // Bundle-baked FontOutline colors for each Wuxing-named *_Effect/Text.
    // Lifted directly from the KTO res_p_55 typetree dump (FontOutline is a
    // Shadow subclass, so the base m_EffectColor / m_EffectDistance fields
    // are what serializes). Each color carries the element's signature hue
    // at ~0.612 alpha and a thick (3,3) symmetric offset that gives the
    // banner title its dramatic glow. The previous enricher applied a
    // generic black (0,0,0,0.6) + (1,-1) — the diff vs the bundle showed
    // this for all 5 elements, so the titles looked dim and undecorated.
    static readonly System.Collections.Generic.Dictionary<string, Color> EffectOutlineColor = new()
    {
        { "Earth_Effect", new Color(0.396f, 0.278f, 0.200f, 0.612f) }, // brown
        { "Fire_Effect",  new Color(0.471f, 0.294f, 0.082f, 0.612f) }, // orange
        { "Metal_Effect", new Color(0.613f, 0.218f, 0.113f, 0.612f) }, // red
        { "Water_Effect", new Color(0.044f, 0.178f, 0.377f, 0.612f) }, // blue
        { "Wood_Effect",  new Color(0.136f, 0.330f, 0.245f, 0.612f) }, // green
    };
    static readonly Vector2 EffectOutlineDistance = new Vector2(3f, 3f);

    static void SetBannerName(Transform imgBG, string effectName, string vn)
    {
        var t = imgBG.Find($"FactionInfo/Faction/{effectName}/Text");
        if (t == null) return;
        var txt = t.GetComponent<Text>();
        if (txt == null) return;
        txt.text = vn;

        // The bundle leaves the faction-title Text at flat (1,1,1,1) which
        // washes out against the orange banner glow underneath. The original
        // wuxia title style is a warm cream/gold with a dark outline + soft
        // shadow. Match the parchment hue used by the description text below.
        txt.color = new Color(1f, 0.93f, 0.78f, 1f);

        // The bundle ships its own custom outline component (`FontOutline`) on
        // the banner title — adding Unity's built-in `UnityEngine.UI.Outline`
        // on top of it stacks two vertex modifiers, producing a 4-corner
        // ghost/double-vision effect that looks like a broken animation when
        // the title text changes at runtime. Skip adding our outline if the
        // bundle's FontOutline (or any other vertex-modifier IEffect script
        // type) is already present, AND tear down any duplicate Outline that
        // a previous enrich pass may have left behind.
        bool hasBundleOutline = false;
        foreach (var comp in t.GetComponents<MonoBehaviour>())
        {
            if (comp == null) continue;
            var name = comp.GetType().Name;
            if (name == "FontOutline") { hasBundleOutline = true; break; }
        }

        var outline = t.GetComponent<Outline>();
        if (hasBundleOutline)
        {
            // Bundle already provides the dark outline — strip the duplicate.
            if (outline != null) Object.DestroyImmediate(outline);
        }
        else
        {
            if (outline == null) outline = t.gameObject.AddComponent<Outline>();
            outline.effectColor     = new Color(0.18f, 0.10f, 0.04f, 0.85f);
            outline.effectDistance  = new Vector2(1.5f, -1.5f);
            outline.useGraphicAlpha = true;
        }

        // Restore the bundle's element-themed FontOutline values. FontOutline
        // is a Shadow subclass so GetComponent<Shadow>() returns it directly;
        // the !(shadow is Outline) guard skips Unity's built-in Outline (also
        // a Shadow subclass) when both happen to be present.
        var shadow = t.GetComponent<Shadow>();
        if (shadow != null && !(shadow is Outline))
        {
            if (EffectOutlineColor.TryGetValue(effectName, out var col))
                shadow.effectColor = col;
            else
                shadow.effectColor = new Color(0f, 0f, 0f, 0.6f);
            shadow.effectDistance = EffectOutlineDistance;
            EditorUtility.SetDirty(shadow);
        }
    }

    static void SetText(Transform root, string path, string value)
    {
        var t = root.Find(path);
        if (t == null) return;
        var txt = t.GetComponent<Text>();
        if (txt == null) return;
        txt.text = value;
    }

    // ---------- 5. Series + single active effect ----------
    static void BakeSeriesAndEffects(Transform imgBG)
    {
        // SeriesList visible
        var sl = imgBG.Find("FactionSeriesList/SeriesList");
        if (sl != null) sl.gameObject.SetActive(true);

        // Only one *_Effect active
        var faction = imgBG.Find("FactionInfo/Faction");
        if (faction != null)
        {
            foreach (Transform child in faction)
            {
                if (!child.name.EndsWith("_Effect")) continue;
                child.gameObject.SetActive(child.name == DefaultEffect);
            }
        }

        // Only the default series text active
        var seriesText = imgBG.Find("FactionInfo/SeriesText");
        if (seriesText != null)
        {
            foreach (Transform child in seriesText)
            {
                if (!child.name.StartsWith("txt")) continue;
                child.gameObject.SetActive(child.name == DefaultSeriesKey);
            }
        }

        // Bake the radar polygon sprite for the default faction. The bundle ships
        // imgFactionInfo with sprite "img_factioninfo_cuiyan" (Thuý Yên/EMei) — at
        // runtime UICreateRole.lua line 365 calls
        //   self.pPanel:Sprite_SetSprite(tbControls.imgFactionInfo,
        //                                Faction:GetRadarChartPath(tbElement.nFactionId))
        // which swaps it per-faction. Since we don't run lua at edit-time, hard-code
        // the sprite that matches DefaultFactionIndex.
        var radar = imgBG.Find("FactionInfo/FactionInfo/imgFactionInfo");
        if (radar != null)
        {
            var rimg = radar.GetComponent<Image>();
            if (rimg != null)
            {
                var spriteName = "img_factioninfo_" + Factions[DefaultFactionIndex].key;
                var found = AssetDatabase.FindAssets("t:Sprite " + spriteName);
                Sprite radarSprite = null;
                foreach (var g in found)
                {
                    var p = AssetDatabase.GUIDToAssetPath(g);
                    var s = AssetDatabase.LoadAssetAtPath<Sprite>(p);
                    if (s != null && s.name == spriteName) { radarSprite = s; break; }
                }
                if (radarSprite != null)
                {
                    rimg.sprite = radarSprite;
                    Debug.Log("[Enrich] Radar polygon set to " + spriteName);
                }
                else
                {
                    Debug.LogWarning("[Enrich] Radar sprite not found: " + spriteName);
                }
            }
        }
    }

    // ---------- 6. Hide spriteless whites ----------
    static void HideSpritelessWhites(GameObject root)
    {
        int hidden = 0;
        foreach (var img in root.GetComponentsInChildren<Image>(true))
        {
            if (img == null) continue;
            // Skip our own baked content + masks (some masks legitimately have no sprite)
            if (img.GetComponent<Mask>() != null) continue;
            // Images with a custom material (e.g. our wired banner layers)
            // render via shader uniforms, not via sprite — never hide them.
            if (img.material != null && img.material.shader != null &&
                img.material.shader.name != "UI/Default") continue;
            if (img.sprite == null && img.color.a >= 0.01f && img.GetType() == typeof(Image))
            {
                var c = img.color; c.a = 0f; img.color = c;
                hidden++;
            }
        }
        Debug.Log($"[Enrich] Hid {hidden} spriteless white images");
    }
}
