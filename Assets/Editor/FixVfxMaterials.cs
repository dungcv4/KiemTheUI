// Converts VFX particle materials from dummy shader to effect/C_EffectStandard_URP
// Preserves ALL original properties: _Diffuse, _Color, _Brightness, blend modes,
// UV speeds, mask textures, rotation, alpha cutout, etc.
using UnityEngine;
using UnityEditor;

public static class FixVfxMaterials
{
    [MenuItem("KTO/Fix VFX Materials (URP)")]
    public static void Execute()
    {
        string dir = "Assets/Material/VFX_URP";
        if (!AssetDatabase.IsValidFolder(dir))
            AssetDatabase.CreateFolder("Assets/Material", "VFX_URP");

        var urpShader = Shader.Find("effect/C_EffectStandard_URP");
        if (urpShader == null)
        {
            Debug.LogError("[FixVfxMat] effect/C_EffectStandard_URP shader not found!");
            return;
        }

        var matGuids = AssetDatabase.FindAssets("t:Material", new[] { "Assets/Material" });
        int count = 0;

        foreach (var guid in matGuids)
        {
            string path = AssetDatabase.GUIDToAssetPath(guid);
            // Skip VFX_URP subfolder
            if (path.Contains("/VFX_URP/")) continue;
            var mat = AssetDatabase.LoadAssetAtPath<Material>(path);
            if (mat == null) continue;
            if (mat.shader == null || !mat.shader.name.Contains("EffectStandard")) continue;

            string urpPath = dir + "/" + mat.name + "_URP.mat";
            // Reuse existing URP material to preserve GUID (avoid breaking references)
            var urpMat = AssetDatabase.LoadAssetAtPath<Material>(urpPath);
            if (urpMat == null)
            {
                urpMat = new Material(urpShader);
                urpMat.name = mat.name + "_URP";
            }
            else
            {
                urpMat.shader = urpShader;
            }

            // Copy all properties from original material to URP material
            // Textures
            CopyTex(mat, urpMat, "_Diffuse");
            CopyTex(mat, urpMat, "_DiffuseMaskTex");

            // Colors
            CopyColor(mat, urpMat, "_Color");

            // Floats
            CopyFloat(mat, urpMat, "_Brightness");
            CopyFloat(mat, urpMat, "_TwoSide");
            CopyFloat(mat, urpMat, "_ZWrite");
            CopyFloat(mat, urpMat, "_AlphaCutout");
            CopyFloat(mat, urpMat, "_DiffuseRo");
            CopyFloat(mat, urpMat, "_DiffuseAng");
            CopyFloat(mat, urpMat, "_Uspeed");
            CopyFloat(mat, urpMat, "_Vspeed");
            CopyFloat(mat, urpMat, "_DiffuseMask");
            CopyFloat(mat, urpMat, "_USpeed_diffusem");
            CopyFloat(mat, urpMat, "_VSpeed_diffusem");

            // Blend modes — copy original blend settings
            CopyFloat(mat, urpMat, "_SrcRGBMode");
            CopyFloat(mat, urpMat, "_DestRGBMode");

            // Distortion
            CopyFloat(mat, urpMat, "_DistortBlock");
            CopyTex(mat, urpMat, "_DistortTex");
            CopyFloat(mat, urpMat, "_USpeed_distort");
            CopyFloat(mat, urpMat, "_VSpeed_distort");
            CopyFloat(mat, urpMat, "_ForceX");
            CopyFloat(mat, urpMat, "_ForceY");

            // Second Layer
            CopyFloat(mat, urpMat, "_SecondLayerBlock");
            CopyTex(mat, urpMat, "_SecondLayerTex");
            CopyFloat(mat, urpMat, "_SecondLayerMask");
            CopyTex(mat, urpMat, "_SecondLayerMaskTex");
            CopyColor(mat, urpMat, "_SecondLayerColor");
            CopyFloat(mat, urpMat, "_SecondLayerBrightness");
            CopyFloat(mat, urpMat, "_SecondLayerRo");
            CopyFloat(mat, urpMat, "_SecondLayerAng");
            CopyFloat(mat, urpMat, "_Uspeed_second");
            CopyFloat(mat, urpMat, "_Vspeed_second");
            CopyFloat(mat, urpMat, "_SecondLayerMaskRo");
            CopyFloat(mat, urpMat, "_SecondLayerMaskAng");
            CopyFloat(mat, urpMat, "_Uspeed_secondm");
            CopyFloat(mat, urpMat, "_Vspeed_secondm");

            // Texture tiling/offset
            CopyTexST(mat, urpMat, "_Diffuse");
            CopyTexST(mat, urpMat, "_DiffuseMaskTex");
            CopyTexST(mat, urpMat, "_DistortTex");
            CopyTexST(mat, urpMat, "_SecondLayerTex");
            CopyTexST(mat, urpMat, "_SecondLayerMaskTex");

            urpMat.renderQueue = 3000;

            // Save: create if new, or just mark dirty if updating existing
            if (!AssetDatabase.Contains(urpMat))
                AssetDatabase.CreateAsset(urpMat, urpPath);
            else
                EditorUtility.SetDirty(urpMat);
            count++;

            Texture diffuse = mat.HasProperty("_Diffuse") ? mat.GetTexture("_Diffuse") : null;
            string texName = diffuse != null ? diffuse.name : "null";
            Debug.Log("[FixVfxMat] " + mat.name + " => " + urpPath + " (diffuse=" + texName + ")");
        }

        AssetDatabase.SaveAssets();
        Debug.Log("[FixVfxMat] Converted " + count + " materials to effect/C_EffectStandard_URP");

        AssignToLoginBG(dir);
    }

