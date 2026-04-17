// ============================================================
// Source  : KiemTheOrigin_DeepExtract/39_CommonUI/Lua/Script_Common_AutoPath.lua
//           (module `AutoPath`; ~700 lines in the original)
// Decomp  : KTO_DecompiledReference/_root/ (where applicable — the Lua module
//           doesn't have a native C# counterpart in DecompiledSource, it's
//           pure Lua that lives on the XLua side and calls into
//           `Client.NavigationModule` + `me.GotoPosition`.)
//
// Scope of this C# port (intentional trim):
//   ✅ WalkFail / WalkEnd / WalkFinish             — lua:46-80
//   ✅ IsPathing / StopGoto                          — lua:109,124
//   ✅ GotoAndCallEx                                 — lua:187-247
//   ✅ GotoAndCall → _GotoPosition                   — lua:139,329-365
//   ✅ _ChooseTargetPos                              — lua:304-327
//
// Omitted subsystems (server/Lua-only, documented branches present but
// NOT reachable because the subsystems don't exist in this port):
//   ❌ TongChallenge near-boss randomization         — lua:223-228
//   ❌ Cross-map switching + TeamMgr:CanSwitchMap    — lua:231-246
//   ❌ DelayGotoAndCallEx timer for !CanDoAutoPath   — lua:159-185
//   ❌ PlayerEvent:StopAutoPath                      — lua:66,79
//   ❌ Map:SendSwitchMapRequest                      — lua:243
//
// These branches are COMMENTED OUT in-place, not erased, so future port
// phases can re-enable them by removing the guard.
//
// DEVIATION — THE ACTUAL WALK IS ON PlayerMotor, NOT me.GotoPosition
//
// Lua path (original):
//   AutoPath:_GotoPosition → me.GotoPosition(nX,nY,near,true)
//                          → native Npc::GotoPosition (IL2CPP)
//                          → NavigationModule_AStar.FindPath + internal
//                            walk-loop that drives the character.
//
// Our path (port):
//   AutoPath:_GotoPosition → PlayerMotor.GotoPosition(nX,nY,near,onDone)
//                          → NavigationModule_AStar.FindPath (same inputs)
//                          → PlayerMotor.AutoPathWalker coroutine that
//                            iterates waypoints, calling the existing
//                            GoDirection / StopDirection primitives.
//
// The deviation is ONLY in "who owns the walk loop", not the A* inputs or
// the callback semantics. All of WalkEnd/WalkFail/WalkFinish still fire
// exactly where the Lua does.
// ============================================================
using UnityEngine;

namespace KTO.Game
{
    // Lua constant (trace): lua:3
    //   AutoPath.nMinDisSquare = Npc.MIN_DISTANCE * Npc.MIN_DISTANCE * 2
    // i.e. a second "we're close enough" cutoff used only inside _GotoPosition.
    //
    // Lua constants (trace): Npc_NpcDefine.lua:100,102
    //   Npc.MIN_DISTANCE    = 256  -- logic units
    //   Npc.DIALOG_DISTANCE = 614  -- logic units
    public static class AutoPath
    {
        public const int MIN_DISTANCE    = 256;
        public const int DIALOG_DISTANCE = 614;
        public static readonly int MinDisSquare = MIN_DISTANCE * MIN_DISTANCE * 2;

        // --- lua: AutoPath.PathReason (lua:4-12) -------------------------
        public enum PathReasonKind
        {
            emNone                          = 1,
            emAFK_AutoFightChaseTarget      = 2,
            emAFK_AutoFightGoToFightPos     = 3,
            emMiniMap_GoToTargetPos         = 4,
            emAFK_AutoFollowFightFollowLeader = 5,
            emAFK_AutoFightPatrol           = 7,
            emFuben_GoToTargetPos           = 8,
        }
        public static PathReasonKind nPathReason     = PathReasonKind.emNone;
        public static PathReasonKind nLastPathReason = PathReasonKind.emNone;

        // --- lua: AutoPath.tbTargetPos (lua:1,206-218) --------------------
        //
        // In Lua this is a plain table; here it's a plain class. Field names
        // mirror the Lua field names so the port reads 1:1.
        public class TargetPos
        {
            public int    nMapId;
            public int    nX;              // logic
            public int    nY;              // logic
            public System.Action fnSucceed;
            public int    nNearLength;     // logic
            public int    nTaskId;
            public int    nNpcTemplateId;
            public int    nTransX;
            public int    nTransY;
            public System.Action fnFail;
            public System.Action fnFinish;
            public PathReasonKind nPathReason;
        }

        public static TargetPos tbTargetPos;
        public static bool      bProcessAutoPath;

        // ------------------------------------------------------------------
        // Public API
        // ------------------------------------------------------------------

