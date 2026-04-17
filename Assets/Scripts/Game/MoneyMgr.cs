// =======================================================================
//  MoneyMgr.cs — Player currency state (Gold / YuanBao / Coin / JingHuo).
//
//  Source: me.GetMoney(szType) in Lua returns a number. UIBag OnChangeMoney
//  logs: Log("OnChangeMoney", me.GetMoney("Gold"), me.GetMoney("YuanBao"),
//        me.GetMoney("Coin"))
//  so there are at least 3 money types, plus JingHuo (精活 / tinh hoạt).
//
//  Client ports: static cache with setters from the network packet handler,
//  plus EventNotify.emNOTIFY_CHANGE_MONEY fan-out. Mock values until server.
// =======================================================================
using UnityEngine;

namespace KTO.Game
{
    public static class MoneyMgr
    {
        /// <summary>Mirror of me.GetMoney(szType). szType values from Lua grep.</summary>
        public enum MoneyType
        {
            Gold    = 0,   // in-game gold currency
            YuanBao = 1,   // premium currency (元宝 / KNB)
            Coin    = 2,   // silver coin (银两)
            JingHuo = 3,   // tinh hoạt (精活) — daily activity points
        }

        // Mock default values so UIMoneyPanel shows non-zero numbers during smoke test.
        static long _gold = 1234567890;
        static long _yuanBao = 4987;
        static long _coin = 10458;
        static long _jingHuo = 57440;

        public static long GetMoney(MoneyType t)
        {
            switch (t)
            {
                case MoneyType.Gold:    return _gold;
                case MoneyType.YuanBao: return _yuanBao;
                case MoneyType.Coin:    return _coin;
                case MoneyType.JingHuo: return _jingHuo;
                default: return 0;
            }
        }

        public static void SetMoney(MoneyType t, long value)
        {
            long before = GetMoney(t);
            switch (t)
            {
                case MoneyType.Gold:    _gold    = value; break;
                case MoneyType.YuanBao: _yuanBao = value; break;
                case MoneyType.Coin:    _coin    = value; break;
                case MoneyType.JingHuo: _jingHuo = value; break;
            }
            if (before != value)
                EventNotify.Fire(NotifyEventKind.emNOTIFY_CHANGE_MONEY, t, value);
        }

        /// <summary>
        /// Format number with thousand separators for UI display. Matches
        /// the original's Lua Lib.NumberTo4Digits for values &lt; 10000,
        /// otherwise uses K/M/B suffix pattern visible in the HUD.
        /// </summary>
        public static string Format(long n)
        {
            if (n < 10_000) return n.ToString();
            if (n < 10_000_000) return (n / 1000f).ToString("F1") + "K";
            if (n < 10_000_000_000) return (n / 1_000_000f).ToString("F1") + "M";
            return (n / 1_000_000_000f).ToString("F1") + "B";
        }
    }
}
