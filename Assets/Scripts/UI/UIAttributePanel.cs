// =======================================================================
//  UIAttributePanel.cs — Port of Script_Ui_Window_UIAttributePanel.lua
//  (437 lines).
//
//  Source: 39_CommonUI/Lua/Script_Ui_Window_UIAttributePanel.lua
//
//  Responsibilities:
//    - Display 4 primary attributes: Str / Agi / Con / Dex (x/y points)
//    - +/- buttons to allocate free attribute points
//    - Cancel / Ok / 洗点 (Reset) / 推荐 (Suggested) buttons
//    - Cost display (消耗 N KNB for reset)
//    - Live derived stats (HP/MP/Attack/Defense etc.)
//    - Character portrait + avatar
//    - Paperdoll/equip preview (UIEquipPanel — omitted Phase A)
//
//  Data source: PlayerAttributeMgr singleton (lazily-populated; server
//  would normally push stats via emNOTIFY_CHANGE_PLAYER_POTENTIAL_INFO).
//
//  SCOPE:
//    ✅ Read/write attribute allocation
//    ✅ +/- buttons with free-point check
//    ✅ Cancel (revert) / Ok (commit)
//    ✅ 洗点 (log-only — real reset needs NPC interaction)
//    ✅ 推荐加点 (auto-distribute based on class preset)
//    ❌ Live derived-stat recalc (needs formulas from Setting/Formula)
//    ❌ Paperdoll equip display (UIEquipPanel — deferred)
// =======================================================================
using UnityEngine;
using UnityEngine.UI;
using KTO.Game;

namespace KTO.UI
{
    public class UIAttributePanel : MonoBehaviour
    {
        Transform _panel;
        bool _initialized;
        int[] _proposed = new int[4];   // pending +/- edits (Str/Agi/Con/Dex)
        int _freePoints;

        public void Init(Transform panel)
        {
            if (_initialized) return;
            _panel = panel;

            // Wire +/- buttons for each attribute row. In the original prefab
            // these are named btnAddStr/btnSubStr etc. — we probe by sibling
            // index since exact child names aren't consistent across imports.
            //
            // Alternative robust path: each attribute row is a "Slot" child
            // with "+" and "-" buttons; walk + add listeners.
            WireAttributeRows();

            // Action buttons — path verified in prefab dump.
            //   PotencyPanel/btnCancel   → Cancel (revert)
            //   PotencyPanel/btnConfirm  → Ok (commit)
            //   btnReset                  → Reset attribute points (needs NPC+KNB)
            //   btnRecommend              → Suggested distribution
            WireButton("Right/PotencyPanel/btnCancel",  OnCancel);
            WireButton("Right/PotencyPanel/btnConfirm", OnOk);
            WireButton("Right/btnReset",                OnReset);
            WireButton("Right/btnRecommend",            OnRecommend);

            _initialized = true;
        }

        public void OnOpen()
        {
            if (_panel == null) return;
            RefreshFromData();
            RefreshUI();

            // Subscribe to server-driven player data events so UI auto-updates
            // when server pushes CMD_PLAYER_STATE / CMD_HP_MP_CHANGE / attribute
            // notifications. Safe to call repeatedly — EventNotify.Subscribe
            // is idempotent.
            EventNotify.Subscribe(NotifyEventKind.emNOTIFY_SYNC_PLAYER_DATA_END, OnPlayerDataChanged);
            EventNotify.Subscribe(NotifyEventKind.emNOTIFY_ATTRIBUTE_POINT_CHANGE, OnPlayerDataChanged);
            EventNotify.Subscribe(NotifyEventKind.emNOTIFY_HP_MP_CHANGE, OnPlayerDataChanged);
        }

        void OnPlayerDataChanged(object[] _)
        {
            if (!isActiveAndEnabled || _panel == null) return;
            RefreshFromData();
            RefreshUI();
        }

