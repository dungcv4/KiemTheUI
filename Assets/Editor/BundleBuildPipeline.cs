// =======================================================================
//  BundleBuildPipeline.cs — AssetBundle build tools (Phase R2.2)
//
//  Source: Original game organizes bundles as:
//    ui/views/res_p_{id}.ab   — UI prefabs
//    ui/atlas/{name}/res_a_1.ab — sprite atlases
//    font/res_f_1.ab          — fonts
//    npc/{resName}/res_n_1.ab — NPC sprites
//    player/{variant}/res_pl_1.ab — player sprites
//    maps/{mapName}/res_m_1.ab — map data
//
//  This script assigns bundle names to assets and builds them
//  into Assets/StreamingAssets/Bundles/Android/ (matching original structure).
// =======================================================================

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using UnityEditor;
using UnityEngine;

public static class BundleBuildPipeline
{
    static string BUNDLE_OUTPUT
    {
        get
        {
            // Match ResourceDef.GetBuildPlatformName() so runtime finds the bundles
            string platform = KTO.Resource.ResourceDef.GetBuildPlatformName();
            return $"Assets/StreamingAssets/Bundles/{platform}";
        }
    }

    // =================================================================
    //  Build All Bundles
    // =================================================================
    [MenuItem("KTO/Build/Build All Bundles")]
    public static void BuildAll()
    {
        AssignAllBundleNames();
        DoBuild();
    }

    // =================================================================
    //  Build UI Atlas Bundles Only
    // =================================================================
    [MenuItem("KTO/Build/Build UI Atlas Bundles Only")]
    public static void BuildAtlasOnly()
    {
        ClearAllBundleNames();
        AssignAtlasBundleNames();
        DoBuild();
    }

    // =================================================================
    //  Build UI View (Prefab) Bundles Only
    // =================================================================
    [MenuItem("KTO/Build/Build UI Prefab Bundles Only")]
    public static void BuildPrefabsOnly()
    {
        ClearAllBundleNames();
        AssignPrefabBundleNames();
        DoBuild();
    }

    // =================================================================
    //  Build Font Bundles Only
    // =================================================================
    [MenuItem("KTO/Build/Build Font Bundles Only")]
    public static void BuildFontsOnly()
    {
        ClearAllBundleNames();
        AssignFontBundleNames();
        DoBuild();
    }

    // =================================================================
    //  AssignAllBundleNames — Tag every asset with its target bundle
    // =================================================================
    public static void AssignAllBundleNames()
    {
        ClearAllBundleNames();

        int total = 0;
        total += AssignAtlasBundleNames();
        total += AssignPrefabBundleNames();
        total += AssignFontBundleNames();
        total += AssignNpcBundleNames();
        total += AssignPlayerBundleNames();
        total += AssignMapBundleNames();

        Debug.Log($"[BundleBuild] Assigned {total} bundle names total");
        AssetDatabase.SaveAssets();
    }

    // =================================================================
    //  Atlas bundles: Assets/Sprite/{atlasName}/*.png → ui/atlas/{atlasName}/res_a_1.ab
    //
    //  Source: KTO_Resources/assets/Bundles/Android/ui/atlas/{name}/res_a_1.ab
    //  Each subdirectory under Assets/Sprite/ (except Npc/ and Player/)
    //  becomes its own atlas bundle.
    // =================================================================
    static int AssignAtlasBundleNames()
    {
        int count = 0;
        string spritesRoot = "Assets/Sprite";

        if (!Directory.Exists(spritesRoot)) return 0;

        // Skip Npc and Player — they get their own bundle categories
        var skipDirs = new HashSet<string> { "Npc", "Player" };

        foreach (var dirPath in Directory.GetDirectories(spritesRoot))
        {
            string dirName = Path.GetFileName(dirPath);
            if (skipDirs.Contains(dirName)) continue;

            // Bundle name matches original: ui/atlas/{dirName}/res_a_1
            string bundleName = $"ui/atlas/{dirName.ToLower()}/res_a_1";

            // Pack both .png and .asset sprite files (some atlases have .asset extracted sprites)
            var files = new List<string>();
            files.AddRange(Directory.GetFiles(dirPath, "*.png", SearchOption.TopDirectoryOnly));
            files.AddRange(Directory.GetFiles(dirPath, "*.asset", SearchOption.TopDirectoryOnly));
            foreach (var file in files)
            {
                string assetPath = file.Replace('\\', '/');
                var importer = AssetImporter.GetAtPath(assetPath);
                if (importer != null)
                {
                    importer.assetBundleName = bundleName;
                    count++;
                }
            }

            if (files.Count > 0)
                Debug.Log($"[BundleBuild] Atlas: {bundleName} ({files.Count} sprites)");
        }

        return count;
    }

