using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public static class InspectDropdown
{
    public static void Execute()
    {
        Debug.Log("[Drop] start");
        var contents = PrefabUtility.LoadPrefabContents("Assets/Prefabs/Imported/UICreateRole.prefab");
        if (contents == null) { Debug.LogError("[Drop] no contents"); return; }
        Debug.Log("[Drop] loaded contents");
        var sel = contents.transform.Find("imgBG/SelectSeries");
        if (sel == null) { Debug.LogError("[Drop] no SelectSeries"); PrefabUtility.UnloadPrefabContents(contents); return; }
        Debug.Log("[Drop] found SelectSeries, walking...");
        Walk(sel, 0);
        PrefabUtility.UnloadPrefabContents(contents);
        Debug.Log("[Drop] done");
    }
    static void Walk(Transform t, int d)
    {
        var pad = new string(' ', d * 2);
        var sb = new System.Text.StringBuilder();
        sb.Append(pad).Append(t.gameObject.activeSelf ? "*" : "-").Append(t.name);
        var rt = t.GetComponent<RectTransform>();
        if (rt != null)
            sb.Append($" pos={rt.anchoredPosition} size={rt.sizeDelta} pivot={rt.pivot}");
        foreach (var c in t.GetComponents<Component>())
        {
            if (c == null) continue;
            var n = c.GetType().Name;
            if (n == "RectTransform" || n == "CanvasRenderer") continue;
            sb.Append(" [").Append(n);
            if (c is Image img) sb.Append($"=sprite:{(img.sprite!=null?img.sprite.name:"NULL")} a:{img.color.a:F2}");
            if (c is Text txt) sb.Append($"='{txt.text}' fs:{txt.fontSize}");
            sb.Append("]");
        }
        Debug.Log("[Drop] " + sb);
        foreach (Transform c in t) Walk(c, d + 1);
    }
}
