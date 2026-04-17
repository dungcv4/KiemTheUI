// AUTO-GENERATED from res_p_263.ab — DO NOT EDIT MANUALLY.
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;
using System.Collections.Generic;
using KTO.Game;  // UIJoyStick and other ported KTO scripts

public class Import_res_p_263
{
    [MenuItem("KTO/Import/res_p_263")]
    public static void Build()
    {
        Debug.Log("[Import_res_p_263] Building UIFirstRecharge...");

        // ─── Create all GameObjects ───────────────────────────
        var goMap = new Dictionary<long, GameObject>();
        var _toggleGroupByMbPid = new Dictionary<long, ToggleGroup>();
        var _toggleGroupLinks = new List<System.Tuple<Toggle,long>>();
        { var go = new GameObject("UIFirstRecharge"); go.SetActive(true); goMap[1321410803127715779L] = go; }
        { var go = new GameObject("node"); go.SetActive(true); goMap[-4475763450260894290L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(true); goMap[2572576028241539523L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(true); goMap[6536010333649535919L] = go; }
        { var go = new GameObject("Title"); go.SetActive(true); goMap[1168599770791567581L] = go; }
        { var go = new GameObject("txtTitle"); go.SetActive(false); goMap[5915213288415998409L] = go; }
        { var go = new GameObject("btnHelp"); go.SetActive(false); goMap[-2423226350155961936L] = go; }
        { var go = new GameObject("Star_Effect"); go.SetActive(true); goMap[-3771475206394412550L] = go; }
        { var go = new GameObject("imgBird"); go.SetActive(true); goMap[-1356600728976258236L] = go; }
        { var go = new GameObject("01"); go.SetActive(true); goMap[-7102878991040179537L] = go; }
        { var go = new GameObject("02"); go.SetActive(true); goMap[-6092665898879814145L] = go; }
        { var go = new GameObject("03"); go.SetActive(true); goMap[8382098440814576249L] = go; }
        { var go = new GameObject("04"); go.SetActive(true); goMap[-4969121518950598026L] = go; }
        { var go = new GameObject("05"); go.SetActive(true); goMap[1665404158550851300L] = go; }
        { var go = new GameObject("imgTitle"); go.SetActive(true); goMap[-7718291630482966345L] = go; }
        { var go = new GameObject("txtFirstRechargeTitle1"); go.SetActive(true); goMap[2355295972845170895L] = go; }
        { var go = new GameObject("titleCell"); go.SetActive(true); goMap[226982818304612635L] = go; }
        { var go = new GameObject("titleTxtCell1"); go.SetActive(true); goMap[8423277232439030286L] = go; }
        { var go = new GameObject("txt1"); go.SetActive(true); goMap[-8537370499335179440L] = go; }
        { var go = new GameObject("titleTxtCell1"); go.SetActive(true); goMap[-5869193051230139926L] = go; }
        { var go = new GameObject("imgTxtBg"); go.SetActive(true); goMap[7920135591107202104L] = go; }
        { var go = new GameObject("txt1"); go.SetActive(true); goMap[-1150194513662533951L] = go; }
        { var go = new GameObject("imgTxtLight"); go.SetActive(true); goMap[8569158337503720313L] = go; }
        { var go = new GameObject("titleTxtCell2"); go.SetActive(true); goMap[6852839294160685235L] = go; }
        { var go = new GameObject("imgTxtBg"); go.SetActive(true); goMap[-3691624246304036139L] = go; }
        { var go = new GameObject("txt1"); go.SetActive(true); goMap[6134199968575987111L] = go; }
        { var go = new GameObject("imgTxtLight"); go.SetActive(true); goMap[8606697786652477271L] = go; }
        { var go = new GameObject("txt2"); go.SetActive(true); goMap[5660286852075153158L] = go; }
        { var go = new GameObject("btnClose"); go.SetActive(true); goMap[-2872861530809471962L] = go; }
        { var go = new GameObject("Left"); go.SetActive(false); goMap[-3133543065130051425L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(true); goMap[-7148334611980088207L] = go; }
        { var go = new GameObject("txtTitle1"); go.SetActive(true); goMap[-5206377813666562807L] = go; }
        { var go = new GameObject("txtTitle2"); go.SetActive(true); goMap[3408193820020575747L] = go; }
        { var go = new GameObject("txtTitle3"); go.SetActive(true); goMap[6730735762649359727L] = go; }
        { var go = new GameObject("txtTitle4"); go.SetActive(true); goMap[-8701214946144103844L] = go; }
        { var go = new GameObject("txtTitle5"); go.SetActive(true); goMap[3687376010923071706L] = go; }
        { var go = new GameObject("txtTitle6"); go.SetActive(true); goMap[-163767145814242919L] = go; }
        { var go = new GameObject("txtTitle7"); go.SetActive(true); goMap[5451380854890503713L] = go; }
        { var go = new GameObject("Left2"); go.SetActive(false); goMap[-158520689025684457L] = go; }
        { var go = new GameObject("HuangJinWuQi"); go.SetActive(true); goMap[-8316399448745976762L] = go; }
        { var go = new GameObject("ChanRao_XingKong01"); go.SetActive(true); goMap[-1039633883586423405L] = go; }
        { var go = new GameObject("ChanRao_XingKong02"); go.SetActive(true); goMap[-1069019910440768512L] = go; }
        { var go = new GameObject("ChanRao_01"); go.SetActive(true); goMap[-6588181185751579557L] = go; }
        { var go = new GameObject("ChanRao_02"); go.SetActive(true); goMap[-4849321640184816720L] = go; }
        { var go = new GameObject("FenWei"); go.SetActive(true); goMap[5381486470052326892L] = go; }
        { var go = new GameObject("Star"); go.SetActive(true); goMap[2800854959469575330L] = go; }
        { var go = new GameObject("BG_Glow"); go.SetActive(true); goMap[-6143546635696330925L] = go; }
        { var go = new GameObject("Effect"); go.SetActive(true); goMap[-2250269441822710595L] = go; }
        { var go = new GameObject("Huan"); go.SetActive(true); goMap[-8439854290298478858L] = go; }
        { var go = new GameObject("Huan01"); go.SetActive(true); goMap[4208562462024266983L] = go; }
        { var go = new GameObject("ZZ005"); go.SetActive(true); goMap[5598024567103531566L] = go; }
        { var go = new GameObject("GuangShu"); go.SetActive(true); goMap[5683072919219413120L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[7834268823755365442L] = go; }
        { var go = new GameObject("Star02"); go.SetActive(true); goMap[6723451449330283919L] = go; }
        { var go = new GameObject("wuqi"); go.SetActive(true); goMap[-5325567076862510331L] = go; }
        { var go = new GameObject("zhang"); go.SetActive(true); goMap[-8272830783927924514L] = go; }
        { var go = new GameObject("Imagezhang_BGGlow"); go.SetActive(true); goMap[-2162192462650943823L] = go; }
        { var go = new GameObject("Imagezhang"); go.SetActive(true); goMap[-4872483459793361276L] = go; }
        { var go = new GameObject("Imagezhang_Glow"); go.SetActive(true); goMap[-1589447510142178161L] = go; }
        { var go = new GameObject("Imagezhang_UV"); go.SetActive(true); goMap[205490616832049589L] = go; }
        { var go = new GameObject("PiaoDai01"); go.SetActive(true); goMap[4444512812581816258L] = go; }
        { var go = new GameObject("PiaoDai01"); go.SetActive(true); goMap[-3980086089390010786L] = go; }
        { var go = new GameObject("Bone014"); go.SetActive(true); goMap[1601242938253442173L] = go; }
        { var go = new GameObject("Bone015"); go.SetActive(true); goMap[-903164378901264733L] = go; }
        { var go = new GameObject("Bone016"); go.SetActive(true); goMap[698362201248310692L] = go; }
        { var go = new GameObject("Bone017"); go.SetActive(true); goMap[-1635370987071540421L] = go; }
        { var go = new GameObject("Bone018"); go.SetActive(true); goMap[-5029732791649398007L] = go; }
        { var go = new GameObject("Bone019"); go.SetActive(true); goMap[3526304395477041399L] = go; }
        { var go = new GameObject("Object001"); go.SetActive(true); goMap[4556311699144140717L] = go; }
        { var go = new GameObject("PiaoDai02"); go.SetActive(true); goMap[-4706516036870666883L] = go; }
        { var go = new GameObject("Bone014"); go.SetActive(true); goMap[4485042542680077595L] = go; }
        { var go = new GameObject("Bone015"); go.SetActive(true); goMap[5013748669551761073L] = go; }
        { var go = new GameObject("Bone016"); go.SetActive(true); goMap[-4473945768860680542L] = go; }
        { var go = new GameObject("Bone017"); go.SetActive(true); goMap[6445648730716746772L] = go; }
        { var go = new GameObject("Bone018"); go.SetActive(true); goMap[3080557948665797021L] = go; }
        { var go = new GameObject("Bone019"); go.SetActive(true); goMap[2061497031918409381L] = go; }
        { var go = new GameObject("Object001"); go.SetActive(true); goMap[-7654985919380733478L] = go; }
        { var go = new GameObject("dao"); go.SetActive(true); goMap[5726838260357644547L] = go; }
        { var go = new GameObject("ImageDao_BGGlow"); go.SetActive(true); goMap[-496810956130788281L] = go; }
        { var go = new GameObject("ImageDao"); go.SetActive(true); goMap[4865698246810517461L] = go; }
        { var go = new GameObject("ImageDao_Glow"); go.SetActive(true); goMap[3305696332088883623L] = go; }
        { var go = new GameObject("ImageDao_UV"); go.SetActive(true); goMap[7527110540882356465L] = go; }
        { var go = new GameObject("jian"); go.SetActive(true); goMap[8285414295179342323L] = go; }
        { var go = new GameObject("Eyes_Star"); go.SetActive(true); goMap[5581752425387351965L] = go; }
        { var go = new GameObject("Imagejian_BGGlow"); go.SetActive(true); goMap[3848780946485745738L] = go; }
        { var go = new GameObject("Imagejian"); go.SetActive(true); goMap[-1125618174966734818L] = go; }
        { var go = new GameObject("Imagejian_Glow"); go.SetActive(true); goMap[-8969339245663597592L] = go; }
        { var go = new GameObject("Imagejian_UV"); go.SetActive(true); goMap[-5340770857382424653L] = go; }
        { var go = new GameObject("Right"); go.SetActive(true); goMap[-5249955380496700413L] = go; }
        { var go = new GameObject("DayTemplate"); go.SetActive(true); goMap[8458511950136368566L] = go; }
        { var go = new GameObject("Template"); go.SetActive(true); goMap[6166266839081062010L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(true); goMap[8633548862401045888L] = go; }
        { var go = new GameObject("imgBgHL"); go.SetActive(true); goMap[-5517155818417356435L] = go; }
        { var go = new GameObject("XuanZhong_Effect"); go.SetActive(true); goMap[8525455570753384539L] = go; }
        { var go = new GameObject("M3"); go.SetActive(true); goMap[-4901590356594771980L] = go; }
        { var go = new GameObject("M2"); go.SetActive(true); goMap[1848139379315763173L] = go; }
        { var go = new GameObject("P1"); go.SetActive(true); goMap[-3386218283498141340L] = go; }
        { var go = new GameObject("imgTitleBg"); go.SetActive(false); goMap[9086048200956773168L] = go; }
        { var go = new GameObject("txtDay"); go.SetActive(true); goMap[8957688514453894388L] = go; }
        { var go = new GameObject("txtSendGroup"); go.SetActive(false); goMap[-9217430888823764461L] = go; }
        { var go = new GameObject("txtgive"); go.SetActive(true); goMap[29103368127581385L] = go; }
        { var go = new GameObject("imgyuanbao"); go.SetActive(true); goMap[5848656180802262335L] = go; }
        { var go = new GameObject("txtnub"); go.SetActive(true); goMap[-7550828500886512059L] = go; }
        { var go = new GameObject("ItemGroup"); go.SetActive(true); goMap[3284408726362578336L] = go; }
        { var go = new GameObject("ElementTemplate"); go.SetActive(true); goMap[-1920700934492219182L] = go; }
        { var go = new GameObject("UIItemGrid"); go.SetActive(true); goMap[-606462473901103705L] = go; }
        { var go = new GameObject("bg"); go.SetActive(false); goMap[1674010639532602410L] = go; }
        { var go = new GameObject("Base"); go.SetActive(true); goMap[-2616475104034453091L] = go; }
        { var go = new GameObject("ItemLayer"); go.SetActive(false); goMap[-154035390679449346L] = go; }
        { var go = new GameObject("Fragment"); go.SetActive(false); goMap[157346044455286694L] = go; }
        { var go = new GameObject("TagNew"); go.SetActive(false); goMap[5665887286197770712L] = go; }
        { var go = new GameObject("LabelSuffix"); go.SetActive(true); goMap[9177013899863594447L] = go; }
        { var go = new GameObject("txtRBCorner"); go.SetActive(false); goMap[-8186146084440968213L] = go; }
        { var go = new GameObject("txtCenter"); go.SetActive(false); goMap[-6545260575577152827L] = go; }
        { var go = new GameObject("txtLTCorner"); go.SetActive(false); goMap[-5860302910169947282L] = go; }
        { var go = new GameObject("ImgLTCorner"); go.SetActive(false); goMap[3392784441983655832L] = go; }
        { var go = new GameObject("CDLayer"); go.SetActive(true); goMap[-3339643156055365005L] = go; }
        { var go = new GameObject("imgPlus"); go.SetActive(false); goMap[3105800876152136872L] = go; }
        { var go = new GameObject("TagTip"); go.SetActive(false); goMap[-480078052957716253L] = go; }
        { var go = new GameObject("TagCanDeal"); go.SetActive(false); goMap[8180575456575446535L] = go; }
        { var go = new GameObject("TagMarketStall"); go.SetActive(false); goMap[-8417391995465598444L] = go; }
        { var go = new GameObject("TagStone"); go.SetActive(false); goMap[-7481285484520842710L] = go; }
        { var go = new GameObject("TagZhenJue"); go.SetActive(false); goMap[-6952801823313711828L] = go; }
        { var go = new GameObject("ImgRedPoint"); go.SetActive(false); goMap[-5476677552050059282L] = go; }
        { var go = new GameObject("TagEquipSeries"); go.SetActive(false); goMap[6578655124971333016L] = go; }
        { var go = new GameObject("Enhance"); go.SetActive(true); goMap[-580496876053682101L] = go; }
        { var go = new GameObject("imgRankBg"); go.SetActive(false); goMap[8464994661215136217L] = go; }
        { var go = new GameObject("txtRank"); go.SetActive(true); goMap[-1411731018504975962L] = go; }
        { var go = new GameObject("imgRankSeries"); go.SetActive(false); goMap[-7445684838684633943L] = go; }
        { var go = new GameObject("txtRank"); go.SetActive(true); goMap[-1512018235322137647L] = go; }
        { var go = new GameObject("ImgDivineWeaponLV"); go.SetActive(false); goMap[7909964995268025563L] = go; }
        { var go = new GameObject("TxtLV"); go.SetActive(true); goMap[1989433618379583866L] = go; }
        { var go = new GameObject("imgQuestionMark"); go.SetActive(false); goMap[1343647390472623416L] = go; }
        { var go = new GameObject("Higher"); go.SetActive(false); goMap[8034926912724126588L] = go; }
        { var go = new GameObject("LabelHushi"); go.SetActive(false); goMap[4631999038428074561L] = go; }
        { var go = new GameObject("ImgSelect"); go.SetActive(false); goMap[-3101962188092499811L] = go; }
        { var go = new GameObject("ImgSelect"); go.SetActive(true); goMap[-2233881748403807839L] = go; }
        { var go = new GameObject("ImgSelect (1)"); go.SetActive(true); goMap[8471964405290936962L] = go; }
        { var go = new GameObject("btn_Effect"); go.SetActive(true); goMap[-8562907073154870310L] = go; }
        { var go = new GameObject("RaoDong01"); go.SetActive(true); goMap[-167312839772152562L] = go; }
        { var go = new GameObject("Star"); go.SetActive(true); goMap[-4818096439885577900L] = go; }
        { var go = new GameObject("Lightning"); go.SetActive(true); goMap[-2482630891036412831L] = go; }
        { var go = new GameObject("SaoGuang_Glow"); go.SetActive(true); goMap[677958139419310109L] = go; }
        { var go = new GameObject("Run"); go.SetActive(true); goMap[-4645795891747450289L] = go; }
        { var go = new GameObject("saoguang"); go.SetActive(true); goMap[6331862153999187726L] = go; }
        { var go = new GameObject("btnGet"); go.SetActive(false); goMap[5391925274972610953L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[4080714912660970804L] = go; }
        { var go = new GameObject("Received"); go.SetActive(false); goMap[2197057476232284188L] = go; }
        { var go = new GameObject("TxtReceived"); go.SetActive(true); goMap[9141388161657250472L] = go; }
        { var go = new GameObject("imgComplete"); go.SetActive(false); goMap[8894519374811070620L] = go; }
        { var go = new GameObject("imgComplete (1)"); go.SetActive(true); goMap[6381329666311794939L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-511247928905992696L] = go; }
        { var go = new GameObject("btnBg"); go.SetActive(true); goMap[-2013028261450389889L] = go; }
        { var go = new GameObject("btnRecharge"); go.SetActive(false); goMap[-145426538223464941L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-4927199037385578396L] = go; }
        { var go = new GameObject("btnRecharge_Effect"); go.SetActive(true); goMap[-2608663744267253450L] = go; }
        { var go = new GameObject("Line"); go.SetActive(true); goMap[-8015272032082769853L] = go; }
        { var go = new GameObject("Line01"); go.SetActive(true); goMap[4073307657643642584L] = go; }
        { var go = new GameObject("Line02"); go.SetActive(true); goMap[-8849781194626718294L] = go; }
        { var go = new GameObject("btnGet2"); go.SetActive(false); goMap[-4425289922153626673L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-7804004827307464682L] = go; }
        { var go = new GameObject("btnRecharge_Effect"); go.SetActive(true); goMap[-2691750266037885318L] = go; }
        { var go = new GameObject("Line"); go.SetActive(true); goMap[-3150599755772081261L] = go; }
        { var go = new GameObject("Line01"); go.SetActive(true); goMap[1454951808346740893L] = go; }
        { var go = new GameObject("Line02"); go.SetActive(true); goMap[2222770802667375361L] = go; }
        { var go = new GameObject("Received2"); go.SetActive(true); goMap[-5045912005471250823L] = go; }
        { var go = new GameObject("TxtReceived"); go.SetActive(true); goMap[-2180129947520023521L] = go; }
        { var go = new GameObject("Star"); go.SetActive(false); goMap[6829282181419118315L] = go; }
        { var go = new GameObject("Star01"); go.SetActive(true); goMap[2839894111397384567L] = go; }
        { var go = new GameObject("Star02"); go.SetActive(true); goMap[-5069956051199359346L] = go; }
        { var go = new GameObject("GoldEffect"); go.SetActive(false); goMap[1540995808043783220L] = go; }
        { var go = new GameObject("Star"); go.SetActive(true); goMap[8247149811443190479L] = go; }
        { var go = new GameObject("Gold"); go.SetActive(true); goMap[1576721876117323314L] = go; }
        { var go = new GameObject("txtTips"); go.SetActive(false); goMap[5052498857261964566L] = go; }
        { var go = new GameObject("imgBird2"); go.SetActive(false); goMap[1240749494308421572L] = go; }
        { var go = new GameObject("ZongJiaZhiCell"); go.SetActive(true); goMap[1770603109409228166L] = go; }
        { var go = new GameObject("zongJiaZhiCell"); go.SetActive(true); goMap[-5195305283161794375L] = go; }
        { var go = new GameObject("imgTxtBg"); go.SetActive(true); goMap[-1329124656480310496L] = go; }
        { var go = new GameObject("txtZongJiaZhi"); go.SetActive(true); goMap[-8631799862734846532L] = go; }
        { var go = new GameObject("imgTxtLight"); go.SetActive(true); goMap[6458407402086600384L] = go; }
        { var go = new GameObject("imgTxtNumberBg"); go.SetActive(true); goMap[-541715995506283716L] = go; }
        { var go = new GameObject("imgNumer1"); go.SetActive(true); goMap[-2315859791270438532L] = go; }
        { var go = new GameObject("imgNumer2"); go.SetActive(true); goMap[-5458798972353439190L] = go; }
        { var go = new GameObject("imgNumer3"); go.SetActive(true); goMap[2064748088468298363L] = go; }
        { var go = new GameObject("imgNumer4"); go.SetActive(true); goMap[-6151454567917345726L] = go; }
        { var go = new GameObject("imgNumer5"); go.SetActive(true); goMap[-3669359067182095370L] = go; }
        { var go = new GameObject("YuanCell"); go.SetActive(true); goMap[4498134444510147942L] = go; }
        { var go = new GameObject("imgTxtBg"); go.SetActive(true); goMap[3995307805896169679L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[-3353023652095368717L] = go; }

        // ─── Parent links ─────────────────────────────────────
        goMap[-4475763450260894290L].transform.SetParent(goMap[1321410803127715779L].transform, false);
        goMap[2572576028241539523L].transform.SetParent(goMap[-4475763450260894290L].transform, false);
        goMap[6536010333649535919L].transform.SetParent(goMap[2572576028241539523L].transform, false);
        goMap[1168599770791567581L].transform.SetParent(goMap[2572576028241539523L].transform, false);
        goMap[5915213288415998409L].transform.SetParent(goMap[1168599770791567581L].transform, false);
        goMap[-2423226350155961936L].transform.SetParent(goMap[1168599770791567581L].transform, false);
        goMap[-3771475206394412550L].transform.SetParent(goMap[1168599770791567581L].transform, false);
        goMap[-1356600728976258236L].transform.SetParent(goMap[1168599770791567581L].transform, false);
        goMap[-7102878991040179537L].transform.SetParent(goMap[-1356600728976258236L].transform, false);
        goMap[-6092665898879814145L].transform.SetParent(goMap[-1356600728976258236L].transform, false);
        goMap[8382098440814576249L].transform.SetParent(goMap[-1356600728976258236L].transform, false);
        goMap[-4969121518950598026L].transform.SetParent(goMap[-1356600728976258236L].transform, false);
        goMap[1665404158550851300L].transform.SetParent(goMap[-1356600728976258236L].transform, false);
        goMap[-7718291630482966345L].transform.SetParent(goMap[1168599770791567581L].transform, false);
        goMap[2355295972845170895L].transform.SetParent(goMap[-7718291630482966345L].transform, false);
        goMap[226982818304612635L].transform.SetParent(goMap[-7718291630482966345L].transform, false);
        goMap[8423277232439030286L].transform.SetParent(goMap[226982818304612635L].transform, false);
        goMap[-8537370499335179440L].transform.SetParent(goMap[8423277232439030286L].transform, false);
        goMap[-5869193051230139926L].transform.SetParent(goMap[8423277232439030286L].transform, false);
        goMap[7920135591107202104L].transform.SetParent(goMap[-5869193051230139926L].transform, false);
        goMap[-1150194513662533951L].transform.SetParent(goMap[-5869193051230139926L].transform, false);
        goMap[8569158337503720313L].transform.SetParent(goMap[-5869193051230139926L].transform, false);
        goMap[6852839294160685235L].transform.SetParent(goMap[226982818304612635L].transform, false);
        goMap[-3691624246304036139L].transform.SetParent(goMap[6852839294160685235L].transform, false);
        goMap[6134199968575987111L].transform.SetParent(goMap[6852839294160685235L].transform, false);
        goMap[8606697786652477271L].transform.SetParent(goMap[6852839294160685235L].transform, false);
        goMap[5660286852075153158L].transform.SetParent(goMap[6852839294160685235L].transform, false);
        goMap[-2872861530809471962L].transform.SetParent(goMap[2572576028241539523L].transform, false);
        goMap[-3133543065130051425L].transform.SetParent(goMap[2572576028241539523L].transform, false);
        goMap[-7148334611980088207L].transform.SetParent(goMap[-3133543065130051425L].transform, false);
        goMap[-5206377813666562807L].transform.SetParent(goMap[-3133543065130051425L].transform, false);
        goMap[3408193820020575747L].transform.SetParent(goMap[-3133543065130051425L].transform, false);
        goMap[6730735762649359727L].transform.SetParent(goMap[-3133543065130051425L].transform, false);
        goMap[-8701214946144103844L].transform.SetParent(goMap[-3133543065130051425L].transform, false);
        goMap[3687376010923071706L].transform.SetParent(goMap[-3133543065130051425L].transform, false);
        goMap[-163767145814242919L].transform.SetParent(goMap[-3133543065130051425L].transform, false);
        goMap[5451380854890503713L].transform.SetParent(goMap[-3133543065130051425L].transform, false);
        goMap[-158520689025684457L].transform.SetParent(goMap[2572576028241539523L].transform, false);
        goMap[-8316399448745976762L].transform.SetParent(goMap[2572576028241539523L].transform, false);
        goMap[-1039633883586423405L].transform.SetParent(goMap[-8316399448745976762L].transform, false);
        goMap[-1069019910440768512L].transform.SetParent(goMap[-8316399448745976762L].transform, false);
        goMap[-6588181185751579557L].transform.SetParent(goMap[-8316399448745976762L].transform, false);
        goMap[-4849321640184816720L].transform.SetParent(goMap[-8316399448745976762L].transform, false);
        goMap[5381486470052326892L].transform.SetParent(goMap[-8316399448745976762L].transform, false);
        goMap[2800854959469575330L].transform.SetParent(goMap[5381486470052326892L].transform, false);
        goMap[-6143546635696330925L].transform.SetParent(goMap[5381486470052326892L].transform, false);
        goMap[-2250269441822710595L].transform.SetParent(goMap[5381486470052326892L].transform, false);
        goMap[-8439854290298478858L].transform.SetParent(goMap[-2250269441822710595L].transform, false);
        goMap[4208562462024266983L].transform.SetParent(goMap[-2250269441822710595L].transform, false);
        goMap[5598024567103531566L].transform.SetParent(goMap[-2250269441822710595L].transform, false);
        goMap[5683072919219413120L].transform.SetParent(goMap[-2250269441822710595L].transform, false);
        goMap[7834268823755365442L].transform.SetParent(goMap[5381486470052326892L].transform, false);
        goMap[6723451449330283919L].transform.SetParent(goMap[5381486470052326892L].transform, false);
        goMap[-5325567076862510331L].transform.SetParent(goMap[-8316399448745976762L].transform, false);
        goMap[-8272830783927924514L].transform.SetParent(goMap[-5325567076862510331L].transform, false);
        goMap[-2162192462650943823L].transform.SetParent(goMap[-8272830783927924514L].transform, false);
        goMap[-4872483459793361276L].transform.SetParent(goMap[-8272830783927924514L].transform, false);
        goMap[-1589447510142178161L].transform.SetParent(goMap[-8272830783927924514L].transform, false);
        goMap[205490616832049589L].transform.SetParent(goMap[-8272830783927924514L].transform, false);
        goMap[4444512812581816258L].transform.SetParent(goMap[-8272830783927924514L].transform, false);
        goMap[-3980086089390010786L].transform.SetParent(goMap[4444512812581816258L].transform, false);
        goMap[1601242938253442173L].transform.SetParent(goMap[-3980086089390010786L].transform, false);
        goMap[-903164378901264733L].transform.SetParent(goMap[1601242938253442173L].transform, false);
        goMap[698362201248310692L].transform.SetParent(goMap[-903164378901264733L].transform, false);
        goMap[-1635370987071540421L].transform.SetParent(goMap[698362201248310692L].transform, false);
        goMap[-5029732791649398007L].transform.SetParent(goMap[-1635370987071540421L].transform, false);
        goMap[3526304395477041399L].transform.SetParent(goMap[-5029732791649398007L].transform, false);
        goMap[4556311699144140717L].transform.SetParent(goMap[-3980086089390010786L].transform, false);
        goMap[-4706516036870666883L].transform.SetParent(goMap[-8272830783927924514L].transform, false);
        goMap[4485042542680077595L].transform.SetParent(goMap[-4706516036870666883L].transform, false);
        goMap[5013748669551761073L].transform.SetParent(goMap[4485042542680077595L].transform, false);
        goMap[-4473945768860680542L].transform.SetParent(goMap[5013748669551761073L].transform, false);
        goMap[6445648730716746772L].transform.SetParent(goMap[-4473945768860680542L].transform, false);
        goMap[3080557948665797021L].transform.SetParent(goMap[6445648730716746772L].transform, false);
        goMap[2061497031918409381L].transform.SetParent(goMap[3080557948665797021L].transform, false);
        goMap[-7654985919380733478L].transform.SetParent(goMap[-4706516036870666883L].transform, false);
        goMap[5726838260357644547L].transform.SetParent(goMap[-5325567076862510331L].transform, false);
        goMap[-496810956130788281L].transform.SetParent(goMap[5726838260357644547L].transform, false);
        goMap[4865698246810517461L].transform.SetParent(goMap[5726838260357644547L].transform, false);
        goMap[3305696332088883623L].transform.SetParent(goMap[5726838260357644547L].transform, false);
        goMap[7527110540882356465L].transform.SetParent(goMap[5726838260357644547L].transform, false);
        goMap[8285414295179342323L].transform.SetParent(goMap[-5325567076862510331L].transform, false);
        goMap[5581752425387351965L].transform.SetParent(goMap[8285414295179342323L].transform, false);
        goMap[3848780946485745738L].transform.SetParent(goMap[8285414295179342323L].transform, false);
        goMap[-1125618174966734818L].transform.SetParent(goMap[8285414295179342323L].transform, false);
        goMap[-8969339245663597592L].transform.SetParent(goMap[8285414295179342323L].transform, false);
        goMap[-5340770857382424653L].transform.SetParent(goMap[8285414295179342323L].transform, false);
        goMap[-5249955380496700413L].transform.SetParent(goMap[2572576028241539523L].transform, false);
        goMap[8458511950136368566L].transform.SetParent(goMap[-5249955380496700413L].transform, false);
        goMap[6166266839081062010L].transform.SetParent(goMap[8458511950136368566L].transform, false);
        goMap[8633548862401045888L].transform.SetParent(goMap[6166266839081062010L].transform, false);
        goMap[-5517155818417356435L].transform.SetParent(goMap[6166266839081062010L].transform, false);
        goMap[8525455570753384539L].transform.SetParent(goMap[-5517155818417356435L].transform, false);
        goMap[-4901590356594771980L].transform.SetParent(goMap[8525455570753384539L].transform, false);
        goMap[1848139379315763173L].transform.SetParent(goMap[8525455570753384539L].transform, false);
        goMap[-3386218283498141340L].transform.SetParent(goMap[8525455570753384539L].transform, false);
        goMap[9086048200956773168L].transform.SetParent(goMap[6166266839081062010L].transform, false);
        goMap[8957688514453894388L].transform.SetParent(goMap[6166266839081062010L].transform, false);
        goMap[-9217430888823764461L].transform.SetParent(goMap[6166266839081062010L].transform, false);
        goMap[29103368127581385L].transform.SetParent(goMap[-9217430888823764461L].transform, false);
        goMap[5848656180802262335L].transform.SetParent(goMap[-9217430888823764461L].transform, false);
        goMap[-7550828500886512059L].transform.SetParent(goMap[-9217430888823764461L].transform, false);
        goMap[3284408726362578336L].transform.SetParent(goMap[6166266839081062010L].transform, false);
        goMap[-1920700934492219182L].transform.SetParent(goMap[3284408726362578336L].transform, false);
        goMap[-606462473901103705L].transform.SetParent(goMap[-1920700934492219182L].transform, false);
        goMap[1674010639532602410L].transform.SetParent(goMap[-606462473901103705L].transform, false);
        goMap[-2616475104034453091L].transform.SetParent(goMap[-606462473901103705L].transform, false);
        goMap[-154035390679449346L].transform.SetParent(goMap[-606462473901103705L].transform, false);
        goMap[157346044455286694L].transform.SetParent(goMap[-606462473901103705L].transform, false);
        goMap[5665887286197770712L].transform.SetParent(goMap[-606462473901103705L].transform, false);
        goMap[9177013899863594447L].transform.SetParent(goMap[-606462473901103705L].transform, false);
        goMap[-8186146084440968213L].transform.SetParent(goMap[-606462473901103705L].transform, false);
        goMap[-6545260575577152827L].transform.SetParent(goMap[-606462473901103705L].transform, false);
        goMap[-5860302910169947282L].transform.SetParent(goMap[-606462473901103705L].transform, false);
        goMap[3392784441983655832L].transform.SetParent(goMap[-606462473901103705L].transform, false);
        goMap[-3339643156055365005L].transform.SetParent(goMap[-606462473901103705L].transform, false);
        goMap[3105800876152136872L].transform.SetParent(goMap[-606462473901103705L].transform, false);
        goMap[-480078052957716253L].transform.SetParent(goMap[-606462473901103705L].transform, false);
        goMap[8180575456575446535L].transform.SetParent(goMap[-606462473901103705L].transform, false);
        goMap[-8417391995465598444L].transform.SetParent(goMap[-606462473901103705L].transform, false);
        goMap[-7481285484520842710L].transform.SetParent(goMap[-606462473901103705L].transform, false);
        goMap[-6952801823313711828L].transform.SetParent(goMap[-606462473901103705L].transform, false);
        goMap[-5476677552050059282L].transform.SetParent(goMap[-606462473901103705L].transform, false);
        goMap[6578655124971333016L].transform.SetParent(goMap[-606462473901103705L].transform, false);
        goMap[-580496876053682101L].transform.SetParent(goMap[-606462473901103705L].transform, false);
        goMap[8464994661215136217L].transform.SetParent(goMap[-606462473901103705L].transform, false);
        goMap[-1411731018504975962L].transform.SetParent(goMap[8464994661215136217L].transform, false);
        goMap[-7445684838684633943L].transform.SetParent(goMap[-606462473901103705L].transform, false);
        goMap[-1512018235322137647L].transform.SetParent(goMap[-7445684838684633943L].transform, false);
        goMap[7909964995268025563L].transform.SetParent(goMap[-606462473901103705L].transform, false);
        goMap[1989433618379583866L].transform.SetParent(goMap[7909964995268025563L].transform, false);
        goMap[1343647390472623416L].transform.SetParent(goMap[-606462473901103705L].transform, false);
        goMap[8034926912724126588L].transform.SetParent(goMap[-606462473901103705L].transform, false);
        goMap[4631999038428074561L].transform.SetParent(goMap[-606462473901103705L].transform, false);
        goMap[-3101962188092499811L].transform.SetParent(goMap[-606462473901103705L].transform, false);
        goMap[-2233881748403807839L].transform.SetParent(goMap[-3101962188092499811L].transform, false);
        goMap[8471964405290936962L].transform.SetParent(goMap[-3101962188092499811L].transform, false);
        goMap[-8562907073154870310L].transform.SetParent(goMap[-1920700934492219182L].transform, false);
        goMap[-167312839772152562L].transform.SetParent(goMap[-8562907073154870310L].transform, false);
        goMap[-4818096439885577900L].transform.SetParent(goMap[-8562907073154870310L].transform, false);
        goMap[-2482630891036412831L].transform.SetParent(goMap[-8562907073154870310L].transform, false);
        goMap[677958139419310109L].transform.SetParent(goMap[-8562907073154870310L].transform, false);
        goMap[-4645795891747450289L].transform.SetParent(goMap[-8562907073154870310L].transform, false);
        goMap[6331862153999187726L].transform.SetParent(goMap[-8562907073154870310L].transform, false);
        goMap[5391925274972610953L].transform.SetParent(goMap[6166266839081062010L].transform, false);
        goMap[4080714912660970804L].transform.SetParent(goMap[5391925274972610953L].transform, false);
        goMap[2197057476232284188L].transform.SetParent(goMap[6166266839081062010L].transform, false);
        goMap[9141388161657250472L].transform.SetParent(goMap[2197057476232284188L].transform, false);
        goMap[8894519374811070620L].transform.SetParent(goMap[6166266839081062010L].transform, false);
        goMap[6381329666311794939L].transform.SetParent(goMap[8894519374811070620L].transform, false);
        goMap[-511247928905992696L].transform.SetParent(goMap[8894519374811070620L].transform, false);
        goMap[-2013028261450389889L].transform.SetParent(goMap[2572576028241539523L].transform, false);
        goMap[-145426538223464941L].transform.SetParent(goMap[2572576028241539523L].transform, false);
        goMap[-4927199037385578396L].transform.SetParent(goMap[-145426538223464941L].transform, false);
        goMap[-2608663744267253450L].transform.SetParent(goMap[-145426538223464941L].transform, false);
        goMap[-8015272032082769853L].transform.SetParent(goMap[-2608663744267253450L].transform, false);
        goMap[4073307657643642584L].transform.SetParent(goMap[-2608663744267253450L].transform, false);
        goMap[-8849781194626718294L].transform.SetParent(goMap[-2608663744267253450L].transform, false);
        goMap[-4425289922153626673L].transform.SetParent(goMap[2572576028241539523L].transform, false);
        goMap[-7804004827307464682L].transform.SetParent(goMap[-4425289922153626673L].transform, false);
        goMap[-2691750266037885318L].transform.SetParent(goMap[-4425289922153626673L].transform, false);
        goMap[-3150599755772081261L].transform.SetParent(goMap[-2691750266037885318L].transform, false);
        goMap[1454951808346740893L].transform.SetParent(goMap[-2691750266037885318L].transform, false);
        goMap[2222770802667375361L].transform.SetParent(goMap[-2691750266037885318L].transform, false);
        goMap[-5045912005471250823L].transform.SetParent(goMap[2572576028241539523L].transform, false);
        goMap[-2180129947520023521L].transform.SetParent(goMap[-5045912005471250823L].transform, false);
        goMap[6829282181419118315L].transform.SetParent(goMap[2572576028241539523L].transform, false);
        goMap[2839894111397384567L].transform.SetParent(goMap[6829282181419118315L].transform, false);
        goMap[-5069956051199359346L].transform.SetParent(goMap[6829282181419118315L].transform, false);
        goMap[1540995808043783220L].transform.SetParent(goMap[2572576028241539523L].transform, false);
        goMap[8247149811443190479L].transform.SetParent(goMap[1540995808043783220L].transform, false);
        goMap[1576721876117323314L].transform.SetParent(goMap[1540995808043783220L].transform, false);
        goMap[5052498857261964566L].transform.SetParent(goMap[2572576028241539523L].transform, false);
        goMap[1240749494308421572L].transform.SetParent(goMap[2572576028241539523L].transform, false);
        goMap[1770603109409228166L].transform.SetParent(goMap[2572576028241539523L].transform, false);
        goMap[-5195305283161794375L].transform.SetParent(goMap[1770603109409228166L].transform, false);
        goMap[-1329124656480310496L].transform.SetParent(goMap[-5195305283161794375L].transform, false);
        goMap[-8631799862734846532L].transform.SetParent(goMap[-5195305283161794375L].transform, false);
        goMap[6458407402086600384L].transform.SetParent(goMap[-5195305283161794375L].transform, false);
        goMap[-541715995506283716L].transform.SetParent(goMap[1770603109409228166L].transform, false);
        goMap[-2315859791270438532L].transform.SetParent(goMap[-541715995506283716L].transform, false);
        goMap[-5458798972353439190L].transform.SetParent(goMap[-541715995506283716L].transform, false);
        goMap[2064748088468298363L].transform.SetParent(goMap[-541715995506283716L].transform, false);
        goMap[-6151454567917345726L].transform.SetParent(goMap[-541715995506283716L].transform, false);
        goMap[-3669359067182095370L].transform.SetParent(goMap[-541715995506283716L].transform, false);
        goMap[4498134444510147942L].transform.SetParent(goMap[1770603109409228166L].transform, false);
        goMap[3995307805896169679L].transform.SetParent(goMap[4498134444510147942L].transform, false);
        goMap[-3353023652095368717L].transform.SetParent(goMap[4498134444510147942L].transform, false);

        // ─── RectTransforms ──────────────────────────────────
        {
            var rt = goMap[1321410803127715779L].AddComponent<RectTransform>();
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
            var rt = goMap[-4475763450260894290L].AddComponent<RectTransform>();
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
            var rt = goMap[2572576028241539523L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(12.500000f, 0.000011f);
            rt.sizeDelta = new Vector2(1176.000000f, 530.000000f);
        }
        {
            var rt = goMap[6536010333649535919L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(1176.000000f, 602.000000f);
        }
        {
            var rt = goMap[1168599770791567581L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-317.779999f, -50.000000f);
            rt.sizeDelta = new Vector2(359.869995f, 91.830002f);
        }
        {
            var rt = goMap[5915213288415998409L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-16.000000f, -62.000000f);
            rt.sizeDelta = new Vector2(367.350006f, 136.000000f);
        }
        {
            var rt = goMap[-2423226350155961936L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(0.800000f, 0.780000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(172.500000f, -25.000000f);
            rt.sizeDelta = new Vector2(49.000000f, 54.000000f);
        }
        {
            var rt = goMap[-3771475206394412550L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(526.000000f, 252.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 100.000000f);
        }
        {
            var rt = goMap[-1356600728976258236L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(636.200623f, 268.200012f);
            rt.sizeDelta = new Vector2(434.000000f, 104.000000f);
        }
        {
            var rt = goMap[-7102878991040179537L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(-7.160000f, -5.450000f);
            rt.anchoredPosition = new Vector2(-27.199890f, -204.399963f);
            rt.sizeDelta = new Vector2(30.000000f, 28.000000f);
        }
        {
            var rt = goMap[-6092665898879814145L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(-2.620000f, -8.080000f);
            rt.anchoredPosition = new Vector2(-27.739929f, -204.480026f);
            rt.sizeDelta = new Vector2(37.000000f, 26.000000f);
        }
        {
            var rt = goMap[8382098440814576249L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.330000f, -8.890000f);
            rt.anchoredPosition = new Vector2(-27.329956f, -204.840027f);
            rt.sizeDelta = new Vector2(39.000000f, 26.000000f);
        }
        {
            var rt = goMap[-4969121518950598026L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-125.999939f, 32.300049f);
            rt.sizeDelta = new Vector2(30.000000f, 21.000000f);
        }
        {
            var rt = goMap[1665404158550851300L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-199.100098f, 28.700134f);
            rt.sizeDelta = new Vector2(30.000000f, 21.000000f);
        }
        {
            var rt = goMap[-7718291630482966345L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(189.599960f, 246.100052f);
            rt.sizeDelta = new Vector2(722.000000f, 134.000000f);
        }
        {
            var rt = goMap[2355295972845170895L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 154.000000f);
        }
        {
            var rt = goMap[226982818304612635L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 247.460007f);
        }
        {
            var rt = goMap[8423277232439030286L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-189.080048f, 9.200027f);
            rt.sizeDelta = new Vector2(323.734589f, 70.000000f);
        }
        {
            var rt = goMap[-8537370499335179440L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 70.000000f);
        }
        {
            var rt = goMap[-5869193051230139926L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 70.000000f);
        }
        {
            var rt = goMap[7920135591107202104L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(1.000000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(56.000000f, 70.000000f);
        }
        {
            var rt = goMap[-1150194513662533951L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(240.000000f, 48.000000f);
        }
        {
            var rt = goMap[8569158337503720313L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.000000f);
            rt.anchorMax = new Vector2(0.500000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(9.500000f, 16.400000f);
            rt.sizeDelta = new Vector2(125.000000f, 10.000000f);
        }
        {
            var rt = goMap[6852839294160685235L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(141.309662f, -166.529999f);
            rt.sizeDelta = new Vector2(172.957703f, 0.000000f);
        }
        {
            var rt = goMap[-3691624246304036139L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(1.000000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.028992f, 0.000000f);
            rt.sizeDelta = new Vector2(98.000000f, 70.000000f);
        }
        {
            var rt = goMap[6134199968575987111L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 48.000000f);
        }
        {
            var rt = goMap[8606697786652477271L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.000000f);
            rt.anchorMax = new Vector2(0.500000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(9.500000f, 5.000000f);
            rt.sizeDelta = new Vector2(125.000000f, 10.000000f);
        }
        {
            var rt = goMap[5660286852075153158L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(266.299988f, -25.000000f);
            rt.sizeDelta = new Vector2(184.996994f, 50.000000f);
        }
        {
            var rt = goMap[-2872861530809471962L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(546.000000f, 242.800003f);
            rt.sizeDelta = new Vector2(44.000000f, 44.000000f);
        }
        {
            var rt = goMap[-3133543065130051425L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-327.200012f, -169.000000f);
            rt.sizeDelta = new Vector2(377.000000f, 89.000000f);
        }
        {
            var rt = goMap[-7148334611980088207L].AddComponent<RectTransform>();
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
            var rt = goMap[-5206377813666562807L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(85.000000f, 65.800003f);
            rt.sizeDelta = new Vector2(169.809998f, 52.000000f);
        }
        {
            var rt = goMap[3408193820020575747L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(191.419998f, 65.699997f);
            rt.sizeDelta = new Vector2(53.945000f, 52.000000f);
        }
        {
            var rt = goMap[6730735762649359727L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(297.700012f, 66.250000f);
            rt.sizeDelta = new Vector2(158.610001f, 62.000000f);
        }
        {
            var rt = goMap[-8701214946144103844L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(65.900002f, 22.900000f);
            rt.sizeDelta = new Vector2(167.741943f, 52.000000f);
        }
        {
            var rt = goMap[3687376010923071706L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(202.199997f, 24.000000f);
            rt.sizeDelta = new Vector2(126.000000f, 56.000000f);
        }
        {
            var rt = goMap[-163767145814242919L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(281.290009f, 24.200001f);
            rt.sizeDelta = new Vector2(31.969999f, 68.000000f);
        }
        {
            var rt = goMap[5451380854890503713L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(334.299988f, 26.700001f);
            rt.sizeDelta = new Vector2(74.054001f, 56.000000f);
        }
        {
            var rt = goMap[-158520689025684457L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-361.200012f, 33.900002f);
            rt.sizeDelta = new Vector2(455.000000f, 520.000000f);
        }
        {
            var rt = goMap[-8316399448745976762L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000080f, 1.000080f, 1.000080f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-162.000000f, -92.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[5381486470052326892L].AddComponent<RectTransform>();
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
            var rt = goMap[-6143546635696330925L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,1.000000f,-0.000000f,0.000000f);
            rt.localScale = new Vector3(56.461750f, 56.461750f, 56.461750f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-122.000000f, 42.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[7834268823755365442L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 9.599635f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(3.704672f, 6.880105f, 8.467822f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-165.000000f, 180.000000f);
            rt.sizeDelta = new Vector2(200.000000f, 100.000000f);
        }
        {
            var rt = goMap[-5325567076862510331L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(0.420615f, 0.420615f, 0.420615f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-133.000000f, 37.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-8272830783927924514L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.019700f,-0.168011f,0.282787f,0.944148f);
            rt.localScale = new Vector3(1.291700f, 1.291700f, 1.291700f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-122.888252f, 85.827293f);
            rt.sizeDelta = new Vector2(261.000000f, 942.000000f);
        }
        {
            var rt = goMap[-2162192462650943823L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(261.000000f, 942.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-4872483459793361276L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(261.000000f, 942.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-1589447510142178161L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, -5.400000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(762.000000f, 1339.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(15.000000f, -2.600000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[205490616832049589L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(261.000000f, 942.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.600000f, 1.600000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[4444512812581816258L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-41.599998f, 179.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[5726838260357644547L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.168058f,0.029187f,-0.842144f,0.511565f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-236.958130f, -125.237297f);
            rt.sizeDelta = new Vector2(405.000000f, 746.000000f);
        }
        {
            var rt = goMap[-496810956130788281L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(600.000000f, 1004.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(3.400000f, -12.700000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[4865698246810517461L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(405.000000f, 746.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[3305696332088883623L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(600.000000f, 1004.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(5.000000f, -9.600000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[7527110540882356465L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(405.000000f, 702.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-2.100000f, -16.900000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[8285414295179342323L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.086197f,-0.017580f,-0.996115f,-0.004081f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(205.939041f, 127.253975f);
            rt.sizeDelta = new Vector2(576.000000f, 1024.000000f);
        }
        {
            var rt = goMap[3848780946485745738L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(600.000000f, 1193.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(23.000000f, 3.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-1125618174966734818L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(576.000000f, 1024.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-8969339245663597592L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(600.000000f, 1193.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(16.000000f, 6.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-5340770857382424653L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(323.000000f, 926.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(10.600000f, -6.200000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-5249955380496700413L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(201.025650f, -25.900000f);
            rt.sizeDelta = new Vector2(624.178101f, 293.161804f);
        }
        {
            var rt = goMap[8458511950136368566L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(202.000000f, 284.000000f);
        }
        {
            var rt = goMap[6166266839081062010L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(202.000000f, 284.000000f);
        }
        {
            var rt = goMap[8633548862401045888L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(202.000000f, 284.000000f);
        }
        {
            var rt = goMap[-5517155818417356435L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(202.000000f, 294.000000f);
        }
        {
            var rt = goMap[8525455570753384539L].AddComponent<RectTransform>();
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
            var rt = goMap[-4901590356594771980L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(203.000000f, 294.000000f);
        }
        {
            var rt = goMap[1848139379315763173L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(203.000000f, 294.000000f);
        }
        {
            var rt = goMap[-3386218283498141340L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,0.704391f,0.709813f,0.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[9086048200956773168L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(134.500000f, -15.000000f);
            rt.sizeDelta = new Vector2(269.000000f, 32.000000f);
        }
        {
            var rt = goMap[8957688514453894388L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 98.699997f);
            rt.sizeDelta = new Vector2(78.000000f, 37.000000f);
        }
        {
            var rt = goMap[-9217430888823764461L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-93.144089f, 83.699997f);
            rt.sizeDelta = new Vector2(186.050003f, 36.000000f);
        }
        {
            var rt = goMap[29103368127581385L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(50.025002f, -18.000000f);
            rt.sizeDelta = new Vector2(54.000000f, 36.000000f);
        }
        {
            var rt = goMap[5848656180802262335L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(98.025002f, -18.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 30.000000f);
        }
        {
            var rt = goMap[-7550828500886512059L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(141.024994f, -18.000000f);
            rt.sizeDelta = new Vector2(44.000000f, 36.000000f);
        }
        {
            var rt = goMap[3284408726362578336L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(9.860000f, -71.930000f);
            rt.sizeDelta = new Vector2(186.050003f, 235.400497f);
        }
        {
            var rt = goMap[-1920700934492219182L].AddComponent<RectTransform>();
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
            var rt = goMap[-606462473901103705L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(0.800000f, 0.800000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 1.799999f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[1674010639532602410L].AddComponent<RectTransform>();
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
            var rt = goMap[-2616475104034453091L].AddComponent<RectTransform>();
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
            var rt = goMap[-154035390679449346L].AddComponent<RectTransform>();
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
            var rt = goMap[157346044455286694L].AddComponent<RectTransform>();
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
            var rt = goMap[5665887286197770712L].AddComponent<RectTransform>();
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
            var rt = goMap[9177013899863594447L].AddComponent<RectTransform>();
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
            var rt = goMap[-8186146084440968213L].AddComponent<RectTransform>();
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
            var rt = goMap[-6545260575577152827L].AddComponent<RectTransform>();
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
            var rt = goMap[-5860302910169947282L].AddComponent<RectTransform>();
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
            var rt = goMap[3392784441983655832L].AddComponent<RectTransform>();
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
            var rt = goMap[-3339643156055365005L].AddComponent<RectTransform>();
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
            var rt = goMap[3105800876152136872L].AddComponent<RectTransform>();
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
            var rt = goMap[-480078052957716253L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.000000f, 1.000000f);
            rt.anchoredPosition = new Vector2(2.000000f, 1.699997f);
            rt.sizeDelta = new Vector2(73.599998f, 30.000000f);
        }
        {
            var rt = goMap[8180575456575446535L].AddComponent<RectTransform>();
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
            var rt = goMap[-8417391995465598444L].AddComponent<RectTransform>();
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
            var rt = goMap[-7481285484520842710L].AddComponent<RectTransform>();
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
            var rt = goMap[-6952801823313711828L].AddComponent<RectTransform>();
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
            var rt = goMap[-5476677552050059282L].AddComponent<RectTransform>();
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
            var rt = goMap[6578655124971333016L].AddComponent<RectTransform>();
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
            var rt = goMap[-580496876053682101L].AddComponent<RectTransform>();
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
            var rt = goMap[8464994661215136217L].AddComponent<RectTransform>();
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
            var rt = goMap[-1411731018504975962L].AddComponent<RectTransform>();
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
            var rt = goMap[-7445684838684633943L].AddComponent<RectTransform>();
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
            var rt = goMap[-1512018235322137647L].AddComponent<RectTransform>();
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
            var rt = goMap[7909964995268025563L].AddComponent<RectTransform>();
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
            var rt = goMap[1989433618379583866L].AddComponent<RectTransform>();
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
            var rt = goMap[1343647390472623416L].AddComponent<RectTransform>();
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
            var rt = goMap[8034926912724126588L].AddComponent<RectTransform>();
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
            var rt = goMap[4631999038428074561L].AddComponent<RectTransform>();
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
            var rt = goMap[-3101962188092499811L].AddComponent<RectTransform>();
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
            var rt = goMap[-2233881748403807839L].AddComponent<RectTransform>();
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
            var rt = goMap[8471964405290936962L].AddComponent<RectTransform>();
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
            var rt = goMap[-8562907073154870310L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(0.779760f, 0.779760f, 0.779760f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.312764f, 3.231932f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-167312839772152562L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(99.188644f, 99.188644f, 99.188660f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-4818096439885577900L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.707107f,-0.000000f,-0.000000f,0.707107f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 8.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-2482630891036412831L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 3.900000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[677958139419310109L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(97.511688f, 97.511688f, 97.511688f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-4645795891747450289L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,1.000000f,-0.000000f,0.000000f);
            rt.localScale = new Vector3(58.946796f, 58.946796f, 81.870544f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[6331862153999187726L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(128.121979f, 128.121979f, 177.947189f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[5391925274972610953L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(187.000000f, -11.000000f);
            rt.sizeDelta = new Vector2(115.000000f, 52.000000f);
        }
        {
            var rt = goMap[4080714912660970804L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 2.000000f);
            rt.sizeDelta = new Vector2(90.900002f, 35.900002f);
        }
        {
            var rt = goMap[2197057476232284188L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(187.000000f, -9.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 42.000000f);
        }
        {
            var rt = goMap[9141388161657250472L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 42.000000f);
        }
        {
            var rt = goMap[8894519374811070620L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(72.800003f, 116.900002f);
            rt.sizeDelta = new Vector2(92.000000f, 92.000000f);
        }
        {
            var rt = goMap[6381329666311794939L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(0.700000f, 0.700000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000046f, -0.000061f);
            rt.sizeDelta = new Vector2(92.000000f, 92.000000f);
        }
        {
            var rt = goMap[-511247928905992696L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.104528f,0.994522f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 3.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 50.000000f);
        }
        {
            var rt = goMap[-2013028261450389889L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(201.000000f, -196.900009f);
            rt.sizeDelta = new Vector2(626.000000f, 100.000000f);
        }
        {
            var rt = goMap[-145426538223464941L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(409.829987f, -205.979996f);
            rt.sizeDelta = new Vector2(208.000000f, 67.000000f);
        }
        {
            var rt = goMap[-4927199037385578396L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 3.000000f);
            rt.sizeDelta = new Vector2(124.199997f, 40.000000f);
        }
        {
            var rt = goMap[-2608663744267253450L].AddComponent<RectTransform>();
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
            var rt = goMap[-8015272032082769853L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.960938f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.100000f, 2.300000f);
            rt.sizeDelta = new Vector2(216.000000f, 64.000000f);
        }
        {
            var rt = goMap[4073307657643642584L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.960938f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.100000f, 2.300000f);
            rt.sizeDelta = new Vector2(216.000000f, 64.000000f);
        }
        {
            var rt = goMap[-8849781194626718294L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.960938f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-1.700000f, 2.200000f);
            rt.sizeDelta = new Vector2(216.000000f, 64.000000f);
        }
        {
            var rt = goMap[-4425289922153626673L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(409.299988f, -205.979996f);
            rt.sizeDelta = new Vector2(208.000000f, 67.000000f);
        }
        {
            var rt = goMap[-7804004827307464682L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 3.000000f);
            rt.sizeDelta = new Vector2(124.199997f, 40.000000f);
        }
        {
            var rt = goMap[-2691750266037885318L].AddComponent<RectTransform>();
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
            var rt = goMap[-3150599755772081261L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.960938f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.100000f, 2.300000f);
            rt.sizeDelta = new Vector2(216.000000f, 64.000000f);
        }
        {
            var rt = goMap[1454951808346740893L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.960938f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.100000f, 2.300000f);
            rt.sizeDelta = new Vector2(216.000000f, 64.000000f);
        }
        {
            var rt = goMap[2222770802667375361L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.960938f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-1.700000f, 2.200000f);
            rt.sizeDelta = new Vector2(216.000000f, 64.000000f);
        }
        {
            var rt = goMap[-5045912005471250823L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(1.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(482.100006f, -205.979996f);
            rt.sizeDelta = new Vector2(0.000000f, 42.000000f);
        }
        {
            var rt = goMap[-2180129947520023521L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 42.000000f);
        }
        {
            var rt = goMap[6829282181419118315L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-1.000000f,-0.000000f,-0.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-206.600006f, -197.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[2839894111397384567L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(570.299988f, 6.300000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-5069956051199359346L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(679.599976f, -75.199997f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[5052498857261964566L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -330.000000f);
            rt.sizeDelta = new Vector2(800.000000f, 40.000000f);
        }
        {
            var rt = goMap[1240749494308421572L].AddComponent<RectTransform>();
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
            var rt = goMap[1770603109409228166L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-100.099998f, -208.700027f);
            rt.sizeDelta = new Vector2(0.000000f, 81.789200f);
        }
        {
            var rt = goMap[-5195305283161794375L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 100.000000f);
        }
        {
            var rt = goMap[-1329124656480310496L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(1.000000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-5.458804f, 0.000000f);
            rt.sizeDelta = new Vector2(37.839001f, 70.000000f);
        }
        {
            var rt = goMap[-8631799862734846532L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 100.000000f);
        }
        {
            var rt = goMap[6458407402086600384L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.000000f);
            rt.anchorMax = new Vector2(0.500000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 31.200001f);
            rt.sizeDelta = new Vector2(125.000000f, 10.000000f);
        }
        {
            var rt = goMap[-541715995506283716L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 88.000000f);
        }
        {
            var rt = goMap[-2315859791270438532L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 42.000000f);
        }
        {
            var rt = goMap[-5458798972353439190L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 42.000000f);
        }
        {
            var rt = goMap[2064748088468298363L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 42.000000f);
        }
        {
            var rt = goMap[-6151454567917345726L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 42.000000f);
        }
        {
            var rt = goMap[-3669359067182095370L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 42.000000f);
        }
        {
            var rt = goMap[4498134444510147942L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 100.000000f);
        }
        {
            var rt = goMap[3995307805896169679L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(1.000000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000008f, 0.000000f);
            rt.sizeDelta = new Vector2(9.982100f, 70.000000f);
        }
        {
            var rt = goMap[-3353023652095368717L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 42.000000f);
        }

        // ─── Components ──────────────────────────────────────
        { var c = goMap[1321410803127715779L].AddComponent<Canvas>();
           c.renderMode = (RenderMode)1;
           c.overrideSorting = false;
           c.sortingOrder = 0;
           c.sortingLayerID = unchecked((int)194136777);
           c.planeDistance = 8.660000f;
           c.pixelPerfect = false;
           c.additionalShaderChannels = (AdditionalCanvasShaderChannels)0;
           c.enabled = true;
        }
        { var c = goMap[1321410803127715779L].AddComponent<CanvasScaler>();
           c.uiScaleMode = (CanvasScaler.ScaleMode)1;
           c.referenceResolution = new Vector2(1280.000000f, 720.000000f);
           c.screenMatchMode = (CanvasScaler.ScreenMatchMode)1;
           c.matchWidthOrHeight = 0.000000f;
           c.referencePixelsPerUnit = 100.000000f;
        }
        { var c = goMap[1321410803127715779L].AddComponent<GraphicRaycaster>();
           c.ignoreReversedGraphics = true;
        }
        { var c = goMap[1321410803127715779L].AddComponent<Image>();
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
        { var c = goMap[1321410803127715779L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("UIFirstRecharge"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[-4475763450260894290L].AddComponent<CanvasGroup>();
           c.alpha = 1.000000f;
           c.interactable = true;
           c.blocksRaycasts = true;
           c.ignoreParentGroups = false;
        }
        { var c = goMap[6536010333649535919L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_firstrecharge_bg");
        }
        { var c = goMap[1168599770791567581L].AddComponent<HorizontalLayoutGroup>();
           c.padding = new RectOffset(0,0,0,0);
           c.spacing = 12.000000f;
           c.childAlignment = (TextAnchor)3;
           c.childForceExpandWidth = false;
           c.childForceExpandHeight = false;
           c.childControlWidth = false;
           c.childControlHeight = false;
           c.reverseArrangement = false;
        }
        { var c = goMap[1168599770791567581L].AddComponent<CanvasGroup>();
           c.alpha = 1.000000f;
           c.interactable = true;
           c.blocksRaycasts = true;
           c.ignoreParentGroups = false;
        }
        { var c = goMap[5915213288415998409L].AddComponent<Text>();
           c.text = "7207";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 90;
           c.fontStyle = FontStyle.BoldAndItalic;
           c.alignment = TextAnchor.LowerLeft;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 80;
           c.resizeTextMaxSize = 90;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var g = goMap[5915213288415998409L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.984314f, 0.917647f, 0.631373f, 1.000000f); }
        { var c = goMap[5915213288415998409L].AddComponent<Outline>();
           c.effectColor = new Color(0.568627f, 0.117647f, 0.058824f, 1.000000f);
           c.effectDistance = new Vector2(2.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[5915213288415998409L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)2;
           c.verticalFit = (ContentSizeFitter.FitMode)0;
        }
        { var c = goMap[-2423226350155961936L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-2423226350155961936L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-2423226350155961936L].AddComponent<UIScalePulse>();
           c.upScale = 0.950000f; c.duration = 0.100000f; c.scaleUp = false;
           c.enabled = true;
        }
        { var c = goMap[-7102878991040179537L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("imgBird01");
        }
        { var c = goMap[-6092665898879814145L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("imgBird02");
        }
        { var c = goMap[8382098440814576249L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("imgBird03");
        }
        { var c = goMap[-4969121518950598026L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("imgBird04");
        }
        { var c = goMap[1665404158550851300L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("imgBird05");
        }
        { var c = goMap[-7718291630482966345L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_firstrecharge_txtbg2");
        }
        { var c = goMap[-7718291630482966345L].AddComponent<HorizontalLayoutGroup>();
           c.padding = new RectOffset(0,0,0,0);
           c.spacing = 0.000000f;
           c.childAlignment = (TextAnchor)3;
           c.childForceExpandWidth = false;
           c.childForceExpandHeight = false;
           c.childControlWidth = true;
           c.childControlHeight = false;
           c.reverseArrangement = false;
        }
        { var c = goMap[2355295972845170895L].AddComponent<Text>();
           c.text = "7207";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 115;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleLeft;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 12;
           c.resizeTextMaxSize = 115;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var g = goMap[2355295972845170895L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.992157f, 0.984314f, 0.807843f, 1.000000f); }
        { var c = goMap[2355295972845170895L].AddComponent<Outline>();
           c.effectColor = new Color(0.572549f, 0.105882f, 0.105882f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[2355295972845170895L].AddComponent<Outline>();
           c.effectColor = new Color(0.572549f, 0.105882f, 0.105882f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[2355295972845170895L].AddComponent<Shadow>();
           c.effectColor = new Color(0.572549f, 0.105882f, 0.105882f, 1.000000f);
           c.effectDistance = new Vector2(0.000000f, -2.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[2355295972845170895L].AddComponent<LayoutElement>();
           c.minWidth = 246.000000f;
           c.minHeight = -1.000000f;
           c.preferredWidth = -1.000000f;
           c.preferredHeight = 300.000000f;
        }
        { var c = goMap[226982818304612635L].AddComponent<LayoutElement>();
           c.minWidth = 413.000000f;
           c.minHeight = -1.000000f;
           c.preferredWidth = 413.000000f;
           c.preferredHeight = -1.000000f;
        }
        { var c = goMap[8423277232439030286L].AddComponent<HorizontalLayoutGroup>();
           c.padding = new RectOffset(0,0,0,0);
           c.spacing = 4.000000f;
           c.childAlignment = (TextAnchor)0;
           c.childForceExpandWidth = false;
           c.childForceExpandHeight = false;
           c.childControlWidth = true;
           c.childControlHeight = false;
           c.reverseArrangement = false;
        }
        { var c = goMap[-8537370499335179440L].AddComponent<Text>();
           c.text = "8037";
           c.color = new Color(1.000000f, 0.937255f, 0.423529f, 1.000000f);
           c.fontSize = 42;
           c.fontStyle = FontStyle.BoldAndItalic;
           c.alignment = TextAnchor.MiddleLeft;
           c.alignByGeometry = false;
           c.supportRichText = false;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 12;
           c.resizeTextMaxSize = 48;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-8537370499335179440L].AddComponent<Outline>();
           c.effectColor = new Color(0.572549f, 0.105882f, 0.105882f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-8537370499335179440L].AddComponent<Outline>();
           c.effectColor = new Color(0.572549f, 0.105882f, 0.105882f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-8537370499335179440L].AddComponent<Shadow>();
           c.effectColor = new Color(0.572549f, 0.082353f, 0.039216f, 1.000000f);
           c.effectDistance = new Vector2(0.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-5869193051230139926L].AddComponent<HorizontalLayoutGroup>();
           c.padding = new RectOffset(0,0,0,0);
           c.spacing = 0.000000f;
           c.childAlignment = (TextAnchor)4;
           c.childForceExpandWidth = false;
           c.childForceExpandHeight = false;
           c.childControlWidth = false;
           c.childControlHeight = false;
           c.reverseArrangement = false;
        }
        { var c = goMap[-5869193051230139926L].AddComponent<LayoutElement>();
           c.minWidth = 172.000000f;
           c.minHeight = -1.000000f;
           c.preferredWidth = 172.000000f;
           c.preferredHeight = -1.000000f;
        }
        { var c = goMap[7920135591107202104L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_firstrecharge_txtLight2");
        }
        { var c = goMap[7920135591107202104L].AddComponent<LayoutElement>();
           c.minWidth = 241.000000f;
           c.minHeight = -1.000000f;
           c.preferredWidth = -1.000000f;
           c.preferredHeight = -1.000000f;
        }
        { var c = goMap[-1150194513662533951L].AddComponent<Text>();
           c.text = "26233";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 38;
           c.fontStyle = FontStyle.BoldAndItalic;
           c.alignment = TextAnchor.MiddleLeft;
           c.alignByGeometry = false;
           c.supportRichText = false;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 12;
           c.resizeTextMaxSize = 38;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var g = goMap[-1150194513662533951L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(1.000000f, 1.000000f, 0.741176f, 1.000000f); }
        { var c = goMap[-1150194513662533951L].AddComponent<Outline>();
           c.effectColor = new Color(0.572549f, 0.105882f, 0.105882f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-1150194513662533951L].AddComponent<Outline>();
           c.effectColor = new Color(0.572549f, 0.105882f, 0.105882f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-1150194513662533951L].AddComponent<Shadow>();
           c.effectColor = new Color(0.572549f, 0.082353f, 0.039216f, 1.000000f);
           c.effectDistance = new Vector2(0.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[8569158337503720313L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_firstrecharge_txtLight");
        }
        { var c = goMap[8569158337503720313L].AddComponent<LayoutElement>();
           c.minWidth = -1.000000f;
           c.minHeight = -1.000000f;
           c.preferredWidth = -1.000000f;
           c.preferredHeight = -1.000000f;
        }
        { var c = goMap[6852839294160685235L].AddComponent<HorizontalLayoutGroup>();
           c.padding = new RectOffset(0,0,0,0);
           c.spacing = 0.000000f;
           c.childAlignment = (TextAnchor)4;
           c.childForceExpandWidth = false;
           c.childForceExpandHeight = false;
           c.childControlWidth = true;
           c.childControlHeight = false;
           c.reverseArrangement = false;
        }
        { var c = goMap[6852839294160685235L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)0;
           c.verticalFit = (ContentSizeFitter.FitMode)2;
        }
        { var c = goMap[-3691624246304036139L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_firstrecharge_txtLight2");
        }
        { var c = goMap[-3691624246304036139L].AddComponent<LayoutElement>();
           c.minWidth = 241.000000f;
           c.minHeight = -1.000000f;
           c.preferredWidth = -1.000000f;
           c.preferredHeight = -1.000000f;
        }
        { var c = goMap[6134199968575987111L].AddComponent<Text>();
           c.text = "30660";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 38;
           c.fontStyle = FontStyle.BoldAndItalic;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = false;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 12;
           c.resizeTextMaxSize = 38;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var g = goMap[6134199968575987111L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(1.000000f, 1.000000f, 0.741176f, 1.000000f); }
        { var c = goMap[6134199968575987111L].AddComponent<Outline>();
           c.effectColor = new Color(0.572549f, 0.105882f, 0.105882f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[6134199968575987111L].AddComponent<Outline>();
           c.effectColor = new Color(0.572549f, 0.105882f, 0.105882f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[6134199968575987111L].AddComponent<Shadow>();
           c.effectColor = new Color(0.572549f, 0.082353f, 0.039216f, 1.000000f);
           c.effectDistance = new Vector2(0.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[8606697786652477271L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_firstrecharge_txtLight");
        }
        { var c = goMap[8606697786652477271L].AddComponent<LayoutElement>();
           c.minWidth = -1.000000f;
           c.minHeight = -1.000000f;
           c.preferredWidth = -1.000000f;
           c.preferredHeight = -1.000000f;
        }
        { var c = goMap[5660286852075153158L].AddComponent<Text>();
           c.text = "30646";
           c.color = new Color(1.000000f, 0.937255f, 0.423529f, 1.000000f);
           c.fontSize = 22;
           c.fontStyle = FontStyle.BoldAndItalic;
           c.alignment = TextAnchor.MiddleLeft;
           c.alignByGeometry = false;
           c.supportRichText = false;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 12;
           c.resizeTextMaxSize = 22;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[5660286852075153158L].AddComponent<Shadow>();
           c.effectColor = new Color(0.400000f, 0.109804f, 0.109804f, 1.000000f);
           c.effectDistance = new Vector2(0.000000f, -3.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[5660286852075153158L].AddComponent<LayoutElement>();
           c.minWidth = -1.000000f;
           c.minHeight = -1.000000f;
           c.preferredWidth = -1.000000f;
           c.preferredHeight = -1.000000f;
        }
        { var c = goMap[-2872861530809471962L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-2872861530809471962L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-2872861530809471962L].AddComponent<UIScalePulse>();
           c.upScale = 0.950000f; c.duration = 0.100000f; c.scaleUp = false;
           c.enabled = true;
        }
        { var c = goMap[-3133543065130051425L].AddComponent<CanvasGroup>();
           c.alpha = 1.000000f;
           c.interactable = true;
           c.blocksRaycasts = true;
           c.ignoreParentGroups = false;
        }
        { var c = goMap[-7148334611980088207L].AddComponent<Image>();
           c.color = new Color(0.756863f, 0.168627f, 0.054902f, 0.490196f);
           c.raycastTarget = true;
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
        { var c = goMap[-5206377813666562807L].AddComponent<Text>();
           c.text = "10293";
           c.color = new Color(0.980392f, 0.949020f, 0.913726f, 1.000000f);
           c.fontSize = 35;
           c.fontStyle = FontStyle.BoldAndItalic;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 3;
           c.resizeTextMaxSize = 35;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[3408193820020575747L].AddComponent<Text>();
           c.text = "8037";
           c.color = new Color(0.980392f, 0.949020f, 0.913726f, 1.000000f);
           c.fontSize = 32;
           c.fontStyle = FontStyle.BoldAndItalic;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 20;
           c.resizeTextMaxSize = 32;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var g = goMap[3408193820020575747L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.984314f, 0.917647f, 0.631373f, 1.000000f); }
        { var c = goMap[3408193820020575747L].AddComponent<Outline>();
           c.effectColor = new Color(0.568627f, 0.117647f, 0.058824f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[6730735762649359727L].AddComponent<Text>();
           c.text = "18309";
           c.color = new Color(0.915094f, 0.568876f, 0.159710f, 1.000000f);
           c.fontSize = 38;
           c.fontStyle = FontStyle.BoldAndItalic;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 20;
           c.resizeTextMaxSize = 38;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var g = goMap[6730735762649359727L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.984314f, 0.917647f, 0.631373f, 1.000000f); }
        { var c = goMap[6730735762649359727L].AddComponent<Outline>();
           c.effectColor = new Color(0.568627f, 0.117647f, 0.058824f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-8701214946144103844L].AddComponent<Text>();
           c.text = "11152";
           c.color = new Color(0.980392f, 0.949020f, 0.913726f, 1.000000f);
           c.fontSize = 34;
           c.fontStyle = FontStyle.BoldAndItalic;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 20;
           c.resizeTextMaxSize = 34;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-8701214946144103844L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)2;
           c.verticalFit = (ContentSizeFitter.FitMode)0;
        }
        { var c = goMap[3687376010923071706L].AddComponent<Text>();
           c.text = "7308";
           c.color = new Color(0.980392f, 0.949020f, 0.913726f, 1.000000f);
           c.fontSize = 36;
           c.fontStyle = FontStyle.BoldAndItalic;
           c.alignment = TextAnchor.MiddleLeft;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 20;
           c.resizeTextMaxSize = 36;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-163767145814242919L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(0.980392f, 0.949020f, 0.913726f, 1.000000f);
           c.fontSize = 44;
           c.fontStyle = FontStyle.BoldAndItalic;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 20;
           c.resizeTextMaxSize = 44;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var g = goMap[-163767145814242919L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.984314f, 0.917647f, 0.631373f, 1.000000f); }
        { var c = goMap[-163767145814242919L].AddComponent<Outline>();
           c.effectColor = new Color(0.568627f, 0.117647f, 0.058824f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[5451380854890503713L].AddComponent<Text>();
           c.text = "4929";
           c.color = new Color(0.980392f, 0.949020f, 0.913726f, 1.000000f);
           c.fontSize = 38;
           c.fontStyle = FontStyle.BoldAndItalic;
           c.alignment = TextAnchor.MiddleLeft;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 20;
           c.resizeTextMaxSize = 38;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var g = goMap[5451380854890503713L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.984314f, 0.917647f, 0.631373f, 1.000000f); }
        { var c = goMap[5451380854890503713L].AddComponent<Outline>();
           c.effectColor = new Color(0.568627f, 0.117647f, 0.058824f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-158520689025684457L].AddComponent<Image>();
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
        { var c = goMap[-8316399448745976762L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("HuangJinWuQi"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[7834268823755365442L].AddComponent<Image>();
           c.color = new Color(0.772243f, 0.430609f, 0.142125f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-3980086089390010786L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("piaodai"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[-4706516036870666883L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("piaodai"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[-5249955380496700413L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)2;
           c.verticalFit = (ContentSizeFitter.FitMode)0;
        }
        { var c = goMap[-5249955380496700413L].AddComponent<HorizontalLayoutGroup>();
           c.padding = new RectOffset(0,0,0,0);
           c.spacing = 0.000000f;
           c.childAlignment = (TextAnchor)0;
           c.childForceExpandWidth = true;
           c.childForceExpandHeight = true;
           c.childControlWidth = false;
           c.childControlHeight = false;
           c.reverseArrangement = false;
        }
        { var c = goMap[8458511950136368566L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("DayTemplate"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[6166266839081062010L].AddComponent<CanvasGroup>();
           c.alpha = 1.000000f;
           c.interactable = true;
           c.blocksRaycasts = true;
           c.ignoreParentGroups = false;
        }
        { var c = goMap[8633548862401045888L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_firstrecharge_rewardbg");
        }
        { var c = goMap[-5517155818417356435L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_firstrecharge_rewardbgHL");
        }
        { var c = goMap[8525455570753384539L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("Effect2"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[-4901590356594771980L].AddComponent<Image>();
           c.color = new Color(1.000000f, 0.737255f, 0.286275f, 1.000000f);
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
        { var c = goMap[1848139379315763173L].AddComponent<Image>();
           c.color = new Color(1.000000f, 0.737255f, 0.286275f, 0.771067f);
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
        { var c = goMap[9086048200956773168L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_everyday_bg");
        }
        { var c = goMap[8957688514453894388L].AddComponent<Text>();
           c.text = "11935";
           c.color = new Color(0.552941f, 0.078431f, 0.086275f, 1.000000f);
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
           c.resizeTextMaxSize = 22;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-9217430888823764461L].AddComponent<HorizontalLayoutGroup>();
           c.padding = new RectOffset(0,0,0,0);
           c.spacing = 6.000000f;
           c.childAlignment = (TextAnchor)4;
           c.childForceExpandWidth = false;
           c.childForceExpandHeight = false;
           c.childControlWidth = true;
           c.childControlHeight = false;
           c.reverseArrangement = false;
        }
        { var c = goMap[-9217430888823764461L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)0;
           c.verticalFit = (ContentSizeFitter.FitMode)2;
        }
        { var c = goMap[29103368127581385L].AddComponent<Text>();
           c.text = "9660";
           c.color = new Color(0.552941f, 0.078431f, 0.086275f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleRight;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 1;
           c.resizeTextMaxSize = 20;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[5848656180802262335L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[5848656180802262335L].AddComponent<LayoutElement>();
           c.minWidth = -1.000000f;
           c.minHeight = -1.000000f;
           c.preferredWidth = 30.000000f;
           c.preferredHeight = -1.000000f;
        }
        { var c = goMap[-7550828500886512059L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(0.552941f, 0.078431f, 0.086275f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleLeft;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 1;
           c.resizeTextMaxSize = 20;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[3284408726362578336L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)0;
           c.verticalFit = (ContentSizeFitter.FitMode)2;
        }
        { var c = goMap[3284408726362578336L].AddComponent<GridLayoutGroup>();
           c.padding = new RectOffset(0,0,0,0);
           c.cellSize = new Vector2(80.000000f, 80.000000f);
           c.spacing = new Vector2(10.000000f, 10.000000f);
           c.childAlignment = (TextAnchor)0;
        }
        { var c = goMap[1674010639532602410L].AddComponent<Image>();
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
        { var c = goMap[-2616475104034453091L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-154035390679449346L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-154035390679449346L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[157346044455286694L].AddComponent<Image>();
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
        { var c = goMap[5665887286197770712L].AddComponent<Text>();
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
        { var c = goMap[5665887286197770712L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[9177013899863594447L].AddComponent<Text>();
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
        { var c = goMap[9177013899863594447L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-8186146084440968213L].AddComponent<Text>();
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
        { var c = goMap[-8186146084440968213L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-6545260575577152827L].AddComponent<Text>();
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
        { var c = goMap[-6545260575577152827L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-5860302910169947282L].AddComponent<Text>();
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
        { var c = goMap[-5860302910169947282L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[3392784441983655832L].AddComponent<Image>();
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
        { var c = goMap[-3339643156055365005L].AddComponent<Image>();
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
        { var c = goMap[3105800876152136872L].AddComponent<Image>();
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
        { var c = goMap[-480078052957716253L].AddComponent<Text>();
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
        { var c = goMap[-480078052957716253L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[8180575456575446535L].AddComponent<Image>();
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
        { var c = goMap[-8417391995465598444L].AddComponent<Image>();
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
        { var c = goMap[-7481285484520842710L].AddComponent<Image>();
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
        { var c = goMap[-6952801823313711828L].AddComponent<Image>();
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
        { var c = goMap[-5476677552050059282L].AddComponent<Image>();
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
        { var c = goMap[6578655124971333016L].AddComponent<Image>();
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
        { var c = goMap[8464994661215136217L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-1411731018504975962L].AddComponent<Text>();
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
        { var g = goMap[-1411731018504975962L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.866667f, 0.988235f, 0.933333f, 1.000000f); }
        { var c = goMap[-1411731018504975962L].AddComponent<Outline>();
           c.effectColor = new Color(0.227451f, 0.196078f, 0.078431f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-7445684838684633943L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-1512018235322137647L].AddComponent<Text>();
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
        { var g = goMap[-1512018235322137647L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.992157f, 0.886275f, 0.447059f, 1.000000f); }
        { var c = goMap[-1512018235322137647L].AddComponent<Outline>();
           c.effectColor = new Color(0.227451f, 0.196078f, 0.078431f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[7909964995268025563L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[1989433618379583866L].AddComponent<Text>();
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
        { var c = goMap[1989433618379583866L].AddComponent<Outline>();
           c.effectColor = new Color(0.286275f, 0.090196f, 0.031373f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[1343647390472623416L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[8034926912724126588L].AddComponent<Image>();
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
        { var c = goMap[4631999038428074561L].AddComponent<Text>();
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
        { var c = goMap[4631999038428074561L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-3101962188092499811L].AddComponent<Image>();
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
        { var c = goMap[-2233881748403807839L].AddComponent<Image>();
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
        { var c = goMap[-2233881748403807839L].AddComponent<Outline>();
           c.effectColor = new Color(0.584906f, 0.584906f, 0.584906f, 0.262745f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[8471964405290936962L].AddComponent<Image>();
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
        { var c = goMap[8471964405290936962L].AddComponent<Outline>();
           c.effectColor = new Color(0.584906f, 0.584906f, 0.584906f, 0.262745f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-8562907073154870310L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("Enhance_16"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[5391925274972610953L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[5391925274972610953L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[5391925274972610953L].AddComponent<CanvasGroup>();
           c.alpha = 1.000000f;
           c.interactable = true;
           c.blocksRaycasts = true;
           c.ignoreParentGroups = false;
        }
        { var c = goMap[4080714912660970804L].AddComponent<Text>();
           c.text = "领取";
           c.color = new Color(0.988235f, 0.937255f, 0.843137f, 1.000000f);
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
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[9141388161657250472L].AddComponent<Text>();
           c.text = "已领取";
           c.color = new Color(0.772549f, 0.019608f, 0.019608f, 1.000000f);
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
        { var c = goMap[6381329666311794939L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_equipped");
        }
        { var c = goMap[-511247928905992696L].AddComponent<Text>();
           c.text = "已领取";
           c.color = new Color(0.800000f, 0.149020f, 0.149020f, 1.000000f);
           c.fontSize = 16;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Overflow;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 1;
           c.resizeTextMaxSize = 40;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-2013028261450389889L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_firstrecharge_btnbg");
        }
        { var c = goMap[-145426538223464941L].AddComponent<Image>();
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
           c.sprite = LookupSprite("btn_common4_1");
        }
        { var c = goMap[-145426538223464941L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-145426538223464941L].AddComponent<CanvasGroup>();
           c.alpha = 1.000000f;
           c.interactable = true;
           c.blocksRaycasts = true;
           c.ignoreParentGroups = false;
        }
        { var c = goMap[-4927199037385578396L].AddComponent<Text>();
           c.text = "4203";
           c.color = new Color(0.992157f, 0.964706f, 0.960784f, 1.000000f);
           c.fontSize = 26;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 12;
           c.resizeTextMaxSize = 26;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-2608663744267253450L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("btnRecharge_Effect"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[-8015272032082769853L].AddComponent<Image>();
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
        { var c = goMap[4073307657643642584L].AddComponent<Image>();
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
        { var c = goMap[-8849781194626718294L].AddComponent<Image>();
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
        { var c = goMap[-4425289922153626673L].AddComponent<Image>();
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
           c.sprite = LookupSprite("btn_common4_1");
        }
        { var c = goMap[-4425289922153626673L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-4425289922153626673L].AddComponent<CanvasGroup>();
           c.alpha = 1.000000f;
           c.interactable = true;
           c.blocksRaycasts = true;
           c.ignoreParentGroups = false;
        }
        { var c = goMap[-7804004827307464682L].AddComponent<Text>();
           c.text = "4203";
           c.color = new Color(0.992157f, 0.964706f, 0.960784f, 1.000000f);
           c.fontSize = 26;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 12;
           c.resizeTextMaxSize = 26;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-2691750266037885318L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("btnRecharge_Effect"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[-3150599755772081261L].AddComponent<Image>();
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
        { var c = goMap[1454951808346740893L].AddComponent<Image>();
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
        { var c = goMap[2222770802667375361L].AddComponent<Image>();
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
        { var c = goMap[-5045912005471250823L].AddComponent<HorizontalLayoutGroup>();
           c.padding = new RectOffset(0,0,0,0);
           c.spacing = 0.000000f;
           c.childAlignment = (TextAnchor)5;
           c.childForceExpandWidth = false;
           c.childForceExpandHeight = false;
           c.childControlWidth = true;
           c.childControlHeight = false;
           c.reverseArrangement = false;
        }
        { var c = goMap[-5045912005471250823L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)2;
           c.verticalFit = (ContentSizeFitter.FitMode)0;
        }
        { var c = goMap[-2180129947520023521L].AddComponent<Text>();
           c.text = "26244";
           c.color = new Color(0.933962f, 0.839080f, 0.770959f, 1.000000f);
           c.fontSize = 22;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleRight;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 16;
           c.resizeTextMaxSize = 22;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-2180129947520023521L].AddComponent<Outline>();
           c.effectColor = new Color(0.733333f, 0.247059f, 0.160784f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-2180129947520023521L].AddComponent<LayoutElement>();
           c.minWidth = 200.000000f;
           c.minHeight = -1.000000f;
           c.preferredWidth = 300.000000f;
           c.preferredHeight = -1.000000f;
        }
        { var c = goMap[5052498857261964566L].AddComponent<Text>();
           c.text = "19021";
           c.color = new Color(0.098039f, 0.984314f, 0.121569f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.UpperCenter;
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
        { var c = goMap[1240749494308421572L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[1770603109409228166L].AddComponent<HorizontalLayoutGroup>();
           c.padding = new RectOffset(0,0,0,0);
           c.spacing = -11.950000f;
           c.childAlignment = (TextAnchor)3;
           c.childForceExpandWidth = false;
           c.childForceExpandHeight = false;
           c.childControlWidth = true;
           c.childControlHeight = false;
           c.reverseArrangement = false;
        }
        { var c = goMap[1770603109409228166L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)2;
           c.verticalFit = (ContentSizeFitter.FitMode)0;
        }
        { var c = goMap[-5195305283161794375L].AddComponent<HorizontalLayoutGroup>();
           c.padding = new RectOffset(0,0,0,0);
           c.spacing = 0.000000f;
           c.childAlignment = (TextAnchor)0;
           c.childForceExpandWidth = false;
           c.childForceExpandHeight = false;
           c.childControlWidth = true;
           c.childControlHeight = false;
           c.reverseArrangement = false;
        }
        { var c = goMap[-5195305283161794375L].AddComponent<LayoutElement>();
           c.minWidth = 92.800003f;
           c.minHeight = -1.000000f;
           c.preferredWidth = -1.000000f;
           c.preferredHeight = -1.000000f;
        }
        { var c = goMap[-1329124656480310496L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_firstrecharge_txtLight2");
        }
        { var c = goMap[-1329124656480310496L].AddComponent<LayoutElement>();
           c.minWidth = 241.000000f;
           c.minHeight = -1.000000f;
           c.preferredWidth = -1.000000f;
           c.preferredHeight = -1.000000f;
        }
        { var c = goMap[-8631799862734846532L].AddComponent<Text>();
           c.text = "30888";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 28;
           c.fontStyle = FontStyle.BoldAndItalic;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 24;
           c.resizeTextMaxSize = 28;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var g = goMap[-8631799862734846532L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(1.000000f, 1.000000f, 0.741176f, 1.000000f); }
        { var c = goMap[-8631799862734846532L].AddComponent<Outline>();
           c.effectColor = new Color(0.572549f, 0.105882f, 0.105882f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-8631799862734846532L].AddComponent<Outline>();
           c.effectColor = new Color(0.572549f, 0.105882f, 0.105882f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-8631799862734846532L].AddComponent<Shadow>();
           c.effectColor = new Color(0.572549f, 0.082353f, 0.039216f, 1.000000f);
           c.effectDistance = new Vector2(0.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-8631799862734846532L].AddComponent<LayoutElement>();
           c.minWidth = 92.000000f;
           c.minHeight = -1.000000f;
           c.preferredWidth = 160.000000f;
           c.preferredHeight = -1.000000f;
        }
        { var c = goMap[6458407402086600384L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_firstrecharge_txtLight");
        }
        { var c = goMap[6458407402086600384L].AddComponent<LayoutElement>();
           c.minWidth = -1.000000f;
           c.minHeight = -1.000000f;
           c.preferredWidth = -1.000000f;
           c.preferredHeight = -1.000000f;
        }
        { var c = goMap[-541715995506283716L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_firstrecharge_txtbg");
        }
        { var c = goMap[-541715995506283716L].AddComponent<LayoutElement>();
           c.minWidth = 198.000000f;
           c.minHeight = -1.000000f;
           c.preferredWidth = -1.000000f;
           c.preferredHeight = -1.000000f;
        }
        { var c = goMap[-541715995506283716L].AddComponent<HorizontalLayoutGroup>();
           c.padding = new RectOffset(0,0,0,0);
           c.spacing = 0.000000f;
           c.childAlignment = (TextAnchor)4;
           c.childForceExpandWidth = false;
           c.childForceExpandHeight = false;
           c.childControlWidth = true;
           c.childControlHeight = false;
           c.reverseArrangement = false;
        }
        { var c = goMap[-2315859791270438532L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_firstrecharge_txt6");
        }
        { var c = goMap[-5458798972353439190L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_firstrecharge_txt6");
        }
        { var c = goMap[2064748088468298363L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_firstrecharge_txt6");
        }
        { var c = goMap[-6151454567917345726L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_firstrecharge_txt6");
        }
        { var c = goMap[-3669359067182095370L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_firstrecharge_txt6");
        }
        { var c = goMap[4498134444510147942L].AddComponent<HorizontalLayoutGroup>();
           c.padding = new RectOffset(0,0,0,0);
           c.spacing = 0.000000f;
           c.childAlignment = (TextAnchor)3;
           c.childForceExpandWidth = false;
           c.childForceExpandHeight = false;
           c.childControlWidth = true;
           c.childControlHeight = false;
           c.reverseArrangement = false;
        }
        { var c = goMap[4498134444510147942L].AddComponent<LayoutElement>();
           c.minWidth = 33.099998f;
           c.minHeight = -1.000000f;
           c.preferredWidth = -1.000000f;
           c.preferredHeight = -1.000000f;
        }
        { var c = goMap[3995307805896169679L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_firstrecharge_txtLight2");
        }
        { var c = goMap[3995307805896169679L].AddComponent<LayoutElement>();
           c.minWidth = 241.000000f;
           c.minHeight = -1.000000f;
           c.preferredWidth = -1.000000f;
           c.preferredHeight = -1.000000f;
        }
        { var c = goMap[-3353023652095368717L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-3353023652095368717L].AddComponent<LayoutElement>();
           c.minWidth = 42.000000f;
           c.minHeight = 42.000000f;
           c.preferredWidth = 42.000000f;
           c.preferredHeight = 42.000000f;
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
        var rootGO = goMap[1321410803127715779L];
        string path = "Assets/Prefabs/Imported/UIFirstRecharge.prefab";
        PrefabUtility.SaveAsPrefabAsset(rootGO, path);
        Object.DestroyImmediate(rootGO);
        Debug.Log("[Import_res_p_263] Saved " + path);
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