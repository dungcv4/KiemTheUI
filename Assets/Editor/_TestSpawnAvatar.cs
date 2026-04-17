using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEditor.SceneManagement;
using System.Text;

// Test script: spawn a single avatar (F_EM by default) into the
// UILoginBG/Character mount that PlaceSelectRoleScene creates.
// Mirrors what SelectRoleRuntimeBridge.ShowCharacter does at runtime,
// but works in edit mode so we can verify the prefab + mount structure
// without needing LoginManager / network play.
public static class _TestSpawnAvatar
{
    public static string Execute()
    {
        var sb = new StringBuilder();
        sb.AppendLine("=== TestSpawnAvatar ===");

        // 1. Find UILoginBG/Character mount
        Transform character = null;
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
        {
            if (t.name == "Character" && t.parent != null && t.parent.name == "UILoginBG")
            {
                character = t;
                break;
            }
        }
        if (character == null) { sb.AppendLine("Character mount NOT FOUND — re-run PlaceSelectRoleScene first"); Debug.Log(sb.ToString()); return sb.ToString(); }
        sb.AppendLine($"Found Character mount at {GetPath(character)}");

        // 2. Clear any existing test avatars
        for (int i = character.childCount - 1; i >= 0; i--)
        {
            var c = character.GetChild(i);
            if (c.name.StartsWith("F_") || c.name.StartsWith("M_"))
                Object.DestroyImmediate(c.gameObject);
        }

        // 3. Load F_EM prefab (Female EMei — matches FACTION_AVATAR[5]="EM")
        const string avatarName = "F_EM";
        const string path = "Assets/game/ui/loginbg/" + avatarName + ".prefab";
        var prefab = AssetDatabase.LoadAssetAtPath<GameObject>(path);
        if (prefab == null) { sb.AppendLine($"Avatar prefab NOT FOUND at {path}"); Debug.Log(sb.ToString()); return sb.ToString(); }
        sb.AppendLine($"Loaded prefab: {path}");

        // 4. Instantiate into Character (mirror SelectRoleRuntimeBridge.ShowCharacter)
        var inst = (GameObject)PrefabUtility.InstantiatePrefab(prefab, character);
        inst.name = avatarName;
        inst.SetActive(true);

        // Apply useSpriteMesh fix (Issue 3)
        foreach (var img in inst.GetComponentsInChildren<Image>(true))
            img.useSpriteMesh = true;

        // Apply CHAR_MID_POS for F_EM = (77, -305)
        var rt = inst.GetComponent<RectTransform>();
        if (rt != null)
        {
            rt.anchoredPosition = new Vector2(77f, -305f);
            sb.AppendLine($"Spawned {avatarName} at anchoredPosition={rt.anchoredPosition} sizeDelta={rt.sizeDelta} scale={rt.localScale}");
        }

        // 5. Report state
        var imgs = inst.GetComponentsInChildren<Image>(true);
        sb.AppendLine($"Image components in spawned avatar: {imgs.Length}");
        foreach (var img in imgs)
        {
            var irt = img.transform as RectTransform;
            sb.AppendLine($"  - {img.name} sprite={(img.sprite != null ? img.sprite.name : "NULL")} size={(irt != null ? irt.rect.size.ToString() : "n/a")} alpha={img.color.a}");
        }

        // 6. Save scene
        EditorSceneManager.MarkSceneDirty(EditorSceneManager.GetActiveScene());
        EditorSceneManager.SaveOpenScenes();
        sb.AppendLine("Saved scene");

        Debug.Log(sb.ToString());
        return sb.ToString();
    }

    private static string GetPath(Transform t)
    {
        if (t == null) return "<null>";
        var path = t.name;
        var p = t.parent;
        while (p != null) { path = p.name + "/" + path; p = p.parent; }
        return path;
    }
}
