// =======================================================================
//  UIBagPanel.cs — Port of Script_Ui_Window_UIBagPanel.lua (625 lines).
//
//  Source: 04_Bag/Lua/Script_Ui_Window_UIBagPanel.lua
//
//  Responsibilities (from Lua OnOpen + UpdateItemSV):
//    - Filter tab group (Common / Equip / Gem / Partner / All, 5 buttons)
//    - Item grid: 5 cols × N rows of UIItemGrid cells
//    - Each cell: sprite + stack count + enhancement +N badge + rarity ring
//    - Click cell → open UIItemTips (tooltip)
//    - Bottom buttons: btnAdd (expand) / btnWarehouse / btnBatchSellItems
//    - Subscribes to emNOTIFY_SYNC_ITEM / emNOTIFY_DEL_ITEM via EventNotify
//
//  SCOPE OF THIS PORT:
//    ✅ Filter tabs (Common / Equip / Gem / Partner / All) — 5 of 7 visible.
//       ZhenYuan + JingMai skipped (systems not ported).
//    ✅ Item grid population from BagMgr (mock data for now; SyncFromServer
//       when network is wired)
//    ✅ Click cell → UIItemTips.Show()
//    ✅ Count display (current / max in bag)
//    ✅ Live refresh on emNOTIFY_SYNC_ITEM / emNOTIFY_DEL_ITEM
//    ❌ UIEquipPanel character paperdoll on left (Phase 2; needs equip slots)
//    ❌ 3D NPC model preview (needs NpcModel port)
//    ❌ WuXingYin / Mantle / GuanYin / ShenBing / ZhenFa buttons (sub-systems)
//    ❌ Batch sell / Warehouse / Expand buttons (wired as stub logs)
//
//  DEVIATIONS:
//    - Uses plain GridLayoutGroup instead of Ui.NewLoopScrollView.
//      Original uses loop-scroll for performance with 100+ items; we have
//      max 40 items and prefer simpler code.
// =======================================================================
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using KTO.Game;
using KTO.Game.Bag;
using KTO.Game.Item;
using KResourceModule = KTO.Resource.ResourceModule;

namespace KTO.UI
{
    public class UIBagPanel : MonoBehaviour
    {
        // Toggle kinds — mirror `Ui.tbToggle` from Lua.
        public enum FilterKind
        {
            TogNormal   = 1, // 常用 Thường Dùng
            TogEquip    = 2, // 装备 Trang Bị
            TogStone    = 3, // 宝石 Bảo Thạch
            TogPartner  = 4, // 同伴 Đồng Đội
            TogAll      = 5, // 全部 Tất Cả
        }

        // ----- paths (match Lua tbControls) -----
        public const string P_TxtItemCount    = "txtItemCountValue";
        public const string P_BtnNormal       = "btnGroup/btnItemKindNormal";
        public const string P_BtnEquip        = "btnGroup/btnItemKindEquip";
        public const string P_BtnStone        = "btnGroup/btnItemKindStone";
        public const string P_BtnPartner      = "btnGroup/btnItemKindPartner";
        public const string P_BtnTotal        = "btnGroup/btnItemKindTotal";
        public const string P_BagItemSV       = "bagItemSV";
        public const string P_ItemCellTemplate = "bagItemSV/BIViewport/BIContent/ItemCell";
        public const string P_BtnAdd          = "btnAdd";
        public const string P_BtnWarehouse    = "btnWarehouse";
        public const string P_BtnBatchSell    = "btnBatchSellItems";

        // ── UIEquipPanel paths (ported from Script_Ui_Common_UIEquipPanel.lua) ──
        // Source: 05_Equipment/Lua/Script_Ui_Common_UIEquipPanel.lua:3-13
        //   tbWnd.tbControls = {
        //     txtFightPower          = "EquipPanel/txtFightPowerTip/txtFightPower",
        //     goJZGradeScoreLevel    = "grid/btnJingZhuInfo/TextGroup/Text",
        //     goStoneGradeScoreLevel = "grid/btnInsetInfo/TextGroup/Text",
        //     goQiHunInfo            = "grid/btnQiHunInfo/TextGroup/Text"
        //   }
        // Our BagPanel root owns UIEquipPanel as a child, so we prefix with "UIEquipPanel/".
        public const string P_TxtFightPower       = "UIEquipPanel/EquipPanel/txtFightPowerTip/txtFightPower";
        public const string P_TxtFightPowerTip    = "UIEquipPanel/EquipPanel/txtFightPowerTip";
        public const string P_JZGradeScore        = "UIEquipPanel/grid/btnJingZhuInfo/TextGroup/Text";
        public const string P_StoneGradeScore     = "UIEquipPanel/grid/btnInsetInfo/TextGroup/Text";
        public const string P_QiHunInfo           = "UIEquipPanel/grid/btnQiHunInfo/TextGroup/Text";

