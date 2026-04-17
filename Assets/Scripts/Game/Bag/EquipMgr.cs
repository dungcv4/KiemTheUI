// =======================================================================
//  EquipMgr.cs — Client-side equipment state, keyed by equip slot.
//
//  Complements BagMgr: bag = slots 0..39, equipment = 10 character slots
//  (Helm, Armor, Belt, Cuff, Boots, Weapon, Necklace, Ring, Pendant, Amulet).
//
//  Populated via CMD_EQUIP_SYNC (206) at login and CMD_EQUIP_SLOT_UPDATE
//  (207) on each equip/unequip. UIEquipPanel listens to
//  emNOTIFY_EQUIP_CHANGE and refreshes the paperdoll.
//
//  Source: server GoodsData.Using field maps to our EquipSlot enum values.
//    Server: goodsData.Using == 1 → Helm, 2 → Armor, ..., 10 → Amulet.
//    See Global.cs line 3365 (EquipLoadMain) + KPlayerEquipBody.
// =======================================================================
using System.Collections.Generic;
using UnityEngine;
using KTO.Game.Item;

namespace KTO.Game.Bag
{
    public enum EquipSlot
    {
        NONE     = 0,
        Helm     = 1,
        Armor    = 2,
        Belt     = 3,
        Cuff     = 4,
        Boots    = 5,
        Weapon   = 6,
        Necklace = 7,
        Ring     = 8,
        Pendant  = 9,
        Amulet   = 10,
    }

    public static class EquipMgr
    {
        // slot → instance (sparse: slot empty = absent)
        static readonly Dictionary<EquipSlot, ItemInstance> _slots
            = new Dictionary<EquipSlot, ItemInstance>();

        // ----- query -----
        public static ItemInstance Get(EquipSlot slot)
        {
            _slots.TryGetValue(slot, out var i);
            return i;
        }

        public static IEnumerable<KeyValuePair<EquipSlot, ItemInstance>> All => _slots;

        public static bool IsEquipped(int dwId)
        {
            foreach (var kv in _slots)
                if (kv.Value != null && kv.Value.dwId == dwId) return true;
            return false;
        }

        public static EquipSlot GetSlotOf(int dwId)
        {
            foreach (var kv in _slots)
                if (kv.Value != null && kv.Value.dwId == dwId) return kv.Key;
            return EquipSlot.NONE;
        }

        // ----- mutations (called from PlayerDataSyncHandler) -----
        public static void OnSlotUpdate(int equipPos, ItemInstance inst)
        {
            var slot = (EquipSlot)equipPos;
            if (slot == EquipSlot.NONE) return;

            if (inst == null || inst.dwId == 0)
                _slots.Remove(slot);
            else
                _slots[slot] = inst;

            // emNOTIFY_USE_UNUSE_EQUIP (16) is the Lua event fired on each
            // single-slot change — see 05_Equipment Lua for subscribers.
            EventNotify.Fire(NotifyEventKind.emNOTIFY_USE_UNUSE_EQUIP, equipPos);
        }

        public static void ClearAll()
        {
            _slots.Clear();
        }

        public static int Count => _slots.Count;
    }
}
