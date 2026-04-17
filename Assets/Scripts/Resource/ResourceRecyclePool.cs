// =======================================================================
//  ResourceRecyclePool.cs — Object recycling pool (Phase R5)
//
//  Source: _shared/DecompiledSource/ResourceRecyclePool.cs (field layout)
//  IL2CPP: KTO_DecompiledReference/_root/ResourceRecyclePool.c (method bodies)
//
//  Original architecture:
//    - Pools recycled GameObjects in a LinkedList + HashSet for O(1) lookup
//    - Tracks LastUseTime (milliseconds since startup) for GC
//    - Despawn: deactivate GO, reparent under pool root, add to list
//    - Spawn: pop from front of list, unparent, return to caller
//    - DeleteRes: destroy one GO from front of list
//    - DeleteAll: destroy all pooled GOs
//    - CompareTo: sort by ResType first, then LastUseTime (for GC ordering)
// =======================================================================

using System;
using System.Collections.Generic;
using UnityEngine;

namespace KTO.Resource
{
    // Source: _shared/DecompiledSource/ResourceRecycleType.cs
    public enum ResourceRecycleType
    {
        Scene,
        Common
    }

    public class ResourceRecyclePool : IComparable<ResourceRecyclePool>
    {
        // Source: field offsets 0x10-0x38
        Transform _parentTrans;                              // 0x10
        readonly LinkedList<GameObject> _recycleResources;   // 0x18
        readonly HashSet<GameObject> _checkSameRecycleRes;   // 0x20

        static readonly List<GameObject> _prepareDestroyList = new List<GameObject>(); // 0x00 (static)

        // Properties from IL2CPP getter/setter at 0x28, 0x30, 0x38
        public string ResPath { get; private set; }                  // 0x28
        public long LastUseTime { get; private set; }                // 0x30
        public ResourceRecycleType ResType { get; private set; }     // 0x38

        // Source: IL2CPP ResourceRecyclePool__get_Count (0x01912959)
        //   return linkedList.Count
        public int Count => _recycleResources.Count;

        // =================================================================
        //  Constructor
        //  Source: IL2CPP ResourceRecyclePool$$.ctor (0x01911664)
        //    param_1 + 0x10 = parentTrans
        //    param_1 + 0x28 = resPath
        //    param_1 + 0x18 = new LinkedList<GameObject>()
        //    param_1 + 0x20 = new HashSet<GameObject>()
        //    param_1 + 0x30 = 0  (LastUseTime)
        //    param_1 + 0x38 = resType
        // =================================================================
        public ResourceRecyclePool(Transform parentTrans, ResourceRecycleType resType, string resPath)
        {
            _parentTrans = parentTrans;
            ResPath = resPath;
            _recycleResources = new LinkedList<GameObject>();
            _checkSameRecycleRes = new HashSet<GameObject>();
            LastUseTime = 0;
            ResType = resType;
        }

        // =================================================================
        //  Spawn — Pop a recycled GO from the pool
        //
        //  Source: IL2CPP ResourceRecyclePool__Spawn (0x01912c21)
        //    1. If count < 1, return null
        //    2. Get first item from linked list
        //    3. Deactivate it (SetActive(false)) — note: original deactivates on spawn
        //    4. Unparent (SetParent(null))
        //    5. Remove from list + hashset
        //    6. Update LastUseTime
        //    7. Return GO
        // =================================================================
        public GameObject Spawn()
        {
            if (Count < 1)
                return null;

            var first = _recycleResources.First;
            if (first == null)
                return null;

            GameObject go = first.Value;

            // Source: lines 340-346 — check not null, deactivate, unparent
            if (go != null)
            {
                go.SetActive(false);
                go.transform.SetParent(null, false);
            }

            // Remove from pool tracking
            _recycleResources.RemoveFirst();
            _checkSameRecycleRes.Remove(go);

            // Update timestamp
            LastUseTime = GetTickCount();

            return go;
        }

