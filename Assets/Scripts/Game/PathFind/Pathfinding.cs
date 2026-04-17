// ============================================================
// Source  : KTO_DecompiledReference/PathFind/Pathfinding.c (5 methods)
// Stub    : KiemTheOrigin_DeepExtract/_shared/DecompiledSource/PathFind/Pathfinding.cs
//
// Standard Unity A* tutorial implementation (Sebastian Lague style) — the
// Ghidra decomp matches line-for-line. Public surface:
//
//   static List<Point> FindPath(Grid grid, Point startPos, Point targetPos)
//       — wraps _ImpFindPath; turns the returned List<Node> into List<Point>.
//
//   static List<Node> _ImpFindPath(Grid grid, Point startPos, Point targetPos)
//       — the open/closed-set A* loop @ 0x01bf0b2a.
//
//   static List<Node> RetracePath(Grid grid, Node startNode, Node endNode)
//       — walks parent chain from end to start, reverses. @ 0x01bf10f1.
//
//   static int GetDistance(Node nodeA, Node nodeB)
//       — diagonal distance heuristic: `min(dx,dy) * 14 + |dx-dy| * 10`
//         @ 0x01bf11ea. `14 ≈ sqrt(2)*10`.
// ============================================================
using System.Collections.Generic;

namespace PathFind
{
    public class Pathfinding
    {
        // FindPath @ 0x01bf08d3 — public wrapper
        public static List<Point> FindPath(Grid grid, Point startPos, Point targetPos)
        {
            var result = new List<Point>();
            var nodePath = _ImpFindPath(grid, startPos, targetPos);
            if (nodePath != null)
            {
                foreach (var n in nodePath)
                {
                    result.Add(new Point(n.gridX, n.gridY));
                }
            }
            return result;
        }

        // _ImpFindPath @ 0x01bf0b2a
        //
        // Bounds checks start/target against grid.nodes, then runs A*:
        //
        //   startNode  = grid.nodes[start.x, start.y]
        //   targetNode = grid.nodes[target.x, target.y]
        //   open       = new List<Node> { startNode }
        //   closed     = new HashSet<Node>()
        //
        //   while open.Count > 0:
        //     current = open[0]
        //     for i in 1..open.Count:
        //       if open[i].fCost < current.fCost ||
        //          (open[i].fCost == current.fCost && open[i].hCost < current.hCost)
        //          current = open[i]
        //     open.Remove(current); closed.Add(current)
        //     if current == targetNode: return RetracePath(grid, startNode, targetNode)
        //     foreach neighbour in grid.GetNeighbours(current):
        //       if !neighbour.walkable || closed.Contains(neighbour) continue
        //       newMoveCost = current.gCost + GetDistance(current, neighbour) * (int)(neighbour.penalty * 10)
        //       if newMoveCost < neighbour.gCost || !open.Contains(neighbour):
        //         neighbour.gCost  = newMoveCost
        //         neighbour.hCost  = GetDistance(neighbour, targetNode)
        //         neighbour.parent = current
        //         if !open.Contains(neighbour): open.Add(neighbour)
        private static List<Node> _ImpFindPath(Grid grid, Point startPos, Point targetPos)
        {
            if (grid == null || startPos == null || targetPos == null) return null;
            if (grid.nodes == null) return null;

            int w = grid.nodes.GetLength(0);
            int h = grid.nodes.GetLength(1);
            if ((uint)startPos.x  >= (uint)w || (uint)startPos.y  >= (uint)h) return null;
            if ((uint)targetPos.x >= (uint)w || (uint)targetPos.y >= (uint)h) return null;

            Node startNode  = grid.nodes[startPos.x,  startPos.y];
            Node targetNode = grid.nodes[targetPos.x, targetPos.y];

            var openSet   = new List<Node>();
            var closedSet = new HashSet<Node>();
            openSet.Add(startNode);

            while (openSet.Count > 0)
            {
                Node current = openSet[0];
                for (int i = 1; i < openSet.Count; i++)
                {
                    var n = openSet[i];
                    if (n.fCost < current.fCost ||
                        (n.fCost == current.fCost && n.hCost < current.hCost))
                    {
                        current = n;
                    }
                }

                openSet.Remove(current);
                closedSet.Add(current);

                if (current == targetNode)
                {
                    return RetracePath(grid, startNode, targetNode);
                }

                var neighbours = grid.GetNeighbours(current);
                if (neighbours == null) break;
                foreach (var neighbour in neighbours)
                {
                    if (!neighbour.walkable) continue;
                    if (closedSet.Contains(neighbour)) continue;

                    int newMoveCost = current.gCost
                                    + GetDistance(current, neighbour) * (int)(neighbour.penalty * 10f);

                    bool inOpen = openSet.Contains(neighbour);
                    if (newMoveCost < neighbour.gCost || !inOpen)
                    {
                        neighbour.gCost  = newMoveCost;
                        neighbour.hCost  = GetDistance(neighbour, targetNode);
                        neighbour.parent = current;
                        if (!inOpen) openSet.Add(neighbour);
                    }
                }
            }

            return null;
        }

        // RetracePath @ 0x01bf10f1 — walk parent chain from end to start, reverse.
        private static List<Node> RetracePath(Grid grid, Node startNode, Node endNode)
        {
            var path = new List<Node>();
            Node cur = endNode;
            while (cur != startNode)
            {
                path.Add(cur);
                if (cur == null) break;
                cur = cur.parent;
            }
            path.Reverse();
            return path;
        }

        // GetDistance @ 0x01bf11ea
        //   dx = |a.gridX - b.gridX|
        //   dy = |a.gridY - b.gridY|
        //   return min(dx,dy) * 14 + |dx - dy| * 10
        private static int GetDistance(Node nodeA, Node nodeB)
        {
            if (nodeA == null || nodeB == null) throw new System.NullReferenceException();

            int dx = System.Math.Abs(nodeA.gridX - nodeB.gridX);
            int dy = System.Math.Abs(nodeA.gridY - nodeB.gridY);

            int min  = dx < dy ? dx : dy;
            int diff = System.Math.Abs(dx - dy);
            return min * 14 + diff * 10;
        }
    }
}
