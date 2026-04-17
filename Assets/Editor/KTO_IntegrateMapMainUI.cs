using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace KTO.Editor.MapImport
{
    public static class KTO_IntegrateMapMainUI
    {
        const string MainUIScenePath = "Assets/MainUIScene.unity";
        const string MapPrefabPath = "Assets/Maps/yunzhongzhen1_a/yunzhongzhen1_a.prefab";
        const string MapRootName = "Map";

        static readonly Vector3 MapCenter = new Vector3(42.4f, 26f, 0f);

        [MenuItem("KTO/Map/Integrate yunzhongzhen1_a into MainUIScene")]
        public static void Integrate()
        {
            var scene = EditorSceneManager.OpenScene(MainUIScenePath, OpenSceneMode.Single);

            var prefab = AssetDatabase.LoadAssetAtPath<GameObject>(MapPrefabPath);
            if (prefab == null)
            {
                Debug.LogError("[KTO] Map prefab not found: " + MapPrefabPath);
                return;
            }

            GameObject mapRoot = null;
            foreach (var go in scene.GetRootGameObjects())
            {
                if (go.name == MapRootName) { mapRoot = go; break; }
            }
            if (mapRoot == null)
            {
                mapRoot = new GameObject(MapRootName);
                Undo.RegisterCreatedObjectUndo(mapRoot, "Create Map root");
            }
            else
            {
                for (int i = mapRoot.transform.childCount - 1; i >= 0; i--)
                    Object.DestroyImmediate(mapRoot.transform.GetChild(i).gameObject);
            }
            mapRoot.transform.position = Vector3.zero;
            mapRoot.transform.rotation = Quaternion.identity;
            mapRoot.transform.localScale = Vector3.one;

            var inst = (GameObject)PrefabUtility.InstantiatePrefab(prefab, mapRoot.transform);
            inst.transform.localPosition = Vector3.zero;

            ConfigureWorldCamera(scene);

            EditorSceneManager.MarkSceneDirty(scene);
            EditorSceneManager.SaveScene(scene);

            Debug.Log("[KTO] Map integrated into MainUIScene: " + inst.name);
        }

        static void ConfigureWorldCamera(Scene scene)
        {
            Camera mainCam = null;
            foreach (var go in scene.GetRootGameObjects())
            {
                var cam = go.GetComponentInChildren<Camera>(true);
                if (cam != null && cam.CompareTag("MainCamera")) { mainCam = cam; break; }
            }
            if (mainCam == null)
            {
                var camGO = new GameObject("Main Camera");
                camGO.tag = "MainCamera";
                mainCam = camGO.AddComponent<Camera>();
                camGO.AddComponent<AudioListener>();
            }

            mainCam.orthographic = true;
            mainCam.orthographicSize = 10f;
            mainCam.nearClipPlane = -100f;
            mainCam.farClipPlane = 1000f;
            mainCam.clearFlags = CameraClearFlags.SolidColor;
            mainCam.backgroundColor = new Color(0.05f, 0.05f, 0.05f, 1f);
            mainCam.transform.position = new Vector3(MapCenter.x, MapCenter.y, -50f);
            mainCam.transform.rotation = Quaternion.identity;
        }
    }
}
