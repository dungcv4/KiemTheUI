using System;
using System.IO;
using UnityEngine;

namespace KTO.Game
{
    /// <summary>
    /// Loads a map obstacle bitmask from <c>obstacle.bytes</c> and exposes
    /// walkability queries for the player motor + A* pathfinder.
    ///
    /// File format (verified Phase 6.1 by visual decode of yunzhongzhen1_a):
    ///   [int32 W][int32 H][ W*H bits, row-major, MSB-first ]
    ///   bit == 1  -> blocked
    ///   bit == 0  -> walkable
    /// For yunzhongzhen1_a: W = 272, H = 320, file size = 10888 B
    ///   (8-byte header + 10880 bytes of bitmask).
    ///
    /// World mapping: the cell grid is an affine mapping of world space,
    /// parameterized by <see cref="WorldOrigin"/> + <see cref="CellSize"/>
    /// (+ an optional Y-flip since file row 0 is typically the TOP row
    /// while world Y increases upward). These are tunable in the Inspector
    /// and calibrated visually against the scene by
    /// <c>MapObstacleDebugGizmo</c>.
    ///
    /// Source of truth: the original client's
    /// <c>NavigationModule_AStar._MapData</c> is a <c>bool[,]</c> of the
    /// same shape (see DeepExtract stub); we just expose it via a
    /// component so the scene can be wired without reflection.
    /// </summary>
    public class MapObstacleGrid : MonoBehaviour
    {
        // ---------- data source ----------

        [Header("Data source")]
        [Tooltip("If assigned, read bytes from this TextAsset. If null, " +
                 "falls back to Application.dataPath/<FallbackPath>.")]
        [SerializeField] TextAsset _obstacleBytes;

        [Tooltip("Relative path under Assets/ used only when _obstacleBytes is null. " +
                 "Handy during calibration before the scene reference is wired up.")]
        [SerializeField] string _fallbackPath = "Maps/yunzhongzhen1_a/obstacle.bytes";

        // ---------- calibration (world <-> cell mapping) ----------

        [Header("Calibration")]
        [Tooltip("World-space position of the bottom-left corner of cell (cx=0, cy=H-1 when FlipY). " +
                 "Iterate in the editor until the red gizmo overlay aligns with buildings.")]
        public Vector2 WorldOrigin = new Vector2(0f, 0f);

        [Tooltip("World-space size of ONE cell (x = cellWidth, y = cellHeight). " +
                 "Default seed is an educated guess; calibrate visually.")]
        public Vector2 CellSize = new Vector2(0.3f, 0.15f);

        [Tooltip("When true, file row 0 is the TOP of the map (cy=0 -> topmost world row). " +
                 "Most raster formats store this way, so leave enabled unless calibration proves otherwise.")]
        public bool FlipY = true;

        // ---------- runtime state ----------

        public int W { get; private set; }
        public int H { get; private set; }
        public bool[,] Walkable { get; private set; }
        public bool Loaded { get; private set; }

        // Lazy singleton. A naive `static MapObstacleGrid Instance` backed by
        // Awake() is NOT robust to Unity's domain reload during play mode
        // (edit-while-playing triggers a C# reload which nulls static fields
        // AND wipes non-SerializeField instance fields — including our
        // Walkable/Loaded/W/H state — but does NOT re-run Awake on the
        // already-alive scene object). The getter here self-heals by:
        //   1. Re-finding the grid if `_instance` is stale (domain reload
        //      nulled the static).
        //   2. Calling EnsureLoaded() EVERY time `Loaded==false`, even if
        //      `_instance` is a cached reference to a still-alive grid
        //      whose non-serialized state was wiped by hot reload.
        // Without point 2, a second caller after hot reload would get a
        // cached `_instance` with `Walkable==null` and fail downstream.
        static MapObstacleGrid _instance;
        public static MapObstacleGrid Instance
        {
            get
            {
                if (_instance == null)
                {
                    // Include inactive in case the holder GO got disabled by
                    // some scene tooling step.
                    _instance = UnityEngine.Object.FindObjectOfType<MapObstacleGrid>(includeInactive: true);
                }
                // Self-heal on every get — cheap (bool check + early-out
                // inside EnsureLoaded when already loaded).
                if (_instance != null && (!_instance.Loaded || _instance.Walkable == null))
                    _instance.EnsureLoaded();
                return _instance;
            }
        }

        void Awake()
        {
            Debug.Log($"[MapObstacleGrid] Awake on GO='{gameObject.name}' scene='{gameObject.scene.name}' isPlaying={Application.isPlaying}");
            _instance = this;
            EnsureLoaded();
        }

        /// <summary>
        /// Idempotent load. Safe to call multiple times (editor gizmo may
        /// hit this before Awake has run).
        /// </summary>
        public void EnsureLoaded()
        {
            if (Loaded && Walkable != null) return;
            Load();
        }

