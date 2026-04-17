using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using System.Text;

// Persists the Character canvas fix to CreateRoleScene.unity:
//   m_Enabled: 1
//   m_OverrideSorting: 1  (true — needed because sub-canvas with override=false
//                          renders M_SL invisible due to canvas-merge ordering)
//   m_SortingOrder: 1
//   m_SortingLayerID: "UI"
//
// This matches what UICreateRoleAvatarController.EnsureCanvasSetup applies
// at runtime for the CreateRole flow. We persist it in the scene so the
// SelectRole flow also works without depending on that script running.
public static class _PersistCharacterCanvasFix
{
    public static string Execute()
    {
        var sb = new StringBuilder();
        var scene = EditorSceneManager.GetActiveScene();
        sb.AppendLine($"=== PersistCharacterCanvasFix on {scene.path} ===");

        GameObject bg = null;
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
        {
            if (t.name == "UILoginBG" && t.parent == null) { bg = t.gameObject; break; }
        }
        if (bg == null) { sb.AppendLine("UILoginBG NOT FOUND"); Debug.Log(sb.ToString()); return sb.ToString(); }

        var charT = bg.transform.Find("Character");
        if (charT == null) { sb.AppendLine("Character NOT FOUND"); Debug.Log(sb.ToString()); return sb.ToString(); }

        var charCanvas = charT.GetComponent<Canvas>();
        if (charCanvas == null) { sb.AppendLine("Character Canvas NOT FOUND"); Debug.Log(sb.ToString()); return sb.ToString(); }

        sb.AppendLine($"BEFORE: enabled={charCanvas.enabled} override={charCanvas.overrideSorting} order={charCanvas.sortingOrder} layer={charCanvas.sortingLayerName}");

        charCanvas.enabled = true;
        charCanvas.overrideSorting = true;
        charCanvas.sortingLayerName = "UI";
        charCanvas.sortingOrder = 1;
        EditorUtility.SetDirty(charCanvas);

        sb.AppendLine($"AFTER:  enabled={charCanvas.enabled} override={charCanvas.overrideSorting} order={charCanvas.sortingOrder} layer={charCanvas.sortingLayerName}");

        EditorSceneManager.MarkSceneDirty(scene);
        EditorSceneManager.SaveScene(scene);
        sb.AppendLine("Saved scene");

        Debug.Log(sb.ToString());
        return sb.ToString();
    }
}
