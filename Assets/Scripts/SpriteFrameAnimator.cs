using UnityEngine;
using UnityEngine.UI;

// Cycles through an array of Sprites at a fixed FPS.
// Supports both UI Image (CanvasRenderer) and SpriteRenderer targets.
// When the avatar is inside an SSC canvas alongside VFX particles, it uses
// SpriteRenderer for proper sorting with ParticleSystemRenderers.
// When used in SSO canvases (select-role), it uses Image.
public class SpriteFrameAnimator : MonoBehaviour
{
    public Sprite[] frames;
    public Sprite[] actionFrames;
    public float fps = 12f;
    public float actionFps = 24f;
    public bool loop = true;

    Sprite[] _oneShot;
    float _oneShotFps;
    int _oneShotIdx;

    Image _img;
    SpriteRenderer _sr;
    float _t;
    int _idx;

    void Awake() { CacheRenderer(); }

    void CacheRenderer()
    {
        if (_sr == null) _sr = GetComponent<SpriteRenderer>();
        if (_img == null) _img = GetComponent<Image>();
    }

    void SetSprite(Sprite s)
    {
        if (_sr != null) _sr.sprite = s;
        else if (_img != null) _img.sprite = s;
    }

    public void SetFrames(Sprite[] newFrames)
    {
        frames = newFrames;
        _idx = 0;
        _t = 0;
        _oneShot = null;
        CacheRenderer();
        if (frames != null && frames.Length > 0)
            SetSprite(frames[0]);
    }

    public void PlayOneShot(Sprite[] action, float actionFps)
    {
        if (action == null || action.Length == 0) return;
        _oneShot = action;
        _oneShotFps = Mathf.Max(0.0001f, actionFps);
        _oneShotIdx = 0;
        _t = 0;
        CacheRenderer();
        SetSprite(_oneShot[0]);
    }

    /// <summary>
    /// Called by UICreateRoleAvatarController after swapping Image → SpriteRenderer
    /// so the animator targets the new renderer.
    /// </summary>
    public void RefreshRenderer()
    {
        _img = null;
        _sr = null;
        CacheRenderer();
    }

    void Update()
    {
        if (_oneShot != null)
        {
            _t += Time.deltaTime;
            float dur = 1f / _oneShotFps;
            while (_t >= dur)
            {
                _t -= dur;
                _oneShotIdx++;
                if (_oneShotIdx >= _oneShot.Length)
                {
                    _oneShot = null;
                    _idx = 0;
                    if (frames != null && frames.Length > 0)
                        SetSprite(frames[0]);
                    return;
                }
                SetSprite(_oneShot[_oneShotIdx]);
            }
            return;
        }

        if (frames == null || frames.Length == 0) return;
        _t += Time.deltaTime;
        float frameDuration = 1f / Mathf.Max(0.0001f, fps);
        while (_t >= frameDuration)
        {
            _t -= frameDuration;
            _idx++;
            if (_idx >= frames.Length)
            {
                if (loop) _idx = 0;
                else { _idx = frames.Length - 1; return; }
            }
            SetSprite(frames[_idx]);
        }
    }
}
