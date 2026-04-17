#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;

namespace KTO.Editor.MapImport
{
    public static class _DumpSortingLayers
    {
        public static void Execute()
        {
            Debug.Log("[_DumpSortingLayers] === Live SortingLayer table ===");
            foreach (var l in SortingLayer.layers)
            {
                // Unity exposes id as signed int. The bundle stores the same
                // value as a uint hash. Print both for direct comparison.
                int signed = l.id;
                uint asUInt = unchecked((uint)signed);
                Debug.Log($"[_DumpSortingLayers]   '{l.name}'  id(signed)={signed}  id(uint)={asUInt}");
            }
            Debug.Log($"[_DumpSortingLayers] Count = {SortingLayer.layers.Length}");

            // Also dump raw layer-name slots 6,7,8,9 to make sure our additive
            // merge didn't get clobbered.
            for (int i = 0; i < 32; i++)
            {
                var nm = LayerMask.LayerToName(i);
                if (!string.IsNullOrEmpty(nm))
                    Debug.Log($"[_DumpSortingLayers]   layer[{i}] = '{nm}'");
            }
        }
    }
}
#endif
