using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.Text;

// Diagnostic for why M_WHT/F_WHT inside _AvatarHost doesn't render visually
// even though dump shows correct sprite, alpha=1, cull=false.
public static class _DiagWHTVisible
{
    public static string Execute()
    {
        var sb = new StringBuilder();
        sb.AppendLine("=== M_WHT visibility deep diag ===");

        Transform whtT = null;
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
        {
            if (t.name == "M_WHT" && t.parent != null && t.parent.name == "_AvatarHost") { whtT = t; break; }
        }
        if (whtT == null) { sb.AppendLine("M_WHT NOT FOUND under _AvatarHost"); Debug.Log(sb.ToString()); return sb.ToString(); }

        sb.AppendLine($"M_WHT path: {GetPath(whtT)}");
        sb.AppendLine($"  active={whtT.gameObject.activeInHierarchy} self={whtT.gameObject.activeSelf}");
        sb.AppendLine($"  localScale={whtT.localScale} lossyScale={whtT.lossyScale}");
        sb.AppendLine($"  position={whtT.position} localPosition={whtT.localPosition}");

        var rt = whtT as RectTransform;
        if (rt != null)
        {
            var corners = new Vector3[4];
            rt.GetWorldCorners(corners);
            sb.AppendLine($"  RT anchoredPos={rt.anchoredPosition} sizeDelta={rt.sizeDelta} pivot={rt.pivot}");
            sb.AppendLine($"  World corners:");
            for (int i = 0; i < 4; i++) sb.AppendLine($"    [{i}] {corners[i]}");
        }

        // Walk parents up
        sb.AppendLine("--- Parent chain ---");
        var p = whtT;
        while (p != null)
        {
            var sb2 = new StringBuilder();
            sb2.Append($"  {p.name}: active={p.gameObject.activeInHierarchy} layer={p.gameObject.layer}");
            var cg = p.GetComponent<CanvasGroup>();
            if (cg != null) sb2.Append($" CG.alpha={cg.alpha}");
            var c = p.GetComponent<Canvas>();
            if (c != null) sb2.Append($" Canvas.enabled={c.enabled} mode={c.renderMode} order={c.sortingOrder} override={c.overrideSorting} sortLayer={c.sortingLayerName} cam={(c.worldCamera != null ? c.worldCamera.name : "<null>")} planeDist={c.planeDistance}");
            var mask = p.GetComponent<Mask>();
            if (mask != null) sb2.Append($" Mask.enabled={mask.enabled}");
            var rmask = p.GetComponent<RectMask2D>();
            if (rmask != null) sb2.Append($" RectMask2D.enabled={rmask.enabled}");
            sb.AppendLine(sb2.ToString());
            p = p.parent;
        }

        // Camera frustum check
        var cam = Camera.main;
        if (cam != null && rt != null)
        {
            sb.AppendLine("--- Camera frustum check ---");
            sb.AppendLine($"  Camera.main: ortho={cam.orthographic} size={cam.orthographicSize} fov={cam.fieldOfView} near={cam.nearClipPlane} far={cam.farClipPlane}");
            sb.AppendLine($"  pos={cam.transform.position} fwd={cam.transform.forward}");
            var corners = new Vector3[4];
            rt.GetWorldCorners(corners);
            for (int i = 0; i < 4; i++)
            {
                var sp = cam.WorldToScreenPoint(corners[i]);
                sb.AppendLine($"    corner[{i}] world={corners[i]} screen={sp}");
            }
        }

        // Canvases ordered
        sb.AppendLine("--- All active canvases by sortingOrder ---");
        var canvases = Object.FindObjectsOfType<Canvas>(false);
        System.Array.Sort(canvases, (a, b) => a.sortingOrder.CompareTo(b.sortingOrder));
        foreach (var c in canvases)
        {
            sb.AppendLine($"  {GetPath(c.transform)}: mode={c.renderMode} order={c.sortingOrder} override={c.overrideSorting} enabled={c.enabled} sortLayer={c.sortingLayerName}");
        }

        Debug.Log(sb.ToString());
        return sb.ToString();
    }

    static string GetPath(Transform t)
    {
        if (t == null) return "<null>";
        var s = t.name;
        while (t.parent != null) { t = t.parent; s = t.name + "/" + s; }
        return "/" + s;
    }
}
