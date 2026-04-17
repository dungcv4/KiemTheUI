using UnityEngine;
using UnityEditor;
using System.IO;
using System.Text;
using System.Reflection;

// Navigate to SelectRole, spawn F_EM via SelectRoleRuntimeBridge.ShowCharacter,
// then capture the GameView so we can see the actual current position.
public static class _NavigateAndCaptureFEM
{
    public static string Execute()
    {
        var sb = new StringBuilder();

        // 1) Find LoginSceneController and invoke ShowSelectRole via reflection
        var lscType = System.Type.GetType("LoginSceneController, Assembly-CSharp");
        if (lscType == null)
        {
            sb.AppendLine("LoginSceneController type NOT FOUND");
            Debug.Log(sb.ToString());
            return sb.ToString();
        }
        var lsc = Object.FindObjectOfType(lscType);
        if (lsc == null)
        {
            sb.AppendLine("LoginSceneController instance NOT FOUND");
            Debug.Log(sb.ToString());
            return sb.ToString();
        }
        var showSelectRole = lscType.GetMethod("ShowSelectRole", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
        if (showSelectRole == null)
        {
            sb.AppendLine("ShowSelectRole method NOT FOUND");
            Debug.Log(sb.ToString());
            return sb.ToString();
        }
        showSelectRole.Invoke(lsc, null);
        sb.AppendLine("Invoked ShowSelectRole");

        // 2) Find SelectRoleRuntimeBridge and call ShowCharacter(5, 1) for F_EM
        var bridgeType = System.Type.GetType("SelectRoleRuntimeBridge, Assembly-CSharp");
        var bridge = Object.FindObjectOfType(bridgeType);
        if (bridge == null)
        {
            sb.AppendLine("SelectRoleRuntimeBridge NOT FOUND");
            Debug.Log(sb.ToString());
            return sb.ToString();
        }
        var showChar = bridgeType.GetMethod("ShowCharacter", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
        showChar.Invoke(bridge, new object[] { 5, 1 }); // EMei faction, female
        sb.AppendLine("Invoked ShowCharacter(5, 1)");

        // 3) Capture GameView
        var cam = Camera.main;
        if (cam == null) { sb.AppendLine("No main camera"); Debug.Log(sb.ToString()); return sb.ToString(); }
        int w = 1280, h = 720;
        var rt = new RenderTexture(w, h, 24, RenderTextureFormat.ARGB32);
        var prev = cam.targetTexture;
        cam.targetTexture = rt;
        cam.Render();
        // Also render UI cameras
        foreach (var c in Object.FindObjectsOfType<Camera>())
        {
            if (c == cam) continue;
            if (!c.isActiveAndEnabled) continue;
            var prevT = c.targetTexture;
            c.targetTexture = rt;
            c.Render();
            c.targetTexture = prevT;
        }
        RenderTexture.active = rt;
        var tex = new Texture2D(w, h, TextureFormat.RGBA32, false);
        tex.ReadPixels(new Rect(0, 0, w, h), 0, 0);
        tex.Apply();
        cam.targetTexture = prev;
        RenderTexture.active = null;
        File.WriteAllBytes("Assets/_GameView.png", tex.EncodeToPNG());
        AssetDatabase.ImportAsset("Assets/_GameView.png");
        Object.DestroyImmediate(rt);
        Object.DestroyImmediate(tex);
        sb.AppendLine("Captured GameView to Assets/_GameView.png");

        // 4) Dump F_EM transform
        Transform fem = null;
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
            if (t.name == "F_EM" && t.gameObject.activeInHierarchy) { fem = t; break; }
        if (fem != null)
        {
            var frt = fem as RectTransform;
            sb.AppendLine($"--- F_EM ---");
            sb.AppendLine($"  anchoredPos={frt.anchoredPosition}");
            sb.AppendLine($"  sizeDelta={frt.sizeDelta}");
            sb.AppendLine($"  pivot={frt.pivot}");
            sb.AppendLine($"  rect={frt.rect}");
            sb.AppendLine($"  lossyScale={frt.lossyScale}");
            // Compute screen position of pivot (= bottom-center of character)
            Vector2 screenPivot = RectTransformUtility.WorldToScreenPoint(cam, frt.position);
            sb.AppendLine($"  screen pivot={screenPivot}");
            // Compute screen position of top of rect
            Vector3[] worldCorners = new Vector3[4];
            frt.GetWorldCorners(worldCorners);
            // 0=BL 1=TL 2=TR 3=BR
            Vector2 screenBL = RectTransformUtility.WorldToScreenPoint(cam, worldCorners[0]);
            Vector2 screenTR = RectTransformUtility.WorldToScreenPoint(cam, worldCorners[2]);
            sb.AppendLine($"  screen BL={screenBL} TR={screenTR}");
            sb.AppendLine($"  Screen.height={Screen.height}");
        }
        else
        {
            sb.AppendLine("F_EM NOT found after ShowCharacter");
        }
        Debug.Log(sb.ToString());
        return sb.ToString();
    }
}