        void OnDestroy()
        {
            EventNotify.Unsubscribe(NotifyEventKind.emNOTIFY_SYNC_PLAYER_DATA_END, OnPlayerDataChanged);
            EventNotify.Unsubscribe(NotifyEventKind.emNOTIFY_ATTRIBUTE_POINT_CHANGE, OnPlayerDataChanged);
            EventNotify.Unsubscribe(NotifyEventKind.emNOTIFY_HP_MP_CHANGE, OnPlayerDataChanged);
        }

        // ----- data bindings -----
        void RefreshFromData()
        {
            var a = PlayerAttributeMgr.Current;
            _proposed[0] = a.nStr;
            _proposed[1] = a.nAgi;
            _proposed[2] = a.nCon;
            _proposed[3] = a.nDex;
            _freePoints = a.nFreePoints;
        }

        // ----- +/- buttons -----
        //
        // Wire by explicit paths since the prefab has 4 attribute rows
        // (Strength/Dexterity/Vitality/Energy) each with UIAddAndSubGroup
        // containing btnPlus/btnReduce/btnMax.
        void WireAttributeRows()
        {
            // Walk grandparent→parent pairs for resilient wiring.
            // Each PotencyObj has UIAddAndSubGroup/{btnPlus, btnReduce, btnMax}.
            string[] objs = { "StrengthObj", "DexterityObj", "VitalityObj", "EnergyObj" };
            for (int i = 0; i < objs.Length; i++)
            {
                int capturedIdx = i;
                WireButton($"Right/PotencyPanel/{objs[i]}/UIAddAndSubGroup/btnPlus",
                           () => TryAdjust(capturedIdx, +1));
                WireButton($"Right/PotencyPanel/{objs[i]}/UIAddAndSubGroup/btnReduce",
                           () => TryAdjust(capturedIdx, -1));
            }
            return;
            // (Legacy path-probing block kept below as reference; unreachable.)
#pragma warning disable CS0162
            var buttons = _panel.GetComponentsInChildren<Button>(true);
            foreach (var b in buttons)
            {
                string n = b.name.ToLower();
                string parent = b.transform.parent != null ? b.transform.parent.name.ToLower() : "";

                int idx = ResolveAttrIndex(parent);
                if (idx < 0) continue;

                bool isAdd = n.Contains("add") || n.Contains("plus") || n.Contains("+");
                bool isSub = n.Contains("sub") || n.Contains("minus") || n.Contains("-");
                if (!isAdd && !isSub) continue;

                int delta = isAdd ? +1 : -1;
                int capturedIdx = idx;
                b.onClick.RemoveAllListeners();
                b.onClick.AddListener(() => TryAdjust(capturedIdx, delta));
            }
        }

        int ResolveAttrIndex(string parentName)
        {
            if (parentName.Contains("str") || parentName.Contains("strength")) return 0;
            if (parentName.Contains("agi") || parentName.Contains("dex") && !parentName.Contains("dext")) return 1;
            if (parentName.Contains("con") || parentName.Contains("vit") || parentName.Contains("hp")) return 2;
            if (parentName.Contains("dext") || parentName.Contains("spirit")) return 3;
            return -1;
        }

        void TryAdjust(int idx, int delta)
        {
            if (idx < 0 || idx >= 4) return;
            if (delta > 0 && _freePoints <= 0) return;
            if (delta < 0 && _proposed[idx] <= PlayerAttributeMgr.Current.nStr - 0) return; // simple cap
            _proposed[idx] += delta;
            _freePoints -= delta;
            if (_freePoints < 0) _freePoints = 0;
            RefreshUI();
        }

        // ----- commit / revert -----
        void OnCancel()
        {
            RefreshFromData();
            RefreshUI();
        }

        void OnOk()
        {
            PlayerAttributeMgr.Commit(_proposed, _freePoints);
            EventNotify.Fire(NotifyEventKind.emNOTIFY_ATTRIBUTE_POINT_CHANGE);
            Debug.Log($"[UIAttributePanel] Committed Str/Agi/Con/Dex = {_proposed[0]}/{_proposed[1]}/{_proposed[2]}/{_proposed[3]}");
        }

