// =======================================================================
//  UIItemBatchSell.cs — Port of Script_Ui_Window_UIItemBatchSellPanel.lua
//  (539 lines) — "batch sell" shortcut from the bag panel.
//
//  Source: 04_Bag/Lua/Script_Ui_Window_UIItemBatchSellPanel.lua
//
//  Flow: opens a list of all sellable items in the current bag filter tab,
//  user toggles rows + optionally selects quantity, clicks "Sell All" →
//  server sells them in bulk.
//
//  Scope of this port:
//    ✅ Lists sellable items matching the passed-in filter kind
//    ✅ Checkbox per row (toggle include/exclude)
//    ✅ Total price counter
//    ✅ "Sell All" button → drain checked items, credit coin
//    ✅ Close button
//
//  Built programmatically (no prefab load) for Phase A speed.
// =======================================================================
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using KTO.Game;
using KTO.Game.Bag;
using KTO.Game.Item;

namespace KTO.UI
{
    public class UIItemBatchSell : MonoBehaviour
    {
        static UIItemBatchSell _instance;
        GameObject _rootGo;
        int _filterKind;
        readonly HashSet<int> _checkedSlots = new HashSet<int>();
        Text _txtTotal;

        public static void Open(int filterKind)
        {
            if (_instance == null)
            {
                var go = new GameObject("[UIItemBatchSell]");
                _instance = go.AddComponent<UIItemBatchSell>();
            }
            _instance.OpenInternal(filterKind);
        }

        void OpenInternal(int filterKind)
        {
            _filterKind = filterKind;
            _checkedSlots.Clear();
            if (_rootGo != null) Destroy(_rootGo);

            var hud = GameObject.Find("HudRoot");
            _rootGo = new GameObject("UIItemBatchSellPanel");
            _rootGo.transform.SetParent(hud.transform, false);

            var canvas = _rootGo.AddComponent<Canvas>();
            canvas.overrideSorting = true;
            canvas.sortingOrder = 550;

            var rt = _rootGo.AddComponent<RectTransform>();
            rt.sizeDelta = new Vector2(460, 520);
            rt.anchorMin = rt.anchorMax = new Vector2(0.5f, 0.5f);
            rt.anchoredPosition = Vector2.zero;

            // Background
            var bg = _rootGo.AddComponent<Image>();
            bg.color = new Color(0.05f, 0.08f, 0.12f, 0.95f);

            // Title
            AddLabel("title", "Bán Hàng Loạt", Color.white, 20, -10, true);

            // Build scrollable item list
            BuildScrollView();

            // Total label + buttons at bottom
            _txtTotal = AddLabel("total", "Tổng: 0 bạc", new Color(0.95f, 0.9f, 0.3f), 16, -460, true);
            AddButton("btnSell",  "Bán Tất Cả", 40, -500, 180, 32, DoBatchSell);
            AddButton("btnClose", "Đóng",       260, -500, 160, 32, () => Destroy(_rootGo));
        }

        void BuildScrollView()
        {
            var viewportGo = new GameObject("Viewport");
            viewportGo.transform.SetParent(_rootGo.transform, false);
            var vRt = viewportGo.AddComponent<RectTransform>();
            vRt.anchorMin = new Vector2(0, 1); vRt.anchorMax = new Vector2(1, 1);
            vRt.pivot = new Vector2(0.5f, 1);
            vRt.offsetMin = new Vector2(10, -440); vRt.offsetMax = new Vector2(-10, -40);
            viewportGo.AddComponent<Image>().color = new Color(0.08f, 0.1f, 0.14f, 0.8f);
            viewportGo.AddComponent<Mask>().showMaskGraphic = false;

            var contentGo = new GameObject("Content");
            contentGo.transform.SetParent(viewportGo.transform, false);
            var cRt = contentGo.AddComponent<RectTransform>();
            cRt.anchorMin = new Vector2(0, 1); cRt.anchorMax = new Vector2(1, 1);
            cRt.pivot = new Vector2(0.5f, 1);
            cRt.offsetMin = Vector2.zero; cRt.offsetMax = Vector2.zero;

            var vlg = contentGo.AddComponent<VerticalLayoutGroup>();
            vlg.spacing = 2;
            vlg.padding = new RectOffset(4, 4, 4, 4);
            vlg.childControlHeight = false;
            vlg.childForceExpandHeight = false;
            vlg.childForceExpandWidth = true;

            var fitter = contentGo.AddComponent<ContentSizeFitter>();
            fitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;

            // Scroll rect
            var sr = _rootGo.AddComponent<ScrollRect>();
            sr.viewport = vRt;
            sr.content = cRt;
            sr.horizontal = false;
            sr.vertical = true;

            // Populate rows
            foreach (var kv in BagMgr.AllSlots)
            {
                var inst = kv.Value;
                var t = inst.Template;
                if (t == null) continue;
                if (t.nSellPrice <= 0 || !t.bTradable) continue;
                if (!UIBagPanel_MatchesFilter(inst, (UIBagPanel.FilterKind)_filterKind)) continue;
                BuildRow(contentGo.transform, inst);
            }
        }

        static bool UIBagPanel_MatchesFilter(ItemInstance i, UIBagPanel.FilterKind k)
        {
            // Duplicate of UIBagPanel.MatchesFilter — kept inline so this file
            // stays self-contained. If you change filter logic, sync both.
            var t = i.Template; if (t == null) return false;
            switch (k)
            {
                case UIBagPanel.FilterKind.TogAll:     return true;
                case UIBagPanel.FilterKind.TogEquip:   return t.nEquipPos > 0 && t.nEquipPos != EquipPos.HORSE;
                case UIBagPanel.FilterKind.TogStone:   return t.nType == (int)ItemType.Gem;
                case UIBagPanel.FilterKind.TogPartner: return t.nType == (int)ItemType.Pet;
                case UIBagPanel.FilterKind.TogNormal:
                    return t.nType == (int)ItemType.Consumable
                        || t.nType == (int)ItemType.Material
                        || t.nType == (int)ItemType.Other;
                default: return true;
            }
        }

