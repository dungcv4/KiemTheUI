using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.Text;

// Test if WHT chars become visible after toggling Character canvas
// (force re-batch). Also tests SetAllDirty on each image. Helps determine
// if the issue is stale canvas batch vs sprite/Image config.
public static class _TestCanvasRefresh
{
    public static string Execute()
    {
        var sb = new StringBuilder();

        Transform charT = null;
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
        {
            if (t.name == "Character" && t.parent != null && t.parent.name == "UILoginBG")
            { charT = t; break; }
        }
        if (charT == null) { sb.AppendLine("Character NOT FOUND"); Debug.Log(sb.ToString()); return sb.ToString(); }

        var canvas = charT.GetComponent<Canvas>();
        if (canvas == null) { sb.AppendLine("Character canvas NOT FOUND"); Debug.Log(sb.ToString()); return sb.ToString(); }

        // Toggle to force re-batch
        sb.AppendLine($"Canvas before toggle: enabled={canvas.enabled} override={canvas.overrideSorting} order={canvas.sortingOrder}");
        canvas.enabled = false;
        canvas.enabled = true;
        sb.AppendLine($"Canvas after toggle: enabled={canvas.enabled}");

        // SetAllDirty on every Image inside Character
        int dirtyCount = 0;
        foreach (var img in charT.GetComponentsInChildren<Image>(true))
        {
            img.SetAllDirty();
            dirtyCount++;
        }
        sb.AppendLine($"SetAllDirty on {dirtyCount} Images");

        // Toggle GameObject active
        var hostT = charT.Find("_AvatarHost");
        if (hostT != null)
        {
            hostT.gameObject.SetActive(false);
            hostT.gameObject.SetActive(true);
            sb.AppendLine($"Toggled _AvatarHost active");
        }

        Debug.Log(sb.ToString());
        return sb.ToString();
    }
}
