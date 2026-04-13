// Reconstruction of the Tuanjie KTO "UI/ImageEffect" shader.
// Inputs reverse-engineered from:
//   - .mat property names found across the Banner / Glow / Distort materials
//   - ImageEffectAnimationController.cs (PropertyToID strings + LoadKeywords)
//   - dummy AssetRipper variants (blend mode + render queue)
// All uniforms read by the controller are declared, even when unused, so
// SetFloat/SetTexture* never silently no-op.

Shader "KTO/UI_ImageEffect"
{
    Properties
    {
        [PerRendererData] _MainTex ("Sprite Texture", 2D) = "white" {}
        _Diffuse           ("Diffuse",         2D) = "white" {}
        _DiffuseMaskTex    ("Diffuse Mask",    2D) = "white" {}
        _MaskMaskTex       ("Mask Mask",       2D) = "white" {}
        _DissolveTex       ("Dissolve",        2D) = "white" {}
        _DistortTex        ("Distort",         2D) = "black" {}
        _DistortMaskTex    ("Distort Mask",    2D) = "white" {}

        [HDR] _Color       ("Color", Color) = (1,1,1,1)
        [HDR] _EdgeColor   ("Edge Color", Color) = (1,1,1,1)
        _Brightness        ("Brightness", Range(0,10)) = 1
        _AlphaCutout       ("Alpha Cutout", Range(0,1)) = 0

        _Uspeed            ("U speed",            Float) = 0
        _Vspeed            ("V speed",            Float) = 0
        _USpeed_diffusem   ("U speed (mask)",     Float) = 0
        _VSpeed_diffusem   ("V speed (mask)",     Float) = 0
        _USpeed_distort    ("U speed (distort)",  Float) = 0
        _VSpeed_distort    ("V speed (distort)",  Float) = 0
        _DissolveUSpeed    ("U speed (dissolve)", Float) = 0
        _DissolveVSpeed    ("V speed (dissolve)", Float) = 0

        _DiffuseRo         ("Diffuse rotate",      Float) = 0
        _DiffuseAng        ("Diffuse angle",       Float) = 0
        _DiffuseMaskRo     ("Mask rotate",         Float) = 0
        _DiffuseMaskAng    ("Mask angle",          Float) = 0

        _DissolveProgress  ("Dissolve progress", Range(0,1)) = 1
        _EdgeWidth         ("Edge width",        Range(0,1)) = 0
        _ForceX            ("Distort force X",   Float) = 0
        _ForceY            ("Distort force Y",   Float) = 0

        _BlendSet          ("Blend set",         Float) = 5
        _TwoSide           ("Two side",          Float) = 2

        _StencilComp       ("Stencil Comparison",Float) = 8
        _Stencil           ("Stencil ID",        Float) = 0
        _StencilOp         ("Stencil Operation", Float) = 0
        _StencilWriteMask  ("Stencil Write Mask",Float) = 255
        _StencilReadMask   ("Stencil Read Mask", Float) = 255
        _ColorMask         ("Color Mask",        Float) = 15

        [Toggle(_DIFFUSEMASK_ON)] _DiffuseMask  ("Use Diffuse Mask", Float) = 0
        [Toggle(_DISSOLVE_ON)]    _DissolveBlock("Use Dissolve",     Float) = 0
        [Toggle(_DISTORT_ON)]     _DistortBlock ("Use Distort",      Float) = 0
        [Toggle(_DISTORTMASK_ON)] _DistortMask  ("Use Distort Mask", Float) = 0
    }

    SubShader
    {
        Tags
        {
            "Queue"            = "Transparent"
            "IgnoreProjector"  = "True"
            "RenderType"       = "Transparent"
            "PreviewType"      = "Plane"
            "CanUseSpriteAtlas"= "True"
        }

        Stencil
        {
            Ref       [_Stencil]
            Comp      [_StencilComp]
            Pass      [_StencilOp]
            ReadMask  [_StencilReadMask]
            WriteMask [_StencilWriteMask]
        }

        Cull Off
        Lighting Off
        ZWrite Off
        ZTest [unity_GUIZTestMode]
        Blend SrcAlpha One
        ColorMask [_ColorMask]

        Pass
        {
            Name "Default"
            CGPROGRAM
            #pragma vertex   vert
            #pragma fragment frag
            #pragma multi_compile_local _ _DIFFUSEMASK_ON
            #pragma multi_compile_local _ _DISSOLVE_ON
            #pragma multi_compile_local _ _DISTORT_ON
            #pragma multi_compile_local _ _DISTORTMASK_ON
            #include "UnityCG.cginc"
            #include "UnityUI.cginc"

            struct appdata_t
            {
                float4 vertex   : POSITION;
                float4 color    : COLOR;
                float2 texcoord : TEXCOORD0;
            };

            struct v2f
            {
                float4 vertex   : SV_POSITION;
                fixed4 color    : COLOR;
                float2 texcoord : TEXCOORD0;
                float4 worldPos : TEXCOORD1;
            };

            sampler2D _MainTex;
            sampler2D _Diffuse;        float4 _Diffuse_ST;
            sampler2D _DiffuseMaskTex; float4 _DiffuseMaskTex_ST;
            sampler2D _MaskMaskTex;    float4 _MaskMaskTex_ST;
            sampler2D _DissolveTex;    float4 _DissolveTex_ST;
            sampler2D _DistortTex;     float4 _DistortTex_ST;
            sampler2D _DistortMaskTex; float4 _DistortMaskTex_ST;

            float4 _Color;
            float4 _EdgeColor;
            float  _Brightness;
            float  _AlphaCutout;

            float  _Uspeed,           _Vspeed;
            float  _USpeed_diffusem,  _VSpeed_diffusem;
            float  _USpeed_distort,   _VSpeed_distort;
            float  _DissolveUSpeed,   _DissolveVSpeed;

            float  _DiffuseRo, _DiffuseAng;
            float  _DiffuseMaskRo, _DiffuseMaskAng;
            float  _DissolveProgress, _EdgeWidth;
            float  _ForceX, _ForceY;

            float2 RotateUV(float2 uv, float angDeg)
            {
                if (abs(angDeg) < 0.0001) return uv;
                float a = radians(angDeg);
                float s, c; sincos(a, s, c);
                float2 p = uv - 0.5;
                return float2(p.x * c - p.y * s, p.x * s + p.y * c) + 0.5;
            }

            v2f vert(appdata_t IN)
            {
                v2f OUT;
                OUT.worldPos = IN.vertex;
                OUT.vertex   = UnityObjectToClipPos(IN.vertex);
                OUT.texcoord = IN.texcoord;
                OUT.color    = IN.color;
                return OUT;
            }

            fixed4 frag(v2f IN) : SV_Target
            {
                float2 uvBase = IN.texcoord;

                // ---- Distortion offset (modifies the diffuse sampling UV) ----
                float2 distortOffset = float2(0,0);
                #if defined(_DISTORT_ON)
                {
                    float2 uvD = uvBase * _DistortTex_ST.xy + _DistortTex_ST.zw
                               + float2(_USpeed_distort, _VSpeed_distort) * _Time.y;
                    float2 d = tex2D(_DistortTex, uvD).rg * 2.0 - 1.0;
                    float maskD = 1.0;
                    #if defined(_DISTORTMASK_ON)
                        float2 uvDM = uvBase * _DistortMaskTex_ST.xy + _DistortMaskTex_ST.zw;
                        maskD = tex2D(_DistortMaskTex, uvDM).a;
                    #endif
                    distortOffset = d * float2(_ForceX, _ForceY) * maskD;
                }
                #endif

                // ---- Diffuse sample (rotated, scrolled, distorted) ----
                float2 uvDiff = RotateUV(uvBase, _DiffuseRo > 0.5 ? _DiffuseAng : 0.0);
                uvDiff = uvDiff * _Diffuse_ST.xy + _Diffuse_ST.zw;
                uvDiff += float2(_Uspeed, _Vspeed) * _Time.y + distortOffset;
                fixed4 diff = tex2D(_Diffuse, uvDiff);

                // ---- Diffuse-mask alpha multiplier ----
                fixed maskA = 1.0;
                #if defined(_DIFFUSEMASK_ON)
                {
                    float2 uvM = RotateUV(uvBase, _DiffuseMaskRo > 0.5 ? _DiffuseMaskAng : 0.0);
                    uvM = uvM * _DiffuseMaskTex_ST.xy + _DiffuseMaskTex_ST.zw
                        + float2(_USpeed_diffusem, _VSpeed_diffusem) * _Time.y;
                    fixed4 m = tex2D(_DiffuseMaskTex, uvM);
                    fixed4 mm = tex2D(_MaskMaskTex,
                                      uvBase * _MaskMaskTex_ST.xy + _MaskMaskTex_ST.zw);
                    maskA = m.a * mm.a;
                }
                #endif

                // ---- Dissolve cutout + edge ----
                fixed dissolveAlpha = 1.0;
                fixed3 dissolveEdge = float3(0,0,0);
                #if defined(_DISSOLVE_ON)
                {
                    float2 uvDis = uvBase * _DissolveTex_ST.xy + _DissolveTex_ST.zw
                                 + float2(_DissolveUSpeed, _DissolveVSpeed) * _Time.y;
                    fixed n = tex2D(_DissolveTex, uvDis).r;
                    fixed cutoff = _DissolveProgress;
                    dissolveAlpha = step(cutoff, n);
                    fixed edge = step(cutoff, n) - step(cutoff + _EdgeWidth, n);
                    dissolveEdge = _EdgeColor.rgb * edge;
                }
                #endif

                fixed4 col;
                col.rgb = diff.rgb * _Color.rgb * _Brightness + dissolveEdge;
                col.a   = diff.a * maskA * dissolveAlpha * _Color.a * IN.color.a;

                clip(col.a - _AlphaCutout);
                return col;
            }
            ENDCG
        }
    }

    Fallback "UI/Default"
}
