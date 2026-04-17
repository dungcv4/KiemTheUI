// =======================================================================
//  PreloadResource.cs — Object pool + GC manager (Phase R5)
//
//  Source: _shared/DecompiledSource/PreloadResource.cs (field layout)
//  IL2CPP: KTO_DecompiledReference/_root/PreloadResource.c (method bodies)
//
//  Original architecture:
//    - Static class managing recycled GameObjects via ResourceRecyclePool
//    - m_recycleResPools: dict keyed by resPath → pool of recycled GOs
//    - GC runs periodically (m_checkInterval), removing pools that haven't
//      been used in m_notUseTime ms, capped at m_onceMaxGcTime ms per frame
//    - Two threshold modes:
//      * resCount > maxCount → aggressively collect ALL pools with items
//      * resCount > minCount → only collect pools older than m_notUseTime
//    - Sorted by CompareTo (Scene type first, then oldest LastUseTime)
//    - m_mapPreloadRes: per-map preload registry (map template ID → set of paths)
//    - OnLoadMap: when entering a map, pre-warm pools for that map's resources
//
//  Delegate:
//    OnPreResFinishHandler(GameObject obj, object param) → bool
//    Source: _shared/DecompiledSource/OnPreResFinishHandler.cs
// =======================================================================

using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

namespace KTO.Resource
{
    // Source: _shared/DecompiledSource/OnPreResFinishHandler.cs
    public delegate bool OnPreResFinishHandler(GameObject obj, object param);

    public static class PreloadResource
    {
        // =================================================================
        //  Source: PreloadResource static fields at offsets 0x00-0x50
        // =================================================================
        static Transform _recycleResRootTrans;                                     // 0x00
        static Dictionary<string, ResourceRecyclePool> _recycleResPools;           // 0x08
        static List<ResourceRecyclePool> _tempClearRes;                            // 0x10
        static Dictionary<int, Dictionary<string, Object>> _mapPreloadRes;         // 0x18
        static List<int> _tempClearMapId;                                          // 0x20
        static int _resMinCount;                                                   // 0x28
        static int _resMaxCount;                                                   // 0x2C
        static bool _needCheckNow;                                                 // 0x30
        static long _checkInterval;                                                // 0x38
        static long _lastCheckTime;                                                // 0x40
        static long _notUseTime;                                                   // 0x48
        static long _onceMaxGcTime;                                                // 0x50

        static bool _initialized;

        // =================================================================
        //  Init — Create the root pool object
        //
        //  Source: IL2CPP PreloadResource__Init (0x01910359)
        //    1. Create new GameObject
        //    2. Set name, SetActive(false)
        //    3. Get transform → _recycleResRootTrans
        //    4. DontDestroyOnLoad
        // =================================================================
        public static void Init()
        {
            if (_initialized) return;

            _recycleResPools = new Dictionary<string, ResourceRecyclePool>();
            _tempClearRes = new List<ResourceRecyclePool>();
            _mapPreloadRes = new Dictionary<int, Dictionary<string, Object>>();
            _tempClearMapId = new List<int>();

            // Default GC parameters
            // Source: These defaults aren't in Init but in the field initializers
            // and SetGcCheckInfo calls from game startup
            _resMinCount = 20;
            _resMaxCount = 50;
            _checkInterval = 5000;    // 5 seconds
            _notUseTime = 30000;      // 30 seconds
            _onceMaxGcTime = 5;       // 5 ms max per GC pass

            var go = new GameObject("[RecycleResRoot]");
            go.SetActive(false);
            _recycleResRootTrans = go.transform;
            Object.DontDestroyOnLoad(go);

            _initialized = true;
            Debug.Log("[PreloadResource] Initialized");
        }

        // =================================================================
        //  Active — Called periodically (e.g. from Update loop) to run GC
        //
        //  Source: IL2CPP PreloadResource__Active (0x0191043d)
        //    Just calls _CheckGc()
        // =================================================================
        public static void Active()
        {
            if (!_initialized) return;
            _CheckGc();
        }

        // =================================================================
        //  SetGcCheckInfo — Configure GC thresholds
        //
        //  Source: IL2CPP PreloadResource__SetGcCheckInfo (0x01910a13)
        //    _resMinCount = param_1
        //    _resMaxCount = param_2
        // =================================================================
        public static void SetGcCheckInfo(int minResCount, int maxResCount)
        {
            _resMinCount = minResCount;
            _resMaxCount = maxResCount;
        }

