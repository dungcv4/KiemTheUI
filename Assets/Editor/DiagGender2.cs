using UnityEngine;
using UnityEngine.UI;

public static class DiagGender2
{
    public static void Execute()
    {
        // Find SelectGender2 and check children directly
        foreach (var t in Object.FindObjectsOfType<Transform>(true))
        {
            if (t.name == "SelectGender2" && t.transform.root.name.Contains("CreateRole"))
            {
                Debug.Log($"[DG2] SelectGender2 found, childCount={t.childCount}");
                for (int i = 0; i < t.childCount; i++)
                {
                    var child = t.GetChild(i);
                    var btn = child.GetComponent<Button>();
                    var img = child.GetComponent<Image>();
                    var allComps = child.GetComponents<Component>();
                    string compList = "";
                    foreach (var c in allComps) compList += c.GetType().Name + ",";
                    Debug.Log($"[DG2]   child[{i}] '{child.name}': btn={btn != null}, img={img != null}, comps=[{compList}]");
                }

                // Also check what Find("btnMale") returns
                var found = t.Find("btnMale");
                Debug.Log($"[DG2] t.Find('btnMale') = {(found != null ? found.name : "NULL")}");
                found = t.Find("btnFemale");
                Debug.Log($"[DG2] t.Find('btnFemale') = {(found != null ? found.name : "NULL")}");
                break;
            }
        }
    }
}
