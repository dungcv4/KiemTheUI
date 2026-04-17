// Check sprite load resolution at runtime.
using UnityEditor;
using UnityEngine;
using KResourceModule = KTO.Resource.ResourceModule;

public static class DiagSpriteLoad
{
    [MenuItem("KTO/Debug/Diag Sprite Load")]
    public static void Run()
    {
        if (!Application.isPlaying) { Debug.LogWarning("Play mode only"); return; }
        string[] targets = { "medicine_111_s", "helm_m_kui_201", "armor_m_kai_201",
                             "belt_m_101", "boots_m_101", "meleeweapon_n_chanshou_601",
                             "medicine_111", "helm_m_kui_201_0", "bupi_103_s_0" };
        foreach (var n in targets)
        {
            var sp = KResourceModule.LoadSpriteByName(n);
            Debug.Log($"[DiagSprite] '{n}' → {(sp != null ? "LOADED "+sp.name : "null")}");
        }
    }
}
