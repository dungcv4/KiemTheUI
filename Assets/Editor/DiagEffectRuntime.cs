using UnityEngine;
using UnityEngine.UI;

public static class DiagEffectRuntime
{
    public static string Execute()
    {
        var sb = new System.Text.StringBuilder();
        sb.AppendLine($"IsPlaying: {Application.isPlaying}");

        var cr = GameObject.Find("UICreateRole_Canvas/UICreateRole")
                 ?? GameObject.Find("UICreateRole");
        if (cr == null) return "UICreateRole not found";

        var faction = cr.transform.Find("imgBG/FactionInfo/Faction");
        if (faction == null) return "Faction not found";

        string[] effects = { "Fire_Effect", "Metal_Effect", "Earth_Effect", "Water_Effect", "Wood_Effect" };

        foreach (var ename in effects)
        {
            var effect = faction.Find(ename);
            if (effect == null) { sb.AppendLine($"{ename}: NOT FOUND"); continue; }

            sb.AppendLine($"\n{ename}: active={effect.gameObject.activeSelf}, children={effect.childCount}");

            var anim = effect.GetComponent<Animator>();
            if (anim != null)
            {
                sb.AppendLine($"  Animator: enabled={anim.enabled}, ctrl={anim.runtimeAnimatorController?.name ?? "NULL"}");
                var ci = anim.GetCurrentAnimatorClipInfo(0);
                if (ci != null && ci.Length > 0)
                    sb.AppendLine($"  Playing: {ci[0].clip.name} weight={ci[0].weight}");
                else
                    sb.AppendLine($"  Playing: none/empty");
            }

            for (int i = 0; i < effect.childCount; i++)
            {
                var child = effect.GetChild(i);
                sb.Append($"  {child.name}: active={child.gameObject.activeSelf}");

                var img = child.GetComponent<Image>();
                if (img != null)
                {
                    sb.Append($", img.enabled={img.enabled}");
                    sb.Append($", mat={img.material?.name ?? "NULL"}");
                    sb.Append($", color={img.color}");
                    sb.Append($", shader={img.material?.shader?.name ?? "NULL"}");
                }

                var ctrl = child.GetComponent<ImageEffectAnimationController>();
                if (ctrl != null)
                {
                    sb.Append($", IEAC.enabled={ctrl.enabled}");
                    try
                    {
                        var f = typeof(ImageEffectAnimationController).GetField("uiMaterial",
                            System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                        if (f != null)
                        {
                            var uiMat = f.GetValue(ctrl);
                            if (uiMat == null || uiMat.Equals(null))
                                sb.Append(", uiMat=NULL");
                            else
                                sb.Append($", uiMat={(uiMat as Material)?.name}");
                        }
                    }
                    catch { sb.Append(", uiMat=ERROR"); }

                    try
                    {
                        var gf = typeof(ImageEffectAnimationController).GetField("graphic",
                            System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                        if (gf != null)
                        {
                            var g = gf.GetValue(ctrl);
                            if (g == null || g.Equals(null))
                                sb.Append(", graphic=NULL");
                            else
                                sb.Append($", graphic={g.GetType().Name}");
                        }
                    }
                    catch { sb.Append(", graphic=ERROR"); }
                }

                var txt = child.GetComponent<Text>();
                if (txt != null)
                    sb.Append($", text=\"{txt.text}\", font={txt.font?.name ?? "NULL"}");

                sb.AppendLine();
            }
        }

        return sb.ToString();
    }
}
