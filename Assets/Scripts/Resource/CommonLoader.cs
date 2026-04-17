// =======================================================================
//  CommonLoader.cs — Combined bundle + asset loader (Phase R1.4)
//
//  Source: _shared/DecompiledSource/CommonLoader.cs (field layout)
//  IL2CPP: KTO_DecompiledReference/_root/CommonLoader.c (method bodies)
//
//  High-level loader that:
//  1. Loads the AssetBundle via BundleLoader
//  2. Extracts the target asset via AssetLoader
//  3. Returns the asset to the caller via callback
//
//  This is what LoaderManager.Load() returns.
// =======================================================================

using System.Collections;
using UnityEngine;

namespace KTO.Resource
{
    public class CommonLoader : BaseLoader
    {
        // Source: CommonLoader.cs fields
        private Object m_asset;
        private BundleLoader m_assetBundleLoader;
        private AssetLoader m_assetLoader;

        // Source: CommonLoader.cs properties
        public Object Asset
        {
            get => m_asset;
            set => m_asset = value;
        }

        public string BundlePath { get; private set; }
        public AbType BundleType { get; private set; }

        // =================================================================
        //  Init — Start the bundle→asset loading pipeline
        //
        //  Source: IL2CPP CommonLoader__Init
        //    1. Resolve bundle path from asset path via BundleManager
        //    2. Load the bundle (async or sync)
        //    3. When bundle ready, load the asset from it
        //    4. Fire callback with the loaded asset
        //
        //  args[0] = (optional) bundle path override
        //  args[1] = (optional) System.Type of asset
        // =================================================================
        public override void Init(string url, LoaderMode loaderMode, params object[] args)
        {
            base.Init(url, loaderMode, args);
            IsLoading = true;

            // Determine bundle path
            // Source: IL2CPP — uses BundleManager.GetBundlePathFromAssetPath
            string bundlePath = null;
            System.Type assetType = null;

            if (args != null && args.Length >= 1 && args[0] is string bp)
                bundlePath = bp;
            if (args != null && args.Length >= 2 && args[1] is System.Type at)
                assetType = at;

            if (string.IsNullOrEmpty(bundlePath))
                bundlePath = url;  // URL is the bundle path itself

            BundlePath = bundlePath;

            // Load the bundle
            m_assetBundleLoader = BundleLoader.Load(bundlePath, loaderMode);

            if (m_assetBundleLoader.IsCompleted)
            {
                // Sync path — bundle already loaded
                _OnBundleLoaded(m_assetBundleLoader.Bundle, url, assetType);
            }
            else
            {
                // Async path — wait for bundle
                string capturedUrl = url;
                System.Type capturedType = assetType;
                m_assetBundleLoader.AddCallback((result) =>
                {
                    var ab = result as AssetBundle;
                    _OnBundleLoaded(ab, capturedUrl, capturedType);
                });
            }
        }

        private void _OnBundleLoaded(AssetBundle bundle, string assetUrl, System.Type assetType)
        {
            if (bundle == null)
            {
                Debug.LogWarning($"[CommonLoader] Bundle load failed for: {BundlePath}");
                OnFinish(null);
                return;
            }

            // Load the specific asset from the bundle
            string assetName = System.IO.Path.GetFileNameWithoutExtension(assetUrl);

            Object asset;
            if (assetType != null)
                asset = bundle.LoadAsset(assetName, assetType);
            else
                asset = bundle.LoadAsset(assetName);

            m_asset = asset;
            OnFinish(asset);
        }

        public override void ReInit(LoaderMode loaderMode, params object[] args)
        {
            base.ReInit(loaderMode, args);
        }

        protected override void OnFinish(object resultObj)
        {
            IsLoading = false;
            IsCompleted = true;
            base.OnFinish(resultObj);
        }

        public override void DoDispose()
        {
            if (m_assetBundleLoader != null)
            {
                m_assetBundleLoader.Release();
                m_assetBundleLoader = null;
            }
            m_assetLoader = null;
            m_asset = null;
            base.DoDispose();
        }

        public override bool NeedUnload()
        {
            return true;
        }
    }
}
