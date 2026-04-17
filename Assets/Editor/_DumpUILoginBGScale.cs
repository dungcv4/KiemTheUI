using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.Text;

// Reports runtime scale + transform state for UILoginBG and its Character/M_SL
// chain to diagnose why M_SL doesn't appear visually even though it's active
// in the hierarchy.
public static class _DumpUILoginBGScale
{
    public static string Execute()
    {
        var sb = new StringBuilder();
        sb.AppendLine("=== UILoginBG scale dump ===");

        GameObject bg = null;
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
        {
            if (t.name == "UILoginBG" && t.parent == null) { bg = t.gameObject; break; }
        }
        if (bg == null) { sb.AppendLine("UILoginBG NOT FOUND"); Debug.Log(sb.ToString()); return sb.ToString(); }
        sb.AppendLine($"UILoginBG found via FindObjectsOfType (includeInactive)");

        var bgRt = bg.transform as RectTransform;
        sb.AppendLine($"UILoginBG localScale={bg.transform.localScale} lossyScale={bg.transform.lossyScale} active={bg.activeInHierarchy}");
        if (bgRt != null) sb.AppendLine($"  RT anchoredPosition={bgRt.anchoredPosition} sizeDelta={bgRt.sizeDelta} pivot={bgRt.pivot}");

        var bgCanvas = bg.GetComponent<Canvas>();
        if (bgCanvas != null)
            sb.AppendLine($"  Canvas mode={bgCanvas.renderMode} order={bgCanvas.sortingOrder} cam={bgCanvas.worldCamera?.name ?? "<null>"}");

        var character = bg.transform.Find("Character");
        if (character != null)
        {
            var cRt = character as RectTransform;
            sb.AppendLine($"  Character localScale={character.localScale} lossyScale={character.lossyScale} active={character.gameObject.activeInHierarchy}");
            if (cRt != null) sb.AppendLine($"    RT anchoredPosition={cRt.anchoredPosition} sizeDelta={cRt.sizeDelta} pivot={cRt.pivot}");
            var cCanvas = character.GetComponent<Canvas>();
            if (cCanvas != null)
                sb.AppendLine($"    Canvas mode={cCanvas.renderMode} order={cCanvas.sortingOrder} overrideSort={cCanvas.overrideSorting}");

            for (int i = 0; i < character.childCount; i++)
            {
                var avatar = character.GetChild(i);
                var aRt = avatar as RectTransform;
                sb.AppendLine($"    [{i}] {avatar.name} localScale={avatar.localScale} lossyScale={avatar.lossyScale} active={avatar.gameObject.activeInHierarchy}");
                if (aRt != null) sb.AppendLine($"      RT anchoredPosition={aRt.anchoredPosition} sizeDelta={aRt.sizeDelta} pivot={aRt.pivot}");

                // Check Image children
                int imgCount = 0;
                int withSprite = 0;
                foreach (var img in avatar.GetComponentsInChildren<Image>(true))
                {
                    imgCount++;
                    if (img.sprite != null) withSprite++;
                }
                sb.AppendLine($"      Images: {imgCount} (with sprite: {withSprite})");
            }
        }

        Debug.Log(sb.ToString());
        return sb.ToString();
    }
}
