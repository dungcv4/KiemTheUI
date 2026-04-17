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
    }
}
