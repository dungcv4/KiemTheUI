using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEditor;
using UnityEditor.SceneManagement;

// Authoritative one-off placer for the SelectRole screen.
// Follows SKILL Step 4b — single-screen placer pattern.
//
// Stack (sortingOrder ↑ = on top):
//   Layer 0: Background_Canvas        → createrole_bg sprite
//   Layer 1: UILoginBG (Canvas)        → empty parent for Character mount
//                                        Character sub-canvas overrideSorting=true,
//                                        order=2 → avatar renders above bg
//   Layer 3: UISelectRoleExist_Canvas  → role list panel UI on top
//
// UILoginBG structure mirrors the REAL prefab from
// RippedProject_APK/ExportedProject/Assets/game/ui/views/UILoginBG.prefab
// (the KiemTheUI/Assets/game/ui/views/UILoginBG.prefab file is wrong — it's
// actually a particle effect named GX35; do NOT trust it).
//
// Real UILoginBG layout (sub-objects):
//   UILoginBG (RT scale=0,0,0 in prefab — runtime sets to 1,1,1)
//     ├ bg              (background image — we use Background_Canvas instead)
//     ├ VFX_after       (particle SortingGroup — skipped here)
//     ├ Character       (RectTransform, Canvas WorldSpace, sortingOrder=1)
//     └ VFX_front       (particle SortingGroup — skipped here)
//
// We only create UILoginBG + Character (the mount point used by
// SelectRoleRuntimeBridge.FindCharacterContainer) since SelectRole doesn't
// need the bg/VFX layers (Background_Canvas already shows createrole_bg,
// and per Lua UILoginBG:OnCreate the VFX layers start inactive anyway).
//
// NOT included: UICreateRole popup (res_p_55) — that's a separate screen
// opened from the "Tạo nhân vật" button. Per SKILL §0, popups belong to
// their own placer.
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

        // Step 3 — UILoginBG with Character mount point (mirrors real prefab
        // from RippedProject_APK). Provides the container that
        // SelectRoleRuntimeBridge.FindCharacterContainer searches for as
        // "Character" with parent "UILoginBG".
        CreateUILoginBGWithCharacter();

        // Step 4 — Layer 3: UISelectRoleExist (main panel) — bumped from
        // sortingOrder=1 to 3 so the role list renders above UILoginBG (1)
        // and Character sub-canvas (2)
        PlacePrefab("Assets/Prefabs/Imported/UISelectRoleExist.prefab",
                    "UISelectRoleExist_Canvas", sortingOrder: 3, active: true);

        // Step 5 — kill any white spriteless rectangles inline
        HideSpritelessInline();

        // Step 6 — LuaRuntime: hosts LuaEngine which loads every Lua file in
        // Resources/Lua and binds Button.onClick handlers from tbOnClick
        // closures. Awake() runs in Play mode and populates dynamic content
        // (character scroll list, server name, faction icon swaps, etc.).
        var luaGo = new GameObject("LuaRuntime");
        luaGo.AddComponent<LuaEngine>();
        Debug.Log("[PlaceSelectRole] Added LuaRuntime → LuaEngine");

        // Step 7 — save scene
        EditorSceneManager.MarkSceneDirty(scene);
        EditorSceneManager.SaveScene(scene, "Assets/SelectRoleScene.unity");
        Debug.Log("[PlaceSelectRole] Saved Assets/SelectRoleScene.unity");
    }

    // Creates UILoginBG canvas root with a Character sub-canvas mount point.
    // Structure mirrors RippedProject_APK/.../UILoginBG.prefab (the authoritative
    // source). Character canvas uses overrideSorting=true with sortingOrder=2 so
    // the avatar renders above Background_Canvas (0) but below UISelectRoleExist
    // panel (3).
    private static void CreateUILoginBGWithCharacter()
    {
        // 1. UILoginBG canvas root — mirror real prefab Canvas config:
        //    renderMode=ScreenSpaceCamera in original, but we use SSO to match
        //    Background_Canvas/UISelectRoleExist_Canvas siblings. sortingOrder=1.
        var loginBg = MakeCanvas("UILoginBG", sortingOrder: 1);
        var loginBgRt = loginBg.GetComponent<RectTransform>();
        loginBgRt.localScale = Vector3.one; // override default 0,0,0

        // 2. Character mount — RT centered (matches real prefab):
        //    anchor=(0.5,0.5), pos=(0,0), size=(100,100), pivot=(0.5,0.5)
        //    Then add a sub-Canvas with overrideSorting=true so the avatar
        //    renders at our chosen order regardless of where it sits in the
        //    hierarchy.
        var characterGo = new GameObject("Character",
            typeof(RectTransform), typeof(Canvas), typeof(GraphicRaycaster));
        characterGo.transform.SetParent(loginBg.transform, false);

        var charRt = characterGo.GetComponent<RectTransform>();
        charRt.anchorMin = new Vector2(0.5f, 0.5f);
        charRt.anchorMax = new Vector2(0.5f, 0.5f);
        charRt.pivot = new Vector2(0.5f, 0.5f);
        charRt.anchoredPosition = Vector2.zero;
        charRt.sizeDelta = new Vector2(100f, 100f);
        charRt.localScale = Vector3.one;

        var charCanvas = characterGo.GetComponent<Canvas>();
        charCanvas.overrideSorting = true;
        charCanvas.sortingLayerName = "UI";
        charCanvas.sortingOrder = 2; // between Background_Canvas (0) and UISelectRoleExist_Canvas (3)

        Debug.Log("[PlaceSelectRole] Created UILoginBG/Character mount (sortingOrder 1/2)");
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
        // Issue 2 fix — original UISelectRoleExist.prefab CanvasScaler is 1280×720,
        // MatchWidthOrHeight, match=0 (verified at prefab line 1824-1829). Wrapping
        // it in a 1334×750/match=0.5 canvas rescaled the avatars (which use absolute
        // pixel sizeDelta like M_TR=798×798) → wrong character sizes vs panel.
        scaler.referenceResolution = new Vector2(1280f, 720f);
        scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;
        scaler.matchWidthOrHeight = 0f;
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
