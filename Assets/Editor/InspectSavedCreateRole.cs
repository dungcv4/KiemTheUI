using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEditor.SceneManagement;

public static class InspectSavedCreateRole
{
    public static void Execute()
    {
        var scene = EditorSceneManager.OpenScene("Assets/CreateRoleScene.unity", OpenSceneMode.Single);
        Debug.Log($"[Inspect] Opened {scene.name} valid={scene.IsValid()}");

        int canvasCount = 0;
        foreach (var root in scene.GetRootGameObjects())
        {
            foreach (var c in root.GetComponentsInChildren<Canvas>(true))
            {
                canvasCount++;
                var t = c.transform;
                string p = t.name;
                while (t.parent != null) { t = t.parent; p = t.name + "/" + p; }
                Debug.Log($"[Inspect] Canvas '{p}' rm={c.renderMode} sort={c.sortingOrder} gr={c.GetComponent<GraphicRaycaster>() != null}");
            }
        }
        Debug.Log($"[Inspect] Total Canvas count = {canvasCount}");

        // Check BackgroundImage raycastTarget
        var bg = GameObject.Find("Background_Canvas/BackgroundImage");
        if (bg != null)
        {
            var img = bg.GetComponent<Image>();
            Debug.Log($"[Inspect] BackgroundImage.raycastTarget = {img.raycastTarget}");
        }
        else Debug.LogError("[Inspect] BackgroundImage NOT FOUND");
    }
}
