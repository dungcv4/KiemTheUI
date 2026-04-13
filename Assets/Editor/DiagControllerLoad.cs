using UnityEngine;
using UnityEditor;

public static class DiagControllerLoad
{
    public static string Execute()
    {
        var sb = new System.Text.StringBuilder();

        // Try loading controller directly
        string[] controllerPaths = {
            "Assets/Animations/loginbg/M_GB.controller",
            "Assets/AnimatorController/M_GB.controller"
        };

        foreach (var path in controllerPaths)
        {
            var ctrl = AssetDatabase.LoadAssetAtPath<RuntimeAnimatorController>(path);
            sb.AppendLine($"Controller '{path}': {(ctrl != null ? $"OK name={ctrl.name}" : "NULL")}");
        }

        // Try loading prefab and check its animator
        string prefabPath = "Assets/Prefabs/Imported/Avatars/M_GB.prefab";
        var prefab = AssetDatabase.LoadAssetAtPath<GameObject>(prefabPath);
        if (prefab != null)
        {
            var anim = prefab.GetComponent<Animator>();
            if (anim != null)
            {
                sb.AppendLine($"\nPrefab '{prefabPath}':");
                sb.AppendLine($"  Animator.runtimeAnimatorController: {anim.runtimeAnimatorController?.name ?? "NULL"}");
                sb.AppendLine($"  Animator.enabled: {anim.enabled}");

                // Check serialized property
                var so = new SerializedObject(anim);
                var prop = so.FindProperty("m_Controller");
                if (prop != null)
                {
                    sb.AppendLine($"  SerializedProp m_Controller: objectRef={prop.objectReferenceValue?.name ?? "NULL"}");
                    sb.AppendLine($"  SerializedProp m_Controller.instanceID={prop.objectReferenceInstanceIDValue}");
                }
            }
        }

        // Check all avatar prefabs for null controllers
        string folder = "Assets/Prefabs/Imported/Avatars";
        var guids = AssetDatabase.FindAssets("t:Prefab", new[] { folder });
        int total = 0, nullCtrl = 0;
        foreach (var guid in guids)
        {
            var p = AssetDatabase.GUIDToAssetPath(guid);
            var go = AssetDatabase.LoadAssetAtPath<GameObject>(p);
            if (go == null) continue;
            var a = go.GetComponent<Animator>();
            if (a == null) continue;
            total++;
            if (a.runtimeAnimatorController == null)
            {
                nullCtrl++;
                if (nullCtrl <= 5)
                    sb.AppendLine($"  NULL ctrl: {go.name}");
            }
        }
        sb.AppendLine($"\nAvatar prefabs: {total} total, {nullCtrl} with NULL controller");

        return sb.ToString();
    }
}
