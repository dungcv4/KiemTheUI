using UnityEngine;
using System.Text;

// Dump the full world-space bounding box of any active F_EM under
// UILoginBG/Character so we can compare its actual rendered pixel
// size between the SelectRole and CreateRole flows.
public static class _DumpFEMWorldRect
{
    public static string Execute()
    {
        var sb = new StringBuilder();

        // Find all F_EM transforms anywhere
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
        {
            if (t.name != "F_EM") continue;
            if (!t.gameObject.activeInHierarchy) continue;
            sb.AppendLine($"--- F_EM at path: {GetPath(t)} ---");
            var rt = t as RectTransform;
            if (rt == null) continue;

            var corners = new Vector3[4];
            rt.GetWorldCorners(corners);
            sb.AppendLine($"  WorldCorners: BL={corners[0]} TL={corners[1]} TR={corners[2]} BR={corners[3]}");
            sb.AppendLine($"  WorldWidth = {(corners[3] - corners[0]).magnitude:F2}");
            sb.AppendLine($"  WorldHeight = {(corners[1] - corners[0]).magnitude:F2}");
            sb.AppendLine($"  anchoredPos = {rt.anchoredPosition}");
            sb.AppendLine($"  sizeDelta = {rt.sizeDelta}");
            sb.AppendLine($"  lossyScale = {rt.lossyScale}");
            sb.AppendLine($"  localScale = {rt.localScale}");

            // Walk parent chain and print canvases
            var p = t.parent;
            int depth = 1;
            while (p != null && depth < 8)
            {
                var c = p.GetComponent<Canvas>();
                var cs = p.GetComponent<UnityEngine.UI.CanvasScaler>();
                if (c != null)
                {
                    sb.AppendLine($"  ↑ Canvas {p.name}: mode={c.renderMode} sortLayer={c.sortingLayerName} order={c.sortingOrder} override={c.overrideSorting} scaleFactor={c.scaleFactor} cam={(c.worldCamera!=null?c.worldCamera.name:"null")}");
                    if (cs != null)
                        sb.AppendLine($"    CanvasScaler: uiScaleMode={cs.uiScaleMode} refRes={cs.referenceResolution} match={cs.matchWidthOrHeight}");
                }
                p = p.parent;
                depth++;
            }

            // Get the actual screen-space pixel size via Camera
            var cam = Camera.main;
            if (cam != null)
            {
                Vector3 sBL = cam.WorldToScreenPoint(corners[0]);
                Vector3 sTR = cam.WorldToScreenPoint(corners[2]);
                sb.AppendLine($"  ScreenPos BL={sBL} TR={sTR}");
                sb.AppendLine($"  ScreenWidth ≈ {Mathf.Abs(sTR.x - sBL.x):F1} px");
                sb.AppendLine($"  ScreenHeight ≈ {Mathf.Abs(sTR.y - sBL.y):F1} px");
                sb.AppendLine($"  Screen.height = {Screen.height}, ratio = {Mathf.Abs(sTR.y - sBL.y) / Screen.height:F2}");
            }
        }

        Debug.Log(sb.ToString());
        return sb.ToString();
    }

    static string GetPath(Transform t)
    {
        var sb = new StringBuilder();
        while (t != null) { sb.Insert(0, "/" + t.name); t = t.parent; }
        return sb.ToString();
    }
}
