// One-shot: simulate user clicking Enter Game after login flow is Ready.
// Verifies the fix for "Not connected, cannot send CMD 104":
//   - LoginManager.ConnectToServer is idempotent now when session is alive
//   - SelectRole sends CMD 104 on the live connection
// Menu: KTO → Debug → Test Enter Game Flow
using UnityEditor;
using UnityEngine;
using KTO.Network;

public static class TestEnterGameFlow
{
    [MenuItem("KTO/Debug/Test Enter Game Flow")]
    public static void Run()
    {
        if (!Application.isPlaying)
        {
            Debug.LogWarning("[TestEnterGameFlow] Editor must be in Play mode.");
            return;
        }

        var lm = LoginManager.Instance ?? Object.FindObjectOfType<LoginManager>();
        if (lm == null)
        {
            Debug.LogError("[TestEnterGameFlow] LoginManager not found (Instance null, no scene instance).");
            return;
        }

        Debug.Log($"[TestEnterGameFlow] State={lm.State}, Roles={lm.Roles?.Count}");
        if (lm.State != LoginState.Ready)
        {
            Debug.LogWarning($"[TestEnterGameFlow] State != Ready (got {lm.State}), waiting...");
            return;
        }

        // First: re-call ConnectToServer — should be a NO-OP now thanks to the fix
        if (lm.SelectedServer != null)
        {
            Debug.Log("[TestEnterGameFlow] Calling ConnectToServer again (should be idempotent)…");
            lm.ConnectToServer(lm.SelectedServer);
        }

        // Then trigger SelectRole (first role)
        if (lm.Roles != null && lm.Roles.Count > 0)
        {
            int id = lm.Roles[0].RoleID;
            Debug.Log($"[TestEnterGameFlow] SelectRole({id}) → should send CMD_INIT_GAME (104)");
            lm.SelectRole(id);
        }
        else
        {
            Debug.LogError("[TestEnterGameFlow] No roles available.");
        }
    }
}
