using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using System.Text;

public static class _DumpSceneRoots
{
    public static string Execute()
    {
        var sb = new StringBuilder();
        var scene = EditorSceneManager.GetActiveScene();
        sb.AppendLine($"=== Scene: {scene.path} ===");
        sb.AppendLine($"isLoaded={scene.isLoaded} rootCount={scene.rootCount}");

        var roots = scene.GetRootGameObjects();
        for (int i = 0; i < roots.Length; i++)
        {
            var r = roots[i];
            var rt = r.transform as RectTransform;
            sb.AppendLine($"  [{i}] {r.name} active={r.activeInHierarchy} sceneInstanceID={r.GetInstanceID()} scale={r.transform.localScale} childCount={r.transform.childCount}");

            // Top-level children
            for (int j = 0; j < r.transform.childCount; j++)
            {
                var c = r.transform.GetChild(j);
                sb.AppendLine($"      → {c.name} active={c.gameObject.activeInHierarchy} scale={c.localScale}");
            }
        }

        Debug.Log(sb.ToString());
        return sb.ToString();
    }
}
