// =======================================================================
//  BaseLoader.cs — Abstract loader base class (Phase R1.4)
//
//  Source: _shared/DecompiledSource/BaseLoader.cs (field layout)
//  IL2CPP: KTO_DecompiledReference/_root/BaseLoader.c (method bodies)
//
//  Original architecture:
//    - Abstract base with Url, RefCount, Progress, callback list
//    - Init/ReInit for loader reuse from LoaderManager pool
//    - DoCallback invokes all queued callbacks then clears the list
//    - Release decrements RefCount; at 0, triggers DoDispose
//    - Subclasses: BundleLoader, AssetLoader, CommonLoader
// =======================================================================

using System;
using System.Collections.Generic;

namespace KTO.Resource
{
    public abstract class BaseLoader : IDisposable
    {
        // Source: BaseLoader.cs delegate
        public delegate void LoaderCallBack(object resultObject);

        // Source: BaseLoader.cs fields
        private readonly List<LoaderCallBack> _FinishCallBacks = new List<LoaderCallBack>();
        protected LoaderMode _LoaderMode;

        // Source: BaseLoader.cs properties (auto-implemented)
        public int RefCount { get; set; }
        public string Url { get; protected set; }
        public object ResultObject { get; protected set; }
        public bool IsCompleted { get; set; }
        public bool IsLoading { get; set; }
        public virtual float Progress { get; protected set; }

        // =================================================================
        //  Init — Initialize loader with URL and mode
        //
        //  Source: IL2CPP BaseLoader__Init (0x0190c9f8)
        //    Sets m_Url, m_Priority (mode), zeros result, sets ready flag
        // =================================================================
        public virtual void Init(string url, LoaderMode loaderMode, params object[] args)
        {
            Url = url;
            _LoaderMode = loaderMode;
            ResultObject = null;
            IsCompleted = false;
            IsLoading = false;
            Progress = 0f;
        }

        // =================================================================
        //  ReInit — Reinitialize for reuse from pool
        //
        //  Source: BaseLoader.cs — virtual, overridden by subclasses
        // =================================================================
        public virtual void ReInit(LoaderMode loaderMode, params object[] args)
        {
            _LoaderMode = loaderMode;
        }

        // =================================================================
        //  AddCallback — Queue a callback for when loading completes
        //
        //  Source: IL2CPP BaseLoader__AddCallback (0x0190ca2b)
        //    Appends to m_CallbackList
        // =================================================================
        public void AddCallback(LoaderCallBack callback)
        {
            if (callback != null)
            {
                _FinishCallBacks.Add(callback);
            }
        }

        // =================================================================
        //  DoCallback — Invoke all queued callbacks with the result
        //
        //  Source: IL2CPP BaseLoader__DoCallback (0x0190cb41)
        //    Iterates callback list, invokes each, then clears list.
        // =================================================================
        protected void DoCallback(object resultObj)
        {
            ResultObject = resultObj;
            IsCompleted = true;
            IsLoading = false;

            for (int i = 0; i < _FinishCallBacks.Count; i++)
            {
                var cb = _FinishCallBacks[i];
                if (cb != null)
                {
                    try
                    {
                        cb(resultObj);
                    }
                    catch (Exception ex)
                    {
                        UnityEngine.Debug.LogException(ex);
                    }
                }
            }
            _FinishCallBacks.Clear();
        }

        // =================================================================
        //  OnFinish — Called when loading completes (override in subclasses)
        //
        //  Source: BaseLoader.cs — virtual
        // =================================================================
        protected virtual void OnFinish(object resultObj)
        {
            DoCallback(resultObj);
        }

        // =================================================================
        //  Release — Decrement ref count, dispose if no longer used
        //
        //  Source: IL2CPP BaseLoader__Release (0x0190cab4)
        //    Decrements refCount; at 0, calls DoDispose
        // =================================================================
        public virtual void Release()
        {
            RefCount--;
            if (RefCount <= 0)
            {
                DoDispose();
            }
        }

        // =================================================================
        //  DoDispose — Clean up loader resources (override in subclasses)
        //
        //  Source: BaseLoader.cs — virtual
        // =================================================================
        public virtual void DoDispose()
        {
            _FinishCallBacks.Clear();
            ResultObject = null;
            Url = null;
            IsCompleted = false;
            IsLoading = false;
        }

        public void Dispose()
        {
            DoDispose();
        }

        /// <summary>Whether this loader's bundle should be unloaded on release.</summary>
        public virtual bool NeedUnload()
        {
            return true;
        }
    }
}
