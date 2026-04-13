using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEditor.SceneManagement;

public static class ClearEffectSprites
{
    public static string Execute()
    {
        var cr = GameObject.Find("UICreateRole_Canvas/UICreateRole")
                 ?? GameObject.Find("UICreateRole");
        if (cr == null) return "UICreateRole not found";

        var faction = cr.transform.Find("imgBG/FactionInfo/Faction");
        if (faction == null) return "Faction not found";

        string[] effects = { "Fire_Effect", "Metal_Effect", "Earth_Effect", "Water_Effect", "Wood_Effect" };
        string[] children = { "BG", "RaoDong", "LiuGuang" };
        int cleared = 0;

        foreach (var ename in effects)
        {
            var effect = faction.Find(ename);
            if (effect == null) continue;
            foreach (var cname in children)
            {
                var child = effect.Find(cname);
                if (child == null) continue;
                var img = child.GetComponent<Image>();
                if (img != null && img.sprite != null)
                {
                    img.sprite = null;
                    EditorUtility.SetDirty(img);
                    cleared++;
                }
            }
        }

        if (cleared > 0)
        {
            EditorSceneManager.MarkSceneDirty(
                UnityEngine.SceneManagement.SceneManager.GetActiveScene());
            EditorSceneManager.SaveOpenScenes();
        }

        return $"Cleared {cleared} sprites";
    }
}
