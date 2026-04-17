// =======================================================================
//  HttpDownloadMgr.cs — HTTP download engine (Phase R4)
//
//  Source: _shared/DecompiledSource/HttpDownloadMgr.cs (field layout)
//  IL2CPP: KTO_DecompiledReference/_root/HttpDownloadMgr.c (method bodies)
//
//  Original architecture:
//    - Wraps DownloadQueue which uses UnityWebRequest internally
//    - Three delegate callbacks: ErrorHandle, CompleteHandle, BreathHandle
//    - SwitchNetwork callback for wifi/mobile transitions
//    - Speed limit control + thread (concurrent download) limit
//    - reqList tracks all active requests by path key
//
//  Our port uses UnityWebRequest directly (no DownloadQueue wrapper)
//  since that's the underlying transport anyway.
// =======================================================================

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Networking;

namespace KTO.Resource
{
    public class HttpDownloadMgr
    {
        // Source: HttpDownloadMgr delegate types
        public delegate void ErrorHandle(DownloadRequest req);
        public delegate void CompleteHandle(DownloadRequest req);
        public delegate void BreathHandle(DownloadRequest req);

        // Source: HttpDownloadMgr fields at offsets 0x10-0x68
        readonly Dictionary<string, DownloadRequest> _reqList = new Dictionary<string, DownloadRequest>();
        readonly Queue<DownloadJob> _pendingJobs = new Queue<DownloadJob>();
        readonly List<DownloadJob> _activeJobs = new List<DownloadJob>();

        bool _closed;
        int _maxConcurrent = 3;  // Source: SetThreadLimit normal param

        public ErrorHandle errorHandle;
        public CompleteHandle completeHandle;
        public BreathHandle breathHandle;
        public ulong CurrentSpeedLimit;

        // Track for speed calculation
        public ulong TotalDownloaded { get; private set; }

        // Source: IL2CPP HttpDownloadMgr$$.ctor (0x01bda9a0)
        public HttpDownloadMgr(
            ErrorHandle errorHandle = null,
            CompleteHandle completeHandle = null,
            BreathHandle breathHandle = null)
        {
            this.errorHandle = errorHandle;
            this.completeHandle = completeHandle;
            this.breathHandle = breathHandle;
        }

        // Source: IL2CPP HttpDownloadMgr__Release (0x01bd7aa0)
        public void Release()
        {
            _closed = true;
            foreach (var job in _activeJobs)
            {
                if (job.webRequest != null)
                {
                    job.webRequest.Abort();
                    job.webRequest.Dispose();
                }
            }
            _activeJobs.Clear();
            _pendingJobs.Clear();
            _reqList.Clear();
        }

        // Source: IL2CPP HttpDownloadMgr__SetDefaultSpeedLimit (0x01bd67d9)
        public void SetDefaultSpeedLimit(ulong limit)
        {
            CurrentSpeedLimit = limit;
        }

        // Source: IL2CPP HttpDownloadMgr__SetThreadLimit (0x01bd67ec)
        public void SetThreadLimit(int normal, int high, int top)
        {
            _maxConcurrent = Mathf.Max(1, normal + high + top);
        }

        // Source: IL2CPP HttpDownloadMgr__GetRequest (0x01bd8cb7)
        public DownloadRequest GetRequest(string key)
        {
            _reqList.TryGetValue(key, out var req);
            return req;
        }

        // Source: IL2CPP HttpDownloadMgr__GetDownloadingSize (0x01bd8230)
        public ulong GetDownloadingSize()
        {
            ulong total = 0;
            foreach (var job in _activeJobs)
            {
                if (job.webRequest != null)
                    total += job.webRequest.downloadedBytes;
            }
            return total;
        }

        // Source: IL2CPP HttpDownloadMgr__PushDownloadRequest (0x01bd9534)
        public bool PushDownloadRequest(DownloadRequest req, string mainUrl, string backupUrl, string savePath)
        {
            if (_closed || req == null || string.IsNullOrEmpty(req.szPath))
                return false;

            if (_reqList.ContainsKey(req.szPath))
                return false; // already downloading

            _reqList[req.szPath] = req;

            var job = new DownloadJob
            {
                request = req,
                mainUrl = mainUrl,
                backupUrl = backupUrl,
                savePath = savePath
            };
            _pendingJobs.Enqueue(job);

            return true;
        }

        // Source: IL2CPP HttpDownloadMgr__NoRunningRequest (0x01bd9654)
        public bool NoRunningRequest()
        {
            return _activeJobs.Count == 0 && _pendingJobs.Count == 0;
        }

        // Source: IL2CPP HttpDownloadMgr__GetDownloadingRequest
        public DownloadRequest[] GetDownloadingRequest()
        {
            var result = new DownloadRequest[_activeJobs.Count];
            for (int i = 0; i < _activeJobs.Count; i++)
                result[i] = _activeJobs[i].request;
            return result;
        }

