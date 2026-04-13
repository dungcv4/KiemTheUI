using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

public static class ProbeScene
{
    public static void Execute()
    {
        var scene = EditorSceneManager.GetActiveScene();
        Debug.Log($"[Probe] Active scene: {scene.path}");
        foreach (var root in scene.GetRootGameObjects())
            Walk(root.transform, 0);
    }

    static void Walk(Transform t, int depth)
    {
        if (depth > 4) return;
        var pad = new string(' ', depth * 2);
        var canvas = t.GetComponent<Canvas>();
        Debug.Log($"[Probe] {pad}{t.name}{(canvas != null ? "  [Canvas]" : "")}");
        for (int i = 0; i < t.childCount; i++) Walk(t.GetChild(i), depth + 1);
    }
}
