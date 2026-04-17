using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using System.Text;

public static class _PersistCharCanvasOrder5
{
    public static string Execute()
    {
        var sb = new StringBuilder();
        Transform charT = null;
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
        {
            if (t.name == "Character" && t.parent != null && t.parent.name == "UILoginBG") { charT = t; break; }
        }
        if (charT == null) { sb.AppendLine("Character NOT FOUND"); Debug.Log(sb.ToString()); return sb.ToString(); }

        var c = charT.GetComponent<Canvas>();
        if (c == null) { sb.AppendLine("Canvas NOT FOUND"); Debug.Log(sb.ToString()); return sb.ToString(); }

        c.enabled = true;
        c.overrideSorting = true;
        c.sortingLayerName = "UI";
        c.sortingOrder = 5;
        EditorUtility.SetDirty(c);

        var scene = EditorSceneManager.GetActiveScene();
        EditorSceneManager.MarkSceneDirty(scene);
        bool saved = EditorSceneManager.SaveScene(scene);
        sb.AppendLine($"enabled={c.enabled} override={c.overrideSorting} order={c.sortingOrder} saved={saved}");
        Debug.Log(sb.ToString());
        return sb.ToString();
    }
}
