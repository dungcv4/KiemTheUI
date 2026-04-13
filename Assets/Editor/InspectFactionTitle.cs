using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public static class InspectFactionTitle
{
    public static void Execute()
    {
        var scene = EditorSceneManager.GetActiveScene();
        Transform faction = null;
        foreach (var root in scene.GetRootGameObjects())
        {
            faction = Find(root.transform, "FactionInfo");
            if (faction != null) break;
        }
        if (faction == null) { Debug.Log("[Title] FactionInfo NOT FOUND"); return; }

        Walk(faction, 0);
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

    static void Walk(Transform t, int depth)
    {
        var pad = new string(' ', depth * 2);
        var line = pad + t.name;
        var txt = t.GetComponent<Text>();
        var img = t.GetComponent<Image>();
        var raw = t.GetComponent<RawImage>();
        var outline = t.GetComponent<Outline>();
        var shadow = t.GetComponent<Shadow>();
        if (txt != null)
        {
            line += "  [Text '" + (txt.text != null ? txt.text.Replace("\n", " ") : "") + "'" +
                    " color=" + txt.color +
                    " font=" + (txt.font != null ? txt.font.name : "null") +
                    " size=" + txt.fontSize +
                    " style=" + txt.fontStyle + "]";
        }
        if (img != null)
            line += "  [Image col=" + img.color + " sprite=" + (img.sprite != null ? img.sprite.name : "null") + "]";
        if (raw != null)
            line += "  [RawImage col=" + raw.color + " tex=" + (raw.texture != null ? raw.texture.name : "null") + "]";
        if (outline != null)
            line += "  [Outline col=" + outline.effectColor + " dist=" + outline.effectDistance + "]";
        if (shadow != null)
            line += "  [Shadow col=" + shadow.effectColor + " dist=" + shadow.effectDistance + "]";
        Debug.Log("[Title] " + line);

        if (depth < 5)
            for (int i = 0; i < t.childCount; i++) Walk(t.GetChild(i), depth + 1);
    }
}
