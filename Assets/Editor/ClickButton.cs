using UnityEngine;
using UnityEngine.UI;

public static class ClickButton
{
    public static void Execute()
    {
        // Find and click btnCreateRole specifically on UISelectRoleExist_Canvas
        foreach (var btn in Object.FindObjectsOfType<Button>(true))
        {
            if (btn.name == "btnCreateRole" && btn.transform.root.name.Contains("SelectRole"))
            {
                Debug.Log($"[ClickButton] Clicking {btn.name} on {btn.transform.root.name}, activeInHierarchy={btn.gameObject.activeInHierarchy}");
                btn.onClick.Invoke();
                return;
            }
        }
        Debug.LogWarning("[ClickButton] btnCreateRole on SelectRole not found");
    }
}
