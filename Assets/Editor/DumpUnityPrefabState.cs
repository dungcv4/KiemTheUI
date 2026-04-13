// DumpUnityPrefabState
// =====================
// Walks the UICreateRole prefab (or any root GO) and dumps every GameObject,
// every component, and every serialized field to JSON.
//
// The output is a path-keyed dict so it can be diffed against the
// extract_kto_prefab.py bundle JSON without worrying about PathID rebinding.
//
//   {
//     "root": "UICreateRole",
//     "gameObjects": {
//       "UICreateRole":              {"active": true, "layer": 5, "components": [...]},
//       "UICreateRole/imgBG":        {...},
//       "UICreateRole/imgBG/Faction/Wood_Effect/Text": {...}
//     }
//   }
//
// Each "components" entry is { "type": "<class>", "fields": { ... } }
// where the field dict is produced by walking SerializedProperty recursively.
// Object references are encoded as "<assetName>" (string) for sprites/fonts/
// materials, or as `null`. This matches the way the bundle JSON refers to
// externals after CAB resolution.
//
// Usage:
//   menu KTO/Compare/Dump UICreateRole prefab → /tmp/unity_state_UICreateRole.json
//   menu KTO/Compare/Dump UICreateRole scene  → /tmp/unity_state_UICreateRole_scene.json
//
// We deliberately use a tiny hand-rolled JSON writer (no Newtonsoft dep)
// because the values are very simple (numbers, strings, bools, lists, dicts).

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

public static class DumpUnityPrefabState
{
    const string kPrefabPath = "Assets/Prefabs/Imported/UICreateRole.prefab";
    const string kOutPrefab  = "/tmp/unity_state_UICreateRole.json";
    const string kOutScene   = "/tmp/unity_state_UICreateRole_scene.json";

    [MenuItem("KTO/Compare/Dump UICreateRole prefab")]
    public static void DumpPrefab()
    {
        var go = AssetDatabase.LoadAssetAtPath<GameObject>(kPrefabPath);
        if (go == null) { Debug.LogError($"[DumpUnityPrefabState] Prefab not found at {kPrefabPath}"); return; }
        var root = (GameObject)PrefabUtility.InstantiatePrefab(go);
        try
        {
            DumpRoot(root, kOutPrefab);
        }
        finally
        {
            UnityEngine.Object.DestroyImmediate(root);
        }
    }

    [MenuItem("KTO/Compare/Dump UICreateRole scene instance")]
    public static void DumpSceneInstance()
    {
        // Find UICreateRole in the open scene (UICreateRole_Canvas/UICreateRole)
        GameObject root = null;
        var scene = EditorSceneManager.GetActiveScene();
        foreach (var ro in scene.GetRootGameObjects())
        {
            root = FindByName(ro.transform, "UICreateRole");
            if (root != null) break;
        }
        if (root == null) { Debug.LogError("[DumpUnityPrefabState] UICreateRole not in active scene"); return; }
        DumpRoot(root, kOutScene);
    }

    public static void Execute()
    {
        // Default execute_script entry: dump prefab
        DumpPrefab();
    }

    // -----------------------------------------------------------------
    // Public helper for arbitrary roots (used by compare pipeline)
    // -----------------------------------------------------------------
    public static void DumpRoot(GameObject root, string outPath)
    {
        var sb = new StringBuilder();
        sb.Append('{');
        WriteKey(sb, "root"); WriteString(sb, root.name); sb.Append(',');
        WriteKey(sb, "gameObjects"); sb.Append('{');
        bool first = true;
        WalkAndDump(root.transform, root.name, sb, ref first);
        sb.Append('}');
        sb.Append('}');

        File.WriteAllText(outPath, sb.ToString());
        Debug.Log($"[DumpUnityPrefabState] Wrote {outPath} ({sb.Length} bytes)");
    }

