// AUTO-GENERATED from res_p_41.ab — DO NOT EDIT MANUALLY.
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;
using System.Collections.Generic;
using KTO.Game;  // UIJoyStick and other ported KTO scripts

public class Import_res_p_41
{
    [MenuItem("KTO/Import/res_p_41")]
    public static void Build()
    {
        Debug.Log("[Import_res_p_41] Building UICardPicking...");

        // ─── Create all GameObjects ───────────────────────────
        var goMap = new Dictionary<long, GameObject>();
        var _toggleGroupByMbPid = new Dictionary<long, ToggleGroup>();
        var _toggleGroupLinks = new List<System.Tuple<Toggle,long>>();
        { var go = new GameObject("UICardPicking"); go.SetActive(true); goMap[8488265890266967383L] = go; }
        { var go = new GameObject("node"); go.SetActive(true); goMap[3432722095087552304L] = go; }
        { var go = new GameObject("imgBlackBg"); go.SetActive(true); goMap[-8402512713859439503L] = go; }
        { var go = new GameObject("imgBG"); go.SetActive(true); goMap[-727019389098517411L] = go; }
        { var go = new GameObject("bg"); go.SetActive(true); goMap[1982603842814787085L] = go; }
        { var go = new GameObject("imgJiGuang03"); go.SetActive(true); goMap[-3594115841788442285L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[-5942139603788536574L] = go; }
        { var go = new GameObject("imgJiGuang"); go.SetActive(true); goMap[6815922576319909644L] = go; }
        { var go = new GameObject("imgJiGuang02"); go.SetActive(true); goMap[3687912689639509416L] = go; }
        { var go = new GameObject("imgGearBg"); go.SetActive(true); goMap[565368244621494339L] = go; }
        { var go = new GameObject("imgMountain"); go.SetActive(true); goMap[8298837295344329456L] = go; }
        { var go = new GameObject("Mask"); go.SetActive(true); goMap[-841196698099187192L] = go; }
        { var go = new GameObject("imgCloud"); go.SetActive(true); goMap[-7890508024511743196L] = go; }
        { var go = new GameObject("Mask"); go.SetActive(true); goMap[7887652042451992401L] = go; }
        { var go = new GameObject("imgGlobe"); go.SetActive(true); goMap[-1591075058762437341L] = go; }
        { var go = new GameObject("imgHorse"); go.SetActive(true); goMap[-1184573606940376265L] = go; }
        { var go = new GameObject("imgRingBottom"); go.SetActive(true); goMap[-6428946152323728548L] = go; }
        { var go = new GameObject("imgRingOuter"); go.SetActive(true); goMap[-5711732007658525353L] = go; }
        { var go = new GameObject("Mask"); go.SetActive(true); goMap[-293907160034285384L] = go; }
        { var go = new GameObject("imgStarBg4"); go.SetActive(true); goMap[7991345737667163285L] = go; }
        { var go = new GameObject("Mask"); go.SetActive(true); goMap[8361467419616652643L] = go; }
        { var go = new GameObject("imgStarBg3"); go.SetActive(true); goMap[3511242877104800945L] = go; }
        { var go = new GameObject("Mask"); go.SetActive(true); goMap[6615463466769062428L] = go; }
        { var go = new GameObject("imgStarBg2"); go.SetActive(true); goMap[2398113249511592448L] = go; }
        { var go = new GameObject("imgStarBg1"); go.SetActive(true); goMap[6327760054969521137L] = go; }
        { var go = new GameObject("imgSeriesBg"); go.SetActive(true); goMap[-2569621866669391282L] = go; }
        { var go = new GameObject("imgSeriesStar"); go.SetActive(true); goMap[5303127807043023L] = go; }
        { var go = new GameObject("imgRingGear"); go.SetActive(true); goMap[-1043810183160555437L] = go; }
        { var go = new GameObject("imgGear4"); go.SetActive(true); goMap[1901938497584640671L] = go; }
        { var go = new GameObject("imgGear3"); go.SetActive(true); goMap[-6733511279965042318L] = go; }
        { var go = new GameObject("imgGear2"); go.SetActive(true); goMap[8564290531328720642L] = go; }
        { var go = new GameObject("imgGear1"); go.SetActive(true); goMap[7741180381710505499L] = go; }
        { var go = new GameObject("imgRingSun"); go.SetActive(true); goMap[-2952062928896845932L] = go; }
        { var go = new GameObject("imgRingMoon"); go.SetActive(true); goMap[6279653949285857500L] = go; }
        { var go = new GameObject("imgRingFire"); go.SetActive(true); goMap[8410273798647024909L] = go; }
        { var go = new GameObject("imgRingSeries"); go.SetActive(true); goMap[-3219709866010276470L] = go; }
        { var go = new GameObject("YuanSuQiu"); go.SetActive(true); goMap[3157053181698028121L] = go; }
        { var go = new GameObject("imgFire"); go.SetActive(true); goMap[8273258284709245734L] = go; }
        { var go = new GameObject("imgWood"); go.SetActive(true); goMap[4787447207069417974L] = go; }
        { var go = new GameObject("imgEarth"); go.SetActive(true); goMap[8884574594086861162L] = go; }
        { var go = new GameObject("imgWater"); go.SetActive(true); goMap[1404864418907660212L] = go; }
        { var go = new GameObject("imgMetal"); go.SetActive(true); goMap[-6636399163737974014L] = go; }
        { var go = new GameObject("imgTitleBg"); go.SetActive(true); goMap[-1217823057774440474L] = go; }
        { var go = new GameObject("Bird_Effect"); go.SetActive(true); goMap[-8110082751761284409L] = go; }
        { var go = new GameObject("Bird_01"); go.SetActive(true); goMap[2400593736662930177L] = go; }
        { var go = new GameObject("Bird_02"); go.SetActive(true); goMap[7226181275852399629L] = go; }
        { var go = new GameObject("Bird_03"); go.SetActive(true); goMap[9191190653154371236L] = go; }
        { var go = new GameObject("Particle System"); go.SetActive(true); goMap[-4041538412887928506L] = go; }
        { var go = new GameObject("Bird_04"); go.SetActive(true); goMap[-2218499223665582272L] = go; }
        { var go = new GameObject("Bird_05"); go.SetActive(true); goMap[5750446410562144682L] = go; }
        { var go = new GameObject("Particle System (1)"); go.SetActive(true); goMap[1897835921189949724L] = go; }
        { var go = new GameObject("Bird_06"); go.SetActive(true); goMap[-6835598671864719944L] = go; }
        { var go = new GameObject("Particle System (1)"); go.SetActive(true); goMap[-6595088515822573330L] = go; }
        { var go = new GameObject("Bird_07"); go.SetActive(true); goMap[8518839110843131814L] = go; }
        { var go = new GameObject("Effect"); go.SetActive(true); goMap[6934137438260105287L] = go; }
        { var go = new GameObject("Star"); go.SetActive(true); goMap[4214660436316737365L] = go; }
        { var go = new GameObject("Star02"); go.SetActive(true); goMap[-4733521636791453260L] = go; }
        { var go = new GameObject("OutEffect"); go.SetActive(true); goMap[-8143682158849816832L] = go; }
        { var go = new GameObject("Quad"); go.SetActive(true); goMap[-686363828142586293L] = go; }
        { var go = new GameObject("Quad (1)"); go.SetActive(true); goMap[8115079907332279429L] = go; }
        { var go = new GameObject("Quad (2)"); go.SetActive(true); goMap[2472659582224810934L] = go; }
        { var go = new GameObject("UICardPicking_Effect"); go.SetActive(false); goMap[-7466510617700566567L] = go; }
        { var go = new GameObject("Mod_jujiwuci1001"); go.SetActive(true); goMap[472537345441188551L] = go; }
        { var go = new GameObject("Box001"); go.SetActive(true); goMap[-5469666316680963947L] = go; }
        { var go = new GameObject("jin"); go.SetActive(true); goMap[-4429525410057714824L] = go; }
        { var go = new GameObject("p1"); go.SetActive(true); goMap[1550006121014779165L] = go; }
        { var go = new GameObject("p2"); go.SetActive(true); goMap[-9141241293201637460L] = go; }
        { var go = new GameObject("p6"); go.SetActive(true); goMap[5382801336684128246L] = go; }
        { var go = new GameObject("p4"); go.SetActive(true); goMap[4328028358397430183L] = go; }
        { var go = new GameObject("Trail_M1"); go.SetActive(true); goMap[-488559854030737127L] = go; }
        { var go = new GameObject("Trail_M2"); go.SetActive(true); goMap[5217727488177608270L] = go; }
        { var go = new GameObject("Box002"); go.SetActive(true); goMap[6846485623929866283L] = go; }
        { var go = new GameObject("tu"); go.SetActive(true); goMap[-6189248757309018026L] = go; }
        { var go = new GameObject("p1"); go.SetActive(true); goMap[-164838050581879932L] = go; }
        { var go = new GameObject("p2"); go.SetActive(true); goMap[6285640685354125342L] = go; }
        { var go = new GameObject("p7"); go.SetActive(true); goMap[5343506600475808933L] = go; }
        { var go = new GameObject("p4"); go.SetActive(true); goMap[2620061469977811763L] = go; }
        { var go = new GameObject("Trail_M5"); go.SetActive(true); goMap[-302869262422098606L] = go; }
        { var go = new GameObject("Trail_M1"); go.SetActive(true); goMap[-6269287152878739103L] = go; }
        { var go = new GameObject("Box003"); go.SetActive(true); goMap[-1476184024059854677L] = go; }
        { var go = new GameObject("mu"); go.SetActive(true); goMap[8992892915332468396L] = go; }
        { var go = new GameObject("p1"); go.SetActive(true); goMap[7008253948009600786L] = go; }
        { var go = new GameObject("p2"); go.SetActive(true); goMap[-7608174147774759283L] = go; }
        { var go = new GameObject("p3"); go.SetActive(true); goMap[6825658664992138085L] = go; }
        { var go = new GameObject("p4"); go.SetActive(true); goMap[8918917474154835641L] = go; }
        { var go = new GameObject("Trail_M3"); go.SetActive(true); goMap[8970842521214332304L] = go; }
        { var go = new GameObject("Trail_M1"); go.SetActive(true); goMap[8504979032295906937L] = go; }
        { var go = new GameObject("Box004"); go.SetActive(true); goMap[7592298268414787731L] = go; }
        { var go = new GameObject("shui"); go.SetActive(true); goMap[-6246916133645389376L] = go; }
        { var go = new GameObject("p1"); go.SetActive(true); goMap[-5077782991732375118L] = go; }
        { var go = new GameObject("p2"); go.SetActive(true); goMap[-7847146972306225455L] = go; }
        { var go = new GameObject("p5"); go.SetActive(true); goMap[6799422191118892541L] = go; }
        { var go = new GameObject("p4"); go.SetActive(true); goMap[8524469053154139689L] = go; }
        { var go = new GameObject("Trail_M3"); go.SetActive(true); goMap[-6848584943358801093L] = go; }
        { var go = new GameObject("Trail_M4"); go.SetActive(true); goMap[-6500092477773620442L] = go; }
        { var go = new GameObject("Box005"); go.SetActive(true); goMap[3575363841926022619L] = go; }
        { var go = new GameObject("huo"); go.SetActive(true); goMap[-7014492547962059803L] = go; }
        { var go = new GameObject("p1"); go.SetActive(true); goMap[-7043875470267885326L] = go; }
        { var go = new GameObject("p2"); go.SetActive(true); goMap[-8086148329928305891L] = go; }
        { var go = new GameObject("p8"); go.SetActive(true); goMap[-1020969830788694311L] = go; }
        { var go = new GameObject("p4"); go.SetActive(true); goMap[-1868716943941590707L] = go; }
        { var go = new GameObject("Trail_M1"); go.SetActive(true); goMap[4083078308365539604L] = go; }
        { var go = new GameObject("Trail_M6"); go.SetActive(true); goMap[-129118376413079066L] = go; }
        { var go = new GameObject("Line001"); go.SetActive(true); goMap[6465992102140605518L] = go; }
        { var go = new GameObject("Line002"); go.SetActive(true); goMap[8434818770287625550L] = go; }
        { var go = new GameObject("Line003"); go.SetActive(true); goMap[1537426635999012079L] = go; }
        { var go = new GameObject("Line004"); go.SetActive(true); goMap[-1075602777025141499L] = go; }
        { var go = new GameObject("Line005"); go.SetActive(true); goMap[6752527139853472558L] = go; }
        { var go = new GameObject("d_TS_1008_wujiaoxingM7"); go.SetActive(true); goMap[1035266336662304956L] = go; }
        { var go = new GameObject("P9"); go.SetActive(true); goMap[-7723362146751102988L] = go; }
        { var go = new GameObject("EF"); go.SetActive(true); goMap[-9016405377741203834L] = go; }
        { var go = new GameObject("P10"); go.SetActive(true); goMap[-1335227214337310650L] = go; }
        { var go = new GameObject("P11"); go.SetActive(true); goMap[2062140978601065241L] = go; }
        { var go = new GameObject("P12"); go.SetActive(true); goMap[2870233093808539183L] = go; }
        { var go = new GameObject("M8"); go.SetActive(true); goMap[786264882936288372L] = go; }
        { var go = new GameObject("P11"); go.SetActive(true); goMap[-8558215722793373928L] = go; }
        { var go = new GameObject("M8"); go.SetActive(true); goMap[8726575937728168960L] = go; }
        { var go = new GameObject("M9"); go.SetActive(true); goMap[-5520562687165408102L] = go; }
        { var go = new GameObject("M7"); go.SetActive(true); goMap[-7619656313873159478L] = go; }
        { var go = new GameObject("M3_1"); go.SetActive(true); goMap[-4832961104113422847L] = go; }
        { var go = new GameObject("M1"); go.SetActive(true); goMap[-7347409604111662783L] = go; }
        { var go = new GameObject("P11"); go.SetActive(true); goMap[3450924580830249706L] = go; }
        { var go = new GameObject("P13"); go.SetActive(true); goMap[4235556532880477220L] = go; }
        { var go = new GameObject("txtTitle"); go.SetActive(true); goMap[-2839755288168311429L] = go; }
        { var go = new GameObject("btnHelp"); go.SetActive(true); goMap[-2516122796516724038L] = go; }
        { var go = new GameObject("btnClose"); go.SetActive(true); goMap[-2473557872573465369L] = go; }
        { var go = new GameObject("Content"); go.SetActive(true); goMap[-245956512253236384L] = go; }
        { var go = new GameObject("CoinPicking"); go.SetActive(true); goMap[5032415346774507646L] = go; }
        { var go = new GameObject("txtTitle"); go.SetActive(false); goMap[4843594694523125305L] = go; }
        { var go = new GameObject("imgCostBg1"); go.SetActive(true); goMap[-6600965532740033953L] = go; }
        { var go = new GameObject("imgCostBg2"); go.SetActive(true); goMap[-5618731616431581897L] = go; }
        { var go = new GameObject("IconCoinTenPick"); go.SetActive(true); goMap[682438437019941539L] = go; }
        { var go = new GameObject("txtCoinTenPickValue"); go.SetActive(true); goMap[6504730874239599200L] = go; }
        { var go = new GameObject("IconCoinPick"); go.SetActive(true); goMap[-9217820294083067492L] = go; }
        { var go = new GameObject("txtCoinPickValue"); go.SetActive(true); goMap[406679844311860663L] = go; }
        { var go = new GameObject("txtCountdown"); go.SetActive(true); goMap[9207926932567190988L] = go; }
        { var go = new GameObject("TipsList"); go.SetActive(true); goMap[8701593904009747291L] = go; }
        { var go = new GameObject("Tip1"); go.SetActive(true); goMap[-5244937048036067546L] = go; }
        { var go = new GameObject("txtTips1"); go.SetActive(true); goMap[4967085122485019591L] = go; }
        { var go = new GameObject("btnCoinTenPick"); go.SetActive(true); goMap[7152697645036802261L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-9057733414298528348L] = go; }
        { var go = new GameObject("btnCoinFreePick"); go.SetActive(true); goMap[-7791846722860623392L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-1553339685355409413L] = go; }
        { var go = new GameObject("btnCoinPick"); go.SetActive(true); goMap[7895314578790749011L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[8637730948199539788L] = go; }
        { var go = new GameObject("YuanbaoPicking"); go.SetActive(false); goMap[1146982383690712088L] = go; }
        { var go = new GameObject("txtTitle"); go.SetActive(false); goMap[-4562595303296709612L] = go; }
        { var go = new GameObject("imgCostBg1"); go.SetActive(true); goMap[5965815757721803110L] = go; }
        { var go = new GameObject("imgCostBg2"); go.SetActive(true); goMap[-1617217154484790522L] = go; }
        { var go = new GameObject("IconYuanbaoTenPick"); go.SetActive(true); goMap[9106837831493246356L] = go; }
        { var go = new GameObject("txtYuanbaoTenPickValue"); go.SetActive(true); goMap[-2767264387412471131L] = go; }
        { var go = new GameObject("IconYuanbaoPick"); go.SetActive(true); goMap[7017668181765069936L] = go; }
        { var go = new GameObject("txtYuanbaoPickValue"); go.SetActive(true); goMap[-1744136361377404306L] = go; }
        { var go = new GameObject("TipsList"); go.SetActive(true); goMap[8231272342598237991L] = go; }
        { var go = new GameObject("Tip1"); go.SetActive(true); goMap[-5812334629962007393L] = go; }
        { var go = new GameObject("txtTips1"); go.SetActive(true); goMap[-119621910670385602L] = go; }
        { var go = new GameObject("Tip2"); go.SetActive(true); goMap[-6655983027467726292L] = go; }
        { var go = new GameObject("txtTips2"); go.SetActive(true); goMap[7051625277701727968L] = go; }
        { var go = new GameObject("btnYuanbaoTenPick"); go.SetActive(true); goMap[-2328435651856328067L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-744882191105418117L] = go; }
        { var go = new GameObject("btnYuanbaoFreePick"); go.SetActive(true); goMap[1348093236012001220L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[3316004050531752473L] = go; }
        { var go = new GameObject("btnYuanbaoPick"); go.SetActive(true); goMap[9199019186969940133L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-7983737703374674949L] = go; }
        { var go = new GameObject("txtCountdown"); go.SetActive(true); goMap[-7759841132039646220L] = go; }
        { var go = new GameObject("txtPickingTips"); go.SetActive(true); goMap[-765433985854971512L] = go; }
        { var go = new GameObject("BtnList"); go.SetActive(true); goMap[-392127840509104546L] = go; }
        { var go = new GameObject("btnCoin"); go.SetActive(true); goMap[3603475799401199237L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[3558254300272522728L] = go; }
        { var go = new GameObject("imgCoin"); go.SetActive(true); goMap[-1381450238515527290L] = go; }
        { var go = new GameObject("btnYuanBao"); go.SetActive(true); goMap[-6225199957836733390L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-580275674457841963L] = go; }
        { var go = new GameObject("imgCoin"); go.SetActive(true); goMap[-955243112007814197L] = go; }
        { var go = new GameObject("UIMoneyPanel"); go.SetActive(true); goMap[1215796524404458935L] = go; }
        { var go = new GameObject("panelList"); go.SetActive(true); goMap[-1612561385618020114L] = go; }
        { var go = new GameObject("panelDynamic"); go.SetActive(false); goMap[8186067839504991436L] = go; }
        { var go = new GameObject("BgDynamic"); go.SetActive(true); goMap[-7667441771603489850L] = go; }
        { var go = new GameObject("txtDynamic"); go.SetActive(true); goMap[-1691431904063077257L] = go; }
        { var go = new GameObject("imgDynamic"); go.SetActive(true); goMap[4678354735297362310L] = go; }
        { var go = new GameObject("btnPlusDynamic"); go.SetActive(true); goMap[4107407001160041755L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[-6653825462572527407L] = go; }
        { var go = new GameObject("panelCoin"); go.SetActive(true); goMap[1936851170976014562L] = go; }
        { var go = new GameObject("BgCoin"); go.SetActive(true); goMap[-6284617653211960201L] = go; }
        { var go = new GameObject("txtCoinValue"); go.SetActive(true); goMap[-6069441402752727261L] = go; }
        { var go = new GameObject("imgCoin"); go.SetActive(true); goMap[-7486834131713475463L] = go; }
        { var go = new GameObject("btnPlusCoin"); go.SetActive(true); goMap[-9151381461575678063L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[6636252723562815900L] = go; }
        { var go = new GameObject("panelYuanBao"); go.SetActive(true); goMap[7903546794408889579L] = go; }
        { var go = new GameObject("BgYuanBao"); go.SetActive(true); goMap[4374079833165044205L] = go; }
        { var go = new GameObject("txtYuanBaoValue"); go.SetActive(true); goMap[7336140254322941212L] = go; }
        { var go = new GameObject("imgYuanBao"); go.SetActive(true); goMap[-3270507227197917854L] = go; }
        { var go = new GameObject("btnPlusYuanBao"); go.SetActive(true); goMap[-7507518031372023205L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[8577955914320050187L] = go; }
        { var go = new GameObject("panelGold"); go.SetActive(true); goMap[1809633201303292420L] = go; }
        { var go = new GameObject("BgGold"); go.SetActive(true); goMap[8483222073349620622L] = go; }
        { var go = new GameObject("txtGoldValue"); go.SetActive(true); goMap[8628338640451584517L] = go; }
        { var go = new GameObject("imgGold"); go.SetActive(true); goMap[-5077010686124561213L] = go; }
        { var go = new GameObject("btnPlusGold"); go.SetActive(true); goMap[3821490267352828035L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[-3894695405590301992L] = go; }

        // ─── Parent links ─────────────────────────────────────
        goMap[3432722095087552304L].transform.SetParent(goMap[8488265890266967383L].transform, false);
        goMap[-8402512713859439503L].transform.SetParent(goMap[3432722095087552304L].transform, false);
        goMap[-727019389098517411L].transform.SetParent(goMap[3432722095087552304L].transform, false);
        goMap[1982603842814787085L].transform.SetParent(goMap[-727019389098517411L].transform, false);
        goMap[-3594115841788442285L].transform.SetParent(goMap[1982603842814787085L].transform, false);
        goMap[-5942139603788536574L].transform.SetParent(goMap[-3594115841788442285L].transform, false);
        goMap[6815922576319909644L].transform.SetParent(goMap[1982603842814787085L].transform, false);
        goMap[3687912689639509416L].transform.SetParent(goMap[1982603842814787085L].transform, false);
        goMap[565368244621494339L].transform.SetParent(goMap[1982603842814787085L].transform, false);
        goMap[8298837295344329456L].transform.SetParent(goMap[1982603842814787085L].transform, false);
        goMap[-841196698099187192L].transform.SetParent(goMap[8298837295344329456L].transform, false);
        goMap[-7890508024511743196L].transform.SetParent(goMap[1982603842814787085L].transform, false);
        goMap[7887652042451992401L].transform.SetParent(goMap[-7890508024511743196L].transform, false);
        goMap[-1591075058762437341L].transform.SetParent(goMap[1982603842814787085L].transform, false);
        goMap[-1184573606940376265L].transform.SetParent(goMap[1982603842814787085L].transform, false);
        goMap[-6428946152323728548L].transform.SetParent(goMap[1982603842814787085L].transform, false);
        goMap[-5711732007658525353L].transform.SetParent(goMap[1982603842814787085L].transform, false);
        goMap[-293907160034285384L].transform.SetParent(goMap[-5711732007658525353L].transform, false);
        goMap[7991345737667163285L].transform.SetParent(goMap[1982603842814787085L].transform, false);
        goMap[8361467419616652643L].transform.SetParent(goMap[7991345737667163285L].transform, false);
        goMap[3511242877104800945L].transform.SetParent(goMap[1982603842814787085L].transform, false);
        goMap[6615463466769062428L].transform.SetParent(goMap[3511242877104800945L].transform, false);
        goMap[2398113249511592448L].transform.SetParent(goMap[1982603842814787085L].transform, false);
        goMap[6327760054969521137L].transform.SetParent(goMap[1982603842814787085L].transform, false);
        goMap[-2569621866669391282L].transform.SetParent(goMap[1982603842814787085L].transform, false);
        goMap[5303127807043023L].transform.SetParent(goMap[1982603842814787085L].transform, false);
        goMap[-1043810183160555437L].transform.SetParent(goMap[1982603842814787085L].transform, false);
        goMap[1901938497584640671L].transform.SetParent(goMap[1982603842814787085L].transform, false);
        goMap[-6733511279965042318L].transform.SetParent(goMap[1982603842814787085L].transform, false);
        goMap[8564290531328720642L].transform.SetParent(goMap[1982603842814787085L].transform, false);
        goMap[7741180381710505499L].transform.SetParent(goMap[1982603842814787085L].transform, false);
        goMap[-2952062928896845932L].transform.SetParent(goMap[1982603842814787085L].transform, false);
        goMap[6279653949285857500L].transform.SetParent(goMap[1982603842814787085L].transform, false);
        goMap[8410273798647024909L].transform.SetParent(goMap[1982603842814787085L].transform, false);
        goMap[-3219709866010276470L].transform.SetParent(goMap[1982603842814787085L].transform, false);
        goMap[3157053181698028121L].transform.SetParent(goMap[1982603842814787085L].transform, false);
        goMap[8273258284709245734L].transform.SetParent(goMap[3157053181698028121L].transform, false);
        goMap[4787447207069417974L].transform.SetParent(goMap[3157053181698028121L].transform, false);
        goMap[8884574594086861162L].transform.SetParent(goMap[3157053181698028121L].transform, false);
        goMap[1404864418907660212L].transform.SetParent(goMap[3157053181698028121L].transform, false);
        goMap[-6636399163737974014L].transform.SetParent(goMap[3157053181698028121L].transform, false);
        goMap[-1217823057774440474L].transform.SetParent(goMap[1982603842814787085L].transform, false);
        goMap[-8110082751761284409L].transform.SetParent(goMap[1982603842814787085L].transform, false);
        goMap[2400593736662930177L].transform.SetParent(goMap[-8110082751761284409L].transform, false);
        goMap[7226181275852399629L].transform.SetParent(goMap[-8110082751761284409L].transform, false);
        goMap[9191190653154371236L].transform.SetParent(goMap[-8110082751761284409L].transform, false);
        goMap[-4041538412887928506L].transform.SetParent(goMap[9191190653154371236L].transform, false);
        goMap[-2218499223665582272L].transform.SetParent(goMap[-8110082751761284409L].transform, false);
        goMap[5750446410562144682L].transform.SetParent(goMap[-8110082751761284409L].transform, false);
        goMap[1897835921189949724L].transform.SetParent(goMap[5750446410562144682L].transform, false);
        goMap[-6835598671864719944L].transform.SetParent(goMap[-8110082751761284409L].transform, false);
        goMap[-6595088515822573330L].transform.SetParent(goMap[-6835598671864719944L].transform, false);
        goMap[8518839110843131814L].transform.SetParent(goMap[-8110082751761284409L].transform, false);
        goMap[6934137438260105287L].transform.SetParent(goMap[1982603842814787085L].transform, false);
        goMap[4214660436316737365L].transform.SetParent(goMap[6934137438260105287L].transform, false);
        goMap[-4733521636791453260L].transform.SetParent(goMap[6934137438260105287L].transform, false);
        goMap[-8143682158849816832L].transform.SetParent(goMap[1982603842814787085L].transform, false);
        goMap[-686363828142586293L].transform.SetParent(goMap[-8143682158849816832L].transform, false);
        goMap[8115079907332279429L].transform.SetParent(goMap[-8143682158849816832L].transform, false);
        goMap[2472659582224810934L].transform.SetParent(goMap[-8143682158849816832L].transform, false);
        goMap[-7466510617700566567L].transform.SetParent(goMap[1982603842814787085L].transform, false);
        goMap[472537345441188551L].transform.SetParent(goMap[-7466510617700566567L].transform, false);
        goMap[-5469666316680963947L].transform.SetParent(goMap[472537345441188551L].transform, false);
        goMap[-4429525410057714824L].transform.SetParent(goMap[-5469666316680963947L].transform, false);
        goMap[1550006121014779165L].transform.SetParent(goMap[-4429525410057714824L].transform, false);
        goMap[-9141241293201637460L].transform.SetParent(goMap[-4429525410057714824L].transform, false);
        goMap[5382801336684128246L].transform.SetParent(goMap[-4429525410057714824L].transform, false);
        goMap[4328028358397430183L].transform.SetParent(goMap[-4429525410057714824L].transform, false);
        goMap[-488559854030737127L].transform.SetParent(goMap[-5469666316680963947L].transform, false);
        goMap[5217727488177608270L].transform.SetParent(goMap[-5469666316680963947L].transform, false);
        goMap[6846485623929866283L].transform.SetParent(goMap[472537345441188551L].transform, false);
        goMap[-6189248757309018026L].transform.SetParent(goMap[6846485623929866283L].transform, false);
        goMap[-164838050581879932L].transform.SetParent(goMap[-6189248757309018026L].transform, false);
        goMap[6285640685354125342L].transform.SetParent(goMap[-6189248757309018026L].transform, false);
        goMap[5343506600475808933L].transform.SetParent(goMap[-6189248757309018026L].transform, false);
        goMap[2620061469977811763L].transform.SetParent(goMap[-6189248757309018026L].transform, false);
        goMap[-302869262422098606L].transform.SetParent(goMap[6846485623929866283L].transform, false);
        goMap[-6269287152878739103L].transform.SetParent(goMap[6846485623929866283L].transform, false);
        goMap[-1476184024059854677L].transform.SetParent(goMap[472537345441188551L].transform, false);
        goMap[8992892915332468396L].transform.SetParent(goMap[-1476184024059854677L].transform, false);
        goMap[7008253948009600786L].transform.SetParent(goMap[8992892915332468396L].transform, false);
        goMap[-7608174147774759283L].transform.SetParent(goMap[8992892915332468396L].transform, false);
        goMap[6825658664992138085L].transform.SetParent(goMap[8992892915332468396L].transform, false);
        goMap[8918917474154835641L].transform.SetParent(goMap[8992892915332468396L].transform, false);
        goMap[8970842521214332304L].transform.SetParent(goMap[-1476184024059854677L].transform, false);
        goMap[8504979032295906937L].transform.SetParent(goMap[-1476184024059854677L].transform, false);
        goMap[7592298268414787731L].transform.SetParent(goMap[472537345441188551L].transform, false);
        goMap[-6246916133645389376L].transform.SetParent(goMap[7592298268414787731L].transform, false);
        goMap[-5077782991732375118L].transform.SetParent(goMap[-6246916133645389376L].transform, false);
        goMap[-7847146972306225455L].transform.SetParent(goMap[-6246916133645389376L].transform, false);
        goMap[6799422191118892541L].transform.SetParent(goMap[-6246916133645389376L].transform, false);
        goMap[8524469053154139689L].transform.SetParent(goMap[-6246916133645389376L].transform, false);
        goMap[-6848584943358801093L].transform.SetParent(goMap[7592298268414787731L].transform, false);
        goMap[-6500092477773620442L].transform.SetParent(goMap[7592298268414787731L].transform, false);
        goMap[3575363841926022619L].transform.SetParent(goMap[472537345441188551L].transform, false);
        goMap[-7014492547962059803L].transform.SetParent(goMap[3575363841926022619L].transform, false);
        goMap[-7043875470267885326L].transform.SetParent(goMap[-7014492547962059803L].transform, false);
        goMap[-8086148329928305891L].transform.SetParent(goMap[-7014492547962059803L].transform, false);
        goMap[-1020969830788694311L].transform.SetParent(goMap[-7014492547962059803L].transform, false);
        goMap[-1868716943941590707L].transform.SetParent(goMap[-7014492547962059803L].transform, false);
        goMap[4083078308365539604L].transform.SetParent(goMap[3575363841926022619L].transform, false);
        goMap[-129118376413079066L].transform.SetParent(goMap[3575363841926022619L].transform, false);
        goMap[6465992102140605518L].transform.SetParent(goMap[472537345441188551L].transform, false);
        goMap[8434818770287625550L].transform.SetParent(goMap[472537345441188551L].transform, false);
        goMap[1537426635999012079L].transform.SetParent(goMap[472537345441188551L].transform, false);
        goMap[-1075602777025141499L].transform.SetParent(goMap[472537345441188551L].transform, false);
        goMap[6752527139853472558L].transform.SetParent(goMap[472537345441188551L].transform, false);
        goMap[1035266336662304956L].transform.SetParent(goMap[-7466510617700566567L].transform, false);
        goMap[-7723362146751102988L].transform.SetParent(goMap[-7466510617700566567L].transform, false);
        goMap[-9016405377741203834L].transform.SetParent(goMap[-7466510617700566567L].transform, false);
        goMap[-1335227214337310650L].transform.SetParent(goMap[-9016405377741203834L].transform, false);
        goMap[2062140978601065241L].transform.SetParent(goMap[-9016405377741203834L].transform, false);
        goMap[2870233093808539183L].transform.SetParent(goMap[-9016405377741203834L].transform, false);
        goMap[786264882936288372L].transform.SetParent(goMap[-9016405377741203834L].transform, false);
        goMap[-8558215722793373928L].transform.SetParent(goMap[-9016405377741203834L].transform, false);
        goMap[8726575937728168960L].transform.SetParent(goMap[-9016405377741203834L].transform, false);
        goMap[-5520562687165408102L].transform.SetParent(goMap[-9016405377741203834L].transform, false);
        goMap[-7619656313873159478L].transform.SetParent(goMap[-9016405377741203834L].transform, false);
        goMap[-4832961104113422847L].transform.SetParent(goMap[-9016405377741203834L].transform, false);
        goMap[-7347409604111662783L].transform.SetParent(goMap[-9016405377741203834L].transform, false);
        goMap[3450924580830249706L].transform.SetParent(goMap[-7466510617700566567L].transform, false);
        goMap[4235556532880477220L].transform.SetParent(goMap[-7466510617700566567L].transform, false);
        goMap[-2839755288168311429L].transform.SetParent(goMap[-727019389098517411L].transform, false);
        goMap[-2516122796516724038L].transform.SetParent(goMap[-2839755288168311429L].transform, false);
        goMap[-2473557872573465369L].transform.SetParent(goMap[-727019389098517411L].transform, false);
        goMap[-245956512253236384L].transform.SetParent(goMap[-727019389098517411L].transform, false);
        goMap[5032415346774507646L].transform.SetParent(goMap[-245956512253236384L].transform, false);
        goMap[4843594694523125305L].transform.SetParent(goMap[5032415346774507646L].transform, false);
        goMap[-6600965532740033953L].transform.SetParent(goMap[5032415346774507646L].transform, false);
        goMap[-5618731616431581897L].transform.SetParent(goMap[5032415346774507646L].transform, false);
        goMap[682438437019941539L].transform.SetParent(goMap[5032415346774507646L].transform, false);
        goMap[6504730874239599200L].transform.SetParent(goMap[682438437019941539L].transform, false);
        goMap[-9217820294083067492L].transform.SetParent(goMap[5032415346774507646L].transform, false);
        goMap[406679844311860663L].transform.SetParent(goMap[-9217820294083067492L].transform, false);
        goMap[9207926932567190988L].transform.SetParent(goMap[5032415346774507646L].transform, false);
        goMap[8701593904009747291L].transform.SetParent(goMap[5032415346774507646L].transform, false);
        goMap[-5244937048036067546L].transform.SetParent(goMap[8701593904009747291L].transform, false);
        goMap[4967085122485019591L].transform.SetParent(goMap[-5244937048036067546L].transform, false);
        goMap[7152697645036802261L].transform.SetParent(goMap[5032415346774507646L].transform, false);
        goMap[-9057733414298528348L].transform.SetParent(goMap[7152697645036802261L].transform, false);
        goMap[-7791846722860623392L].transform.SetParent(goMap[5032415346774507646L].transform, false);
        goMap[-1553339685355409413L].transform.SetParent(goMap[-7791846722860623392L].transform, false);
        goMap[7895314578790749011L].transform.SetParent(goMap[5032415346774507646L].transform, false);
        goMap[8637730948199539788L].transform.SetParent(goMap[7895314578790749011L].transform, false);
        goMap[1146982383690712088L].transform.SetParent(goMap[-245956512253236384L].transform, false);
        goMap[-4562595303296709612L].transform.SetParent(goMap[1146982383690712088L].transform, false);
        goMap[5965815757721803110L].transform.SetParent(goMap[1146982383690712088L].transform, false);
        goMap[-1617217154484790522L].transform.SetParent(goMap[1146982383690712088L].transform, false);
        goMap[9106837831493246356L].transform.SetParent(goMap[1146982383690712088L].transform, false);
        goMap[-2767264387412471131L].transform.SetParent(goMap[9106837831493246356L].transform, false);
        goMap[7017668181765069936L].transform.SetParent(goMap[1146982383690712088L].transform, false);
        goMap[-1744136361377404306L].transform.SetParent(goMap[7017668181765069936L].transform, false);
        goMap[8231272342598237991L].transform.SetParent(goMap[1146982383690712088L].transform, false);
        goMap[-5812334629962007393L].transform.SetParent(goMap[8231272342598237991L].transform, false);
        goMap[-119621910670385602L].transform.SetParent(goMap[-5812334629962007393L].transform, false);
        goMap[-6655983027467726292L].transform.SetParent(goMap[8231272342598237991L].transform, false);
        goMap[7051625277701727968L].transform.SetParent(goMap[-6655983027467726292L].transform, false);
        goMap[-2328435651856328067L].transform.SetParent(goMap[1146982383690712088L].transform, false);
        goMap[-744882191105418117L].transform.SetParent(goMap[-2328435651856328067L].transform, false);
        goMap[1348093236012001220L].transform.SetParent(goMap[1146982383690712088L].transform, false);
        goMap[3316004050531752473L].transform.SetParent(goMap[1348093236012001220L].transform, false);
        goMap[9199019186969940133L].transform.SetParent(goMap[1146982383690712088L].transform, false);
        goMap[-7983737703374674949L].transform.SetParent(goMap[9199019186969940133L].transform, false);
        goMap[-7759841132039646220L].transform.SetParent(goMap[1146982383690712088L].transform, false);
        goMap[-765433985854971512L].transform.SetParent(goMap[1146982383690712088L].transform, false);
        goMap[-392127840509104546L].transform.SetParent(goMap[-245956512253236384L].transform, false);
        goMap[3603475799401199237L].transform.SetParent(goMap[-392127840509104546L].transform, false);
        goMap[3558254300272522728L].transform.SetParent(goMap[3603475799401199237L].transform, false);
        goMap[-1381450238515527290L].transform.SetParent(goMap[3603475799401199237L].transform, false);
        goMap[-6225199957836733390L].transform.SetParent(goMap[-392127840509104546L].transform, false);
        goMap[-580275674457841963L].transform.SetParent(goMap[-6225199957836733390L].transform, false);
        goMap[-955243112007814197L].transform.SetParent(goMap[-6225199957836733390L].transform, false);
        goMap[1215796524404458935L].transform.SetParent(goMap[3432722095087552304L].transform, false);
        goMap[-1612561385618020114L].transform.SetParent(goMap[1215796524404458935L].transform, false);
        goMap[8186067839504991436L].transform.SetParent(goMap[-1612561385618020114L].transform, false);
        goMap[-7667441771603489850L].transform.SetParent(goMap[8186067839504991436L].transform, false);
        goMap[-1691431904063077257L].transform.SetParent(goMap[8186067839504991436L].transform, false);
        goMap[4678354735297362310L].transform.SetParent(goMap[8186067839504991436L].transform, false);
        goMap[4107407001160041755L].transform.SetParent(goMap[8186067839504991436L].transform, false);
        goMap[-6653825462572527407L].transform.SetParent(goMap[4107407001160041755L].transform, false);
        goMap[1936851170976014562L].transform.SetParent(goMap[-1612561385618020114L].transform, false);
        goMap[-6284617653211960201L].transform.SetParent(goMap[1936851170976014562L].transform, false);
        goMap[-6069441402752727261L].transform.SetParent(goMap[1936851170976014562L].transform, false);
        goMap[-7486834131713475463L].transform.SetParent(goMap[1936851170976014562L].transform, false);
        goMap[-9151381461575678063L].transform.SetParent(goMap[1936851170976014562L].transform, false);
        goMap[6636252723562815900L].transform.SetParent(goMap[-9151381461575678063L].transform, false);
        goMap[7903546794408889579L].transform.SetParent(goMap[-1612561385618020114L].transform, false);
        goMap[4374079833165044205L].transform.SetParent(goMap[7903546794408889579L].transform, false);
        goMap[7336140254322941212L].transform.SetParent(goMap[7903546794408889579L].transform, false);
        goMap[-3270507227197917854L].transform.SetParent(goMap[7903546794408889579L].transform, false);
        goMap[-7507518031372023205L].transform.SetParent(goMap[7903546794408889579L].transform, false);
        goMap[8577955914320050187L].transform.SetParent(goMap[-7507518031372023205L].transform, false);
        goMap[1809633201303292420L].transform.SetParent(goMap[-1612561385618020114L].transform, false);
        goMap[8483222073349620622L].transform.SetParent(goMap[1809633201303292420L].transform, false);
        goMap[8628338640451584517L].transform.SetParent(goMap[1809633201303292420L].transform, false);
        goMap[-5077010686124561213L].transform.SetParent(goMap[1809633201303292420L].transform, false);
        goMap[3821490267352828035L].transform.SetParent(goMap[1809633201303292420L].transform, false);
        goMap[-3894695405590301992L].transform.SetParent(goMap[3821490267352828035L].transform, false);

        // ─── RectTransforms ──────────────────────────────────
        {
            var rt = goMap[8488265890266967383L].AddComponent<RectTransform>();
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
            var rt = goMap[3432722095087552304L].AddComponent<RectTransform>();
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
            var rt = goMap[-8402512713859439503L].AddComponent<RectTransform>();
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
            var rt = goMap[-727019389098517411L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(7.999900f, -8.887500f);
            rt.sizeDelta = new Vector2(1280.000000f, 720.000000f);
        }
        {
            var rt = goMap[1982603842814787085L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000025f);
            rt.sizeDelta = new Vector2(1280.000000f, 720.000000f);
        }
        {
            var rt = goMap[-3594115841788442285L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.990072f, 1.487905f, 1.487905f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(4.000000f, -7.000000f);
            rt.sizeDelta = new Vector2(790.000000f, 601.000000f);
        }
        {
            var rt = goMap[-5942139603788536574L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.287631f, 1.287663f, 1.000225f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(800.000000f, 600.000000f);
        }
        {
            var rt = goMap[6815922576319909644L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-274.000000f, -7.000000f);
            rt.sizeDelta = new Vector2(790.000000f, 601.000000f);
        }
        {
            var rt = goMap[3687912689639509416L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(187.000000f, -7.000000f);
            rt.sizeDelta = new Vector2(790.000000f, 601.000000f);
        }
        {
            var rt = goMap[565368244621494339L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-6.800000f, -30.200001f);
            rt.sizeDelta = new Vector2(638.000000f, 638.000000f);
        }
        {
            var rt = goMap[8298837295344329456L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.920450f, 0.920450f, 0.920450f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-256.000000f, 46.000000f);
            rt.sizeDelta = new Vector2(300.000000f, 300.000000f);
        }
        {
            var rt = goMap[-841196698099187192L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.000031f, 0.000000f);
            rt.sizeDelta = new Vector2(300.000000f, 300.000000f);
        }
        {
            var rt = goMap[-7890508024511743196L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.876250f, 0.876250f, 0.876250f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-213.000000f, -110.000000f);
            rt.sizeDelta = new Vector2(377.000000f, 188.000000f);
        }
        {
            var rt = goMap[7887652042451992401L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.000031f, 0.000000f);
            rt.sizeDelta = new Vector2(377.000000f, 188.000000f);
        }
        {
            var rt = goMap[-1591075058762437341L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.779020f, 0.779020f, 0.779020f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(227.100006f, 8.000000f);
            rt.sizeDelta = new Vector2(162.000000f, 198.000000f);
        }
        {
            var rt = goMap[-1184573606940376265L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.823230f, 0.823230f, 0.823230f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(213.000000f, -61.299999f);
            rt.sizeDelta = new Vector2(335.000000f, 177.000000f);
        }
        {
            var rt = goMap[-6428946152323728548L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-6.200000f, -179.000000f);
            rt.sizeDelta = new Vector2(500.000000f, 188.000000f);
        }
        {
            var rt = goMap[-5711732007658525353L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-6.200000f, 82.800003f);
            rt.sizeDelta = new Vector2(448.000000f, 448.000000f);
        }
        {
            var rt = goMap[-293907160034285384L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(512.000000f, 512.000000f);
        }
        {
            var rt = goMap[7991345737667163285L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-6.900000f, 79.300003f);
            rt.sizeDelta = new Vector2(488.000000f, 458.000000f);
        }
        {
            var rt = goMap[8361467419616652643L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000024f, 0.000015f);
            rt.sizeDelta = new Vector2(488.000000f, 458.000000f);
        }
        {
            var rt = goMap[3511242877104800945L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-6.900000f, 80.199997f);
            rt.sizeDelta = new Vector2(438.000000f, 382.000000f);
        }
        {
            var rt = goMap[6615463466769062428L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000024f, 0.000015f);
            rt.sizeDelta = new Vector2(438.000000f, 382.000000f);
        }
        {
            var rt = goMap[2398113249511592448L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-6.900000f, 80.900002f);
            rt.sizeDelta = new Vector2(338.000000f, 338.000000f);
        }
        {
            var rt = goMap[6327760054969521137L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-6.900000f, 80.900002f);
            rt.sizeDelta = new Vector2(294.000000f, 294.000000f);
        }
        {
            var rt = goMap[-2569621866669391282L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-6.900000f, 37.000000f);
            rt.sizeDelta = new Vector2(252.000000f, 252.000000f);
        }
        {
            var rt = goMap[5303127807043023L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-6.900000f, 46.500000f);
            rt.sizeDelta = new Vector2(210.000000f, 210.000000f);
        }
        {
            var rt = goMap[-1043810183160555437L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-6.900000f, 37.000000f);
            rt.sizeDelta = new Vector2(194.000000f, 194.000000f);
        }
        {
            var rt = goMap[1901938497584640671L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(75.900002f, -29.799999f);
            rt.sizeDelta = new Vector2(36.000000f, 36.000000f);
        }
        {
            var rt = goMap[-6733511279965042318L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(110.099998f, -14.900000f);
            rt.sizeDelta = new Vector2(58.000000f, 58.000000f);
        }
        {
            var rt = goMap[8564290531328720642L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-110.000000f, 40.099998f);
            rt.sizeDelta = new Vector2(36.000000f, 36.000000f);
        }
        {
            var rt = goMap[7741180381710505499L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-129.000000f, 9.400000f);
            rt.sizeDelta = new Vector2(58.000000f, 58.000000f);
        }
        {
            var rt = goMap[-2952062928896845932L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-19.299999f, 37.000000f);
            rt.sizeDelta = new Vector2(168.000000f, 144.000000f);
        }
        {
            var rt = goMap[6279653949285857500L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-5.900000f, 37.000000f);
            rt.sizeDelta = new Vector2(132.000000f, 130.000000f);
        }
        {
            var rt = goMap[8410273798647024909L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-6.900000f, 37.000000f);
            rt.sizeDelta = new Vector2(360.000000f, 360.000000f);
        }
        {
            var rt = goMap[-3219709866010276470L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.938130f, 0.938130f, 0.938130f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-5.000000f, 38.900002f);
            rt.sizeDelta = new Vector2(512.000000f, 512.000000f);
        }
        {
            var rt = goMap[3157053181698028121L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-7.200000f, 37.799999f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[8273258284709245734L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.300012f, 96.200012f);
            rt.sizeDelta = new Vector2(66.000000f, 66.000000f);
        }
        {
            var rt = goMap[4787447207069417974L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-89.699989f, 28.300011f);
            rt.sizeDelta = new Vector2(66.000000f, 66.000000f);
        }
        {
            var rt = goMap[8884574594086861162L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(94.500015f, 28.300011f);
            rt.sizeDelta = new Vector2(66.000000f, 66.000000f);
        }
        {
            var rt = goMap[1404864418907660212L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-53.899986f, -79.199989f);
            rt.sizeDelta = new Vector2(66.000000f, 66.000000f);
        }
        {
            var rt = goMap[-6636399163737974014L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(58.500011f, -79.199989f);
            rt.sizeDelta = new Vector2(66.000000f, 66.000000f);
        }
        {
            var rt = goMap[-1217823057774440474L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-454.799988f, 167.000000f);
            rt.sizeDelta = new Vector2(258.000000f, 84.000000f);
        }
        {
            var rt = goMap[-8110082751761284409L].AddComponent<RectTransform>();
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
            var rt = goMap[2400593736662930177L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(51.599998f, 290.399994f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[7226181275852399629L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.077154f,0.997019f);
            rt.localScale = new Vector3(0.404087f, 0.404087f, 0.404087f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(14.200000f, 309.299988f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[9191190653154371236L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,0.162397f,0.986726f);
            rt.localScale = new Vector3(0.746171f, 0.746171f, 0.746171f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-40.900002f, 307.799988f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-4041538412887928506L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 1.599997f);
            rt.localRotation = new Quaternion(0.123065f,0.700897f,-0.121133f,0.692044f);
            rt.localScale = new Vector3(1.340176f, 1.340176f, 1.340176f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-6.700000f, 3.500000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-2218499223665582272L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.191438f,0.981505f);
            rt.localScale = new Vector3(0.379093f, 0.379093f, 0.379093f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(177.699997f, 251.100006f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[5750446410562144682L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.469844f,0.882749f);
            rt.localScale = new Vector3(0.791081f, 0.791081f, 0.791081f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(185.399994f, 210.899994f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[1897835921189949724L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, -4.000000f);
            rt.localRotation = new Quaternion(0.084556f,0.701862f,-0.093582f,0.701058f);
            rt.localScale = new Vector3(1.264092f, 1.264092f, 1.264092f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(20.900000f, -7.700000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-6835598671864719944L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,0.703304f,0.710889f);
            rt.localScale = new Vector3(0.413498f, 0.413498f, 0.413498f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-250.899994f, 92.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-6595088515822573330L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 9.000000f);
            rt.localRotation = new Quaternion(-0.000354f,0.706811f,0.009400f,0.707340f);
            rt.localScale = new Vector3(2.418389f, 2.418389f, 2.418389f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-25.000000f, -11.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[8518839110843131814L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,0.729952f,0.683499f);
            rt.localScale = new Vector3(0.957687f, 0.957687f, 0.957687f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-248.199997f, 20.200001f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[6934137438260105287L].AddComponent<RectTransform>();
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
            var rt = goMap[4214660436316737365L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-439.000000f, 4.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-4733521636791453260L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(417.000000f, 4.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-8143682158849816832L].AddComponent<RectTransform>();
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
            var rt = goMap[-686363828142586293L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,1.000000f,0.000000f,0.000000f);
            rt.localScale = new Vector3(156.250229f, 156.250229f, 156.250229f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[8115079907332279429L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,1.000000f,0.000000f,0.000000f);
            rt.localScale = new Vector3(20.651573f, 20.651573f, 20.651573f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-11.000000f, 38.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[2472659582224810934L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,1.000000f,0.000000f,0.000000f);
            rt.localScale = new Vector3(20.651573f, 20.651573f, 20.651573f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-11.000000f, 38.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-2839755288168311429L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-500.799988f, 185.600037f);
            rt.sizeDelta = new Vector2(0.000000f, 60.000000f);
        }
        {
            var rt = goMap[-2516122796516724038L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(0.800000f, 0.800000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.500000f);
            rt.anchorMax = new Vector2(1.000000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(23.699997f, -3.400000f);
            rt.sizeDelta = new Vector2(52.000000f, 52.000000f);
        }
        {
            var rt = goMap[-2473557872573465369L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(370.000000f, 187.000000f);
            rt.sizeDelta = new Vector2(52.000000f, 52.000000f);
        }
        {
            var rt = goMap[-245956512253236384L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.000031f, -0.001251f);
            rt.sizeDelta = new Vector2(1154.000000f, 661.770020f);
        }
        {
            var rt = goMap[5032415346774507646L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(20.000000f, -25.000000f);
            rt.sizeDelta = new Vector2(500.000000f, 560.000000f);
        }
        {
            var rt = goMap[4843594694523125305L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 8.375000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-15.000000f, 235.306519f);
            rt.sizeDelta = new Vector2(200.000000f, 50.000000f);
        }
        {
            var rt = goMap[-6600965532740033953L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-130.800049f, -174.699997f);
            rt.sizeDelta = new Vector2(180.000000f, 30.000000f);
        }
        {
            var rt = goMap[-5618731616431581897L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(87.599998f, -174.699997f);
            rt.sizeDelta = new Vector2(180.000000f, 30.000000f);
        }
        {
            var rt = goMap[682438437019941539L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(49.725327f, -173.899994f);
            rt.sizeDelta = new Vector2(32.000000f, 32.000000f);
        }
        {
            var rt = goMap[6504730874239599200L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 8.375000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(122.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(200.000000f, 50.000000f);
        }
        {
            var rt = goMap[-9217820294083067492L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-168.974670f, -173.899994f);
            rt.sizeDelta = new Vector2(32.000000f, 32.000000f);
        }
        {
            var rt = goMap[406679844311860663L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 8.375000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(122.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(200.000000f, 50.000000f);
        }
        {
            var rt = goMap[9207926932567190988L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 8.375000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-131.374695f, -259.600006f);
            rt.sizeDelta = new Vector2(200.000000f, 30.000000f);
        }
        {
            var rt = goMap[8701593904009747291L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-482.700012f, 133.399994f);
            rt.sizeDelta = new Vector2(321.970001f, 0.000000f);
        }
        {
            var rt = goMap[-5244937048036067546L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,1.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }
        {
            var rt = goMap[4967085122485019591L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-1.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }
        {
            var rt = goMap[7152697645036802261L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 8.375000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(88.725327f, -220.000000f);
            rt.sizeDelta = new Vector2(148.000000f, 50.000000f);
        }
        {
            var rt = goMap[-9057733414298528348L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.349998f, 3.000000f);
            rt.sizeDelta = new Vector2(135.892456f, 40.000000f);
        }
        {
            var rt = goMap[-7791846722860623392L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 8.375000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-129.874695f, -220.000000f);
            rt.sizeDelta = new Vector2(148.000000f, 50.000000f);
        }
        {
            var rt = goMap[-1553339685355409413L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 3.000000f);
            rt.sizeDelta = new Vector2(148.000000f, 40.000000f);
        }
        {
            var rt = goMap[7895314578790749011L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 8.375000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-130.174744f, -220.000000f);
            rt.sizeDelta = new Vector2(148.000000f, 50.000000f);
        }
        {
            var rt = goMap[8637730948199539788L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.349998f, 3.000000f);
            rt.sizeDelta = new Vector2(135.892395f, 40.000000f);
        }
        {
            var rt = goMap[1146982383690712088L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-7.000000f, -26.000000f);
            rt.sizeDelta = new Vector2(500.000000f, 560.000000f);
        }
        {
            var rt = goMap[-4562595303296709612L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 8.375000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(4.000000f, 238.000000f);
            rt.sizeDelta = new Vector2(200.000000f, 50.000000f);
        }
        {
            var rt = goMap[5965815757721803110L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-102.900009f, -174.699997f);
            rt.sizeDelta = new Vector2(180.000000f, 30.000000f);
        }
        {
            var rt = goMap[-1617217154484790522L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(115.500000f, -174.699997f);
            rt.sizeDelta = new Vector2(180.000000f, 30.000000f);
        }
        {
            var rt = goMap[9106837831493246356L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(72.000000f, -173.300003f);
            rt.sizeDelta = new Vector2(32.000000f, 32.000000f);
        }
        {
            var rt = goMap[-2767264387412471131L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 8.375000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(121.800003f, -0.200000f);
            rt.sizeDelta = new Vector2(200.000000f, 50.000000f);
        }
        {
            var rt = goMap[7017668181765069936L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-149.800003f, -173.300003f);
            rt.sizeDelta = new Vector2(32.000000f, 32.000000f);
        }
        {
            var rt = goMap[-1744136361377404306L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 8.375000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(122.000000f, -0.200000f);
            rt.sizeDelta = new Vector2(200.000000f, 50.000000f);
        }
        {
            var rt = goMap[8231272342598237991L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-455.700012f, 118.900002f);
            rt.sizeDelta = new Vector2(321.970001f, 58.000000f);
        }
        {
            var rt = goMap[-5812334629962007393L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,1.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(160.985001f, -13.000000f);
            rt.sizeDelta = new Vector2(321.970001f, 26.000000f);
        }
        {
            var rt = goMap[-119621910670385602L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-1.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(70.000000f, -13.000000f);
            rt.sizeDelta = new Vector2(140.000000f, 26.000000f);
        }
        {
            var rt = goMap[-6655983027467726292L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,1.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(160.985001f, -45.000000f);
            rt.sizeDelta = new Vector2(321.970001f, 26.000000f);
        }
        {
            var rt = goMap[7051625277701727968L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-1.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(96.500000f, -13.000000f);
            rt.sizeDelta = new Vector2(193.000000f, 26.000000f);
        }
        {
            var rt = goMap[-2328435651856328067L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 8.375000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(114.599945f, -220.000000f);
            rt.sizeDelta = new Vector2(150.000000f, 52.000000f);
        }
        {
            var rt = goMap[-744882191105418117L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-1.199997f, 3.000000f);
            rt.sizeDelta = new Vector2(136.350098f, 40.000000f);
        }
        {
            var rt = goMap[1348093236012001220L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 8.375000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-103.100037f, -220.000000f);
            rt.sizeDelta = new Vector2(150.000000f, 52.000000f);
        }
        {
            var rt = goMap[3316004050531752473L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 3.000000f);
            rt.sizeDelta = new Vector2(150.000000f, 40.000000f);
        }
        {
            var rt = goMap[9199019186969940133L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 8.375000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-102.900009f, -220.000000f);
            rt.sizeDelta = new Vector2(150.000000f, 52.000000f);
        }
        {
            var rt = goMap[-7983737703374674949L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.290001f, 3.000000f);
            rt.sizeDelta = new Vector2(136.429688f, 40.000000f);
        }
        {
            var rt = goMap[-7759841132039646220L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 8.375000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-104.000000f, -259.600006f);
            rt.sizeDelta = new Vector2(200.000000f, 30.000000f);
        }
        {
            var rt = goMap[-765433985854971512L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(6.300000f, -299.000000f);
            rt.sizeDelta = new Vector2(700.000000f, 30.000000f);
        }
        {
            var rt = goMap[-392127840509104546L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-360.299988f, -114.000000f);
            rt.sizeDelta = new Vector2(331.336212f, 326.087006f);
        }
        {
            var rt = goMap[3603475799401199237L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(25.900000f, -17.100000f);
            rt.sizeDelta = new Vector2(222.000000f, 70.000000f);
        }
        {
            var rt = goMap[3558254300272522728L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(8.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(114.000000f, 60.000000f);
        }
        {
            var rt = goMap[-1381450238515527290L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-80.199997f, 0.000000f);
            rt.sizeDelta = new Vector2(60.000000f, 60.000000f);
        }
        {
            var rt = goMap[-6225199957836733390L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(2.100000f, 60.599998f);
            rt.sizeDelta = new Vector2(222.000000f, 70.000000f);
        }
        {
            var rt = goMap[-580275674457841963L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(8.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(114.000000f, 60.000000f);
        }
        {
            var rt = goMap[-955243112007814197L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-78.900002f, 0.000000f);
            rt.sizeDelta = new Vector2(60.000000f, 60.000000f);
        }
        {
            var rt = goMap[1215796524404458935L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, -7.731608f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 1.000000f);
            rt.anchorMax = new Vector2(0.500000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(128.000000f, -36.000000f);
            rt.sizeDelta = new Vector2(745.000000f, 60.000000f);
        }
        {
            var rt = goMap[-1612561385618020114L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-44.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(800.000000f, 40.000000f);
        }
        {
            var rt = goMap[8186067839504991436L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(715.000000f, -20.000000f);
            rt.sizeDelta = new Vector2(170.000000f, 40.000000f);
        }
        {
            var rt = goMap[-7667441771603489850L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(170.000000f, 30.000000f);
        }
        {
            var rt = goMap[-1691431904063077257L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 1.000000f);
            rt.sizeDelta = new Vector2(130.000000f, 40.000000f);
        }
        {
            var rt = goMap[4678354735297362310L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-70.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(28.000000f, 28.000000f);
        }
        {
            var rt = goMap[4107407001160041755L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(170.000000f, 40.000000f);
        }
        {
            var rt = goMap[-6653825462572527407L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(70.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 30.000000f);
        }
        {
            var rt = goMap[1936851170976014562L].AddComponent<RectTransform>();
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
            var rt = goMap[-6284617653211960201L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(170.000000f, 30.000000f);
        }
        {
            var rt = goMap[-6069441402752727261L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 1.000000f);
            rt.sizeDelta = new Vector2(110.000000f, 30.000000f);
        }
        {
            var rt = goMap[-7486834131713475463L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-70.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(28.000000f, 28.000000f);
        }
        {
            var rt = goMap[-9151381461575678063L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(170.000000f, 40.000000f);
        }
        {
            var rt = goMap[6636252723562815900L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(70.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 30.000000f);
        }
        {
            var rt = goMap[7903546794408889579L].AddComponent<RectTransform>();
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
            var rt = goMap[4374079833165044205L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(170.000000f, 30.000000f);
        }
        {
            var rt = goMap[7336140254322941212L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 1.000000f);
            rt.sizeDelta = new Vector2(110.000000f, 30.000000f);
        }
        {
            var rt = goMap[-3270507227197917854L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-70.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(28.000000f, 28.000000f);
        }
        {
            var rt = goMap[-7507518031372023205L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(170.000000f, 40.000000f);
        }
        {
            var rt = goMap[8577955914320050187L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(70.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 30.000000f);
        }
        {
            var rt = goMap[1809633201303292420L].AddComponent<RectTransform>();
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
            var rt = goMap[8483222073349620622L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(170.000000f, 30.000000f);
        }
        {
            var rt = goMap[8628338640451584517L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 1.000000f);
            rt.sizeDelta = new Vector2(110.000000f, 30.000000f);
        }
        {
            var rt = goMap[-5077010686124561213L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-70.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(26.000000f, 26.000000f);
        }
        {
            var rt = goMap[3821490267352828035L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(170.000000f, 40.000000f);
        }
        {
            var rt = goMap[-3894695405590301992L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(70.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 30.000000f);
        }

        // ─── Components ──────────────────────────────────────
        { var c = goMap[8488265890266967383L].AddComponent<Canvas>();
           c.renderMode = (RenderMode)1;
           c.overrideSorting = false;
           c.sortingOrder = 0;
           c.sortingLayerID = unchecked((int)194136777);
           c.planeDistance = 8.660000f;
           c.pixelPerfect = false;
           c.additionalShaderChannels = (AdditionalCanvasShaderChannels)0;
           c.enabled = true;
        }
        { var c = goMap[8488265890266967383L].AddComponent<CanvasScaler>();
           c.uiScaleMode = (CanvasScaler.ScaleMode)1;
           c.referenceResolution = new Vector2(1280.000000f, 720.000000f);
           c.screenMatchMode = (CanvasScaler.ScreenMatchMode)1;
           c.matchWidthOrHeight = 0.000000f;
           c.referencePixelsPerUnit = 100.000000f;
        }
        { var c = goMap[8488265890266967383L].AddComponent<GraphicRaycaster>();
           c.ignoreReversedGraphics = true;
        }
        { var c = goMap[8488265890266967383L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.000000f, 0.000000f, 0.862745f);
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
        { var c = goMap[8488265890266967383L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("UICardPicking"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[-8402512713859439503L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
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
        { var c = goMap[-3594115841788442285L].AddComponent<Image>();
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
        { var c = goMap[-5942139603788536574L].AddComponent<Image>();
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
        { var c = goMap[6815922576319909644L].AddComponent<Image>();
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
        { var c = goMap[3687912689639509416L].AddComponent<Image>();
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
        { var c = goMap[565368244621494339L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_partner_gear_bg");
        }
        { var c = goMap[8298837295344329456L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_partner_mountain");
        }
        { var c = goMap[-841196698099187192L].AddComponent<Image>();
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
        { var c = goMap[-7890508024511743196L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_partner_cloud");
        }
        { var c = goMap[7887652042451992401L].AddComponent<Image>();
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
        { var c = goMap[-1591075058762437341L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_partner_globe");
        }
        { var c = goMap[-1184573606940376265L].AddComponent<Image>();
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
           c.sprite = LookupSprite("imgHorse");
        }
        { var c = goMap[-6428946152323728548L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_partner_ring_bottom");
        }
        { var c = goMap[-5711732007658525353L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_partner_ring_outer");
        }
        { var c = goMap[-293907160034285384L].AddComponent<Image>();
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
        { var c = goMap[7991345737667163285L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_partner_starbg4");
        }
        { var c = goMap[8361467419616652643L].AddComponent<Image>();
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
        { var c = goMap[3511242877104800945L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_partner_starbg3");
        }
        { var c = goMap[6615463466769062428L].AddComponent<Image>();
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
        { var c = goMap[2398113249511592448L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_partner_starbg2");
        }
        { var c = goMap[6327760054969521137L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_partner_starbg1");
        }
        { var c = goMap[-2569621866669391282L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_partner_series_bg");
        }
        { var c = goMap[5303127807043023L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_partner_series_star");
        }
        { var c = goMap[-1043810183160555437L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_partner_ring_gear");
        }
        { var c = goMap[1901938497584640671L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_partner_gear2");
        }
        { var c = goMap[-6733511279965042318L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_partner_gear1");
        }
        { var c = goMap[8564290531328720642L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_partner_gear2");
        }
        { var c = goMap[7741180381710505499L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_partner_gear1");
        }
        { var c = goMap[-2952062928896845932L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_partner_ring_sun");
        }
        { var c = goMap[6279653949285857500L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_partner_ring_moon");
        }
        { var c = goMap[8410273798647024909L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_partner_ring_fire");
        }
        { var c = goMap[-3219709866010276470L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_partner_ring_series");
        }
        { var c = goMap[8273258284709245734L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_partner_series_fire");
        }
        { var c = goMap[4787447207069417974L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_partner_series_wood");
        }
        { var c = goMap[8884574594086861162L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_partner_series_earth");
        }
        { var c = goMap[1404864418907660212L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_partner_series_water");
        }
        { var c = goMap[-6636399163737974014L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_partner_series_metal");
        }
        { var c = goMap[-1217823057774440474L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_partner_title_bg");
        }
        { var c = goMap[-7466510617700566567L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("UICardPicking_Effect"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[472537345441188551L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("Mod_jujiwuci1001"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[-2839755288168311429L].AddComponent<Text>();
           c.text = "966";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 32;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleLeft;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 0;
           c.resizeTextMaxSize = 222;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-2839755288168311429L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)2;
           c.verticalFit = (ContentSizeFitter.FitMode)0;
        }
        { var c = goMap[-2516122796516724038L].AddComponent<Image>();
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
           c.sprite = LookupSprite("btn_info_01");
        }
        { var c = goMap[-2516122796516724038L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-2516122796516724038L].AddComponent<UIScalePulse>();
           c.upScale = 0.950000f; c.duration = 0.100000f; c.scaleUp = false;
           c.enabled = true;
        }
        { var c = goMap[-2473557872573465369L].AddComponent<Image>();
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
           c.sprite = LookupSprite("btn_close01");
        }
        { var c = goMap[-2473557872573465369L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-2473557872573465369L].AddComponent<UIScalePulse>();
           c.upScale = 0.950000f; c.duration = 0.100000f; c.scaleUp = false;
           c.enabled = true;
        }
        { var c = goMap[-2473557872573465369L].AddComponent<CanvasGroup>();
           c.alpha = 1.000000f;
           c.interactable = true;
           c.blocksRaycasts = true;
           c.ignoreParentGroups = false;
        }
        { var c = goMap[4843594694523125305L].AddComponent<Text>();
           c.text = "7738";
           c.color = new Color(0.156863f, 0.294118f, 0.270588f, 1.000000f);
           c.fontSize = 22;
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
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-6600965532740033953L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.000000f, 0.000000f, 0.588235f);
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
           c.sprite = LookupSprite("img_line2");
        }
        { var c = goMap[-5618731616431581897L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.000000f, 0.000000f, 0.588235f);
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
           c.sprite = LookupSprite("img_line2");
        }
        { var c = goMap[682438437019941539L].AddComponent<Image>();
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
           c.sprite = LookupSprite("icon_coin");
        }
        { var c = goMap[6504730874239599200L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
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
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-9217820294083067492L].AddComponent<Image>();
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
           c.sprite = LookupSprite("icon_coin");
        }
        { var c = goMap[406679844311860663L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
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
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[9207926932567190988L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(0.098039f, 0.984314f, 0.121569f, 1.000000f);
           c.fontSize = 20;
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
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[8701593904009747291L].AddComponent<VerticalLayoutGroup>();
           c.padding = new RectOffset(0,0,0,0);
           c.spacing = 6.000000f;
           c.childAlignment = (TextAnchor)2;
           c.childForceExpandWidth = false;
           c.childForceExpandHeight = false;
           c.childControlWidth = true;
           c.childControlHeight = true;
           c.reverseArrangement = false;
        }
        { var c = goMap[8701593904009747291L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)0;
           c.verticalFit = (ContentSizeFitter.FitMode)2;
        }
        { var c = goMap[-5244937048036067546L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
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
           c.sprite = LookupSprite("img_line1");
        }
        { var c = goMap[-5244937048036067546L].AddComponent<HorizontalLayoutGroup>();
           c.padding = new RectOffset(0,0,0,0);
           c.spacing = 0.000000f;
           c.childAlignment = (TextAnchor)0;
           c.childForceExpandWidth = false;
           c.childForceExpandHeight = false;
           c.childControlWidth = true;
           c.childControlHeight = true;
           c.reverseArrangement = false;
        }
        { var c = goMap[4967085122485019591L].AddComponent<Text>();
           c.text = "17750";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleRight;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 18;
           c.resizeTextMaxSize = 20;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[7152697645036802261L].AddComponent<Image>();
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
        { var c = goMap[7152697645036802261L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[7152697645036802261L].AddComponent<UIScalePulse>();
           c.upScale = 0.950000f; c.duration = 0.100000f; c.scaleUp = false;
           c.enabled = true;
        }
        { var c = goMap[-9057733414298528348L].AddComponent<Text>();
           c.text = "8459";
           c.color = new Color(0.113725f, 0.309804f, 0.321569f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Bold;
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
        { var c = goMap[-7791846722860623392L].AddComponent<Image>();
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
        { var c = goMap[-7791846722860623392L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-1553339685355409413L].AddComponent<Text>();
           c.text = "15693";
           c.color = new Color(0.113725f, 0.309804f, 0.321569f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Bold;
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
        { var c = goMap[7895314578790749011L].AddComponent<Image>();
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
        { var c = goMap[7895314578790749011L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[7895314578790749011L].AddComponent<UIScalePulse>();
           c.upScale = 0.950000f; c.duration = 0.100000f; c.scaleUp = false;
           c.enabled = true;
        }
        { var c = goMap[8637730948199539788L].AddComponent<Text>();
           c.text = "6865";
           c.color = new Color(0.113725f, 0.309804f, 0.321569f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Bold;
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
        { var c = goMap[-4562595303296709612L].AddComponent<Text>();
           c.text = "8137";
           c.color = new Color(0.156863f, 0.294118f, 0.270588f, 1.000000f);
           c.fontSize = 22;
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
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[5965815757721803110L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.000000f, 0.000000f, 0.588235f);
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
           c.sprite = LookupSprite("img_line2");
        }
        { var c = goMap[-1617217154484790522L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.000000f, 0.000000f, 0.588235f);
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
           c.sprite = LookupSprite("img_line2");
        }
        { var c = goMap[9106837831493246356L].AddComponent<Image>();
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
        { var c = goMap[-2767264387412471131L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
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
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[7017668181765069936L].AddComponent<Image>();
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
        { var c = goMap[-1744136361377404306L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
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
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[8231272342598237991L].AddComponent<VerticalLayoutGroup>();
           c.padding = new RectOffset(0,0,0,0);
           c.spacing = 6.000000f;
           c.childAlignment = (TextAnchor)2;
           c.childForceExpandWidth = false;
           c.childForceExpandHeight = false;
           c.childControlWidth = true;
           c.childControlHeight = true;
           c.reverseArrangement = false;
        }
        { var c = goMap[8231272342598237991L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)0;
           c.verticalFit = (ContentSizeFitter.FitMode)2;
        }
        { var c = goMap[-5812334629962007393L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
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
           c.sprite = LookupSprite("img_line1");
        }
        { var c = goMap[-5812334629962007393L].AddComponent<HorizontalLayoutGroup>();
           c.padding = new RectOffset(0,0,0,0);
           c.spacing = 0.000000f;
           c.childAlignment = (TextAnchor)0;
           c.childForceExpandWidth = false;
           c.childForceExpandHeight = false;
           c.childControlWidth = true;
           c.childControlHeight = true;
           c.reverseArrangement = false;
        }
        { var c = goMap[-119621910670385602L].AddComponent<Text>();
           c.text = "17753";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleRight;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 18;
           c.resizeTextMaxSize = 20;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-6655983027467726292L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
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
           c.sprite = LookupSprite("img_line1");
        }
        { var c = goMap[-6655983027467726292L].AddComponent<HorizontalLayoutGroup>();
           c.padding = new RectOffset(0,0,0,0);
           c.spacing = 0.000000f;
           c.childAlignment = (TextAnchor)0;
           c.childForceExpandWidth = false;
           c.childForceExpandHeight = false;
           c.childControlWidth = true;
           c.childControlHeight = true;
           c.reverseArrangement = false;
        }
        { var c = goMap[7051625277701727968L].AddComponent<Text>();
           c.text = "17752";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 18;
           c.resizeTextMaxSize = 20;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-2328435651856328067L].AddComponent<Image>();
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
           c.sprite = LookupSprite("btn_common3_1");
        }
        { var c = goMap[-2328435651856328067L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-2328435651856328067L].AddComponent<UIScalePulse>();
           c.upScale = 0.950000f; c.duration = 0.100000f; c.scaleUp = false;
           c.enabled = true;
        }
        { var c = goMap[-744882191105418117L].AddComponent<Text>();
           c.text = "8459";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
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
        { var c = goMap[1348093236012001220L].AddComponent<Image>();
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
           c.sprite = LookupSprite("btn_common3_1");
        }
        { var c = goMap[1348093236012001220L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[1348093236012001220L].AddComponent<UIScalePulse>();
           c.upScale = 0.950000f; c.duration = 0.100000f; c.scaleUp = false;
           c.enabled = true;
        }
        { var c = goMap[3316004050531752473L].AddComponent<Text>();
           c.text = "15693";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 12;
           c.resizeTextMaxSize = 20;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[9199019186969940133L].AddComponent<Image>();
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
           c.sprite = LookupSprite("btn_common3_1");
        }
        { var c = goMap[9199019186969940133L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[9199019186969940133L].AddComponent<UIScalePulse>();
           c.upScale = 0.950000f; c.duration = 0.100000f; c.scaleUp = false;
           c.enabled = true;
        }
        { var c = goMap[-7983737703374674949L].AddComponent<Text>();
           c.text = "6865";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
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
        { var c = goMap[-7759841132039646220L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(0.098039f, 0.984314f, 0.121569f, 1.000000f);
           c.fontSize = 20;
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
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-765433985854971512L].AddComponent<Text>();
           c.text = "17892";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
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
        { var c = goMap[3603475799401199237L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_cardpicking_tap2");
        }
        { var c = goMap[3603475799401199237L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[3558254300272522728L].AddComponent<Text>();
           c.text = "7738";
           c.color = new Color(0.584314f, 0.584314f, 0.568627f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
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
        { var c = goMap[-1381450238515527290L].AddComponent<Image>();
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
           c.sprite = LookupSprite("icon_coin");
        }
        { var c = goMap[-6225199957836733390L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_cardpicking_tap2");
        }
        { var c = goMap[-6225199957836733390L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-580275674457841963L].AddComponent<Text>();
           c.text = "8137";
           c.color = new Color(0.584314f, 0.584314f, 0.568627f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
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
        { var c = goMap[-955243112007814197L].AddComponent<Image>();
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
        { var c = goMap[1215796524404458935L].AddComponent<CanvasGroup>();
           c.alpha = 1.000000f;
           c.interactable = true;
           c.blocksRaycasts = true;
           c.ignoreParentGroups = false;
        }
        { var c = goMap[-1612561385618020114L].AddComponent<GridLayoutGroup>();
           c.padding = new RectOffset(0,0,0,0);
           c.cellSize = new Vector2(170.000000f, 40.000000f);
           c.spacing = new Vector2(8.000000f, 0.000000f);
           c.childAlignment = (TextAnchor)5;
        }
        { var c = goMap[-7667441771603489850L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_moneypanel_bg");
        }
        { var c = goMap[-1691431904063077257L].AddComponent<Text>();
           c.text = "4987";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 16;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 0;
           c.resizeTextMaxSize = 70;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[4678354735297362310L].AddComponent<Image>();
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
           c.sprite = LookupSprite("icon_kincontrib");
        }
        { var c = goMap[4107407001160041755L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[4107407001160041755L].AddComponent<UIScalePulse>();
           c.upScale = 1.100000f; c.duration = 0.100000f; c.scaleUp = true;
           c.enabled = true;
        }
        { var c = goMap[4107407001160041755L].AddComponent<Image>();
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
        }
        { var c = goMap[-6653825462572527407L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_moneypanel_plus");
        }
        { var c = goMap[-6284617653211960201L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_moneypanel_bg");
        }
        { var c = goMap[-6069441402752727261L].AddComponent<Text>();
           c.text = "4987";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 16;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 0;
           c.resizeTextMaxSize = 70;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-7486834131713475463L].AddComponent<Image>();
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
           c.sprite = LookupSprite("icon_coin");
        }
        { var c = goMap[-9151381461575678063L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-9151381461575678063L].AddComponent<UIScalePulse>();
           c.upScale = 1.100000f; c.duration = 0.100000f; c.scaleUp = true;
           c.enabled = true;
        }
        { var c = goMap[-9151381461575678063L].AddComponent<Image>();
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
        }
        { var c = goMap[6636252723562815900L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_moneypanel_plus");
        }
        { var c = goMap[4374079833165044205L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_moneypanel_bg");
        }
        { var c = goMap[7336140254322941212L].AddComponent<Text>();
           c.text = "4987";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 16;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 0;
           c.resizeTextMaxSize = 70;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-3270507227197917854L].AddComponent<Image>();
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
        { var c = goMap[-7507518031372023205L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-7507518031372023205L].AddComponent<UIScalePulse>();
           c.upScale = 1.100000f; c.duration = 0.100000f; c.scaleUp = true;
           c.enabled = true;
        }
        { var c = goMap[-7507518031372023205L].AddComponent<Image>();
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
        }
        { var c = goMap[8577955914320050187L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_moneypanel_plus");
        }
        { var c = goMap[8483222073349620622L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_moneypanel_bg");
        }
        { var c = goMap[8628338640451584517L].AddComponent<Text>();
           c.text = "4987";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 16;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 0;
           c.resizeTextMaxSize = 70;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-5077010686124561213L].AddComponent<Image>();
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
           c.sprite = LookupSprite("icon_gold");
        }
        { var c = goMap[3821490267352828035L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[3821490267352828035L].AddComponent<UIScalePulse>();
           c.upScale = 1.100000f; c.duration = 0.100000f; c.scaleUp = true;
           c.enabled = true;
        }
        { var c = goMap[3821490267352828035L].AddComponent<Image>();
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
        }
        { var c = goMap[-3894695405590301992L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_moneypanel_plus");
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
        var rootGO = goMap[8488265890266967383L];
        string path = "Assets/Prefabs/Imported/UICardPicking.prefab";
        PrefabUtility.SaveAsPrefabAsset(rootGO, path);
        Object.DestroyImmediate(rootGO);
        Debug.Log("[Import_res_p_41] Saved " + path);
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