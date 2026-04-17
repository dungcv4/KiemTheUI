using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.Text;

// Put M_SL back to its CharacterMidPos (50, -265) per faction.tab,
// keep Character canvas overrideSorting=true so it definitely renders
// above the role list panel which was likely covering it before.
public static class _RestoreMSLPos
{
    public static string Execute()
    {
        var sb = new StringBuilder();

        Transform msl = null;
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
            if (t.name == "M_SL") { msl = t; break; }
        if (msl == null) { sb.AppendLine("M_SL NOT FOUND"); Debug.Log(sb.ToString()); return sb.ToString(); }

        var rt = msl as RectTransform;
        if (rt != null)
        {
            rt.anchoredPosition = new Vector2(50, -265);
            sb.AppendLine($"M_SL anchored → (50, -265)");
        }

        Debug.Log(sb.ToString());
        return sb.ToString();
    }
}
