using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.Text;

// Deep diagnostic for why M_SL avatar doesn't render visually.
// Walks every parent up from M_SL checking: enabled, alpha, scale,
// canvas group state, image color, sprite, raycast, world bounds vs
// camera frustum.
public static class _DiagMSLVisible
{
    public static string Execute()
    {
        var sb = new StringBuilder();
        sb.AppendLine("=== M_SL visibility deep diag ===");

        // Find M_SL anywhere in scene (active or inactive)
        Transform msl = null;
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
        {
            if (t.name == "M_SL") { msl = t; break; }
        }
        if (msl == null) { sb.AppendLine("M_SL NOT FOUND"); Debug.Log(sb.ToString()); return sb.ToString(); }

        sb.AppendLine($"M_SL found at: {GetPath(msl)}");
        sb.AppendLine($"  active={msl.gameObject.activeInHierarchy} self={msl.gameObject.activeSelf}");
        sb.AppendLine($"  localScale={msl.localScale} lossyScale={msl.lossyScale}");
        sb.AppendLine($"  position={msl.position} localPosition={msl.localPosition}");

        var rt = msl as RectTransform;
        if (rt != null)
        {
            var corners = new Vector3[4];
            rt.GetWorldCorners(corners);
            sb.AppendLine($"  RT anchoredPos={rt.anchoredPosition} sizeDelta={rt.sizeDelta} pivot={rt.pivot}");
            sb.AppendLine($"  World corners:");
            for (int i = 0; i < 4; i++) sb.AppendLine($"    [{i}] {corners[i]}");
        }

        // Walk parents up checking visibility blockers
        sb.AppendLine("--- Parent chain ---");
        var p = msl;
        while (p != null)
        {
            var sb2 = new StringBuilder();
            sb2.Append($"  {p.name}: active={p.gameObject.activeInHierarchy}");
            var cg = p.GetComponent<CanvasGroup>();
            if (cg != null) sb2.Append($" CG.alpha={cg.alpha} interactable={cg.interactable} blocks={cg.blocksRaycasts}");
            var c = p.GetComponent<Canvas>();
            if (c != null) sb2.Append($" Canvas.enabled={c.enabled} mode={c.renderMode} order={c.sortingOrder} override={c.overrideSorting} cam={c.worldCamera?.name ?? "<null>"} planeDist={c.planeDistance}");
            var mask = p.GetComponent<Mask>();
            if (mask != null) sb2.Append($" Mask.enabled={mask.enabled} showInside={mask.showMaskGraphic}");
            var rmask = p.GetComponent<RectMask2D>();
            if (rmask != null) sb2.Append($" RectMask2D.enabled={rmask.enabled}");
            sb.AppendLine(sb2.ToString());
            p = p.parent;
        }

        // Image components on M_SL
        sb.AppendLine("--- Images under M_SL ---");
        foreach (var img in msl.GetComponentsInChildren<Image>(true))
        {
            sb.AppendLine($"  {GetPath(img.transform)}");
            sb.AppendLine($"    enabled={img.enabled} color={img.color} sprite={(img.sprite != null ? img.sprite.name : "<null>")}");
            sb.AppendLine($"    type={img.type} preserveAspect={img.preserveAspect} raycastTarget={img.raycastTarget}");
            sb.AppendLine($"    canvasRenderer.cull={img.canvasRenderer.cull} alpha={img.canvasRenderer.GetAlpha()}");
            var irt = img.transform as RectTransform;
            if (irt != null) sb.AppendLine($"    RT anchoredPos={irt.anchoredPosition} sizeDelta={irt.sizeDelta}");
        }

        // RawImage
        foreach (var ri in msl.GetComponentsInChildren<RawImage>(true))
        {
            sb.AppendLine($"  RawImage {GetPath(ri.transform)} enabled={ri.enabled} color={ri.color} tex={(ri.texture != null ? ri.texture.name : "<null>")}");
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

        // Check Canvases that might be on top
        sb.AppendLine("--- All canvases ordered ---");
        var canvases = Object.FindObjectsOfType<Canvas>(true);
        System.Array.Sort(canvases, (a, b) => a.sortingOrder.CompareTo(b.sortingOrder));
        foreach (var c in canvases)
        {
            sb.AppendLine($"  {GetPath(c.transform)}: mode={c.renderMode} order={c.sortingOrder} override={c.overrideSorting} enabled={c.enabled} active={c.gameObject.activeInHierarchy}");
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
