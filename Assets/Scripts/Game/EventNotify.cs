// =======================================================================
//  EventNotify.cs — Client-side event dispatcher for Lua NotifyEvents.
//
//  Source: Every UI window's NotifyEvents() return table uses enum values
//          like `EventNotify.emNOTIFY_SYNC_ITEM`. In the original client
//          these are routed through a C++ dispatcher that Lua subscribes
//          to via the NotifyEvents() table returned from each window.
//
//  Our port: C# static dispatcher with enum + Action subscriptions. Every
//  UI controller ports NotifyEvents() as:
//    EventNotify.Subscribe(NotifyEventKind.emNOTIFY_SYNC_ITEM, OnSyncItem);
//  Fired from BagMgr / NetworkHandler when the server tells us state changed.
// =======================================================================
using System;
using System.Collections.Generic;
using UnityEngine;

namespace KTO.Game
{
    /// <summary>
    /// Event kinds referenced by at least one window's NotifyEvents() in the
    /// original Lua. List extracted from Script_Ui_Window_UIBag.lua +
    /// 39_CommonUI/CSharp/EventNotify.cs stubs (IL2CPP).
    /// New events: add here AND to any emitter.
    /// </summary>
    public enum NotifyEventKind
    {
        emNOTIFY_SYNC_ITEM                     = 1,
        emNOTIFY_DEL_ITEM                      = 2,
        emNOTIFY_STRENGTHEN_RESULT             = 3,
        emNOTIFY_CHANGE_PLAYER_NAME            = 4,
        emNOTIFY_CHANGE_PLAYER_POTENTIAL_INFO  = 5,
        emNOTIFY_CHANGE_PLAYER_FACTION_SECT    = 6,
        emNOTIFY_CHANGE_MONEY                  = 7,
        emNOTIFY_CHANGE_FEATURE                = 8,
        emNOTIFY_FIGHT_POWER_CHANGE            = 9,
        emNOTIFY_CHANGE_HONOR_LEVEL            = 10,
        emNOTIFY_UPDATE_TITLE                  = 11,
        emNOTIFY_CHANGE_PLAYER_LEVEL           = 12,
        emNOTIFY_GOODWILL_VALUE_CHANGE         = 13,
        emNOTIFY_CHANGE_PORTRAIT               = 14,
        emNOTIFY_PORTRAIT_FRAME_CHANGE         = 15,
        emNOTIFY_USE_UNUSE_EQUIP               = 16,
        emNOTIFY_EXPAND_BAG_COUNT              = 17,
        emNOTIFY_SHOP_FASHION_UPDATE           = 18,
        emNOTIFY_FASHION_DATA_CHANGE           = 19,
        emNOTIFY_WEEK_MONTH_CARD_BUY           = 20,
        emNOTIFY_SYNC_PLAYER_DATA_END          = 21,
        emNOTIFY_SYNC_EQUIP                    = 22,
        emNOTIFY_HORSE_DATA_CHANGE             = 23,
        emNOTIFY_ATTRIBUTE_POINT_CHANGE        = 24,
        emNOTIFY_REPUTE_CHANGE                 = 25,
        emNOTIFY_HP_MP_CHANGE                  = 26,
    }

    public static class EventNotify
    {
        // One handler list per event kind.
        static readonly Dictionary<NotifyEventKind, List<Action<object[]>>> _subs =
            new Dictionary<NotifyEventKind, List<Action<object[]>>>();

        public static void Subscribe(NotifyEventKind k, Action<object[]> handler)
        {
            if (handler == null) return;
            if (!_subs.TryGetValue(k, out var list))
            {
                list = new List<Action<object[]>>();
                _subs[k] = list;
            }
            if (!list.Contains(handler)) list.Add(handler);
        }

        public static void Unsubscribe(NotifyEventKind k, Action<object[]> handler)
        {
            if (_subs.TryGetValue(k, out var list))
                list.Remove(handler);
        }

        public static void Fire(NotifyEventKind k, params object[] args)
        {
            if (!_subs.TryGetValue(k, out var list)) return;
            // Copy snapshot to guard against handlers that subscribe/unsubscribe during dispatch
            var snapshot = list.ToArray();
            foreach (var h in snapshot)
            {
                try { h?.Invoke(args); }
                catch (Exception e) { Debug.LogError($"[EventNotify] Handler for {k} threw: {e.Message}"); }
            }
        }

        /// <summary>Clear all subscriptions (scene reset / domain reload).</summary>
        public static void ClearAll() => _subs.Clear();
    }
}
