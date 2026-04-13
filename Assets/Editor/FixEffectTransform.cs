using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using System.Collections.Generic;

public static class FixEffectTransform
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
        int fixes = 0;
        var sb = new System.Text.StringBuilder();

        foreach (var ename in effects)
        {
            var effect = faction.Find(ename);
            if (effect == null) { sb.AppendLine($"  {ename}: NOT FOUND"); continue; }

            if (effect is RectTransform)
            {
                sb.AppendLine($"  {ename}: already RectTransform");
                continue;
            }

            // Need to convert Transform → RectTransform
            // Approach: create new GO with RectTransform, reparent children,
            // copy Animator + other components, destroy old GO
            var oldGO = effect.gameObject;
            int sibIndex = effect.GetSiblingIndex();
            bool wasActive = oldGO.activeSelf;

            // Collect children
            var children = new List<Transform>();
            for (int i = effect.childCount - 1; i >= 0; i--)
                children.Add(effect.GetChild(i));

            // Collect Animator info
            var oldAnim = oldGO.GetComponent<Animator>();
            RuntimeAnimatorController animCtrl = null;
            if (oldAnim != null)
                animCtrl = oldAnim.runtimeAnimatorController;

            // Create new GO
            var newGO = new GameObject(ename);
            var newRT = newGO.AddComponent<RectTransform>();
            newGO.transform.SetParent(faction, false);
            newGO.transform.SetSiblingIndex(sibIndex);

            // Configure RectTransform to fill parent
            newRT.anchorMin = Vector2.zero;
            newRT.anchorMax = Vector2.one;
            newRT.offsetMin = Vector2.zero;
            newRT.offsetMax = Vector2.zero;
            newRT.localScale = Vector3.one;

            // Reparent children
            foreach (var child in children)
                child.SetParent(newGO.transform, false);

            // Add Animator
            if (animCtrl != null)
            {
                var newAnim = newGO.AddComponent<Animator>();
                newAnim.runtimeAnimatorController = animCtrl;
            }

            // Copy SortingGroup if present
            var oldSG = oldGO.GetComponent<UnityEngine.Rendering.SortingGroup>();
            if (oldSG != null)
            {
                var newSG = newGO.AddComponent<UnityEngine.Rendering.SortingGroup>();
                newSG.sortingLayerID = oldSG.sortingLayerID;
                newSG.sortingOrder = oldSG.sortingOrder;
            }

            newGO.SetActive(wasActive);

            // Destroy old
            Object.DestroyImmediate(oldGO);

            fixes++;
            sb.AppendLine($"  {ename}: converted to RectTransform (stretch fill)");
        }

        if (fixes > 0)
        {
            EditorSceneManager.MarkSceneDirty(
                UnityEngine.SceneManagement.SceneManager.GetActiveScene());
            EditorSceneManager.SaveOpenScenes();
        }

        sb.Insert(0, $"Converted {fixes} Effects to RectTransform:\n");
        return sb.ToString();
    }
}
