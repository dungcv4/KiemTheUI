#if UNITY_EDITOR
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace KTO.Editor.MapImport
{
    // ------------------------------------------------------------
    // JSON schemas (mirror /tmp/extract_map_bundle.py output).
    // JsonUtility requires [Serializable] on nested classes but NOT on arrays.
    // ------------------------------------------------------------

    [Serializable] public class JVec2 { public float x; public float y; }
    [Serializable] public class JVec3 { public float x; public float y; public float z; }
    [Serializable] public class JVec4 { public float x; public float y; public float z; public float w; }
    [Serializable] public class JCol  { public float r; public float g; public float b; public float a; }
    [Serializable] public class JRect { public float x; public float y; public float w; public float h; }
    [Serializable] public class JIVec3 { public int x; public int y; public int z; }

    // --- scene.json
    [Serializable]
    public class SceneJson
    {
        public long root_go_pid;
        public int node_count;
        public NodeJson[] nodes;
    }
    [Serializable]
    public class NodeJson
    {
        public long path_id;
        public string name;
        public int layer;
        public int tag;
        public bool is_active;
        public long tr_pid;
        public JVec3 pos;
        public JVec4 rot;
        public JVec3 scale;
        public long parent_go_pid;
        public long[] children_go_pids;
        public long sr_pid;
        public long[] sprite_animation_pids;
        public long[] region_represent_pids;
        public long scene_info_pid;
        public long scene_represent_pid;
        public long scene_obstacle_pid;
        public bool has_tilemap;
        public bool has_tilemap_renderer;
        public bool has_grid;
        public long[] unknown_component_pids;
    }

    // --- sprites.json
    [Serializable]
    public class SpritesJson
    {
        public int sprite_count;
        public AtlasJson[] atlases;
        public SpriteInfoJson[] all_sprites;
    }
    [Serializable]
    public class AtlasJson
    {
        public long texture_pid;
        public string texture_name;
        public SpriteInfoJson[] sprites;
    }
    [Serializable]
    public class SpriteInfoJson
    {
        public long path_id;
        public string name;
        public string unique_name;
        public JRect rect;
        public JVec2 pivot;
        public JVec2 offset;
        public JVec4 border;
        public float pixels_to_units;
        public int extrude;
        public bool is_polygon;
        public long texture_pid;
        public string texture_name;
    }

    // --- spriterenderers.json
    [Serializable]
    public class SRListJson
    {
        public int count;
        public SRJson[] items;
    }
    [Serializable]
    public class SRJson
    {
        public long path_id;
        public long go_pid;
        public bool enabled;
        public long sprite_pid;
        public long material_pid;
        public JCol color;
        public bool flip_x;
        public bool flip_y;
        public int draw_mode;
        public JVec2 size;
        public int sorting_layer_id;
        public int sorting_layer;
        public int sorting_order;
        public int mask_interaction;
        public int sprite_sort_point;
    }

    // (Material list is already part of meta.json -> MaterialInfoJson[];
    //  no separate materials.json file is needed.)

    // --- tiles.json
    [Serializable]
    public class TilesJson
    {
        public TilemapJson tilemap;
        public GridJson grid;
        public TilemapRendererJson tilemap_renderer;
        public TileMBJson[] tile_assets;
    }
    [Serializable]
    public class TilemapJson
    {
        public long path_id;
        public long go_pid;
        public JIVec3 origin;
        public JIVec3 size;
        public JVec3 tile_anchor;
        public JCol color;
        public int tile_orientation;
        public float animation_frame_rate;
        public TileSlotJson[] tiles;
        public TileAssetArrayEntryJson[] tile_asset_array;
        public TileSpriteArrayEntryJson[] tile_sprite_array;
        public TileMatrixArrayEntryJson[] tile_matrix_array;
        public TileColorArrayEntryJson[] tile_color_array;
    }
    [Serializable]
    public class TileSlotJson
    {
        public int x, y, z;
        public int tile_index;
        public int tile_sprite_index;
        public int tile_matrix_index;
        public int tile_color_index;
        public int tile_object_to_instantiate_index;
        public int all_tile_flags;
    }
    [Serializable] public class TileAssetArrayEntryJson  { public int ref_count; public long tile_pid; }
    [Serializable] public class TileSpriteArrayEntryJson { public int ref_count; public long sprite_pid; }
    [Serializable] public class TileMatrixArrayEntryJson { public int ref_count; public float[] matrix; }
    [Serializable] public class TileColorArrayEntryJson  { public int ref_count; public JCol color; }
    [Serializable]
    public class GridJson
    {
        public long path_id;
        public long go_pid;
        public JVec3 cell_size;
        public JVec3 cell_gap;
        public int cell_layout;
        public int cell_swizzle;
    }
    [Serializable]
    public class TilemapRendererJson
    {
        public long path_id;
        public long go_pid;
        public bool enabled;
        public long material_pid;
        public int sorting_layer_id;
        public int sorting_layer;
        public int sorting_order;
        public JIVec3 chunk_size;
        public int sort_order;
        public int mode;
        public int mask_interaction;
    }
    [Serializable]
    public class TileMBJson
    {
        public long path_id;
        public long sprite_pid;
        public JCol color;
        public int flags;
        public int collider_type;
        public float[] transform;
    }

    // --- animations.json
    [Serializable]
    public class AnimationsJson
    {
        public int count;
        public AnimationItemJson[] items;
    }
    [Serializable]
    public class AnimationItemJson
    {
        public long path_id;
        public long go_pid;
        public bool enabled;
        public float interval;
        public long[] sprite_pids;
    }

    // --- regions.json
    [Serializable]
    public class RegionsJson
    {
        public int count;
        public RegionItemJson[] items;
    }
    [Serializable]
    public class RegionItemJson
    {
        public long path_id;
        public long go_pid;
        public bool enabled;
        public int[] runtime_obj_id_list;
        public long[] runtime_obj_pids;
    }

    // --- meta.json
    [Serializable]
    public class MetaJson
    {
        public string bundle_path;
        public string map_name;
        public long root_go_pid;
        public TextureInfoJson[] textures;
        public MaterialInfoJson[] materials;
        public ShaderInfoJson[] shaders;
        public SceneInfoJson scene_info;
        public SceneRepresentJson scene_represent;
        public SceneObstacleFileJson scene_obstacle;
    }
    [Serializable]
    public class TextureInfoJson
    {
        public long path_id;
        public string name;
        public int width;
        public int height;
        public int format;
        public int filter_mode;
        public int wrap_u;
        public int wrap_v;
        public int mip_count;
        public string png;
    }
    [Serializable] public class MaterialInfoJson { public long path_id; public string name; public long shader_pid; public string shader_name; }
    [Serializable] public class ShaderInfoJson   { public long path_id; public string name; }
    [Serializable]
    public class SceneInfoJson
    {
        public long path_id;
        public long go_pid;
        public SceneRectJson map_rect;
        public int draw_all_represent_area;
        public int draw_all_represent_region;
        public int draw_cur_player_area;
        public int draw_cur_region;
        public int draw_cur_area;
        public int draw_cur_area_cell;
        public int draw_cur_represent_area;
        public int draw_obstacle;
        public int draw_trap;
        public int draw_dyn_obst;
    }
    [Serializable] public class SceneRectJson { public int left; public int top; public int right; public int bottom; }
    [Serializable]
    public class SceneRepresentJson
    {
        public long path_id;
        public long go_pid;
        public string map_name;
        public long[] region_list_pids;
        public int[] region_id_list;
    }
    [Serializable]
    public class SceneObstacleFileJson
    {
        public long path_id;
        public long go_pid;
        public long text_pid;
    }

    // ------------------------------------------------------------
    // Main importer.
    // ------------------------------------------------------------
    public static class KTO_MapImporter
    {
        const string MapName = "yunzhongzhen1_a";
        static string MapRoot => $"Assets/Maps/{MapName}";
        static string DataRoot => $"{MapRoot}/Data";
        static string TexRoot  => $"{MapRoot}/Textures";
        static string TilesRoot => $"{MapRoot}/Tiles";
        static string PrefabPath => $"{MapRoot}/{MapName}.prefab";

        [MenuItem("KTO/Import Map/" + MapName)]
        public static void ImportYunzhongzhen1a() => ImportMap(MapName);

        public static void ImportMap(string mapName)
        {
            var mapRoot = $"Assets/Maps/{mapName}";
            var dataRoot = $"{mapRoot}/Data";
            if (!AssetDatabase.IsValidFolder(mapRoot))
            {
                Debug.LogError($"[KTO_MapImporter] Map folder missing: {mapRoot}");
                return;
            }

            // 1. Load JSONs.
            Debug.Log($"[KTO_MapImporter] Loading JSON...");
            var meta     = LoadJson<MetaJson>($"{dataRoot}/meta.json.txt");
            var sprites  = LoadJson<SpritesJson>($"{dataRoot}/sprites.json.txt");
            var scene    = LoadJson<SceneJson>($"{dataRoot}/scene.json.txt");
            var srData   = LoadJson<SRListJson>($"{dataRoot}/spriterenderers.json.txt");
            var tilesDat = LoadJson<TilesJson>($"{dataRoot}/tiles.json.txt");
            var animDat  = LoadJson<AnimationsJson>($"{dataRoot}/animations.json.txt");
            var regDat   = LoadJson<RegionsJson>($"{dataRoot}/regions.json.txt");

            // 2. Import textures with sprite sheets.
            Debug.Log($"[KTO_MapImporter] Importing textures...");
            var textureAssetByPid = new Dictionary<long, Texture2D>();
            var spriteAssetByPid = new Dictionary<long, Sprite>();
            ImportTextures(mapRoot, meta, sprites, textureAssetByPid, spriteAssetByPid);

            // 3. Create Tile assets for the tilemap.
            Debug.Log($"[KTO_MapImporter] Creating tile assets (this may take a while)...");
            var tileAssetByPid = new Dictionary<long, TileBase>();
            CreateTileAssets(mapRoot, tilesDat, spriteAssetByPid, tileAssetByPid);

            // 4. Build the scene hierarchy.
            Debug.Log($"[KTO_MapImporter] Building hierarchy ({scene.nodes.Length} GOs)...");
            var goByPid = new Dictionary<long, GameObject>();
            var nodeByPid = scene.nodes.ToDictionary(n => n.path_id);
            BuildHierarchy(scene, nodeByPid, goByPid);

            // 5. Resolve materials (material_pid -> Material asset) and
            //    attach SpriteRenderers with both sprite and material wired up.
            //    Why: every SR in a map bundle references a Material via
            //    PPtr<Material> (typically Game/SpriteDefault, sometimes
            //    Game/SpriteBackground). Falling back to Unity's "Sprites-Default"
            //    shader makes sorting/blending diverge from the original.
            //    Source: RippedProject_APK/.../Material/SpriteDefault.mat
            //            shader = Game/SpriteDefault (guid 13245e4a39e316c459eda47ca409101a)
            //    Material list already lives in meta.materials (path_id + name).
            var materialByPid = ResolveMaterials(meta.materials, srData);
            Debug.Log($"[KTO_MapImporter] Attaching SpriteRenderers ({srData.items.Length})...");
            AttachSpriteRenderers(srData, nodeByPid, goByPid, spriteAssetByPid, materialByPid);

            // 6. Attach Tilemap + Grid + TilemapRenderer.
            Debug.Log("[KTO_MapImporter] Attaching Tilemap...");
            AttachTilemap(tilesDat, nodeByPid, goByPid, tileAssetByPid, materialByPid);

            // 7. Attach SpriteAnimationLoop components.
            Debug.Log($"[KTO_MapImporter] Attaching SpriteAnimationLoop ({animDat.items.Length})...");
            AttachAnimations(animDat, goByPid, spriteAssetByPid);

            // 8. Attach RegionRepresent components.
            Debug.Log($"[KTO_MapImporter] Attaching RegionRepresent ({regDat.items.Length})...");
            var regionMbByPid = new Dictionary<long, RegionRepresent>();
            AttachRegions(regDat, goByPid, regionMbByPid);

            // 9. Attach scene-level MBs.
            Debug.Log("[KTO_MapImporter] Attaching scene-level components...");
            AttachSceneComponents(meta, goByPid, mapRoot, regionMbByPid);

            // 10. Save as prefab.
            var rootGO = goByPid[scene.root_go_pid];
            var prefabPath = $"{mapRoot}/{mapName}.prefab";
            PrefabUtility.SaveAsPrefabAsset(rootGO, prefabPath);
            UnityEngine.Object.DestroyImmediate(rootGO);
            Debug.Log($"[KTO_MapImporter] Saved prefab: {prefabPath}");

            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }

        // ------------------------------------------------------------
        static T LoadJson<T>(string path) where T : class
        {
            var ta = AssetDatabase.LoadAssetAtPath<TextAsset>(path);
            if (ta == null) throw new Exception($"Missing asset: {path}");
            var obj = JsonUtility.FromJson<T>(ta.text);
            if (obj == null) throw new Exception($"JSON parse failed: {path}");
            return obj;
        }

        // Returns null if the file isn't present (so older extracts still work).
        static T LoadJsonOptional<T>(string path) where T : class
        {
            var ta = AssetDatabase.LoadAssetAtPath<TextAsset>(path);
            if (ta == null) return null;
            return JsonUtility.FromJson<T>(ta.text);
        }

        // ------------------------------------------------------------
        // Material resolution.
        //
        // Bundle PPtr<Material> entries point either internally (within the
        // map bundle) or externally (CommonAsset.bundle). For map bundles
        // the externals are always "SpriteDefault" or "SpriteBackground"
        // -- single-pass shaders in `Assets/Shaders/Game/`. We map by NAME
        // because the bundle's local PathID has no meaning in our project.
        //
        // This table MUST stay in sync with the shaders the importer can
        // resolve. Add entries here for any new map material we encounter
        // in the wild (run extract_map_bundle.py and inspect materials.json).
        // ------------------------------------------------------------
        static readonly Dictionary<string, string> MaterialNameToGuid = new Dictionary<string, string>
        {
            // shader = Game/SpriteDefault — used by 100% of yunzhongzhen1_a SRs
            { "SpriteDefault",    "daf33d7167258e74b9f2b6284ab35a7c" },
            // shader = GAME/SpriteBackground — for ground-plane sprites
            { "SpriteBackground", "0a9721179e982b242843cdc8ac34c99f" },
        };

        static Material ResolveMaterialByName(string name)
        {
            if (string.IsNullOrEmpty(name)) return null;
            if (!MaterialNameToGuid.TryGetValue(name, out var guid)) return null;
            var path = AssetDatabase.GUIDToAssetPath(guid);
            if (string.IsNullOrEmpty(path)) return null;
            return AssetDatabase.LoadAssetAtPath<Material>(path);
        }

        static Dictionary<long, Material> ResolveMaterials(MaterialInfoJson[] mats, SRListJson srData)
        {
            var result = new Dictionary<long, Material>();
            // Default fallback used for every PID that meta.materials doesn't
            // resolve (e.g. unknown material name, or SR points to something
            // outside this bundle's local materials list).
            var fallback = ResolveMaterialByName("SpriteDefault");
            if (fallback == null)
            {
                Debug.LogError($"[KTO_MapImporter] SpriteDefault.mat missing — sprite renderers will use Unity's default shader (wrong sorting). " +
                               $"Expected GUID {MaterialNameToGuid["SpriteDefault"]} at Assets/Material/SpriteDefault.mat.");
            }
            if (mats != null)
            {
                foreach (var m in mats)
                {
                    var mat = ResolveMaterialByName(m.name) ?? fallback;
                    result[m.path_id] = mat;
                    Debug.Log($"[KTO_MapImporter]   material pid={m.path_id} '{m.name}' (shader={m.shader_name}) -> {(mat != null ? mat.name : "<null>")}");
                }
            }
            // Any material_pid referenced by SRs but NOT in meta.materials gets the fallback.
            foreach (var sr in srData.items)
            {
                if (!result.ContainsKey(sr.material_pid))
                    result[sr.material_pid] = fallback;
            }
            int resolved = 0;
            foreach (var m in result.Values) if (m != null) resolved++;
            Debug.Log($"[KTO_MapImporter] Materials: {resolved}/{result.Count} resolved (fallback=SpriteDefault).");
            return result;
        }

        // ------------------------------------------------------------
        // Layer / tag name remapping.
        //
        // Bundle GameObjects store `m_Layer` as a raw int (0-31) and `m_TagString`
        // as a string. The int indices in the bundle are in the ORIGINAL game's
        // TagManager numbering, which differs from ours for slots 6-8.
        //
        // For map bundles built from yunzhongzhen1_a (and probably most maps),
        // every GO is on layer 0 / tag "Untagged" so this helper is a no-op,
        // but it future-proofs the importer for NPC/effect bundles where the
        // bundle WILL set non-default layers.
        //
        // Source for index→name table:
        // RippedProject_APK/ExportedProject/ProjectSettings/TagManager.asset
        // ------------------------------------------------------------
        static readonly string[] OriginalLayerNames = new string[]
        {
            "Default",         // 0
            "TransparentFX",   // 1
            "Ignore Raycast",  // 2
            null,              // 3 (empty)
            "Water",           // 4
            "UI",              // 5
            "Character",       // 6  (we have "Me" at 6)
            null,              // 7  (empty in original; we have "OtherPlayer")
            "Map",             // 8  (we have "Npc" at 8)
            "Npc",             // 9
            "SceneRep",        // 10
            "Player",          // 11
            "MapObj",          // 12
            "UiModel",         // 13
            "MapQG",           // 14
            "NoNpc",           // 15
            "MainPlayer",      // 16
            "UI3D",            // 17
            null,              // 18
            "TempForGround",   // 19
            "TempForFlyArea",  // 20
            "Reflection0",     // 21
            "Reflection1",     // 22
            "3DHeaUI",         // 23
            "HiddenScene",     // 24
            null,              // 25
            "Sky",             // 26
            "Level0",          // 27
            "Level1",          // 28
            "Level2",          // 29
            "Level3",          // 30
            "Terrain",         // 31
        };

        static int RemapLayerFromBundle(int bundleLayerInt)
        {
            // Built-in layers 0..5 are identical in every Unity project.
            if (bundleLayerInt <= 5) return bundleLayerInt;
            if (bundleLayerInt < 0 || bundleLayerInt >= OriginalLayerNames.Length) return 0;
            var name = OriginalLayerNames[bundleLayerInt];
            if (string.IsNullOrEmpty(name)) return 0;
            int local = LayerMask.NameToLayer(name);
            if (local < 0)
            {
                Debug.LogWarning($"[KTO_MapImporter] Layer '{name}' (orig idx {bundleLayerInt}) " +
                                 $"missing from project TagManager — falling back to Default. " +
                                 $"Add it via ProjectSettings → Tags and Layers.");
                return 0;
            }
            return local;
        }

        // ------------------------------------------------------------
        static void ImportTextures(string mapRoot, MetaJson meta, SpritesJson sprites,
                                   Dictionary<long, Texture2D> textureByPid,
                                   Dictionary<long, Sprite> spriteByPid)
        {
            // Build atlas lookup: texture_pid -> atlas
            var atlasByTexPid = sprites.atlases.ToDictionary(a => a.texture_pid);

            foreach (var tex in meta.textures)
            {
                var pngPath = $"{mapRoot}/Textures/{tex.name}.png";
                if (!File.Exists(pngPath))
                {
                    Debug.LogWarning($"[KTO_MapImporter] Missing PNG: {pngPath}");
                    continue;
                }
                var importer = (TextureImporter)AssetImporter.GetAtPath(pngPath);
                if (importer == null)
                {
                    Debug.LogWarning($"[KTO_MapImporter] No TextureImporter for {pngPath}");
                    continue;
                }
                importer.textureType = TextureImporterType.Sprite;
                importer.spriteImportMode = SpriteImportMode.Multiple;
                importer.spritePixelsPerUnit = 100f;
                importer.filterMode = (FilterMode)tex.filter_mode;
                importer.wrapMode = (TextureWrapMode)tex.wrap_u;
                importer.mipmapEnabled = tex.mip_count > 1;
                importer.isReadable = false;
                importer.textureCompression = TextureImporterCompression.Uncompressed;
                importer.alphaIsTransparency = true;

                // Build spritesheet metadata
                if (!atlasByTexPid.TryGetValue(tex.path_id, out var atlas))
                {
                    Debug.LogWarning($"[KTO_MapImporter] No atlas entry for texture {tex.name}");
                    continue;
                }
                var metas = new List<SpriteMetaData>(atlas.sprites.Length);
                foreach (var s in atlas.sprites)
                {
                    var md = new SpriteMetaData
                    {
                        name = s.unique_name,
                        rect = new Rect(s.rect.x, s.rect.y, s.rect.w, s.rect.h),
                        alignment = (int)SpriteAlignment.Custom,
                        pivot = new Vector2(s.pivot.x, s.pivot.y),
                        border = new Vector4(s.border.x, s.border.y, s.border.z, s.border.w),
                    };
                    metas.Add(md);
                }
                importer.spritesheet = metas.ToArray();

                EditorUtility.SetDirty(importer);
                importer.SaveAndReimport();

                // Reload the texture + sub-sprites
                var texAsset = AssetDatabase.LoadAssetAtPath<Texture2D>(pngPath);
                textureByPid[tex.path_id] = texAsset;

                var allAssets = AssetDatabase.LoadAllAssetsAtPath(pngPath);
                var subSpritesByName = allAssets
                    .OfType<Sprite>()
                    .ToDictionary(sp => sp.name);

                foreach (var s in atlas.sprites)
                {
                    if (subSpritesByName.TryGetValue(s.unique_name, out var sp))
                    {
                        spriteByPid[s.path_id] = sp;
                    }
                    else
                    {
                        Debug.LogWarning($"[KTO_MapImporter] Sprite not found after import: {s.unique_name} (pid={s.path_id})");
                    }
                }
                Debug.Log($"[KTO_MapImporter]   {tex.name}: {atlas.sprites.Length} sprites");
            }
        }

        // ------------------------------------------------------------
        static void CreateTileAssets(string mapRoot, TilesJson tilesDat,
                                     Dictionary<long, Sprite> spriteByPid,
                                     Dictionary<long, TileBase> tileByPid)
        {
            var tilesFolder = $"{mapRoot}/Tiles";
            if (!AssetDatabase.IsValidFolder(tilesFolder))
                AssetDatabase.CreateFolder(mapRoot, "Tiles");

            // Pack all 9920 Tile ScriptableObjects into a single .asset to avoid
            // creating thousands of files. The first tile becomes the main asset;
            // the rest are added as sub-assets of it.
            var containerPath = $"{tilesFolder}/TilePalette.asset";

            // Wipe any stale container (so repeated imports are idempotent).
            if (File.Exists(containerPath))
                AssetDatabase.DeleteAsset(containerPath);

            Tile mainTile = null;

            AssetDatabase.StartAssetEditing();
            try
            {
                foreach (var tm in tilesDat.tile_assets)
                {
                    var tile = ScriptableObject.CreateInstance<Tile>();
                    tile.name = $"Tile_{tm.path_id}";
                    if (spriteByPid.TryGetValue(tm.sprite_pid, out var sp))
                        tile.sprite = sp;
                    tile.color = new Color(tm.color.r, tm.color.g, tm.color.b, tm.color.a);
                    tile.colliderType = (Tile.ColliderType)tm.collider_type;
                    if (tm.transform != null && tm.transform.Length == 16)
                    {
                        var m = new Matrix4x4();
                        for (int i = 0; i < 4; i++)
                        for (int j = 0; j < 4; j++)
                            m[i, j] = tm.transform[i * 4 + j];
                        tile.transform = m;
                    }

                    if (mainTile == null)
                    {
                        mainTile = tile;
                        AssetDatabase.CreateAsset(mainTile, containerPath);
                    }
                    else
                    {
                        AssetDatabase.AddObjectToAsset(tile, mainTile);
                    }
                    tileByPid[tm.path_id] = tile;
                }
            }
            finally
            {
                AssetDatabase.StopAssetEditing();
            }
            AssetDatabase.ImportAsset(containerPath);
            Debug.Log($"[KTO_MapImporter]   Created {tilesDat.tile_assets.Length} Tile assets in {containerPath}");
        }

        // ------------------------------------------------------------
        static void BuildHierarchy(SceneJson scene, Dictionary<long, NodeJson> nodeByPid,
                                   Dictionary<long, GameObject> goByPid)
        {
            // Create all GOs first
            foreach (var n in scene.nodes)
            {
                var go = new GameObject(n.name);
                // Remap bundle's layer index (in original game's TagManager
                // numbering) to our project's index by name. For map bundles
                // every node is layer 0 today, but this keeps NPC/effect
                // bundles correct when the importer is generalised.
                go.layer = RemapLayerFromBundle(n.layer);
                go.SetActive(n.is_active);
                goByPid[n.path_id] = go;
            }
            // Set parents + transforms
            foreach (var n in scene.nodes)
            {
                var go = goByPid[n.path_id];
                if (n.parent_go_pid != 0 && goByPid.TryGetValue(n.parent_go_pid, out var parent))
                {
                    go.transform.SetParent(parent.transform, false);
                }
                go.transform.localPosition = new Vector3(n.pos.x, n.pos.y, n.pos.z);
                go.transform.localRotation = new Quaternion(n.rot.x, n.rot.y, n.rot.z, n.rot.w);
                go.transform.localScale    = new Vector3(n.scale.x, n.scale.y, n.scale.z);
            }
            // Reorder siblings to match bundle order
            foreach (var n in scene.nodes)
            {
                if (n.children_go_pids == null) continue;
                for (int i = 0; i < n.children_go_pids.Length; i++)
                {
                    if (goByPid.TryGetValue(n.children_go_pids[i], out var child))
                        child.transform.SetSiblingIndex(i);
                }
            }
        }

        // ------------------------------------------------------------
        static void AttachSpriteRenderers(SRListJson srData, Dictionary<long, NodeJson> nodeByPid,
                                          Dictionary<long, GameObject> goByPid,
                                          Dictionary<long, Sprite> spriteByPid,
                                          Dictionary<long, Material> materialByPid)
        {
            int unresolvedSorting = 0;
            int unresolvedMaterial = 0;
            foreach (var sr in srData.items)
            {
                if (!goByPid.TryGetValue(sr.go_pid, out var go)) continue;
                var r = go.AddComponent<SpriteRenderer>();
                r.enabled = sr.enabled;
                if (spriteByPid.TryGetValue(sr.sprite_pid, out var sp))
                    r.sprite = sp;

                // Material — wire BEFORE sprite-sensitive props so Unity
                // doesn't transiently bind the global Sprites-Default shader.
                // Source: bundle's SpriteRenderer.m_Material PPtr. The map
                // bundle stores material_pid 4 (= Game/SpriteDefault) for
                // all 4622 SRs in yunzhongzhen1_a; ResolveMaterials handles
                // unknown PIDs by falling back to SpriteDefault.mat.
                if (materialByPid != null && materialByPid.TryGetValue(sr.material_pid, out var mat) && mat != null)
                {
                    r.sharedMaterial = mat;
                }
                else
                {
                    unresolvedMaterial++;
                }

                r.color = new Color(sr.color.r, sr.color.g, sr.color.b, sr.color.a);
                r.flipX = sr.flip_x;
                r.flipY = sr.flip_y;
                r.drawMode = (SpriteDrawMode)sr.draw_mode;
                r.size = new Vector2(sr.size.x, sr.size.y);

                // sortingLayerID is a 32-bit hash of the layer name. Bundle
                // stores it as int32 (signed two's complement); Unity reads
                // it bit-for-bit, so signed -1393136525 == unsigned 2901830771
                // which matches BuildinObj uniqueID in TagManager.asset.
                // If the layer hash isn't registered in OUR TagManager,
                // Unity silently falls back to Default(0) → broken draw order.
                r.sortingLayerID = sr.sorting_layer_id;
                if (sr.sorting_layer_id != 0 && r.sortingLayerID != sr.sorting_layer_id)
                {
                    // Defensive: Unity rewrote the value because the layer
                    // wasn't found. Should never trigger after the
                    // TagManager.asset additive merge.
                    unresolvedSorting++;
                }
                r.sortingOrder = sr.sorting_order;
                r.maskInteraction = (SpriteMaskInteraction)sr.mask_interaction;
                r.spriteSortPoint = (SpriteSortPoint)sr.sprite_sort_point;
            }
            if (unresolvedMaterial > 0)
                Debug.LogWarning($"[KTO_MapImporter] {unresolvedMaterial}/{srData.items.Length} SpriteRenderers have NO material assigned (lookup miss).");
            if (unresolvedSorting > 0)
                Debug.LogWarning($"[KTO_MapImporter] {unresolvedSorting}/{srData.items.Length} SpriteRenderers fell back to Default sorting layer (hash not registered in TagManager.asset).");
        }

        // ------------------------------------------------------------
        static void AttachTilemap(TilesJson td, Dictionary<long, NodeJson> nodeByPid,
                                  Dictionary<long, GameObject> goByPid,
                                  Dictionary<long, TileBase> tileByPid,
                                  Dictionary<long, Material> materialByPid)
        {
            // Grid + Tilemap + TilemapRenderer each live on their own GO.
            var gridGO = goByPid.ContainsKey(td.grid.go_pid) ? goByPid[td.grid.go_pid] : null;
            if (gridGO != null)
            {
                var grid = gridGO.AddComponent<Grid>();
                grid.cellSize = new Vector3(td.grid.cell_size.x, td.grid.cell_size.y, td.grid.cell_size.z);
                grid.cellGap  = new Vector3(td.grid.cell_gap.x,  td.grid.cell_gap.y,  td.grid.cell_gap.z);
                grid.cellLayout = (GridLayout.CellLayout)td.grid.cell_layout;
                grid.cellSwizzle = (GridLayout.CellSwizzle)td.grid.cell_swizzle;
            }

            var tmGO = goByPid.ContainsKey(td.tilemap.go_pid) ? goByPid[td.tilemap.go_pid] : null;
            if (tmGO == null) return;
            var tm = tmGO.AddComponent<Tilemap>();
            tm.origin = new Vector3Int(td.tilemap.origin.x, td.tilemap.origin.y, td.tilemap.origin.z);
            tm.size   = new Vector3Int(td.tilemap.size.x, td.tilemap.size.y, td.tilemap.size.z);
            tm.tileAnchor = new Vector3(td.tilemap.tile_anchor.x, td.tilemap.tile_anchor.y, td.tilemap.tile_anchor.z);
            tm.color = new Color(td.tilemap.color.r, td.tilemap.color.g, td.tilemap.color.b, td.tilemap.color.a);
            tm.orientation = (Tilemap.Orientation)td.tilemap.tile_orientation;
            tm.animationFrameRate = td.tilemap.animation_frame_rate;

            var tmr = tmGO.AddComponent<TilemapRenderer>();
            var trJ = td.tilemap_renderer;
            tmr.enabled = trJ.enabled;
            // Wire material before sortingLayerID so Unity doesn't briefly
            // bind the TilemapRenderer's default shader. Same fallback chain
            // as SpriteRenderer.
            if (materialByPid != null && materialByPid.TryGetValue(trJ.material_pid, out var trMat) && trMat != null)
                tmr.sharedMaterial = trMat;
            tmr.sortingLayerID = trJ.sorting_layer_id;
            tmr.sortingOrder = trJ.sorting_order;
            tmr.chunkSize = new Vector3Int(trJ.chunk_size.x, trJ.chunk_size.y, trJ.chunk_size.z);
            tmr.sortOrder = (TilemapRenderer.SortOrder)trJ.sort_order;
            tmr.mode = (TilemapRenderer.Mode)trJ.mode;
            tmr.maskInteraction = (SpriteMaskInteraction)trJ.mask_interaction;

            // Bulk set tiles
            var slots = td.tilemap.tiles;
            var positions = new Vector3Int[slots.Length];
            var tileArr   = new TileBase[slots.Length];
            var assetArr  = td.tilemap.tile_asset_array;
            for (int i = 0; i < slots.Length; i++)
            {
                positions[i] = new Vector3Int(slots[i].x, slots[i].y, slots[i].z);
                var assetIdx = slots[i].tile_index;
                if (assetIdx >= 0 && assetIdx < assetArr.Length)
                {
                    var tilePid = assetArr[assetIdx].tile_pid;
                    if (tileByPid.TryGetValue(tilePid, out var tb)) tileArr[i] = tb;
                }
            }
            tm.SetTiles(positions, tileArr);
            Debug.Log($"[KTO_MapImporter]   Tilemap: {slots.Length} tiles placed");
        }

        // ------------------------------------------------------------
        static void AttachAnimations(AnimationsJson ad, Dictionary<long, GameObject> goByPid,
                                     Dictionary<long, Sprite> spriteByPid)
        {
            foreach (var a in ad.items)
            {
                if (!goByPid.TryGetValue(a.go_pid, out var go)) continue;
                var sal = go.AddComponent<SpriteAnimationLoop>();
                sal._Interval = a.interval;
                if (a.sprite_pids != null)
                {
                    var list = new List<Sprite>(a.sprite_pids.Length);
                    foreach (var sp in a.sprite_pids)
                    {
                        if (spriteByPid.TryGetValue(sp, out var s)) list.Add(s);
                    }
                    sal._Sprites = list.ToArray();
                }
                sal.enabled = a.enabled;
            }
        }

        // ------------------------------------------------------------
        static void AttachRegions(RegionsJson rd, Dictionary<long, GameObject> goByPid,
                                  Dictionary<long, RegionRepresent> regionMbByPid)
        {
            foreach (var r in rd.items)
            {
                if (!goByPid.TryGetValue(r.go_pid, out var go)) continue;
                var rr = go.AddComponent<RegionRepresent>();
                rr.RuntimeObjIdList = r.runtime_obj_id_list ?? new int[0];
                if (r.runtime_obj_pids != null)
                {
                    var list = new List<GameObject>(r.runtime_obj_pids.Length);
                    foreach (var p in r.runtime_obj_pids)
                    {
                        if (goByPid.TryGetValue(p, out var g)) list.Add(g);
                    }
                    rr.RuntimeObjList = list.ToArray();
                }
                rr.enabled = r.enabled;
                regionMbByPid[r.path_id] = rr;
            }
        }

        // ------------------------------------------------------------
        static void AttachSceneComponents(MetaJson meta, Dictionary<long, GameObject> goByPid, string mapRoot,
                                          Dictionary<long, RegionRepresent> regionMbByPid)
        {
            if (meta.scene_info != null && goByPid.TryGetValue(meta.scene_info.go_pid, out var si_go))
            {
                var si = si_go.AddComponent<SceneInfo>();
                var mr = meta.scene_info.map_rect;
                si.MapRect = new SceneInfo.Rect { Left = mr.left, Top = mr.top, Right = mr.right, Bottom = mr.bottom };
                si.DrawAllRepresentArea   = meta.scene_info.draw_all_represent_area != 0;
                si.DrawAllRepresentRegion = meta.scene_info.draw_all_represent_region != 0;
                si.DrawCurPlayerArea      = meta.scene_info.draw_cur_player_area != 0;
                si.DrawCurRegion          = meta.scene_info.draw_cur_region != 0;
                si.DrawCurArea            = meta.scene_info.draw_cur_area != 0;
                si.DrawCurAreaCell        = meta.scene_info.draw_cur_area_cell != 0;
                si.DrawCurRepresentArea   = meta.scene_info.draw_cur_represent_area != 0;
                si.DrawObstacle           = meta.scene_info.draw_obstacle != 0;
                si.DrawTrap               = meta.scene_info.draw_trap != 0;
                si.DrawDynObst            = meta.scene_info.draw_dyn_obst != 0;
            }

            if (meta.scene_represent != null && goByPid.TryGetValue(meta.scene_represent.go_pid, out var sr_go))
            {
                var sr = sr_go.AddComponent<SceneRepresent>();
                sr.MapName = meta.scene_represent.map_name ?? "";
                sr.RegionIdList = meta.scene_represent.region_id_list ?? new int[0];
                if (meta.scene_represent.region_list_pids != null)
                {
                    // The bundle stores PPtrs to Region GameObjects, not to the
                    // RegionRepresent component directly. Resolve via goByPid.
                    var list = new List<RegionRepresent>(meta.scene_represent.region_list_pids.Length);
                    foreach (var rp in meta.scene_represent.region_list_pids)
                    {
                        if (goByPid.TryGetValue(rp, out var rgo))
                        {
                            var rrComp = rgo.GetComponent<RegionRepresent>();
                            if (rrComp != null) list.Add(rrComp);
                        }
                    }
                    sr.RegionList = list.ToArray();
                }
                // BuildinObjJson is large — load from file.
                var buildinPath = $"{mapRoot}/Data/BuildinObj.json.txt";
                var buildinAsset = AssetDatabase.LoadAssetAtPath<TextAsset>(buildinPath);
                if (buildinAsset != null) sr.BuildinObjJson = buildinAsset.text;
            }

            if (meta.scene_obstacle != null && goByPid.TryGetValue(meta.scene_obstacle.go_pid, out var sof_go))
            {
                var sof = sof_go.AddComponent<SceneObstacleFile>();
                var textPath = $"{mapRoot}/obstacle.bytes";
                var textAsset = AssetDatabase.LoadAssetAtPath<TextAsset>(textPath);
                if (textAsset != null) sof._Text = textAsset;
            }
        }
    }
}
#endif
