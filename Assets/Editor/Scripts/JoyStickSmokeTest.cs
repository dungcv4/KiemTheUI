using UnityEngine;
using KTO.Game;
using KtoJoy = KTO.Game.UIJoyStick;

public static class JoyStickSmokeTest
{
    // Drives Operation.GoDirection as UIJoyStick.OnMove would, then ticks
    // PlayerMotor a few logic frames and reports the delta. Disables the
    // keyboard input controller first so it doesn't race our calls.
    public static void Execute()
    {
        var playerGo = GameObject.Find("Player_ma_000a_free");
        if (playerGo == null) { Debug.LogError("[Smoke] player not found (game not in play?)"); return; }
        var motor = playerGo.GetComponent<PlayerMotor>();
        if (motor == null) { Debug.LogError("[Smoke] motor missing"); return; }
        var input = playerGo.GetComponent<PlayerInputController>();
        if (input != null) input.enabled = false;

        // Re-register in case a mid-play domain reload wiped Operation._motor.
        // PlayerMotor.Awake already registers on fresh spawn; this is idempotent.
        Operation.RegisterMotor(motor);

        Debug.Log($"[Smoke] KtoJoy.Inst={(KtoJoy.Inst != null ? KtoJoy.Inst.name : "null")} " +
                  $"motorRegistered? callingGoDirection...");

        Vector3 startPos = playerGo.transform.position;
        Debug.Log($"[Smoke] start pos = {startPos}");

        var axes = new[] {
            new { name="W (up)",    axis=new Vector2( 0f,  1f) },
            new { name="D (right)", axis=new Vector2( 1f,  0f) },
            new { name="S (down)",  axis=new Vector2( 0f, -1f) },
            new { name="A (left)",  axis=new Vector2(-1f,  0f) },
        };

        var tick = typeof(PlayerMotor).GetMethod("TickOneFrame",
            System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

        foreach (var a in axes)
        {
            int dir = KtoJoy.GetJoyStickDirByAxis(a.axis);
            // Force a clean re-fire like UIJoyStick.OnMove's dir-change path.
            Operation.ClearLastDir();
            Operation.GoDirection(dir);
            int lastDirAfterGo = Operation.nLastGoDir;
            int curMotorDir    = motor.CurLogicDir;
            int remaining      = motor.RemainingFrames;

            Vector3 before = playerGo.transform.position;
            for (int i = 0; i < 6; i++) tick.Invoke(motor, null);
            Vector3 after = playerGo.transform.position;
            Vector3 delta = after - before;
            Debug.Log($"[Smoke] {a.name}: dir={dir} opLastGoDir={lastDirAfterGo} " +
                      $"motorCurDir={curMotorDir} remainingFrames={remaining} " +
                      $"delta=({delta.x:F3}, {delta.y:F3})");
        }

        Operation.StopGoDir();
        Debug.Log($"[Smoke] after StopGoDir: opLastGoDir={Operation.nLastGoDir} bOnJoyStick={Operation.bOnJoyStick}");

        if (input != null) input.enabled = true;
    }
}
