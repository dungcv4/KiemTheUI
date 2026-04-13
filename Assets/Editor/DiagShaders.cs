using UnityEngine;
using UnityEditor;

public static class DiagShaders
{
    public static string Execute()
    {
        var sb = new System.Text.StringBuilder();
        string[] names = {
            "KTO/EffectAdditive",
            "Universal Render Pipeline/Particles/Unlit",
            "Universal Render Pipeline/Unlit",
            "Particles/Standard Unlit",
            "Particles/Additive",
            "Mobile/Particles/Additive",
            "Sprites/Default",
            "Unlit/Transparent",
            "Unlit/Texture",
            "UI/Default",
        };
        foreach (var n in names)
        {
            var s = Shader.Find(n);
            sb.AppendLine($"  {n}: {(s != null ? "FOUND" : "NULL")}");
        }

        // Check the current ClickEffect materials
        string[] matPaths = {
            "Assets/Materials/ClickEffect/ClickEffect_Glow.mat",
            "Assets/Materials/ClickEffect/ClickEffect_Spark.mat",
            "Assets/Materials/ClickEffect/ClickEffect_Ring.mat",
        };
        sb.AppendLine("\nMaterials:");
        foreach (var p in matPaths)
        {
            var mat = AssetDatabase.LoadAssetAtPath<Material>(p);
            if (mat != null)
                sb.AppendLine($"  {p}: shader={mat.shader.name}, tex={mat.GetTexture("_MainTex")?.name ?? "NULL"}");
            else
                sb.AppendLine($"  {p}: NOT FOUND");
        }

        // Check if KTO/EffectAdditive shader has errors
        var effShader = Shader.Find("KTO/EffectAdditive");
        if (effShader != null)
        {
            sb.AppendLine($"\nKTO/EffectAdditive isSupported: {effShader.isSupported}");
            sb.AppendLine($"  passCount(subshader0): attempting...");
        }

        return sb.ToString();
    }
}