        public void Load()
        {
            byte[] data = null;
            string source = null;

            if (_obstacleBytes != null)
            {
                data = _obstacleBytes.bytes;
                source = $"TextAsset '{_obstacleBytes.name}'";
            }
            else
            {
                string full = Path.Combine(Application.dataPath, _fallbackPath);
                if (File.Exists(full))
                {
                    data = File.ReadAllBytes(full);
                    source = full;
                }
            }

            if (data == null || data.Length < 8)
            {
                Debug.LogError($"[MapObstacleGrid] could not load obstacle data (source tried: {source ?? "(none)"})");
                return;
            }

            int w = BitConverter.ToInt32(data, 0);
            int h = BitConverter.ToInt32(data, 4);
            int expectedBits = w * h;
            int expectedBytes = (expectedBits + 7) / 8;
            if (expectedBytes != data.Length - 8)
            {
                Debug.LogError(
                    $"[MapObstacleGrid] header mismatch at {source}: " +
                    $"W={w} H={h} expects {expectedBytes} bytes but body is {data.Length - 8}");
                return;
            }

            W = w;
            H = h;
            Walkable = new bool[W, H];

            // row-major, MSB-first (verified visually in Phase 6.1)
            for (int y = 0; y < H; y++)
            {
                for (int x = 0; x < W; x++)
                {
                    int idx = y * W + x;
                    int b = data[8 + idx / 8];
                    int bit = (b >> (7 - (idx % 8))) & 1;
                    Walkable[x, y] = (bit == 0); // 1 = blocked, 0 = walkable
                }
            }

            Loaded = true;
            Debug.Log($"[MapObstacleGrid] loaded W={W} H={H} from {source} " +
                      $"({data.Length} bytes total)");
        }

        // ---------- queries ----------

        public bool IsWalkableCell(int cx, int cy)
        {
            if (!Loaded || Walkable == null) return true; // fail-open until loaded
            if (cx < 0 || cy < 0 || cx >= W || cy >= H) return false;
            return Walkable[cx, cy];
        }

        public bool IsWalkableWorld(Vector2 worldPos)
        {
            if (!WorldToCell(worldPos, out int cx, out int cy)) return false;
            return IsWalkableCell(cx, cy);
        }

        /// <summary>
        /// Matches the original client's API exactly:
        ///     bool NavigationModule.IsLogicPointObstacle(int nLogicX, int nLogicY)
        /// (see <c>03_HUD_Main/CSharp/NavigationModule.cs:153</c> and the
        /// XLua binding <c>NavigationModuleWrap._m_IsLogicPointObstacle_xlua_st_</c>.)
        ///
        /// Returns <c>true</c> if the point is BLOCKED, <c>false</c> if walkable —
        /// note the inverse of <see cref="IsWalkableWorld"/>.
        ///
        /// Coordinates are in LOGIC units in Unity world space (i.e.
        /// <c>logicX = worldX / Env.LOGIC_POS_CELL</c>, see <see cref="Env.World2Logic"/>).
        /// The map's <see cref="WorldOrigin"/> offset is applied inside
        /// <see cref="WorldToCell"/>, so callers do NOT need to subtract it.
        /// </summary>
        public bool IsLogicPointObstacle(int nLogicX, int nLogicY)
        {
            float wx = nLogicX * Env.LOGIC_POS_CELL;
            float wy = nLogicY * Env.LOGIC_POS_CELL;
            return !IsWalkableWorld(new Vector2(wx, wy));
        }

        /// <summary>
        /// World -> cell mapping. Returns false if the point falls outside
        /// the grid (caller should treat that as "blocked").
        /// </summary>
        public bool WorldToCell(Vector2 worldPos, out int cx, out int cy)
        {
            float localX = (worldPos.x - WorldOrigin.x) / CellSize.x;
            float localY = (worldPos.y - WorldOrigin.y) / CellSize.y;
            cx = Mathf.FloorToInt(localX);
            int rowFromBottom = Mathf.FloorToInt(localY);
            cy = FlipY ? (H - 1 - rowFromBottom) : rowFromBottom;
            return cx >= 0 && cy >= 0 && cx < W && cy < H;
        }

        /// <summary>
        /// Cell -> world center. Always returns the center of the cell
        /// (i.e. adds +0.5 on both axes) so the gizmo doesn't land on edges.
        /// </summary>
        public Vector2 CellToWorld(int cx, int cy)
        {
            int rowFromBottom = FlipY ? (H - 1 - cy) : cy;
            return new Vector2(
                WorldOrigin.x + (cx + 0.5f) * CellSize.x,
                WorldOrigin.y + (rowFromBottom + 0.5f) * CellSize.y);
        }
    }
}
