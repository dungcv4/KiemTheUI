// =======================================================================
//  ItemTemplate.cs — Static item metadata (name, icon, type, stats).
//
//  Source: GameServer XML configs at
//    GameServer_NET8/GameServer/bin/Debug/net10.0/Config/Config/KT_Item/**/*.xml
//  consolidated into a single JSON at
//    Assets/Resources/item_templates.json  (via /tmp/build_item_templates_json.py)
//
//  ~13k items across 42 XML files (weapons, armor, gems, medicine,
//  quest items, task items, etc.). Client loads all at boot so any
//  dwId coming from server CMD_BAG_SYNC can be resolved to name/icon.
//
//  The JSON uses short keys (id/n/t/eq/stk/…) to keep the file < 3 MB.
//  See build_item_templates_json.py for the key mapping.
// =======================================================================
using System.Collections.Generic;
using UnityEngine;

namespace KTO.Game.Item
{
    /// <summary>
    /// Faithful field set from Setting/Item/*.tab columns.
    /// Not every field is populated for every template (gems lack
    /// nAttack, potions lack nDefense, etc.). Missing = 0 / null.
    /// </summary>
    public class ItemTemplate
    {
        // ----- identity -----
        public int    nTemplateId;       // column "Id"
        public string szName;            // column "Name"
        public string szIcon;            // column "Icon" (sprite name)
        public int    nType;             // top-level kind (see ItemType enum)
        public int    nDetailType;       // sub-kind (Weapon/Helm/Armor/Gem...)
        public int    nColor;            // rarity: 0=white 1=green 2=blue 3=purple 4=gold 5=red
        public int    nMaxStack;         // 1 = unstackable, N = stackable up to N
        public int    nLevel;            // required level
        public int    nBindType;         // 0=none 1=BoE 2=BoP
        public bool   bTradable;         // can be sold/traded
        public bool   bDiscardable;      // can be deleted
        public int    nSellPrice;        // sell price to NPC in Coin

        // ----- display -----
        public string szDesc;            // tooltip description
        public string szPrefix;          // tooltip prefix (Lua tbItemClass:GetPrefixTip)
        public string szTip;             // extra tip line

        // ----- combat / stats (equipment templates) -----
        public int    nAttack;
        public int    nDefense;
        public int    nHp;
        public int    nMp;
        public int    nCritRate;         // x10 (123 → 12.3%)
        public int    nCritResist;
        public int    nHitRate;
        public int    nDodgeRate;
        public int    nBlockRate;
        public int    nAttackSpeed;

        // ----- equipment-specific -----
        public int    nEquipPos;         // -1 = not equippable; see Item.EQUIPPOS_* in Lua
        public int    nMinLevel;         // min level to equip
        public int    nFiveElements;     // 1=Metal 2=Wood 3=Water 4=Fire 5=Earth (五行)
        public int    nFaction;          // 0=Any, or sect id

        // ----- gem-specific -----
        public int    nGemType;          // color/kind of gem slot it fits
        public int    nGemLevel;

        // ----- potion-specific -----
        public int    nCdGroup;          // cooldown bucket
        public int    nCdTime;           // seconds
    }

    /// <summary>
    /// Item type top-level enum. Matches
    /// <c>Setting/Item/DetailTypeClassify.tab</c> rough buckets:
    ///   1 Weapon        2 Armor         3 Accessory
    ///   4 Consumable    5 Material      6 Quest
    ///   7 Gem           8 Horse         9 Fashion
    ///  10 Pet          11 Book         12 Other
    /// (Exact values verified in Item_NpcBagClass.lua when porting.)
    /// </summary>
    public enum ItemType
    {
        None       = 0,
        Weapon     = 1,
        Armor      = 2,
        Accessory  = 3,
        Consumable = 4,
        Material   = 5,
        Quest      = 6,
        Gem        = 7,
        Horse      = 8,
        Fashion    = 9,
        Pet        = 10,
        Book       = 11,
        Other      = 12,
    }

    /// <summary>
    /// EQUIPPOS_* values from <c>04_Bag/Lua/Item.lua</c>.
    /// Referenced by <c>Item.EQUIPPOS_HORSE</c> etc. in UIBag.lua.
    /// </summary>
    public static class EquipPos
    {
        public const int NONE      = -1;
        public const int HELM      = 1;
        public const int ARMOR     = 2;
        public const int WEAPON    = 3;
        public const int BOOTS     = 4;
        public const int BELT      = 5;
        public const int AMULET    = 6;
        public const int HORSE     = 7;
        public const int MEDAL     = 8;
        public const int RING1     = 9;
        public const int RING2     = 10;
        public const int FASHION1  = 11; // outfit
        public const int FASHION2  = 12; // hair
        public const int FASHION3  = 13; // headwear
    }

