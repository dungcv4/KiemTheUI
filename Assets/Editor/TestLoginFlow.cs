using UnityEngine;
using UnityEditor;

public static class TestLoginFlow
{
    [MenuItem("KTO/Test/Login Flow → Click Vào Giang Hồ")]
    public static void ClickLoginButton()
    {
        // Find the login controller + trigger its click handler.
        var lsc = Object.FindObjectOfType<LoginSceneController>();
        if (lsc == null) { Debug.LogError("[TestLoginFlow] LoginSceneController not found"); return; }

        // The login controller's button wiring should exist; we trigger via reflection
        // since the button path / method name varies.
        var t = lsc.GetType();
        var methods = t.GetMethods(System.Reflection.BindingFlags.Instance
                                 | System.Reflection.BindingFlags.Public
                                 | System.Reflection.BindingFlags.NonPublic);
        foreach (var m in methods)
        {
            if (m.Name.Contains("EnterGame") || m.Name.Contains("OnLoginClick") || m.Name.Contains("DoLogin") || m.Name.Contains("OnEnterClick"))
            {
                Debug.Log($"[TestLoginFlow] Invoking {m.Name}");
                try { m.Invoke(lsc, null); return; }
                catch (System.Exception ex) { Debug.LogError($"[TestLoginFlow] {m.Name} failed: {ex.InnerException?.Message ?? ex.Message}"); }
            }
        }
        Debug.LogWarning("[TestLoginFlow] No EnterGame / DoLogin method found on LoginSceneController");

        // Fallback: call LoginManager.DoLogin directly with mock creds
        var lm = KTO.Network.LoginManager.Instance;
        if (lm != null)
        {
            Debug.Log("[TestLoginFlow] Calling LoginManager.DoLogin('test','test')");
            lm.DoLogin("test", "test");
        }
    }

    [MenuItem("KTO/Test/Login Flow → Show State")]
    public static void ShowState()
    {
        var lm = KTO.Network.LoginManager.Instance;
        if (lm == null) { Debug.LogError("LoginManager null"); return; }
        Debug.Log($"[LoginState] state={lm.State} err={lm.ErrorMessage} token={lm.AccessToken?.Substring(0, System.Math.Min(10, lm.AccessToken?.Length ?? 0))}... " +
                  $"servers={lm.Servers.Count} selected={lm.SelectedServer?.ServerName} roles={lm.Roles.Count}");
    }
}
