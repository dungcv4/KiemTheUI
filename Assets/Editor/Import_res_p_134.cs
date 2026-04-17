// AUTO-GENERATED from res_p_134.ab — DO NOT EDIT MANUALLY.
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;
using System.Collections.Generic;
using KTO.Game;  // UIJoyStick and other ported KTO scripts

public class Import_res_p_134
{
    [MenuItem("KTO/Import/res_p_134")]
    public static void Build()
    {
        Debug.Log("[Import_res_p_134] Building UILoginBG...");

        // ─── Create all GameObjects ───────────────────────────
        var goMap = new Dictionary<long, GameObject>();
        var _toggleGroupByMbPid = new Dictionary<long, ToggleGroup>();
        var _toggleGroupLinks = new List<System.Tuple<Toggle,long>>();
        { var go = new GameObject("UILoginBG"); go.SetActive(true); goMap[-6428595806602477281L] = go; }
        { var go = new GameObject("bg"); go.SetActive(true); goMap[-4532044079407381979L] = go; }
        { var go = new GameObject("VFX_after"); go.SetActive(true); goMap[7132010007907565446L] = go; }
        { var go = new GameObject("VFX_huo_after"); go.SetActive(true); goMap[9104246940477716032L] = go; }
        { var go = new GameObject("WL161_4x4_WL165_4x4"); go.SetActive(true); goMap[-6267013990400333679L] = go; }
        { var go = new GameObject("GX09_u075"); go.SetActive(true); goMap[-3966047278140858461L] = go; }
        { var go = new GameObject("H7_6x6_GQ004_NM"); go.SetActive(true); goMap[-1419232825741571446L] = go; }
        { var go = new GameObject("VFX_jin_after"); go.SetActive(true); goMap[-1426101848517844168L] = go; }
        { var go = new GameObject("GX09_u075"); go.SetActive(true); goMap[1333523025360474266L] = go; }
        { var go = new GameObject("GX064"); go.SetActive(true); goMap[-7433625325218532120L] = go; }
        { var go = new GameObject("WL101_YW10_pattern006"); go.SetActive(true); goMap[8400184265297170382L] = go; }
        { var go = new GameObject("GC20"); go.SetActive(true); goMap[6442150858203728527L] = go; }
        { var go = new GameObject("YW27_8X8_u15 "); go.SetActive(true); goMap[4350813797480540700L] = go; }
        { var go = new GameObject("VFX_mu_after"); go.SetActive(true); goMap[-5176299835808690722L] = go; }
        { var go = new GameObject("GC20"); go.SetActive(true); goMap[-6861940708473592530L] = go; }
        { var go = new GameObject("GX09_u075"); go.SetActive(true); goMap[-4984716205103513979L] = go; }
        { var go = new GameObject("GX35_u055"); go.SetActive(true); goMap[-5483688343236796861L] = go; }
        { var go = new GameObject("GX35 "); go.SetActive(true); goMap[917282519155369795L] = go; }
        { var go = new GameObject("GX09_GQ002_u25"); go.SetActive(true); goMap[8505208344424525749L] = go; }
        { var go = new GameObject("VFX_shui_after"); go.SetActive(true); goMap[-3581862602079153080L] = go; }
        { var go = new GameObject("WATER_UV17"); go.SetActive(true); goMap[4644806530897578711L] = go; }
        { var go = new GameObject("YW24_4x4_YW029"); go.SetActive(true); goMap[8707659020960557724L] = go; }
        { var go = new GameObject("GX064"); go.SetActive(true); goMap[2928905901524233455L] = go; }
        { var go = new GameObject("VFX_tu_after"); go.SetActive(true); goMap[-4647464720942671106L] = go; }
        { var go = new GameObject("WL21_WL04_WL087"); go.SetActive(true); goMap[8134862841881860709L] = go; }
        { var go = new GameObject("GX_145"); go.SetActive(true); goMap[-6669230339951480113L] = go; }
        { var go = new GameObject("GX35_u055"); go.SetActive(true); goMap[-3279304184896580095L] = go; }
        { var go = new GameObject("GX002_u1"); go.SetActive(true); goMap[-2685688595825941259L] = go; }
        { var go = new GameObject("VFX_TY_frame_after"); go.SetActive(true); goMap[-386461166532853005L] = go; }
        { var go = new GameObject("GL2"); go.SetActive(true); goMap[-319847555131889337L] = go; }
        { var go = new GameObject("ZZ020_u3"); go.SetActive(true); goMap[-6379898334166272707L] = go; }
        { var go = new GameObject("GC24"); go.SetActive(true); goMap[-1970293998579919247L] = go; }
        { var go = new GameObject("Character"); go.SetActive(true); goMap[-4975886052411155216L] = go; }
        { var go = new GameObject("VFX_front"); go.SetActive(true); goMap[8712777727523364934L] = go; }
        { var go = new GameObject("VFX_huo_front"); go.SetActive(true); goMap[5648229339714525466L] = go; }
        { var go = new GameObject("WL101_YW10_pattern006"); go.SetActive(true); goMap[-4662952355797881040L] = go; }
        { var go = new GameObject("GX35_1"); go.SetActive(true); goMap[-1401290122993801566L] = go; }
        { var go = new GameObject("WL161_4x4_WL165_4x4_WL21_04_087"); go.SetActive(true); goMap[4889091944770547114L] = go; }
        { var go = new GameObject("GX100"); go.SetActive(true); goMap[1148876562491958600L] = go; }
        { var go = new GameObject("GX100"); go.SetActive(true); goMap[1027480766279978888L] = go; }
        { var go = new GameObject("PUBU04_u2"); go.SetActive(true); goMap[5086721155554862269L] = go; }
        { var go = new GameObject("GX35"); go.SetActive(true); goMap[-5049482167094195229L] = go; }
        { var go = new GameObject("WL21_WL04_WL087"); go.SetActive(true); goMap[7216413508561066453L] = go; }
        { var go = new GameObject("VFX_jin_front"); go.SetActive(true); goMap[-7458168519803429543L] = go; }
        { var go = new GameObject("GX35_u1"); go.SetActive(true); goMap[-2438854537872415752L] = go; }
        { var go = new GameObject("WL101_YW10_pattern006"); go.SetActive(true); goMap[5582497292106975530L] = go; }
        { var go = new GameObject("GX100_Trail012_C_GX027"); go.SetActive(true); goMap[8279123865888004365L] = go; }
        { var go = new GameObject("WL21_WL04_WL087_10"); go.SetActive(true); goMap[4421475789809879540L] = go; }
        { var go = new GameObject("WL101_YW10_pattern006"); go.SetActive(true); goMap[-3763094828612211125L] = go; }
        { var go = new GameObject("ZZ_101_2"); go.SetActive(true); goMap[-364466541931465537L] = go; }
        { var go = new GameObject("GX35_1"); go.SetActive(true); goMap[-8776497411219608732L] = go; }
        { var go = new GameObject("GX100"); go.SetActive(true); goMap[-9145123460429036632L] = go; }
        { var go = new GameObject("VFX_mu_front"); go.SetActive(true); goMap[8989855467871328993L] = go; }
        { var go = new GameObject("SP028"); go.SetActive(true); goMap[3206901727795515479L] = go; }
        { var go = new GameObject("Trail012_C_GX027_SP028"); go.SetActive(true); goMap[8742194208416047046L] = go; }
        { var go = new GameObject("GX064"); go.SetActive(true); goMap[-7942457896754736462L] = go; }
        { var go = new GameObject("GX100"); go.SetActive(true); goMap[5068226409393469632L] = go; }
        { var go = new GameObject("VFX_shui_front"); go.SetActive(true); goMap[-739170741247203706L] = go; }
        { var go = new GameObject("GX100_DG11_u3"); go.SetActive(true); goMap[6961527997050783052L] = go; }
        { var go = new GameObject("GX82_3x3"); go.SetActive(true); goMap[-2861859885438497723L] = go; }
        { var go = new GameObject("PUBU04_WL087"); go.SetActive(true); goMap[3964028590921840999L] = go; }
        { var go = new GameObject("WL101_YW10_pattern006_B_NM_B"); go.SetActive(true); goMap[773830895861647298L] = go; }
        { var go = new GameObject("GX35"); go.SetActive(true); goMap[-792638372989306488L] = go; }
        { var go = new GameObject("WL21_WL04_WL087"); go.SetActive(true); goMap[7668543168521929864L] = go; }
        { var go = new GameObject("VFX_tu_front "); go.SetActive(true); goMap[-7126516005275752160L] = go; }
        { var go = new GameObject("GX35_1"); go.SetActive(true); goMap[2923282875364503165L] = go; }
        { var go = new GameObject("GX35 "); go.SetActive(true); goMap[4870152896775824161L] = go; }
        { var go = new GameObject("YW27_8X8_u15"); go.SetActive(true); goMap[-8793321486146728712L] = go; }
        { var go = new GameObject("Trail012_C_GX027_SP028"); go.SetActive(true); goMap[2612876831045535843L] = go; }
        { var go = new GameObject("WL21_WL04_WL087"); go.SetActive(true); goMap[-7924306886857237679L] = go; }
        { var go = new GameObject("PUBU04_WL087"); go.SetActive(true); goMap[2497631182656477890L] = go; }
        { var go = new GameObject("PUBU04_u2"); go.SetActive(true); goMap[886473408316856334L] = go; }
        { var go = new GameObject("WL085_YW029_WL087"); go.SetActive(true); goMap[4773272331089030641L] = go; }
        { var go = new GameObject("VFX_TY_frame_front"); go.SetActive(true); goMap[-5596553230426531367L] = go; }
        { var go = new GameObject("GY005_GY006"); go.SetActive(true); goMap[8198289488477102507L] = go; }
        { var go = new GameObject("DG21"); go.SetActive(true); goMap[-2777418989571799142L] = go; }
        { var go = new GameObject("GX100"); go.SetActive(true); goMap[2574938358674990763L] = go; }
        { var go = new GameObject("ZZ005"); go.SetActive(true); goMap[2169758915888199572L] = go; }

        // ─── Parent links ─────────────────────────────────────
        goMap[-4532044079407381979L].transform.SetParent(goMap[-6428595806602477281L].transform, false);
        goMap[7132010007907565446L].transform.SetParent(goMap[-6428595806602477281L].transform, false);
        goMap[9104246940477716032L].transform.SetParent(goMap[7132010007907565446L].transform, false);
        goMap[-6267013990400333679L].transform.SetParent(goMap[9104246940477716032L].transform, false);
        goMap[-3966047278140858461L].transform.SetParent(goMap[9104246940477716032L].transform, false);
        goMap[-1419232825741571446L].transform.SetParent(goMap[9104246940477716032L].transform, false);
        goMap[-1426101848517844168L].transform.SetParent(goMap[7132010007907565446L].transform, false);
        goMap[1333523025360474266L].transform.SetParent(goMap[-1426101848517844168L].transform, false);
        goMap[-7433625325218532120L].transform.SetParent(goMap[-1426101848517844168L].transform, false);
        goMap[8400184265297170382L].transform.SetParent(goMap[-1426101848517844168L].transform, false);
        goMap[6442150858203728527L].transform.SetParent(goMap[-1426101848517844168L].transform, false);
        goMap[4350813797480540700L].transform.SetParent(goMap[-1426101848517844168L].transform, false);
        goMap[-5176299835808690722L].transform.SetParent(goMap[7132010007907565446L].transform, false);
        goMap[-6861940708473592530L].transform.SetParent(goMap[-5176299835808690722L].transform, false);
        goMap[-4984716205103513979L].transform.SetParent(goMap[-5176299835808690722L].transform, false);
        goMap[-5483688343236796861L].transform.SetParent(goMap[-5176299835808690722L].transform, false);
        goMap[917282519155369795L].transform.SetParent(goMap[-5176299835808690722L].transform, false);
        goMap[8505208344424525749L].transform.SetParent(goMap[-5176299835808690722L].transform, false);
        goMap[-3581862602079153080L].transform.SetParent(goMap[7132010007907565446L].transform, false);
        goMap[4644806530897578711L].transform.SetParent(goMap[-3581862602079153080L].transform, false);
        goMap[8707659020960557724L].transform.SetParent(goMap[-3581862602079153080L].transform, false);
        goMap[2928905901524233455L].transform.SetParent(goMap[-3581862602079153080L].transform, false);
        goMap[-4647464720942671106L].transform.SetParent(goMap[7132010007907565446L].transform, false);
        goMap[8134862841881860709L].transform.SetParent(goMap[-4647464720942671106L].transform, false);
        goMap[-6669230339951480113L].transform.SetParent(goMap[-4647464720942671106L].transform, false);
        goMap[-3279304184896580095L].transform.SetParent(goMap[-4647464720942671106L].transform, false);
        goMap[-2685688595825941259L].transform.SetParent(goMap[-4647464720942671106L].transform, false);
        goMap[-386461166532853005L].transform.SetParent(goMap[7132010007907565446L].transform, false);
        goMap[-319847555131889337L].transform.SetParent(goMap[-386461166532853005L].transform, false);
        goMap[-6379898334166272707L].transform.SetParent(goMap[-386461166532853005L].transform, false);
        goMap[-1970293998579919247L].transform.SetParent(goMap[-386461166532853005L].transform, false);
        goMap[-4975886052411155216L].transform.SetParent(goMap[-6428595806602477281L].transform, false);
        goMap[8712777727523364934L].transform.SetParent(goMap[-6428595806602477281L].transform, false);
        goMap[5648229339714525466L].transform.SetParent(goMap[8712777727523364934L].transform, false);
        goMap[-4662952355797881040L].transform.SetParent(goMap[5648229339714525466L].transform, false);
        goMap[-1401290122993801566L].transform.SetParent(goMap[5648229339714525466L].transform, false);
        goMap[4889091944770547114L].transform.SetParent(goMap[5648229339714525466L].transform, false);
        goMap[1148876562491958600L].transform.SetParent(goMap[5648229339714525466L].transform, false);
        goMap[1027480766279978888L].transform.SetParent(goMap[1148876562491958600L].transform, false);
        goMap[5086721155554862269L].transform.SetParent(goMap[5648229339714525466L].transform, false);
        goMap[-5049482167094195229L].transform.SetParent(goMap[5648229339714525466L].transform, false);
        goMap[7216413508561066453L].transform.SetParent(goMap[5648229339714525466L].transform, false);
        goMap[-7458168519803429543L].transform.SetParent(goMap[8712777727523364934L].transform, false);
        goMap[-2438854537872415752L].transform.SetParent(goMap[-7458168519803429543L].transform, false);
        goMap[5582497292106975530L].transform.SetParent(goMap[-7458168519803429543L].transform, false);
        goMap[8279123865888004365L].transform.SetParent(goMap[-7458168519803429543L].transform, false);
        goMap[4421475789809879540L].transform.SetParent(goMap[-7458168519803429543L].transform, false);
        goMap[-3763094828612211125L].transform.SetParent(goMap[-7458168519803429543L].transform, false);
        goMap[-364466541931465537L].transform.SetParent(goMap[-7458168519803429543L].transform, false);
        goMap[-8776497411219608732L].transform.SetParent(goMap[-7458168519803429543L].transform, false);
        goMap[-9145123460429036632L].transform.SetParent(goMap[-7458168519803429543L].transform, false);
        goMap[8989855467871328993L].transform.SetParent(goMap[8712777727523364934L].transform, false);
        goMap[3206901727795515479L].transform.SetParent(goMap[8989855467871328993L].transform, false);
        goMap[8742194208416047046L].transform.SetParent(goMap[8989855467871328993L].transform, false);
        goMap[-7942457896754736462L].transform.SetParent(goMap[8989855467871328993L].transform, false);
        goMap[5068226409393469632L].transform.SetParent(goMap[8989855467871328993L].transform, false);
        goMap[-739170741247203706L].transform.SetParent(goMap[8712777727523364934L].transform, false);
        goMap[6961527997050783052L].transform.SetParent(goMap[-739170741247203706L].transform, false);
        goMap[-2861859885438497723L].transform.SetParent(goMap[6961527997050783052L].transform, false);
        goMap[3964028590921840999L].transform.SetParent(goMap[-739170741247203706L].transform, false);
        goMap[773830895861647298L].transform.SetParent(goMap[-739170741247203706L].transform, false);
        goMap[-792638372989306488L].transform.SetParent(goMap[-739170741247203706L].transform, false);
        goMap[7668543168521929864L].transform.SetParent(goMap[-739170741247203706L].transform, false);
        goMap[-7126516005275752160L].transform.SetParent(goMap[8712777727523364934L].transform, false);
        goMap[2923282875364503165L].transform.SetParent(goMap[-7126516005275752160L].transform, false);
        goMap[4870152896775824161L].transform.SetParent(goMap[-7126516005275752160L].transform, false);
        goMap[-8793321486146728712L].transform.SetParent(goMap[-7126516005275752160L].transform, false);
        goMap[2612876831045535843L].transform.SetParent(goMap[-7126516005275752160L].transform, false);
        goMap[-7924306886857237679L].transform.SetParent(goMap[-7126516005275752160L].transform, false);
        goMap[2497631182656477890L].transform.SetParent(goMap[-7126516005275752160L].transform, false);
        goMap[886473408316856334L].transform.SetParent(goMap[-7126516005275752160L].transform, false);
        goMap[4773272331089030641L].transform.SetParent(goMap[-7126516005275752160L].transform, false);
        goMap[-5596553230426531367L].transform.SetParent(goMap[8712777727523364934L].transform, false);
        goMap[8198289488477102507L].transform.SetParent(goMap[-5596553230426531367L].transform, false);
        goMap[-2777418989571799142L].transform.SetParent(goMap[-5596553230426531367L].transform, false);
        goMap[2574938358674990763L].transform.SetParent(goMap[-5596553230426531367L].transform, false);
        goMap[2169758915888199572L].transform.SetParent(goMap[-5596553230426531367L].transform, false);

        // ─── RectTransforms ──────────────────────────────────
        {
            var rt = goMap[-6428595806602477281L].AddComponent<RectTransform>();
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
            var rt = goMap[-4532044079407381979L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 54.000000f);
            rt.sizeDelta = new Vector2(1660.000000f, 1076.000000f);
        }
        {
            var rt = goMap[7132010007907565446L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-4975886052411155216L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[8712777727523364934L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }

        // ─── Components ──────────────────────────────────────
        { var c = goMap[-6428595806602477281L].AddComponent<Canvas>();
           c.renderMode = (RenderMode)1;
           c.overrideSorting = false;
           c.sortingOrder = -1;
           c.sortingLayerID = unchecked((int)194136777);
           c.planeDistance = 100.000000f;
           c.pixelPerfect = false;
           c.additionalShaderChannels = (AdditionalCanvasShaderChannels)0;
           c.enabled = true;
        }
        { var c = goMap[-6428595806602477281L].AddComponent<CanvasScaler>();
           c.uiScaleMode = (CanvasScaler.ScaleMode)1;
           c.referenceResolution = new Vector2(1280.000000f, 720.000000f);
           c.screenMatchMode = (CanvasScaler.ScreenMatchMode)1;
           c.matchWidthOrHeight = 0.000000f;
           c.referencePixelsPerUnit = 100.000000f;
        }
        { var c = goMap[-6428595806602477281L].AddComponent<GraphicRaycaster>();
           c.ignoreReversedGraphics = true;
        }
        { var c = goMap[-4532044079407381979L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
        }
        { var c = goMap[-4975886052411155216L].AddComponent<Canvas>();
           c.renderMode = (RenderMode)2;
           c.overrideSorting = false;
           c.sortingOrder = 1;
           c.sortingLayerID = unchecked((int)194136777);
           c.planeDistance = 100.000000f;
           c.pixelPerfect = false;
           c.additionalShaderChannels = (AdditionalCanvasShaderChannels)0;
           c.enabled = true;
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
        var rootGO = goMap[-6428595806602477281L];
        string path = "Assets/Prefabs/Imported/UILoginBG.prefab";
        PrefabUtility.SaveAsPrefabAsset(rootGO, path);
        Object.DestroyImmediate(rootGO);
        Debug.Log("[Import_res_p_134] Saved " + path);
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