// =======================================================================
//  SpriteAtlasMap.cs — Sprite name → atlas bundle path resolution
//
//  DEVIATION — not a direct class in the original source
//  Reason: Original uses BundleManager.s_fileAbInfo (populated from
//  AssetBundleManifest at Init) to resolve any asset path to its bundle.
//  We use a simpler approach: a JSON file mapping sprite names to atlas
//  bundle paths, generated at build time by SpriteAtlasMapGenerator.
//
//  Usage:
//    string bundlePath = SpriteAtlasMap.GetBundlePath("img_dialogbox");
//    // returns "ui/atlas/guide/res_a_1"
// =======================================================================

using System;
using System.Collections.Generic;
using UnityEngine;

namespace KTO.Resource
{
    public static class SpriteAtlasMap
    {
        static Dictionary<string, string> _map; // spriteName → bundlePath
        static bool _loaded;

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        static void ResetStatic() { _map = null; _loaded = false; }

        /// <summary>
        /// Get the atlas bundle path for a sprite name.
        /// Returns null if not found.
        /// </summary>
        public static string GetBundlePath(string spriteName)
        {
            EnsureLoaded();
            if (_map != null && _map.TryGetValue(spriteName, out string bundlePath))
                return bundlePath;
            return null;
        }

        /// <summary>
        /// Try all known atlas bundles for a sprite name.
        /// Returns the loaded Sprite or null.
        ///
        /// When the incoming name (from XML Icon="…") doesn't match exactly,
        /// we try a few common naming variants the KTO atlas build pipeline
        /// produces:
        ///   - exact name
        ///   - name + "_0"          (atlas-packing variant suffix)
        ///   - name without trailing "_s"
        ///   - (name without "_s") + "_0"
        ///
        /// This mirrors the original game's loader — same atlas→sprite-by-name
        /// lookup — with the known XML↔bundle naming drift accommodated so
        /// more than just 28/1544 XML icon names resolve.
        /// </summary>
        public static Sprite LoadSpriteByName(string spriteName)
        {
            if (string.IsNullOrEmpty(spriteName)) return null;
            EnsureLoaded();

            // Variant candidates in preference order
            var candidates = new[] {
                spriteName,
                spriteName + "_0",
                spriteName.EndsWith("_s") ? spriteName.Substring(0, spriteName.Length - 2) : null,
                spriteName.EndsWith("_s") ? spriteName.Substring(0, spriteName.Length - 2) + "_0" : null,
            };

            foreach (var cand in candidates)
            {
                if (string.IsNullOrEmpty(cand)) continue;

                // 1. Pre-built map
                string bundlePath = GetBundlePath(cand);
                if (bundlePath != null)
                {
                    var s = ResourceModule.LoadSync<Sprite>(bundlePath, cand);
                    if (s != null) return s;
                }

                // 2. Brute-force known atlases (caches on hit)
                foreach (var atlas in _knownAtlases)
                {
                    var s = ResourceModule.LoadSync<Sprite>(atlas, cand);
                    if (s != null)
                    {
                        if (_map == null) _map = new Dictionary<string, string>();
                        _map[cand] = atlas;
                        return s;
                    }
                }
            }

            return null;
        }

        // Known atlas bundle paths (matches BundleBuildPipeline atlas dirs)
        static readonly string[] _knownAtlases =
        {
            "ui/atlas/common/res_a_1",
            "ui/atlas/common_btn/res_a_1",
            "ui/atlas/guide/res_a_1",
            "ui/atlas/hud/res_a_1",
            "ui/atlas/loginbg/res_a_1",
            "ui/atlas/npcdialog/res_a_1",
            "ui/atlas/createrole/res_a_1",
            "ui/atlas/faction_icon/res_a_1",
            "ui/atlas/selectrole/res_a_1",
            "ui/atlas/character_stand/res_a_1",
            "ui/atlas/scene_bg/res_a_1",
            "ui/atlas/minimap/res_a_1",
            "ui/atlas/worldmap/res_a_1",
            "ui/atlas/chat/res_a_1",
            "ui/atlas/activity/res_a_1",
            "ui/atlas/welfare/res_a_1",
            // Item icons — 2,470 sprites extracted from
            // KTO_Resources/assets/Bundles/Android/ui/icon/item/res_a_1..7.ab
            "ui/atlas/item/res_a_1",
        };

        static void EnsureLoaded()
        {
            if (_loaded) return;
            _loaded = true;

            var ta = Resources.Load<TextAsset>("SpriteAtlasMap");
            if (ta != null)
            {
                try
                {
                    var wrapper = JsonUtility.FromJson<MapWrapper>(ta.text);
                    _map = new Dictionary<string, string>(wrapper.entries.Length);
                    foreach (var e in wrapper.entries)
                        _map[e.sprite] = e.bundle;
                    Debug.Log($"[SpriteAtlasMap] Loaded {_map.Count} entries");
                }
                catch (Exception ex)
                {
                    Debug.LogWarning($"[SpriteAtlasMap] Parse error: {ex.Message}");
                }
            }
            else
            {
                Debug.Log("[SpriteAtlasMap] No Resources/SpriteAtlasMap.json — will brute-force atlas lookup");
                _map = new Dictionary<string, string>();
            }
        }

        [Serializable]
        class MapWrapper { public MapEntry[] entries; }

        [Serializable]
        class MapEntry { public string sprite; public string bundle; }
    }
}
