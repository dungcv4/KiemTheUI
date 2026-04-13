using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public static class InspectBannerArea
{
    public static void Execute()
    {
        var prefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefabs/Imported/UICreateRole.prefab");
        Transform faction = null;
        foreach (var t in prefab.GetComponentsInChildren<Transform>(true))
            if (t.name == "Faction" && t.parent != null && t.parent.name == "FactionInfo") { faction = t; break; }
        if (faction == null) { Debug.LogError("[Banner] not found"); return; }

        Walk(faction, 0);

        // Find SelectedSeries text container
        foreach (var t in prefab.GetComponentsInChildren<Transform>(true))
        {
            if (t.name == "txtSelectedSeries")
            {
                var rt = t.GetComponent<RectTransform>();
                var txt = t.GetComponent<Text>();
                Debug.Log($"[Banner] txtSelectedSeries pos={rt.anchoredPosition} size={rt.sizeDelta} font={(txt!=null?txt.fontSize.ToString():"-")} text='{(txt!=null?txt.text:"")}'");
            }
        }
    }
    static void Walk(Transform t, int depth)
    {
        var pad = new string(' ', depth * 2);
        var img = t.GetComponent<Image>();
        var txt = t.GetComponent<Text>();
        var info = "";
        if (img != null) info += $" img sprite={(img.sprite!=null?img.sprite.name:"NULL")} color={img.color} type={img.GetType().Name}";
        if (txt != null) info += $" txt='{txt.text}'";
        Debug.Log($"[Banner] {pad}{(t.gameObject.activeSelf?"*":"-")}{t.name}{info}");
        foreach (Transform c in t) Walk(c, depth + 1);
    }
}
