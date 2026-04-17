using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;
using UnityEditor;

public static class DebugMapState
{
    public static void Execute()
    {
        var cam = GameObject.Find("SceneCamera").GetComponent<Camera>();
        cam.transform.position = new Vector3(43.36f, 25.76f, -100f);
        cam.orthographicSize = 30f;
        Debug.Log($"[FrameMap] SceneCamera moved to {cam.transform.position} size={cam.orthographicSize}");
    }

    public static void Restore()
    {
        var cam = GameObject.Find("SceneCamera").GetComponent<Camera>();
        cam.transform.position = new Vector3(0, 0, -100f);
        cam.orthographicSize = 2.8f;
        Debug.Log("[FrameMap] SceneCamera restored");
    }
}
