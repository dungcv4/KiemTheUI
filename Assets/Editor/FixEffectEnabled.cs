// Fixes Effect element Image.enabled to match original bundle (all enabled=true)
// Also ensures sprite=null per bundle
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEditor.SceneManagement;

public static class FixEffectEnabled
{
    public static string Execute()
    {
        if (Application.isPlaying) return "Stop play mode first";

        var cr = GameObject.Find("UICreateRole_Canvas/UICreateRole")
                 ?? GameObject.Find("UICreateRole");
        if (cr == null) return "UICreateRole not found";

        var faction = cr.transform.Find("imgBG/FactionInfo/Faction");
        if (faction == null) return "Faction not found";

        string[] effects = { "Fire_Effect", "Metal_Effect", "Earth_Effect", "Water_Effect", "Wood_Effect" };
        string[] children = { "BG", "RaoDong", "LiuGuang" };
        int fixes = 0;
        var sb = new System.Text.StringBuilder();

        foreach (var ename in effects)
        {
            var effect = faction.Find(ename);
            if (effect == null) continue;

            foreach (var cname in children)
            {
                var child = effect.Find(cname);
                if (child == null) continue;

                var img = child.GetComponent<Image>();
                if (img == null) continue;

                bool changed = false;

                // Enable Image (bundle has m_Enabled=1 for all)
                if (!img.enabled)
                {
                    img.enabled = true;
                    changed = true;
                    sb.AppendLine($"  {ename}/{cname}: enabled Image");
                }

                // Clear sprite (bundle has NULL)
                if (img.sprite != null)
                {
                    img.sprite = null;
                    changed = true;
                    sb.AppendLine($"  {ename}/{cname}: cleared sprite");
                }

                // Fix raycastTarget per bundle:
                // BG, LiuGuang = true; RaoDong = false
                bool shouldRaycast = (cname != "RaoDong");
                if (img.raycastTarget != shouldRaycast)
                {
                    img.raycastTarget = shouldRaycast;
                    changed = true;
                }

                if (changed)
                {
                    EditorUtility.SetDirty(img);
                    fixes++;
                }
            }
        }

        if (fixes > 0)
        {
            EditorSceneManager.MarkSceneDirty(
                UnityEngine.SceneManagement.SceneManager.GetActiveScene());
            EditorSceneManager.SaveOpenScenes();
        }

        sb.Insert(0, $"Fixed {fixes} Image components:\n");
        return sb.ToString();
    }
}