        public static PathReasonKind GetPathReason()     => nPathReason;
        public static PathReasonKind GetLastPathReason() => nLastPathReason;
        public static void           SetLastPathReason(PathReasonKind reason) { nLastPathReason = reason; }

        // --- lua: AutoPath:IsPathing (lua:109) ----------------------------
        public static bool IsPathing() => bProcessAutoPath;

        // --- lua: AutoPath:InitGoAndDoSomethingDataAndfnAfterWalk (lua:26) -
        //
        // Resets per-walk state + calls WalkFinish (which fires the fnFinish
        // callback). Called from every terminal path (WalkFail, WalkEnd).
        public static void InitGoAndDoSomethingDataAndfnAfterWalk()
        {
            // Operation:SetPositionEffect(false) — the position-click circle
            // effect. Not yet ported (Phase 8.3). Commented stub.
            // Operation.SetPositionEffect(false);

            bProcessAutoPath     = false;
            nPathReason          = PathReasonKind.emNone;
            Operation.bIsClickMap = false;  // lua:30 (field added below)
            WalkFinish();
        }

        // --- lua: AutoPath:WalkFinish (lua:46-55) -------------------------
        public static void WalkFinish()
        {
            // Client.NavigationModule.ClearPathLine() — path-line visual.
            // Not yet ported; visual effect, safe to skip.
            if (tbTargetPos != null && tbTargetPos.fnFinish != null)
            {
                var cb = tbTargetPos.fnFinish;
                tbTargetPos.fnFinish = null;
                cb();
            }
            // Client.RepresentModule.StopShowClickMapEffect() — visual.
        }

        // --- lua: AutoPath:WalkFail (lua:57-68) ---------------------------
        public static void WalkFail()
        {
            if (tbTargetPos != null && tbTargetPos.fnFail != null)
            {
                var cb = tbTargetPos.fnFail;
                tbTargetPos.fnFail = null;
                cb();
            }
            // PlayerEvent:StopAutoPath() — server hook, skip.
            InitGoAndDoSomethingDataAndfnAfterWalk();
        }

        // --- lua: AutoPath:WalkEnd (lua:70-81) ----------------------------
        public static void WalkEnd()
        {
            if (tbTargetPos != null && tbTargetPos.fnSucceed != null)
            {
                var cb = tbTargetPos.fnSucceed;
                tbTargetPos.fnSucceed = null;
                cb();
            }
            // PlayerEvent:StopAutoPath() — server hook, skip.
            InitGoAndDoSomethingDataAndfnAfterWalk();
        }

        // --- lua: AutoPath:StopGoto (lua:124-137) -------------------------
        //
        // Called when another input (joystick, keyboard) interrupts the
        // walker. Cancels the motor's queued frames and resets state.
        public static void StopGoto()
        {
            PlayerMotor.StopAutoPathWalker();
            InitGoAndDoSomethingDataAndfnAfterWalk();
        }

        // --- lua: AutoPath:GotoAndCall (lua:139-145) ----------------------
        public static bool GotoAndCall()
        {
            if (tbTargetPos == null) { WalkFail(); return false; }
            return _GotoPosition();
        }

        // --- lua: AutoPath:GotoAndCallEx (lua:187-247) --------------------
        //
        // Ported verbatim minus the four omitted subsystems listed at the
        // top of this file. Each omission has a comment marker so it's
        // trivial to see what's missing.
        //
        // Parameters mirror the Lua signature (12 positional args). C#
        // callers can pass default values for the optional tail params.
        public static bool GotoAndCallEx(
            int nMapId, int nX, int nY,
            System.Action fnSucceed,
            int nNearLength        = 0,
            int nTaskId            = 0,
            int nNpcTemplateId     = 0,
            int nTransX            = 0,
            int nTransY            = 0,
            System.Action fnFail   = null,
            System.Action fnFinish = null,
            PathReasonKind pathReason = PathReasonKind.emNone)
        {
            nPathReason = pathReason;
            SetLastPathReason(nPathReason);

            // lua:190-193 — dedupe by task id
            if (tbTargetPos != null && tbTargetPos.nTaskId != 0 && nTaskId == tbTargetPos.nTaskId)
            {
                WalkFail();
                return false;
            }

            if (nNearLength <= 0) nNearLength = DIALOG_DISTANCE; // lua:196

            // lua:197-201 — CanDoAutoPath + DelayGotoAndCallEx
            //   Skipped: !CanDoAutoPath branch requires Timer:Register which
            //   we don't have. For click-to-move on a loaded map this never
            //   fires anyway — the player is always in a state where paths
            //   are legal.

            // lua:202-205 — cancel pending delay timer (skip, no timer)

            tbTargetPos = new TargetPos
            {
                nMapId         = nMapId,
                nX             = nX,
                nY             = nY,
                fnSucceed      = fnSucceed,
                nNearLength    = nNearLength,
                nTaskId        = nTaskId,
                nNpcTemplateId = nNpcTemplateId,
                nTransX        = nTransX,
                nTransY        = nTransY,
                fnFail         = fnFail,
                fnFinish       = fnFinish,
                nPathReason    = nPathReason,
            };

            // ClearSwitchMapCache (lua:219) — no cross-map switching.

            // lua:220-230 — same-map shortcut. Our port IS always same-map
            // so we unconditionally take this branch.
            //
            // OMITTED: TongChallenge:IsInTongChallengePlaying random-jitter
            // (lua:223-228) — gated on an AFK subsystem we don't have.
            bProcessAutoPath = true;
            return GotoAndCall();

            // OMITTED — cross-map path (lua:231-246):
            //   bCanSwitchMap = TeamMgr:CanSwitchMap(nMapId)
            //   if !bCanSwitchMap → WalkFail
            //   SetSwitchMapCache(...)
            //   if nTransX/nTransY → GotoAndCall()
            //   else StopGoto() + Map:SendSwitchMapRequest(...)
        }

