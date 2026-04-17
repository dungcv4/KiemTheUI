using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.Text;

// Dump everything inside UILoginBG/Character to see what avatars are
// currently spawned + their state. Useful for diagnosing missing WHT
// in CreateRole flow + size issues in EM faction.
public static class _DumpCharacterChildren
{
    public static string Execute()
    {
        var sb = new StringBuilder();
        sb.AppendLine("=== Character container dump ===");

        Transform charT = null;
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
        {
            if (t.name == "Character" && t.parent != null && t.parent.name == "UILoginBG")
            { charT = t; break; }
        }
        if (charT == null) { sb.AppendLine("Character NOT FOUND"); Debug.Log(sb.ToString()); return sb.ToString(); }

        sb.AppendLine($"Character childCount={charT.childCount}");
        for (int i = 0; i < charT.childCount; i++)
        {
            var c = charT.GetChild(i);
            sb.AppendLine($"  [{i}] {c.name} active={c.gameObject.activeInHierarchy}");
            var rt = c as RectTransform;
            if (rt != null)
                sb.AppendLine($"      RT anchoredPos={rt.anchoredPosition} sizeDelta={rt.sizeDelta} pivot={rt.pivot} localScale={rt.localScale}");
            var img = c.GetComponent<Image>();
            if (img != null)
                sb.AppendLine($"      Image enabled={img.enabled} alpha={img.color.a} sprite={(img.sprite != null ? img.sprite.name : "<null>")} useMesh={img.useSpriteMesh} type={img.type}");
            // child images with full transform
            foreach (var subImg in c.GetComponentsInChildren<Image>(true))
            {
                if (subImg.transform == c) continue;
                var srt = subImg.transform as RectTransform;
                sb.AppendLine($"      sub-Image {subImg.name} enabled={subImg.enabled} alpha={subImg.color.a} sprite={(subImg.sprite != null ? subImg.sprite.name : "<null>")} useMesh={subImg.useSpriteMesh}");
                if (srt != null)
                    sb.AppendLine($"        anchoredPos={srt.anchoredPosition} sizeDelta={srt.sizeDelta} pivot={srt.pivot} localScale={srt.localScale} world={srt.position}");
                if (subImg.sprite != null)
                    sb.AppendLine($"        sprite.rect={subImg.sprite.rect} pivot={subImg.sprite.pivot} ppu={subImg.sprite.pixelsPerUnit}");
                sb.AppendLine($"        cr.cull={subImg.canvasRenderer.cull} cr.alpha={subImg.canvasRenderer.GetAlpha()}");
            }
            var anim = c.GetComponent<Animator>();
            if (anim != null)
                sb.AppendLine($"      Animator enabled={anim.enabled} runtime={(anim.runtimeAnimatorController != null ? anim.runtimeAnimatorController.name : "<null>")} speed={anim.speed}");
        }

        var createRoleCanvas = GameObject.Find("UICreateRole_Canvas");
        if (createRoleCanvas != null)
            sb.AppendLine($"UICreateRole_Canvas active={createRoleCanvas.activeInHierarchy}");
        var selectRoleCanvas = GameObject.Find("UISelectRoleExist_Canvas");
        if (selectRoleCanvas != null)
            sb.AppendLine($"UISelectRoleExist_Canvas active={selectRoleCanvas.activeInHierarchy}");

        Debug.Log(sb.ToString());
        return sb.ToString();
    }
}
