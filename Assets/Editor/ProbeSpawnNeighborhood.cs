using UnityEngine;
using KTO.Game;

public static class ProbeSpawnNeighborhood
{
    public static void Execute()
    {
        var grid = MapObstacleGrid.Instance;
        if (grid == null)
        {
            var holder = GameObject.Find("yunzhongzhen1_a/Runtime Layer/MapObstacleGrid");
            if (holder != null) grid = holder.GetComponent<MapObstacleGrid>();
        }
        grid.EnsureLoaded();

        // Ring of expected walkable positions: the character has been seen
        // walking around this area, so nearly every cell within 1-2 world
        // units should be walkable.
        Vector2 spawn = new Vector2(43.36f, 25.76f);
        grid.WorldToCell(spawn, out int cxC, out int cyC);
        Debug.Log($"[ProbeSpawn] spawn = {spawn}  cell=({cxC},{cyC})");

        // 7x7 cell grid centered on spawn cell
        var sb = new System.Text.StringBuilder();
        sb.AppendLine($"[ProbeSpawn] 7x7 cell neighborhood (row 0 = top in file, col 0 = left):");
        for (int dy = -3; dy <= 3; dy++)
        {
            string row = $"  dy={dy,+2}: ";
            for (int dx = -3; dx <= 3; dx++)
            {
                int cx = cxC + dx, cy = cyC + dy;
                bool w = grid.IsWalkableCell(cx, cy);
                row += w ? ". " : "# ";
            }
            sb.AppendLine(row);
        }
        Debug.Log(sb.ToString());

        // Spiral outward — nearest walkable cell
        int maxR = 40;
        for (int r = 0; r <= maxR; r++)
        {
            for (int dy = -r; dy <= r; dy++)
            {
                for (int dx = -r; dx <= r; dx++)
                {
                    // only check boundary of the current radius
                    if (Mathf.Max(Mathf.Abs(dx), Mathf.Abs(dy)) != r) continue;
                    int cx = cxC + dx, cy = cyC + dy;
                    if (grid.IsWalkableCell(cx, cy))
                    {
                        Vector2 w = grid.CellToWorld(cx, cy);
                        Debug.Log($"[ProbeSpawn] nearest walkable cell to spawn: ({cx},{cy})  " +
                                  $"world=({w.x:F3},{w.y:F3})  " +
                                  $"dCell=({dx},{dy})  Chebyshev radius={r}");
                        return;
                    }
                }
            }
        }
        Debug.Log("[ProbeSpawn] NO walkable cell found within radius 40 — calibration is way off");
    }
}
