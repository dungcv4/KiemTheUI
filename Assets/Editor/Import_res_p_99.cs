// AUTO-GENERATED from res_p_99.ab — DO NOT EDIT MANUALLY.
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;
using System.Collections.Generic;
using KTO.Game;  // UIJoyStick and other ported KTO scripts

public class Import_res_p_99
{
    [MenuItem("KTO/Import/res_p_99")]
    public static void Build()
    {
        Debug.Log("[Import_res_p_99] Building UIHudLeftPanelTeam...");

        // ─── Create all GameObjects ───────────────────────────
        var goMap = new Dictionary<long, GameObject>();
        var _toggleGroupByMbPid = new Dictionary<long, ToggleGroup>();
        var _toggleGroupLinks = new List<System.Tuple<Toggle,long>>();
        { var go = new GameObject("UIHudLeftPanelTeam"); go.SetActive(true); goMap[-2513686513170334702L] = go; }
        { var go = new GameObject("PanelTeamMember"); go.SetActive(true); goMap[-3509723304621144196L] = go; }
        { var go = new GameObject("Member1"); go.SetActive(true); goMap[-5495362718481652909L] = go; }
        { var go = new GameObject("PortraitObj"); go.SetActive(true); goMap[-1507406936179867867L] = go; }
        { var go = new GameObject("PortraitBg"); go.SetActive(true); goMap[5482312748868989237L] = go; }
        { var go = new GameObject("Portrait"); go.SetActive(true); goMap[-1043601435006104507L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[-8826867592513018698L] = go; }
        { var go = new GameObject("OutlineObj"); go.SetActive(false); goMap[2740374963613404162L] = go; }
        { var go = new GameObject("imgOutlineBG"); go.SetActive(true); goMap[-7585794548253453685L] = go; }
        { var go = new GameObject("txtOutline"); go.SetActive(true); goMap[7689728547276908803L] = go; }
        { var go = new GameObject("PortraitFrame"); go.SetActive(false); goMap[223800268521639463L] = go; }
        { var go = new GameObject("Level"); go.SetActive(true); goMap[5364413952296121062L] = go; }
        { var go = new GameObject("imgLvBg"); go.SetActive(true); goMap[2572429339505542802L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[7201580684390628087L] = go; }
        { var go = new GameObject("TextMaster"); go.SetActive(false); goMap[4868330342652639958L] = go; }
        { var go = new GameObject("imgFactionIcon"); go.SetActive(true); goMap[-7089629258753431221L] = go; }
        { var go = new GameObject("txtFollow"); go.SetActive(true); goMap[3415586759589982094L] = go; }
        { var go = new GameObject("Info"); go.SetActive(true); goMap[-1104978712402916575L] = go; }
        { var go = new GameObject("txtRoleName"); go.SetActive(true); goMap[1426734519584061150L] = go; }
        { var go = new GameObject("hpBg"); go.SetActive(true); goMap[2710565287139559808L] = go; }
        { var go = new GameObject("hp"); go.SetActive(true); goMap[6602268193820881126L] = go; }
        { var go = new GameObject("imgLeader"); go.SetActive(true); goMap[7505876845407084972L] = go; }
        { var go = new GameObject("imgSelected"); go.SetActive(false); goMap[4175268949578043524L] = go; }
        { var go = new GameObject("imgPopupPos"); go.SetActive(true); goMap[1988598330138276518L] = go; }
        { var go = new GameObject("imgPractice"); go.SetActive(false); goMap[6032909320526371335L] = go; }
        { var go = new GameObject("Member2"); go.SetActive(true); goMap[3167684777292570302L] = go; }
        { var go = new GameObject("PortraitObj"); go.SetActive(true); goMap[-7884584508217518047L] = go; }
        { var go = new GameObject("PortraitBg"); go.SetActive(true); goMap[8315422536885579039L] = go; }
        { var go = new GameObject("Portrait"); go.SetActive(true); goMap[5697723376517842608L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[-3096378097726204018L] = go; }
        { var go = new GameObject("OutlineObj"); go.SetActive(false); goMap[5241438503448733028L] = go; }
        { var go = new GameObject("imgOutlineBG"); go.SetActive(true); goMap[-1811044059168001002L] = go; }
        { var go = new GameObject("txtOutline"); go.SetActive(true); goMap[-8352919503681824565L] = go; }
        { var go = new GameObject("PortraitFrame"); go.SetActive(false); goMap[242546135546512874L] = go; }
        { var go = new GameObject("Level"); go.SetActive(true); goMap[6755246648232389968L] = go; }
        { var go = new GameObject("imgLvBg"); go.SetActive(true); goMap[8681766664674948702L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[6259489509613031086L] = go; }
        { var go = new GameObject("TextMaster"); go.SetActive(false); goMap[3391072058736191404L] = go; }
        { var go = new GameObject("imgFactionIcon"); go.SetActive(true); goMap[251774536289787443L] = go; }
        { var go = new GameObject("txtFollow"); go.SetActive(true); goMap[474248166302101352L] = go; }
        { var go = new GameObject("Info"); go.SetActive(true); goMap[-1534808200604532765L] = go; }
        { var go = new GameObject("txtRoleName"); go.SetActive(true); goMap[7389737801860773489L] = go; }
        { var go = new GameObject("hpBg"); go.SetActive(true); goMap[337134773040413100L] = go; }
        { var go = new GameObject("hp"); go.SetActive(true); goMap[7192974219545790476L] = go; }
        { var go = new GameObject("imgLeader"); go.SetActive(true); goMap[-5051807356121029041L] = go; }
        { var go = new GameObject("imgSelected"); go.SetActive(false); goMap[-915931463864161786L] = go; }
        { var go = new GameObject("imgPopupPos"); go.SetActive(true); goMap[1289881893737635087L] = go; }
        { var go = new GameObject("imgPractice"); go.SetActive(false); goMap[-6427897379509932417L] = go; }
        { var go = new GameObject("Member3"); go.SetActive(true); goMap[-2948690502920014827L] = go; }
        { var go = new GameObject("PortraitObj"); go.SetActive(true); goMap[-7704011285764435472L] = go; }
        { var go = new GameObject("PortraitBg"); go.SetActive(true); goMap[1624582069023026126L] = go; }
        { var go = new GameObject("Portrait"); go.SetActive(true); goMap[8901730471514957605L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[-542929927082669350L] = go; }
        { var go = new GameObject("OutlineObj"); go.SetActive(false); goMap[-1676759048721487167L] = go; }
        { var go = new GameObject("imgOutlineBG"); go.SetActive(true); goMap[3790017652448762517L] = go; }
        { var go = new GameObject("txtOutline"); go.SetActive(true); goMap[-1343092823770004931L] = go; }
        { var go = new GameObject("PortraitFrame"); go.SetActive(false); goMap[8560871464969735350L] = go; }
        { var go = new GameObject("Level"); go.SetActive(true); goMap[-7675390605812291302L] = go; }
        { var go = new GameObject("imgLvBg"); go.SetActive(true); goMap[7297211244281670636L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-9042861962797136038L] = go; }
        { var go = new GameObject("TextMaster"); go.SetActive(false); goMap[1755758450075381044L] = go; }
        { var go = new GameObject("imgFactionIcon"); go.SetActive(true); goMap[5192311639185197600L] = go; }
        { var go = new GameObject("txtFollow"); go.SetActive(true); goMap[-2967799343916164115L] = go; }
        { var go = new GameObject("Info"); go.SetActive(true); goMap[-3211731217540366985L] = go; }
        { var go = new GameObject("txtRoleName"); go.SetActive(true); goMap[-8723154074159433792L] = go; }
        { var go = new GameObject("hpBg"); go.SetActive(true); goMap[-8525467854463032066L] = go; }
        { var go = new GameObject("hp"); go.SetActive(true); goMap[7501921787203000563L] = go; }
        { var go = new GameObject("imgLeader"); go.SetActive(true); goMap[2526246940117544090L] = go; }
        { var go = new GameObject("imgSelected"); go.SetActive(false); goMap[3880216853130031095L] = go; }
        { var go = new GameObject("imgPopupPos"); go.SetActive(true); goMap[6498576659694871767L] = go; }
        { var go = new GameObject("imgPractice"); go.SetActive(false); goMap[-1194561796028643369L] = go; }
        { var go = new GameObject("Member4"); go.SetActive(true); goMap[-507707150166112072L] = go; }
        { var go = new GameObject("PortraitObj"); go.SetActive(true); goMap[4961308027296819806L] = go; }
        { var go = new GameObject("PortraitBg"); go.SetActive(true); goMap[-8392832162013966860L] = go; }
        { var go = new GameObject("Portrait"); go.SetActive(true); goMap[-2088122411448739851L] = go; }
        { var go = new GameObject("Image"); go.SetActive(true); goMap[-7154518197798899254L] = go; }
        { var go = new GameObject("OutlineObj"); go.SetActive(false); goMap[5566312368103575880L] = go; }
        { var go = new GameObject("imgOutlineBG"); go.SetActive(true); goMap[-1328630597961727950L] = go; }
        { var go = new GameObject("txtOutline"); go.SetActive(true); goMap[-2290013825646560160L] = go; }
        { var go = new GameObject("PortraitFrame"); go.SetActive(false); goMap[2172256319329340494L] = go; }
        { var go = new GameObject("Level"); go.SetActive(true); goMap[-281380797649332533L] = go; }
        { var go = new GameObject("imgLvBg"); go.SetActive(true); goMap[7065350729515874232L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[2334977958462141438L] = go; }
        { var go = new GameObject("TextMaster"); go.SetActive(false); goMap[-9210423873083563645L] = go; }
        { var go = new GameObject("imgFactionIcon"); go.SetActive(true); goMap[2347479578333914796L] = go; }
        { var go = new GameObject("txtFollow"); go.SetActive(true); goMap[258500554665313891L] = go; }
        { var go = new GameObject("Info"); go.SetActive(true); goMap[-2642637056129874550L] = go; }
        { var go = new GameObject("txtRoleName"); go.SetActive(true); goMap[2674258591880659044L] = go; }
        { var go = new GameObject("hpBg"); go.SetActive(true); goMap[-2725310986168751530L] = go; }
        { var go = new GameObject("hp"); go.SetActive(true); goMap[-244795751834911196L] = go; }
        { var go = new GameObject("imgLeader"); go.SetActive(true); goMap[8087883388110124209L] = go; }
        { var go = new GameObject("imgSelected"); go.SetActive(false); goMap[703884347161453269L] = go; }
        { var go = new GameObject("imgPopupPos"); go.SetActive(true); goMap[2856201194609224635L] = go; }
        { var go = new GameObject("imgPractice"); go.SetActive(false); goMap[-1931275450661547443L] = go; }
        { var go = new GameObject("btnInvite"); go.SetActive(true); goMap[3935995226531007030L] = go; }
        { var go = new GameObject("txtInvite"); go.SetActive(true); goMap[3017483831044405786L] = go; }
        { var go = new GameObject("imgbtn"); go.SetActive(true); goMap[7774152301619890235L] = go; }
        { var go = new GameObject("PanelCreateTeam"); go.SetActive(true); goMap[6510091471446130209L] = go; }
        { var go = new GameObject("btnCreateTeam"); go.SetActive(true); goMap[-1141440682808168872L] = go; }
        { var go = new GameObject("Image"); go.SetActive(false); goMap[6584843944286227462L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[-1727804349827926575L] = go; }
        { var go = new GameObject("btnSearchTeam"); go.SetActive(true); goMap[4024499023208902900L] = go; }
        { var go = new GameObject("Image"); go.SetActive(false); goMap[-7996621463030408123L] = go; }
        { var go = new GameObject("Text"); go.SetActive(true); goMap[4431482020704316248L] = go; }
        { var go = new GameObject("txtMatching"); go.SetActive(true); goMap[3626250087862538551L] = go; }

        // ─── Parent links ─────────────────────────────────────
        goMap[-3509723304621144196L].transform.SetParent(goMap[-2513686513170334702L].transform, false);
        goMap[-5495362718481652909L].transform.SetParent(goMap[-3509723304621144196L].transform, false);
        goMap[-1507406936179867867L].transform.SetParent(goMap[-5495362718481652909L].transform, false);
        goMap[5482312748868989237L].transform.SetParent(goMap[-1507406936179867867L].transform, false);
        goMap[-1043601435006104507L].transform.SetParent(goMap[-1507406936179867867L].transform, false);
        goMap[-8826867592513018698L].transform.SetParent(goMap[-1043601435006104507L].transform, false);
        goMap[2740374963613404162L].transform.SetParent(goMap[-8826867592513018698L].transform, false);
        goMap[-7585794548253453685L].transform.SetParent(goMap[2740374963613404162L].transform, false);
        goMap[7689728547276908803L].transform.SetParent(goMap[2740374963613404162L].transform, false);
        goMap[223800268521639463L].transform.SetParent(goMap[-1507406936179867867L].transform, false);
        goMap[5364413952296121062L].transform.SetParent(goMap[-1507406936179867867L].transform, false);
        goMap[2572429339505542802L].transform.SetParent(goMap[5364413952296121062L].transform, false);
        goMap[7201580684390628087L].transform.SetParent(goMap[5364413952296121062L].transform, false);
        goMap[4868330342652639958L].transform.SetParent(goMap[5364413952296121062L].transform, false);
        goMap[-7089629258753431221L].transform.SetParent(goMap[-1507406936179867867L].transform, false);
        goMap[3415586759589982094L].transform.SetParent(goMap[-5495362718481652909L].transform, false);
        goMap[-1104978712402916575L].transform.SetParent(goMap[-5495362718481652909L].transform, false);
        goMap[1426734519584061150L].transform.SetParent(goMap[-1104978712402916575L].transform, false);
        goMap[2710565287139559808L].transform.SetParent(goMap[-1104978712402916575L].transform, false);
        goMap[6602268193820881126L].transform.SetParent(goMap[2710565287139559808L].transform, false);
        goMap[7505876845407084972L].transform.SetParent(goMap[-5495362718481652909L].transform, false);
        goMap[4175268949578043524L].transform.SetParent(goMap[-5495362718481652909L].transform, false);
        goMap[1988598330138276518L].transform.SetParent(goMap[-5495362718481652909L].transform, false);
        goMap[6032909320526371335L].transform.SetParent(goMap[-5495362718481652909L].transform, false);
        goMap[3167684777292570302L].transform.SetParent(goMap[-3509723304621144196L].transform, false);
        goMap[-7884584508217518047L].transform.SetParent(goMap[3167684777292570302L].transform, false);
        goMap[8315422536885579039L].transform.SetParent(goMap[-7884584508217518047L].transform, false);
        goMap[5697723376517842608L].transform.SetParent(goMap[-7884584508217518047L].transform, false);
        goMap[-3096378097726204018L].transform.SetParent(goMap[5697723376517842608L].transform, false);
        goMap[5241438503448733028L].transform.SetParent(goMap[-3096378097726204018L].transform, false);
        goMap[-1811044059168001002L].transform.SetParent(goMap[5241438503448733028L].transform, false);
        goMap[-8352919503681824565L].transform.SetParent(goMap[5241438503448733028L].transform, false);
        goMap[242546135546512874L].transform.SetParent(goMap[-7884584508217518047L].transform, false);
        goMap[6755246648232389968L].transform.SetParent(goMap[-7884584508217518047L].transform, false);
        goMap[8681766664674948702L].transform.SetParent(goMap[6755246648232389968L].transform, false);
        goMap[6259489509613031086L].transform.SetParent(goMap[6755246648232389968L].transform, false);
        goMap[3391072058736191404L].transform.SetParent(goMap[6755246648232389968L].transform, false);
        goMap[251774536289787443L].transform.SetParent(goMap[-7884584508217518047L].transform, false);
        goMap[474248166302101352L].transform.SetParent(goMap[3167684777292570302L].transform, false);
        goMap[-1534808200604532765L].transform.SetParent(goMap[3167684777292570302L].transform, false);
        goMap[7389737801860773489L].transform.SetParent(goMap[-1534808200604532765L].transform, false);
        goMap[337134773040413100L].transform.SetParent(goMap[-1534808200604532765L].transform, false);
        goMap[7192974219545790476L].transform.SetParent(goMap[337134773040413100L].transform, false);
        goMap[-5051807356121029041L].transform.SetParent(goMap[3167684777292570302L].transform, false);
        goMap[-915931463864161786L].transform.SetParent(goMap[3167684777292570302L].transform, false);
        goMap[1289881893737635087L].transform.SetParent(goMap[3167684777292570302L].transform, false);
        goMap[-6427897379509932417L].transform.SetParent(goMap[3167684777292570302L].transform, false);
        goMap[-2948690502920014827L].transform.SetParent(goMap[-3509723304621144196L].transform, false);
        goMap[-7704011285764435472L].transform.SetParent(goMap[-2948690502920014827L].transform, false);
        goMap[1624582069023026126L].transform.SetParent(goMap[-7704011285764435472L].transform, false);
        goMap[8901730471514957605L].transform.SetParent(goMap[-7704011285764435472L].transform, false);
        goMap[-542929927082669350L].transform.SetParent(goMap[8901730471514957605L].transform, false);
        goMap[-1676759048721487167L].transform.SetParent(goMap[-542929927082669350L].transform, false);
        goMap[3790017652448762517L].transform.SetParent(goMap[-1676759048721487167L].transform, false);
        goMap[-1343092823770004931L].transform.SetParent(goMap[-1676759048721487167L].transform, false);
        goMap[8560871464969735350L].transform.SetParent(goMap[-7704011285764435472L].transform, false);
        goMap[-7675390605812291302L].transform.SetParent(goMap[-7704011285764435472L].transform, false);
        goMap[7297211244281670636L].transform.SetParent(goMap[-7675390605812291302L].transform, false);
        goMap[-9042861962797136038L].transform.SetParent(goMap[-7675390605812291302L].transform, false);
        goMap[1755758450075381044L].transform.SetParent(goMap[-7675390605812291302L].transform, false);
        goMap[5192311639185197600L].transform.SetParent(goMap[-7704011285764435472L].transform, false);
        goMap[-2967799343916164115L].transform.SetParent(goMap[-2948690502920014827L].transform, false);
        goMap[-3211731217540366985L].transform.SetParent(goMap[-2948690502920014827L].transform, false);
        goMap[-8723154074159433792L].transform.SetParent(goMap[-3211731217540366985L].transform, false);
        goMap[-8525467854463032066L].transform.SetParent(goMap[-3211731217540366985L].transform, false);
        goMap[7501921787203000563L].transform.SetParent(goMap[-8525467854463032066L].transform, false);
        goMap[2526246940117544090L].transform.SetParent(goMap[-2948690502920014827L].transform, false);
        goMap[3880216853130031095L].transform.SetParent(goMap[-2948690502920014827L].transform, false);
        goMap[6498576659694871767L].transform.SetParent(goMap[-2948690502920014827L].transform, false);
        goMap[-1194561796028643369L].transform.SetParent(goMap[-2948690502920014827L].transform, false);
        goMap[-507707150166112072L].transform.SetParent(goMap[-3509723304621144196L].transform, false);
        goMap[4961308027296819806L].transform.SetParent(goMap[-507707150166112072L].transform, false);
        goMap[-8392832162013966860L].transform.SetParent(goMap[4961308027296819806L].transform, false);
        goMap[-2088122411448739851L].transform.SetParent(goMap[4961308027296819806L].transform, false);
        goMap[-7154518197798899254L].transform.SetParent(goMap[-2088122411448739851L].transform, false);
        goMap[5566312368103575880L].transform.SetParent(goMap[-7154518197798899254L].transform, false);
        goMap[-1328630597961727950L].transform.SetParent(goMap[5566312368103575880L].transform, false);
        goMap[-2290013825646560160L].transform.SetParent(goMap[5566312368103575880L].transform, false);
        goMap[2172256319329340494L].transform.SetParent(goMap[4961308027296819806L].transform, false);
        goMap[-281380797649332533L].transform.SetParent(goMap[4961308027296819806L].transform, false);
        goMap[7065350729515874232L].transform.SetParent(goMap[-281380797649332533L].transform, false);
        goMap[2334977958462141438L].transform.SetParent(goMap[-281380797649332533L].transform, false);
        goMap[-9210423873083563645L].transform.SetParent(goMap[-281380797649332533L].transform, false);
        goMap[2347479578333914796L].transform.SetParent(goMap[4961308027296819806L].transform, false);
        goMap[258500554665313891L].transform.SetParent(goMap[-507707150166112072L].transform, false);
        goMap[-2642637056129874550L].transform.SetParent(goMap[-507707150166112072L].transform, false);
        goMap[2674258591880659044L].transform.SetParent(goMap[-2642637056129874550L].transform, false);
        goMap[-2725310986168751530L].transform.SetParent(goMap[-2642637056129874550L].transform, false);
        goMap[-244795751834911196L].transform.SetParent(goMap[-2725310986168751530L].transform, false);
        goMap[8087883388110124209L].transform.SetParent(goMap[-507707150166112072L].transform, false);
        goMap[703884347161453269L].transform.SetParent(goMap[-507707150166112072L].transform, false);
        goMap[2856201194609224635L].transform.SetParent(goMap[-507707150166112072L].transform, false);
        goMap[-1931275450661547443L].transform.SetParent(goMap[-507707150166112072L].transform, false);
        goMap[3935995226531007030L].transform.SetParent(goMap[-3509723304621144196L].transform, false);
        goMap[3017483831044405786L].transform.SetParent(goMap[3935995226531007030L].transform, false);
        goMap[7774152301619890235L].transform.SetParent(goMap[3935995226531007030L].transform, false);
        goMap[6510091471446130209L].transform.SetParent(goMap[-2513686513170334702L].transform, false);
        goMap[-1141440682808168872L].transform.SetParent(goMap[6510091471446130209L].transform, false);
        goMap[6584843944286227462L].transform.SetParent(goMap[-1141440682808168872L].transform, false);
        goMap[-1727804349827926575L].transform.SetParent(goMap[-1141440682808168872L].transform, false);
        goMap[4024499023208902900L].transform.SetParent(goMap[6510091471446130209L].transform, false);
        goMap[-7996621463030408123L].transform.SetParent(goMap[4024499023208902900L].transform, false);
        goMap[4431482020704316248L].transform.SetParent(goMap[4024499023208902900L].transform, false);
        goMap[3626250087862538551L].transform.SetParent(goMap[6510091471446130209L].transform, false);

        // ─── RectTransforms ──────────────────────────────────
        {
            var rt = goMap[-2513686513170334702L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.000000f, 1.000000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }
        {
            var rt = goMap[-3509723304621144196L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.000000f, 0.000000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }
        {
            var rt = goMap[-5495362718481652909L].AddComponent<RectTransform>();
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
            var rt = goMap[-1507406936179867867L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.500000f, 0.500000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-113.800003f, 0.000000f);
            rt.sizeDelta = new Vector2(90.000000f, 90.000000f);
        }
        {
            var rt = goMap[5482312748868989237L].AddComponent<RectTransform>();
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
            var rt = goMap[-1043601435006104507L].AddComponent<RectTransform>();
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
            var rt = goMap[-8826867592513018698L].AddComponent<RectTransform>();
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
            var rt = goMap[2740374963613404162L].AddComponent<RectTransform>();
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
            var rt = goMap[-7585794548253453685L].AddComponent<RectTransform>();
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
            var rt = goMap[7689728547276908803L].AddComponent<RectTransform>();
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
            var rt = goMap[223800268521639463L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-1.800000f, 0.000000f);
            rt.sizeDelta = new Vector2(120.000000f, 120.000000f);
        }
        {
            var rt = goMap[5364413952296121062L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-36.799999f, -28.200001f);
            rt.sizeDelta = new Vector2(53.480598f, 35.644001f);
        }
        {
            var rt = goMap[2572429339505542802L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(8.000000f, 0.200000f);
            rt.sizeDelta = new Vector2(36.000000f, 36.000000f);
        }
        {
            var rt = goMap[7201580684390628087L].AddComponent<RectTransform>();
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
            var rt = goMap[4868330342652639958L].AddComponent<RectTransform>();
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
            var rt = goMap[-7089629258753431221L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(28.700005f, 30.000000f);
            rt.sizeDelta = new Vector2(40.000000f, 40.000000f);
        }
        {
            var rt = goMap[3415586759589982094L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(208.000000f, -29.000000f);
            rt.sizeDelta = new Vector2(50.000000f, 25.000000f);
        }
        {
            var rt = goMap[-1104978712402916575L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(20.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(209.800003f, 48.000000f);
        }
        {
            var rt = goMap[1426734519584061150L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(78.000000f, -20.000000f);
            rt.sizeDelta = new Vector2(120.000000f, 40.000000f);
        }
        {
            var rt = goMap[2710565287139559808L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(106.000000f, -41.000000f);
            rt.sizeDelta = new Vector2(175.000000f, 8.000000f);
        }
        {
            var rt = goMap[6602268193820881126L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(-2.000000f, -2.000000f);
        }
        {
            var rt = goMap[7505876845407084972L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-105.299988f, 16.000000f);
            rt.sizeDelta = new Vector2(41.000000f, 42.000000f);
        }
        {
            var rt = goMap[4175268949578043524L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(5.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(260.000000f, 58.000000f);
        }
        {
            var rt = goMap[1988598330138276518L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(84.800003f, -1.500000f);
            rt.sizeDelta = new Vector2(1.000000f, 1.000000f);
        }
        {
            var rt = goMap[6032909320526371335L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(146.300003f, 0.000000f);
            rt.sizeDelta = new Vector2(40.000000f, 40.000000f);
        }
        {
            var rt = goMap[3167684777292570302L].AddComponent<RectTransform>();
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
            var rt = goMap[-7884584508217518047L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.500000f, 0.500000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-113.800003f, 0.000000f);
            rt.sizeDelta = new Vector2(90.000000f, 90.000000f);
        }
        {
            var rt = goMap[8315422536885579039L].AddComponent<RectTransform>();
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
            var rt = goMap[5697723376517842608L].AddComponent<RectTransform>();
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
            var rt = goMap[-3096378097726204018L].AddComponent<RectTransform>();
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
            var rt = goMap[5241438503448733028L].AddComponent<RectTransform>();
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
            var rt = goMap[-1811044059168001002L].AddComponent<RectTransform>();
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
            var rt = goMap[-8352919503681824565L].AddComponent<RectTransform>();
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
            var rt = goMap[242546135546512874L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-1.800000f, 0.000000f);
            rt.sizeDelta = new Vector2(120.000000f, 120.000000f);
        }
        {
            var rt = goMap[6755246648232389968L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-36.800011f, -28.200001f);
            rt.sizeDelta = new Vector2(53.480598f, 35.644001f);
        }
        {
            var rt = goMap[8681766664674948702L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(8.000000f, 0.200000f);
            rt.sizeDelta = new Vector2(36.000000f, 36.000000f);
        }
        {
            var rt = goMap[6259489509613031086L].AddComponent<RectTransform>();
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
            var rt = goMap[3391072058736191404L].AddComponent<RectTransform>();
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
            var rt = goMap[251774536289787443L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(28.700005f, 30.000000f);
            rt.sizeDelta = new Vector2(40.000000f, 40.000000f);
        }
        {
            var rt = goMap[474248166302101352L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(208.000000f, -29.000000f);
            rt.sizeDelta = new Vector2(50.000000f, 25.000000f);
        }
        {
            var rt = goMap[-1534808200604532765L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(20.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(209.800003f, 48.000000f);
        }
        {
            var rt = goMap[7389737801860773489L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(78.000000f, -20.000000f);
            rt.sizeDelta = new Vector2(120.000000f, 40.000000f);
        }
        {
            var rt = goMap[337134773040413100L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(106.000000f, -41.000000f);
            rt.sizeDelta = new Vector2(175.000000f, 8.000000f);
        }
        {
            var rt = goMap[7192974219545790476L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(-2.000000f, -2.000000f);
        }
        {
            var rt = goMap[-5051807356121029041L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-105.299988f, 16.000000f);
            rt.sizeDelta = new Vector2(41.000000f, 42.000000f);
        }
        {
            var rt = goMap[-915931463864161786L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(5.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(260.000000f, 58.000000f);
        }
        {
            var rt = goMap[1289881893737635087L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(84.799995f, -1.500000f);
            rt.sizeDelta = new Vector2(1.000000f, 1.000000f);
        }
        {
            var rt = goMap[-6427897379509932417L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(146.299988f, 0.000000f);
            rt.sizeDelta = new Vector2(40.000000f, 40.000000f);
        }
        {
            var rt = goMap[-2948690502920014827L].AddComponent<RectTransform>();
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
            var rt = goMap[-7704011285764435472L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.500000f, 0.500000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-113.800003f, 0.000000f);
            rt.sizeDelta = new Vector2(90.000000f, 90.000000f);
        }
        {
            var rt = goMap[1624582069023026126L].AddComponent<RectTransform>();
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
            var rt = goMap[8901730471514957605L].AddComponent<RectTransform>();
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
            var rt = goMap[-542929927082669350L].AddComponent<RectTransform>();
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
            var rt = goMap[-1676759048721487167L].AddComponent<RectTransform>();
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
            var rt = goMap[3790017652448762517L].AddComponent<RectTransform>();
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
            var rt = goMap[-1343092823770004931L].AddComponent<RectTransform>();
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
            var rt = goMap[8560871464969735350L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-1.800000f, 0.000000f);
            rt.sizeDelta = new Vector2(120.000000f, 120.000000f);
        }
        {
            var rt = goMap[-7675390605812291302L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-36.800011f, -28.200001f);
            rt.sizeDelta = new Vector2(53.480598f, 35.644001f);
        }
        {
            var rt = goMap[7297211244281670636L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(8.000000f, 0.200000f);
            rt.sizeDelta = new Vector2(36.000000f, 36.000000f);
        }
        {
            var rt = goMap[-9042861962797136038L].AddComponent<RectTransform>();
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
            var rt = goMap[1755758450075381044L].AddComponent<RectTransform>();
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
            var rt = goMap[5192311639185197600L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(28.700005f, 30.000000f);
            rt.sizeDelta = new Vector2(40.000000f, 40.000000f);
        }
        {
            var rt = goMap[-2967799343916164115L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(208.000000f, -29.000000f);
            rt.sizeDelta = new Vector2(50.000000f, 25.000000f);
        }
        {
            var rt = goMap[-3211731217540366985L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(20.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(209.800003f, 48.000000f);
        }
        {
            var rt = goMap[-8723154074159433792L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(78.000000f, -20.000000f);
            rt.sizeDelta = new Vector2(120.000000f, 40.000000f);
        }
        {
            var rt = goMap[-8525467854463032066L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(106.000000f, -41.000000f);
            rt.sizeDelta = new Vector2(175.000000f, 8.000000f);
        }
        {
            var rt = goMap[7501921787203000563L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(-2.000000f, -2.000000f);
        }
        {
            var rt = goMap[2526246940117544090L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-105.299988f, 16.000000f);
            rt.sizeDelta = new Vector2(41.000000f, 42.000000f);
        }
        {
            var rt = goMap[3880216853130031095L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(5.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(260.000000f, 58.000000f);
        }
        {
            var rt = goMap[6498576659694871767L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(84.799995f, -1.500000f);
            rt.sizeDelta = new Vector2(1.000000f, 1.000000f);
        }
        {
            var rt = goMap[-1194561796028643369L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(146.299988f, 0.000000f);
            rt.sizeDelta = new Vector2(40.000000f, 40.000000f);
        }
        {
            var rt = goMap[-507707150166112072L].AddComponent<RectTransform>();
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
            var rt = goMap[4961308027296819806L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.500000f, 0.500000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-113.800003f, 0.000000f);
            rt.sizeDelta = new Vector2(90.000000f, 90.000000f);
        }
        {
            var rt = goMap[-8392832162013966860L].AddComponent<RectTransform>();
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
            var rt = goMap[-2088122411448739851L].AddComponent<RectTransform>();
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
            var rt = goMap[-7154518197798899254L].AddComponent<RectTransform>();
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
            var rt = goMap[5566312368103575880L].AddComponent<RectTransform>();
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
            var rt = goMap[-1328630597961727950L].AddComponent<RectTransform>();
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
            var rt = goMap[-2290013825646560160L].AddComponent<RectTransform>();
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
            var rt = goMap[2172256319329340494L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-1.800000f, 0.000000f);
            rt.sizeDelta = new Vector2(120.000000f, 120.000000f);
        }
        {
            var rt = goMap[-281380797649332533L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-36.800011f, -28.200001f);
            rt.sizeDelta = new Vector2(53.480598f, 35.644001f);
        }
        {
            var rt = goMap[7065350729515874232L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(8.000000f, 0.200000f);
            rt.sizeDelta = new Vector2(36.000000f, 36.000000f);
        }
        {
            var rt = goMap[2334977958462141438L].AddComponent<RectTransform>();
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
            var rt = goMap[-9210423873083563645L].AddComponent<RectTransform>();
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
            var rt = goMap[2347479578333914796L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(28.699997f, 30.000000f);
            rt.sizeDelta = new Vector2(40.000000f, 40.000000f);
        }
        {
            var rt = goMap[258500554665313891L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(208.000000f, -29.000000f);
            rt.sizeDelta = new Vector2(50.000000f, 25.000000f);
        }
        {
            var rt = goMap[-2642637056129874550L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(20.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(209.800003f, 48.000000f);
        }
        {
            var rt = goMap[2674258591880659044L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(78.000000f, -20.000000f);
            rt.sizeDelta = new Vector2(120.000000f, 40.000000f);
        }
        {
            var rt = goMap[-2725310986168751530L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(106.000000f, -41.000000f);
            rt.sizeDelta = new Vector2(175.000000f, 8.000000f);
        }
        {
            var rt = goMap[-244795751834911196L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(-2.000000f, -2.000000f);
        }
        {
            var rt = goMap[8087883388110124209L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-105.299988f, 16.000000f);
            rt.sizeDelta = new Vector2(41.000000f, 42.000000f);
        }
        {
            var rt = goMap[703884347161453269L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(5.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(260.000000f, 58.000000f);
        }
        {
            var rt = goMap[2856201194609224635L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(84.799995f, -1.500000f);
            rt.sizeDelta = new Vector2(1.000000f, 1.000000f);
        }
        {
            var rt = goMap[-1931275450661547443L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(146.299988f, 0.000000f);
            rt.sizeDelta = new Vector2(40.000000f, 40.000000f);
        }
        {
            var rt = goMap[3935995226531007030L].AddComponent<RectTransform>();
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
            var rt = goMap[3017483831044405786L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.495500f, 0.000000f);
            rt.sizeDelta = new Vector2(200.355103f, 30.000000f);
        }
        {
            var rt = goMap[7774152301619890235L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.001248f, 0.000000f);
            rt.sizeDelta = new Vector2(220.000000f, 50.000000f);
        }
        {
            var rt = goMap[6510091471446130209L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 1.000000f);
            rt.anchorMax = new Vector2(0.000000f, 1.000000f);
            rt.pivot = new Vector2(0.000000f, 1.000000f);
            rt.anchoredPosition = new Vector2(0.000000f, 2.100000f);
            rt.sizeDelta = new Vector2(250.139999f, 238.100006f);
        }
        {
            var rt = goMap[-1141440682808168872L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.000008f, 69.979782f);
            rt.sizeDelta = new Vector2(250.139999f, 92.192001f);
        }
        {
            var rt = goMap[6584843944286227462L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(144.000000f, 58.000000f);
        }
        {
            var rt = goMap[-1727804349827926575L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(210.000000f, 60.000000f);
        }
        {
            var rt = goMap[4024499023208902900L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -25.299698f);
            rt.sizeDelta = new Vector2(250.139999f, 90.817299f);
        }
        {
            var rt = goMap[-7996621463030408123L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(144.000000f, 58.000000f);
        }
        {
            var rt = goMap[4431482020704316248L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(210.000000f, 60.000000f);
        }
        {
            var rt = goMap[3626250087862538551L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -89.300003f);
            rt.sizeDelta = new Vector2(210.000000f, 60.000000f);
        }

        // ─── Components ──────────────────────────────────────
        { var c = goMap[-3509723304621144196L].AddComponent<GridLayoutGroup>();
           c.padding = new RectOffset(0,0,0,0);
           c.cellSize = new Vector2(250.000000f, 57.500000f);
           c.spacing = new Vector2(0.000000f, 2.000000f);
           c.childAlignment = (TextAnchor)0;
        }
        { var c = goMap[-5495362718481652909L].AddComponent<Image>();
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
        }
        { var c = goMap[-5495362718481652909L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-1507406936179867867L].AddComponent<Image>();
           c.color = new Color(1f,1f,1f,0f);
           c.raycastTarget = true;
           c.maskable = true;
           c.enabled = true;
        }
        { var c = goMap[-1507406936179867867L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[5482312748868989237L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-1043601435006104507L].AddComponent<Image>();
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
        { var c = goMap[-1043601435006104507L].AddComponent<Mask>();
           c.showMaskGraphic = true;
           c.enabled = true;
        }
        { var c = goMap[-8826867592513018698L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-7585794548253453685L].AddComponent<Image>();
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
        { var c = goMap[7689728547276908803L].AddComponent<Text>();
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
        { var c = goMap[7689728547276908803L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[223800268521639463L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_empty_portrait");
        }
        { var c = goMap[2572429339505542802L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_level_bg");
        }
        { var c = goMap[7201580684390628087L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(0.172549f, 0.925490f, 0.278431f, 1.000000f);
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
        { var c = goMap[4868330342652639958L].AddComponent<Text>();
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
        { var g = goMap[4868330342652639958L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.996078f, 0.847059f, 0.984314f, 1.000000f); }
        { var c = goMap[4868330342652639958L].AddComponent<Outline>();
           c.effectColor = new Color(0.505882f, 0.090196f, 0.498039f, 1.000000f);
           c.effectDistance = new Vector2(1.500000f, -1.500000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-7089629258753431221L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[3415586759589982094L].AddComponent<Text>();
           c.text = "9728";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 16;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleRight;
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
        { var c = goMap[3415586759589982094L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[1426734519584061150L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 16;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleLeft;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 12;
           c.resizeTextMaxSize = 16;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[2710565287139559808L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_hp_bg");
        }
        { var c = goMap[6602268193820881126L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = false;
           c.maskable = true;
           c.type = Image.Type.Filled;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 0.444000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Horizontal;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_hp");
        }
        { var c = goMap[7505876845407084972L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_hud_leader");
        }
        { var c = goMap[4175268949578043524L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_hudteam_member");
        }
        { var c = goMap[1988598330138276518L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
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
        }
        { var c = goMap[6032909320526371335L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("nverhong_1");
        }
        { var c = goMap[3167684777292570302L].AddComponent<Image>();
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
        }
        { var c = goMap[3167684777292570302L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-7884584508217518047L].AddComponent<Image>();
           c.color = new Color(1f,1f,1f,0f);
           c.raycastTarget = true;
           c.maskable = true;
           c.enabled = true;
        }
        { var c = goMap[-7884584508217518047L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[8315422536885579039L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[5697723376517842608L].AddComponent<Image>();
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
        { var c = goMap[5697723376517842608L].AddComponent<Mask>();
           c.showMaskGraphic = true;
           c.enabled = true;
        }
        { var c = goMap[-3096378097726204018L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-1811044059168001002L].AddComponent<Image>();
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
        { var c = goMap[-8352919503681824565L].AddComponent<Text>();
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
        { var c = goMap[-8352919503681824565L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[242546135546512874L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_empty_portrait");
        }
        { var c = goMap[8681766664674948702L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_level_bg");
        }
        { var c = goMap[6259489509613031086L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(0.172549f, 0.925490f, 0.278431f, 1.000000f);
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
        { var c = goMap[3391072058736191404L].AddComponent<Text>();
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
        { var g = goMap[3391072058736191404L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.996078f, 0.847059f, 0.984314f, 1.000000f); }
        { var c = goMap[3391072058736191404L].AddComponent<Outline>();
           c.effectColor = new Color(0.505882f, 0.090196f, 0.498039f, 1.000000f);
           c.effectDistance = new Vector2(1.500000f, -1.500000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[251774536289787443L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[474248166302101352L].AddComponent<Text>();
           c.text = "9728";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 16;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleRight;
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
        { var c = goMap[474248166302101352L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[7389737801860773489L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 16;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleLeft;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 12;
           c.resizeTextMaxSize = 16;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[337134773040413100L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_hp_bg");
        }
        { var c = goMap[7192974219545790476L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = false;
           c.maskable = true;
           c.type = Image.Type.Filled;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 0.450000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Horizontal;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_hp");
        }
        { var c = goMap[-5051807356121029041L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_hud_leader");
        }
        { var c = goMap[-915931463864161786L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_hudteam_member");
        }
        { var c = goMap[1289881893737635087L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
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
        }
        { var c = goMap[-6427897379509932417L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("nverhong_1");
        }
        { var c = goMap[-2948690502920014827L].AddComponent<Image>();
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
        }
        { var c = goMap[-2948690502920014827L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-7704011285764435472L].AddComponent<Image>();
           c.color = new Color(1f,1f,1f,0f);
           c.raycastTarget = true;
           c.maskable = true;
           c.enabled = true;
        }
        { var c = goMap[-7704011285764435472L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[1624582069023026126L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[8901730471514957605L].AddComponent<Image>();
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
        { var c = goMap[8901730471514957605L].AddComponent<Mask>();
           c.showMaskGraphic = true;
           c.enabled = true;
        }
        { var c = goMap[-542929927082669350L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[3790017652448762517L].AddComponent<Image>();
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
        { var c = goMap[-1343092823770004931L].AddComponent<Text>();
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
        { var c = goMap[-1343092823770004931L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[8560871464969735350L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_empty_portrait");
        }
        { var c = goMap[7297211244281670636L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_level_bg");
        }
        { var c = goMap[-9042861962797136038L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(0.172549f, 0.925490f, 0.278431f, 1.000000f);
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
        { var c = goMap[1755758450075381044L].AddComponent<Text>();
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
        { var g = goMap[1755758450075381044L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.996078f, 0.847059f, 0.984314f, 1.000000f); }
        { var c = goMap[1755758450075381044L].AddComponent<Outline>();
           c.effectColor = new Color(0.505882f, 0.090196f, 0.498039f, 1.000000f);
           c.effectDistance = new Vector2(1.500000f, -1.500000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[5192311639185197600L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-2967799343916164115L].AddComponent<Text>();
           c.text = "9728";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 16;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleRight;
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
        { var c = goMap[-2967799343916164115L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-8723154074159433792L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 16;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleLeft;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 12;
           c.resizeTextMaxSize = 16;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-8525467854463032066L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_hp_bg");
        }
        { var c = goMap[7501921787203000563L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Filled;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 0.450000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Horizontal;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_hp");
        }
        { var c = goMap[2526246940117544090L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_hud_leader");
        }
        { var c = goMap[3880216853130031095L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_hudteam_member");
        }
        { var c = goMap[6498576659694871767L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
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
        }
        { var c = goMap[-1194561796028643369L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("nverhong_1");
        }
        { var c = goMap[-507707150166112072L].AddComponent<Image>();
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
        }
        { var c = goMap[-507707150166112072L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[4961308027296819806L].AddComponent<Image>();
           c.color = new Color(1f,1f,1f,0f);
           c.raycastTarget = true;
           c.maskable = true;
           c.enabled = true;
        }
        { var c = goMap[4961308027296819806L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-8392832162013966860L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-2088122411448739851L].AddComponent<Image>();
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
        { var c = goMap[-2088122411448739851L].AddComponent<Mask>();
           c.showMaskGraphic = true;
           c.enabled = true;
        }
        { var c = goMap[-7154518197798899254L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-1328630597961727950L].AddComponent<Image>();
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
        { var c = goMap[-2290013825646560160L].AddComponent<Text>();
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
        { var c = goMap[-2290013825646560160L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[2172256319329340494L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_empty_portrait");
        }
        { var c = goMap[7065350729515874232L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_level_bg");
        }
        { var c = goMap[2334977958462141438L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(0.172549f, 0.925490f, 0.278431f, 1.000000f);
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
        { var c = goMap[-9210423873083563645L].AddComponent<Text>();
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
        { var g = goMap[-9210423873083563645L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(0.996078f, 0.847059f, 0.984314f, 1.000000f); }
        { var c = goMap[-9210423873083563645L].AddComponent<Outline>();
           c.effectColor = new Color(0.505882f, 0.090196f, 0.498039f, 1.000000f);
           c.effectDistance = new Vector2(1.500000f, -1.500000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[2347479578333914796L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[258500554665313891L].AddComponent<Text>();
           c.text = "9728";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 16;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleRight;
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
        { var c = goMap[258500554665313891L].AddComponent<Outline>();
           c.effectColor = new Color(0.000000f, 0.000000f, 0.000000f, 0.392157f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[2674258591880659044L].AddComponent<Text>();
           c.text = "dynamic_change_from_script";
           c.color = new Color(1.000000f, 0.980392f, 0.901961f, 1.000000f);
           c.fontSize = 16;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.MiddleLeft;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = true;
           c.resizeTextMinSize = 12;
           c.resizeTextMaxSize = 16;
           c.raycastTarget = false;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var c = goMap[-2725310986168751530L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_hp_bg");
        }
        { var c = goMap[-244795751834911196L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = false;
           c.maskable = true;
           c.type = Image.Type.Filled;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 0.450000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Horizontal;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("img_hp");
        }
        { var c = goMap[8087883388110124209L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_hud_leader");
        }
        { var c = goMap[703884347161453269L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_hudteam_member");
        }
        { var c = goMap[2856201194609224635L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
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
        }
        { var c = goMap[-1931275450661547443L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("nverhong_1");
        }
        { var c = goMap[3935995226531007030L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.000000f, 0.000000f, 0.588235f);
           c.raycastTarget = true;
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
        { var c = goMap[3017483831044405786L].AddComponent<Text>();
           c.text = "添加队员";
           c.color = new Color(0.125490f, 0.980392f, 0.066667f, 1.000000f);
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
        { var c = goMap[7774152301619890235L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_white");
        }
        { var c = goMap[7774152301619890235L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[7774152301619890235L].AddComponent<UIScalePulse>();
           c.upScale = 0.950000f; c.duration = 0.100000f; c.scaleUp = false;
           c.enabled = true;
        }
        { var c = goMap[6510091471446130209L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.000000f, 0.000000f, 0.490196f);
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
           c.sprite = LookupSprite("img_white");
        }
        { var c = goMap[-1141440682808168872L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.000000f, 0.000000f, 0.588235f);
           c.raycastTarget = true;
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
        { var c = goMap[-1141440682808168872L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[6584843944286227462L].AddComponent<Image>();
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
        }
        { var c = goMap[-1727804349827926575L].AddComponent<Text>();
           c.text = "创建队伍";
           c.color = new Color(0.752941f, 0.870588f, 0.823529f, 1.000000f);
           c.fontSize = 26;
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
        { var c = goMap[4024499023208902900L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.000000f, 0.000000f, 0.588235f);
           c.raycastTarget = true;
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
        { var c = goMap[4024499023208902900L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-7996621463030408123L].AddComponent<Image>();
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
        }
        { var c = goMap[4431482020704316248L].AddComponent<Text>();
           c.text = "周围队伍";
           c.color = new Color(0.752941f, 0.870588f, 0.823529f, 1.000000f);
           c.fontSize = 26;
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
        { var c = goMap[3626250087862538551L].AddComponent<Text>();
           c.text = "TeamMatching";
           c.color = new Color(0.752941f, 0.870588f, 0.823529f, 1.000000f);
           c.fontSize = 24;
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

        // ─── Resolve Toggle → ToggleGroup links ─────────────
        foreach (var kv in _toggleGroupLinks)
        {
            ToggleGroup grp;
            if (_toggleGroupByMbPid.TryGetValue(kv.Item2, out grp) && grp != null)
                kv.Item1.group = grp;
        }

        // ─── Save prefab ─────────────────────────────────────
        Directory.CreateDirectory("Assets/Prefabs/Imported");
        var rootGO = goMap[-2513686513170334702L];
        string path = "Assets/Prefabs/Imported/UIHudLeftPanelTeam.prefab";
        PrefabUtility.SaveAsPrefabAsset(rootGO, path);
        Object.DestroyImmediate(rootGO);
        Debug.Log("[Import_res_p_99] Saved " + path);
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