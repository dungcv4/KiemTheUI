using System.IO;
using System.Text;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

// Walks the UICreateRole instance in the currently-open scene (or the prefab
// asset directly) and writes a flat JSON dump to /tmp/scene_create_role.json.
//
// The dump shape mirrors the keys we care about for diffing against the
// authoritative pipeline JSON at /tmp/res_p_55_resolved.json:
//   {
//     "root": "UICreateRole",
//     "nodes": [
//       { "path": "UICreateRole/FactionInfo/imgBG",
//         "name": "imgBG", "active": true,
//         "ap":[x,y], "sd":[w,h], "am":[x,y], "ax":[x,y], "pv":[x,y],
//         "sprite": "img_createrole_bg", "color":[r,g,b,a],
//         "text": "Cái Bang", "image": true, "txt": false }
//     ]
//   }
//
// Run via:  KTO → Dump CreateRole Scene
public static class DumpCreateRoleScene
{
    [MenuItem("KTO/Dump CreateRole Scene")]
    public static void Execute()
    {
        var root = FindRoot();
        if (root == null)
        {
            Debug.LogError("[DumpCreateRole] No 'UICreateRole' GameObject found in scene. Open CreateRoleScene.unity first.");
            return;
        }

        var sb = new StringBuilder();
        sb.Append("{\n  \"root\": ");
        AppendString(sb, root.name);
        sb.Append(",\n  \"nodes\": [\n");

        bool first = true;
        Walk(root.transform, root.name, sb, ref first);

        sb.Append("\n  ]\n}\n");
        File.WriteAllText("/tmp/scene_create_role.json", sb.ToString());
        Debug.Log($"[DumpCreateRole] Wrote /tmp/scene_create_role.json — root='{root.name}'");
    }

    private static GameObject FindRoot()
    {
        // First try direct lookup in the active scene
        var go = GameObject.Find("UICreateRole");
        if (go != null) return go;

        // Fallback: search inactive too
        foreach (var t in Object.FindObjectsByType<Transform>(FindObjectsInactive.Include, FindObjectsSortMode.None))
        {
            if (t.name == "UICreateRole") return t.gameObject;
        }
        return null;
    }

    private static void Walk(Transform t, string path, StringBuilder sb, ref bool first)
    {
        if (!first) sb.Append(",\n");
        first = false;
        EmitNode(t, path, sb);

        // Track sibling indices so duplicate names disambiguate during diff
        var counts = new System.Collections.Generic.Dictionary<string, int>();
        for (int i = 0; i < t.childCount; i++)
        {
            var c = t.GetChild(i);
            var n = c.name;
            int idx = counts.TryGetValue(n, out var cur) ? cur : 0;
            counts[n] = idx + 1;
            string childPath = path + "/" + n + (idx > 0 ? "#" + idx : "");
            Walk(c, childPath, sb, ref first);
        }
    }

    private static void EmitNode(Transform t, string path, StringBuilder sb)
    {
        var go = t.gameObject;
        var rt = t as RectTransform;

        sb.Append("    { \"path\": ");
        AppendString(sb, path);
        sb.Append(", \"name\": ");
        AppendString(sb, go.name);
        sb.Append(", \"active\": ");
        sb.Append(go.activeSelf ? "true" : "false");

        if (rt != null)
        {
            sb.Append(", \"ap\": ["); sb.Append(F(rt.anchoredPosition.x)); sb.Append(","); sb.Append(F(rt.anchoredPosition.y)); sb.Append("]");
            sb.Append(", \"sd\": ["); sb.Append(F(rt.sizeDelta.x));        sb.Append(","); sb.Append(F(rt.sizeDelta.y));        sb.Append("]");
            sb.Append(", \"am\": ["); sb.Append(F(rt.anchorMin.x));        sb.Append(","); sb.Append(F(rt.anchorMin.y));        sb.Append("]");
            sb.Append(", \"ax\": ["); sb.Append(F(rt.anchorMax.x));        sb.Append(","); sb.Append(F(rt.anchorMax.y));        sb.Append("]");
            sb.Append(", \"pv\": ["); sb.Append(F(rt.pivot.x));            sb.Append(","); sb.Append(F(rt.pivot.y));            sb.Append("]");
            sb.Append(", \"sc\": ["); sb.Append(F(rt.localScale.x));       sb.Append(","); sb.Append(F(rt.localScale.y));       sb.Append("]");
        }

        var img = go.GetComponent<Image>();
        if (img != null)
        {
            sb.Append(", \"image\": true");
            sb.Append(", \"sprite\": ");
            AppendString(sb, img.sprite != null ? img.sprite.name : "");
            var c = img.color;
            sb.Append(", \"color\": ["); sb.Append(F(c.r)); sb.Append(","); sb.Append(F(c.g)); sb.Append(","); sb.Append(F(c.b)); sb.Append(","); sb.Append(F(c.a)); sb.Append("]");
            sb.Append(", \"itype\": "); sb.Append((int)img.type);
            sb.Append(", \"ifill\": "); sb.Append(F(img.fillAmount));
        }

        var txt = go.GetComponent<Text>();
        if (txt != null)
        {
            sb.Append(", \"txt\": true");
            sb.Append(", \"text\": ");
            AppendString(sb, txt.text);
            sb.Append(", \"font\": ");
            AppendString(sb, txt.font != null ? txt.font.name : "");
            sb.Append(", \"fsz\": "); sb.Append(txt.fontSize);
        }

        sb.Append(" }");
    }

    private static string F(float v) => v.ToString("0.##", System.Globalization.CultureInfo.InvariantCulture);

    private static void AppendString(StringBuilder sb, string s)
    {
        sb.Append('"');
        if (s != null)
        {
            foreach (var ch in s)
            {
                switch (ch)
                {
                    case '"':  sb.Append("\\\""); break;
                    case '\\': sb.Append("\\\\"); break;
                    case '\n': sb.Append("\\n");  break;
                    case '\r': sb.Append("\\r");  break;
                    case '\t': sb.Append("\\t");  break;
                    default:
                        if (ch < 0x20) sb.Append("\\u").Append(((int)ch).ToString("x4"));
                        else sb.Append(ch);
                        break;
                }
            }
        }
        sb.Append('"');
    }
}
