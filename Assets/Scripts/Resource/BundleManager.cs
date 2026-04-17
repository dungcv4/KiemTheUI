// =======================================================================
//  BundleManager.cs — AssetBundle lifecycle manager (Phase R1.3)
//
//  Source: _shared/DecompiledSource/BundleManager.cs (field layout)
//  IL2CPP: KTO_DecompiledReference/_root/BundleManager.c (method bodies)
//
//  Original architecture:
//    - Static singleton managing all loaded/loading AssetBundles
//    - Init() loads the AssetBundleManifest for dependency resolution
//    - LoadBundle() loads a bundle + all its dependencies
//    - Update() polls async requests and fires callbacks
//    - ReleaseBundle() decrements refCount; bundles GC'd when unused
//    - s_bundlePool caches loaded bundles; s_loadingBundle tracks in-progress
//
//  NOTE: The original uses FileAbInfo (a compiled string table mapping
//  asset paths → bundle paths). For our project, we use a simpler
//  directory-based mapping since we control the bundle build pipeline.
// =======================================================================

using System;
using System.Collections.Generic;
using UnityEngine;

namespace KTO.Resource
{
    public static class BundleManager
    {
        // Source: BundleManager.cs static fields

        /// <summary>Loaded bundles keyed by bundle path.</summary>
        static Dictionary<string, BundleInfo> s_bundlePool
            = new Dictionary<string, BundleInfo>();

        /// <summary>Set of bundle paths currently being loaded.</summary>
        static HashSet<string> s_loadingBundle
            = new HashSet<string>();

        /// <summary>In-progress async load requests.</summary>
        static Dictionary<string, BundleLoadingInfo> s_loadingBundleInfo
            = new Dictionary<string, BundleLoadingInfo>();

        /// <summary>Bundles that finished loading this frame (for batch callback).</summary>
        static List<string> s_loadingFinishBundle
            = new List<string>();

        /// <summary>Unity's manifest for dependency resolution.</summary>
        static AssetBundleManifest s_assetBundleManifest;

        /// <summary>Whether the manifest has been loaded.</summary>
        static bool s_isLoadBundleManifest;

        /// <summary>Bundle type cache (path → AbType).</summary>
        static Dictionary<string, AbType> s_abTypeInfo
            = new Dictionary<string, AbType>();

        /// <summary>Temporary set for collecting dependencies (avoid alloc).</summary>
        static HashSet<string> s_tempDependencies = new HashSet<string>();

        static bool s_initialized;

        // =================================================================
        //  Init — Load the AssetBundleManifest
        //
        //  Source: IL2CPP BundleManager__Init (0x01906582)
        //    Loads the platform manifest bundle ("Android")
        //    which contains the dependency graph for all bundles.
        // =================================================================
        public static void Init()
        {
            if (s_initialized) return;
            s_initialized = true;

            ResourceDef.Init();
            _PreLoadManifest();
        }

        // =================================================================
        //  _PreLoadManifest — Load the AssetBundleManifest
        //
        //  Source: IL2CPP BundleManager___PreLoadManifest
        //    Loads "{StreamingResPath}/Android" (the manifest bundle)
        //    then extracts AssetBundleManifest from it.
        // =================================================================
        private static void _PreLoadManifest()
        {
            if (s_isLoadBundleManifest) return;

            string platform = ResourceDef.GetBuildPlatformName();
            string manifestPath = ResourceDef.GetResourceFullPath(platform, false);

            if (string.IsNullOrEmpty(manifestPath))
            {
                Debug.LogWarning($"[BundleManager] Manifest bundle not found: {platform}");
                Debug.LogWarning("[BundleManager] Bundle loading will work without dependencies. " +
                    "Run 'KTO → Build → Build All Bundles' to generate the manifest.");
                return;
            }

            var manifestBundle = AssetBundle.LoadFromFile(manifestPath);
            if (manifestBundle == null)
            {
                Debug.LogError($"[BundleManager] Failed to load manifest bundle: {manifestPath}");
                return;
            }

            s_assetBundleManifest = manifestBundle.LoadAsset<AssetBundleManifest>("AssetBundleManifest");
            manifestBundle.Unload(false);

            if (s_assetBundleManifest != null)
            {
                s_isLoadBundleManifest = true;
                Debug.Log("[BundleManager] Manifest loaded successfully");
            }
            else
            {
                Debug.LogError("[BundleManager] AssetBundleManifest not found in manifest bundle");
            }
        }