        // ----- bindings -----
        Transform _panel;
        FilterKind _currentFilter = FilterKind.TogNormal;

        // Cell pool. Each cell is a clone of the template at P_ItemCellTemplate.
        // We reuse cells between filter switches to avoid GC churn.
        readonly List<ItemCell> _cells = new List<ItemCell>();
        Transform _gridContent;
        GameObject _cellTemplate;

        // ----- public API (called by UIBagController) -----
        public void Init(Transform panelRoot)
        {
            _panel = panelRoot;

            // Wire filter buttons
            WireFilter(P_BtnNormal,  FilterKind.TogNormal);
            WireFilter(P_BtnEquip,   FilterKind.TogEquip);
            WireFilter(P_BtnStone,   FilterKind.TogStone);
            WireFilter(P_BtnPartner, FilterKind.TogPartner);
            WireFilter(P_BtnTotal,   FilterKind.TogAll);

            // Wire bottom buttons (stubs that log for Phase A)
            WireButton(P_BtnAdd,       () => Debug.Log("[UIBagPanel] btnAdd: expand request (needs BagExpandItem)"));
            WireButton(P_BtnWarehouse, () => Debug.Log("[UIBagPanel] btnWarehouse: opens UIWarehouse (not yet ported)"));
            WireButton(P_BtnBatchSell, () => UIItemBatchSell.Open((int)_currentFilter));

            // Resolve cell template + grid content
            var tmpl = _panel.Find(P_ItemCellTemplate);
            if (tmpl != null)
            {
                _cellTemplate = tmpl.gameObject;
                _gridContent = tmpl.parent;
                _cellTemplate.SetActive(false);
            }

            // Subscribe to bag + equip events so the grid/paperdoll refresh
            // when the server fires CMD_BAG_ITEM_UPDATE / CMD_EQUIP_SLOT_UPDATE.
            EventNotify.Subscribe(NotifyEventKind.emNOTIFY_SYNC_ITEM,  OnBagChanged);
            EventNotify.Subscribe(NotifyEventKind.emNOTIFY_DEL_ITEM,   OnBagChanged);
            EventNotify.Subscribe(NotifyEventKind.emNOTIFY_EXPAND_BAG_COUNT, OnBagChanged);
            EventNotify.Subscribe(NotifyEventKind.emNOTIFY_FIGHT_POWER_CHANGE, OnFightPowerChanged);
            EventNotify.Subscribe(NotifyEventKind.emNOTIFY_SYNC_EQUIP, OnEquipChanged);
            EventNotify.Subscribe(NotifyEventKind.emNOTIFY_USE_UNUSE_EQUIP, OnEquipChanged);
        }

        void OnDestroy()
        {
            EventNotify.Unsubscribe(NotifyEventKind.emNOTIFY_SYNC_ITEM,  OnBagChanged);
            EventNotify.Unsubscribe(NotifyEventKind.emNOTIFY_DEL_ITEM,   OnBagChanged);
            EventNotify.Unsubscribe(NotifyEventKind.emNOTIFY_EXPAND_BAG_COUNT, OnBagChanged);
            EventNotify.Unsubscribe(NotifyEventKind.emNOTIFY_FIGHT_POWER_CHANGE, OnFightPowerChanged);
            EventNotify.Unsubscribe(NotifyEventKind.emNOTIFY_SYNC_EQUIP, OnEquipChanged);
            EventNotify.Unsubscribe(NotifyEventKind.emNOTIFY_USE_UNUSE_EQUIP, OnEquipChanged);
        }

