using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.UI;

public static class DiagHuoVfx
{
    public static string Execute()
    {
        if (Application.isPlaying) return "Stop play mode first";

        var sb = new System.Text.StringBuilder();
        int fixes = 0;

        // Fix UILoginBG CanvasScaler
        var lbg = GameObject.Find("UILoginBG");
        if (lbg != null)
        {
            var scaler = lbg.GetComponent<CanvasScaler>();
            if (scaler != null)
            {
                sb.AppendLine($"UILoginBG CanvasScaler: mode={scaler.screenMatchMode}, match={scaler.matchWidthOrHeight}");
                if (scaler.screenMatchMode != CanvasScaler.ScreenMatchMode.Expand)
                {
                    scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
                    scaler.matchWidthOrHeight = 0f;
                    EditorUtility.SetDirty(lbg);
                    fixes++;
                    sb.AppendLine("  => Fixed to Expand mode");
                }
            }
        }

        // Fix UICreateRole_Canvas CanvasScaler
        var crCanvas = GameObject.Find("UICreateRole_Canvas");
        if (crCanvas != null)
        {
            var scaler = crCanvas.GetComponent<CanvasScaler>();
            if (scaler != null)
            {
                sb.AppendLine($"UICreateRole_Canvas CanvasScaler: mode={scaler.screenMatchMode}, match={scaler.matchWidthOrHeight}");
                if (scaler.screenMatchMode != CanvasScaler.ScreenMatchMode.Expand)
                {
                    scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
                    scaler.matchWidthOrHeight = 0f;
                    EditorUtility.SetDirty(crCanvas);
                    fixes++;
                    sb.AppendLine("  => Fixed to Expand mode");
                }
            }
        }

        // Also fix the prefab
        string prefabPath = "Assets/game/ui/views/UILoginBG.prefab";
        var prefab = AssetDatabase.LoadAssetAtPath<GameObject>(prefabPath);
        if (prefab != null)
        {
            var instance = (GameObject)PrefabUtility.InstantiatePrefab(prefab);
            var scaler = instance.GetComponent<CanvasScaler>();
            if (scaler != null && scaler.screenMatchMode != CanvasScaler.ScreenMatchMode.Expand)
            {
                scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
                scaler.matchWidthOrHeight = 0f;
                PrefabUtility.ApplyPrefabInstance(instance, InteractionMode.AutomatedAction);
                fixes++;
                sb.AppendLine("UILoginBG prefab: Fixed to Expand mode");
            }
            Object.DestroyImmediate(instance);
        }

        if (fixes > 0)
        {
            EditorSceneManager.MarkSceneDirty(UnityEngine.SceneManagement.SceneManager.GetActiveScene());
            EditorSceneManager.SaveOpenScenes();
        }

        sb.AppendLine($"\nTotal fixes: {fixes}");
        return sb.ToString();
    }
}
