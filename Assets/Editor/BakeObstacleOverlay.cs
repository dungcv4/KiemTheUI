using System;
using System.IO;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using KTO.Game;

public static class BakeObstacleOverlay
{
    const string OverlayPngPath = "Assets/Maps/yunzhongzhen1_a/obstacle_overlay.png";
    const string OverlayChildName = "ObstacleOverlay";

    public static void Execute()
    {
        // 1) Find grid
        var holder = GameObject.Find("yunzhongzhen1_a/Runtime Layer/MapObstacleGrid");
        if (holder == null)
        {
            Debug.LogError("[BakeObstacleOverlay] MapObstacleGrid holder not found — run AttachMapObstacleGrid first");
            return;
        }
        var grid = holder.GetComponent<MapObstacleGrid>();
        if (grid == null) { Debug.LogError("[BakeObstacleOverlay] grid component missing"); return; }
        grid.EnsureLoaded();
        if (grid.Walkable == null) { Debug.LogError("[BakeObstacleOverlay] grid not loaded"); return; }

        // 2) Bake texture — red pixel where blocked, transparent where walkable.
        // Raster convention: texture y=0 is BOTTOM in Unity. Our Walkable[x,y]
        // has y=0 at the TOP of the source file, so we flip when writing pixels
        // IFF FlipY is true (matches how CellToWorld maps cells to world Y).
        int W = grid.W, H = grid.H;
        var tex = new Texture2D(W, H, TextureFormat.RGBA32, mipChain: false, linear: false);
        tex.filterMode = FilterMode.Point;
        var clear = new Color32(0, 0, 0, 0);
        var blocked = new Color32(255, 40, 40, 140);
        var pixels = new Color32[W * H];
        for (int y = 0; y < H; y++)
        {
            int texRow = grid.FlipY ? (H - 1 - y) : y;
            int rowOffset = texRow * W;
            for (int x = 0; x < W; x++)
            {
                pixels[rowOffset + x] = grid.Walkable[x, y] ? clear : blocked;
            }
        }
        tex.SetPixels32(pixels);
        tex.Apply(false, false);
        byte[] png = tex.EncodeToPNG();
        File.WriteAllBytes(OverlayPngPath, png);
        AssetDatabase.ImportAsset(OverlayPngPath, ImportAssetOptions.ForceUpdate);

        // 3) Reimport as Sprite (Point, no compression)
        var importer = AssetImporter.GetAtPath(OverlayPngPath) as TextureImporter;
        if (importer != null)
        {
            importer.textureType = TextureImporterType.Sprite;
            importer.filterMode = FilterMode.Point;
            importer.mipmapEnabled = false;
            importer.spriteImportMode = SpriteImportMode.Single;
            importer.spritePixelsPerUnit = 1f; // 1 px == 1 unit; we scale via transform
            importer.textureCompression = TextureImporterCompression.Uncompressed;
            importer.isReadable = true;
            importer.alphaIsTransparency = true;
            importer.SaveAndReimport();
        }
        var sprite = AssetDatabase.LoadAssetAtPath<Sprite>(OverlayPngPath);
        if (sprite == null)
        {
            Debug.LogError("[BakeObstacleOverlay] failed to load baked sprite");
            return;
        }

        // 4) Locate/create child overlay GameObject
        Transform childT = holder.transform.Find(OverlayChildName);
        GameObject child = childT != null ? childT.gameObject : null;
        if (child == null)
        {
            child = new GameObject(OverlayChildName);
            child.transform.SetParent(holder.transform, worldPositionStays: false);
        }
        var sr = child.GetComponent<SpriteRenderer>();
        if (sr == null) sr = child.AddComponent<SpriteRenderer>();
        sr.sprite = sprite;
        sr.color = Color.white;           // texture alpha handles blending
        sr.sortingOrder = 30000;          // above ground tiles and buildings but below UI
        // No sortingLayerName override — use the default layer ("Default")
        // so it sits on top without messing with the map's own sorting layers.

        // 5) Position & size:
        //   world origin (bottom-left) = grid.WorldOrigin
        //   world size = (W*CellSize.x, H*CellSize.y)
        //   sprite pivot is centered (default) so the transform position = center of the grid rect
        float worldW = W * grid.CellSize.x;
        float worldH = H * grid.CellSize.y;
        child.transform.localPosition = Vector3.zero; // holder is at origin
        child.transform.position = new Vector3(
            grid.WorldOrigin.x + worldW * 0.5f,
            grid.WorldOrigin.y + worldH * 0.5f,
            0f);
        // Sprite is W×H pixels @ 1 px/unit, so its native size is W×H world units.
        // We want (worldW, worldH), so scale = (worldW/W, worldH/H) = (CellSize.x, CellSize.y)
        child.transform.localScale = new Vector3(grid.CellSize.x, grid.CellSize.y, 1f);

        EditorUtility.SetDirty(holder);
        EditorSceneManager.MarkSceneDirty(holder.scene);

        Debug.Log($"[BakeObstacleOverlay] OK  tex={W}x{H} png={OverlayPngPath} " +
                  $"pos={child.transform.position} scale={child.transform.localScale}");
    }
}