        // --- lua: AutoPath:_ChooseTargetPos (lua:304-327) -----------------
        //
        // In the Lua this handles NPC-dialog coords (Map:GetMapNpcDlgPos) +
        // cross-map transition coords. Neither subsystem exists in this
        // port, so _ChooseTargetPos always returns the raw tbTargetPos.
        static TargetPos _ChooseTargetPos()
        {
            // OMITTED — lua:308-325:
            //   nNpcTemplateId → Map:GetMapNpcDlgPos override
            //   nTransX/Y + different map → use transition coords
            return tbTargetPos;
        }

        // --- lua: AutoPath:_GotoPosition (lua:329-365) --------------------
        //
        // Checks distance (two different thresholds — see lua:337 and :341),
        // then asks the NavigationModule for a nav-mesh snap, then kicks
        // off the walker by calling me.GotoPosition (→ our PlayerMotor).
        static bool _GotoPosition()
        {
            var tb = _ChooseTargetPos();
            if (tb == null) { WalkFail(); return false; }

            var motor = PlayerMotor.Instance;
            if (motor == null) { WalkFail(); return false; }

            // lua:335  local _, nMeX, nMeY = me.GetWorldPos()
            //   Despite the name, `me.GetWorldPos()` returns LOGIC coords in
            //   the original client (Lua/server speak). Our equivalent is
            //   transform.position → Env.World2Logic.
            Vector2 mePos = motor.transform.position;
            int nMeX = Env.World2Logic(mePos.x);
            int nMeY = Env.World2Logic(mePos.y);

            // lua:336  nDisSquareTotal = (nMeX-tX)^2 + (nMeY-tY)^2
            long dxTot = (long)nMeX - tb.nX;
            long dyTot = (long)nMeY - tb.nY;
            long nDisSquareTotal = dxTot * dxTot + dyTot * dyTot;

            // lua:337-339 — already inside the near-length radius
            if (nDisSquareTotal <= (long)tb.nNearLength * tb.nNearLength)
            {
                WalkEnd();
                return true;
            }

            // lua:341-344 — already inside the 2×MIN_DISTANCE² fallback cutoff
            if (nDisSquareTotal <= MinDisSquare)
            {
                WalkEnd();
                return true;
            }

            // lua:345-349 — the Lua code repeats the check (same variable,
            // same threshold). Possibly a post-Map:GetMapNpcDlgPos recheck
            // but dead with our _ChooseTargetPos simplification. Kept as a
            // literal 1:1 port comment; no-op here.

            // lua:350-353 — nNearLength == -1 special case (dialog follow).
            //   Not used by click-to-move so kept as a sentinel check.
            if (tb.nNearLength == -1 &&
                nDisSquareTotal < (long)DIALOG_DISTANCE * DIALOG_DISTANCE)
            {
                WalkEnd();
                return true;
            }

            // lua:354-358  anFinalPoints = Client.NavigationModule.GetNavMeshPoint(...)
            //   The native GetNavMeshPoint snaps the player position to the
            //   nearest walkable cell. Our MapObstacleGrid + PlayerMotor
            //   already does spawn-snap on load, and the motor's IsWalkable
            //   footprint check keeps subsequent positions valid. Skipping
            //   the explicit snap is safe.

            // lua:359-363 — me.GotoPosition(tX, tY, near, true)
            //
            // Returns false synchronously if the path can't be started
            // (e.g. start or target is out of grid, or A* returns null).
            // PlayerMotor.GotoPosition will call WalkEnd via its onDone
            // callback; WalkFail via its onFail callback.
            bool bRet = motor.GotoPosition(tb.nX, tb.nY, tb.nNearLength,
                                           onArrive: WalkEnd,
                                           onFail:   WalkFail);
            if (!bRet)
            {
                WalkFail();
                return false;
            }
            return true;
        }
    }
}
