// =======================================================================
//  BuildAllImportsReflection.cs — Run every Import_res_p_*.cs via reflection
//
//  Menu: KTO → Build → Run ALL Import_res_p_* Builders
//
//  Finds every public static class named `Import_res_p_<id>` that has a
//  `public static void Build()` method, calls Build() on each.
//
//  Used after the batch Python pipeline generates 500+ Import_*.cs files —
//  this avoids having to maintain a hand-written list.
//
//  After running, also calls AssetDatabase.Refresh() + regenerates the
//  SpriteAtlasMap so the newly-imported prefabs can resolve sprites.
// =======================================================================
using System;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

public static class BuildAllImportsReflection
{
    [MenuItem("KTO/Build/Run ALL Import_res_p_* Builders")]
    public static void Run()
    {
        Debug.Log("[BuildAllImports] Scanning for Import_res_p_* classes…");

        // Scan ALL loaded assemblies (Editor assembly might be separate from
        // the assembly this script compiles into).
        var types = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(a =>
            {
                try { return a.GetTypes(); }
                catch { return new Type[0]; }
            })
            .Where(t => t.IsClass && t.IsPublic && t.Name.StartsWith("Import_res_p_"))
            .OrderBy(t => t.Name)
            .ToList();

        Debug.Log($"[BuildAllImports] Found {types.Count} importer classes");

        int built = 0, failed = 0;
        long t0 = DateTime.UtcNow.Ticks;

        foreach (var t in types)
        {
            var m = t.GetMethod("Build", BindingFlags.Public | BindingFlags.Static);
            if (m == null)
            {
                Debug.LogWarning($"[BuildAllImports] {t.Name} has no Build() method, skipping");
                continue;
            }

            try
            {
                m.Invoke(null, null);
                built++;
                if (built % 25 == 0)
                    Debug.Log($"[BuildAllImports] Progress: {built}/{types.Count}");
            }
            catch (Exception ex)
            {
                failed++;
                Debug.LogWarning($"[BuildAllImports] {t.Name}.Build() threw: {ex.InnerException?.Message ?? ex.Message}");
            }
        }

        AssetDatabase.Refresh();
        double dt = (DateTime.UtcNow.Ticks - t0) / 10000000.0;
        Debug.Log($"[BuildAllImports] Done: {built} built, {failed} failed, {dt:F1}s total");
    }

    /// <summary>
    /// After running import builders, this runs the full post-process chain:
    /// 1. Regenerate SpriteAtlasMap (so new prefab sprite refs resolve)
    /// 2. FixNullSpriteImages (hide placeholder white Images)
    /// 3. LocalizationApplier (wire Localize components to new Text)
    /// </summary>
    [MenuItem("KTO/Build/Run ALL Import + Post-Process")]
    public static void RunFull()
    {
        Run();

        // Regenerate the SpriteAtlasMap since new atlas directories may be in play.
        try { SpriteAtlasMapGenerator.Generate(); }
        catch (Exception ex) { Debug.LogWarning($"[BuildAllImports] SpriteAtlasMap: {ex.Message}"); }

        // Hide null-sprite white-rectangle Images on newly imported prefabs.
        try { FixNullSpriteImages.Run(); }
        catch (Exception ex) { Debug.LogWarning($"[BuildAllImports] FixNullSprites: {ex.Message}"); }

        // Wire Localize components to every Chinese-containing Text.
        try { LocalizationApplier.Run(); }
        catch (Exception ex) { Debug.LogWarning($"[BuildAllImports] LocalizeApplier: {ex.Message}"); }

        // Dump missing translation keys to the console.
        try { LocalizationApplier.ReportMissingTranslations(); }
        catch (Exception ex) { Debug.LogWarning($"[BuildAllImports] ReportMissing: {ex.Message}"); }

        Debug.Log("[BuildAllImports] Full pipeline complete.");
    }
}
