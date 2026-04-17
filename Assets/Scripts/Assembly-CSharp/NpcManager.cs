using System.Collections.Generic;
using UnityEngine;

namespace KTO.Game
{
    // =======================================================================
    //  NpcManager.cs — Static NPC lifecycle manager (Phase 9.1 port)
    //
    //  Sources:
    //    _shared/DecompiledSource/NpcManager.cs     — 12 static fields, 33 methods
    //    KTO_DecompiledReference/_root/NpcManager.c  — IL2CPP method bodies
    //
    //  Key methods ported:
    //    Init       — NpcManager.c:307-376   (create root GameObjects)
    //    CreateNpc  — NpcManager.c:601-747   (spawn + InitData + layer parent)
    //    AddNpc     — NpcManager.c:760-823   (dict insert, evict duplicates)
    //    GetNpc     — NpcManager.c:1034-1055 (dict lookup)
    //    RemoveNpc  — NpcManager.c:837-1021  (cleanup + pool return)
    //
    //  The original NpcManager is a static class (all static fields + methods).
    //  We mirror that pattern here. The 3 root transforms (_NpcRoot,
    //  _PlayerRoot, _MeRoot) are children of DontDestroyOnLoad.
    //
    //  Phase 9.1 omits: ComponentPool<Npc> (uses Instantiate/Destroy),
    //  m_ShowingPlayer, m_ShowingTalkRangeNpc, m_ShowingBossHpRangeNpcID,
    //  CppApi.OnCreateNpcRepFinish, NpcSound, feature parts, scene occlusion.
    //
    //  GUID preserved: 4466ccff88dff8f17085baabe7c8e3cc (AssetRipper stub)
    // =======================================================================

    public static class NpcManager
    {
        // -------------------------------------------------------------------
        //  Static fields (offsets from DecompiledSource/NpcManager.cs)
        // -------------------------------------------------------------------

        /// <summary>All NPCs on the map. Key = m_nNpcID.</summary>
        static Dictionary<int, Npc> m_NpcMap = new Dictionary<int, Npc>();  // 0x00

        /// <summary>The local player NPC reference.</summary>
        static Npc m_Player;  // 0x08

        /// <summary>Root transform for non-player, non-me NPCs (monsters, dialogers, etc.).</summary>
        static Transform _NpcRoot;       // 0x10

        /// <summary>Root transform for other-player NPCs.</summary>
        static Transform _PlayerRoot;    // 0x18

        /// <summary>Root transform for the local player ("me").</summary>
        static Transform _MeRoot;        // 0x20

        /// <summary>True after Init() has been called.</summary>
        static bool _initialized;

        // ===================================================================
        //  Init — NpcManager.c:307-376
        //
        //  Creates the 3 root GameObjects parented under DontDestroyOnLoad.
        //  Called once at map load (SceneLoadManager or GameStart).
        // ===================================================================
        public static void Init()
        {
            if (_initialized) return;

            // Source: NpcManager.c:320-340
            // Creates "NpcLayer" (parent) → "OtherPlayerLayer" + "MeRoot" (children)
            // In our port we keep them as siblings under a shared root for clarity.
            var root = new GameObject("[NpcManager]");
            Object.DontDestroyOnLoad(root);

            var npcGo = new GameObject("NpcRoot");
            npcGo.transform.SetParent(root.transform, false);
            _NpcRoot = npcGo.transform;

            var playerGo = new GameObject("PlayerRoot");
            playerGo.transform.SetParent(root.transform, false);
            _PlayerRoot = playerGo.transform;

            var meGo = new GameObject("MeRoot");
            meGo.transform.SetParent(root.transform, false);
            _MeRoot = meGo.transform;

            // Ensure layer IDs are resolved
            GameDefine.Init();

            _initialized = true;
            Debug.Log("[NpcManager] Init complete — NpcRoot/PlayerRoot/MeRoot created");
        }

        // ===================================================================
        //  CreateNpc — NpcManager.c:601-747
        //
        //  Spawns an NPC, parents it under the correct root, sets position,
        //  calls InitData + CreateBoxCollider + CreateRepresent.
        //
        //  Signature matches the original:
        //    void CreateNpc(int nNpcId, int nLogicX, int nLogicY,
        //                   int nNpcResID, int nKind, bool bIsMe,
        //                   int nBloodStyle, int nNotShowShadow, int nTalkType)
        // ===================================================================
        public static Npc CreateNpc(int nNpcId, int nLogicX, int nLogicY,
                                     int nNpcResID, int nKind, bool bIsMe,
                                     int nBloodStyle, int nNotShowShadow,
                                     int nTalkType)
        {
            return CreateNpc(nNpcId, nLogicX, nLogicY, nNpcResID, nKind, bIsMe,
                             nBloodStyle, nNotShowShadow, nTalkType, "");
        }

