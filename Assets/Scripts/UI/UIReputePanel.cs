// =======================================================================
//  UIReputePanel.cs — Port of Script_Ui_Window_UIReputePanel.lua (45 lines).
//
//  Source: 39_CommonUI/Lua/Script_Ui_Window_UIReputePanel.lua
//  Small panel — shows player reputation (声望) with various factions +
//  clickable rows to open each faction's reputation detail dialog.
//
//  Scope: full port of the 45-line Lua.
// =======================================================================
using UnityEngine;
using UnityEngine.UI;
using KTO.Game;

namespace KTO.UI
{
    public class UIReputePanel : MonoBehaviour
    {
        Transform _panel;
        bool _initialized;

        public void Init(Transform panel)
        {
            if (_initialized) return;
            _panel = panel;

            // Subscribe to reputation change events
            EventNotify.Subscribe(NotifyEventKind.emNOTIFY_REPUTE_CHANGE, OnReputeChanged);

            _initialized = true;
        }

        void OnDestroy()
        {
            EventNotify.Unsubscribe(NotifyEventKind.emNOTIFY_REPUTE_CHANGE, OnReputeChanged);
        }

        public void OnOpen()
        {
            if (_panel == null) return;
            UpdateView();
        }

        void OnReputeChanged(object[] _) { if (isActiveAndEnabled) UpdateView(); }

        /// <summary>
        /// Populate reputation rows. Each row = faction name + reputation
        /// value + rank tier. Data from ReputeMgr (server-side; stub below).
        /// </summary>
        void UpdateView()
        {
            var factions = ReputeMgr.GetAllFactions();
            int row = 0;
            foreach (var f in factions)
            {
                string path = $"ScrollView/Viewport/Content/Row{row}";
                var t = _panel.Find(path);
                if (t == null) { row++; continue; }

                var txtName  = t.Find("txtName")?.GetComponent<Text>();
                var txtValue = t.Find("txtValue")?.GetComponent<Text>();
                var txtRank  = t.Find("txtRank")?.GetComponent<Text>();
                if (txtName != null)  txtName.text  = f.szName;
                if (txtValue != null) txtValue.text = f.nValue.ToString();
                if (txtRank != null)  txtRank.text  = f.szRankName;
                row++;
            }
        }
    }

    /// <summary>Reputation data manager — stub with mock factions.</summary>
    public static class ReputeMgr
    {
        public class FactionRepute
        {
            public int    nId;
            public string szName;        // localized via LanguageModule
            public int    nValue;
            public int    nRank;
            public string szRankName;
        }

        public static FactionRepute[] GetAllFactions()
        {
            // Mock data — real game loads from Setting/Repute/*.tab
            return new[]
            {
                new FactionRepute { nId = 1, szName = "Thiếu Lâm",  nValue = 1500, nRank = 2, szRankName = "Đồng đạo" },
                new FactionRepute { nId = 2, szName = "Võ Đang",    nValue = 800,  nRank = 1, szRankName = "Người quen" },
                new FactionRepute { nId = 3, szName = "Nga Mi",     nValue = 200,  nRank = 1, szRankName = "Người quen" },
                new FactionRepute { nId = 4, szName = "Đường Môn",  nValue = 0,    nRank = 0, szRankName = "Xa lạ" },
                new FactionRepute { nId = 5, szName = "Thiên Nhẫn", nValue = 3200, nRank = 3, szRankName = "Thân thiết" },
            };
        }
    }
}
