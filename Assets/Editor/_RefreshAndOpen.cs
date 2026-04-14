using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

public static class _RefreshAndOpen
{
    public static void Execute()
    {
        AssetDatabase.Refresh(ImportAssetOptions.ForceUpdate);
        EditorSceneManager.OpenScene("Assets/CreateRoleScene.unity", OpenSceneMode.Single);
        Debug.Log("[_RefreshAndOpen] Refreshed AssetDatabase + opened CreateRoleScene");
    }
}
