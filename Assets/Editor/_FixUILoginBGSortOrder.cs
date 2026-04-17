using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEditor.SceneManagement;
using System.Text;

// Fixes character invisibility in CreateRoleScene by correcting canvas
// sorting orders for UILoginBG and its Character sub-canvas.
//
// Current (broken):
//   Background_Canvas: order=0
//   UILoginBG: order=-1               ← UNDER background, content invisible
//     └ Character: order=1, overrideSorting=false  ← inherits parent -1
//   UISelectRoleExist_Canvas: order=10
//
// Fixed:
//   Background_Canvas: order=0
//   UILoginBG: order=1                ← ABOVE background
//     └ Character: order=8, overrideSorting=true   ← own sort, between bg and UI panel
//   UISelectRoleExist_Canvas: order=10
//
// This matches what LoginSceneController.ShowSelectRole intends but couldn't
// achieve because Character.overrideSorting was false (the foreach skipped it).
public static class _FixUILoginBGSortOrder
{
    public static string Execute()
    {
        var sb = new StringBuilder();
        var scene = EditorSceneManager.GetActiveScene();
        sb.AppendLine($"=== FixUILoginBGSortOrder on {scene.path} ===");

        // Find UILoginBG (root level)
        GameObject bg = null;
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
        {
            if (t.name == "UILoginBG" && t.parent == null) { bg = t.gameObject; break; }
        }
        if (bg == null) { sb.AppendLine("UILoginBG NOT FOUND"); Debug.Log(sb.ToString()); return sb.ToString(); }

        // Set UILoginBG canvas sortingOrder = 1
        var bgCanvas = bg.GetComponent<Canvas>();
        if (bgCanvas != null)
        {
            sb.AppendLine($"UILoginBG canvas sortingOrder: {bgCanvas.sortingOrder} → 1");
            bgCanvas.sortingOrder = 1;
            EditorUtility.SetDirty(bgCanvas);
        }

        // Find Character sub-canvas, set overrideSorting=true + sortOrder=8
        var charT = bg.transform.Find("Character");
        if (charT != null)
        {
            var charCanvas = charT.GetComponent<Canvas>();
            if (charCanvas != null)
            {
                sb.AppendLine($"Character canvas overrideSorting: {charCanvas.overrideSorting} → true, sortingOrder: {charCanvas.sortingOrder} → 8");
                charCanvas.overrideSorting = true;
                charCanvas.sortingOrder = 8;
                EditorUtility.SetDirty(charCanvas);
            }
        }

        // Save
        EditorSceneManager.MarkSceneDirty(scene);
        EditorSceneManager.SaveScene(scene);
        sb.AppendLine("Saved scene");

        Debug.Log(sb.ToString());
        return sb.ToString();
    }
}
