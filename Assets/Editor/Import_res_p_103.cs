// AUTO-GENERATED from res_p_103.ab — DO NOT EDIT MANUALLY.
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;
using System.Collections.Generic;

public class Import_res_p_103
{
    [MenuItem("KTO/Import/res_p_103")]
    public static void Build()
    {
        Debug.Log("[Import_res_p_103] Building UIHudRightCenter...");

        // ─── Create all GameObjects ───────────────────────────
        var goMap = new Dictionary<long, GameObject>();
        { var go = new GameObject("UIHudRightCenter"); go.SetActive(true); goMap[4740752404981931012L] = go; }
        { var go = new GameObject("imgBG"); go.SetActive(true); goMap[-3612170478515708554L] = go; }
        { var go = new GameObject("btnLeave"); go.SetActive(true); goMap[-372004621883432296L] = go; }
        { var go = new GameObject("Text"); go.SetActive(false); goMap[-367781027006762702L] = go; }
        { var go = new GameObject("btnAFuben"); go.SetActive(false); goMap[-2688408261270963586L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[6174306247436992690L] = go; }
        { var go = new GameObject("UIPlayerGuide"); go.SetActive(true); goMap[-8154440632916482533L] = go; }
        { var go = new GameObject("Guide"); go.SetActive(true); goMap[-2352809640098430279L] = go; }
        { var go = new GameObject("Name"); go.SetActive(true); goMap[-5027555563687232974L] = go; }
        { var go = new GameObject("Limite"); go.SetActive(true); goMap[-7984897084696327622L] = go; }
        { var go = new GameObject("UIPlayer_Effect"); go.SetActive(true); goMap[2265221337347077309L] = go; }
        { var go = new GameObject("Line"); go.SetActive(true); goMap[-4721905999471268042L] = go; }
        { var go = new GameObject("Light"); go.SetActive(true); goMap[-2987728139930575257L] = go; }
        { var go = new GameObject("Line02"); go.SetActive(true); goMap[-1686420075611327128L] = go; }
        { var go = new GameObject("btnStateSwitchCancel"); go.SetActive(false); goMap[6070025845665693198L] = go; }
        { var go = new GameObject("Text"); go.SetActive(false); goMap[4795611909881889244L] = go; }

        // ─── Parent links ─────────────────────────────────────
        goMap[-3612170478515708554L].transform.SetParent(goMap[4740752404981931012L].transform, false);
        goMap[-372004621883432296L].transform.SetParent(goMap[-3612170478515708554L].transform, false);
        goMap[-367781027006762702L].transform.SetParent(goMap[-372004621883432296L].transform, false);
        goMap[-2688408261270963586L].transform.SetParent(goMap[-3612170478515708554L].transform, false);
        goMap[6174306247436992690L].transform.SetParent(goMap[-2688408261270963586L].transform, false);
        goMap[-8154440632916482533L].transform.SetParent(goMap[-3612170478515708554L].transform, false);
        goMap[-2352809640098430279L].transform.SetParent(goMap[-8154440632916482533L].transform, false);
        goMap[-5027555563687232974L].transform.SetParent(goMap[-2352809640098430279L].transform, false);
        goMap[-7984897084696327622L].transform.SetParent(goMap[-2352809640098430279L].transform, false);
        goMap[2265221337347077309L].transform.SetParent(goMap[-8154440632916482533L].transform, false);
        goMap[-4721905999471268042L].transform.SetParent(goMap[2265221337347077309L].transform, false);
        goMap[-2987728139930575257L].transform.SetParent(goMap[2265221337347077309L].transform, false);
        goMap[-1686420075611327128L].transform.SetParent(goMap[2265221337347077309L].transform, false);
        goMap[6070025845665693198L].transform.SetParent(goMap[4740752404981931012L].transform, false);
        goMap[4795611909881889244L].transform.SetParent(goMap[6070025845665693198L].transform, false);

        // ─── RectTransforms ──────────────────────────────────
        {
            var rt = goMap[4740752404981931012L].AddComponent<RectTransform>();
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
            var rt = goMap[-3612170478515708554L].AddComponent<RectTransform>();
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
            var rt = goMap[-372004621883432296L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 1.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-236.700012f, -234.000000f);
            rt.sizeDelta = new Vector2(62.000000f, 62.000000f);
        }
        {
            var rt = goMap[-367781027006762702L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -23.000000f);
            rt.sizeDelta = new Vector2(59.000000f, 30.000000f);
        }
        {
            var rt = goMap[-2688408261270963586L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 1.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-336.000000f, -234.000061f);
            rt.sizeDelta = new Vector2(62.000000f, 62.000000f);
        }
        {
            var rt = goMap[6174306247436992690L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -20.000000f);
            rt.sizeDelta = new Vector2(80.000000f, 30.000000f);
        }
        {
            var rt = goMap[-8154440632916482533L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 1.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-98.000000f, -236.479996f);
            rt.sizeDelta = new Vector2(186.150024f, 66.000000f);
        }
        {
            var rt = goMap[-2352809640098430279L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(1.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(98.000000f, 4.400000f);
            rt.sizeDelta = new Vector2(176.992996f, 58.765900f);
        }
        {
            var rt = goMap[-5027555563687232974L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.351097f, 16.488199f);
            rt.sizeDelta = new Vector2(168.612000f, 32.000000f);
        }
        {
            var rt = goMap[-7984897084696327622L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.351486f, -15.200000f);
            rt.sizeDelta = new Vector2(168.610001f, 32.000000f);
        }
        {
            var rt = goMap[2265221337347077309L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.006156f, 0.935133f, 0.946970f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(5.600000f, 3.300000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-4721905999471268042L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.987500f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(3.600000f, 0.700000f);
            rt.sizeDelta = new Vector2(256.000000f, 128.000000f);
        }
        {
            var rt = goMap[-2987728139930575257L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(3.900000f, 0.000000f);
            rt.sizeDelta = new Vector2(256.000000f, 128.000000f);
        }
        {
            var rt = goMap[-1686420075611327128L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 0.991250f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(3.900000f, 0.000000f);
            rt.sizeDelta = new Vector2(256.000000f, 128.000000f);
        }
        {
            var rt = goMap[6070025845665693198L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 1.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-315.000000f, -312.000061f);
            rt.sizeDelta = new Vector2(58.000000f, 58.000000f);
        }
        {
            var rt = goMap[4795611909881889244L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -36.500019f);
            rt.sizeDelta = new Vector2(82.000000f, 30.000000f);
        }

        // ─── Components ──────────────────────────────────────
        { var c = goMap[4740752404981931012L].AddComponent<CanvasScaler>();
           c.uiScaleMode = (CanvasScaler.ScaleMode)1;
           c.referenceResolution = new Vector2(1280.000000f, 720.000000f);
           c.matchWidthOrHeight = 0.000000f;
           c.referencePixelsPerUnit = 100.000000f;
        }
        { var c = goMap[4740752404981931012L].AddComponent<GraphicRaycaster>();
           c.ignoreReversedGraphics = true;
        }
        { var c = goMap[-372004621883432296L].AddComponent<Image>();
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
           c.sprite = LookupSprite("btn_exit");
        }
        { var c = goMap[-372004621883432296L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-367781027006762702L].AddComponent<Text>();
           c.text = "离开";
           c.color = new Color(0.666667f, 0.811765f, 0.752941f, 1.000000f);
           c.fontSize = 16;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Overflow;
           c.lineSpacing = 0.500000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 1;
           c.resizeTextMaxSize = 40;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-367781027006762702L].AddComponent<Outline>();
           c.effectColor = new Color(0.047059f, 0.227451f, 0.239216f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-2688408261270963586L].AddComponent<Image>();
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
           c.sprite = LookupSprite("btn_plunder");
        }
        { var c = goMap[-2688408261270963586L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[6174306247436992690L].AddComponent<Text>();
           c.text = "99:99";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 1;
           c.resizeTextMaxSize = 40;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[6174306247436992690L].AddComponent<Outline>();
           c.effectColor = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-2352809640098430279L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
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
           c.sprite = LookupSprite("img_white");
        }
        { var c = goMap[-2352809640098430279L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-5027555563687232974L].AddComponent<Text>();
           c.text = "活动任务";
           c.color = new Color(0.988235f, 0.768627f, 0.176471f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.LowerCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 12;
           c.resizeTextMaxSize = 20;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-7984897084696327622L].AddComponent<Text>();
           c.text = "88:88";
           c.color = new Color(0.247059f, 0.831373f, 0.537255f, 1.000000f);
           c.fontSize = 24;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.UpperCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 12;
           c.resizeTextMaxSize = 24;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-4721905999471268042L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = false;
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
        { var c = goMap[-2987728139930575257L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = false;
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
        { var c = goMap[-1686420075611327128L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = false;
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
        { var c = goMap[6070025845665693198L].AddComponent<Image>();
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
           c.sprite = LookupSprite("btn_stateswitch_cancel");
        }
        { var c = goMap[6070025845665693198L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[4795611909881889244L].AddComponent<Text>();
           c.text = "1:45:08";
           c.color = new Color(0.666667f, 0.811765f, 0.752941f, 1.000000f);
           c.fontSize = 16;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Overflow;
           c.lineSpacing = 0.500000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 1;
           c.resizeTextMaxSize = 40;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_vi");
        }
        { var c = goMap[4795611909881889244L].AddComponent<Outline>();
           c.effectColor = new Color(0.047059f, 0.227451f, 0.239216f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }

        // ─── Save prefab ─────────────────────────────────────
        Directory.CreateDirectory("Assets/Prefabs/Imported");
        var rootGO = goMap[4740752404981931012L];
        string path = "Assets/Prefabs/Imported/UIHudRightCenter.prefab";
        PrefabUtility.SaveAsPrefabAsset(rootGO, path);
        Object.DestroyImmediate(rootGO);
        Debug.Log("[Import_res_p_103] Saved " + path);
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
}