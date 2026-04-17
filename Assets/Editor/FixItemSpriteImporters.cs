// =======================================================================
//  FixItemSpriteImporters.cs — Batch-set every PNG in Assets/Sprite/item/
//  to TextureType = Sprite (single), pivot center, pixels-per-unit 100,
//  alpha=Transparency, so they can be loaded as Sprites.
//
//  Menu: KTO → Fix → Fix Item Sprite Importers
//
//  2,470 extracted PNGs import by default as Texture2D. Without this
//  fix, LoadSpriteByName returns null for every item icon.
// =======================================================================
using System.IO;
using UnityEditor;
using UnityEngine;

public static class FixItemSpriteImporters
{
    [MenuItem("KTO/Fix/Fix Item Sprite Importers")]
    public static void Run()
    {
        const string dir = "Assets/Sprite/item";
        if (!Directory.Exists(dir))
        {
            Debug.LogWarning($"[FixItemSprites] {dir} not found");
            return;
        }

        var files = Directory.GetFiles(dir, "*.png", SearchOption.TopDirectoryOnly);
        Debug.Log($"[FixItemSprites] Processing {files.Length} PNGs…");
        int fixedCount = 0;
        AssetDatabase.StartAssetEditing();
        try
        {
            foreach (var path in files)
            {
                string assetPath = path.Replace("\\", "/");
                var ti = AssetImporter.GetAtPath(assetPath) as TextureImporter;
                if (ti == null) continue;
                bool dirty = false;
                if (ti.textureType != TextureImporterType.Sprite)
                {
                    ti.textureType = TextureImporterType.Sprite;
                    dirty = true;
                }
                if (ti.spriteImportMode != SpriteImportMode.Single)
                {
                    ti.spriteImportMode = SpriteImportMode.Single;
                    dirty = true;
                }
                if (ti.spritePixelsPerUnit != 100f) { ti.spritePixelsPerUnit = 100f; dirty = true; }
                if (ti.alphaIsTransparency != true) { ti.alphaIsTransparency = true; dirty = true; }
                if (ti.mipmapEnabled) { ti.mipmapEnabled = false; dirty = true; }
                if (dirty)
                {
                    ti.SaveAndReimport();
                    fixedCount++;
                }
            }
        }
        finally
        {
            AssetDatabase.StopAssetEditing();
        }
        AssetDatabase.Refresh();
        Debug.Log($"[FixItemSprites] Fixed {fixedCount}/{files.Length}");
    }
}
