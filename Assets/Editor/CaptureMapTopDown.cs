using System.IO;
using UnityEditor;
using UnityEngine;

public static class CaptureMapTopDown
{
    // Captures a clean top-down orthographic screenshot of yunzhongzhen1_a
    // so we can visually calibrate MapObstacleGrid/ObstacleOverlay against
    // the rendered buildings.
    //
    // Writes:
    //   /tmp/map_topdown_full.png   — full map at ~1440x864
    //   /tmp/map_topdown_zoom.png   — close-up on the town at ~1024x768
    public static void Execute()
    {
        // Map extent: (-0.14, -0.14) .. (86.86, 51.66)  (from Ground TileMap)
        // Center + half-extent:
        Vector3 center = new Vector3(43.36f, 25.76f, -100f);
        float halfW = 44f;    // a hair more than 87/2 = 43.5 so we see the edges
        float halfH = 27f;    // a hair more than 51.8/2 = 25.9

        int fullW = 1440, fullH = (int)(fullW * (halfH / halfW));
        Shot("/tmp/map_topdown_full.png", center, halfH, fullW, fullH);

        // Zoomed capture on the town center
        Vector3 zoomCenter = new Vector3(43.36f, 25.76f, -100f);
        float zoomHalf = 12f;
        int zoomW = 1024, zoomH = 768;
        Shot("/tmp/map_topdown_zoom.png", zoomCenter, zoomHalf, zoomW, zoomH);

        Debug.Log("[CaptureMapTopDown] wrote /tmp/map_topdown_full.png and /tmp/map_topdown_zoom.png");
    }

    static void Shot(string path, Vector3 pos, float orthoHalfHeight, int w, int h)
    {
        var camGo = new GameObject("__CalibCaptureCam");
        camGo.transform.position = pos;
        var cam = camGo.AddComponent<Camera>();
        cam.orthographic = true;
        cam.orthographicSize = orthoHalfHeight;
        cam.aspect = (float)w / h;
        cam.clearFlags = CameraClearFlags.SolidColor;
        cam.backgroundColor = new Color(0.12f, 0.12f, 0.15f, 1f);
        cam.cullingMask = ~0;
        cam.nearClipPlane = 0.01f;
        cam.farClipPlane = 200f;

        var rt = new RenderTexture(w, h, 24);
        cam.targetTexture = rt;
        RenderTexture.active = rt;
        GL.Flush();
        cam.Render();
        var tex = new Texture2D(w, h, TextureFormat.RGB24, false);
        tex.ReadPixels(new Rect(0, 0, w, h), 0, 0);
        tex.Apply();
        cam.targetTexture = null;
        RenderTexture.active = null;
        File.WriteAllBytes(path, tex.EncodeToPNG());
        Object.DestroyImmediate(tex);
        Object.DestroyImmediate(rt);
        Object.DestroyImmediate(camGo);
    }
}
