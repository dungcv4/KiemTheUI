using UnityEditor;
using UnityEngine;
using KTO.Game;

public static class TestNpcRaycast
{
    [MenuItem("KTO/Test/Test NPC Raycast (offset-aware)")]
    public static void Test()
    {
        var npc = NpcManager.GetNpc(9001);
        if (npc == null) { Debug.LogError("Npc 9001 not found"); return; }

        var box = npc.GetComponent<BoxCollider2D>();
        Vector2 colliderCenter = (Vector2)npc.transform.position + box.offset;
        int npcLayerMask = 1 << LayerMask.NameToLayer("Npc");

        // Test 1: at collider center
        var hit1 = Physics2D.OverlapPoint(colliderCenter, npcLayerMask);
        Debug.Log($"[Raycast] At collider center {colliderCenter}: hit={(hit1?.gameObject.name ?? "NULL")}");

        // Test 2: also include OtherPlayer layer (matches ClickToMoveInput)
        int allMask = (1 << LayerMask.NameToLayer("Npc")) | (1 << LayerMask.NameToLayer("OtherPlayer"));
        var hit2 = Physics2D.OverlapPoint(colliderCenter, allMask);
        Debug.Log($"[Raycast] Same point with combined mask 0x{allMask:X}: hit={(hit2?.gameObject.name ?? "NULL")}");

        // Test 3: simulate Operation.SimpleTap dispatch
        if (hit2 != null)
        {
            var hitNpc = hit2.GetComponent<Npc>();
            if (hitNpc != null)
            {
                Debug.Log($"[SimulateClick] Triggering Operation.SimpleTap(id={hitNpc.m_nNpcID}, isFriend={hitNpc._IsFriend})");
                Operation.SimpleTap(hitNpc.m_nNpcID, hitNpc._IsFriend);
            }
        }
    }
}
