using UnityEngine;
using KTO.Game;

public static class Phase5VerifyDirs
{
    public static void Execute()
    {
        var cases = new (string label, Vector2 v, int expected)[]
        {
            ("south  (0,-1)",  new Vector2( 0f, -1f),   0),
            ("sw     (-1,-1)", new Vector2(-1f, -1f),  32),
            ("west   (-1,0)",  new Vector2(-1f,  0f),  64),
            ("nw     (-1, 1)", new Vector2(-1f,  1f),  96),
            ("north  ( 0, 1)", new Vector2( 0f,  1f), 128),
            ("ne     ( 1, 1)", new Vector2( 1f,  1f), 160),
            ("east   ( 1, 0)", new Vector2( 1f,  0f), 192),
            ("se     ( 1,-1)", new Vector2( 1f, -1f), 224),
        };

        int fail = 0;
        foreach (var (label, v, expected) in cases)
        {
            int got = Env.UnityMoveToLogicDir(v);
            string mark = (got == expected) ? "OK" : "FAIL";
            if (got != expected) fail++;
            Debug.Log($"[Phase5Verify] {mark} {label} -> {got} (expected {expected})");
        }
        Debug.Log($"[Phase5Verify] Env.GAME_FPS={Env.GAME_FPS} LOGIC_MAX_DIR={Env.LOGIC_MAX_DIR} LOGIC_POS_CELL={Env.LOGIC_POS_CELL}");
        Debug.Log($"[Phase5Verify] Map2Logic(1)={Env.Map2Logic(1)} World2Logic(1f)={Env.World2Logic(1f)} Logic2World(800)={Env.Logic2World(800)}");
        Debug.Log(fail == 0
            ? "[Phase5Verify] SUCCESS: all 8 cardinals match sprite-atlas convention."
            : $"[Phase5Verify] FAILURE: {fail} mismatch(es)");
    }
}
