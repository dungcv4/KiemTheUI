// Restores Effect elements exactly like original bundle (res_p_55.ab):
// - Effect parent uses plain Transform (NOT RectTransform) — matches bundle
// - Children use RectTransform with exact bundle values
// - All components: Image, Text, UIMultiGradient, FontOutline, Localize,
//   ImageEffectAnimationController, FireStar
// - Font: common_vi (Vietnamese equivalent of bundle's common_zh)
// - FontOutline: per-element colors + distance (3,3) from bundle typetree
// - Text: bestFit=true, Wrap/Truncate overflow — exact bundle settings
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEditor.SceneManagement;
using I2.Loc;

public static class RestoreEffectChildren
{
    // Bundle font is common_zh; project uses common_vi for Vietnamese
    const string FontPath = "Assets/Font/common_vi.ttf";

    public static string Execute()
    {
        if (Application.isPlaying) return "Stop play mode first";

        var cr = GameObject.Find("UICreateRole_Canvas/UICreateRole")
                 ?? GameObject.Find("UICreateRole");
        if (cr == null) return "UICreateRole not found";

        var faction = cr.transform.Find("imgBG/FactionInfo/Faction");
        if (faction == null) return "Faction not found";

        var font = AssetDatabase.LoadAssetAtPath<Font>(FontPath);
        if (font == null) return $"Font not found at {FontPath}";

        var sb = new System.Text.StringBuilder();
        int total = 0;
        string matDir = "Assets/game/ui/effect/uicreaterole_effect/materials";
        string animDir = "Assets/game/ui/effect/uicreaterole_effect/animation";

        // ---- Fire_Effect ----
        // Bundle FontOutline: r=0.4706 g=0.2937 b=0.0824 a=0.6118
        total += BuildEffect(faction, sb, matDir, animDir, font, "Fire_Effect",
            bgPos: V2(-1.2999999523162842f, -1.2999999523162842f),
            bgScale: V3(1.9448679685592651f, 1.2979921102523804f, 0.6030598282814026f),
            bgMat: "BG_TianRen",
            text: "\u5929\u5fcd", // 天忍
            outlineColor: new Color(0.4706f, 0.2937f, 0.0824f, 0.6118f),
            raoDongPos: V2(158.8699951171875f, -11.199999809265137f),
            raoDongScale: V3(3.0780527591705322f, -1.618736982345581f, 0.6522601246833801f),
            raoDongMat: "RaoDong_TianRen",
            liuGuangMat: "LiuGuang_TianRen");

        // ---- Metal_Effect ----
        // Bundle FontOutline: r=0.6132 g=0.2184 b=0.1128 a=0.6118
        total += BuildEffect(faction, sb, matDir, animDir, font, "Metal_Effect",
            bgPos: V2(-1.2999999523162842f, 4.300000190734863f),
            bgScale: V3(1.970765233039856f, 1.2166301012039185f, 0.6110900044441223f),
            bgMat: "BG_WuDang",
            text: "\u5c11\u6797", // 少林
            outlineColor: new Color(0.6132f, 0.2184f, 0.1128f, 0.6118f),
            raoDongPos: V2(133.86000061035156f, -12.600000381469727f),
            raoDongScale: V3(2.577869176864624f, -1.436629056930542f, 0.6522601246833801f),
            raoDongMat: "RaoDong_WuDang",
            liuGuangMat: "LiuGuang_ShaoLin");

        // ---- Earth_Effect ----
        // Bundle FontOutline: r=0.3962 g=0.2785 b=0.2000 a=0.6118
        total += BuildEffect(faction, sb, matDir, animDir, font, "Earth_Effect",
            bgPos: V2(-1.2999999523162842f, -1.2999999523162842f),
            bgScale: V3(2.265134811401367f, 1.5117360353469849f, 0.7023674249649048f),
            bgMat: "BG_WuDang",
            text: "\u6b66\u5f53", // 武当
            outlineColor: new Color(0.3962f, 0.2785f, 0.2000f, 0.6118f),
            raoDongPos: V2(158.8699951171875f, -11.199999809265137f),
            raoDongScale: V3(3.0780527591705322f, -1.618736982345581f, 0.6522601246833801f),
            raoDongMat: "RaoDong_WuDang",
            liuGuangMat: "LiuGuang_WuDang");

        // ---- Water_Effect ----
        // Bundle FontOutline: r=0.0445 g=0.1779 b=0.3774 a=0.6118
        total += BuildEffect(faction, sb, matDir, animDir, font, "Water_Effect",
            bgPos: V2(-1.2999999523162842f, -1.2999999523162842f),
            bgScale: V3(2.3128409385681152f, 1.5435748100280762f, 0.7171599864959717f),
            bgMat: "BG_EMei",
            text: "\u5ce8\u7709", // 峨眉
            outlineColor: new Color(0.0445f, 0.1779f, 0.3774f, 0.6118f),
            raoDongPos: V2(158.8699951171875f, -11.199999809265137f),
            raoDongScale: V3(3.0780527591705322f, -1.618736982345581f, 0.6522601246833801f),
            raoDongMat: "RaoDong_EMei",
            liuGuangMat: "LiuGuang_EMei");

        // ---- Wood_Effect ----
        // Bundle FontOutline: r=0.1355 g=0.3302 b=0.2452 a=0.6118
        total += BuildEffect(faction, sb, matDir, animDir, font, "Wood_Effect",
            bgPos: V2(-1.2999999523162842f, -1.2999999523162842f),
            bgScale: V3(3.2249999046325684f, 2.15234375f, 1.0f),
            bgMat: "BG_TangMen",
            text: "\u5510\u95e8", // 唐门
            outlineColor: new Color(0.1355f, 0.3302f, 0.2452f, 0.6118f),
            raoDongPos: V2(158.8699951171875f, -11.199999809265137f),
            raoDongScale: V3(3.0780527591705322f, -1.618736982345581f, 0.6522601246833801f),
            raoDongMat: "RaoDong_TangMen",
            liuGuangMat: "LiuGuang_TangMen");

        if (total > 0)
        {
            EditorSceneManager.MarkSceneDirty(
                UnityEngine.SceneManagement.SceneManager.GetActiveScene());
            EditorSceneManager.SaveOpenScenes();
        }

        sb.Insert(0, $"Restored {total} children total:\n");
        return sb.ToString();
    }

