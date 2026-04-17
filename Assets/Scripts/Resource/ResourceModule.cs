// =======================================================================
//  ResourceModule.cs — High-level resource loading API (Phase R1.5)
//
//  Source: _shared/DecompiledSource/ResourceModule.cs (stub — field layout)
//  IL2CPP: KTO_DecompiledReference/_root/ResourceModule.c
//
//  This is the primary API that game code uses to load assets.
//  Wraps BundleManager/LoaderManager with type-safe helpers.
//
//  In editor mode (before bundles are built), falls back to AssetDatabase.
//  In builds, loads exclusively from AssetBundles.
//
//  Usage:
//    ResourceModule.LoadSprite("ui/atlas/guide/res_a_1.ab", "img_dialogbox", (s) => { ... });
//    ResourceModule.LoadPrefab("ui/views/res_p_91.ab", "UIHud", (go) => { ... });
// =======================================================================

using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

namespace KTO.Resource
{
    public static class ResourceModule
    {
        static bool s_initialized;

        // =================================================================
        //  Init — Initialize the resource system
        // =================================================================
        public static void Init()
        {
            if (s_initialized) return;
            s_initialized = true;

            ResourceDef.Init();
            BundleManager.Init();

            Debug.Log("[ResourceModule] Initialized");
        }

        // =================================================================
        //  Update — Must be called every frame for async loading
        // =================================================================
        public static void Update()
        {
            BundleManager.Update();
        }

        // =================================================================
        //  LoadPrefab — Load a UI prefab from a view bundle
        //
        //  bundlePath: e.g. "ui/views/res_p_91.ab"
        //  prefabName: e.g. "UIHud"
        //  callback:   receives the loaded GameObject prefab (or null)
        // =================================================================
        public static void LoadPrefab(string bundlePath, string prefabName,
            Action<GameObject> callback)
        {
#if UNITY_EDITOR
            // Editor fallback: try AssetDatabase first
            if (!BundleManager.HasBundle(bundlePath))
            {
                var go = _EditorLoadAsset<GameObject>(prefabName, "Assets/Prefabs");
                if (go != null)
                {
                    callback?.Invoke(go);
                    return;
                }
            }
#endif
            _LoadAssetFromBundle<GameObject>(bundlePath, prefabName, callback);
        }

        // =================================================================
        //  LoadSprite — Load a sprite from an atlas bundle
        //
        //  bundlePath: e.g. "ui/atlas/guide/res_a_1.ab"
        //  spriteName: e.g. "img_dialogbox"
        //  callback:   receives the loaded Sprite (or null)
        // =================================================================
        public static void LoadSprite(string bundlePath, string spriteName,
            Action<Sprite> callback)
        {
#if UNITY_EDITOR
            if (!BundleManager.HasBundle(bundlePath))
            {
                var s = _EditorLoadSprite(spriteName);
                if (s != null)
                {
                    callback?.Invoke(s);
                    return;
                }
            }
#endif
            _LoadAssetFromBundle<Sprite>(bundlePath, spriteName, callback);
        }

        // =================================================================
        //  LoadFont — Load a font from a font bundle
        //
        //  bundlePath: e.g. "font/res_f_1.ab"
        //  fontName:   e.g. "common_vi"
        //  callback:   receives the loaded Font (or null)
        // =================================================================
        public static void LoadFont(string bundlePath, string fontName,
            Action<Font> callback)
        {
#if UNITY_EDITOR
            if (!BundleManager.HasBundle(bundlePath))
            {
                var f = _EditorLoadAsset<Font>(fontName, "Assets/Font");
                if (f != null)
                {
                    callback?.Invoke(f);
                    return;
                }
            }
#endif
            _LoadAssetFromBundle<Font>(bundlePath, fontName, callback);
        }

        // =================================================================
        //  LoadTexture — Load a Texture2D from a bundle
        // =================================================================
        public static void LoadTexture(string bundlePath, string texName,
            Action<Texture2D> callback)
        {
#if UNITY_EDITOR
            if (!BundleManager.HasBundle(bundlePath))
            {
                var t = _EditorLoadAsset<Texture2D>(texName, "Assets/Sprite");
                if (t != null)
                {
                    callback?.Invoke(t);
                    return;
                }
            }
#endif
            _LoadAssetFromBundle<Texture2D>(bundlePath, texName, callback);
        }

        // =================================================================
        //  LoadAllSpritesFromBundle — Load all sprites from an atlas bundle
        //
        //  For NPC/player sprite loading: gets all sprites in a bundle at once.
        // =================================================================
        public static void LoadAllSpritesFromBundle(string bundlePath,
            Action<Sprite[]> callback)
        {
            Init();

            BundleManager.LoadBundle(null, bundlePath, LoaderMode.Async,
                (ab, param) =>
                {
                    if (ab == null)
                    {
                        callback?.Invoke(null);
                        return;
                    }
                    var sprites = ab.LoadAllAssets<Sprite>();
                    callback?.Invoke(sprites);
                }, null);
        }

