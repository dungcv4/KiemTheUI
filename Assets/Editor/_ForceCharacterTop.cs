using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.Text;

// Diagnostic test: force Character canvas to overrideSorting with sortingOrder=999
// to definitively put M_SL above EVERYTHING. If M_SL becomes visible, the
// problem is sub-canvas inheritance/ordering. If still invisible, the problem
// is something else (sprite atlas, render path, etc).
//
// Also moves M_SL to anchored (0, 0) so it appears at center regardless
// of CharacterMidPos calculation.
public static class _ForceCharacterTop
{
    public static string Execute()
    {
        var sb = new StringBuilder();

        var bg = GameObject.Find("UILoginBG");
        if (bg == null) { sb.AppendLine("UILoginBG NOT FOUND"); Debug.Log(sb.ToString()); return sb.ToString(); }

        var charT = bg.transform.Find("Character");
        if (charT == null) { sb.AppendLine("Character NOT FOUND"); Debug.Log(sb.ToString()); return sb.ToString(); }

        var charCanvas = charT.GetComponent<Canvas>();
        if (charCanvas != null)
        {
            charCanvas.overrideSorting = true;
            charCanvas.sortingOrder = 999;
            charCanvas.sortingLayerName = "UI";
            sb.AppendLine($"Character canvas → override=true order=999");
        }

        // Move M_SL to center
        Transform msl = null;
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
            if (t.name == "M_SL") { msl = t; break; }
        if (msl != null)
        {
            var rt = msl as RectTransform;
            if (rt != null)
            {
                sb.AppendLine($"M_SL was at {rt.anchoredPosition}");
                rt.anchoredPosition = Vector2.zero;
                sb.AppendLine($"M_SL now at {rt.anchoredPosition}");
            }
            // Also flag image dirty
            var img = msl.GetComponent<Image>();
            if (img != null)
            {
                img.SetAllDirty();
                sb.AppendLine($"M_SL Image marked dirty (sprite={img.sprite?.name})");
            }
        }

        Debug.Log(sb.ToString());
        return sb.ToString();
    }
}
