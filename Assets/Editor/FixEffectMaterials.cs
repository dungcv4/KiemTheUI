// Assigns the correct materials to UICreateRole Effect elements (BG, RaoDong, LiuGuang)
// based on original bundle data from res_p_55.ab.
// Menu: KTO → Fix Effect Materials
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEditor.SceneManagement;

public static class FixEffectMaterials
{
    // Material mapping from original bundle (res_p_55.ab)
    // Format: Effect_name -> { BG_material, RaoDong_material, LiuGuang_material }
    static readonly string[,] kMapping = {
        // Effect          BG               RaoDong              LiuGuang
        { "Metal_Effect",  "BG_WuDang",     "RaoDong_WuDang",    "LiuGuang_ShaoLin" },
        { "Wood_Effect",   "BG_TangMen",    "RaoDong_TangMen",   "LiuGuang_TangMen" },
        { "Water_Effect",  "BG_EMei",       "RaoDong_EMei",      "LiuGuang_EMei"    },
        { "Fire_Effect",   "BG_TianRen",    "RaoDong_TianRen",   "LiuGuang_TianRen" },
        { "Earth_Effect",  "BG_WuDang",     "RaoDong_WuDang",    "LiuGuang_WuDang"  },
    };

    const string kMatDir = "Assets/game/ui/effect/uicreaterole_effect/materials";

    [MenuItem("KTO/Fix Effect Materials")]
    public static void Execute()
    {
        var cr = GameObject.Find("UICreateRole_Canvas/UICreateRole")
                 ?? GameObject.Find("UICreateRole");
        if (cr == null)
        {
            Debug.LogError("[FixEffectMat] UICreateRole not found in scene");
            return;
        }

        var faction = cr.transform.Find("imgBG/FactionInfo/Faction");
        if (faction == null)
        {
            Debug.LogError("[FixEffectMat] imgBG/FactionInfo/Faction not found");
            return;
        }

        int total = 0;

        for (int i = 0; i < kMapping.GetLength(0); i++)
        {
            string effectName = kMapping[i, 0];
            string bgMat      = kMapping[i, 1];
            string raoDongMat = kMapping[i, 2];
            string liuGuangMat = kMapping[i, 3];

            var effect = faction.Find(effectName);
            if (effect == null)
            {
                Debug.LogWarning($"[FixEffectMat] {effectName} not found");
                continue;
            }

            total += AssignMaterial(effect, "BG", bgMat);
            total += AssignMaterial(effect, "RaoDong", raoDongMat);
            total += AssignMaterial(effect, "LiuGuang", liuGuangMat);
        }

        if (total > 0)
        {
            EditorSceneManager.MarkSceneDirty(
                UnityEngine.SceneManagement.SceneManager.GetActiveScene());
        }

        Debug.Log($"[FixEffectMat] Assigned {total} materials to Effect elements");
    }

    static int AssignMaterial(Transform effect, string childName, string matName)
    {
        var child = effect.Find(childName);
        if (child == null)
        {
            Debug.LogWarning($"[FixEffectMat] {effect.name}/{childName} not found");
            return 0;
        }

        var img = child.GetComponent<Image>();
        if (img == null)
        {
            Debug.LogWarning($"[FixEffectMat] {effect.name}/{childName} has no Image");
            return 0;
        }

        string matPath = $"{kMatDir}/{matName}.mat";
        var mat = AssetDatabase.LoadAssetAtPath<Material>(matPath);
        if (mat == null)
        {
            Debug.LogError($"[FixEffectMat] Material not found: {matPath}");
            return 0;
        }

        // Also clear the sprite (bundle has NULL sprite - visual comes from material)
        img.sprite = null;

        if (img.material != mat)
        {
            img.material = mat;
            EditorUtility.SetDirty(img);
            Debug.Log($"[FixEffectMat] {effect.name}/{childName} = {matName}");
            return 1;
        }

        return 0;
    }
}
