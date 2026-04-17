// =======================================================================
//  ResourceCacheData.cs — Loader cache entry with ref counting (Phase R5)
//
//  Source: _shared/DecompiledSource/ResourceCacheData.cs (field layout)
//  IL2CPP: KTO_DecompiledReference/_root/ResourceCacheData.c (method bodies)
//
//  Tracks a CommonLoader with reference counting and last-use time.
//  Used by ResourceCache (the loader-level cache) to know when a
//  loaded bundle/asset can be released.
// =======================================================================

using System;

namespace KTO.Resource
{
    public class ResourceCacheData : IComparable<ResourceCacheData>
    {
        // Source: field offsets 0x10-0x20
        public CommonLoader loader;     // 0x10
        public long lastUseTime;        // 0x18
        int _refCount;                  // 0x20

        // Source: IL2CPP ResourceCacheData__AddRef (0x01813BF8)
        //   refCount++
        public void AddRef()
        {
            _refCount++;
        }

        // Source: IL2CPP ResourceCacheData__RemoveRef (0x01813BFC)
        //   refCount--
        public void RemoveRef()
        {
            _refCount--;
        }

        // Source: IL2CPP ResourceCacheData__GetRefCount (0x01813C00)
        //   return refCount
        public int GetRefCount()
        {
            return _refCount;
        }

        // Source: IL2CPP ResourceCacheData__CompareTo (0x01800FB1)
        //   Compare by lastUseTime (ascending — oldest first for GC)
        public int CompareTo(ResourceCacheData other)
        {
            if (other == null) return -1;
            return lastUseTime.CompareTo(other.lastUseTime);
        }
    }
}
