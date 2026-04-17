// =======================================================================
//  SpriteAtlasMapGenerator.cs — Generate sprite→atlas bundle mapping
//
//  DEVIATION — not from original source
//  Reason: Original uses BundleManager.s_fileAbInfo populated from the
//  AssetBundleManifest. We generate a simpler JSON mapping at build time.
//
//  Menu: KTO → Build → Generate Sprite Atlas Map
//  Output: Assets/Resources/SpriteAtlasMap.json
// =======================================================================

using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEditor;
using UnityEngine;

public static class SpriteAtlasMapGenerator
{
    [MenuItem("KTO/Build/Generate Sprite Atlas Map")]
    public static void Generate()
    {
        var entries = new List<SpriteEntry>();

        string spritesRoot = "Assets/Sprite";
        if (!Directory.Exists(spritesRoot))
        {
            Debug.LogError("[SpriteAtlasMapGen] Assets/Sprite not found");
            return;
        }

        // Skip Npc, Player, Avatars — they have their own bundle categories
        var skipDirs = new HashSet<string> { "Npc", "Player", "Avatars" };

        foreach (var dirPath in Directory.GetDirectories(spritesRoot))
        {
            string dirName = Path.GetFileName(dirPath);
            if (skipDirs.Contains(dirName)) continue;

            string bundleName = $"ui/atlas/{dirName.ToLower()}/res_a_1";

            // Find all sprite files (.png and .asset) in this directory
            var files = new List<string>();
            files.AddRange(Directory.GetFiles(dirPath, "*.png", SearchOption.TopDirectoryOnly));
            files.AddRange(Directory.GetFiles(dirPath, "*.asset", SearchOption.TopDirectoryOnly));

            foreach (var file in files)
            {
                string assetPath = file.Replace('\\', '/');
                string spriteName = Path.GetFileNameWithoutExtension(file);

                // Verify it's actually a sprite
                var sprite = AssetDatabase.LoadAssetAtPath<Sprite>(assetPath);
                if (sprite != null)
                {
                    entries.Add(new SpriteEntry { sprite = spriteName, bundle = bundleName });
                    continue;
                }

                // Check for sub-sprites (atlas .asset files)
                var objs = AssetDatabase.LoadAllAssetRepresentationsAtPath(assetPath);
                foreach (var obj in objs)
                {
                    if (obj is Sprite s)
                        entries.Add(new SpriteEntry { sprite = s.name, bundle = bundleName });
                }
            }
        }

        // Also map root-level .asset files if they're in Avatars or loose
        // (Skip for now — Avatars are loaded by NpcAssembler/PlayerAssembler directly from their bundles)

        // Serialize to JSON manually (JsonUtility can't serialize inner classes of static classes)
        var sb = new StringBuilder();
        sb.AppendLine("{\"entries\":[");
        for (int i = 0; i < entries.Count; i++)
        {
            var e = entries[i];
            // Escape any special chars in sprite names
            string sSafe = e.sprite.Replace("\\", "\\\\").Replace("\"", "\\\"");
            string bSafe = e.bundle.Replace("\\", "\\\\").Replace("\"", "\\\"");
            sb.Append($"  {{\"sprite\":\"{sSafe}\",\"bundle\":\"{bSafe}\"}}");
            if (i < entries.Count - 1) sb.Append(",");
            sb.AppendLine();
        }
        sb.AppendLine("]}");

        // Ensure Resources directory exists
        string outputDir = "Assets/Resources";
        if (!Directory.Exists(outputDir))
            Directory.CreateDirectory(outputDir);

        string outputPath = Path.Combine(outputDir, "SpriteAtlasMap.json");
        File.WriteAllText(outputPath, sb.ToString());
        AssetDatabase.Refresh();

        Debug.Log($"[SpriteAtlasMapGen] Generated {entries.Count} sprite→bundle mappings to {outputPath}");
    }

    // Also run after bundle build
    [MenuItem("KTO/Build/Build All Bundles + Atlas Map")]
    public static void BuildAllWithMap()
    {
        BundleBuildPipeline.BuildAll();
        Generate();
    }

    class SpriteEntry { public string sprite; public string bundle; }
}
