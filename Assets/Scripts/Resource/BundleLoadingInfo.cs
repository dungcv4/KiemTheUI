// =======================================================================
//  BundleLoadingInfo.cs — Async bundle load state (Phase R1.2)
//
//  Source: _shared/DecompiledSource/BundleLoadingInfo.cs
//         _shared/DecompiledSource/BundleLoadingCallBackInfo.cs
//
//  Tracks an in-progress AssetBundleCreateRequest and queued callbacks
//  that should fire when loading completes.
// =======================================================================

using System;
using System.Collections.Generic;
using UnityEngine;

namespace KTO.Resource
{
    /// <summary>Delegate for bundle load completion callbacks.</summary>
    /// <param name="ab">The loaded AssetBundle (null on failure).</param>
    /// <param name="param">User-supplied parameters from the load request.</param>
    public delegate void OnFinishLoadBundle(AssetBundle ab, object[] param);

    public class BundleLoadingInfo
    {
        /// <summary>The loaded bundle (null until loading completes).</summary>
        public AssetBundle bundle;

        /// <summary>Unity's async load request handle.</summary>
        public AssetBundleCreateRequest request;

        /// <summary>Queued callbacks waiting for this bundle to load.</summary>
        public List<BundleLoadingCallBackInfo> loadCallBack;

        /// <summary>Whether this is a root bundle (not a dependency).</summary>
        public bool isRootBundle;

        public BundleLoadingInfo()
        {
            loadCallBack = new List<BundleLoadingCallBackInfo>();
        }
    }

    public class BundleLoadingCallBackInfo
    {
        /// <summary>Unique request ID for tracking/cancellation.</summary>
        public Guid requestId;

        /// <summary>Callback to invoke when bundle is ready.</summary>
        public OnFinishLoadBundle callBackFunc;

        /// <summary>User-supplied parameters to pass to callback.</summary>
        public object[] callBackParam;
    }
}
