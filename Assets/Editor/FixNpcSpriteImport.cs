using System.IO;
using UnityEditor;
using UnityEngine;

/// <summary>
/// Phase 9.4 utility — converts every PNG under Assets/Sprite/Npc/ to
/// TextureImporterType.Sprite (single mode), pivot Bottom, PPU=100.
///
/// The /tmp/extract_npc_bundle.py script writes raw PNGs without any meta
/// hints, so Unity defaults them to "Default" texture type. NpcAssembler
/// needs them as Sprites to render. This menu fixes all of them in one
/// pass after extraction.
///
/// Menu: KTO > Test > Fix NPC Sprite Import Settings
/// </summary>
public static class FixNpcSpriteImport
{
    const string NpcRoot = "Assets/Sprite/Npc";

    [MenuItem("KTO/Test/Fix NPC Sprite Import Settings")]
    public static void FixAll()
    {
        if (!Directory.Exists(NpcRoot))
        {
            Debug.LogWarning($"[FixNpcSpriteImport] folder not found: {NpcRoot}");
            return;
        }

        var pngs = Directory.GetFiles(NpcRoot, "*.png", SearchOption.AllDirectories);
        int changed = 0;
        AssetDatabase.StartAssetEditing();
        try
        {
            foreach (var p in pngs)
            {
                var rel = p.Replace('\\', '/');
                var ti = AssetImporter.GetAtPath(rel) as TextureImporter;
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
                // Pivot bottom-center so transform.position = NPC's feet
                // (matches PlayerAssembler convention: feet on logic point)
                var ts = ti.spritePivot;
                if (ts.x != 0.5f || ts.y != 0f)
                {
                    var so = new SerializedObject(ti);
                    so.FindProperty("m_Alignment").intValue = (int)SpriteAlignment.BottomCenter;
                    so.FindProperty("m_SpritePivot").vector2Value = new Vector2(0.5f, 0f);
                    so.ApplyModifiedProperties();
                    dirty = true;
                }
                if (ti.spritePixelsPerUnit != 100f)
                {
                    ti.spritePixelsPerUnit = 100f;
                    dirty = true;
                }
                if (ti.alphaIsTransparency != true)
                {
                    ti.alphaIsTransparency = true;
                    dirty = true;
                }
                if (ti.mipmapEnabled != false)
                {
                    ti.mipmapEnabled = false;
                    dirty = true;
                }
                if (dirty)
                {
                    AssetDatabase.WriteImportSettingsIfDirty(rel);
                    changed++;
                }
            }
        }
        finally
        {
            AssetDatabase.StopAssetEditing();
        }

        AssetDatabase.Refresh(ImportAssetOptions.ForceUpdate);
        Debug.Log($"[FixNpcSpriteImport] Updated import settings on {changed} of {pngs.Length} sprites");
    }
}
