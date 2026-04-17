using UnityEngine;
using KTO.Game;

namespace KTO.Network
{
    // =======================================================================
    //  NpcNetworkHandler.cs — Receives NPC spawn/remove packets from server
    //
    //  Source of truth (client-side):
    //    KTO_DecompiledReference/_root/NpcManager.c:CreateNpc (IL2CPP)
    //      → void CreateNpc(int nNpcId, int nLogicX, int nLogicY,
    //                        int nNpcResID, int nKind, bool bIsMe,
    //                        int nBloodStyle, int nNotShowShadow, int nTalkType)
    //
    //    KTO_DecompiledReference/_root/RepresentEvent.c:CreateNpc (IL2CPP)
    //      → Server fires RepresentEvent.CreateNpc(11 params) which unpacks
    //        param8 into nNotShowShadow + nTalkType, then calls NpcManager.CreateNpc
    //
    //  Protocol (server → client, colon-separated text via CMD_SPR_NEWNPC 408):
    //    npcID:resID:resName:name:title:posX:posY:dir:kind:bloodStyle:notShowShadow:talkType:visibleOnMinimap
    //
    //  See: .claude/skills/npc-server-protocol/SKILL.md
    // =======================================================================

    public class NpcNetworkHandler : MonoBehaviour
    {
        public static NpcNetworkHandler Instance { get; private set; }

        void Awake()
        {
            if (Instance != null && Instance != this) { Destroy(gameObject); return; }
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        void Start()
        {
            var net = NetworkManager.Instance;
            if (net == null)
            {
                Debug.LogWarning("[NpcNetworkHandler] NetworkManager not found — " +
                                 "NPC packets won't be handled");
                return;
            }

            net.RegisterHandler(LoginProtocol.CMD_SPR_NEWNPC, OnRecvNewNpc);
            net.RegisterHandler(LoginProtocol.CMD_SPR_DELNPC, OnRecvDelNpc);

            Debug.Log("[NpcNetworkHandler] Registered CMD_SPR_NEWNPC (408) + CMD_SPR_DELNPC (409)");
        }

        void OnDestroy()
        {
            var net = NetworkManager.Instance;
            if (net != null)
            {
                net.UnregisterHandler(LoginProtocol.CMD_SPR_NEWNPC);
                net.UnregisterHandler(LoginProtocol.CMD_SPR_DELNPC);
            }
            if (Instance == this) Instance = null;
        }

        // ===================================================================
        //  CMD_SPR_NEWNPC (408) — Server sends NPC spawn data
        //
        //  Format: npcID:resID:resName:name:title:posX:posY:dir:kind:
        //          bloodStyle:notShowShadow:talkType:visibleOnMinimap
        //
        //  Source: GameServer ClientManager.NotifyMySelfNewNPC
        //  → maps to NpcManager.CreateNpc (Phase 9.1)
        // ===================================================================
        void OnRecvNewNpc(string payload)
        {
            string[] f = KTPacket.SplitFields(payload);
            if (f.Length < 13)
            {
                Debug.LogWarning($"[NpcNetworkHandler] CMD_SPR_NEWNPC: expected 13 fields, got {f.Length}: {payload}");
                return;
            }

            int    npcId          = int.Parse(f[0]);
            int    resId          = int.Parse(f[1]);
            string resName        = f[2];       // sprite bundle name (e.g. "passerby062")
            string npcName        = f[3];       // display name (Vietnamese)
            string npcTitle       = f[4];       // title text
            int    posX           = int.Parse(f[5]);  // logic X
            int    posY           = int.Parse(f[6]);  // logic Y
            int    dir            = int.Parse(f[7]);  // Direction enum (0-7)
            int    kind           = int.Parse(f[8]);  // NpcKind enum
            int    bloodStyle     = int.Parse(f[9]);
            int    notShowShadow  = int.Parse(f[10]);
            int    talkType       = int.Parse(f[11]);
            int    visibleMinimap = int.Parse(f[12]);

            Debug.Log($"[NpcNetworkHandler] NewNpc id={npcId} res={resId} resName={resName} " +
                      $"name={npcName} pos=({posX},{posY}) dir={dir} kind={kind}");

            // Ensure NpcManager is initialized
            NpcManager.Init();

            // Create NPC via the Phase 9.1 entity system
            // Source: NpcManager.CreateNpc matches IL2CPP signature exactly
            Npc npc = NpcManager.CreateNpc(
                nNpcId:          npcId,
                nLogicX:         posX,
                nLogicY:         posY,
                nNpcResID:       resId,
                nKind:           kind,
                bIsMe:           false,          // server NPCs are never "me"
                nBloodStyle:     bloodStyle,
                nNotShowShadow:  notShowShadow,
                nTalkType:       talkType,
                resName:         resName         // Phase 9.4: bundle name for sprite render
            );

            if (npc != null)
            {
                // Store additional data not in CreateNpc signature
                // These come from the server but aren't part of the IL2CPP
                // NpcManager.CreateNpc — they're set via separate RepresentEvent
                // calls in the original (SetNpcRepName, etc.)
                npc.name = $"Npc_{npcId}_{resName}";

                // Set initial direction from server
                // Source: Npc.c:ChangeLogicDir — dir is 0-7 Direction enum,
                // but ChangeLogicDir expects 0-255 logic dir.
                // Server sends Direction enum (0-7), convert to logic dir range.
                // Direction enum maps: 0→0, 1→32, 2→64, 3→96, 4→128, 5→160, 6→192, 7→224
                int logicDir = dir * 32;
                npc.ChangeLogicDir(logicDir);
            }
        }

        // ===================================================================
        //  CMD_SPR_DELNPC (409) — Server removes NPC from map
        //
        //  Format: npcID:mapCode
        //
        //  Source: GameServer ClientManager.NotifyMySelfDelNPC
        //  → maps to NpcManager.RemoveNpc (Phase 9.1)
        // ===================================================================
        void OnRecvDelNpc(string payload)
        {
            string[] f = KTPacket.SplitFields(payload);
            if (f.Length < 1)
            {
                Debug.LogWarning($"[NpcNetworkHandler] CMD_SPR_DELNPC: empty payload");
                return;
            }

            int npcId = int.Parse(f[0]);
            // f[1] = mapCode (not used on client — we only have one map loaded)

            Debug.Log($"[NpcNetworkHandler] DelNpc id={npcId}");
            NpcManager.RemoveNpc(npcId);
        }

        // ===================================================================
        //  SendClickNpc — Client tells server player clicked an NPC
        //
        //  Source: TCPGameServerCmds.CMD_KT_CLICKON_NPC = 50004
        //  Original flow: InputModule.On_SimpleTap → LuaTables.SimpleTap
        //    → Lua Operation:SimpleTap → (for dialoger) Operation:OnDialogerClicked
        //    → RemoteServer.OnSimpleTapNpc(npcId)
        //
        //  This is the C# equivalent of RemoteServer.OnSimpleTapNpc
        // ===================================================================
        public static void SendClickNpc(int npcId)
        {
            var net = NetworkManager.Instance;
            if (net == null) return;

            net.SendCmd(LoginProtocol.CMD_KT_CLICKON_NPC, npcId);
            Debug.Log($"[NpcNetworkHandler] SendClickNpc id={npcId}");
        }
    }
}
