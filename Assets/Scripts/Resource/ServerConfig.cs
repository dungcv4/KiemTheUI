// =======================================================================
//  ServerConfig.cs — CDN/server configuration (Phase R4)
//
//  DEVIATION — not a direct class in the original source
//  Reason: Original uses VersionInfo + KUpdaterMgr__ProcessMainVersion
//  to resolve CDN URLs from server response. We centralize config here
//  for simpler setup. The URLs feed into DlcModule._updateUrl/_updateUrlBackup.
//
//  Usage: Place ServerConfig.json in Assets/Resources/
//  or set URLs programmatically via ServerConfig.SetUrls().
// =======================================================================

using System;
using UnityEngine;

namespace KTO.Resource
{
    [Serializable]
    public class ServerConfig
    {
        // CDN base URLs (must end with /)
        public string cdnUrl = "https://cdn.example.com/kto/bundles/";
        public string cdnUrlBackup = "https://backup-cdn.example.com/kto/bundles/";

        // Version check URL
        public string versionUrl = "https://cdn.example.com/kto/version/";

        // Static instance
        static ServerConfig _instance;

        public static ServerConfig Instance
        {
            get
            {
                if (_instance == null)
                    _instance = Load();
                return _instance;
            }
        }

        // Reset on Play mode (handles Domain Reload disabled)
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        static void ResetStatic() { _instance = null; }

        // Load from Resources/ServerConfig.json
        static ServerConfig Load()
        {
            var ta = Resources.Load<TextAsset>("ServerConfig");
            if (ta != null)
            {
                try
                {
                    var config = JsonUtility.FromJson<ServerConfig>(ta.text);
                    Debug.Log($"[ServerConfig] Loaded: cdn={config.cdnUrl}");
                    return config;
                }
                catch (Exception ex)
                {
                    Debug.LogWarning($"[ServerConfig] Failed to parse: {ex.Message}");
                }
            }

            Debug.Log("[ServerConfig] Using default config (no Resources/ServerConfig.json)");
            return new ServerConfig();
        }

        // Set URLs programmatically (e.g. from login server response)
        public static void SetUrls(string cdnUrl, string cdnUrlBackup = null)
        {
            if (_instance == null)
                _instance = new ServerConfig();

            _instance.cdnUrl = cdnUrl;
            _instance.cdnUrlBackup = cdnUrlBackup ?? cdnUrl;

            // Also update DlcModule URLs
            DlcModule._updateUrl = cdnUrl;
            DlcModule._updateUrlBackup = _instance.cdnUrlBackup;

            Debug.Log($"[ServerConfig] URLs set: main={cdnUrl} backup={_instance.cdnUrlBackup}");
        }
    }
}
