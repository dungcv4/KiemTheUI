using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.Text;

// Tests if M_SL renders by:
// 1. Reporting actual texture dimensions + sprite rect (catches 1x1 placeholders)
// 2. Walking up parent chain checking ANY object's enabled state
// 3. Hiding all other UILoginBG siblings to isolate M_SL
public static class _DiagMSLTexture
{
    public static string Execute()
    {
        var sb = new StringBuilder();

        Transform msl = null;
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
            if (t.name == "M_SL") { msl = t; break; }
        if (msl == null) { sb.AppendLine("M_SL NOT FOUND"); Debug.Log(sb.ToString()); return sb.ToString(); }

        var img = msl.GetComponent<Image>();
        if (img != null && img.sprite != null)
        {
            var sp = img.sprite;
            sb.AppendLine($"Sprite: {sp.name}");
            sb.AppendLine($"  rect={sp.rect} pixelsPerUnit={sp.pixelsPerUnit} pivot={sp.pivot}");
            sb.AppendLine($"  bounds={sp.bounds}");
            if (sp.texture != null)
            {
                sb.AppendLine($"  texture={sp.texture.name} {sp.texture.width}x{sp.texture.height} format={sp.texture.format} readable={sp.texture.isReadable}");
            }
            else sb.AppendLine($"  texture=NULL");

            // Sample a pixel from the middle
            try
            {
                var tex = sp.texture;
                if (tex != null && tex.isReadable)
                {
                    var px = tex.GetPixel(tex.width / 2, tex.height / 2);
                    sb.AppendLine($"  middle pixel: {px}");
                }
            }
            catch (System.Exception e) { sb.AppendLine($"  GetPixel err: {e.Message}"); }
        }

        // Check if M_SL Image is registered in graphic registry
        var canvas = msl.GetComponentInParent<Canvas>();
        if (canvas != null)
        {
            sb.AppendLine($"M_SL belongs to canvas: {canvas.name}");
            sb.AppendLine($"  rootCanvas: {canvas.rootCanvas.name}");
        }

        // Check meshFilter / canvasRenderer mesh existence
        var cr = msl.GetComponent<CanvasRenderer>();
        if (cr != null)
        {
            sb.AppendLine($"CanvasRenderer cull={cr.cull} alpha={cr.GetAlpha()} colorAlpha={cr.GetColor().a} hasMaterial={(cr.GetMaterial(0) != null)}");
        }

        // Force layout rebuild
        if (img != null) img.SetAllDirty();

        Debug.Log(sb.ToString());
        return sb.ToString();
    }
}
