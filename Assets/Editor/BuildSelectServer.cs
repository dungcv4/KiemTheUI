using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using System.Collections.Generic;

public class BuildSelectServer
{
    public static void Execute()
    {
        // Load resources
        var commonFont = AssetDatabase.LoadAssetAtPath<Font>("Assets/Font/common_vi.ttf");
        var btnFont = AssetDatabase.LoadAssetAtPath<Font>("Assets/Font/btn_hydl_vi.ttf");
        var sprites = LoadSprites();

        // Remove old UILoginChannelSDK if present
        var oldSDK = GameObject.Find("UILoginChannelSDK");
        if (oldSDK != null) Object.DestroyImmediate(oldSDK);

        // === Add UILoginServer (server display on login) ===
        var oldServer = GameObject.Find("UILoginServer");
        if (oldServer != null) Object.DestroyImmediate(oldServer);

        var serverPrefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/game/ui/views/UILoginServer.prefab");
        if (serverPrefab != null)
        {
            var server = (GameObject)PrefabUtility.InstantiatePrefab(serverPrefab);
            var scaler = server.GetComponent<CanvasScaler>();
            if (scaler != null)
            {
                scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
                scaler.referenceResolution = new Vector2(1280, 720);
                scaler.matchWidthOrHeight = 0.5f;
            }
            var canvas = server.GetComponent<Canvas>();
            if (canvas != null) canvas.sortingOrder = 5;

            // Transparent BG
            var imgBG = server.transform.Find("imgBG");
            if (imgBG != null)
            {
                var bg = imgBG.GetComponent<Image>();
                if (bg != null) bg.color = new Color(0, 0, 0, 0);
            }

            // Fix sprites
            SetSprite(server, "btnSetting", sprites, "btn_setting");
            SetSprite(server, "btnAccount", sprites, "btn_account");
            SetSprite(server, "btnAnnounce", sprites, "btn_announce");
            SetSprite(server, "btnEwm", sprites, "btn_Ewm");
            SetSprite(server, "btnQRcode", sprites, "btn_QRcode");
            SetSprite(server, "btnAgreement", sprites, "btn_agreement");
            SetSprite(server, "imgGameLogo", sprites, "gamelogo");
            SetSprite(server, "imgCADPA", sprites, "CADPA");
            SetSprite(server, "imgServerBg", sprites, "img_server_bg");
            SetSprite(server, "btnLoginServer", sprites, "btn_login");
            SetSprite(server, "btnChange", sprites, "btn_login");
            SetSprite(server, "ServerFlagGreen", sprites, "server_normal");
            SetSprite(server, "ServerFlagRed", sprites, "server_busy");
            SetSprite(server, "ServerFlagGray", sprites, "server_maintain");

            // Fix fonts + texts
            foreach (var text in server.GetComponentsInChildren<Text>(true))
                if (text.font == null) text.font = commonFont;

            SetText(server, "btnLoginServer", "Vào Game", btnFont, 26, Color.white);
            SetText(server, "ServerName", "S1 - Hoa Sơn", commonFont, 18, Color.white);
            SetText(server, "ServerIndex", "S1", commonFont, 16, new Color(1f, 0.9f, 0.5f));
            SetText(server, "txtAppVersion", "v2.0.1", commonFont, 14, new Color(0.8f, 0.8f, 0.8f));
            SetText(server, "txtGameAdvice", "Trò chơi dành cho người trên 18 tuổi", commonFont, 12, new Color(0.7f, 0.7f, 0.7f));
            SetText(server, "btnChange", "Đổi Server", commonFont, 14, Color.white);
            SetText(server, "Label1", "Gần đây", commonFont, 14, Color.white);
            SetText(server, "Label2", "Server", commonFont, 14, new Color(1f, 0.85f, 0.5f));
            SetText(server, "Label3", "Nhân vật", commonFont, 14, new Color(0.7f, 0.7f, 0.7f));
            SetText(server, "Label4", "Lv.50", commonFont, 14, new Color(0.7f, 1f, 0.7f));
            SetText(server, "Deal", "Tôi đồng ý điều khoản", commonFont, 12, new Color(0.6f, 0.8f, 1f));

            Debug.Log("UILoginServer built with sprites + texts");
        }

        // === Add UISelectServer popup (initially hidden, for screenshot) ===
        var oldSelect = GameObject.Find("UISelectServer");
        if (oldSelect != null) Object.DestroyImmediate(oldSelect);

        var selectPrefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/game/ui/views/UISelectServer.prefab");
        if (selectPrefab != null)
        {
            var select = (GameObject)PrefabUtility.InstantiatePrefab(selectPrefab);
            var scaler = select.GetComponent<CanvasScaler>();
            if (scaler != null)
            {
                scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
                scaler.referenceResolution = new Vector2(1280, 720);
                scaler.matchWidthOrHeight = 0.5f;
            }
            var canvas = select.GetComponent<Canvas>();
            if (canvas != null) canvas.sortingOrder = 20;

            // Fix fonts
            foreach (var text in select.GetComponentsInChildren<Text>(true))
                if (text.font == null) text.font = commonFont;

            // Fix texts
            SetText(select, "txtTitle", "Chọn Server", btnFont, 24, new Color(1f, 0.9f, 0.6f));
            SetText(select, "NotInfo", "Chưa có nhân vật", commonFont, 16, new Color(0.6f, 0.6f, 0.6f));

            // Fix KindTemplate text
            var kindText = FindDeep(select.transform, "KindTemplate");
            if (kindText != null)
            {
                var t = kindText.GetComponentInChildren<Text>(true);
                if (t != null) { t.text = "Máy chủ mới"; t.font = commonFont; t.fontSize = 16; }
            }

            // Fix ServerTemplate
            var serverTemplate = FindDeep(select.transform, "ServerTemplate");
            if (serverTemplate != null)
            {
                SetSprite(serverTemplate.gameObject, "ServerFlagGreen", sprites, "server_normal");
                SetSprite(serverTemplate.gameObject, "ServerFlagRed", sprites, "server_busy");
                SetSprite(serverTemplate.gameObject, "ServerFlagGray", sprites, "server_maintain");
                SetSprite(serverTemplate.gameObject, "ServerFlag", sprites, "server_hot");
                SetSprite(serverTemplate.gameObject, "imgNew", sprites, "img_talk_new");

                var sn = FindDeep(serverTemplate, "ServerName");
                if (sn != null) { var t = sn.GetComponent<Text>(); if (t != null) { t.text = "S1 - Hoa Sơn"; t.font = commonFont; t.fontSize = 16; t.color = Color.white; } }
                var si = FindDeep(serverTemplate, "ServerIndex");
                if (si != null) { var t = si.GetComponent<Text>(); if (t != null) { t.text = "S1"; t.font = commonFont; t.fontSize = 14; t.color = new Color(1f, 0.9f, 0.5f); } }
                var sl = FindDeep(serverTemplate, "ServerRoleLevel");
                if (sl != null) { var t = sl.GetComponent<Text>(); if (t != null) { t.text = "Lv.50"; t.font = commonFont; t.fontSize = 14; t.color = new Color(0.7f, 1f, 0.7f); } }
            }

            // Set active to show
            select.SetActive(true);
            Debug.Log("UISelectServer built with sprites + texts");
        }

        // Capture
        CaptureScene("/tmp/selectserver_HD.png");
        Debug.Log("=== Select Server COMPLETE! ===");
    }

