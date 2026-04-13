using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public static class InspectSeriesAndRadar
{
    public static void Execute()
    {
        var scene = EditorSceneManager.GetActiveScene();
        Transform root = null;
        foreach (var go in scene.GetRootGameObjects())
        {
            root = Find(go.transform, "FactionInfo");
            if (root != null) break;
        }
        if (root == null) { Debug.Log("[SR] FactionInfo NOT FOUND"); return; }

        // Left sidebar: SeriesList/{Metal,Wood,Water,Fire,Earth}/Text
        var seriesList = FindByPath(root, "FactionSeriesList/SeriesList");
        if (seriesList == null)
        {
            // try walking from a wider root
            foreach (var ro in EditorSceneManager.GetActiveScene().GetRootGameObjects())
            {
                seriesList = FindByPath(ro.transform, "FactionSeriesList/SeriesList");
                if (seriesList != null) break;
            }
        }
        if (seriesList != null)
        {
            foreach (var elem in new[] { "Metal", "Wood", "Water", "Fire", "Earth" })
            {
                var node = seriesList.Find(elem);
                if (node == null) continue;
                Dump("SidebarRow", node);
                for (int i = 0; i < node.childCount; i++) Dump("  ch", node.GetChild(i));
            }
        }

        // SeriesText area (top of right panel)
        var st = Find(root, "SeriesText");
        if (st != null) Dump("SeriesText", st);
        for (int i = 0; i < (st != null ? st.childCount : 0); i++) Dump("  child", st.GetChild(i));

        // Radar bg + polygon
        var bg = Find(root, "imgFactionInfoBg");
        if (bg != null) Dump("imgFactionInfoBg", bg);
        var radar = Find(root, "imgFactionInfo");
        if (radar != null) Dump("imgFactionInfo", radar);
    }

    static Transform FindByPath(Transform root, string path)
    {
        var parts = path.Split('/');
        Transform cur = root;
        foreach (var p in parts)
        {
            if (cur == null) return null;
            // Search recursively for the named child
            cur = Find(cur, p);
        }
        return cur;
    }

    static Transform Find(Transform t, string name)
    {
        if (t.name == name) return t;
        for (int i = 0; i < t.childCount; i++)
        {
            var r = Find(t.GetChild(i), name);
            if (r != null) return r;
        }
        return null;
    }

    static void Dump(string label, Transform t)
    {
        var img = t.GetComponent<Image>();
        var txt = t.GetComponent<Text>();
        var rt = t as RectTransform;
        var outline = t.GetComponent<Outline>();
        var shadow = t.GetComponent<Shadow>();
        var info = label + " '" + t.name + "' active=" + t.gameObject.activeSelf;
        if (rt != null)
            info += "  rect=(" + rt.anchoredPosition.x + "," + rt.anchoredPosition.y + ") size=(" + rt.sizeDelta.x + "," + rt.sizeDelta.y + ")";
        if (img != null)
            info += "  [Image col=" + img.color + " spr=" + (img.sprite != null ? img.sprite.name : "null") + " mat=" + (img.material != null ? img.material.name : "null") + "]";
        if (txt != null)
        {
            var fnt = txt.font != null ? txt.font.name : "null";
            var mat = txt.material != null ? txt.material.name : "null";
            info += "  [Text '" + txt.text + "' col=" + txt.color + " size=" + txt.fontSize + " font=" + fnt + " mat=" + mat + "]";
        }
        if (outline != null && !(outline is Shadow == false))
        {
            // Outline derives from Shadow; report only outline-typed
        }
        if (outline != null)
            info += "  [Outline col=" + outline.effectColor + " dist=" + outline.effectDistance + "]";
        if (shadow != null && !(shadow is Outline))
            info += "  [Shadow col=" + shadow.effectColor + " dist=" + shadow.effectDistance + "]";
        Debug.Log("[SR] " + info);
    }
}
