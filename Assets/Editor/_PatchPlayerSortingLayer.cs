#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

namespace KTO.Editor.MapImport
{
    // Runtime probe: change live player SortingGroup.sortingLayerName from
    // "Default" → "Player" so we can VERIFY visually whether that fixes the
    // hidden-player regression before baking the change into PlayerAssembler.cs.
    public static class _PatchPlayerSortingLayer
    {
        public static void Execute()
        {
            var p = GameObject.Find("Player_ma_000a_free");
            if (p == null) { Debug.LogError("[_PatchPlayerSortingLayer] no player"); return; }
            var sg = p.GetComponent<SortingGroup>();
            if (sg == null) { Debug.LogError("[_PatchPlayerSortingLayer] no SortingGroup"); return; }
            string before = $"layer='{sg.sortingLayerName}'(id={sg.sortingLayerID}) order={sg.sortingOrder}";
            sg.sortingLayerName = "Player";
            sg.sortingOrder = 1000;
            string after = $"layer='{sg.sortingLayerName}'(id={sg.sortingLayerID}) order={sg.sortingOrder}";
            Debug.Log($"[_PatchPlayerSortingLayer] BEFORE  {before}");
            Debug.Log($"[_PatchPlayerSortingLayer] AFTER   {after}");
        }
    }
}
#endif
