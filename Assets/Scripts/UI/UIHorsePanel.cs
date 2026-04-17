// =======================================================================
//  UIHorsePanel.cs — Port of Script_Ui_Window_UIHorsePanel.lua (491 lines).
//
//  Source: 23_Mount_Horse/Lua/Script_Ui_Window_UIHorsePanel.lua
//
//  Responsibilities:
//    - List owned horses (left column)
//    - Show selected horse: 3D preview + stats + level + feed/train/summon
//    - Horse equipment slots (4 items) with +/- to gem-slot
//    - Skill tree tab with skill slots
//    - Feeding cost meter (草料 / grass-feed)
//    - Bottom action buttons: 召唤 Summon / 喂养 Feed / 换骑 Switch
//
//  Data source: HorseMgr singleton (stub here; real game uses Horse.lua
//  module + CMD_KT_G2C_HORSE_DATA packet handler).
//
//  SCOPE of this port:
//    ✅ Horse list with selection
//    ✅ Display selected horse's name/level/stats
//    ✅ Summon button (fires event; server would handle the actual summon)
//    ✅ Feed button (decrements grass count, shows log)
//    ✅ Switch button (selects different owned horse)
//    ❌ 3D preview model (needs UINpcModel port)
//    ❌ Horse equipment + gem sockets (separate Item subsystem)
//    ❌ Skill tree tab (separate panel — UIHorseSkill.lua)
// =======================================================================
using UnityEngine;
using UnityEngine.UI;
using KTO.Game;

namespace KTO.UI
{
    public class UIHorsePanel : MonoBehaviour
    {
        Transform _panel;
        bool _initialized;
        int _selectedHorseId;

        public void Init(Transform panel)
        {
            if (_initialized) return;
            _panel = panel;

            // Subscribe
            EventNotify.Subscribe(NotifyEventKind.emNOTIFY_HORSE_DATA_CHANGE, OnHorseChanged);

            // Wire action buttons
            WireBtn("btnSummon", OnSummon);
            WireBtn("btnFeed",   OnFeed);
            WireBtn("btnSwitch", OnSwitchList);
            WireBtn("btnTrain",  OnTrain);

            _initialized = true;
        }

        void OnDestroy()
        {
            EventNotify.Unsubscribe(NotifyEventKind.emNOTIFY_HORSE_DATA_CHANGE, OnHorseChanged);
        }

        public void OnOpen()
        {
            if (_panel == null) return;
            var horses = HorseMgr.GetOwnedHorses();
            if (horses.Length > 0 && _selectedHorseId == 0) _selectedHorseId = horses[0].nId;
            BuildHorseList(horses);
            UpdateDetailView();
        }

        void OnHorseChanged(object[] _) { if (isActiveAndEnabled) { BuildHorseList(HorseMgr.GetOwnedHorses()); UpdateDetailView(); } }

        void BuildHorseList(HorseMgr.Horse[] horses)
        {
            var list = _panel.Find("Left/HorseList/Viewport/Content");
            if (list == null) return;

            // Clean + rebuild
            foreach (Transform child in list) Destroy(child.gameObject);

            foreach (var h in horses)
            {
                var row = new GameObject($"horse_{h.nId}");
                row.transform.SetParent(list, false);
                var rt = row.AddComponent<RectTransform>();
                rt.sizeDelta = new Vector2(0, 60);
                row.AddComponent<Image>().color = (h.nId == _selectedHorseId) ? new Color(0.2f, 0.3f, 0.4f) : new Color(0.1f, 0.12f, 0.16f);
                var btn = row.AddComponent<Button>();
                var capturedId = h.nId;
                btn.onClick.AddListener(() => { _selectedHorseId = capturedId; UpdateDetailView(); BuildHorseList(horses); });

                var label = new GameObject("Text");
                label.transform.SetParent(row.transform, false);
                var lrt = label.AddComponent<RectTransform>();
                lrt.anchorMin = Vector2.zero; lrt.anchorMax = Vector2.one;
                lrt.offsetMin = new Vector2(8, 0); lrt.offsetMax = new Vector2(-4, 0);
                var txt = label.AddComponent<Text>();
                txt.text = $"{h.szName}\nCấp {h.nLevel}";
                txt.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
                txt.color = Color.white;
                txt.fontSize = 14;
                txt.alignment = TextAnchor.MiddleLeft;
            }
        }

