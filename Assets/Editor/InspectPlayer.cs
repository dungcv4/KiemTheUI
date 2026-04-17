using UnityEngine;
using UnityEditor;
using System.IO;

public static class InspectPlayer
{
    public static void Execute()
    {
        var go = GameObject.Find("Player_ma_000a_free");
        if (go == null) { Debug.LogError("[InspectPlayer] Player GameObject not found"); return; }
        Debug.Log($"[InspectPlayer] Root: {go.name}  pos={go.transform.position}  active={go.activeInHierarchy}");
        foreach (Transform child in go.transform)
        {
            var sr = child.GetComponent<SpriteRenderer>();
            var sprName = sr != null && sr.sprite != null ? sr.sprite.name : "<null>";
            var bounds = sr != null ? sr.bounds : default;
            var sLayer = sr != null ? sr.sortingLayerName : "?";
            var sOrder = sr != null ? sr.sortingOrder : 0;
            Debug.Log($"  Child: {child.name}  sprite={sprName}  order={sOrder}/{sLayer}  bounds={bounds.size}  flipX={(sr!=null?sr.flipX:false)}");
        }
    }

    public static void CaptureGameView()
    {
        var cam = GameObject.Find("SceneCamera")?.GetComponent<Camera>();
        if (cam == null) { Debug.LogError("[InspectPlayer] SceneCamera not found"); return; }
        int w = 1024, h = 576;
        var rt = new RenderTexture(w, h, 24);
        cam.targetTexture = rt;
        RenderTexture.active = rt;
        cam.Render();
        var tex = new Texture2D(w, h, TextureFormat.RGB24, false);
        tex.ReadPixels(new Rect(0, 0, w, h), 0, 0);
        tex.Apply();
        cam.targetTexture = null;
        RenderTexture.active = null;
        var bytes = tex.EncodeToPNG();
        var path = "/tmp/player_checkpoint1.png";
        File.WriteAllBytes(path, bytes);
        Debug.Log($"[InspectPlayer] Saved game view to {path} (cam pos={cam.transform.position} orthoSize={cam.orthographicSize})");
        Object.DestroyImmediate(rt);
        Object.DestroyImmediate(tex);
    }
}