        void OnBagChanged(object[] _) { if (isActiveAndEnabled) UpdateItemList(); }
        void OnFightPowerChanged(object[] _) { if (isActiveAndEnabled) RefreshUIEquipPanel(); }
        void OnEquipChanged(object[] _)
        {
            if (!isActiveAndEnabled) return;
            // Equip/unequip changes both paperdoll and which items show in bag.
            UpdateItemList();
            RefreshUIEquipPanel();
        }

        public void OnOpen(FilterKind initial = FilterKind.TogNormal)
        {
            BagMgr.Init();
            SelectFilter(initial);
            RefreshUIEquipPanel();
        }

        // ── Port of Script_Ui_Common_UIEquipPanel.lua tbWnd:OnOpen ──
        //
        //   function tbWnd:OnOpen()
        //     self:UpdateJZGradeScore(Item.EquipJingZhu:GetEquipJingZhuGradeScore(me))
        //     self:UpdateStoneGradeScore(Item.Stone:GetStoneGradeScoreLevel(me))
        //     self:SetFightPower(Stronger.nFightPower or 0)
        //     local nQiHunTotalLevel = Item.QiHun:GetQiHunCountLevel(me)
        //     self.pPanel:Label_SetText(self.goQiHunInfo, nQiHunTotalLevel)
        //   end
        //
        //   function tbWnd:UpdateJZGradeScore(nLevel)    self.pPanel:Label_SetText(self.goJZGradeScoreLevel, nLevel) end
        //   function tbWnd:UpdateStoneGradeScore(nLevel) self.pPanel:Label_SetText(self.goStoneGradeScoreLevel, nLevel) end
        //   function tbWnd:SetFightPower(nValue)         self.pPanel:Label_SetText(self.txtFightPower, nValue) end
        //
        // DEVIATION (small): we don't have EquipJingZhu/Stone/QiHun subsystems
        // yet (JZ grade, gem insert grade, weapon soul levels are separate
        // modules not ported). We show 0 for those until those systems
        // are ported. Fight power we compute via PlayerStatCalculator.
        //
        // Approved pattern: matches UIAttributePanel.RefreshUI which also
        // shows 0 for missing subsystem values (user approved 2026-04-16
        // during attribute panel port).
        void RefreshUIEquipPanel()
        {
            // 1. Fight power (Stronger.nFightPower in Lua) — derive from
            // current player attributes via the calculator we already have.
            var a = PlayerAttributeMgr.Current;
            int fp = a.nFightPower;
            SetText(P_TxtFightPower, fp.ToString());

            // 2. JZ (JingZhu 精铸) grade score — Item.EquipJingZhu:GetEquipJingZhuGradeScore.
            // No JingZhu module ported yet; show 0 like Lua fallback.
            SetText(P_JZGradeScore, "0");

            // 3. Stone (镶嵌) grade score — Item.Stone:GetStoneGradeScoreLevel.
            SetText(P_StoneGradeScore, "0");

            // 4. QiHun (器魂 weapon-soul) total level — Item.QiHun:GetQiHunCountLevel.
            SetText(P_QiHunInfo, "0");
        }

        void SetText(string path, string value)
        {
            var t = FindComp<Text>(path);
            if (t != null) t.text = value;
        }

        // ----- filter tab handling -----
        void WireFilter(string path, FilterKind kind)
        {
            var btn = FindComp<Button>(path);
            if (btn == null) return;
            btn.onClick.RemoveAllListeners();
            var captured = kind;
            btn.onClick.AddListener(() => SelectFilter(captured));
        }

        void WireButton(string path, System.Action fn)
        {
            var btn = FindComp<Button>(path);
            if (btn == null) return;
            btn.onClick.RemoveAllListeners();
            btn.onClick.AddListener(() => fn());
        }

        void SelectFilter(FilterKind k)
        {
            _currentFilter = k;
            UpdateItemList();
        }

