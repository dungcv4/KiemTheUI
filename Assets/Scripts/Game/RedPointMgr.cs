// =======================================================================
//  RedPointMgr.cs — Red-dot notification registry (stub).
//
//  Source: 39_CommonUI/Lua/RedPointMgr.lua (~1500 lines — full graph of
//  event dependencies, tree propagation, etc.)
//  Used by UIBag / UISkill / UITask / almost every window to flag buttons
//  with a red dot when there's unread / actionable state.
//
//  This is a STUB — accepts DynamicRegisteRedPoint calls without actually
//  rendering dots. Full red-point tree pending Phase 2+ when event source
//  counts are wired (quest availability, mail unread, guild invites, etc.).
// =======================================================================
using System.Collections.Generic;
using UnityEngine;

namespace KTO.Game
{
    public static class RedPointMgr
    {
        /// <summary>
        /// Enum of event IDs referenced by UIBag + UISkill. Values are
        /// arbitrary local ints — the Lua uses a global enum table that we
        /// partially mirror here. Add more as controllers reference them.
        /// </summary>
        public enum EventKind
        {
            None = 0,
            PotentialPointLeft,
            HelmEnhance,
            AmuletEnhance,
            ZhenFaLevelUp,
            ZhenFaZJLevelUpBegin,
            ZhenFaZJLevelUpEnd,
            ShenBingBagEntrance,
            HorseLevel,
            HorseEquipGrade1,
            HorseSkillLevelBegin,
            HorseSkillLevelEnd,
            HorseSkillStoneBegin,
            HorseSkillStoneEnd,
            FashionPrettyStageAward,
            FactionSkill,
            KinSkill,
            SecretBookLevelEnough,
            SecretBookCanLevelUp,
            ZongShiSkill,
        }

        /// <summary>Expose nested class mirroring `RedPointMgr.EVENT.FieldName` Lua access pattern.</summary>
        public static class EVENT
        {
            public const int PotentialPointLeft        = (int)EventKind.PotentialPointLeft;
            public const int HelmEnhance               = (int)EventKind.HelmEnhance;
            public const int AmuletEnhance             = (int)EventKind.AmuletEnhance;
            public const int ZhenFaLevelUp             = (int)EventKind.ZhenFaLevelUp;
            public const int ZhenFaZJLevelUpBegin      = (int)EventKind.ZhenFaZJLevelUpBegin;
            public const int ZhenFaZJLevelUpEnd        = (int)EventKind.ZhenFaZJLevelUpEnd;
            public const int ShenBingBagEntrance       = (int)EventKind.ShenBingBagEntrance;
            public const int HorseLevel                = (int)EventKind.HorseLevel;
            public const int HorseEquipGrade1          = (int)EventKind.HorseEquipGrade1;
            public const int HorseSkillLevelBegin      = (int)EventKind.HorseSkillLevelBegin;
            public const int HorseSkillLevelEnd        = (int)EventKind.HorseSkillLevelEnd;
            public const int HorseSkillStoneBegin      = (int)EventKind.HorseSkillStoneBegin;
            public const int HorseSkillStoneEnd        = (int)EventKind.HorseSkillStoneEnd;
            public const int FashionPrettyStageAward   = (int)EventKind.FashionPrettyStageAward;
            public const int FactionSkill              = (int)EventKind.FactionSkill;
            public const int KinSkill                  = (int)EventKind.KinSkill;
            public const int SecretBookLevelEnough     = (int)EventKind.SecretBookLevelEnough;
            public const int SecretBookCanLevelUp      = (int)EventKind.SecretBookCanLevelUp;
            public const int ZongShiSkill              = (int)EventKind.ZongShiSkill;
        }

        /// <summary>
        /// Original signature:
        ///   RedPointMgr:DynamicRegisteRedPoint(pPanel, szControlPath, tbEventList)
        /// Registers a red-dot on the given button; dot appears when any
        /// event in tbEventList has a positive count.
        ///
        /// Stub currently just tracks registrations so Unregist matches.
        /// </summary>
        public static void DynamicRegisteRedPoint(GameObject pPanel, string szControlPath, params int[] tbEventList)
        {
            // TODO Phase 2: spawn red-dot GO under the control path, subscribe
            // to each event, toggle visibility on count change.
        }

        /// <summary>Counterpart of DynamicRegisteRedPoint. Stub no-op.</summary>
        public static void DynamicUnRegist(GameObject pPanel, string szControlPath)
        {
            // TODO Phase 2: find the dot GO, unsubscribe, destroy.
        }

        // ----- event counters (for future full implementation) -----
        static readonly Dictionary<int, int> _counts = new Dictionary<int, int>();
        public static int GetCount(int eventId) => _counts.TryGetValue(eventId, out var n) ? n : 0;
        public static void SetCount(int eventId, int count) { _counts[eventId] = count; }
    }
}
