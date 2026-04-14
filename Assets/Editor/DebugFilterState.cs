using UnityEngine;
using UnityEditor;
using System.Reflection;

public class DebugFilterState
{
    public static void Execute()
    {
        var ctrl = Object.FindObjectOfType<LoginSceneController>();
        if (ctrl == null)
        {
            Debug.Log("[DebugFilter] LoginSceneController NOT FOUND");
            return;
        }

        var flags = BindingFlags.NonPublic | BindingFlags.Instance;
        var t = ctrl.GetType();

        bool filterNew = (bool)t.GetField("_filterNew", flags).GetValue(ctrl);
        bool filterRec = (bool)t.GetField("_filterRecommend", flags).GetValue(ctrl);
        bool filterMnt = (bool)t.GetField("_filterMaintain", flags).GetValue(ctrl);
        bool filterFul = (bool)t.GetField("_filterFull", flags).GetValue(ctrl);
        int kindIndex = (int)t.GetField("_kindIndex", flags).GetValue(ctrl);

        Debug.Log($"[DebugFilter] filterNew={filterNew} filterRecommend={filterRec} filterMaintain={filterMnt} filterFull={filterFul} kindIndex={kindIndex}");

        // Check spawned server buttons count
        var spawnedField = t.GetField("_spawnedServerBtns", flags);
        if (spawnedField != null)
        {
            var list = spawnedField.GetValue(ctrl) as System.Collections.Generic.List<GameObject>;
            int active = 0;
            if (list != null)
            {
                foreach (var go in list)
                    if (go != null && go.activeInHierarchy) active++;
                Debug.Log($"[DebugFilter] Spawned server buttons: {list.Count} total, {active} active");
            }
        }

        // Check spawned kind buttons
        var kindField = t.GetField("_spawnedKindBtns", flags);
        if (kindField != null)
        {
            var list = kindField.GetValue(ctrl) as System.Collections.Generic.List<GameObject>;
            if (list != null)
            {
                Debug.Log($"[DebugFilter] Kind tabs: {list.Count}");
                foreach (var go in list)
                {
                    if (go == null) continue;
                    var txt = go.GetComponentInChildren<UnityEngine.UI.Text>();
                    string label = txt != null ? txt.text : "?";
                    Debug.Log($"[DebugFilter]   Tab: '{label}'");
                }
            }
        }

        // Check wndServerSetting visibility
        var panel = t.GetField("_selectServerPanel", flags)?.GetValue(ctrl) as GameObject;
        if (panel != null)
        {
            var wnd = panel.transform.Find("node/wndServerSetting");
            if (wnd != null)
                Debug.Log($"[DebugFilter] wndServerSetting active={wnd.gameObject.activeSelf}");
            else
                Debug.Log($"[DebugFilter] wndServerSetting NOT FOUND in hierarchy");
        }
    }
}
