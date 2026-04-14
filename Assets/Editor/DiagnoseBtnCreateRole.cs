using UnityEngine;
using UnityEngine.UI;

public static class DiagnoseBtnCreateRole
{
    public static void Execute()
    {
        // 1. Find all btnCreateRole buttons in scene
        int count = 0;
        foreach (var btn in Object.FindObjectsOfType<Button>(true))
        {
            if (btn.name == "btnCreateRole")
            {
                count++;
                string root = btn.transform.root.name;
                bool active = btn.gameObject.activeInHierarchy;
                int listeners = btn.onClick.GetPersistentEventCount();
                Debug.Log($"[Diag] btnCreateRole #{count}: root={root}, activeInHierarchy={active}, persistentListeners={listeners}, go.activeSelf={btn.gameObject.activeSelf}");

                // Check parent chain
                var t = btn.transform;
                string chain = btn.name;
                while (t.parent != null) { t = t.parent; chain = t.name + "/" + chain; }
                Debug.Log($"[Diag]   path: {chain}");
            }
        }
        Debug.Log($"[Diag] Total btnCreateRole buttons found: {count}");

        // 2. Check SelectRoleRuntimeBridge
        var bridges = Object.FindObjectsOfType<SelectRoleRuntimeBridge>(true);
        Debug.Log($"[Diag] SelectRoleRuntimeBridge instances: {bridges.Length}");
        foreach (var b in bridges)
        {
            Debug.Log($"[Diag]   Bridge on: {b.gameObject.name}, root={b.transform.root.name}, active={b.gameObject.activeInHierarchy}");
        }

        // 3. Check if btnCreateRole in SelectRole hierarchy has runtime listeners
        // We can't directly count runtime listeners, but we can test invoke
        foreach (var btn in Object.FindObjectsOfType<Button>(true))
        {
            if (btn.name == "btnCreateRole" && btn.transform.root.name.Contains("SelectRole"))
            {
                Debug.Log($"[Diag] Testing btnCreateRole invoke on SelectRole...");
                btn.onClick.Invoke();
                Debug.Log($"[Diag] Invoke completed");
                break;
            }
        }
    }
}
