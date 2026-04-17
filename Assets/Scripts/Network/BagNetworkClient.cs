// =======================================================================
//  BagNetworkClient.cs — Client-side send helpers for bag / equip actions.
//
//  Wraps KTTcpClient.Send with the colon-text payloads expected by the
//  server's KT_TCPHandler_BagAction wrapper (CMDs 50200-50206).
//
//  Flow:
//    UI click (UIItemTips/right-click menu)
//      → BagNetworkClient.EquipItem(dwId, equipPos)
//      → NetworkManager.SendCmd(CMD_BAG_EQUIP_ITEM, dwId, equipPos)
//      → [server parses, delegates to Global.ModifyGoodsByCmdParams]
//      → [server emits CMD_EQUIP_SLOT_UPDATE (207) + CMD_BAG_ITEM_UPDATE (205)]
//      → PlayerDataSyncHandler.OnEquipSlotUpdate / OnBagItemUpdate
//      → BagMgr / EquipMgr mutations → EventNotify → UI refresh
//
//  All methods are fire-and-forget. The caller does NOT wait for an ACK;
//  UI updates when the server's notification packet arrives.
// =======================================================================
using UnityEngine;

namespace KTO.Network
{
    public static class BagNetworkClient
    {
        static NetworkManager Net => NetworkManager.Instance;

        static bool CheckConnected(string action)
        {
            if (Net == null || Net.TCP == null || !Net.TCP.IsConnected)
            {
                Debug.LogWarning($"[BagNet] Cannot {action}: not connected");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Use a consumable item (potion, scroll, etc.).
        /// Server routes through KT_TCPHandler.DoUseGoods.
        /// </summary>
        public static void UseItem(int dwId, int count = 1)
        {
            if (!CheckConnected($"UseItem dwId={dwId}")) return;
            Net.SendCmd(PlayerDataProtocol.CMD_BAG_USE_ITEM, dwId, count);
            Debug.Log($"[BagNet] UseItem dwId={dwId} count={count}");
        }

        /// <summary>
        /// Equip a bag item into a character slot.
        /// equipPos: 1=Helm, 2=Armor, 3=Belt, 4=Cuff, 5=Boots,
        ///           6=Weapon, 7=Necklace, 8=Ring, 9=Pendant, 10=Amulet.
        /// </summary>
        public static void EquipItem(int dwId, int equipPos)
        {
            if (!CheckConnected($"EquipItem dwId={dwId}")) return;
            Net.SendCmd(PlayerDataProtocol.CMD_BAG_EQUIP_ITEM, dwId, equipPos);
            Debug.Log($"[BagNet] EquipItem dwId={dwId} equipPos={equipPos}");
        }

        /// <summary>
        /// Unequip an equipped item. targetSlot = bag slot to land in;
        /// pass -1 to let the server pick first empty slot.
        /// </summary>
        public static void UnequipItem(int dwId, int targetSlot = -1)
        {
            if (!CheckConnected($"UnequipItem dwId={dwId}")) return;
            Net.SendCmd(PlayerDataProtocol.CMD_BAG_UNEQUIP_ITEM, dwId, targetSlot);
            Debug.Log($"[BagNet] UnequipItem dwId={dwId} targetSlot={targetSlot}");
        }

        /// <summary>Drop / discard an item permanently.</summary>
        public static void DropItem(int dwId, int count = 1)
        {
            if (!CheckConnected($"DropItem dwId={dwId}")) return;
            Net.SendCmd(PlayerDataProtocol.CMD_BAG_DROP_ITEM, dwId, count);
            Debug.Log($"[BagNet] DropItem dwId={dwId} count={count}");
        }

        /// <summary>Sell to NPC vendor (must be in-range; server validates).</summary>
        public static void SellItem(int dwId, int count = 1)
        {
            if (!CheckConnected($"SellItem dwId={dwId}")) return;
            Net.SendCmd(PlayerDataProtocol.CMD_BAG_SELL_ITEM, dwId, count);
            Debug.Log($"[BagNet] SellItem dwId={dwId} count={count}");
        }

        /// <summary>Move item to a different bag slot (rearrange).</summary>
        public static void MoveItem(int dwId, int newSlot)
        {
            if (!CheckConnected($"MoveItem dwId={dwId}")) return;
            Net.SendCmd(PlayerDataProtocol.CMD_BAG_MOVE_ITEM, dwId, newSlot);
            Debug.Log($"[BagNet] MoveItem dwId={dwId} newSlot={newSlot}");
        }

        /// <summary>Split a stack into two stacks (splitCount moves into a fresh slot).</summary>
        public static void SplitItem(int dwId, int splitCount)
        {
            if (!CheckConnected($"SplitItem dwId={dwId}")) return;
            Net.SendCmd(PlayerDataProtocol.CMD_BAG_SPLIT_ITEM, dwId, splitCount);
            Debug.Log($"[BagNet] SplitItem dwId={dwId} splitCount={splitCount}");
        }
    }
}
