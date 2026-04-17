using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

public static class BumpPlayerOrder
{
    public static void Execute()
    {
        var go = GameObject.Find("Player_ma_000a_free");
        if (go == null) { Debug.LogError("Player not found"); return; }
        var sg = go.GetComponent<SortingGroup>();
        if (sg == null) { Debug.LogError("No SortingGroup"); return; }
        sg.sortingOrder = 1000;
        Debug.Log($"[BumpPlayerOrder] SortingGroup.sortingOrder -> {sg.sortingOrder}");

        // Also check URP transparency sort mode
        var cam = GameObject.Find("SceneCamera")?.GetComponent<Camera>();
        if (cam != null)
            Debug.Log($"[BumpPlayerOrder] SceneCamera transparencySortMode={cam.transparencySortMode} sortAxis={cam.transparencySortAxis}");
    }
}
