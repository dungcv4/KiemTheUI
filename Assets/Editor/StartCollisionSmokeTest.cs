using UnityEngine;
using KTO.Game;

public static class StartCollisionSmokeTest
{
    // Attaches a CollisionSmokeTestDriver to the first PlayerAssembler
    // found in any loaded scene, with a configured direction + frame count.
    //
    // Usage (pass JSON args via MCP):
    //   { "dir_x": -1, "dir_y": 0, "frames": 90, "label": "push_west" }
    //
    // After the driver finishes, it logs the total position delta.
    // Read the results from the Unity console after ~1.5 seconds of play.
    public static void Execute()
    {
        // Default: push due west 90 frames (~1.5s at 60fps ≈ 6.75 u desired).
        Run(-1f, 0f, 90, "push_west");
    }

    public static void PushWest()    => Run(-1f, 0f, 90, "push_west");
    public static void PushEast()    => Run(+1f, 0f, 90, "push_east");
    public static void PushNorth()   => Run(0f, +1f, 90, "push_north");
    public static void PushSouth()   => Run(0f, -1f, 90, "push_south");
    public static void PushNW()      => Run(-1f, +1f, 90, "push_nw");
    public static void PushNE()      => Run(+1f, +1f, 90, "push_ne");
    public static void PushSW()      => Run(-1f, -1f, 90, "push_sw");
    public static void PushSE()      => Run(+1f, -1f, 90, "push_se");

    /// <summary>Warp the player to a known position for a clean test start.</summary>
    public static void WarpToCourtyard()  => WarpTo(44f, 31f);
    public static void WarpToSpawn()      => WarpTo(43.52f, 25.68f);

    static void WarpTo(float x, float y)
    {
        var players = Object.FindObjectsOfType<PlayerAssembler>();
        if (players == null || players.Length == 0)
        {
            Debug.LogError("[StartCollisionSmokeTest] no PlayerAssembler in scene");
            return;
        }
        var go = players[0].gameObject;
        var t = go.transform;
        t.position = new Vector3(x, y, t.position.z);
        Debug.Log($"[StartCollisionSmokeTest] warped {go.name} to ({x},{y})");
    }

    static void Run(float dx, float dy, int frames, string label)
    {
        var players = Object.FindObjectsOfType<PlayerAssembler>();
        if (players == null || players.Length == 0)
        {
            Debug.LogError("[StartCollisionSmokeTest] no PlayerAssembler in scene");
            return;
        }
        var go = players[0].gameObject;
        // Remove any previous driver so we don't compound motion from a
        // prior test that didn't finish before we started this one.
        foreach (var old in go.GetComponents<CollisionSmokeTestDriver>())
        {
            Object.Destroy(old);
        }
        var drv = go.AddComponent<CollisionSmokeTestDriver>();
        drv.Direction = new Vector2(dx, dy);
        drv.MaxFrames = frames;
        drv.Label = label;
        drv.VerboseFirstNFrames = 8;
        Debug.Log($"[StartCollisionSmokeTest] attached driver to {go.name}  " +
                  $"dir=({dx},{dy})  frames={frames}  label={label}");
    }
}
