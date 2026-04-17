// AUTO-GENERATED from res_p_287.ab — DO NOT EDIT MANUALLY.
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;
using System.Collections.Generic;
using KTO.Game;  // UIJoyStick and other ported KTO scripts

public class Import_res_p_287
{
    [MenuItem("KTO/Import/res_p_287")]
    public static void Build()
    {
        Debug.Log("[Import_res_p_287] Building UIGiftEffect_0_3...");

        // ─── Create all GameObjects ───────────────────────────
        var goMap = new Dictionary<long, GameObject>();
        var _toggleGroupByMbPid = new Dictionary<long, ToggleGroup>();
        var _toggleGroupLinks = new List<System.Tuple<Toggle,long>>();
        { var go = new GameObject("UIGiftEffect_0_3"); go.SetActive(true); goMap[-6586748065354952823L] = go; }
        { var go = new GameObject("ClickEmptyToClose"); go.SetActive(true); goMap[-1176440815172676541L] = go; }
        { var go = new GameObject("UIQinMiDu_nan3"); go.SetActive(true); goMap[-8649788445617972792L] = go; }
        { var go = new GameObject("P10"); go.SetActive(true); goMap[-5194044585107555176L] = go; }
        { var go = new GameObject("p5_ai"); go.SetActive(true); goMap[-8512398458381839015L] = go; }
        { var go = new GameObject("P10"); go.SetActive(true); goMap[-5884886767704921856L] = go; }
        { var go = new GameObject("tengman+lujing"); go.SetActive(true); goMap[1860205725281724962L] = go; }
        { var go = new GameObject("Dummy001"); go.SetActive(true); goMap[-2834375305641197034L] = go; }
        { var go = new GameObject("p5_ai"); go.SetActive(true); goMap[-1794225080024199929L] = go; }
        { var go = new GameObject("Trail"); go.SetActive(true); goMap[-7938113873140333642L] = go; }
        { var go = new GameObject("Dummy002"); go.SetActive(true); goMap[6642589600589321135L] = go; }
        { var go = new GameObject("p5_ai"); go.SetActive(true); goMap[7738407885071837659L] = go; }
        { var go = new GameObject("Trail"); go.SetActive(true); goMap[5298225336308713608L] = go; }
        { var go = new GameObject("Dummy003"); go.SetActive(true); goMap[5768568441058623610L] = go; }
        { var go = new GameObject("p5_ai"); go.SetActive(true); goMap[4132178439852977963L] = go; }
        { var go = new GameObject("Trail"); go.SetActive(true); goMap[-2636328431319992189L] = go; }
        { var go = new GameObject("Dummy004"); go.SetActive(true); goMap[-2930267854212930309L] = go; }
        { var go = new GameObject("p5_ai"); go.SetActive(true); goMap[-7196424881263881532L] = go; }
        { var go = new GameObject("Trail"); go.SetActive(true); goMap[1727459161702673937L] = go; }
        { var go = new GameObject("Dummy005"); go.SetActive(true); goMap[8392494715205147954L] = go; }
        { var go = new GameObject("p5_ai"); go.SetActive(true); goMap[363776209636815413L] = go; }
        { var go = new GameObject("Trail"); go.SetActive(true); goMap[-1913688801881480873L] = go; }
        { var go = new GameObject("Line001"); go.SetActive(true); goMap[4027145437796865114L] = go; }
        { var go = new GameObject("Line002"); go.SetActive(true); goMap[5444795400109428756L] = go; }
        { var go = new GameObject("Line003"); go.SetActive(true); goMap[2535657422749622302L] = go; }
        { var go = new GameObject("Line004"); go.SetActive(true); goMap[-1631379591682470441L] = go; }
        { var go = new GameObject("Line009"); go.SetActive(true); goMap[6856477009719777325L] = go; }
        { var go = new GameObject("P5_ai"); go.SetActive(true); goMap[-8558128514343652053L] = go; }
        { var go = new GameObject("tengman+lujing"); go.SetActive(true); goMap[-264741417082665778L] = go; }
        { var go = new GameObject("Dummy001"); go.SetActive(true); goMap[-115603690049361812L] = go; }
        { var go = new GameObject("p5_ai"); go.SetActive(true); goMap[-5387804219285866229L] = go; }
        { var go = new GameObject("Trail"); go.SetActive(true); goMap[-4630616862388956862L] = go; }
        { var go = new GameObject("Dummy002"); go.SetActive(true); goMap[7845820335659310340L] = go; }
        { var go = new GameObject("p5_ai"); go.SetActive(true); goMap[-2210583379554311167L] = go; }
        { var go = new GameObject("Trail"); go.SetActive(true); goMap[6368748403624397669L] = go; }
        { var go = new GameObject("Dummy003"); go.SetActive(true); goMap[7735383071344291608L] = go; }
        { var go = new GameObject("p5_ai"); go.SetActive(true); goMap[576043187818360624L] = go; }
        { var go = new GameObject("Trail"); go.SetActive(true); goMap[2883206415765635762L] = go; }
        { var go = new GameObject("Dummy004"); go.SetActive(true); goMap[6204966251896098581L] = go; }
        { var go = new GameObject("p5_ai"); go.SetActive(true); goMap[-9030311588842214693L] = go; }
        { var go = new GameObject("Trail"); go.SetActive(true); goMap[226676163816431922L] = go; }
        { var go = new GameObject("Dummy005"); go.SetActive(true); goMap[7388599469561970201L] = go; }
        { var go = new GameObject("p5_ai"); go.SetActive(true); goMap[-4484214756040857982L] = go; }
        { var go = new GameObject("Trail"); go.SetActive(true); goMap[-8861612905858938773L] = go; }
        { var go = new GameObject("Line001"); go.SetActive(true); goMap[-3023902886608719858L] = go; }
        { var go = new GameObject("Line002"); go.SetActive(true); goMap[3815083415923645500L] = go; }
        { var go = new GameObject("Line003"); go.SetActive(true); goMap[-7367674694404931950L] = go; }
        { var go = new GameObject("Line004"); go.SetActive(true); goMap[714227764318674934L] = go; }
        { var go = new GameObject("Line009"); go.SetActive(true); goMap[-8914181134591214103L] = go; }
        { var go = new GameObject("tengman+lujing"); go.SetActive(true); goMap[2441155251308058435L] = go; }
        { var go = new GameObject("Dummy002"); go.SetActive(true); goMap[5718652733295758800L] = go; }
        { var go = new GameObject("p5_ai"); go.SetActive(true); goMap[-5898415695104553508L] = go; }
        { var go = new GameObject("Trail"); go.SetActive(true); goMap[5285954708349250135L] = go; }
        { var go = new GameObject("Dummy003"); go.SetActive(true); goMap[3412269626070996721L] = go; }
        { var go = new GameObject("p5_ai"); go.SetActive(true); goMap[-3811062220563908052L] = go; }
        { var go = new GameObject("Trail"); go.SetActive(true); goMap[-5343407670429372863L] = go; }
        { var go = new GameObject("Dummy004"); go.SetActive(true); goMap[6110682003198695211L] = go; }
        { var go = new GameObject("p5_ai"); go.SetActive(true); goMap[-2988049740372072263L] = go; }
        { var go = new GameObject("Trail"); go.SetActive(true); goMap[2807825499204213141L] = go; }
        { var go = new GameObject("Dummy005"); go.SetActive(true); goMap[-8631931299939852528L] = go; }
        { var go = new GameObject("p5_ai"); go.SetActive(true); goMap[5833342874797393347L] = go; }
        { var go = new GameObject("Trail"); go.SetActive(true); goMap[2679076420775940784L] = go; }
        { var go = new GameObject("Line002"); go.SetActive(true); goMap[3385274746440397801L] = go; }
        { var go = new GameObject("Line003"); go.SetActive(true); goMap[-2700524801318506369L] = go; }
        { var go = new GameObject("Line004"); go.SetActive(true); goMap[850057431334413519L] = go; }
        { var go = new GameObject("Line009"); go.SetActive(true); goMap[-4348540337795282452L] = go; }

        // ─── Parent links ─────────────────────────────────────
        goMap[-1176440815172676541L].transform.SetParent(goMap[-6586748065354952823L].transform, false);
        goMap[-8649788445617972792L].transform.SetParent(goMap[-6586748065354952823L].transform, false);
        goMap[-5194044585107555176L].transform.SetParent(goMap[-8649788445617972792L].transform, false);
        goMap[-8512398458381839015L].transform.SetParent(goMap[-8649788445617972792L].transform, false);
        goMap[-5884886767704921856L].transform.SetParent(goMap[-8649788445617972792L].transform, false);
        goMap[1860205725281724962L].transform.SetParent(goMap[-8649788445617972792L].transform, false);
        goMap[-2834375305641197034L].transform.SetParent(goMap[1860205725281724962L].transform, false);
        goMap[-1794225080024199929L].transform.SetParent(goMap[-2834375305641197034L].transform, false);
        goMap[-7938113873140333642L].transform.SetParent(goMap[-2834375305641197034L].transform, false);
        goMap[6642589600589321135L].transform.SetParent(goMap[1860205725281724962L].transform, false);
        goMap[7738407885071837659L].transform.SetParent(goMap[6642589600589321135L].transform, false);
        goMap[5298225336308713608L].transform.SetParent(goMap[6642589600589321135L].transform, false);
        goMap[5768568441058623610L].transform.SetParent(goMap[1860205725281724962L].transform, false);
        goMap[4132178439852977963L].transform.SetParent(goMap[5768568441058623610L].transform, false);
        goMap[-2636328431319992189L].transform.SetParent(goMap[5768568441058623610L].transform, false);
        goMap[-2930267854212930309L].transform.SetParent(goMap[1860205725281724962L].transform, false);
        goMap[-7196424881263881532L].transform.SetParent(goMap[-2930267854212930309L].transform, false);
        goMap[1727459161702673937L].transform.SetParent(goMap[-2930267854212930309L].transform, false);
        goMap[8392494715205147954L].transform.SetParent(goMap[1860205725281724962L].transform, false);
        goMap[363776209636815413L].transform.SetParent(goMap[8392494715205147954L].transform, false);
        goMap[-1913688801881480873L].transform.SetParent(goMap[8392494715205147954L].transform, false);
        goMap[4027145437796865114L].transform.SetParent(goMap[1860205725281724962L].transform, false);
        goMap[5444795400109428756L].transform.SetParent(goMap[1860205725281724962L].transform, false);
        goMap[2535657422749622302L].transform.SetParent(goMap[1860205725281724962L].transform, false);
        goMap[-1631379591682470441L].transform.SetParent(goMap[1860205725281724962L].transform, false);
        goMap[6856477009719777325L].transform.SetParent(goMap[1860205725281724962L].transform, false);
        goMap[-8558128514343652053L].transform.SetParent(goMap[1860205725281724962L].transform, false);
        goMap[-264741417082665778L].transform.SetParent(goMap[-8649788445617972792L].transform, false);
        goMap[-115603690049361812L].transform.SetParent(goMap[-264741417082665778L].transform, false);
        goMap[-5387804219285866229L].transform.SetParent(goMap[-115603690049361812L].transform, false);
        goMap[-4630616862388956862L].transform.SetParent(goMap[-115603690049361812L].transform, false);
        goMap[7845820335659310340L].transform.SetParent(goMap[-264741417082665778L].transform, false);
        goMap[-2210583379554311167L].transform.SetParent(goMap[7845820335659310340L].transform, false);
        goMap[6368748403624397669L].transform.SetParent(goMap[7845820335659310340L].transform, false);
        goMap[7735383071344291608L].transform.SetParent(goMap[-264741417082665778L].transform, false);
        goMap[576043187818360624L].transform.SetParent(goMap[7735383071344291608L].transform, false);
        goMap[2883206415765635762L].transform.SetParent(goMap[7735383071344291608L].transform, false);
        goMap[6204966251896098581L].transform.SetParent(goMap[-264741417082665778L].transform, false);
        goMap[-9030311588842214693L].transform.SetParent(goMap[6204966251896098581L].transform, false);
        goMap[226676163816431922L].transform.SetParent(goMap[6204966251896098581L].transform, false);
        goMap[7388599469561970201L].transform.SetParent(goMap[-264741417082665778L].transform, false);
        goMap[-4484214756040857982L].transform.SetParent(goMap[7388599469561970201L].transform, false);
        goMap[-8861612905858938773L].transform.SetParent(goMap[7388599469561970201L].transform, false);
        goMap[-3023902886608719858L].transform.SetParent(goMap[-264741417082665778L].transform, false);
        goMap[3815083415923645500L].transform.SetParent(goMap[-264741417082665778L].transform, false);
        goMap[-7367674694404931950L].transform.SetParent(goMap[-264741417082665778L].transform, false);
        goMap[714227764318674934L].transform.SetParent(goMap[-264741417082665778L].transform, false);
        goMap[-8914181134591214103L].transform.SetParent(goMap[-264741417082665778L].transform, false);
        goMap[2441155251308058435L].transform.SetParent(goMap[-8649788445617972792L].transform, false);
        goMap[5718652733295758800L].transform.SetParent(goMap[2441155251308058435L].transform, false);
        goMap[-5898415695104553508L].transform.SetParent(goMap[5718652733295758800L].transform, false);
        goMap[5285954708349250135L].transform.SetParent(goMap[5718652733295758800L].transform, false);
        goMap[3412269626070996721L].transform.SetParent(goMap[2441155251308058435L].transform, false);
        goMap[-3811062220563908052L].transform.SetParent(goMap[3412269626070996721L].transform, false);
        goMap[-5343407670429372863L].transform.SetParent(goMap[3412269626070996721L].transform, false);
        goMap[6110682003198695211L].transform.SetParent(goMap[2441155251308058435L].transform, false);
        goMap[-2988049740372072263L].transform.SetParent(goMap[6110682003198695211L].transform, false);
        goMap[2807825499204213141L].transform.SetParent(goMap[6110682003198695211L].transform, false);
        goMap[-8631931299939852528L].transform.SetParent(goMap[2441155251308058435L].transform, false);
        goMap[5833342874797393347L].transform.SetParent(goMap[-8631931299939852528L].transform, false);
        goMap[2679076420775940784L].transform.SetParent(goMap[-8631931299939852528L].transform, false);
        goMap[3385274746440397801L].transform.SetParent(goMap[2441155251308058435L].transform, false);
        goMap[-2700524801318506369L].transform.SetParent(goMap[2441155251308058435L].transform, false);
        goMap[850057431334413519L].transform.SetParent(goMap[2441155251308058435L].transform, false);
        goMap[-4348540337795282452L].transform.SetParent(goMap[2441155251308058435L].transform, false);

        // ─── RectTransforms ──────────────────────────────────
        {
            var rt = goMap[-6586748065354952823L].AddComponent<RectTransform>();
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
            var rt = goMap[-1176440815172676541L].AddComponent<RectTransform>();
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
        { var c = goMap[-6586748065354952823L].AddComponent<Canvas>();
           c.renderMode = (RenderMode)1;
           c.overrideSorting = true;
           c.sortingOrder = 0;
           c.sortingLayerID = unchecked((int)194136777);
           c.planeDistance = 100.000000f;
           c.pixelPerfect = false;
           c.additionalShaderChannels = (AdditionalCanvasShaderChannels)0;
           c.enabled = true;
        }
        { var c = goMap[-6586748065354952823L].AddComponent<GraphicRaycaster>();
           c.ignoreReversedGraphics = true;
        }
        { var c = goMap[-6586748065354952823L].AddComponent<CanvasScaler>();
           c.uiScaleMode = (CanvasScaler.ScaleMode)1;
           c.referenceResolution = new Vector2(1280.000000f, 720.000000f);
           c.screenMatchMode = (CanvasScaler.ScreenMatchMode)1;
           c.matchWidthOrHeight = 0.000000f;
           c.referencePixelsPerUnit = 100.000000f;
        }
        { var c = goMap[-1176440815172676541L].AddComponent<Image>();
           c.color = new Color(1f,1f,1f,0f);
           c.raycastTarget = true;
           c.maskable = true;
           c.enabled = true;
        }
        { var c = goMap[-1176440815172676541L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[1860205725281724962L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("tengman+lujing3"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[-264741417082665778L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("tengman+lujing"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[2441155251308058435L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("tengman+lujing2"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
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
        var rootGO = goMap[-6586748065354952823L];
        string path = "Assets/Prefabs/Imported/UIGiftEffect_0_3.prefab";
        PrefabUtility.SaveAsPrefabAsset(rootGO, path);
        Object.DestroyImmediate(rootGO);
        Debug.Log("[Import_res_p_287] Saved " + path);
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