    // =================================================================
    //  Prefab bundles: Assets/Prefabs/Imported/{Name}.prefab → ui/views/{name}
    //
    //  Source: KTO_Resources/assets/Bundles/Android/ui/views/res_p_{id}.ab
    //  We use the prefab name as bundle name (simpler than original res_p_id scheme).
    // =================================================================
    static int AssignPrefabBundleNames()
    {
        int count = 0;
        string prefabDir = "Assets/Prefabs/Imported";

        if (!Directory.Exists(prefabDir)) return 0;

        foreach (var prefabPath in Directory.GetFiles(prefabDir, "*.prefab"))
        {
            string assetPath = prefabPath.Replace('\\', '/');
            string prefabName = Path.GetFileNameWithoutExtension(prefabPath).ToLower();
            string bundleName = $"ui/views/{prefabName}";

            var importer = AssetImporter.GetAtPath(assetPath);
            if (importer != null)
            {
                importer.assetBundleName = bundleName;
                count++;
                Debug.Log($"[BundleBuild] Prefab: {bundleName}");
            }
        }

        return count;
    }

    // =================================================================
    //  Font bundles: Assets/Font/*.ttf → font/res_f_1
    //
    //  Source: KTO_Resources/assets/Bundles/Android/font/res_f_1.ab
    //  All fonts go into a single bundle (matching original — 5 fonts, 1 bundle).
    // =================================================================
    static int AssignFontBundleNames()
    {
        int count = 0;
        string fontDir = "Assets/Font";

        if (!Directory.Exists(fontDir)) return 0;

        foreach (var fontPath in Directory.GetFiles(fontDir, "*.ttf"))
        {
            string assetPath = fontPath.Replace('\\', '/');
            var importer = AssetImporter.GetAtPath(assetPath);
            if (importer != null)
            {
                importer.assetBundleName = "font/res_f_1";
                count++;
            }
        }

        if (count > 0)
            Debug.Log($"[BundleBuild] Font: font/res_f_1 ({count} fonts)");

        return count;
    }

    // =================================================================
    //  NPC bundles: Assets/Sprite/Npc/{resName}/ → npc/{resName}/res_n_1
    //
    //  Source: KTO_Resources/assets/Bundles/Android/npc/{resName}/res_n_1.ab
    //  Each NPC gets its own bundle.
    // =================================================================
    static int AssignNpcBundleNames()
    {
        int count = 0;
        string npcRoot = "Assets/Sprite/Npc";

        if (!Directory.Exists(npcRoot)) return 0;

        foreach (var npcDir in Directory.GetDirectories(npcRoot))
        {
            string resName = Path.GetFileName(npcDir).ToLower();
            string bundleName = $"npc/{resName}/res_n_1";

            var pngFiles = Directory.GetFiles(npcDir, "*.png", SearchOption.AllDirectories);
            var assetFiles = Directory.GetFiles(npcDir, "*.asset", SearchOption.AllDirectories);
            var files = pngFiles.Concat(assetFiles);
            foreach (var f in files)
            {
                string assetPath = f.Replace('\\', '/');
                var importer = AssetImporter.GetAtPath(assetPath);
                if (importer != null)
                {
                    importer.assetBundleName = bundleName;
                    count++;
                }
            }
        }

        if (count > 0)
            Debug.Log($"[BundleBuild] NPC sprites: {count} files assigned");

        return count;
    }

