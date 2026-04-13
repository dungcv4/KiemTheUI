using UnityEngine;
using UnityEditor;

public class BuildAllHudImports
{
    [MenuItem("KTO/Build All HUD Imports")]
    public static void Execute()
    {
        Debug.Log("[BuildAllHud] START");
        Import_res_p_91.Build();
        Import_res_p_92.Build();
        Import_res_p_98.Build();
        Import_res_p_100.Build();
        Import_res_p_102.Build();
        Import_res_p_103.Build();
        Import_res_p_104.Build();
        Import_res_p_105.Build();
        AssetDatabase.Refresh();
        Debug.Log("[BuildAllHud] DONE — 8 HUD prefabs in Assets/Prefabs/Imported/");
    }
}
