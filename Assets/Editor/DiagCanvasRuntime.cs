using UnityEngine;
using UnityEngine.UI;

public static class DiagCanvasRuntime
{
    public static string Execute()
    {
        var sb = new System.Text.StringBuilder();
        sb.AppendLine($"IsPlaying: {Application.isPlaying}");
        sb.AppendLine($"Camera.main: {(Camera.main != null ? Camera.main.name : "NULL")}");

        // Check all root canvases
        var canvases = Object.FindObjectsByType<Canvas>(FindObjectsSortMode.None);
        foreach (var c in canvases)
        {
            if (!c.isRootCanvas) continue;
            sb.AppendLine($"\nCanvas: {c.name}");
            sb.AppendLine($"  renderMode={c.renderMode}, enabled={c.enabled}");
            sb.AppendLine($"  sortingLayer={c.sortingLayerName}, order={c.sortingOrder}");
            sb.AppendLine($"  camera={c.worldCamera?.name ?? "NULL"}");
            sb.AppendLine($"  gameObject.active={c.gameObject.activeSelf}");

            var scaler = c.GetComponent<CanvasScaler>();
            if (scaler != null)
                sb.AppendLine($"  scaler: mode={scaler.uiScaleMode}, refRes={scaler.referenceResolution}");
        }

        // Check avatar animator controllers more carefully
        var host = GameObject.Find("UILoginBG/Character/_AvatarHost");
        if (host != null)
        {
            for (int i = 0; i < host.transform.childCount; i++)
            {
                var child = host.transform.GetChild(i);
                var anim = child.GetComponent<Animator>();
                if (anim != null)
                {
                    sb.AppendLine($"\nAvatar {child.name}:");
                    sb.AppendLine($"  runtimeController: {anim.runtimeAnimatorController?.name ?? "NULL"}");
                    sb.AppendLine($"  type: {anim.runtimeAnimatorController?.GetType().Name ?? "N/A"}");
#if UNITY_EDITOR
                    // Check the prefab source
                    var prefabSource = UnityEditor.PrefabUtility.GetCorrespondingObjectFromSource(child.gameObject);
                    if (prefabSource != null)
                    {
                        var srcAnim = prefabSource.GetComponent<Animator>();
                        sb.AppendLine($"  prefabSource.ctrl: {srcAnim?.runtimeAnimatorController?.name ?? "NULL"}");
                    }
                    else
                    {
                        sb.AppendLine($"  prefabSource: NULL (not a prefab instance)");
                    }
#endif
                }
            }
        }

        return sb.ToString();
    }
}
