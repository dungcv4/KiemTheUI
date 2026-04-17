using UnityEngine;
using UnityEditor;
using System.Text;

// Refresh AssetDatabase so the edited F_EM.prefab is reimported, then
// re-spawn F_EM under SelectRole's Character container to verify the
// new sizeDelta=(352,446) is picked up from the prefab itself.
public static class _RefreshAndRespawnEM
{
    public static string Execute()
    {
        var sb = new StringBuilder();
        AssetDatabase.Refresh();

        Transform charT = null;
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
            if (t.name == "Character" && t.parent != null && t.parent.name == "UILoginBG") { charT = t; break; }
        if (charT == null) { sb.AppendLine("Character NOT FOUND"); Debug.Log(sb.ToString()); return sb.ToString(); }

        for (int i = charT.childCount - 1; i >= 0; i--)
            Object.DestroyImmediate(charT.GetChild(i).gameObject);

        var prefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/game/ui/loginbg/F_EM.prefab");
        if (prefab == null) { sb.AppendLine("prefab NULL"); Debug.Log(sb.ToString()); return sb.ToString(); }

        var inst = (GameObject)PrefabUtility.InstantiatePrefab(prefab, charT);
        inst.name = "F_EM";
        inst.SetActive(true);

        var rt = inst.GetComponent<RectTransform>();
        if (rt != null) rt.anchoredPosition = new Vector2(77, -305);

        foreach (var img in inst.GetComponentsInChildren<UnityEngine.UI.Image>(true))
            img.useSpriteMesh = true;

        // Mirror the runtime fix in SelectRoleRuntimeBridge: force animator
        // to first frame, then shrink RectTransform to the sprite's rect.
        var anim = inst.GetComponent<Animator>();
        if (anim != null && anim.runtimeAnimatorController != null)
            anim.Update(0f);
        var rootImg = inst.GetComponent<UnityEngine.UI.Image>();
        if (rootImg != null && rootImg.sprite != null && rt != null)
        {
            Vector2 spriteSize = rootImg.sprite.rect.size;
            if (spriteSize.x > 0 && spriteSize.y > 0
                && (spriteSize.x < rt.sizeDelta.x * 0.85f
                 || spriteSize.y < rt.sizeDelta.y * 0.85f))
            {
                rt.sizeDelta = spriteSize;
            }
        }

        sb.AppendLine($"Respawned F_EM");
        sb.AppendLine($"  sizeDelta={rt.sizeDelta}  anchoredPos={rt.anchoredPosition}  pivot={rt.pivot}");
        if (rootImg != null && rootImg.sprite != null)
            sb.AppendLine($"  sprite={rootImg.sprite.name} rect={rootImg.sprite.rect}");
        Debug.Log(sb.ToString());
        return sb.ToString();
    }
}
