// TestAllFactions
// ===============
// Walks every Faction_<key> child of FactionList in playmode, invokes its
// Button.onClick, and reports which avatar prefab landed under
// imgBG/CharacterPortrait/_AvatarHost. Used to verify UICreateRoleAvatarController.

using UnityEngine;
using UnityEngine.UI;

public static class TestAllFactions
{
    static readonly string[] kKeys = {
        "shaolin", "tianwang", "tangmen", "wudu", "emei",
        "cuiyan", "gaibang", "tianren", "wudang", "kunlun",
        "mingjiao", "duanshi", "gumu", "badao", "xiaoyao",
        "baituosha", "taohua", "changge", "YiPinTang", "WuHuntang"
    };

    public static void Execute()
    {
        // Direct controller test: call Apply(factionId, sex) for both genders.
        // Bypasses button click + lua so we verify only the avatar swap path.
        for (int fid = 1; fid <= 20; fid++)
        {
            for (int sex = 1; sex <= 2; sex++)
            {
                UICreateRoleAvatarController.Apply(fid, sex, forceAction: true);
                var hostT = GameObject.Find("UICreateRole_Canvas/UICreateRole/imgBG/CharacterPortrait/_AvatarHost");
                string avatar = hostT != null && hostT.transform.childCount > 0
                    ? hostT.transform.GetChild(0).name
                    : "<none>";
                string sexLabel = sex == 1 ? "M" : "F";
                Debug.Log($"[TestAll] fid={fid,2} sex={sexLabel} → {avatar}");
            }
        }
    }
}
