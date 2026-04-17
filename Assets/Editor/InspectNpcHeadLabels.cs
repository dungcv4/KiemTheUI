using UnityEditor;
using UnityEngine;
using KTO.Game;

public static class InspectNpcHeadLabels
{
    [MenuItem("KTO/Test/Inspect Head Labels")]
    public static void Execute()
    {
        if (!Application.isPlaying)
        {
            Debug.LogError("[InspectHeadLabels] Must be in Play mode!");
            return;
        }

        var allNpcs = NpcManager.AllNpcs;
        if (allNpcs == null || allNpcs.Count == 0)
        {
            Debug.LogWarning("[InspectHeadLabels] No NPCs spawned");
            return;
        }

        foreach (var kv in allNpcs)
        {
            var npc = kv.Value;
            if (npc == null) continue;

            var label = npc.GetComponentInChildren<NpcHeadLabel>(true);
            var canvas = npc.GetComponentInChildren<Canvas>(true);

            string nameText = "null";
            string titleText = "null";
            var texts = npc.GetComponentsInChildren<UnityEngine.UI.Text>(true);
            if (texts.Length > 0) nameText = texts[0].text;
            if (texts.Length > 1) titleText = texts[1].text;

            bool hasFont = texts.Length > 0 && texts[0].font != null;

            Debug.Log($"[InspectHeadLabels] NPC {npc.m_nNpcID} '{npc.m_szName}' " +
                      $"pos={npc.transform.position} " +
                      $"hasLabel={label != null} hasCanvas={canvas != null} " +
                      $"nameText='{nameText}' titleText='{titleText}' " +
                      $"hasFont={hasFont} " +
                      $"labelActive={label?.gameObject.activeSelf} " +
                      $"childCount={npc.transform.childCount}");
        }

        // Also log player position for reference
        var player = GameObject.Find("Player_ma_000a_free");
        if (player != null)
            Debug.Log($"[InspectHeadLabels] Player pos={player.transform.position}");
    }
}