    static int BuildEffect(Transform faction, System.Text.StringBuilder sb,
        string matDir, string animDir, Font font, string effectName,
        Vector2 bgPos, Vector3 bgScale, string bgMat,
        string text, Color outlineColor,
        Vector2 raoDongPos, Vector3 raoDongScale, string raoDongMat,
        string liuGuangMat)
    {
        // Save info from existing Effect GO
        var existing = faction.Find(effectName);
        int sibIndex = -1;
        bool wasActive = true;
        if (existing != null)
        {
            sibIndex = existing.GetSiblingIndex();
            wasActive = existing.gameObject.activeSelf;
            Object.DestroyImmediate(existing.gameObject);
        }
        else
        {
            sb.AppendLine($"{effectName}: NOT FOUND, creating new");
        }

        // Create new GO with plain Transform (NOT RectTransform) — matches bundle
        var effectGO = new GameObject(effectName);
        effectGO.transform.SetParent(faction, false);
        effectGO.transform.localPosition = Vector3.zero;
        effectGO.transform.localScale = Vector3.one;
        effectGO.transform.localRotation = Quaternion.identity;
        if (sibIndex >= 0) effectGO.transform.SetSiblingIndex(sibIndex);

        // Add Animator with controller
        var animCtrl = AssetDatabase.LoadAssetAtPath<RuntimeAnimatorController>(
            $"{animDir}/{effectName}.controller");
        if (animCtrl != null)
        {
            var anim = effectGO.AddComponent<Animator>();
            anim.runtimeAnimatorController = animCtrl;
        }
        else
        {
            sb.AppendLine($"  WARNING: controller {effectName}.controller not found");
        }

        var effect = effectGO.transform;
        int count = 0;

        // 1. BG — Image with material
        {
            var go = CreateChild("BG", effect,
                V2(0.5f, 0.5f), V2(0.5f, 0.5f), V2(0.5f, 0.5f),
                bgPos, new Vector2(137.14999389648438f, 100f), bgScale, Vector3.zero);
            go.AddComponent<CanvasRenderer>();
            var img = go.AddComponent<Image>();
            img.sprite = null;
            img.color = new Color(1f, 1f, 1f, 0.997786283493042f);
            img.type = Image.Type.Simple;
            img.raycastTarget = true;
            SetMaterial(img, matDir, bgMat, sb);
            go.SetActive(true);
            count++;
        }

        // 2. Text — with UIMultiGradient, FontOutline, Localize
        // Bundle: font=common_zh, fontSize=65, alignment=MiddleCenter(4),
        //         color=white, bestFit=true, hOverflow=Wrap, vOverflow=Truncate,
        //         raycastTarget=true, richText=true
        {
            var go = CreateChild("Text", effect,
                V2(0.5f, 0.5f), V2(0.5f, 0.5f), V2(0.5f, 0.5f),
                Vector2.zero, new Vector2(280f, 100f), Vector3.one, Vector3.zero);
            go.AddComponent<CanvasRenderer>();
            var txt = go.AddComponent<Text>();
            txt.text = text;
            txt.font = font;
            txt.fontSize = 65;
            txt.color = Color.white;
            txt.alignment = TextAnchor.MiddleCenter;
            txt.raycastTarget = true;
            txt.supportRichText = true;
            txt.resizeTextForBestFit = true;
            txt.horizontalOverflow = HorizontalWrapMode.Wrap;
            txt.verticalOverflow = VerticalWrapMode.Truncate;
            // UIMultiGradient — bundle has it, defaults are OK (can't read gradient from stripped typetree)
            go.AddComponent<UIMultiGradient>();
            // FontOutline — bundle values: effectDistance=(3,3), per-element color
            var fo = go.AddComponent<FontOutline>();
            fo.effectColor = outlineColor;
            fo.effectDistance = new Vector2(3f, 3f);
            fo.useGraphicAlpha = true;
            // Localize — bundle has it with empty mTerm
            go.AddComponent<Localize>();
            go.SetActive(true);
            count++;
        }

        // 3. RaoDong — Image with material, localPos.z = 99.999755859375
        {
            var go = CreateChild("RaoDong", effect,
                V2(0.5f, 0.5f), V2(0.5f, 0.5f), new Vector2(1f, 0.5f),
                raoDongPos, new Vector2(100f, 100f), raoDongScale,
                new Vector3(0f, 0f, 99.999755859375f));
            go.AddComponent<CanvasRenderer>();
            var img = go.AddComponent<Image>();
            img.sprite = null;
            img.color = Color.white;
            img.type = Image.Type.Simple;
            img.raycastTarget = false;
            SetMaterial(img, matDir, raoDongMat, sb);
            go.SetActive(true);
            count++;
        }

        // 4. LiuGuang — Image + ImageEffectAnimationController
        {
            var go = CreateChild("LiuGuang", effect,
                V2(0.5f, 0.5f), V2(0.5f, 0.5f), V2(0.5f, 0.5f),
                Vector2.zero, new Vector2(137.14999389648438f, 100f),
                new Vector3(1.412500023841858f, 1f, 1f), Vector3.zero);
            go.AddComponent<CanvasRenderer>();
            var img = go.AddComponent<Image>();
            img.sprite = null;
            img.color = Color.white;
            img.type = Image.Type.Simple;
            img.raycastTarget = true;
            SetMaterial(img, matDir, liuGuangMat, sb);
            go.AddComponent<ImageEffectAnimationController>();
            // Re-assign after IEAC init
            SetMaterial(img, matDir, liuGuangMat, sb);
            go.SetActive(true);
            count++;
        }

        // 5. FireStar — inactive, has ParticleSystem in bundle (placeholder)
        {
            var go = CreateChild("FireStar", effect,
                V2(0.5f, 0.5f), V2(0.5f, 0.5f), V2(0.5f, 0.5f),
                new Vector2(1.399999976158142f, -0.6000000238418579f),
                new Vector2(100f, 100f), Vector3.one, Vector3.zero);
            go.SetActive(false);
            count++;
        }

        effectGO.SetActive(wasActive);
        sb.AppendLine($"{effectName}: created with Transform + {count} children");
        return count;
    }