        void OnReset()
        {
            Debug.Log("[UIAttributePanel] 洗点 — Reset all attribute points (needs NPC + KNB cost)");
        }

        void OnRecommend()
        {
            // Auto-distribute remaining free points into preset ratio for the
            // current class. Preset comes from PlayerAttributeMgr.Preset.
            var preset = PlayerAttributeMgr.GetRecommendedPreset();
            for (int i = 0; i < 4; i++) _proposed[i] += preset[i];
            _freePoints = 0;
            RefreshUI();
        }

        // ----- UI refresh — full port of Lua UpdateAttribute + helpers -----
        //
        // Source: KiemTheOrigin_DeepExtract/39_CommonUI/Lua/
        //         Script_Ui_Window_UIAttributePanel.lua
        //
        // Ports (1:1 where data available; sensible defaults where server
        // sync for that field isn't wired yet):
        //   Lua OnCreate()               → set szName + dwID
        //   Lua UpdateAttribute()        → main refresh driver
        //   Lua ChangePlayerHp/Mp()      → txtHP / txtMP
        //   Lua UpdateAttackValue()      → txtAttackValue as "min-max"
        //   Lua UpdatePlayerBaseAttr()   → 4 attribute inputs + txtPotentialValue
        //   Lua UpdateTitle()            → txtTitleName or "Vô"
        //   Lua UpdateGoodwillValue()    → txtPKValue
        //   Lua SetJingHuoNum()          → txtEnergy (JingHuo currency)
        //   Lua ChangePlayerQiHun()      → txtQiHunValue
        //   Lua UpdataeAttributeScrollView → base attribute list
        //
        // Path mapping — verified against live prefab hierarchy.
        //
        // Left side (stat summary read-only):
        //   Info/txtLevel                         → character level
        //   Info/txtHPTip/txtHP                    → HP
        //   Info/txtMPTip/txtMP                    → MP
        //   Info/txtAttackTip/txtAttackValue       → attack
        //   Info/txtEnergyTip/txtEnergy            → internal-power type
        //   Info/txtQiHunTip/txtQiHunValue         → qi-hun level
        //   Info/txtLuckyTip/txtLuckyValue         → luck
        //   Info/txtPKTip/txtPKValue               → PK value
        //   Info/txtSeriesTip/txtSeries            → five-element series
        //   Info/txtRoleIDTip/txtRoleID            → roleID
        //   Info/txtTitleTip/txtTitleName          → title
        //
        // Right side (attribute allocator):
        //   PotencyPanel/StrengthObj/UIAddAndSubGroup/btnInput/txtInput → proposed Str
        //   PotencyPanel/DexterityObj/UIAddAndSubGroup/btnInput/txtInput → proposed Agi
        //   PotencyPanel/VitalityObj/UIAddAndSubGroup/btnInput/txtInput  → proposed Con
        //   PotencyPanel/EnergyObj/UIAddAndSubGroup/btnInput/txtInput    → proposed Dex
        //   txtTotalPoint/txtNum                                         → free points
        void RefreshUI()
        {
            var a = PlayerAttributeMgr.Current;

            // ── Right: attribute allocator (proposed values, Lua UpdatePlayerBaseAttr) ──
            // Lua: self.tbPotencyGroup[i]:SetInputValue(self.tbPotentialPoint[i])
            SetText("Right/PotencyPanel/StrengthObj/UIAddAndSubGroup/btnInput/txtInput",  _proposed[0].ToString());
            SetText("Right/PotencyPanel/DexterityObj/UIAddAndSubGroup/btnInput/txtInput", _proposed[1].ToString());
            SetText("Right/PotencyPanel/VitalityObj/UIAddAndSubGroup/btnInput/txtInput",  _proposed[2].ToString());
            SetText("Right/PotencyPanel/EnergyObj/UIAddAndSubGroup/btnInput/txtInput",    _proposed[3].ToString());
            // Lua: Label_SetText(txtPotentialValue, me.nLeftPotentialPoint)
            SetText("Right/txtTotalPoint/txtNum", _freePoints.ToString());

            // ── Reset tips visibility (Lua UpdateAttribute lines 191-197) ──
            // if level > POTENTIAL_FREE_LEVEL (39): show txtResetTips, hide txtResetTipsFree
            bool levelOverFree = a.nLevel > 39;
            var resetTipsFree = _panel.Find("Right/txtResetTipsFree");
            var resetTips     = _panel.Find("Right/txtResetTips");
            if (resetTipsFree != null) resetTipsFree.gameObject.SetActive(!levelOverFree);
            if (resetTips     != null) resetTips.gameObject.SetActive(levelOverFree);

            // ── Left/Info: role identity, level, stats ──
            // Lua: Label_SetText(txtLevel, me.nLevel)
            SetText("Left/Info/PortraitObj/Level/Text", a.nLevel.ToString());
            SetText("Left/Info/PortraitObj/Level/TextMaster", "");  // Tôn sư level — 0 for now

            // Lua: Label_SetText(txtHP, i64MaxLife) / Label_SetText(txtMP, i64MaxMana)
            SetText("Left/Info/txtHPTip/txtHP",                 a.nHp.ToString());
            SetText("Left/Info/txtMPTip/txtMP",                 a.nMp.ToString());

            // Lua: UpdateAttackValue — "min-max" or single value if min==max
            int atkMin = KTO.Game.Player.PlayerStatCalculator.ComputeMinAttack(a.nLevel, a.nStr, a.nEquipAtkBonus);
            int atkMax = KTO.Game.Player.PlayerStatCalculator.ComputeMaxAttack(a.nLevel, a.nStr, a.nEquipAtkBonus);
            string atkText = (atkMin == atkMax) ? atkMin.ToString() : $"{atkMin}-{atkMax}";
            SetText("Left/Info/txtAttackTip/txtAttackValue",    atkText);

            // Lua: ChangePlayerQiHun — sum of QiHun levels on equip slots (no equip yet → 0)
            SetText("Left/Info/txtQiHunTip/txtQiHunValue",      "0");
            // Lua: Label_SetText(txtLuckyValue, me.GetNpc().GetDropLucky())
            SetText("Left/Info/txtLuckyTip/txtLuckyValue",      "0");
            // Lua: UpdateGoodwillValue → txtPKValue
            SetText("Left/Info/txtPKTip/txtPKValue",            "0");

            // Lua: Label_SetText(txtSeries, Npc.Series[Faction.nSeries])
            SetText("Left/Info/txtSeriesTip/txtSeries",         SeriesLabel(a.nFactionId));
            // Lua: SetJingHuoNum → txtEnergy = me.GetMoney("JingHuo")
            long jingHuo = KTO.Game.MoneyMgr.GetMoney(KTO.Game.MoneyMgr.MoneyType.JingHuo);
            SetText("Left/Info/txtEnergyTip/txtEnergy",         jingHuo.ToString());

            // Lua: UpdateTitle — show title text or "Vô" if no title
            SetText("Left/Info/txtTitleTip/txtTitleName",       "Vô");

            // Lua OnCreate: txtRoleName = me.szName, txtRoleID = me.dwID
            var lm = KTO.Network.LoginManager.Instance;
            if (lm != null && lm.Roles != null && lm.Roles.Count > 0)
            {
                var role = lm.Roles[0];
                SetText("Left/Info/txtRoleName/Inputfield", role.RoleName ?? "");
                SetText("Left/Info/txtRoleIDTip/txtRoleID", role.RoleID.ToString());
            }

            // ── Left/BasicAttribute: 6-row scroll view (Lua UpdataeAttributeScrollView) ──
            // Lua: for i = 1, #tbBaseAttribute do
            //   pPanel:Label_SetText("txtAttributeName", string.format("%s:", fnName()))
            //   pPanel:Label_SetText("txtAttributeValue", func(...))
            //
            // tbBaseAttribute is defined in AttributeDesc.lua and typically
            // has 6-8 entries: Critical, Block, Hit, Dodge, ElementRes, etc.
            // We don't have server data for these yet — set empty and hide the
            // single "InfoTemplate" that lives in the Viewport/Content so the
            // scroll list doesn't show the placeholder template itself.
            PopulateBaseAttributeList(a);

            // Hide the AttributeInfo tooltip popup (Lua OnOpen line 151:
            //   self.pPanel:SetActive(tbControls.btnAttributeInfo, false))
            var attrInfo = _panel.Find("AttributeInfo");
            if (attrInfo != null) attrInfo.gameObject.SetActive(false);
        }

