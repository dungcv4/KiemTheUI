using UnityEngine;

namespace KTO.Game
{
    // =======================================================================
    //  Npc.cs — NPC entity MonoBehaviour (Phase 9.1 port)
    //
    //  Sources:
    //    _shared/DecompiledSource/Npc.cs       — 123 fields, 152 method stubs
    //    KTO_DecompiledReference/_root/Npc.c   — IL2CPP method bodies (277 KB)
    //
    //  Key methods ported:
    //    InitData          — Npc.c:38-309   (ID storage, layer, scale, dir, mask)
    //    CreateBoxCollider — Npc.c:432-484  (BoxCollider2D from NpcResTemplate)
    //    ChangeLogicDir    — Npc.c:2147-2186 (dir16→dir8 LUT, dirty flag)
    //    OnRecycle         — Npc.c:893-1048  (cleanup for pool return)
    //
    //  Fields ported: only the ~25 essential for entity lifecycle + click
    //  detection. The full 123 fields (HP, effects, sounds, ride, hide,
    //  feature parts, etc.) are deferred to later phases.
    //
    //  GUID preserved: 3044702afc7080759418579450c42f50 (AssetRipper stub)
    //  executionOrder: -6 (from original, ensures Npc.Update runs before
    //  camera + UI scripts)
    // =======================================================================

    [DefaultExecutionOrder(-6)]
    public class Npc : MonoBehaviour
    {
        // -------------------------------------------------------------------
        //  Core identity fields (offsets from DecompiledSource/Npc.cs)
        // -------------------------------------------------------------------

        /// <summary>Server-assigned NPC instance ID. Unique per NPC on the map.</summary>
        public int m_nNpcID;                      // 0x20

        /// <summary>Visual resource ID → which sprite bundle to load.</summary>
        public int m_nNpcResID;                    // 0x24

        /// <summary>Visual resource template (scale, collider, dialog radius).</summary>
        public NpcResTemplate m_NpcResTemplate;    // 0x28

        // -------------------------------------------------------------------
        //  Transform cache
        // -------------------------------------------------------------------
        public Transform m_Transform;              // 0xA0
        public GameObject m_Object;                // 0xA8

        /// <summary>Current world position (kept in sync with logic pos).</summary>
        public Vector3 m_vePos;                    // 0xB0

        // -------------------------------------------------------------------
        //  Identity flags
        // -------------------------------------------------------------------
        /// <summary>True if this NPC is the local player ("me").</summary>
        public bool m_bIsMe;                       // 0xBC

        /// <summary>NPC archetype / kind (dialoger, player, monster, etc.).</summary>
        public int m_nKind;                        // 0xE4

        /// <summary>Blood bar style (server-supplied).</summary>
        public int m_nBloodStyle;                  // 0xE8

        /// <summary>Talk interaction type (server-supplied).</summary>
        public int m_nTalkType;                    // 0xF4

        // -------------------------------------------------------------------
        //  Scale
        // -------------------------------------------------------------------
        /// <summary>Current interpolating scale.</summary>
        public float m_fCurSize = 1f;              // 0xC4

        /// <summary>Target scale (from NpcResTemplate.m_fScale).</summary>
        public float m_fDstSize = 1f;              // 0xC8

        // -------------------------------------------------------------------
        //  Action / animation state
        // -------------------------------------------------------------------
        /// <summary>Current visual action (FightStand, FightRun, etc.).</summary>
        public NpcAction _CurAction = NpcAction.FightStand;   // 0x150

        /// <summary>Current 8-direction visual direction.</summary>
        public Direction _CurRepresentDir = Direction.Bottom;  // 0x154

        /// <summary>Raw 16-direction logic dir (0..255).</summary>
        public int _LogicDir;                      // 0x160

        /// <summary>Flag: animation needs refresh on next frame.</summary>
        public bool _NeedUpdateAnimation;          // 0x170

        // -------------------------------------------------------------------
        //  Display data (name, title)
        //
        //  Source: Npc.cs:0x30 m_szName, 0x38 m_szTitle (DecompiledSource)
        //  Set by: NpcNetworkHandler.OnRecvNewNpc (server) or
        //          TestSpawnNpcs (editor test data)
        //
        //  In the original, these feed into UESHead._Name.text and
        //  UESHead._Title.text respectively, managed by
        //  UESNpcHeadTextSet.Attach (RepresentModule).
        // -------------------------------------------------------------------

        /// <summary>NPC display name (Vietnamese). Set by server or test data.</summary>
        public string m_szName;                        // 0x30

        /// <summary>NPC title text (guild name, rank, etc.).</summary>
        public string m_szTitle;                       // 0x38

