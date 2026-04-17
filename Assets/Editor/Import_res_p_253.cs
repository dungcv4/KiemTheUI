// AUTO-GENERATED from res_p_253.ab — DO NOT EDIT MANUALLY.
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;
using System.Collections.Generic;
using KTO.Game;  // UIJoyStick and other ported KTO scripts

public class Import_res_p_253
{
    [MenuItem("KTO/Import/res_p_253")]
    public static void Build()
    {
        Debug.Log("[Import_res_p_253] Building UIGoldenShell...");

        // ─── Create all GameObjects ───────────────────────────
        var goMap = new Dictionary<long, GameObject>();
        var _toggleGroupByMbPid = new Dictionary<long, ToggleGroup>();
        var _toggleGroupLinks = new List<System.Tuple<Toggle,long>>();
        { var go = new GameObject("UIGoldenShell"); go.SetActive(true); goMap[-530952539511192973L] = go; }
        { var go = new GameObject("node"); go.SetActive(true); goMap[1237544823446787431L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(true); goMap[-7741648411971759812L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(true); goMap[6496384723354867089L] = go; }
        { var go = new GameObject("imgRockingbar"); go.SetActive(true); goMap[-1048173925215314851L] = go; }
        { var go = new GameObject("Title"); go.SetActive(true); goMap[-6409472771210974146L] = go; }
        { var go = new GameObject("txtTitle"); go.SetActive(true); goMap[-8812391881331520679L] = go; }
        { var go = new GameObject("btnHelp"); go.SetActive(true); goMap[-6286371172428373189L] = go; }
        { var go = new GameObject("btnClose"); go.SetActive(true); goMap[7957554589500756767L] = go; }
        { var go = new GameObject("Left"); go.SetActive(true); goMap[-7045675892246741563L] = go; }
        { var go = new GameObject("item01"); go.SetActive(true); goMap[-6959178057277519759L] = go; }
        { var go = new GameObject("imgSelected"); go.SetActive(false); goMap[-2831686508410854079L] = go; }
        { var go = new GameObject("UIItemGrid"); go.SetActive(true); goMap[-2339120959881809807L] = go; }
        { var go = new GameObject("bg"); go.SetActive(false); goMap[5035197687843713640L] = go; }
        { var go = new GameObject("Base"); go.SetActive(true); goMap[-7618770041494257442L] = go; }
        { var go = new GameObject("ItemLayer"); go.SetActive(false); goMap[-2285400191166724421L] = go; }
        { var go = new GameObject("Fragment"); go.SetActive(false); goMap[-2889215052763512915L] = go; }
        { var go = new GameObject("TagNew"); go.SetActive(false); goMap[-1969699695723536218L] = go; }
        { var go = new GameObject("LabelSuffix"); go.SetActive(true); goMap[6564889592374029765L] = go; }
        { var go = new GameObject("txtRBCorner"); go.SetActive(false); goMap[2511512401151602561L] = go; }
        { var go = new GameObject("txtCenter"); go.SetActive(false); goMap[3382658767223394837L] = go; }
        { var go = new GameObject("txtLTCorner"); go.SetActive(false); goMap[-35018585859007955L] = go; }
        { var go = new GameObject("ImgLTCorner"); go.SetActive(false); goMap[7221797610359877000L] = go; }
        { var go = new GameObject("CDLayer"); go.SetActive(true); goMap[-2821348471682522009L] = go; }
        { var go = new GameObject("imgPlus"); go.SetActive(false); goMap[-1676785437452364397L] = go; }
        { var go = new GameObject("TagTip"); go.SetActive(false); goMap[2373032883546668414L] = go; }
        { var go = new GameObject("TagCanDeal"); go.SetActive(false); goMap[-4619890912434326870L] = go; }
        { var go = new GameObject("TagMarketStall"); go.SetActive(false); goMap[6785202751957544351L] = go; }
        { var go = new GameObject("TagStone"); go.SetActive(false); goMap[2751685217077241257L] = go; }
        { var go = new GameObject("TagZhenJue"); go.SetActive(false); goMap[2756910226099145686L] = go; }
        { var go = new GameObject("ImgRedPoint"); go.SetActive(false); goMap[-9185651290367197905L] = go; }
        { var go = new GameObject("TagEquipSeries"); go.SetActive(false); goMap[-8385832109621459112L] = go; }
        { var go = new GameObject("Enhance"); go.SetActive(true); goMap[-4763436585626852253L] = go; }
        { var go = new GameObject("imgRankBg"); go.SetActive(false); goMap[-2645216112389681032L] = go; }
        { var go = new GameObject("txtRank"); go.SetActive(true); goMap[2453440394282108337L] = go; }
        { var go = new GameObject("imgRankSeries"); go.SetActive(false); goMap[468678153841821433L] = go; }
        { var go = new GameObject("txtRank"); go.SetActive(true); goMap[5646725436785184187L] = go; }
        { var go = new GameObject("ImgDivineWeaponLV"); go.SetActive(false); goMap[6460721506743374230L] = go; }
        { var go = new GameObject("TxtLV"); go.SetActive(true); goMap[-7451192948842942841L] = go; }
        { var go = new GameObject("imgQuestionMark"); go.SetActive(false); goMap[1354625941047378844L] = go; }
        { var go = new GameObject("Higher"); go.SetActive(false); goMap[-8738706388075742723L] = go; }
        { var go = new GameObject("LabelHushi"); go.SetActive(false); goMap[935514795542420135L] = go; }
        { var go = new GameObject("ImgSelect"); go.SetActive(false); goMap[-7594359136338575651L] = go; }
        { var go = new GameObject("ImgSelect"); go.SetActive(true); goMap[3731212983796224572L] = go; }
        { var go = new GameObject("ImgSelect (1)"); go.SetActive(true); goMap[-392737364501195896L] = go; }
        { var go = new GameObject("item02"); go.SetActive(true); goMap[2841613070133622032L] = go; }
        { var go = new GameObject("imgSelected"); go.SetActive(false); goMap[-4988810074645023889L] = go; }
        { var go = new GameObject("UIItemGrid"); go.SetActive(true); goMap[2047340335599326728L] = go; }
        { var go = new GameObject("bg"); go.SetActive(false); goMap[6709104194550122760L] = go; }
        { var go = new GameObject("Base"); go.SetActive(true); goMap[-7785397558308939797L] = go; }
        { var go = new GameObject("ItemLayer"); go.SetActive(false); goMap[-2692911843489492650L] = go; }
        { var go = new GameObject("Fragment"); go.SetActive(false); goMap[-5659479714504479972L] = go; }
        { var go = new GameObject("TagNew"); go.SetActive(false); goMap[828417171665754036L] = go; }
        { var go = new GameObject("LabelSuffix"); go.SetActive(true); goMap[4003942894495324816L] = go; }
        { var go = new GameObject("txtRBCorner"); go.SetActive(false); goMap[7160229399895744252L] = go; }
        { var go = new GameObject("txtCenter"); go.SetActive(false); goMap[-4427178065573516104L] = go; }
        { var go = new GameObject("txtLTCorner"); go.SetActive(false); goMap[-4265867431189302692L] = go; }
        { var go = new GameObject("ImgLTCorner"); go.SetActive(false); goMap[-3509482534033452089L] = go; }
        { var go = new GameObject("CDLayer"); go.SetActive(true); goMap[1753955458329894587L] = go; }
        { var go = new GameObject("imgPlus"); go.SetActive(false); goMap[-1411144917474042382L] = go; }
        { var go = new GameObject("TagTip"); go.SetActive(false); goMap[-4304784207304754494L] = go; }
        { var go = new GameObject("TagCanDeal"); go.SetActive(false); goMap[3935547857572528056L] = go; }
        { var go = new GameObject("TagMarketStall"); go.SetActive(false); goMap[-1291571388378402241L] = go; }
        { var go = new GameObject("TagStone"); go.SetActive(false); goMap[-1038525985385277067L] = go; }
        { var go = new GameObject("TagZhenJue"); go.SetActive(false); goMap[-6923880281196046419L] = go; }
        { var go = new GameObject("ImgRedPoint"); go.SetActive(false); goMap[-7037674693110203753L] = go; }
        { var go = new GameObject("TagEquipSeries"); go.SetActive(false); goMap[-2510395457031808888L] = go; }
        { var go = new GameObject("Enhance"); go.SetActive(true); goMap[8482495998215746989L] = go; }
        { var go = new GameObject("imgRankBg"); go.SetActive(false); goMap[-6163183374181559442L] = go; }
        { var go = new GameObject("txtRank"); go.SetActive(true); goMap[-812954737358892092L] = go; }
        { var go = new GameObject("imgRankSeries"); go.SetActive(false); goMap[-2342273936036781804L] = go; }
        { var go = new GameObject("txtRank"); go.SetActive(true); goMap[117384091583299352L] = go; }
        { var go = new GameObject("ImgDivineWeaponLV"); go.SetActive(false); goMap[-4057634697521165401L] = go; }
        { var go = new GameObject("TxtLV"); go.SetActive(true); goMap[-5747343911105630032L] = go; }
        { var go = new GameObject("imgQuestionMark"); go.SetActive(false); goMap[4577149306098047836L] = go; }
        { var go = new GameObject("Higher"); go.SetActive(false); goMap[1365903304797663523L] = go; }
        { var go = new GameObject("LabelHushi"); go.SetActive(false); goMap[8513276619107819192L] = go; }
        { var go = new GameObject("ImgSelect"); go.SetActive(false); goMap[8052279758503742616L] = go; }
        { var go = new GameObject("ImgSelect"); go.SetActive(true); goMap[-8713228793197791329L] = go; }
        { var go = new GameObject("ImgSelect (1)"); go.SetActive(true); goMap[-7977801324917535485L] = go; }
        { var go = new GameObject("item03"); go.SetActive(true); goMap[8235924642477159862L] = go; }
        { var go = new GameObject("imgSelected"); go.SetActive(false); goMap[2644630784343507100L] = go; }
        { var go = new GameObject("UIItemGrid"); go.SetActive(true); goMap[-780696193793809583L] = go; }
        { var go = new GameObject("bg"); go.SetActive(false); goMap[-2199055589934537373L] = go; }
        { var go = new GameObject("Base"); go.SetActive(true); goMap[-6259935470873015027L] = go; }
        { var go = new GameObject("ItemLayer"); go.SetActive(false); goMap[-5707403456316849769L] = go; }
        { var go = new GameObject("Fragment"); go.SetActive(false); goMap[-1354096351710242146L] = go; }
        { var go = new GameObject("TagNew"); go.SetActive(false); goMap[-9178270468901734932L] = go; }
        { var go = new GameObject("LabelSuffix"); go.SetActive(true); goMap[-7277837998518740561L] = go; }
        { var go = new GameObject("txtRBCorner"); go.SetActive(false); goMap[5179008744008519177L] = go; }
        { var go = new GameObject("txtCenter"); go.SetActive(false); goMap[-4168760214318772541L] = go; }
        { var go = new GameObject("txtLTCorner"); go.SetActive(false); goMap[-2306850403838867871L] = go; }
        { var go = new GameObject("ImgLTCorner"); go.SetActive(false); goMap[3886011940583801547L] = go; }
        { var go = new GameObject("CDLayer"); go.SetActive(true); goMap[8903288092914796881L] = go; }
        { var go = new GameObject("imgPlus"); go.SetActive(false); goMap[2943435199980712421L] = go; }
        { var go = new GameObject("TagTip"); go.SetActive(false); goMap[-7103388226694789436L] = go; }
        { var go = new GameObject("TagCanDeal"); go.SetActive(false); goMap[-3019447615700983432L] = go; }
        { var go = new GameObject("TagMarketStall"); go.SetActive(false); goMap[6095395030151942335L] = go; }
        { var go = new GameObject("TagStone"); go.SetActive(false); goMap[5929353036565012880L] = go; }
        { var go = new GameObject("TagZhenJue"); go.SetActive(false); goMap[5909346670532762525L] = go; }
        { var go = new GameObject("ImgRedPoint"); go.SetActive(false); goMap[887708270330023763L] = go; }
        { var go = new GameObject("TagEquipSeries"); go.SetActive(false); goMap[5580234528742680754L] = go; }
        { var go = new GameObject("Enhance"); go.SetActive(true); goMap[3261085653812602634L] = go; }
        { var go = new GameObject("imgRankBg"); go.SetActive(false); goMap[-5217579735090019196L] = go; }
        { var go = new GameObject("txtRank"); go.SetActive(true); goMap[-993483133408869621L] = go; }
        { var go = new GameObject("imgRankSeries"); go.SetActive(false); goMap[-8220143743773992068L] = go; }
        { var go = new GameObject("txtRank"); go.SetActive(true); goMap[1128440315632879086L] = go; }
        { var go = new GameObject("ImgDivineWeaponLV"); go.SetActive(false); goMap[6953557680374727160L] = go; }
        { var go = new GameObject("TxtLV"); go.SetActive(true); goMap[-1170435407500132975L] = go; }
        { var go = new GameObject("imgQuestionMark"); go.SetActive(false); goMap[2986583290605097019L] = go; }
        { var go = new GameObject("Higher"); go.SetActive(false); goMap[-904286889202515445L] = go; }
        { var go = new GameObject("LabelHushi"); go.SetActive(false); goMap[6173264726392118532L] = go; }
        { var go = new GameObject("ImgSelect"); go.SetActive(false); goMap[3898238631152543171L] = go; }
        { var go = new GameObject("ImgSelect"); go.SetActive(true); goMap[539141545454901718L] = go; }
        { var go = new GameObject("ImgSelect (1)"); go.SetActive(true); goMap[7389679714594753712L] = go; }
        { var go = new GameObject("item04"); go.SetActive(true); goMap[1818598192170335006L] = go; }
        { var go = new GameObject("imgSelected"); go.SetActive(false); goMap[4756118330947438947L] = go; }
        { var go = new GameObject("UIItemGrid"); go.SetActive(true); goMap[-2969254269191482076L] = go; }
        { var go = new GameObject("bg"); go.SetActive(false); goMap[-2747133590769654289L] = go; }
        { var go = new GameObject("Base"); go.SetActive(true); goMap[3316991072999543507L] = go; }
        { var go = new GameObject("ItemLayer"); go.SetActive(false); goMap[-1056932844143038560L] = go; }
        { var go = new GameObject("Fragment"); go.SetActive(false); goMap[-6185558515373789866L] = go; }
        { var go = new GameObject("TagNew"); go.SetActive(false); goMap[-2462332175542322340L] = go; }
        { var go = new GameObject("LabelSuffix"); go.SetActive(true); goMap[1650209262349969699L] = go; }
        { var go = new GameObject("txtRBCorner"); go.SetActive(false); goMap[-5129925588215870390L] = go; }
        { var go = new GameObject("txtCenter"); go.SetActive(false); goMap[-2991514388471886352L] = go; }
        { var go = new GameObject("txtLTCorner"); go.SetActive(false); goMap[-1068832718366549766L] = go; }
        { var go = new GameObject("ImgLTCorner"); go.SetActive(false); goMap[7737591243062095058L] = go; }
        { var go = new GameObject("CDLayer"); go.SetActive(true); goMap[3607688411957492950L] = go; }
        { var go = new GameObject("imgPlus"); go.SetActive(false); goMap[-3849952560644415644L] = go; }
        { var go = new GameObject("TagTip"); go.SetActive(false); goMap[-6273487276266295590L] = go; }
        { var go = new GameObject("TagCanDeal"); go.SetActive(false); goMap[7741378695028675943L] = go; }
        { var go = new GameObject("TagMarketStall"); go.SetActive(false); goMap[-3477028317645482911L] = go; }
        { var go = new GameObject("TagStone"); go.SetActive(false); goMap[1886090582131228065L] = go; }
        { var go = new GameObject("TagZhenJue"); go.SetActive(false); goMap[6327078442107999798L] = go; }
        { var go = new GameObject("ImgRedPoint"); go.SetActive(false); goMap[7073356767125253036L] = go; }
        { var go = new GameObject("TagEquipSeries"); go.SetActive(false); goMap[3542421210518926120L] = go; }
        { var go = new GameObject("Enhance"); go.SetActive(true); goMap[406455628800584870L] = go; }
        { var go = new GameObject("imgRankBg"); go.SetActive(false); goMap[-8150748596911203672L] = go; }
        { var go = new GameObject("txtRank"); go.SetActive(true); goMap[-74868981596848676L] = go; }
        { var go = new GameObject("imgRankSeries"); go.SetActive(false); goMap[-5571368072696524685L] = go; }
        { var go = new GameObject("txtRank"); go.SetActive(true); goMap[4274259126662576580L] = go; }
        { var go = new GameObject("ImgDivineWeaponLV"); go.SetActive(false); goMap[6607367121880594206L] = go; }
        { var go = new GameObject("TxtLV"); go.SetActive(true); goMap[8381002780691030183L] = go; }
        { var go = new GameObject("imgQuestionMark"); go.SetActive(false); goMap[-5217367109159946479L] = go; }
        { var go = new GameObject("Higher"); go.SetActive(false); goMap[7273965044490187946L] = go; }
        { var go = new GameObject("LabelHushi"); go.SetActive(false); goMap[-3797229454583386668L] = go; }
        { var go = new GameObject("ImgSelect"); go.SetActive(false); goMap[4225400851029987153L] = go; }
        { var go = new GameObject("ImgSelect"); go.SetActive(true); goMap[5968032313552453206L] = go; }
        { var go = new GameObject("ImgSelect (1)"); go.SetActive(true); goMap[-629706803690471377L] = go; }
        { var go = new GameObject("item05"); go.SetActive(true); goMap[3203654569723708702L] = go; }
        { var go = new GameObject("imgSelected"); go.SetActive(false); goMap[-4004919049465411750L] = go; }
        { var go = new GameObject("UIItemGrid"); go.SetActive(true); goMap[4194297304323543147L] = go; }
        { var go = new GameObject("bg"); go.SetActive(false); goMap[-3783771068485415084L] = go; }
        { var go = new GameObject("Base"); go.SetActive(true); goMap[6502516323095144277L] = go; }
        { var go = new GameObject("ItemLayer"); go.SetActive(false); goMap[-1806627685724413089L] = go; }
        { var go = new GameObject("Fragment"); go.SetActive(false); goMap[7750096041181587338L] = go; }
        { var go = new GameObject("TagNew"); go.SetActive(false); goMap[-45981857361267538L] = go; }
        { var go = new GameObject("LabelSuffix"); go.SetActive(true); goMap[3583785882062999907L] = go; }
        { var go = new GameObject("txtRBCorner"); go.SetActive(false); goMap[1854188323772268177L] = go; }
        { var go = new GameObject("txtCenter"); go.SetActive(false); goMap[-2707144691636398801L] = go; }
        { var go = new GameObject("txtLTCorner"); go.SetActive(false); goMap[6819031330683157589L] = go; }
        { var go = new GameObject("ImgLTCorner"); go.SetActive(false); goMap[5482651682701006359L] = go; }
        { var go = new GameObject("CDLayer"); go.SetActive(true); goMap[4797636452550945659L] = go; }
        { var go = new GameObject("imgPlus"); go.SetActive(false); goMap[-8087478530635953379L] = go; }
        { var go = new GameObject("TagTip"); go.SetActive(false); goMap[-4057624814627753876L] = go; }
        { var go = new GameObject("TagCanDeal"); go.SetActive(false); goMap[1277088060254502308L] = go; }
        { var go = new GameObject("TagMarketStall"); go.SetActive(false); goMap[-5511441829023179228L] = go; }
        { var go = new GameObject("TagStone"); go.SetActive(false); goMap[2094144939881200617L] = go; }
        { var go = new GameObject("TagZhenJue"); go.SetActive(false); goMap[7368225251734086024L] = go; }
        { var go = new GameObject("ImgRedPoint"); go.SetActive(false); goMap[-3048984516186313070L] = go; }
        { var go = new GameObject("TagEquipSeries"); go.SetActive(false); goMap[-8889852562522881302L] = go; }
        { var go = new GameObject("Enhance"); go.SetActive(true); goMap[-1839315582462150938L] = go; }
        { var go = new GameObject("imgRankBg"); go.SetActive(false); goMap[5368793025668648731L] = go; }
        { var go = new GameObject("txtRank"); go.SetActive(true); goMap[-2975432711635616719L] = go; }
        { var go = new GameObject("imgRankSeries"); go.SetActive(false); goMap[4248838317101648056L] = go; }
        { var go = new GameObject("txtRank"); go.SetActive(true); goMap[-6246364200537742906L] = go; }
        { var go = new GameObject("ImgDivineWeaponLV"); go.SetActive(false); goMap[-5280317836490420235L] = go; }
        { var go = new GameObject("TxtLV"); go.SetActive(true); goMap[6919660766227727534L] = go; }
        { var go = new GameObject("imgQuestionMark"); go.SetActive(false); goMap[-5542171321853228168L] = go; }
        { var go = new GameObject("Higher"); go.SetActive(false); goMap[-2298401924145024944L] = go; }
        { var go = new GameObject("LabelHushi"); go.SetActive(false); goMap[-4187379582435832753L] = go; }
        { var go = new GameObject("ImgSelect"); go.SetActive(false); goMap[-8935351006806585305L] = go; }
        { var go = new GameObject("ImgSelect"); go.SetActive(true); goMap[-2753218195425567341L] = go; }
        { var go = new GameObject("ImgSelect (1)"); go.SetActive(true); goMap[1531864095864878732L] = go; }
        { var go = new GameObject("item06"); go.SetActive(true); goMap[-6557785430215885438L] = go; }
        { var go = new GameObject("imgSelected"); go.SetActive(false); goMap[-6244949745423807786L] = go; }
        { var go = new GameObject("UIItemGrid"); go.SetActive(true); goMap[-1660032452913207623L] = go; }
        { var go = new GameObject("bg"); go.SetActive(false); goMap[3859934498748265959L] = go; }
        { var go = new GameObject("Base"); go.SetActive(true); goMap[258547390643155568L] = go; }
        { var go = new GameObject("ItemLayer"); go.SetActive(false); goMap[4350287868858106684L] = go; }
        { var go = new GameObject("Fragment"); go.SetActive(false); goMap[2518129077057491871L] = go; }
        { var go = new GameObject("TagNew"); go.SetActive(false); goMap[-7468606049957495883L] = go; }
        { var go = new GameObject("LabelSuffix"); go.SetActive(true); goMap[5536058534585205598L] = go; }
        { var go = new GameObject("txtRBCorner"); go.SetActive(false); goMap[-2915357637535509381L] = go; }
        { var go = new GameObject("txtCenter"); go.SetActive(false); goMap[-4013312492994039685L] = go; }
        { var go = new GameObject("txtLTCorner"); go.SetActive(false); goMap[5578147471128079548L] = go; }
        { var go = new GameObject("ImgLTCorner"); go.SetActive(false); goMap[5200651765324398648L] = go; }
        { var go = new GameObject("CDLayer"); go.SetActive(true); goMap[3585479898826806734L] = go; }
        { var go = new GameObject("imgPlus"); go.SetActive(false); goMap[-8235555614972968260L] = go; }
        { var go = new GameObject("TagTip"); go.SetActive(false); goMap[-4808438553405592758L] = go; }
        { var go = new GameObject("TagCanDeal"); go.SetActive(false); goMap[-928689722833608946L] = go; }
        { var go = new GameObject("TagMarketStall"); go.SetActive(false); goMap[-1491615210035932463L] = go; }
        { var go = new GameObject("TagStone"); go.SetActive(false); goMap[1943632073059430502L] = go; }
        { var go = new GameObject("TagZhenJue"); go.SetActive(false); goMap[8581961768108890376L] = go; }
        { var go = new GameObject("ImgRedPoint"); go.SetActive(false); goMap[-6861360801964382209L] = go; }
        { var go = new GameObject("TagEquipSeries"); go.SetActive(false); goMap[-5618775290806992885L] = go; }
        { var go = new GameObject("Enhance"); go.SetActive(true); goMap[1255208121312004112L] = go; }
        { var go = new GameObject("imgRankBg"); go.SetActive(false); goMap[1324437040123722409L] = go; }
        { var go = new GameObject("txtRank"); go.SetActive(true); goMap[5116464727626368434L] = go; }
        { var go = new GameObject("imgRankSeries"); go.SetActive(false); goMap[7612103997383136473L] = go; }
        { var go = new GameObject("txtRank"); go.SetActive(true); goMap[7468409178993271628L] = go; }
        { var go = new GameObject("ImgDivineWeaponLV"); go.SetActive(false); goMap[-4490376897510665074L] = go; }
        { var go = new GameObject("TxtLV"); go.SetActive(true); goMap[6170809084645975647L] = go; }
        { var go = new GameObject("imgQuestionMark"); go.SetActive(false); goMap[-2185328281396515535L] = go; }
        { var go = new GameObject("Higher"); go.SetActive(false); goMap[-621842661251458155L] = go; }
        { var go = new GameObject("LabelHushi"); go.SetActive(false); goMap[-4270564351483450102L] = go; }
        { var go = new GameObject("ImgSelect"); go.SetActive(false); goMap[1877497348024382598L] = go; }
        { var go = new GameObject("ImgSelect"); go.SetActive(true); goMap[4387906694162754338L] = go; }
        { var go = new GameObject("ImgSelect (1)"); go.SetActive(true); goMap[-4164641553595051019L] = go; }
        { var go = new GameObject("item07"); go.SetActive(true); goMap[6886569599195319990L] = go; }
        { var go = new GameObject("imgSelected"); go.SetActive(false); goMap[3569326097188466142L] = go; }
        { var go = new GameObject("UIItemGrid"); go.SetActive(true); goMap[3256290757132076363L] = go; }
        { var go = new GameObject("bg"); go.SetActive(false); goMap[-3206802188326003192L] = go; }
        { var go = new GameObject("Base"); go.SetActive(true); goMap[-7992722351109031519L] = go; }
        { var go = new GameObject("ItemLayer"); go.SetActive(false); goMap[-3703476882474036217L] = go; }
        { var go = new GameObject("Fragment"); go.SetActive(false); goMap[2547725499076561724L] = go; }
        { var go = new GameObject("TagNew"); go.SetActive(false); goMap[-6429517870701096137L] = go; }
        { var go = new GameObject("LabelSuffix"); go.SetActive(true); goMap[-3861307512401056529L] = go; }
        { var go = new GameObject("txtRBCorner"); go.SetActive(false); goMap[-3893583791612394962L] = go; }
        { var go = new GameObject("txtCenter"); go.SetActive(false); goMap[7754430352565921336L] = go; }
        { var go = new GameObject("txtLTCorner"); go.SetActive(false); goMap[5784300124308319141L] = go; }
        { var go = new GameObject("ImgLTCorner"); go.SetActive(false); goMap[-5319570853057360076L] = go; }
        { var go = new GameObject("CDLayer"); go.SetActive(true); goMap[5661331876045189672L] = go; }
        { var go = new GameObject("imgPlus"); go.SetActive(false); goMap[-5725024631616254166L] = go; }
        { var go = new GameObject("TagTip"); go.SetActive(false); goMap[-3914005005258374868L] = go; }
        { var go = new GameObject("TagCanDeal"); go.SetActive(false); goMap[2023878650659462326L] = go; }
        { var go = new GameObject("TagMarketStall"); go.SetActive(false); goMap[6385776964626232266L] = go; }
        { var go = new GameObject("TagStone"); go.SetActive(false); goMap[5478605813741346077L] = go; }
        { var go = new GameObject("TagZhenJue"); go.SetActive(false); goMap[4440391946033369108L] = go; }
        { var go = new GameObject("ImgRedPoint"); go.SetActive(false); goMap[-7658658768117457682L] = go; }
        { var go = new GameObject("TagEquipSeries"); go.SetActive(false); goMap[9191134168714483198L] = go; }
        { var go = new GameObject("Enhance"); go.SetActive(true); goMap[-431245549300961747L] = go; }
        { var go = new GameObject("imgRankBg"); go.SetActive(false); goMap[2185518495806790478L] = go; }
        { var go = new GameObject("txtRank"); go.SetActive(true); goMap[-7310316910746679953L] = go; }
        { var go = new GameObject("imgRankSeries"); go.SetActive(false); goMap[-753186279118087024L] = go; }
        { var go = new GameObject("txtRank"); go.SetActive(true); goMap[-421264179994258120L] = go; }
        { var go = new GameObject("ImgDivineWeaponLV"); go.SetActive(false); goMap[1189418231994101254L] = go; }
        { var go = new GameObject("TxtLV"); go.SetActive(true); goMap[-2522277611558697722L] = go; }
        { var go = new GameObject("imgQuestionMark"); go.SetActive(false); goMap[3019259967916700993L] = go; }
        { var go = new GameObject("Higher"); go.SetActive(false); goMap[6123882577084589483L] = go; }
        { var go = new GameObject("LabelHushi"); go.SetActive(false); goMap[664402229362451315L] = go; }
        { var go = new GameObject("ImgSelect"); go.SetActive(false); goMap[-7650318869590572907L] = go; }
        { var go = new GameObject("ImgSelect"); go.SetActive(true); goMap[2480033360837464480L] = go; }
        { var go = new GameObject("ImgSelect (1)"); go.SetActive(true); goMap[-7366620873748422204L] = go; }
        { var go = new GameObject("item08"); go.SetActive(true); goMap[1595356721993304515L] = go; }
        { var go = new GameObject("imgSelected"); go.SetActive(false); goMap[-5572456803609149599L] = go; }
        { var go = new GameObject("UIItemGrid"); go.SetActive(true); goMap[162078786380344046L] = go; }
        { var go = new GameObject("bg"); go.SetActive(false); goMap[-4459061989411866599L] = go; }
        { var go = new GameObject("Base"); go.SetActive(true); goMap[5389173865562054004L] = go; }
        { var go = new GameObject("ItemLayer"); go.SetActive(false); goMap[-1542549233695943954L] = go; }
        { var go = new GameObject("Fragment"); go.SetActive(false); goMap[-758400158961041734L] = go; }
        { var go = new GameObject("TagNew"); go.SetActive(false); goMap[4251515164245845223L] = go; }
        { var go = new GameObject("LabelSuffix"); go.SetActive(true); goMap[-6636141275141599414L] = go; }
        { var go = new GameObject("txtRBCorner"); go.SetActive(false); goMap[-3508559083789626954L] = go; }
        { var go = new GameObject("txtCenter"); go.SetActive(false); goMap[-6076793695855127581L] = go; }
        { var go = new GameObject("txtLTCorner"); go.SetActive(false); goMap[-8022097623875767155L] = go; }
        { var go = new GameObject("ImgLTCorner"); go.SetActive(false); goMap[3084556461343236870L] = go; }
        { var go = new GameObject("CDLayer"); go.SetActive(true); goMap[-2502804922131173566L] = go; }
        { var go = new GameObject("imgPlus"); go.SetActive(false); goMap[1377975162260520142L] = go; }
        { var go = new GameObject("TagTip"); go.SetActive(false); goMap[-7586487632728244221L] = go; }
        { var go = new GameObject("TagCanDeal"); go.SetActive(false); goMap[-7620775324658509088L] = go; }
        { var go = new GameObject("TagMarketStall"); go.SetActive(false); goMap[7569918802615195081L] = go; }
        { var go = new GameObject("TagStone"); go.SetActive(false); goMap[8654249257387496586L] = go; }
        { var go = new GameObject("TagZhenJue"); go.SetActive(false); goMap[-1147449900313440380L] = go; }
        { var go = new GameObject("ImgRedPoint"); go.SetActive(false); goMap[-7459614203372114148L] = go; }
        { var go = new GameObject("TagEquipSeries"); go.SetActive(false); goMap[4993880972996822887L] = go; }
        { var go = new GameObject("Enhance"); go.SetActive(true); goMap[-7122437874173256294L] = go; }
        { var go = new GameObject("imgRankBg"); go.SetActive(false); goMap[-2878033329699973957L] = go; }
        { var go = new GameObject("txtRank"); go.SetActive(true); goMap[401080732301674078L] = go; }
        { var go = new GameObject("imgRankSeries"); go.SetActive(false); goMap[-2814341700986650808L] = go; }
        { var go = new GameObject("txtRank"); go.SetActive(true); goMap[2710144149694006154L] = go; }
        { var go = new GameObject("ImgDivineWeaponLV"); go.SetActive(false); goMap[-6837416058809651670L] = go; }
        { var go = new GameObject("TxtLV"); go.SetActive(true); goMap[4013423673232460561L] = go; }
        { var go = new GameObject("imgQuestionMark"); go.SetActive(false); goMap[-8950848934434519908L] = go; }
        { var go = new GameObject("Higher"); go.SetActive(false); goMap[-3747978240577390605L] = go; }
        { var go = new GameObject("LabelHushi"); go.SetActive(false); goMap[5448532372314014984L] = go; }
        { var go = new GameObject("ImgSelect"); go.SetActive(false); goMap[-632295598915230293L] = go; }
        { var go = new GameObject("ImgSelect"); go.SetActive(true); goMap[-3247584279771251903L] = go; }
        { var go = new GameObject("ImgSelect (1)"); go.SetActive(true); goMap[5217197697780506563L] = go; }
        { var go = new GameObject("item09"); go.SetActive(true); goMap[1663118642577024934L] = go; }
        { var go = new GameObject("imgSelected"); go.SetActive(false); goMap[-73704323097791350L] = go; }
        { var go = new GameObject("UIItemGrid"); go.SetActive(true); goMap[9205755363516087646L] = go; }
        { var go = new GameObject("bg"); go.SetActive(false); goMap[-1642865896103847093L] = go; }
        { var go = new GameObject("Base"); go.SetActive(true); goMap[-8989895865271480841L] = go; }
        { var go = new GameObject("ItemLayer"); go.SetActive(false); goMap[7274919739472658569L] = go; }
        { var go = new GameObject("Fragment"); go.SetActive(false); goMap[-6474420241397276760L] = go; }
        { var go = new GameObject("TagNew"); go.SetActive(false); goMap[1981196291729700466L] = go; }
        { var go = new GameObject("LabelSuffix"); go.SetActive(true); goMap[6146143904014342779L] = go; }
        { var go = new GameObject("txtRBCorner"); go.SetActive(false); goMap[6206043328514573101L] = go; }
        { var go = new GameObject("txtCenter"); go.SetActive(false); goMap[-900145749982296073L] = go; }
        { var go = new GameObject("txtLTCorner"); go.SetActive(false); goMap[-8345511344440216439L] = go; }
        { var go = new GameObject("ImgLTCorner"); go.SetActive(false); goMap[-8551629439379484552L] = go; }
        { var go = new GameObject("CDLayer"); go.SetActive(true); goMap[7355185180429482560L] = go; }
        { var go = new GameObject("imgPlus"); go.SetActive(false); goMap[-5296215651904924457L] = go; }
        { var go = new GameObject("TagTip"); go.SetActive(false); goMap[-1589268852755538248L] = go; }
        { var go = new GameObject("TagCanDeal"); go.SetActive(false); goMap[-3335551879107124431L] = go; }
        { var go = new GameObject("TagMarketStall"); go.SetActive(false); goMap[-693530954936255824L] = go; }
        { var go = new GameObject("TagStone"); go.SetActive(false); goMap[6272798149034974544L] = go; }
        { var go = new GameObject("TagZhenJue"); go.SetActive(false); goMap[3882805435572226329L] = go; }
        { var go = new GameObject("ImgRedPoint"); go.SetActive(false); goMap[6582776910553710131L] = go; }
        { var go = new GameObject("TagEquipSeries"); go.SetActive(false); goMap[5887803223407278764L] = go; }
        { var go = new GameObject("Enhance"); go.SetActive(true); goMap[-3616659947293336528L] = go; }
        { var go = new GameObject("imgRankBg"); go.SetActive(false); goMap[-7715521518177954685L] = go; }
        { var go = new GameObject("txtRank"); go.SetActive(true); goMap[2434601062884682979L] = go; }
        { var go = new GameObject("imgRankSeries"); go.SetActive(false); goMap[-1922581952339719502L] = go; }
        { var go = new GameObject("txtRank"); go.SetActive(true); goMap[7895873382187774913L] = go; }
        { var go = new GameObject("ImgDivineWeaponLV"); go.SetActive(false); goMap[-194576399171645000L] = go; }
        { var go = new GameObject("TxtLV"); go.SetActive(true); goMap[-2935697758642554993L] = go; }
        { var go = new GameObject("imgQuestionMark"); go.SetActive(false); goMap[2144337918547670652L] = go; }
        { var go = new GameObject("Higher"); go.SetActive(false); goMap[5084932241245459628L] = go; }
        { var go = new GameObject("LabelHushi"); go.SetActive(false); goMap[3933394076467007949L] = go; }
        { var go = new GameObject("ImgSelect"); go.SetActive(false); goMap[-374201911436493508L] = go; }
        { var go = new GameObject("ImgSelect"); go.SetActive(true); goMap[-1025374096136740890L] = go; }
        { var go = new GameObject("ImgSelect (1)"); go.SetActive(true); goMap[8595004814372084585L] = go; }
        { var go = new GameObject("item10"); go.SetActive(true); goMap[-7309444687643116399L] = go; }
        { var go = new GameObject("imgSelected"); go.SetActive(false); goMap[6050447251632985150L] = go; }
        { var go = new GameObject("UIItemGrid"); go.SetActive(true); goMap[-2268300130891209069L] = go; }
        { var go = new GameObject("bg"); go.SetActive(false); goMap[2378326900071587541L] = go; }
        { var go = new GameObject("Base"); go.SetActive(true); goMap[8168369866304933107L] = go; }
        { var go = new GameObject("ItemLayer"); go.SetActive(false); goMap[-5174309534820832584L] = go; }
        { var go = new GameObject("Fragment"); go.SetActive(false); goMap[-8231060882058414772L] = go; }
        { var go = new GameObject("TagNew"); go.SetActive(false); goMap[7373304116156363766L] = go; }
        { var go = new GameObject("LabelSuffix"); go.SetActive(true); goMap[8906195386061717354L] = go; }
        { var go = new GameObject("txtRBCorner"); go.SetActive(false); goMap[7892847533465812692L] = go; }
        { var go = new GameObject("txtCenter"); go.SetActive(false); goMap[-2876244575501082604L] = go; }
        { var go = new GameObject("txtLTCorner"); go.SetActive(false); goMap[-7415099686420225185L] = go; }
        { var go = new GameObject("ImgLTCorner"); go.SetActive(false); goMap[-4864082822081032184L] = go; }
        { var go = new GameObject("CDLayer"); go.SetActive(true); goMap[3427259412550978892L] = go; }
        { var go = new GameObject("imgPlus"); go.SetActive(false); goMap[-799171564556225449L] = go; }
        { var go = new GameObject("TagTip"); go.SetActive(false); goMap[7974702868045624266L] = go; }
        { var go = new GameObject("TagCanDeal"); go.SetActive(false); goMap[-656587985902071198L] = go; }
        { var go = new GameObject("TagMarketStall"); go.SetActive(false); goMap[-980586608958451626L] = go; }
        { var go = new GameObject("TagStone"); go.SetActive(false); goMap[562665163024275017L] = go; }
        { var go = new GameObject("TagZhenJue"); go.SetActive(false); goMap[8333801475305311219L] = go; }
        { var go = new GameObject("ImgRedPoint"); go.SetActive(false); goMap[-5764902720471370084L] = go; }
        { var go = new GameObject("TagEquipSeries"); go.SetActive(false); goMap[5238608587787509558L] = go; }
        { var go = new GameObject("Enhance"); go.SetActive(true); goMap[-7540757176210170787L] = go; }
        { var go = new GameObject("imgRankBg"); go.SetActive(false); goMap[3553685321471580007L] = go; }
        { var go = new GameObject("txtRank"); go.SetActive(true); goMap[-197591211163696369L] = go; }
        { var go = new GameObject("imgRankSeries"); go.SetActive(false); goMap[6984071307798181110L] = go; }
        { var go = new GameObject("txtRank"); go.SetActive(true); goMap[-8374112380971608967L] = go; }
        { var go = new GameObject("ImgDivineWeaponLV"); go.SetActive(false); goMap[1200566845871880307L] = go; }
        { var go = new GameObject("TxtLV"); go.SetActive(true); goMap[-7037641143752962045L] = go; }
        { var go = new GameObject("imgQuestionMark"); go.SetActive(false); goMap[-6037309053294482300L] = go; }
        { var go = new GameObject("Higher"); go.SetActive(false); goMap[-3115327118152154352L] = go; }
        { var go = new GameObject("LabelHushi"); go.SetActive(false); goMap[-6543105446751645424L] = go; }
        { var go = new GameObject("ImgSelect"); go.SetActive(false); goMap[6498122785235064957L] = go; }
        { var go = new GameObject("ImgSelect"); go.SetActive(true); goMap[8362856759373596002L] = go; }
        { var go = new GameObject("ImgSelect (1)"); go.SetActive(true); goMap[109259675198610636L] = go; }
        { var go = new GameObject("item11"); go.SetActive(true); goMap[2965639596179616547L] = go; }
        { var go = new GameObject("imgSelected"); go.SetActive(false); goMap[220428456418758578L] = go; }
        { var go = new GameObject("UIItemGrid"); go.SetActive(true); goMap[-8009926675464430123L] = go; }
        { var go = new GameObject("bg"); go.SetActive(false); goMap[-2555838729817560368L] = go; }
        { var go = new GameObject("Base"); go.SetActive(true); goMap[3264847616176402910L] = go; }
        { var go = new GameObject("ItemLayer"); go.SetActive(false); goMap[7475800658144970975L] = go; }
        { var go = new GameObject("Fragment"); go.SetActive(false); goMap[6418080242586951814L] = go; }
        { var go = new GameObject("TagNew"); go.SetActive(false); goMap[-4080550302726174419L] = go; }
        { var go = new GameObject("LabelSuffix"); go.SetActive(true); goMap[-5714976616510214674L] = go; }
        { var go = new GameObject("txtRBCorner"); go.SetActive(false); goMap[260657172871768196L] = go; }
        { var go = new GameObject("txtCenter"); go.SetActive(false); goMap[7140514509794322496L] = go; }
        { var go = new GameObject("txtLTCorner"); go.SetActive(false); goMap[-4940729278684384457L] = go; }
        { var go = new GameObject("ImgLTCorner"); go.SetActive(false); goMap[-6758392136145104355L] = go; }
        { var go = new GameObject("CDLayer"); go.SetActive(true); goMap[-1980188168636719842L] = go; }
        { var go = new GameObject("imgPlus"); go.SetActive(false); goMap[1945511589896611101L] = go; }
        { var go = new GameObject("TagTip"); go.SetActive(false); goMap[3479838084973489529L] = go; }
        { var go = new GameObject("TagCanDeal"); go.SetActive(false); goMap[3793986255456268988L] = go; }
        { var go = new GameObject("TagMarketStall"); go.SetActive(false); goMap[5150506781369034332L] = go; }
        { var go = new GameObject("TagStone"); go.SetActive(false); goMap[-3935790612616573192L] = go; }
        { var go = new GameObject("TagZhenJue"); go.SetActive(false); goMap[3942483339803346154L] = go; }
        { var go = new GameObject("ImgRedPoint"); go.SetActive(false); goMap[-1658166954870918362L] = go; }
        { var go = new GameObject("TagEquipSeries"); go.SetActive(false); goMap[-575181074648501323L] = go; }
        { var go = new GameObject("Enhance"); go.SetActive(true); goMap[96847911620851889L] = go; }
        { var go = new GameObject("imgRankBg"); go.SetActive(false); goMap[-6583475327188434656L] = go; }
        { var go = new GameObject("txtRank"); go.SetActive(true); goMap[-6136508682829120932L] = go; }
        { var go = new GameObject("imgRankSeries"); go.SetActive(false); goMap[-3234199561606740755L] = go; }
        { var go = new GameObject("txtRank"); go.SetActive(true); goMap[-7315441288776086324L] = go; }
        { var go = new GameObject("ImgDivineWeaponLV"); go.SetActive(false); goMap[531390889013143977L] = go; }
        { var go = new GameObject("TxtLV"); go.SetActive(true); goMap[7481779225232934934L] = go; }
        { var go = new GameObject("imgQuestionMark"); go.SetActive(false); goMap[-8086346586055357343L] = go; }
        { var go = new GameObject("Higher"); go.SetActive(false); goMap[-378640279643211297L] = go; }
        { var go = new GameObject("LabelHushi"); go.SetActive(false); goMap[3199508643747806029L] = go; }
        { var go = new GameObject("ImgSelect"); go.SetActive(false); goMap[-1653104402406472818L] = go; }
        { var go = new GameObject("ImgSelect"); go.SetActive(true); goMap[-5726366200773963988L] = go; }
        { var go = new GameObject("ImgSelect (1)"); go.SetActive(true); goMap[-2823386897994125793L] = go; }
        { var go = new GameObject("item12"); go.SetActive(true); goMap[-7281530768682015014L] = go; }
        { var go = new GameObject("imgSelected"); go.SetActive(false); goMap[-1855929211468115950L] = go; }
        { var go = new GameObject("UIItemGrid"); go.SetActive(true); goMap[-2786361121474131816L] = go; }
        { var go = new GameObject("bg"); go.SetActive(false); goMap[309477125561651569L] = go; }
        { var go = new GameObject("Base"); go.SetActive(true); goMap[3374280535351502192L] = go; }
        { var go = new GameObject("ItemLayer"); go.SetActive(false); goMap[-366850427297400475L] = go; }
        { var go = new GameObject("Fragment"); go.SetActive(false); goMap[-7803183571198445711L] = go; }
        { var go = new GameObject("TagNew"); go.SetActive(false); goMap[-1927688012450094885L] = go; }
        { var go = new GameObject("LabelSuffix"); go.SetActive(true); goMap[139295094796042983L] = go; }
        { var go = new GameObject("txtRBCorner"); go.SetActive(false); goMap[5023509310148843131L] = go; }
        { var go = new GameObject("txtCenter"); go.SetActive(false); goMap[-3365066893982352480L] = go; }
        { var go = new GameObject("txtLTCorner"); go.SetActive(false); goMap[3521491654050434488L] = go; }
        { var go = new GameObject("ImgLTCorner"); go.SetActive(false); goMap[3233412841466314447L] = go; }
        { var go = new GameObject("CDLayer"); go.SetActive(true); goMap[1190175795195419405L] = go; }
        { var go = new GameObject("imgPlus"); go.SetActive(false); goMap[-7988713809276816343L] = go; }
        { var go = new GameObject("TagTip"); go.SetActive(false); goMap[5055907786938158942L] = go; }
        { var go = new GameObject("TagCanDeal"); go.SetActive(false); goMap[-7351918411705901345L] = go; }
        { var go = new GameObject("TagMarketStall"); go.SetActive(false); goMap[-123076985158000013L] = go; }
        { var go = new GameObject("TagStone"); go.SetActive(false); goMap[-6024470738857561803L] = go; }
        { var go = new GameObject("TagZhenJue"); go.SetActive(false); goMap[4645460277573699346L] = go; }
        { var go = new GameObject("ImgRedPoint"); go.SetActive(false); goMap[-1611572446160023218L] = go; }
        { var go = new GameObject("TagEquipSeries"); go.SetActive(false); goMap[342241789552109340L] = go; }
        { var go = new GameObject("Enhance"); go.SetActive(true); goMap[7212110131603294907L] = go; }
        { var go = new GameObject("imgRankBg"); go.SetActive(false); goMap[4645359045161815676L] = go; }
        { var go = new GameObject("txtRank"); go.SetActive(true); goMap[-8042487701915378318L] = go; }
        { var go = new GameObject("imgRankSeries"); go.SetActive(false); goMap[-4712080362788068618L] = go; }
        { var go = new GameObject("txtRank"); go.SetActive(true); goMap[-2084517210091289812L] = go; }
        { var go = new GameObject("ImgDivineWeaponLV"); go.SetActive(false); goMap[331772348087123986L] = go; }
        { var go = new GameObject("TxtLV"); go.SetActive(true); goMap[-9168339921928156106L] = go; }
        { var go = new GameObject("imgQuestionMark"); go.SetActive(false); goMap[7635564418589756352L] = go; }
        { var go = new GameObject("Higher"); go.SetActive(false); goMap[-3504544829515422575L] = go; }
        { var go = new GameObject("LabelHushi"); go.SetActive(false); goMap[4678314847436373733L] = go; }
        { var go = new GameObject("ImgSelect"); go.SetActive(false); goMap[6207036371573398290L] = go; }
        { var go = new GameObject("ImgSelect"); go.SetActive(true); goMap[2186732890953018367L] = go; }
        { var go = new GameObject("ImgSelect (1)"); go.SetActive(true); goMap[8039820574805633968L] = go; }
        { var go = new GameObject("item13"); go.SetActive(true); goMap[8269142522574968021L] = go; }
        { var go = new GameObject("imgSelected"); go.SetActive(false); goMap[-2665572518284299046L] = go; }
        { var go = new GameObject("UIItemGrid"); go.SetActive(true); goMap[-5510519897795049125L] = go; }
        { var go = new GameObject("bg"); go.SetActive(false); goMap[1632436747866668060L] = go; }
        { var go = new GameObject("Base"); go.SetActive(true); goMap[6443748589094228407L] = go; }
        { var go = new GameObject("ItemLayer"); go.SetActive(false); goMap[-1290796867381821885L] = go; }
        { var go = new GameObject("Fragment"); go.SetActive(false); goMap[6682867503231978052L] = go; }
        { var go = new GameObject("TagNew"); go.SetActive(false); goMap[238224093019188941L] = go; }
        { var go = new GameObject("LabelSuffix"); go.SetActive(true); goMap[-9218032090682951194L] = go; }
        { var go = new GameObject("txtRBCorner"); go.SetActive(false); goMap[5689150910811022587L] = go; }
        { var go = new GameObject("txtCenter"); go.SetActive(false); goMap[5583822471829505566L] = go; }
        { var go = new GameObject("txtLTCorner"); go.SetActive(false); goMap[-2336819022152583553L] = go; }
        { var go = new GameObject("ImgLTCorner"); go.SetActive(false); goMap[1799849665726952850L] = go; }
        { var go = new GameObject("CDLayer"); go.SetActive(true); goMap[4862550098728663682L] = go; }
        { var go = new GameObject("imgPlus"); go.SetActive(false); goMap[1315618604124949646L] = go; }
        { var go = new GameObject("TagTip"); go.SetActive(false); goMap[-5483252812310593894L] = go; }
        { var go = new GameObject("TagCanDeal"); go.SetActive(false); goMap[918582564678823665L] = go; }
        { var go = new GameObject("TagMarketStall"); go.SetActive(false); goMap[4046833811904718556L] = go; }
        { var go = new GameObject("TagStone"); go.SetActive(false); goMap[-4153682306255988263L] = go; }
        { var go = new GameObject("TagZhenJue"); go.SetActive(false); goMap[4322287215292411231L] = go; }
        { var go = new GameObject("ImgRedPoint"); go.SetActive(false); goMap[-1996116205181667262L] = go; }
        { var go = new GameObject("TagEquipSeries"); go.SetActive(false); goMap[-7061633926358787167L] = go; }
        { var go = new GameObject("Enhance"); go.SetActive(true); goMap[-4203840812857488190L] = go; }
        { var go = new GameObject("imgRankBg"); go.SetActive(false); goMap[1626280828237840168L] = go; }
        { var go = new GameObject("txtRank"); go.SetActive(true); goMap[-3552916326029274164L] = go; }
        { var go = new GameObject("imgRankSeries"); go.SetActive(false); goMap[5108911299483461114L] = go; }
        { var go = new GameObject("txtRank"); go.SetActive(true); goMap[-580421857412706967L] = go; }
        { var go = new GameObject("ImgDivineWeaponLV"); go.SetActive(false); goMap[8937777941304791581L] = go; }
        { var go = new GameObject("TxtLV"); go.SetActive(true); goMap[-9067689547174741385L] = go; }
        { var go = new GameObject("imgQuestionMark"); go.SetActive(false); goMap[5241138162347462331L] = go; }
        { var go = new GameObject("Higher"); go.SetActive(false); goMap[-1784573481267764908L] = go; }
        { var go = new GameObject("LabelHushi"); go.SetActive(false); goMap[-2031584657449456117L] = go; }
        { var go = new GameObject("ImgSelect"); go.SetActive(false); goMap[-4837959988399956591L] = go; }
        { var go = new GameObject("ImgSelect"); go.SetActive(true); goMap[-1263048765459368588L] = go; }
        { var go = new GameObject("ImgSelect (1)"); go.SetActive(true); goMap[7689126718433443884L] = go; }
        { var go = new GameObject("item14"); go.SetActive(true); goMap[663443784623078094L] = go; }
        { var go = new GameObject("imgSelected"); go.SetActive(false); goMap[-4441438487826942939L] = go; }
        { var go = new GameObject("UIItemGrid"); go.SetActive(true); goMap[-5672054666671336624L] = go; }
        { var go = new GameObject("bg"); go.SetActive(false); goMap[1934965008272520929L] = go; }
        { var go = new GameObject("Base"); go.SetActive(true); goMap[-3914668558201226401L] = go; }
        { var go = new GameObject("ItemLayer"); go.SetActive(false); goMap[-9025270563583067234L] = go; }
        { var go = new GameObject("Fragment"); go.SetActive(false); goMap[-1426553099175553763L] = go; }
        { var go = new GameObject("TagNew"); go.SetActive(false); goMap[-4741887140592962283L] = go; }
        { var go = new GameObject("LabelSuffix"); go.SetActive(true); goMap[1173539502285042023L] = go; }
        { var go = new GameObject("txtRBCorner"); go.SetActive(false); goMap[-6313177268042651810L] = go; }
        { var go = new GameObject("txtCenter"); go.SetActive(false); goMap[-3043534514911786430L] = go; }
        { var go = new GameObject("txtLTCorner"); go.SetActive(false); goMap[4593530615845601401L] = go; }
        { var go = new GameObject("ImgLTCorner"); go.SetActive(false); goMap[1240241652354211560L] = go; }
        { var go = new GameObject("CDLayer"); go.SetActive(true); goMap[-1584673111506814084L] = go; }
        { var go = new GameObject("imgPlus"); go.SetActive(false); goMap[5979928834058709445L] = go; }
        { var go = new GameObject("TagTip"); go.SetActive(false); goMap[-2717411965676524757L] = go; }
        { var go = new GameObject("TagCanDeal"); go.SetActive(false); goMap[7042675463309729403L] = go; }
        { var go = new GameObject("TagMarketStall"); go.SetActive(false); goMap[3614208344004240393L] = go; }
        { var go = new GameObject("TagStone"); go.SetActive(false); goMap[-2890472369134269897L] = go; }
        { var go = new GameObject("TagZhenJue"); go.SetActive(false); goMap[7164213566470975811L] = go; }
        { var go = new GameObject("ImgRedPoint"); go.SetActive(false); goMap[-5065732609134337278L] = go; }
        { var go = new GameObject("TagEquipSeries"); go.SetActive(false); goMap[-131644770327765254L] = go; }
        { var go = new GameObject("Enhance"); go.SetActive(true); goMap[6942847734778764776L] = go; }
        { var go = new GameObject("imgRankBg"); go.SetActive(false); goMap[3902907734395517633L] = go; }
        { var go = new GameObject("txtRank"); go.SetActive(true); goMap[-1756068433598306997L] = go; }
        { var go = new GameObject("imgRankSeries"); go.SetActive(false); goMap[1235942746676039321L] = go; }
        { var go = new GameObject("txtRank"); go.SetActive(true); goMap[-9214956267585963084L] = go; }
        { var go = new GameObject("ImgDivineWeaponLV"); go.SetActive(false); goMap[5399547955743535734L] = go; }
        { var go = new GameObject("TxtLV"); go.SetActive(true); goMap[-7684511990707099075L] = go; }
        { var go = new GameObject("imgQuestionMark"); go.SetActive(false); goMap[-4621261958724562655L] = go; }
        { var go = new GameObject("Higher"); go.SetActive(false); goMap[-1161739683658855587L] = go; }
        { var go = new GameObject("LabelHushi"); go.SetActive(false); goMap[7097934953336531027L] = go; }
        { var go = new GameObject("ImgSelect"); go.SetActive(false); goMap[6093609156816985515L] = go; }
        { var go = new GameObject("ImgSelect"); go.SetActive(true); goMap[5470909357486236732L] = go; }
        { var go = new GameObject("ImgSelect (1)"); go.SetActive(true); goMap[4792398910692167065L] = go; }
        { var go = new GameObject("Right"); go.SetActive(true); goMap[-4316481871989741389L] = go; }
        { var go = new GameObject("imgExplainBg"); go.SetActive(true); goMap[6789453669242967106L] = go; }
        { var go = new GameObject("txtExplain"); go.SetActive(false); goMap[-7398008622001293413L] = go; }
        { var go = new GameObject("imgBoxClose"); go.SetActive(true); goMap[5688869594172480997L] = go; }
        { var go = new GameObject("imgBoxOpen"); go.SetActive(false); goMap[2757386761525363806L] = go; }
        { var go = new GameObject("Toggle"); go.SetActive(true); goMap[-5308719843761229971L] = go; }
        { var go = new GameObject("Background"); go.SetActive(true); goMap[834651492000526268L] = go; }
        { var go = new GameObject("Checkmark"); go.SetActive(true); goMap[-5104079435713966824L] = go; }
        { var go = new GameObject("Label"); go.SetActive(true); goMap[5449305954774952441L] = go; }
        { var go = new GameObject("txtShell"); go.SetActive(true); goMap[-2304202685755250079L] = go; }
        { var go = new GameObject("btnOpenOne"); go.SetActive(true); goMap[1985221619168864184L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-7812967673499400467L] = go; }
        { var go = new GameObject("btnOpenTen"); go.SetActive(true); goMap[-3096614008334680314L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-5631834561915026799L] = go; }

        // ─── Parent links ─────────────────────────────────────
        goMap[1237544823446787431L].transform.SetParent(goMap[-530952539511192973L].transform, false);
        goMap[-7741648411971759812L].transform.SetParent(goMap[1237544823446787431L].transform, false);
        goMap[6496384723354867089L].transform.SetParent(goMap[-7741648411971759812L].transform, false);
        goMap[-1048173925215314851L].transform.SetParent(goMap[-7741648411971759812L].transform, false);
        goMap[-6409472771210974146L].transform.SetParent(goMap[-7741648411971759812L].transform, false);
        goMap[-8812391881331520679L].transform.SetParent(goMap[-6409472771210974146L].transform, false);
        goMap[-6286371172428373189L].transform.SetParent(goMap[-6409472771210974146L].transform, false);
        goMap[7957554589500756767L].transform.SetParent(goMap[-7741648411971759812L].transform, false);
        goMap[-7045675892246741563L].transform.SetParent(goMap[-7741648411971759812L].transform, false);
        goMap[-6959178057277519759L].transform.SetParent(goMap[-7045675892246741563L].transform, false);
        goMap[-2831686508410854079L].transform.SetParent(goMap[-6959178057277519759L].transform, false);
        goMap[-2339120959881809807L].transform.SetParent(goMap[-6959178057277519759L].transform, false);
        goMap[5035197687843713640L].transform.SetParent(goMap[-2339120959881809807L].transform, false);
        goMap[-7618770041494257442L].transform.SetParent(goMap[-2339120959881809807L].transform, false);
        goMap[-2285400191166724421L].transform.SetParent(goMap[-2339120959881809807L].transform, false);
        goMap[-2889215052763512915L].transform.SetParent(goMap[-2339120959881809807L].transform, false);
        goMap[-1969699695723536218L].transform.SetParent(goMap[-2339120959881809807L].transform, false);
        goMap[6564889592374029765L].transform.SetParent(goMap[-2339120959881809807L].transform, false);
        goMap[2511512401151602561L].transform.SetParent(goMap[-2339120959881809807L].transform, false);
        goMap[3382658767223394837L].transform.SetParent(goMap[-2339120959881809807L].transform, false);
        goMap[-35018585859007955L].transform.SetParent(goMap[-2339120959881809807L].transform, false);
        goMap[7221797610359877000L].transform.SetParent(goMap[-2339120959881809807L].transform, false);
        goMap[-2821348471682522009L].transform.SetParent(goMap[-2339120959881809807L].transform, false);
        goMap[-1676785437452364397L].transform.SetParent(goMap[-2339120959881809807L].transform, false);
        goMap[2373032883546668414L].transform.SetParent(goMap[-2339120959881809807L].transform, false);
        goMap[-4619890912434326870L].transform.SetParent(goMap[-2339120959881809807L].transform, false);
        goMap[6785202751957544351L].transform.SetParent(goMap[-2339120959881809807L].transform, false);
        goMap[2751685217077241257L].transform.SetParent(goMap[-2339120959881809807L].transform, false);
        goMap[2756910226099145686L].transform.SetParent(goMap[-2339120959881809807L].transform, false);
        goMap[-9185651290367197905L].transform.SetParent(goMap[-2339120959881809807L].transform, false);
        goMap[-8385832109621459112L].transform.SetParent(goMap[-2339120959881809807L].transform, false);
        goMap[-4763436585626852253L].transform.SetParent(goMap[-2339120959881809807L].transform, false);
        goMap[-2645216112389681032L].transform.SetParent(goMap[-2339120959881809807L].transform, false);
        goMap[2453440394282108337L].transform.SetParent(goMap[-2645216112389681032L].transform, false);
        goMap[468678153841821433L].transform.SetParent(goMap[-2339120959881809807L].transform, false);
        goMap[5646725436785184187L].transform.SetParent(goMap[468678153841821433L].transform, false);
        goMap[6460721506743374230L].transform.SetParent(goMap[-2339120959881809807L].transform, false);
        goMap[-7451192948842942841L].transform.SetParent(goMap[6460721506743374230L].transform, false);
        goMap[1354625941047378844L].transform.SetParent(goMap[-2339120959881809807L].transform, false);
        goMap[-8738706388075742723L].transform.SetParent(goMap[-2339120959881809807L].transform, false);
        goMap[935514795542420135L].transform.SetParent(goMap[-2339120959881809807L].transform, false);
        goMap[-7594359136338575651L].transform.SetParent(goMap[-2339120959881809807L].transform, false);
        goMap[3731212983796224572L].transform.SetParent(goMap[-7594359136338575651L].transform, false);
        goMap[-392737364501195896L].transform.SetParent(goMap[-7594359136338575651L].transform, false);
        goMap[2841613070133622032L].transform.SetParent(goMap[-7045675892246741563L].transform, false);
        goMap[-4988810074645023889L].transform.SetParent(goMap[2841613070133622032L].transform, false);
        goMap[2047340335599326728L].transform.SetParent(goMap[2841613070133622032L].transform, false);
        goMap[6709104194550122760L].transform.SetParent(goMap[2047340335599326728L].transform, false);
        goMap[-7785397558308939797L].transform.SetParent(goMap[2047340335599326728L].transform, false);
        goMap[-2692911843489492650L].transform.SetParent(goMap[2047340335599326728L].transform, false);
        goMap[-5659479714504479972L].transform.SetParent(goMap[2047340335599326728L].transform, false);
        goMap[828417171665754036L].transform.SetParent(goMap[2047340335599326728L].transform, false);
        goMap[4003942894495324816L].transform.SetParent(goMap[2047340335599326728L].transform, false);
        goMap[7160229399895744252L].transform.SetParent(goMap[2047340335599326728L].transform, false);
        goMap[-4427178065573516104L].transform.SetParent(goMap[2047340335599326728L].transform, false);
        goMap[-4265867431189302692L].transform.SetParent(goMap[2047340335599326728L].transform, false);
        goMap[-3509482534033452089L].transform.SetParent(goMap[2047340335599326728L].transform, false);
        goMap[1753955458329894587L].transform.SetParent(goMap[2047340335599326728L].transform, false);
        goMap[-1411144917474042382L].transform.SetParent(goMap[2047340335599326728L].transform, false);
        goMap[-4304784207304754494L].transform.SetParent(goMap[2047340335599326728L].transform, false);
        goMap[3935547857572528056L].transform.SetParent(goMap[2047340335599326728L].transform, false);
        goMap[-1291571388378402241L].transform.SetParent(goMap[2047340335599326728L].transform, false);
        goMap[-1038525985385277067L].transform.SetParent(goMap[2047340335599326728L].transform, false);
        goMap[-6923880281196046419L].transform.SetParent(goMap[2047340335599326728L].transform, false);
        goMap[-7037674693110203753L].transform.SetParent(goMap[2047340335599326728L].transform, false);
        goMap[-2510395457031808888L].transform.SetParent(goMap[2047340335599326728L].transform, false);
        goMap[8482495998215746989L].transform.SetParent(goMap[2047340335599326728L].transform, false);
        goMap[-6163183374181559442L].transform.SetParent(goMap[2047340335599326728L].transform, false);
        goMap[-812954737358892092L].transform.SetParent(goMap[-6163183374181559442L].transform, false);
        goMap[-2342273936036781804L].transform.SetParent(goMap[2047340335599326728L].transform, false);
        goMap[117384091583299352L].transform.SetParent(goMap[-2342273936036781804L].transform, false);
        goMap[-4057634697521165401L].transform.SetParent(goMap[2047340335599326728L].transform, false);
        goMap[-5747343911105630032L].transform.SetParent(goMap[-4057634697521165401L].transform, false);
        goMap[4577149306098047836L].transform.SetParent(goMap[2047340335599326728L].transform, false);
        goMap[1365903304797663523L].transform.SetParent(goMap[2047340335599326728L].transform, false);
        goMap[8513276619107819192L].transform.SetParent(goMap[2047340335599326728L].transform, false);
        goMap[8052279758503742616L].transform.SetParent(goMap[2047340335599326728L].transform, false);
        goMap[-8713228793197791329L].transform.SetParent(goMap[8052279758503742616L].transform, false);
        goMap[-7977801324917535485L].transform.SetParent(goMap[8052279758503742616L].transform, false);
        goMap[8235924642477159862L].transform.SetParent(goMap[-7045675892246741563L].transform, false);
        goMap[2644630784343507100L].transform.SetParent(goMap[8235924642477159862L].transform, false);
        goMap[-780696193793809583L].transform.SetParent(goMap[8235924642477159862L].transform, false);
        goMap[-2199055589934537373L].transform.SetParent(goMap[-780696193793809583L].transform, false);
        goMap[-6259935470873015027L].transform.SetParent(goMap[-780696193793809583L].transform, false);
        goMap[-5707403456316849769L].transform.SetParent(goMap[-780696193793809583L].transform, false);
        goMap[-1354096351710242146L].transform.SetParent(goMap[-780696193793809583L].transform, false);
        goMap[-9178270468901734932L].transform.SetParent(goMap[-780696193793809583L].transform, false);
        goMap[-7277837998518740561L].transform.SetParent(goMap[-780696193793809583L].transform, false);
        goMap[5179008744008519177L].transform.SetParent(goMap[-780696193793809583L].transform, false);
        goMap[-4168760214318772541L].transform.SetParent(goMap[-780696193793809583L].transform, false);
        goMap[-2306850403838867871L].transform.SetParent(goMap[-780696193793809583L].transform, false);
        goMap[3886011940583801547L].transform.SetParent(goMap[-780696193793809583L].transform, false);
        goMap[8903288092914796881L].transform.SetParent(goMap[-780696193793809583L].transform, false);
        goMap[2943435199980712421L].transform.SetParent(goMap[-780696193793809583L].transform, false);
        goMap[-7103388226694789436L].transform.SetParent(goMap[-780696193793809583L].transform, false);
        goMap[-3019447615700983432L].transform.SetParent(goMap[-780696193793809583L].transform, false);
        goMap[6095395030151942335L].transform.SetParent(goMap[-780696193793809583L].transform, false);
        goMap[5929353036565012880L].transform.SetParent(goMap[-780696193793809583L].transform, false);
        goMap[5909346670532762525L].transform.SetParent(goMap[-780696193793809583L].transform, false);
        goMap[887708270330023763L].transform.SetParent(goMap[-780696193793809583L].transform, false);
        goMap[5580234528742680754L].transform.SetParent(goMap[-780696193793809583L].transform, false);
        goMap[3261085653812602634L].transform.SetParent(goMap[-780696193793809583L].transform, false);
        goMap[-5217579735090019196L].transform.SetParent(goMap[-780696193793809583L].transform, false);
        goMap[-993483133408869621L].transform.SetParent(goMap[-5217579735090019196L].transform, false);
        goMap[-8220143743773992068L].transform.SetParent(goMap[-780696193793809583L].transform, false);
        goMap[1128440315632879086L].transform.SetParent(goMap[-8220143743773992068L].transform, false);
        goMap[6953557680374727160L].transform.SetParent(goMap[-780696193793809583L].transform, false);
        goMap[-1170435407500132975L].transform.SetParent(goMap[6953557680374727160L].transform, false);
        goMap[2986583290605097019L].transform.SetParent(goMap[-780696193793809583L].transform, false);
        goMap[-904286889202515445L].transform.SetParent(goMap[-780696193793809583L].transform, false);
        goMap[6173264726392118532L].transform.SetParent(goMap[-780696193793809583L].transform, false);
        goMap[3898238631152543171L].transform.SetParent(goMap[-780696193793809583L].transform, false);
        goMap[539141545454901718L].transform.SetParent(goMap[3898238631152543171L].transform, false);
        goMap[7389679714594753712L].transform.SetParent(goMap[3898238631152543171L].transform, false);
        goMap[1818598192170335006L].transform.SetParent(goMap[-7045675892246741563L].transform, false);
        goMap[4756118330947438947L].transform.SetParent(goMap[1818598192170335006L].transform, false);
        goMap[-2969254269191482076L].transform.SetParent(goMap[1818598192170335006L].transform, false);
        goMap[-2747133590769654289L].transform.SetParent(goMap[-2969254269191482076L].transform, false);
        goMap[3316991072999543507L].transform.SetParent(goMap[-2969254269191482076L].transform, false);
        goMap[-1056932844143038560L].transform.SetParent(goMap[-2969254269191482076L].transform, false);
        goMap[-6185558515373789866L].transform.SetParent(goMap[-2969254269191482076L].transform, false);
        goMap[-2462332175542322340L].transform.SetParent(goMap[-2969254269191482076L].transform, false);
        goMap[1650209262349969699L].transform.SetParent(goMap[-2969254269191482076L].transform, false);
        goMap[-5129925588215870390L].transform.SetParent(goMap[-2969254269191482076L].transform, false);
        goMap[-2991514388471886352L].transform.SetParent(goMap[-2969254269191482076L].transform, false);
        goMap[-1068832718366549766L].transform.SetParent(goMap[-2969254269191482076L].transform, false);
        goMap[7737591243062095058L].transform.SetParent(goMap[-2969254269191482076L].transform, false);
        goMap[3607688411957492950L].transform.SetParent(goMap[-2969254269191482076L].transform, false);
        goMap[-3849952560644415644L].transform.SetParent(goMap[-2969254269191482076L].transform, false);
        goMap[-6273487276266295590L].transform.SetParent(goMap[-2969254269191482076L].transform, false);
        goMap[7741378695028675943L].transform.SetParent(goMap[-2969254269191482076L].transform, false);
        goMap[-3477028317645482911L].transform.SetParent(goMap[-2969254269191482076L].transform, false);
        goMap[1886090582131228065L].transform.SetParent(goMap[-2969254269191482076L].transform, false);
        goMap[6327078442107999798L].transform.SetParent(goMap[-2969254269191482076L].transform, false);
        goMap[7073356767125253036L].transform.SetParent(goMap[-2969254269191482076L].transform, false);
        goMap[3542421210518926120L].transform.SetParent(goMap[-2969254269191482076L].transform, false);
        goMap[406455628800584870L].transform.SetParent(goMap[-2969254269191482076L].transform, false);
        goMap[-8150748596911203672L].transform.SetParent(goMap[-2969254269191482076L].transform, false);
        goMap[-74868981596848676L].transform.SetParent(goMap[-8150748596911203672L].transform, false);
        goMap[-5571368072696524685L].transform.SetParent(goMap[-2969254269191482076L].transform, false);
        goMap[4274259126662576580L].transform.SetParent(goMap[-5571368072696524685L].transform, false);
        goMap[6607367121880594206L].transform.SetParent(goMap[-2969254269191482076L].transform, false);
        goMap[8381002780691030183L].transform.SetParent(goMap[6607367121880594206L].transform, false);
        goMap[-5217367109159946479L].transform.SetParent(goMap[-2969254269191482076L].transform, false);
        goMap[7273965044490187946L].transform.SetParent(goMap[-2969254269191482076L].transform, false);
        goMap[-3797229454583386668L].transform.SetParent(goMap[-2969254269191482076L].transform, false);
        goMap[4225400851029987153L].transform.SetParent(goMap[-2969254269191482076L].transform, false);
        goMap[5968032313552453206L].transform.SetParent(goMap[4225400851029987153L].transform, false);
        goMap[-629706803690471377L].transform.SetParent(goMap[4225400851029987153L].transform, false);
        goMap[3203654569723708702L].transform.SetParent(goMap[-7045675892246741563L].transform, false);
        goMap[-4004919049465411750L].transform.SetParent(goMap[3203654569723708702L].transform, false);
        goMap[4194297304323543147L].transform.SetParent(goMap[3203654569723708702L].transform, false);
        goMap[-3783771068485415084L].transform.SetParent(goMap[4194297304323543147L].transform, false);
        goMap[6502516323095144277L].transform.SetParent(goMap[4194297304323543147L].transform, false);
        goMap[-1806627685724413089L].transform.SetParent(goMap[4194297304323543147L].transform, false);
        goMap[7750096041181587338L].transform.SetParent(goMap[4194297304323543147L].transform, false);
        goMap[-45981857361267538L].transform.SetParent(goMap[4194297304323543147L].transform, false);
        goMap[3583785882062999907L].transform.SetParent(goMap[4194297304323543147L].transform, false);
        goMap[1854188323772268177L].transform.SetParent(goMap[4194297304323543147L].transform, false);
        goMap[-2707144691636398801L].transform.SetParent(goMap[4194297304323543147L].transform, false);
        goMap[6819031330683157589L].transform.SetParent(goMap[4194297304323543147L].transform, false);
        goMap[5482651682701006359L].transform.SetParent(goMap[4194297304323543147L].transform, false);
        goMap[4797636452550945659L].transform.SetParent(goMap[4194297304323543147L].transform, false);
        goMap[-8087478530635953379L].transform.SetParent(goMap[4194297304323543147L].transform, false);
        goMap[-4057624814627753876L].transform.SetParent(goMap[4194297304323543147L].transform, false);
        goMap[1277088060254502308L].transform.SetParent(goMap[4194297304323543147L].transform, false);
        goMap[-5511441829023179228L].transform.SetParent(goMap[4194297304323543147L].transform, false);
        goMap[2094144939881200617L].transform.SetParent(goMap[4194297304323543147L].transform, false);
        goMap[7368225251734086024L].transform.SetParent(goMap[4194297304323543147L].transform, false);
        goMap[-3048984516186313070L].transform.SetParent(goMap[4194297304323543147L].transform, false);
        goMap[-8889852562522881302L].transform.SetParent(goMap[4194297304323543147L].transform, false);
        goMap[-1839315582462150938L].transform.SetParent(goMap[4194297304323543147L].transform, false);
        goMap[5368793025668648731L].transform.SetParent(goMap[4194297304323543147L].transform, false);
        goMap[-2975432711635616719L].transform.SetParent(goMap[5368793025668648731L].transform, false);
        goMap[4248838317101648056L].transform.SetParent(goMap[4194297304323543147L].transform, false);
        goMap[-6246364200537742906L].transform.SetParent(goMap[4248838317101648056L].transform, false);
        goMap[-5280317836490420235L].transform.SetParent(goMap[4194297304323543147L].transform, false);
        goMap[6919660766227727534L].transform.SetParent(goMap[-5280317836490420235L].transform, false);
        goMap[-5542171321853228168L].transform.SetParent(goMap[4194297304323543147L].transform, false);
        goMap[-2298401924145024944L].transform.SetParent(goMap[4194297304323543147L].transform, false);
        goMap[-4187379582435832753L].transform.SetParent(goMap[4194297304323543147L].transform, false);
        goMap[-8935351006806585305L].transform.SetParent(goMap[4194297304323543147L].transform, false);
        goMap[-2753218195425567341L].transform.SetParent(goMap[-8935351006806585305L].transform, false);
        goMap[1531864095864878732L].transform.SetParent(goMap[-8935351006806585305L].transform, false);
        goMap[-6557785430215885438L].transform.SetParent(goMap[-7045675892246741563L].transform, false);
        goMap[-6244949745423807786L].transform.SetParent(goMap[-6557785430215885438L].transform, false);
        goMap[-1660032452913207623L].transform.SetParent(goMap[-6557785430215885438L].transform, false);
        goMap[3859934498748265959L].transform.SetParent(goMap[-1660032452913207623L].transform, false);
        goMap[258547390643155568L].transform.SetParent(goMap[-1660032452913207623L].transform, false);
        goMap[4350287868858106684L].transform.SetParent(goMap[-1660032452913207623L].transform, false);
        goMap[2518129077057491871L].transform.SetParent(goMap[-1660032452913207623L].transform, false);
        goMap[-7468606049957495883L].transform.SetParent(goMap[-1660032452913207623L].transform, false);
        goMap[5536058534585205598L].transform.SetParent(goMap[-1660032452913207623L].transform, false);
        goMap[-2915357637535509381L].transform.SetParent(goMap[-1660032452913207623L].transform, false);
        goMap[-4013312492994039685L].transform.SetParent(goMap[-1660032452913207623L].transform, false);
        goMap[5578147471128079548L].transform.SetParent(goMap[-1660032452913207623L].transform, false);
        goMap[5200651765324398648L].transform.SetParent(goMap[-1660032452913207623L].transform, false);
        goMap[3585479898826806734L].transform.SetParent(goMap[-1660032452913207623L].transform, false);
        goMap[-8235555614972968260L].transform.SetParent(goMap[-1660032452913207623L].transform, false);
        goMap[-4808438553405592758L].transform.SetParent(goMap[-1660032452913207623L].transform, false);
        goMap[-928689722833608946L].transform.SetParent(goMap[-1660032452913207623L].transform, false);
        goMap[-1491615210035932463L].transform.SetParent(goMap[-1660032452913207623L].transform, false);
        goMap[1943632073059430502L].transform.SetParent(goMap[-1660032452913207623L].transform, false);
        goMap[8581961768108890376L].transform.SetParent(goMap[-1660032452913207623L].transform, false);
        goMap[-6861360801964382209L].transform.SetParent(goMap[-1660032452913207623L].transform, false);
        goMap[-5618775290806992885L].transform.SetParent(goMap[-1660032452913207623L].transform, false);
        goMap[1255208121312004112L].transform.SetParent(goMap[-1660032452913207623L].transform, false);
        goMap[1324437040123722409L].transform.SetParent(goMap[-1660032452913207623L].transform, false);
        goMap[5116464727626368434L].transform.SetParent(goMap[1324437040123722409L].transform, false);
        goMap[7612103997383136473L].transform.SetParent(goMap[-1660032452913207623L].transform, false);
        goMap[7468409178993271628L].transform.SetParent(goMap[7612103997383136473L].transform, false);
        goMap[-4490376897510665074L].transform.SetParent(goMap[-1660032452913207623L].transform, false);
        goMap[6170809084645975647L].transform.SetParent(goMap[-4490376897510665074L].transform, false);
        goMap[-2185328281396515535L].transform.SetParent(goMap[-1660032452913207623L].transform, false);
        goMap[-621842661251458155L].transform.SetParent(goMap[-1660032452913207623L].transform, false);
        goMap[-4270564351483450102L].transform.SetParent(goMap[-1660032452913207623L].transform, false);
        goMap[1877497348024382598L].transform.SetParent(goMap[-1660032452913207623L].transform, false);
        goMap[4387906694162754338L].transform.SetParent(goMap[1877497348024382598L].transform, false);
        goMap[-4164641553595051019L].transform.SetParent(goMap[1877497348024382598L].transform, false);
        goMap[6886569599195319990L].transform.SetParent(goMap[-7045675892246741563L].transform, false);
        goMap[3569326097188466142L].transform.SetParent(goMap[6886569599195319990L].transform, false);
        goMap[3256290757132076363L].transform.SetParent(goMap[6886569599195319990L].transform, false);
        goMap[-3206802188326003192L].transform.SetParent(goMap[3256290757132076363L].transform, false);
        goMap[-7992722351109031519L].transform.SetParent(goMap[3256290757132076363L].transform, false);
        goMap[-3703476882474036217L].transform.SetParent(goMap[3256290757132076363L].transform, false);
        goMap[2547725499076561724L].transform.SetParent(goMap[3256290757132076363L].transform, false);
        goMap[-6429517870701096137L].transform.SetParent(goMap[3256290757132076363L].transform, false);
        goMap[-3861307512401056529L].transform.SetParent(goMap[3256290757132076363L].transform, false);
        goMap[-3893583791612394962L].transform.SetParent(goMap[3256290757132076363L].transform, false);
        goMap[7754430352565921336L].transform.SetParent(goMap[3256290757132076363L].transform, false);
        goMap[5784300124308319141L].transform.SetParent(goMap[3256290757132076363L].transform, false);
        goMap[-5319570853057360076L].transform.SetParent(goMap[3256290757132076363L].transform, false);
        goMap[5661331876045189672L].transform.SetParent(goMap[3256290757132076363L].transform, false);
        goMap[-5725024631616254166L].transform.SetParent(goMap[3256290757132076363L].transform, false);
        goMap[-3914005005258374868L].transform.SetParent(goMap[3256290757132076363L].transform, false);
        goMap[2023878650659462326L].transform.SetParent(goMap[3256290757132076363L].transform, false);
        goMap[6385776964626232266L].transform.SetParent(goMap[3256290757132076363L].transform, false);
        goMap[5478605813741346077L].transform.SetParent(goMap[3256290757132076363L].transform, false);
        goMap[4440391946033369108L].transform.SetParent(goMap[3256290757132076363L].transform, false);
        goMap[-7658658768117457682L].transform.SetParent(goMap[3256290757132076363L].transform, false);
        goMap[9191134168714483198L].transform.SetParent(goMap[3256290757132076363L].transform, false);
        goMap[-431245549300961747L].transform.SetParent(goMap[3256290757132076363L].transform, false);
        goMap[2185518495806790478L].transform.SetParent(goMap[3256290757132076363L].transform, false);
        goMap[-7310316910746679953L].transform.SetParent(goMap[2185518495806790478L].transform, false);
        goMap[-753186279118087024L].transform.SetParent(goMap[3256290757132076363L].transform, false);
        goMap[-421264179994258120L].transform.SetParent(goMap[-753186279118087024L].transform, false);
        goMap[1189418231994101254L].transform.SetParent(goMap[3256290757132076363L].transform, false);
        goMap[-2522277611558697722L].transform.SetParent(goMap[1189418231994101254L].transform, false);
        goMap[3019259967916700993L].transform.SetParent(goMap[3256290757132076363L].transform, false);
        goMap[6123882577084589483L].transform.SetParent(goMap[3256290757132076363L].transform, false);
        goMap[664402229362451315L].transform.SetParent(goMap[3256290757132076363L].transform, false);
        goMap[-7650318869590572907L].transform.SetParent(goMap[3256290757132076363L].transform, false);
        goMap[2480033360837464480L].transform.SetParent(goMap[-7650318869590572907L].transform, false);
        goMap[-7366620873748422204L].transform.SetParent(goMap[-7650318869590572907L].transform, false);
        goMap[1595356721993304515L].transform.SetParent(goMap[-7045675892246741563L].transform, false);
        goMap[-5572456803609149599L].transform.SetParent(goMap[1595356721993304515L].transform, false);
        goMap[162078786380344046L].transform.SetParent(goMap[1595356721993304515L].transform, false);
        goMap[-4459061989411866599L].transform.SetParent(goMap[162078786380344046L].transform, false);
        goMap[5389173865562054004L].transform.SetParent(goMap[162078786380344046L].transform, false);
        goMap[-1542549233695943954L].transform.SetParent(goMap[162078786380344046L].transform, false);
        goMap[-758400158961041734L].transform.SetParent(goMap[162078786380344046L].transform, false);
        goMap[4251515164245845223L].transform.SetParent(goMap[162078786380344046L].transform, false);
        goMap[-6636141275141599414L].transform.SetParent(goMap[162078786380344046L].transform, false);
        goMap[-3508559083789626954L].transform.SetParent(goMap[162078786380344046L].transform, false);
        goMap[-6076793695855127581L].transform.SetParent(goMap[162078786380344046L].transform, false);
        goMap[-8022097623875767155L].transform.SetParent(goMap[162078786380344046L].transform, false);
        goMap[3084556461343236870L].transform.SetParent(goMap[162078786380344046L].transform, false);
        goMap[-2502804922131173566L].transform.SetParent(goMap[162078786380344046L].transform, false);
        goMap[1377975162260520142L].transform.SetParent(goMap[162078786380344046L].transform, false);
        goMap[-7586487632728244221L].transform.SetParent(goMap[162078786380344046L].transform, false);
        goMap[-7620775324658509088L].transform.SetParent(goMap[162078786380344046L].transform, false);
        goMap[7569918802615195081L].transform.SetParent(goMap[162078786380344046L].transform, false);
        goMap[8654249257387496586L].transform.SetParent(goMap[162078786380344046L].transform, false);
        goMap[-1147449900313440380L].transform.SetParent(goMap[162078786380344046L].transform, false);
        goMap[-7459614203372114148L].transform.SetParent(goMap[162078786380344046L].transform, false);
        goMap[4993880972996822887L].transform.SetParent(goMap[162078786380344046L].transform, false);
        goMap[-7122437874173256294L].transform.SetParent(goMap[162078786380344046L].transform, false);
        goMap[-2878033329699973957L].transform.SetParent(goMap[162078786380344046L].transform, false);
        goMap[401080732301674078L].transform.SetParent(goMap[-2878033329699973957L].transform, false);
        goMap[-2814341700986650808L].transform.SetParent(goMap[162078786380344046L].transform, false);
        goMap[2710144149694006154L].transform.SetParent(goMap[-2814341700986650808L].transform, false);
        goMap[-6837416058809651670L].transform.SetParent(goMap[162078786380344046L].transform, false);
        goMap[4013423673232460561L].transform.SetParent(goMap[-6837416058809651670L].transform, false);
        goMap[-8950848934434519908L].transform.SetParent(goMap[162078786380344046L].transform, false);
        goMap[-3747978240577390605L].transform.SetParent(goMap[162078786380344046L].transform, false);
        goMap[5448532372314014984L].transform.SetParent(goMap[162078786380344046L].transform, false);
        goMap[-632295598915230293L].transform.SetParent(goMap[162078786380344046L].transform, false);
        goMap[-3247584279771251903L].transform.SetParent(goMap[-632295598915230293L].transform, false);
        goMap[5217197697780506563L].transform.SetParent(goMap[-632295598915230293L].transform, false);
        goMap[1663118642577024934L].transform.SetParent(goMap[-7045675892246741563L].transform, false);
        goMap[-73704323097791350L].transform.SetParent(goMap[1663118642577024934L].transform, false);
        goMap[9205755363516087646L].transform.SetParent(goMap[1663118642577024934L].transform, false);
        goMap[-1642865896103847093L].transform.SetParent(goMap[9205755363516087646L].transform, false);
        goMap[-8989895865271480841L].transform.SetParent(goMap[9205755363516087646L].transform, false);
        goMap[7274919739472658569L].transform.SetParent(goMap[9205755363516087646L].transform, false);
        goMap[-6474420241397276760L].transform.SetParent(goMap[9205755363516087646L].transform, false);
        goMap[1981196291729700466L].transform.SetParent(goMap[9205755363516087646L].transform, false);
        goMap[6146143904014342779L].transform.SetParent(goMap[9205755363516087646L].transform, false);
        goMap[6206043328514573101L].transform.SetParent(goMap[9205755363516087646L].transform, false);
        goMap[-900145749982296073L].transform.SetParent(goMap[9205755363516087646L].transform, false);
        goMap[-8345511344440216439L].transform.SetParent(goMap[9205755363516087646L].transform, false);
        goMap[-8551629439379484552L].transform.SetParent(goMap[9205755363516087646L].transform, false);
        goMap[7355185180429482560L].transform.SetParent(goMap[9205755363516087646L].transform, false);
        goMap[-5296215651904924457L].transform.SetParent(goMap[9205755363516087646L].transform, false);
        goMap[-1589268852755538248L].transform.SetParent(goMap[9205755363516087646L].transform, false);
        goMap[-3335551879107124431L].transform.SetParent(goMap[9205755363516087646L].transform, false);
        goMap[-693530954936255824L].transform.SetParent(goMap[9205755363516087646L].transform, false);
        goMap[6272798149034974544L].transform.SetParent(goMap[9205755363516087646L].transform, false);
        goMap[3882805435572226329L].transform.SetParent(goMap[9205755363516087646L].transform, false);
        goMap[6582776910553710131L].transform.SetParent(goMap[9205755363516087646L].transform, false);
        goMap[5887803223407278764L].transform.SetParent(goMap[9205755363516087646L].transform, false);
        goMap[-3616659947293336528L].transform.SetParent(goMap[9205755363516087646L].transform, false);
        goMap[-7715521518177954685L].transform.SetParent(goMap[9205755363516087646L].transform, false);
        goMap[2434601062884682979L].transform.SetParent(goMap[-7715521518177954685L].transform, false);
        goMap[-1922581952339719502L].transform.SetParent(goMap[9205755363516087646L].transform, false);
        goMap[7895873382187774913L].transform.SetParent(goMap[-1922581952339719502L].transform, false);
        goMap[-194576399171645000L].transform.SetParent(goMap[9205755363516087646L].transform, false);
        goMap[-2935697758642554993L].transform.SetParent(goMap[-194576399171645000L].transform, false);
        goMap[2144337918547670652L].transform.SetParent(goMap[9205755363516087646L].transform, false);
        goMap[5084932241245459628L].transform.SetParent(goMap[9205755363516087646L].transform, false);
        goMap[3933394076467007949L].transform.SetParent(goMap[9205755363516087646L].transform, false);
        goMap[-374201911436493508L].transform.SetParent(goMap[9205755363516087646L].transform, false);
        goMap[-1025374096136740890L].transform.SetParent(goMap[-374201911436493508L].transform, false);
        goMap[8595004814372084585L].transform.SetParent(goMap[-374201911436493508L].transform, false);
        goMap[-7309444687643116399L].transform.SetParent(goMap[-7045675892246741563L].transform, false);
        goMap[6050447251632985150L].transform.SetParent(goMap[-7309444687643116399L].transform, false);
        goMap[-2268300130891209069L].transform.SetParent(goMap[-7309444687643116399L].transform, false);
        goMap[2378326900071587541L].transform.SetParent(goMap[-2268300130891209069L].transform, false);
        goMap[8168369866304933107L].transform.SetParent(goMap[-2268300130891209069L].transform, false);
        goMap[-5174309534820832584L].transform.SetParent(goMap[-2268300130891209069L].transform, false);
        goMap[-8231060882058414772L].transform.SetParent(goMap[-2268300130891209069L].transform, false);
        goMap[7373304116156363766L].transform.SetParent(goMap[-2268300130891209069L].transform, false);
        goMap[8906195386061717354L].transform.SetParent(goMap[-2268300130891209069L].transform, false);
        goMap[7892847533465812692L].transform.SetParent(goMap[-2268300130891209069L].transform, false);
        goMap[-2876244575501082604L].transform.SetParent(goMap[-2268300130891209069L].transform, false);
        goMap[-7415099686420225185L].transform.SetParent(goMap[-2268300130891209069L].transform, false);
        goMap[-4864082822081032184L].transform.SetParent(goMap[-2268300130891209069L].transform, false);
        goMap[3427259412550978892L].transform.SetParent(goMap[-2268300130891209069L].transform, false);
        goMap[-799171564556225449L].transform.SetParent(goMap[-2268300130891209069L].transform, false);
        goMap[7974702868045624266L].transform.SetParent(goMap[-2268300130891209069L].transform, false);
        goMap[-656587985902071198L].transform.SetParent(goMap[-2268300130891209069L].transform, false);
        goMap[-980586608958451626L].transform.SetParent(goMap[-2268300130891209069L].transform, false);
        goMap[562665163024275017L].transform.SetParent(goMap[-2268300130891209069L].transform, false);
        goMap[8333801475305311219L].transform.SetParent(goMap[-2268300130891209069L].transform, false);
        goMap[-5764902720471370084L].transform.SetParent(goMap[-2268300130891209069L].transform, false);
        goMap[5238608587787509558L].transform.SetParent(goMap[-2268300130891209069L].transform, false);
        goMap[-7540757176210170787L].transform.SetParent(goMap[-2268300130891209069L].transform, false);
        goMap[3553685321471580007L].transform.SetParent(goMap[-2268300130891209069L].transform, false);
        goMap[-197591211163696369L].transform.SetParent(goMap[3553685321471580007L].transform, false);
        goMap[6984071307798181110L].transform.SetParent(goMap[-2268300130891209069L].transform, false);
        goMap[-8374112380971608967L].transform.SetParent(goMap[6984071307798181110L].transform, false);
        goMap[1200566845871880307L].transform.SetParent(goMap[-2268300130891209069L].transform, false);
        goMap[-7037641143752962045L].transform.SetParent(goMap[1200566845871880307L].transform, false);
        goMap[-6037309053294482300L].transform.SetParent(goMap[-2268300130891209069L].transform, false);
        goMap[-3115327118152154352L].transform.SetParent(goMap[-2268300130891209069L].transform, false);
        goMap[-6543105446751645424L].transform.SetParent(goMap[-2268300130891209069L].transform, false);
        goMap[6498122785235064957L].transform.SetParent(goMap[-2268300130891209069L].transform, false);
        goMap[8362856759373596002L].transform.SetParent(goMap[6498122785235064957L].transform, false);
        goMap[109259675198610636L].transform.SetParent(goMap[6498122785235064957L].transform, false);
        goMap[2965639596179616547L].transform.SetParent(goMap[-7045675892246741563L].transform, false);
        goMap[220428456418758578L].transform.SetParent(goMap[2965639596179616547L].transform, false);
        goMap[-8009926675464430123L].transform.SetParent(goMap[2965639596179616547L].transform, false);
        goMap[-2555838729817560368L].transform.SetParent(goMap[-8009926675464430123L].transform, false);
        goMap[3264847616176402910L].transform.SetParent(goMap[-8009926675464430123L].transform, false);
        goMap[7475800658144970975L].transform.SetParent(goMap[-8009926675464430123L].transform, false);
        goMap[6418080242586951814L].transform.SetParent(goMap[-8009926675464430123L].transform, false);
        goMap[-4080550302726174419L].transform.SetParent(goMap[-8009926675464430123L].transform, false);
        goMap[-5714976616510214674L].transform.SetParent(goMap[-8009926675464430123L].transform, false);
        goMap[260657172871768196L].transform.SetParent(goMap[-8009926675464430123L].transform, false);
        goMap[7140514509794322496L].transform.SetParent(goMap[-8009926675464430123L].transform, false);
        goMap[-4940729278684384457L].transform.SetParent(goMap[-8009926675464430123L].transform, false);
        goMap[-6758392136145104355L].transform.SetParent(goMap[-8009926675464430123L].transform, false);
        goMap[-1980188168636719842L].transform.SetParent(goMap[-8009926675464430123L].transform, false);
        goMap[1945511589896611101L].transform.SetParent(goMap[-8009926675464430123L].transform, false);
        goMap[3479838084973489529L].transform.SetParent(goMap[-8009926675464430123L].transform, false);
        goMap[3793986255456268988L].transform.SetParent(goMap[-8009926675464430123L].transform, false);
        goMap[5150506781369034332L].transform.SetParent(goMap[-8009926675464430123L].transform, false);
        goMap[-3935790612616573192L].transform.SetParent(goMap[-8009926675464430123L].transform, false);
        goMap[3942483339803346154L].transform.SetParent(goMap[-8009926675464430123L].transform, false);
        goMap[-1658166954870918362L].transform.SetParent(goMap[-8009926675464430123L].transform, false);
        goMap[-575181074648501323L].transform.SetParent(goMap[-8009926675464430123L].transform, false);
        goMap[96847911620851889L].transform.SetParent(goMap[-8009926675464430123L].transform, false);
        goMap[-6583475327188434656L].transform.SetParent(goMap[-8009926675464430123L].transform, false);
        goMap[-6136508682829120932L].transform.SetParent(goMap[-6583475327188434656L].transform, false);
        goMap[-3234199561606740755L].transform.SetParent(goMap[-8009926675464430123L].transform, false);
        goMap[-7315441288776086324L].transform.SetParent(goMap[-3234199561606740755L].transform, false);
        goMap[531390889013143977L].transform.SetParent(goMap[-8009926675464430123L].transform, false);
        goMap[7481779225232934934L].transform.SetParent(goMap[531390889013143977L].transform, false);
        goMap[-8086346586055357343L].transform.SetParent(goMap[-8009926675464430123L].transform, false);
        goMap[-378640279643211297L].transform.SetParent(goMap[-8009926675464430123L].transform, false);
        goMap[3199508643747806029L].transform.SetParent(goMap[-8009926675464430123L].transform, false);
        goMap[-1653104402406472818L].transform.SetParent(goMap[-8009926675464430123L].transform, false);
        goMap[-5726366200773963988L].transform.SetParent(goMap[-1653104402406472818L].transform, false);
        goMap[-2823386897994125793L].transform.SetParent(goMap[-1653104402406472818L].transform, false);
        goMap[-7281530768682015014L].transform.SetParent(goMap[-7045675892246741563L].transform, false);
        goMap[-1855929211468115950L].transform.SetParent(goMap[-7281530768682015014L].transform, false);
        goMap[-2786361121474131816L].transform.SetParent(goMap[-7281530768682015014L].transform, false);
        goMap[309477125561651569L].transform.SetParent(goMap[-2786361121474131816L].transform, false);
        goMap[3374280535351502192L].transform.SetParent(goMap[-2786361121474131816L].transform, false);
        goMap[-366850427297400475L].transform.SetParent(goMap[-2786361121474131816L].transform, false);
        goMap[-7803183571198445711L].transform.SetParent(goMap[-2786361121474131816L].transform, false);
        goMap[-1927688012450094885L].transform.SetParent(goMap[-2786361121474131816L].transform, false);
        goMap[139295094796042983L].transform.SetParent(goMap[-2786361121474131816L].transform, false);
        goMap[5023509310148843131L].transform.SetParent(goMap[-2786361121474131816L].transform, false);
        goMap[-3365066893982352480L].transform.SetParent(goMap[-2786361121474131816L].transform, false);
        goMap[3521491654050434488L].transform.SetParent(goMap[-2786361121474131816L].transform, false);
        goMap[3233412841466314447L].transform.SetParent(goMap[-2786361121474131816L].transform, false);
        goMap[1190175795195419405L].transform.SetParent(goMap[-2786361121474131816L].transform, false);
        goMap[-7988713809276816343L].transform.SetParent(goMap[-2786361121474131816L].transform, false);
        goMap[5055907786938158942L].transform.SetParent(goMap[-2786361121474131816L].transform, false);
        goMap[-7351918411705901345L].transform.SetParent(goMap[-2786361121474131816L].transform, false);
        goMap[-123076985158000013L].transform.SetParent(goMap[-2786361121474131816L].transform, false);
        goMap[-6024470738857561803L].transform.SetParent(goMap[-2786361121474131816L].transform, false);
        goMap[4645460277573699346L].transform.SetParent(goMap[-2786361121474131816L].transform, false);
        goMap[-1611572446160023218L].transform.SetParent(goMap[-2786361121474131816L].transform, false);
        goMap[342241789552109340L].transform.SetParent(goMap[-2786361121474131816L].transform, false);
        goMap[7212110131603294907L].transform.SetParent(goMap[-2786361121474131816L].transform, false);
        goMap[4645359045161815676L].transform.SetParent(goMap[-2786361121474131816L].transform, false);
        goMap[-8042487701915378318L].transform.SetParent(goMap[4645359045161815676L].transform, false);
        goMap[-4712080362788068618L].transform.SetParent(goMap[-2786361121474131816L].transform, false);
        goMap[-2084517210091289812L].transform.SetParent(goMap[-4712080362788068618L].transform, false);
        goMap[331772348087123986L].transform.SetParent(goMap[-2786361121474131816L].transform, false);
        goMap[-9168339921928156106L].transform.SetParent(goMap[331772348087123986L].transform, false);
        goMap[7635564418589756352L].transform.SetParent(goMap[-2786361121474131816L].transform, false);
        goMap[-3504544829515422575L].transform.SetParent(goMap[-2786361121474131816L].transform, false);
        goMap[4678314847436373733L].transform.SetParent(goMap[-2786361121474131816L].transform, false);
        goMap[6207036371573398290L].transform.SetParent(goMap[-2786361121474131816L].transform, false);
        goMap[2186732890953018367L].transform.SetParent(goMap[6207036371573398290L].transform, false);
        goMap[8039820574805633968L].transform.SetParent(goMap[6207036371573398290L].transform, false);
        goMap[8269142522574968021L].transform.SetParent(goMap[-7045675892246741563L].transform, false);
        goMap[-2665572518284299046L].transform.SetParent(goMap[8269142522574968021L].transform, false);
        goMap[-5510519897795049125L].transform.SetParent(goMap[8269142522574968021L].transform, false);
        goMap[1632436747866668060L].transform.SetParent(goMap[-5510519897795049125L].transform, false);
        goMap[6443748589094228407L].transform.SetParent(goMap[-5510519897795049125L].transform, false);
        goMap[-1290796867381821885L].transform.SetParent(goMap[-5510519897795049125L].transform, false);
        goMap[6682867503231978052L].transform.SetParent(goMap[-5510519897795049125L].transform, false);
        goMap[238224093019188941L].transform.SetParent(goMap[-5510519897795049125L].transform, false);
        goMap[-9218032090682951194L].transform.SetParent(goMap[-5510519897795049125L].transform, false);
        goMap[5689150910811022587L].transform.SetParent(goMap[-5510519897795049125L].transform, false);
        goMap[5583822471829505566L].transform.SetParent(goMap[-5510519897795049125L].transform, false);
        goMap[-2336819022152583553L].transform.SetParent(goMap[-5510519897795049125L].transform, false);
        goMap[1799849665726952850L].transform.SetParent(goMap[-5510519897795049125L].transform, false);
        goMap[4862550098728663682L].transform.SetParent(goMap[-5510519897795049125L].transform, false);
        goMap[1315618604124949646L].transform.SetParent(goMap[-5510519897795049125L].transform, false);
        goMap[-5483252812310593894L].transform.SetParent(goMap[-5510519897795049125L].transform, false);
        goMap[918582564678823665L].transform.SetParent(goMap[-5510519897795049125L].transform, false);
        goMap[4046833811904718556L].transform.SetParent(goMap[-5510519897795049125L].transform, false);
        goMap[-4153682306255988263L].transform.SetParent(goMap[-5510519897795049125L].transform, false);
        goMap[4322287215292411231L].transform.SetParent(goMap[-5510519897795049125L].transform, false);
        goMap[-1996116205181667262L].transform.SetParent(goMap[-5510519897795049125L].transform, false);
        goMap[-7061633926358787167L].transform.SetParent(goMap[-5510519897795049125L].transform, false);
        goMap[-4203840812857488190L].transform.SetParent(goMap[-5510519897795049125L].transform, false);
        goMap[1626280828237840168L].transform.SetParent(goMap[-5510519897795049125L].transform, false);
        goMap[-3552916326029274164L].transform.SetParent(goMap[1626280828237840168L].transform, false);
        goMap[5108911299483461114L].transform.SetParent(goMap[-5510519897795049125L].transform, false);
        goMap[-580421857412706967L].transform.SetParent(goMap[5108911299483461114L].transform, false);
        goMap[8937777941304791581L].transform.SetParent(goMap[-5510519897795049125L].transform, false);
        goMap[-9067689547174741385L].transform.SetParent(goMap[8937777941304791581L].transform, false);
        goMap[5241138162347462331L].transform.SetParent(goMap[-5510519897795049125L].transform, false);
        goMap[-1784573481267764908L].transform.SetParent(goMap[-5510519897795049125L].transform, false);
        goMap[-2031584657449456117L].transform.SetParent(goMap[-5510519897795049125L].transform, false);
        goMap[-4837959988399956591L].transform.SetParent(goMap[-5510519897795049125L].transform, false);
        goMap[-1263048765459368588L].transform.SetParent(goMap[-4837959988399956591L].transform, false);
        goMap[7689126718433443884L].transform.SetParent(goMap[-4837959988399956591L].transform, false);
        goMap[663443784623078094L].transform.SetParent(goMap[-7045675892246741563L].transform, false);
        goMap[-4441438487826942939L].transform.SetParent(goMap[663443784623078094L].transform, false);
        goMap[-5672054666671336624L].transform.SetParent(goMap[663443784623078094L].transform, false);
        goMap[1934965008272520929L].transform.SetParent(goMap[-5672054666671336624L].transform, false);
        goMap[-3914668558201226401L].transform.SetParent(goMap[-5672054666671336624L].transform, false);
        goMap[-9025270563583067234L].transform.SetParent(goMap[-5672054666671336624L].transform, false);
        goMap[-1426553099175553763L].transform.SetParent(goMap[-5672054666671336624L].transform, false);
        goMap[-4741887140592962283L].transform.SetParent(goMap[-5672054666671336624L].transform, false);
        goMap[1173539502285042023L].transform.SetParent(goMap[-5672054666671336624L].transform, false);
        goMap[-6313177268042651810L].transform.SetParent(goMap[-5672054666671336624L].transform, false);
        goMap[-3043534514911786430L].transform.SetParent(goMap[-5672054666671336624L].transform, false);
        goMap[4593530615845601401L].transform.SetParent(goMap[-5672054666671336624L].transform, false);
        goMap[1240241652354211560L].transform.SetParent(goMap[-5672054666671336624L].transform, false);
        goMap[-1584673111506814084L].transform.SetParent(goMap[-5672054666671336624L].transform, false);
        goMap[5979928834058709445L].transform.SetParent(goMap[-5672054666671336624L].transform, false);
        goMap[-2717411965676524757L].transform.SetParent(goMap[-5672054666671336624L].transform, false);
        goMap[7042675463309729403L].transform.SetParent(goMap[-5672054666671336624L].transform, false);
        goMap[3614208344004240393L].transform.SetParent(goMap[-5672054666671336624L].transform, false);
        goMap[-2890472369134269897L].transform.SetParent(goMap[-5672054666671336624L].transform, false);
        goMap[7164213566470975811L].transform.SetParent(goMap[-5672054666671336624L].transform, false);
        goMap[-5065732609134337278L].transform.SetParent(goMap[-5672054666671336624L].transform, false);
        goMap[-131644770327765254L].transform.SetParent(goMap[-5672054666671336624L].transform, false);
        goMap[6942847734778764776L].transform.SetParent(goMap[-5672054666671336624L].transform, false);
        goMap[3902907734395517633L].transform.SetParent(goMap[-5672054666671336624L].transform, false);
        goMap[-1756068433598306997L].transform.SetParent(goMap[3902907734395517633L].transform, false);
        goMap[1235942746676039321L].transform.SetParent(goMap[-5672054666671336624L].transform, false);
        goMap[-9214956267585963084L].transform.SetParent(goMap[1235942746676039321L].transform, false);
        goMap[5399547955743535734L].transform.SetParent(goMap[-5672054666671336624L].transform, false);
        goMap[-7684511990707099075L].transform.SetParent(goMap[5399547955743535734L].transform, false);
        goMap[-4621261958724562655L].transform.SetParent(goMap[-5672054666671336624L].transform, false);
        goMap[-1161739683658855587L].transform.SetParent(goMap[-5672054666671336624L].transform, false);
        goMap[7097934953336531027L].transform.SetParent(goMap[-5672054666671336624L].transform, false);
        goMap[6093609156816985515L].transform.SetParent(goMap[-5672054666671336624L].transform, false);
        goMap[5470909357486236732L].transform.SetParent(goMap[6093609156816985515L].transform, false);
        goMap[4792398910692167065L].transform.SetParent(goMap[6093609156816985515L].transform, false);
        goMap[-4316481871989741389L].transform.SetParent(goMap[-7741648411971759812L].transform, false);
        goMap[6789453669242967106L].transform.SetParent(goMap[-4316481871989741389L].transform, false);
        goMap[-7398008622001293413L].transform.SetParent(goMap[6789453669242967106L].transform, false);
        goMap[5688869594172480997L].transform.SetParent(goMap[6789453669242967106L].transform, false);
        goMap[2757386761525363806L].transform.SetParent(goMap[6789453669242967106L].transform, false);
        goMap[-5308719843761229971L].transform.SetParent(goMap[-4316481871989741389L].transform, false);
        goMap[834651492000526268L].transform.SetParent(goMap[-5308719843761229971L].transform, false);
        goMap[-5104079435713966824L].transform.SetParent(goMap[834651492000526268L].transform, false);
        goMap[5449305954774952441L].transform.SetParent(goMap[-5308719843761229971L].transform, false);
        goMap[-2304202685755250079L].transform.SetParent(goMap[-4316481871989741389L].transform, false);
        goMap[1985221619168864184L].transform.SetParent(goMap[-4316481871989741389L].transform, false);
        goMap[-7812967673499400467L].transform.SetParent(goMap[1985221619168864184L].transform, false);
        goMap[-3096614008334680314L].transform.SetParent(goMap[-4316481871989741389L].transform, false);
        goMap[-5631834561915026799L].transform.SetParent(goMap[-3096614008334680314L].transform, false);

        // ─── RectTransforms ──────────────────────────────────
        {
            var rt = goMap[-530952539511192973L].AddComponent<RectTransform>();
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
            var rt = goMap[1237544823446787431L].AddComponent<RectTransform>();
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
            var rt = goMap[-7741648411971759812L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(11.000000f, -4.000000f);
            rt.sizeDelta = new Vector2(782.000000f, 632.000000f);
        }
        {
            var rt = goMap[6496384723354867089L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -3.500000f);
            rt.sizeDelta = new Vector2(734.000000f, 632.000000f);
        }
        {
            var rt = goMap[-1048173925215314851L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(359.000000f, 72.000000f);
            rt.sizeDelta = new Vector2(64.000000f, 90.000000f);
        }
        {
            var rt = goMap[-6409472771210974146L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(23.000000f, 287.000000f);
            rt.sizeDelta = new Vector2(434.000000f, 70.000000f);
        }
        {
            var rt = goMap[-8812391881331520679L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(131.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 70.000000f);
        }
        {
            var rt = goMap[-6286371172428373189L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(0.800000f, 0.780000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(52.000000f, 52.000000f);
        }
        {
            var rt = goMap[7957554589500756767L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(391.899994f, 287.399994f);
            rt.sizeDelta = new Vector2(44.000000f, 44.000000f);
        }
        {
            var rt = goMap[-7045675892246741563L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-10.000000f, 12.000000f);
            rt.sizeDelta = new Vector2(485.000000f, 412.000000f);
        }
        {
            var rt = goMap[-6959178057277519759L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(51.000000f, -51.000000f);
            rt.sizeDelta = new Vector2(102.000000f, 102.000000f);
        }
        {
            var rt = goMap[-2831686508410854079L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(102.000000f, 102.000000f);
        }
        {
            var rt = goMap[-2339120959881809807L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.720000f, 0.720000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[5035197687843713640L].AddComponent<RectTransform>();
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
            var rt = goMap[-7618770041494257442L].AddComponent<RectTransform>();
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
            var rt = goMap[-2285400191166724421L].AddComponent<RectTransform>();
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
            var rt = goMap[-2889215052763512915L].AddComponent<RectTransform>();
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
            var rt = goMap[-1969699695723536218L].AddComponent<RectTransform>();
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
            var rt = goMap[6564889592374029765L].AddComponent<RectTransform>();
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
            var rt = goMap[2511512401151602561L].AddComponent<RectTransform>();
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
            var rt = goMap[3382658767223394837L].AddComponent<RectTransform>();
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
            var rt = goMap[-35018585859007955L].AddComponent<RectTransform>();
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
            var rt = goMap[7221797610359877000L].AddComponent<RectTransform>();
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
            var rt = goMap[-2821348471682522009L].AddComponent<RectTransform>();
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
            var rt = goMap[-1676785437452364397L].AddComponent<RectTransform>();
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
            var rt = goMap[2373032883546668414L].AddComponent<RectTransform>();
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
            var rt = goMap[-4619890912434326870L].AddComponent<RectTransform>();
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
            var rt = goMap[6785202751957544351L].AddComponent<RectTransform>();
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
            var rt = goMap[2751685217077241257L].AddComponent<RectTransform>();
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
            var rt = goMap[2756910226099145686L].AddComponent<RectTransform>();
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
            var rt = goMap[-9185651290367197905L].AddComponent<RectTransform>();
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
            var rt = goMap[-8385832109621459112L].AddComponent<RectTransform>();
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
            var rt = goMap[-4763436585626852253L].AddComponent<RectTransform>();
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
            var rt = goMap[-2645216112389681032L].AddComponent<RectTransform>();
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
            var rt = goMap[2453440394282108337L].AddComponent<RectTransform>();
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
            var rt = goMap[468678153841821433L].AddComponent<RectTransform>();
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
            var rt = goMap[5646725436785184187L].AddComponent<RectTransform>();
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
            var rt = goMap[6460721506743374230L].AddComponent<RectTransform>();
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
            var rt = goMap[-7451192948842942841L].AddComponent<RectTransform>();
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
            var rt = goMap[1354625941047378844L].AddComponent<RectTransform>();
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
            var rt = goMap[-8738706388075742723L].AddComponent<RectTransform>();
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
            var rt = goMap[935514795542420135L].AddComponent<RectTransform>();
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
            var rt = goMap[-7594359136338575651L].AddComponent<RectTransform>();
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
            var rt = goMap[3731212983796224572L].AddComponent<RectTransform>();
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
            var rt = goMap[-392737364501195896L].AddComponent<RectTransform>();
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
            var rt = goMap[2841613070133622032L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(51.000000f, -151.000000f);
            rt.sizeDelta = new Vector2(102.000000f, 102.000000f);
        }
        {
            var rt = goMap[-4988810074645023889L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(102.000000f, 102.000000f);
        }
        {
            var rt = goMap[2047340335599326728L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.720000f, 0.720000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[6709104194550122760L].AddComponent<RectTransform>();
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
            var rt = goMap[-7785397558308939797L].AddComponent<RectTransform>();
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
            var rt = goMap[-2692911843489492650L].AddComponent<RectTransform>();
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
            var rt = goMap[-5659479714504479972L].AddComponent<RectTransform>();
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
            var rt = goMap[828417171665754036L].AddComponent<RectTransform>();
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
            var rt = goMap[4003942894495324816L].AddComponent<RectTransform>();
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
            var rt = goMap[7160229399895744252L].AddComponent<RectTransform>();
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
            var rt = goMap[-4427178065573516104L].AddComponent<RectTransform>();
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
            var rt = goMap[-4265867431189302692L].AddComponent<RectTransform>();
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
            var rt = goMap[-3509482534033452089L].AddComponent<RectTransform>();
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
            var rt = goMap[1753955458329894587L].AddComponent<RectTransform>();
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
            var rt = goMap[-1411144917474042382L].AddComponent<RectTransform>();
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
            var rt = goMap[-4304784207304754494L].AddComponent<RectTransform>();
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
            var rt = goMap[3935547857572528056L].AddComponent<RectTransform>();
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
            var rt = goMap[-1291571388378402241L].AddComponent<RectTransform>();
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
            var rt = goMap[-1038525985385277067L].AddComponent<RectTransform>();
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
            var rt = goMap[-6923880281196046419L].AddComponent<RectTransform>();
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
            var rt = goMap[-7037674693110203753L].AddComponent<RectTransform>();
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
            var rt = goMap[-2510395457031808888L].AddComponent<RectTransform>();
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
            var rt = goMap[8482495998215746989L].AddComponent<RectTransform>();
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
            var rt = goMap[-6163183374181559442L].AddComponent<RectTransform>();
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
            var rt = goMap[-812954737358892092L].AddComponent<RectTransform>();
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
            var rt = goMap[-2342273936036781804L].AddComponent<RectTransform>();
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
            var rt = goMap[117384091583299352L].AddComponent<RectTransform>();
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
            var rt = goMap[-4057634697521165401L].AddComponent<RectTransform>();
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
            var rt = goMap[-5747343911105630032L].AddComponent<RectTransform>();
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
            var rt = goMap[4577149306098047836L].AddComponent<RectTransform>();
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
            var rt = goMap[1365903304797663523L].AddComponent<RectTransform>();
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
            var rt = goMap[8513276619107819192L].AddComponent<RectTransform>();
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
            var rt = goMap[8052279758503742616L].AddComponent<RectTransform>();
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
            var rt = goMap[-8713228793197791329L].AddComponent<RectTransform>();
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
            var rt = goMap[-7977801324917535485L].AddComponent<RectTransform>();
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
            var rt = goMap[8235924642477159862L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(51.000000f, -251.000000f);
            rt.sizeDelta = new Vector2(102.000000f, 102.000000f);
        }
        {
            var rt = goMap[2644630784343507100L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(102.000000f, 102.000000f);
        }
        {
            var rt = goMap[-780696193793809583L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.720000f, 0.720000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-2199055589934537373L].AddComponent<RectTransform>();
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
            var rt = goMap[-6259935470873015027L].AddComponent<RectTransform>();
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
            var rt = goMap[-5707403456316849769L].AddComponent<RectTransform>();
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
            var rt = goMap[-1354096351710242146L].AddComponent<RectTransform>();
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
            var rt = goMap[-9178270468901734932L].AddComponent<RectTransform>();
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
            var rt = goMap[-7277837998518740561L].AddComponent<RectTransform>();
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
            var rt = goMap[5179008744008519177L].AddComponent<RectTransform>();
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
            var rt = goMap[-4168760214318772541L].AddComponent<RectTransform>();
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
            var rt = goMap[-2306850403838867871L].AddComponent<RectTransform>();
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
            var rt = goMap[3886011940583801547L].AddComponent<RectTransform>();
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
            var rt = goMap[8903288092914796881L].AddComponent<RectTransform>();
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
            var rt = goMap[2943435199980712421L].AddComponent<RectTransform>();
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
            var rt = goMap[-7103388226694789436L].AddComponent<RectTransform>();
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
            var rt = goMap[-3019447615700983432L].AddComponent<RectTransform>();
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
            var rt = goMap[6095395030151942335L].AddComponent<RectTransform>();
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
            var rt = goMap[5929353036565012880L].AddComponent<RectTransform>();
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
            var rt = goMap[5909346670532762525L].AddComponent<RectTransform>();
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
            var rt = goMap[887708270330023763L].AddComponent<RectTransform>();
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
            var rt = goMap[5580234528742680754L].AddComponent<RectTransform>();
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
            var rt = goMap[3261085653812602634L].AddComponent<RectTransform>();
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
            var rt = goMap[-5217579735090019196L].AddComponent<RectTransform>();
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
            var rt = goMap[-993483133408869621L].AddComponent<RectTransform>();
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
            var rt = goMap[-8220143743773992068L].AddComponent<RectTransform>();
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
            var rt = goMap[1128440315632879086L].AddComponent<RectTransform>();
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
            var rt = goMap[6953557680374727160L].AddComponent<RectTransform>();
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
            var rt = goMap[-1170435407500132975L].AddComponent<RectTransform>();
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
            var rt = goMap[2986583290605097019L].AddComponent<RectTransform>();
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
            var rt = goMap[-904286889202515445L].AddComponent<RectTransform>();
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
            var rt = goMap[6173264726392118532L].AddComponent<RectTransform>();
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
            var rt = goMap[3898238631152543171L].AddComponent<RectTransform>();
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
            var rt = goMap[539141545454901718L].AddComponent<RectTransform>();
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
            var rt = goMap[7389679714594753712L].AddComponent<RectTransform>();
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
            var rt = goMap[1818598192170335006L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(51.000000f, -351.000000f);
            rt.sizeDelta = new Vector2(102.000000f, 102.000000f);
        }
        {
            var rt = goMap[4756118330947438947L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(102.000000f, 102.000000f);
        }
        {
            var rt = goMap[-2969254269191482076L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.720000f, 0.720000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-2747133590769654289L].AddComponent<RectTransform>();
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
            var rt = goMap[3316991072999543507L].AddComponent<RectTransform>();
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
            var rt = goMap[-1056932844143038560L].AddComponent<RectTransform>();
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
            var rt = goMap[-6185558515373789866L].AddComponent<RectTransform>();
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
            var rt = goMap[-2462332175542322340L].AddComponent<RectTransform>();
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
            var rt = goMap[1650209262349969699L].AddComponent<RectTransform>();
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
            var rt = goMap[-5129925588215870390L].AddComponent<RectTransform>();
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
            var rt = goMap[-2991514388471886352L].AddComponent<RectTransform>();
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
            var rt = goMap[-1068832718366549766L].AddComponent<RectTransform>();
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
            var rt = goMap[7737591243062095058L].AddComponent<RectTransform>();
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
            var rt = goMap[3607688411957492950L].AddComponent<RectTransform>();
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
            var rt = goMap[-3849952560644415644L].AddComponent<RectTransform>();
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
            var rt = goMap[-6273487276266295590L].AddComponent<RectTransform>();
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
            var rt = goMap[7741378695028675943L].AddComponent<RectTransform>();
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
            var rt = goMap[-3477028317645482911L].AddComponent<RectTransform>();
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
            var rt = goMap[1886090582131228065L].AddComponent<RectTransform>();
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
            var rt = goMap[6327078442107999798L].AddComponent<RectTransform>();
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
            var rt = goMap[7073356767125253036L].AddComponent<RectTransform>();
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
            var rt = goMap[3542421210518926120L].AddComponent<RectTransform>();
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
            var rt = goMap[406455628800584870L].AddComponent<RectTransform>();
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
            var rt = goMap[-8150748596911203672L].AddComponent<RectTransform>();
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
            var rt = goMap[-74868981596848676L].AddComponent<RectTransform>();
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
            var rt = goMap[-5571368072696524685L].AddComponent<RectTransform>();
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
            var rt = goMap[4274259126662576580L].AddComponent<RectTransform>();
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
            var rt = goMap[6607367121880594206L].AddComponent<RectTransform>();
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
            var rt = goMap[8381002780691030183L].AddComponent<RectTransform>();
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
            var rt = goMap[-5217367109159946479L].AddComponent<RectTransform>();
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
            var rt = goMap[7273965044490187946L].AddComponent<RectTransform>();
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
            var rt = goMap[-3797229454583386668L].AddComponent<RectTransform>();
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
            var rt = goMap[4225400851029987153L].AddComponent<RectTransform>();
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
            var rt = goMap[5968032313552453206L].AddComponent<RectTransform>();
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
            var rt = goMap[-629706803690471377L].AddComponent<RectTransform>();
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
            var rt = goMap[3203654569723708702L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(153.500000f, -351.000000f);
            rt.sizeDelta = new Vector2(102.000000f, 102.000000f);
        }
        {
            var rt = goMap[-4004919049465411750L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(102.000000f, 102.000000f);
        }
        {
            var rt = goMap[4194297304323543147L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.720000f, 0.720000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-3783771068485415084L].AddComponent<RectTransform>();
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
            var rt = goMap[6502516323095144277L].AddComponent<RectTransform>();
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
            var rt = goMap[-1806627685724413089L].AddComponent<RectTransform>();
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
            var rt = goMap[7750096041181587338L].AddComponent<RectTransform>();
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
            var rt = goMap[-45981857361267538L].AddComponent<RectTransform>();
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
            var rt = goMap[3583785882062999907L].AddComponent<RectTransform>();
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
            var rt = goMap[1854188323772268177L].AddComponent<RectTransform>();
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
            var rt = goMap[-2707144691636398801L].AddComponent<RectTransform>();
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
            var rt = goMap[6819031330683157589L].AddComponent<RectTransform>();
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
            var rt = goMap[5482651682701006359L].AddComponent<RectTransform>();
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
            var rt = goMap[4797636452550945659L].AddComponent<RectTransform>();
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
            var rt = goMap[-8087478530635953379L].AddComponent<RectTransform>();
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
            var rt = goMap[-4057624814627753876L].AddComponent<RectTransform>();
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
            var rt = goMap[1277088060254502308L].AddComponent<RectTransform>();
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
            var rt = goMap[-5511441829023179228L].AddComponent<RectTransform>();
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
            var rt = goMap[2094144939881200617L].AddComponent<RectTransform>();
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
            var rt = goMap[7368225251734086024L].AddComponent<RectTransform>();
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
            var rt = goMap[-3048984516186313070L].AddComponent<RectTransform>();
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
            var rt = goMap[-8889852562522881302L].AddComponent<RectTransform>();
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
            var rt = goMap[-1839315582462150938L].AddComponent<RectTransform>();
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
            var rt = goMap[5368793025668648731L].AddComponent<RectTransform>();
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
            var rt = goMap[-2975432711635616719L].AddComponent<RectTransform>();
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
            var rt = goMap[4248838317101648056L].AddComponent<RectTransform>();
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
            var rt = goMap[-6246364200537742906L].AddComponent<RectTransform>();
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
            var rt = goMap[-5280317836490420235L].AddComponent<RectTransform>();
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
            var rt = goMap[6919660766227727534L].AddComponent<RectTransform>();
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
            var rt = goMap[-5542171321853228168L].AddComponent<RectTransform>();
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
            var rt = goMap[-2298401924145024944L].AddComponent<RectTransform>();
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
            var rt = goMap[-4187379582435832753L].AddComponent<RectTransform>();
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
            var rt = goMap[-8935351006806585305L].AddComponent<RectTransform>();
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
            var rt = goMap[-2753218195425567341L].AddComponent<RectTransform>();
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
            var rt = goMap[1531864095864878732L].AddComponent<RectTransform>();
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
            var rt = goMap[-6557785430215885438L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(256.000000f, -351.000000f);
            rt.sizeDelta = new Vector2(102.000000f, 102.000000f);
        }
        {
            var rt = goMap[-6244949745423807786L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(102.000000f, 102.000000f);
        }
        {
            var rt = goMap[-1660032452913207623L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.720000f, 0.720000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[3859934498748265959L].AddComponent<RectTransform>();
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
            var rt = goMap[258547390643155568L].AddComponent<RectTransform>();
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
            var rt = goMap[4350287868858106684L].AddComponent<RectTransform>();
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
            var rt = goMap[2518129077057491871L].AddComponent<RectTransform>();
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
            var rt = goMap[-7468606049957495883L].AddComponent<RectTransform>();
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
            var rt = goMap[5536058534585205598L].AddComponent<RectTransform>();
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
            var rt = goMap[-2915357637535509381L].AddComponent<RectTransform>();
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
            var rt = goMap[-4013312492994039685L].AddComponent<RectTransform>();
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
            var rt = goMap[5578147471128079548L].AddComponent<RectTransform>();
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
            var rt = goMap[5200651765324398648L].AddComponent<RectTransform>();
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
            var rt = goMap[3585479898826806734L].AddComponent<RectTransform>();
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
            var rt = goMap[-8235555614972968260L].AddComponent<RectTransform>();
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
            var rt = goMap[-4808438553405592758L].AddComponent<RectTransform>();
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
            var rt = goMap[-928689722833608946L].AddComponent<RectTransform>();
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
            var rt = goMap[-1491615210035932463L].AddComponent<RectTransform>();
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
            var rt = goMap[1943632073059430502L].AddComponent<RectTransform>();
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
            var rt = goMap[8581961768108890376L].AddComponent<RectTransform>();
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
            var rt = goMap[-6861360801964382209L].AddComponent<RectTransform>();
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
            var rt = goMap[-5618775290806992885L].AddComponent<RectTransform>();
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
            var rt = goMap[1255208121312004112L].AddComponent<RectTransform>();
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
            var rt = goMap[1324437040123722409L].AddComponent<RectTransform>();
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
            var rt = goMap[5116464727626368434L].AddComponent<RectTransform>();
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
            var rt = goMap[7612103997383136473L].AddComponent<RectTransform>();
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
            var rt = goMap[7468409178993271628L].AddComponent<RectTransform>();
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
            var rt = goMap[-4490376897510665074L].AddComponent<RectTransform>();
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
            var rt = goMap[6170809084645975647L].AddComponent<RectTransform>();
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
            var rt = goMap[-2185328281396515535L].AddComponent<RectTransform>();
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
            var rt = goMap[-621842661251458155L].AddComponent<RectTransform>();
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
            var rt = goMap[-4270564351483450102L].AddComponent<RectTransform>();
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
            var rt = goMap[1877497348024382598L].AddComponent<RectTransform>();
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
            var rt = goMap[4387906694162754338L].AddComponent<RectTransform>();
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
            var rt = goMap[-4164641553595051019L].AddComponent<RectTransform>();
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
            var rt = goMap[6886569599195319990L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(358.500000f, -351.000000f);
            rt.sizeDelta = new Vector2(102.000000f, 102.000000f);
        }
        {
            var rt = goMap[3569326097188466142L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(102.000000f, 102.000000f);
        }
        {
            var rt = goMap[3256290757132076363L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.720000f, 0.720000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-3206802188326003192L].AddComponent<RectTransform>();
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
            var rt = goMap[-7992722351109031519L].AddComponent<RectTransform>();
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
            var rt = goMap[-3703476882474036217L].AddComponent<RectTransform>();
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
            var rt = goMap[2547725499076561724L].AddComponent<RectTransform>();
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
            var rt = goMap[-6429517870701096137L].AddComponent<RectTransform>();
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
            var rt = goMap[-3861307512401056529L].AddComponent<RectTransform>();
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
            var rt = goMap[-3893583791612394962L].AddComponent<RectTransform>();
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
            var rt = goMap[7754430352565921336L].AddComponent<RectTransform>();
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
            var rt = goMap[5784300124308319141L].AddComponent<RectTransform>();
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
            var rt = goMap[-5319570853057360076L].AddComponent<RectTransform>();
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
            var rt = goMap[5661331876045189672L].AddComponent<RectTransform>();
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
            var rt = goMap[-5725024631616254166L].AddComponent<RectTransform>();
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
            var rt = goMap[-3914005005258374868L].AddComponent<RectTransform>();
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
            var rt = goMap[2023878650659462326L].AddComponent<RectTransform>();
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
            var rt = goMap[6385776964626232266L].AddComponent<RectTransform>();
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
            var rt = goMap[5478605813741346077L].AddComponent<RectTransform>();
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
            var rt = goMap[4440391946033369108L].AddComponent<RectTransform>();
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
            var rt = goMap[-7658658768117457682L].AddComponent<RectTransform>();
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
            var rt = goMap[9191134168714483198L].AddComponent<RectTransform>();
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
            var rt = goMap[-431245549300961747L].AddComponent<RectTransform>();
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
            var rt = goMap[2185518495806790478L].AddComponent<RectTransform>();
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
            var rt = goMap[-7310316910746679953L].AddComponent<RectTransform>();
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
            var rt = goMap[-753186279118087024L].AddComponent<RectTransform>();
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
            var rt = goMap[-421264179994258120L].AddComponent<RectTransform>();
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
            var rt = goMap[1189418231994101254L].AddComponent<RectTransform>();
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
            var rt = goMap[-2522277611558697722L].AddComponent<RectTransform>();
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
            var rt = goMap[3019259967916700993L].AddComponent<RectTransform>();
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
            var rt = goMap[6123882577084589483L].AddComponent<RectTransform>();
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
            var rt = goMap[664402229362451315L].AddComponent<RectTransform>();
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
            var rt = goMap[-7650318869590572907L].AddComponent<RectTransform>();
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
            var rt = goMap[2480033360837464480L].AddComponent<RectTransform>();
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
            var rt = goMap[-7366620873748422204L].AddComponent<RectTransform>();
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
            var rt = goMap[1595356721993304515L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(461.000000f, -351.000000f);
            rt.sizeDelta = new Vector2(102.000000f, 102.000000f);
        }
        {
            var rt = goMap[-5572456803609149599L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(102.000000f, 102.000000f);
        }
        {
            var rt = goMap[162078786380344046L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.720000f, 0.720000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-4459061989411866599L].AddComponent<RectTransform>();
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
            var rt = goMap[5389173865562054004L].AddComponent<RectTransform>();
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
            var rt = goMap[-1542549233695943954L].AddComponent<RectTransform>();
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
            var rt = goMap[-758400158961041734L].AddComponent<RectTransform>();
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
            var rt = goMap[4251515164245845223L].AddComponent<RectTransform>();
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
            var rt = goMap[-6636141275141599414L].AddComponent<RectTransform>();
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
            var rt = goMap[-3508559083789626954L].AddComponent<RectTransform>();
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
            var rt = goMap[-6076793695855127581L].AddComponent<RectTransform>();
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
            var rt = goMap[-8022097623875767155L].AddComponent<RectTransform>();
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
            var rt = goMap[3084556461343236870L].AddComponent<RectTransform>();
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
            var rt = goMap[-2502804922131173566L].AddComponent<RectTransform>();
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
            var rt = goMap[1377975162260520142L].AddComponent<RectTransform>();
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
            var rt = goMap[-7586487632728244221L].AddComponent<RectTransform>();
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
            var rt = goMap[-7620775324658509088L].AddComponent<RectTransform>();
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
            var rt = goMap[7569918802615195081L].AddComponent<RectTransform>();
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
            var rt = goMap[8654249257387496586L].AddComponent<RectTransform>();
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
            var rt = goMap[-1147449900313440380L].AddComponent<RectTransform>();
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
            var rt = goMap[-7459614203372114148L].AddComponent<RectTransform>();
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
            var rt = goMap[4993880972996822887L].AddComponent<RectTransform>();
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
            var rt = goMap[-7122437874173256294L].AddComponent<RectTransform>();
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
            var rt = goMap[-2878033329699973957L].AddComponent<RectTransform>();
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
            var rt = goMap[401080732301674078L].AddComponent<RectTransform>();
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
            var rt = goMap[-2814341700986650808L].AddComponent<RectTransform>();
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
            var rt = goMap[2710144149694006154L].AddComponent<RectTransform>();
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
            var rt = goMap[-6837416058809651670L].AddComponent<RectTransform>();
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
            var rt = goMap[4013423673232460561L].AddComponent<RectTransform>();
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
            var rt = goMap[-8950848934434519908L].AddComponent<RectTransform>();
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
            var rt = goMap[-3747978240577390605L].AddComponent<RectTransform>();
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
            var rt = goMap[5448532372314014984L].AddComponent<RectTransform>();
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
            var rt = goMap[-632295598915230293L].AddComponent<RectTransform>();
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
            var rt = goMap[-3247584279771251903L].AddComponent<RectTransform>();
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
            var rt = goMap[5217197697780506563L].AddComponent<RectTransform>();
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
            var rt = goMap[1663118642577024934L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(461.000000f, -251.000000f);
            rt.sizeDelta = new Vector2(102.000000f, 102.000000f);
        }
        {
            var rt = goMap[-73704323097791350L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(102.000000f, 102.000000f);
        }
        {
            var rt = goMap[9205755363516087646L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.720000f, 0.720000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-1642865896103847093L].AddComponent<RectTransform>();
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
            var rt = goMap[-8989895865271480841L].AddComponent<RectTransform>();
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
            var rt = goMap[7274919739472658569L].AddComponent<RectTransform>();
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
            var rt = goMap[-6474420241397276760L].AddComponent<RectTransform>();
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
            var rt = goMap[1981196291729700466L].AddComponent<RectTransform>();
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
            var rt = goMap[6146143904014342779L].AddComponent<RectTransform>();
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
            var rt = goMap[6206043328514573101L].AddComponent<RectTransform>();
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
            var rt = goMap[-900145749982296073L].AddComponent<RectTransform>();
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
            var rt = goMap[-8345511344440216439L].AddComponent<RectTransform>();
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
            var rt = goMap[-8551629439379484552L].AddComponent<RectTransform>();
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
            var rt = goMap[7355185180429482560L].AddComponent<RectTransform>();
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
            var rt = goMap[-5296215651904924457L].AddComponent<RectTransform>();
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
            var rt = goMap[-1589268852755538248L].AddComponent<RectTransform>();
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
            var rt = goMap[-3335551879107124431L].AddComponent<RectTransform>();
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
            var rt = goMap[-693530954936255824L].AddComponent<RectTransform>();
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
            var rt = goMap[6272798149034974544L].AddComponent<RectTransform>();
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
            var rt = goMap[3882805435572226329L].AddComponent<RectTransform>();
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
            var rt = goMap[6582776910553710131L].AddComponent<RectTransform>();
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
            var rt = goMap[5887803223407278764L].AddComponent<RectTransform>();
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
            var rt = goMap[-3616659947293336528L].AddComponent<RectTransform>();
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
            var rt = goMap[-7715521518177954685L].AddComponent<RectTransform>();
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
            var rt = goMap[2434601062884682979L].AddComponent<RectTransform>();
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
            var rt = goMap[-1922581952339719502L].AddComponent<RectTransform>();
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
            var rt = goMap[7895873382187774913L].AddComponent<RectTransform>();
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
            var rt = goMap[-194576399171645000L].AddComponent<RectTransform>();
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
            var rt = goMap[-2935697758642554993L].AddComponent<RectTransform>();
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
            var rt = goMap[2144337918547670652L].AddComponent<RectTransform>();
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
            var rt = goMap[5084932241245459628L].AddComponent<RectTransform>();
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
            var rt = goMap[3933394076467007949L].AddComponent<RectTransform>();
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
            var rt = goMap[-374201911436493508L].AddComponent<RectTransform>();
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
            var rt = goMap[-1025374096136740890L].AddComponent<RectTransform>();
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
            var rt = goMap[8595004814372084585L].AddComponent<RectTransform>();
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
            var rt = goMap[-7309444687643116399L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(461.000000f, -151.000000f);
            rt.sizeDelta = new Vector2(102.000000f, 102.000000f);
        }
        {
            var rt = goMap[6050447251632985150L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(102.000000f, 102.000000f);
        }
        {
            var rt = goMap[-2268300130891209069L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.720000f, 0.720000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[2378326900071587541L].AddComponent<RectTransform>();
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
            var rt = goMap[8168369866304933107L].AddComponent<RectTransform>();
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
            var rt = goMap[-5174309534820832584L].AddComponent<RectTransform>();
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
            var rt = goMap[-8231060882058414772L].AddComponent<RectTransform>();
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
            var rt = goMap[7373304116156363766L].AddComponent<RectTransform>();
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
            var rt = goMap[8906195386061717354L].AddComponent<RectTransform>();
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
            var rt = goMap[7892847533465812692L].AddComponent<RectTransform>();
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
            var rt = goMap[-2876244575501082604L].AddComponent<RectTransform>();
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
            var rt = goMap[-7415099686420225185L].AddComponent<RectTransform>();
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
            var rt = goMap[-4864082822081032184L].AddComponent<RectTransform>();
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
            var rt = goMap[3427259412550978892L].AddComponent<RectTransform>();
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
            var rt = goMap[-799171564556225449L].AddComponent<RectTransform>();
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
            var rt = goMap[7974702868045624266L].AddComponent<RectTransform>();
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
            var rt = goMap[-656587985902071198L].AddComponent<RectTransform>();
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
            var rt = goMap[-980586608958451626L].AddComponent<RectTransform>();
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
            var rt = goMap[562665163024275017L].AddComponent<RectTransform>();
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
            var rt = goMap[8333801475305311219L].AddComponent<RectTransform>();
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
            var rt = goMap[-5764902720471370084L].AddComponent<RectTransform>();
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
            var rt = goMap[5238608587787509558L].AddComponent<RectTransform>();
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
            var rt = goMap[-7540757176210170787L].AddComponent<RectTransform>();
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
            var rt = goMap[3553685321471580007L].AddComponent<RectTransform>();
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
            var rt = goMap[-197591211163696369L].AddComponent<RectTransform>();
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
            var rt = goMap[6984071307798181110L].AddComponent<RectTransform>();
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
            var rt = goMap[-8374112380971608967L].AddComponent<RectTransform>();
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
            var rt = goMap[1200566845871880307L].AddComponent<RectTransform>();
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
            var rt = goMap[-7037641143752962045L].AddComponent<RectTransform>();
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
            var rt = goMap[-6037309053294482300L].AddComponent<RectTransform>();
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
            var rt = goMap[-3115327118152154352L].AddComponent<RectTransform>();
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
            var rt = goMap[-6543105446751645424L].AddComponent<RectTransform>();
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
            var rt = goMap[6498122785235064957L].AddComponent<RectTransform>();
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
            var rt = goMap[8362856759373596002L].AddComponent<RectTransform>();
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
            var rt = goMap[109259675198610636L].AddComponent<RectTransform>();
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
            var rt = goMap[2965639596179616547L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(461.000000f, -51.000000f);
            rt.sizeDelta = new Vector2(102.000000f, 102.000000f);
        }
        {
            var rt = goMap[220428456418758578L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(102.000000f, 102.000000f);
        }
        {
            var rt = goMap[-8009926675464430123L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.720000f, 0.720000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-2555838729817560368L].AddComponent<RectTransform>();
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
            var rt = goMap[3264847616176402910L].AddComponent<RectTransform>();
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
            var rt = goMap[7475800658144970975L].AddComponent<RectTransform>();
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
            var rt = goMap[6418080242586951814L].AddComponent<RectTransform>();
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
            var rt = goMap[-4080550302726174419L].AddComponent<RectTransform>();
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
            var rt = goMap[-5714976616510214674L].AddComponent<RectTransform>();
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
            var rt = goMap[260657172871768196L].AddComponent<RectTransform>();
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
            var rt = goMap[7140514509794322496L].AddComponent<RectTransform>();
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
            var rt = goMap[-4940729278684384457L].AddComponent<RectTransform>();
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
            var rt = goMap[-6758392136145104355L].AddComponent<RectTransform>();
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
            var rt = goMap[-1980188168636719842L].AddComponent<RectTransform>();
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
            var rt = goMap[1945511589896611101L].AddComponent<RectTransform>();
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
            var rt = goMap[3479838084973489529L].AddComponent<RectTransform>();
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
            var rt = goMap[3793986255456268988L].AddComponent<RectTransform>();
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
            var rt = goMap[5150506781369034332L].AddComponent<RectTransform>();
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
            var rt = goMap[-3935790612616573192L].AddComponent<RectTransform>();
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
            var rt = goMap[3942483339803346154L].AddComponent<RectTransform>();
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
            var rt = goMap[-1658166954870918362L].AddComponent<RectTransform>();
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
            var rt = goMap[-575181074648501323L].AddComponent<RectTransform>();
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
            var rt = goMap[96847911620851889L].AddComponent<RectTransform>();
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
            var rt = goMap[-6583475327188434656L].AddComponent<RectTransform>();
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
            var rt = goMap[-6136508682829120932L].AddComponent<RectTransform>();
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
            var rt = goMap[-3234199561606740755L].AddComponent<RectTransform>();
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
            var rt = goMap[-7315441288776086324L].AddComponent<RectTransform>();
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
            var rt = goMap[531390889013143977L].AddComponent<RectTransform>();
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
            var rt = goMap[7481779225232934934L].AddComponent<RectTransform>();
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
            var rt = goMap[-8086346586055357343L].AddComponent<RectTransform>();
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
            var rt = goMap[-378640279643211297L].AddComponent<RectTransform>();
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
            var rt = goMap[3199508643747806029L].AddComponent<RectTransform>();
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
            var rt = goMap[-1653104402406472818L].AddComponent<RectTransform>();
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
            var rt = goMap[-5726366200773963988L].AddComponent<RectTransform>();
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
            var rt = goMap[-2823386897994125793L].AddComponent<RectTransform>();
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
            var rt = goMap[-7281530768682015014L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(358.500000f, -51.000000f);
            rt.sizeDelta = new Vector2(102.000000f, 102.000000f);
        }
        {
            var rt = goMap[-1855929211468115950L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(102.000000f, 102.000000f);
        }
        {
            var rt = goMap[-2786361121474131816L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.720000f, 0.720000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[309477125561651569L].AddComponent<RectTransform>();
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
            var rt = goMap[3374280535351502192L].AddComponent<RectTransform>();
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
            var rt = goMap[-366850427297400475L].AddComponent<RectTransform>();
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
            var rt = goMap[-7803183571198445711L].AddComponent<RectTransform>();
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
            var rt = goMap[-1927688012450094885L].AddComponent<RectTransform>();
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
            var rt = goMap[139295094796042983L].AddComponent<RectTransform>();
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
            var rt = goMap[5023509310148843131L].AddComponent<RectTransform>();
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
            var rt = goMap[-3365066893982352480L].AddComponent<RectTransform>();
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
            var rt = goMap[3521491654050434488L].AddComponent<RectTransform>();
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
            var rt = goMap[3233412841466314447L].AddComponent<RectTransform>();
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
            var rt = goMap[1190175795195419405L].AddComponent<RectTransform>();
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
            var rt = goMap[-7988713809276816343L].AddComponent<RectTransform>();
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
            var rt = goMap[5055907786938158942L].AddComponent<RectTransform>();
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
            var rt = goMap[-7351918411705901345L].AddComponent<RectTransform>();
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
            var rt = goMap[-123076985158000013L].AddComponent<RectTransform>();
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
            var rt = goMap[-6024470738857561803L].AddComponent<RectTransform>();
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
            var rt = goMap[4645460277573699346L].AddComponent<RectTransform>();
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
            var rt = goMap[-1611572446160023218L].AddComponent<RectTransform>();
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
            var rt = goMap[342241789552109340L].AddComponent<RectTransform>();
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
            var rt = goMap[7212110131603294907L].AddComponent<RectTransform>();
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
            var rt = goMap[4645359045161815676L].AddComponent<RectTransform>();
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
            var rt = goMap[-8042487701915378318L].AddComponent<RectTransform>();
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
            var rt = goMap[-4712080362788068618L].AddComponent<RectTransform>();
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
            var rt = goMap[-2084517210091289812L].AddComponent<RectTransform>();
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
            var rt = goMap[331772348087123986L].AddComponent<RectTransform>();
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
            var rt = goMap[-9168339921928156106L].AddComponent<RectTransform>();
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
            var rt = goMap[7635564418589756352L].AddComponent<RectTransform>();
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
            var rt = goMap[-3504544829515422575L].AddComponent<RectTransform>();
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
            var rt = goMap[4678314847436373733L].AddComponent<RectTransform>();
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
            var rt = goMap[6207036371573398290L].AddComponent<RectTransform>();
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
            var rt = goMap[2186732890953018367L].AddComponent<RectTransform>();
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
            var rt = goMap[8039820574805633968L].AddComponent<RectTransform>();
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
            var rt = goMap[8269142522574968021L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(256.000000f, -51.000000f);
            rt.sizeDelta = new Vector2(102.000000f, 102.000000f);
        }
        {
            var rt = goMap[-2665572518284299046L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(102.000000f, 102.000000f);
        }
        {
            var rt = goMap[-5510519897795049125L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.720000f, 0.720000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[1632436747866668060L].AddComponent<RectTransform>();
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
            var rt = goMap[6443748589094228407L].AddComponent<RectTransform>();
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
            var rt = goMap[-1290796867381821885L].AddComponent<RectTransform>();
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
            var rt = goMap[6682867503231978052L].AddComponent<RectTransform>();
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
            var rt = goMap[238224093019188941L].AddComponent<RectTransform>();
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
            var rt = goMap[-9218032090682951194L].AddComponent<RectTransform>();
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
            var rt = goMap[5689150910811022587L].AddComponent<RectTransform>();
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
            var rt = goMap[5583822471829505566L].AddComponent<RectTransform>();
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
            var rt = goMap[-2336819022152583553L].AddComponent<RectTransform>();
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
            var rt = goMap[1799849665726952850L].AddComponent<RectTransform>();
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
            var rt = goMap[4862550098728663682L].AddComponent<RectTransform>();
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
            var rt = goMap[1315618604124949646L].AddComponent<RectTransform>();
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
            var rt = goMap[-5483252812310593894L].AddComponent<RectTransform>();
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
            var rt = goMap[918582564678823665L].AddComponent<RectTransform>();
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
            var rt = goMap[4046833811904718556L].AddComponent<RectTransform>();
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
            var rt = goMap[-4153682306255988263L].AddComponent<RectTransform>();
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
            var rt = goMap[4322287215292411231L].AddComponent<RectTransform>();
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
            var rt = goMap[-1996116205181667262L].AddComponent<RectTransform>();
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
            var rt = goMap[-7061633926358787167L].AddComponent<RectTransform>();
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
            var rt = goMap[-4203840812857488190L].AddComponent<RectTransform>();
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
            var rt = goMap[1626280828237840168L].AddComponent<RectTransform>();
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
            var rt = goMap[-3552916326029274164L].AddComponent<RectTransform>();
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
            var rt = goMap[5108911299483461114L].AddComponent<RectTransform>();
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
            var rt = goMap[-580421857412706967L].AddComponent<RectTransform>();
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
            var rt = goMap[8937777941304791581L].AddComponent<RectTransform>();
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
            var rt = goMap[-9067689547174741385L].AddComponent<RectTransform>();
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
            var rt = goMap[5241138162347462331L].AddComponent<RectTransform>();
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
            var rt = goMap[-1784573481267764908L].AddComponent<RectTransform>();
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
            var rt = goMap[-2031584657449456117L].AddComponent<RectTransform>();
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
            var rt = goMap[-4837959988399956591L].AddComponent<RectTransform>();
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
            var rt = goMap[-1263048765459368588L].AddComponent<RectTransform>();
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
            var rt = goMap[7689126718433443884L].AddComponent<RectTransform>();
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
            var rt = goMap[663443784623078094L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(153.500000f, -51.000000f);
            rt.sizeDelta = new Vector2(102.000000f, 102.000000f);
        }
        {
            var rt = goMap[-4441438487826942939L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(102.000000f, 102.000000f);
        }
        {
            var rt = goMap[-5672054666671336624L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.720000f, 0.720000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[1934965008272520929L].AddComponent<RectTransform>();
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
            var rt = goMap[-3914668558201226401L].AddComponent<RectTransform>();
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
            var rt = goMap[-9025270563583067234L].AddComponent<RectTransform>();
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
            var rt = goMap[-1426553099175553763L].AddComponent<RectTransform>();
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
            var rt = goMap[-4741887140592962283L].AddComponent<RectTransform>();
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
            var rt = goMap[1173539502285042023L].AddComponent<RectTransform>();
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
            var rt = goMap[-6313177268042651810L].AddComponent<RectTransform>();
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
            var rt = goMap[-3043534514911786430L].AddComponent<RectTransform>();
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
            var rt = goMap[4593530615845601401L].AddComponent<RectTransform>();
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
            var rt = goMap[1240241652354211560L].AddComponent<RectTransform>();
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
            var rt = goMap[-1584673111506814084L].AddComponent<RectTransform>();
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
            var rt = goMap[5979928834058709445L].AddComponent<RectTransform>();
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
            var rt = goMap[-2717411965676524757L].AddComponent<RectTransform>();
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
            var rt = goMap[7042675463309729403L].AddComponent<RectTransform>();
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
            var rt = goMap[3614208344004240393L].AddComponent<RectTransform>();
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
            var rt = goMap[-2890472369134269897L].AddComponent<RectTransform>();
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
            var rt = goMap[7164213566470975811L].AddComponent<RectTransform>();
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
            var rt = goMap[-5065732609134337278L].AddComponent<RectTransform>();
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
            var rt = goMap[-131644770327765254L].AddComponent<RectTransform>();
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
            var rt = goMap[6942847734778764776L].AddComponent<RectTransform>();
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
            var rt = goMap[3902907734395517633L].AddComponent<RectTransform>();
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
            var rt = goMap[-1756068433598306997L].AddComponent<RectTransform>();
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
            var rt = goMap[1235942746676039321L].AddComponent<RectTransform>();
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
            var rt = goMap[-9214956267585963084L].AddComponent<RectTransform>();
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
            var rt = goMap[5399547955743535734L].AddComponent<RectTransform>();
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
            var rt = goMap[-7684511990707099075L].AddComponent<RectTransform>();
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
            var rt = goMap[-4621261958724562655L].AddComponent<RectTransform>();
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
            var rt = goMap[-1161739683658855587L].AddComponent<RectTransform>();
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
            var rt = goMap[7097934953336531027L].AddComponent<RectTransform>();
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
            var rt = goMap[6093609156816985515L].AddComponent<RectTransform>();
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
            var rt = goMap[5470909357486236732L].AddComponent<RectTransform>();
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
            var rt = goMap[4792398910692167065L].AddComponent<RectTransform>();
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
            var rt = goMap[-4316481871989741389L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(1.850000f, -33.900002f);
            rt.sizeDelta = new Vector2(633.500000f, 571.700012f);
        }
        {
            var rt = goMap[6789453669242967106L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-4.000000f, 57.700001f);
            rt.sizeDelta = new Vector2(188.000000f, 188.000000f);
        }
        {
            var rt = goMap[-7398008622001293413L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000021f, 0.000592f);
            rt.sizeDelta = new Vector2(192.590698f, 207.130005f);
        }
        {
            var rt = goMap[5688869594172480997L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(10.500000f, 8.000000f);
            rt.sizeDelta = new Vector2(188.000000f, 188.000000f);
        }
        {
            var rt = goMap[2757386761525363806L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(10.500000f, 8.000000f);
            rt.sizeDelta = new Vector2(188.000000f, 188.000000f);
        }
        {
            var rt = goMap[-5308719843761229971L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-24.000000f, -27.000000f);
            rt.sizeDelta = new Vector2(235.000000f, 36.000000f);
        }
        {
            var rt = goMap[834651492000526268L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(17.600000f, -17.650000f);
            rt.sizeDelta = new Vector2(34.000000f, 34.000000f);
        }
        {
            var rt = goMap[-5104079435713966824L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(2.100000f, 0.000000f);
            rt.sizeDelta = new Vector2(38.000000f, 34.000000f);
        }
        {
            var rt = goMap[5449305954774952441L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(17.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(-38.000000f, -4.000000f);
        }
        {
            var rt = goMap[-2304202685755250079L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(121.589996f, -27.100000f);
            rt.sizeDelta = new Vector2(63.180000f, 36.000000f);
        }
        {
            var rt = goMap[1985221619168864184L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(-1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-183.000000f, -215.000000f);
            rt.sizeDelta = new Vector2(250.000000f, 70.000000f);
        }
        {
            var rt = goMap[-7812967673499400467L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(-1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 12.000000f);
            rt.sizeDelta = new Vector2(200.000000f, 52.000000f);
        }
        {
            var rt = goMap[-3096614008334680314L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(186.699997f, -215.000000f);
            rt.sizeDelta = new Vector2(250.000000f, 70.000000f);
        }
        {
            var rt = goMap[-5631834561915026799L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 12.000000f);
            rt.sizeDelta = new Vector2(200.000000f, 52.000000f);
        }

        // ─── Components ──────────────────────────────────────
        { var c = goMap[-530952539511192973L].AddComponent<Canvas>();
           c.renderMode = (RenderMode)1;
           c.overrideSorting = false;
           c.sortingOrder = 0;
           c.sortingLayerID = unchecked((int)194136777);
           c.planeDistance = 8.660000f;
           c.pixelPerfect = false;
           c.additionalShaderChannels = (AdditionalCanvasShaderChannels)0;
           c.enabled = true;
        }
        { var c = goMap[-530952539511192973L].AddComponent<CanvasScaler>();
           c.uiScaleMode = (CanvasScaler.ScaleMode)1;
           c.referenceResolution = new Vector2(1280.000000f, 720.000000f);
           c.screenMatchMode = (CanvasScaler.ScreenMatchMode)1;
           c.matchWidthOrHeight = 0.000000f;
           c.referencePixelsPerUnit = 100.000000f;
        }
        { var c = goMap[-530952539511192973L].AddComponent<GraphicRaycaster>();
           c.ignoreReversedGraphics = true;
        }
        { var c = goMap[-530952539511192973L].AddComponent<Image>();
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
        { var c = goMap[6496384723354867089L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_goldshell_bg");
        }
        { var c = goMap[-1048173925215314851L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_rockingbar");
        }
        { var c = goMap[-6409472771210974146L].AddComponent<HorizontalLayoutGroup>();
           c.padding = new RectOffset(0,0,0,0);
           c.spacing = 12.000000f;
           c.childAlignment = (TextAnchor)4;
           c.childForceExpandWidth = false;
           c.childForceExpandHeight = false;
           c.childControlWidth = false;
           c.childControlHeight = false;
           c.reverseArrangement = false;
        }
        { var c = goMap[-8812391881331520679L].AddComponent<Text>();
           c.text = "11842";
           c.color = new Color(0.643137f, 0.133333f, 0.133333f, 1.000000f);
           c.fontSize = 36;
           c.fontStyle = FontStyle.Bold;
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
        { var c = goMap[-8812391881331520679L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)2;
           c.verticalFit = (ContentSizeFitter.FitMode)0;
        }
        { var c = goMap[-6286371172428373189L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-6286371172428373189L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-6286371172428373189L].AddComponent<UIScalePulse>();
           c.upScale = 0.950000f; c.duration = 0.100000f; c.scaleUp = false;
           c.enabled = true;
        }
        { var c = goMap[7957554589500756767L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[7957554589500756767L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[7957554589500756767L].AddComponent<UIScalePulse>();
           c.upScale = 0.950000f; c.duration = 0.100000f; c.scaleUp = false;
           c.enabled = true;
        }
        { var c = goMap[-2831686508410854079L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("imgimg_goldshell_slected");
        }
        { var c = goMap[5035197687843713640L].AddComponent<Image>();
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
        { var c = goMap[-7618770041494257442L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-2285400191166724421L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-2285400191166724421L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-2889215052763512915L].AddComponent<Image>();
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
        { var c = goMap[-1969699695723536218L].AddComponent<Text>();
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
        { var c = goMap[-1969699695723536218L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[6564889592374029765L].AddComponent<Text>();
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
        { var c = goMap[6564889592374029765L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[2511512401151602561L].AddComponent<Text>();
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
        { var c = goMap[2511512401151602561L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[3382658767223394837L].AddComponent<Text>();
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
        { var c = goMap[3382658767223394837L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-35018585859007955L].AddComponent<Text>();
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
        { var c = goMap[-35018585859007955L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[7221797610359877000L].AddComponent<Image>();
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
        { var c = goMap[-2821348471682522009L].AddComponent<Image>();
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
        { var c = goMap[-1676785437452364397L].AddComponent<Image>();
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
        { var c = goMap[2373032883546668414L].AddComponent<Text>();
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
        { var c = goMap[2373032883546668414L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-4619890912434326870L].AddComponent<Image>();
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
        { var c = goMap[6785202751957544351L].AddComponent<Image>();
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
        { var c = goMap[2751685217077241257L].AddComponent<Image>();
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
        { var c = goMap[2756910226099145686L].AddComponent<Image>();
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
        { var c = goMap[-9185651290367197905L].AddComponent<Image>();
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
        { var c = goMap[-8385832109621459112L].AddComponent<Image>();
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
        { var c = goMap[-2645216112389681032L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[2453440394282108337L].AddComponent<Text>();
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
        { var g = goMap[2453440394282108337L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.866667f, 0.988235f, 0.933333f, 1.000000f); }
        { var c = goMap[2453440394282108337L].AddComponent<Outline>();
           c.effectColor = new Color(0.227451f, 0.196078f, 0.078431f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[468678153841821433L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[5646725436785184187L].AddComponent<Text>();
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
        { var g = goMap[5646725436785184187L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.992157f, 0.886275f, 0.447059f, 1.000000f); }
        { var c = goMap[5646725436785184187L].AddComponent<Outline>();
           c.effectColor = new Color(0.227451f, 0.196078f, 0.078431f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[6460721506743374230L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-7451192948842942841L].AddComponent<Text>();
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
        { var c = goMap[-7451192948842942841L].AddComponent<Outline>();
           c.effectColor = new Color(0.286275f, 0.090196f, 0.031373f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[1354625941047378844L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-8738706388075742723L].AddComponent<Image>();
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
        { var c = goMap[935514795542420135L].AddComponent<Text>();
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
        { var c = goMap[935514795542420135L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-7594359136338575651L].AddComponent<Image>();
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
        { var c = goMap[3731212983796224572L].AddComponent<Image>();
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
        { var c = goMap[3731212983796224572L].AddComponent<Outline>();
           c.effectColor = new Color(0.584906f, 0.584906f, 0.584906f, 0.262745f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-392737364501195896L].AddComponent<Image>();
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
        { var c = goMap[-392737364501195896L].AddComponent<Outline>();
           c.effectColor = new Color(0.584906f, 0.584906f, 0.584906f, 0.262745f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-4988810074645023889L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("imgimg_goldshell_slected");
        }
        { var c = goMap[6709104194550122760L].AddComponent<Image>();
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
        { var c = goMap[-7785397558308939797L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-2692911843489492650L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-2692911843489492650L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-5659479714504479972L].AddComponent<Image>();
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
        { var c = goMap[828417171665754036L].AddComponent<Text>();
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
        { var c = goMap[828417171665754036L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[4003942894495324816L].AddComponent<Text>();
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
        { var c = goMap[4003942894495324816L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[7160229399895744252L].AddComponent<Text>();
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
        { var c = goMap[7160229399895744252L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-4427178065573516104L].AddComponent<Text>();
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
        { var c = goMap[-4427178065573516104L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-4265867431189302692L].AddComponent<Text>();
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
        { var c = goMap[-4265867431189302692L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-3509482534033452089L].AddComponent<Image>();
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
        { var c = goMap[1753955458329894587L].AddComponent<Image>();
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
        { var c = goMap[-1411144917474042382L].AddComponent<Image>();
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
        { var c = goMap[-4304784207304754494L].AddComponent<Text>();
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
        { var c = goMap[-4304784207304754494L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[3935547857572528056L].AddComponent<Image>();
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
        { var c = goMap[-1291571388378402241L].AddComponent<Image>();
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
        { var c = goMap[-1038525985385277067L].AddComponent<Image>();
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
        { var c = goMap[-6923880281196046419L].AddComponent<Image>();
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
        { var c = goMap[-7037674693110203753L].AddComponent<Image>();
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
        { var c = goMap[-2510395457031808888L].AddComponent<Image>();
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
        { var c = goMap[-6163183374181559442L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-812954737358892092L].AddComponent<Text>();
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
        { var g = goMap[-812954737358892092L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.866667f, 0.988235f, 0.933333f, 1.000000f); }
        { var c = goMap[-812954737358892092L].AddComponent<Outline>();
           c.effectColor = new Color(0.227451f, 0.196078f, 0.078431f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-2342273936036781804L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[117384091583299352L].AddComponent<Text>();
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
        { var g = goMap[117384091583299352L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.992157f, 0.886275f, 0.447059f, 1.000000f); }
        { var c = goMap[117384091583299352L].AddComponent<Outline>();
           c.effectColor = new Color(0.227451f, 0.196078f, 0.078431f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-4057634697521165401L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-5747343911105630032L].AddComponent<Text>();
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
        { var c = goMap[-5747343911105630032L].AddComponent<Outline>();
           c.effectColor = new Color(0.286275f, 0.090196f, 0.031373f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[4577149306098047836L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[1365903304797663523L].AddComponent<Image>();
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
        { var c = goMap[8513276619107819192L].AddComponent<Text>();
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
        { var c = goMap[8513276619107819192L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[8052279758503742616L].AddComponent<Image>();
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
        { var c = goMap[-8713228793197791329L].AddComponent<Image>();
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
        { var c = goMap[-8713228793197791329L].AddComponent<Outline>();
           c.effectColor = new Color(0.584906f, 0.584906f, 0.584906f, 0.262745f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-7977801324917535485L].AddComponent<Image>();
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
        { var c = goMap[-7977801324917535485L].AddComponent<Outline>();
           c.effectColor = new Color(0.584906f, 0.584906f, 0.584906f, 0.262745f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[2644630784343507100L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("imgimg_goldshell_slected");
        }
        { var c = goMap[-2199055589934537373L].AddComponent<Image>();
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
        { var c = goMap[-6259935470873015027L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-5707403456316849769L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-5707403456316849769L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-1354096351710242146L].AddComponent<Image>();
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
        { var c = goMap[-9178270468901734932L].AddComponent<Text>();
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
        { var c = goMap[-9178270468901734932L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-7277837998518740561L].AddComponent<Text>();
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
        { var c = goMap[-7277837998518740561L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[5179008744008519177L].AddComponent<Text>();
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
        { var c = goMap[5179008744008519177L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-4168760214318772541L].AddComponent<Text>();
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
        { var c = goMap[-4168760214318772541L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-2306850403838867871L].AddComponent<Text>();
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
        { var c = goMap[-2306850403838867871L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[3886011940583801547L].AddComponent<Image>();
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
        { var c = goMap[8903288092914796881L].AddComponent<Image>();
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
        { var c = goMap[2943435199980712421L].AddComponent<Image>();
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
        { var c = goMap[-7103388226694789436L].AddComponent<Text>();
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
        { var c = goMap[-7103388226694789436L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-3019447615700983432L].AddComponent<Image>();
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
        { var c = goMap[6095395030151942335L].AddComponent<Image>();
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
        { var c = goMap[5929353036565012880L].AddComponent<Image>();
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
        { var c = goMap[5909346670532762525L].AddComponent<Image>();
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
        { var c = goMap[887708270330023763L].AddComponent<Image>();
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
        { var c = goMap[5580234528742680754L].AddComponent<Image>();
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
        { var c = goMap[-5217579735090019196L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-993483133408869621L].AddComponent<Text>();
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
        { var g = goMap[-993483133408869621L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.866667f, 0.988235f, 0.933333f, 1.000000f); }
        { var c = goMap[-993483133408869621L].AddComponent<Outline>();
           c.effectColor = new Color(0.227451f, 0.196078f, 0.078431f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-8220143743773992068L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[1128440315632879086L].AddComponent<Text>();
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
        { var g = goMap[1128440315632879086L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.992157f, 0.886275f, 0.447059f, 1.000000f); }
        { var c = goMap[1128440315632879086L].AddComponent<Outline>();
           c.effectColor = new Color(0.227451f, 0.196078f, 0.078431f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[6953557680374727160L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-1170435407500132975L].AddComponent<Text>();
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
        { var c = goMap[-1170435407500132975L].AddComponent<Outline>();
           c.effectColor = new Color(0.286275f, 0.090196f, 0.031373f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[2986583290605097019L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-904286889202515445L].AddComponent<Image>();
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
        { var c = goMap[6173264726392118532L].AddComponent<Text>();
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
        { var c = goMap[6173264726392118532L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[3898238631152543171L].AddComponent<Image>();
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
        { var c = goMap[539141545454901718L].AddComponent<Image>();
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
        { var c = goMap[539141545454901718L].AddComponent<Outline>();
           c.effectColor = new Color(0.584906f, 0.584906f, 0.584906f, 0.262745f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[7389679714594753712L].AddComponent<Image>();
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
        { var c = goMap[7389679714594753712L].AddComponent<Outline>();
           c.effectColor = new Color(0.584906f, 0.584906f, 0.584906f, 0.262745f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[4756118330947438947L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("imgimg_goldshell_slected");
        }
        { var c = goMap[-2747133590769654289L].AddComponent<Image>();
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
        { var c = goMap[3316991072999543507L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-1056932844143038560L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-1056932844143038560L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-6185558515373789866L].AddComponent<Image>();
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
        { var c = goMap[-2462332175542322340L].AddComponent<Text>();
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
        { var c = goMap[-2462332175542322340L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[1650209262349969699L].AddComponent<Text>();
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
        { var c = goMap[1650209262349969699L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-5129925588215870390L].AddComponent<Text>();
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
        { var c = goMap[-5129925588215870390L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-2991514388471886352L].AddComponent<Text>();
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
        { var c = goMap[-2991514388471886352L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-1068832718366549766L].AddComponent<Text>();
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
        { var c = goMap[-1068832718366549766L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[7737591243062095058L].AddComponent<Image>();
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
        { var c = goMap[3607688411957492950L].AddComponent<Image>();
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
        { var c = goMap[-3849952560644415644L].AddComponent<Image>();
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
        { var c = goMap[-6273487276266295590L].AddComponent<Text>();
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
        { var c = goMap[-6273487276266295590L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[7741378695028675943L].AddComponent<Image>();
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
        { var c = goMap[-3477028317645482911L].AddComponent<Image>();
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
        { var c = goMap[1886090582131228065L].AddComponent<Image>();
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
        { var c = goMap[6327078442107999798L].AddComponent<Image>();
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
        { var c = goMap[7073356767125253036L].AddComponent<Image>();
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
        { var c = goMap[3542421210518926120L].AddComponent<Image>();
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
        { var c = goMap[-8150748596911203672L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-74868981596848676L].AddComponent<Text>();
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
        { var g = goMap[-74868981596848676L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.866667f, 0.988235f, 0.933333f, 1.000000f); }
        { var c = goMap[-74868981596848676L].AddComponent<Outline>();
           c.effectColor = new Color(0.227451f, 0.196078f, 0.078431f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-5571368072696524685L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[4274259126662576580L].AddComponent<Text>();
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
        { var g = goMap[4274259126662576580L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.992157f, 0.886275f, 0.447059f, 1.000000f); }
        { var c = goMap[4274259126662576580L].AddComponent<Outline>();
           c.effectColor = new Color(0.227451f, 0.196078f, 0.078431f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[6607367121880594206L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[8381002780691030183L].AddComponent<Text>();
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
        { var c = goMap[8381002780691030183L].AddComponent<Outline>();
           c.effectColor = new Color(0.286275f, 0.090196f, 0.031373f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-5217367109159946479L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[7273965044490187946L].AddComponent<Image>();
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
        { var c = goMap[-3797229454583386668L].AddComponent<Text>();
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
        { var c = goMap[-3797229454583386668L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[4225400851029987153L].AddComponent<Image>();
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
        { var c = goMap[5968032313552453206L].AddComponent<Image>();
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
        { var c = goMap[5968032313552453206L].AddComponent<Outline>();
           c.effectColor = new Color(0.584906f, 0.584906f, 0.584906f, 0.262745f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-629706803690471377L].AddComponent<Image>();
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
        { var c = goMap[-629706803690471377L].AddComponent<Outline>();
           c.effectColor = new Color(0.584906f, 0.584906f, 0.584906f, 0.262745f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-4004919049465411750L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("imgimg_goldshell_slected");
        }
        { var c = goMap[-3783771068485415084L].AddComponent<Image>();
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
        { var c = goMap[6502516323095144277L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-1806627685724413089L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-1806627685724413089L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[7750096041181587338L].AddComponent<Image>();
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
        { var c = goMap[-45981857361267538L].AddComponent<Text>();
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
        { var c = goMap[-45981857361267538L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[3583785882062999907L].AddComponent<Text>();
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
        { var c = goMap[3583785882062999907L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[1854188323772268177L].AddComponent<Text>();
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
        { var c = goMap[1854188323772268177L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-2707144691636398801L].AddComponent<Text>();
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
        { var c = goMap[-2707144691636398801L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[6819031330683157589L].AddComponent<Text>();
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
        { var c = goMap[6819031330683157589L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[5482651682701006359L].AddComponent<Image>();
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
        { var c = goMap[4797636452550945659L].AddComponent<Image>();
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
        { var c = goMap[-8087478530635953379L].AddComponent<Image>();
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
        { var c = goMap[-4057624814627753876L].AddComponent<Text>();
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
        { var c = goMap[-4057624814627753876L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[1277088060254502308L].AddComponent<Image>();
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
        { var c = goMap[-5511441829023179228L].AddComponent<Image>();
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
        { var c = goMap[2094144939881200617L].AddComponent<Image>();
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
        { var c = goMap[7368225251734086024L].AddComponent<Image>();
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
        { var c = goMap[-3048984516186313070L].AddComponent<Image>();
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
        { var c = goMap[-8889852562522881302L].AddComponent<Image>();
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
        { var c = goMap[5368793025668648731L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-2975432711635616719L].AddComponent<Text>();
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
        { var g = goMap[-2975432711635616719L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.866667f, 0.988235f, 0.933333f, 1.000000f); }
        { var c = goMap[-2975432711635616719L].AddComponent<Outline>();
           c.effectColor = new Color(0.227451f, 0.196078f, 0.078431f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[4248838317101648056L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-6246364200537742906L].AddComponent<Text>();
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
        { var g = goMap[-6246364200537742906L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.992157f, 0.886275f, 0.447059f, 1.000000f); }
        { var c = goMap[-6246364200537742906L].AddComponent<Outline>();
           c.effectColor = new Color(0.227451f, 0.196078f, 0.078431f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-5280317836490420235L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[6919660766227727534L].AddComponent<Text>();
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
        { var c = goMap[6919660766227727534L].AddComponent<Outline>();
           c.effectColor = new Color(0.286275f, 0.090196f, 0.031373f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-5542171321853228168L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-2298401924145024944L].AddComponent<Image>();
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
        { var c = goMap[-4187379582435832753L].AddComponent<Text>();
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
        { var c = goMap[-4187379582435832753L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-8935351006806585305L].AddComponent<Image>();
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
        { var c = goMap[-2753218195425567341L].AddComponent<Image>();
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
        { var c = goMap[-2753218195425567341L].AddComponent<Outline>();
           c.effectColor = new Color(0.584906f, 0.584906f, 0.584906f, 0.262745f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[1531864095864878732L].AddComponent<Image>();
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
        { var c = goMap[1531864095864878732L].AddComponent<Outline>();
           c.effectColor = new Color(0.584906f, 0.584906f, 0.584906f, 0.262745f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-6244949745423807786L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("imgimg_goldshell_slected");
        }
        { var c = goMap[3859934498748265959L].AddComponent<Image>();
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
        { var c = goMap[258547390643155568L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[4350287868858106684L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[4350287868858106684L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[2518129077057491871L].AddComponent<Image>();
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
        { var c = goMap[-7468606049957495883L].AddComponent<Text>();
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
        { var c = goMap[-7468606049957495883L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[5536058534585205598L].AddComponent<Text>();
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
        { var c = goMap[5536058534585205598L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-2915357637535509381L].AddComponent<Text>();
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
        { var c = goMap[-2915357637535509381L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-4013312492994039685L].AddComponent<Text>();
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
        { var c = goMap[-4013312492994039685L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[5578147471128079548L].AddComponent<Text>();
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
        { var c = goMap[5578147471128079548L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[5200651765324398648L].AddComponent<Image>();
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
        { var c = goMap[3585479898826806734L].AddComponent<Image>();
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
        { var c = goMap[-8235555614972968260L].AddComponent<Image>();
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
        { var c = goMap[-4808438553405592758L].AddComponent<Text>();
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
        { var c = goMap[-4808438553405592758L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-928689722833608946L].AddComponent<Image>();
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
        { var c = goMap[-1491615210035932463L].AddComponent<Image>();
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
        { var c = goMap[1943632073059430502L].AddComponent<Image>();
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
        { var c = goMap[8581961768108890376L].AddComponent<Image>();
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
        { var c = goMap[-6861360801964382209L].AddComponent<Image>();
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
        { var c = goMap[-5618775290806992885L].AddComponent<Image>();
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
        { var c = goMap[1324437040123722409L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[5116464727626368434L].AddComponent<Text>();
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
        { var g = goMap[5116464727626368434L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.866667f, 0.988235f, 0.933333f, 1.000000f); }
        { var c = goMap[5116464727626368434L].AddComponent<Outline>();
           c.effectColor = new Color(0.227451f, 0.196078f, 0.078431f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[7612103997383136473L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[7468409178993271628L].AddComponent<Text>();
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
        { var g = goMap[7468409178993271628L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.992157f, 0.886275f, 0.447059f, 1.000000f); }
        { var c = goMap[7468409178993271628L].AddComponent<Outline>();
           c.effectColor = new Color(0.227451f, 0.196078f, 0.078431f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-4490376897510665074L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[6170809084645975647L].AddComponent<Text>();
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
        { var c = goMap[6170809084645975647L].AddComponent<Outline>();
           c.effectColor = new Color(0.286275f, 0.090196f, 0.031373f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-2185328281396515535L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-621842661251458155L].AddComponent<Image>();
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
        { var c = goMap[-4270564351483450102L].AddComponent<Text>();
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
        { var c = goMap[-4270564351483450102L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[1877497348024382598L].AddComponent<Image>();
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
        { var c = goMap[4387906694162754338L].AddComponent<Image>();
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
        { var c = goMap[4387906694162754338L].AddComponent<Outline>();
           c.effectColor = new Color(0.584906f, 0.584906f, 0.584906f, 0.262745f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-4164641553595051019L].AddComponent<Image>();
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
        { var c = goMap[-4164641553595051019L].AddComponent<Outline>();
           c.effectColor = new Color(0.584906f, 0.584906f, 0.584906f, 0.262745f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[3569326097188466142L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("imgimg_goldshell_slected");
        }
        { var c = goMap[-3206802188326003192L].AddComponent<Image>();
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
        { var c = goMap[-7992722351109031519L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-3703476882474036217L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-3703476882474036217L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[2547725499076561724L].AddComponent<Image>();
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
        { var c = goMap[-6429517870701096137L].AddComponent<Text>();
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
        { var c = goMap[-6429517870701096137L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-3861307512401056529L].AddComponent<Text>();
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
        { var c = goMap[-3861307512401056529L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-3893583791612394962L].AddComponent<Text>();
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
        { var c = goMap[-3893583791612394962L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[7754430352565921336L].AddComponent<Text>();
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
        { var c = goMap[7754430352565921336L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[5784300124308319141L].AddComponent<Text>();
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
        { var c = goMap[5784300124308319141L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-5319570853057360076L].AddComponent<Image>();
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
        { var c = goMap[5661331876045189672L].AddComponent<Image>();
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
        { var c = goMap[-5725024631616254166L].AddComponent<Image>();
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
        { var c = goMap[-3914005005258374868L].AddComponent<Text>();
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
        { var c = goMap[-3914005005258374868L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[2023878650659462326L].AddComponent<Image>();
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
        { var c = goMap[6385776964626232266L].AddComponent<Image>();
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
        { var c = goMap[5478605813741346077L].AddComponent<Image>();
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
        { var c = goMap[4440391946033369108L].AddComponent<Image>();
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
        { var c = goMap[-7658658768117457682L].AddComponent<Image>();
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
        { var c = goMap[9191134168714483198L].AddComponent<Image>();
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
        { var c = goMap[2185518495806790478L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-7310316910746679953L].AddComponent<Text>();
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
        { var g = goMap[-7310316910746679953L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.866667f, 0.988235f, 0.933333f, 1.000000f); }
        { var c = goMap[-7310316910746679953L].AddComponent<Outline>();
           c.effectColor = new Color(0.227451f, 0.196078f, 0.078431f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-753186279118087024L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-421264179994258120L].AddComponent<Text>();
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
        { var g = goMap[-421264179994258120L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.992157f, 0.886275f, 0.447059f, 1.000000f); }
        { var c = goMap[-421264179994258120L].AddComponent<Outline>();
           c.effectColor = new Color(0.227451f, 0.196078f, 0.078431f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[1189418231994101254L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-2522277611558697722L].AddComponent<Text>();
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
        { var c = goMap[-2522277611558697722L].AddComponent<Outline>();
           c.effectColor = new Color(0.286275f, 0.090196f, 0.031373f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[3019259967916700993L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[6123882577084589483L].AddComponent<Image>();
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
        { var c = goMap[664402229362451315L].AddComponent<Text>();
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
        { var c = goMap[664402229362451315L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-7650318869590572907L].AddComponent<Image>();
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
        { var c = goMap[2480033360837464480L].AddComponent<Image>();
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
        { var c = goMap[2480033360837464480L].AddComponent<Outline>();
           c.effectColor = new Color(0.584906f, 0.584906f, 0.584906f, 0.262745f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-7366620873748422204L].AddComponent<Image>();
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
        { var c = goMap[-7366620873748422204L].AddComponent<Outline>();
           c.effectColor = new Color(0.584906f, 0.584906f, 0.584906f, 0.262745f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-5572456803609149599L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("imgimg_goldshell_slected");
        }
        { var c = goMap[-4459061989411866599L].AddComponent<Image>();
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
        { var c = goMap[5389173865562054004L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-1542549233695943954L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-1542549233695943954L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-758400158961041734L].AddComponent<Image>();
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
        { var c = goMap[4251515164245845223L].AddComponent<Text>();
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
        { var c = goMap[4251515164245845223L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-6636141275141599414L].AddComponent<Text>();
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
        { var c = goMap[-6636141275141599414L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-3508559083789626954L].AddComponent<Text>();
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
        { var c = goMap[-3508559083789626954L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-6076793695855127581L].AddComponent<Text>();
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
        { var c = goMap[-6076793695855127581L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-8022097623875767155L].AddComponent<Text>();
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
        { var c = goMap[-8022097623875767155L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[3084556461343236870L].AddComponent<Image>();
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
        { var c = goMap[-2502804922131173566L].AddComponent<Image>();
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
        { var c = goMap[1377975162260520142L].AddComponent<Image>();
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
        { var c = goMap[-7586487632728244221L].AddComponent<Text>();
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
        { var c = goMap[-7586487632728244221L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-7620775324658509088L].AddComponent<Image>();
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
        { var c = goMap[7569918802615195081L].AddComponent<Image>();
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
        { var c = goMap[8654249257387496586L].AddComponent<Image>();
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
        { var c = goMap[-1147449900313440380L].AddComponent<Image>();
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
        { var c = goMap[-7459614203372114148L].AddComponent<Image>();
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
        { var c = goMap[4993880972996822887L].AddComponent<Image>();
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
        { var c = goMap[-2878033329699973957L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[401080732301674078L].AddComponent<Text>();
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
        { var g = goMap[401080732301674078L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.866667f, 0.988235f, 0.933333f, 1.000000f); }
        { var c = goMap[401080732301674078L].AddComponent<Outline>();
           c.effectColor = new Color(0.227451f, 0.196078f, 0.078431f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-2814341700986650808L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[2710144149694006154L].AddComponent<Text>();
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
        { var g = goMap[2710144149694006154L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.992157f, 0.886275f, 0.447059f, 1.000000f); }
        { var c = goMap[2710144149694006154L].AddComponent<Outline>();
           c.effectColor = new Color(0.227451f, 0.196078f, 0.078431f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-6837416058809651670L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[4013423673232460561L].AddComponent<Text>();
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
        { var c = goMap[4013423673232460561L].AddComponent<Outline>();
           c.effectColor = new Color(0.286275f, 0.090196f, 0.031373f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-8950848934434519908L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-3747978240577390605L].AddComponent<Image>();
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
        { var c = goMap[5448532372314014984L].AddComponent<Text>();
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
        { var c = goMap[5448532372314014984L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-632295598915230293L].AddComponent<Image>();
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
        { var c = goMap[-3247584279771251903L].AddComponent<Image>();
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
        { var c = goMap[-3247584279771251903L].AddComponent<Outline>();
           c.effectColor = new Color(0.584906f, 0.584906f, 0.584906f, 0.262745f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[5217197697780506563L].AddComponent<Image>();
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
        { var c = goMap[5217197697780506563L].AddComponent<Outline>();
           c.effectColor = new Color(0.584906f, 0.584906f, 0.584906f, 0.262745f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-73704323097791350L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("imgimg_goldshell_slected");
        }
        { var c = goMap[-1642865896103847093L].AddComponent<Image>();
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
        { var c = goMap[-8989895865271480841L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[7274919739472658569L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[7274919739472658569L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-6474420241397276760L].AddComponent<Image>();
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
        { var c = goMap[1981196291729700466L].AddComponent<Text>();
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
        { var c = goMap[1981196291729700466L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[6146143904014342779L].AddComponent<Text>();
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
        { var c = goMap[6146143904014342779L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[6206043328514573101L].AddComponent<Text>();
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
        { var c = goMap[6206043328514573101L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-900145749982296073L].AddComponent<Text>();
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
        { var c = goMap[-900145749982296073L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-8345511344440216439L].AddComponent<Text>();
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
        { var c = goMap[-8345511344440216439L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-8551629439379484552L].AddComponent<Image>();
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
        { var c = goMap[7355185180429482560L].AddComponent<Image>();
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
        { var c = goMap[-5296215651904924457L].AddComponent<Image>();
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
        { var c = goMap[-1589268852755538248L].AddComponent<Text>();
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
        { var c = goMap[-1589268852755538248L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-3335551879107124431L].AddComponent<Image>();
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
        { var c = goMap[-693530954936255824L].AddComponent<Image>();
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
        { var c = goMap[6272798149034974544L].AddComponent<Image>();
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
        { var c = goMap[3882805435572226329L].AddComponent<Image>();
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
        { var c = goMap[6582776910553710131L].AddComponent<Image>();
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
        { var c = goMap[5887803223407278764L].AddComponent<Image>();
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
        { var c = goMap[-7715521518177954685L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[2434601062884682979L].AddComponent<Text>();
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
        { var g = goMap[2434601062884682979L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.866667f, 0.988235f, 0.933333f, 1.000000f); }
        { var c = goMap[2434601062884682979L].AddComponent<Outline>();
           c.effectColor = new Color(0.227451f, 0.196078f, 0.078431f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-1922581952339719502L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[7895873382187774913L].AddComponent<Text>();
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
        { var g = goMap[7895873382187774913L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.992157f, 0.886275f, 0.447059f, 1.000000f); }
        { var c = goMap[7895873382187774913L].AddComponent<Outline>();
           c.effectColor = new Color(0.227451f, 0.196078f, 0.078431f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-194576399171645000L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-2935697758642554993L].AddComponent<Text>();
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
        { var c = goMap[-2935697758642554993L].AddComponent<Outline>();
           c.effectColor = new Color(0.286275f, 0.090196f, 0.031373f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[2144337918547670652L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[5084932241245459628L].AddComponent<Image>();
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
        { var c = goMap[3933394076467007949L].AddComponent<Text>();
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
        { var c = goMap[3933394076467007949L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-374201911436493508L].AddComponent<Image>();
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
        { var c = goMap[-1025374096136740890L].AddComponent<Image>();
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
        { var c = goMap[-1025374096136740890L].AddComponent<Outline>();
           c.effectColor = new Color(0.584906f, 0.584906f, 0.584906f, 0.262745f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[8595004814372084585L].AddComponent<Image>();
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
        { var c = goMap[8595004814372084585L].AddComponent<Outline>();
           c.effectColor = new Color(0.584906f, 0.584906f, 0.584906f, 0.262745f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[6050447251632985150L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("imgimg_goldshell_slected");
        }
        { var c = goMap[2378326900071587541L].AddComponent<Image>();
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
        { var c = goMap[8168369866304933107L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-5174309534820832584L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-5174309534820832584L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-8231060882058414772L].AddComponent<Image>();
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
        { var c = goMap[7373304116156363766L].AddComponent<Text>();
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
        { var c = goMap[7373304116156363766L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[8906195386061717354L].AddComponent<Text>();
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
        { var c = goMap[8906195386061717354L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[7892847533465812692L].AddComponent<Text>();
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
        { var c = goMap[7892847533465812692L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-2876244575501082604L].AddComponent<Text>();
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
        { var c = goMap[-2876244575501082604L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-7415099686420225185L].AddComponent<Text>();
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
        { var c = goMap[-7415099686420225185L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-4864082822081032184L].AddComponent<Image>();
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
        { var c = goMap[3427259412550978892L].AddComponent<Image>();
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
        { var c = goMap[-799171564556225449L].AddComponent<Image>();
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
        { var c = goMap[7974702868045624266L].AddComponent<Text>();
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
        { var c = goMap[7974702868045624266L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-656587985902071198L].AddComponent<Image>();
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
        { var c = goMap[-980586608958451626L].AddComponent<Image>();
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
        { var c = goMap[562665163024275017L].AddComponent<Image>();
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
        { var c = goMap[8333801475305311219L].AddComponent<Image>();
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
        { var c = goMap[-5764902720471370084L].AddComponent<Image>();
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
        { var c = goMap[5238608587787509558L].AddComponent<Image>();
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
        { var c = goMap[3553685321471580007L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-197591211163696369L].AddComponent<Text>();
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
        { var g = goMap[-197591211163696369L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.866667f, 0.988235f, 0.933333f, 1.000000f); }
        { var c = goMap[-197591211163696369L].AddComponent<Outline>();
           c.effectColor = new Color(0.227451f, 0.196078f, 0.078431f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[6984071307798181110L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-8374112380971608967L].AddComponent<Text>();
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
        { var g = goMap[-8374112380971608967L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.992157f, 0.886275f, 0.447059f, 1.000000f); }
        { var c = goMap[-8374112380971608967L].AddComponent<Outline>();
           c.effectColor = new Color(0.227451f, 0.196078f, 0.078431f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[1200566845871880307L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-7037641143752962045L].AddComponent<Text>();
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
        { var c = goMap[-7037641143752962045L].AddComponent<Outline>();
           c.effectColor = new Color(0.286275f, 0.090196f, 0.031373f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-6037309053294482300L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-3115327118152154352L].AddComponent<Image>();
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
        { var c = goMap[-6543105446751645424L].AddComponent<Text>();
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
        { var c = goMap[-6543105446751645424L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[6498122785235064957L].AddComponent<Image>();
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
        { var c = goMap[8362856759373596002L].AddComponent<Image>();
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
        { var c = goMap[8362856759373596002L].AddComponent<Outline>();
           c.effectColor = new Color(0.584906f, 0.584906f, 0.584906f, 0.262745f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[109259675198610636L].AddComponent<Image>();
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
        { var c = goMap[109259675198610636L].AddComponent<Outline>();
           c.effectColor = new Color(0.584906f, 0.584906f, 0.584906f, 0.262745f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[220428456418758578L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("imgimg_goldshell_slected");
        }
        { var c = goMap[-2555838729817560368L].AddComponent<Image>();
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
        { var c = goMap[3264847616176402910L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[7475800658144970975L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[7475800658144970975L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[6418080242586951814L].AddComponent<Image>();
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
        { var c = goMap[-4080550302726174419L].AddComponent<Text>();
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
        { var c = goMap[-4080550302726174419L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-5714976616510214674L].AddComponent<Text>();
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
        { var c = goMap[-5714976616510214674L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[260657172871768196L].AddComponent<Text>();
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
        { var c = goMap[260657172871768196L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[7140514509794322496L].AddComponent<Text>();
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
        { var c = goMap[7140514509794322496L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-4940729278684384457L].AddComponent<Text>();
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
        { var c = goMap[-4940729278684384457L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-6758392136145104355L].AddComponent<Image>();
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
        { var c = goMap[-1980188168636719842L].AddComponent<Image>();
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
        { var c = goMap[1945511589896611101L].AddComponent<Image>();
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
        { var c = goMap[3479838084973489529L].AddComponent<Text>();
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
        { var c = goMap[3479838084973489529L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[3793986255456268988L].AddComponent<Image>();
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
        { var c = goMap[5150506781369034332L].AddComponent<Image>();
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
        { var c = goMap[-3935790612616573192L].AddComponent<Image>();
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
        { var c = goMap[3942483339803346154L].AddComponent<Image>();
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
        { var c = goMap[-1658166954870918362L].AddComponent<Image>();
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
        { var c = goMap[-575181074648501323L].AddComponent<Image>();
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
        { var c = goMap[-6583475327188434656L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-6136508682829120932L].AddComponent<Text>();
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
        { var g = goMap[-6136508682829120932L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.866667f, 0.988235f, 0.933333f, 1.000000f); }
        { var c = goMap[-6136508682829120932L].AddComponent<Outline>();
           c.effectColor = new Color(0.227451f, 0.196078f, 0.078431f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-3234199561606740755L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-7315441288776086324L].AddComponent<Text>();
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
        { var g = goMap[-7315441288776086324L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.992157f, 0.886275f, 0.447059f, 1.000000f); }
        { var c = goMap[-7315441288776086324L].AddComponent<Outline>();
           c.effectColor = new Color(0.227451f, 0.196078f, 0.078431f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[531390889013143977L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[7481779225232934934L].AddComponent<Text>();
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
        { var c = goMap[7481779225232934934L].AddComponent<Outline>();
           c.effectColor = new Color(0.286275f, 0.090196f, 0.031373f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-8086346586055357343L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-378640279643211297L].AddComponent<Image>();
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
        { var c = goMap[3199508643747806029L].AddComponent<Text>();
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
        { var c = goMap[3199508643747806029L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-1653104402406472818L].AddComponent<Image>();
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
        { var c = goMap[-5726366200773963988L].AddComponent<Image>();
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
        { var c = goMap[-5726366200773963988L].AddComponent<Outline>();
           c.effectColor = new Color(0.584906f, 0.584906f, 0.584906f, 0.262745f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-2823386897994125793L].AddComponent<Image>();
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
        { var c = goMap[-2823386897994125793L].AddComponent<Outline>();
           c.effectColor = new Color(0.584906f, 0.584906f, 0.584906f, 0.262745f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-1855929211468115950L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("imgimg_goldshell_slected");
        }
        { var c = goMap[309477125561651569L].AddComponent<Image>();
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
        { var c = goMap[3374280535351502192L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-366850427297400475L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-366850427297400475L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-7803183571198445711L].AddComponent<Image>();
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
        { var c = goMap[-1927688012450094885L].AddComponent<Text>();
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
        { var c = goMap[-1927688012450094885L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[139295094796042983L].AddComponent<Text>();
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
        { var c = goMap[139295094796042983L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[5023509310148843131L].AddComponent<Text>();
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
        { var c = goMap[5023509310148843131L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-3365066893982352480L].AddComponent<Text>();
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
        { var c = goMap[-3365066893982352480L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[3521491654050434488L].AddComponent<Text>();
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
        { var c = goMap[3521491654050434488L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[3233412841466314447L].AddComponent<Image>();
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
        { var c = goMap[1190175795195419405L].AddComponent<Image>();
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
        { var c = goMap[-7988713809276816343L].AddComponent<Image>();
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
        { var c = goMap[5055907786938158942L].AddComponent<Text>();
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
        { var c = goMap[5055907786938158942L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-7351918411705901345L].AddComponent<Image>();
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
        { var c = goMap[-123076985158000013L].AddComponent<Image>();
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
        { var c = goMap[-6024470738857561803L].AddComponent<Image>();
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
        { var c = goMap[4645460277573699346L].AddComponent<Image>();
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
        { var c = goMap[-1611572446160023218L].AddComponent<Image>();
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
        { var c = goMap[342241789552109340L].AddComponent<Image>();
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
        { var c = goMap[4645359045161815676L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-8042487701915378318L].AddComponent<Text>();
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
        { var g = goMap[-8042487701915378318L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.866667f, 0.988235f, 0.933333f, 1.000000f); }
        { var c = goMap[-8042487701915378318L].AddComponent<Outline>();
           c.effectColor = new Color(0.227451f, 0.196078f, 0.078431f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-4712080362788068618L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-2084517210091289812L].AddComponent<Text>();
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
        { var g = goMap[-2084517210091289812L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.992157f, 0.886275f, 0.447059f, 1.000000f); }
        { var c = goMap[-2084517210091289812L].AddComponent<Outline>();
           c.effectColor = new Color(0.227451f, 0.196078f, 0.078431f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[331772348087123986L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-9168339921928156106L].AddComponent<Text>();
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
        { var c = goMap[-9168339921928156106L].AddComponent<Outline>();
           c.effectColor = new Color(0.286275f, 0.090196f, 0.031373f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[7635564418589756352L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-3504544829515422575L].AddComponent<Image>();
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
        { var c = goMap[4678314847436373733L].AddComponent<Text>();
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
        { var c = goMap[4678314847436373733L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[6207036371573398290L].AddComponent<Image>();
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
        { var c = goMap[2186732890953018367L].AddComponent<Image>();
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
        { var c = goMap[2186732890953018367L].AddComponent<Outline>();
           c.effectColor = new Color(0.584906f, 0.584906f, 0.584906f, 0.262745f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[8039820574805633968L].AddComponent<Image>();
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
        { var c = goMap[8039820574805633968L].AddComponent<Outline>();
           c.effectColor = new Color(0.584906f, 0.584906f, 0.584906f, 0.262745f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-2665572518284299046L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("imgimg_goldshell_slected");
        }
        { var c = goMap[1632436747866668060L].AddComponent<Image>();
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
        { var c = goMap[6443748589094228407L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-1290796867381821885L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-1290796867381821885L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[6682867503231978052L].AddComponent<Image>();
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
        { var c = goMap[238224093019188941L].AddComponent<Text>();
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
        { var c = goMap[238224093019188941L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-9218032090682951194L].AddComponent<Text>();
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
        { var c = goMap[-9218032090682951194L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[5689150910811022587L].AddComponent<Text>();
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
        { var c = goMap[5689150910811022587L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[5583822471829505566L].AddComponent<Text>();
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
        { var c = goMap[5583822471829505566L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-2336819022152583553L].AddComponent<Text>();
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
        { var c = goMap[-2336819022152583553L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[1799849665726952850L].AddComponent<Image>();
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
        { var c = goMap[4862550098728663682L].AddComponent<Image>();
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
        { var c = goMap[1315618604124949646L].AddComponent<Image>();
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
        { var c = goMap[-5483252812310593894L].AddComponent<Text>();
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
        { var c = goMap[-5483252812310593894L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[918582564678823665L].AddComponent<Image>();
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
        { var c = goMap[4046833811904718556L].AddComponent<Image>();
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
        { var c = goMap[-4153682306255988263L].AddComponent<Image>();
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
        { var c = goMap[4322287215292411231L].AddComponent<Image>();
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
        { var c = goMap[-1996116205181667262L].AddComponent<Image>();
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
        { var c = goMap[-7061633926358787167L].AddComponent<Image>();
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
        { var c = goMap[1626280828237840168L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-3552916326029274164L].AddComponent<Text>();
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
        { var g = goMap[-3552916326029274164L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.866667f, 0.988235f, 0.933333f, 1.000000f); }
        { var c = goMap[-3552916326029274164L].AddComponent<Outline>();
           c.effectColor = new Color(0.227451f, 0.196078f, 0.078431f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[5108911299483461114L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-580421857412706967L].AddComponent<Text>();
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
        { var g = goMap[-580421857412706967L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.992157f, 0.886275f, 0.447059f, 1.000000f); }
        { var c = goMap[-580421857412706967L].AddComponent<Outline>();
           c.effectColor = new Color(0.227451f, 0.196078f, 0.078431f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[8937777941304791581L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-9067689547174741385L].AddComponent<Text>();
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
        { var c = goMap[-9067689547174741385L].AddComponent<Outline>();
           c.effectColor = new Color(0.286275f, 0.090196f, 0.031373f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[5241138162347462331L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-1784573481267764908L].AddComponent<Image>();
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
        { var c = goMap[-2031584657449456117L].AddComponent<Text>();
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
        { var c = goMap[-2031584657449456117L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-4837959988399956591L].AddComponent<Image>();
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
        { var c = goMap[-1263048765459368588L].AddComponent<Image>();
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
        { var c = goMap[-1263048765459368588L].AddComponent<Outline>();
           c.effectColor = new Color(0.584906f, 0.584906f, 0.584906f, 0.262745f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[7689126718433443884L].AddComponent<Image>();
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
        { var c = goMap[7689126718433443884L].AddComponent<Outline>();
           c.effectColor = new Color(0.584906f, 0.584906f, 0.584906f, 0.262745f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-4441438487826942939L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("imgimg_goldshell_slected");
        }
        { var c = goMap[1934965008272520929L].AddComponent<Image>();
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
        { var c = goMap[-3914668558201226401L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-9025270563583067234L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-9025270563583067234L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-1426553099175553763L].AddComponent<Image>();
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
        { var c = goMap[-4741887140592962283L].AddComponent<Text>();
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
        { var c = goMap[-4741887140592962283L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[1173539502285042023L].AddComponent<Text>();
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
        { var c = goMap[1173539502285042023L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-6313177268042651810L].AddComponent<Text>();
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
        { var c = goMap[-6313177268042651810L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-3043534514911786430L].AddComponent<Text>();
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
        { var c = goMap[-3043534514911786430L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[4593530615845601401L].AddComponent<Text>();
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
        { var c = goMap[4593530615845601401L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[1240241652354211560L].AddComponent<Image>();
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
        { var c = goMap[-1584673111506814084L].AddComponent<Image>();
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
        { var c = goMap[5979928834058709445L].AddComponent<Image>();
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
        { var c = goMap[-2717411965676524757L].AddComponent<Text>();
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
        { var c = goMap[-2717411965676524757L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[7042675463309729403L].AddComponent<Image>();
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
        { var c = goMap[3614208344004240393L].AddComponent<Image>();
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
        { var c = goMap[-2890472369134269897L].AddComponent<Image>();
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
        { var c = goMap[7164213566470975811L].AddComponent<Image>();
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
        { var c = goMap[-5065732609134337278L].AddComponent<Image>();
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
        { var c = goMap[-131644770327765254L].AddComponent<Image>();
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
        { var c = goMap[3902907734395517633L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-1756068433598306997L].AddComponent<Text>();
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
        { var g = goMap[-1756068433598306997L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.866667f, 0.988235f, 0.933333f, 1.000000f); }
        { var c = goMap[-1756068433598306997L].AddComponent<Outline>();
           c.effectColor = new Color(0.227451f, 0.196078f, 0.078431f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[1235942746676039321L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-9214956267585963084L].AddComponent<Text>();
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
        { var g = goMap[-9214956267585963084L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.992157f, 0.886275f, 0.447059f, 1.000000f); }
        { var c = goMap[-9214956267585963084L].AddComponent<Outline>();
           c.effectColor = new Color(0.227451f, 0.196078f, 0.078431f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[5399547955743535734L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-7684511990707099075L].AddComponent<Text>();
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
        { var c = goMap[-7684511990707099075L].AddComponent<Outline>();
           c.effectColor = new Color(0.286275f, 0.090196f, 0.031373f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-4621261958724562655L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-1161739683658855587L].AddComponent<Image>();
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
        { var c = goMap[7097934953336531027L].AddComponent<Text>();
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
        { var c = goMap[7097934953336531027L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[6093609156816985515L].AddComponent<Image>();
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
        { var c = goMap[5470909357486236732L].AddComponent<Image>();
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
        { var c = goMap[5470909357486236732L].AddComponent<Outline>();
           c.effectColor = new Color(0.584906f, 0.584906f, 0.584906f, 0.262745f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[4792398910692167065L].AddComponent<Image>();
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
        { var c = goMap[4792398910692167065L].AddComponent<Outline>();
           c.effectColor = new Color(0.584906f, 0.584906f, 0.584906f, 0.262745f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[6789453669242967106L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.545098f);
           c.raycastTarget = false;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = false;
        }
        { var c = goMap[-7398008622001293413L].AddComponent<Text>();
           c.text = "14327";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
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
        { var c = goMap[5688869594172480997L].AddComponent<Image>();
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
           c.sprite = LookupSprite("icon_goldshell_box");
        }
        { var c = goMap[2757386761525363806L].AddComponent<Image>();
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
           c.sprite = LookupSprite("icon_goldshell_box");
        }
        { var c = goMap[-5308719843761229971L].AddComponent<Toggle>();
           c.isOn = false;
           c.transition = (Selectable.Transition)1;
           c.enabled = true;
        }
        { var c = goMap[834651492000526268L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-5104079435713966824L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[5449305954774952441L].AddComponent<Text>();
           c.text = "13351";
           c.color = new Color(0.133333f, 0.980392f, 0.341176f, 1.000000f);
           c.fontSize = 16;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleLeft;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 10;
           c.resizeTextMaxSize = 16;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[5449305954774952441L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-2304202685755250079L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(0.937255f, 0.913726f, 0.294118f, 1.000000f);
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
        { var c = goMap[-2304202685755250079L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[1985221619168864184L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("btn_locker");
        }
        { var c = goMap[1985221619168864184L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-7812967673499400467L].AddComponent<Text>();
           c.text = "334";
           c.color = new Color(0.643137f, 0.133333f, 0.133333f, 1.000000f);
           c.fontSize = 32;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 20;
           c.resizeTextMaxSize = 32;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-3096614008334680314L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("btn_locker");
        }
        { var c = goMap[-3096614008334680314L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-5631834561915026799L].AddComponent<Text>();
           c.text = "5918";
           c.color = new Color(0.643137f, 0.133333f, 0.133333f, 1.000000f);
           c.fontSize = 32;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 20;
           c.resizeTextMaxSize = 32;
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
        var rootGO = goMap[-530952539511192973L];
        string path = "Assets/Prefabs/Imported/UIGoldenShell.prefab";
        PrefabUtility.SaveAsPrefabAsset(rootGO, path);
        Object.DestroyImmediate(rootGO);
        Debug.Log("[Import_res_p_253] Saved " + path);
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