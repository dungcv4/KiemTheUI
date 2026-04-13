using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

public static class InspectFactionTemplate
{
    public static void Execute()
    {
        EditorSceneManager.OpenScene("Assets/CreateRoleScene.unity", OpenSceneMode.Single);
        var fl = GameObject.Find("UICreateRole_Canvas/UICreateRole/imgBG/FactionSeriesList/FactionList");
        if (fl == null) { Debug.LogError("FactionList not found"); return; }
        Debug.Log($"[Inspect] FactionList childCount={fl.transform.childCount}");
        for (int i = 0; i < fl.transform.childCount; i++)
        {
            var c = fl.transform.GetChild(i);
            Debug.Log($"[Inspect]   [{i}] {c.name}  active={c.gameObject.activeSelf}");
        }
        var first = fl.transform.GetChild(1); // skip template
        Dump(first, 0);
    }

    static void Dump(Transform t, int depth)
    {
        string indent = new string(' ', depth * 2);
        Debug.Log($"[Inspect] {indent}{t.name} active={t.gameObject.activeSelf}");
        for (int i = 0; i < t.childCount; i++) Dump(t.GetChild(i), depth + 1);
    }
}
