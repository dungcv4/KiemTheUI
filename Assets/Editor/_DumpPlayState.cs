using UnityEngine;
using UnityEditor;
using System.Text;
using KTO.Network;

// Reports current Play-mode state of LoginScene: which panels are active,
// what LoginManager.State is, role count, and the auto-login coroutine progress.
// Mirrors what _DumpSceneRoots does but reads Play-mode runtime data.
public static class _DumpPlayState
{
    public static string Execute()
    {
        var sb = new StringBuilder();
        sb.AppendLine("=== Play state dump ===");

        // Scene roots
        var scene = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        sb.AppendLine($"Scene: {scene.path} loaded={scene.isLoaded}");
        var roots = scene.GetRootGameObjects();
        for (int i = 0; i < roots.Length; i++)
        {
            var r = roots[i];
            sb.AppendLine($"  [{i}] {r.name} active={r.activeInHierarchy} childCount={r.transform.childCount}");
        }

        // LoginManager state
        var lm = LoginManager.Instance;
        if (lm == null)
        {
            sb.AppendLine("LoginManager.Instance == null");
        }
        else
        {
            sb.AppendLine($"LoginManager.State={lm.State} ErrorMessage={lm.ErrorMessage}");
            sb.AppendLine($"  ServerCount={lm.Servers?.Count ?? -1}");
            sb.AppendLine($"  SelectedServer={(lm.SelectedServer?.ServerName ?? "<null>")}");
            sb.AppendLine($"  PlatformUserID={lm.PlatformUserID}");
        }

        // Find UISelectRoleExist
        var sre = GameObject.Find("UISelectRoleExist_Canvas");
        if (sre == null) sre = GameObject.Find("UISelectRoleExist");
        sb.AppendLine($"UISelectRoleExist canvas: {(sre != null ? sre.name + " active=" + sre.activeInHierarchy : "NOT FOUND")}");

        // Find character mount
        Transform character = null;
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
        {
            if (t.name == "Character" && t.parent != null && t.parent.name == "UILoginBG")
            {
                character = t;
                break;
            }
        }
        if (character != null)
        {
            sb.AppendLine($"UILoginBG/Character: active={character.gameObject.activeInHierarchy} childCount={character.childCount}");
            for (int j = 0; j < character.childCount; j++)
            {
                var c = character.GetChild(j);
                sb.AppendLine($"      → {c.name} active={c.gameObject.activeInHierarchy} pos={(c as RectTransform)?.anchoredPosition.ToString() ?? "n/a"}");
            }
        }
        else
        {
            sb.AppendLine("UILoginBG/Character mount NOT FOUND");
        }

        Debug.Log(sb.ToString());
        return sb.ToString();
    }
}