        // -------------------------------------------------------------------
        //  Represent mask (bit flags controlling visual parts)
        // -------------------------------------------------------------------
        /// <summary>
        /// Bitmask controlling which visual parts are active.
        /// Source: Npc.c:InitData lines 200-280
        /// </summary>
        public int _RepresentMask;                 // 0x2F8

        /// <summary>
        /// True after the represent (sprite assembler) has been created.
        /// </summary>
        public bool bRepresent;                    // 0x308

        // -------------------------------------------------------------------
        //  Friendship (for click/tap dispatch)
        // -------------------------------------------------------------------
        /// <summary>True if this NPC is friendly to the local player.</summary>
        public bool _IsFriend;                     // 0x21A

        // -------------------------------------------------------------------
        //  Rendering — sprite assembler
        //
        //  Phase 9.4: switched from PlayerAssembler (3-part body+head+shadow)
        //  to NpcAssembler (single body sprite). NpcAssembler reads
        //  Resources/NpcAssets/<resName>.json + Assets/Sprite/Npc/<resName>/*.png
        //  produced by /tmp/extract_npc_bundle.py.
        //
        //  resName comes from server CMD_SPR_NEWNPC field 2 (or test data).
        //  In the original it lives on NpcResTemplate.m_szResFile, which is
        //  populated by RepresentSetting.GetNpcRes(resId). Until the
        //  NpcRes.tab loader exists, we let callers set it directly.
        // -------------------------------------------------------------------
        NpcAssembler _assembler;

        /// <summary>BoxCollider2D for click detection (Physics2D.Raycast).</summary>
        BoxCollider2D _boxCollider;

        /// <summary>Head label (name + title above sprite). Phase 10.</summary>
        /// <remarks>
        /// Source: UESHead (offset 0x40 _Name, 0x48 _NameOutline, 0x38 _Title)
        ///         Attached via UESNpcHeadTextSet.Attach in original.
        ///         Phase 10: attached directly as child world-space Canvas.
        /// </remarks>
        NpcHeadLabel _headLabel;

        // ===================================================================
        //  InitData — Npc.c:38-309
        //
        //  Called by NpcManager.CreateNpc right after pool spawn.
        //  Stores IDs, sets layer, initialises scale + direction + mask.
        // ===================================================================
        public void InitData(int nNpcId, int nNpcResID, int nKind,
                             bool bIsMe, int nBloodStyle,
                             bool bShowShadow, int nTalkType)
        {
            m_nNpcID      = nNpcId;
            m_nNpcResID   = nNpcResID;
            m_nKind       = nKind;
            m_bIsMe       = bIsMe;
            m_nBloodStyle = nBloodStyle;
            m_nTalkType   = nTalkType;

            // --- Look up NpcResTemplate ---
            // Source: Npc.c:74 — m_NpcResTemplate = RepresentSetting.GetNpcRes(resId)
            // Phase 9.1: RepresentSetting is not ported yet. We create a
            // default template. When the tab-loader is wired, this will use
            // RepresentSetting.GetNpcRes(nNpcResID) instead.
            m_NpcResTemplate = new NpcResTemplate(nNpcResID);

            // --- Layer assignment ---
            // Source: Npc.c:85-98
            //   if (bIsMe)       → layer = GameDefine.MeLayer
            //   elif (nKind==1)  → layer = GameDefine.OtherPlayerLayer   (Player kind)
            //   else             → layer = GameDefine.NpcLayer
            int layer;
            if (bIsMe)
                layer = GameDefine.MeLayer;
            else if (nKind == (int)NpcKind.Player)
                layer = GameDefine.OtherPlayerLayer;
            else
                layer = GameDefine.NpcLayer;

            if (layer >= 0)
                gameObject.layer = layer;

            // --- Initial direction ---
            // Source: Npc.c:156 — _LogicDir = 0xAA (170 ≈ south-ish)
            _LogicDir = 0xAA;
            _CurRepresentDir = (Direction)GameDefine.Dir16ToDir8[(_LogicDir >> 4) & 0xF];

            // --- Scale from template ---
            // Source: Npc.c:162-164
            m_fCurSize = m_NpcResTemplate.m_fScale;
            m_fDstSize = m_NpcResTemplate.m_fScale;

            // --- Represent mask ---
            // Source: Npc.c:200-280 — sets bits per nKind
            // Simplified: always enable BoxCollider + Shadow for now.
            // Full mask logic (head text, blood bar per nKind) deferred.
            _RepresentMask = (int)(NpcRepresentMask.BoxCollider | NpcRepresentMask.Shadow);

            // If bShowShadow is false, clear shadow bit
            if (!bShowShadow)
                _RepresentMask &= ~(int)NpcRepresentMask.Shadow;

            // Dialogers get head text
            if (nKind == (int)NpcKind.Dialoger)
                _RepresentMask |= (int)NpcRepresentMask.HeadText;

            // Reset animation state
            _CurAction = NpcAction.FightStand;
            _NeedUpdateAnimation = true;
            bRepresent = false;
            _IsFriend = true; // Default friendly; server will update

            // Cache transform
            m_Transform = transform;
            m_Object    = gameObject;
        }

