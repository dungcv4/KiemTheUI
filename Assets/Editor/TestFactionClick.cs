using UnityEngine;
using UnityEngine.UI;

public static class TestFactionClick
{
    public static void Execute()
    {
        string[] keys = { "shaolin", "tianwang", "tangmen", "emei", "wudang", "WuHuntang" };
        foreach (var k in keys)
        {
            var go = GameObject.Find($"UICreateRole_Canvas/UICreateRole/imgBG/FactionSeriesList/FactionList/Faction_{k}");
            if (go == null) { Debug.Log($"[TestClick] {k}: NOT FOUND"); continue; }
            var btn = go.GetComponent<Button>();
            Debug.Log($"[TestClick] Faction_{k} btn={(btn != null)} active={go.activeInHierarchy}");
        }
        // Now click shaolin and capture title text after
        var sg = GameObject.Find("UICreateRole_Canvas/UICreateRole/imgBG/FactionSeriesList/FactionList/Faction_shaolin");
        var sb = sg != null ? sg.GetComponent<Button>() : null;
        if (sb != null)
        {
            Debug.Log("[TestClick] >>> CLICK Faction_shaolin");
            sb.onClick.Invoke();
            // dump active banner texts
            string[] series = { "Metal", "Wood", "Water", "Fire", "Earth" };
            foreach (var s in series)
            {
                var t = GameObject.Find($"UICreateRole_Canvas/UICreateRole/imgBG/FactionInfo/Faction/{s}_Effect/Text");
                if (t == null) continue;
                var txt = t.GetComponent<Text>();
                Debug.Log($"[TestClick]   {s}_Effect/Text active={t.activeInHierarchy} text='{(txt != null ? txt.text : "null")}'");
            }
        }
    }
}
