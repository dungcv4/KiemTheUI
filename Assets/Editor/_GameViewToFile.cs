using UnityEngine;
using UnityEditor;
using System.IO;
using System.Text;

// Captures the GameView via Camera.targetTexture render so it works in
// PlayMode and writes the result to Assets/_GameView.png. The Coplay
// capture_ui_canvas tool returns black during playmode; this works.
public static class _GameViewToFile
{
    public static string Execute()
    {
        var sb = new StringBuilder();
        var cam = Camera.main;
        if (cam == null) { sb.AppendLine("Camera.main NULL"); Debug.Log(sb.ToString()); return sb.ToString(); }

        int w = 1280, h = 720;
        var rt = new RenderTexture(w, h, 24, RenderTextureFormat.ARGB32);
        var prev = cam.targetTexture;
        var prevActive = RenderTexture.active;
        cam.targetTexture = rt;
        cam.Render();
        RenderTexture.active = rt;
        var tex = new Texture2D(w, h, TextureFormat.RGBA32, false);
        tex.ReadPixels(new Rect(0, 0, w, h), 0, 0);
        tex.Apply();
        cam.targetTexture = prev;
        RenderTexture.active = prevActive;
        Object.DestroyImmediate(rt);

        var bytes = tex.EncodeToPNG();
        Object.DestroyImmediate(tex);
        var path = "Assets/_GameView.png";
        File.WriteAllBytes(path, bytes);
        AssetDatabase.ImportAsset(path);
        sb.AppendLine($"Wrote {path} ({bytes.Length} bytes)");
        Debug.Log(sb.ToString());
        return sb.ToString();
    }
}
