using UnityEngine;
using UnityEditor;

public static class CleanupBag
{
    [MenuItem("KTO/Test/Cleanup duplicate UIBag controllers")]
    public static void Run()
    {
        // Remove leftover [UIBag] and [UIBagController] GOs that accumulated
        // across domain reloads. Leave only one if present; reboot via Open().
        var all = Object.FindObjectsOfType<KTO.UI.UIBagController>(includeInactive: true);
        foreach (var c in all)
        {
            if (c != null && c.gameObject != null)
                Object.Destroy(c.gameObject);
        }
        var bagPrefab = GameObject.Find("HudRoot/UIBag");
        if (bagPrefab != null) Object.Destroy(bagPrefab);
        Debug.Log($"[CleanupBag] Destroyed {all.Length} UIBagController(s) + prefab instance");
    }
}