        // ===================================================================
        //  CreateBoxCollider — Npc.c:432-484
        //
        //  Adds a BoxCollider2D for Physics2D click detection.
        //  Size and offset come from NpcResTemplate.
        // ===================================================================
        public void CreateBoxCollider()
        {
            // Source: Npc.c:436 — checks _RepresentMask bit 0x100
            bool showCollider = (_RepresentMask & (int)NpcRepresentMask.BoxCollider) != 0;

            if (showCollider)
            {
                // Source: Npc.c:445 — AddMissingComponent<BoxCollider2D>
                _boxCollider = gameObject.GetComponent<BoxCollider2D>();
                if (_boxCollider == null)
                    _boxCollider = gameObject.AddComponent<BoxCollider2D>();

                _boxCollider.enabled = true;

                if (m_NpcResTemplate != null)
                {
                    // Source: Npc.c:455-460
                    // size from template offset 0x6C, offset from 0x74
                    _boxCollider.size = new Vector2(
                        m_NpcResTemplate.m_fBoxColliderSizeX,
                        m_NpcResTemplate.m_fBoxColliderSizeY);
                    _boxCollider.offset = new Vector2(
                        m_NpcResTemplate.m_fBoxColliderPosX,
                        m_NpcResTemplate.m_fBoxColliderPosY);
                }
                else
                {
                    // Fallback defaults matching NpcResTemplate constructor
                    _boxCollider.size   = new Vector2(0.6f, 0.6f);
                    _boxCollider.offset = new Vector2(0f, 0.4f);
                }
            }
            else
            {
                // Source: Npc.c:470-480 — disable existing collider
                _boxCollider = gameObject.GetComponent<BoxCollider2D>();
                if (_boxCollider != null)
                    _boxCollider.enabled = false;
            }
        }

        // ===================================================================
        //  ChangeLogicDir — Npc.c:2147-2186
        //
        //  Updates the raw 16-dir logic direction and derives the 8-dir
        //  visual direction via the Dir16ToDir8 LUT.
        // ===================================================================
        public void ChangeLogicDir(int dir16)
        {
            // Source: Npc.c:2155 — store raw at _LogicDir
            _LogicDir = dir16;

            // Source: Npc.c:2162-2168 — dir8 = Dir16ToDir8[dir16 >> 4]
            int idx = (dir16 >> 4) & 0xF;
            Direction newDir = (Direction)GameDefine.Dir16ToDir8[idx];

            if (_CurRepresentDir != newDir)
            {
                _CurRepresentDir    = newDir;
                _NeedUpdateAnimation = true;
            }

            // Source: Npc.c:2180 — if bIsMe, SetArrowDir(dir16)
            // Arrow direction indicator deferred to Phase 10.
        }

        // ===================================================================
        //  SetWorldPosition — helper wrapping the original's
        //  XPositionFrameBuffer.SetPosition logic
        //
        //  Source: Npc.c:ActiveAttribute:2320-2328
        //    SetPosition(logicX / 800.0, logicY / 1600.0, logicZ / 800.0)
        //  Phase 9.1: we skip the Z/height component (2D game plane).
        // ===================================================================
        public void SetWorldPosition(int logicX, int logicY)
        {
            float wx = logicX * Env.LOGIC_POS_CELL;
            float wy = logicY * Env.LOGIC_POS_CELL;
            m_vePos = new Vector3(wx, wy, 0f);
            if (m_Transform != null)
                m_Transform.position = m_vePos;
        }

