using UnityEngine;
using KTO.Game;

/// <summary>
/// Editor harness for <see cref="WalkSpeedTimingDriver"/>.
///
/// Warps the player to a wide-open courtyard, then fires a timing run in
/// each cardinal direction. Reads the results from the Unity console after
/// ~12 seconds per run (hard wall-clock cap in the driver).
///
/// The courtyard coordinate (44, 31) was identified during Phase 6.3
/// smoke-test calibration as a wide-open area north of spawn with no walls
/// in at least a 3-world-unit radius on all cardinal axes.
/// </summary>
public static class StartWalkSpeedTiming
{
    public static void Execute()     => TimingEast();  // default

    public static void TimingEast()  => Run(+1f, 0f, 180, "timing_east");
    public static void TimingWest()  => Run(-1f, 0f, 180, "timing_west");
    public static void TimingNorth() => Run(0f, +1f, 180, "timing_north");
    public static void TimingSouth() => Run(0f, -1f, 180, "timing_south");

    /// <summary>
    /// Warp to the known-open courtyard spot that Phase 6 used for
    /// unobstructed walk-speed checks. Direct cross-reference:
    /// <c>StartCollisionSmokeTest.WarpToCourtyard()</c> uses the same (44, 31).
    /// </summary>
    public static void WarpToCourtyard() => WarpTo(44f, 31f);

    static void WarpTo(float x, float y)
    {
        var players = Object.FindObjectsOfType<PlayerAssembler>();
        if (players == null || players.Length == 0)
        {
            Debug.LogError("[StartWalkSpeedTiming] no PlayerAssembler in scene");
            return;
        }
        var go = players[0].gameObject;
        var t = go.transform;
        t.position = new Vector3(x, y, t.position.z);
        Debug.Log($"[StartWalkSpeedTiming] warped {go.name} to ({x},{y})");
    }

    static void Run(float dx, float dy, int frames, string label)
    {
        var players = Object.FindObjectsOfType<PlayerAssembler>();
        if (players == null || players.Length == 0)
        {
            Debug.LogError("[StartWalkSpeedTiming] no PlayerAssembler in scene");
            return;
        }
        var go = players[0].gameObject;
        // Remove any previous timing driver + any smoke driver that might
        // still be attached — they compete for motor state.
        foreach (var old in go.GetComponents<WalkSpeedTimingDriver>())
            Object.Destroy(old);
        foreach (var old in go.GetComponents<CollisionSmokeTestDriver>())
            Object.Destroy(old);

        var drv = go.AddComponent<WalkSpeedTimingDriver>();
        drv.Direction = new Vector2(dx, dy);
        drv.Frames = frames;
        drv.Label = label;
        Debug.Log($"[StartWalkSpeedTiming] attached  dir=({dx},{dy})  " +
                  $"frames={frames}  label={label}");
    }
}
