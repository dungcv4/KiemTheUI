using UnityEngine;

namespace KTO.Game
{
    // Source: _shared/DecompiledSource/NpcResTemplate.cs (16 fields)
    //         KTO_DecompiledReference/_root/NpcResTemplate.c (constructor body)
    //         Setting/Npc/Res/NpcRes.tab (64 entries, extracted via /tmp/kto_pack_extractor.py)
    //
    // NpcResTemplate defines the visual appearance params for an NPC sprite:
    // which bundle to load, scale, collider size, dialog radius, head text
    // position, etc.
    //
    // In the original client these are loaded from NpcRes.tab via TabLoader.
    // For Phase 9.1 we construct them directly from server-supplied data
    // (NpcResId → hardcoded defaults or tab-loaded values).

    /// <summary>
    /// Visual resource template for an NPC.
    /// One template is shared by all NPCs using the same ResId.
    /// </summary>
    public class NpcResTemplate
    {
        // Source: NpcResTemplate.cs field offsets 0x10-0x78
        //         NpcResTemplate.c constructor reads from TabLoader.Row

        /// <summary>NPC visual resource ID (e.g. 12392..14012 from NpcRes.tab)</summary>
        public int    m_nResId;              // 0x10

        /// <summary>Bundle path (e.g. "npc/enemy/passerby001")</summary>
        public string m_szResFile;           // 0x18

        /// <summary>Shadow sprite bundle path</summary>
        public string m_szShadowResFile;     // 0x20

        /// <summary>Head text display position (world offset from NPC origin)</summary>
        public Vector3 m_HeadTextPos;        // 0x28

        /// <summary>Head text scale multiplier</summary>
        public float  m_fHeadTextScale;      // 0x40

        /// <summary>Blood/HP bar display position (world offset from NPC origin)</summary>
        public Vector3 m_BloodBarPos;        // 0x44

        /// <summary>Select-effect scale multiplier</summary>
        public float  m_fSelectEffectScale;  // 0x5C

        /// <summary>Dialog interaction radius (world units). Default 1.0</summary>
        public float  m_fDialogRadius;       // 0x60

        /// <summary>NPC world scale. Default 1.0</summary>
        public float  m_fScale;              // 0x64

        /// <summary>Whether to show the box collider (1 = show)</summary>
        public int    m_ShowBoxCollider;      // 0x68

        /// <summary>BoxCollider2D half-width. Default 0.6</summary>
        public float  m_fBoxColliderSizeX;   // 0x6C

        /// <summary>BoxCollider2D half-height. Default 0.6</summary>
        public float  m_fBoxColliderSizeY;   // 0x70

        /// <summary>BoxCollider2D offset X. Default 0.0</summary>
        public float  m_fBoxColliderPosX;    // 0x74

        /// <summary>BoxCollider2D offset Y. Default 0.4 (feet-to-center)</summary>
        public float  m_fBoxColliderPosY;    // 0x78

        // --- Static: ride offset ---
        // Source: NpcResTemplate.c constructor — nRideLogicOffset = 0x280 (640)
        public static int nRideLogicOffset = 640;
        public static Vector3 BodyEffectRidePos = new Vector3(0f, 0.4f, 0f);

        /// <summary>
        /// Construct a template with sensible defaults.
        /// Source: NpcResTemplate.c constructor — default values for each field.
        /// </summary>
        public NpcResTemplate(int resId = 0)
        {
            m_nResId             = resId;
            m_szResFile          = "";
            m_szShadowResFile    = "";
            m_HeadTextPos        = new Vector3(0f, 1.2f, 0f);
            m_fHeadTextScale     = 1f;
            m_BloodBarPos        = new Vector3(0f, 1.0f, 0f);
            m_fSelectEffectScale = 1f;
            m_fDialogRadius      = 1f;
            m_fScale             = 1f;
            m_ShowBoxCollider    = 1;
            m_fBoxColliderSizeX  = 0.6f;
            m_fBoxColliderSizeY  = 0.6f;
            m_fBoxColliderPosX   = 0f;
            m_fBoxColliderPosY   = 0.4f;
        }
    }
}
