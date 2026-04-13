using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public static class ProbeBannerMats
{
    public static void Execute()
    {
        var paths = new[]
        {
            "Assets/game/ui/effect/uicreaterole_effect/materials/BG_TianRen.mat",
            "Assets/game/ui/effect/uicreaterole_effect/materials/LiuGuang_TianRen.mat",
            "Assets/game/ui/effect/uicreaterole_effect/materials/RaoDong_TianRen.mat",
            "Assets/Shader/UI_ImageEffect_Banner.shader",
        };
        foreach (var p in paths)
        {
            var obj = AssetDatabase.LoadMainAssetAtPath(p);
            if (obj == null) { Debug.Log("[ProbeMat] MISSING " + p); continue; }
            if (obj is Material m)
            {
                var s = m.shader;
                var name = System.IO.Path.GetFileName(p);
                var kw = string.Join(",", m.shaderKeywords);
                var sp = AssetDatabase.GetAssetPath(s);
                Debug.Log("[ProbeMat] " + name +
                          " -> shader='" + s.name +
                          "' hasBlendSet=" + m.HasProperty("_BlendSet") +
                          " hasUspeed=" + m.HasProperty("_Uspeed") +
                          " hasDiffuse=" + m.HasProperty("_Diffuse") +
                          " keywords=[" + kw + "]" +
                          " shaderPath='" + sp + "'");
            }
            else if (obj is Shader sh)
            {
                Debug.Log("[ProbeMat] " + System.IO.Path.GetFileName(p) +
                          " shaderObj name='" + sh.name + "' supported=" + sh.isSupported);
            }
        }

        var allShaderGuids = AssetDatabase.FindAssets("t:Shader");
        var collisions = new List<string>();
        foreach (var g in allShaderGuids)
        {
            var sp2 = AssetDatabase.GUIDToAssetPath(g);
            var sh = AssetDatabase.LoadAssetAtPath<Shader>(sp2);
            if (sh == null) continue;
            if (sh.name == "UI/ImageEffect" || sh.name == "KTO/UI_ImageEffect")
                collisions.Add("  " + sh.name + "  guid=" + g + "  path=" + sp2);
        }
        Debug.Log("[ProbeMat] shaders named UI/ImageEffect or KTO/UI_ImageEffect:\n" + string.Join("\n", collisions));
    }
}