        // =================================================================
        //  Internal: Load an asset from a bundle by name and type
        // =================================================================
        private static void _LoadAssetFromBundle<T>(string bundlePath, string assetName,
            Action<T> callback) where T : Object
        {
            Init();

            BundleManager.LoadBundle(null, bundlePath, LoaderMode.Async,
                (ab, param) =>
                {
                    if (ab == null)
                    {
                        Debug.LogWarning($"[ResourceModule] Bundle load failed: {bundlePath}");
                        callback?.Invoke(null);
                        return;
                    }

                    var asset = ab.LoadAsset<T>(assetName);
                    if (asset == null)
                    {
                        Debug.LogWarning($"[ResourceModule] Asset not found in bundle: " +
                            $"{assetName} in {bundlePath}");
                    }
                    callback?.Invoke(asset);
                }, null);
        }

        // =================================================================
        //  Sync versions — for when you need immediate results
        // =================================================================
        public static T LoadSync<T>(string bundlePath, string assetName) where T : Object
        {
            Init();

            string fullPath = ResourceDef.GetResourceFullPath(bundlePath, false);
            if (string.IsNullOrEmpty(fullPath))
            {
#if UNITY_EDITOR
                return _EditorLoadAsset<T>(assetName, "Assets");
#else
                return null;
#endif
            }

            // Check if already loaded via BundleManager
            var existingBundle = BundleManager.GetBundle(bundlePath);
            if (existingBundle != null)
                return existingBundle.LoadAsset<T>(assetName);

            // Load synchronously via BundleManager (registers in pool, handles dependencies)
            T result = null;
            BundleManager.LoadBundle(null, bundlePath, LoaderMode.Sync,
                (ab, param) =>
                {
                    if (ab != null)
                        result = ab.LoadAsset<T>(assetName);
                }, null);

            return result;
        }

        // =================================================================
        //  Editor fallback methods
        // =================================================================
#if UNITY_EDITOR
        static Dictionary<string, Sprite> _editorSpriteCache;

        static T _EditorLoadAsset<T>(string name, string searchFolder) where T : Object
        {
            var guids = UnityEditor.AssetDatabase.FindAssets(
                $"{name} t:{typeof(T).Name}",
                new[] { searchFolder });

            foreach (var guid in guids)
            {
                var path = UnityEditor.AssetDatabase.GUIDToAssetPath(guid);
                var asset = UnityEditor.AssetDatabase.LoadAssetAtPath<T>(path);
                if (asset != null && asset.name == name)
                    return asset;
            }
            return null;
        }

        static Sprite _EditorLoadSprite(string name)
        {
            if (_editorSpriteCache == null)
            {
                _editorSpriteCache = new Dictionary<string, Sprite>();
                var guids = UnityEditor.AssetDatabase.FindAssets(
                    "t:Sprite", new[] { "Assets/Sprite" });
                foreach (var g in guids)
                {
                    var p = UnityEditor.AssetDatabase.GUIDToAssetPath(g);
                    var s = UnityEditor.AssetDatabase.LoadAssetAtPath<Sprite>(p);
                    if (s != null && !_editorSpriteCache.ContainsKey(s.name))
                        _editorSpriteCache[s.name] = s;
                }
                Debug.Log($"[ResourceModule] Editor sprite cache: {_editorSpriteCache.Count} sprites");
            }

            Sprite result;
            _editorSpriteCache.TryGetValue(name, out result);
            return result;
        }
#endif

        // =================================================================
        //  LoadSpriteByName — Resolve sprite name to atlas bundle + load
        //
        //  DEVIATION — not a direct method in the original source
        //  Reason: Original uses BundleManager.s_fileAbInfo to resolve
        //  any asset path to its bundle. We use SpriteAtlasMap instead.
        //  This is the entry point for all "I have a sprite name, load it"
        //  calls (replaces AssetDatabase.FindAssets in runtime code).
        // =================================================================
        public static Sprite LoadSpriteByName(string spriteName)
        {
            if (string.IsNullOrEmpty(spriteName)) return null;
            Init();

            // Try SpriteAtlasMap (pre-built mapping + brute-force fallback)
            var sprite = SpriteAtlasMap.LoadSpriteByName(spriteName);
            if (sprite != null) return sprite;

#if UNITY_EDITOR
            // Editor fallback: AssetDatabase search
            return _EditorLoadSprite(spriteName);
#else
            return null;
#endif
        }

        // =================================================================
        //  LoadPrefabFromBundle — Load a prefab from a view bundle (sync)
        //
        //  In the original game, ALL UI prefabs come from bundles:
        //  ui/views/res_p_XX.ab → loaded via BundleManager
        //  This replaces AssetDatabase.LoadAssetAtPath<GameObject> at runtime.
        // =================================================================
        public static GameObject LoadPrefabSync(string bundlePath, string prefabName)
        {
            Init();

            // Try bundle first
            string fullPath = ResourceDef.GetResourceFullPath(bundlePath, false);
            if (!string.IsNullOrEmpty(fullPath))
            {
                var go = LoadSync<GameObject>(bundlePath, prefabName);
                if (go != null) return go;
            }

#if UNITY_EDITOR
            // Editor fallback
            return _EditorLoadAsset<GameObject>(prefabName, "Assets/Prefabs/Imported");
#else
            return null;
#endif
        }

        // =================================================================
        //  Release — Clean up
        // =================================================================
        public static void Release(string bundlePath)
        {
            BundleManager.ReleaseBundle(null, bundlePath, null, Guid.Empty);
        }

        public static void Shutdown()
        {
            LoaderManager.ClearAll();
            BundleManager.UnloadAll();
            s_initialized = false;
#if UNITY_EDITOR
            _editorSpriteCache = null;
#endif
            Debug.Log("[ResourceModule] Shutdown");
        }
    }
}
