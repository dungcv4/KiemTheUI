using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public static class InspectFireEffect
{
    public static void Execute()
    {
        var prefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefabs/Imported/UICreateRole.prefab");
        Transform fire = null;
        foreach (var t in prefab.GetComponentsInChildren<Transform>(true))
            if (t.name == "Fire_Effect" && t.parent != null && t.parent.name == "Faction") { fire = t; break; }
        if (fire == null) { Debug.LogError("[Fire] not found"); return; }
        Walk(fire, 0);
    }

    static void Walk(Transform t, int depth)
    {
        var pad = new string(' ', depth * 2);
        var comps = t.GetComponents<Component>();
        var sb = new System.Text.StringBuilder();
        sb.Append(pad).Append(t.gameObject.activeSelf ? "*" : "-").Append(t.name);
        foreach (var c in comps)
        {
            if (c == null) { sb.Append(" (null)"); continue; }
            var n = c.GetType().Name;
            if (n == "RectTransform" || n == "CanvasRenderer") continue;
            sb.Append(" [").Append(n);
            if (c is Image img && img.sprite == null) sb.Append("?null");
            if (c is Outline ol) sb.Append("=").Append(ol.effectColor);
            if (c is Shadow sh) sb.Append("=").Append(sh.effectColor);
            sb.Append("]");
        }
        Debug.Log("[Fire] " + sb);
        foreach (Transform c in t) Walk(c, depth + 1);
    }
}
