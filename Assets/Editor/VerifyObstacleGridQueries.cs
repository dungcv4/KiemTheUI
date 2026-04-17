using UnityEngine;
using KTO.Game;

public static class VerifyObstacleGridQueries
{
    public static void Execute()
    {
        var grid = MapObstacleGrid.Instance;
        if (grid == null)
        {
            var holder = GameObject.Find("yunzhongzhen1_a/Runtime Layer/MapObstacleGrid");
            if (holder != null) grid = holder.GetComponent<MapObstacleGrid>();
        }
        if (grid == null) { Debug.LogError("[VerifyObstacleGrid] no grid"); return; }
        grid.EnsureLoaded();

        Debug.Log($"[VerifyObstacleGrid] grid W={grid.W} H={grid.H}  " +
                  $"origin=({grid.WorldOrigin.x:F3},{grid.WorldOrigin.y:F3})  " +
                  $"cellSize=({grid.CellSize.x:F4},{grid.CellSize.y:F4})  flipY={grid.FlipY}");

        // 1) Player spawn — should be walkable (character stands here at
        //    game start, per GameStart.cs)
        Vector2 spawn = new Vector2(43.36f, 25.76f);
        Test("player spawn (expected WALKABLE)", grid, spawn);

        // 2) A few world positions far inside the big stone palace roof
        //    that we visually verified are covered by the red outline.
        //    Those should be BLOCKED.
        Test("palace roof NW (expected BLOCKED)",    grid, new Vector2(38f, 35f));
        Test("palace roof NE (expected BLOCKED)",    grid, new Vector2(50f, 35f));
        Test("courtyard center (expected WALKABLE)", grid, new Vector2(44f, 31f));

        // 3) Out-of-bounds should be BLOCKED
        Test("off-map left (expected BLOCKED)",  grid, new Vector2(-10f, 25f));
        Test("off-map right (expected BLOCKED)", grid, new Vector2(200f, 25f));
        Test("off-map top (expected BLOCKED)",   grid, new Vector2(40f, 100f));
        Test("off-map bottom (expected BLOCKED)", grid, new Vector2(40f, -10f));

        // 4) Count total walkable ratio — for sanity
        int total = grid.W * grid.H;
        int walk = 0;
        for (int y = 0; y < grid.H; y++)
            for (int x = 0; x < grid.W; x++)
                if (grid.Walkable[x, y]) walk++;
        float pct = 100f * walk / total;
        Debug.Log($"[VerifyObstacleGrid] walkable {walk}/{total} = {pct:F1}%  " +
                  $"(blocked {100f - pct:F1}%)");
    }

    static void Test(string label, MapObstacleGrid grid, Vector2 w)
    {
        bool ok = grid.WorldToCell(w, out int cx, out int cy);
        bool walk = grid.IsWalkableWorld(w);
        Debug.Log($"[VerifyObstacleGrid] {label,-42} world=({w.x:F2},{w.y:F2})  " +
                  $"cell=({cx},{cy}) inRange={ok}  walkable={walk}");
    }
}
