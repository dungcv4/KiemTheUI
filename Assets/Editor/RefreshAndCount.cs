using UnityEditor;
using UnityEngine;

public static class RefreshAndCount
{
    public static void Execute()
    {
        AssetDatabase.Refresh(ImportAssetOptions.Default);
        var root = "Assets/Sprite/Player";
        var guids = AssetDatabase.FindAssets("t:Texture2D", new[] { root });
        int spriteTotal = 0, texTotal = 0;
        foreach (var g in guids)
        {
            texTotal++;
            var path = AssetDatabase.GUIDToAssetPath(g);
            var subs = AssetDatabase.LoadAllAssetRepresentationsAtPath(path);
            foreach (var o in subs) if (o is Sprite) spriteTotal++;
        }
        Debug.Log($"[RefreshAndCount] textures={texTotal} sprites={spriteTotal} under {root}");
    }
}
