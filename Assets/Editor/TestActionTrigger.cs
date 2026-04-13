using UnityEngine;

public static class TestActionTrigger
{
    public static void Run()
    {
        var go = GameObject.Find("UICreateRole_Canvas/UICreateRole/imgBG/M_GB");
        if (go == null) { Debug.Log("M_GB not found"); return; }
        var anim = go.GetComponent<Animator>();
        if (anim == null) { Debug.Log("no animator"); return; }

        Debug.Log($"[before] paramCount={anim.parameterCount} ctrl={anim.runtimeAnimatorController?.name}");
        for (int i = 0; i < anim.parameterCount; i++)
        {
            var p = anim.GetParameter(i);
            Debug.Log($"  param[{i}] name={p.name} type={p.type}");
        }

        var stateInfo = anim.GetCurrentAnimatorStateInfo(0);
        Debug.Log($"[before] currentStateHash={stateInfo.fullPathHash} normTime={stateInfo.normalizedTime}");

        anim.SetTrigger("action");
        Debug.Log("SetTrigger(action) fired");

        // Force-update Animator one tick so we can see the state change immediately.
        anim.Update(0.016f);
        var after = anim.GetCurrentAnimatorStateInfo(0);
        Debug.Log($"[after] currentStateHash={after.fullPathHash} normTime={after.normalizedTime}");
    }
}
