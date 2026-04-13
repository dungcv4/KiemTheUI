// Recreated from KTO bundle UI/ImageEffect shader (res_1.ab)
// Properties and blend modes extracted via TypeTreeGenerator.
// Core features: _Brightness multiplier, _Color tint, UV rotation (_DiffuseRo/_DiffuseAng)
// Blend per-material: _SrcRGBMode/_DestRGBMode (default SrcAlpha/One = additive)
Shader "UI/ImageEffect"
{
    Properties
    {
        _Diffuse ("Diffuse", 2D) = "white" {}
        _Color ("Color", Color) = (1,1,1,1)
        _Brightness ("Brightness", Range(0, 10)) = 1
        _DiffuseRo ("UV Rotation", Float) = 0
        _DiffuseAng ("UV Rotation Angle", Float) = 0
        _AlphaCutout ("Alpha Cutout", Range(0, 1)) = 0

        // Blend mode (material-controlled)
        [Enum(UnityEngine.Rendering.BlendMode)] _SrcRGBMode ("Src RGB", Float) = 5
        [Enum(UnityEngine.Rendering.BlendMode)] _DestRGBMode ("Dst RGB", Float) = 1
        [Enum(UnityEngine.Rendering.BlendMode)] _SrcAlphaMode ("Src Alpha", Float) = 5
        [Enum(UnityEngine.Rendering.BlendMode)] _DestAlphaMode ("Dst Alpha", Float) = 1
        _ZWrite ("ZWrite", Float) = 0
        _TwoSide ("Two Side", Float) = 0
        _ColorMask ("Color Mask", Float) = 15

        // Stencil
        _StencilComp ("Stencil Comp", Float) = 8
        _Stencil ("Stencil ID", Float) = 0
        _StencilOp ("Stencil Op", Float) = 0
        _StencilWriteMask ("Stencil Write Mask", Float) = 255
        _StencilReadMask ("Stencil Read Mask", Float) = 255
    }

    SubShader
    {
        Tags
        {
            "Queue" = "Transparent"
            "RenderType" = "Transparent"
            "IgnoreProjector" = "True"
            "CanUseSpriteAtlas" = "True"
            "RenderPipeline" = "UniversalPipeline"
        }

        Stencil
        {
            Ref [_Stencil]
            Comp [_StencilComp]
            Pass [_StencilOp]
            ReadMask [_StencilReadMask]
            WriteMask [_StencilWriteMask]
        }

        Pass
        {
            Name "UIImageEffect"
            Blend [_SrcRGBMode] [_DestRGBMode]
            ZWrite [_ZWrite]
            ZTest LEqual
            Cull [_TwoSide]
            ColorMask [_ColorMask]

            HLSLPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma multi_compile_local _ _ALPHATEST_ON
            #pragma multi_compile_local _ _DIFFUSERO_ON

            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
                float4 color : COLOR;
            };

            struct v2f
            {
                float4 pos : SV_POSITION;
                float2 uv : TEXCOORD0;
                float4 color : COLOR;
            };

            TEXTURE2D(_Diffuse);
            SAMPLER(sampler_Diffuse);

            CBUFFER_START(UnityPerMaterial)
                float4 _Diffuse_ST;
                half4 _Color;
                half _Brightness;
                half _DiffuseRo;
                half _DiffuseAng;
                half _AlphaCutout;
            CBUFFER_END

            // Rotate UV around center (0.5, 0.5) by angle in degrees
            float2 RotateUV(float2 uv, float angleDeg)
            {
                float rad = angleDeg * 0.0174533; // deg to rad
                float cosA = cos(rad);
                float sinA = sin(rad);
                float2 centered = uv - 0.5;
                float2 rotated;
                rotated.x = centered.x * cosA - centered.y * sinA;
                rotated.y = centered.x * sinA + centered.y * cosA;
                return rotated + 0.5;
            }

            v2f vert(appdata v)
            {
                v2f o;
                o.pos = TransformObjectToHClip(v.vertex.xyz);
                o.uv = TRANSFORM_TEX(v.uv, _Diffuse);
                o.color = v.color;
                return o;
            }

            half4 frag(v2f i) : SV_Target
            {
                float2 uv = i.uv;

                // UV rotation
                if (_DiffuseRo > 0.5)
                {
                    uv = RotateUV(uv, _DiffuseAng);
                }

                half4 tex = SAMPLE_TEXTURE2D(_Diffuse, sampler_Diffuse, uv);

                half4 col;
                col.rgb = _Brightness * _Color.rgb * tex.rgb * i.color.rgb;
                col.a = _Color.a * tex.a * i.color.a;

                #ifdef _ALPHATEST_ON
                    clip(col.a - _AlphaCutout);
                #endif

                return col;
            }
            ENDHLSL
        }
    }

    // Fallback for built-in pipeline
    SubShader
    {
        Tags
        {
            "Queue" = "Transparent"
            "RenderType" = "Transparent"
            "IgnoreProjector" = "True"
        }

        Pass
        {
            Blend [_SrcRGBMode] [_DestRGBMode]
            ZWrite [_ZWrite]
            ZTest LEqual
            Cull [_TwoSide]

            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
                float4 color : COLOR;
            };

            struct v2f
            {
                float4 pos : SV_POSITION;
                float2 uv : TEXCOORD0;
                float4 color : COLOR;
            };

            sampler2D _Diffuse;
            float4 _Diffuse_ST;
            half4 _Color;
            half _Brightness;
            half _DiffuseRo;
            half _DiffuseAng;

            float2 RotateUV(float2 uv, float angleDeg)
            {
                float rad = angleDeg * 0.0174533;
                float c = cos(rad);
                float s = sin(rad);
                float2 centered = uv - 0.5;
                return float2(centered.x * c - centered.y * s, centered.x * s + centered.y * c) + 0.5;
            }

            v2f vert(appdata v)
            {
                v2f o;
                o.pos = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _Diffuse);
                o.color = v.color;
                return o;
            }

            half4 frag(v2f i) : SV_Target
            {
                float2 uv = i.uv;
                if (_DiffuseRo > 0.5) uv = RotateUV(uv, _DiffuseAng);
                half4 tex = tex2D(_Diffuse, uv);
                half4 col;
                col.rgb = _Brightness * _Color.rgb * tex.rgb * i.color.rgb;
                col.a = _Color.a * tex.a * i.color.a;
                return col;
            }
            ENDCG
        }
    }
}
