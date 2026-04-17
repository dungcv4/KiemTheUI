using UnityEngine;
using UnityEditor;
using System.Text;

public static class _BumpCharCanvasOrder
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
        if (c != null)
        {
            sb.AppendLine($"Before: enabled={c.enabled} order={c.sortingOrder} override={c.overrideSorting}");
            c.overrideSorting = true;
            c.sortingOrder = 5;
            c.enabled = false;
            c.enabled = true;
            sb.AppendLine($"After: enabled={c.enabled} order={c.sortingOrder} override={c.overrideSorting}");
        }
        Debug.Log(sb.ToString());
        return sb.ToString();
    }
}
