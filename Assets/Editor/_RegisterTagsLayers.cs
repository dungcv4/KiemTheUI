#if UNITY_EDITOR
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace KTO.Editor.MapImport
{
    // Editing ProjectSettings/TagManager.asset on disk while the editor is
    // open does NOT make Unity reload it. The TagManager is loaded once at
    // startup and only re-saved when modified through SerializedObject.
    //
    // This editor action programmatically adds every Tag, Layer, and
    // SortingLayer that the KTO map/NPC bundles reference, going through
    // Unity's own SerializedObject API so the in-memory cache updates
    // immediately. Idempotent — entries that already exist are skipped.
    //
    // Source for the lists: the YAML I previously wrote to TagManager.asset,
    // which mirrors RippedProject_APK/ExportedProject/ProjectSettings/TagManager.asset
    // (sortingLayer uniqueIDs MUST stay byte-identical to the original or
    // the bundle's hash references will not resolve).
    public static class _RegisterTagsLayers
    {
        // Menu entry so a fresh checkout (or anyone who edits TagManager.asset
        // outside the editor) can re-register everything in one click. Run
        // this once after pulling, or whenever Unity logs
        // "[KTO_MapImporter] N/M SpriteRenderers fell back to Default sorting
        // layer". Idempotent.
        [MenuItem("KTO/Setup/Register Tags + Layers + Sorting Layers")]
        public static void Menu_Register() => Execute();


        // --- Tags ---
        // Source: RippedProject_APK/ExportedProject/ProjectSettings/TagManager.asset
        static readonly string[] RequiredTags =
        {
            "CullObj", "Wall", "Building", "Terrain", "Fly", "Exploder", "NoBuilding",
            "UICamera", "AdvancedEffect",
            "IgnoreSafeArea", "IgnoreSafeAreaLeft", "IgnoreSafeAreaRight",
            "UIBtn", "DropDown",
        };

        // --- Layer names. (slot, name).  Slots 0-5 are Unity built-ins and
        // are skipped by the writer.  Slots 6-8 are our existing project
        // layers and we keep them. The rest mirror the original game's
        // names so map/NPC/effect bundles can resolve via LayerMask.NameToLayer.
        // The actual slot index doesn't matter for the importer (it's
        // name-based) — but we match the original where free.
        static readonly (int slot, string name)[] RequiredLayers =
        {
            (6,  "Me"),                // ours (orig: "Character")
            (7,  "OtherPlayer"),       // ours (orig: empty)
            (8,  "Npc"),               // ours (orig: "Map")
            (9,  "SceneRep"),
            (10, "Player"),
            (11, "MapObj"),
            (12, "UiModel"),
            (13, "MapQG"),
            (14, "NoNpc"),
            (15, "MainPlayer"),
            (16, "UI3D"),
            (17, "Map"),
            (18, "Character"),
            (19, "TempForGround"),
            (20, "TempForFlyArea"),
            (21, "Reflection0"),
            (22, "Reflection1"),
            (23, "3DHeaUI"),
            (24, "HiddenScene"),
            (26, "Sky"),
            (27, "Level0"),
            (28, "Level1"),
            (29, "Level2"),
            (30, "Level3"),
            (31, "Terrain"),
        };

        // --- Sorting layers.  The uniqueID MUST match the original game
        // exactly — the bundle's sorting_layer_id field is a 32-bit hash
        // of the layer name; Unity matches by uniqueID when loading.
        // Source: RippedProject_APK/ExportedProject/ProjectSettings/TagManager.asset:54-120
        //
        // NOTE: uniqueID is stored as `Integer` SerializedProperty with
        // numericType=UInt32 internally. Unity rejects negative intValue,
        // so we MUST set via SerializedProperty.longValue using the
        // unsigned value extended to 64 bits. Using `int` here loses every
        // hash > 2^31 (BuildinObj, CoverGround, etc. — 16 of 21 entries).
        static readonly (string name, uint uniqueID)[] RequiredSortingLayers =
        {
            ("UI",                   194136777u),
            ("DistantScroll",        2085160307u),
            ("CoverDistantScroll",   2700818287u),
            ("Ground",               2485813873u),
            ("CoverGround",          3920483253u),
            ("NpcShadow",            2070212983u),
            ("EffectFoot",           2649464819u),
            ("PathLine",             2245926651u),
            ("NpcArrow",             4226587315u),
            ("Missile",              1637761177u),
            ("BuildinObj",           2901830771u),
            ("BuildinAboveObj",      1212627541u),
            ("CoverScroll",          3151216781u),
            ("Top",                  3701845327u),
            ("Map",                  4245656571u),
            ("Npc",                  2673848299u),
            ("Player",               2651622445u),
            ("Effect",               3340914149u),
            ("NpcHeadText",          845915985u),
            ("NpcBloodBar",          2440205355u),
            ("NpcFlyText",           3548724621u),
        };

        public static void Execute()
        {
            var assets = AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/TagManager.asset");
            if (assets == null || assets.Length == 0)
            {
                Debug.LogError("[_RegisterTagsLayers] Could not load ProjectSettings/TagManager.asset");
                return;
            }
            var tagMgr = new SerializedObject(assets[0]);

            int tagsAdded = AddTags(tagMgr);
            int layersAdded = SetLayers(tagMgr);
            int sortingAdded = AddSortingLayers(tagMgr);

            tagMgr.ApplyModifiedPropertiesWithoutUndo();
            EditorUtility.SetDirty(assets[0]);
            AssetDatabase.SaveAssets();

            Debug.Log($"[_RegisterTagsLayers] DONE — tags+{tagsAdded}, layers+{layersAdded}, sortingLayers+{sortingAdded}");

            // Print the result so we can see what's in the live table now
            Debug.Log($"[_RegisterTagsLayers] Live SortingLayer.layers count = {SortingLayer.layers.Length}");
            foreach (var l in SortingLayer.layers)
                Debug.Log($"[_RegisterTagsLayers]   SL '{l.name}' id={l.id} (uint={unchecked((uint)l.id)})");

            for (int i = 6; i < 32; i++)
            {
                var nm = LayerMask.LayerToName(i);
                if (!string.IsNullOrEmpty(nm))
                    Debug.Log($"[_RegisterTagsLayers]   layer[{i}] = '{nm}'");
            }
        }

        static int AddTags(SerializedObject so)
        {
            var tags = so.FindProperty("tags");
            var existing = new HashSet<string>();
            for (int i = 0; i < tags.arraySize; i++)
                existing.Add(tags.GetArrayElementAtIndex(i).stringValue);

            int added = 0;
            foreach (var t in RequiredTags)
            {
                if (existing.Contains(t)) continue;
                tags.InsertArrayElementAtIndex(tags.arraySize);
                tags.GetArrayElementAtIndex(tags.arraySize - 1).stringValue = t;
                existing.Add(t);
                added++;
            }
            return added;
        }

        static int SetLayers(SerializedObject so)
        {
            var layers = so.FindProperty("layers");
            int added = 0;
            foreach (var (slot, name) in RequiredLayers)
            {
                if (slot < 0 || slot >= layers.arraySize) continue;
                var prop = layers.GetArrayElementAtIndex(slot);
                if (prop.stringValue == name) continue;
                if (!string.IsNullOrEmpty(prop.stringValue) && prop.stringValue != name)
                {
                    Debug.LogWarning($"[_RegisterTagsLayers] layer[{slot}] already '{prop.stringValue}', skipping (wanted '{name}')");
                    continue;
                }
                prop.stringValue = name;
                added++;
            }
            return added;
        }

        static int AddSortingLayers(SerializedObject so)
        {
            var arr = so.FindProperty("m_SortingLayers");
            // Existing names → index, so we can update uniqueID if the name
            // exists with the wrong id (which is exactly the case here:
            // the in-memory TagManager only has Default, but the file on
            // disk has 22 entries with stale on-disk state Unity ignored).
            var existing = new Dictionary<string, int>();
            for (int i = 0; i < arr.arraySize; i++)
            {
                var entry = arr.GetArrayElementAtIndex(i);
                var nameProp = entry.FindPropertyRelative("name");
                if (nameProp != null) existing[nameProp.stringValue] = i;
            }

            int added = 0;
            foreach (var (name, uid) in RequiredSortingLayers)
            {
                long uidLong = (long)uid;   // extend uint→long; intValue would clip when uid > int.MaxValue
                int idx;
                if (existing.TryGetValue(name, out idx))
                {
                    var entry = arr.GetArrayElementAtIndex(idx);
                    var idProp = entry.FindPropertyRelative("uniqueID");
                    if (idProp != null && idProp.longValue != uidLong)
                    {
                        idProp.longValue = uidLong;
                        added++;
                    }
                }
                else
                {
                    arr.InsertArrayElementAtIndex(arr.arraySize);
                    var entry = arr.GetArrayElementAtIndex(arr.arraySize - 1);
                    entry.FindPropertyRelative("name").stringValue = name;
                    entry.FindPropertyRelative("uniqueID").longValue = uidLong;
                    var lockProp = entry.FindPropertyRelative("locked");
                    if (lockProp != null) lockProp.boolValue = false;
                    added++;
                }
            }
            return added;
        }
    }
}
#endif
