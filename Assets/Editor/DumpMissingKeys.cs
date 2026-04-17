// Dump missing translation keys to a JSON file on disk so they can be
// edited in bulk (454 items is too many to paste from logs).
//
// Menu: KTO → Debug → Dump Missing Translation Keys to /tmp/missing_keys.json
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public static class DumpMissingKeys
{
    [MenuItem("KTO/Debug/Dump Missing Translation Keys")]
    public static void Run()
    {
        // Pre-load translations
        KTO.Localization.LanguageModule.LoadLanguage("vi-VN");

        string[] guids = AssetDatabase.FindAssets("t:Prefab",
            new[] { "Assets/Prefabs/Imported" });

        var misses = new HashSet<string>();

        foreach (var guid in guids)
        {
            string path = AssetDatabase.GUIDToAssetPath(guid);
            GameObject root = PrefabUtility.LoadPrefabContents(path);
            if (root == null) continue;

            foreach (var t in root.GetComponentsInChildren<Text>(true))
            {
                if (t == null) continue;
                var loc = t.GetComponent<KTO.Localization.Localize>();
                string key = loc != null && !string.IsNullOrEmpty(loc.Term) ? loc.Term : t.text;
                if (string.IsNullOrEmpty(key)) continue;

                // Only non-ASCII keys (pure ASCII like "100", "23:20" are runtime data)
                bool nonAscii = false;
                foreach (char c in key) { if (c > 0x7F) { nonAscii = true; break; } }
                if (!nonAscii) continue;

                if (!KTO.Localization.LanguageModule.HasTerm(key))
                    misses.Add(key);
            }
            PrefabUtility.UnloadPrefabContents(root);
        }

        // Write sorted JSON
        var sorted = new List<string>(misses);
        sorted.Sort();

        var sb = new StringBuilder();
        sb.AppendLine("{");
        sb.AppendLine("  \"_comment\": \"Missing translation keys. Fill in the values and merge into translations_vi-VN.json.\",");
        sb.AppendLine("  \"terms\": {");
        for (int i = 0; i < sorted.Count; i++)
        {
            string k = sorted[i].Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\n", "\\n");
            sb.Append($"    \"{k}\": \"{k}\"");
            if (i < sorted.Count - 1) sb.Append(",");
            sb.AppendLine();
        }
        sb.AppendLine("  }");
        sb.AppendLine("}");

        string outPath = "/tmp/missing_keys.json";
        File.WriteAllText(outPath, sb.ToString());
        Debug.Log($"[DumpMissingKeys] Wrote {sorted.Count} missing keys to {outPath}");
    }
}
