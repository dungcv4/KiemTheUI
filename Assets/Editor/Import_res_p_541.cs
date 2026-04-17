// AUTO-GENERATED from res_p_541.ab — DO NOT EDIT MANUALLY.
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;
using System.Collections.Generic;
using KTO.Game;  // UIJoyStick and other ported KTO scripts

public class Import_res_p_541
{
    [MenuItem("KTO/Import/res_p_541")]
    public static void Build()
    {
        Debug.Log("[Import_res_p_541] Building UIRankPromotion...");

        // ─── Create all GameObjects ───────────────────────────
        var goMap = new Dictionary<long, GameObject>();
        var _toggleGroupByMbPid = new Dictionary<long, ToggleGroup>();
        var _toggleGroupLinks = new List<System.Tuple<Toggle,long>>();
        { var go = new GameObject("UIRankPromotion"); go.SetActive(true); goMap[-2518585297228529315L] = go; }
        { var go = new GameObject("node"); go.SetActive(true); goMap[104379545984303206L] = go; }
        { var go = new GameObject("bgGroup"); go.SetActive(true); goMap[-7154772289168635054L] = go; }
        { var go = new GameObject("Succeed_Effect"); go.SetActive(true); goMap[1257098583744644910L] = go; }
        { var go = new GameObject("HongYunDangTou_Effect"); go.SetActive(true); goMap[-4308531903168783503L] = go; }
        { var go = new GameObject("Black"); go.SetActive(true); goMap[3201555406317655730L] = go; }
        { var go = new GameObject("bg"); go.SetActive(true); goMap[-1855500468232027138L] = go; }
        { var go = new GameObject("imgMask_RefineSucceedEffect"); go.SetActive(true); goMap[1239199600710376010L] = go; }
        { var go = new GameObject("HuoYanShan"); go.SetActive(true); goMap[7421852962709303208L] = go; }
        { var go = new GameObject("FengHuang01"); go.SetActive(true); goMap[3370808159112061783L] = go; }
        { var go = new GameObject("LiuGuang"); go.SetActive(true); goMap[-5904553460043721347L] = go; }
        { var go = new GameObject("M2"); go.SetActive(true); goMap[1195170330553743284L] = go; }
        { var go = new GameObject("Glow"); go.SetActive(true); goMap[-3908985587095182575L] = go; }
        { var go = new GameObject("FengHuang02"); go.SetActive(true); goMap[1065031930445777269L] = go; }
        { var go = new GameObject("LiuGuang"); go.SetActive(true); goMap[-3077108116113672842L] = go; }
        { var go = new GameObject("M2"); go.SetActive(true); goMap[2396417426401341862L] = go; }
        { var go = new GameObject("Glow"); go.SetActive(true); goMap[3807312000994324489L] = go; }
        { var go = new GameObject("txt"); go.SetActive(false); goMap[-595574990527438525L] = go; }
        { var go = new GameObject("AwardTips"); go.SetActive(true); goMap[8086470748451449560L] = go; }
        { var go = new GameObject("txtAward"); go.SetActive(true); goMap[4341347639073241946L] = go; }
        { var go = new GameObject("txtAwardValue"); go.SetActive(true); goMap[5894435831502766156L] = go; }
        { var go = new GameObject("001"); go.SetActive(true); goMap[5971442499714705005L] = go; }
        { var go = new GameObject("01"); go.SetActive(true); goMap[-9154909754418658607L] = go; }
        { var go = new GameObject("Di"); go.SetActive(true); goMap[3397944686295458176L] = go; }
        { var go = new GameObject("Bian"); go.SetActive(true); goMap[-4333447126800760289L] = go; }
        { var go = new GameObject("Jian"); go.SetActive(true); goMap[6589323014343685819L] = go; }
        { var go = new GameObject("002"); go.SetActive(false); goMap[3200902547026773551L] = go; }
        { var go = new GameObject("01"); go.SetActive(true); goMap[-1057650393998734860L] = go; }
        { var go = new GameObject("Di"); go.SetActive(true); goMap[-7636052702942455461L] = go; }
        { var go = new GameObject("Bian"); go.SetActive(true); goMap[-8010486652265458597L] = go; }
        { var go = new GameObject("Jian"); go.SetActive(true); goMap[-754013320304844959L] = go; }
        { var go = new GameObject("LightBeam"); go.SetActive(true); goMap[4173952712471543209L] = go; }
        { var go = new GameObject("ParticleEffect01"); go.SetActive(true); goMap[-8187344880566564835L] = go; }
        { var go = new GameObject("M2"); go.SetActive(true); goMap[-7552050284425683184L] = go; }
        { var go = new GameObject("M9"); go.SetActive(true); goMap[7761965782319263779L] = go; }
        { var go = new GameObject("003"); go.SetActive(false); goMap[-4376309279324246038L] = go; }
        { var go = new GameObject("06"); go.SetActive(true); goMap[-3741271541233245385L] = go; }
        { var go = new GameObject("Di"); go.SetActive(true); goMap[1643563398472142691L] = go; }
        { var go = new GameObject("Left"); go.SetActive(true); goMap[5239597342874621459L] = go; }
        { var go = new GameObject("BJinChi"); go.SetActive(true); goMap[8881683248388082458L] = go; }
        { var go = new GameObject("Right"); go.SetActive(true); goMap[-5843494126916140922L] = go; }
        { var go = new GameObject("BJinChi"); go.SetActive(true); goMap[6979574298721462194L] = go; }
        { var go = new GameObject("Jian"); go.SetActive(true); goMap[-1691355025540215320L] = go; }
        { var go = new GameObject("LightBeam"); go.SetActive(true); goMap[-5086726845345822536L] = go; }
        { var go = new GameObject("ParticleEffect01"); go.SetActive(true); goMap[-7869303613310279535L] = go; }
        { var go = new GameObject("M2"); go.SetActive(true); goMap[-2683914215333368387L] = go; }
        { var go = new GameObject("M7"); go.SetActive(true); goMap[-6150993440463301899L] = go; }
        { var go = new GameObject("M9"); go.SetActive(true); goMap[4503832999969256114L] = go; }
        { var go = new GameObject("M12"); go.SetActive(true); goMap[-4400853597050198202L] = go; }
        { var go = new GameObject("M1"); go.SetActive(true); goMap[-3128395026888051467L] = go; }
        { var go = new GameObject("004"); go.SetActive(false); goMap[-6909566829229560869L] = go; }
        { var go = new GameObject("06"); go.SetActive(true); goMap[7393998746021394992L] = go; }
        { var go = new GameObject("Di"); go.SetActive(true); goMap[1923515459789414190L] = go; }
        { var go = new GameObject("DiGlow"); go.SetActive(true); goMap[5517870903635298610L] = go; }
        { var go = new GameObject("Left"); go.SetActive(true); goMap[-8496141532092978373L] = go; }
        { var go = new GameObject("04-Red"); go.SetActive(true); goMap[4728466518470497493L] = go; }
        { var go = new GameObject("BJinChi"); go.SetActive(true); goMap[-5858491271074859662L] = go; }
        { var go = new GameObject("BJinChiLiuGuang"); go.SetActive(true); goMap[7815325830266213874L] = go; }
        { var go = new GameObject("Right"); go.SetActive(true); goMap[-5956195214413076150L] = go; }
        { var go = new GameObject("04-Red"); go.SetActive(true); goMap[1553358591688971301L] = go; }
        { var go = new GameObject("BJinChi"); go.SetActive(true); goMap[2728170170037942635L] = go; }
        { var go = new GameObject("BJinChiLiuGuang"); go.SetActive(true); goMap[-5508440501310254197L] = go; }
        { var go = new GameObject("Jian"); go.SetActive(true); goMap[165091215433578647L] = go; }
        { var go = new GameObject("JianGlow01"); go.SetActive(true); goMap[2427226106854177707L] = go; }
        { var go = new GameObject("LightBeam"); go.SetActive(true); goMap[-2222031366920804876L] = go; }
        { var go = new GameObject("ParticleEffect01"); go.SetActive(true); goMap[7982828906448102121L] = go; }
        { var go = new GameObject("M2"); go.SetActive(true); goMap[4932883409340286376L] = go; }
        { var go = new GameObject("M7"); go.SetActive(true); goMap[1034225862570303465L] = go; }
        { var go = new GameObject("M8"); go.SetActive(true); goMap[1734908346312748471L] = go; }
        { var go = new GameObject("M9"); go.SetActive(true); goMap[696057169541090296L] = go; }
        { var go = new GameObject("M12"); go.SetActive(true); goMap[6237339859642978148L] = go; }
        { var go = new GameObject("M1"); go.SetActive(true); goMap[2582834713789015866L] = go; }
        { var go = new GameObject("005"); go.SetActive(false); goMap[-8411118445094999840L] = go; }
        { var go = new GameObject("05"); go.SetActive(true); goMap[828009690019412666L] = go; }
        { var go = new GameObject("Di"); go.SetActive(true); goMap[-3337237605245703439L] = go; }
        { var go = new GameObject("DiGlow"); go.SetActive(true); goMap[-3383023698317278288L] = go; }
        { var go = new GameObject("Left"); go.SetActive(true); goMap[-1919010543945213693L] = go; }
        { var go = new GameObject("PiaoDai"); go.SetActive(true); goMap[-8209174204535966L] = go; }
        { var go = new GameObject("BJinChi"); go.SetActive(true); goMap[-3912419564210154053L] = go; }
        { var go = new GameObject("BJinChiLiuGuang"); go.SetActive(true); goMap[1216520523636512977L] = go; }
        { var go = new GameObject("Jian"); go.SetActive(true); goMap[-9057051366944743214L] = go; }
        { var go = new GameObject("JianGlow"); go.SetActive(true); goMap[-2091524321207708872L] = go; }
        { var go = new GameObject("JianGlow01"); go.SetActive(true); goMap[-2214381888053284411L] = go; }
        { var go = new GameObject("JianGlowLoop"); go.SetActive(true); goMap[9221010084868225501L] = go; }
        { var go = new GameObject("Right"); go.SetActive(true); goMap[-518910619049669807L] = go; }
        { var go = new GameObject("PiaoDai"); go.SetActive(true); goMap[3940917523944053259L] = go; }
        { var go = new GameObject("BJinChi"); go.SetActive(true); goMap[6509065813367546125L] = go; }
        { var go = new GameObject("BJinChiLiuGuang"); go.SetActive(true); goMap[2905309632800712019L] = go; }
        { var go = new GameObject("LightBeam"); go.SetActive(true); goMap[3363004205918899107L] = go; }
        { var go = new GameObject("ParticleEffect01"); go.SetActive(true); goMap[8823624154489291986L] = go; }
        { var go = new GameObject("M1"); go.SetActive(true); goMap[5879905192248942572L] = go; }
        { var go = new GameObject("M2"); go.SetActive(true); goMap[5632060356500671667L] = go; }
        { var go = new GameObject("M5"); go.SetActive(true); goMap[-503692321918305861L] = go; }
        { var go = new GameObject("M7"); go.SetActive(true); goMap[-6814304347487236278L] = go; }
        { var go = new GameObject("M8"); go.SetActive(true); goMap[-7573937069076854191L] = go; }
        { var go = new GameObject("M9"); go.SetActive(true); goMap[-535758120205278947L] = go; }
        { var go = new GameObject("M12"); go.SetActive(true); goMap[5727217183140462699L] = go; }
        { var go = new GameObject("M3"); go.SetActive(true); goMap[-5504766216963651674L] = go; }
        { var go = new GameObject("006"); go.SetActive(false); goMap[-1984872683595409183L] = go; }
        { var go = new GameObject("06"); go.SetActive(true); goMap[-5172019794038548753L] = go; }
        { var go = new GameObject("Di"); go.SetActive(true); goMap[3852119607289136592L] = go; }
        { var go = new GameObject("DiGlow"); go.SetActive(true); goMap[9001286143119974629L] = go; }
        { var go = new GameObject("Left"); go.SetActive(true); goMap[-1588164926691698L] = go; }
        { var go = new GameObject("PiaoDai"); go.SetActive(true); goMap[8127015196328522004L] = go; }
        { var go = new GameObject("BJinChi01"); go.SetActive(true); goMap[-8394764112248088770L] = go; }
        { var go = new GameObject("BJinChi"); go.SetActive(true); goMap[-1807096733964713277L] = go; }
        { var go = new GameObject("BJinChiLiuGuang"); go.SetActive(true); goMap[2645441379006853424L] = go; }
        { var go = new GameObject("BigPiaoDai"); go.SetActive(true); goMap[398478294506049208L] = go; }
        { var go = new GameObject("SJinChi"); go.SetActive(true); goMap[-7239819039330596213L] = go; }
        { var go = new GameObject("SJinChiLiuGuang"); go.SetActive(true); goMap[8370569931883637921L] = go; }
        { var go = new GameObject("Right"); go.SetActive(true); goMap[-6921806350730023641L] = go; }
        { var go = new GameObject("PiaoDai"); go.SetActive(true); goMap[-5316079061689600472L] = go; }
        { var go = new GameObject("BJinChi01"); go.SetActive(true); goMap[2785384296073530917L] = go; }
        { var go = new GameObject("BJinChi"); go.SetActive(true); goMap[4665589517270851057L] = go; }
        { var go = new GameObject("BJinChiLiuGuang"); go.SetActive(true); goMap[-2421514388694109441L] = go; }
        { var go = new GameObject("BigPiaoDai"); go.SetActive(true); goMap[-5167416274920966693L] = go; }
        { var go = new GameObject("SJinChi"); go.SetActive(true); goMap[-1621265364486047390L] = go; }
        { var go = new GameObject("SJinChiLiuGuang"); go.SetActive(true); goMap[3270199387603381779L] = go; }
        { var go = new GameObject("Jian"); go.SetActive(true); goMap[5178901161516173443L] = go; }
        { var go = new GameObject("JianGlow"); go.SetActive(true); goMap[6059525678364630173L] = go; }
        { var go = new GameObject("JianGlowLoop"); go.SetActive(true); goMap[8556775588466680104L] = go; }
        { var go = new GameObject("LightBeam"); go.SetActive(true); goMap[7742423698143694482L] = go; }
        { var go = new GameObject("ParticleEffect01"); go.SetActive(true); goMap[-7566578207933672238L] = go; }
        { var go = new GameObject("M2"); go.SetActive(true); goMap[-1545686520949018024L] = go; }
        { var go = new GameObject("M5"); go.SetActive(true); goMap[-761546630335259407L] = go; }
        { var go = new GameObject("M7"); go.SetActive(true); goMap[-1013961330913364619L] = go; }
        { var go = new GameObject("M8"); go.SetActive(true); goMap[5461531821122689756L] = go; }
        { var go = new GameObject("M9"); go.SetActive(true); goMap[448262219043532089L] = go; }
        { var go = new GameObject("M11"); go.SetActive(true); goMap[6854842030778510610L] = go; }
        { var go = new GameObject("M12"); go.SetActive(true); goMap[-2544587404890571498L] = go; }
        { var go = new GameObject("M1"); go.SetActive(true); goMap[7569018676168357851L] = go; }
        { var go = new GameObject("M3"); go.SetActive(true); goMap[72654080111849436L] = go; }

        // ─── Parent links ─────────────────────────────────────
        goMap[104379545984303206L].transform.SetParent(goMap[-2518585297228529315L].transform, false);
        goMap[-7154772289168635054L].transform.SetParent(goMap[104379545984303206L].transform, false);
        goMap[1257098583744644910L].transform.SetParent(goMap[104379545984303206L].transform, false);
        goMap[-4308531903168783503L].transform.SetParent(goMap[1257098583744644910L].transform, false);
        goMap[3201555406317655730L].transform.SetParent(goMap[-4308531903168783503L].transform, false);
        goMap[-1855500468232027138L].transform.SetParent(goMap[-4308531903168783503L].transform, false);
        goMap[1239199600710376010L].transform.SetParent(goMap[-4308531903168783503L].transform, false);
        goMap[7421852962709303208L].transform.SetParent(goMap[-4308531903168783503L].transform, false);
        goMap[3370808159112061783L].transform.SetParent(goMap[-4308531903168783503L].transform, false);
        goMap[-5904553460043721347L].transform.SetParent(goMap[3370808159112061783L].transform, false);
        goMap[1195170330553743284L].transform.SetParent(goMap[-5904553460043721347L].transform, false);
        goMap[-3908985587095182575L].transform.SetParent(goMap[3370808159112061783L].transform, false);
        goMap[1065031930445777269L].transform.SetParent(goMap[-4308531903168783503L].transform, false);
        goMap[-3077108116113672842L].transform.SetParent(goMap[1065031930445777269L].transform, false);
        goMap[2396417426401341862L].transform.SetParent(goMap[-3077108116113672842L].transform, false);
        goMap[3807312000994324489L].transform.SetParent(goMap[1065031930445777269L].transform, false);
        goMap[-595574990527438525L].transform.SetParent(goMap[-4308531903168783503L].transform, false);
        goMap[8086470748451449560L].transform.SetParent(goMap[-4308531903168783503L].transform, false);
        goMap[4341347639073241946L].transform.SetParent(goMap[8086470748451449560L].transform, false);
        goMap[5894435831502766156L].transform.SetParent(goMap[8086470748451449560L].transform, false);
        goMap[5971442499714705005L].transform.SetParent(goMap[-4308531903168783503L].transform, false);
        goMap[-9154909754418658607L].transform.SetParent(goMap[5971442499714705005L].transform, false);
        goMap[3397944686295458176L].transform.SetParent(goMap[-9154909754418658607L].transform, false);
        goMap[-4333447126800760289L].transform.SetParent(goMap[-9154909754418658607L].transform, false);
        goMap[6589323014343685819L].transform.SetParent(goMap[-9154909754418658607L].transform, false);
        goMap[3200902547026773551L].transform.SetParent(goMap[-4308531903168783503L].transform, false);
        goMap[-1057650393998734860L].transform.SetParent(goMap[3200902547026773551L].transform, false);
        goMap[-7636052702942455461L].transform.SetParent(goMap[-1057650393998734860L].transform, false);
        goMap[-8010486652265458597L].transform.SetParent(goMap[-1057650393998734860L].transform, false);
        goMap[-754013320304844959L].transform.SetParent(goMap[-1057650393998734860L].transform, false);
        goMap[4173952712471543209L].transform.SetParent(goMap[-1057650393998734860L].transform, false);
        goMap[-8187344880566564835L].transform.SetParent(goMap[-1057650393998734860L].transform, false);
        goMap[-7552050284425683184L].transform.SetParent(goMap[-8187344880566564835L].transform, false);
        goMap[7761965782319263779L].transform.SetParent(goMap[-8187344880566564835L].transform, false);
        goMap[-4376309279324246038L].transform.SetParent(goMap[-4308531903168783503L].transform, false);
        goMap[-3741271541233245385L].transform.SetParent(goMap[-4376309279324246038L].transform, false);
        goMap[1643563398472142691L].transform.SetParent(goMap[-3741271541233245385L].transform, false);
        goMap[5239597342874621459L].transform.SetParent(goMap[-3741271541233245385L].transform, false);
        goMap[8881683248388082458L].transform.SetParent(goMap[5239597342874621459L].transform, false);
        goMap[-5843494126916140922L].transform.SetParent(goMap[-3741271541233245385L].transform, false);
        goMap[6979574298721462194L].transform.SetParent(goMap[-5843494126916140922L].transform, false);
        goMap[-1691355025540215320L].transform.SetParent(goMap[-3741271541233245385L].transform, false);
        goMap[-5086726845345822536L].transform.SetParent(goMap[-3741271541233245385L].transform, false);
        goMap[-7869303613310279535L].transform.SetParent(goMap[-3741271541233245385L].transform, false);
        goMap[-2683914215333368387L].transform.SetParent(goMap[-7869303613310279535L].transform, false);
        goMap[-6150993440463301899L].transform.SetParent(goMap[-7869303613310279535L].transform, false);
        goMap[4503832999969256114L].transform.SetParent(goMap[-7869303613310279535L].transform, false);
        goMap[-4400853597050198202L].transform.SetParent(goMap[-7869303613310279535L].transform, false);
        goMap[-3128395026888051467L].transform.SetParent(goMap[-7869303613310279535L].transform, false);
        goMap[-6909566829229560869L].transform.SetParent(goMap[-4308531903168783503L].transform, false);
        goMap[7393998746021394992L].transform.SetParent(goMap[-6909566829229560869L].transform, false);
        goMap[1923515459789414190L].transform.SetParent(goMap[7393998746021394992L].transform, false);
        goMap[5517870903635298610L].transform.SetParent(goMap[1923515459789414190L].transform, false);
        goMap[-8496141532092978373L].transform.SetParent(goMap[7393998746021394992L].transform, false);
        goMap[4728466518470497493L].transform.SetParent(goMap[-8496141532092978373L].transform, false);
        goMap[-5858491271074859662L].transform.SetParent(goMap[-8496141532092978373L].transform, false);
        goMap[7815325830266213874L].transform.SetParent(goMap[-5858491271074859662L].transform, false);
        goMap[-5956195214413076150L].transform.SetParent(goMap[7393998746021394992L].transform, false);
        goMap[1553358591688971301L].transform.SetParent(goMap[-5956195214413076150L].transform, false);
        goMap[2728170170037942635L].transform.SetParent(goMap[-5956195214413076150L].transform, false);
        goMap[-5508440501310254197L].transform.SetParent(goMap[2728170170037942635L].transform, false);
        goMap[165091215433578647L].transform.SetParent(goMap[7393998746021394992L].transform, false);
        goMap[2427226106854177707L].transform.SetParent(goMap[165091215433578647L].transform, false);
        goMap[-2222031366920804876L].transform.SetParent(goMap[7393998746021394992L].transform, false);
        goMap[7982828906448102121L].transform.SetParent(goMap[7393998746021394992L].transform, false);
        goMap[4932883409340286376L].transform.SetParent(goMap[7982828906448102121L].transform, false);
        goMap[1034225862570303465L].transform.SetParent(goMap[7982828906448102121L].transform, false);
        goMap[1734908346312748471L].transform.SetParent(goMap[7982828906448102121L].transform, false);
        goMap[696057169541090296L].transform.SetParent(goMap[7982828906448102121L].transform, false);
        goMap[6237339859642978148L].transform.SetParent(goMap[7982828906448102121L].transform, false);
        goMap[2582834713789015866L].transform.SetParent(goMap[7982828906448102121L].transform, false);
        goMap[-8411118445094999840L].transform.SetParent(goMap[-4308531903168783503L].transform, false);
        goMap[828009690019412666L].transform.SetParent(goMap[-8411118445094999840L].transform, false);
        goMap[-3337237605245703439L].transform.SetParent(goMap[828009690019412666L].transform, false);
        goMap[-3383023698317278288L].transform.SetParent(goMap[-3337237605245703439L].transform, false);
        goMap[-1919010543945213693L].transform.SetParent(goMap[828009690019412666L].transform, false);
        goMap[-8209174204535966L].transform.SetParent(goMap[-1919010543945213693L].transform, false);
        goMap[-3912419564210154053L].transform.SetParent(goMap[-1919010543945213693L].transform, false);
        goMap[1216520523636512977L].transform.SetParent(goMap[-3912419564210154053L].transform, false);
        goMap[-9057051366944743214L].transform.SetParent(goMap[828009690019412666L].transform, false);
        goMap[-2091524321207708872L].transform.SetParent(goMap[-9057051366944743214L].transform, false);
        goMap[-2214381888053284411L].transform.SetParent(goMap[-9057051366944743214L].transform, false);
        goMap[9221010084868225501L].transform.SetParent(goMap[-9057051366944743214L].transform, false);
        goMap[-518910619049669807L].transform.SetParent(goMap[828009690019412666L].transform, false);
        goMap[3940917523944053259L].transform.SetParent(goMap[-518910619049669807L].transform, false);
        goMap[6509065813367546125L].transform.SetParent(goMap[-518910619049669807L].transform, false);
        goMap[2905309632800712019L].transform.SetParent(goMap[6509065813367546125L].transform, false);
        goMap[3363004205918899107L].transform.SetParent(goMap[828009690019412666L].transform, false);
        goMap[8823624154489291986L].transform.SetParent(goMap[828009690019412666L].transform, false);
        goMap[5879905192248942572L].transform.SetParent(goMap[8823624154489291986L].transform, false);
        goMap[5632060356500671667L].transform.SetParent(goMap[8823624154489291986L].transform, false);
        goMap[-503692321918305861L].transform.SetParent(goMap[8823624154489291986L].transform, false);
        goMap[-6814304347487236278L].transform.SetParent(goMap[8823624154489291986L].transform, false);
        goMap[-7573937069076854191L].transform.SetParent(goMap[8823624154489291986L].transform, false);
        goMap[-535758120205278947L].transform.SetParent(goMap[8823624154489291986L].transform, false);
        goMap[5727217183140462699L].transform.SetParent(goMap[8823624154489291986L].transform, false);
        goMap[-5504766216963651674L].transform.SetParent(goMap[8823624154489291986L].transform, false);
        goMap[-1984872683595409183L].transform.SetParent(goMap[-4308531903168783503L].transform, false);
        goMap[-5172019794038548753L].transform.SetParent(goMap[-1984872683595409183L].transform, false);
        goMap[3852119607289136592L].transform.SetParent(goMap[-5172019794038548753L].transform, false);
        goMap[9001286143119974629L].transform.SetParent(goMap[3852119607289136592L].transform, false);
        goMap[-1588164926691698L].transform.SetParent(goMap[-5172019794038548753L].transform, false);
        goMap[8127015196328522004L].transform.SetParent(goMap[-1588164926691698L].transform, false);
        goMap[-8394764112248088770L].transform.SetParent(goMap[-1588164926691698L].transform, false);
        goMap[-1807096733964713277L].transform.SetParent(goMap[-1588164926691698L].transform, false);
        goMap[2645441379006853424L].transform.SetParent(goMap[-1807096733964713277L].transform, false);
        goMap[398478294506049208L].transform.SetParent(goMap[-1588164926691698L].transform, false);
        goMap[-7239819039330596213L].transform.SetParent(goMap[-1588164926691698L].transform, false);
        goMap[8370569931883637921L].transform.SetParent(goMap[-7239819039330596213L].transform, false);
        goMap[-6921806350730023641L].transform.SetParent(goMap[-5172019794038548753L].transform, false);
        goMap[-5316079061689600472L].transform.SetParent(goMap[-6921806350730023641L].transform, false);
        goMap[2785384296073530917L].transform.SetParent(goMap[-6921806350730023641L].transform, false);
        goMap[4665589517270851057L].transform.SetParent(goMap[-6921806350730023641L].transform, false);
        goMap[-2421514388694109441L].transform.SetParent(goMap[4665589517270851057L].transform, false);
        goMap[-5167416274920966693L].transform.SetParent(goMap[-6921806350730023641L].transform, false);
        goMap[-1621265364486047390L].transform.SetParent(goMap[-6921806350730023641L].transform, false);
        goMap[3270199387603381779L].transform.SetParent(goMap[-1621265364486047390L].transform, false);
        goMap[5178901161516173443L].transform.SetParent(goMap[-5172019794038548753L].transform, false);
        goMap[6059525678364630173L].transform.SetParent(goMap[5178901161516173443L].transform, false);
        goMap[8556775588466680104L].transform.SetParent(goMap[5178901161516173443L].transform, false);
        goMap[7742423698143694482L].transform.SetParent(goMap[-5172019794038548753L].transform, false);
        goMap[-7566578207933672238L].transform.SetParent(goMap[-5172019794038548753L].transform, false);
        goMap[-1545686520949018024L].transform.SetParent(goMap[-7566578207933672238L].transform, false);
        goMap[-761546630335259407L].transform.SetParent(goMap[-7566578207933672238L].transform, false);
        goMap[-1013961330913364619L].transform.SetParent(goMap[-7566578207933672238L].transform, false);
        goMap[5461531821122689756L].transform.SetParent(goMap[-7566578207933672238L].transform, false);
        goMap[448262219043532089L].transform.SetParent(goMap[-7566578207933672238L].transform, false);
        goMap[6854842030778510610L].transform.SetParent(goMap[-7566578207933672238L].transform, false);
        goMap[-2544587404890571498L].transform.SetParent(goMap[-7566578207933672238L].transform, false);
        goMap[7569018676168357851L].transform.SetParent(goMap[-7566578207933672238L].transform, false);
        goMap[72654080111849436L].transform.SetParent(goMap[-7566578207933672238L].transform, false);

        // ─── RectTransforms ──────────────────────────────────
        {
            var rt = goMap[-2518585297228529315L].AddComponent<RectTransform>();
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
            var rt = goMap[104379545984303206L].AddComponent<RectTransform>();
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
            var rt = goMap[-7154772289168635054L].AddComponent<RectTransform>();
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
            var rt = goMap[1257098583744644910L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(28.900000f, 118.000000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-4308531903168783503L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-15.699989f, -56.999973f);
            rt.sizeDelta = new Vector2(1500.000000f, 850.000000f);
        }
        {
            var rt = goMap[3201555406317655730L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(1500.000000f, 850.000000f);
        }
        {
            var rt = goMap[-1855500468232027138L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(0.775000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(25.000000f, -115.000000f);
            rt.sizeDelta = new Vector2(939.000000f, 400.000000f);
        }
        {
            var rt = goMap[1239199600710376010L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-13.200012f, -78.350067f);
            rt.sizeDelta = new Vector2(-220.000000f, -93.500000f);
        }
        {
            var rt = goMap[7421852962709303208L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 0.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-15.000000f, 146.299988f);
            rt.sizeDelta = new Vector2(351.000000f, 145.000000f);
        }
        {
            var rt = goMap[3370808159112061783L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.372900f,0.927872f);
            rt.localScale = new Vector3(-1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.160000f);
            rt.anchoredPosition = new Vector2(-93.799988f, 113.000000f);
            rt.sizeDelta = new Vector2(200.000000f, 123.000000f);
        }
        {
            var rt = goMap[-5904553460043721347L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.084930f,0.996387f);
            rt.localScale = new Vector3(1.733600f, 1.733600f, 1.733600f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.160000f);
            rt.anchoredPosition = new Vector2(-81.500000f, -38.900002f);
            rt.sizeDelta = new Vector2(181.000000f, 103.000000f);
        }
        {
            var rt = goMap[-3908985587095182575L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(181.000000f, 103.000000f);
        }
        {
            var rt = goMap[1065031930445777269L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000007f,-0.000017f,-0.366414f,0.930452f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.160000f);
            rt.anchoredPosition = new Vector2(95.200020f, 113.000038f);
            rt.sizeDelta = new Vector2(200.000000f, 123.000000f);
        }
        {
            var rt = goMap[-3077108116113672842L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.084930f,0.996387f);
            rt.localScale = new Vector3(1.733600f, 1.733600f, 1.733600f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.000000f, 0.160000f);
            rt.anchoredPosition = new Vector2(-93.300003f, -36.799999f);
            rt.sizeDelta = new Vector2(181.000000f, 103.000000f);
        }
        {
            var rt = goMap[3807312000994324489L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(181.000000f, 103.000000f);
        }
        {
            var rt = goMap[-595574990527438525L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(0.761350f, 0.761350f, 0.761350f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.900049f, 139.999969f);
            rt.sizeDelta = new Vector2(256.768097f, 100.000000f);
        }
        {
            var rt = goMap[8086470748451449560L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-17.000000f, -290.683533f);
            rt.sizeDelta = new Vector2(600.000000f, 40.000000f);
        }
        {
            var rt = goMap[4341347639073241946L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 30.000000f);
        }
        {
            var rt = goMap[5894435831502766156L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(0.000000f, 0.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 30.000000f);
        }
        {
            var rt = goMap[5971442499714705005L].AddComponent<RectTransform>();
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
            var rt = goMap[-9154909754418658607L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-3.900000f, -89.099998f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[3397944686295458176L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(0.717160f, 0.717160f, 0.717160f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 10.600006f);
            rt.sizeDelta = new Vector2(241.000000f, 241.000000f);
        }
        {
            var rt = goMap[-4333447126800760289L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(0.690640f, 0.690640f, 0.690640f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.050000f);
            rt.anchoredPosition = new Vector2(0.000000f, -114.999985f);
            rt.sizeDelta = new Vector2(241.000000f, 112.000000f);
        }
        {
            var rt = goMap[6589323014343685819L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 28.799999f);
            rt.sizeDelta = new Vector2(83.000000f, 271.000000f);
        }
        {
            var rt = goMap[3200902547026773551L].AddComponent<RectTransform>();
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
            var rt = goMap[-1057650393998734860L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-3.900000f, -89.099998f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-7636052702942455461L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(0.717160f, 0.717160f, 0.717160f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 10.600006f);
            rt.sizeDelta = new Vector2(247.000000f, 247.000000f);
        }
        {
            var rt = goMap[-8010486652265458597L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(0.690640f, 0.690640f, 0.690640f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.050000f);
            rt.anchoredPosition = new Vector2(0.000000f, -114.999985f);
            rt.sizeDelta = new Vector2(286.000000f, 165.000000f);
        }
        {
            var rt = goMap[-754013320304844959L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 176.784943f);
            rt.sizeDelta = new Vector2(104.000000f, 280.000000f);
        }
        {
            var rt = goMap[4173952712471543209L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.413750f, 4.766250f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.000000f);
            rt.anchoredPosition = new Vector2(0.000000f, 130.800003f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-8187344880566564835L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.800000f, -110.600006f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-4376309279324246038L].AddComponent<RectTransform>();
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
            var rt = goMap[-3741271541233245385L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -90.400002f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[1643563398472142691L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 10.600006f);
            rt.sizeDelta = new Vector2(241.000000f, 241.000000f);
        }
        {
            var rt = goMap[5239597342874621459L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-95.400002f, -8.100000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[8881683248388082458L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.940000f, 0.130000f);
            rt.anchoredPosition = new Vector2(72.900002f, -98.040085f);
            rt.sizeDelta = new Vector2(122.000000f, 177.000000f);
        }
        {
            var rt = goMap[-5843494126916140922L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(-1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(96.699997f, -8.100000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[6979574298721462194L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.940000f, 0.130000f);
            rt.anchoredPosition = new Vector2(72.900002f, -98.040085f);
            rt.sizeDelta = new Vector2(122.000000f, 177.000000f);
        }
        {
            var rt = goMap[-1691355025540215320L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 15.199989f);
            rt.sizeDelta = new Vector2(110.000000f, 316.000000f);
        }
        {
            var rt = goMap[-5086726845345822536L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.413750f, 3.075000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.000000f);
            rt.anchoredPosition = new Vector2(0.000000f, -98.749329f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-7869303613310279535L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.800000f, -110.600006f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-6909566829229560869L].AddComponent<RectTransform>();
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
            var rt = goMap[7393998746021394992L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -90.400002f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[1923515459789414190L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 10.600006f);
            rt.sizeDelta = new Vector2(241.000000f, 241.000000f);
        }
        {
            var rt = goMap[5517870903635298610L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.008800f, 1.008800f, 1.008800f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.700000f, 11.800000f);
            rt.sizeDelta = new Vector2(286.000000f, 262.000000f);
        }
        {
            var rt = goMap[-8496141532092978373L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-95.400002f, -8.100000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[4728466518470497493L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.940000f, 0.130000f);
            rt.anchoredPosition = new Vector2(86.300003f, -74.799988f);
            rt.sizeDelta = new Vector2(118.000000f, 191.000000f);
        }
        {
            var rt = goMap[-5858491271074859662L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.940000f, 0.130000f);
            rt.anchoredPosition = new Vector2(80.000000f, -98.040085f);
            rt.sizeDelta = new Vector2(148.000000f, 261.000000f);
        }
        {
            var rt = goMap[7815325830266213874L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.940000f, 0.130000f);
            rt.anchoredPosition = new Vector2(101.300003f, -127.099998f);
            rt.sizeDelta = new Vector2(230.000000f, 338.000000f);
        }
        {
            var rt = goMap[-5956195214413076150L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(-1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(93.599998f, -8.100000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[1553358591688971301L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.940000f, 0.130000f);
            rt.anchoredPosition = new Vector2(86.300003f, -74.799988f);
            rt.sizeDelta = new Vector2(118.000000f, 191.000000f);
        }
        {
            var rt = goMap[2728170170037942635L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.940000f, 0.130000f);
            rt.anchoredPosition = new Vector2(80.000000f, -98.040085f);
            rt.sizeDelta = new Vector2(148.000000f, 261.000000f);
        }
        {
            var rt = goMap[-5508440501310254197L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.940000f, 0.130000f);
            rt.anchoredPosition = new Vector2(101.300003f, -127.099998f);
            rt.sizeDelta = new Vector2(230.000000f, 338.000000f);
        }
        {
            var rt = goMap[165091215433578647L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 15.199989f);
            rt.sizeDelta = new Vector2(139.000000f, 336.000000f);
        }
        {
            var rt = goMap[2427226106854177707L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.499999f, 7.099992f);
            rt.sizeDelta = new Vector2(185.000000f, 386.000000f);
        }
        {
            var rt = goMap[-2222031366920804876L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.413750f, 3.075000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.000000f);
            rt.anchoredPosition = new Vector2(0.000000f, -98.749329f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[7982828906448102121L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.800000f, -110.600006f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-8411118445094999840L].AddComponent<RectTransform>();
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
            var rt = goMap[828009690019412666L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -90.400002f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-3337237605245703439L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 10.600006f);
            rt.sizeDelta = new Vector2(284.000000f, 270.000000f);
        }
        {
            var rt = goMap[-3383023698317278288L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.700000f, 11.800000f);
            rt.sizeDelta = new Vector2(286.000000f, 262.000000f);
        }
        {
            var rt = goMap[-1919010543945213693L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-95.400002f, -8.100000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-8209174204535966L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 1.000000f);
            rt.anchoredPosition = new Vector2(48.299999f, -87.500000f);
            rt.sizeDelta = new Vector2(43.000000f, 43.000000f);
        }
        {
            var rt = goMap[-3912419564210154053L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.940000f, 0.130000f);
            rt.anchoredPosition = new Vector2(65.560036f, -87.400002f);
            rt.sizeDelta = new Vector2(139.000000f, 174.000000f);
        }
        {
            var rt = goMap[1216520523636512977L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.940000f, 0.130000f);
            rt.anchoredPosition = new Vector2(80.300003f, -80.199997f);
            rt.sizeDelta = new Vector2(183.000000f, 207.000000f);
        }
        {
            var rt = goMap[-9057051366944743214L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 15.199989f);
            rt.sizeDelta = new Vector2(161.000000f, 354.000000f);
        }
        {
            var rt = goMap[-2091524321207708872L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(219.000000f, 412.000000f);
        }
        {
            var rt = goMap[-2214381888053284411L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(219.000000f, 412.000000f);
        }
        {
            var rt = goMap[9221010084868225501L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(219.000000f, 412.000000f);
        }
        {
            var rt = goMap[-518910619049669807L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(-1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(95.599998f, -8.100000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[3940917523944053259L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 1.000000f);
            rt.anchoredPosition = new Vector2(48.299999f, -87.500000f);
            rt.sizeDelta = new Vector2(43.000000f, 43.000000f);
        }
        {
            var rt = goMap[6509065813367546125L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.940000f, 0.130000f);
            rt.anchoredPosition = new Vector2(65.560036f, -87.400002f);
            rt.sizeDelta = new Vector2(139.000000f, 174.000000f);
        }
        {
            var rt = goMap[2905309632800712019L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.940000f, 0.130000f);
            rt.anchoredPosition = new Vector2(80.300003f, -80.199997f);
            rt.sizeDelta = new Vector2(183.000000f, 207.000000f);
        }
        {
            var rt = goMap[3363004205918899107L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.413750f, 3.075000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.000000f);
            rt.anchoredPosition = new Vector2(0.000000f, -98.749329f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[8823624154489291986L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.800000f, -110.600006f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-503692321918305861L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-7.700000f, 125.199997f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-1984872683595409183L].AddComponent<RectTransform>();
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
            var rt = goMap[-5172019794038548753L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, -90.400002f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[3852119607289136592L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 10.600006f);
            rt.sizeDelta = new Vector2(270.000000f, 270.000000f);
        }
        {
            var rt = goMap[9001286143119974629L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.700000f, 11.800000f);
            rt.sizeDelta = new Vector2(286.000000f, 262.000000f);
        }
        {
            var rt = goMap[-1588164926691698L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-95.400002f, -8.100000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[8127015196328522004L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 1.000000f);
            rt.anchoredPosition = new Vector2(-22.000000f, -2.250000f);
            rt.sizeDelta = new Vector2(64.000000f, 128.000000f);
        }
        {
            var rt = goMap[-8394764112248088770L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(2.131400f, 2.131400f, 2.131400f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.940000f, 0.130000f);
            rt.anchoredPosition = new Vector2(81.400040f, -145.300064f);
            rt.sizeDelta = new Vector2(269.000000f, 283.000000f);
        }
        {
            var rt = goMap[-1807096733964713277L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.940000f, 0.130000f);
            rt.anchoredPosition = new Vector2(65.560036f, -98.040085f);
            rt.sizeDelta = new Vector2(149.000000f, 212.000000f);
        }
        {
            var rt = goMap[2645441379006853424L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.940000f, 0.130000f);
            rt.anchoredPosition = new Vector2(85.099998f, -80.000000f);
            rt.sizeDelta = new Vector2(207.000000f, 251.000000f);
        }
        {
            var rt = goMap[398478294506049208L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 1.000000f);
            rt.anchoredPosition = new Vector2(46.000015f, 149.050034f);
            rt.sizeDelta = new Vector2(64.000000f, 320.000000f);
        }
        {
            var rt = goMap[-7239819039330596213L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.910000f, 0.060000f);
            rt.anchoredPosition = new Vector2(77.500008f, -107.170052f);
            rt.sizeDelta = new Vector2(60.000000f, 103.000000f);
        }
        {
            var rt = goMap[8370569931883637921L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.910000f, 0.060000f);
            rt.anchoredPosition = new Vector2(44.900002f, -65.500000f);
            rt.sizeDelta = new Vector2(107.000000f, 144.000000f);
        }
        {
            var rt = goMap[-6921806350730023641L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(-1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(97.000000f, -8.100000f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-5316079061689600472L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 1.000000f);
            rt.anchoredPosition = new Vector2(-22.000000f, -2.250000f);
            rt.sizeDelta = new Vector2(64.000000f, 128.000000f);
        }
        {
            var rt = goMap[2785384296073530917L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(2.131400f, 2.131400f, 2.131400f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.940000f, 0.130000f);
            rt.anchoredPosition = new Vector2(81.500038f, -145.300064f);
            rt.sizeDelta = new Vector2(269.000000f, 283.000000f);
        }
        {
            var rt = goMap[4665589517270851057L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.940000f, 0.130000f);
            rt.anchoredPosition = new Vector2(65.560036f, -98.040085f);
            rt.sizeDelta = new Vector2(149.000000f, 212.000000f);
        }
        {
            var rt = goMap[-2421514388694109441L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.940000f, 0.130000f);
            rt.anchoredPosition = new Vector2(86.000000f, -80.000000f);
            rt.sizeDelta = new Vector2(207.000000f, 251.000000f);
        }
        {
            var rt = goMap[-5167416274920966693L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 1.000000f);
            rt.anchoredPosition = new Vector2(46.000015f, 149.050034f);
            rt.sizeDelta = new Vector2(64.000000f, 320.000000f);
        }
        {
            var rt = goMap[-1621265364486047390L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.910000f, 0.060000f);
            rt.anchoredPosition = new Vector2(77.500008f, -107.170052f);
            rt.sizeDelta = new Vector2(60.000000f, 103.000000f);
        }
        {
            var rt = goMap[3270199387603381779L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.910000f, 0.060000f);
            rt.anchoredPosition = new Vector2(44.000000f, -65.500000f);
            rt.sizeDelta = new Vector2(107.000000f, 144.000000f);
        }
        {
            var rt = goMap[5178901161516173443L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 15.199989f);
            rt.sizeDelta = new Vector2(181.000000f, 356.000000f);
        }
        {
            var rt = goMap[6059525678364630173L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 34.000000f);
            rt.sizeDelta = new Vector2(176.000000f, 404.000000f);
        }
        {
            var rt = goMap[8556775588466680104L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 34.000000f);
            rt.sizeDelta = new Vector2(176.000000f, 404.000000f);
        }
        {
            var rt = goMap[7742423698143694482L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.413750f, 3.075000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.000000f);
            rt.anchoredPosition = new Vector2(0.000000f, -98.749329f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-7566578207933672238L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-0.800000f, -110.600006f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }
        {
            var rt = goMap[-761546630335259407L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.500000f, 0.500000f);
            rt.anchorMax = new Vector2(0.500000f, 0.500000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(-7.700000f, 125.199997f);
            rt.sizeDelta = new Vector2(100.000000f, 100.000000f);
        }

        // ─── Components ──────────────────────────────────────
        { var c = goMap[-2518585297228529315L].AddComponent<Canvas>();
           c.renderMode = (RenderMode)1;
           c.overrideSorting = false;
           c.sortingOrder = 0;
           c.sortingLayerID = unchecked((int)194136777);
           c.planeDistance = 8.660000f;
           c.pixelPerfect = false;
           c.additionalShaderChannels = (AdditionalCanvasShaderChannels)0;
           c.enabled = true;
        }
        { var c = goMap[-2518585297228529315L].AddComponent<CanvasScaler>();
           c.uiScaleMode = (CanvasScaler.ScaleMode)1;
           c.referenceResolution = new Vector2(1280.000000f, 720.000000f);
           c.screenMatchMode = (CanvasScaler.ScreenMatchMode)1;
           c.matchWidthOrHeight = 0.000000f;
           c.referencePixelsPerUnit = 100.000000f;
        }
        { var c = goMap[-2518585297228529315L].AddComponent<GraphicRaycaster>();
           c.ignoreReversedGraphics = true;
        }
        { var c = goMap[-2518585297228529315L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.000000f, 0.000000f, 0.447059f);
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
        { var c = goMap[104379545984303206L].AddComponent<Canvas>();
           c.renderMode = (RenderMode)2;
           c.overrideSorting = true;
           c.sortingOrder = 5;
           c.sortingLayerID = unchecked((int)194136777);
           c.planeDistance = 100.000000f;
           c.pixelPerfect = false;
           c.additionalShaderChannels = (AdditionalCanvasShaderChannels)0;
           c.enabled = true;
        }
        { var c = goMap[104379545984303206L].AddComponent<GraphicRaycaster>();
           c.ignoreReversedGraphics = true;
        }
        { var c = goMap[-4308531903168783503L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("UIRankPromotion_Effect"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[3201555406317655730L].AddComponent<Image>();
           c.color = new Color(0.000000f, 0.000000f, 0.000000f, 0.431373f);
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
        { var c = goMap[3201555406317655730L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[-1855500468232027138L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_BG");
        }
        { var c = goMap[1239199600710376010L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[1239199600710376010L].AddComponent<Image>();
           c.color = new Color(1f,1f,1f,0f);
           c.raycastTarget = false;
           c.maskable = true;
           c.enabled = true;
        }
        { var c = goMap[7421852962709303208L].AddComponent<Image>();
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
           c.sprite = LookupSprite("img_HuoYanSha");
        }
        { var c = goMap[3370808159112061783L].AddComponent<Image>();
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
           c.sprite = LookupSprite("RefineChiBang01");
        }
        { var c = goMap[-5904553460043721347L].AddComponent<Image>();
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
        { var c = goMap[-3908985587095182575L].AddComponent<Image>();
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
        { var c = goMap[1065031930445777269L].AddComponent<Image>();
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
           c.sprite = LookupSprite("RefineChiBang01");
        }
        { var c = goMap[-3077108116113672842L].AddComponent<Image>();
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
        { var c = goMap[3807312000994324489L].AddComponent<Image>();
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
        { var c = goMap[-595574990527438525L].AddComponent<Text>();
           c.text = "45381";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 46;
           c.fontStyle = FontStyle.Bold;
           c.alignment = TextAnchor.MiddleCenter;
           c.alignByGeometry = false;
           c.supportRichText = true;
           c.horizontalOverflow = HorizontalWrapMode.Wrap;
           c.verticalOverflow = VerticalWrapMode.Truncate;
           c.lineSpacing = 1.000000f;
           c.resizeTextForBestFit = false;
           c.resizeTextMinSize = 0;
           c.resizeTextMaxSize = 46;
           c.raycastTarget = true;
           c.enabled = true;
           c.font = LookupFont("common_zh");
        }
        { var g = goMap[-595574990527438525L].GetComponent<Graphic>();
           if (g != null) g.color = new Color(1.000000f, 1.000000f, 0.984314f, 1.000000f); }
        { var c = goMap[-595574990527438525L].AddComponent<Outline>();
           c.effectColor = new Color(0.735849f, 0.177020f, 0.212389f, 1.000000f);
           c.effectDistance = new Vector2(1.000000f, -1.000000f);
           c.useGraphicAlpha = true;
           c.enabled = true;
        }
        { var c = goMap[-595574990527438525L].AddComponent<CanvasGroup>();
           c.alpha = 1.000000f;
           c.interactable = true;
           c.blocksRaycasts = true;
           c.ignoreParentGroups = false;
        }
        { var c = goMap[8086470748451449560L].AddComponent<HorizontalLayoutGroup>();
           c.padding = new RectOffset(0,0,0,0);
           c.spacing = 8.000000f;
           c.childAlignment = (TextAnchor)4;
           c.childForceExpandWidth = false;
           c.childForceExpandHeight = false;
           c.childControlWidth = true;
           c.childControlHeight = false;
           c.reverseArrangement = false;
        }
        { var c = goMap[8086470748451449560L].AddComponent<CanvasGroup>();
           c.alpha = 0.000000f;
           c.interactable = true;
           c.blocksRaycasts = true;
           c.ignoreParentGroups = false;
        }
        { var c = goMap[4341347639073241946L].AddComponent<Text>();
           c.text = "45383";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 22;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.UpperLeft;
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
        { var c = goMap[5894435831502766156L].AddComponent<Text>();
           c.text = "45382";
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.fontSize = 22;
           c.fontStyle = FontStyle.Normal;
           c.alignment = TextAnchor.UpperLeft;
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
        { var c = goMap[5971442499714705005L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("01"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[3397944686295458176L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("01-Di");
        }
        { var c = goMap[-4333447126800760289L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("01-Chi");
        }
        { var c = goMap[6589323014343685819L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("01-Jian");
        }
        { var c = goMap[3200902547026773551L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("02"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[-7636052702942455461L].AddComponent<Image>();
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
           c.sprite = LookupSprite("02-Di");
        }
        { var c = goMap[-8010486652265458597L].AddComponent<Image>();
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
           c.sprite = LookupSprite("02-Chi");
        }
        { var c = goMap[-754013320304844959L].AddComponent<Image>();
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
           c.sprite = LookupSprite("02-Jian");
        }
        { var c = goMap[4173952712471543209L].AddComponent<Image>();
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
        { var c = goMap[-4376309279324246038L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("03"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[1643563398472142691L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("03-Di");
        }
        { var c = goMap[5239597342874621459L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
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
        { var c = goMap[8881683248388082458L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("03-chi");
        }
        { var c = goMap[-5843494126916140922L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
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
        { var c = goMap[6979574298721462194L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("03-chi");
        }
        { var c = goMap[-1691355025540215320L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("03-jian");
        }
        { var c = goMap[-5086726845345822536L].AddComponent<Image>();
           c.color = new Color(1.000000f, 0.920064f, 0.438679f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-6909566829229560869L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("04"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[1923515459789414190L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("04_Di");
        }
        { var c = goMap[5517870903635298610L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-8496141532092978373L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
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
        { var c = goMap[4728466518470497493L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("04-Red");
        }
        { var c = goMap[-5858491271074859662L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("04_JinChi");
        }
        { var c = goMap[7815325830266213874L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-5956195214413076150L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
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
        { var c = goMap[1553358591688971301L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("04-Red");
        }
        { var c = goMap[2728170170037942635L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("04_JinChi");
        }
        { var c = goMap[-5508440501310254197L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[165091215433578647L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("04_Jian");
        }
        { var c = goMap[2427226106854177707L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-2222031366920804876L].AddComponent<Image>();
           c.color = new Color(1.000000f, 0.920064f, 0.438679f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-8411118445094999840L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("05"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[-3337237605245703439L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("05-Di");
        }
        { var c = goMap[-3383023698317278288L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-1919010543945213693L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
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
        { var c = goMap[-8209174204535966L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("05-PiaoDai");
        }
        { var c = goMap[-3912419564210154053L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("05-Chi");
        }
        { var c = goMap[1216520523636512977L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-9057051366944743214L].AddComponent<Image>();
           c.color = new Color(0.150943f, 0.150943f, 0.150943f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("05-Jian");
        }
        { var c = goMap[-2091524321207708872L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-2214381888053284411L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[9221010084868225501L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-518910619049669807L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
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
        { var c = goMap[3940917523944053259L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("05-PiaoDai");
        }
        { var c = goMap[6509065813367546125L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("05-Chi");
        }
        { var c = goMap[2905309632800712019L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[3363004205918899107L].AddComponent<Image>();
           c.color = new Color(1.000000f, 0.920064f, 0.438679f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-1984872683595409183L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("06"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
        }
        { var c = goMap[3852119607289136592L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("06-Di");
        }
        { var c = goMap[9001286143119974629L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-1588164926691698L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
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
        { var c = goMap[8127015196328522004L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-8394764112248088770L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-1807096733964713277L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[2645441379006853424L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[398478294506049208L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-7239819039330596213L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("06-SJinChi");
        }
        { var c = goMap[8370569931883637921L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("06-SJinChi");
        }
        { var c = goMap[-6921806350730023641L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
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
        { var c = goMap[-5316079061689600472L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[2785384296073530917L].AddComponent<Image>();
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
        { var c = goMap[4665589517270851057L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-2421514388694109441L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-5167416274920966693L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[-1621265364486047390L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("06-SJinChi");
        }
        { var c = goMap[3270199387603381779L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("06-SJinChi");
        }
        { var c = goMap[5178901161516173443L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
           c.maskable = true;
           c.type = Image.Type.Simple;
           c.preserveAspect = false;
           c.fillCenter = true;
           c.fillAmount = 1.000000f;
           c.fillClockwise = true;
           c.fillMethod = Image.FillMethod.Radial360;
           c.fillOrigin = 0;
           c.enabled = true;
           c.sprite = LookupSprite("06-Jian");
        }
        { var c = goMap[6059525678364630173L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[8556775588466680104L].AddComponent<Image>();
           c.color = new Color(1.000000f, 1.000000f, 1.000000f, 1.000000f);
           c.raycastTarget = true;
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
        { var c = goMap[7742423698143694482L].AddComponent<Image>();
           c.color = new Color(1.000000f, 0.920064f, 0.438679f, 1.000000f);
           c.raycastTarget = true;
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
        var rootGO = goMap[-2518585297228529315L];
        string path = "Assets/Prefabs/Imported/UIRankPromotion.prefab";
        PrefabUtility.SaveAsPrefabAsset(rootGO, path);
        Object.DestroyImmediate(rootGO);
        Debug.Log("[Import_res_p_541] Saved " + path);
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