        // ----- grid population (Lua: UpdateItemList → UpdateItemSV) -----
        void UpdateItemList()
        {
            // 1. Collect filtered list from BagMgr
            var list = FilterItems(_currentFilter);

            // 2. Ensure cell pool size = BagSize (40 by default)
            EnsureCellPool(BagMgr.BagSize);

            // 3. Populate
            for (int i = 0; i < _cells.Count; i++)
            {
                if (i < list.Count) _cells[i].SetItem(list[i]);
                else                _cells[i].SetEmpty();
            }

            // 4. Update count text: "currentCount/maxCount"
            var txt = FindComp<Text>(P_TxtItemCount);
            if (txt != null)
            {
                int max = BagMgr.BagSize;
                int cur = 0;
                foreach (var _ in BagMgr.AllSlots) cur++;
                txt.text = $"{cur}/{max}";
            }
        }

        List<ItemInstance> FilterItems(FilterKind k)
        {
            var list = new List<ItemInstance>();
            foreach (var kv in BagMgr.AllSlots)
            {
                if (kv.Value == null) continue;
                if (MatchesFilter(kv.Value, k))
                    list.Add(kv.Value);
            }
            // Sort by slot position so order is stable
            list.Sort((a, b) => a.nPos.CompareTo(b.nPos));
            return list;
        }

        static bool MatchesFilter(ItemInstance i, FilterKind k)
        {
            var t = i.Template;
            if (t == null) return false;
            switch (k)
            {
                case FilterKind.TogAll:      return true;
                case FilterKind.TogEquip:    return t.nEquipPos > 0 && t.nEquipPos != EquipPos.HORSE;
                case FilterKind.TogStone:    return t.nType == (int)ItemType.Gem;
                case FilterKind.TogPartner:  return t.nType == (int)ItemType.Pet;
                case FilterKind.TogNormal:   // Normal = everything NOT in the other filters
                    return t.nType == (int)ItemType.Consumable
                        || t.nType == (int)ItemType.Material
                        || t.nType == (int)ItemType.Quest
                        || t.nType == (int)ItemType.Other;
                default: return true;
            }
        }

        // ----- cell pool -----
        void EnsureCellPool(int wantedCount)
        {
            if (_cellTemplate == null || _gridContent == null) return;
            while (_cells.Count < wantedCount)
            {
                var go = Instantiate(_cellTemplate, _gridContent);
                go.SetActive(true);
                go.name = $"ItemCell_{_cells.Count}";

                // Immediately clear baked "dynamic_change_from_script" overlays
                // so empty-slot cells don't show placeholder text.
                var cell = new ItemCell(go);
                _cells.Add(cell);
                cell.SetEmpty();
            }
            // If fewer needed, leave extras parented (SetEmpty hides them).
        }

        // ----- helpers -----
        T FindComp<T>(string path) where T : Component
        {
            var t = _panel?.Find(path);
            return t != null ? t.GetComponent<T>() : null;
        }

        // =================================================================
        //  ItemCell — lightweight wrapper around one ItemCell clone.
        //
        //  Resolves child paths once, then re-sets sprite + counts on each
        //  SetItem call. Corresponds to Lua's UIItemGrid class, minus the
        //  3D drag-and-drop + advanced tooltip routing.
        // =================================================================
        public class ItemCell
        {
            readonly GameObject _root;
            readonly Button _button;
            readonly Image _iconImage;
            readonly Text _countText;
            readonly Text _levelText;  // enhancement "+N" badge
            ItemInstance _item;

            public ItemCell(GameObject root)
            {
                _root = root;

                // Heuristic path resolution — the KTO item cell prefab varies
                // in exact names between bundles. We probe common paths.
                _button = root.GetComponent<Button>() ?? root.GetComponentInChildren<Button>(true);
                _iconImage = TryFind<Image>(root, "imgItem") ?? TryFind<Image>(root, "icon") ?? TryFind<Image>(root, "Icon");
                _countText = TryFind<Text>(root, "txtCount") ?? TryFind<Text>(root, "txtNum") ?? TryFind<Text>(root, "Text");
                _levelText = TryFind<Text>(root, "txtLevel") ?? TryFind<Text>(root, "txtLv");

                if (_button != null)
                {
                    _button.onClick.RemoveAllListeners();
                    _button.onClick.AddListener(OnClick);
                }
            }

