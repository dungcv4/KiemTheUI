using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using KTO.Game;

public static class AttachMapObstacleGrid
{
    // Seed values derived from:
    //   - Ground TileMap worldBounds (-0.14, -0.14) .. (86.86, 51.66)
    //   - obstacle.bytes = 272 x 320 cells (verified Phase 6.1)
    //   - 2:1 isometric aspect (cell Y half of cell X)
    const float SeedOriginX   = -0.14f;
    const float SeedOriginY   = -0.14f;
    const float SeedCellSizeX = 87.00f / 272f;   // = 0.31985
    const float SeedCellSizeY = 51.80f / 320f;   // = 0.16188

    const string HolderName = "MapObstacleGrid";
    const string ParentPath = "yunzhongzhen1_a/Runtime Layer";

    public static void Execute()
    {
        // Find parent. Prefer Runtime Layer so the grid lives alongside other
        // dynamic data and isn't baked into the static persistent layer.
        var parent = GameObject.Find(ParentPath);
        if (parent == null)
        {
            // fall back to the scene root
            parent = GameObject.Find("yunzhongzhen1_a");
            if (parent == null)
            {
                Debug.LogError("[AttachMapObstacleGrid] map root not found");
                return;
            }
            Debug.LogWarning($"[AttachMapObstacleGrid] '{ParentPath}' not found, attaching to scene root");
        }

        // Locate or create holder
        var existing = parent.transform.Find(HolderName);
        GameObject holder;
        if (existing != null)
        {
            holder = existing.gameObject;
            Debug.Log($"[AttachMapObstacleGrid] reusing existing holder {HolderName}");
        }
        else
        {
            holder = new GameObject(HolderName);
            holder.transform.SetParent(parent.transform, worldPositionStays: true);
            holder.transform.localPosition = Vector3.zero;
            Debug.Log($"[AttachMapObstacleGrid] created new holder under {parent.name}");
        }

        // Attach grid component
        var grid = holder.GetComponent<MapObstacleGrid>();
        if (grid == null) grid = holder.AddComponent<MapObstacleGrid>();
        grid.WorldOrigin = new Vector2(SeedOriginX, SeedOriginY);
        grid.CellSize    = new Vector2(SeedCellSizeX, SeedCellSizeY);
        grid.FlipY       = true;

        // Wire up the TextAsset reference so runtime load doesn't depend on Application.dataPath
        var ta = AssetDatabase.LoadAssetAtPath<TextAsset>(
            "Assets/Maps/yunzhongzhen1_a/obstacle.bytes");
        if (ta != null)
        {
            var so = new SerializedObject(grid);
            so.FindProperty("_obstacleBytes").objectReferenceValue = ta;
            so.ApplyModifiedProperties();
            Debug.Log($"[AttachMapObstacleGrid] wired TextAsset reference: {ta.name}");
        }
        else
        {
            Debug.LogWarning("[AttachMapObstacleGrid] obstacle.bytes TextAsset not found; will use Application.dataPath fallback at runtime");
        }

        grid.Load();

        // Attach debug gizmo
        var gizmo = holder.GetComponent<MapObstacleDebugGizmo>();
        if (gizmo == null) gizmo = holder.AddComponent<MapObstacleDebugGizmo>();
        gizmo.Draw = true;
        gizmo.DrawOnlyEdges = true;
        gizmo.CellStride = 1;
        gizmo.DrawGridOutline = true;

        EditorUtility.SetDirty(holder);
        EditorSceneManager.MarkSceneDirty(holder.scene);

        Debug.Log($"[AttachMapObstacleGrid] DONE. Grid: W={grid.W} H={grid.H}  " +
                  $"origin=({grid.WorldOrigin.x:F3},{grid.WorldOrigin.y:F3})  " +
                  $"cellSize=({grid.CellSize.x:F4},{grid.CellSize.y:F4})  flipY={grid.FlipY}  " +
                  $"loaded={grid.Loaded}");
    }
}
