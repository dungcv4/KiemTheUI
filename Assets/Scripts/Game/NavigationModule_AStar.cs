// ============================================================
// Source  : KTO_DecompiledReference/_root/NavigationModule_AStar.c (5 methods)
// Stub    : KiemTheOrigin_DeepExtract/_shared/DecompiledSource/NavigationModule_AStar.cs
// Lua use : Client.NavigationModule.GetNavMeshPoint / ClearPathLine
//           (Script_Common_AutoPath.lua:354; Script_Common_Operation.lua:332)
//
// Public surface (signatures from DecompiledSource / IL2CPP):
//
//   static Vector3[] FindPath(int nLogicStartX, int nLogicStartY,
//                             int nLogicEndX,  int nLogicEndY)
//
// The native `FindPath` @ 0x01c792c2 does:
//   1. `(x + (x<0?0xff:0)) >> 8` to collapse logic → grid (256 logic/cell)
//   2. Builds PathFind.Point(start) + PathFind.Point(end)
//   3. Calls PathFind.Pathfinding.FindPath(_Grid, startPt, endPt)
//   4. Walks returned Point list; for each emits Vector3(
//        (gridX<<8 | 0x80) / 800.0,
//        (gridY<<8 | 0x80) / 1600.0,
//        0)
//      (i.e. cell-center logic coord → world coord, with a Y-divisor of
//      1600 = 2×800 for the native's 2:1 isometric aspect.)
//
// DEVIATION — CELL RESOLUTION
// The native A* grid is 256-logic units per cell. Our `MapObstacleGrid` is
// loaded from a different dump with `CellSize = (0.3, 0.15)` world units =
// (240, 120) logic units — coarser along Y, finer along X. The native's raw
// `>> 8` input shift therefore wouldn't line up with our obstacle data.
//
// So we wrap at a higher abstraction: same public contract (logic in,
// Vector3[] waypoints out) but internally we route through
// `MapObstacleGrid.WorldToCell` / `CellToWorld`. The A* semantics are
// identical; only the grid resolution differs.
//
// Grid caching: the first call builds a `PathFind.Grid` from
// `MapObstacleGrid.Walkable`. The grid is rebuilt if `MapObstacleGrid.Instance`
// changes (map load / scene change).
// ============================================================
using UnityEngine;

namespace KTO.Game
{
    public static class NavigationModule_AStar
    {
        static PathFind.Grid  _Grid;
        static MapObstacleGrid _SourceGrid;     // invalidate when the host GO changes
        static bool[,]         _SourceWalkable; // invalidate when Load() allocated a new array
                                                // (domain reload on the MonoBehaviour can
                                                // wipe + re-populate Walkable with a fresh
                                                // array while `_SourceGrid == src` stays true)

        // Init @ 0x01c7b40c — resets static state. No-op in our port; the grid
        // is rebuilt lazily on first FindPath call.
        public static void Init()
        {
            _Grid           = null;
            _SourceGrid     = null;
            _SourceWalkable = null;
        }

