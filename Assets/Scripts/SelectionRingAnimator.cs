// Animates the SelectionRing glow under the selected character's feet.
// Replicates the original VFX_TY_frame particle animation from UILoginBG:
//
//   GL2 (J_GL_2.png):    RotationModule DISABLED, looping, prewarm → static glow
//   ZZ020_u3 (EX-ZZ-005): SizeModule ENABLED, size 0.114→1.0 over 1s loop → pulse
//   GC24 (J_GC_24.png):  no animation modules → static ring
//
// The combined visual: a golden ring that pulses (scales) in size.
// NO ROTATION — the original RotationModule is disabled (enabled=0).
//
// Since this is a UI Image (not particles), we approximate the size-over-
// lifetime curve with a smooth scale pulse between pulseMin and pulseMax.
// Values are derived from the original ZZ020_u3 SizeModule curve:
//   curve goes from 0.114 → 1.0, but each particle overlaps with the next,
//   so the visual range is narrower (roughly 0.85–1.05 of base size).

using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class SelectionRingAnimator : MonoBehaviour
{
    [Header("Scale Pulse (from ZZ020_u3 SizeModule)")]
    [Tooltip("Pulse cycles per second. Original particle duration: 1s loop")]
    public float pulseFrequency = 1f;

    [Tooltip("Minimum scale. Derived from overlapping particle visual range")]
    public float pulseMin = 0.85f;

    [Tooltip("Maximum scale")]
    public float pulseMax = 1.05f;

    [Header("Alpha Pulse (glow breathing)")]
    [Tooltip("Alpha at pulse trough")]
    public float alphaMin = 0.55f;

    [Tooltip("Alpha at pulse peak")]
    public float alphaMax = 0.85f;

    UnityEngine.UI.Image _img;

    void Start() { _img = GetComponent<UnityEngine.UI.Image>(); }

    void Update()
    {
        if (!Application.isPlaying) return;
        Animate();
    }

#if UNITY_EDITOR
    void OnEnable()
    {
        if (!Application.isPlaying)
        {
            _img = GetComponent<UnityEngine.UI.Image>();
            EditorApplication.update -= EditorTick;
            EditorApplication.update += EditorTick;
        }
    }

    void OnDisable()
    {
        EditorApplication.update -= EditorTick;
    }

    void OnDestroy()
    {
        EditorApplication.update -= EditorTick;
    }

    void EditorTick()
    {
        if (this == null || !gameObject.activeInHierarchy)
        {
            EditorApplication.update -= EditorTick;
            return;
        }
        Animate();
    }
#endif

    void Animate()
    {
        float now = Time.realtimeSinceStartup;

        // Scale pulse (matches ZZ020_u3 size-over-lifetime)
        float t = Mathf.Sin(now * pulseFrequency * Mathf.PI * 2f) * 0.5f + 0.5f;
        float scale = Mathf.Lerp(pulseMin, pulseMax, t);
        transform.localScale = new Vector3(scale, scale, 1f);

        // Alpha breathing (glow intensity variation)
        if (_img == null) _img = GetComponent<UnityEngine.UI.Image>();
        if (_img != null)
        {
            float alpha = Mathf.Lerp(alphaMin, alphaMax, t);
            var c = _img.color;
            if (Mathf.Abs(c.a - alpha) > 0.01f)
                _img.color = new Color(c.r, c.g, c.b, alpha);
        }
    }
}
