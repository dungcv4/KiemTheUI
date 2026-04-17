using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

// Post-import wiring for UIJoyStick.
//
// Runs Import_res_p_114.Build() (the auto-generated bundle importer), then
// patches the saved prefab to:
//   - fix root localScale (the bundle serialized it as 0,0,0; Tuanjie Unity
//     apparently normalizes this at instantiation — stock Unity doesn't).
//   - add KTO.Game.UIJoyStick MonoBehaviour
//   - wire up swiper/handle/arrow references to the imported child transforms
//   - set rightTopBorder to the .ctor literal (−296, −380) from
//     KTO_DecompiledReference/_root/UIJoyStick.c @ 0x01cc50ff
//   - set handleRatio to a sane default (the bundle MB didn't expose it via
//     our typetree whitelist; 0.15 matches the visual from gameplay footage)
public static class BuildUIJoyStick
{
    [MenuItem("KTO/Build UIJoyStick Prefab (literal)")]
    public static void Execute()
    {
        // Step 1: run the auto-generated importer
        Import_res_p_114.Build();

        // Step 2: load the saved prefab and patch it
        const string path = "Assets/Prefabs/Imported/UIJoyStick.prefab";
        var asset = AssetDatabase.LoadAssetAtPath<GameObject>(path);
        if (asset == null)
        {
            Debug.LogError("[BuildUIJoyStick] prefab not found at " + path);
            return;
        }

        var contents = PrefabUtility.LoadPrefabContents(path);

        // --- fix root scale ---
        var rootRT = contents.GetComponent<RectTransform>();
        if (rootRT != null)
        {
            rootRT.localScale = Vector3.one;
            // Root is a HUD canvas-root proxy: stretch-full, size 0.
            rootRT.anchorMin = new Vector2(0f, 0f);
            rootRT.anchorMax = new Vector2(1f, 1f);
            rootRT.pivot     = new Vector2(0.5f, 0.5f);
            rootRT.sizeDelta = Vector2.zero;
            rootRT.anchoredPosition = Vector2.zero;
        }

        // --- find child transforms ---
        // Hierarchy: UIJoyStick / panel / Joystick / {image, imgArrow, Thumb, KeyboardMark, imgHand}
        var panel    = contents.transform.Find("panel");
        var joystick = panel != null ? panel.Find("Joystick") : null;
        var image    = joystick != null ? joystick.Find("image")    : null;  // swiper background
        var imgArrow = joystick != null ? joystick.Find("imgArrow") : null;
        var thumb    = joystick != null ? joystick.Find("Thumb")    : null;  // handle

        if (joystick == null || image == null || thumb == null || imgArrow == null)
        {
            Debug.LogError($"[BuildUIJoyStick] missing children under panel/Joystick: " +
                           $"image={image} imgArrow={imgArrow} thumb={thumb}");
            PrefabUtility.UnloadPrefabContents(contents);
            return;
        }

        // --- add UIJoyStick MB and wire references ---
        var js = contents.GetComponent<KTO.Game.UIJoyStick>();
        if (js == null) js = contents.AddComponent<KTO.Game.UIJoyStick>();

        // rightTopBorder literal from UIJoyStick.c .ctor @ 0x01cc50ff:
        //   *(undefined8 *)(param_1 + 0x20) = 0xc3be0000c3948000;
        //   → Vector2(-296f, -380f)
        js.rightTopBorder = new Vector2(-296f, -380f);
        js.handleRatio    = 0.15f;  // tuned, not in our typetree whitelist
        js.bEnable        = true;
        js.swiper = image as RectTransform;
        js.handle = thumb as RectTransform;
        js.arrow  = imgArrow;

        // --- save back ---
        PrefabUtility.SaveAsPrefabAsset(contents, path);
        PrefabUtility.UnloadPrefabContents(contents);
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
        Debug.Log("[BuildUIJoyStick] wired UIJoyStick component + refs, saved " + path);
    }
}
