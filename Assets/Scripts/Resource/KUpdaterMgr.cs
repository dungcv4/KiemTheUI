// =======================================================================
//  KUpdaterMgr.cs — Startup update checker (Phase R4)
//
//  Source: _shared/DecompiledSource/KKUpdater/KUpdaterMgr.cs (field layout)
//  IL2CPP: KTO_DecompiledReference/KKUpdater/KUpdaterMgr.c (method bodies)
//
//  Original architecture:
//    - On startup: compare local PatchFileList.json vs remote
//    - Compute diff → list of bundles that need downloading
//    - Feed diff into DlcModule queues
//    - Show progress UI during mandatory update
//    - Track update state via UpdateStateChangeDelegate
//
//  This port focuses on the compare + diff logic.
//  The UI integration is a separate concern (Phase R4.5).
// =======================================================================

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;

namespace KTO.Resource
{
    public class KUpdaterMgr
    {
        // Source: KUpdaterMgr.DownloadResInfo inner class
        public class DownloadResInfo
        {
            public string pathName;
            public string MD5;
            public int size;
            public int ver;
        }

        // Update state tracking
        public enum UpdateState
        {
            None,
            CheckingVersion,
            Downloading,
            Complete,
            Error
        }

        public delegate void UpdateStateChangeDelegate(UpdateState state, string message);

        // =================================================================
        //  Static fields
        // =================================================================
        static KUpdaterMgr _instance;
        public static KUpdaterMgr Instance => _instance ?? (_instance = new KUpdaterMgr());

        public UpdateState CurrentState { get; private set; } = UpdateState.None;
        public UpdateStateChangeDelegate OnStateChanged;

        public bool IsNeedUpdate { get; private set; }
        public List<DownloadResInfo> PendingDownloads { get; private set; } = new List<DownloadResInfo>();
        public ulong TotalDownloadSize { get; private set; }

        PatchFileListData _localPatchFileList;
        PatchFileListData _remotePatchFileList;

        // =================================================================
        //  CheckForUpdates — Compare local vs remote PatchFileList
        //
        //  Source: IL2CPP KUpdaterMgr coroutine ProcessCheckLocalMainVersion
        //    1. Read local PatchFileList.json from StreamingAssets
        //    2. Fetch remote PatchFileList.json from CDN
        //    3. Compare: any file in remote not in local (or different MD5) = needs download
        //    4. Also check OptionalPatchFileList for on-demand content
        //
        //  Returns the list of DownloadResInfo items that need updating.
        // =================================================================
        public IEnumerator CheckForUpdates(string localPatchPath, string remotePatchUrl)
        {
            SetState(UpdateState.CheckingVersion, "Checking for updates...");
            PendingDownloads.Clear();
            TotalDownloadSize = 0;
            IsNeedUpdate = false;

            // 1. Load local PatchFileList
            yield return LoadLocalPatchFileList(localPatchPath);

            // 2. Load remote PatchFileList
            yield return LoadRemotePatchFileList(remotePatchUrl);

            if (_remotePatchFileList == null)
            {
                Debug.LogWarning("[KUpdaterMgr] Remote PatchFileList not available — skipping update check");
                SetState(UpdateState.Complete, "No remote manifest available");
                yield break;
            }

            // 3. Compare and build diff
            ComputeDiff();

            if (PendingDownloads.Count > 0)
            {
                IsNeedUpdate = true;
                Debug.Log($"[KUpdaterMgr] Update required: {PendingDownloads.Count} files, " +
                    $"{TotalDownloadSize / 1024 / 1024}MB total");
                SetState(UpdateState.Downloading,
                    $"{PendingDownloads.Count} files to download ({TotalDownloadSize / 1024 / 1024}MB)");
            }
            else
            {
                Debug.Log("[KUpdaterMgr] All bundles up to date");
                SetState(UpdateState.Complete, "All bundles up to date");
            }
        }

        // =================================================================
        //  DoUpdate — Download all pending updates via DlcModule
        //
        //  Source: KUpdaterMgr feeds items into DlcModule.normalQueue
        // =================================================================
        public IEnumerator DoUpdate()
        {
            if (PendingDownloads.Count == 0)
            {
                SetState(UpdateState.Complete, "Nothing to update");
                yield break;
            }

            SetState(UpdateState.Downloading, "Downloading updates...");

            // Enqueue all pending downloads
            foreach (var info in PendingDownloads)
            {
                var req = new DownloadRequest
                {
                    szPath = info.pathName,
                    md5 = info.MD5,
                    nSize = info.size,
                    ver = info.ver.ToString(),
                    queueType = DlcQueueType.Normal
                };
                DlcModule.normalQueue.Enqueue(req);
                DlcModule.nTotalSize += (ulong)info.size;
            }

            // Wait for all downloads to complete
            while (DlcModule.normalQueue.Count > 0 ||
                   (DlcModule.downloadMgr != null && !DlcModule.downloadMgr.NoRunningRequest()))
            {
                yield return new WaitForSeconds(0.5f);
            }

            // Save the remote PatchFileList as the new local
            if (_remotePatchFileList != null)
            {
                DlcModule.patchFileList = _remotePatchFileList;
            }

            SetState(UpdateState.Complete, "Update complete");
            Debug.Log("[KUpdaterMgr] All updates downloaded");
        }

