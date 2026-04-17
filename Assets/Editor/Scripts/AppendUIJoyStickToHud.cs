using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using KTO.Game;

public static class AppendUIJoyStickToHud
{
    public static void Execute()
    {
        var scene = EditorSceneManager.OpenScene("Assets/MainUIScene.unity");
        var go = GameObject.Find("GameStart");
        if (go == null) { Debug.LogError("[Append] GameStart not found"); return; }

        var mgr = go.GetComponent<UIMgr>();
        if (mgr == null) { Debug.LogError("[Append] UIMgr not found"); return; }

        var prefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefabs/Imported/UIJoyStick.prefab");
        if (prefab == null) { Debug.LogError("[Append] UIJoyStick.prefab missing"); return; }

        var list = new System.Collections.Generic.List<GameObject>(mgr.HudPrefabs ?? new GameObject[0]);
        // Dedup
        if (list.Contains(prefab))
        {
            Debug.Log("[Append] UIJoyStick.prefab already in list");
            return;
        }
        list.Add(prefab);
        mgr.HudPrefabs = list.ToArray();

        EditorUtility.SetDirty(mgr);
        EditorSceneManager.MarkSceneDirty(scene);
        EditorSceneManager.SaveScene(scene);
        Debug.Log($"[Append] HudPrefabs now has {list.Count} entries; last = UIJoyStick.prefab");
    }
}
