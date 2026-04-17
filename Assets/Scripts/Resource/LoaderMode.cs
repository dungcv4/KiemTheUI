// Source: _shared/DecompiledSource/LoaderMode.cs
// Determines whether a loader operates synchronously or asynchronously.

namespace KTO.Resource
{
    public enum LoaderMode
    {
        Async,  // 0 — non-blocking, uses coroutines / AssetBundleCreateRequest
        Sync    // 1 — blocking, uses AssetBundle.LoadFromFile directly
    }
}
