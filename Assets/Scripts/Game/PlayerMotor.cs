using System.Collections;
using UnityEngine;

namespace KTO.Game
{
    /// <summary>
    /// Player movement controller — matches the original client's flow
    /// from <c>39_CommonUI/Lua/Script_Common_Operation.lua</c> verbatim.
    ///
    /// ORIGINAL FLOW (trace):
    ///   1. Input source (joystick OR WASD hotkey) → a logic dir 0..255 via
    ///      <c>CS.Joystick.GetJoyStickDirByAxis(Ui.Vector2(nV, nH))</c>
    ///      (Script_Common_Operation.lua line 1038).
    ///   2. Input source calls <c>Operation:GoDirection(nDir)</c> (line 71),
    ///      which (after guards) fires:
    ///           me.GoDirection(nDir, Env.GAME_FPS * 10)   -- 180 frames = 10s
    ///           me.StartDirection(nDir)
    ///      (lines 119-120).
    ///   3. On release, <c>Operation:StopGoDir()</c> (line 127) fires:
    ///           me.GoDirection(self.nLastGoDir, 2)         -- 2-frame settle
    ///           me.StopDirection()
    ///      (lines 146-148).
    ///   4. The engine ticks at <c>Env.GAME_FPS = 18</c>. Each tick, while
    ///      <c>_remainingFrames > 0</c>, the character advances by
    ///      <c>pNpc.nRunSpeed</c> LOGIC UNITS (proven by
    ///      <c>Player_AutoRunSpeed.lua:77 nTimeFrame = nPathLen / pNpc.nRunSpeed</c>).
    ///   5. Wall check uses <c>NavigationModule.IsLogicPointObstacle(int, int)</c>
    ///      (03_HUD_Main/CSharp/NavigationModule.cs:153). See
    ///      <see cref="MapObstacleGrid.IsLogicPointObstacle"/>.
    ///
    /// This motor exposes <see cref="GoDirection"/> / <see cref="StartDirection"/>
    /// / <see cref="StopDirection"/> so that both the keyboard input controller
    /// (Phase 7) and later joystick HUD + click-to-move (Phase 8) drive the
    /// character through the same API, exactly as the original Lua code does.
    /// </summary>
    [RequireComponent(typeof(PlayerAssembler))]
    public class PlayerMotor : MonoBehaviour
    {
        // -----------------------------------------------------------------
        // Tunables (server-authoritative in the real client; placeholder here)
        // -----------------------------------------------------------------

        /// <summary>
        /// Logic units per <see cref="Env.GAME_FPS"/> tick. Placeholder —
        /// see <see cref="Env.DEFAULT_RUN_SPEED"/> for the full chain of
        /// source-of-truth evidence. In the real client this is read from
        /// <c>me.GetNpc().nRunSpeed</c>, which is populated from
        /// <c>NpcRepresentData.m_nSpeed</c> sent by the server.
        /// </summary>
        public int NRunSpeed = Env.DEFAULT_RUN_SPEED;

        /// <summary>
        /// Sprint multiplier while LeftShift is held. Not in the original
        /// Lua source — the real game uses server-driven skill state buffs
        /// (e.g. AutoRunSpeed buff 1008). This is a desktop QoL, gated.
        /// </summary>
        public float RunMultiplier = 1.5f;
        public bool  AllowRun      = true;

        /// <summary>
        /// When true, AutoPathWalker emits per-waypoint / per-iteration
        /// Debug.Logs and TickOneFrame emits [TickStuck] diagnostics while
        /// the walker is active. ~76 log lines per click-to-move path, so
        /// off in normal play; flip on via a test menu or inspector for
        /// regression investigation. Does NOT gate the stall-bail warning
        /// (that always fires — you always want to know if pathing died).
        /// </summary>
        public static bool DebugLogWalker = false;

        // -----------------------------------------------------------------
        // Runtime state (matches original's internal _LastSpeed / _LogicDir
        // fields on Npc: Npc.cs lines 208, 212)
        // -----------------------------------------------------------------

        PlayerAssembler _player;
        int   _curLogicDir;        // 0..255; direction while _remainingFrames > 0
        int   _remainingFrames;    // 0 = stopped; decrements once per logic tick
        float _tickAccumulator;    // accumulates Time.deltaTime, fires tick at 1/GAME_FPS
        float _runMultiplier = 1f; // cached per-GoDirection for shift-run

