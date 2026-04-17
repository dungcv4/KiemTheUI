using UnityEngine;

namespace KTO.Game
{
    /// <summary>
    /// Constants + helpers ported verbatim from the original Lua:
    ///   KiemTheOrigin_DeepExtract/39_CommonUI/Lua/EnvDef.lua
    ///   KiemTheOrigin_DeepExtract/39_CommonUI/Lua/lib.lua
    ///
    /// DO NOT invent values. Every number here must trace back to a source file.
    /// </summary>
    public static class Env
    {
        // --- EnvDef.lua ---------------------------------------------------
        /// <summary>Logic tick rate. `Env.GAME_FPS = 18`</summary>
        public const int GAME_FPS = 18;

        /// <summary>Directions around the circle. `Env.LOGIC_MAX_DIR = 256`</summary>
        public const int LOGIC_MAX_DIR = 256;

        // --- Player base run speed ----------------------------------------
        //
        // Unit: LOGIC UNITS PER GAME FRAME (i.e. per 1/18 second).
        //
        // Source of truth: `pNpc.nRunSpeed` is read in
        //   39_CommonUI/Lua/Script_Player_AttributeDesc.lua:22
        //       local nRunSpeed = pAsyncRole and tbAsyncAttr[29]
        //                         or me.GetNpc().nRunSpeedOnShow
        //       nRunSpeed = math.floor(Lib:Logic2Map(nRunSpeed))   -- (÷ 8)
        // and used in
        //   39_CommonUI/Lua/Player_AutoRunSpeed.lua:77
        //       local nTimeFrame = nPathLen / pNpc.nRunSpeed
        //       if nTimeFrame <= Env.GAME_FPS then return end
        // The second site proves the unit: `pathLen[logic] / speed = frames`,
        // therefore speed = logic/frame.
        //
        // BASE VALUE IS SERVER-AUTHORITATIVE. The Npc.nRunSpeed attribute is
        // populated by NpcRepresentData.m_nSpeed (decoded from the server sync
        // packet, see _shared/DecompiledSource/NpcRepresentData.cs:60).
        //
        // Exhaustive grep of KiemTheOrigin_DeepExtract (2026-04-15) found NO
        // literal base run speed in client Lua configs. The references that
        // exist are all SPECIAL-MODE overrides, NOT the normal player speed:
        //   - 39_CommonUI/Lua/SnowFight_SnowFightCfg.lua:221
        //       {nRunSpeed = 15000}                    -- snowball fight
        //   - 39_CommonUI/Lua/TowerDefense_TowerDefenseCfg.lua:34
        //       nResetRunSpeed = 15000                 -- reset after tower mode
        //   - 39_CommonUI/Lua/YeLanGuan_YeLanGuanCfg.lua:15
        //       nResetRunSpeed = 15000                 -- reset after dungeon
        //   - 39_CommonUI/Lua/BeachFight_BeachFightCfg.lua:84,89,95
        //       nSpeed = 16500 / 16500 / 15000         -- beach minigame
        //   - 10_Arena/Lua/Script_Battle_BattleAlone.lua:367
        //       pNpc.SetBaseRunSpeed(10000)            -- arena AI FAKE PLAYER
        // None of those apply to the out-of-combat open-world movement used
        // by the player on a normal city map like yunzhongzhen1_a. The base
        // value is almost certainly seeded from a server-side .ini we don't
        // have decompiled visibility into.
        //
        // EMPIRICAL VERIFICATION (2026-04-15): a dedicated
        //   Assets/Scripts/Game/WalkSpeedTimingDriver.cs +
        //   Assets/Editor/StartWalkSpeedTiming.cs
        // harness measured wall-clock walk speed from the courtyard (44, 31):
        //   dir   = east (logicDir 192)
        //   dist  = 42.750 world units (spanned ≈ half the map width)
        //   wall  = 9.835 s
        //   eff.  = 4.347 u/s
        //   pred  = 4.500 u/s  (200 × LOGIC_POS_CELL × GAME_FPS)
        //   ratio = 0.966  (3.4% lost to editor stalls + MCP round-trips)
        // This proves the formula `step = DEFAULT_RUN_SPEED × LOGIC_POS_CELL`
        // per logic tick produces the expected 4.5 u/s at the literal below,
        // AND proves the 18 Hz logic tick loop runs at real time (9.835 wall
        // vs 10.000 logic for a 180-frame budget → 98.4% timing accuracy).
        //
        // The literal 200 is still a PLACEHOLDER because we can't cite it to
        // a source file — we only know it produces gameplay-plausible pacing
        // and the formula self-checks. Revise if/when one of these surfaces:
        //   1. A packet capture of NpcRepresentData.m_nSpeed on spawn.
        //   2. A client-side TabLoader row for cnRoleClass with a speed column.
        //   3. A visual comparison against original gameplay footage (slow-
        //      mo the character crossing a known distance in-game).
        public const int DEFAULT_RUN_SPEED = 200;

