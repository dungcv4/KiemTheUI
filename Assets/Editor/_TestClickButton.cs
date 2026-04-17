using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEditor;
using System.Text;

// Tries to programmatically click each Button in UISelectRoleExist_Canvas
// to confirm the EventSystem + GraphicRaycaster + button onClick wiring is
// working. Lists every button found, its name, and whether onClick has any
// listeners.
public static class _TestClickButton
{
    public static string Execute()
    {
        var sb = new StringBuilder();
        sb.AppendLine("=== Test buttons in UISelectRoleExist ===");

        var es = Object.FindObjectOfType<EventSystem>();
        sb.AppendLine($"EventSystem present: {es != null}");

        var sre = GameObject.Find("UISelectRoleExist_Canvas");
        if (sre == null)
        {
            sb.AppendLine("UISelectRoleExist_Canvas NOT FOUND");
            Debug.Log(sb.ToString());
            return sb.ToString();
        }

        var canvas = sre.GetComponent<Canvas>();
        var rc = sre.GetComponent<GraphicRaycaster>();
        sb.AppendLine($"Canvas: mode={canvas?.renderMode} sortOrder={canvas?.sortingOrder} cam={canvas?.worldCamera?.name ?? "<null>"}");
        sb.AppendLine($"GraphicRaycaster: {(rc != null ? "present" : "MISSING")}");

        var buttons = sre.GetComponentsInChildren<Button>(true);
        sb.AppendLine($"Buttons found: {buttons.Length}");
        foreach (var btn in buttons)
        {
            int listeners = btn.onClick.GetPersistentEventCount();
            sb.AppendLine($"  - {GetPath(btn.transform)} interactable={btn.interactable} listeners={listeners}");
        }

        // Try clicking the first button (just invoke onClick to see if any handler fires)
        if (buttons.Length > 0)
        {
            var first = buttons[0];
            sb.AppendLine($"Invoking onClick on first button: {first.name}");
            first.onClick.Invoke();
            sb.AppendLine("  → onClick.Invoke() returned");
        }

        Debug.Log(sb.ToString());
        return sb.ToString();
    }

    private static string GetPath(Transform t)
    {
        if (t == null) return "<null>";
        var path = t.name;
        var p = t.parent;
        while (p != null) { path = p.name + "/" + path; p = p.parent; }
        return path;
    }
}
