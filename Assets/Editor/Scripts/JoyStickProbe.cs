using UnityEngine;
using System.Reflection;
using KTO.Game;
using KtoJoy = KTO.Game.UIJoyStick;

public static class JoyStickProbe
{
    public static void Execute()
    {
        Debug.Log($"[Probe] Application.isPlaying={Application.isPlaying}");

        // 1. KTO.Game.UIJoyStick singleton + scene instance
        var jsStatic = KtoJoy.Inst;
        var jsFound  = Object.FindObjectOfType<KtoJoy>(true);
        Debug.Log($"[Probe] UIJoyStick.Inst={(jsStatic!=null?jsStatic.name:"null")}  " +
                  $"FindObjectOfType={(jsFound!=null?jsFound.name+" active="+jsFound.gameObject.activeInHierarchy:"null")}");

        // 2. Operation static state
        var opT = typeof(Operation);
        var motorField = opT.GetField("_motor", BindingFlags.NonPublic | BindingFlags.Static);
        var opMotor = motorField != null ? motorField.GetValue(null) : null;
        Debug.Log($"[Probe] Operation._motor={(opMotor!=null?((PlayerMotor)opMotor).name:"null")}  " +
                  $"nLastGoDir={Operation.nLastGoDir}  bBlock={Operation.bBlock}");

        // 3. Scene player
        var playerGo = GameObject.Find("Player_ma_000a_free");
        if (playerGo == null) { Debug.LogError("[Probe] Player not found"); return; }
        var motor = playerGo.GetComponent<PlayerMotor>();
        Debug.Log($"[Probe] scene motor={(motor!=null?motor.name:"null")}  " +
                  $"CurLogicDir={motor?.CurLogicDir}  RemainingFrames={motor?.RemainingFrames}");

        // 4. Bypass Operation — call motor.GoDirection directly
        if (motor != null)
        {
            var grid = MapObstacleGrid.Instance;
            Debug.Log($"[Probe] grid={(grid!=null?(grid.Loaded?"loaded":"not-loaded"):"null")}");
            var before = playerGo.transform.position;
            Debug.Log($"[Probe] pos before = {before}");
            motor.GoDirection(128, 180);
            motor.StartDirection(128);
            Debug.Log($"[Probe] direct motor.GoDirection(128,180) → CurLogicDir={motor.CurLogicDir} " +
                      $"RemainingFrames={motor.RemainingFrames}");

            var tick = typeof(PlayerMotor).GetMethod("TickOneFrame",
                BindingFlags.NonPublic | BindingFlags.Instance);
            for (int i = 0; i < 6; i++) tick.Invoke(motor, null);
            var after = playerGo.transform.position;
            Debug.Log($"[Probe] direct 6-tick delta = {after - before}");
            motor.StopDirection();
        }
    }
}
