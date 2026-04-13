using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public static class InspectFireRipped
{
    public static void Execute()
    {
        Debug.Log("[Fr] start");
        var contents = PrefabUtility.LoadPrefabContents("Assets/Prefabs/Imported/UICreateRole.prefab");
        if (contents == null) { Debug.LogError("[Fr] no contents"); return; }

        Transform fire = null;
        foreach (var t in contents.GetComponentsInChildren<Transform>(true))
            if (t.name == "Fire_Effect" && t.parent != null && t.parent.name == "Faction") { fire = t; break; }
        if (fire == null) { Debug.LogError("[Fr] no Fire_Effect"); PrefabUtility.UnloadPrefabContents(contents); return; }
        Debug.Log($"[Fr] Fire_Effect children={fire.childCount} active={fire.gameObject.activeSelf}");

        Walk(fire, 0);

        // Check Animator on Fire_Effect_Ripped
        var ripped = fire.Find("Fire_Effect_Ripped");
        if (ripped != null)
        {
            var anim = ripped.GetComponent<Animator>();
            Debug.Log($"[Fr] Animator: {(anim!=null?$"controller={(anim.runtimeAnimatorController!=null?anim.runtimeAnimatorController.name:"NULL")} cullMode={anim.cullingMode}":"NONE")}");
            foreach (var ps in ripped.GetComponentsInChildren<ParticleSystem>(true))
            {
                var psr = ps.GetComponent<ParticleSystemRenderer>();
                var mat = psr != null ? psr.sharedMaterial : null;
                Debug.Log($"[Fr] PS @ {ps.name}: emit.enabled={ps.emission.enabled} startCol={ps.main.startColor.color} mat={(mat!=null?mat.name:"NULL")} shader={(mat!=null && mat.shader!=null?mat.shader.name:"NULL")} sup={(mat!=null && mat.shader!=null?mat.shader.isSupported.ToString():"-")}");
            }
            foreach (var img in ripped.GetComponentsInChildren<Image>(true))
            {
                var mat = img.material;
                Debug.Log($"[Fr] Img @ {img.name}: a={img.color.a:F2} sprite={(img.sprite!=null?img.sprite.name:"NULL")} mat={(mat!=null?mat.name:"NULL")} shader={(mat!=null&&mat.shader!=null?mat.shader.name:"NULL")} sup={(mat!=null&&mat.shader!=null?mat.shader.isSupported.ToString():"-")}");
            }
        }
        else Debug.LogWarning("[Fr] no Fire_Effect_Ripped child");

        PrefabUtility.UnloadPrefabContents(contents);
        Debug.Log("[Fr] done");
    }

    static void Walk(Transform t, int d)
    {
        var pad = new string(' ', d * 2);
        var sb = new System.Text.StringBuilder();
        sb.Append(pad).Append(t.gameObject.activeSelf ? "*" : "-").Append(t.name);
        foreach (var c in t.GetComponents<Component>())
        {
            if (c == null) { sb.Append(" (null!)"); continue; }
            var n = c.GetType().Name;
            if (n == "RectTransform" || n == "CanvasRenderer" || n == "Transform") continue;
            sb.Append(" [").Append(n).Append("]");
        }
        Debug.Log("[Fr] " + sb);
        foreach (Transform c in t) Walk(c, d + 1);
    }
}
