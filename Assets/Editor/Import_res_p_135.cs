// AUTO-GENERATED from res_p_135.ab — DO NOT EDIT MANUALLY.
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;
using System.Collections.Generic;
using System.Reflection;
using I2.Loc;

public class Import_res_p_135
{
    [MenuItem("KTO/Import/res_p_135")]
    public static void Build()
    {
        Debug.Log("[Import_res_p_135] Building UILoginChannelInner...");

        // ─── Create all GameObjects ───────────────────────────
        var goMap = new Dictionary<long, GameObject>();
        { var go = new GameObject("UILoginChannelInner"); go.SetActive(true); goMap[-959427722286098252L] = go; }
        { var go = new GameObject("imgBG"); go.SetActive(true); goMap[-4673948578471444958L] = go; }
        { var go = new GameObject("imgLine"); go.SetActive(true); goMap[3104239386166485368L] = go; }
        { var go = new GameObject("txtAppVersion"); go.SetActive(true); goMap[-7476955837567255747L] = go; }
        { var go = new GameObject("txtGameAdvice"); go.SetActive(true); goMap[-2917083366826642417L] = go; }
        { var go = new GameObject("imgGameLogo"); go.SetActive(true); goMap[6909498026805937718L] = go; }
        { var go = new GameObject("imgCADPA"); go.SetActive(false); goMap[-5129686316111348541L] = go; }
        { var go = new GameObject("btnEnterGame"); go.SetActive(true); goMap[-3060623319365470202L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[3243906466086540206L] = go; }
        { var go = new GameObject("imgAccount"); go.SetActive(true); goMap[-8066389694688378803L] = go; }
        { var go = new GameObject("imgInputBG"); go.SetActive(true); goMap[-5107390794436273388L] = go; }
        { var go = new GameObject("txtID"); go.SetActive(true); goMap[6330686935579603030L] = go; }
        { var go = new GameObject("imgInputBG"); go.SetActive(true); goMap[510372578836138939L] = go; }
        { var go = new GameObject("txtPwd"); go.SetActive(true); goMap[-2900524705604812200L] = go; }
        { var go = new GameObject("inputAccount"); go.SetActive(true); goMap[3938945099341229646L] = go; }
        { var go = new GameObject("Placeholder"); go.SetActive(true); goMap[-1321269842105272742L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-1323056984077052894L] = go; }
        { var go = new GameObject("inputPwd"); go.SetActive(true); goMap[409035814923731511L] = go; }
        { var go = new GameObject("Placeholder"); go.SetActive(true); goMap[-2140165931822314807L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-4752530702791096079L] = go; }
        { var go = new GameObject("togRememberAccount"); go.SetActive(true); goMap[3408246909575946839L] = go; }
        { var go = new GameObject("Background"); go.SetActive(true); goMap[-3264826014631784969L] = go; }
        { var go = new GameObject("Checkmark"); go.SetActive(true); goMap[2954057030242465022L] = go; }
        { var go = new GameObject("Label"); go.SetActive(true); goMap[-3028824380545492527L] = go; }
        { var go = new GameObject("btnRegister"); go.SetActive(false); goMap[1486408382902650638L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[3198215296030496653L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[740882908957158691L] = go; }
        { var go = new GameObject("btnFindPwd"); go.SetActive(false); goMap[-7209637982974084092L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-1191758205968235226L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[3027630945157291835L] = go; }
        { var go = new GameObject("txtCurZoneTip"); go.SetActive(true); goMap[-3220662619355526429L] = go; }
        { var go = new GameObject("txtCurZoneValue"); go.SetActive(true); goMap[-1806731902761475707L] = go; }
        { var go = new GameObject("btnSelectZone"); go.SetActive(true); goMap[9198468259966897890L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[2989608131843237764L] = go; }
        { var go = new GameObject("SelectPlatform"); go.SetActive(true); goMap[-2654001819065670792L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[2285784091670728775L] = go; }
        { var go = new GameObject("togglePC"); go.SetActive(true); goMap[-9150077196022877136L] = go; }
        { var go = new GameObject("Background"); go.SetActive(true); goMap[532213880791618148L] = go; }
        { var go = new GameObject("Checkmark"); go.SetActive(true); goMap[7565429519185754554L] = go; }
        { var go = new GameObject("Label"); go.SetActive(true); goMap[-7705758488480704023L] = go; }
        { var go = new GameObject("toggleiOS"); go.SetActive(true); goMap[6983251550178796478L] = go; }
        { var go = new GameObject("Background"); go.SetActive(true); goMap[5511621679902880547L] = go; }
        { var go = new GameObject("Checkmark"); go.SetActive(true); goMap[8980104210362642417L] = go; }
        { var go = new GameObject("Label"); go.SetActive(true); goMap[-2915151790377423669L] = go; }
        { var go = new GameObject("toggleAndroid"); go.SetActive(true); goMap[5139040020343021124L] = go; }
        { var go = new GameObject("Background"); go.SetActive(true); goMap[-8905912453469056538L] = go; }
        { var go = new GameObject("Checkmark"); go.SetActive(true); goMap[6431776791569506784L] = go; }
        { var go = new GameObject("Label"); go.SetActive(true); goMap[7177278377188989178L] = go; }
        { var go = new GameObject("toggleMix"); go.SetActive(true); goMap[-5846258571111919563L] = go; }
        { var go = new GameObject("Background"); go.SetActive(true); goMap[-7035891633917960475L] = go; }
        { var go = new GameObject("Checkmark"); go.SetActive(true); goMap[-6327951899122848638L] = go; }
        { var go = new GameObject("Label"); go.SetActive(true); goMap[-956569705120667222L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-4137217204506836836L] = go; }
        { var go = new GameObject("Dropdown"); go.SetActive(true); goMap[-2228882742424832941L] = go; }
        { var go = new GameObject("Label"); go.SetActive(true); goMap[-1457697452122017427L] = go; }
        { var go = new GameObject("Arrow"); go.SetActive(true); goMap[1774440990325404704L] = go; }
        { var go = new GameObject("Template"); go.SetActive(false); goMap[-6640051572024578214L] = go; }
        { var go = new GameObject("Viewport"); go.SetActive(true); goMap[-3198845291674568655L] = go; }
        { var go = new GameObject("Content"); go.SetActive(true); goMap[-2667034637960062046L] = go; }
        { var go = new GameObject("Item"); go.SetActive(true); goMap[5431699452823915283L] = go; }
        { var go = new GameObject("Item Background"); go.SetActive(true); goMap[6699230820125197428L] = go; }
        { var go = new GameObject("Item Checkmark"); go.SetActive(true); goMap[2042272082762107293L] = go; }
        { var go = new GameObject("Item Label"); go.SetActive(true); goMap[-2645315664051713667L] = go; }
        { var go = new GameObject("Scrollbar"); go.SetActive(true); goMap[1316121078678036205L] = go; }
        { var go = new GameObject("Sliding Area"); go.SetActive(true); goMap[6236366690304230166L] = go; }
        { var go = new GameObject("Handle"); go.SetActive(true); goMap[6696452328744356773L] = go; }

        // ─── Parent links ─────────────────────────────────────
        goMap[-4673948578471444958L].transform.SetParent(goMap[-959427722286098252L].transform, false);
        goMap[3104239386166485368L].transform.SetParent(goMap[-4673948578471444958L].transform, false);
        goMap[-7476955837567255747L].transform.SetParent(goMap[-4673948578471444958L].transform, false);
        goMap[-2917083366826642417L].transform.SetParent(goMap[-4673948578471444958L].transform, false);
        goMap[6909498026805937718L].transform.SetParent(goMap[-4673948578471444958L].transform, false);
        goMap[-5129686316111348541L].transform.SetParent(goMap[-4673948578471444958L].transform, false);
        goMap[-3060623319365470202L].transform.SetParent(goMap[-4673948578471444958L].transform, false);
        goMap[3243906466086540206L].transform.SetParent(goMap[-3060623319365470202L].transform, false);
        goMap[-8066389694688378803L].transform.SetParent(goMap[-4673948578471444958L].transform, false);
        goMap[-5107390794436273388L].transform.SetParent(goMap[-8066389694688378803L].transform, false);
        goMap[6330686935579603030L].transform.SetParent(goMap[-8066389694688378803L].transform, false);
        goMap[510372578836138939L].transform.SetParent(goMap[-8066389694688378803L].transform, false);
        goMap[-2900524705604812200L].transform.SetParent(goMap[-8066389694688378803L].transform, false);
        goMap[3938945099341229646L].transform.SetParent(goMap[-8066389694688378803L].transform, false);
        goMap[-1321269842105272742L].transform.SetParent(goMap[3938945099341229646L].transform, false);
        goMap[-1323056984077052894L].transform.SetParent(goMap[3938945099341229646L].transform, false);
        goMap[409035814923731511L].transform.SetParent(goMap[-8066389694688378803L].transform, false);
        goMap[-2140165931822314807L].transform.SetParent(goMap[409035814923731511L].transform, false);
        goMap[-4752530702791096079L].transform.SetParent(goMap[409035814923731511L].transform, false);
        goMap[3408246909575946839L].transform.SetParent(goMap[-8066389694688378803L].transform, false);
        goMap[-3264826014631784969L].transform.SetParent(goMap[3408246909575946839L].transform, false);
        goMap[2954057030242465022L].transform.SetParent(goMap[-3264826014631784969L].transform, false);
        goMap[-3028824380545492527L].transform.SetParent(goMap[3408246909575946839L].transform, false);
        goMap[1486408382902650638L].transform.SetParent(goMap[-8066389694688378803L].transform, false);
        goMap[3198215296030496653L].transform.SetParent(goMap[1486408382902650638L].transform, false);
        goMap[740882908957158691L].transform.SetParent(goMap[1486408382902650638L].transform, false);
        goMap[-7209637982974084092L].transform.SetParent(goMap[-8066389694688378803L].transform, false);
        goMap[-1191758205968235226L].transform.SetParent(goMap[-7209637982974084092L].transform, false);
        goMap[3027630945157291835L].transform.SetParent(goMap[-7209637982974084092L].transform, false);
        goMap[-3220662619355526429L].transform.SetParent(goMap[-4673948578471444958L].transform, false);
        goMap[-1806731902761475707L].transform.SetParent(goMap[-4673948578471444958L].transform, false);
        goMap[9198468259966897890L].transform.SetParent(goMap[-4673948578471444958L].transform, false);
        goMap[2989608131843237764L].transform.SetParent(goMap[9198468259966897890L].transform, false);
        goMap[-2654001819065670792L].transform.SetParent(goMap[-4673948578471444958L].transform, false);
        goMap[2285784091670728775L].transform.SetParent(goMap[-2654001819065670792L].transform, false);
        goMap[-9150077196022877136L].transform.SetParent(goMap[-2654001819065670792L].transform, false);
        goMap[532213880791618148L].transform.SetParent(goMap[-9150077196022877136L].transform, false);
        goMap[7565429519185754554L].transform.SetParent(goMap[532213880791618148L].transform, false);
        goMap[-7705758488480704023L].transform.SetParent(goMap[-9150077196022877136L].transform, false);
        goMap[6983251550178796478L].transform.SetParent(goMap[-2654001819065670792L].transform, false);
        goMap[5511621679902880547L].transform.SetParent(goMap[6983251550178796478L].transform, false);
        goMap[8980104210362642417L].transform.SetParent(goMap[5511621679902880547L].transform, false);
        goMap[-2915151790377423669L].transform.SetParent(goMap[6983251550178796478L].transform, false);
        goMap[5139040020343021124L].transform.SetParent(goMap[-2654001819065670792L].transform, false);
        goMap[-8905912453469056538L].transform.SetParent(goMap[5139040020343021124L].transform, false);
        goMap[6431776791569506784L].transform.SetParent(goMap[-8905912453469056538L].transform, false);
        goMap[7177278377188989178L].transform.SetParent(goMap[5139040020343021124L].transform, false);
        goMap[-5846258571111919563L].transform.SetParent(goMap[-2654001819065670792L].transform, false);
        goMap[-7035891633917960475L].transform.SetParent(goMap[-5846258571111919563L].transform, false);
        goMap[-6327951899122848638L].transform.SetParent(goMap[-7035891633917960475L].transform, false);
        goMap[-956569705120667222L].transform.SetParent(goMap[-5846258571111919563L].transform, false);
        goMap[-4137217204506836836L].transform.SetParent(goMap[-2654001819065670792L].transform, false);
        goMap[-2228882742424832941L].transform.SetParent(goMap[-2654001819065670792L].transform, false);
        goMap[-1457697452122017427L].transform.SetParent(goMap[-2228882742424832941L].transform, false);
        goMap[1774440990325404704L].transform.SetParent(goMap[-2228882742424832941L].transform, false);
        goMap[-6640051572024578214L].transform.SetParent(goMap[-2228882742424832941L].transform, false);
        goMap[-3198845291674568655L].transform.SetParent(goMap[-6640051572024578214L].transform, false);
        goMap[-2667034637960062046L].transform.SetParent(goMap[-3198845291674568655L].transform, false);
        goMap[5431699452823915283L].transform.SetParent(goMap[-2667034637960062046L].transform, false);
        goMap[6699230820125197428L].transform.SetParent(goMap[5431699452823915283L].transform, false);
        goMap[2042272082762107293L].transform.SetParent(goMap[5431699452823915283L].transform, false);
        goMap[-2645315664051713667L].transform.SetParent(goMap[5431699452823915283L].transform, false);
        goMap[1316121078678036205L].transform.SetParent(goMap[-6640051572024578214L].transform, false);
        goMap[6236366690304230166L].transform.SetParent(goMap[1316121078678036205L].transform, false);
        goMap[6696452328744356773L].transform.SetParent(goMap[6236366690304230166L].transform, false);

        // ─── Transforms ──────────────────────────────────────
        {
            var rt = goMap[-959427722286098252L].AddComponent<RectTransform>();
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
            var rt = goMap[-4673948578471444958L].AddComponent<RectTransform>();
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
            var rt = goMap[3104239386166485368L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.707107f,0.707107f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.000000f);
            rt.anchorMax = new Vector2(0.500000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.000200f, 80.000000f);
            rt.sizeDelta = new Vector2(160.225098f, 1561.702637f);
        }
        {
            var rt = goMap[-7476955837567255747L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(214.000000f, 60.000000f);
            rt.sizeDelta = new Vector2(900.000000f, 40.000000f);
        }
        {
            var rt = goMap[-2917083366826642417L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(717.000000f, 20.000000f);
            rt.sizeDelta = new Vector2(1280.000000f, 40.000000f);
        }
        {
            var rt = goMap[6909498026805937718L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.800000f, 0.800000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(203.500000f, -85.000000f);
            rt.sizeDelta = new Vector2(618.000000f, 162.000000f);
        }
        {
            var rt = goMap[-5129686316111348541L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.000000f, 0.000000f);
            rt.anchoredPosition = new Vector2(38.500000f, 95.000000f);
            rt.sizeDelta = new Vector2(211.000000f, 80.000000f);
        }
        {
            var rt = goMap[-3060623319365470202L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -162.339996f);
            rt.sizeDelta = new Vector2(236.000000f, 61.000000f);
        }
        {
            var rt = goMap[3243906466086540206L].AddComponent<RectTransform>();
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
            var rt = goMap[-8066389694688378803L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 27.000000f);
            rt.sizeDelta = new Vector2(500.000000f, 276.000000f);
        }
        {
            var rt = goMap[-5107390794436273388L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(34.000000f, 72.000000f);
            rt.sizeDelta = new Vector2(270.000000f, 40.000000f);
        }
        {
            var rt = goMap[6330686935579603030L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-150.600006f, 72.500000f);
            rt.sizeDelta = new Vector2(160.000000f, 50.000000f);
        }
        {
            var rt = goMap[510372578836138939L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(34.000000f, -2.200012f);
            rt.sizeDelta = new Vector2(270.000000f, 40.000000f);
        }
        {
            var rt = goMap[-2900524705604812200L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-150.600006f, -1.700000f);
            rt.sizeDelta = new Vector2(160.000000f, 50.000000f);
        }
        {
            var rt = goMap[3938945099341229646L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(34.000000f, 72.000000f);
            rt.sizeDelta = new Vector2(250.000000f, 40.000000f);
        }
        {
            var rt = goMap[-1321269842105272742L].AddComponent<RectTransform>();
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
            var rt = goMap[-1323056984077052894L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -0.000002f);
            rt.sizeDelta = new Vector2(-0.000015f, 0.000000f);
        }
        {
            var rt = goMap[409035814923731511L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(34.000000f, -1.200000f);
            rt.sizeDelta = new Vector2(250.000000f, 40.000000f);
        }
        {
            var rt = goMap[-2140165931822314807L].AddComponent<RectTransform>();
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
            var rt = goMap[-4752530702791096079L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -0.000002f);
            rt.sizeDelta = new Vector2(-0.000015f, 0.000000f);
        }
        {
            var rt = goMap[3408246909575946839L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(164.000000f, -92.000000f);
            rt.sizeDelta = new Vector2(140.000000f, 40.000000f);
        }
        {
            var rt = goMap[-3264826014631784969L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(20.000000f, -20.000000f);
            rt.sizeDelta = new Vector2(38.000000f, 38.000000f);
        }
        {
            var rt = goMap[2954057030242465022L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(38.000000f, 34.000000f);
        }
        {
            var rt = goMap[-3028824380545492527L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(17.900000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }
        {
            var rt = goMap[1486408382902650638L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-145.199997f, -92.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 40.000000f);
        }
        {
            var rt = goMap[3198215296030496653L].AddComponent<RectTransform>();
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
            var rt = goMap[740882908957158691L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -11.600000f);
            rt.sizeDelta = new Vector2(85.000000f, 1.000000f);
        }
        {
            var rt = goMap[-7209637982974084092L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-11.300000f, -92.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 40.000000f);
        }
        {
            var rt = goMap[-1191758205968235226L].AddComponent<RectTransform>();
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
            var rt = goMap[3027630945157291835L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -11.600000f);
            rt.sizeDelta = new Vector2(85.000000f, 1.000000f);
        }
        {
            var rt = goMap[-3220662619355526429L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-501.999939f, 79.000061f);
            rt.sizeDelta = new Vector2(200.000000f, 80.000000f);
        }
        {
            var rt = goMap[-1806731902761475707L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-213.000000f, 79.000000f);
            rt.sizeDelta = new Vector2(350.000000f, 80.000000f);
        }
        {
            var rt = goMap[9198468259966897890L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-115.999939f, 77.300049f);
            rt.sizeDelta = new Vector2(120.000000f, 44.000000f);
        }
        {
            var rt = goMap[2989608131843237764L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 2.000000f);
            rt.sizeDelta = new Vector2(120.000000f, 30.000000f);
        }
        {
            var rt = goMap[-2654001819065670792L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(0.000000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(194.000000f, -37.000000f);
            rt.sizeDelta = new Vector2(345.000000f, 500.000000f);
        }
        {
            var rt = goMap[2285784091670728775L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.000000f, 1.000000f);
            rt.anchoredPosition = new Vector2(10.000000f, -7.000015f);
            rt.sizeDelta = new Vector2(220.000000f, 250.000000f);
        }
        {
            var rt = goMap[-9150077196022877136L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.500000f, 1.500000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.000000f, 1.000000f);
            rt.anchoredPosition = new Vector2(54.000122f, -258.296783f);
            rt.sizeDelta = new Vector2(160.000000f, 22.446426f);
        }
        {
            var rt = goMap[532213880791618148L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(10.000000f, -11.223000f);
            rt.sizeDelta = new Vector2(20.000000f, 20.000000f);
        }
        {
            var rt = goMap[7565429519185754554L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(20.000000f, 20.000000f);
        }
        {
            var rt = goMap[-7705758488480704023L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(9.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(-28.000000f, 0.000000f);
        }
        {
            var rt = goMap[6983251550178796478L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.500000f, 1.500000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.000000f, 1.000000f);
            rt.anchoredPosition = new Vector2(54.000122f, -308.806793f);
            rt.sizeDelta = new Vector2(160.000000f, 22.446426f);
        }
        {
            var rt = goMap[5511621679902880547L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(10.000000f, -11.223000f);
            rt.sizeDelta = new Vector2(20.000000f, 20.000000f);
        }
        {
            var rt = goMap[8980104210362642417L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(20.000000f, 20.000000f);
        }
        {
            var rt = goMap[-2915151790377423669L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(9.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(-28.000000f, 0.000000f);
        }
        {
            var rt = goMap[5139040020343021124L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.500000f, 1.500000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.000000f, 1.000000f);
            rt.anchoredPosition = new Vector2(54.000122f, -355.946777f);
            rt.sizeDelta = new Vector2(160.000000f, 22.446426f);
        }
        {
            var rt = goMap[-8905912453469056538L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(10.000000f, -11.223000f);
            rt.sizeDelta = new Vector2(20.000000f, 20.000000f);
        }
        {
            var rt = goMap[6431776791569506784L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(20.000000f, 20.000000f);
        }
        {
            var rt = goMap[7177278377188989178L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(9.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(-28.000000f, 0.000000f);
        }
        {
            var rt = goMap[-5846258571111919563L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.500000f, 1.500000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.000000f, 1.000000f);
            rt.anchoredPosition = new Vector2(54.000122f, -400.000000f);
            rt.sizeDelta = new Vector2(160.000000f, 22.446426f);
        }
        {
            var rt = goMap[-7035891633917960475L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(10.000000f, -11.223000f);
            rt.sizeDelta = new Vector2(20.000000f, 20.000000f);
        }
        {
            var rt = goMap[-6327951899122848638L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(20.000000f, 20.000000f);
        }
        {
            var rt = goMap[-956569705120667222L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(9.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(-28.000000f, 0.000000f);
        }
        {
            var rt = goMap[-4137217204506836836L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-74.000000f, -220.000000f);
            rt.sizeDelta = new Vector2(160.000000f, 30.000000f);
        }
        {
            var rt = goMap[-2228882742424832941L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-25.000000f, -220.000000f);
            rt.sizeDelta = new Vector2(160.000000f, 44.000000f);
        }
        {
            var rt = goMap[-1457697452122017427L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-7.500000f, -0.500000f);
            rt.sizeDelta = new Vector2(-35.000000f, -13.000000f);
        }
        {
            var rt = goMap[1774440990325404704L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.500000f);
            rt.anchorMax = new Vector2(1.000000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-15.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(20.000000f, 20.000000f);
        }
        {
            var rt = goMap[-6640051572024578214L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 1.000000f);
            rt.anchoredPosition = new Vector2(0.000000f, 2.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 150.000000f);
        }
        {
            var rt = goMap[-3198845291674568655L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.000000f, 1.000000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(-17.000000f, 0.000000f);
        }
        {
            var rt = goMap[-2667034637960062046L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 1.000000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 28.000000f);
        }
        {
            var rt = goMap[5431699452823915283L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(1.000000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 30.000000f);
        }
        {
            var rt = goMap[6699230820125197428L].AddComponent<RectTransform>();
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
            var rt = goMap[2042272082762107293L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(0.000000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(10.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(20.000000f, 20.000000f);
        }
        {
            var rt = goMap[-2645315664051713667L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(5.000000f, -0.500000f);
            rt.sizeDelta = new Vector2(-30.000000f, -3.000000f);
        }
        {
            var rt = goMap[1316121078678036205L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(1.000000f, 1.000000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(20.000000f, 0.000000f);
        }
        {
            var rt = goMap[6236366690304230166L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(-20.000000f, -20.000000f);
        }
        {
            var rt = goMap[6696452328744356773L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(20.000000f, 20.000000f);
        }

        // ─── Components ──────────────────────────────────────
        { var c = goMap[-959427722286098252L].AddComponent<CanvasScaler>();
           c.uiScaleMode = (CanvasScaler.ScaleMode)1;
           c.referenceResolution = new Vector2(1280.000000f, 720.000000f);
           c.matchWidthOrHeight = 0.000000f;
           c.referencePixelsPerUnit = 100.000000f;
        }
        { var c = goMap[-959427722286098252L].AddComponent<GraphicRaycaster>();
           c.ignoreReversedGraphics = true;
        }
        { var c = goMap[-959427722286098252L].AddComponent<UIView>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"m_luaClassName", "UILoginChannelInner"}});
        }
        { var c = goMap[3104239386166485368L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.000000f, 0.000000f, 0.784314f);
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
           c.sprite = LookupSprite("img_line_hud");
        }
        { var c = goMap[-7476955837567255747L].AddComponent<Text>();
           c.text = "程序版本：0.0.0.0";
           c.color = new Color(1.000000f, 0.964672f, 0.000000f, 1.000000f);
           c.fontSize = 16;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleLeft;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 1;
           c.resizeTextMaxSize = 40;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-7476955837567255747L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "11400"},{"mTermSecondary", "common_zh"},{"PrimaryTermModifier", 0},{"SecondaryTermModifier", 0},{"TermPrefix", ""},{"TermSuffix", ""},{"LocalizeOnAwake", 1},{"IgnoreRTL", 0},{"MaxCharactersInRTL", 0},{"IgnoreNumbersInRTL", 1},{"CorrectAlignmentForRTL", 1},{"AddSpacesToJoinedLanguages", 0},{"AllowLocalizedParameters", 1},{"AllowParameters", 1},{"AlwaysForceLocalize", 0},{"mGUI_ShowReferences", 0},{"mGUI_ShowTems", 1},{"mGUI_ShowCallback", 0},{"mLocalizeTargetName", "I2.Loc.LocalizeTarget_UnityUI_Text"}});
        }
        { var c = goMap[-2917083366826642417L].AddComponent<Text>();
           c.text = "健康游戏忠告：抵制不良游戏，拒绝盗版游戏。注意自我保护，谨防受骗上当。适度游戏益脑，沉迷游戏伤身。合理安排时间，享受健康生活。";
           c.color = new Color(1.000000f, 1.000000f, 0.800000f, 1.000000f);
           c.fontSize = 16;
           c.fontStyle = FontStyle.Normal;
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
        { var c = goMap[-2917083366826642417L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "HealthyGamingAdvice"},{"mTermSecondary", "common_zh"},{"PrimaryTermModifier", 0},{"SecondaryTermModifier", 0},{"TermPrefix", ""},{"TermSuffix", ""},{"LocalizeOnAwake", 1},{"IgnoreRTL", 0},{"MaxCharactersInRTL", 0},{"IgnoreNumbersInRTL", 1},{"CorrectAlignmentForRTL", 1},{"AddSpacesToJoinedLanguages", 0},{"AllowLocalizedParameters", 1},{"AllowParameters", 1},{"AlwaysForceLocalize", 0},{"mGUI_ShowReferences", 0},{"mGUI_ShowTems", 1},{"mGUI_ShowCallback", 0},{"mLocalizeTargetName", "I2.Loc.LocalizeTarget_UnityUI_Text"}});
        }
        { var c = goMap[6909498026805937718L].AddComponent<Image>();
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
           c.sprite = LookupSprite("gamelogo");
        }
        { var c = goMap[-5129686316111348541L].AddComponent<Image>();
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
           c.sprite = LookupSprite("CADPA");
        }
        { var c = goMap[-5129686316111348541L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-3060623319365470202L].AddComponent<Image>();
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
           c.sprite = LookupSprite("btn_createrole");
        }
        { var c = goMap[-3060623319365470202L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-3060623319365470202L].AddComponent<UIAnimScaleUp>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"AnimTime", 0.200000f},{"UpToScale", 1.100000f}});
        }
        { var c = goMap[3243906466086540206L].AddComponent<Text>();
           c.text = "登录";
           c.color = new Color(0.466667f, 0.215686f, 0.078431f, 1.000000f);
           c.fontSize = 28;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 0;
           c.resizeTextMaxSize = 40;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[3243906466086540206L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "登录"},{"mTermSecondary", "common_zh"},{"PrimaryTermModifier", 0},{"SecondaryTermModifier", 0},{"TermPrefix", ""},{"TermSuffix", ""},{"LocalizeOnAwake", 1},{"IgnoreRTL", 0},{"MaxCharactersInRTL", 0},{"IgnoreNumbersInRTL", 1},{"CorrectAlignmentForRTL", 1},{"AddSpacesToJoinedLanguages", 0},{"AllowLocalizedParameters", 1},{"AllowParameters", 1},{"AlwaysForceLocalize", 0},{"mGUI_ShowReferences", 0},{"mGUI_ShowTems", 1},{"mGUI_ShowCallback", 0},{"mLocalizeTargetName", "I2.Loc.LocalizeTarget_UnityUI_Text"}});
        }
        { var c = goMap[-8066389694688378803L].AddComponent<Image>();
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
        { var c = goMap[-5107390794436273388L].AddComponent<Image>();
           c.color = new Color(0.784314f, 0.811765f, 0.811765f, 1.000000f);
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
        { var c = goMap[-5107390794436273388L].AddComponent<Outline>();
           c.effectColor = new Color(0.584314f, 0.603922f, 0.603922f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[6330686935579603030L].AddComponent<Text>();
           c.text = "账号";
           c.color = new Color(0.862745f, 0.827451f, 0.827451f, 1.000000f);
           c.fontSize = 23;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = true;
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
        { var c = goMap[6330686935579603030L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "账号"},{"mTermSecondary", "common_zh"},{"PrimaryTermModifier", 0},{"SecondaryTermModifier", 0},{"TermPrefix", ""},{"TermSuffix", ""},{"LocalizeOnAwake", 1},{"IgnoreRTL", 0},{"MaxCharactersInRTL", 0},{"IgnoreNumbersInRTL", 1},{"CorrectAlignmentForRTL", 1},{"AddSpacesToJoinedLanguages", 0},{"AllowLocalizedParameters", 1},{"AllowParameters", 1},{"AlwaysForceLocalize", 0},{"mGUI_ShowReferences", 0},{"mGUI_ShowTems", 1},{"mGUI_ShowCallback", 0},{"mLocalizeTargetName", "I2.Loc.LocalizeTarget_UnityUI_Text"}});
        }
        { var c = goMap[510372578836138939L].AddComponent<Image>();
           c.color = new Color(0.784314f, 0.811765f, 0.811765f, 1.000000f);
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
        { var c = goMap[510372578836138939L].AddComponent<Outline>();
           c.effectColor = new Color(0.584314f, 0.603922f, 0.603922f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-2900524705604812200L].AddComponent<Text>();
           c.text = "密码";
           c.color = new Color(0.862745f, 0.827451f, 0.827451f, 1.000000f);
           c.fontSize = 23;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = true;
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
        { var c = goMap[-2900524705604812200L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "密码"},{"mTermSecondary", "common_zh"},{"PrimaryTermModifier", 0},{"SecondaryTermModifier", 0},{"TermPrefix", ""},{"TermSuffix", ""},{"LocalizeOnAwake", 1},{"IgnoreRTL", 0},{"MaxCharactersInRTL", 0},{"IgnoreNumbersInRTL", 1},{"CorrectAlignmentForRTL", 1},{"AddSpacesToJoinedLanguages", 0},{"AllowLocalizedParameters", 1},{"AllowParameters", 1},{"AlwaysForceLocalize", 0},{"mGUI_ShowReferences", 0},{"mGUI_ShowTems", 1},{"mGUI_ShowCallback", 0},{"mLocalizeTargetName", "I2.Loc.LocalizeTarget_UnityUI_Text"}});
        }
        { var c = goMap[3938945099341229646L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.000000f);
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
        { var c = goMap[3938945099341229646L].AddComponent<UIDealEmojiInput>();
           c.enabled = true;
        }
        { var c = goMap[-1321269842105272742L].AddComponent<Text>();
           c.text = "请输入账号";
           c.color = new Color(0.603774f, 0.603774f, 0.603774f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Italic;
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
        { var c = goMap[-1321269842105272742L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "请输入账号"},{"mTermSecondary", "common_zh"},{"PrimaryTermModifier", 0},{"SecondaryTermModifier", 0},{"TermPrefix", ""},{"TermSuffix", ""},{"LocalizeOnAwake", 1},{"IgnoreRTL", 0},{"MaxCharactersInRTL", 0},{"IgnoreNumbersInRTL", 1},{"CorrectAlignmentForRTL", 1},{"AddSpacesToJoinedLanguages", 0},{"AllowLocalizedParameters", 1},{"AllowParameters", 1},{"AlwaysForceLocalize", 0},{"mGUI_ShowReferences", 0},{"mGUI_ShowTems", 1},{"mGUI_ShowCallback", 0},{"mLocalizeTargetName", "I2.Loc.LocalizeTarget_UnityUI_Text"}});
        }
        { var c = goMap[-1323056984077052894L].AddComponent<Text>();
           c.text = "";
           c.color = new Color(0.941176f, 0.941176f, 0.941176f, 1.000000f);
           c.fontSize = 22;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = false;
           c.horizontalOverflow = HorizontalWrapMode.Overflow;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 40;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-1323056984077052894L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "dynamic_change_from_script"},{"mTermSecondary", "common_zh"},{"PrimaryTermModifier", 0},{"SecondaryTermModifier", 0},{"TermPrefix", ""},{"TermSuffix", ""},{"LocalizeOnAwake", 1},{"IgnoreRTL", 0},{"MaxCharactersInRTL", 0},{"IgnoreNumbersInRTL", 1},{"CorrectAlignmentForRTL", 1},{"AddSpacesToJoinedLanguages", 0},{"AllowLocalizedParameters", 1},{"AllowParameters", 1},{"AlwaysForceLocalize", 0},{"mGUI_ShowReferences", 0},{"mGUI_ShowTems", 1},{"mGUI_ShowCallback", 0},{"mLocalizeTargetName", "I2.Loc.LocalizeTarget_UnityUI_Text"}});
        }
        { var c = goMap[409035814923731511L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.000000f);
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
        { var c = goMap[409035814923731511L].AddComponent<UIDealEmojiInput>();
           c.enabled = true;
        }
        { var c = goMap[-2140165931822314807L].AddComponent<Text>();
           c.text = "请输入密码";
           c.color = new Color(0.603922f, 0.603922f, 0.603922f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Italic;
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
        { var c = goMap[-2140165931822314807L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "请输入密码"},{"mTermSecondary", "common_zh"},{"PrimaryTermModifier", 0},{"SecondaryTermModifier", 0},{"TermPrefix", ""},{"TermSuffix", ""},{"LocalizeOnAwake", 1},{"IgnoreRTL", 0},{"MaxCharactersInRTL", 0},{"IgnoreNumbersInRTL", 1},{"CorrectAlignmentForRTL", 1},{"AddSpacesToJoinedLanguages", 0},{"AllowLocalizedParameters", 1},{"AllowParameters", 1},{"AlwaysForceLocalize", 0},{"mGUI_ShowReferences", 0},{"mGUI_ShowTems", 1},{"mGUI_ShowCallback", 0},{"mLocalizeTargetName", "I2.Loc.LocalizeTarget_UnityUI_Text"}});
        }
        { var c = goMap[-4752530702791096079L].AddComponent<Text>();
           c.text = "";
           c.color = new Color(0.941176f, 0.941176f, 0.941176f, 1.000000f);
           c.fontSize = 22;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = false;
           c.horizontalOverflow = HorizontalWrapMode.Overflow;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 40;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-4752530702791096079L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "dynamic_change_from_script"},{"mTermSecondary", "common_zh"},{"PrimaryTermModifier", 0},{"SecondaryTermModifier", 0},{"TermPrefix", ""},{"TermSuffix", ""},{"LocalizeOnAwake", 1},{"IgnoreRTL", 0},{"MaxCharactersInRTL", 0},{"IgnoreNumbersInRTL", 1},{"CorrectAlignmentForRTL", 1},{"AddSpacesToJoinedLanguages", 0},{"AllowLocalizedParameters", 1},{"AllowParameters", 1},{"AlwaysForceLocalize", 0},{"mGUI_ShowReferences", 0},{"mGUI_ShowTems", 1},{"mGUI_ShowCallback", 0},{"mLocalizeTargetName", "I2.Loc.LocalizeTarget_UnityUI_Text"}});
        }
        { var c = goMap[3408246909575946839L].AddComponent<Toggle>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"toggleTransition", 1}});
        }
        { var c = goMap[3408246909575946839L].AddComponent<Image>();
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
           c.enabled = false;
           c.sprite = LookupSprite("img_white");
        }
        { var c = goMap[-3264826014631784969L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.784314f);
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
           c.sprite = LookupSprite("common_toggle");
        }
        { var c = goMap[2954057030242465022L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_checkmark");
        }
        { var c = goMap[-3028824380545492527L].AddComponent<Text>();
           c.text = "记住账号";
           c.color = new Color(0.862745f, 0.827451f, 0.827451f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
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
        { var c = goMap[-3028824380545492527L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "记住账号"},{"mTermSecondary", "common_zh"},{"PrimaryTermModifier", 0},{"SecondaryTermModifier", 0},{"TermPrefix", ""},{"TermSuffix", ""},{"LocalizeOnAwake", 1},{"IgnoreRTL", 0},{"MaxCharactersInRTL", 0},{"IgnoreNumbersInRTL", 1},{"CorrectAlignmentForRTL", 1},{"AddSpacesToJoinedLanguages", 0},{"AllowLocalizedParameters", 1},{"AllowParameters", 1},{"AlwaysForceLocalize", 0},{"mGUI_ShowReferences", 0},{"mGUI_ShowTems", 1},{"mGUI_ShowCallback", 0},{"mLocalizeTargetName", "I2.Loc.LocalizeTarget_UnityUI_Text"}});
        }
        { var c = goMap[1486408382902650638L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.000000f);
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
        { var c = goMap[3198215296030496653L].AddComponent<Text>();
           c.text = "注册账号";
           c.color = new Color(0.396078f, 0.984314f, 0.396078f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
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
        { var c = goMap[3198215296030496653L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "注册账号"},{"mTermSecondary", "common_zh"},{"PrimaryTermModifier", 0},{"SecondaryTermModifier", 0},{"TermPrefix", ""},{"TermSuffix", ""},{"LocalizeOnAwake", 1},{"IgnoreRTL", 0},{"MaxCharactersInRTL", 0},{"IgnoreNumbersInRTL", 1},{"CorrectAlignmentForRTL", 1},{"AddSpacesToJoinedLanguages", 0},{"AllowLocalizedParameters", 1},{"AllowParameters", 1},{"AlwaysForceLocalize", 0},{"mGUI_ShowReferences", 0},{"mGUI_ShowTems", 1},{"mGUI_ShowCallback", 0},{"mLocalizeTargetName", "I2.Loc.LocalizeTarget_UnityUI_Text"}});
        }
        { var c = goMap[740882908957158691L].AddComponent<Image>();
           c.color = new Color(0.396078f, 0.984314f, 0.396078f, 1.000000f);
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
        { var c = goMap[-7209637982974084092L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.000000f);
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
        { var c = goMap[-1191758205968235226L].AddComponent<Text>();
           c.text = "忘记密码";
           c.color = new Color(0.396078f, 0.984314f, 0.396078f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
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
        { var c = goMap[-1191758205968235226L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "忘记密码"},{"mTermSecondary", "common_zh"},{"PrimaryTermModifier", 0},{"SecondaryTermModifier", 0},{"TermPrefix", ""},{"TermSuffix", ""},{"LocalizeOnAwake", 1},{"IgnoreRTL", 0},{"MaxCharactersInRTL", 0},{"IgnoreNumbersInRTL", 1},{"CorrectAlignmentForRTL", 1},{"AddSpacesToJoinedLanguages", 0},{"AllowLocalizedParameters", 1},{"AllowParameters", 1},{"AlwaysForceLocalize", 0},{"mGUI_ShowReferences", 0},{"mGUI_ShowTems", 1},{"mGUI_ShowCallback", 0},{"mLocalizeTargetName", "I2.Loc.LocalizeTarget_UnityUI_Text"}});
        }
        { var c = goMap[3027630945157291835L].AddComponent<Image>();
           c.color = new Color(0.396078f, 0.984314f, 0.396078f, 1.000000f);
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
        { var c = goMap[-3220662619355526429L].AddComponent<Text>();
           c.text = "当前大区";
           c.color = new Color(0.960784f, 0.890196f, 0.298039f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleRight;
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
        { var c = goMap[-3220662619355526429L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "当前大区"},{"mTermSecondary", "common_zh"},{"PrimaryTermModifier", 0},{"SecondaryTermModifier", 0},{"TermPrefix", ""},{"TermSuffix", ""},{"LocalizeOnAwake", 1},{"IgnoreRTL", 0},{"MaxCharactersInRTL", 0},{"IgnoreNumbersInRTL", 1},{"CorrectAlignmentForRTL", 1},{"AddSpacesToJoinedLanguages", 0},{"AllowLocalizedParameters", 1},{"AllowParameters", 1},{"AlwaysForceLocalize", 0},{"mGUI_ShowReferences", 0},{"mGUI_ShowTems", 1},{"mGUI_ShowCallback", 0},{"mLocalizeTargetName", "I2.Loc.LocalizeTarget_UnityUI_Text"}});
        }
        { var c = goMap[-1806731902761475707L].AddComponent<Text>();
           c.text = "内网127.127.127.127";
           c.color = new Color(0.960784f, 0.890196f, 0.298039f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleLeft;
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
        { var c = goMap[-1806731902761475707L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "2104"},{"mTermSecondary", "common_zh"},{"PrimaryTermModifier", 0},{"SecondaryTermModifier", 0},{"TermPrefix", ""},{"TermSuffix", ""},{"LocalizeOnAwake", 1},{"IgnoreRTL", 0},{"MaxCharactersInRTL", 0},{"IgnoreNumbersInRTL", 1},{"CorrectAlignmentForRTL", 1},{"AddSpacesToJoinedLanguages", 0},{"AllowLocalizedParameters", 1},{"AllowParameters", 1},{"AlwaysForceLocalize", 0},{"mGUI_ShowReferences", 0},{"mGUI_ShowTems", 1},{"mGUI_ShowCallback", 0},{"mLocalizeTargetName", "I2.Loc.LocalizeTarget_UnityUI_Text"}});
        }
        { var c = goMap[9198468259966897890L].AddComponent<Image>();
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
           c.sprite = LookupSprite("btn_common1_1");
        }
        { var c = goMap[9198468259966897890L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[9198468259966897890L].AddComponent<UIAnimScaleDown>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"AnimTime", 0.100000f},{"DownToScale", 0.950000f}});
        }
        { var c = goMap[2989608131843237764L].AddComponent<Text>();
           c.text = "更改大区";
           c.color = new Color(0.113725f, 0.309804f, 0.321569f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Normal;
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
        { var c = goMap[2989608131843237764L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "更改大区"},{"mTermSecondary", "common_zh"},{"PrimaryTermModifier", 0},{"SecondaryTermModifier", 0},{"TermPrefix", ""},{"TermSuffix", ""},{"LocalizeOnAwake", 1},{"IgnoreRTL", 0},{"MaxCharactersInRTL", 0},{"IgnoreNumbersInRTL", 1},{"CorrectAlignmentForRTL", 1},{"AddSpacesToJoinedLanguages", 0},{"AllowLocalizedParameters", 1},{"AllowParameters", 1},{"AlwaysForceLocalize", 0},{"mGUI_ShowReferences", 0},{"mGUI_ShowTems", 1},{"mGUI_ShowCallback", 0},{"mLocalizeTargetName", "I2.Loc.LocalizeTarget_UnityUI_Text"}});
        }
        { var c = goMap[-2654001819065670792L].AddComponent<Image>();
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
        }
        { var c = goMap[2285784091670728775L].AddComponent<Text>();
           c.text = "<color=#ff0000ff>此界面仅编辑器下显示</color>\n\n当需要从编辑器通过白名单进入外网环境时才需要选择，<color=#ff0000ff>选择的是你外网账号登录的手机平台</color>，其它情况忽略\n\n选择平台：\n";
           c.color = new Color(0.196078f, 0.196078f, 0.196078f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.UpperLeft;
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
        { var c = goMap[2285784091670728775L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "26057"},{"mTermSecondary", "common_zh"},{"PrimaryTermModifier", 0},{"SecondaryTermModifier", 0},{"TermPrefix", ""},{"TermSuffix", ""},{"LocalizeOnAwake", 1},{"IgnoreRTL", 0},{"MaxCharactersInRTL", 0},{"IgnoreNumbersInRTL", 1},{"CorrectAlignmentForRTL", 1},{"AddSpacesToJoinedLanguages", 0},{"AllowLocalizedParameters", 1},{"AllowParameters", 1},{"AlwaysForceLocalize", 0},{"mGUI_ShowReferences", 0},{"mGUI_ShowTems", 1},{"mGUI_ShowCallback", 0},{"mLocalizeTargetName", "I2.Loc.LocalizeTarget_UnityUI_Text"}});
        }
        { var c = goMap[-9150077196022877136L].AddComponent<Toggle>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"toggleTransition", 1}});
        }
        { var c = goMap[532213880791618148L].AddComponent<Image>();
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
        }
        { var c = goMap[7565429519185754554L].AddComponent<Image>();
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
        { var c = goMap[-7705758488480704023L].AddComponent<Text>();
           c.text = " PC";
           c.color = new Color(0.196078f, 0.196078f, 0.196078f, 1.000000f);
           c.fontSize = 14;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleLeft;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 10;
           c.resizeTextMaxSize = 40;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-7705758488480704023L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "dynamic_change_from_script"},{"mTermSecondary", "common_zh"},{"PrimaryTermModifier", 0},{"SecondaryTermModifier", 0},{"TermPrefix", ""},{"TermSuffix", ""},{"LocalizeOnAwake", 1},{"IgnoreRTL", 0},{"MaxCharactersInRTL", 0},{"IgnoreNumbersInRTL", 1},{"CorrectAlignmentForRTL", 1},{"AddSpacesToJoinedLanguages", 0},{"AllowLocalizedParameters", 1},{"AllowParameters", 1},{"AlwaysForceLocalize", 0},{"mGUI_ShowReferences", 0},{"mGUI_ShowTems", 1},{"mGUI_ShowCallback", 0},{"mLocalizeTargetName", "I2.Loc.LocalizeTarget_UnityUI_Text"}});
        }
        { var c = goMap[6983251550178796478L].AddComponent<Toggle>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"toggleTransition", 1}});
        }
        { var c = goMap[5511621679902880547L].AddComponent<Image>();
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
        }
        { var c = goMap[8980104210362642417L].AddComponent<Image>();
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
        { var c = goMap[-2915151790377423669L].AddComponent<Text>();
           c.text = " iOS";
           c.color = new Color(0.196078f, 0.196078f, 0.196078f, 1.000000f);
           c.fontSize = 14;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleLeft;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 10;
           c.resizeTextMaxSize = 40;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-2915151790377423669L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "dynamic_change_from_script"},{"mTermSecondary", "common_zh"},{"PrimaryTermModifier", 0},{"SecondaryTermModifier", 0},{"TermPrefix", ""},{"TermSuffix", ""},{"LocalizeOnAwake", 1},{"IgnoreRTL", 0},{"MaxCharactersInRTL", 0},{"IgnoreNumbersInRTL", 1},{"CorrectAlignmentForRTL", 1},{"AddSpacesToJoinedLanguages", 0},{"AllowLocalizedParameters", 1},{"AllowParameters", 1},{"AlwaysForceLocalize", 0},{"mGUI_ShowReferences", 0},{"mGUI_ShowTems", 1},{"mGUI_ShowCallback", 0},{"mLocalizeTargetName", "I2.Loc.LocalizeTarget_UnityUI_Text"}});
        }
        { var c = goMap[5139040020343021124L].AddComponent<Toggle>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"toggleTransition", 1}});
        }
        { var c = goMap[-8905912453469056538L].AddComponent<Image>();
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
        }
        { var c = goMap[6431776791569506784L].AddComponent<Image>();
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
        { var c = goMap[7177278377188989178L].AddComponent<Text>();
           c.text = " Android";
           c.color = new Color(0.196078f, 0.196078f, 0.196078f, 1.000000f);
           c.fontSize = 14;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleLeft;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 10;
           c.resizeTextMaxSize = 40;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[7177278377188989178L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "dynamic_change_from_script"},{"mTermSecondary", "common_zh"},{"PrimaryTermModifier", 0},{"SecondaryTermModifier", 0},{"TermPrefix", ""},{"TermSuffix", ""},{"LocalizeOnAwake", 1},{"IgnoreRTL", 0},{"MaxCharactersInRTL", 0},{"IgnoreNumbersInRTL", 1},{"CorrectAlignmentForRTL", 1},{"AddSpacesToJoinedLanguages", 0},{"AllowLocalizedParameters", 1},{"AllowParameters", 1},{"AlwaysForceLocalize", 0},{"mGUI_ShowReferences", 0},{"mGUI_ShowTems", 1},{"mGUI_ShowCallback", 0},{"mLocalizeTargetName", "I2.Loc.LocalizeTarget_UnityUI_Text"}});
        }
        { var c = goMap[-5846258571111919563L].AddComponent<Toggle>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"toggleTransition", 1}});
        }
        { var c = goMap[-7035891633917960475L].AddComponent<Image>();
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
        }
        { var c = goMap[-6327951899122848638L].AddComponent<Image>();
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
        { var c = goMap[-956569705120667222L].AddComponent<Text>();
           c.text = "Mix";
           c.color = new Color(0.196078f, 0.196078f, 0.196078f, 1.000000f);
           c.fontSize = 14;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleLeft;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 10;
           c.resizeTextMaxSize = 40;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-956569705120667222L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "dynamic_change_from_script"},{"mTermSecondary", "common_zh"},{"PrimaryTermModifier", 0},{"SecondaryTermModifier", 0},{"TermPrefix", ""},{"TermSuffix", ""},{"LocalizeOnAwake", 1},{"IgnoreRTL", 0},{"MaxCharactersInRTL", 0},{"IgnoreNumbersInRTL", 1},{"CorrectAlignmentForRTL", 1},{"AddSpacesToJoinedLanguages", 0},{"AllowLocalizedParameters", 1},{"AllowParameters", 1},{"AlwaysForceLocalize", 0},{"mGUI_ShowReferences", 0},{"mGUI_ShowTems", 1},{"mGUI_ShowCallback", 0},{"mLocalizeTargetName", "I2.Loc.LocalizeTarget_UnityUI_Text"}});
        }
        { var c = goMap[-4137217204506836836L].AddComponent<Text>();
           c.text = "语言";
           c.color = new Color(0.196078f, 0.196078f, 0.196078f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleLeft;
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
        { var c = goMap[-4137217204506836836L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "1372"},{"mTermSecondary", "common_zh"},{"PrimaryTermModifier", 0},{"SecondaryTermModifier", 0},{"TermPrefix", ""},{"TermSuffix", ""},{"LocalizeOnAwake", 1},{"IgnoreRTL", 0},{"MaxCharactersInRTL", 0},{"IgnoreNumbersInRTL", 1},{"CorrectAlignmentForRTL", 1},{"AddSpacesToJoinedLanguages", 0},{"AllowLocalizedParameters", 1},{"AllowParameters", 1},{"AlwaysForceLocalize", 0},{"mGUI_ShowReferences", 0},{"mGUI_ShowTems", 1},{"mGUI_ShowCallback", 0},{"mLocalizeTargetName", "I2.Loc.LocalizeTarget_UnityUI_Text"}});
        }
        { var c = goMap[-2228882742424832941L].AddComponent<Image>();
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
        }
        { var c = goMap[-1457697452122017427L].AddComponent<Text>();
           c.text = "";
           c.color = new Color(0.196078f, 0.196078f, 0.196078f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleLeft;
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
        { var c = goMap[-1457697452122017427L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "dynamic_change_from_script"},{"mTermSecondary", "common_zh"},{"PrimaryTermModifier", 0},{"SecondaryTermModifier", 0},{"TermPrefix", ""},{"TermSuffix", ""},{"LocalizeOnAwake", 1},{"IgnoreRTL", 0},{"MaxCharactersInRTL", 0},{"IgnoreNumbersInRTL", 1},{"CorrectAlignmentForRTL", 1},{"AddSpacesToJoinedLanguages", 0},{"AllowLocalizedParameters", 1},{"AllowParameters", 1},{"AlwaysForceLocalize", 0},{"mGUI_ShowReferences", 0},{"mGUI_ShowTems", 1},{"mGUI_ShowCallback", 0},{"mLocalizeTargetName", "I2.Loc.LocalizeTarget_UnityUI_Text"}});
        }
        { var c = goMap[1774440990325404704L].AddComponent<Image>();
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
        { var c = goMap[-6640051572024578214L].AddComponent<Image>();
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
        }
        { var c = goMap[-3198845291674568655L].AddComponent<Image>();
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
        }
        { var c = goMap[-3198845291674568655L].AddComponent<Mask>();
           c.showMaskGraphic = false;
           c.enabled = true;
        }
        { var c = goMap[5431699452823915283L].AddComponent<Toggle>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"toggleTransition", 1}});
        }
        { var c = goMap[6699230820125197428L].AddComponent<Image>();
           c.color = new Color(0.960784f, 0.960784f, 0.960784f, 1.000000f);
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
        { var c = goMap[2042272082762107293L].AddComponent<Image>();
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
        { var c = goMap[-2645315664051713667L].AddComponent<Text>();
           c.text = "Option A";
           c.color = new Color(0.196078f, 0.196078f, 0.196078f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleLeft;
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
        { var c = goMap[-2645315664051713667L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "dynamic_change_from_script"},{"mTermSecondary", "common_zh"},{"PrimaryTermModifier", 0},{"SecondaryTermModifier", 0},{"TermPrefix", ""},{"TermSuffix", ""},{"LocalizeOnAwake", 1},{"IgnoreRTL", 0},{"MaxCharactersInRTL", 0},{"IgnoreNumbersInRTL", 1},{"CorrectAlignmentForRTL", 1},{"AddSpacesToJoinedLanguages", 0},{"AllowLocalizedParameters", 1},{"AllowParameters", 1},{"AlwaysForceLocalize", 0},{"mGUI_ShowReferences", 0},{"mGUI_ShowTems", 1},{"mGUI_ShowCallback", 0},{"mLocalizeTargetName", "I2.Loc.LocalizeTarget_UnityUI_Text"}});
        }
        { var c = goMap[1316121078678036205L].AddComponent<Image>();
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
        }
        { var c = goMap[6696452328744356773L].AddComponent<Image>();
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
        }

        // ─── Save prefab ─────────────────────────────────────
        Directory.CreateDirectory("Assets/Prefabs/Imported");
        var rootGO = goMap[-959427722286098252L];
        string path = "Assets/Prefabs/Imported/UILoginChannelInner.prefab";
        PrefabUtility.SaveAsPrefabAsset(rootGO, path);
        Object.DestroyImmediate(rootGO);
        Debug.Log("[Import_res_p_135] Saved " + path);
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