    /// <summary>
    /// Central registry. Populated by ItemDatabase.LoadAll() at boot; filled
    /// with mock data if config tabs are unavailable so UI still renders.
    /// </summary>
    public static class ItemDatabase
    {
        static readonly Dictionary<int, ItemTemplate> _byId = new Dictionary<int, ItemTemplate>();

        public static ItemTemplate Get(int nTemplateId)
        {
            if (_byId.TryGetValue(nTemplateId, out var t)) return t;
            return null;
        }

        public static void Register(ItemTemplate t)
        {
            if (t == null || t.nTemplateId == 0) return;
            _byId[t.nTemplateId] = t;
        }

        public static int Count => _byId.Count;
        public static Dictionary<int, ItemTemplate>.ValueCollection All => _byId.Values;

        /// <summary>
        /// Load all templates from Resources/item_templates.json (bundled
        /// from server XML configs — see build_item_templates_json.py).
        /// Falls back to the mock set if the file is missing / corrupt,
        /// so UI smoke tests still work without the data file.
        /// </summary>
        public static void LoadAll()
        {
            if (_byId.Count > 0) return;

            try
            {
                var ta = Resources.Load<TextAsset>("item_templates");
                if (ta != null && !string.IsNullOrEmpty(ta.text))
                {
                    int n = LoadFromJson(ta.text);
                    Debug.Log($"[ItemDatabase] Loaded {n} item templates from JSON");
                    if (n > 0) return;
                }
            }
            catch (System.Exception ex)
            {
                Debug.LogError($"[ItemDatabase] JSON load failed: {ex.Message}");
            }
            // Fallback
            LoadMockData();
            Debug.Log($"[ItemDatabase] Fallback mock: {_byId.Count} items");
        }

        /// <summary>
        /// Hand-rolled parser for the compact item_templates.json shape.
        /// Format: { "version":1, "count":N, "items":[{"id":123, "n":"...", ...}, ...] }
        /// Short keys match build_item_templates_json.py.
        /// Hand-rolled because Unity JsonUtility chokes on top-level arrays
        /// of anonymous-shape objects + we avoid a Newtonsoft dep.
        /// </summary>
        static int LoadFromJson(string json)
        {
            int count = 0;
            int i = json.IndexOf("\"items\"");
            if (i < 0) return 0;
            i = json.IndexOf('[', i);
            if (i < 0) return 0;
            i++; // past [

            while (i < json.Length)
            {
                // Skip whitespace and commas
                while (i < json.Length && (json[i] == ' ' || json[i] == ',' || json[i] == '\n' || json[i] == '\r' || json[i] == '\t')) i++;
                if (i >= json.Length || json[i] == ']') break;
                if (json[i] != '{') { i++; continue; }

                // Find matching '}' (no nested objects in our format)
                int end = json.IndexOf('}', i);
                if (end < 0) break;
                string obj = json.Substring(i, end - i + 1);
                i = end + 1;

                var tpl = ParseOne(obj);
                if (tpl != null)
                {
                    _byId[tpl.nTemplateId] = tpl;
                    count++;
                }
            }
            return count;
        }

        static ItemTemplate ParseOne(string obj)
        {
            int id     = ReadInt(obj, "\"id\":");
            if (id <= 0) return null;
            return new ItemTemplate
            {
                nTemplateId  = id,
                szName       = ReadStr(obj, "\"n\":"),
                nType        = ReadInt(obj, "\"t\":"),
                nEquipPos    = ReadInt(obj, "\"eq\":"),
                nMaxStack    = ReadInt(obj, "\"stk\":", 1),
                nColor       = ReadInt(obj, "\"q\":"),
                nMinLevel    = ReadInt(obj, "\"lv\":"),
                nLevel       = ReadInt(obj, "\"lv\":"),
                szIcon       = ReadStr(obj, "\"ic\":"),
                nSellPrice   = ReadInt(obj, "\"pr\":"),
                nBindType    = ReadInt(obj, "\"bnd\":"),
                szDesc       = ReadStr(obj, "\"ds\":"),
                nAttack      = ReadInt(obj, "\"atk\":"),
                nDefense     = ReadInt(obj, "\"def\":"),
                nHp          = ReadInt(obj, "\"hp\":"),
                nMp          = ReadInt(obj, "\"mp\":"),
                bTradable    = true,
                bDiscardable = true,
            };
        }

        static int ReadInt(string s, string key, int def = 0)
        {
            int i = s.IndexOf(key);
            if (i < 0) return def;
            i += key.Length;
            // Skip whitespace
            while (i < s.Length && (s[i] == ' ' || s[i] == '\t')) i++;
            int start = i;
            if (i < s.Length && s[i] == '-') i++;
            while (i < s.Length && s[i] >= '0' && s[i] <= '9') i++;
            if (start == i) return def;
            return int.TryParse(s.Substring(start, i - start), out int v) ? v : def;
        }

