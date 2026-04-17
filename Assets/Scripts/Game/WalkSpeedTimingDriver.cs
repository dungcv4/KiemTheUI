using UnityEngine;

namespace KTO.Game
{
    /// <summary>
    /// Wall-clock walk-speed verification driver for Phase 7.1.
    ///
    /// Attaches at runtime to a PlayerAssembler. Fires ONE fire-and-forget
    /// <see cref="PlayerMotor.GoDirection"/> call in <c>Start()</c> for a
    /// large frame budget, then samples <c>Time.realtimeSinceStartup</c> on
    /// each Unity Update to compute the true wall-clock traversal speed.
    ///
    /// This is intentionally separate from <see cref="CollisionSmokeTestDriver"/>:
    /// the smoke driver cares about per-tick deltas and blocks/slides, while
    /// this one cares about total world-distance per wall-clock second.
    ///
    /// Expected nominal speed (from
    /// <c>39_CommonUI/Lua/Player_AutoRunSpeed.lua:77</c>:
    ///     nTimeFrame = nPathLen / pNpc.nRunSpeed
    /// combined with <c>LOGIC_POS_CELL</c> and <c>Env.GAME_FPS</c>):
    ///
    ///     expected_u_per_sec = NRunSpeed * LOGIC_POS_CELL * GAME_FPS
    ///                        = 200 * 0.00125 * 18
    ///                        = 4.5 world units / sec
    ///
    /// The test logs the effective rate so we can compare against the
    /// placeholder <see cref="Env.DEFAULT_RUN_SPEED"/> and decide whether
    /// to revise the literal (still an open question from Phase 7.0 —
    /// server-authoritative, not citable from decompiled Lua/C#).
    /// </summary>
    public class WalkSpeedTimingDriver : MonoBehaviour
    {
        /// <summary>World-space direction vector (non-zero).</summary>
        public Vector2 Direction = Vector2.right;   // east, default

        /// <summary>LOGIC ticks to run (not Unity frames).
        /// 180 = 10 seconds at 18 Hz — matches the default
        /// <c>me.GoDirection(nDir, Env.GAME_FPS * 10)</c> budget from
        /// <c>Script_Common_Operation.lua:119</c>.</summary>
        public int Frames = 180;

        /// <summary>Hard stop on wall-clock duration so a stuck motor can't
        /// hang the test forever.</summary>
        public float MaxWallSeconds = 12f;

        public string Label = "timing";

        PlayerMotor _motor;
        PlayerInputController _input;
        bool _inputWasEnabled;

        Vector2 _startPos;
        Vector2 _lastPos;
        float _startRealtime;
        float _distanceTraveled;
        int   _sampleCount;
        bool  _done;
        int   _logicDir;

        void Awake()
        {
            _motor = GetComponent<PlayerMotor>();
            // Silence WASD input so the driver owns direction state.
            _input = GetComponent<PlayerInputController>();
            if (_input != null)
            {
                _inputWasEnabled = _input.enabled;
                _input.enabled = false;
                _input.ClearLastDir();
            }
        }

        void OnDestroy()
        {
            if (_input != null)
            {
                _input.enabled = _inputWasEnabled;
                _input.ClearLastDir();
            }
        }

        void Start()
        {
            _startPos       = transform.position;
            _lastPos        = _startPos;
            _startRealtime  = Time.realtimeSinceStartup;
            _logicDir       = Env.UnityMoveToLogicDir(Direction);

            Debug.Log($"[WalkSpeedTiming][{Label}] START  pos={_startPos}  " +
                      $"dir={Direction} → logicDir={_logicDir}  " +
                      $"frames={Frames}  maxWall={MaxWallSeconds}s  " +
                      $"expected={Env.DEFAULT_RUN_SPEED * Env.LOGIC_POS_CELL * Env.GAME_FPS:F3} u/s");

            // ONE fire-and-forget call — matches
            //   me.GoDirection(nDir, Env.GAME_FPS * 10)
            //   me.StartDirection(nDir)
            // Script_Common_Operation.lua:119-120.
            _motor.GoDirection(_logicDir, Frames);
            _motor.StartDirection(_logicDir);
        }

        void Update()
        {
            if (_done) return;
            if (_motor == null) { _done = true; return; }

            Vector2 cur = transform.position;
            _distanceTraveled += (cur - _lastPos).magnitude;
            _lastPos = cur;
            _sampleCount++;

            float wallElapsed = Time.realtimeSinceStartup - _startRealtime;

            bool budgetDrained = (_motor.RemainingFrames == 0);
            bool wallTimeout   = (wallElapsed >= MaxWallSeconds);

            if (budgetDrained || wallTimeout)
            {
                Vector2 delta = cur - _startPos;
                float straightDist = delta.magnitude;
                float effectiveUPS = (wallElapsed > 1e-4f)
                    ? _distanceTraveled / wallElapsed
                    : 0f;
                float expectedUPS  = Env.DEFAULT_RUN_SPEED * Env.LOGIC_POS_CELL * Env.GAME_FPS;
                float ratio        = (expectedUPS > 1e-4f) ? effectiveUPS / expectedUPS : 0f;
                string reason      = budgetDrained ? "BUDGET_DRAINED" : "WALL_TIMEOUT";

                Debug.Log($"[WalkSpeedTiming][{Label}] DONE ({reason})  " +
                          $"start={_startPos}  end={cur}  " +
                          $"straightDelta=({delta.x:F3},{delta.y:F3})={straightDist:F3}  " +
                          $"pathDist={_distanceTraveled:F3}  " +
                          $"wallSec={wallElapsed:F3}  " +
                          $"samples={_sampleCount}  " +
                          $"effective={effectiveUPS:F3} u/s  " +
                          $"expected={expectedUPS:F3} u/s  " +
                          $"ratio={ratio:F3}");

                _done = true;
                Destroy(this);
            }
        }
    }
}
