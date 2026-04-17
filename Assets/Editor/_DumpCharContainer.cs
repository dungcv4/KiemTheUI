using UnityEngine;
using System.Text;

// Dump everything currently inside UILoginBG/Character so we can see
// which avatars (game/loginbg M_SL, _AvatarHost children, etc) are
// actually live at this moment.
public static class _DumpCharContainer
{
    public static string Execute()
    {
        var sb = new StringBuilder();
        Transform charT = null;
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
            if (t.name == "Character" && t.parent != null && t.parent.name == "UILoginBG") { charT = t; break; }
        if (charT == null) { sb.AppendLine("Character NOT FOUND"); Debug.Log(sb.ToString()); return sb.ToString(); }

        sb.AppendLine($"Character childCount={charT.childCount}");
        for (int i = 0; i < charT.childCount; i++)
        {
            var c = charT.GetChild(i);
            var rt = c as RectTransform;
            var img = c.GetComponent<UnityEngine.UI.Image>();
            sb.AppendLine($"  [{i}] {c.name} active={c.gameObject.activeInHierarchy}");
            if (rt != null)
                sb.AppendLine($"      pos={rt.anchoredPosition} sizeDelta={rt.sizeDelta} scale={rt.localScale}");
            if (img != null && img.sprite != null)
                sb.AppendLine($"      sprite={img.sprite.name} rect={img.sprite.rect}");

            // Recurse one level for _AvatarHost
            for (int j = 0; j < c.childCount; j++)
            {
                var cc = c.GetChild(j);
                var crt = cc as RectTransform;
                var cimg = cc.GetComponent<UnityEngine.UI.Image>();
                sb.AppendLine($"    [{i}.{j}] {cc.name} active={cc.gameObject.activeInHierarchy}");
                if (crt != null)
                    sb.AppendLine($"        pos={crt.anchoredPosition} sizeDelta={crt.sizeDelta} scale={crt.localScale}");
                if (cimg != null && cimg.sprite != null)
                    sb.AppendLine($"        sprite={cimg.sprite.name} rect={cimg.sprite.rect}");
            }
        }
        Debug.Log(sb.ToString());
        return sb.ToString();
    }
}
