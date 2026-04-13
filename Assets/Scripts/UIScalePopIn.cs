using UnityEngine;

// Tiny editor-friendly scale-bounce tween used by the create-role panel to
// animate the faction title (Võ Đang / Thiếu Lâm / …) when the player picks
// a different sect. Mirrors the original KTO ImageEffectAnimationController
// "pop-in" feel without pulling in the full effect controller stack.
[DisallowMultipleComponent]
public class UIScalePopIn : MonoBehaviour
{
    public float from = 0.6f;
    public float to = 1f;
    public float duration = 0.35f;
    public bool playOnEnable = true;

    Vector3 _baseScale = Vector3.one;
    float _t = -1f;

    void Awake() { _baseScale = transform.localScale; if (_baseScale == Vector3.zero) _baseScale = Vector3.one; }

    void OnEnable() { if (playOnEnable) Play(from, to, duration); }

    public void Play(float from, float to, float duration)
    {
        this.from = from;
        this.to = to;
        this.duration = Mathf.Max(0.01f, duration);
        if (_baseScale == Vector3.zero) _baseScale = Vector3.one;
        _t = 0f;
        transform.localScale = _baseScale * from;
        enabled = true;
    }

    void Update()
    {
        if (_t < 0f) return;
        _t += Time.unscaledDeltaTime;
        float k = Mathf.Clamp01(_t / duration);
        // Ease-out back: overshoot to ~1.12× then settle.
        float eased;
        if (k < 0.7f)
        {
            float u = k / 0.7f;
            eased = Mathf.Lerp(from, to * 1.12f, 1f - (1f - u) * (1f - u));
        }
        else
        {
            float u = (k - 0.7f) / 0.3f;
            eased = Mathf.Lerp(to * 1.12f, to, u);
        }
        transform.localScale = _baseScale * eased;
        if (k >= 1f)
        {
            transform.localScale = _baseScale * to;
            _t = -1f;
            enabled = false;
        }
    }
}
