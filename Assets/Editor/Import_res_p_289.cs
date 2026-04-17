// AUTO-GENERATED from res_p_289.ab — DO NOT EDIT MANUALLY.
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;
using System.Collections.Generic;
using KTO.Game;  // UIJoyStick and other ported KTO scripts

public class Import_res_p_289
{
    [MenuItem("KTO/Import/res_p_289")]
    public static void Build()
    {
        Debug.Log("[Import_res_p_289] Building UIGiftEffect_1_2...");

        // ─── Create all GameObjects ───────────────────────────
        var goMap = new Dictionary<long, GameObject>();
        var _toggleGroupByMbPid = new Dictionary<long, ToggleGroup>();
        var _toggleGroupLinks = new List<System.Tuple<Toggle,long>>();
        { var go = new GameObject("UIGiftEffect_1_2"); go.SetActive(true); goMap[1423852112789855193L] = go; }
        { var go = new GameObject("ClickEmptyToClose"); go.SetActive(true); goMap[-1280174617360273851L] = go; }
        { var go = new GameObject("UIQinMiDu_nv2"); go.SetActive(true); goMap[8536586568232852005L] = go; }
        { var go = new GameObject("P8"); go.SetActive(true); goMap[-2356598923499856700L] = go; }
        { var go = new GameObject("aixin_lujing"); go.SetActive(true); goMap[2069477363416162599L] = go; }
        { var go = new GameObject("Dummy001"); go.SetActive(true); goMap[-1476122013114168831L] = go; }
        { var go = new GameObject("p5_ai"); go.SetActive(true); goMap[9138673921523517616L] = go; }
        { var go = new GameObject("p3"); go.SetActive(true); goMap[-2123291182581784726L] = go; }
        { var go = new GameObject("Dummy002"); go.SetActive(true); goMap[-4021567683615617254L] = go; }
        { var go = new GameObject("p5_ai"); go.SetActive(true); goMap[-630649370647407699L] = go; }
        { var go = new GameObject("p3"); go.SetActive(true); goMap[8808026862729007206L] = go; }
        { var go = new GameObject("Line012"); go.SetActive(true); goMap[-2331063883078415780L] = go; }
        { var go = new GameObject("Line013"); go.SetActive(true); goMap[-867988504458328074L] = go; }
        { var go = new GameObject("aixin_lujing"); go.SetActive(true); goMap[2890766478643089027L] = go; }
        { var go = new GameObject("Dummy001"); go.SetActive(true); goMap[4458298997766150599L] = go; }
        { var go = new GameObject("p5_ai"); go.SetActive(true); goMap[-1488009499951799804L] = go; }
        { var go = new GameObject("p3"); go.SetActive(true); goMap[643541505941703997L] = go; }
        { var go = new GameObject("Dummy002"); go.SetActive(true); goMap[-8325351308309832297L] = go; }
        { var go = new GameObject("p5_ai"); go.SetActive(true); goMap[8525078919093378962L] = go; }
        { var go = new GameObject("p3"); go.SetActive(true); goMap[8251186913199159353L] = go; }
        { var go = new GameObject("Line012"); go.SetActive(true); goMap[6936730708092107593L] = go; }
        { var go = new GameObject("Line013"); go.SetActive(true); goMap[-1937066607988223095L] = go; }
        { var go = new GameObject("P8"); go.SetActive(true); goMap[-7291683060116963992L] = go; }
        { var go = new GameObject("P2_liang"); go.SetActive(true); goMap[-6345163304592119205L] = go; }
        { var go = new GameObject("P4"); go.SetActive(true); goMap[3258206503101202499L] = go; }
        { var go = new GameObject("P4_1"); go.SetActive(true); goMap[5605040343757950433L] = go; }
        { var go = new GameObject("p14"); go.SetActive(true); goMap[-6748410631975813865L] = go; }
        { var go = new GameObject("p15"); go.SetActive(true); goMap[1369497950442509137L] = go; }
        { var go = new GameObject("p12"); go.SetActive(true); goMap[9016191649954929126L] = go; }

        // ─── Parent links ─────────────────────────────────────
        goMap[-1280174617360273851L].transform.SetParent(goMap[1423852112789855193L].transform, false);
        goMap[8536586568232852005L].transform.SetParent(goMap[1423852112789855193L].transform, false);
        goMap[-2356598923499856700L].transform.SetParent(goMap[8536586568232852005L].transform, false);
        goMap[2069477363416162599L].transform.SetParent(goMap[8536586568232852005L].transform, false);
        goMap[-1476122013114168831L].transform.SetParent(goMap[2069477363416162599L].transform, false);
        goMap[9138673921523517616L].transform.SetParent(goMap[-1476122013114168831L].transform, false);
        goMap[-2123291182581784726L].transform.SetParent(goMap[-1476122013114168831L].transform, false);
        goMap[-4021567683615617254L].transform.SetParent(goMap[2069477363416162599L].transform, false);
        goMap[-630649370647407699L].transform.SetParent(goMap[-4021567683615617254L].transform, false);
        goMap[8808026862729007206L].transform.SetParent(goMap[-4021567683615617254L].transform, false);
        goMap[-2331063883078415780L].transform.SetParent(goMap[2069477363416162599L].transform, false);
        goMap[-867988504458328074L].transform.SetParent(goMap[2069477363416162599L].transform, false);
        goMap[2890766478643089027L].transform.SetParent(goMap[8536586568232852005L].transform, false);
        goMap[4458298997766150599L].transform.SetParent(goMap[2890766478643089027L].transform, false);
        goMap[-1488009499951799804L].transform.SetParent(goMap[4458298997766150599L].transform, false);
        goMap[643541505941703997L].transform.SetParent(goMap[4458298997766150599L].transform, false);
        goMap[-8325351308309832297L].transform.SetParent(goMap[2890766478643089027L].transform, false);
        goMap[8525078919093378962L].transform.SetParent(goMap[-8325351308309832297L].transform, false);
        goMap[8251186913199159353L].transform.SetParent(goMap[-8325351308309832297L].transform, false);
        goMap[6936730708092107593L].transform.SetParent(goMap[2890766478643089027L].transform, false);
        goMap[-1937066607988223095L].transform.SetParent(goMap[2890766478643089027L].transform, false);
        goMap[-7291683060116963992L].transform.SetParent(goMap[8536586568232852005L].transform, false);
        goMap[-6345163304592119205L].transform.SetParent(goMap[8536586568232852005L].transform, false);
        goMap[3258206503101202499L].transform.SetParent(goMap[8536586568232852005L].transform, false);
        goMap[5605040343757950433L].transform.SetParent(goMap[8536586568232852005L].transform, false);
        goMap[-6748410631975813865L].transform.SetParent(goMap[8536586568232852005L].transform, false);
        goMap[1369497950442509137L].transform.SetParent(goMap[-6748410631975813865L].transform, false);
        goMap[9016191649954929126L].transform.SetParent(goMap[8536586568232852005L].transform, false);

        // ─── RectTransforms ──────────────────────────────────
        {
            var rt = goMap[1423852112789855193L].AddComponent<RectTransform>();
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
            var rt = goMap[-1280174617360273851L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }

        // ─── Components ──────────────────────────────────────
        { var c = goMap[1423852112789855193L].AddComponent<Canvas>();
           c.renderMode = (RenderMode)1;
           c.overrideSorting = true;
           c.sortingOrder = 0;
           c.sortingLayerID = unchecked((int)194136777);
           c.planeDistance = 100.000000f;
           c.pixelPerfect = false;
           c.additionalShaderChannels = (AdditionalCanvasShaderChannels)0;
           c.enabled = true;
        }
        { var c = goMap[1423852112789855193L].AddComponent<GraphicRaycaster>();
           c.ignoreReversedGraphics = true;
        }
        { var c = goMap[1423852112789855193L].AddComponent<CanvasScaler>();
           c.uiScaleMode = (CanvasScaler.ScaleMode)1;
           c.referenceResolution = new Vector2(1280.000000f, 720.000000f);
           c.screenMatchMode = (CanvasScaler.ScreenMatchMode)1;
           c.matchWidthOrHeight = 0.000000f;
           c.referencePixelsPerUnit = 100.000000f;
        }
        { var c = goMap[-1280174617360273851L].AddComponent<Image>();
           c.color = new Color(1f,1f,1f,0f);
           c.raycastTarget = true;
           c.maskable = true;
           c.enabled = true;
        }
        { var c = goMap[-1280174617360273851L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[2069477363416162599L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("aixin_lujing(Clone)"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[2890766478643089027L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("aixin_lujing(Clone)"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
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
        var rootGO = goMap[1423852112789855193L];
        string path = "Assets/Prefabs/Imported/UIGiftEffect_1_2.prefab";
        PrefabUtility.SaveAsPrefabAsset(rootGO, path);
        Object.DestroyImmediate(rootGO);
        Debug.Log("[Import_res_p_289] Saved " + path);
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