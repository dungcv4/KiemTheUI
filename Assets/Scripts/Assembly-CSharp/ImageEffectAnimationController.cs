// Reconstructed from KTO il2cpp dump (TypeDefIndex 458).
// Field layout, method signatures, and the *_LastFrame dirty-check pattern
// are taken verbatim from the dump; method bodies are reconstructed to match
// the only behavior consistent with: shader uniform names found in the
// existing .mat files, the [ExecuteAlways]+RequireComponent attribute pair,
// and the LoadValuesFromMaterial / SendValuesToMaterial / RegisterAsLastFrame
// helper triple. Animator drives the public fields by name; Update() pushes
// any changed value into the cloned material via cached PropertyToID handles.

using UnityEngine;
using UnityEngine.UI;

public enum BlendSetOption
{
    Opaque        = 0,
    BlendNormal   = 1,
    BlendAdd      = 2,
    Cutout        = 3,
    BlendNormalUI = 4,
    BlendAddUI    = 5,
}

public enum TwoSideOption
{
    TwoSide = 0,
    Off     = 2,
}

public enum StencilOption
{
    Off   = 0,
    Equal = 4,
}

// DefaultExecutionOrder forces our Awake/OnEnable to run BEFORE Unity's
// Animator (default order 0). The Animator captures "default" values for
// every animated property at OnEnable; if our LoadValuesFromMaterial hasn't
// run yet, the animator captures the field initializers (Color.white,
// Brightness=1, …) and then writes those over the material whenever a clip
// transition needs a default. By running first we make the captured defaults
// match the material asset values.
[DefaultExecutionOrder(-1000)]
[ExecuteAlways]
[RequireComponent(typeof(Graphic))]
public class ImageEffectAnimationController : MonoBehaviour
{
    // ----- runtime cached -----
    private Material uiMaterial;
    private Graphic  graphic;

    // ----- public, animator-driven -----
    public bool             SingleMaterial;
    public BlendSetOption   BlendSet;
    [Range(0, 1)] public float AlphaCutout;
    public TwoSideOption    TwoSide;

    public Vector2 MainTexTiling = Vector2.one;
    public Vector2 MainTexOffset;

    public bool    DiffuseRo;
    public float   DiffuseAng;
    [ColorUsage(true, true)] public Color HDRColor = Color.white;
    [Range(0, 10)] public float Brightness = 1f;
    public float   Uspeed;
    public float   Vspeed;

    public StencilOption StencilMode;
    public float         StencilID;

    public Vector2 DiffuseMaskTexTiling     = Vector2.one;
    public Vector2 DiffuseMaskTexOffset;
    public Vector2 DiffuseMaskMaskTexTiling = Vector2.one;
    public Vector2 DiffuseMaskMaskTexOffset;
    public bool    DiffuseMaskRo;
    public float   DiffuseMaskAng;
    public float   DiffuseMaskUspeed;
    public float   DiffuseMaskVspeed;

    public Vector2 DissolveTexTiling = Vector2.one;
    public Vector2 DissolveTexOffset;
    [ColorUsage(true, true)] public Color EdgeColor = Color.white;
    public float   DissolveProgress = 1f;
    public float   EdgeWidth;
    public float   DissolveUspeed;
    public float   DissolveVspeed;

    public Vector2 DistortTexTiling = Vector2.one;
    public Vector2 DistortTexOffset;
    public float   DistortForceX;
    public float   DistortForceY;
    public float   DistortUspeed;
    public float   DistortVspeed;
    public Vector2 DistortMaskTexTiling = Vector2.one;
    public Vector2 DistortMaskTexOffset;

