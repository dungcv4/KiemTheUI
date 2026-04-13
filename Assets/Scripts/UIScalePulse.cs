using UnityEngine;
using UnityEngine.EventSystems;

// Mirrors the KTO UIAnimScaleUp / UIAnimScaleDown MonoBehaviours from the
// original Tuanjie bundle. Plays a single shrink/grow tween on pointer down
// and reverses on pointer up so the button gives the same press feedback as
// the source build.
[DisallowMultipleComponent]
public class UIScalePulse : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public float upScale = 1.1f;     // peak scale (UpToScale on the source MB)
    public float duration = 0.1f;    // tween length in seconds (AnimTime)
    public bool scaleUp = true;      // true = grow on press, false = shrink

    Vector3 _baseScale;
    float _t;
    int _dir;

    void Awake() { _baseScale = transform.localScale; }

    public void OnPointerDown(PointerEventData _) { _dir = 1; _t = 0f; enabled = true; }
    public void OnPointerUp(PointerEventData _)   { _dir = -1; enabled = true; }

    void Update()
    {
        if (_dir == 0) return;
        _t += Time.unscaledDeltaTime * (1f / Mathf.Max(0.0001f, duration));
        float k = Mathf.Clamp01(_t);
        float target = scaleUp ? upScale : (2f - upScale);
        float s = _dir > 0 ? Mathf.Lerp(1f, target, k) : Mathf.Lerp(target, 1f, k);
        transform.localScale = _baseScale * s;
        if (k >= 1f)
        {
            if (_dir < 0) { transform.localScale = _baseScale; _dir = 0; enabled = false; }
            else { _dir = 0; }
            _t = 0f;
        }
    }
}
