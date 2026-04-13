// Sets up ParticleSystem components on Click_Effect and children (M1, M2, M4),
// plus MeshFilter/MeshRenderer/SortingGroup on M3.
// All values extracted from original bundle res_p_55.ab via TypeTreeGenerator.
//
// Hierarchy: imgSelected/Click_Effect
//   M1 — static glow billboard (1 particle, looping)
//   M2 — spark particles from MeshRenderer shape (3 particles, looping)
//   M3 — rotating Quad mesh (NOT a ParticleSystem), AutoRotation script
//   M4 — burst ring/flash (1 particle, one-shot)
//
// Original materials use shader "UI/ImageEffect" (bundle "M1","M2","M3").
// Using URP Particles/Unlit as rendering fallback since the bundle shader is a
// stub export. Textures and colors match the original exactly.
using UnityEngine;
using UnityEditor;
using UnityEngine.Rendering;

public static class SetupClickEffectParticles
{
    [MenuItem("KTO/Setup Click Effect Particles")]
    public static void Run()
    {
        string result = Execute();
        Debug.Log(result);
    }

    public static string Execute()
    {
        var sb = new System.Text.StringBuilder();

        // ── Ensure material folder ──
        if (!AssetDatabase.IsValidFolder("Assets/Materials"))
            AssetDatabase.CreateFolder("Assets", "Materials");
        if (!AssetDatabase.IsValidFolder("Assets/Materials/ClickEffect"))
            AssetDatabase.CreateFolder("Assets/Materials", "ClickEffect");

        // ── Find shader ──
        var shader = Shader.Find("Universal Render Pipeline/Particles/Unlit");
        if (shader == null)
        {
            return "ERROR: Universal Render Pipeline/Particles/Unlit shader not found";
        }

        // ── Load textures ──
        var texGlow  = AssetDatabase.LoadAssetAtPath<Texture2D>(
            "Assets/game/ui/effect/textures/glow/TX-GQ-039.png");
        var texSpark = AssetDatabase.LoadAssetAtPath<Texture2D>(
            "Assets/game/ui/effect/textures/glow/Glow_024.png");
        var texRing  = AssetDatabase.LoadAssetAtPath<Texture2D>(
            "Assets/Texture2D/TX-GQ-002.png");

        if (texGlow  == null) sb.AppendLine("WARN: TX-GQ-039.png not found");
        if (texSpark == null) sb.AppendLine("WARN: Glow_024.png not found");
        if (texRing  == null) sb.AppendLine("WARN: TX-GQ-002.png not found");

        // ── Create materials ──
        // Bundle mat "M2" → child M1 (glow), texture TX-GQ-039, _Brightness=1, _Color alpha=0.498
        var matGlow = CreateParticleMat(
            "Assets/Materials/ClickEffect/ClickEffect_Glow.mat",
            shader, texGlow, new Color(1f, 1f, 1f, 0.498f));

        // Bundle mat "M1" → child M2 (sparks), texture Glow_024, _Brightness=1.5
        var matSpark = CreateParticleMat(
            "Assets/Materials/ClickEffect/ClickEffect_Spark.mat",
            shader, texSpark, Color.white);

        // Bundle mat "M3" → child M3 (mesh) + M4 (burst), texture TX-GQ-002,
        //   _Brightness=1.2, _DiffuseRo=1, _DiffuseAng=90, _Color=rgba(1,0.626,0.184,1)
        var matRing = CreateParticleMat(
            "Assets/Materials/ClickEffect/ClickEffect_Ring.mat",
            shader, texRing, new Color(1f, 0.626f, 0.184f, 1f));

        AssetDatabase.SaveAssets();

        // ── Open prefab ──
        string prefabPath = "Assets/Prefabs/Imported/UICreateRole.prefab";
        var prefabAsset = AssetDatabase.LoadAssetAtPath<GameObject>(prefabPath);
        if (prefabAsset == null)
        {
            return sb + "ERROR: UICreateRole.prefab not found";
        }

        var contents = PrefabUtility.LoadPrefabContents(prefabPath);
        int count = 0;

        var allTransforms = contents.GetComponentsInChildren<Transform>(true);
        foreach (var t in allTransforms)
        {
            if (t.name != "Click_Effect") continue;
            if (t.GetComponent<ParticleSystem>() != null)
            {
                sb.AppendLine($"  {GetPath(t)}: already has ParticleSystem, skipping");
                continue;
            }

            SetupHierarchy(t.gameObject, matGlow, matSpark, matRing, sb);
            count++;
        }

        PrefabUtility.SaveAsPrefabAsset(contents, prefabPath);
        PrefabUtility.UnloadPrefabContents(contents);

        sb.Insert(0, $"SetupClickEffectParticles: configured {count} Click_Effect(s)\n");
        return sb.ToString();
    }

