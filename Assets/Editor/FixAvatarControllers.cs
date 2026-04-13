// Fixes broken Animator controller references on avatar prefabs.
// Matches each prefab to its controller by name: M_GB.prefab → M_GB.controller
using UnityEngine;
using UnityEditor;

public static class FixAvatarControllers
{
    const string AvatarFolder = "Assets/Prefabs/Imported/Avatars";
    const string ControllerFolder = "Assets/Animations/loginbg";

    public static string Execute()
    {
        var sb = new System.Text.StringBuilder();
        var guids = AssetDatabase.FindAssets("t:Prefab", new[] { AvatarFolder });
        int fixed_ = 0;

        foreach (var guid in guids)
        {
            var path = AssetDatabase.GUIDToAssetPath(guid);
            var prefab = AssetDatabase.LoadAssetAtPath<GameObject>(path);
            if (prefab == null) continue;

            var anim = prefab.GetComponent<Animator>();
            if (anim == null) continue;

            if (anim.runtimeAnimatorController != null) continue;

            // Try to find matching controller
            string ctrlPath = $"{ControllerFolder}/{prefab.name}.controller";
            var ctrl = AssetDatabase.LoadAssetAtPath<RuntimeAnimatorController>(ctrlPath);
            if (ctrl == null)
            {
                sb.AppendLine($"{prefab.name}: controller not found at {ctrlPath}");
                continue;
            }

            // Fix the reference
            anim.runtimeAnimatorController = ctrl;
            EditorUtility.SetDirty(anim);
            EditorUtility.SetDirty(prefab);
            sb.AppendLine($"{prefab.name}: FIXED → {ctrl.name}");
            fixed_++;
        }

        if (fixed_ > 0)
            AssetDatabase.SaveAssets();

        sb.Insert(0, $"Fixed {fixed_} avatar prefab controllers:\n");
        return sb.ToString();
    }
}
