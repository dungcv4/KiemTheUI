// =======================================================================
//  DlcModule.cs — On-demand bundle download manager (Phase R4)
//
//  Source: _shared/DecompiledSource/DlcModule.cs (field layout)
//  IL2CPP: KTO_DecompiledReference/_root/DlcModule.c (method bodies)
//
//  Original architecture:
//    - MonoBehaviour singleton with 3 priority queues:
//      normalQueue (background), manualQueue (user-triggered), topQueue (urgent)
//    - DlcProcess coroutine pops items from queues and feeds HttpDownloadMgr
//    - Tracks downloaded bundles in a persistent list file
//    - PatchFileList provides the manifest of all bundles + MD5/size
//    - OnComplete saves to persistent path, updates downloaded list
//    - DownloadAssetBundleAsync is the public API called by game code
//
//  Key methods ported:
//    Init, PrepareQueue, DownloadAssetBundleAsync, IsBundleDownloaded,
//    OnComplete, OnReqFailed, LoadDownloadedList, DlcProcess
// =======================================================================

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace KTO.Resource
{
    public class DlcModule : MonoBehaviour
    {
        // =================================================================
        //  Source: DlcModule.DownloadBundleReq — per-request status tracker
        //  IL2CPP offset: inner class at 0x200024F
        // =================================================================
        public class DownloadBundleReq
        {
            public bool isCompleted;
            public float fProgress;
            public string error;
            public int nRetry;

            public void UpdateData(bool _isCompleted, float _fProgress, string _err = null, int _nRetry = 0)
            {
                isCompleted = _isCompleted;
                fProgress = _fProgress;
                error = _err;
                nRetry = _nRetry;
            }
        }

        // =================================================================
        //  Source: DlcModule static fields at offsets 0x00-0xB0
        // =================================================================
        public static GameObject objDlcModule;
        public static DlcModule Instance;

        // Reset statics on Play mode (handles Domain Reload disabled)
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        static void ResetStatics()
        {
            objDlcModule = null; Instance = null;
            downloaded = new Dictionary<string, string>();
            _updateUrl = ""; _updateUrlBackup = "";
            patchFileList = null;
            speedCalculator = new DownloadSpeed();
            normalQueue = new Queue<DownloadRequest>();
            manualQueue = new Queue<DownloadRequest>();
            topQueue = new Queue<DownloadRequest>();
            downloadMgr = null; curDownloadingItem = null;
            bPrepareFinished = false; bDownloaderFinished = false;
            bConfirmDownloadWithoutWifi = false; bSkip = false;
            lastReqPath = null; nTotalSize = 0; nSavedSize = 0;
            LoaderMaxRetryTime = 3;
            requestList = new Dictionary<string, DownloadBundleReq>();
        }

        // Downloaded bundle tracking: path → MD5
        public static Dictionary<string, string> downloaded = new Dictionary<string, string>();

        // CDN URLs (set from server config or KUpdaterMgr)
        public static string _updateUrl = "";
        public static string _updateUrlBackup = "";

        // The loaded patch manifest
        public static PatchFileListData patchFileList;

        // Speed calculator for UI display
        public static DownloadSpeed speedCalculator = new DownloadSpeed();

        // Three priority queues (Source: offsets 0x40, 0x48, 0x50)
        public static Queue<DownloadRequest> normalQueue = new Queue<DownloadRequest>();
        public static Queue<DownloadRequest> manualQueue = new Queue<DownloadRequest>();
        public static Queue<DownloadRequest> topQueue = new Queue<DownloadRequest>();

        // Download engine
        public static HttpDownloadMgr downloadMgr;

        // Current download in progress
        public static DownloadRequest curDownloadingItem;

        // State flags (Source: offsets 0x70-0x73)
        public static bool bPrepareFinished;
        public static bool bDownloaderFinished;
        public static bool bConfirmDownloadWithoutWifi;
        public static bool bSkip;

        // Progress tracking (Source: offsets 0x78-0x88)
        public static string lastReqPath;
        public static ulong nTotalSize;
        public static ulong nSavedSize;

        // Retry limit (Source: offset 0x90)
        public static int LoaderMaxRetryTime = 3;

        // Per-path request status (Source: offset 0x98)
        public static Dictionary<string, DownloadBundleReq> requestList
            = new Dictionary<string, DownloadBundleReq>();

        // Persistent file tracking
        static string _downloadedListPath;

        // =================================================================
        //  Init — Initialize the DLC download system
        //
        //  Source: IL2CPP DlcModule__Init (0x01bd7508)
        //    Creates queues, loads downloaded list, loads PatchFileList,
        //    creates HttpDownloadMgr with callbacks.
        // =================================================================
        public static IEnumerator Init()
        {
            if (Instance != null)
                yield break;

            // Create singleton GameObject
            objDlcModule = new GameObject("[DlcModule]");
            Instance = objDlcModule.AddComponent<DlcModule>();
            DontDestroyOnLoad(objDlcModule);

            // Initialize paths
            ResourceDef.Init();
            ResourceDef.EnsurePersistentDirectoryExists();
            _downloadedListPath = Path.Combine(
                ResourceDef.PersistentPathWithoutFileProtocol,
                "downloaded_list.txt");

            // Prepare queues (Source: DlcModule__PrepareQueue)
            PrepareQueue();

            // Load the list of already-downloaded bundles
            LoadDownloadedList();

            // Load PatchFileList from StreamingAssets
            string patchPath = Path.Combine(ResourceDef.StreamingResPath, "PatchFileList.json");
            yield return LoadPatchFileList(patchPath);

            // Create download manager with callbacks
            downloadMgr = new HttpDownloadMgr(
                errorHandle: OnReqFailed,
                completeHandle: OnComplete,
                breathHandle: OnReqBreath
            );

            // Start download processing coroutines
            Instance.StartCoroutine(Instance.DlcProcess());
            Instance.StartCoroutine(Instance.SpeedCheck());

            bPrepareFinished = true;
            Debug.Log("[DlcModule] Initialized");
        }

        // =================================================================
        //  PrepareQueue — Create fresh download queues
        //
        //  Source: IL2CPP DlcModule__PrepareQueue (0x01cd651c)
        // =================================================================
        static void PrepareQueue()
        {
            normalQueue = new Queue<DownloadRequest>();
            manualQueue = new Queue<DownloadRequest>();
            topQueue = new Queue<DownloadRequest>();
        }

        // =================================================================
        //  ClearAllQueue — Empty all queues
        //
        //  Source: IL2CPP DlcModule__ClearAllQueue (0x01cd65fa)
        // =================================================================
        static void ClearAllQueue()
        {
            normalQueue.Clear();
            manualQueue.Clear();
            topQueue.Clear();
        }

        // =================================================================
        //  LoadDownloadedList — Read persistent file of completed downloads
        //
        //  Source: IL2CPP DlcModule__LoadDownloadedList (0x01bd67fa)
        //    Reads a text file with "path|MD5" lines.
        // =================================================================
        static void LoadDownloadedList()
        {
            downloaded.Clear();

            if (!File.Exists(_downloadedListPath))
            {
                Debug.Log("[DlcModule] No downloaded list file — fresh start");
                return;
            }

            try
            {
                var lines = File.ReadAllLines(_downloadedListPath);
                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    var parts = line.Split('|');
                    if (parts.Length >= 2)
                    {
                        downloaded[parts[0]] = parts[1];
                    }
                }
                Debug.Log($"[DlcModule] Loaded {downloaded.Count} downloaded entries");
            }
            catch (Exception ex)
            {
                Debug.LogWarning($"[DlcModule] Failed to load downloaded list: {ex.Message}");
            }
        }

        // Save downloaded list to persistent file
        static void SaveDownloadedList()
        {
            try
            {
                var lines = new List<string>();
                foreach (var kvp in downloaded)
                {
                    lines.Add($"{kvp.Key}|{kvp.Value}");
                }
                File.WriteAllLines(_downloadedListPath, lines);
            }
            catch (Exception ex)
            {
                Debug.LogWarning($"[DlcModule] Failed to save downloaded list: {ex.Message}");
            }
        }

        // =================================================================
        //  LoadPatchFileList — Load PatchFileList.json
        // =================================================================
        static IEnumerator LoadPatchFileList(string path)
        {
            // Try local file first
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                patchFileList = PatchFileListData.ParseFromJson(json);
                if (patchFileList != null)
                {
                    Debug.Log($"[DlcModule] PatchFileList loaded: {patchFileList.FileList.Count} files, " +
                        $"version={patchFileList.MainVersion}");
                    yield break;
                }
            }

            // StreamingAssets on Android needs UnityWebRequest
            var request = UnityEngine.Networking.UnityWebRequest.Get(path);
            yield return request.SendWebRequest();

            if (request.result == UnityEngine.Networking.UnityWebRequest.Result.Success)
            {
                patchFileList = PatchFileListData.ParseFromJson(request.downloadHandler.text);
                if (patchFileList != null)
                {
                    Debug.Log($"[DlcModule] PatchFileList loaded (web): {patchFileList.FileList.Count} files");
                }
            }
            else
            {
                Debug.LogWarning($"[DlcModule] PatchFileList not found at {path}");
                patchFileList = new PatchFileListData();
            }

            request.Dispose();
        }

        // =================================================================
        //  DownloadAssetBundleAsync — Public API to request a bundle download
        //
        //  Source: IL2CPP DlcModule__DownloadAssetBundleAsync (0x01bd8858)
        //    1. GetFixedPath normalizes the bundle path
        //    2. Check if already downloaded → return completed req
        //    3. Check if already in requestList → return existing req
        //    4. Look up in PatchFileList for MD5/size
        //    5. Enqueue into normalQueue
        //    6. Return DownloadBundleReq for progress tracking
        // =================================================================
        public static DownloadBundleReq DownloadAssetBundleAsync(string fixedPath, bool force = false)
        {
            if (string.IsNullOrEmpty(fixedPath))
                return null;

            fixedPath = GetFixedPath(fixedPath);

            // Already downloaded and not forced?
            if (!force && IsBundleDownloaded(fixedPath))
            {
                var completedReq = new DownloadBundleReq();
                completedReq.UpdateData(true, 1f);
                return completedReq;
            }

            // Already in request queue?
            if (requestList.TryGetValue(fixedPath, out var existingReq))
                return existingReq;

            // Create download request from PatchFileList
            var dlReq = new DownloadRequest
            {
                szPath = fixedPath,
                queueType = DlcQueueType.Normal
            };

            // Look up in patch manifest for MD5 and size
            if (patchFileList != null && patchFileList.FileList.TryGetValue(fixedPath, out var pf))
            {
                dlReq.md5 = pf.MD5;
                dlReq.nSize = pf.size;
                dlReq.ver = pf.ver.ToString();
            }
            else if (patchFileList != null &&
                     patchFileList.OptionalPatchFileList.TryGetValue(fixedPath, out var opf))
            {
                dlReq.md5 = opf.MD5;
                dlReq.nSize = opf.size;
                dlReq.ver = opf.ver.ToString();
                dlReq.priority = opf.priority;
            }
            else
            {
                Debug.LogWarning($"[DlcModule] Bundle not in PatchFileList: {fixedPath}");
            }

            // Track request
            var bundleReq = new DownloadBundleReq();
            requestList[fixedPath] = bundleReq;

            // Enqueue
            normalQueue.Enqueue(dlReq);
            nTotalSize += (ulong)dlReq.nSize;

            Debug.Log($"[DlcModule] Queued download: {fixedPath} ({dlReq.nSize} bytes)");
            return bundleReq;
        }

        // =================================================================
        //  IsBundleDownloaded — Check if a bundle exists in persistent path
        //
        //  Source: IL2CPP DlcModule__IsBundleDownloaded (0x01bd7239)
        //    Checks both the downloaded dict and the actual file on disk.
        // =================================================================
        public static bool IsBundleDownloaded(string fixedPath)
        {
            if (string.IsNullOrEmpty(fixedPath)) return false;

            // Check downloaded list
            if (downloaded.ContainsKey(fixedPath))
            {
                // Verify file still exists
                string localPath = Path.Combine(
                    ResourceDef.PersistentPathWithoutFileProtocol, fixedPath);
                if (File.Exists(localPath))
                    return true;

                // File was deleted — remove from list
                downloaded.Remove(fixedPath);
            }

            return false;
        }

        // =================================================================
        //  GetFixedPath — Normalize a bundle path
        //
        //  Source: IL2CPP DlcModule__GetFixedPath (0x01bd847d)
        //    Ensures path starts with "Bundles/{platform}/"
        // =================================================================
        public static string GetFixedPath(string url)
        {
            if (string.IsNullOrEmpty(url)) return url;

            string platform = ResourceDef.GetBuildPlatformName();
            string prefix = $"Bundles/{platform}/";

            if (url.StartsWith(prefix))
                return url;

            // Strip leading path components if present
            if (url.StartsWith("Bundles/"))
                return url; // already has Bundles/ prefix with different platform

            return prefix + url;
        }

        // =================================================================
        //  GetDownloadSize — Get the expected download size of a bundle
        //
        //  Source: IL2CPP DlcModule__GetDownloadSize (0x01bd85b8)
        // =================================================================
        public static ulong GetDownloadSize(string fixedPath)
        {
            fixedPath = GetFixedPath(fixedPath);
            if (patchFileList == null) return 0;

            if (patchFileList.FileList.TryGetValue(fixedPath, out var pf))
                return (ulong)pf.size;
            if (patchFileList.OptionalPatchFileList.TryGetValue(fixedPath, out var opf))
                return (ulong)opf.size;

            return 0;
        }

        // =================================================================
        //  OnComplete — Called when a download finishes successfully
        //
        //  Source: IL2CPP DlcModule__OnComplete (0x01bd7e01)
        //    Adds to downloaded dict, saves list, updates requestList status.
        // =================================================================
        public static void OnComplete(DownloadRequest req)
        {
            if (req == null) return;

            string fixedPath = req.szPath;
            downloaded[fixedPath] = req.md5 ?? "";
            nSavedSize += (ulong)req.nSize;

            // Update request status
            if (requestList.TryGetValue(fixedPath, out var bundleReq))
            {
                bundleReq.UpdateData(true, 1f);
            }

            SaveDownloadedList();
            Debug.Log($"[DlcModule] Download complete: {fixedPath}");
        }

        // =================================================================
        //  OnReqBreath — Called periodically during download (progress update)
        //
        //  Source: IL2CPP DlcModule__OnReqBreath (0x01bd8105)
        // =================================================================
        public static void OnReqBreath(DownloadRequest req)
        {
            if (req == null) return;

            if (requestList.TryGetValue(req.szPath, out var bundleReq))
            {
                bundleReq.fProgress = req.progress;
            }

            lastReqPath = req.szPath;
        }

        // =================================================================
        //  OnReqFailed — Called when a download fails
        //
        //  Source: IL2CPP DlcModule__OnReqFailed (0x01bd8308)
        // =================================================================
        public static void OnReqFailed(DownloadRequest req)
        {
            if (req == null) return;

            Debug.LogError($"[DlcModule] Download failed: {req.szPath} error={req.error}");

            if (requestList.TryGetValue(req.szPath, out var bundleReq))
            {
                bundleReq.UpdateData(false, 0f, req.error, req.retryCount);
            }
        }

        // =================================================================
        //  DlcProcess — Main download loop coroutine
        //
        //  Source: IL2CPP DlcModule coroutine state machines
        //    (_003CDlcProcess_003Ed__50, _003CDlcProcessManualReq_003Ed__49,
        //     _003CDlcProcessTopReq_003Ed__48)
        //    Priority: topQueue > manualQueue > normalQueue
        //    Each frame dequeues one item, submits to downloadMgr,
        //    waits for completion.
        // =================================================================
        IEnumerator DlcProcess()
        {
            while (!bSkip)
            {
                DownloadRequest item = null;

                // Priority: top > manual > normal
                // Source: DlcProcessTopReq, DlcProcessManualReq, DlcProcess
                if (topQueue.Count > 0)
                    item = topQueue.Dequeue();
                else if (manualQueue.Count > 0)
                    item = manualQueue.Dequeue();
                else if (normalQueue.Count > 0)
                    item = normalQueue.Dequeue();

                if (item != null)
                {
                    curDownloadingItem = item;
                    string savePath = ResourceDef.PersistentPathWithoutFileProtocol;
                    string mainUrl = _updateUrl;
                    string backupUrl = _updateUrlBackup;

                    downloadMgr.PushDownloadRequest(item, mainUrl, backupUrl, savePath);

                    // Wait until this item completes or fails
                    while (!item.isCompleted && string.IsNullOrEmpty(item.error))
                    {
                        yield return null;
                    }

                    curDownloadingItem = null;
                }
                else
                {
                    // Nothing in queues — wait a bit
                    yield return new WaitForSeconds(0.5f);
                }
            }

            bDownloaderFinished = true;
        }

        // =================================================================
        //  SpeedCheck — Periodic speed calculation
        //
        //  Source: IL2CPP DlcModule coroutine _003CSpeedCheck_003Ed__37
        // =================================================================
        IEnumerator SpeedCheck()
        {
            speedCalculator.Start();
            while (!bSkip)
            {
                ulong totalDownloaded = nSavedSize;
                if (downloadMgr != null)
                    totalDownloaded += downloadMgr.GetDownloadingSize();

                speedCalculator.Update(totalDownloaded);
                yield return new WaitForSeconds(1f);
            }
        }

        // =================================================================
        //  SkipDlc — Stop all downloads (user chose to skip)
        //
        //  Source: IL2CPP DlcModule__SkipDlc (0x01cd2e37)
        // =================================================================
        public static void SkipDlc()
        {
            bSkip = true;
            ClearAllQueue();
            if (downloadMgr != null)
                downloadMgr.Release();
        }

        // =================================================================
        //  DownloadedSize — Total bytes downloaded so far
        //
        //  Source: IL2CPP DlcModule__DownloadedSize (0x01bd817a)
        // =================================================================
        public static ulong DownloadedSize()
        {
            ulong total = nSavedSize;
            if (downloadMgr != null)
                total += downloadMgr.GetDownloadingSize();
            return total;
        }

        // =================================================================
        //  GetDownloadingSize — Total remaining bytes to download
        //
        //  Source: IL2CPP DlcModule__GetDownloadingSize (0x01bd8d39)
        // =================================================================
        public static ulong GetDownloadingSize()
        {
            return nTotalSize - nSavedSize;
        }

        // =================================================================
        //  ShowDownloadProgress — Feed progress to UI
        //
        //  Source: IL2CPP DlcModule__ShowDownloadProgress (0x01cd6a35)
        //    Computes downloaded + downloading as ratio of total,
        //    passes to UIUpdateProgress for display.
        // =================================================================
        public static void ShowDownloadProgress()
        {
            if (UIUpdateProgress.Instance == null) return;

            ulong downloaded = nSavedSize;
            ulong downloading = downloadMgr != null ? downloadMgr.GetDownloadingSize() : 0;
            ulong total = nTotalSize;

            if (total == 0) return;

            float progress = (float)(downloaded + downloading) / total;
            UIUpdateProgress.Instance.SetProgress(progress);

            float dlMB = (downloaded + downloading) / (1024f * 1024f);
            float totalMB = total / (1024f * 1024f);
            UIUpdateProgress.Instance.SetInfoText($"{dlMB:F1} MB / {totalMB:F1} MB");
            UIUpdateProgress.Instance.SetSpeedText(speedCalculator.FormatSpeed());
        }

        // =================================================================
        //  DestroyDlcModule — Clean up singleton
        //
        //  Source: IL2CPP DlcModule__DestoryDlcModule (0x01bd87e7)
        // =================================================================
        public static void DestroyDlcModule()
        {
            if (downloadMgr != null)
            {
                downloadMgr.Release();
                downloadMgr = null;
            }

            ClearAllQueue();
            requestList.Clear();

            if (Instance != null)
            {
                Destroy(objDlcModule);
                Instance = null;
                objDlcModule = null;
            }
        }

        void Start()
        {
            // Source: DlcModule__Start (0x01bd7566)
            // Original starts coroutines here — we start them in Init instead
        }

        void FixedUpdate()
        {
            // Source: IL2CPP DlcModule__FixedUpdate (0x01bd8def)
            // Poll the download manager
            if (downloadMgr != null)
                downloadMgr.Update();
        }

        void OnDestroy()
        {
            // Source: IL2CPP DlcModule__OnDestroy (0x01bd7976)
            if (Instance == this)
            {
                Instance = null;
                if (downloadMgr != null)
                {
                    downloadMgr.Release();
                    downloadMgr = null;
                }
                SaveDownloadedList();
            }
        }
    }
}
