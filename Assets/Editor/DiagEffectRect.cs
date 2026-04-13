using UnityEngine;
using UnityEngine.UI;

public static class DiagEffectRect
{
    public static string Execute()
    {
        var sb = new System.Text.StringBuilder();

        var cr = GameObject.Find("UICreateRole_Canvas/UICreateRole")
                 ?? GameObject.Find("UICreateRole");
        if (cr == null) return "UICreateRole not found";

        var faction = cr.transform.Find("imgBG/FactionInfo/Faction");
        if (faction == null) return "Faction not found";

        // Check Faction container itself
        var frt = faction.GetComponent<RectTransform>();
        sb.AppendLine($"Faction: pos={frt.anchoredPosition} size={frt.sizeDelta} anchor=({frt.anchorMin},{frt.anchorMax}) pivot={frt.pivot}");

        string[] effects = { "Metal_Effect" }; // just check the active one
        string[] children = { "BG", "RaoDong", "LiuGuang", "FireStar", "Text" };

        foreach (var ename in effects)
        {
            var effect = faction.Find(ename);
            if (effect == null) { sb.AppendLine($"{ename}: NOT FOUND"); continue; }

            var ert = effect.GetComponent<RectTransform>();
            sb.AppendLine($"\n{ename}: active={effect.gameObject.activeSelf} hasRT={ert != null}");
            if (ert != null)
                sb.AppendLine($"  RT: pos={ert.anchoredPosition} size={ert.sizeDelta} anchor=({ert.anchorMin},{ert.anchorMax})");
            sb.AppendLine($"  worldPos={effect.position} scale={effect.localScale}");

            foreach (var cname in children)
            {
                var child = effect.Find(cname);
                if (child == null) continue;
                var crt = child.GetComponent<RectTransform>();
                if (crt == null) continue;

                string extra = "";
                var img = child.GetComponent<Image>();
                if (img != null)
                {
                    string matName = img.material?.name ?? "NULL";
                    extra = $" mat={matName} color={img.color} enabled={img.enabled} raycast={img.raycastTarget}";

                    // Check if material has _Diffuse texture
                    if (img.material != null && img.material.HasProperty("_Diffuse"))
                    {
                        var tex = img.material.GetTexture("_Diffuse");
                        extra += $" _Diffuse={tex?.name ?? "NULL"}";
                    }
                }

                var canvasRenderer = child.GetComponent<CanvasRenderer>();
                float crAlpha = canvasRenderer != null ? canvasRenderer.GetAlpha() : -1;

                sb.AppendLine($"  {cname}: pos={crt.anchoredPosition} size={crt.sizeDelta} pivot={crt.pivot}");
                sb.AppendLine($"    anchor=({crt.anchorMin},{crt.anchorMax}) crAlpha={crAlpha:F2}{extra}");
            }
        }

        return sb.ToString();
    }
}