        public int RemainingFrames => _remainingFrames;
        public int CurLogicDir     => _curLogicDir;

        // ---- singleton (same self-heal pattern as MapObstacleGrid) ------
        //
        // Needed so AutoPath._GotoPosition can find the motor without every
        // input source having a manual reference. Survives domain reload
        // the same way MapObstacleGrid.Instance does (Find on first access).
        static PlayerMotor _instance;
        public static PlayerMotor Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = UnityEngine.Object.FindObjectOfType<PlayerMotor>(includeInactive: true);
                }
                return _instance;
            }
        }

        void Awake()
        {
            _player = GetComponent<PlayerAssembler>();
            _instance = this;
            // Register with Operation singleton so both keyboard
            // (PlayerInputController) and joystick (UIJoyStick.OnMove) dispatch
            // through the same Operation.GoDirection / StopGoDir path.
            Operation.RegisterMotor(this);
        }

        void OnDestroy()
        {
            Operation.UnregisterMotor(this);
            if (_instance == this) _instance = null;
        }

        void Start()
        {
            // If the spawn lands on a blocked cell (happens on yunzhongzhen1_a
            // because the player spawn (43.36, 25.76) is the map center, which
            // sits on a 1-cell-wide palace wall), warp to the nearest walkable
            // cell. This matches the original client's behavior on map-load:
            // NPCs are always snapped to a walkable cell before being shown.
            var grid = MapObstacleGrid.Instance;
            if (grid == null || !grid.Loaded) return;
            Vector2 feet = transform.position;
            if (IsWalkable(grid, feet)) return;

            if (SnapToNearestWalkable(grid, feet, out Vector2 snap))
            {
                Debug.Log($"[PlayerMotor] spawn {feet} was blocked, snapped to {snap} " +
                          $"(dCell <= 16)");
                transform.position = new Vector3(snap.x, snap.y, transform.position.z);
            }
            else
            {
                Debug.LogWarning($"[PlayerMotor] spawn {feet} blocked and no walkable " +
                                 $"cell within radius 16 — leaving in place");
            }
        }

        // -----------------------------------------------------------------
        // Public API (trace → Script_Common_Operation.lua)
        // -----------------------------------------------------------------

        /// <summary>
        /// Matches <c>me.GoDirection(nDir, nFrames)</c> from
        /// <c>Script_Common_Operation.lua:119,146</c>.
        ///
        /// Queues movement in <paramref name="nLogicDir"/> for the next
        /// <paramref name="nFrames"/> logic ticks. Fire-and-forget — the
        /// motor advances the character on its own; the input controller
        /// should call this again only when the direction changes or when
        /// the budget runs out (matches the original's early-out in
        /// <c>Operation:GoDirection</c> line 80-82).
        ///
        /// Also captures the current shift-run state so LeftShift-tap during
        /// a sustained move is honored. This is NOT in the original (see
        /// <see cref="RunMultiplier"/> note).
        /// </summary>
        public void GoDirection(int nLogicDir, int nFrames)
        {
            _curLogicDir = Env.NormalizeDir(nLogicDir);
            _remainingFrames = Mathf.Max(_remainingFrames, nFrames);

            // Cache sprint multiplier for this run. In the original, sprint
            // is a server-side buff — here we read LeftShift for desktop QoL.
            bool shift = AllowRun && (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift));
            _runMultiplier = shift ? RunMultiplier : 1f;
        }

        /// <summary>
        /// Matches <c>me.StartDirection(nDir)</c> from
        /// <c>Script_Common_Operation.lua:120</c>. Sets the facing +
        /// run animation.
        /// </summary>
        public void StartDirection(int nLogicDir)
        {
            _curLogicDir = Env.NormalizeDir(nLogicDir);
            _player.SetLogicDir(_curLogicDir);
            _player.SetAction(NpcAction.FightRun);
        }

        /// <summary>
        /// Matches <c>me.StopDirection()</c> from
        /// <c>Script_Common_Operation.lua:148</c>. In the original, this
        /// only clears the "key held" flag — any <c>_remainingFrames</c>
        /// already queued by a prior <c>GoDirection(lastDir, 2)</c> still
        /// tick out. Here we mirror that: we DO NOT zero the budget.
        /// </summary>
        public void StopDirection()
        {
            // Intentionally no _remainingFrames reset. The 2-frame settle
            // queued by Operation:StopGoDir (line 146) should still play.
            // The animation will flip to Stand once _remainingFrames hits 0
            // in the next Update tick.
        }

        // -----------------------------------------------------------------
        // Auto-path (click-to-move) — see AutoPath.cs for the flow overview
        // -----------------------------------------------------------------

        // Coroutine handle so Stop/restart cancel the walker cleanly.
        Coroutine _autoPathCo;
        static PlayerMotor _walkerOwner; // instance that owns the current walker

        // Diagnostic: set by the walker while it's running so TickOneFrame
        // can log when it fails to advance (auto-path-specific stall).
        // Different from general WASD/joystick stalls which are expected
        // when the user holds into a wall.
        bool _walkerActive;

        /// <summary>
        /// DEVIATION — not a direct port of a Lua/IL2CPP method.
        ///
        /// The original client's flow terminates in <c>me.GotoPosition(nX,
        /// nY, nNearLen, true)</c>, which is a native Npc method (IL2CPP)
        /// that owns its own walk loop. We don't have that native loop, so
        /// we reproduce the exact same observable behavior via a coroutine
        /// on <see cref="PlayerMotor"/>:
        ///
        ///   1. Call <see cref="NavigationModule_AStar.FindPath"/> with the
        ///      current player logic pos as start and (nTargetLogicX,
        ///      nTargetLogicY) as end — identical A* inputs to the Lua flow
        ///      (<c>AutoPath:_GotoPosition</c> → <c>me.GotoPosition</c>).
        ///   2. Iterate the returned waypoint array. For each step: compute
        ///      the logic dir from (next - cur), call the existing
        ///      <see cref="GoDirection"/> + <see cref="StartDirection"/>
        ///      primitives (same pair Operation:GoDirection uses), then
        ///      wait until the player is within half a cell of the target.
        ///   3. Stop when the final waypoint is reached OR when interrupted
        ///      (the user touches joystick / keyboard). Fire the onArrive
        ///      or onFail callback.
        ///
        /// Approved by user via "phương án nào đúng 100% thì làm mở rộng đi"
        /// (2026-04-15) — reuse the PlayerMotor walk primitives so every
        /// input source drives the same motor with the same semantics.
        ///
        /// Return value: <c>false</c> if A* fails synchronously (no path or
        /// start/end out of grid); <c>true</c> if the walk was started.
        /// </summary>
        public bool GotoPosition(int nTargetLogicX, int nTargetLogicY,
                                  int nNearLogic,
                                  System.Action onArrive,
                                  System.Action onFail)
        {
            // Cancel any previous walker.
            StopAutoPathWalkerInternal();

            // Current player logic pos — source of truth matches
            // AutoPath._GotoPosition's `local _, nMeX, nMeY = me.GetWorldPos()`.
            Vector2 mePos = transform.position;
            int nStartX = Env.World2Logic(mePos.x);
            int nStartY = Env.World2Logic(mePos.y);

            // Call A* — same inputs the native flow would use.
            Vector3[] waypoints = NavigationModule_AStar.FindPath(
                nStartX, nStartY, nTargetLogicX, nTargetLogicY);

            if (waypoints == null || waypoints.Length == 0)
            {
                Debug.LogWarning(
                    $"[PlayerMotor] GotoPosition: A* returned no path " +
                    $"from ({nStartX},{nStartY}) to ({nTargetLogicX},{nTargetLogicY})");
                return false;
            }

            // Kick off the walker coroutine.
            _autoPathCo = StartCoroutine(AutoPathWalker(
                waypoints, nTargetLogicX, nTargetLogicY, nNearLogic,
                onArrive, onFail));
            _walkerOwner = this;
            return true;
        }

        /// <summary>
        /// Static helper called by AutoPath.StopGoto — cancels the current
        /// walker on whichever PlayerMotor owns it. Resolves the common
        /// case "input stopped the path but the caller doesn't have a
        /// motor reference handy".
        /// </summary>
        public static void StopAutoPathWalker()
        {
            if (_walkerOwner != null) _walkerOwner.StopAutoPathWalkerInternal();
        }

        void StopAutoPathWalkerInternal()
        {
            if (_autoPathCo != null)
            {
                StopCoroutine(_autoPathCo);
                _autoPathCo = null;
            }
            _walkerActive = false;
            // Clear any queued frames so the character settles.
            _remainingFrames = 0;
        }

        /// <summary>
        /// The walker coroutine itself. See <see cref="GotoPosition"/> for
        /// the flow overview. Not a direct port — see the DEVIATION block
        /// on <see cref="GotoPosition"/>.
        /// </summary>
        IEnumerator AutoPathWalker(Vector3[] waypoints,
                                    int nTargetLogicX, int nTargetLogicY,
                                    int nNearLogic,
                                    System.Action onArrive,
                                    System.Action onFail)
        {
            _walkerActive = true;

            // Pre-compute the arrival threshold in world units (for the
            // final target). MIN_DISTANCE is 256 logic; that's 0.32 world
            // units — about a third of a cell, plenty loose so we don't
            // over-step and stall.
            float nearWorld = nNearLogic * Env.LOGIC_POS_CELL;

            // Per-waypoint advance threshold: stop heading toward waypoint
            // `i` once we're within half the smaller cell dim of it. This
            // mirrors the native's "advance to next cell when you cross
            // the boundary" behavior.
            var grid = MapObstacleGrid.Instance;
            float stepAdvance = (grid != null)
                ? Mathf.Min(grid.CellSize.x, grid.CellSize.y) * 0.5f
                : 0.08f; // conservative fallback

            // Safety bail — time-based, not frame-count. The coroutine runs
            // at Unity frame rate (60+ fps) while the motor ticks at
            // Env.GAME_FPS = 18 Hz, so a frame counter would be tripped by
            // the rate mismatch (most coroutine iterations see an unchanged
            // position simply because no motor tick fired that frame).
            // 1.5 s of real time = ~27 motor ticks at 18 Hz, which is
            // plenty of runway for any single-cell delay while still
            // catching a true collision deadlock quickly.
            const float MAX_STALL_TIME = 1.5f;

            if (DebugLogWalker)
            {
                Debug.Log($"[PlayerMotor] AutoPathWalker start — {waypoints.Length} waypoints, " +
                          $"first={waypoints[0]} last={waypoints[waypoints.Length - 1]}, " +
                          $"stepAdv={stepAdvance:F4}");
            }

            // Iterate the waypoints one at a time.
            for (int i = 0; i < waypoints.Length; i++)
            {
                Vector3 target = waypoints[i];
                Vector2 prevMovePos = transform.position;
                float stallTime = 0f;
                int iterCount = 0;

                // Snapshot the approach direction at the start of this
                // waypoint so we can detect "crossed the waypoint" later.
                // This is critical: worldStep per motor tick (≈0.25) is
                // larger than the per-waypoint cell spacing (≈0.16 on Y),
                // so a pure distance threshold keeps bouncing across the
                // target. A "did we pass it along the initial direction?"
                // check stops that oscillation cleanly.
                Vector2 initialToNext = (Vector2)target - (Vector2)transform.position;
                Vector2 initialDir    = initialToNext.sqrMagnitude > 1e-8f
                                        ? initialToNext.normalized
                                        : Vector2.zero;

                while (true)
                {
                    Vector2 cur    = transform.position;
                    Vector2 toNext = (Vector2)target - cur;
                    float   dist   = toNext.magnitude;

                    // (a) Standard tight-proximity break for the last
                    //     waypoint / when we actually land on target.
                    if (dist <= stepAdvance) break;

                    // (b) Overshoot break: if the current position is past
                    //     the target along the initial approach direction,
                    //     we've crossed the waypoint — advance.
                    //     `dot(toNext, initialDir) <= 0` means toNext flipped
                    //     sign relative to how we started, i.e. the target
                    //     is now behind us.
                    if (initialDir != Vector2.zero &&
                        Vector2.Dot(toNext, initialDir) <= 0f)
                        break;

                    // Convert the move vector into a logic dir and feed it
                    // to the same primitives the joystick uses.
                    int dir = Env.UnityMoveToLogicDir(toNext);
                    GoDirection(dir, 2);     // short budget — re-fired each frame
                    StartDirection(dir);     // animation + facing

                    // Walker diagnostics: log the first 4 iterations per
                    // waypoint so we can see the initial state + whether
                    // the motor is ticking. Keeps the console readable
                    // while still catching "stuck at step 0" bugs.
                    if (DebugLogWalker && iterCount < 4)
                    {
                        Debug.Log($"[WalkerDiag] wp{i}/{waypoints.Length} iter{iterCount} " +
                                  $"cur={cur} tgt={target} dist={dist:F4} dir={dir} " +
                                  $"remFrames={_remainingFrames}");
                    }
                    iterCount++;

                    // Check if we actually advanced since the last motor-
                    // tick move. prevMovePos is only updated when we see
                    // real movement — so stallTime accumulates cleanly
                    // across frames where the motor hasn't ticked yet.
                    if ((cur - prevMovePos).sqrMagnitude < 1e-6f)
                    {
                        stallTime += Time.deltaTime;
                        if (stallTime > MAX_STALL_TIME)
                        {
                            Debug.LogWarning(
                                $"[PlayerMotor] AutoPathWalker stalled at {cur} " +
                                $"wp{i}/{waypoints.Length} target {target} dir={dir} " +
                                $"remFrames={_remainingFrames} stallTime={stallTime:F2}s " +
                                $"iters={iterCount} — bailing out");
                            _walkerActive = false;
                            _autoPathCo = null;
                            _remainingFrames = 0;
                            onFail?.Invoke();
                            yield break;
                        }
                    }
                    else
                    {
                        stallTime = 0f;
                        prevMovePos = cur;
                    }

                    yield return null;
                }

                if (DebugLogWalker)
                    Debug.Log($"[WalkerDiag] wp{i} reached after {iterCount} iters, pos={transform.position}");
            }

            // Reached the last waypoint — stop cleanly and fire callback.
            _remainingFrames = 0;
            _autoPathCo = null;
            _walkerActive = false;

            // Final proximity check: if we're inside the arrival radius,
            // call onArrive; otherwise treat as fail.
            Vector2 finalPos = transform.position;
            float finalDist = Vector2.Distance(
                finalPos,
                new Vector2(Env.Logic2World(nTargetLogicX),
                            Env.Logic2World(nTargetLogicY)));

            if (DebugLogWalker)
            {
                Debug.Log($"[PlayerMotor] AutoPathWalker finished, finalPos={finalPos} " +
                          $"finalDist={finalDist:F4} nearWorld={nearWorld:F4}");
            }

            if (finalDist <= nearWorld + Env.Logic2World(AutoPath.MIN_DISTANCE))
                onArrive?.Invoke();
            else
                onFail?.Invoke();
        }

        // -----------------------------------------------------------------
        // Tick loop (runs at Env.GAME_FPS = 18 Hz)
        // -----------------------------------------------------------------

        void Update()
        {
            _tickAccumulator += Time.deltaTime;
            float tickDt = 1f / Env.GAME_FPS;

            // Drain accumulator. Multiple ticks per Update handle the case
            // where Unity stalls (editor reload, MCP round-trip): catch up
            // so physics stays deterministic-ish instead of teleporting.
            // Clamp to a sane max so a 10s stall doesn't spawn 180 ticks.
            const int MAX_TICKS_PER_UPDATE = 3;
            int ticksThisUpdate = 0;

            while (_tickAccumulator >= tickDt && ticksThisUpdate < MAX_TICKS_PER_UPDATE)
            {
                _tickAccumulator -= tickDt;
                ticksThisUpdate++;

                if (_remainingFrames > 0)
                {
                    TickOneFrame();
                    _remainingFrames--;
                }
            }

            // Bleed off any excess accumulator from stalls so we don't
            // start the next Update with a backlog that'll teleport us.
            if (_tickAccumulator > tickDt * MAX_TICKS_PER_UPDATE)
                _tickAccumulator = 0f;

            // Idle state: force FightStand + zero out sprint so the next
            // GoDirection re-reads LeftShift fresh.
            if (_remainingFrames == 0)
            {
                _player.SetAction(NpcAction.FightStand);
                _runMultiplier = 1f;
            }
        }

        /// <summary>
        /// Advance one logic frame. Step distance in world units =
        ///   nRunSpeed [logic/frame] * LOGIC_POS_CELL [world/logic]
        /// multiplied by the sprint cache. Uses sub-stepping + axis-separated
        /// sliding so that a single tick cannot tunnel through a wall even
        /// with high sprint multipliers.
        /// </summary>
        void TickOneFrame()
        {
            // World-space unit vector from logic dir. Env.UnityMoveToLogicDir
            // uses the formula `dir = (192 - angleDeg*256/360) mod 256`, so
            // the inverse is `angleDeg = (192 - dir) * 360/256`. Verified
            // against the 8 cardinals in CaptureWalkFrames.cs (Phase 4).
            float angleDeg = (192f - _curLogicDir) * 360f / Env.LOGIC_MAX_DIR;
            float angleRad = angleDeg * Mathf.Deg2Rad;
            Vector2 dirVec = new Vector2(Mathf.Cos(angleRad), Mathf.Sin(angleRad));

            float worldStep = NRunSpeed * Env.LOGIC_POS_CELL * _runMultiplier;

            Vector2 feet = transform.position;
            var grid = MapObstacleGrid.Instance;

            // Sub-step so one tick can't jump across a wall at high sprint.
            // Step size cap = half the smaller cell dim (same rule as pre-refactor).
            float maxSub = (grid != null)
                ? Mathf.Min(grid.CellSize.x, grid.CellSize.y) * 0.5f
                : worldStep;
            int substeps = Mathf.Max(1, Mathf.CeilToInt(worldStep / Mathf.Max(maxSub, 1e-4f)));
            Vector2 substepVec = dirVec * (worldStep / substeps);

            bool anyMoved = false;
            for (int i = 0; i < substeps; i++)
            {
                bool stepMoved = false;

                if (grid == null || !grid.Loaded)
                {
                    // Fail-open if the grid isn't available — movement still
                    // works on maps without obstacles, and the player isn't
                    // stuck if there's a bootstrap bug.
                    feet += substepVec;
                    stepMoved = true;
                }
                else
                {
                    Vector2 tryFull = feet + substepVec;
                    if (IsWalkable(grid, tryFull))
                    {
                        feet = tryFull;
                        stepMoved = true;
                    }
                    else
                    {
                        // Axis-separated slide. The original Lua code is
                        // a C# stub (Cpp2IL), but the sliding behavior is
                        // clearly visible in gameplay footage of the
                        // original client. Not a creative deviation.
                        if (Mathf.Abs(substepVec.x) > 1e-6f)
                        {
                            Vector2 tryX = feet + new Vector2(substepVec.x, 0f);
                            if (IsWalkable(grid, tryX))
                            {
                                feet = tryX;
                                stepMoved = true;
                            }
                        }
                        if (!stepMoved && Mathf.Abs(substepVec.y) > 1e-6f)
                        {
                            Vector2 tryY = feet + new Vector2(0f, substepVec.y);
                            if (IsWalkable(grid, tryY))
                            {
                                feet = tryY;
                                stepMoved = true;
                            }
                        }
                    }
                }

                anyMoved |= stepMoved;
                if (!stepMoved) break; // fully blocked — no point continuing
            }

            transform.position = new Vector3(feet.x, feet.y, transform.position.z);

            _player.SetLogicDir(_curLogicDir);
            _player.SetAction(anyMoved ? NpcAction.FightRun : NpcAction.FightStand);

            // Walker-specific stuck diagnostic: when the auto-path walker is
            // active and a motor tick fails to produce ANY movement, break
            // down why. This is the most common failure mode (A* cleared a
            // cell-level path but the footprint check rejects the world-
            // space step because the ±radius samples cross a blocked cell
            // boundary). Log rate-limited so we only see it once per stuck
            // run, not every tick. Gated on DebugLogWalker — the bail
            // warning in the walker coroutine still fires unconditionally.
            if (DebugLogWalker && !anyMoved && _walkerActive
                && grid != null && grid.Loaded
                && _stuckLogCount < 3)
            {
                _stuckLogCount++;
                Vector2 feetNow = feet;
                float r = Mathf.Min(grid.CellSize.x, grid.CellSize.y) * 0.4f;
                int lx = Env.World2Logic(feetNow.x);
                int ly = Env.World2Logic(feetNow.y);
                int rLogic = Mathf.Max(1, Env.World2Logic(r));
                bool c = !grid.IsLogicPointObstacle(lx,          ly);
                bool e = !grid.IsLogicPointObstacle(lx + rLogic, ly);
                bool w = !grid.IsLogicPointObstacle(lx - rLogic, ly);
                bool n = !grid.IsLogicPointObstacle(lx,          ly + rLogic);
                bool s = !grid.IsLogicPointObstacle(lx,          ly - rLogic);

                // Also check the proposed destination cell directly.
                Vector2 dst = feetNow + dirVec * worldStep;
                int dlx = Env.World2Logic(dst.x);
                int dly = Env.World2Logic(dst.y);
                bool dc = !grid.IsLogicPointObstacle(dlx,          dly);
                bool de = !grid.IsLogicPointObstacle(dlx + rLogic, dly);
                bool dw = !grid.IsLogicPointObstacle(dlx - rLogic, dly);
                bool dn = !grid.IsLogicPointObstacle(dlx,          dly + rLogic);
                bool ds = !grid.IsLogicPointObstacle(dlx,          dly - rLogic);

                Debug.Log(
                    $"[TickStuck] at {feetNow} dir={_curLogicDir} dirVec={dirVec} " +
                    $"worldStep={worldStep:F4} substeps={substeps}\n" +
                    $"  cur footprint : c={c} e={e} w={w} n={n} s={s} (rLogic={rLogic})\n" +
                    $"  dst {dst} footprint : c={dc} e={de} w={dw} n={dn} s={ds}");
            }
            if (anyMoved) _stuckLogCount = 0; // reset once we're unstuck
        }

        // Rate-limit counter for [TickStuck] diagnostic logging. Reset
        // whenever the motor successfully advances.
        int _stuckLogCount;

        // -----------------------------------------------------------------
        // Walkable footprint check (uses NavigationModule-style API)
        // -----------------------------------------------------------------

        /// <summary>
        /// Walk check with a tiny footprint, not a single point. Samples 4
        /// corners of a small box (radius ≈ 40% of the smaller cell dim)
        /// around the feet so the character's "volume" doesn't clip walls.
        /// Matches the original client's collision check which uses the
        /// NPC's radius.
        ///
        /// Internally routes through <see cref="MapObstacleGrid.IsLogicPointObstacle"/>
        /// — the same API the original client's <c>NavigationModule</c>
        /// exposes to Lua via XLua.
        /// </summary>
        static bool IsWalkable(MapObstacleGrid grid, Vector2 pos)
        {
            float r = Mathf.Min(grid.CellSize.x, grid.CellSize.y) * 0.4f;

            // Convert world → logic once (plus radius offset).
            int logicX = Env.World2Logic(pos.x);
            int logicY = Env.World2Logic(pos.y);
            int rLogic = Mathf.Max(1, Env.World2Logic(r));

            if (grid.IsLogicPointObstacle(logicX,           logicY))          return false;
            if (grid.IsLogicPointObstacle(logicX + rLogic,  logicY))          return false;
            if (grid.IsLogicPointObstacle(logicX - rLogic,  logicY))          return false;
            if (grid.IsLogicPointObstacle(logicX,           logicY + rLogic)) return false;
            if (grid.IsLogicPointObstacle(logicX,           logicY - rLogic)) return false;
            return true;
        }

        // -----------------------------------------------------------------
        // Spawn snap (unchanged from pre-refactor)
        // -----------------------------------------------------------------

        /// <summary>
        /// Chebyshev-spiral search for the nearest walkable cell around
        /// <paramref name="world"/>, up to radius 16 cells. Returns the
        /// CENTER of the found cell in world coordinates.
        /// </summary>
        static bool SnapToNearestWalkable(MapObstacleGrid grid, Vector2 world, out Vector2 snap)
        {
            snap = world;
            if (!grid.WorldToCell(world, out int cx0, out int cy0))
            {
                // Out of grid entirely — can't help.
                return false;
            }
            const int MaxR = 16;
            for (int r = 0; r <= MaxR; r++)
            {
                for (int dy = -r; dy <= r; dy++)
                {
                    for (int dx = -r; dx <= r; dx++)
                    {
                        if (Mathf.Max(Mathf.Abs(dx), Mathf.Abs(dy)) != r) continue;
                        int cx = cx0 + dx, cy = cy0 + dy;
                        Vector2 w = grid.CellToWorld(cx, cy);
                        if (IsWalkable(grid, w))
                        {
                            snap = w;
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
