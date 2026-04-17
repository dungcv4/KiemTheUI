using UnityEngine;
using UnityEditor;

public static class TestBagTabs
{
    [MenuItem("KTO/Test/Bag → Attribute tab")]
    public static void RunAttr()
    {
        if (KTO.UI.UIBagController.Instance != null)
            KTO.UI.UIBagController.Instance.SelectPanel(KTO.UI.UIBagController.PanelType.Attribute);
    }

    [MenuItem("KTO/Test/Bag → Horse tab")]
    public static void RunHorse()
    {
        if (KTO.UI.UIBagController.Instance != null)
            KTO.UI.UIBagController.Instance.SelectPanel(KTO.UI.UIBagController.PanelType.Horse);
    }

    [MenuItem("KTO/Test/Bag → Close")]
    public static void RunClose()
    {
        if (KTO.UI.UIBagController.Instance != null)
            KTO.UI.UIBagController.Instance.Close();
    }
}
