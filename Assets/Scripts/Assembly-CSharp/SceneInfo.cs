using UnityEngine;

public class SceneInfo : MonoBehaviour
{
	[System.Serializable]
	public struct Rect { public int Left; public int Top; public int Right; public int Bottom; }

	public bool DrawAllRepresentArea = true;
	public bool DrawAllRepresentRegion = true;
	public bool DrawCurPlayerArea = true;
	public bool DrawCurRegion = false;
	public bool DrawCurArea = true;
	public bool DrawCurAreaCell = false;
	public bool DrawCurRepresentArea = true;
	public bool DrawObstacle = false;
	public bool DrawTrap = false;
	public bool DrawDynObst = false;
	public Rect MapRect;
}