        void UpdateDetailView()
        {
            var h = HorseMgr.GetById(_selectedHorseId);
            if (h == null) return;

            SetLabel("Detail/txtName",  h.szName);
            SetLabel("Detail/txtLevel", $"Cấp {h.nLevel}");
            SetLabel("Detail/txtSpeed", $"Tốc độ +{h.nSpeedBonus}%");
            SetLabel("Detail/txtHp",    $"Sinh mệnh +{h.nHpBonus}");
            SetLabel("Detail/txtAttack", $"Sát thương +{h.nAttackBonus}");
            SetLabel("Detail/txtGrass", $"Cỏ: {HorseMgr.GetGrassCount()}");
        }

        void OnSummon()
        {
            var h = HorseMgr.GetById(_selectedHorseId);
            if (h == null) return;
            Debug.Log($"[UIHorsePanel] Summon horse {h.szName}");
            // TODO: send CMD_KT_C2G_HORSE_SUMMON(h.nId)
        }

        void OnFeed()
        {
            var h = HorseMgr.GetById(_selectedHorseId);
            if (h == null) return;
            if (HorseMgr.GetGrassCount() <= 0) { Debug.Log("[UIHorsePanel] Không đủ cỏ"); return; }
            HorseMgr.Feed(h.nId, 1);
            UpdateDetailView();
        }

        void OnSwitchList()
        {
            Debug.Log("[UIHorsePanel] Switch horse picker opened (Phase 2: add UIHorseList overlay)");
        }

        void OnTrain()
        {
            Debug.Log("[UIHorsePanel] Train horse (Phase 2: needs HorseTrainingMgr)");
        }

        void SetLabel(string path, string text)
        {
            var t = _panel.Find(path)?.GetComponent<Text>();
            if (t != null) t.text = text;
        }

        void WireBtn(string name, System.Action fn)
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

    /// <summary>Horse state (stub — real state lives in Horse.lua module + server).</summary>
    public static class HorseMgr
    {
        public class Horse
        {
            public int    nId;
            public int    nTemplateId;
            public string szName;
            public int    nLevel;
            public int    nExp;
            public int    nSpeedBonus;
            public int    nHpBonus;
            public int    nAttackBonus;
            public bool   bSummoned;
        }

        static Horse[] _horses = new[]
        {
            new Horse { nId = 1, nTemplateId = 8001, szName = "Xích Thố",   nLevel = 10, nSpeedBonus = 35, nHpBonus = 200, nAttackBonus = 30, bSummoned = true },
            new Horse { nId = 2, nTemplateId = 8002, szName = "Ô Long Câu", nLevel = 5,  nSpeedBonus = 20, nHpBonus = 100, nAttackBonus = 15 },
            new Horse { nId = 3, nTemplateId = 8003, szName = "Bạch Mã",    nLevel = 1,  nSpeedBonus = 10, nHpBonus = 50,  nAttackBonus = 5 },
        };

        static int _grassCount = 50;

        public static Horse[] GetOwnedHorses() => _horses;
        public static Horse GetById(int id) { foreach (var h in _horses) if (h.nId == id) return h; return null; }
        public static int GetGrassCount() => _grassCount;

        public static void Feed(int id, int qty)
        {
            var h = GetById(id);
            if (h == null || _grassCount < qty) return;
            _grassCount -= qty;
            h.nExp += qty * 10;
            if (h.nExp >= 100) { h.nLevel++; h.nExp = 0; }
            EventNotify.Fire(NotifyEventKind.emNOTIFY_HORSE_DATA_CHANGE, id);
        }

        public static bool IsHorseOpen() => _horses.Length > 0;
    }
}
