// One-shot: verify CMD_BAG_EQUIP_ITEM (50201) reaches server by firing
// BagNetworkClient.EquipItem with a fake dwId. Server logs should show
// "[BagAction] GoodsData not found dwId=99999" — proving the dispatch
// case, the handler, and the colon-text decoder all work.
//
// Menu: KTO → Debug → Test Bag Action Roundtrip
using UnityEditor;
using UnityEngine;
using KTO.Network;

public static class TestBagActionRoundtrip
{
    [MenuItem("KTO/Debug/Test Bag Action Roundtrip")]
    public static void Run()
    {
        if (!Application.isPlaying)
        {
            Debug.LogWarning("[TestBagAction] Editor must be in Play mode.");
            return;
        }
        var net = NetworkManager.Instance ?? Object.FindObjectOfType<NetworkManager>();
        if (net == null || net.TCP == null || !net.TCP.IsConnected)
        {
            Debug.LogError("[TestBagAction] TCP not connected.");
            return;
        }

        Debug.Log("[TestBagAction] Firing CMD_BAG_EQUIP_ITEM (50201) dwId=99999 equipPos=1");
        BagNetworkClient.EquipItem(99999, 1);

        Debug.Log("[TestBagAction] Firing CMD_BAG_DROP_ITEM (50203) dwId=99999 count=1");
        BagNetworkClient.DropItem(99999, 1);

        Debug.Log("[TestBagAction] Check server log for '[BagAction] GoodsData not found' / Error lines");
    }
}