    static void WalkAndDump(Transform t, string path, StringBuilder sb, ref bool first)
    {
        if (!first) sb.Append(',');
        first = false;
        WriteKey(sb, path);
        sb.Append('{');
        WriteKey(sb, "active"); WriteBool(sb, t.gameObject.activeSelf); sb.Append(',');
        WriteKey(sb, "layer");  WriteInt(sb, t.gameObject.layer);       sb.Append(',');
        WriteKey(sb, "components"); sb.Append('[');
        var comps = t.GetComponents<Component>();
        bool firstComp = true;
        for (int i = 0; i < comps.Length; i++)
        {
            var c = comps[i];
            if (c == null) continue;
            if (c is CanvasRenderer) continue; // noisy, never set in lua
            if (!firstComp) sb.Append(',');
            firstComp = false;
            DumpComponent(c, sb);
        }
        sb.Append(']');
        sb.Append('}');

        // Recurse children, building path
        for (int i = 0; i < t.childCount; i++)
        {
            var child = t.GetChild(i);
            WalkAndDump(child, path + "/" + child.name, sb, ref first);
        }
    }

    static void DumpComponent(Component c, StringBuilder sb)
    {
        sb.Append('{');
        WriteKey(sb, "type"); WriteString(sb, c.GetType().Name); sb.Append(',');
        WriteKey(sb, "fields"); sb.Append('{');
        try
        {
            var so = new SerializedObject(c);
            var prop = so.GetIterator();
            bool enterChildren = true;
            bool firstField = true;
            // Walk top-level fields only (depth-1) to keep output bounded.
            // Within each top-level field, expand recursively for structs.
            while (prop.NextVisible(enterChildren))
            {
                enterChildren = false;
                if (prop.depth != 0) continue;
                if (prop.name == "m_Script") continue;
                if (prop.name == "m_GameObject") continue;
                if (!firstField) sb.Append(',');
                firstField = false;
                WriteKey(sb, prop.name);
                WriteSerializedProperty(prop, sb, 0);
            }
        }
        catch (Exception ex)
        {
            sb.Append("\"_error\":"); WriteString(sb, ex.Message);
        }
        sb.Append('}');
        sb.Append('}');
    }

    static void WriteSerializedProperty(SerializedProperty prop, StringBuilder sb, int depth)
    {
        if (depth > 5) { sb.Append("null"); return; }
        switch (prop.propertyType)
        {
            case SerializedPropertyType.Integer:        WriteInt(sb, prop.intValue); break;
            case SerializedPropertyType.Boolean:        WriteBool(sb, prop.boolValue); break;
            case SerializedPropertyType.Float:          WriteFloat(sb, prop.floatValue); break;
            case SerializedPropertyType.String:         WriteString(sb, prop.stringValue); break;
            case SerializedPropertyType.Color:          WriteColor(sb, prop.colorValue); break;
            case SerializedPropertyType.LayerMask:      WriteInt(sb, prop.intValue); break;
            case SerializedPropertyType.Enum:           WriteInt(sb, prop.intValue); break;
            case SerializedPropertyType.Vector2:        WriteVec2(sb, prop.vector2Value); break;
            case SerializedPropertyType.Vector3:        WriteVec3(sb, prop.vector3Value); break;
            case SerializedPropertyType.Vector4:        WriteVec4(sb, prop.vector4Value); break;
            case SerializedPropertyType.Rect:           WriteRect(sb, prop.rectValue); break;
            case SerializedPropertyType.ArraySize:      WriteInt(sb, prop.intValue); break;
            case SerializedPropertyType.Character:      WriteInt(sb, prop.intValue); break;
            case SerializedPropertyType.Bounds:         WriteVec3(sb, prop.boundsValue.center); break;
            case SerializedPropertyType.Quaternion:     WriteVec4(sb, new Vector4(prop.quaternionValue.x, prop.quaternionValue.y, prop.quaternionValue.z, prop.quaternionValue.w)); break;
            case SerializedPropertyType.ObjectReference:
            {
                var o = prop.objectReferenceValue;
                if (o == null) { sb.Append("null"); break; }
                // Encode as a small object: { "_type": "Sprite", "name": "...", "guid": "..." }
                sb.Append('{');
                WriteKey(sb, "_ref");
                WriteString(sb, o.GetType().Name + ":" + o.name);
                sb.Append('}');
                break;
            }
            case SerializedPropertyType.Generic:
            {
                // Array vs struct
                if (prop.isArray)
                {
                    sb.Append('[');
                    int n = Math.Min(prop.arraySize, 32);
                    for (int i = 0; i < n; i++)
                    {
                        if (i > 0) sb.Append(',');
                        WriteSerializedProperty(prop.GetArrayElementAtIndex(i), sb, depth + 1);
                    }
                    if (prop.arraySize > n) { sb.Append(",\"_truncated\":"); WriteInt(sb, prop.arraySize - n); }
                    sb.Append(']');
                }
                else
                {
                    sb.Append('{');
                    var copy = prop.Copy();
                    var end = prop.GetEndProperty();
                    bool enterChildren = true;
                    bool firstField = true;
                    while (copy.NextVisible(enterChildren))
                    {
                        enterChildren = false;
                        if (SerializedProperty.EqualContents(copy, end)) break;
                        if (!firstField) sb.Append(',');
                        firstField = false;
                        WriteKey(sb, copy.name);
                        WriteSerializedProperty(copy, sb, depth + 1);
                    }
                    sb.Append('}');
                }
                break;
            }
            default:
                sb.Append("null");
                break;
        }
    }

