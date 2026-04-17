// =======================================================================
//  LocalizationApplier.cs — Walk imported prefabs, add Localize components
//  to every Text that contains non-ASCII characters, using the Text's
//  current value as the translation key.
//
//  This mirrors how the original game authors its UI: each Text gets a
//  translation term (often the source-language Chinese string itself),
//  and UIMultiLangConfig/Localize.Refresh() applies the translation at
//  runtime via LanguageModule.Get.
//
//  Menu: KTO → Fix → Add Localize Components to All Imported Prefabs
// =======================================================================
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using KTO.Localization;

public static class LocalizationApplier
{
    [MenuItem("KTO/Fix/Add Localize Components to All Imported Prefabs")]
    public static void Run()
    {
        string[] guids = AssetDatabase.FindAssets("t:Prefab",
            new[] { "Assets/Prefabs/Imported" });

        int totalPrefabs = 0, totalTexts = 0, totalAdded = 0, totalSkipped = 0;

        foreach (var guid in guids)
        {
            string path = AssetDatabase.GUIDToAssetPath(guid);
            if (!path.EndsWith(".prefab")) continue;

            GameObject root = PrefabUtility.LoadPrefabContents(path);
            if (root == null) continue;

            totalPrefabs++;
            bool modified = false;

            var texts = root.GetComponentsInChildren<Text>(includeInactive: true);
            foreach (var t in texts)
            {
                if (t == null) continue;
                totalTexts++;

                // Skip if already has a Localize component
                if (t.GetComponent<Localize>() != null) { totalSkipped++; continue; }

                string value = t.text;
                if (string.IsNullOrEmpty(value)) continue;

                // Only add Localize for strings that contain non-ASCII or
                // numeric-placeholder characters (e.g. Chinese). Pure ASCII
                // digits like "100" / "23:20" are runtime values — skip
                // them so Lua can update them without Localize fighting.
                if (!ShouldLocalize(value)) continue;

                var loc = t.gameObject.AddComponent<Localize>();
                loc.Term = value;
                loc.CaptureFromText = false;
                totalAdded++;
                modified = true;
            }

            if (modified)
            {
                PrefabUtility.SaveAsPrefabAsset(root, path);
                Debug.Log($"[LocalizationApplier] {System.IO.Path.GetFileName(path)}: added Localize");
            }

            PrefabUtility.UnloadPrefabContents(root);
        }

        Debug.Log(
            $"[LocalizationApplier] Done: {totalPrefabs} prefabs scanned, " +
            $"{totalTexts} Text components, {totalAdded} Localize added, " +
            $"{totalSkipped} skipped (already had Localize)");
    }

    /// <summary>
    /// Only add Localize for text that looks like a human-authored label,
    /// not a runtime-dynamic value. Rule: contains any non-ASCII character,
    /// OR is a multi-digit numeric placeholder that matches an entry in
    /// the translations JSON. This covers:
    ///   - "自由"                       → yes (Chinese)
    ///   - "战力值:"                    → yes (Chinese)
    ///   - "Minh Nguyệt Trấn"           → yes (has diacritics > 0x7F)
    ///   - "100"                        → NO unless translated (runtime val)
    ///   - "23:20"                      → NO (pure ASCII)
    ///   - "9999999"                    → NO unless translated
    ///   - "自动寻路中……"              → yes (Chinese + ellipsis)
    ///   - "5318"                       → YES if translations_vi-VN.json has "5318"
    ///                                    (extractor placeholder — see
    ///                                    DetailJSON/UIBag_res_p_27.json)
    ///
    /// The numeric-placeholder branch is what makes baked Chinese strings
    /// that got corrupted to integer-like locKeys during extraction
    /// (5318, 10458, 57440, 29413, 38231, 1896, ...) appear as their
    /// mapped Vietnamese labels at runtime, exactly like the original's
    /// I2.Loc path did.
    /// </summary>
    static bool ShouldLocalize(string value)
    {
        bool hasNonAscii = false;
        foreach (char c in value)
        {
            if (c > 0x7F) { hasNonAscii = true; break; }
        }
        if (hasNonAscii) return true;

        // Pure-digit branch: only localize if we have an explicit translation
        // entry. This prevents runtime-dynamic numbers like "100" / "23:20"
        // from being captured as terms.
        if (IsAllDigits(value))
        {
            if (KTO.Localization.LanguageModule.TermCount == 0)
                KTO.Localization.LanguageModule.LoadLanguage(
                    KTO.Localization.LanguageModule.CurrentLanguageCode());
            return KTO.Localization.LanguageModule.HasTerm(value);
        }
        return false;
    }

    static bool IsAllDigits(string s)
    {
        if (string.IsNullOrEmpty(s)) return false;
        foreach (char c in s) if (c < '0' || c > '9') return false;
        return true;
    }

    /// <summary>
    /// Debug helper: log every Text in every prefab with its translation
    /// lookup result (hit vs miss). Useful for finding untranslated terms.
    /// </summary>
    [MenuItem("KTO/Debug/Report Missing Translations")]
    public static void ReportMissingTranslations()
    {
        // Ensure translations are loaded
        KTO.Localization.LanguageModule.LoadLanguage(KTO.Localization.LanguageModule.CurrentLanguageCode());

        string[] guids = AssetDatabase.FindAssets("t:Prefab",
            new[] { "Assets/Prefabs/Imported" });

        var hits = new System.Collections.Generic.HashSet<string>();
        var misses = new System.Collections.Generic.HashSet<string>();

        foreach (var guid in guids)
        {
            string path = AssetDatabase.GUIDToAssetPath(guid);
            GameObject root = PrefabUtility.LoadPrefabContents(path);
            if (root == null) continue;

            foreach (var t in root.GetComponentsInChildren<Text>(true))
            {
                if (t == null) continue;
                var loc = t.GetComponent<Localize>();
                string key = loc != null && !string.IsNullOrEmpty(loc.Term) ? loc.Term : t.text;
                if (string.IsNullOrEmpty(key)) continue;
                if (!ShouldLocalize(key)) continue;

                if (KTO.Localization.LanguageModule.HasTerm(key)) hits.Add(key);
                else                              misses.Add(key);
            }
            PrefabUtility.UnloadPrefabContents(root);
        }

        Debug.Log($"[LocalizationApplier] Translation coverage: {hits.Count} hits, {misses.Count} misses");
        if (misses.Count > 0)
        {
            var sb = new System.Text.StringBuilder();
            sb.AppendLine("--- MISSING KEYS (add to translations_vi-VN.json) ---");
            foreach (var m in misses) sb.AppendLine($"  \"{m}\": \"{m}\",");
            Debug.Log(sb.ToString());
        }
    }
}
