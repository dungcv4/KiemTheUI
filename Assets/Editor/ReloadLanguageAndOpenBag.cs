// Re-load translations (lost on domain reload) + refresh open Localize +
// re-open UIBag. Menu: KTO → Debug → Reload Lang + Open Bag
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using Lang = KTO.Localization.LanguageModule;

public static class ReloadLanguageAndOpenBag
{
    [MenuItem("KTO/Debug/Reload Lang + Open Bag")]
    public static void Run()
    {
        if (!Application.isPlaying)
        {
            Debug.LogWarning("[ReloadLangOpenBag] Editor must be in Play mode.");
            return;
        }
        Lang.LoadLanguage(Lang.CurrentLanguageCode());
        Debug.Log($"[ReloadLangOpenBag] Loaded {Lang.TermCount} terms");

        // Refresh every Localize currently in the scene
        var all = Object.FindObjectsOfType<KTO.Localization.Localize>(includeInactive: true);
        foreach (var l in all) l.ApplyTranslation();
        Debug.Log($"[ReloadLangOpenBag] Refreshed {all.Length} Localize components");

        // Close + re-open bag so labels re-run
        KTO.UI.UIBagController.Instance?.Close();
        KTO.UI.UIBagController.Open(KTO.UI.UIBagController.PanelType.Bag);
    }
}