    // =================================================================
    //  Player bundles: Assets/Sprite/Player/ → player/res_pl_1
    //
    //  Source: KTO_Resources/assets/Bundles/Android/player/{variant}/res_pl_1.ab
    //  For now, all player sprites go into one bundle (can split later).
    // =================================================================
    static int AssignPlayerBundleNames()
    {
        int count = 0;
        string playerRoot = "Assets/Sprite/Player";

        if (!Directory.Exists(playerRoot)) return 0;

        var pngFiles2 = Directory.GetFiles(playerRoot, "*.png", SearchOption.AllDirectories);
        var assetFiles2 = Directory.GetFiles(playerRoot, "*.asset", SearchOption.AllDirectories);
        var files = pngFiles2.Concat(assetFiles2);
        foreach (var f in files)
        {
            string assetPath = f.Replace('\\', '/');
            var importer = AssetImporter.GetAtPath(assetPath);
            if (importer != null)
            {
                importer.assetBundleName = "player/res_pl_1";
                count++;
            }
        }

        if (count > 0)
            Debug.Log($"[BundleBuild] Player sprites: {count} files → player/res_pl_1");

        return count;
    }

    // =================================================================
    //  Map bundles: Assets/Maps/{mapName}/ → maps/{mapName}/res_m_1
    //
    //  Source: KTO_Resources/assets/Bundles/Android/maps/{mapName}/res_m_1.ab
    //  Includes map textures, obstacle data, meta files.
    // =================================================================
    static int AssignMapBundleNames()
    {
        int count = 0;
        string mapsRoot = "Assets/Maps";

        if (!Directory.Exists(mapsRoot)) return 0;

        foreach (var mapDir in Directory.GetDirectories(mapsRoot))
        {
            string mapName = Path.GetFileName(mapDir).ToLower();
            string bundleName = $"maps/{mapName}/res_m_1";

            // Include textures and data files (not .unity scenes)
            var textures = Directory.GetFiles(mapDir, "*.png", SearchOption.AllDirectories);
            var dataFiles = Directory.GetFiles(mapDir, "*.bytes", SearchOption.AllDirectories);
            var jsonFiles = Directory.GetFiles(mapDir, "*.txt", SearchOption.AllDirectories);

            foreach (var f in textures.Concat(dataFiles).Concat(jsonFiles))
            {
                string assetPath = f.Replace('\\', '/');
                var importer = AssetImporter.GetAtPath(assetPath);
                if (importer != null)
                {
                    importer.assetBundleName = bundleName;
                    count++;
                }
            }
        }

        if (count > 0)
            Debug.Log($"[BundleBuild] Map assets: {count} files assigned");

        return count;
    }

    // =================================================================
    //  DoBuild — Execute the actual bundle build
    // =================================================================
    static void DoBuild()
    {
        if (!Directory.Exists(BUNDLE_OUTPUT))
            Directory.CreateDirectory(BUNDLE_OUTPUT);

        var buildTarget = EditorUserBuildSettings.activeBuildTarget;
        Debug.Log($"[BundleBuild] Building for target: {buildTarget}");

        var manifest = BuildPipeline.BuildAssetBundles(
            BUNDLE_OUTPUT,
            BuildAssetBundleOptions.ChunkBasedCompression |
            BuildAssetBundleOptions.ForceRebuildAssetBundle,
            buildTarget
        );

        if (manifest == null)
        {
            Debug.LogError("[BundleBuild] Build failed!");
            return;
        }

        var bundles = manifest.GetAllAssetBundles();
        Debug.Log($"[BundleBuild] Build complete: {bundles.Length} bundles");

        foreach (var b in bundles)
        {
            string fullPath = Path.Combine(BUNDLE_OUTPUT, b);
            long size = new FileInfo(fullPath).Length;
            Debug.Log($"  {b} ({size / 1024}KB)");
        }

        // Generate PatchFileList.json
        GeneratePatchFileList(manifest);

        AssetDatabase.Refresh();
    }