        // =================================================================
        //  Despawn — Return a GO to the pool
        //
        //  Source: IL2CPP ResourceRecyclePool__Despawn (0x01911730)
        //    1. Null check
        //    2. If already in hashset → log error, return
        //    3. Deactivate GO
        //    4. Reparent under pool root
        //    5. Add to linked list + hashset
        //    6. Update LastUseTime
        // =================================================================
        public void Despawn(GameObject obj)
        {
            if (obj == null) return;

            if (_checkSameRecycleRes.Contains(obj))
            {
                Debug.LogError($"[ResourceRecyclePool] Duplicate recycle: {ResPath}");
                return;
            }

            // Deactivate and reparent
            obj.SetActive(false);
            obj.transform.SetParent(_parentTrans, false);

            // Add to pool
            _recycleResources.AddLast(obj);
            _checkSameRecycleRes.Add(obj);

            // Update timestamp
            LastUseTime = GetTickCount();
        }

        // =================================================================
        //  Release — Remove a specific GO from pool and destroy it
        //
        //  Source: IL2CPP ResourceRecyclePool__Release (0x019135b9)
        //    Remove from list + hashset, then Destroy
        // =================================================================
        public void Release(GameObject obj)
        {
            _recycleResources.Remove(obj);
            _checkSameRecycleRes.Remove(obj);
            UnityEngine.Object.Destroy(obj);
        }

        // =================================================================
        //  DeleteRes — Destroy one GO from front of pool
        //
        //  Source: IL2CPP ResourceRecyclePool__DeleteRes (0x01912ace)
        //    1. If count < 1, return
        //    2. Get first from list
        //    3. RemoveFirst from list + hashset
        //    4. Unparent
        //    5. Destroy
        // =================================================================
        public void DeleteRes()
        {
            if (Count < 1) return;

            var first = _recycleResources.First;
            if (first == null) return;

            GameObject go = first.Value;
            _recycleResources.RemoveFirst();
            _checkSameRecycleRes.Remove(go);

            if (go != null)
            {
                go.transform.SetParent(null, false);
                UnityEngine.Object.Destroy(go);
            }
        }

        // =================================================================
        //  DeleteAll — Destroy all pooled GOs
        //
        //  Source: IL2CPP ResourceRecyclePool__DeleteAll (0x01911b5c)
        //    Loop while count > 0:
        //      get first, removeFirst, remove from hashset,
        //      unparent, destroy
        // =================================================================
        public void DeleteAll()
        {
            while (Count > 0)
            {
                var first = _recycleResources.First;
                if (first == null) break;

                GameObject go = first.Value;
                _recycleResources.RemoveFirst();
                _checkSameRecycleRes.Remove(go);

                if (go != null)
                {
                    go.transform.SetParent(null, false);
                    UnityEngine.Object.Destroy(go);
                }
            }
        }

        // =================================================================
        //  CompareTo — Sort order for GC
        //
        //  Source: IL2CPP ResourceRecyclePool__CompareTo (0x0191358d)
        //    1. Compare ResType (int subtraction)
        //    2. If same type, compare LastUseTime
        //    3. If other is null, return -1
        // =================================================================
        public int CompareTo(ResourceRecyclePool other)
        {
            if (other == null) return -1;

            int typeCompare = (int)ResType - (int)other.ResType;
            if (typeCompare != 0) return typeCompare;

            return LastUseTime.CompareTo(other.LastUseTime);
        }

        // =================================================================
        //  GetTickCount — match UtilsHelper.GetTickCount from IL2CPP
        //
        //  Source: IL2CPP UtilsHelper__GetTickCount (0x01bba7c0)
        //    return (long)(Time.realtimeSinceStartup * 1000f + 0.6f)
        // =================================================================
        static long GetTickCount()
        {
            return (long)(Time.realtimeSinceStartup * 1000f + 0.6f);
        }
    }
}
