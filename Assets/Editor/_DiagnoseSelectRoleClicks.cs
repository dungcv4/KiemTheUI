using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEditor;
using System.Text;

// Diagnoses why SelectRole UI is unclickable. Checks:
// 1. EventSystem present?
// 2. UISelectRoleExist canvas renderMode + worldCamera + sortOrder
// 3. GraphicRaycaster present?
// 4. Any blocking canvas above (sortingOrder > UISelectRoleExist)?
// 5. Background canvas name mismatch
public static class _DiagnoseSelectRoleClicks
{
    public static string Execute()
    {
        var sb = new StringBuilder();
        sb.AppendLine("=== Diagnose SelectRole clicks ===");

        // 1. EventSystem
        var es = Object.FindObjectOfType<EventSystem>();
        sb.AppendLine($"EventSystem: {(es != null ? es.gameObject.name + " active=" + es.gameObject.activeInHierarchy : "MISSING")}");
        if (es != null)
        {
            var input = es.GetComponent<StandaloneInputModule>();
            sb.AppendLine($"  StandaloneInputModule: {(input != null ? "present" : "MISSING")}");
        }

        // 2. List ALL canvases with their settings
        sb.AppendLine("--- All canvases ---");
        var canvases = Object.FindObjectsOfType<Canvas>(true);
        foreach (var c in canvases)
        {
            var raycaster = c.GetComponent<GraphicRaycaster>();
            sb.AppendLine($"  {GetPath(c.transform)} mode={c.renderMode} order={c.sortingOrder} active={c.gameObject.activeInHierarchy} raycaster={(raycaster != null ? "yes" : "NO")} cam={(c.worldCamera != null ? c.worldCamera.name : "<null>")}");
        }

        // 3. Check Background_Canvas vs BG_Canvas
        var bg1 = GameObject.Find("Background_Canvas");
        var bg2 = GameObject.Find("BG_Canvas");
        sb.AppendLine($"Background_Canvas exists: {bg1 != null}");
        sb.AppendLine($"BG_Canvas exists: {bg2 != null} active={(bg2 != null ? bg2.activeSelf.ToString() : "n/a")}");

        // 4. UISelectRoleExist canvas details
        var sre = GameObject.Find("UISelectRoleExist_Canvas");
        if (sre != null)
        {
            var canvas = sre.GetComponent<Canvas>();
            var rc = sre.GetComponent<GraphicRaycaster>();
            sb.AppendLine($"UISelectRoleExist_Canvas: mode={canvas?.renderMode} order={canvas?.sortingOrder} cam={(canvas?.worldCamera?.name ?? "<null>")} raycaster={rc != null}");

            // Check children for buttons
            int btnCount = 0;
            foreach (var btn in sre.GetComponentsInChildren<Button>(true))
            {
                btnCount++;
            }
            sb.AppendLine($"  Buttons in subtree: {btnCount}");
        }

        // 5. Camera config — Camera.main needs to be able to render UI
        var cam = Camera.main;
        if (cam != null)
        {
            sb.AppendLine($"Camera.main: name={cam.name} cullingMask={cam.cullingMask:X} clearFlags={cam.clearFlags}");
            int uiLayer = LayerMask.NameToLayer("UI");
            bool uiInMask = (cam.cullingMask & (1 << uiLayer)) != 0;
            sb.AppendLine($"  UI layer ({uiLayer}) in cullingMask: {uiInMask}");
        }
        else
        {
            sb.AppendLine("Camera.main: NULL");
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
