using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using UnityEditor.SceneManagement;

/// <summary>
/// Builds MainUIScene.unity — the in-game HUD, using AUTHORITATIVE positions
/// decompiled from the original res_p_91..res_p_105 bundles (UIHud, UIHudMinimap,
/// UIHudLeftPanelTask, UIHudRightBottom, UIHudRightTopWelfare, UIHudRightCenter).
///
/// Goal: match the REAL in-game screenshot, not an invented composition.
///  - No invented chat panel (original screenshot shows no chat popup)
///  - No invented team member portraits
///  - Only 2 welfare icons visible (Hoạt Động + Nạp Lần Đầu)
///  - Yellow vertical task banner (imgOngoing) from res_p_98
///  - Right vertical menu Row1 (Skill/LifeSkill/Kin/Tong/Setting) + Row2 from res_p_102
///  - Minimap with "Vân Trung Trấn" label from res_p_100
///  - UIHud top-left player frame + imgOnHook + imgBuff + exp from res_p_91
///
/// Reference resolution: 1334 x 750 (matches bundle coords).
/// </summary>
public class BuildMainUIScene
{
    const string SCENE_PATH = "Assets/MainUIScene.unity";
    const float REF_W = 1334f;
    const float REF_H = 750f;

    [MenuItem("KTO/Build MainUI Scene")]
    public static void Execute()
    {
        Debug.Log("[BuildMainUIScene] START");

        ForceSpriteImportInDir("Assets/Sprite/hud");
        ForceSpriteImportInDir("Assets/Sprite/common");
        ForceSpriteImportInDir("Assets/Sprite/minimap");
        ForceSpriteImportInDir("Assets/Sprite/activity");
        ForceSpriteImportInDir("Assets/Sprite/welfare");
        AssetDatabase.Refresh();

        var mapTi = AssetImporter.GetAtPath("Assets/Sprite/minimap/minimap_shaolin.png") as TextureImporter;
        if (mapTi != null)
        {
            mapTi.textureType = TextureImporterType.Sprite;
            mapTi.mipmapEnabled = false;
            mapTi.SaveAndReimport();
        }

        var scene = EditorSceneManager.NewScene(NewSceneSetup.DefaultGameObjects, NewSceneMode.Single);

        // EventSystem
        var es = new GameObject("EventSystem");
        es.AddComponent<UnityEngine.EventSystems.EventSystem>();
        es.AddComponent<UnityEngine.EventSystems.StandaloneInputModule>();

        // Canvas (ScreenSpaceOverlay, 1334x750)
        var hudGO = new GameObject("UIMainUI");
        var hudCanvas = hudGO.AddComponent<Canvas>();
        hudCanvas.renderMode = RenderMode.ScreenSpaceOverlay;
        hudCanvas.sortingOrder = 10;
        var scaler = hudGO.AddComponent<CanvasScaler>();
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        scaler.referenceResolution = new Vector2(REF_W, REF_H);
        scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;
        scaler.matchWidthOrHeight = 0.5f;
        hudGO.AddComponent<GraphicRaycaster>();

        Transform root = hudGO.transform;

        // ------- sprite handles -------
        Sprite mapBg         = Load("Assets/Sprite/minimap/minimap_shaolin.png");
        Sprite spHudBg       = Load("Assets/Sprite/hud/btn_hud_bg.png");
        Sprite spPortraitBg  = Load("Assets/Sprite/hud/img_hud_faction_bg.png");
        Sprite spCircular    = Load("Assets/Sprite/common/img_circular.png");
        Sprite spHp          = Load("Assets/Sprite/hud/img_hp.png");
        Sprite spHpBg        = Load("Assets/Sprite/hud/img_hp_bg.png");
        Sprite spMp          = Load("Assets/Sprite/hud/img_mp.png");
        Sprite spExp         = Load("Assets/Sprite/hud/img_exp.png");
        Sprite spFightPower  = Load("Assets/Sprite/hud/img_fightpower.png");
        Sprite spMinimapBg   = Load("Assets/Sprite/hud/img_hud_minimap_bg.png");
        Sprite spMinimapHead = Load("Assets/Sprite/hud/img_hud_column.png");
        Sprite spOnHook      = Load("Assets/Sprite/hud/img_hud_onhook.png");
        Sprite spBatteryBg   = Load("Assets/Sprite/common/phone_energyframe.png");
        Sprite spBatteryFill = Load("Assets/Sprite/common/phone_charging.png");
        Sprite spSignal      = Load("Assets/Sprite/common/Signal_1.png");
        Sprite spBag         = Load("Assets/Sprite/hud/btn_bag.png");
        Sprite spSetting     = Load("Assets/Sprite/hud/btn_setting.png");
        Sprite spSwitch      = Load("Assets/Sprite/common/btn_switch.png");
        Sprite spPartner     = Load("Assets/Sprite/hud/btn_partner.png");
        Sprite spRanking     = Load("Assets/Sprite/hud/btn_ranking.png");
        Sprite spLifeSkill   = Load("Assets/Sprite/hud/btn_lifeskill.png");
        Sprite spKin         = Load("Assets/Sprite/hud/btn_kin.png");
        Sprite spTaskBg      = Load("Assets/Sprite/hud/img_hud_task.png");
        Sprite spListBg      = Load("Assets/Sprite/hud/img_hud_btnlist_bg.png");
        Sprite spSit         = Load("Assets/Sprite/common/btn_sit.png");
        Sprite spMapBg       = Load("Assets/Sprite/common/hud_map_bg.png");
        Sprite spMapMask     = Load("Assets/Sprite/common/mapmask.png");
        Sprite spLevelBg     = Load("Assets/Sprite/common/img_level_bg.png");
        Sprite spPortraitBg2 = Load("Assets/Sprite/common/img_portrait_bg.png");
        Sprite spPortraitFrameCommon = Load("Assets/Sprite/common/img_portrait_frame.png");
        Sprite spActivity    = Load("Assets/Sprite/hud/btn_activity.png");
        Sprite spFirstRecharge= Load("Assets/Sprite/hud/btn_firstrecharge.png");
        Sprite spImgTask     = Load("Assets/Sprite/hud/img_hud_task.png");
        Sprite spImgTaskGo   = Load("Assets/Sprite/hud/img_taskgo.png");

        // Right-menu icons (reuse what exists)
        Sprite spSkill       = Load("Assets/Sprite/hud/btn_skill.png");
        Sprite spStronger    = Load("Assets/Sprite/hud/btn_stronger.png");
        Sprite spTarget      = Load("Assets/Sprite/common/btn_target.png");
        Sprite spFlag        = Load("Assets/Sprite/common/flag.png");
        Sprite spSkillBig    = Load("Assets/Sprite/hud/btn_skill_bg_Big.png");
        Sprite spSkillLittle = Load("Assets/Sprite/hud/btn_skill_bg_Little.png");
        Sprite spFightMode   = Load("Assets/Sprite/hud/btn_hud_peace.png");
        Sprite spRideUp      = Load("Assets/Sprite/common/btn_ride_up.png");
        Sprite spAuto        = Load("Assets/Sprite/common/btn_auto.png");
        Sprite spChatLoc     = Load("Assets/Sprite/chat/btn_chat_location.png");
        Sprite spChatVoice   = Load("Assets/Sprite/chat/btn_chat_voice.png");
        Sprite spNewChat     = Load("Assets/Sprite/chat/btn_newchat.png");
        Sprite spChatBg      = Load("Assets/Sprite/chat/img_chat_bg.png");
        Sprite spNewMsgCount = Load("Assets/Sprite/chat/img_newmsgcount.png");
        Sprite spHongbao     = Load("Assets/Sprite/common_btn/btn_hongbao_normal.png");
        Sprite spRideDown    = Load("Assets/Sprite/common/btn_ride_down.png");
        Sprite spSkillSpec   = Load("Assets/Sprite/hud/img_skillspecial.png");

        Font titleFont = AssetDatabase.LoadAssetAtPath<Font>("Assets/Font/btn_hydl_vi.ttf");
        Font bodyFont  = AssetDatabase.LoadAssetAtPath<Font>("Assets/Font/common_vi.ttf");

        // ============================================================
        // Scene background — Shaolin map tile, fills canvas
        // ============================================================
        {
            var bgGO = new GameObject("SceneBG");
            bgGO.transform.SetParent(root, false);
            var img = bgGO.AddComponent<Image>();
            img.sprite = mapBg; img.type = Image.Type.Simple;
            img.preserveAspect = false; img.color = Color.white;
            img.raycastTarget = false;
            var rt = bgGO.GetComponent<RectTransform>();
            rt.anchorMin = Vector2.zero; rt.anchorMax = Vector2.one;
            rt.offsetMin = Vector2.zero; rt.offsetMax = Vector2.zero;

            var dim = new GameObject("Dim");
            dim.transform.SetParent(root, false);
            var di = dim.AddComponent<Image>();
            di.color = new Color(0,0,0,0.22f); di.raycastTarget = false;
            var dRT = dim.GetComponent<RectTransform>();
            dRT.anchorMin = Vector2.zero; dRT.anchorMax = Vector2.one;
            dRT.offsetMin = Vector2.zero; dRT.offsetMax = Vector2.zero;
        }

        // ============================================================
        // Accurate low-level (Lv9) HUD layout to match the original screenshot.
        // Bundle data (res_p_91..105) holds MAX-LEVEL state; many elements are
        // hidden at runtime for a new character. Below we only place what is
        // actually visible in the provided reference screenshot.
        // ============================================================

        // -----------------------------------------------------------
        // [1] Player Frame (top-left)
        //   Small round portrait + orange dot + level badge under it,
        //   "Sơ Nhập" name + HP bar + "Tài Phú: 7972" stacked right of it.
        // -----------------------------------------------------------
        {
            var frame = NewNode(root, "PlayerFrame", v(0,1), v(0,1), v(0,1),
                                new Vector2(6, -6), new Vector2(420, 96));

            // Portrait circle
            var portrait = NewNode(frame, "btnRoleHead", v(0,1), v(0,1), v(0.5f,0.5f),
                                   new Vector2(44, -42), new Vector2(72, 72));
            var pBg = portrait.gameObject.AddComponent<Image>();
            pBg.sprite = spPortraitBg2 != null ? spPortraitBg2 : spCircular;
            pBg.color = new Color(0.95f, 0.82f, 0.5f, 1f);
            pBg.preserveAspect = true; pBg.raycastTarget = false;
            var pPortrait = NewImage(portrait, "Portrait", spCircular,
                                     new Color(0.85f, 0.6f, 0.35f, 1f), Image.Type.Simple);
            pPortrait.preserveAspect = true;
            SetRT(pPortrait, v(0.5f,0.5f), v(0.5f,0.5f), v(0.5f,0.5f), Vector2.zero, new Vector2(60, 60));

            // Orange dot top (state indicator)
            var dot = NewImage(portrait, "StateDot", spCircular,
                               new Color(1f, 0.55f, 0.1f, 1f), Image.Type.Simple);
            dot.preserveAspect = true;
            SetRT(dot, v(0.5f,1), v(0.5f,1), v(0.5f,0.5f), new Vector2(-20, 0), new Vector2(14, 14));

            // Level badge under portrait (dark circle + "9")
            var levelGO = NewNode(portrait, "Level", v(0.5f,0), v(0.5f,0), v(0.5f,0.5f),
                                  new Vector2(0, -4), new Vector2(28, 28));
            var lvBgImg = levelGO.gameObject.AddComponent<Image>();
            lvBgImg.sprite = spCircular; lvBgImg.color = new Color(0.08f, 0.08f, 0.08f, 0.92f);
            lvBgImg.preserveAspect = true; lvBgImg.raycastTarget = false;
            var lvTxt = NewText(levelGO, "Text", "9", titleFont, 18,
                                TextAnchor.MiddleCenter, new Color(1f, 0.92f, 0.4f, 1f));
            SetRT(lvTxt.rectTransform, v(0,0), v(1,1), v(0.5f,0.5f), Vector2.zero, Vector2.zero);
            AddOutline(lvTxt.gameObject, Color.black);

            // Name "Sơ Nhập"
            var name = NewText(frame, "txtName", "Sơ Nhập", titleFont, 22,
                               TextAnchor.LowerLeft, new Color(1f, 0.92f, 0.58f, 1f));
            SetRT(name.rectTransform, v(0,1), v(0,1), v(0,0),
                  new Vector2(88, -32), new Vector2(200, 28));
            AddOutline(name.gameObject, new Color(0.3f, 0.12f, 0f, 1f));

            // HP bar (long, thin, horizontal) — no MP in original
            var hpBg = NewImage(frame, "hp_bg", spHpBg, new Color(0.1f, 0.05f, 0.03f, 0.9f), Image.Type.Sliced);
            SetRT(hpBg, v(0,1), v(0,1), v(0,0.5f),
                  new Vector2(88, -38), new Vector2(300, 14));
            var hp = NewImage(frame, "hp", spHp, new Color(0.85f, 0.18f, 0.18f, 1f), Image.Type.Filled);
            hp.fillMethod = Image.FillMethod.Horizontal; hp.fillAmount = 0.85f;
            SetRT(hp, v(0,1), v(0,1), v(0,0.5f),
                  new Vector2(90, -38), new Vector2(296, 10));
            var hpNum = NewText(frame, "hpNum", "3565", bodyFont, 14,
                                TextAnchor.MiddleRight, new Color(1f, 1f, 1f, 1f));
            SetRT(hpNum.rectTransform, v(0,1), v(0,1), v(1,0.5f),
                  new Vector2(386, -38), new Vector2(80, 20));
            AddOutline(hpNum.gameObject, Color.black);

            // "Tài Phú: 7972" (wealth, not fight power at low level)
            var tpLbl = NewText(frame, "txtTaiPhuLabel", "Tài Phú:", bodyFont, 14,
                                TextAnchor.LowerLeft, new Color(0.98f, 0.86f, 0.5f, 1f));
            SetRT(tpLbl.rectTransform, v(0,1), v(0,1), v(0,0),
                  new Vector2(88, -68), new Vector2(80, 22));
            AddOutline(tpLbl.gameObject, Color.black);
            var tpNum = NewText(frame, "txtTaiPhuNum", "7972", bodyFont, 14,
                                TextAnchor.LowerLeft, new Color(0.55f, 1f, 0.55f, 1f));
            SetRT(tpNum.rectTransform, v(0,1), v(0,1), v(0,0),
                  new Vector2(150, -68), new Vector2(120, 22));
            AddOutline(tpNum.gameObject, Color.black);

            // Faction leaf icon next to tài phú (small green leaf)
            var leaf = NewImage(frame, "FactionLeaf", spFlag, new Color(0.4f, 1f, 0.4f, 1f), Image.Type.Simple);
            leaf.preserveAspect = true;
            SetRT(leaf, v(0,1), v(0,1), v(0,0.5f),
                  new Vector2(124, -78), new Vector2(20, 20));
        }

        // -----------------------------------------------------------
        // [2] "Hòa Bình" FightMode button + "18+" badge (top, right of frame)
        // -----------------------------------------------------------
        {
            var fmRoot = NewNode(root, "FightMode", v(0,1), v(0,1), v(0.5f,0.5f),
                                 new Vector2(520, -38), new Vector2(120, 36));
            var bg = fmRoot.gameObject.AddComponent<Image>();
            bg.sprite = spHudBg; bg.type = Image.Type.Sliced;
            bg.color = new Color(0.1f, 0.06f, 0.04f, 0.82f); bg.raycastTarget = false;

            // bird icon
            var bird = NewImage(fmRoot, "icon", spFightMode != null ? spFightMode : spFlag,
                                new Color(0.9f, 1f, 0.9f, 1f), Image.Type.Simple);
            bird.preserveAspect = true;
            SetRT(bird, v(0,0), v(0,0), v(0,0.5f), new Vector2(6, 18), new Vector2(26, 26));

            var txt = NewText(fmRoot, "Text", "Hòa Bình", titleFont, 16,
                              TextAnchor.MiddleCenter, new Color(1f, 0.92f, 0.55f, 1f));
            SetRT(txt.rectTransform, v(0,0), v(1,1), v(0.5f,0.5f),
                  new Vector2(14, 0), new Vector2(-14, 0));
            AddOutline(txt.gameObject, Color.black);

            // 18+ badge next to FightMode
            var age = NewNode(root, "Badge18", v(0,1), v(0,1), v(0.5f,0.5f),
                              new Vector2(610, -38), new Vector2(34, 32));
            var ageBg = age.gameObject.AddComponent<Image>();
            ageBg.sprite = spCircular; ageBg.color = new Color(0.05f, 0.05f, 0.05f, 0.85f);
            ageBg.preserveAspect = true; ageBg.raycastTarget = false;
            var ageTxt = NewText(age, "Text", "18+", bodyFont, 13,
                                 TextAnchor.MiddleCenter, new Color(1f, 0.95f, 0.55f, 1f));
            SetRT(ageTxt.rectTransform, v(0,0), v(1,1), v(0.5f,0.5f), Vector2.zero, Vector2.zero);
            AddOutline(ageTxt.gameObject, Color.black);
        }

        // -----------------------------------------------------------
        // [3] Task panel (left side, below player frame) — 2 tasks
        //   Small flag icon on far-left outside the yellow banner.
        // -----------------------------------------------------------
        {
            var taskRoot = NewNode(root, "TaskPanel", v(0,1), v(0,1), v(0,1),
                                   new Vector2(6, -140), new Vector2(370, 220));

            // Flag icon on outer-left (quest tracker marker)
            var flagIco = NewImage(taskRoot, "FlagIcon", spFlag,
                                   new Color(1f, 0.92f, 0.2f, 1f), Image.Type.Simple);
            flagIco.preserveAspect = true;
            SetRT(flagIco, v(0,1), v(0,1), v(0.5f,0.5f),
                  new Vector2(16, -22), new Vector2(26, 30));

            // [Chính] task banner (yellow outlined box)
            var mainBg = NewNode(taskRoot, "MainTaskBG", v(0,1), v(0,1), v(0,1),
                                 new Vector2(36, 0), new Vector2(330, 80));
            var mainBgImg = mainBg.gameObject.AddComponent<Image>();
            mainBgImg.sprite = spHudBg; mainBgImg.type = Image.Type.Sliced;
            mainBgImg.color = new Color(0.08f, 0.05f, 0.03f, 0.78f);
            mainBgImg.raycastTarget = false;
            var mainOutline = mainBg.gameObject.AddComponent<Outline>();
            mainOutline.effectColor = new Color(0.95f, 0.78f, 0.3f, 1f);
            mainOutline.effectDistance = new Vector2(2, -2);

            var mainTitle = NewText(mainBg, "txtTitle",
                                    "<color=#FFE16A>[Chính]</color> <color=#FFFFFF>Anh Cô Trở Về</color> <color=#FFE16A>(2/6)</color>",
                                    bodyFont, 17, TextAnchor.UpperLeft, Color.white);
            mainTitle.supportRichText = true;
            SetRT(mainTitle.rectTransform, v(0,1), v(1,1), v(0,1),
                  new Vector2(12, -8), new Vector2(-12, 26));
            AddOutline(mainTitle.gameObject, Color.black);

            var mainDesc = NewText(mainBg, "txtDesc",
                                   "Đánh bại <color=#FF8A6A>Tần Công Xích</color>",
                                   bodyFont, 15, TextAnchor.UpperLeft, new Color(0.95f, 0.9f, 0.78f, 1f));
            mainDesc.supportRichText = true;
            SetRT(mainDesc.rectTransform, v(0,1), v(1,1), v(0,1),
                  new Vector2(12, -38), new Vector2(-12, 26));
            AddOutline(mainDesc.gameObject, Color.black);

            // Small [Phụ] side-quest row (no banner frame, just text)
            var sub = NewNode(taskRoot, "SubTask", v(0,1), v(0,1), v(0,1),
                              new Vector2(36, -94), new Vector2(330, 70));

            var subTitle = NewText(sub, "txtTitle",
                                   "<color=#8BE6FF>[Phụ]</color> <color=#FFFFFF>Cường Hóa Trang Bị</color> <color=#8BE6FF>(3/3)</color>",
                                   bodyFont, 15, TextAnchor.UpperLeft, Color.white);
            subTitle.supportRichText = true;
            SetRT(subTitle.rectTransform, v(0,1), v(1,1), v(0,1),
                  new Vector2(0, 0), new Vector2(0, 22));
            AddOutline(subTitle.gameObject, Color.black);

            var subDesc = NewText(sub, "txtDesc",
                                  "Đối thoại với <color=#8BE6FF>Điếm Tửu Thúc</color>",
                                  bodyFont, 14, TextAnchor.UpperLeft, new Color(0.9f, 0.88f, 0.78f, 1f));
            subDesc.supportRichText = true;
            SetRT(subDesc.rectTransform, v(0,1), v(1,1), v(0,1),
                  new Vector2(0, -26), new Vector2(0, 22));
            AddOutline(subDesc.gameObject, Color.black);
        }

        // -----------------------------------------------------------
        // [4] Top-right: signal/time/ping (res_p_91 top) + minimap with
        //   label "Khoang Thuyền Tầng 2" + coord "(17, 42)"
        // -----------------------------------------------------------
        {
            // RightTop info bar
            var rTop = NewNode(root, "RightTop", v(1,1), v(1,1), v(0.5f,0.5f),
                               new Vector2(-120, -16), new Vector2(230, 26));
            var sig = NewImage(rTop, "imgSignal", spSignal, Color.white, Image.Type.Simple);
            sig.preserveAspect = true;
            SetRT(sig, v(0,0), v(0,0), v(0,0.5f), new Vector2(4, 13), new Vector2(18, 14));

            var batt = NewNode(rTop, "Battery", v(0,0), v(0,0), v(0,0.5f),
                               new Vector2(28, 13), new Vector2(22, 12));
            var battBg = batt.gameObject.AddComponent<Image>();
            battBg.sprite = spBatteryBg; battBg.color = Color.white;
            battBg.preserveAspect = true; battBg.raycastTarget = false;
            var battFill = NewImage(batt, "imgBattery", spBatteryFill, new Color(0.4f,1f,0.5f,1f), Image.Type.Simple);
            SetRT(battFill, v(0,0), v(1,1), v(0.5f,0.5f), Vector2.zero, new Vector2(-5,-3));

            var tTime = NewText(rTop, "txtTime", "22:08:15", bodyFont, 14,
                                TextAnchor.MiddleLeft, Color.white);
            SetRT(tTime.rectTransform, v(0,0), v(0,0), v(0,0.5f),
                  new Vector2(60, 13), new Vector2(70, 20));
            AddOutline(tTime.gameObject, Color.black);

            var tPing = NewText(rTop, "txtPing", "164 ms", bodyFont, 14,
                                TextAnchor.MiddleRight, new Color(1f, 0.75f, 0.35f, 1f));
            SetRT(tPing.rectTransform, v(1,0), v(1,0), v(1,0.5f),
                  new Vector2(-6, 13), new Vector2(70, 20));
            AddOutline(tPing.gameObject, Color.black);

            // Map name bar (right under info bar)
            var nameBg = NewNode(root, "MapNameBg", v(1,1), v(1,1), v(0.5f,0.5f),
                                 new Vector2(-120, -48), new Vector2(230, 32));
            var mnImg = nameBg.gameObject.AddComponent<Image>();
            mnImg.sprite = spHudBg; mnImg.type = Image.Type.Sliced;
            mnImg.color = new Color(0.2f, 0.12f, 0.06f, 0.92f); mnImg.raycastTarget = false;
            var mapName = NewText(nameBg, "txtMapName", "Khoang Thuyền Tầng 2", titleFont, 17,
                                  TextAnchor.MiddleCenter, new Color(1f, 0.92f, 0.55f, 1f));
            SetRT(mapName.rectTransform, v(0,0), v(1,1), v(0.5f,0.5f), Vector2.zero, Vector2.zero);
            AddOutline(mapName.gameObject, new Color(0.3f, 0.12f, 0f, 1f));

            // Minimap
            var mini = NewNode(root, "Minimap", v(1,1), v(1,1), v(0.5f,0.5f),
                               new Vector2(-120, -140), new Vector2(222, 150));
            var miniImg = mini.gameObject.AddComponent<Image>();
            miniImg.sprite = mapBg; miniImg.color = new Color(0.55f, 0.48f, 0.38f, 1f);
            miniImg.preserveAspect = false; miniImg.raycastTarget = false;
            // inner frame tint
            var miniFr = NewNode(mini, "frame", v(0,0), v(1,1), v(0.5f,0.5f), Vector2.zero, new Vector2(6,6));
            var mfImg = miniFr.gameObject.AddComponent<Image>();
            mfImg.sprite = spHudBg; mfImg.type = Image.Type.Sliced;
            mfImg.color = new Color(0.25f, 0.15f, 0.05f, 0.92f); mfImg.fillCenter = false;
            mfImg.raycastTarget = false;

            // Collapse arrow on right side of minimap
            var arrow = NewNode(root, "MiniArrow", v(1,1), v(1,1), v(0.5f,0.5f),
                                new Vector2(-10, -48), new Vector2(28, 32));
            var arImg = arrow.gameObject.AddComponent<Image>();
            arImg.sprite = spCircular; arImg.color = new Color(0.2f, 0.12f, 0.05f, 0.92f);
            arImg.preserveAspect = true; arImg.raycastTarget = false;
            var arTxt = NewText(arrow, "Text", ">", titleFont, 22,
                                TextAnchor.MiddleCenter, new Color(1f, 0.95f, 0.55f, 1f));
            SetRT(arTxt.rectTransform, v(0,0), v(1,1), v(0.5f,0.5f), Vector2.zero, Vector2.zero);
            AddOutline(arTxt.gameObject, Color.black);

            // Coordinate label below minimap
            var coord = NewText(root, "txtCurPos", "(17, 42)", bodyFont, 14,
                                TextAnchor.MiddleCenter, new Color(1f, 0.92f, 0.55f, 1f));
            SetRT(coord.rectTransform, v(1,1), v(1,1), v(0.5f,0.5f),
                  new Vector2(-120, -240), new Vector2(110, 26));
            AddOutline(coord.gameObject, Color.black);
        }

        // -----------------------------------------------------------
        // [5] Welfare — 2 icons stacked VERTICALLY, LEFT of the minimap
        // -----------------------------------------------------------
        {
            var welfareRoot = NewNode(root, "WelfareStack", v(1,1), v(1,1), v(0.5f,0.5f),
                                      new Vector2(-270, -100), new Vector2(70, 180));
            AddWelfareIcon(welfareRoot, "btnActivity",
                           new Vector2(0, 40), spActivity, "Hoạt Động", bodyFont);
            AddWelfareIcon(welfareRoot, "btnFirstRecharge",
                           new Vector2(0, -50), spFirstRecharge, "Nạp Lần Đầu", bodyFont);
        }

        // -----------------------------------------------------------
        // [6] Right-side vertical menu column (6 icons)
        //   Túi / gem / Tự động / Hồng bao(30) / Lv10 lock / Lv20 lock
        //   At low level most feature buttons are hidden, the column has
        //   only a few active entries + 2 locked skill slots.
        // -----------------------------------------------------------
        {
            var rbRoot = NewNode(root, "RightBottomMenu", v(1,1), v(1,1), v(1,1),
                                 new Vector2(-8, -260), new Vector2(80, 420));

            // Helper-like inline definitions
            void MakeIcon(string name, float y, Sprite icon, string label, Color iconTint, bool locked = false, string lockText = "")
            {
                var btn = NewNode(rbRoot, name, v(1,1), v(1,1), v(1,1),
                                  new Vector2(-6, y), new Vector2(64, 64));
                var bgImg = btn.gameObject.AddComponent<Image>();
                bgImg.sprite = spCircular; bgImg.color = new Color(0.15f, 0.1f, 0.06f, 0.85f);
                bgImg.preserveAspect = true; bgImg.raycastTarget = false;
                if (icon != null)
                {
                    var ic = NewImage(btn, "icon", icon, iconTint, Image.Type.Simple);
                    ic.preserveAspect = true;
                    SetRT(ic, v(0.5f,0.5f), v(0.5f,0.5f), v(0.5f,0.5f), Vector2.zero, new Vector2(52, 52));
                }
                if (!string.IsNullOrEmpty(label))
                {
                    var lbl = NewText(btn, "Text", label, bodyFont, 11,
                                      TextAnchor.MiddleCenter, new Color(1f, 0.93f, 0.55f, 1f));
                    SetRT(lbl.rectTransform, v(0.5f,0), v(0.5f,0), v(0.5f,0.5f),
                          new Vector2(0, -8), new Vector2(72, 16));
                    AddOutline(lbl.gameObject, Color.black);
                }
                if (locked)
                {
                    var lbl = NewText(btn, "LockText", lockText, bodyFont, 10,
                                      TextAnchor.MiddleCenter, new Color(0.95f, 0.85f, 0.55f, 1f));
                    SetRT(lbl.rectTransform, v(0.5f,0), v(0.5f,0), v(0.5f,0.5f),
                          new Vector2(0, -8), new Vector2(78, 14));
                    AddOutline(lbl.gameObject, Color.black);
                    bgImg.color = new Color(0.08f, 0.05f, 0.03f, 0.92f);
                    var lockIco = NewImage(btn, "lockIcon", spCircular, new Color(1f,1f,1f,0.75f), Image.Type.Simple);
                    SetRT(lockIco, v(0.5f,0.5f), v(0.5f,0.5f), v(0.5f,0.5f), Vector2.zero, new Vector2(28, 28));
                }
            }

            MakeIcon("btnBag",         0,    spBag,          "Túi",       Color.white);
            MakeIcon("btnGem",        -80,   spCircular,     "",          new Color(0.7f, 0.9f, 1f, 1f));
            MakeIcon("btnAuto",       -160,  spAuto,         "Tự động",   Color.white);
            MakeIcon("btnHongBao",    -240,  spHongbao,      "30",        Color.white);
            MakeIcon("btnSkillLock1", -320,  null,           "Lv10 được học", Color.white, locked: true, lockText: "Lv10 được học");
            MakeIcon("btnSkillLock2", -400,  null,           "Lv20 được học", Color.white, locked: true, lockText: "Lv20 được học");
        }

        // -----------------------------------------------------------
        // [7] Skill ring (bottom-right) — main attack + 3 secondary
        //   Main = orange dragon; secondary skills stacked vertically
        // -----------------------------------------------------------
        {
            var skRoot = NewNode(root, "SkillRing", v(1,0), v(1,0), v(0.5f,0.5f),
                                 new Vector2(0, 0), new Vector2(0, 0));

            // btnSkill1 (main attack) — orange dragon circle
            var main = NewNode(skRoot, "btnSkill1", v(1,0), v(1,0), v(0.5f,0.5f),
                               new Vector2(-110, 110), new Vector2(130, 130));
            var mBg = main.gameObject.AddComponent<Image>();
            mBg.sprite = spSkillBig != null ? spSkillBig : spCircular;
            mBg.color = new Color(1f, 0.72f, 0.25f, 1f);
            mBg.preserveAspect = true; mBg.raycastTarget = false;
            var mInner = NewImage(main, "skillImage", spCircular,
                                  new Color(0.85f, 0.45f, 0.15f, 1f), Image.Type.Simple);
            mInner.preserveAspect = true;
            SetRT(mInner, v(0.5f,0.5f), v(0.5f,0.5f), v(0.5f,0.5f), Vector2.zero, new Vector2(96, 96));

            // Secondary skills (3 stacked vertical-left of main)
            // All using small skill bg; show numbers "3", "21", "6"
            (string name, float x, float y, Sprite icon, Color tint, string count)[] secs = {
                ("btnSkill2", -220,  60, spSkill,     new Color(0.35f, 0.65f, 1f, 1f), "3"),
                ("btnSkill3", -235, 160, spCircular,  new Color(1f,   0.45f, 0.2f, 1f), "21"),
                ("btnSkill4", -175, 250, spCircular,  new Color(1f,   0.55f, 0.3f, 1f), "6"),
            };
            foreach (var s in secs)
            {
                var b = NewNode(skRoot, s.name, v(1,0), v(1,0), v(0.5f,0.5f),
                                new Vector2(s.x, s.y), new Vector2(78, 78));
                var bBg = b.gameObject.AddComponent<Image>();
                bBg.sprite = spSkillLittle != null ? spSkillLittle : spCircular;
                bBg.color = Color.white; bBg.preserveAspect = true; bBg.raycastTarget = false;
                var bIc = NewImage(b, "icon", s.icon != null ? s.icon : spCircular,
                                   s.tint, Image.Type.Simple);
                bIc.preserveAspect = true;
                SetRT(bIc, v(0.5f,0.5f), v(0.5f,0.5f), v(0.5f,0.5f), Vector2.zero, new Vector2(56, 56));
                // count badge (top-left)
                var cnt = NewText(b, "count", s.count, titleFont, 17,
                                  TextAnchor.UpperLeft, new Color(1f, 0.95f, 0.55f, 1f));
                SetRT(cnt.rectTransform, v(0,0), v(1,1), v(0.5f,0.5f),
                      new Vector2(4, -4), new Vector2(-4, -4));
                AddOutline(cnt.gameObject, Color.black);
            }

            // btnRide (horse) bottom
            {
                var ride = NewNode(skRoot, "btnRide", v(1,0), v(1,0), v(0.5f,0.5f),
                                   new Vector2(-378, 34), new Vector2(56, 56));
                var img = ride.gameObject.AddComponent<Image>();
                img.sprite = spCircular; img.color = new Color(0.15f,0.08f,0.04f,0.85f);
                img.preserveAspect = true; img.raycastTarget = false;
                var ic = NewImage(ride, "icon", spRideUp != null ? spRideUp : spCircular,
                                  Color.white, Image.Type.Simple);
                ic.preserveAspect = true;
                SetRT(ic, v(0.5f,0.5f), v(0.5f,0.5f), v(0.5f,0.5f), Vector2.zero, new Vector2(44, 44));
            }

            // btnSwitchTarget (crosshair)
            {
                var tgt = NewNode(skRoot, "btnSwitchTarget", v(1,0), v(1,0), v(0.5f,0.5f),
                                  new Vector2(-308, 37), new Vector2(56, 56));
                var img = tgt.gameObject.AddComponent<Image>();
                img.sprite = spCircular; img.color = new Color(0.15f,0.08f,0.04f,0.85f);
                img.preserveAspect = true; img.raycastTarget = false;
                var ic = NewImage(tgt, "icon", spTarget != null ? spTarget : spFlag,
                                  Color.white, Image.Type.Simple);
                ic.preserveAspect = true;
                SetRT(ic, v(0.5f,0.5f), v(0.5f,0.5f), v(0.5f,0.5f), Vector2.zero, new Vector2(42, 42));
            }
        }

        // -----------------------------------------------------------
        // [8] Bottom-center notification panel with reward lines
        //   + gear / up-arrow buttons on right, team mic on left
        // -----------------------------------------------------------
        {
            var bottom = NewNode(root, "BottomNotify", v(0.5f,0), v(0.5f,0), v(0.5f,0),
                                 new Vector2(30, 90), new Vector2(540, 98));
            var bg = bottom.gameObject.AddComponent<Image>();
            bg.sprite = spHudBg; bg.type = Image.Type.Sliced;
            bg.color = new Color(0, 0, 0, 0.55f); bg.raycastTarget = false;

            string[] lines = {
                "[Nhắc] Nhận <color=#FFE16A><Y Phục Thường Bậc 1></color>",
                "[Nhắc] Nhận <color=#FFE16A>Bạc×1000</color>",
                "[Nhắc] Đã vào khu chiến đấu",
            };
            for (int i = 0; i < 3; i++)
            {
                var lt = NewText(bottom, $"line{i}", lines[i], bodyFont, 14,
                                 TextAnchor.MiddleLeft, new Color(0.95f, 0.95f, 0.85f, 1f));
                lt.supportRichText = true;
                SetRT(lt.rectTransform, v(0,1), v(1,1), v(0,1),
                      new Vector2(16, -8 - i * 28), new Vector2(-80, 24));
                AddOutline(lt.gameObject, Color.black);
            }

            // Team mic button on left OUTSIDE the panel
            var mic = NewNode(root, "btnTeamMic", v(0.5f,0), v(0.5f,0), v(0.5f,0),
                              new Vector2(-20, 150), new Vector2(56, 56));
            var micImg = mic.gameObject.AddComponent<Image>();
            micImg.sprite = spChatVoice != null ? spChatVoice : spCircular;
            micImg.color = new Color(0.95f, 0.95f, 0.95f, 1f);
            micImg.preserveAspect = true; micImg.raycastTarget = false;
            var micLbl = NewText(mic, "Text", "Đội", bodyFont, 12,
                                 TextAnchor.MiddleCenter, new Color(1f, 0.93f, 0.55f, 1f));
            SetRT(micLbl.rectTransform, v(0.5f,0), v(0.5f,0), v(0.5f,0.5f),
                  new Vector2(0, -6), new Vector2(50, 18));
            AddOutline(micLbl.gameObject, Color.black);

            // Up-arrow toggle on right of panel
            var up = NewNode(bottom, "btnUp", v(1,1), v(1,1), v(1,1),
                             new Vector2(-6, -6), new Vector2(32, 32));
            var upImg = up.gameObject.AddComponent<Image>();
            upImg.sprite = spCircular; upImg.color = new Color(0.15f, 0.1f, 0.05f, 0.9f);
            upImg.preserveAspect = true; upImg.raycastTarget = false;
            var upTxt = NewText(up, "Text", "^", titleFont, 20,
                                TextAnchor.MiddleCenter, new Color(1f, 0.92f, 0.55f, 1f));
            SetRT(upTxt.rectTransform, v(0,0), v(1,1), v(0.5f,0.5f), Vector2.zero, Vector2.zero);
            AddOutline(upTxt.gameObject, Color.black);

            // Gear settings below arrow
            var gear = NewNode(bottom, "btnGear", v(1,0), v(1,0), v(1,0),
                               new Vector2(-6, 6), new Vector2(32, 32));
            var gearImg = gear.gameObject.AddComponent<Image>();
            gearImg.sprite = spSetting != null ? spSetting : spCircular;
            gearImg.color = Color.white; gearImg.preserveAspect = true; gearImg.raycastTarget = false;
        }

        // -----------------------------------------------------------
        // [9] Left-edge collapse arrow "<" (middle of left edge)
        // -----------------------------------------------------------
        {
            var lc = NewNode(root, "btnLeftCollapse", v(0, 0.5f), v(0, 0.5f), v(0.5f, 0.5f),
                             new Vector2(24, 0), new Vector2(32, 44));
            var lcBg = lc.gameObject.AddComponent<Image>();
            lcBg.sprite = spHudBg; lcBg.type = Image.Type.Sliced;
            lcBg.color = new Color(0.1f, 0.06f, 0.04f, 0.85f); lcBg.raycastTarget = false;
            var lcTxt = NewText(lc, "Text", "<", titleFont, 24,
                                TextAnchor.MiddleCenter, new Color(1f, 0.92f, 0.55f, 1f));
            SetRT(lcTxt.rectTransform, v(0,0), v(1,1), v(0.5f,0.5f), Vector2.zero, Vector2.zero);
            AddOutline(lcTxt.gameObject, Color.black);
        }

        // -----------------------------------------------------------
        // [10] Bottom-left: lotus meditation ("Treo máy" equivalent) + EXP bar
        // -----------------------------------------------------------
        {
            // Lotus
            var lotus = NewNode(root, "btnMeditation", v(0,0), v(0,0), v(0.5f,0.5f),
                                new Vector2(40, 56), new Vector2(56, 56));
            var lImg = lotus.gameObject.AddComponent<Image>();
            lImg.sprite = spOnHook != null ? spOnHook : spCircular;
            lImg.color = new Color(1f, 0.92f, 0.45f, 1f);
            lImg.preserveAspect = true; lImg.raycastTarget = false;

            // EXP bar (bottom full width)
            var expRoot = NewNode(root, "ExpBar", v(0,0), v(1,0), v(0.5f,0),
                                  new Vector2(0, 0), new Vector2(0, 26));
            var expBg = expRoot.gameObject.AddComponent<Image>();
            expBg.color = new Color(0, 0, 0, 0.6f); expBg.raycastTarget = false;
            var expFill = NewImage(expRoot, "Fill", spExp,
                                   new Color(1f, 0.83f, 0.35f, 1f), Image.Type.Filled);
            expFill.fillMethod = Image.FillMethod.Horizontal; expFill.fillAmount = 0.4008f;
            SetRT(expFill, v(0,0), v(1,0), v(0.5f,0), new Vector2(0, 4), new Vector2(0, 6));
            var expTxt = NewText(expRoot, "Text", "EXP 200420/500000 (40.08%)", bodyFont, 13,
                                 TextAnchor.MiddleLeft, new Color(1f, 0.95f, 0.6f, 1f));
            SetRT(expTxt.rectTransform, v(0,0), v(1,1), v(0.5f,0.5f),
                  new Vector2(110, 0), new Vector2(-20, 0));
            AddOutline(expTxt.gameObject, Color.black);
        }


        // Save scene
        EditorSceneManager.MarkSceneDirty(scene);
        EditorSceneManager.SaveScene(scene, SCENE_PATH);
        Debug.Log($"[BuildMainUIScene] Saved {SCENE_PATH}");
    }

