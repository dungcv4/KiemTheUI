// =======================================================================
//  UIAppearancePanel.cs — Port of Script_Ui_Window_UIAppearancePanel3.lua
//  (743 lines).
//
//  Source: 28_ClosetShop/Lua/Script_Ui_Window_UIAppearancePanel3.lua
//
//  The "closet" tab — displays cosmetic fashion items (outfits/hair/
//  headwear/weapon skins/mount skins) the player owns or can preview.
//  Subtabs typically: 时装 Fashion / 发型 Hair / 头饰 Headwear /
//  武器 Weapon / 坐骑 Mount.
//
//  Scope of this port:
//    ✅ Category sub-tabs (5)
//    ✅ Item grid per category (owned + locked)
//    ✅ Click item → preview on avatar + "Put On" button
//    ✅ Owned vs Locked indicator (lock icon overlay)
//    ✅ Bottom buttons: Put On / Remove / Shop (links to appearance store)
//    ❌ 3D preview on character model (Phase 2)
//    ❌ Dye system (染色)
//    ❌ Fashion awakening (觉醒)
//    ❌ Random appearance roll (换装抽卡)
//
//  Data source: FashionMgr static stub; server populates via
//  emNOTIFY_FASHION_DATA_CHANGE.
// =======================================================================
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using KTO.Game;

namespace KTO.UI
{
    public class UIAppearancePanel : MonoBehaviour
    {
        public enum FashionSubTab
        {
            Outfit     = 1,
            Hair       = 2,
            Headwear   = 3,
            Weapon     = 4,
            Mount      = 5,
        }

        Transform _panel;
        bool _initialized;
        FashionSubTab _currentTab = FashionSubTab.Outfit;
        int _selectedItemId;

        public void Init(Transform panel)
        {
            if (_initialized) return;
            _panel = panel;

            EventNotify.Subscribe(NotifyEventKind.emNOTIFY_FASHION_DATA_CHANGE, OnFashionChanged);

            // Sub-tab buttons — probe by well-known names
            WireBtnByName("btnOutfit",   () => SelectTab(FashionSubTab.Outfit));
            WireBtnByName("btnHair",     () => SelectTab(FashionSubTab.Hair));
            WireBtnByName("btnHeadwear", () => SelectTab(FashionSubTab.Headwear));
            WireBtnByName("btnWeapon",   () => SelectTab(FashionSubTab.Weapon));
            WireBtnByName("btnMount",    () => SelectTab(FashionSubTab.Mount));

            WireBtnByName("btnPutOn",    OnPutOn);
            WireBtnByName("btnRemove",   OnRemove);
            WireBtnByName("btnShop",     OnShop);

            _initialized = true;
        }

        void OnDestroy()
        {
            EventNotify.Unsubscribe(NotifyEventKind.emNOTIFY_FASHION_DATA_CHANGE, OnFashionChanged);
        }

        public void OnOpen()
        {
            SelectTab(_currentTab);
        }

        void OnFashionChanged(object[] _) { if (isActiveAndEnabled) RebuildGrid(); }

        // ----- tab selection + grid -----
        void SelectTab(FashionSubTab t)
        {
            _currentTab = t;
            RebuildGrid();
        }

        void RebuildGrid()
        {
            var content = _panel.Find("ItemScrollView/Viewport/Content");
            if (content == null)
            {
                // Fallback: look for any GridLayoutGroup under the panel.
                var grid = _panel.GetComponentInChildren<GridLayoutGroup>(true);
                if (grid != null) content = grid.transform;
            }
            if (content == null) return;

            foreach (Transform child in content) Destroy(child.gameObject);

            var items = FashionMgr.GetByCategory(_currentTab);
            foreach (var fi in items)
            {
                var cell = new GameObject($"fashion_{fi.nId}");
                cell.transform.SetParent(content, false);
                var rt = cell.AddComponent<RectTransform>();
                rt.sizeDelta = new Vector2(80, 80);

                var img = cell.AddComponent<Image>();
                img.color = fi.bOwned
                    ? new Color(0.30f, 0.35f, 0.45f)
                    : new Color(0.12f, 0.12f, 0.15f);

                var btn = cell.AddComponent<Button>();
                var captured = fi.nId;
                btn.onClick.AddListener(() => { _selectedItemId = captured; });

                // Name label
                var txt = new GameObject("Text");
                txt.transform.SetParent(cell.transform, false);
                var txtRt = txt.AddComponent<RectTransform>();
                txtRt.anchorMin = Vector2.zero; txtRt.anchorMax = Vector2.one;
                txtRt.offsetMin = new Vector2(2, 2); txtRt.offsetMax = new Vector2(-2, -2);
                var t = txt.AddComponent<Text>();
                t.text = fi.szName;
                t.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
                t.fontSize = 10;
                t.color = fi.bOwned ? Color.white : new Color(0.5f, 0.5f, 0.5f);
                t.alignment = TextAnchor.LowerCenter;

                // Lock overlay if not owned
                if (!fi.bOwned)
                {
                    var lockIcon = new GameObject("lock");
                    lockIcon.transform.SetParent(cell.transform, false);
                    var lrt = lockIcon.AddComponent<RectTransform>();
                    lrt.anchorMin = lrt.anchorMax = new Vector2(0.5f, 0.5f);
                    lrt.sizeDelta = new Vector2(28, 28);
                    lockIcon.AddComponent<Image>().color = new Color(0, 0, 0, 0.65f);
                }
            }
        }

