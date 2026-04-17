using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.Text;

// Inspect _AvatarHost: anchors, components, masks, anything that could
// hide its children. Compare to what's visible in M_SL which renders
// directly under Character (no _AvatarHost intermediate).
public static class _DumpAvatarHost
{
    public static string Execute()
    {
        var sb = new StringBuilder();

        var hosts = new System.Collections.Generic.List<Transform>();
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
            if (t.name == "_AvatarHost") hosts.Add(t);
        sb.AppendLine($"Found {hosts.Count} _AvatarHost");

        foreach (var hostFound in hosts) DumpHost(hostFound, sb);
        Debug.Log(sb.ToString());
        return sb.ToString();
    }

    static void DumpHost(Transform host, StringBuilder sb)
    {

        var rt = host as RectTransform;
        sb.AppendLine($"_AvatarHost path: {GetPath(host)}");
        sb.AppendLine($"  active={host.gameObject.activeInHierarchy} layer={host.gameObject.layer}");
        if (rt != null)
        {
            sb.AppendLine($"  anchorMin={rt.anchorMin} anchorMax={rt.anchorMax} pivot={rt.pivot}");
            sb.AppendLine($"  anchoredPosition={rt.anchoredPosition} sizeDelta={rt.sizeDelta} localScale={rt.localScale}");
            sb.AppendLine($"  rect={rt.rect} world position={rt.position}");
        }

        // List all components
        sb.AppendLine("--- Components on _AvatarHost ---");
        foreach (var comp in host.GetComponents<Component>())
        {
            if (comp == null) { sb.AppendLine("  <null>"); continue; }
            sb.AppendLine($"  {comp.GetType().Name}");
        }

        // Dump children with anchors
        sb.AppendLine("--- Children ---");
        for (int i = 0; i < host.childCount; i++)
        {
            var c = host.GetChild(i);
            var crt = c as RectTransform;
            sb.AppendLine($"  [{i}] {c.name} active={c.gameObject.activeInHierarchy}");
            if (crt != null)
            {
                sb.AppendLine($"      anchorMin={crt.anchorMin} anchorMax={crt.anchorMax} pivot={crt.pivot}");
                sb.AppendLine($"      anchoredPos={crt.anchoredPosition} sizeDelta={crt.sizeDelta} localScale={crt.localScale}");
                sb.AppendLine($"      rect={crt.rect} world={crt.position}");
                var corners = new Vector3[4];
                crt.GetWorldCorners(corners);
                sb.AppendLine($"      worldCorners: BL={corners[0]} TL={corners[1]} TR={corners[2]} BR={corners[3]}");
            }
            // ALL components
            foreach (var comp in c.GetComponents<Component>())
            {
                if (comp == null) continue;
                sb.AppendLine($"      comp: {comp.GetType().Name}");
            }
        }

        Debug.Log(sb.ToString());
    }

    static string GetPath(Transform t)
    {
        var s = t.name;
        while (t.parent != null) { t = t.parent; s = t.name + "/" + s; }
        return "/" + s;
    }
}
