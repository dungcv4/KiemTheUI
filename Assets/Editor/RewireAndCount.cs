using UnityEngine;

public static class RewireAndCount
{
    public static void Run()
    {
        SelectRoleSceneNav.Wire();

        int loginbg = 0, vfx = 0;
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
        {
            if (t == null) continue;
            if (t.name == "UILoginBG") loginbg++;
            else if (t.name == "UILoginBG_VFX") vfx++;
        }
        Debug.Log($"[RewireAndCount] after Wire: UILoginBG={loginbg} UILoginBG_VFX={vfx}");
    }
}