    static void CopyTex(Material src, Material dst, string prop)
    {
        if (src.HasProperty(prop) && dst.HasProperty(prop))
            dst.SetTexture(prop, src.GetTexture(prop));
    }

    static void CopyColor(Material src, Material dst, string prop)
    {
        if (src.HasProperty(prop) && dst.HasProperty(prop))
            dst.SetColor(prop, src.GetColor(prop));
    }

    static void CopyFloat(Material src, Material dst, string prop)
    {
        if (src.HasProperty(prop) && dst.HasProperty(prop))
            dst.SetFloat(prop, src.GetFloat(prop));
    }

    static void CopyTexST(Material src, Material dst, string prop)
    {
        if (src.HasProperty(prop) && dst.HasProperty(prop))
        {
            dst.SetTextureScale(prop, src.GetTextureScale(prop));
            dst.SetTextureOffset(prop, src.GetTextureOffset(prop));
        }
    }

    static void AssignToLoginBG(string urpDir)
    {
        string prefabPath = "Assets/game/ui/views/UILoginBG.prefab";
        var prefab = AssetDatabase.LoadAssetAtPath<GameObject>(prefabPath);
        if (prefab == null) { Debug.LogError("[FixVfxMat] UILoginBG prefab not found"); return; }

        var instance = (GameObject)PrefabUtility.InstantiatePrefab(prefab);
        int assigned = 0;

        var renderers = instance.GetComponentsInChildren<ParticleSystemRenderer>(true);
        foreach (var psr in renderers)
        {
            if (psr.sharedMaterial == null) continue;
            string origName = psr.sharedMaterial.name;

            // Strip existing _URP suffix to find the base name
            string baseName = origName.EndsWith("_URP")
                ? origName.Substring(0, origName.Length - 4)
                : origName;

            string urpPath = urpDir + "/" + baseName + "_URP.mat";
            var urpMat = AssetDatabase.LoadAssetAtPath<Material>(urpPath);
            if (urpMat != null)
            {
                psr.sharedMaterial = urpMat;
                assigned++;
            }
        }

        PrefabUtility.ApplyPrefabInstance(instance, InteractionMode.AutomatedAction);
        Object.DestroyImmediate(instance);

        Debug.Log($"[FixVfxMat] Assigned {assigned} URP materials to UILoginBG prefab renderers");
    }
}
