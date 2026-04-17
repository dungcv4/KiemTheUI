using UnityEditor;
using UnityEngine;
using KTO.Game;

/// <summary>
/// Editor-only test: spawns sample NPCs around the player to verify
/// Phase 9 NPC entity system + click detection WITHOUT needing a server.
///
/// Menu: KTO > Test > Spawn Test NPCs
///       KTO > Test > Clear All NPCs
///
/// What to verify:
///   1. NPCs appear as GameObjects under [NpcManager]/NpcRoot
///   2. Each NPC has a BoxCollider2D (visible in Inspector)
///   3. Click on an NPC in Game view → Console shows "[Operation] SimpleTap"
///   4. Click on empty ground → Console shows "[ClickToMoveInput] click" (normal ClickMap)
///   5. Click a dialoger NPC → player walks toward it → "[Operation] OnDialogerClicked"
/// </summary>
public static class TestSpawnNpcs
{
    // yunzhongzhen NPC positions from server MapConfig/yunzhongzhen/npcs.xml
    // These are server world units (= client logic units)
    static readonly (int id, int posX, int posY, int dir, string name, string resName)[] TestNpcs = new[]
    {
        (9001, 8510, 4370, 1, "Bao Van Dong",          "passerby062"),
        (9002, 7110, 4930, 1, "Diem Tuu Thuc",         "enemy006"),
        (9003, 9210, 5170, 1, "Hach Phieu Tinh",       "passerby010"),
        (9004, 8410, 5370, 7, "Tham Ha Diep",          "enemy004"),
        (9005, 7750, 5190, 1, "Truong Tram Kinh",      "passerby016"),
        (9006, 6890, 2870, 1, "Da Luyen Dai Su",       "enemy005"),
        (9007, 7330, 4350, 7, "Trau Duc Khoai",        "passerby073"),
        (9008, 5570, 1650, 1, "Trau Duc Khoai (2)",    "passerby047"),
    };

    [MenuItem("KTO/Test/Spawn Test NPCs")]
    public static void SpawnTestNpcs()
    {
        if (!Application.isPlaying)
        {
            Debug.LogError("[TestSpawnNpcs] Must be in Play mode!");
            return;
        }

        GameDefine.Init();
        NpcManager.Init();

        int spawned = 0;
        foreach (var t in TestNpcs)
        {
            // Check if already spawned
            if (NpcManager.GetNpc(t.id) != null)
            {
                Debug.Log($"[TestSpawnNpcs] NPC {t.id} already exists, skipping");
                continue;
            }

            // CreateNpc signature matches IL2CPP original:
            // (nNpcId, nLogicX, nLogicY, nNpcResID, nKind, bIsMe, nBloodStyle, nNotShowShadow, nTalkType)
            var npc = NpcManager.CreateNpc(
                nNpcId:         t.id,
                nLogicX:        t.posX,
                nLogicY:        t.posY,
                nNpcResID:      0,          // no ResID lookup yet
                nKind:          (int)NpcKind.Dialoger,  // kind=2, clickable
                bIsMe:          false,
                nBloodStyle:    0,
                nNotShowShadow: 0,
                nTalkType:      1,          // standard dialog
                resName:        t.resName   // Phase 9.4: pass bundle name for sprite render
            );

            if (npc != null)
            {
                npc.name = $"Npc_{t.id}_{t.resName}";
                npc.ChangeLogicDir(t.dir * 32); // Direction enum → logic dir
                spawned++;
            }
        }

        Debug.Log($"[TestSpawnNpcs] Spawned {spawned} test NPCs. Total: {NpcManager.Count}");
        Debug.Log("[TestSpawnNpcs] Click an NPC in Game view — check Console for SimpleTap/OnDialogerClicked logs");
    }

    [MenuItem("KTO/Test/Clear All NPCs")]
    public static void ClearAllNpcs()
    {
        if (!Application.isPlaying)
        {
            Debug.LogError("[TestSpawnNpcs] Must be in Play mode!");
            return;
        }

        int count = NpcManager.Count;
        NpcManager.RemoveAllNpcs();
        Debug.Log($"[TestSpawnNpcs] Cleared {count} NPCs");
    }

    [MenuItem("KTO/Test/Spawn Test NPCs", true)]
    static bool ValidateSpawn() => Application.isPlaying;

    [MenuItem("KTO/Test/Clear All NPCs", true)]
    static bool ValidateClear() => Application.isPlaying;
}
