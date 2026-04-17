using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public static class TestEnterGame
{
    [MenuItem("KTO/Test/Click Vào Giang Hồ")]
    public static void Click()
    {
        // Prefer btnEnterGame (SelectRole screen) over btnLoginServer (Login screen)
        var buttons = Object.FindObjectsOfType<Button>(true);
        foreach (var b in buttons)
        {
            if (b.name == "btnEnterGame")
            {
                Debug.Log($"[TestEnterGame] Clicking {b.name}");
                b.onClick?.Invoke();
                return;
            }
        }
        // Fall back to force-calling OnEnterGame via SelectRoleRuntimeBridge
        var bridges = Object.FindObjectsOfType<SelectRoleRuntimeBridge>(true);
        if (bridges != null && bridges.Length > 0)
        {
            var bridge = bridges[0];
            // Invoke OnEnterGame via reflection (it's private)
            var m = bridge.GetType().GetMethod("OnEnterGame", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            if (m != null)
            {
                Debug.Log("[TestEnterGame] Invoking SelectRoleRuntimeBridge.OnEnterGame via reflection");
                m.Invoke(bridge, null);
                return;
            }
        }
        Debug.LogWarning("[TestEnterGame] No enter path. Falling back to LoginManager.SelectRole");
        var lm = KTO.Network.LoginManager.Instance;
        if (lm != null && lm.Roles.Count > 0)
            lm.SelectRole(lm.Roles[0].RoleID);
    }
}
