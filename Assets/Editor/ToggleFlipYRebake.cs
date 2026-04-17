using UnityEditor;
using UnityEngine;
using KTO.Game;

public static class ToggleFlipYRebake
{
    // Flip the FlipY flag on MapObstacleGrid, re-bake the overlay PNG, and
    // log the new state. Used to A/B test which raster convention the
    // obstacle.bytes file uses.
    public static void Execute()
    {
        var holder = GameObject.Find("yunzhongzhen1_a/Runtime Layer/MapObstacleGrid");
        if (holder == null) { Debug.LogError("[ToggleFlipYRebake] holder missing"); return; }
        var grid = holder.GetComponent<MapObstacleGrid>();
        if (grid == null) { Debug.LogError("[ToggleFlipYRebake] grid component missing"); return; }

        grid.FlipY = !grid.FlipY;
        Debug.Log($"[ToggleFlipYRebake] FlipY now = {grid.FlipY}");
        EditorUtility.SetDirty(grid);
        UnityEditor.SceneManagement.EditorSceneManager.MarkSceneDirty(holder.scene);

        // Rebake + recapture
        BakeObstacleOverlay.Execute();
        CaptureMapTopDown.Execute();
    }
}
