// =======================================================================
//  TestMovementSmoke.cs — Smoke test the full movement pipeline.
//
//  Menu: KTO → Test → Movement Smoke Test
//
//  Verifies (during Play Mode):
//    - Env constants are correct
//    - KTO.Game.UIJoyStick.GetJoyStickDirByAxis produces expected dirs for cardinals
//    - Player exists with PlayerMotor + PlayerInputController
//    - ClickToMoveInput is in the scene
//    - UIJoyStick is in the HUD
//    - MapObstacleGrid is loaded
//    - Operation.ClickMap triggers auto-path
// =======================================================================
using UnityEngine;
using UnityEditor;
using KTO.Game;

public static class TestMovementSmoke
{
    [MenuItem("KTO/Test/Movement Smoke Test")]
    public static void Run()
    {
        if (!Application.isPlaying)
        {
            Debug.LogWarning("[MovementSmoke] Enter Play Mode first");
            return;
        }

        int passed = 0, failed = 0;
        void Check(string label, bool ok, string extra = "")
        {
            if (ok) { passed++; Debug.Log($"  ✓ {label} {extra}"); }
            else    { failed++; Debug.LogError($"  ✗ {label} {extra}"); }
        }

        Debug.Log("=== Movement Smoke Test ===");

        // --- Env constants ---
        Check("Env.GAME_FPS = 18", Env.GAME_FPS == 18);
        Check("Env.LOGIC_MAX_DIR = 256", Env.LOGIC_MAX_DIR == 256);
        Check("Env.LOGIC_POS_CELL = 0.00125", Mathf.Abs(Env.LOGIC_POS_CELL - 0.00125f) < 1e-6f);
        Check("Env.DEFAULT_RUN_SPEED = 200", Env.DEFAULT_RUN_SPEED == 200);

        float predicted = Env.DEFAULT_RUN_SPEED * Env.LOGIC_POS_CELL * Env.GAME_FPS;
        Check("predicted walk speed = 4.5 u/s", Mathf.Abs(predicted - 4.5f) < 0.01f,
              $"(got {predicted:F3})");

        // --- direction math (cardinals should match sprite atlas convention) ---
        int dE = KTO.Game.UIJoyStick.GetJoyStickDirByAxis(new Vector2(1, 0));
        int dW = KTO.Game.UIJoyStick.GetJoyStickDirByAxis(new Vector2(-1, 0));
        int dN = KTO.Game.UIJoyStick.GetJoyStickDirByAxis(new Vector2(0, 1));
        int dS = KTO.Game.UIJoyStick.GetJoyStickDirByAxis(new Vector2(0, -1));
        Check("dir east  = 192",  dE == 192, $"(got {dE})");
        Check("dir west  = 64",   dW == 64,  $"(got {dW})");
        Check("dir north = 128",  dN == 128, $"(got {dN})");
        Check("dir south = 0",    dS == 0,   $"(got {dS})");

        // dead-zone
        int dead = KTO.Game.UIJoyStick.GetJoyStickDirByAxis(Vector2.zero);
        Check("dir dead-zone = -2", dead == -2, $"(got {dead})");

        // --- scene wiring ---
        var player = GameObject.Find("Player_ma_000a_free");
        Check("Player exists", player != null);

        if (player != null)
        {
            Check("PlayerMotor on player", player.GetComponent<PlayerMotor>() != null);
            Check("PlayerInputController on player", player.GetComponent<PlayerInputController>() != null);
            Check("PlayerAssembler on player", player.GetComponent<PlayerAssembler>() != null);
        }

        var ctm = GameObject.FindObjectOfType<ClickToMoveInput>();
        Check("ClickToMoveInput in scene", ctm != null);

        var joy = GameObject.FindObjectOfType<KTO.Game.UIJoyStick>();
        Check("UIJoyStick in scene", joy != null);

        var grid = MapObstacleGrid.Instance;
        Check("MapObstacleGrid.Instance", grid != null);
        if (grid != null)
        {
            Check("grid loaded", grid.Loaded, $"(W={grid.W} H={grid.H})");
        }

        var motor = PlayerMotor.Instance;
        Check("PlayerMotor.Instance", motor != null);

        // --- click-to-move end-to-end ---
        if (motor != null)
        {
            Vector3 start = motor.transform.position;
            int tx = Env.World2Logic(start.x + 2f);  // 2 units east
            int ty = Env.World2Logic(start.y);

            bool canClick = !Operation.bBlock && !Operation.bForbidClickMap;
            Check("click allowed (!block && !forbid)", canClick);

            Operation.ClickMap(tx, ty, false, false);
            Check("AutoPath.IsPathing after ClickMap", AutoPath.IsPathing(),
                  $"(target logic {tx},{ty})");
        }

        Debug.Log($"=== Smoke Test: {passed} passed, {failed} failed ===");
    }
}
