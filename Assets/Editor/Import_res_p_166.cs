// AUTO-GENERATED from res_p_166.ab — DO NOT EDIT MANUALLY.
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;
using System.Collections.Generic;
using KTO.Game;  // UIJoyStick and other ported KTO scripts

public class Import_res_p_166
{
    [MenuItem("KTO/Import/res_p_166")]
    public static void Build()
    {
        Debug.Log("[Import_res_p_166] Building UIPartnerStarsUp...");

        // ─── Create all GameObjects ───────────────────────────
        var goMap = new Dictionary<long, GameObject>();
        var _toggleGroupByMbPid = new Dictionary<long, ToggleGroup>();
        var _toggleGroupLinks = new List<System.Tuple<Toggle,long>>();
        { var go = new GameObject("UIPartnerStarsUp"); go.SetActive(true); goMap[3234735537922300143L] = go; }
        { var go = new GameObject("node"); go.SetActive(true); goMap[3945388089780440666L] = go; }
        { var go = new GameObject("UIBg3_1"); go.SetActive(true); goMap[4055871074233093091L] = go; }
        { var go = new GameObject("panel"); go.SetActive(true); goMap[3299279500291616282L] = go; }
        { var go = new GameObject("imgShadow1"); go.SetActive(true); goMap[3938092759976508898L] = go; }
        { var go = new GameObject("imgShadow2"); go.SetActive(true); goMap[5446201502268030719L] = go; }
        { var go = new GameObject("imgShadow3"); go.SetActive(true); goMap[-7648232724668134389L] = go; }
        { var go = new GameObject("imgShadow4"); go.SetActive(true); goMap[-6195448894422624557L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(true); goMap[-1293367365699253638L] = go; }
        { var go = new GameObject("imgTitleBg1"); go.SetActive(true); goMap[5467965228140875103L] = go; }
        { var go = new GameObject("imgReflection"); go.SetActive(true); goMap[4247749607033715472L] = go; }
        { var go = new GameObject("imgBorderline1"); go.SetActive(true); goMap[2308658377850910961L] = go; }
        { var go = new GameObject("imgBorderline2"); go.SetActive(true); goMap[595231751789470271L] = go; }
        { var go = new GameObject("imgBorderline3"); go.SetActive(true); goMap[-704710079963207697L] = go; }
        { var go = new GameObject("imgBorderline4"); go.SetActive(true); goMap[-8776721450332639076L] = go; }
        { var go = new GameObject("imgListBg"); go.SetActive(false); goMap[-5065673131270198913L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(false); goMap[-3215921739427355339L] = go; }
        { var go = new GameObject("imgBG"); go.SetActive(true); goMap[2467822709940603548L] = go; }
        { var go = new GameObject("btnClose"); go.SetActive(true); goMap[5757726401891543646L] = go; }
        { var go = new GameObject("txtTitle"); go.SetActive(true); goMap[6816598455657616683L] = go; }
        { var go = new GameObject("Content"); go.SetActive(true); goMap[-7666222920952687518L] = go; }
        { var go = new GameObject("PreStar"); go.SetActive(true); goMap[4839675983278491765L] = go; }
        { var go = new GameObject("txtNow"); go.SetActive(true); goMap[5753481503304624134L] = go; }
        { var go = new GameObject("StarsList"); go.SetActive(true); goMap[-739316333397060947L] = go; }
        { var go = new GameObject("NoStar1"); go.SetActive(true); goMap[-1611104360110124102L] = go; }
        { var go = new GameObject("Star1"); go.SetActive(true); goMap[8357388933535953441L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[6819502722847958907L] = go; }
        { var go = new GameObject("Stars_Effect"); go.SetActive(false); goMap[-2170007839850768716L] = go; }
        { var go = new GameObject("Glow"); go.SetActive(true); goMap[-2949249071565123633L] = go; }
        { var go = new GameObject("Star"); go.SetActive(true); goMap[-6543210114668253055L] = go; }
        { var go = new GameObject("StarGlow"); go.SetActive(true); goMap[8870124854585655719L] = go; }
        { var go = new GameObject("Star02"); go.SetActive(true); goMap[7055951580439506138L] = go; }
        { var go = new GameObject("Star03"); go.SetActive(true); goMap[4739085761482707844L] = go; }
        { var go = new GameObject("GlowLight"); go.SetActive(true); goMap[-5192820362663614449L] = go; }
        { var go = new GameObject("NoStar2"); go.SetActive(true); goMap[-6426709608600509360L] = go; }
        { var go = new GameObject("Star2"); go.SetActive(true); goMap[5360859761328083824L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[-5154651572578956940L] = go; }
        { var go = new GameObject("Stars_Effect"); go.SetActive(false); goMap[-5196340154655026492L] = go; }
        { var go = new GameObject("Glow"); go.SetActive(true); goMap[3922656639683113239L] = go; }
        { var go = new GameObject("Star"); go.SetActive(true); goMap[3112382401901360813L] = go; }
        { var go = new GameObject("StarGlow"); go.SetActive(true); goMap[4707272789158689930L] = go; }
        { var go = new GameObject("Star02"); go.SetActive(true); goMap[-7620671298691077434L] = go; }
        { var go = new GameObject("Star03"); go.SetActive(true); goMap[6002385650345087114L] = go; }
        { var go = new GameObject("GlowLight"); go.SetActive(true); goMap[438690655210114593L] = go; }
        { var go = new GameObject("NoStar3"); go.SetActive(true); goMap[8851085592277010826L] = go; }
        { var go = new GameObject("Star3"); go.SetActive(true); goMap[-8051068233628335769L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[8980479324127867904L] = go; }
        { var go = new GameObject("Stars_Effect"); go.SetActive(false); goMap[-953531584992077029L] = go; }
        { var go = new GameObject("Glow"); go.SetActive(true); goMap[-6060784570306279416L] = go; }
        { var go = new GameObject("Star"); go.SetActive(true); goMap[-1016861462626337775L] = go; }
        { var go = new GameObject("StarGlow"); go.SetActive(true); goMap[-323649884964017795L] = go; }
        { var go = new GameObject("Star02"); go.SetActive(true); goMap[1672993012430907627L] = go; }
        { var go = new GameObject("Star03"); go.SetActive(true); goMap[2932247632442589586L] = go; }
        { var go = new GameObject("GlowLight"); go.SetActive(true); goMap[2665122871150871178L] = go; }
        { var go = new GameObject("NoStar4"); go.SetActive(true); goMap[-2550632027926656290L] = go; }
        { var go = new GameObject("Star4"); go.SetActive(true); goMap[4541033614448359897L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[-6154697379434018567L] = go; }
        { var go = new GameObject("Stars_Effect"); go.SetActive(false); goMap[-8573601724672564979L] = go; }
        { var go = new GameObject("Glow"); go.SetActive(true); goMap[-1900076293175689746L] = go; }
        { var go = new GameObject("Star"); go.SetActive(true); goMap[4790759944120895075L] = go; }
        { var go = new GameObject("StarGlow"); go.SetActive(true); goMap[-4883687784143725223L] = go; }
        { var go = new GameObject("Star02"); go.SetActive(true); goMap[7152418055762483459L] = go; }
        { var go = new GameObject("Star03"); go.SetActive(true); goMap[-737189967021102339L] = go; }
        { var go = new GameObject("GlowLight"); go.SetActive(true); goMap[8618377119359548901L] = go; }
        { var go = new GameObject("NoStar5"); go.SetActive(true); goMap[-462465019854132157L] = go; }
        { var go = new GameObject("Star5"); go.SetActive(true); goMap[4151047700023418276L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[-7512650144178068486L] = go; }
        { var go = new GameObject("Stars_Effect"); go.SetActive(false); goMap[-4002904500122676931L] = go; }
        { var go = new GameObject("Glow"); go.SetActive(true); goMap[3576347670119352105L] = go; }
        { var go = new GameObject("Star"); go.SetActive(true); goMap[2711649218186930816L] = go; }
        { var go = new GameObject("StarGlow"); go.SetActive(true); goMap[2756443205663124640L] = go; }
        { var go = new GameObject("Star02"); go.SetActive(true); goMap[1012443744616767515L] = go; }
        { var go = new GameObject("Star03"); go.SetActive(true); goMap[292193343307695195L] = go; }
        { var go = new GameObject("GlowLight"); go.SetActive(true); goMap[-8915481951151846066L] = go; }
        { var go = new GameObject("NoStar6"); go.SetActive(true); goMap[-7490405748862311908L] = go; }
        { var go = new GameObject("Star6"); go.SetActive(true); goMap[8810965390122667246L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[-1248926478434573238L] = go; }
        { var go = new GameObject("Stars_Effect"); go.SetActive(false); goMap[4294215755529901335L] = go; }
        { var go = new GameObject("Glow"); go.SetActive(true); goMap[4795115375771039105L] = go; }
        { var go = new GameObject("Star"); go.SetActive(true); goMap[-7127260521124767976L] = go; }
        { var go = new GameObject("StarGlow"); go.SetActive(true); goMap[-7588365245636225969L] = go; }
        { var go = new GameObject("Star02"); go.SetActive(true); goMap[4724204725663328857L] = go; }
        { var go = new GameObject("Star03"); go.SetActive(true); goMap[-4515152765130138054L] = go; }
        { var go = new GameObject("GlowLight"); go.SetActive(true); goMap[-8385253487601168974L] = go; }
        { var go = new GameObject("NoStar7"); go.SetActive(true); goMap[-7131017960517302066L] = go; }
        { var go = new GameObject("Star7"); go.SetActive(true); goMap[6570614327353679017L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[483337742469751541L] = go; }
        { var go = new GameObject("Stars_Effect"); go.SetActive(false); goMap[-2801888561433760602L] = go; }
        { var go = new GameObject("Glow"); go.SetActive(true); goMap[6685749964145550084L] = go; }
        { var go = new GameObject("Star"); go.SetActive(true); goMap[2565843395336727796L] = go; }
        { var go = new GameObject("StarGlow"); go.SetActive(true); goMap[-2299731936075077400L] = go; }
        { var go = new GameObject("Star02"); go.SetActive(true); goMap[-7608813041173418661L] = go; }
        { var go = new GameObject("Star03"); go.SetActive(true); goMap[-2656410450249240064L] = go; }
        { var go = new GameObject("GlowLight"); go.SetActive(true); goMap[7650555389396468493L] = go; }
        { var go = new GameObject("NoStar8"); go.SetActive(true); goMap[354385634602601588L] = go; }
        { var go = new GameObject("Star8"); go.SetActive(true); goMap[716125061773250638L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[77193653939337239L] = go; }
        { var go = new GameObject("Stars_Effect"); go.SetActive(false); goMap[-1243228839793477792L] = go; }
        { var go = new GameObject("Glow"); go.SetActive(true); goMap[8525166709864408491L] = go; }
        { var go = new GameObject("Star"); go.SetActive(true); goMap[-6907784491104699083L] = go; }
        { var go = new GameObject("StarGlow"); go.SetActive(true); goMap[-7656427223733620045L] = go; }
        { var go = new GameObject("Star02"); go.SetActive(true); goMap[-4867037155168910107L] = go; }
        { var go = new GameObject("Star03"); go.SetActive(true); goMap[-1508997663551144053L] = go; }
        { var go = new GameObject("GlowLight"); go.SetActive(true); goMap[-8543919480190094921L] = go; }
        { var go = new GameObject("txtNowFightPower"); go.SetActive(true); goMap[-1120722393036109054L] = go; }
        { var go = new GameObject("txtNextFightPower"); go.SetActive(true); goMap[-6135853244126971360L] = go; }
        { var go = new GameObject("imgGroup"); go.SetActive(true); goMap[-7979246616826963616L] = go; }
        { var go = new GameObject("imgBG1"); go.SetActive(true); goMap[-4329932287692243318L] = go; }
        { var go = new GameObject("imgBG2"); go.SetActive(true); goMap[-1115738949101879851L] = go; }
        { var go = new GameObject("PotentialList"); go.SetActive(true); goMap[-8640404968505843781L] = go; }
        { var go = new GameObject("imgArrow"); go.SetActive(true); goMap[7667147277450260804L] = go; }
        { var go = new GameObject("StarsUpAttribItem1"); go.SetActive(true); goMap[6510247877017047373L] = go; }
        { var go = new GameObject("NowQualityGroup"); go.SetActive(true); goMap[-8895668424808438992L] = go; }
        { var go = new GameObject("imgListBg"); go.SetActive(true); goMap[4709012764903896606L] = go; }
        { var go = new GameObject("txtAttribute"); go.SetActive(true); goMap[220127819256391290L] = go; }
        { var go = new GameObject("txtAttribute1"); go.SetActive(true); goMap[-3776758144051738292L] = go; }
        { var go = new GameObject("NowQuality"); go.SetActive(true); goMap[-4985048016744411627L] = go; }
        { var go = new GameObject("imgQualityBarBG"); go.SetActive(true); goMap[-6666573820160454681L] = go; }
        { var go = new GameObject("imgQualityBar"); go.SetActive(true); goMap[-3928363599584786902L] = go; }
        { var go = new GameObject("txtQualityPercent"); go.SetActive(true); goMap[-4755570678986020043L] = go; }
        { var go = new GameObject("NextQualityGroup"); go.SetActive(true); goMap[9162396083003193223L] = go; }
        { var go = new GameObject("imgListBg"); go.SetActive(true); goMap[-5903351347500995990L] = go; }
        { var go = new GameObject("txtAttribute"); go.SetActive(true); goMap[-2389380717241017990L] = go; }
        { var go = new GameObject("txtAttribute1"); go.SetActive(true); goMap[5266550835561992563L] = go; }
        { var go = new GameObject("NextQuality"); go.SetActive(true); goMap[-3773734049788244556L] = go; }
        { var go = new GameObject("imgQualityBarBG"); go.SetActive(true); goMap[7011586862414228360L] = go; }
        { var go = new GameObject("imgQualityBar"); go.SetActive(true); goMap[-7027404975942066462L] = go; }
        { var go = new GameObject("txtQualityPercent"); go.SetActive(true); goMap[-4263394293975780911L] = go; }
        { var go = new GameObject("StarsUpAttribItem2"); go.SetActive(true); goMap[-7115643980146951185L] = go; }
        { var go = new GameObject("NowPhysiqueGroup"); go.SetActive(true); goMap[-9051635706378770793L] = go; }
        { var go = new GameObject("imgListBg"); go.SetActive(true); goMap[3347868991075693914L] = go; }
        { var go = new GameObject("txtAttribute"); go.SetActive(true); goMap[4008234521411931872L] = go; }
        { var go = new GameObject("txtAttribute1"); go.SetActive(true); goMap[-5336356145618509422L] = go; }
        { var go = new GameObject("NowPhysique"); go.SetActive(true); goMap[5779641546417794848L] = go; }
        { var go = new GameObject("imgPhysiqueBarBG"); go.SetActive(true); goMap[7557798947104825702L] = go; }
        { var go = new GameObject("imgPhysiqueBar"); go.SetActive(true); goMap[-513533972849856645L] = go; }
        { var go = new GameObject("txtPhysiquePercent"); go.SetActive(true); goMap[3534624205430497742L] = go; }
        { var go = new GameObject("NextPhysiqueGroup"); go.SetActive(true); goMap[-5719713614825243138L] = go; }
        { var go = new GameObject("imgListBg"); go.SetActive(true); goMap[9023064107338188402L] = go; }
        { var go = new GameObject("txtAttribute"); go.SetActive(true); goMap[-2266729908282950782L] = go; }
        { var go = new GameObject("txtAttribute1"); go.SetActive(true); goMap[2715245157730404675L] = go; }
        { var go = new GameObject("NextPhysique"); go.SetActive(true); goMap[1191044516803501369L] = go; }
        { var go = new GameObject("imgPhysiqueBarBG"); go.SetActive(true); goMap[5861201471266805240L] = go; }
        { var go = new GameObject("imgPhysiqueBar"); go.SetActive(true); goMap[883732059803775364L] = go; }
        { var go = new GameObject("txtPhysiquePercent"); go.SetActive(true); goMap[-5278553939604487587L] = go; }
        { var go = new GameObject("StarsUpAttribItem3"); go.SetActive(true); goMap[-257558248621476368L] = go; }
        { var go = new GameObject("NowNeiGongGroup"); go.SetActive(true); goMap[-5208398228975635235L] = go; }
        { var go = new GameObject("imgListBg"); go.SetActive(true); goMap[2859973957070342304L] = go; }
        { var go = new GameObject("txtAttribute"); go.SetActive(true); goMap[-5855475892591408286L] = go; }
        { var go = new GameObject("txtAttribute1"); go.SetActive(true); goMap[8335626354727567372L] = go; }
        { var go = new GameObject("NowNeiGong"); go.SetActive(true); goMap[-7786233064560093558L] = go; }
        { var go = new GameObject("imgNeiGongBarBG"); go.SetActive(true); goMap[8069096253605241694L] = go; }
        { var go = new GameObject("imgNeiGongBar"); go.SetActive(true); goMap[-5328210617609593739L] = go; }
        { var go = new GameObject("txtNeiGongPercent"); go.SetActive(true); goMap[-6168081303697248622L] = go; }
        { var go = new GameObject("NextNeiGongGroup"); go.SetActive(true); goMap[-3653557486982773188L] = go; }
        { var go = new GameObject("imgListBg"); go.SetActive(true); goMap[3869749892591518472L] = go; }
        { var go = new GameObject("txtAttribute"); go.SetActive(true); goMap[-4315081264153127850L] = go; }
        { var go = new GameObject("txtAttribute1"); go.SetActive(true); goMap[5441594349541672554L] = go; }
        { var go = new GameObject("NextNeiGong"); go.SetActive(true); goMap[3240874650805179739L] = go; }
        { var go = new GameObject("imgNeiGongBarBG"); go.SetActive(true); goMap[-2476595509888812582L] = go; }
        { var go = new GameObject("imgNeiGongBar"); go.SetActive(true); goMap[-3100651814891294229L] = go; }
        { var go = new GameObject("txtNeiGongPercent"); go.SetActive(true); goMap[3434687367049390774L] = go; }
        { var go = new GameObject("StarsUpAttribItem4"); go.SetActive(true); goMap[-534171021608326641L] = go; }
        { var go = new GameObject("NowShenFaGroup"); go.SetActive(true); goMap[1383814936887046630L] = go; }
        { var go = new GameObject("imgListBg"); go.SetActive(true); goMap[8035279643546325816L] = go; }
        { var go = new GameObject("txtAttribute"); go.SetActive(true); goMap[6520388031762645846L] = go; }
        { var go = new GameObject("txtAttribute1"); go.SetActive(true); goMap[2814609402373077280L] = go; }
        { var go = new GameObject("NowShenFa"); go.SetActive(true); goMap[-3843895827321818733L] = go; }
        { var go = new GameObject("imgShenFaBarBG"); go.SetActive(true); goMap[-4150256370293658522L] = go; }
        { var go = new GameObject("imgShenFaBar"); go.SetActive(true); goMap[4747953812791310495L] = go; }
        { var go = new GameObject("txtShenFaPercent"); go.SetActive(true); goMap[-6236220478818438188L] = go; }
        { var go = new GameObject("NextShenFaGroup"); go.SetActive(true); goMap[8246076380788931812L] = go; }
        { var go = new GameObject("imgListBg"); go.SetActive(true); goMap[-2100433758910331870L] = go; }
        { var go = new GameObject("txtAttribute"); go.SetActive(true); goMap[6395141748899658570L] = go; }
        { var go = new GameObject("txtAttribute1"); go.SetActive(true); goMap[1700776221948875682L] = go; }
        { var go = new GameObject("NextShenFa"); go.SetActive(true); goMap[4740736687452161246L] = go; }
        { var go = new GameObject("imgShenFaBarBG"); go.SetActive(true); goMap[647037677680005221L] = go; }
        { var go = new GameObject("imgShenFaBar"); go.SetActive(true); goMap[6049515899158543199L] = go; }
        { var go = new GameObject("txtShenFaPercent"); go.SetActive(true); goMap[-6198246070162060933L] = go; }
        { var go = new GameObject("Need"); go.SetActive(true); goMap[5402941593196120952L] = go; }
        { var go = new GameObject("txtLvNeed"); go.SetActive(true); goMap[-7475118935421058513L] = go; }
        { var go = new GameObject("PartnerNeed"); go.SetActive(true); goMap[-3551964480073841159L] = go; }
        { var go = new GameObject("txtTip"); go.SetActive(true); goMap[3830738052779403065L] = go; }
        { var go = new GameObject("txtName"); go.SetActive(true); goMap[997699912737467909L] = go; }
        { var go = new GameObject("txtCount"); go.SetActive(true); goMap[-5264890917061130999L] = go; }
        { var go = new GameObject("btnStarsUp"); go.SetActive(true); goMap[3462981794034216428L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[7974511670011937539L] = go; }
        { var go = new GameObject("txtTitle"); go.SetActive(true); goMap[8996515339600885042L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[-366285291519699992L] = go; }
        { var go = new GameObject("Image (1)"); go.SetActive(true); goMap[-5663598520975234286L] = go; }
        { var go = new GameObject("imgEmpty"); go.SetActive(false); goMap[-3218270996477689853L] = go; }
        { var go = new GameObject("txtEmpty"); go.SetActive(false); goMap[-6323258045011492572L] = go; }

        // ─── Parent links ─────────────────────────────────────
        goMap[3945388089780440666L].transform.SetParent(goMap[3234735537922300143L].transform, false);
        goMap[4055871074233093091L].transform.SetParent(goMap[3945388089780440666L].transform, false);
        goMap[3299279500291616282L].transform.SetParent(goMap[4055871074233093091L].transform, false);
        goMap[3938092759976508898L].transform.SetParent(goMap[3299279500291616282L].transform, false);
        goMap[5446201502268030719L].transform.SetParent(goMap[3299279500291616282L].transform, false);
        goMap[-7648232724668134389L].transform.SetParent(goMap[3299279500291616282L].transform, false);
        goMap[-6195448894422624557L].transform.SetParent(goMap[3299279500291616282L].transform, false);
        goMap[-1293367365699253638L].transform.SetParent(goMap[3299279500291616282L].transform, false);
        goMap[5467965228140875103L].transform.SetParent(goMap[3299279500291616282L].transform, false);
        goMap[4247749607033715472L].transform.SetParent(goMap[3299279500291616282L].transform, false);
        goMap[2308658377850910961L].transform.SetParent(goMap[3299279500291616282L].transform, false);
        goMap[595231751789470271L].transform.SetParent(goMap[3299279500291616282L].transform, false);
        goMap[-704710079963207697L].transform.SetParent(goMap[3299279500291616282L].transform, false);
        goMap[-8776721450332639076L].transform.SetParent(goMap[3299279500291616282L].transform, false);
        goMap[-5065673131270198913L].transform.SetParent(goMap[3299279500291616282L].transform, false);
        goMap[-3215921739427355339L].transform.SetParent(goMap[4055871074233093091L].transform, false);
        goMap[2467822709940603548L].transform.SetParent(goMap[3945388089780440666L].transform, false);
        goMap[5757726401891543646L].transform.SetParent(goMap[2467822709940603548L].transform, false);
        goMap[6816598455657616683L].transform.SetParent(goMap[2467822709940603548L].transform, false);
        goMap[-7666222920952687518L].transform.SetParent(goMap[2467822709940603548L].transform, false);
        goMap[4839675983278491765L].transform.SetParent(goMap[-7666222920952687518L].transform, false);
        goMap[5753481503304624134L].transform.SetParent(goMap[4839675983278491765L].transform, false);
        goMap[-739316333397060947L].transform.SetParent(goMap[4839675983278491765L].transform, false);
        goMap[-1611104360110124102L].transform.SetParent(goMap[-739316333397060947L].transform, false);
        goMap[8357388933535953441L].transform.SetParent(goMap[-739316333397060947L].transform, false);
        goMap[6819502722847958907L].transform.SetParent(goMap[8357388933535953441L].transform, false);
        goMap[-2170007839850768716L].transform.SetParent(goMap[8357388933535953441L].transform, false);
        goMap[-2949249071565123633L].transform.SetParent(goMap[-2170007839850768716L].transform, false);
        goMap[-6543210114668253055L].transform.SetParent(goMap[-2170007839850768716L].transform, false);
        goMap[8870124854585655719L].transform.SetParent(goMap[-2170007839850768716L].transform, false);
        goMap[7055951580439506138L].transform.SetParent(goMap[-2170007839850768716L].transform, false);
        goMap[4739085761482707844L].transform.SetParent(goMap[-2170007839850768716L].transform, false);
        goMap[-5192820362663614449L].transform.SetParent(goMap[-2170007839850768716L].transform, false);
        goMap[-6426709608600509360L].transform.SetParent(goMap[-739316333397060947L].transform, false);
        goMap[5360859761328083824L].transform.SetParent(goMap[-739316333397060947L].transform, false);
        goMap[-5154651572578956940L].transform.SetParent(goMap[5360859761328083824L].transform, false);
        goMap[-5196340154655026492L].transform.SetParent(goMap[5360859761328083824L].transform, false);
        goMap[3922656639683113239L].transform.SetParent(goMap[-5196340154655026492L].transform, false);
        goMap[3112382401901360813L].transform.SetParent(goMap[-5196340154655026492L].transform, false);
        goMap[4707272789158689930L].transform.SetParent(goMap[-5196340154655026492L].transform, false);
        goMap[-7620671298691077434L].transform.SetParent(goMap[-5196340154655026492L].transform, false);
        goMap[6002385650345087114L].transform.SetParent(goMap[-5196340154655026492L].transform, false);
        goMap[438690655210114593L].transform.SetParent(goMap[-5196340154655026492L].transform, false);
        goMap[8851085592277010826L].transform.SetParent(goMap[-739316333397060947L].transform, false);
        goMap[-8051068233628335769L].transform.SetParent(goMap[-739316333397060947L].transform, false);
        goMap[8980479324127867904L].transform.SetParent(goMap[-8051068233628335769L].transform, false);
        goMap[-953531584992077029L].transform.SetParent(goMap[-8051068233628335769L].transform, false);
        goMap[-6060784570306279416L].transform.SetParent(goMap[-953531584992077029L].transform, false);
        goMap[-1016861462626337775L].transform.SetParent(goMap[-953531584992077029L].transform, false);
        goMap[-323649884964017795L].transform.SetParent(goMap[-953531584992077029L].transform, false);
        goMap[1672993012430907627L].transform.SetParent(goMap[-953531584992077029L].transform, false);
        goMap[2932247632442589586L].transform.SetParent(goMap[-953531584992077029L].transform, false);
        goMap[2665122871150871178L].transform.SetParent(goMap[-953531584992077029L].transform, false);
        goMap[-2550632027926656290L].transform.SetParent(goMap[-739316333397060947L].transform, false);
        goMap[4541033614448359897L].transform.SetParent(goMap[-739316333397060947L].transform, false);
        goMap[-6154697379434018567L].transform.SetParent(goMap[4541033614448359897L].transform, false);
        goMap[-8573601724672564979L].transform.SetParent(goMap[4541033614448359897L].transform, false);
        goMap[-1900076293175689746L].transform.SetParent(goMap[-8573601724672564979L].transform, false);
        goMap[4790759944120895075L].transform.SetParent(goMap[-8573601724672564979L].transform, false);
        goMap[-4883687784143725223L].transform.SetParent(goMap[-8573601724672564979L].transform, false);
        goMap[7152418055762483459L].transform.SetParent(goMap[-8573601724672564979L].transform, false);
        goMap[-737189967021102339L].transform.SetParent(goMap[-8573601724672564979L].transform, false);
        goMap[8618377119359548901L].transform.SetParent(goMap[-8573601724672564979L].transform, false);
        goMap[-462465019854132157L].transform.SetParent(goMap[-739316333397060947L].transform, false);
        goMap[4151047700023418276L].transform.SetParent(goMap[-739316333397060947L].transform, false);
        goMap[-7512650144178068486L].transform.SetParent(goMap[4151047700023418276L].transform, false);
        goMap[-4002904500122676931L].transform.SetParent(goMap[4151047700023418276L].transform, false);
        goMap[3576347670119352105L].transform.SetParent(goMap[-4002904500122676931L].transform, false);
        goMap[2711649218186930816L].transform.SetParent(goMap[-4002904500122676931L].transform, false);
        goMap[2756443205663124640L].transform.SetParent(goMap[-4002904500122676931L].transform, false);
        goMap[1012443744616767515L].transform.SetParent(goMap[-4002904500122676931L].transform, false);
        goMap[292193343307695195L].transform.SetParent(goMap[-4002904500122676931L].transform, false);
        goMap[-8915481951151846066L].transform.SetParent(goMap[-4002904500122676931L].transform, false);
        goMap[-7490405748862311908L].transform.SetParent(goMap[-739316333397060947L].transform, false);
        goMap[8810965390122667246L].transform.SetParent(goMap[-739316333397060947L].transform, false);
        goMap[-1248926478434573238L].transform.SetParent(goMap[8810965390122667246L].transform, false);
        goMap[4294215755529901335L].transform.SetParent(goMap[8810965390122667246L].transform, false);
        goMap[4795115375771039105L].transform.SetParent(goMap[4294215755529901335L].transform, false);
        goMap[-7127260521124767976L].transform.SetParent(goMap[4294215755529901335L].transform, false);
        goMap[-7588365245636225969L].transform.SetParent(goMap[4294215755529901335L].transform, false);
        goMap[4724204725663328857L].transform.SetParent(goMap[4294215755529901335L].transform, false);
        goMap[-4515152765130138054L].transform.SetParent(goMap[4294215755529901335L].transform, false);
        goMap[-8385253487601168974L].transform.SetParent(goMap[4294215755529901335L].transform, false);
        goMap[-7131017960517302066L].transform.SetParent(goMap[-739316333397060947L].transform, false);
        goMap[6570614327353679017L].transform.SetParent(goMap[-739316333397060947L].transform, false);
        goMap[483337742469751541L].transform.SetParent(goMap[6570614327353679017L].transform, false);
        goMap[-2801888561433760602L].transform.SetParent(goMap[6570614327353679017L].transform, false);
        goMap[6685749964145550084L].transform.SetParent(goMap[-2801888561433760602L].transform, false);
        goMap[2565843395336727796L].transform.SetParent(goMap[-2801888561433760602L].transform, false);
        goMap[-2299731936075077400L].transform.SetParent(goMap[-2801888561433760602L].transform, false);
        goMap[-7608813041173418661L].transform.SetParent(goMap[-2801888561433760602L].transform, false);
        goMap[-2656410450249240064L].transform.SetParent(goMap[-2801888561433760602L].transform, false);
        goMap[7650555389396468493L].transform.SetParent(goMap[-2801888561433760602L].transform, false);
        goMap[354385634602601588L].transform.SetParent(goMap[-739316333397060947L].transform, false);
        goMap[716125061773250638L].transform.SetParent(goMap[-739316333397060947L].transform, false);
        goMap[77193653939337239L].transform.SetParent(goMap[716125061773250638L].transform, false);
        goMap[-1243228839793477792L].transform.SetParent(goMap[716125061773250638L].transform, false);
        goMap[8525166709864408491L].transform.SetParent(goMap[-1243228839793477792L].transform, false);
        goMap[-6907784491104699083L].transform.SetParent(goMap[-1243228839793477792L].transform, false);
        goMap[-7656427223733620045L].transform.SetParent(goMap[-1243228839793477792L].transform, false);
        goMap[-4867037155168910107L].transform.SetParent(goMap[-1243228839793477792L].transform, false);
        goMap[-1508997663551144053L].transform.SetParent(goMap[-1243228839793477792L].transform, false);
        goMap[-8543919480190094921L].transform.SetParent(goMap[-1243228839793477792L].transform, false);
        goMap[-1120722393036109054L].transform.SetParent(goMap[-7666222920952687518L].transform, false);
        goMap[-6135853244126971360L].transform.SetParent(goMap[-7666222920952687518L].transform, false);
        goMap[-7979246616826963616L].transform.SetParent(goMap[-7666222920952687518L].transform, false);
        goMap[-4329932287692243318L].transform.SetParent(goMap[-7979246616826963616L].transform, false);
        goMap[-1115738949101879851L].transform.SetParent(goMap[-7979246616826963616L].transform, false);
        goMap[-8640404968505843781L].transform.SetParent(goMap[-7666222920952687518L].transform, false);
        goMap[7667147277450260804L].transform.SetParent(goMap[-8640404968505843781L].transform, false);
        goMap[6510247877017047373L].transform.SetParent(goMap[-8640404968505843781L].transform, false);
        goMap[-8895668424808438992L].transform.SetParent(goMap[6510247877017047373L].transform, false);
        goMap[4709012764903896606L].transform.SetParent(goMap[-8895668424808438992L].transform, false);
        goMap[220127819256391290L].transform.SetParent(goMap[-8895668424808438992L].transform, false);
        goMap[-3776758144051738292L].transform.SetParent(goMap[-8895668424808438992L].transform, false);
        goMap[-4985048016744411627L].transform.SetParent(goMap[-8895668424808438992L].transform, false);
        goMap[-6666573820160454681L].transform.SetParent(goMap[-4985048016744411627L].transform, false);
        goMap[-3928363599584786902L].transform.SetParent(goMap[-4985048016744411627L].transform, false);
        goMap[-4755570678986020043L].transform.SetParent(goMap[-4985048016744411627L].transform, false);
        goMap[9162396083003193223L].transform.SetParent(goMap[6510247877017047373L].transform, false);
        goMap[-5903351347500995990L].transform.SetParent(goMap[9162396083003193223L].transform, false);
        goMap[-2389380717241017990L].transform.SetParent(goMap[9162396083003193223L].transform, false);
        goMap[5266550835561992563L].transform.SetParent(goMap[9162396083003193223L].transform, false);
        goMap[-3773734049788244556L].transform.SetParent(goMap[9162396083003193223L].transform, false);
        goMap[7011586862414228360L].transform.SetParent(goMap[-3773734049788244556L].transform, false);
        goMap[-7027404975942066462L].transform.SetParent(goMap[-3773734049788244556L].transform, false);
        goMap[-4263394293975780911L].transform.SetParent(goMap[-3773734049788244556L].transform, false);
        goMap[-7115643980146951185L].transform.SetParent(goMap[-8640404968505843781L].transform, false);
        goMap[-9051635706378770793L].transform.SetParent(goMap[-7115643980146951185L].transform, false);
        goMap[3347868991075693914L].transform.SetParent(goMap[-9051635706378770793L].transform, false);
        goMap[4008234521411931872L].transform.SetParent(goMap[-9051635706378770793L].transform, false);
        goMap[-5336356145618509422L].transform.SetParent(goMap[-9051635706378770793L].transform, false);
        goMap[5779641546417794848L].transform.SetParent(goMap[-9051635706378770793L].transform, false);
        goMap[7557798947104825702L].transform.SetParent(goMap[5779641546417794848L].transform, false);
        goMap[-513533972849856645L].transform.SetParent(goMap[5779641546417794848L].transform, false);
        goMap[3534624205430497742L].transform.SetParent(goMap[5779641546417794848L].transform, false);
        goMap[-5719713614825243138L].transform.SetParent(goMap[-7115643980146951185L].transform, false);
        goMap[9023064107338188402L].transform.SetParent(goMap[-5719713614825243138L].transform, false);
        goMap[-2266729908282950782L].transform.SetParent(goMap[-5719713614825243138L].transform, false);
        goMap[2715245157730404675L].transform.SetParent(goMap[-5719713614825243138L].transform, false);
        goMap[1191044516803501369L].transform.SetParent(goMap[-5719713614825243138L].transform, false);
        goMap[5861201471266805240L].transform.SetParent(goMap[1191044516803501369L].transform, false);
        goMap[883732059803775364L].transform.SetParent(goMap[1191044516803501369L].transform, false);
        goMap[-5278553939604487587L].transform.SetParent(goMap[1191044516803501369L].transform, false);
        goMap[-257558248621476368L].transform.SetParent(goMap[-8640404968505843781L].transform, false);
        goMap[-5208398228975635235L].transform.SetParent(goMap[-257558248621476368L].transform, false);
        goMap[2859973957070342304L].transform.SetParent(goMap[-5208398228975635235L].transform, false);
        goMap[-5855475892591408286L].transform.SetParent(goMap[-5208398228975635235L].transform, false);
        goMap[8335626354727567372L].transform.SetParent(goMap[-5208398228975635235L].transform, false);
        goMap[-7786233064560093558L].transform.SetParent(goMap[-5208398228975635235L].transform, false);
        goMap[8069096253605241694L].transform.SetParent(goMap[-7786233064560093558L].transform, false);
        goMap[-5328210617609593739L].transform.SetParent(goMap[-7786233064560093558L].transform, false);
        goMap[-6168081303697248622L].transform.SetParent(goMap[-7786233064560093558L].transform, false);
        goMap[-3653557486982773188L].transform.SetParent(goMap[-257558248621476368L].transform, false);
        goMap[3869749892591518472L].transform.SetParent(goMap[-3653557486982773188L].transform, false);
        goMap[-4315081264153127850L].transform.SetParent(goMap[-3653557486982773188L].transform, false);
        goMap[5441594349541672554L].transform.SetParent(goMap[-3653557486982773188L].transform, false);
        goMap[3240874650805179739L].transform.SetParent(goMap[-3653557486982773188L].transform, false);
        goMap[-2476595509888812582L].transform.SetParent(goMap[3240874650805179739L].transform, false);
        goMap[-3100651814891294229L].transform.SetParent(goMap[3240874650805179739L].transform, false);
        goMap[3434687367049390774L].transform.SetParent(goMap[3240874650805179739L].transform, false);
        goMap[-534171021608326641L].transform.SetParent(goMap[-8640404968505843781L].transform, false);
        goMap[1383814936887046630L].transform.SetParent(goMap[-534171021608326641L].transform, false);
        goMap[8035279643546325816L].transform.SetParent(goMap[1383814936887046630L].transform, false);
        goMap[6520388031762645846L].transform.SetParent(goMap[1383814936887046630L].transform, false);
        goMap[2814609402373077280L].transform.SetParent(goMap[1383814936887046630L].transform, false);
        goMap[-3843895827321818733L].transform.SetParent(goMap[1383814936887046630L].transform, false);
        goMap[-4150256370293658522L].transform.SetParent(goMap[-3843895827321818733L].transform, false);
        goMap[4747953812791310495L].transform.SetParent(goMap[-3843895827321818733L].transform, false);
        goMap[-6236220478818438188L].transform.SetParent(goMap[-3843895827321818733L].transform, false);
        goMap[8246076380788931812L].transform.SetParent(goMap[-534171021608326641L].transform, false);
        goMap[-2100433758910331870L].transform.SetParent(goMap[8246076380788931812L].transform, false);
        goMap[6395141748899658570L].transform.SetParent(goMap[8246076380788931812L].transform, false);
        goMap[1700776221948875682L].transform.SetParent(goMap[8246076380788931812L].transform, false);
        goMap[4740736687452161246L].transform.SetParent(goMap[8246076380788931812L].transform, false);
        goMap[647037677680005221L].transform.SetParent(goMap[4740736687452161246L].transform, false);
        goMap[6049515899158543199L].transform.SetParent(goMap[4740736687452161246L].transform, false);
        goMap[-6198246070162060933L].transform.SetParent(goMap[4740736687452161246L].transform, false);
        goMap[5402941593196120952L].transform.SetParent(goMap[-7666222920952687518L].transform, false);
        goMap[-7475118935421058513L].transform.SetParent(goMap[5402941593196120952L].transform, false);
        goMap[-3551964480073841159L].transform.SetParent(goMap[5402941593196120952L].transform, false);
        goMap[3830738052779403065L].transform.SetParent(goMap[-3551964480073841159L].transform, false);
        goMap[997699912737467909L].transform.SetParent(goMap[-3551964480073841159L].transform, false);
        goMap[-5264890917061130999L].transform.SetParent(goMap[-3551964480073841159L].transform, false);
        goMap[3462981794034216428L].transform.SetParent(goMap[-7666222920952687518L].transform, false);
        goMap[7974511670011937539L].transform.SetParent(goMap[3462981794034216428L].transform, false);
        goMap[8996515339600885042L].transform.SetParent(goMap[-7666222920952687518L].transform, false);
        goMap[-366285291519699992L].transform.SetParent(goMap[8996515339600885042L].transform, false);
        goMap[-5663598520975234286L].transform.SetParent(goMap[8996515339600885042L].transform, false);
        goMap[-3218270996477689853L].transform.SetParent(goMap[-7666222920952687518L].transform, false);
        goMap[-6323258045011492572L].transform.SetParent(goMap[-7666222920952687518L].transform, false);

        // ─── RectTransforms ──────────────────────────────────
        {
            var rt = goMap[3234735537922300143L].AddComponent<RectTransform>();
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
            var rt = goMap[3945388089780440666L].AddComponent<RectTransform>();
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
            var rt = goMap[4055871074233093091L].AddComponent<RectTransform>();
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
            var rt = goMap[3299279500291616282L].AddComponent<RectTransform>();
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
            var rt = goMap[3938092759976508898L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(1.000000f, 0.000000f);
            rt.anchoredPosition = new Vector2(427.415802f, -272.181030f);
            rt.sizeDelta = new Vector2(567.315674f, 383.681000f);
        }
        {
            var rt = goMap[5446201502268030719L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, -1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(57.323093f, 192.258987f);
            rt.sizeDelta = new Vector2(739.920227f, 161.335098f);
        }
        {
            var rt = goMap[-7648232724668134389L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,1.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, -1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-283.607727f, -141.018494f);
            rt.sizeDelta = new Vector2(287.341492f, 262.270996f);
        }
        {
            var rt = goMap[-6195448894422624557L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,1.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-380.801910f, 131.195068f);
            rt.sizeDelta = new Vector2(93.120598f, 282.997711f);
        }
        {
            var rt = goMap[-1293367365699253638L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.400000f, -23.000000f);
            rt.sizeDelta = new Vector2(846.000000f, 486.000000f);
        }
        {
            var rt = goMap[5467965228140875103L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.400000f, 236.300003f);
            rt.sizeDelta = new Vector2(846.000000f, 60.000000f);
        }
        {
            var rt = goMap[4247749607033715472L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.341000f, 264.400024f);
            rt.sizeDelta = new Vector2(842.577820f, 1.000000f);
        }
        {
            var rt = goMap[2308658377850910961L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(1.000000f, 0.000000f);
            rt.anchoredPosition = new Vector2(425.097534f, -268.297668f);
            rt.sizeDelta = new Vector2(558.600586f, 360.611694f);
        }
        {
            var rt = goMap[595231751789470271L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,0.707107f,0.707107f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(124.996582f, 180.522461f);
            rt.sizeDelta = new Vector2(176.462997f, 600.165771f);
        }
        {
            var rt = goMap[-704710079963207697L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,0.707107f,-0.707107f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-279.234192f, -37.571899f);
            rt.sizeDelta = new Vector2(461.448700f, 291.383911f);
        }
        {
            var rt = goMap[-8776721450332639076L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,1.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-299.898254f, 230.839600f);
            rt.sizeDelta = new Vector2(250.023193f, 75.538902f);
        }
        {
            var rt = goMap[-5065673131270198913L].AddComponent<RectTransform>();
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
            var rt = goMap[-3215921739427355339L].AddComponent<RectTransform>();
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
            var rt = goMap[2467822709940603548L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(880.309570f, 577.167175f);
        }
        {
            var rt = goMap[5757726401891543646L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(396.500000f, 238.100006f);
            rt.sizeDelta = new Vector2(49.000000f, 54.000000f);
        }
        {
            var rt = goMap[6816598455657616683L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-410.500000f, 241.899994f);
            rt.sizeDelta = new Vector2(250.000000f, 50.000000f);
        }
        {
            var rt = goMap[-7666222920952687518L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.000107f, -0.001778f);
            rt.sizeDelta = new Vector2(880.309998f, 577.159973f);
        }
        {
            var rt = goMap[4839675983278491765L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-167.000000f, 187.000000f);
            rt.sizeDelta = new Vector2(280.000000f, 30.000000f);
        }
        {
            var rt = goMap[5753481503304624134L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(0.000000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(104.300003f, -1.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 30.000000f);
        }
        {
            var rt = goMap[-739316333397060947L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(0.000000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(227.199997f, 0.000000f);
            rt.sizeDelta = new Vector2(180.000000f, 30.000000f);
        }
        {
            var rt = goMap[-1611104360110124102L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(0.000000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(1.799988f, 0.000000f);
            rt.sizeDelta = new Vector2(28.000000f, 28.000000f);
        }
        {
            var rt = goMap[8357388933535953441L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(0.000000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 30.000000f);
        }
        {
            var rt = goMap[6819502722847958907L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(28.000000f, 28.000000f);
        }
        {
            var rt = goMap[-2170007839850768716L].AddComponent<RectTransform>();
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
            var rt = goMap[-2949249071565123633L].AddComponent<RectTransform>();
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
            var rt = goMap[-6543210114668253055L].AddComponent<RectTransform>();
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
            var rt = goMap[8870124854585655719L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.900000f, 1.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[7055951580439506138L].AddComponent<RectTransform>();
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
            var rt = goMap[-5192820362663614449L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.490000f, 0.290000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-6426709608600509360L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(0.000000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(31.799988f, 0.000000f);
            rt.sizeDelta = new Vector2(28.000000f, 28.000000f);
        }
        {
            var rt = goMap[5360859761328083824L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(0.000000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(30.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 30.000000f);
        }
        {
            var rt = goMap[-5154651572578956940L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(28.000000f, 28.000000f);
        }
        {
            var rt = goMap[-5196340154655026492L].AddComponent<RectTransform>();
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
            var rt = goMap[3922656639683113239L].AddComponent<RectTransform>();
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
            var rt = goMap[3112382401901360813L].AddComponent<RectTransform>();
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
            var rt = goMap[4707272789158689930L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.900000f, 1.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-7620671298691077434L].AddComponent<RectTransform>();
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
            var rt = goMap[438690655210114593L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.490000f, 0.290000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[8851085592277010826L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(0.000000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(61.799999f, 0.000000f);
            rt.sizeDelta = new Vector2(28.000000f, 28.000000f);
        }
        {
            var rt = goMap[-8051068233628335769L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(0.000000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(60.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 30.000000f);
        }
        {
            var rt = goMap[8980479324127867904L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(28.000000f, 28.000000f);
        }
        {
            var rt = goMap[-953531584992077029L].AddComponent<RectTransform>();
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
            var rt = goMap[-6060784570306279416L].AddComponent<RectTransform>();
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
            var rt = goMap[-1016861462626337775L].AddComponent<RectTransform>();
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
            var rt = goMap[-323649884964017795L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.900000f, 1.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[1672993012430907627L].AddComponent<RectTransform>();
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
            var rt = goMap[2665122871150871178L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.490000f, 0.290000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-2550632027926656290L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(0.000000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(91.799988f, 0.000000f);
            rt.sizeDelta = new Vector2(28.000000f, 28.000000f);
        }
        {
            var rt = goMap[4541033614448359897L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(0.000000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(90.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 30.000000f);
        }
        {
            var rt = goMap[-6154697379434018567L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(28.000000f, 28.000000f);
        }
        {
            var rt = goMap[-8573601724672564979L].AddComponent<RectTransform>();
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
            var rt = goMap[-1900076293175689746L].AddComponent<RectTransform>();
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
            var rt = goMap[4790759944120895075L].AddComponent<RectTransform>();
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
            var rt = goMap[-4883687784143725223L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.900000f, 1.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[7152418055762483459L].AddComponent<RectTransform>();
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
            var rt = goMap[8618377119359548901L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.490000f, 0.290000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-462465019854132157L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(0.000000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(121.799988f, 0.000000f);
            rt.sizeDelta = new Vector2(28.000000f, 28.000000f);
        }
        {
            var rt = goMap[4151047700023418276L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(0.000000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(120.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 30.000000f);
        }
        {
            var rt = goMap[-7512650144178068486L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(28.000000f, 28.000000f);
        }
        {
            var rt = goMap[-4002904500122676931L].AddComponent<RectTransform>();
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
            var rt = goMap[3576347670119352105L].AddComponent<RectTransform>();
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
            var rt = goMap[2711649218186930816L].AddComponent<RectTransform>();
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
            var rt = goMap[2756443205663124640L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.900000f, 1.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[1012443744616767515L].AddComponent<RectTransform>();
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
            var rt = goMap[-8915481951151846066L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.490000f, 0.290000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-7490405748862311908L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(0.000000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(151.799988f, 0.000000f);
            rt.sizeDelta = new Vector2(28.000000f, 28.000000f);
        }
        {
            var rt = goMap[8810965390122667246L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(0.000000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(150.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 30.000000f);
        }
        {
            var rt = goMap[-1248926478434573238L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(28.000000f, 28.000000f);
        }
        {
            var rt = goMap[4294215755529901335L].AddComponent<RectTransform>();
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
            var rt = goMap[4795115375771039105L].AddComponent<RectTransform>();
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
            var rt = goMap[-7127260521124767976L].AddComponent<RectTransform>();
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
            var rt = goMap[-7588365245636225969L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.900000f, 1.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[4724204725663328857L].AddComponent<RectTransform>();
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
            var rt = goMap[-8385253487601168974L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.490000f, 0.290000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-7131017960517302066L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(0.000000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(181.799988f, 0.000000f);
            rt.sizeDelta = new Vector2(28.000000f, 28.000000f);
        }
        {
            var rt = goMap[6570614327353679017L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(0.000000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(180.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 30.000000f);
        }
        {
            var rt = goMap[483337742469751541L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(28.000000f, 28.000000f);
        }
        {
            var rt = goMap[-2801888561433760602L].AddComponent<RectTransform>();
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
            var rt = goMap[6685749964145550084L].AddComponent<RectTransform>();
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
            var rt = goMap[2565843395336727796L].AddComponent<RectTransform>();
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
            var rt = goMap[-2299731936075077400L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.900000f, 1.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-7608813041173418661L].AddComponent<RectTransform>();
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
            var rt = goMap[7650555389396468493L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.490000f, 0.290000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[354385634602601588L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(0.000000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(211.999969f, 0.000000f);
            rt.sizeDelta = new Vector2(28.000000f, 28.000000f);
        }
        {
            var rt = goMap[716125061773250638L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(0.000000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(210.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 30.000000f);
        }
        {
            var rt = goMap[77193653939337239L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(28.000000f, 28.000000f);
        }
        {
            var rt = goMap[-1243228839793477792L].AddComponent<RectTransform>();
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
            var rt = goMap[8525166709864408491L].AddComponent<RectTransform>();
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
            var rt = goMap[-6907784491104699083L].AddComponent<RectTransform>();
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
            var rt = goMap[-7656427223733620045L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.900000f, 1.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-4867037155168910107L].AddComponent<RectTransform>();
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
            var rt = goMap[-8543919480190094921L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.490000f, 0.290000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-1120722393036109054L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-218.000000f, 148.000000f);
            rt.sizeDelta = new Vector2(300.000000f, 30.000000f);
        }
        {
            var rt = goMap[-6135853244126971360L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(229.000000f, 147.000000f);
            rt.sizeDelta = new Vector2(300.000000f, 30.000000f);
        }
        {
            var rt = goMap[-7979246616826963616L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-226.764175f, 11.804300f);
            rt.sizeDelta = new Vector2(359.946014f, 241.793900f);
        }
        {
            var rt = goMap[-4329932287692243318L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.000015f, 0.000000f);
            rt.sizeDelta = new Vector2(359.946014f, 241.793900f);
        }
        {
            var rt = goMap[-1115738949101879851L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(453.770264f, 0.000000f);
            rt.sizeDelta = new Vector2(358.110687f, 241.793900f);
        }
        {
            var rt = goMap[-8640404968505843781L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-9.999878f, 29.000000f);
            rt.sizeDelta = new Vector2(800.000000f, 150.000000f);
        }
        {
            var rt = goMap[7667147277450260804L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(5.200000f, -18.730286f);
            rt.sizeDelta = new Vector2(70.000000f, 35.000000f);
        }
        {
            var rt = goMap[6510247877017047373L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-7.800000f, 63.299999f);
            rt.sizeDelta = new Vector2(800.000000f, 30.000000f);
        }
        {
            var rt = goMap[-8895668424808438992L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.800000f, 0.800000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-209.000000f, 6.762200f);
            rt.sizeDelta = new Vector2(427.230011f, 66.651497f);
        }
        {
            var rt = goMap[4709012764903896606L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.000092f, 0.000000f);
            rt.sizeDelta = new Vector2(427.230011f, 66.651497f);
        }
        {
            var rt = goMap[220127819256391290L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.250000f, 1.250000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(0.000000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(5.990005f, -8.452759f);
            rt.sizeDelta = new Vector2(53.766701f, 37.000000f);
        }
        {
            var rt = goMap[-3776758144051738292L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.250000f, 1.250000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(0.000000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(60.240005f, 11.172259f);
            rt.sizeDelta = new Vector2(65.997299f, 37.000000f);
        }
        {
            var rt = goMap[-4985048016744411627L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.250000f, 1.250000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(35.618942f, -8.452759f);
            rt.sizeDelta = new Vector2(284.786713f, 30.000000f);
        }
        {
            var rt = goMap[-6666573820160454681L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-2.029300f, -1.501300f);
            rt.sizeDelta = new Vector2(276.741394f, 9.947500f);
        }
        {
            var rt = goMap[-3928363599584786902L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-138.987656f, -1.501286f);
            rt.sizeDelta = new Vector2(275.329895f, 8.000000f);
        }
        {
            var rt = goMap[-4755570678986020043L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(78.199997f, 14.800000f);
            rt.sizeDelta = new Vector2(130.000000f, 37.000000f);
        }
        {
            var rt = goMap[9162396083003193223L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.800000f, 0.800000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(245.199997f, 6.762200f);
            rt.sizeDelta = new Vector2(427.230011f, 66.651497f);
        }
        {
            var rt = goMap[-5903351347500995990L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.000031f, 0.000000f);
            rt.sizeDelta = new Vector2(427.230011f, 66.651497f);
        }
        {
            var rt = goMap[-2389380717241017990L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.250000f, 1.250000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(0.000000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(5.990005f, -8.452759f);
            rt.sizeDelta = new Vector2(53.766701f, 37.000000f);
        }
        {
            var rt = goMap[5266550835561992563L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.250000f, 1.250000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(0.000000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(60.240005f, 11.172259f);
            rt.sizeDelta = new Vector2(65.997299f, 37.000000f);
        }
        {
            var rt = goMap[-3773734049788244556L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.250000f, 1.250000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(35.618942f, -8.452759f);
            rt.sizeDelta = new Vector2(284.786713f, 30.000000f);
        }
        {
            var rt = goMap[7011586862414228360L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-2.029300f, -1.501300f);
            rt.sizeDelta = new Vector2(276.741394f, 9.947500f);
        }
        {
            var rt = goMap[-7027404975942066462L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-138.987656f, -1.501286f);
            rt.sizeDelta = new Vector2(275.329895f, 8.000000f);
        }
        {
            var rt = goMap[-4263394293975780911L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(78.199997f, 14.800000f);
            rt.sizeDelta = new Vector2(130.000000f, 37.000000f);
        }
        {
            var rt = goMap[-7115643980146951185L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-7.800000f, 5.600000f);
            rt.sizeDelta = new Vector2(800.000000f, 30.000000f);
        }
        {
            var rt = goMap[-9051635706378770793L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.800000f, 0.800000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-209.000000f, 6.762200f);
            rt.sizeDelta = new Vector2(427.230011f, 66.651497f);
        }
        {
            var rt = goMap[3347868991075693914L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.000031f, 0.000000f);
            rt.sizeDelta = new Vector2(427.230011f, 66.651497f);
        }
        {
            var rt = goMap[4008234521411931872L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.250000f, 1.250000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(0.000000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(5.990005f, -8.452759f);
            rt.sizeDelta = new Vector2(53.766701f, 37.000000f);
        }
        {
            var rt = goMap[-5336356145618509422L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.250000f, 1.250000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(0.000000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(60.240005f, 11.172259f);
            rt.sizeDelta = new Vector2(65.997299f, 37.000000f);
        }
        {
            var rt = goMap[5779641546417794848L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.250000f, 1.250000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(35.618942f, -8.452759f);
            rt.sizeDelta = new Vector2(284.786713f, 30.000000f);
        }
        {
            var rt = goMap[7557798947104825702L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-2.029300f, -1.501300f);
            rt.sizeDelta = new Vector2(276.741394f, 9.947500f);
        }
        {
            var rt = goMap[-513533972849856645L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-138.987656f, -1.501286f);
            rt.sizeDelta = new Vector2(275.329895f, 8.000000f);
        }
        {
            var rt = goMap[3534624205430497742L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(78.199997f, 14.800000f);
            rt.sizeDelta = new Vector2(130.000000f, 37.000000f);
        }
        {
            var rt = goMap[-5719713614825243138L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.800000f, 0.800000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(245.199997f, 6.762200f);
            rt.sizeDelta = new Vector2(427.230011f, 66.651497f);
        }
        {
            var rt = goMap[9023064107338188402L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.000031f, 0.000000f);
            rt.sizeDelta = new Vector2(427.230011f, 66.651497f);
        }
        {
            var rt = goMap[-2266729908282950782L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.250000f, 1.250000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(0.000000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(5.990005f, -8.452759f);
            rt.sizeDelta = new Vector2(53.766701f, 37.000000f);
        }
        {
            var rt = goMap[2715245157730404675L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.250000f, 1.250000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(0.000000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(60.240005f, 11.172259f);
            rt.sizeDelta = new Vector2(65.997299f, 37.000000f);
        }
        {
            var rt = goMap[1191044516803501369L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.250000f, 1.250000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(35.618942f, -8.452759f);
            rt.sizeDelta = new Vector2(284.786713f, 30.000000f);
        }
        {
            var rt = goMap[5861201471266805240L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-2.029300f, -1.501300f);
            rt.sizeDelta = new Vector2(276.741394f, 9.947500f);
        }
        {
            var rt = goMap[883732059803775364L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-138.987656f, -1.501286f);
            rt.sizeDelta = new Vector2(275.329895f, 8.000000f);
        }
        {
            var rt = goMap[-5278553939604487587L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(78.199997f, 14.800000f);
            rt.sizeDelta = new Vector2(130.000000f, 37.000000f);
        }
        {
            var rt = goMap[-257558248621476368L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-7.800000f, -52.299999f);
            rt.sizeDelta = new Vector2(800.000000f, 30.000000f);
        }
        {
            var rt = goMap[-5208398228975635235L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.800000f, 0.800000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-209.000000f, 6.762200f);
            rt.sizeDelta = new Vector2(427.230011f, 66.651497f);
        }
        {
            var rt = goMap[2859973957070342304L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.000031f, 0.000000f);
            rt.sizeDelta = new Vector2(427.230011f, 66.651497f);
        }
        {
            var rt = goMap[-5855475892591408286L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.250000f, 1.250000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(0.000000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(5.990005f, -8.452759f);
            rt.sizeDelta = new Vector2(53.766701f, 37.000000f);
        }
        {
            var rt = goMap[8335626354727567372L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.250000f, 1.250000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(0.000000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(60.240005f, 11.172259f);
            rt.sizeDelta = new Vector2(65.997299f, 37.000000f);
        }
        {
            var rt = goMap[-7786233064560093558L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.250000f, 1.250000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(35.618942f, -8.452759f);
            rt.sizeDelta = new Vector2(284.786713f, 30.000000f);
        }
        {
            var rt = goMap[8069096253605241694L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-2.029300f, -1.501300f);
            rt.sizeDelta = new Vector2(276.741394f, 9.947500f);
        }
        {
            var rt = goMap[-5328210617609593739L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-138.987656f, -1.501286f);
            rt.sizeDelta = new Vector2(275.329895f, 8.000000f);
        }
        {
            var rt = goMap[-6168081303697248622L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(78.199997f, 14.800000f);
            rt.sizeDelta = new Vector2(130.000000f, 37.000000f);
        }
        {
            var rt = goMap[-3653557486982773188L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.800000f, 0.800000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(245.199997f, 6.762200f);
            rt.sizeDelta = new Vector2(427.230011f, 66.651497f);
        }
        {
            var rt = goMap[3869749892591518472L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.000031f, 0.000000f);
            rt.sizeDelta = new Vector2(427.230011f, 66.651497f);
        }
        {
            var rt = goMap[-4315081264153127850L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.250000f, 1.250000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(0.000000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(5.990005f, -8.452759f);
            rt.sizeDelta = new Vector2(53.766701f, 37.000000f);
        }
        {
            var rt = goMap[5441594349541672554L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.250000f, 1.250000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(0.000000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(60.240005f, 11.172259f);
            rt.sizeDelta = new Vector2(65.997299f, 37.000000f);
        }
        {
            var rt = goMap[3240874650805179739L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.250000f, 1.250000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(35.618942f, -8.452759f);
            rt.sizeDelta = new Vector2(284.786713f, 30.000000f);
        }
        {
            var rt = goMap[-2476595509888812582L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-2.029300f, -1.501300f);
            rt.sizeDelta = new Vector2(276.741394f, 9.947500f);
        }
        {
            var rt = goMap[-3100651814891294229L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-138.987656f, -1.501286f);
            rt.sizeDelta = new Vector2(275.329895f, 8.000000f);
        }
        {
            var rt = goMap[3434687367049390774L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(78.199997f, 14.800000f);
            rt.sizeDelta = new Vector2(130.000000f, 37.000000f);
        }
        {
            var rt = goMap[-534171021608326641L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-7.800000f, -110.099998f);
            rt.sizeDelta = new Vector2(800.000000f, 30.000000f);
        }
        {
            var rt = goMap[1383814936887046630L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.800000f, 0.800000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-209.000000f, 6.762200f);
            rt.sizeDelta = new Vector2(427.230011f, 66.651497f);
        }
        {
            var rt = goMap[8035279643546325816L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.000031f, 0.000000f);
            rt.sizeDelta = new Vector2(427.230011f, 66.651497f);
        }
        {
            var rt = goMap[6520388031762645846L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.250000f, 1.250000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(0.000000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(5.990005f, -8.452759f);
            rt.sizeDelta = new Vector2(53.766701f, 37.000000f);
        }
        {
            var rt = goMap[2814609402373077280L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.250000f, 1.250000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(0.000000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(60.240005f, 11.172259f);
            rt.sizeDelta = new Vector2(65.997299f, 37.000000f);
        }
        {
            var rt = goMap[-3843895827321818733L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.250000f, 1.250000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(35.618942f, -8.452759f);
            rt.sizeDelta = new Vector2(284.786713f, 30.000000f);
        }
        {
            var rt = goMap[-4150256370293658522L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-2.029300f, -1.501300f);
            rt.sizeDelta = new Vector2(276.741394f, 9.947500f);
        }
        {
            var rt = goMap[4747953812791310495L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-138.987656f, -1.501286f);
            rt.sizeDelta = new Vector2(275.329895f, 8.000000f);
        }
        {
            var rt = goMap[-6236220478818438188L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(78.199997f, 14.800000f);
            rt.sizeDelta = new Vector2(130.000000f, 37.000000f);
        }
        {
            var rt = goMap[8246076380788931812L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.800000f, 0.800000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(245.199997f, 6.762200f);
            rt.sizeDelta = new Vector2(427.230011f, 66.651497f);
        }
        {
            var rt = goMap[-2100433758910331870L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.000031f, 0.000000f);
            rt.sizeDelta = new Vector2(427.230011f, 66.651497f);
        }
        {
            var rt = goMap[6395141748899658570L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.250000f, 1.250000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(0.000000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(5.990005f, -8.452759f);
            rt.sizeDelta = new Vector2(53.766701f, 37.000000f);
        }
        {
            var rt = goMap[1700776221948875682L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.250000f, 1.250000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(0.000000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(60.240005f, 11.172259f);
            rt.sizeDelta = new Vector2(65.997299f, 37.000000f);
        }
        {
            var rt = goMap[4740736687452161246L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.250000f, 1.250000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(35.618942f, -8.452759f);
            rt.sizeDelta = new Vector2(284.786713f, 30.000000f);
        }
        {
            var rt = goMap[647037677680005221L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-2.029300f, -1.501300f);
            rt.sizeDelta = new Vector2(276.741394f, 9.947500f);
        }
        {
            var rt = goMap[6049515899158543199L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-138.987656f, -1.501286f);
            rt.sizeDelta = new Vector2(275.329895f, 8.000000f);
        }
        {
            var rt = goMap[-6198246070162060933L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(78.199997f, 14.800000f);
            rt.sizeDelta = new Vector2(130.000000f, 37.000000f);
        }
        {
            var rt = goMap[5402941593196120952L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000122f, -149.000000f);
            rt.sizeDelta = new Vector2(800.000000f, 114.467903f);
        }
        {
            var rt = goMap[-7475118935421058513L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(218.000000f, -15.200000f);
            rt.sizeDelta = new Vector2(300.000000f, 40.000000f);
        }
        {
            var rt = goMap[-3551964480073841159L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-176.000000f, -15.599991f);
            rt.sizeDelta = new Vector2(350.000000f, 40.000000f);
        }
        {
            var rt = goMap[3830738052779403065L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 40.000000f);
        }
        {
            var rt = goMap[997699912737467909L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(130.000000f, 40.000000f);
        }
        {
            var rt = goMap[-5264890917061130999L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 40.000000f);
        }
        {
            var rt = goMap[3462981794034216428L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(4.200000f, -221.899994f);
            rt.sizeDelta = new Vector2(144.000000f, 52.000000f);
        }
        {
            var rt = goMap[7974511670011937539L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 3.000000f);
            rt.sizeDelta = new Vector2(144.000000f, 40.000000f);
        }
        {
            var rt = goMap[8996515339600885042L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000122f, -127.400002f);
            rt.sizeDelta = new Vector2(150.000000f, 40.000000f);
        }
        {
            var rt = goMap[-366285291519699992L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(233.041840f, 0.000000f);
            rt.sizeDelta = new Vector2(310.000000f, 15.000000f);
        }
        {
            var rt = goMap[-5663598520975234286L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,1.000000f,0.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-233.041794f, 0.000000f);
            rt.sizeDelta = new Vector2(310.000000f, 15.000000f);
        }
        {
            var rt = goMap[-3218270996477689853L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(229.000000f, 11.000000f);
            rt.sizeDelta = new Vector2(302.000000f, 182.000000f);
        }
        {
            var rt = goMap[-6323258045011492572L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -164.300003f);
            rt.sizeDelta = new Vector2(600.000000f, 40.000000f);
        }

        // ─── Components ──────────────────────────────────────
        { var c = goMap[3234735537922300143L].AddComponent<Canvas>();
           c.renderMode = (RenderMode)1;
           c.overrideSorting = false;
           c.sortingOrder = 0;
           c.sortingLayerID = unchecked((int)194136777);
           c.planeDistance = 100.000000f;
           c.pixelPerfect = false;
           c.additionalShaderChannels = (AdditionalCanvasShaderChannels)0;
           c.enabled = true;
        }
        { var c = goMap[3234735537922300143L].AddComponent<CanvasScaler>();
           c.uiScaleMode = (CanvasScaler.ScaleMode)1;
           c.referenceResolution = new Vector2(1280.000000f, 720.000000f);
           c.screenMatchMode = (CanvasScaler.ScreenMatchMode)1;
           c.matchWidthOrHeight = 0.000000f;
           c.referencePixelsPerUnit = 100.000000f;
        }
        { var c = goMap[3234735537922300143L].AddComponent<GraphicRaycaster>();
           c.ignoreReversedGraphics = true;
        }
        { var c = goMap[3234735537922300143L].AddComponent<Image>();
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
        { var c = goMap[4055871074233093091L].AddComponent<CanvasGroup>();
           c.alpha = 1.000000f;
           c.interactable = true;
           c.blocksRaycasts = true;
           c.ignoreParentGroups = false;
        }
        { var c = goMap[3938092759976508898L].AddComponent<Image>();
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
        { var c = goMap[5446201502268030719L].AddComponent<Image>();
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
        { var c = goMap[-7648232724668134389L].AddComponent<Image>();
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
        { var c = goMap[-6195448894422624557L].AddComponent<Image>();
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
        { var c = goMap[-1293367365699253638L].AddComponent<Image>();
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
        { var c = goMap[5467965228140875103L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[4247749607033715472L].AddComponent<Image>();
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
        { var c = goMap[2308658377850910961L].AddComponent<Image>();
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
        { var c = goMap[595231751789470271L].AddComponent<Image>();
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
        { var c = goMap[-704710079963207697L].AddComponent<Image>();
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
        { var c = goMap[-8776721450332639076L].AddComponent<Image>();
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
        { var c = goMap[-5065673131270198913L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-3215921739427355339L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[5757726401891543646L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[5757726401891543646L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[5757726401891543646L].AddComponent<UIScalePulse>();
           c.upScale = 0.950000f; c.duration = 0.100000f; c.scaleUp = false;
           c.enabled = true;
        }
        { var c = goMap[6816598455657616683L].AddComponent<Text>();
           c.text = "2743";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 26;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleLeft;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 222;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[5753481503304624134L].AddComponent<Text>();
           c.text = "8115";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
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
        { var c = goMap[-1611104360110124102L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("Cmn_Star02");
        }
        { var c = goMap[6819502722847958907L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("Cmn_Star01");
        }
        { var c = goMap[-6426709608600509360L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("Cmn_Star02");
        }
        { var c = goMap[-5154651572578956940L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("Cmn_Star01");
        }
        { var c = goMap[8851085592277010826L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("Cmn_Star02");
        }
        { var c = goMap[8980479324127867904L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("Cmn_Star01");
        }
        { var c = goMap[-2550632027926656290L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("Cmn_Star02");
        }
        { var c = goMap[-6154697379434018567L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("Cmn_Star01");
        }
        { var c = goMap[-462465019854132157L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("Cmn_Star02");
        }
        { var c = goMap[-7512650144178068486L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("Cmn_Star01");
        }
        { var c = goMap[-7490405748862311908L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("Cmn_Star02");
        }
        { var c = goMap[-1248926478434573238L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("Cmn_Star01");
        }
        { var c = goMap[-7131017960517302066L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("Cmn_Star02");
        }
        { var c = goMap[483337742469751541L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("Cmn_Star01");
        }
        { var c = goMap[354385634602601588L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("Cmn_Star02");
        }
        { var c = goMap[77193653939337239L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("Cmn_Star01");
        }
        { var c = goMap[-1120722393036109054L].AddComponent<Text>();
           c.text = "6866";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
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
        { var c = goMap[-6135853244126971360L].AddComponent<Text>();
           c.text = "14360";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
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
        { var c = goMap[-4329932287692243318L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_listbg2");
        }
        { var c = goMap[-1115738949101879851L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_listbg2");
        }
        { var c = goMap[7667147277450260804L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_reborn_arrow");
        }
        { var c = goMap[6510247877017047373L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[4709012764903896606L].AddComponent<Image>();
           c.color = new Color(0.843137f, 0.843137f, 0.807843f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[220127819256391290L].AddComponent<Text>();
           c.text = "8507";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
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
        { var c = goMap[-3776758144051738292L].AddComponent<Text>();
           c.text = "1852";
           c.color = new Color(0.427451f, 0.019608f, 0.772549f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 8;
           c.resizeTextMaxSize = 18;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-4985048016744411627L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-6666573820160454681L].AddComponent<Image>();
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
        { var c = goMap[-3928363599584786902L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_partner_StartUp_slider");
        }
        { var c = goMap[-4755570678986020043L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(0.329412f, 0.670588f, 0.301961f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 8;
           c.resizeTextMaxSize = 18;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-5903351347500995990L].AddComponent<Image>();
           c.color = new Color(0.843137f, 0.843137f, 0.807843f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-2389380717241017990L].AddComponent<Text>();
           c.text = "8507";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
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
        { var c = goMap[5266550835561992563L].AddComponent<Text>();
           c.text = "1852";
           c.color = new Color(0.427451f, 0.019608f, 0.772549f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 8;
           c.resizeTextMaxSize = 18;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-3773734049788244556L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[7011586862414228360L].AddComponent<Image>();
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
        { var c = goMap[-7027404975942066462L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_partner_StartUp_slider");
        }
        { var c = goMap[-4263394293975780911L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(0.329412f, 0.670588f, 0.301961f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 8;
           c.resizeTextMaxSize = 18;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-7115643980146951185L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[3347868991075693914L].AddComponent<Image>();
           c.color = new Color(0.843137f, 0.843137f, 0.807843f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[4008234521411931872L].AddComponent<Text>();
           c.text = "4293";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
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
        { var c = goMap[-5336356145618509422L].AddComponent<Text>();
           c.text = "1852";
           c.color = new Color(0.427451f, 0.019608f, 0.772549f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 8;
           c.resizeTextMaxSize = 18;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[5779641546417794848L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[7557798947104825702L].AddComponent<Image>();
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
        { var c = goMap[-513533972849856645L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_partner_StartUp_slider");
        }
        { var c = goMap[3534624205430497742L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(0.329412f, 0.670588f, 0.301961f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 8;
           c.resizeTextMaxSize = 18;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[9023064107338188402L].AddComponent<Image>();
           c.color = new Color(0.843137f, 0.843137f, 0.807843f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-2266729908282950782L].AddComponent<Text>();
           c.text = "4293";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
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
        { var c = goMap[2715245157730404675L].AddComponent<Text>();
           c.text = "1852";
           c.color = new Color(0.427451f, 0.019608f, 0.772549f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 8;
           c.resizeTextMaxSize = 18;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[1191044516803501369L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[5861201471266805240L].AddComponent<Image>();
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
        { var c = goMap[883732059803775364L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_partner_StartUp_slider");
        }
        { var c = goMap[-5278553939604487587L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(0.329412f, 0.670588f, 0.301961f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 8;
           c.resizeTextMaxSize = 18;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-257558248621476368L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[2859973957070342304L].AddComponent<Image>();
           c.color = new Color(0.843137f, 0.843137f, 0.807843f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-5855475892591408286L].AddComponent<Text>();
           c.text = "5265";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
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
        { var c = goMap[8335626354727567372L].AddComponent<Text>();
           c.text = "1852";
           c.color = new Color(0.427451f, 0.019608f, 0.772549f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 8;
           c.resizeTextMaxSize = 18;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-7786233064560093558L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[8069096253605241694L].AddComponent<Image>();
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
        { var c = goMap[-5328210617609593739L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_partner_StartUp_slider");
        }
        { var c = goMap[-6168081303697248622L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(0.329412f, 0.670588f, 0.301961f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 8;
           c.resizeTextMaxSize = 18;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[3869749892591518472L].AddComponent<Image>();
           c.color = new Color(0.843137f, 0.843137f, 0.807843f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-4315081264153127850L].AddComponent<Text>();
           c.text = "5265";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
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
        { var c = goMap[5441594349541672554L].AddComponent<Text>();
           c.text = "1852";
           c.color = new Color(0.427451f, 0.019608f, 0.772549f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 8;
           c.resizeTextMaxSize = 18;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[3240874650805179739L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-2476595509888812582L].AddComponent<Image>();
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
        { var c = goMap[-3100651814891294229L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_partner_StartUp_slider");
        }
        { var c = goMap[3434687367049390774L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(0.329412f, 0.670588f, 0.301961f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 8;
           c.resizeTextMaxSize = 18;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-534171021608326641L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[8035279643546325816L].AddComponent<Image>();
           c.color = new Color(0.843137f, 0.843137f, 0.807843f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[6520388031762645846L].AddComponent<Text>();
           c.text = "7532";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
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
        { var c = goMap[2814609402373077280L].AddComponent<Text>();
           c.text = "1852";
           c.color = new Color(0.427451f, 0.019608f, 0.772549f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 8;
           c.resizeTextMaxSize = 18;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-3843895827321818733L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-4150256370293658522L].AddComponent<Image>();
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
        { var c = goMap[4747953812791310495L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_partner_StartUp_slider");
        }
        { var c = goMap[-6236220478818438188L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(0.329412f, 0.670588f, 0.301961f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 8;
           c.resizeTextMaxSize = 18;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-2100433758910331870L].AddComponent<Image>();
           c.color = new Color(0.843137f, 0.843137f, 0.807843f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[6395141748899658570L].AddComponent<Text>();
           c.text = "7532";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
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
        { var c = goMap[1700776221948875682L].AddComponent<Text>();
           c.text = "1852";
           c.color = new Color(0.427451f, 0.019608f, 0.772549f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 8;
           c.resizeTextMaxSize = 18;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[4740736687452161246L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[647037677680005221L].AddComponent<Image>();
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
        { var c = goMap[6049515899158543199L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_partner_StartUp_slider");
        }
        { var c = goMap[-6198246070162060933L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(0.329412f, 0.670588f, 0.301961f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 8;
           c.resizeTextMaxSize = 18;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-7475118935421058513L].AddComponent<Text>();
           c.text = "1573";
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
           c.resizeTextMinSize = 10;
           c.resizeTextMaxSize = 20;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-3551964480073841159L].AddComponent<HorizontalLayoutGroup>();
           c.padding = new RectOffset(0,0,0,0);
           c.spacing = 0.000000f;
           c.childAlignment = (TextAnchor)0;
           c.childForceExpandWidth = false;
           c.childForceExpandHeight = false;
           c.childControlWidth = false;
           c.childControlHeight = false;
           c.reverseArrangement = false;
        }
        { var c = goMap[3830738052779403065L].AddComponent<Text>();
           c.text = "6481";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleRight;
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
        { var c = goMap[997699912737467909L].AddComponent<Text>();
           c.text = "7004";
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
           c.resizeTextMinSize = 10;
           c.resizeTextMaxSize = 20;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-5264890917061130999L].AddComponent<Text>();
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
           c.resizeTextMinSize = 10;
           c.resizeTextMaxSize = 20;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[3462981794034216428L].AddComponent<Image>();
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
        { var c = goMap[3462981794034216428L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[3462981794034216428L].AddComponent<UIScalePulse>();
           c.upScale = 0.950000f; c.duration = 0.100000f; c.scaleUp = false;
           c.enabled = true;
        }
        { var c = goMap[7974511670011937539L].AddComponent<Text>();
           c.text = "10323";
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
           c.resizeTextMinSize = 12;
           c.resizeTextMaxSize = 22;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[8996515339600885042L].AddComponent<Text>();
           c.text = "15438";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
           c.fontSize = 22;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
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
        { var c = goMap[-366285291519699992L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_title_line");
        }
        { var c = goMap[-5663598520975234286L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_title_line");
        }
        { var c = goMap[-3218270996477689853L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-6323258045011492572L].AddComponent<Text>();
           c.text = "836";
           c.color = new Color(0.301961f, 0.250980f, 0.203922f, 1.000000f);
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

        // ─── Resolve Toggle → ToggleGroup links ─────────────
        foreach (var kv in _toggleGroupLinks)
        {
            ToggleGroup grp;
            if (_toggleGroupByMbPid.TryGetValue(kv.Item2, out grp) && grp != null)
                kv.Item1.group = grp;
        }

        // ─── Save prefab ─────────────────────────────────────
        Directory.CreateDirectory("Assets/Prefabs/Imported");
        var rootGO = goMap[3234735537922300143L];
        string path = "Assets/Prefabs/Imported/UIPartnerStarsUp.prefab";
        PrefabUtility.SaveAsPrefabAsset(rootGO, path);
        Object.DestroyImmediate(rootGO);
        Debug.Log("[Import_res_p_166] Saved " + path);
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