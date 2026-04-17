// Source: _shared/DecompiledSource/GetResourceFullPathType.cs
// Result of ResourceDef.GetResourceFullPath — where the resource was found.

namespace KTO.Resource
{
    public enum GetResourceFullPathType
    {
        Invalid,       // 0 — resource not found in either location
        InStreaming,   // 1 — found in StreamingAssets (shipped with APK)
        InPersistent   // 2 — found in PersistentDataPath (downloaded patch)
    }
}
