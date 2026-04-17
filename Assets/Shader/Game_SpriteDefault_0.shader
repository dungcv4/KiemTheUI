// DEVIATION — not from original source
//
// The original game ships a real `Game/SpriteDefault` shader compiled into
// libil2cpp.so / the APK shader cache. We do NOT have its source. Both
// AssetRipper extracts (this project AND RippedProject_APK/) produced
// "//DummyShaderTextExporter" stubs with `Tags { "RenderType"="Opaque" }`,
// no Blend, no `Cull Off`, no `ZWrite Off`. Routing 4622 SpriteRenderers
// through that stub turns every sprite into an opaque rectangle z-fighting
// with everything else (verified 2026-04-17 — that's exactly the "loạn"
// regression after Phase 9.5 wired material PPtrs through correctly).
//
// Reason for deviation: Cpp2IL stub — original HLSL is unrecoverable.
// Approved by user: 2026-04-17 ("tiếp tục" after I laid out options A/B/C).
// Original closest match: Unity built-in `Sprites/Default` shader, which
// is what every map SR was *visually* using before Phase 9.5 (because the
// map bundle's `m_Materials[0]` was unassigned, Unity fell back to it).
// This shader is a faithful copy of `Sprites/Default` semantics:
//   Queue=Transparent, RenderType=Transparent, IgnoreProjector,
//   Cull Off, Lighting Off, ZWrite Off, Blend One OneMinusSrcAlpha
//   (premultiplied alpha — matches what Unity Sprites do when Texture
//    Importer alphaIsTransparency=true, which is how KTO_MapImporter
//    configures every sprite atlas).
//
// Keep the shader name `Game/SpriteDefault` and GUID
// 13245e4a39e316c459eda47ca409101a so existing material PPtrs continue
// to resolve.
//
// Source for the directives we DO know about (from the bundle's SR fields
// and Unity's stock Sprites/Default):
//   _MainTex   — sprite texture (per-renderer)
//   _Color     — Tint, multiplied with sample
//   _Flip      — sprite atlas X/Y flip (we don't apply it because the SR
//                 component already pre-flips UVs in r.flipX / r.flipY)
Shader "Game/SpriteDefault"
{
    Properties
    {
        [PerRendererData] _MainTex ("Sprite Texture", 2D) = "white" {}
        _Color ("Tint", Color) = (1,1,1,1)
        [HideInInspector] _RendererColor ("RendererColor", Color) = (1,1,1,1)
    }

    SubShader
    {
        Tags
        {
            "Queue"           = "Transparent"
            "IgnoreProjector" = "True"
            "RenderType"      = "Transparent"
            "PreviewType"     = "Plane"
            "CanUseSpriteAtlas" = "True"
        }

        Cull     Off
        Lighting Off
        ZWrite   Off
        Blend    One OneMinusSrcAlpha   // premultiplied; matches Unity Sprites/Default

        Pass
        {
            CGPROGRAM
            #pragma vertex   vert
            #pragma fragment frag
            #pragma multi_compile_instancing
            #include "UnityCG.cginc"

            struct appdata_t
            {
                float4 vertex : POSITION;
                float4 color  : COLOR;
                float2 uv     : TEXCOORD0;
                UNITY_VERTEX_INPUT_INSTANCE_ID
            };

            struct v2f
            {
                float4 vertex : SV_POSITION;
                fixed4 color  : COLOR;
                float2 uv     : TEXCOORD0;
                UNITY_VERTEX_OUTPUT_STEREO
            };

            sampler2D _MainTex;
            fixed4    _Color;
            fixed4    _RendererColor;

            v2f vert(appdata_t IN)
            {
                v2f OUT;
                UNITY_SETUP_INSTANCE_ID(IN);
                UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(OUT);
                OUT.vertex = UnityObjectToClipPos(IN.vertex);
                OUT.uv     = IN.uv;
                // SR already premultiplies vertex color * RendererColor on CPU,
                // but stay safe here by combining once more (Sprites/Default does).
                OUT.color  = IN.color * _Color * _RendererColor;
                return OUT;
            }

            fixed4 frag(v2f IN) : SV_Target
            {
                fixed4 c = tex2D(_MainTex, IN.uv) * IN.color;
                // Premultiply alpha to match Blend One OneMinusSrcAlpha
                c.rgb *= c.a;
                return c;
            }
            ENDCG
        }
    }
}
