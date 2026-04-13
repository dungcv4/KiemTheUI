using UnityEngine;
using UnityEngine.UI;

public static class DiagAvatarRuntime
{
    public static string Execute()
    {
        var sb = new System.Text.StringBuilder();
        sb.AppendLine($"IsPlaying: {Application.isPlaying}");

        var lbg = GameObject.Find("UILoginBG");
        if (lbg == null) return "UILoginBG not found";

        var character = lbg.transform.Find("Character");
        if (character == null) return "UILoginBG/Character not found";

        var charCanvas = character.GetComponent<Canvas>();
        sb.AppendLine($"Character Canvas: enabled={charCanvas?.enabled}, override={charCanvas?.overrideSorting}, order={charCanvas?.sortingOrder}, layer={charCanvas?.sortingLayerName}");

        var host = character.Find("_AvatarHost");
        if (host == null) return sb + "\n_AvatarHost not found";

        sb.AppendLine($"_AvatarHost childCount={host.childCount}");

        for (int i = 0; i < host.childCount; i++)
        {
            var child = host.GetChild(i);
            sb.Append($"\n  [{child.name}] active={child.gameObject.activeSelf}");

            var rt = child.GetComponent<RectTransform>();
            if (rt != null)
                sb.Append($", pos=({rt.anchoredPosition.x:F1},{rt.anchoredPosition.y:F1}), size=({rt.sizeDelta.x:F0}x{rt.sizeDelta.y:F0})");

            var img = child.GetComponent<Image>();
            if (img != null)
                sb.Append($", sprite={img.sprite?.name ?? "NULL"}, enabled={img.enabled}");

            var anim = child.GetComponent<Animator>();
            if (anim != null)
            {
                sb.Append($", animator.enabled={anim.enabled}");
                sb.Append($", ctrl={anim.runtimeAnimatorController?.name ?? "NULL"}");
                sb.Append($", isInitialized={anim.isInitialized}");
                sb.Append($", hasTransformHierarchy={anim.hasTransformHierarchy}");

                if (anim.isInitialized && anim.runtimeAnimatorController != null)
                {
                    var ci = anim.GetCurrentAnimatorClipInfo(0);
                    if (ci != null && ci.Length > 0)
                        sb.Append($", playing={ci[0].clip.name}(w={ci[0].weight:F2})");
                    else
                        sb.Append(", playing=NONE");

                    var si = anim.GetCurrentAnimatorStateInfo(0);
                    sb.Append($", stateHash={si.shortNameHash}, normalizedTime={si.normalizedTime:F2}");
                }
                else
                {
                    sb.Append(", NOT INITIALIZED or NO CONTROLLER");
                }
            }
            sb.AppendLine();
        }

        // Check CharacterPortrait visibility
        var cr = GameObject.Find("UICreateRole_Canvas/UICreateRole");
        if (cr != null)
        {
            var portrait = cr.transform.Find("imgBG/CharacterPortrait");
            if (portrait != null)
            {
                sb.AppendLine($"\nCharacterPortrait: active={portrait.gameObject.activeSelf}");
                for (int i = 0; i < portrait.childCount; i++)
                {
                    var ch = portrait.GetChild(i);
                    sb.Append($"  {ch.name}: active={ch.gameObject.activeSelf}");
                    var chImg = ch.GetComponent<Image>();
                    if (chImg != null)
                        sb.Append($", sprite={chImg.sprite?.name ?? "NULL"}, enabled={chImg.enabled}");
                    sb.AppendLine();
                }
            }
        }

        return sb.ToString();
    }
}
