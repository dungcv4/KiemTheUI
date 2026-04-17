// AUTO-GENERATED from res_p_85.ab — DO NOT EDIT MANUALLY.
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;
using System.Collections.Generic;
using KTO.Game;  // UIJoyStick and other ported KTO scripts

public class Import_res_p_85
{
    [MenuItem("KTO/Import/res_p_85")]
    public static void Build()
    {
        Debug.Log("[Import_res_p_85] Building UIGuide...");

        // ─── Create all GameObjects ───────────────────────────
        var goMap = new Dictionary<long, GameObject>();
        var _toggleGroupByMbPid = new Dictionary<long, ToggleGroup>();
        var _toggleGroupLinks = new List<System.Tuple<Toggle,long>>();
        { var go = new GameObject("UIGuide"); go.SetActive(true); goMap[-7177879799564883097L] = go; }
        { var go = new GameObject("imgBG"); go.SetActive(true); goMap[-6147670599606064478L] = go; }
        { var go = new GameObject("mask_bg"); go.SetActive(false); goMap[-7241151733281151571L] = go; }
        { var go = new GameObject("DynamicHighLight"); go.SetActive(true); goMap[3982330802774223901L] = go; }
        { var go = new GameObject("Hint"); go.SetActive(true); goMap[5404879705136466240L] = go; }
        { var go = new GameObject("Kuang"); go.SetActive(true); goMap[-5282736852163387596L] = go; }
        { var go = new GameObject("Effect"); go.SetActive(true); goMap[-8889115215282066449L] = go; }
        { var go = new GameObject("Glow"); go.SetActive(true); goMap[-2250885598557058657L] = go; }
        { var go = new GameObject("Line"); go.SetActive(true); goMap[3636817037918806003L] = go; }
        { var go = new GameObject("Region"); go.SetActive(true); goMap[2996004831447117929L] = go; }
        { var go = new GameObject("handIcon"); go.SetActive(true); goMap[-6605858033297056604L] = go; }
        { var go = new GameObject("short"); go.SetActive(true); goMap[-8406771505707443812L] = go; }
        { var go = new GameObject("KuoSan_01"); go.SetActive(true); goMap[-9016395712270813862L] = go; }
        { var go = new GameObject("KuoSan_02"); go.SetActive(true); goMap[-9139417458332817861L] = go; }
        { var go = new GameObject("imgHand"); go.SetActive(true); goMap[1845275603623023359L] = go; }
        { var go = new GameObject("long"); go.SetActive(true); goMap[4924190453350101875L] = go; }
        { var go = new GameObject("KuoSan_01"); go.SetActive(true); goMap[3959402430916044455L] = go; }
        { var go = new GameObject("KuoSan_02"); go.SetActive(true); goMap[3840510374141700581L] = go; }
        { var go = new GameObject("imgHand"); go.SetActive(true); goMap[-7020191555804081136L] = go; }
        { var go = new GameObject("LeftComment"); go.SetActive(true); goMap[-8416979886323725499L] = go; }
        { var go = new GameObject("imgTxtBg"); go.SetActive(true); goMap[-467051666674106938L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[3584880573211140908L] = go; }
        { var go = new GameObject("RightComment"); go.SetActive(true); goMap[-4490726443433652863L] = go; }
        { var go = new GameObject("imgTxtBg"); go.SetActive(true); goMap[3887231386097525025L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-3330895636368024812L] = go; }
        { var go = new GameObject("TopComment"); go.SetActive(true); goMap[8336398003986287016L] = go; }
        { var go = new GameObject("imgTxtBg"); go.SetActive(true); goMap[-1384332076755041754L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[8772459683864144078L] = go; }
        { var go = new GameObject("BottomComment"); go.SetActive(true); goMap[-3552372717058218343L] = go; }
        { var go = new GameObject("imgTxtBg"); go.SetActive(true); goMap[7744571632882739449L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-5318329361996097627L] = go; }
        { var go = new GameObject("BtnGroup"); go.SetActive(false); goMap[-1105920934262513659L] = go; }
        { var go = new GameObject("ForceClick1"); go.SetActive(false); goMap[8720588907509217498L] = go; }
        { var go = new GameObject("ForegroundGroup"); go.SetActive(true); goMap[1694912329518584681L] = go; }
        { var go = new GameObject("OpenBag"); go.SetActive(false); goMap[1626526457021226341L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[-1804296017267211100L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[5812254403853625137L] = go; }
        { var go = new GameObject("NewPlayerLogin3"); go.SetActive(false); goMap[7196905210169977961L] = go; }
        { var go = new GameObject("imgTxtBg"); go.SetActive(true); goMap[-2974209469121596207L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-466336247164348598L] = go; }
        { var go = new GameObject("SkillGuide1"); go.SetActive(true); goMap[-5997505930059170972L] = go; }
        { var go = new GameObject("Effect"); go.SetActive(true); goMap[5908975703055095190L] = go; }
        { var go = new GameObject("tishianniu"); go.SetActive(true); goMap[6277402929359149307L] = go; }
        { var go = new GameObject("Particle System (2)"); go.SetActive(true); goMap[-2854199933563932690L] = go; }
        { var go = new GameObject("Particle System (1)"); go.SetActive(true); goMap[-4560628830250034821L] = go; }
        { var go = new GameObject("Particle System (6)"); go.SetActive(true); goMap[-2682452869972619875L] = go; }
        { var go = new GameObject("Particle System (3)"); go.SetActive(true); goMap[-976747688663811230L] = go; }
        { var go = new GameObject("OpenBag (1)"); go.SetActive(true); goMap[5148513471992583216L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[-4785109229607813661L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-2574858918129457740L] = go; }
        { var go = new GameObject("SkillGuide2"); go.SetActive(true); goMap[-8343107463257151270L] = go; }
        { var go = new GameObject("Effect"); go.SetActive(true); goMap[1753148528069889215L] = go; }
        { var go = new GameObject("tishianniu"); go.SetActive(true); goMap[6607032036140148952L] = go; }
        { var go = new GameObject("Particle System (2)"); go.SetActive(true); goMap[698996676578279761L] = go; }
        { var go = new GameObject("Particle System (1)"); go.SetActive(true); goMap[-2885951227314380341L] = go; }
        { var go = new GameObject("Particle System (6)"); go.SetActive(true); goMap[1956381843993135154L] = go; }
        { var go = new GameObject("Particle System (3)"); go.SetActive(true); goMap[-1598184723173149331L] = go; }
        { var go = new GameObject("OpenBag (1)"); go.SetActive(true); goMap[5676819858138041116L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[-3781110672606624317L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[7295734829272958014L] = go; }
        { var go = new GameObject("Effect (1)"); go.SetActive(false); goMap[-4850865735736333703L] = go; }
        { var go = new GameObject("tishianniu"); go.SetActive(true); goMap[-7243831698800382043L] = go; }
        { var go = new GameObject("Particle System (2)"); go.SetActive(true); goMap[3953496212385762552L] = go; }
        { var go = new GameObject("Particle System (1)"); go.SetActive(true); goMap[-8974871499584844573L] = go; }
        { var go = new GameObject("Particle System (6)"); go.SetActive(true); goMap[-2558774681457759589L] = go; }
        { var go = new GameObject("Particle System (3)"); go.SetActive(true); goMap[-4666133232373361623L] = go; }
        { var go = new GameObject("SkillGuide3"); go.SetActive(true); goMap[3780755287063704128L] = go; }
        { var go = new GameObject("Effect"); go.SetActive(true); goMap[-8471628098597474029L] = go; }
        { var go = new GameObject("tishianniu"); go.SetActive(true); goMap[593588040140609464L] = go; }
        { var go = new GameObject("Particle System (2)"); go.SetActive(true); goMap[-6532679954480585006L] = go; }
        { var go = new GameObject("Particle System (1)"); go.SetActive(true); goMap[2105385727226946076L] = go; }
        { var go = new GameObject("Particle System (6)"); go.SetActive(true); goMap[5530911857604160968L] = go; }
        { var go = new GameObject("Particle System (3)"); go.SetActive(true); goMap[-240979686103507288L] = go; }
        { var go = new GameObject("OpenBag (1)"); go.SetActive(true); goMap[8199726741110318071L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[4805242172577387643L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[4795910171104748309L] = go; }
        { var go = new GameObject("WaitingMask"); go.SetActive(false); goMap[-508633428186904768L] = go; }
        { var go = new GameObject("CommonDialog"); go.SetActive(false); goMap[-2726796319195115278L] = go; }
        { var go = new GameObject("bg"); go.SetActive(true); goMap[-6469343192085183996L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-3891032748520993346L] = go; }
        { var go = new GameObject("btnOK"); go.SetActive(true); goMap[9170598462533964775L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[3412844272490231421L] = go; }
        { var go = new GameObject("DefaultBtn"); go.SetActive(false); goMap[-4761593256588574169L] = go; }
        { var go = new GameObject("BtnSkip"); go.SetActive(false); goMap[-3061470302727050666L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[-973023369422015549L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-8062276718836236906L] = go; }
        { var go = new GameObject("imgSkip"); go.SetActive(true); goMap[-3842934937776548221L] = go; }

        // ─── Parent links ─────────────────────────────────────
        goMap[-6147670599606064478L].transform.SetParent(goMap[-7177879799564883097L].transform, false);
        goMap[-7241151733281151571L].transform.SetParent(goMap[-6147670599606064478L].transform, false);
        goMap[3982330802774223901L].transform.SetParent(goMap[-6147670599606064478L].transform, false);
        goMap[5404879705136466240L].transform.SetParent(goMap[3982330802774223901L].transform, false);
        goMap[-5282736852163387596L].transform.SetParent(goMap[5404879705136466240L].transform, false);
        goMap[-8889115215282066449L].transform.SetParent(goMap[5404879705136466240L].transform, false);
        goMap[-2250885598557058657L].transform.SetParent(goMap[-8889115215282066449L].transform, false);
        goMap[3636817037918806003L].transform.SetParent(goMap[-8889115215282066449L].transform, false);
        goMap[2996004831447117929L].transform.SetParent(goMap[3982330802774223901L].transform, false);
        goMap[-6605858033297056604L].transform.SetParent(goMap[2996004831447117929L].transform, false);
        goMap[-8406771505707443812L].transform.SetParent(goMap[-6605858033297056604L].transform, false);
        goMap[-9016395712270813862L].transform.SetParent(goMap[-8406771505707443812L].transform, false);
        goMap[-9139417458332817861L].transform.SetParent(goMap[-8406771505707443812L].transform, false);
        goMap[1845275603623023359L].transform.SetParent(goMap[-8406771505707443812L].transform, false);
        goMap[4924190453350101875L].transform.SetParent(goMap[-6605858033297056604L].transform, false);
        goMap[3959402430916044455L].transform.SetParent(goMap[4924190453350101875L].transform, false);
        goMap[3840510374141700581L].transform.SetParent(goMap[4924190453350101875L].transform, false);
        goMap[-7020191555804081136L].transform.SetParent(goMap[4924190453350101875L].transform, false);
        goMap[-8416979886323725499L].transform.SetParent(goMap[2996004831447117929L].transform, false);
        goMap[-467051666674106938L].transform.SetParent(goMap[-8416979886323725499L].transform, false);
        goMap[3584880573211140908L].transform.SetParent(goMap[-467051666674106938L].transform, false);
        goMap[-4490726443433652863L].transform.SetParent(goMap[2996004831447117929L].transform, false);
        goMap[3887231386097525025L].transform.SetParent(goMap[-4490726443433652863L].transform, false);
        goMap[-3330895636368024812L].transform.SetParent(goMap[3887231386097525025L].transform, false);
        goMap[8336398003986287016L].transform.SetParent(goMap[2996004831447117929L].transform, false);
        goMap[-1384332076755041754L].transform.SetParent(goMap[8336398003986287016L].transform, false);
        goMap[8772459683864144078L].transform.SetParent(goMap[-1384332076755041754L].transform, false);
        goMap[-3552372717058218343L].transform.SetParent(goMap[2996004831447117929L].transform, false);
        goMap[7744571632882739449L].transform.SetParent(goMap[-3552372717058218343L].transform, false);
        goMap[-5318329361996097627L].transform.SetParent(goMap[7744571632882739449L].transform, false);
        goMap[-1105920934262513659L].transform.SetParent(goMap[-6147670599606064478L].transform, false);
        goMap[8720588907509217498L].transform.SetParent(goMap[-1105920934262513659L].transform, false);
        goMap[1694912329518584681L].transform.SetParent(goMap[-6147670599606064478L].transform, false);
        goMap[1626526457021226341L].transform.SetParent(goMap[1694912329518584681L].transform, false);
        goMap[-1804296017267211100L].transform.SetParent(goMap[1626526457021226341L].transform, false);
        goMap[5812254403853625137L].transform.SetParent(goMap[-1804296017267211100L].transform, false);
        goMap[7196905210169977961L].transform.SetParent(goMap[1694912329518584681L].transform, false);
        goMap[-2974209469121596207L].transform.SetParent(goMap[7196905210169977961L].transform, false);
        goMap[-466336247164348598L].transform.SetParent(goMap[-2974209469121596207L].transform, false);
        goMap[-5997505930059170972L].transform.SetParent(goMap[1694912329518584681L].transform, false);
        goMap[5908975703055095190L].transform.SetParent(goMap[-5997505930059170972L].transform, false);
        goMap[6277402929359149307L].transform.SetParent(goMap[5908975703055095190L].transform, false);
        goMap[-2854199933563932690L].transform.SetParent(goMap[6277402929359149307L].transform, false);
        goMap[-4560628830250034821L].transform.SetParent(goMap[-2854199933563932690L].transform, false);
        goMap[-2682452869972619875L].transform.SetParent(goMap[-2854199933563932690L].transform, false);
        goMap[-976747688663811230L].transform.SetParent(goMap[-2854199933563932690L].transform, false);
        goMap[5148513471992583216L].transform.SetParent(goMap[-5997505930059170972L].transform, false);
        goMap[-4785109229607813661L].transform.SetParent(goMap[5148513471992583216L].transform, false);
        goMap[-2574858918129457740L].transform.SetParent(goMap[-4785109229607813661L].transform, false);
        goMap[-8343107463257151270L].transform.SetParent(goMap[1694912329518584681L].transform, false);
        goMap[1753148528069889215L].transform.SetParent(goMap[-8343107463257151270L].transform, false);
        goMap[6607032036140148952L].transform.SetParent(goMap[1753148528069889215L].transform, false);
        goMap[698996676578279761L].transform.SetParent(goMap[6607032036140148952L].transform, false);
        goMap[-2885951227314380341L].transform.SetParent(goMap[698996676578279761L].transform, false);
        goMap[1956381843993135154L].transform.SetParent(goMap[698996676578279761L].transform, false);
        goMap[-1598184723173149331L].transform.SetParent(goMap[698996676578279761L].transform, false);
        goMap[5676819858138041116L].transform.SetParent(goMap[-8343107463257151270L].transform, false);
        goMap[-3781110672606624317L].transform.SetParent(goMap[5676819858138041116L].transform, false);
        goMap[7295734829272958014L].transform.SetParent(goMap[-3781110672606624317L].transform, false);
        goMap[-4850865735736333703L].transform.SetParent(goMap[-8343107463257151270L].transform, false);
        goMap[-7243831698800382043L].transform.SetParent(goMap[-4850865735736333703L].transform, false);
        goMap[3953496212385762552L].transform.SetParent(goMap[-7243831698800382043L].transform, false);
        goMap[-8974871499584844573L].transform.SetParent(goMap[3953496212385762552L].transform, false);
        goMap[-2558774681457759589L].transform.SetParent(goMap[3953496212385762552L].transform, false);
        goMap[-4666133232373361623L].transform.SetParent(goMap[3953496212385762552L].transform, false);
        goMap[3780755287063704128L].transform.SetParent(goMap[1694912329518584681L].transform, false);
        goMap[-8471628098597474029L].transform.SetParent(goMap[3780755287063704128L].transform, false);
        goMap[593588040140609464L].transform.SetParent(goMap[-8471628098597474029L].transform, false);
        goMap[-6532679954480585006L].transform.SetParent(goMap[593588040140609464L].transform, false);
        goMap[2105385727226946076L].transform.SetParent(goMap[-6532679954480585006L].transform, false);
        goMap[5530911857604160968L].transform.SetParent(goMap[-6532679954480585006L].transform, false);
        goMap[-240979686103507288L].transform.SetParent(goMap[-6532679954480585006L].transform, false);
        goMap[8199726741110318071L].transform.SetParent(goMap[3780755287063704128L].transform, false);
        goMap[4805242172577387643L].transform.SetParent(goMap[8199726741110318071L].transform, false);
        goMap[4795910171104748309L].transform.SetParent(goMap[4805242172577387643L].transform, false);
        goMap[-508633428186904768L].transform.SetParent(goMap[1694912329518584681L].transform, false);
        goMap[-2726796319195115278L].transform.SetParent(goMap[-6147670599606064478L].transform, false);
        goMap[-6469343192085183996L].transform.SetParent(goMap[-2726796319195115278L].transform, false);
        goMap[-3891032748520993346L].transform.SetParent(goMap[-6469343192085183996L].transform, false);
        goMap[9170598462533964775L].transform.SetParent(goMap[-6469343192085183996L].transform, false);
        goMap[3412844272490231421L].transform.SetParent(goMap[9170598462533964775L].transform, false);
        goMap[-4761593256588574169L].transform.SetParent(goMap[-6147670599606064478L].transform, false);
        goMap[-3061470302727050666L].transform.SetParent(goMap[-6147670599606064478L].transform, false);
        goMap[-973023369422015549L].transform.SetParent(goMap[-3061470302727050666L].transform, false);
        goMap[-8062276718836236906L].transform.SetParent(goMap[-3061470302727050666L].transform, false);
        goMap[-3842934937776548221L].transform.SetParent(goMap[-3061470302727050666L].transform, false);

        // ─── RectTransforms ──────────────────────────────────
        {
            var rt = goMap[-7177879799564883097L].AddComponent<RectTransform>();
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
            var rt = goMap[-6147670599606064478L].AddComponent<RectTransform>();
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
            var rt = goMap[-7241151733281151571L].AddComponent<RectTransform>();
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
            var rt = goMap[3982330802774223901L].AddComponent<RectTransform>();
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
            var rt = goMap[5404879705136466240L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.000000f, 1.000000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }
        {
            var rt = goMap[-5282736852163387596L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(170.000000f, 170.000000f);
        }
        {
            var rt = goMap[-8889115215282066449L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(170.000000f, 170.000000f, 170.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }
        {
            var rt = goMap[-2250885598557058657L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.004000f);
            rt.sizeDelta = new Vector2(1.000000f, 1.000000f);
        }
        {
            var rt = goMap[3636817037918806003L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(2.159825f, 2.159825f, 2.159825f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(1.000000f, 1.000000f);
        }
        {
            var rt = goMap[2996004831447117929L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.005762f, 1.005762f, 1.005762f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(652.199219f, -374.299988f);
            rt.sizeDelta = new Vector2(416.299988f, 180.899994f);
        }
        {
            var rt = goMap[-6605858033297056604L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-8406771505707443812L].AddComponent<RectTransform>();
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
            var rt = goMap[-9016395712270813862L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,0.280326f,0.959905f);
            rt.localScale = new Vector3(0.488010f, 0.488010f, 0.488010f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-1.199966f, -0.499989f);
            rt.sizeDelta = new Vector2(256.000000f, 256.000000f);
        }
        {
            var rt = goMap[-9139417458332817861L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,0.280326f,0.959905f);
            rt.localScale = new Vector3(0.286691f, 0.286691f, 0.286691f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-1.199989f, -0.499981f);
            rt.sizeDelta = new Vector2(256.000000f, 256.000000f);
        }
        {
            var rt = goMap[1845275603623023359L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,0.280326f,0.959905f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(54.700001f, -44.700001f);
            rt.sizeDelta = new Vector2(70.000000f, 140.000000f);
        }
        {
            var rt = goMap[4924190453350101875L].AddComponent<RectTransform>();
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
            var rt = goMap[3959402430916044455L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,0.280326f,0.959905f);
            rt.localScale = new Vector3(0.488010f, 0.488010f, 0.488010f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-1.199966f, -0.499989f);
            rt.sizeDelta = new Vector2(256.000000f, 256.000000f);
        }
        {
            var rt = goMap[3840510374141700581L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,0.280326f,0.959905f);
            rt.localScale = new Vector3(0.286691f, 0.286691f, 0.286691f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-1.199989f, -0.499981f);
            rt.sizeDelta = new Vector2(256.000000f, 256.000000f);
        }
        {
            var rt = goMap[-7020191555804081136L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,0.280326f,0.959905f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(54.700001f, -44.700001f);
            rt.sizeDelta = new Vector2(70.000000f, 140.000000f);
        }
        {
            var rt = goMap[-8416979886323725499L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(0.000000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-177.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(305.000000f, 80.000000f);
        }
        {
            var rt = goMap[-467051666674106938L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,1.000000f,0.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.838600f, 0.000000f);
            rt.sizeDelta = new Vector2(320.000000f, 0.000000f);
        }
        {
            var rt = goMap[3584880573211140908L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-1.000000f,-0.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }
        {
            var rt = goMap[-4490726443433652863L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.500000f);
            rt.anchorMax = new Vector2(1.000000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(179.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(305.000000f, 80.000000f);
        }
        {
            var rt = goMap[3887231386097525025L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -9.035700f);
            rt.sizeDelta = new Vector2(320.000000f, 0.000000f);
        }
        {
            var rt = goMap[-3330895636368024812L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(0.981139f, 0.981139f, 0.981139f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }
        {
            var rt = goMap[8336398003986287016L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 1.000000f);
            rt.anchorMax = new Vector2(0.500000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 60.000000f);
            rt.sizeDelta = new Vector2(305.000000f, 80.000000f);
        }
        {
            var rt = goMap[-1384332076755041754L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -19.137400f);
            rt.sizeDelta = new Vector2(320.000000f, 0.000000f);
        }
        {
            var rt = goMap[8772459683864144078L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }
        {
            var rt = goMap[-3552372717058218343L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.000000f);
            rt.anchorMax = new Vector2(0.500000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -55.000000f);
            rt.sizeDelta = new Vector2(305.000000f, 80.000000f);
        }
        {
            var rt = goMap[7744571632882739449L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(1.000000f,0.000000f,0.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 18.670000f);
            rt.sizeDelta = new Vector2(320.000000f, 0.000000f);
        }
        {
            var rt = goMap[-5318329361996097627L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-1.000000f,-0.000000f,-0.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }
        {
            var rt = goMap[-1105920934262513659L].AddComponent<RectTransform>();
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
            var rt = goMap[8720588907509217498L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 1.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-548.289062f, -151.650024f);
            rt.sizeDelta = new Vector2(70.000000f, 70.000000f);
        }
        {
            var rt = goMap[1694912329518584681L].AddComponent<RectTransform>();
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
            var rt = goMap[1626526457021226341L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.500000f);
            rt.anchorMax = new Vector2(1.000000f, 0.500000f);
            rt.pivot = new Vector2(1.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-167.000000f, 58.000000f);
            rt.sizeDelta = new Vector2(300.000000f, 70.000000f);
        }
        {
            var rt = goMap[-1804296017267211100L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,1.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(-20.000000f, -25.000000f);
        }
        {
            var rt = goMap[5812254403853625137L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-1.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(150.000000f, -22.500000f);
            rt.sizeDelta = new Vector2(200.000000f, 26.000000f);
        }
        {
            var rt = goMap[7196905210169977961L].AddComponent<RectTransform>();
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
            var rt = goMap[-2974209469121596207L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,1.000000f,0.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(293.230743f, -80.948425f);
            rt.sizeDelta = new Vector2(361.878204f, 62.000000f);
        }
        {
            var rt = goMap[-466336247164348598L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-1.000000f,-0.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(190.939102f, -31.000000f);
            rt.sizeDelta = new Vector2(321.878204f, 52.000000f);
        }
        {
            var rt = goMap[-5997505930059170972L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-7.000000f, 24.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }
        {
            var rt = goMap[5908975703055095190L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-151.000000f, 150.200012f);
            rt.sizeDelta = new Vector2(133.500000f, 135.600006f);
        }
        {
            var rt = goMap[5148513471992583216L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 0.000000f);
            rt.pivot = new Vector2(1.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-187.000000f, 83.000000f);
            rt.sizeDelta = new Vector2(320.000000f, 70.000000f);
        }
        {
            var rt = goMap[-4785109229607813661L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,1.000000f,0.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-1.753204f, 1.499900f);
            rt.sizeDelta = new Vector2(316.828796f, 0.000000f);
        }
        {
            var rt = goMap[-2574858918129457740L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-1.000000f,-0.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }
        {
            var rt = goMap[-8343107463257151270L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 18.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }
        {
            var rt = goMap[1753148528069889215L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-216.300003f, 32.799999f);
            rt.sizeDelta = new Vector2(96.699997f, 94.699997f);
        }
        {
            var rt = goMap[5676819858138041116L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 0.000000f);
            rt.pivot = new Vector2(1.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-329.000000f, 95.600006f);
            rt.sizeDelta = new Vector2(274.768066f, 70.000000f);
        }
        {
            var rt = goMap[-3781110672606624317L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,1.000000f,0.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.500000f);
            rt.anchorMax = new Vector2(1.000000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-123.599998f, -63.000000f);
            rt.sizeDelta = new Vector2(316.000000f, 0.000000f);
        }
        {
            var rt = goMap[7295734829272958014L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-1.000000f,-0.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }
        {
            var rt = goMap[-4850865735736333703L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-302.000000f, 203.000000f);
            rt.sizeDelta = new Vector2(96.699997f, 94.699997f);
        }
        {
            var rt = goMap[3780755287063704128L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-98.000000f, 61.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }
        {
            var rt = goMap[-8471628098597474029L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-202.699997f, 146.100006f);
            rt.sizeDelta = new Vector2(96.699997f, 94.699997f);
        }
        {
            var rt = goMap[8199726741110318071L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 0.000000f);
            rt.pivot = new Vector2(1.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-285.000000f, 150.000000f);
            rt.sizeDelta = new Vector2(300.000000f, 70.000000f);
        }
        {
            var rt = goMap[4805242172577387643L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,1.000000f,0.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.500000f);
            rt.anchorMax = new Vector2(1.000000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-150.874420f, -0.166820f);
            rt.sizeDelta = new Vector2(297.948914f, 39.666000f);
        }
        {
            var rt = goMap[4795910171104748309L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-1.000000f,-0.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }
        {
            var rt = goMap[-508633428186904768L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(1000.000000f, 0.000000f);
        }
        {
            var rt = goMap[-2726796319195115278L].AddComponent<RectTransform>();
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
            var rt = goMap[-6469343192085183996L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(17.559692f, -36.973801f);
            rt.sizeDelta = new Vector2(500.000000f, 205.947495f);
        }
        {
            var rt = goMap[-3891032748520993346L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(2.352200f, 28.519684f);
            rt.sizeDelta = new Vector2(466.966492f, 112.185799f);
        }
        {
            var rt = goMap[9170598462533964775L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(163.899994f, -65.000000f);
            rt.sizeDelta = new Vector2(120.000000f, 52.000000f);
        }
        {
            var rt = goMap[3412844272490231421L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 3.000000f);
            rt.sizeDelta = new Vector2(120.000000f, 40.000000f);
        }
        {
            var rt = goMap[-4761593256588574169L].AddComponent<RectTransform>();
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
            var rt = goMap[-3061470302727050666L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 1.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-135.899902f, -69.100098f);
            rt.sizeDelta = new Vector2(220.000000f, 60.000000f);
        }
        {
            var rt = goMap[-973023369422015549L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(200.000000f, 50.000000f);
        }
        {
            var rt = goMap[-8062276718836236906L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-31.372612f, 0.000000f);
            rt.sizeDelta = new Vector2(121.852097f, 50.000000f);
        }
        {
            var rt = goMap[-3842934937776548221L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(61.299999f, -9.100000f);
            rt.sizeDelta = new Vector2(47.000000f, 40.000000f);
        }

        // ─── Components ──────────────────────────────────────
        { var c = goMap[-7177879799564883097L].AddComponent<Canvas>();
           c.renderMode = (RenderMode)1;
           c.overrideSorting = false;
           c.sortingOrder = 20;
           c.sortingLayerID = unchecked((int)194136777);
           c.planeDistance = 100.000000f;
           c.pixelPerfect = false;
           c.additionalShaderChannels = (AdditionalCanvasShaderChannels)0;
           c.enabled = true;
        }
        { var c = goMap[-7177879799564883097L].AddComponent<CanvasScaler>();
           c.uiScaleMode = (CanvasScaler.ScaleMode)1;
           c.referenceResolution = new Vector2(1280.000000f, 720.000000f);
           c.screenMatchMode = (CanvasScaler.ScreenMatchMode)1;
           c.matchWidthOrHeight = 0.000000f;
           c.referencePixelsPerUnit = 100.000000f;
        }
        { var c = goMap[-7177879799564883097L].AddComponent<GraphicRaycaster>();
           c.ignoreReversedGraphics = true;
        }
        { var c = goMap[5404879705136466240L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("Hint"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[-5282736852163387596L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = false;
           c.maskable = true;
           c.type = Image.Type.Sliced;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("Kuang");
        }
        { var c = goMap[-2250885598557058657L].AddComponent<Image>();
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
        { var c = goMap[3636817037918806003L].AddComponent<Image>();
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
        { var c = goMap[-6605858033297056604L].AddComponent<Canvas>();
           c.renderMode = (RenderMode)2;
           c.overrideSorting = true;
           c.sortingOrder = 24;
           c.sortingLayerID = unchecked((int)194136777);
           c.planeDistance = 100.000000f;
           c.pixelPerfect = false;
           c.additionalShaderChannels = (AdditionalCanvasShaderChannels)0;
           c.enabled = true;
        }
        { var c = goMap[-8406771505707443812L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("UIGuide_Button_Hand"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[-9016395712270813862L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.537255f);
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
           c.sprite = LookupSprite("img_Circular");
        }
        { var c = goMap[-9139417458332817861L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_Circular");
        }
        { var c = goMap[1845275603623023359L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_guidehand");
        }
        { var c = goMap[4924190453350101875L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("UIGuide_Button_HandLong"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[3959402430916044455L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.537255f);
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
           c.sprite = LookupSprite("img_Circular");
        }
        { var c = goMap[3840510374141700581L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_Circular02");
        }
        { var c = goMap[-7020191555804081136L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_guidehand");
        }
        { var c = goMap[-8416979886323725499L].AddComponent<Canvas>();
           c.renderMode = (RenderMode)2;
           c.overrideSorting = true;
           c.sortingOrder = 24;
           c.sortingLayerID = unchecked((int)194136777);
           c.planeDistance = 100.000000f;
           c.pixelPerfect = false;
           c.additionalShaderChannels = (AdditionalCanvasShaderChannels)0;
           c.enabled = true;
        }
        { var c = goMap[-467051666674106938L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_dialogbox_left");
        }
        { var c = goMap[-467051666674106938L].AddComponent<VerticalLayoutGroup>();
           c.padding = new RectOffset(30,10,10,5);
           c.spacing = 0.000000f;
           c.childAlignment = (TextAnchor)2;
           c.childForceExpandWidth = false;
           c.childForceExpandHeight = false;
           c.childControlWidth = true;
           c.childControlHeight = true;
           c.reverseArrangement = false;
        }
        { var c = goMap[-467051666674106938L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)0;
           c.verticalFit = (ContentSizeFitter.FitMode)2;
        }
        { var c = goMap[-4490726443433652863L].AddComponent<Canvas>();
           c.renderMode = (RenderMode)2;
           c.overrideSorting = true;
           c.sortingOrder = 24;
           c.sortingLayerID = unchecked((int)194136777);
           c.planeDistance = 100.000000f;
           c.pixelPerfect = false;
           c.additionalShaderChannels = (AdditionalCanvasShaderChannels)0;
           c.enabled = true;
        }
        { var c = goMap[3887231386097525025L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_dialogbox_left");
        }
        { var c = goMap[3887231386097525025L].AddComponent<VerticalLayoutGroup>();
           c.padding = new RectOffset(30,10,10,5);
           c.spacing = 0.000000f;
           c.childAlignment = (TextAnchor)0;
           c.childForceExpandWidth = false;
           c.childForceExpandHeight = false;
           c.childControlWidth = true;
           c.childControlHeight = true;
           c.reverseArrangement = false;
        }
        { var c = goMap[3887231386097525025L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)0;
           c.verticalFit = (ContentSizeFitter.FitMode)2;
        }
        { var c = goMap[8336398003986287016L].AddComponent<Canvas>();
           c.renderMode = (RenderMode)2;
           c.overrideSorting = true;
           c.sortingOrder = 24;
           c.sortingLayerID = unchecked((int)194136777);
           c.planeDistance = 100.000000f;
           c.pixelPerfect = false;
           c.additionalShaderChannels = (AdditionalCanvasShaderChannels)0;
           c.enabled = true;
        }
        { var c = goMap[-1384332076755041754L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_dialogbox_down");
        }
        { var c = goMap[-1384332076755041754L].AddComponent<VerticalLayoutGroup>();
           c.padding = new RectOffset(5,5,10,30);
           c.spacing = 0.000000f;
           c.childAlignment = (TextAnchor)1;
           c.childForceExpandWidth = false;
           c.childForceExpandHeight = false;
           c.childControlWidth = true;
           c.childControlHeight = true;
           c.reverseArrangement = false;
        }
        { var c = goMap[-1384332076755041754L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)0;
           c.verticalFit = (ContentSizeFitter.FitMode)2;
        }
        { var c = goMap[-3552372717058218343L].AddComponent<Canvas>();
           c.renderMode = (RenderMode)2;
           c.overrideSorting = true;
           c.sortingOrder = 24;
           c.sortingLayerID = unchecked((int)194136777);
           c.planeDistance = 100.000000f;
           c.pixelPerfect = false;
           c.additionalShaderChannels = (AdditionalCanvasShaderChannels)0;
           c.enabled = true;
        }
        { var c = goMap[7744571632882739449L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_dialogbox_down");
        }
        { var c = goMap[7744571632882739449L].AddComponent<VerticalLayoutGroup>();
           c.padding = new RectOffset(5,5,10,30);
           c.spacing = 0.000000f;
           c.childAlignment = (TextAnchor)1;
           c.childForceExpandWidth = false;
           c.childForceExpandHeight = false;
           c.childControlWidth = true;
           c.childControlHeight = true;
           c.reverseArrangement = false;
        }
        { var c = goMap[7744571632882739449L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)0;
           c.verticalFit = (ContentSizeFitter.FitMode)2;
        }
        { var c = goMap[8720588907509217498L].AddComponent<Image>();
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
        { var c = goMap[8720588907509217498L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[8720588907509217498L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
        }
        { var c = goMap[1626526457021226341L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)0;
           c.verticalFit = (ContentSizeFitter.FitMode)0;
        }
        { var c = goMap[-1804296017267211100L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = false;
           c.maskable = true;
           c.type = Image.Type.Sliced;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_dialogbox_left");
        }
        { var c = goMap[-1804296017267211100L].AddComponent<VerticalLayoutGroup>();
           c.padding = new RectOffset(30,10,5,5);
           c.spacing = 5.000000f;
           c.childAlignment = (TextAnchor)4;
           c.childForceExpandWidth = false;
           c.childForceExpandHeight = false;
           c.childControlWidth = true;
           c.childControlHeight = true;
           c.reverseArrangement = false;
        }
        { var c = goMap[-1804296017267211100L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)0;
           c.verticalFit = (ContentSizeFitter.FitMode)2;
        }
        { var c = goMap[5812254403853625137L].AddComponent<Text>();
           c.text = "3164";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = false;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Overflow;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 1;
           c.resizeTextMaxSize = 40;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-2974209469121596207L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_dialogbox_left");
        }
        { var c = goMap[-2974209469121596207L].AddComponent<VerticalLayoutGroup>();
           c.padding = new RectOffset(30,10,5,5);
           c.spacing = 5.000000f;
           c.childAlignment = (TextAnchor)4;
           c.childForceExpandWidth = false;
           c.childForceExpandHeight = false;
           c.childControlWidth = true;
           c.childControlHeight = true;
           c.reverseArrangement = false;
        }
        { var c = goMap[-2974209469121596207L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)0;
           c.verticalFit = (ContentSizeFitter.FitMode)2;
        }
        { var c = goMap[-466336247164348598L].AddComponent<Text>();
           c.text = "1396";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleLeft;
           c.alignByGeometry = false;
           c.supportRichText = false;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Overflow;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 1;
           c.resizeTextMaxSize = 40;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-4785109229607813661L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = false;
           c.maskable = true;
           c.type = Image.Type.Sliced;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_dialogbox_left");
        }
        { var c = goMap[-4785109229607813661L].AddComponent<VerticalLayoutGroup>();
           c.padding = new RectOffset(30,10,5,5);
           c.spacing = 0.000000f;
           c.childAlignment = (TextAnchor)4;
           c.childForceExpandWidth = false;
           c.childForceExpandHeight = false;
           c.childControlWidth = true;
           c.childControlHeight = true;
           c.reverseArrangement = false;
        }
        { var c = goMap[-4785109229607813661L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)0;
           c.verticalFit = (ContentSizeFitter.FitMode)2;
        }
        { var c = goMap[-3781110672606624317L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = false;
           c.maskable = true;
           c.type = Image.Type.Sliced;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_dialogbox_left");
        }
        { var c = goMap[-3781110672606624317L].AddComponent<VerticalLayoutGroup>();
           c.padding = new RectOffset(30,10,5,5);
           c.spacing = 0.000000f;
           c.childAlignment = (TextAnchor)4;
           c.childForceExpandWidth = false;
           c.childForceExpandHeight = false;
           c.childControlWidth = true;
           c.childControlHeight = true;
           c.reverseArrangement = false;
        }
        { var c = goMap[-3781110672606624317L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)0;
           c.verticalFit = (ContentSizeFitter.FitMode)2;
        }
        { var c = goMap[4805242172577387643L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = false;
           c.maskable = true;
           c.type = Image.Type.Sliced;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_dialogbox_left");
        }
        { var c = goMap[4805242172577387643L].AddComponent<VerticalLayoutGroup>();
           c.padding = new RectOffset(30,10,5,5);
           c.spacing = 0.000000f;
           c.childAlignment = (TextAnchor)1;
           c.childForceExpandWidth = false;
           c.childForceExpandHeight = false;
           c.childControlWidth = true;
           c.childControlHeight = true;
           c.reverseArrangement = false;
        }
        { var c = goMap[4805242172577387643L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)0;
           c.verticalFit = (ContentSizeFitter.FitMode)0;
        }
        { var c = goMap[-508633428186904768L].AddComponent<Image>();
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
        }
        { var c = goMap[-6469343192085183996L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_dialogbox");
        }
        { var c = goMap[-3891032748520993346L].AddComponent<Text>();
           c.text = "4705";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 22;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.UpperLeft;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Overflow;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 1;
           c.resizeTextMaxSize = 40;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[9170598462533964775L].AddComponent<Image>();
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
        { var c = goMap[9170598462533964775L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[3412844272490231421L].AddComponent<Text>();
           c.text = "Ok";
           c.color = new Color(0.113725f, 0.309804f, 0.321569f, 1.000000f);
           c.fontSize = 22;
           c.fontStyle = FontStyle.Normal;
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
        { var c = goMap[-4761593256588574169L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-4761593256588574169L].AddComponent<Image>();
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
        }
        { var c = goMap[-3061470302727050666L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-973023369422015549L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_dialogbox");
        }
        { var c = goMap[-8062276718836236906L].AddComponent<Text>();
           c.text = "11413";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
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
           c.resizeTextMaxSize = 189;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-3842934937776548221L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_skip");
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
        var rootGO = goMap[-7177879799564883097L];
        string path = "Assets/Prefabs/Imported/UIGuide.prefab";
        PrefabUtility.SaveAsPrefabAsset(rootGO, path);
        Object.DestroyImmediate(rootGO);
        Debug.Log("[Import_res_p_85] Saved " + path);
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