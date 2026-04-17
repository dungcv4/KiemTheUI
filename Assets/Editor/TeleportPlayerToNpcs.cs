using UnityEditor;
using UnityEngine;

public static class TeleportPlayerToNpcs
{
    [MenuItem("KTO/Test/Teleport Player to NPCs")]
    public static void Execute()
    {
        if (!Application.isPlaying) { Debug.LogError("Must be in Play mode!"); return; }

        var player = GameObject.Find("Player_ma_000a_free");
        if (player == null) { Debug.LogError("Player not found!"); return; }

        // NPC cluster is around (9, 6) — center of the test NPCs
        player.transform.position = new Vector3(9.5f, 6.0f, 0f);
        Debug.Log($"[Teleport] Player moved to {player.transform.position}");

        // Also frame the SceneView on the area
        var sv = SceneView.lastActiveSceneView;
        if (sv != null)
        {
            sv.pivot = new Vector3(9.5f, 6.0f, 0f);
            sv.size = 5f;
            sv.Repaint();
        }
    }
}
