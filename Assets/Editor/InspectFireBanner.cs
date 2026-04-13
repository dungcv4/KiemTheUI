using System.Linq;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public static class InspectFireBanner
{
    public static void Execute()
    {
        var scene = EditorSceneManager.GetActiveScene();
        Transform fire = null;
        foreach (var root in scene.GetRootGameObjects())
        {
            fire = FindByName(root.transform, "Fire_Effect");
            if (fire != null) break;
        }
        if (fire == null) { Debug.Log("[FireBanner] Fire_Effect NOT FOUND in scene"); return; }
        Debug.Log("[FireBanner] Fire_Effect found at " + GetPath(fire) +
                  "  active=" + fire.gameObject.activeInHierarchy);

        Walk(fire, 0);
    }

    static Transform FindByName(Transform t, string name)
    {
        if (t.name == name) return t;
        for (int i = 0; i < t.childCount; i++)
        {
            var r = FindByName(t.GetChild(i), name);
            if (r != null) return r;
        }
        return null;
    }

    static string GetPath(Transform t)
    {
        var p = t.name;
        var c = t.parent;
        while (c != null) { p = c.name + "/" + p; c = c.parent; }
        return p;
    }

    static void Walk(Transform t, int depth)
    {
        var pad = new string(' ', depth * 2);
        var img = t.GetComponent<Image>();
        var anim = t.GetComponent<Animator>();
        var ctrl = t.GetComponent<ImageEffectAnimationController>();
        var rt = t as RectTransform;

        var line = pad + t.name + (t.gameObject.activeSelf ? "" : " [INACTIVE]");
        if (img != null)
        {
            var matName = img.material != null ? img.material.name : "null";
            var shaderName = (img.material != null && img.material.shader != null) ? img.material.shader.name : "null";
            line += "  [Image color=" + img.color + " sprite=" + (img.sprite != null ? img.sprite.name : "null") +
                    " mat=" + matName + " shader=" + shaderName + "]";
        }
        if (anim != null)
        {
            line += "  [Animator " + (anim.runtimeAnimatorController != null ? anim.runtimeAnimatorController.name : "null") +
                    " enabled=" + anim.enabled + "]";
        }
        if (ctrl != null)
        {
            line += "  [Ctrl color=" + ctrl.HDRColor + " bright=" + ctrl.Brightness +
                    " uiMat=" + (ctrl.UiMaterial != null ? ctrl.UiMaterial.name : "null") + "]";
        }
        if (rt != null)
        {
            line += "  rect=(" + rt.anchoredPosition.x + "," + rt.anchoredPosition.y +
                    ") size=(" + rt.sizeDelta.x + "," + rt.sizeDelta.y + ")";
        }
        Debug.Log("[FireBanner] " + line);

        for (int i = 0; i < t.childCount; i++) Walk(t.GetChild(i), depth + 1);
    }
}
