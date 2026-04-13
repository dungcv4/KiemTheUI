// Restores Click_Effect materials using recreated UI/ImageEffect shader
// with EXACT property values from bundle uicreaterole/res_1.ab
using UnityEngine;
using UnityEditor;

public static class RestoreClickEffectMaterials
{
    public static string Execute()
    {
        var sb = new System.Text.StringBuilder();

        var shader = Shader.Find("UI/ImageEffect");
        if (shader == null) return "ERROR: UI/ImageEffect shader not found. Check Assets/Shaders/UI-ImageEffect.shader";

        var texGlow  = AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/game/ui/effect/textures/glow/TX-GQ-039.png");
        var texSpark = AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/game/ui/effect/textures/glow/Glow_024.png");
        var texRing  = AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/Texture2D/TX-GQ-002.png");

        // Delete old materials
        AssetDatabase.DeleteAsset("Assets/Materials/ClickEffect/ClickEffect_Glow.mat");
        AssetDatabase.DeleteAsset("Assets/Materials/ClickEffect/ClickEffect_Spark.mat");
        AssetDatabase.DeleteAsset("Assets/Materials/ClickEffect/ClickEffect_Ring.mat");
        AssetDatabase.DeleteAsset("Assets/Materials/ClickEffect/ClickEffect_RingMesh.mat");

        // Bundle mat "M2" → M1 (glow): _Brightness=1.0, _Color=(1,1,1,0.498), no UV rotation
        var matGlow = CreateMat(shader, "ClickEffect_Glow", texGlow,
            brightness: 1.0f,
            color: new Color(1f, 1f, 1f, 0.498f),
            diffuseRo: 0f, diffuseAng: -90f);
        AssetDatabase.CreateAsset(matGlow, "Assets/Materials/ClickEffect/ClickEffect_Glow.mat");

        // Bundle mat "M1" → M2 (sparks): _Brightness=1.5, _Color=(1,1,1,1), no UV rotation
        var matSpark = CreateMat(shader, "ClickEffect_Spark", texSpark,
            brightness: 1.5f,
            color: Color.white,
            diffuseRo: 0f, diffuseAng: -90f);
        AssetDatabase.CreateAsset(matSpark, "Assets/Materials/ClickEffect/ClickEffect_Spark.mat");

        // Bundle mat "M3" → M4 (burst) + M3 (mesh): _Brightness=1.2, _Color=(1,0.626,0.184,1), UV rotation
        var matRing = CreateMat(shader, "ClickEffect_Ring", texRing,
            brightness: 1.2f,
            color: new Color(1f, 0.6256f, 0.1840f, 1f),
            diffuseRo: 1f, diffuseAng: 90f);
        AssetDatabase.CreateAsset(matRing, "Assets/Materials/ClickEffect/ClickEffect_Ring.mat");

        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();

        // Reload from disk
        matGlow  = AssetDatabase.LoadAssetAtPath<Material>("Assets/Materials/ClickEffect/ClickEffect_Glow.mat");
        matSpark = AssetDatabase.LoadAssetAtPath<Material>("Assets/Materials/ClickEffect/ClickEffect_Spark.mat");
        matRing  = AssetDatabase.LoadAssetAtPath<Material>("Assets/Materials/ClickEffect/ClickEffect_Ring.mat");

        sb.AppendLine($"matGlow:  shader={matGlow.shader.name}, bright={matGlow.GetFloat("_Brightness")}");
        sb.AppendLine($"matSpark: shader={matSpark.shader.name}, bright={matSpark.GetFloat("_Brightness")}");
        sb.AppendLine($"matRing:  shader={matRing.shader.name}, bright={matRing.GetFloat("_Brightness")}, diffRo={matRing.GetFloat("_DiffuseRo")}");

        // Assign to scene
        var sceneRoot = GameObject.Find("UICreateRole_Canvas/UICreateRole");
        int updated = 0;
        if (sceneRoot != null)
        {
            var allTrans = sceneRoot.GetComponentsInChildren<Transform>(true);
            foreach (var t in allTrans)
            {
                if (t.name == "Click_Effect")
                {
                    var psr = t.GetComponent<ParticleSystemRenderer>();
                    if (psr != null) { psr.sharedMaterial = matGlow; updated++; }
                }
                else if (t.name == "M1")
                {
                    var psr = t.GetComponent<ParticleSystemRenderer>();
                    if (psr != null) { psr.sharedMaterial = matGlow; updated++; }
                }
                else if (t.name == "M2")
                {
                    var psr = t.GetComponent<ParticleSystemRenderer>();
                    if (psr != null) { psr.sharedMaterial = matSpark; updated++; }
                }
                else if (t.name == "M3")
                {
                    var mr = t.GetComponent<MeshRenderer>();
                    if (mr != null) { mr.sharedMaterial = matRing; updated++; }
                }
                else if (t.name == "M4")
                {
                    var psr = t.GetComponent<ParticleSystemRenderer>();
                    if (psr != null) { psr.sharedMaterial = matRing; updated++; }
                }
            }
            sb.AppendLine($"Scene renderers: {updated}");

            var prefabRoot = PrefabUtility.GetNearestPrefabInstanceRoot(sceneRoot);
            if (prefabRoot != null)
            {
                PrefabUtility.ApplyPrefabInstance(prefabRoot, InteractionMode.AutomatedAction);
                sb.AppendLine("Applied to prefab");
            }

            UnityEditor.SceneManagement.EditorSceneManager.MarkSceneDirty(
                UnityEditor.SceneManagement.EditorSceneManager.GetActiveScene());
            UnityEditor.SceneManagement.EditorSceneManager.SaveOpenScenes();
        }

        // Verify prefab
        var prefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefabs/Imported/UICreateRole.prefab");
        if (prefab != null)
        {
            var psrs = prefab.GetComponentsInChildren<ParticleSystemRenderer>(true);
            int nullCount = 0;
            foreach (var psr in psrs) { if (psr.sharedMaterial == null) nullCount++; }
            sb.AppendLine($"Prefab: {nullCount}/{psrs.Length} NULL");
        }

        return sb.ToString();
    }

    static Material CreateMat(Shader shader, string name, Texture2D tex,
        float brightness, Color color, float diffuseRo, float diffuseAng)
    {
        var mat = new Material(shader);
        mat.name = name;

        // Texture
        if (tex != null) mat.SetTexture("_Diffuse", tex);

        // Original bundle properties
        mat.SetFloat("_Brightness", brightness);
        mat.SetColor("_Color", color);
        mat.SetFloat("_DiffuseRo", diffuseRo);
        mat.SetFloat("_DiffuseAng", diffuseAng);

        // Blend: SrcAlpha, One (additive) — exact bundle values
        mat.SetFloat("_SrcRGBMode", (float)UnityEngine.Rendering.BlendMode.SrcAlpha);   // 5
        mat.SetFloat("_DestRGBMode", (float)UnityEngine.Rendering.BlendMode.One);        // 1
        mat.SetFloat("_SrcAlphaMode", (float)UnityEngine.Rendering.BlendMode.SrcAlpha);  // 5
        mat.SetFloat("_DestAlphaMode", (float)UnityEngine.Rendering.BlendMode.One);      // 1
        mat.SetFloat("_ZWrite", 0f);
        mat.SetFloat("_TwoSide", 0f);
        mat.SetFloat("_ColorMask", 15f);

        // Enable UV rotation keyword if needed
        if (diffuseRo > 0.5f)
            mat.EnableKeyword("_DIFFUSERO_ON");

        mat.renderQueue = 3000;
        return mat;
    }
}
