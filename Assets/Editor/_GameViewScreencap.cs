using UnityEngine;
using UnityEditor;
using System.IO;
using System.Collections;
using System.Text;

// Uses ScreenCapture.CaptureScreenshot which captures the actual GameView
// including GUI/Canvas passes. Camera.Render() may miss sub-canvas passes.
// Saves to Temp/_ScreenCap.png so we can compare with _GameViewToFile.cs.
public static class _GameViewScreencap
{
    public static string Execute()
    {
        var sb = new StringBuilder();
        var path = "Temp/_ScreenCap.png";
        if (File.Exists(path)) File.Delete(path);
        ScreenCapture.CaptureScreenshot(path);
        sb.AppendLine($"ScreenCapture.CaptureScreenshot → {path} (will write next frame)");
        Debug.Log(sb.ToString());
        return sb.ToString();
    }
}
