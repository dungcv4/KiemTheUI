// AUTO-GENERATED from res_p_272.ab — DO NOT EDIT MANUALLY.
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;
using System.Collections.Generic;
using KTO.Game;  // UIJoyStick and other ported KTO scripts

public class Import_res_p_272
{
    [MenuItem("KTO/Import/res_p_272")]
    public static void Build()
    {
        Debug.Log("[Import_res_p_272] Building UIPlayerModifyName...");

        // ─── Create all GameObjects ───────────────────────────
        var goMap = new Dictionary<long, GameObject>();
        var _toggleGroupByMbPid = new Dictionary<long, ToggleGroup>();
        var _toggleGroupLinks = new List<System.Tuple<Toggle,long>>();
        { var go = new GameObject("UIPlayerModifyName"); go.SetActive(true); goMap[-3623994943746630329L] = go; }
        { var go = new GameObject("node"); go.SetActive(true); goMap[6031055840130034009L] = go; }
        { var go = new GameObject("UIBg4"); go.SetActive(true); goMap[-8258622997474017852L] = go; }
        { var go = new GameObject("panel"); go.SetActive(true); goMap[3042562883496624711L] = go; }
        { var go = new GameObject("imgShadow1"); go.SetActive(true); goMap[-6067311128197125518L] = go; }
        { var go = new GameObject("imgShadow2"); go.SetActive(true); goMap[8711237197878453815L] = go; }
        { var go = new GameObject("imgShadow3"); go.SetActive(true); goMap[-2854667702866034163L] = go; }
        { var go = new GameObject("imgShadow4"); go.SetActive(true); goMap[-4787992541033925063L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(true); goMap[-7067929919516144730L] = go; }
        { var go = new GameObject("imgTitleBg1"); go.SetActive(true); goMap[2228277152806480663L] = go; }
        { var go = new GameObject("imgReflection"); go.SetActive(true); goMap[1914003000572325534L] = go; }
        { var go = new GameObject("imgBorderline1"); go.SetActive(true); goMap[2111397292902958186L] = go; }
        { var go = new GameObject("imgBorderline2"); go.SetActive(true); goMap[9146758433963347705L] = go; }
        { var go = new GameObject("imgBorderline3"); go.SetActive(true); goMap[7287860685170429272L] = go; }
        { var go = new GameObject("imgBorderline4"); go.SetActive(true); goMap[-5943010861625126351L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(false); goMap[1116456610283000694L] = go; }
        { var go = new GameObject("imgBG"); go.SetActive(true); goMap[-447940242590424607L] = go; }
        { var go = new GameObject("btnClose"); go.SetActive(true); goMap[-1097320286975747148L] = go; }
        { var go = new GameObject("txtTitle"); go.SetActive(true); goMap[-866727569713308659L] = go; }
        { var go = new GameObject("btnHelp"); go.SetActive(true); goMap[8901681535328524089L] = go; }
        { var go = new GameObject("Content"); go.SetActive(true); goMap[2198664134873810414L] = go; }
        { var go = new GameObject("PortraitObj"); go.SetActive(true); goMap[-2878231624896232247L] = go; }
        { var go = new GameObject("PortraitBg"); go.SetActive(true); goMap[3119587059341281389L] = go; }
        { var go = new GameObject("Portrait"); go.SetActive(true); goMap[-5119646303807181167L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[2332742321008256173L] = go; }
        { var go = new GameObject("OutlineObj"); go.SetActive(false); goMap[-5768738703989094470L] = go; }
        { var go = new GameObject("imgOutlineBG"); go.SetActive(true); goMap[8293203503950599828L] = go; }
        { var go = new GameObject("txtOutline"); go.SetActive(true); goMap[7766555810418696440L] = go; }
        { var go = new GameObject("PortraitFrame"); go.SetActive(false); goMap[5744706740004535233L] = go; }
        { var go = new GameObject("Level"); go.SetActive(false); goMap[-3707775245594182718L] = go; }
        { var go = new GameObject("imgLvBg"); go.SetActive(true); goMap[-9160406135973828590L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[8987510532917230767L] = go; }
        { var go = new GameObject("TextMaster"); go.SetActive(false); goMap[6811288906427153145L] = go; }
        { var go = new GameObject("imgFactionIcon"); go.SetActive(true); goMap[7241596957681497151L] = go; }
        { var go = new GameObject("txtCurrentName"); go.SetActive(true); goMap[-2769106959679195560L] = go; }
        { var go = new GameObject("inputNewName"); go.SetActive(true); goMap[-8360592351981907993L] = go; }
        { var go = new GameObject("Placeholder"); go.SetActive(true); goMap[-7987549426346481829L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-7492758340124757421L] = go; }
        { var go = new GameObject("txtFree"); go.SetActive(false); goMap[2254065474437011172L] = go; }
        { var go = new GameObject("Cost"); go.SetActive(true); goMap[-6299632750225968713L] = go; }
        { var go = new GameObject("imgJinbi"); go.SetActive(true); goMap[7771892294044945934L] = go; }
        { var go = new GameObject("txtCostNum"); go.SetActive(true); goMap[-704601450880528412L] = go; }
        { var go = new GameObject("txtCostTip"); go.SetActive(true); goMap[-7494357728535919550L] = go; }
        { var go = new GameObject("btnSave"); go.SetActive(true); goMap[1408658395710885033L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[7673535765961410515L] = go; }

        // ─── Parent links ─────────────────────────────────────
        goMap[6031055840130034009L].transform.SetParent(goMap[-3623994943746630329L].transform, false);
        goMap[-8258622997474017852L].transform.SetParent(goMap[6031055840130034009L].transform, false);
        goMap[3042562883496624711L].transform.SetParent(goMap[-8258622997474017852L].transform, false);
        goMap[-6067311128197125518L].transform.SetParent(goMap[3042562883496624711L].transform, false);
        goMap[8711237197878453815L].transform.SetParent(goMap[3042562883496624711L].transform, false);
        goMap[-2854667702866034163L].transform.SetParent(goMap[3042562883496624711L].transform, false);
        goMap[-4787992541033925063L].transform.SetParent(goMap[3042562883496624711L].transform, false);
        goMap[-7067929919516144730L].transform.SetParent(goMap[3042562883496624711L].transform, false);
        goMap[2228277152806480663L].transform.SetParent(goMap[3042562883496624711L].transform, false);
        goMap[1914003000572325534L].transform.SetParent(goMap[3042562883496624711L].transform, false);
        goMap[2111397292902958186L].transform.SetParent(goMap[3042562883496624711L].transform, false);
        goMap[9146758433963347705L].transform.SetParent(goMap[3042562883496624711L].transform, false);
        goMap[7287860685170429272L].transform.SetParent(goMap[3042562883496624711L].transform, false);
        goMap[-5943010861625126351L].transform.SetParent(goMap[3042562883496624711L].transform, false);
        goMap[1116456610283000694L].transform.SetParent(goMap[-8258622997474017852L].transform, false);
        goMap[-447940242590424607L].transform.SetParent(goMap[6031055840130034009L].transform, false);
        goMap[-1097320286975747148L].transform.SetParent(goMap[-447940242590424607L].transform, false);
        goMap[-866727569713308659L].transform.SetParent(goMap[-447940242590424607L].transform, false);
        goMap[8901681535328524089L].transform.SetParent(goMap[-866727569713308659L].transform, false);
        goMap[2198664134873810414L].transform.SetParent(goMap[-447940242590424607L].transform, false);
        goMap[-2878231624896232247L].transform.SetParent(goMap[2198664134873810414L].transform, false);
        goMap[3119587059341281389L].transform.SetParent(goMap[-2878231624896232247L].transform, false);
        goMap[-5119646303807181167L].transform.SetParent(goMap[-2878231624896232247L].transform, false);
        goMap[2332742321008256173L].transform.SetParent(goMap[-5119646303807181167L].transform, false);
        goMap[-5768738703989094470L].transform.SetParent(goMap[2332742321008256173L].transform, false);
        goMap[8293203503950599828L].transform.SetParent(goMap[-5768738703989094470L].transform, false);
        goMap[7766555810418696440L].transform.SetParent(goMap[-5768738703989094470L].transform, false);
        goMap[5744706740004535233L].transform.SetParent(goMap[-2878231624896232247L].transform, false);
        goMap[-3707775245594182718L].transform.SetParent(goMap[-2878231624896232247L].transform, false);
        goMap[-9160406135973828590L].transform.SetParent(goMap[-3707775245594182718L].transform, false);
        goMap[8987510532917230767L].transform.SetParent(goMap[-3707775245594182718L].transform, false);
        goMap[6811288906427153145L].transform.SetParent(goMap[-3707775245594182718L].transform, false);
        goMap[7241596957681497151L].transform.SetParent(goMap[-2878231624896232247L].transform, false);
        goMap[-2769106959679195560L].transform.SetParent(goMap[2198664134873810414L].transform, false);
        goMap[-8360592351981907993L].transform.SetParent(goMap[2198664134873810414L].transform, false);
        goMap[-7987549426346481829L].transform.SetParent(goMap[-8360592351981907993L].transform, false);
        goMap[-7492758340124757421L].transform.SetParent(goMap[-8360592351981907993L].transform, false);
        goMap[2254065474437011172L].transform.SetParent(goMap[2198664134873810414L].transform, false);
        goMap[-6299632750225968713L].transform.SetParent(goMap[2198664134873810414L].transform, false);
        goMap[7771892294044945934L].transform.SetParent(goMap[-6299632750225968713L].transform, false);
        goMap[-704601450880528412L].transform.SetParent(goMap[-6299632750225968713L].transform, false);
        goMap[-7494357728535919550L].transform.SetParent(goMap[-6299632750225968713L].transform, false);
        goMap[1408658395710885033L].transform.SetParent(goMap[2198664134873810414L].transform, false);
        goMap[7673535765961410515L].transform.SetParent(goMap[1408658395710885033L].transform, false);

        // ─── RectTransforms ──────────────────────────────────
        {
            var rt = goMap[-3623994943746630329L].AddComponent<RectTransform>();
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
            var rt = goMap[6031055840130034009L].AddComponent<RectTransform>();
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
            var rt = goMap[-8258622997474017852L].AddComponent<RectTransform>();
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
            var rt = goMap[3042562883496624711L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(600.000000f, 400.000000f);
        }
        {
            var rt = goMap[-6067311128197125518L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(124.599998f, -71.300003f);
            rt.sizeDelta = new Vector2(353.700012f, 260.500000f);
        }
        {
            var rt = goMap[8711237197878453815L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,0.707107f,0.707107f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(86.400002f, 129.699997f);
            rt.sizeDelta = new Vector2(141.399994f, 434.000000f);
        }
        {
            var rt = goMap[-2854667702866034163L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,0.707107f,-0.707107f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-177.000000f, -76.599998f);
            rt.sizeDelta = new Vector2(247.300003f, 250.300003f);
        }
        {
            var rt = goMap[-4787992541033925063L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,1.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-216.000000f, 125.000000f);
            rt.sizeDelta = new Vector2(171.000000f, 155.300003f);
        }
        {
            var rt = goMap[-7067929919516144730L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -21.799999f);
            rt.sizeDelta = new Vector2(593.599976f, 345.799988f);
        }
        {
            var rt = goMap[2228277152806480663L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 165.699997f);
            rt.sizeDelta = new Vector2(592.000000f, 60.000000f);
        }
        {
            var rt = goMap[1914003000572325534L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.800000f, 192.800003f);
            rt.sizeDelta = new Vector2(576.700012f, 1.000000f);
        }
        {
            var rt = goMap[2111397292902958186L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(83.000000f, -45.099998f);
            rt.sizeDelta = new Vector2(432.000000f, 305.600006f);
        }
        {
            var rt = goMap[9146758433963347705L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,0.707107f,0.707107f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(84.199997f, 153.000000f);
            rt.sizeDelta = new Vector2(90.699997f, 429.600006f);
        }
        {
            var rt = goMap[7287860685170429272L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,0.707107f,-0.707107f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-216.000000f, -38.000000f);
            rt.sizeDelta = new Vector2(319.000000f, 166.399994f);
        }
        {
            var rt = goMap[-5943010861625126351L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,1.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-215.000000f, 160.000000f);
            rt.sizeDelta = new Vector2(168.699997f, 77.300003f);
        }
        {
            var rt = goMap[1116456610283000694L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(600.000000f, 400.000000f);
        }
        {
            var rt = goMap[-447940242590424607L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(600.000000f, 400.000000f);
        }
        {
            var rt = goMap[-1097320286975747148L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 1.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-29.299999f, -33.000000f);
            rt.sizeDelta = new Vector2(49.000000f, 54.000000f);
        }
        {
            var rt = goMap[-866727569713308659L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-279.999969f, 170.000000f);
            rt.sizeDelta = new Vector2(69.648903f, 50.000000f);
        }
        {
            var rt = goMap[8901681535328524089L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(0.800000f, 0.800000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.500000f);
            rt.anchorMax = new Vector2(1.000000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(25.200001f, -2.400002f);
            rt.sizeDelta = new Vector2(49.000000f, 54.000000f);
        }
        {
            var rt = goMap[2198664134873810414L].AddComponent<RectTransform>();
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
            var rt = goMap[-2878231624896232247L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.800000f, 0.800000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-35.700001f, 82.800003f);
            rt.sizeDelta = new Vector2(90.000000f, 90.000000f);
        }
        {
            var rt = goMap[3119587059341281389L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -4.800000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-5119646303807181167L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -0.943100f);
            rt.sizeDelta = new Vector2(78.000000f, 78.000000f);
        }
        {
            var rt = goMap[2332742321008256173L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(80.000000f, 80.000000f);
        }
        {
            var rt = goMap[-5768738703989094470L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }
        {
            var rt = goMap[8293203503950599828L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(80.000000f, 80.000000f);
        }
        {
            var rt = goMap[7766555810418696440L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(69.862198f, 61.366100f);
        }
        {
            var rt = goMap[5744706740004535233L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-1.800000f, 0.000000f);
            rt.sizeDelta = new Vector2(120.000000f, 120.000000f);
        }
        {
            var rt = goMap[-3707775245594182718L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(21.600000f, -28.200001f);
            rt.sizeDelta = new Vector2(53.480598f, 35.644001f);
        }
        {
            var rt = goMap[-9160406135973828590L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(8.000000f, 0.200000f);
            rt.sizeDelta = new Vector2(36.000000f, 36.000000f);
        }
        {
            var rt = goMap[8987510532917230767L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(8.300000f, 0.000000f);
            rt.sizeDelta = new Vector2(33.400002f, 30.000000f);
        }
        {
            var rt = goMap[6811288906427153145L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(8.300000f, 0.000000f);
            rt.sizeDelta = new Vector2(33.400002f, 30.000000f);
        }
        {
            var rt = goMap[7241596957681497151L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-31.100000f, 30.000000f);
            rt.sizeDelta = new Vector2(40.000000f, 40.000000f);
        }
        {
            var rt = goMap[-2769106959679195560L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-1.300000f, 16.799988f);
            rt.sizeDelta = new Vector2(250.000000f, 40.000000f);
        }
        {
            var rt = goMap[-8360592351981907993L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -36.600006f);
            rt.sizeDelta = new Vector2(440.000000f, 52.000000f);
        }
        {
            var rt = goMap[-7987549426346481829L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.000093f, 0.000000f);
            rt.sizeDelta = new Vector2(440.000000f, 44.000000f);
        }
        {
            var rt = goMap[-7492758340124757421L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(440.000000f, 44.000000f);
        }
        {
            var rt = goMap[2254065474437011172L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -90.299988f);
            rt.sizeDelta = new Vector2(200.000000f, 40.000000f);
        }
        {
            var rt = goMap[-6299632750225968713L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.000000f);
            rt.anchorMax = new Vector2(0.500000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(4.200000f, -40.300003f);
            rt.sizeDelta = new Vector2(400.000000f, 55.000000f);
        }
        {
            var rt = goMap[7771892294044945934L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(13.500000f, 0.000000f);
            rt.sizeDelta = new Vector2(32.000000f, 32.000000f);
        }
        {
            var rt = goMap[-704601450880528412L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(113.599998f, 0.000000f);
            rt.sizeDelta = new Vector2(160.000000f, 40.000000f);
        }
        {
            var rt = goMap[-7494357728535919550L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-81.599998f, 0.000000f);
            rt.sizeDelta = new Vector2(150.000000f, 40.000000f);
        }
        {
            var rt = goMap[1408658395710885033L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -148.000000f);
            rt.sizeDelta = new Vector2(144.000000f, 52.000000f);
        }
        {
            var rt = goMap[7673535765961410515L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 3.000000f);
            rt.sizeDelta = new Vector2(144.000000f, 54.000000f);
        }

        // ─── Components ──────────────────────────────────────
        { var c = goMap[-3623994943746630329L].AddComponent<Canvas>();
           c.renderMode = (RenderMode)1;
           c.overrideSorting = false;
           c.sortingOrder = 0;
           c.planeDistance = 100.000000f;
           c.pixelPerfect = false;
           c.additionalShaderChannels = (AdditionalCanvasShaderChannels)0;
           c.enabled = true;
        }
        { var c = goMap[-3623994943746630329L].AddComponent<CanvasScaler>();
           c.uiScaleMode = (CanvasScaler.ScaleMode)1;
           c.referenceResolution = new Vector2(1280.000000f, 720.000000f);
           c.screenMatchMode = (CanvasScaler.ScreenMatchMode)0;
           c.matchWidthOrHeight = 0.000000f;
           c.referencePixelsPerUnit = 100.000000f;
        }
        { var c = goMap[-3623994943746630329L].AddComponent<GraphicRaycaster>();
           c.ignoreReversedGraphics = true;
        }
        { var c = goMap[-3623994943746630329L].AddComponent<Image>();
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
        { var c = goMap[-3623994943746630329L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("UIKinModifyName"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[-8258622997474017852L].AddComponent<CanvasGroup>();
           c.alpha = 1.000000f;
           c.interactable = true;
           c.blocksRaycasts = true;
           c.ignoreParentGroups = false;
        }
        { var c = goMap[-6067311128197125518L].AddComponent<Image>();
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
        { var c = goMap[8711237197878453815L].AddComponent<Image>();
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
        { var c = goMap[-2854667702866034163L].AddComponent<Image>();
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
        { var c = goMap[-4787992541033925063L].AddComponent<Image>();
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
        { var c = goMap[-7067929919516144730L].AddComponent<Image>();
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
        { var c = goMap[2228277152806480663L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_background_titlebg4");
        }
        { var c = goMap[1914003000572325534L].AddComponent<Image>();
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
        { var c = goMap[2111397292902958186L].AddComponent<Image>();
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
        { var c = goMap[9146758433963347705L].AddComponent<Image>();
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
        { var c = goMap[7287860685170429272L].AddComponent<Image>();
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
        { var c = goMap[-5943010861625126351L].AddComponent<Image>();
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
        { var c = goMap[1116456610283000694L].AddComponent<Image>();
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
        { var c = goMap[-1097320286975747148L].AddComponent<Image>();
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
           c.sprite = LookupSprite("btn_close");
        }
        { var c = goMap[-1097320286975747148L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-1097320286975747148L].AddComponent<UIScalePulse>();
           c.upScale = 0.950000f; c.duration = 0.100000f; c.scaleUp = false;
           c.enabled = true;
        }
        { var c = goMap[-866727569713308659L].AddComponent<Text>();
           c.text = "10140";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 26;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleLeft;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 0.850000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 42;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-866727569713308659L].AddComponent<Outline>();
           c.effectColor = new Color(0.372549f, 0.545098f, 0.552941f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[8901681535328524089L].AddComponent<Image>();
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
           c.sprite = LookupSprite("btn_info");
        }
        { var c = goMap[8901681535328524089L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[8901681535328524089L].AddComponent<UIScalePulse>();
           c.upScale = 0.950000f; c.duration = 0.100000f; c.scaleUp = false;
           c.enabled = true;
        }
        { var c = goMap[2198664134873810414L].AddComponent<CanvasGroup>();
           c.alpha = 1.000000f;
           c.interactable = true;
           c.blocksRaycasts = true;
           c.ignoreParentGroups = false;
        }
        { var c = goMap[-2878231624896232247L].AddComponent<Image>();
           c.color = new Color(1f,1f,1f,0f);
           c.raycastTarget = true;
           c.maskable = true;
           c.enabled = true;
        }
        { var c = goMap[-2878231624896232247L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[3119587059341281389L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_portrait_bg");
        }
        { var c = goMap[-5119646303807181167L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.003922f);
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
           c.sprite = LookupSprite("img_portraitbg2");
        }
        { var c = goMap[-5119646303807181167L].AddComponent<Mask>();
           c.showMaskGraphic = true;
           c.enabled = true;
        }
        { var c = goMap[2332742321008256173L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_common_empty");
        }
        { var c = goMap[8293203503950599828L].AddComponent<Image>();
           c.color = new Color(0.047170f, 0.046057f, 0.046057f, 0.596078f);
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
        { var c = goMap[7766555810418696440L].AddComponent<Text>();
           c.text = "离线";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 12;
           c.resizeTextMaxSize = 18;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[7766555810418696440L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[5744706740004535233L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_empty_portrait");
        }
        { var c = goMap[-9160406135973828590L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_level_bg");
        }
        { var c = goMap[8987510532917230767L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(0.172549f, 0.925490f, 0.278431f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Overflow;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 0;
           c.resizeTextMaxSize = 300;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[6811288906427153145L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Overflow;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 0;
           c.resizeTextMaxSize = 300;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var g = goMap[6811288906427153145L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.996078f, 0.847059f, 0.984314f, 1.000000f); }
        { var c = goMap[6811288906427153145L].AddComponent<Outline>();
           c.effectColor = new Color(0.505882f, 0.090196f, 0.498039f, 1.000000f);
           c.effectDistance = new Vector2(1.500000f, -1.500000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[7241596957681497151L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_common_empty");
        }
        { var c = goMap[-2769106959679195560L].AddComponent<Text>();
           c.text = "14942";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 10;
           c.resizeTextMaxSize = 20;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-8360592351981907993L].AddComponent<Image>();
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
           c.sprite = LookupSprite("common_input_bg");
        }
        { var c = goMap[-7987549426346481829L].AddComponent<Text>();
           c.text = "9569";
           c.color = new Color(0.576471f, 0.576471f, 0.572549f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Italic;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 10;
           c.resizeTextMaxSize = 20;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-7492758340124757421L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = false;
           c.horizontalOverflow = HorizontalWrapMode.Overflow;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 10;
           c.resizeTextMaxSize = 20;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[2254065474437011172L].AddComponent<Text>();
           c.text = "15693";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 10;
           c.resizeTextMaxSize = 20;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[7771892294044945934L].AddComponent<Image>();
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
           c.sprite = LookupSprite("icon_yuanbao");
        }
        { var c = goMap[-704601450880528412L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleLeft;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 10;
           c.resizeTextMaxSize = 20;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-7494357728535919550L].AddComponent<Text>();
           c.text = "改名费用";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleRight;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 10;
           c.resizeTextMaxSize = 20;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[1408658395710885033L].AddComponent<Image>();
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
           c.sprite = LookupSprite("btn_common2_1");
        }
        { var c = goMap[1408658395710885033L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[1408658395710885033L].AddComponent<UIScalePulse>();
           c.upScale = 0.950000f; c.duration = 0.100000f; c.scaleUp = false;
           c.enabled = true;
        }
        { var c = goMap[7673535765961410515L].AddComponent<Text>();
           c.text = "保存";
           c.color = new Color(0.047059f, 0.227451f, 0.239216f, 1.000000f);
           c.fontSize = 22;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 12;
           c.resizeTextMaxSize = 22;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
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
        var rootGO = goMap[-3623994943746630329L];
        string path = "Assets/Prefabs/Imported/UIPlayerModifyName.prefab";
        PrefabUtility.SaveAsPrefabAsset(rootGO, path);
        Object.DestroyImmediate(rootGO);
        Debug.Log("[Import_res_p_272] Saved " + path);
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