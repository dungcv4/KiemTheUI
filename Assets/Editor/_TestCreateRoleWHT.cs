using UnityEngine;
using UnityEditor;
using System.Text;

// Switch to CreateRole panel and select WHT (faction 20) to verify
// the orphan _AvatarHost cleanup fix lets the new host spawn properly.
public static class _TestCreateRoleWHT
{
    public static string Execute()
    {
        var sb = new StringBuilder();

        // Hide SelectRole panel, show CreateRole panel
        var selectRole = GameObject.Find("UISelectRoleExist_Canvas");
        if (selectRole != null) { selectRole.SetActive(false); sb.AppendLine("Hid UISelectRoleExist_Canvas"); }

        Transform createRoleCanvas = null;
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
            if (t.name == "UICreateRole_Canvas") { createRoleCanvas = t; break; }
        if (createRoleCanvas != null)
        {
            createRoleCanvas.gameObject.SetActive(true);
            sb.AppendLine("Showed UICreateRole_Canvas");
        }

        Transform createRole = null;
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
            if (t.name == "UICreateRole" && t.parent != null && t.parent.name == "UICreateRole_Canvas") { createRole = t; break; }
        if (createRole != null)
        {
            createRole.gameObject.SetActive(true);
            sb.AppendLine("Showed UICreateRole");
        }

        // Hide SelectRole avatar (M_SL) directly inside Character
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
            sb.AppendLine("Hid SelectRole-direct avatars under Character");
        }

        // Apply WHT (faction 20, male first)
        UICreateRoleAvatarController.Apply(20, 1, true);
        sb.AppendLine("Applied UICreateRoleAvatarController.Apply(20, 1)");

        // Re-dump
        var hosts = new System.Collections.Generic.List<Transform>();
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
            if (t.name == "_AvatarHost") hosts.Add(t);
        sb.AppendLine($"After: found {hosts.Count} _AvatarHost");
        foreach (var h in hosts)
        {
            sb.AppendLine($"  path: {GetPath(h)} childCount={h.childCount}");
            for (int i = 0; i < h.childCount; i++)
            {
                var c = h.GetChild(i);
                var img = c.GetComponent<UnityEngine.UI.Image>();
                sb.AppendLine($"    [{i}] {c.name} active={c.gameObject.activeInHierarchy} sprite={(img!=null && img.sprite!=null ? img.sprite.name : "<null>")}");
            }
        }

        Debug.Log(sb.ToString());
        return sb.ToString();
    }

    static string GetPath(Transform t)
    {
        var s = t.name;
        while (t.parent != null) { t = t.parent; s = t.name + "/" + s; }
        return "/" + s;
    }
}
