using UnityEngine;

public class SpriteAnimationLoop : MonoBehaviour
{
	public Sprite[] _Sprites;
	public float _Interval = 0.06f;

	SpriteRenderer _sr;
	int _index;
	float _timer;

	void Awake()
	{
		_sr = GetComponent<SpriteRenderer>();
	}

	void Update()
	{
		if (_Sprites == null || _Sprites.Length == 0 || _sr == null) return;
		_timer += Time.deltaTime;
		if (_timer >= _Interval)
		{
			_timer = 0f;
			_index = (_index + 1) % _Sprites.Length;
			_sr.sprite = _Sprites[_index];
		}
	}
}