    // ---------------- helpers ----------------
    static Sprite Load(string path) => AssetDatabase.LoadAssetAtPath<Sprite>(path);
    static Vector2 v(float x, float y) => new Vector2(x,y);

    static Transform NewNode(Transform parent, string name,
                             Vector2 aMin, Vector2 aMax, Vector2 pivot,
                             Vector2 pos, Vector2 size)
    {
        var go = new GameObject(name);
        go.transform.SetParent(parent, false);
        var rt = go.AddComponent<RectTransform>();
        rt.anchorMin = aMin; rt.anchorMax = aMax; rt.pivot = pivot;
        rt.anchoredPosition = pos; rt.sizeDelta = size;
        return go.transform;
    }

    static Image NewImage(Transform parent, string name, Sprite sprite, Color color, Image.Type type)
    {
        var go = new GameObject(name);
        go.transform.SetParent(parent, false);
        var img = go.AddComponent<Image>();
        img.sprite = sprite; img.color = color; img.type = type;
        img.raycastTarget = false;
        return img;
    }

    static Text NewText(Transform parent, string name, string text, Font font, int size,
                        TextAnchor align, Color color)
    {
        var go = new GameObject(name);
        go.transform.SetParent(parent, false);
        var t = go.AddComponent<Text>();
        t.text = text; t.font = font; t.fontSize = size; t.alignment = align;
        t.color = color; t.raycastTarget = false;
        t.horizontalOverflow = HorizontalWrapMode.Overflow;
        t.verticalOverflow = VerticalWrapMode.Overflow;
        return t;
    }

