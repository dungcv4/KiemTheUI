using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Cycles a UI Image through an array of sprites at a fixed FPS to produce
/// the standing-idle animation used by character previews on CreateRoleScene.
/// </summary>
[RequireComponent(typeof(Image))]
public class CharStandAnim : MonoBehaviour
{
    public Sprite[] frames;
    public float fps = 12f;

    Image _img;
    float _t;
    int _i;

    void Awake() { _img = GetComponent<Image>(); }

    void Update()
    {
        if (frames == null || frames.Length == 0) return;
        _t += Time.deltaTime;
        float frameDur = 1f / Mathf.Max(0.01f, fps);
        if (_t >= frameDur)
        {
            _t -= frameDur;
            _i = (_i + 1) % frames.Length;
            _img.sprite = frames[_i];
        }
    }
}
