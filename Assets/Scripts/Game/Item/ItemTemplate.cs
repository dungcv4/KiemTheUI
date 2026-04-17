// =======================================================================
//  ItemTemplate.cs — Static item metadata (name, icon, type, stats).
//
//  Source: Setting/Item/*.tab in pack0.dat (Amulet.tab, Armor.tab,
//          Boots.tab, etc. — total ~50+ tab files with ~50K rows).
//  Client Lua: 04_Bag/Lua/Item.lua (client-side Item:GetClass registry).
//
//  In the original game, ItemTemplate fields are loaded from Setting tabs
//  at client boot (BagMgr calls Item:LoadAllTemplates). Our port ships a
//  ItemTemplate struct that matches the tab column order 1:1, plus a
//  static registry keyed by nTemplateId.
//
//  For "chờ ghép server" mode, the server tells us nTemplateId — the
//  client looks up the rest (name, icon, stats) from this registry.
// =======================================================================
using System.Collections.Generic;

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
        /// Load all templates from pack0 Setting/Item/*.tab files if available,
        /// fall back to mock entries for UI smoke testing.
        /// </summary>
        public static void LoadAll()
        {
            if (_byId.Count > 0) return;

            // TODO: actual tab loader via pack0 reader. For now, register
            // a small mock set so UIBagPanel has something to display.
            LoadMockData();
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
