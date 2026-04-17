// AUTO-GENERATED from res_p_290.ab — DO NOT EDIT MANUALLY.
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;
using System.Collections.Generic;
using KTO.Game;  // UIJoyStick and other ported KTO scripts

public class Import_res_p_290
{
    [MenuItem("KTO/Import/res_p_290")]
    public static void Build()
    {
        Debug.Log("[Import_res_p_290] Building UIGiftEffect_1_3...");

        // ─── Create all GameObjects ───────────────────────────
        var goMap = new Dictionary<long, GameObject>();
        var _toggleGroupByMbPid = new Dictionary<long, ToggleGroup>();
        var _toggleGroupLinks = new List<System.Tuple<Toggle,long>>();
        { var go = new GameObject("UIGiftEffect_1_3"); go.SetActive(true); goMap[-2455511028382004459L] = go; }
        { var go = new GameObject("ClickEmptyToClose"); go.SetActive(true); goMap[-2670551807702123439L] = go; }
        { var go = new GameObject("UIQinMiDu_nv3"); go.SetActive(true); goMap[-3400973070579547229L] = go; }
        { var go = new GameObject("P1_an"); go.SetActive(true); goMap[1471857076662344157L] = go; }
        { var go = new GameObject("P2_liang"); go.SetActive(true); goMap[-5651496245804011516L] = go; }
        { var go = new GameObject("P3"); go.SetActive(true); goMap[-5545433946476102695L] = go; }
        { var go = new GameObject("P4"); go.SetActive(true); goMap[6714601894067482213L] = go; }
        { var go = new GameObject("P4_1"); go.SetActive(true); goMap[7101736635837981655L] = go; }
        { var go = new GameObject("p2"); go.SetActive(true); goMap[-5398632013272878685L] = go; }
        { var go = new GameObject("aixin_lujing(Clone)"); go.SetActive(true); goMap[4639087054427927836L] = go; }
        { var go = new GameObject("Dummy001"); go.SetActive(true); goMap[4140850831711803171L] = go; }
        { var go = new GameObject("p5_ai"); go.SetActive(true); goMap[-4283151807592761438L] = go; }
        { var go = new GameObject("Dummy002"); go.SetActive(true); goMap[-3100849584647913185L] = go; }
        { var go = new GameObject("p5_ai"); go.SetActive(true); goMap[547210765115633482L] = go; }
        { var go = new GameObject("Line012"); go.SetActive(true); goMap[-571158206053868039L] = go; }
        { var go = new GameObject("Line013"); go.SetActive(true); goMap[-2329448644530325336L] = go; }
        { var go = new GameObject("aixin_ani"); go.SetActive(true); goMap[-6855820080607375990L] = go; }
        { var go = new GameObject("Mod_p4_ai"); go.SetActive(true); goMap[-2716058436113110916L] = go; }
        { var go = new GameObject("Mod_p4_ai_L"); go.SetActive(true); goMap[6605422059674364877L] = go; }
        { var go = new GameObject("p7_KS"); go.SetActive(true); goMap[8467444928667251835L] = go; }
        { var go = new GameObject("P8"); go.SetActive(true); goMap[3810320318812997081L] = go; }
        { var go = new GameObject("p14"); go.SetActive(true); goMap[6350000971462145051L] = go; }
        { var go = new GameObject("p15"); go.SetActive(true); goMap[5835058374244285513L] = go; }

        // ─── Parent links ─────────────────────────────────────
        goMap[-2670551807702123439L].transform.SetParent(goMap[-2455511028382004459L].transform, false);
        goMap[-3400973070579547229L].transform.SetParent(goMap[-2455511028382004459L].transform, false);
        goMap[1471857076662344157L].transform.SetParent(goMap[-3400973070579547229L].transform, false);
        goMap[-5651496245804011516L].transform.SetParent(goMap[-3400973070579547229L].transform, false);
        goMap[-5545433946476102695L].transform.SetParent(goMap[-3400973070579547229L].transform, false);
        goMap[6714601894067482213L].transform.SetParent(goMap[-3400973070579547229L].transform, false);
        goMap[7101736635837981655L].transform.SetParent(goMap[-3400973070579547229L].transform, false);
        goMap[-5398632013272878685L].transform.SetParent(goMap[-3400973070579547229L].transform, false);
        goMap[4639087054427927836L].transform.SetParent(goMap[-3400973070579547229L].transform, false);
        goMap[4140850831711803171L].transform.SetParent(goMap[4639087054427927836L].transform, false);
        goMap[-4283151807592761438L].transform.SetParent(goMap[4140850831711803171L].transform, false);
        goMap[-3100849584647913185L].transform.SetParent(goMap[4639087054427927836L].transform, false);
        goMap[547210765115633482L].transform.SetParent(goMap[-3100849584647913185L].transform, false);
        goMap[-571158206053868039L].transform.SetParent(goMap[4639087054427927836L].transform, false);
        goMap[-2329448644530325336L].transform.SetParent(goMap[4639087054427927836L].transform, false);
        goMap[-6855820080607375990L].transform.SetParent(goMap[-3400973070579547229L].transform, false);
        goMap[-2716058436113110916L].transform.SetParent(goMap[-6855820080607375990L].transform, false);
        goMap[6605422059674364877L].transform.SetParent(goMap[-6855820080607375990L].transform, false);
        goMap[8467444928667251835L].transform.SetParent(goMap[-6855820080607375990L].transform, false);
        goMap[3810320318812997081L].transform.SetParent(goMap[-3400973070579547229L].transform, false);
        goMap[6350000971462145051L].transform.SetParent(goMap[-3400973070579547229L].transform, false);
        goMap[5835058374244285513L].transform.SetParent(goMap[6350000971462145051L].transform, false);

        // ─── RectTransforms ──────────────────────────────────
        {
            var rt = goMap[-2455511028382004459L].AddComponent<RectTransform>();
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
            var rt = goMap[-2670551807702123439L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }

        // ─── Components ──────────────────────────────────────
        { var c = goMap[-2455511028382004459L].AddComponent<Canvas>();
           c.renderMode = (RenderMode)1;
           c.overrideSorting = true;
           c.sortingOrder = 0;
           c.sortingLayerID = unchecked((int)194136777);
           c.planeDistance = 100.000000f;
           c.pixelPerfect = false;
           c.additionalShaderChannels = (AdditionalCanvasShaderChannels)0;
           c.enabled = true;
        }
        { var c = goMap[-2455511028382004459L].AddComponent<GraphicRaycaster>();
           c.ignoreReversedGraphics = true;
        }
        { var c = goMap[-2455511028382004459L].AddComponent<CanvasScaler>();
           c.uiScaleMode = (CanvasScaler.ScaleMode)1;
           c.referenceResolution = new Vector2(1280.000000f, 720.000000f);
           c.screenMatchMode = (CanvasScaler.ScreenMatchMode)1;
           c.matchWidthOrHeight = 0.000000f;
           c.referencePixelsPerUnit = 100.000000f;
        }
        { var c = goMap[-2670551807702123439L].AddComponent<Image>();
           c.color = new Color(1f,1f,1f,0f);
           c.raycastTarget = true;
           c.maskable = true;
           c.enabled = true;
        }
        { var c = goMap[-2670551807702123439L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[4639087054427927836L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("aixin_lujing(Clone)"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[-6855820080607375990L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("aixin_ani"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
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
        var rootGO = goMap[-2455511028382004459L];
        string path = "Assets/Prefabs/Imported/UIGiftEffect_1_3.prefab";
        PrefabUtility.SaveAsPrefabAsset(rootGO, path);
        Object.DestroyImmediate(rootGO);
        Debug.Log("[Import_res_p_290] Saved " + path);
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