using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using System.Text;

// Restores UILoginBG/Character Canvas component to match the original
// RippedProject_APK/Assets/game/ui/views/UILoginBG.prefab values.
//
// Bug: scene file (CreateRoleScene.unity line 171614) has Canvas.m_Enabled=0
// which makes Character (and all child avatars including M_SL) invisible.
// Original prefab has m_Enabled=1, m_OverrideSorting=0, m_SortingOrder=1.
//
// The earlier _FixUILoginBGSortOrder.cs incorrectly set overrideSorting=true
// and sortingOrder=8 — but the original uses overrideSorting=false so the
// Character inherits everything from the parent UILoginBG canvas. We restore
// to original values.
public static class _RestoreCharacterCanvas
{
    public static string Execute()
    {
        var sb = new StringBuilder();
        var scene = EditorSceneManager.GetActiveScene();
        sb.AppendLine($"=== RestoreCharacterCanvas on {scene.path} ===");

        // Find UILoginBG (root level)
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

        sb.AppendLine($"BEFORE: enabled={charCanvas.enabled} renderMode={charCanvas.renderMode} override={charCanvas.overrideSorting} order={charCanvas.sortingOrder}");

        // Match original prefab values
        charCanvas.enabled = true;                       // m_Enabled: 1
        charCanvas.overrideSorting = false;              // m_OverrideSorting: 0
        charCanvas.sortingOrder = 1;                     // m_SortingOrder: 1
        charCanvas.sortingLayerName = "UI";              // m_SortingLayerID: 194136777
        EditorUtility.SetDirty(charCanvas);

        sb.AppendLine($"AFTER:  enabled={charCanvas.enabled} renderMode={charCanvas.renderMode} override={charCanvas.overrideSorting} order={charCanvas.sortingOrder}");

        // Save scene
        EditorSceneManager.MarkSceneDirty(scene);
        EditorSceneManager.SaveScene(scene);
        sb.AppendLine("Saved scene");

        Debug.Log(sb.ToString());
        return sb.ToString();
    }
}
