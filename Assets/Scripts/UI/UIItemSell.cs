// =======================================================================
//  UIItemSell.cs — Port of Script_Ui_Window_UIItemSell.lua (87 lines).
//
//  Source: 04_Bag/Lua/Script_Ui_Window_UIItemSell.lua
//  Quick confirm dialog: "Sell X <item> for Y coin?"  [Cancel] [Confirm]
//
//  Scope: full port of the small flow — pick quantity slider, show total
//  price, confirm → BagMgr mutation (client-side for now; real game sends
//  CMD_KT_C2G_SELL_ITEM to the server).
// =======================================================================
using UnityEngine;
using UnityEngine.UI;
using KTO.Game;
using KTO.Game.Bag;
using KTO.Game.Item;

namespace KTO.UI
{
    public class UIItemSell : MonoBehaviour
    {
        static UIItemSell _instance;
        GameObject _rootGo;
        ItemInstance _item;
        int _sellCount = 1;
        Text _txtTotalPrice;

        public static void Show(ItemInstance item)
        {
            if (item == null || item.Template == null || item.Template.nSellPrice <= 0) return;
            if (_instance == null)
            {
                var go = new GameObject("[UIItemSell]");
                _instance = go.AddComponent<UIItemSell>();
            }
            _instance.ShowInternal(item);
        }

        void ShowInternal(ItemInstance item)
        {
            _item = item;
            _sellCount = 1;
            if (_rootGo != null) Destroy(_rootGo);

            var hud = GameObject.Find("HudRoot");
            _rootGo = new GameObject("UIItemSellPanel");
            _rootGo.transform.SetParent(hud.transform, false);

            var canvas = _rootGo.AddComponent<Canvas>();
            canvas.overrideSorting = true;
            canvas.sortingOrder = 600;

            var rt = _rootGo.AddComponent<RectTransform>();
            rt.sizeDelta = new Vector2(360, 180);
            rt.anchorMin = rt.anchorMax = new Vector2(0.5f, 0.5f);
            rt.anchoredPosition = Vector2.zero;

            var bg = new GameObject("bg");
            bg.transform.SetParent(_rootGo.transform, false);
            var bgRt = bg.AddComponent<RectTransform>();
            bgRt.anchorMin = Vector2.zero; bgRt.anchorMax = Vector2.one;
            bgRt.offsetMin = Vector2.zero; bgRt.offsetMax = Vector2.zero;
            bg.AddComponent<Image>().color = new Color(0.05f, 0.08f, 0.12f, 0.95f);

            AddLabel("title", $"Bán: {item.szName}", Color.white, 18, -10, true);
            AddLabel("unit", $"Giá đơn: {item.Template.nSellPrice} bạc", new Color(0.9f, 0.85f, 0.5f), 13, -42);
            _txtTotalPrice = AddLabel("total", "", new Color(0.95f, 0.9f, 0.3f), 16, -68, true);

            // Slider for quantity (if stackable)
            if (item.IsStackable && item.nAmount > 1)
            {
                BuildSlider(-92, item.nAmount);
            }
            else
            {
                _sellCount = 1;
            }

            AddButton("btnConfirm", "Xác Nhận", 60, -140, 120, 30, DoSell);
            AddButton("btnCancel",  "Huỷ",      200, -140, 100, 30, () => Destroy(_rootGo));

            RefreshTotal();
        }

        Text AddLabel(string name, string text, Color c, int size, int y, bool bold = false)
        {
            var go = new GameObject(name);
            go.transform.SetParent(_rootGo.transform, false);
            var rt = go.AddComponent<RectTransform>();
            rt.anchorMin = new Vector2(0, 1);
            rt.anchorMax = new Vector2(1, 1);
            rt.pivot = new Vector2(0, 1);
            rt.offsetMin = new Vector2(10, y - size - 4);
            rt.offsetMax = new Vector2(-10, y);
            var t = go.AddComponent<Text>();
            t.text = text;
            t.color = c;
            t.fontSize = size;
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
            var btn = go.AddComponent<Button>();
            btn.onClick.AddListener(() => fn());
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

        void BuildSlider(int y, int maxAmt)
        {
            var go = new GameObject("slider");
            go.transform.SetParent(_rootGo.transform, false);
            var rt = go.AddComponent<RectTransform>();
            rt.anchorMin = new Vector2(0.1f, 1); rt.anchorMax = new Vector2(0.9f, 1);
            rt.pivot = new Vector2(0.5f, 1);
            rt.offsetMin = new Vector2(0, y - 20);
            rt.offsetMax = new Vector2(0, y);
            var slider = go.AddComponent<Slider>();
            slider.minValue = 1;
            slider.maxValue = maxAmt;
            slider.wholeNumbers = true;
            slider.value = 1;
            slider.onValueChanged.AddListener(v =>
            {
                _sellCount = (int)v;
                RefreshTotal();
            });

            // Minimal slider visual
            var bg = new GameObject("Background");
            bg.transform.SetParent(go.transform, false);
            var bgRt = bg.AddComponent<RectTransform>();
            bgRt.anchorMin = Vector2.zero; bgRt.anchorMax = Vector2.one;
            bgRt.offsetMin = Vector2.zero; bgRt.offsetMax = Vector2.zero;
            bg.AddComponent<Image>().color = new Color(0.15f, 0.2f, 0.25f);

            var fill = new GameObject("Fill Area");
            fill.transform.SetParent(go.transform, false);
            var fillRt = fill.AddComponent<RectTransform>();
            fillRt.anchorMin = Vector2.zero; fillRt.anchorMax = Vector2.one;
            fillRt.offsetMin = Vector2.zero; fillRt.offsetMax = Vector2.zero;
            var fillInner = new GameObject("Fill");
            fillInner.transform.SetParent(fill.transform, false);
            var fiRt = fillInner.AddComponent<RectTransform>();
            fiRt.anchorMin = Vector2.zero; fiRt.anchorMax = Vector2.one;
            fiRt.offsetMin = Vector2.zero; fiRt.offsetMax = Vector2.zero;
            fillInner.AddComponent<Image>().color = new Color(0.6f, 0.7f, 0.4f);
            slider.fillRect = fiRt;
        }

        void RefreshTotal()
        {
            if (_txtTotalPrice == null || _item?.Template == null) return;
            long total = (long)_sellCount * _item.Template.nSellPrice;
            _txtTotalPrice.text = $"Tổng: {total} bạc (×{_sellCount})";
        }

        void DoSell()
        {
            if (_item == null || _item.Template == null) return;

            // Route through server — server validates (NPC nearby, item
            // sellable, etc.), mutates state, persists to DB, and echoes
            // back CMD_BAG_ITEM_UPDATE + CMD_MONEY_CHANGE which drives
            // the client refresh via EventNotify. No local mutation here.
            KTO.Network.BagNetworkClient.SellItem(_item.dwId, _sellCount);
            Debug.Log($"[UIItemSell] SellItem dwId={_item.dwId} count={_sellCount}");
            Destroy(_rootGo);
        }
    }
}
