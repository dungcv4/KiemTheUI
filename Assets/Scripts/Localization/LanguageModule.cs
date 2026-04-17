// =======================================================================
//  LanguageModule.cs — Faithful port of KTO's runtime localization API.
//
//  Source:
//    KTO_DecompiledReference/_root/LanguageModule.c (5 methods)
//    KiemTheOrigin_DeepExtract/_shared/DecompiledSource/LanguageModule.cs (stub)
//    KiemTheOrigin_DeepExtract/39_CommonUI/CSharp/LanguageSource.cs (I2.Loc.*)
//
//  Original call chain:
//    Lua:  i18n.Get(key)
//       -> (XLua binding) LanguageModule.Get(key, null)
//       -> I2.Loc.LocalizationManager.GetTranslation(key, fixCase=1, fallback=0,
//                                                   returnNull=1, ...)
//       -> if null: return key itself
//       -> String.Format(translation, args) if args non-empty
//
//  I2Languages.asset in both the ORIGINAL APK rip and our project is EMPTY —
//  the live game downloads translation data from the server, or from a
//  separate asset we don't have visibility into.
//
//  Our port follows the SAME API but sources data from a local dictionary
//  (Assets/Resources/language/translations_{code}.json) so the rest of the
//  code compiles and runs identically to how the original game would.
//
//  DEVIATION — not from original source
//  Reason: Original's backing store is I2.Loc.LocalizationManager which
//  talks to a full I2 Localization plugin. We don't ship I2Loc so we back
//  it with a plain Dictionary<string,string> loaded from JSON.
//  The PUBLIC API matches the original 1:1. Callers can't tell the difference.
// =======================================================================

using System.Collections.Generic;
using UnityEngine;

namespace KTO.Localization
{
    public static class LanguageModule
    {
        // ----- static mirror of IL2CPP fields (FieldOffset 0x0..0x68) -----
        // These are populated by LoadDefaultString (IL2CPP 0x01bbb6c5).
        // Kept as public statics with the exact same names/order so any
        // legacy code referencing them by path continues to work.
        public static string szNPC_FLYCHAR_TYPE_HIT_MISS;
        public static string szNPC_FLYCHAR_TYPE_HURT_MISS;
        public static string szNPC_FLYCHAR_TYPE_HIT_RESIST;
        public static string szNPC_FLYCHAR_TYPE_HURT_RESIST;
        public static string szNPC_FLYCHAR_TYPE_HIT_CLEAR;
        public static string szNPC_FLYCHAR_TYPE_HURT_CLEAR;
        public static string szNPC_FLYCHAR_JINGHUO;
        public static string szNPC_FLYCHAR_TYPE_HURT_NORMAL;
        public static string szNPC_FLYCHAR_TYPE_CURE;
        public static string szNPC_FLYCHAR_ADD_EXP;
        public static string szNPC_FLYCHAR_TYPE_HIT_BLOCK;
        public static string szNPC_FLYCHAR_TYPE_HURT_BLOCK;
        public static string szOk;
        public static string szCancel;

        // ----- Lua-bound delegate (original: V_S_Parse) -----
        // Lua's i18n.Parse(msg) → resolves <i18n=KEY> tokens inside msg.
        // We keep the delegate so Lua bindings can hook Parse later.
        public delegate string V_S_Parse(string szMsg);
        public static V_S_Parse Parse;

        // ----- translation table (backing store for Get) -----
        //
        // Keyed by term. For the CN build these would be hardcoded Chinese
        // strings; for the VN build the keys are the SAME Chinese strings
        // used in the original prefabs (since the VN APK we decoded still
        // has Chinese placeholder text embedded — see our audit of
        // Assets/Prefabs/Imported/UIHud.prefab).
        //
        // This mirrors I2 Localization's TermData store (List<TermData>
        // mTerms in LanguageSource). Lookup is O(1) by key; key lookup is
        // case-sensitive to match LocalizationManager.GetTranslation with
        // fixForAllLanguages=true (the 2nd arg in the native call).
        static readonly Dictionary<string, string> _terms = new Dictionary<string, string>();

