using UnityEngine;

public static class DiagClickEffectRuntime
{
    public static string Execute()
    {
        var sb = new System.Text.StringBuilder();
        sb.AppendLine($"IsPlaying: {Application.isPlaying}");

        // Find all active Click_Effects in the scene
        var allPS = Object.FindObjectsByType<ParticleSystem>(FindObjectsSortMode.None);
        foreach (var ps in allPS)
        {
            if (ps.name != "Click_Effect") continue;
            var t = ps.transform;
            sb.AppendLine($"\nClick_Effect: activeInHierarchy={t.gameObject.activeInHierarchy}");
            sb.AppendLine($"  worldPos=({t.position.x:F1},{t.position.y:F1},{t.position.z:F1})");
            sb.AppendLine($"  parent={t.parent?.name}, gparent={t.parent?.parent?.name}");

            // Check imgSelected parent
            if (t.parent != null && t.parent.name == "imgSelected")
            {
                var rt = t.parent.GetComponent<RectTransform>();
                if (rt != null)
                {
                    var screenPos = RectTransformUtility.WorldToScreenPoint(Camera.main, rt.position);
                    sb.AppendLine($"  imgSelected screenPos=({screenPos.x:F0},{screenPos.y:F0})");
                    sb.AppendLine($"  imgSelected worldPos=({rt.position.x:F1},{rt.position.y:F1},{rt.position.z:F1})");
                }
            }

            // Check children
            for (int i = 0; i < t.childCount; i++)
            {
                var ch = t.GetChild(i);
                var chPS = ch.GetComponent<ParticleSystem>();
                var chPSR = ch.GetComponent<ParticleSystemRenderer>();
                sb.Append($"  {ch.name}: active={ch.gameObject.activeInHierarchy}");
                if (chPS != null) sb.Append($", particleCount={chPS.particleCount}");
                if (chPSR != null) sb.Append($", sortOrder={chPSR.sortingOrder}");
                sb.AppendLine();
            }
        }
        return sb.ToString();
    }
}
