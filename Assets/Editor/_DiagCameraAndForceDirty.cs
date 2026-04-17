using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.Text;

public static class _DiagCameraAndForceDirty
{
    public static string Execute()
    {
        var sb = new StringBuilder();
        var cam = Camera.main;
        if (cam != null)
        {
            sb.AppendLine($"Camera.main: cullingMask={cam.cullingMask:X8} ({cam.cullingMask})");
            for (int i = 0; i < 32; i++)
            {
                if ((cam.cullingMask & (1 << i)) != 0)
                    sb.AppendLine($"  bit {i} = layer '{LayerMask.LayerToName(i)}' (rendered)");
            }
            sb.AppendLine($"  clearFlags={cam.clearFlags} backgroundColor={cam.backgroundColor}");
            sb.AppendLine($"  depth={cam.depth}");
        }

        // Force redraw
        Transform whtT = null;
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
        {
            if (t.name == "M_WHT" && t.parent != null && t.parent.name == "_AvatarHost") { whtT = t; break; }
        }
        if (whtT != null)
        {
            // Try setting layer to UI (5)
            SetLayerRecursively(whtT.gameObject, 5);
            sb.AppendLine("Set M_WHT and children to layer UI (5)");

            // Set _AvatarHost to UI too
            whtT.parent.gameObject.layer = 5;
            sb.AppendLine("Set _AvatarHost to layer UI (5)");

            // SetAllDirty on all images
            foreach (var img in whtT.parent.GetComponentsInChildren<Image>(true))
            {
                img.SetAllDirty();
            }
            sb.AppendLine("SetAllDirty on all _AvatarHost child images");

            // Toggle Character canvas to force re-batch
            var charCanvas = whtT.parent.parent.GetComponent<Canvas>();
            if (charCanvas != null)
            {
                charCanvas.enabled = false;
                charCanvas.enabled = true;
                sb.AppendLine("Toggled Character canvas enabled");
            }
        }

        Debug.Log(sb.ToString());
        return sb.ToString();
    }

    static void SetLayerRecursively(GameObject go, int layer)
    {
        go.layer = layer;
        for (int i = 0; i < go.transform.childCount; i++)
            SetLayerRecursively(go.transform.GetChild(i).gameObject, layer);
    }
}