    // ────────────────────────────────────────────────────────────
    static Material CreateParticleMat(string path, Shader shader, Texture2D tex, Color color)
    {
        var existing = AssetDatabase.LoadAssetAtPath<Material>(path);
        if (existing != null) return existing;

        var mat = new Material(shader);
        if (tex != null) mat.SetTexture("_BaseMap", tex);
        mat.SetColor("_BaseColor", color);

        // Transparent + Additive
        mat.SetFloat("_Surface", 1f);
        mat.SetFloat("_Blend", 2f);
        mat.SetOverrideTag("RenderType", "Transparent");
        mat.SetFloat("_SrcBlend", (float)UnityEngine.Rendering.BlendMode.SrcAlpha);
        mat.SetFloat("_DstBlend", (float)UnityEngine.Rendering.BlendMode.One);
        mat.SetFloat("_ZWrite", 0f);
        mat.EnableKeyword("_SURFACE_TYPE_TRANSPARENT");
        mat.renderQueue = 3000;

        AssetDatabase.CreateAsset(mat, path);
        return mat;
    }

    // ────────────────────────────────────────────────────────────
    static void SetupHierarchy(GameObject clickEffect, Material matGlow,
        Material matSpark, Material matRing, System.Text.StringBuilder sb)
    {
        var m1T = clickEffect.transform.Find("M1");
        var m2T = clickEffect.transform.Find("M2");
        var m3T = clickEffect.transform.Find("M3");
        var m4T = clickEffect.transform.Find("M4");

        // 1. M3 first (M2's shape references M3's MeshRenderer)
        MeshRenderer m3Renderer = null;
        if (m3T != null)
        {
            if (m3T.GetComponent<MeshFilter>() == null)
            {
                m3Renderer = SetupM3(m3T.gameObject, matRing);
                sb.AppendLine("  M3: MeshFilter + MeshRenderer + SortingGroup added");
            }
            else
            {
                m3Renderer = m3T.GetComponent<MeshRenderer>();
                sb.AppendLine("  M3: already has MeshFilter, skipped");
            }
        }

        // 2. Click_Effect root PS (container, renderer disabled)
        SetupRoot(clickEffect);
        sb.AppendLine("  Click_Effect: ParticleSystem (container) added");

        // 3. M1 — glow
        if (m1T != null && m1T.GetComponent<ParticleSystem>() == null)
        {
            SetupM1(m1T.gameObject, matGlow);
            sb.AppendLine("  M1: ParticleSystem (glow) added");
        }

        // 4. M2 — sparks
        if (m2T != null && m2T.GetComponent<ParticleSystem>() == null)
        {
            SetupM2(m2T.gameObject, matSpark, m3Renderer);
            sb.AppendLine("  M2: ParticleSystem (sparks) added");
        }

        // 5. M4 — burst
        if (m4T != null && m4T.GetComponent<ParticleSystem>() == null)
        {
            SetupM4(m4T.gameObject, matRing);
            sb.AppendLine("  M4: ParticleSystem (burst) added");
        }
    }

    // ── Click_Effect root: container, renderer disabled ──
    static void SetupRoot(GameObject go)
    {
        var ps = go.AddComponent<ParticleSystem>();
        var main = ps.main;
        main.loop = false;
        main.duration = 2f;
        main.playOnAwake = true;
        main.scalingMode = ParticleSystemScalingMode.Local;
        main.startLifetime = 2f;
        main.startSpeed = 0f;
        main.startSize = 1f;
        main.startColor = Color.white;
        main.maxParticles = 20;

        var emission = ps.emission;
        emission.enabled = false;

        var shape = ps.shape;
        shape.enabled = false;

        var psr = go.GetComponent<ParticleSystemRenderer>();
        psr.enabled = false;
    }