    // ---------- Tiny JSON writer ----------
    static void WriteKey(StringBuilder sb, string k) { WriteString(sb, k); sb.Append(':'); }
    static void WriteString(StringBuilder sb, string s)
    {
        if (s == null) { sb.Append("null"); return; }
        sb.Append('"');
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (c == '"' || c == '\\') { sb.Append('\\'); sb.Append(c); }
            else if (c == '\n') sb.Append("\\n");
            else if (c == '\r') sb.Append("\\r");
            else if (c == '\t') sb.Append("\\t");
            else if (c < 0x20) sb.AppendFormat("\\u{0:x4}", (int)c);
            else sb.Append(c);
        }
        sb.Append('"');
    }
    static void WriteInt(StringBuilder sb, int v) { sb.Append(v.ToString(CultureInfo.InvariantCulture)); }
    static void WriteFloat(StringBuilder sb, float v)
    {
        if (float.IsNaN(v) || float.IsInfinity(v)) { sb.Append("null"); return; }
        sb.Append(v.ToString("R", CultureInfo.InvariantCulture));
    }
    static void WriteBool(StringBuilder sb, bool v) { sb.Append(v ? "true" : "false"); }
    static void WriteVec2(StringBuilder sb, Vector2 v) { sb.Append('['); WriteFloat(sb, v.x); sb.Append(','); WriteFloat(sb, v.y); sb.Append(']'); }
    static void WriteVec3(StringBuilder sb, Vector3 v) { sb.Append('['); WriteFloat(sb, v.x); sb.Append(','); WriteFloat(sb, v.y); sb.Append(','); WriteFloat(sb, v.z); sb.Append(']'); }
    static void WriteVec4(StringBuilder sb, Vector4 v) { sb.Append('['); WriteFloat(sb, v.x); sb.Append(','); WriteFloat(sb, v.y); sb.Append(','); WriteFloat(sb, v.z); sb.Append(','); WriteFloat(sb, v.w); sb.Append(']'); }
    static void WriteColor(StringBuilder sb, Color c) { sb.Append('['); WriteFloat(sb, c.r); sb.Append(','); WriteFloat(sb, c.g); sb.Append(','); WriteFloat(sb, c.b); sb.Append(','); WriteFloat(sb, c.a); sb.Append(']'); }
    static void WriteRect(StringBuilder sb, Rect r) { sb.Append('['); WriteFloat(sb, r.x); sb.Append(','); WriteFloat(sb, r.y); sb.Append(','); WriteFloat(sb, r.width); sb.Append(','); WriteFloat(sb, r.height); sb.Append(']'); }

    // -----------------------------------------------------------------
    static GameObject FindByName(Transform t, string name)
    {
        if (t.name == name) return t.gameObject;
        for (int i = 0; i < t.childCount; i++)
        {
            var r = FindByName(t.GetChild(i), name);
            if (r != null) return r;
        }
        return null;
    }
}
