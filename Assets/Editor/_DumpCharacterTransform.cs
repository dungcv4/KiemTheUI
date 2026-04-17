using UnityEngine;
using System.Text;

// Dump the UILoginBG/Character transform AND F_EM child transform fully —
// localPosition, anchoredPosition, anchors, pivot, sizeDelta, parent chain.
// Helps diagnose why F_EM appears positioned too low.
public static class _DumpCharacterTransform
{
    public static string Execute()
    {
        var sb = new StringBuilder();
        Transform charT = null;
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
            if (t.name == "Character" && t.parent != null && t.parent.name == "UILoginBG") { charT = t; break; }
        if (charT == null) { sb.AppendLine("Character NOT FOUND"); Debug.Log(sb.ToString()); return sb.ToString(); }

        var crt = charT as RectTransform;
        sb.AppendLine($"--- Character (parent of F_EM) ---");
        sb.AppendLine($"  localPosition={crt.localPosition}");
        sb.AppendLine($"  anchoredPosition={crt.anchoredPosition}");
        sb.AppendLine($"  anchorMin={crt.anchorMin} anchorMax={crt.anchorMax}");
        sb.AppendLine($"  pivot={crt.pivot}");
        sb.AppendLine($"  sizeDelta={crt.sizeDelta}");
        sb.AppendLine($"  rect={crt.rect}");
        sb.AppendLine($"  lossyScale={crt.lossyScale}");

        // Parent chain
        Transform p = charT.parent;
        int depth = 1;
        while (p != null && depth < 6)
        {
            var prt = p as RectTransform;
            if (prt != null)
            {
                sb.AppendLine($"  ↑ {p.name}");
                sb.AppendLine($"    localPosition={prt.localPosition}");
                sb.AppendLine($"    anchoredPosition={prt.anchoredPosition}");
                sb.AppendLine($"    anchors=({prt.anchorMin.x},{prt.anchorMin.y})..({prt.anchorMax.x},{prt.anchorMax.y})");
                sb.AppendLine($"    pivot={prt.pivot}");
                sb.AppendLine($"    sizeDelta={prt.sizeDelta} rect={prt.rect}");
            }
            p = p.parent;
            depth++;
        }

        // F_EM child
        Transform fem = null;
        foreach (Transform child in charT)
            if (child.name == "F_EM") { fem = child; break; }
        if (fem != null)
        {
            var frt = fem as RectTransform;
            sb.AppendLine($"--- F_EM ---");
            sb.AppendLine($"  localPosition={frt.localPosition}");
            sb.AppendLine($"  anchoredPosition={frt.anchoredPosition}");
            sb.AppendLine($"  anchors=({frt.anchorMin.x},{frt.anchorMin.y})..({frt.anchorMax.x},{frt.anchorMax.y})");
            sb.AppendLine($"  pivot={frt.pivot}");
            sb.AppendLine($"  sizeDelta={frt.sizeDelta} rect={frt.rect}");
        }
        else
        {
            sb.AppendLine("F_EM child NOT FOUND under Character");
        }

        Debug.Log(sb.ToString());
        return sb.ToString();
    }
}
