using UnityEngine;
using UnityEditor;
using System.Text;

// Switch to CreateRole panel and select EM (faction 5, female only)
public static class _TestCreateRoleEM
{
    public static string Execute()
    {
        var sb = new StringBuilder();

        var selectRole = GameObject.Find("UISelectRoleExist_Canvas");
        if (selectRole != null) selectRole.SetActive(false);

        Transform createRoleCanvas = null;
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
            if (t.name == "UICreateRole_Canvas") { createRoleCanvas = t; break; }
        if (createRoleCanvas != null) createRoleCanvas.gameObject.SetActive(true);

        Transform createRole = null;
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
            if (t.name == "UICreateRole" && t.parent != null && t.parent.name == "UICreateRole_Canvas") { createRole = t; break; }
        if (createRole != null) createRole.gameObject.SetActive(true);

        Transform charT = null;
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
            if (t.name == "Character" && t.parent != null && t.parent.name == "UILoginBG") { charT = t; break; }
        if (charT != null)
        {
            for (int i = 0; i < charT.childCount; i++)
            {
                var c = charT.GetChild(i);
                if (c.name != "_AvatarHost") c.gameObject.SetActive(false);
            }
        }

        // EM = faction 5 (female only)
        UICreateRoleAvatarController.Apply(5, 2, true);
        sb.AppendLine("Applied EM faction (female)");

        var hosts = new System.Collections.Generic.List<Transform>();
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
            if (t.name == "_AvatarHost") hosts.Add(t);
        foreach (var h in hosts)
        {
            sb.AppendLine($"Host: {h.parent.name}/_AvatarHost childCount={h.childCount}");
            for (int i = 0; i < h.childCount; i++)
            {
                var c = h.GetChild(i);
                var rt = c as RectTransform;
                var img = c.GetComponent<UnityEngine.UI.Image>();
                sb.AppendLine($"  [{i}] {c.name} active={c.gameObject.activeInHierarchy}");
                if (rt != null)
                    sb.AppendLine($"      anchoredPos={rt.anchoredPosition} sizeDelta={rt.sizeDelta} pivot={rt.pivot}");
                if (img != null && img.sprite != null)
                    sb.AppendLine($"      sprite={img.sprite.name} rect={img.sprite.rect} useMesh={img.useSpriteMesh}");
            }
        }

        Debug.Log(sb.ToString());
        return sb.ToString();
    }
}
