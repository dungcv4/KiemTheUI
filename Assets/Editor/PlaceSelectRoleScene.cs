using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEditor;
using UnityEditor.SceneManagement;

// Authoritative one-off placer for the SelectRole screen.
// Follows SKILL Step 4b — single-screen placer pattern.
//
// Stack:
//   Layer 0: static background  → Assets/Sprite/scene_bg/createrole_bg.png
//                                 (UILoginBG bundle res_p_134 is empty —
//                                 only particle anchors / 3D scene roots)
//   Layer 1: UISelectRoleExist  → Assets/Prefabs/Imported/UISelectRoleExist.prefab
//                                 (the main panel; active by default)
//
// NOT included: UICreateRole popup (res_p_55) — that's a separate screen
// opened from the "Tạo nhân vật" button. Per SKILL §0, popups belong to
// their own placer.
//
// NOT included: LuaRuntime — this placer is for evaluating raw pipeline
// fidelity (visual correctness without dynamic lua-driven content).
public static class PlaceSelectRoleScene
{
    [MenuItem("KTO/Place SelectRole Scene")]
    public static void Execute()
    {
        // Step 1 — fresh scene with EventSystem
        var scene = EditorSceneManager.NewScene(
            NewSceneSetup.DefaultGameObjects,
            NewSceneMode.Single);

        var eventSysGo = GameObject.Find("EventSystem");
        if (eventSysGo == null)
        {
            eventSysGo = new GameObject("EventSystem");
            eventSysGo.AddComponent<EventSystem>();
            eventSysGo.AddComponent<StandaloneInputModule>();
        }

        // Step 2 — Layer 0: background sprite
        var bgSprite = AssetDatabase.LoadAssetAtPath<Sprite>(
            "Assets/Sprite/scene_bg/createrole_bg.png");
        if (bgSprite == null)
        {
            Debug.LogWarning("[PlaceSelectRole] createrole_bg.png not found — skipping background");
        }
        else
        {
            var bgCanvasGo = MakeCanvas("Background_Canvas", sortingOrder: 0);
            var bgImgGo = new GameObject("BackgroundImage",
                typeof(RectTransform), typeof(CanvasRenderer), typeof(Image));
            bgImgGo.transform.SetParent(bgCanvasGo.transform, false);
            var bgImg = bgImgGo.GetComponent<Image>();
            bgImg.sprite = bgSprite;
            bgImg.preserveAspect = false;
            var bgRt = bgImgGo.GetComponent<RectTransform>();
            bgRt.anchorMin = Vector2.zero;
            bgRt.anchorMax = Vector2.one;
            bgRt.offsetMin = Vector2.zero;
            bgRt.offsetMax = Vector2.zero;
            Debug.Log("[PlaceSelectRole] Placed background createrole_bg.png");
        }

        // Step 3 — Layer 1: UISelectRoleExist (main panel)
        PlacePrefab("Assets/Prefabs/Imported/UISelectRoleExist.prefab",
                    "UISelectRoleExist_Canvas", sortingOrder: 1, active: true);

        // Step 4 — kill any white spriteless rectangles inline
        HideSpritelessInline();

        // Step 5 — LuaRuntime: hosts LuaEngine which loads every Lua file in
        // Resources/Lua and binds Button.onClick handlers from tbOnClick
        // closures. Awake() runs in Play mode and populates dynamic content
        // (character scroll list, server name, faction icon swaps, etc.).
        var luaGo = new GameObject("LuaRuntime");
        luaGo.AddComponent<LuaEngine>();
        Debug.Log("[PlaceSelectRole] Added LuaRuntime → LuaEngine");

        // Step 6 — save scene
        EditorSceneManager.MarkSceneDirty(scene);
        EditorSceneManager.SaveScene(scene, "Assets/SelectRoleScene.unity");
        Debug.Log("[PlaceSelectRole] Saved Assets/SelectRoleScene.unity");
    }

    private static GameObject MakeCanvas(string name, int sortingOrder)
    {
        var canvasGo = new GameObject(name, typeof(RectTransform), typeof(Canvas),
                                      typeof(CanvasScaler), typeof(GraphicRaycaster));
        var canvas = canvasGo.GetComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        canvas.sortingOrder = sortingOrder;
        var scaler = canvasGo.GetComponent<CanvasScaler>();
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        scaler.referenceResolution = new Vector2(1334f, 750f);
        scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;
        scaler.matchWidthOrHeight = 0.5f;
        return canvasGo;
    }

    private static void PlacePrefab(string prefabPath, string canvasName, int sortingOrder, bool active)
    {
        var prefab = AssetDatabase.LoadAssetAtPath<GameObject>(prefabPath);
        if (prefab == null)
        {
            Debug.LogError($"[PlaceSelectRole] Prefab not found: {prefabPath}");
            return;
        }

        var wrapper = MakeCanvas(canvasName, sortingOrder);
        var instance = (GameObject)PrefabUtility.InstantiatePrefab(prefab);
        instance.transform.SetParent(wrapper.transform, false);

        // Strip the prefab's own Canvas/CanvasScaler/GraphicRaycaster — the
        // wrapper canvas already provides these. Avoids ScreenSpaceOverlay
        // double-canvas conflict.
        var existingCanvas = instance.GetComponent<Canvas>();
        if (existingCanvas != null) Object.DestroyImmediate(existingCanvas, allowDestroyingAssets: false);
        var existingScaler = instance.GetComponent<CanvasScaler>();
        if (existingScaler != null) Object.DestroyImmediate(existingScaler, allowDestroyingAssets: false);
        var existingRaycaster = instance.GetComponent<GraphicRaycaster>();
        if (existingRaycaster != null) Object.DestroyImmediate(existingRaycaster, allowDestroyingAssets: false);

        // Stretch to fill wrapper
        var rt = instance.GetComponent<RectTransform>();
        if (rt != null)
        {
            rt.anchorMin = Vector2.zero;
            rt.anchorMax = Vector2.one;
            rt.offsetMin = Vector2.zero;
            rt.offsetMax = Vector2.zero;
            rt.localScale = Vector3.one;
        }

        instance.SetActive(active);
        Debug.Log($"[PlaceSelectRole] Placed {prefabPath} → {canvasName} (sortingOrder={sortingOrder})");
    }

    private static void HideSpritelessInline()
    {
        int hidden = 0;
        foreach (var img in Object.FindObjectsByType<Image>(FindObjectsInactive.Include, FindObjectsSortMode.None))
        {
            if (img == null) continue;
            if (img.sprite == null && img.color.a >= 0.01f)
            {
                var c = img.color;
                c.a = 0f;
                img.color = c;
                hidden++;
            }
        }
        Debug.Log($"[PlaceSelectRole] Hid {hidden} spriteless white images");
    }
}
