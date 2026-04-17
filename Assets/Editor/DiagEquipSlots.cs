// Dump current state of equip slot Text components.
// Menu: KTO → Debug → Diag Equip Slots
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using KTO.Localization;

public static class DiagEquipSlots
{
    [MenuItem("KTO/Debug/Diag Equip Slots")]
    public static void Run()
    {
        if (!Application.isPlaying) { Debug.LogWarning("Play mode only"); return; }
        var root = GameObject.Find("UIBag");
        if (root == null) { Debug.LogWarning("UIBag not open"); return; }
        string[] slots = {
            "imgBG/BagPanel/UIEquipPanel/EquipPanel/PanelEquip/grid1/Helm/Text",
            "imgBG/BagPanel/UIEquipPanel/EquipPanel/PanelEquip/grid1/Armor/Text",
            "imgBG/BagPanel/UIEquipPanel/EquipPanel/PanelEquip/grid2/Weapon/Text",
            "imgBG/BagPanel/UIEquipPanel/EquipPanel/PanelEquip/grid3/Wuxingyin/Text",
        };
        foreach (var p in slots)
        {
            var tr = root.transform.Find(p);
            if (tr == null) { Debug.LogWarning($"[DiagEquipSlots] {p} NOT FOUND"); continue; }
            var txt = tr.GetComponent<Text>();
            var locs = tr.GetComponents<Localize>();
            Debug.Log($"[DiagEquipSlots] {p} active={tr.gameObject.activeSelf} text={txt?.text} color={txt?.color} fontSize={txt?.fontSize} locCount={locs.Length}");
            foreach (var l in locs)
                Debug.Log($"[DiagEquipSlots]   Localize.Term={l.Term}");
        }
    }
}
