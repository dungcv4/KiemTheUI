using UnityEngine;
using System.Collections.Generic;

public static class CountLoginBgRoots
{
    public static void Run()
    {
        var ucr = GameObject.Find("UICreateRole");
        if (ucr == null) { Debug.Log("no UICreateRole"); return; }

        Debug.Log($"--- direct children of UICreateRole ({ucr.transform.childCount}) ---");
        for (int i = 0; i < ucr.transform.childCount; i++)
        {
            var c = ucr.transform.GetChild(i);
            Debug.Log($"  [{i}] {c.name}  (children={c.childCount}, active={c.gameObject.activeInHierarchy})");
        }

        // Find anything with name starting "UILoginBG" anywhere in scene.
        var hits = new List<string>();
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
        {
            if (t.name.StartsWith("UILoginBG"))
            {
                string p = t.name;
                var pp = t.parent;
                while (pp != null) { p = pp.name + "/" + p; pp = pp.parent; }
                hits.Add(p);
            }
        }
        Debug.Log($"--- {hits.Count} UILoginBG* in entire scene ---");
        foreach (var h in hits) Debug.Log("  " + h);
    }
}
