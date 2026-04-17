// AUTO-GENERATED from res_p_560.ab — DO NOT EDIT MANUALLY.
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;
using System.Collections.Generic;
using KTO.Game;  // UIJoyStick and other ported KTO scripts

public class Import_res_p_560
{
    [MenuItem("KTO/Import/res_p_560")]
    public static void Build()
    {
        Debug.Log("[Import_res_p_560] Building UILegionList...");

        // ─── Create all GameObjects ───────────────────────────
        var goMap = new Dictionary<long, GameObject>();
        var _toggleGroupByMbPid = new Dictionary<long, ToggleGroup>();
        var _toggleGroupLinks = new List<System.Tuple<Toggle,long>>();
        { var go = new GameObject("UILegionList"); go.SetActive(true); goMap[8333513703502013360L] = go; }
        { var go = new GameObject("node"); go.SetActive(true); goMap[-5652739408178728748L] = go; }
        { var go = new GameObject("UIBg3"); go.SetActive(true); goMap[-1856427607681994877L] = go; }
        { var go = new GameObject("panel"); go.SetActive(true); goMap[1960977720905454994L] = go; }
        { var go = new GameObject("imgShadow1"); go.SetActive(true); goMap[-6006531979814469218L] = go; }
        { var go = new GameObject("imgShadow2"); go.SetActive(true); goMap[4470454166698919303L] = go; }
        { var go = new GameObject("imgShadow3"); go.SetActive(true); goMap[8187253934611388427L] = go; }
        { var go = new GameObject("imgShadow4"); go.SetActive(true); goMap[-5698870741786211429L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(true); goMap[1650956028367450543L] = go; }
        { var go = new GameObject("imgTitleBg1"); go.SetActive(true); goMap[-5534520209645894546L] = go; }
        { var go = new GameObject("imgReflection"); go.SetActive(true); goMap[2186017438670053093L] = go; }
        { var go = new GameObject("imgBorderline1"); go.SetActive(true); goMap[-5918661392330402205L] = go; }
        { var go = new GameObject("imgBorderline2"); go.SetActive(true); goMap[6067164632782053589L] = go; }
        { var go = new GameObject("imgBorderline3"); go.SetActive(true); goMap[1858695571710979592L] = go; }
        { var go = new GameObject("imgBorderline4"); go.SetActive(true); goMap[-6269261675786623964L] = go; }
        { var go = new GameObject("imgListBg"); go.SetActive(true); goMap[-8702597175766861309L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(false); goMap[7025520231562002625L] = go; }
        { var go = new GameObject("imgBG"); go.SetActive(true); goMap[705931453392185196L] = go; }
        { var go = new GameObject("btnClose"); go.SetActive(true); goMap[2846580321834405285L] = go; }
        { var go = new GameObject("txtTitle"); go.SetActive(true); goMap[5262827841072762729L] = go; }
        { var go = new GameObject("btnHelp"); go.SetActive(true); goMap[1747644429056159886L] = go; }
        { var go = new GameObject("Content"); go.SetActive(true); goMap[1842583571085126202L] = go; }
        { var go = new GameObject("imgTitleBg"); go.SetActive(true); goMap[331820019492967284L] = go; }
        { var go = new GameObject("LegionListTitle"); go.SetActive(true); goMap[1094901167232336962L] = go; }
        { var go = new GameObject("txtLegionName"); go.SetActive(true); goMap[4789737931827383410L] = go; }
        { var go = new GameObject("txtName"); go.SetActive(true); goMap[-4404994934219393708L] = go; }
        { var go = new GameObject("txtNum"); go.SetActive(true); goMap[-6130378619370303046L] = go; }
        { var go = new GameObject("imgList"); go.SetActive(true); goMap[-943479867263271517L] = go; }
        { var go = new GameObject("NotInfo"); go.SetActive(false); goMap[4983719005265024412L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[2703750280844409999L] = go; }
        { var go = new GameObject("List"); go.SetActive(true); goMap[6719711673735463485L] = go; }
        { var go = new GameObject("Template"); go.SetActive(true); goMap[4365494065112725512L] = go; }
        { var go = new GameObject("imgSelect"); go.SetActive(false); goMap[-8999341241742500684L] = go; }
        { var go = new GameObject("imgApplied"); go.SetActive(true); goMap[8634289450413056485L] = go; }
        { var go = new GameObject("txtLegionName"); go.SetActive(true); goMap[-5272920532523974082L] = go; }
        { var go = new GameObject("txtNum"); go.SetActive(true); goMap[2530555090319767430L] = go; }
        { var go = new GameObject("txtName"); go.SetActive(true); goMap[-1077567397746307028L] = go; }
        { var go = new GameObject("imgVip"); go.SetActive(true); goMap[-6268152050561212721L] = go; }
        { var go = new GameObject("btnPrevious"); go.SetActive(true); goMap[-2940136767623287974L] = go; }
        { var go = new GameObject("btnNext"); go.SetActive(true); goMap[7174244297624026525L] = go; }
        { var go = new GameObject("txtPage"); go.SetActive(true); goMap[7993875992157196324L] = go; }
        { var go = new GameObject("Right"); go.SetActive(true); goMap[-1254424532928222404L] = go; }
        { var go = new GameObject("txtLegionName"); go.SetActive(true); goMap[1281840494644361357L] = go; }
        { var go = new GameObject("LegionNotice"); go.SetActive(true); goMap[-5249490333070509839L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(true); goMap[1942917847274168094L] = go; }
        { var go = new GameObject("titlebg"); go.SetActive(true); goMap[-265814872301517376L] = go; }
        { var go = new GameObject("txtTitle"); go.SetActive(true); goMap[7052023076351760310L] = go; }
        { var go = new GameObject("txtContent"); go.SetActive(true); goMap[-1644515507954222302L] = go; }
        { var go = new GameObject("GridBtn"); go.SetActive(true); goMap[-5566908765242769895L] = go; }
        { var go = new GameObject("btnMatch"); go.SetActive(false); goMap[4523316696948600479L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-7785539448494488050L] = go; }
        { var go = new GameObject("btnCreate"); go.SetActive(true); goMap[2366566514074819487L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-6187784514028866133L] = go; }
        { var go = new GameObject("btnGo"); go.SetActive(true); goMap[-248715242524579454L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[2204212955391298851L] = go; }
        { var go = new GameObject("txtLegionTips"); go.SetActive(true); goMap[1309978226104064471L] = go; }

        // ─── Parent links ─────────────────────────────────────
        goMap[-5652739408178728748L].transform.SetParent(goMap[8333513703502013360L].transform, false);
        goMap[-1856427607681994877L].transform.SetParent(goMap[-5652739408178728748L].transform, false);
        goMap[1960977720905454994L].transform.SetParent(goMap[-1856427607681994877L].transform, false);
        goMap[-6006531979814469218L].transform.SetParent(goMap[1960977720905454994L].transform, false);
        goMap[4470454166698919303L].transform.SetParent(goMap[1960977720905454994L].transform, false);
        goMap[8187253934611388427L].transform.SetParent(goMap[1960977720905454994L].transform, false);
        goMap[-5698870741786211429L].transform.SetParent(goMap[1960977720905454994L].transform, false);
        goMap[1650956028367450543L].transform.SetParent(goMap[1960977720905454994L].transform, false);
        goMap[-5534520209645894546L].transform.SetParent(goMap[1960977720905454994L].transform, false);
        goMap[2186017438670053093L].transform.SetParent(goMap[1960977720905454994L].transform, false);
        goMap[-5918661392330402205L].transform.SetParent(goMap[1960977720905454994L].transform, false);
        goMap[6067164632782053589L].transform.SetParent(goMap[1960977720905454994L].transform, false);
        goMap[1858695571710979592L].transform.SetParent(goMap[1960977720905454994L].transform, false);
        goMap[-6269261675786623964L].transform.SetParent(goMap[1960977720905454994L].transform, false);
        goMap[-8702597175766861309L].transform.SetParent(goMap[1960977720905454994L].transform, false);
        goMap[7025520231562002625L].transform.SetParent(goMap[-1856427607681994877L].transform, false);
        goMap[705931453392185196L].transform.SetParent(goMap[-5652739408178728748L].transform, false);
        goMap[2846580321834405285L].transform.SetParent(goMap[705931453392185196L].transform, false);
        goMap[5262827841072762729L].transform.SetParent(goMap[705931453392185196L].transform, false);
        goMap[1747644429056159886L].transform.SetParent(goMap[5262827841072762729L].transform, false);
        goMap[1842583571085126202L].transform.SetParent(goMap[705931453392185196L].transform, false);
        goMap[331820019492967284L].transform.SetParent(goMap[1842583571085126202L].transform, false);
        goMap[1094901167232336962L].transform.SetParent(goMap[1842583571085126202L].transform, false);
        goMap[4789737931827383410L].transform.SetParent(goMap[1094901167232336962L].transform, false);
        goMap[-4404994934219393708L].transform.SetParent(goMap[1094901167232336962L].transform, false);
        goMap[-6130378619370303046L].transform.SetParent(goMap[1094901167232336962L].transform, false);
        goMap[-943479867263271517L].transform.SetParent(goMap[1842583571085126202L].transform, false);
        goMap[4983719005265024412L].transform.SetParent(goMap[-943479867263271517L].transform, false);
        goMap[2703750280844409999L].transform.SetParent(goMap[4983719005265024412L].transform, false);
        goMap[6719711673735463485L].transform.SetParent(goMap[-943479867263271517L].transform, false);
        goMap[4365494065112725512L].transform.SetParent(goMap[6719711673735463485L].transform, false);
        goMap[-8999341241742500684L].transform.SetParent(goMap[4365494065112725512L].transform, false);
        goMap[8634289450413056485L].transform.SetParent(goMap[4365494065112725512L].transform, false);
        goMap[-5272920532523974082L].transform.SetParent(goMap[4365494065112725512L].transform, false);
        goMap[2530555090319767430L].transform.SetParent(goMap[4365494065112725512L].transform, false);
        goMap[-1077567397746307028L].transform.SetParent(goMap[4365494065112725512L].transform, false);
        goMap[-6268152050561212721L].transform.SetParent(goMap[-1077567397746307028L].transform, false);
        goMap[-2940136767623287974L].transform.SetParent(goMap[-943479867263271517L].transform, false);
        goMap[7174244297624026525L].transform.SetParent(goMap[-943479867263271517L].transform, false);
        goMap[7993875992157196324L].transform.SetParent(goMap[-943479867263271517L].transform, false);
        goMap[-1254424532928222404L].transform.SetParent(goMap[1842583571085126202L].transform, false);
        goMap[1281840494644361357L].transform.SetParent(goMap[-1254424532928222404L].transform, false);
        goMap[-5249490333070509839L].transform.SetParent(goMap[-1254424532928222404L].transform, false);
        goMap[1942917847274168094L].transform.SetParent(goMap[-5249490333070509839L].transform, false);
        goMap[-265814872301517376L].transform.SetParent(goMap[-5249490333070509839L].transform, false);
        goMap[7052023076351760310L].transform.SetParent(goMap[-5249490333070509839L].transform, false);
        goMap[-1644515507954222302L].transform.SetParent(goMap[-5249490333070509839L].transform, false);
        goMap[-5566908765242769895L].transform.SetParent(goMap[-1254424532928222404L].transform, false);
        goMap[4523316696948600479L].transform.SetParent(goMap[-5566908765242769895L].transform, false);
        goMap[-7785539448494488050L].transform.SetParent(goMap[4523316696948600479L].transform, false);
        goMap[2366566514074819487L].transform.SetParent(goMap[-5566908765242769895L].transform, false);
        goMap[-6187784514028866133L].transform.SetParent(goMap[2366566514074819487L].transform, false);
        goMap[-248715242524579454L].transform.SetParent(goMap[-5566908765242769895L].transform, false);
        goMap[2204212955391298851L].transform.SetParent(goMap[-248715242524579454L].transform, false);
        goMap[1309978226104064471L].transform.SetParent(goMap[-1254424532928222404L].transform, false);

        // ─── RectTransforms ──────────────────────────────────
        {
            var rt = goMap[8333513703502013360L].AddComponent<RectTransform>();
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
            var rt = goMap[-5652739408178728748L].AddComponent<RectTransform>();
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
            var rt = goMap[-1856427607681994877L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(1280.000000f, 720.000000f);
        }
        {
            var rt = goMap[1960977720905454994L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(1066.000000f, 590.000000f);
        }
        {
            var rt = goMap[-6006531979814469218L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(107.471390f, -30.212299f);
            rt.sizeDelta = new Vector2(945.266724f, 586.456482f);
        }
        {
            var rt = goMap[4470454166698919303L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,0.707107f,0.707107f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(46.743221f, 293.897156f);
            rt.sizeDelta = new Vector2(61.576401f, 1071.143555f);
        }
        {
            var rt = goMap[8187253934611388427L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,0.707107f,-0.707107f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-476.009277f, -67.044266f);
            rt.sizeDelta = new Vector2(509.189911f, 221.833496f);
        }
        {
            var rt = goMap[-5698870741786211429L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,1.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-536.710205f, 257.139191f);
            rt.sizeDelta = new Vector2(95.670097f, 139.164902f);
        }
        {
            var rt = goMap[1650956028367450543L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-1.800000f, -22.000000f);
            rt.sizeDelta = new Vector2(1156.000000f, 590.000000f);
        }
        {
            var rt = goMap[-5534520209645894546L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-1.800000f, 285.200012f);
            rt.sizeDelta = new Vector2(1156.000000f, 68.000000f);
        }
        {
            var rt = goMap[2186017438670053093L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-2.043800f, 317.453949f);
            rt.sizeDelta = new Vector2(1137.783203f, 1.094200f);
        }
        {
            var rt = goMap[-5918661392330402205L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(149.324615f, -88.713608f);
            rt.sizeDelta = new Vector2(856.968872f, 461.197815f);
        }
        {
            var rt = goMap[6067164632782053589L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,0.707107f,0.707107f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(235.919006f, 232.355240f);
            rt.sizeDelta = new Vector2(180.937607f, 683.796875f);
        }
        {
            var rt = goMap[1858695571710979592L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,0.707107f,-0.707107f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-430.495575f, -74.036812f);
            rt.sizeDelta = new Vector2(490.550812f, 302.671814f);
        }
        {
            var rt = goMap[-6269261675786623964L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,1.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-343.904022f, 247.034073f);
            rt.sizeDelta = new Vector2(475.855408f, 151.591202f);
        }
        {
            var rt = goMap[-8702597175766861309L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-170.600006f, 8.800000f);
            rt.sizeDelta = new Vector2(800.700012f, 501.899994f);
        }
        {
            var rt = goMap[7025520231562002625L].AddComponent<RectTransform>();
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
            var rt = goMap[705931453392185196L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(1168.000000f, 644.000000f);
        }
        {
            var rt = goMap[2846580321834405285L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 1.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-35.000000f, -31.000000f);
            rt.sizeDelta = new Vector2(49.000000f, 54.000000f);
        }
        {
            var rt = goMap[5262827841072762729L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-570.000000f, 293.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 58.000000f);
        }
        {
            var rt = goMap[1747644429056159886L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 90.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.500000f);
            rt.anchorMax = new Vector2(1.000000f, 0.500000f);
            rt.pivot = new Vector2(1.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(56.400002f, -1.799988f);
            rt.sizeDelta = new Vector2(49.000000f, 54.000000f);
        }
        {
            var rt = goMap[1842583571085126202L].AddComponent<RectTransform>();
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
            var rt = goMap[331820019492967284L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-171.500046f, 239.300003f);
            rt.sizeDelta = new Vector2(790.000000f, 30.000000f);
        }
        {
            var rt = goMap[1094901167232336962L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-121.500000f, 190.300018f);
            rt.sizeDelta = new Vector2(780.000000f, 30.000000f);
        }
        {
            var rt = goMap[4789737931827383410L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-267.100006f, -0.799988f);
            rt.sizeDelta = new Vector2(130.000000f, 35.799999f);
        }
        {
            var rt = goMap[-4404994934219393708L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(12.099976f, -0.799988f);
            rt.sizeDelta = new Vector2(130.000000f, 35.799999f);
        }
        {
            var rt = goMap[-6130378619370303046L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(262.399994f, -0.799988f);
            rt.sizeDelta = new Vector2(80.000000f, 35.799999f);
        }
        {
            var rt = goMap[-943479867263271517L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-171.500000f, -43.291004f);
            rt.sizeDelta = new Vector2(788.000000f, 524.817993f);
        }
        {
            var rt = goMap[4983719005265024412L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-27.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(214.000000f, 100.000000f);
        }
        {
            var rt = goMap[2703750280844409999L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(214.000000f, 100.000000f);
        }
        {
            var rt = goMap[6719711673735463485L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 1.000000f);
            rt.anchorMax = new Vector2(0.500000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 1.000000f);
            rt.anchoredPosition = new Vector2(0.000000f, -0.000031f);
            rt.sizeDelta = new Vector2(788.000000f, 0.000000f);
        }
        {
            var rt = goMap[4365494065112725512L].AddComponent<RectTransform>();
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
            var rt = goMap[-8999341241742500684L].AddComponent<RectTransform>();
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
            var rt = goMap[8634289450413056485L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(0.800000f, 0.800000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-365.000000f, 0.700000f);
            rt.sizeDelta = new Vector2(40.000000f, 40.000000f);
        }
        {
            var rt = goMap[-5272920532523974082L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-265.099976f, 0.000000f);
            rt.sizeDelta = new Vector2(150.000000f, 37.299999f);
        }
        {
            var rt = goMap[2530555090319767430L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(263.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(60.000000f, 40.000000f);
        }
        {
            var rt = goMap[-1077567397746307028L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(15.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 37.299999f);
        }
        {
            var rt = goMap[-6268152050561212721L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.700000f, 0.700000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.500000f);
            rt.anchorMax = new Vector2(1.000000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(11.200000f, 0.000000f);
            rt.sizeDelta = new Vector2(32.000000f, 32.000000f);
        }
        {
            var rt = goMap[-2940136767623287974L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-110.000000f, -230.000000f);
            rt.sizeDelta = new Vector2(48.000000f, 52.000000f);
        }
        {
            var rt = goMap[7174244297624026525L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(110.000000f, -230.000000f);
            rt.sizeDelta = new Vector2(48.000000f, 52.000000f);
        }
        {
            var rt = goMap[7993875992157196324L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -230.100006f);
            rt.sizeDelta = new Vector2(160.000000f, 40.000000f);
        }
        {
            var rt = goMap[-1254424532928222404L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(401.689697f, -19.245001f);
            rt.sizeDelta = new Vector2(347.378998f, 572.489990f);
        }
        {
            var rt = goMap[1281840494644361357L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.000000f, 236.899994f);
            rt.sizeDelta = new Vector2(200.000000f, 50.000000f);
        }
        {
            var rt = goMap[-5249490333070509839L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 1.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-174.600143f, -199.500000f);
            rt.sizeDelta = new Vector2(330.000000f, 251.884995f);
        }
        {
            var rt = goMap[1942917847274168094L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 1.000000f);
            rt.anchoredPosition = new Vector2(0.000000f, 90.666977f);
            rt.sizeDelta = new Vector2(330.000000f, 352.282898f);
        }
        {
            var rt = goMap[-265814872301517376L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-10.000000f, 107.500000f);
            rt.sizeDelta = new Vector2(100.000000f, 15.000000f);
        }
        {
            var rt = goMap[7052023076351760310L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 1.000000f);
            rt.anchorMax = new Vector2(0.500000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-112.500023f, -17.638000f);
            rt.sizeDelta = new Vector2(105.000000f, 35.275002f);
        }
        {
            var rt = goMap[-1644515507954222302L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.304700f, 15.506100f);
            rt.sizeDelta = new Vector2(311.151306f, 128.420395f);
        }
        {
            var rt = goMap[-5566908765242769895L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 0.000000f);
            rt.pivot = new Vector2(1.000000f, 0.000000f);
            rt.anchoredPosition = new Vector2(-21.000000f, -7.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 80.000000f);
        }
        {
            var rt = goMap[4523316696948600479L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(72.000000f, -40.000000f);
            rt.sizeDelta = new Vector2(144.000000f, 52.000000f);
        }
        {
            var rt = goMap[-7785539448494488050L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 3.000000f);
            rt.sizeDelta = new Vector2(144.000000f, 40.000000f);
        }
        {
            var rt = goMap[2366566514074819487L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(144.000000f, 52.000000f);
        }
        {
            var rt = goMap[-6187784514028866133L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 3.000000f);
            rt.sizeDelta = new Vector2(144.000000f, 40.000000f);
        }
        {
            var rt = goMap[-248715242524579454L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(144.000000f, 52.000000f);
        }
        {
            var rt = goMap[2204212955391298851L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 3.000000f);
            rt.sizeDelta = new Vector2(144.000000f, 40.000000f);
        }
        {
            var rt = goMap[1309978226104064471L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.910390f, -202.100006f);
            rt.sizeDelta = new Vector2(330.000000f, 50.000000f);
        }

        // ─── Components ──────────────────────────────────────
        { var c = goMap[8333513703502013360L].AddComponent<Image>();
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
        { var c = goMap[8333513703502013360L].AddComponent<Canvas>();
           c.renderMode = (RenderMode)1;
           c.overrideSorting = false;
           c.sortingOrder = 0;
           c.planeDistance = 100.000000f;
           c.pixelPerfect = false;
           c.additionalShaderChannels = (AdditionalCanvasShaderChannels)0;
           c.enabled = true;
        }
        { var c = goMap[8333513703502013360L].AddComponent<CanvasScaler>();
           c.uiScaleMode = (CanvasScaler.ScaleMode)1;
           c.referenceResolution = new Vector2(1280.000000f, 720.000000f);
           c.screenMatchMode = (CanvasScaler.ScreenMatchMode)1;
           c.matchWidthOrHeight = 0.000000f;
           c.referencePixelsPerUnit = 100.000000f;
        }
        { var c = goMap[8333513703502013360L].AddComponent<GraphicRaycaster>();
           c.ignoreReversedGraphics = true;
        }
        { var c = goMap[8333513703502013360L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("UIKinList"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[-1856427607681994877L].AddComponent<CanvasGroup>();
           c.alpha = 1.000000f;
           c.interactable = true;
           c.blocksRaycasts = true;
           c.ignoreParentGroups = false;
        }
        { var c = goMap[-6006531979814469218L].AddComponent<Image>();
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
        { var c = goMap[4470454166698919303L].AddComponent<Image>();
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
        { var c = goMap[8187253934611388427L].AddComponent<Image>();
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
        { var c = goMap[-5698870741786211429L].AddComponent<Image>();
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
        { var c = goMap[1650956028367450543L].AddComponent<Image>();
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
        { var c = goMap[-5534520209645894546L].AddComponent<Image>();
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
        { var c = goMap[2186017438670053093L].AddComponent<Image>();
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
        { var c = goMap[-5918661392330402205L].AddComponent<Image>();
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
        { var c = goMap[6067164632782053589L].AddComponent<Image>();
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
        { var c = goMap[1858695571710979592L].AddComponent<Image>();
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
        { var c = goMap[-6269261675786623964L].AddComponent<Image>();
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
        { var c = goMap[-8702597175766861309L].AddComponent<Image>();
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
        { var c = goMap[7025520231562002625L].AddComponent<Image>();
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
        { var c = goMap[2846580321834405285L].AddComponent<Image>();
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
        { var c = goMap[2846580321834405285L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[2846580321834405285L].AddComponent<UIScalePulse>();
           c.upScale = 0.950000f; c.duration = 0.100000f; c.scaleUp = false;
           c.enabled = true;
        }
        { var c = goMap[5262827841072762729L].AddComponent<Text>();
           c.text = "56376";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 26;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleLeft;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 0.850000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 16;
           c.resizeTextMaxSize = 26;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[5262827841072762729L].AddComponent<Outline>();
           c.effectColor = new Color(0.372549f, 0.545098f, 0.552941f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[5262827841072762729L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)2;
           c.verticalFit = (ContentSizeFitter.FitMode)0;
        }
        { var c = goMap[1747644429056159886L].AddComponent<Image>();
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
        { var c = goMap[1747644429056159886L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[1747644429056159886L].AddComponent<CanvasGroup>();
           c.alpha = 1.000000f;
           c.interactable = true;
           c.blocksRaycasts = true;
           c.ignoreParentGroups = false;
        }
        { var c = goMap[1842583571085126202L].AddComponent<CanvasGroup>();
           c.alpha = 1.000000f;
           c.interactable = true;
           c.blocksRaycasts = true;
           c.ignoreParentGroups = false;
        }
        { var c = goMap[331820019492967284L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_activity_titlebg");
        }
        { var c = goMap[4789737931827383410L].AddComponent<Text>();
           c.text = "56394";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 8;
           c.resizeTextMaxSize = 18;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-4404994934219393708L].AddComponent<Text>();
           c.text = "56471";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 8;
           c.resizeTextMaxSize = 18;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-6130378619370303046L].AddComponent<Text>();
           c.text = "56709";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 8;
           c.resizeTextMaxSize = 18;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-943479867263271517L].AddComponent<RectMask2D>();
           c.enabled = true;
        }
        { var c = goMap[2703750280844409999L].AddComponent<Text>();
           c.text = "暂无信息";
           c.color = new Color(0.576471f, 0.576471f, 0.572549f, 1.000000f);
           c.fontSize = 24;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 14;
           c.resizeTextMaxSize = 24;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[6719711673735463485L].AddComponent<GridLayoutGroup>();
           c.padding = new RectOffset(0,0,0,0);
           c.cellSize = new Vector2(788.000000f, 58.000000f);
           c.spacing = new Vector2(0.000000f, 6.000000f);
           c.childAlignment = (TextAnchor)1;
        }
        { var c = goMap[6719711673735463485L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)0;
           c.verticalFit = (ContentSizeFitter.FitMode)2;
        }
        { var c = goMap[4365494065112725512L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_listbg");
        }
        { var c = goMap[4365494065112725512L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-8999341241742500684L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_listselected");
        }
        { var c = goMap[8634289450413056485L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_Right");
        }
        { var c = goMap[-5272920532523974082L].AddComponent<Text>();
           c.text = "8906";
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
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[2530555090319767430L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
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
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-1077567397746307028L].AddComponent<Text>();
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
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-1077567397746307028L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)2;
           c.verticalFit = (ContentSizeFitter.FitMode)0;
        }
        { var c = goMap[-6268152050561212721L].AddComponent<Image>();
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
           c.sprite = LookupSprite("V_Green_01");
        }
        { var c = goMap[-2940136767623287974L].AddComponent<Image>();
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
           c.sprite = LookupSprite("btn_narrow_left");
        }
        { var c = goMap[-2940136767623287974L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[7174244297624026525L].AddComponent<Image>();
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
           c.sprite = LookupSprite("btn_narrow_right");
        }
        { var c = goMap[7174244297624026525L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[7993875992157196324L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
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
        { var c = goMap[1281840494644361357L].AddComponent<Text>();
           c.text = "8906";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
           c.fontSize = 26;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 16;
           c.resizeTextMaxSize = 26;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[1942917847274168094L].AddComponent<Image>();
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
        { var c = goMap[-265814872301517376L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_title_line");
        }
        { var c = goMap[7052023076351760310L].AddComponent<Text>();
           c.text = "56378";
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
        { var c = goMap[-1644515507954222302L].AddComponent<Text>();
           c.text = "13663";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.UpperLeft;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 16;
           c.resizeTextMaxSize = 20;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-5566908765242769895L].AddComponent<HorizontalLayoutGroup>();
           c.padding = new RectOffset(0,0,0,0);
           c.spacing = 16.600000f;
           c.childAlignment = (TextAnchor)4;
           c.childForceExpandWidth = true;
           c.childForceExpandHeight = true;
           c.childControlWidth = false;
           c.childControlHeight = false;
           c.reverseArrangement = false;
        }
        { var c = goMap[-5566908765242769895L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)2;
           c.verticalFit = (ContentSizeFitter.FitMode)0;
        }
        { var c = goMap[4523316696948600479L].AddComponent<Image>();
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
           c.sprite = LookupSprite("btn_common1_1");
        }
        { var c = goMap[4523316696948600479L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[4523316696948600479L].AddComponent<UIScalePulse>();
           c.upScale = 0.950000f; c.duration = 0.100000f; c.scaleUp = false;
           c.enabled = true;
        }
        { var c = goMap[-7785539448494488050L].AddComponent<Text>();
           c.text = "56381";
           c.color = new Color(0.047059f, 0.227451f, 0.239216f, 1.000000f);
           c.fontSize = 22;
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
        { var c = goMap[2366566514074819487L].AddComponent<Image>();
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
           c.sprite = LookupSprite("btn_common1_1");
        }
        { var c = goMap[2366566514074819487L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[2366566514074819487L].AddComponent<UIScalePulse>();
           c.upScale = 0.950000f; c.duration = 0.100000f; c.scaleUp = false;
           c.enabled = true;
        }
        { var c = goMap[-6187784514028866133L].AddComponent<Text>();
           c.text = "56393";
           c.color = new Color(0.047059f, 0.227451f, 0.239216f, 1.000000f);
           c.fontSize = 22;
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
        { var c = goMap[-248715242524579454L].AddComponent<Image>();
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
           c.sprite = LookupSprite("btn_common1_1");
        }
        { var c = goMap[-248715242524579454L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-248715242524579454L].AddComponent<UIScalePulse>();
           c.upScale = 0.950000f; c.duration = 0.100000f; c.scaleUp = false;
           c.enabled = true;
        }
        { var c = goMap[2204212955391298851L].AddComponent<Text>();
           c.text = "申请加入";
           c.color = new Color(0.047059f, 0.227451f, 0.239216f, 1.000000f);
           c.fontSize = 22;
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
        { var c = goMap[1309978226104064471L].AddComponent<Text>();
           c.text = "81654";
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
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 20;
           c.raycastTarget = false;
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
        var rootGO = goMap[8333513703502013360L];
        string path = "Assets/Prefabs/Imported/UILegionList.prefab";
        PrefabUtility.SaveAsPrefabAsset(rootGO, path);
        Object.DestroyImmediate(rootGO);
        Debug.Log("[Import_res_p_560] Saved " + path);
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