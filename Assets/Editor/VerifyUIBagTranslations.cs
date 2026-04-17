// =======================================================================
//  VerifyUIBagTranslations.cs — One-shot sanity check for the UIBag
//  translation pipeline. Loads the vi-VN JSON, looks up the keys the
//  user complained were missing, and reports hit/miss.
//
//  Menu: KTO → Debug → Verify UIBag Translations
// =======================================================================
using UnityEditor;
using UnityEngine;
// Alias — the global namespace has a stub `LanguageModule` (AssetRipper
// output) that shadows KTO.Localization.LanguageModule when both are in
// scope. Alias to the real one.
using Lang = KTO.Localization.LanguageModule;

public static class VerifyUIBagTranslations
{
    [MenuItem("KTO/Debug/Verify UIBag Translations")]
    public static void Run()
    {
        Lang.LoadLanguage(Lang.CurrentLanguageCode());
        Debug.Log($"[VerifyUIBag] Loaded {Lang.TermCount} terms");

        string[] keys = {
            // Tab labels (user-reported missing)
            "UIBAG_TAB_BAG", "UIBAG_TAB_ATTRIBUTE", "UIBAG_TAB_REPUTATION",
            "UIBAG_TAB_HORSE", "UIBAG_TAB_CLOSET", "UIBAG_TITLE",
            // Numeric placeholders the user saw on-screen
            "10458", "57440", "24723", "36033", "29413", "38231", "1896",
            // Common numeric placeholders that leak into item cells
            "5318", "2695", "7569",
            // Chinese keys used elsewhere in the panel
            "属性", "潜能", "基础属性", "推荐加点", "生命", "内力", "攻击力",
        };

        int hits = 0, misses = 0;
        foreach (var k in keys)
        {
            bool has = Lang.HasTerm(k);
            if (has) hits++; else misses++;
            string val = Lang.Get(k);
            string flag = has ? "OK" : "MISS";
            Debug.Log($"[VerifyUIBag] [{flag}] {k} → {val}");
        }
        Debug.Log($"[VerifyUIBag] Summary: {hits}/{keys.Length} hits, {misses} misses");
    }
}
