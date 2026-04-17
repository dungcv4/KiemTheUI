// =======================================================================
//  ResourceDef.cs — Resource path resolution (Phase R1.1)
//
//  Source: _shared/DecompiledSource/ResourceDef.cs (field layout)
//  IL2CPP: KTO_DecompiledReference/_root/ResourceDef.c (method bodies)
//
//  Original architecture:
//    - Static class with path constants for StreamingAssets and PersistentData
//    - GetResourceFullPath tries persistent first (downloaded patches),
//      falls back to streaming (shipped with APK)
//    - Platform-specific path construction (Android, iOS, etc.)
//
//  This is the foundation all bundle loading depends on.
// =======================================================================

using System.IO;
using UnityEngine;

namespace KTO.Resource
{
    public static class ResourceDef
    {
        // --- Path constants ---
        // Source: ResourceDef.cs static fields + .cctor

        /// <summary>Relative path from StreamingAssets/PersistentData to bundles root.</summary>
        public static readonly string BundlesPathRelative = "Bundles";

        /// <summary>File protocol prefix for local file access.</summary>
        public static readonly string FileProtocol = "file://";

        // --- Computed paths (set once in Init) ---

        /// <summary>Full path to StreamingAssets bundle directory (e.g. .../StreamingAssets/Bundles/Android/)</summary>
        public static string StreamingResPath { get; private set; }

        /// <summary>Full path to PersistentDataPath bundle directory (e.g. .../PersistentData/Bundles/Android/)</summary>
        public static string PersistentBundlePath { get; private set; }

        /// <summary>PersistentDataPath without file:// protocol.</summary>
        public static string PersistentPathWithoutFileProtocol { get; private set; }

        /// <summary>PersistentDataPath with file:// protocol.</summary>
        public static string PersistentPath { get; private set; }

        /// <summary>PersistentDataPath + Bundles/ + Platform/ (no file:// prefix).</summary>
        public static string PersistentResPath { get; private set; }

        static bool s_initialized;

        // =================================================================
        //  Init — Set up all path constants once
        //
        //  Source: ResourceDef.cctor + IL2CPP ResourceDef__get_StreamingResPath
        //  Must be called before any bundle loading.
        // =================================================================
        public static void Init()
        {
            if (s_initialized) return;
            s_initialized = true;

            string platform = GetBuildPlatformName();

            // StreamingAssets path
            // Source: IL2CPP — combines streamingAssetsPath + "/" for most platforms
            // Android: jar:file:// already has protocol
            // Others: file://
            StreamingResPath = Path.Combine(
                Application.streamingAssetsPath,
                BundlesPathRelative,
                platform
            );

            // PersistentDataPath
            // Source: IL2CPP ResourceDef__get_PersistentBundlePath
            //   = Format(GameEnv.GetPersistent(0)) → persistentDataPath + "/Bundles/Platform/"
            PersistentPathWithoutFileProtocol = Application.persistentDataPath;
            PersistentPath = FileProtocol + PersistentPathWithoutFileProtocol;

            PersistentResPath = Path.Combine(
                PersistentPathWithoutFileProtocol,
                BundlesPathRelative,
                platform
            );

            PersistentBundlePath = PersistentResPath;

            Debug.Log($"[ResourceDef] Init: streaming={StreamingResPath}");
            Debug.Log($"[ResourceDef] Init: persistent={PersistentBundlePath}");
        }

        // =================================================================
        //  GetResourceFullPath — Resolve a bundle URL to a local file path
        //
        //  Source: IL2CPP ResourceDef__GetResourceFullPath (0x0190918c)
        //    Tries persistent first (downloaded patches), then streaming (APK).
        //    Returns the type of location found.
        //
        //  url: relative bundle path, e.g. "ui/atlas/guide/res_a_1.ab"
        // =================================================================
        public static string GetResourceFullPath(string url, bool withFileProtocol = true)
        {
            string fullPath;
            var result = GetResourceFullPath(url, withFileProtocol, out fullPath);
            return result != GetResourceFullPathType.Invalid ? fullPath : null;
        }

        public static GetResourceFullPathType GetResourceFullPath(
            string url, bool withFileProtocol, out string fullPath)
        {
            if (string.IsNullOrEmpty(url))
            {
                fullPath = null;
                return GetResourceFullPathType.Invalid;
            }

            // Source: IL2CPP — tries persistent first, then streaming
            // Priority: PersistentDataPath > StreamingAssets
            // This is how patches override base APK bundles.
            if (TryGetPersistentUrl(url, withFileProtocol, out fullPath))
            {
                return GetResourceFullPathType.InPersistent;
            }

            if (TryGetStreamingUrl(url, withFileProtocol, out fullPath))
            {
                return GetResourceFullPathType.InStreaming;
            }

            fullPath = null;
            return GetResourceFullPathType.Invalid;
        }