        // =================================================================
        //  LoadResourceAsync — Load a resource, checking pool first
        //
        //  Source: IL2CPP PreloadResource__LoadResourceAsync (0x01910a64)
        //    1. Check if resPath is null → return
        //    2. Try _PopResourceGameObject(resPath) from pool
        //    3. If found → call finishHandler immediately
        //    4. If not found → LoaderManager.Load(resPath, Async, callback)
        //       callback instantiates and returns via finishHandler
        // =================================================================
        public static void LoadResourceAsync(bool isUI, string resPath,
            OnPreResFinishHandler finishHandler, object param)
        {
            if (string.IsNullOrEmpty(resPath))
                return;

            if (!_initialized) Init();

            // Try pool first
            var pooled = _PopResourceGameObject(resPath);
            if (pooled != null)
            {
                pooled.SetActive(true);
                _OnResourceLoadFinishHandler(pooled, finishHandler, param);
                return;
            }

            // Load via LoaderManager
            LoaderManager.Load(resPath, LoaderMode.Async, (obj) =>
            {
                _OnLoadResAsyncFinish(obj as Object, resPath, finishHandler, param);
            });
        }

        // =================================================================
        //  LoadResourceSync — Synchronous version
        //
        //  Source: IL2CPP PreloadResource__LoadResourceSync (0x0181114E)
        //    1. Try _PopResourceGameObject(resPath)
        //    2. If found → return it
        //    3. LoaderManager.Load(resPath, Sync, ...)
        //    4. Instantiate and return
        // =================================================================
        public static GameObject LoadResourceSync(string resPath)
        {
            if (string.IsNullOrEmpty(resPath))
                return null;

            if (!_initialized) Init();

            // Try pool first
            var pooled = _PopResourceGameObject(resPath);
            if (pooled != null)
            {
                pooled.SetActive(true);
                return pooled;
            }

            // Load synchronously
            GameObject result = null;
            LoaderManager.Load(resPath, LoaderMode.Sync, (obj) =>
            {
                if (obj != null)
                {
                    result = _PreInstantiateObj(obj as Object, resPath);
                }
            });

            return result;
        }

        // =================================================================
        //  RecycleGameObject — Return a GO to the pool
        //
        //  Source: IL2CPP PreloadResource__RecycleGameObject (0x0181144D)
        //    1. Null check
        //    2. Get or create ResourceRecyclePool for resPath (from GO name)
        //    3. pool.Despawn(gameObj)
        // =================================================================
        public static void RecycleGameObject(GameObject gameObj,
            ResourceRecycleType resType = ResourceRecycleType.Common)
        {
            if (gameObj == null) return;
            if (!_initialized) Init();

            // Use name as the resource path key
            string resPath = gameObj.name;

            // Get or create pool
            if (!_recycleResPools.TryGetValue(resPath, out var pool))
            {
                pool = new ResourceRecyclePool(_recycleResRootTrans, resType, resPath);
                _recycleResPools[resPath] = pool;
            }

            pool.Despawn(gameObj);
        }

        // =================================================================
        //  ClearRecycle — Destroy all pooled objects
        //
        //  Source: IL2CPP PreloadResource__ClearRecycle (0x0181198F)
        //    Iterate all pools → DeleteAll, then clear the dict
        // =================================================================
        public static void ClearRecycle()
        {
            if (_recycleResPools == null) return;

            foreach (var kvp in _recycleResPools)
            {
                kvp.Value.DeleteAll();
            }
            _recycleResPools.Clear();

            Debug.Log("[PreloadResource] All recycle pools cleared");
        }

        // =================================================================
        //  AddPreloadRes — Register a resource for map preloading
        //
        //  Source: IL2CPP PreloadResource__AddPreloadRes (0x01811CA7)
        //    Add (mapTemplateId, resPath) to _mapPreloadRes dictionary.
        //    If needInstantiate, also load it via LoaderManager.
        // =================================================================
        public static void AddPreloadRes(int mapTemplateId, string resPath, bool needInstantiate)
        {
            if (string.IsNullOrEmpty(resPath)) return;
            if (!_initialized) Init();

            if (!_mapPreloadRes.TryGetValue(mapTemplateId, out var dict))
            {
                dict = new Dictionary<string, Object>();
                _mapPreloadRes[mapTemplateId] = dict;
            }

            if (!dict.ContainsKey(resPath))
            {
                dict[resPath] = null;

                if (needInstantiate)
                {
                    // Pre-load the resource
                    LoaderManager.Load(resPath, LoaderMode.Async, (obj) =>
                    {
                        _OnAddPreloadResFinish(obj as Object, resPath, mapTemplateId);
                    });
                }
            }
        }

