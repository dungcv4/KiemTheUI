using UnityEngine;
using System.Text;

// Inspect the F_EM Animator state and verify whether the runtime sprite
// is being driven by the animation curve or stuck on the static prefab
// sprite. M_SL (which renders correctly) uses the same attribute name
// but resolves to .asset versions with trimmed rect 425x425.
public static class _DiagFEMAnimator
{
    public static string Execute()
    {
        var sb = new StringBuilder();
        Transform fem = null;
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
            if (t.name == "F_EM" && t.gameObject.activeInHierarchy) { fem = t; break; }
        if (fem == null) { sb.AppendLine("F_EM NOT FOUND"); Debug.Log(sb.ToString()); return sb.ToString(); }

        var anim = fem.GetComponent<Animator>();
        if (anim == null) { sb.AppendLine("Animator MISSING"); Debug.Log(sb.ToString()); return sb.ToString(); }
        sb.AppendLine($"Animator: enabled={anim.enabled} speed={anim.speed} updateMode={anim.updateMode}");
        sb.AppendLine($"  controller={(anim.runtimeAnimatorController!=null?anim.runtimeAnimatorController.name:"NULL")}");
        sb.AppendLine($"  layerCount={anim.layerCount}");
        if (anim.layerCount > 0)
        {
            var info = anim.GetCurrentAnimatorStateInfo(0);
            sb.AppendLine($"  currentState shortNameHash={info.shortNameHash} length={info.length} normalizedTime={info.normalizedTime}");
            var clips = anim.GetCurrentAnimatorClipInfo(0);
            sb.AppendLine($"  currentClips count={clips.Length}");
            foreach (var ci in clips)
                sb.AppendLine($"    clip={(ci.clip!=null?ci.clip.name:"null")} weight={ci.weight}");
        }

        var img = fem.GetComponent<UnityEngine.UI.Image>();
        if (img != null && img.sprite != null)
        {
            sb.AppendLine($"  sprite.name={img.sprite.name}");
            sb.AppendLine($"  sprite.rect={img.sprite.rect}");
            sb.AppendLine($"  sprite.texture.name={(img.sprite.texture!=null?img.sprite.texture.name:"null")}");
            sb.AppendLine($"  sprite.texture.size={(img.sprite.texture!=null?$"{img.sprite.texture.width}x{img.sprite.texture.height}":"null")}");
        }

        // Force animator update and re-check
        if (anim.enabled)
        {
            anim.Update(0.5f); // advance half second
            sb.AppendLine("--- After Update(0.5) ---");
            if (img != null && img.sprite != null)
            {
                sb.AppendLine($"  sprite.name={img.sprite.name}");
                sb.AppendLine($"  sprite.rect={img.sprite.rect}");
                sb.AppendLine($"  sprite.texture={(img.sprite.texture!=null?img.sprite.texture.name:"null")}");
            }
        }

        Debug.Log(sb.ToString());
        return sb.ToString();
    }
}