    // ----- last-frame mirrors (dirty-check) -----
    private BlendSetOption BlendSet_LastFrame;
    private float          AlphaCutout_LastFrame;
    private TwoSideOption  TwoSide_LastFrame;
    private Vector2        MainTexTiling_LastFrame;
    private Vector2        MainTexOffset_LastFrame;
    private bool           DiffuseRo_LastFrame;
    private float          DiffuseAng_LastFrame;
    private Color          HDRColor_LastFrame;
    private float          Brightness_LastFrame;
    private float          Uspeed_LastFrame;
    private float          Vspeed_LastFrame;
    private StencilOption  StencilMode_LastFrame;
    private float          StencilID_LastFrame;
    private Vector2        DiffuseMaskTexTiling_LastFrame;
    private Vector2        DiffuseMaskTexOffset_LastFrame;
    private Vector2        DiffuseMaskMaskTexTiling_LastFrame;
    private Vector2        DiffuseMaskMaskTexOffset_LastFrame;
    private bool           DiffuseMaskRo_LastFrame;
    private float          DiffuseMaskAng_LastFrame;
    private float          DiffuseMaskUspeed_LastFrame;
    private float          DiffuseMaskVspeed_LastFrame;
    private Vector2        DissolveTexTiling_LastFrame;
    private Vector2        DissolveTexOffset_LastFrame;
    private Color          EdgeColor_LastFrame;
    private float          DissolveProgress_LastFrame;
    private float          EdgeWidth_LastFrame;
    private float          DissolveUspeed_LastFrame;
    private float          DissolveVspeed_LastFrame;
    private Vector2        DistortTexTiling_LastFrame;
    private Vector2        DistortTexOffset_LastFrame;
    private float          DistortForceX_LastFrame;
    private float          DistortForceY_LastFrame;
    private float          DistortUspeed_LastFrame;
    private float          DistortVspeed_LastFrame;
    private Vector2        DistortMaskTexTiling_LastFrame;
    private Vector2        DistortMaskTexOffset_LastFrame;

    // ----- cached PropertyToID -----
    private static readonly int BlendSet_ID          = Shader.PropertyToID("_BlendSet");
    private static readonly int AlphaCutout_ID       = Shader.PropertyToID("_AlphaCutout");
    private static readonly int TwoSide_ID           = Shader.PropertyToID("_TwoSide");
    private static readonly int MainTex_ID           = Shader.PropertyToID("_MainTex");
    private static readonly int DiffuseRo_ID         = Shader.PropertyToID("_DiffuseRo");
    private static readonly int DiffuseAng_ID        = Shader.PropertyToID("_DiffuseAng");
    private static readonly int HDRColor_ID          = Shader.PropertyToID("_Color");
    private static readonly int Brightness_ID        = Shader.PropertyToID("_Brightness");
    private static readonly int Uspeed_ID            = Shader.PropertyToID("_Uspeed");
    private static readonly int Vspeed_ID            = Shader.PropertyToID("_Vspeed");
    private static readonly int StencilMode_ID       = Shader.PropertyToID("_StencilComp");
    private static readonly int StencilID_ID         = Shader.PropertyToID("_Stencil");
    private static readonly int DiffuseMaskTex_ID    = Shader.PropertyToID("_DiffuseMaskTex");
    private static readonly int DiffuseMaskMaskTex_ID = Shader.PropertyToID("_MaskMaskTex");
    private static readonly int DiffuseMaskRo_ID     = Shader.PropertyToID("_DiffuseMaskRo");
    private static readonly int DiffuseMaskAng_ID    = Shader.PropertyToID("_DiffuseMaskAng");
    private static readonly int DiffuseMaskUspeed_ID = Shader.PropertyToID("_USpeed_diffusem");
    private static readonly int DiffuseMaskVspeed_ID = Shader.PropertyToID("_VSpeed_diffusem");
    private static readonly int DissolveTex_ID       = Shader.PropertyToID("_DissolveTex");
    private static readonly int EdgeColor_ID         = Shader.PropertyToID("_EdgeColor");
    private static readonly int DissolveProgress_ID  = Shader.PropertyToID("_DissolveProgress");
    private static readonly int EdgeWidth_ID         = Shader.PropertyToID("_EdgeWidth");
    private static readonly int DissolveUspeed_ID    = Shader.PropertyToID("_DissolveUSpeed");
    private static readonly int DissolveVspeed_ID    = Shader.PropertyToID("_DissolveVSpeed");
    private static readonly int DistortTex_ID        = Shader.PropertyToID("_DistortTex");
    private static readonly int DistortForceX_ID     = Shader.PropertyToID("_ForceX");
    private static readonly int DistortForceY_ID     = Shader.PropertyToID("_ForceY");
    private static readonly int DistortUspeed_ID     = Shader.PropertyToID("_USpeed_distort");
    private static readonly int DistortVspeed_ID     = Shader.PropertyToID("_VSpeed_distort");
    private static readonly int DistortMaskTex_ID    = Shader.PropertyToID("_DistortMaskTex");

