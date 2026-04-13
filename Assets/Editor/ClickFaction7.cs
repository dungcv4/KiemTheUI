using UnityEngine;
using UnityEngine.UI;

public static class ClickFaction7
{
    public static void Run()
    {
        var faction7 = GameObject.Find("UICreateRole_Canvas/UICreateRole/imgBG/FactionSeriesList/FactionList/Faction_7");
        if (faction7 == null) { Debug.Log("Faction_7 not found"); return; }
        var btn = faction7.GetComponent<Button>();
        if (btn == null) { Debug.Log("no button"); return; }
        btn.onClick.Invoke();
        Debug.Log("clicked Faction_7 (Cái Bang)");
    }
}
