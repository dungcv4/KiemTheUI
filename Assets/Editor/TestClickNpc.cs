using UnityEditor;
using UnityEngine;
using KTO.Game;

public static class TestClickNpc
{
    [MenuItem("KTO/Test/Click NPC 9001 (Bao Van Dong)")]
    public static void Execute()
    {
        if (!Application.isPlaying) { Debug.LogError("Must be in Play mode!"); return; }

        // Teleport player near NPC 9001 first
        var npc = NpcManager.GetNpc(9001);
        if (npc == null) { Debug.LogError("NPC 9001 not found! Spawn NPCs first."); return; }

        var player = GameObject.Find("Player_ma_000a_free");
        if (player != null)
        {
            // Move player close to NPC
            player.transform.position = npc.transform.position + new Vector3(0.5f, 0f, 0f);
            Debug.Log($"[TestClickNpc] Teleported player near NPC 9001 at {npc.transform.position}");
        }

        // Simulate clicking the NPC
        Operation.OnDialogerClicked(9001);
    }
}
