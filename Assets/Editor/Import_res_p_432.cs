// AUTO-GENERATED from res_p_432.ab — DO NOT EDIT MANUALLY.
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;
using System.Collections.Generic;
using KTO.Game;  // UIJoyStick and other ported KTO scripts

public class Import_res_p_432
{
    [MenuItem("KTO/Import/res_p_432")]
    public static void Build()
    {
        Debug.Log("[Import_res_p_432] Building UISkillBookPickingNew...");

        // ─── Create all GameObjects ───────────────────────────
        var goMap = new Dictionary<long, GameObject>();
        var _toggleGroupByMbPid = new Dictionary<long, ToggleGroup>();
        var _toggleGroupLinks = new List<System.Tuple<Toggle,long>>();
        { var go = new GameObject("UISkillBookPickingNew"); go.SetActive(true); goMap[4819335448985046053L] = go; }
        { var go = new GameObject("node"); go.SetActive(true); goMap[-4009740617851856979L] = go; }
        { var go = new GameObject("imgBG"); go.SetActive(true); goMap[-8174799108336178379L] = go; }
        { var go = new GameObject("bg"); go.SetActive(true); goMap[-9151620475021393516L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(true); goMap[4876639976599978901L] = go; }
        { var go = new GameObject("Dot"); go.SetActive(true); goMap[1892586625407494784L] = go; }
        { var go = new GameObject("Moon"); go.SetActive(true); goMap[-1503355689707737232L] = go; }
        { var go = new GameObject("CardPickingTree"); go.SetActive(true); goMap[-9115555122256397782L] = go; }
        { var go = new GameObject("Bone001"); go.SetActive(true); goMap[6596605432855132299L] = go; }
        { var go = new GameObject("Bone002"); go.SetActive(true); goMap[-265932086382302313L] = go; }
        { var go = new GameObject("Bone003"); go.SetActive(true); goMap[-7818819116382767634L] = go; }
        { var go = new GameObject("Bone004"); go.SetActive(true); goMap[-3161470476069263946L] = go; }
        { var go = new GameObject("Bone005"); go.SetActive(true); goMap[-2849929938536019601L] = go; }
        { var go = new GameObject("Bone006"); go.SetActive(true); goMap[-3370358032327666168L] = go; }
        { var go = new GameObject("Bone007"); go.SetActive(true); goMap[-2467986634443186230L] = go; }
        { var go = new GameObject("Bone008"); go.SetActive(true); goMap[-5613997916645109167L] = go; }
        { var go = new GameObject("Bone009"); go.SetActive(true); goMap[4754395154313488801L] = go; }
        { var go = new GameObject("Bone010"); go.SetActive(true); goMap[-3400540608839409635L] = go; }
        { var go = new GameObject("Bone011"); go.SetActive(true); goMap[8121497878015917053L] = go; }
        { var go = new GameObject("Bone012"); go.SetActive(true); goMap[3661379932094169406L] = go; }
        { var go = new GameObject("Plane001"); go.SetActive(true); goMap[-4736267931167622526L] = go; }
        { var go = new GameObject("Plane002"); go.SetActive(true); goMap[109818613204221544L] = go; }
        { var go = new GameObject("House"); go.SetActive(true); goMap[-8936318331402761519L] = go; }
        { var go = new GameObject("Water"); go.SetActive(true); goMap[-1591030223787988054L] = go; }
        { var go = new GameObject("ShuiWen"); go.SetActive(true); goMap[-7495977913106730410L] = go; }
        { var go = new GameObject("ShuiBo001"); go.SetActive(true); goMap[-3510610541380237278L] = go; }
        { var go = new GameObject("ShuiBo002"); go.SetActive(true); goMap[9111669115138538998L] = go; }
        { var go = new GameObject("txtTitle"); go.SetActive(true); goMap[2834392888039573256L] = go; }
        { var go = new GameObject("btnHelp"); go.SetActive(true); goMap[8852437334595616062L] = go; }
        { var go = new GameObject("Content"); go.SetActive(true); goMap[-5380319781391671054L] = go; }
        { var go = new GameObject("ImgBG01"); go.SetActive(true); goMap[7970867397367519496L] = go; }
        { var go = new GameObject("StarGroup"); go.SetActive(true); goMap[6742190131932243580L] = go; }
        { var go = new GameObject("Stone"); go.SetActive(true); goMap[7387779843775975856L] = go; }
        { var go = new GameObject("Stone11"); go.SetActive(true); goMap[-6759574980915932396L] = go; }
        { var go = new GameObject("Stone01"); go.SetActive(true); goMap[-5731550630456769182L] = go; }
        { var go = new GameObject("Stone02"); go.SetActive(true); goMap[2188390708554993707L] = go; }
        { var go = new GameObject("Stone03"); go.SetActive(true); goMap[-6592110375637805327L] = go; }
        { var go = new GameObject("Stone04"); go.SetActive(true); goMap[6870609025290668291L] = go; }
        { var go = new GameObject("Stone05"); go.SetActive(true); goMap[-2676376668016231640L] = go; }
        { var go = new GameObject("Stone06"); go.SetActive(true); goMap[4424472383744146493L] = go; }
        { var go = new GameObject("Stone07"); go.SetActive(true); goMap[-6189851091565826385L] = go; }
        { var go = new GameObject("Stone08"); go.SetActive(true); goMap[-2605723084892628197L] = go; }
        { var go = new GameObject("Stone09"); go.SetActive(true); goMap[477001982891309104L] = go; }
        { var go = new GameObject("Stone10"); go.SetActive(true); goMap[-5707384806701844166L] = go; }
        { var go = new GameObject("Stone12"); go.SetActive(true); goMap[3945488021599877140L] = go; }
        { var go = new GameObject("FuWen"); go.SetActive(true); goMap[-1291141195669593967L] = go; }
        { var go = new GameObject("02"); go.SetActive(true); goMap[774815550174164945L] = go; }
        { var go = new GameObject("03"); go.SetActive(true); goMap[-4513997910400335741L] = go; }
        { var go = new GameObject("04"); go.SetActive(true); goMap[-8923759541003661355L] = go; }
        { var go = new GameObject("05"); go.SetActive(true); goMap[-8530091813134288047L] = go; }
        { var go = new GameObject("06"); go.SetActive(true); goMap[-4284899629221323854L] = go; }
        { var go = new GameObject("07"); go.SetActive(true); goMap[7164904240449843560L] = go; }
        { var go = new GameObject("08"); go.SetActive(true); goMap[4013184310230766431L] = go; }
        { var go = new GameObject("JueSeGlow"); go.SetActive(true); goMap[-5137377339727836689L] = go; }
        { var go = new GameObject("DiZuo"); go.SetActive(true); goMap[-6074657908179465672L] = go; }
        { var go = new GameObject("juese"); go.SetActive(true); goMap[5727666512096771818L] = go; }
        { var go = new GameObject("Bone001"); go.SetActive(true); goMap[3801091915196387421L] = go; }
        { var go = new GameObject("Bone002"); go.SetActive(true); goMap[-3101191484808222162L] = go; }
        { var go = new GameObject("Bone003"); go.SetActive(true); goMap[-151234646242951174L] = go; }
        { var go = new GameObject("Bone004"); go.SetActive(true); goMap[9088946265072814616L] = go; }
        { var go = new GameObject("Bone005"); go.SetActive(true); goMap[3538031027046802191L] = go; }
        { var go = new GameObject("Bone006"); go.SetActive(true); goMap[-7364674248588144072L] = go; }
        { var go = new GameObject("Bone007"); go.SetActive(true); goMap[6760686035486704010L] = go; }
        { var go = new GameObject("Bone014"); go.SetActive(true); goMap[-5867283431694614035L] = go; }
        { var go = new GameObject("Bone015"); go.SetActive(true); goMap[-8215869316136973220L] = go; }
        { var go = new GameObject("Bone016"); go.SetActive(true); goMap[-7306885631385740653L] = go; }
        { var go = new GameObject("Bone017"); go.SetActive(true); goMap[5931669881912078695L] = go; }
        { var go = new GameObject("Bone018"); go.SetActive(true); goMap[-7940461102502173085L] = go; }
        { var go = new GameObject("Bone019"); go.SetActive(true); goMap[-5414680607054875358L] = go; }
        { var go = new GameObject("Bone020"); go.SetActive(true); goMap[-25692501790973817L] = go; }
        { var go = new GameObject("Bone021"); go.SetActive(true); goMap[-3661772995496832957L] = go; }
        { var go = new GameObject("Bone022"); go.SetActive(true); goMap[-6437626548250769371L] = go; }
        { var go = new GameObject("Bone023"); go.SetActive(true); goMap[5850376620303838029L] = go; }
        { var go = new GameObject("Bone024"); go.SetActive(true); goMap[3904957174222550374L] = go; }
        { var go = new GameObject("Bone008"); go.SetActive(true); goMap[-1438890078565682559L] = go; }
        { var go = new GameObject("Bone009"); go.SetActive(true); goMap[2998092026943182634L] = go; }
        { var go = new GameObject("Bone010"); go.SetActive(true); goMap[2777016730837888597L] = go; }
        { var go = new GameObject("Bone011"); go.SetActive(true); goMap[7948551588702137392L] = go; }
        { var go = new GameObject("Bone012"); go.SetActive(true); goMap[-3580177050737868558L] = go; }
        { var go = new GameObject("Bone013"); go.SetActive(true); goMap[-7849652771754901917L] = go; }
        { var go = new GameObject("Bone025"); go.SetActive(true); goMap[9199157610969502835L] = go; }
        { var go = new GameObject("Bone026"); go.SetActive(true); goMap[-2400206227909238157L] = go; }
        { var go = new GameObject("Bone027"); go.SetActive(true); goMap[6616683905155944933L] = go; }
        { var go = new GameObject("Bone028"); go.SetActive(true); goMap[-4821087009452372916L] = go; }
        { var go = new GameObject("Bone029"); go.SetActive(true); goMap[1038203626900272379L] = go; }
        { var go = new GameObject("Bone030"); go.SetActive(true); goMap[7484280456437663810L] = go; }
        { var go = new GameObject("Bone031"); go.SetActive(true); goMap[-5372993916798666626L] = go; }
        { var go = new GameObject("Bone032"); go.SetActive(true); goMap[-1856715320221852965L] = go; }
        { var go = new GameObject("Bone033"); go.SetActive(true); goMap[-7161578253672427101L] = go; }
        { var go = new GameObject("Bone034"); go.SetActive(true); goMap[-1913076889511643331L] = go; }
        { var go = new GameObject("Bone035"); go.SetActive(true); goMap[669672048080437467L] = go; }
        { var go = new GameObject("Bone036"); go.SetActive(true); goMap[-3851824815086883579L] = go; }
        { var go = new GameObject("Plane001"); go.SetActive(true); goMap[9003179102678087746L] = go; }
        { var go = new GameObject("Plane002"); go.SetActive(true); goMap[-8555836985938532706L] = go; }
        { var go = new GameObject("Plane003"); go.SetActive(true); goMap[-8057124363402508216L] = go; }
        { var go = new GameObject("Tui"); go.SetActive(true); goMap[5444594966465973322L] = go; }
        { var go = new GameObject("DaoYing"); go.SetActive(true); goMap[-7578610513728695982L] = go; }
        { var go = new GameObject("TouYinLight"); go.SetActive(true); goMap[8752633661201647517L] = go; }
        { var go = new GameObject("BgGlow"); go.SetActive(true); goMap[3995448807955063930L] = go; }
        { var go = new GameObject("Glow_Effect"); go.SetActive(true); goMap[3242399999460821893L] = go; }
        { var go = new GameObject("Glow01"); go.SetActive(true); goMap[-6752815307683922378L] = go; }
        { var go = new GameObject("Glow02"); go.SetActive(true); goMap[8805448058483966012L] = go; }
        { var go = new GameObject("CneterGlow"); go.SetActive(true); goMap[-4007633394725432196L] = go; }
        { var go = new GameObject("Dot"); go.SetActive(true); goMap[-7282599408271715796L] = go; }
        { var go = new GameObject("NengLiang"); go.SetActive(true); goMap[7797905765695626947L] = go; }
        { var go = new GameObject("GuangHuan"); go.SetActive(true); goMap[2184598130986927044L] = go; }
        { var go = new GameObject("DotLine"); go.SetActive(true); goMap[1807315397694397354L] = go; }
        { var go = new GameObject("ZhaoMuEffect"); go.SetActive(false); goMap[-3606545693049957187L] = go; }
        { var go = new GameObject("CneterGlow01"); go.SetActive(true); goMap[382484804367401699L] = go; }
        { var go = new GameObject("CneterGlow02"); go.SetActive(true); goMap[6679511227897196168L] = go; }
        { var go = new GameObject("Dot"); go.SetActive(true); goMap[-2905933428464315081L] = go; }
        { var go = new GameObject("DotLine"); go.SetActive(true); goMap[-3329878931021310428L] = go; }
        { var go = new GameObject("Tail"); go.SetActive(true); goMap[-3502103925725581644L] = go; }
        { var go = new GameObject("Tail02"); go.SetActive(true); goMap[-7394679089984868651L] = go; }
        { var go = new GameObject("Tail03"); go.SetActive(true); goMap[-3564783400013696194L] = go; }
        { var go = new GameObject("Tail04"); go.SetActive(true); goMap[-2726897064287536982L] = go; }
        { var go = new GameObject("Tail05"); go.SetActive(true); goMap[-5839280060843895280L] = go; }
        { var go = new GameObject("InsideGlow"); go.SetActive(true); goMap[7100771624195794294L] = go; }
        { var go = new GameObject("BaoFa"); go.SetActive(true); goMap[2287665600948638742L] = go; }
        { var go = new GameObject("M7"); go.SetActive(true); goMap[-6789061741882370038L] = go; }
        { var go = new GameObject("M1"); go.SetActive(true); goMap[-3145258825231270044L] = go; }
        { var go = new GameObject("M2"); go.SetActive(true); goMap[4516438064648789164L] = go; }
        { var go = new GameObject("M3_1"); go.SetActive(true); goMap[-6078846900455966702L] = go; }
        { var go = new GameObject("M8"); go.SetActive(true); goMap[7597048143449509386L] = go; }
        { var go = new GameObject("M9"); go.SetActive(true); goMap[-7593688028729526073L] = go; }
        { var go = new GameObject("M10"); go.SetActive(true); goMap[-408354883861899060L] = go; }
        { var go = new GameObject("M11"); go.SetActive(true); goMap[-7522118983075025686L] = go; }
        { var go = new GameObject("M12"); go.SetActive(true); goMap[-9119202032137928376L] = go; }
        { var go = new GameObject("BgGlow"); go.SetActive(true); goMap[-933107128965746130L] = go; }
        { var go = new GameObject("Inside"); go.SetActive(true); goMap[-6381627880408306472L] = go; }
        { var go = new GameObject("Loop"); go.SetActive(true); goMap[8551861957485517136L] = go; }
        { var go = new GameObject("GlowLine"); go.SetActive(true); goMap[-1902797993300054173L] = go; }
        { var go = new GameObject("imgBG"); go.SetActive(true); goMap[-6153628543227417074L] = go; }
        { var go = new GameObject("txtTitle"); go.SetActive(false); goMap[5252642059354391742L] = go; }
        { var go = new GameObject("btnClose"); go.SetActive(true); goMap[-211957413662482855L] = go; }
        { var go = new GameObject("Content"); go.SetActive(true); goMap[1561941930045693554L] = go; }
        { var go = new GameObject("imgCostBg"); go.SetActive(true); goMap[-3901944275606859404L] = go; }
        { var go = new GameObject("IconTenPick"); go.SetActive(true); goMap[1978926375919820888L] = go; }
        { var go = new GameObject("txtTenPickValue"); go.SetActive(true); goMap[-7098503441982965008L] = go; }
        { var go = new GameObject("btnTenPick"); go.SetActive(true); goMap[7135430627738913241L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-4496826088188936620L] = go; }
        { var go = new GameObject("IconPick"); go.SetActive(true); goMap[3105518807093882871L] = go; }
        { var go = new GameObject("txtPickValue"); go.SetActive(true); goMap[-2819388067459691541L] = go; }
        { var go = new GameObject("btnPick"); go.SetActive(true); goMap[1669872368941248673L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-4179266455452556974L] = go; }
        { var go = new GameObject("txtTips"); go.SetActive(true); goMap[-7453174105810813141L] = go; }
        { var go = new GameObject("UIMoneyPanel000"); go.SetActive(false); goMap[-3481751320980515111L] = go; }
        { var go = new GameObject("panelList"); go.SetActive(true); goMap[-6039891053796283742L] = go; }
        { var go = new GameObject("panelDynamic"); go.SetActive(false); goMap[2115900198056767718L] = go; }
        { var go = new GameObject("BgDynamic"); go.SetActive(true); goMap[5252582076376554681L] = go; }
        { var go = new GameObject("txtDynamic"); go.SetActive(true); goMap[5833663767682686097L] = go; }
        { var go = new GameObject("imgDynamic"); go.SetActive(true); goMap[4498117995788496094L] = go; }
        { var go = new GameObject("btnPlusDynamic"); go.SetActive(true); goMap[-1360394101204846089L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[5158759203904459366L] = go; }
        { var go = new GameObject("panelCoin"); go.SetActive(true); goMap[-6069233594518704085L] = go; }
        { var go = new GameObject("BgCoin"); go.SetActive(true); goMap[-3197927011868807317L] = go; }
        { var go = new GameObject("txtCoinValue"); go.SetActive(true); goMap[-1258867156500752294L] = go; }
        { var go = new GameObject("imgCoin"); go.SetActive(true); goMap[-5576995668172751362L] = go; }
        { var go = new GameObject("btnPlusCoin"); go.SetActive(true); goMap[7821647098668844939L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[6686506202834080604L] = go; }
        { var go = new GameObject("panelYuanBao"); go.SetActive(true); goMap[-3801218635263175337L] = go; }
        { var go = new GameObject("BgYuanBao"); go.SetActive(true); goMap[7563170486094614631L] = go; }
        { var go = new GameObject("txtYuanBaoValue"); go.SetActive(true); goMap[5649588123910234908L] = go; }
        { var go = new GameObject("imgYuanBao"); go.SetActive(true); goMap[1225239543510754234L] = go; }
        { var go = new GameObject("btnPlusYuanBao"); go.SetActive(true); goMap[-2986304683960228138L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[637470501273205855L] = go; }
        { var go = new GameObject("panelGold"); go.SetActive(true); goMap[-4125570003964329536L] = go; }
        { var go = new GameObject("BgGold"); go.SetActive(true); goMap[5287424476567467287L] = go; }
        { var go = new GameObject("txtGoldValue"); go.SetActive(true); goMap[2947540931266190570L] = go; }
        { var go = new GameObject("imgGold"); go.SetActive(true); goMap[-1475367650970447587L] = go; }
        { var go = new GameObject("btnPlusGold"); go.SetActive(true); goMap[-5891180512872814050L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[1518337924155512096L] = go; }
        { var go = new GameObject("UIMoneyPanel"); go.SetActive(true); goMap[-5470516685279597304L] = go; }
        { var go = new GameObject("panelList"); go.SetActive(true); goMap[1963229782784186703L] = go; }
        { var go = new GameObject("panelDynamic"); go.SetActive(false); goMap[4738809532108798243L] = go; }
        { var go = new GameObject("BgDynamic"); go.SetActive(true); goMap[-1349906807189058108L] = go; }
        { var go = new GameObject("txtDynamic"); go.SetActive(true); goMap[-8490753408518963357L] = go; }
        { var go = new GameObject("imgDynamic"); go.SetActive(true); goMap[-5332259170841068989L] = go; }
        { var go = new GameObject("btnPlusDynamic"); go.SetActive(true); goMap[-1005047536695220358L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[282133458021753375L] = go; }
        { var go = new GameObject("panelCoin"); go.SetActive(true); goMap[-3769662730719947932L] = go; }
        { var go = new GameObject("BgCoin"); go.SetActive(true); goMap[4086984118314974064L] = go; }
        { var go = new GameObject("txtCoinValue"); go.SetActive(true); goMap[-4929854311498320183L] = go; }
        { var go = new GameObject("imgCoin"); go.SetActive(true); goMap[8859664096502209178L] = go; }
        { var go = new GameObject("btnPlusCoin"); go.SetActive(true); goMap[3626295187002482928L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[-3859571403933658986L] = go; }
        { var go = new GameObject("panelYuanBao"); go.SetActive(true); goMap[2893754803441222203L] = go; }
        { var go = new GameObject("BgYuanBao"); go.SetActive(true); goMap[342512212035237246L] = go; }
        { var go = new GameObject("txtYuanBaoValue"); go.SetActive(true); goMap[-3490818806212525058L] = go; }
        { var go = new GameObject("imgYuanBao"); go.SetActive(true); goMap[7875392811810505008L] = go; }
        { var go = new GameObject("btnPlusYuanBao"); go.SetActive(true); goMap[4783548646248206586L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[3545101595527939407L] = go; }
        { var go = new GameObject("panelGold"); go.SetActive(true); goMap[8939267422253780043L] = go; }
        { var go = new GameObject("BgGold"); go.SetActive(true); goMap[-6818114889825714276L] = go; }
        { var go = new GameObject("txtGoldValue"); go.SetActive(true); goMap[-8852044364166502203L] = go; }
        { var go = new GameObject("imgGold"); go.SetActive(true); goMap[-4173716544426695569L] = go; }
        { var go = new GameObject("btnPlusGold"); go.SetActive(true); goMap[-2367827872379986103L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[-114094213477513418L] = go; }

        // ─── Parent links ─────────────────────────────────────
        goMap[-4009740617851856979L].transform.SetParent(goMap[4819335448985046053L].transform, false);
        goMap[-8174799108336178379L].transform.SetParent(goMap[-4009740617851856979L].transform, false);
        goMap[-9151620475021393516L].transform.SetParent(goMap[-8174799108336178379L].transform, false);
        goMap[4876639976599978901L].transform.SetParent(goMap[-9151620475021393516L].transform, false);
        goMap[1892586625407494784L].transform.SetParent(goMap[4876639976599978901L].transform, false);
        goMap[-1503355689707737232L].transform.SetParent(goMap[4876639976599978901L].transform, false);
        goMap[-9115555122256397782L].transform.SetParent(goMap[4876639976599978901L].transform, false);
        goMap[6596605432855132299L].transform.SetParent(goMap[-9115555122256397782L].transform, false);
        goMap[-265932086382302313L].transform.SetParent(goMap[6596605432855132299L].transform, false);
        goMap[-7818819116382767634L].transform.SetParent(goMap[-265932086382302313L].transform, false);
        goMap[-3161470476069263946L].transform.SetParent(goMap[-7818819116382767634L].transform, false);
        goMap[-2849929938536019601L].transform.SetParent(goMap[-3161470476069263946L].transform, false);
        goMap[-3370358032327666168L].transform.SetParent(goMap[-2849929938536019601L].transform, false);
        goMap[-2467986634443186230L].transform.SetParent(goMap[-9115555122256397782L].transform, false);
        goMap[-5613997916645109167L].transform.SetParent(goMap[-2467986634443186230L].transform, false);
        goMap[4754395154313488801L].transform.SetParent(goMap[-5613997916645109167L].transform, false);
        goMap[-3400540608839409635L].transform.SetParent(goMap[4754395154313488801L].transform, false);
        goMap[8121497878015917053L].transform.SetParent(goMap[-3400540608839409635L].transform, false);
        goMap[3661379932094169406L].transform.SetParent(goMap[8121497878015917053L].transform, false);
        goMap[-4736267931167622526L].transform.SetParent(goMap[-9115555122256397782L].transform, false);
        goMap[109818613204221544L].transform.SetParent(goMap[-9115555122256397782L].transform, false);
        goMap[-8936318331402761519L].transform.SetParent(goMap[4876639976599978901L].transform, false);
        goMap[-1591030223787988054L].transform.SetParent(goMap[4876639976599978901L].transform, false);
        goMap[-7495977913106730410L].transform.SetParent(goMap[-1591030223787988054L].transform, false);
        goMap[-3510610541380237278L].transform.SetParent(goMap[-1591030223787988054L].transform, false);
        goMap[9111669115138538998L].transform.SetParent(goMap[-1591030223787988054L].transform, false);
        goMap[2834392888039573256L].transform.SetParent(goMap[-8174799108336178379L].transform, false);
        goMap[8852437334595616062L].transform.SetParent(goMap[2834392888039573256L].transform, false);
        goMap[-5380319781391671054L].transform.SetParent(goMap[-8174799108336178379L].transform, false);
        goMap[7970867397367519496L].transform.SetParent(goMap[-5380319781391671054L].transform, false);
        goMap[6742190131932243580L].transform.SetParent(goMap[7970867397367519496L].transform, false);
        goMap[7387779843775975856L].transform.SetParent(goMap[7970867397367519496L].transform, false);
        goMap[-6759574980915932396L].transform.SetParent(goMap[7387779843775975856L].transform, false);
        goMap[-5731550630456769182L].transform.SetParent(goMap[7387779843775975856L].transform, false);
        goMap[2188390708554993707L].transform.SetParent(goMap[7387779843775975856L].transform, false);
        goMap[-6592110375637805327L].transform.SetParent(goMap[7387779843775975856L].transform, false);
        goMap[6870609025290668291L].transform.SetParent(goMap[7387779843775975856L].transform, false);
        goMap[-2676376668016231640L].transform.SetParent(goMap[7387779843775975856L].transform, false);
        goMap[4424472383744146493L].transform.SetParent(goMap[7387779843775975856L].transform, false);
        goMap[-6189851091565826385L].transform.SetParent(goMap[7387779843775975856L].transform, false);
        goMap[-2605723084892628197L].transform.SetParent(goMap[7387779843775975856L].transform, false);
        goMap[477001982891309104L].transform.SetParent(goMap[7387779843775975856L].transform, false);
        goMap[-5707384806701844166L].transform.SetParent(goMap[7387779843775975856L].transform, false);
        goMap[3945488021599877140L].transform.SetParent(goMap[7387779843775975856L].transform, false);
        goMap[-1291141195669593967L].transform.SetParent(goMap[7970867397367519496L].transform, false);
        goMap[774815550174164945L].transform.SetParent(goMap[-1291141195669593967L].transform, false);
        goMap[-4513997910400335741L].transform.SetParent(goMap[-1291141195669593967L].transform, false);
        goMap[-8923759541003661355L].transform.SetParent(goMap[-1291141195669593967L].transform, false);
        goMap[-8530091813134288047L].transform.SetParent(goMap[-1291141195669593967L].transform, false);
        goMap[-4284899629221323854L].transform.SetParent(goMap[-1291141195669593967L].transform, false);
        goMap[7164904240449843560L].transform.SetParent(goMap[-1291141195669593967L].transform, false);
        goMap[4013184310230766431L].transform.SetParent(goMap[-1291141195669593967L].transform, false);
        goMap[-5137377339727836689L].transform.SetParent(goMap[7970867397367519496L].transform, false);
        goMap[-6074657908179465672L].transform.SetParent(goMap[7970867397367519496L].transform, false);
        goMap[5727666512096771818L].transform.SetParent(goMap[7970867397367519496L].transform, false);
        goMap[3801091915196387421L].transform.SetParent(goMap[5727666512096771818L].transform, false);
        goMap[-3101191484808222162L].transform.SetParent(goMap[3801091915196387421L].transform, false);
        goMap[-151234646242951174L].transform.SetParent(goMap[-3101191484808222162L].transform, false);
        goMap[9088946265072814616L].transform.SetParent(goMap[-151234646242951174L].transform, false);
        goMap[3538031027046802191L].transform.SetParent(goMap[9088946265072814616L].transform, false);
        goMap[-7364674248588144072L].transform.SetParent(goMap[3538031027046802191L].transform, false);
        goMap[6760686035486704010L].transform.SetParent(goMap[-7364674248588144072L].transform, false);
        goMap[-5867283431694614035L].transform.SetParent(goMap[-3101191484808222162L].transform, false);
        goMap[-8215869316136973220L].transform.SetParent(goMap[-5867283431694614035L].transform, false);
        goMap[-7306885631385740653L].transform.SetParent(goMap[-8215869316136973220L].transform, false);
        goMap[5931669881912078695L].transform.SetParent(goMap[-7306885631385740653L].transform, false);
        goMap[-7940461102502173085L].transform.SetParent(goMap[5931669881912078695L].transform, false);
        goMap[-5414680607054875358L].transform.SetParent(goMap[-7940461102502173085L].transform, false);
        goMap[-25692501790973817L].transform.SetParent(goMap[-5414680607054875358L].transform, false);
        goMap[-3661772995496832957L].transform.SetParent(goMap[-25692501790973817L].transform, false);
        goMap[-6437626548250769371L].transform.SetParent(goMap[-3661772995496832957L].transform, false);
        goMap[5850376620303838029L].transform.SetParent(goMap[-6437626548250769371L].transform, false);
        goMap[3904957174222550374L].transform.SetParent(goMap[5850376620303838029L].transform, false);
        goMap[-1438890078565682559L].transform.SetParent(goMap[3801091915196387421L].transform, false);
        goMap[2998092026943182634L].transform.SetParent(goMap[-1438890078565682559L].transform, false);
        goMap[2777016730837888597L].transform.SetParent(goMap[2998092026943182634L].transform, false);
        goMap[7948551588702137392L].transform.SetParent(goMap[2777016730837888597L].transform, false);
        goMap[-3580177050737868558L].transform.SetParent(goMap[7948551588702137392L].transform, false);
        goMap[-7849652771754901917L].transform.SetParent(goMap[-3580177050737868558L].transform, false);
        goMap[9199157610969502835L].transform.SetParent(goMap[-1438890078565682559L].transform, false);
        goMap[-2400206227909238157L].transform.SetParent(goMap[9199157610969502835L].transform, false);
        goMap[6616683905155944933L].transform.SetParent(goMap[-2400206227909238157L].transform, false);
        goMap[-4821087009452372916L].transform.SetParent(goMap[6616683905155944933L].transform, false);
        goMap[1038203626900272379L].transform.SetParent(goMap[-4821087009452372916L].transform, false);
        goMap[7484280456437663810L].transform.SetParent(goMap[1038203626900272379L].transform, false);
        goMap[-5372993916798666626L].transform.SetParent(goMap[7484280456437663810L].transform, false);
        goMap[-1856715320221852965L].transform.SetParent(goMap[-5372993916798666626L].transform, false);
        goMap[-7161578253672427101L].transform.SetParent(goMap[-1856715320221852965L].transform, false);
        goMap[-1913076889511643331L].transform.SetParent(goMap[-7161578253672427101L].transform, false);
        goMap[669672048080437467L].transform.SetParent(goMap[-1913076889511643331L].transform, false);
        goMap[-3851824815086883579L].transform.SetParent(goMap[669672048080437467L].transform, false);
        goMap[9003179102678087746L].transform.SetParent(goMap[5727666512096771818L].transform, false);
        goMap[-8555836985938532706L].transform.SetParent(goMap[5727666512096771818L].transform, false);
        goMap[-8057124363402508216L].transform.SetParent(goMap[5727666512096771818L].transform, false);
        goMap[5444594966465973322L].transform.SetParent(goMap[5727666512096771818L].transform, false);
        goMap[-7578610513728695982L].transform.SetParent(goMap[7970867397367519496L].transform, false);
        goMap[8752633661201647517L].transform.SetParent(goMap[7970867397367519496L].transform, false);
        goMap[3995448807955063930L].transform.SetParent(goMap[7970867397367519496L].transform, false);
        goMap[3242399999460821893L].transform.SetParent(goMap[7970867397367519496L].transform, false);
        goMap[-6752815307683922378L].transform.SetParent(goMap[3242399999460821893L].transform, false);
        goMap[8805448058483966012L].transform.SetParent(goMap[3242399999460821893L].transform, false);
        goMap[-4007633394725432196L].transform.SetParent(goMap[3242399999460821893L].transform, false);
        goMap[-7282599408271715796L].transform.SetParent(goMap[3242399999460821893L].transform, false);
        goMap[7797905765695626947L].transform.SetParent(goMap[3242399999460821893L].transform, false);
        goMap[2184598130986927044L].transform.SetParent(goMap[3242399999460821893L].transform, false);
        goMap[1807315397694397354L].transform.SetParent(goMap[3242399999460821893L].transform, false);
        goMap[-3606545693049957187L].transform.SetParent(goMap[3242399999460821893L].transform, false);
        goMap[382484804367401699L].transform.SetParent(goMap[-3606545693049957187L].transform, false);
        goMap[6679511227897196168L].transform.SetParent(goMap[-3606545693049957187L].transform, false);
        goMap[-2905933428464315081L].transform.SetParent(goMap[-3606545693049957187L].transform, false);
        goMap[-3329878931021310428L].transform.SetParent(goMap[-3606545693049957187L].transform, false);
        goMap[-3502103925725581644L].transform.SetParent(goMap[-3606545693049957187L].transform, false);
        goMap[-7394679089984868651L].transform.SetParent(goMap[-3606545693049957187L].transform, false);
        goMap[-3564783400013696194L].transform.SetParent(goMap[-3606545693049957187L].transform, false);
        goMap[-2726897064287536982L].transform.SetParent(goMap[-3606545693049957187L].transform, false);
        goMap[-5839280060843895280L].transform.SetParent(goMap[-3606545693049957187L].transform, false);
        goMap[7100771624195794294L].transform.SetParent(goMap[-3606545693049957187L].transform, false);
        goMap[2287665600948638742L].transform.SetParent(goMap[-3606545693049957187L].transform, false);
        goMap[-6789061741882370038L].transform.SetParent(goMap[2287665600948638742L].transform, false);
        goMap[-3145258825231270044L].transform.SetParent(goMap[2287665600948638742L].transform, false);
        goMap[4516438064648789164L].transform.SetParent(goMap[2287665600948638742L].transform, false);
        goMap[-6078846900455966702L].transform.SetParent(goMap[2287665600948638742L].transform, false);
        goMap[7597048143449509386L].transform.SetParent(goMap[2287665600948638742L].transform, false);
        goMap[-7593688028729526073L].transform.SetParent(goMap[2287665600948638742L].transform, false);
        goMap[-408354883861899060L].transform.SetParent(goMap[2287665600948638742L].transform, false);
        goMap[-7522118983075025686L].transform.SetParent(goMap[2287665600948638742L].transform, false);
        goMap[-9119202032137928376L].transform.SetParent(goMap[2287665600948638742L].transform, false);
        goMap[-933107128965746130L].transform.SetParent(goMap[-3606545693049957187L].transform, false);
        goMap[-6381627880408306472L].transform.SetParent(goMap[-3606545693049957187L].transform, false);
        goMap[8551861957485517136L].transform.SetParent(goMap[-3606545693049957187L].transform, false);
        goMap[-1902797993300054173L].transform.SetParent(goMap[-3606545693049957187L].transform, false);
        goMap[-6153628543227417074L].transform.SetParent(goMap[-5380319781391671054L].transform, false);
        goMap[5252642059354391742L].transform.SetParent(goMap[-6153628543227417074L].transform, false);
        goMap[-211957413662482855L].transform.SetParent(goMap[-6153628543227417074L].transform, false);
        goMap[1561941930045693554L].transform.SetParent(goMap[-6153628543227417074L].transform, false);
        goMap[-3901944275606859404L].transform.SetParent(goMap[1561941930045693554L].transform, false);
        goMap[1978926375919820888L].transform.SetParent(goMap[1561941930045693554L].transform, false);
        goMap[-7098503441982965008L].transform.SetParent(goMap[1978926375919820888L].transform, false);
        goMap[7135430627738913241L].transform.SetParent(goMap[1561941930045693554L].transform, false);
        goMap[-4496826088188936620L].transform.SetParent(goMap[7135430627738913241L].transform, false);
        goMap[3105518807093882871L].transform.SetParent(goMap[1561941930045693554L].transform, false);
        goMap[-2819388067459691541L].transform.SetParent(goMap[3105518807093882871L].transform, false);
        goMap[1669872368941248673L].transform.SetParent(goMap[1561941930045693554L].transform, false);
        goMap[-4179266455452556974L].transform.SetParent(goMap[1669872368941248673L].transform, false);
        goMap[-7453174105810813141L].transform.SetParent(goMap[1561941930045693554L].transform, false);
        goMap[-3481751320980515111L].transform.SetParent(goMap[-4009740617851856979L].transform, false);
        goMap[-6039891053796283742L].transform.SetParent(goMap[-3481751320980515111L].transform, false);
        goMap[2115900198056767718L].transform.SetParent(goMap[-6039891053796283742L].transform, false);
        goMap[5252582076376554681L].transform.SetParent(goMap[2115900198056767718L].transform, false);
        goMap[5833663767682686097L].transform.SetParent(goMap[2115900198056767718L].transform, false);
        goMap[4498117995788496094L].transform.SetParent(goMap[2115900198056767718L].transform, false);
        goMap[-1360394101204846089L].transform.SetParent(goMap[2115900198056767718L].transform, false);
        goMap[5158759203904459366L].transform.SetParent(goMap[-1360394101204846089L].transform, false);
        goMap[-6069233594518704085L].transform.SetParent(goMap[-6039891053796283742L].transform, false);
        goMap[-3197927011868807317L].transform.SetParent(goMap[-6069233594518704085L].transform, false);
        goMap[-1258867156500752294L].transform.SetParent(goMap[-6069233594518704085L].transform, false);
        goMap[-5576995668172751362L].transform.SetParent(goMap[-6069233594518704085L].transform, false);
        goMap[7821647098668844939L].transform.SetParent(goMap[-6069233594518704085L].transform, false);
        goMap[6686506202834080604L].transform.SetParent(goMap[7821647098668844939L].transform, false);
        goMap[-3801218635263175337L].transform.SetParent(goMap[-6039891053796283742L].transform, false);
        goMap[7563170486094614631L].transform.SetParent(goMap[-3801218635263175337L].transform, false);
        goMap[5649588123910234908L].transform.SetParent(goMap[-3801218635263175337L].transform, false);
        goMap[1225239543510754234L].transform.SetParent(goMap[-3801218635263175337L].transform, false);
        goMap[-2986304683960228138L].transform.SetParent(goMap[-3801218635263175337L].transform, false);
        goMap[637470501273205855L].transform.SetParent(goMap[-2986304683960228138L].transform, false);
        goMap[-4125570003964329536L].transform.SetParent(goMap[-6039891053796283742L].transform, false);
        goMap[5287424476567467287L].transform.SetParent(goMap[-4125570003964329536L].transform, false);
        goMap[2947540931266190570L].transform.SetParent(goMap[-4125570003964329536L].transform, false);
        goMap[-1475367650970447587L].transform.SetParent(goMap[-4125570003964329536L].transform, false);
        goMap[-5891180512872814050L].transform.SetParent(goMap[-4125570003964329536L].transform, false);
        goMap[1518337924155512096L].transform.SetParent(goMap[-5891180512872814050L].transform, false);
        goMap[-5470516685279597304L].transform.SetParent(goMap[-4009740617851856979L].transform, false);
        goMap[1963229782784186703L].transform.SetParent(goMap[-5470516685279597304L].transform, false);
        goMap[4738809532108798243L].transform.SetParent(goMap[1963229782784186703L].transform, false);
        goMap[-1349906807189058108L].transform.SetParent(goMap[4738809532108798243L].transform, false);
        goMap[-8490753408518963357L].transform.SetParent(goMap[4738809532108798243L].transform, false);
        goMap[-5332259170841068989L].transform.SetParent(goMap[4738809532108798243L].transform, false);
        goMap[-1005047536695220358L].transform.SetParent(goMap[4738809532108798243L].transform, false);
        goMap[282133458021753375L].transform.SetParent(goMap[-1005047536695220358L].transform, false);
        goMap[-3769662730719947932L].transform.SetParent(goMap[1963229782784186703L].transform, false);
        goMap[4086984118314974064L].transform.SetParent(goMap[-3769662730719947932L].transform, false);
        goMap[-4929854311498320183L].transform.SetParent(goMap[-3769662730719947932L].transform, false);
        goMap[8859664096502209178L].transform.SetParent(goMap[-3769662730719947932L].transform, false);
        goMap[3626295187002482928L].transform.SetParent(goMap[-3769662730719947932L].transform, false);
        goMap[-3859571403933658986L].transform.SetParent(goMap[3626295187002482928L].transform, false);
        goMap[2893754803441222203L].transform.SetParent(goMap[1963229782784186703L].transform, false);
        goMap[342512212035237246L].transform.SetParent(goMap[2893754803441222203L].transform, false);
        goMap[-3490818806212525058L].transform.SetParent(goMap[2893754803441222203L].transform, false);
        goMap[7875392811810505008L].transform.SetParent(goMap[2893754803441222203L].transform, false);
        goMap[4783548646248206586L].transform.SetParent(goMap[2893754803441222203L].transform, false);
        goMap[3545101595527939407L].transform.SetParent(goMap[4783548646248206586L].transform, false);
        goMap[8939267422253780043L].transform.SetParent(goMap[1963229782784186703L].transform, false);
        goMap[-6818114889825714276L].transform.SetParent(goMap[8939267422253780043L].transform, false);
        goMap[-8852044364166502203L].transform.SetParent(goMap[8939267422253780043L].transform, false);
        goMap[-4173716544426695569L].transform.SetParent(goMap[8939267422253780043L].transform, false);
        goMap[-2367827872379986103L].transform.SetParent(goMap[8939267422253780043L].transform, false);
        goMap[-114094213477513418L].transform.SetParent(goMap[-2367827872379986103L].transform, false);

        // ─── RectTransforms ──────────────────────────────────
        {
            var rt = goMap[4819335448985046053L].AddComponent<RectTransform>();
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
            var rt = goMap[-4009740617851856979L].AddComponent<RectTransform>();
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
            var rt = goMap[-8174799108336178379L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000244f, 0.000000f);
        }
        {
            var rt = goMap[-9151620475021393516L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.000059f, 0.000000f);
            rt.sizeDelta = new Vector2(1280.000000f, 720.000000f);
        }
        {
            var rt = goMap[4876639976599978901L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(816.000000f, 721.000000f);
        }
        {
            var rt = goMap[1892586625407494784L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.994888f,-0.100987f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(812.000000f, 812.000000f);
        }
        {
            var rt = goMap[-1503355689707737232L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 38.900002f);
            rt.sizeDelta = new Vector2(708.000000f, 624.000000f);
        }
        {
            var rt = goMap[-8936318331402761519L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(626.866089f, 447.904358f, 0.999786f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 64.300003f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-1591030223787988054L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(767.909546f, 306.963837f, 0.999882f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.300000f, -196.100006f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-7495977913106730410L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.524899f,0.851165f,0.000000f);
            rt.localScale = new Vector3(0.268178f, 0.268178f, 0.268178f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-3510610541380237278L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.717160f, 0.717160f, 0.717160f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[9111669115138538998L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.717160f, 0.717160f, 0.717160f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[2834392888039573256L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(19.799927f, -30.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 60.000000f);
        }
        {
            var rt = goMap[8852437334595616062L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(0.800000f, 0.800000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.500000f);
            rt.anchorMax = new Vector2(1.000000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(23.700005f, -3.400000f);
            rt.sizeDelta = new Vector2(52.000000f, 52.000000f);
        }
        {
            var rt = goMap[-5380319781391671054L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.000031f, -0.001251f);
            rt.sizeDelta = new Vector2(1154.000000f, 661.770020f);
        }
        {
            var rt = goMap[7970867397367519496L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000031f, -34.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[6742190131932243580L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-13.000000f, 79.000000f);
            rt.sizeDelta = new Vector2(1264.000000f, 528.000000f);
        }
        {
            var rt = goMap[7387779843775975856L].AddComponent<RectTransform>();
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
            var rt = goMap[-6759574980915932396L].AddComponent<RectTransform>();
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
            var rt = goMap[-5731550630456769182L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-318.000000f, -300.880219f);
            rt.sizeDelta = new Vector2(105.000000f, 62.000000f);
        }
        {
            var rt = goMap[2188390708554993707L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -33.669239f);
            rt.sizeDelta = new Vector2(72.000000f, 78.000000f);
        }
        {
            var rt = goMap[-6592110375637805327L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-567.000000f, -321.079926f);
            rt.sizeDelta = new Vector2(99.000000f, 87.000000f);
        }
        {
            var rt = goMap[6870609025290668291L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(44.000000f, -376.688324f);
            rt.sizeDelta = new Vector2(125.000000f, 76.000000f);
        }
        {
            var rt = goMap[-2676376668016231640L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-515.000000f, -56.270004f);
            rt.sizeDelta = new Vector2(59.000000f, 63.000000f);
        }
        {
            var rt = goMap[4424472383744146493L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -36.827873f);
            rt.sizeDelta = new Vector2(73.000000f, 67.000000f);
        }
        {
            var rt = goMap[-6189851091565826385L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(656.000000f, 171.453003f);
            rt.sizeDelta = new Vector2(73.000000f, 108.000000f);
        }
        {
            var rt = goMap[-2605723084892628197L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(744.000000f, 227.635880f);
            rt.sizeDelta = new Vector2(115.000000f, 121.000000f);
        }
        {
            var rt = goMap[477001982891309104L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(415.000000f, -284.762451f);
            rt.sizeDelta = new Vector2(55.000000f, 59.000000f);
        }
        {
            var rt = goMap[-5707384806701844166L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(601.000000f, -271.120575f);
            rt.sizeDelta = new Vector2(172.000000f, 109.000000f);
        }
        {
            var rt = goMap[3945488021599877140L].AddComponent<RectTransform>();
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
            var rt = goMap[-1291141195669593967L].AddComponent<RectTransform>();
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
            var rt = goMap[774815550174164945L].AddComponent<RectTransform>();
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
            var rt = goMap[-4513997910400335741L].AddComponent<RectTransform>();
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
            var rt = goMap[-8923759541003661355L].AddComponent<RectTransform>();
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
            var rt = goMap[-8530091813134288047L].AddComponent<RectTransform>();
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
            var rt = goMap[-4284899629221323854L].AddComponent<RectTransform>();
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
            var rt = goMap[7164904240449843560L].AddComponent<RectTransform>();
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
            var rt = goMap[4013184310230766431L].AddComponent<RectTransform>();
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
            var rt = goMap[-5137377339727836689L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, -1.216400f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(0.599210f, 0.599210f, 0.599210f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-3.206400f, -68.721008f);
            rt.sizeDelta = new Vector2(273.000000f, 287.000000f);
        }
        {
            var rt = goMap[-6074657908179465672L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, -1.216400f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(0.599210f, 0.599210f, 0.599210f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-8.000000f, -159.800018f);
            rt.sizeDelta = new Vector2(564.000000f, 126.000000f);
        }
        {
            var rt = goMap[-7578610513728695982L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, -1.216400f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(0.599210f, 0.599210f, 0.599210f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-3.206400f, -158.000000f);
            rt.sizeDelta = new Vector2(493.000000f, 328.000000f);
        }
        {
            var rt = goMap[8752633661201647517L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, -1.216400f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(0.599210f, 0.599210f, 0.599210f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-3.206400f, -191.560013f);
            rt.sizeDelta = new Vector2(241.000000f, 135.000000f);
        }
        {
            var rt = goMap[3995448807955063930L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, -0.752390f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(0.752105f, 0.752105f, 0.752105f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(10.802000f, -76.708015f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[3242399999460821893L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.478950f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.542625f, 0.542625f, 0.542625f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-1.111300f, -46.133999f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-6752815307683922378L].AddComponent<RectTransform>();
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
            var rt = goMap[8805448058483966012L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,-1.000000f,0.000000f,0.000000f);
            rt.localScale = new Vector3(20.008423f, 17.861040f, 0.324746f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-4.600000f, -47.700001f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-4007633394725432196L].AddComponent<RectTransform>();
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
            var rt = goMap[-7282599408271715796L].AddComponent<RectTransform>();
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
            var rt = goMap[7797905765695626947L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, -0.991040f);
            rt.localRotation = new Quaternion(0.000000f,-1.000000f,0.000000f,0.000000f);
            rt.localScale = new Vector3(77.027458f, 68.760574f, 1.250192f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-13.714000f, 254.110001f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[2184598130986927044L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-4.000000f, 36.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[1807315397694397354L].AddComponent<RectTransform>();
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
            var rt = goMap[-3606545693049957187L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 889.640015f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.500000f, 1.500000f, 1.500000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-1.200000f, -49.200001f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[382484804367401699L].AddComponent<RectTransform>();
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
            var rt = goMap[6679511227897196168L].AddComponent<RectTransform>();
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
            var rt = goMap[-2905933428464315081L].AddComponent<RectTransform>();
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
            var rt = goMap[-3329878931021310428L].AddComponent<RectTransform>();
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
            var rt = goMap[-3502103925725581644L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, -232.940002f);
            rt.localRotation = new Quaternion(-0.041880f,0.424098f,0.088903f,0.900268f);
            rt.localScale = new Vector3(1.486100f, 1.486100f, 1.486100f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(21.000000f, 47.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-7394679089984868651L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 105.900002f);
            rt.localRotation = new Quaternion(0.095936f,-0.984263f,0.022996f,0.146612f);
            rt.localScale = new Vector3(1.486100f, 1.486100f, 1.486100f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-124.641006f, 146.569016f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-3564783400013696194L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, -91.757004f);
            rt.localRotation = new Quaternion(0.032474f,-0.824500f,0.244786f,0.509142f);
            rt.localScale = new Vector3(1.486100f, 1.486100f, 1.486100f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-63.708996f, -9.472986f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-2726897064287536982L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, -313.190002f);
            rt.localRotation = new Quaternion(0.593562f,0.220039f,-0.317393f,0.706065f);
            rt.localScale = new Vector3(-1.170854f, 1.170854f, 1.170854f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-274.737000f, 103.473015f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-5839280060843895280L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, -333.700012f);
            rt.localRotation = new Quaternion(0.323667f,0.902466f,0.002887f,-0.284229f);
            rt.localScale = new Vector3(-1.486100f, 1.486100f, 1.486100f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(133.942993f, 47.000011f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[7100771624195794294L].AddComponent<RectTransform>();
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
            var rt = goMap[2287665600948638742L].AddComponent<RectTransform>();
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
            var rt = goMap[-933107128965746130L].AddComponent<RectTransform>();
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
            var rt = goMap[-6381627880408306472L].AddComponent<RectTransform>();
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
            var rt = goMap[8551861957485517136L].AddComponent<RectTransform>();
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
            var rt = goMap[-1902797993300054173L].AddComponent<RectTransform>();
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
            var rt = goMap[-6153628543227417074L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000061f, 0.001251f);
            rt.sizeDelta = new Vector2(406.000122f, 58.229980f);
        }
        {
            var rt = goMap[5252642059354391742L].AddComponent<RectTransform>();
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
            var rt = goMap[-211957413662482855L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 1.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-202.300003f, -90.300003f);
            rt.sizeDelta = new Vector2(52.000000f, 52.000000f);
        }
        {
            var rt = goMap[1561941930045693554L].AddComponent<RectTransform>();
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
            var rt = goMap[-3901944275606859404L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.000122f, -299.923248f);
            rt.sizeDelta = new Vector2(658.000000f, 121.556000f);
        }
        {
            var rt = goMap[1978926375919820888L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.000000f);
            rt.anchorMax = new Vector2(0.500000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(72.400002f, 104.000000f);
            rt.sizeDelta = new Vector2(32.000000f, 32.000000f);
        }
        {
            var rt = goMap[-7098503441982965008L].AddComponent<RectTransform>();
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
            var rt = goMap[7135430627738913241L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 8.375000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.000000f);
            rt.anchorMax = new Vector2(0.500000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(102.699997f, 56.599998f);
            rt.sizeDelta = new Vector2(150.000000f, 52.000000f);
        }
        {
            var rt = goMap[-4496826088188936620L].AddComponent<RectTransform>();
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
            var rt = goMap[3105518807093882871L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.000000f);
            rt.anchorMax = new Vector2(0.500000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-124.199997f, 103.100006f);
            rt.sizeDelta = new Vector2(32.000000f, 32.000000f);
        }
        {
            var rt = goMap[-2819388067459691541L].AddComponent<RectTransform>();
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
            var rt = goMap[1669872368941248673L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 8.375000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.000000f);
            rt.anchorMax = new Vector2(0.500000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-101.500000f, 55.700012f);
            rt.sizeDelta = new Vector2(150.000000f, 52.000000f);
        }
        {
            var rt = goMap[-4179266455452556974L].AddComponent<RectTransform>();
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
            var rt = goMap[-7453174105810813141L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -338.000000f);
            rt.sizeDelta = new Vector2(400.000000f, 40.000000f);
        }
        {
            var rt = goMap[-3481751320980515111L].AddComponent<RectTransform>();
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
            var rt = goMap[-6039891053796283742L].AddComponent<RectTransform>();
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
            var rt = goMap[2115900198056767718L].AddComponent<RectTransform>();
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
            var rt = goMap[5252582076376554681L].AddComponent<RectTransform>();
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
            var rt = goMap[5833663767682686097L].AddComponent<RectTransform>();
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
            var rt = goMap[4498117995788496094L].AddComponent<RectTransform>();
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
            var rt = goMap[-1360394101204846089L].AddComponent<RectTransform>();
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
            var rt = goMap[5158759203904459366L].AddComponent<RectTransform>();
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
            var rt = goMap[-6069233594518704085L].AddComponent<RectTransform>();
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
            var rt = goMap[-3197927011868807317L].AddComponent<RectTransform>();
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
            var rt = goMap[-1258867156500752294L].AddComponent<RectTransform>();
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
            var rt = goMap[-5576995668172751362L].AddComponent<RectTransform>();
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
            var rt = goMap[7821647098668844939L].AddComponent<RectTransform>();
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
            var rt = goMap[6686506202834080604L].AddComponent<RectTransform>();
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
            var rt = goMap[-3801218635263175337L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(537.000000f, -20.000000f);
            rt.sizeDelta = new Vector2(170.000000f, 40.000000f);
        }
        {
            var rt = goMap[7563170486094614631L].AddComponent<RectTransform>();
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
            var rt = goMap[5649588123910234908L].AddComponent<RectTransform>();
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
            var rt = goMap[1225239543510754234L].AddComponent<RectTransform>();
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
            var rt = goMap[-2986304683960228138L].AddComponent<RectTransform>();
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
            var rt = goMap[637470501273205855L].AddComponent<RectTransform>();
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
            var rt = goMap[-4125570003964329536L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(359.000000f, -20.000000f);
            rt.sizeDelta = new Vector2(170.000000f, 40.000000f);
        }
        {
            var rt = goMap[5287424476567467287L].AddComponent<RectTransform>();
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
            var rt = goMap[2947540931266190570L].AddComponent<RectTransform>();
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
            var rt = goMap[-1475367650970447587L].AddComponent<RectTransform>();
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
            var rt = goMap[-5891180512872814050L].AddComponent<RectTransform>();
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
            var rt = goMap[1518337924155512096L].AddComponent<RectTransform>();
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
            var rt = goMap[-5470516685279597304L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, -7.731608f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 1.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(1.000000f, 1.000000f);
            rt.anchoredPosition = new Vector2(-107.000000f, -1.899994f);
            rt.sizeDelta = new Vector2(745.000000f, 60.000000f);
        }
        {
            var rt = goMap[1963229782784186703L].AddComponent<RectTransform>();
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
            var rt = goMap[4738809532108798243L].AddComponent<RectTransform>();
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
            var rt = goMap[-1349906807189058108L].AddComponent<RectTransform>();
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
            var rt = goMap[-8490753408518963357L].AddComponent<RectTransform>();
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
            var rt = goMap[-5332259170841068989L].AddComponent<RectTransform>();
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
            var rt = goMap[-1005047536695220358L].AddComponent<RectTransform>();
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
            var rt = goMap[282133458021753375L].AddComponent<RectTransform>();
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
            var rt = goMap[-3769662730719947932L].AddComponent<RectTransform>();
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
            var rt = goMap[4086984118314974064L].AddComponent<RectTransform>();
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
            var rt = goMap[-4929854311498320183L].AddComponent<RectTransform>();
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
            var rt = goMap[8859664096502209178L].AddComponent<RectTransform>();
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
            var rt = goMap[3626295187002482928L].AddComponent<RectTransform>();
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
            var rt = goMap[-3859571403933658986L].AddComponent<RectTransform>();
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
            var rt = goMap[2893754803441222203L].AddComponent<RectTransform>();
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
            var rt = goMap[342512212035237246L].AddComponent<RectTransform>();
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
            var rt = goMap[-3490818806212525058L].AddComponent<RectTransform>();
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
            var rt = goMap[7875392811810505008L].AddComponent<RectTransform>();
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
            var rt = goMap[4783548646248206586L].AddComponent<RectTransform>();
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
            var rt = goMap[3545101595527939407L].AddComponent<RectTransform>();
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
            var rt = goMap[8939267422253780043L].AddComponent<RectTransform>();
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
            var rt = goMap[-6818114889825714276L].AddComponent<RectTransform>();
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
            var rt = goMap[-8852044364166502203L].AddComponent<RectTransform>();
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
            var rt = goMap[-4173716544426695569L].AddComponent<RectTransform>();
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
            var rt = goMap[-2367827872379986103L].AddComponent<RectTransform>();
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
            var rt = goMap[-114094213477513418L].AddComponent<RectTransform>();
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
        { var c = goMap[4819335448985046053L].AddComponent<Canvas>();
           c.renderMode = (RenderMode)1;
           c.overrideSorting = false;
           c.sortingOrder = 0;
           c.sortingLayerID = unchecked((int)194136777);
           c.planeDistance = 8.660000f;
           c.pixelPerfect = false;
           c.additionalShaderChannels = (AdditionalCanvasShaderChannels)0;
           c.enabled = true;
        }
        { var c = goMap[4819335448985046053L].AddComponent<CanvasScaler>();
           c.uiScaleMode = (CanvasScaler.ScaleMode)1;
           c.referenceResolution = new Vector2(1280.000000f, 720.000000f);
           c.screenMatchMode = (CanvasScaler.ScreenMatchMode)1;
           c.matchWidthOrHeight = 0.000000f;
           c.referencePixelsPerUnit = 100.000000f;
        }
        { var c = goMap[4819335448985046053L].AddComponent<GraphicRaycaster>();
           c.ignoreReversedGraphics = true;
        }
        { var c = goMap[4819335448985046053L].AddComponent<Image>();
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
        { var c = goMap[4819335448985046053L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("UISkillBookPickingNew"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[1892586625407494784L].AddComponent<Image>();
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
           c.sprite = LookupSprite("Dot");
        }
        { var c = goMap[-1503355689707737232L].AddComponent<Image>();
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
           c.sprite = LookupSprite("Moon");
        }
        { var c = goMap[-9115555122256397782L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("CardPickingTree"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[2834392888039573256L].AddComponent<Text>();
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
        { var c = goMap[2834392888039573256L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)2;
           c.verticalFit = (ContentSizeFitter.FitMode)0;
        }
        { var c = goMap[2834392888039573256L].AddComponent<CanvasGroup>();
           c.alpha = 1.000000f;
           c.interactable = true;
           c.blocksRaycasts = true;
           c.ignoreParentGroups = false;
        }
        { var c = goMap[8852437334595616062L].AddComponent<Image>();
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
        { var c = goMap[8852437334595616062L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[8852437334595616062L].AddComponent<UIScalePulse>();
           c.upScale = 0.950000f; c.duration = 0.100000f; c.scaleUp = false;
           c.enabled = true;
        }
        { var c = goMap[-5380319781391671054L].AddComponent<Canvas>();
           c.renderMode = (RenderMode)2;
           c.overrideSorting = true;
           c.sortingOrder = 10;
           c.sortingLayerID = unchecked((int)194136777);
           c.planeDistance = 100.000000f;
           c.pixelPerfect = false;
           c.additionalShaderChannels = (AdditionalCanvasShaderChannels)0;
           c.enabled = true;
        }
        { var c = goMap[-5380319781391671054L].AddComponent<GraphicRaycaster>();
           c.ignoreReversedGraphics = true;
        }
        { var c = goMap[6742190131932243580L].AddComponent<Image>();
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
        { var c = goMap[7387779843775975856L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("Stone"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[-6759574980915932396L].AddComponent<Image>();
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
        { var c = goMap[-5731550630456769182L].AddComponent<Image>();
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
        { var c = goMap[2188390708554993707L].AddComponent<Image>();
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
        { var c = goMap[-6592110375637805327L].AddComponent<Image>();
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
        { var c = goMap[6870609025290668291L].AddComponent<Image>();
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
        { var c = goMap[-2676376668016231640L].AddComponent<Image>();
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
        { var c = goMap[4424472383744146493L].AddComponent<Image>();
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
        { var c = goMap[-6189851091565826385L].AddComponent<Image>();
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
        { var c = goMap[-2605723084892628197L].AddComponent<Image>();
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
        { var c = goMap[477001982891309104L].AddComponent<Image>();
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
        { var c = goMap[-5707384806701844166L].AddComponent<Image>();
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
        { var c = goMap[3945488021599877140L].AddComponent<Image>();
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
        { var c = goMap[3945488021599877140L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("Stone"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[774815550174164945L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.588235f);
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
        { var c = goMap[-4513997910400335741L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.588235f);
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
        { var c = goMap[-8923759541003661355L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.588235f);
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
        { var c = goMap[-8530091813134288047L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.588235f);
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
        { var c = goMap[-4284899629221323854L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.588235f);
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
        { var c = goMap[7164904240449843560L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.588235f);
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
        { var c = goMap[4013184310230766431L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.588235f);
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
        { var c = goMap[-5137377339727836689L].AddComponent<Image>();
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
        { var c = goMap[-6074657908179465672L].AddComponent<Image>();
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
        { var c = goMap[5727666512096771818L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("JueSe"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[-7578610513728695982L].AddComponent<Image>();
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
        { var c = goMap[8752633661201647517L].AddComponent<Image>();
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
        { var c = goMap[3242399999460821893L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = false;
           { var ctrl = LookupAnimatorController("ZhaoMu"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[5252642059354391742L].AddComponent<Text>();
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
        { var c = goMap[-211957413662482855L].AddComponent<Image>();
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
        { var c = goMap[-211957413662482855L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-211957413662482855L].AddComponent<UIScalePulse>();
           c.upScale = 0.950000f; c.duration = 0.100000f; c.scaleUp = false;
           c.enabled = true;
        }
        { var c = goMap[-211957413662482855L].AddComponent<CanvasGroup>();
           c.alpha = 1.000000f;
           c.interactable = true;
           c.blocksRaycasts = true;
           c.ignoreParentGroups = false;
        }
        { var c = goMap[-3901944275606859404L].AddComponent<Image>();
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
        { var c = goMap[1978926375919820888L].AddComponent<Image>();
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
        { var c = goMap[-7098503441982965008L].AddComponent<Text>();
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
        { var c = goMap[7135430627738913241L].AddComponent<Image>();
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
        { var c = goMap[7135430627738913241L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[7135430627738913241L].AddComponent<UIScalePulse>();
           c.upScale = 0.950000f; c.duration = 0.100000f; c.scaleUp = false;
           c.enabled = true;
        }
        { var c = goMap[-4496826088188936620L].AddComponent<Text>();
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
        { var c = goMap[-4496826088188936620L].AddComponent<Shadow>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[3105518807093882871L].AddComponent<Image>();
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
        { var c = goMap[-2819388067459691541L].AddComponent<Text>();
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
        { var c = goMap[1669872368941248673L].AddComponent<Image>();
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
        { var c = goMap[1669872368941248673L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[1669872368941248673L].AddComponent<UIScalePulse>();
           c.upScale = 0.950000f; c.duration = 0.100000f; c.scaleUp = false;
           c.enabled = true;
        }
        { var c = goMap[-4179266455452556974L].AddComponent<Text>();
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
        { var c = goMap[-4179266455452556974L].AddComponent<Shadow>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-7453174105810813141L].AddComponent<Text>();
           c.text = "13809";
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
           c.resizeTextMinSize = 1;
           c.resizeTextMaxSize = 40;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-7453174105810813141L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-3481751320980515111L].AddComponent<CanvasGroup>();
           c.alpha = 1.000000f;
           c.interactable = true;
           c.blocksRaycasts = true;
           c.ignoreParentGroups = false;
        }
        { var c = goMap[-6039891053796283742L].AddComponent<GridLayoutGroup>();
           c.padding = new RectOffset(0,0,0,0);
           c.cellSize = new Vector2(170.000000f, 40.000000f);
           c.spacing = new Vector2(8.000000f, 0.000000f);
           c.childAlignment = (TextAnchor)5;
        }
        { var c = goMap[5252582076376554681L].AddComponent<Image>();
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
        { var c = goMap[5833663767682686097L].AddComponent<Text>();
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
        { var c = goMap[4498117995788496094L].AddComponent<Image>();
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
        { var c = goMap[-1360394101204846089L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-1360394101204846089L].AddComponent<UIScalePulse>();
           c.upScale = 1.100000f; c.duration = 0.100000f; c.scaleUp = true;
           c.enabled = true;
        }
        { var c = goMap[-1360394101204846089L].AddComponent<Image>();
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
        { var c = goMap[5158759203904459366L].AddComponent<Image>();
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
        { var c = goMap[-3197927011868807317L].AddComponent<Image>();
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
        { var c = goMap[-1258867156500752294L].AddComponent<Text>();
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
        { var c = goMap[-5576995668172751362L].AddComponent<Image>();
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
        { var c = goMap[7821647098668844939L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[7821647098668844939L].AddComponent<UIScalePulse>();
           c.upScale = 1.100000f; c.duration = 0.100000f; c.scaleUp = true;
           c.enabled = true;
        }
        { var c = goMap[7821647098668844939L].AddComponent<Image>();
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
        { var c = goMap[6686506202834080604L].AddComponent<Image>();
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
        { var c = goMap[7563170486094614631L].AddComponent<Image>();
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
        { var c = goMap[5649588123910234908L].AddComponent<Text>();
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
        { var c = goMap[1225239543510754234L].AddComponent<Image>();
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
        { var c = goMap[-2986304683960228138L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-2986304683960228138L].AddComponent<UIScalePulse>();
           c.upScale = 1.100000f; c.duration = 0.100000f; c.scaleUp = true;
           c.enabled = true;
        }
        { var c = goMap[-2986304683960228138L].AddComponent<Image>();
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
        { var c = goMap[637470501273205855L].AddComponent<Image>();
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
        { var c = goMap[5287424476567467287L].AddComponent<Image>();
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
        { var c = goMap[2947540931266190570L].AddComponent<Text>();
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
        { var c = goMap[-1475367650970447587L].AddComponent<Image>();
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
        { var c = goMap[-5891180512872814050L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-5891180512872814050L].AddComponent<UIScalePulse>();
           c.upScale = 1.100000f; c.duration = 0.100000f; c.scaleUp = true;
           c.enabled = true;
        }
        { var c = goMap[-5891180512872814050L].AddComponent<Image>();
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
        { var c = goMap[1518337924155512096L].AddComponent<Image>();
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
        { var c = goMap[-5470516685279597304L].AddComponent<CanvasGroup>();
           c.alpha = 1.000000f;
           c.interactable = true;
           c.blocksRaycasts = true;
           c.ignoreParentGroups = false;
        }
        { var c = goMap[1963229782784186703L].AddComponent<GridLayoutGroup>();
           c.padding = new RectOffset(0,0,0,0);
           c.cellSize = new Vector2(170.000000f, 40.000000f);
           c.spacing = new Vector2(8.000000f, 0.000000f);
           c.childAlignment = (TextAnchor)5;
        }
        { var c = goMap[-1349906807189058108L].AddComponent<Image>();
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
        { var c = goMap[-8490753408518963357L].AddComponent<Text>();
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
        { var c = goMap[-5332259170841068989L].AddComponent<Image>();
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
        { var c = goMap[-1005047536695220358L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-1005047536695220358L].AddComponent<UIScalePulse>();
           c.upScale = 1.100000f; c.duration = 0.100000f; c.scaleUp = true;
           c.enabled = true;
        }
        { var c = goMap[-1005047536695220358L].AddComponent<Image>();
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
        { var c = goMap[282133458021753375L].AddComponent<Image>();
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
        { var c = goMap[4086984118314974064L].AddComponent<Image>();
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
        { var c = goMap[-4929854311498320183L].AddComponent<Text>();
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
        { var c = goMap[8859664096502209178L].AddComponent<Image>();
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
        { var c = goMap[3626295187002482928L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[3626295187002482928L].AddComponent<UIScalePulse>();
           c.upScale = 1.100000f; c.duration = 0.100000f; c.scaleUp = true;
           c.enabled = true;
        }
        { var c = goMap[3626295187002482928L].AddComponent<Image>();
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
        { var c = goMap[-3859571403933658986L].AddComponent<Image>();
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
        { var c = goMap[342512212035237246L].AddComponent<Image>();
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
        { var c = goMap[-3490818806212525058L].AddComponent<Text>();
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
        { var c = goMap[7875392811810505008L].AddComponent<Image>();
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
        { var c = goMap[4783548646248206586L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[4783548646248206586L].AddComponent<UIScalePulse>();
           c.upScale = 1.100000f; c.duration = 0.100000f; c.scaleUp = true;
           c.enabled = true;
        }
        { var c = goMap[4783548646248206586L].AddComponent<Image>();
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
        { var c = goMap[3545101595527939407L].AddComponent<Image>();
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
        { var c = goMap[-6818114889825714276L].AddComponent<Image>();
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
        { var c = goMap[-8852044364166502203L].AddComponent<Text>();
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
        { var c = goMap[-4173716544426695569L].AddComponent<Image>();
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
        { var c = goMap[-2367827872379986103L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-2367827872379986103L].AddComponent<UIScalePulse>();
           c.upScale = 1.100000f; c.duration = 0.100000f; c.scaleUp = true;
           c.enabled = true;
        }
        { var c = goMap[-2367827872379986103L].AddComponent<Image>();
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
        { var c = goMap[-114094213477513418L].AddComponent<Image>();
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
        var rootGO = goMap[4819335448985046053L];
        string path = "Assets/Prefabs/Imported/UISkillBookPickingNew.prefab";
        PrefabUtility.SaveAsPrefabAsset(rootGO, path);
        Object.DestroyImmediate(rootGO);
        Debug.Log("[Import_res_p_432] Saved " + path);
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