#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;

namespace KTO.Editor.MapImport
{
    // One-shot MCP entry point. Calls KTO_MapImporter.ImportMap so we
    // don't have to depend on a MenuItem invocation through the bridge.
    // Safe to leave checked in — does nothing unless explicitly invoked.
    public static class _RunMapImport
    {
        public static void Execute()
        {
            var t0 = System.DateTime.UtcNow;
            try
            {
                Debug.Log("[_RunMapImport] BEGIN ImportMap(\"yunzhongzhen1_a\")");
                KTO_MapImporter.ImportMap("yunzhongzhen1_a");
                var dt = (System.DateTime.UtcNow - t0).TotalSeconds;
                Debug.Log($"[_RunMapImport] END OK in {dt:F1}s");
            }
            catch (System.Exception e)
            {
                var dt = (System.DateTime.UtcNow - t0).TotalSeconds;
                Debug.LogError($"[_RunMapImport] FAILED after {dt:F1}s: {e.GetType().Name}: {e.Message}\n{e.StackTrace}");
                throw;
            }
        }
    }
}
#endif
