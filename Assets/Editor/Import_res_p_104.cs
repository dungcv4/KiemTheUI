// AUTO-GENERATED from res_p_104.ab — DO NOT EDIT MANUALLY.
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;
using System.Collections.Generic;

public class Import_res_p_104
{
    [MenuItem("KTO/Import/res_p_104")]
    public static void Build()
    {
        Debug.Log("[Import_res_p_104] Building UIHudRightSkill...");

        // ─── Create all GameObjects ───────────────────────────
        var goMap = new Dictionary<long, GameObject>();
        { var go = new GameObject("UIHudRightSkill"); go.SetActive(true); goMap[-505170310806722818L] = go; }
        { var go = new GameObject("imgBG"); go.SetActive(true); goMap[4698399892616113384L] = go; }
        { var go = new GameObject("skillbg"); go.SetActive(true); goMap[6614476112898934457L] = go; }
        { var go = new GameObject("btnSkill1"); go.SetActive(true); goMap[-4604452676421208745L] = go; }
        { var go = new GameObject("skillImage"); go.SetActive(true); goMap[-2680578444748262782L] = go; }
        { var go = new GameObject("CD"); go.SetActive(true); goMap[6011512065163492639L] = go; }
        { var go = new GameObject("CDText"); go.SetActive(true); goMap[7964270623288650510L] = go; }
        { var go = new GameObject("CDUsePoint"); go.SetActive(true); goMap[-3895230867223739866L] = go; }
        { var go = new GameObject("DisableMask"); go.SetActive(true); goMap[2876419161059730916L] = go; }
        { var go = new GameObject("anniutishi"); go.SetActive(true); goMap[2234209710887717732L] = go; }
        { var go = new GameObject("DianJi_Effcet"); go.SetActive(true); goMap[5445459157699617503L] = go; }
        { var go = new GameObject("SkillCD_Effect"); go.SetActive(false); goMap[-1747304736232977427L] = go; }
        { var go = new GameObject("WenLi"); go.SetActive(false); goMap[8056385823319411269L] = go; }
        { var go = new GameObject("GuangHuan"); go.SetActive(false); goMap[2082492290192657099L] = go; }
        { var go = new GameObject("ShanGuang"); go.SetActive(true); goMap[2745937564456138383L] = go; }
        { var go = new GameObject("GuangHuan_02"); go.SetActive(false); goMap[-8829613399954042692L] = go; }
        { var go = new GameObject("LiZi"); go.SetActive(false); goMap[7273765070698045380L] = go; }
        { var go = new GameObject("CDUsePointText"); go.SetActive(false); goMap[-8761686395194708583L] = go; }
        { var go = new GameObject("KeyboardMark"); go.SetActive(false); goMap[1284148003858496349L] = go; }
        { var go = new GameObject("K"); go.SetActive(true); goMap[8046156967202809136L] = go; }
        { var go = new GameObject("btnSkill2"); go.SetActive(true); goMap[-8540440773408584456L] = go; }
        { var go = new GameObject("skillImage"); go.SetActive(true); goMap[6345776855776289053L] = go; }
        { var go = new GameObject("CD"); go.SetActive(true); goMap[8664323072091333941L] = go; }
        { var go = new GameObject("CDText"); go.SetActive(true); goMap[2449636839759187966L] = go; }
        { var go = new GameObject("CDUsePoint"); go.SetActive(false); goMap[-6959205323960115395L] = go; }
        { var go = new GameObject("DisableMask"); go.SetActive(true); goMap[199505377505860908L] = go; }
        { var go = new GameObject("anniutishi"); go.SetActive(true); goMap[6945721822077407099L] = go; }
        { var go = new GameObject("DianJi_Effcet"); go.SetActive(true); goMap[7203396946151232821L] = go; }
        { var go = new GameObject("SkillCD_Effect"); go.SetActive(true); goMap[1266127606291743594L] = go; }
        { var go = new GameObject("WenLi"); go.SetActive(false); goMap[2036885841429208173L] = go; }
        { var go = new GameObject("GuangHuan"); go.SetActive(false); goMap[-3399623518800077152L] = go; }
        { var go = new GameObject("ShanGuang"); go.SetActive(false); goMap[249239059067498757L] = go; }
        { var go = new GameObject("GuangHuan_02"); go.SetActive(false); goMap[7869158589290998247L] = go; }
        { var go = new GameObject("LiZi"); go.SetActive(false); goMap[-6058926132351280345L] = go; }
        { var go = new GameObject("CDUsePointText"); go.SetActive(false); goMap[-15665877420440777L] = go; }
        { var go = new GameObject("SkillLock"); go.SetActive(false); goMap[3328037334421634240L] = go; }
        { var go = new GameObject("txtUnlockLv"); go.SetActive(true); goMap[-979150597126615511L] = go; }
        { var go = new GameObject("imgLock"); go.SetActive(true); goMap[-265349486119821339L] = go; }
        { var go = new GameObject("KeyboardMark"); go.SetActive(false); goMap[3625351349849309683L] = go; }
        { var go = new GameObject("J"); go.SetActive(true); goMap[4636618231479330903L] = go; }
        { var go = new GameObject("btnSkill3"); go.SetActive(true); goMap[-7803727915772642997L] = go; }
        { var go = new GameObject("skillImage"); go.SetActive(true); goMap[-449172240975439368L] = go; }
        { var go = new GameObject("CD"); go.SetActive(true); goMap[6299711269936610943L] = go; }
        { var go = new GameObject("CDText"); go.SetActive(true); goMap[8433658555559819024L] = go; }
        { var go = new GameObject("CDUsePoint"); go.SetActive(true); goMap[-1842976861392890942L] = go; }
        { var go = new GameObject("DisableMask"); go.SetActive(true); goMap[-8379789711243744906L] = go; }
        { var go = new GameObject("anniutishi"); go.SetActive(true); goMap[8939028338081513303L] = go; }
        { var go = new GameObject("DianJi_Effcet"); go.SetActive(true); goMap[289467459231244894L] = go; }
        { var go = new GameObject("SkillCD_Effect"); go.SetActive(true); goMap[-3545418426772144902L] = go; }
        { var go = new GameObject("WenLi"); go.SetActive(false); goMap[-7993715888132882694L] = go; }
        { var go = new GameObject("GuangHuan"); go.SetActive(false); goMap[-3580709414101683427L] = go; }
        { var go = new GameObject("ShanGuang"); go.SetActive(false); goMap[-5248780366737210739L] = go; }
        { var go = new GameObject("GuangHuan_02"); go.SetActive(false); goMap[-3502493453048510569L] = go; }
        { var go = new GameObject("LiZi"); go.SetActive(false); goMap[3647326049221342511L] = go; }
        { var go = new GameObject("CDUsePointText"); go.SetActive(false); goMap[-598345772288120282L] = go; }
        { var go = new GameObject("SkillLock"); go.SetActive(false); goMap[5284080190253727684L] = go; }
        { var go = new GameObject("txtUnlockLv"); go.SetActive(true); goMap[7640045321075754472L] = go; }
        { var go = new GameObject("imgLock"); go.SetActive(true); goMap[7385614178626317774L] = go; }
        { var go = new GameObject("KeyboardMark"); go.SetActive(false); goMap[6264083292714672059L] = go; }
        { var go = new GameObject("U"); go.SetActive(true); goMap[207114240030905289L] = go; }
        { var go = new GameObject("btnSkill4"); go.SetActive(true); goMap[2060706012100672974L] = go; }
        { var go = new GameObject("skillImage"); go.SetActive(true); goMap[7969729691420640968L] = go; }
        { var go = new GameObject("CD"); go.SetActive(true); goMap[-486569995512691673L] = go; }
        { var go = new GameObject("CDText"); go.SetActive(true); goMap[-6754545847898296918L] = go; }
        { var go = new GameObject("CDUsePoint"); go.SetActive(false); goMap[-264871016208571780L] = go; }
        { var go = new GameObject("DisableMask"); go.SetActive(true); goMap[-6724259936573054453L] = go; }
        { var go = new GameObject("anniutishi"); go.SetActive(true); goMap[59867554037438608L] = go; }
        { var go = new GameObject("DianJi_Effcet"); go.SetActive(true); goMap[1910503912913282468L] = go; }
        { var go = new GameObject("SkillCD_Effect"); go.SetActive(true); goMap[1210638632862834481L] = go; }
        { var go = new GameObject("WenLi"); go.SetActive(false); goMap[-4761095439515878733L] = go; }
        { var go = new GameObject("GuangHuan"); go.SetActive(false); goMap[3350033018248533789L] = go; }
        { var go = new GameObject("ShanGuang"); go.SetActive(false); goMap[9206473817135465796L] = go; }
        { var go = new GameObject("GuangHuan_02"); go.SetActive(false); goMap[-1461000065812277394L] = go; }
        { var go = new GameObject("LiZi"); go.SetActive(false); goMap[-6768118514839040703L] = go; }
        { var go = new GameObject("CDUsePointText"); go.SetActive(false); goMap[3516665418004474092L] = go; }
        { var go = new GameObject("SkillLock"); go.SetActive(false); goMap[-8024281324226479849L] = go; }
        { var go = new GameObject("txtUnlockLv"); go.SetActive(true); goMap[-4907494804830526061L] = go; }
        { var go = new GameObject("imgLock"); go.SetActive(true); goMap[-8859214668307593655L] = go; }
        { var go = new GameObject("KeyboardMark"); go.SetActive(false); goMap[9063958857194198518L] = go; }
        { var go = new GameObject("I"); go.SetActive(true); goMap[-6063926043197739696L] = go; }
        { var go = new GameObject("btnSkill5"); go.SetActive(true); goMap[6808388302714695786L] = go; }
        { var go = new GameObject("skillImage"); go.SetActive(true); goMap[-4803598202576356995L] = go; }
        { var go = new GameObject("CD"); go.SetActive(true); goMap[-6514676742962530142L] = go; }
        { var go = new GameObject("CDText"); go.SetActive(true); goMap[5092884888898161205L] = go; }
        { var go = new GameObject("CDUsePoint"); go.SetActive(false); goMap[-4684606610209150593L] = go; }
        { var go = new GameObject("DisableMask"); go.SetActive(true); goMap[6025753770910659253L] = go; }
        { var go = new GameObject("anniutishi"); go.SetActive(true); goMap[3513392338288642055L] = go; }
        { var go = new GameObject("DianJi_Effcet"); go.SetActive(true); goMap[-3015592765155141529L] = go; }
        { var go = new GameObject("SkillCD_Effect"); go.SetActive(true); goMap[-2601224623691635625L] = go; }
        { var go = new GameObject("WenLi"); go.SetActive(false); goMap[-2195744494476524971L] = go; }
        { var go = new GameObject("GuangHuan"); go.SetActive(false); goMap[4964056629560570117L] = go; }
        { var go = new GameObject("ShanGuang"); go.SetActive(false); goMap[3059679146024846085L] = go; }
        { var go = new GameObject("GuangHuan_02"); go.SetActive(false); goMap[-9118257563414759432L] = go; }
        { var go = new GameObject("LiZi"); go.SetActive(false); goMap[-5183325016508861198L] = go; }
        { var go = new GameObject("CDUsePointText"); go.SetActive(false); goMap[5292784270193578425L] = go; }
        { var go = new GameObject("SkillLock"); go.SetActive(false); goMap[-8904457033452487952L] = go; }
        { var go = new GameObject("txtUnlockLv"); go.SetActive(true); goMap[5195321321574292861L] = go; }
        { var go = new GameObject("imgLock"); go.SetActive(true); goMap[-2052208102064299634L] = go; }
        { var go = new GameObject("KeyboardMark"); go.SetActive(false); goMap[5311371466097208087L] = go; }
        { var go = new GameObject("O"); go.SetActive(true); goMap[4104077730807241263L] = go; }
        { var go = new GameObject("TongCamp"); go.SetActive(false); goMap[3288634337615831791L] = go; }
        { var go = new GameObject("btnTongMode"); go.SetActive(true); goMap[3724969905040145829L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[2285784354919624874L] = go; }
        { var go = new GameObject("imgMask"); go.SetActive(false); goMap[-6183717179574427006L] = go; }
        { var go = new GameObject("imgMaskUsePoint"); go.SetActive(false); goMap[-6317327717682246726L] = go; }
        { var go = new GameObject("txtBuffTime"); go.SetActive(false); goMap[1570330872980603920L] = go; }
        { var go = new GameObject("txtBuffTimeUsePoint"); go.SetActive(false); goMap[6300241840580095445L] = go; }
        { var go = new GameObject("btnJustice"); go.SetActive(true); goMap[7409389323368433024L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-765153702701176898L] = go; }
        { var go = new GameObject("imgMask"); go.SetActive(false); goMap[-6527691034233822723L] = go; }
        { var go = new GameObject("imgMaskUsePoint"); go.SetActive(false); goMap[6558214718643765950L] = go; }
        { var go = new GameObject("txtBuffTime"); go.SetActive(false); goMap[-6171738257053796066L] = go; }
        { var go = new GameObject("txtBuffTimeUsePoint"); go.SetActive(false); goMap[-4972747254247415717L] = go; }
        { var go = new GameObject("btnNeutrality"); go.SetActive(true); goMap[2022348217077567644L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[5307649616257537927L] = go; }
        { var go = new GameObject("imgMask"); go.SetActive(false); goMap[-8328865442789105240L] = go; }
        { var go = new GameObject("imgMaskUsePoint"); go.SetActive(false); goMap[4525060424070368289L] = go; }
        { var go = new GameObject("txtBuffTime"); go.SetActive(false); goMap[-3337763184212787673L] = go; }
        { var go = new GameObject("txtBuffTimeUsePoint"); go.SetActive(false); goMap[-2559392933116311911L] = go; }
        { var go = new GameObject("btnEvil"); go.SetActive(true); goMap[-2644452386813790099L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[5751900236404203427L] = go; }
        { var go = new GameObject("imgMask"); go.SetActive(false); goMap[2904770196660660045L] = go; }
        { var go = new GameObject("imgMaskUsePoint"); go.SetActive(false); goMap[5770348884974793421L] = go; }
        { var go = new GameObject("txtBuffTime"); go.SetActive(false); goMap[-8676323578187220487L] = go; }
        { var go = new GameObject("txtBuffTimeUsePoint"); go.SetActive(false); goMap[-2226849749700380895L] = go; }
        { var go = new GameObject("ManualSkillCaster"); go.SetActive(false); goMap[834687017711717292L] = go; }
        { var go = new GameObject("DebugDot"); go.SetActive(false); goMap[2748308880132554528L] = go; }
        { var go = new GameObject("DebugDot (1)"); go.SetActive(false); goMap[-3031763653391634264L] = go; }
        { var go = new GameObject("DebugDot (2)"); go.SetActive(true); goMap[7012829260713158418L] = go; }
        { var go = new GameObject("btnCancer"); go.SetActive(true); goMap[-8141538957844588804L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[2183930071166712069L] = go; }
        { var go = new GameObject("btnMedicine"); go.SetActive(true); goMap[-3202376101565362456L] = go; }
        { var go = new GameObject("skillImage"); go.SetActive(true); goMap[-6152790527035529764L] = go; }
        { var go = new GameObject("CD"); go.SetActive(false); goMap[-1847392839987607762L] = go; }
        { var go = new GameObject("CDText"); go.SetActive(false); goMap[-7656686862451681279L] = go; }
        { var go = new GameObject("CDUsePoint"); go.SetActive(false); goMap[3824338068560615823L] = go; }
        { var go = new GameObject("CDUsePointText"); go.SetActive(false); goMap[-6922416529777263049L] = go; }
        { var go = new GameObject("imgBlack"); go.SetActive(false); goMap[68091241504638832L] = go; }
        { var go = new GameObject("imgPlus"); go.SetActive(false); goMap[5799186231942803867L] = go; }
        { var go = new GameObject("txtMedicineCount"); go.SetActive(true); goMap[-3117298033521374793L] = go; }
        { var go = new GameObject("anniutishi"); go.SetActive(true); goMap[-4716074784255749072L] = go; }
        { var go = new GameObject("DianJi_Effcet"); go.SetActive(true); goMap[-6750949985260853050L] = go; }
        { var go = new GameObject("SkillCD_Effect"); go.SetActive(false); goMap[284415134558256666L] = go; }
        { var go = new GameObject("WenLi"); go.SetActive(false); goMap[-3350807390247092236L] = go; }
        { var go = new GameObject("GuangHuan"); go.SetActive(false); goMap[-6704101358884667490L] = go; }
        { var go = new GameObject("ShanGuang"); go.SetActive(false); goMap[631353528465912324L] = go; }
        { var go = new GameObject("GuangHuan_02"); go.SetActive(false); goMap[8054732902888111815L] = go; }
        { var go = new GameObject("LiZi"); go.SetActive(false); goMap[-2809562510682158786L] = go; }
        { var go = new GameObject("DisableMask"); go.SetActive(false); goMap[9084154749753190381L] = go; }
        { var go = new GameObject("KeyboardMark"); go.SetActive(false); goMap[2204507256174152521L] = go; }
        { var go = new GameObject("H"); go.SetActive(true); goMap[-2841585352275090228L] = go; }
        { var go = new GameObject("btnAuto"); go.SetActive(true); goMap[6448561864505022193L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[265972771125574157L] = go; }
        { var go = new GameObject("KeyboardMark"); go.SetActive(false); goMap[-8965038464424305431L] = go; }
        { var go = new GameObject("F"); go.SetActive(true); goMap[-6352839020668222238L] = go; }
        { var go = new GameObject("btnManual"); go.SetActive(true); goMap[3535413626053756433L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-5245693610933703615L] = go; }
        { var go = new GameObject("Manual_Effect"); go.SetActive(true); goMap[7750029830297870049L] = go; }
        { var go = new GameObject("LiuGuang"); go.SetActive(true); goMap[-5163150904620973056L] = go; }
        { var go = new GameObject("Glow"); go.SetActive(true); goMap[-3458778223271688658L] = go; }
        { var go = new GameObject("GuangQuan"); go.SetActive(true); goMap[-6820728270903118545L] = go; }
        { var go = new GameObject("KeyboardMark"); go.SetActive(false); goMap[8742052578064954519L] = go; }
        { var go = new GameObject("F"); go.SetActive(true); goMap[-1790091547151766849L] = go; }
        { var go = new GameObject("btnJump"); go.SetActive(true); goMap[4913519792906914546L] = go; }
        { var go = new GameObject("skillImage"); go.SetActive(true); goMap[-9172179323496584541L] = go; }
        { var go = new GameObject("CD"); go.SetActive(true); goMap[8380223691777849941L] = go; }
        { var go = new GameObject("CDText"); go.SetActive(false); goMap[-101559371840674367L] = go; }
        { var go = new GameObject("CDUsePoint"); go.SetActive(false); goMap[-3240014703483295585L] = go; }
        { var go = new GameObject("CDUsePointText"); go.SetActive(true); goMap[4445052976092313583L] = go; }
        { var go = new GameObject("anniutishi"); go.SetActive(true); goMap[-3843530212429135637L] = go; }
        { var go = new GameObject("DianJi_Effcet"); go.SetActive(true); goMap[3690835674224919719L] = go; }
        { var go = new GameObject("SkillCD_Effect"); go.SetActive(true); goMap[8994061576271688309L] = go; }
        { var go = new GameObject("WenLi"); go.SetActive(false); goMap[3517732553139607850L] = go; }
        { var go = new GameObject("GuangHuan"); go.SetActive(false); goMap[2649650569271069276L] = go; }
        { var go = new GameObject("ShanGuang"); go.SetActive(false); goMap[5851375669707577472L] = go; }
        { var go = new GameObject("GuangHuan_02"); go.SetActive(false); goMap[7010681538041553242L] = go; }
        { var go = new GameObject("LiZi"); go.SetActive(false); goMap[-9183471573238676604L] = go; }
        { var go = new GameObject("KeyboardMark"); go.SetActive(false); goMap[4233185735053625867L] = go; }
        { var go = new GameObject("Space"); go.SetActive(true); goMap[-528258494804935527L] = go; }
        { var go = new GameObject("btnSkillLock"); go.SetActive(true); goMap[-9163990204722043384L] = go; }
        { var go = new GameObject("CD"); go.SetActive(true); goMap[-2397032916046080846L] = go; }
        { var go = new GameObject("CDText"); go.SetActive(false); goMap[-7872213626190719830L] = go; }
        { var go = new GameObject("CDUsePoint"); go.SetActive(false); goMap[7316762769053103884L] = go; }
        { var go = new GameObject("imgLock"); go.SetActive(true); goMap[-413135616190048636L] = go; }
        { var go = new GameObject("imgUnlock"); go.SetActive(false); goMap[8040436650192479410L] = go; }
        { var go = new GameObject("btnSkillLockHide"); go.SetActive(false); goMap[-7806845672604755148L] = go; }
        { var go = new GameObject("imgArrowClose"); go.SetActive(true); goMap[2653439226259348729L] = go; }
        { var go = new GameObject("imgArrowOpen"); go.SetActive(false); goMap[-3117203015968352357L] = go; }
        { var go = new GameObject("btnSwitchTarget"); go.SetActive(true); goMap[-3634240885161816432L] = go; }
        { var go = new GameObject("skillImage"); go.SetActive(true); goMap[1453364372587689086L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-3238541514736070332L] = go; }
        { var go = new GameObject("DisableMask"); go.SetActive(true); goMap[-604381086727030260L] = go; }
        { var go = new GameObject("KeyboardMark"); go.SetActive(false); goMap[-8431732466732635421L] = go; }
        { var go = new GameObject("Q"); go.SetActive(true); goMap[-5032876086891915949L] = go; }
        { var go = new GameObject("btnSkillMartialArts"); go.SetActive(false); goMap[-959899472340865441L] = go; }
        { var go = new GameObject("skillImage"); go.SetActive(true); goMap[3589094691956112967L] = go; }
        { var go = new GameObject("CD"); go.SetActive(true); goMap[5049302239516006484L] = go; }
        { var go = new GameObject("CDText"); go.SetActive(true); goMap[1956788135510404163L] = go; }
        { var go = new GameObject("CDUsePoint"); go.SetActive(false); goMap[5247181220983650622L] = go; }
        { var go = new GameObject("DisableMask"); go.SetActive(true); goMap[7745105872495901956L] = go; }
        { var go = new GameObject("anniutishi"); go.SetActive(true); goMap[-3885453583486018799L] = go; }
        { var go = new GameObject("DianJi_Effcet"); go.SetActive(true); goMap[-1912578136901788121L] = go; }
        { var go = new GameObject("SkillCD_Effect"); go.SetActive(true); goMap[-5545680676340924478L] = go; }
        { var go = new GameObject("WenLi"); go.SetActive(false); goMap[5509310581499754811L] = go; }
        { var go = new GameObject("GuangHuan"); go.SetActive(false); goMap[-4470304427137069547L] = go; }
        { var go = new GameObject("ShanGuang"); go.SetActive(false); goMap[2944573335004902959L] = go; }
        { var go = new GameObject("GuangHuan_02"); go.SetActive(false); goMap[8352736510745087549L] = go; }
        { var go = new GameObject("LiZi"); go.SetActive(false); goMap[5550209453617123674L] = go; }
        { var go = new GameObject("CDUsePointText"); go.SetActive(false); goMap[3039768255981816252L] = go; }
        { var go = new GameObject("SkillLock"); go.SetActive(false); goMap[3858957314487626227L] = go; }
        { var go = new GameObject("txtUnlockLv"); go.SetActive(true); goMap[8109975175002384414L] = go; }
        { var go = new GameObject("imgLock"); go.SetActive(true); goMap[-1161962047489786518L] = go; }
        { var go = new GameObject("KeyboardMark"); go.SetActive(false); goMap[1340200135462406413L] = go; }
        { var go = new GameObject("I"); go.SetActive(true); goMap[-1501922615769999554L] = go; }

        // ─── Parent links ─────────────────────────────────────
        goMap[4698399892616113384L].transform.SetParent(goMap[-505170310806722818L].transform, false);
        goMap[6614476112898934457L].transform.SetParent(goMap[4698399892616113384L].transform, false);
        goMap[-4604452676421208745L].transform.SetParent(goMap[4698399892616113384L].transform, false);
        goMap[-2680578444748262782L].transform.SetParent(goMap[-4604452676421208745L].transform, false);
        goMap[6011512065163492639L].transform.SetParent(goMap[-4604452676421208745L].transform, false);
        goMap[7964270623288650510L].transform.SetParent(goMap[-4604452676421208745L].transform, false);
        goMap[-3895230867223739866L].transform.SetParent(goMap[-4604452676421208745L].transform, false);
        goMap[2876419161059730916L].transform.SetParent(goMap[-4604452676421208745L].transform, false);
        goMap[2234209710887717732L].transform.SetParent(goMap[-4604452676421208745L].transform, false);
        goMap[5445459157699617503L].transform.SetParent(goMap[2234209710887717732L].transform, false);
        goMap[-1747304736232977427L].transform.SetParent(goMap[2234209710887717732L].transform, false);
        goMap[8056385823319411269L].transform.SetParent(goMap[-1747304736232977427L].transform, false);
        goMap[2082492290192657099L].transform.SetParent(goMap[-1747304736232977427L].transform, false);
        goMap[2745937564456138383L].transform.SetParent(goMap[-1747304736232977427L].transform, false);
        goMap[-8829613399954042692L].transform.SetParent(goMap[-1747304736232977427L].transform, false);
        goMap[7273765070698045380L].transform.SetParent(goMap[-1747304736232977427L].transform, false);
        goMap[-8761686395194708583L].transform.SetParent(goMap[-4604452676421208745L].transform, false);
        goMap[1284148003858496349L].transform.SetParent(goMap[-4604452676421208745L].transform, false);
        goMap[8046156967202809136L].transform.SetParent(goMap[1284148003858496349L].transform, false);
        goMap[-8540440773408584456L].transform.SetParent(goMap[4698399892616113384L].transform, false);
        goMap[6345776855776289053L].transform.SetParent(goMap[-8540440773408584456L].transform, false);
        goMap[8664323072091333941L].transform.SetParent(goMap[-8540440773408584456L].transform, false);
        goMap[2449636839759187966L].transform.SetParent(goMap[-8540440773408584456L].transform, false);
        goMap[-6959205323960115395L].transform.SetParent(goMap[-8540440773408584456L].transform, false);
        goMap[199505377505860908L].transform.SetParent(goMap[-8540440773408584456L].transform, false);
        goMap[6945721822077407099L].transform.SetParent(goMap[-8540440773408584456L].transform, false);
        goMap[7203396946151232821L].transform.SetParent(goMap[6945721822077407099L].transform, false);
        goMap[1266127606291743594L].transform.SetParent(goMap[6945721822077407099L].transform, false);
        goMap[2036885841429208173L].transform.SetParent(goMap[1266127606291743594L].transform, false);
        goMap[-3399623518800077152L].transform.SetParent(goMap[1266127606291743594L].transform, false);
        goMap[249239059067498757L].transform.SetParent(goMap[1266127606291743594L].transform, false);
        goMap[7869158589290998247L].transform.SetParent(goMap[1266127606291743594L].transform, false);
        goMap[-6058926132351280345L].transform.SetParent(goMap[1266127606291743594L].transform, false);
        goMap[-15665877420440777L].transform.SetParent(goMap[-8540440773408584456L].transform, false);
        goMap[3328037334421634240L].transform.SetParent(goMap[-8540440773408584456L].transform, false);
        goMap[-979150597126615511L].transform.SetParent(goMap[3328037334421634240L].transform, false);
        goMap[-265349486119821339L].transform.SetParent(goMap[3328037334421634240L].transform, false);
        goMap[3625351349849309683L].transform.SetParent(goMap[-8540440773408584456L].transform, false);
        goMap[4636618231479330903L].transform.SetParent(goMap[3625351349849309683L].transform, false);
        goMap[-7803727915772642997L].transform.SetParent(goMap[4698399892616113384L].transform, false);
        goMap[-449172240975439368L].transform.SetParent(goMap[-7803727915772642997L].transform, false);
        goMap[6299711269936610943L].transform.SetParent(goMap[-7803727915772642997L].transform, false);
        goMap[8433658555559819024L].transform.SetParent(goMap[-7803727915772642997L].transform, false);
        goMap[-1842976861392890942L].transform.SetParent(goMap[-7803727915772642997L].transform, false);
        goMap[-8379789711243744906L].transform.SetParent(goMap[-7803727915772642997L].transform, false);
        goMap[8939028338081513303L].transform.SetParent(goMap[-7803727915772642997L].transform, false);
        goMap[289467459231244894L].transform.SetParent(goMap[8939028338081513303L].transform, false);
        goMap[-3545418426772144902L].transform.SetParent(goMap[8939028338081513303L].transform, false);
        goMap[-7993715888132882694L].transform.SetParent(goMap[-3545418426772144902L].transform, false);
        goMap[-3580709414101683427L].transform.SetParent(goMap[-3545418426772144902L].transform, false);
        goMap[-5248780366737210739L].transform.SetParent(goMap[-3545418426772144902L].transform, false);
        goMap[-3502493453048510569L].transform.SetParent(goMap[-3545418426772144902L].transform, false);
        goMap[3647326049221342511L].transform.SetParent(goMap[-3545418426772144902L].transform, false);
        goMap[-598345772288120282L].transform.SetParent(goMap[-7803727915772642997L].transform, false);
        goMap[5284080190253727684L].transform.SetParent(goMap[-7803727915772642997L].transform, false);
        goMap[7640045321075754472L].transform.SetParent(goMap[5284080190253727684L].transform, false);
        goMap[7385614178626317774L].transform.SetParent(goMap[5284080190253727684L].transform, false);
        goMap[6264083292714672059L].transform.SetParent(goMap[-7803727915772642997L].transform, false);
        goMap[207114240030905289L].transform.SetParent(goMap[6264083292714672059L].transform, false);
        goMap[2060706012100672974L].transform.SetParent(goMap[4698399892616113384L].transform, false);
        goMap[7969729691420640968L].transform.SetParent(goMap[2060706012100672974L].transform, false);
        goMap[-486569995512691673L].transform.SetParent(goMap[2060706012100672974L].transform, false);
        goMap[-6754545847898296918L].transform.SetParent(goMap[2060706012100672974L].transform, false);
        goMap[-264871016208571780L].transform.SetParent(goMap[2060706012100672974L].transform, false);
        goMap[-6724259936573054453L].transform.SetParent(goMap[2060706012100672974L].transform, false);
        goMap[59867554037438608L].transform.SetParent(goMap[2060706012100672974L].transform, false);
        goMap[1910503912913282468L].transform.SetParent(goMap[59867554037438608L].transform, false);
        goMap[1210638632862834481L].transform.SetParent(goMap[59867554037438608L].transform, false);
        goMap[-4761095439515878733L].transform.SetParent(goMap[1210638632862834481L].transform, false);
        goMap[3350033018248533789L].transform.SetParent(goMap[1210638632862834481L].transform, false);
        goMap[9206473817135465796L].transform.SetParent(goMap[1210638632862834481L].transform, false);
        goMap[-1461000065812277394L].transform.SetParent(goMap[1210638632862834481L].transform, false);
        goMap[-6768118514839040703L].transform.SetParent(goMap[1210638632862834481L].transform, false);
        goMap[3516665418004474092L].transform.SetParent(goMap[2060706012100672974L].transform, false);
        goMap[-8024281324226479849L].transform.SetParent(goMap[2060706012100672974L].transform, false);
        goMap[-4907494804830526061L].transform.SetParent(goMap[-8024281324226479849L].transform, false);
        goMap[-8859214668307593655L].transform.SetParent(goMap[-8024281324226479849L].transform, false);
        goMap[9063958857194198518L].transform.SetParent(goMap[2060706012100672974L].transform, false);
        goMap[-6063926043197739696L].transform.SetParent(goMap[9063958857194198518L].transform, false);
        goMap[6808388302714695786L].transform.SetParent(goMap[4698399892616113384L].transform, false);
        goMap[-4803598202576356995L].transform.SetParent(goMap[6808388302714695786L].transform, false);
        goMap[-6514676742962530142L].transform.SetParent(goMap[6808388302714695786L].transform, false);
        goMap[5092884888898161205L].transform.SetParent(goMap[6808388302714695786L].transform, false);
        goMap[-4684606610209150593L].transform.SetParent(goMap[6808388302714695786L].transform, false);
        goMap[6025753770910659253L].transform.SetParent(goMap[6808388302714695786L].transform, false);
        goMap[3513392338288642055L].transform.SetParent(goMap[6808388302714695786L].transform, false);
        goMap[-3015592765155141529L].transform.SetParent(goMap[3513392338288642055L].transform, false);
        goMap[-2601224623691635625L].transform.SetParent(goMap[3513392338288642055L].transform, false);
        goMap[-2195744494476524971L].transform.SetParent(goMap[-2601224623691635625L].transform, false);
        goMap[4964056629560570117L].transform.SetParent(goMap[-2601224623691635625L].transform, false);
        goMap[3059679146024846085L].transform.SetParent(goMap[-2601224623691635625L].transform, false);
        goMap[-9118257563414759432L].transform.SetParent(goMap[-2601224623691635625L].transform, false);
        goMap[-5183325016508861198L].transform.SetParent(goMap[-2601224623691635625L].transform, false);
        goMap[5292784270193578425L].transform.SetParent(goMap[6808388302714695786L].transform, false);
        goMap[-8904457033452487952L].transform.SetParent(goMap[6808388302714695786L].transform, false);
        goMap[5195321321574292861L].transform.SetParent(goMap[-8904457033452487952L].transform, false);
        goMap[-2052208102064299634L].transform.SetParent(goMap[-8904457033452487952L].transform, false);
        goMap[5311371466097208087L].transform.SetParent(goMap[6808388302714695786L].transform, false);
        goMap[4104077730807241263L].transform.SetParent(goMap[5311371466097208087L].transform, false);
        goMap[3288634337615831791L].transform.SetParent(goMap[4698399892616113384L].transform, false);
        goMap[3724969905040145829L].transform.SetParent(goMap[3288634337615831791L].transform, false);
        goMap[2285784354919624874L].transform.SetParent(goMap[3724969905040145829L].transform, false);
        goMap[-6183717179574427006L].transform.SetParent(goMap[3724969905040145829L].transform, false);
        goMap[-6317327717682246726L].transform.SetParent(goMap[3724969905040145829L].transform, false);
        goMap[1570330872980603920L].transform.SetParent(goMap[3724969905040145829L].transform, false);
        goMap[6300241840580095445L].transform.SetParent(goMap[3724969905040145829L].transform, false);
        goMap[7409389323368433024L].transform.SetParent(goMap[3288634337615831791L].transform, false);
        goMap[-765153702701176898L].transform.SetParent(goMap[7409389323368433024L].transform, false);
        goMap[-6527691034233822723L].transform.SetParent(goMap[7409389323368433024L].transform, false);
        goMap[6558214718643765950L].transform.SetParent(goMap[7409389323368433024L].transform, false);
        goMap[-6171738257053796066L].transform.SetParent(goMap[7409389323368433024L].transform, false);
        goMap[-4972747254247415717L].transform.SetParent(goMap[7409389323368433024L].transform, false);
        goMap[2022348217077567644L].transform.SetParent(goMap[3288634337615831791L].transform, false);
        goMap[5307649616257537927L].transform.SetParent(goMap[2022348217077567644L].transform, false);
        goMap[-8328865442789105240L].transform.SetParent(goMap[2022348217077567644L].transform, false);
        goMap[4525060424070368289L].transform.SetParent(goMap[2022348217077567644L].transform, false);
        goMap[-3337763184212787673L].transform.SetParent(goMap[2022348217077567644L].transform, false);
        goMap[-2559392933116311911L].transform.SetParent(goMap[2022348217077567644L].transform, false);
        goMap[-2644452386813790099L].transform.SetParent(goMap[3288634337615831791L].transform, false);
        goMap[5751900236404203427L].transform.SetParent(goMap[-2644452386813790099L].transform, false);
        goMap[2904770196660660045L].transform.SetParent(goMap[-2644452386813790099L].transform, false);
        goMap[5770348884974793421L].transform.SetParent(goMap[-2644452386813790099L].transform, false);
        goMap[-8676323578187220487L].transform.SetParent(goMap[-2644452386813790099L].transform, false);
        goMap[-2226849749700380895L].transform.SetParent(goMap[-2644452386813790099L].transform, false);
        goMap[834687017711717292L].transform.SetParent(goMap[4698399892616113384L].transform, false);
        goMap[2748308880132554528L].transform.SetParent(goMap[834687017711717292L].transform, false);
        goMap[-3031763653391634264L].transform.SetParent(goMap[834687017711717292L].transform, false);
        goMap[7012829260713158418L].transform.SetParent(goMap[834687017711717292L].transform, false);
        goMap[-8141538957844588804L].transform.SetParent(goMap[834687017711717292L].transform, false);
        goMap[2183930071166712069L].transform.SetParent(goMap[-8141538957844588804L].transform, false);
        goMap[-3202376101565362456L].transform.SetParent(goMap[4698399892616113384L].transform, false);
        goMap[-6152790527035529764L].transform.SetParent(goMap[-3202376101565362456L].transform, false);
        goMap[-1847392839987607762L].transform.SetParent(goMap[-3202376101565362456L].transform, false);
        goMap[-7656686862451681279L].transform.SetParent(goMap[-3202376101565362456L].transform, false);
        goMap[3824338068560615823L].transform.SetParent(goMap[-3202376101565362456L].transform, false);
        goMap[-6922416529777263049L].transform.SetParent(goMap[-3202376101565362456L].transform, false);
        goMap[68091241504638832L].transform.SetParent(goMap[-3202376101565362456L].transform, false);
        goMap[5799186231942803867L].transform.SetParent(goMap[-3202376101565362456L].transform, false);
        goMap[-3117298033521374793L].transform.SetParent(goMap[-3202376101565362456L].transform, false);
        goMap[-4716074784255749072L].transform.SetParent(goMap[-3202376101565362456L].transform, false);
        goMap[-6750949985260853050L].transform.SetParent(goMap[-4716074784255749072L].transform, false);
        goMap[284415134558256666L].transform.SetParent(goMap[-4716074784255749072L].transform, false);
        goMap[-3350807390247092236L].transform.SetParent(goMap[284415134558256666L].transform, false);
        goMap[-6704101358884667490L].transform.SetParent(goMap[284415134558256666L].transform, false);
        goMap[631353528465912324L].transform.SetParent(goMap[284415134558256666L].transform, false);
        goMap[8054732902888111815L].transform.SetParent(goMap[284415134558256666L].transform, false);
        goMap[-2809562510682158786L].transform.SetParent(goMap[284415134558256666L].transform, false);
        goMap[9084154749753190381L].transform.SetParent(goMap[-3202376101565362456L].transform, false);
        goMap[2204507256174152521L].transform.SetParent(goMap[-3202376101565362456L].transform, false);
        goMap[-2841585352275090228L].transform.SetParent(goMap[2204507256174152521L].transform, false);
        goMap[6448561864505022193L].transform.SetParent(goMap[4698399892616113384L].transform, false);
        goMap[265972771125574157L].transform.SetParent(goMap[6448561864505022193L].transform, false);
        goMap[-8965038464424305431L].transform.SetParent(goMap[6448561864505022193L].transform, false);
        goMap[-6352839020668222238L].transform.SetParent(goMap[-8965038464424305431L].transform, false);
        goMap[3535413626053756433L].transform.SetParent(goMap[4698399892616113384L].transform, false);
        goMap[-5245693610933703615L].transform.SetParent(goMap[3535413626053756433L].transform, false);
        goMap[7750029830297870049L].transform.SetParent(goMap[3535413626053756433L].transform, false);
        goMap[-5163150904620973056L].transform.SetParent(goMap[7750029830297870049L].transform, false);
        goMap[-3458778223271688658L].transform.SetParent(goMap[7750029830297870049L].transform, false);
        goMap[-6820728270903118545L].transform.SetParent(goMap[7750029830297870049L].transform, false);
        goMap[8742052578064954519L].transform.SetParent(goMap[3535413626053756433L].transform, false);
        goMap[-1790091547151766849L].transform.SetParent(goMap[8742052578064954519L].transform, false);
        goMap[4913519792906914546L].transform.SetParent(goMap[4698399892616113384L].transform, false);
        goMap[-9172179323496584541L].transform.SetParent(goMap[4913519792906914546L].transform, false);
        goMap[8380223691777849941L].transform.SetParent(goMap[4913519792906914546L].transform, false);
        goMap[-101559371840674367L].transform.SetParent(goMap[4913519792906914546L].transform, false);
        goMap[-3240014703483295585L].transform.SetParent(goMap[4913519792906914546L].transform, false);
        goMap[4445052976092313583L].transform.SetParent(goMap[4913519792906914546L].transform, false);
        goMap[-3843530212429135637L].transform.SetParent(goMap[4913519792906914546L].transform, false);
        goMap[3690835674224919719L].transform.SetParent(goMap[-3843530212429135637L].transform, false);
        goMap[8994061576271688309L].transform.SetParent(goMap[-3843530212429135637L].transform, false);
        goMap[3517732553139607850L].transform.SetParent(goMap[8994061576271688309L].transform, false);
        goMap[2649650569271069276L].transform.SetParent(goMap[8994061576271688309L].transform, false);
        goMap[5851375669707577472L].transform.SetParent(goMap[8994061576271688309L].transform, false);
        goMap[7010681538041553242L].transform.SetParent(goMap[8994061576271688309L].transform, false);
        goMap[-9183471573238676604L].transform.SetParent(goMap[8994061576271688309L].transform, false);
        goMap[4233185735053625867L].transform.SetParent(goMap[4913519792906914546L].transform, false);
        goMap[-528258494804935527L].transform.SetParent(goMap[4233185735053625867L].transform, false);
        goMap[-9163990204722043384L].transform.SetParent(goMap[4698399892616113384L].transform, false);
        goMap[-2397032916046080846L].transform.SetParent(goMap[-9163990204722043384L].transform, false);
        goMap[-7872213626190719830L].transform.SetParent(goMap[-9163990204722043384L].transform, false);
        goMap[7316762769053103884L].transform.SetParent(goMap[-9163990204722043384L].transform, false);
        goMap[-413135616190048636L].transform.SetParent(goMap[-9163990204722043384L].transform, false);
        goMap[8040436650192479410L].transform.SetParent(goMap[-9163990204722043384L].transform, false);
        goMap[-7806845672604755148L].transform.SetParent(goMap[4698399892616113384L].transform, false);
        goMap[2653439226259348729L].transform.SetParent(goMap[-7806845672604755148L].transform, false);
        goMap[-3117203015968352357L].transform.SetParent(goMap[-7806845672604755148L].transform, false);
        goMap[-3634240885161816432L].transform.SetParent(goMap[4698399892616113384L].transform, false);
        goMap[1453364372587689086L].transform.SetParent(goMap[-3634240885161816432L].transform, false);
        goMap[-3238541514736070332L].transform.SetParent(goMap[-3634240885161816432L].transform, false);
        goMap[-604381086727030260L].transform.SetParent(goMap[-3634240885161816432L].transform, false);
        goMap[-8431732466732635421L].transform.SetParent(goMap[-3634240885161816432L].transform, false);
        goMap[-5032876086891915949L].transform.SetParent(goMap[-8431732466732635421L].transform, false);
        goMap[-959899472340865441L].transform.SetParent(goMap[4698399892616113384L].transform, false);
        goMap[3589094691956112967L].transform.SetParent(goMap[-959899472340865441L].transform, false);
        goMap[5049302239516006484L].transform.SetParent(goMap[-959899472340865441L].transform, false);
        goMap[1956788135510404163L].transform.SetParent(goMap[-959899472340865441L].transform, false);
        goMap[5247181220983650622L].transform.SetParent(goMap[-959899472340865441L].transform, false);
        goMap[7745105872495901956L].transform.SetParent(goMap[-959899472340865441L].transform, false);
        goMap[-3885453583486018799L].transform.SetParent(goMap[-959899472340865441L].transform, false);
        goMap[-1912578136901788121L].transform.SetParent(goMap[-3885453583486018799L].transform, false);
        goMap[-5545680676340924478L].transform.SetParent(goMap[-3885453583486018799L].transform, false);
        goMap[5509310581499754811L].transform.SetParent(goMap[-5545680676340924478L].transform, false);
        goMap[-4470304427137069547L].transform.SetParent(goMap[-5545680676340924478L].transform, false);
        goMap[2944573335004902959L].transform.SetParent(goMap[-5545680676340924478L].transform, false);
        goMap[8352736510745087549L].transform.SetParent(goMap[-5545680676340924478L].transform, false);
        goMap[5550209453617123674L].transform.SetParent(goMap[-5545680676340924478L].transform, false);
        goMap[3039768255981816252L].transform.SetParent(goMap[-959899472340865441L].transform, false);
        goMap[3858957314487626227L].transform.SetParent(goMap[-959899472340865441L].transform, false);
        goMap[8109975175002384414L].transform.SetParent(goMap[3858957314487626227L].transform, false);
        goMap[-1161962047489786518L].transform.SetParent(goMap[3858957314487626227L].transform, false);
        goMap[1340200135462406413L].transform.SetParent(goMap[-959899472340865441L].transform, false);
        goMap[-1501922615769999554L].transform.SetParent(goMap[1340200135462406413L].transform, false);

        // ─── RectTransforms ──────────────────────────────────
        {
            var rt = goMap[-505170310806722818L].AddComponent<RectTransform>();
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
            var rt = goMap[4698399892616113384L].AddComponent<RectTransform>();
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
            var rt = goMap[6614476112898934457L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-107.000000f, 107.899994f);
            rt.sizeDelta = new Vector2(140.000000f, 140.000000f);
        }
        {
            var rt = goMap[-4604452676421208745L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-103.000000f, 107.899994f);
            rt.sizeDelta = new Vector2(110.000000f, 110.000000f);
        }
        {
            var rt = goMap[-2680578444748262782L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.220000f, -0.220000f);
            rt.sizeDelta = new Vector2(106.000000f, 106.000000f);
        }
        {
            var rt = goMap[6011512065163492639L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(106.000000f, 106.000000f);
        }
        {
            var rt = goMap[7964270623288650510L].AddComponent<RectTransform>();
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
            var rt = goMap[-3895230867223739866L].AddComponent<RectTransform>();
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
            var rt = goMap[2876419161059730916L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(110.000000f, 110.000000f);
        }
        {
            var rt = goMap[-1747304736232977427L].AddComponent<RectTransform>();
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
            var rt = goMap[8056385823319411269L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(236.370743f, 236.370743f, 236.370743f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[2082492290192657099L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.665875f,0.746063f);
            rt.localScale = new Vector3(305.934631f, 305.934631f, 305.934631f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.000177f, -0.000252f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[2745937564456138383L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(328.464661f, 328.464661f, 328.464661f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000021f, 0.000267f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-8829613399954042692L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(183.728912f, 183.728912f, 183.728912f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-8761686395194708583L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(33.599998f, -34.500000f);
            rt.sizeDelta = new Vector2(0.500000f, 0.399994f);
        }
        {
            var rt = goMap[1284148003858496349L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 30.000000f);
        }
        {
            var rt = goMap[8046156967202809136L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 30.000000f);
        }
        {
            var rt = goMap[-8540440773408584456L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-220.000000f, 52.000000f);
            rt.sizeDelta = new Vector2(86.000000f, 86.000000f);
        }
        {
            var rt = goMap[6345776855776289053L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.060000f, -0.060000f);
            rt.sizeDelta = new Vector2(84.000000f, 84.000000f);
        }
        {
            var rt = goMap[8664323072091333941L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(86.000000f, 86.000000f);
        }
        {
            var rt = goMap[2449636839759187966L].AddComponent<RectTransform>();
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
            var rt = goMap[-6959205323960115395L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(86.000000f, 86.000000f);
        }
        {
            var rt = goMap[199505377505860908L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(88.000000f, 88.000000f);
        }
        {
            var rt = goMap[1266127606291743594L].AddComponent<RectTransform>();
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
            var rt = goMap[2036885841429208173L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(236.370743f, 236.370743f, 236.370743f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-3399623518800077152L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.665875f,0.746063f);
            rt.localScale = new Vector3(305.934631f, 305.934631f, 305.934631f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.000177f, -0.000252f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[249239059067498757L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(328.464661f, 328.464661f, 328.464661f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000021f, 0.000267f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[7869158589290998247L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(183.728912f, 183.728912f, 183.728912f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-15665877420440777L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(29.424999f, -29.000000f);
            rt.sizeDelta = new Vector2(44.849998f, -42.000000f);
        }
        {
            var rt = goMap[3328037334421634240L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(86.000000f, 86.000000f);
        }
        {
            var rt = goMap[-979150597126615511L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -14.100000f);
            rt.sizeDelta = new Vector2(100.000000f, 30.000000f);
        }
        {
            var rt = goMap[-265349486119821339L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 13.000000f);
            rt.sizeDelta = new Vector2(26.000000f, 31.000000f);
        }
        {
            var rt = goMap[3625351349849309683L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 30.000000f);
        }
        {
            var rt = goMap[4636618231479330903L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 30.000000f);
        }
        {
            var rt = goMap[-7803727915772642997L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-230.000000f, 164.000000f);
            rt.sizeDelta = new Vector2(86.000000f, 86.000000f);
        }
        {
            var rt = goMap[-449172240975439368L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(84.000000f, 84.000000f);
        }
        {
            var rt = goMap[6299711269936610943L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(86.000000f, 86.000000f);
        }
        {
            var rt = goMap[8433658555559819024L].AddComponent<RectTransform>();
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
            var rt = goMap[-1842976861392890942L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(86.000000f, 86.000000f);
        }
        {
            var rt = goMap[-8379789711243744906L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(88.000000f, 88.000000f);
        }
        {
            var rt = goMap[-3545418426772144902L].AddComponent<RectTransform>();
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
            var rt = goMap[-7993715888132882694L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(236.370743f, 236.370743f, 236.370743f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-3580709414101683427L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.665875f,0.746063f);
            rt.localScale = new Vector3(305.934631f, 305.934631f, 305.934631f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.000177f, -0.000252f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-5248780366737210739L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(328.464661f, 328.464661f, 328.464661f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000021f, 0.000267f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-3502493453048510569L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(183.728912f, 183.728912f, 183.728912f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-598345772288120282L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(34.950001f, -29.300003f);
            rt.sizeDelta = new Vector2(55.900002f, -41.400002f);
        }
        {
            var rt = goMap[5284080190253727684L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(86.000000f, 86.000000f);
        }
        {
            var rt = goMap[7640045321075754472L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -14.100000f);
            rt.sizeDelta = new Vector2(100.000000f, 30.000000f);
        }
        {
            var rt = goMap[7385614178626317774L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 13.000000f);
            rt.sizeDelta = new Vector2(26.000000f, 31.000000f);
        }
        {
            var rt = goMap[6264083292714672059L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 30.000000f);
        }
        {
            var rt = goMap[207114240030905289L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 30.000000f);
        }
        {
            var rt = goMap[2060706012100672974L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-150.000000f, 230.000000f);
            rt.sizeDelta = new Vector2(86.000000f, 86.000000f);
        }
        {
            var rt = goMap[7969729691420640968L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(84.000000f, 84.000000f);
        }
        {
            var rt = goMap[-486569995512691673L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(86.000000f, 86.000000f);
        }
        {
            var rt = goMap[-6754545847898296918L].AddComponent<RectTransform>();
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
            var rt = goMap[-264871016208571780L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(86.000000f, 86.000000f);
        }
        {
            var rt = goMap[-6724259936573054453L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(88.000000f, 88.000000f);
        }
        {
            var rt = goMap[1210638632862834481L].AddComponent<RectTransform>();
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
            var rt = goMap[-4761095439515878733L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(236.370743f, 236.370743f, 236.370743f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[3350033018248533789L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.665875f,0.746063f);
            rt.localScale = new Vector3(305.934631f, 305.934631f, 305.934631f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.000177f, -0.000252f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[9206473817135465796L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(328.464661f, 328.464661f, 328.464661f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000021f, 0.000267f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-1461000065812277394L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(183.728912f, 183.728912f, 183.728912f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[3516665418004474092L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(34.950001f, -29.300003f);
            rt.sizeDelta = new Vector2(55.900002f, -41.400002f);
        }
        {
            var rt = goMap[-8024281324226479849L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(86.000000f, 86.000000f);
        }
        {
            var rt = goMap[-4907494804830526061L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -14.100000f);
            rt.sizeDelta = new Vector2(100.000000f, 30.000000f);
        }
        {
            var rt = goMap[-8859214668307593655L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 13.000000f);
            rt.sizeDelta = new Vector2(26.000000f, 31.000000f);
        }
        {
            var rt = goMap[9063958857194198518L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 30.000000f);
        }
        {
            var rt = goMap[-6063926043197739696L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 30.000000f);
        }
        {
            var rt = goMap[6808388302714695786L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-47.000000f, 220.000000f);
            rt.sizeDelta = new Vector2(86.000000f, 86.000000f);
        }
        {
            var rt = goMap[-4803598202576356995L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(84.000000f, 84.000000f);
        }
        {
            var rt = goMap[-6514676742962530142L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(86.000000f, 86.000000f);
        }
        {
            var rt = goMap[5092884888898161205L].AddComponent<RectTransform>();
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
            var rt = goMap[-4684606610209150593L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(86.000000f, 86.000000f);
        }
        {
            var rt = goMap[6025753770910659253L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(88.000000f, 88.000000f);
        }
        {
            var rt = goMap[-2601224623691635625L].AddComponent<RectTransform>();
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
            var rt = goMap[-2195744494476524971L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(236.370743f, 236.370743f, 236.370743f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[4964056629560570117L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.665875f,0.746063f);
            rt.localScale = new Vector3(305.934631f, 305.934631f, 305.934631f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.000177f, -0.000252f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[3059679146024846085L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(328.464661f, 328.464661f, 328.464661f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000021f, 0.000267f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-9118257563414759432L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(183.728912f, 183.728912f, 183.728912f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[5292784270193578425L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(34.950001f, -29.300003f);
            rt.sizeDelta = new Vector2(55.900002f, -41.400002f);
        }
        {
            var rt = goMap[-8904457033452487952L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(86.000000f, 86.000000f);
        }
        {
            var rt = goMap[5195321321574292861L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -14.100000f);
            rt.sizeDelta = new Vector2(100.000000f, 30.000000f);
        }
        {
            var rt = goMap[-2052208102064299634L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 13.000000f);
            rt.sizeDelta = new Vector2(26.000000f, 31.000000f);
        }
        {
            var rt = goMap[5311371466097208087L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 30.000000f);
        }
        {
            var rt = goMap[4104077730807241263L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 30.000000f);
        }
        {
            var rt = goMap[3288634337615831791L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-410.999969f, 310.500061f);
            rt.sizeDelta = new Vector2(230.000000f, 56.000000f);
        }
        {
            var rt = goMap[3724969905040145829L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(16.400000f, -80.800003f);
            rt.sizeDelta = new Vector2(45.000000f, 45.000000f);
        }
        {
            var rt = goMap[2285784354919624874L].AddComponent<RectTransform>();
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
            var rt = goMap[-6183717179574427006L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(42.000000f, 42.000000f);
        }
        {
            var rt = goMap[-6317327717682246726L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(50.000000f, 50.000000f);
        }
        {
            var rt = goMap[1570330872980603920L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(50.000000f, 30.000000f);
        }
        {
            var rt = goMap[6300241840580095445L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(50.000000f, 30.000000f);
        }
        {
            var rt = goMap[7409389323368433024L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(42.400002f, -31.799999f);
            rt.sizeDelta = new Vector2(45.000000f, 45.000000f);
        }
        {
            var rt = goMap[-765153702701176898L].AddComponent<RectTransform>();
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
            var rt = goMap[-6527691034233822723L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(42.000000f, 42.000000f);
        }
        {
            var rt = goMap[6558214718643765950L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(50.000000f, 50.000000f);
        }
        {
            var rt = goMap[-6171738257053796066L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(50.000000f, 30.000000f);
        }
        {
            var rt = goMap[-4972747254247415717L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(50.000000f, 30.000000f);
        }
        {
            var rt = goMap[2022348217077567644L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(90.400002f, 3.400000f);
            rt.sizeDelta = new Vector2(45.000000f, 45.000000f);
        }
        {
            var rt = goMap[5307649616257537927L].AddComponent<RectTransform>();
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
            var rt = goMap[-8328865442789105240L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(42.000000f, 42.000000f);
        }
        {
            var rt = goMap[4525060424070368289L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(50.000000f, 50.000000f);
        }
        {
            var rt = goMap[-3337763184212787673L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(50.000000f, 30.000000f);
        }
        {
            var rt = goMap[-2559392933116311911L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(50.000000f, 30.000000f);
        }
        {
            var rt = goMap[-2644452386813790099L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(138.600006f, 21.900000f);
            rt.sizeDelta = new Vector2(45.000000f, 45.000000f);
        }
        {
            var rt = goMap[5751900236404203427L].AddComponent<RectTransform>();
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
            var rt = goMap[2904770196660660045L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(42.000000f, 42.000000f);
        }
        {
            var rt = goMap[5770348884974793421L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(50.000000f, 50.000000f);
        }
        {
            var rt = goMap[-8676323578187220487L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(50.000000f, 30.000000f);
        }
        {
            var rt = goMap[-2226849749700380895L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(50.000000f, 30.000000f);
        }
        {
            var rt = goMap[834687017711717292L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-166.000031f, 159.000000f);
            rt.sizeDelta = new Vector2(300.000000f, 300.000000f);
        }
        {
            var rt = goMap[2748308880132554528L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 30.000000f);
        }
        {
            var rt = goMap[-3031763653391634264L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 30.000000f);
        }
        {
            var rt = goMap[7012829260713158418L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 30.000000f);
        }
        {
            var rt = goMap[-8141538957844588804L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(0.800000f, 0.800000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(9.369995f, -16.500000f);
            rt.sizeDelta = new Vector2(72.000000f, 72.000000f);
        }
        {
            var rt = goMap[2183930071166712069L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(72.000000f, 50.000000f);
        }
        {
            var rt = goMap[-3202376101565362456L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.900000f, 0.900000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-49.700073f, 327.299988f);
            rt.sizeDelta = new Vector2(64.000000f, 64.000000f);
        }
        {
            var rt = goMap[-6152790527035529764L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(60.000000f, 60.000000f);
        }
        {
            var rt = goMap[-1847392839987607762L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(64.000000f, 64.000000f);
        }
        {
            var rt = goMap[-7656686862451681279L].AddComponent<RectTransform>();
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
            var rt = goMap[3824338068560615823L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(64.000000f, 64.000000f);
        }
        {
            var rt = goMap[-6922416529777263049L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(22.799999f, -18.400002f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }
        {
            var rt = goMap[68091241504638832L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(64.000000f, 64.000000f);
        }
        {
            var rt = goMap[5799186231942803867L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(36.000000f, 36.000000f);
        }
        {
            var rt = goMap[-3117298033521374793L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -17.500000f);
            rt.sizeDelta = new Vector2(0.000000f, -35.000000f);
        }
        {
            var rt = goMap[284415134558256666L].AddComponent<RectTransform>();
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
            var rt = goMap[-3350807390247092236L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(236.370743f, 236.370743f, 236.370743f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-6704101358884667490L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.665875f,0.746063f);
            rt.localScale = new Vector3(305.934631f, 305.934631f, 305.934631f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.000177f, -0.000252f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[631353528465912324L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(328.464661f, 328.464661f, 328.464661f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000021f, 0.000267f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[8054732902888111815L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(183.728912f, 183.728912f, 183.728912f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[9084154749753190381L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(64.000000f, 64.000000f);
        }
        {
            var rt = goMap[2204507256174152521L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.111111f, 1.111111f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 30.000000f);
        }
        {
            var rt = goMap[-2841585352275090228L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 30.000000f);
        }
        {
            var rt = goMap[6448561864505022193L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(0.900000f, 0.900000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-122.000000f, 328.000000f);
            rt.sizeDelta = new Vector2(72.000000f, 72.000000f);
        }
        {
            var rt = goMap[265972771125574157L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -23.999981f);
            rt.sizeDelta = new Vector2(50.000000f, 30.000000f);
        }
        {
            var rt = goMap[-8965038464424305431L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.111111f, 1.111111f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 30.000000f);
        }
        {
            var rt = goMap[-6352839020668222238L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 30.000000f);
        }
        {
            var rt = goMap[3535413626053756433L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(0.900000f, 0.900000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-122.000000f, 328.000000f);
            rt.sizeDelta = new Vector2(72.000000f, 72.000000f);
        }
        {
            var rt = goMap[-5245693610933703615L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -24.000000f);
            rt.sizeDelta = new Vector2(50.000000f, 30.000000f);
        }
        {
            var rt = goMap[7750029830297870049L].AddComponent<RectTransform>();
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
            var rt = goMap[-5163150904620973056L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(58.000000f, 58.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-3458778223271688658L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(100.108665f, 100.108665f, 100.108665f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-6820728270903118545L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,-0.627872f,-0.778316f);
            rt.localScale = new Vector3(96.889633f, 96.889633f, 96.889633f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[8742052578064954519L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.111111f, 1.111111f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 30.000000f);
        }
        {
            var rt = goMap[-1790091547151766849L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 30.000000f);
        }
        {
            var rt = goMap[4913519792906914546L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-301.200012f, 205.899994f);
            rt.sizeDelta = new Vector2(56.000000f, 56.000000f);
        }
        {
            var rt = goMap[-9172179323496584541L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.500000f);
            rt.sizeDelta = new Vector2(53.000000f, 53.000000f);
        }
        {
            var rt = goMap[8380223691777849941L].AddComponent<RectTransform>();
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
            var rt = goMap[-101559371840674367L].AddComponent<RectTransform>();
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
            var rt = goMap[-3240014703483295585L].AddComponent<RectTransform>();
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
            var rt = goMap[4445052976092313583L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(20.100000f, -16.799999f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }
        {
            var rt = goMap[8994061576271688309L].AddComponent<RectTransform>();
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
            var rt = goMap[3517732553139607850L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(236.370743f, 236.370743f, 236.370743f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[2649650569271069276L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.665875f,0.746063f);
            rt.localScale = new Vector3(305.934631f, 305.934631f, 305.934631f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.000177f, -0.000252f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[5851375669707577472L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(328.464661f, 328.464661f, 328.464661f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000021f, 0.000267f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[7010681538041553242L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(183.728912f, 183.728912f, 183.728912f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[4233185735053625867L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(50.000000f, 24.000000f);
        }
        {
            var rt = goMap[-528258494804935527L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(50.000000f, 30.000000f);
        }
        {
            var rt = goMap[-9163990204722043384L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-349.299988f, 120.000000f);
            rt.sizeDelta = new Vector2(56.000000f, 56.000000f);
        }
        {
            var rt = goMap[-2397032916046080846L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(56.000000f, 56.000000f);
        }
        {
            var rt = goMap[-7872213626190719830L].AddComponent<RectTransform>();
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
            var rt = goMap[7316762769053103884L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(56.000000f, 56.000000f);
        }
        {
            var rt = goMap[-413135616190048636L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(26.000000f, 31.000000f);
        }
        {
            var rt = goMap[8040436650192479410L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-6.600000f, 0.000000f);
            rt.sizeDelta = new Vector2(38.000000f, 31.000000f);
        }
        {
            var rt = goMap[-7806845672604755148L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-296.000000f, 203.199997f);
            rt.sizeDelta = new Vector2(40.000000f, 40.000000f);
        }
        {
            var rt = goMap[2653439226259348729L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.173648f,0.984808f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-1.200000f, -64.800003f);
            rt.sizeDelta = new Vector2(38.000000f, 38.000000f);
        }
        {
            var rt = goMap[-3117203015968352357L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,-0.984808f,0.173648f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-1.300000f, -65.599998f);
            rt.sizeDelta = new Vector2(38.000000f, 38.000000f);
        }
        {
            var rt = goMap[-3634240885161816432L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(0.960000f, 0.960000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-308.000000f, 37.000000f);
            rt.sizeDelta = new Vector2(64.000000f, 64.000000f);
        }
        {
            var rt = goMap[1453364372587689086L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.500000f);
            rt.sizeDelta = new Vector2(64.000000f, 64.000000f);
        }
        {
            var rt = goMap[-3238541514736070332L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -14.600000f);
            rt.sizeDelta = new Vector2(50.000000f, 30.000000f);
        }
        {
            var rt = goMap[-604381086727030260L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.500000f);
            rt.sizeDelta = new Vector2(58.000000f, 58.000000f);
        }
        {
            var rt = goMap[-8431732466732635421L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.041667f, 1.041667f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 30.000000f);
        }
        {
            var rt = goMap[-5032876086891915949L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 30.000000f);
        }
        {
            var rt = goMap[-959899472340865441L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-242.199997f, 283.500000f);
            rt.sizeDelta = new Vector2(86.000000f, 86.000000f);
        }
        {
            var rt = goMap[3589094691956112967L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(84.000000f, 84.000000f);
        }
        {
            var rt = goMap[5049302239516006484L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(86.000000f, 86.000000f);
        }
        {
            var rt = goMap[1956788135510404163L].AddComponent<RectTransform>();
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
            var rt = goMap[5247181220983650622L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(86.000000f, 86.000000f);
        }
        {
            var rt = goMap[7745105872495901956L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(88.000000f, 88.000000f);
        }
        {
            var rt = goMap[-5545680676340924478L].AddComponent<RectTransform>();
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
            var rt = goMap[5509310581499754811L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(236.370743f, 236.370743f, 236.370743f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-4470304427137069547L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.665875f,0.746063f);
            rt.localScale = new Vector3(305.934631f, 305.934631f, 305.934631f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.000177f, -0.000252f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[2944573335004902959L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(328.464661f, 328.464661f, 328.464661f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000021f, 0.000267f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[8352736510745087549L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(183.728912f, 183.728912f, 183.728912f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[3039768255981816252L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(34.950001f, -29.300003f);
            rt.sizeDelta = new Vector2(55.900002f, -41.400002f);
        }
        {
            var rt = goMap[3858957314487626227L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(86.000000f, 86.000000f);
        }
        {
            var rt = goMap[8109975175002384414L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -14.100000f);
            rt.sizeDelta = new Vector2(100.000000f, 30.000000f);
        }
        {
            var rt = goMap[-1161962047489786518L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 13.000000f);
            rt.sizeDelta = new Vector2(26.000000f, 31.000000f);
        }
        {
            var rt = goMap[1340200135462406413L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 30.000000f);
        }
        {
            var rt = goMap[-1501922615769999554L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(30.000000f, 30.000000f);
        }

        // ─── Components ──────────────────────────────────────
        { var c = goMap[-505170310806722818L].AddComponent<CanvasScaler>();
           c.uiScaleMode = (CanvasScaler.ScaleMode)1;
           c.referenceResolution = new Vector2(1280.000000f, 720.000000f);
           c.matchWidthOrHeight = 0.000000f;
           c.referencePixelsPerUnit = 100.000000f;
        }
        { var c = goMap[-505170310806722818L].AddComponent<GraphicRaycaster>();
           c.ignoreReversedGraphics = true;
        }
        { var c = goMap[6614476112898934457L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_skillbg");
        }
        { var c = goMap[-4604452676421208745L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("btn_skill_bg");
        }
        { var c = goMap[-4604452676421208745L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[6011512065163492639L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.784314f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Filled;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 0.000000f;
           c.fillClockwise = false;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 2;
           c.enabled = true;
           c.sprite = LookupSprite("img_skillcd");
        }
        { var c = goMap[7964270623288650510L].AddComponent<Text>();
           c.text = "10";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 36;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 0;
           c.resizeTextMaxSize = 300;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-3895230867223739866L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Filled;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 0.000000f;
           c.fillClockwise = false;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 2;
           c.enabled = true;
           c.sprite = LookupSprite("img_skillusepoint");
        }
        { var c = goMap[2876419161059730916L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_skillcd");
        }
        { var c = goMap[-8761686395194708583L].AddComponent<Text>();
           c.text = "3";
           c.color = new Color(0.396078f, 0.984314f, 0.396078f, 1.000000f);
           c.fontSize = 35;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 3;
           c.resizeTextMaxSize = 70;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[1284148003858496349L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.raycastTarget = true;
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
        { var c = goMap[8046156967202809136L].AddComponent<Text>();
           c.text = "K";
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
           c.resizeTextMinSize = 1;
           c.resizeTextMaxSize = 40;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-8540440773408584456L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("btn_skill_bg");
        }
        { var c = goMap[-8540440773408584456L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[8664323072091333941L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.784314f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Filled;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 0.000000f;
           c.fillClockwise = false;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 2;
           c.enabled = true;
           c.sprite = LookupSprite("img_skillcd");
        }
        { var c = goMap[2449636839759187966L].AddComponent<Text>();
           c.text = "10";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 28;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 70;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-6959205323960115395L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Filled;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 0.000000f;
           c.fillClockwise = false;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 2;
           c.enabled = true;
           c.sprite = LookupSprite("img_skillusepoint");
        }
        { var c = goMap[199505377505860908L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_skillcd");
        }
        { var c = goMap[-15665877420440777L].AddComponent<Text>();
           c.text = "3";
           c.color = new Color(0.396078f, 0.984314f, 0.396078f, 1.000000f);
           c.fontSize = 25;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 70;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-979150597126615511L].AddComponent<Text>();
           c.text = "99级学习";
           c.color = new Color(1.000000f, 1.000000f, 0.800000f, 1.000000f);
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
           c.resizeTextMaxSize = 70;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-265349486119821339L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_locked");
        }
        { var c = goMap[3625351349849309683L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.raycastTarget = true;
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
        { var c = goMap[4636618231479330903L].AddComponent<Text>();
           c.text = "J";
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
           c.resizeTextMinSize = 1;
           c.resizeTextMaxSize = 40;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-7803727915772642997L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("btn_skill_bg");
        }
        { var c = goMap[-7803727915772642997L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[6299711269936610943L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.784314f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Filled;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 0.000000f;
           c.fillClockwise = false;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 2;
           c.enabled = true;
           c.sprite = LookupSprite("img_skillcd");
        }
        { var c = goMap[8433658555559819024L].AddComponent<Text>();
           c.text = "10";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 28;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 70;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-1842976861392890942L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Filled;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 0.000000f;
           c.fillClockwise = false;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 2;
           c.enabled = true;
           c.sprite = LookupSprite("img_skillusepoint");
        }
        { var c = goMap[-8379789711243744906L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_skillcd");
        }
        { var c = goMap[-598345772288120282L].AddComponent<Text>();
           c.text = "3";
           c.color = new Color(0.396078f, 0.984314f, 0.396078f, 1.000000f);
           c.fontSize = 25;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 70;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[7640045321075754472L].AddComponent<Text>();
           c.text = "99级学习";
           c.color = new Color(1.000000f, 1.000000f, 0.800000f, 1.000000f);
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
           c.resizeTextMaxSize = 70;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[7385614178626317774L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_locked");
        }
        { var c = goMap[6264083292714672059L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.raycastTarget = true;
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
        { var c = goMap[207114240030905289L].AddComponent<Text>();
           c.text = "U";
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
           c.resizeTextMinSize = 1;
           c.resizeTextMaxSize = 40;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[2060706012100672974L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("btn_skill_bg");
        }
        { var c = goMap[2060706012100672974L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-486569995512691673L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.784314f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Filled;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 0.000000f;
           c.fillClockwise = false;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 2;
           c.enabled = true;
           c.sprite = LookupSprite("img_skillcd");
        }
        { var c = goMap[-6754545847898296918L].AddComponent<Text>();
           c.text = "10";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 28;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 70;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-264871016208571780L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Filled;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 0.000000f;
           c.fillClockwise = false;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 2;
           c.enabled = true;
           c.sprite = LookupSprite("img_skillusepoint");
        }
        { var c = goMap[-6724259936573054453L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_skillcd");
        }
        { var c = goMap[3516665418004474092L].AddComponent<Text>();
           c.text = "3";
           c.color = new Color(0.396078f, 0.984314f, 0.396078f, 1.000000f);
           c.fontSize = 25;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 70;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-4907494804830526061L].AddComponent<Text>();
           c.text = "99级学习";
           c.color = new Color(1.000000f, 1.000000f, 0.800000f, 1.000000f);
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
           c.resizeTextMaxSize = 70;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-8859214668307593655L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_locked");
        }
        { var c = goMap[9063958857194198518L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.raycastTarget = true;
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
        { var c = goMap[-6063926043197739696L].AddComponent<Text>();
           c.text = "I";
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
           c.resizeTextMinSize = 1;
           c.resizeTextMaxSize = 40;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[6808388302714695786L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("btn_skill_bg");
        }
        { var c = goMap[6808388302714695786L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-6514676742962530142L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.784314f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Filled;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 0.000000f;
           c.fillClockwise = false;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 2;
           c.enabled = true;
           c.sprite = LookupSprite("img_skillcd");
        }
        { var c = goMap[5092884888898161205L].AddComponent<Text>();
           c.text = "10";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 28;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 70;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-4684606610209150593L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Filled;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 0.000000f;
           c.fillClockwise = false;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 2;
           c.enabled = true;
           c.sprite = LookupSprite("img_skillusepoint");
        }
        { var c = goMap[6025753770910659253L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_skillcd");
        }
        { var c = goMap[5292784270193578425L].AddComponent<Text>();
           c.text = "3";
           c.color = new Color(0.396078f, 0.984314f, 0.396078f, 1.000000f);
           c.fontSize = 25;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 70;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[5195321321574292861L].AddComponent<Text>();
           c.text = "99级学习";
           c.color = new Color(1.000000f, 1.000000f, 0.800000f, 1.000000f);
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
           c.resizeTextMaxSize = 70;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-2052208102064299634L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_locked");
        }
        { var c = goMap[5311371466097208087L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.raycastTarget = true;
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
        { var c = goMap[4104077730807241263L].AddComponent<Text>();
           c.text = "O";
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
           c.resizeTextMinSize = 1;
           c.resizeTextMaxSize = 40;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[3724969905040145829L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("btn_motion");
        }
        { var c = goMap[3724969905040145829L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[2285784354919624874L].AddComponent<Text>();
           c.text = "帮";
           c.color = new Color(0.000000f, 0.703955f, 1.000000f, 1.000000f);
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
        { var c = goMap[2285784354919624874L].AddComponent<Outline>();
           c.effectColor = new Color(0.023529f, 0.149020f, 0.043137f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-6183717179574427006L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.000000f, 0.000000f, 0.627451f);
           c.raycastTarget = false;
           c.maskable = true;
           c.type = Image.Type.Filled;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 0.000000f;
           c.fillClockwise = false;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 2;
           c.enabled = true;
           c.sprite = LookupSprite("img_circular");
        }
        { var c = goMap[-6317327717682246726L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.000000f, 0.000000f, 0.588235f);
           c.raycastTarget = false;
           c.maskable = true;
           c.type = Image.Type.Filled;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 0.000000f;
           c.fillClockwise = false;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 2;
           c.enabled = true;
           c.sprite = LookupSprite("img_circular");
        }
        { var c = goMap[1570330872980603920L].AddComponent<Text>();
           c.text = "999";
           c.color = new Color(0.984314f, 0.321569f, 0.321569f, 0.000000f);
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
        { var c = goMap[1570330872980603920L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, 1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[6300241840580095445L].AddComponent<Text>();
           c.text = "999";
           c.color = new Color(0.984314f, 0.321569f, 0.321569f, 1.000000f);
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
        { var c = goMap[6300241840580095445L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, 1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[7409389323368433024L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("btn_motion");
        }
        { var c = goMap[7409389323368433024L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-765153702701176898L].AddComponent<Text>();
           c.text = "正";
           c.color = new Color(1.000000f, 0.517647f, 0.333333f, 1.000000f);
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
        { var c = goMap[-765153702701176898L].AddComponent<Outline>();
           c.effectColor = new Color(0.376471f, 0.141176f, 0.050980f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, 1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-6527691034233822723L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.000000f, 0.000000f, 0.627451f);
           c.raycastTarget = false;
           c.maskable = true;
           c.type = Image.Type.Filled;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 0.000000f;
           c.fillClockwise = false;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 2;
           c.enabled = true;
           c.sprite = LookupSprite("img_circular");
        }
        { var c = goMap[6558214718643765950L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.000000f, 0.000000f, 0.588235f);
           c.raycastTarget = false;
           c.maskable = true;
           c.type = Image.Type.Filled;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 0.000000f;
           c.fillClockwise = false;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 2;
           c.enabled = true;
           c.sprite = LookupSprite("img_circular");
        }
        { var c = goMap[-6171738257053796066L].AddComponent<Text>();
           c.text = "999";
           c.color = new Color(0.984314f, 0.321569f, 0.321569f, 0.000000f);
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
        { var c = goMap[-6171738257053796066L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, 1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-4972747254247415717L].AddComponent<Text>();
           c.text = "999";
           c.color = new Color(0.984314f, 0.321569f, 0.321569f, 1.000000f);
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
        { var c = goMap[-4972747254247415717L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, 1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[2022348217077567644L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("btn_motion");
        }
        { var c = goMap[2022348217077567644L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[5307649616257537927L].AddComponent<Text>();
           c.text = "中";
           c.color = new Color(0.333333f, 1.000000f, 0.427451f, 1.000000f);
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
        { var c = goMap[5307649616257537927L].AddComponent<Outline>();
           c.effectColor = new Color(0.023529f, 0.149020f, 0.043137f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-8328865442789105240L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.000000f, 0.000000f, 0.627451f);
           c.raycastTarget = false;
           c.maskable = true;
           c.type = Image.Type.Filled;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 0.000000f;
           c.fillClockwise = false;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 2;
           c.enabled = true;
           c.sprite = LookupSprite("img_circular");
        }
        { var c = goMap[4525060424070368289L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.000000f, 0.000000f, 0.588235f);
           c.raycastTarget = false;
           c.maskable = true;
           c.type = Image.Type.Filled;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 0.000000f;
           c.fillClockwise = false;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 2;
           c.enabled = true;
           c.sprite = LookupSprite("img_circular");
        }
        { var c = goMap[-3337763184212787673L].AddComponent<Text>();
           c.text = "999";
           c.color = new Color(0.984314f, 0.321569f, 0.321569f, 0.000000f);
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
        { var c = goMap[-3337763184212787673L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, 1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-2559392933116311911L].AddComponent<Text>();
           c.text = "999";
           c.color = new Color(0.984314f, 0.321569f, 0.321569f, 1.000000f);
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
        { var c = goMap[-2559392933116311911L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, 1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-2644452386813790099L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("btn_motion");
        }
        { var c = goMap[-2644452386813790099L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[5751900236404203427L].AddComponent<Text>();
           c.text = "邪";
           c.color = new Color(1.000000f, 0.333333f, 0.960784f, 1.000000f);
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
        { var c = goMap[5751900236404203427L].AddComponent<Outline>();
           c.effectColor = new Color(0.200000f, 0.031373f, 0.188235f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[2904770196660660045L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.000000f, 0.000000f, 0.627451f);
           c.raycastTarget = false;
           c.maskable = true;
           c.type = Image.Type.Filled;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 0.000000f;
           c.fillClockwise = false;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 2;
           c.enabled = true;
           c.sprite = LookupSprite("img_circular");
        }
        { var c = goMap[5770348884974793421L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.000000f, 0.000000f, 0.588235f);
           c.raycastTarget = false;
           c.maskable = true;
           c.type = Image.Type.Filled;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 0.000000f;
           c.fillClockwise = false;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 2;
           c.enabled = true;
           c.sprite = LookupSprite("img_circular");
        }
        { var c = goMap[-8676323578187220487L].AddComponent<Text>();
           c.text = "999";
           c.color = new Color(0.984314f, 0.321569f, 0.321569f, 0.000000f);
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
        { var c = goMap[-8676323578187220487L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, 1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-2226849749700380895L].AddComponent<Text>();
           c.text = "999";
           c.color = new Color(0.984314f, 0.321569f, 0.321569f, 1.000000f);
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
        { var c = goMap[-2226849749700380895L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, 1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[834687017711717292L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_circular");
        }
        { var c = goMap[2748308880132554528L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.745956f, 1.000000f, 1.000000f);
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
           c.sprite = LookupSprite("img_circular");
        }
        { var c = goMap[-3031763653391634264L].AddComponent<Image>();
           c.color = new Color(1.000000f, 0.053741f, 0.000000f, 1.000000f);
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
           c.sprite = LookupSprite("img_circular");
        }
        { var c = goMap[7012829260713158418L].AddComponent<Image>();
           c.color = new Color(0.679245f, 0.679245f, 0.679245f, 0.858824f);
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
           c.sprite = LookupSprite("img_circular");
        }
        { var c = goMap[-8141538957844588804L].AddComponent<Image>();
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
           c.sprite = LookupSprite("btn_skill_bg");
        }
        { var c = goMap[2183930071166712069L].AddComponent<Text>();
           c.text = "取消";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 22;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 22;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-3202376101565362456L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("btn_skill_bg");
        }
        { var c = goMap[-3202376101565362456L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-1847392839987607762L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Filled;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 0.000000f;
           c.fillClockwise = false;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 2;
           c.enabled = true;
           c.sprite = LookupSprite("img_skillcd");
        }
        { var c = goMap[-7656686862451681279L].AddComponent<Text>();
           c.text = "10";
           c.color = new Color(1.000000f, 1.000000f, 0.800000f, 1.000000f);
           c.fontSize = 38;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 3;
           c.resizeTextMaxSize = 70;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[3824338068560615823L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Filled;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 0.000000f;
           c.fillClockwise = false;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 2;
           c.enabled = true;
           c.sprite = LookupSprite("img_skillusepoint");
        }
        { var c = goMap[-6922416529777263049L].AddComponent<Text>();
           c.text = "3";
           c.color = new Color(0.396078f, 0.984314f, 0.396078f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 70;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[68091241504638832L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_skillcd");
        }
        { var c = goMap[5799186231942803867L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-3117298033521374793L].AddComponent<Text>();
           c.text = "9999";
           c.color = new Color(0.396078f, 0.984314f, 0.396078f, 1.000000f);
           c.fontSize = 20;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleRight;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Overflow;
           c.verticalOverflow = VerticalWrapMode.Overflow;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 1;
           c.resizeTextMaxSize = 70;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[9084154749753190381L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_skillcd");
        }
        { var c = goMap[2204507256174152521L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.raycastTarget = true;
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
        { var c = goMap[-2841585352275090228L].AddComponent<Text>();
           c.text = "H";
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
           c.resizeTextMinSize = 1;
           c.resizeTextMaxSize = 40;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[6448561864505022193L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("btn_manual");
        }
        { var c = goMap[6448561864505022193L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[265972771125574157L].AddComponent<Text>();
           c.text = "手动";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 18;
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
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[265972771125574157L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-8965038464424305431L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.raycastTarget = true;
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
        { var c = goMap[-6352839020668222238L].AddComponent<Text>();
           c.text = "F";
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
           c.resizeTextMinSize = 1;
           c.resizeTextMaxSize = 40;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[3535413626053756433L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("btn_auto");
        }
        { var c = goMap[3535413626053756433L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-5245693610933703615L].AddComponent<Text>();
           c.text = "自动";
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
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-5245693610933703615L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.500000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[8742052578064954519L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.raycastTarget = true;
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
        { var c = goMap[-1790091547151766849L].AddComponent<Text>();
           c.text = "F";
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
           c.resizeTextMinSize = 1;
           c.resizeTextMaxSize = 40;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[4913519792906914546L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("btn_skill_bg");
        }
        { var c = goMap[4913519792906914546L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[8380223691777849941L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Filled;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 0.000000f;
           c.fillClockwise = false;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 2;
           c.enabled = true;
           c.sprite = LookupSprite("img_skillcd");
        }
        { var c = goMap[-101559371840674367L].AddComponent<Text>();
           c.text = "10";
           c.color = new Color(1.000000f, 1.000000f, 0.800000f, 1.000000f);
           c.fontSize = 30;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 70;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-3240014703483295585L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Filled;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 0.000000f;
           c.fillClockwise = false;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 2;
           c.enabled = true;
           c.sprite = LookupSprite("img_skillusepoint");
        }
        { var c = goMap[4445052976092313583L].AddComponent<Text>();
           c.text = "3";
           c.color = new Color(0.396078f, 0.984314f, 0.396078f, 1.000000f);
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
           c.resizeTextMaxSize = 70;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[4233185735053625867L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_activity_markbg");
        }
        { var c = goMap[-528258494804935527L].AddComponent<Text>();
           c.text = "空格";
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
           c.resizeTextMinSize = 10;
           c.resizeTextMaxSize = 18;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-9163990204722043384L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("btn_skill_bg");
        }
        { var c = goMap[-9163990204722043384L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-2397032916046080846L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Filled;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 0.000000f;
           c.fillClockwise = false;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 2;
           c.enabled = true;
           c.sprite = LookupSprite("img_skillcd");
        }
        { var c = goMap[-7872213626190719830L].AddComponent<Text>();
           c.text = "10";
           c.color = new Color(1.000000f, 1.000000f, 0.800000f, 1.000000f);
           c.fontSize = 30;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 70;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[7316762769053103884L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Filled;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 0.000000f;
           c.fillClockwise = false;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 2;
           c.enabled = true;
           c.sprite = LookupSprite("img_skillusepoint");
        }
        { var c = goMap[-413135616190048636L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_locked");
        }
        { var c = goMap[8040436650192479410L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_unlock");
        }
        { var c = goMap[-7806845672604755148L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[2653439226259348729L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_hud_handle");
        }
        { var c = goMap[-3117203015968352357L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_hud_handle");
        }
        { var c = goMap[-3634240885161816432L].AddComponent<Image>();
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
           c.sprite = LookupSprite("btn_skill_bg");
        }
        { var c = goMap[-3634240885161816432L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[1453364372587689086L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("btn_target");
        }
        { var c = goMap[-3238541514736070332L].AddComponent<Text>();
           c.text = "目标";
           c.color = new Color(1.000000f, 1.000000f, 0.800000f, 1.000000f);
           c.fontSize = 18;
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
           c.enabled = false;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-604381086727030260L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_skillcd");
        }
        { var c = goMap[-8431732466732635421L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.raycastTarget = true;
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
        { var c = goMap[-5032876086891915949L].AddComponent<Text>();
           c.text = "Q";
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
           c.resizeTextMinSize = 1;
           c.resizeTextMaxSize = 40;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-959899472340865441L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("btn_skill_bg");
        }
        { var c = goMap[-959899472340865441L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[5049302239516006484L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 0.784314f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Filled;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 0.000000f;
           c.fillClockwise = false;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 2;
           c.enabled = true;
           c.sprite = LookupSprite("img_skillcd");
        }
        { var c = goMap[1956788135510404163L].AddComponent<Text>();
           c.text = "10";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 28;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 70;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[5247181220983650622L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Filled;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 0.000000f;
           c.fillClockwise = false;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 2;
           c.enabled = true;
           c.sprite = LookupSprite("img_skillusepoint");
        }
        { var c = goMap[7745105872495901956L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_skillcd");
        }
        { var c = goMap[3039768255981816252L].AddComponent<Text>();
           c.text = "3";
           c.color = new Color(0.396078f, 0.984314f, 0.396078f, 1.000000f);
           c.fontSize = 25;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 2;
           c.resizeTextMaxSize = 70;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[8109975175002384414L].AddComponent<Text>();
           c.text = "99级学习";
           c.color = new Color(1.000000f, 1.000000f, 0.800000f, 1.000000f);
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
           c.resizeTextMaxSize = 70;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-1161962047489786518L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_locked");
        }
        { var c = goMap[1340200135462406413L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.raycastTarget = true;
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
        { var c = goMap[-1501922615769999554L].AddComponent<Text>();
           c.text = "I";
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
           c.resizeTextMinSize = 1;
           c.resizeTextMaxSize = 40;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }

        // ─── Save prefab ─────────────────────────────────────
        Directory.CreateDirectory("Assets/Prefabs/Imported");
        var rootGO = goMap[-505170310806722818L];
        string path = "Assets/Prefabs/Imported/UIHudRightSkill.prefab";
        PrefabUtility.SaveAsPrefabAsset(rootGO, path);
        Object.DestroyImmediate(rootGO);
        Debug.Log("[Import_res_p_104] Saved " + path);
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
}