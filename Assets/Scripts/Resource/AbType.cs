// Source: _shared/DecompiledSource/AbType.cs
// Asset Bundle type classification — determines how BundleManager handles each bundle.

namespace KTO.Resource
{
    public enum AbType
    {
        none,       // 0
        shader,     // 1
        font,       // 2
        atlas,      // 3
        prefab,     // 4
        unity,      // 5 (scene bundles)
        common,     // 6
        sound,      // 7
        sprite      // 8
    }
}
