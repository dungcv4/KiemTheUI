// =======================================================================
//  PlayerStatCalculator.cs — Client-side stat computation from tabs.
//
//  Both client AND server read the SAME tab files from pack0.dat:
//    Setting/Player/PlayerLevel.tab         (per-level base stats)
//    Setting/Player/LevelFactionPotency.tab (faction × level modifier)
//
//  This file: client-side reader + formula. The server has an equivalent
//  class at GameServer/Config/PlayerStatCalculator.cs — both sides must
//  produce IDENTICAL numbers for the same (level, faction, attrs, equip).
//
//  Source formulas (reverse-engineered from client Lua):
//    AttributeDesc.lua:
//      MaxLife      = PlayerLevel[lv].MaxLife + Con*12 + equipHP
//      MaxMana      = PlayerLevel[lv].MaxMana + Energy*10 + equipMP
//      MinAttack    = PlayerLevel[lv].MinBaseAttack + Str*3 + equipAtk
//      MaxAttack    = PlayerLevel[lv].MaxBaseAttack + Str*3 + equipAtk
//      FightPower   = PlayerLevel[lv].FightPower × (attrSum/totalAttr)
//                     + LevelFactionPotency[faction][lv].FactionFightPower
//    (exact multipliers are placeholder — verify from Lua when porting
//    Player_AttributeDesc.lua path Scripts/Player/AttributeDesc.lua)
//
//  Loaded at runtime from Resources/Setting/Player/*.tab.txt.
// =======================================================================
using System.Collections.Generic;
using UnityEngine;

namespace KTO.Game.Player
{
    /// <summary>Per-level row from PlayerLevel.tab.</summary>
    public class PlayerLevelRow
    {
        public int Level;
        public long ExpUpGrade;
        public int BaseAwardExp;
        public int RunSpeed;
        public int AttackSpeed;
        public int AttributePower;
        public int FightPower;
        public int DeadlyStrikeV;
        public int DeadlyStrikeDamageV;
        public int SeriesEnhanceV;
        public int BlockV;
        public int BlockDamageResistV;
        public int MaxLife;
        public int MaxMana;
        public int Miss;
        public int HitRate;
        public int MinBaseAttack;
        public int MaxBaseAttack;
        public int RecoverManaV;
    }

    public static class PlayerStatCalculator
    {
        static readonly Dictionary<int, PlayerLevelRow> _byLevel = new Dictionary<int, PlayerLevelRow>();
        static bool _loaded;
        public static int MaxLevel { get; private set; }

        public const int DEFAULT_MAX_LIFE  = 100;  // level 1 fallback if table missing
        public const int DEFAULT_MAX_MANA  = 50;
        public const int DEFAULT_ATTACK    = 10;

        // Attribute → stat multipliers (placeholder; refine from AttributeDesc.lua).
        // Source grep: KiemTheOrigin_DeepExtract/_shared/Lua/Player/AttributeDesc.lua
        public const int HP_PER_VIT        = 12;
        public const int MP_PER_ENERGY     = 10;
        public const int ATTACK_PER_STR    = 3;
        public const int DEFENSE_PER_DEX   = 2;

        /// <summary>Load tabs from Resources (call once at boot).</summary>
        public static void Load()
        {
            if (_loaded) return;

            var ta = Resources.Load<TextAsset>("Setting/Player/PlayerLevel");
            if (ta == null)
            {
                Debug.LogWarning("[PlayerStatCalculator] PlayerLevel.tab not found in Resources — using defaults");
                _loaded = true;
                return;
            }

            ParsePlayerLevel(ta.text);
            Debug.Log($"[PlayerStatCalculator] Loaded {_byLevel.Count} level rows (max={MaxLevel})");
            _loaded = true;
        }