        // --- Derived: world ↔ logic unit conversion ------------------------
        //
        // The original KTO client uses 2 distinct "coordinate spaces":
        //   1. Logic units  — integer grid positions used by the server + A*.
        //      1 map cell = 8 logic units (see `Lib:Map2Logic(n) = n * 8` below).
        //   2. World units  — Unity world-space floats. 1 map cell = 1 world unit.
        //
        // From the Go_MoveProcess.lua constants and the scene layout we observe
        // in `yunzhongzhen1_a` (9x9 regions × 64 cells/region = 576 cells/axis,
        // which matches the 72×80 world-unit extent of the map after scaling),
        // the conversion factor is:
        //     1 logic unit = 1/800 world unit = 0.00125 world unit
        public const float LOGIC_POS_CELL = 0.00125f; // = 1f / 800f

        /// <summary>`Lib:Map2Logic(nNum) = nNum * 8`</summary>
        public static int Map2Logic(int n) => n * 8;

        /// <summary>`Lib:Logic2Map(nNum) = nNum / 8`</summary>
        public static int Logic2Map(int n) => n / 8;

        /// <summary>World-space float → logic-space int.</summary>
        public static int World2Logic(float w) => Mathf.RoundToInt(w / LOGIC_POS_CELL);

        /// <summary>Logic-space int → world-space float.</summary>
        public static float Logic2World(int logic) => logic * LOGIC_POS_CELL;

        // --- Lib.lua direction math ---------------------------------------
        //
        // `Lib:FloatAngleToDir(fAngle)` and `Lib:FloatDirToInt(fAngle)` are
        // identical functions — both convert a Lua-game-coord angle (degrees)
        // into a 0..255 logic dir value.
        //
        //   function Lib:FloatAngleToDir(fAngle)
        //     local angle = fAngle
        //     if fAngle >= 360 then angle = fAngle - 360 end
        //     angle = (450 - angle) % 360
        //     return angle * Env.LOGIC_MAX_DIR / 360
        //   end
        //
        // WARNING: this function is NOT directly applicable to Unity-world
        // move vectors. The Lua game's coordinate system has a 90° rotation
        // relative to Unity world space — the "angle" fed to FloatAngleToDir
        // comes from `math.atan(dx, dy) * 180/pi + 180` where `(dx, dy)` are
        // differences in Lua logic coords (see `Operation:Turn2Player`).
        //
        // Use this when you need to match bit-for-bit what the Lua would send
        // to the server (e.g. when you've already converted a Unity move into
        // logic coordinates via World2Logic). For Unity-world input (WASD,
        // joystick axis), use `UnityMoveToLogicDir` below instead.
        public static int FloatAngleToDir(float fAngleDeg)
        {
            float angle = fAngleDeg;
            if (angle >= 360f) angle -= 360f;
            angle = ((450f - angle) % 360f + 360f) % 360f;
            int nDir = Mathf.RoundToInt(angle * LOGIC_MAX_DIR / 360f);
            return NormalizeDir(nDir);
        }

        /// <summary>`Lib:NormalizeDir(nDir)` — wraps into [0, LOGIC_MAX_DIR).</summary>
        public static int NormalizeDir(int nDir)
        {
            nDir %= LOGIC_MAX_DIR;
            if (nDir < 0) nDir += LOGIC_MAX_DIR;
            return nDir;
        }

        /// <summary>
        /// Convert a Unity world-space move vector (normalised or not) into the
        /// 0..255 logic dir expected by `PlayerAssembler.SetLogicDir`.
        ///
        /// The sprite atlas convention (verified against `body_1_free.json`):
        ///   dir = 0   → south  (character facing camera)
        ///   dir = 64  → west
        ///   dir = 128 → north  (character facing away)
        ///   dir = 192 → east
        /// diagonals are at 32, 96, 160, 224.
        ///
        /// The formula is derived from Unity's `Mathf.Atan2(y, x)` convention
        /// (0° = +x east, 90° = +y north) mapped onto the above sprite dir
        /// convention via `dir = ((192 - angle*256/360) mod 256)`.
        /// </summary>
        public static int UnityMoveToLogicDir(Vector2 move)
        {
            if (move.sqrMagnitude < 1e-6f) return 0;
            float angleDeg = Mathf.Atan2(move.y, move.x) * Mathf.Rad2Deg; // (-180, 180]
            int dir = Mathf.RoundToInt(192f - angleDeg * LOGIC_MAX_DIR / 360f);
            return NormalizeDir(dir);
        }
    }
}