    static Dictionary<string, Sprite> LoadSprites()
    {
        var sprites = new Dictionary<string, Sprite>();
        string[] folders = { "Assets/game/ui/atlas/login", "Assets/game/ui/atlas/common", "Assets/game/ui/atlas/common_btn" };
        foreach (var folder in folders)
            foreach (var guid in AssetDatabase.FindAssets("t:Sprite", new[] { folder }))
            {
                var path = AssetDatabase.GUIDToAssetPath(guid);
                var s = AssetDatabase.LoadAssetAtPath<Sprite>(path);
                if (s != null && !sprites.ContainsKey(s.name)) sprites[s.name] = s;
            }
        return sprites;
    }

    static void SetSprite(GameObject root, string name, Dictionary<string, Sprite> sprites, string spriteName)
    {
        if (!sprites.ContainsKey(spriteName)) return;
        var t = FindDeep(root.transform, name);
        if (t == null) return;
        var img = t.GetComponent<Image>();
        if (img != null && img.sprite == null)
            img.sprite = sprites[spriteName];
    }

    static void SetText(GameObject root, string name, string content, Font font, int size, Color color)
    {
        var t = FindDeep(root.transform, name);
        if (t == null) return;
        var text = t.GetComponent<Text>();
        if (text == null) { var tc = t.Find("Text"); if (tc != null) text = tc.GetComponent<Text>(); }
        if (text != null)
        {
            text.text = content;
            if (font != null) text.font = font;
            text.fontSize = size;
            text.color = color;
            text.alignment = TextAnchor.MiddleCenter;
        }
    }

    static Transform FindDeep(Transform parent, string name)
    {
        foreach (Transform child in parent)
        {
            if (child.name == name) return child;
            var f = FindDeep(child, name);
            if (f != null) return f;
        }
        return null;
    }

    static void CaptureScene(string path)
    {
        var camObj = GameObject.Find("Main Camera");
        if (camObj == null) return;
        var cam = camObj.GetComponent<Camera>();

        var canvases = Object.FindObjectsOfType<Canvas>();
        foreach (var c in canvases)
            if (c.isRootCanvas) { c.renderMode = RenderMode.ScreenSpaceCamera; c.worldCamera = cam; c.planeDistance = 10; }

        int w = 1920, h = 1080;
        var rt = new RenderTexture(w, h, 24);
        cam.targetTexture = rt;
        cam.Render();
        RenderTexture.active = rt;
        var tex = new Texture2D(w, h, TextureFormat.RGB24, false);
        tex.ReadPixels(new Rect(0, 0, w, h), 0, 0);
        tex.Apply();
        System.IO.File.WriteAllBytes(path, tex.EncodeToPNG());
        cam.targetTexture = null;
        RenderTexture.active = null;
        Object.DestroyImmediate(rt);
        Object.DestroyImmediate(tex);

        foreach (var c in canvases)
            if (c.isRootCanvas) c.renderMode = RenderMode.ScreenSpaceOverlay;
    }
}
