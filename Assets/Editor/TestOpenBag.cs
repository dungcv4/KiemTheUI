using UnityEngine;
using UnityEditor;

public static class TestOpenBag
{
    [MenuItem("KTO/Test/Open UIBag")]
    public static void Run()
    {
        KTO.UI.UIBagController.Open();
        Debug.Log("[TestOpenBag] UIBag.Open() called");
    }
}