        // =================================================================
        //  LoadBundle — Load a bundle (with dependencies)
        //
        //  Source: IL2CPP BundleManager__LoadBundle (0x01906...)
        //    1. Check if already loaded in s_bundlePool → increment refCount
        //    2. Check if currently loading → add callback to waiting list
        //    3. Load all dependencies first (recursive)
        //    4. Start async/sync load of the actual bundle
        //    5. Return a Guid for tracking the request
        // =================================================================
        public static Guid LoadBundle(string parentBundlePath, string bundlePath,
            LoaderMode loaderMode, OnFinishLoadBundle callBack, object[] param)
        {
            if (string.IsNullOrEmpty(bundlePath))
            {
                callBack?.Invoke(null, param);
                return Guid.Empty;
            }

            var requestId = Guid.NewGuid();

            // 1. Already loaded? → return immediately
            if (s_bundlePool.TryGetValue(bundlePath, out var existingInfo))
            {
                existingInfo.refCount++;
                existingInfo.isRootBundle = true;
                callBack?.Invoke(existingInfo.bundle, param);
                return requestId;
            }

            // 2. Currently loading? → queue callback
            if (s_loadingBundleInfo.TryGetValue(bundlePath, out var loadingInfo))
            {
                loadingInfo.loadCallBack.Add(new BundleLoadingCallBackInfo
                {
                    requestId = requestId,
                    callBackFunc = callBack,
                    callBackParam = param
                });
                return requestId;
            }

            // 3. Load dependencies first
            var deps = GetAllDependencies(bundlePath);
            if (deps != null)
            {
                foreach (var dep in deps)
                {
                    if (!s_bundlePool.ContainsKey(dep) && !s_loadingBundle.Contains(dep))
                    {
                        LoadBundle(bundlePath, dep, loaderMode, null, null);
                    }
                    else if (s_bundlePool.TryGetValue(dep, out var depInfo))
                    {
                        depInfo.refCount++;
                    }
                }
            }

            // 4. Start loading this bundle
            s_loadingBundle.Add(bundlePath);

            var newLoadInfo = new BundleLoadingInfo { isRootBundle = true };
            newLoadInfo.loadCallBack.Add(new BundleLoadingCallBackInfo
            {
                requestId = requestId,
                callBackFunc = callBack,
                callBackParam = param
            });

            string fullPath = ResourceDef.GetResourceFullPath(bundlePath, false);
            if (string.IsNullOrEmpty(fullPath))
            {
                Debug.LogWarning($"[BundleManager] Bundle not found: {bundlePath}");
                s_loadingBundle.Remove(bundlePath);
                callBack?.Invoke(null, param);
                return requestId;
            }

            if (loaderMode == LoaderMode.Sync)
            {
                // Sync load
                var ab = AssetBundle.LoadFromFile(fullPath);
                _OnBundleLoaded(bundlePath, ab, newLoadInfo);
            }
            else
            {
                // Async load
                var request = AssetBundle.LoadFromFileAsync(fullPath);
                newLoadInfo.request = request;
                s_loadingBundleInfo[bundlePath] = newLoadInfo;
            }

            return requestId;
        }

        // =================================================================
        //  Update — Poll async loads, fire callbacks on completion
        //
        //  Source: IL2CPP BundleManager__Update (0x01906c8c)
        //    Iterates s_loadingBundleInfo, checks isDone on each request.
        //    When done: stores in s_bundlePool, fires all queued callbacks.
        //    Must be called every frame (typically from a MonoBehaviour).
        // =================================================================
        public static void Update()
        {
            if (s_loadingBundleInfo.Count == 0) return;

            s_loadingFinishBundle.Clear();

            foreach (var kvp in s_loadingBundleInfo)
            {
                if (kvp.Value.request != null && kvp.Value.request.isDone)
                {
                    s_loadingFinishBundle.Add(kvp.Key);
                }
            }

            for (int i = 0; i < s_loadingFinishBundle.Count; i++)
            {
                string bundlePath = s_loadingFinishBundle[i];
                if (s_loadingBundleInfo.TryGetValue(bundlePath, out var info))
                {
                    var ab = info.request?.assetBundle;
                    s_loadingBundleInfo.Remove(bundlePath);
                    _OnBundleLoaded(bundlePath, ab, info);
                }
            }
        }

        private static void _OnBundleLoaded(string bundlePath, AssetBundle ab, BundleLoadingInfo loadInfo)
        {
            s_loadingBundle.Remove(bundlePath);

            if (ab != null)
            {
                var bundleInfo = new BundleInfo
                {
                    bundlePath = bundlePath,
                    bundle = ab,
                    type = GetBundleType(bundlePath),
                    refCount = 1,
                    lastUnUseTime = 0f,
                    isRootBundle = loadInfo.isRootBundle
                };
                s_bundlePool[bundlePath] = bundleInfo;
            }

            // Fire all queued callbacks
            if (loadInfo.loadCallBack != null)
            {
                for (int i = 0; i < loadInfo.loadCallBack.Count; i++)
                {
                    var cbInfo = loadInfo.loadCallBack[i];
                    try
                    {
                        cbInfo.callBackFunc?.Invoke(ab, cbInfo.callBackParam);
                    }
                    catch (Exception ex)
                    {
                        Debug.LogException(ex);
                    }
                }
            }
        }

