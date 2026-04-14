using UnityEngine;
using UnityEngine.UI;

public static class ClickGender
{
    public static void Execute()
    {
        // Click btnFemale in SelectGender2 (large overlay) on CreateRole
        foreach (var btn in Object.FindObjectsOfType<Button>(true))
        {
            if (btn.name == "btnFemale" && btn.transform.parent != null
                && btn.transform.parent.name == "SelectGender2")
            {
                Debug.Log($"[ClickGender] Clicking btnFemale in SelectGender2, active={btn.gameObject.activeInHierarchy}");
                btn.onClick.Invoke();
                return;
            }
        }
        // Fallback: try SelectGender small button
        foreach (var btn in Object.FindObjectsOfType<Button>(true))
        {
            if (btn.name == "btnFemale" && btn.transform.parent != null
                && btn.transform.parent.name == "SelectGender")
            {
                Debug.Log($"[ClickGender] Clicking btnFemale in SelectGender, active={btn.gameObject.activeInHierarchy}");
                btn.onClick.Invoke();
                return;
            }
        }
        Debug.LogWarning("[ClickGender] btnFemale not found");
    }
}
