using UnityEditor;
using UnityEngine;
using KTO.Game;

public static class TestWalkAnimation
{
    public static void Execute()
    {
        var go = GameObject.Find("Player_ma_000a_free");
        if (go == null) { Debug.LogError("Player not found"); return; }
        var pa = go.GetComponent<PlayerAssembler>();
        if (pa == null) { Debug.LogError("PlayerAssembler not found"); return; }

        // Disable the input controller so it doesn't revert our action each frame
        var ic = go.GetComponent<PlayerInputController>();
        if (ic != null) ic.enabled = false;

        string[] names = { "Bottom(0)", "LB(32)", "L(64)", "LT(96)", "Top(128)", "RT(160)", "R(192)", "RB(224)" };
        Debug.Log($"[TestWalk2] initial CurAct={pa.CurrentAction} CurDir={pa.CurrentLogicDir} CurFrame={pa.CurrentFrame}");
        for (int i = 0; i < 8; i++)
        {
            pa.SetAction(NpcAction.FightRun);
            pa.SetLogicDir(i * 32);
            Debug.Log($"[TestWalk2] after set: CurAct={pa.CurrentAction} CurDir={pa.CurrentLogicDir} CurFrame={pa.CurrentFrame}");
            foreach (Transform c in go.transform)
            {
                var sr = c.GetComponent<SpriteRenderer>();
                if (sr != null && sr.sprite != null && c.name == "body")
                    Debug.Log($"[TestWalk2] {names[i]}: body={sr.sprite.name} flipX={sr.flipX}");
            }
        }

        pa.SetAction(NpcAction.FightStand);
        pa.SetLogicDir(0);
        if (ic != null) ic.enabled = true;
    }
}