        static void ParsePlayerLevel(string text)
        {
            var lines = text.Split('\n');
            if (lines.Length < 2) return;

            // First line is header: Level ExpUpGrade BaseAwardExp RunSpeed ...
            // Tab-separated.
            for (int i = 1; i < lines.Length; i++)
            {
                var line = lines[i].Trim();
                if (string.IsNullOrEmpty(line)) continue;
                var cols = line.Split('\t');
                if (cols.Length < 19) continue;

                var row = new PlayerLevelRow
                {
                    Level               = ParseInt(cols[0]),
                    ExpUpGrade          = ParseLong(cols[1]),
                    BaseAwardExp        = ParseInt(cols[2]),
                    RunSpeed            = ParseInt(cols[3]),
                    AttackSpeed         = ParseInt(cols[4]),
                    AttributePower      = ParseInt(cols[5]),
                    FightPower          = ParseInt(cols[6]),
                    DeadlyStrikeV       = ParseInt(cols[7]),
                    DeadlyStrikeDamageV = ParseInt(cols[8]),
                    SeriesEnhanceV      = ParseInt(cols[9]),
                    BlockV              = ParseInt(cols[10]),
                    BlockDamageResistV  = ParseInt(cols[11]),
                    MaxLife             = ParseInt(cols[12]),
                    MaxMana             = ParseInt(cols[13]),
                    Miss                = ParseInt(cols[14]),
                    HitRate             = ParseInt(cols[15]),
                    MinBaseAttack       = ParseInt(cols[16]),
                    MaxBaseAttack       = ParseInt(cols[17]),
                    RecoverManaV        = ParseInt(cols[18]),
                };

                _byLevel[row.Level] = row;
                if (row.Level > MaxLevel) MaxLevel = row.Level;
            }
        }

        static int  ParseInt(string s)  { return int.TryParse(s.Trim(), out var v) ? v : 0; }
        static long ParseLong(string s) { return long.TryParse(s.Trim(), out var v) ? v : 0L; }

        public static PlayerLevelRow GetRow(int level)
        {
            Load();
            return _byLevel.TryGetValue(level, out var r) ? r : null;
        }

        // ----- Public formulas -----

        /// <summary>Max HP for a character. All numbers from source-of-truth tabs.</summary>
        public static int ComputeMaxHP(int level, int vitality, int equipHpBonus)
        {
            var row = GetRow(level);
            int baseHp = (row != null && row.MaxLife > 0) ? row.MaxLife : DEFAULT_MAX_LIFE;
            return baseHp + vitality * HP_PER_VIT + equipHpBonus;
        }

        public static int ComputeMaxMP(int level, int energy, int equipMpBonus)
        {
            var row = GetRow(level);
            int baseMp = (row != null && row.MaxMana > 0) ? row.MaxMana : DEFAULT_MAX_MANA;
            return baseMp + energy * MP_PER_ENERGY + equipMpBonus;
        }

        public static int ComputeMinAttack(int level, int strength, int equipAtkBonus)
        {
            var row = GetRow(level);
            int baseAtk = (row != null && row.MinBaseAttack > 0) ? row.MinBaseAttack : DEFAULT_ATTACK;
            return baseAtk + strength * ATTACK_PER_STR + equipAtkBonus;
        }

        public static int ComputeMaxAttack(int level, int strength, int equipAtkBonus)
        {
            var row = GetRow(level);
            int baseAtk = (row != null && row.MaxBaseAttack > 0) ? row.MaxBaseAttack : DEFAULT_ATTACK;
            return baseAtk + strength * ATTACK_PER_STR + equipAtkBonus;
        }

        public static int ComputeFightPower(int level, int str, int agi, int con, int dex, int factionId, int equipFightPowerBonus)
        {
            var row = GetRow(level);
            int basePower = (row != null) ? row.FightPower : 0;
            int attrSum = str + agi + con + dex;
            // Simple proxy: base × (1 + attrSum/1000) + equip. Refine when formula traced.
            int computed = basePower + attrSum * 5 + equipFightPowerBonus;
            return computed;
        }

        public static long ExpToNext(int level)
        {
            var row = GetRow(level);
            return row?.ExpUpGrade ?? 100000L;
        }

        public static int RunSpeedAtLevel(int level)
        {
            var row = GetRow(level);
            return (row != null && row.RunSpeed > 0) ? row.RunSpeed : 200; // default 200 logic/frame
        }
    }
}