        // ===================================================================
        //  CreateRepresent — instantiate the sprite assembler
        //
        //  Source: Npc.c:Active (2250-2268), called after InitData.
        //  Phase 9.1: uses PlayerAssembler with default sprites.
        //  When NpcResTemplate.m_szResFile is properly wired, this will
        //  load the correct NPC sprite bundle.
        // ===================================================================
        public void CreateRepresent()
        {
            if (bRepresent) return;

            // Pull bundle name from the template (set by NpcManager.CreateNpc
            // overload or NpcNetworkHandler before this call).
            string resName = m_NpcResTemplate != null ? m_NpcResTemplate.m_szResFile : null;
            if (string.IsNullOrEmpty(resName))
            {
                Debug.LogWarning($"[Npc {m_nNpcID}] CreateRepresent skipped: no resName on template");
                return;
            }

            _assembler = NpcAssembler.Attach(gameObject, resName, m_fCurSize);
            transform.localScale = new Vector3(m_fCurSize, m_fCurSize, 1f);

            _assembler.SetAction(_CurAction);
            _assembler.SetLogicDir(_LogicDir);

            bRepresent = true;
            _NeedUpdateAnimation = false;

            // --- Phase 10: Attach head label (name + title above sprite) ---
            // Source: Npc.c:Active (2250-2268) → after represent creation,
            //         RepresentEvent.c calls UESNpcHeadTextSet.Attach(nKind, isMe, npcSlot)
            //         then UESHead.SetName / SetTitle / SetNameColor
            // Phase 10: simplified to NpcHeadLabel.Attach (world-space Canvas child)
            _headLabel = NpcHeadLabel.Attach(this);
        }

        // ===================================================================
        //  RefreshHeadLabel — Update head label text after name/title change
        //
        //  In the original, name and title are set via separate RepresentEvent
        //  calls (SetNpcRepName, SetNpcRepTitle) which call UESHead.SetName /
        //  UESHead.SetTitle on the already-attached UESHead instance.
        //  Source: RepresentEvent.c → UESHead.SetName / SetTitle
        //
        //  Phase 10: called after m_szName / m_szTitle are set on the Npc,
        //  which happens after NpcManager.CreateNpc returns (by the caller:
        //  NpcNetworkHandler.OnRecvNewNpc or TestSpawnNpcs).
        // ===================================================================
        public void RefreshHeadLabel()
        {
            if (_headLabel == null) return;
            _headLabel.SetName(m_szName);
            _headLabel.SetTitle(m_szTitle);
            _headLabel.SetNameColor(m_nKind, m_bIsMe);
        }

        // ===================================================================
        //  DoAction — set the current animation action
        //
        //  Source: Npc.c:DoAction (1641-1731)
        //  Simplified: delegates to PlayerAssembler.SetAction
        // ===================================================================
        public void DoAction(NpcAction action)
        {
            if (_CurAction == action) return;
            _CurAction = action;
            _NeedUpdateAnimation = true;

            if (_assembler != null)
                _assembler.SetAction(action);
        }

        // ===================================================================
        //  OnRecycle — Npc.c:893-1048
        //
        //  Cleanup when the NPC is returned to the pool.
        //  Clears all references, disables collider, resets state.
        // ===================================================================
        public void OnRecycle()
        {
            // Source: Npc.c:920-940 — clear represent
            bRepresent = false;
            _RepresentMask = 0;

            // Disable collider
            if (_boxCollider != null)
            {
                _boxCollider.enabled = false;
                _boxCollider = null;
            }

            // Reset assembler
            if (_assembler != null)
            {
                _assembler.SetAction(NpcAction.FightStand);
                _assembler = null;
            }

            // Phase 10: Detach head label
            // Source: RepresentEvent.c → UESNpcHeadTextSet.Detach(nKind, isMe, npcSlot)
            //         UESHeadTextContrl.Detach → CollectHandler → OnRecycle + pool return
            if (_headLabel != null)
            {
                _headLabel.OnRecycle();
                _headLabel = null;
            }

            // Source: Npc.c:1000-1048 — zero out fields
            m_nNpcID         = 0;
            m_nNpcResID      = 0;
            m_NpcResTemplate = null;
            m_nKind          = (int)NpcKind.None;
            m_bIsMe          = false;
            m_nBloodStyle    = 0;
            m_nTalkType      = 0;
            m_fCurSize       = 1f;
            m_fDstSize       = 1f;
            _CurAction       = NpcAction.FightStand;
            _CurRepresentDir = Direction.Bottom;
            _LogicDir        = 0;
            _IsFriend        = true;
            _NeedUpdateAnimation = false;
            m_vePos          = Vector3.zero;
            m_Transform      = null;
            m_Object         = null;
            m_szName         = null;
            m_szTitle        = null;
        }

        // ===================================================================
        //  Update — Npc.c:2541-2563
        //
        //  Phase 9.1: only handles animation dirty flag.
        //  Full version calls UpdateFeature, UpdateRepresentPos,
        //  UpdateChangeSize, ProcSceneOcclusion, NpcFlyText.Update.
        // ===================================================================
        void Update()
        {
            if (!bRepresent) return;

            if (_NeedUpdateAnimation && _assembler != null)
            {
                _assembler.SetAction(_CurAction);
                _assembler.SetLogicDir(_LogicDir);
                _NeedUpdateAnimation = false;
            }
        }
    }
}
