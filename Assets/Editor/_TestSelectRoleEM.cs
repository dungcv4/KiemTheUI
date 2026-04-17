using UnityEngine;
using UnityEditor;
using System.Text;

// Switch to SelectRole panel and spawn F_EM (mirrors what
// SelectRoleRuntimeBridge.ShowCharacter does for a faction-5 female role).
// Uses the SAME prefab path (Assets/game/ui/loginbg/F_EM.prefab) and the
// SAME anchoredPosition from CHAR_MID_POS so we can compare SelectRole vs
// CreateRole F_EM rendering side-by-side.
public static class _TestSelectRoleEM
{
    public static string Execute()
    {
        var sb = new StringBuilder();

        // Show SelectRole, hide CreateRole
        Transform selectCanvas = null, createCanvas = null;
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
        {
            if (t.name == "UISelectRoleExist_Canvas") selectCanvas = t;
            else if (t.name == "UICreateRole_Canvas") createCanvas = t;
        }
        if (selectCanvas != null) selectCanvas.gameObject.SetActive(true);
        if (createCanvas != null) createCanvas.gameObject.SetActive(false);

        // Find Character container
        Transform charT = null;
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
            if (t.name == "Character" && t.parent != null && t.parent.name == "UILoginBG") { charT = t; break; }
        if (charT == null) { sb.AppendLine("Character NOT FOUND"); Debug.Log(sb.ToString()); return sb.ToString(); }

        // DELETE all existing children so only F_EM remains visible
        for (int i = charT.childCount - 1; i >= 0; i--)
            Object.DestroyImmediate(charT.GetChild(i).gameObject);

        // Spawn F_EM exactly like SelectRoleRuntimeBridge does
        var prefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/game/ui/loginbg/F_EM.prefab");
        if (prefab == null) { sb.AppendLine("F_EM prefab NOT FOUND"); Debug.Log(sb.ToString()); return sb.ToString(); }

        var inst = (GameObject)PrefabUtility.InstantiatePrefab(prefab, charT);
        inst.name = "F_EM";
        inst.SetActive(true);

        // Apply CHAR_MID_POS for F_EM = (77, -305)
        var rt = inst.GetComponent<RectTransform>();
        if (rt != null) rt.anchoredPosition = new Vector2(77, -305);

        // Apply useSpriteMesh (mirrors SelectRoleRuntimeBridge.ShowCharacter)
        foreach (var img in inst.GetComponentsInChildren<UnityEngine.UI.Image>(true))
            img.useSpriteMesh = true;

        // Dump the visible state
        var rt2 = inst.GetComponent<RectTransform>();
        var img2 = inst.GetComponent<UnityEngine.UI.Image>();
        sb.AppendLine($"SelectRole F_EM spawned");
        sb.AppendLine($"  parent={inst.transform.parent.name}");
        sb.AppendLine($"  anchoredPos={rt2.anchoredPosition} sizeDelta={rt2.sizeDelta} pivot={rt2.pivot}");
        if (img2 != null && img2.sprite != null)
            sb.AppendLine($"  sprite={img2.sprite.name} rect={img2.sprite.rect} type={img2.type} preserveAspect={img2.preserveAspect} useMesh={img2.useSpriteMesh}");
        else
            sb.AppendLine("  sprite=NULL (broken reference!)");

        Debug.Log(sb.ToString());
        return sb.ToString();
    }
}
