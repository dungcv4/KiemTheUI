using UnityEngine;

public static class CleanupAndCount
{
    public static void Run()
    {
        // Count BEFORE.
        int before = 0;
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
        {
            if (t.name == "UILoginBG" || t.name == "UILoginBG_VFX") before++;
        }
        Debug.Log($"[CleanupAndCount] BEFORE cleanup: {before} UILoginBG-roots in scene");

        // Destroy ALL of them — both renamed and unrenamed.
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
        {
            if (t == null) continue;
            if (t.name == "UILoginBG" || t.name == "UILoginBG_VFX")
            {
                Object.DestroyImmediate(t.gameObject);
            }
        }

        int after = 0;
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
        {
            if (t == null) continue;
            if (t.name == "UILoginBG" || t.name == "UILoginBG_VFX") after++;
        }
        Debug.Log($"[CleanupAndCount] AFTER cleanup: {after} UILoginBG-roots in scene");
    }
}