        // =================================================================
        //  TryGetPersistentUrl — Check if bundle exists in PersistentDataPath
        //
        //  Source: IL2CPP ResourceDef__TryGetPersistentUrl (0x01914087)
        //    Combines persistent path + url, then File.Exists check.
        // =================================================================
        public static bool TryGetPersistentUrl(string url, bool withFileProtocol, out string newUrl)
        {
            string rawPath = Path.Combine(PersistentBundlePath, url);

            if (File.Exists(rawPath))
            {
                newUrl = withFileProtocol ? (FileProtocol + rawPath) : rawPath;
                return true;
            }

            newUrl = null;
            return false;
        }

        // =================================================================
        //  TryGetStreamingUrl — Build path into StreamingAssets
        //
        //  Source: IL2CPP ResourceDef__TryGetStreamingUrl (0x0191411e)
        //    Returns true always (streaming assets assumed to exist).
        //    On Android, StreamingAssets are inside the APK jar, so
        //    File.Exists doesn't work — we always return true.
        // =================================================================
        public static bool TryGetStreamingUrl(string url, bool withFileProtocol, out string newUrl)
        {
            // Source: IL2CPP always returns 1 (true) for streaming
            // Streaming assets are packaged in APK, can't File.Exists on Android
            string rawPath = Path.Combine(StreamingResPath, url);

#if UNITY_EDITOR
            // In editor, verify the file actually exists
            if (!File.Exists(rawPath))
            {
                newUrl = null;
                return false;
            }
#endif

            newUrl = withFileProtocol ? (FileProtocol + rawPath) : rawPath;
            return true;
        }

        // =================================================================
        //  IsResourceExist — Check if a bundle exists at either location
        //
        //  Source: IL2CPP ResourceDef__IsResourceExist (0x019142f8)
        // =================================================================
        public static bool IsResourceExist(string url)
        {
            string dummy;
            return GetResourceFullPath(url, false, out dummy) != GetResourceFullPathType.Invalid;
        }

        // =================================================================
        //  GetBuildPlatformName — Returns platform string for bundle paths
        //
        //  Source: IL2CPP ResourceDef__GetBuildPlatformName (0x01908f36)
        //    Hash-based comparison of Application.platform
        // =================================================================
        public static string GetBuildPlatformName()
        {
            // Source: IL2CPP ResourceDef__GetBuildPlatformName (0x01908f36)
            //   Hash-based comparison of Application.platform
            //   In editor: uses EditorUserBuildSettings.activeBuildTarget
#if UNITY_EDITOR
            // In editor, match the active build target so we load the right bundles
            var target = UnityEditor.EditorUserBuildSettings.activeBuildTarget;
            switch (target)
            {
                case UnityEditor.BuildTarget.Android: return "Android";
                case UnityEditor.BuildTarget.iOS: return "iOS";
                case UnityEditor.BuildTarget.WebGL: return "WebGL";
                case UnityEditor.BuildTarget.StandaloneWindows64: return "Win64";
                case UnityEditor.BuildTarget.StandaloneLinux64: return "Linux";
                case UnityEditor.BuildTarget.StandaloneOSX: return "macOS";
                default: return "Android";
            }
#elif UNITY_ANDROID
            return "Android";
#elif UNITY_IOS
            return "iOS";
#elif UNITY_WEBGL
            return "WebGL";
#elif UNITY_STANDALONE_WIN
            return "Win64";
#elif UNITY_STANDALONE_LINUX
            return "Linux";
#elif UNITY_STANDALONE_OSX
            return "macOS";
#else
            return "Android";
#endif
        }

        // =================================================================
        //  EnsurePersistentDirectoryExists — Create PersistentData/Bundles
        //
        //  DEVIATION — not in original source
        //  Reason: original copies APK bundles to persistent on first launch
        //          via KUpdaterMgr.ProcessFirstUnpackAssets. We need the
        //          directory to exist for DlcModule downloads.
        // =================================================================
        public static void EnsurePersistentDirectoryExists()
        {
            if (!Directory.Exists(PersistentBundlePath))
            {
                Directory.CreateDirectory(PersistentBundlePath);
                Debug.Log($"[ResourceDef] Created persistent bundle directory: {PersistentBundlePath}");
            }
        }
    }
}
