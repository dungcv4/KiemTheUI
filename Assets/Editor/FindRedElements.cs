using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public static class FindRedElements
{
    public static void Execute()
    {
        var prefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefabs/Imported/UICreateRole.prefab");
        foreach (var g in prefab.GetComponentsInChildren<Graphic>(true))
        {
            if (g == null) continue;
            var c = g.color;
            if (c.r > 0.6f && c.g < 0.4f && c.b < 0.4f && c.a > 0.3f)
            {
                Debug.Log($"[Red] {GetPath(g.transform)} type={g.GetType().Name} color={c}");
            }
        }
    }
    static string GetPath(Transform t)
    {
        var s = t.name;
        while (t.parent != null) { t = t.parent; s = t.name + "/" + s; }
        return s;
    }
}