    // ----- keyword cache -----
    private bool UseDiffuseMask;
    private bool UseDissolveBlock;
    private bool UseDistortBlock;
    private bool UseDistortMask;

    public Material UiMaterial => uiMaterial;

    public bool IsUseKeyword(string keyword)
    {
        if (uiMaterial == null) return false;
        var kws = uiMaterial.shaderKeywords;
        for (int i = 0; i < kws.Length; i++)
            if (kws[i] == keyword) return true;
        return false;
    }

    public static string GetFullPath(Transform transform)
    {
        if (transform == null) return string.Empty;
        var sb = new System.Text.StringBuilder(transform.name);
        var t = transform.parent;
        while (t != null) { sb.Insert(0, t.name + "/"); t = t.parent; }
        return sb.ToString();
    }

    // Marker suffix on per-instance clones — used to detect already-cloned
    // materials so repeated OnEnable calls (or domain reloads while in play
    // mode) don't snowball "(Clone) (Clone) (Clone)…" generations.
    private const string CloneMarker = " [KTO]";

    private void TryCloneMaterial()
    {
        if (graphic == null) return;
        var src = graphic.material;
        if (src == null) { uiMaterial = null; return; }

        // If the bound material is already one of our instances, just adopt
        // it. This happens after a domain reload where graphic.material
        // points at the runtime clone we created last frame.
        if (src.name.EndsWith(CloneMarker))
        {
            uiMaterial = src;
            return;
        }

        if (Application.isPlaying)
        {
            // Fresh runtime clone so animator drives don't bleed across the
            // shared asset.
            uiMaterial = new Material(src) { name = src.name + CloneMarker };
            graphic.material = uiMaterial;
        }
        else
        {
            // Edit-mode preview: read the asset directly, never modify it.
            uiMaterial = src;
        }
    }

    private void ConnectMaterial()
    {
        if (graphic == null) graphic = GetComponent<Graphic>();
        if (graphic == null) return;
        if (SingleMaterial) uiMaterial = graphic.material;
        else                TryCloneMaterial();
        // The controller only knows how to drive KTO/UI_ImageEffect-style
        // materials. If the Image is bound to UI/Default (or anything else
        // that lacks our properties), drop the reference so LoadValues /
        // SendValues become no-ops instead of spamming GetFloat errors.
        if (uiMaterial != null && !uiMaterial.HasProperty(BlendSet_ID))
            uiMaterial = null;
        LoadKeywords();
    }

    private void LoadKeywords()
    {
        if (uiMaterial == null) return;
        UseDiffuseMask   = IsUseKeyword("_DIFFUSEMASK_ON");
        UseDissolveBlock = IsUseKeyword("_DISSOLVE_ON");
        UseDistortBlock  = IsUseKeyword("_DISTORT_ON");
        UseDistortMask   = IsUseKeyword("_DISTORTMASK_ON");
    }

    private void Awake()
    {
        ConnectMaterial();
    }

    private void OnEnable()
    {
        ConnectMaterial();
        LoadValuesFromMaterial();
    }

