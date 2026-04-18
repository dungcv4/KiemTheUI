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

            // Resolve cell template + grid container.
            //
            // Layout per DetailJSON inspection:
            //   BIContent                 — ScrollRect Content
            //     └── ItemCell            — GridLayoutGroup container (the ACTUAL grid)
            //           ├── Item1..Item5  — 5 individual cell prefabs
            //
            // So `ItemCell` is the CONTAINER, and Item1 is the cell template.
            // We keep Item1 as the single prototype and clone it into
            // ItemCell to reach 40 cells. Items 2-5 become the first 4
            // clones (re-used). GridLayoutGroup auto-arranges them.
            var itemCell = _panel.Find(P_ItemCellTemplate);
            if (itemCell != null)
            {
                _gridContent = itemCell;                     // container
                var item1 = itemCell.Find("Item1");
                if (item1 != null)
                    _cellTemplate = item1.gameObject;         // single cell prototype

                // Configure the GridLayoutGroup to give us a 5-column grid
                // (original Lua LoopScrollView used nRow=5 meaning 5 columns).
                var grid = itemCell.GetComponent<GridLayoutGroup>();
                if (grid != null)
                {
                    grid.cellSize    = new Vector2(78, 78);
                    grid.spacing     = new Vector2(4, 4);
                    grid.constraint  = GridLayoutGroup.Constraint.FixedColumnCount;
                    grid.constraintCount = 5;
                    grid.startCorner = GridLayoutGroup.Corner.UpperLeft;
                    grid.startAxis   = GridLayoutGroup.Axis.Horizontal;
                    grid.childAlignment = TextAnchor.UpperLeft;
                }

                // The original prefab ships ItemCell at 80×80 (matches a
                // single cell) — the Lua LoopScrollView resizes it at runtime.
                // Our non-virtualized grid needs ItemCell sized to fit all
                // 40 cells: 5 cols × 78 + 4×4 spacing ≈ 406 wide,
                //           8 rows × 78 + 7×4 spacing ≈ 652 tall.
                // Clamp to the viewport width so the scrollable area stays
                // within bounds.
                var rt = itemCell as RectTransform;
                if (rt != null)
                {
                    const int cols = 5, rows = 8;
                    const float cell = 78f, sp = 4f;
                    float gridW = cols * cell + (cols - 1) * sp;   // 406
                    float gridH = rows * cell + (rows - 1) * sp;   // 652
                    rt.pivot     = new Vector2(0f, 1f);
                    rt.anchorMin = new Vector2(0f, 1f);
                    rt.anchorMax = new Vector2(0f, 1f);
                    rt.anchoredPosition = new Vector2(0f, 0f);
                    rt.sizeDelta = new Vector2(gridW, gridH);
                }

                // BIContent (ScrollRect Content): normalize pivot/anchors to
                // top-left so ItemCell's anchoredPos (0,0) matches the
                // viewport's top-left, not a centered pivot.
                // Without this the 406-wide grid renders at x=-424 relative
                // to a 439-wide viewport and ~2 columns get clipped off the
                // left edge (saw 3 cols visible instead of 5).
                var contentRt = itemCell.parent as RectTransform;   // BIContent
                if (contentRt != null)
                {
                    contentRt.pivot     = new Vector2(0f, 1f);
                    contentRt.anchorMin = new Vector2(0f, 1f);
                    contentRt.anchorMax = new Vector2(0f, 1f);
                    contentRt.anchoredPosition = Vector2.zero;
                    contentRt.sizeDelta = new Vector2(410f, 660f);
                }
            }

            // ── Equip slot labels (left paperdoll) ────────────────────
            //
            // Source: 05_Equipment/Lua/Script_Ui_Common_UIEquipPanel.lua:178
            //   self.tbGridTextList[i] = tbEquipPosKey[i] .. "/Text"
            //   self.pPanel:SetActive(self.tbGridTextList[i], true)  -- show name
            // Each slot's child "Text" shows the Vietnamese slot name when empty;
            // replaced by the equipped item's icon when occupied (SetActive false
            // on the name, true on UIItemGrid).
            //
            // Labels from original UI screenshot (user-provided reference).
            SetupEquipSlotLabels();

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
            RefreshEquipSlotIcons();
        }

        // ── Paperdoll icons on equip / label on empty ──
        //
        // Port of Script_Ui_Common_UIEquipPanel.lua tbWnd:SetEquip()
        // (line 252 — if nItemId>0: show icon, hide label; else opposite).
        //
        // Maps EquipMgr.EquipSlot → prefab path and toggles visibility of
        // the slot's Text (Vietnamese label) + UIItemGrid (item icon).
        void RefreshEquipSlotIcons()
        {
            const string root = "UIEquipPanel/EquipPanel/PanelEquip";
            var slotPaths = new System.Collections.Generic.Dictionary<KTO.Game.Bag.EquipSlot, string>
            {
                { KTO.Game.Bag.EquipSlot.Helm,     $"{root}/grid1/Helm" },
                { KTO.Game.Bag.EquipSlot.Cuff,     $"{root}/grid1/Cuff" },
                { KTO.Game.Bag.EquipSlot.Armor,    $"{root}/grid1/Armor" },
                { KTO.Game.Bag.EquipSlot.Belt,     $"{root}/grid1/Belt" },
                { KTO.Game.Bag.EquipSlot.Boots,    $"{root}/grid1/Boots" },
                { KTO.Game.Bag.EquipSlot.Weapon,   $"{root}/grid2/Weapon" },
                { KTO.Game.Bag.EquipSlot.Necklace, $"{root}/grid2/Necklace" },
                { KTO.Game.Bag.EquipSlot.Ring,     $"{root}/grid2/Ring" },
                { KTO.Game.Bag.EquipSlot.Pendant,  $"{root}/grid2/Pendant" },
                { KTO.Game.Bag.EquipSlot.Amulet,   $"{root}/grid2/Amulet" },
            };
            foreach (var kv in slotPaths)
            {
                var slotTr = _panel.Find(kv.Value);
                if (slotTr == null) continue;
                var inst = KTO.Game.Bag.EquipMgr.Get(kv.Key);
                var label  = slotTr.Find("Text");
                var grid   = slotTr.Find("UIItemGrid");
                bool occupied = inst != null && inst.dwId != 0;

                if (label != null) label.gameObject.SetActive(!occupied);
                if (grid != null)
                {
                    grid.gameObject.SetActive(occupied);
                    if (occupied)
                    {
                        // Plug the item's icon into UIItemGrid/ItemLayer
                        var itemLayerImg = grid.Find("ItemLayer")?.GetComponent<Image>();
                        if (itemLayerImg != null)
                        {
                            var sp = KResourceModule.LoadSpriteByName(inst.Template?.szIcon);
                            if (sp != null)
                            {
                                itemLayerImg.sprite = sp;
                                itemLayerImg.color  = Color.white;
                            }
                            else
                            {
                                // No icon — show rarity-tinted rect so the
                                // slot still reads as "equipped" (not empty).
                                itemLayerImg.sprite = null;
                                itemLayerImg.color  = ItemDatabase.ColorForRarity(inst.nColor);
                            }
                        }
                    }
                }
            }
        }

        public void OnOpen(FilterKind initial = FilterKind.TogAll)
        {
            BagMgr.Init();
            SelectFilter(initial);
            RefreshUIEquipPanel();
            RefreshSeriesIcon();
            ActivateNpcModelPlaceholder();
        }

        // ── Element icon (Kim / Mộc / Thuỷ / Hoả / Thổ) on character ──
        //
        // Port of Script_Ui_Common_UIEquipPanel.lua:196-200:
        //   local szPlayerSeries = KPlayer.GetPlayerInitInfo(me.nFaction).nSeries
        //   for index, sztxt in ipairs(tbSeriesNumberToTextName) do
        //       self.pPanel:SetActive(btnSeriesText/sztxt, false)
        //   end
        //   self.pPanel:SetActive(btnSeriesText/tbSeriesNumberToTextName[szPlayerSeries], true)
        //
        // tbSeriesNumberToTextName = { [1]="txtMetal", [2]="txtWood",
        //                              [3]="txtWater", [4]="txtFire", [5]="txtEarth" }
        //
        // DEVIATION: we don't have KPlayer.GetPlayerInitInfo server data yet
        // so faction→series mapping is hardcoded from ingame observation
        // (Cái Bang/Võ Đang faction=Thuỷ, etc.). Matches the user's screenshot.
        void RefreshSeriesIcon()
        {
            string[] all = { "txtMetal", "txtWood", "txtWater", "txtFire", "txtEarth" };
            foreach (var s in all)
            {
                var tr = _panel.Find($"UIEquipPanel/btnSeriesText/{s}");
                if (tr != null) tr.gameObject.SetActive(false);
            }

            // Pick series by faction. Mapping from KTO faction .tab:
            //   1=Thiếu Lâm→txtMetal, 2=Thiên Nhẫn→txtWood, 3=Võ Đang→txtWater,
            //   4=Đường Môn→txtFire, 5=Cái Bang→txtEarth, 6=Minh Giáo→txtMetal,
            //   7=Thuý Yên→txtWater, 8=Côn Lôn→txtWood, 9=Nga Mi→txtFire.
            // (Approximate — source was KPlayer.GetPlayerInitInfo which needs
            // server data. TestHero faction=1; override via player data later.)
            int faction = PlayerAttributeMgr.Current.nFactionId;
            string pick = faction switch
            {
                1 => "txtMetal",  2 => "txtWood",  3 => "txtWater",
                4 => "txtFire",   5 => "txtEarth", 6 => "txtMetal",
                7 => "txtWater",  8 => "txtWood",  9 => "txtFire",
                _ => "txtWater",
            };
            var sel = _panel.Find($"UIEquipPanel/btnSeriesText/{pick}");
            if (sel != null) sel.gameObject.SetActive(true);
        }

        // ── NpcModel placeholder ───────────────────────────────────
        //
        // The original renders a 3D character preview inside NpcModel via
        // UINpcModel component (not yet ported). For now we just make sure
        // the GameObject is active so the hit-zone / frame shows, and
        // preserve its sort position.
        //
        // Full port (Phase 2+): plug in PlayerAssembler rendered into an
        // SSO render texture, sampled by an Image inside NpcModel.
        void ActivateNpcModelPlaceholder()
        {
            var go = _panel.Find("NpcModel");
            if (go != null && !go.gameObject.activeSelf)
                go.gameObject.SetActive(true);
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

        // ── Equip slot labels — one-shot setup at panel Init ──────
        //
        // Each equipment slot GameObject (Helm / Armor / ... / Mantle) has
        // a child called "Text" that displays the Vietnamese category name
        // when the slot is empty. The Lua UIEquipPanel toggles visibility
        // of these labels vs the UIItemGrid icon based on whether the slot
        // is occupied (see Script_Ui_Common_UIEquipPanel.lua:178 + 301).
        //
        // Paths from DetailJSON/UIBag_res_p_27.json:
        //   UIEquipPanel/EquipPanel/PanelEquip/grid1/Helm/Text
        //   UIEquipPanel/EquipPanel/PanelEquip/grid1/Cuff/Text
        //   UIEquipPanel/EquipPanel/PanelEquip/grid1/Armor/Text
        //   UIEquipPanel/EquipPanel/PanelEquip/grid1/Belt/Text
        //   UIEquipPanel/EquipPanel/PanelEquip/grid1/Boots/Text
        //   UIEquipPanel/EquipPanel/PanelEquip/grid2/Weapon/Text
        //   UIEquipPanel/EquipPanel/PanelEquip/grid2/Necklace/Text
        //   UIEquipPanel/EquipPanel/PanelEquip/grid2/Ring/Text
        //   UIEquipPanel/EquipPanel/PanelEquip/grid2/Pendant/Text
        //   UIEquipPanel/EquipPanel/PanelEquip/grid2/Amulet/Text
        //   UIEquipPanel/EquipPanel/PanelEquip/grid3/Wuxingyin/Text
        //   UIEquipPanel/EquipPanel/PanelEquip/grid3/Guanyin/Text
        //   UIEquipPanel/EquipPanel/PanelEquip/grid3/Mantle/Text
        //
        // Label translations match user's reference screenshot of the
        // original KTO client (Vietnamese release).
        void SetupEquipSlotLabels()
        {
            const string root = "UIEquipPanel/EquipPanel/PanelEquip";
            SetText($"{root}/grid1/Helm/Text",      "Nón");
            SetText($"{root}/grid1/Cuff/Text",      "Hộ Uyển");
            SetText($"{root}/grid1/Armor/Text",     "Y Phục");
            SetText($"{root}/grid1/Belt/Text",      "Đai");
            SetText($"{root}/grid1/Boots/Text",     "Giày");
            SetText($"{root}/grid2/Weapon/Text",    "Vũ Khí");
            SetText($"{root}/grid2/Necklace/Text",  "Dây Chuyền");
            SetText($"{root}/grid2/Ring/Text",      "Nhẫn");
            SetText($"{root}/grid2/Pendant/Text",   "Ngọc Bội");
            SetText($"{root}/grid2/Amulet/Text",    "Hộ Thân Phù");
            SetText($"{root}/grid3/Wuxingyin/Text", "Ngũ Hành Ấn");
            SetText($"{root}/grid3/Guanyin/Text",   "Quan Ấn");
            SetText($"{root}/grid3/Mantle/Text",    "Phi Phong");

            // Also make sure the GameObjects hosting the label Text are
            // active — import pipeline may have left them inactive.
            string[] slotPaths = {
                $"{root}/grid1/Helm/Text",       $"{root}/grid1/Cuff/Text",
                $"{root}/grid1/Armor/Text",      $"{root}/grid1/Belt/Text",
                $"{root}/grid1/Boots/Text",      $"{root}/grid2/Weapon/Text",
                $"{root}/grid2/Necklace/Text",   $"{root}/grid2/Ring/Text",
                $"{root}/grid2/Pendant/Text",    $"{root}/grid2/Amulet/Text",
                $"{root}/grid3/Wuxingyin/Text",  $"{root}/grid3/Guanyin/Text",
                $"{root}/grid3/Mantle/Text",
            };
            foreach (var p in slotPaths)
            {
                var tr = _panel.Find(p);
                if (tr != null && !tr.gameObject.activeSelf)
                    tr.gameObject.SetActive(true);
            }

            // Hide the UIItemGrid sibling on each slot so the "empty slot"
            // label is visible. Original Lua: each slot has a `Text` (the
            // Vietnamese name) AND a `UIItemGrid` (the item icon); only one
            // is active at a time — UIItemGrid when equipped, Text when empty.
            // No equipment is synced yet, so every slot is empty → hide grids.
            string[] slotParents = {
                $"{root}/grid1/Helm",  $"{root}/grid1/Cuff",
                $"{root}/grid1/Armor", $"{root}/grid1/Belt",
                $"{root}/grid1/Boots", $"{root}/grid2/Weapon",
                $"{root}/grid2/Necklace", $"{root}/grid2/Ring",
                $"{root}/grid2/Pendant",  $"{root}/grid2/Amulet",
                $"{root}/grid3/Wuxingyin", $"{root}/grid3/Guanyin",
                $"{root}/grid3/Mantle",
            };
            foreach (var sp in slotParents)
            {
                var tr = _panel.Find(sp);
                if (tr == null) continue;
                var grid = tr.Find("UIItemGrid");
                if (grid != null)
                    grid.gameObject.SetActive(false);
                // txtJingZhuLv (enhance +N badge) also hides on empty slots.
                var lv = tr.Find("txtJingZhuLv");
                if (lv != null)
                    lv.gameObject.SetActive(false);
            }
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
        //
        // Prefab layout (verified via DetailJSON):
        //   BIContent/ItemCell  — GridLayoutGroup container (the grid)
        //     ├── Item1..Item5  — 5 cell prefabs, originally the first row
        //                         of the Lua LoopScrollView
        //
        // The original Lua uses LoopScrollView (5 virtual cells recycled on
        // scroll). We go simpler: materialize all 40 cells and let the
        // GridLayoutGroup (configured 5-column) arrange them — matches the
        // full 5×8 grid in the user's reference screenshot.
        //
        // First call: adopt Item1..Item5 that shipped in the prefab as the
        // first 5 pool entries, then clone Item1 (35 more times) to reach 40.
        void EnsureCellPool(int wantedCount)
        {
            if (_cellTemplate == null || _gridContent == null) return;

            // Step 1: adopt the 5 shipped prototypes on first call.
            // Also strip the bogus bg/Base sprites the import pipeline
            // assigned (DetailJSON shows these should be null on empty
            // cells — the importer picked dark HUD sprites as fallbacks
            // which made every cell look like a dark brown box).
            if (_cells.Count == 0)
            {
                for (int i = 1; i <= 5; i++)
                {
                    var slot = _gridContent.Find($"Item{i}");
                    if (slot == null) continue;
                    slot.gameObject.SetActive(true);
                    StripCellBackdrop(slot);
                    var cell = new ItemCell(slot.gameObject);
                    _cells.Add(cell);
                    cell.SetEmpty();
                }
            }

            // Step 2: clone Item1 into the grid container up to wantedCount.
            while (_cells.Count < wantedCount)
            {
                var go = Instantiate(_cellTemplate, _gridContent);
                go.SetActive(true);
                go.name = $"ItemCell_{_cells.Count}";
                StripCellBackdrop(go.transform);
                var cell = new ItemCell(go);
                _cells.Add(cell);
                cell.SetEmpty();
            }
        }

        // Strip the wrong sprites the import pipeline assigned to the
        // cell backdrop layers, AND hide every layer that's meant to be
        // item-state-specific (CDLayer, imgPlus, TagCanDeal, etc.) so
        // empty cells match the original's clean cream/transparent look
        // (user reference screenshot). Without this, empty cells render
        // dark gray because of assigned HUD textures + tag overlays.
        //
        // Original DetailJSON/UIBag_res_p_27.json has bg/Base/ItemLayer
        // with sprite=null. Our importer fell back to HUD sprites
        // (itemframebg/itembaseOrange/chunyangwuji → dark). Tags like
        // CDLayer/TagMarketStall only activate at runtime when the
        // item's state warrants them.
        static void StripCellBackdrop(Transform cellRoot)
        {
            // Only the 3 backdrop layers that the import pipeline wrongly
            // assigned HUD textures to (itemframebg, itembaseOrange,
            // chunyangwuji). Clearing these restores the cell to its
            // DetailJSON original state (sprite=null, invisible). The
            // state-tag overlays (CDLayer, TagMarketStall, etc.) default
            // to inactive in Unity UGUI — leaving them alone keeps the
            // prefab's layout intact.
            string[] stripLayers = {
                "UIItemGrid/bg",
                "UIItemGrid/Base",
                "UIItemGrid/ItemLayer",
            };
            foreach (var p in stripLayers)
            {
                var tr = cellRoot.Find(p);
                if (tr == null) continue;
                var img = tr.GetComponent<Image>();
                if (img != null)
                {
                    img.sprite = null;
                    img.color  = new Color(1f, 1f, 1f, 0f);
                }
            }
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
                // Cell structure per DetailJSON inspection:
                //   Item{N}                  — Image + Button (the cell root)
                //     └── UIItemGrid         — container with layout bits
                //           ├── ItemLayer    — Image (THE ICON) + Button
                //           ├── txtCenter    — stack count center text
                //           ├── txtRBCorner  — stack count bottom-right
                //           ├── imgRankBg/txtRank — rank/enhance badge
                //           ├── ImgLTCorner  — enhance level overlay
                //           └── ... (TagNew/TagTip/CDLayer/etc)
                _button    = root.GetComponent<Button>() ?? root.GetComponentInChildren<Button>(true);
                _iconImage = TryFind<Image>(root, "ItemLayer")
                          ?? TryFind<Image>(root, "imgItem")
                          ?? TryFind<Image>(root, "icon")
                          ?? TryFind<Image>(root, "Icon");
                _countText = TryFind<Text>(root, "txtCenter")
                          ?? TryFind<Text>(root, "txtRBCorner")
                          ?? TryFind<Text>(root, "txtCount")
                          ?? TryFind<Text>(root, "txtNum");
                _levelText = TryFind<Text>(root, "ImgLTCorner")
                          ?? TryFind<Text>(root, "txtLTCorner")
                          ?? TryFind<Text>(root, "txtLevel")
                          ?? TryFind<Text>(root, "txtLv");

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

                // Make sure UIItemGrid child is visible (it may have been
                // hidden by SetEmpty or by an equip-slot-style setup where
                // empty slots hide the grid in favor of a "Nón" label).
                var grid = _root.transform.Find("UIItemGrid");
                if (grid != null && !grid.gameObject.activeSelf)
                    grid.gameObject.SetActive(true);

                if (_iconImage != null)
                {
                    if (!_iconImage.gameObject.activeSelf)
                        _iconImage.gameObject.SetActive(true);
                    // Try bundle sprite lookup
                    var sp = KResourceModule.LoadSpriteByName(item.Template?.szIcon);
                    if (sp != null)
                    {
                        _iconImage.sprite = sp;
                        _iconImage.color = Color.white;
                    }
                    else
                    {
                        // No sprite found — keep the icon transparent (match
                        // original behavior: empty slot = no icon). The
                        // rarity-colored placeholder made the grid noisy
                        // since it's drawn on top of bg, producing the
                        // dark-brown look user flagged.
                        _iconImage.sprite = null;
                        _iconImage.color = new Color(1f, 1f, 1f, 0f);
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
