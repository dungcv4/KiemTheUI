using UnityEditor;
using UnityEngine;
using KTO.Game;
using NavAStar = KTO.Game.NavigationModule_AStar;

/// <summary>
/// Debug helper: warp the player to a known-walkable spawn, dump an ASCII
/// obstacle map around it, and run the full click-to-move flow so we can
/// capture the walker diagnostics without depending on wherever the player
/// happened to drift to during the previous test run.
/// </summary>
public static class WarpAndWalk
{
    [MenuItem("KTO/Test/Warp + Walk (stall diag)")]
    public static void Execute()
    {
        var playerGo = GameObject.Find("Player_ma_000a_free");
        if (playerGo == null) { Debug.LogError("[WarpWalk] player not found"); return; }

        var motor = playerGo.GetComponent<PlayerMotor>();
        if (motor == null) { Debug.LogError("[WarpWalk] PlayerMotor missing"); return; }
        Operation.RegisterMotor(motor);

        var grid = MapObstacleGrid.Instance;
        if (grid == null || !grid.Loaded) { Debug.LogError("[WarpWalk] no grid"); return; }

        // Warp to a known-walkable spot. (25.54, 31.83) was the starting
        // position from the earlier successful A* run (19 waypoints from
        // cell (80,197) to (99,197)).
        Vector3 warpTo = new Vector3(25.54f, 31.83f, playerGo.transform.position.z);
        playerGo.transform.position = warpTo;
        Debug.Log($"[WarpWalk] warped player to {warpTo}");

        // Dump a 25x15 ASCII map centered on the start cell so we can see
        // the obstacle layout around the path.
        if (grid.WorldToCell(warpTo, out int cx, out int cy))
        {
            Debug.Log($"[WarpWalk] start cell=({cx},{cy})");
            DumpAsciiMap(grid, cx, cy, 25, 7);
        }

        // Target: 6 world units east (same offset ClickToMoveSmokeTest uses).
        Vector3 target = warpTo + new Vector3(6f, 0f, 0f);
        int tgtLX = Env.World2Logic(target.x);
        int tgtLY = Env.World2Logic(target.y);

        // Reset click state + kick off the walker via Operation.ClickMap.
        Operation.bIsClickMapPathing = false;
        AutoPath.tbTargetPos        = null;
        AutoPath.bProcessAutoPath   = false;

        bool ret = Operation.ClickMap(tgtLX, tgtLY, isDoubleClick: false, bIsIgnoreFollow: false);
        Debug.Log($"[WarpWalk] Operation.ClickMap returned={ret} " +
                  $"bIsClickMapPathing={Operation.bIsClickMapPathing} " +
                  $"AutoPath.IsPathing={AutoPath.IsPathing()}");
        Debug.Log($"[WarpWalk] motor remainingFrames={motor.RemainingFrames} " +
                  $"curLogicDir={motor.CurLogicDir}");
        Debug.Log($"[WarpWalk] walker kicked — WAIT ~2s in Play mode then call " +
                  $"'KTO/Test/Dump Walker Result' to see where it ended up");
    }

    static void DumpAsciiMap(MapObstacleGrid grid, int cx, int cy, int widthCells, int heightCells)
    {
        var sb = new System.Text.StringBuilder();
        sb.AppendLine($"[WarpWalk] ASCII map around ({cx},{cy}) " +
                      $"({widthCells}x{heightCells}); '.'=walk '#'=blocked 'S'=start");
        int x0 = cx - widthCells / 2;
        int y0 = cy - heightCells / 2;
        for (int dy = 0; dy < heightCells; dy++)
        {
            int y = y0 + dy;
            sb.Append($"  y={y:D3} ");
            for (int dx = 0; dx < widthCells; dx++)
            {
                int x = x0 + dx;
                if (x < 0 || y < 0 || x >= grid.W || y >= grid.H) { sb.Append('?'); continue; }
                char ch;
                if (x == cx && y == cy)      ch = 'S';
                else if (grid.Walkable[x, y]) ch = '.';
                else                          ch = '#';
                sb.Append(ch);
            }
            sb.AppendLine();
        }
        Debug.Log(sb.ToString());
    }
}

public static class DumpWalkerResult
{
    [MenuItem("KTO/Test/Dump Walker Result")]
    public static void Execute()
    {
        var playerGo = GameObject.Find("Player_ma_000a_free");
        if (playerGo == null) { Debug.LogError("[WalkerResult] player not found"); return; }
        var motor = playerGo.GetComponent<PlayerMotor>();
        Debug.Log($"[WalkerResult] pos={playerGo.transform.position} " +
                  $"remainingFrames={motor.RemainingFrames} curLogicDir={motor.CurLogicDir} " +
                  $"AutoPath.IsPathing={AutoPath.IsPathing()}");
    }
}
