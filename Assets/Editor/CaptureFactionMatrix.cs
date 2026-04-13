// CaptureFactionMatrix
// ====================
// Iterates through several factions, applies each, and dumps the resulting
// avatar host children + their RectTransform anchoredPosition / sizeDelta.
// Used to diagnose per-faction position misalignment in UICreateRole.

using UnityEngine;

public static class CaptureFactionMatrix
{
    public static void Execute()
    {
        int[] testFids = { 1, 2, 5, 7, 9, 14, 17, 19, 20 };
        var hostGO = GameObject.Find("UICreateRole_Canvas/UICreateRole/imgBG/CharacterPortrait/_AvatarHost");
        if (hostGO == null) { Debug.LogError("[Matrix] no host"); return; }
        var hostT = hostGO.transform;
        var portraitRT = hostT.parent as RectTransform;
        var hostRT = hostT as RectTransform;
        Debug.Log($"[Matrix] CharacterPortrait size={portraitRT.rect.size} hostPos={hostRT.anchoredPosition} hostSize={hostRT.sizeDelta} hostAnchorMin={hostRT.anchorMin} hostAnchorMax={hostRT.anchorMax} hostPivot={hostRT.pivot}");
        foreach (int fid in testFids)
        {
            UICreateRoleAvatarController.Apply(fid, 1, forceAction: false);
            for (int i = 0; i < hostT.childCount; i++)
            {
                var c = hostT.GetChild(i) as RectTransform;
                Debug.Log($"[Matrix] fid={fid,2} {c.name,-6} pos={c.anchoredPosition} size={c.sizeDelta} pivot={c.pivot} aMin={c.anchorMin} aMax={c.anchorMax}");
            }
        }
    }
}
