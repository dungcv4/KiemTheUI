using UnityEditor;
using UnityEngine;
using KTO.Game;
using KTO.Network;
using System.Reflection;

/// <summary>
/// Tests Phase 9.3 server protocol by directly invoking the handler with
/// the exact wire format the server now sends (after our ClientManager.cs fix).
///
/// This avoids needing the full login → CreateRole → MainUIScene flow,
/// while still exercising the real NpcNetworkHandler.OnRecvNewNpc parser.
/// </summary>
public static class TestServerProtocol
{
    [MenuItem("KTO/Test/Inject Mock Server NPC Packet")]
    public static void InjectMockPacket()
    {
        if (!Application.isPlaying)
        {
            Debug.LogError("[TestServerProtocol] Must be in Play mode!");
            return;
        }

        // Ensure handler is created (normally done by GameStart)
        if (NpcNetworkHandler.Instance == null)
        {
            var go = new GameObject("[NpcNetworkHandler]");
            go.AddComponent<NpcNetworkHandler>();
        }

        // Build the EXACT payload our modified server sends (ClientManager.cs:3799)
        // Format: npcID:resID:resName:name:title:posX:posY:dir:kind:bloodStyle:notShowShadow:talkType:visibleOnMinimap
        //
        // Sample data from server NPCs.xml + MapConfig/yunzhongzhen/npcs.xml:
        //   <NPC ID="3573" ResName="enemy006" />  -- in NPCs.xml (Bao Van Dong)
        //   <NPC Code="3573" X="8510" Y="4370" Dir="1" Name="Bao Van Dong" />
        string mockServerPayload = "5001:3573:enemy006:Bao Van Dong:Quan Quan Nhu:8510:4370:1:2:0:0:1:1";

        Debug.Log($"[TestServerProtocol] Injecting payload: {mockServerPayload}");

        // Use reflection to call OnRecvNewNpc (private method)
        var handler = NpcNetworkHandler.Instance;
        var method = typeof(NpcNetworkHandler).GetMethod("OnRecvNewNpc",
            BindingFlags.Instance | BindingFlags.NonPublic);
        if (method == null)
        {
            Debug.LogError("[TestServerProtocol] OnRecvNewNpc method not found via reflection");
            return;
        }
        method.Invoke(handler, new object[] { mockServerPayload });

        // Verify NPC was created
        var npc = NpcManager.GetNpc(5001);
        if (npc == null)
        {
            Debug.LogError("[TestServerProtocol] NPC 5001 NOT created — protocol parsing failed!");
            return;
        }

        Debug.Log($"[TestServerProtocol] ✓ Server packet → NPC created");
        Debug.Log($"  m_nNpcID    = {npc.m_nNpcID}        (expected 5001)");
        Debug.Log($"  m_nNpcResID = {npc.m_nNpcResID}     (expected 3573)");
        Debug.Log($"  m_nKind     = {npc.m_nKind}         (expected 2 = Dialoger)");
        Debug.Log($"  position    = {npc.transform.position}");
        Debug.Log($"  layer       = {npc.gameObject.layer} ({LayerMask.LayerToName(npc.gameObject.layer)})");

        // Now test inverse direction: client → server packet build
        var net = NetworkManager.Instance;
        if (net == null)
        {
            Debug.LogWarning("[TestServerProtocol] NetworkManager.Instance null — " +
                             "click-to-server test skipped (only available in full login scene)");
            return;
        }

        Debug.Log("[TestServerProtocol] Testing SendClickNpc (would send CMD 50004)...");
        // Don't actually send — would require connected TCP
        // NpcNetworkHandler.SendClickNpc(5001);
    }

    [MenuItem("KTO/Test/Test Live TCP Connection (port 23001)")]
    public static void TestLiveTcp()
    {
        if (!Application.isPlaying)
        {
            Debug.LogError("[TestServerProtocol] Must be in Play mode!");
            return;
        }

        var go = GameObject.Find("[NetworkManager]");
        if (go == null)
        {
            go = new GameObject("[NetworkManager]");
            go.AddComponent<NetworkManager>();
            Debug.Log("[TestServerProtocol] Created NetworkManager singleton");
        }

        var net = NetworkManager.Instance;
        if (net == null) { Debug.LogError("NetworkManager.Instance still null"); return; }

        net.OnTcpConnected += () => Debug.Log("[TestServerProtocol] ✓ TCP CONNECTED!");
        net.OnTcpDisconnected += r => Debug.LogError($"[TestServerProtocol] TCP disconnected: {r}");

        Debug.Log("[TestServerProtocol] Connecting to localhost:23001...");
        net.ConnectGameServer("127.0.0.1", 23001);
    }
}
