using UnityEngine;
using System.Text;

// Try shifting F_EM's anchoredPosition.y upward to see what value makes
// the character's feet land on the rock platform instead of clipping
// into the bottom UI area.
public static class _TestFEMPosShift
{
    public static string Execute()
    {
        var sb = new StringBuilder();
        Transform fem = null;
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
            if (t.name == "F_EM" && t.gameObject.activeInHierarchy) { fem = t; break; }
        if (fem == null) { sb.AppendLine("F_EM NOT FOUND"); Debug.Log(sb.ToString()); return sb.ToString(); }

        var rt = fem as RectTransform;
        sb.AppendLine($"BEFORE: anchoredPos={rt.anchoredPosition} sizeDelta={rt.sizeDelta}");

        // Move character up by ~150 px so feet land on rock platform
        rt.anchoredPosition = new Vector2(77, -155);

        sb.AppendLine($"AFTER:  anchoredPos={rt.anchoredPosition}");
        Debug.Log(sb.ToString());
        return sb.ToString();
    }
}
