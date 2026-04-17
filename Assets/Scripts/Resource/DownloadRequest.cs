// =======================================================================
//  DownloadRequest.cs — Individual download item (Phase R4)
//
//  Source: _shared/DecompiledSource/DownloadRequest.cs (field layout)
//  IL2CPP: KTO_DecompiledReference/_root/DownloadRequest.c (CompareTo)
//
//  IComparable for priority queue sorting — higher priority = first.
// =======================================================================

using System;

namespace KTO.Resource
{
    // Source: DownloadRequest.QueueType — maps to the 3 queues in DlcModule
    public enum DlcQueueType
    {
        Normal = 0,
        Manual = 1,
        Top = 2
    }

    public class DownloadRequest : IComparable
    {
        // Source: DownloadRequest fields at offsets 0x10-0x38
        public string szPath;      // relative bundle path (e.g. "Bundles/Android/npc/enemy005/res_n_1")
        public string md5;         // expected MD5 hash
        public int nSize;          // file size in bytes
        public int priority;       // higher = download first
        public string ver;         // version string
        public DlcQueueType queueType;

        // Download state
        public bool isCompleted;
        public float progress;
        public string error;
        public int retryCount;

        // Source: IL2CPP DownloadRequest__CompareTo (0x01bdb3d9)
        // Compares by priority for sorted queue ordering
        public int CompareTo(object obj)
        {
            if (obj is DownloadRequest other)
            {
                return other.priority.CompareTo(priority); // higher priority first
            }
            return 0;
        }

        public void Release()
        {
            szPath = null;
            md5 = null;
            ver = null;
            error = null;
            isCompleted = false;
            progress = 0f;
            retryCount = 0;
        }
    }
}
