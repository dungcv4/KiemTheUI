using UnityEngine;
using UnityEngine.UI;

public static class DiagEffectPos
{
    public static string Execute()
    {
        var sb = new System.Text.StringBuilder();

        var cr = GameObject.Find("UICreateRole_Canvas/UICreateRole")
                 ?? GameObject.Find("UICreateRole");
        if (cr == null) return "UICreateRole not found";

        sb.AppendLine($"Screen: {Screen.width}x{Screen.height}");

        // Walk from UICreateRole down to the active Effect
        string[] path = { "imgBG", "FactionInfo", "Faction" };
        Transform cur = cr.transform;
        foreach (var p in path)
        {
            cur = cur.Find(p);
            if (cur == null) { sb.AppendLine($"{p}: NOT FOUND"); return sb.ToString(); }
            var rt = cur.GetComponent<RectTransform>();
            if (rt != null)
            {
                Vector3[] c = new Vector3[4];
                rt.GetWorldCorners(c);
                sb.AppendLine($"{p}: localPos={rt.anchoredPosition} size={rt.sizeDelta} worldBL={c[0]:F1} worldTR={c[2]:F1}");
            }
            else
            {
                sb.AppendLine($"{p}: Transform localPos={cur.localPosition}");
            }
        }

        // Find active effect
        for (int i = 0; i < cur.childCount; i++)
        {
            var effect = cur.GetChild(i);
            if (!effect.gameObject.activeSelf) continue;
            sb.AppendLine($"\nACTIVE: {effect.name}");
            sb.AppendLine($"  Transform: localPos={effect.localPosition} localScale={effect.localScale}");
            sb.AppendLine($"  worldPos={effect.position}");

            // Children
            for (int j = 0; j < effect.childCount; j++)
            {
                var child = effect.GetChild(j);
                var crt = child.GetComponent<RectTransform>();
                if (crt == null) continue;
                Vector3[] corners = new Vector3[4];
                crt.GetWorldCorners(corners);
                // Convert to screen space
                var canvas = cr.GetComponentInParent<Canvas>();
                Camera cam = canvas?.worldCamera;
                if (cam != null)
                {
                    Vector3 screenBL = cam.WorldToScreenPoint(corners[0]);
                    Vector3 screenTR = cam.WorldToScreenPoint(corners[2]);
                    sb.AppendLine($"  {child.name}: screenBL={screenBL:F0} screenTR={screenTR:F0} anchoredPos={crt.anchoredPosition} size={crt.sizeDelta}");
                }
                else
                {
                    sb.AppendLine($"  {child.name}: worldBL={corners[0]:F1} worldTR={corners[2]:F1}");
                }
            }
        }

        return sb.ToString();
    }
}
