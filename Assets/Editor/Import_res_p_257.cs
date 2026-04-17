// AUTO-GENERATED from res_p_257.ab — DO NOT EDIT MANUALLY.
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;
using System.Collections.Generic;
using KTO.Game;  // UIJoyStick and other ported KTO scripts

public class Import_res_p_257
{
    [MenuItem("KTO/Import/res_p_257")]
    public static void Build()
    {
        Debug.Log("[Import_res_p_257] Building UIChangeFaction...");

        // ─── Create all GameObjects ───────────────────────────
        var goMap = new Dictionary<long, GameObject>();
        var _toggleGroupByMbPid = new Dictionary<long, ToggleGroup>();
        var _toggleGroupLinks = new List<System.Tuple<Toggle,long>>();
        { var go = new GameObject("UIChangeFaction"); go.SetActive(true); goMap[-9072411513186826955L] = go; }
        { var go = new GameObject("imgBG"); go.SetActive(true); goMap[-6820018181845890044L] = go; }
        { var go = new GameObject("btnClose"); go.SetActive(true); goMap[2359160393980789769L] = go; }
        { var go = new GameObject("MenPaiBG"); go.SetActive(true); goMap[-2219477878381123224L] = go; }
        { var go = new GameObject("FactionInfo"); go.SetActive(true); goMap[7040152402937814600L] = go; }
        { var go = new GameObject("BG"); go.SetActive(false); goMap[5502497552007660027L] = go; }
        { var go = new GameObject("Faction"); go.SetActive(true); goMap[6449898164209967021L] = go; }
        { var go = new GameObject("Fire_Effect"); go.SetActive(false); goMap[-7314965977479778093L] = go; }
        { var go = new GameObject("BG"); go.SetActive(true); goMap[5501021488848377363L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-1122566743645268464L] = go; }
        { var go = new GameObject("RaoDong"); go.SetActive(true); goMap[7577701490158478040L] = go; }
        { var go = new GameObject("LiuGuang"); go.SetActive(true); goMap[-8863023607259300262L] = go; }
        { var go = new GameObject("FireStar"); go.SetActive(false); goMap[7676373637151709793L] = go; }
        { var go = new GameObject("Metal_Effect"); go.SetActive(true); goMap[-2689342375102368203L] = go; }
        { var go = new GameObject("BG"); go.SetActive(true); goMap[595637003103206320L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[7536929498784973980L] = go; }
        { var go = new GameObject("RaoDong"); go.SetActive(true); goMap[-4572191696158459248L] = go; }
        { var go = new GameObject("LiuGuang"); go.SetActive(true); goMap[-7902422944309987778L] = go; }
        { var go = new GameObject("FireStar"); go.SetActive(false); goMap[6137880216924379411L] = go; }
        { var go = new GameObject("Earth_Effect"); go.SetActive(false); goMap[-7640437775082469868L] = go; }
        { var go = new GameObject("BG"); go.SetActive(true); goMap[-4344394444093759919L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[2759912441097620874L] = go; }
        { var go = new GameObject("RaoDong"); go.SetActive(true); goMap[-2859587782140199941L] = go; }
        { var go = new GameObject("LiuGuang"); go.SetActive(true); goMap[6414497830729389754L] = go; }
        { var go = new GameObject("FireStar"); go.SetActive(false); goMap[-1279584662179832131L] = go; }
        { var go = new GameObject("Water_Effect"); go.SetActive(false); goMap[-8266277647760883211L] = go; }
        { var go = new GameObject("BG"); go.SetActive(true); goMap[-1691549535701390791L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[5401522209080010638L] = go; }
        { var go = new GameObject("RaoDong"); go.SetActive(true); goMap[274588443301963245L] = go; }
        { var go = new GameObject("LiuGuang"); go.SetActive(true); goMap[-3616394257718424761L] = go; }
        { var go = new GameObject("FireStar"); go.SetActive(false); goMap[-7476488189796511095L] = go; }
        { var go = new GameObject("Wood_Effect"); go.SetActive(false); goMap[-654701379753593422L] = go; }
        { var go = new GameObject("BG"); go.SetActive(true); goMap[-1780462580648434850L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-1916628071552239762L] = go; }
        { var go = new GameObject("RaoDong"); go.SetActive(true); goMap[-5000379029910219462L] = go; }
        { var go = new GameObject("LiuGuang"); go.SetActive(true); goMap[4205163956466730127L] = go; }
        { var go = new GameObject("FireStar"); go.SetActive(false); goMap[-2790015255458649035L] = go; }
        { var go = new GameObject("FactionInfo"); go.SetActive(true); goMap[5030989225623976900L] = go; }
        { var go = new GameObject("imgFactionInfoBg"); go.SetActive(true); goMap[-2988921305116089728L] = go; }
        { var go = new GameObject("imgFactionInfo"); go.SetActive(true); goMap[8513335236900179819L] = go; }
        { var go = new GameObject("txtAttribute1"); go.SetActive(true); goMap[-8391397485744596302L] = go; }
        { var go = new GameObject("txtAttribute2"); go.SetActive(true); goMap[-3371520666826067037L] = go; }
        { var go = new GameObject("txtAttribute3"); go.SetActive(true); goMap[8621436611495578342L] = go; }
        { var go = new GameObject("txtAttribute4"); go.SetActive(true); goMap[-133340317476654060L] = go; }
        { var go = new GameObject("txtAttribute5"); go.SetActive(true); goMap[-3938406520542683453L] = go; }
        { var go = new GameObject("txtAttribute6"); go.SetActive(true); goMap[158604653455886913L] = go; }
        { var go = new GameObject("txtFactionDesc"); go.SetActive(true); goMap[5934046710479141241L] = go; }
        { var go = new GameObject("btnChangeFaction"); go.SetActive(true); goMap[-7174170611939755906L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-3767299883770909055L] = go; }
        { var go = new GameObject("FactionListLeft"); go.SetActive(true); goMap[-4375000426205600783L] = go; }
        { var go = new GameObject("Tangmen"); go.SetActive(true); goMap[-6398053035568973071L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(true); goMap[-1218023274851310521L] = go; }
        { var go = new GameObject("imgIcon"); go.SetActive(true); goMap[-7985805368465966213L] = go; }
        { var go = new GameObject("imgSelected"); go.SetActive(true); goMap[6966271682889459231L] = go; }
        { var go = new GameObject("Click_Effect"); go.SetActive(true); goMap[-3847429066923447735L] = go; }
        { var go = new GameObject("M1"); go.SetActive(true); goMap[2737243104565985276L] = go; }
        { var go = new GameObject("M2"); go.SetActive(true); goMap[5872853788640296834L] = go; }
        { var go = new GameObject("M3"); go.SetActive(true); goMap[-619670100599173085L] = go; }
        { var go = new GameObject("M4"); go.SetActive(true); goMap[-3282212155927698619L] = go; }
        { var go = new GameObject("ShaoLin"); go.SetActive(true); goMap[8048942549968783147L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(true); goMap[-7518276769389678122L] = go; }
        { var go = new GameObject("imgIcon"); go.SetActive(true); goMap[8697976976940919972L] = go; }
        { var go = new GameObject("imgSelected"); go.SetActive(true); goMap[-317013419373663485L] = go; }
        { var go = new GameObject("Click_Effect"); go.SetActive(true); goMap[-4166606229686895978L] = go; }
        { var go = new GameObject("M1"); go.SetActive(true); goMap[-9191426262222462636L] = go; }
        { var go = new GameObject("M2"); go.SetActive(true); goMap[2601675135497782528L] = go; }
        { var go = new GameObject("M3"); go.SetActive(true); goMap[-1187922277890282449L] = go; }
        { var go = new GameObject("M4"); go.SetActive(true); goMap[-582922691755804989L] = go; }
        { var go = new GameObject("MingJiao"); go.SetActive(true); goMap[1186400962111014990L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(true); goMap[1746370816962148383L] = go; }
        { var go = new GameObject("imgIcon"); go.SetActive(true); goMap[7498313837232261714L] = go; }
        { var go = new GameObject("imgSelected"); go.SetActive(true); goMap[7830615029234965383L] = go; }
        { var go = new GameObject("Click_Effect"); go.SetActive(true); goMap[-4784109621361213598L] = go; }
        { var go = new GameObject("M1"); go.SetActive(true); goMap[-6999369652677942695L] = go; }
        { var go = new GameObject("M2"); go.SetActive(true); goMap[8262612141739763816L] = go; }
        { var go = new GameObject("M3"); go.SetActive(true); goMap[-9218467348934298727L] = go; }
        { var go = new GameObject("M4"); go.SetActive(true); goMap[3436950418097901271L] = go; }
        { var go = new GameObject("KunLun"); go.SetActive(true); goMap[8831826385193187329L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(true); goMap[6159100301111158809L] = go; }
        { var go = new GameObject("imgIcon"); go.SetActive(true); goMap[672453596266439318L] = go; }
        { var go = new GameObject("imgSelected"); go.SetActive(true); goMap[-6220139324773100714L] = go; }
        { var go = new GameObject("Click_Effect"); go.SetActive(true); goMap[7267355225386136784L] = go; }
        { var go = new GameObject("M1"); go.SetActive(true); goMap[-8129712048454326373L] = go; }
        { var go = new GameObject("M2"); go.SetActive(true); goMap[6787746525327124061L] = go; }
        { var go = new GameObject("M3"); go.SetActive(true); goMap[7735029489092496528L] = go; }
        { var go = new GameObject("M4"); go.SetActive(true); goMap[909070834065329054L] = go; }
        { var go = new GameObject("GaiBang"); go.SetActive(true); goMap[6529269463383508547L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(true); goMap[-5218614377579334889L] = go; }
        { var go = new GameObject("imgIcon"); go.SetActive(true); goMap[-686915155390993805L] = go; }
        { var go = new GameObject("imgSelected"); go.SetActive(true); goMap[295662126974219862L] = go; }
        { var go = new GameObject("Click_Effect"); go.SetActive(true); goMap[-5385312949726053442L] = go; }
        { var go = new GameObject("M1"); go.SetActive(true); goMap[5319916624569732508L] = go; }
        { var go = new GameObject("M2"); go.SetActive(true); goMap[-5567988256191596682L] = go; }
        { var go = new GameObject("M3"); go.SetActive(true); goMap[-5312444441636516219L] = go; }
        { var go = new GameObject("M4"); go.SetActive(true); goMap[6502159853429663966L] = go; }
        { var go = new GameObject("EMei"); go.SetActive(true); goMap[3630878805144999280L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(true); goMap[3485391183591083210L] = go; }
        { var go = new GameObject("imgIcon"); go.SetActive(true); goMap[-9207004325593006483L] = go; }
        { var go = new GameObject("imgSelected"); go.SetActive(true); goMap[-7348495412049388635L] = go; }
        { var go = new GameObject("Click_Effect"); go.SetActive(true); goMap[-8602249518098111636L] = go; }
        { var go = new GameObject("M1"); go.SetActive(true); goMap[-784257047041866421L] = go; }
        { var go = new GameObject("M2"); go.SetActive(true); goMap[295772707630879592L] = go; }
        { var go = new GameObject("M3"); go.SetActive(true); goMap[-243620051616160907L] = go; }
        { var go = new GameObject("M4"); go.SetActive(true); goMap[-1014467564155736375L] = go; }
        { var go = new GameObject("xiaoyao"); go.SetActive(true); goMap[6852732223945741817L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(true); goMap[431990548120164459L] = go; }
        { var go = new GameObject("imgIcon"); go.SetActive(true); goMap[7278829630593875893L] = go; }
        { var go = new GameObject("imgSelected"); go.SetActive(true); goMap[-6272325846242310396L] = go; }
        { var go = new GameObject("Click_Effect"); go.SetActive(true); goMap[-4798821937261298362L] = go; }
        { var go = new GameObject("M1"); go.SetActive(true); goMap[3977628641773245033L] = go; }
        { var go = new GameObject("M2"); go.SetActive(true); goMap[-3073443847112574327L] = go; }
        { var go = new GameObject("M3"); go.SetActive(true); goMap[8039190353437906416L] = go; }
        { var go = new GameObject("M4"); go.SetActive(true); goMap[-8678055041458702697L] = go; }
        { var go = new GameObject("Gumu"); go.SetActive(true); goMap[-548575148030427951L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(true); goMap[4137840714879873872L] = go; }
        { var go = new GameObject("imgIcon"); go.SetActive(true); goMap[5726619445160175043L] = go; }
        { var go = new GameObject("imgSelected"); go.SetActive(true); goMap[4177400639133106361L] = go; }
        { var go = new GameObject("Click_Effect"); go.SetActive(true); goMap[-5978643116973779059L] = go; }
        { var go = new GameObject("M1"); go.SetActive(true); goMap[-4626575374794704678L] = go; }
        { var go = new GameObject("M2"); go.SetActive(true); goMap[-585697448559676829L] = go; }
        { var go = new GameObject("M3"); go.SetActive(true); goMap[137545236230299356L] = go; }
        { var go = new GameObject("M4"); go.SetActive(true); goMap[-6772722198812843566L] = go; }
        { var go = new GameObject("Taohua"); go.SetActive(true); goMap[-163352017617084981L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(true); goMap[3122622948924706758L] = go; }
        { var go = new GameObject("imgIcon"); go.SetActive(true); goMap[-716778710931694527L] = go; }
        { var go = new GameObject("imgSelected"); go.SetActive(true); goMap[5239800010931282688L] = go; }
        { var go = new GameObject("Click_Effect"); go.SetActive(true); goMap[-2531313978791185567L] = go; }
        { var go = new GameObject("M1"); go.SetActive(true); goMap[3001898410479560634L] = go; }
        { var go = new GameObject("M2"); go.SetActive(true); goMap[4400991775822721643L] = go; }
        { var go = new GameObject("M3"); go.SetActive(true); goMap[8210533778020195872L] = go; }
        { var go = new GameObject("M4"); go.SetActive(true); goMap[6966880512873533155L] = go; }
        { var go = new GameObject("YiPinTang"); go.SetActive(true); goMap[4922474593684333695L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(true); goMap[-7920799018745589430L] = go; }
        { var go = new GameObject("imgIcon"); go.SetActive(true); goMap[-6111115773420419690L] = go; }
        { var go = new GameObject("imgSelected"); go.SetActive(true); goMap[1707529008551604124L] = go; }
        { var go = new GameObject("Click_Effect"); go.SetActive(true); goMap[5227752876140305912L] = go; }
        { var go = new GameObject("M1"); go.SetActive(true); goMap[24978612992196744L] = go; }
        { var go = new GameObject("M2"); go.SetActive(true); goMap[7822677720540017139L] = go; }
        { var go = new GameObject("M3"); go.SetActive(true); goMap[1384712619099965246L] = go; }
        { var go = new GameObject("M4"); go.SetActive(true); goMap[-4765237749424503260L] = go; }
        { var go = new GameObject("WuHunTang"); go.SetActive(true); goMap[-2617066436648305912L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(true); goMap[-6337189036971934932L] = go; }
        { var go = new GameObject("imgIcon"); go.SetActive(true); goMap[2432531351441246217L] = go; }
        { var go = new GameObject("imgSelected"); go.SetActive(true); goMap[6068663889059216974L] = go; }
        { var go = new GameObject("Click_Effect"); go.SetActive(true); goMap[4507707329843046235L] = go; }
        { var go = new GameObject("M1"); go.SetActive(true); goMap[4931089638976165746L] = go; }
        { var go = new GameObject("M2"); go.SetActive(true); goMap[-8094726322340874471L] = go; }
        { var go = new GameObject("M3"); go.SetActive(true); goMap[4458790285124447291L] = go; }
        { var go = new GameObject("M4"); go.SetActive(true); goMap[6305836318772586533L] = go; }
        { var go = new GameObject("FactionListRight"); go.SetActive(true); goMap[-7325489850133891770L] = go; }
        { var go = new GameObject("TianWang"); go.SetActive(true); goMap[-1790169810516780900L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(true); goMap[-1668267671223787435L] = go; }
        { var go = new GameObject("imgIcon"); go.SetActive(true); goMap[-975998876663545048L] = go; }
        { var go = new GameObject("imgSelected"); go.SetActive(true); goMap[-7061502623815358326L] = go; }
        { var go = new GameObject("Click_Effect"); go.SetActive(true); goMap[7433051402771144359L] = go; }
        { var go = new GameObject("M1"); go.SetActive(true); goMap[3836093364684387024L] = go; }
        { var go = new GameObject("M2"); go.SetActive(true); goMap[7186947113144645300L] = go; }
        { var go = new GameObject("M3"); go.SetActive(true); goMap[-568358622723966994L] = go; }
        { var go = new GameObject("M4"); go.SetActive(true); goMap[1312437731779894517L] = go; }
        { var go = new GameObject("CuiYan"); go.SetActive(true); goMap[463955709694975218L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(true); goMap[937791589142165462L] = go; }
        { var go = new GameObject("imgIcon"); go.SetActive(true); goMap[-7691976798653124528L] = go; }
        { var go = new GameObject("imgSelected"); go.SetActive(true); goMap[-5689940029379283369L] = go; }
        { var go = new GameObject("Click_Effect"); go.SetActive(true); goMap[-6479637451704740675L] = go; }
        { var go = new GameObject("M1"); go.SetActive(true); goMap[-3905282888234740272L] = go; }
        { var go = new GameObject("M2"); go.SetActive(true); goMap[-5073907600400042807L] = go; }
        { var go = new GameObject("M3"); go.SetActive(true); goMap[1239092496081215507L] = go; }
        { var go = new GameObject("M4"); go.SetActive(true); goMap[-8354560878650867991L] = go; }
        { var go = new GameObject("WuDang"); go.SetActive(true); goMap[9033730404377387568L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(true); goMap[2029463042147613593L] = go; }
        { var go = new GameObject("imgIcon"); go.SetActive(true); goMap[-5709931580719791864L] = go; }
        { var go = new GameObject("imgSelected"); go.SetActive(true); goMap[-1672203231299551832L] = go; }
        { var go = new GameObject("Click_Effect"); go.SetActive(true); goMap[4150327184553134123L] = go; }
        { var go = new GameObject("M1"); go.SetActive(true); goMap[-2928627218182682118L] = go; }
        { var go = new GameObject("M2"); go.SetActive(true); goMap[-7408477675515573579L] = go; }
        { var go = new GameObject("M3"); go.SetActive(true); goMap[-6204197882052759252L] = go; }
        { var go = new GameObject("M4"); go.SetActive(true); goMap[-5055147033408381790L] = go; }
        { var go = new GameObject("TianRen"); go.SetActive(true); goMap[-3454470024530962112L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(true); goMap[6528570390512217460L] = go; }
        { var go = new GameObject("imgIcon"); go.SetActive(true); goMap[-3857054920168619446L] = go; }
        { var go = new GameObject("imgSelected"); go.SetActive(true); goMap[-2517660705555871922L] = go; }
        { var go = new GameObject("Click_Effect"); go.SetActive(true); goMap[2252698649104363109L] = go; }
        { var go = new GameObject("M1"); go.SetActive(true); goMap[-6058972348026088931L] = go; }
        { var go = new GameObject("M2"); go.SetActive(true); goMap[1708522407170610595L] = go; }
        { var go = new GameObject("M3"); go.SetActive(true); goMap[-3784906583418252493L] = go; }
        { var go = new GameObject("M4"); go.SetActive(true); goMap[6328426864496614742L] = go; }
        { var go = new GameObject("DuanShi"); go.SetActive(true); goMap[-6160857569591889873L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(true); goMap[4358204666419679998L] = go; }
        { var go = new GameObject("imgIcon"); go.SetActive(true); goMap[308903074891103611L] = go; }
        { var go = new GameObject("imgSelected"); go.SetActive(true); goMap[-372841046645356312L] = go; }
        { var go = new GameObject("Click_Effect"); go.SetActive(true); goMap[-2655376128228521356L] = go; }
        { var go = new GameObject("M1"); go.SetActive(true); goMap[7091910758224425674L] = go; }
        { var go = new GameObject("M2"); go.SetActive(true); goMap[-578252916693763369L] = go; }
        { var go = new GameObject("M3"); go.SetActive(true); goMap[7365214537880120476L] = go; }
        { var go = new GameObject("M4"); go.SetActive(true); goMap[6803329020949650617L] = go; }
        { var go = new GameObject("WuDu"); go.SetActive(true); goMap[-5921073451059394752L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(true); goMap[-1753466198599486634L] = go; }
        { var go = new GameObject("imgIcon"); go.SetActive(true); goMap[-1018890697026895511L] = go; }
        { var go = new GameObject("imgSelected"); go.SetActive(true); goMap[8935195549274196707L] = go; }
        { var go = new GameObject("Click_Effect"); go.SetActive(true); goMap[176688324960497688L] = go; }
        { var go = new GameObject("M1"); go.SetActive(true); goMap[-6155831144091904540L] = go; }
        { var go = new GameObject("M2"); go.SetActive(true); goMap[-3806424738394955800L] = go; }
        { var go = new GameObject("M3"); go.SetActive(true); goMap[-3914846090313760988L] = go; }
        { var go = new GameObject("M4"); go.SetActive(true); goMap[-4584202464225229950L] = go; }
        { var go = new GameObject("BaDao"); go.SetActive(true); goMap[4289239842280690141L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(true); goMap[-8884348135360029421L] = go; }
        { var go = new GameObject("imgIcon"); go.SetActive(true); goMap[5439730254507698730L] = go; }
        { var go = new GameObject("imgSelected"); go.SetActive(true); goMap[-1235751324295501401L] = go; }
        { var go = new GameObject("Click_Effect"); go.SetActive(true); goMap[-3142154811259541277L] = go; }
        { var go = new GameObject("M1"); go.SetActive(true); goMap[7054578170752032955L] = go; }
        { var go = new GameObject("M2"); go.SetActive(true); goMap[2089965970542035168L] = go; }
        { var go = new GameObject("M3"); go.SetActive(true); goMap[-3820980948183915305L] = go; }
        { var go = new GameObject("M4"); go.SetActive(true); goMap[-5135931481241594164L] = go; }
        { var go = new GameObject("baituoshan"); go.SetActive(true); goMap[1663017479171496580L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(true); goMap[-8548785630604288138L] = go; }
        { var go = new GameObject("imgIcon"); go.SetActive(true); goMap[8700772532374245602L] = go; }
        { var go = new GameObject("imgSelected"); go.SetActive(true); goMap[-3893353556541859372L] = go; }
        { var go = new GameObject("Click_Effect"); go.SetActive(true); goMap[-6522280961580340458L] = go; }
        { var go = new GameObject("M1"); go.SetActive(true); goMap[-700954336313106703L] = go; }
        { var go = new GameObject("M2"); go.SetActive(true); goMap[4558442959565692204L] = go; }
        { var go = new GameObject("M3"); go.SetActive(true); goMap[5524935491277047058L] = go; }
        { var go = new GameObject("M4"); go.SetActive(true); goMap[-4421393404228396054L] = go; }
        { var go = new GameObject("Changge"); go.SetActive(true); goMap[-2276432401239455630L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(true); goMap[-8386982700619931365L] = go; }
        { var go = new GameObject("imgIcon"); go.SetActive(true); goMap[-2816521808406854022L] = go; }
        { var go = new GameObject("imgSelected"); go.SetActive(true); goMap[2261284890229149185L] = go; }
        { var go = new GameObject("Click_Effect"); go.SetActive(true); goMap[5592793177023850098L] = go; }
        { var go = new GameObject("M1"); go.SetActive(true); goMap[5532720191376380408L] = go; }
        { var go = new GameObject("M2"); go.SetActive(true); goMap[4828067178562134486L] = go; }
        { var go = new GameObject("M3"); go.SetActive(true); goMap[-6388041484620753318L] = go; }
        { var go = new GameObject("M4"); go.SetActive(true); goMap[-416134707180660811L] = go; }

        // ─── Parent links ─────────────────────────────────────
        goMap[-6820018181845890044L].transform.SetParent(goMap[-9072411513186826955L].transform, false);
        goMap[2359160393980789769L].transform.SetParent(goMap[-6820018181845890044L].transform, false);
        goMap[-2219477878381123224L].transform.SetParent(goMap[-6820018181845890044L].transform, false);
        goMap[7040152402937814600L].transform.SetParent(goMap[-6820018181845890044L].transform, false);
        goMap[5502497552007660027L].transform.SetParent(goMap[7040152402937814600L].transform, false);
        goMap[6449898164209967021L].transform.SetParent(goMap[7040152402937814600L].transform, false);
        goMap[-7314965977479778093L].transform.SetParent(goMap[6449898164209967021L].transform, false);
        goMap[5501021488848377363L].transform.SetParent(goMap[-7314965977479778093L].transform, false);
        goMap[-1122566743645268464L].transform.SetParent(goMap[-7314965977479778093L].transform, false);
        goMap[7577701490158478040L].transform.SetParent(goMap[-7314965977479778093L].transform, false);
        goMap[-8863023607259300262L].transform.SetParent(goMap[-7314965977479778093L].transform, false);
        goMap[7676373637151709793L].transform.SetParent(goMap[-7314965977479778093L].transform, false);
        goMap[-2689342375102368203L].transform.SetParent(goMap[6449898164209967021L].transform, false);
        goMap[595637003103206320L].transform.SetParent(goMap[-2689342375102368203L].transform, false);
        goMap[7536929498784973980L].transform.SetParent(goMap[-2689342375102368203L].transform, false);
        goMap[-4572191696158459248L].transform.SetParent(goMap[-2689342375102368203L].transform, false);
        goMap[-7902422944309987778L].transform.SetParent(goMap[-2689342375102368203L].transform, false);
        goMap[6137880216924379411L].transform.SetParent(goMap[-2689342375102368203L].transform, false);
        goMap[-7640437775082469868L].transform.SetParent(goMap[6449898164209967021L].transform, false);
        goMap[-4344394444093759919L].transform.SetParent(goMap[-7640437775082469868L].transform, false);
        goMap[2759912441097620874L].transform.SetParent(goMap[-7640437775082469868L].transform, false);
        goMap[-2859587782140199941L].transform.SetParent(goMap[-7640437775082469868L].transform, false);
        goMap[6414497830729389754L].transform.SetParent(goMap[-7640437775082469868L].transform, false);
        goMap[-1279584662179832131L].transform.SetParent(goMap[-7640437775082469868L].transform, false);
        goMap[-8266277647760883211L].transform.SetParent(goMap[6449898164209967021L].transform, false);
        goMap[-1691549535701390791L].transform.SetParent(goMap[-8266277647760883211L].transform, false);
        goMap[5401522209080010638L].transform.SetParent(goMap[-8266277647760883211L].transform, false);
        goMap[274588443301963245L].transform.SetParent(goMap[-8266277647760883211L].transform, false);
        goMap[-3616394257718424761L].transform.SetParent(goMap[-8266277647760883211L].transform, false);
        goMap[-7476488189796511095L].transform.SetParent(goMap[-8266277647760883211L].transform, false);
        goMap[-654701379753593422L].transform.SetParent(goMap[6449898164209967021L].transform, false);
        goMap[-1780462580648434850L].transform.SetParent(goMap[-654701379753593422L].transform, false);
        goMap[-1916628071552239762L].transform.SetParent(goMap[-654701379753593422L].transform, false);
        goMap[-5000379029910219462L].transform.SetParent(goMap[-654701379753593422L].transform, false);
        goMap[4205163956466730127L].transform.SetParent(goMap[-654701379753593422L].transform, false);
        goMap[-2790015255458649035L].transform.SetParent(goMap[-654701379753593422L].transform, false);
        goMap[5030989225623976900L].transform.SetParent(goMap[7040152402937814600L].transform, false);
        goMap[-2988921305116089728L].transform.SetParent(goMap[5030989225623976900L].transform, false);
        goMap[8513335236900179819L].transform.SetParent(goMap[5030989225623976900L].transform, false);
        goMap[-8391397485744596302L].transform.SetParent(goMap[5030989225623976900L].transform, false);
        goMap[-3371520666826067037L].transform.SetParent(goMap[5030989225623976900L].transform, false);
        goMap[8621436611495578342L].transform.SetParent(goMap[5030989225623976900L].transform, false);
        goMap[-133340317476654060L].transform.SetParent(goMap[5030989225623976900L].transform, false);
        goMap[-3938406520542683453L].transform.SetParent(goMap[5030989225623976900L].transform, false);
        goMap[158604653455886913L].transform.SetParent(goMap[5030989225623976900L].transform, false);
        goMap[5934046710479141241L].transform.SetParent(goMap[7040152402937814600L].transform, false);
        goMap[-7174170611939755906L].transform.SetParent(goMap[-6820018181845890044L].transform, false);
        goMap[-3767299883770909055L].transform.SetParent(goMap[-7174170611939755906L].transform, false);
        goMap[-4375000426205600783L].transform.SetParent(goMap[-6820018181845890044L].transform, false);
        goMap[-6398053035568973071L].transform.SetParent(goMap[-4375000426205600783L].transform, false);
        goMap[-1218023274851310521L].transform.SetParent(goMap[-6398053035568973071L].transform, false);
        goMap[-7985805368465966213L].transform.SetParent(goMap[-6398053035568973071L].transform, false);
        goMap[6966271682889459231L].transform.SetParent(goMap[-6398053035568973071L].transform, false);
        goMap[-3847429066923447735L].transform.SetParent(goMap[6966271682889459231L].transform, false);
        goMap[2737243104565985276L].transform.SetParent(goMap[-3847429066923447735L].transform, false);
        goMap[5872853788640296834L].transform.SetParent(goMap[-3847429066923447735L].transform, false);
        goMap[-619670100599173085L].transform.SetParent(goMap[-3847429066923447735L].transform, false);
        goMap[-3282212155927698619L].transform.SetParent(goMap[-3847429066923447735L].transform, false);
        goMap[8048942549968783147L].transform.SetParent(goMap[-4375000426205600783L].transform, false);
        goMap[-7518276769389678122L].transform.SetParent(goMap[8048942549968783147L].transform, false);
        goMap[8697976976940919972L].transform.SetParent(goMap[8048942549968783147L].transform, false);
        goMap[-317013419373663485L].transform.SetParent(goMap[8048942549968783147L].transform, false);
        goMap[-4166606229686895978L].transform.SetParent(goMap[-317013419373663485L].transform, false);
        goMap[-9191426262222462636L].transform.SetParent(goMap[-4166606229686895978L].transform, false);
        goMap[2601675135497782528L].transform.SetParent(goMap[-4166606229686895978L].transform, false);
        goMap[-1187922277890282449L].transform.SetParent(goMap[-4166606229686895978L].transform, false);
        goMap[-582922691755804989L].transform.SetParent(goMap[-4166606229686895978L].transform, false);
        goMap[1186400962111014990L].transform.SetParent(goMap[-4375000426205600783L].transform, false);
        goMap[1746370816962148383L].transform.SetParent(goMap[1186400962111014990L].transform, false);
        goMap[7498313837232261714L].transform.SetParent(goMap[1186400962111014990L].transform, false);
        goMap[7830615029234965383L].transform.SetParent(goMap[1186400962111014990L].transform, false);
        goMap[-4784109621361213598L].transform.SetParent(goMap[7830615029234965383L].transform, false);
        goMap[-6999369652677942695L].transform.SetParent(goMap[-4784109621361213598L].transform, false);
        goMap[8262612141739763816L].transform.SetParent(goMap[-4784109621361213598L].transform, false);
        goMap[-9218467348934298727L].transform.SetParent(goMap[-4784109621361213598L].transform, false);
        goMap[3436950418097901271L].transform.SetParent(goMap[-4784109621361213598L].transform, false);
        goMap[8831826385193187329L].transform.SetParent(goMap[-4375000426205600783L].transform, false);
        goMap[6159100301111158809L].transform.SetParent(goMap[8831826385193187329L].transform, false);
        goMap[672453596266439318L].transform.SetParent(goMap[8831826385193187329L].transform, false);
        goMap[-6220139324773100714L].transform.SetParent(goMap[8831826385193187329L].transform, false);
        goMap[7267355225386136784L].transform.SetParent(goMap[-6220139324773100714L].transform, false);
        goMap[-8129712048454326373L].transform.SetParent(goMap[7267355225386136784L].transform, false);
        goMap[6787746525327124061L].transform.SetParent(goMap[7267355225386136784L].transform, false);
        goMap[7735029489092496528L].transform.SetParent(goMap[7267355225386136784L].transform, false);
        goMap[909070834065329054L].transform.SetParent(goMap[7267355225386136784L].transform, false);
        goMap[6529269463383508547L].transform.SetParent(goMap[-4375000426205600783L].transform, false);
        goMap[-5218614377579334889L].transform.SetParent(goMap[6529269463383508547L].transform, false);
        goMap[-686915155390993805L].transform.SetParent(goMap[6529269463383508547L].transform, false);
        goMap[295662126974219862L].transform.SetParent(goMap[6529269463383508547L].transform, false);
        goMap[-5385312949726053442L].transform.SetParent(goMap[295662126974219862L].transform, false);
        goMap[5319916624569732508L].transform.SetParent(goMap[-5385312949726053442L].transform, false);
        goMap[-5567988256191596682L].transform.SetParent(goMap[-5385312949726053442L].transform, false);
        goMap[-5312444441636516219L].transform.SetParent(goMap[-5385312949726053442L].transform, false);
        goMap[6502159853429663966L].transform.SetParent(goMap[-5385312949726053442L].transform, false);
        goMap[3630878805144999280L].transform.SetParent(goMap[-4375000426205600783L].transform, false);
        goMap[3485391183591083210L].transform.SetParent(goMap[3630878805144999280L].transform, false);
        goMap[-9207004325593006483L].transform.SetParent(goMap[3630878805144999280L].transform, false);
        goMap[-7348495412049388635L].transform.SetParent(goMap[3630878805144999280L].transform, false);
        goMap[-8602249518098111636L].transform.SetParent(goMap[-7348495412049388635L].transform, false);
        goMap[-784257047041866421L].transform.SetParent(goMap[-8602249518098111636L].transform, false);
        goMap[295772707630879592L].transform.SetParent(goMap[-8602249518098111636L].transform, false);
        goMap[-243620051616160907L].transform.SetParent(goMap[-8602249518098111636L].transform, false);
        goMap[-1014467564155736375L].transform.SetParent(goMap[-8602249518098111636L].transform, false);
        goMap[6852732223945741817L].transform.SetParent(goMap[-4375000426205600783L].transform, false);
        goMap[431990548120164459L].transform.SetParent(goMap[6852732223945741817L].transform, false);
        goMap[7278829630593875893L].transform.SetParent(goMap[6852732223945741817L].transform, false);
        goMap[-6272325846242310396L].transform.SetParent(goMap[6852732223945741817L].transform, false);
        goMap[-4798821937261298362L].transform.SetParent(goMap[-6272325846242310396L].transform, false);
        goMap[3977628641773245033L].transform.SetParent(goMap[-4798821937261298362L].transform, false);
        goMap[-3073443847112574327L].transform.SetParent(goMap[-4798821937261298362L].transform, false);
        goMap[8039190353437906416L].transform.SetParent(goMap[-4798821937261298362L].transform, false);
        goMap[-8678055041458702697L].transform.SetParent(goMap[-4798821937261298362L].transform, false);
        goMap[-548575148030427951L].transform.SetParent(goMap[-4375000426205600783L].transform, false);
        goMap[4137840714879873872L].transform.SetParent(goMap[-548575148030427951L].transform, false);
        goMap[5726619445160175043L].transform.SetParent(goMap[-548575148030427951L].transform, false);
        goMap[4177400639133106361L].transform.SetParent(goMap[-548575148030427951L].transform, false);
        goMap[-5978643116973779059L].transform.SetParent(goMap[4177400639133106361L].transform, false);
        goMap[-4626575374794704678L].transform.SetParent(goMap[-5978643116973779059L].transform, false);
        goMap[-585697448559676829L].transform.SetParent(goMap[-5978643116973779059L].transform, false);
        goMap[137545236230299356L].transform.SetParent(goMap[-5978643116973779059L].transform, false);
        goMap[-6772722198812843566L].transform.SetParent(goMap[-5978643116973779059L].transform, false);
        goMap[-163352017617084981L].transform.SetParent(goMap[-4375000426205600783L].transform, false);
        goMap[3122622948924706758L].transform.SetParent(goMap[-163352017617084981L].transform, false);
        goMap[-716778710931694527L].transform.SetParent(goMap[-163352017617084981L].transform, false);
        goMap[5239800010931282688L].transform.SetParent(goMap[-163352017617084981L].transform, false);
        goMap[-2531313978791185567L].transform.SetParent(goMap[5239800010931282688L].transform, false);
        goMap[3001898410479560634L].transform.SetParent(goMap[-2531313978791185567L].transform, false);
        goMap[4400991775822721643L].transform.SetParent(goMap[-2531313978791185567L].transform, false);
        goMap[8210533778020195872L].transform.SetParent(goMap[-2531313978791185567L].transform, false);
        goMap[6966880512873533155L].transform.SetParent(goMap[-2531313978791185567L].transform, false);
        goMap[4922474593684333695L].transform.SetParent(goMap[-4375000426205600783L].transform, false);
        goMap[-7920799018745589430L].transform.SetParent(goMap[4922474593684333695L].transform, false);
        goMap[-6111115773420419690L].transform.SetParent(goMap[4922474593684333695L].transform, false);
        goMap[1707529008551604124L].transform.SetParent(goMap[4922474593684333695L].transform, false);
        goMap[5227752876140305912L].transform.SetParent(goMap[1707529008551604124L].transform, false);
        goMap[24978612992196744L].transform.SetParent(goMap[5227752876140305912L].transform, false);
        goMap[7822677720540017139L].transform.SetParent(goMap[5227752876140305912L].transform, false);
        goMap[1384712619099965246L].transform.SetParent(goMap[5227752876140305912L].transform, false);
        goMap[-4765237749424503260L].transform.SetParent(goMap[5227752876140305912L].transform, false);
        goMap[-2617066436648305912L].transform.SetParent(goMap[-4375000426205600783L].transform, false);
        goMap[-6337189036971934932L].transform.SetParent(goMap[-2617066436648305912L].transform, false);
        goMap[2432531351441246217L].transform.SetParent(goMap[-2617066436648305912L].transform, false);
        goMap[6068663889059216974L].transform.SetParent(goMap[-2617066436648305912L].transform, false);
        goMap[4507707329843046235L].transform.SetParent(goMap[6068663889059216974L].transform, false);
        goMap[4931089638976165746L].transform.SetParent(goMap[4507707329843046235L].transform, false);
        goMap[-8094726322340874471L].transform.SetParent(goMap[4507707329843046235L].transform, false);
        goMap[4458790285124447291L].transform.SetParent(goMap[4507707329843046235L].transform, false);
        goMap[6305836318772586533L].transform.SetParent(goMap[4507707329843046235L].transform, false);
        goMap[-7325489850133891770L].transform.SetParent(goMap[-6820018181845890044L].transform, false);
        goMap[-1790169810516780900L].transform.SetParent(goMap[-7325489850133891770L].transform, false);
        goMap[-1668267671223787435L].transform.SetParent(goMap[-1790169810516780900L].transform, false);
        goMap[-975998876663545048L].transform.SetParent(goMap[-1790169810516780900L].transform, false);
        goMap[-7061502623815358326L].transform.SetParent(goMap[-1790169810516780900L].transform, false);
        goMap[7433051402771144359L].transform.SetParent(goMap[-7061502623815358326L].transform, false);
        goMap[3836093364684387024L].transform.SetParent(goMap[7433051402771144359L].transform, false);
        goMap[7186947113144645300L].transform.SetParent(goMap[7433051402771144359L].transform, false);
        goMap[-568358622723966994L].transform.SetParent(goMap[7433051402771144359L].transform, false);
        goMap[1312437731779894517L].transform.SetParent(goMap[7433051402771144359L].transform, false);
        goMap[463955709694975218L].transform.SetParent(goMap[-7325489850133891770L].transform, false);
        goMap[937791589142165462L].transform.SetParent(goMap[463955709694975218L].transform, false);
        goMap[-7691976798653124528L].transform.SetParent(goMap[463955709694975218L].transform, false);
        goMap[-5689940029379283369L].transform.SetParent(goMap[463955709694975218L].transform, false);
        goMap[-6479637451704740675L].transform.SetParent(goMap[-5689940029379283369L].transform, false);
        goMap[-3905282888234740272L].transform.SetParent(goMap[-6479637451704740675L].transform, false);
        goMap[-5073907600400042807L].transform.SetParent(goMap[-6479637451704740675L].transform, false);
        goMap[1239092496081215507L].transform.SetParent(goMap[-6479637451704740675L].transform, false);
        goMap[-8354560878650867991L].transform.SetParent(goMap[-6479637451704740675L].transform, false);
        goMap[9033730404377387568L].transform.SetParent(goMap[-7325489850133891770L].transform, false);
        goMap[2029463042147613593L].transform.SetParent(goMap[9033730404377387568L].transform, false);
        goMap[-5709931580719791864L].transform.SetParent(goMap[9033730404377387568L].transform, false);
        goMap[-1672203231299551832L].transform.SetParent(goMap[9033730404377387568L].transform, false);
        goMap[4150327184553134123L].transform.SetParent(goMap[-1672203231299551832L].transform, false);
        goMap[-2928627218182682118L].transform.SetParent(goMap[4150327184553134123L].transform, false);
        goMap[-7408477675515573579L].transform.SetParent(goMap[4150327184553134123L].transform, false);
        goMap[-6204197882052759252L].transform.SetParent(goMap[4150327184553134123L].transform, false);
        goMap[-5055147033408381790L].transform.SetParent(goMap[4150327184553134123L].transform, false);
        goMap[-3454470024530962112L].transform.SetParent(goMap[-7325489850133891770L].transform, false);
        goMap[6528570390512217460L].transform.SetParent(goMap[-3454470024530962112L].transform, false);
        goMap[-3857054920168619446L].transform.SetParent(goMap[-3454470024530962112L].transform, false);
        goMap[-2517660705555871922L].transform.SetParent(goMap[-3454470024530962112L].transform, false);
        goMap[2252698649104363109L].transform.SetParent(goMap[-2517660705555871922L].transform, false);
        goMap[-6058972348026088931L].transform.SetParent(goMap[2252698649104363109L].transform, false);
        goMap[1708522407170610595L].transform.SetParent(goMap[2252698649104363109L].transform, false);
        goMap[-3784906583418252493L].transform.SetParent(goMap[2252698649104363109L].transform, false);
        goMap[6328426864496614742L].transform.SetParent(goMap[2252698649104363109L].transform, false);
        goMap[-6160857569591889873L].transform.SetParent(goMap[-7325489850133891770L].transform, false);
        goMap[4358204666419679998L].transform.SetParent(goMap[-6160857569591889873L].transform, false);
        goMap[308903074891103611L].transform.SetParent(goMap[-6160857569591889873L].transform, false);
        goMap[-372841046645356312L].transform.SetParent(goMap[-6160857569591889873L].transform, false);
        goMap[-2655376128228521356L].transform.SetParent(goMap[-372841046645356312L].transform, false);
        goMap[7091910758224425674L].transform.SetParent(goMap[-2655376128228521356L].transform, false);
        goMap[-578252916693763369L].transform.SetParent(goMap[-2655376128228521356L].transform, false);
        goMap[7365214537880120476L].transform.SetParent(goMap[-2655376128228521356L].transform, false);
        goMap[6803329020949650617L].transform.SetParent(goMap[-2655376128228521356L].transform, false);
        goMap[-5921073451059394752L].transform.SetParent(goMap[-7325489850133891770L].transform, false);
        goMap[-1753466198599486634L].transform.SetParent(goMap[-5921073451059394752L].transform, false);
        goMap[-1018890697026895511L].transform.SetParent(goMap[-5921073451059394752L].transform, false);
        goMap[8935195549274196707L].transform.SetParent(goMap[-5921073451059394752L].transform, false);
        goMap[176688324960497688L].transform.SetParent(goMap[8935195549274196707L].transform, false);
        goMap[-6155831144091904540L].transform.SetParent(goMap[176688324960497688L].transform, false);
        goMap[-3806424738394955800L].transform.SetParent(goMap[176688324960497688L].transform, false);
        goMap[-3914846090313760988L].transform.SetParent(goMap[176688324960497688L].transform, false);
        goMap[-4584202464225229950L].transform.SetParent(goMap[176688324960497688L].transform, false);
        goMap[4289239842280690141L].transform.SetParent(goMap[-7325489850133891770L].transform, false);
        goMap[-8884348135360029421L].transform.SetParent(goMap[4289239842280690141L].transform, false);
        goMap[5439730254507698730L].transform.SetParent(goMap[4289239842280690141L].transform, false);
        goMap[-1235751324295501401L].transform.SetParent(goMap[4289239842280690141L].transform, false);
        goMap[-3142154811259541277L].transform.SetParent(goMap[-1235751324295501401L].transform, false);
        goMap[7054578170752032955L].transform.SetParent(goMap[-3142154811259541277L].transform, false);
        goMap[2089965970542035168L].transform.SetParent(goMap[-3142154811259541277L].transform, false);
        goMap[-3820980948183915305L].transform.SetParent(goMap[-3142154811259541277L].transform, false);
        goMap[-5135931481241594164L].transform.SetParent(goMap[-3142154811259541277L].transform, false);
        goMap[1663017479171496580L].transform.SetParent(goMap[-7325489850133891770L].transform, false);
        goMap[-8548785630604288138L].transform.SetParent(goMap[1663017479171496580L].transform, false);
        goMap[8700772532374245602L].transform.SetParent(goMap[1663017479171496580L].transform, false);
        goMap[-3893353556541859372L].transform.SetParent(goMap[1663017479171496580L].transform, false);
        goMap[-6522280961580340458L].transform.SetParent(goMap[-3893353556541859372L].transform, false);
        goMap[-700954336313106703L].transform.SetParent(goMap[-6522280961580340458L].transform, false);
        goMap[4558442959565692204L].transform.SetParent(goMap[-6522280961580340458L].transform, false);
        goMap[5524935491277047058L].transform.SetParent(goMap[-6522280961580340458L].transform, false);
        goMap[-4421393404228396054L].transform.SetParent(goMap[-6522280961580340458L].transform, false);
        goMap[-2276432401239455630L].transform.SetParent(goMap[-7325489850133891770L].transform, false);
        goMap[-8386982700619931365L].transform.SetParent(goMap[-2276432401239455630L].transform, false);
        goMap[-2816521808406854022L].transform.SetParent(goMap[-2276432401239455630L].transform, false);
        goMap[2261284890229149185L].transform.SetParent(goMap[-2276432401239455630L].transform, false);
        goMap[5592793177023850098L].transform.SetParent(goMap[2261284890229149185L].transform, false);
        goMap[5532720191376380408L].transform.SetParent(goMap[5592793177023850098L].transform, false);
        goMap[4828067178562134486L].transform.SetParent(goMap[5592793177023850098L].transform, false);
        goMap[-6388041484620753318L].transform.SetParent(goMap[5592793177023850098L].transform, false);
        goMap[-416134707180660811L].transform.SetParent(goMap[5592793177023850098L].transform, false);

        // ─── RectTransforms ──────────────────────────────────
        {
            var rt = goMap[-9072411513186826955L].AddComponent<RectTransform>();
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
            var rt = goMap[-6820018181845890044L].AddComponent<RectTransform>();
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
            var rt = goMap[2359160393980789769L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(416.000000f, 284.000000f);
            rt.sizeDelta = new Vector2(44.000000f, 44.000000f);
        }
        {
            var rt = goMap[-2219477878381123224L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-13.000000f, -22.000000f);
            rt.sizeDelta = new Vector2(832.000000f, 610.000000f);
        }
        {
            var rt = goMap[7040152402937814600L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(202.000000f, -83.999992f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }
        {
            var rt = goMap[5502497552007660027L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,-0.000000f,0.707107f,-0.707107f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-193.635376f, 54.124100f);
            rt.sizeDelta = new Vector2(437.169495f, 560.689087f);
        }
        {
            var rt = goMap[6449898164209967021L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-184.000000f, 253.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[5501021488848377363L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.944868f, 1.297992f, 0.603060f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-1.300000f, -1.300000f);
            rt.sizeDelta = new Vector2(137.149994f, 100.000000f);
        }
        {
            var rt = goMap[-1122566743645268464L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(280.000000f, 100.000000f);
        }
        {
            var rt = goMap[7577701490158478040L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 99.999756f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(3.078053f, -1.618737f, 0.652260f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(1.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(158.869995f, -11.200000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-8863023607259300262L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.412500f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(137.149994f, 100.000000f);
        }
        {
            var rt = goMap[7676373637151709793L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.707107f,-0.000000f,-0.000000f,0.707107f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(1.400000f, -0.600000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[595637003103206320L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.970765f, 1.216630f, 0.611090f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-1.300000f, 4.300000f);
            rt.sizeDelta = new Vector2(137.149994f, 100.000000f);
        }
        {
            var rt = goMap[7536929498784973980L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(280.000000f, 100.000000f);
        }
        {
            var rt = goMap[-4572191696158459248L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 99.999756f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(2.577869f, -1.436629f, 0.652260f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(1.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(133.860001f, -12.600000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-7902422944309987778L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.412500f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(137.149994f, 100.000000f);
        }
        {
            var rt = goMap[6137880216924379411L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.707107f,-0.000000f,-0.000000f,0.707107f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(1.400000f, -0.600000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-4344394444093759919L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(2.265135f, 1.511736f, 0.702367f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-1.300000f, -1.300000f);
            rt.sizeDelta = new Vector2(137.149994f, 100.000000f);
        }
        {
            var rt = goMap[2759912441097620874L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(280.000000f, 100.000000f);
        }
        {
            var rt = goMap[-2859587782140199941L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 99.999756f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(3.078053f, -1.618737f, 0.652260f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(1.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(158.869995f, -11.200000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[6414497830729389754L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.412500f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(137.149994f, 100.000000f);
        }
        {
            var rt = goMap[-1279584662179832131L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.707107f,-0.000000f,-0.000000f,0.707107f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(1.400000f, -0.600000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-1691549535701390791L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(2.312841f, 1.543575f, 0.717160f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-1.300000f, -1.300000f);
            rt.sizeDelta = new Vector2(137.149994f, 100.000000f);
        }
        {
            var rt = goMap[5401522209080010638L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(280.000000f, 100.000000f);
        }
        {
            var rt = goMap[274588443301963245L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 99.999756f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(3.078053f, -1.618737f, 0.652260f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(1.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(158.869995f, -11.200000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-3616394257718424761L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.412500f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(137.149994f, 100.000000f);
        }
        {
            var rt = goMap[-7476488189796511095L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.707107f,-0.000000f,-0.000000f,0.707107f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(1.400000f, -0.600000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-1780462580648434850L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(3.225000f, 2.152344f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-1.300000f, -1.300000f);
            rt.sizeDelta = new Vector2(137.149994f, 100.000000f);
        }
        {
            var rt = goMap[-1916628071552239762L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(280.000000f, 100.000000f);
        }
        {
            var rt = goMap[-5000379029910219462L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 99.999756f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(3.078053f, -1.618737f, 0.652260f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(1.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(158.869995f, -11.200000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[4205163956466730127L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.412500f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(137.149994f, 100.000000f);
        }
        {
            var rt = goMap[-2790015255458649035L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.707107f,-0.000000f,-0.000000f,0.707107f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(1.400000f, -0.600000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[5030989225623976900L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.900000f, 0.900000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-184.000000f, -51.000000f);
            rt.sizeDelta = new Vector2(264.000000f, 260.000000f);
        }
        {
            var rt = goMap[-2988921305116089728L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-2.700000f, -1.800000f);
            rt.sizeDelta = new Vector2(234.000000f, 243.000000f);
        }
        {
            var rt = goMap[8513335236900179819L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.200000f, 5.000000f);
            rt.sizeDelta = new Vector2(200.000000f, 200.000000f);
        }
        {
            var rt = goMap[-8391397485744596302L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-1.800000f, 109.900002f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }
        {
            var rt = goMap[-3371520666826067037L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(106.099998f, 52.500000f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }
        {
            var rt = goMap[8621436611495578342L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(101.599998f, -53.599998f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }
        {
            var rt = goMap[-133340317476654060L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.800000f, -103.300003f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }
        {
            var rt = goMap[-3938406520542683453L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-106.800003f, -49.900002f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }
        {
            var rt = goMap[158604653455886913L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-105.099998f, 60.599998f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }
        {
            var rt = goMap[5934046710479141241L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-187.045319f, 136.979996f);
            rt.sizeDelta = new Vector2(439.456207f, 115.970001f);
        }
        {
            var rt = goMap[-7174170611939755906L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(15.000000f, -300.000000f);
            rt.sizeDelta = new Vector2(236.000000f, 61.000000f);
        }
        {
            var rt = goMap[-3767299883770909055L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(-14.000000f, -14.000000f);
        }
        {
            var rt = goMap[-4375000426205600783L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-299.000000f, -24.000000f);
            rt.sizeDelta = new Vector2(263.979889f, 522.892273f);
        }
        {
            var rt = goMap[-6398053035568973071L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(231.000000f, -15.000000f);
            rt.sizeDelta = new Vector2(72.000000f, 72.000000f);
        }
        {
            var rt = goMap[-1218023274851310521L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[-7985805368465966213L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[6966271682889459231L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[8048942549968783147L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(173.000000f, -89.000000f);
            rt.sizeDelta = new Vector2(72.000000f, 72.000000f);
        }
        {
            var rt = goMap[-7518276769389678122L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[8697976976940919972L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[-317013419373663485L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[1186400962111014990L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(132.000000f, -165.000000f);
            rt.sizeDelta = new Vector2(72.000000f, 72.000000f);
        }
        {
            var rt = goMap[1746370816962148383L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[7498313837232261714L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[7830615029234965383L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[8831826385193187329L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(122.000000f, -246.000000f);
            rt.sizeDelta = new Vector2(72.000000f, 72.000000f);
        }
        {
            var rt = goMap[6159100301111158809L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[672453596266439318L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[-6220139324773100714L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[6529269463383508547L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(123.000031f, -330.000000f);
            rt.sizeDelta = new Vector2(72.000000f, 72.000000f);
        }
        {
            var rt = goMap[-5218614377579334889L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[-686915155390993805L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[295662126974219862L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[3630878805144999280L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(149.000000f, -410.000000f);
            rt.sizeDelta = new Vector2(72.000000f, 72.000000f);
        }
        {
            var rt = goMap[3485391183591083210L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[-9207004325593006483L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[-7348495412049388635L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[6852732223945741817L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(201.000000f, -488.000000f);
            rt.sizeDelta = new Vector2(72.000000f, 72.000000f);
        }
        {
            var rt = goMap[431990548120164459L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[7278829630593875893L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[-6272325846242310396L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[-548575148030427951L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(306.000000f, 32.000000f);
            rt.sizeDelta = new Vector2(72.000000f, 72.000000f);
        }
        {
            var rt = goMap[4137840714879873872L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[5726619445160175043L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[4177400639133106361L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[-163352017617084981L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(388.000000f, 65.000000f);
            rt.sizeDelta = new Vector2(72.000000f, 72.000000f);
        }
        {
            var rt = goMap[3122622948924706758L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[-716778710931694527L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[5239800010931282688L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[4922474593684333695L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(471.000000f, 65.000000f);
            rt.sizeDelta = new Vector2(72.000000f, 72.000000f);
        }
        {
            var rt = goMap[-7920799018745589430L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[-6111115773420419690L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[1707529008551604124L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[-2617066436648305912L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(278.000000f, -530.000000f);
            rt.sizeDelta = new Vector2(72.000000f, 72.000000f);
        }
        {
            var rt = goMap[-6337189036971934932L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[2432531351441246217L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[6068663889059216974L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[-7325489850133891770L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(336.500000f, -23.999979f);
            rt.sizeDelta = new Vector2(263.979889f, 522.892273f);
        }
        {
            var rt = goMap[-1790169810516780900L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(112.000000f, -145.000000f);
            rt.sizeDelta = new Vector2(72.000000f, 72.000000f);
        }
        {
            var rt = goMap[-1668267671223787435L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[-975998876663545048L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[-7061502623815358326L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[463955709694975218L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(128.000000f, -228.000000f);
            rt.sizeDelta = new Vector2(72.000000f, 72.000000f);
        }
        {
            var rt = goMap[937791589142165462L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[-7691976798653124528L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[-5689940029379283369L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[9033730404377387568L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(123.000000f, -318.000000f);
            rt.sizeDelta = new Vector2(72.000000f, 72.000000f);
        }
        {
            var rt = goMap[2029463042147613593L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[-5709931580719791864L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[-1672203231299551832L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[-3454470024530962112L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(100.000000f, -400.000000f);
            rt.sizeDelta = new Vector2(72.000000f, 72.000000f);
        }
        {
            var rt = goMap[6528570390512217460L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[-3857054920168619446L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[-2517660705555871922L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[-6160857569591889873L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(56.000000f, -477.000000f);
            rt.sizeDelta = new Vector2(72.000000f, 72.000000f);
        }
        {
            var rt = goMap[4358204666419679998L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[308903074891103611L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[-372841046645356312L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[-5921073451059394752L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-21.000000f, -529.000000f);
            rt.sizeDelta = new Vector2(72.000000f, 72.000000f);
        }
        {
            var rt = goMap[-1753466198599486634L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[-1018890697026895511L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[8935195549274196707L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[4289239842280690141L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(78.000000f, -65.000000f);
            rt.sizeDelta = new Vector2(72.000000f, 72.000000f);
        }
        {
            var rt = goMap[-8884348135360029421L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[5439730254507698730L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[-1235751324295501401L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[1663017479171496580L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(2.000000f, -2.000000f);
            rt.sizeDelta = new Vector2(72.000000f, 72.000000f);
        }
        {
            var rt = goMap[-8548785630604288138L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[8700772532374245602L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[-3893353556541859372L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[-2276432401239455630L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-79.000000f, 55.000000f);
            rt.sizeDelta = new Vector2(72.000000f, 72.000000f);
        }
        {
            var rt = goMap[-8386982700619931365L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[-2816521808406854022L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }
        {
            var rt = goMap[2261284890229149185L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(74.000000f, 74.000000f);
        }

        // ─── Components ──────────────────────────────────────
        { var c = goMap[-9072411513186826955L].AddComponent<Canvas>();
           c.renderMode = (RenderMode)1;
           c.overrideSorting = false;
           c.sortingOrder = 0;
           c.planeDistance = 100.000000f;
           c.pixelPerfect = false;
           c.additionalShaderChannels = (AdditionalCanvasShaderChannels)6;
           c.enabled = true;
        }
        { var c = goMap[-9072411513186826955L].AddComponent<CanvasScaler>();
           c.uiScaleMode = (CanvasScaler.ScaleMode)1;
           c.referenceResolution = new Vector2(1280.000000f, 720.000000f);
           c.screenMatchMode = (CanvasScaler.ScreenMatchMode)1;
           c.matchWidthOrHeight = 0.000000f;
           c.referencePixelsPerUnit = 100.000000f;
        }
        { var c = goMap[-9072411513186826955L].AddComponent<GraphicRaycaster>();
           c.ignoreReversedGraphics = true;
        }
        { var c = goMap[-6820018181845890044L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_white");
        }
        { var c = goMap[2359160393980789769L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[2359160393980789769L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[2359160393980789769L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
        }
        { var c = goMap[-2219477878381123224L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_menpai_bg");
        }
        { var c = goMap[7040152402937814600L].AddComponent<ToggleGroup>();
           c.allowSwitchOff = false;
           _toggleGroupByMbPid[4646404708030672828L] = c;
        }
        { var c = goMap[5502497552007660027L].AddComponent<Image>();
           c.color = new Color(0.066038f, 0.066038f, 0.066038f, 0.678431f);
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
        { var c = goMap[-7314965977479778093L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("Fire_Effect"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[5501021488848377363L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.997786f);
           c.raycastTarget = true;
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
        { var c = goMap[-1122566743645268464L].AddComponent<Text>();
           c.text = "Thiên Nhẫn";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 65;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 20;
           c.resizeTextMaxSize = 65;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var g = goMap[-1122566743645268464L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(1.000000f, 0.961658f, 0.890196f, 1.000000f); }
        { var c = goMap[-1122566743645268464L].AddComponent<Outline>();
           c.effectColor = new Color(0.470588f, 0.293651f, 0.082353f, 0.611765f);
           c.effectDistance = new Vector2(3.000000f, 3.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[7577701490158478040L].AddComponent<Image>();
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
        { var c = goMap[-8863023607259300262L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-2689342375102368203L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("Metal_Effect"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[595637003103206320L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.997786f);
           c.raycastTarget = true;
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
        { var c = goMap[7536929498784973980L].AddComponent<Text>();
           c.text = "Thiếu Lâm";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 65;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 20;
           c.resizeTextMaxSize = 65;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var g = goMap[7536929498784973980L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(1.000000f, 0.991294f, 0.891509f, 1.000000f); }
        { var c = goMap[7536929498784973980L].AddComponent<Outline>();
           c.effectColor = new Color(0.613208f, 0.218379f, 0.112807f, 0.611765f);
           c.effectDistance = new Vector2(3.000000f, 3.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-4572191696158459248L].AddComponent<Image>();
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
        { var c = goMap[-7902422944309987778L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-7640437775082469868L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("Earth_Effect"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[-4344394444093759919L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.997786f);
           c.raycastTarget = true;
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
        { var c = goMap[2759912441097620874L].AddComponent<Text>();
           c.text = "Võ Đang";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 65;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 20;
           c.resizeTextMaxSize = 65;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var g = goMap[2759912441097620874L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(1.000000f, 0.961658f, 0.890196f, 1.000000f); }
        { var c = goMap[2759912441097620874L].AddComponent<Outline>();
           c.effectColor = new Color(0.396226f, 0.278480f, 0.199982f, 0.611765f);
           c.effectDistance = new Vector2(3.000000f, 3.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-2859587782140199941L].AddComponent<Image>();
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
        { var c = goMap[6414497830729389754L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-8266277647760883211L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("Water_Effect"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[-1691549535701390791L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.997786f);
           c.raycastTarget = true;
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
        { var c = goMap[5401522209080010638L].AddComponent<Text>();
           c.text = "7785";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 65;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 20;
           c.resizeTextMaxSize = 65;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var g = goMap[5401522209080010638L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.890196f, 0.994810f, 1.000000f, 1.000000f); }
        { var c = goMap[5401522209080010638L].AddComponent<Outline>();
           c.effectColor = new Color(0.044500f, 0.177934f, 0.377358f, 0.611765f);
           c.effectDistance = new Vector2(3.000000f, 3.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[274588443301963245L].AddComponent<Image>();
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
        { var c = goMap[-3616394257718424761L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-654701379753593422L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("Wood_Effect"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[-1780462580648434850L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.997786f);
           c.raycastTarget = true;
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
        { var c = goMap[-1916628071552239762L].AddComponent<Text>();
           c.text = "Đường Môn";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 65;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 20;
           c.resizeTextMaxSize = 65;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var g = goMap[-1916628071552239762L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.890196f, 0.994810f, 1.000000f, 1.000000f); }
        { var c = goMap[-1916628071552239762L].AddComponent<Outline>();
           c.effectColor = new Color(0.135502f, 0.330189f, 0.245234f, 0.611765f);
           c.effectDistance = new Vector2(3.000000f, 3.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-5000379029910219462L].AddComponent<Image>();
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
        { var c = goMap[4205163956466730127L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-2988921305116089728L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_createrole_faction_info");
        }
        { var c = goMap[8513335236900179819L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_factioninfo_cuiyan");
        }
        { var c = goMap[-8391397485744596302L].AddComponent<Text>();
           c.text = "1695";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = false;
           c.horizontalOverflow = HorizontalWrapMode.Overflow;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 0;
           c.resizeTextMaxSize = 100;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-8391397485744596302L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)2;
           c.verticalFit = (ContentSizeFitter.FitMode)2;
        }
        { var c = goMap[-3371520666826067037L].AddComponent<Text>();
           c.text = "6458";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = false;
           c.horizontalOverflow = HorizontalWrapMode.Overflow;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 0;
           c.resizeTextMaxSize = 100;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-3371520666826067037L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)2;
           c.verticalFit = (ContentSizeFitter.FitMode)2;
        }
        { var c = goMap[8621436611495578342L].AddComponent<Text>();
           c.text = "2156";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = false;
           c.horizontalOverflow = HorizontalWrapMode.Overflow;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 0;
           c.resizeTextMaxSize = 100;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[8621436611495578342L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)2;
           c.verticalFit = (ContentSizeFitter.FitMode)2;
        }
        { var c = goMap[-133340317476654060L].AddComponent<Text>();
           c.text = "Thao tác";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = false;
           c.horizontalOverflow = HorizontalWrapMode.Overflow;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 0;
           c.resizeTextMaxSize = 100;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-133340317476654060L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)2;
           c.verticalFit = (ContentSizeFitter.FitMode)2;
        }
        { var c = goMap[-3938406520542683453L].AddComponent<Text>();
           c.text = "10421";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = false;
           c.horizontalOverflow = HorizontalWrapMode.Overflow;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 0;
           c.resizeTextMaxSize = 100;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-3938406520542683453L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)2;
           c.verticalFit = (ContentSizeFitter.FitMode)2;
        }
        { var c = goMap[158604653455886913L].AddComponent<Text>();
           c.text = "5160";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = false;
           c.horizontalOverflow = HorizontalWrapMode.Overflow;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 0;
           c.resizeTextMaxSize = 100;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[158604653455886913L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)2;
           c.verticalFit = (ContentSizeFitter.FitMode)2;
        }
        { var c = goMap[5934046710479141241L].AddComponent<Text>();
           c.text = "8537";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.UpperLeft;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 1;
           c.resizeTextMaxSize = 20;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-7174170611939755906L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-7174170611939755906L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-7174170611939755906L].AddComponent<UIScalePulse>();
           c.upScale = 1.100000f; c.duration = 0.100000f; c.scaleUp = true;
           c.enabled = true;
        }
        { var c = goMap[-3767299883770909055L].AddComponent<Text>();
           c.text = "2684";
           c.color = new Color(0.466667f, 0.215686f, 0.078431f, 1.000000f);
           c.fontSize = 24;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 24;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-6398053035568973071L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-1218023274851310521L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_faction_bg");
        }
        { var c = goMap[-7985805368465966213L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("faction_tangmen");
        }
        { var c = goMap[6966271682889459231L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
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
           c.sprite = LookupSprite("img_faction_select");
        }
        { var c = goMap[8048942549968783147L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-7518276769389678122L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_faction_bg");
        }
        { var c = goMap[8697976976940919972L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("faction_shaolin");
        }
        { var c = goMap[-317013419373663485L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
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
           c.sprite = LookupSprite("img_faction_select");
        }
        { var c = goMap[1186400962111014990L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[1746370816962148383L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_faction_bg");
        }
        { var c = goMap[7498313837232261714L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("faction_mingjiao");
        }
        { var c = goMap[7830615029234965383L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
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
           c.sprite = LookupSprite("img_faction_select");
        }
        { var c = goMap[8831826385193187329L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[6159100301111158809L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_faction_bg");
        }
        { var c = goMap[672453596266439318L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("faction_kunlun");
        }
        { var c = goMap[-6220139324773100714L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
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
           c.sprite = LookupSprite("img_faction_select");
        }
        { var c = goMap[6529269463383508547L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-5218614377579334889L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_faction_bg");
        }
        { var c = goMap[-686915155390993805L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("faction_gaibang");
        }
        { var c = goMap[295662126974219862L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
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
           c.sprite = LookupSprite("img_faction_select");
        }
        { var c = goMap[3630878805144999280L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[3485391183591083210L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_faction_bg");
        }
        { var c = goMap[-9207004325593006483L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("faction_emei");
        }
        { var c = goMap[-7348495412049388635L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
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
           c.sprite = LookupSprite("img_faction_select");
        }
        { var c = goMap[6852732223945741817L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[431990548120164459L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_faction_bg");
        }
        { var c = goMap[7278829630593875893L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("faction_xiaoyao");
        }
        { var c = goMap[-6272325846242310396L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
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
           c.sprite = LookupSprite("img_faction_select");
        }
        { var c = goMap[-548575148030427951L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[4137840714879873872L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_faction_bg");
        }
        { var c = goMap[5726619445160175043L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("faction_gumu");
        }
        { var c = goMap[4177400639133106361L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
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
           c.sprite = LookupSprite("img_faction_select");
        }
        { var c = goMap[-163352017617084981L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[3122622948924706758L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_faction_bg");
        }
        { var c = goMap[-716778710931694527L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("faction_taohua");
        }
        { var c = goMap[5239800010931282688L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
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
           c.sprite = LookupSprite("img_faction_select");
        }
        { var c = goMap[4922474593684333695L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-7920799018745589430L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_faction_bg");
        }
        { var c = goMap[-6111115773420419690L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("faction_YiPinTang");
        }
        { var c = goMap[1707529008551604124L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
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
           c.sprite = LookupSprite("img_faction_select");
        }
        { var c = goMap[-2617066436648305912L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-6337189036971934932L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_faction_bg");
        }
        { var c = goMap[2432531351441246217L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("faction_WuHuntang");
        }
        { var c = goMap[6068663889059216974L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
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
           c.sprite = LookupSprite("img_faction_select");
        }
        { var c = goMap[-1790169810516780900L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-1668267671223787435L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_faction_bg");
        }
        { var c = goMap[-975998876663545048L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("faction_tianwang");
        }
        { var c = goMap[-7061502623815358326L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
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
           c.sprite = LookupSprite("img_faction_select");
        }
        { var c = goMap[463955709694975218L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[937791589142165462L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_faction_bg");
        }
        { var c = goMap[-7691976798653124528L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("faction_cuiyan");
        }
        { var c = goMap[-5689940029379283369L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
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
           c.sprite = LookupSprite("img_faction_select");
        }
        { var c = goMap[9033730404377387568L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[2029463042147613593L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_faction_bg");
        }
        { var c = goMap[-5709931580719791864L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("faction_wudang");
        }
        { var c = goMap[-1672203231299551832L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
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
           c.sprite = LookupSprite("img_faction_select");
        }
        { var c = goMap[-3454470024530962112L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[6528570390512217460L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_faction_bg");
        }
        { var c = goMap[-3857054920168619446L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("faction_tianren");
        }
        { var c = goMap[-2517660705555871922L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
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
           c.sprite = LookupSprite("img_faction_select");
        }
        { var c = goMap[-6160857569591889873L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[4358204666419679998L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_faction_bg");
        }
        { var c = goMap[308903074891103611L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("faction_duanshi");
        }
        { var c = goMap[-372841046645356312L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
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
           c.sprite = LookupSprite("img_faction_select");
        }
        { var c = goMap[-5921073451059394752L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-1753466198599486634L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_faction_bg");
        }
        { var c = goMap[-1018890697026895511L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("faction_wudu");
        }
        { var c = goMap[8935195549274196707L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
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
           c.sprite = LookupSprite("img_faction_select");
        }
        { var c = goMap[4289239842280690141L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-8884348135360029421L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_faction_bg");
        }
        { var c = goMap[5439730254507698730L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("faction_badao");
        }
        { var c = goMap[-1235751324295501401L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
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
           c.sprite = LookupSprite("img_faction_select");
        }
        { var c = goMap[1663017479171496580L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-8548785630604288138L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_faction_bg");
        }
        { var c = goMap[8700772532374245602L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("faction_baituosha");
        }
        { var c = goMap[-3893353556541859372L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
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
           c.sprite = LookupSprite("img_faction_select");
        }
        { var c = goMap[-2276432401239455630L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-8386982700619931365L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_faction_bg");
        }
        { var c = goMap[-2816521808406854022L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("faction_changge");
        }
        { var c = goMap[2261284890229149185L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
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
           c.sprite = LookupSprite("img_faction_select");
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
        var rootGO = goMap[-9072411513186826955L];
        string path = "Assets/Prefabs/Imported/UIChangeFaction.prefab";
        PrefabUtility.SaveAsPrefabAsset(rootGO, path);
        Object.DestroyImmediate(rootGO);
        Debug.Log("[Import_res_p_257] Saved " + path);
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