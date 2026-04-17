// Open UIBag in play-mode for visual inspection.
// Menu: KTO → Debug → Open UIBag
using UnityEditor;
using UnityEngine;
using KTO.UI;

public static class OpenBagForScreenshot
{
    [MenuItem("KTO/Debug/Open UIBag")]
    public static void Run()
    {
        if (!Application.isPlaying)
        {
            Debug.LogWarning("[OpenBag] Editor must be in Play mode.");
            return;
        }
        UIBagController.Open(UIBagController.PanelType.Bag);
        Debug.Log("[OpenBag] UIBag opened — capture canvas to verify layout.");
    }
}
