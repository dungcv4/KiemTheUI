using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.Text;

public static class _DiagSelectRoleAvatar
{
    public static void Execute()
    {
        var sb = new StringBuilder();
        sb.AppendLine("=== SelectRole avatar diagnostic ===");

        // 1. Find UILoginBG and Character container
        Transform uiLoginBg = null;
        Transform character = null;
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
        {
            if (t.name == "UILoginBG") uiLoginBg = t;
            if (t.name == "Character" && t.parent != null && t.parent.name == "UILoginBG")
                character = t;
        }

        if (uiLoginBg == null) { sb.AppendLine("UILoginBG NOT FOUND"); Debug.Log(sb.ToString()); return; }
        sb.AppendLine($"UILoginBG path: {GetPath(uiLoginBg)} active={uiLoginBg.gameObject.activeInHierarchy}");
        var bgRt = uiLoginBg as RectTransform;
        if (bgRt != null) sb.AppendLine($"  RT pos={bgRt.anchoredPosition} size={bgRt.rect.size} scale={bgRt.localScale}");
        var bgCanvas = uiLoginBg.GetComponent<Canvas>();
        if (bgCanvas != null) sb.AppendLine($"  Canvas renderMode={bgCanvas.renderMode} sortingOrder={bgCanvas.sortingOrder} overrideSorting={bgCanvas.overrideSorting} sortingLayer={bgCanvas.sortingLayerName}");

        if (character == null) { sb.AppendLine("Character NOT FOUND"); Debug.Log(sb.ToString()); return; }
        sb.AppendLine($"Character path: {GetPath(character)} active={character.gameObject.activeInHierarchy}");
        var chRt = character as RectTransform;
        if (chRt != null) sb.AppendLine($"  RT pos={chRt.anchoredPosition} size={chRt.rect.size} scale={chRt.localScale}");
        var chCanvas = character.GetComponent<Canvas>();
        if (chCanvas != null) sb.AppendLine($"  Canvas renderMode={chCanvas.renderMode} sortingOrder={chCanvas.sortingOrder} overrideSorting={chCanvas.overrideSorting} sortingLayer={chCanvas.sortingLayerName}");
        else sb.AppendLine("  NO Canvas component on Character");

        // 2. List all children of Character
        sb.AppendLine($"Character children ({character.childCount}):");
        for (int i = 0; i < character.childCount; i++)
        {
            var c = character.GetChild(i);
            var crt = c as RectTransform;
            sb.AppendLine($"  [{i}] {c.name} active={c.gameObject.activeInHierarchy} pos={(crt != null ? crt.anchoredPosition.ToString() : "n/a")} size={(crt != null ? crt.rect.size.ToString() : "n/a")} scale={c.localScale}");
            // List Image components
            var imgs = c.GetComponentsInChildren<Image>(true);
            sb.AppendLine($"    Image children: {imgs.Length}");
            for (int j = 0; j < System.Math.Min(imgs.Length, 8); j++)
            {
                var img = imgs[j];
                var irt = img.transform as RectTransform;
                sb.AppendLine($"      - {img.name} enabled={img.enabled} sprite={(img.sprite != null ? img.sprite.name : "NULL")} color={img.color} alpha={img.color.a} size={(irt != null ? irt.rect.size.ToString() : "n/a")} active={img.gameObject.activeInHierarchy}");
            }
        }

        // 3. Find the parent canvas chain
        sb.AppendLine("Parent chain from Character:");
        Transform p = character;
        while (p != null)
        {
            var prt = p as RectTransform;
            var pCanvas = p.GetComponent<Canvas>();
            sb.AppendLine($"  {p.name} active={p.gameObject.activeInHierarchy} scale={p.localScale} canvas={(pCanvas != null ? "renderMode="+pCanvas.renderMode+" order="+pCanvas.sortingOrder : "none")}");
            p = p.parent;
        }

        // 4. List all MonoBehaviour components on UILoginBG
        sb.AppendLine($"\nUILoginBG components:");
        foreach (var c in uiLoginBg.GetComponents<Component>())
        {
            if (c == null) sb.AppendLine($"  - <missing script>");
            else sb.AppendLine($"  - {c.GetType().Name}");
        }
        // Also list children of UILoginBG
        sb.AppendLine($"\nUILoginBG children ({uiLoginBg.childCount}):");
        for (int i = 0; i < uiLoginBg.childCount; i++)
        {
            var c = uiLoginBg.GetChild(i);
            sb.AppendLine($"  [{i}] {c.name} active={c.gameObject.activeInHierarchy} scale={c.localScale}");
        }

        Debug.Log(sb.ToString());
    }

    private static string GetPath(Transform t)
    {
        if (t == null) return "<null>";
        var path = t.name;
        var p = t.parent;
        while (p != null) { path = p.name + "/" + path; p = p.parent; }
        return path;
    }
}
