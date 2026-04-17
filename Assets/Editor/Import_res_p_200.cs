// AUTO-GENERATED from res_p_200.ab — DO NOT EDIT MANUALLY.
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;
using System.Collections.Generic;
using KTO.Game;  // UIJoyStick and other ported KTO scripts

public class Import_res_p_200
{
    [MenuItem("KTO/Import/res_p_200")]
    public static void Build()
    {
        Debug.Log("[Import_res_p_200] Building UISkillBookPicking...");

        // ─── Create all GameObjects ───────────────────────────
        var goMap = new Dictionary<long, GameObject>();
        var _toggleGroupByMbPid = new Dictionary<long, ToggleGroup>();
        var _toggleGroupLinks = new List<System.Tuple<Toggle,long>>();
        { var go = new GameObject("UISkillBookPicking"); go.SetActive(true); goMap[-7561915101673553132L] = go; }
        { var go = new GameObject("node"); go.SetActive(true); goMap[4425982114330880011L] = go; }
        { var go = new GameObject("ImgBG"); go.SetActive(true); goMap[108250861536825582L] = go; }
        { var go = new GameObject("BG"); go.SetActive(true); goMap[412392087390704863L] = go; }
        { var go = new GameObject("StarGroup"); go.SetActive(true); goMap[-5907281132247713055L] = go; }
        { var go = new GameObject("Stone"); go.SetActive(true); goMap[4456983735178493399L] = go; }
        { var go = new GameObject("Stone11"); go.SetActive(true); goMap[2445875482852961111L] = go; }
        { var go = new GameObject("Stone01"); go.SetActive(true); goMap[3376428869031111614L] = go; }
        { var go = new GameObject("Stone02"); go.SetActive(true); goMap[-1009477539370787100L] = go; }
        { var go = new GameObject("Stone03"); go.SetActive(true); goMap[4103284138292440985L] = go; }
        { var go = new GameObject("Stone04"); go.SetActive(true); goMap[-7218305171394589783L] = go; }
        { var go = new GameObject("Stone05"); go.SetActive(true); goMap[3624703988301875477L] = go; }
        { var go = new GameObject("Stone06"); go.SetActive(true); goMap[4023889818469903973L] = go; }
        { var go = new GameObject("Stone07"); go.SetActive(true); goMap[-8972723026976856427L] = go; }
        { var go = new GameObject("Stone08"); go.SetActive(true); goMap[-5470046329506897739L] = go; }
        { var go = new GameObject("Stone09"); go.SetActive(true); goMap[-4688634112036592288L] = go; }
        { var go = new GameObject("Stone10"); go.SetActive(true); goMap[-5484359707814149009L] = go; }
        { var go = new GameObject("Stone12"); go.SetActive(true); goMap[-5134437480959385838L] = go; }
        { var go = new GameObject("FuWen"); go.SetActive(true); goMap[1160807071284990916L] = go; }
        { var go = new GameObject("01"); go.SetActive(true); goMap[2686635326143478271L] = go; }
        { var go = new GameObject("02"); go.SetActive(true); goMap[-5668588976390456653L] = go; }
        { var go = new GameObject("03"); go.SetActive(true); goMap[-3034073523632708099L] = go; }
        { var go = new GameObject("04"); go.SetActive(true); goMap[8812887863427875710L] = go; }
        { var go = new GameObject("05"); go.SetActive(true); goMap[8651295259197199910L] = go; }
        { var go = new GameObject("06"); go.SetActive(true); goMap[-622313425000463828L] = go; }
        { var go = new GameObject("07"); go.SetActive(true); goMap[-2276934639615801297L] = go; }
        { var go = new GameObject("08"); go.SetActive(true); goMap[8165548250482636436L] = go; }
        { var go = new GameObject("09"); go.SetActive(true); goMap[-3118400481189974006L] = go; }
        { var go = new GameObject("YuanHuan"); go.SetActive(true); goMap[-6717810245976010036L] = go; }
        { var go = new GameObject("JueSeGlow"); go.SetActive(true); goMap[2557667149849316977L] = go; }
        { var go = new GameObject("DiZuo"); go.SetActive(true); goMap[-700736698821006853L] = go; }
        { var go = new GameObject("juese"); go.SetActive(true); goMap[-3000582078565771415L] = go; }
        { var go = new GameObject("Bone001"); go.SetActive(true); goMap[-9091395072901268044L] = go; }
        { var go = new GameObject("Bone002"); go.SetActive(true); goMap[-8893732001197071518L] = go; }
        { var go = new GameObject("Bone003"); go.SetActive(true); goMap[2125627331380159145L] = go; }
        { var go = new GameObject("Bone004"); go.SetActive(true); goMap[-6299479079816307204L] = go; }
        { var go = new GameObject("Bone005"); go.SetActive(true); goMap[3927032003065825961L] = go; }
        { var go = new GameObject("Bone006"); go.SetActive(true); goMap[-3322538639046035742L] = go; }
        { var go = new GameObject("Bone007"); go.SetActive(true); goMap[-4021340984944492370L] = go; }
        { var go = new GameObject("Bone014"); go.SetActive(true); goMap[-4699401774864302303L] = go; }
        { var go = new GameObject("Bone015"); go.SetActive(true); goMap[4801444820862916835L] = go; }
        { var go = new GameObject("Bone016"); go.SetActive(true); goMap[5470074219117054975L] = go; }
        { var go = new GameObject("Bone017"); go.SetActive(true); goMap[1052285334687428735L] = go; }
        { var go = new GameObject("Bone018"); go.SetActive(true); goMap[5246047689419219000L] = go; }
        { var go = new GameObject("Bone019"); go.SetActive(true); goMap[2387169755296781322L] = go; }
        { var go = new GameObject("Bone020"); go.SetActive(true); goMap[-4519668983975005005L] = go; }
        { var go = new GameObject("Bone021"); go.SetActive(true); goMap[3911132490711139444L] = go; }
        { var go = new GameObject("Bone022"); go.SetActive(true); goMap[8431450211724108215L] = go; }
        { var go = new GameObject("Bone023"); go.SetActive(true); goMap[-7418760307600171343L] = go; }
        { var go = new GameObject("Bone024"); go.SetActive(true); goMap[-211986078146510334L] = go; }
        { var go = new GameObject("Bone008"); go.SetActive(true); goMap[3852581060524698342L] = go; }
        { var go = new GameObject("Bone009"); go.SetActive(true); goMap[-9204848484817000676L] = go; }
        { var go = new GameObject("Bone010"); go.SetActive(true); goMap[5187387259948446086L] = go; }
        { var go = new GameObject("Bone011"); go.SetActive(true); goMap[131971764443233720L] = go; }
        { var go = new GameObject("Bone012"); go.SetActive(true); goMap[-7989092604927122649L] = go; }
        { var go = new GameObject("Bone013"); go.SetActive(true); goMap[-541012292757217903L] = go; }
        { var go = new GameObject("Bone025"); go.SetActive(true); goMap[-6756630554655483847L] = go; }
        { var go = new GameObject("Bone026"); go.SetActive(true); goMap[8039670665077229345L] = go; }
        { var go = new GameObject("Bone027"); go.SetActive(true); goMap[1530725178538067130L] = go; }
        { var go = new GameObject("Bone028"); go.SetActive(true); goMap[5332968979969603567L] = go; }
        { var go = new GameObject("Bone029"); go.SetActive(true); goMap[-8477253252875098881L] = go; }
        { var go = new GameObject("Bone030"); go.SetActive(true); goMap[-3913109959624515166L] = go; }
        { var go = new GameObject("Bone031"); go.SetActive(true); goMap[-2920983813629306690L] = go; }
        { var go = new GameObject("Bone032"); go.SetActive(true); goMap[6365657087753827515L] = go; }
        { var go = new GameObject("Bone033"); go.SetActive(true); goMap[7350682795662314127L] = go; }
        { var go = new GameObject("Bone034"); go.SetActive(true); goMap[-567102096912799069L] = go; }
        { var go = new GameObject("Bone035"); go.SetActive(true); goMap[1313309516657351069L] = go; }
        { var go = new GameObject("Bone036"); go.SetActive(true); goMap[4933935351860717601L] = go; }
        { var go = new GameObject("Plane001"); go.SetActive(true); goMap[1173504617759065041L] = go; }
        { var go = new GameObject("Plane002"); go.SetActive(true); goMap[848331992477891373L] = go; }
        { var go = new GameObject("Plane003"); go.SetActive(true); goMap[7551938577192979676L] = go; }
        { var go = new GameObject("Tui"); go.SetActive(true); goMap[-4414417966503446633L] = go; }
        { var go = new GameObject("GuangHuan"); go.SetActive(true); goMap[-2375117545926318819L] = go; }
        { var go = new GameObject("DaoYing"); go.SetActive(true); goMap[7938209267848746093L] = go; }
        { var go = new GameObject("TouYinLight"); go.SetActive(true); goMap[-7798648971985518451L] = go; }
        { var go = new GameObject("BgGlow"); go.SetActive(true); goMap[-1743022046355857900L] = go; }
        { var go = new GameObject("Glow_Effect"); go.SetActive(true); goMap[7206022857123966071L] = go; }
        { var go = new GameObject("Glow01"); go.SetActive(true); goMap[-6566545425120768884L] = go; }
        { var go = new GameObject("Glow02"); go.SetActive(true); goMap[4958621259587994437L] = go; }
        { var go = new GameObject("CneterGlow"); go.SetActive(true); goMap[-412792916894947829L] = go; }
        { var go = new GameObject("Dot"); go.SetActive(true); goMap[-8349699780383165365L] = go; }
        { var go = new GameObject("NengLiang"); go.SetActive(true); goMap[-1828131576275101302L] = go; }
        { var go = new GameObject("GuangHuan"); go.SetActive(true); goMap[-4315435571947243683L] = go; }
        { var go = new GameObject("DotLine"); go.SetActive(true); goMap[1224361825969862940L] = go; }
        { var go = new GameObject("ZhaoMuEffect"); go.SetActive(false); goMap[-7338627323906862166L] = go; }
        { var go = new GameObject("CneterGlow01"); go.SetActive(true); goMap[-8371750124452697441L] = go; }
        { var go = new GameObject("CneterGlow02"); go.SetActive(true); goMap[8208842205493566080L] = go; }
        { var go = new GameObject("Dot"); go.SetActive(true); goMap[1061790471285719166L] = go; }
        { var go = new GameObject("DotLine"); go.SetActive(true); goMap[-7189061118253480232L] = go; }
        { var go = new GameObject("Tail"); go.SetActive(true); goMap[-9078929786468955203L] = go; }
        { var go = new GameObject("Tail02"); go.SetActive(true); goMap[-508002100171594981L] = go; }
        { var go = new GameObject("Tail03"); go.SetActive(true); goMap[6498500052796493564L] = go; }
        { var go = new GameObject("Tail04"); go.SetActive(true); goMap[-3335561694425684901L] = go; }
        { var go = new GameObject("Tail05"); go.SetActive(true); goMap[-986779303296505056L] = go; }
        { var go = new GameObject("InsideGlow"); go.SetActive(true); goMap[-6053562829956968992L] = go; }
        { var go = new GameObject("BaoFa"); go.SetActive(true); goMap[-3237813191014856203L] = go; }
        { var go = new GameObject("M7"); go.SetActive(true); goMap[-4698316339324953264L] = go; }
        { var go = new GameObject("M1"); go.SetActive(true); goMap[335547599258714052L] = go; }
        { var go = new GameObject("M2"); go.SetActive(true); goMap[6878000719666593223L] = go; }
        { var go = new GameObject("M3_1"); go.SetActive(true); goMap[-4211356159269113984L] = go; }
        { var go = new GameObject("M8"); go.SetActive(true); goMap[8389677997376403405L] = go; }
        { var go = new GameObject("M9"); go.SetActive(true); goMap[-2537814418718126533L] = go; }
        { var go = new GameObject("M10"); go.SetActive(true); goMap[-7660046244318212343L] = go; }
        { var go = new GameObject("M11"); go.SetActive(true); goMap[-784431330527731143L] = go; }
        { var go = new GameObject("M12"); go.SetActive(true); goMap[-3975263722381306141L] = go; }
        { var go = new GameObject("BgGlow"); go.SetActive(true); goMap[3682236084374798457L] = go; }
        { var go = new GameObject("Inside"); go.SetActive(true); goMap[-5590169230402251301L] = go; }
        { var go = new GameObject("Loop"); go.SetActive(true); goMap[-5146659227913066691L] = go; }
        { var go = new GameObject("GlowLine"); go.SetActive(true); goMap[-5144823035355768084L] = go; }
        { var go = new GameObject("UIMoneyPanel"); go.SetActive(true); goMap[-6287603901396786336L] = go; }
        { var go = new GameObject("panelList"); go.SetActive(true); goMap[3068774569708045574L] = go; }
        { var go = new GameObject("panelDynamic"); go.SetActive(false); goMap[-4266730709693631888L] = go; }
        { var go = new GameObject("BgDynamic"); go.SetActive(true); goMap[-685186880043692449L] = go; }
        { var go = new GameObject("txtDynamic"); go.SetActive(true); goMap[8411064718115362268L] = go; }
        { var go = new GameObject("imgDynamic"); go.SetActive(true); goMap[4537409364233245584L] = go; }
        { var go = new GameObject("btnPlusDynamic"); go.SetActive(true); goMap[-8099691358505882177L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[4367075698168847682L] = go; }
        { var go = new GameObject("panelCoin"); go.SetActive(true); goMap[2023220565904270072L] = go; }
        { var go = new GameObject("BgCoin"); go.SetActive(true); goMap[-8380796256678767058L] = go; }
        { var go = new GameObject("txtCoinValue"); go.SetActive(true); goMap[-5706410927349647651L] = go; }
        { var go = new GameObject("imgCoin"); go.SetActive(true); goMap[8699900415256598228L] = go; }
        { var go = new GameObject("btnPlusCoin"); go.SetActive(true); goMap[2012651930417467783L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[2027100172096224126L] = go; }
        { var go = new GameObject("panelYuanBao"); go.SetActive(true); goMap[-1786720765218581177L] = go; }
        { var go = new GameObject("BgYuanBao"); go.SetActive(true); goMap[2655795610957533070L] = go; }
        { var go = new GameObject("txtYuanBaoValue"); go.SetActive(true); goMap[3244165922332707993L] = go; }
        { var go = new GameObject("imgYuanBao"); go.SetActive(true); goMap[1709750185729026993L] = go; }
        { var go = new GameObject("btnPlusYuanBao"); go.SetActive(true); goMap[-5823306048871318281L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[9142746292198219509L] = go; }
        { var go = new GameObject("panelGold"); go.SetActive(true); goMap[6171822335128710518L] = go; }
        { var go = new GameObject("BgGold"); go.SetActive(true); goMap[-3569606862743835244L] = go; }
        { var go = new GameObject("txtGoldValue"); go.SetActive(true); goMap[3080816573675997141L] = go; }
        { var go = new GameObject("imgGold"); go.SetActive(true); goMap[-1572542169620759234L] = go; }
        { var go = new GameObject("btnPlusGold"); go.SetActive(true); goMap[6344949757999971202L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[1714527679141761683L] = go; }
        { var go = new GameObject("imgBG"); go.SetActive(true); goMap[-8333227539888330473L] = go; }
        { var go = new GameObject("txtTitle"); go.SetActive(false); goMap[-9061946888654598661L] = go; }
        { var go = new GameObject("btnClose"); go.SetActive(true); goMap[1517114853165202446L] = go; }
        { var go = new GameObject("Content"); go.SetActive(true); goMap[-741218888426864545L] = go; }
        { var go = new GameObject("IconTenPick"); go.SetActive(true); goMap[-3398803665771306097L] = go; }
        { var go = new GameObject("txtTenPickValue"); go.SetActive(true); goMap[-9132697027396470047L] = go; }
        { var go = new GameObject("btnTenPick"); go.SetActive(true); goMap[-1804719081436846616L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[4769563380497257903L] = go; }
        { var go = new GameObject("IconPick"); go.SetActive(true); goMap[191905735053379250L] = go; }
        { var go = new GameObject("txtPickValue"); go.SetActive(true); goMap[-1339233964520797925L] = go; }
        { var go = new GameObject("btnPick"); go.SetActive(true); goMap[212083927804020650L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-5002949637649751806L] = go; }
        { var go = new GameObject("txtTips"); go.SetActive(true); goMap[5261215109483293296L] = go; }

        // ─── Parent links ─────────────────────────────────────
        goMap[4425982114330880011L].transform.SetParent(goMap[-7561915101673553132L].transform, false);
        goMap[108250861536825582L].transform.SetParent(goMap[4425982114330880011L].transform, false);
        goMap[412392087390704863L].transform.SetParent(goMap[108250861536825582L].transform, false);
        goMap[-5907281132247713055L].transform.SetParent(goMap[108250861536825582L].transform, false);
        goMap[4456983735178493399L].transform.SetParent(goMap[108250861536825582L].transform, false);
        goMap[2445875482852961111L].transform.SetParent(goMap[4456983735178493399L].transform, false);
        goMap[3376428869031111614L].transform.SetParent(goMap[4456983735178493399L].transform, false);
        goMap[-1009477539370787100L].transform.SetParent(goMap[4456983735178493399L].transform, false);
        goMap[4103284138292440985L].transform.SetParent(goMap[4456983735178493399L].transform, false);
        goMap[-7218305171394589783L].transform.SetParent(goMap[4456983735178493399L].transform, false);
        goMap[3624703988301875477L].transform.SetParent(goMap[4456983735178493399L].transform, false);
        goMap[4023889818469903973L].transform.SetParent(goMap[4456983735178493399L].transform, false);
        goMap[-8972723026976856427L].transform.SetParent(goMap[4456983735178493399L].transform, false);
        goMap[-5470046329506897739L].transform.SetParent(goMap[4456983735178493399L].transform, false);
        goMap[-4688634112036592288L].transform.SetParent(goMap[4456983735178493399L].transform, false);
        goMap[-5484359707814149009L].transform.SetParent(goMap[4456983735178493399L].transform, false);
        goMap[-5134437480959385838L].transform.SetParent(goMap[4456983735178493399L].transform, false);
        goMap[1160807071284990916L].transform.SetParent(goMap[108250861536825582L].transform, false);
        goMap[2686635326143478271L].transform.SetParent(goMap[1160807071284990916L].transform, false);
        goMap[-5668588976390456653L].transform.SetParent(goMap[1160807071284990916L].transform, false);
        goMap[-3034073523632708099L].transform.SetParent(goMap[1160807071284990916L].transform, false);
        goMap[8812887863427875710L].transform.SetParent(goMap[1160807071284990916L].transform, false);
        goMap[8651295259197199910L].transform.SetParent(goMap[1160807071284990916L].transform, false);
        goMap[-622313425000463828L].transform.SetParent(goMap[1160807071284990916L].transform, false);
        goMap[-2276934639615801297L].transform.SetParent(goMap[1160807071284990916L].transform, false);
        goMap[8165548250482636436L].transform.SetParent(goMap[1160807071284990916L].transform, false);
        goMap[-3118400481189974006L].transform.SetParent(goMap[1160807071284990916L].transform, false);
        goMap[-6717810245976010036L].transform.SetParent(goMap[108250861536825582L].transform, false);
        goMap[2557667149849316977L].transform.SetParent(goMap[108250861536825582L].transform, false);
        goMap[-700736698821006853L].transform.SetParent(goMap[108250861536825582L].transform, false);
        goMap[-3000582078565771415L].transform.SetParent(goMap[108250861536825582L].transform, false);
        goMap[-9091395072901268044L].transform.SetParent(goMap[-3000582078565771415L].transform, false);
        goMap[-8893732001197071518L].transform.SetParent(goMap[-9091395072901268044L].transform, false);
        goMap[2125627331380159145L].transform.SetParent(goMap[-8893732001197071518L].transform, false);
        goMap[-6299479079816307204L].transform.SetParent(goMap[2125627331380159145L].transform, false);
        goMap[3927032003065825961L].transform.SetParent(goMap[-6299479079816307204L].transform, false);
        goMap[-3322538639046035742L].transform.SetParent(goMap[3927032003065825961L].transform, false);
        goMap[-4021340984944492370L].transform.SetParent(goMap[-3322538639046035742L].transform, false);
        goMap[-4699401774864302303L].transform.SetParent(goMap[-8893732001197071518L].transform, false);
        goMap[4801444820862916835L].transform.SetParent(goMap[-4699401774864302303L].transform, false);
        goMap[5470074219117054975L].transform.SetParent(goMap[4801444820862916835L].transform, false);
        goMap[1052285334687428735L].transform.SetParent(goMap[5470074219117054975L].transform, false);
        goMap[5246047689419219000L].transform.SetParent(goMap[1052285334687428735L].transform, false);
        goMap[2387169755296781322L].transform.SetParent(goMap[5246047689419219000L].transform, false);
        goMap[-4519668983975005005L].transform.SetParent(goMap[2387169755296781322L].transform, false);
        goMap[3911132490711139444L].transform.SetParent(goMap[-4519668983975005005L].transform, false);
        goMap[8431450211724108215L].transform.SetParent(goMap[3911132490711139444L].transform, false);
        goMap[-7418760307600171343L].transform.SetParent(goMap[8431450211724108215L].transform, false);
        goMap[-211986078146510334L].transform.SetParent(goMap[-7418760307600171343L].transform, false);
        goMap[3852581060524698342L].transform.SetParent(goMap[-9091395072901268044L].transform, false);
        goMap[-9204848484817000676L].transform.SetParent(goMap[3852581060524698342L].transform, false);
        goMap[5187387259948446086L].transform.SetParent(goMap[-9204848484817000676L].transform, false);
        goMap[131971764443233720L].transform.SetParent(goMap[5187387259948446086L].transform, false);
        goMap[-7989092604927122649L].transform.SetParent(goMap[131971764443233720L].transform, false);
        goMap[-541012292757217903L].transform.SetParent(goMap[-7989092604927122649L].transform, false);
        goMap[-6756630554655483847L].transform.SetParent(goMap[3852581060524698342L].transform, false);
        goMap[8039670665077229345L].transform.SetParent(goMap[-6756630554655483847L].transform, false);
        goMap[1530725178538067130L].transform.SetParent(goMap[8039670665077229345L].transform, false);
        goMap[5332968979969603567L].transform.SetParent(goMap[1530725178538067130L].transform, false);
        goMap[-8477253252875098881L].transform.SetParent(goMap[5332968979969603567L].transform, false);
        goMap[-3913109959624515166L].transform.SetParent(goMap[-8477253252875098881L].transform, false);
        goMap[-2920983813629306690L].transform.SetParent(goMap[-3913109959624515166L].transform, false);
        goMap[6365657087753827515L].transform.SetParent(goMap[-2920983813629306690L].transform, false);
        goMap[7350682795662314127L].transform.SetParent(goMap[6365657087753827515L].transform, false);
        goMap[-567102096912799069L].transform.SetParent(goMap[7350682795662314127L].transform, false);
        goMap[1313309516657351069L].transform.SetParent(goMap[-567102096912799069L].transform, false);
        goMap[4933935351860717601L].transform.SetParent(goMap[1313309516657351069L].transform, false);
        goMap[1173504617759065041L].transform.SetParent(goMap[-3000582078565771415L].transform, false);
        goMap[848331992477891373L].transform.SetParent(goMap[-3000582078565771415L].transform, false);
        goMap[7551938577192979676L].transform.SetParent(goMap[-3000582078565771415L].transform, false);
        goMap[-4414417966503446633L].transform.SetParent(goMap[-3000582078565771415L].transform, false);
        goMap[-2375117545926318819L].transform.SetParent(goMap[108250861536825582L].transform, false);
        goMap[7938209267848746093L].transform.SetParent(goMap[108250861536825582L].transform, false);
        goMap[-7798648971985518451L].transform.SetParent(goMap[108250861536825582L].transform, false);
        goMap[-1743022046355857900L].transform.SetParent(goMap[108250861536825582L].transform, false);
        goMap[7206022857123966071L].transform.SetParent(goMap[108250861536825582L].transform, false);
        goMap[-6566545425120768884L].transform.SetParent(goMap[7206022857123966071L].transform, false);
        goMap[4958621259587994437L].transform.SetParent(goMap[7206022857123966071L].transform, false);
        goMap[-412792916894947829L].transform.SetParent(goMap[7206022857123966071L].transform, false);
        goMap[-8349699780383165365L].transform.SetParent(goMap[7206022857123966071L].transform, false);
        goMap[-1828131576275101302L].transform.SetParent(goMap[7206022857123966071L].transform, false);
        goMap[-4315435571947243683L].transform.SetParent(goMap[7206022857123966071L].transform, false);
        goMap[1224361825969862940L].transform.SetParent(goMap[7206022857123966071L].transform, false);
        goMap[-7338627323906862166L].transform.SetParent(goMap[7206022857123966071L].transform, false);
        goMap[-8371750124452697441L].transform.SetParent(goMap[-7338627323906862166L].transform, false);
        goMap[8208842205493566080L].transform.SetParent(goMap[-7338627323906862166L].transform, false);
        goMap[1061790471285719166L].transform.SetParent(goMap[-7338627323906862166L].transform, false);
        goMap[-7189061118253480232L].transform.SetParent(goMap[-7338627323906862166L].transform, false);
        goMap[-9078929786468955203L].transform.SetParent(goMap[-7338627323906862166L].transform, false);
        goMap[-508002100171594981L].transform.SetParent(goMap[-7338627323906862166L].transform, false);
        goMap[6498500052796493564L].transform.SetParent(goMap[-7338627323906862166L].transform, false);
        goMap[-3335561694425684901L].transform.SetParent(goMap[-7338627323906862166L].transform, false);
        goMap[-986779303296505056L].transform.SetParent(goMap[-7338627323906862166L].transform, false);
        goMap[-6053562829956968992L].transform.SetParent(goMap[-7338627323906862166L].transform, false);
        goMap[-3237813191014856203L].transform.SetParent(goMap[-7338627323906862166L].transform, false);
        goMap[-4698316339324953264L].transform.SetParent(goMap[-3237813191014856203L].transform, false);
        goMap[335547599258714052L].transform.SetParent(goMap[-3237813191014856203L].transform, false);
        goMap[6878000719666593223L].transform.SetParent(goMap[-3237813191014856203L].transform, false);
        goMap[-4211356159269113984L].transform.SetParent(goMap[-3237813191014856203L].transform, false);
        goMap[8389677997376403405L].transform.SetParent(goMap[-3237813191014856203L].transform, false);
        goMap[-2537814418718126533L].transform.SetParent(goMap[-3237813191014856203L].transform, false);
        goMap[-7660046244318212343L].transform.SetParent(goMap[-3237813191014856203L].transform, false);
        goMap[-784431330527731143L].transform.SetParent(goMap[-3237813191014856203L].transform, false);
        goMap[-3975263722381306141L].transform.SetParent(goMap[-3237813191014856203L].transform, false);
        goMap[3682236084374798457L].transform.SetParent(goMap[-7338627323906862166L].transform, false);
        goMap[-5590169230402251301L].transform.SetParent(goMap[-7338627323906862166L].transform, false);
        goMap[-5146659227913066691L].transform.SetParent(goMap[-7338627323906862166L].transform, false);
        goMap[-5144823035355768084L].transform.SetParent(goMap[-7338627323906862166L].transform, false);
        goMap[-6287603901396786336L].transform.SetParent(goMap[4425982114330880011L].transform, false);
        goMap[3068774569708045574L].transform.SetParent(goMap[-6287603901396786336L].transform, false);
        goMap[-4266730709693631888L].transform.SetParent(goMap[3068774569708045574L].transform, false);
        goMap[-685186880043692449L].transform.SetParent(goMap[-4266730709693631888L].transform, false);
        goMap[8411064718115362268L].transform.SetParent(goMap[-4266730709693631888L].transform, false);
        goMap[4537409364233245584L].transform.SetParent(goMap[-4266730709693631888L].transform, false);
        goMap[-8099691358505882177L].transform.SetParent(goMap[-4266730709693631888L].transform, false);
        goMap[4367075698168847682L].transform.SetParent(goMap[-8099691358505882177L].transform, false);
        goMap[2023220565904270072L].transform.SetParent(goMap[3068774569708045574L].transform, false);
        goMap[-8380796256678767058L].transform.SetParent(goMap[2023220565904270072L].transform, false);
        goMap[-5706410927349647651L].transform.SetParent(goMap[2023220565904270072L].transform, false);
        goMap[8699900415256598228L].transform.SetParent(goMap[2023220565904270072L].transform, false);
        goMap[2012651930417467783L].transform.SetParent(goMap[2023220565904270072L].transform, false);
        goMap[2027100172096224126L].transform.SetParent(goMap[2012651930417467783L].transform, false);
        goMap[-1786720765218581177L].transform.SetParent(goMap[3068774569708045574L].transform, false);
        goMap[2655795610957533070L].transform.SetParent(goMap[-1786720765218581177L].transform, false);
        goMap[3244165922332707993L].transform.SetParent(goMap[-1786720765218581177L].transform, false);
        goMap[1709750185729026993L].transform.SetParent(goMap[-1786720765218581177L].transform, false);
        goMap[-5823306048871318281L].transform.SetParent(goMap[-1786720765218581177L].transform, false);
        goMap[9142746292198219509L].transform.SetParent(goMap[-5823306048871318281L].transform, false);
        goMap[6171822335128710518L].transform.SetParent(goMap[3068774569708045574L].transform, false);
        goMap[-3569606862743835244L].transform.SetParent(goMap[6171822335128710518L].transform, false);
        goMap[3080816573675997141L].transform.SetParent(goMap[6171822335128710518L].transform, false);
        goMap[-1572542169620759234L].transform.SetParent(goMap[6171822335128710518L].transform, false);
        goMap[6344949757999971202L].transform.SetParent(goMap[6171822335128710518L].transform, false);
        goMap[1714527679141761683L].transform.SetParent(goMap[6344949757999971202L].transform, false);
        goMap[-8333227539888330473L].transform.SetParent(goMap[4425982114330880011L].transform, false);
        goMap[-9061946888654598661L].transform.SetParent(goMap[-8333227539888330473L].transform, false);
        goMap[1517114853165202446L].transform.SetParent(goMap[-8333227539888330473L].transform, false);
        goMap[-741218888426864545L].transform.SetParent(goMap[-8333227539888330473L].transform, false);
        goMap[-3398803665771306097L].transform.SetParent(goMap[-741218888426864545L].transform, false);
        goMap[-9132697027396470047L].transform.SetParent(goMap[-3398803665771306097L].transform, false);
        goMap[-1804719081436846616L].transform.SetParent(goMap[-741218888426864545L].transform, false);
        goMap[4769563380497257903L].transform.SetParent(goMap[-1804719081436846616L].transform, false);
        goMap[191905735053379250L].transform.SetParent(goMap[-741218888426864545L].transform, false);
        goMap[-1339233964520797925L].transform.SetParent(goMap[191905735053379250L].transform, false);
        goMap[212083927804020650L].transform.SetParent(goMap[-741218888426864545L].transform, false);
        goMap[-5002949637649751806L].transform.SetParent(goMap[212083927804020650L].transform, false);
        goMap[5261215109483293296L].transform.SetParent(goMap[-741218888426864545L].transform, false);

        // ─── RectTransforms ──────────────────────────────────
        {
            var rt = goMap[-7561915101673553132L].AddComponent<RectTransform>();
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
            var rt = goMap[4425982114330880011L].AddComponent<RectTransform>();
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
            var rt = goMap[108250861536825582L].AddComponent<RectTransform>();
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
            var rt = goMap[412392087390704863L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(0.900000f, 0.900000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(1960.000000f, 1280.000000f);
        }
        {
            var rt = goMap[-5907281132247713055L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(1264.000000f, 528.000000f);
        }
        {
            var rt = goMap[4456983735178493399L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(1837.000000f, 613.000000f);
        }
        {
            var rt = goMap[2445875482852961111L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -227.000000f);
            rt.sizeDelta = new Vector2(1837.000000f, 613.000000f);
        }
        {
            var rt = goMap[3376428869031111614L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-318.000000f, -271.000000f);
            rt.sizeDelta = new Vector2(105.000000f, 62.000000f);
        }
        {
            var rt = goMap[-1009477539370787100L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(72.000000f, 78.000000f);
        }
        {
            var rt = goMap[4103284138292440985L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-567.000000f, -287.000000f);
            rt.sizeDelta = new Vector2(99.000000f, 87.000000f);
        }
        {
            var rt = goMap[-7218305171394589783L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(44.000000f, -341.000000f);
            rt.sizeDelta = new Vector2(125.000000f, 76.000000f);
        }
        {
            var rt = goMap[3624703988301875477L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-515.000000f, -21.000000f);
            rt.sizeDelta = new Vector2(59.000000f, 63.000000f);
        }
        {
            var rt = goMap[4023889818469903973L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(73.000000f, 67.000000f);
        }
        {
            var rt = goMap[-8972723026976856427L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(656.000000f, 205.000000f);
            rt.sizeDelta = new Vector2(73.000000f, 108.000000f);
        }
        {
            var rt = goMap[-5470046329506897739L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(744.000000f, 259.000000f);
            rt.sizeDelta = new Vector2(115.000000f, 121.000000f);
        }
        {
            var rt = goMap[-4688634112036592288L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(415.000000f, -250.000000f);
            rt.sizeDelta = new Vector2(55.000000f, 59.000000f);
        }
        {
            var rt = goMap[-5484359707814149009L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(601.000000f, -239.000000f);
            rt.sizeDelta = new Vector2(172.000000f, 109.000000f);
        }
        {
            var rt = goMap[-5134437480959385838L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -227.000000f);
            rt.sizeDelta = new Vector2(1837.000000f, 613.000000f);
        }
        {
            var rt = goMap[1160807071284990916L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-331.000000f, 141.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[2686635326143478271L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-34.500000f, -125.000000f);
            rt.sizeDelta = new Vector2(31.000000f, 350.000000f);
        }
        {
            var rt = goMap[-5668588976390456653L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(57.930000f, -50.000000f);
            rt.sizeDelta = new Vector2(35.000000f, 347.000000f);
        }
        {
            var rt = goMap[-3034073523632708099L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(149.860001f, -162.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 359.000000f);
        }
        {
            var rt = goMap[8812887863427875710L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(239.790009f, -3.500000f);
            rt.sizeDelta = new Vector2(31.000000f, 350.000000f);
        }
        {
            var rt = goMap[8651295259197199910L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(332.220001f, 20.000000f);
            rt.sizeDelta = new Vector2(35.000000f, 347.000000f);
        }
        {
            var rt = goMap[-622313425000463828L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(424.149994f, -8.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 359.000000f);
        }
        {
            var rt = goMap[-2276934639615801297L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(514.080017f, -109.000000f);
            rt.sizeDelta = new Vector2(31.000000f, 350.000000f);
        }
        {
            var rt = goMap[8165548250482636436L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(606.510010f, -90.000000f);
            rt.sizeDelta = new Vector2(35.000000f, 347.000000f);
        }
        {
            var rt = goMap[-3118400481189974006L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(698.440002f, -129.500000f);
            rt.sizeDelta = new Vector2(30.000000f, 359.000000f);
        }
        {
            var rt = goMap[-6717810245976010036L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(780.000000f, 652.000000f);
        }
        {
            var rt = goMap[2557667149849316977L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -39.000000f);
            rt.sizeDelta = new Vector2(273.000000f, 287.000000f);
        }
        {
            var rt = goMap[-700736698821006853L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-8.000000f, -191.000000f);
            rt.sizeDelta = new Vector2(564.000000f, 126.000000f);
        }
        {
            var rt = goMap[-2375117545926318819L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -39.000000f);
            rt.sizeDelta = new Vector2(182.000000f, 129.000000f);
        }
        {
            var rt = goMap[7938209267848746093L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -188.000000f);
            rt.sizeDelta = new Vector2(493.000000f, 328.000000f);
        }
        {
            var rt = goMap[-7798648971985518451L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -244.000000f);
            rt.sizeDelta = new Vector2(241.000000f, 135.000000f);
        }
        {
            var rt = goMap[-1743022046355857900L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(17.000000f, -58.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[7206022857123966071L].AddComponent<RectTransform>();
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
            var rt = goMap[-6566545425120768884L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(182.000000f, 129.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(2.500000f, -54.700001f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[4958621259587994437L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,-1.000000f,0.000000f,0.000000f);
            rt.localScale = new Vector3(20.008421f, 17.861040f, 0.324746f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-4.600000f, -47.700001f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-412792916894947829L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-1.700000f, -49.200001f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-8349699780383165365L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-2.000000f, -46.400002f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-1828131576275101302L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,-1.000000f,0.000000f,0.000000f);
            rt.localScale = new Vector3(39.573086f, 35.325947f, 0.642290f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(1.000000f, 111.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-4315435571947243683L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -47.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[1224361825969862940L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-2.000000f, -46.400002f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-7338627323906862166L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-1.500000f, -48.299999f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-8371750124452697441L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.200000f, -0.900005f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[8208842205493566080L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.200000f, -0.900005f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[1061790471285719166L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.500000f, 1.899990f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-7189061118253480232L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.500000f, 1.899990f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-9078929786468955203L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, -194.000000f);
            rt.localRotation = new Quaternion(-0.041880f,0.424098f,0.088903f,0.900268f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(19.000000f, 35.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-508002100171594981L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 34.000000f);
            rt.localRotation = new Quaternion(0.095936f,-0.984263f,0.022996f,0.146612f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-79.000000f, 102.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[6498500052796493564L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, -99.000000f);
            rt.localRotation = new Quaternion(0.032474f,-0.824500f,0.244786f,0.509142f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-38.000000f, -3.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-3335561694425684901L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, -248.000015f);
            rt.localRotation = new Quaternion(0.593562f,0.220039f,-0.317393f,0.706065f);
            rt.localScale = new Vector3(-0.787870f, 0.787870f, 0.787870f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-180.000000f, 73.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-986779303296505056L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, -261.800018f);
            rt.localRotation = new Quaternion(0.323667f,0.902466f,0.002887f,-0.284229f);
            rt.localScale = new Vector3(-1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(95.000000f, 35.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-6053562829956968992L].AddComponent<RectTransform>();
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
            var rt = goMap[-3237813191014856203L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 6576.479492f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000080f, 1.000080f, 1.000080f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.500000f, 4.300000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[3682236084374798457L].AddComponent<RectTransform>();
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
            var rt = goMap[-5590169230402251301L].AddComponent<RectTransform>();
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
            var rt = goMap[-5146659227913066691L].AddComponent<RectTransform>();
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
            var rt = goMap[-5144823035355768084L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(2.000000f, 2.000000f, 2.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-6287603901396786336L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, -7.731608f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(106.000000f, 311.000000f);
            rt.sizeDelta = new Vector2(745.000000f, 60.000000f);
        }
        {
            var rt = goMap[3068774569708045574L].AddComponent<RectTransform>();
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
            var rt = goMap[-4266730709693631888L].AddComponent<RectTransform>();
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
            var rt = goMap[-685186880043692449L].AddComponent<RectTransform>();
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
            var rt = goMap[8411064718115362268L].AddComponent<RectTransform>();
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
            var rt = goMap[4537409364233245584L].AddComponent<RectTransform>();
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
            var rt = goMap[-8099691358505882177L].AddComponent<RectTransform>();
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
            var rt = goMap[4367075698168847682L].AddComponent<RectTransform>();
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
            var rt = goMap[2023220565904270072L].AddComponent<RectTransform>();
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
            var rt = goMap[-8380796256678767058L].AddComponent<RectTransform>();
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
            var rt = goMap[-5706410927349647651L].AddComponent<RectTransform>();
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
            var rt = goMap[8699900415256598228L].AddComponent<RectTransform>();
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
            var rt = goMap[2012651930417467783L].AddComponent<RectTransform>();
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
            var rt = goMap[2027100172096224126L].AddComponent<RectTransform>();
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
            var rt = goMap[-1786720765218581177L].AddComponent<RectTransform>();
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
            var rt = goMap[2655795610957533070L].AddComponent<RectTransform>();
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
            var rt = goMap[3244165922332707993L].AddComponent<RectTransform>();
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
            var rt = goMap[1709750185729026993L].AddComponent<RectTransform>();
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
            var rt = goMap[-5823306048871318281L].AddComponent<RectTransform>();
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
            var rt = goMap[9142746292198219509L].AddComponent<RectTransform>();
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
            var rt = goMap[6171822335128710518L].AddComponent<RectTransform>();
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
            var rt = goMap[-3569606862743835244L].AddComponent<RectTransform>();
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
            var rt = goMap[3080816573675997141L].AddComponent<RectTransform>();
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
            var rt = goMap[-1572542169620759234L].AddComponent<RectTransform>();
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
            var rt = goMap[6344949757999971202L].AddComponent<RectTransform>();
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
            var rt = goMap[1714527679141761683L].AddComponent<RectTransform>();
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
            var rt = goMap[-8333227539888330473L].AddComponent<RectTransform>();
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
            var rt = goMap[-9061946888654598661L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(19.000000f, -53.000000f);
            rt.sizeDelta = new Vector2(200.000000f, 70.000000f);
        }
        {
            var rt = goMap[1517114853165202446L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 1.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-74.000000f, -62.000000f);
            rt.sizeDelta = new Vector2(44.000000f, 44.000000f);
        }
        {
            var rt = goMap[-741218888426864545L].AddComponent<RectTransform>();
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
            var rt = goMap[-3398803665771306097L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.000000f);
            rt.anchorMax = new Vector2(0.500000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(183.000000f, 144.000000f);
            rt.sizeDelta = new Vector2(32.000000f, 32.000000f);
        }
        {
            var rt = goMap[-9132697027396470047L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 8.375000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(66.194778f, -0.200000f);
            rt.sizeDelta = new Vector2(88.789597f, 50.000000f);
        }
        {
            var rt = goMap[-1804719081436846616L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 8.375000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.000000f);
            rt.anchorMax = new Vector2(0.500000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(223.000000f, 94.000000f);
            rt.sizeDelta = new Vector2(150.000000f, 52.000000f);
        }
        {
            var rt = goMap[4769563380497257903L].AddComponent<RectTransform>();
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
            var rt = goMap[191905735053379250L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.000000f);
            rt.anchorMax = new Vector2(0.500000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-256.000000f, 144.000000f);
            rt.sizeDelta = new Vector2(32.000000f, 32.000000f);
        }
        {
            var rt = goMap[-1339233964520797925L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 8.375000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(65.874146f, -0.200000f);
            rt.sizeDelta = new Vector2(87.748299f, 50.000000f);
        }
        {
            var rt = goMap[212083927804020650L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 8.375000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.000000f);
            rt.anchorMax = new Vector2(0.500000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-220.000000f, 94.000000f);
            rt.sizeDelta = new Vector2(150.000000f, 52.000000f);
        }
        {
            var rt = goMap[-5002949637649751806L].AddComponent<RectTransform>();
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
            var rt = goMap[5261215109483293296L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -325.000000f);
            rt.sizeDelta = new Vector2(400.000000f, 40.000000f);
        }

        // ─── Components ──────────────────────────────────────
        { var c = goMap[-7561915101673553132L].AddComponent<Canvas>();
           c.renderMode = (RenderMode)1;
           c.overrideSorting = false;
           c.sortingOrder = 0;
           c.sortingLayerID = unchecked((int)194136777);
           c.planeDistance = 8.660000f;
           c.pixelPerfect = false;
           c.additionalShaderChannels = (AdditionalCanvasShaderChannels)0;
           c.enabled = true;
        }
        { var c = goMap[-7561915101673553132L].AddComponent<CanvasScaler>();
           c.uiScaleMode = (CanvasScaler.ScaleMode)1;
           c.referenceResolution = new Vector2(1280.000000f, 720.000000f);
           c.screenMatchMode = (CanvasScaler.ScreenMatchMode)1;
           c.matchWidthOrHeight = 0.000000f;
           c.referencePixelsPerUnit = 100.000000f;
        }
        { var c = goMap[-7561915101673553132L].AddComponent<GraphicRaycaster>();
           c.ignoreReversedGraphics = true;
        }
        { var c = goMap[-7561915101673553132L].AddComponent<Image>();
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
        { var c = goMap[412392087390704863L].AddComponent<Image>();
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
           c.sprite = LookupSprite("BG");
        }
        { var c = goMap[-5907281132247713055L].AddComponent<Image>();
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
        { var c = goMap[4456983735178493399L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("Stone"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[2445875482852961111L].AddComponent<Image>();
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
        { var c = goMap[3376428869031111614L].AddComponent<Image>();
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
           c.sprite = LookupSprite("Stone01");
        }
        { var c = goMap[-1009477539370787100L].AddComponent<Image>();
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
           c.sprite = LookupSprite("Stone02");
        }
        { var c = goMap[4103284138292440985L].AddComponent<Image>();
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
           c.sprite = LookupSprite("Stone03");
        }
        { var c = goMap[-7218305171394589783L].AddComponent<Image>();
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
           c.sprite = LookupSprite("Stone04");
        }
        { var c = goMap[3624703988301875477L].AddComponent<Image>();
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
           c.sprite = LookupSprite("Stone05");
        }
        { var c = goMap[4023889818469903973L].AddComponent<Image>();
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
           c.sprite = LookupSprite("Stone06");
        }
        { var c = goMap[-8972723026976856427L].AddComponent<Image>();
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
           c.sprite = LookupSprite("Stone07");
        }
        { var c = goMap[-5470046329506897739L].AddComponent<Image>();
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
           c.sprite = LookupSprite("Stone08");
        }
        { var c = goMap[-4688634112036592288L].AddComponent<Image>();
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
           c.sprite = LookupSprite("Stone09");
        }
        { var c = goMap[-5484359707814149009L].AddComponent<Image>();
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
           c.sprite = LookupSprite("Stone10");
        }
        { var c = goMap[-5134437480959385838L].AddComponent<Image>();
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
        { var c = goMap[-5134437480959385838L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("Stone"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[2686635326143478271L].AddComponent<Image>();
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
        { var c = goMap[-5668588976390456653L].AddComponent<Image>();
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
        { var c = goMap[-3034073523632708099L].AddComponent<Image>();
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
        { var c = goMap[8812887863427875710L].AddComponent<Image>();
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
        { var c = goMap[8651295259197199910L].AddComponent<Image>();
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
        { var c = goMap[-622313425000463828L].AddComponent<Image>();
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
        { var c = goMap[-2276934639615801297L].AddComponent<Image>();
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
        { var c = goMap[8165548250482636436L].AddComponent<Image>();
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
        { var c = goMap[-3118400481189974006L].AddComponent<Image>();
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
        { var c = goMap[-6717810245976010036L].AddComponent<Image>();
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
           c.sprite = LookupSprite("YuanHuan");
        }
        { var c = goMap[2557667149849316977L].AddComponent<Image>();
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
        { var c = goMap[-700736698821006853L].AddComponent<Image>();
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
           c.sprite = LookupSprite("DiZuo");
        }
        { var c = goMap[-3000582078565771415L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("JueSe"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[-2375117545926318819L].AddComponent<Image>();
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
           c.sprite = LookupSprite("GuangHuan");
        }
        { var c = goMap[7938209267848746093L].AddComponent<Image>();
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
        { var c = goMap[-7798648971985518451L].AddComponent<Image>();
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
        { var c = goMap[7206022857123966071L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = false;
           { var ctrl = LookupAnimatorController("ZhaoMu"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[-6287603901396786336L].AddComponent<CanvasGroup>();
           c.alpha = 1.000000f;
           c.interactable = true;
           c.blocksRaycasts = true;
           c.ignoreParentGroups = false;
        }
        { var c = goMap[3068774569708045574L].AddComponent<GridLayoutGroup>();
           c.padding = new RectOffset(0,0,0,0);
           c.cellSize = new Vector2(170.000000f, 40.000000f);
           c.spacing = new Vector2(8.000000f, 0.000000f);
           c.childAlignment = (TextAnchor)5;
        }
        { var c = goMap[-685186880043692449L].AddComponent<Image>();
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
        { var c = goMap[8411064718115362268L].AddComponent<Text>();
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
        { var c = goMap[4537409364233245584L].AddComponent<Image>();
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
        { var c = goMap[-8099691358505882177L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-8099691358505882177L].AddComponent<UIScalePulse>();
           c.upScale = 1.100000f; c.duration = 0.100000f; c.scaleUp = true;
           c.enabled = true;
        }
        { var c = goMap[-8099691358505882177L].AddComponent<Image>();
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
        { var c = goMap[4367075698168847682L].AddComponent<Image>();
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
        { var c = goMap[-8380796256678767058L].AddComponent<Image>();
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
        { var c = goMap[-5706410927349647651L].AddComponent<Text>();
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
        { var c = goMap[8699900415256598228L].AddComponent<Image>();
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
        { var c = goMap[2012651930417467783L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[2012651930417467783L].AddComponent<UIScalePulse>();
           c.upScale = 1.100000f; c.duration = 0.100000f; c.scaleUp = true;
           c.enabled = true;
        }
        { var c = goMap[2012651930417467783L].AddComponent<Image>();
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
        { var c = goMap[2027100172096224126L].AddComponent<Image>();
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
        { var c = goMap[2655795610957533070L].AddComponent<Image>();
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
        { var c = goMap[3244165922332707993L].AddComponent<Text>();
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
        { var c = goMap[1709750185729026993L].AddComponent<Image>();
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
        { var c = goMap[-5823306048871318281L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-5823306048871318281L].AddComponent<UIScalePulse>();
           c.upScale = 1.100000f; c.duration = 0.100000f; c.scaleUp = true;
           c.enabled = true;
        }
        { var c = goMap[-5823306048871318281L].AddComponent<Image>();
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
        { var c = goMap[9142746292198219509L].AddComponent<Image>();
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
        { var c = goMap[-3569606862743835244L].AddComponent<Image>();
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
        { var c = goMap[3080816573675997141L].AddComponent<Text>();
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
        { var c = goMap[-1572542169620759234L].AddComponent<Image>();
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
        { var c = goMap[6344949757999971202L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[6344949757999971202L].AddComponent<UIScalePulse>();
           c.upScale = 1.100000f; c.duration = 0.100000f; c.scaleUp = true;
           c.enabled = true;
        }
        { var c = goMap[6344949757999971202L].AddComponent<Image>();
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
        { var c = goMap[1714527679141761683L].AddComponent<Image>();
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
        { var c = goMap[-9061946888654598661L].AddComponent<Text>();
           c.text = "1855";
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
        { var c = goMap[1517114853165202446L].AddComponent<Image>();
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
           c.sprite = LookupSprite("btn_close_special");
        }
        { var c = goMap[1517114853165202446L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[1517114853165202446L].AddComponent<UIScalePulse>();
           c.upScale = 0.950000f; c.duration = 0.100000f; c.scaleUp = false;
           c.enabled = true;
        }
        { var c = goMap[1517114853165202446L].AddComponent<CanvasGroup>();
           c.alpha = 1.000000f;
           c.interactable = true;
           c.blocksRaycasts = true;
           c.ignoreParentGroups = false;
        }
        { var c = goMap[-3398803665771306097L].AddComponent<Image>();
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
        { var c = goMap[-9132697027396470047L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(0.772549f, 0.709804f, 0.019608f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Bold;
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
        { var c = goMap[-1804719081436846616L].AddComponent<Image>();
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
        { var c = goMap[-1804719081436846616L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-1804719081436846616L].AddComponent<UIScalePulse>();
           c.upScale = 0.950000f; c.duration = 0.100000f; c.scaleUp = false;
           c.enabled = true;
        }
        { var c = goMap[4769563380497257903L].AddComponent<Text>();
           c.text = "17034";
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
        { var c = goMap[4769563380497257903L].AddComponent<Shadow>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[191905735053379250L].AddComponent<Image>();
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
        { var c = goMap[-1339233964520797925L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(0.772549f, 0.709804f, 0.019608f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Bold;
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
        { var c = goMap[212083927804020650L].AddComponent<Image>();
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
           c.sprite = LookupSprite("btn_common1_3");
        }
        { var c = goMap[212083927804020650L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[212083927804020650L].AddComponent<UIScalePulse>();
           c.upScale = 0.950000f; c.duration = 0.100000f; c.scaleUp = false;
           c.enabled = true;
        }
        { var c = goMap[-5002949637649751806L].AddComponent<Text>();
           c.text = "17033";
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
        { var c = goMap[-5002949637649751806L].AddComponent<Shadow>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[5261215109483293296L].AddComponent<Text>();
           c.text = "13809";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 20;
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
        { var c = goMap[5261215109483293296L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
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
        var rootGO = goMap[-7561915101673553132L];
        string path = "Assets/Prefabs/Imported/UISkillBookPicking.prefab";
        PrefabUtility.SaveAsPrefabAsset(rootGO, path);
        Object.DestroyImmediate(rootGO);
        Debug.Log("[Import_res_p_200] Saved " + path);
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