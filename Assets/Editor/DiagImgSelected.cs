using UnityEngine;
using UnityEditor;

public static class DiagImgSelected
{
    public static string Execute()
    {
        var sb = new System.Text.StringBuilder();
        string prefabPath = "Assets/Prefabs/Imported/UICreateRole.prefab";
        var contents = PrefabUtility.LoadPrefabContents(prefabPath);

        // Find all imgSelected
        var allT = contents.GetComponentsInChildren<Transform>(true);
        int total = 0;
        foreach (var t in allT)
        {
            if (t.name != "imgSelected") continue;
            total++;
            string parent = t.parent != null ? t.parent.name : "ROOT";
            bool hasClickEffect = t.Find("Click_Effect") != null;
            sb.AppendLine($"  imgSelected parent={parent}, active={t.gameObject.activeSelf}, hasClickEffect={hasClickEffect}");
        }

        // Find all Click_Effect
        int ceTotal = 0;
        foreach (var t in allT)
        {
            if (t.name != "Click_Effect") continue;
            ceTotal++;
            string parent = t.parent != null ? t.parent.name : "ROOT";
            string gparent = t.parent?.parent != null ? t.parent.parent.name : "ROOT";
            bool hasPS = t.GetComponent<ParticleSystem>() != null;
            sb.AppendLine($"  Click_Effect parent={parent}, gparent={gparent}, active={t.gameObject.activeSelf}, hasPS={hasPS}");
        }

        PrefabUtility.UnloadPrefabContents(contents);
        sb.Insert(0, $"imgSelected: {total} total, Click_Effect: {ceTotal} total\n");
        return sb.ToString();
    }
}
