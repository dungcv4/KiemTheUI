// Fixes Click_Effect particle sorting order so effects render ABOVE UICreateRole_Canvas.
// UICreateRole_Canvas has sortingOrder=10; particles need sortingOrder >= 11.
// Also sets imgSelected to inactive by default (SelectElement toggles it).
using UnityEngine;
using UnityEditor;
using UnityEngine.Rendering;

public static class FixClickEffectSorting
{
    public static string Execute()
    {
        var sb = new System.Text.StringBuilder();
        string prefabPath = "Assets/Prefabs/Imported/UICreateRole.prefab";
        var contents = PrefabUtility.LoadPrefabContents(prefabPath);
        int fixedSort = 0, fixedActive = 0;

        var allTransforms = contents.GetComponentsInChildren<Transform>(true);
        foreach (var t in allTransforms)
        {
            // Fix ParticleSystemRenderer sorting on M1, M2, M4
            if (t.name == "M1" || t.name == "M4")
            {
                var psr = t.GetComponent<ParticleSystemRenderer>();
                if (psr != null && psr.sortingOrder < 11)
                {
                    psr.sortingOrder = 12;
                    fixedSort++;
                }
            }
            else if (t.name == "M2")
            {
                var psr = t.GetComponent<ParticleSystemRenderer>();
                if (psr != null && psr.sortingOrder < 11)
                {
                    psr.sortingOrder = 11;
                    fixedSort++;
                }
            }
            // Fix MeshRenderer + SortingGroup on M3
            else if (t.name == "M3")
            {
                var sg = t.GetComponent<SortingGroup>();
                if (sg != null && sg.sortingOrder < 11)
                {
                    sg.sortingOrder = 11;
                    fixedSort++;
                }
                var mr = t.GetComponent<MeshRenderer>();
                if (mr != null && mr.sortingOrder < 11)
                {
                    mr.sortingOrder = 11;
                    fixedSort++;
                }
            }
            // Set imgSelected inactive by default (SelectElement activates it).
            // Match any imgSelected that has a Click_Effect child (faction icons).
            else if (t.name == "imgSelected" && t.Find("Click_Effect") != null)
            {
                if (t.gameObject.activeSelf)
                {
                    t.gameObject.SetActive(false);
                    fixedActive++;
                }
            }
        }

        PrefabUtility.SaveAsPrefabAsset(contents, prefabPath);
        PrefabUtility.UnloadPrefabContents(contents);

        sb.AppendLine($"Fixed {fixedSort} renderer sorting orders (→ 11-12)");
        sb.AppendLine($"Set {fixedActive} imgSelected to inactive");
        return sb.ToString();
    }
}
