// AUTO-GENERATED from res_p_193.ab — DO NOT EDIT MANUALLY.
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;
using System.Collections.Generic;
using System.Reflection;
using I2.Loc;

public class Import_res_p_193
{
    [MenuItem("KTO/Import/res_p_193")]
    public static void Build()
    {
        Debug.Log("[Import_res_p_193] Building UISelectZone...");

        // ─── Create all GameObjects ───────────────────────────
        var goMap = new Dictionary<long, GameObject>();
        { var go = new GameObject("UISelectZone"); go.SetActive(true); goMap[-5871931771484844951L] = go; }
        { var go = new GameObject("imgBG"); go.SetActive(true); goMap[-4799703686976770574L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[4371586482863360148L] = go; }
        { var go = new GameObject("UIBg3"); go.SetActive(false); goMap[-7504005409842391922L] = go; }
        { var go = new GameObject("panel"); go.SetActive(true); goMap[-4940509516477043086L] = go; }
        { var go = new GameObject("imgShadow1"); go.SetActive(true); goMap[-170243392381871571L] = go; }
        { var go = new GameObject("imgShadow2"); go.SetActive(true); goMap[4117569312536960919L] = go; }
        { var go = new GameObject("imgShadow3"); go.SetActive(true); goMap[7860825332416815273L] = go; }
        { var go = new GameObject("imgShadow4"); go.SetActive(true); goMap[7659286772093612149L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(true); goMap[-9122957880656130604L] = go; }
        { var go = new GameObject("imgTitleBg1"); go.SetActive(true); goMap[-4600633056373996077L] = go; }
        { var go = new GameObject("imgReflection"); go.SetActive(true); goMap[-3151685931114620077L] = go; }
        { var go = new GameObject("imgBorderline1"); go.SetActive(true); goMap[6579470481279091951L] = go; }
        { var go = new GameObject("imgBorderline2"); go.SetActive(true); goMap[8530817921308131868L] = go; }
        { var go = new GameObject("imgBorderline3"); go.SetActive(true); goMap[-3804706781183679082L] = go; }
        { var go = new GameObject("imgBorderline4"); go.SetActive(true); goMap[-2224184043147170277L] = go; }
        { var go = new GameObject("imgListBg"); go.SetActive(false); goMap[-8847029234033198742L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(false); goMap[1247982087964105237L] = go; }
        { var go = new GameObject("txtTitle"); go.SetActive(true); goMap[1560245240313044642L] = go; }
        { var go = new GameObject("ZoneList"); go.SetActive(true); goMap[-7367716707964655702L] = go; }
        { var go = new GameObject("ZoneList"); go.SetActive(true); goMap[-6859170668582792341L] = go; }
        { var go = new GameObject("btnTemplate"); go.SetActive(true); goMap[3429162066399358494L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[524757226992543170L] = go; }

        // ─── Parent links ─────────────────────────────────────
        goMap[-4799703686976770574L].transform.SetParent(goMap[-5871931771484844951L].transform, false);
        goMap[4371586482863360148L].transform.SetParent(goMap[-4799703686976770574L].transform, false);
        goMap[-7504005409842391922L].transform.SetParent(goMap[-4799703686976770574L].transform, false);
        goMap[-4940509516477043086L].transform.SetParent(goMap[-7504005409842391922L].transform, false);
        goMap[-170243392381871571L].transform.SetParent(goMap[-4940509516477043086L].transform, false);
        goMap[4117569312536960919L].transform.SetParent(goMap[-4940509516477043086L].transform, false);
        goMap[7860825332416815273L].transform.SetParent(goMap[-4940509516477043086L].transform, false);
        goMap[7659286772093612149L].transform.SetParent(goMap[-4940509516477043086L].transform, false);
        goMap[-9122957880656130604L].transform.SetParent(goMap[-4940509516477043086L].transform, false);
        goMap[-4600633056373996077L].transform.SetParent(goMap[-4940509516477043086L].transform, false);
        goMap[-3151685931114620077L].transform.SetParent(goMap[-4940509516477043086L].transform, false);
        goMap[6579470481279091951L].transform.SetParent(goMap[-4940509516477043086L].transform, false);
        goMap[8530817921308131868L].transform.SetParent(goMap[-4940509516477043086L].transform, false);
        goMap[-3804706781183679082L].transform.SetParent(goMap[-4940509516477043086L].transform, false);
        goMap[-2224184043147170277L].transform.SetParent(goMap[-4940509516477043086L].transform, false);
        goMap[-8847029234033198742L].transform.SetParent(goMap[-4940509516477043086L].transform, false);
        goMap[1247982087964105237L].transform.SetParent(goMap[-7504005409842391922L].transform, false);
        goMap[1560245240313044642L].transform.SetParent(goMap[-4799703686976770574L].transform, false);
        goMap[-7367716707964655702L].transform.SetParent(goMap[-4799703686976770574L].transform, false);
        goMap[-6859170668582792341L].transform.SetParent(goMap[-7367716707964655702L].transform, false);
        goMap[3429162066399358494L].transform.SetParent(goMap[-6859170668582792341L].transform, false);
        goMap[524757226992543170L].transform.SetParent(goMap[3429162066399358494L].transform, false);

        // ─── Transforms ──────────────────────────────────────
        {
            var rt = goMap[-5871931771484844951L].AddComponent<RectTransform>();
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
            var rt = goMap[-4799703686976770574L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(500.000000f, 600.000000f);
        }
        {
            var rt = goMap[4371586482863360148L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.922220f, 1.149300f);
            rt.sizeDelta = new Vector2(441.170013f, 549.789612f);
        }
        {
            var rt = goMap[-7504005409842391922L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(1280.000000f, 720.000000f);
        }
        {
            var rt = goMap[-4940509516477043086L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(520.000000f, 590.000000f);
        }
        {
            var rt = goMap[-170243392381871571L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(92.265869f, -28.225800f);
            rt.sizeDelta = new Vector2(794.789612f, 535.951721f);
        }
        {
            var rt = goMap[4117569312536960919L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,0.707107f,0.707107f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(41.204987f, 267.971924f);
            rt.sizeDelta = new Vector2(56.273499f, 900.626404f);
        }
        {
            var rt = goMap[7860825332416815273L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,0.707107f,-0.707107f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-398.330383f, -61.885902f);
            rt.sizeDelta = new Vector2(465.339386f, 186.519394f);
        }
        {
            var rt = goMap[7659286772093612149L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,1.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-449.368256f, 234.379395f);
            rt.sizeDelta = new Vector2(80.440399f, 127.180298f);
        }
        {
            var rt = goMap[-9122957880656130604L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.297000f, -1.636200f);
            rt.sizeDelta = new Vector2(970.690979f, 575.252075f);
        }
        {
            var rt = goMap[-4600633056373996077L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.296330f, 257.673065f);
            rt.sizeDelta = new Vector2(970.690002f, 70.000000f);
        }
        {
            var rt = goMap[-3151685931114620077L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.184500f, 289.500000f);
            rt.sizeDelta = new Vector2(956.659302f, 1.000000f);
        }
        {
            var rt = goMap[6579470481279091951L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(127.456543f, -81.689148f);
            rt.sizeDelta = new Vector2(720.547913f, 421.480286f);
        }
        {
            var rt = goMap[8530817921308131868L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,0.707107f,0.707107f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(200.265884f, 211.729797f);
            rt.sizeDelta = new Vector2(165.355606f, 574.942078f);
        }
        {
            var rt = goMap[-3804706781183679082L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,0.707107f,-0.707107f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-360.062012f, -68.276260f);
            rt.sizeDelta = new Vector2(448.305389f, 254.488998f);
        }
        {
            var rt = goMap[-2224184043147170277L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,1.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-287.255005f, 225.144531f);
            rt.sizeDelta = new Vector2(400.103912f, 138.536407f);
        }
        {
            var rt = goMap[-8847029234033198742L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.627900f, -43.241535f);
            rt.sizeDelta = new Vector2(936.000000f, 454.892090f);
        }
        {
            var rt = goMap[1247982087964105237L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(850.000000f, 540.000000f);
        }
        {
            var rt = goMap[1560245240313044642L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(0.000000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(208.399994f, 253.199997f);
            rt.sizeDelta = new Vector2(350.000000f, 100.000000f);
        }
        {
            var rt = goMap[-7367716707964655702L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(1.000000f, -18.077417f);
            rt.sizeDelta = new Vector2(450.000000f, 460.845215f);
        }
        {
            var rt = goMap[-6859170668582792341L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 1.000000f);
            rt.anchorMax = new Vector2(0.500000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 1.000000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(450.000000f, 0.000000f);
        }
        {
            var rt = goMap[3429162066399358494L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }
        {
            var rt = goMap[524757226992543170L].AddComponent<RectTransform>();
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
        { var c = goMap[-5871931771484844951L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.000000f, 0.000000f, 0.705882f);
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
        { var c = goMap[-5871931771484844951L].AddComponent<CanvasScaler>();
           c.uiScaleMode = (CanvasScaler.ScaleMode)1;
           c.referenceResolution = new Vector2(1280.000000f, 720.000000f);
           c.matchWidthOrHeight = 0.000000f;
           c.referencePixelsPerUnit = 100.000000f;
        }
        { var c = goMap[-5871931771484844951L].AddComponent<GraphicRaycaster>();
           c.ignoreReversedGraphics = true;
        }
        { var c = goMap[-5871931771484844951L].AddComponent<UIView>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"m_luaClassName", "UISelectZone"}});
        }
        { var c = goMap[4371586482863360148L].AddComponent<Image>();
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
        { var c = goMap[-170243392381871571L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Sliced;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_background_shadow");
        }
        { var c = goMap[4117569312536960919L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Sliced;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_background_shadow");
        }
        { var c = goMap[7860825332416815273L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Sliced;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_background_shadow");
        }
        { var c = goMap[7659286772093612149L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Sliced;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_background_shadow");
        }
        { var c = goMap[-9122957880656130604L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Sliced;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_background_bg");
        }
        { var c = goMap[-4600633056373996077L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_background_titlebg3");
        }
        { var c = goMap[-3151685931114620077L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.196078f);
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
        { var c = goMap[6579470481279091951L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Sliced;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_background_borderline");
        }
        { var c = goMap[8530817921308131868L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Sliced;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_background_borderline");
        }
        { var c = goMap[-3804706781183679082L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Sliced;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_background_borderline");
        }
        { var c = goMap[-2224184043147170277L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Sliced;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_background_borderline");
        }
        { var c = goMap[-8847029234033198742L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_listbg2");
        }
        { var c = goMap[1247982087964105237L].AddComponent<Image>();
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
           c.sprite = LookupSprite("test_bg1");
        }
        { var c = goMap[1560245240313044642L].AddComponent<Text>();
           c.text = "大区";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 42;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleLeft;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 0;
           c.resizeTextMaxSize = 42;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("hysz");
        }
        { var c = goMap[1560245240313044642L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "15260"},{"mTermSecondary", "hysz"},{"PrimaryTermModifier", 0},{"SecondaryTermModifier", 0},{"TermPrefix", ""},{"TermSuffix", ""},{"LocalizeOnAwake", 1},{"IgnoreRTL", 0},{"MaxCharactersInRTL", 0},{"IgnoreNumbersInRTL", 1},{"CorrectAlignmentForRTL", 1},{"AddSpacesToJoinedLanguages", 0},{"AllowLocalizedParameters", 1},{"AllowParameters", 1},{"AlwaysForceLocalize", 0},{"mGUI_ShowReferences", 0},{"mGUI_ShowTems", 1},{"mGUI_ShowCallback", 0},{"mLocalizeTargetName", "I2.Loc.LocalizeTarget_UnityUI_Text"}});
        }
        { var c = goMap[-7367716707964655702L].AddComponent<RectMask2D>();
           c.enabled = true;
        }
        { var c = goMap[-6859170668582792341L].AddComponent<GridLayoutGroup>();
           c.cellSize = new Vector2(380.000000f, 70.000000f);
           c.spacing = new Vector2(30.000000f, 8.000000f);
        }
        { var c = goMap[-6859170668582792341L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)0;
           c.verticalFit = (ContentSizeFitter.FitMode)2;
        }
        { var c = goMap[3429162066399358494L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Sliced;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("btn_tap5_1");
        }
        { var c = goMap[3429162066399358494L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[524757226992543170L].AddComponent<Text>();
           c.text = "大区127.127.127.127";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 22;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = true;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 0;
           c.resizeTextMaxSize = 159;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[524757226992543170L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "16086"},{"mTermSecondary", "common_zh"},{"PrimaryTermModifier", 0},{"SecondaryTermModifier", 0},{"TermPrefix", ""},{"TermSuffix", ""},{"LocalizeOnAwake", 1},{"IgnoreRTL", 0},{"MaxCharactersInRTL", 0},{"IgnoreNumbersInRTL", 1},{"CorrectAlignmentForRTL", 1},{"AddSpacesToJoinedLanguages", 0},{"AllowLocalizedParameters", 1},{"AllowParameters", 1},{"AlwaysForceLocalize", 0},{"mGUI_ShowReferences", 0},{"mGUI_ShowTems", 1},{"mGUI_ShowCallback", 0},{"mLocalizeTargetName", "I2.Loc.LocalizeTarget_UnityUI_Text"}});
        }

        // ─── Save prefab ─────────────────────────────────────
        Directory.CreateDirectory("Assets/Prefabs/Imported");
        var rootGO = goMap[-5871931771484844951L];
        string path = "Assets/Prefabs/Imported/UISelectZone.prefab";
        PrefabUtility.SaveAsPrefabAsset(rootGO, path);
        Object.DestroyImmediate(rootGO);
        Debug.Log("[Import_res_p_193] Saved " + path);
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

    static Sprite _builtinUISprite;
    static Sprite LookupBuiltinUISprite()
    {
        if (_builtinUISprite == null)
            _builtinUISprite = AssetDatabase.GetBuiltinExtraResource<Sprite>("UI/Skin/UISprite.psd");
        if (_builtinUISprite == null)
            _builtinUISprite = Resources.GetBuiltinResource<Sprite>("UI/Skin/UISprite.psd");
        return _builtinUISprite;
    }

    static Dictionary<string, Material> _matCache;
    static Material LookupMaterial(string name)
    {
        if (_matCache == null)
        {
            _matCache = new Dictionary<string, Material>();
            var guids = AssetDatabase.FindAssets("t:Material", new[] { "Assets/game", "Assets/Sprite", "Assets/Material" });
            foreach (var g in guids)
            {
                var p = AssetDatabase.GUIDToAssetPath(g);
                var m = AssetDatabase.LoadAssetAtPath<Material>(p);
                if (m == null) continue;
                if (!_matCache.ContainsKey(m.name)) _matCache[m.name] = m;
            }
            Debug.Log($"[Material cache] {_matCache.Count} materials");
        }
        Material r;
        return _matCache.TryGetValue(name, out r) ? r : null;
    }

    static void ApplyFields(Component comp, Dictionary<string, object> fields)
    {
        if (comp == null || fields == null) return;
        var t = comp.GetType();
        var flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.FlattenHierarchy;
        foreach (var kv in fields)
        {
            var f = t.GetField(kv.Key, flags);
            if (f == null) continue;
            try {
                object val = kv.Value;
                if (val == null) continue;
                // Coerce common numeric types
                if (f.FieldType == typeof(float) && val is int iv) val = (float)iv;
                else if (f.FieldType == typeof(int) && val is float fv) val = (int)fv;
                else if (f.FieldType == typeof(bool) && val is int ibv) val = ibv != 0;
                else if (f.FieldType == typeof(byte) && val is int byv) val = (byte)byv;
                f.SetValue(comp, val);
            } catch (System.Exception e) {
                Debug.LogWarning($"[ApplyFields] {t.Name}.{kv.Key}: {e.Message}");
            }
        }
    }

    static Dictionary<string, RuntimeAnimatorController> _ctrlCache;
    static RuntimeAnimatorController LookupAnimatorController(string name)
    {
        if (_ctrlCache == null)
        {
            _ctrlCache = new Dictionary<string, RuntimeAnimatorController>();
            var guids = AssetDatabase.FindAssets("t:AnimatorController", new[] { "Assets/game" });
            foreach (var g in guids)
            {
                var p = AssetDatabase.GUIDToAssetPath(g);
                var c = AssetDatabase.LoadAssetAtPath<RuntimeAnimatorController>(p);
                if (c == null) continue;
                if (!_ctrlCache.ContainsKey(c.name)) _ctrlCache[c.name] = c;
            }
            Debug.Log($"[AnimatorController cache] {_ctrlCache.Count} controllers");
        }
        RuntimeAnimatorController r;
        return _ctrlCache.TryGetValue(name, out r) ? r : null;
    }
}