        // ----- current language code (matches CurrentLanguageCode) -----
        //
        // Default "vi-VN" matches the Vietnamese release the player is
        // running. Original reads from
        //   I2.Loc.LocalizationManager.get_CurrentLanguageCode()
        // which is initialized from LanguageSource.mLanguages[0].Code.
        static string _currentLanguageCode = "vi-VN";
        public static string CurrentLanguageCode() => _currentLanguageCode;

        // ----- lifecycle -----
        //
        // Called by game bootstrap to load translation data. Idempotent.
        // Original LoadDefaultString (IL2CPP 0x01bbb6c5) calls many static
        // getters of I2.Loc.ScriptLocalization to populate the fields
        // above. We do the same — but read from our local dictionary.
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        static void BootstrapOnStart()
        {
            if (_terms.Count == 0)
                LoadLanguage(_currentLanguageCode);
            LoadDefaultString();
        }

        /// <summary>
        /// Faithful port of <c>LanguageModule.Get(key, args)</c>
        /// (IL2CPP <c>0x01bbb800</c>).
        ///
        /// Logic mirrors the native body:
        ///   string t = I2.Loc.LocalizationManager.GetTranslation(key, true, 0, true, false, null, null, true);
        ///   if (t == null) t = key;
        ///   if (args != null && args.Length != 0) return String.Format(t, args);
        ///   return t;
        /// </summary>
        public static string Get(string key, params object[] args)
        {
            if (string.IsNullOrEmpty(key)) return key;

            if (!_terms.TryGetValue(key, out string translation) || translation == null)
            {
                // Fallback to key itself — exactly what the native does when
                // LocalizationManager.GetTranslation returns null.
                translation = key;
            }

            if (args != null && args.Length > 0)
                return string.Format(translation, args);
            return translation;
        }

        /// <summary>
        /// Faithful port of <c>LanguageModule.Format(format, args)</c>
        /// (IL2CPP <c>0x01bbb89a</c>). Native is a one-liner
        /// <c>System.String.Format(fmt, args)</c>, no translation.
        /// </summary>
        public static string Format(string fmt, params object[] args)
        {
            return string.Format(fmt ?? string.Empty, args);
        }

        /// <summary>
        /// Faithful port of <c>LanguageModule.LoadDefaultString()</c>
        /// (IL2CPP <c>0x01bbb6c5</c>). Populates the static sz-prefixed
        /// fields by looking up well-known keys.
        /// </summary>
        public static void LoadDefaultString()
        {
            // Original keys from I2.Loc.ScriptLocalization property names,
            // visible in Ghidra as `I2_Loc_ScriptLocalization__get_*`.
            szNPC_FLYCHAR_TYPE_HIT_MISS    = Get("NPC_FLYCHAR_MISS");
            szNPC_FLYCHAR_TYPE_HURT_MISS   = Get("NPC_FLYCHAR_MISS");
            szNPC_FLYCHAR_TYPE_HIT_RESIST  = Get("NPC_FLYCHAR_RESIST");
            szNPC_FLYCHAR_TYPE_HURT_RESIST = Get("NPC_FLYCHAR_RESIST");
            szNPC_FLYCHAR_TYPE_HIT_CLEAR   = Get("NPC_FLYCHAR_CLEAR");
            szNPC_FLYCHAR_TYPE_HURT_CLEAR  = Get("NPC_FLYCHAR_CLEAR");
            szNPC_FLYCHAR_JINGHUO          = Get("NPC_FLYCHAR_JINGHUO");
            szNPC_FLYCHAR_TYPE_HIT_BLOCK   = Get("NPC_FLYCHAR_BLOCK");
            szNPC_FLYCHAR_TYPE_HURT_BLOCK  = Get("NPC_FLYCHAR_BLOCK");
            szNPC_FLYCHAR_ADD_EXP          = Get("NPC_FLYCHAR_ADD_EXP");
            szOk                           = Get("Ok");
            szCancel                       = Get("Cancel");
        }

