using UnityEditor;
using UnityEngine;

/// <summary>
/// Force-add the Me/OtherPlayer/Npc layers via SerializedObject API.
/// Direct YAML editing of TagManager.asset doesn't work when Unity is running
/// because Unity caches the asset on startup.
/// </summary>
public static class AddNpcLayers
{
    [MenuItem("KTO/Test/Add NPC Layers (Me/OtherPlayer/Npc)")]
    public static void Add()
    {
        // Standard slot positions: 6=Me, 7=OtherPlayer, 8=Npc
        AddLayer("Me", 6);
        AddLayer("OtherPlayer", 7);
        AddLayer("Npc", 8);

        Debug.Log("[AddNpcLayers] Done. Layers added/verified.");

        // Re-check
        Debug.Log($"  Me          = {LayerMask.NameToLayer("Me")}");
        Debug.Log($"  OtherPlayer = {LayerMask.NameToLayer("OtherPlayer")}");
        Debug.Log($"  Npc         = {LayerMask.NameToLayer("Npc")}");
    }

    static void AddLayer(string name, int slot)
    {
        var tagManagerAsset = AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/TagManager.asset");
        if (tagManagerAsset == null || tagManagerAsset.Length == 0)
        {
            Debug.LogError("[AddNpcLayers] Cannot load TagManager.asset");
            return;
        }

        var so = new SerializedObject(tagManagerAsset[0]);
        var layersProp = so.FindProperty("layers");
        if (layersProp == null || layersProp.arraySize <= slot)
        {
            Debug.LogError($"[AddNpcLayers] 'layers' property missing or too small (size={layersProp?.arraySize})");
            return;
        }

        var slotProp = layersProp.GetArrayElementAtIndex(slot);
        if (slotProp.stringValue == name)
        {
            Debug.Log($"  Slot {slot}: '{name}' already set");
            return;
        }
        if (!string.IsNullOrEmpty(slotProp.stringValue))
        {
            Debug.LogWarning($"  Slot {slot}: was '{slotProp.stringValue}', overwriting with '{name}'");
        }
        slotProp.stringValue = name;
        so.ApplyModifiedPropertiesWithoutUndo();
        AssetDatabase.SaveAssets();
        Debug.Log($"  Slot {slot}: SET to '{name}'");
    }
}
