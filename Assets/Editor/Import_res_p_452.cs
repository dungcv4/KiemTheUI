// AUTO-GENERATED from res_p_452.ab — DO NOT EDIT MANUALLY.
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;
using System.Collections.Generic;
using KTO.Game;  // UIJoyStick and other ported KTO scripts

public class Import_res_p_452
{
    [MenuItem("KTO/Import/res_p_452")]
    public static void Build()
    {
        Debug.Log("[Import_res_p_452] Building UIGiftEffect_NewYear...");

        // ─── Create all GameObjects ───────────────────────────
        var goMap = new Dictionary<long, GameObject>();
        var _toggleGroupByMbPid = new Dictionary<long, ToggleGroup>();
        var _toggleGroupLinks = new List<System.Tuple<Toggle,long>>();
        { var go = new GameObject("UIGiftEffect_NewYear"); go.SetActive(true); goMap[8284263909460438706L] = go; }
        { var go = new GameObject("ClickEmptyToClose"); go.SetActive(true); goMap[-5453101499679509516L] = go; }
        { var go = new GameObject("YanHua_NewYear"); go.SetActive(true); goMap[204841078615886232L] = go; }
        { var go = new GameObject("P01_Purple01"); go.SetActive(true); goMap[-8760246614709858165L] = go; }
        { var go = new GameObject("P1"); go.SetActive(true); goMap[-5341454154222241197L] = go; }
        { var go = new GameObject("P2"); go.SetActive(true); goMap[5725924368855833592L] = go; }
        { var go = new GameObject("P3"); go.SetActive(true); goMap[6464611313819441066L] = go; }
        { var go = new GameObject("P4"); go.SetActive(true); goMap[-3742129968298110456L] = go; }
        { var go = new GameObject("P03_Yellow01"); go.SetActive(true); goMap[-9080686754708820130L] = go; }
        { var go = new GameObject("P1"); go.SetActive(true); goMap[9169160241249326925L] = go; }
        { var go = new GameObject("P3"); go.SetActive(true); goMap[3778354656479762697L] = go; }
        { var go = new GameObject("P4"); go.SetActive(true); goMap[-3399536676715642305L] = go; }
        { var go = new GameObject("P04_Green01"); go.SetActive(true); goMap[5717039830162562778L] = go; }
        { var go = new GameObject("P1"); go.SetActive(true); goMap[-6796368055369290476L] = go; }
        { var go = new GameObject("P3"); go.SetActive(true); goMap[-9187102074440044759L] = go; }
        { var go = new GameObject("P4"); go.SetActive(true); goMap[-6000969576533336437L] = go; }
        { var go = new GameObject("P01_Blue01"); go.SetActive(true); goMap[8077711622696266617L] = go; }
        { var go = new GameObject("P1"); go.SetActive(true); goMap[3231626095859498567L] = go; }
        { var go = new GameObject("P2"); go.SetActive(true); goMap[7771674829635124696L] = go; }
        { var go = new GameObject("P3"); go.SetActive(true); goMap[-6407601094427139743L] = go; }
        { var go = new GameObject("P4"); go.SetActive(true); goMap[-4016292016931653658L] = go; }
        { var go = new GameObject("P03_Pink01"); go.SetActive(true); goMap[-2132845468270897329L] = go; }
        { var go = new GameObject("P1"); go.SetActive(true); goMap[1217806873172257713L] = go; }
        { var go = new GameObject("P3"); go.SetActive(true); goMap[3609715171086643891L] = go; }
        { var go = new GameObject("P4"); go.SetActive(true); goMap[4012538442329036892L] = go; }
        { var go = new GameObject("P04_Green02"); go.SetActive(true); goMap[1651354089457002539L] = go; }
        { var go = new GameObject("P1"); go.SetActive(true); goMap[-1841018879467202400L] = go; }
        { var go = new GameObject("P3"); go.SetActive(true); goMap[8851281145448096388L] = go; }
        { var go = new GameObject("P4"); go.SetActive(true); goMap[8302430657334231838L] = go; }
        { var go = new GameObject("P01_Purple02"); go.SetActive(true); goMap[-7426558875926592235L] = go; }
        { var go = new GameObject("P1"); go.SetActive(true); goMap[-3853647136931924224L] = go; }
        { var go = new GameObject("P2"); go.SetActive(true); goMap[8234955296368640933L] = go; }
        { var go = new GameObject("P3"); go.SetActive(true); goMap[5551042731777375628L] = go; }
        { var go = new GameObject("P4"); go.SetActive(true); goMap[6996202405952189116L] = go; }
        { var go = new GameObject("P03_Pink02"); go.SetActive(true); goMap[-3519630928517583287L] = go; }
        { var go = new GameObject("P1"); go.SetActive(true); goMap[-6115754769134396450L] = go; }
        { var go = new GameObject("P3"); go.SetActive(true); goMap[-5357857416684874429L] = go; }
        { var go = new GameObject("P4"); go.SetActive(true); goMap[-6226344268105403669L] = go; }
        { var go = new GameObject("P01_Blue02"); go.SetActive(true); goMap[4086781896414465117L] = go; }
        { var go = new GameObject("P1"); go.SetActive(true); goMap[-85145071455971089L] = go; }
        { var go = new GameObject("P2"); go.SetActive(true); goMap[-549190900517421859L] = go; }
        { var go = new GameObject("P3"); go.SetActive(true); goMap[809416659140025567L] = go; }
        { var go = new GameObject("P4"); go.SetActive(true); goMap[561676601548200981L] = go; }
        { var go = new GameObject("CaiDai_Effect"); go.SetActive(true); goMap[1244244646584529719L] = go; }
        { var go = new GameObject("HongBao"); go.SetActive(true); goMap[-4430045153059426574L] = go; }
        { var go = new GameObject("P03_Yellow02"); go.SetActive(true); goMap[-1586019925685353208L] = go; }
        { var go = new GameObject("P1"); go.SetActive(true); goMap[4814056800706494955L] = go; }
        { var go = new GameObject("P3"); go.SetActive(true); goMap[1674240049639346162L] = go; }
        { var go = new GameObject("P4"); go.SetActive(true); goMap[-5195060559797000028L] = go; }
        { var go = new GameObject("P04_Green03"); go.SetActive(true); goMap[1968454688033797930L] = go; }
        { var go = new GameObject("P1"); go.SetActive(true); goMap[-1477183769552937718L] = go; }
        { var go = new GameObject("P3"); go.SetActive(true); goMap[-5883489199379567981L] = go; }
        { var go = new GameObject("P4"); go.SetActive(true); goMap[-1624026365755721055L] = go; }
        { var go = new GameObject("P01_Purple03"); go.SetActive(true); goMap[-327482372660538068L] = go; }
        { var go = new GameObject("P1"); go.SetActive(true); goMap[3398468444096230076L] = go; }
        { var go = new GameObject("P2"); go.SetActive(true); goMap[-5727438080813935253L] = go; }
        { var go = new GameObject("P3"); go.SetActive(true); goMap[-6064470266239301026L] = go; }
        { var go = new GameObject("P4"); go.SetActive(true); goMap[-705206411557654927L] = go; }
        { var go = new GameObject("P01_Blue04"); go.SetActive(true); goMap[-6683594653817135375L] = go; }
        { var go = new GameObject("P1"); go.SetActive(true); goMap[3356096395301758038L] = go; }
        { var go = new GameObject("P2"); go.SetActive(true); goMap[4435818819652390676L] = go; }
        { var go = new GameObject("P3"); go.SetActive(true); goMap[4951320026771995235L] = go; }
        { var go = new GameObject("P4"); go.SetActive(true); goMap[5539645228067462258L] = go; }
        { var go = new GameObject("P04_Green04"); go.SetActive(true); goMap[-3400379269650788366L] = go; }
        { var go = new GameObject("P1"); go.SetActive(true); goMap[974653504112527920L] = go; }
        { var go = new GameObject("P3"); go.SetActive(true); goMap[-5628358635475858332L] = go; }
        { var go = new GameObject("P4"); go.SetActive(true); goMap[3667130306422750403L] = go; }
        { var go = new GameObject("P01_Purple04"); go.SetActive(true); goMap[-8829694936221071090L] = go; }
        { var go = new GameObject("P1"); go.SetActive(true); goMap[-499365141017163703L] = go; }
        { var go = new GameObject("P2"); go.SetActive(true); goMap[3794937189297827105L] = go; }
        { var go = new GameObject("P3"); go.SetActive(true); goMap[-4330743892075132876L] = go; }
        { var go = new GameObject("P4"); go.SetActive(true); goMap[7473465628662342099L] = go; }
        { var go = new GameObject("P03_Pink04"); go.SetActive(true); goMap[269545052687013587L] = go; }
        { var go = new GameObject("P1"); go.SetActive(true); goMap[-389457401955294622L] = go; }
        { var go = new GameObject("P3"); go.SetActive(true); goMap[8245702689524733349L] = go; }
        { var go = new GameObject("P4"); go.SetActive(true); goMap[2273137357192245293L] = go; }
        { var go = new GameObject("P04_Green05"); go.SetActive(true); goMap[-4778606534604703988L] = go; }
        { var go = new GameObject("P1"); go.SetActive(true); goMap[-8638069433273665058L] = go; }
        { var go = new GameObject("P3"); go.SetActive(true); goMap[-8936509539238488140L] = go; }
        { var go = new GameObject("P4"); go.SetActive(true); goMap[2963786717795373653L] = go; }
        { var go = new GameObject("P01_Purple05"); go.SetActive(true); goMap[-4172896652153438354L] = go; }
        { var go = new GameObject("P1"); go.SetActive(true); goMap[-1027304619660128034L] = go; }
        { var go = new GameObject("P2"); go.SetActive(true); goMap[-6793717613384693776L] = go; }
        { var go = new GameObject("P3"); go.SetActive(true); goMap[-3111169662470125621L] = go; }
        { var go = new GameObject("P4"); go.SetActive(true); goMap[-158924358685338040L] = go; }
        { var go = new GameObject("P03_Pink05"); go.SetActive(true); goMap[-2275552929744847646L] = go; }
        { var go = new GameObject("P1"); go.SetActive(true); goMap[-6568808813302316229L] = go; }
        { var go = new GameObject("P3"); go.SetActive(true); goMap[-176836902877976889L] = go; }
        { var go = new GameObject("P4"); go.SetActive(true); goMap[-6446023133806537361L] = go; }
        { var go = new GameObject("P01_Blue05"); go.SetActive(true); goMap[-426501977411870357L] = go; }
        { var go = new GameObject("P1"); go.SetActive(true); goMap[1866879049864893029L] = go; }
        { var go = new GameObject("P2"); go.SetActive(true); goMap[-3153766936918088427L] = go; }
        { var go = new GameObject("P3"); go.SetActive(true); goMap[7949557040393002743L] = go; }
        { var go = new GameObject("P4"); go.SetActive(true); goMap[7806864461607302440L] = go; }
        { var go = new GameObject("P03_Yellow04"); go.SetActive(true); goMap[-2736550920493833585L] = go; }
        { var go = new GameObject("P1"); go.SetActive(true); goMap[5656286498261358568L] = go; }
        { var go = new GameObject("P3"); go.SetActive(true); goMap[-8296571941759046605L] = go; }
        { var go = new GameObject("P4"); go.SetActive(true); goMap[-6967963315680141714L] = go; }

        // ─── Parent links ─────────────────────────────────────
        goMap[-5453101499679509516L].transform.SetParent(goMap[8284263909460438706L].transform, false);
        goMap[204841078615886232L].transform.SetParent(goMap[8284263909460438706L].transform, false);
        goMap[-8760246614709858165L].transform.SetParent(goMap[204841078615886232L].transform, false);
        goMap[-5341454154222241197L].transform.SetParent(goMap[-8760246614709858165L].transform, false);
        goMap[5725924368855833592L].transform.SetParent(goMap[-8760246614709858165L].transform, false);
        goMap[6464611313819441066L].transform.SetParent(goMap[-8760246614709858165L].transform, false);
        goMap[-3742129968298110456L].transform.SetParent(goMap[-8760246614709858165L].transform, false);
        goMap[-9080686754708820130L].transform.SetParent(goMap[204841078615886232L].transform, false);
        goMap[9169160241249326925L].transform.SetParent(goMap[-9080686754708820130L].transform, false);
        goMap[3778354656479762697L].transform.SetParent(goMap[-9080686754708820130L].transform, false);
        goMap[-3399536676715642305L].transform.SetParent(goMap[-9080686754708820130L].transform, false);
        goMap[5717039830162562778L].transform.SetParent(goMap[204841078615886232L].transform, false);
        goMap[-6796368055369290476L].transform.SetParent(goMap[5717039830162562778L].transform, false);
        goMap[-9187102074440044759L].transform.SetParent(goMap[5717039830162562778L].transform, false);
        goMap[-6000969576533336437L].transform.SetParent(goMap[5717039830162562778L].transform, false);
        goMap[8077711622696266617L].transform.SetParent(goMap[204841078615886232L].transform, false);
        goMap[3231626095859498567L].transform.SetParent(goMap[8077711622696266617L].transform, false);
        goMap[7771674829635124696L].transform.SetParent(goMap[8077711622696266617L].transform, false);
        goMap[-6407601094427139743L].transform.SetParent(goMap[8077711622696266617L].transform, false);
        goMap[-4016292016931653658L].transform.SetParent(goMap[8077711622696266617L].transform, false);
        goMap[-2132845468270897329L].transform.SetParent(goMap[204841078615886232L].transform, false);
        goMap[1217806873172257713L].transform.SetParent(goMap[-2132845468270897329L].transform, false);
        goMap[3609715171086643891L].transform.SetParent(goMap[-2132845468270897329L].transform, false);
        goMap[4012538442329036892L].transform.SetParent(goMap[-2132845468270897329L].transform, false);
        goMap[1651354089457002539L].transform.SetParent(goMap[204841078615886232L].transform, false);
        goMap[-1841018879467202400L].transform.SetParent(goMap[1651354089457002539L].transform, false);
        goMap[8851281145448096388L].transform.SetParent(goMap[1651354089457002539L].transform, false);
        goMap[8302430657334231838L].transform.SetParent(goMap[1651354089457002539L].transform, false);
        goMap[-7426558875926592235L].transform.SetParent(goMap[204841078615886232L].transform, false);
        goMap[-3853647136931924224L].transform.SetParent(goMap[-7426558875926592235L].transform, false);
        goMap[8234955296368640933L].transform.SetParent(goMap[-7426558875926592235L].transform, false);
        goMap[5551042731777375628L].transform.SetParent(goMap[-7426558875926592235L].transform, false);
        goMap[6996202405952189116L].transform.SetParent(goMap[-7426558875926592235L].transform, false);
        goMap[-3519630928517583287L].transform.SetParent(goMap[204841078615886232L].transform, false);
        goMap[-6115754769134396450L].transform.SetParent(goMap[-3519630928517583287L].transform, false);
        goMap[-5357857416684874429L].transform.SetParent(goMap[-3519630928517583287L].transform, false);
        goMap[-6226344268105403669L].transform.SetParent(goMap[-3519630928517583287L].transform, false);
        goMap[4086781896414465117L].transform.SetParent(goMap[204841078615886232L].transform, false);
        goMap[-85145071455971089L].transform.SetParent(goMap[4086781896414465117L].transform, false);
        goMap[-549190900517421859L].transform.SetParent(goMap[4086781896414465117L].transform, false);
        goMap[809416659140025567L].transform.SetParent(goMap[4086781896414465117L].transform, false);
        goMap[561676601548200981L].transform.SetParent(goMap[4086781896414465117L].transform, false);
        goMap[1244244646584529719L].transform.SetParent(goMap[204841078615886232L].transform, false);
        goMap[-4430045153059426574L].transform.SetParent(goMap[1244244646584529719L].transform, false);
        goMap[-1586019925685353208L].transform.SetParent(goMap[204841078615886232L].transform, false);
        goMap[4814056800706494955L].transform.SetParent(goMap[-1586019925685353208L].transform, false);
        goMap[1674240049639346162L].transform.SetParent(goMap[-1586019925685353208L].transform, false);
        goMap[-5195060559797000028L].transform.SetParent(goMap[-1586019925685353208L].transform, false);
        goMap[1968454688033797930L].transform.SetParent(goMap[204841078615886232L].transform, false);
        goMap[-1477183769552937718L].transform.SetParent(goMap[1968454688033797930L].transform, false);
        goMap[-5883489199379567981L].transform.SetParent(goMap[1968454688033797930L].transform, false);
        goMap[-1624026365755721055L].transform.SetParent(goMap[1968454688033797930L].transform, false);
        goMap[-327482372660538068L].transform.SetParent(goMap[204841078615886232L].transform, false);
        goMap[3398468444096230076L].transform.SetParent(goMap[-327482372660538068L].transform, false);
        goMap[-5727438080813935253L].transform.SetParent(goMap[-327482372660538068L].transform, false);
        goMap[-6064470266239301026L].transform.SetParent(goMap[-327482372660538068L].transform, false);
        goMap[-705206411557654927L].transform.SetParent(goMap[-327482372660538068L].transform, false);
        goMap[-6683594653817135375L].transform.SetParent(goMap[204841078615886232L].transform, false);
        goMap[3356096395301758038L].transform.SetParent(goMap[-6683594653817135375L].transform, false);
        goMap[4435818819652390676L].transform.SetParent(goMap[-6683594653817135375L].transform, false);
        goMap[4951320026771995235L].transform.SetParent(goMap[-6683594653817135375L].transform, false);
        goMap[5539645228067462258L].transform.SetParent(goMap[-6683594653817135375L].transform, false);
        goMap[-3400379269650788366L].transform.SetParent(goMap[204841078615886232L].transform, false);
        goMap[974653504112527920L].transform.SetParent(goMap[-3400379269650788366L].transform, false);
        goMap[-5628358635475858332L].transform.SetParent(goMap[-3400379269650788366L].transform, false);
        goMap[3667130306422750403L].transform.SetParent(goMap[-3400379269650788366L].transform, false);
        goMap[-8829694936221071090L].transform.SetParent(goMap[204841078615886232L].transform, false);
        goMap[-499365141017163703L].transform.SetParent(goMap[-8829694936221071090L].transform, false);
        goMap[3794937189297827105L].transform.SetParent(goMap[-8829694936221071090L].transform, false);
        goMap[-4330743892075132876L].transform.SetParent(goMap[-8829694936221071090L].transform, false);
        goMap[7473465628662342099L].transform.SetParent(goMap[-8829694936221071090L].transform, false);
        goMap[269545052687013587L].transform.SetParent(goMap[204841078615886232L].transform, false);
        goMap[-389457401955294622L].transform.SetParent(goMap[269545052687013587L].transform, false);
        goMap[8245702689524733349L].transform.SetParent(goMap[269545052687013587L].transform, false);
        goMap[2273137357192245293L].transform.SetParent(goMap[269545052687013587L].transform, false);
        goMap[-4778606534604703988L].transform.SetParent(goMap[204841078615886232L].transform, false);
        goMap[-8638069433273665058L].transform.SetParent(goMap[-4778606534604703988L].transform, false);
        goMap[-8936509539238488140L].transform.SetParent(goMap[-4778606534604703988L].transform, false);
        goMap[2963786717795373653L].transform.SetParent(goMap[-4778606534604703988L].transform, false);
        goMap[-4172896652153438354L].transform.SetParent(goMap[204841078615886232L].transform, false);
        goMap[-1027304619660128034L].transform.SetParent(goMap[-4172896652153438354L].transform, false);
        goMap[-6793717613384693776L].transform.SetParent(goMap[-4172896652153438354L].transform, false);
        goMap[-3111169662470125621L].transform.SetParent(goMap[-4172896652153438354L].transform, false);
        goMap[-158924358685338040L].transform.SetParent(goMap[-4172896652153438354L].transform, false);
        goMap[-2275552929744847646L].transform.SetParent(goMap[204841078615886232L].transform, false);
        goMap[-6568808813302316229L].transform.SetParent(goMap[-2275552929744847646L].transform, false);
        goMap[-176836902877976889L].transform.SetParent(goMap[-2275552929744847646L].transform, false);
        goMap[-6446023133806537361L].transform.SetParent(goMap[-2275552929744847646L].transform, false);
        goMap[-426501977411870357L].transform.SetParent(goMap[204841078615886232L].transform, false);
        goMap[1866879049864893029L].transform.SetParent(goMap[-426501977411870357L].transform, false);
        goMap[-3153766936918088427L].transform.SetParent(goMap[-426501977411870357L].transform, false);
        goMap[7949557040393002743L].transform.SetParent(goMap[-426501977411870357L].transform, false);
        goMap[7806864461607302440L].transform.SetParent(goMap[-426501977411870357L].transform, false);
        goMap[-2736550920493833585L].transform.SetParent(goMap[204841078615886232L].transform, false);
        goMap[5656286498261358568L].transform.SetParent(goMap[-2736550920493833585L].transform, false);
        goMap[-8296571941759046605L].transform.SetParent(goMap[-2736550920493833585L].transform, false);
        goMap[-6967963315680141714L].transform.SetParent(goMap[-2736550920493833585L].transform, false);

        // ─── RectTransforms ──────────────────────────────────
        {
            var rt = goMap[8284263909460438706L].AddComponent<RectTransform>();
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
            var rt = goMap[-5453101499679509516L].AddComponent<RectTransform>();
            rt.localPosition = new Vector3(0.000000f, 0.000000f, 0.000000f);
            rt.localRotation = new Quaternion(-0.000000f,-0.000000f,-0.000000f,1.000000f);
            rt.localScale = new Vector3(1.000000f, 1.000000f, 1.000000f);
            rt.anchorMin = new Vector2(0.000000f, 0.000000f);
            rt.anchorMax = new Vector2(1.000000f, 1.000000f);
            rt.pivot = new Vector2(0.500000f, 0.500000f);
            rt.anchoredPosition = new Vector2(0.000000f, 0.000000f);
            rt.sizeDelta = new Vector2(0.000000f, 0.000000f);
        }

        // ─── Components ──────────────────────────────────────
        { var c = goMap[8284263909460438706L].AddComponent<Canvas>();
           c.renderMode = (RenderMode)1;
           c.overrideSorting = true;
           c.sortingOrder = 0;
           c.sortingLayerID = unchecked((int)194136777);
           c.planeDistance = 100.000000f;
           c.pixelPerfect = false;
           c.additionalShaderChannels = (AdditionalCanvasShaderChannels)0;
           c.enabled = true;
        }
        { var c = goMap[8284263909460438706L].AddComponent<GraphicRaycaster>();
           c.ignoreReversedGraphics = true;
        }
        { var c = goMap[8284263909460438706L].AddComponent<CanvasScaler>();
           c.uiScaleMode = (CanvasScaler.ScaleMode)1;
           c.referenceResolution = new Vector2(1280.000000f, 720.000000f);
           c.screenMatchMode = (CanvasScaler.ScreenMatchMode)1;
           c.matchWidthOrHeight = 0.000000f;
           c.referencePixelsPerUnit = 100.000000f;
        }
        { var c = goMap[-5453101499679509516L].AddComponent<Image>();
           c.color = new Color(1f,1f,1f,0f);
           c.raycastTarget = true;
           c.maskable = true;
           c.enabled = true;
        }
        { var c = goMap[-5453101499679509516L].AddComponent<Button>();
           c.enabled = true;
        }
        { var c = goMap[204841078615886232L].AddComponent<Animator>();
           c.cullingMode = (AnimatorCullingMode)0;
           c.updateMode = (AnimatorUpdateMode)0;
           c.applyRootMotion = false;
           c.enabled = true;
           { var ctrl = LookupAnimatorController("YanHua_NewYear"); if (ctrl != null) c.runtimeAnimatorController = ctrl; }
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
        var rootGO = goMap[8284263909460438706L];
        string path = "Assets/Prefabs/Imported/UIGiftEffect_NewYear.prefab";
        PrefabUtility.SaveAsPrefabAsset(rootGO, path);
        Object.DestroyImmediate(rootGO);
        Debug.Log("[Import_res_p_452] Saved " + path);
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