// Inspect the actual grid container state at runtime.
// Menu: KTO → Debug → Diag Bag Grid
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public static class DiagBagGrid
{
    [MenuItem("KTO/Debug/Diag Bag Grid")]
    public static void Run()
    {
        if (!Application.isPlaying) { Debug.LogWarning("Play mode only"); return; }
        var root = GameObject.Find("UIBag");
        if (root == null) { Debug.LogWarning("UIBag not open"); return; }

        var itemCellTr = root.transform.Find("imgBG/BagPanel/bagItemSV/BIViewport/BIContent/ItemCell");
        if (itemCellTr == null) { Debug.LogWarning("ItemCell not found"); return; }
        var rt = itemCellTr as RectTransform;
        var grid = itemCellTr.GetComponent<GridLayoutGroup>();
        int childCount = itemCellTr.childCount;
        Debug.Log($"[DiagBagGrid] ItemCell rect={rt?.rect} childCount={childCount}");
        if (grid != null)
        {
            Debug.Log($"[DiagBagGrid] Grid cellSize={grid.cellSize} spacing={grid.spacing} constraint={grid.constraint} count={grid.constraintCount} startAxis={grid.startAxis}");
        }
        for (int i = 0; i < Mathf.Min(childCount, 10); i++)
        {
            var child = itemCellTr.GetChild(i);
            var crt = child as RectTransform;
            Debug.Log($"[DiagBagGrid]   [{i}] {child.name} active={child.gameObject.activeSelf} anchoredPos={crt?.anchoredPosition} size={crt?.sizeDelta}");
        }

        // Also check the viewport
        var viewport = root.transform.Find("imgBG/BagPanel/bagItemSV/BIViewport") as RectTransform;
        if (viewport != null) Debug.Log($"[DiagBagGrid] BIViewport rect={viewport.rect}");
        var content = root.transform.Find("imgBG/BagPanel/bagItemSV/BIViewport/BIContent") as RectTransform;
        if (content != null) Debug.Log($"[DiagBagGrid] BIContent rect={content.rect} anchoredPos={content.anchoredPosition}");
    }
}