    private void Update()
    {
        SendValuesToMaterial();
    }

    public void LoadValuesFromMaterial()
    {
        if (uiMaterial == null) return;
        LoadKeywords();

        BlendSet     = (BlendSetOption)uiMaterial.GetInt(BlendSet_ID);
        AlphaCutout  = uiMaterial.GetFloat(AlphaCutout_ID);
        TwoSide      = (TwoSideOption)uiMaterial.GetInt(TwoSide_ID);

        if (uiMaterial.HasProperty(MainTex_ID))
        {
            MainTexTiling = uiMaterial.GetTextureScale(MainTex_ID);
            MainTexOffset = uiMaterial.GetTextureOffset(MainTex_ID);
        }
        DiffuseRo  = uiMaterial.GetFloat(DiffuseRo_ID)  > 0.5f;
        DiffuseAng = uiMaterial.GetFloat(DiffuseAng_ID);
        HDRColor   = uiMaterial.GetColor(HDRColor_ID);
        Brightness = uiMaterial.GetFloat(Brightness_ID);
        Uspeed     = uiMaterial.GetFloat(Uspeed_ID);
        Vspeed     = uiMaterial.GetFloat(Vspeed_ID);

        StencilMode = (StencilOption)uiMaterial.GetInt(StencilMode_ID);
        StencilID   = uiMaterial.GetFloat(StencilID_ID);

        if (UseDiffuseMask)
        {
            if (uiMaterial.HasProperty(DiffuseMaskTex_ID))
            {
                DiffuseMaskTexTiling = uiMaterial.GetTextureScale(DiffuseMaskTex_ID);
                DiffuseMaskTexOffset = uiMaterial.GetTextureOffset(DiffuseMaskTex_ID);
            }
            if (uiMaterial.HasProperty(DiffuseMaskMaskTex_ID))
            {
                DiffuseMaskMaskTexTiling = uiMaterial.GetTextureScale(DiffuseMaskMaskTex_ID);
                DiffuseMaskMaskTexOffset = uiMaterial.GetTextureOffset(DiffuseMaskMaskTex_ID);
            }
            DiffuseMaskRo     = uiMaterial.GetFloat(DiffuseMaskRo_ID) > 0.5f;
            DiffuseMaskAng    = uiMaterial.GetFloat(DiffuseMaskAng_ID);
            DiffuseMaskUspeed = uiMaterial.GetFloat(DiffuseMaskUspeed_ID);
            DiffuseMaskVspeed = uiMaterial.GetFloat(DiffuseMaskVspeed_ID);
        }

        if (UseDissolveBlock)
        {
            if (uiMaterial.HasProperty(DissolveTex_ID))
            {
                DissolveTexTiling = uiMaterial.GetTextureScale(DissolveTex_ID);
                DissolveTexOffset = uiMaterial.GetTextureOffset(DissolveTex_ID);
            }
            EdgeColor        = uiMaterial.GetColor(EdgeColor_ID);
            DissolveProgress = uiMaterial.GetFloat(DissolveProgress_ID);
            EdgeWidth        = uiMaterial.GetFloat(EdgeWidth_ID);
            DissolveUspeed   = uiMaterial.GetFloat(DissolveUspeed_ID);
            DissolveVspeed   = uiMaterial.GetFloat(DissolveVspeed_ID);
        }

        if (UseDistortBlock)
        {
            if (uiMaterial.HasProperty(DistortTex_ID))
            {
                DistortTexTiling = uiMaterial.GetTextureScale(DistortTex_ID);
                DistortTexOffset = uiMaterial.GetTextureOffset(DistortTex_ID);
            }
            DistortForceX = uiMaterial.GetFloat(DistortForceX_ID);
            DistortForceY = uiMaterial.GetFloat(DistortForceY_ID);
            DistortUspeed = uiMaterial.GetFloat(DistortUspeed_ID);
            DistortVspeed = uiMaterial.GetFloat(DistortVspeed_ID);
        }

        if (UseDistortMask && uiMaterial.HasProperty(DistortMaskTex_ID))
        {
            DistortMaskTexTiling = uiMaterial.GetTextureScale(DistortMaskTex_ID);
            DistortMaskTexOffset = uiMaterial.GetTextureOffset(DistortMaskTex_ID);
        }

        RegisterAsLastFrame();
    }

