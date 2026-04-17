// KTO Game Server protocol constants — extracted from KT_TCPHandler_Core.cs
namespace KTO.Network
{
    public static class LoginProtocol
    {
        // ── CMD IDs ──
        public const ushort CMD_LOGIN_ON2  = 20;
        public const ushort CMD_LOGIN_ON   = 100;
        public const ushort CMD_ROLE_LIST  = 101;
        public const ushort CMD_CREATE_ROLE = 102;
        public const ushort CMD_INIT_GAME  = 104;
        public const ushort CMD_PLAY_GAME  = 106;

        // Phase A "fake gate": server → client Lua EventNotify dispatch
        public const ushort CMD_SPR_FIRE_EVENT = 32200;

        // Phase 9.3: NPC spawn/remove — server → client
        // Source: GameServer TCPGameServerCmds enum (TCPCmdHandler.cs)
        // CMD_SPR_NEWNPC sends NPC data as colon-separated text:
        //   npcID:resID:resName:name:title:posX:posY:dir:kind:visibleOnMinimap
        // CMD_SPR_DELNPC sends: npcID:mapCode
        public const ushort CMD_SPR_NEWNPC  = 408;
        public const ushort CMD_SPR_DELNPC  = 409;

        // Phase 9.3: NPC click — client → server
        // Source: TCPGameServerCmds.CMD_KT_CLICKON_NPC = 50004
        public const ushort CMD_KT_CLICKON_NPC  = 50004;
        // Source: TCPGameServerCmds.CMD_KT_G2C_NPCDIALOG = 50005 (server → client)
        public const ushort CMD_KT_G2C_NPCDIALOG = 50005;
        // Source: TCPGameServerCmds.CMD_KT_C2G_NPCDIALOG = 50006 (client → server)
        public const ushort CMD_KT_C2G_NPCDIALOG = 50006;

        // ── Crypto keys ──
        public const string WEB_KEY   = "9377(*)#mst9";   // Login2 MD5 sign key
        public const string KEY_SHA1  = "abcde";           // Token SHA1 key
        public const string KEY_DATA  = "12345";           // Token data key
        public const string VER_SIGN  = "20140624";        // Protocol version

        // ── SDK endpoints ──
        public const string SDK_LOGIN     = "/LoginSDK.aspx";
        public const string SDK_REGISTER  = "/RegisterSDK.aspx";
        public const string SDK_VERIFY    = "/VerifyAccount.aspx";
        public const string SDK_SERVERS   = "/api/servers";

        // ── Error codes ──
        public const int ERR_SUCCESS           = 0;
        public const int ERR_SUCCESS_INFO      = 1;
        public const int ERR_TOKEN_EXPIRED     = -100;
        public const int ERR_VERSION_MISMATCH  = -2;
        public const int ERR_DUPLICATE_CONN    = -2;
        public const int ERR_SERVER_BUSY       = -11000;
        public const int ERR_CONN_DISABLED     = -11005;
        public const int ERR_INVALID_NAME      = -1;
        public const int ERR_OPERATION_DENIED  = -12;
        public const int ERR_CREATE_LIMIT      = -7;

        // ── Server status ──
        public const int STATUS_NORMAL    = 0;
        public const int STATUS_OFFLINE   = 1;
        public const int STATUS_RECOMMEND = 2;
        public const int STATUS_NEW       = 3;
        public const int STATUS_FULL      = 4;
        public const int STATUS_MAINTAIN  = 5;  // Custom: server under maintenance
    }
}
