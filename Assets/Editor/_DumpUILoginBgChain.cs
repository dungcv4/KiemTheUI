using UnityEngine;
using System.Text;

// Dump UILoginBG canvas + scaler + Character + F_EM full chain to find
// where the visible "rock platform" position is and how to align F_EM.
public static class _DumpUILoginBgChain
{
    public static string Execute()
    {
        var sb = new StringBuilder();

        // 1) UILoginBG itself
        Transform loginBG = null;
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
            if (t.name == "UILoginBG") { loginBG = t; break; }
        if (loginBG == null) { sb.AppendLine("UILoginBG NOT FOUND"); Debug.Log(sb.ToString()); return sb.ToString(); }

        var lrt = loginBG as RectTransform;
        var lcanvas = loginBG.GetComponent<Canvas>();
        var lscaler = loginBG.GetComponent<UnityEngine.UI.CanvasScaler>();
        sb.AppendLine($"--- UILoginBG (root) ---");
        sb.AppendLine($"  rect={lrt.rect}");
        sb.AppendLine($"  sizeDelta={lrt.sizeDelta}  pivot={lrt.pivot}  anchors=({lrt.anchorMin})..({lrt.anchorMax})");
        sb.AppendLine($"  localPos={lrt.localPosition}  lossyScale={lrt.lossyScale}");
        if (lcanvas != null) sb.AppendLine($"  Canvas: renderMode={lcanvas.renderMode} sortOrder={lcanvas.sortingOrder} planeDistance={lcanvas.planeDistance}");
        if (lscaler != null) sb.AppendLine($"  Scaler: ref={lscaler.referenceResolution} match={lscaler.screenMatchMode}({lscaler.matchWidthOrHeight}) mode={lscaler.uiScaleMode}");
        else sb.AppendLine("  No CanvasScaler");

        // 2) List all immediate children of UILoginBG with their rects (looking for background rock)
        sb.AppendLine($"--- UILoginBG children ---");
        for (int i = 0; i < loginBG.childCount; i++)
        {
            var ch = loginBG.GetChild(i);
            var crt = ch as RectTransform;
            if (crt == null) continue;
            sb.AppendLine($"  [{i}] {ch.name} active={ch.gameObject.activeSelf}");
            sb.AppendLine($"      anchoredPos={crt.anchoredPosition} sizeDelta={crt.sizeDelta} pivot={crt.pivot}");
            sb.AppendLine($"      anchors=({crt.anchorMin})..({crt.anchorMax})");
            sb.AppendLine($"      rect={crt.rect}");
            // Look for child Image sprites named "rock" or anything obvious
            int subCount = ch.childCount;
            if (subCount > 0 && subCount < 25)
            {
                for (int j = 0; j < subCount; j++)
                {
                    var sub = ch.GetChild(j);
                    var img = sub.GetComponent<UnityEngine.UI.Image>();
                    string spr = img != null && img.sprite != null ? img.sprite.name : "<none>";
                    sb.AppendLine($"        - {sub.name} sprite={spr}");
                }
            }
        }

        Debug.Log(sb.ToString());
        return sb.ToString();
    }
}
