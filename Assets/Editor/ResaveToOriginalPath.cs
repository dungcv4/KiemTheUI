using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

public static class ResaveToOriginalPath
{
    public static void Execute()
    {
        // If yunzhongzhen1_a.unity got saved into Assets/ instead of Assets/Maps/yunzhongzhen1_a/,
        // re-save it to the original path via EditorSceneManager.SaveScene(scene, path).
        var current = EditorSceneManager.GetActiveScene();
        Debug.Log($"[ResaveToOriginalPath] active scene: name={current.name} path={current.path}");
        const string targetPath = "Assets/Maps/yunzhongzhen1_a/yunzhongzhen1_a.unity";
        bool ok = EditorSceneManager.SaveScene(current, targetPath);
        Debug.Log($"[ResaveToOriginalPath] SaveScene to '{targetPath}' ok={ok}");
    }
}
