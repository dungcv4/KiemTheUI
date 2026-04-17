using UnityEngine;
using UnityEngine.UI;
using System.Text;

public static class _DumpBgSprite
{
    public static string Execute()
    {
        var sb = new StringBuilder();
        Transform bg = null;
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
        {
            if (t.name == "bg" && t.parent != null && t.parent.name == "UILoginBG")
            { bg = t; break; }
        }
        if (bg == null) { sb.AppendLine("UILoginBG/bg NOT FOUND"); Debug.Log(sb.ToString()); return sb.ToString(); }

        // Dump bg's Image
        var img = bg.GetComponent<Image>();
        sb.AppendLine($"--- UILoginBG/bg ---");
        if (img != null)
        {
            sb.AppendLine($"  Image sprite={(img.sprite!=null?img.sprite.name:"<null>")}");
            if (img.sprite != null)
                sb.AppendLine($"  sprite rect={img.sprite.rect} pivot={img.sprite.pivot}");
            sb.AppendLine($"  type={img.type} preserveAspect={img.preserveAspect}");
        }
        else sb.AppendLine("  No Image");

        // Dump children
        sb.AppendLine($"--- UILoginBG/bg children ({bg.childCount}) ---");
        for (int i = 0; i < bg.childCount; i++)
        {
            var c = bg.GetChild(i);
            var crt = c as RectTransform;
            var cimg = c.GetComponent<Image>();
            string spr = cimg != null && cimg.sprite != null ? cimg.sprite.name : "<none>";
            sb.AppendLine($"  [{i}] {c.name} sprite={spr} active={c.gameObject.activeSelf}");
            if (crt != null) sb.AppendLine($"      anchoredPos={crt.anchoredPosition} sizeDelta={crt.sizeDelta} pivot={crt.pivot} rect={crt.rect}");
        }

        Debug.Log(sb.ToString());
        return sb.ToString();
    }
}