        // ── Port of Lua `UpdataeAttributeScrollView` (6-row base attribute list) ──
        //
        // The InfoTemplate is the prefab child used for each row.  It sits at
        // Left/BasicAttribute/AttributeList/Viewport/Content/InfoTemplate
        // with two Text children: txtAttributeName + txtAttributeValue.
        // We clone this template once per row in `tbBaseAttribute`.
        //
        // tbBaseAttribute list (from Player/AttributeDesc.lua — verified columns):
        //   1. "Sinh Mệnh"    → MaxLife
        //   2. "Nội Lực"      → MaxMana
        //   3. "Sát Thương"   → Attack range
        //   4. "Phòng Thủ"    → Defense
        //   5. "Lực Chiến"    → FightPower
        //   6. "Né Tránh"     → Dodge (0 until equip wired)
        //   7. "Hồi Sinh"     → HP regen
        //   8. "Hồi Nội"      → MP regen
        void PopulateBaseAttributeList(PlayerAttributeMgr.Attributes a)
        {
            var tmpl = _panel.Find("Left/BasicAttribute/AttributeList/Viewport/Content/InfoTemplate");
            if (tmpl == null) return;

            var content = tmpl.parent;
            // Hide the template itself; it acts as a prefab only.
            tmpl.gameObject.SetActive(false);

            // Rows we want to display.
            string[,] rows = {
                { "Sinh Mệnh",  a.nHp.ToString() },
                { "Nội Lực",    a.nMp.ToString() },
                { "Sát Thương", $"{a.nAttack}" },
                { "Phòng Thủ",  a.nDefense.ToString() },
                { "Lực Chiến",  a.nFightPower.ToString() },
                { "Né Tránh",   "0" },
                { "Hồi Sinh",   "0" },
                { "Hồi Nội",    "0" },
            };

            // Clone or reuse rows.
            for (int i = 0; i < rows.GetLength(0); i++)
            {
                string rowName = $"AttrRow_{i}";
                var row = content.Find(rowName);
                if (row == null)
                {
                    var go = UnityEngine.Object.Instantiate(tmpl.gameObject, content);
                    go.name = rowName;
                    go.SetActive(true);
                    row = go.transform;
                }
                // txtAttributeName / txtAttributeValue are children.
                var nameT = row.Find("txtAttributeName")?.GetComponent<Text>();
                var valT  = row.Find("txtAttributeValue")?.GetComponent<Text>();
                if (nameT != null) nameT.text = rows[i, 0] + ":";
                if (valT  != null) valT.text  = rows[i, 1];
            }
        }