        void BuildRow(Transform parent, ItemInstance inst)
        {
            var row = new GameObject($"row_{inst.nPos}");
            row.transform.SetParent(parent, false);
            var rRt = row.AddComponent<RectTransform>();
            rRt.sizeDelta = new Vector2(0, 30);
            row.AddComponent<Image>().color = new Color(0.12f, 0.14f, 0.18f);

            // Toggle
            var tog = new GameObject("tog");
            tog.transform.SetParent(row.transform, false);
            var tRt = tog.AddComponent<RectTransform>();
            tRt.anchorMin = new Vector2(0, 0.5f); tRt.anchorMax = new Vector2(0, 0.5f);
            tRt.pivot = new Vector2(0, 0.5f);
            tRt.sizeDelta = new Vector2(22, 22);
            tRt.anchoredPosition = new Vector2(8, 0);
            var togImg = tog.AddComponent<Image>();
            togImg.color = new Color(0.25f, 0.3f, 0.35f);
            var toggle = tog.AddComponent<Toggle>();
            toggle.graphic = togImg;
            toggle.isOn = false;
            toggle.onValueChanged.AddListener(v =>
            {
                if (v) _checkedSlots.Add(inst.nPos);
                else   _checkedSlots.Remove(inst.nPos);
                RefreshTotal();
            });

            // Row label
            var label = new GameObject("label");
            label.transform.SetParent(row.transform, false);
            var lRt = label.AddComponent<RectTransform>();
            lRt.anchorMin = new Vector2(0, 0); lRt.anchorMax = new Vector2(1, 1);
            lRt.offsetMin = new Vector2(40, 0); lRt.offsetMax = new Vector2(-4, 0);
            var txt = label.AddComponent<Text>();
            txt.text = $"{inst.szName}  ×{inst.nAmount}  →  {inst.Template.nSellPrice * inst.nAmount} bạc";
            txt.color = ItemDatabase.ColorForRarity(inst.nColor);
            txt.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
            txt.fontSize = 13;
            txt.alignment = TextAnchor.MiddleLeft;
        }

        Text AddLabel(string name, string text, Color c, int size, int y, bool bold = false)
        {
            var go = new GameObject(name);
            go.transform.SetParent(_rootGo.transform, false);
            var rt = go.AddComponent<RectTransform>();
            rt.anchorMin = new Vector2(0, 1); rt.anchorMax = new Vector2(1, 1);
            rt.pivot = new Vector2(0.5f, 1);
            rt.offsetMin = new Vector2(0, y - size - 8); rt.offsetMax = new Vector2(0, y);
            var t = go.AddComponent<Text>();
            t.text = text; t.color = c; t.fontSize = size;
            t.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
            t.alignment = TextAnchor.MiddleCenter;
            if (bold) t.fontStyle = FontStyle.Bold;
            return t;
        }

        void AddButton(string name, string label, int x, int y, int w, int h, System.Action fn)
        {
            var go = new GameObject(name);
            go.transform.SetParent(_rootGo.transform, false);
            var rt = go.AddComponent<RectTransform>();
            rt.anchorMin = new Vector2(0, 1); rt.anchorMax = new Vector2(0, 1);
            rt.pivot = Vector2.zero;
            rt.offsetMin = new Vector2(x, y); rt.offsetMax = new Vector2(x + w, y + h);
            rt.sizeDelta = new Vector2(w, h);
            go.AddComponent<Image>().color = new Color(0.20f, 0.42f, 0.48f);
            go.AddComponent<Button>().onClick.AddListener(() => fn());
            var textGo = new GameObject("Text");
            textGo.transform.SetParent(go.transform, false);
            var tRt = textGo.AddComponent<RectTransform>();
            tRt.anchorMin = Vector2.zero; tRt.anchorMax = Vector2.one;
            tRt.offsetMin = Vector2.zero; tRt.offsetMax = Vector2.zero;
            var tx = textGo.AddComponent<Text>();
            tx.text = label;
            tx.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
            tx.color = Color.white; tx.fontSize = 14;
            tx.alignment = TextAnchor.MiddleCenter;
        }

        void RefreshTotal()
        {
            long total = 0;
            foreach (var slot in _checkedSlots)
            {
                var it = BagMgr.GetItem(slot);
                if (it?.Template != null)
                    total += (long)it.nAmount * it.Template.nSellPrice;
            }
            if (_txtTotal != null) _txtTotal.text = $"Tổng: {total} bạc";
        }

        void DoBatchSell()
        {
            long totalGained = 0;
            int sold = 0;
            foreach (var slot in _checkedSlots)
            {
                var it = BagMgr.GetItem(slot);
                if (it?.Template == null || it.Template.nSellPrice <= 0) continue;
                totalGained += (long)it.nAmount * it.Template.nSellPrice;
                BagMgr.OnDelItem(slot);
                sold++;
            }
            if (totalGained > 0)
                MoneyMgr.SetMoney(MoneyMgr.MoneyType.Coin,
                    MoneyMgr.GetMoney(MoneyMgr.MoneyType.Coin) + totalGained);

            Debug.Log($"[UIItemBatchSell] Sold {sold} stacks for {totalGained} coin");
            Destroy(_rootGo);
        }
    }
}
