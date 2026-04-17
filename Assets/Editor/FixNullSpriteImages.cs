// =======================================================================
//  FixNullSpriteImages.cs — Disable Image components that have no sprite.
//
//  Problem: When an imported HUD prefab has an Image with m_Sprite = null
//  but color = white (1,1,1,1) and enabled = true, Unity renders it as a
//  plain white rectangle. Several HUD panels (minimap map, right-top
//  welfare, bottom chat input) exhibit this after import.
//
//  Original behavior: Lua code populates these Image sprites at runtime via
//  pPanel:Sprite_SetSprite(key, bundlePath). Until Lua sets the sprite, the
//  Image should stay transparent (not render a white rect).
//
//  Fix: for every prefab under Assets/Prefabs/Imported/, find every Image
//  with sprite==null AND color.a==1, and either disable it OR set alpha=0.
//  We use alpha=0 so that when Lua later assigns a sprite + alpha (via the
//  ReferenceLoader/SpriteAtlasMap path) the Image renders correctly.
//
//  Menu: KTO → Fix → Hide Null-Sprite Images
// =======================================================================
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public static class FixNullSpriteImages
{
    [MenuItem("KTO/Fix/Hide Null-Sprite Images")]
    public static void Run()
    {
        string[] guids = AssetDatabase.FindAssets("t:Prefab",
            new[] { "Assets/Prefabs/Imported" });

        int totalPrefabs = 0, totalImages = 0, totalFixed = 0;

        foreach (var guid in guids)
        {
            string path = AssetDatabase.GUIDToAssetPath(guid);
            if (!path.EndsWith(".prefab")) continue;

            GameObject root = PrefabUtility.LoadPrefabContents(path);
            if (root == null) continue;

            totalPrefabs++;
            bool modified = false;

            var images = root.GetComponentsInChildren<Image>(includeInactive: true);
            foreach (var img in images)
            {
                totalImages++;
                if (img == null) continue;

                // Only fix when: sprite is null AND color is opaque white
                // AND component is enabled. That's the exact condition that
                // makes Unity render a plain white rectangle.
                if (img.sprite != null) continue;
                if (!img.enabled) continue;
                var col = img.color;
                if (col.a < 0.01f) continue; // already hidden

                // Set alpha to 0 — preserves RGB so Lua-assigned tint still
                // works when it later sets the sprite.
                img.color = new Color(col.r, col.g, col.b, 0f);
                modified = true;
                totalFixed++;
            }

            if (modified)
            {
                PrefabUtility.SaveAsPrefabAsset(root, path);
                Debug.Log($"[FixNullSpriteImages] {System.IO.Path.GetFileName(path)} — fixed");
            }

            PrefabUtility.UnloadPrefabContents(root);
        }

        Debug.Log(
            $"[FixNullSpriteImages] Done: {totalPrefabs} prefabs scanned, " +
            $"{totalImages} Image components, {totalFixed} hidden (alpha→0)");
    }
}
