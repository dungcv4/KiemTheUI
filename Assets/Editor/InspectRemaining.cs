using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public static class InspectRemaining
{
    public static void Execute()
    {
        var prefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefabs/Imported/UICreateRole.prefab");
        if (prefab == null) { Debug.LogError("[Insp] no prefab"); return; }

        // 1. Find any Text containing "天" / Chinese
        Debug.Log("== Chinese Texts remaining ==");
        foreach (var t in prefab.GetComponentsInChildren<Text>(true))
        {
            if (t.text == null) continue;
            bool hasHan = false;
            foreach (var c in t.text)
                if (c >= 0x4E00 && c <= 0x9FFF) { hasHan = true; break; }
            if (hasHan)
                Debug.Log($"[Insp] '{t.text}' @ {GetPath(t.transform)} (active={t.gameObject.activeSelf})");
        }

        // 2. txtSelectedSeries hierarchy + parent rect
        var ts = prefab.transform.Find("imgBG/SelectSeries/txtSelectedSeries");
        if (ts == null)
        {
            // search broadly
            foreach (var x in prefab.GetComponentsInChildren<Transform>(true))
                if (x.name == "txtSelectedSeries") { ts = x; break; }
        }
        if (ts != null)
        {
            Debug.Log($"[Insp] txtSelectedSeries path={GetPath(ts)}");
            var rt = ts.GetComponent<RectTransform>();
            Debug.Log($"[Insp]   rt anchored={rt.anchoredPosition} size={rt.sizeDelta} aMin={rt.anchorMin} aMax={rt.anchorMax} pivot={rt.pivot}");
            var prt = ts.parent.GetComponent<RectTransform>();
            Debug.Log($"[Insp]   parent={ts.parent.name} anchored={prt.anchoredPosition} size={prt.sizeDelta}");
            var txt = ts.GetComponent<Text>();
            if (txt != null)
                Debug.Log($"[Insp]   text='{txt.text}' fontSize={txt.fontSize} align={txt.alignment} hOver={txt.horizontalOverflow}");
        }
        else Debug.Log("[Insp] txtSelectedSeries NOT FOUND");

        // 3. btnReturn
        Transform btn = null;
        foreach (var x in prefab.GetComponentsInChildren<Transform>(true))
            if (x.name == "btnReturn") { btn = x; break; }
        if (btn != null)
        {
            var rt = btn.GetComponent<RectTransform>();
            Debug.Log($"[Insp] btnReturn @ {GetPath(btn)} active={btn.gameObject.activeSelf} pos={rt.anchoredPosition} size={rt.sizeDelta}");
            foreach (var img in btn.GetComponentsInChildren<Image>(true))
                Debug.Log($"[Insp]   img name={img.name} sprite={(img.sprite!=null?img.sprite.name:"NULL")} alpha={img.color.a}");
        }
        else Debug.Log("[Insp] btnReturn NOT FOUND");
    }

    static string GetPath(Transform t)
    {
        var s = t.name;
        while (t.parent != null) { t = t.parent; s = t.name + "/" + s; }
        return s;
    }
}
