// ============================================================
// Source  : KTO_DecompiledReference/PathFind/Node.c (2 methods @ 0x01bf0582, 0x01bf08cc)
// Stub    : KiemTheOrigin_DeepExtract/_shared/DecompiledSource/PathFind/Node.cs
//
// Field layout (from DecompiledSource FieldOffsets):
//   walkable : bool  @ 0x10
//   gridX    : int   @ 0x14
//   gridY    : int   @ 0x18
//   penalty  : float @ 0x1C
//   gCost    : int   @ 0x20
//   hCost    : int   @ 0x24
//   parent   : Node  @ 0x28
//
// .ctor body (literal):
//   walkable = _price != 0.0
//   penalty  = _price
//   gridX    = _gridX
//   gridY    = _gridY
// ============================================================
namespace PathFind
{
    public class Node
    {
        public bool  walkable;
        public int   gridX;
        public int   gridY;
        public float penalty;
        public int   gCost;
        public int   hCost;
        public Node  parent;

        // .ctor @ 0x01bf0582
        public Node(float _price, int _gridX, int _gridY)
        {
            walkable = _price != 0f;
            penalty  = _price;
            gridX    = _gridX;
            gridY    = _gridY;
        }

        // get_fCost @ 0x01bf08cc
        public int fCost => hCost + gCost;
    }
}
