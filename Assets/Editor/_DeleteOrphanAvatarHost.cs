using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using System.Text;

// Removes any _AvatarHost that is NOT a child of UILoginBG/Character.
// The valid _AvatarHost lives under /UILoginBG/Character/_AvatarHost
// (created by UICreateRoleAvatarController.GetOrCreateHost). An orphan was
// found under /UICreateRole_Canvas/UICreateRole/imgBG/CharacterPortrait/_AvatarHost
// and is hiding/competing with the real one in CreateRole flow.
public static class _DeleteOrphanAvatarHost
{
    public static string Execute()
    {
        var sb = new StringBuilder();

        var hosts = new System.Collections.Generic.List<Transform>();
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
            if (t.name == "_AvatarHost") hosts.Add(t);
        sb.AppendLine($"Found {hosts.Count} _AvatarHost before cleanup");

        int deleted = 0;
        foreach (var host in hosts)
        {
            string path = GetPath(host);
            bool isValid = path.StartsWith("/UILoginBG/Character/");
            sb.AppendLine($"  {path} -> {(isValid ? "KEEP" : "DELETE")}");
            if (!isValid)
            {
                Object.DestroyImmediate(host.gameObject);
                deleted++;
            }
        }
        sb.AppendLine($"Deleted {deleted} orphan(s)");

        // Re-count
        int remaining = 0;
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
            if (t.name == "_AvatarHost") remaining++;
        sb.AppendLine($"Remaining _AvatarHost: {remaining}");

        // Persist scene changes
        var scene = EditorSceneManager.GetActiveScene();
        EditorSceneManager.MarkSceneDirty(scene);
        EditorSceneManager.SaveScene(scene);
        sb.AppendLine($"Saved scene: {scene.path}");

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
