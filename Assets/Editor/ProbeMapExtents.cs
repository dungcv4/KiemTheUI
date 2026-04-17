using UnityEditor;
using UnityEngine;

public static class ProbeMapExtents
{
    public static void Execute()
    {
        // Find all SpriteRenderers under the yunzhongzhen root
        var rootGo = GameObject.Find("yunzhongzhen1_a");
        if (rootGo == null)
        {
            // Try a few common names
            foreach (var n in new[] { "Map", "Scene", "map_root" })
            {
                rootGo = GameObject.Find(n);
                if (rootGo != null) break;
            }
        }
        if (rootGo == null)
        {
            Debug.LogWarning("[ProbeMap] map root not found — sampling ALL SpriteRenderers");
            rootGo = null;
        }

        var srs = rootGo != null
            ? rootGo.GetComponentsInChildren<SpriteRenderer>(true)
            : Object.FindObjectsOfType<SpriteRenderer>();

        Debug.Log($"[ProbeMap] SpriteRenderer count: {srs.Length}");
        if (srs.Length == 0) return;

        Bounds b = srs[0].bounds;
        foreach (var sr in srs) b.Encapsulate(sr.bounds);
        Debug.Log($"[ProbeMap] Aggregate bounds min={b.min} max={b.max} size={b.size}");

        var player = GameObject.Find("Player_ma_000a_free");
        if (player != null)
            Debug.Log($"[ProbeMap] Player transform: {player.transform.position}");

        var cam = GameObject.Find("SceneCamera");
        if (cam != null)
        {
            var c = cam.GetComponent<Camera>();
            if (c != null)
                Debug.Log($"[ProbeMap] SceneCamera ortho size={c.orthographicSize} aspect={c.aspect} pos={c.transform.position}");
        }
    }
}
