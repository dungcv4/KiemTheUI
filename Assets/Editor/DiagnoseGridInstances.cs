using UnityEngine;
using KTO.Game;

public static class DiagnoseGridInstances
{
    // Detect whether there are multiple MapObstacleGrid instances in loaded
    // scenes, and whether MapObstacleGrid.Instance points at a loaded one.
    // Also queries the PlayerMotor's current walkability via the same code
    // path PlayerMotor uses inside GoDirection/TickOneFrame.
    public static void Execute()
    {
        var all = Object.FindObjectsOfType<MapObstacleGrid>();
        Debug.Log($"[DiagnoseGrid] found {all.Length} MapObstacleGrid(s) in scene(s)");
        for (int i = 0; i < all.Length; i++)
        {
            var g = all[i];
            Debug.Log($"[DiagnoseGrid]  [{i}] scene={g.gameObject.scene.name}  " +
                      $"path={GetPath(g.transform)}  loaded={g.Loaded}  " +
                      $"W={g.W} H={g.H}  origin=({g.WorldOrigin.x:F3},{g.WorldOrigin.y:F3})  " +
                      $"cell=({g.CellSize.x:F4},{g.CellSize.y:F4}) flipY={g.FlipY}");
        }

        var inst = MapObstacleGrid.Instance;
        if (inst == null)
        {
            Debug.LogError("[DiagnoseGrid] MapObstacleGrid.Instance is NULL");
        }
        else
        {
            Debug.Log($"[DiagnoseGrid] Instance = {GetPath(inst.transform)}  loaded={inst.Loaded}");
        }

        // Query the player's current walkability at the position it's at
        var players = Object.FindObjectsOfType<PlayerAssembler>();
        if (players.Length > 0)
        {
            var pg = players[0].transform;
            Vector2 p = pg.position;
            Debug.Log($"[DiagnoseGrid] player={pg.name} at ({p.x:F3},{p.y:F3})");
            if (inst != null)
            {
                bool center = inst.IsWalkableWorld(p);
                inst.WorldToCell(p, out int cx, out int cy);
                Debug.Log($"[DiagnoseGrid] Instance.IsWalkableWorld(player) = {center}  cell=({cx},{cy})");
                float r = Mathf.Min(inst.CellSize.x, inst.CellSize.y) * 0.4f;
                Debug.Log($"[DiagnoseGrid]   r={r:F4}  " +
                          $"L={inst.IsWalkableWorld(new Vector2(p.x-r,p.y))}  " +
                          $"R={inst.IsWalkableWorld(new Vector2(p.x+r,p.y))}  " +
                          $"U={inst.IsWalkableWorld(new Vector2(p.x,p.y+r))}  " +
                          $"D={inst.IsWalkableWorld(new Vector2(p.x,p.y-r))}");
            }
        }
    }

    static string GetPath(Transform t)
    {
        if (t == null) return "(null)";
        string path = t.name;
        while (t.parent != null)
        {
            t = t.parent;
            path = t.name + "/" + path;
        }
        return path;
    }
}
