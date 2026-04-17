using UnityEngine;
using KTO.Game;

public static class InspectRuntimePlayer
{
    // Dumps the current runtime state of the player and the obstacle grid,
    // whether running in play mode or edit mode.
    public static void Execute()
    {
        Debug.Log($"[InspectRuntimePlayer] Application.isPlaying={Application.isPlaying}");

        // Walk every scene for a Player object
        var all = Object.FindObjectsOfType<PlayerAssembler>();
        Debug.Log($"[InspectRuntimePlayer] PlayerAssembler count: {all.Length}");
        foreach (var pa in all)
        {
            var go = pa.gameObject;
            var motor = go.GetComponent<PlayerMotor>();
            var input = go.GetComponent<PlayerInputController>();
            Debug.Log($"[InspectRuntimePlayer] {go.name} pos={go.transform.position}  " +
                      $"motor?{motor != null}  input?{input != null}");
        }

        // Obstacle grid
        var grid = MapObstacleGrid.Instance;
        if (grid == null)
        {
            var holder = GameObject.Find("yunzhongzhen1_a/Runtime Layer/MapObstacleGrid");
            if (holder != null) grid = holder.GetComponent<MapObstacleGrid>();
        }
        if (grid != null)
        {
            Debug.Log($"[InspectRuntimePlayer] grid.Loaded={grid.Loaded}  W={grid.W}  H={grid.H}  " +
                      $"origin=({grid.WorldOrigin.x:F3},{grid.WorldOrigin.y:F3})  " +
                      $"cellSize=({grid.CellSize.x:F4},{grid.CellSize.y:F4})  " +
                      $"flipY={grid.FlipY}");
        }
        else
        {
            Debug.Log("[InspectRuntimePlayer] grid: not found in scene");
        }

        // List all top-level loaded scenes
        for (int i = 0; i < UnityEngine.SceneManagement.SceneManager.sceneCount; i++)
        {
            var s = UnityEngine.SceneManagement.SceneManager.GetSceneAt(i);
            Debug.Log($"[InspectRuntimePlayer] loaded scene {i}: {s.name}  (path={s.path})");
        }
    }
}
