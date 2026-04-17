using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public static class DumpRemainingPlaceholders
{
    [MenuItem("KTO/Debug/Dump Remaining dynamic_change Placeholders")]
    public static void Run()
    {
        var texts = Object.FindObjectsOfType<Text>(true);
        int count = 0;
        foreach (var t in texts)
        {
            if (t == null || string.IsNullOrEmpty(t.text)) continue;
            if (!t.text.Contains("dynamic_change")) continue;

            // Build full path
            var path = BuildPath(t.transform);
            Debug.Log($"[Placeholder] '{t.text}' @ {path}");
            count++;
            if (count >= 30) { Debug.Log("...stopping at 30 for readability"); break; }
        }
        Debug.Log($"[Placeholder] Total: {count}");
    }

    static string BuildPath(Transform t)
    {
        var parts = new System.Collections.Generic.List<string>();
        while (t != null)
        {
            parts.Insert(0, t.name);
            t = t.parent;
        }
        return string.Join("/", parts);
    }
}