        // =================================================================
        //  OnLoadMap — Activate preloads for a specific map
        //
        //  Source: IL2CPP PreloadResource__OnLoadMap (0x01812595)
        //    1. Clear pools for any maps not in the current set
        //    2. If _mapPreloadRes has entries for this map, they're already loaded
        // =================================================================
        public static void OnLoadMap(int mapTemplateId)
        {
            if (!_initialized) return;

            // Clean up pools for other maps
            _tempClearMapId.Clear();
            foreach (var kvp in _mapPreloadRes)
            {
                if (kvp.Key != mapTemplateId)
                {
                    _tempClearMapId.Add(kvp.Key);
                }
            }

            foreach (int mapId in _tempClearMapId)
            {
                if (_mapPreloadRes.TryGetValue(mapId, out var dict))
                {
                    dict.Clear();
                }
                _mapPreloadRes.Remove(mapId);
            }

            Debug.Log($"[PreloadResource] OnLoadMap({mapTemplateId}) — " +
                $"cleaned up {_tempClearMapId.Count} old map preloads");
        }

        // =================================================================
        //  PreloadResFinish — Called when all preloads for a map are done
        //
        //  Source: IL2CPP PreloadResource__PreloadResFinish (0x018133EF)
        //    Placeholder — original does logging/state tracking
        // =================================================================
        public static void PreloadResFinish()
        {
            Debug.Log("[PreloadResource] Preload finished");
        }

        // =================================================================
        //  Internal: _CheckGc — Periodic garbage collection of pools
        //
        //  Source: IL2CPP PreloadResource___CheckGc (0x01910478)
        //    1. Call _NeedGc() → if false, return
        //    2. Set _needCheckNow = false
        //    3. Get current resCount and minCount
        //    4. Record start time
        //    5. Clear _tempClearRes
        //    6. If resCount > maxCount:
        //       → collect ALL pools with Count > 0
        //    7. Else (resCount > minCount):
        //       → collect only pools where (now - LastUseTime) > _notUseTime
        //    8. Sort _tempClearRes (by CompareTo: Scene first, then oldest)
        //    9. Loop: DeleteRes from each pool, increment deletedCount
        //       Stop when: all processed OR deletedCount >= (resCount - minCount)
        //       Also stop if (now - startTime) >= _onceMaxGcTime
        //    10. If still more to clean, set _needCheckNow = true
        // =================================================================
        static void _CheckGc()
        {
            if (!_NeedGc()) return;

            _needCheckNow = false;
            int resCount = _GetResCount();
            int minCount = _resMinCount;

            long startTime = GetTickCount();

            // Collect candidates
            _tempClearRes.Clear();

            if (resCount > _resMaxCount)
            {
                // Aggressive: collect ALL non-empty pools
                foreach (var kvp in _recycleResPools)
                {
                    if (kvp.Value.Count > 0)
                    {
                        _tempClearRes.Add(kvp.Value);
                    }
                }
            }
            else
            {
                // Normal: collect only expired pools
                foreach (var kvp in _recycleResPools)
                {
                    if (kvp.Value.Count > 0)
                    {
                        long age = startTime - kvp.Value.LastUseTime;
                        if (age > _notUseTime)
                        {
                            _tempClearRes.Add(kvp.Value);
                        }
                    }
                }
            }

            if (_tempClearRes.Count == 0) return;

            // Sort: Scene type first, then oldest LastUseTime
            _tempClearRes.Sort();

            // Delete resources, respecting time budget
            int deleted = 0;
            for (int i = 0; i < _tempClearRes.Count; i++)
            {
                if (resCount - deleted <= minCount) break;

                var pool = _tempClearRes[i];
                if (pool.Count > 0)
                {
                    pool.DeleteRes();
                    deleted++;

                    // Check time budget
                    long elapsed = GetTickCount() - startTime;
                    if (elapsed >= _onceMaxGcTime)
                        break;
                }
            }

            // If we still have excess, schedule another pass
            if (resCount - deleted > minCount && resCount > _resMinCount)
            {
                _needCheckNow = true;
            }
        }