    public void SendValuesToMaterial()
    {
        if (uiMaterial == null)
        {
            ConnectMaterial();
            if (uiMaterial == null) return;
        }

        if (BlendSet != BlendSet_LastFrame)
        { uiMaterial.SetInt(BlendSet_ID, (int)BlendSet); BlendSet_LastFrame = BlendSet; }

        if (AlphaCutout != AlphaCutout_LastFrame)
        { uiMaterial.SetFloat(AlphaCutout_ID, AlphaCutout); AlphaCutout_LastFrame = AlphaCutout; }

        if (TwoSide != TwoSide_LastFrame)
        { uiMaterial.SetInt(TwoSide_ID, (int)TwoSide); TwoSide_LastFrame = TwoSide; }

        if (MainTexTiling != MainTexTiling_LastFrame)
        { uiMaterial.SetTextureScale(MainTex_ID, MainTexTiling); MainTexTiling_LastFrame = MainTexTiling; }

        if (MainTexOffset != MainTexOffset_LastFrame)
        { uiMaterial.SetTextureOffset(MainTex_ID, MainTexOffset); MainTexOffset_LastFrame = MainTexOffset; }

        if (DiffuseRo != DiffuseRo_LastFrame)
        { uiMaterial.SetFloat(DiffuseRo_ID, DiffuseRo ? 1f : 0f); DiffuseRo_LastFrame = DiffuseRo; }

        if (DiffuseAng != DiffuseAng_LastFrame)
        { uiMaterial.SetFloat(DiffuseAng_ID, DiffuseAng); DiffuseAng_LastFrame = DiffuseAng; }

        if (HDRColor != HDRColor_LastFrame)
        { uiMaterial.SetColor(HDRColor_ID, HDRColor); HDRColor_LastFrame = HDRColor; }

        if (Brightness != Brightness_LastFrame)
        { uiMaterial.SetFloat(Brightness_ID, Brightness); Brightness_LastFrame = Brightness; }

        if (Uspeed != Uspeed_LastFrame)
        { uiMaterial.SetFloat(Uspeed_ID, Uspeed); Uspeed_LastFrame = Uspeed; }

        if (Vspeed != Vspeed_LastFrame)
        { uiMaterial.SetFloat(Vspeed_ID, Vspeed); Vspeed_LastFrame = Vspeed; }

        if (StencilMode != StencilMode_LastFrame)
        { uiMaterial.SetInt(StencilMode_ID, (int)StencilMode); StencilMode_LastFrame = StencilMode; }

        if (StencilID != StencilID_LastFrame)
        { uiMaterial.SetFloat(StencilID_ID, StencilID); StencilID_LastFrame = StencilID; }

        if (UseDiffuseMask)
        {
            if (DiffuseMaskTexTiling != DiffuseMaskTexTiling_LastFrame)
            { uiMaterial.SetTextureScale(DiffuseMaskTex_ID, DiffuseMaskTexTiling); DiffuseMaskTexTiling_LastFrame = DiffuseMaskTexTiling; }
            if (DiffuseMaskTexOffset != DiffuseMaskTexOffset_LastFrame)
            { uiMaterial.SetTextureOffset(DiffuseMaskTex_ID, DiffuseMaskTexOffset); DiffuseMaskTexOffset_LastFrame = DiffuseMaskTexOffset; }
            if (DiffuseMaskMaskTexTiling != DiffuseMaskMaskTexTiling_LastFrame)
            { uiMaterial.SetTextureScale(DiffuseMaskMaskTex_ID, DiffuseMaskMaskTexTiling); DiffuseMaskMaskTexTiling_LastFrame = DiffuseMaskMaskTexTiling; }
            if (DiffuseMaskMaskTexOffset != DiffuseMaskMaskTexOffset_LastFrame)
            { uiMaterial.SetTextureOffset(DiffuseMaskMaskTex_ID, DiffuseMaskMaskTexOffset); DiffuseMaskMaskTexOffset_LastFrame = DiffuseMaskMaskTexOffset; }
            if (DiffuseMaskRo != DiffuseMaskRo_LastFrame)
            { uiMaterial.SetFloat(DiffuseMaskRo_ID, DiffuseMaskRo ? 1f : 0f); DiffuseMaskRo_LastFrame = DiffuseMaskRo; }
            if (DiffuseMaskAng != DiffuseMaskAng_LastFrame)
            { uiMaterial.SetFloat(DiffuseMaskAng_ID, DiffuseMaskAng); DiffuseMaskAng_LastFrame = DiffuseMaskAng; }
            if (DiffuseMaskUspeed != DiffuseMaskUspeed_LastFrame)
            { uiMaterial.SetFloat(DiffuseMaskUspeed_ID, DiffuseMaskUspeed); DiffuseMaskUspeed_LastFrame = DiffuseMaskUspeed; }
            if (DiffuseMaskVspeed != DiffuseMaskVspeed_LastFrame)
            { uiMaterial.SetFloat(DiffuseMaskVspeed_ID, DiffuseMaskVspeed); DiffuseMaskVspeed_LastFrame = DiffuseMaskVspeed; }
        }

        if (UseDissolveBlock)
        {
            if (DissolveTexTiling != DissolveTexTiling_LastFrame)
            { uiMaterial.SetTextureScale(DissolveTex_ID, DissolveTexTiling); DissolveTexTiling_LastFrame = DissolveTexTiling; }
            if (DissolveTexOffset != DissolveTexOffset_LastFrame)
            { uiMaterial.SetTextureOffset(DissolveTex_ID, DissolveTexOffset); DissolveTexOffset_LastFrame = DissolveTexOffset; }
            if (EdgeColor != EdgeColor_LastFrame)
            { uiMaterial.SetColor(EdgeColor_ID, EdgeColor); EdgeColor_LastFrame = EdgeColor; }
            if (DissolveProgress != DissolveProgress_LastFrame)
            { uiMaterial.SetFloat(DissolveProgress_ID, DissolveProgress); DissolveProgress_LastFrame = DissolveProgress; }
            if (EdgeWidth != EdgeWidth_LastFrame)
            { uiMaterial.SetFloat(EdgeWidth_ID, EdgeWidth); EdgeWidth_LastFrame = EdgeWidth; }
            if (DissolveUspeed != DissolveUspeed_LastFrame)
            { uiMaterial.SetFloat(DissolveUspeed_ID, DissolveUspeed); DissolveUspeed_LastFrame = DissolveUspeed; }
            if (DissolveVspeed != DissolveVspeed_LastFrame)
            { uiMaterial.SetFloat(DissolveVspeed_ID, DissolveVspeed); DissolveVspeed_LastFrame = DissolveVspeed; }
        }

        if (UseDistortBlock)
        {
            if (DistortTexTiling != DistortTexTiling_LastFrame)
            { uiMaterial.SetTextureScale(DistortTex_ID, DistortTexTiling); DistortTexTiling_LastFrame = DistortTexTiling; }
            if (DistortTexOffset != DistortTexOffset_LastFrame)
            { uiMaterial.SetTextureOffset(DistortTex_ID, DistortTexOffset); DistortTexOffset_LastFrame = DistortTexOffset; }
            if (DistortForceX != DistortForceX_LastFrame)
            { uiMaterial.SetFloat(DistortForceX_ID, DistortForceX); DistortForceX_LastFrame = DistortForceX; }
            if (DistortForceY != DistortForceY_LastFrame)
            { uiMaterial.SetFloat(DistortForceY_ID, DistortForceY); DistortForceY_LastFrame = DistortForceY; }
            if (DistortUspeed != DistortUspeed_LastFrame)
            { uiMaterial.SetFloat(DistortUspeed_ID, DistortUspeed); DistortUspeed_LastFrame = DistortUspeed; }
            if (DistortVspeed != DistortVspeed_LastFrame)
            { uiMaterial.SetFloat(DistortVspeed_ID, DistortVspeed); DistortVspeed_LastFrame = DistortVspeed; }
        }

        if (UseDistortMask)
        {
            if (DistortMaskTexTiling != DistortMaskTexTiling_LastFrame)
            { uiMaterial.SetTextureScale(DistortMaskTex_ID, DistortMaskTexTiling); DistortMaskTexTiling_LastFrame = DistortMaskTexTiling; }
            if (DistortMaskTexOffset != DistortMaskTexOffset_LastFrame)
            { uiMaterial.SetTextureOffset(DistortMaskTex_ID, DistortMaskTexOffset); DistortMaskTexOffset_LastFrame = DistortMaskTexOffset; }
        }
    }

