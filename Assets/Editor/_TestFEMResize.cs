using UnityEngine;
using System.Text;

// Quick experiment: shrink the live F_EM RectTransform to the sprite's
// trimmed atlas rect (~352x446) to verify the visual size is fixed by
// adjusting sizeDelta rather than swapping sprites.
public static class _TestFEMResize
{
    public static string Execute()
    {
        var sb = new StringBuilder();
        Transform fem = null;
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
            if (t.name == "F_EM" && t.gameObject.activeInHierarchy) { fem = t; break; }
        if (fem == null) { sb.AppendLine("F_EM NOT FOUND"); Debug.Log(sb.ToString()); return sb.ToString(); }

        var rt = fem as RectTransform;
        sb.AppendLine($"BEFORE: sizeDelta={rt.sizeDelta}");

        // Match M_SL ratio more closely: M_SL is 448x512.
        // F_EM sprite native rect is ~352x446 (0.789 aspect).
        // Use 352x446 (true native trimmed size).
        rt.sizeDelta = new Vector2(352, 446);

        sb.AppendLine($"AFTER:  sizeDelta={rt.sizeDelta}");

        var img = fem.GetComponent<UnityEngine.UI.Image>();
        if (img != null)
        {
            img.SetAllDirty();
            if (img.sprite != null)
                sb.AppendLine($"sprite={img.sprite.name} rect={img.sprite.rect} useMesh={img.useSpriteMesh}");
        }

        Debug.Log(sb.ToString());
        return sb.ToString();
    }
}
