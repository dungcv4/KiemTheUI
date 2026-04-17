// Full bag flow test: open bag → tooltip on item 4 (Helm) → equip → verify.
using UnityEditor;
using UnityEngine;
using KTO.Game.Bag;
using KTO.Game.Item;
using KTO.Network;

public static class TestBagFullFlow
{
    [MenuItem("KTO/Debug/Test Bag Full Flow - Equip Helm")]
    public static void Run()
    {
        if (!Application.isPlaying) { Debug.LogWarning("Play mode only"); return; }

        // Find a bag item that's a helm (tmpl=3399 or any Using<=0 equip)
        ItemInstance helm = null;
        foreach (var kv in BagMgr.AllSlots)
        {
            if (kv.Value != null && kv.Value.nTemplateId == 3399) { helm = kv.Value; break; }
        }
        if (helm == null)
        {
            Debug.LogWarning("[TestBagFull] Helm (tmpl=3399) not in bag");
            return;
        }
        Debug.Log($"[TestBagFull] Found helm at slot={helm.nPos} dwId={helm.dwId} → equipping to slot 1 (Helm)");
        BagNetworkClient.EquipItem(helm.dwId, 1);   // equipPos=1 (Helm)
    }

    [MenuItem("KTO/Debug/Test Bag Full Flow - Unequip Helm")]
    public static void Unequip()
    {
        if (!Application.isPlaying) { Debug.LogWarning("Play mode only"); return; }
        var helm = EquipMgr.Get(EquipSlot.Helm);
        if (helm == null || helm.dwId == 0)
        {
            Debug.LogWarning("[TestBagFull] No helm equipped");
            return;
        }
        Debug.Log($"[TestBagFull] Unequipping helm dwId={helm.dwId}");
        BagNetworkClient.UnequipItem(helm.dwId, -1);
    }
}
