// AUTO-GENERATED from res_p_487.ab — DO NOT EDIT MANUALLY.
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;
using System.Collections.Generic;
using KTO.Game;  // UIJoyStick and other ported KTO scripts

public class Import_res_p_487
{
    [MenuItem("KTO/Import/res_p_487")]
    public static void Build()
    {
        Debug.Log("[Import_res_p_487] Building UIMarriageCertificate...");

        // ─── Create all GameObjects ───────────────────────────
        var goMap = new Dictionary<long, GameObject>();
        var _toggleGroupByMbPid = new Dictionary<long, ToggleGroup>();
        var _toggleGroupLinks = new List<System.Tuple<Toggle,long>>();
        { var go = new GameObject("UIMarriageCertificate"); go.SetActive(true); goMap[6857333476451622312L] = go; }
        { var go = new GameObject("node"); go.SetActive(true); goMap[-1337267503152172912L] = go; }
        { var go = new GameObject("imgBG"); go.SetActive(true); goMap[-491181860070276798L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(true); goMap[-3882546873448411273L] = go; }
        { var go = new GameObject("imgInvitation"); go.SetActive(true); goMap[5762659184739565361L] = go; }
        { var go = new GameObject("LiuGuang"); go.SetActive(true); goMap[8836598719008590180L] = go; }
        { var go = new GameObject("Glow"); go.SetActive(true); goMap[7002870994423079233L] = go; }
        { var go = new GameObject("Effect"); go.SetActive(true); goMap[780751217517209237L] = go; }
        { var go = new GameObject("Love"); go.SetActive(true); goMap[580046322170294025L] = go; }
        { var go = new GameObject("Star"); go.SetActive(true); goMap[7114486073080765299L] = go; }
        { var go = new GameObject("Light"); go.SetActive(true); goMap[-1276973861259869429L] = go; }
        { var go = new GameObject("imgTassels"); go.SetActive(false); goMap[-5517603871095790944L] = go; }
        { var go = new GameObject("txtTitle"); go.SetActive(true); goMap[6320925389586634571L] = go; }
        { var go = new GameObject("txtInfo"); go.SetActive(true); goMap[4602973026040779109L] = go; }
        { var go = new GameObject("txtTime"); go.SetActive(true); goMap[-1864500083372402518L] = go; }
        { var go = new GameObject("txtInfo1"); go.SetActive(true); goMap[-413829260404140714L] = go; }
        { var go = new GameObject("txtPlayer1"); go.SetActive(true); goMap[113915689574557548L] = go; }
        { var go = new GameObject("txtPlayer2"); go.SetActive(true); goMap[-311512675571832848L] = go; }
        { var go = new GameObject("LiuSu"); go.SetActive(true); goMap[4186977457142651035L] = go; }
        { var go = new GameObject("shengzi"); go.SetActive(true); goMap[-955350907685948202L] = go; }
        { var go = new GameObject("Bone001"); go.SetActive(true); goMap[-133037950210844403L] = go; }
        { var go = new GameObject("Bone002"); go.SetActive(true); goMap[3814978292653426286L] = go; }
        { var go = new GameObject("Bone003"); go.SetActive(true); goMap[4986982423578029769L] = go; }
        { var go = new GameObject("Bone004"); go.SetActive(true); goMap[6219126397484515656L] = go; }
        { var go = new GameObject("Bone005"); go.SetActive(true); goMap[7378453902933582882L] = go; }
        { var go = new GameObject("Bone006"); go.SetActive(true); goMap[1550610465483837870L] = go; }
        { var go = new GameObject("Bone007"); go.SetActive(true); goMap[-2435365297934614546L] = go; }
        { var go = new GameObject("Bone008"); go.SetActive(true); goMap[3412922263529821845L] = go; }
        { var go = new GameObject("Bone009"); go.SetActive(true); goMap[-7194999640648197224L] = go; }
        { var go = new GameObject("Bone010"); go.SetActive(true); goMap[8293044252901002260L] = go; }
        { var go = new GameObject("Bone011"); go.SetActive(true); goMap[-6599102086203190479L] = go; }
        { var go = new GameObject("Bone012"); go.SetActive(true); goMap[846610435255653670L] = go; }
        { var go = new GameObject("Bone013"); go.SetActive(true); goMap[6203678117256949127L] = go; }
        { var go = new GameObject("Bone014"); go.SetActive(true); goMap[-8065731548940867770L] = go; }
        { var go = new GameObject("Bone015"); go.SetActive(true); goMap[-1434843000417957227L] = go; }
        { var go = new GameObject("Bone016"); go.SetActive(true); goMap[2373734313077433122L] = go; }
        { var go = new GameObject("Bone017"); go.SetActive(true); goMap[6115821607134812540L] = go; }
        { var go = new GameObject("Bone018"); go.SetActive(true); goMap[9045046660756209542L] = go; }
        { var go = new GameObject("Bone019"); go.SetActive(true); goMap[8175756187341825776L] = go; }
        { var go = new GameObject("Bone020"); go.SetActive(true); goMap[-6299806409706245456L] = go; }
        { var go = new GameObject("Object001"); go.SetActive(true); goMap[810960735162021584L] = go; }
        { var go = new GameObject("Plane001"); go.SetActive(true); goMap[-457104354877187263L] = go; }
        { var go = new GameObject("Plane002"); go.SetActive(true); goMap[-6632299502837718323L] = go; }
        { var go = new GameObject("Quad"); go.SetActive(true); goMap[912880056104784348L] = go; }

        // ─── Parent links ─────────────────────────────────────
        goMap[-1337267503152172912L].transform.SetParent(goMap[6857333476451622312L].transform, false);
        goMap[-491181860070276798L].transform.SetParent(goMap[-1337267503152172912L].transform, false);
        goMap[-3882546873448411273L].transform.SetParent(goMap[-491181860070276798L].transform, false);
        goMap[5762659184739565361L].transform.SetParent(goMap[-491181860070276798L].transform, false);
        goMap[8836598719008590180L].transform.SetParent(goMap[5762659184739565361L].transform, false);
        goMap[7002870994423079233L].transform.SetParent(goMap[5762659184739565361L].transform, false);
        goMap[780751217517209237L].transform.SetParent(goMap[5762659184739565361L].transform, false);
        goMap[580046322170294025L].transform.SetParent(goMap[780751217517209237L].transform, false);
        goMap[7114486073080765299L].transform.SetParent(goMap[580046322170294025L].transform, false);
        goMap[-1276973861259869429L].transform.SetParent(goMap[5762659184739565361L].transform, false);
        goMap[-5517603871095790944L].transform.SetParent(goMap[-491181860070276798L].transform, false);
        goMap[6320925389586634571L].transform.SetParent(goMap[-491181860070276798L].transform, false);
        goMap[4602973026040779109L].transform.SetParent(goMap[-491181860070276798L].transform, false);
        goMap[-1864500083372402518L].transform.SetParent(goMap[-491181860070276798L].transform, false);
        goMap[-413829260404140714L].transform.SetParent(goMap[-1864500083372402518L].transform, false);
        goMap[113915689574557548L].transform.SetParent(goMap[-491181860070276798L].transform, false);
        goMap[-311512675571832848L].transform.SetParent(goMap[-491181860070276798L].transform, false);
        goMap[4186977457142651035L].transform.SetParent(goMap[-491181860070276798L].transform, false);
        goMap[-955350907685948202L].transform.SetParent(goMap[4186977457142651035L].transform, false);
        goMap[-133037950210844403L].transform.SetParent(goMap[-955350907685948202L].transform, false);
        goMap[3814978292653426286L].transform.SetParent(goMap[-133037950210844403L].transform, false);
        goMap[4986982423578029769L].transform.SetParent(goMap[3814978292653426286L].transform, false);
        goMap[6219126397484515656L].transform.SetParent(goMap[4986982423578029769L].transform, false);
        goMap[7378453902933582882L].transform.SetParent(goMap[6219126397484515656L].transform, false);
        goMap[1550610465483837870L].transform.SetParent(goMap[-955350907685948202L].transform, false);
        goMap[-2435365297934614546L].transform.SetParent(goMap[1550610465483837870L].transform, false);
        goMap[3412922263529821845L].transform.SetParent(goMap[-2435365297934614546L].transform, false);
        goMap[-7194999640648197224L].transform.SetParent(goMap[3412922263529821845L].transform, false);
        goMap[8293044252901002260L].transform.SetParent(goMap[-7194999640648197224L].transform, false);
        goMap[-6599102086203190479L].transform.SetParent(goMap[8293044252901002260L].transform, false);
        goMap[846610435255653670L].transform.SetParent(goMap[-955350907685948202L].transform, false);
        goMap[6203678117256949127L].transform.SetParent(goMap[846610435255653670L].transform, false);
        goMap[-8065731548940867770L].transform.SetParent(goMap[6203678117256949127L].transform, false);
        goMap[-1434843000417957227L].transform.SetParent(goMap[-8065731548940867770L].transform, false);
        goMap[2373734313077433122L].transform.SetParent(goMap[-1434843000417957227L].transform, false);
        goMap[6115821607134812540L].transform.SetParent(goMap[846610435255653670L].transform, false);
        goMap[9045046660756209542L].transform.SetParent(goMap[6115821607134812540L].transform, false);
        goMap[8175756187341825776L].transform.SetParent(goMap[9045046660756209542L].transform, false);
        goMap[-6299806409706245456L].transform.SetParent(goMap[8175756187341825776L].transform, false);
        goMap[810960735162021584L].transform.SetParent(goMap[-955350907685948202L].transform, false);
        goMap[-457104354877187263L].transform.SetParent(goMap[-955350907685948202L].transform, false);
        goMap[-6632299502837718323L].transform.SetParent(goMap[-955350907685948202L].transform, false);
        goMap[912880056104784348L].transform.SetParent(goMap[-955350907685948202L].transform, false);

        // ─── RectTransforms ──────────────────────────────────
        {
            var rt = goMap[6857333476451622312L].AddComponent<RectTransform>();
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
            var rt = goMap[-1337267503152172912L].AddComponent<RectTransform>();
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
            var rt = goMap[-491181860070276798L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(1164.000000f, 644.000000f);
        }
        {
            var rt = goMap[-3882546873448411273L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(51.000000f, -2.000000f);
            rt.sizeDelta = new Vector2(906.000000f, 568.000000f);
        }
        {
            var rt = goMap[5762659184739565361L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-9.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(919.000000f, 473.000000f);
        }
        {
            var rt = goMap[8836598719008590180L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(1.300001f, 1.400000f);
            rt.sizeDelta = new Vector2(944.000000f, 487.000000f);
        }
        {
            var rt = goMap[7002870994423079233L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(919.000000f, 473.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[780751217517209237L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.321350f);
            rt.localRotation = new Quaternion(-0.069146f,0.084674f,-0.350175f,0.930283f);
            rt.localScale = new Vector3(2.714700f, 2.714700f, 2.714701f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-58.000000f, 148.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[580046322170294025L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, -14.699940f);
            rt.localRotation = new Quaternion(0.318981f,-0.549485f,-0.385896f,-0.668882f);
            rt.localScale = new Vector3(1.495000f, 1.495000f, 1.495000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-2.600006f, -74.800011f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[7114486073080765299L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.000061f, 0.000023f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-1276973861259869429L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(2781.458740f, 1752.099976f, 1752.099976f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-5517603871095790944L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(411.000000f, 27.000000f);
            rt.sizeDelta = new Vector2(128.000000f, 243.000000f);
        }
        {
            var rt = goMap[6320925389586634571L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 90.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(150.000000f, 2.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 111.627602f);
        }
        {
            var rt = goMap[4602973026040779109L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 1.000000f);
            rt.anchoredPosition = new Vector2(409.000000f, -110.800003f);
            rt.sizeDelta = new Vector2(381.200012f, 219.399994f);
        }
        {
            var rt = goMap[-1864500083372402518L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(409.000000f, -371.000000f);
            rt.sizeDelta = new Vector2(381.200012f, 54.400002f);
        }
        {
            var rt = goMap[-413829260404140714L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 1.000000f);
            rt.anchoredPosition = new Vector2(190.599976f, -17.200012f);
            rt.sizeDelta = new Vector2(381.200012f, 50.000000f);
        }
        {
            var rt = goMap[113915689574557548L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(1.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(483.000000f, -434.000000f);
            rt.sizeDelta = new Vector2(381.200012f, 40.000000f);
        }
        {
            var rt = goMap[-311512675571832848L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(1.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(483.000000f, -474.000000f);
            rt.sizeDelta = new Vector2(381.200012f, 40.000000f);
        }
        {
            var rt = goMap[4186977457142651035L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(397.799988f, 128.500000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }

        // ─── Components ──────────────────────────────────────
        { var c = goMap[6857333476451622312L].AddComponent<Image>();
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
        { var c = goMap[6857333476451622312L].AddComponent<Canvas>();
           c.renderMode = (RenderMode)1;
           c.overrideSorting = false;
           c.sortingOrder = 0;
           c.planeDistance = 100.000000f;
           c.pixelPerfect = false;
           c.additionalShaderChannels = (AdditionalCanvasShaderChannels)6;
           c.enabled = true;
        }
        { var c = goMap[6857333476451622312L].AddComponent<CanvasScaler>();
           c.uiScaleMode = (CanvasScaler.ScaleMode)1;
           c.referenceResolution = new Vector2(1280.000000f, 720.000000f);
           c.screenMatchMode = (CanvasScaler.ScreenMatchMode)1;
           c.matchWidthOrHeight = 0.000000f;
           c.referencePixelsPerUnit = 100.000000f;
        }
        { var c = goMap[6857333476451622312L].AddComponent<GraphicRaycaster>();
           c.ignoreReversedGraphics = true;
        }
        { var c = goMap[6857333476451622312L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("UIMarriageCertificate"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[-1337267503152172912L].AddComponent<CanvasGroup>();
           c.alpha = 1.000000f;
           c.interactable = true;
           c.blocksRaycasts = true;
           c.ignoreParentGroups = false;
        }
        { var c = goMap[-491181860070276798L].AddComponent<CanvasGroup>();
           c.alpha = 1.000000f;
           c.interactable = true;
           c.blocksRaycasts = true;
           c.ignoreParentGroups = false;
        }
        { var c = goMap[-3882546873448411273L].AddComponent<Image>();
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
           c.sprite = LookupSprite("UISwordsmen_Bg01");
        }
        { var c = goMap[5762659184739565361L].AddComponent<Image>();
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
           c.sprite = LookupSprite("UISwordsmen_Bg02");
        }
        { var c = goMap[8836598719008590180L].AddComponent<Image>();
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
           c.sprite = LookupSprite("BianKuang_Mask");
        }
        { var c = goMap[-5517603871095790944L].AddComponent<Image>();
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
           c.sprite = LookupSprite("UISwordsmen_Bg03");
        }
        { var c = goMap[6320925389586634571L].AddComponent<Text>();
           c.text = "42768";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 50;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleLeft;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 4;
           c.resizeTextMaxSize = 60;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[6320925389586634571L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)2;
           c.verticalFit = (ContentSizeFitter.FitMode)0;
        }
        { var g = goMap[6320925389586634571L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.858824f, 0.141176f, 0.156863f, 1.000000f); }
        { var c = goMap[6320925389586634571L].AddComponent<Outline>();
           c.effectColor = new Color(1.000000f, 0.913726f, 0.615686f, 1.000000f);
           c.effectDistance = new Vector2(2.000000f, -2.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[4602973026040779109L].AddComponent<Text>();
           c.text = "44310";
           c.color = new Color(1.000000f, 0.905882f, 0.694118f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.LowerCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 18;
           c.resizeTextMaxSize = 20;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[4602973026040779109L].AddComponent<Outline>();
           c.effectColor = new Color(0.678431f, 0.086275f, 0.082353f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-1864500083372402518L].AddComponent<Text>();
           c.text = "44307";
           c.color = new Color(1.000000f, 0.905882f, 0.694118f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.UpperCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 18;
           c.resizeTextMaxSize = 20;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-1864500083372402518L].AddComponent<Outline>();
           c.effectColor = new Color(0.678431f, 0.086275f, 0.082353f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-413829260404140714L].AddComponent<Text>();
           c.text = "44309";
           c.color = new Color(1.000000f, 0.905882f, 0.694118f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.UpperCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 18;
           c.resizeTextMaxSize = 20;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-413829260404140714L].AddComponent<Outline>();
           c.effectColor = new Color(0.678431f, 0.086275f, 0.082353f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[113915689574557548L].AddComponent<Text>();
           c.text = "14942";
           c.color = new Color(1.000000f, 0.905882f, 0.694118f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleRight;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 18;
           c.resizeTextMaxSize = 20;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[113915689574557548L].AddComponent<Outline>();
           c.effectColor = new Color(0.678431f, 0.086275f, 0.082353f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-311512675571832848L].AddComponent<Text>();
           c.text = "14942";
           c.color = new Color(1.000000f, 0.905882f, 0.694118f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleRight;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 18;
           c.resizeTextMaxSize = 20;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-311512675571832848L].AddComponent<Outline>();
           c.effectColor = new Color(0.678431f, 0.086275f, 0.082353f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-955350907685948202L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("shengzi"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
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
        var rootGO = goMap[6857333476451622312L];
        string path = "Assets/Prefabs/Imported/UIMarriageCertificate.prefab";
        PrefabUtility.SaveAsPrefabAsset(rootGO, path);
        Object.DestroyImmediate(rootGO);
        Debug.Log("[Import_res_p_487] Saved " + path);
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