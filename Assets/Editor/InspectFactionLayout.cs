using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public static class InspectFactionLayout
{
    public static void Execute()
    {
        var prefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefabs/Imported/UICreateRole.prefab");
        if (prefab == null) { Debug.LogError("[Inspect2] prefab not found"); return; }

        // FactionList container info
        Transform list = null;
        foreach (var t in prefab.GetComponentsInChildren<Transform>(true))
            if (t.name == "FactionList") { list = t; break; }
        if (list == null) { Debug.LogError("[Inspect2] FactionList not found"); return; }

        var rt = list.GetComponent<RectTransform>();
        var grid = list.GetComponent<GridLayoutGroup>();
        var vlg  = list.GetComponent<VerticalLayoutGroup>();
        var hlg  = list.GetComponent<HorizontalLayoutGroup>();
        var fitter = list.GetComponent<ContentSizeFitter>();
        Debug.Log($"[Inspect2] FactionList rt: anchoredPos={rt.anchoredPosition} sizeDelta={rt.sizeDelta} pivot={rt.pivot} aMin={rt.anchorMin} aMax={rt.anchorMax}");
        Debug.Log($"[Inspect2] grid={grid != null} vlg={vlg != null} hlg={hlg != null} fitter={fitter != null}");
        if (grid != null)
            Debug.Log($"[Inspect2] grid cellSize={grid.cellSize} spacing={grid.spacing} constraint={grid.constraint} count={grid.constraintCount}");
        Debug.Log($"[Inspect2] childCount={list.childCount}");

        // Fire_Effect_Ripped inspect
        Transform fire = null;
        foreach (var t in prefab.GetComponentsInChildren<Transform>(true))
            if (t.name == "Fire_Effect_Ripped") { fire = t; break; }
        if (fire != null)
        {
            Debug.Log($"[Inspect2] Fire_Effect_Ripped found, children={fire.childCount}");
            foreach (var img in fire.GetComponentsInChildren<Image>(true))
                Debug.Log($"[Inspect2]   img name={img.name} sprite={(img.sprite!=null?img.sprite.name:"NULL")} color={img.color}");
        }
        else Debug.Log("[Inspect2] Fire_Effect_Ripped not found");

        // btnReturn / btnCreate text
        foreach (var t in prefab.GetComponentsInChildren<Transform>(true))
        {
            if (t.name == "btnReturn" || t.name == "btnCreateRole")
            {
                var txt = t.GetComponentInChildren<Text>(true);
                Debug.Log($"[Inspect2] {t.name} text='{(txt != null ? txt.text : "NONE")}'");
            }
        }
    }
}
