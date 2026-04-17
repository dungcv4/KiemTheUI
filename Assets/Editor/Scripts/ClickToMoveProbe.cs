using UnityEditor;
using UnityEngine;
using KTO.Game;
using NavAStar = KTO.Game.NavigationModule_AStar;

/// <summary>
/// Deeper diagnostic for the "direct FindPath returned NULL" case
/// reported by ClickToMoveSmokeTest. Explicitly prints:
///   - start + target cell coords
///   - whether each is walkable per MapObstacleGrid.Walkable
///   - how many walkable cells exist on row y=cy of start
///   - a manual PathFind.Grid walk to confirm neighbors work
/// </summary>
public static class ClickToMoveProbe
{
    [MenuItem("KTO/Test/ClickToMove Probe (deep diag)")]
    public static void Execute()
    {
        var playerGo = GameObject.Find("Player_ma_000a_free");
        if (playerGo == null) { Debug.LogError("[ClickMoveProbe] player not found"); return; }

        var grid = MapObstacleGrid.Instance;
        if (grid == null || !grid.Loaded) { Debug.LogError("[ClickMoveProbe] no grid"); return; }

        Vector3 startWorld = playerGo.transform.position;
        Vector3 targetWorld = startWorld + new Vector3(6f, 0f, 0f);

        if (!grid.WorldToCell(startWorld, out int sx, out int sy))
        {
            Debug.LogError($"[ClickMoveProbe] start {startWorld} out of grid");
            return;
        }
        if (!grid.WorldToCell(targetWorld, out int tx, out int ty))
        {
            Debug.LogError($"[ClickMoveProbe] target {targetWorld} out of grid");
            return;
        }

        bool sWalk = grid.Walkable[sx, sy];
        bool tWalk = grid.Walkable[tx, ty];
        Debug.Log($"[ClickMoveProbe] start cell=({sx},{sy}) walkable={sWalk}");
        Debug.Log($"[ClickMoveProbe] target cell=({tx},{ty}) walkable={tWalk}");

        // Scan row sy for walkable cells between sx and tx.
        int walkCount = 0;
        int blockedCount = 0;
        for (int x = Mathf.Min(sx, tx); x <= Mathf.Max(sx, tx); x++)
        {
            if (grid.Walkable[x, sy]) walkCount++;
            else blockedCount++;
        }
        Debug.Log($"[ClickMoveProbe] row y={sy} between x=[{Mathf.Min(sx,tx)},{Mathf.Max(sx,tx)}]: " +
                  $"walkable={walkCount} blocked={blockedCount}");

        // Rebuild grid fresh and run A* manually with explicit reset.
        Debug.Log("[ClickMoveProbe] MARK A: about to build PathFind.Grid");
        var pfg = new PathFind.Grid(grid.W, grid.H, grid.Walkable);
        Debug.Log($"[ClickMoveProbe] MARK B: built PathFind.Grid {grid.W}x{grid.H}");
        var sNode = pfg.nodes[sx, sy];
        var tNode = pfg.nodes[tx, ty];
        Debug.Log($"[ClickMoveProbe] MARK C: sNode null?={sNode==null} tNode null?={tNode==null}");
        if (sNode != null) Debug.Log($"[ClickMoveProbe] MARK D: sNode walkable={sNode.walkable}");
        if (tNode != null) Debug.Log($"[ClickMoveProbe] MARK E: tNode walkable={tNode.walkable}");

        // Direct A* — wrap in try/catch because an unreachable target is
        // one of the exact edge cases we want to diagnose.
        try
        {
            var pts = PathFind.Pathfinding.FindPath(pfg,
                new PathFind.Point(sx, sy), new PathFind.Point(tx, ty));
            if (pts == null)
                Debug.LogError("[ClickMoveProbe] raw A* returned NULL (no path)");
            else if (pts.Count == 0)
                Debug.LogWarning("[ClickMoveProbe] raw A* returned empty list");
            else
                Debug.Log($"[ClickMoveProbe] raw A* returned {pts.Count} points: " +
                          $"first=({pts[0].x},{pts[0].y}) last=({pts[pts.Count-1].x},{pts[pts.Count-1].y})");
        }
        catch (System.Exception ex)
        {
            Debug.LogError($"[ClickMoveProbe] raw A* threw: {ex.GetType().Name}: {ex.Message}\n{ex.StackTrace}");
        }

        // And via NavigationModule_AStar wrapper.
        int startLX = Env.World2Logic(startWorld.x);
        int startLY = Env.World2Logic(startWorld.y);
        int tgtLX   = Env.World2Logic(targetWorld.x);
        int tgtLY   = Env.World2Logic(targetWorld.y);
        var wrap = NavAStar.FindPath(startLX, startLY, tgtLX, tgtLY);
        if (wrap == null)
            Debug.LogError("[ClickMoveProbe] NavAStar.FindPath wrapper returned NULL");
        else
            Debug.Log($"[ClickMoveProbe] NavAStar.FindPath wrapper returned {wrap.Length} points");

        // Also print the immediate neighbors of the start cell.
        var neigh = pfg.GetNeighbours(pfg.nodes[sx, sy]);
        Debug.Log($"[ClickMoveProbe] start neighbours count={neigh.Count}");
        foreach (var n in neigh)
            Debug.Log($"[ClickMoveProbe]   neigh ({n.gridX},{n.gridY}) walkable={n.walkable}");
    }
}