        static string ReadStr(string s, string key)
        {
            int i = s.IndexOf(key);
            if (i < 0) return "";
            i += key.Length;
            while (i < s.Length && (s[i] == ' ' || s[i] == '\t')) i++;
            if (i >= s.Length || s[i] != '"') return "";
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
                        case '"': sb.Append('"');  i += 2; break;
                        case '\\': sb.Append('\\'); i += 2; break;
                        case '/':  sb.Append('/');  i += 2; break;
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
                if (c == '"') return sb.ToString();
                sb.Append(c);
                i++;
            }
            return sb.ToString();
        }

        static void LoadMockData()
        {
            // 10 fake items to let UIBagPanel render. Names in Vietnamese
            // since the target locale is vi-VN.
            Register(new ItemTemplate { nTemplateId = 1001, szName = "Kiếm Sắt",        szIcon = "item_weapon_1",  nType = (int)ItemType.Weapon,     nColor = 0, nMaxStack = 1, nLevel = 1,  nAttack = 10, nEquipPos = EquipPos.WEAPON, nSellPrice = 50 });
            Register(new ItemTemplate { nTemplateId = 1002, szName = "Giáp Da",         szIcon = "item_armor_1",   nType = (int)ItemType.Armor,      nColor = 0, nMaxStack = 1, nLevel = 1,  nDefense = 8, nEquipPos = EquipPos.ARMOR,  nSellPrice = 40 });
            Register(new ItemTemplate { nTemplateId = 1003, szName = "Nón Vải",         szIcon = "item_helm_1",    nType = (int)ItemType.Armor,      nColor = 0, nMaxStack = 1, nLevel = 1,  nDefense = 4, nEquipPos = EquipPos.HELM,   nSellPrice = 25 });
            Register(new ItemTemplate { nTemplateId = 2001, szName = "Huyết Tinh",      szIcon = "item_potion_hp", nType = (int)ItemType.Consumable, nColor = 1, nMaxStack = 99, nLevel = 1, nCdGroup = 1, nCdTime = 3, nSellPrice = 5, szDesc = "Hồi 100 HP" });
            Register(new ItemTemplate { nTemplateId = 2002, szName = "Nội Đan",         szIcon = "item_potion_mp", nType = (int)ItemType.Consumable, nColor = 1, nMaxStack = 99, nLevel = 1, nCdGroup = 2, nCdTime = 3, nSellPrice = 5, szDesc = "Hồi 80 MP" });
            Register(new ItemTemplate { nTemplateId = 3001, szName = "Bảo Thạch Đỏ",    szIcon = "item_gem_red",   nType = (int)ItemType.Gem,        nColor = 2, nMaxStack = 20, nLevel = 1, nGemType = 1, nGemLevel = 1 });
            Register(new ItemTemplate { nTemplateId = 3002, szName = "Bảo Thạch Xanh",  szIcon = "item_gem_blue",  nType = (int)ItemType.Gem,        nColor = 2, nMaxStack = 20, nLevel = 1, nGemType = 2, nGemLevel = 1 });
            Register(new ItemTemplate { nTemplateId = 4001, szName = "Gỗ Đào",          szIcon = "item_mat_wood",  nType = (int)ItemType.Material,   nColor = 0, nMaxStack = 99, nLevel = 1, nSellPrice = 2 });
            Register(new ItemTemplate { nTemplateId = 4002, szName = "Sắt Vụn",         szIcon = "item_mat_iron",  nType = (int)ItemType.Material,   nColor = 0, nMaxStack = 99, nLevel = 1, nSellPrice = 3 });
            Register(new ItemTemplate { nTemplateId = 5001, szName = "Thiệp Hồng",      szIcon = "item_quest_1",   nType = (int)ItemType.Quest,      nColor = 3, nMaxStack = 1, nLevel = 1, bTradable = false, bDiscardable = false });
        }

        /// <summary>
        /// Color name for UI tooltip title tint. Matches the game's rarity
        /// color scheme (verified from UIItemTips.lua color cases).
        /// </summary>
        public static UnityEngine.Color ColorForRarity(int rarity)
        {
            switch (rarity)
            {
                case 0: return new UnityEngine.Color(0.90f, 0.90f, 0.90f); // white
                case 1: return new UnityEngine.Color(0.30f, 0.80f, 0.30f); // green
                case 2: return new UnityEngine.Color(0.25f, 0.55f, 0.95f); // blue
                case 3: return new UnityEngine.Color(0.75f, 0.35f, 0.95f); // purple
                case 4: return new UnityEngine.Color(0.95f, 0.75f, 0.20f); // gold
                case 5: return new UnityEngine.Color(0.95f, 0.25f, 0.25f); // red
                default: return UnityEngine.Color.white;
            }
        }
    }
}
