using UnityEditor;
using UnityEngine;
using KTO.Game;

public static class CheckNpc
{
    [MenuItem("KTO/Test/Inspect First Npc")]
    public static void Inspect()
    {
        var npc = NpcManager.GetNpc(9001);
        if (npc == null) { Debug.LogError("Npc 9001 not found"); return; }

        var go = npc.gameObject;
        var box = go.GetComponent<BoxCollider2D>();
        Debug.Log($"=== Npc 9001 ===");
        Debug.Log($"  Name           : {go.name}");
        Debug.Log($"  Layer          : {go.layer} ({LayerMask.LayerToName(go.layer)})");
        Debug.Log($"  Position       : {go.transform.position}");
        Debug.Log($"  m_nNpcID       : {npc.m_nNpcID}");
        Debug.Log($"  m_nKind        : {npc.m_nKind} (NpcKind={(NpcKind)npc.m_nKind})");
        Debug.Log($"  _LogicDir      : {npc._LogicDir}");
        Debug.Log($"  _CurReprDir    : {npc._CurRepresentDir}");
        Debug.Log($"  _RepresentMask : 0x{npc._RepresentMask:X4}");
        Debug.Log($"  bRepresent     : {npc.bRepresent}");
        Debug.Log($"  BoxCollider2D? : enabled={box?.enabled} size={box?.size} offset={box?.offset}");

        // Test raycast manually at NPC position
        Vector2 testPoint = new Vector2(go.transform.position.x, go.transform.position.y);
        int npcLayerMask = 1 << LayerMask.NameToLayer("Npc");
        var hit = Physics2D.OverlapPoint(testPoint, npcLayerMask);
        Debug.Log($"  Raycast at NPC center: hit={(hit?.gameObject.name ?? "NULL")}");
    }
}
