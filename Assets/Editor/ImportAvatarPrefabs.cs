// ImportAvatarPrefabs
// ===================
// Builds 38 KTO faction avatar prefabs from
//   Assets/Editor/avatars.json  + Assets/Sprite/Avatars/<name>/*.png
//
// Each prefab is a UI GameObject with RectTransform + Image + SpriteFrameAnimator,
// configured from the source bundle's RectTransform (anchoredPosition / sizeDelta /
// pivot) and pre-populated with stand_frames (loop) and action_frames (one-shot).
//
// Output: Assets/Prefabs/Imported/Avatars/<avatar>.prefab  (38 files)
//
// Menu:
//   KTO/Import/Avatar Prefabs (all 38)
//
// Step 0 of the routine reimports every PNG under Assets/Sprite/Avatars/ as
// TextureImporterType.Sprite — they were copied in as default Texture2D, so
// AssetDatabase.LoadAssetAtPath<Sprite> would otherwise return null.

using System;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public static class ImportAvatarPrefabs
{
    const string kJsonPath   = "Assets/Editor/avatars.json";
    const string kSpriteRoot = "Assets/Sprite/Avatars";
    const string kPrefabRoot = "Assets/Prefabs/Imported/Avatars";
    const float  kStandFps   = 12f;
    const float  kActionFps  = 24f;

    [MenuItem("KTO/Import/Avatar Prefabs (all 38)")]
    public static void ImportAll()
    {
        if (!File.Exists(kJsonPath))
        {
            Debug.LogError($"[ImportAvatars] Missing {kJsonPath}");
            return;
        }

        // ---- Step 0: ensure all sprite PNGs are imported as Sprite ----
        ReimportAvatarSprites();

        // ---- Step 1: ensure output folder exists ----
        if (!AssetDatabase.IsValidFolder("Assets/Prefabs/Imported"))
            AssetDatabase.CreateFolder("Assets/Prefabs", "Imported");
        if (!AssetDatabase.IsValidFolder(kPrefabRoot))
            AssetDatabase.CreateFolder("Assets/Prefabs/Imported", "Avatars");

        // ---- Step 2: parse JSON and build prefabs ----
        var json = File.ReadAllText(kJsonPath);
        var avatars = MiniJson.Parse(json) as Dictionary<string, object>;
        if (avatars == null) { Debug.LogError("[ImportAvatars] Failed to parse avatars.json"); return; }

        int ok = 0, fail = 0;
        foreach (var kv in avatars)
        {
            string name = kv.Key;
            var meta = kv.Value as Dictionary<string, object>;
            if (meta == null) { fail++; continue; }
            try
            {
                BuildAvatarPrefab(name, meta);
                ok++;
            }
            catch (Exception e)
            {
                Debug.LogError($"[ImportAvatars] {name}: {e.Message}\n{e.StackTrace}");
                fail++;
            }
        }

        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
        Debug.Log($"[ImportAvatars] Done. ok={ok} fail={fail} → {kPrefabRoot}");
    }

    static void ReimportAvatarSprites()
    {
        var guids = AssetDatabase.FindAssets("t:Texture2D", new[] { kSpriteRoot });
        int changed = 0;
        foreach (var g in guids)
        {
            var path = AssetDatabase.GUIDToAssetPath(g);
            var ti = AssetImporter.GetAtPath(path) as TextureImporter;
            if (ti == null) continue;
            bool dirty = false;
            if (ti.textureType != TextureImporterType.Sprite) { ti.textureType = TextureImporterType.Sprite; dirty = true; }
            if (ti.spriteImportMode != SpriteImportMode.Single) { ti.spriteImportMode = SpriteImportMode.Single; dirty = true; }
            if (ti.alphaIsTransparency != true) { ti.alphaIsTransparency = true; dirty = true; }
            if (ti.mipmapEnabled) { ti.mipmapEnabled = false; dirty = true; }
            if (dirty)
            {
                ti.SaveAndReimport();
                changed++;
            }
        }
        Debug.Log($"[ImportAvatars] Reimported {changed} textures as Sprite (of {guids.Length} found in {kSpriteRoot})");
    }

    static void BuildAvatarPrefab(string avatarName, Dictionary<string, object> meta)
    {
        string spriteDir = (meta.ContainsKey("sprite_dir") ? meta["sprite_dir"] as string : avatarName) ?? avatarName;
        string defaultSprite = meta.ContainsKey("default_sprite") ? meta["default_sprite"] as string : null;
        var standList  = meta.ContainsKey("stand_frames")  ? meta["stand_frames"]  as List<object> : null;
        var actionList = meta.ContainsKey("action_frames") ? meta["action_frames"] as List<object> : null;
        var rect = meta.ContainsKey("rect") ? meta["rect"] as Dictionary<string, object> : null;

        // Resolve sprites. The JSON's stand_frames/action_frames lists are
        // unreliable — many entries only contain 1 frame because the original
        // bundle parser skipped over Unity Tuanjie typetree extensions. Trust
        // the filesystem instead: scan the sprite folder for *_stand_*.png /
        // *_action_*.png and sort by name (zero-padded frame indices sort
        // correctly alphabetically).
        var standSprites  = ScanFramesByPattern(spriteDir, "_stand_");
        var actionSprites = ScanFramesByPattern(spriteDir, "_action_");
        // Fall back to JSON list only if filesystem scan came up empty.
        if (standSprites.Length == 0)  standSprites  = LoadSpriteList(spriteDir, standList);
        if (actionSprites.Length == 0) actionSprites = LoadSpriteList(spriteDir, actionList);

        Sprite defSprite = null;
        if (!string.IsNullOrEmpty(defaultSprite))
        {
            defSprite = LoadSprite(spriteDir, defaultSprite);
        }
        if (defSprite == null && standSprites.Length > 0) defSprite = standSprites[0];

        if (defSprite == null)
        {
            Debug.LogWarning($"[ImportAvatars] {avatarName}: no sprites found in {kSpriteRoot}/{spriteDir}, skipping");
            return;
        }

        // Build GameObject
        var go = new GameObject(avatarName, typeof(RectTransform));
        var rt = go.GetComponent<RectTransform>();

        Vector2 anchorMin = ReadVec2(rect, "anchorMin", 0.5f, 0.5f);
        Vector2 anchorMax = ReadVec2(rect, "anchorMax", 0.5f, 0.5f);
        Vector2 pivot     = ReadVec2(rect, "pivot",     0.5f, 0.5f);
        Vector2 pos       = ReadVec2(rect, "anchoredPosition", 0f, 0f);
        Vector2 size      = ReadVec2(rect, "sizeDelta", 384f, 512f);

        rt.anchorMin = anchorMin;
        rt.anchorMax = anchorMax;
        rt.pivot     = pivot;
        rt.anchoredPosition = pos;
        rt.sizeDelta = size;
        rt.localScale = Vector3.one;

        var img = go.AddComponent<Image>();
        img.sprite = defSprite;
        img.preserveAspect = false;
        img.raycastTarget  = false;
        img.SetNativeSize();
        // SetNativeSize overwrites sizeDelta — restore the bundle's sizeDelta
        rt.sizeDelta = size;

        var anim = go.AddComponent<SpriteFrameAnimator>();
        anim.fps = kStandFps;
        anim.actionFps = kActionFps;
        anim.loop = true;
        anim.frames = standSprites.Length > 0 ? standSprites : new Sprite[] { defSprite };
        anim.actionFrames = actionSprites;

        // Save prefab
        string prefabPath = $"{kPrefabRoot}/{avatarName}.prefab";
        PrefabUtility.SaveAsPrefabAsset(go, prefabPath);
        UnityEngine.Object.DestroyImmediate(go);

        string kind = (actionSprites.Length > 0 || standSprites.Length > 1) ? "ANIM" : "STATIC";
        Debug.Log($"[ImportAvatars] {avatarName,-6} {kind,-6}  stand={standSprites.Length} action={actionSprites.Length}  size={size.x}x{size.y} pos={pos}  → {prefabPath}");
    }

    // Scan Assets/Sprite/Avatars/<dir>/ for sprites whose filename contains
    // `pattern` (e.g. "_stand_" or "_action_"), sort alphabetically, return.
    // Frame numbers are zero-padded so alpha sort == numeric sort.
    static Sprite[] ScanFramesByPattern(string dir, string pattern)
    {
        string folder = $"{kSpriteRoot}/{dir}";
        if (!AssetDatabase.IsValidFolder(folder)) return Array.Empty<Sprite>();
        var guids = AssetDatabase.FindAssets("t:Sprite", new[] { folder });
        if (guids == null || guids.Length == 0) return Array.Empty<Sprite>();
        var list = new List<(string name, Sprite sp)>(guids.Length);
        foreach (var g in guids)
        {
            var path = AssetDatabase.GUIDToAssetPath(g);
            string fn = Path.GetFileNameWithoutExtension(path);
            // Case-insensitive: some bundles use uppercase ACTION (e.g. M_SL).
            if (fn.IndexOf(pattern, StringComparison.OrdinalIgnoreCase) < 0) continue;
            var sp = AssetDatabase.LoadAssetAtPath<Sprite>(path);
            if (sp != null) list.Add((fn, sp));
        }
        list.Sort((a, b) => string.Compare(a.name, b.name, StringComparison.Ordinal));
        var arr = new Sprite[list.Count];
        for (int i = 0; i < list.Count; i++) arr[i] = list[i].sp;
        return arr;
    }

    static Sprite[] LoadSpriteList(string dir, List<object> names)
    {
        if (names == null || names.Count == 0) return Array.Empty<Sprite>();
        var list = new List<Sprite>(names.Count);
        foreach (var n in names)
        {
            var s = LoadSprite(dir, n as string);
            if (s != null) list.Add(s);
        }
        return list.ToArray();
    }

    static Sprite LoadSprite(string dir, string name)
    {
        if (string.IsNullOrEmpty(name)) return null;
        string path = $"{kSpriteRoot}/{dir}/{name}.png";
        return AssetDatabase.LoadAssetAtPath<Sprite>(path);
    }

    static Vector2 ReadVec2(Dictionary<string, object> rect, string key, float dx, float dy)
    {
        if (rect == null || !rect.ContainsKey(key)) return new Vector2(dx, dy);
        var arr = rect[key] as List<object>;
        if (arr == null || arr.Count < 2) return new Vector2(dx, dy);
        return new Vector2(ToFloat(arr[0], dx), ToFloat(arr[1], dy));
    }

    static float ToFloat(object o, float fallback)
    {
        if (o == null) return fallback;
        if (o is double d) return (float)d;
        if (o is float f) return f;
        if (o is int i) return i;
        if (o is long l) return l;
        try { return (float)Convert.ToDouble(o); } catch { return fallback; }
    }

    // ---------- Tiny JSON parser (handles dicts/lists/strings/numbers/bools/null) ----------
    // Borrowed from Unity wiki MiniJSON style. Embedded so we don't depend on Newtonsoft.
    static class MiniJson
    {
        public static object Parse(string json)
        {
            int i = 0;
            return ParseValue(json, ref i);
        }
        static object ParseValue(string s, ref int i)
        {
            SkipWs(s, ref i);
            if (i >= s.Length) return null;
            char c = s[i];
            if (c == '{') return ParseObject(s, ref i);
            if (c == '[') return ParseArray(s, ref i);
            if (c == '"') return ParseString(s, ref i);
            if (c == 't' || c == 'f') return ParseBool(s, ref i);
            if (c == 'n') { i += 4; return null; }
            return ParseNumber(s, ref i);
        }
        static Dictionary<string, object> ParseObject(string s, ref int i)
        {
            var d = new Dictionary<string, object>();
            i++; // {
            while (true)
            {
                SkipWs(s, ref i);
                if (i >= s.Length) break;
                if (s[i] == '}') { i++; break; }
                string key = ParseString(s, ref i);
                SkipWs(s, ref i);
                if (i < s.Length && s[i] == ':') i++;
                var val = ParseValue(s, ref i);
                d[key] = val;
                SkipWs(s, ref i);
                if (i < s.Length && s[i] == ',') { i++; continue; }
                if (i < s.Length && s[i] == '}') { i++; break; }
            }
            return d;
        }
        static List<object> ParseArray(string s, ref int i)
        {
            var l = new List<object>();
            i++; // [
            while (true)
            {
                SkipWs(s, ref i);
                if (i >= s.Length) break;
                if (s[i] == ']') { i++; break; }
                l.Add(ParseValue(s, ref i));
                SkipWs(s, ref i);
                if (i < s.Length && s[i] == ',') { i++; continue; }
                if (i < s.Length && s[i] == ']') { i++; break; }
            }
            return l;
        }
        static string ParseString(string s, ref int i)
        {
            if (s[i] != '"') return null;
            i++;
            var sb = new System.Text.StringBuilder();
            while (i < s.Length && s[i] != '"')
            {
                if (s[i] == '\\' && i + 1 < s.Length)
                {
                    char e = s[i + 1];
                    if (e == 'n') sb.Append('\n');
                    else if (e == 't') sb.Append('\t');
                    else if (e == 'r') sb.Append('\r');
                    else if (e == '"') sb.Append('"');
                    else if (e == '\\') sb.Append('\\');
                    else if (e == '/') sb.Append('/');
                    else if (e == 'u' && i + 5 < s.Length)
                    {
                        sb.Append((char)Convert.ToInt32(s.Substring(i + 2, 4), 16));
                        i += 4;
                    }
                    else sb.Append(e);
                    i += 2;
                }
                else { sb.Append(s[i]); i++; }
            }
            if (i < s.Length) i++; // closing quote
            return sb.ToString();
        }
        static object ParseNumber(string s, ref int i)
        {
            int start = i;
            while (i < s.Length && "0123456789.-+eE".IndexOf(s[i]) >= 0) i++;
            string num = s.Substring(start, i - start);
            if (num.IndexOf('.') >= 0 || num.IndexOf('e') >= 0 || num.IndexOf('E') >= 0)
                return double.Parse(num, System.Globalization.CultureInfo.InvariantCulture);
            if (long.TryParse(num, out long l)) return l;
            return double.Parse(num, System.Globalization.CultureInfo.InvariantCulture);
        }
        static bool ParseBool(string s, ref int i)
        {
            if (s[i] == 't') { i += 4; return true; }
            i += 5; return false;
        }
        static void SkipWs(string s, ref int i)
        {
            while (i < s.Length && (s[i] == ' ' || s[i] == '\t' || s[i] == '\n' || s[i] == '\r')) i++;
        }
    }
}
