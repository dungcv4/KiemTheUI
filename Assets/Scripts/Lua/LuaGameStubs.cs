using MoonSharp.Interpreter;
using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Stub các game system mà Lua gọi (me.*, FightSkill.*, MedicineMgr.*, etc.)
/// Trả về dummy data để UI hoạt động mà không cần server.
/// </summary>
public static class LuaGameStubs
{
    public static void RegisterAll(Script script)
    {
        // === Player "me" ===
        var me = new Table(script);
        me["nLevel"] = 80;
        me["nFaction"] = 1;
        me["nFactionSect"] = 1;
        me["nRideState"] = 0;
        me["nFightMode"] = 1;
        me["nTotalLevel"] = 80;
        me["nPortrait"] = 1;
        me["bStartAutoPath"] = false;
        me["nMapTemplateId"] = 1;
        me["CenterMsg"] = DynValue.NewCallback((ctx, args) => {
            string msg = args.Count > 0 ? args[0].CastToString() : "";
            Debug.Log($"[Lua:CenterMsg] {msg}");
            return DynValue.Nil;
        });
        me["GetDoing"] = DynValue.NewCallback((ctx, args) => DynValue.NewNumber(0));
        me["GetSkillLevel"] = DynValue.NewCallback((ctx, args) => DynValue.NewNumber(10));
        me["GetNpc"] = DynValue.NewCallback((ctx, args) => {
            var npc = new Table(script);
            npc["i64CurLife"] = 85000;
            npc["i64MaxLife"] = 100000;
            npc["i64CurHP"] = 50000;
            npc["i64MaxHP"] = 100000;
            npc["i64CurMana"] = 30000;
            npc["i64MaxMana"] = 60000;
            npc["nId"] = 1;
            npc["GetDistance"] = DynValue.NewCallback((c2, a2) => DynValue.NewNumber(100));
            npc["GetRideHorseUsePoint"] = DynValue.NewCallback((c2, a2) => DynValue.NewTuple(DynValue.False, DynValue.NewNumber(0), DynValue.NewNumber(0)));
            npc["GetRideHorseNextCastTime"] = DynValue.NewCallback((c2, a2) => DynValue.NewTuple(DynValue.NewNumber(0), DynValue.NewNumber(0)));
            npc["GetAllSkillState"] = DynValue.NewCallback((c2, a2) => DynValue.NewTable(script));
            npc["GetSkillState"] = DynValue.NewCallback((c2, a2) => DynValue.Nil);
            npc["GetDir"] = DynValue.NewCallback((c2, a2) => DynValue.NewNumber(128));
            npc["GetSkillUsePoint"] = DynValue.NewCallback((c2, a2) => DynValue.NewTuple(DynValue.False, DynValue.NewNumber(0), DynValue.NewNumber(0)));
            npc["GetSkillNextCastTime"] = DynValue.NewCallback((c2, a2) => DynValue.NewTuple(DynValue.NewNumber(0), DynValue.NewNumber(0)));
            npc["GetQingKungUsePoint"] = DynValue.NewCallback((c2, a2) => DynValue.NewTuple(DynValue.False, DynValue.NewNumber(0), DynValue.NewNumber(0)));
            npc["GetQingKungNextCastTime"] = DynValue.NewCallback((c2, a2) => DynValue.NewTuple(DynValue.NewNumber(0), DynValue.NewNumber(0)));
            return DynValue.NewTable(npc);
        });
        me["GetWorldPos"] = DynValue.NewCallback((ctx, args) => DynValue.NewTuple(DynValue.NewNumber(1), DynValue.NewNumber(500), DynValue.NewNumber(500)));
        me["GetVipLevel"] = DynValue.NewCallback((ctx, args) => DynValue.NewNumber(3));
        me["dwID"] = 10001;
        me["szName"] = "Hiệp Khách";
        me["nSex"] = 1;
        me["i64CurHP"] = 50000;
        me["i64MaxHP"] = 100000;
        me["i64CurMana"] = 30000;
        me["i64MaxMana"] = 60000;
        me["nCurExp"] = 1500000;
        me["nMaxExp"] = 5000000;
        me["nPKMode"] = 0;
        me["nPkMode"] = 0;
        me["dwTongId"] = 0;
        me["dwKinId"] = 0;
        me["dwKinBossId"] = 0;
        me["GetItemCountInBags"] = DynValue.NewCallback((ctx, args) => DynValue.NewNumber(99));
        me["GetItemCountByTypeInBag"] = DynValue.NewCallback((ctx, args) => DynValue.NewNumber(0));
        me["GetEquipByPos"] = DynValue.NewCallback((ctx, args) => DynValue.Nil);
        me["GetItemListInBag"] = DynValue.NewCallback((ctx, args) => DynValue.NewTable(script));
        me["GetExp"] = DynValue.NewCallback((ctx, args) => DynValue.NewNumber(1500000));
        me["GetNextLevelExp"] = DynValue.NewCallback((ctx, args) => DynValue.NewNumber(5000000));
        me["SwitchRide"] = DynValue.NewCallback((ctx, args) => DynValue.Nil);
        me["UseSkill"] = DynValue.NewCallback((ctx, args) => DynValue.Nil);
        me["IsMaskPlayerAttr"] = DynValue.NewCallback((ctx, args) => DynValue.False);
        me["GetUserValue"] = DynValue.NewCallback((ctx, args) => DynValue.NewNumber(0));
        me["GetVipLevel"] = DynValue.NewCallback((ctx, args) => DynValue.NewNumber(0));
        script.Globals["me"] = me;

        // === Ui global ===
        var ui = new Table(script);
        ui["bInZone"] = false;
        ui["UISkillCountDown"] = DynValue.NewString("UISkillCountDown");
        ui["ManualSkillCaster"] = DynValue.NewString("ManualSkillCaster");
        
        // Ui.tbSettingType
        var settingType = new Table(script);
        var castTypeEnum = new Table(script);
        castTypeEnum["Action"] = 1;
        castTypeEnum["Auto"] = 0;
        settingType["tbCastTypeEnum"] = castTypeEnum;
        ui["tbSettingType"] = settingType;
        
        // Ui.PlayerPrefs
        var playerPrefs = new Table(script);
        playerPrefs["GetInt"] = DynValue.NewCallback((ctx, args) => {
            string key = args.Count > 0 ? args[0].CastToString() : "";
            int def = args.Count > 1 ? (int)args[1].Number : 0;
            return DynValue.NewNumber(def);
        });
        ui["PlayerPrefs"] = playerPrefs;
        
        // Reuse existing Ui table if set
        var existingUi = script.Globals.Get("Ui");
        if (existingUi.Type == DataType.Table)
        {
            // Merge our defaults
            foreach (var kv in ui.Pairs)
                existingUi.Table.Set(kv.Key, kv.Value);
        }
        else
        {
            script.Globals["Ui"] = ui;
        }
        
        // Ui.GameEnv
        var gameEnv = new Table(script);
        gameEnv["EnableAutoTest"] = false;
        ui["GameEnv"] = gameEnv;

        // === FightSkill ===
        var fightSkill = new Table(script);
        fightSkill["IsFactionSkillStatus"] = DynValue.NewCallback((ctx, args) => DynValue.True);
        fightSkill["IsCustomSkillStatus"] = DynValue.NewCallback((ctx, args) => DynValue.False);
        fightSkill["IsDragonBoatSkillStatus"] = DynValue.NewCallback((ctx, args) => DynValue.False);
        fightSkill["IsKeYiMenSkillStatus"] = DynValue.NewCallback((ctx, args) => DynValue.False);
        fightSkill["IsTongBattleSkillStatus"] = DynValue.NewCallback((ctx, args) => DynValue.False);
        fightSkill["IsActiveSkill"] = DynValue.NewCallback((ctx, args) => DynValue.True);
        fightSkill["GetHRSSubType"] = DynValue.NewCallback((ctx, args) => DynValue.NewNumber(0));
        fightSkill["GetPlayerOneSkillInfoWithoutConfig"] = DynValue.NewCallback((ctx, args) => DynValue.Nil);
        fightSkill["GetDynamicPlayerOneSkillWithoutConfig"] = DynValue.NewCallback((ctx, args) => DynValue.Nil);
        fightSkill["CheckAFKShow"] = DynValue.NewCallback((ctx, args) => DynValue.True);
        fightSkill["GetFactionSkill"] = DynValue.NewCallback((ctx, args) => DynValue.NewTable(script));
        fightSkill["GetSkillIconAtlas"] = DynValue.NewCallback((ctx, args) => DynValue.NewString(""));
        fightSkill["IsSpecialSkillStatus"] = DynValue.NewCallback((ctx, args) => DynValue.False);
        var fsTerms = new Table(script);
        fsTerms["LevelRequire"] = "Cần cấp {0}";
        fightSkill["Terms"] = fsTerms;
        
        var skillCasterType = new Table(script);
        skillCasterType["none"] = 0;
        skillCasterType["castingaoe"] = 1;
        skillCasterType["castingdir"] = 2;
        skillCasterType["dir"] = 3;
        skillCasterType["aoe"] = 4;
        fightSkill["SkillCasterType"] = skillCasterType;
        
        var hrsSubType = new Table(script);
        hrsSubType["DynamicSkill"] = 100;
        hrsSubType["CustomSkill"] = 200;
        fightSkill["HRS_SUBTYPE_LIST"] = hrsSubType;
        fightSkill["HRS_SKILL_ID_LIST"] = new Table(script);
        fightSkill["HRS_CAST_TYPE_LIST"] = new Table(script);
        fightSkill["HRS_SAVE_KEY"] = "HRS";
        
        var allSkillSetting = new Table(script);
        fightSkill["tbAllSkillSetting"] = allSkillSetting;
        
        script.Globals["FightSkill"] = fightSkill;

        // === MedicineMgr ===
        var medicineMgr = new Table(script);
        medicineMgr["nDefaultMedicineTId"] = 1001;
        medicineMgr["CheckCDEnd"] = DynValue.NewCallback((ctx, args) => DynValue.True);
        medicineMgr["HasMedicineLeft"] = DynValue.NewCallback((ctx, args) => DynValue.True);
        medicineMgr["HasMedicine"] = DynValue.NewCallback((ctx, args) => DynValue.True);
        medicineMgr["UseMedicine"] = DynValue.NewCallback((ctx, args) => {
            Debug.Log("[Lua] 💊 Sử dụng thuốc");
            return DynValue.Nil;
        });
        medicineMgr["OpenShop"] = DynValue.NewCallback((ctx, args) => DynValue.Nil);
        script.Globals["MedicineMgr"] = medicineMgr;

        // === Operation ===
        var operation = new Table(script);
        operation["SwitchAttackTargetManual"] = DynValue.NewCallback((ctx, args) => {
            Debug.Log("[Lua] 🎯 Switch target");
            return DynValue.Nil;
        });
        operation["OnDialogerClicked"] = DynValue.NewCallback((ctx, args) => DynValue.Nil);
        operation["SetNpcSelected"] = DynValue.NewCallback((ctx, args) => DynValue.Nil);
        operation["GetAttackTarget"] = DynValue.NewCallback((ctx, args) => DynValue.NewNumber(0));
        operation["UseSkillToDir"] = DynValue.NewCallback((ctx, args) => DynValue.Nil);
        operation["UseSkillToPos"] = DynValue.NewCallback((ctx, args) => DynValue.Nil);
        operation["SkillCheckHorseLimited"] = DynValue.NewCallback((ctx, args) => DynValue.Nil);
        script.Globals["Operation"] = operation;

        // === EventNotify ===
        var eventNotify = new Table(script);
        eventNotify["OnNotify"] = DynValue.NewCallback((ctx, args) => {
            string evt = args.Count > 0 ? args[0].CastToString() : "?";
            Debug.Log($"[Lua:Event] {evt}");
            // emNOTIFY_UILOGINBG_ACTION dispatches avatar swaps for UICreateRole.
            // Lua call shape: OnNotify(eventName, action, factionId, sex)
            //   action = "PlayDuo"(fid)       → spawn both M+F avatars (faction picked)
            //   action = "Select" (fid, sex)  → fire action animation on chosen sex
            // Both go through Apply(); PlayDuo defaults sex=1 so both prefabs
            // mount immediately, and Select fires the action on the chosen one.
            // NOTE: emNOTIFY_UILOGINBG_ACTION is now handled directly by C#
            // CreateRoleRuntimeBridge → UICreateRoleAvatarController.Apply().
            // Lua fires this event with its own nCurFactionId which becomes stale
            // when faction is changed via C# buttons. Ignoring the Lua event
            // prevents stale-faction overrides (e.g. always resetting to faction 20).
            if (evt == "emNOTIFY_UILOGINBG_ACTION")
            {
                string action = args.Count > 1 && args[1].Type == DataType.String ? args[1].String : "";
                Debug.Log($"[Lua:Event] emNOTIFY_UILOGINBG_ACTION action={action} (ignored, C# handles Apply)");
            }
            return DynValue.Nil;
        });
        // No-op event subscription. Game systems are stubs in editor mode,
        // so we don't dispatch events; just keep the API surface.
        eventNotify["RegistNotify"] = DynValue.NewCallback((ctx, args) => DynValue.Nil);
        eventNotify["UnRegistNotify"] = DynValue.NewCallback((ctx, args) => DynValue.Nil);
        eventNotify["FireNotify"] = DynValue.NewCallback((ctx, args) => DynValue.Nil);
        // Pre-fill ALL event IDs (extracted from Lua files)
        string[] events = {
            "EMNOTIFY_WULINGAOSHOU_STATUS_REPLY",
            "emNOTIFY_ADD_SKILL", "emNOTIFY_ADD_SKILL_STATE",
            "emNOTIFY_AFK_MANUAL_OPEN_CLOSE", "emNOTIFY_BOSS_HP_CLOSE", "emNOTIFY_BOSS_HP_OPEN",
            "emNOTIFY_CADPA_ONOFF", "emNOTIFY_CHANGE_AFK_STATE", "emNOTIFY_CHANGE_EQUIP_MASK_STATE",
            "emNOTIFY_CHANGE_FACTION", "emNOTIFY_CHANGE_FIGHT_STATE", "emNOTIFY_CHANGE_FUBEN_BUTTON",
            "emNOTIFY_CHANGE_FUBEN_REDPACKET_BUTTON", "emNOTIFY_CHANGE_LEAVE_BUTTON",
            "emNOTIFY_CHANGE_PK_MODE", "emNOTIFY_CHANGE_PLAYER_EXP", "emNOTIFY_CHANGE_PLAYER_FACTION",
            "emNOTIFY_CHANGE_PLAYER_FACTION_SECT", "emNOTIFY_CHANGE_PLAYER_HP",
            "emNOTIFY_CHANGE_PLAYER_LEVEL", "emNOTIFY_CHANGE_PLAYER_MP", "emNOTIFY_CHANGE_PORTRAIT",
            "emNOTIFY_CHANGE_REPORT_BUTTON", "emNOTIFY_CHAT_COLOR_MSG", "emNOTIFY_CHAT_DATA_CHANGE",
            "emNOTIFY_CHAT_LINK_UPDATE", "emNOTIFY_CHAT_NEW_MSG", "emNOTIFY_CHAT_ROOM_STATUS",
            "emNOTIFY_CROSS_DAYS", "emNOTIFY_DEL_ITEM", "emNOTIFY_FIGHT_POWER_CHANGE",
            "emNOTIFY_FIRST_RECHARGE_THREEDAY", "emNOTIFY_HANWUYIJI_IN_MATCH",
            "emNOTIFY_HIDE_QUESTIONNAIRE_BUTTON", "emNOTIFY_HOOK_ONLINE_START", "emNOTIFY_HOOK_ONLINE_STOP",
            "emNOTIFY_HRS_REMOVE_SKILL", "emNOTIFY_HRS_SETTING_SKILL", "emNOTIFY_HRS_SUBTYPE_MODIFICATION",
            "emNOTIFY_LOCALIZE_CHANGE", "emNOTIFY_LOGIN_ZONE", "emNOTIFY_LOGOUT_ZONE",
            "emNOTIFY_MAP_ENTER", "emNOTIFY_MAP_LEAVE", "emNOTIFY_MAP_LOADED", "emNOTIFY_MAP_UI_LOADED",
            "emNOTIFY_MEDICINE_INFO_UPDATE", "emNOTIFY_NOTIFY_MEDICINE_CD", "emNOTIFY_NOTIFY_NEW_MAIL",
            "emNOTIFY_NOTIFY_PROCESS_MSG", "emNOTIFY_NPC_IN_TALK_RANGE", "emNOTIFY_NPC_LEVEL_CHANGE",
            "emNOTIFY_NPC_NOT_IN_TALK_RANGE", "emNOTIFY_ONACTIVITY_STATE_CHANGE",
            "emNOTIFY_ON_CLICK_GOTO_TASK", "emNOTIFY_ON_CLOSE_HUD_RIGHT_BOTTOM",
            "emNOTIFY_OPEN_MEDICINESHOP_FAIL", "emNOTIFY_OPEN_MEDICINESHOP_SUCCESS",
            "emNOTIFY_PLAYER_LOGIN", "emNOTIFY_PORTRAIT_FRAME_CHANGE", "emNOTIFY_PRIVATE_MSG_NUM_CHANGE",
            "emNOTIFY_QINSHIHUANGLING_SYNC_STATE", "emNOTIFY_QUICK_TEAM_UPDATE",
            "emNOTIFY_REMOVE_SKILL_STATE", "emNOTIFY_ROLE_HP_CHANGE",
            "emNOTIFY_SHOP_LEVEL_LIMIT_ONOFF", "emNOTIFY_SHOW_QUESTIONNAIRE_BUTTON",
            "emNOTIFY_SKILL_LEVELUP", "emNOTIFY_SUMMERFASHING_BAIT_SYNC",
            "emNOTIFY_SUPER_VIEW_REFRESH", "emNOTIFY_SWITCH_SKILL_CAST_TYPE",
            "emNOTIFY_SYNC_BATTLE_REPORT", "emNOTIFY_SYNC_BATTLE_TIME",
            "emNOTIFY_SYNC_GUANFUTONGJI_DATA", "emNOTIFY_SYNC_ITEM", "emNOTIFY_SYNC_JIANXIACIDIAN_DATA",
            "emNOTIFY_SYNC_KIN_DATA", "emNOTIFY_SYNC_LEGION_BASEINFO", "emNOTIFY_SYNC_LEGION_DOMAIN_SCORE",
            "emNOTIFY_SYNC_MAP_POINT", "emNOTIFY_SYNC_MARRY_DATA", "emNOTIFY_SYNC_REDPACKET",
            "emNOTIFY_SYNC_TIEFUCHENG_SCORE", "emNOTIFY_SYNC_TONG_BASEINFO",
            "emNOTIFY_SYNC_TONG_DOMAIN_SCORE", "emNOTIFY_SYNC_TONG_MEMBERLIST", "emNOTIFY_SYNC_TONG_QUIT",
            "emNOTIFY_SYNC_YIJUNTASK_DATA", "emNOTIFY_SYN_DLC_GIFT_DATA",
            "emNOTIFY_TEAM_CLEAR_INVITE", "emNOTIFY_TEAM_REMOVE_INVITE", "emNOTIFY_TEAM_UPDATE",
            "emNOTIFY_TREASURE_CHEST_ONOFF", "emNOTIFY_TRY_SWITCH_RIGHT_HUD_PANEL",
            "emNOTIFY_TRY_USE_JUMP", "emNOTIFY_TRY_USE_SKILL",
            "emNOTIFY_UILOGINBG_ACTION",
            "emNOTIFY_UISetting_ACTIVE_KEYBOARD_TIPS", "emNOTIFY_UI_UIHUDTIP_UPDATE",
            "emNOTIFY_UPDATE_COMMERCETASK", "emNOTIFY_UPDATE_KINFREIGHTTASK_DATA",
            "emNOTIFY_UPDATE_TASK", "emNOTIFY_USE_SKILL", "emNOTIFY_USE_UNUSE_EQUIP",
            "emNOTIFY_VIP_LEVEL_CHANGE", "emNOTIFY_WELFARE_PANEL_CLOSE", "emNOTIFY_WELFARE_PANEL_OPEN",
            "emNOTIFY_XIULIAN_JIUSTATE_CHANGE", "emNOTIYF_FOLLOW_STATE_UPDATE",
            "emNoTIFY_NEW_PRIVATE_MSG", "emNoTIFY_QINGKUNG_CD", "emNoTIFY_QINGKUNG_USEPOINT_CHANGED",
            "emNoTIFY_RIDEHORSE_CD", "emNoTIFY_RIDEHORSE_USEPOINT_CHANGED",
            "emNoTIFY_SKILL_CD", "emNoTIFY_SKILL_USEPOINT_CHANGED", "emNoTIFY_SYNC_FRIEND_DATA"
        };
        for (int i = 0; i < events.Length; i++)
            eventNotify[events[i]] = events[i];
        script.Globals["EventNotify"] = eventNotify;

        // === RedPointMgr ===
        var redPoint = new Table(script);
        redPoint["DynamicRegisteRedPoint"] = DynValue.NewCallback((ctx, args) => DynValue.Nil);
        redPoint["DynamicUnRegist"] = DynValue.NewCallback((ctx, args) => DynValue.Nil);
        redPoint["LightRedPoint"] = DynValue.NewCallback((ctx, args) => DynValue.Nil);
        redPoint["FadeRedPoint"] = DynValue.NewCallback((ctx, args) => DynValue.Nil);
        redPoint["ChangeRedPointPositionLeft"] = DynValue.NewCallback((ctx, args) => DynValue.Nil);
        var eventTbl = new Table(script);
        // Fill common event IDs with sequential numbers
        string[] rpEvents = {
            "FactionSkill", "SecretBookLevelEnough", "SecretBookCanLevelUp",
            "KinSkill", "FactionSkillExtend", "ZongShiSkill",
            "TongManager", "TongCostRedBag", "TongYuanBaoRedBagRecv",
            "TongYuanBaoRedBagSend", "DomainBattleOpen", "OfficialMaintain",
            "OfficialBuy", "TongApply", "TongAppraise",
            "ResourceBattleMining_CanMine", "KinSalary", "KinCostRedBag",
            "KinYuanBaoRedBagRecv", "KinYuanBaoRedBagSend", "KinGiftGain",
            "KinApply", "KinShop", "KinFreightTask", "KinBuilding",
            "HelmEnhance", "AmuletEnhance", "HelmJingZhu", "AmuletJingZhu",
            "HelmLianHua", "AmuletLianHua", "HelmStoneInsert", "AmuletStoneInsert",
            "HelmQiHun", "AmuletQiHun", "ZhenYuanMetal", "ZhenYuanLianHuaHuTi",
            "HorseLevel", "ZhenFaLevelUp", "FashionPrettyStageAward",
            "ZhenFaZJLevelUpBegin", "ZhenFaZJLevelUpEnd",
            "HorseEquipGrade1", "GuanYin", "WuXingYin", "WuXingYinEquipLvUp",
            "WuXingYinEnhanceLvUp", "WuXingYinabateLvUp",
            "ShenBingBagEntrance", "LifeSkill", "Achievement", "HonorLevelUp",
            "CardPickCoinFree", "CardPickYuanBaoFree", "CardPickLimitedFree",
            "PartnerFriend", "PartnerOperation", "PartnerCanInPos",
            "PartnerSKillBookPick", "PartnerXiSui", "PartnerEquipBetter",
            "PartnerEquipCanEnhance", "PartnerEquipCanReforge",
            "PartnerZFDailyRemind", "PartnerZFActivate", "PartnerSetPos",
            "WuLinHonorSongJing", "WuLinHonorArena", "WuLinHonorFactionBattle",
            "WuLinHonorZhaiXingLou", "WuLinHonorHanWuYiJi", "WuLinHonorMultiPvP",
            "Stronger1", "Stronger2", "Stronger3",
            "PotentialPointLeft", "NewPortrait", "NewPortraitFrame",
            "NewSpeechBalloon", "NewChatTitlePrefix"
        };
        for (int i = 0; i < rpEvents.Length; i++)
            eventTbl[rpEvents[i]] = i + 1;
        redPoint["EVENT"] = eventTbl;
        script.Globals["RedPointMgr"] = redPoint;

        // === Timer ===
        var timer = new Table(script);
        int _timerId = 0;
        timer["Register"] = DynValue.NewCallback((ctx, args) => {
            _timerId++;
            return DynValue.NewNumber(_timerId);
        });
        timer["Close"] = DynValue.NewCallback((ctx, args) => DynValue.Nil);
        script.Globals["Timer"] = timer;

        // === Env ===
        var env = new Table(script);
        env["GAME_FPS"] = 30;
        script.Globals["Env"] = env;

        // === Npc constants ===
        var npc = new Table(script);
        npc["nSitSkillId"] = 9999;
        npc["PLAYER_ROLEHEADPOP_DISTANCE"] = 30;
        var doing = new Table(script);
        doing["sit"] = 1; doing["stand"] = 0; doing["run"] = 2; doing["skill"] = 3;
        npc["Doing"] = doing;
        var fightMode = new Table(script);
        fightMode["emFightMode_None"] = 0;
        npc["FIGHT_MODE"] = fightMode;
        var pkMode = new Table(script);
        pkMode["emPK_MODE_PEACE"] = 0; pkMode["emPK_MODE_KILLER"] = 1; pkMode["emPK_MODE_KIN"] = 2;
        npc["PK_MODE"] = pkMode;
        var campType = new Table(script);
        campType["camp_type_neutrality"] = 0; campType["camp_type_justice"] = 1; campType["camp_type_evil"] = 2;
        npc["CampTypeDef"] = campType;
        // Sex definitions (used by UICreateRole)
        var sexDef = new Table(script);
        sexDef["MALE"] = 1;
        sexDef["FEMALE"] = 2;
        npc["SexDef"] = sexDef;
        // 5-elements series enum (used by UICreateRole)
        var seriesType = new Table(script);
        seriesType["SERIES_METAL"] = 1;
        seriesType["SERIES_WOOD"] = 2;
        seriesType["SERIES_WATER"] = 3;
        seriesType["SERIES_FIRE"] = 4;
        seriesType["SERIES_EARTH"] = 5;
        npc["emSERIES_TYPE"] = seriesType;
        script.Globals["Npc"] = npc;

        // === Faction (UICreateRole / faction list) ===
        // Canonical id → (series, suffix, vietnamese name, desc) mapping from
        // game_data/extracted_tabs/dat_549_nId_15c_21r.tab (Setting/Faction/faction.tab).
        // Series enum (matches Npc.emSERIES_TYPE):
        //   1=Metal/Kim, 2=Wood/Mộc, 3=Water/Thủy, 4=Fire/Hỏa, 5=Earth/Thổ
        // Suffix matches the Faction_<suffix> GameObject in the prefab and
        // faction_<suffix>.png / img_factioninfo_<suffix>.png sprite assets.
        var faction = new Table(script);
        faction["MAX_FACTION_COUNT"] = 20;
        var factionSeries = new int[] {
            1, 1, 2, 2, 3, 3, 4, 4, 5, 5,   // 1..10:  shaolin, tianwang, tangmen, wudu, emei, cuiyan, gaibang, tianren, wudang, kunlun
            2, 3, 5, 1, 4, 2, 3, 5, 1, 4    // 11..20: mingjiao, duanshi, gumu, badao, xiaoyao, baituosha, taohua, changge, YiPinTang, WuHuntang
        };
        // Suffix used for both faction_<suffix>.png icons and Faction_<suffix> GO names.
        // Cases preserved from the asset filenames (YiPinTang/WuHuntang are mixed-case).
        var factionSuffix = new string[] {
            "shaolin", "tianwang", "tangmen", "wudu", "emei",
            "cuiyan", "gaibang", "tianren", "wudang", "kunlun",
            "mingjiao", "duanshi", "gumu", "badao", "xiaoyao",
            "baituosha", "taohua", "changge", "YiPinTang", "WuHuntang"
        };
        // Radar chart suffix can differ in spelling — derived from the tab's szRadarChartPath:
        //   img_factioninfo_baituoshan.png (note "baituoshan" vs Faction_baituosha)
        //   img_factioninfo_YiPintang.png  (lowercase "tang")
        var factionRadarSuffix = new string[] {
            "shaolin", "tianwang", "tangmen", "wudu", "emei",
            "cuiyan", "gaibang", "tianren", "wudang", "kunlun",
            "mingjiao", "duanshi", "gumu", "badao", "xiaoyao",
            "baituoshan", "taohua", "changge", "YiPintang", "WuHuntang"
        };
        var factionNames = new string[] {
            "Thiếu Lâm", "Thiên Vương", "Đường Môn", "Ngũ Độc", "Nga Mi",
            "Thúy Yên", "Cái Bang", "Thiên Nhẫn", "Võ Đang", "Côn Lôn",
            "Minh Giáo", "Đoàn Thị", "Cổ Mộ", "Bá Đao", "Tiêu Dao",
            "Bạch Đà Sơn", "Đào Hoa", "Trường Ca", "Nhất Phẩm Đường", "Vũ Huân Đường"
        };
        faction["IsFactionOpen"] = DynValue.NewCallback((c, a) => {
            int id = a.Count > 1 ? (int)a[1].Number : 0;
            return DynValue.NewBoolean(id >= 1 && id <= 20);
        });
        faction["GetSeries"] = DynValue.NewCallback((c, a) => {
            int id = a.Count > 1 ? (int)a[1].Number : 0;
            if (id < 1 || id > 20) return DynValue.NewNumber(1);
            return DynValue.NewNumber(factionSeries[id - 1]);
        });
        faction["IsOpenSex"] = DynValue.NewCallback((c, a) => {
            // All factions in our build support both sexes (tab has nOpenType=3 = both bits)
            return DynValue.True;
        });
        faction["GetIcon"] = DynValue.NewCallback((c, a) => {
            int id = a.Count > 1 ? (int)a[1].Number : 1;
            if (id < 1 || id > 20) return DynValue.NewString("");
            return DynValue.NewString($"faction_{factionSuffix[id - 1]}");
        });
        faction["GetHudIcon"] = DynValue.NewCallback((c, a) => {
            int id = a.Count > 1 ? (int)a[1].Number : 1;
            if (id < 1 || id > 20) return DynValue.NewString("");
            return DynValue.NewString($"hud_{factionSuffix[id - 1]}");
        });
        var factionDescs = new string[] {
            // Extracted from pack0.dat i18n table (XOR-decrypted)
            "Võ công thiên hạ đều xuất phát từ Thiếu Lâm. Đệ tử Phật môn Thiếu Lâm ngũ uẩn giai không, lấy thiền nhập võ, độ thế nhân kiếp.",
            "Thiên Vương Bang vốn nổi danh giang hồ. Từ sau khi Dương Thiết Tâm kế nhiệm Bang Chủ, tuyên bố chiêu hiền nạp tài không câu nệ nam nữ, từ nay về sau đệ tử Thiên Vương rải khắp bốn biển, xông pha vào loạn thế.",
            "Thục Trung Đường Môn nổi danh với ám khí, cơ quan và dùng độc. Cơ quan không phát ra tiếng động chứa đầy kịch độc, một kích trúng mục tiêu, giang hồ đều biến sắc.",
            "Sau khi bị Tuyệt Sát Lệnh, Ngũ Độc lẫn vào vùng man hoang độc chướng để gây dựng thế lực. Ngũ Độc thường dùng Thi Độc Thuật giết người vô hình, trở thành môn phái không ai muốn đắc tội.",
            "Nga Mi nằm ở danh sơn thanh tú linh thiêng, võ công Nga Mi vừa nhu vừa cương, nội ngoại song tu, xa gần đều tinh, môn hạ đệ tử chỉ có nữ nhân.",
            "Thúy Yên Môn xưa nay ẩn mình, võ công tuyệt diệu, thân pháp linh động, tự tại như tiên. Đệ tử Thúy Yên khoác trên mình chiếc áo không nhiễm bụi trần, làm cho người đời đều mơ ước.",
            "Đệ tử Cái Bang đều đến từ trong phố xá, không câu nệ tiểu tiết, tự do thẳng thắn. Ở thời loạn thế, Cái Bang luôn diệt ác, trừ tham, chống địch, sau trở thành bậc thái đẩu võ lâm.",
            "Thiên Nhẫn có vô số cao thủ, nội lực thâm hậu. Vốn không phân chính tà, nhưng vì nội tình to lớn, khiến cho Thiên Nhẫn trở thành lực lượng chính của nước Kim dùng đối phó các môn phái võ lâm.",
            "Võ công Võ Đang có nguồn gốc sâu xa, nhẹ nhàng ảo diệu, không chủ tấn công, là đại tông phái của võ lâm. Đệ tử Võ Đang nổi tiếng hiệp nghĩa, cùng đồng môn cũng vô cùng trọng tình.",
            "Côn Lôn tôn sùng võ dũng, hùng cứ Tây Vực, ít khi bước vào trung nguyên. Sau này Côn Lôn không ngừng lớn mạnh, dần trở thành một môn phái lớn, sánh ngang với các phái khác trong võ lâm.",
            "Giáo lý Minh Giáo lấy cứu khổ vạn dân làm nhiệm vụ, giúp đỡ chúng sinh trong bể lửa, trong loạn thế được dân chúng tín nhiệm. Chí hướng của giáo chúng là làm thiện trừ ác, cứu rỗi thế nhân.",
            "Đoàn Thị vốn là người võ lâm, sau thành lập Đại Lý. Võ học nhiều đời tương truyền, vô cùng thâm sâu, khí thế mạnh mẽ, thực chiến thượng thừa.",
            "Phái Cổ Mộ do kỳ tài võ học Lâm Triều Anh sáng lập. Đệ tử Cổ Mộ đều lạnh lùng, tĩnh lặng. Chiêu thức võ công vô cùng linh hoạt, biến hóa khôn lường, khiến nhân sĩ võ lâm phải kiêng dè.",
            "Bá Đao Sơn Trang quy định nghiêm ngặt, tương truyền là hậu duệ của Võ Thánh, đệ tử môn hạ thượng võ trọng nghĩa, hành sự tự do, sau khi bị chạm tới giới hạn sẽ không còn chỗ vãn hồi.",
            "Trăm năm trước, có kẻ sống sót trong lúc tuyệt vọng ở vùng đất cực lạnh Bắc Minh. Tình cờ, hắn lĩnh ngộ được Bắc Minh Thần Công, lập ra Tiêu Dao Phái. Tiêu Dao võ học phiêu dật, nhất cử nhất động đều phi phàm.",
            "Chiêu thức võ học của Bạch Đà Sơn, xuất chiêu nhanh mạnh, các môn nhân có thực lực mạnh, hành sự bí hiểm, là một phái mạnh của Tây Vực.",
            "\"Đào hoa ảnh lạc phi thần kiếm, bích hải triều sinh án ngọc tiêu\", võ học Đào Hoa nổi tiếng khắp giang hồ về sự đa dạng và có uy lực cực mạnh.",
            "Trường Ca Môn gồm các văn sĩ hào nho võ nghệ cao cường, văn võ song toàn, thích hành hiệp trượng nghĩa, nghĩ cho thiên hạ, luôn kết hợp sức mạnh võ lâm chống lại quân địch.",
            "Nhất Phẩm Đường thuộc Tây Hạ, đệ tử trong môn phái giỏi về quyền pháp và đao pháp, khi chiến đấu xuất chiêu mạnh mẽ, xông pha trận mạc, tiến lui không ngại.",
            "Võ Hồn Đường vào quân đội để quy ẩn giang hồ, giỏi tấn công lẫn phòng thủ, ra sa trường bảo vệ nước nhà, lánh khỏi giang hồ diệt đạo tặc."
        };
        faction["GetDesc"] = DynValue.NewCallback((c, a) => {
            int id = a.Count > 1 ? (int)a[1].Number : 1;
            if (id < 1 || id > 20) return DynValue.NewString("");
            return DynValue.NewString(factionDescs[id - 1]);
        });
        faction["GetRadarChartPath"] = DynValue.NewCallback((c, a) => {
            int id = a.Count > 1 ? (int)a[1].Number : 1;
            if (id < 1 || id > 20) return DynValue.NewString("");
            return DynValue.NewString($"img_factioninfo_{factionRadarSuffix[id - 1]}");
        });
        faction["GetName"] = DynValue.NewCallback((c, a) => {
            int id = a.Count > 1 ? (int)a[1].Number : 1;
            if (id < 1 || id > 20) return DynValue.NewString("?");
            return DynValue.NewString(factionNames[id - 1]);
        });
        script.Globals["Faction"] = faction;

        // === Login (UICreateRole) ===
        var login = new Table(script);
        login["ServerName"] = "Thiên Long";
        login["CheckNameinValid"] = DynValue.NewCallback((c, a) => {
            if (a.Count < 2) return DynValue.False;
            var s = a[1].CastToString();
            return DynValue.NewBoolean(!string.IsNullOrEmpty(s) && s.Length >= 2 && s.Length <= 12);
        });
        login["GetRandomName"] = DynValue.NewCallback((c, a) => {
            string[] pool = { "Hiệp Khách", "Lãng Tử", "Phi Yến", "Thanh Vân", "Tuyết Nhi",
                              "Mộc Uyên", "Lăng Phong", "Băng Tâm", "Vô Danh", "Cô Độc" };
            return DynValue.NewString(pool[UnityEngine.Random.Range(0, pool.Length)]);
        });
        script.Globals["Login"] = login;

        // === Sdk (UICreateRole) ===
        // Create Sdk table eagerly if not already present (RegisterStubTable below
        // would only set it later, after this block has already run and not bound).
        var sdkDv = script.Globals.Get("Sdk");
        Table sdkTbl = sdkDv.Type == DataType.Table ? sdkDv.Table : new Table(script);
        sdkTbl["OnNamedRole"] = DynValue.NewCallback((c, a) => DynValue.Nil);
        sdkTbl["GetServerId"] = DynValue.NewCallback((c, a) => DynValue.NewNumber(1));
        sdkTbl["onEnterGame"] = DynValue.NewCallback((c, a) => DynValue.Nil);
        sdkTbl["openXgQuestionnaire"] = DynValue.NewCallback((c, a) => DynValue.Nil);
        script.Globals["Sdk"] = sdkTbl;

        // === Createrole free functions ===
        script.Globals["MathRandom"] = DynValue.NewCallback((c, a) => {
            int max = a.Count > 0 ? (int)a[0].Number : 1;
            return DynValue.NewNumber(UnityEngine.Random.Range(1, Mathf.Max(2, max + 1)));
        });
        script.Globals["CheckNameAvailable"] = DynValue.NewCallback((c, a) => DynValue.True);
        script.Globals["CreateRole"] = DynValue.NewCallback((c, a) => DynValue.Nil);
        script.Globals["LoginRole"] = DynValue.NewCallback((c, a) => DynValue.Nil);
        script.Globals["CloseServerConnect"] = DynValue.NewCallback((c, a) => DynValue.Nil);
        script.Globals["GetServerList"] = DynValue.NewCallback((c, a) => {
            var t = new Table(script);
            var s = new Table(script);
            s["dwServerId"] = 1;
            s["szName"] = "Thiên Long";
            t[1] = s;
            return DynValue.NewTable(t);
        });

        // Lib:RandTable wired below where Lib is defined

        // === Other stubs (original) ===
        RegisterStubTable(script, "Kin", "OpenKinWindow", "GetMemberData", "HasKin", "IsKinVoiceManager");
        RegisterStubTable(script, "Tong", "OpenTongWindow", "GetMemberData", "HasTong", "IsTongVoiceManager");
        RegisterStubTable(script, "Partner", "OpenPartnerMainUI");
        RegisterStubTable(script, "Horse", "nHorseEquipCount");
        script.Globals.Get("Horse").Table["nHorseEquipCount"] = 6;
        RegisterStubTable(script, "PlayerQingKung", "DoQingKung");
        var hanWuYiJi = new Table(script);
        hanWuYiJi["CheckInHanWuYiJi"] = DynValue.NewCallback((c,a) => DynValue.False);
        hanWuYiJi["FuShiTemplatedId"] = 10001;
        hanWuYiJi["EXCLUDE_ITEM"] = new Table(script);
        hanWuYiJi["MaxBagCount"] = 20;
        hanWuYiJi["RefreshEnhanceRedPoint"] = DynValue.NewCallback((c,a) => DynValue.Nil);
        hanWuYiJi["GetMemberList"] = DynValue.NewCallback((c,a) => DynValue.NewTable(script));
        hanWuYiJi["OnGiveFuShi"] = DynValue.NewCallback((c,a) => DynValue.Nil);
        hanWuYiJi["IsInFubenMap"] = DynValue.NewCallback((c,a) => DynValue.False);
        script.Globals["HanWuYiJi"] = hanWuYiJi;
        RegisterStubTable(script, "DragonBoatRace", "CheckInDragonBoatRace", "GetSkillList", "GetPlayerOneSkillInfoWithoutConfig");
        RegisterStubTable(script, "HanHaiMiCheng", "GetKeyStatus");
        // Add GetCurrentLineName to HanHaiMiCheng (returns nil = no line suffix)
        script.Globals.Get("HanHaiMiCheng").Table["GetCurrentLineName"] = DynValue.NewCallback((c,a) => DynValue.Nil);

        // Map (expanded with minimap functions)
        var map = new Table(script);
        map["IsForbidRide"] = DynValue.NewCallback((c,a) => DynValue.Nil);
        map["IsFuben"] = DynValue.NewCallback((c,a) => DynValue.False);
        map["IsZoneHangUpMap"] = DynValue.NewCallback((c,a) => DynValue.False);
        map["IsForbidMiniMap"] = DynValue.NewCallback((c,a) => DynValue.NewNumber(0));
        map["IsMiniMapShowFriend"] = DynValue.NewCallback((c,a) => DynValue.True);
        map["IsMiniMapNotShowTeam"] = DynValue.NewCallback((c,a) => DynValue.False);
        map["nShowPosScale"] = 1;
        // yunzhongzhen1_a: world X range ~4-83, Y range ~5-51
        // Minimap sprite = 960x576, MapPoint = 256x256
        // Formula: miniX = worldX / RawScale / 8 - RawWidth/2
        // RawScale tuned so center of world (43,28) maps to center of minimap
        map["GetMiniMapInfo"] = DynValue.NewCallback((c,a) => {
            var size = new Table(script);
            size["Width"] = 256; size["Height"] = 256;
            var szMiniMap = "minimap_yunzhongzhen1_a";
            var rawInfo = new Table(script);
            rawInfo["RawWidth"] = 120;
            rawInfo["RawHeight"] = 120;
            rawInfo["RawScale"] = 0.09;
            rawInfo["PadWidth"] = 10;
            rawInfo["PadHeight"] = 10;
            return DynValue.NewTuple(DynValue.NewTable(size), DynValue.NewString(szMiniMap), DynValue.NewTable(rawInfo));
        });
        map["GetMapSetting"] = DynValue.NewCallback((c,a) => {
            var setting = new Table(script);
            setting["MapName"] = "Bản đồ";
            return DynValue.NewTable(setting);
        });
        script.Globals["Map"] = map;
        RegisterStubTable(script, "Vip", "CSRoleHeadReqVipLevel", "GetVipName");
        RegisterStubTable(script, "DingFengPK", "ChkPlayerInMapEx");
        RegisterStubTable(script, "TeamMgr", "GetMember", "StopFollowMember", "HasTeam", "IsCaptain",
            "GetMembers", "GetCaptainData", "IsFollowTeammate", "StartFollowMember", "Recall", "Quite",
            "IsMatchingAct", "GetMyTeamMember", "GetTeamMembers", "IsInTeam", "GetTeamId");
        RegisterStubTable(script, "Weather", "OpenTimer", "CheckWeather");
        RegisterStubTable(script, "Stronger", "CheckOpen");
        script.Globals.Get("Stronger").Table["nFightPower"] = 120000;
        RegisterStubTable(script, "XiaKeDao", "CanAssist", "OnClientSendAssist", "GetBelongId", "GetGroup", "IsXiaKeDaoFuben");
        RegisterStubTable(script, "WuXue", "UseActiveSkill", "GetAllWuXueInstalled", "GetSkillIdByWuXueId");
        var wuxueDef = new Table(script);
        wuxueDef["nSkillGroupKey"] = 1;
        var tbSkillGroup = new Table(script);
        tbSkillGroup["CurActiveSkill"] = 1;
        wuxueDef["tbSkillGroup"] = tbSkillGroup;
        script.Globals.Get("WuXue").Table["Def"] = wuxueDef;
        RegisterStubTable(script, "RemoteServer", "ApplyChangeMode", "RestoreAction", "GoldBossReqUI", "QinShiHuangLingReqUI");
        RegisterStubTable(script, "KNpc", "GetById");
        // LocalData — needs to return the default value (2nd arg) when no entry exists,
        // otherwise lua code that does `self.x = LocalData:GetRoleNumber("k", 0)` ends up
        // with self.x = nil and arithmetic fails.
        var localData = new Table(script);
        // signature: LocalData:GetRoleNumber(key, default)
        // args: [self, key, default]
        localData["GetRoleNumber"] = DynValue.NewCallback((ctx, args) => {
            return args.Count > 2 ? args[2] : DynValue.NewNumber(0);
        });
        localData["GetRoleBoolean"] = DynValue.NewCallback((ctx, args) => {
            return args.Count > 2 ? args[2] : DynValue.False;
        });
        localData["GetRoleString"] = DynValue.NewCallback((ctx, args) => {
            return args.Count > 2 ? args[2] : DynValue.NewString("");
        });
        localData["SetRoleNumber"] = DynValue.NewCallback((c, a) => DynValue.Nil);
        localData["SetRoleBoolean"] = DynValue.NewCallback((c, a) => DynValue.Nil);
        localData["SetRoleString"] = DynValue.NewCallback((c, a) => DynValue.Nil);
        script.Globals["LocalData"] = localData;
        // Item (expanded with constants)
        var itemTbl = new Table(script);
        itemTbl["GetName"] = DynValue.NewCallback((c,a) => DynValue.NewString(""));
        itemTbl["ClientUseItem"] = DynValue.NewCallback((c,a) => DynValue.Nil);
        itemTbl["EQUIPPOS_HORSE"] = 20;
        itemTbl["EQUIPPOS_WEAPON"] = 1;
        itemTbl["EQUIPPOS_HEAD"] = 2;
        script.Globals["Item"] = itemTbl;
        RegisterStubTable(script, "OnOffController", "Check");
        var onOffKey = new Table(script);
        onOffKey["TreasureChest"] = "TreasureChest";
        onOffKey["ShopLevelLimit"] = "ShopLevelLimit";
        script.Globals.Get("OnOffController").Table["KEY"] = onOffKey;
        RegisterStubTable(script, "PlayerPortraitFrame", "GetMeCurPortraitFrameId");
        RegisterStubTable(script, "KeYiMen");
        RegisterStubTable(script, "TongBattle", "GetSkillList", "GetPlayerOneSkillInfoWithoutConfig");
        // FriendShip (expanded)
        var friendShip = new Table(script);
        friendShip["UpdateIntimacyBuff"] = DynValue.NewCallback((c,a) => DynValue.Nil);
        friendShip["GetAllFriendRequestData"] = DynValue.NewCallback((c,a) => DynValue.NewTable(script));
        friendShip["GetPlayerRemarkName"] = DynValue.NewCallback((c,a) => DynValue.NewString(""));
        friendShip["SHOW_LEVEL"] = 15;
        script.Globals["FriendShip"] = friendShip;

        RegisterStubTable(script, "JingMai", "AddJingMaiAllRedPoint");

        // === AFK ===
        var afk = new Table(script);
        afk["IsLeadFightRunning"] = DynValue.NewCallback((c,a) => DynValue.False);
        afk["IsFollowFightRunning"] = DynValue.NewCallback((c,a) => DynValue.False);
        afk["IsRunning"] = DynValue.NewCallback((c,a) => DynValue.False);
        afk["Stop"] = DynValue.NewCallback((c,a) => DynValue.Nil);
        afk["Start"] = DynValue.NewCallback((c,a) => DynValue.Nil);
        var leadFightState = new Table(script);
        leadFightState["emAutoFight"] = 1;
        leadFightState["emGoToSafePos"] = 2;
        leadFightState["emSupplyWare"] = 3;
        leadFightState["emNone"] = 0;
        leadFightState["emGoToFightPos"] = 4;
        afk["LeadFightStateTB"] = leadFightState;
        script.Globals["AFK"] = afk;

        // === Additional Ui helpers ===
        var uiGlobal = script.Globals.Get("Ui");
        if (uiGlobal.Type == DataType.Table)
        {
            // Ui.Vector2, Ui.Vector3
            uiGlobal.Table["Vector2"] = DynValue.NewCallback((c,a) => {
                var v = new Table(script);
                v["x"] = a.Count > 0 ? a[0].Number : 0;
                v["y"] = a.Count > 1 ? a[1].Number : 0;
                return DynValue.NewTable(v);
            });
            var vec3Table = new Table(script);
            vec3Table["zero"] = DynValue.NewTable(new Table(script) { ["x"] = 0, ["y"] = 0, ["z"] = 0 });
            uiGlobal.Table["Vector3"] = DynValue.NewCallback((c,a) => {
                var v = new Table(script);
                v["x"] = a.Count > 0 ? a[0].Number : 0;
                v["y"] = a.Count > 1 ? a[1].Number : 0;
                v["z"] = a.Count > 2 ? a[2].Number : 0;
                return DynValue.NewTable(v);
            });
            // Also make it indexable as table for .zero
            uiGlobal.Table["Vector3"] = vec3Table;

            // Ui.UIEventListener
            var uiEventListener = new Table(script);
            uiEventListener["Get"] = DynValue.NewCallback((c,a) => {
                var listener = new Table(script);
                listener["Click"] = DynValue.Nil;
                return DynValue.NewTable(listener);
            });
            uiGlobal.Table["UIEventListener"] = uiEventListener;

            // Ui.ContentSizeFitter, Ui.RectTransform
            uiGlobal.Table["ContentSizeFitter"] = "ContentSizeFitter";
            uiGlobal.Table["RectTransform"] = "RectTransform";

            // Ui.tbColor
            var tbColor = new Table(script);
            tbColor["GetColorHexBySettingId"] = DynValue.NewCallback((c,a) => DynValue.NewString("FFFFFF"));
            uiGlobal.Table["tbColor"] = tbColor;

            // Ui.tbNotifyMsgDatas
            uiGlobal.Table["tbNotifyMsgDatas"] = new Table(script);
            uiGlobal.Table["nUnReadNotifyMsgNum"] = 0;
        }

        // === GetServerName ===
        script.Globals["GetServerName"] = DynValue.NewCallback((c,a) => DynValue.NewString("Thiên Long"));
        script.Globals["SERVER_ID"] = 1;


        // === Client (expanded) ===
        RegisterStubTable(script, "Client");
        script.Globals.Get("Client").Table["EnableLoginCADPA"] = true;
        var clientQuality = new Table(script);
        clientQuality["GetRemainBattery"] = DynValue.NewCallback((c,a) => DynValue.NewNumber(0.85));
        script.Globals.Get("Client").Table["QualityModule"] = clientQuality;
        var clientRes = new Table(script);
        clientRes["UnLoadResourceCache"] = DynValue.NewCallback((c,a) => DynValue.Nil);
        script.Globals.Get("Client").Table["ResourceModule"] = clientRes;
        var clientUpdate = new Table(script);
        clientUpdate["GetDLCTotalSize"] = DynValue.NewCallback((c,a) => DynValue.NewNumber(0));
        clientUpdate["GetNeedDownDLCSize"] = DynValue.NewCallback((c,a) => DynValue.NewNumber(0));
        clientUpdate["GetCurDownloadedDLCSize"] = DynValue.NewCallback((c,a) => DynValue.NewNumber(0));
        clientUpdate["GetDownloadedDLCSize"] = DynValue.NewCallback((c,a) => DynValue.NewNumber(0));
        script.Globals.Get("Client").Table["UpdateModule"] = clientUpdate;

        // ========================================
        // === 28 NEW stubs extracted from Lua ===
        // ========================================

        // AutoPath
        RegisterStubTable(script, "AutoPath", "GetTargetPos", "IsPathing");

        // BattlePassNew
        RegisterStubTable(script, "BattlePassNew");
        script.Globals.Get("BattlePassNew").Table["bIsNewServer"] = false;

        // Calendar
        var calendar = new Table(script);
        var calendarRedPoint = new Table(script);
        calendarRedPoint["JiangHuZhuJiu"] = new Table(script);
        calendar["szRedPointEvent"] = calendarRedPoint;
        script.Globals["Calendar"] = calendar;

        // ChatMgr
        var chatMgr = new Table(script);
        var channelType = new Table(script);
        channelType["Public"] = 1; channelType["Private"] = 2; channelType["Team"] = 3;
        channelType["Kin"] = 4; channelType["Tong"] = 5; channelType["System"] = 6;
        channelType["World"] = 7; channelType["Camp"] = 8; channelType["Zone"] = 9;
        channelType["Nearby"] = 10; channelType["Friend"] = 11; channelType["Color"] = 12;
        channelType["Map"] = 13; channelType["Recruit"] = 14; channelType["Hawk"] = 15;
        channelType["Zone_Legion"] = 16;
        chatMgr["ChannelType"] = channelType;

        // Populate tbChannelSetting — each channel needs a sub-table with szChannelName
        var tbChannelSetting = new Table(script);
        foreach (var kvp in channelType.Pairs)
        {
            if (kvp.Value.Type == DataType.Number)
            {
                var chSetting = new Table(script);
                chSetting["szChannelName"] = kvp.Key.CastToString(); // Use key name as channel name
                tbChannelSetting[kvp.Value] = chSetting;
            }
        }
        chatMgr["tbChannelSetting"] = tbChannelSetting;

        // ChatMgr.Terms
        var chatTerms = new Table(script);
        chatTerms["SystemChannelName"] = "System";
        chatTerms["DynamicChannelName"] = "Dynamic";
        chatTerms["MyServerName"] = "MyServer";
        chatTerms["OtherServerName"] = "OtherServer";
        chatMgr["Terms"] = chatTerms;

        // ChatMgr methods
        chatMgr["SwitchMicState"] = DynValue.NewCallback((c,a) => DynValue.Nil);
        chatMgr["SwitchSpeakerState"] = DynValue.NewCallback((c,a) => DynValue.Nil);
        chatMgr["CheckShowInSmall"] = DynValue.NewCallback((c,a) => DynValue.True);
        chatMgr["DealMsgWithLinkColor"] = DynValue.NewCallback((c,a) => a.Count > 0 ? a[0] : DynValue.NewString(""));
        chatMgr["DealMsgWithLinkUpdate"] = DynValue.NewCallback((c,a) => a.Count > 0 ? a[0] : DynValue.NewString(""));
        chatMgr["GetChannelChatData"] = DynValue.NewCallback((c,a) => DynValue.NewTable(script));
        chatMgr["GetColorMsg"] = DynValue.NewCallback((c,a) => {
            var result = new Table(script);
            result["szMsg"] = DynValue.Nil;
            return DynValue.NewTable(result);
        });
        chatMgr["GetNamePrefix"] = DynValue.NewCallback((c,a) => DynValue.NewString(""));
        chatMgr["GetNamePrefixColor"] = DynValue.NewCallback((c,a) => DynValue.NewString(""));
        chatMgr["GetStaticChatTitlePrefixConfig"] = DynValue.NewCallback((c,a) => DynValue.NewTable(script));
        chatMgr["InChatMap"] = DynValue.NewCallback((c,a) => DynValue.False);
        chatMgr["PrivateChatRedPointNum"] = 0;
        chatMgr["Time2Str"] = DynValue.NewCallback((c,a) => DynValue.NewString("00:00"));
        chatMgr["SystemTypeChannel"] = new Table(script);
        chatMgr["Time"] = new Table(script);
        chatMgr["chatSmall"] = new Table(script);

        var chatRoom = new Table(script);
        chatRoom["bMicOn"] = false;
        chatRoom["bSpeakerOn_PlayerSetting"] = true;
        chatMgr["tbChatRoom"] = chatRoom;
        chatMgr["tbChatRoomForKinAndTongMap"] = new Table(script);
        chatMgr["tbChatRoomForKinMap"] = new Table(script);
        chatMgr["tbChatRoomForLegionMap"] = new Table(script);
        chatMgr["tbChatRoomForTeamMap"] = new Table(script);
        chatMgr["tbChatRoomForTongMap"] = new Table(script);
        chatMgr["tbDynamicChannel"] = new Table(script);
        chatMgr["tbLinkClickFns"] = new Table(script);
        chatMgr["ChannelBg"] = new Table(script);
        chatMgr["ChannelSystemBg"] = new Table(script);
        chatMgr["ChannelTagColor"] = new Table(script);
        chatMgr["ChannelTap"] = new Table(script);
        script.Globals["ChatMgr"] = chatMgr;

        // ClientBulletin
        var clientBulletin = new Table(script);
        clientBulletin["BULLETIN_TYPE_SERVER"] = 1;
        clientBulletin["GetBulletin"] = DynValue.NewCallback((c,a) => DynValue.Nil);
        clientBulletin["tbRedPoint"] = new Table(script);
        script.Globals["ClientBulletin"] = clientBulletin;

        // CustomHotkey
        RegisterStubTable(script, "CustomHotkey", "CheckPlatform", "GetKeycodeGameDisplayName");

        // DomainBattle
        RegisterStubTable(script, "DomainBattle", "QueryScoreReq", "ShowLegionIcon");

        // FieldPractice
        RegisterStubTable(script, "FieldPractice", "GetCurXiuLianTime", "GetJiuStateTb", "IsPlayState");

        // FubenUIController
        RegisterStubTable(script, "FubenUIController", "GetFubenBtnAImagePathAndText", "IsInFubenMap",
            "IsNeedExitFubenButton", "IsNeedFubenBtn", "IsNeedFuncScoreButton", "IsNeedStateCancelBtn",
            "IsShowBtnScore", "OnFubenMapLoaded", "OpenFuBenUI", "RequireQuit");

        // GameSetting
        RegisterStubTable(script, "GameSetting");
        script.Globals.Get("GameSetting").Table["MAX_PLAYER_LEVEL"] = 120;

        // Gift
        RegisterStubTable(script, "Gift", "GetAllGiftInfo", "IsGetAllDLCGift", "TimeDesc");
        script.Globals.Get("Gift").Table["tbDlcAwardData"] = DynValue.Nil;

        // GlobalDomainBattle
        RegisterStubTable(script, "GlobalDomainBattle", "QueryScoreReq", "ShowLegionIcon");

        // GlobalHangUp
        RegisterStubTable(script, "GlobalHangUp");
        script.Globals.Get("GlobalHangUp").Table["KongQueHeMapTemplateID"] = 0;

        // GuardXiangYangMgr
        RegisterStubTable(script, "GuardXiangYangMgr", "IsInGuardXiangYang", "ReqRankInfo");

        // Legion
        RegisterStubTable(script, "Legion", "HasLegion", "IsLegionVoiceManager", "OpenLegionWindow");

        // LevelUpAwards
        RegisterStubTable(script, "LevelUpAwards", "CanBuyAwards");

        // LimitTimeLevelUp
        var limitTimeLevelUp = new Table(script);
        limitTimeLevelUp["tbIndex"] = new Table(script);
        limitTimeLevelUp["tbIndex2RedPoint"] = new Table(script);
        script.Globals["LimitTimeLevelUp"] = limitTimeLevelUp;

        // LimitedTimeGift
        RegisterStubTable(script, "LimitedTimeGift", "GetAllGiftInfo", "TimeDesc");

        // Mail (returns number 0 rather than nil to prevent nil comparisons)
        var mail = new Table(script);
        mail["GetUnreadCount"] = DynValue.NewCallback((c,a) => DynValue.NewNumber(0));
        script.Globals["Mail"] = mail;

        // PlayerPortrait
        RegisterStubTable(script, "PlayerPortrait", "GetIcon");

        // QinShiHuangLing
        RegisterStubTable(script, "QinShiHuangLing", "IsInMap", "RequestActivityStatus");

        // RedPacketMgr
        var redPacketMgr = new Table(script);
        redPacketMgr["GetCanOpenList"] = DynValue.NewCallback((c,a) => {
            var result = new Table(script);
            result["Gold"] = new Table(script);
            result["YuanBao"] = new Table(script);
            return DynValue.NewTable(result);
        });
        redPacketMgr["GetRedPacketGetNum"] = DynValue.NewCallback((c,a) => DynValue.NewNumber(0));
        redPacketMgr["OpenRedPacket"] = DynValue.NewCallback((c,a) => DynValue.Nil);
        script.Globals["RedPacketMgr"] = redPacketMgr;

        // Sdk — registered earlier in the file (line ~407) with full GetServerId/onEnterGame
        // bindings. RegisterStubTable would clobber it with a fresh empty table, so we skip.

        // Shop
        var shop = new Table(script);
        shop["CheckLimitShopIsOpenNewType"] = DynValue.NewCallback((c,a) => DynValue.False);
        shop["HandleShopRedPoint"] = DynValue.NewCallback((c,a) => DynValue.Nil);
        shop["LightLimitShopRedPoint"] = DynValue.NewCallback((c,a) => DynValue.Nil);
        var shopType = new Table(script);
        shop["ShopType"] = shopType;
        var shopType2 = new Table(script);
        shopType2["LimitBuy"] = 1;
        shop["ShopType2ViewIndex"] = shopType2;
        var shopCfg = new Table(script);
        shopCfg["VIPPrivilegeGiftPackLevel"] = 5;
        shopCfg["DefaultShopRedPointValue"] = 0;
        shop["Cfg"] = shopCfg;
        script.Globals["Shop"] = shop;

        // TieFuCheng
        var tieFuCheng = new Table(script);
        tieFuCheng["GetCurrentLineName"] = DynValue.NewCallback((c,a) => DynValue.Nil);
        tieFuCheng["QueryScoreReq"] = DynValue.NewCallback((c,a) => DynValue.True);
        var intervalTbl = new Table(script);
        intervalTbl["DAEMON"] = 5;
        tieFuCheng["INTERVAL"] = intervalTbl;
        script.Globals["TieFuCheng"] = tieFuCheng;

        // TongChallenge
        RegisterStubTable(script, "TongChallenge", "IsInTongChallengePlaying");

        // Wedding
        var wedding = new Table(script);
        wedding["OpenRedPacket"] = DynValue.NewCallback((c,a) => DynValue.Nil);
        wedding["RequestActivityStatus"] = DynValue.NewCallback((c,a) => DynValue.Nil);
        wedding["nStartTime"] = 0;
        wedding["nStateEndTime"] = 0;
        script.Globals["Wedding"] = wedding;

        // WuLinDaHui
        RegisterStubTable(script, "WuLinDaHui", "GetWarZone", "IsSysOpen", "OpenWindow");

        // WuLinGaoShou
        var wuLinGaoShou = new Table(script);
        wuLinGaoShou["RequestActivityStatus"] = DynValue.NewCallback((c,a) => DynValue.Nil);
        wuLinGaoShou["bCanEnterWuLinGaoShou"] = false;
        wuLinGaoShou["tbAllTMapSetting"] = new Table(script);
        script.Globals["WuLinGaoShou"] = wuLinGaoShou;

        // ZongShiSkill
        var zongShiSkill = new Table(script);
        zongShiSkill["GetPlayerZongShiExp"] = DynValue.NewCallback((c,a) => DynValue.NewNumber(0));
        zongShiSkill["GetPlayerZongShiLevel"] = DynValue.NewCallback((c,a) => DynValue.NewNumber(1));
        zongShiSkill["tbZongShiLevelSetting"] = new Table(script);
        script.Globals["ZongShiSkill"] = zongShiSkill;

        // ActivityMgr (expanded with sub-tables)
        RegisterStubTable(script, "ActivityMgr", "GetInstanceByClassName");
        var actDefTbl = new Table(script);
        var classNameList = new Table(script);
        classNameList["CelebrationGift"] = "CelebrationGift";
        actDefTbl["ClassNameList"] = classNameList;
        script.Globals.Get("ActivityMgr").Table["Def"] = actDefTbl;
        script.Globals.Get("ActivityMgr").Table["OBActivityCfg"] = MakeActivityCfg(script);
        script.Globals.Get("ActivityMgr").Table["XiongWangActivityCfg"] = MakeActivityCfg(script);
        script.Globals.Get("ActivityMgr").Table["EmeiActivityCfg"] = MakeActivityCfg(script);
        script.Globals.Get("ActivityMgr").Table["ChildrenActivityCfg"] = MakeActivityCfg(script);
        script.Globals.Get("ActivityMgr").Table["DragonBoatActivityCfg"] = MakeActivityCfg(script);
        script.Globals.Get("ActivityMgr").Table["WuDuActivityCfg"] = MakeActivityCfg(script);
        script.Globals.Get("ActivityMgr").Table["SummerActivityCfg"] = MakeActivityCfg(script);
        script.Globals.Get("ActivityMgr").Table["EntranceScheduleCfg"] = new Table(script);
        var entranceSchedule = new Table(script);
        entranceSchedule["CallScript"] = DynValue.NewCallback((c,a) => DynValue.Nil);
        script.Globals.Get("ActivityMgr").Table["EntranceSchedule"] = entranceSchedule;
        var rechargeAward = new Table(script);
        rechargeAward["IsShow"] = DynValue.NewCallback((c,a) => DynValue.False);
        rechargeAward["OnClickIcon"] = DynValue.NewCallback((c,a) => DynValue.Nil);
        script.Globals.Get("ActivityMgr").Table["RechargeAward"] = rechargeAward;

        // FirstRecharge
        var firstRecharge = new Table(script);
        firstRecharge["bHadOpenUIFirstRecharge"] = false;
        script.Globals["FirstRecharge"] = firstRecharge;

        // Recharge
        var recharge = new Table(script);
        recharge["nFirstRechargeJoinLevel"] = 10;
        recharge["FIRST_RECHARGE_GROUP"] = "FR";
        recharge["KEY_GET_FIRST_RECHARGE"] = "GFR";
        recharge["KEY_GET_AWARD"] = "GA";
        recharge["KEY_FIRST_RECHARGE_TIME"] = "FRT";
        var dayBit = new Table(script);
        dayBit["MAX"] = 8;
        for (int d = 1; d <= 7; d++) dayBit[d] = 1 << (d-1);
        recharge["tbFirstRechargeDayBit"] = dayBit;
        script.Globals["Recharge"] = recharge;

        // NewInfomation
        RegisterStubTable(script, "NewInfomation", "CheckCanShow");

        // Ui.UIHudRightTopWelfare config
        var uiTbl = script.Globals.Get("Ui");
        if (uiTbl.Type == DataType.Table) {
            var welfareConf = new Table(script);
            welfareConf["tbBtnShowCfg"] = new Table(script);
            uiTbl.Table["UIHudRightTopWelfare"] = welfareConf;
        }

        // JiangHuZhuJiu
        RegisterStubTable(script, "JiangHuZhuJiu", "GetScheduleList");



        




        // GetTimeFrameState
        script.Globals["GetTimeFrameState"] = DynValue.NewCallback((c,a) => DynValue.NewNumber(1));

        // === Utility functions ===
        script.Globals["Require"] = DynValue.NewCallback((ctx, args) => DynValue.Nil);
        script.Globals["GetTime"] = DynValue.NewCallback((ctx, args) => DynValue.NewNumber(System.DateTimeOffset.Now.ToUnixTimeSeconds()));
        script.Globals["GetFrame"] = DynValue.NewCallback((ctx, args) => DynValue.NewNumber(Time.frameCount));
        script.Globals["GetPingDelay"] = DynValue.NewCallback((ctx, args) => DynValue.NewNumber(45));
        script.Globals["IsAlone"] = DynValue.NewCallback((ctx, args) => DynValue.NewNumber(0));
        script.Globals["SetRideState"] = DynValue.NewCallback((ctx, args) => DynValue.Nil);

        // === i18n (Vietnamese) ===
        var i18n = new Table(script);
        i18n["szOk"] = "Đồng ý";
        i18n["szCancel"] = "Hủy";

        // Vietnamese translation dictionary
        var viDict = new Dictionary<string, string> {
            // Common HUD texts
            {"跨服中无法进行当前操作", "Không thể thực hiện trong liên server"},
            {"安全区内不能使用该技能", "Không thể sử dụng kỹ năng trong vùng an toàn"},
            {"当前未拥有该技能", "Chưa sở hữu kỹ năng này"},
            {"技能等级为0 ，不能使用", "Kỹ năng cấp 0, không sử dụng được"},
            {"自动战斗中", "Đang tự động chiến đấu"},
            {"前往安全区", "Đi đến vùng an toàn"},
            {"补给药品中", "Đang bổ sung thuốc"},
            {"跟战中", "Đang theo chiến đấu"},
            {"本地图无法买药", "Không thể mua thuốc ở bản đồ này"},
            {"确定", "Xác nhận"},
            {"取消", "Hủy"},
            {"等级", "Cấp độ"},
            {"战斗力", "Lực chiến"},
            {"经验", "Kinh nghiệm"},
            {"生命", "Sinh mệnh"},
            {"内力", "Nội lực"},
            {"帮会", "Bang hội"},
            {"门派", "Môn phái"},
            {"组队", "Tổ đội"},
            {"好友", "Bạn bè"},
            {"聊天", "Trò chuyện"},
            {"邮件", "Thư"},
            {"背包", "Túi đồ"},
            {"任务", "Nhiệm vụ"},
            {"活动", "Hoạt động"},
            {"商城", "Thương thành"},
            {"世界", "Thế giới"},
            {"系统", "Hệ thống"},
            {"私聊", "Riêng tư"},
            {"队伍", "Đội ngũ"},
            {"附近", "Lân cận"},
            {"帮", "Bang"},
            {"宗", "Tông"},
            {"阵营", "Trận doanh"},
            {"招募", "Chiêu mộ"},
            {"叫卖", "Rao bán"},
            {"地图", "Bản đồ"},
            {"频道", "Kênh"},
            {"坐骑", "Tọa kỵ"},
            {"宠物", "Thú cưng"},
            {"技能", "Kỹ năng"},
            {"装备", "Trang bị"},
        };

        // EasyGet — decode Chinese UTF-8 → Vietnamese
        i18n["EasyGet"] = DynValue.NewCallback((ctx, args) => {
            if (args.Count == 0) return DynValue.NewString("?");
            string raw = args[0].CastToString();
            if (string.IsNullOrEmpty(raw)) return DynValue.NewString("");
            // Try Vietnamese translation
            if (viDict.TryGetValue(raw, out var vi)) return DynValue.NewString(vi);
            return DynValue.NewString(raw);
        });

        // Get — return Vietnamese or passthrough
        i18n["Get"] = DynValue.NewCallback((c, a) => {
            if (a.Count == 0) return DynValue.NewString("?");
            string raw = a[0].CastToString();
            if (viDict.TryGetValue(raw, out var vi)) return DynValue.NewString(vi);
            return a[0];
        });

        // Parse — return Vietnamese or passthrough
        i18n["Parse"] = DynValue.NewCallback((c, a) => {
            if (a.Count == 0) return DynValue.NewString("?");
            string raw = a[0].CastToString();
            if (viDict.TryGetValue(raw, out var vi)) return DynValue.NewString(vi);
            return a[0];
        });

        script.Globals["i18n"] = i18n;

        // === Lib (full) ===
        var lib = new Table(script);
        lib["EasyLoadTabFile"] = DynValue.NewCallback((ctx, args) => DynValue.NewTable(script));
        lib["IsInteger"] = DynValue.NewCallback((ctx, args) => DynValue.True);
        lib["OSDate"] = DynValue.NewCallback((ctx, args) => DynValue.NewString(System.DateTime.Now.ToString("HH:mm:ss")));
        lib["CalcDayOffset"] = DynValue.NewCallback((c,a) => DynValue.NewNumber(0));
        lib["ParseConfigDateTime"] = DynValue.NewCallback((c,a) => DynValue.NewNumber(0));
        lib["TimeDesc3"] = DynValue.NewCallback((c,a) => DynValue.NewString("00:00:00"));
        lib["MergeTable"] = DynValue.NewCallback((c,a) => a.Count > 0 ? a[0] : DynValue.NewTable(script));
        lib["IsEmptyStr"] = DynValue.NewCallback((c,a) => {
            if (a.Count > 0 && a[0].Type == DataType.String)
                return DynValue.NewBoolean(string.IsNullOrEmpty(a[0].String));
            return DynValue.True;
        });
        lib["CallBack"] = DynValue.NewCallback((c,a) => DynValue.NewTuple(DynValue.False, DynValue.Nil));
        lib["GetLocalDay"] = DynValue.NewCallback((c,a) => DynValue.NewNumber(System.DateTime.Now.DayOfYear));
        lib["CopyTB"] = DynValue.NewCallback((c,a) => {
            if (a.Count > 0 && a[0].Type == DataType.Table) return a[0]; // shallow copy stub
            return DynValue.NewTable(script);
        });
        lib["NumberTo4Digits"] = DynValue.NewCallback((c,a) => {
            if (a.Count > 0) return DynValue.NewString(a[0].CastToString());
            return DynValue.NewString("0");
        });
        lib["SortTable"] = DynValue.NewCallback((c,a) => a.Count > 0 ? a[0] : DynValue.NewTable(script));
        lib["Table_GetCount"] = DynValue.NewCallback((c,a) => {
            if (a.Count > 0 && a[0].Type == DataType.Table) return DynValue.NewNumber(a[0].Table.Length);
            return DynValue.NewNumber(0);
        });
        lib["RandTable"] = DynValue.NewCallback((c, a) => {
            // Lib:RandTable(tb) — colon call so a[0] is Lib (self), a[1] is the table
            DynValue tbDv = (a.Count > 1 && a[1].Type == DataType.Table) ? a[1] :
                            (a.Count > 0 && a[0].Type == DataType.Table) ? a[0] : DynValue.Nil;
            if (tbDv.Type != DataType.Table) return DynValue.Nil;
            var tb = tbDv.Table;
            int n = tb.Length;
            if (n <= 0) return DynValue.Nil;
            return tb.Get(UnityEngine.Random.Range(1, n + 1));
        });
        script.Globals["Lib"] = lib;

        // === MedicineMgr (expand) ===
        var medTbl = script.Globals.Get("MedicineMgr");
        if (medTbl.Type == DataType.Table) {
            medTbl.Table["GetCurUsedMedicineCount"] = DynValue.NewCallback((c,a) => DynValue.NewNumber(10));
            medTbl.Table["GetCurUsedMedicineIcon"] = DynValue.NewCallback((c,a) => DynValue.NewString("medicine_icon"));
        }

        // === Task ===
        var taskTbl = new Table(script);
        taskTbl["TASK_TYPE_MAIN"] = 1;
        taskTbl["TASK_TYPE_DAILY"] = 2;
        taskTbl["TASK_TYPE_SUB"] = 3;
        taskTbl["TASK_TYPE_ACT"] = 4;
        taskTbl["tbTaskData"] = new Table(script);
        taskTbl["tbDailyTaskOrder"] = new Table(script);
        taskTbl["tbDailyTaskSettings"] = new Table(script);
        taskTbl["GetTaskInfo"] = DynValue.NewCallback((c, a) => DynValue.Nil);
        taskTbl["IsTaskFinished"] = DynValue.NewCallback((c, a) => DynValue.False);
        taskTbl["GetTaskList"] = DynValue.NewCallback((c, a) => DynValue.NewTable(script));
        taskTbl["GetTitleIncludeColor"] = DynValue.NewCallback((c, a) => a.Count > 1 ? a[1] : DynValue.NewString(""));
        script.Globals["Task"] = taskTbl;

        // === TeamMgr (expand) ===
        var teamTbl = script.Globals.Get("TeamMgr");
        if (teamTbl.Type == DataType.Table) {
            var teamCfg = new Table(script);
            teamCfg["MAX_MEMBER_COUNT"] = 5;
            teamTbl.Table["Cfg"] = teamCfg;
            teamTbl.Table["GetTeamMatesPos"] = DynValue.NewCallback((c,a) => DynValue.NewTable(script));
        }

        // === Kin (expand) ===
        var kinTbl = script.Globals.Get("Kin");
        if (kinTbl.Type == DataType.Table) {
            var kinDef = new Table(script);
            kinDef["TongModeCdTime"] = 30;
            kinTbl.Table["Def"] = kinDef;
        }

        // === EDITOR flag ===
        script.Globals["EDITOR"] = DynValue.False;


        // === AutoPath (expand) ===
        var autoPathTbl = script.Globals.Get("AutoPath");
        if (autoPathTbl.Type == DataType.Table) {
            autoPathTbl.Table["IsPathing"] = DynValue.NewCallback((c,a) => DynValue.False);
            autoPathTbl.Table["GetTargetPos"] = DynValue.NewCallback((c,a) => DynValue.NewTuple(DynValue.NewNumber(0), DynValue.NewNumber(0)));
        }


        // === ResourceBattleMining ===
        RegisterStubTable(script, "ResourceBattleMining", "CanMine");

        Debug.Log("[LuaStubs] All game systems registered");
    }

    private static Table MakeActivityCfg(Script script)
    {
        var cfg = new Table(script);
        cfg["IsShow"] = DynValue.NewCallback((c,a) => DynValue.False);
        cfg["OnClickIcon"] = DynValue.NewCallback((c,a) => DynValue.Nil);
        cfg["GetActivityTimeDesc"] = DynValue.NewCallback((c,a) => DynValue.NewString(""));
        cfg["nLevel"] = 0;
        cfg["szStartTime"] = "2020-01-01 00:00:00";
        cfg["szEndTime"] = "2020-01-01 00:00:01";
        cfg["szIconName"] = "";
        return cfg;
    }

    private static void RegisterStubTable(Script script, string name, params string[] methods)
    {
        var tbl = new Table(script);
        foreach (var m in methods)
        {
            tbl[m] = DynValue.NewCallback((ctx, args) => DynValue.Nil);
        }
        script.Globals[name] = tbl;
    }
}