        // ----- data loading -----
        //
        // Loads translations from <c>Resources/language/translations_{code}.json</c>.
        // JSON shape: { "terms": { "key1": "val1", "key2": "val2" } }
        //
        // If the file is missing (new language not yet translated) we leave
        // the dictionary empty — Get() will fall back to returning the key,
        // which is exactly what the original does when LocalizationManager
        // has no data for the key.
        public static void LoadLanguage(string code)
        {
            _terms.Clear();
            _currentLanguageCode = code;

            string path = $"language/translations_{code}";
            TextAsset ta = Resources.Load<TextAsset>(path);
            if (ta == null)
            {
                Debug.LogWarning(
                    $"[LanguageModule] No translations file at Resources/{path}.json — " +
                    "Get() will return keys unchanged.");
                return;
            }

            try
            {
                // Simple flat dictionary decode. We don't rely on JsonUtility
                // here because it can't serialize Dictionary<,> without a
                // wrapper. Hand-parse the JSON — shape is controlled by us.
                var dict = ParseFlatJsonDict(ta.text);
                foreach (var kv in dict)
                    _terms[kv.Key] = kv.Value;
                Debug.Log($"[LanguageModule] Loaded {_terms.Count} terms for {code}");
            }
            catch (System.Exception ex)
            {
                Debug.LogError($"[LanguageModule] Parse error for {path}: {ex.Message}");
            }
        }

        // Minimal JSON parser for our flat shape. Intentionally NOT a full
        // JSON parser — we control both the writer and the reader.
        //
        // Accepts:  { "terms": { "key": "value", ... } }
        // Escapes:  \n \t \" \\ \u####
        static Dictionary<string, string> ParseFlatJsonDict(string json)
        {
            var result = new Dictionary<string, string>();
            if (string.IsNullOrEmpty(json)) return result;

            int idx = json.IndexOf("\"terms\"");
            if (idx < 0) return result;

            // Advance to the opening brace after "terms":
            idx = json.IndexOf('{', idx);
            if (idx < 0) return result;

            int depth = 1;
            int i = idx + 1;
            while (i < json.Length && depth > 0)
            {
                char c = json[i];
                if (c == '}')
                {
                    depth--;
                    i++;
                    continue;
                }
                if (c == '"')
                {
                    // Read key
                    string key = ReadJsonString(json, ref i);
                    // Advance to colon
                    while (i < json.Length && json[i] != ':') i++;
                    i++; // skip ':'
                    while (i < json.Length && char.IsWhiteSpace(json[i])) i++;
                    if (i < json.Length && json[i] == '"')
                    {
                        string val = ReadJsonString(json, ref i);
                        result[key] = val;
                    }
                    continue;
                }
                i++;
            }
            return result;
        }

        static string ReadJsonString(string s, ref int i)
        {
            // Precondition: s[i] == '"'
            i++; // skip opening quote
            var sb = new System.Text.StringBuilder();
            while (i < s.Length)
            {
                char c = s[i];
                if (c == '\\' && i + 1 < s.Length)
                {
                    char esc = s[i + 1];
                    switch (esc)
                    {
                        case 'n': sb.Append('\n'); i += 2; break;
                        case 't': sb.Append('\t'); i += 2; break;
                        case 'r': sb.Append('\r'); i += 2; break;
                        case '"': sb.Append('"');  i += 2; break;
                        case '\\': sb.Append('\\'); i += 2; break;
                        case '/': sb.Append('/');  i += 2; break;
                        case 'u':
                            if (i + 5 < s.Length)
                            {
                                string hex = s.Substring(i + 2, 4);
                                if (int.TryParse(hex, System.Globalization.NumberStyles.HexNumber,
                                                 System.Globalization.CultureInfo.InvariantCulture, out int cp))
                                    sb.Append((char)cp);
                                i += 6;
                            }
                            else i += 2;
                            break;
                        default: sb.Append(esc); i += 2; break;
                    }
                    continue;
                }
                if (c == '"')
                {
                    i++; // skip closing quote
                    return sb.ToString();
                }
                sb.Append(c);
                i++;
            }
            return sb.ToString();
        }

        // ----- diagnostics -----
        public static int TermCount => _terms.Count;
        public static bool HasTerm(string key) => _terms.ContainsKey(key);
    }
}