    // =================================================================
    //  GeneratePatchFileList — Create manifest in original format
    //
    //  Source: KTO_Resources/assets/PatchFileList.json
    //  Format: { MainVersion, UpdateVersion, FileList: { path: { date, MD5, size, ver } } }
    // =================================================================
    static void GeneratePatchFileList(AssetBundleManifest manifest)
    {
        var fileList = new Dictionary<string, object>();
        var bundles = manifest.GetAllAssetBundles();
        string platform = KTO.Resource.ResourceDef.GetBuildPlatformName();

        foreach (var bundleName in bundles)
        {
            string fullPath = Path.Combine(BUNDLE_OUTPUT, bundleName);
            if (!File.Exists(fullPath)) continue;

            var fileInfo = new FileInfo(fullPath);
            string md5 = ComputeMD5(fullPath);

            fileList[$"Bundles/{platform}/{bundleName}"] = new Dictionary<string, object>
            {
                { "date", System.DateTime.Now.ToString("yyyy-MM-dd") },
                { "MD5", md5 },
                { "size", fileInfo.Length },
                { "ver", 1 }
            };
        }

        // Also include the manifest bundle itself
        string manifestPath = Path.Combine(BUNDLE_OUTPUT, platform);
        if (File.Exists(manifestPath))
        {
            var manifestInfo = new FileInfo(manifestPath);
            fileList[$"Bundles/{platform}/{platform}"] = new Dictionary<string, object>
            {
                { "date", System.DateTime.Now.ToString("yyyy-MM-dd") },
                { "MD5", ComputeMD5(manifestPath) },
                { "size", manifestInfo.Length },
                { "ver", 1 }
            };
        }

        var patchFileList = new Dictionary<string, object>
        {
            { "MainVersion", "1.0.0" },
            { "UpdateVersion", 1 },
            { "FileList", fileList },
            { "OptionalPatchFileList", new Dictionary<string, object>() }
        };

        string json = JsonUtility.ToJson(new PatchFileListWrapper
        {
            MainVersion = "1.0.0",
            UpdateVersion = 1
        }, true);

        // Use Newtonsoft-style manual JSON for nested dicts
        var sb = new System.Text.StringBuilder();
        sb.AppendLine("{");
        sb.AppendLine("  \"MainVersion\": \"1.0.0\",");
        sb.AppendLine("  \"UpdateVersion\": 1,");
        sb.AppendLine("  \"FileList\": {");

        int i = 0;
        foreach (var kvp in fileList)
        {
            var entry = (Dictionary<string, object>)kvp.Value;
            sb.Append($"    \"{kvp.Key}\": {{ ");
            sb.Append($"\"date\": \"{entry["date"]}\", ");
            sb.Append($"\"MD5\": \"{entry["MD5"]}\", ");
            sb.Append($"\"size\": {entry["size"]}, ");
            sb.Append($"\"ver\": {entry["ver"]}");
            sb.Append(" }");
            if (++i < fileList.Count) sb.Append(",");
            sb.AppendLine();
        }

        sb.AppendLine("  },");
        sb.AppendLine("  \"OptionalPatchFileList\": {}");
        sb.AppendLine("}");

        string outputPath = Path.Combine(BUNDLE_OUTPUT, "PatchFileList.json");
        File.WriteAllText(outputPath, sb.ToString());
        Debug.Log($"[BundleBuild] PatchFileList.json written: {fileList.Count} entries");
    }

    static string ComputeMD5(string filePath)
    {
        using (var md5 = MD5.Create())
        using (var stream = File.OpenRead(filePath))
        {
            var hash = md5.ComputeHash(stream);
            return System.BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
        }
    }

    // =================================================================
    //  ClearAllBundleNames — Remove all bundle name assignments
    // =================================================================
    static void ClearAllBundleNames()
    {
        var bundleNames = AssetDatabase.GetAllAssetBundleNames();
        foreach (var name in bundleNames)
        {
            AssetDatabase.RemoveAssetBundleName(name, true);
        }
    }

    // Helper class for JsonUtility (partial, doesn't handle nested dicts)
    [System.Serializable]
    class PatchFileListWrapper
    {
        public string MainVersion;
        public int UpdateVersion;
    }

    // =================================================================
    //  Show Bundle Stats — Debug menu item
    // =================================================================
    [MenuItem("KTO/Build/Show Bundle Stats")]
    public static void ShowBundleStats()
    {
        if (!Directory.Exists(BUNDLE_OUTPUT))
        {
            Debug.Log("[BundleBuild] No bundles built yet. Run 'KTO → Build → Build All Bundles'");
            return;
        }

        var abFiles = Directory.GetFiles(BUNDLE_OUTPUT, "*", SearchOption.AllDirectories)
            .Where(f => !f.EndsWith(".meta") && !f.EndsWith(".manifest"))
            .ToArray();

        long totalSize = 0;
        foreach (var f in abFiles)
        {
            totalSize += new FileInfo(f).Length;
        }

        Debug.Log($"[BundleBuild] {abFiles.Length} bundles, total size: {totalSize / (1024 * 1024)}MB");
    }
}
