using UnityEngine;
using UnityEditor;

public static class TestSelectRole
{
    [MenuItem("KTO/Test/Login → Select first role")]
    public static void SelectFirstRole()
    {
        var lm = KTO.Network.LoginManager.Instance;
        if (lm == null) { Debug.LogError("[TestSelectRole] LoginManager null"); return; }
        if (lm.Roles.Count == 0) { Debug.LogError("[TestSelectRole] No roles"); return; }

        var role = lm.Roles[0];
        Debug.Log($"[TestSelectRole] Selecting role id={role.RoleID} name={role.RoleName} lv={role.Level}");
        lm.SelectRole(role.RoleID);
    }

    [MenuItem("KTO/Test/Dump player sync state")]
    public static void DumpState()
    {
        Debug.Log($"[State] HP={KTO.Network.PlayerHpMpMgr.Hp} MP={KTO.Network.PlayerHpMpMgr.Mp}");
        var a = KTO.UI.PlayerAttributeMgr.Current;
        Debug.Log($"[State] Level={a.nLevel} Str/Agi/Con/Dex={a.nStr}/{a.nAgi}/{a.nCon}/{a.nDex} " +
                  $"MaxHP={a.nHp} MaxMP={a.nMp} Atk={a.nAttack} FP={a.nFightPower} Faction={a.nFactionId}");
        Debug.Log($"[State] Money Gold={KTO.Game.MoneyMgr.GetMoney(KTO.Game.MoneyMgr.MoneyType.Gold)} " +
                  $"YB={KTO.Game.MoneyMgr.GetMoney(KTO.Game.MoneyMgr.MoneyType.YuanBao)}");
        Debug.Log($"[State] Bag count={KTO.Game.Bag.BagMgr.Count}");
        Debug.Log($"[State] Level.Lvl={KTO.Network.PlayerLevelMgr.Level} Exp={KTO.Network.PlayerLevelMgr.Exp}");
    }
}