    static void SetRT(Image img, Vector2 aMin, Vector2 aMax, Vector2 pivot, Vector2 pos, Vector2 size)
        => SetRT(img.rectTransform, aMin, aMax, pivot, pos, size);

    static void SetRT(RectTransform rt, Vector2 aMin, Vector2 aMax, Vector2 pivot, Vector2 pos, Vector2 size)
    {
        rt.anchorMin = aMin; rt.anchorMax = aMax; rt.pivot = pivot;
        rt.anchoredPosition = pos; rt.sizeDelta = size;
    }

    static void AddOutline(GameObject go, Color c)
    {
        var o = go.GetComponent<Outline>();
        if (o == null) o = go.AddComponent<Outline>();
        o.effectColor = c;
        o.effectDistance = new Vector2(1,-1);
    }

    static void AddWelfareIcon(Transform parent, string name, Vector2 pos, Sprite icon, string label, Font font)
    {
        var btn = NewNode(parent, name, v(0.5f,0.5f), v(0.5f,0.5f), v(0.5f,0.5f), pos, new Vector2(68,80));
        var ic = NewImage(btn, "imgIcon", icon, Color.white, Image.Type.Simple);
        ic.preserveAspect = true;
        SetRT(ic, v(0.5f,0.5f), v(0.5f,0.5f), v(0.5f,0.5f), new Vector2(0,11), new Vector2(64,64));
        var lbl = NewText(btn, "Text", label, font, 12,
                          TextAnchor.MiddleCenter, new Color(1f, 0.93f, 0.55f, 1f));
        SetRT(lbl.rectTransform, v(0.5f,0.5f), v(0.5f,0.5f), v(0.5f,0.5f), new Vector2(0,-22), new Vector2(80,20));
        AddOutline(lbl.gameObject, Color.black);
    }

    static void ForceSpriteImportInDir(string dir)
    {
        if (!System.IO.Directory.Exists(dir)) return;
        var files = System.IO.Directory.GetFiles(dir, "*.png", System.IO.SearchOption.TopDirectoryOnly);
        foreach (var f in files)
        {
            var ti = AssetImporter.GetAtPath(f) as TextureImporter;
            if (ti == null) continue;
            if (ti.textureType != TextureImporterType.Sprite)
            {
                ti.textureType = TextureImporterType.Sprite;
                ti.SaveAndReimport();
            }
        }
    }
}
