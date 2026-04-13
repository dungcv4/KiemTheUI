using UnityEngine;
using UnityEditor;

public static class RunImport189
{
    [MenuItem("KTO/Run Import res_p_189")]
    public static void Execute()
    {
        Import_res_p_189.Build();
        AssetDatabase.Refresh();
    }
}
