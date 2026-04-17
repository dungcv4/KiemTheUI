using UnityEngine;
using UnityEngine.EventSystems;
using UnityEditor;
using UnityEditor.SceneManagement;
using System.Text;

// Fixes two issues with LoginScene that prevented clicks + background:
// 1. Adds EventSystem GameObject (StandaloneInputModule) — was missing
//    so no UI click ever propagated to buttons.
// 2. Renames root "BG_Canvas" → "Background_Canvas" so
//    LoginSceneController.Start() line 94 finds it via FindCanvasRoot.
public static class _FixLoginSceneRoots
{
    public static string Execute()
    {
        var sb = new StringBuilder();
        var scene = EditorSceneManager.GetActiveScene();
        sb.AppendLine($"=== FixLoginSceneRoots on {scene.path} ===");

        // 1. EventSystem
        var existingEs = Object.FindObjectOfType<EventSystem>(true);
        if (existingEs != null)
        {
            sb.AppendLine($"EventSystem already exists on {existingEs.gameObject.name}");
        }
        else
        {
            var esGo = new GameObject("EventSystem");
            esGo.AddComponent<EventSystem>();
            esGo.AddComponent<StandaloneInputModule>();
            sb.AppendLine("Created EventSystem + StandaloneInputModule");
        }

        // 2. Rename BG_Canvas → Background_Canvas
        var roots = scene.GetRootGameObjects();
        bool renamed = false;
        foreach (var r in roots)
        {
            if (r.name == "BG_Canvas")
            {
                r.name = "Background_Canvas";
                renamed = true;
                sb.AppendLine("Renamed root BG_Canvas → Background_Canvas");
                break;
            }
            if (r.name == "Background_Canvas")
            {
                sb.AppendLine("Background_Canvas already correctly named");
                renamed = true;
                break;
            }
        }
        if (!renamed) sb.AppendLine("WARNING: Neither BG_Canvas nor Background_Canvas root found");

        // 3. Save
        EditorSceneManager.MarkSceneDirty(scene);
        EditorSceneManager.SaveScene(scene);
        sb.AppendLine("Saved scene");

        // 4. Re-dump roots
        roots = scene.GetRootGameObjects();
        sb.AppendLine($"--- Scene roots ({roots.Length}) ---");
        for (int i = 0; i < roots.Length; i++)
        {
            var r = roots[i];
            sb.AppendLine($"  [{i}] {r.name} active={r.activeInHierarchy}");
        }

        Debug.Log(sb.ToString());
        return sb.ToString();
    }
}