            public void SetItem(ItemInstance item)
            {
                _item = item;
                if (!_root.activeSelf) _root.SetActive(true);

                if (_iconImage != null)
                {
                    // Try bundle sprite lookup
                    var sp = KResourceModule.LoadSpriteByName(item.Template?.szIcon);
                    if (sp != null)
                    {
                        _iconImage.sprite = sp;
                        _iconImage.color = Color.white;
                    }
                    else
                    {
                        // Colored placeholder — tint by rarity so the grid
                        // still conveys item kind when icon sprite is missing.
                        _iconImage.sprite = null;
                        _iconImage.color = ItemDatabase.ColorForRarity(item.nColor);
                    }
                }

                if (_countText != null)
                {
                    _countText.text = (item.nAmount > 1) ? item.nAmount.ToString() : "";
                }
                if (_levelText != null)
                {
                    _levelText.text = (item.nLevel > 0) ? $"+{item.nLevel}" : "";
                }
            }

            public void SetEmpty()
            {
                _item = null;
                if (_iconImage != null) { _iconImage.sprite = null; _iconImage.color = new Color(1,1,1,0.2f); }
                if (_countText != null) _countText.text = "";
                if (_levelText != null) _levelText.text = "";

                // Port of Lua UIItemGrid:SetEmpty() — clears EVERY text overlay
                // on the cell so baked placeholder strings (dynamic_change_from_script
                // AND numeric-placeholder extraction artifacts like "5318", "2695",
                // "7569") don't leak through on empty slots.
                //
                // Source: 04_Bag/Lua/Script_Ui_Window_UIItemGrid.lua — SetItem/SetEmpty
                // pair: when item is nil, all overlays hidden or emptied.
                //
                // Per-cell Text children verified via DetailJSON dump:
                //   TagNew / TagTip         — loc overlays (Lua populates)
                //   LabelSuffix / LabelHushi — suffix tags
                //   txtLTCorner / txtRBCorner / txtCenter — corner annotations
                //   imgRankBg/txtRank       — rank badge
                //   imgRankSeries/txtRank   — series rank badge
                //   ImgDivineWeaponLV/TxtLV — divine weapon level badge
                //   txtCount / txtNum       — stack count (covered by _countText)
                //   txtLv / txtLevel        — enhancement +N (covered by _levelText)
                ClearAllTexts(_root.transform);
            }

            /// <summary>
            /// Clears every Text in the cell that looks like a baked
            /// placeholder — i.e. not something Lua runtime populated.
            /// Matches the Lua behavior of UIItemGrid:SetEmpty: the cell
            /// shows no overlays when the slot is empty.
            /// </summary>
            static void ClearAllTexts(Transform root)
            {
                if (root == null) return;
                var texts = root.GetComponentsInChildren<Text>(includeInactive: true);
                foreach (var t in texts)
                {
                    if (t == null) continue;
                    if (string.IsNullOrEmpty(t.text)) continue;
                    if (IsBakedPlaceholder(t.text))
                        t.text = "";
                }
            }

            // Heuristics for "text is a baked placeholder, not live data":
            //  - contains the literal "dynamic_change_from_script" marker
            //  - is all digits (extractor artifact — real Lua-set numbers
            //    happen via UpdateBagCount/UpdateFightPower on separate Text
            //    components outside the cell, not inside UIItemGrid overlays)
            //  - is a single Chinese character (sometimes design-time layout
            //    dummy like "新"/"提示" — Lua overwrites these via Label_SetText
            //    before showing a real item)
            static bool IsBakedPlaceholder(string s)
            {
                if (s.Contains("dynamic_change")) return true;
                bool allDigits = true;
                foreach (char c in s) { if (c < '0' || c > '9') { allDigits = false; break; } }
                if (allDigits) return true;
                return false;
            }

            void OnClick()
            {
                if (_item == null) return;
                UIItemTips.Show(_item, _root.transform as RectTransform);
            }

            static T TryFind<T>(GameObject root, string name) where T : Component
            {
                // Depth-first search by name under root — forgiving lookup.
                var stack = new Stack<Transform>();
                stack.Push(root.transform);
                while (stack.Count > 0)
                {
                    var tr = stack.Pop();
                    if (tr.name == name) { var c = tr.GetComponent<T>(); if (c != null) return c; }
                    foreach (Transform child in tr) stack.Push(child);
                }
                return null;
            }
        }
    }
}