    // ── M1: static glow billboard, 1 particle ──
    //    Bundle: looping, lifetime=5, speed=5, size=102.9, maxP=1
    //    Color: orange (1, 0.337, 0, 1)
    //    Material "M2": TX-GQ-039, _Brightness=1, _Color alpha=0.498
    static void SetupM1(GameObject go, Material mat)
    {
        var ps = go.AddComponent<ParticleSystem>();
        var main = ps.main;
        main.loop = true;
        main.duration = 5f;
        main.playOnAwake = true;
        main.scalingMode = ParticleSystemScalingMode.Hierarchy;
        main.startLifetime = 5f;
        main.startSpeed = 5f;
        main.startSize = 102.9f;
        main.maxParticles = 1;
        main.startColor = new Color(1f, 0.337f, 0f, 1f);

        var emission = ps.emission;
        emission.enabled = true;
        emission.rateOverTime = 100f;

        var shape = ps.shape;
        shape.enabled = false;

        var psr = go.GetComponent<ParticleSystemRenderer>();
        psr.enabled = true;
        psr.renderMode = ParticleSystemRenderMode.Billboard;
        psr.sharedMaterial = mat;
        psr.sortingLayerName = "UI";
        psr.sortingOrder = 3;
        psr.maxParticleSize = 10f;
    }

    // ── M2: spark particles from MeshRenderer shape ──
    //    Bundle: looping, lifetime=Random[0.3,0.75], speed=Random[5,30],
    //    size=Random[30,50], rotation=Random[-π/2,π/2], maxP=3
    //    Color: orange (0.99, 0.54, 0.27, 1)
    //    Shape: MeshRenderer (M3), scale=(70.4, 1, 71.3)
    //    SizeOverLifetime + ColorOverLifetime + RotationOverLifetime
    //    Material "M1": Glow_024, _Brightness=1.5
    static void SetupM2(GameObject go, Material mat, MeshRenderer shapeSource)
    {
        var ps = go.AddComponent<ParticleSystem>();
        var main = ps.main;
        main.loop = true;
        main.duration = 5f;
        main.playOnAwake = true;
        main.scalingMode = ParticleSystemScalingMode.Hierarchy;
        main.startLifetime = new ParticleSystem.MinMaxCurve(0.3f, 0.75f);
        main.startSpeed = new ParticleSystem.MinMaxCurve(5f, 30f);
        main.startSize = new ParticleSystem.MinMaxCurve(30f, 50f);
        main.startRotation = new ParticleSystem.MinMaxCurve(
            -Mathf.PI * 0.5f, Mathf.PI * 0.5f);
        main.startColor = new Color(0.99f, 0.54f, 0.27f, 1f);
        main.maxParticles = 3;

        var emission = ps.emission;
        emission.enabled = true;
        emission.rateOverTime = 10f;

        // Shape: emit from M3's MeshRenderer surface
        var shape = ps.shape;
        shape.enabled = true;
        shape.shapeType = ParticleSystemShapeType.MeshRenderer;
        shape.scale = new Vector3(70.4f, 1f, 71.3f);
        if (shapeSource != null)
            shape.meshRenderer = shapeSource;

        // Size over lifetime: 4-key curve with exact tangent slopes from bundle
        var sol = ps.sizeOverLifetime;
        sol.enabled = true;
        var sizeCurve = new AnimationCurve(
            new Keyframe(0.0000f, 1.0000f, -1.0f, -2.996f),
            new Keyframe(0.3179f, 0.04764f, -2.996f, 3.152f),
            new Keyframe(0.5517f, 0.7846f, 3.152f, -1.750f),
            new Keyframe(1.0000f, 0.0000f, -1.750f, -1.0f));
        sol.size = new ParticleSystem.MinMaxCurve(1f, sizeCurve);

        // Color over lifetime: warm orange gradient with alpha fade
        var col = ps.colorOverLifetime;
        col.enabled = true;
        var grad = new Gradient();
        grad.SetKeys(
            new GradientColorKey[] {
                new GradientColorKey(new Color(1f, 0.99f, 0.59f), 0.2236f),
                new GradientColorKey(new Color(0.81f, 0.38f, 0.11f), 0.5970f)
            },
            new GradientAlphaKey[] {
                new GradientAlphaKey(1f, 0.1559f),
                new GradientAlphaKey(1f, 0.8148f),
                new GradientAlphaKey(0f, 1f)
            });
        col.color = new ParticleSystem.MinMaxGradient(grad);

        // Rotation over lifetime: random spin
        var rol = ps.rotationOverLifetime;
        rol.enabled = true;
        rol.z = new ParticleSystem.MinMaxCurve(-Mathf.PI, Mathf.PI);

        var psr = go.GetComponent<ParticleSystemRenderer>();
        psr.enabled = true;
        psr.renderMode = ParticleSystemRenderMode.Billboard;
        psr.sharedMaterial = mat;
        psr.sortingLayerName = "UI";
        psr.sortingOrder = 2;
        psr.maxParticleSize = 10f;
    }

