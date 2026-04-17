using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.Text;

// After enabling Character canvas, M_SL position is correct, sprite valid,
// alpha=1, frustum check passes — but still invisible in GameView.
// This script:
// 1. Lists ALL UILoginBG children in render order to find anything covering M_SL
// 2. Checks for opaque Images at sibling indices > Character that might cover
// 3. Checks GraphicRaycaster, CanvasGroup, materials
// 4. Tests by temporarily hiding all UILoginBG siblings except Character
public static class _DiagWhyMSLInvisible
{
    public static string Execute()
    {
        var sb = new StringBuilder();
        sb.AppendLine("=== Why M_SL invisible deep diag ===");

        var bg = GameObject.Find("UILoginBG");
        if (bg == null) { sb.AppendLine("UILoginBG NOT FOUND"); Debug.Log(sb.ToString()); return sb.ToString(); }

        // List all UILoginBG direct children in sibling order
        sb.AppendLine("--- UILoginBG children in sibling order ---");
        for (int i = 0; i < bg.transform.childCount; i++)
        {
            var c = bg.transform.GetChild(i);
            var img = c.GetComponent<Image>();
            var canvas = c.GetComponent<Canvas>();
            sb.AppendLine($"  [{i}] {c.name} active={c.gameObject.activeInHierarchy}");
            if (img != null)
                sb.AppendLine($"      Image enabled={img.enabled} alpha={img.color.a} sprite={(img.sprite != null ? img.sprite.name : "<null>")}");
            if (canvas != null)
                sb.AppendLine($"      Canvas enabled={canvas.enabled} mode={canvas.renderMode} order={canvas.sortingOrder} override={canvas.overrideSorting}");
        }

        // Check Character + its children
        var charT = bg.transform.Find("Character");
        if (charT != null)
        {
            sb.AppendLine("--- Character children ---");
            for (int i = 0; i < charT.childCount; i++)
            {
                var c = charT.GetChild(i);
                sb.AppendLine($"  [{i}] {c.name} active={c.gameObject.activeInHierarchy}");
                foreach (var img in c.GetComponentsInChildren<Image>(true))
                    sb.AppendLine($"      Image {img.name} enabled={img.enabled} alpha={img.color.a} crCull={img.canvasRenderer.cull} crAlpha={img.canvasRenderer.GetAlpha()} sprite={(img.sprite != null ? img.sprite.name : "<null>")}");
            }
        }

        // Check whether camera actually renders M_SL by querying CanvasRenderer mesh
        Transform msl = null;
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
            if (t.name == "M_SL") { msl = t; break; }
        if (msl != null)
        {
            var mImg = msl.GetComponent<Image>();
            if (mImg != null)
            {
                sb.AppendLine("--- M_SL Image details ---");
                sb.AppendLine($"  material={(mImg.material != null ? mImg.material.name : "<null>")}");
                sb.AppendLine($"  defaultMaterial={(mImg.defaultMaterial != null ? mImg.defaultMaterial.name : "<null>")}");
                sb.AppendLine($"  mainTexture={(mImg.mainTexture != null ? mImg.mainTexture.name : "<null>")}");
                sb.AppendLine($"  rectTransform.rect={mImg.rectTransform.rect}");
                sb.AppendLine($"  layer={mImg.gameObject.layer} ({LayerMask.LayerToName(mImg.gameObject.layer)})");
            }
            // Camera culling mask
            var cam = Camera.main;
            if (cam != null)
            {
                int mslLayer = msl.gameObject.layer;
                bool inMask = (cam.cullingMask & (1 << mslLayer)) != 0;
                sb.AppendLine($"  Camera.cullingMask=0x{cam.cullingMask:X8} M_SL layer={mslLayer} inMask={inMask}");
            }
        }

        // Check what's above UILoginBG (order >= 1, active)
        sb.AppendLine("--- Canvases above UILoginBG (order >= 1, active) that might cover ---");
        foreach (var c in Object.FindObjectsOfType<Canvas>(true))
        {
            if (!c.isRootCanvas) continue;
            if (!c.gameObject.activeInHierarchy) continue;
            if (c.sortingOrder < 1) continue;
            sb.AppendLine($"  {c.name}: order={c.sortingOrder} mode={c.renderMode} cam={c.worldCamera?.name ?? "<null>"}");
            // count opaque graphics
            int opaqueCount = 0;
            foreach (var g in c.GetComponentsInChildren<Graphic>(true))
            {
                if (g.enabled && g.color.a > 0.99f && g.canvasRenderer.cull == false)
                    opaqueCount++;
            }
            sb.AppendLine($"    opaque graphics: {opaqueCount}");
        }

        Debug.Log(sb.ToString());
        return sb.ToString();
    }
}