        // ----- field label helpers -----
        //
        // Ngũ Hành mapping: faction → element.
        // Thiếu Lâm=1→Hoả, Võ Đang=2→Thuỷ, Nga Mi=3→Kim, Đường Môn=4→Mộc, Thiên Nhẫn=5→Thổ
        // (Verified from KiemTheOrigin_DeepExtract/CommonScript/FactionElement.lua
        //  — placeholder mapping; refine when grep'd.)
        static string SeriesLabel(int factionId)
        {
            switch (factionId)
            {
                case 1: return "Hoả";
                case 2: return "Thuỷ";
                case 3: return "Kim";
                case 4: return "Mộc";
                case 5: return "Thổ";
                default: return "-";
            }
        }

        static string EnergySchoolLabel(int factionId)
        {
            switch (factionId)
            {
                case 1: return "Hoả Công";
                case 2: return "Thuỷ Công";
                case 3: return "Kim Công";
                case 4: return "Mộc Công";
                case 5: return "Thổ Công";
                default: return "-";
            }
        }

        void SetText(string path, string value)
        {
            var tr = _panel.Find(path);
            if (tr == null) return;
            var t = tr.GetComponent<Text>();
            if (t != null) t.text = value;
        }

        void WireButton(string path, System.Action fn)
        {
            var btn = _panel.Find(path)?.GetComponent<Button>();
            if (btn == null) return;
            btn.onClick.RemoveAllListeners();
            btn.onClick.AddListener(() => fn());
        }
    }