        // =================================================================
        //  Internal: _NeedGc — Check if GC should run
        //
        //  Source: IL2CPP PreloadResource___NeedGc (0x0181298C)
        //    1. If _needCheckNow → return true
        //    2. If now - _lastCheckTime < _checkInterval → return false
        //    3. Update _lastCheckTime = now
        //    4. return _GetResCount() > _resMinCount
        // =================================================================
        static bool _NeedGc()
        {
            if (_needCheckNow) return true;

            long now = GetTickCount();
            if (now - _lastCheckTime < _checkInterval) return false;

            _lastCheckTime = now;
            return _GetResCount() > _resMinCount;
        }

        // =================================================================
        //  Internal: _GetResCount — Total pooled items across all pools
        //
        //  Source: IL2CPP PreloadResource___GetResCount (0x01812801)
        //    Sum of all pool.Count
        // =================================================================
        static int _GetResCount()
        {
            if (_recycleResPools == null) return 0;

            int total = 0;
            foreach (var kvp in _recycleResPools)
            {
                total += kvp.Value.Count;
            }
            return total;
        }

        // =================================================================
        //  Internal: _PopResourceGameObject — Get a GO from pool
        //
        //  Source: IL2CPP PreloadResource___PopResourceGameObject (0x018110B4)
        //    Look up pool by resPath → pool.Spawn()
        // =================================================================
        static GameObject _PopResourceGameObject(string resPath)
        {
            if (_recycleResPools == null) return null;

            if (_recycleResPools.TryGetValue(resPath, out var pool))
            {
                return pool.Spawn();
            }
            return null;
        }

        // =================================================================
        //  Internal: _OnLoadResAsyncFinish — Callback after async load
        //
        //  Source: IL2CPP PreloadResource___OnLoadResAsyncFinish (0x01813012)
        //    Instantiate the loaded object, call the finish handler
        // =================================================================
        static void _OnLoadResAsyncFinish(Object obj, string resPath,
            OnPreResFinishHandler finishHandler, object param)
        {
            if (obj == null)
            {
                Debug.LogWarning($"[PreloadResource] Failed to load: {resPath}");
                finishHandler?.Invoke(null, param);
                return;
            }

            var go = _PreInstantiateObj(obj, resPath);
            _OnResourceLoadFinishHandler(go, finishHandler, param);
        }

        // =================================================================
        //  Internal: _OnResourceLoadFinishHandler
        //
        //  Source: IL2CPP PreloadResource___OnResourceLoadFinishHandler (0x01812EB7)
        //    Invoke the user's finish handler
        // =================================================================
        static void _OnResourceLoadFinishHandler(GameObject gameObj,
            OnPreResFinishHandler finishHandler, object param)
        {
            if (finishHandler != null)
            {
                finishHandler.Invoke(gameObj, param);
            }
        }

        // =================================================================
        //  Internal: _OnAddPreloadResFinish — Callback after preload completes
        //
        //  Source: IL2CPP PreloadResource___OnAddPreloadResFinish (0x01811FD1)
        //    Store loaded object in the map preload dict
        // =================================================================
        static void _OnAddPreloadResFinish(Object obj, string resPath, int mapTemplateId)
        {
            if (obj == null) return;

            if (_mapPreloadRes.TryGetValue(mapTemplateId, out var dict))
            {
                dict[resPath] = obj;
            }
        }

        // =================================================================
        //  Internal: _PreInstantiateObj — Instantiate + name the GO
        //
        //  Source: IL2CPP PreloadResource___PreInstantiateObj (0x018123C0)
        //    1. Instantiate the object
        //    2. Set name to resPath (strip extension)
        //    3. Return the new GO
        // =================================================================
        static GameObject _PreInstantiateObj(Object obj, string resPath)
        {
            if (obj == null) return null;

            var go = Object.Instantiate(obj) as GameObject;
            if (go != null)
            {
                // Strip clone suffix and use resPath as name for pooling key
                go.name = resPath;
            }
            return go;
        }

        // =================================================================
        //  GetTickCount — match UtilsHelper.GetTickCount
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
