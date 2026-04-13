// AUTO-GENERATED — bakes 38 loginbg character prefabs from bundle data.
// DO NOT EDIT MANUALLY. Re-run /tmp/emit_loginbg_baker.py to regenerate.
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEditor.Animations;
using System.IO;
using System.Collections.Generic;

public static class BakeAllLoginBgPrefabs
{
    const string OUT_DIR = "Assets/game/ui/loginbg";
    const string CTRL_DIR = "Assets/AnimatorController";

    [MenuItem("KTO/Bake LoginBg Prefabs")]
    public static void BakeAll()
    {
        Directory.CreateDirectory(OUT_DIR);
        int ok = 0, missing = 0;
        if (Bake("F_5D", new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.000000f), new Vector2(214.000000f,-292.000000f), new Vector2(604.000000f,604.000000f), new Vector3(1.000000f,1.000000f,1.000000f), new Color(1.000000f,1.000000f,1.000000f,1.000000f), true, Image.Type.Simple)) ok++; else missing++;
        if (Bake("F_BD", new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.500000f), new Vector2(0.600000f,0.000000f), new Vector2(200.200012f,-285.000000f), new Vector2(512.000000f,512.000000f), new Vector3(1.000000f,1.000000f,1.000000f), new Color(1.000000f,1.000000f,1.000000f,1.000000f), true, Image.Type.Simple)) ok++; else missing++;
        if (Bake("F_BTS", new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.500000f), new Vector2(0.480000f,0.000000f), new Vector2(175.000000f,-279.000000f), new Vector2(531.000000f,598.000000f), new Vector3(1.000000f,1.000000f,1.000000f), new Color(1.000000f,1.000000f,1.000000f,1.000000f), true, Image.Type.Simple)) ok++; else missing++;
        if (Bake("F_CGM", new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.500000f), new Vector2(0.520000f,0.000000f), new Vector2(183.159988f,-275.000000f), new Vector2(417.000000f,628.000000f), new Vector3(1.000000f,1.000000f,1.000000f), new Color(1.000000f,1.000000f,1.000000f,1.000000f), true, Image.Type.Simple)) ok++; else missing++;
        if (Bake("F_CY", new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.000000f), new Vector2(179.000031f,-268.000000f), new Vector2(384.000000f,512.000000f), new Vector3(1.000000f,1.000000f,1.000000f), new Color(1.000000f,1.000000f,1.000000f,1.000000f), true, Image.Type.Simple)) ok++; else missing++;
        if (Bake("F_DL", new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.000000f), new Vector2(238.500031f,-293.999969f), new Vector2(696.000000f,522.000000f), new Vector3(1.000000f,1.000000f,1.000000f), new Color(1.000000f,1.000000f,1.000000f,1.000000f), true, Image.Type.Simple)) ok++; else missing++;
        if (Bake("F_EM", new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.000000f), new Vector2(8.000000f,-305.000000f), new Vector2(604.000000f,604.000000f), new Vector3(1.000000f,1.000000f,1.000000f), new Color(1.000000f,1.000000f,1.000000f,1.000000f), true, Image.Type.Simple)) ok++; else missing++;
        if (Bake("F_GB", new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.000000f), new Vector2(224.000000f,-274.000000f), new Vector2(552.000000f,552.000000f), new Vector3(1.000000f,1.000000f,1.000000f), new Color(1.000000f,1.000000f,1.000000f,1.000000f), true, Image.Type.Simple)) ok++; else missing++;
        if (Bake("F_GM", new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.000000f), new Vector2(214.000000f,-278.000000f), new Vector2(512.000000f,512.000000f), new Vector3(1.000000f,1.000000f,1.000000f), new Color(1.000000f,1.000000f,1.000000f,1.000000f), true, Image.Type.Simple)) ok++; else missing++;
        if (Bake("F_KL", new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.000000f), new Vector2(179.000000f,-274.000000f), new Vector2(384.000000f,512.000000f), new Vector3(1.000000f,1.000000f,1.000000f), new Color(1.000000f,1.000000f,1.000000f,1.000000f), true, Image.Type.Simple)) ok++; else missing++;
        if (Bake("F_MJ", new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.000000f), new Vector2(183.000000f,-258.000183f), new Vector2(563.000000f,563.000000f), new Vector3(1.000000f,1.000000f,1.000000f), new Color(1.000000f,1.000000f,1.000000f,1.000000f), true, Image.Type.Simple)) ok++; else missing++;
        if (Bake("F_THD", new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.500000f), new Vector2(0.540000f,0.000000f), new Vector2(191.500000f,-275.000000f), new Vector2(575.000000f,628.000000f), new Vector3(1.000000f,1.000000f,1.000000f), new Color(1.000000f,1.000000f,1.000000f,1.000000f), true, Image.Type.Simple)) ok++; else missing++;
        if (Bake("F_TM", new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.000000f), new Vector2(162.000000f,-268.000000f), new Vector2(384.000000f,512.000000f), new Vector3(1.000000f,1.000000f,1.000000f), new Color(1.000000f,1.000000f,1.000000f,1.000000f), true, Image.Type.Simple)) ok++; else missing++;
        if (Bake("F_TR", new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.000000f), new Vector2(199.000000f,-283.000000f), new Vector2(552.000000f,552.000000f), new Vector3(1.000000f,1.000000f,1.000000f), new Color(1.000000f,1.000000f,1.000000f,1.000000f), true, Image.Type.Simple)) ok++; else missing++;
        if (Bake("F_TW", new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.000000f), new Vector2(254.000000f,-325.499969f), new Vector2(665.000000f,585.000000f), new Vector3(1.000000f,1.000000f,1.000000f), new Color(1.000000f,1.000000f,1.000000f,1.000000f), true, Image.Type.Simple)) ok++; else missing++;
        if (Bake("F_WD", new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.000000f), new Vector2(199.000000f,-283.000000f), new Vector2(513.000000f,583.000000f), new Vector3(1.000000f,1.000000f,1.000000f), new Color(1.000000f,1.000000f,1.000000f,1.000000f), true, Image.Type.Simple)) ok++; else missing++;
        if (Bake("F_WHT", new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.500000f), new Vector2(0.590000f,0.100000f), new Vector2(243.679993f,-176.399994f), new Vector2(582.000000f,656.000000f), new Vector3(1.000000f,1.000000f,1.000000f), new Color(1.000000f,1.000000f,1.000000f,1.000000f), true, Image.Type.Simple)) ok++; else missing++;
        if (Bake("F_XY", new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.000000f), new Vector2(166.000000f,-281.000000f), new Vector2(432.000000f,491.000000f), new Vector3(1.000000f,1.000000f,1.000000f), new Color(1.000000f,1.000000f,1.000000f,1.000000f), true, Image.Type.Simple)) ok++; else missing++;
        if (Bake("F_YP", new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.500000f), new Vector2(0.520000f,0.000000f), new Vector2(195.779999f,-321.399994f), new Vector2(469.000000f,707.000000f), new Vector3(1.000000f,1.000000f,1.000000f), new Color(1.000000f,1.000000f,1.000000f,1.000000f), true, Image.Type.Simple)) ok++; else missing++;
        if (Bake("M_5D", new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.500000f), new Vector2(0.650000f,0.000000f), new Vector2(-202.000000f,-276.000000f), new Vector2(390.000000f,512.000000f), new Vector3(1.000000f,1.000000f,1.000000f), new Color(1.000000f,1.000000f,1.000000f,1.000000f), true, Image.Type.Simple)) ok++; else missing++;
        if (Bake("M_BD", new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.000000f), new Vector2(-220.449951f,-303.000000f), new Vector2(603.000000f,665.000000f), new Vector3(1.000000f,1.000000f,1.000000f), new Color(1.000000f,1.000000f,1.000000f,1.000000f), true, Image.Type.Simple)) ok++; else missing++;
        if (Bake("M_BTS", new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.000000f), new Vector2(-221.000000f,-319.000000f), new Vector2(448.000000f,563.000000f), new Vector3(1.000000f,1.000000f,1.000000f), new Color(1.000000f,1.000000f,1.000000f,1.000000f), true, Image.Type.Simple)) ok++; else missing++;
        if (Bake("M_CGM", new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.500000f), new Vector2(0.510000f,0.000000f), new Vector2(-218.580002f,-360.000000f), new Vector2(551.000000f,645.000000f), new Vector3(1.000000f,1.000000f,1.000000f), new Color(1.000000f,1.000000f,1.000000f,1.000000f), true, Image.Type.Simple)) ok++; else missing++;
        if (Bake("M_CY", new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.500000f), new Vector2(0.600000f,0.000000f), new Vector2(-189.599976f,-268.000000f), new Vector2(384.000000f,512.000000f), new Vector3(1.000000f,1.000000f,1.000000f), new Color(1.000000f,1.000000f,1.000000f,1.000000f), true, Image.Type.Simple)) ok++; else missing++;
        if (Bake("M_DL", new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.000000f), new Vector2(-184.000000f,-276.000000f), new Vector2(384.000000f,512.000000f), new Vector3(1.000000f,1.000000f,1.000000f), new Color(1.000000f,1.000000f,1.000000f,1.000000f), true, Image.Type.Simple)) ok++; else missing++;
        if (Bake("M_GB", new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.000000f), new Vector2(-211.000000f,-276.000000f), new Vector2(384.000000f,512.000000f), new Vector3(1.000000f,1.000000f,1.000000f), new Color(1.000000f,1.000000f,1.000000f,1.000000f), true, Image.Type.Simple)) ok++; else missing++;
        if (Bake("M_GM", new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.000000f), new Vector2(-223.000000f,-273.000000f), new Vector2(368.000000f,491.000000f), new Vector3(1.000000f,1.000000f,1.000000f), new Color(1.000000f,1.000000f,1.000000f,1.000000f), true, Image.Type.Simple)) ok++; else missing++;
        if (Bake("M_KL", new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.000000f), new Vector2(-202.000000f,-255.000000f), new Vector2(583.000000f,583.000000f), new Vector3(1.000000f,1.000000f,1.000000f), new Color(1.000000f,1.000000f,1.000000f,1.000000f), true, Image.Type.Simple)) ok++; else missing++;
        if (Bake("M_MJ", new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.000000f), new Vector2(-228.000000f,-268.000031f), new Vector2(532.000000f,532.000000f), new Vector3(1.000000f,1.000000f,1.000000f), new Color(1.000000f,1.000000f,1.000000f,1.000000f), true, Image.Type.Simple)) ok++; else missing++;
        if (Bake("M_SL", new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.000000f), new Vector2(-6.500000f,-265.000031f), new Vector2(448.000000f,512.000000f), new Vector3(1.000000f,1.000000f,1.000000f), new Color(1.000000f,1.000000f,1.000000f,1.000000f), true, Image.Type.Simple)) ok++; else missing++;
        if (Bake("M_THD", new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.500000f), new Vector2(0.530000f,0.000000f), new Vector2(-207.559998f,-319.000000f), new Vector2(448.000000f,563.000000f), new Vector3(1.000000f,1.000000f,1.000000f), new Color(1.000000f,1.000000f,1.000000f,1.000000f), true, Image.Type.Simple)) ok++; else missing++;
        if (Bake("M_TM", new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.000000f), new Vector2(-211.000000f,-276.000000f), new Vector2(384.000000f,512.000000f), new Vector3(1.000000f,1.000000f,1.000000f), new Color(1.000000f,1.000000f,1.000000f,1.000000f), true, Image.Type.Simple)) ok++; else missing++;
        if (Bake("M_TR", new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.500000f), new Vector2(0.600000f,0.000000f), new Vector2(-174.199951f,-389.000000f), new Vector2(798.000000f,798.000000f), new Vector3(1.000000f,1.000000f,1.000000f), new Color(1.000000f,1.000000f,1.000000f,1.000000f), true, Image.Type.Simple)) ok++; else missing++;
        if (Bake("M_TW", new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.000000f), new Vector2(-202.000000f,-322.500000f), new Vector2(839.000000f,672.000000f), new Vector3(1.000000f,1.000000f,1.000000f), new Color(1.000000f,1.000000f,1.000000f,1.000000f), true, Image.Type.Simple)) ok++; else missing++;
        if (Bake("M_WD", new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.000000f), new Vector2(-235.000000f,-311.500000f), new Vector2(583.000000f,583.000000f), new Vector3(1.000000f,1.000000f,1.000000f), new Color(1.000000f,1.000000f,1.000000f,1.000000f), true, Image.Type.Simple)) ok++; else missing++;
        if (Bake("M_WHT", new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.500000f), new Vector2(0.600000f,0.220000f), new Vector2(-137.599976f,-57.439621f), new Vector2(677.000000f,849.000000f), new Vector3(1.000000f,1.000000f,1.000000f), new Color(1.000000f,1.000000f,1.000000f,1.000000f), true, Image.Type.Simple)) ok++; else missing++;
        if (Bake("M_XY", new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.000000f), new Vector2(-247.399994f,-298.000000f), new Vector2(716.000000f,716.000000f), new Vector3(1.000000f,1.000000f,1.000000f), new Color(1.000000f,1.000000f,1.000000f,1.000000f), true, Image.Type.Simple)) ok++; else missing++;
        if (Bake("M_YP", new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.500000f), new Vector2(0.500000f,0.000000f), new Vector2(-207.000000f,-299.299988f), new Vector2(456.000000f,573.000000f), new Vector3(1.000000f,1.000000f,1.000000f), new Color(1.000000f,1.000000f,1.000000f,1.000000f), true, Image.Type.Simple)) ok++; else missing++;
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
        Debug.Log($"[BakeAllLoginBgPrefabs] Baked {ok} prefabs ({missing} skipped)");
    }

    static bool Bake(string charName,
                     Vector2 anchorMin, Vector2 anchorMax,
                     Vector2 pivot, Vector2 anchoredPos, Vector2 sizeDelta,
                     Vector3 localScale,
                     Color color, bool raycast, Image.Type imgType)
    {
        var go = new GameObject(charName, typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rt = (RectTransform)go.transform;
        rt.anchorMin = anchorMin; rt.anchorMax = anchorMax;
        rt.pivot = pivot;
        rt.anchoredPosition = anchoredPos;
        rt.sizeDelta = sizeDelta;
        rt.localScale = localScale;

        var img = go.GetComponent<Image>();
        img.color = color;
        img.raycastTarget = raycast;
        img.type = imgType;
        // Editor preview frame: first stand sprite (M2_GB_stand_0001 etc.).
        var prefix = (charName[0] + "2" + charName.Substring(1)) + "_stand_0001";
        img.sprite = LookupSprite(prefix);

        var anim = go.GetComponent<Animator>();
        var ctrlPath = $"{CTRL_DIR}/{charName}.controller";
        var ctrl = AssetDatabase.LoadAssetAtPath<RuntimeAnimatorController>(ctrlPath);
        if (ctrl != null) anim.runtimeAnimatorController = ctrl;
        anim.cullingMode = AnimatorCullingMode.AlwaysAnimate;
        anim.applyRootMotion = false;

        string outPath = $"{OUT_DIR}/{charName}.prefab";
        PrefabUtility.SaveAsPrefabAsset(go, outPath);
        Object.DestroyImmediate(go);
        if (ctrl == null) Debug.LogWarning($"[BakeAllLoginBgPrefabs] {charName}: no controller at {ctrlPath}");
        return ctrl != null;
    }

    static Dictionary<string, Sprite> _spriteCache;
    static Sprite LookupSprite(string name)
    {
        if (_spriteCache == null)
        {
            _spriteCache = new Dictionary<string, Sprite>();
            var guids = AssetDatabase.FindAssets("t:Sprite", new[] { "Assets/Sprite" });
            foreach (var g in guids)
            {
                var p = AssetDatabase.GUIDToAssetPath(g);
                var s = AssetDatabase.LoadAssetAtPath<Sprite>(p);
                if (s == null) continue;
                if (!_spriteCache.ContainsKey(s.name)) _spriteCache[s.name] = s;
            }
        }
        Sprite r;
        return _spriteCache.TryGetValue(name, out r) ? r : null;
    }
}