        // ---------------------------------------------------------------
        //  Phase 9.4 overload — accepts the sprite-bundle resName.
        //
        //  DEVIATION (transitional, not in original IL2CPP):
        //    The original NpcManager.CreateNpc looks up resName via
        //    RepresentSetting.GetNpcRes(resId) → NpcResTemplate.m_szResFile,
        //    backed by Setting/Npc/Res/NpcRes.tab. Until that tab loader is
        //    ported, callers (NpcNetworkHandler / TestSpawnNpcs) pass
        //    resName directly so CreateRepresent can find the JSON manifest.
        //
        //  Once NpcRes.tab is wired, callers should drop this argument and
        //  the lookup will happen inside InitData like the original.
        // ---------------------------------------------------------------
        public static Npc CreateNpc(int nNpcId, int nLogicX, int nLogicY,
                                     int nNpcResID, int nKind, bool bIsMe,
                                     int nBloodStyle, int nNotShowShadow,
                                     int nTalkType, string resName)
        {
            if (!_initialized) Init();

            // Source: NpcManager.c:630 — spawn from pool
            // Phase 9.1: use Instantiate instead of ComponentPool
            var go = new GameObject($"Npc_{nNpcId}");
            var npc = go.AddComponent<Npc>();

            // Source: NpcManager.c:640-658 — parent under correct root
            Transform parent;
            if (bIsMe)
                parent = _MeRoot;
            else if (nKind == (int)NpcKind.Player)
                parent = _PlayerRoot;
            else
                parent = _NpcRoot;

            go.transform.SetParent(parent, false);

            // Source: NpcManager.c:665-670 — initial position
            // logicX * LOGIC_POS_CELL, logicY * LOGIC_POS_CELL
            float wx = nLogicX * Env.LOGIC_POS_CELL;
            float wy = nLogicY * Env.LOGIC_POS_CELL;
            go.transform.position = new Vector3(wx, wy, 0f);

            // Source: NpcManager.c:680 — AddNpc (dict insert)
            AddNpc(nNpcId, npc);

            // Source: NpcManager.c:690 — InitData
            bool bShowShadow = (nNotShowShadow == 0);
            npc.InitData(nNpcId, nNpcResID, nKind, bIsMe, nBloodStyle,
                         bShowShadow, nTalkType);

            // Phase 9.4 transitional bridge: stamp resName onto the template
            // so CreateRepresent can find the right JSON. See overload header.
            if (!string.IsNullOrEmpty(resName) && npc.m_NpcResTemplate != null)
                npc.m_NpcResTemplate.m_szResFile = resName;

            // Source: NpcManager.c:700 — store player ref
            if (bIsMe)
                m_Player = npc;

            // Source: NpcManager.c:710-720 — CreateBoxCollider + CreateRepresent
            npc.CreateBoxCollider();
            npc.CreateRepresent();

            // Set initial position via the Npc's own method (caches m_vePos)
            npc.SetWorldPosition(nLogicX, nLogicY);

            Debug.Log($"[NpcManager] CreateNpc id={nNpcId} res={nNpcResID} " +
                      $"kind={nKind} isMe={bIsMe} pos=({nLogicX},{nLogicY}) " +
                      $"world=({wx:F3},{wy:F3})");

            return npc;
        }

        // ===================================================================
        //  AddNpc — NpcManager.c:760-823
        //
        //  Inserts into m_NpcMap. If the ID already exists, removes the old
        //  NPC first (handles server re-sends gracefully).
        // ===================================================================
        public static void AddNpc(int nNpcId, Npc npc)
        {
            // Source: NpcManager.c:775-790 — evict existing if duplicate ID
            if (m_NpcMap.TryGetValue(nNpcId, out Npc existing))
            {
                Debug.LogWarning($"[NpcManager] AddNpc: duplicate id={nNpcId}, removing old");
                RemoveNpc(nNpcId);
            }

            m_NpcMap[nNpcId] = npc;
        }

        // ===================================================================
        //  GetNpc — NpcManager.c:1034-1055
        // ===================================================================
        public static Npc GetNpc(int nNpcId)
        {
            m_NpcMap.TryGetValue(nNpcId, out Npc npc);
            return npc;
        }

        /// <summary>Get the local player NPC ("me").</summary>
        public static Npc GetPlayer() => m_Player;

        /// <summary>All NPC instances. Read-only access for iteration.</summary>
        public static IReadOnlyDictionary<int, Npc> AllNpcs => m_NpcMap;

        // ===================================================================
        //  RemoveNpc — NpcManager.c:837-1021
        //
        //  Removes an NPC from the map, recycles it, and destroys the GO.
        //  Phase 9.1: no pool — just Destroy.
        // ===================================================================
        public static void RemoveNpc(int nNpcId)
        {
            if (!m_NpcMap.TryGetValue(nNpcId, out Npc npc))
            {
                Debug.LogWarning($"[NpcManager] RemoveNpc: id={nNpcId} not found");
                return;
            }

            m_NpcMap.Remove(nNpcId);

            // Source: NpcManager.c:880 — clear player ref
            if (m_Player == npc)
                m_Player = null;

            // Source: NpcManager.c:900 — recycle (clear state)
            if (npc != null)
            {
                npc.OnRecycle();
                Object.Destroy(npc.gameObject);
            }

            Debug.Log($"[NpcManager] RemoveNpc id={nNpcId}");
        }

        // ===================================================================
        //  RemoveAllNpcs — convenience for map transitions
        //
        //  Not a direct port; the original uses RemoveNpc in a loop from
        //  NpcManager.Clear (NpcManager.c:1080-1120).
        // ===================================================================
        public static void RemoveAllNpcs()
        {
            var ids = new List<int>(m_NpcMap.Keys);
            foreach (int id in ids)
                RemoveNpc(id);

            m_NpcMap.Clear();
            m_Player = null;
        }

        /// <summary>Number of NPCs currently on the map.</summary>
        public static int Count => m_NpcMap.Count;

        // ===================================================================
        //  Shutdown — cleanup for scene unload / app quit
        // ===================================================================
        public static void Shutdown()
        {
            RemoveAllNpcs();

            if (_NpcRoot != null)    Object.Destroy(_NpcRoot.parent.gameObject);
            _NpcRoot    = null;
            _PlayerRoot = null;
            _MeRoot     = null;
            _initialized = false;

            Debug.Log("[NpcManager] Shutdown complete");
        }
    }
}
