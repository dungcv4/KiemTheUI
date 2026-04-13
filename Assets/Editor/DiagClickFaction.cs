using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public static class DiagClickFaction
{
    public static string Execute()
    {
        var sb = new System.Text.StringBuilder();

        var cr = GameObject.Find("UICreateRole_Canvas/UICreateRole")
                 ?? GameObject.Find("UICreateRole");
        if (cr == null) return "UICreateRole not found";

        // Check Metal_Effect (currently active) in detail
        var metalEffect = cr.transform.Find("imgBG/FactionInfo/Faction/Metal_Effect");
        if (metalEffect == null) return "Metal_Effect not found";

        var anim = metalEffect.GetComponent<Animator>();
        sb.AppendLine($"=== Metal_Effect Animator ===");
        sb.AppendLine($"  active={metalEffect.gameObject.activeSelf}");
        sb.AppendLine($"  Animator: enabled={anim?.enabled}, hasController={anim?.runtimeAnimatorController != null}");
        if (anim != null && anim.runtimeAnimatorController != null)
        {
            sb.AppendLine($"  controller: {anim.runtimeAnimatorController.name}");
            var stateInfo = anim.GetCurrentAnimatorStateInfo(0);
            sb.AppendLine($"  state: normalizedTime={stateInfo.normalizedTime:F2}, length={stateInfo.length:F2}");
            sb.AppendLine($"  clips:");
            foreach (var clip in anim.runtimeAnimatorController.animationClips)
                sb.AppendLine($"    {clip.name}: length={clip.length:F2}, wrapMode={clip.wrapMode}");
        }

        // Check each child's visual state
        sb.AppendLine($"\n=== Metal_Effect children ===");
        CheckChild(sb, metalEffect, "BG");
        CheckChild(sb, metalEffect, "Text");
        CheckChild(sb, metalEffect, "RaoDong");
        CheckChild(sb, metalEffect, "LiuGuang");
        CheckChild(sb, metalEffect, "FireStar");

        // Also check all 5 effects for Animator controllers
        sb.AppendLine($"\n=== All Effect Animator controllers ===");
        string[] names = { "Fire_Effect", "Metal_Effect", "Earth_Effect", "Water_Effect", "Wood_Effect" };
        var faction = cr.transform.Find("imgBG/FactionInfo/Faction");
        foreach (var name in names)
        {
            var t = faction.Find(name);
            if (t == null) continue;
            var a = t.GetComponent<Animator>();
            string ctrl = "no Animator";
            if (a != null)
                ctrl = a.runtimeAnimatorController != null ? a.runtimeAnimatorController.name : "controller=NULL";
            sb.AppendLine($"  {name}: active={t.gameObject.activeSelf}, {ctrl}");
        }

        return sb.ToString();
    }

    static void CheckChild(System.Text.StringBuilder sb, Transform parent, string childName)
    {
        var child = parent.Find(childName);
        if (child == null) { sb.AppendLine($"  {childName}: NOT FOUND"); return; }

        sb.AppendLine($"  {childName}: active={child.gameObject.activeSelf}");

        var img = child.GetComponent<Image>();
        if (img != null)
        {
            string sprName = "null";
            try { if (img.sprite != null) sprName = img.sprite.name; } catch { sprName = "error"; }
            sb.AppendLine($"    Image: sprite={sprName}, type={img.type}, color={img.color}, enabled={img.enabled}");
            var rt = child.GetComponent<RectTransform>();
            if (rt != null)
                sb.AppendLine($"    RectTransform: size={rt.sizeDelta}, pos={rt.anchoredPosition}");
        }

        var txt = child.GetComponent<Text>();
        if (txt != null)
        {
            sb.AppendLine($"    Text: \"{txt.text}\", fontSize={txt.fontSize}, color={txt.color}");
        }

        // Check for CanvasRenderer alpha
        var cvr = child.GetComponent<CanvasRenderer>();
        if (cvr != null)
            sb.AppendLine($"    CanvasRenderer: alpha={cvr.GetAlpha():F2}");

        // Deeper: check grandchildren
        for (int i = 0; i < child.childCount; i++)
        {
            var gc = child.GetChild(i);
            sb.AppendLine($"    child: {gc.name}, active={gc.gameObject.activeSelf}");
        }
    }
}
