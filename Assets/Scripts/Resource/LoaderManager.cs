// =======================================================================
//  LoaderManager.cs — Loader instance pool (Phase R1.4)
//
//  Source: _shared/DecompiledSource/LoaderManager.cs (field layout)
//  IL2CPP: KTO_DecompiledReference/_root/LoaderManager.c (method bodies)
//
//  Original architecture:
//    - Static pool keyed by (Type, URL) → BaseLoader
//    - Load() creates or reuses a CommonLoader for a given URL
//    - GetLoader<T>() generic factory with ref count management
//    - ReleaseLoader() decrements ref count and returns to pool
//
//  This is the primary API that game code uses to load assets.
// =======================================================================

using System;
using System.Collections.Generic;
using UnityEngine;

namespace KTO.Resource
{
    public static class LoaderManager
    {
        // Source: LoaderManager.cs static field
        // Pool structure: Type → (URL → loader instance)
        // Allows multiple loader types to coexist for the same URL.
        private static readonly Dictionary<Type, Dictionary<string, BaseLoader>> _LoaderPool
            = new Dictionary<Type, Dictionary<string, BaseLoader>>();

        // =================================================================
        //  Load — Create or reuse a CommonLoader for an asset URL
        //
        //  Source: IL2CPP LoaderManager__Load (0x0190257f)
        //    Delegates to GetLoader<CommonLoader>(url, callback, mode)
        //
        //  url:      Bundle path (e.g. "ui/views/res_p_91.ab")
        //  mode:     Async or Sync
        //  callBack: Invoked with the loaded Object when ready
        // =================================================================
        public static CommonLoader Load(string url, LoaderMode loaderMode,
            BaseLoader.LoaderCallBack callBack)
        {
            return GetLoader<CommonLoader>(url, callBack, loaderMode);
        }

        // =================================================================
        //  GetLoader<T> — Generic loader factory with pooling
        //
        //  Source: IL2CPP LoaderManager__GetLoader<object> (0x01ed59f9)
        //    1. Look up pool for type T
        //    2. If loader exists for URL: increment RefCount, add callback
        //    3. If new: create instance, Init(url, mode, args), add to pool
        //    4. Return the loader
        // =================================================================
        public static T GetLoader<T>(string url, BaseLoader.LoaderCallBack loaderCallBack,
            LoaderMode loaderMode, params object[] initArgs) where T : BaseLoader, new()
        {
            var type = typeof(T);

            // Get or create the sub-pool for this loader type
            if (!_LoaderPool.TryGetValue(type, out var urlPool))
            {
                urlPool = new Dictionary<string, BaseLoader>();
                _LoaderPool[type] = urlPool;
            }

            // Check for existing loader for this URL
            if (urlPool.TryGetValue(url, out var existing))
            {
                var typed = (T)existing;
                typed.RefCount++;
                typed.AddCallback(loaderCallBack);

                // If already completed, fire callback immediately
                if (typed.IsCompleted)
                {
                    loaderCallBack?.Invoke(typed.ResultObject);
                }

                return typed;
            }

            // Create new loader
            // Source: IL2CPP — Activator.CreateInstance<T>()
            var loader = new T();
            loader.RefCount = 1;
            loader.AddCallback(loaderCallBack);
            loader.Init(url, loaderMode, initArgs);

            urlPool[url] = loader;

            return loader;
        }

        // =================================================================
        //  ReleaseLoader — Return a loader to the pool / dispose it
        //
        //  Source: IL2CPP LoaderManager__ReleaseLoader (0x0190cb28)
        //    Calls loader.Release() which decrements RefCount.
        //    At RefCount 0, loader is disposed and removed from pool.
        // =================================================================
        public static void ReleaseLoader(BaseLoader loader)
        {
            if (loader == null) return;

            loader.Release();

            // Remove from pool if fully released
            if (loader.RefCount <= 0)
            {
                var type = loader.GetType();
                if (_LoaderPool.TryGetValue(type, out var urlPool))
                {
                    if (!string.IsNullOrEmpty(loader.Url))
                    {
                        urlPool.Remove(loader.Url);
                    }
                }
            }
        }

        /// <summary>Clear all loader pools (e.g. on scene unload).</summary>
        public static void ClearAll()
        {
            foreach (var kvp in _LoaderPool)
            {
                foreach (var loader in kvp.Value.Values)
                {
                    loader.DoDispose();
                }
                kvp.Value.Clear();
            }
            _LoaderPool.Clear();
        }
    }
}
