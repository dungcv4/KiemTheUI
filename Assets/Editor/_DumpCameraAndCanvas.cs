using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.Text;

// Reports Camera.main settings and Canvas details to diagnose why M_SL
// (which exists in hierarchy) doesn't render visually. Possibilities:
// 1. SSC canvas has wrong planeDistance / scaleFactor making content off-screen
// 2. Camera ortho/perspective settings clip the avatar
// 3. Canvas worldCamera != Camera.main
public static class _DumpCameraAndCanvas
{
    public static string Execute()
    {
        var sb = new StringBuilder();
        sb.AppendLine("=== Camera + Canvas dump ===");

        // Camera
        var cam = Camera.main;
        if (cam != null)
        {
            sb.AppendLine($"Camera.main: {cam.name}");
            sb.AppendLine($"  ortho={cam.orthographic} orthoSize={cam.orthographicSize} fov={cam.fieldOfView}");
            sb.AppendLine($"  near={cam.nearClipPlane} far={cam.farClipPlane}");
            sb.AppendLine($"  pos={cam.transform.position} rot={cam.transform.eulerAngles}");
            sb.AppendLine($"  cullingMask=0x{cam.cullingMask:X8}");
        }
        else
        {
            sb.AppendLine("Camera.main: NULL");
        }

        // All canvases
        sb.AppendLine("--- Canvases ---");
        foreach (var c in Object.FindObjectsOfType<Canvas>(true))
        {
            var rt = c.transform as RectTransform;
            sb.AppendLine($"  {c.name}: mode={c.renderMode} order={c.sortingOrder} cam={c.worldCamera?.name ?? "<null>"} planeDist={c.planeDistance}");
            sb.AppendLine($"    rt scale={rt.localScale} pos={rt.position} sizeDelta={rt.sizeDelta}");
            sb.AppendLine($"    active={c.gameObject.activeInHierarchy} scaleFactor={c.scaleFactor}");
        }

        Debug.Log(sb.ToString());
        return sb.ToString();
    }
}
