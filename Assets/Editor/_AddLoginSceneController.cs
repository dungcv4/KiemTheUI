using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using System.Text;

// Adds LoginSceneController to the active scene (LoginScene) so pressing Play
// triggers the full flow: SpawnLoginPanel → _DebugAutoLogin → LoginServer →
// auto-connect → ShowSelectRole.
//
// LoginSceneController is the master orchestrator that:
//   1. Auto-loads UILoginChannelInner / UILoginServer / UISelectServer prefabs
//   2. Subscribes to LoginManager state changes
//   3. Activates UILoginBG only on SelectRole/CreateRole states
//   4. Runs _DebugAutoLogin coroutine in Editor (testuser/12345678)
public static class _AddLoginSceneController
{
    public static string Execute()
    {
        var sb = new StringBuilder();
        var scene = EditorSceneManager.GetActiveScene();
        sb.AppendLine($"=== AddLoginSceneController on {scene.path} ===");

        // 1. Check if already present
        var existing = Object.FindObjectOfType<LoginSceneController>();
        if (existing != null)
        {
            sb.AppendLine($"LoginSceneController already exists on {existing.gameObject.name}");
        }
        else
        {
            var go = new GameObject("LoginSceneController");
            go.AddComponent<LoginSceneController>();
            sb.AppendLine($"Created LoginSceneController GameObject");
        }

        // 2. Save scene
        EditorSceneManager.MarkSceneDirty(scene);
        EditorSceneManager.SaveScene(scene);
        sb.AppendLine("Saved scene");

        // 3. Dump roots so we can verify the add worked
        var roots = scene.GetRootGameObjects();
        sb.AppendLine($"--- Scene roots ({roots.Length}) ---");
        for (int i = 0; i < roots.Length; i++)
        {
            var r = roots[i];
            sb.AppendLine($"  [{i}] {r.name} active={r.activeInHierarchy} childCount={r.transform.childCount}");
        }

        Debug.Log(sb.ToString());
        return sb.ToString();
    }
}
