using UnityEngine;
using UnityEditor;
using System.IO;
using System.Text;

// Captures the Game view via ScreenCapture.CaptureScreenshot, which renders
// exactly what the player would see (all canvases composited, including
// ScreenSpaceOverlay). Saves to a temp PNG so we can inspect the result.
public static class _GameViewScreenshot
{
    public static string Execute()
    {
        var sb = new StringBuilder();
        string outPath = "Temp/_GameView.png";

        // Make sure Game window is focused so screenshot picks the right resolution
        var gameView = EditorWindow.GetWindow(System.Type.GetType("UnityEditor.GameView,UnityEditor"));
        if (gameView != null) gameView.Focus();

        ScreenCapture.CaptureScreenshot(outPath);
        sb.AppendLine($"ScreenCapture.CaptureScreenshot → {outPath}");
        Debug.Log(sb.ToString());
        return sb.ToString();
    }
}