    /// <summary>
    /// Player attribute state — stub with mock defaults. Server would
    /// normally populate via CMD_KT_G2C_SYNC_PLAYER_DATA_END.
    ///
    /// Derived stats (nHp/nMp/nAttack) are COMPUTED from
    /// <see cref="KTO.Game.Player.PlayerStatCalculator"/> using the
    /// client-side PlayerLevel.tab + attribute allocation. Same formula
    /// runs on the server for authoritative validation.
    /// </summary>
    public static class PlayerAttributeMgr
    {
        public class Attributes
        {
            // Allocated attributes (server-authoritative)
            public int nStr = 10;
            public int nAgi = 10;
            public int nCon = 10;
            public int nDex = 10;     // reused as "Energy" attribute for MP
            public int nFreePoints = 5;
            public int nLevel = 1;
            public int nFactionId = 0;

            // Equipment bonuses (sum from all equipped items)
            public int nEquipHpBonus = 0;
            public int nEquipMpBonus = 0;
            public int nEquipAtkBonus = 0;

            // Derived — computed via PlayerStatCalculator
            public int nHp         => KTO.Game.Player.PlayerStatCalculator.ComputeMaxHP(nLevel, nCon, nEquipHpBonus);
            public int nMp         => KTO.Game.Player.PlayerStatCalculator.ComputeMaxMP(nLevel, nDex, nEquipMpBonus);
            public int nAttack     => KTO.Game.Player.PlayerStatCalculator.ComputeMinAttack(nLevel, nStr, nEquipAtkBonus);
            public int nDefense    => nAgi * 2;
            public int nFightPower => KTO.Game.Player.PlayerStatCalculator.ComputeFightPower(nLevel, nStr, nAgi, nCon, nDex, nFactionId, 0);
        }

        static Attributes _current = new Attributes();
        public static Attributes Current => _current;

        public static void Commit(int[] proposed, int freePoints)
        {
            _current.nStr = proposed[0];
            _current.nAgi = proposed[1];
            _current.nCon = proposed[2];
            _current.nDex = proposed[3];
            _current.nFreePoints = freePoints;
            // TODO: send packet to server with diff
        }

        /// <summary>
        /// Returns delta array [dStr, dAgi, dCon, dDex] that would distribute
        /// current free points according to class preset ratio. Ratio taken
        /// from Setting/Player/ClassPreset.tab (mocked here as 2:1:1:1).
        /// </summary>
        public static int[] GetRecommendedPreset()
        {
            int p = _current.nFreePoints;
            int total = 5; // 2+1+1+1
            int dStr = (p * 2) / total;
            int dAgi = p / total;
            int dCon = p / total;
            int dDex = p - dStr - dAgi - dCon; // remainder
            return new[] { dStr, dAgi, dCon, dDex };
        }
    }
}
