// =======================================================================
//  DownloadSpeed.cs — Speed calculator for download UI (Phase R4)
//
//  Source: _shared/DecompiledSource/DownloadSpeed.cs (field layout)
//  IL2CPP: KTO_DecompiledReference/_root/DownloadSpeed.c (Start, Update)
//
//  Calculates download speed by sampling total bytes over time.
// =======================================================================

using UnityEngine;

namespace KTO.Resource
{
    public class DownloadSpeed
    {
        // Source: DownloadSpeed fields at offsets 0x10-0x20
        ulong _lastSize;
        float _lastTime;
        public ulong speed;  // bytes per second

        // Source: IL2CPP DownloadSpeed__Start (0x01976bbd)
        public void Start()
        {
            _lastSize = 0;
            _lastTime = Time.realtimeSinceStartup;
            speed = 0;
        }

        // Source: IL2CPP DownloadSpeed__Update (0x01976bd7)
        // Called periodically with total downloaded bytes
        public void Update(ulong totalDownloaded)
        {
            float now = Time.realtimeSinceStartup;
            float elapsed = now - _lastTime;

            if (elapsed >= 1f) // update speed every second
            {
                ulong delta = totalDownloaded - _lastSize;
                speed = (ulong)(delta / elapsed);
                _lastSize = totalDownloaded;
                _lastTime = now;
            }
        }

        /// <summary>Format speed as human-readable string (KB/s or MB/s).</summary>
        public string FormatSpeed()
        {
            if (speed >= 1024 * 1024)
                return $"{speed / (1024f * 1024f):F1} MB/s";
            if (speed >= 1024)
                return $"{speed / 1024f:F1} KB/s";
            return $"{speed} B/s";
        }
    }
}
