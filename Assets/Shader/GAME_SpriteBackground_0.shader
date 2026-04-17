// DEVIATION — not from original source
//
// AssetRipper produced a "//DummyShaderTextExporter" stub here, same as
// `Game/SpriteDefault`. The real `GAME/SpriteBackground` shader lives in
// the APK's compiled shader cache and is unrecoverable.
//
// Reason for deviation: Cpp2IL stub — original HLSL is unrecoverable.
// Approved by user: 2026-04-17 ("tiếp tục" after Phase 9.5 visual regression).
// Original closest match: Unity built-in `Sprites/Default`, treated as a
// background-plane variant (no per-renderer color mod, no atlas flip).
//
// `SpriteBackground.mat` is used by the Tilemap renderer for the ground
// plane in map bundles. The bundle's TilemapRenderer attaches it via
// PPtr<Material>. Same transparency semantics as `Game/SpriteDefault`
// (Queue=Transparent, ZWrite Off, premultiplied Blend), but we keep
// `_RendererColor` unused since Tilemap renderers don't drive it.
//
// Keep shader name `GAME/SpriteBackground` (uppercase GAME — matches the
// original) and GUID d9a64b43d4d15774e8a5bc32df757121.
Shader "GAME/SpriteBackground"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        [HideInInspector] _Color ("Tint", Color) = (1,1,1,1)
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

            v2f vert(appdata_t IN)
            {
                v2f OUT;
                UNITY_SETUP_INSTANCE_ID(IN);
                UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(OUT);
                OUT.vertex = UnityObjectToClipPos(IN.vertex);
                OUT.uv     = IN.uv;
                OUT.color  = IN.color * _Color;
                return OUT;
            }

            fixed4 frag(v2f IN) : SV_Target
            {
                fixed4 c = tex2D(_MainTex, IN.uv) * IN.color;
                c.rgb *= c.a;
                return c;
            }
            ENDCG
        }
    }
}
