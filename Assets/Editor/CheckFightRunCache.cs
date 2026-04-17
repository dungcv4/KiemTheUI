using UnityEditor;
using UnityEngine;
using KTO.Game;
using System.Reflection;

public static class CheckFightRunCache
{
    public static void Execute()
    {
        var go = GameObject.Find("Player_ma_000a_free");
        if (go == null) { Debug.LogError("Player not found"); return; }
        var pa = go.GetComponent<PlayerAssembler>();

        // Force-apply FightRun dir 0 frame 0 manually via reflection + check
        pa.SetAction(NpcAction.FightRun);
        pa.CurrentFrame = 0;
        pa.SetLogicDir(0);

        foreach (Transform c in go.transform)
        {
            var sr = c.GetComponent<SpriteRenderer>();
            if (sr == null) continue;
            var sp = sr.sprite;
            Debug.Log($"[Cache] {c.name}: sprite={(sp!=null?sp.name:"<null>")} order={sr.sortingOrder}");
        }

        // Probe the cache directly
        var t = typeof(PlayerAssembler);
        var field = t.GetField("_spriteCache", BindingFlags.Static | BindingFlags.NonPublic);
        var dict = field.GetValue(null) as System.Collections.Generic.Dictionary<string, Sprite>;
        Debug.Log($"[Cache] cache size = {dict.Count}");
        string[] probe = { "ma_000a_bd_dr_000", "ma_000a_bd_dr_024", "ma_000a_bd_ds01_000", "ma_000a_bd_db_000" };
        foreach (var p in probe)
            Debug.Log($"[Cache]  '{p}' in cache: {dict.ContainsKey(p)}");

        // Dump body JSON arrays
        var bf = t.GetField("_body", BindingFlags.NonPublic | BindingFlags.Instance);
        var bodyJson = bf.GetValue(pa) as PlayerNpcAssetJson;
        Debug.Log($"[Cache] body.FightRun[0]={bodyJson.FightRun[0]} [1]={bodyJson.FightRun[1]} FightRun.Length={bodyJson.FightRun.Length}");
        Debug.Log($"[Cache] body.FightStand[0]={bodyJson.FightStand[0]} FightStand.Length={bodyJson.FightStand.Length}");
    }
}
