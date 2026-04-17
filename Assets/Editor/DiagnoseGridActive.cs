using UnityEngine;
using KTO.Game;

public static class DiagnoseGridActive
{
    // Diagnose why MapObstacleGrid.Instance is null even though the component
    // exists in a loaded scene. Checks activeSelf / activeInHierarchy /
    // parent chain + whether Awake has been called.
    public static void Execute()
    {
        var all = Object.FindObjectsOfType<MapObstacleGrid>(includeInactive: true);
        Debug.Log($"[DiagActive] found {all.Length} grid(s) (includeInactive)");
        foreach (var g in all)
        {
            var go = g.gameObject;
            Debug.Log($"[DiagActive] name={go.name}  activeSelf={go.activeSelf}  " +
                      $"activeInHierarchy={go.activeInHierarchy}  enabled={g.enabled}  " +
                      $"scene.isLoaded={go.scene.isLoaded}  scene.name={go.scene.name}  " +
                      $"loaded={g.Loaded}  W={g.W}");

            // Walk parent chain
            var t = go.transform;
            while (t != null)
            {
                Debug.Log($"[DiagActive]   parent={t.name}  activeSelf={t.gameObject.activeSelf}");
                t = t.parent;
            }
        }

        // Attempt to force-init: manually set Instance if null and the
        // grid is loaded. Pure diagnostic — we still need to find the root
        // cause, but this lets me confirm whether fixing Instance makes
        // PlayerMotor respect walls.
        if (MapObstacleGrid.Instance == null && all.Length > 0)
        {
            var inst = all[0];
            // Use reflection because the setter is private
            var prop = typeof(MapObstacleGrid).GetProperty(
                "Instance", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
            if (prop != null && prop.CanWrite)
            {
                prop.SetValue(null, inst);
                Debug.Log($"[DiagActive] FORCE-SET MapObstacleGrid.Instance = {inst.name}");
            }
            else
            {
                // Try via the backing field
                var field = typeof(MapObstacleGrid).GetField("<Instance>k__BackingField",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
                if (field != null)
                {
                    field.SetValue(null, inst);
                    Debug.Log($"[DiagActive] FORCE-SET via backing field = {inst.name}");
                }
                else
                {
                    Debug.LogError("[DiagActive] could not find Instance property or backing field");
                }
            }
            Debug.Log($"[DiagActive] after force: Instance is null? = {MapObstacleGrid.Instance == null}");
        }
    }
}
