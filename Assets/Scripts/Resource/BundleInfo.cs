// =======================================================================
//  BundleInfo.cs — Loaded bundle metadata (Phase R1.2)
//
//  Source: _shared/DecompiledSource/BundleInfo.cs
//
//  Tracks a loaded AssetBundle's lifecycle: reference count for
//  determining when to unload, lastUnUseTime for GC decisions,
//  AbType for specialized handling.
// =======================================================================

using System;
using UnityEngine;

namespace KTO.Resource
{
    public class BundleInfo : IComparable<BundleInfo>
    {
        /// <summary>Full bundle path (e.g. "ui/atlas/guide/res_a_1.ab").</summary>
        public string bundlePath;

        /// <summary>The loaded AssetBundle instance.</summary>
        public AssetBundle bundle;

        /// <summary>Bundle type classification.</summary>
        public AbType type;

        /// <summary>Number of active references. Bundle can be unloaded when 0.</summary>
        public int refCount;

        /// <summary>Time.realtimeSinceStartup when refCount last reached 0.
        /// Used by GC to decide when to unload unused bundles.</summary>
        public float lastUnUseTime;

        /// <summary>True if this bundle was directly requested (not a dependency).</summary>
        public bool isRootBundle;

        // Source: BundleInfo.cs — IComparable<BundleInfo>
        // Sort by lastUnUseTime for GC prioritization (oldest unused first).
        public int CompareTo(BundleInfo other)
        {
            if (other == null) return 1;
            return lastUnUseTime.CompareTo(other.lastUnUseTime);
        }
    }
}