        // FindPath @ 0x01c792c2 — public entry point.
        //
        // Returns null if no path, empty if start==end, otherwise the
        // waypoint array. First element is the step AFTER the start cell;
        // last element is the target cell (inclusive), matching the native's
        // `RetracePath` output shape.
        public static Vector3[] FindPath(int nLogicStartX, int nLogicStartY,
                                         int nLogicEndX,  int nLogicEndY)
        {
            var src = MapObstacleGrid.Instance;
            // Split the early-out into 3 distinct conditions so we can see
            // exactly which one fired during debugging. After hot reload
            // (file edit during play mode), the scene's MapObstacleGrid
            // MonoBehaviour can survive with non-SerializeField state
            // (Walkable / Loaded / W / H) wiped — `Instance`'s EnsureLoaded
            // self-heal handles the Loaded==false path but a direct caller
            // can still hit a stale `src` reference whose fields are zeroed.
            if (src == null)
            {
                Debug.LogWarning("[NavAStar] MapObstacleGrid.Instance == null");
                return null;
            }
            if (!src.Loaded)
            {
                Debug.LogWarning("[NavAStar] src.Loaded == false — calling EnsureLoaded()");
                src.EnsureLoaded();
            }
            if (src.Walkable == null)
            {
                Debug.LogWarning("[NavAStar] src.Walkable == null after EnsureLoaded — giving up");
                return null;
            }

            // Lazy rebuild of the PathFind grid when the source changes.
            // Two invalidation keys:
            //   - `_SourceGrid != src`      → different MapObstacleGrid GO (scene change)
            //   - `_SourceWalkable != src.Walkable` → same GO but Load() re-allocated
            //                                         the bitmap (hot reload scenario)
            if (_Grid == null || _SourceGrid != src || _SourceWalkable != src.Walkable)
            {
                _Grid           = new PathFind.Grid(src.W, src.H, src.Walkable);
                _SourceGrid     = src;
                _SourceWalkable = src.Walkable;
            }

            // Logic → world → cell. The native's `>> 8` is replaced by this
            // route because our cell size doesn't match 256-logic.
            Vector2 startWorld = new Vector2(Env.Logic2World(nLogicStartX),
                                             Env.Logic2World(nLogicStartY));
            Vector2 endWorld   = new Vector2(Env.Logic2World(nLogicEndX),
                                             Env.Logic2World(nLogicEndY));

            if (!src.WorldToCell(startWorld, out int sx, out int sy)) return null;
            if (!src.WorldToCell(endWorld,   out int ex, out int ey)) return null;

            Debug.Log($"[NavAStar] FindPath: start={startWorld}→cell({sx},{sy}) walk={src.Walkable[sx,sy]} " +
                      $"end={endWorld}→cell({ex},{ey}) walk={src.Walkable[ex,ey]}");

            // Snap to the nearest walkable cell if the raw cell is blocked.
            //
            // Behavior match: the original Lua flow routes every click-to-
            // move request through `Client.NavigationModule.GetNavMeshPoint`
            // (AutoPath.lua:354) — a native method that snaps to the nearest
            // valid nav-mesh point. The native `me.GotoPosition` likewise
            // snaps its target internally (how else could you click on a
            // building wall and have the character walk up to it?). We
            // preserve that semantics here: if start or end is a blocked
            // cell, Chebyshev-spiral out to the nearest walkable cell.
            //
            // Without this snap, A* would return null any time the user
            // clicks on a prop, a wall, or even a corner where the grid's
            // discretization pushed the world point across a blocked cell
            // boundary.
            if (!src.Walkable[sx, sy])
            {
                if (!SnapToWalkable(src, sx, sy, out sx, out sy))
                {
                    Debug.LogWarning($"[NavAStar] start cell ({sx},{sy}) blocked " +
                                     $"and no walkable cell within snap radius");
                    return null;
                }
            }
            if (!src.Walkable[ex, ey])
            {
                if (!SnapToWalkable(src, ex, ey, out ex, out ey))
                {
                    Debug.LogWarning($"[NavAStar] end cell ({ex},{ey}) blocked " +
                                     $"and no walkable cell within snap radius");
                    return null;
                }
            }

            // Reset gCost / hCost / parent on every node touched by the last
            // run. The native leaks state across calls because Nodes are
            // allocated fresh per Grid; we reuse the Grid, so we must clear.
            ClearNodeState(_Grid);

            var startPt = new PathFind.Point(sx, sy);
            var endPt   = new PathFind.Point(ex, ey);

            var pointPath = PathFind.Pathfinding.FindPath(_Grid, startPt, endPt);
            if (pointPath == null || pointPath.Count == 0) return null;

            // Convert each grid cell back to world coords (cell center).
            // The native's `(x<<8|0x80)/800` is cell-center in the native's
            // 256-logic grid; `CellToWorld` is the equivalent for ours.
            var result = new Vector3[pointPath.Count];
            for (int i = 0; i < pointPath.Count; i++)
            {
                var p = pointPath[i];
                Vector2 w = src.CellToWorld(p.x, p.y);
                result[i] = new Vector3(w.x, w.y, 0f);
            }
            return result;
        }

        // Chebyshev-spiral outward from (cx, cy) looking for the nearest
        // walkable cell in `src.Walkable`. Matches the behavior of the
        // native `Client.NavigationModule.GetNavMeshPoint`, which snaps
        // an input world point to the closest valid nav-mesh point.
        //
        // Radius cap of 32 cells keeps the search bounded — past ~32 cells
        // we're too far from the user's intended click to be useful, and
        // returning null lets the caller fail cleanly.
        const int SNAP_RADIUS = 32;
        static bool SnapToWalkable(MapObstacleGrid src, int cx, int cy,
                                    out int outCx, out int outCy)
        {
            for (int r = 1; r <= SNAP_RADIUS; r++)
            {
                for (int dy = -r; dy <= r; dy++)
                {
                    for (int dx = -r; dx <= r; dx++)
                    {
                        // Only the outer ring at this radius
                        if (Mathf.Max(Mathf.Abs(dx), Mathf.Abs(dy)) != r) continue;
                        int nx = cx + dx;
                        int ny = cy + dy;
                        if (nx < 0 || ny < 0 || nx >= src.W || ny >= src.H) continue;
                        if (src.Walkable[nx, ny])
                        {
                            outCx = nx;
                            outCy = ny;
                            return true;
                        }
                    }
                }
            }
            outCx = cx;
            outCy = cy;
            return false;
        }

        // Clear per-search state so a cached Grid can be reused. Needed
        // because we don't reallocate nodes per call like the native does.
        static void ClearNodeState(PathFind.Grid grid)
        {
            if (grid == null || grid.nodes == null) return;
            int w = grid.nodes.GetLength(0);
            int h = grid.nodes.GetLength(1);
            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    var n = grid.nodes[x, y];
                    if (n == null) continue;
                    n.gCost  = 0;
                    n.hCost  = 0;
                    n.parent = null;
                }
            }
        }
    }
}
