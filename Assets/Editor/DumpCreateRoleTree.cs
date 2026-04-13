using UnityEngine;
using UnityEditor;
using System.Text;

public static class DumpCreateRoleTree
{
    [MenuItem("KTO/Dump CreateRole Tree")]
    public static void Execute()
    {
        var prefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefabs/Imported/UICreateRole.prefab");
        if (prefab == null) { Debug.LogError("prefab not found"); return; }
        var sb = new StringBuilder();
        Dump(prefab.transform, 0, sb);
        System.IO.File.WriteAllText("/tmp/create_role_tree.txt", sb.ToString());
        Debug.Log($"[DumpCreateRoleTree] {sb.Length} bytes -> /tmp/create_role_tree.txt");
    }

    static void Dump(Transform t, int depth, StringBuilder sb)
    {
        for (int i = 0; i < depth; i++) sb.Append("  ");
        sb.Append(t.gameObject.activeSelf ? "[+] " : "[ ] ");
        sb.Append(t.name);
        var img = t.GetComponent<UnityEngine.UI.Image>();
        if (img != null) {
            sb.Append(" <Image sprite=" + (img.sprite ? img.sprite.name : "NULL") + " a=" + img.color.a.ToString("F2") + ">");
        }
        var txt = t.GetComponent<UnityEngine.UI.Text>();
        if (txt != null) {
            sb.Append(" <Text \"" + txt.text.Replace("\n","\\n") + "\">");
        }
        sb.Append("\n");
        foreach (Transform c in t) Dump(c, depth + 1, sb);
    }
}
