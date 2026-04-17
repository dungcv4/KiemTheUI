// =======================================================================
//  ScrubPlaceholderTexts.cs — Permanent fix for "dynamic_change_from_script"
//
//  The KTO import pipeline copies Text m_Text fields from the .ab bundle,
//  where the original client's Lua scripts would have replaced them at
//  runtime via pPanel:Label_SetText(controlPath, actualValue). Since we
//  haven't ported every Lua window, some placeholder text leaks through.
//
//  This scrub iterates every prefab under Assets/Prefabs/Imported/ and
//  clears any Text whose value is literally "dynamic_change_from_script"
//  or contains that substring. Lua dynamically-set fields start empty
//  and get populated by the runtime, so clearing them is the same end
//  state the original game has on cold open.
//
//  Menu: KTO → Fix → Scrub dynamic_change_from_script from prefabs
// =======================================================================
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public static class ScrubPlaceholderTexts
{
    const string PLACEHOLDER = "dynamic_change_from_script";

    [MenuItem("KTO/Fix/Scrub dynamic_change_from_script from prefabs")]
    public static void Run()
    {
        string[] guids = AssetDatabase.FindAssets("t:Prefab",
            new[] { "Assets/Prefabs/Imported" });

        int totalPrefabs = 0, totalTexts = 0, totalCleared = 0;

        foreach (var guid in guids)
        {
            string path = AssetDatabase.GUIDToAssetPath(guid);
            if (!path.EndsWith(".prefab")) continue;

            GameObject root = PrefabUtility.LoadPrefabContents(path);
            if (root == null) continue;

            totalPrefabs++;
            bool modified = false;

            var texts = root.GetComponentsInChildren<Text>(includeInactive: true);
            foreach (var t in texts)
            {
                if (t == null) continue;
                totalTexts++;
                if (string.IsNullOrEmpty(t.text)) continue;
                if (t.text.Contains(PLACEHOLDER))
                {
                    t.text = "";
                    totalCleared++;
                    modified = true;
                }
            }

            if (modified)
            {
                PrefabUtility.SaveAsPrefabAsset(root, path);
                Debug.Log($"[ScrubPlaceholder] {System.IO.Path.GetFileName(path)} — cleared");
            }

            PrefabUtility.UnloadPrefabContents(root);
        }

        Debug.Log($"[ScrubPlaceholder] Done: {totalPrefabs} prefabs, {totalTexts} Text components, {totalCleared} cleared");
    }
}
