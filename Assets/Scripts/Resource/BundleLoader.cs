// =======================================================================
//  BundleLoader.cs — AssetBundle file loader (Phase R1.4)
//
//  Source: _shared/DecompiledSource/BundleLoader.cs (field layout)
//  IL2CPP: KTO_DecompiledReference/_root/BundleLoader.c (method bodies)
//
//  Loads an .ab file via AssetBundle.LoadFromFileAsync (or sync).
//  Handles dependency loading through BundleManager.
// =======================================================================

using System;
using System.Collections;
using UnityEngine;

namespace KTO.Resource
{
    public class BundleLoader : BaseLoader
    {
        // Source: BundleLoader.cs fields
        private Guid _RequestID;
        private IEnumerator _InitEnumerator;
        private bool _LoadingFinished;

        // Source: BundleLoader.cs property
        public AssetBundle Bundle { get; private set; }

        // =================================================================
        //  Load — Static factory method
        //
        //  Source: BundleLoader.cs — static BundleLoader Load(url, mode)
        // =================================================================
        public static BundleLoader Load(string url, LoaderMode loaderMode)
        {
            var loader = new BundleLoader();
            loader.Init(url, loaderMode);
            return loader;
        }

        // =================================================================
        //  Init — Start loading the bundle
        //
        //  Source: IL2CPP BundleLoader__Init
        //    Resolves full path via ResourceDef, then either:
        //    - Sync: AssetBundle.LoadFromFile
        //    - Async: AssetBundle.LoadFromFileAsync → poll in Update
        // =================================================================
        public override void Init(string url, LoaderMode loaderMode, params object[] args)
        {
            base.Init(url, loaderMode, args);
            IsLoading = true;
            _LoadingFinished = false;

            // Resolve the bundle's full file path
            // Source: IL2CPP BundleManager___GetFullBundlePath (0x01908adb)
            string fullPath = ResourceDef.GetResourceFullPath(url, false);

            if (string.IsNullOrEmpty(fullPath))
            {
                Debug.LogWarning($"[BundleLoader] Bundle not found: {url}");
                OnFinish(null);
                return;
            }

            if (loaderMode == LoaderMode.Sync)
            {
                // Source: IL2CPP — sync path uses AssetBundle.LoadFromFile
                var ab = AssetBundle.LoadFromFile(fullPath);
                Bundle = ab;
                OnFinish(ab);
            }
            else
            {
                // Source: IL2CPP — async path uses AssetBundleCreateRequest
                // BundleManager.Update polls isDone and fires callbacks
                _RequestID = Guid.NewGuid();

                var request = AssetBundle.LoadFromFileAsync(fullPath);
                if (request == null)
                {
                    Debug.LogError($"[BundleLoader] LoadFromFileAsync returned null: {fullPath}");
                    OnFinish(null);
                    return;
                }

                request.completed += (op) =>
                {
                    Bundle = request.assetBundle;
                    _LoadingFinished = true;
                    OnFinish(Bundle);
                };
            }
        }

        public override void ReInit(LoaderMode loaderMode, params object[] args)
        {
            base.ReInit(loaderMode, args);
        }

        protected override void OnFinish(object resultObj)
        {
            _LoadingFinished = true;
            IsLoading = false;
            IsCompleted = true;
            base.OnFinish(resultObj);
        }

        // =================================================================
        //  DoDispose — Unload the bundle
        //
        //  Source: BundleLoader.cs — override DoDispose
        // =================================================================
        public override void DoDispose()
        {
            if (Bundle != null)
            {
                Bundle.Unload(false);
                Bundle = null;
            }
            base.DoDispose();
        }
    }
}
