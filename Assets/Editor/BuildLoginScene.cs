using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.UI;

public class BuildLoginScene
{
    public static void Execute()
    {
        // Create fresh scene
        EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);

        // Add camera
        var camObj = new GameObject("Main Camera");
        var cam = camObj.AddComponent<Camera>();
        cam.clearFlags = CameraClearFlags.SolidColor;
        cam.backgroundColor = Color.black;
        cam.orthographic = true;

        // 1. Create Background Canvas with vnbg1
        var bgCanvas = new GameObject("BG_Canvas");
        var bgCanvasComp = bgCanvas.AddComponent<Canvas>();
        bgCanvasComp.renderMode = RenderMode.ScreenSpaceOverlay;
        bgCanvasComp.sortingOrder = -10;
        var bgScaler = bgCanvas.AddComponent<CanvasScaler>();
        bgScaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        bgScaler.referenceResolution = new Vector2(1280, 720);
        bgScaler.matchWidthOrHeight = 0.5f;
        bgCanvas.AddComponent<GraphicRaycaster>();

        // Add background image
        var bgImgObj = new GameObject("imgBackground");
        bgImgObj.transform.SetParent(bgCanvas.transform, false);
        var bgRect = bgImgObj.AddComponent<RectTransform>();
        bgRect.anchorMin = Vector2.zero;
        bgRect.anchorMax = Vector2.one;
        bgRect.sizeDelta = Vector2.zero;
        bgImgObj.AddComponent<CanvasRenderer>();
        var bgImg = bgImgObj.AddComponent<Image>();

        // Load vnbg1 sprite
        string vnbgPath = "Assets/game/ui/bg/vnbg1.png";
        var importer = AssetImporter.GetAtPath(vnbgPath) as TextureImporter;
        if (importer != null && importer.textureType != TextureImporterType.Sprite)
        {
            importer.textureType = TextureImporterType.Sprite;
            importer.maxTextureSize = 2048;
            importer.SaveAndReimport();
        }
        var bgSprite = AssetDatabase.LoadAssetAtPath<Sprite>(vnbgPath);
        if (bgSprite != null)
        {
            bgImg.sprite = bgSprite;
            bgImg.preserveAspect = false;
            Debug.Log("Background vnbg1 loaded!");
        }

        // 2. Instantiate UILoginBG (particle effects layer)
        var loginBGPrefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/game/ui/views/UILoginBG.prefab");
        if (loginBGPrefab != null)
        {
            var loginBG = (GameObject)PrefabUtility.InstantiatePrefab(loginBGPrefab);
            var lbScaler = loginBG.GetComponent<CanvasScaler>();
            if (lbScaler != null)
            {
                lbScaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
                lbScaler.referenceResolution = new Vector2(1280, 720);
                lbScaler.matchWidthOrHeight = 0.5f;
            }
            var lbCanvas = loginBG.GetComponent<Canvas>();
            if (lbCanvas != null) lbCanvas.sortingOrder = 0;
        }

        // 3. Instantiate UILoginChannelSDK (the real login UI)
        var sdkPrefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/game/ui/views/UILoginChannelSDK.prefab");
        if (sdkPrefab != null)
        {
            var sdk = (GameObject)PrefabUtility.InstantiatePrefab(sdkPrefab);
            var sdkScaler = sdk.GetComponent<CanvasScaler>();
            if (sdkScaler != null)
            {
                sdkScaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
                sdkScaler.referenceResolution = new Vector2(1280, 720);
                sdkScaler.matchWidthOrHeight = 0.5f;
            }
            var sdkCanvas = sdk.GetComponent<Canvas>();
            if (sdkCanvas != null) sdkCanvas.sortingOrder = 10;

            // Make imgBG transparent so background shows through
            var imgBG = sdk.transform.Find("imgBG");
            if (imgBG != null)
            {
                var img = imgBG.GetComponent<Image>();
                if (img != null) img.color = new Color(0, 0, 0, 0);
            }
        }

        // Focus Game view
        var gameView = EditorWindow.GetWindow(System.Type.GetType("UnityEditor.GameView,UnityEditor"));
        if (gameView != null) gameView.Focus();

        Debug.Log("=== Login Scene Built! BG + LoginBG particles + LoginChannelSDK ===");
    }
}
