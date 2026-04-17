using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEditor.SceneManagement;

public static class FixCameraStack
{
    public static void StopPlay()
    {
        if (EditorApplication.isPlaying)
        {
            EditorApplication.isPlaying = false;
            Debug.Log("[FixCameraStack] Stop play requested");
        }
        else
        {
            Debug.Log("[FixCameraStack] Not in play mode");
        }
    }

    public static void Apply()
    {
        if (EditorApplication.isPlaying)
        {
            Debug.LogError("[FixCameraStack] Exit play mode first");
            return;
        }
        var scenePath = "Assets/MainUIScene.unity";
        var scene = EditorSceneManager.OpenScene(scenePath, OpenSceneMode.Single);

        Camera scene_cam = null, ui_cam = null;
        foreach (var root in scene.GetRootGameObjects())
        {
            if (root.name == "SceneCamera") scene_cam = root.GetComponent<Camera>();
            else if (root.name == "UICamera") ui_cam = root.GetComponent<Camera>();
        }
        if (scene_cam == null || ui_cam == null)
        {
            Debug.LogError($"[FixCameraStack] Missing camera (scene={scene_cam} ui={ui_cam})");
            return;
        }

        var sceneData = scene_cam.GetUniversalAdditionalCameraData();
        var uiData = ui_cam.GetUniversalAdditionalCameraData();
        uiData.renderType = CameraRenderType.Overlay;

        sceneData.cameraStack.Clear();
        sceneData.cameraStack.Add(ui_cam);

        EditorUtility.SetDirty(sceneData);
        EditorUtility.SetDirty(uiData);
        EditorUtility.SetDirty(scene_cam);
        EditorUtility.SetDirty(ui_cam);
        EditorSceneManager.MarkSceneDirty(scene);
        EditorSceneManager.SaveScene(scene);

        Debug.Log($"[FixCameraStack] Applied: SceneCamera stack=[{ui_cam.name}], UICamera.renderType={uiData.renderType}");
    }
}