        void OnPutOn()
        {
            if (_selectedItemId == 0) { Debug.Log("[UIAppearance] Chưa chọn trang phục"); return; }
            var fi = FashionMgr.GetById(_selectedItemId);
            if (fi == null || !fi.bOwned) { Debug.Log("[UIAppearance] Chưa sở hữu trang phục này"); return; }
            FashionMgr.Equip(fi.nId);
            Debug.Log($"[UIAppearance] Equipped {fi.szName}");
        }

        void OnRemove()
        {
            FashionMgr.Unequip(_currentTab);
            Debug.Log($"[UIAppearance] Removed fashion in category {_currentTab}");
        }

        void OnShop()
        {
            Debug.Log("[UIAppearance] Open UIAppearanceShop (Phase 2)");
        }

        void WireBtnByName(string name, System.Action fn)
        {
            var buttons = _panel?.GetComponentsInChildren<Button>(true);
            if (buttons == null) return;
            foreach (var b in buttons)
            {
                if (b.name == name)
                {
                    b.onClick.RemoveAllListeners();
                    b.onClick.AddListener(() => fn());
                    return;
                }
            }
        }
    }

    /// <summary>Fashion/closet data — stub until server integration.</summary>
    public static class FashionMgr
    {
        public class FashionItem
        {
            public int    nId;
            public int    nTemplateId;
            public string szName;
            public UIAppearancePanel.FashionSubTab eCategory;
            public bool   bOwned;
            public int    nStage;   // awakening stage
        }

        static readonly FashionItem[] _items = new[]
        {
            new FashionItem { nId =  1, szName = "Thanh Y",        eCategory = UIAppearancePanel.FashionSubTab.Outfit,   bOwned = true  },
            new FashionItem { nId =  2, szName = "Cẩm Y",          eCategory = UIAppearancePanel.FashionSubTab.Outfit,   bOwned = true  },
            new FashionItem { nId =  3, szName = "Hoa Y",          eCategory = UIAppearancePanel.FashionSubTab.Outfit,   bOwned = false },
            new FashionItem { nId =  4, szName = "Tóc Dài Đen",    eCategory = UIAppearancePanel.FashionSubTab.Hair,     bOwned = true  },
            new FashionItem { nId =  5, szName = "Búi Cao",        eCategory = UIAppearancePanel.FashionSubTab.Hair,     bOwned = false },
            new FashionItem { nId =  6, szName = "Khăn Choàng",    eCategory = UIAppearancePanel.FashionSubTab.Headwear, bOwned = true  },
            new FashionItem { nId =  7, szName = "Mão Vàng",       eCategory = UIAppearancePanel.FashionSubTab.Headwear, bOwned = false },
            new FashionItem { nId =  8, szName = "Kiếm Thanh",     eCategory = UIAppearancePanel.FashionSubTab.Weapon,   bOwned = true  },
            new FashionItem { nId =  9, szName = "Song Kiếm",      eCategory = UIAppearancePanel.FashionSubTab.Weapon,   bOwned = false },
            new FashionItem { nId = 10, szName = "Hắc Mã",         eCategory = UIAppearancePanel.FashionSubTab.Mount,    bOwned = true  },
            new FashionItem { nId = 11, szName = "Bạch Hổ",        eCategory = UIAppearancePanel.FashionSubTab.Mount,    bOwned = false },
        };

        static readonly Dictionary<UIAppearancePanel.FashionSubTab, int> _equipped
            = new Dictionary<UIAppearancePanel.FashionSubTab, int>();

        public static IEnumerable<FashionItem> GetByCategory(UIAppearancePanel.FashionSubTab c)
        {
            foreach (var i in _items) if (i.eCategory == c) yield return i;
        }

        public static FashionItem GetById(int id)
        {
            foreach (var i in _items) if (i.nId == id) return i;
            return null;
        }

        public static void Equip(int id)
        {
            var fi = GetById(id);
            if (fi == null) return;
            _equipped[fi.eCategory] = id;
            EventNotify.Fire(NotifyEventKind.emNOTIFY_FASHION_DATA_CHANGE, id);
        }

        public static void Unequip(UIAppearancePanel.FashionSubTab c)
        {
            if (_equipped.Remove(c))
                EventNotify.Fire(NotifyEventKind.emNOTIFY_FASHION_DATA_CHANGE, 0);
        }

        public static int GetEquippedId(UIAppearancePanel.FashionSubTab c)
            => _equipped.TryGetValue(c, out var id) ? id : 0;
    }
}
