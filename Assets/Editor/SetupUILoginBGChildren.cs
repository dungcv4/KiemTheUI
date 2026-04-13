// Creates the minimal UILoginBG child structure needed for avatar display.
// Matches the original bundle (res_p_134.ab) hierarchy:
//   UILoginBG (Canvas SSC, sortingLayer="UI", sortingOrder=-1)
//     bg (Image, 1660x1076, pos y=54)
//     VFX_after (SortingGroup, sortingOrder=0)
//       VFX_huo_after, VFX_jin_after, VFX_mu_after, VFX_shui_after, VFX_tu_after, VFX_TY_frame_after
//     Character (Canvas, sortingOrder=1)
//     VFX_front (SortingGroup, sortingOrder=2)
//       VFX_huo_front, VFX_jin_front, VFX_mu_front, VFX_shui_front, VFX_tu_front, VFX_TY_frame_front
//
// VFX particle children are created as empty placeholders (no ParticleSystem).
// Full VFX import requires res_p_134 pipeline which handles materials/textures.
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using UnityEditor;
using UnityEditor.SceneManagement;

public static class SetupUILoginBGChildren
{
    public static string Execute()
    {
        if (Application.isPlaying) return "Stop play mode first";

        var lbg = GameObject.Find("UILoginBG");
        if (lbg == null) return "UILoginBG not found in scene";

        var sb = new System.Text.StringBuilder();
        int created = 0;

        // 1. bg — Image (background)
        if (lbg.transform.Find("bg") == null)
        {
            var bgGO = new GameObject("bg", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image));
            bgGO.transform.SetParent(lbg.transform, false);
            bgGO.transform.SetSiblingIndex(0);
            var rt = bgGO.GetComponent<RectTransform>();
            rt.anchorMin = new Vector2(0.5f, 0.5f);
            rt.anchorMax = new Vector2(0.5f, 0.5f);
            rt.pivot = new Vector2(0.5f, 0.5f);
            rt.anchoredPosition = new Vector2(0f, 54f);
            rt.sizeDelta = new Vector2(1660f, 1076f);
            var img = bgGO.GetComponent<Image>();
            img.raycastTarget = false;
            // Try to load createrole_bg sprite
            var guids = AssetDatabase.FindAssets("t:Sprite createrole_bg");
            foreach (var g in guids)
            {
                var path = AssetDatabase.GUIDToAssetPath(g);
                var spr = AssetDatabase.LoadAssetAtPath<Sprite>(path);
                if (spr != null && spr.name == "createrole_bg")
                {
                    img.sprite = spr;
                    break;
                }
            }
            sb.AppendLine("bg: created");
            created++;
        }
        else sb.AppendLine("bg: already exists");

        // 2. VFX_after — SortingGroup (sortingOrder=0)
        if (lbg.transform.Find("VFX_after") == null)
        {
            var vfxAfterGO = new GameObject("VFX_after", typeof(RectTransform));
            vfxAfterGO.transform.SetParent(lbg.transform, false);
            vfxAfterGO.transform.SetSiblingIndex(1);
            var rt = vfxAfterGO.GetComponent<RectTransform>();
            rt.anchorMin = new Vector2(0.5f, 0.5f);
            rt.anchorMax = new Vector2(0.5f, 0.5f);
            rt.pivot = new Vector2(0.5f, 0.5f);
            rt.anchoredPosition = Vector2.zero;
            rt.sizeDelta = new Vector2(100f, 100f);
            var sg = vfxAfterGO.AddComponent<SortingGroup>();
            sg.sortingLayerName = "UI";
            sg.sortingOrder = 0;
            // Create VFX placeholder children (matching bundle names)
            string[] afterNames = {
                "VFX_huo_after", "VFX_jin_after", "VFX_mu_after",
                "VFX_shui_after", "VFX_tu_after", "VFX_TY_frame_after"
            };
            foreach (var name in afterNames)
            {
                var child = new GameObject(name);
                child.transform.SetParent(vfxAfterGO.transform, false);
                child.SetActive(false); // inactive until faction selected
            }
            sb.AppendLine("VFX_after: created with 6 placeholder children");
            created++;
        }
        else sb.AppendLine("VFX_after: already exists");

        // 3. Character — Canvas (sortingOrder=1)
        if (lbg.transform.Find("Character") == null)
        {
            var charGO = new GameObject("Character", typeof(RectTransform));
            charGO.transform.SetParent(lbg.transform, false);
            charGO.transform.SetSiblingIndex(2);
            var rt = charGO.GetComponent<RectTransform>();
            rt.anchorMin = new Vector2(0.5f, 0.5f);
            rt.anchorMax = new Vector2(0.5f, 0.5f);
            rt.pivot = new Vector2(0.5f, 0.5f);
            rt.anchoredPosition = Vector2.zero;
            rt.sizeDelta = new Vector2(100f, 100f);
            var canvas = charGO.AddComponent<Canvas>();
            canvas.overrideSorting = true;
            canvas.sortingLayerName = "UI";
            canvas.sortingOrder = 1;
            sb.AppendLine("Character: created with Canvas (sortingOrder=1)");
            created++;
        }
        else sb.AppendLine("Character: already exists");

        // 4. VFX_front — SortingGroup (sortingOrder=2)
        if (lbg.transform.Find("VFX_front") == null)
        {
            var vfxFrontGO = new GameObject("VFX_front", typeof(RectTransform));
            vfxFrontGO.transform.SetParent(lbg.transform, false);
            vfxFrontGO.transform.SetSiblingIndex(3);
            var rt = vfxFrontGO.GetComponent<RectTransform>();
            rt.anchorMin = new Vector2(0.5f, 0.5f);
            rt.anchorMax = new Vector2(0.5f, 0.5f);
            rt.pivot = new Vector2(0.5f, 0.5f);
            rt.anchoredPosition = Vector2.zero;
            rt.sizeDelta = new Vector2(100f, 100f);
            var sg = vfxFrontGO.AddComponent<SortingGroup>();
            sg.sortingLayerName = "UI";
            sg.sortingOrder = 2;
            // Create VFX placeholder children (matching bundle names)
            string[] frontNames = {
                "VFX_huo_front", "VFX_jin_front", "VFX_mu_front",
                "VFX_shui_front", "VFX_tu_front", "VFX_TY_frame_front"
            };
            foreach (var name in frontNames)
            {
                var child = new GameObject(name);
                child.transform.SetParent(vfxFrontGO.transform, false);
                child.SetActive(false);
            }
            sb.AppendLine("VFX_front: created with 6 placeholder children");
            created++;
        }
        else sb.AppendLine("VFX_front: already exists");

        if (created > 0)
        {
            EditorSceneManager.MarkSceneDirty(
                UnityEngine.SceneManagement.SceneManager.GetActiveScene());
            EditorSceneManager.SaveOpenScenes();
        }

        sb.Insert(0, $"SetupUILoginBGChildren: {created} created\n");
        return sb.ToString();
    }
}