        // =================================================================
        //  Update — Must be called every frame to poll active downloads
        //
        //  DEVIATION — not a direct port of the original coroutine
        //  Reason: Original uses DownloadQueue with internal coroutines.
        //  We use a poll-based Update() to avoid coroutine dependency on
        //  MonoBehaviour, matching BundleManager.Update() pattern.
        // =================================================================
        public void Update()
        {
            if (_closed) return;

            // Start pending jobs up to max concurrent
            while (_pendingJobs.Count > 0 && _activeJobs.Count < _maxConcurrent)
            {
                var job = _pendingJobs.Dequeue();
                StartJob(job);
            }

            // Poll active jobs
            for (int i = _activeJobs.Count - 1; i >= 0; i--)
            {
                var job = _activeJobs[i];
                if (job.webRequest == null)
                {
                    _activeJobs.RemoveAt(i);
                    continue;
                }

                if (!job.webRequest.isDone)
                {
                    // Update progress
                    job.request.progress = job.webRequest.downloadProgress;
                    breathHandle?.Invoke(job.request);
                    continue;
                }

                // Done — check for errors
                _activeJobs.RemoveAt(i);

                if (job.webRequest.result == UnityWebRequest.Result.Success)
                {
                    OnJobSuccess(job);
                }
                else
                {
                    OnJobError(job);
                }

                job.webRequest.Dispose();
            }
        }

        void StartJob(DownloadJob job)
        {
            string url = job.mainUrl + job.request.szPath;
            string savePath = Path.Combine(job.savePath, job.request.szPath);

            // Ensure directory exists
            string dir = Path.GetDirectoryName(savePath);
            if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            job.localPath = savePath;
            job.webRequest = UnityWebRequest.Get(url);
            job.webRequest.downloadHandler = new DownloadHandlerFile(savePath);
            job.webRequest.SendWebRequest();
            _activeJobs.Add(job);

            Debug.Log($"[HttpDownloadMgr] Start download: {url}");
        }

        // Source: IL2CPP HttpDownloadMgr__OnSucceed (0x01bdc13f)
        void OnJobSuccess(DownloadJob job)
        {
            var req = job.request;

            // Verify MD5 if expected hash is provided
            if (!string.IsNullOrEmpty(req.md5) && File.Exists(job.localPath))
            {
                string actualMd5 = ComputeMD5(job.localPath);
                if (actualMd5 != req.md5)
                {
                    Debug.LogWarning($"[HttpDownloadMgr] MD5 mismatch: {req.szPath} " +
                        $"expected={req.md5} actual={actualMd5}");
                    // Try backup URL on MD5 mismatch
                    if (!string.IsNullOrEmpty(job.backupUrl) && !job.usedBackup)
                    {
                        job.usedBackup = true;
                        File.Delete(job.localPath);
                        _pendingJobs.Enqueue(job);
                        return;
                    }

                    req.error = "MD5 mismatch";
                    errorHandle?.Invoke(req);
                    _reqList.Remove(req.szPath);
                    return;
                }
            }

            req.isCompleted = true;
            req.progress = 1f;
            TotalDownloaded += (ulong)req.nSize;

            Debug.Log($"[HttpDownloadMgr] Download complete: {req.szPath} ({req.nSize} bytes)");
            completeHandle?.Invoke(req);
            _reqList.Remove(req.szPath);
        }

        // Source: IL2CPP HttpDownloadMgr__OnError (0x01bdc0c2)
        void OnJobError(DownloadJob job)
        {
            var req = job.request;
            req.error = job.webRequest.error;
            req.retryCount++;

            Debug.LogWarning($"[HttpDownloadMgr] Download failed: {req.szPath} " +
                $"error={req.error} retry={req.retryCount}");

            // Retry with backup URL
            if (!string.IsNullOrEmpty(job.backupUrl) && !job.usedBackup)
            {
                job.usedBackup = true;
                _pendingJobs.Enqueue(job);
                return;
            }

            // Retry up to 3 times
            if (req.retryCount < 3)
            {
                _pendingJobs.Enqueue(job);
                return;
            }

            errorHandle?.Invoke(req);
            _reqList.Remove(req.szPath);
        }

        static string ComputeMD5(string filePath)
        {
            using (var md5 = MD5.Create())
            using (var stream = File.OpenRead(filePath))
            {
                var hash = md5.ComputeHash(stream);
                return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
            }
        }

        // Internal job tracking
        class DownloadJob
        {
            public DownloadRequest request;
            public string mainUrl;
            public string backupUrl;
            public string savePath;
            public string localPath;
            public UnityWebRequest webRequest;
            public bool usedBackup;
        }
    }
}
