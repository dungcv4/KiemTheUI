using UnityEditor;

public static class TestBagClosetRepute
{
    [MenuItem("KTO/Test/Bag → Reputation tab")]
    public static void RunRep()
    {
        if (KTO.UI.UIBagController.Instance != null)
            KTO.UI.UIBagController.Instance.SelectPanel(KTO.UI.UIBagController.PanelType.Reputation);
    }
    [MenuItem("KTO/Test/Bag → Appearance tab")]
    public static void RunApp()
    {
        if (KTO.UI.UIBagController.Instance != null)
            KTO.UI.UIBagController.Instance.SelectPanel(KTO.UI.UIBagController.PanelType.Appearance);
    }
}
