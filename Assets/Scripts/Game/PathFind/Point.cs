// ============================================================
// Source  : KTO_DecompiledReference/PathFind/Point.c (9 methods @ 0x01bf10d2..0x01bf13fc)
// Stub    : KiemTheOrigin_DeepExtract/_shared/DecompiledSource/PathFind/Point.cs
//
// Field layout (from DecompiledSource FieldOffsets):
//   x : int @ 0x10
//   y : int @ 0x14
//
// Direct translation of the IL2CPP Ghidra decomp; semantics verbatim.
// ============================================================
namespace PathFind
{
    public class Point
    {
        public int x;
        public int y;

        // .ctor @ 0x01bf12ca — default
        public Point() { x = 0; y = 0; }

        // .ctor @ 0x01bf10d2 — (int, int)
        public Point(int iX, int iY)
        {
            x = iX;
            y = iY;
        }

        // .ctor @ 0x01bf12df — copy (null throws in original via FUN_0185fa41)
        public Point(Point b)
        {
            if (b == null) throw new System.NullReferenceException();
            x = b.x;
            y = b.y;
        }

        // GetHashCode @ 0x01bf1310 — x XOR y
        public override int GetHashCode() => x ^ y;

        // Equals(object) @ 0x01bf1317 — type-checked, then compares x+y
        public override bool Equals(object obj)
        {
            if (obj is Point p) return x == p.x && y == p.y;
            return false;
        }

        // Equals(Point) @ 0x01bf1393
        public bool Equals(Point p)
        {
            if (p == null) return false;
            return x == p.x && y == p.y;
        }

        // op_Equality @ 0x01bf13ad
        public static bool operator ==(Point a, Point b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;
            return a.x == b.x && a.y == b.y;
        }

        // op_Inequality @ 0x01bf13d6
        public static bool operator !=(Point a, Point b) => !(a == b);

        // Set @ 0x01bf13fc
        public Point Set(int iX, int iY)
        {
            x = iX;
            y = iY;
            return this;
        }
    }
}
