// =======================================================================
//  PlayerDataProtocol.cs — Shared wire protocol for player/bag/equip sync.
//
//  NEW command IDs (200-207). Chosen to NOT overlap with original KTO
//  command IDs (which use 20, 100-106, 32200, 408-409, 50004-50006). This
//  range (200-210) is unused in the existing protocol, verified by grep
//  of LoginProtocol.cs + server's TCPGameServerCmds enum.
//
//  All packets use colon-separated text payload (matches existing KTO
//  convention — see NpcNetworkHandler.OnRecvNewNpc).
//
//  WIRE FORMAT (server → client):
//
//    CMD_PLAYER_STATE (200) — sent once after CMD_PLAY_GAME ack
//      level:exp:hp:mp:
//      gold:yuanBao:coin:jingHuo:
//      freePoints:str:agi:con:dex:
//      posX:posY:mapCode:factionId:sex:
//      fightPower
//
//    CMD_HP_MP_CHANGE (201)
//      hp:mp
//
//    CMD_MONEY_CHANGE (202)
//      moneyType:newValue         (moneyType: 0=Gold 1=YuanBao 2=Coin 3=JingHuo)
//
//    CMD_EXP_GAIN (203)
//      newExp:newLevel            (level unchanged if no level-up)
//
//    CMD_BAG_SYNC (204)
//      numItems[:slot:dwId:tmplId:amount:lvl:bind:expiry]*
//
//    CMD_BAG_ITEM_UPDATE (205)
//      slot:dwId:tmplId:amount:lvl:bind:expiry   (dwId=0 = slot cleared)
//
//    CMD_EQUIP_SYNC (206)
//      numSlots[:equipPos:dwId:tmplId:lvl:gem1:gem2]*
//
//    CMD_EQUIP_SLOT_UPDATE (207)
//      equipPos:dwId:tmplId:lvl:gem1:gem2        (dwId=0 = slot cleared)
//
//  ── CLIENT → SERVER BAG ACTIONS (50200-50206) ──────────────────────
//
//  Thin colon-text wrapper around the original server's protobuf
//  CMD_SPR_MOD_GOODS (131) / CMD_SPR_USEGOODS (160) handlers. Each CMD
//  below is translated server-side (KT_TCPHandler_BagAction.cs) into
//  the 9-field payload `roleID:modType:id:goodsID:isusing:site:gcount:
//  bagindex:extraParams` expected by `Global.ModifyGoodsByCmdParams`.
//
//  After a successful mutation the server emits CMD_BAG_ITEM_UPDATE (205)
//  and/or CMD_EQUIP_SLOT_UPDATE (207) back to the client.
//
//  Why 50200-50206: IDs 208-214 were originally considered but collide
//  with existing server C→S dispatch cases (CMD_GETJINGMAILIST=208 etc.).
//  Range 50200+ is empty in TCPGameServerCmds enum and safe for new
//  extensions — matches the KTO convention of CMD_KT_* extensions in
//  45000+ / 50000+.
//
//    CMD_BAG_USE_ITEM     (50200)  dwId:count
//    CMD_BAG_EQUIP_ITEM   (50201)  dwId:equipPos          (equipPos: 1=Helm ... 10=Amulet)
//    CMD_BAG_UNEQUIP_ITEM (50202)  dwId:targetSlot        (targetSlot = bag slot to land in; -1 = auto)
//    CMD_BAG_DROP_ITEM    (50203)  dwId:count
//    CMD_BAG_SELL_ITEM    (50204)  dwId:count
//    CMD_BAG_MOVE_ITEM    (50205)  dwId:newSlot
//    CMD_BAG_SPLIT_ITEM   (50206)  dwId:splitCount        (server lands new stack in first empty slot)
// =======================================================================
namespace KTO.Network
{
    public static class PlayerDataProtocol
    {
        public const ushort CMD_PLAYER_STATE       = 200;
        public const ushort CMD_HP_MP_CHANGE       = 201;
        public const ushort CMD_MONEY_CHANGE       = 202;
        public const ushort CMD_EXP_GAIN           = 203;
        public const ushort CMD_BAG_SYNC           = 204;
        public const ushort CMD_BAG_ITEM_UPDATE    = 205;
        public const ushort CMD_EQUIP_SYNC         = 206;
        public const ushort CMD_EQUIP_SLOT_UPDATE  = 207;

        // C→S bag actions (50200-50206).
        // Must match GameServer KT_* enum values and the dispatch
        // cases in TCPCmdHandler.ProcessGameCmd.
        public const ushort CMD_BAG_USE_ITEM     = 50200;
        public const ushort CMD_BAG_EQUIP_ITEM   = 50201;
        public const ushort CMD_BAG_UNEQUIP_ITEM = 50202;
        public const ushort CMD_BAG_DROP_ITEM    = 50203;
        public const ushort CMD_BAG_SELL_ITEM    = 50204;
        public const ushort CMD_BAG_MOVE_ITEM    = 50205;
        public const ushort CMD_BAG_SPLIT_ITEM   = 50206;
    }
}
