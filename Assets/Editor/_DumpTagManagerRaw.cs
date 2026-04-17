#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

namespace KTO.Editor.MapImport
{
    public static class _DumpTagManagerRaw
    {
        public static void Execute()
        {
            var assets = AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/TagManager.asset");
            var so = new SerializedObject(assets[0]);
            var arr = so.FindProperty("m_SortingLayers");
            Debug.Log($"[Raw] m_SortingLayers.arraySize = {arr.arraySize}");
            for (int i = 0; i < arr.arraySize; i++)
            {
                var entry = arr.GetArrayElementAtIndex(i);
                var nameProp = entry.FindPropertyRelative("name");
                var idProp = entry.FindPropertyRelative("uniqueID");
                var lockProp = entry.FindPropertyRelative("locked");
                string idDesc = "?";
                if (idProp != null)
                {
                    try { idDesc = $"{idProp.intValue} (uint={unchecked((uint)idProp.intValue)})"; }
                    catch { try { idDesc = $"long={idProp.longValue}"; } catch { idDesc = "<unknown>"; } }
                    idDesc = $"{idDesc} type={idProp.propertyType} numericType={idProp.numericType}";
                }
                Debug.Log($"[Raw]   [{i}] name='{(nameProp?.stringValue ?? "<null>")}' id={idDesc} locked={(lockProp?.boolValue.ToString() ?? "<null>")}");
            }
        }
    }
}
#endif
