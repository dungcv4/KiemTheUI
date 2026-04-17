using UnityEditor;
using UnityEngine;
using KTO.Game;

public static class TestSpawnPlayer
{
    [MenuItem("KTO/Test/Spawn Player at Origin")]
    public static void SpawnAtOrigin()
    {
        if (!Application.isPlaying)
        {
            Debug.LogWarning("[TestSpawnPlayer] Enter Play Mode first — PlayerAssembler runs at runtime");
            return;
        }
        var pa = PlayerAssembler.Spawn(Vector3.zero);
        Selection.activeGameObject = pa.gameObject;
        Debug.Log($"[TestSpawnPlayer] Spawned {pa.name} at {pa.transform.position}");
    }

    [MenuItem("KTO/Test/Cycle Action (selected player)")]
    public static void CycleAction()
    {
        var go = Selection.activeGameObject;
        if (go == null) { Debug.LogWarning("Select a Player GameObject first"); return; }
        var pa = go.GetComponent<PlayerAssembler>();
        if (pa == null) { Debug.LogWarning("Selected GameObject has no PlayerAssembler"); return; }
        int next = ((int)pa.CurrentAction + 1) % (int)NpcAction.Count;
        pa.SetAction((NpcAction)next);
        Debug.Log($"[TestSpawnPlayer] Action → {(NpcAction)next}");
    }

    [MenuItem("KTO/Test/Rotate Dir +32 (selected player)")]
    public static void RotateDir()
    {
        var go = Selection.activeGameObject;
        if (go == null) { Debug.LogWarning("Select a Player GameObject first"); return; }
        var pa = go.GetComponent<PlayerAssembler>();
        if (pa == null) { Debug.LogWarning("Selected GameObject has no PlayerAssembler"); return; }
        pa.SetLogicDir(pa.CurrentLogicDir + 32);
        Debug.Log($"[TestSpawnPlayer] LogicDir → {pa.CurrentLogicDir}");
    }
}
