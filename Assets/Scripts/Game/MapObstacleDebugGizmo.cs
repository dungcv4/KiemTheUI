using UnityEngine;

namespace KTO.Game
{
    /// <summary>
    /// Editor-time overlay that draws red cubes over every blocked cell in
    /// a <see cref="MapObstacleGrid"/>. Used to visually calibrate
    /// <c>WorldOrigin</c>/<c>CellSize</c> until the gizmo blob sits on top
    /// of the actual building walls in the rendered map.
    ///
    /// Lives alongside the game scripts (not in /Editor) so it can be
    /// attached as a MonoBehaviour, but the draw code is wrapped in
    /// <c>#if UNITY_EDITOR</c> so it compiles out for builds.
    /// </summary>
    [RequireComponent(typeof(MapObstacleGrid))]
    public class MapObstacleDebugGizmo : MonoBehaviour
    {
        [Header("Display")]
        public bool Draw = true;

        [Tooltip("Solid cube per blocked cell.")]
        public Color BlockedColor = new Color(1f, 0.2f, 0.2f, 0.35f);

        [Tooltip("Only draw cells on the boundary between walkable and blocked " +
                 "(huge perf win on dense maps, still shows the outline clearly).")]
        public bool DrawOnlyEdges = true;

        [Tooltip("Draw every Nth cell instead of every one. Bigger = faster gizmo.")]
        [Range(1, 8)] public int CellStride = 1;

        [Tooltip("Also draw a wire box around the full grid rect in green, " +
                 "so you can see grid extent + alignment at a glance.")]
        public bool DrawGridOutline = true;

        public Color GridOutlineColor = new Color(0.2f, 1f, 0.2f, 0.8f);

#if UNITY_EDITOR
        void OnDrawGizmos()
        {
            if (!Draw) return;
            var grid = GetComponent<MapObstacleGrid>();
            if (grid == null) return;
            grid.EnsureLoaded();
            if (grid.Walkable == null) return;

            int W = grid.W, H = grid.H;
            Vector3 cubeSize = new Vector3(
                grid.CellSize.x * CellStride,
                grid.CellSize.y * CellStride,
                0.01f);

            // --- blocked cells ---
            Gizmos.color = BlockedColor;
            for (int y = 0; y < H; y += CellStride)
            {
                for (int x = 0; x < W; x += CellStride)
                {
                    if (grid.Walkable[x, y]) continue; // walkable

                    if (DrawOnlyEdges)
                    {
                        bool edge = false;
                        if (x > 0     && grid.Walkable[x - 1, y]) edge = true;
                        if (x < W - 1 && grid.Walkable[x + 1, y]) edge = true;
                        if (y > 0     && grid.Walkable[x, y - 1]) edge = true;
                        if (y < H - 1 && grid.Walkable[x, y + 1]) edge = true;
                        if (!edge) continue;
                    }

                    Vector2 w = grid.CellToWorld(x, y);
                    Gizmos.DrawCube(new Vector3(w.x, w.y, 0f), cubeSize);
                }
            }

            // --- outer grid outline ---
            if (DrawGridOutline)
            {
                Gizmos.color = GridOutlineColor;
                Vector2 bl = grid.CellToWorld(0,       grid.FlipY ? H - 1 : 0) - grid.CellSize * 0.5f;
                Vector2 br = grid.CellToWorld(W - 1,   grid.FlipY ? H - 1 : 0) + new Vector2(grid.CellSize.x * 0.5f, -grid.CellSize.y * 0.5f);
                Vector2 tl = grid.CellToWorld(0,       grid.FlipY ? 0 : H - 1) + new Vector2(-grid.CellSize.x * 0.5f, grid.CellSize.y * 0.5f);
                Vector2 tr = grid.CellToWorld(W - 1,   grid.FlipY ? 0 : H - 1) + grid.CellSize * 0.5f;
                Gizmos.DrawLine(bl, br);
                Gizmos.DrawLine(br, tr);
                Gizmos.DrawLine(tr, tl);
                Gizmos.DrawLine(tl, bl);
            }
        }
#endif
    }
}
