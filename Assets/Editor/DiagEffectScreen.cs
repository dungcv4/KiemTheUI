using UnityEngine;
using UnityEngine.UI;

public static class DiagEffectScreen
{
    public static string Execute()
    {
        var sb = new System.Text.StringBuilder();

        var cr = GameObject.Find("UICreateRole_Canvas/UICreateRole")
                 ?? GameObject.Find("UICreateRole");
        if (cr == null) return "UICreateRole not found";

        var faction = cr.transform.Find("imgBG/FactionInfo/Faction");
        if (faction == null) return "Faction not found";

        // Check sibling order
        sb.AppendLine("=== Faction children order ===");
        for (int i = 0; i < faction.childCount; i++)
        {
            var child = faction.GetChild(i);
            sb.AppendLine($"  [{i}] {child.name} active={child.gameObject.activeSelf}");
        }

        // Check which effect is active
        string[] effects = { "Fire_Effect", "Metal_Effect", "Earth_Effect", "Water_Effect", "Wood_Effect" };
        foreach (var ename in effects)
        {
            var effect = faction.Find(ename);
            if (effect == null || !effect.gameObject.activeSelf) continue;

            sb.AppendLine($"\n=== ACTIVE: {ename} ===");
            sb.AppendLine($"  siblingIndex={effect.GetSiblingIndex()}/{faction.childCount}");

            string[] children = { "BG", "RaoDong", "LiuGuang" };
            foreach (var cname in children)
            {
                var child = effect.Find(cname);
                if (child == null) continue;
                var rt = child.GetComponent<RectTransform>();
                if (rt == null) continue;
                var img = child.GetComponent<Image>();

                // Get screen rect
                Vector3[] corners = new Vector3[4];
                rt.GetWorldCorners(corners);
                var canvas = cr.GetComponentInParent<Canvas>();
                if (canvas != null && canvas.renderMode == RenderMode.ScreenSpaceCamera && canvas.worldCamera != null)
                {
                    for (int i = 0; i < 4; i++)
                        corners[i] = canvas.worldCamera.WorldToScreenPoint(corners[i]);
                }

                sb.AppendLine($"  {cname}: worldCorners=[{corners[0]:F0},{corners[2]:F0}]");
                if (img != null)
                {
                    sb.AppendLine($"    enabled={img.enabled} color={img.color} matName={img.material?.name}");
                    // Check if material has valid _Diffuse texture
                    if (img.material != null)
                    {
                        bool hasDiffuse = img.material.HasProperty("_Diffuse");
                        Texture diffTex = hasDiffuse ? img.material.GetTexture("_Diffuse") : null;
                        sb.AppendLine($"    hasDiffuse={hasDiffuse} diffTex={diffTex?.name ?? "NULL"} ({diffTex?.width}x{diffTex?.height})");
                        bool hasBlendSet = img.material.HasProperty("_BlendSet");
                        sb.AppendLine($"    hasBlendSet={hasBlendSet}");
                    }
                }

                // Check CanvasRenderer
                var cvr = child.GetComponent<CanvasRenderer>();
                if (cvr != null)
                    sb.AppendLine($"    CanvasRenderer: cull={cvr.cull} alpha={cvr.GetAlpha():F2}");
            }
        }

        // Check Canvas info
        var canvasObj = cr.GetComponentInParent<Canvas>();
        if (canvasObj != null)
            sb.AppendLine($"\nCanvas: renderMode={canvasObj.renderMode} sortingOrder={canvasObj.sortingOrder}");

        return sb.ToString();
    }
}
