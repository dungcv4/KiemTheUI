using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class CheckSortLayers
{
    public static void Execute()
    {
        // Dump sort layer registry
        foreach (var l in SortingLayer.layers)
            Debug.Log($"[Layer] id={l.id} value={l.value} name='{l.name}' default={l.name=="Default"}");

        // Sample map sprite renderers near player (43.36, 25.76)
        var map = GameObject.Find("yunzhongzhen1_a");
        if (map == null) { Debug.LogWarning("Map not loaded"); return; }
        var counts = new System.Collections.Generic.Dictionary<string, int>();
        var orderHist = new System.Collections.Generic.Dictionary<int, int>();
        int nearPlayer = 0;
        foreach (var sr in map.GetComponentsInChildren<SpriteRenderer>(true))
        {
            var key = $"{sr.sortingLayerName}";
            counts[key] = counts.TryGetValue(key, out var c) ? c+1 : 1;
            orderHist[sr.sortingOrder] = orderHist.TryGetValue(sr.sortingOrder, out var o) ? o+1 : 1;
            var d = sr.transform.position - new Vector3(43.36f, 25.76f, 0);
            if (d.sqrMagnitude < 1f) nearPlayer++;
        }
        Debug.Log($"[Layer] map SpriteRenderers near (43.36,25.76) within 1u: {nearPlayer}");
        foreach (var kv in counts)  Debug.Log($"[Layer]  sortingLayer='{kv.Key}' count={kv.Value}");
        var orders = new System.Collections.Generic.List<int>(orderHist.Keys);
        orders.Sort();
        foreach (var o in orders) Debug.Log($"[Layer]  sortingOrder={o} count={orderHist[o]}");
    }
}
