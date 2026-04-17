using UnityEditor;
using UnityEngine;
using KTO.Game;
// Alias around the global AssetRipper dummy `NavigationModule_AStar`
// that shadows the real KTO.Game.NavigationModule_AStar when this file
// has `using KTO.Game;`. Same pattern JoyStickSmokeTest uses for UIJoyStick.
using NavAStar = KTO.Game.NavigationModule_AStar;

/// <summary>
/// Phase 8.2 end-to-end click-to-move smoke test.
///
/// Exercises the full chain:
///     Operation.ClickMap → AutoPath.GotoAndCallEx → PlayerMotor.GotoPosition
///                       → NavigationModule_AStar.FindPath → PathFind.Pathfinding
///                       → AutoPathWalker coroutine → GoDirection/StartDirection
///
/// Does NOT dispatch through ClickToMoveInput (no mouse needed). We skip
/// the UI layer and call Operation.ClickMap directly with pre-chosen logic
/// coords so the test is deterministic and harness-driven.
///
/// Test strategy:
///   1. Find the player and capture its start world position.
///   2. Pick a target world position offset by (+6, 0) world units (due east).
///   3. Convert to logic coords.
///   4. Call Operation.ClickMap(logicX, logicY, false, false).
///   5. Immediately report: bIsClickMapPathing, AutoPath.IsPathing(),
///      tbTargetPos values, whether A* produced a path.
///   6. Also run a direct NavigationModule_AStar.FindPath to verify the
///      grid + path builder work outside of the full call chain.
/// </summary>
public static class ClickToMoveSmokeTest
{
    [MenuItem("KTO/Test/ClickToMove Smoke Test")]
    public static void Execute()
    {
        var playerGo = GameObject.Find("Player_ma_000a_free");
        if (playerGo == null) { Debug.LogError("[ClickMoveSmoke] player not found (game not in play?)"); return; }

        var motor = playerGo.GetComponent<PlayerMotor>();
        if (motor == null) { Debug.LogError("[ClickMoveSmoke] PlayerMotor missing"); return; }

        // Defensive re-register in case a domain reload wiped the static.
        Operation.RegisterMotor(motor);

        var grid = MapObstacleGrid.Instance;
        if (grid == null || !grid.Loaded)
        {
            Debug.LogError("[ClickMoveSmoke] MapObstacleGrid not loaded — aborting");
            return;
        }
        Debug.Log($"[ClickMoveSmoke] grid W={grid.W} H={grid.H} origin={grid.WorldOrigin} cell={grid.CellSize}");

        // ---------- compute start + target ------------------------------
        Vector3 startWorld = playerGo.transform.position;
        Vector3 targetWorld = startWorld + new Vector3(6f, 0f, 0f); // ~6 world units east

        int startLX = Env.World2Logic(startWorld.x);
        int startLY = Env.World2Logic(startWorld.y);
        int tgtLX   = Env.World2Logic(targetWorld.x);
        int tgtLY   = Env.World2Logic(targetWorld.y);

        Debug.Log($"[ClickMoveSmoke] start world=({startWorld.x:F3},{startWorld.y:F3}) logic=({startLX},{startLY})");
        Debug.Log($"[ClickMoveSmoke] target world=({targetWorld.x:F3},{targetWorld.y:F3}) logic=({tgtLX},{tgtLY})");

        // ---------- Step 1: direct A* call -----------------------------
        var direct = NavAStar.FindPath(startLX, startLY, tgtLX, tgtLY);
        if (direct == null)
            Debug.LogError("[ClickMoveSmoke] direct FindPath returned NULL");
        else
            Debug.Log($"[ClickMoveSmoke] direct FindPath returned {direct.Length} waypoints, " +
                      $"first={direct[0]:F3} last={direct[direct.Length-1]:F3}");

        // ---------- Step 2: full Operation.ClickMap flow ---------------
        // Clear any residual state.
        Operation.bIsClickMapPathing = false;
        AutoPath.tbTargetPos        = null;
        AutoPath.bProcessAutoPath   = false;

        bool ret = Operation.ClickMap(tgtLX, tgtLY, isDoubleClick: false, bIsIgnoreFollow: false);

        Debug.Log($"[ClickMoveSmoke] Operation.ClickMap returned={ret} " +
                  $"bIsClickMapPathing={Operation.bIsClickMapPathing} " +
                  $"AutoPath.IsPathing={AutoPath.IsPathing()}");

        if (AutoPath.tbTargetPos != null)
        {
            var tb = AutoPath.tbTargetPos;
            Debug.Log($"[ClickMoveSmoke] tbTargetPos mapId={tb.nMapId} " +
                      $"target=({tb.nX},{tb.nY}) near={tb.nNearLength} " +
                      $"pathReason={tb.nPathReason}");
        }
        else
        {
            Debug.LogWarning("[ClickMoveSmoke] tbTargetPos is null after ClickMap — " +
                             "walker either short-circuited (already arrived) or the flow failed");
        }

        Debug.Log($"[ClickMoveSmoke] motor remainingFrames={motor.RemainingFrames} " +
                  $"curLogicDir={motor.CurLogicDir}");
    }
}
