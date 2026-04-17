using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using System.Text;

// Sets UILoginBG.localScale = (1,1,1) in the active scene.
// CreateRoleScene.unity had it at (0.15, 0.15, 0.15) which made
// the avatar spawned into UILoginBG/Character invisible (lossyScale=0.15).
// The original prefab is (0,0,0) but Lua Ui:CreateWindow runtime sets
// it to (1,1,1) — matching what PlaceSelectRoleScene.cs comment notes.
public static class _FixUILoginBGScale
{
    public static string Execute()
    {
        var sb = new StringBuilder();
        var scene = EditorSceneManager.GetActiveScene();
        sb.AppendLine($"=== FixUILoginBGScale on {scene.path} ===");

        var bg = GameObject.Find("UILoginBG");
        if (bg == null)
        {
            sb.AppendLine("UILoginBG NOT FOUND");
            Debug.Log(sb.ToString());
            return sb.ToString();
        }

        var oldScale = bg.transform.localScale;
        bg.transform.localScale = Vector3.one;
        sb.AppendLine($"UILoginBG localScale: {oldScale} → (1,1,1)");

        EditorSceneManager.MarkSceneDirty(scene);
        EditorSceneManager.SaveScene(scene);
        sb.AppendLine("Saved scene");

        Debug.Log(sb.ToString());
        return sb.ToString();
    }
}
