using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public static class DiagEffectMats
{
    public static string Execute()
    {
        var sb = new System.Text.StringBuilder();

        var cr = GameObject.Find("UICreateRole_Canvas/UICreateRole")
                 ?? GameObject.Find("UICreateRole");
        if (cr == null) return "UICreateRole not found";

        var faction = cr.transform.Find("imgBG/FactionInfo/Faction");
        if (faction == null) return "Faction not found";

        string[] effects = { "Fire_Effect", "Metal_Effect", "Earth_Effect", "Water_Effect", "Wood_Effect" };
        string[] children = { "BG", "RaoDong", "LiuGuang", "FireStar" };

        foreach (var ename in effects)
        {
            var effect = faction.Find(ename);
            if (effect == null) { sb.AppendLine($"{ename}: NOT FOUND"); continue; }

            sb.AppendLine($"\n=== {ename} (active={effect.gameObject.activeSelf}) ===");
            var anim = effect.GetComponent<Animator>();
            if (anim != null)
                sb.AppendLine($"  Animator: ctrl={anim.runtimeAnimatorController?.name ?? "NULL"}");

            foreach (var cname in children)
            {
                var child = effect.Find(cname);
                if (child == null) { sb.AppendLine($"  {cname}: NOT FOUND"); continue; }

                var img = child.GetComponent<Image>();
                if (img != null)
                {
                    string matName = img.material != null ? img.material.name : "NULL";
                    string shaderName = img.material?.shader?.name ?? "NULL";
                    string spriteName = "NULL";
                    try { if (img.sprite != null) spriteName = img.sprite.name; } catch { spriteName = "err"; }
                    sb.AppendLine($"  {cname}: mat=\"{matName}\" shader=\"{shaderName}\" sprite=\"{spriteName}\" color.a={img.color.a:F2}");
                }

                var ctrl = child.GetComponent<ImageEffectAnimationController>();
                if (ctrl != null)
                    sb.AppendLine($"    ImageEffectAnimCtrl: present");

                var ps = child.GetComponent<ParticleSystem>();
                if (ps != null)
                    sb.AppendLine($"  {cname}: ParticleSystem");
            }
        }

        return sb.ToString();
    }
}
