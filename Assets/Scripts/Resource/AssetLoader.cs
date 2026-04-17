// =======================================================================
//  AssetLoader.cs — Individual asset loader from a loaded bundle (Phase R1.4)
//
//  Source: _shared/DecompiledSource/AssetLoader.cs (field layout)
//  IL2CPP: KTO_DecompiledReference/_root/AssetLoader.c (method bodies)
//
//  Loads a specific asset (Sprite, Prefab, Font, etc.) from an already-
//  loaded AssetBundle. Used internally by CommonLoader after the bundle
//  is loaded by BundleLoader.
// =======================================================================

using UnityEngine;

namespace KTO.Resource
{
    public class AssetLoader : BaseLoader
    {
        // Source: AssetLoader.cs property
        public Object AssetObj { get; private set; }

        // =================================================================
        //  Load — Static factory
        //
        //  Source: AssetLoader.cs — static AssetLoader Load(url)
        // =================================================================
        public static AssetLoader Load(string url)
        {
            var loader = new AssetLoader();
            loader.Init(url, LoaderMode.Sync);
            return loader;
        }

        // =================================================================
        //  Init — Load asset from bundle by name
        //
        //  Source: IL2CPP AssetLoader__Init
        //    args[0] = AssetBundle to load from
        //    args[1] = (optional) System.Type of asset to load
        //    Extracts asset name from URL (last segment)
        // =================================================================
        public override void Init(string url, LoaderMode loaderMode, params object[] args)
        {
            base.Init(url, loaderMode, args);

            if (args == null || args.Length < 1 || !(args[0] is AssetBundle))
            {
                Debug.LogError($"[AssetLoader] Init requires AssetBundle as args[0], url={url}");
                OnFinish(null);
                return;
            }

            var bundle = (AssetBundle)args[0];

            // Extract asset name from URL path
            string assetName = System.IO.Path.GetFileNameWithoutExtension(url);

            Object asset;
            if (args.Length >= 2 && args[1] is System.Type assetType)
            {
                asset = bundle.LoadAsset(assetName, assetType);
            }
            else
            {
                asset = bundle.LoadAsset(assetName);
            }

            AssetObj = asset;
            OnFinish(asset);
        }

        public override void ReInit(LoaderMode loaderMode, params object[] args)
        {
            base.ReInit(loaderMode, args);
        }

        public override void DoDispose()
        {
            AssetObj = null;
            base.DoDispose();
        }
    }
}
