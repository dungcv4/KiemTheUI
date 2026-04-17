// AUTO-GENERATED from res_p_296.ab — DO NOT EDIT MANUALLY.
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;
using System.Collections.Generic;
using KTO.Game;  // UIJoyStick and other ported KTO scripts

public class Import_res_p_296
{
    [MenuItem("KTO/Import/res_p_296")]
    public static void Build()
    {
        Debug.Log("[Import_res_p_296] Building VipIcon...");

        // ─── Create all GameObjects ───────────────────────────
        var goMap = new Dictionary<long, GameObject>();
        var _toggleGroupByMbPid = new Dictionary<long, ToggleGroup>();
        var _toggleGroupLinks = new List<System.Tuple<Toggle,long>>();
        { var go = new GameObject("VipIcon"); go.SetActive(true); goMap[-7840855338545917199L] = go; }
        { var go = new GameObject("Green"); go.SetActive(false); goMap[-1910006188388584394L] = go; }
        { var go = new GameObject("txtGreen"); go.SetActive(true); goMap[3359998972895615407L] = go; }
        { var go = new GameObject("UI_VipIcon_ef_green"); go.SetActive(true); goMap[8575882355271122300L] = go; }
        { var go = new GameObject("M1"); go.SetActive(true); goMap[5502079484869999164L] = go; }
        { var go = new GameObject("M2"); go.SetActive(true); goMap[-8652711320552276276L] = go; }
        { var go = new GameObject("P1"); go.SetActive(true); goMap[8468055666381875766L] = go; }
        { var go = new GameObject("Blue"); go.SetActive(false); goMap[-9173791783961269470L] = go; }
        { var go = new GameObject("txtBlue"); go.SetActive(true); goMap[-1972583633259458056L] = go; }
        { var go = new GameObject("UI_VipIcon_ef_Blue"); go.SetActive(true); goMap[-1956827318007907461L] = go; }
        { var go = new GameObject("P1"); go.SetActive(true); goMap[7032091008503034324L] = go; }
        { var go = new GameObject("M3"); go.SetActive(true); goMap[8260563958384732791L] = go; }
        { var go = new GameObject("M4"); go.SetActive(true); goMap[3003323436978326483L] = go; }
        { var go = new GameObject("Purple"); go.SetActive(false); goMap[2152351214500190808L] = go; }
        { var go = new GameObject("txtPurple"); go.SetActive(true); goMap[-4303368525566682699L] = go; }
        { var go = new GameObject("UI_VipIcon_ef_Purple"); go.SetActive(true); goMap[4285295795187001539L] = go; }
        { var go = new GameObject("P1"); go.SetActive(true); goMap[-6986930767114317106L] = go; }
        { var go = new GameObject("M5"); go.SetActive(true); goMap[-1690016171479432888L] = go; }
        { var go = new GameObject("M6"); go.SetActive(true); goMap[8860694301291076112L] = go; }
        { var go = new GameObject("Pink"); go.SetActive(false); goMap[9131176763793126282L] = go; }
        { var go = new GameObject("txtPink"); go.SetActive(true); goMap[-9054225355106097076L] = go; }
        { var go = new GameObject("UI_VipIcon_ef_Pink"); go.SetActive(true); goMap[4022781012413724897L] = go; }
        { var go = new GameObject("P1"); go.SetActive(true); goMap[8177941531834267163L] = go; }
        { var go = new GameObject("M7"); go.SetActive(true); goMap[1374934591203418893L] = go; }
        { var go = new GameObject("M8"); go.SetActive(true); goMap[-8658929600107949887L] = go; }
        { var go = new GameObject("Red"); go.SetActive(false); goMap[-1230060646759477545L] = go; }
        { var go = new GameObject("txtPink"); go.SetActive(true); goMap[-4453980855204593299L] = go; }
        { var go = new GameObject("UI_VipIcon_ef_Red"); go.SetActive(true); goMap[7009178949134835200L] = go; }
        { var go = new GameObject("P1"); go.SetActive(true); goMap[-1381797027863595840L] = go; }
        { var go = new GameObject("M9"); go.SetActive(true); goMap[-3400104956119011467L] = go; }
        { var go = new GameObject("M10"); go.SetActive(true); goMap[5770590085157759875L] = go; }
        { var go = new GameObject("Orange"); go.SetActive(true); goMap[7930915428129433320L] = go; }
        { var go = new GameObject("txtPink"); go.SetActive(true); goMap[-4178528242494009550L] = go; }
        { var go = new GameObject("UI_VipIcon_ef_Orange"); go.SetActive(true); goMap[6158211125895523323L] = go; }
        { var go = new GameObject("P1"); go.SetActive(true); goMap[-7628728721516246551L] = go; }
        { var go = new GameObject("M11"); go.SetActive(true); goMap[8777108067519765771L] = go; }
        { var go = new GameObject("M12"); go.SetActive(true); goMap[-7074227437206793681L] = go; }

        // ─── Parent links ─────────────────────────────────────
        goMap[-1910006188388584394L].transform.SetParent(goMap[-7840855338545917199L].transform, false);
        goMap[3359998972895615407L].transform.SetParent(goMap[-1910006188388584394L].transform, false);
        goMap[8575882355271122300L].transform.SetParent(goMap[3359998972895615407L].transform, false);
        goMap[5502079484869999164L].transform.SetParent(goMap[8575882355271122300L].transform, false);
        goMap[-8652711320552276276L].transform.SetParent(goMap[8575882355271122300L].transform, false);
        goMap[8468055666381875766L].transform.SetParent(goMap[8575882355271122300L].transform, false);
        goMap[-9173791783961269470L].transform.SetParent(goMap[-7840855338545917199L].transform, false);
        goMap[-1972583633259458056L].transform.SetParent(goMap[-9173791783961269470L].transform, false);
        goMap[-1956827318007907461L].transform.SetParent(goMap[-1972583633259458056L].transform, false);
        goMap[7032091008503034324L].transform.SetParent(goMap[-1956827318007907461L].transform, false);
        goMap[8260563958384732791L].transform.SetParent(goMap[-1956827318007907461L].transform, false);
        goMap[3003323436978326483L].transform.SetParent(goMap[-1956827318007907461L].transform, false);
        goMap[2152351214500190808L].transform.SetParent(goMap[-7840855338545917199L].transform, false);
        goMap[-4303368525566682699L].transform.SetParent(goMap[2152351214500190808L].transform, false);
        goMap[4285295795187001539L].transform.SetParent(goMap[2152351214500190808L].transform, false);
        goMap[-6986930767114317106L].transform.SetParent(goMap[4285295795187001539L].transform, false);
        goMap[-1690016171479432888L].transform.SetParent(goMap[4285295795187001539L].transform, false);
        goMap[8860694301291076112L].transform.SetParent(goMap[4285295795187001539L].transform, false);
        goMap[9131176763793126282L].transform.SetParent(goMap[-7840855338545917199L].transform, false);
        goMap[-9054225355106097076L].transform.SetParent(goMap[9131176763793126282L].transform, false);
        goMap[4022781012413724897L].transform.SetParent(goMap[9131176763793126282L].transform, false);
        goMap[8177941531834267163L].transform.SetParent(goMap[4022781012413724897L].transform, false);
        goMap[1374934591203418893L].transform.SetParent(goMap[4022781012413724897L].transform, false);
        goMap[-8658929600107949887L].transform.SetParent(goMap[4022781012413724897L].transform, false);
        goMap[-1230060646759477545L].transform.SetParent(goMap[-7840855338545917199L].transform, false);
        goMap[-4453980855204593299L].transform.SetParent(goMap[-1230060646759477545L].transform, false);
        goMap[7009178949134835200L].transform.SetParent(goMap[-1230060646759477545L].transform, false);
        goMap[-1381797027863595840L].transform.SetParent(goMap[7009178949134835200L].transform, false);
        goMap[-3400104956119011467L].transform.SetParent(goMap[7009178949134835200L].transform, false);
        goMap[5770590085157759875L].transform.SetParent(goMap[7009178949134835200L].transform, false);
        goMap[7930915428129433320L].transform.SetParent(goMap[-7840855338545917199L].transform, false);
        goMap[-4178528242494009550L].transform.SetParent(goMap[7930915428129433320L].transform, false);
        goMap[6158211125895523323L].transform.SetParent(goMap[7930915428129433320L].transform, false);
        goMap[-7628728721516246551L].transform.SetParent(goMap[6158211125895523323L].transform, false);
        goMap[8777108067519765771L].transform.SetParent(goMap[6158211125895523323L].transform, false);
        goMap[-7074227437206793681L].transform.SetParent(goMap[6158211125895523323L].transform, false);

        // ─── RectTransforms ──────────────────────────────────
        {
            var rt = goMap[-7840855338545917199L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.500000f);
            rt.anchorMax = new Vector2(1.000000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(16.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(36.000000f, 36.000000f);
        }
        {
            var rt = goMap[-1910006188388584394L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(36.000000f, 36.000000f);
        }
        {
            var rt = goMap[3359998972895615407L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(50.000000f, 50.000000f);
        }
        {
            var rt = goMap[-9173791783961269470L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(36.000000f, 36.000000f);
        }
        {
            var rt = goMap[-1972583633259458056L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(50.000000f, 50.000000f);
        }
        {
            var rt = goMap[2152351214500190808L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(36.000000f, 36.000000f);
        }
        {
            var rt = goMap[-4303368525566682699L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(50.000000f, 50.000000f);
        }
        {
            var rt = goMap[9131176763793126282L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(36.000000f, 36.000000f);
        }
        {
            var rt = goMap[-9054225355106097076L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(50.000000f, 50.000000f);
        }
        {
            var rt = goMap[-1230060646759477545L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(36.000000f, 36.000000f);
        }
        {
            var rt = goMap[-4453980855204593299L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(50.000000f, 50.000000f);
        }
        {
            var rt = goMap[7930915428129433320L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(36.000000f, 36.000000f);
        }
        {
            var rt = goMap[-4178528242494009550L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(50.000000f, 50.000000f);
        }

        // ─── Components ──────────────────────────────────────
        { var c = goMap[3359998972895615407L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 32;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 40;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var g = goMap[3359998972895615407L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f); }
        { var c = goMap[3359998972895615407L].AddComponent<Outline>();
           c.effectColor = new Color(0.352941f, 0.615686f, 0.643137f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[8575882355271122300L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("UI_VipIcon_ef_green"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[-1972583633259458056L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 32;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 40;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var g = goMap[-1972583633259458056L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f); }
        { var c = goMap[-1972583633259458056L].AddComponent<Outline>();
           c.effectColor = new Color(0.376471f, 0.603922f, 0.905882f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-1956827318007907461L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("UI_VipIcon_ef_Blue"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[-4303368525566682699L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 32;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 40;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var g = goMap[-4303368525566682699L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.850980f, 0.862745f, 0.949020f, 1.000000f); }
        { var c = goMap[-4303368525566682699L].AddComponent<Outline>();
           c.effectColor = new Color(0.239216f, 0.247059f, 0.552941f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[4285295795187001539L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("UI_VipIcon_ef_Purple"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[-9054225355106097076L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 32;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 40;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var g = goMap[-9054225355106097076L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.850980f, 0.862745f, 0.949020f, 1.000000f); }
        { var c = goMap[-9054225355106097076L].AddComponent<Outline>();
           c.effectColor = new Color(0.682353f, 0.298039f, 0.917647f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[4022781012413724897L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("UI_VipIcon_ef_Pink"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[-4453980855204593299L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 32;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 40;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var g = goMap[-4453980855204593299L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.850980f, 0.862745f, 0.949020f, 1.000000f); }
        { var c = goMap[-4453980855204593299L].AddComponent<Outline>();
           c.effectColor = new Color(0.811765f, 0.294118f, 0.290196f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[7009178949134835200L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("UI_VipIcon_ef_Red"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[-4178528242494009550L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 32;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 40;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var g = goMap[-4178528242494009550L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.850980f, 0.862745f, 0.949020f, 1.000000f); }
        { var c = goMap[-4178528242494009550L].AddComponent<Outline>();
           c.effectColor = new Color(0.921569f, 0.403922f, 0.290196f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[6158211125895523323L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("UI_VipIcon_ef_Orange"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
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
        var rootGO = goMap[-7840855338545917199L];
        string path = "Assets/Prefabs/Imported/VipIcon.prefab";
        PrefabUtility.SaveAsPrefabAsset(rootGO, path);
        Object.DestroyImmediate(rootGO);
        Debug.Log("[Import_res_p_296] Saved " + path);
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