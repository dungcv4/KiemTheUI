using UnityEngine;

/// <summary>
/// Adjusts a RectTransform to fit within Screen.safeArea.
/// Attach to UI panels that should respect notches / dynamic islands.
/// </summary>
[RequireComponent(typeof(RectTransform))]
public class SafeArea : MonoBehaviour
{
    RectTransform _rt;
    Rect _last;

    void Awake() { _rt = GetComponent<RectTransform>(); Apply(); }
    void Update() { if (Screen.safeArea != _last) Apply(); }

    void Apply()
    {
        var sa = Screen.safeArea;
        _last = sa;
        Vector2 min = sa.position;
        Vector2 max = sa.position + sa.size;
        min.x /= Screen.width;  min.y /= Screen.height;
        max.x /= Screen.width;  max.y /= Screen.height;
        _rt.anchorMin = min;
        _rt.anchorMax = max;
        _rt.offsetMin = Vector2.zero;
        _rt.offsetMax = Vector2.zero;
    }
}
