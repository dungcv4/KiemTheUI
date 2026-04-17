using UnityEditor;
using UnityEngine;

public static class CheckLayers
{
    [MenuItem("KTO/Test/Check NPC Layers")]
    public static void Check()
    {
        Debug.Log($"Me layer       = {LayerMask.NameToLayer("Me")}");
        Debug.Log($"OtherPlayer    = {LayerMask.NameToLayer("OtherPlayer")}");
        Debug.Log($"Npc            = {LayerMask.NameToLayer("Npc")}");

        // List all 32 layers
        for (int i = 0; i < 32; i++)
        {
            string name = LayerMask.LayerToName(i);
            if (!string.IsNullOrEmpty(name))
                Debug.Log($"  Layer {i:00}: {name}");
        }
    }
}
