// Dump current BagMgr contents + resolved template names.
// Menu: KTO → Debug → Diag Bag Contents
using UnityEditor;
using UnityEngine;

public static class DiagBagContents
{
    [MenuItem("KTO/Debug/Diag Bag Contents")]
    public static void Run()
    {
        if (!Application.isPlaying) { Debug.LogWarning("Play mode only"); return; }
        Debug.Log($"[DiagBag] ItemDatabase has {KTO.Game.Item.ItemDatabase.Count} templates");
        Debug.Log($"[DiagBag] BagMgr has {KTO.Game.Bag.BagMgr.Count} items");
        foreach (var kv in KTO.Game.Bag.BagMgr.AllSlots)
        {
            var i = kv.Value;
            var tpl = i.Template;
            string name = tpl?.szName ?? $"(template {i.nTemplateId} MISSING)";
            string icon = tpl?.szIcon ?? "?";
            int typ   = tpl?.nType ?? 0;
            Debug.Log($"[DiagBag] slot={kv.Key} dwId={i.dwId} tmpl={i.nTemplateId} amt={i.nAmount} → name='{name}' icon={icon} type={typ}");
        }
    }
}