    // ── M3: rotating Quad mesh (NOT a particle system) ──
    //    Bundle: localScale=(100,100,1), MeshFilter=Quad, MeshRenderer mat "M3",
    //    SortingGroup sortingOrder=2, AutoRotation EulerAngleSpeed=(0,0,-180)
    //    (AutoRotation already added by Import_res_p_55.cs)
    static MeshRenderer SetupM3(GameObject go, Material mat)
    {
        // Get built-in Quad mesh
        var tempQuad = GameObject.CreatePrimitive(PrimitiveType.Quad);
        var quadMesh = tempQuad.GetComponent<MeshFilter>().sharedMesh;
        Object.DestroyImmediate(tempQuad);

        var mf = go.AddComponent<MeshFilter>();
        mf.sharedMesh = quadMesh;

        var mr = go.AddComponent<MeshRenderer>();
        mr.sharedMaterial = mat;
        mr.shadowCastingMode = ShadowCastingMode.Off;
        mr.receiveShadows = false;

        var sg = go.AddComponent<SortingGroup>();
        sg.sortingLayerName = "UI";
        sg.sortingOrder = 2;

        return mr;
    }

    // ── M4: burst ring/flash, one-shot ──
    //    Bundle: loop=false, duration=0.5, lifetime=0.45, speed=5, size=102.9,
    //    maxP=1, 1 burst at t=0 count=30 cycleCount=1
    //    SizeOverLifetime + ColorOverLifetime + RotationOverLifetime (6.28 rad/s)
    //    Material "M3": TX-GQ-002 (same as M3's mesh)
    static void SetupM4(GameObject go, Material mat)
    {
        var ps = go.AddComponent<ParticleSystem>();
        var main = ps.main;
        main.loop = false;
        main.duration = 0.5f;
        main.playOnAwake = true;
        main.scalingMode = ParticleSystemScalingMode.Hierarchy;
        main.startLifetime = 0.45f;
        main.startSpeed = 5f;
        main.startSize = 102.9f;
        main.startColor = Color.white;
        main.maxParticles = 1;

        var emission = ps.emission;
        emission.enabled = true;
        emission.rateOverTime = 0f;
        var burst = new ParticleSystem.Burst(0f, 30);
        burst.cycleCount = 1;
        burst.repeatInterval = 0.01f;
        emission.SetBursts(new ParticleSystem.Burst[] { burst });

        var shape = ps.shape;
        shape.enabled = false;

        // Size over lifetime: scale 2x, 3-key curve with exact tangent slopes from bundle
        var sol = ps.sizeOverLifetime;
        sol.enabled = true;
        var sizeCurve = new AnimationCurve(
            new Keyframe(0.0000f, 0.4000f, 0f, 2.210f),
            new Keyframe(0.1816f, 0.8013f, 2.210f, 0.243f),
            new Keyframe(1.0000f, 1.0000f, 0.243f, 0f));
        sol.size = new ParticleSystem.MinMaxCurve(2f, sizeCurve);

        // Color over lifetime: warm flash fading out
        var col = ps.colorOverLifetime;
        col.enabled = true;
        var grad = new Gradient();
        grad.SetKeys(
            new GradientColorKey[] {
                new GradientColorKey(new Color(1f, 0.99f, 0.59f), 0f),
                new GradientColorKey(new Color(0.81f, 0.38f, 0.11f), 1f)
            },
            new GradientAlphaKey[] {
                new GradientAlphaKey(1f, 0.1559f),
                new GradientAlphaKey(0.5686f, 0.3235f),
                new GradientAlphaKey(0f, 1f)
            });
        col.color = new ParticleSystem.MinMaxGradient(grad);

        // Rotation over lifetime: constant 2π rad/s (1 full rotation per second)
        var rol = ps.rotationOverLifetime;
        rol.enabled = true;
        rol.z = new ParticleSystem.MinMaxCurve(6.28f);

        var psr = go.GetComponent<ParticleSystemRenderer>();
        psr.enabled = true;
        psr.renderMode = ParticleSystemRenderMode.Billboard;
        psr.sharedMaterial = mat;
        psr.sortingLayerName = "UI";
        psr.sortingOrder = 3;
        psr.maxParticleSize = 10f;
    }

    static string GetPath(Transform t)
    {
        string path = t.name;
        while (t.parent != null) { t = t.parent; path = t.name + "/" + path; }
        return path;
    }
}
