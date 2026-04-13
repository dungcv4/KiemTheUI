using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

public static class AuditSelectRole
{
    [MenuItem("KTO/Audit SelectRole")]
    public static void Execute()
    {
        var sb = new StringBuilder();
        var scene = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        sb.AppendLine($"Scene: {scene.name}  ({scene.path})");

        // Mirror the LookupSprite logic from generated importers
        var cache = new Dictionary<string, Sprite>();
        var guids = AssetDatabase.FindAssets("t:Sprite", new[] { "Assets/Sprite" });
        foreach (var g in guids)
        {
            var p = AssetDatabase.GUIDToAssetPath(g);
            var s = AssetDatabase.LoadAssetAtPath<Sprite>(p);
            if (s == null) continue;
            if (!cache.ContainsKey(s.name)) cache[s.name] = s;
        }
        sb.AppendLine($"Sprite cache size: {cache.Count}");

        // Walk every Image in scene
        int totalImages = 0, withSprite = 0, nullSprite = 0, hiddenAlpha = 0;
        var nullByCanvas = new Dictionary<string, int>();
        var nullList = new List<string>();
        foreach (var img in Object.FindObjectsByType<Image>(FindObjectsInactive.Include, FindObjectsSortMode.None))
        {
            if (img == null) continue;
            totalImages++;
            if (img.sprite != null) withSprite++;
            else
            {
                nullSprite++;
                if (img.color.a < 0.01f) hiddenAlpha++;
                Transform t = img.transform;
                string canvasName = "(none)";
                while (t != null)
                {
                    if (t.GetComponent<Canvas>() != null) { canvasName = t.name; break; }
                    t = t.parent;
                }
                if (!nullByCanvas.ContainsKey(canvasName)) nullByCanvas[canvasName] = 0;
                nullByCanvas[canvasName]++;
                if (nullList.Count < 30) nullList.Add($"{canvasName}/{img.gameObject.name}");
            }
        }
        sb.AppendLine($"\nImage components: {totalImages} total");
        sb.AppendLine($"  withSprite: {withSprite}");
        sb.AppendLine($"  spriteless: {nullSprite}  (hidden α=0: {hiddenAlpha})");
        sb.AppendLine("\nSpriteless by canvas:");
        foreach (var kv in nullByCanvas.OrderByDescending(k => k.Value))
            sb.AppendLine($"  {kv.Key}: {kv.Value}");

        sb.AppendLine("\nFirst 30 spriteless:");
        foreach (var n in nullList) sb.AppendLine($"  - {n}");

        // Sprite-name lookup check from JSON
        sb.AppendLine("\n=== res_p_189 sprite-name resolution ===");
        var jp = "/tmp/res_p_189_resolved.json";
        if (File.Exists(jp))
        {
            var txt = File.ReadAllText(jp);
            var re = new System.Text.RegularExpressions.Regex(
                "\"sprite_resolved\"\\s*:\\s*\\{[^}]*\"name\"\\s*:\\s*\"([^\"]+)\"",
                System.Text.RegularExpressions.RegexOptions.Singleline);
            var matches = re.Matches(txt);
            int found = 0, missing = 0;
            var missList = new HashSet<string>();
            var foundList = new List<string>();
            foreach (System.Text.RegularExpressions.Match m in matches)
            {
                var name = m.Groups[1].Value;
                if (cache.ContainsKey(name)) { found++; foundList.Add(name); }
                else { missing++; missList.Add(name); }
            }
            sb.AppendLine($"Total sprite refs: {matches.Count} → {found} found / {missing} missing");
            sb.AppendLine("Found sprite names:");
            foreach (var n in foundList) sb.AppendLine($"  ✓ {n}");
            if (missList.Count > 0)
            {
                sb.AppendLine("Missing sprite names:");
                foreach (var n in missList) sb.AppendLine($"  ✗ {n}");
            }
        }

        // Text components — what strings does the bundle ship with?
        int totalText = 0;
        var sampleTexts = new List<string>();
        foreach (var t in Object.FindObjectsByType<Text>(FindObjectsInactive.Include, FindObjectsSortMode.None))
        {
            totalText++;
            if (sampleTexts.Count < 20 && !string.IsNullOrEmpty(t.text))
                sampleTexts.Add($"\"{t.text.Replace("\n","\\n")}\" (font={t.font?.name ?? "?"})");
        }
        sb.AppendLine($"\nText components: {totalText}");
        sb.AppendLine("Sample text values (first 20):");
        foreach (var s in sampleTexts) sb.AppendLine($"  {s}");

        Debug.Log(sb.ToString());
    }
}