    static GameObject CreateChild(string name, Transform parent,
        Vector2 anchorMin, Vector2 anchorMax, Vector2 pivot,
        Vector2 anchoredPos, Vector2 sizeDelta, Vector3 localScale, Vector3 localPos)
    {
        var go = new GameObject(name);
        var rt = go.AddComponent<RectTransform>();
        rt.SetParent(parent, false);
        rt.anchorMin = anchorMin;
        rt.anchorMax = anchorMax;
        rt.pivot = pivot;
        rt.sizeDelta = sizeDelta;
        rt.anchoredPosition = anchoredPos;
        rt.localScale = localScale;
        if (localPos.z != 0)
        {
            var lp = rt.localPosition;
            lp.z = localPos.z;
            rt.localPosition = lp;
        }
        return go;
    }

    static void SetMaterial(Image img, string matDir, string matName, System.Text.StringBuilder sb)
    {
        var mat = AssetDatabase.LoadAssetAtPath<Material>($"{matDir}/{matName}.mat");
        if (mat != null)
            img.material = mat;
        else
            sb.AppendLine($"  WARNING: material {matName} not found");
    }

    static Vector2 V2(float x, float y) => new Vector2(x, y);
    static Vector3 V3(float x, float y, float z) => new Vector3(x, y, z);
}
