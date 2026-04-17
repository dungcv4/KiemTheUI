// ============================================================
// Source  : KTO_DecompiledReference/PathFind/Grid.c (3 methods)
// Stub    : KiemTheOrigin_DeepExtract/_shared/DecompiledSource/PathFind/Grid.cs
//
// Field layout (from DecompiledSource FieldOffsets):
//   nodes     : Node[,] @ 0x10
//   gridSizeX : int     @ 0x18
//   gridSizeY : int     @ 0x1C
//
// Two constructors (both decoded from Ghidra @ 0x01bf03fa and 0x01bf05cb):
//   Grid(int w, int h, float[,] tiles_costs)  — per-tile float penalty
//   Grid(int w, int h, bool[,]  walkable_tiles) — bool → penalty 1.0 or 0.0
//
// Node walkable flag inside loops comes from: `walkable = penalty != 0.0`
// (matches Node.ctor body @ 0x01bf0582).
//
// GetNeighbours iterates the 3×3 box around the node excluding (0,0), with
// bounds checks. 8-way connectivity.
// ============================================================
using System.Collections.Generic;

namespace PathFind
{
    public class Grid
    {
        public Node[,] nodes;
        int gridSizeX;
        int gridSizeY;

        // .ctor(int, int, float[,]) @ 0x01bf03fa
        public Grid(int width, int height, float[,] tiles_costs)
        {
            gridSizeX = width;
            gridSizeY = height;
            nodes = new Node[width, height];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    float penalty = tiles_costs[i, j];
                    nodes[i, j] = new Node(penalty, i, j);
                }
            }
        }

        // .ctor(int, int, bool[,]) @ 0x01bf05cb
        // Literal: `fVar7 = walkable_tiles[i,j] ? 1.0 : 0.0;`
        public Grid(int width, int height, bool[,] walkable_tiles)
        {
            gridSizeX = width;
            gridSizeY = height;
            nodes = new Node[width, height];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    float penalty = walkable_tiles[i, j] ? 1f : 0f;
                    nodes[i, j] = new Node(penalty, i, j);
                }
            }
        }

        // GetNeighbours @ 0x01bf0770
        // iVar9 = -1..1, iVar8 = -1..1, skip (0,0), bounds-check, push.
        public List<Node> GetNeighbours(Node node)
        {
            var result = new List<Node>();
            for (int dx = -1; dx <= 1; dx++)
            {
                for (int dy = -1; dy <= 1; dy++)
                {
                    if (dx == 0 && dy == 0) continue;
                    int nx = node.gridX + dx;
                    int ny = node.gridY + dy;
                    if (nx < 0 || ny < 0) continue;
                    if (nx >= gridSizeX || ny >= gridSizeY) continue;
                    result.Add(nodes[nx, ny]);
                }
            }
            return result;
        }
    }
}
