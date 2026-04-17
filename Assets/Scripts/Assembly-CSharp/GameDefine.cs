using UnityEngine;

namespace KTO.Game
{
    // Source: _shared/DecompiledSource/GameDefine.cs (Cpp2IL stub, 68 fields, 9 enums)
    //         KTO_DecompiledReference/_root/GameDefine.c (IL2CPP .cctor body)
    //
    // The original GameDefine is a massive static class with sorting layers,
    // layer masks, action enums, direction enums, weapon→action maps, etc.
    // We port only the subset needed for Phase 9.1 (NPC entities).
    //
    // NpcAction and Direction enums are already defined in PlayerAssembler.cs
    // (KTO.Game namespace). We re-export Direction here for convenience but
    // do NOT duplicate NpcAction.

    /// <summary>
    /// 8-direction visual enum. Matches the sprite row layout in NpcAsset.
    /// Source: _shared/DecompiledSource/GameDefine.cs — enum Direction
    /// </summary>
    public enum Direction
    {
        Bottom      = 0,
        LeftBottom  = 1,
        Left        = 2,
        LeftTop     = 3,
        Top         = 4,
        RightTop    = 5,
        Right       = 6,
        RightBottom = 7,
        Count       = 8,
    }

    /// <summary>
    /// NPC kind / archetype. Determines layer, click behaviour, and
    /// represent mask bits.
    /// Source: _shared/DecompiledSource/GameDefine.cs — enum NpcKind
    ///         KTO_DecompiledReference/_root/NpcManager.c:CreateNpc (layer switch)
    /// </summary>
    public enum NpcKind
    {
        None             = -1,
        Normal           = 0,
        Player           = 1,
        Dialoger         = 2,
        Partner          = 3,
        Silencer         = 4,
        SilencerNoneName = 5,
        God              = 6,
        Mechanism        = 7,
        Sporter          = 8,
        Building         = 9,
    }

    /// <summary>
    /// Server→client action codes. Maps to NpcAction for animation.
    /// Source: _shared/DecompiledSource/GameDefine.cs — enum KE_NPC_ACTION
    /// </summary>
    public enum KE_NPC_ACTION
    {
        act_none        = 0,
        act_stand       = 1,
        act_run         = 2,
        act_death       = 3,
        act_bat         = 4,
        act_sit         = 5,
        act_attack1     = 6,
        act_attack2     = 7,
        act_magic       = 8,
        act_jump        = 9,
        act_randomattack = 10,
        act_fastattack  = 11,
        act_count       = 12,
    }

    /// <summary>
    /// Bit flags controlling what visual parts an NPC displays.
    /// Source: KTO_DecompiledReference/_root/Npc.c:InitData (represent mask setup)
    /// </summary>
    [System.Flags]
    public enum NpcRepresentMask
    {
        None           = 0,
        BoxCollider    = 0x0100,   // bit 8 — CreateBoxCollider checks this
        Shadow         = 0x0200,   // bit 9
        HeadText       = 0x0400,   // bit 10
        BloodBar       = 0x0800,   // bit 11
        Feature        = 0x1000,   // bit 12
    }

    /// <summary>
    /// Static constants + layer IDs ported from GameDefine.
    /// Source: _shared/DecompiledSource/GameDefine.cs (field offsets 0x00-0x18)
    ///         KTO_DecompiledReference/_root/GameDefine.c (.cctor body)
    /// </summary>
    public static class GameDefine
    {
        // --- Layer IDs (resolved at runtime via LayerMask.NameToLayer) ---
        // Source: GameDefine.cctor — `MeLayer = LayerMask.NameToLayer("Me")`
        //         etc. for OtherPlayerLayer, NpcLayer
        // Phase 9.1: we define the layer NAMES here; the TagManager.asset
        // is updated separately to create the actual layers.
        public const string MeLayerName          = "Me";
        public const string OtherPlayerLayerName = "OtherPlayer";
        public const string NpcLayerName         = "Npc";

        // Cached layer indices (initialised by Init or on first use)
        public static int MeLayer          { get; private set; }
        public static int OtherPlayerLayer { get; private set; }
        public static int NpcLayer         { get; private set; }

        // --- Tick rate (duplicated from Env for code that references GameDefine) ---
        // Source: GameDefine.cctor — `GAME_FPS = 0x12` (18)
        public const int GAME_FPS = 18;

        // --- Logic↔world conversion ---
        // Source: GameDefine struct offset 0x1C — LOGIC_POS_CELL = 1/800
        public const float LOGIC_POS_CELL = 0.00125f;

        // --- Dir16→Dir8 lookup table ---
        // Source: NpcDef.LogicDirToRepDir at global-metadata.dat 0x5a0528
        //         KTO_DecompiledReference/_root/Npc.c:ChangeLogicDir — `dir8 = array[dir16 >> 4]`
        // 16 logic directions → 8 visual directions
        public static readonly int[] Dir16ToDir8 =
            { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7 };

        // --- Player represent speed param ---
        // Source: GameDefine.cctor — PlayerRepresentSpeedParam dict
        // Maps Direction → speed multiplier for animation timing
        public static readonly float[] PlayerRepresentSpeedParam =
            { 2.0f, 1.5f, 1.0f, 1.5f, 2.0f, 1.5f, 1.0f, 1.5f };

        /// <summary>
        /// Call once at game startup (e.g. from GameStart or SceneLoadManager).
        /// Resolves layer names → layer indices.
        /// </summary>
        public static void Init()
        {
            MeLayer          = LayerMask.NameToLayer(MeLayerName);
            OtherPlayerLayer = LayerMask.NameToLayer(OtherPlayerLayerName);
            NpcLayer         = LayerMask.NameToLayer(NpcLayerName);

            // If layers aren't configured in TagManager, Unity returns -1.
            // Log a warning but don't crash — the game still works, just
            // click detection won't filter by layer.
            if (MeLayer < 0)
                Debug.LogWarning($"[GameDefine] Layer '{MeLayerName}' not found in TagManager. Add it to ProjectSettings.");
            if (OtherPlayerLayer < 0)
                Debug.LogWarning($"[GameDefine] Layer '{OtherPlayerLayerName}' not found in TagManager. Add it to ProjectSettings.");
            if (NpcLayer < 0)
                Debug.LogWarning($"[GameDefine] Layer '{NpcLayerName}' not found in TagManager. Add it to ProjectSettings.");
        }
    }
}
