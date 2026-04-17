using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
public static class FixGameStartSpawnPos
{
    public static void Execute()
    {
        var scenePath = "Assets/MainUIScene.unity";
        var scene = EditorSceneManager.OpenScene(scenePath, OpenSceneMode.Single);
        KTO.Game.GameStart gs = null;
        foreach (var r in scene.GetRootGameObjects())
        {
            gs = r.GetComponent<KTO.Game.GameStart>();
            if (gs != null) break;
        }
        if (gs == null) { Debug.LogError("[FixGameStartSpawnPos] GameStart not found"); return; }
        gs.PlayerSpawnPos = new Vector3(43.36f, 25.76f, 0f);
        gs.SpawnPlayerOnStart = true;
        EditorUtility.SetDirty(gs);
        EditorSceneManager.MarkSceneDirty(scene);
        EditorSceneManager.SaveScene(scene);
        Debug.Log($"[FixGameStartSpawnPos] PlayerSpawnPos -> {gs.PlayerSpawnPos}");
    }
}
