Shader "effect/C_EffectStandard_URP"
{
    Properties
    {
        [Enum(TwoSide,0,Off,2)] _TwoSide ("2-Side", Float) = 2
        [HideInInspector] _ZWrite ("__zw", Float) = 0
        _AlphaCutout ("_AlphaCutout", Range(0, 1)) = 0
        _Diffuse ("Diffuse", 2D) = "white" {}
        [Toggle] _DiffuseRo ("Rotate", Float) = 0
        _DiffuseAng ("Rotate Angle", Float) = 0
        [HDR] _Color ("Color", Color) = (1,1,1,1)
        _Brightness ("Brightness", Range(0, 10)) = 1
        _Uspeed ("Uspeed", Float) = 0
        _Vspeed ("Vspeed", Float) = 0
        [Toggle] _DiffuseMask ("Diffuse Mask", Float) = 0
        _DiffuseMaskTex ("Mask Tex", 2D) = "white" {}
        _USpeed_diffusem ("Mask USpeed", Float) = 0
        _VSpeed_diffusem ("Mask VSpeed", Float) = 0
        [HideInInspector] _SrcRGBMode ("__src_rgb", Float) = 5
        [HideInInspector] _DestRGBMode ("__dst_rgb", Float) = 10

        // Distortion
        [Toggle] _DistortBlock ("Distort", Float) = 0
        _DistortTex ("Distort Tex", 2D) = "gray" {}
        _USpeed_distort ("Distort USpeed", Float) = 0
        _VSpeed_distort ("Distort VSpeed", Float) = 0
        _ForceX ("Distort ForceX", Float) = 0.1
        _ForceY ("Distort ForceY", Float) = 0.1

        // Second Layer
        [Toggle] _SecondLayerBlock ("Second Layer", Float) = 0
        _SecondLayerTex ("Second Tex", 2D) = "black" {}
        [Toggle] _SecondLayerMask ("Second Mask", Float) = 0
        _SecondLayerMaskTex ("Second Mask Tex", 2D) = "white" {}
        [HDR] _SecondLayerColor ("Second Color", Color) = (1,1,1,1)
        _SecondLayerBrightness ("Second Brightness", Range(0, 10)) = 1
        [Toggle] _SecondLayerRo ("Second Rotate", Float) = 0
        _SecondLayerAng ("Second Angle", Float) = 0
        _Uspeed_second ("Second USpeed", Float) = 0
        _Vspeed_second ("Second VSpeed", Float) = 0
        [Toggle] _SecondLayerMaskRo ("Second Mask Rotate", Float) = 0
        _SecondLayerMaskAng ("Second Mask Angle", Float) = 0
        _Uspeed_secondm ("Second Mask USpeed", Float) = 0
        _Vspeed_secondm ("Second Mask VSpeed", Float) = 0
    }

    SubShader
    {
        Tags
        {
            "RenderType" = "Transparent"
            "Queue" = "Transparent"
            "RenderPipeline" = "UniversalPipeline"
            "IgnoreProjector" = "True"
        }

        Pass
        {
            Name "EffectStandard"
            Blend [_SrcRGBMode] [_DestRGBMode]
            ZWrite [_ZWrite]
            Cull [_TwoSide]

            HLSLPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma multi_compile_particles
            #pragma multi_compile_fog

            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            struct Attributes
            {
                float4 positionOS : POSITION;
                float4 color      : COLOR;
                float2 uv         : TEXCOORD0;
            };

            struct Varyings
            {
                float4 positionCS : SV_POSITION;
                float4 color      : COLOR;
                float2 uv         : TEXCOORD0;
                float2 uvMask     : TEXCOORD1;
                float  fogFactor  : TEXCOORD2;
                float2 uvDistort  : TEXCOORD3;
                float2 uvSecond   : TEXCOORD4;
                float2 uvSecondM  : TEXCOORD5;
            };

            TEXTURE2D(_Diffuse);            SAMPLER(sampler_Diffuse);
            TEXTURE2D(_DiffuseMaskTex);     SAMPLER(sampler_DiffuseMaskTex);
            TEXTURE2D(_DistortTex);         SAMPLER(sampler_DistortTex);
            TEXTURE2D(_SecondLayerTex);     SAMPLER(sampler_SecondLayerTex);
            TEXTURE2D(_SecondLayerMaskTex); SAMPLER(sampler_SecondLayerMaskTex);

            CBUFFER_START(UnityPerMaterial)
                float4 _Diffuse_ST;
                float4 _DiffuseMaskTex_ST;
                float4 _DistortTex_ST;
                float4 _SecondLayerTex_ST;
                float4 _SecondLayerMaskTex_ST;
                float4 _Color;
                float4 _SecondLayerColor;
                float  _Brightness;
                float  _Uspeed;
                float  _Vspeed;
                float  _DiffuseRo;
                float  _DiffuseAng;
                float  _DiffuseMask;
                float  _USpeed_diffusem;
                float  _VSpeed_diffusem;
                float  _AlphaCutout;
                // Distortion
                float  _DistortBlock;
                float  _USpeed_distort;
                float  _VSpeed_distort;
                float  _ForceX;
                float  _ForceY;
                // Second Layer
                float  _SecondLayerBlock;
                float  _SecondLayerBrightness;
                float  _SecondLayerRo;
                float  _SecondLayerAng;
                float  _Uspeed_second;
                float  _Vspeed_second;
                float  _SecondLayerMask;
                float  _SecondLayerMaskRo;
                float  _SecondLayerMaskAng;
                float  _Uspeed_secondm;
                float  _Vspeed_secondm;
            CBUFFER_END

            float2 RotateUV(float2 uv, float angle)
            {
                float rad = angle * 0.0174533;
                float s = sin(rad);
                float c = cos(rad);
                uv -= 0.5;
                float2 rotated = float2(uv.x * c - uv.y * s, uv.x * s + uv.y * c);
                return rotated + 0.5;
            }

            Varyings vert(Attributes input)
            {
                Varyings output;
                VertexPositionInputs vpi = GetVertexPositionInputs(input.positionOS.xyz);
                output.positionCS = vpi.positionCS;
                output.color = input.color;

                // Diffuse UV
                output.uv = TRANSFORM_TEX(input.uv, _Diffuse);
                output.uv += float2(_Uspeed, _Vspeed) * _Time.y;

                // Mask UV
                output.uvMask = TRANSFORM_TEX(input.uv, _DiffuseMaskTex);
                output.uvMask += float2(_USpeed_diffusem, _VSpeed_diffusem) * _Time.y;

                // Distort UV
                output.uvDistort = TRANSFORM_TEX(input.uv, _DistortTex);
                output.uvDistort += float2(_USpeed_distort, _VSpeed_distort) * _Time.y;

                // Second Layer UV
                output.uvSecond = TRANSFORM_TEX(input.uv, _SecondLayerTex);
                output.uvSecond += float2(_Uspeed_second, _Vspeed_second) * _Time.y;

                // Second Layer Mask UV
                output.uvSecondM = TRANSFORM_TEX(input.uv, _SecondLayerMaskTex);
                output.uvSecondM += float2(_Uspeed_secondm, _Vspeed_secondm) * _Time.y;

                output.fogFactor = ComputeFogFactor(vpi.positionCS.z);
                return output;
            }

            half4 frag(Varyings input) : SV_Target
            {
                float2 uv = input.uv;

                // UV rotation
                if (_DiffuseRo > 0.5)
                    uv = RotateUV(uv, _DiffuseAng + _Time.y * 30.0);

                // Distortion: offset diffuse UV using distort texture
                if (_DistortBlock > 0.5)
                {
                    half4 distort = SAMPLE_TEXTURE2D(_DistortTex, sampler_DistortTex, input.uvDistort);
                    // Remap 0..1 to -0.5..0.5, multiply by force
                    float2 offset = (distort.rg - 0.5) * float2(_ForceX, _ForceY);
                    uv += offset;
                }

                // Sample diffuse
                half4 diffuse = SAMPLE_TEXTURE2D(_Diffuse, sampler_Diffuse, uv);

                // Apply mask
                if (_DiffuseMask > 0.5)
                {
                    half4 mask = SAMPLE_TEXTURE2D(_DiffuseMaskTex, sampler_DiffuseMaskTex, input.uvMask);
                    diffuse.a *= mask.r;
                }

                // Color tint with HDR brightness
                half4 col;
                col.rgb = diffuse.rgb * _Color.rgb * _Brightness * input.color.rgb;
                col.a = diffuse.a * _Color.a * input.color.a;

                // Second Layer: additive blend
                if (_SecondLayerBlock > 0.5)
                {
                    float2 secUV = input.uvSecond;
                    if (_SecondLayerRo > 0.5)
                        secUV = RotateUV(secUV, _SecondLayerAng + _Time.y * 30.0);

                    half4 secTex = SAMPLE_TEXTURE2D(_SecondLayerTex, sampler_SecondLayerTex, secUV);

                    // Apply second layer mask
                    if (_SecondLayerMask > 0.5)
                    {
                        float2 secMaskUV = input.uvSecondM;
                        if (_SecondLayerMaskRo > 0.5)
                            secMaskUV = RotateUV(secMaskUV, _SecondLayerMaskAng + _Time.y * 30.0);
                        half4 secMask = SAMPLE_TEXTURE2D(_SecondLayerMaskTex, sampler_SecondLayerMaskTex, secMaskUV);
                        secTex.a *= secMask.r;
                    }

                    half3 secColor = secTex.rgb * _SecondLayerColor.rgb * _SecondLayerBrightness * input.color.rgb;
                    col.rgb += secColor * secTex.a;
                }

                // Alpha cutout
                clip(col.a - _AlphaCutout);

                // Fog
                col.rgb = MixFog(col.rgb, input.fogFactor);

                return col;
            }
            ENDHLSL
        }
    }

    Fallback "Universal Render Pipeline/Particles/Unlit"
}
