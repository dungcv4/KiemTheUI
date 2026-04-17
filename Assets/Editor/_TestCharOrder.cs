using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.Text;

// Test progressively lower sortingOrder values for Character canvas
// to find the lowest value where M_SL still renders visibly. This
// matches the same fix UICreateRoleAvatarController.EnsureCanvasSetup
// uses for the CreateRole flow (override=true, sortingOrder=1).
public static class _TestCharOrder
{
    public static string Execute()
    {
        var sb = new StringBuilder();

        var bg = GameObject.Find("UILoginBG");
        var charT = bg?.transform.Find("Character");
        var charCanvas = charT?.GetComponent<Canvas>();
        if (charCanvas == null) { sb.AppendLine("Character canvas NOT FOUND"); Debug.Log(sb.ToString()); return sb.ToString(); }

        // Match UICreateRoleAvatarController.EnsureCanvasSetup
        charCanvas.enabled = true;
        charCanvas.overrideSorting = true;
        charCanvas.sortingLayerName = "UI";
        charCanvas.sortingOrder = 1;

        sb.AppendLine($"Character canvas → enabled=true override=true sortingLayer=UI order=1");
        Debug.Log(sb.ToString());
        return sb.ToString();
    }
}