        // =================================================================
        //  ReleaseBundle — Decrement ref count, unload when unused
        //
        //  Source: IL2CPP BundleManager__ReleaseBundle (0x019081c3)
        //    Decrements refCount. Does NOT immediately unload — GC handles that.
        //    Skips built-in bundles (shader, font).
        // =================================================================
        public static void ReleaseBundle(string parentBundlePath, string bundlePath,
            AssetBundle bundle, Guid requestId)
        {
            if (string.IsNullOrEmpty(bundlePath)) return;

            if (s_bundlePool.TryGetValue(bundlePath, out var info))
            {
                info.refCount--;
                if (info.refCount <= 0)
                {
                    info.refCount = 0;
                    info.lastUnUseTime = Time.realtimeSinceStartup;
                }
            }

            // Also release dependencies
            var deps = GetAllDependencies(bundlePath);
            if (deps != null)
            {
                foreach (var dep in deps)
                {
                    if (s_bundlePool.TryGetValue(dep, out var depInfo))
                    {
                        depInfo.refCount--;
                        if (depInfo.refCount <= 0)
                        {
                            depInfo.refCount = 0;
                            depInfo.lastUnUseTime = Time.realtimeSinceStartup;
                        }
                    }
                }
            }
        }

        // =================================================================
        //  GetBundle — Get an already-loaded bundle (sync access)
        //
        //  Source: IL2CPP BundleManager__GetBundle (0x01908569)
        // =================================================================
        public static AssetBundle GetBundle(string bundlePath)
        {
            if (s_bundlePool.TryGetValue(bundlePath, out var info))
            {
                return info.bundle;
            }
            return null;
        }

        /// <summary>Check if a bundle is loaded or loading.</summary>
        public static bool HasBundle(string bundlePath)
        {
            return s_bundlePool.ContainsKey(bundlePath) || s_loadingBundle.Contains(bundlePath);
        }

        // =================================================================
        //  GetAllDependencies — Get bundle dependency list from manifest
        //
        //  Source: BundleManager.cs — reads AssetBundleManifest
        // =================================================================
        public static string[] GetAllDependencies(string url)
        {
            if (!s_isLoadBundleManifest || s_assetBundleManifest == null)
                return null;

            return s_assetBundleManifest.GetAllDependencies(url);
        }

        // =================================================================
        //  GetBundleType — Determine AbType from bundle path
        //
        //  Source: IL2CPP BundleManager__GetBundleType (0x01908f31)
        //    Infers type from path prefix.
        // =================================================================
        public static AbType GetBundleType(string bundlePath)
        {
            if (string.IsNullOrEmpty(bundlePath)) return AbType.none;

            if (s_abTypeInfo.TryGetValue(bundlePath, out var cached))
                return cached;

            // Infer from path prefix
            // Source: original uses FileAbInfo lookup; we infer from directory structure
            AbType type = AbType.none;
            if (bundlePath.StartsWith("ui/atlas/")) type = AbType.atlas;
            else if (bundlePath.StartsWith("ui/views/")) type = AbType.prefab;
            else if (bundlePath.StartsWith("font/")) type = AbType.font;
            else if (bundlePath.StartsWith("npc/")) type = AbType.sprite;
            else if (bundlePath.StartsWith("player/")) type = AbType.sprite;
            else if (bundlePath.StartsWith("maps/")) type = AbType.unity;
            else if (bundlePath.StartsWith("sound/")) type = AbType.sound;
            else if (bundlePath.StartsWith("skill/")) type = AbType.common;
            else if (bundlePath.StartsWith("shader/")) type = AbType.shader;

            s_abTypeInfo[bundlePath] = type;
            return type;
        }

        // =================================================================
        //  GarbageCollect — Unload unused bundles
        //
        //  Source: IL2CPP BundleManager__Update (partial — GC logic)
        //    Unloads bundles with refCount == 0 and age > threshold.
        // =================================================================
        public static void GarbageCollect(float maxUnusedAge = 60f)
        {
            var toRemove = new List<string>();
            float now = Time.realtimeSinceStartup;

            foreach (var kvp in s_bundlePool)
            {
                var info = kvp.Value;
                if (info.refCount <= 0 && info.lastUnUseTime > 0 &&
                    (now - info.lastUnUseTime) > maxUnusedAge)
                {
                    toRemove.Add(kvp.Key);
                }
            }

            foreach (var path in toRemove)
            {
                if (s_bundlePool.TryGetValue(path, out var info))
                {
                    if (info.bundle != null)
                    {
                        info.bundle.Unload(false);
                        Debug.Log($"[BundleManager] GC unloaded: {path}");
                    }
                    s_bundlePool.Remove(path);
                }
            }
        }

        /// <summary>Unload all bundles (e.g. on application quit).</summary>
        public static void UnloadAll()
        {
            foreach (var kvp in s_bundlePool)
            {
                if (kvp.Value.bundle != null)
                    kvp.Value.bundle.Unload(true);
            }
            s_bundlePool.Clear();
            s_loadingBundle.Clear();
            s_loadingBundleInfo.Clear();
            s_abTypeInfo.Clear();
            s_initialized = false;
            s_isLoadBundleManifest = false;
            s_assetBundleManifest = null;
        }

        /// <summary>Debug: log all loaded bundles.</summary>
        public static void DebugLogState()
        {
            Debug.Log($"[BundleManager] Loaded: {s_bundlePool.Count}, Loading: {s_loadingBundle.Count}");
            foreach (var kvp in s_bundlePool)
            {
                Debug.Log($"  [{kvp.Value.type}] {kvp.Key} ref={kvp.Value.refCount}");
            }
        }
    }
}
