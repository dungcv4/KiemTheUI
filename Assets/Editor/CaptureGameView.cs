using UnityEngine;
public static class CaptureGameView { public static void Execute() { ScreenCapture.CaptureScreenshot(System.IO.Path.Combine(Application.dataPath, "../GameViewCapture.png")); } }
