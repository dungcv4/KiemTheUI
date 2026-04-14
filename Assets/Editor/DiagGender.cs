using UnityEngine;
using UnityEngine.UI;

public static class DiagGender
{
    public static void Execute()
    {
        // Check all gender-related buttons
        foreach (var btn in Object.FindObjectsOfType<Button>(true))
        {
            if ((btn.name == "btnMale" || btn.name == "btnFemale") &&
                btn.transform.parent != null &&
                (btn.transform.parent.name == "SelectGender" || btn.transform.parent.name == "SelectGender2"))
            {
                var rt = btn.GetComponent<RectTransform>();
                string parentName = btn.transform.parent.name;
                Debug.Log($"[DiagGender] {parentName}/{btn.name}: " +
                    $"activeInHierarchy={btn.gameObject.activeInHierarchy}, " +
                    $"interactable={btn.interactable}, " +
                    $"pos={rt?.anchoredPosition}, size={rt?.sizeDelta}, " +
                    $"raycastTarget={btn.GetComponent<Image>()?.raycastTarget}");
            }
        }

        // Check if SelectGender2 itself is active
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
        {
            if (t.name == "SelectGender2")
            {
                var rt = t.GetComponent<RectTransform>();
                Debug.Log($"[DiagGender] SelectGender2: active={t.gameObject.activeSelf}, " +
                    $"activeInHierarchy={t.gameObject.activeInHierarchy}, " +
                    $"pos={rt?.anchoredPosition}, size={rt?.sizeDelta}");
            }
        }

        // Test invoke btnMale in SelectGender2
        foreach (var btn in Object.FindObjectsOfType<Button>(true))
        {
            if (btn.name == "btnMale" && btn.transform.parent != null && btn.transform.parent.name == "SelectGender2")
            {
                Debug.Log("[DiagGender] Invoking SelectGender2/btnMale...");
                btn.onClick.Invoke();
                break;
            }
        }
    }
}
