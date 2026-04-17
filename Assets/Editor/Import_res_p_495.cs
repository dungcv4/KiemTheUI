// AUTO-GENERATED from res_p_495.ab — DO NOT EDIT MANUALLY.
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;
using System.Collections.Generic;
using KTO.Game;  // UIJoyStick and other ported KTO scripts

public class Import_res_p_495
{
    [MenuItem("KTO/Import/res_p_495")]
    public static void Build()
    {
        Debug.Log("[Import_res_p_495] Building UIXiaLvEffect_1_4...");

        // ─── Create all GameObjects ───────────────────────────
        var goMap = new Dictionary<long, GameObject>();
        var _toggleGroupByMbPid = new Dictionary<long, ToggleGroup>();
        var _toggleGroupLinks = new List<System.Tuple<Toggle,long>>();
        { var go = new GameObject("UIXiaLvEffect_1_4"); go.SetActive(true); goMap[5672744999810093596L] = go; }
        { var go = new GameObject("ClickEmptyToClose"); go.SetActive(true); goMap[1596952790246058921L] = go; }
        { var go = new GameObject("UIQinMiDu_nv3"); go.SetActive(true); goMap[1968903008757429056L] = go; }
        { var go = new GameObject("P1_an"); go.SetActive(true); goMap[2942584965827962599L] = go; }
        { var go = new GameObject("P4"); go.SetActive(true); goMap[779356306006382465L] = go; }
        { var go = new GameObject("P4_1"); go.SetActive(true); goMap[-7903337474730024281L] = go; }
        { var go = new GameObject("aixin_lujing"); go.SetActive(true); goMap[-6009028045026934490L] = go; }
        { var go = new GameObject("Dummy001"); go.SetActive(true); goMap[-732331274607413999L] = go; }
        { var go = new GameObject("p5_ai"); go.SetActive(true); goMap[-6710178269132194075L] = go; }
        { var go = new GameObject("Dummy002"); go.SetActive(true); goMap[4411798241837113222L] = go; }
        { var go = new GameObject("p5_ai"); go.SetActive(true); goMap[-7987062065375662474L] = go; }
        { var go = new GameObject("Line012"); go.SetActive(true); goMap[-5955717523359337079L] = go; }
        { var go = new GameObject("Line013"); go.SetActive(true); goMap[-61807441481479309L] = go; }
        { var go = new GameObject("aixin_ani"); go.SetActive(true); goMap[-7020996415355074891L] = go; }
        { var go = new GameObject("p7_KS"); go.SetActive(true); goMap[-2968169905967155335L] = go; }
        { var go = new GameObject("Love_Red"); go.SetActive(true); goMap[-3284553759037463614L] = go; }
        { var go = new GameObject("Love_Blue"); go.SetActive(true); goMap[-3565683175046871838L] = go; }
        { var go = new GameObject("Love_BlueGlow"); go.SetActive(true); goMap[7061869428039388416L] = go; }
        { var go = new GameObject("Love_RedGlow"); go.SetActive(true); goMap[7719967401368851325L] = go; }
        { var go = new GameObject("txtTitle"); go.SetActive(true); goMap[-8640908564086221838L] = go; }
        { var go = new GameObject("p14"); go.SetActive(false); goMap[8881441202629790525L] = go; }
        { var go = new GameObject("p15"); go.SetActive(true); goMap[-6917548275598379883L] = go; }
        { var go = new GameObject("P8"); go.SetActive(true); goMap[6822655705981955769L] = go; }
        { var go = new GameObject("HuDieAnim"); go.SetActive(true); goMap[-3244900232318458100L] = go; }
        { var go = new GameObject("hudieBlue"); go.SetActive(true); goMap[-1055039691920855671L] = go; }
        { var go = new GameObject("hudie(Clone)"); go.SetActive(true); goMap[7521661878169227351L] = go; }
        { var go = new GameObject("Bone009"); go.SetActive(true); goMap[-5810899519037048193L] = go; }
        { var go = new GameObject("Bone001"); go.SetActive(true); goMap[120723726132293962L] = go; }
        { var go = new GameObject("Bone003"); go.SetActive(true); goMap[-8151307982437884106L] = go; }
        { var go = new GameObject("Bone005"); go.SetActive(true); goMap[3815668274314412705L] = go; }
        { var go = new GameObject("Bone007"); go.SetActive(true); goMap[-4911262933809046206L] = go; }
        { var go = new GameObject("Plane007"); go.SetActive(true); goMap[1834469697413607257L] = go; }
        { var go = new GameObject("Plane008"); go.SetActive(true); goMap[-7572902757938649835L] = go; }
        { var go = new GameObject("Sphere001"); go.SetActive(true); goMap[-1091038299233946318L] = go; }
        { var go = new GameObject("Plane001"); go.SetActive(true); goMap[3399327905865335639L] = go; }
        { var go = new GameObject("Plane002"); go.SetActive(true); goMap[1306455563672572588L] = go; }
        { var go = new GameObject("Plane004"); go.SetActive(true); goMap[7699710586232962056L] = go; }
        { var go = new GameObject("Plane005"); go.SetActive(true); goMap[2205234877826762720L] = go; }
        { var go = new GameObject("Particle System"); go.SetActive(true); goMap[1149169836849052992L] = go; }
        { var go = new GameObject("Particle System (1)"); go.SetActive(true); goMap[-466223504523940809L] = go; }
        { var go = new GameObject("Trail1"); go.SetActive(true); goMap[5695088948044380941L] = go; }
        { var go = new GameObject("Trail2"); go.SetActive(true); goMap[-6747010625927677894L] = go; }
        { var go = new GameObject("Trail3"); go.SetActive(true); goMap[2332902099418056215L] = go; }
        { var go = new GameObject("hudieRed"); go.SetActive(true); goMap[-2086392168675853073L] = go; }
        { var go = new GameObject("hudie(Clone)"); go.SetActive(true); goMap[4136688981539445429L] = go; }
        { var go = new GameObject("Bone009"); go.SetActive(true); goMap[-1963362120359914307L] = go; }
        { var go = new GameObject("Bone001"); go.SetActive(true); goMap[-5228994330731303232L] = go; }
        { var go = new GameObject("Bone003"); go.SetActive(true); goMap[-7329285853752862515L] = go; }
        { var go = new GameObject("Bone005"); go.SetActive(true); goMap[7673138787423164986L] = go; }
        { var go = new GameObject("Bone007"); go.SetActive(true); goMap[-41108770721836592L] = go; }
        { var go = new GameObject("Plane007"); go.SetActive(true); goMap[-248536893846101670L] = go; }
        { var go = new GameObject("Plane008"); go.SetActive(true); goMap[5809880646113363169L] = go; }
        { var go = new GameObject("Sphere001"); go.SetActive(true); goMap[793258943247503497L] = go; }
        { var go = new GameObject("Plane001"); go.SetActive(true); goMap[-2045142528755363229L] = go; }
        { var go = new GameObject("Plane002"); go.SetActive(true); goMap[-6571882261812002122L] = go; }
        { var go = new GameObject("Plane004"); go.SetActive(true); goMap[2886290165188043482L] = go; }
        { var go = new GameObject("Plane005"); go.SetActive(true); goMap[6543552436073079005L] = go; }
        { var go = new GameObject("Particle System"); go.SetActive(true); goMap[1457600872019407851L] = go; }
        { var go = new GameObject("Particle System (1)"); go.SetActive(true); goMap[6900138971119820734L] = go; }
        { var go = new GameObject("TrailGlow"); go.SetActive(true); goMap[4453895717325129141L] = go; }
        { var go = new GameObject("TrailLine"); go.SetActive(true); goMap[8126222621930911322L] = go; }
        { var go = new GameObject("TrailLight"); go.SetActive(true); goMap[-1168428085944072862L] = go; }

        // ─── Parent links ─────────────────────────────────────
        goMap[1596952790246058921L].transform.SetParent(goMap[5672744999810093596L].transform, false);
        goMap[1968903008757429056L].transform.SetParent(goMap[5672744999810093596L].transform, false);
        goMap[2942584965827962599L].transform.SetParent(goMap[1968903008757429056L].transform, false);
        goMap[779356306006382465L].transform.SetParent(goMap[1968903008757429056L].transform, false);
        goMap[-7903337474730024281L].transform.SetParent(goMap[1968903008757429056L].transform, false);
        goMap[-6009028045026934490L].transform.SetParent(goMap[1968903008757429056L].transform, false);
        goMap[-732331274607413999L].transform.SetParent(goMap[-6009028045026934490L].transform, false);
        goMap[-6710178269132194075L].transform.SetParent(goMap[-732331274607413999L].transform, false);
        goMap[4411798241837113222L].transform.SetParent(goMap[-6009028045026934490L].transform, false);
        goMap[-7987062065375662474L].transform.SetParent(goMap[4411798241837113222L].transform, false);
        goMap[-5955717523359337079L].transform.SetParent(goMap[-6009028045026934490L].transform, false);
        goMap[-61807441481479309L].transform.SetParent(goMap[-6009028045026934490L].transform, false);
        goMap[-7020996415355074891L].transform.SetParent(goMap[1968903008757429056L].transform, false);
        goMap[-2968169905967155335L].transform.SetParent(goMap[-7020996415355074891L].transform, false);
        goMap[-3284553759037463614L].transform.SetParent(goMap[-7020996415355074891L].transform, false);
        goMap[-3565683175046871838L].transform.SetParent(goMap[-7020996415355074891L].transform, false);
        goMap[7061869428039388416L].transform.SetParent(goMap[-7020996415355074891L].transform, false);
        goMap[7719967401368851325L].transform.SetParent(goMap[-7020996415355074891L].transform, false);
        goMap[-8640908564086221838L].transform.SetParent(goMap[-7020996415355074891L].transform, false);
        goMap[8881441202629790525L].transform.SetParent(goMap[1968903008757429056L].transform, false);
        goMap[-6917548275598379883L].transform.SetParent(goMap[8881441202629790525L].transform, false);
        goMap[6822655705981955769L].transform.SetParent(goMap[1968903008757429056L].transform, false);
        goMap[-3244900232318458100L].transform.SetParent(goMap[1968903008757429056L].transform, false);
        goMap[-1055039691920855671L].transform.SetParent(goMap[-3244900232318458100L].transform, false);
        goMap[7521661878169227351L].transform.SetParent(goMap[-1055039691920855671L].transform, false);
        goMap[-5810899519037048193L].transform.SetParent(goMap[7521661878169227351L].transform, false);
        goMap[120723726132293962L].transform.SetParent(goMap[-5810899519037048193L].transform, false);
        goMap[-8151307982437884106L].transform.SetParent(goMap[-5810899519037048193L].transform, false);
        goMap[3815668274314412705L].transform.SetParent(goMap[-5810899519037048193L].transform, false);
        goMap[-4911262933809046206L].transform.SetParent(goMap[-5810899519037048193L].transform, false);
        goMap[1834469697413607257L].transform.SetParent(goMap[-5810899519037048193L].transform, false);
        goMap[-7572902757938649835L].transform.SetParent(goMap[-5810899519037048193L].transform, false);
        goMap[-1091038299233946318L].transform.SetParent(goMap[-5810899519037048193L].transform, false);
        goMap[3399327905865335639L].transform.SetParent(goMap[7521661878169227351L].transform, false);
        goMap[1306455563672572588L].transform.SetParent(goMap[7521661878169227351L].transform, false);
        goMap[7699710586232962056L].transform.SetParent(goMap[7521661878169227351L].transform, false);
        goMap[2205234877826762720L].transform.SetParent(goMap[7521661878169227351L].transform, false);
        goMap[1149169836849052992L].transform.SetParent(goMap[7521661878169227351L].transform, false);
        goMap[-466223504523940809L].transform.SetParent(goMap[7521661878169227351L].transform, false);
        goMap[5695088948044380941L].transform.SetParent(goMap[7521661878169227351L].transform, false);
        goMap[-6747010625927677894L].transform.SetParent(goMap[7521661878169227351L].transform, false);
        goMap[2332902099418056215L].transform.SetParent(goMap[7521661878169227351L].transform, false);
        goMap[-2086392168675853073L].transform.SetParent(goMap[-3244900232318458100L].transform, false);
        goMap[4136688981539445429L].transform.SetParent(goMap[-2086392168675853073L].transform, false);
        goMap[-1963362120359914307L].transform.SetParent(goMap[4136688981539445429L].transform, false);
        goMap[-5228994330731303232L].transform.SetParent(goMap[-1963362120359914307L].transform, false);
        goMap[-7329285853752862515L].transform.SetParent(goMap[-1963362120359914307L].transform, false);
        goMap[7673138787423164986L].transform.SetParent(goMap[-1963362120359914307L].transform, false);
        goMap[-41108770721836592L].transform.SetParent(goMap[-1963362120359914307L].transform, false);
        goMap[-248536893846101670L].transform.SetParent(goMap[-1963362120359914307L].transform, false);
        goMap[5809880646113363169L].transform.SetParent(goMap[-1963362120359914307L].transform, false);
        goMap[793258943247503497L].transform.SetParent(goMap[-1963362120359914307L].transform, false);
        goMap[-2045142528755363229L].transform.SetParent(goMap[4136688981539445429L].transform, false);
        goMap[-6571882261812002122L].transform.SetParent(goMap[4136688981539445429L].transform, false);
        goMap[2886290165188043482L].transform.SetParent(goMap[4136688981539445429L].transform, false);
        goMap[6543552436073079005L].transform.SetParent(goMap[4136688981539445429L].transform, false);
        goMap[1457600872019407851L].transform.SetParent(goMap[4136688981539445429L].transform, false);
        goMap[6900138971119820734L].transform.SetParent(goMap[4136688981539445429L].transform, false);
        goMap[4453895717325129141L].transform.SetParent(goMap[4136688981539445429L].transform, false);
        goMap[8126222621930911322L].transform.SetParent(goMap[4136688981539445429L].transform, false);
        goMap[-1168428085944072862L].transform.SetParent(goMap[4136688981539445429L].transform, false);

        // ─── RectTransforms ──────────────────────────────────
        {
            var rt = goMap[5672744999810093596L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.000000f, 0.000000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }
        {
            var rt = goMap[1596952790246058921L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }
        {
            var rt = goMap[-8640908564086221838L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 1.232877f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(0.013700f, 0.013700f, 0.013700f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.109588f, 1.791779f);
            rt.sizeDelta = new Vector2(0.000000f, 111.627602f);
        }

        // ─── Components ──────────────────────────────────────
        { var c = goMap[5672744999810093596L].AddComponent<Canvas>();
           c.renderMode = (RenderMode)1;
           c.overrideSorting = true;
           c.sortingOrder = 0;
           c.sortingLayerID = unchecked((int)194136777);
           c.planeDistance = 100.000000f;
           c.pixelPerfect = false;
           c.additionalShaderChannels = (AdditionalCanvasShaderChannels)0;
           c.enabled = true;
        }
        { var c = goMap[5672744999810093596L].AddComponent<GraphicRaycaster>();
           c.ignoreReversedGraphics = true;
        }
        { var c = goMap[5672744999810093596L].AddComponent<CanvasScaler>();
           c.uiScaleMode = (CanvasScaler.ScaleMode)1;
           c.referenceResolution = new Vector2(1280.000000f, 720.000000f);
           c.screenMatchMode = (CanvasScaler.ScreenMatchMode)1;
           c.matchWidthOrHeight = 0.000000f;
           c.referencePixelsPerUnit = 100.000000f;
        }
        { var c = goMap[1596952790246058921L].AddComponent<Image>();
           c.color = new Color(1f,1f,1f,0f);
           c.raycastTarget = true;
           c.maskable = true;
           c.enabled = true;
        }
        { var c = goMap[1596952790246058921L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-6009028045026934490L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("aixin_lujing(Clone)"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[-7020996415355074891L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("aixin_ani02"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[-8640908564086221838L].AddComponent<Text>();
           c.text = "42768";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 0.649802f);
           c.fontSize = 80;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleLeft;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 4;
           c.resizeTextMaxSize = 80;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-8640908564086221838L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)2;
           c.verticalFit = (ContentSizeFitter.FitMode)0;
        }
        { var g = goMap[-8640908564086221838L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(1.000000f, 0.514151f, 0.899835f, 1.000000f); }
        { var c = goMap[-8640908564086221838L].AddComponent<Outline>();
           c.effectColor = new Color(1.000000f, 0.615686f, 0.984464f, 1.000000f);
           c.effectDistance = new Vector2(2.000000f, -2.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-3244900232318458100L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("HuDieAnim"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[7521661878169227351L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("HuDie"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[4136688981539445429L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("HuDie"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }

        // ─── Resolve Toggle → ToggleGroup links ─────────────
        foreach (var kv in _toggleGroupLinks)
        {
            ToggleGroup grp;
            if (_toggleGroupByMbPid.TryGetValue(kv.Item2, out grp) && grp != null)
                kv.Item1.group = grp;
        }

        // ─── Save prefab ─────────────────────────────────────
        Directory.CreateDirectory("Assets/Prefabs/Imported");
        var rootGO = goMap[5672744999810093596L];
        string path = "Assets/Prefabs/Imported/UIXiaLvEffect_1_4.prefab";
        PrefabUtility.SaveAsPrefabAsset(rootGO, path);
        Object.DestroyImmediate(rootGO);
        Debug.Log("[Import_res_p_495] Saved " + path);
    }

    static Dictionary<string, Sprite> _spriteCache;
    static Sprite LookupSprite(string name)
    {
        if (_spriteCache == null)
        {
            _spriteCache = new Dictionary<string, Sprite>();
            var guids = AssetDatabase.FindAssets("t:Sprite", new[] { "Assets/Sprite" });
            foreach (var g in guids)
            {
                var p = AssetDatabase.GUIDToAssetPath(g);
                var s = AssetDatabase.LoadAssetAtPath<Sprite>(p);
                if (s == null) continue;
                if (!_spriteCache.ContainsKey(s.name)) _spriteCache[s.name] = s;
            }
            Debug.Log($"[Sprite cache] {_spriteCache.Count} sprites");
        }
        Sprite r;
        return _spriteCache.TryGetValue(name, out r) ? r : null;
    }

    static Dictionary<string, Font> _fontCache;
    static Font LookupFont(string name)
    {
        if (_fontCache == null)
        {
            _fontCache = new Dictionary<string, Font>();
            // Map Chinese fonts to local Vietnamese fonts
            var vi = AssetDatabase.LoadAssetAtPath<Font>("Assets/Font/common_vi.ttf");
            var hydl = AssetDatabase.LoadAssetAtPath<Font>("Assets/Font/btn_hydl_vi.ttf");
            _fontCache["common_zh"] = vi;
            _fontCache["common_vi"] = vi;
            _fontCache["btn_hydl_zh"] = hydl;
            _fontCache["btn_hydl_vi"] = hydl;
        }
        Font r;
        if (_fontCache.TryGetValue(name, out r)) return r;
        return _fontCache["common_vi"];
    }

    static Dictionary<string, RuntimeAnimatorController> _animCtrlCache;
    static RuntimeAnimatorController LookupAnimatorController(string name)
    {
        if (_animCtrlCache == null)
        {
            _animCtrlCache = new Dictionary<string, RuntimeAnimatorController>();
            var guids = AssetDatabase.FindAssets("t:AnimatorController", new[] { "Assets" });
            foreach (var g in guids)
            {
                var p = AssetDatabase.GUIDToAssetPath(g);
                var a = AssetDatabase.LoadAssetAtPath<RuntimeAnimatorController>(p);
                if (a == null) continue;
                if (!_animCtrlCache.ContainsKey(a.name)) _animCtrlCache[a.name] = a;
            }
            Debug.Log($"[AnimCtrl cache] {_animCtrlCache.Count} controllers");
        }
        RuntimeAnimatorController r;
        return _animCtrlCache.TryGetValue(name, out r) ? r : null;
    }
}