        // =================================================================
        //  Internal: Load local PatchFileList
        // =================================================================
        IEnumerator LoadLocalPatchFileList(string path)
        {
            // Try persistent first (downloaded updates override streaming)
            string persistentPath = Path.Combine(
                ResourceDef.PersistentPathWithoutFileProtocol,
                "PatchFileList.json");

            if (File.Exists(persistentPath))
            {
                string json = File.ReadAllText(persistentPath);
                _localPatchFileList = PatchFileListData.ParseFromJson(json);
                if (_localPatchFileList != null)
                {
                    Debug.Log($"[KUpdaterMgr] Local PatchFileList (persistent): " +
                        $"{_localPatchFileList.FileList.Count} files");
                    yield break;
                }
            }

            // Fall back to streaming
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                _localPatchFileList = PatchFileListData.ParseFromJson(json);
            }
            else
            {
                // Android StreamingAssets — use UnityWebRequest
                var request = UnityWebRequest.Get(path);
                yield return request.SendWebRequest();
                if (request.result == UnityWebRequest.Result.Success)
                {
                    _localPatchFileList = PatchFileListData.ParseFromJson(request.downloadHandler.text);
                }
                request.Dispose();
            }

            if (_localPatchFileList != null)
            {
                Debug.Log($"[KUpdaterMgr] Local PatchFileList (streaming): " +
                    $"{_localPatchFileList.FileList.Count} files");
            }
            else
            {
                Debug.Log("[KUpdaterMgr] No local PatchFileList found");
                _localPatchFileList = new PatchFileListData();
            }
        }

        // =================================================================
        //  Internal: Load remote PatchFileList from CDN
        // =================================================================
        IEnumerator LoadRemotePatchFileList(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                _remotePatchFileList = null;
                yield break;
            }

            var request = UnityWebRequest.Get(url);
            request.timeout = 10; // 10 second timeout
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                _remotePatchFileList = PatchFileListData.ParseFromJson(request.downloadHandler.text);
                if (_remotePatchFileList != null)
                {
                    Debug.Log($"[KUpdaterMgr] Remote PatchFileList: " +
                        $"{_remotePatchFileList.FileList.Count} files, " +
                        $"version={_remotePatchFileList.MainVersion}");
                }
            }
            else
            {
                Debug.LogWarning($"[KUpdaterMgr] Failed to fetch remote PatchFileList: {request.error}");
                _remotePatchFileList = null;
            }

            request.Dispose();
        }

        // =================================================================
        //  Internal: Compute diff between local and remote manifests
        //
        //  Source: KUpdaterMgr compares FileList entries by MD5.
        //  Any file in remote that's missing locally or has different MD5
        //  is added to PendingDownloads.
        // =================================================================
        void ComputeDiff()
        {
            PendingDownloads.Clear();
            TotalDownloadSize = 0;

            if (_remotePatchFileList == null) return;

            // Check mandatory files
            foreach (var kvp in _remotePatchFileList.FileList)
            {
                string path = kvp.Key;
                var remoteFile = kvp.Value;

                bool needsDownload = false;

                if (_localPatchFileList == null ||
                    !_localPatchFileList.FileList.TryGetValue(path, out var localFile))
                {
                    // Not in local — new file
                    needsDownload = true;
                }
                else if (localFile.MD5 != remoteFile.MD5)
                {
                    // MD5 mismatch — updated file
                    needsDownload = true;
                }
                else if (localFile.ver < remoteFile.ver)
                {
                    // Newer version
                    needsDownload = true;
                }

                // Also check if the file is actually downloaded
                if (!needsDownload && !DlcModule.IsBundleDownloaded(path))
                {
                    // File should exist locally but doesn't — re-download
                    // (This catches files that were deleted from persistent storage)
                    // Only for files not in StreamingAssets
                    string streamingPath = Path.Combine(ResourceDef.StreamingResPath,
                        path.Replace($"Bundles/{ResourceDef.GetBuildPlatformName()}/", ""));
                    if (!File.Exists(streamingPath))
                        needsDownload = true;
                }

                if (needsDownload)
                {
                    PendingDownloads.Add(new DownloadResInfo
                    {
                        pathName = path,
                        MD5 = remoteFile.MD5,
                        size = remoteFile.size,
                        ver = remoteFile.ver
                    });
                    TotalDownloadSize += (ulong)remoteFile.size;
                }
            }

            // Also check optional files (on-demand content)
            foreach (var kvp in _remotePatchFileList.OptionalPatchFileList)
            {
                string path = kvp.Key;
                var remoteFile = kvp.Value;

                // Optional files are NOT auto-downloaded
                // They're downloaded on-demand via DlcModule.DownloadAssetBundleAsync
                // We just log them for awareness
            }
        }

        void SetState(UpdateState state, string message)
        {
            CurrentState = state;
            OnStateChanged?.Invoke(state, message);
        }
    }
}
