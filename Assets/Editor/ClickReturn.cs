using UnityEngine;
using UnityEngine.UI;

public static class ClickReturn
{
    public static void Execute()
    {
        foreach (var btn in Object.FindObjectsOfType<Button>(true))
        {
            if (btn.name == "btnReturn" && btn.transform.root.name.Contains("CreateRole"))
            {
                Debug.Log($"[ClickReturn] Clicking {btn.name} on {btn.transform.root.name}, active={btn.gameObject.activeInHierarchy}");
                btn.onClick.Invoke();
                return;
            }
        }
        Debug.LogWarning("[ClickReturn] btnReturn on CreateRole not found");
    }
}
