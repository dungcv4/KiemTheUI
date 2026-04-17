using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using KTOGame = KTO.Game;

namespace KTO.Editor.MapImport
{
    public static class KTO_MatchGocRefactor
    {
        const string MainUIScenePath = "Assets/MainUIScene.unity";
        const string MapScenePath = "Assets/Maps/yunzhongzhen1_a/yunzhongzhen1_a.unity";
        const string MapPrefabPath = "Assets/Maps/yunzhongzhen1_a/yunzhongzhen1_a.prefab";
        const string HudPrefabDir = "Assets/Prefabs/Imported";

        static readonly string[] HudPrefabNames = {
            "UIHud",
            "UIHudChat",
            "UIHudLeftPanelTask",
            "UIHudLeftPanelTeam",
            "UIHudMinimap",
            "UIHudRightBottom",
            "UIHudRightCenter",
            "UIHudRightSkill",
            "UIHudRightTopWelfare",
        };

        [MenuItem("KTO/Match Goc/1. Create yunzhongzhen1_a scene")]
        public static void CreateMapScene()
        {
            var prefab = AssetDatabase.LoadAssetAtPath<GameObject>(MapPrefabPath);
            if (prefab == null) { Debug.LogError("[KTO] Map prefab not found: " + MapPrefabPath); return; }

            var dir = Path.GetDirectoryName(MapScenePath);
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

            var newScene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
            var inst = (GameObject)PrefabUtility.InstantiatePrefab(prefab);
            inst.transform.position = Vector3.zero;
            inst.transform.rotation = Quaternion.identity;

            EditorSceneManager.SaveScene(newScene, MapScenePath);
            Debug.Log("[KTO] Saved map scene: " + MapScenePath);
        }

        [MenuItem("KTO/Match Goc/2. Refactor MainUIScene to level0 layout")]
        public static void RefactorMainUIScene()
        {
            EnsureTags();

            var scene = EditorSceneManager.OpenScene(MainUIScenePath, OpenSceneMode.Single);

            var roots = scene.GetRootGameObjects();
            Debug.Log($"[KTO] MainUIScene currently has {roots.Length} root GameObjects");

            var toDestroy = new List<GameObject>();
            GameObject eventSystem = null;
            GameObject luaRuntime = null;
            GameObject directionalLight = null;

            foreach (var go in roots)
            {
                var n = go.name;
                if (n == "EventSystem") { eventSystem = go; continue; }
                if (n == "LuaRuntime") { luaRuntime = go; continue; }
                if (n == "Directional Light") { directionalLight = go; continue; }
                toDestroy.Add(go);
            }

            foreach (var go in toDestroy)
            {
                Debug.Log("[KTO]   removing root: " + go.name);
                Object.DestroyImmediate(go);
            }

            var sceneCamGO = new GameObject("SceneCamera");
            sceneCamGO.tag = "MainCamera";
            var sceneCam = sceneCamGO.AddComponent<Camera>();
            sceneCamGO.AddComponent<AudioListener>();
            sceneCam.orthographic = true;
            sceneCam.orthographicSize = 2.8f;
            sceneCam.clearFlags = CameraClearFlags.SolidColor;
            sceneCam.backgroundColor = Color.black;
            sceneCam.depth = 0;
            sceneCam.nearClipPlane = 0.3f;
            sceneCam.farClipPlane = 3000f;
            int uiLayer = LayerMask.NameToLayer("UI");
            sceneCam.cullingMask = uiLayer >= 0 ? ~(1 << uiLayer) : ~0;
            sceneCamGO.transform.position = new Vector3(0, 0, -100);

            var uiCamGO = new GameObject("UICamera");
            uiCamGO.tag = "UICamera";
            uiCamGO.layer = uiLayer >= 0 ? uiLayer : 5;
            var uiCam = uiCamGO.AddComponent<Camera>();
            uiCam.orthographic = true;
            uiCam.orthographicSize = 5f;
            uiCam.clearFlags = CameraClearFlags.Depth;
            uiCam.depth = 10;
            uiCam.nearClipPlane = 0.3f;
            uiCam.farClipPlane = 1000f;
            uiCam.cullingMask = uiLayer >= 0 ? (1 << uiLayer) : 32;
            uiCamGO.transform.position = Vector3.zero;

            var gameStartGO = new GameObject("GameStart");
            var gameStart = gameStartGO.AddComponent<KTOGame.GameStart>();
            var uiMgr = gameStartGO.AddComponent<KTOGame.UIMgr>();
            gameStartGO.AddComponent<KTOGame.SceneLoadManager>();

            uiMgr.UICamera = uiCam;
            var hudList = new List<GameObject>();
            foreach (var name in HudPrefabNames)
            {
                var path = $"{HudPrefabDir}/{name}.prefab";
                var p = AssetDatabase.LoadAssetAtPath<GameObject>(path);
                if (p == null) { Debug.LogWarning("[KTO] HUD prefab missing: " + path); continue; }
                hudList.Add(p);
            }
            uiMgr.HudPrefabs = hudList.ToArray();
            gameStart.InitialMapCode = 1;

            EditorSceneManager.MarkSceneDirty(scene);
            EditorSceneManager.SaveScene(scene);

            Debug.Log($"[KTO] MainUIScene refactored. Roots now: SceneCamera, UICamera, GameStart" +
                (eventSystem != null ? ", EventSystem" : "") +
                (luaRuntime != null ? ", LuaRuntime" : "") +
                (directionalLight != null ? ", Directional Light" : ""));
        }

        [MenuItem("KTO/Match Goc/3. Update Build Settings (add map scene)")]
        public static void UpdateBuildSettings()
        {
            var existing = EditorBuildSettings.scenes.ToList();
            bool hasMainUI = existing.Any(s => s.path == MainUIScenePath);
            bool hasMap = existing.Any(s => s.path == MapScenePath);

            if (!hasMainUI) existing.Insert(0, new EditorBuildSettingsScene(MainUIScenePath, true));
            if (!hasMap) existing.Add(new EditorBuildSettingsScene(MapScenePath, true));

            EditorBuildSettings.scenes = existing.ToArray();
            Debug.Log($"[KTO] Build Settings updated: {existing.Count} scenes, MainUI={hasMainUI}, Map={hasMap}");
        }

        [MenuItem("KTO/Match Goc/RUN ALL STEPS")]
        public static void RunAll()
        {
            CreateMapScene();
            RefactorMainUIScene();
            UpdateBuildSettings();
            Debug.Log("[KTO] === Match Goc refactor complete ===");
        }

        static void EnsureTags()
        {
            var tagManager = new SerializedObject(AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/TagManager.asset")[0]);
            var tagsProp = tagManager.FindProperty("tags");
            bool hasUICamera = false;
            for (int i = 0; i < tagsProp.arraySize; i++)
            {
                if (tagsProp.GetArrayElementAtIndex(i).stringValue == "UICamera") { hasUICamera = true; break; }
            }
            if (!hasUICamera)
            {
                tagsProp.InsertArrayElementAtIndex(tagsProp.arraySize);
                tagsProp.GetArrayElementAtIndex(tagsProp.arraySize - 1).stringValue = "UICamera";
                tagManager.ApplyModifiedProperties();
                Debug.Log("[KTO] Added 'UICamera' tag to TagManager");
            }
        }
    }
}
