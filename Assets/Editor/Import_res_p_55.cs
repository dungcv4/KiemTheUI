// AUTO-GENERATED from res_p_55.ab — DO NOT EDIT MANUALLY.
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;
using System.Collections.Generic;
using System.Reflection;
using I2.Loc;

public class Import_res_p_55
{
    [MenuItem("KTO/Import/res_p_55")]
    public static void Build()
    {
        Debug.Log("[Import_res_p_55] Building UICreateRole...");

        // ─── Create all GameObjects ───────────────────────────
        var goMap = new Dictionary<long, GameObject>();
        { var go = new GameObject("UICreateRole"); go.SetActive(true); goMap[4271273089317044952L] = go; }
        { var go = new GameObject("imgBG"); go.SetActive(true); goMap[-5957422566960681333L] = go; }
        { var go = new GameObject("imgShadow"); go.SetActive(true); goMap[-6798353631814109257L] = go; }
        { var go = new GameObject("btnReturn"); go.SetActive(true); goMap[990567454976288233L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[5763557359389786042L] = go; }
        { var go = new GameObject("PanelCreateRole"); go.SetActive(true); goMap[8708534815418200256L] = go; }
        { var go = new GameObject("imgInputName"); go.SetActive(true); goMap[-410095182932259793L] = go; }
        { var go = new GameObject("inputRoleName"); go.SetActive(true); goMap[8791628711457671664L] = go; }
        { var go = new GameObject("Placeholder"); go.SetActive(true); goMap[2742240321075408148L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[1345754868160353766L] = go; }
        { var go = new GameObject("btnRandRoleName"); go.SetActive(true); goMap[-3588654977203044116L] = go; }
        { var go = new GameObject("FactionInfo"); go.SetActive(true); goMap[-2405690622590338207L] = go; }
        { var go = new GameObject("BG"); go.SetActive(true); goMap[-238685380400369890L] = go; }
        { var go = new GameObject("imgFactionTxt"); go.SetActive(false); goMap[-5894637090637446858L] = go; }
        { var go = new GameObject("imgSeriesMetal"); go.SetActive(false); goMap[1008643446575695081L] = go; }
        { var go = new GameObject("SeriesText"); go.SetActive(true); goMap[-4172480587894130087L] = go; }
        { var go = new GameObject("txtMetal"); go.SetActive(true); goMap[217333393460229540L] = go; }
        { var go = new GameObject("txtWood"); go.SetActive(false); goMap[4014137510617869995L] = go; }
        { var go = new GameObject("txtWater"); go.SetActive(false); goMap[-3108589251172947768L] = go; }
        { var go = new GameObject("txtFire"); go.SetActive(false); goMap[4538177999214186772L] = go; }
        { var go = new GameObject("txtEarth"); go.SetActive(false); goMap[4207516675672706224L] = go; }
        { var go = new GameObject("Faction"); go.SetActive(true); goMap[-4886363794103256737L] = go; }
        { var go = new GameObject("Fire_Effect"); go.SetActive(true); goMap[-7838134828542674151L] = go; }
        { var go = new GameObject("BG"); go.SetActive(true); goMap[6913450795335797691L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[1114574383277648428L] = go; }
        { var go = new GameObject("RaoDong"); go.SetActive(true); goMap[-7859743502503758854L] = go; }
        { var go = new GameObject("LiuGuang"); go.SetActive(true); goMap[-7772671734558205840L] = go; }
        { var go = new GameObject("FireStar"); go.SetActive(false); goMap[4906960004077644659L] = go; }
        { var go = new GameObject("Metal_Effect"); go.SetActive(true); goMap[2662338375045730787L] = go; }
        { var go = new GameObject("BG"); go.SetActive(true); goMap[4303969278622449371L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[290016822104568891L] = go; }
        { var go = new GameObject("RaoDong"); go.SetActive(true); goMap[-4251294226241157785L] = go; }
        { var go = new GameObject("LiuGuang"); go.SetActive(true); goMap[1180459555382424481L] = go; }
        { var go = new GameObject("FireStar"); go.SetActive(false); goMap[965800175516728121L] = go; }
        { var go = new GameObject("Earth_Effect"); go.SetActive(false); goMap[-5036261640627051572L] = go; }
        { var go = new GameObject("BG"); go.SetActive(true); goMap[-8473877606902557450L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-2962375905180152978L] = go; }
        { var go = new GameObject("RaoDong"); go.SetActive(true); goMap[4598401087194501333L] = go; }
        { var go = new GameObject("LiuGuang"); go.SetActive(true); goMap[2707760979904832091L] = go; }
        { var go = new GameObject("FireStar"); go.SetActive(false); goMap[4753094666550475684L] = go; }
        { var go = new GameObject("Water_Effect"); go.SetActive(false); goMap[-9220266554761468308L] = go; }
        { var go = new GameObject("BG"); go.SetActive(true); goMap[-568218722910650998L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-7148981038486249995L] = go; }
        { var go = new GameObject("RaoDong"); go.SetActive(true); goMap[1725474597534898591L] = go; }
        { var go = new GameObject("LiuGuang"); go.SetActive(true); goMap[4674279812422491816L] = go; }
        { var go = new GameObject("FireStar"); go.SetActive(false); goMap[4101740786217008135L] = go; }
        { var go = new GameObject("Wood_Effect"); go.SetActive(false); goMap[6038769253223626071L] = go; }
        { var go = new GameObject("BG"); go.SetActive(true); goMap[114921855123917447L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[5565108161967469151L] = go; }
        { var go = new GameObject("RaoDong"); go.SetActive(true); goMap[5527901731769069917L] = go; }
        { var go = new GameObject("LiuGuang"); go.SetActive(true); goMap[-1872589554798487423L] = go; }
        { var go = new GameObject("FireStar"); go.SetActive(false); goMap[-4567827929578254067L] = go; }
        { var go = new GameObject("FactionInfo"); go.SetActive(true); goMap[-3725790120443405577L] = go; }
        { var go = new GameObject("imgFactionInfoBg"); go.SetActive(true); goMap[-9071483163238143281L] = go; }
        { var go = new GameObject("imgFactionInfo"); go.SetActive(true); goMap[7850525672503268368L] = go; }
        { var go = new GameObject("txtAttribute1"); go.SetActive(true); goMap[557401503329319989L] = go; }
        { var go = new GameObject("txtAttribute2"); go.SetActive(true); goMap[8773051742914492585L] = go; }
        { var go = new GameObject("txtAttribute3"); go.SetActive(true); goMap[7395742575067980146L] = go; }
        { var go = new GameObject("txtAttribute4"); go.SetActive(true); goMap[-7972357491050523135L] = go; }
        { var go = new GameObject("txtAttribute5"); go.SetActive(true); goMap[-231706938876365947L] = go; }
        { var go = new GameObject("txtAttribute6"); go.SetActive(true); goMap[3774099341825457830L] = go; }
        { var go = new GameObject("txtFactionDesc"); go.SetActive(true); goMap[8658098461315931975L] = go; }
        { var go = new GameObject("btnCreateRole"); go.SetActive(true); goMap[-3993503144425037068L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[8725548046853645485L] = go; }
        { var go = new GameObject("SelectGender"); go.SetActive(true); goMap[-1726799648922068095L] = go; }
        { var go = new GameObject("btnFemale"); go.SetActive(true); goMap[-9196012875113975151L] = go; }
        { var go = new GameObject("btnMale"); go.SetActive(true); goMap[-6657872601965833236L] = go; }
        { var go = new GameObject("SelectSeries"); go.SetActive(true); goMap[3185465335275681127L] = go; }
        { var go = new GameObject("imgSelectFactionBg"); go.SetActive(true); goMap[-286028278976624947L] = go; }
        { var go = new GameObject("txtSelectedSeries"); go.SetActive(true); goMap[-2838673083462345624L] = go; }
        { var go = new GameObject("btnArrowUp"); go.SetActive(true); goMap[-8835777817934898060L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[-2023599638178868068L] = go; }
        { var go = new GameObject("btnArrowDown"); go.SetActive(true); goMap[-4301653686471364667L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[-2309750405881040988L] = go; }
        { var go = new GameObject("SelectGender2"); go.SetActive(true); goMap[-8405965851517658361L] = go; }
        { var go = new GameObject("btnFemale"); go.SetActive(true); goMap[241350737396141613L] = go; }
        { var go = new GameObject("btnMale"); go.SetActive(true); goMap[-1376381583251762219L] = go; }
        { var go = new GameObject("FactionSeriesList"); go.SetActive(true); goMap[3474341260163918500L] = go; }
        { var go = new GameObject("SeriesList"); go.SetActive(false); goMap[-2205009208734912041L] = go; }
        { var go = new GameObject("Metal"); go.SetActive(true); goMap[-6515105284288533975L] = go; }
        { var go = new GameObject("imgMetal"); go.SetActive(true); goMap[-5798208218235459882L] = go; }
        { var go = new GameObject("imgSelect"); go.SetActive(true); goMap[-1816257820259273313L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[6367024589426156139L] = go; }
        { var go = new GameObject("Wood"); go.SetActive(true); goMap[-6905832038270292756L] = go; }
        { var go = new GameObject("imgWood"); go.SetActive(true); goMap[7580840332442818525L] = go; }
        { var go = new GameObject("imgSelect"); go.SetActive(true); goMap[-6429501728678524461L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-357425684516940382L] = go; }
        { var go = new GameObject("Water"); go.SetActive(true); goMap[-43873865111887362L] = go; }
        { var go = new GameObject("imgWater"); go.SetActive(true); goMap[-9193240005511291718L] = go; }
        { var go = new GameObject("imgSelect"); go.SetActive(true); goMap[7103809506789838195L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-7159687639865966115L] = go; }
        { var go = new GameObject("Fire"); go.SetActive(true); goMap[6085733076097110800L] = go; }
        { var go = new GameObject("imgFire"); go.SetActive(true); goMap[7732620158930536837L] = go; }
        { var go = new GameObject("imgSelect"); go.SetActive(true); goMap[-3680672302836669507L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-2313609112355251505L] = go; }
        { var go = new GameObject("Earth"); go.SetActive(true); goMap[-8335787953482761326L] = go; }
        { var go = new GameObject("imgEarth"); go.SetActive(true); goMap[-5197117477205302507L] = go; }
        { var go = new GameObject("imgSelect"); go.SetActive(true); goMap[-5591798237181283959L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-7401365494474935156L] = go; }
        { var go = new GameObject("FactionList"); go.SetActive(true); goMap[-6864146390819006932L] = go; }
        { var go = new GameObject("FactionTemplate"); go.SetActive(true); goMap[-8425866967006347552L] = go; }
        { var go = new GameObject("imgBg"); go.SetActive(true); goMap[2336028557759271801L] = go; }
        { var go = new GameObject("imgIcon"); go.SetActive(true); goMap[2800998152632357630L] = go; }
        { var go = new GameObject("imgSelected"); go.SetActive(true); goMap[-7181435786815480095L] = go; }
        { var go = new GameObject("Click_Effect"); go.SetActive(true); goMap[-4108142243437250371L] = go; }
        { var go = new GameObject("M1"); go.SetActive(true); goMap[-6262023056239275535L] = go; }
        { var go = new GameObject("M2"); go.SetActive(true); goMap[-4402897887020896732L] = go; }
        { var go = new GameObject("M3"); go.SetActive(true); goMap[2766487223777188707L] = go; }
        { var go = new GameObject("M4"); go.SetActive(true); goMap[-4440031378572487105L] = go; }

        // ─── Parent links ─────────────────────────────────────
        goMap[-5957422566960681333L].transform.SetParent(goMap[4271273089317044952L].transform, false);
        goMap[-6798353631814109257L].transform.SetParent(goMap[-5957422566960681333L].transform, false);
        goMap[990567454976288233L].transform.SetParent(goMap[-5957422566960681333L].transform, false);
        goMap[5763557359389786042L].transform.SetParent(goMap[990567454976288233L].transform, false);
        goMap[8708534815418200256L].transform.SetParent(goMap[-5957422566960681333L].transform, false);
        goMap[-410095182932259793L].transform.SetParent(goMap[8708534815418200256L].transform, false);
        goMap[8791628711457671664L].transform.SetParent(goMap[-410095182932259793L].transform, false);
        goMap[2742240321075408148L].transform.SetParent(goMap[8791628711457671664L].transform, false);
        goMap[1345754868160353766L].transform.SetParent(goMap[8791628711457671664L].transform, false);
        goMap[-3588654977203044116L].transform.SetParent(goMap[8708534815418200256L].transform, false);
        goMap[-2405690622590338207L].transform.SetParent(goMap[-5957422566960681333L].transform, false);
        goMap[-238685380400369890L].transform.SetParent(goMap[-2405690622590338207L].transform, false);
        goMap[-5894637090637446858L].transform.SetParent(goMap[-2405690622590338207L].transform, false);
        goMap[1008643446575695081L].transform.SetParent(goMap[-2405690622590338207L].transform, false);
        goMap[-4172480587894130087L].transform.SetParent(goMap[-2405690622590338207L].transform, false);
        goMap[217333393460229540L].transform.SetParent(goMap[-4172480587894130087L].transform, false);
        goMap[4014137510617869995L].transform.SetParent(goMap[-4172480587894130087L].transform, false);
        goMap[-3108589251172947768L].transform.SetParent(goMap[-4172480587894130087L].transform, false);
        goMap[4538177999214186772L].transform.SetParent(goMap[-4172480587894130087L].transform, false);
        goMap[4207516675672706224L].transform.SetParent(goMap[-4172480587894130087L].transform, false);
        goMap[-4886363794103256737L].transform.SetParent(goMap[-2405690622590338207L].transform, false);
        goMap[-7838134828542674151L].transform.SetParent(goMap[-4886363794103256737L].transform, false);
        goMap[6913450795335797691L].transform.SetParent(goMap[-7838134828542674151L].transform, false);
        goMap[1114574383277648428L].transform.SetParent(goMap[-7838134828542674151L].transform, false);
        goMap[-7859743502503758854L].transform.SetParent(goMap[-7838134828542674151L].transform, false);
        goMap[-7772671734558205840L].transform.SetParent(goMap[-7838134828542674151L].transform, false);
        goMap[4906960004077644659L].transform.SetParent(goMap[-7838134828542674151L].transform, false);
        goMap[2662338375045730787L].transform.SetParent(goMap[-4886363794103256737L].transform, false);
        goMap[4303969278622449371L].transform.SetParent(goMap[2662338375045730787L].transform, false);
        goMap[290016822104568891L].transform.SetParent(goMap[2662338375045730787L].transform, false);
        goMap[-4251294226241157785L].transform.SetParent(goMap[2662338375045730787L].transform, false);
        goMap[1180459555382424481L].transform.SetParent(goMap[2662338375045730787L].transform, false);
        goMap[965800175516728121L].transform.SetParent(goMap[2662338375045730787L].transform, false);
        goMap[-5036261640627051572L].transform.SetParent(goMap[-4886363794103256737L].transform, false);
        goMap[-8473877606902557450L].transform.SetParent(goMap[-5036261640627051572L].transform, false);
        goMap[-2962375905180152978L].transform.SetParent(goMap[-5036261640627051572L].transform, false);
        goMap[4598401087194501333L].transform.SetParent(goMap[-5036261640627051572L].transform, false);
        goMap[2707760979904832091L].transform.SetParent(goMap[-5036261640627051572L].transform, false);
        goMap[4753094666550475684L].transform.SetParent(goMap[-5036261640627051572L].transform, false);
        goMap[-9220266554761468308L].transform.SetParent(goMap[-4886363794103256737L].transform, false);
        goMap[-568218722910650998L].transform.SetParent(goMap[-9220266554761468308L].transform, false);
        goMap[-7148981038486249995L].transform.SetParent(goMap[-9220266554761468308L].transform, false);
        goMap[1725474597534898591L].transform.SetParent(goMap[-9220266554761468308L].transform, false);
        goMap[4674279812422491816L].transform.SetParent(goMap[-9220266554761468308L].transform, false);
        goMap[4101740786217008135L].transform.SetParent(goMap[-9220266554761468308L].transform, false);
        goMap[6038769253223626071L].transform.SetParent(goMap[-4886363794103256737L].transform, false);
        goMap[114921855123917447L].transform.SetParent(goMap[6038769253223626071L].transform, false);
        goMap[5565108161967469151L].transform.SetParent(goMap[6038769253223626071L].transform, false);
        goMap[5527901731769069917L].transform.SetParent(goMap[6038769253223626071L].transform, false);
        goMap[-1872589554798487423L].transform.SetParent(goMap[6038769253223626071L].transform, false);
        goMap[-4567827929578254067L].transform.SetParent(goMap[6038769253223626071L].transform, false);
        goMap[-3725790120443405577L].transform.SetParent(goMap[-2405690622590338207L].transform, false);
        goMap[-9071483163238143281L].transform.SetParent(goMap[-3725790120443405577L].transform, false);
        goMap[7850525672503268368L].transform.SetParent(goMap[-3725790120443405577L].transform, false);
        goMap[557401503329319989L].transform.SetParent(goMap[-3725790120443405577L].transform, false);
        goMap[8773051742914492585L].transform.SetParent(goMap[-3725790120443405577L].transform, false);
        goMap[7395742575067980146L].transform.SetParent(goMap[-3725790120443405577L].transform, false);
        goMap[-7972357491050523135L].transform.SetParent(goMap[-3725790120443405577L].transform, false);
        goMap[-231706938876365947L].transform.SetParent(goMap[-3725790120443405577L].transform, false);
        goMap[3774099341825457830L].transform.SetParent(goMap[-3725790120443405577L].transform, false);
        goMap[8658098461315931975L].transform.SetParent(goMap[-2405690622590338207L].transform, false);
        goMap[-3993503144425037068L].transform.SetParent(goMap[-5957422566960681333L].transform, false);
        goMap[8725548046853645485L].transform.SetParent(goMap[-3993503144425037068L].transform, false);
        goMap[-1726799648922068095L].transform.SetParent(goMap[-5957422566960681333L].transform, false);
        goMap[-9196012875113975151L].transform.SetParent(goMap[-1726799648922068095L].transform, false);
        goMap[-6657872601965833236L].transform.SetParent(goMap[-1726799648922068095L].transform, false);
        goMap[3185465335275681127L].transform.SetParent(goMap[-5957422566960681333L].transform, false);
        goMap[-286028278976624947L].transform.SetParent(goMap[3185465335275681127L].transform, false);
        goMap[-2838673083462345624L].transform.SetParent(goMap[3185465335275681127L].transform, false);
        goMap[-8835777817934898060L].transform.SetParent(goMap[3185465335275681127L].transform, false);
        goMap[-2023599638178868068L].transform.SetParent(goMap[-8835777817934898060L].transform, false);
        goMap[-4301653686471364667L].transform.SetParent(goMap[3185465335275681127L].transform, false);
        goMap[-2309750405881040988L].transform.SetParent(goMap[-4301653686471364667L].transform, false);
        goMap[-8405965851517658361L].transform.SetParent(goMap[-5957422566960681333L].transform, false);
        goMap[241350737396141613L].transform.SetParent(goMap[-8405965851517658361L].transform, false);
        goMap[-1376381583251762219L].transform.SetParent(goMap[-8405965851517658361L].transform, false);
        goMap[3474341260163918500L].transform.SetParent(goMap[-5957422566960681333L].transform, false);
        goMap[-2205009208734912041L].transform.SetParent(goMap[3474341260163918500L].transform, false);
        goMap[-6515105284288533975L].transform.SetParent(goMap[-2205009208734912041L].transform, false);
        goMap[-5798208218235459882L].transform.SetParent(goMap[-6515105284288533975L].transform, false);
        goMap[-1816257820259273313L].transform.SetParent(goMap[-6515105284288533975L].transform, false);
        goMap[6367024589426156139L].transform.SetParent(goMap[-6515105284288533975L].transform, false);
        goMap[-6905832038270292756L].transform.SetParent(goMap[-2205009208734912041L].transform, false);
        goMap[7580840332442818525L].transform.SetParent(goMap[-6905832038270292756L].transform, false);
        goMap[-6429501728678524461L].transform.SetParent(goMap[-6905832038270292756L].transform, false);
        goMap[-357425684516940382L].transform.SetParent(goMap[-6905832038270292756L].transform, false);
        goMap[-43873865111887362L].transform.SetParent(goMap[-2205009208734912041L].transform, false);
        goMap[-9193240005511291718L].transform.SetParent(goMap[-43873865111887362L].transform, false);
        goMap[7103809506789838195L].transform.SetParent(goMap[-43873865111887362L].transform, false);
        goMap[-7159687639865966115L].transform.SetParent(goMap[-43873865111887362L].transform, false);
        goMap[6085733076097110800L].transform.SetParent(goMap[-2205009208734912041L].transform, false);
        goMap[7732620158930536837L].transform.SetParent(goMap[6085733076097110800L].transform, false);
        goMap[-3680672302836669507L].transform.SetParent(goMap[6085733076097110800L].transform, false);
        goMap[-2313609112355251505L].transform.SetParent(goMap[6085733076097110800L].transform, false);
        goMap[-8335787953482761326L].transform.SetParent(goMap[-2205009208734912041L].transform, false);
        goMap[-5197117477205302507L].transform.SetParent(goMap[-8335787953482761326L].transform, false);
        goMap[-5591798237181283959L].transform.SetParent(goMap[-8335787953482761326L].transform, false);
        goMap[-7401365494474935156L].transform.SetParent(goMap[-8335787953482761326L].transform, false);
        goMap[-6864146390819006932L].transform.SetParent(goMap[3474341260163918500L].transform, false);
        goMap[-8425866967006347552L].transform.SetParent(goMap[-6864146390819006932L].transform, false);
        goMap[2336028557759271801L].transform.SetParent(goMap[-8425866967006347552L].transform, false);
        goMap[2800998152632357630L].transform.SetParent(goMap[-8425866967006347552L].transform, false);
        goMap[-7181435786815480095L].transform.SetParent(goMap[-8425866967006347552L].transform, false);
        goMap[-4108142243437250371L].transform.SetParent(goMap[-7181435786815480095L].transform, false);
        goMap[-6262023056239275535L].transform.SetParent(goMap[-4108142243437250371L].transform, false);
        goMap[-4402897887020896732L].transform.SetParent(goMap[-4108142243437250371L].transform, false);
        goMap[2766487223777188707L].transform.SetParent(goMap[-4108142243437250371L].transform, false);
        goMap[-4440031378572487105L].transform.SetParent(goMap[-4108142243437250371L].transform, false);

        // ─── Transforms ──────────────────────────────────────
        {
            var rt = goMap[4271273089317044952L].AddComponent<RectTransform>();
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
            var rt = goMap[-5957422566960681333L].AddComponent<RectTransform>();
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
            var rt = goMap[-6798353631814109257L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.707107f,0.707107f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.000000f);
            rt.anchorMax = new Vector2(0.500000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(27.437195f, 98.837219f);
            rt.sizeDelta = new Vector2(195.674301f, 1794.345825f);
        }
        {
            var rt = goMap[990567454976288233L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.500000f);
            rt.anchorMax = new Vector2(0.000000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(126.000000f, -300.000000f);
            rt.sizeDelta = new Vector2(120.000000f, 52.000000f);
        }
        {
            var rt = goMap[5763557359389786042L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 3.000000f);
            rt.sizeDelta = new Vector2(120.000000f, 40.000000f);
        }
        {
            var rt = goMap[8708534815418200256L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.000000f);
            rt.anchorMax = new Vector2(0.500000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-61.000000f, 125.699997f);
            rt.sizeDelta = new Vector2(500.000000f, 300.000000f);
        }
        {
            var rt = goMap[-410095182932259793L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.000000f);
            rt.anchorMax = new Vector2(0.500000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(18.700001f, 76.500000f);
            rt.sizeDelta = new Vector2(315.000000f, 46.000000f);
        }
        {
            var rt = goMap[8791628711457671664L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-12.700000f, -0.100000f);
            rt.sizeDelta = new Vector2(230.000000f, 40.000000f);
        }
        {
            var rt = goMap[2742240321075408148L].AddComponent<RectTransform>();
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
            var rt = goMap[1345754868160353766L].AddComponent<RectTransform>();
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
            var rt = goMap[-3588654977203044116L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.000000f);
            rt.anchorMax = new Vector2(0.500000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(172.000000f, 73.599998f);
            rt.sizeDelta = new Vector2(48.000000f, 52.000000f);
        }
        {
            var rt = goMap[-2405690622590338207L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.500000f);
            rt.anchorMax = new Vector2(1.000000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 3.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }
        {
            var rt = goMap[-238685380400369890L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,-0.000000f,0.707107f,-0.707107f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-186.000000f, 55.275177f);
            rt.sizeDelta = new Vector2(604.521912f, 334.683685f);
        }
        {
            var rt = goMap[-5894637090637446858L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-220.099976f, 248.000000f);
            rt.sizeDelta = new Vector2(175.000000f, 101.000000f);
        }
        {
            var rt = goMap[1008643446575695081L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-114.099998f, 240.000000f);
            rt.sizeDelta = new Vector2(38.000000f, 85.000000f);
        }
        {
            var rt = goMap[-4172480587894130087L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-324.000000f, 322.299988f);
            rt.sizeDelta = new Vector2(82.000000f, 82.000000f);
        }
        {
            var rt = goMap[217333393460229540L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-1.000000f, 5.000000f);
            rt.sizeDelta = new Vector2(36.000000f, 36.000000f);
        }
        {
            var rt = goMap[4014137510617869995L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-1.000000f, 5.000000f);
            rt.sizeDelta = new Vector2(36.000000f, 36.000000f);
        }
        {
            var rt = goMap[-3108589251172947768L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-1.000000f, 5.000000f);
            rt.sizeDelta = new Vector2(36.000000f, 36.000000f);
        }
        {
            var rt = goMap[4538177999214186772L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-1.000000f, 5.000000f);
            rt.sizeDelta = new Vector2(36.000000f, 36.000000f);
        }
        {
            var rt = goMap[4207516675672706224L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-1.000000f, 5.000000f);
            rt.sizeDelta = new Vector2(36.000000f, 36.000000f);
        }
        {
            var rt = goMap[-4886363794103256737L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-184.000000f, 269.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var tr = goMap[-7838134828542674151L].transform;
            tr.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            tr.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            tr.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
        }
        {
            var rt = goMap[6913450795335797691L].AddComponent<RectTransform>();
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
            var rt = goMap[1114574383277648428L].AddComponent<RectTransform>();
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
            var rt = goMap[-7859743502503758854L].AddComponent<RectTransform>();
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
            var rt = goMap[-7772671734558205840L].AddComponent<RectTransform>();
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
            var rt = goMap[4906960004077644659L].AddComponent<RectTransform>();
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
            var tr = goMap[2662338375045730787L].transform;
            tr.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            tr.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            tr.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
        }
        {
            var rt = goMap[4303969278622449371L].AddComponent<RectTransform>();
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
            var rt = goMap[290016822104568891L].AddComponent<RectTransform>();
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
            var rt = goMap[-4251294226241157785L].AddComponent<RectTransform>();
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
            var rt = goMap[1180459555382424481L].AddComponent<RectTransform>();
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
            var rt = goMap[965800175516728121L].AddComponent<RectTransform>();
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
            var tr = goMap[-5036261640627051572L].transform;
            tr.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            tr.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            tr.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
        }
        {
            var rt = goMap[-8473877606902557450L].AddComponent<RectTransform>();
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
            var rt = goMap[-2962375905180152978L].AddComponent<RectTransform>();
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
            var rt = goMap[4598401087194501333L].AddComponent<RectTransform>();
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
            var rt = goMap[2707760979904832091L].AddComponent<RectTransform>();
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
            var rt = goMap[4753094666550475684L].AddComponent<RectTransform>();
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
            var tr = goMap[-9220266554761468308L].transform;
            tr.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            tr.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            tr.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
        }
        {
            var rt = goMap[-568218722910650998L].AddComponent<RectTransform>();
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
            var rt = goMap[-7148981038486249995L].AddComponent<RectTransform>();
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
            var rt = goMap[1725474597534898591L].AddComponent<RectTransform>();
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
            var rt = goMap[4674279812422491816L].AddComponent<RectTransform>();
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
            var rt = goMap[4101740786217008135L].AddComponent<RectTransform>();
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
            var tr = goMap[6038769253223626071L].transform;
            tr.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            tr.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            tr.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
        }
        {
            var rt = goMap[114921855123917447L].AddComponent<RectTransform>();
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
            var rt = goMap[5565108161967469151L].AddComponent<RectTransform>();
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
            var rt = goMap[5527901731769069917L].AddComponent<RectTransform>();
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
            var rt = goMap[-1872589554798487423L].AddComponent<RectTransform>();
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
            var rt = goMap[-4567827929578254067L].AddComponent<RectTransform>();
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
            var rt = goMap[-3725790120443405577L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-184.000000f, -32.700001f);
            rt.sizeDelta = new Vector2(264.064606f, 260.830109f);
        }
        {
            var rt = goMap[-9071483163238143281L].AddComponent<RectTransform>();
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
            var rt = goMap[7850525672503268368L].AddComponent<RectTransform>();
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
            var rt = goMap[557401503329319989L].AddComponent<RectTransform>();
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
            var rt = goMap[8773051742914492585L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-106.799950f, -49.900002f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }
        {
            var rt = goMap[7395742575067980146L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.800060f, -103.300003f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }
        {
            var rt = goMap[-7972357491050523135L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-105.099953f, 60.599960f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }
        {
            var rt = goMap[-231706938876365947L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(101.599976f, -53.600010f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }
        {
            var rt = goMap[3774099341825457830L].AddComponent<RectTransform>();
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
            var rt = goMap[8658098461315931975L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-184.811920f, 160.699997f);
            rt.sizeDelta = new Vector2(298.376099f, 101.529999f);
        }
        {
            var rt = goMap[-3993503144425037068L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-176.600006f, 65.200012f);
            rt.sizeDelta = new Vector2(236.000000f, 61.000000f);
        }
        {
            var rt = goMap[8725548046853645485L].AddComponent<RectTransform>();
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
            var rt = goMap[-1726799648922068095L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(1.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-254.899994f, 156.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }
        {
            var rt = goMap[-9196012875113975151L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(117.800003f, 0.000000f);
            rt.sizeDelta = new Vector2(72.000000f, 74.000000f);
        }
        {
            var rt = goMap[-6657872601965833236L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(22.400000f, -0.400000f);
            rt.sizeDelta = new Vector2(72.000000f, 74.000000f);
        }
        {
            var rt = goMap[3185465335275681127L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-558.799988f, 128.500000f);
            rt.sizeDelta = new Vector2(143.851196f, 394.576202f);
        }
        {
            var rt = goMap[-286028278976624947L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(49.799999f, 161.600006f);
            rt.sizeDelta = new Vector2(176.000000f, 50.000000f);
        }
        {
            var rt = goMap[-2838673083462345624L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(50.887001f, 161.609085f);
            rt.sizeDelta = new Vector2(97.974998f, 46.047001f);
        }
        {
            var rt = goMap[-8835777817934898060L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-37.000000f, 162.000000f);
            rt.sizeDelta = new Vector2(53.000000f, 53.000000f);
        }
        {
            var rt = goMap[-2023599638178868068L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.400000f, 0.400000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(62.000000f, 35.000000f);
        }
        {
            var rt = goMap[-4301653686471364667L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-37.000000f, 162.000000f);
            rt.sizeDelta = new Vector2(53.000000f, 53.000000f);
        }
        {
            var rt = goMap[-2309750405881040988L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,1.000000f,0.000000f);
            rt.localScale = new Vector3(0.400000f, 0.400000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(62.000000f, 35.000000f);
        }
        {
            var rt = goMap[-8405965851517658361L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.000000f);
            rt.anchorMax = new Vector2(0.500000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }
        {
            var rt = goMap[241350737396141613L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.000000f);
            rt.anchorMax = new Vector2(0.500000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(182.000000f, 400.000000f);
            rt.sizeDelta = new Vector2(300.000000f, 500.000000f);
        }
        {
            var rt = goMap[-1376381583251762219L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.000000f);
            rt.anchorMax = new Vector2(0.500000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-206.000000f, 400.000000f);
            rt.sizeDelta = new Vector2(300.000000f, 500.000000f);
        }
        {
            var rt = goMap[3474341260163918500L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-491.000000f, -9.100000f);
            rt.sizeDelta = new Vector2(263.979889f, 522.892273f);
        }
        {
            var rt = goMap[-2205009208734912041L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(28.310600f, -156.361557f);
            rt.sizeDelta = new Vector2(56.621201f, 312.723114f);
        }
        {
            var rt = goMap[-6515105284288533975L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(26.500000f, -26.500000f);
            rt.sizeDelta = new Vector2(53.000000f, 53.000000f);
        }
        {
            var rt = goMap[-5798208218235459882L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(53.000000f, 53.000000f);
        }
        {
            var rt = goMap[-1816257820259273313L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(53.000000f, 53.000000f);
        }
        {
            var rt = goMap[6367024589426156139L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.400000f, 1.900000f);
            rt.sizeDelta = new Vector2(52.000000f, 52.000000f);
        }
        {
            var rt = goMap[-6905832038270292756L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(26.500000f, -87.500000f);
            rt.sizeDelta = new Vector2(53.000000f, 53.000000f);
        }
        {
            var rt = goMap[7580840332442818525L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(53.000000f, 53.000000f);
        }
        {
            var rt = goMap[-6429501728678524461L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(53.000000f, 53.000000f);
        }
        {
            var rt = goMap[-357425684516940382L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.400000f, 1.900000f);
            rt.sizeDelta = new Vector2(52.000000f, 52.000000f);
        }
        {
            var rt = goMap[-43873865111887362L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(26.500000f, -148.500000f);
            rt.sizeDelta = new Vector2(53.000000f, 53.000000f);
        }
        {
            var rt = goMap[-9193240005511291718L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(53.000000f, 53.000000f);
        }
        {
            var rt = goMap[7103809506789838195L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(53.000000f, 53.000000f);
        }
        {
            var rt = goMap[-7159687639865966115L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.400000f, 1.900000f);
            rt.sizeDelta = new Vector2(52.000000f, 52.000000f);
        }
        {
            var rt = goMap[6085733076097110800L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(26.500000f, -209.500000f);
            rt.sizeDelta = new Vector2(53.000000f, 53.000000f);
        }
        {
            var rt = goMap[7732620158930536837L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(53.000000f, 53.000000f);
        }
        {
            var rt = goMap[-3680672302836669507L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(53.000000f, 53.000000f);
        }
        {
            var rt = goMap[-2313609112355251505L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.400000f, 1.900000f);
            rt.sizeDelta = new Vector2(52.000000f, 52.000000f);
        }
        {
            var rt = goMap[-8335787953482761326L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(26.500000f, -270.500000f);
            rt.sizeDelta = new Vector2(53.000000f, 53.000000f);
        }
        {
            var rt = goMap[-5197117477205302507L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(53.000000f, 53.000000f);
        }
        {
            var rt = goMap[-5591798237181283959L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(53.000000f, 53.000000f);
        }
        {
            var rt = goMap[-7401365494474935156L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.400000f, 1.900000f);
            rt.sizeDelta = new Vector2(52.000000f, 52.000000f);
        }
        {
            var rt = goMap[-6864146390819006932L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(176.802704f, 501.920593f);
        }
        {
            var rt = goMap[-8425866967006347552L].AddComponent<RectTransform>();
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
            var rt = goMap[2336028557759271801L].AddComponent<RectTransform>();
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
            var rt = goMap[2800998152632357630L].AddComponent<RectTransform>();
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
            var rt = goMap[-7181435786815480095L].AddComponent<RectTransform>();
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
            var tr = goMap[-4108142243437250371L].transform;
            tr.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            tr.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            tr.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
        }
        {
            var tr = goMap[-6262023056239275535L].transform;
            tr.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            tr.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            tr.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
        }
        {
            var tr = goMap[-4402897887020896732L].transform;
            tr.localPosition = new Vector3(-0.800000f, -0.300000f, 0.000000f);
            tr.localRotation = new Quaternion(-0.707107f,0.000000f,0.000000f,0.707107f);
            tr.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
        }
        {
            var tr = goMap[2766487223777188707L].transform;
            tr.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            tr.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            tr.localScale = new Vector3(100.000000f, 100.000000f, 1.000000f);
        }
        {
            var tr = goMap[-4440031378572487105L].transform;
            tr.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            tr.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            tr.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
        }

        // ─── Components ──────────────────────────────────────
        { var c = goMap[4271273089317044952L].AddComponent<CanvasScaler>();
           c.uiScaleMode = (CanvasScaler.ScaleMode)1;
           c.referenceResolution = new Vector2(1280.000000f, 720.000000f);
           c.matchWidthOrHeight = 0.000000f;
           c.referencePixelsPerUnit = 100.000000f;
        }
        { var c = goMap[4271273089317044952L].AddComponent<GraphicRaycaster>();
           c.ignoreReversedGraphics = true;
        }
        { var c = goMap[4271273089317044952L].AddComponent<UIView>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"m_luaClassName", "UICreateRole"}});
        }
        { var c = goMap[-5957422566960681333L].AddComponent<SafeAreaElement>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"layout", 0},{"offsetL", new Vector2(0.000000f,0.000000f)},{"offsetR", new Vector2(0.000000f,0.000000f)},{"offsetT", new Vector2(0.000000f,0.000000f)},{"offsetB", new Vector2(0.000000f,0.000000f)}});
        }
        { var c = goMap[-6798353631814109257L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.000000f, 0.000000f, 0.784314f);
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
           c.sprite = LookupSprite("img_line_hud");
        }
        { var c = goMap[990567454976288233L].AddComponent<Image>();
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
        { var c = goMap[990567454976288233L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[990567454976288233L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
        }
        { var c = goMap[5763557359389786042L].AddComponent<Text>();
           c.text = "返回";
           c.color = new Color(0.113725f, 0.309804f, 0.321569f, 1.000000f);
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
        { var c = goMap[5763557359389786042L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "返回"},{"mTermSecondary", "common_zh"}});
        }
        { var c = goMap[-410095182932259793L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_createrole_input");
        }
        { var c = goMap[8791628711457671664L].AddComponent<Image>();
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
        }
        { var c = goMap[8791628711457671664L].AddComponent<UIDealEmojiInput>();
           c.enabled = true;
        }
        { var c = goMap[2742240321075408148L].AddComponent<Text>();
           c.text = "输入角色昵称";
           c.color = new Color(0.462745f, 0.686275f, 0.627451f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Italic;
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
        { var c = goMap[2742240321075408148L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "输入角色昵称"},{"mTermSecondary", "common_zh"}});
        }
        { var c = goMap[1345754868160353766L].AddComponent<Text>();
           c.text = "";
           c.color = new Color(0.462745f, 0.686275f, 0.627451f, 1.000000f);
           c.fontSize = 18;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = false;
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
        { var c = goMap[1345754868160353766L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "dynamic_change_from_script"},{"mTermSecondary", "common_zh"}});
        }
        { var c = goMap[-3588654977203044116L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("btn_refresh");
        }
        { var c = goMap[-3588654977203044116L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-3588654977203044116L].AddComponent<UIAnimScaleDown>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"AnimTime", 0.100000f},{"DownToScale", 0.950000f}});
        }
        { var c = goMap[-2405690622590338207L].AddComponent<ToggleGroup>();
           c.enabled = true;
        }
        { var c = goMap[-238685380400369890L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.000000f, 0.000000f, 0.784314f);
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
        { var c = goMap[-5894637090637446858L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[1008643446575695081L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-4172480587894130087L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_seriesfaction_bg");
        }
        { var c = goMap[217333393460229540L].AddComponent<Text>();
           c.text = "金";
           c.color = new Color(0.196078f, 0.196078f, 0.196078f, 1.000000f);
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
        { var c = goMap[217333393460229540L].AddComponent<UIMultiGradient>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"gradientColor", new Gradient { colorKeys = new GradientColorKey[]{new GradientColorKey(new Color(0.992157f,0.980392f,0.933333f,1.000000f), 0.0000f),new GradientColorKey(new Color(0.976471f,0.929412f,0.635294f,1.000000f), 0.1429f),new GradientColorKey(new Color(0.988235f,0.760784f,0.333333f,0.000000f), 0.2857f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 0.4286f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 0.5714f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 0.7143f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 0.8571f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 1.0000f)} }},{"gradientDir", 0},{"isMultiplyTextColor", 0}});
        }
        { var c = goMap[217333393460229540L].AddComponent<Outline>();
           c.effectColor = new Color(0.286275f, 0.074510f, 0.054902f, 1.000000f);
           c.effectDistance = new Vector2(0.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[217333393460229540L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "金"},{"mTermSecondary", "common_zh"}});
        }
        { var c = goMap[4014137510617869995L].AddComponent<Text>();
           c.text = "木";
           c.color = new Color(0.196078f, 0.196078f, 0.196078f, 1.000000f);
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
        { var c = goMap[4014137510617869995L].AddComponent<UIMultiGradient>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"gradientColor", new Gradient { colorKeys = new GradientColorKey[]{new GradientColorKey(new Color(0.925490f,0.992157f,0.952941f,1.000000f), 0.0000f),new GradientColorKey(new Color(0.521569f,0.988235f,0.882353f,1.000000f), 0.1429f),new GradientColorKey(new Color(0.462745f,0.937255f,0.737255f,0.000000f), 0.2857f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 0.4286f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 0.5714f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 0.7143f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 0.8571f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 1.0000f)} }},{"gradientDir", 0},{"isMultiplyTextColor", 0}});
        }
        { var c = goMap[4014137510617869995L].AddComponent<Outline>();
           c.effectColor = new Color(0.286275f, 0.074510f, 0.054902f, 1.000000f);
           c.effectDistance = new Vector2(0.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[4014137510617869995L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "木"},{"mTermSecondary", "common_zh"}});
        }
        { var c = goMap[-3108589251172947768L].AddComponent<Text>();
           c.text = "水";
           c.color = new Color(0.196078f, 0.196078f, 0.196078f, 1.000000f);
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
        { var c = goMap[-3108589251172947768L].AddComponent<UIMultiGradient>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"gradientColor", new Gradient { colorKeys = new GradientColorKey[]{new GradientColorKey(new Color(0.917647f,0.984314f,0.964706f,1.000000f), 0.0000f),new GradientColorKey(new Color(0.443137f,0.929412f,0.988235f,1.000000f), 0.1429f),new GradientColorKey(new Color(0.294118f,0.698039f,0.921569f,0.000000f), 0.2857f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 0.4286f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 0.5714f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 0.7143f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 0.8571f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 1.0000f)} }},{"gradientDir", 0},{"isMultiplyTextColor", 0}});
        }
        { var c = goMap[-3108589251172947768L].AddComponent<Outline>();
           c.effectColor = new Color(0.286275f, 0.074510f, 0.054902f, 1.000000f);
           c.effectDistance = new Vector2(0.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-3108589251172947768L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "水"},{"mTermSecondary", "common_zh"}});
        }
        { var c = goMap[4538177999214186772L].AddComponent<Text>();
           c.text = "火";
           c.color = new Color(0.196078f, 0.196078f, 0.196078f, 1.000000f);
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
        { var c = goMap[4538177999214186772L].AddComponent<UIMultiGradient>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"gradientColor", new Gradient { colorKeys = new GradientColorKey[]{new GradientColorKey(new Color(0.984314f,0.968628f,0.956863f,1.000000f), 0.0000f),new GradientColorKey(new Color(0.988235f,0.580392f,0.372549f,1.000000f), 0.1429f),new GradientColorKey(new Color(0.866667f,0.184314f,0.125490f,0.000000f), 0.2857f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 0.4286f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 0.5714f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 0.7143f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 0.8571f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 1.0000f)} }},{"gradientDir", 0},{"isMultiplyTextColor", 0}});
        }
        { var c = goMap[4538177999214186772L].AddComponent<Outline>();
           c.effectColor = new Color(0.286275f, 0.074510f, 0.054902f, 1.000000f);
           c.effectDistance = new Vector2(0.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[4538177999214186772L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "火"},{"mTermSecondary", "common_zh"}});
        }
        { var c = goMap[4207516675672706224L].AddComponent<Text>();
           c.text = "土";
           c.color = new Color(0.196078f, 0.196078f, 0.196078f, 1.000000f);
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
        { var c = goMap[4207516675672706224L].AddComponent<UIMultiGradient>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"gradientColor", new Gradient { colorKeys = new GradientColorKey[]{new GradientColorKey(new Color(0.980392f,0.921569f,0.882353f,1.000000f), 0.0000f),new GradientColorKey(new Color(0.976471f,0.929412f,0.635294f,1.000000f), 0.1429f),new GradientColorKey(new Color(0.662745f,0.509804f,0.349020f,0.000000f), 0.2857f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 0.4286f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 0.5714f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 0.7143f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 0.8571f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 1.0000f)} }},{"gradientDir", 0},{"isMultiplyTextColor", 0}});
        }
        { var c = goMap[4207516675672706224L].AddComponent<Outline>();
           c.effectColor = new Color(0.286275f, 0.074510f, 0.054902f, 1.000000f);
           c.effectDistance = new Vector2(0.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[4207516675672706224L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "土"},{"mTermSecondary", "common_zh"}});
        }
        { var c = goMap[-7838134828542674151L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("Fire_Effect"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[6913450795335797691L].AddComponent<Image>();
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
           { var mat = LookupMaterial("BG_TianRen"); if (mat != null) c.material = mat; }
           if (c.sprite == null) c.sprite = LookupBuiltinUISprite();
        }
        { var c = goMap[1114574383277648428L].AddComponent<Text>();
           c.text = "天忍";
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
        { var c = goMap[1114574383277648428L].AddComponent<UIMultiGradient>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"gradientColor", new Gradient { colorKeys = new GradientColorKey[]{new GradientColorKey(new Color(1.000000f,0.961658f,0.890196f,1.000000f), 0.0000f),new GradientColorKey(new Color(1.000000f,0.671875f,0.363208f,1.000000f), 0.1429f),new GradientColorKey(new Color(0.866667f,0.557559f,0.305882f,0.000000f), 0.2857f),new GradientColorKey(new Color(0.925490f,0.630165f,0.258824f,0.000000f), 0.4286f),new GradientColorKey(new Color(1.000000f,0.914885f,0.863208f,0.000000f), 0.5714f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 0.7143f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 0.8571f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 1.0000f)} }},{"gradientDir", 0},{"isMultiplyTextColor", 0}});
        }
        { var c = goMap[1114574383277648428L].AddComponent<FontOutline>();
           c.enabled = true;
        }
        { var c = goMap[1114574383277648428L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "天忍"},{"mTermSecondary", "common_zh"}});
        }
        { var c = goMap[-7859743502503758854L].AddComponent<Image>();
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
           { var mat = LookupMaterial("RaoDong_TianRen"); if (mat != null) c.material = mat; }
           if (c.sprite == null) c.sprite = LookupBuiltinUISprite();
        }
        { var c = goMap[-7772671734558205840L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           { var mat = LookupMaterial("LiuGuang_TianRen"); if (mat != null) c.material = mat; }
           if (c.sprite == null) c.sprite = LookupBuiltinUISprite();
        }
        { var c = goMap[-7772671734558205840L].AddComponent<ImageEffectAnimationController>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"SingleMaterial", 0},{"BlendSet", 2},{"AlphaCutout", 0.000000f},{"TwoSide", 2},{"MainTexTiling", new Vector2(1.000000f,1.000000f)},{"MainTexOffset", new Vector2(0.080000f,0.000000f)},{"DiffuseRo", 0},{"DiffuseAng", 0.000000f},{"HDRColor", new Color(2.000000f,0.101961f,0.000000f,1.000000f)},{"Brightness", 1.000000f},{"Uspeed", 0.000000f},{"Vspeed", 0.000000f},{"StencilMode", 0},{"StencilID", 0.000000f},{"DiffuseMaskTexTiling", new Vector2(1.000000f,1.000000f)},{"DiffuseMaskTexOffset", new Vector2(0.010000f,0.000000f)},{"DiffuseMaskMaskTexTiling", new Vector2(1.000000f,1.000000f)},{"DiffuseMaskMaskTexOffset", new Vector2(0.000000f,0.000000f)},{"DiffuseMaskRo", 0},{"DiffuseMaskAng", 0.000000f},{"DiffuseMaskUspeed", 0.200000f},{"DiffuseMaskVspeed", 0.000000f},{"DissolveTexTiling", new Vector2(1.000000f,1.000000f)},{"DissolveTexOffset", new Vector2(0.000000f,0.000000f)},{"EdgeColor", new Color(1.000000f,1.000000f,1.000000f,1.000000f)},{"DissolveProgress", 1.000000f},{"EdgeWidth", 0.000000f},{"DissolveUspeed", 0.000000f},{"DissolveVspeed", 0.000000f},{"DistortTexTiling", new Vector2(1.000000f,1.000000f)},{"DistortTexOffset", new Vector2(0.000000f,0.000000f)},{"DistortForceX", 0.100000f},{"DistortForceY", 0.100000f},{"DistortUspeed", 0.000000f},{"DistortVspeed", 0.000000f},{"DistortMaskTexTiling", new Vector2(1.000000f,1.000000f)},{"DistortMaskTexOffset", new Vector2(0.000000f,0.000000f)}});
        }
        { var c = goMap[2662338375045730787L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("Metal_Effect"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[4303969278622449371L].AddComponent<Image>();
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
           { var mat = LookupMaterial("BG_WuDang"); if (mat != null) c.material = mat; }
           if (c.sprite == null) c.sprite = LookupBuiltinUISprite();
        }
        { var c = goMap[290016822104568891L].AddComponent<Text>();
           c.text = "少林";
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
        { var c = goMap[290016822104568891L].AddComponent<UIMultiGradient>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"gradientColor", new Gradient { colorKeys = new GradientColorKey[]{new GradientColorKey(new Color(1.000000f,0.991294f,0.891509f,1.000000f), 0.0000f),new GradientColorKey(new Color(1.000000f,0.915533f,0.221698f,1.000000f), 0.1429f),new GradientColorKey(new Color(1.000000f,0.701530f,0.382075f,0.000000f), 0.2857f),new GradientColorKey(new Color(0.820755f,0.341204f,0.050329f,0.000000f), 0.4286f),new GradientColorKey(new Color(1.000000f,0.779794f,0.646226f,0.000000f), 0.5714f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 0.7143f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 0.8571f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 1.0000f)} }},{"gradientDir", 0},{"isMultiplyTextColor", 0}});
        }
        { var c = goMap[290016822104568891L].AddComponent<FontOutline>();
           c.enabled = true;
        }
        { var c = goMap[290016822104568891L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "少林"},{"mTermSecondary", "common_zh"}});
        }
        { var c = goMap[-4251294226241157785L].AddComponent<Image>();
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
           { var mat = LookupMaterial("RaoDong_WuDang"); if (mat != null) c.material = mat; }
           if (c.sprite == null) c.sprite = LookupBuiltinUISprite();
        }
        { var c = goMap[1180459555382424481L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           { var mat = LookupMaterial("LiuGuang_ShaoLin"); if (mat != null) c.material = mat; }
           if (c.sprite == null) c.sprite = LookupBuiltinUISprite();
        }
        { var c = goMap[1180459555382424481L].AddComponent<ImageEffectAnimationController>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"SingleMaterial", 0},{"BlendSet", 2},{"AlphaCutout", 0.000000f},{"TwoSide", 2},{"MainTexTiling", new Vector2(1.000000f,1.000000f)},{"MainTexOffset", new Vector2(-0.295340f,0.000000f)},{"DiffuseRo", 0},{"DiffuseAng", 0.000000f},{"HDRColor", new Color(1.000000f,0.745440f,0.353774f,0.969534f)},{"Brightness", 1.000000f},{"Uspeed", 0.000000f},{"Vspeed", 0.000000f},{"StencilMode", 0},{"StencilID", 0.000000f},{"DiffuseMaskTexTiling", new Vector2(1.000000f,1.000000f)},{"DiffuseMaskTexOffset", new Vector2(0.010000f,0.000000f)},{"DiffuseMaskMaskTexTiling", new Vector2(1.000000f,1.000000f)},{"DiffuseMaskMaskTexOffset", new Vector2(0.000000f,0.000000f)},{"DiffuseMaskRo", 0},{"DiffuseMaskAng", 0.000000f},{"DiffuseMaskUspeed", 0.200000f},{"DiffuseMaskVspeed", 0.000000f},{"DissolveTexTiling", new Vector2(1.000000f,1.000000f)},{"DissolveTexOffset", new Vector2(0.000000f,0.000000f)},{"EdgeColor", new Color(1.000000f,1.000000f,1.000000f,1.000000f)},{"DissolveProgress", 1.000000f},{"EdgeWidth", 0.000000f},{"DissolveUspeed", 0.000000f},{"DissolveVspeed", 0.000000f},{"DistortTexTiling", new Vector2(1.000000f,1.000000f)},{"DistortTexOffset", new Vector2(0.000000f,0.000000f)},{"DistortForceX", 0.100000f},{"DistortForceY", 0.100000f},{"DistortUspeed", 0.000000f},{"DistortVspeed", 0.000000f},{"DistortMaskTexTiling", new Vector2(1.000000f,1.000000f)},{"DistortMaskTexOffset", new Vector2(0.000000f,0.000000f)}});
        }
        { var c = goMap[-5036261640627051572L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("Earth_Effect"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[-8473877606902557450L].AddComponent<Image>();
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
           { var mat = LookupMaterial("BG_WuDang"); if (mat != null) c.material = mat; }
           if (c.sprite == null) c.sprite = LookupBuiltinUISprite();
        }
        { var c = goMap[-2962375905180152978L].AddComponent<Text>();
           c.text = "武当";
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
        { var c = goMap[-2962375905180152978L].AddComponent<UIMultiGradient>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"gradientColor", new Gradient { colorKeys = new GradientColorKey[]{new GradientColorKey(new Color(1.000000f,0.961658f,0.890196f,1.000000f), 0.0000f),new GradientColorKey(new Color(0.962264f,0.739278f,0.503827f,1.000000f), 0.1429f),new GradientColorKey(new Color(0.547170f,0.435374f,0.307138f,0.000000f), 0.2857f),new GradientColorKey(new Color(0.405660f,0.303198f,0.158820f,0.000000f), 0.4286f),new GradientColorKey(new Color(0.641509f,0.479835f,0.384300f,0.000000f), 0.5714f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 0.7143f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 0.8571f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 1.0000f)} }},{"gradientDir", 0},{"isMultiplyTextColor", 0}});
        }
        { var c = goMap[-2962375905180152978L].AddComponent<FontOutline>();
           c.enabled = true;
        }
        { var c = goMap[-2962375905180152978L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "武当"},{"mTermSecondary", "common_zh"}});
        }
        { var c = goMap[4598401087194501333L].AddComponent<Image>();
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
           { var mat = LookupMaterial("RaoDong_WuDang"); if (mat != null) c.material = mat; }
           if (c.sprite == null) c.sprite = LookupBuiltinUISprite();
        }
        { var c = goMap[2707760979904832091L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           { var mat = LookupMaterial("LiuGuang_WuDang"); if (mat != null) c.material = mat; }
           if (c.sprite == null) c.sprite = LookupBuiltinUISprite();
        }
        { var c = goMap[2707760979904832091L].AddComponent<ImageEffectAnimationController>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"SingleMaterial", 0},{"BlendSet", 2},{"AlphaCutout", 0.000000f},{"TwoSide", 2},{"MainTexTiling", new Vector2(1.000000f,1.000000f)},{"MainTexOffset", new Vector2(-0.395824f,0.000000f)},{"DiffuseRo", 0},{"DiffuseAng", 0.000000f},{"HDRColor", new Color(1.000000f,0.745440f,0.353774f,1.000000f)},{"Brightness", 1.000000f},{"Uspeed", 0.000000f},{"Vspeed", 0.000000f},{"StencilMode", 0},{"StencilID", 0.000000f},{"DiffuseMaskTexTiling", new Vector2(1.000000f,1.000000f)},{"DiffuseMaskTexOffset", new Vector2(0.010000f,0.000000f)},{"DiffuseMaskMaskTexTiling", new Vector2(1.000000f,1.000000f)},{"DiffuseMaskMaskTexOffset", new Vector2(0.000000f,0.000000f)},{"DiffuseMaskRo", 0},{"DiffuseMaskAng", 0.000000f},{"DiffuseMaskUspeed", 0.200000f},{"DiffuseMaskVspeed", 0.000000f},{"DissolveTexTiling", new Vector2(1.000000f,1.000000f)},{"DissolveTexOffset", new Vector2(0.000000f,0.000000f)},{"EdgeColor", new Color(1.000000f,1.000000f,1.000000f,1.000000f)},{"DissolveProgress", 1.000000f},{"EdgeWidth", 0.000000f},{"DissolveUspeed", 0.000000f},{"DissolveVspeed", 0.000000f},{"DistortTexTiling", new Vector2(1.000000f,1.000000f)},{"DistortTexOffset", new Vector2(0.000000f,0.000000f)},{"DistortForceX", 0.100000f},{"DistortForceY", 0.100000f},{"DistortUspeed", 0.000000f},{"DistortVspeed", 0.000000f},{"DistortMaskTexTiling", new Vector2(1.000000f,1.000000f)},{"DistortMaskTexOffset", new Vector2(0.000000f,0.000000f)}});
        }
        { var c = goMap[-9220266554761468308L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("Water_Effect"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[-568218722910650998L].AddComponent<Image>();
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
           { var mat = LookupMaterial("BG_EMei"); if (mat != null) c.material = mat; }
           if (c.sprite == null) c.sprite = LookupBuiltinUISprite();
        }
        { var c = goMap[-7148981038486249995L].AddComponent<Text>();
           c.text = "峨眉";
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
        { var c = goMap[-7148981038486249995L].AddComponent<UIMultiGradient>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"gradientColor", new Gradient { colorKeys = new GradientColorKey[]{new GradientColorKey(new Color(0.890196f,0.994810f,1.000000f,1.000000f), 0.0000f),new GradientColorKey(new Color(0.223529f,0.928847f,1.000000f,1.000000f), 0.1429f),new GradientColorKey(new Color(0.380392f,0.734790f,1.000000f,0.000000f), 0.2857f),new GradientColorKey(new Color(0.457547f,0.808909f,1.000000f,0.000000f), 0.4286f),new GradientColorKey(new Color(0.740566f,0.956030f,1.000000f,0.000000f), 0.5714f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 0.7143f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 0.8571f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 1.0000f)} }},{"gradientDir", 0},{"isMultiplyTextColor", 0}});
        }
        { var c = goMap[-7148981038486249995L].AddComponent<FontOutline>();
           c.enabled = true;
        }
        { var c = goMap[-7148981038486249995L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "7785"},{"mTermSecondary", "common_zh"}});
        }
        { var c = goMap[1725474597534898591L].AddComponent<Image>();
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
           { var mat = LookupMaterial("RaoDong_EMei"); if (mat != null) c.material = mat; }
           if (c.sprite == null) c.sprite = LookupBuiltinUISprite();
        }
        { var c = goMap[4674279812422491816L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           { var mat = LookupMaterial("LiuGuang_EMei"); if (mat != null) c.material = mat; }
           if (c.sprite == null) c.sprite = LookupBuiltinUISprite();
        }
        { var c = goMap[4674279812422491816L].AddComponent<ImageEffectAnimationController>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"SingleMaterial", 0},{"BlendSet", 2},{"AlphaCutout", 0.000000f},{"TwoSide", 2},{"MainTexTiling", new Vector2(1.000000f,1.000000f)},{"MainTexOffset", new Vector2(0.538372f,0.000000f)},{"DiffuseRo", 0},{"DiffuseAng", 0.000000f},{"HDRColor", new Color(0.098039f,0.491084f,1.000000f,1.000000f)},{"Brightness", 1.000000f},{"Uspeed", 0.000000f},{"Vspeed", 0.000000f},{"StencilMode", 0},{"StencilID", 0.000000f},{"DiffuseMaskTexTiling", new Vector2(1.000000f,1.000000f)},{"DiffuseMaskTexOffset", new Vector2(0.010000f,0.000000f)},{"DiffuseMaskMaskTexTiling", new Vector2(1.000000f,1.000000f)},{"DiffuseMaskMaskTexOffset", new Vector2(0.000000f,0.000000f)},{"DiffuseMaskRo", 0},{"DiffuseMaskAng", 0.000000f},{"DiffuseMaskUspeed", 0.200000f},{"DiffuseMaskVspeed", 0.000000f},{"DissolveTexTiling", new Vector2(1.000000f,1.000000f)},{"DissolveTexOffset", new Vector2(0.000000f,0.000000f)},{"EdgeColor", new Color(1.000000f,1.000000f,1.000000f,1.000000f)},{"DissolveProgress", 1.000000f},{"EdgeWidth", 0.000000f},{"DissolveUspeed", 0.000000f},{"DissolveVspeed", 0.000000f},{"DistortTexTiling", new Vector2(1.000000f,1.000000f)},{"DistortTexOffset", new Vector2(0.000000f,0.000000f)},{"DistortForceX", 0.100000f},{"DistortForceY", 0.100000f},{"DistortUspeed", 0.000000f},{"DistortVspeed", 0.000000f},{"DistortMaskTexTiling", new Vector2(1.000000f,1.000000f)},{"DistortMaskTexOffset", new Vector2(0.000000f,0.000000f)}});
        }
        { var c = goMap[6038769253223626071L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("Wood_Effect"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[114921855123917447L].AddComponent<Image>();
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
           { var mat = LookupMaterial("BG_TangMen"); if (mat != null) c.material = mat; }
           if (c.sprite == null) c.sprite = LookupBuiltinUISprite();
        }
        { var c = goMap[5565108161967469151L].AddComponent<Text>();
           c.text = "唐门";
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
        { var c = goMap[5565108161967469151L].AddComponent<UIMultiGradient>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"gradientColor", new Gradient { colorKeys = new GradientColorKey[]{new GradientColorKey(new Color(0.890196f,0.994810f,1.000000f,1.000000f), 0.0000f),new GradientColorKey(new Color(0.223529f,1.000000f,0.838730f,1.000000f), 0.1429f),new GradientColorKey(new Color(0.316394f,0.849057f,0.616720f,0.000000f), 0.2857f),new GradientColorKey(new Color(0.246039f,0.915094f,0.623167f,0.000000f), 0.4286f),new GradientColorKey(new Color(0.740566f,0.956030f,1.000000f,0.000000f), 0.5714f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 0.7143f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 0.8571f),new GradientColorKey(new Color(0.000000f,0.000000f,0.000000f,0.000000f), 1.0000f)} }},{"gradientDir", 0},{"isMultiplyTextColor", 0}});
        }
        { var c = goMap[5565108161967469151L].AddComponent<FontOutline>();
           c.enabled = true;
        }
        { var c = goMap[5565108161967469151L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "唐门"},{"mTermSecondary", "common_zh"}});
        }
        { var c = goMap[5527901731769069917L].AddComponent<Image>();
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
           { var mat = LookupMaterial("RaoDong_TangMen"); if (mat != null) c.material = mat; }
           if (c.sprite == null) c.sprite = LookupBuiltinUISprite();
        }
        { var c = goMap[-1872589554798487423L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           { var mat = LookupMaterial("LiuGuang_TangMen"); if (mat != null) c.material = mat; }
           if (c.sprite == null) c.sprite = LookupBuiltinUISprite();
        }
        { var c = goMap[-1872589554798487423L].AddComponent<ImageEffectAnimationController>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"SingleMaterial", 0},{"BlendSet", 2},{"AlphaCutout", 0.000000f},{"TwoSide", 2},{"MainTexTiling", new Vector2(1.000000f,1.000000f)},{"MainTexOffset", new Vector2(0.540000f,0.000000f)},{"DiffuseRo", 0},{"DiffuseAng", 0.000000f},{"HDRColor", new Color(0.174128f,0.858491f,0.452075f,0.000000f)},{"Brightness", 1.000000f},{"Uspeed", 0.000000f},{"Vspeed", 0.000000f},{"StencilMode", 0},{"StencilID", 0.000000f},{"DiffuseMaskTexTiling", new Vector2(1.000000f,1.000000f)},{"DiffuseMaskTexOffset", new Vector2(0.010000f,0.000000f)},{"DiffuseMaskMaskTexTiling", new Vector2(1.000000f,1.000000f)},{"DiffuseMaskMaskTexOffset", new Vector2(0.000000f,0.000000f)},{"DiffuseMaskRo", 0},{"DiffuseMaskAng", 0.000000f},{"DiffuseMaskUspeed", 0.200000f},{"DiffuseMaskVspeed", 0.000000f},{"DissolveTexTiling", new Vector2(1.000000f,1.000000f)},{"DissolveTexOffset", new Vector2(0.000000f,0.000000f)},{"EdgeColor", new Color(1.000000f,1.000000f,1.000000f,1.000000f)},{"DissolveProgress", 1.000000f},{"EdgeWidth", 0.000000f},{"DissolveUspeed", 0.000000f},{"DissolveVspeed", 0.000000f},{"DistortTexTiling", new Vector2(1.000000f,1.000000f)},{"DistortTexOffset", new Vector2(0.000000f,0.000000f)},{"DistortForceX", 0.100000f},{"DistortForceY", 0.100000f},{"DistortUspeed", 0.000000f},{"DistortVspeed", 0.000000f},{"DistortMaskTexTiling", new Vector2(1.000000f,1.000000f)},{"DistortMaskTexOffset", new Vector2(0.000000f,0.000000f)}});
        }
        { var c = goMap[-9071483163238143281L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[7850525672503268368L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[557401503329319989L].AddComponent<Text>();
           c.text = "生存";
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
        { var c = goMap[557401503329319989L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)2;
           c.verticalFit = (ContentSizeFitter.FitMode)2;
        }
        { var c = goMap[557401503329319989L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "1695"},{"mTermSecondary", "common_zh"}});
        }
        { var c = goMap[8773051742914492585L].AddComponent<Text>();
           c.text = "群攻";
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
        { var c = goMap[8773051742914492585L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)2;
           c.verticalFit = (ContentSizeFitter.FitMode)2;
        }
        { var c = goMap[8773051742914492585L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "6458"},{"mTermSecondary", "common_zh"}});
        }
        { var c = goMap[7395742575067980146L].AddComponent<Text>();
           c.text = "机动";
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
        { var c = goMap[7395742575067980146L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)2;
           c.verticalFit = (ContentSizeFitter.FitMode)2;
        }
        { var c = goMap[7395742575067980146L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "2156"},{"mTermSecondary", "common_zh"}});
        }
        { var c = goMap[-7972357491050523135L].AddComponent<Text>();
           c.text = "操作";
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
        { var c = goMap[-7972357491050523135L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)2;
           c.verticalFit = (ContentSizeFitter.FitMode)2;
        }
        { var c = goMap[-7972357491050523135L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "操作"},{"mTermSecondary", "common_zh"}});
        }
        { var c = goMap[-231706938876365947L].AddComponent<Text>();
           c.text = "辅助";
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
        { var c = goMap[-231706938876365947L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)2;
           c.verticalFit = (ContentSizeFitter.FitMode)2;
        }
        { var c = goMap[-231706938876365947L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "10421"},{"mTermSecondary", "common_zh"}});
        }
        { var c = goMap[3774099341825457830L].AddComponent<Text>();
           c.text = "单攻";
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
        { var c = goMap[3774099341825457830L].AddComponent<ContentSizeFitter>();
           c.horizontalFit = (ContentSizeFitter.FitMode)2;
           c.verticalFit = (ContentSizeFitter.FitMode)2;
        }
        { var c = goMap[3774099341825457830L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "5160"},{"mTermSecondary", "common_zh"}});
        }
        { var c = goMap[8658098461315931975L].AddComponent<Text>();
           c.text = "门派介绍一段话，门派介绍一段话，门派介绍一段话，门派介绍一段话，门派介绍一段话。";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 16;
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
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[8658098461315931975L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "8537"},{"mTermSecondary", "common_zh"}});
        }
        { var c = goMap[-3993503144425037068L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-3993503144425037068L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-3993503144425037068L].AddComponent<UIAnimScaleUp>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"AnimTime", 0.100000f},{"UpToScale", 1.100000f}});
        }
        { var c = goMap[8725548046853645485L].AddComponent<Text>();
           c.text = "创建角色";
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
        { var c = goMap[8725548046853645485L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "创建角色"},{"mTermSecondary", "common_zh"}});
        }
        { var c = goMap[-1726799648922068095L].AddComponent<ToggleGroup>();
           c.enabled = true;
        }
        { var c = goMap[-9196012875113975151L].AddComponent<Toggle>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"toggleTransition", 1}});
        }
        { var c = goMap[-9196012875113975151L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("btn_gender_female_unselect");
        }
        { var c = goMap[-9196012875113975151L].AddComponent<ButtonGroupTransition>();
           c.enabled = true;
        }
        { var c = goMap[-6657872601965833236L].AddComponent<Toggle>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"toggleTransition", 1}});
        }
        { var c = goMap[-6657872601965833236L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("btn_gender_male_unselect");
        }
        { var c = goMap[-6657872601965833236L].AddComponent<ButtonGroupTransition>();
           c.enabled = true;
        }
        { var c = goMap[-286028278976624947L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_selectfaction_bg");
        }
        { var c = goMap[-2838673083462345624L].AddComponent<Text>();
           c.text = "全门派";
           c.color = new Color(1.000000f, 1.000000f, 0.800000f, 1.000000f);
           c.fontSize = 24;
           c.fontStyle = FontStyle.Normal;
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
        { var c = goMap[-2838673083462345624L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "全门派"},{"mTermSecondary", "common_zh"}});
        }
        { var c = goMap[-8835777817934898060L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("btn_selectfaction");
        }
        { var c = goMap[-8835777817934898060L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-2023599638178868068L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_arrow");
        }
        { var c = goMap[-4301653686471364667L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("btn_selectfaction");
        }
        { var c = goMap[-4301653686471364667L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-2309750405881040988L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_arrow");
        }
        { var c = goMap[241350737396141613L].AddComponent<Empty4Raycast>();
           c.enabled = true;
        }
        { var c = goMap[241350737396141613L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-1376381583251762219L].AddComponent<Empty4Raycast>();
           c.enabled = true;
        }
        { var c = goMap[-1376381583251762219L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[3474341260163918500L].AddComponent<HorizontalLayoutGroup>();
           c.spacing = 0.000000f;
        }
        { var c = goMap[-2205009208734912041L].AddComponent<GridLayoutGroup>();
           c.cellSize = new Vector2(53.000000f, 53.000000f);
           c.spacing = new Vector2(8.000000f, 8.000000f);
        }
        { var c = goMap[-2205009208734912041L].AddComponent<ToggleGroup>();
           c.enabled = true;
        }
        { var c = goMap[-6515105284288533975L].AddComponent<Toggle>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"toggleTransition", 1}});
        }
        { var c = goMap[-5798208218235459882L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("btn_series_metal");
        }
        { var c = goMap[-1816257820259273313L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_faction_select");
        }
        { var c = goMap[6367024589426156139L].AddComponent<Text>();
           c.text = "金";
           c.color = new Color(1.000000f, 1.000000f, 0.800000f, 1.000000f);
           c.fontSize = 24;
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
        { var c = goMap[6367024589426156139L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "金"},{"mTermSecondary", "common_zh"}});
        }
        { var c = goMap[-6905832038270292756L].AddComponent<Toggle>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"toggleTransition", 1}});
        }
        { var c = goMap[7580840332442818525L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("btn_series_wood");
        }
        { var c = goMap[-6429501728678524461L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_faction_select");
        }
        { var c = goMap[-357425684516940382L].AddComponent<Text>();
           c.text = "木";
           c.color = new Color(1.000000f, 1.000000f, 0.800000f, 1.000000f);
           c.fontSize = 24;
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
        { var c = goMap[-357425684516940382L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "木"},{"mTermSecondary", "common_zh"}});
        }
        { var c = goMap[-43873865111887362L].AddComponent<Toggle>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"toggleTransition", 1}});
        }
        { var c = goMap[-9193240005511291718L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("btn_series_water");
        }
        { var c = goMap[7103809506789838195L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_faction_select");
        }
        { var c = goMap[-7159687639865966115L].AddComponent<Text>();
           c.text = "水";
           c.color = new Color(1.000000f, 1.000000f, 0.800000f, 1.000000f);
           c.fontSize = 24;
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
        { var c = goMap[-7159687639865966115L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "水"},{"mTermSecondary", "common_zh"}});
        }
        { var c = goMap[6085733076097110800L].AddComponent<Toggle>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"toggleTransition", 1}});
        }
        { var c = goMap[7732620158930536837L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("btn_series_fire");
        }
        { var c = goMap[-3680672302836669507L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_faction_select");
        }
        { var c = goMap[-2313609112355251505L].AddComponent<Text>();
           c.text = "火";
           c.color = new Color(1.000000f, 1.000000f, 0.800000f, 1.000000f);
           c.fontSize = 24;
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
        { var c = goMap[-2313609112355251505L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "火"},{"mTermSecondary", "common_zh"}});
        }
        { var c = goMap[-8335787953482761326L].AddComponent<Toggle>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"toggleTransition", 1}});
        }
        { var c = goMap[-5197117477205302507L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("btn_series_earth");
        }
        { var c = goMap[-5591798237181283959L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_faction_select");
        }
        { var c = goMap[-7401365494474935156L].AddComponent<Text>();
           c.text = "土";
           c.color = new Color(1.000000f, 1.000000f, 0.800000f, 1.000000f);
           c.fontSize = 24;
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
        { var c = goMap[-7401365494474935156L].AddComponent<I2.Loc.Localize>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"mTerm", "土"},{"mTermSecondary", "common_zh"}});
        }
        { var c = goMap[-6864146390819006932L].AddComponent<GridLayoutGroup>();
           c.cellSize = new Vector2(72.000000f, 72.000000f);
           c.spacing = new Vector2(30.000000f, 20.000000f);
        }
        { var c = goMap[-8425866967006347552L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-8425866967006347552L].AddComponent<ButtonGroupTransition>();
           c.enabled = true;
        }
        { var c = goMap[2336028557759271801L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[2800998152632357630L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-7181435786815480095L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
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
        { var c = goMap[2766487223777188707L].AddComponent<AutoRotation>();
           c.enabled = true;
           ApplyFields(c, new Dictionary<string, object>{{"EulerAngleSpeed", new Vector3(0.000000f,0.000000f,-180.000000f)},{"running", 1}});
        }

        // ─── Save prefab ─────────────────────────────────────
        Directory.CreateDirectory("Assets/Prefabs/Imported");
        var rootGO = goMap[4271273089317044952L];
        string path = "Assets/Prefabs/Imported/UICreateRole.prefab";
        PrefabUtility.SaveAsPrefabAsset(rootGO, path);
        Object.DestroyImmediate(rootGO);
        Debug.Log("[Import_res_p_55] Saved " + path);
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

    static Sprite _builtinUISprite;
    static Sprite LookupBuiltinUISprite()
    {
        if (_builtinUISprite == null)
            _builtinUISprite = AssetDatabase.GetBuiltinExtraResource<Sprite>("UI/Skin/UISprite.psd");
        if (_builtinUISprite == null)
            _builtinUISprite = Resources.GetBuiltinResource<Sprite>("UI/Skin/UISprite.psd");
        return _builtinUISprite;
    }

    static Dictionary<string, Material> _matCache;
    static Material LookupMaterial(string name)
    {
        if (_matCache == null)
        {
            _matCache = new Dictionary<string, Material>();
            var guids = AssetDatabase.FindAssets("t:Material", new[] { "Assets/game", "Assets/Sprite", "Assets/Material" });
            foreach (var g in guids)
            {
                var p = AssetDatabase.GUIDToAssetPath(g);
                var m = AssetDatabase.LoadAssetAtPath<Material>(p);
                if (m == null) continue;
                if (!_matCache.ContainsKey(m.name)) _matCache[m.name] = m;
            }
            Debug.Log($"[Material cache] {_matCache.Count} materials");
        }
        Material r;
        return _matCache.TryGetValue(name, out r) ? r : null;
    }

    static void ApplyFields(Component comp, Dictionary<string, object> fields)
    {
        if (comp == null || fields == null) return;
        var t = comp.GetType();
        var flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.FlattenHierarchy;
        foreach (var kv in fields)
        {
            var f = t.GetField(kv.Key, flags);
            if (f == null) continue;
            try {
                object val = kv.Value;
                if (val == null) continue;
                // Coerce common numeric types
                if (f.FieldType == typeof(float) && val is int iv) val = (float)iv;
                else if (f.FieldType == typeof(int) && val is float fv) val = (int)fv;
                else if (f.FieldType == typeof(bool) && val is int ibv) val = ibv != 0;
                else if (f.FieldType == typeof(byte) && val is int byv) val = (byte)byv;
                f.SetValue(comp, val);
            } catch (System.Exception e) {
                Debug.LogWarning($"[ApplyFields] {t.Name}.{kv.Key}: {e.Message}");
            }
        }
    }

    static Dictionary<string, RuntimeAnimatorController> _ctrlCache;
    static RuntimeAnimatorController LookupAnimatorController(string name)
    {
        if (_ctrlCache == null)
        {
            _ctrlCache = new Dictionary<string, RuntimeAnimatorController>();
            var guids = AssetDatabase.FindAssets("t:AnimatorController", new[] { "Assets/game" });
            foreach (var g in guids)
            {
                var p = AssetDatabase.GUIDToAssetPath(g);
                var c = AssetDatabase.LoadAssetAtPath<RuntimeAnimatorController>(p);
                if (c == null) continue;
                if (!_ctrlCache.ContainsKey(c.name)) _ctrlCache[c.name] = c;
            }
            Debug.Log($"[AnimatorController cache] {_ctrlCache.Count} controllers");
        }
        RuntimeAnimatorController r;
        return _ctrlCache.TryGetValue(name, out r) ? r : null;
    }
}