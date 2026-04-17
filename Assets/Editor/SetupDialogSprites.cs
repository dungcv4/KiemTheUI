using UnityEditor;
using UnityEngine;

public static class SetupDialogSprites
{
    [MenuItem("KTO/Setup Dialog Sprites + Rebuild Prefab")]
    public static void Execute()
    {
        // ── 1. Configure sprite import settings ──────────────────

        // img_dialogbox needs 9-slice border: L=16 B=17 R=17 T=16
        SetSpriteBorder("Assets/Sprite/guide/img_dialogbox.png", new Vector4(16, 17, 17, 16));

        // Other sprites: just make sure they're imported as Sprite
        EnsureSpriteImport("Assets/Sprite/guide/img_dialogbox01.png");
        EnsureSpriteImport("Assets/Sprite/guide/img_dialog_option.png");
        EnsureSpriteImport("Assets/Sprite/guide/img_skip.png");
        EnsureSpriteImport("Assets/Sprite/npcdialog/img_play.png");
        EnsureSpriteImport("Assets/Sprite/npcdialog/img_pause.png");

        AssetDatabase.Refresh();
        Debug.Log("[SetupDialogSprites] All sprite imports configured. Running Import_res_p_151...");

        // ── 2. Re-run the importer to rebuild the prefab ─────────
        Import_res_p_151.Build();

        Debug.Log("[SetupDialogSprites] Done! UINpcDialog prefab rebuilt with proper sprites.");
    }

    static void SetSpriteBorder(string path, Vector4 border)
    {
        var importer = AssetImporter.GetAtPath(path) as TextureImporter;
        if (importer == null)
        {
            Debug.LogWarning($"[SetupDialogSprites] TextureImporter not found: {path}");
            return;
        }

        importer.textureType = TextureImporterType.Sprite;
        importer.spriteImportMode = SpriteImportMode.Single;
        importer.spriteBorder = border;
        importer.filterMode = FilterMode.Bilinear;
        importer.mipmapEnabled = false;
        importer.textureCompression = TextureImporterCompression.Uncompressed;

        // Set max size to avoid downscaling small sprites
        var settings = importer.GetDefaultPlatformTextureSettings();
        settings.maxTextureSize = 2048;
        importer.SetPlatformTextureSettings(settings);

        importer.SaveAndReimport();
        Debug.Log($"[SetupDialogSprites] {path} → border={border}");
    }

    static void EnsureSpriteImport(string path)
    {
        var importer = AssetImporter.GetAtPath(path) as TextureImporter;
        if (importer == null)
        {
            Debug.LogWarning($"[SetupDialogSprites] TextureImporter not found: {path}");
            return;
        }

        if (importer.textureType != TextureImporterType.Sprite)
        {
            importer.textureType = TextureImporterType.Sprite;
            importer.spriteImportMode = SpriteImportMode.Single;
            importer.filterMode = FilterMode.Bilinear;
            importer.mipmapEnabled = false;
            importer.textureCompression = TextureImporterCompression.Uncompressed;
            importer.SaveAndReimport();
            Debug.Log($"[SetupDialogSprites] {path} → configured as Sprite");
        }
    }
}
