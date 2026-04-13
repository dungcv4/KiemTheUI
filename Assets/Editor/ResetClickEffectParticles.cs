// Removes existing ParticleSystem/MeshFilter/MeshRenderer/SortingGroup from
// Click_Effect children so SetupClickEffectParticles can re-add them with
// corrected values.
using UnityEngine;
using UnityEditor;
using UnityEngine.Rendering;

public static class ResetClickEffectParticles
{
    public static string Execute()
    {
        string prefabPath = "Assets/Prefabs/Imported/UICreateRole.prefab";
        var contents = PrefabUtility.LoadPrefabContents(prefabPath);
        int removed = 0;

        var allT = contents.GetComponentsInChildren<Transform>(true);
        foreach (var t in allT)
        {
            if (t.name == "Click_Effect" || t.name == "M1" || t.name == "M2" || t.name == "M4")
            {
                var ps = t.GetComponent<ParticleSystem>();
                if (ps != null)
                {
                    // Must destroy renderer first, then PS
                    var psr = t.GetComponent<ParticleSystemRenderer>();
                    if (psr != null) Object.DestroyImmediate(psr);
                    Object.DestroyImmediate(ps);
                    removed++;
                }
            }
            else if (t.name == "M3")
            {
                var sg = t.GetComponent<SortingGroup>();
                if (sg != null) { Object.DestroyImmediate(sg); removed++; }
                var mr = t.GetComponent<MeshRenderer>();
                if (mr != null) { Object.DestroyImmediate(mr); removed++; }
                var mf = t.GetComponent<MeshFilter>();
                if (mf != null) { Object.DestroyImmediate(mf); removed++; }
            }
        }

        PrefabUtility.SaveAsPrefabAsset(contents, prefabPath);
        PrefabUtility.UnloadPrefabContents(contents);
        return $"Reset: removed {removed} components";
    }
}
