// AUTO-GENERATED from res_p_517.ab — DO NOT EDIT MANUALLY.
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;
using System.Collections.Generic;
using KTO.Game;  // UIJoyStick and other ported KTO scripts

public class Import_res_p_517
{
    [MenuItem("KTO/Import/res_p_517")]
    public static void Build()
    {
        Debug.Log("[Import_res_p_517] Building UIWuLinLianSaiBattle...");

        // ─── Create all GameObjects ───────────────────────────
        var goMap = new Dictionary<long, GameObject>();
        var _toggleGroupByMbPid = new Dictionary<long, ToggleGroup>();
        var _toggleGroupLinks = new List<System.Tuple<Toggle,long>>();
        { var go = new GameObject("UIWuLinLianSaiBattle"); go.SetActive(true); goMap[8288932506965247784L] = go; }
        { var go = new GameObject("imgBG"); go.SetActive(true); goMap[-4511462900108186272L] = go; }
        { var go = new GameObject("Victory"); go.SetActive(false); goMap[700478526607095497L] = go; }
        { var go = new GameObject("VictoryEffect"); go.SetActive(true); goMap[-6765623561886376391L] = go; }
        { var go = new GameObject("imgBG"); go.SetActive(true); goMap[-1085736792926157276L] = go; }
        { var go = new GameObject("bg"); go.SetActive(true); goMap[7509994667406976506L] = go; }
        { var go = new GameObject("BG_Metal_R"); go.SetActive(true); goMap[-6964310842323112080L] = go; }
        { var go = new GameObject("BG_Metal_L"); go.SetActive(true); goMap[-6143024971044207336L] = go; }
        { var go = new GameObject("imgBg_Fire_Blue"); go.SetActive(true); goMap[-6044206671070556212L] = go; }
        { var go = new GameObject("Red_Fire"); go.SetActive(true); goMap[1384410120101208336L] = go; }
        { var go = new GameObject("FireStar"); go.SetActive(true); goMap[-713182743964884259L] = go; }
        { var go = new GameObject("imgBg_Fire_Red"); go.SetActive(true); goMap[-3339873612196055156L] = go; }
        { var go = new GameObject("Red_Fire"); go.SetActive(true); goMap[-4034519492194222613L] = go; }
        { var go = new GameObject("FireStar"); go.SetActive(true); goMap[-625872219110830929L] = go; }
        { var go = new GameObject("Blue_Metal"); go.SetActive(true); goMap[6214283012226554526L] = go; }
        { var go = new GameObject("Red_Metal"); go.SetActive(true); goMap[-926580658804960161L] = go; }
        { var go = new GameObject("GameObject"); go.SetActive(true); goMap[2176411311957158289L] = go; }
        { var go = new GameObject("BG_GlowBlue"); go.SetActive(true); goMap[-5851551586806943395L] = go; }
        { var go = new GameObject("BG_GlowRed"); go.SetActive(true); goMap[-8415852400827614567L] = go; }
        { var go = new GameObject("BG_FaZhen"); go.SetActive(true); goMap[-4322609040573995736L] = go; }
        { var go = new GameObject("Line_Blue"); go.SetActive(true); goMap[-1963365459134174588L] = go; }
        { var go = new GameObject("Line_Red"); go.SetActive(true); goMap[7591403367005598433L] = go; }
        { var go = new GameObject("BG_HuaWen"); go.SetActive(true); goMap[-2781019963408561852L] = go; }
        { var go = new GameObject("RedSword"); go.SetActive(true); goMap[-2541177810395555021L] = go; }
        { var go = new GameObject("BlueSword"); go.SetActive(true); goMap[6590721947264464161L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-4318585609790034221L] = go; }
        { var go = new GameObject("Text_Effect"); go.SetActive(true); goMap[-5819075653973683288L] = go; }
        { var go = new GameObject("txtTime"); go.SetActive(true); goMap[-5756810801748760106L] = go; }
        { var go = new GameObject("ParticleEffect"); go.SetActive(true); goMap[-2547151547099425951L] = go; }
        { var go = new GameObject("Yuan"); go.SetActive(true); goMap[8228206752514224026L] = go; }
        { var go = new GameObject("Particle"); go.SetActive(true); goMap[3970403163712778569L] = go; }
        { var go = new GameObject("M7"); go.SetActive(true); goMap[-251784569984474077L] = go; }
        { var go = new GameObject("M1"); go.SetActive(true); goMap[-7146635423424346707L] = go; }
        { var go = new GameObject("M2"); go.SetActive(true); goMap[4666243005614272673L] = go; }
        { var go = new GameObject("M3_1"); go.SetActive(true); goMap[3369231732147106662L] = go; }
        { var go = new GameObject("M4"); go.SetActive(true); goMap[-9085845853103327783L] = go; }
        { var go = new GameObject("M7"); go.SetActive(true); goMap[7228701384033899501L] = go; }
        { var go = new GameObject("M8"); go.SetActive(true); goMap[-5455168497910374233L] = go; }
        { var go = new GameObject("Defeat"); go.SetActive(false); goMap[4529452304786622977L] = go; }
        { var go = new GameObject("DefeatEffect"); go.SetActive(true); goMap[4087450521241690056L] = go; }
        { var go = new GameObject("imgBG"); go.SetActive(true); goMap[-368007361665983437L] = go; }
        { var go = new GameObject("bg"); go.SetActive(true); goMap[-1631881305623211769L] = go; }
        { var go = new GameObject("BG_Metal_R"); go.SetActive(true); goMap[-1368079570874760819L] = go; }
        { var go = new GameObject("BG_Metal_L"); go.SetActive(true); goMap[6614070594891758187L] = go; }
        { var go = new GameObject("imgBg_Fire_Blue"); go.SetActive(true); goMap[-685759207250653374L] = go; }
        { var go = new GameObject("Red_Fire"); go.SetActive(true); goMap[-625692137034036061L] = go; }
        { var go = new GameObject("FireStar"); go.SetActive(true); goMap[-9175370276732203199L] = go; }
        { var go = new GameObject("imgBg_Fire_Red"); go.SetActive(true); goMap[5140301278594195607L] = go; }
        { var go = new GameObject("Red_Fire"); go.SetActive(true); goMap[-4467730827413947217L] = go; }
        { var go = new GameObject("FireStar"); go.SetActive(true); goMap[8083819800272115210L] = go; }
        { var go = new GameObject("Blue_Metal"); go.SetActive(true); goMap[-9152707727201916803L] = go; }
        { var go = new GameObject("Red_Metal"); go.SetActive(true); goMap[-4336354349289966807L] = go; }
        { var go = new GameObject("GameObject"); go.SetActive(true); goMap[-7928769504467693945L] = go; }
        { var go = new GameObject("BG_GlowBlue"); go.SetActive(true); goMap[-9120023070448340131L] = go; }
        { var go = new GameObject("BG_GlowRed"); go.SetActive(true); goMap[-6300553758192693855L] = go; }
        { var go = new GameObject("BG_FaZhen"); go.SetActive(true); goMap[6299723835758528389L] = go; }
        { var go = new GameObject("Line_Blue"); go.SetActive(true); goMap[6225744891470185290L] = go; }
        { var go = new GameObject("Line_Red"); go.SetActive(true); goMap[7502300030645705236L] = go; }
        { var go = new GameObject("BG_HuaWen"); go.SetActive(true); goMap[3509430808153626885L] = go; }
        { var go = new GameObject("RedSword"); go.SetActive(true); goMap[869023297875462804L] = go; }
        { var go = new GameObject("BlueSword"); go.SetActive(true); goMap[7899913893374808673L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[2629715266137283633L] = go; }
        { var go = new GameObject("Text_Effect"); go.SetActive(false); goMap[781821326194390089L] = go; }
        { var go = new GameObject("txtTime"); go.SetActive(true); goMap[502909137235898508L] = go; }
        { var go = new GameObject("ParticleEffect"); go.SetActive(false); goMap[-1310265534670687926L] = go; }
        { var go = new GameObject("Particle"); go.SetActive(true); goMap[-1727180901221637586L] = go; }
        { var go = new GameObject("M3_1"); go.SetActive(true); goMap[-2792647273948448692L] = go; }
        { var go = new GameObject("M8"); go.SetActive(true); goMap[-5405080537496931186L] = go; }
        { var go = new GameObject("Ready"); go.SetActive(true); goMap[-2152507525683331501L] = go; }
        { var go = new GameObject("BG_Metal_R"); go.SetActive(true); goMap[6744258626760124394L] = go; }
        { var go = new GameObject("BG_Metal_L"); go.SetActive(true); goMap[-3002966148975525245L] = go; }
        { var go = new GameObject("imgBg_Fire_Blue"); go.SetActive(true); goMap[-1923178622911592181L] = go; }
        { var go = new GameObject("Red_Fire"); go.SetActive(true); goMap[7088541186769160303L] = go; }
        { var go = new GameObject("FireStar"); go.SetActive(true); goMap[4797690823332835406L] = go; }
        { var go = new GameObject("imgBg_Fire_Red"); go.SetActive(true); goMap[-7397396200095229823L] = go; }
        { var go = new GameObject("Red_Fire"); go.SetActive(true); goMap[702475251493000915L] = go; }
        { var go = new GameObject("FireStar"); go.SetActive(true); goMap[183819549407968240L] = go; }
        { var go = new GameObject("Blue_Metal"); go.SetActive(true); goMap[433591615642837982L] = go; }
        { var go = new GameObject("Red_Metal"); go.SetActive(true); goMap[-8953747061721227556L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-5725086431433319793L] = go; }
        { var go = new GameObject("Text02"); go.SetActive(false); goMap[3453597695561703720L] = go; }
        { var go = new GameObject("txtTime"); go.SetActive(true); goMap[7558215906013124814L] = go; }
        { var go = new GameObject("Jian"); go.SetActive(true); goMap[8175771094723028470L] = go; }
        { var go = new GameObject("Red"); go.SetActive(true); goMap[2297700789881564654L] = go; }
        { var go = new GameObject("Jian_Red"); go.SetActive(true); goMap[-7030387378609688649L] = go; }
        { var go = new GameObject("LiuGuang"); go.SetActive(true); goMap[-133789042358545939L] = go; }
        { var go = new GameObject("Glow"); go.SetActive(true); goMap[-8980650161997045476L] = go; }
        { var go = new GameObject("Blue"); go.SetActive(true); goMap[-6008994594342903801L] = go; }
        { var go = new GameObject("Jian_Blue"); go.SetActive(true); goMap[4688844249915211347L] = go; }
        { var go = new GameObject("GlowBlack"); go.SetActive(true); goMap[-8683656071072866938L] = go; }
        { var go = new GameObject("LiuGuang"); go.SetActive(true); goMap[7554334519589449312L] = go; }
        { var go = new GameObject("Line01"); go.SetActive(true); goMap[-8232313519749658847L] = go; }
        { var go = new GameObject("Line02"); go.SetActive(true); goMap[-1381527318579017939L] = go; }
        { var go = new GameObject("Glow"); go.SetActive(true); goMap[6900668258004713987L] = go; }
        { var go = new GameObject("GameObject"); go.SetActive(true); goMap[7296320469558768373L] = go; }
        { var go = new GameObject("BG_GlowBlue"); go.SetActive(true); goMap[1361004898752446676L] = go; }
        { var go = new GameObject("BG_GlowRed"); go.SetActive(true); goMap[-3162516049482321517L] = go; }
        { var go = new GameObject("BG_FaZhen"); go.SetActive(true); goMap[8306127775595398698L] = go; }
        { var go = new GameObject("Line_Blue"); go.SetActive(true); goMap[-3756162196483723447L] = go; }
        { var go = new GameObject("Line_Red"); go.SetActive(true); goMap[294629011539261058L] = go; }
        { var go = new GameObject("BG_HuaWen"); go.SetActive(true); goMap[450530573786936732L] = go; }
        { var go = new GameObject("BG_HuaWenMask"); go.SetActive(true); goMap[105830929750971316L] = go; }
        { var go = new GameObject("Particle_Effect"); go.SetActive(true); goMap[3291862978556232207L] = go; }
        { var go = new GameObject("Particle"); go.SetActive(true); goMap[-990704538762561937L] = go; }
        { var go = new GameObject("BGGlow"); go.SetActive(true); goMap[-5788079473907262662L] = go; }
        { var go = new GameObject("Line_Blue"); go.SetActive(true); goMap[2017640313260385473L] = go; }
        { var go = new GameObject("Glow_Blue"); go.SetActive(true); goMap[2739406875720858619L] = go; }
        { var go = new GameObject("Glow_Red"); go.SetActive(true); goMap[-3764221186348433138L] = go; }
        { var go = new GameObject("Line_Red"); go.SetActive(true); goMap[6997320763456225462L] = go; }
        { var go = new GameObject("HuoHua01"); go.SetActive(true); goMap[-8649311258924137086L] = go; }
        { var go = new GameObject("ShanDian_Glow"); go.SetActive(true); goMap[5049096773387215245L] = go; }
        { var go = new GameObject("ShanDian02"); go.SetActive(true); goMap[-6978354919168798905L] = go; }
        { var go = new GameObject("Draw"); go.SetActive(false); goMap[-6107052044566678351L] = go; }
        { var go = new GameObject("DogfallEffect"); go.SetActive(true); goMap[-8436115453037760527L] = go; }
        { var go = new GameObject("imgBG"); go.SetActive(true); goMap[-4605474477655128744L] = go; }
        { var go = new GameObject("bg"); go.SetActive(true); goMap[5631930042313090509L] = go; }
        { var go = new GameObject("BG_Metal_R"); go.SetActive(true); goMap[-2471261623395068496L] = go; }
        { var go = new GameObject("BG_Metal_L"); go.SetActive(true); goMap[3795461683082059577L] = go; }
        { var go = new GameObject("imgBg_Fire_Blue"); go.SetActive(true); goMap[-2340782766390483293L] = go; }
        { var go = new GameObject("Red_Fire"); go.SetActive(true); goMap[-9071473782348700067L] = go; }
        { var go = new GameObject("FireStar"); go.SetActive(true); goMap[6599278624756108569L] = go; }
        { var go = new GameObject("imgBg_Fire_Red"); go.SetActive(true); goMap[-5016114011965181486L] = go; }
        { var go = new GameObject("Red_Fire"); go.SetActive(true); goMap[-5889604305864907356L] = go; }
        { var go = new GameObject("FireStar"); go.SetActive(true); goMap[-865704538867222088L] = go; }
        { var go = new GameObject("Blue_Metal"); go.SetActive(true); goMap[172367045147299582L] = go; }
        { var go = new GameObject("Red_Metal"); go.SetActive(true); goMap[8776302537700400085L] = go; }
        { var go = new GameObject("GameObject"); go.SetActive(true); goMap[-8254504995378767248L] = go; }
        { var go = new GameObject("BG_GlowBlue"); go.SetActive(true); goMap[7803631156686637614L] = go; }
        { var go = new GameObject("BG_GlowRed"); go.SetActive(true); goMap[8593932820660588545L] = go; }
        { var go = new GameObject("BG_FaZhen"); go.SetActive(true); goMap[-5275482794238128886L] = go; }
        { var go = new GameObject("Line_Blue"); go.SetActive(true); goMap[-119379952709723457L] = go; }
        { var go = new GameObject("Line_Red"); go.SetActive(true); goMap[-7217358657160244274L] = go; }
        { var go = new GameObject("BG_HuaWen"); go.SetActive(true); goMap[6099669255969927281L] = go; }
        { var go = new GameObject("RedSword"); go.SetActive(true); goMap[1257179498954214446L] = go; }
        { var go = new GameObject("BlueSword"); go.SetActive(true); goMap[-5124942242176774516L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-3977737507305443799L] = go; }
        { var go = new GameObject("Text_Effect"); go.SetActive(true); goMap[8026671466016902728L] = go; }
        { var go = new GameObject("txtTime"); go.SetActive(true); goMap[-6504155991101315054L] = go; }
        { var go = new GameObject("ParticleEffect"); go.SetActive(true); goMap[-9145990261122792109L] = go; }
        { var go = new GameObject("Yuan"); go.SetActive(true); goMap[5065374567866928224L] = go; }
        { var go = new GameObject("Particle"); go.SetActive(true); goMap[-1085379337291598912L] = go; }
        { var go = new GameObject("M3_1"); go.SetActive(true); goMap[-7924307189418678326L] = go; }
        { var go = new GameObject("M4"); go.SetActive(true); goMap[3082785252512035663L] = go; }
        { var go = new GameObject("M8"); go.SetActive(true); goMap[8316886421942384569L] = go; }
        { var go = new GameObject("btnOk"); go.SetActive(true); goMap[7420228266637859512L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-6961562662614301415L] = go; }
        { var go = new GameObject("BlueTeam"); go.SetActive(true); goMap[7465586058000088774L] = go; }
        { var go = new GameObject("Img_MyTeam"); go.SetActive(true); goMap[4922310201327424995L] = go; }
        { var go = new GameObject("txtMyTeam"); go.SetActive(true); goMap[-1115911883448335651L] = go; }
        { var go = new GameObject("MyGroup"); go.SetActive(true); goMap[1559184296236093371L] = go; }
        { var go = new GameObject("MyTemplate"); go.SetActive(true); goMap[-8125837768278707682L] = go; }
        { var go = new GameObject("BG"); go.SetActive(true); goMap[4938678500959952648L] = go; }
        { var go = new GameObject("Full"); go.SetActive(true); goMap[-8043843360246071908L] = go; }
        { var go = new GameObject("txtName"); go.SetActive(true); goMap[-7321048092984497837L] = go; }
        { var go = new GameObject("PortraitObj"); go.SetActive(true); goMap[160596153764956185L] = go; }
        { var go = new GameObject("PortraitBg"); go.SetActive(true); goMap[-6548088098183714908L] = go; }
        { var go = new GameObject("Portrait"); go.SetActive(true); goMap[-8159720228654337436L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[8264518061686953219L] = go; }
        { var go = new GameObject("OutlineObj"); go.SetActive(false); goMap[-3266201109850105287L] = go; }
        { var go = new GameObject("imgOutlineBG"); go.SetActive(true); goMap[-5304899471738225166L] = go; }
        { var go = new GameObject("txtOutline"); go.SetActive(true); goMap[3353665947234687223L] = go; }
        { var go = new GameObject("PortraitFrame"); go.SetActive(false); goMap[-1008786526713200685L] = go; }
        { var go = new GameObject("Level"); go.SetActive(true); goMap[-4267053861779400716L] = go; }
        { var go = new GameObject("imgLvBg"); go.SetActive(true); goMap[-474284659334728111L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[7368914373586523362L] = go; }
        { var go = new GameObject("TextMaster"); go.SetActive(false); goMap[-6563695789993973661L] = go; }
        { var go = new GameObject("imgFactionIcon"); go.SetActive(true); goMap[5142014136674964623L] = go; }
        { var go = new GameObject("Ready"); go.SetActive(true); goMap[7660394797667502191L] = go; }
        { var go = new GameObject("txtKin"); go.SetActive(true); goMap[5139450922551537535L] = go; }
        { var go = new GameObject("txtFightPower"); go.SetActive(true); goMap[-2323307331607013020L] = go; }
        { var go = new GameObject("Result"); go.SetActive(false); goMap[-4542577707788328303L] = go; }
        { var go = new GameObject("txtKillCount"); go.SetActive(true); goMap[-4422224507333878224L] = go; }
        { var go = new GameObject("txtDamage"); go.SetActive(true); goMap[-6992372788664983378L] = go; }
        { var go = new GameObject("btnUp"); go.SetActive(true); goMap[-8657041082432049055L] = go; }
        { var go = new GameObject("btnDown"); go.SetActive(true); goMap[-4244189568723436854L] = go; }
        { var go = new GameObject("Empty"); go.SetActive(false); goMap[-5746002486937432618L] = go; }
        { var go = new GameObject("txtName"); go.SetActive(true); goMap[-119068930186243769L] = go; }
        { var go = new GameObject("Img_Trophy"); go.SetActive(false); goMap[-8497141645377787364L] = go; }
        { var go = new GameObject("MyTeamTittle"); go.SetActive(true); goMap[-4233711434050336527L] = go; }
        { var go = new GameObject("TeamTittle"); go.SetActive(true); goMap[-7515424364244795569L] = go; }
        { var go = new GameObject("Img_Bg"); go.SetActive(true); goMap[8778080051506401960L] = go; }
        { var go = new GameObject("Img_Line"); go.SetActive(true); goMap[-8138379562096505358L] = go; }
        { var go = new GameObject("TexMyTittle"); go.SetActive(true); goMap[-3408413553799519017L] = go; }
        { var go = new GameObject("Team1"); go.SetActive(true); goMap[2439077760553484839L] = go; }
        { var go = new GameObject("Img_Bg"); go.SetActive(true); goMap[-6851029706957163737L] = go; }
        { var go = new GameObject("Img_Line"); go.SetActive(true); goMap[-3294428624243169502L] = go; }
        { var go = new GameObject("TexMyNum"); go.SetActive(true); goMap[-6785735016372639179L] = go; }
        { var go = new GameObject("Team2"); go.SetActive(true); goMap[6934840241908943446L] = go; }
        { var go = new GameObject("Img_Bg"); go.SetActive(true); goMap[-7365800675109892040L] = go; }
        { var go = new GameObject("Img_Line"); go.SetActive(true); goMap[2905952232254738162L] = go; }
        { var go = new GameObject("TexMyNum"); go.SetActive(true); goMap[6078531385713533509L] = go; }
        { var go = new GameObject("Team3"); go.SetActive(true); goMap[-3217896183912345999L] = go; }
        { var go = new GameObject("Img_Bg"); go.SetActive(true); goMap[496055563929648742L] = go; }
        { var go = new GameObject("Img_Line"); go.SetActive(true); goMap[-1227621137874697774L] = go; }
        { var go = new GameObject("TexMyNum"); go.SetActive(true); goMap[1346506091348681508L] = go; }
        { var go = new GameObject("BlueLiuGuang"); go.SetActive(true); goMap[1566064392881136701L] = go; }
        { var go = new GameObject("RedTeam"); go.SetActive(true); goMap[-332179511771152574L] = go; }
        { var go = new GameObject("Img_EnemyTeam"); go.SetActive(true); goMap[6673018629142148065L] = go; }
        { var go = new GameObject("txtEnemyTeam"); go.SetActive(true); goMap[-7349370465402979044L] = go; }
        { var go = new GameObject("EnemyGroup"); go.SetActive(true); goMap[6691814768971194727L] = go; }
        { var go = new GameObject("EnemyTemplate1"); go.SetActive(true); goMap[-1380422878113667968L] = go; }
        { var go = new GameObject("BG"); go.SetActive(true); goMap[-709492796833853249L] = go; }
        { var go = new GameObject("Full"); go.SetActive(true); goMap[-1947320907263803347L] = go; }
        { var go = new GameObject("txtName"); go.SetActive(true); goMap[7904632379023582000L] = go; }
        { var go = new GameObject("PortraitObj"); go.SetActive(true); goMap[-9205327879029624770L] = go; }
        { var go = new GameObject("PortraitBg"); go.SetActive(true); goMap[5040599177235538469L] = go; }
        { var go = new GameObject("Portrait"); go.SetActive(true); goMap[7894479585749807760L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[2021145524246662191L] = go; }
        { var go = new GameObject("OutlineObj"); go.SetActive(false); goMap[-7494426994754784063L] = go; }
        { var go = new GameObject("imgOutlineBG"); go.SetActive(true); goMap[-1292183573080651866L] = go; }
        { var go = new GameObject("txtOutline"); go.SetActive(true); goMap[-1424909792947784981L] = go; }
        { var go = new GameObject("PortraitFrame"); go.SetActive(false); goMap[-275746101383750061L] = go; }
        { var go = new GameObject("Level"); go.SetActive(true); goMap[-6220808464177478983L] = go; }
        { var go = new GameObject("imgLvBg"); go.SetActive(true); goMap[564562545675123515L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[6251518469964913984L] = go; }
        { var go = new GameObject("TextMaster"); go.SetActive(false); goMap[-4793853822049358486L] = go; }
        { var go = new GameObject("imgFactionIcon"); go.SetActive(true); goMap[-6189157304605087176L] = go; }
        { var go = new GameObject("Ready"); go.SetActive(true); goMap[7116569135626935045L] = go; }
        { var go = new GameObject("txtKin"); go.SetActive(true); goMap[5151406503163289237L] = go; }
        { var go = new GameObject("txtFightPower"); go.SetActive(true); goMap[7023035217427834341L] = go; }
        { var go = new GameObject("Result"); go.SetActive(false); goMap[-459538195822770821L] = go; }
        { var go = new GameObject("txtKillCount"); go.SetActive(true); goMap[9135156445230722378L] = go; }
        { var go = new GameObject("txtDamage"); go.SetActive(true); goMap[-1151914568119698842L] = go; }
        { var go = new GameObject("btnUp"); go.SetActive(true); goMap[-5910943803449012956L] = go; }
        { var go = new GameObject("btnDown"); go.SetActive(true); goMap[-5238876571725887807L] = go; }
        { var go = new GameObject("Empty"); go.SetActive(false); goMap[-4893397891070029119L] = go; }
        { var go = new GameObject("txtName"); go.SetActive(true); goMap[-2008330955740574762L] = go; }
        { var go = new GameObject("Img_Trophy"); go.SetActive(false); goMap[-3974093048727078709L] = go; }
        { var go = new GameObject("MyEnemyTittle"); go.SetActive(true); goMap[130192412960308025L] = go; }
        { var go = new GameObject("TeamTittle"); go.SetActive(true); goMap[7661207905815414473L] = go; }
        { var go = new GameObject("Img_Bg"); go.SetActive(true); goMap[2225219857296705985L] = go; }
        { var go = new GameObject("Img_Line"); go.SetActive(true); goMap[2811206142600608215L] = go; }
        { var go = new GameObject("TexMyTittle"); go.SetActive(true); goMap[-6593795009663866144L] = go; }
        { var go = new GameObject("Team1"); go.SetActive(true); goMap[-4058428506990950266L] = go; }
        { var go = new GameObject("Img_Bg"); go.SetActive(true); goMap[-7657705507547346728L] = go; }
        { var go = new GameObject("Img_Line"); go.SetActive(true); goMap[-8932794834924486329L] = go; }
        { var go = new GameObject("TexMyNum"); go.SetActive(true); goMap[7965078269822874228L] = go; }
        { var go = new GameObject("Team2"); go.SetActive(true); goMap[3593142820523774836L] = go; }
        { var go = new GameObject("Img_Bg"); go.SetActive(true); goMap[621878492404309520L] = go; }
        { var go = new GameObject("Img_Line"); go.SetActive(true); goMap[4768753396885464892L] = go; }
        { var go = new GameObject("TexMyNum"); go.SetActive(true); goMap[3513306133997707923L] = go; }
        { var go = new GameObject("Team3"); go.SetActive(true); goMap[-1506896871338429913L] = go; }
        { var go = new GameObject("Img_Bg"); go.SetActive(true); goMap[4149299542629135470L] = go; }
        { var go = new GameObject("Img_Line"); go.SetActive(true); goMap[4499121895303975448L] = go; }
        { var go = new GameObject("TexMyNum"); go.SetActive(true); goMap[-5284297363748077661L] = go; }
        { var go = new GameObject("RedLiuGuang"); go.SetActive(true); goMap[1459112613939710407L] = go; }
        { var go = new GameObject("Image"); go.SetActive(false); goMap[3453250095787815906L] = go; }

        // ─── Parent links ─────────────────────────────────────
        goMap[-4511462900108186272L].transform.SetParent(goMap[8288932506965247784L].transform, false);
        goMap[700478526607095497L].transform.SetParent(goMap[-4511462900108186272L].transform, false);
        goMap[-6765623561886376391L].transform.SetParent(goMap[700478526607095497L].transform, false);
        goMap[-1085736792926157276L].transform.SetParent(goMap[-6765623561886376391L].transform, false);
        goMap[7509994667406976506L].transform.SetParent(goMap[-1085736792926157276L].transform, false);
        goMap[-6964310842323112080L].transform.SetParent(goMap[7509994667406976506L].transform, false);
        goMap[-6143024971044207336L].transform.SetParent(goMap[7509994667406976506L].transform, false);
        goMap[-6044206671070556212L].transform.SetParent(goMap[7509994667406976506L].transform, false);
        goMap[1384410120101208336L].transform.SetParent(goMap[-6044206671070556212L].transform, false);
        goMap[-713182743964884259L].transform.SetParent(goMap[-6044206671070556212L].transform, false);
        goMap[-3339873612196055156L].transform.SetParent(goMap[7509994667406976506L].transform, false);
        goMap[-4034519492194222613L].transform.SetParent(goMap[-3339873612196055156L].transform, false);
        goMap[-625872219110830929L].transform.SetParent(goMap[-3339873612196055156L].transform, false);
        goMap[6214283012226554526L].transform.SetParent(goMap[7509994667406976506L].transform, false);
        goMap[-926580658804960161L].transform.SetParent(goMap[7509994667406976506L].transform, false);
        goMap[2176411311957158289L].transform.SetParent(goMap[7509994667406976506L].transform, false);
        goMap[-5851551586806943395L].transform.SetParent(goMap[2176411311957158289L].transform, false);
        goMap[-8415852400827614567L].transform.SetParent(goMap[2176411311957158289L].transform, false);
        goMap[-4322609040573995736L].transform.SetParent(goMap[2176411311957158289L].transform, false);
        goMap[-1963365459134174588L].transform.SetParent(goMap[2176411311957158289L].transform, false);
        goMap[7591403367005598433L].transform.SetParent(goMap[2176411311957158289L].transform, false);
        goMap[-2781019963408561852L].transform.SetParent(goMap[2176411311957158289L].transform, false);
        goMap[-2541177810395555021L].transform.SetParent(goMap[2176411311957158289L].transform, false);
        goMap[6590721947264464161L].transform.SetParent(goMap[2176411311957158289L].transform, false);
        goMap[-4318585609790034221L].transform.SetParent(goMap[-1085736792926157276L].transform, false);
        goMap[-5819075653973683288L].transform.SetParent(goMap[-1085736792926157276L].transform, false);
        goMap[-5756810801748760106L].transform.SetParent(goMap[-1085736792926157276L].transform, false);
        goMap[-2547151547099425951L].transform.SetParent(goMap[-1085736792926157276L].transform, false);
        goMap[8228206752514224026L].transform.SetParent(goMap[-2547151547099425951L].transform, false);
        goMap[3970403163712778569L].transform.SetParent(goMap[-2547151547099425951L].transform, false);
        goMap[-251784569984474077L].transform.SetParent(goMap[3970403163712778569L].transform, false);
        goMap[-7146635423424346707L].transform.SetParent(goMap[3970403163712778569L].transform, false);
        goMap[4666243005614272673L].transform.SetParent(goMap[3970403163712778569L].transform, false);
        goMap[3369231732147106662L].transform.SetParent(goMap[3970403163712778569L].transform, false);
        goMap[-9085845853103327783L].transform.SetParent(goMap[3970403163712778569L].transform, false);
        goMap[7228701384033899501L].transform.SetParent(goMap[3970403163712778569L].transform, false);
        goMap[-5455168497910374233L].transform.SetParent(goMap[3970403163712778569L].transform, false);
        goMap[4529452304786622977L].transform.SetParent(goMap[-4511462900108186272L].transform, false);
        goMap[4087450521241690056L].transform.SetParent(goMap[4529452304786622977L].transform, false);
        goMap[-368007361665983437L].transform.SetParent(goMap[4087450521241690056L].transform, false);
        goMap[-1631881305623211769L].transform.SetParent(goMap[-368007361665983437L].transform, false);
        goMap[-1368079570874760819L].transform.SetParent(goMap[-1631881305623211769L].transform, false);
        goMap[6614070594891758187L].transform.SetParent(goMap[-1631881305623211769L].transform, false);
        goMap[-685759207250653374L].transform.SetParent(goMap[-1631881305623211769L].transform, false);
        goMap[-625692137034036061L].transform.SetParent(goMap[-685759207250653374L].transform, false);
        goMap[-9175370276732203199L].transform.SetParent(goMap[-685759207250653374L].transform, false);
        goMap[5140301278594195607L].transform.SetParent(goMap[-1631881305623211769L].transform, false);
        goMap[-4467730827413947217L].transform.SetParent(goMap[5140301278594195607L].transform, false);
        goMap[8083819800272115210L].transform.SetParent(goMap[5140301278594195607L].transform, false);
        goMap[-9152707727201916803L].transform.SetParent(goMap[-1631881305623211769L].transform, false);
        goMap[-4336354349289966807L].transform.SetParent(goMap[-1631881305623211769L].transform, false);
        goMap[-7928769504467693945L].transform.SetParent(goMap[-1631881305623211769L].transform, false);
        goMap[-9120023070448340131L].transform.SetParent(goMap[-7928769504467693945L].transform, false);
        goMap[-6300553758192693855L].transform.SetParent(goMap[-7928769504467693945L].transform, false);
        goMap[6299723835758528389L].transform.SetParent(goMap[-7928769504467693945L].transform, false);
        goMap[6225744891470185290L].transform.SetParent(goMap[-7928769504467693945L].transform, false);
        goMap[7502300030645705236L].transform.SetParent(goMap[-7928769504467693945L].transform, false);
        goMap[3509430808153626885L].transform.SetParent(goMap[-7928769504467693945L].transform, false);
        goMap[869023297875462804L].transform.SetParent(goMap[-7928769504467693945L].transform, false);
        goMap[7899913893374808673L].transform.SetParent(goMap[-7928769504467693945L].transform, false);
        goMap[2629715266137283633L].transform.SetParent(goMap[-368007361665983437L].transform, false);
        goMap[781821326194390089L].transform.SetParent(goMap[-368007361665983437L].transform, false);
        goMap[502909137235898508L].transform.SetParent(goMap[-368007361665983437L].transform, false);
        goMap[-1310265534670687926L].transform.SetParent(goMap[-368007361665983437L].transform, false);
        goMap[-1727180901221637586L].transform.SetParent(goMap[-1310265534670687926L].transform, false);
        goMap[-2792647273948448692L].transform.SetParent(goMap[-1727180901221637586L].transform, false);
        goMap[-5405080537496931186L].transform.SetParent(goMap[-1727180901221637586L].transform, false);
        goMap[-2152507525683331501L].transform.SetParent(goMap[-4511462900108186272L].transform, false);
        goMap[6744258626760124394L].transform.SetParent(goMap[-2152507525683331501L].transform, false);
        goMap[-3002966148975525245L].transform.SetParent(goMap[-2152507525683331501L].transform, false);
        goMap[-1923178622911592181L].transform.SetParent(goMap[-2152507525683331501L].transform, false);
        goMap[7088541186769160303L].transform.SetParent(goMap[-1923178622911592181L].transform, false);
        goMap[4797690823332835406L].transform.SetParent(goMap[-1923178622911592181L].transform, false);
        goMap[-7397396200095229823L].transform.SetParent(goMap[-2152507525683331501L].transform, false);
        goMap[702475251493000915L].transform.SetParent(goMap[-7397396200095229823L].transform, false);
        goMap[183819549407968240L].transform.SetParent(goMap[-7397396200095229823L].transform, false);
        goMap[433591615642837982L].transform.SetParent(goMap[-2152507525683331501L].transform, false);
        goMap[-8953747061721227556L].transform.SetParent(goMap[-2152507525683331501L].transform, false);
        goMap[-5725086431433319793L].transform.SetParent(goMap[-2152507525683331501L].transform, false);
        goMap[3453597695561703720L].transform.SetParent(goMap[-2152507525683331501L].transform, false);
        goMap[7558215906013124814L].transform.SetParent(goMap[-2152507525683331501L].transform, false);
        goMap[8175771094723028470L].transform.SetParent(goMap[-2152507525683331501L].transform, false);
        goMap[2297700789881564654L].transform.SetParent(goMap[8175771094723028470L].transform, false);
        goMap[-7030387378609688649L].transform.SetParent(goMap[2297700789881564654L].transform, false);
        goMap[-133789042358545939L].transform.SetParent(goMap[-7030387378609688649L].transform, false);
        goMap[-8980650161997045476L].transform.SetParent(goMap[-7030387378609688649L].transform, false);
        goMap[-6008994594342903801L].transform.SetParent(goMap[8175771094723028470L].transform, false);
        goMap[4688844249915211347L].transform.SetParent(goMap[-6008994594342903801L].transform, false);
        goMap[-8683656071072866938L].transform.SetParent(goMap[4688844249915211347L].transform, false);
        goMap[7554334519589449312L].transform.SetParent(goMap[4688844249915211347L].transform, false);
        goMap[-8232313519749658847L].transform.SetParent(goMap[4688844249915211347L].transform, false);
        goMap[-1381527318579017939L].transform.SetParent(goMap[4688844249915211347L].transform, false);
        goMap[6900668258004713987L].transform.SetParent(goMap[4688844249915211347L].transform, false);
        goMap[7296320469558768373L].transform.SetParent(goMap[-2152507525683331501L].transform, false);
        goMap[1361004898752446676L].transform.SetParent(goMap[7296320469558768373L].transform, false);
        goMap[-3162516049482321517L].transform.SetParent(goMap[7296320469558768373L].transform, false);
        goMap[8306127775595398698L].transform.SetParent(goMap[7296320469558768373L].transform, false);
        goMap[-3756162196483723447L].transform.SetParent(goMap[7296320469558768373L].transform, false);
        goMap[294629011539261058L].transform.SetParent(goMap[7296320469558768373L].transform, false);
        goMap[450530573786936732L].transform.SetParent(goMap[7296320469558768373L].transform, false);
        goMap[105830929750971316L].transform.SetParent(goMap[7296320469558768373L].transform, false);
        goMap[3291862978556232207L].transform.SetParent(goMap[-2152507525683331501L].transform, false);
        goMap[-990704538762561937L].transform.SetParent(goMap[3291862978556232207L].transform, false);
        goMap[-5788079473907262662L].transform.SetParent(goMap[-990704538762561937L].transform, false);
        goMap[2017640313260385473L].transform.SetParent(goMap[-990704538762561937L].transform, false);
        goMap[2739406875720858619L].transform.SetParent(goMap[-990704538762561937L].transform, false);
        goMap[-3764221186348433138L].transform.SetParent(goMap[-990704538762561937L].transform, false);
        goMap[6997320763456225462L].transform.SetParent(goMap[-990704538762561937L].transform, false);
        goMap[-8649311258924137086L].transform.SetParent(goMap[3291862978556232207L].transform, false);
        goMap[5049096773387215245L].transform.SetParent(goMap[3291862978556232207L].transform, false);
        goMap[-6978354919168798905L].transform.SetParent(goMap[3291862978556232207L].transform, false);
        goMap[-6107052044566678351L].transform.SetParent(goMap[-4511462900108186272L].transform, false);
        goMap[-8436115453037760527L].transform.SetParent(goMap[-6107052044566678351L].transform, false);
        goMap[-4605474477655128744L].transform.SetParent(goMap[-8436115453037760527L].transform, false);
        goMap[5631930042313090509L].transform.SetParent(goMap[-4605474477655128744L].transform, false);
        goMap[-2471261623395068496L].transform.SetParent(goMap[5631930042313090509L].transform, false);
        goMap[3795461683082059577L].transform.SetParent(goMap[5631930042313090509L].transform, false);
        goMap[-2340782766390483293L].transform.SetParent(goMap[5631930042313090509L].transform, false);
        goMap[-9071473782348700067L].transform.SetParent(goMap[-2340782766390483293L].transform, false);
        goMap[6599278624756108569L].transform.SetParent(goMap[-2340782766390483293L].transform, false);
        goMap[-5016114011965181486L].transform.SetParent(goMap[5631930042313090509L].transform, false);
        goMap[-5889604305864907356L].transform.SetParent(goMap[-5016114011965181486L].transform, false);
        goMap[-865704538867222088L].transform.SetParent(goMap[-5016114011965181486L].transform, false);
        goMap[172367045147299582L].transform.SetParent(goMap[5631930042313090509L].transform, false);
        goMap[8776302537700400085L].transform.SetParent(goMap[5631930042313090509L].transform, false);
        goMap[-8254504995378767248L].transform.SetParent(goMap[5631930042313090509L].transform, false);
        goMap[7803631156686637614L].transform.SetParent(goMap[-8254504995378767248L].transform, false);
        goMap[8593932820660588545L].transform.SetParent(goMap[-8254504995378767248L].transform, false);
        goMap[-5275482794238128886L].transform.SetParent(goMap[-8254504995378767248L].transform, false);
        goMap[-119379952709723457L].transform.SetParent(goMap[-8254504995378767248L].transform, false);
        goMap[-7217358657160244274L].transform.SetParent(goMap[-8254504995378767248L].transform, false);
        goMap[6099669255969927281L].transform.SetParent(goMap[-8254504995378767248L].transform, false);
        goMap[1257179498954214446L].transform.SetParent(goMap[-8254504995378767248L].transform, false);
        goMap[-5124942242176774516L].transform.SetParent(goMap[-8254504995378767248L].transform, false);
        goMap[-3977737507305443799L].transform.SetParent(goMap[-4605474477655128744L].transform, false);
        goMap[8026671466016902728L].transform.SetParent(goMap[-4605474477655128744L].transform, false);
        goMap[-6504155991101315054L].transform.SetParent(goMap[-4605474477655128744L].transform, false);
        goMap[-9145990261122792109L].transform.SetParent(goMap[-4605474477655128744L].transform, false);
        goMap[5065374567866928224L].transform.SetParent(goMap[-9145990261122792109L].transform, false);
        goMap[-1085379337291598912L].transform.SetParent(goMap[-9145990261122792109L].transform, false);
        goMap[-7924307189418678326L].transform.SetParent(goMap[-1085379337291598912L].transform, false);
        goMap[3082785252512035663L].transform.SetParent(goMap[-1085379337291598912L].transform, false);
        goMap[8316886421942384569L].transform.SetParent(goMap[-1085379337291598912L].transform, false);
        goMap[7420228266637859512L].transform.SetParent(goMap[-4511462900108186272L].transform, false);
        goMap[-6961562662614301415L].transform.SetParent(goMap[7420228266637859512L].transform, false);
        goMap[7465586058000088774L].transform.SetParent(goMap[-4511462900108186272L].transform, false);
        goMap[4922310201327424995L].transform.SetParent(goMap[7465586058000088774L].transform, false);
        goMap[-1115911883448335651L].transform.SetParent(goMap[4922310201327424995L].transform, false);
        goMap[1559184296236093371L].transform.SetParent(goMap[7465586058000088774L].transform, false);
        goMap[-8125837768278707682L].transform.SetParent(goMap[1559184296236093371L].transform, false);
        goMap[4938678500959952648L].transform.SetParent(goMap[-8125837768278707682L].transform, false);
        goMap[-8043843360246071908L].transform.SetParent(goMap[-8125837768278707682L].transform, false);
        goMap[-7321048092984497837L].transform.SetParent(goMap[-8043843360246071908L].transform, false);
        goMap[160596153764956185L].transform.SetParent(goMap[-8043843360246071908L].transform, false);
        goMap[-6548088098183714908L].transform.SetParent(goMap[160596153764956185L].transform, false);
        goMap[-8159720228654337436L].transform.SetParent(goMap[160596153764956185L].transform, false);
        goMap[8264518061686953219L].transform.SetParent(goMap[-8159720228654337436L].transform, false);
        goMap[-3266201109850105287L].transform.SetParent(goMap[8264518061686953219L].transform, false);
        goMap[-5304899471738225166L].transform.SetParent(goMap[-3266201109850105287L].transform, false);
        goMap[3353665947234687223L].transform.SetParent(goMap[-3266201109850105287L].transform, false);
        goMap[-1008786526713200685L].transform.SetParent(goMap[160596153764956185L].transform, false);
        goMap[-4267053861779400716L].transform.SetParent(goMap[160596153764956185L].transform, false);
        goMap[-474284659334728111L].transform.SetParent(goMap[-4267053861779400716L].transform, false);
        goMap[7368914373586523362L].transform.SetParent(goMap[-4267053861779400716L].transform, false);
        goMap[-6563695789993973661L].transform.SetParent(goMap[-4267053861779400716L].transform, false);
        goMap[5142014136674964623L].transform.SetParent(goMap[160596153764956185L].transform, false);
        goMap[7660394797667502191L].transform.SetParent(goMap[-8043843360246071908L].transform, false);
        goMap[5139450922551537535L].transform.SetParent(goMap[7660394797667502191L].transform, false);
        goMap[-2323307331607013020L].transform.SetParent(goMap[7660394797667502191L].transform, false);
        goMap[-4542577707788328303L].transform.SetParent(goMap[-8043843360246071908L].transform, false);
        goMap[-4422224507333878224L].transform.SetParent(goMap[-4542577707788328303L].transform, false);
        goMap[-6992372788664983378L].transform.SetParent(goMap[-4542577707788328303L].transform, false);
        goMap[-8657041082432049055L].transform.SetParent(goMap[-8043843360246071908L].transform, false);
        goMap[-4244189568723436854L].transform.SetParent(goMap[-8043843360246071908L].transform, false);
        goMap[-5746002486937432618L].transform.SetParent(goMap[-8125837768278707682L].transform, false);
        goMap[-119068930186243769L].transform.SetParent(goMap[-5746002486937432618L].transform, false);
        goMap[-8497141645377787364L].transform.SetParent(goMap[-8125837768278707682L].transform, false);
        goMap[-4233711434050336527L].transform.SetParent(goMap[7465586058000088774L].transform, false);
        goMap[-7515424364244795569L].transform.SetParent(goMap[-4233711434050336527L].transform, false);
        goMap[8778080051506401960L].transform.SetParent(goMap[-7515424364244795569L].transform, false);
        goMap[-8138379562096505358L].transform.SetParent(goMap[-7515424364244795569L].transform, false);
        goMap[-3408413553799519017L].transform.SetParent(goMap[-7515424364244795569L].transform, false);
        goMap[2439077760553484839L].transform.SetParent(goMap[-4233711434050336527L].transform, false);
        goMap[-6851029706957163737L].transform.SetParent(goMap[2439077760553484839L].transform, false);
        goMap[-3294428624243169502L].transform.SetParent(goMap[2439077760553484839L].transform, false);
        goMap[-6785735016372639179L].transform.SetParent(goMap[2439077760553484839L].transform, false);
        goMap[6934840241908943446L].transform.SetParent(goMap[-4233711434050336527L].transform, false);
        goMap[-7365800675109892040L].transform.SetParent(goMap[6934840241908943446L].transform, false);
        goMap[2905952232254738162L].transform.SetParent(goMap[6934840241908943446L].transform, false);
        goMap[6078531385713533509L].transform.SetParent(goMap[6934840241908943446L].transform, false);
        goMap[-3217896183912345999L].transform.SetParent(goMap[-4233711434050336527L].transform, false);
        goMap[496055563929648742L].transform.SetParent(goMap[-3217896183912345999L].transform, false);
        goMap[-1227621137874697774L].transform.SetParent(goMap[-3217896183912345999L].transform, false);
        goMap[1346506091348681508L].transform.SetParent(goMap[-3217896183912345999L].transform, false);
        goMap[1566064392881136701L].transform.SetParent(goMap[7465586058000088774L].transform, false);
        goMap[-332179511771152574L].transform.SetParent(goMap[-4511462900108186272L].transform, false);
        goMap[6673018629142148065L].transform.SetParent(goMap[-332179511771152574L].transform, false);
        goMap[-7349370465402979044L].transform.SetParent(goMap[6673018629142148065L].transform, false);
        goMap[6691814768971194727L].transform.SetParent(goMap[-332179511771152574L].transform, false);
        goMap[-1380422878113667968L].transform.SetParent(goMap[6691814768971194727L].transform, false);
        goMap[-709492796833853249L].transform.SetParent(goMap[-1380422878113667968L].transform, false);
        goMap[-1947320907263803347L].transform.SetParent(goMap[-1380422878113667968L].transform, false);
        goMap[7904632379023582000L].transform.SetParent(goMap[-1947320907263803347L].transform, false);
        goMap[-9205327879029624770L].transform.SetParent(goMap[-1947320907263803347L].transform, false);
        goMap[5040599177235538469L].transform.SetParent(goMap[-9205327879029624770L].transform, false);
        goMap[7894479585749807760L].transform.SetParent(goMap[-9205327879029624770L].transform, false);
        goMap[2021145524246662191L].transform.SetParent(goMap[7894479585749807760L].transform, false);
        goMap[-7494426994754784063L].transform.SetParent(goMap[2021145524246662191L].transform, false);
        goMap[-1292183573080651866L].transform.SetParent(goMap[-7494426994754784063L].transform, false);
        goMap[-1424909792947784981L].transform.SetParent(goMap[-7494426994754784063L].transform, false);
        goMap[-275746101383750061L].transform.SetParent(goMap[-9205327879029624770L].transform, false);
        goMap[-6220808464177478983L].transform.SetParent(goMap[-9205327879029624770L].transform, false);
        goMap[564562545675123515L].transform.SetParent(goMap[-6220808464177478983L].transform, false);
        goMap[6251518469964913984L].transform.SetParent(goMap[-6220808464177478983L].transform, false);
        goMap[-4793853822049358486L].transform.SetParent(goMap[-6220808464177478983L].transform, false);
        goMap[-6189157304605087176L].transform.SetParent(goMap[-9205327879029624770L].transform, false);
        goMap[7116569135626935045L].transform.SetParent(goMap[-1947320907263803347L].transform, false);
        goMap[5151406503163289237L].transform.SetParent(goMap[7116569135626935045L].transform, false);
        goMap[7023035217427834341L].transform.SetParent(goMap[7116569135626935045L].transform, false);
        goMap[-459538195822770821L].transform.SetParent(goMap[-1947320907263803347L].transform, false);
        goMap[9135156445230722378L].transform.SetParent(goMap[-459538195822770821L].transform, false);
        goMap[-1151914568119698842L].transform.SetParent(goMap[-459538195822770821L].transform, false);
        goMap[-5910943803449012956L].transform.SetParent(goMap[-1947320907263803347L].transform, false);
        goMap[-5238876571725887807L].transform.SetParent(goMap[-1947320907263803347L].transform, false);
        goMap[-4893397891070029119L].transform.SetParent(goMap[-1380422878113667968L].transform, false);
        goMap[-2008330955740574762L].transform.SetParent(goMap[-4893397891070029119L].transform, false);
        goMap[-3974093048727078709L].transform.SetParent(goMap[-1380422878113667968L].transform, false);
        goMap[130192412960308025L].transform.SetParent(goMap[-332179511771152574L].transform, false);
        goMap[7661207905815414473L].transform.SetParent(goMap[130192412960308025L].transform, false);
        goMap[2225219857296705985L].transform.SetParent(goMap[7661207905815414473L].transform, false);
        goMap[2811206142600608215L].transform.SetParent(goMap[7661207905815414473L].transform, false);
        goMap[-6593795009663866144L].transform.SetParent(goMap[7661207905815414473L].transform, false);
        goMap[-4058428506990950266L].transform.SetParent(goMap[130192412960308025L].transform, false);
        goMap[-7657705507547346728L].transform.SetParent(goMap[-4058428506990950266L].transform, false);
        goMap[-8932794834924486329L].transform.SetParent(goMap[-4058428506990950266L].transform, false);
        goMap[7965078269822874228L].transform.SetParent(goMap[-4058428506990950266L].transform, false);
        goMap[3593142820523774836L].transform.SetParent(goMap[130192412960308025L].transform, false);
        goMap[621878492404309520L].transform.SetParent(goMap[3593142820523774836L].transform, false);
        goMap[4768753396885464892L].transform.SetParent(goMap[3593142820523774836L].transform, false);
        goMap[3513306133997707923L].transform.SetParent(goMap[3593142820523774836L].transform, false);
        goMap[-1506896871338429913L].transform.SetParent(goMap[130192412960308025L].transform, false);
        goMap[4149299542629135470L].transform.SetParent(goMap[-1506896871338429913L].transform, false);
        goMap[4499121895303975448L].transform.SetParent(goMap[-1506896871338429913L].transform, false);
        goMap[-5284297363748077661L].transform.SetParent(goMap[-1506896871338429913L].transform, false);
        goMap[1459112613939710407L].transform.SetParent(goMap[-332179511771152574L].transform, false);
        goMap[3453250095787815906L].transform.SetParent(goMap[-4511462900108186272L].transform, false);

        // ─── RectTransforms ──────────────────────────────────
        {
            var rt = goMap[8288932506965247784L].AddComponent<RectTransform>();
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
            var rt = goMap[-4511462900108186272L].AddComponent<RectTransform>();
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
            var rt = goMap[700478526607095497L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 221.000000f);
            rt.sizeDelta = new Vector2(400.000000f, 230.000000f);
        }
        {
            var rt = goMap[-6765623561886376391L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -65.800003f);
            rt.sizeDelta = new Vector2(1280.000000f, 720.000000f);
        }
        {
            var rt = goMap[-1085736792926157276L].AddComponent<RectTransform>();
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
            var rt = goMap[7509994667406976506L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -71.200012f);
            rt.sizeDelta = new Vector2(1280.000000f, 720.000000f);
        }
        {
            var rt = goMap[-6964310842323112080L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.000000f);
            rt.anchoredPosition = new Vector2(66.399994f, 83.100037f);
            rt.sizeDelta = new Vector2(490.000000f, 70.000000f);
        }
        {
            var rt = goMap[-6143024971044207336L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(-1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.000000f);
            rt.anchoredPosition = new Vector2(-52.700012f, 83.100037f);
            rt.sizeDelta = new Vector2(490.000000f, 70.000000f);
        }
        {
            var rt = goMap[-6044206671070556212L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000080f, 1.062720f, 1.000080f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-127.000000f, 176.000015f);
            rt.sizeDelta = new Vector2(311.000000f, 138.000000f);
        }
        {
            var rt = goMap[1384410120101208336L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(0.999920f, 0.999920f, 0.999920f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.000031f, 0.000031f);
            rt.sizeDelta = new Vector2(311.000000f, 138.000000f);
        }
        {
            var rt = goMap[-713182743964884259L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.703610f,-0.070240f,0.070240f,0.703610f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-19.400000f, -34.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-3339873612196055156L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000080f, 1.000080f, 1.000080f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(157.000000f, 183.199982f);
            rt.sizeDelta = new Vector2(311.000000f, 138.000000f);
        }
        {
            var rt = goMap[-4034519492194222613L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(0.999920f, 0.999920f, 0.999920f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.000031f, 0.000031f);
            rt.sizeDelta = new Vector2(311.000000f, 138.000000f);
        }
        {
            var rt = goMap[-625872219110830929L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.704799f,0.057086f,-0.057086f,0.704799f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-40.700001f, -34.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[6214283012226554526L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(1.000000f, 0.000000f);
            rt.anchoredPosition = new Vector2(-108.899963f, 107.600037f);
            rt.sizeDelta = new Vector2(346.000000f, 92.000000f);
        }
        {
            var rt = goMap[-926580658804960161L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.000000f);
            rt.anchoredPosition = new Vector2(122.600006f, 107.600052f);
            rt.sizeDelta = new Vector2(346.000000f, 92.000000f);
        }
        {
            var rt = goMap[2176411311957158289L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -84.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-5851551586806943395L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-3.800000f, 135.000000f);
            rt.sizeDelta = new Vector2(146.000000f, 408.000000f);
        }
        {
            var rt = goMap[-8415852400827614567L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(3.900000f, -98.800003f);
            rt.sizeDelta = new Vector2(165.000000f, 370.000000f);
        }
        {
            var rt = goMap[-4322609040573995736L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(427.000000f, 426.000000f);
        }
        {
            var rt = goMap[-1963365459134174588L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 148.600006f);
            rt.sizeDelta = new Vector2(15.000000f, 138.000000f);
        }
        {
            var rt = goMap[7591403367005598433L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -138.899994f);
            rt.sizeDelta = new Vector2(15.000000f, 138.000000f);
        }
        {
            var rt = goMap[-2781019963408561852L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(146.000000f, 158.000000f);
        }
        {
            var rt = goMap[-2541177810395555021L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(8.300000f, 12.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[6590721947264464161L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-6.800000f, 12.000006f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-4318585609790034221L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 82.000008f);
            rt.sizeDelta = new Vector2(483.440002f, 144.800003f);
        }
        {
            var rt = goMap[-5819075653973683288L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(3.411697f, 3.411697f, 3.411697f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(8.000000f, 82.000000f);
            rt.sizeDelta = new Vector2(483.440002f, 144.800003f);
        }
        {
            var rt = goMap[-5756810801748760106L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 5.828247f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 1.000000f);
            rt.anchorMax = new Vector2(0.500000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-5.400000f, -326.200012f);
            rt.sizeDelta = new Vector2(300.000000f, 40.000000f);
        }
        {
            var rt = goMap[-2547151547099425951L].AddComponent<RectTransform>();
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
            var rt = goMap[8228206752514224026L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,1.000000f,0.000000f,0.000000f);
            rt.localScale = new Vector3(103.134216f, 103.134216f, 1.031342f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-12.000000f, 74.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[3970403163712778569L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000080f, 1.000080f, 1.000080f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(20.999998f, -49.000004f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[7228701384033899501L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 100.142578f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(5.000000f, 110.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[4529452304786622977L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 221.000000f);
            rt.sizeDelta = new Vector2(400.000000f, 230.000000f);
        }
        {
            var rt = goMap[4087450521241690056L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -65.800003f);
            rt.sizeDelta = new Vector2(1280.000000f, 720.000000f);
        }
        {
            var rt = goMap[-368007361665983437L].AddComponent<RectTransform>();
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
            var rt = goMap[-1631881305623211769L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -71.200012f);
            rt.sizeDelta = new Vector2(1280.000000f, 720.000000f);
        }
        {
            var rt = goMap[-1368079570874760819L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.000000f);
            rt.anchoredPosition = new Vector2(66.399994f, 83.100037f);
            rt.sizeDelta = new Vector2(490.000000f, 70.000000f);
        }
        {
            var rt = goMap[6614070594891758187L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(-1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.000000f);
            rt.anchoredPosition = new Vector2(-52.700012f, 83.100037f);
            rt.sizeDelta = new Vector2(490.000000f, 70.000000f);
        }
        {
            var rt = goMap[-685759207250653374L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(-1.000080f, 1.062720f, 1.000080f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(156.000000f, 169.899994f);
            rt.sizeDelta = new Vector2(311.000000f, 138.000000f);
        }
        {
            var rt = goMap[-625692137034036061L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(-1.000000f, 0.999920f, 0.999920f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-9.500000f, 7.900000f);
            rt.sizeDelta = new Vector2(311.000000f, 138.000000f);
        }
        {
            var rt = goMap[-9175370276732203199L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.703610f,-0.070240f,0.070240f,0.703610f);
            rt.localScale = new Vector3(-1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-19.400000f, -34.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[5140301278594195607L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000080f, 1.000080f, 1.000080f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-155.000000f, 174.399979f);
            rt.sizeDelta = new Vector2(311.000000f, 138.000000f);
        }
        {
            var rt = goMap[-4467730827413947217L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(-1.000000f, 0.999920f, 0.999920f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-10.000000f, 11.500000f);
            rt.sizeDelta = new Vector2(311.000000f, 138.000000f);
        }
        {
            var rt = goMap[8083819800272115210L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.704799f,0.057086f,-0.057086f,0.704799f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-40.700001f, -34.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-9152707727201916803L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(-1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.000000f);
            rt.anchoredPosition = new Vector2(-113.000000f, 107.600037f);
            rt.sizeDelta = new Vector2(346.000000f, 92.000000f);
        }
        {
            var rt = goMap[-4336354349289966807L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.000000f);
            rt.anchoredPosition = new Vector2(122.600006f, 107.600052f);
            rt.sizeDelta = new Vector2(346.000000f, 92.000000f);
        }
        {
            var rt = goMap[-7928769504467693945L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -84.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-9120023070448340131L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-3.800000f, 135.000000f);
            rt.sizeDelta = new Vector2(146.000000f, 408.000000f);
        }
        {
            var rt = goMap[-6300553758192693855L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(3.900000f, -98.800003f);
            rt.sizeDelta = new Vector2(165.000000f, 370.000000f);
        }
        {
            var rt = goMap[6299723835758528389L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(427.000000f, 426.000000f);
        }
        {
            var rt = goMap[6225744891470185290L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 148.600006f);
            rt.sizeDelta = new Vector2(15.000000f, 138.000000f);
        }
        {
            var rt = goMap[7502300030645705236L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -138.899994f);
            rt.sizeDelta = new Vector2(15.000000f, 138.000000f);
        }
        {
            var rt = goMap[3509430808153626885L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(146.000000f, 158.000000f);
        }
        {
            var rt = goMap[869023297875462804L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(8.300000f, 12.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[7899913893374808673L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-6.800000f, 12.000006f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[2629715266137283633L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 82.000008f);
            rt.sizeDelta = new Vector2(483.440002f, 144.800003f);
        }
        {
            var rt = goMap[781821326194390089L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(3.411697f, 3.411697f, 3.411697f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(8.000000f, 82.000000f);
            rt.sizeDelta = new Vector2(483.440002f, 144.800003f);
        }
        {
            var rt = goMap[502909137235898508L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 5.828247f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 1.000000f);
            rt.anchorMax = new Vector2(0.500000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-5.400000f, -326.200012f);
            rt.sizeDelta = new Vector2(300.000000f, 40.000000f);
        }
        {
            var rt = goMap[-1310265534670687926L].AddComponent<RectTransform>();
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
            var rt = goMap[-1727180901221637586L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000080f, 1.000080f, 1.000080f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(20.999998f, -49.000004f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-2152507525683331501L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 270.000000f);
            rt.sizeDelta = new Vector2(400.000000f, 230.000000f);
        }
        {
            var rt = goMap[6744258626760124394L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(311.399994f, -67.899994f);
            rt.sizeDelta = new Vector2(490.000000f, 70.000000f);
        }
        {
            var rt = goMap[-3002966148975525245L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(-1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-297.700012f, -67.899994f);
            rt.sizeDelta = new Vector2(490.000000f, 70.000000f);
        }
        {
            var rt = goMap[-1923178622911592181L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000080f, 1.062720f, 1.000080f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-127.000000f, -10.000000f);
            rt.sizeDelta = new Vector2(311.000000f, 138.000000f);
        }
        {
            var rt = goMap[7088541186769160303L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(0.999920f, 0.999920f, 0.999920f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.000031f, 0.000031f);
            rt.sizeDelta = new Vector2(311.000000f, 138.000000f);
        }
        {
            var rt = goMap[4797690823332835406L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.703610f,-0.070240f,0.070240f,0.703610f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-19.400000f, -34.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-7397396200095229823L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000080f, 1.000080f, 1.000080f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(157.000000f, -2.799988f);
            rt.sizeDelta = new Vector2(311.000000f, 138.000000f);
        }
        {
            var rt = goMap[702475251493000915L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(0.999920f, 0.999920f, 0.999920f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.000031f, 0.000031f);
            rt.sizeDelta = new Vector2(311.000000f, 138.000000f);
        }
        {
            var rt = goMap[183819549407968240L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.704799f,0.057086f,-0.057086f,0.704799f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-40.700001f, -34.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[433591615642837982L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-281.899994f, -32.399994f);
            rt.sizeDelta = new Vector2(346.000000f, 92.000000f);
        }
        {
            var rt = goMap[-8953747061721227556L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(295.600006f, -32.399994f);
            rt.sizeDelta = new Vector2(346.000000f, 92.000000f);
        }
        {
            var rt = goMap[-5725086431433319793L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(6.300000f, -23.200001f);
            rt.sizeDelta = new Vector2(483.440002f, 144.800003f);
        }
        {
            var rt = goMap[3453597695561703720L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(6.300000f, -23.200001f);
            rt.sizeDelta = new Vector2(483.440002f, 144.800003f);
        }
        {
            var rt = goMap[7558215906013124814L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 5.828257f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 1.000000f);
            rt.anchorMax = new Vector2(0.500000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-5.400000f, -178.199997f);
            rt.sizeDelta = new Vector2(300.000000f, 40.000000f);
        }
        {
            var rt = goMap[8175771094723028470L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000080f, 1.000080f, 1.000080f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -270.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[2297700789881564654L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,-0.939693f,0.342020f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(108.000000f, -125.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-133789042358545939L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(2.559999f, 5.120002f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -1.476000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-8980650161997045476L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(2.559999f, 5.120002f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -1.476000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-6008994594342903801L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.939693f,0.342020f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-109.000000f, -124.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-8683656071072866938L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(2.560000f, 5.120000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.007000f, -1.510000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[7554334519589449312L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(2.560000f, 5.120000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.007000f, -1.510000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[6900668258004713987L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(2.560000f, 5.120000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.007000f, -1.510000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[7296320469558768373L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -270.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[1361004898752446676L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-3.800000f, 135.000000f);
            rt.sizeDelta = new Vector2(146.000000f, 408.000000f);
        }
        {
            var rt = goMap[-3162516049482321517L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(3.900000f, -98.800003f);
            rt.sizeDelta = new Vector2(165.000000f, 370.000000f);
        }
        {
            var rt = goMap[8306127775595398698L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(427.000000f, 426.000000f);
        }
        {
            var rt = goMap[-3756162196483723447L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 148.600006f);
            rt.sizeDelta = new Vector2(15.000000f, 138.000000f);
        }
        {
            var rt = goMap[294629011539261058L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -138.899994f);
            rt.sizeDelta = new Vector2(15.000000f, 138.000000f);
        }
        {
            var rt = goMap[450530573786936732L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(146.000000f, 158.000000f);
        }
        {
            var rt = goMap[105830929750971316L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(256.000000f, 256.000000f);
        }
        {
            var rt = goMap[3291862978556232207L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-5.000000f, -261.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-990704538762561937L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000080f, 1.000080f, 1.000080f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(20.999998f, -134.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-8649311258924137086L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 113.000000f);
            rt.localRotation = new Quaternion(-0.999783f,-0.000000f,-0.000000f,-0.020808f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(8.000000f, -15.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[5049096773387215245L].AddComponent<RectTransform>();
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
            var rt = goMap[-6978354919168798905L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-4.800000f, 3.800000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-6107052044566678351L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 221.000000f);
            rt.sizeDelta = new Vector2(400.000000f, 230.000000f);
        }
        {
            var rt = goMap[-8436115453037760527L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.000000f);
            rt.anchoredPosition = new Vector2(0.000000f, -99.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }
        {
            var rt = goMap[-4605474477655128744L].AddComponent<RectTransform>();
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
            var rt = goMap[5631930042313090509L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -38.000000f);
            rt.sizeDelta = new Vector2(1280.000000f, 720.000000f);
        }
        {
            var rt = goMap[-2471261623395068496L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.000000f);
            rt.anchoredPosition = new Vector2(66.399994f, 83.100037f);
            rt.sizeDelta = new Vector2(490.000000f, 70.000000f);
        }
        {
            var rt = goMap[3795461683082059577L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(-1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.000000f);
            rt.anchoredPosition = new Vector2(-52.700012f, 83.100037f);
            rt.sizeDelta = new Vector2(490.000000f, 70.000000f);
        }
        {
            var rt = goMap[-2340782766390483293L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(-1.000080f, 1.062720f, 1.000080f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(141.600006f, 169.899994f);
            rt.sizeDelta = new Vector2(311.000000f, 138.000000f);
        }
        {
            var rt = goMap[-9071473782348700067L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(-1.000000f, 0.999920f, 0.999920f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-9.500000f, 7.900000f);
            rt.sizeDelta = new Vector2(311.000000f, 138.000000f);
        }
        {
            var rt = goMap[6599278624756108569L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.703610f,-0.070240f,0.070240f,0.703610f);
            rt.localScale = new Vector3(-1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-19.400000f, -34.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-5016114011965181486L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000080f, 1.000080f, 1.000080f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-133.399994f, 174.399979f);
            rt.sizeDelta = new Vector2(311.000000f, 138.000000f);
        }
        {
            var rt = goMap[-5889604305864907356L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(-1.000000f, 0.999920f, 0.999920f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-10.000000f, 11.500000f);
            rt.sizeDelta = new Vector2(311.000000f, 138.000000f);
        }
        {
            var rt = goMap[-865704538867222088L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.704799f,0.057086f,-0.057086f,0.704799f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-40.700001f, -34.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[172367045147299582L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(-1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.000000f);
            rt.anchoredPosition = new Vector2(-113.000000f, 107.600037f);
            rt.sizeDelta = new Vector2(346.000000f, 92.000000f);
        }
        {
            var rt = goMap[8776302537700400085L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.000000f);
            rt.anchoredPosition = new Vector2(122.600006f, 107.600052f);
            rt.sizeDelta = new Vector2(346.000000f, 92.000000f);
        }
        {
            var rt = goMap[-8254504995378767248L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -84.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[7803631156686637614L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-3.800000f, 135.000000f);
            rt.sizeDelta = new Vector2(146.000000f, 408.000000f);
        }
        {
            var rt = goMap[8593932820660588545L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(3.900000f, -98.800003f);
            rt.sizeDelta = new Vector2(165.000000f, 370.000000f);
        }
        {
            var rt = goMap[-5275482794238128886L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(427.000000f, 426.000000f);
        }
        {
            var rt = goMap[-119379952709723457L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 148.600006f);
            rt.sizeDelta = new Vector2(15.000000f, 138.000000f);
        }
        {
            var rt = goMap[-7217358657160244274L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -138.899994f);
            rt.sizeDelta = new Vector2(15.000000f, 138.000000f);
        }
        {
            var rt = goMap[6099669255969927281L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(146.000000f, 158.000000f);
        }
        {
            var rt = goMap[1257179498954214446L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(8.300000f, 11.999991f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-5124942242176774516L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-6.800000f, 11.999997f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-3977737507305443799L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(8.000000f, 114.199997f);
            rt.sizeDelta = new Vector2(483.440002f, 144.800003f);
        }
        {
            var rt = goMap[8026671466016902728L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(3.411697f, 3.411697f, 3.411697f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(8.000000f, 115.200012f);
            rt.sizeDelta = new Vector2(483.440002f, 144.800003f);
        }
        {
            var rt = goMap[-6504155991101315054L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 5.828247f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 1.000000f);
            rt.anchorMax = new Vector2(0.500000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-5.400000f, -293.000000f);
            rt.sizeDelta = new Vector2(300.000000f, 40.000000f);
        }
        {
            var rt = goMap[-9145990261122792109L].AddComponent<RectTransform>();
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
            var rt = goMap[5065374567866928224L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,1.000000f,0.000000f,0.000000f);
            rt.localScale = new Vector3(103.134216f, 103.134216f, 1.031342f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-12.000000f, 74.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-1085379337291598912L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000080f, 1.000080f, 1.000080f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(20.999998f, -49.000004f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[7420228266637859512L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.000000f);
            rt.anchorMax = new Vector2(0.500000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-1.000000f, 62.000000f);
            rt.sizeDelta = new Vector2(144.000000f, 52.000000f);
        }
        {
            var rt = goMap[-6961562662614301415L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 3.000000f);
            rt.sizeDelta = new Vector2(144.000000f, 30.000000f);
        }
        {
            var rt = goMap[7465586058000088774L].AddComponent<RectTransform>();
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
            var rt = goMap[4922310201327424995L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-290.000000f, 157.000000f);
            rt.sizeDelta = new Vector2(275.000000f, 29.400000f);
        }
        {
            var rt = goMap[-1115911883448335651L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(300.000000f, 40.000000f);
        }
        {
            var rt = goMap[1559184296236093371L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-283.000000f, -44.000000f);
            rt.sizeDelta = new Vector2(500.000000f, 350.000000f);
        }
        {
            var rt = goMap[-8125837768278707682L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 5.828257f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(461.799988f, 118.000000f);
        }
        {
            var rt = goMap[4938678500959952648L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.000000f, 1.000000f);
            rt.anchoredPosition = new Vector2(28.400024f, -0.000061f);
            rt.sizeDelta = new Vector2(435.000000f, 118.000000f);
        }
        {
            var rt = goMap[-8043843360246071908L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(11.100000f, 0.000000f);
            rt.sizeDelta = new Vector2(440.000000f, 117.099998f);
        }
        {
            var rt = goMap[-7321048092984497837L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(267.299988f, -26.250061f);
            rt.sizeDelta = new Vector2(300.000000f, 36.000000f);
        }
        {
            var rt = goMap[160596153764956185L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, -5.828257f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(34.100006f, -52.049988f);
            rt.sizeDelta = new Vector2(50.000000f, 50.000000f);
        }
        {
            var rt = goMap[-6548088098183714908L].AddComponent<RectTransform>();
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
            var rt = goMap[-8159720228654337436L].AddComponent<RectTransform>();
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
            var rt = goMap[8264518061686953219L].AddComponent<RectTransform>();
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
            var rt = goMap[-3266201109850105287L].AddComponent<RectTransform>();
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
            var rt = goMap[-5304899471738225166L].AddComponent<RectTransform>();
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
            var rt = goMap[3353665947234687223L].AddComponent<RectTransform>();
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
            var rt = goMap[-1008786526713200685L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-1.800003f, 0.000000f);
            rt.sizeDelta = new Vector2(120.000000f, 120.000000f);
        }
        {
            var rt = goMap[-4267053861779400716L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.800003f, -47.299999f);
            rt.sizeDelta = new Vector2(50.000000f, 36.000000f);
        }
        {
            var rt = goMap[-474284659334728111L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(50.000000f, 24.000000f);
        }
        {
            var rt = goMap[7368914373586523362L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.500000f);
            rt.sizeDelta = new Vector2(33.400002f, 30.000000f);
        }
        {
            var rt = goMap[-6563695789993973661L].AddComponent<RectTransform>();
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
            var rt = goMap[5142014136674964623L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(28.799999f, 29.000000f);
            rt.sizeDelta = new Vector2(32.000000f, 32.000000f);
        }
        {
            var rt = goMap[7660394797667502191L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(46.500023f, -23.000000f);
            rt.sizeDelta = new Vector2(300.000000f, 61.099998f);
        }
        {
            var rt = goMap[5139450922551537535L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-48.500000f, 24.500000f);
            rt.sizeDelta = new Vector2(202.768005f, 48.275002f);
        }
        {
            var rt = goMap[-2323307331607013020L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-61.900002f, -3.000000f);
            rt.sizeDelta = new Vector2(176.390793f, 48.275002f);
        }
        {
            var rt = goMap[-4542577707788328303L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(304.710571f, -73.500000f);
            rt.sizeDelta = new Vector2(408.021088f, 61.099998f);
        }
        {
            var rt = goMap[-4422224507333878224L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-114.820129f, 18.000000f);
            rt.sizeDelta = new Vector2(145.608307f, 32.000000f);
        }
        {
            var rt = goMap[-6992372788664983378L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-77.400002f, -10.600000f);
            rt.sizeDelta = new Vector2(221.046799f, 32.000000f);
        }
        {
            var rt = goMap[-8657041082432049055L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, -5.828257f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 1.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-29.800110f, -31.550018f);
            rt.sizeDelta = new Vector2(48.000000f, 52.000000f);
        }
        {
            var rt = goMap[-4244189568723436854L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, -5.828257f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,1.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 1.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-29.699997f, -86.949989f);
            rt.sizeDelta = new Vector2(48.000000f, 52.000000f);
        }
        {
            var rt = goMap[-5746002486937432618L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(11.100000f, 0.000000f);
            rt.sizeDelta = new Vector2(440.000000f, 117.099998f);
        }
        {
            var rt = goMap[-119068930186243769L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(300.000000f, 36.000000f);
        }
        {
            var rt = goMap[-8497141645377787364L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(193.599976f, 0.000000f);
            rt.sizeDelta = new Vector2(56.211998f, 61.099998f);
        }
        {
            var rt = goMap[-4233711434050336527L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-564.000000f, -40.000000f);
            rt.sizeDelta = new Vector2(120.000000f, 500.000000f);
        }
        {
            var rt = goMap[-7515424364244795569L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-3.700000f, 199.399994f);
            rt.sizeDelta = new Vector2(130.000000f, 100.000000f);
        }
        {
            var rt = goMap[8778080051506401960L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,1.000000f,-0.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(9.299952f, -3.200027f);
            rt.sizeDelta = new Vector2(100.000000f, 33.000000f);
        }
        {
            var rt = goMap[-8138379562096505358L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(58.299980f, -3.099960f);
            rt.sizeDelta = new Vector2(2.000000f, 33.000000f);
        }
        {
            var rt = goMap[-3408413553799519017L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-2.999988f, -2.700027f);
            rt.sizeDelta = new Vector2(120.400002f, 35.000000f);
        }
        {
            var rt = goMap[2439077760553484839L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-3.700000f, 111.199997f);
            rt.sizeDelta = new Vector2(130.000000f, 100.000000f);
        }
        {
            var rt = goMap[-6851029706957163737L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,1.000000f,-0.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(9.299952f, -3.200027f);
            rt.sizeDelta = new Vector2(100.000000f, 33.000000f);
        }
        {
            var rt = goMap[-3294428624243169502L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(58.299980f, -0.600000f);
            rt.sizeDelta = new Vector2(2.000000f, 119.000000f);
        }
        {
            var rt = goMap[-6785735016372639179L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-2.000000f, -2.700027f);
            rt.sizeDelta = new Vector2(117.199997f, 40.000000f);
        }
        {
            var rt = goMap[6934840241908943446L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-3.700000f, -17.799999f);
            rt.sizeDelta = new Vector2(130.000000f, 100.000000f);
        }
        {
            var rt = goMap[-7365800675109892040L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,1.000000f,-0.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(9.299952f, -3.200027f);
            rt.sizeDelta = new Vector2(100.000000f, 33.000000f);
        }
        {
            var rt = goMap[2905952232254738162L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(58.299980f, -0.600000f);
            rt.sizeDelta = new Vector2(2.000000f, 119.000000f);
        }
        {
            var rt = goMap[6078531385713533509L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-2.000000f, -2.700027f);
            rt.sizeDelta = new Vector2(117.199997f, 40.000000f);
        }
        {
            var rt = goMap[-3217896183912345999L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-3.700000f, -144.699997f);
            rt.sizeDelta = new Vector2(130.000000f, 100.000000f);
        }
        {
            var rt = goMap[496055563929648742L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,1.000000f,-0.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(9.299952f, -3.200027f);
            rt.sizeDelta = new Vector2(100.000000f, 33.000000f);
        }
        {
            var rt = goMap[-1227621137874697774L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(58.299980f, -0.600000f);
            rt.sizeDelta = new Vector2(2.000000f, 119.000000f);
        }
        {
            var rt = goMap[1346506091348681508L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-2.000000f, -2.700027f);
            rt.sizeDelta = new Vector2(117.199997f, 40.000000f);
        }
        {
            var rt = goMap[1566064392881136701L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(5.424146f, 3.748394f, 3.527900f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-343.000000f, -55.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-332179511771152574L].AddComponent<RectTransform>();
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
            var rt = goMap[6673018629142148065L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(287.000000f, 157.000000f);
            rt.sizeDelta = new Vector2(275.000000f, 29.400000f);
        }
        {
            var rt = goMap[-7349370465402979044L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(300.000000f, 40.000000f);
        }
        {
            var rt = goMap[6691814768971194727L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(302.000000f, -44.000000f);
            rt.sizeDelta = new Vector2(500.000000f, 350.000000f);
        }
        {
            var rt = goMap[-1380422878113667968L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 5.828257f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(461.799988f, 118.000000f);
        }
        {
            var rt = goMap[-709492796833853249L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.000000f, 1.000000f);
            rt.anchoredPosition = new Vector2(28.400024f, -0.000061f);
            rt.sizeDelta = new Vector2(435.000000f, 118.000000f);
        }
        {
            var rt = goMap[-1947320907263803347L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(15.700000f, 0.000000f);
            rt.sizeDelta = new Vector2(435.000000f, 115.300003f);
        }
        {
            var rt = goMap[7904632379023582000L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(260.200012f, -25.350037f);
            rt.sizeDelta = new Vector2(300.000000f, 36.000000f);
        }
        {
            var rt = goMap[-9205327879029624770L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, -5.828257f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(26.999969f, -51.149994f);
            rt.sizeDelta = new Vector2(50.000000f, 50.000000f);
        }
        {
            var rt = goMap[5040599177235538469L].AddComponent<RectTransform>();
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
            var rt = goMap[7894479585749807760L].AddComponent<RectTransform>();
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
            var rt = goMap[2021145524246662191L].AddComponent<RectTransform>();
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
            var rt = goMap[-7494426994754784063L].AddComponent<RectTransform>();
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
            var rt = goMap[-1292183573080651866L].AddComponent<RectTransform>();
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
            var rt = goMap[-1424909792947784981L].AddComponent<RectTransform>();
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
            var rt = goMap[-275746101383750061L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-1.800003f, 0.000000f);
            rt.sizeDelta = new Vector2(120.000000f, 120.000000f);
        }
        {
            var rt = goMap[-6220808464177478983L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.800003f, -47.299999f);
            rt.sizeDelta = new Vector2(50.000000f, 36.000000f);
        }
        {
            var rt = goMap[564562545675123515L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(50.000000f, 24.000000f);
        }
        {
            var rt = goMap[6251518469964913984L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.500000f);
            rt.sizeDelta = new Vector2(33.400002f, 30.000000f);
        }
        {
            var rt = goMap[-4793853822049358486L].AddComponent<RectTransform>();
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
            var rt = goMap[-6189157304605087176L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(28.799999f, 29.000000f);
            rt.sizeDelta = new Vector2(32.000000f, 32.000000f);
        }
        {
            var rt = goMap[7116569135626935045L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(41.900047f, -23.000000f);
            rt.sizeDelta = new Vector2(300.000000f, 61.099998f);
        }
        {
            var rt = goMap[5151406503163289237L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-48.500000f, 24.500000f);
            rt.sizeDelta = new Vector2(202.768005f, 48.275002f);
        }
        {
            var rt = goMap[7023035217427834341L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-61.900002f, -3.000000f);
            rt.sizeDelta = new Vector2(176.390793f, 48.275002f);
        }
        {
            var rt = goMap[-459538195822770821L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(297.610596f, -72.599976f);
            rt.sizeDelta = new Vector2(408.021088f, 61.099998f);
        }
        {
            var rt = goMap[9135156445230722378L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-114.820129f, 18.000000f);
            rt.sizeDelta = new Vector2(145.608307f, 32.000000f);
        }
        {
            var rt = goMap[-1151914568119698842L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-77.400002f, -10.600000f);
            rt.sizeDelta = new Vector2(221.046799f, 32.000000f);
        }
        {
            var rt = goMap[-5910943803449012956L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, -5.828257f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 1.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-32.200073f, -30.649994f);
            rt.sizeDelta = new Vector2(48.000000f, 52.000000f);
        }
        {
            var rt = goMap[-5238876571725887807L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, -5.828257f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,1.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 1.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-32.100052f, -86.049995f);
            rt.sizeDelta = new Vector2(48.000000f, 52.000000f);
        }
        {
            var rt = goMap[-4893397891070029119L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(15.700000f, 0.000000f);
            rt.sizeDelta = new Vector2(435.000000f, 115.300003f);
        }
        {
            var rt = goMap[-2008330955740574762L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(300.000000f, 36.000000f);
        }
        {
            var rt = goMap[-3974093048727078709L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(194.100006f, 0.000000f);
            rt.sizeDelta = new Vector2(56.211998f, 61.099998f);
        }
        {
            var rt = goMap[130192412960308025L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(564.000000f, -41.000000f);
            rt.sizeDelta = new Vector2(120.000000f, 500.000000f);
        }
        {
            var rt = goMap[7661207905815414473L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-3.700000f, 199.399994f);
            rt.sizeDelta = new Vector2(130.000000f, 100.000000f);
        }
        {
            var rt = goMap[2225219857296705985L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(9.299952f, -3.200027f);
            rt.sizeDelta = new Vector2(100.000000f, 33.000000f);
        }
        {
            var rt = goMap[2811206142600608215L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-41.700001f, -3.099960f);
            rt.sizeDelta = new Vector2(2.000000f, 33.000000f);
        }
        {
            var rt = goMap[-6593795009663866144L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(18.400000f, -2.700027f);
            rt.sizeDelta = new Vector2(120.400002f, 35.000000f);
        }
        {
            var rt = goMap[-4058428506990950266L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-3.700000f, 111.199997f);
            rt.sizeDelta = new Vector2(130.000000f, 100.000000f);
        }
        {
            var rt = goMap[-7657705507547346728L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(9.299952f, -0.400000f);
            rt.sizeDelta = new Vector2(100.000000f, 119.000000f);
        }
        {
            var rt = goMap[-8932794834924486329L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-41.700001f, -0.600000f);
            rt.sizeDelta = new Vector2(2.000000f, 119.000000f);
        }
        {
            var rt = goMap[7965078269822874228L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(18.600000f, -2.700027f);
            rt.sizeDelta = new Vector2(117.199997f, 40.000000f);
        }
        {
            var rt = goMap[3593142820523774836L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-3.700000f, -16.600000f);
            rt.sizeDelta = new Vector2(130.000000f, 100.000000f);
        }
        {
            var rt = goMap[621878492404309520L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(9.299952f, -0.400000f);
            rt.sizeDelta = new Vector2(100.000000f, 119.000000f);
        }
        {
            var rt = goMap[4768753396885464892L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-41.700001f, -0.600000f);
            rt.sizeDelta = new Vector2(2.000000f, 119.000000f);
        }
        {
            var rt = goMap[3513306133997707923L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(18.600000f, -2.700027f);
            rt.sizeDelta = new Vector2(117.199997f, 40.000000f);
        }
        {
            var rt = goMap[-1506896871338429913L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-3.700000f, -145.100006f);
            rt.sizeDelta = new Vector2(130.000000f, 100.000000f);
        }
        {
            var rt = goMap[4149299542629135470L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(9.299952f, -0.400000f);
            rt.sizeDelta = new Vector2(100.000000f, 119.000000f);
        }
        {
            var rt = goMap[4499121895303975448L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-41.700001f, -0.600000f);
            rt.sizeDelta = new Vector2(2.000000f, 119.000000f);
        }
        {
            var rt = goMap[-5284297363748077661L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(18.600000f, -2.700027f);
            rt.sizeDelta = new Vector2(117.199997f, 40.000000f);
        }
        {
            var rt = goMap[1459112613939710407L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(5.424146f, 3.748394f, 3.527900f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(353.000000f, -57.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[3453250095787815906L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(1644.000000f, 720.000000f);
        }

        // ─── Components ──────────────────────────────────────
        { var c = goMap[8288932506965247784L].AddComponent<Canvas>();
           c.renderMode = (RenderMode)1;
           c.overrideSorting = false;
           c.sortingOrder = 0;
           c.sortingLayerID = unchecked((int)194136777);
           c.planeDistance = 100.000000f;
           c.pixelPerfect = false;
           c.additionalShaderChannels = (AdditionalCanvasShaderChannels)0;
           c.enabled = true;
        }
        { var c = goMap[8288932506965247784L].AddComponent<CanvasScaler>();
           c.uiScaleMode = (CanvasScaler.ScaleMode)1;
           c.referenceResolution = new Vector2(1280.000000f, 720.000000f);
           c.screenMatchMode = (CanvasScaler.ScreenMatchMode)1;
           c.matchWidthOrHeight = 0.000000f;
           c.referencePixelsPerUnit = 100.000000f;
        }
        { var c = goMap[8288932506965247784L].AddComponent<GraphicRaycaster>();
           c.ignoreReversedGraphics = true;
        }
        { var c = goMap[8288932506965247784L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("UIWuLinLianSaiBattle"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[-4511462900108186272L].AddComponent<Image>();
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
        { var c = goMap[-1085736792926157276L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("VictoryEffect"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[-6964310842323112080L].AddComponent<Image>();
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
           c.sprite = LookupSprite("BG_Metal");
        }
        { var c = goMap[-6143024971044207336L].AddComponent<Image>();
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
           c.sprite = LookupSprite("BG_Metal");
        }
        { var c = goMap[-6044206671070556212L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.000000f);
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
        { var c = goMap[1384410120101208336L].AddComponent<Image>();
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
        { var c = goMap[-3339873612196055156L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.000000f);
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
        { var c = goMap[-4034519492194222613L].AddComponent<Image>();
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
        { var c = goMap[6214283012226554526L].AddComponent<Image>();
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
           c.sprite = LookupSprite("Blue_Metal");
        }
        { var c = goMap[-926580658804960161L].AddComponent<Image>();
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
           c.sprite = LookupSprite("Red_Metal");
        }
        { var c = goMap[-5851551586806943395L].AddComponent<Image>();
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
           c.sprite = LookupSprite("BG_GlowBlue");
        }
        { var c = goMap[-8415852400827614567L].AddComponent<Image>();
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
           c.sprite = LookupSprite("BG_GlowRed");
        }
        { var c = goMap[-4322609040573995736L].AddComponent<Image>();
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
        { var c = goMap[-1963365459134174588L].AddComponent<Image>();
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
           c.sprite = LookupSprite("BG_BlueLine");
        }
        { var c = goMap[7591403367005598433L].AddComponent<Image>();
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
           c.sprite = LookupSprite("BG_RedLine");
        }
        { var c = goMap[-2781019963408561852L].AddComponent<Image>();
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
           c.sprite = LookupSprite("BG_HuaWen");
        }
        { var c = goMap[-2541177810395555021L].AddComponent<Image>();
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
           c.sprite = LookupSprite("RedSword");
        }
        { var c = goMap[6590721947264464161L].AddComponent<Image>();
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
           c.sprite = LookupSprite("BlueSword");
        }
        { var c = goMap[-4318585609790034221L].AddComponent<Text>();
           c.text = "8542";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 60;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 6;
           c.resizeTextMaxSize = 202;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-4318585609790034221L].AddComponent<Outline>();
           c.effectColor = new Color(0.517647f, 0.274510f, 0.198647f, 0.815686f);
           c.effectDistance = new Vector2(3.000000f, 3.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var g = goMap[-4318585609790034221L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.988678f, 1.000000f, 0.863208f, 1.000000f); }
        { var c = goMap[-5819075653973683288L].AddComponent<Text>();
           c.text = "8542";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.000000f);
           c.fontSize = 80;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 6;
           c.resizeTextMaxSize = 202;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var g = goMap[-5819075653973683288L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.988678f, 1.000000f, 0.863208f, 1.000000f); }
        { var c = goMap[-5756810801748760106L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(0.054902f, 0.984314f, 0.054902f, 1.000000f);
           c.fontSize = 18;
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
        { var c = goMap[-368007361665983437L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("DefeatEffect"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[-1368079570874760819L].AddComponent<Image>();
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
           c.sprite = LookupSprite("Fail_Metal");
        }
        { var c = goMap[6614070594891758187L].AddComponent<Image>();
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
           c.sprite = LookupSprite("Fail_Metal");
        }
        { var c = goMap[-685759207250653374L].AddComponent<Image>();
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
        { var c = goMap[-625692137034036061L].AddComponent<Image>();
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
        { var c = goMap[5140301278594195607L].AddComponent<Image>();
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
        { var c = goMap[-4467730827413947217L].AddComponent<Image>();
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
        { var c = goMap[-9152707727201916803L].AddComponent<Image>();
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
           c.sprite = LookupSprite("Fail__Metal");
        }
        { var c = goMap[-4336354349289966807L].AddComponent<Image>();
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
           c.sprite = LookupSprite("Fail__Metal");
        }
        { var c = goMap[-9120023070448340131L].AddComponent<Image>();
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
           c.sprite = LookupSprite("BG_GlowBlue");
        }
        { var c = goMap[-6300553758192693855L].AddComponent<Image>();
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
           c.sprite = LookupSprite("BG_GlowRed");
        }
        { var c = goMap[6299723835758528389L].AddComponent<Image>();
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
        { var c = goMap[6225744891470185290L].AddComponent<Image>();
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
           c.sprite = LookupSprite("BG_BlueLine");
        }
        { var c = goMap[7502300030645705236L].AddComponent<Image>();
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
           c.sprite = LookupSprite("BG_RedLine");
        }
        { var c = goMap[3509430808153626885L].AddComponent<Image>();
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
           c.sprite = LookupSprite("BG_HuaWen");
        }
        { var c = goMap[869023297875462804L].AddComponent<Image>();
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
           c.sprite = LookupSprite("RedSword");
        }
        { var c = goMap[7899913893374808673L].AddComponent<Image>();
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
           c.sprite = LookupSprite("BlueSword");
        }
        { var c = goMap[2629715266137283633L].AddComponent<Text>();
           c.text = "失败";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 60;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 6;
           c.resizeTextMaxSize = 202;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[2629715266137283633L].AddComponent<Outline>();
           c.effectColor = new Color(0.490566f, 0.490566f, 0.490566f, 0.815686f);
           c.effectDistance = new Vector2(3.000000f, 3.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var g = goMap[2629715266137283633L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.915094f, 0.915094f, 0.915094f, 1.000000f); }
        { var c = goMap[781821326194390089L].AddComponent<Text>();
           c.text = "8542";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.000000f);
           c.fontSize = 80;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 6;
           c.resizeTextMaxSize = 202;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var g = goMap[781821326194390089L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.988678f, 1.000000f, 0.863208f, 1.000000f); }
        { var c = goMap[502909137235898508L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(0.054902f, 0.984314f, 0.054902f, 1.000000f);
           c.fontSize = 18;
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
        { var c = goMap[-2152507525683331501L].AddComponent<CanvasGroup>();
           c.alpha = 1.000000f;
           c.interactable = true;
           c.blocksRaycasts = true;
           c.ignoreParentGroups = false;
        }
        { var c = goMap[6744258626760124394L].AddComponent<Image>();
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
           c.sprite = LookupSprite("BG_Metal");
        }
        { var c = goMap[-3002966148975525245L].AddComponent<Image>();
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
           c.sprite = LookupSprite("BG_Metal");
        }
        { var c = goMap[-1923178622911592181L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.000000f);
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
        { var c = goMap[7088541186769160303L].AddComponent<Image>();
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
        { var c = goMap[-7397396200095229823L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.000000f);
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
        { var c = goMap[702475251493000915L].AddComponent<Image>();
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
        { var c = goMap[433591615642837982L].AddComponent<Image>();
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
           c.sprite = LookupSprite("Blue_Metal");
        }
        { var c = goMap[-8953747061721227556L].AddComponent<Image>();
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
           c.sprite = LookupSprite("Red_Metal");
        }
        { var c = goMap[-5725086431433319793L].AddComponent<Text>();
           c.text = "42788";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 60;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 5;
           c.resizeTextMaxSize = 202;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-5725086431433319793L].AddComponent<Outline>();
           c.effectColor = new Color(0.518868f, 0.276094f, 0.198247f, 0.815686f);
           c.effectDistance = new Vector2(2.000000f, 2.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var g = goMap[-5725086431433319793L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.988678f, 1.000000f, 0.863208f, 1.000000f); }
        { var c = goMap[3453597695561703720L].AddComponent<Text>();
           c.text = "42788";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 60;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 5;
           c.resizeTextMaxSize = 202;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[3453597695561703720L].AddComponent<Outline>();
           c.effectColor = new Color(0.518868f, 0.276094f, 0.198247f, 0.815686f);
           c.effectDistance = new Vector2(2.000000f, 2.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var g = goMap[3453597695561703720L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.988678f, 1.000000f, 0.863208f, 1.000000f); }
        { var c = goMap[7558215906013124814L].AddComponent<Text>();
           c.text = "42792";
           c.color = new Color(0.054902f, 0.984314f, 0.054902f, 1.000000f);
           c.fontSize = 18;
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
        { var c = goMap[1361004898752446676L].AddComponent<Image>();
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
        { var c = goMap[-3162516049482321517L].AddComponent<Image>();
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
        { var c = goMap[8306127775595398698L].AddComponent<Image>();
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
        { var c = goMap[-3756162196483723447L].AddComponent<Image>();
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
           c.sprite = LookupSprite("BG_BlueLine");
        }
        { var c = goMap[294629011539261058L].AddComponent<Image>();
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
           c.sprite = LookupSprite("BG_RedLine");
        }
        { var c = goMap[450530573786936732L].AddComponent<Image>();
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
           c.sprite = LookupSprite("BG_HuaWen");
        }
        { var c = goMap[105830929750971316L].AddComponent<Image>();
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
        { var c = goMap[-4605474477655128744L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("DrawEffect"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[-2471261623395068496L].AddComponent<Image>();
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
           c.sprite = LookupSprite("BG_Metal");
        }
        { var c = goMap[3795461683082059577L].AddComponent<Image>();
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
           c.sprite = LookupSprite("BG_Metal");
        }
        { var c = goMap[-2340782766390483293L].AddComponent<Image>();
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
        { var c = goMap[-9071473782348700067L].AddComponent<Image>();
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
        { var c = goMap[-5016114011965181486L].AddComponent<Image>();
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
        { var c = goMap[-5889604305864907356L].AddComponent<Image>();
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
        { var c = goMap[172367045147299582L].AddComponent<Image>();
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
           c.sprite = LookupSprite("Draw_Metal");
        }
        { var c = goMap[8776302537700400085L].AddComponent<Image>();
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
           c.sprite = LookupSprite("Draw_Metal");
        }
        { var c = goMap[7803631156686637614L].AddComponent<Image>();
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
           c.sprite = LookupSprite("BG_GlowBlue");
        }
        { var c = goMap[8593932820660588545L].AddComponent<Image>();
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
           c.sprite = LookupSprite("BG_GlowRed");
        }
        { var c = goMap[-5275482794238128886L].AddComponent<Image>();
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
        { var c = goMap[-119379952709723457L].AddComponent<Image>();
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
           c.sprite = LookupSprite("BG_BlueLine");
        }
        { var c = goMap[-7217358657160244274L].AddComponent<Image>();
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
           c.sprite = LookupSprite("BG_RedLine");
        }
        { var c = goMap[6099669255969927281L].AddComponent<Image>();
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
           c.sprite = LookupSprite("BG_HuaWen");
        }
        { var c = goMap[1257179498954214446L].AddComponent<Image>();
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
           c.sprite = LookupSprite("RedSword");
        }
        { var c = goMap[-5124942242176774516L].AddComponent<Image>();
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
           c.sprite = LookupSprite("BlueSword");
        }
        { var c = goMap[-3977737507305443799L].AddComponent<Text>();
           c.text = "16271";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 60;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 6;
           c.resizeTextMaxSize = 202;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-3977737507305443799L].AddComponent<Outline>();
           c.effectColor = new Color(0.450980f, 0.314883f, 0.200000f, 0.815686f);
           c.effectDistance = new Vector2(3.000000f, 3.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var g = goMap[-3977737507305443799L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(1.000000f, 0.889936f, 0.552941f, 1.000000f); }
        { var c = goMap[8026671466016902728L].AddComponent<Text>();
           c.text = "16271";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.000000f);
           c.fontSize = 80;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 6;
           c.resizeTextMaxSize = 202;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var g = goMap[8026671466016902728L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.988678f, 1.000000f, 0.863208f, 1.000000f); }
        { var c = goMap[-6504155991101315054L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(0.054902f, 0.984314f, 0.054902f, 1.000000f);
           c.fontSize = 18;
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
        { var c = goMap[7420228266637859512L].AddComponent<Image>();
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
        { var c = goMap[7420228266637859512L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[7420228266637859512L].AddComponent<UIScalePulse>();
           c.upScale = 0.950000f; c.duration = 0.100000f; c.scaleUp = false;
           c.enabled = true;
        }
        { var c = goMap[-6961562662614301415L].AddComponent<Text>();
           c.text = "42785";
           c.color = new Color(0.113725f, 0.309804f, 0.321569f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Bold;
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
        { var c = goMap[7465586058000088774L].AddComponent<CanvasGroup>();
           c.alpha = 1.000000f;
           c.interactable = true;
           c.blocksRaycasts = true;
           c.ignoreParentGroups = false;
        }
        { var c = goMap[4922310201327424995L].AddComponent<Image>();
           c.color = new Color(0.149020f, 0.184314f, 0.560784f, 1.000000f);
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
        { var c = goMap[-1115911883448335651L].AddComponent<Text>();
           c.text = "16124";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 22;
           c.fontStyle = FontStyle.Bold;
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
        { var c = goMap[1559184296236093371L].AddComponent<VerticalLayoutGroup>();
           c.padding = new RectOffset(0,0,0,0);
           c.spacing = 10.100000f;
           c.childAlignment = (TextAnchor)0;
           c.childForceExpandWidth = false;
           c.childForceExpandHeight = false;
           c.childControlWidth = false;
           c.childControlHeight = false;
           c.reverseArrangement = false;
        }
        { var c = goMap[-8125837768278707682L].AddComponent<Image>();
           c.color = new Color(0.372549f, 0.545098f, 0.552941f, 0.000000f);
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
        { var c = goMap[-8125837768278707682L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[4938678500959952648L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.639216f);
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
           c.sprite = LookupSprite("img_listbg01");
        }
        { var c = goMap[-7321048092984497837L].AddComponent<Text>();
           c.text = "14942";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
           c.fontSize = 22;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleLeft;
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
        { var c = goMap[160596153764956185L].AddComponent<Image>();
           c.color = new Color(1f,1f,1f,0f);
           c.raycastTarget = true;
           c.maskable = true;
           c.enabled = true;
        }
        { var c = goMap[160596153764956185L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-6548088098183714908L].AddComponent<Image>();
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
        { var c = goMap[-8159720228654337436L].AddComponent<Image>();
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
        { var c = goMap[-8159720228654337436L].AddComponent<Mask>();
           c.showMaskGraphic = true;
           c.enabled = true;
        }
        { var c = goMap[8264518061686953219L].AddComponent<Image>();
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
        { var c = goMap[-5304899471738225166L].AddComponent<Image>();
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
        { var c = goMap[3353665947234687223L].AddComponent<Text>();
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
        { var c = goMap[3353665947234687223L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-1008786526713200685L].AddComponent<Image>();
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
           c.sprite = LookupSprite("v15");
        }
        { var c = goMap[-474284659334728111L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_hednum_bg");
        }
        { var c = goMap[7368914373586523362L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(0.176471f, 0.925490f, 0.282353f, 1.000000f);
           c.fontSize = 20;
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
        { var c = goMap[7368914373586523362L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.400000f);
           c.effectDistance = new Vector2(2.000000f, -2.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-6563695789993973661L].AddComponent<Text>();
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
        { var g = goMap[-6563695789993973661L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.996078f, 0.847059f, 0.984314f, 1.000000f); }
        { var c = goMap[-6563695789993973661L].AddComponent<Outline>();
           c.effectColor = new Color(0.505882f, 0.090196f, 0.498039f, 1.000000f);
           c.effectDistance = new Vector2(1.500000f, -1.500000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[5142014136674964623L].AddComponent<Image>();
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
        { var c = goMap[7660394797667502191L].AddComponent<CanvasGroup>();
           c.alpha = 1.000000f;
           c.interactable = true;
           c.blocksRaycasts = true;
           c.ignoreParentGroups = false;
        }
        { var c = goMap[5139450922551537535L].AddComponent<Text>();
           c.text = "2818";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleLeft;
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
        { var c = goMap[-2323307331607013020L].AddComponent<Text>();
           c.text = "11684";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleLeft;
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
        { var c = goMap[-4542577707788328303L].AddComponent<CanvasGroup>();
           c.alpha = 1.000000f;
           c.interactable = true;
           c.blocksRaycasts = true;
           c.ignoreParentGroups = false;
        }
        { var c = goMap[-4422224507333878224L].AddComponent<Text>();
           c.text = "15302";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleLeft;
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
        { var c = goMap[-6992372788664983378L].AddComponent<Text>();
           c.text = "10754";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleLeft;
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
        { var c = goMap[-8657041082432049055L].AddComponent<Image>();
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
           c.sprite = LookupSprite("btn_liansai_normal");
        }
        { var c = goMap[-8657041082432049055L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-4244189568723436854L].AddComponent<Image>();
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
           c.sprite = LookupSprite("btn_liansai_normal");
        }
        { var c = goMap[-4244189568723436854L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-119068930186243769L].AddComponent<Text>();
           c.text = "42790";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
           c.fontSize = 22;
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
        { var c = goMap[-8497141645377787364L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_LabelWin");
        }
        { var c = goMap[8778080051506401960L].AddComponent<Image>();
           c.color = new Color(0.149020f, 0.321569f, 0.560784f, 0.352941f);
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
        { var c = goMap[-8138379562096505358L].AddComponent<Image>();
           c.color = new Color(0.121569f, 0.411765f, 1.000000f, 1.000000f);
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
        { var c = goMap[-3408413553799519017L].AddComponent<Text>();
           c.text = "42786";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Bold;
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
        { var c = goMap[-6851029706957163737L].AddComponent<Image>();
           c.color = new Color(0.149020f, 0.321569f, 0.560784f, 0.352941f);
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
        { var c = goMap[-3294428624243169502L].AddComponent<Image>();
           c.color = new Color(0.121569f, 0.411765f, 1.000000f, 1.000000f);
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
        { var c = goMap[-6785735016372639179L].AddComponent<Text>();
           c.text = "42787";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Bold;
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
        { var c = goMap[-7365800675109892040L].AddComponent<Image>();
           c.color = new Color(0.149020f, 0.321569f, 0.560784f, 0.352941f);
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
        { var c = goMap[2905952232254738162L].AddComponent<Image>();
           c.color = new Color(0.121569f, 0.411765f, 1.000000f, 1.000000f);
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
        { var c = goMap[6078531385713533509L].AddComponent<Text>();
           c.text = "42795";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Bold;
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
        { var c = goMap[496055563929648742L].AddComponent<Image>();
           c.color = new Color(0.149020f, 0.321569f, 0.560784f, 0.352941f);
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
        { var c = goMap[-1227621137874697774L].AddComponent<Image>();
           c.color = new Color(0.121569f, 0.411765f, 1.000000f, 1.000000f);
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
        { var c = goMap[1346506091348681508L].AddComponent<Text>();
           c.text = "42784";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Bold;
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
        { var c = goMap[1566064392881136701L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.615686f);
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
        { var c = goMap[-332179511771152574L].AddComponent<CanvasGroup>();
           c.alpha = 1.000000f;
           c.interactable = true;
           c.blocksRaycasts = true;
           c.ignoreParentGroups = false;
        }
        { var c = goMap[6673018629142148065L].AddComponent<Image>();
           c.color = new Color(0.647059f, 0.141176f, 0.094118f, 1.000000f);
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
        { var c = goMap[-7349370465402979044L].AddComponent<Text>();
           c.text = "16124";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 22;
           c.fontStyle = FontStyle.Bold;
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
        { var c = goMap[6691814768971194727L].AddComponent<VerticalLayoutGroup>();
           c.padding = new RectOffset(0,0,0,0);
           c.spacing = 10.100000f;
           c.childAlignment = (TextAnchor)0;
           c.childForceExpandWidth = false;
           c.childForceExpandHeight = false;
           c.childControlWidth = false;
           c.childControlHeight = false;
           c.reverseArrangement = false;
        }
        { var c = goMap[-1380422878113667968L].AddComponent<Image>();
           c.color = new Color(0.372549f, 0.545098f, 0.552941f, 0.000000f);
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
        { var c = goMap[-1380422878113667968L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-709492796833853249L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.639216f);
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
           c.sprite = LookupSprite("img_listbg01");
        }
        { var c = goMap[7904632379023582000L].AddComponent<Text>();
           c.text = "14942";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
           c.fontSize = 22;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleLeft;
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
        { var c = goMap[-9205327879029624770L].AddComponent<Image>();
           c.color = new Color(1f,1f,1f,0f);
           c.raycastTarget = true;
           c.maskable = true;
           c.enabled = true;
        }
        { var c = goMap[-9205327879029624770L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[5040599177235538469L].AddComponent<Image>();
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
        { var c = goMap[7894479585749807760L].AddComponent<Image>();
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
        { var c = goMap[7894479585749807760L].AddComponent<Mask>();
           c.showMaskGraphic = true;
           c.enabled = true;
        }
        { var c = goMap[2021145524246662191L].AddComponent<Image>();
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
        { var c = goMap[-1292183573080651866L].AddComponent<Image>();
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
        { var c = goMap[-1424909792947784981L].AddComponent<Text>();
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
        { var c = goMap[-1424909792947784981L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-275746101383750061L].AddComponent<Image>();
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
           c.sprite = LookupSprite("v15");
        }
        { var c = goMap[564562545675123515L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_hednum_bg");
        }
        { var c = goMap[6251518469964913984L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(0.176471f, 0.925490f, 0.282353f, 1.000000f);
           c.fontSize = 20;
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
        { var c = goMap[6251518469964913984L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.400000f);
           c.effectDistance = new Vector2(2.000000f, -2.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-4793853822049358486L].AddComponent<Text>();
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
        { var g = goMap[-4793853822049358486L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.996078f, 0.847059f, 0.984314f, 1.000000f); }
        { var c = goMap[-4793853822049358486L].AddComponent<Outline>();
           c.effectColor = new Color(0.505882f, 0.090196f, 0.498039f, 1.000000f);
           c.effectDistance = new Vector2(1.500000f, -1.500000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-6189157304605087176L].AddComponent<Image>();
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
        { var c = goMap[7116569135626935045L].AddComponent<CanvasGroup>();
           c.alpha = 1.000000f;
           c.interactable = true;
           c.blocksRaycasts = true;
           c.ignoreParentGroups = false;
        }
        { var c = goMap[5151406503163289237L].AddComponent<Text>();
           c.text = "2818";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleLeft;
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
        { var c = goMap[7023035217427834341L].AddComponent<Text>();
           c.text = "11684";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleLeft;
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
        { var c = goMap[-459538195822770821L].AddComponent<CanvasGroup>();
           c.alpha = 1.000000f;
           c.interactable = true;
           c.blocksRaycasts = true;
           c.ignoreParentGroups = false;
        }
        { var c = goMap[9135156445230722378L].AddComponent<Text>();
           c.text = "15302";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleLeft;
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
        { var c = goMap[-1151914568119698842L].AddComponent<Text>();
           c.text = "10754";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleLeft;
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
        { var c = goMap[-5910943803449012956L].AddComponent<Image>();
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
           c.sprite = LookupSprite("btn_liansai_normal");
        }
        { var c = goMap[-5910943803449012956L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-5238876571725887807L].AddComponent<Image>();
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
           c.sprite = LookupSprite("btn_liansai_normal");
        }
        { var c = goMap[-5238876571725887807L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-2008330955740574762L].AddComponent<Text>();
           c.text = "42790";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
           c.fontSize = 22;
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
        { var c = goMap[-3974093048727078709L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_LabelWin");
        }
        { var c = goMap[2225219857296705985L].AddComponent<Image>();
           c.color = new Color(0.647059f, 0.172549f, 0.137255f, 0.352941f);
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
        { var c = goMap[2811206142600608215L].AddComponent<Image>();
           c.color = new Color(0.952941f, 0.172549f, 0.152941f, 1.000000f);
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
        { var c = goMap[-6593795009663866144L].AddComponent<Text>();
           c.text = "42786";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Bold;
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
        { var c = goMap[-7657705507547346728L].AddComponent<Image>();
           c.color = new Color(0.647059f, 0.172549f, 0.137255f, 0.352941f);
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
        { var c = goMap[-8932794834924486329L].AddComponent<Image>();
           c.color = new Color(0.952941f, 0.172549f, 0.152941f, 1.000000f);
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
        { var c = goMap[7965078269822874228L].AddComponent<Text>();
           c.text = "42787";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Bold;
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
        { var c = goMap[621878492404309520L].AddComponent<Image>();
           c.color = new Color(0.647059f, 0.172549f, 0.137255f, 0.352941f);
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
        { var c = goMap[4768753396885464892L].AddComponent<Image>();
           c.color = new Color(0.952941f, 0.172549f, 0.152941f, 1.000000f);
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
        { var c = goMap[3513306133997707923L].AddComponent<Text>();
           c.text = "42795";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Bold;
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
        { var c = goMap[4149299542629135470L].AddComponent<Image>();
           c.color = new Color(0.647059f, 0.172549f, 0.137255f, 0.352941f);
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
        { var c = goMap[4499121895303975448L].AddComponent<Image>();
           c.color = new Color(0.952941f, 0.172549f, 0.152941f, 1.000000f);
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
        { var c = goMap[-5284297363748077661L].AddComponent<Text>();
           c.text = "42784";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Bold;
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
        { var c = goMap[1459112613939710407L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.615686f);
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
        { var c = goMap[3453250095787815906L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.349020f);
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

        // ─── Resolve Toggle → ToggleGroup links ─────────────
        foreach (var kv in _toggleGroupLinks)
        {
            ToggleGroup grp;
            if (_toggleGroupByMbPid.TryGetValue(kv.Item2, out grp) && grp != null)
                kv.Item1.group = grp;
        }

        // ─── Save prefab ─────────────────────────────────────
        Directory.CreateDirectory("Assets/Prefabs/Imported");
        var rootGO = goMap[8288932506965247784L];
        string path = "Assets/Prefabs/Imported/UIWuLinLianSaiBattle.prefab";
        PrefabUtility.SaveAsPrefabAsset(rootGO, path);
        Object.DestroyImmediate(rootGO);
        Debug.Log("[Import_res_p_517] Saved " + path);
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