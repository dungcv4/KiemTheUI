using UnityEngine;

namespace KTO.Game
{
    /// <summary>
    /// Play-mode smoke test driver for Phase 6.3 sliding collision and
    /// Phase 7 GoDirection refactor.
    ///
    /// Attached at runtime to the player GameObject by
    /// <c>Assets/Editor/StartCollisionSmokeTest.cs</c>. On <c>Start()</c>
    /// it fires a single <c>GoDirection(logicDir, MaxFrames)</c> call
    /// (matching the original <c>me.GoDirection(nDir, Env.GAME_FPS * 10)</c>
    /// pattern from <c>Script_Common_Operation.lua:119</c>) and then
    /// samples the player's feet position each Unity frame. Once the
    /// motor has consumed its frame budget (or an internal watchdog
    /// <see cref="MaxSampleFrames"/> trips first) it dumps a summary and
    /// destroys itself.
    ///
    /// Used to verify (from the editor MCP bridge) that:
    ///   1. Driving into a known-blocked wall stops the player on the axis
    ///      that intersects the wall.
    ///   2. Driving diagonally into a wall lets the player slide along the
    ///      free axis.
    ///   3. Driving into open space moves the expected distance given
    ///      <see cref="PlayerMotor.NRunSpeed"/> (sanity check for Phase 7.1).
    /// </summary>
    public class CollisionSmokeTestDriver : MonoBehaviour
    {
        /// <summary>World-space direction vector (non-zero); converted to a
        /// 0..255 logic dir via <see cref="Env.UnityMoveToLogicDir"/>.</summary>
        public Vector2 Direction = Vector2.left;

        /// <summary>Number of LOGIC ticks to run (not Unity frames). Matches
        /// the <c>nFrames</c> argument of <c>me.GoDirection</c>.</summary>
        public int MaxFrames = 90;

        /// <summary>Upper bound on Unity Update ticks we'll wait for the
        /// logic budget to drain, so a stalled motor can't hang the test
        /// forever. ~MaxFrames * (60/18) + slack.</summary>
        public int MaxSampleFrames => Mathf.CeilToInt(MaxFrames * 60f / Env.GAME_FPS) + 30;

        public string Label = "test";
        public int VerboseFirstNFrames = 0;

        PlayerMotor _motor;
        PlayerInputController _input;
        bool _inputWasEnabled;
        int _sampleFrame;
        Vector2 _startPos;
        Vector2 _lastPos;
        float _distanceTraveled;
        bool _done;
        int _logicDir;

        void Awake()
        {
            _motor = GetComponent<PlayerMotor>();
            // Silence the keyboard input controller for the duration of the
            // test so it doesn't compete with the driver by pushing (0,0).
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
            _startPos = transform.position;
            _lastPos = _startPos;
            _logicDir = Env.UnityMoveToLogicDir(Direction);

            Debug.Log($"[CollisionSmoke][{Label}] start pos={_startPos}  " +
                      $"dir={Direction} → logicDir={_logicDir}  " +
                      $"maxFrames={MaxFrames}  inputDisabled={_input != null}");

            // ONE fire-and-forget call — same shape as
            //   me.GoDirection(nDir, Env.GAME_FPS * 10)
            //   me.StartDirection(nDir)
            // from Script_Common_Operation.lua:119-120.
            _motor.GoDirection(_logicDir, MaxFrames);
            _motor.StartDirection(_logicDir);
        }

        void Update()
        {
            if (_done) return;
            if (_motor == null) { _done = true; return; }

            Vector2 cur = transform.position;

            if (_sampleFrame < VerboseFirstNFrames)
            {
                Vector2 d = cur - _lastPos;
                Debug.Log($"[CollisionSmoke][{Label}] f={_sampleFrame}  pos={cur}  " +
                          $"delta=({d.x:F4},{d.y:F4})  dt={Time.deltaTime:F5}  " +
                          $"remaining={_motor.RemainingFrames}");
            }

            _distanceTraveled += (cur - _lastPos).magnitude;
            _lastPos = cur;
            _sampleFrame++;

            // Done when motor has drained its frame budget (matches the
            // original's Doing.stand transition) OR the watchdog trips.
            bool budgetDrained = (_motor.RemainingFrames == 0);
            bool watchdogTrip  = (_sampleFrame >= MaxSampleFrames);

            if (budgetDrained || watchdogTrip)
            {
                Vector2 delta = cur - _startPos;
                string reason = budgetDrained ? "BUDGET_DRAINED" : "WATCHDOG";
                Debug.Log($"[CollisionSmoke][{Label}] DONE ({reason}) " +
                          $"sampleFrames={_sampleFrame}  " +
                          $"start={_startPos}  end={cur}  " +
                          $"delta=({delta.x:F3},{delta.y:F3})  " +
                          $"dist={_distanceTraveled:F3}");
                _done = true;
                Destroy(this);
            }
        }
    }
}
