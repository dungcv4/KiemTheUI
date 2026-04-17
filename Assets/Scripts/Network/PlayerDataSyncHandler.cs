// =======================================================================
//  PlayerDataSyncHandler.cs — Network adapter for player / bag / equip sync.
//
//  NEW file — 0 changes to existing UI/HUD code. Wires 8 new packet IDs
//  (200-207) and translates them into EventNotify events that existing
//  UI controllers (UIBagPanel, UIAttributePanel, HUD health bar, etc.)
//  already subscribe to.
//
//  Flow: server packet → parse here → update manager state → fire event
//        → UI auto-refreshes via its existing NotifyEvents subscription.
// =======================================================================
using UnityEngine;
using KTO.Game;
using KTO.Game.Bag;
using KTO.Game.Item;

namespace KTO.Network
{
    public class PlayerDataSyncHandler : MonoBehaviour
    {
        public static PlayerDataSyncHandler Instance { get; private set; }

        void Awake()
        {
            if (Instance != null && Instance != this) { Destroy(gameObject); return; }
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        void Start()
        {
            var net = NetworkManager.Instance;
            if (net == null) { Debug.LogWarning("[PlayerDataSyncHandler] NetworkManager null"); return; }

            net.RegisterHandler(PlayerDataProtocol.CMD_PLAYER_STATE,      OnPlayerState);
            net.RegisterHandler(PlayerDataProtocol.CMD_HP_MP_CHANGE,      OnHpMpChange);
            net.RegisterHandler(PlayerDataProtocol.CMD_MONEY_CHANGE,      OnMoneyChange);
            net.RegisterHandler(PlayerDataProtocol.CMD_EXP_GAIN,          OnExpGain);
            net.RegisterHandler(PlayerDataProtocol.CMD_BAG_SYNC,          OnBagSync);
            net.RegisterHandler(PlayerDataProtocol.CMD_BAG_ITEM_UPDATE,   OnBagItemUpdate);
            net.RegisterHandler(PlayerDataProtocol.CMD_EQUIP_SYNC,        OnEquipSync);
            net.RegisterHandler(PlayerDataProtocol.CMD_EQUIP_SLOT_UPDATE, OnEquipSlotUpdate);

            Debug.Log("[PlayerDataSyncHandler] Registered CMD 200-207 (player/bag/equip sync)");
        }

        void OnDestroy()
        {
            var net = NetworkManager.Instance;
            if (net != null)
            {
                net.UnregisterHandler(PlayerDataProtocol.CMD_PLAYER_STATE);
                net.UnregisterHandler(PlayerDataProtocol.CMD_HP_MP_CHANGE);
                net.UnregisterHandler(PlayerDataProtocol.CMD_MONEY_CHANGE);
                net.UnregisterHandler(PlayerDataProtocol.CMD_EXP_GAIN);
                net.UnregisterHandler(PlayerDataProtocol.CMD_BAG_SYNC);
                net.UnregisterHandler(PlayerDataProtocol.CMD_BAG_ITEM_UPDATE);
                net.UnregisterHandler(PlayerDataProtocol.CMD_EQUIP_SYNC);
                net.UnregisterHandler(PlayerDataProtocol.CMD_EQUIP_SLOT_UPDATE);
            }
            if (Instance == this) Instance = null;
        }

        // ── CMD_PLAYER_STATE (200) ─────────────────────────────────
        // Format: level:exp:hp:mp:gold:yuanBao:coin:jingHuo:
        //         freePoints:str:agi:con:dex:
        //         posX:posY:mapCode:factionId:sex:fightPower
        void OnPlayerState(string payload)
        {
            var f = KTPacket.SplitFields(payload);
            if (f.Length < 19) { Debug.LogWarning($"[PlayerDataSync] CMD_PLAYER_STATE bad payload: {payload}"); return; }

            int lv = Int(f, 0);
            long exp = Long(f, 1);
            int hp = Int(f, 2);
            int mp = Int(f, 3);
            long gold = Long(f, 4);
            long yb   = Long(f, 5);
            long coin = Long(f, 6);
            long jh   = Long(f, 7);
            int fp  = Int(f, 8);
            int str = Int(f, 9);
            int agi = Int(f, 10);
            int con = Int(f, 11);
            int dex = Int(f, 12);
            int px  = Int(f, 13);
            int py  = Int(f, 14);
            int mapCode = Int(f, 15);
            int factionId = Int(f, 16);
            int sex = Int(f, 17);
            int fightPower = Int(f, 18);

            // 1. Push attributes
            var a = KTO.UI.PlayerAttributeMgr.Current;
            a.nLevel     = lv;
            a.nStr       = str;
            a.nAgi       = agi;
            a.nCon       = con;
            a.nDex       = dex;
            a.nFreePoints = fp;
            a.nFactionId = factionId;

            // 2. Push money
            MoneyMgr.SetMoney(MoneyMgr.MoneyType.Gold,    gold);
            MoneyMgr.SetMoney(MoneyMgr.MoneyType.YuanBao, yb);
            MoneyMgr.SetMoney(MoneyMgr.MoneyType.Coin,    coin);
            MoneyMgr.SetMoney(MoneyMgr.MoneyType.JingHuo, jh);

            // 3. Push HP/MP
            PlayerHpMpMgr.SetHp(hp);
            PlayerHpMpMgr.SetMp(mp);

            // 4. Push level+exp
            PlayerLevelMgr.Set(lv, exp);

            // 5. Fire post-sync event (Lua equivalent of emNOTIFY_SYNC_PLAYER_DATA_END)
            EventNotify.Fire(NotifyEventKind.emNOTIFY_SYNC_PLAYER_DATA_END);
            EventNotify.Fire(NotifyEventKind.emNOTIFY_FIGHT_POWER_CHANGE, fightPower);

            Debug.Log($"[PlayerDataSync] PLAYER_STATE lv={lv} hp={hp} mp={mp} pos=({px},{py}) map={mapCode} faction={factionId}");
        }

        // ── CMD_HP_MP_CHANGE (201) ─────────────────────────────────
        void OnHpMpChange(string payload)
        {
            var f = KTPacket.SplitFields(payload);
            if (f.Length < 2) return;
            int hp = Int(f, 0), mp = Int(f, 1);
            PlayerHpMpMgr.SetHp(hp);
            PlayerHpMpMgr.SetMp(mp);
        }

        // ── CMD_MONEY_CHANGE (202) ─────────────────────────────────
        void OnMoneyChange(string payload)
        {
            var f = KTPacket.SplitFields(payload);
            if (f.Length < 2) return;
            int moneyType = Int(f, 0);
            long v = Long(f, 1);
            MoneyMgr.SetMoney((MoneyMgr.MoneyType)moneyType, v);
        }

        // ── CMD_EXP_GAIN (203) ─────────────────────────────────────
        void OnExpGain(string payload)
        {
            var f = KTPacket.SplitFields(payload);
            if (f.Length < 2) return;
            long newExp = Long(f, 0);
            int newLv = Int(f, 1);
            int oldLv = KTO.UI.PlayerAttributeMgr.Current.nLevel;
            PlayerLevelMgr.Set(newLv, newExp);
            if (newLv != oldLv) EventNotify.Fire(NotifyEventKind.emNOTIFY_CHANGE_PLAYER_LEVEL, newLv);
        }

        // ── CMD_BAG_SYNC (204) ─────────────────────────────────────
        // Format: numItems[:slot:dwId:tmplId:amount:lvl:bind:expiry]*
        //
        // Server-authoritative — drops client-side mock completely and replaces
        // with whatever items server reports. If n==0, bag is actually empty.
        void OnBagSync(string payload)
        {
            var f = KTPacket.SplitFields(payload);
            if (f.Length < 1) return;
            int n = Int(f, 0);
            const int fieldsPer = 7;

            // Ensure item template DB loaded (needs pack0 item tables when wired)
            KTO.Game.Item.ItemDatabase.LoadAll();

            // Clear existing bag — no mock re-fill. Server is authoritative.
            BagMgr.ClearAll();

            for (int i = 0; i < n; i++)
            {
                int ofs = 1 + i * fieldsPer;
                if (f.Length < ofs + fieldsPer) break;
                var inst = new ItemInstance
                {
                    nPos         = Int(f, ofs + 0),
                    dwId         = Int(f, ofs + 1),
                    nTemplateId  = Int(f, ofs + 2),
                    nAmount      = Int(f, ofs + 3),
                    nLevel       = Int(f, ofs + 4),
                    bBinding     = Int(f, ofs + 5) != 0,
                    nExpireTime  = Long(f, ofs + 6),
                };
                BagMgr.OnSyncItem(inst.nPos, inst);
            }
            Debug.Log($"[PlayerDataSync] BAG_SYNC loaded {n} items (cleared previous)");
        }

        // ── CMD_BAG_ITEM_UPDATE (205) ──────────────────────────────
        void OnBagItemUpdate(string payload)
        {
            var f = KTPacket.SplitFields(payload);
            if (f.Length < 7) return;
            int slot = Int(f, 0);
            int dwId = Int(f, 1);
            if (dwId == 0) { BagMgr.OnDelItem(slot); return; }
            var inst = new ItemInstance
            {
                nPos         = slot,
                dwId         = dwId,
                nTemplateId  = Int(f, 2),
                nAmount      = Int(f, 3),
                nLevel       = Int(f, 4),
                bBinding     = Int(f, 5) != 0,
                nExpireTime  = Long(f, 6),
            };
            BagMgr.OnSyncItem(slot, inst);
        }

        // ── CMD_EQUIP_SYNC (206) ───────────────────────────────────
        void OnEquipSync(string payload)
        {
            var f = KTPacket.SplitFields(payload);
            if (f.Length < 1) return;
            int n = Int(f, 0);
            // Phase 1: just fire notify; UIEquipPanel will pick up later.
            EventNotify.Fire(NotifyEventKind.emNOTIFY_SYNC_EQUIP, n);
            Debug.Log($"[PlayerDataSync] EQUIP_SYNC {n} slots (UIEquipPanel port pending)");
        }

        void OnEquipSlotUpdate(string payload)
        {
            var f = KTPacket.SplitFields(payload);
            if (f.Length < 6) return;
            int pos = Int(f, 0);
            int dwId = Int(f, 1);
            EventNotify.Fire(NotifyEventKind.emNOTIFY_USE_UNUSE_EQUIP, dwId != 0, pos, dwId);
        }

        // Helpers
        static int  Int(string[] a, int i)  => (i < a.Length && int.TryParse(a[i], out var v))  ? v : 0;
        static long Long(string[] a, int i) => (i < a.Length && long.TryParse(a[i], out var v)) ? v : 0L;
    }

    /// <summary>Live HP/MP state + events (for HUD health bar).</summary>
    public static class PlayerHpMpMgr
    {
        static int _hp = 100;
        static int _mp = 50;
        public static int Hp => _hp;
        public static int Mp => _mp;

        public static void SetHp(int v) { if (v == _hp) return; _hp = v; EventNotify.Fire(NotifyEventKind.emNOTIFY_HP_MP_CHANGE, _hp, _mp); }
        public static void SetMp(int v) { if (v == _mp) return; _mp = v; EventNotify.Fire(NotifyEventKind.emNOTIFY_HP_MP_CHANGE, _hp, _mp); }
    }

    /// <summary>Level + exp state + events.</summary>
    public static class PlayerLevelMgr
    {
        static int _level = 1;
        static long _exp = 0;
        public static int  Level => _level;
        public static long Exp   => _exp;

        public static void Set(int level, long exp)
        {
            bool lvChanged = level != _level;
            _level = level; _exp = exp;
            if (lvChanged) EventNotify.Fire(NotifyEventKind.emNOTIFY_CHANGE_PLAYER_LEVEL, level);
        }
    }
}
