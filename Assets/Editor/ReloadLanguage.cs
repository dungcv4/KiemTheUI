using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public static class ReloadLanguage
{
    [MenuItem("KTO/Fix/Reload Language + Refresh All Localize")]
    public static void Run()
    {
        // 1) Force re-read of translations_vi-VN.json
        KTO.Localization.LanguageModule.LoadLanguage("vi-VN");
        Debug.Log($"[ReloadLanguage] Re-loaded: TermCount={KTO.Localization.LanguageModule.TermCount}");

        // 2) Walk every active Localize in the scene and re-apply it so the
        //    HUD updates without having to exit+re-enter play mode.
        var all = GameObject.FindObjectsOfType<KTO.Localization.Localize>(includeInactive: true);
        int applied = 0;
        foreach (var l in all)
        {
            if (l == null) continue;
            l.ApplyTranslation();
            applied++;
        }
        Debug.Log($"[ReloadLanguage] Refreshed {applied} Localize components");
    }
}
