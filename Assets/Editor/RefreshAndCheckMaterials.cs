using UnityEditor;
using UnityEngine;

public static class RefreshAndCheckMaterials
{
    public static void Execute()
    {
        Debug.Log("[Mat] reimport textures dir");
        AssetDatabase.ImportAsset("Assets/game/ui/effect/uicreaterole_effect/textures",
            ImportAssetOptions.ImportRecursive | ImportAssetOptions.ForceUpdate);
        AssetDatabase.Refresh(ImportAssetOptions.ForceUpdate);

        // Reimport materials too so they pick up the new texture refs
        AssetDatabase.ImportAsset("Assets/game/ui/effect/uicreaterole_effect/materials",
            ImportAssetOptions.ImportRecursive | ImportAssetOptions.ForceUpdate);
        AssetDatabase.Refresh(ImportAssetOptions.ForceUpdate);

        // Check the BG_TianRen material
        string[] mats = {
            "Assets/game/ui/effect/uicreaterole_effect/materials/BG_TianRen.mat",
            "Assets/game/ui/effect/uicreaterole_effect/materials/LiuGuang_TianRen.mat",
            "Assets/game/ui/effect/uicreaterole_effect/materials/RaoDong_TianRen.mat",
            "Assets/game/ui/effect/uicreaterole_effect/materials/LiZi.mat",
        };
        foreach (var mp in mats)
        {
            var m = AssetDatabase.LoadAssetAtPath<Material>(mp);
            if (m == null) { Debug.LogWarning($"[Mat] not loaded: {mp}"); continue; }
            string sh = m.shader != null ? m.shader.name : "NULL";
            string sup = m.shader != null ? m.shader.isSupported.ToString() : "-";
            Debug.Log($"[Mat] {m.name} shader={sh} sup={sup}");
            // List texture properties
            int n = ShaderUtil.GetPropertyCount(m.shader);
            for (int i = 0; i < n; i++)
            {
                if (ShaderUtil.GetPropertyType(m.shader, i) != ShaderUtil.ShaderPropertyType.TexEnv) continue;
                var pname = ShaderUtil.GetPropertyName(m.shader, i);
                var tex = m.GetTexture(pname);
                if (tex != null)
                    Debug.Log($"[Mat]   {pname} = {tex.name}");
            }
        }
        Debug.Log("[Mat] done");
    }
}
