// TestSelectFactions
// ==================
// Iterates through several factions and verifies the avatar host contains BOTH
// male and female prefabs after each Apply() (PlayDuo behavior).

using UnityEngine;

public static class TestSelectFactions
{
    public static void Execute()
    {
        int[] testFids = { 1, 2, 5, 7, 14, 20 }; // shaolin (M-only), tianwang, emei (F-only), gaibang, badao, wuhuntang
        foreach (int fid in testFids)
        {
            UICreateRoleAvatarController.Apply(fid, 1, forceAction: true);
            var hostT = GameObject.Find("UICreateRole_Canvas/UICreateRole/imgBG/CharacterPortrait/_AvatarHost");
            string children = "<none>";
            if (hostT != null)
            {
                var names = new string[hostT.transform.childCount];
                for (int i = 0; i < hostT.transform.childCount; i++)
                    names[i] = hostT.transform.GetChild(i).name;
                children = string.Join(",", names);
            }
            Debug.Log($"[TestDuo] fid={fid,2} → [{children}]");
        }
    }
}