    private void RegisterAsLastFrame()
    {
        BlendSet_LastFrame                 = BlendSet;
        AlphaCutout_LastFrame              = AlphaCutout;
        TwoSide_LastFrame                  = TwoSide;
        MainTexTiling_LastFrame            = MainTexTiling;
        MainTexOffset_LastFrame            = MainTexOffset;
        DiffuseRo_LastFrame                = DiffuseRo;
        DiffuseAng_LastFrame               = DiffuseAng;
        HDRColor_LastFrame                 = HDRColor;
        Brightness_LastFrame               = Brightness;
        Uspeed_LastFrame                   = Uspeed;
        Vspeed_LastFrame                   = Vspeed;
        StencilMode_LastFrame              = StencilMode;
        StencilID_LastFrame                = StencilID;
        DiffuseMaskTexTiling_LastFrame     = DiffuseMaskTexTiling;
        DiffuseMaskTexOffset_LastFrame     = DiffuseMaskTexOffset;
        DiffuseMaskMaskTexTiling_LastFrame = DiffuseMaskMaskTexTiling;
        DiffuseMaskMaskTexOffset_LastFrame = DiffuseMaskMaskTexOffset;
        DiffuseMaskRo_LastFrame            = DiffuseMaskRo;
        DiffuseMaskAng_LastFrame           = DiffuseMaskAng;
        DiffuseMaskUspeed_LastFrame        = DiffuseMaskUspeed;
        DiffuseMaskVspeed_LastFrame        = DiffuseMaskVspeed;
        DissolveTexTiling_LastFrame        = DissolveTexTiling;
        DissolveTexOffset_LastFrame        = DissolveTexOffset;
        EdgeColor_LastFrame                = EdgeColor;
        DissolveProgress_LastFrame         = DissolveProgress;
        EdgeWidth_LastFrame                = EdgeWidth;
        DissolveUspeed_LastFrame           = DissolveUspeed;
        DissolveVspeed_LastFrame           = DissolveVspeed;
        DistortTexTiling_LastFrame         = DistortTexTiling;
        DistortTexOffset_LastFrame         = DistortTexOffset;
        DistortForceX_LastFrame            = DistortForceX;
        DistortForceY_LastFrame            = DistortForceY;
        DistortUspeed_LastFrame            = DistortUspeed;
        DistortVspeed_LastFrame            = DistortVspeed;
        DistortMaskTexTiling_LastFrame     = DistortMaskTexTiling;
        DistortMaskTexOffset_LastFrame     = DistortMaskTexOffset;
    }
}
