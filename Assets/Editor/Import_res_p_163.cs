// AUTO-GENERATED from res_p_163.ab — DO NOT EDIT MANUALLY.
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;
using System.Collections.Generic;
using KTO.Game;  // UIJoyStick and other ported KTO scripts

public class Import_res_p_163
{
    [MenuItem("KTO/Import/res_p_163")]
    public static void Build()
    {
        Debug.Log("[Import_res_p_163] Building UIPartnerReInit...");

        // ─── Create all GameObjects ───────────────────────────
        var goMap = new Dictionary<long, GameObject>();
        var _toggleGroupByMbPid = new Dictionary<long, ToggleGroup>();
        var _toggleGroupLinks = new List<System.Tuple<Toggle,long>>();
        { var go = new GameObject("UIPartnerReInit"); go.SetActive(true); goMap[-5410072893380332074L] = go; }
        { var go = new GameObject("node"); go.SetActive(true); goMap[5850580688209458034L] = go; }
        { var go = new GameObject("UIBg3_1"); go.SetActive(true); goMap[7494715035987907443L] = go; }
        { var go = new GameObject("panel"); go.SetActive(true); goMap[-1779684940842059603L] = go; }
        { var go = new GameObject("imgShadow1"); go.SetActive(true); goMap[-4059674784957539576L] = go; }
        { var go = new GameObject("imgShadow2"); go.SetActive(true); goMap[4455496314685649504L] = go; }
        { var go = new GameObject("imgShadow3"); go.SetActive(true); goMap[8879796951415004425L] = go; }
        { var go = new GameObject("imgShadow4"); go.SetActive(true); goMap[143055057515559732L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(true); goMap[4313145087632134192L] = go; }
        { var go = new GameObject("imgTitleBg1"); go.SetActive(true); goMap[-3901781696768931636L] = go; }
        { var go = new GameObject("imgReflection"); go.SetActive(true); goMap[6004295168455961024L] = go; }
        { var go = new GameObject("imgBorderline1"); go.SetActive(true); goMap[2509697378878266614L] = go; }
        { var go = new GameObject("imgBorderline2"); go.SetActive(true); goMap[-3050881745245514223L] = go; }
        { var go = new GameObject("imgBorderline3"); go.SetActive(true); goMap[-8985092503837569299L] = go; }
        { var go = new GameObject("imgBorderline4"); go.SetActive(true); goMap[5827280906768274339L] = go; }
        { var go = new GameObject("imgListBg"); go.SetActive(false); goMap[3861332371569658488L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(false); goMap[8277754476641573448L] = go; }
        { var go = new GameObject("btnClose"); go.SetActive(true); goMap[-160205708699140850L] = go; }
        { var go = new GameObject("txtTitle"); go.SetActive(true); goMap[3419847499700644190L] = go; }
        { var go = new GameObject("bg"); go.SetActive(true); goMap[1266466318475729540L] = go; }
        { var go = new GameObject("QualitySkill"); go.SetActive(true); goMap[133225948079599699L] = go; }
        { var go = new GameObject("Quality1"); go.SetActive(true); goMap[-8598885523834656280L] = go; }
        { var go = new GameObject("bg"); go.SetActive(true); goMap[-4122777845558127274L] = go; }
        { var go = new GameObject("imgQualityBarBG"); go.SetActive(true); goMap[-4385978739059115831L] = go; }
        { var go = new GameObject("imgQualityBar"); go.SetActive(true); goMap[-6427192992196418075L] = go; }
        { var go = new GameObject("imgQualityBar_Effect"); go.SetActive(false); goMap[851463700560747827L] = go; }
        { var go = new GameObject("M1"); go.SetActive(true); goMap[-67354349515178974L] = go; }
        { var go = new GameObject("P1"); go.SetActive(true); goMap[-6430807423344192165L] = go; }
        { var go = new GameObject("txtAttribute"); go.SetActive(true); goMap[-9009237444553094871L] = go; }
        { var go = new GameObject("txtCharacter"); go.SetActive(true); goMap[4486421417911169886L] = go; }
        { var go = new GameObject("txtQualityPercent"); go.SetActive(true); goMap[-2099807119676130714L] = go; }
        { var go = new GameObject("Quality2"); go.SetActive(true); goMap[-2035843811035536436L] = go; }
        { var go = new GameObject("bg"); go.SetActive(true); goMap[8781423780937197358L] = go; }
        { var go = new GameObject("imgQualityBarBG"); go.SetActive(true); goMap[-610940867976778983L] = go; }
        { var go = new GameObject("imgQualityBar"); go.SetActive(true); goMap[3502854538788597306L] = go; }
        { var go = new GameObject("imgQualityBar_Effect"); go.SetActive(false); goMap[7554025343338323901L] = go; }
        { var go = new GameObject("M1"); go.SetActive(true); goMap[-3436924778316353601L] = go; }
        { var go = new GameObject("P1"); go.SetActive(true); goMap[6578022578581379951L] = go; }
        { var go = new GameObject("txtAttribute"); go.SetActive(true); goMap[3755328907183370457L] = go; }
        { var go = new GameObject("txtCharacter"); go.SetActive(true); goMap[-3747305104260330610L] = go; }
        { var go = new GameObject("txtQualityPercent"); go.SetActive(true); goMap[3905770104735356237L] = go; }
        { var go = new GameObject("Quality3"); go.SetActive(true); goMap[-3421183226499940821L] = go; }
        { var go = new GameObject("bg"); go.SetActive(true); goMap[922797256036937451L] = go; }
        { var go = new GameObject("imgQualityBarBG"); go.SetActive(true); goMap[-2239844057260797641L] = go; }
        { var go = new GameObject("imgQualityBar"); go.SetActive(true); goMap[-1984959195603795986L] = go; }
        { var go = new GameObject("imgQualityBar_Effect"); go.SetActive(false); goMap[-4575665093978911606L] = go; }
        { var go = new GameObject("M1"); go.SetActive(true); goMap[-7828605774377940568L] = go; }
        { var go = new GameObject("P1"); go.SetActive(true); goMap[-4558616916665230817L] = go; }
        { var go = new GameObject("txtAttribute"); go.SetActive(true); goMap[-227079422634081550L] = go; }
        { var go = new GameObject("txtCharacter"); go.SetActive(true); goMap[-6396870067947319844L] = go; }
        { var go = new GameObject("txtQualityPercent"); go.SetActive(true); goMap[-9047132102007231198L] = go; }
        { var go = new GameObject("Quality4"); go.SetActive(true); goMap[8529327201554145541L] = go; }
        { var go = new GameObject("bg"); go.SetActive(true); goMap[-4970120576498008350L] = go; }
        { var go = new GameObject("imgQualityBarBG"); go.SetActive(true); goMap[2672093836592867067L] = go; }
        { var go = new GameObject("imgQualityBar"); go.SetActive(true); goMap[-2105992937788106193L] = go; }
        { var go = new GameObject("imgQualityBar_Effect"); go.SetActive(false); goMap[-7838749108462703157L] = go; }
        { var go = new GameObject("M1"); go.SetActive(true); goMap[3925420964894919170L] = go; }
        { var go = new GameObject("P1"); go.SetActive(true); goMap[-5475272880499921619L] = go; }
        { var go = new GameObject("txtAttribute"); go.SetActive(true); goMap[458702011344636930L] = go; }
        { var go = new GameObject("txtCharacter"); go.SetActive(true); goMap[5004226595222933961L] = go; }
        { var go = new GameObject("txtQualityPercent"); go.SetActive(true); goMap[4332799141138955307L] = go; }
        { var go = new GameObject("ReinitEmpty"); go.SetActive(false); goMap[6108535212122570300L] = go; }
        { var go = new GameObject("imgEmpty"); go.SetActive(true); goMap[5844333978855182034L] = go; }
        { var go = new GameObject("btnReinit"); go.SetActive(true); goMap[-9211593674066273474L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-670353296265690981L] = go; }
        { var go = new GameObject("btnAutoReinit"); go.SetActive(true); goMap[5160442988426414571L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-2282156621995409748L] = go; }
        { var go = new GameObject("btnReplace"); go.SetActive(false); goMap[-2441641805026743177L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-2694580509888007265L] = go; }
        { var go = new GameObject("ReinitCost"); go.SetActive(true); goMap[-1682753631558012790L] = go; }
        { var go = new GameObject("UIItemGrid"); go.SetActive(true); goMap[383543286794136556L] = go; }
        { var go = new GameObject("bg"); go.SetActive(false); goMap[-8024987238189379648L] = go; }
        { var go = new GameObject("Base"); go.SetActive(true); goMap[-919924478232997977L] = go; }
        { var go = new GameObject("ItemLayer"); go.SetActive(false); goMap[7093341347546714490L] = go; }
        { var go = new GameObject("Fragment"); go.SetActive(false); goMap[2510925094617276713L] = go; }
        { var go = new GameObject("TagNew"); go.SetActive(false); goMap[6330680832290896538L] = go; }
        { var go = new GameObject("LabelSuffix"); go.SetActive(true); goMap[-4298640828377142221L] = go; }
        { var go = new GameObject("txtRBCorner"); go.SetActive(false); goMap[7629314859144525668L] = go; }
        { var go = new GameObject("txtCenter"); go.SetActive(false); goMap[-6594033756581925929L] = go; }
        { var go = new GameObject("txtLTCorner"); go.SetActive(false); goMap[-5815403467983410338L] = go; }
        { var go = new GameObject("ImgLTCorner"); go.SetActive(false); goMap[3853792538383831021L] = go; }
        { var go = new GameObject("CDLayer"); go.SetActive(true); goMap[-7569402894444356479L] = go; }
        { var go = new GameObject("imgPlus"); go.SetActive(false); goMap[-8872449966508473966L] = go; }
        { var go = new GameObject("TagTip"); go.SetActive(false); goMap[-3577185499396004986L] = go; }
        { var go = new GameObject("TagCanDeal"); go.SetActive(false); goMap[5680412702128867536L] = go; }
        { var go = new GameObject("TagMarketStall"); go.SetActive(false); goMap[7192507121656650451L] = go; }
        { var go = new GameObject("TagStone"); go.SetActive(false); goMap[5605055697399581361L] = go; }
        { var go = new GameObject("TagZhenJue"); go.SetActive(false); goMap[-9136409616608299134L] = go; }
        { var go = new GameObject("ImgRedPoint"); go.SetActive(false); goMap[4117322638209082459L] = go; }
        { var go = new GameObject("TagEquipSeries"); go.SetActive(false); goMap[-4658342696809846693L] = go; }
        { var go = new GameObject("Enhance"); go.SetActive(true); goMap[1530633624034008145L] = go; }
        { var go = new GameObject("imgRankBg"); go.SetActive(false); goMap[-4609731345817039726L] = go; }
        { var go = new GameObject("txtRank"); go.SetActive(true); goMap[-2655713632998841738L] = go; }
        { var go = new GameObject("imgRankSeries"); go.SetActive(false); goMap[-7089413113639677348L] = go; }
        { var go = new GameObject("txtRank"); go.SetActive(true); goMap[4706046074363466767L] = go; }
        { var go = new GameObject("ImgDivineWeaponLV"); go.SetActive(false); goMap[-5398067247424334998L] = go; }
        { var go = new GameObject("TxtLV"); go.SetActive(true); goMap[4393190126704144665L] = go; }
        { var go = new GameObject("imgQuestionMark"); go.SetActive(false); goMap[5406995166767751679L] = go; }
        { var go = new GameObject("Higher"); go.SetActive(false); goMap[5207598383567267271L] = go; }
        { var go = new GameObject("LabelHushi"); go.SetActive(false); goMap[8478666550144204964L] = go; }
        { var go = new GameObject("ImgSelect"); go.SetActive(false); goMap[4478440899085811207L] = go; }
        { var go = new GameObject("ImgSelect"); go.SetActive(true); goMap[-3612797643337757627L] = go; }
        { var go = new GameObject("ImgSelect (1)"); go.SetActive(true); goMap[6308573082619842946L] = go; }
        { var go = new GameObject("txtCostNum"); go.SetActive(true); goMap[8214297606069191566L] = go; }
        { var go = new GameObject("btnAdd"); go.SetActive(true); goMap[-1595199767371936622L] = go; }

        // ─── Parent links ─────────────────────────────────────
        goMap[5850580688209458034L].transform.SetParent(goMap[-5410072893380332074L].transform, false);
        goMap[7494715035987907443L].transform.SetParent(goMap[5850580688209458034L].transform, false);
        goMap[-1779684940842059603L].transform.SetParent(goMap[7494715035987907443L].transform, false);
        goMap[-4059674784957539576L].transform.SetParent(goMap[-1779684940842059603L].transform, false);
        goMap[4455496314685649504L].transform.SetParent(goMap[-1779684940842059603L].transform, false);
        goMap[8879796951415004425L].transform.SetParent(goMap[-1779684940842059603L].transform, false);
        goMap[143055057515559732L].transform.SetParent(goMap[-1779684940842059603L].transform, false);
        goMap[4313145087632134192L].transform.SetParent(goMap[-1779684940842059603L].transform, false);
        goMap[-3901781696768931636L].transform.SetParent(goMap[-1779684940842059603L].transform, false);
        goMap[6004295168455961024L].transform.SetParent(goMap[-1779684940842059603L].transform, false);
        goMap[2509697378878266614L].transform.SetParent(goMap[-1779684940842059603L].transform, false);
        goMap[-3050881745245514223L].transform.SetParent(goMap[-1779684940842059603L].transform, false);
        goMap[-8985092503837569299L].transform.SetParent(goMap[-1779684940842059603L].transform, false);
        goMap[5827280906768274339L].transform.SetParent(goMap[-1779684940842059603L].transform, false);
        goMap[3861332371569658488L].transform.SetParent(goMap[-1779684940842059603L].transform, false);
        goMap[8277754476641573448L].transform.SetParent(goMap[7494715035987907443L].transform, false);
        goMap[-160205708699140850L].transform.SetParent(goMap[5850580688209458034L].transform, false);
        goMap[3419847499700644190L].transform.SetParent(goMap[5850580688209458034L].transform, false);
        goMap[1266466318475729540L].transform.SetParent(goMap[5850580688209458034L].transform, false);
        goMap[133225948079599699L].transform.SetParent(goMap[5850580688209458034L].transform, false);
        goMap[-8598885523834656280L].transform.SetParent(goMap[133225948079599699L].transform, false);
        goMap[-4122777845558127274L].transform.SetParent(goMap[-8598885523834656280L].transform, false);
        goMap[-4385978739059115831L].transform.SetParent(goMap[-8598885523834656280L].transform, false);
        goMap[-6427192992196418075L].transform.SetParent(goMap[-8598885523834656280L].transform, false);
        goMap[851463700560747827L].transform.SetParent(goMap[-8598885523834656280L].transform, false);
        goMap[-67354349515178974L].transform.SetParent(goMap[851463700560747827L].transform, false);
        goMap[-6430807423344192165L].transform.SetParent(goMap[851463700560747827L].transform, false);
        goMap[-9009237444553094871L].transform.SetParent(goMap[-8598885523834656280L].transform, false);
        goMap[4486421417911169886L].transform.SetParent(goMap[-8598885523834656280L].transform, false);
        goMap[-2099807119676130714L].transform.SetParent(goMap[-8598885523834656280L].transform, false);
        goMap[-2035843811035536436L].transform.SetParent(goMap[133225948079599699L].transform, false);
        goMap[8781423780937197358L].transform.SetParent(goMap[-2035843811035536436L].transform, false);
        goMap[-610940867976778983L].transform.SetParent(goMap[-2035843811035536436L].transform, false);
        goMap[3502854538788597306L].transform.SetParent(goMap[-2035843811035536436L].transform, false);
        goMap[7554025343338323901L].transform.SetParent(goMap[-2035843811035536436L].transform, false);
        goMap[-3436924778316353601L].transform.SetParent(goMap[7554025343338323901L].transform, false);
        goMap[6578022578581379951L].transform.SetParent(goMap[7554025343338323901L].transform, false);
        goMap[3755328907183370457L].transform.SetParent(goMap[-2035843811035536436L].transform, false);
        goMap[-3747305104260330610L].transform.SetParent(goMap[-2035843811035536436L].transform, false);
        goMap[3905770104735356237L].transform.SetParent(goMap[-2035843811035536436L].transform, false);
        goMap[-3421183226499940821L].transform.SetParent(goMap[133225948079599699L].transform, false);
        goMap[922797256036937451L].transform.SetParent(goMap[-3421183226499940821L].transform, false);
        goMap[-2239844057260797641L].transform.SetParent(goMap[-3421183226499940821L].transform, false);
        goMap[-1984959195603795986L].transform.SetParent(goMap[-3421183226499940821L].transform, false);
        goMap[-4575665093978911606L].transform.SetParent(goMap[-3421183226499940821L].transform, false);
        goMap[-7828605774377940568L].transform.SetParent(goMap[-4575665093978911606L].transform, false);
        goMap[-4558616916665230817L].transform.SetParent(goMap[-4575665093978911606L].transform, false);
        goMap[-227079422634081550L].transform.SetParent(goMap[-3421183226499940821L].transform, false);
        goMap[-6396870067947319844L].transform.SetParent(goMap[-3421183226499940821L].transform, false);
        goMap[-9047132102007231198L].transform.SetParent(goMap[-3421183226499940821L].transform, false);
        goMap[8529327201554145541L].transform.SetParent(goMap[133225948079599699L].transform, false);
        goMap[-4970120576498008350L].transform.SetParent(goMap[8529327201554145541L].transform, false);
        goMap[2672093836592867067L].transform.SetParent(goMap[8529327201554145541L].transform, false);
        goMap[-2105992937788106193L].transform.SetParent(goMap[8529327201554145541L].transform, false);
        goMap[-7838749108462703157L].transform.SetParent(goMap[8529327201554145541L].transform, false);
        goMap[3925420964894919170L].transform.SetParent(goMap[-7838749108462703157L].transform, false);
        goMap[-5475272880499921619L].transform.SetParent(goMap[-7838749108462703157L].transform, false);
        goMap[458702011344636930L].transform.SetParent(goMap[8529327201554145541L].transform, false);
        goMap[5004226595222933961L].transform.SetParent(goMap[8529327201554145541L].transform, false);
        goMap[4332799141138955307L].transform.SetParent(goMap[8529327201554145541L].transform, false);
        goMap[6108535212122570300L].transform.SetParent(goMap[5850580688209458034L].transform, false);
        goMap[5844333978855182034L].transform.SetParent(goMap[6108535212122570300L].transform, false);
        goMap[-9211593674066273474L].transform.SetParent(goMap[5850580688209458034L].transform, false);
        goMap[-670353296265690981L].transform.SetParent(goMap[-9211593674066273474L].transform, false);
        goMap[5160442988426414571L].transform.SetParent(goMap[5850580688209458034L].transform, false);
        goMap[-2282156621995409748L].transform.SetParent(goMap[5160442988426414571L].transform, false);
        goMap[-2441641805026743177L].transform.SetParent(goMap[5850580688209458034L].transform, false);
        goMap[-2694580509888007265L].transform.SetParent(goMap[-2441641805026743177L].transform, false);
        goMap[-1682753631558012790L].transform.SetParent(goMap[5850580688209458034L].transform, false);
        goMap[383543286794136556L].transform.SetParent(goMap[-1682753631558012790L].transform, false);
        goMap[-8024987238189379648L].transform.SetParent(goMap[383543286794136556L].transform, false);
        goMap[-919924478232997977L].transform.SetParent(goMap[383543286794136556L].transform, false);
        goMap[7093341347546714490L].transform.SetParent(goMap[383543286794136556L].transform, false);
        goMap[2510925094617276713L].transform.SetParent(goMap[383543286794136556L].transform, false);
        goMap[6330680832290896538L].transform.SetParent(goMap[383543286794136556L].transform, false);
        goMap[-4298640828377142221L].transform.SetParent(goMap[383543286794136556L].transform, false);
        goMap[7629314859144525668L].transform.SetParent(goMap[383543286794136556L].transform, false);
        goMap[-6594033756581925929L].transform.SetParent(goMap[383543286794136556L].transform, false);
        goMap[-5815403467983410338L].transform.SetParent(goMap[383543286794136556L].transform, false);
        goMap[3853792538383831021L].transform.SetParent(goMap[383543286794136556L].transform, false);
        goMap[-7569402894444356479L].transform.SetParent(goMap[383543286794136556L].transform, false);
        goMap[-8872449966508473966L].transform.SetParent(goMap[383543286794136556L].transform, false);
        goMap[-3577185499396004986L].transform.SetParent(goMap[383543286794136556L].transform, false);
        goMap[5680412702128867536L].transform.SetParent(goMap[383543286794136556L].transform, false);
        goMap[7192507121656650451L].transform.SetParent(goMap[383543286794136556L].transform, false);
        goMap[5605055697399581361L].transform.SetParent(goMap[383543286794136556L].transform, false);
        goMap[-9136409616608299134L].transform.SetParent(goMap[383543286794136556L].transform, false);
        goMap[4117322638209082459L].transform.SetParent(goMap[383543286794136556L].transform, false);
        goMap[-4658342696809846693L].transform.SetParent(goMap[383543286794136556L].transform, false);
        goMap[1530633624034008145L].transform.SetParent(goMap[383543286794136556L].transform, false);
        goMap[-4609731345817039726L].transform.SetParent(goMap[383543286794136556L].transform, false);
        goMap[-2655713632998841738L].transform.SetParent(goMap[-4609731345817039726L].transform, false);
        goMap[-7089413113639677348L].transform.SetParent(goMap[383543286794136556L].transform, false);
        goMap[4706046074363466767L].transform.SetParent(goMap[-7089413113639677348L].transform, false);
        goMap[-5398067247424334998L].transform.SetParent(goMap[383543286794136556L].transform, false);
        goMap[4393190126704144665L].transform.SetParent(goMap[-5398067247424334998L].transform, false);
        goMap[5406995166767751679L].transform.SetParent(goMap[383543286794136556L].transform, false);
        goMap[5207598383567267271L].transform.SetParent(goMap[383543286794136556L].transform, false);
        goMap[8478666550144204964L].transform.SetParent(goMap[383543286794136556L].transform, false);
        goMap[4478440899085811207L].transform.SetParent(goMap[383543286794136556L].transform, false);
        goMap[-3612797643337757627L].transform.SetParent(goMap[4478440899085811207L].transform, false);
        goMap[6308573082619842946L].transform.SetParent(goMap[4478440899085811207L].transform, false);
        goMap[8214297606069191566L].transform.SetParent(goMap[-1682753631558012790L].transform, false);
        goMap[-1595199767371936622L].transform.SetParent(goMap[-1682753631558012790L].transform, false);

        // ─── RectTransforms ──────────────────────────────────
        {
            var rt = goMap[-5410072893380332074L].AddComponent<RectTransform>();
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
            var rt = goMap[5850580688209458034L].AddComponent<RectTransform>();
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
            var rt = goMap[7494715035987907443L].AddComponent<RectTransform>();
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
            var rt = goMap[-1779684940842059603L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(778.000000f, 508.000000f);
        }
        {
            var rt = goMap[-4059674784957539576L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(1.000000f, 0.000000f);
            rt.anchoredPosition = new Vector2(436.199005f, -289.514954f);
            rt.sizeDelta = new Vector2(576.098877f, 401.015015f);
        }
        {
            var rt = goMap[4455496314685649504L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, -1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(61.707066f, 204.581802f);
            rt.sizeDelta = new Vector2(748.687683f, 179.636703f);
        }
        {
            var rt = goMap[8879796951415004425L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,1.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, -1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-286.502014f, -146.905457f);
            rt.sizeDelta = new Vector2(291.039307f, 285.135986f);
        }
        {
            var rt = goMap[143055057515559732L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,1.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-384.388092f, 144.985535f);
            rt.sizeDelta = new Vector2(95.358101f, 298.171112f);
        }
        {
            var rt = goMap[4313145087632134192L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(1.897000f, -14.342500f);
            rt.sizeDelta = new Vector2(859.857910f, 536.684875f);
        }
        {
            var rt = goMap[-3901781696768931636L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(1.900000f, 256.399994f);
            rt.sizeDelta = new Vector2(859.859985f, 60.000000f);
        }
        {
            var rt = goMap[6004295168455961024L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(2.612100f, 284.910034f);
            rt.sizeDelta = new Vector2(853.323792f, 1.000000f);
        }
        {
            var rt = goMap[2509697378878266614L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(1.000000f, 0.000000f);
            rt.anchoredPosition = new Vector2(433.807617f, -285.456116f);
            rt.sizeDelta = new Vector2(567.211609f, 378.753510f);
        }
        {
            var rt = goMap[-3050881745245514223L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,0.707107f,0.707107f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(130.182556f, 191.513794f);
            rt.sizeDelta = new Vector2(196.480194f, 607.277527f);
        }
        {
            var rt = goMap[-8985092503837569299L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,0.707107f,-0.707107f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-281.529785f, -34.440479f);
            rt.sizeDelta = new Vector2(501.677612f, 296.199005f);
        }
        {
            var rt = goMap[5827280906768274339L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,1.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-301.540405f, 253.048096f);
            rt.sizeDelta = new Vector2(256.030792f, 73.438301f);
        }
        {
            var rt = goMap[3861332371569658488L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.627900f, -24.615999f);
            rt.sizeDelta = new Vector2(732.361389f, 417.641113f);
        }
        {
            var rt = goMap[8277754476641573448L].AddComponent<RectTransform>();
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
            var rt = goMap[-160205708699140850L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(405.600006f, 258.100006f);
            rt.sizeDelta = new Vector2(49.000000f, 54.000000f);
        }
        {
            var rt = goMap[3419847499700644190L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-410.299988f, 262.100006f);
            rt.sizeDelta = new Vector2(250.000000f, 50.000000f);
        }
        {
            var rt = goMap[1266466318475729540L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(1.800000f, 34.500000f);
            rt.sizeDelta = new Vector2(828.200012f, 374.200012f);
        }
        {
            var rt = goMap[133225948079599699L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(1.200000f, 42.000000f);
            rt.sizeDelta = new Vector2(823.000000f, 367.200012f);
        }
        {
            var rt = goMap[-8598885523834656280L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(800.000000f, 80.000000f);
        }
        {
            var rt = goMap[-4122777845558127274L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(800.000000f, 78.000000f);
        }
        {
            var rt = goMap[-4385978739059115831L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(52.000000f, -11.699951f);
            rt.sizeDelta = new Vector2(642.000000f, 10.000000f);
        }
        {
            var rt = goMap[-6427192992196418075L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(52.000000f, -11.700000f);
            rt.sizeDelta = new Vector2(640.000000f, 8.000000f);
        }
        {
            var rt = goMap[-9009237444553094871L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-343.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 40.000000f);
        }
        {
            var rt = goMap[4486421417911169886L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-214.000000f, 12.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 40.000000f);
        }
        {
            var rt = goMap[-2099807119676130714L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(222.000000f, 12.000000f);
            rt.sizeDelta = new Vector2(300.000000f, 40.000000f);
        }
        {
            var rt = goMap[-2035843811035536436L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(800.000000f, 80.000000f);
        }
        {
            var rt = goMap[8781423780937197358L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(800.000000f, 78.000000f);
        }
        {
            var rt = goMap[-610940867976778983L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(52.000000f, -11.600000f);
            rt.sizeDelta = new Vector2(642.000000f, 10.000000f);
        }
        {
            var rt = goMap[3502854538788597306L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(52.000000f, -11.600000f);
            rt.sizeDelta = new Vector2(640.000000f, 8.000000f);
        }
        {
            var rt = goMap[3755328907183370457L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-343.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 40.000000f);
        }
        {
            var rt = goMap[-3747305104260330610L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-214.000000f, 12.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 40.000000f);
        }
        {
            var rt = goMap[3905770104735356237L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(222.000000f, 12.000000f);
            rt.sizeDelta = new Vector2(300.000000f, 40.000000f);
        }
        {
            var rt = goMap[-3421183226499940821L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(800.000000f, 80.000000f);
        }
        {
            var rt = goMap[922797256036937451L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(800.000000f, 78.000000f);
        }
        {
            var rt = goMap[-2239844057260797641L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(52.000000f, -11.600000f);
            rt.sizeDelta = new Vector2(642.000000f, 10.000000f);
        }
        {
            var rt = goMap[-1984959195603795986L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(52.000000f, -11.600000f);
            rt.sizeDelta = new Vector2(640.000000f, 8.000000f);
        }
        {
            var rt = goMap[-227079422634081550L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-343.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 40.000000f);
        }
        {
            var rt = goMap[-6396870067947319844L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-214.000000f, 12.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 40.000000f);
        }
        {
            var rt = goMap[-9047132102007231198L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(222.000000f, 12.000000f);
            rt.sizeDelta = new Vector2(300.000000f, 40.000000f);
        }
        {
            var rt = goMap[8529327201554145541L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(800.000000f, 80.000000f);
        }
        {
            var rt = goMap[-4970120576498008350L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(800.000000f, 78.000000f);
        }
        {
            var rt = goMap[2672093836592867067L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(52.000000f, -11.600000f);
            rt.sizeDelta = new Vector2(642.000000f, 10.000000f);
        }
        {
            var rt = goMap[-2105992937788106193L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(52.000000f, -11.600000f);
            rt.sizeDelta = new Vector2(640.000000f, 8.000000f);
        }
        {
            var rt = goMap[458702011344636930L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-343.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 40.000000f);
        }
        {
            var rt = goMap[5004226595222933961L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-214.000000f, 12.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 40.000000f);
        }
        {
            var rt = goMap[4332799141138955307L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(222.000000f, 12.000000f);
            rt.sizeDelta = new Vector2(300.000000f, 40.000000f);
        }
        {
            var rt = goMap[6108535212122570300L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-26.000000f, -59.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[5844333978855182034L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(22.000000f, 119.000000f);
            rt.sizeDelta = new Vector2(302.000000f, 182.000000f);
        }
        {
            var rt = goMap[-9211593674066273474L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(100.000000f, -236.199997f);
            rt.sizeDelta = new Vector2(144.000000f, 52.000000f);
        }
        {
            var rt = goMap[-670353296265690981L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 3.000000f);
            rt.sizeDelta = new Vector2(144.000000f, 40.000000f);
        }
        {
            var rt = goMap[5160442988426414571L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-100.000000f, -236.199997f);
            rt.sizeDelta = new Vector2(144.000000f, 52.000000f);
        }
        {
            var rt = goMap[-2282156621995409748L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 3.000000f);
            rt.sizeDelta = new Vector2(144.000000f, 40.000000f);
        }
        {
            var rt = goMap[-2441641805026743177L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -236.199997f);
            rt.sizeDelta = new Vector2(144.000000f, 52.000000f);
        }
        {
            var rt = goMap[-2694580509888007265L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 3.000000f);
            rt.sizeDelta = new Vector2(144.000000f, 40.000000f);
        }
        {
            var rt = goMap[-1682753631558012790L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-84.000000f, -170.100006f);
            rt.sizeDelta = new Vector2(50.000000f, 50.000000f);
        }
        {
            var rt = goMap[383543286794136556L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.400000f, 0.400000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -1.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-8024987238189379648L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(110.000000f, 110.000000f);
        }
        {
            var rt = goMap[-919924478232997977L].AddComponent<RectTransform>();
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
            var rt = goMap[7093341347546714490L].AddComponent<RectTransform>();
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
            var rt = goMap[2510925094617276713L].AddComponent<RectTransform>();
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
            var rt = goMap[6330680832290896538L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.000000f, 1.000000f);
            rt.anchoredPosition = new Vector2(2.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(83.000000f, 25.620001f);
        }
        {
            var rt = goMap[-4298640828377142221L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.000000f);
            rt.anchorMax = new Vector2(0.500000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.000000f);
            rt.anchoredPosition = new Vector2(-0.700000f, 1.400002f);
            rt.sizeDelta = new Vector2(94.000000f, 40.000000f);
        }
        {
            var rt = goMap[7629314859144525668L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-33.879974f, 13.820000f);
            rt.sizeDelta = new Vector2(60.360001f, 35.000000f);
        }
        {
            var rt = goMap[-6594033756581925929L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(1.100000f, 12.900000f);
            rt.sizeDelta = new Vector2(100.000000f, 50.000000f);
        }
        {
            var rt = goMap[-5815403467983410338L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(96.000000f, 96.000000f);
        }
        {
            var rt = goMap[3853792538383831021L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(96.000000f, 96.000000f);
        }
        {
            var rt = goMap[-7569402894444356479L].AddComponent<RectTransform>();
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
            var rt = goMap[-8872449966508473966L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(54.000000f, 54.000000f);
        }
        {
            var rt = goMap[-3577185499396004986L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.000000f, 1.000000f);
            rt.anchoredPosition = new Vector2(2.000000f, 1.700001f);
            rt.sizeDelta = new Vector2(73.599998f, 30.000000f);
        }
        {
            var rt = goMap[5680412702128867536L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-34.000000f, -34.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 30.000000f);
        }
        {
            var rt = goMap[7192507121656650451L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-34.000000f, -34.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 30.000000f);
        }
        {
            var rt = goMap[5605055697399581361L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(34.000000f, 34.000000f);
            rt.sizeDelta = new Vector2(40.000000f, 40.000000f);
        }
        {
            var rt = goMap[-9136409616608299134L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(34.000000f, 34.000000f);
            rt.sizeDelta = new Vector2(24.000000f, 24.000000f);
        }
        {
            var rt = goMap[4117322638209082459L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 1.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-7.400002f, -7.400002f);
            rt.sizeDelta = new Vector2(20.000000f, 20.000000f);
        }
        {
            var rt = goMap[-4658342696809846693L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 1.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(1.000000f, 1.000000f);
            rt.anchoredPosition = new Vector2(-2.199982f, 0.799988f);
            rt.sizeDelta = new Vector2(38.000000f, 37.000000f);
        }
        {
            var rt = goMap[1530633624034008145L].AddComponent<RectTransform>();
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
            var rt = goMap[-4609731345817039726L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.800000f, 0.800000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(35.000000f, -35.680000f);
            rt.sizeDelta = new Vector2(36.000000f, 36.000000f);
        }
        {
            var rt = goMap[-2655713632998841738L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.250000f, 1.250000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000031f, -0.000019f);
            rt.sizeDelta = new Vector2(52.601101f, 36.000000f);
        }
        {
            var rt = goMap[-7089413113639677348L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.800000f, 0.800000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(35.000000f, 34.600021f);
            rt.sizeDelta = new Vector2(36.000000f, 36.000000f);
        }
        {
            var rt = goMap[4706046074363466767L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.250000f, 1.250000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000031f, -0.000019f);
            rt.sizeDelta = new Vector2(52.601101f, 36.000000f);
        }
        {
            var rt = goMap[-5398067247424334998L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(32.099998f, 31.799999f);
            rt.sizeDelta = new Vector2(30.000000f, 30.000000f);
        }
        {
            var rt = goMap[4393190126704144665L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-3.900000f, 2.100000f);
            rt.sizeDelta = new Vector2(29.799999f, 20.200001f);
        }
        {
            var rt = goMap[5406995166767751679L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(55.000000f, 62.000000f);
        }
        {
            var rt = goMap[5207598383567267271L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(110.000000f, 110.000000f);
        }
        {
            var rt = goMap[8478666550144204964L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 1.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(1.000000f, 1.000000f);
            rt.anchoredPosition = new Vector2(-0.000122f, 0.000000f);
            rt.sizeDelta = new Vector2(94.000000f, 40.000000f);
        }
        {
            var rt = goMap[4478440899085811207L].AddComponent<RectTransform>();
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
            var rt = goMap[-3612797643337757627L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(50.070587f, 44.799999f);
        }
        {
            var rt = goMap[6308573082619842946L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(50.070587f, 44.799999f);
        }
        {
            var rt = goMap[8214297606069191566L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(82.339096f, -3.700000f);
            rt.sizeDelta = new Vector2(104.876404f, 30.000000f);
        }
        {
            var rt = goMap[-1595199767371936622L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(166.500000f, -1.900000f);
            rt.sizeDelta = new Vector2(48.000000f, 52.000000f);
        }

        // ─── Components ──────────────────────────────────────
        { var c = goMap[-5410072893380332074L].AddComponent<Canvas>();
           c.renderMode = (RenderMode)1;
           c.overrideSorting = false;
           c.sortingOrder = 0;
           c.sortingLayerID = unchecked((int)194136777);
           c.planeDistance = 100.000000f;
           c.pixelPerfect = false;
           c.additionalShaderChannels = (AdditionalCanvasShaderChannels)0;
           c.enabled = true;
        }
        { var c = goMap[-5410072893380332074L].AddComponent<CanvasScaler>();
           c.uiScaleMode = (CanvasScaler.ScaleMode)1;
           c.referenceResolution = new Vector2(1280.000000f, 720.000000f);
           c.screenMatchMode = (CanvasScaler.ScreenMatchMode)1;
           c.matchWidthOrHeight = 0.000000f;
           c.referencePixelsPerUnit = 100.000000f;
        }
        { var c = goMap[-5410072893380332074L].AddComponent<GraphicRaycaster>();
           c.ignoreReversedGraphics = true;
        }
        { var c = goMap[-5410072893380332074L].AddComponent<Image>();
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
        { var c = goMap[7494715035987907443L].AddComponent<CanvasGroup>();
           c.alpha = 1.000000f;
           c.interactable = true;
           c.blocksRaycasts = true;
           c.ignoreParentGroups = false;
        }
        { var c = goMap[-4059674784957539576L].AddComponent<Image>();
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
        { var c = goMap[4455496314685649504L].AddComponent<Image>();
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
        { var c = goMap[8879796951415004425L].AddComponent<Image>();
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
        { var c = goMap[143055057515559732L].AddComponent<Image>();
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
        { var c = goMap[4313145087632134192L].AddComponent<Image>();
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
        { var c = goMap[-3901781696768931636L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_background_titlebg3_1");
        }
        { var c = goMap[6004295168455961024L].AddComponent<Image>();
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
        { var c = goMap[2509697378878266614L].AddComponent<Image>();
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
        { var c = goMap[-3050881745245514223L].AddComponent<Image>();
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
        { var c = goMap[-8985092503837569299L].AddComponent<Image>();
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
        { var c = goMap[5827280906768274339L].AddComponent<Image>();
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
        { var c = goMap[3861332371569658488L].AddComponent<Image>();
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
        { var c = goMap[8277754476641573448L].AddComponent<Image>();
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
        { var c = goMap[-160205708699140850L].AddComponent<Image>();
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
        { var c = goMap[-160205708699140850L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-160205708699140850L].AddComponent<UIScalePulse>();
           c.upScale = 0.950000f; c.duration = 0.100000f; c.scaleUp = false;
           c.enabled = true;
        }
        { var c = goMap[3419847499700644190L].AddComponent<Text>();
           c.text = "9904";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 26;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleLeft;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 16;
           c.resizeTextMaxSize = 26;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[1266466318475729540L].AddComponent<Image>();
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
        { var c = goMap[133225948079599699L].AddComponent<VerticalLayoutGroup>();
           c.padding = new RectOffset(0,0,0,0);
           c.spacing = 6.000000f;
           c.childAlignment = (TextAnchor)4;
           c.childForceExpandWidth = false;
           c.childForceExpandHeight = false;
           c.childControlWidth = false;
           c.childControlHeight = false;
           c.reverseArrangement = false;
        }
        { var c = goMap[-4122777845558127274L].AddComponent<Image>();
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
        { var c = goMap[-4385978739059115831L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_slider_bg");
        }
        { var c = goMap[-6427192992196418075L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = false;
           c.maskable = true;
           c.type = Image.Type.Filled;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Horizontal;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_patnergallery_slider");
        }
        { var c = goMap[851463700560747827L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("imgQualityBar_Effect"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[-9009237444553094871L].AddComponent<Text>();
           c.text = "8507";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
           c.fontSize = 24;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 24;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[4486421417911169886L].AddComponent<Text>();
           c.text = "12004";
           c.color = new Color(0.772549f, 0.427451f, 0.019608f, 1.000000f);
           c.fontSize = 22;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleLeft;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 22;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-2099807119676130714L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleRight;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 20;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[8781423780937197358L].AddComponent<Image>();
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
        { var c = goMap[-610940867976778983L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_slider_bg");
        }
        { var c = goMap[3502854538788597306L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = false;
           c.maskable = true;
           c.type = Image.Type.Filled;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Horizontal;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_patnergallery_slider");
        }
        { var c = goMap[7554025343338323901L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("imgQualityBar_Effect"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[3755328907183370457L].AddComponent<Text>();
           c.text = "4293";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
           c.fontSize = 24;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 24;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-3747305104260330610L].AddComponent<Text>();
           c.text = "12004";
           c.color = new Color(0.772549f, 0.427451f, 0.019608f, 1.000000f);
           c.fontSize = 22;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleLeft;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 22;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[3905770104735356237L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleRight;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 22;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[922797256036937451L].AddComponent<Image>();
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
        { var c = goMap[-2239844057260797641L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_slider_bg");
        }
        { var c = goMap[-1984959195603795986L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = false;
           c.maskable = true;
           c.type = Image.Type.Filled;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Horizontal;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_patnergallery_slider");
        }
        { var c = goMap[-4575665093978911606L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("imgQualityBar_Effect"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[-227079422634081550L].AddComponent<Text>();
           c.text = "7532";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
           c.fontSize = 24;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 24;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-6396870067947319844L].AddComponent<Text>();
           c.text = "12004";
           c.color = new Color(0.772549f, 0.427451f, 0.019608f, 1.000000f);
           c.fontSize = 22;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleLeft;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 22;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-9047132102007231198L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleRight;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 22;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-4970120576498008350L].AddComponent<Image>();
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
        { var c = goMap[2672093836592867067L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_slider_bg");
        }
        { var c = goMap[-2105992937788106193L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = false;
           c.maskable = true;
           c.type = Image.Type.Filled;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Horizontal;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_patnergallery_slider");
        }
        { var c = goMap[-7838749108462703157L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("imgQualityBar_Effect"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[458702011344636930L].AddComponent<Text>();
           c.text = "5265";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
           c.fontSize = 24;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 24;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[5004226595222933961L].AddComponent<Text>();
           c.text = "12004";
           c.color = new Color(0.772549f, 0.427451f, 0.019608f, 1.000000f);
           c.fontSize = 22;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleLeft;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 22;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[4332799141138955307L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleRight;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 22;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[5844333978855182034L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_honor_bg");
        }
        { var c = goMap[-9211593674066273474L].AddComponent<Image>();
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
        { var c = goMap[-9211593674066273474L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-670353296265690981L].AddComponent<Text>();
           c.text = "15873";
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
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 22;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[5160442988426414571L].AddComponent<Image>();
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
        { var c = goMap[5160442988426414571L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-2282156621995409748L].AddComponent<Text>();
           c.text = "16734";
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
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 22;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-2441641805026743177L].AddComponent<Image>();
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
        { var c = goMap[-2441641805026743177L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-2694580509888007265L].AddComponent<Text>();
           c.text = "15124";
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
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 22;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-8024987238189379648L].AddComponent<Image>();
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
           c.sprite = LookupSprite("itemframebg");
        }
        { var c = goMap[-919924478232997977L].AddComponent<Image>();
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
           c.sprite = LookupSprite("itembaseOrange");
        }
        { var c = goMap[7093341347546714490L].AddComponent<Image>();
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
           c.sprite = LookupSprite("chunyangwuji");
        }
        { var c = goMap[7093341347546714490L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[2510925094617276713L].AddComponent<Image>();
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
           c.sprite = LookupSprite("itemframe_fragment");
        }
        { var c = goMap[6330680832290896538L].AddComponent<Text>();
           c.text = "2695";
           c.color = new Color(0.984314f, 0.321569f, 0.321569f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleLeft;
           c.alignByGeometry = false;
           c.supportRichText = false;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 0;
           c.resizeTextMaxSize = 40;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[6330680832290896538L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-4298640828377142221L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(0.098039f, 0.984314f, 0.121569f, 1.000000f);
           c.fontSize = 22;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.LowerRight;
           c.alignByGeometry = false;
           c.supportRichText = false;
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
        { var c = goMap[-4298640828377142221L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[7629314859144525668L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(0.396078f, 0.984314f, 0.396078f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleRight;
           c.alignByGeometry = false;
           c.supportRichText = false;
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
        { var c = goMap[7629314859144525668L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-6594033756581925929L].AddComponent<Text>();
           c.text = "7569";
           c.color = new Color(0.896226f, 0.890460f, 0.705990f, 1.000000f);
           c.fontSize = 30;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = false;
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
        { var c = goMap[-6594033756581925929L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-5815403467983410338L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.UpperLeft;
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
        { var c = goMap[-5815403467983410338L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[3853792538383831021L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = false;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = true;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Horizontal;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("insetStone02");
        }
        { var c = goMap[-7569402894444356479L].AddComponent<Image>();
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
           c.sprite = LookupSprite("itemframeCDL");
        }
        { var c = goMap[-8872449966508473966L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_Plus");
        }
        { var c = goMap[-3577185499396004986L].AddComponent<Text>();
           c.text = "5318";
           c.color = new Color(0.396078f, 0.984314f, 0.396078f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleLeft;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 0;
           c.resizeTextMaxSize = 40;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-3577185499396004986L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[5680412702128867536L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_candeal");
        }
        { var c = goMap[7192507121656650451L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_baitan");
        }
        { var c = goMap[5605055697399581361L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_helm");
        }
        { var c = goMap[-9136409616608299134L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_common_empty");
        }
        { var c = goMap[4117322638209082459L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_redpoint");
        }
        { var c = goMap[-4658342696809846693L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_common_empty");
        }
        { var c = goMap[-4609731345817039726L].AddComponent<Image>();
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
           c.sprite = LookupSprite("item_rankbg");
        }
        { var c = goMap[-2655713632998841738L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 16;
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
        { var g = goMap[-2655713632998841738L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.866667f, 0.988235f, 0.933333f, 1.000000f); }
        { var c = goMap[-2655713632998841738L].AddComponent<Outline>();
           c.effectColor = new Color(0.227451f, 0.196078f, 0.078431f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-7089413113639677348L].AddComponent<Image>();
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
           c.sprite = LookupSprite("item_rankbg");
        }
        { var c = goMap[4706046074363466767L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 16;
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
        { var g = goMap[4706046074363466767L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.992157f, 0.886275f, 0.447059f, 1.000000f); }
        { var c = goMap[4706046074363466767L].AddComponent<Outline>();
           c.effectColor = new Color(0.227451f, 0.196078f, 0.078431f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-5398067247424334998L].AddComponent<Image>();
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
           c.sprite = LookupSprite("UIDivineWeapon_LV");
        }
        { var c = goMap[4393190126704144665L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(0.949020f, 0.886275f, 0.125490f, 1.000000f);
           c.fontSize = 14;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleLeft;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 1;
           c.resizeTextMaxSize = 14;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[4393190126704144665L].AddComponent<Outline>();
           c.effectColor = new Color(0.286275f, 0.090196f, 0.031373f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[5406995166767751679L].AddComponent<Image>();
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
           c.sprite = LookupSprite("UIDivineWeapon_QuestionMark");
        }
        { var c = goMap[5207598383567267271L].AddComponent<Image>();
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
           c.sprite = LookupSprite("itemhigh");
        }
        { var c = goMap[8478666550144204964L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(0.098039f, 0.984314f, 0.121569f, 1.000000f);
           c.fontSize = 22;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.UpperRight;
           c.alignByGeometry = false;
           c.supportRichText = false;
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
        { var c = goMap[8478666550144204964L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[4478440899085811207L].AddComponent<Image>();
           c.color = new Color(0.890196f, 0.878431f, 0.847059f, 0.549020f);
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
           c.sprite = LookupSprite("img_listbg01");
        }
        { var c = goMap[-3612797643337757627L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_checkmark");
        }
        { var c = goMap[-3612797643337757627L].AddComponent<Outline>();
           c.effectColor = new Color(0.584906f, 0.584906f, 0.584906f, 0.262745f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[6308573082619842946L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_checkmark");
        }
        { var c = goMap[6308573082619842946L].AddComponent<Outline>();
           c.effectColor = new Color(0.584906f, 0.584906f, 0.584906f, 0.262745f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[8214297606069191566L].AddComponent<Text>();
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
           c.resizeTextMinSize = 12;
           c.resizeTextMaxSize = 20;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-1595199767371936622L].AddComponent<Image>();
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
           c.sprite = LookupSprite("btn_plus");
        }
        { var c = goMap[-1595199767371936622L].AddComponent<Button>();
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
        var rootGO = goMap[-5410072893380332074L];
        string path = "Assets/Prefabs/Imported/UIPartnerReInit.prefab";
        PrefabUtility.SaveAsPrefabAsset(rootGO, path);
        Object.DestroyImmediate(rootGO);
        Debug.Log("[Import_res_p_163] Saved " + path);
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