// =======================================================================
//  BagMgr.cs — Client-side bag state, keyed by slot position.
//
//  Source: 04_Bag/Lua/BagMgr*.lua + server SyncItem packet handler.
//  Original flow:
//    server → CMD_KT_G2C_SYNC_ITEM packet → BagMgr:OnSyncItem(nPos, pItem)
//      → updates local cache → EventNotify.Fire(emNOTIFY_SYNC_ITEM, pos)
//      → UIBagPanel listens → calls UpdateOneItem(pos)
//
//  Our port: same cache shape + EventNotify fan-out. Until network is
//  wired, MockFill() populates demo items so UIBagPanel renders.
// =======================================================================
using System.Collections.Generic;
using UnityEngine;
using KTO.Game.Item;

namespace KTO.Game.Bag
{
    public static class BagMgr
    {
        // ----- config -----
        /// <summary>
        /// Current bag size. Original starts at 40 slots; expanded via
        /// `BagExpandItem` consumable up to ~100. Server tells us the cap
        /// via emNOTIFY_EXPAND_BAG_COUNT; we default to 40 for the mock.
        /// </summary>
        public static int BagSize { get; private set; } = 40;

        // ----- state -----
        // Keyed by slot position (0..BagSize-1). Sparse — slot may be empty.
        static readonly Dictionary<int, ItemInstance> _items = new Dictionary<int, ItemInstance>();
        static bool _initialized;

        // ----- lifecycle -----
        public static void Init()
        {
            if (_initialized) return;
            ItemDatabase.LoadAll();
            MockFill();
            _initialized = true;
            Debug.Log($"[BagMgr] Initialized with {_items.Count}/{BagSize} mock items");
        }

        // ----- query -----
        public static ItemInstance GetItem(int slot)
        {
            _items.TryGetValue(slot, out var i);
            return i;
        }

        public static int Count => _items.Count;

        public static IEnumerable<KeyValuePair<int, ItemInstance>> AllSlots => _items;

        /// <summary>Enumerate slots that match a filter predicate (for UIBagPanel filter tabs).</summary>
        public static IEnumerable<KeyValuePair<int, ItemInstance>> Find(System.Predicate<ItemInstance> pred)
        {
            foreach (var kv in _items)
                if (pred(kv.Value)) yield return kv;
        }

        public static int FindSlotByTemplate(int nTemplateId)
        {
            foreach (var kv in _items)
                if (kv.Value != null && kv.Value.nTemplateId == nTemplateId)
                    return kv.Key;
            return -1;
        }

        // ----- mutations (called from network handler or mock) -----
        public static void OnSyncItem(int slot, ItemInstance inst)
        {
            if (inst == null || inst.nTemplateId == 0)
                _items.Remove(slot);
            else
                _items[slot] = inst;
            EventNotify.Fire(NotifyEventKind.emNOTIFY_SYNC_ITEM, slot);
        }

        public static void OnDelItem(int slot)
        {
            if (_items.Remove(slot))
                EventNotify.Fire(NotifyEventKind.emNOTIFY_DEL_ITEM, slot);
        }

        public static void OnBagCountExpand(int newSize)
        {
            BagSize = newSize;
            EventNotify.Fire(NotifyEventKind.emNOTIFY_EXPAND_BAG_COUNT, newSize);
        }

        /// <summary>
        /// Clear ALL items (both real and mock). Leaves `_initialized = true`
        /// so future <see cref="Init"/> calls become a no-op — the server is
        /// authoritative after the first CMD_BAG_SYNC packet, and we must not
        /// re-populate mock data on subsequent calls.
        /// </summary>
        public static void ClearAll()
        {
            _items.Clear();
            _initialized = true;
        }

        // ----- mock data -----
        // Fills 15 slots with varied items so UIBagPanel has something to
        // render during single-player smoke testing. Real game replaces
        // this with packet-driven data via OnSyncItem.
        static void MockFill()
        {
            int[] ids = { 1001, 1002, 1003, 2001, 2001, 2002, 2002, 3001, 3002, 4001, 4001, 4001, 4002, 4002, 5001 };
            int[] amounts = { 1, 1, 1, 30, 15, 25, 10, 5, 3, 99, 50, 20, 80, 40, 1 };
            int[] enhance = { 5, 3, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            int uid = 100000;
            for (int i = 0; i < ids.Length; i++)
            {
                _items[i] = new ItemInstance
                {
                    dwId = uid++,
                    nTemplateId = ids[i],
                    nAmount = amounts[i],
                    nPos = i,
                    nLevel = enhance[i],
                    bBinding = (ids[i] == 5001),
                };
            }
        }
    }
}
