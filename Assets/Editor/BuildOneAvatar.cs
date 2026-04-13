// Quick test: build just F_5D avatar prefab
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEditor.Animations;

public static class BuildOneAvatar
{
    [MenuItem("KTO/Build Test Avatar (F_5D)")]
    public static void Execute()
    {
        EnsureDir("Assets/Animations/loginbg");
        EnsureDir("Assets/Prefabs/Imported/Avatars");

        // Stand clip: F2_5D (30f, 30fps, 1.0s, loop)
        var standSprites = new string[] {
            "F2_5D_stand_0001","F2_5D_stand_0002","F2_5D_stand_0003","F2_5D_stand_0004",
            "F2_5D_stand_0005","F2_5D_stand_0006","F2_5D_stand_0007","F2_5D_stand_0008",
            "F2_5D_stand_0009","F2_5D_stand_0010","F2_5D_stand_0011","F2_5D_stand_0012",
            "F2_5D_stand_0013","F2_5D_stand_0014","F2_5D_stand_0015","F2_5D_stand_0001",
            "F2_5D_stand_0002","F2_5D_stand_0003","F2_5D_stand_0004","F2_5D_stand_0005",
            "F2_5D_stand_0006","F2_5D_stand_0007","F2_5D_stand_0008","F2_5D_stand_0009",
            "F2_5D_stand_0010","F2_5D_stand_0011","F2_5D_stand_0012","F2_5D_stand_0013",
            "F2_5D_stand_0014","F2_5D_stand_0015"
        };
        var standClip = BuildClip("F2_5D", 30f, 1f, true, standSprites);
        CreateOrReplaceAsset(standClip, "Assets/Animations/loginbg/F2_5D.anim");

        // Action clip: F2_5D_ACTION (36f, 30fps, 1.2s, no loop)
        var actionSprites = new string[] {
            "F2_5D_action_0000","F2_5D_action_0002","F2_5D_action_0004","F2_5D_action_0006",
            "F2_5D_action_0008","F2_5D_action_0010","F2_5D_action_0012","F2_5D_action_0014",
            "F2_5D_action_0016","F2_5D_action_0018","F2_5D_action_0020","F2_5D_action_0022",
            "F2_5D_action_0024","F2_5D_action_0026","F2_5D_action_0028","F2_5D_action_0030",
            "F2_5D_action_0032","F2_5D_action_0034","F2_5D_action_0036","F2_5D_action_0038",
            "F2_5D_action_0040","F2_5D_action_0042","F2_5D_action_0044","F2_5D_action_0046",
            "F2_5D_action_0048","F2_5D_action_0050","F2_5D_action_0052","F2_5D_action_0054",
            "F2_5D_action_0056","F2_5D_action_0058","F2_5D_action_0060","F2_5D_action_0062",
            "F2_5D_action_0064","F2_5D_action_0066","F2_5D_action_0068","F2_5D_action_0070"
        };
        var actionClip = BuildClip("F2_5D_ACTION", 30f, 1.2f, false, actionSprites);
        CreateOrReplaceAsset(actionClip, "Assets/Animations/loginbg/F2_5D_ACTION.anim");

        // AnimatorController
        string ctrlPath = "Assets/Animations/loginbg/F_5D.controller";
        if (AssetDatabase.LoadAssetAtPath<RuntimeAnimatorController>(ctrlPath) != null)
            AssetDatabase.DeleteAsset(ctrlPath);
        var ctrl = AnimatorController.CreateAnimatorControllerAtPath(ctrlPath);
        ctrl.AddParameter("action", AnimatorControllerParameterType.Trigger);
        var rootSM = ctrl.layers[0].stateMachine;
        var standState = rootSM.AddState("stand");
        standState.motion = standClip;
        rootSM.defaultState = standState;
        var actionState = rootSM.AddState("action");
        actionState.motion = actionClip;
        var toAction = standState.AddTransition(actionState);
        toAction.AddCondition(AnimatorConditionMode.If, 0, "action");
        toAction.hasExitTime = false;
        toAction.duration = 0;
        var toStand = actionState.AddTransition(standState);
        toStand.hasExitTime = true;
        toStand.exitTime = 1f;
        toStand.duration = 0;

        // Prefab (matching bundle RectTransform exactly)
        var go = new GameObject("F_5D", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rt = go.GetComponent<RectTransform>();
        rt.anchoredPosition = new Vector2(214f, -292f);
        rt.sizeDelta = new Vector2(604f, 604f);
        rt.pivot = new Vector2(0.5f, 0f);
        rt.anchorMin = new Vector2(0.5f, 0.5f);
        rt.anchorMax = new Vector2(0.5f, 0.5f);
        var img = go.GetComponent<Image>();
        img.raycastTarget = false;
        img.sprite = FindSprite("F2_5D_stand_0001");
        var animator = go.GetComponent<Animator>();
        animator.runtimeAnimatorController = ctrl;
        PrefabUtility.SaveAsPrefabAsset(go, "Assets/Prefabs/Imported/Avatars/F_5D.prefab");
        Object.DestroyImmediate(go);

        AssetDatabase.SaveAssets();
        Debug.Log("[BuildOneAvatar] Built F_5D prefab with Animator + AnimationClips");
    }

    static AnimationClip BuildClip(string clipName, float sampleRate, float stopTime, bool loop, string[] spriteNames)
    {
        var clip = new AnimationClip();
        clip.name = clipName;
        clip.frameRate = sampleRate;
        var settings = AnimationUtility.GetAnimationClipSettings(clip);
        settings.loopTime = loop;
        AnimationUtility.SetAnimationClipSettings(clip, settings);
        var keyframes = new ObjectReferenceKeyframe[spriteNames.Length];
        float interval = spriteNames.Length > 1 ? stopTime / spriteNames.Length : 0;
        for (int i = 0; i < spriteNames.Length; i++)
        {
            keyframes[i] = new ObjectReferenceKeyframe
            {
                time = i * interval,
                value = FindSprite(spriteNames[i])
            };
        }
        var binding = EditorCurveBinding.PPtrCurve("", typeof(Image), "m_Sprite");
        AnimationUtility.SetObjectReferenceCurve(clip, binding, keyframes);
        return clip;
    }

    static void CreateOrReplaceAsset(Object asset, string path)
    {
        var existing = AssetDatabase.LoadAssetAtPath<Object>(path);
        if (existing != null) AssetDatabase.DeleteAsset(path);
        AssetDatabase.CreateAsset(asset, path);
    }

    static Sprite FindSprite(string spriteName)
    {
        string path = "Assets/Sprite/loginbg/" + spriteName + ".png";
        var sprite = AssetDatabase.LoadAssetAtPath<Sprite>(path);
        if (sprite != null) return sprite;
        var guids = AssetDatabase.FindAssets("t:Sprite " + spriteName);
        foreach (var g in guids)
        {
            var p = AssetDatabase.GUIDToAssetPath(g);
            var s = AssetDatabase.LoadAssetAtPath<Sprite>(p);
            if (s != null && s.name == spriteName) return s;
        }
        return null;
    }

    static void EnsureDir(string path)
    {
        if (!AssetDatabase.IsValidFolder(path))
        {
            var parts = path.Split('/');
            string current = parts[0];
            for (int i = 1; i < parts.Length; i++)
            {
                string next = current + "/" + parts[i];
                if (!AssetDatabase.IsValidFolder(next))
                    AssetDatabase.CreateFolder(current, parts[i]);
                current = next;
            }
        }
    }
}
