using UnityEngine;
using KTO.Game;

public static class ProbeWestWalk
{
    // Probes IsWalkableWorld along the player's actual west-walk path from
    // the spawn cell, to diagnose why the player walked through what the
    // cell-accurate probe said were blocked cells.
    public static void Execute()
    {
        var grid = MapObstacleGrid.Instance;
        if (grid == null)
        {
            var holder = GameObject.Find("yunzhongzhen1_a/Runtime Layer/MapObstacleGrid");
            if (holder != null) grid = holder.GetComponent<MapObstacleGrid>();
        }
        grid.EnsureLoaded();

        Debug.Log($"[ProbeWestWalk] W={grid.W} H={grid.H} origin=({grid.WorldOrigin.x:F3},{grid.WorldOrigin.y:F3}) cell=({grid.CellSize.x:F4},{grid.CellSize.y:F4}) flipY={grid.FlipY}");

        // Step from x=43.52 to x=42.24 in 0.05 increments, y=25.68
        float y = 25.68f;
        for (float x = 43.60f; x >= 42.20f; x -= 0.05f)
        {
            bool center = grid.IsWalkableWorld(new Vector2(x, y));
            grid.WorldToCell(new Vector2(x, y), out int cx, out int cy);
            // 4-corner footprint
            float r = Mathf.Min(grid.CellSize.x, grid.CellSize.y) * 0.4f;
            bool wLeft   = grid.IsWalkableWorld(new Vector2(x - r, y));
            bool wRight  = grid.IsWalkableWorld(new Vector2(x + r, y));
            bool wUp     = grid.IsWalkableWorld(new Vector2(x, y + r));
            bool wDown   = grid.IsWalkableWorld(new Vector2(x, y - r));
            bool all = center && wLeft && wRight && wUp && wDown;
            Debug.Log($"[ProbeWestWalk] x={x:F3} cell=({cx},{cy})  center={(center?"W":"B")} L={(wLeft?"W":"B")} R={(wRight?"W":"B")} U={(wUp?"W":"B")} D={(wDown?"W":"B")}  footprint={(all?"WALK":"BLOCK")}");
        }
    }
}
