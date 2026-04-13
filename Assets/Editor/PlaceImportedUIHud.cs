using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.UI;

public class PlaceImportedUIHud
{
    [MenuItem("KTO/Place All Imported HUD")]
    public static void Execute()
    {
        var scene = EditorSceneManager.NewScene(NewSceneSetup.DefaultGameObjects, NewSceneMode.Single);

        // EventSystem
        var es = new GameObject("EventSystem");
        es.AddComponent<UnityEngine.EventSystems.EventSystem>();
        es.AddComponent<UnityEngine.EventSystems.StandaloneInputModule>();

        // Background scene tile (Shaolin map) for visual context
        var bgGO = new GameObject("SceneBG");
        var bgCanvas = bgGO.AddComponent<Canvas>();
        bgCanvas.renderMode = RenderMode.ScreenSpaceOverlay;
        bgCanvas.sortingOrder = 0;
        var bgScaler = bgGO.AddComponent<CanvasScaler>();
        bgScaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        bgScaler.referenceResolution = new Vector2(1334, 750);
        bgScaler.matchWidthOrHeight = 0.5f;
        bgGO.AddComponent<GraphicRaycaster>();
        var bgImgGO = new GameObject("BG");
        bgImgGO.transform.SetParent(bgGO.transform, false);
        var bgImg = bgImgGO.AddComponent<Image>();
        bgImg.sprite = AssetDatabase.LoadAssetAtPath<Sprite>("Assets/Sprite/minimap/minimap_shaolin.png");
        var bgRT = bgImgGO.GetComponent<RectTransform>();
        bgRT.anchorMin = Vector2.zero; bgRT.anchorMax = Vector2.one;
        bgRT.offsetMin = Vector2.zero; bgRT.offsetMax = Vector2.zero;

        string[] prefabs = {
            "UIHud", "UIHudChat", "UIHudLeftPanelTask", "UIHudLeftPanelTeam", "UIHudMinimap",
            "UIHudRightBottom", "UIHudRightCenter", "UIHudRightSkill", "UIHudRightTopWelfare"
        };

        // Slots in UIHudLeftFrameExt where these sub-panels actually sit at runtime.
        // Both occupy the same PanelGroup rect: 250×236 anchored top-left, offset (45.5, -143.9).
        var slots = new System.Collections.Generic.Dictionary<string, (Vector2 pos, Vector2 size)>
        {
            { "UIHudLeftPanelTask", (new Vector2(45.5f, -143.9f), new Vector2(250f, 236f)) },
            { "UIHudLeftPanelTeam", (new Vector2(45.5f, -143.9f), new Vector2(250f, 236f)) },
        };

        int sortingOrder = 10;
        foreach (var name in prefabs)
        {
            var path = $"Assets/Prefabs/Imported/{name}.prefab";
            var prefab = AssetDatabase.LoadAssetAtPath<GameObject>(path);
            if (prefab == null) { Debug.LogError("missing: " + path); continue; }
            var instance = (GameObject)PrefabUtility.InstantiatePrefab(prefab);
            instance.name = name;

            // Sub-HUD prefabs that the original game places inside a PanelGroup
            // slot need a wrapper Canvas + a sized RectTransform around them,
            // because their own root rect is "stretch full parent".
            if (slots.TryGetValue(name, out var slot))
            {
                // Create wrapper: full-screen Canvas → sized child rect → instance.
                var wrapper = new GameObject(name + "_Canvas");
                var wc = wrapper.AddComponent<Canvas>();
                wc.renderMode = RenderMode.ScreenSpaceOverlay;
                wc.overrideSorting = true;
                wc.sortingOrder = sortingOrder++;
                var ws = wrapper.AddComponent<CanvasScaler>();
                ws.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
                ws.referenceResolution = new Vector2(1334, 750);
                ws.matchWidthOrHeight = 0.5f;
                wrapper.AddComponent<GraphicRaycaster>();

                var slotGO = new GameObject(name + "_Slot", typeof(RectTransform));
                slotGO.transform.SetParent(wrapper.transform, false);
                var srt = slotGO.GetComponent<RectTransform>();
                srt.anchorMin = new Vector2(0f, 1f);
                srt.anchorMax = new Vector2(0f, 1f);
                srt.pivot = new Vector2(0f, 1f);
                srt.anchoredPosition = slot.pos;
                srt.sizeDelta = slot.size;

                instance.transform.SetParent(slotGO.transform, false);
                // Make the imported prefab fill its slot.
                var irt = instance.GetComponent<RectTransform>();
                irt.anchorMin = Vector2.zero;
                irt.anchorMax = Vector2.one;
                irt.pivot = new Vector2(0.5f, 0.5f);
                irt.anchoredPosition = Vector2.zero;
                irt.sizeDelta = Vector2.zero;
                irt.localScale = Vector3.one;
                // Strip any Canvas the prefab brought with it (would conflict).
                var ic = instance.GetComponent<Canvas>();
                if (ic != null)
                {
                    var igr = instance.GetComponent<GraphicRaycaster>();
                    if (igr != null) Object.DestroyImmediate(igr);
                    var ics = instance.GetComponent<CanvasScaler>();
                    if (ics != null) Object.DestroyImmediate(ics);
                    Object.DestroyImmediate(ic);
                }
                Debug.Log($"  ⟳ wrapped {name} in slot pos={slot.pos} size={slot.size}");
            }
            else
            {
                var c = instance.GetComponent<Canvas>();
                if (c == null) c = instance.GetComponentInChildren<Canvas>();
                if (c == null)
                {
                    c = instance.AddComponent<Canvas>();
                    var scaler = instance.AddComponent<CanvasScaler>();
                    scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
                    scaler.referenceResolution = new Vector2(1334, 750);
                    scaler.matchWidthOrHeight = 0.5f;
                    instance.AddComponent<GraphicRaycaster>();
                    Debug.Log($"  + added Canvas to {name}");
                }
                c.renderMode = RenderMode.ScreenSpaceOverlay;
                c.overrideSorting = true;
                c.sortingOrder = sortingOrder++;
            }

            Debug.Log($"  placed {name}");
        }

        // LuaRuntime — single GameObject that hosts LuaEngine. It loads
        // every Lua script in Resources/Lua and binds Button.onClick handlers
        // to the prefabs we just placed. Awake() runs at scene start.
        var luaGO = new GameObject("LuaRuntime");
        luaGO.AddComponent<LuaEngine>();
        Debug.Log("[PlaceImportedHUD] Added LuaRuntime → LuaEngine");

        // Hide every spriteless Image — particle/effect anchors, mask viewports,
        // template placeholders. The placer creates a fresh scene each run,
        // so this needs to run inline (not as a separate menu pass).
        HideSpritelessInline();

        EditorSceneManager.MarkSceneDirty(scene);
        EditorSceneManager.SaveScene(scene, "Assets/MainUIScene.unity");
        Debug.Log("[PlaceImportedHUD] Saved MainUIScene with all 9 prefabs + LuaRuntime");
    }

    static void HideSpritelessInline()
    {
        int hidden = 0;
        foreach (var img in Object.FindObjectsOfType<Image>(true))
        {
            if (img.sprite != null) continue;
            var c = img.color;
            if (c.a < 0.01f) continue;
            img.color = new Color(c.r, c.g, c.b, 0f);
            EditorUtility.SetDirty(img);
            hidden++;
        }
        Debug.Log($"[PlaceImportedHUD] hid {hidden} spriteless Images inline");
    }
}
