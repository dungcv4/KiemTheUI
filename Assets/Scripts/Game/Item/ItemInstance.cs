// =======================================================================
//  ItemInstance.cs — Runtime item instance (unique per server-side dwId).
//
//  Source: 04_Bag/Lua/Item_Class_Default.lua (Item:GetClass("default") base)
//          + in-memory pItem table fields used by UIBagPanel / UIItemTips.
//
//  The SERVER owns the source of truth; each live item has a unique dwId,
//  a slot position nPos, and dynamic properties (enhancement level, stat
//  rolls, binding state, etc.). The client caches instances via BagMgr.
// =======================================================================
using System.Collections.Generic;

namespace KTO.Game.Item
{
    public class ItemInstance
    {
        // ----- identity (from server) -----
        public int dwId;             // unique live item id (non-zero)
        public int nTemplateId;      // template lookup → ItemTemplate
        public int nAmount;          // stack count
        public int nPos;             // bag slot index (0..bagSize-1)

        // ----- dynamic state -----
        public int nLevel;           // enhancement level (+1 .. +15)
        public int nJingZhuLevel;    // tinh đúc (refine) level
        public int nQiHunLevel;      // khí hồn (soul) level
        public bool bBinding;        // bound to player
        public bool bEquipped;       // currently equipped (nPos < 0 means equip slot)
        public long nExpireTime;     // unix timestamp; 0 = no expiry
        public int nCdRemain;        // cooldown remaining (seconds)

        // ----- dynamic property rolls (random stats for equipment) -----
        public Dictionary<string, int> tbProperties = new Dictionary<string, int>();

        // ----- gem sockets (equipment) -----
        public int[] tbGemSlots;     // template ids of gems in sockets; 0 = empty

        // ----- derived -----
        public ItemTemplate Template => ItemDatabase.Get(nTemplateId);
        public string szName => Template?.szName ?? $"#{nTemplateId}";
        public int nColor => Template?.nColor ?? 0;
        public int nMaxStack => Template?.nMaxStack ?? 1;
        public bool IsStackable => nMaxStack > 1;
        public bool IsEquipment => (Template?.nEquipPos ?? EquipPos.NONE) != EquipPos.NONE;
    }
}
