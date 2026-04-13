// AUTO-GENERATED — builds avatar prefabs from extracted loginbg bundle data.
// Matches original bundle structure: Image + Animator + AnimationClip (PPtrCurve).
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEditor.Animations;
using System.IO;

public static class BuildLoginBGAvatars
{
    [MenuItem("KTO/Build LoginBG Avatar Prefabs")]
    public static void BuildAll()
    {
        EnsureDir("Assets/Animations/loginbg");
        EnsureDir("Assets/Prefabs/Imported/Avatars");
        int count = 0;
        // === F_5D ===
        Build_F_5D();
        count++;
        // === F_BD ===
        Build_F_BD();
        count++;
        // === F_BTS ===
        Build_F_BTS();
        count++;
        // === F_CGM ===
        Build_F_CGM();
        count++;
        // === F_CY ===
        Build_F_CY();
        count++;
        // === F_DL ===
        Build_F_DL();
        count++;
        // === F_EM ===
        Build_F_EM();
        count++;
        // === F_GB ===
        Build_F_GB();
        count++;
        // === F_GM ===
        Build_F_GM();
        count++;
        // === F_KL ===
        Build_F_KL();
        count++;
        // === F_MJ ===
        Build_F_MJ();
        count++;
        // === F_THD ===
        Build_F_THD();
        count++;
        // === F_TM ===
        Build_F_TM();
        count++;
        // === F_TR ===
        Build_F_TR();
        count++;
        // === F_TW ===
        Build_F_TW();
        count++;
        // === F_WD ===
        Build_F_WD();
        count++;
        // === F_WHT ===
        Build_F_WHT();
        count++;
        // === F_XY ===
        Build_F_XY();
        count++;
        // === F_YP ===
        Build_F_YP();
        count++;
        // === M_5D ===
        Build_M_5D();
        count++;
        // === M_BD ===
        Build_M_BD();
        count++;
        // === M_BTS ===
        Build_M_BTS();
        count++;
        // === M_CGM ===
        Build_M_CGM();
        count++;
        // === M_CY ===
        Build_M_CY();
        count++;
        // === M_DL ===
        Build_M_DL();
        count++;
        // === M_GB ===
        Build_M_GB();
        count++;
        // === M_GM ===
        Build_M_GM();
        count++;
        // === M_KL ===
        Build_M_KL();
        count++;
        // === M_MJ ===
        Build_M_MJ();
        count++;
        // === M_SL ===
        Build_M_SL();
        count++;
        // === M_THD ===
        Build_M_THD();
        count++;
        // === M_TM ===
        Build_M_TM();
        count++;
        // === M_TR ===
        Build_M_TR();
        count++;
        // === M_TW ===
        Build_M_TW();
        count++;
        // === M_WD ===
        Build_M_WD();
        count++;
        // === M_WHT ===
        Build_M_WHT();
        count++;
        // === M_XY ===
        Build_M_XY();
        count++;
        // === M_YP ===
        Build_M_YP();
        count++;
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
        Debug.Log($"[BuildLoginBGAvatars] Built {count} avatar prefabs");
    }

    static void Build_F_5D()
    {
        string avatarName = "F_5D";
        // Stand clip: F2_5D (30f, 30.0fps)
        var standClip = BuildClip("F2_5D", 30.0f, 1.0f, true, new string[] {
            "F2_5D_stand_0001",
            "F2_5D_stand_0002",
            "F2_5D_stand_0003",
            "F2_5D_stand_0004",
            "F2_5D_stand_0005",
            "F2_5D_stand_0006",
            "F2_5D_stand_0007",
            "F2_5D_stand_0008",
            "F2_5D_stand_0009",
            "F2_5D_stand_0010",
            "F2_5D_stand_0011",
            "F2_5D_stand_0012",
            "F2_5D_stand_0013",
            "F2_5D_stand_0014",
            "F2_5D_stand_0015",
            "F2_5D_stand_0001",
            "F2_5D_stand_0002",
            "F2_5D_stand_0003",
            "F2_5D_stand_0004",
            "F2_5D_stand_0005",
            "F2_5D_stand_0006",
            "F2_5D_stand_0007",
            "F2_5D_stand_0008",
            "F2_5D_stand_0009",
            "F2_5D_stand_0010",
            "F2_5D_stand_0011",
            "F2_5D_stand_0012",
            "F2_5D_stand_0013",
            "F2_5D_stand_0014",
            "F2_5D_stand_0015"
        });
        AssetDatabase.CreateAsset(standClip, "Assets/Animations/loginbg/F2_5D.anim");
        // Action clip: F2_5D_ACTION (36f, 30.0fps)
        var actionClip = BuildClip("F2_5D_ACTION", 30.0f, 1.1999999284744263f, false, new string[] {
            "F2_5D_action_0000",
            "F2_5D_action_0002",
            "F2_5D_action_0004",
            "F2_5D_action_0006",
            "F2_5D_action_0008",
            "F2_5D_action_0010",
            "F2_5D_action_0012",
            "F2_5D_action_0014",
            "F2_5D_action_0016",
            "F2_5D_action_0018",
            "F2_5D_action_0020",
            "F2_5D_action_0022",
            "F2_5D_action_0024",
            "F2_5D_action_0026",
            "F2_5D_action_0028",
            "F2_5D_action_0030",
            "F2_5D_action_0032",
            "F2_5D_action_0034",
            "F2_5D_action_0036",
            "F2_5D_action_0038",
            "F2_5D_action_0040",
            "F2_5D_action_0042",
            "F2_5D_action_0044",
            "F2_5D_action_0046",
            "F2_5D_action_0048",
            "F2_5D_action_0050",
            "F2_5D_action_0052",
            "F2_5D_action_0054",
            "F2_5D_action_0056",
            "F2_5D_action_0058",
            "F2_5D_action_0060",
            "F2_5D_action_0062",
            "F2_5D_action_0064",
            "F2_5D_action_0066",
            "F2_5D_action_0068",
            "F2_5D_action_0070"
        });
        AssetDatabase.CreateAsset(actionClip, "Assets/Animations/loginbg/F2_5D_ACTION.anim");
        // AnimatorController: F_5D
        var ctrl = AnimatorController.CreateAnimatorControllerAtPath("Assets/Animations/loginbg/F_5D.controller");
        ctrl.AddParameter("action", AnimatorControllerParameterType.Trigger);
        var rootSM = ctrl.layers[0].stateMachine;
        var standState = rootSM.AddState("stand");
        standState.motion = standClip;
        rootSM.defaultState = standState;
        var actionState = rootSM.AddState("action");
        actionState.motion = actionClip;
        // stand → action (trigger)
        var toAction = standState.AddTransition(actionState);
        toAction.AddCondition(AnimatorConditionMode.If, 0, "action");
        toAction.hasExitTime = false;
        toAction.duration = 0;
        // action → stand (exit time)
        var toStand = actionState.AddTransition(standState);
        toStand.hasExitTime = true;
        toStand.exitTime = 1f;
        toStand.duration = 0;
        // Prefab: F_5D
        var go = new GameObject("F_5D", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rtComp = go.GetComponent<RectTransform>();
        rtComp.anchoredPosition = new Vector2(214.0f, -292.0f);
        rtComp.sizeDelta = new Vector2(604.0f, 604.0f);
        rtComp.pivot = new Vector2(0.5f, 0.0f);
        rtComp.anchorMin = new Vector2(0.5f, 0.5f);
        rtComp.anchorMax = new Vector2(0.5f, 0.5f);
        var img = go.GetComponent<Image>();
        img.raycastTarget = false;
        img.sprite = FindSprite("F2_5D_stand_0001");
        var animator = go.GetComponent<Animator>();
        animator.runtimeAnimatorController = ctrl;
        PrefabUtility.SaveAsPrefabAsset(go, "Assets/Prefabs/Imported/Avatars/F_5D.prefab");
        Object.DestroyImmediate(go);
    }

    static void Build_F_BD()
    {
        string avatarName = "F_BD";
        // Stand clip: F2_BD (15f, 30.0fps)
        var standClip = BuildClip("F2_BD", 30.0f, 0.5f, true, new string[] {
            "F2_BD_stand_0001",
            "F2_BD_stand_0002",
            "F2_BD_stand_0003",
            "F2_BD_stand_0004",
            "F2_BD_stand_0005",
            "F2_BD_stand_0006",
            "F2_BD_stand_0007",
            "F2_BD_stand_0008",
            "F2_BD_stand_0009",
            "F2_BD_stand_0010",
            "F2_BD_stand_0011",
            "F2_BD_stand_0012",
            "F2_BD_stand_0013",
            "F2_BD_stand_0014",
            "F2_BD_stand_0015"
        });
        AssetDatabase.CreateAsset(standClip, "Assets/Animations/loginbg/F2_BD.anim");
        // Action clip: F2_BD_ACTION (35f, 30.0fps)
        var actionClip = BuildClip("F2_BD_ACTION", 30.0f, 1.1666666269302368f, false, new string[] {
            "F2_BD_action_0001",
            "F2_BD_action_0003",
            "F2_BD_action_0005",
            "F2_BD_action_0007",
            "F2_BD_action_0009",
            "F2_BD_action_0011",
            "F2_BD_action_0013",
            "F2_BD_action_0015",
            "F2_BD_action_0017",
            "F2_BD_action_0019",
            "F2_BD_action_0021",
            "F2_BD_action_0023",
            "F2_BD_action_0025",
            "F2_BD_action_0027",
            "F2_BD_action_0029",
            "F2_BD_action_0031",
            "F2_BD_action_0033",
            "F2_BD_action_0035",
            "F2_BD_action_0037",
            "F2_BD_action_0039",
            "F2_BD_action_0041",
            "F2_BD_action_0043",
            "F2_BD_action_0045",
            "F2_BD_action_0047",
            "F2_BD_action_0049",
            "F2_BD_action_0051",
            "F2_BD_action_0053",
            "F2_BD_action_0054",
            "F2_BD_action_0055",
            "F2_BD_action_0056",
            "F2_BD_action_0057",
            "F2_BD_action_0058",
            "F2_BD_action_0059",
            "F2_BD_action_0060",
            "F2_BD_action_0061"
        });
        AssetDatabase.CreateAsset(actionClip, "Assets/Animations/loginbg/F2_BD_ACTION.anim");
        // AnimatorController: F_BD
        var ctrl = AnimatorController.CreateAnimatorControllerAtPath("Assets/Animations/loginbg/F_BD.controller");
        ctrl.AddParameter("action", AnimatorControllerParameterType.Trigger);
        var rootSM = ctrl.layers[0].stateMachine;
        var standState = rootSM.AddState("stand");
        standState.motion = standClip;
        rootSM.defaultState = standState;
        var actionState = rootSM.AddState("action");
        actionState.motion = actionClip;
        // stand → action (trigger)
        var toAction = standState.AddTransition(actionState);
        toAction.AddCondition(AnimatorConditionMode.If, 0, "action");
        toAction.hasExitTime = false;
        toAction.duration = 0;
        // action → stand (exit time)
        var toStand = actionState.AddTransition(standState);
        toStand.hasExitTime = true;
        toStand.exitTime = 1f;
        toStand.duration = 0;
        // Prefab: F_BD
        var go = new GameObject("F_BD", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rtComp = go.GetComponent<RectTransform>();
        rtComp.anchoredPosition = new Vector2(200.20001220703125f, -285.0f);
        rtComp.sizeDelta = new Vector2(512.0f, 512.0f);
        rtComp.pivot = new Vector2(0.6000000238418579f, 0.0f);
        rtComp.anchorMin = new Vector2(0.5f, 0.5f);
        rtComp.anchorMax = new Vector2(0.5f, 0.5f);
        var img = go.GetComponent<Image>();
        img.raycastTarget = false;
        img.sprite = FindSprite("F2_BD_stand_0001");
        var animator = go.GetComponent<Animator>();
        animator.runtimeAnimatorController = ctrl;
        PrefabUtility.SaveAsPrefabAsset(go, "Assets/Prefabs/Imported/Avatars/F_BD.prefab");
        Object.DestroyImmediate(go);
    }

    static void Build_F_BTS()
    {
        string avatarName = "F_BTS";
        // Stand clip: F2_BTS (16f, 30.0fps)
        var standClip = BuildClip("F2_BTS", 30.0f, 0.5333333611488342f, true, new string[] {
            "F2_BTS_stand_0001",
            "F2_BTS_stand_0002",
            "F2_BTS_stand_0003",
            "F2_BTS_stand_0004",
            "F2_BTS_stand_0005",
            "F2_BTS_stand_0006",
            "F2_BTS_stand_0007",
            "F2_BTS_stand_0008",
            "F2_BTS_stand_0009",
            "F2_BTS_stand_0010",
            "F2_BTS_stand_0011",
            "F2_BTS_stand_0012",
            "F2_BTS_stand_0013",
            "F2_BTS_stand_0014",
            "F2_BTS_stand_0015",
            "F2_BTS_stand_0016"
        });
        AssetDatabase.CreateAsset(standClip, "Assets/Animations/loginbg/F2_BTS.anim");
        // Action clip: F2_BTS_ACTION (31f, 30.0fps)
        var actionClip = BuildClip("F2_BTS_ACTION", 30.0f, 1.0333333015441895f, false, new string[] {
            "F2_BTS_action_0001",
            "F2_BTS_action_0003",
            "F2_BTS_action_0005",
            "F2_BTS_action_0007",
            "F2_BTS_action_0009",
            "F2_BTS_action_0011",
            "F2_BTS_action_0013",
            "F2_BTS_action_0015",
            "F2_BTS_action_0017",
            "F2_BTS_action_0019",
            "F2_BTS_action_0021",
            "F2_BTS_action_0023",
            "F2_BTS_action_0025",
            "F2_BTS_action_0027",
            "F2_BTS_action_0029",
            "F2_BTS_action_0031",
            "F2_BTS_action_0033",
            "F2_BTS_action_0035",
            "F2_BTS_action_0037",
            "F2_BTS_action_0039",
            "F2_BTS_action_0041",
            "F2_BTS_action_0043",
            "F2_BTS_action_0045",
            "F2_BTS_action_0047",
            "F2_BTS_action_0049",
            "F2_BTS_action_0051",
            "F2_BTS_action_0053",
            "F2_BTS_action_0055",
            "F2_BTS_action_0057",
            "F2_BTS_action_0059",
            "F2_BTS_action_0061"
        });
        AssetDatabase.CreateAsset(actionClip, "Assets/Animations/loginbg/F2_BTS_ACTION.anim");
        // AnimatorController: F_BTS
        var ctrl = AnimatorController.CreateAnimatorControllerAtPath("Assets/Animations/loginbg/F_BTS.controller");
        ctrl.AddParameter("action", AnimatorControllerParameterType.Trigger);
        var rootSM = ctrl.layers[0].stateMachine;
        var standState = rootSM.AddState("stand");
        standState.motion = standClip;
        rootSM.defaultState = standState;
        var actionState = rootSM.AddState("action");
        actionState.motion = actionClip;
        // stand → action (trigger)
        var toAction = standState.AddTransition(actionState);
        toAction.AddCondition(AnimatorConditionMode.If, 0, "action");
        toAction.hasExitTime = false;
        toAction.duration = 0;
        // action → stand (exit time)
        var toStand = actionState.AddTransition(standState);
        toStand.hasExitTime = true;
        toStand.exitTime = 1f;
        toStand.duration = 0;
        // Prefab: F_BTS
        var go = new GameObject("F_BTS", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rtComp = go.GetComponent<RectTransform>();
        rtComp.anchoredPosition = new Vector2(175.0f, -279.0f);
        rtComp.sizeDelta = new Vector2(531.0f, 598.0f);
        rtComp.pivot = new Vector2(0.47999998927116394f, 0.0f);
        rtComp.anchorMin = new Vector2(0.5f, 0.5f);
        rtComp.anchorMax = new Vector2(0.5f, 0.5f);
        var img = go.GetComponent<Image>();
        img.raycastTarget = false;
        img.sprite = FindSprite("F2_BTS_stand_0001");
        var animator = go.GetComponent<Animator>();
        animator.runtimeAnimatorController = ctrl;
        PrefabUtility.SaveAsPrefabAsset(go, "Assets/Prefabs/Imported/Avatars/F_BTS.prefab");
        Object.DestroyImmediate(go);
    }

    static void Build_F_CGM()
    {
        string avatarName = "F_CGM";
        // Stand clip: F2_CGM (16f, 30.0fps)
        var standClip = BuildClip("F2_CGM", 30.0f, 0.5333333611488342f, true, new string[] {
            "F2_CGM_stand_0001",
            "F2_CGM_stand_0002",
            "F2_CGM_stand_0003",
            "F2_CGM_stand_0004",
            "F2_CGM_stand_0005",
            "F2_CGM_stand_0006",
            "F2_CGM_stand_0007",
            "F2_CGM_stand_0008",
            "F2_CGM_stand_0009",
            "F2_CGM_stand_0010",
            "F2_CGM_stand_0011",
            "F2_CGM_stand_0012",
            "F2_CGM_stand_0013",
            "F2_CGM_stand_0014",
            "F2_CGM_stand_0015",
            "F2_CGM_stand_0016"
        });
        AssetDatabase.CreateAsset(standClip, "Assets/Animations/loginbg/F2_CGM.anim");
        // Action clip: F2_CGM_ACTION (31f, 30.0fps)
        var actionClip = BuildClip("F2_CGM_ACTION", 30.0f, 1.0333333015441895f, false, new string[] {
            "F2_CGM_action_0001",
            "F2_CGM_action_0003",
            "F2_CGM_action_0005",
            "F2_CGM_action_0007",
            "F2_CGM_action_0009",
            "F2_CGM_action_0011",
            "F2_CGM_action_0013",
            "F2_CGM_action_0015",
            "F2_CGM_action_0017",
            "F2_CGM_action_0019",
            "F2_CGM_action_0021",
            "F2_CGM_action_0023",
            "F2_CGM_action_0025",
            "F2_CGM_action_0027",
            "F2_CGM_action_0029",
            "F2_CGM_action_0031",
            "F2_CGM_action_0033",
            "F2_CGM_action_0035",
            "F2_CGM_action_0037",
            "F2_CGM_action_0039",
            "F2_CGM_action_0041",
            "F2_CGM_action_0043",
            "F2_CGM_action_0045",
            "F2_CGM_action_0047",
            "F2_CGM_action_0049",
            "F2_CGM_action_0051",
            "F2_CGM_action_0053",
            "F2_CGM_action_0055",
            "F2_CGM_action_0057",
            "F2_CGM_action_0059",
            "F2_CGM_action_0061"
        });
        AssetDatabase.CreateAsset(actionClip, "Assets/Animations/loginbg/F2_CGM_ACTION.anim");
        // AnimatorController: F_CGM
        var ctrl = AnimatorController.CreateAnimatorControllerAtPath("Assets/Animations/loginbg/F_CGM.controller");
        ctrl.AddParameter("action", AnimatorControllerParameterType.Trigger);
        var rootSM = ctrl.layers[0].stateMachine;
        var standState = rootSM.AddState("stand");
        standState.motion = standClip;
        rootSM.defaultState = standState;
        var actionState = rootSM.AddState("action");
        actionState.motion = actionClip;
        // stand → action (trigger)
        var toAction = standState.AddTransition(actionState);
        toAction.AddCondition(AnimatorConditionMode.If, 0, "action");
        toAction.hasExitTime = false;
        toAction.duration = 0;
        // action → stand (exit time)
        var toStand = actionState.AddTransition(standState);
        toStand.hasExitTime = true;
        toStand.exitTime = 1f;
        toStand.duration = 0;
        // Prefab: F_CGM
        var go = new GameObject("F_CGM", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rtComp = go.GetComponent<RectTransform>();
        rtComp.anchoredPosition = new Vector2(183.1599884033203f, -275.0f);
        rtComp.sizeDelta = new Vector2(417.0f, 628.0f);
        rtComp.pivot = new Vector2(0.5199999809265137f, 0.0f);
        rtComp.anchorMin = new Vector2(0.5f, 0.5f);
        rtComp.anchorMax = new Vector2(0.5f, 0.5f);
        var img = go.GetComponent<Image>();
        img.raycastTarget = false;
        img.sprite = FindSprite("F2_CGM_stand_0001");
        var animator = go.GetComponent<Animator>();
        animator.runtimeAnimatorController = ctrl;
        PrefabUtility.SaveAsPrefabAsset(go, "Assets/Prefabs/Imported/Avatars/F_CGM.prefab");
        Object.DestroyImmediate(go);
    }

    static void Build_F_CY()
    {
        string avatarName = "F_CY";
        // Stand clip: F2_CY (32f, 30.0fps)
        var standClip = BuildClip("F2_CY", 30.0f, 1.066666603088379f, true, new string[] {
            "F2_CY_stand_0001",
            "F2_CY_stand_0002",
            "F2_CY_stand_0003",
            "F2_CY_stand_0004",
            "F2_CY_stand_0005",
            "F2_CY_stand_0006",
            "F2_CY_stand_0007",
            "F2_CY_stand_0008",
            "F2_CY_stand_0009",
            "F2_CY_stand_0010",
            "F2_CY_stand_0011",
            "F2_CY_stand_0012",
            "F2_CY_stand_0013",
            "F2_CY_stand_0014",
            "F2_CY_stand_0015",
            "F2_CY_stand_0016",
            "F2_CY_stand_0001",
            "F2_CY_stand_0002",
            "F2_CY_stand_0003",
            "F2_CY_stand_0004",
            "F2_CY_stand_0005",
            "F2_CY_stand_0006",
            "F2_CY_stand_0007",
            "F2_CY_stand_0008",
            "F2_CY_stand_0009",
            "F2_CY_stand_0010",
            "F2_CY_stand_0011",
            "F2_CY_stand_0012",
            "F2_CY_stand_0013",
            "F2_CY_stand_0014",
            "F2_CY_stand_0015",
            "F2_CY_stand_0016"
        });
        AssetDatabase.CreateAsset(standClip, "Assets/Animations/loginbg/F2_CY.anim");
        // Action clip: F2_CY_ACTION (30f, 30.0fps)
        var actionClip = BuildClip("F2_CY_ACTION", 30.0f, 1.0f, false, new string[] {
            "F2_CY_action_0000",
            "F2_CY_action_0002",
            "F2_CY_action_0004",
            "F2_CY_action_0006",
            "F2_CY_action_0008",
            "F2_CY_action_0010",
            "F2_CY_action_0012",
            "F2_CY_action_0014",
            "F2_CY_action_0016",
            "F2_CY_action_0018",
            "F2_CY_action_0020",
            "F2_CY_action_0022",
            "F2_CY_action_0024",
            "F2_CY_action_0026",
            "F2_CY_action_0028",
            "F2_CY_action_0030",
            "F2_CY_action_0032",
            "F2_CY_action_0034",
            "F2_CY_action_0036",
            "F2_CY_action_0038",
            "F2_CY_action_0040",
            "F2_CY_action_0042",
            "F2_CY_action_0044",
            "F2_CY_action_0046",
            "F2_CY_action_0048",
            "F2_CY_action_0050",
            "F2_CY_action_0052",
            "F2_CY_action_0054",
            "F2_CY_action_0056",
            "F2_CY_action_0058"
        });
        AssetDatabase.CreateAsset(actionClip, "Assets/Animations/loginbg/F2_CY_ACTION.anim");
        // AnimatorController: F_CY
        var ctrl = AnimatorController.CreateAnimatorControllerAtPath("Assets/Animations/loginbg/F_CY.controller");
        ctrl.AddParameter("action", AnimatorControllerParameterType.Trigger);
        var rootSM = ctrl.layers[0].stateMachine;
        var standState = rootSM.AddState("stand");
        standState.motion = standClip;
        rootSM.defaultState = standState;
        var actionState = rootSM.AddState("action");
        actionState.motion = actionClip;
        // stand → action (trigger)
        var toAction = standState.AddTransition(actionState);
        toAction.AddCondition(AnimatorConditionMode.If, 0, "action");
        toAction.hasExitTime = false;
        toAction.duration = 0;
        // action → stand (exit time)
        var toStand = actionState.AddTransition(standState);
        toStand.hasExitTime = true;
        toStand.exitTime = 1f;
        toStand.duration = 0;
        // Prefab: F_CY
        var go = new GameObject("F_CY", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rtComp = go.GetComponent<RectTransform>();
        rtComp.anchoredPosition = new Vector2(179.00003051757812f, -268.0f);
        rtComp.sizeDelta = new Vector2(384.0f, 512.0f);
        rtComp.pivot = new Vector2(0.5f, 0.0f);
        rtComp.anchorMin = new Vector2(0.5f, 0.5f);
        rtComp.anchorMax = new Vector2(0.5f, 0.5f);
        var img = go.GetComponent<Image>();
        img.raycastTarget = false;
        img.sprite = FindSprite("F2_CY_stand_0001");
        var animator = go.GetComponent<Animator>();
        animator.runtimeAnimatorController = ctrl;
        PrefabUtility.SaveAsPrefabAsset(go, "Assets/Prefabs/Imported/Avatars/F_CY.prefab");
        Object.DestroyImmediate(go);
    }

    static void Build_F_DL()
    {
        string avatarName = "F_DL";
        // Stand clip: F2_DL (32f, 30.0fps)
        var standClip = BuildClip("F2_DL", 30.0f, 1.066666603088379f, true, new string[] {
            "F2_DL_stand_0001",
            "F2_DL_stand_0002",
            "F2_DL_stand_0003",
            "F2_DL_stand_0004",
            "F2_DL_stand_0005",
            "F2_DL_stand_0006",
            "F2_DL_stand_0007",
            "F2_DL_stand_0008",
            "F2_DL_stand_0009",
            "F2_DL_stand_0010",
            "F2_DL_stand_0011",
            "F2_DL_stand_0012",
            "F2_DL_stand_0013",
            "F2_DL_stand_0014",
            "F2_DL_stand_0015",
            "F2_DL_stand_0016",
            "F2_DL_stand_0001",
            "F2_DL_stand_0002",
            "F2_DL_stand_0003",
            "F2_DL_stand_0004",
            "F2_DL_stand_0005",
            "F2_DL_stand_0006",
            "F2_DL_stand_0007",
            "F2_DL_stand_0008",
            "F2_DL_stand_0009",
            "F2_DL_stand_0010",
            "F2_DL_stand_0011",
            "F2_DL_stand_0012",
            "F2_DL_stand_0013",
            "F2_DL_stand_0014",
            "F2_DL_stand_0015",
            "F2_DL_stand_0016"
        });
        AssetDatabase.CreateAsset(standClip, "Assets/Animations/loginbg/F2_DL.anim");
        // Action clip: F2_DL_action (32f, 30.0fps)
        var actionClip = BuildClip("F2_DL_action", 30.0f, 1.1333333253860474f, false, new string[] {
            "F2_DL_action_0000",
            "F2_DL_action_0002",
            "F2_DL_action_0004",
            "F2_DL_action_0006",
            "F2_DL_action_0008",
            "F2_DL_action_0010",
            "F2_DL_action_0012",
            "F2_DL_action_0014",
            "F2_DL_action_0016",
            "F2_DL_action_0018",
            "F2_DL_action_0020",
            "F2_DL_action_0022",
            "F2_DL_action_0024",
            "F2_DL_action_0026",
            "F2_DL_action_0028",
            "F2_DL_action_0030",
            "F2_DL_action_0032",
            "F2_DL_action_0034",
            "F2_DL_action_0036",
            "F2_DL_action_0038",
            "F2_DL_action_0040",
            "F2_DL_action_0042",
            "F2_DL_action_0044",
            "F2_DL_action_0046",
            "F2_DL_action_0048",
            "F2_DL_action_0050",
            "F2_DL_action_0052",
            "F2_DL_action_0054",
            "F2_DL_action_0056",
            "F2_DL_action_0058",
            "F2_DL_action_0060",
            "F2_DL_action_0062"
        });
        AssetDatabase.CreateAsset(actionClip, "Assets/Animations/loginbg/F2_DL_action.anim");
        // AnimatorController: F_DL
        var ctrl = AnimatorController.CreateAnimatorControllerAtPath("Assets/Animations/loginbg/F_DL.controller");
        ctrl.AddParameter("action", AnimatorControllerParameterType.Trigger);
        var rootSM = ctrl.layers[0].stateMachine;
        var standState = rootSM.AddState("stand");
        standState.motion = standClip;
        rootSM.defaultState = standState;
        var actionState = rootSM.AddState("action");
        actionState.motion = actionClip;
        // stand → action (trigger)
        var toAction = standState.AddTransition(actionState);
        toAction.AddCondition(AnimatorConditionMode.If, 0, "action");
        toAction.hasExitTime = false;
        toAction.duration = 0;
        // action → stand (exit time)
        var toStand = actionState.AddTransition(standState);
        toStand.hasExitTime = true;
        toStand.exitTime = 1f;
        toStand.duration = 0;
        // Prefab: F_DL
        var go = new GameObject("F_DL", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rtComp = go.GetComponent<RectTransform>();
        rtComp.anchoredPosition = new Vector2(238.50003051757812f, -293.9999694824219f);
        rtComp.sizeDelta = new Vector2(696.0f, 522.0f);
        rtComp.pivot = new Vector2(0.5f, 0.0f);
        rtComp.anchorMin = new Vector2(0.5f, 0.5f);
        rtComp.anchorMax = new Vector2(0.5f, 0.5f);
        var img = go.GetComponent<Image>();
        img.raycastTarget = false;
        img.sprite = FindSprite("F2_DL_stand_0001");
        var animator = go.GetComponent<Animator>();
        animator.runtimeAnimatorController = ctrl;
        PrefabUtility.SaveAsPrefabAsset(go, "Assets/Prefabs/Imported/Avatars/F_DL.prefab");
        Object.DestroyImmediate(go);
    }

    static void Build_F_EM()
    {
        string avatarName = "F_EM";
        // Stand clip: F2_EM (32f, 30.0fps)
        var standClip = BuildClip("F2_EM", 30.0f, 1.066666603088379f, true, new string[] {
            "F2_EM_stand_0001",
            "F2_EM_stand_0002",
            "F2_EM_stand_0003",
            "F2_EM_stand_0004",
            "F2_EM_stand_0005",
            "F2_EM_stand_0006",
            "F2_EM_stand_0007",
            "F2_EM_stand_0008",
            "F2_EM_stand_0009",
            "F2_EM_stand_0010",
            "F2_EM_stand_0011",
            "F2_EM_stand_0012",
            "F2_EM_stand_0013",
            "F2_EM_stand_0014",
            "F2_EM_stand_0015",
            "F2_EM_stand_0016",
            "F2_EM_stand_0001",
            "F2_EM_stand_0002",
            "F2_EM_stand_0003",
            "F2_EM_stand_0004",
            "F2_EM_stand_0005",
            "F2_EM_stand_0006",
            "F2_EM_stand_0007",
            "F2_EM_stand_0008",
            "F2_EM_stand_0009",
            "F2_EM_stand_0010",
            "F2_EM_stand_0011",
            "F2_EM_stand_0012",
            "F2_EM_stand_0013",
            "F2_EM_stand_0014",
            "F2_EM_stand_0015",
            "F2_EM_stand_0016"
        });
        AssetDatabase.CreateAsset(standClip, "Assets/Animations/loginbg/F2_EM.anim");
        // Action clip: F2_EM_ACTION (32f, 30.0fps)
        var actionClip = BuildClip("F2_EM_ACTION", 30.0f, 1.066666603088379f, false, new string[] {
            "F2_EM_action_0001",
            "F2_EM_action_0003",
            "F2_EM_action_0005",
            "F2_EM_action_0007",
            "F2_EM_action_0009",
            "F2_EM_action_0011",
            "F2_EM_action_0013",
            "F2_EM_action_0015",
            "F2_EM_action_0017",
            "F2_EM_action_0019",
            "F2_EM_action_0021",
            "F2_EM_action_0023",
            "F2_EM_action_0025",
            "F2_EM_action_0027",
            "F2_EM_action_0029",
            "F2_EM_action_0031",
            "F2_EM_action_0033",
            "F2_EM_action_0035",
            "F2_EM_action_0037",
            "F2_EM_action_0039",
            "F2_EM_action_0041",
            "F2_EM_action_0043",
            "F2_EM_action_0045",
            "F2_EM_action_0047",
            "F2_EM_action_0049",
            "F2_EM_action_0051",
            "F2_EM_action_0053",
            "F2_EM_action_0055",
            "F2_EM_action_0057",
            "F2_EM_action_0059",
            "F2_EM_action_0061",
            "F2_EM_action_0001"
        });
        AssetDatabase.CreateAsset(actionClip, "Assets/Animations/loginbg/F2_EM_ACTION.anim");
        // AnimatorController: F_EM
        var ctrl = AnimatorController.CreateAnimatorControllerAtPath("Assets/Animations/loginbg/F_EM.controller");
        ctrl.AddParameter("action", AnimatorControllerParameterType.Trigger);
        var rootSM = ctrl.layers[0].stateMachine;
        var standState = rootSM.AddState("stand");
        standState.motion = standClip;
        rootSM.defaultState = standState;
        var actionState = rootSM.AddState("action");
        actionState.motion = actionClip;
        // stand → action (trigger)
        var toAction = standState.AddTransition(actionState);
        toAction.AddCondition(AnimatorConditionMode.If, 0, "action");
        toAction.hasExitTime = false;
        toAction.duration = 0;
        // action → stand (exit time)
        var toStand = actionState.AddTransition(standState);
        toStand.hasExitTime = true;
        toStand.exitTime = 1f;
        toStand.duration = 0;
        // Prefab: F_EM
        var go = new GameObject("F_EM", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rtComp = go.GetComponent<RectTransform>();
        rtComp.anchoredPosition = new Vector2(8.0f, -305.0f);
        rtComp.sizeDelta = new Vector2(604.0f, 604.0f);
        rtComp.pivot = new Vector2(0.5f, 0.0f);
        rtComp.anchorMin = new Vector2(0.5f, 0.5f);
        rtComp.anchorMax = new Vector2(0.5f, 0.5f);
        var img = go.GetComponent<Image>();
        img.raycastTarget = false;
        img.sprite = FindSprite("F2_EM_stand_0001");
        var animator = go.GetComponent<Animator>();
        animator.runtimeAnimatorController = ctrl;
        PrefabUtility.SaveAsPrefabAsset(go, "Assets/Prefabs/Imported/Avatars/F_EM.prefab");
        Object.DestroyImmediate(go);
    }

    static void Build_F_GB()
    {
        string avatarName = "F_GB";
        // Stand clip: F2_GB (32f, 30.0fps)
        var standClip = BuildClip("F2_GB", 30.0f, 1.066666603088379f, true, new string[] {
            "F2_GB_stand_0001",
            "F2_GB_stand_0002",
            "F2_GB_stand_0003",
            "F2_GB_stand_0004",
            "F2_GB_stand_0005",
            "F2_GB_stand_0006",
            "F2_GB_stand_0007",
            "F2_GB_stand_0008",
            "F2_GB_stand_0009",
            "F2_GB_stand_0010",
            "F2_GB_stand_0011",
            "F2_GB_stand_0012",
            "F2_GB_stand_0013",
            "F2_GB_stand_0014",
            "F2_GB_stand_0015",
            "F2_GB_stand_0016",
            "F2_GB_stand_0001",
            "F2_GB_stand_0002",
            "F2_GB_stand_0003",
            "F2_GB_stand_0004",
            "F2_GB_stand_0005",
            "F2_GB_stand_0006",
            "F2_GB_stand_0007",
            "F2_GB_stand_0008",
            "F2_GB_stand_0009",
            "F2_GB_stand_0010",
            "F2_GB_stand_0011",
            "F2_GB_stand_0012",
            "F2_GB_stand_0013",
            "F2_GB_stand_0014",
            "F2_GB_stand_0015",
            "F2_GB_stand_0016"
        });
        AssetDatabase.CreateAsset(standClip, "Assets/Animations/loginbg/F2_GB.anim");
        // Action clip: F2_GB_ACTION (41f, 30.0fps)
        var actionClip = BuildClip("F2_GB_ACTION", 30.0f, 1.3666666746139526f, false, new string[] {
            "F2_GB_action_0000",
            "F2_GB_action_0002",
            "F2_GB_action_0004",
            "F2_GB_action_0006",
            "F2_GB_action_0008",
            "F2_GB_action_0010",
            "F2_GB_action_0012",
            "F2_GB_action_0014",
            "F2_GB_action_0016",
            "F2_GB_action_0018",
            "F2_GB_action_0020",
            "F2_GB_action_0022",
            "F2_GB_action_0024",
            "F2_GB_action_0026",
            "F2_GB_action_0028",
            "F2_GB_action_0030",
            "F2_GB_action_0032",
            "F2_GB_action_0034",
            "F2_GB_action_0036",
            "F2_GB_action_0038",
            "F2_GB_action_0040",
            "F2_GB_action_0042",
            "F2_GB_action_0044",
            "F2_GB_action_0046",
            "F2_GB_action_0048",
            "F2_GB_action_0050",
            "F2_GB_action_0052",
            "F2_GB_action_0054",
            "F2_GB_action_0056",
            "F2_GB_action_0058",
            "F2_GB_action_0060",
            "F2_GB_action_0062",
            "F2_GB_action_0064",
            "F2_GB_action_0066",
            "F2_GB_action_0068",
            "F2_GB_action_0070",
            "F2_GB_action_0072",
            "F2_GB_action_0074",
            "F2_GB_action_0076",
            "F2_GB_action_0078",
            "F2_GB_action_0080"
        });
        AssetDatabase.CreateAsset(actionClip, "Assets/Animations/loginbg/F2_GB_ACTION.anim");
        // AnimatorController: F_GB
        var ctrl = AnimatorController.CreateAnimatorControllerAtPath("Assets/Animations/loginbg/F_GB.controller");
        ctrl.AddParameter("action", AnimatorControllerParameterType.Trigger);
        var rootSM = ctrl.layers[0].stateMachine;
        var standState = rootSM.AddState("stand");
        standState.motion = standClip;
        rootSM.defaultState = standState;
        var actionState = rootSM.AddState("action");
        actionState.motion = actionClip;
        // stand → action (trigger)
        var toAction = standState.AddTransition(actionState);
        toAction.AddCondition(AnimatorConditionMode.If, 0, "action");
        toAction.hasExitTime = false;
        toAction.duration = 0;
        // action → stand (exit time)
        var toStand = actionState.AddTransition(standState);
        toStand.hasExitTime = true;
        toStand.exitTime = 1f;
        toStand.duration = 0;
        // Prefab: F_GB
        var go = new GameObject("F_GB", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rtComp = go.GetComponent<RectTransform>();
        rtComp.anchoredPosition = new Vector2(224.0f, -274.0f);
        rtComp.sizeDelta = new Vector2(552.0f, 552.0f);
        rtComp.pivot = new Vector2(0.5f, 0.0f);
        rtComp.anchorMin = new Vector2(0.5f, 0.5f);
        rtComp.anchorMax = new Vector2(0.5f, 0.5f);
        var img = go.GetComponent<Image>();
        img.raycastTarget = false;
        img.sprite = FindSprite("F2_GB_stand_0001");
        var animator = go.GetComponent<Animator>();
        animator.runtimeAnimatorController = ctrl;
        PrefabUtility.SaveAsPrefabAsset(go, "Assets/Prefabs/Imported/Avatars/F_GB.prefab");
        Object.DestroyImmediate(go);
    }

    static void Build_F_GM()
    {
        string avatarName = "F_GM";
        // Stand clip: F2_GM (17f, 30.0fps)
        var standClip = BuildClip("F2_GM", 30.0f, 1.0333333015441895f, true, new string[] {
            "F2_GM_stand_0000",
            "F2_GM_stand_0001",
            "F2_GM_stand_0002",
            "F2_GM_stand_0003",
            "F2_GM_stand_0004",
            "F2_GM_stand_0005",
            "F2_GM_stand_0006",
            "F2_GM_stand_0007",
            "F2_GM_stand_0008",
            "F2_GM_stand_0009",
            "F2_GM_stand_0010",
            "F2_GM_stand_0011",
            "F2_GM_stand_0012",
            "F2_GM_stand_0013",
            "F2_GM_stand_0014",
            "F2_GM_stand_0015",
            "F2_GM_stand_0016"
        });
        AssetDatabase.CreateAsset(standClip, "Assets/Animations/loginbg/F2_GM.anim");
        // Action clip: F2_GM_ACTION (32f, 30.0fps)
        var actionClip = BuildClip("F2_GM_ACTION", 30.0f, 1.3666666746139526f, false, new string[] {
            "F2_GM_action_0000",
            "F2_GM_action_0002",
            "F2_GM_action_0004",
            "F2_GM_action_0006",
            "F2_GM_action_0008",
            "F2_GM_action_0010",
            "F2_GM_action_0012",
            "F2_GM_action_0014",
            "F2_GM_action_0016",
            "F2_GM_action_0018",
            "F2_GM_action_0020",
            "F2_GM_action_0022",
            "F2_GM_action_0024",
            "F2_GM_action_0026",
            "F2_GM_action_0028",
            "F2_GM_action_0030",
            "F2_GM_action_0032",
            "F2_GM_action_0034",
            "F2_GM_action_0036",
            "F2_GM_action_0038",
            "F2_GM_action_0040",
            "F2_GM_action_0042",
            "F2_GM_action_0044",
            "F2_GM_action_0046",
            "F2_GM_action_0048",
            "F2_GM_action_0050",
            "F2_GM_action_0052",
            "F2_GM_action_0054",
            "F2_GM_action_0056",
            "F2_GM_action_0058",
            "F2_GM_action_0060",
            "F2_GM_action_0062"
        });
        AssetDatabase.CreateAsset(actionClip, "Assets/Animations/loginbg/F2_GM_ACTION.anim");
        // AnimatorController: F_GM
        var ctrl = AnimatorController.CreateAnimatorControllerAtPath("Assets/Animations/loginbg/F_GM.controller");
        ctrl.AddParameter("action", AnimatorControllerParameterType.Trigger);
        var rootSM = ctrl.layers[0].stateMachine;
        var standState = rootSM.AddState("stand");
        standState.motion = standClip;
        rootSM.defaultState = standState;
        var actionState = rootSM.AddState("action");
        actionState.motion = actionClip;
        // stand → action (trigger)
        var toAction = standState.AddTransition(actionState);
        toAction.AddCondition(AnimatorConditionMode.If, 0, "action");
        toAction.hasExitTime = false;
        toAction.duration = 0;
        // action → stand (exit time)
        var toStand = actionState.AddTransition(standState);
        toStand.hasExitTime = true;
        toStand.exitTime = 1f;
        toStand.duration = 0;
        // Prefab: F_GM
        var go = new GameObject("F_GM", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rtComp = go.GetComponent<RectTransform>();
        rtComp.anchoredPosition = new Vector2(214.0f, -278.0f);
        rtComp.sizeDelta = new Vector2(512.0f, 512.0f);
        rtComp.pivot = new Vector2(0.5f, 0.0f);
        rtComp.anchorMin = new Vector2(0.5f, 0.5f);
        rtComp.anchorMax = new Vector2(0.5f, 0.5f);
        var img = go.GetComponent<Image>();
        img.raycastTarget = false;
        img.sprite = FindSprite("F2_GM_stand_0000");
        var animator = go.GetComponent<Animator>();
        animator.runtimeAnimatorController = ctrl;
        PrefabUtility.SaveAsPrefabAsset(go, "Assets/Prefabs/Imported/Avatars/F_GM.prefab");
        Object.DestroyImmediate(go);
    }

    static void Build_F_KL()
    {
        string avatarName = "F_KL";
        // Stand clip: F2_KL (32f, 30.0fps)
        var standClip = BuildClip("F2_KL", 30.0f, 1.066666603088379f, true, new string[] {
            "F2_KL_stand_0001",
            "F2_KL_stand_0002",
            "F2_KL_stand_0003",
            "F2_KL_stand_0004",
            "F2_KL_stand_0005",
            "F2_KL_stand_0006",
            "F2_KL_stand_0007",
            "F2_KL_stand_0008",
            "F2_KL_stand_0009",
            "F2_KL_stand_0010",
            "F2_KL_stand_0011",
            "F2_KL_stand_0012",
            "F2_KL_stand_0013",
            "F2_KL_stand_0014",
            "F2_KL_stand_0015",
            "F2_KL_stand_0016",
            "F2_KL_stand_0001",
            "F2_KL_stand_0002",
            "F2_KL_stand_0003",
            "F2_KL_stand_0004",
            "F2_KL_stand_0005",
            "F2_KL_stand_0006",
            "F2_KL_stand_0007",
            "F2_KL_stand_0008",
            "F2_KL_stand_0009",
            "F2_KL_stand_0010",
            "F2_KL_stand_0011",
            "F2_KL_stand_0012",
            "F2_KL_stand_0013",
            "F2_KL_stand_0014",
            "F2_KL_stand_0015",
            "F2_KL_stand_0016"
        });
        AssetDatabase.CreateAsset(standClip, "Assets/Animations/loginbg/F2_KL.anim");
        // Action clip: F2_KL_ACTION (29f, 30.0fps)
        var actionClip = BuildClip("F2_KL_ACTION", 30.0f, 1.2666666507720947f, false, new string[] {
            "F2_KL_action_0001",
            "F2_KL_action_0003",
            "F2_KL_action_0005",
            "F2_KL_action_0007",
            "F2_KL_action_0009",
            "F2_KL_action_0011",
            "F2_KL_action_0013",
            "F2_KL_action_0015",
            "F2_KL_action_0017",
            "F2_KL_action_0019",
            "F2_KL_action_0021",
            "F2_KL_action_0023",
            "F2_KL_action_0025",
            "F2_KL_action_0027",
            "F2_KL_action_0029",
            "F2_KL_action_0031",
            "F2_KL_action_0033",
            "F2_KL_action_0035",
            "F2_KL_action_0037",
            "F2_KL_action_0039",
            "F2_KL_action_0041",
            "F2_KL_action_0043",
            "F2_KL_action_0045",
            "F2_KL_action_0047",
            "F2_KL_action_0049",
            "F2_KL_action_0051",
            "F2_KL_action_0053",
            "F2_KL_action_0055",
            "F2_KL_action_0057"
        });
        AssetDatabase.CreateAsset(actionClip, "Assets/Animations/loginbg/F2_KL_ACTION.anim");
        // AnimatorController: F_KL
        var ctrl = AnimatorController.CreateAnimatorControllerAtPath("Assets/Animations/loginbg/F_KL.controller");
        ctrl.AddParameter("action", AnimatorControllerParameterType.Trigger);
        var rootSM = ctrl.layers[0].stateMachine;
        var standState = rootSM.AddState("stand");
        standState.motion = standClip;
        rootSM.defaultState = standState;
        var actionState = rootSM.AddState("action");
        actionState.motion = actionClip;
        // stand → action (trigger)
        var toAction = standState.AddTransition(actionState);
        toAction.AddCondition(AnimatorConditionMode.If, 0, "action");
        toAction.hasExitTime = false;
        toAction.duration = 0;
        // action → stand (exit time)
        var toStand = actionState.AddTransition(standState);
        toStand.hasExitTime = true;
        toStand.exitTime = 1f;
        toStand.duration = 0;
        // Prefab: F_KL
        var go = new GameObject("F_KL", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rtComp = go.GetComponent<RectTransform>();
        rtComp.anchoredPosition = new Vector2(179.0f, -274.0f);
        rtComp.sizeDelta = new Vector2(384.0f, 512.0f);
        rtComp.pivot = new Vector2(0.5f, 0.0f);
        rtComp.anchorMin = new Vector2(0.5f, 0.5f);
        rtComp.anchorMax = new Vector2(0.5f, 0.5f);
        var img = go.GetComponent<Image>();
        img.raycastTarget = false;
        img.sprite = FindSprite("F2_KL_stand_0001");
        var animator = go.GetComponent<Animator>();
        animator.runtimeAnimatorController = ctrl;
        PrefabUtility.SaveAsPrefabAsset(go, "Assets/Prefabs/Imported/Avatars/F_KL.prefab");
        Object.DestroyImmediate(go);
    }

    static void Build_F_MJ()
    {
        string avatarName = "F_MJ";
        // Stand clip: F2_MJ (32f, 30.0fps)
        var standClip = BuildClip("F2_MJ", 30.0f, 1.066666603088379f, true, new string[] {
            "F2_MJ_stand_0001",
            "F2_MJ_stand_0002",
            "F2_MJ_stand_0003",
            "F2_MJ_stand_0004",
            "F2_MJ_stand_0005",
            "F2_MJ_stand_0006",
            "F2_MJ_stand_0007",
            "F2_MJ_stand_0008",
            "F2_MJ_stand_0009",
            "F2_MJ_stand_0010",
            "F2_MJ_stand_0011",
            "F2_MJ_stand_0012",
            "F2_MJ_stand_0013",
            "F2_MJ_stand_0014",
            "F2_MJ_stand_0015",
            "F2_MJ_stand_0016",
            "F2_MJ_stand_0001",
            "F2_MJ_stand_0002",
            "F2_MJ_stand_0003",
            "F2_MJ_stand_0004",
            "F2_MJ_stand_0005",
            "F2_MJ_stand_0006",
            "F2_MJ_stand_0007",
            "F2_MJ_stand_0008",
            "F2_MJ_stand_0009",
            "F2_MJ_stand_0010",
            "F2_MJ_stand_0011",
            "F2_MJ_stand_0012",
            "F2_MJ_stand_0013",
            "F2_MJ_stand_0014",
            "F2_MJ_stand_0015",
            "F2_MJ_stand_0016"
        });
        AssetDatabase.CreateAsset(standClip, "Assets/Animations/loginbg/F2_MJ.anim");
        // Action clip: F2_MJ_ACTION (31f, 30.0fps)
        var actionClip = BuildClip("F2_MJ_ACTION", 30.0f, 1.100000023841858f, false, new string[] {
            "F2_MJ_action_0001",
            "F2_MJ_action_0003",
            "F2_MJ_action_0005",
            "F2_MJ_action_0007",
            "F2_MJ_action_0009",
            "F2_MJ_action_0011",
            "F2_MJ_action_0013",
            "F2_MJ_action_0015",
            "F2_MJ_action_0017",
            "F2_MJ_action_0019",
            "F2_MJ_action_0021",
            "F2_MJ_action_0023",
            "F2_MJ_action_0025",
            "F2_MJ_action_0027",
            "F2_MJ_action_0029",
            "F2_MJ_action_0031",
            "F2_MJ_action_0033",
            "F2_MJ_action_0035",
            "F2_MJ_action_0037",
            "F2_MJ_action_0039",
            "F2_MJ_action_0041",
            "F2_MJ_action_0043",
            "F2_MJ_action_0045",
            "F2_MJ_action_0047",
            "F2_MJ_action_0049",
            "F2_MJ_action_0051",
            "F2_MJ_action_0053",
            "F2_MJ_action_0055",
            "F2_MJ_action_0057",
            "F2_MJ_action_0059",
            "F2_MJ_action_0061"
        });
        AssetDatabase.CreateAsset(actionClip, "Assets/Animations/loginbg/F2_MJ_ACTION.anim");
        // AnimatorController: F_MJ
        var ctrl = AnimatorController.CreateAnimatorControllerAtPath("Assets/Animations/loginbg/F_MJ.controller");
        ctrl.AddParameter("action", AnimatorControllerParameterType.Trigger);
        var rootSM = ctrl.layers[0].stateMachine;
        var standState = rootSM.AddState("stand");
        standState.motion = standClip;
        rootSM.defaultState = standState;
        var actionState = rootSM.AddState("action");
        actionState.motion = actionClip;
        // stand → action (trigger)
        var toAction = standState.AddTransition(actionState);
        toAction.AddCondition(AnimatorConditionMode.If, 0, "action");
        toAction.hasExitTime = false;
        toAction.duration = 0;
        // action → stand (exit time)
        var toStand = actionState.AddTransition(standState);
        toStand.hasExitTime = true;
        toStand.exitTime = 1f;
        toStand.duration = 0;
        // Prefab: F_MJ
        var go = new GameObject("F_MJ", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rtComp = go.GetComponent<RectTransform>();
        rtComp.anchoredPosition = new Vector2(183.0f, -258.00018310546875f);
        rtComp.sizeDelta = new Vector2(563.0f, 563.0f);
        rtComp.pivot = new Vector2(0.5f, 0.0f);
        rtComp.anchorMin = new Vector2(0.5f, 0.5f);
        rtComp.anchorMax = new Vector2(0.5f, 0.5f);
        var img = go.GetComponent<Image>();
        img.raycastTarget = false;
        img.sprite = FindSprite("F2_MJ_stand_0001");
        var animator = go.GetComponent<Animator>();
        animator.runtimeAnimatorController = ctrl;
        PrefabUtility.SaveAsPrefabAsset(go, "Assets/Prefabs/Imported/Avatars/F_MJ.prefab");
        Object.DestroyImmediate(go);
    }

    static void Build_F_THD()
    {
        string avatarName = "F_THD";
        // Stand clip: F2_THD (16f, 30.0fps)
        var standClip = BuildClip("F2_THD", 30.0f, 0.5333333611488342f, true, new string[] {
            "F2_THD_stand_0001",
            "F2_THD_stand_0002",
            "F2_THD_stand_0003",
            "F2_THD_stand_0004",
            "F2_THD_stand_0005",
            "F2_THD_stand_0006",
            "F2_THD_stand_0007",
            "F2_THD_stand_0008",
            "F2_THD_stand_0009",
            "F2_THD_stand_0010",
            "F2_THD_stand_0011",
            "F2_THD_stand_0012",
            "F2_THD_stand_0013",
            "F2_THD_stand_0014",
            "F2_THD_stand_0015",
            "F2_THD_stand_0016"
        });
        AssetDatabase.CreateAsset(standClip, "Assets/Animations/loginbg/F2_THD.anim");
        // Action clip: F2_THD_ACTION (35f, 30.0fps)
        var actionClip = BuildClip("F2_THD_ACTION", 30.0f, 1.1666666269302368f, false, new string[] {
            "F2_THD_action_0001",
            "F2_THD_action_0003",
            "F2_THD_action_0005",
            "F2_THD_action_0007",
            "F2_THD_action_0009",
            "F2_THD_action_0011",
            "F2_THD_action_0013",
            "F2_THD_action_0015",
            "F2_THD_action_0017",
            "F2_THD_action_0019",
            "F2_THD_action_0021",
            "F2_THD_action_0023",
            "F2_THD_action_0025",
            "F2_THD_action_0027",
            "F2_THD_action_0029",
            "F2_THD_action_0031",
            "F2_THD_action_0033",
            "F2_THD_action_0035",
            "F2_THD_action_0037",
            "F2_THD_action_0039",
            "F2_THD_action_0041",
            "F2_THD_action_0043",
            "F2_THD_action_0045",
            "F2_THD_action_0047",
            "F2_THD_action_0049",
            "F2_THD_action_0051",
            "F2_THD_action_0053",
            "F2_THD_action_0055",
            "F2_THD_action_0057",
            "F2_THD_action_0059",
            "F2_THD_action_0061",
            "F2_THD_action_0061",
            "F2_THD_action_0061",
            "F2_THD_action_0061",
            "F2_THD_action_0061"
        });
        AssetDatabase.CreateAsset(actionClip, "Assets/Animations/loginbg/F2_THD_ACTION.anim");
        // AnimatorController: F_THD
        var ctrl = AnimatorController.CreateAnimatorControllerAtPath("Assets/Animations/loginbg/F_THD.controller");
        ctrl.AddParameter("action", AnimatorControllerParameterType.Trigger);
        var rootSM = ctrl.layers[0].stateMachine;
        var standState = rootSM.AddState("stand");
        standState.motion = standClip;
        rootSM.defaultState = standState;
        var actionState = rootSM.AddState("action");
        actionState.motion = actionClip;
        // stand → action (trigger)
        var toAction = standState.AddTransition(actionState);
        toAction.AddCondition(AnimatorConditionMode.If, 0, "action");
        toAction.hasExitTime = false;
        toAction.duration = 0;
        // action → stand (exit time)
        var toStand = actionState.AddTransition(standState);
        toStand.hasExitTime = true;
        toStand.exitTime = 1f;
        toStand.duration = 0;
        // Prefab: F_THD
        var go = new GameObject("F_THD", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rtComp = go.GetComponent<RectTransform>();
        rtComp.anchoredPosition = new Vector2(191.5f, -275.0f);
        rtComp.sizeDelta = new Vector2(575.0f, 628.0f);
        rtComp.pivot = new Vector2(0.5400000214576721f, 0.0f);
        rtComp.anchorMin = new Vector2(0.5f, 0.5f);
        rtComp.anchorMax = new Vector2(0.5f, 0.5f);
        var img = go.GetComponent<Image>();
        img.raycastTarget = false;
        img.sprite = FindSprite("F2_THD_stand_0001");
        var animator = go.GetComponent<Animator>();
        animator.runtimeAnimatorController = ctrl;
        PrefabUtility.SaveAsPrefabAsset(go, "Assets/Prefabs/Imported/Avatars/F_THD.prefab");
        Object.DestroyImmediate(go);
    }

    static void Build_F_TM()
    {
        string avatarName = "F_TM";
        // Stand clip: F2_TM (32f, 30.0fps)
        var standClip = BuildClip("F2_TM", 30.0f, 1.066666603088379f, true, new string[] {
            "F2_TM_stand_0001",
            "F2_TM_stand_0002",
            "F2_TM_stand_0003",
            "F2_TM_stand_0004",
            "F2_TM_stand_0005",
            "F2_TM_stand_0006",
            "F2_TM_stand_0007",
            "F2_TM_stand_0008",
            "F2_TM_stand_0009",
            "F2_TM_stand_0010",
            "F2_TM_stand_0011",
            "F2_TM_stand_0012",
            "F2_TM_stand_0013",
            "F2_TM_stand_0014",
            "F2_TM_stand_0015",
            "F2_TM_stand_0016",
            "F2_TM_stand_0001",
            "F2_TM_stand_0002",
            "F2_TM_stand_0003",
            "F2_TM_stand_0004",
            "F2_TM_stand_0005",
            "F2_TM_stand_0006",
            "F2_TM_stand_0007",
            "F2_TM_stand_0008",
            "F2_TM_stand_0009",
            "F2_TM_stand_0010",
            "F2_TM_stand_0011",
            "F2_TM_stand_0012",
            "F2_TM_stand_0013",
            "F2_TM_stand_0014",
            "F2_TM_stand_0015",
            "F2_TM_stand_0016"
        });
        AssetDatabase.CreateAsset(standClip, "Assets/Animations/loginbg/F2_TM.anim");
        // Action clip: F2_TM_ACTION (33f, 30.0fps)
        var actionClip = BuildClip("F2_TM_ACTION", 30.0f, 1.2666666507720947f, false, new string[] {
            "F2_TM_action_0000",
            "F2_TM_action_0002",
            "F2_TM_action_0004",
            "F2_TM_action_0006",
            "F2_TM_action_0008",
            "F2_TM_action_0010",
            "F2_TM_action_0012",
            "F2_TM_action_0014",
            "F2_TM_action_0016",
            "F2_TM_action_0018",
            "F2_TM_action_0020",
            "F2_TM_action_0022",
            "F2_TM_action_0024",
            "F2_TM_action_0026",
            "F2_TM_action_0028",
            "F2_TM_action_0030",
            "F2_TM_action_0032",
            "F2_TM_action_0034",
            "F2_TM_action_0036",
            "F2_TM_action_0038",
            "F2_TM_action_0040",
            "F2_TM_action_0042",
            "F2_TM_action_0044",
            "F2_TM_action_0046",
            "F2_TM_action_0048",
            "F2_TM_action_0050",
            "F2_TM_action_0052",
            "F2_TM_action_0054",
            "F2_TM_action_0056",
            "F2_TM_action_0058",
            "F2_TM_action_0060",
            "F2_TM_action_0062",
            "F2_TM_action_0064"
        });
        AssetDatabase.CreateAsset(actionClip, "Assets/Animations/loginbg/F2_TM_ACTION.anim");
        // AnimatorController: F_TM
        var ctrl = AnimatorController.CreateAnimatorControllerAtPath("Assets/Animations/loginbg/F_TM.controller");
        ctrl.AddParameter("action", AnimatorControllerParameterType.Trigger);
        var rootSM = ctrl.layers[0].stateMachine;
        var standState = rootSM.AddState("stand");
        standState.motion = standClip;
        rootSM.defaultState = standState;
        var actionState = rootSM.AddState("action");
        actionState.motion = actionClip;
        // stand → action (trigger)
        var toAction = standState.AddTransition(actionState);
        toAction.AddCondition(AnimatorConditionMode.If, 0, "action");
        toAction.hasExitTime = false;
        toAction.duration = 0;
        // action → stand (exit time)
        var toStand = actionState.AddTransition(standState);
        toStand.hasExitTime = true;
        toStand.exitTime = 1f;
        toStand.duration = 0;
        // Prefab: F_TM
        var go = new GameObject("F_TM", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rtComp = go.GetComponent<RectTransform>();
        rtComp.anchoredPosition = new Vector2(162.0f, -268.0f);
        rtComp.sizeDelta = new Vector2(384.0f, 512.0f);
        rtComp.pivot = new Vector2(0.5f, 0.0f);
        rtComp.anchorMin = new Vector2(0.5f, 0.5f);
        rtComp.anchorMax = new Vector2(0.5f, 0.5f);
        var img = go.GetComponent<Image>();
        img.raycastTarget = false;
        img.sprite = FindSprite("F2_TM_stand_0001");
        var animator = go.GetComponent<Animator>();
        animator.runtimeAnimatorController = ctrl;
        PrefabUtility.SaveAsPrefabAsset(go, "Assets/Prefabs/Imported/Avatars/F_TM.prefab");
        Object.DestroyImmediate(go);
    }

    static void Build_F_TR()
    {
        string avatarName = "F_TR";
        // Stand clip: F2_TR (32f, 30.0fps)
        var standClip = BuildClip("F2_TR", 30.0f, 1.066666603088379f, true, new string[] {
            "F2_TR_stand_0001",
            "F2_TR_stand_0002",
            "F2_TR_stand_0003",
            "F2_TR_stand_0004",
            "F2_TR_stand_0005",
            "F2_TR_stand_0006",
            "F2_TR_stand_0007",
            "F2_TR_stand_0008",
            "F2_TR_stand_0009",
            "F2_TR_stand_0010",
            "F2_TR_stand_0011",
            "F2_TR_stand_0012",
            "F2_TR_stand_0013",
            "F2_TR_stand_0014",
            "F2_TR_stand_0015",
            "F2_TR_stand_0016",
            "F2_TR_stand_0001",
            "F2_TR_stand_0002",
            "F2_TR_stand_0003",
            "F2_TR_stand_0004",
            "F2_TR_stand_0005",
            "F2_TR_stand_0006",
            "F2_TR_stand_0007",
            "F2_TR_stand_0008",
            "F2_TR_stand_0009",
            "F2_TR_stand_0010",
            "F2_TR_stand_0011",
            "F2_TR_stand_0012",
            "F2_TR_stand_0013",
            "F2_TR_stand_0014",
            "F2_TR_stand_0015",
            "F2_TR_stand_0016"
        });
        AssetDatabase.CreateAsset(standClip, "Assets/Animations/loginbg/F2_TR.anim");
        // Action clip: F2_TR_ACTION (33f, 30.0fps)
        var actionClip = BuildClip("F2_TR_ACTION", 30.0f, 1.1999999284744263f, false, new string[] {
            "F2_TR_action_0001",
            "F2_TR_action_0003",
            "F2_TR_action_0005",
            "F2_TR_action_0007",
            "F2_TR_action_0009",
            "F2_TR_action_0011",
            "F2_TR_action_0013",
            "F2_TR_action_0015",
            "F2_TR_action_0017",
            "F2_TR_action_0019",
            "F2_TR_action_0021",
            "F2_TR_action_0023",
            "F2_TR_action_0025",
            "F2_TR_action_0027",
            "F2_TR_action_0029",
            "F2_TR_action_0031",
            "F2_TR_action_0033",
            "F2_TR_action_0035",
            "F2_TR_action_0037",
            "F2_TR_action_0039",
            "F2_TR_action_0041",
            "F2_TR_action_0043",
            "F2_TR_action_0045",
            "F2_TR_action_0047",
            "F2_TR_action_0049",
            "F2_TR_action_0051",
            "F2_TR_action_0053",
            "F2_TR_action_0055",
            "F2_TR_action_0057",
            "F2_TR_action_0059",
            "F2_TR_action_0061",
            "F2_TR_action_0063",
            "F2_TR_action_0065"
        });
        AssetDatabase.CreateAsset(actionClip, "Assets/Animations/loginbg/F2_TR_ACTION.anim");
        // AnimatorController: F_TR
        var ctrl = AnimatorController.CreateAnimatorControllerAtPath("Assets/Animations/loginbg/F_TR.controller");
        ctrl.AddParameter("action", AnimatorControllerParameterType.Trigger);
        var rootSM = ctrl.layers[0].stateMachine;
        var standState = rootSM.AddState("stand");
        standState.motion = standClip;
        rootSM.defaultState = standState;
        var actionState = rootSM.AddState("action");
        actionState.motion = actionClip;
        // stand → action (trigger)
        var toAction = standState.AddTransition(actionState);
        toAction.AddCondition(AnimatorConditionMode.If, 0, "action");
        toAction.hasExitTime = false;
        toAction.duration = 0;
        // action → stand (exit time)
        var toStand = actionState.AddTransition(standState);
        toStand.hasExitTime = true;
        toStand.exitTime = 1f;
        toStand.duration = 0;
        // Prefab: F_TR
        var go = new GameObject("F_TR", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rtComp = go.GetComponent<RectTransform>();
        rtComp.anchoredPosition = new Vector2(199.0f, -283.0f);
        rtComp.sizeDelta = new Vector2(552.0f, 552.0f);
        rtComp.pivot = new Vector2(0.5f, 0.0f);
        rtComp.anchorMin = new Vector2(0.5f, 0.5f);
        rtComp.anchorMax = new Vector2(0.5f, 0.5f);
        var img = go.GetComponent<Image>();
        img.raycastTarget = false;
        img.sprite = FindSprite("F2_TR_stand_0001");
        var animator = go.GetComponent<Animator>();
        animator.runtimeAnimatorController = ctrl;
        PrefabUtility.SaveAsPrefabAsset(go, "Assets/Prefabs/Imported/Avatars/F_TR.prefab");
        Object.DestroyImmediate(go);
    }

    static void Build_F_TW()
    {
        string avatarName = "F_TW";
        // Stand clip: F2_TW (32f, 30.0fps)
        var standClip = BuildClip("F2_TW", 30.0f, 1.066666603088379f, true, new string[] {
            "F2_TW_stand_0001",
            "F2_TW_stand_0002",
            "F2_TW_stand_0003",
            "F2_TW_stand_0004",
            "F2_TW_stand_0005",
            "F2_TW_stand_0006",
            "F2_TW_stand_0007",
            "F2_TW_stand_0008",
            "F2_TW_stand_0009",
            "F2_TW_stand_0010",
            "F2_TW_stand_0011",
            "F2_TW_stand_0012",
            "F2_TW_stand_0013",
            "F2_TW_stand_0014",
            "F2_TW_stand_0015",
            "F2_TW_stand_0016",
            "F2_TW_stand_0001",
            "F2_TW_stand_0002",
            "F2_TW_stand_0003",
            "F2_TW_stand_0004",
            "F2_TW_stand_0005",
            "F2_TW_stand_0006",
            "F2_TW_stand_0007",
            "F2_TW_stand_0008",
            "F2_TW_stand_0009",
            "F2_TW_stand_0010",
            "F2_TW_stand_0011",
            "F2_TW_stand_0012",
            "F2_TW_stand_0013",
            "F2_TW_stand_0014",
            "F2_TW_stand_0015",
            "F2_TW_stand_0016"
        });
        AssetDatabase.CreateAsset(standClip, "Assets/Animations/loginbg/F2_TW.anim");
        // Action clip: F2_TW_action (31f, 24.0fps)
        var actionClip = BuildClip("F2_TW_action", 24.0f, 1.3333332538604736f, false, new string[] {
            "F2_TW_action_0001",
            "F2_TW_action_0003",
            "F2_TW_action_0005",
            "F2_TW_action_0007",
            "F2_TW_action_0009",
            "F2_TW_action_0011",
            "F2_TW_action_0013",
            "F2_TW_action_0015",
            "F2_TW_action_0017",
            "F2_TW_action_0019",
            "F2_TW_action_0021",
            "F2_TW_action_0023",
            "F2_TW_action_0025",
            "F2_TW_action_0027",
            "F2_TW_action_0029",
            "F2_TW_action_0031",
            "F2_TW_action_0033",
            "F2_TW_action_0035",
            "F2_TW_action_0037",
            "F2_TW_action_0039",
            "F2_TW_action_0041",
            "F2_TW_action_0043",
            "F2_TW_action_0045",
            "F2_TW_action_0047",
            "F2_TW_action_0049",
            "F2_TW_action_0051",
            "F2_TW_action_0053",
            "F2_TW_action_0055",
            "F2_TW_action_0057",
            "F2_TW_action_0059",
            "F2_TW_action_0061"
        });
        AssetDatabase.CreateAsset(actionClip, "Assets/Animations/loginbg/F2_TW_action.anim");
        // AnimatorController: F_TW
        var ctrl = AnimatorController.CreateAnimatorControllerAtPath("Assets/Animations/loginbg/F_TW.controller");
        ctrl.AddParameter("action", AnimatorControllerParameterType.Trigger);
        var rootSM = ctrl.layers[0].stateMachine;
        var standState = rootSM.AddState("stand");
        standState.motion = standClip;
        rootSM.defaultState = standState;
        var actionState = rootSM.AddState("action");
        actionState.motion = actionClip;
        // stand → action (trigger)
        var toAction = standState.AddTransition(actionState);
        toAction.AddCondition(AnimatorConditionMode.If, 0, "action");
        toAction.hasExitTime = false;
        toAction.duration = 0;
        // action → stand (exit time)
        var toStand = actionState.AddTransition(standState);
        toStand.hasExitTime = true;
        toStand.exitTime = 1f;
        toStand.duration = 0;
        // Prefab: F_TW
        var go = new GameObject("F_TW", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rtComp = go.GetComponent<RectTransform>();
        rtComp.anchoredPosition = new Vector2(254.0f, -325.4999694824219f);
        rtComp.sizeDelta = new Vector2(665.0f, 585.0f);
        rtComp.pivot = new Vector2(0.5f, 0.0f);
        rtComp.anchorMin = new Vector2(0.5f, 0.5f);
        rtComp.anchorMax = new Vector2(0.5f, 0.5f);
        var img = go.GetComponent<Image>();
        img.raycastTarget = false;
        img.sprite = FindSprite("F2_TW_stand_0001");
        var animator = go.GetComponent<Animator>();
        animator.runtimeAnimatorController = ctrl;
        PrefabUtility.SaveAsPrefabAsset(go, "Assets/Prefabs/Imported/Avatars/F_TW.prefab");
        Object.DestroyImmediate(go);
    }

    static void Build_F_WD()
    {
        string avatarName = "F_WD";
        // Stand clip: F2_WD (32f, 30.0fps)
        var standClip = BuildClip("F2_WD", 30.0f, 1.066666603088379f, true, new string[] {
            "F2_WD_stand_0001",
            "F2_WD_stand_0002",
            "F2_WD_stand_0003",
            "F2_WD_stand_0004",
            "F2_WD_stand_0005",
            "F2_WD_stand_0006",
            "F2_WD_stand_0007",
            "F2_WD_stand_0008",
            "F2_WD_stand_0009",
            "F2_WD_stand_0010",
            "F2_WD_stand_0011",
            "F2_WD_stand_0012",
            "F2_WD_stand_0013",
            "F2_WD_stand_0014",
            "F2_WD_stand_0015",
            "F2_WD_stand_0016",
            "F2_WD_stand_0001",
            "F2_WD_stand_0002",
            "F2_WD_stand_0003",
            "F2_WD_stand_0004",
            "F2_WD_stand_0005",
            "F2_WD_stand_0006",
            "F2_WD_stand_0007",
            "F2_WD_stand_0008",
            "F2_WD_stand_0009",
            "F2_WD_stand_0010",
            "F2_WD_stand_0011",
            "F2_WD_stand_0012",
            "F2_WD_stand_0013",
            "F2_WD_stand_0014",
            "F2_WD_stand_0015",
            "F2_WD_stand_0016"
        });
        AssetDatabase.CreateAsset(standClip, "Assets/Animations/loginbg/F2_WD.anim");
        // Action clip: F2_WD_ACTION (31f, 30.0fps)
        var actionClip = BuildClip("F2_WD_ACTION", 30.0f, 1.0333333015441895f, false, new string[] {
            "F2_WD_ACTION_0001",
            "F2_WD_ACTION_0003",
            "F2_WD_ACTION_0005",
            "F2_WD_ACTION_0007",
            "F2_WD_ACTION_0009",
            "F2_WD_ACTION_0011",
            "F2_WD_ACTION_0013",
            "F2_WD_ACTION_0015",
            "F2_WD_ACTION_0017",
            "F2_WD_ACTION_0019",
            "F2_WD_ACTION_0021",
            "F2_WD_ACTION_0023",
            "F2_WD_ACTION_0025",
            "F2_WD_ACTION_0027",
            "F2_WD_ACTION_0029",
            "F2_WD_ACTION_0031",
            "F2_WD_ACTION_0033",
            "F2_WD_ACTION_0035",
            "F2_WD_ACTION_0037",
            "F2_WD_ACTION_0039",
            "F2_WD_ACTION_0041",
            "F2_WD_ACTION_0043",
            "F2_WD_ACTION_0045",
            "F2_WD_ACTION_0047",
            "F2_WD_ACTION_0049",
            "F2_WD_ACTION_0051",
            "F2_WD_ACTION_0053",
            "F2_WD_ACTION_0055",
            "F2_WD_ACTION_0057",
            "F2_WD_ACTION_0059",
            "F2_WD_ACTION_0061"
        });
        AssetDatabase.CreateAsset(actionClip, "Assets/Animations/loginbg/F2_WD_ACTION.anim");
        // AnimatorController: F_WD
        var ctrl = AnimatorController.CreateAnimatorControllerAtPath("Assets/Animations/loginbg/F_WD.controller");
        ctrl.AddParameter("action", AnimatorControllerParameterType.Trigger);
        var rootSM = ctrl.layers[0].stateMachine;
        var standState = rootSM.AddState("stand");
        standState.motion = standClip;
        rootSM.defaultState = standState;
        var actionState = rootSM.AddState("action");
        actionState.motion = actionClip;
        // stand → action (trigger)
        var toAction = standState.AddTransition(actionState);
        toAction.AddCondition(AnimatorConditionMode.If, 0, "action");
        toAction.hasExitTime = false;
        toAction.duration = 0;
        // action → stand (exit time)
        var toStand = actionState.AddTransition(standState);
        toStand.hasExitTime = true;
        toStand.exitTime = 1f;
        toStand.duration = 0;
        // Prefab: F_WD
        var go = new GameObject("F_WD", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rtComp = go.GetComponent<RectTransform>();
        rtComp.anchoredPosition = new Vector2(199.0f, -283.0f);
        rtComp.sizeDelta = new Vector2(513.0f, 583.0f);
        rtComp.pivot = new Vector2(0.5f, 0.0f);
        rtComp.anchorMin = new Vector2(0.5f, 0.5f);
        rtComp.anchorMax = new Vector2(0.5f, 0.5f);
        var img = go.GetComponent<Image>();
        img.raycastTarget = false;
        img.sprite = FindSprite("F2_WD_stand_0001");
        var animator = go.GetComponent<Animator>();
        animator.runtimeAnimatorController = ctrl;
        PrefabUtility.SaveAsPrefabAsset(go, "Assets/Prefabs/Imported/Avatars/F_WD.prefab");
        Object.DestroyImmediate(go);
    }

    static void Build_F_WHT()
    {
        string avatarName = "F_WHT";
        // Stand clip: F2_WHT (16f, 30.0fps)
        var standClip = BuildClip("F2_WHT", 30.0f, 0.5333333611488342f, true, new string[] {
            "F2_WHT_stand_0001",
            "F2_WHT_stand_0002",
            "F2_WHT_stand_0003",
            "F2_WHT_stand_0004",
            "F2_WHT_stand_0005",
            "F2_WHT_stand_0006",
            "F2_WHT_stand_0007",
            "F2_WHT_stand_0008",
            "F2_WHT_stand_0009",
            "F2_WHT_stand_0010",
            "F2_WHT_stand_0011",
            "F2_WHT_stand_0012",
            "F2_WHT_stand_0013",
            "F2_WHT_stand_0014",
            "F2_WHT_stand_0015",
            "F2_WHT_stand_0016"
        });
        AssetDatabase.CreateAsset(standClip, "Assets/Animations/loginbg/F2_WHT.anim");
        // Action clip: F2_WHT_ACTION (31f, 30.0fps)
        var actionClip = BuildClip("F2_WHT_ACTION", 30.0f, 1.0333333015441895f, false, new string[] {
            "F2_WHT_action_0001",
            "F2_WHT_action_0002",
            "F2_WHT_action_0003",
            "F2_WHT_action_0004",
            "F2_WHT_action_0005",
            "F2_WHT_action_0006",
            "F2_WHT_action_0007",
            "F2_WHT_action_0008",
            "F2_WHT_action_0009",
            "F2_WHT_action_0010",
            "F2_WHT_action_0011",
            "F2_WHT_action_0012",
            "F2_WHT_action_0013",
            "F2_WHT_action_0014",
            "F2_WHT_action_0015",
            "F2_WHT_action_0016",
            "F2_WHT_action_0017",
            "F2_WHT_action_0018",
            "F2_WHT_action_0019",
            "F2_WHT_action_0020",
            "F2_WHT_action_0021",
            "F2_WHT_action_0022",
            "F2_WHT_action_0023",
            "F2_WHT_action_0024",
            "F2_WHT_action_0025",
            "F2_WHT_action_0026",
            "F2_WHT_action_0027",
            "F2_WHT_action_0028",
            "F2_WHT_action_0029",
            "F2_WHT_action_0030",
            "F2_WHT_action_0031"
        });
        AssetDatabase.CreateAsset(actionClip, "Assets/Animations/loginbg/F2_WHT_ACTION.anim");
        // AnimatorController: F_WHT
        var ctrl = AnimatorController.CreateAnimatorControllerAtPath("Assets/Animations/loginbg/F_WHT.controller");
        ctrl.AddParameter("action", AnimatorControllerParameterType.Trigger);
        var rootSM = ctrl.layers[0].stateMachine;
        var standState = rootSM.AddState("stand");
        standState.motion = standClip;
        rootSM.defaultState = standState;
        var actionState = rootSM.AddState("action");
        actionState.motion = actionClip;
        // stand → action (trigger)
        var toAction = standState.AddTransition(actionState);
        toAction.AddCondition(AnimatorConditionMode.If, 0, "action");
        toAction.hasExitTime = false;
        toAction.duration = 0;
        // action → stand (exit time)
        var toStand = actionState.AddTransition(standState);
        toStand.hasExitTime = true;
        toStand.exitTime = 1f;
        toStand.duration = 0;
        // Prefab: F_WHT
        var go = new GameObject("F_WHT", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rtComp = go.GetComponent<RectTransform>();
        rtComp.anchoredPosition = new Vector2(180.0f, -240.0f);
        rtComp.sizeDelta = new Vector2(582.0f, 656.0f);
        rtComp.pivot = new Vector2(0.5899999737739563f, 0.10000000149011612f);
        rtComp.anchorMin = new Vector2(0.5f, 0.5f);
        rtComp.anchorMax = new Vector2(0.5f, 0.5f);
        var img = go.GetComponent<Image>();
        img.raycastTarget = false;
        img.sprite = FindSprite("F2_WHT_stand_0001");
        var animator = go.GetComponent<Animator>();
        animator.runtimeAnimatorController = ctrl;
        PrefabUtility.SaveAsPrefabAsset(go, "Assets/Prefabs/Imported/Avatars/F_WHT.prefab");
        Object.DestroyImmediate(go);
    }

    static void Build_F_XY()
    {
        string avatarName = "F_XY";
        // Stand clip: F2_XY (15f, 30.0fps)
        var standClip = BuildClip("F2_XY", 30.0f, 0.5f, true, new string[] {
            "F2_XY_stand_0001",
            "F2_XY_stand_0002",
            "F2_XY_stand_0003",
            "F2_XY_stand_0004",
            "F2_XY_stand_0005",
            "F2_XY_stand_0006",
            "F2_XY_stand_0007",
            "F2_XY_stand_0008",
            "F2_XY_stand_0009",
            "F2_XY_stand_0010",
            "F2_XY_stand_0011",
            "F2_XY_stand_0012",
            "F2_XY_stand_0013",
            "F2_XY_stand_0014",
            "F2_XY_stand_0015"
        });
        AssetDatabase.CreateAsset(standClip, "Assets/Animations/loginbg/F2_XY.anim");
        // Action clip: F2_XY_ACTION (35f, 30.0fps)
        var actionClip = BuildClip("F2_XY_ACTION", 30.0f, 1.1666666269302368f, false, new string[] {
            "F2_XY_action_0001",
            "F2_XY_action_0003",
            "F2_XY_action_0005",
            "F2_XY_action_0007",
            "F2_XY_action_0009",
            "F2_XY_action_0011",
            "F2_XY_action_0013",
            "F2_XY_action_0015",
            "F2_XY_action_0017",
            "F2_XY_action_0019",
            "F2_XY_action_0021",
            "F2_XY_action_0023",
            "F2_XY_action_0025",
            "F2_XY_action_0027",
            "F2_XY_action_0029",
            "F2_XY_action_0031",
            "F2_XY_action_0033",
            "F2_XY_action_0035",
            "F2_XY_action_0037",
            "F2_XY_action_0039",
            "F2_XY_action_0041",
            "F2_XY_action_0043",
            "F2_XY_action_0045",
            "F2_XY_action_0047",
            "F2_XY_action_0049",
            "F2_XY_action_0051",
            "F2_XY_action_0053",
            "F2_XY_action_0054",
            "F2_XY_action_0055",
            "F2_XY_action_0056",
            "F2_XY_action_0057",
            "F2_XY_action_0058",
            "F2_XY_action_0059",
            "F2_XY_action_0060",
            "F2_XY_action_0061"
        });
        AssetDatabase.CreateAsset(actionClip, "Assets/Animations/loginbg/F2_XY_ACTION.anim");
        // AnimatorController: F_XY
        var ctrl = AnimatorController.CreateAnimatorControllerAtPath("Assets/Animations/loginbg/F_XY.controller");
        ctrl.AddParameter("action", AnimatorControllerParameterType.Trigger);
        var rootSM = ctrl.layers[0].stateMachine;
        var standState = rootSM.AddState("stand");
        standState.motion = standClip;
        rootSM.defaultState = standState;
        var actionState = rootSM.AddState("action");
        actionState.motion = actionClip;
        // stand → action (trigger)
        var toAction = standState.AddTransition(actionState);
        toAction.AddCondition(AnimatorConditionMode.If, 0, "action");
        toAction.hasExitTime = false;
        toAction.duration = 0;
        // action → stand (exit time)
        var toStand = actionState.AddTransition(standState);
        toStand.hasExitTime = true;
        toStand.exitTime = 1f;
        toStand.duration = 0;
        // Prefab: F_XY
        var go = new GameObject("F_XY", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rtComp = go.GetComponent<RectTransform>();
        rtComp.anchoredPosition = new Vector2(166.0f, -281.0f);
        rtComp.sizeDelta = new Vector2(432.0f, 491.0f);
        rtComp.pivot = new Vector2(0.5f, 0.0f);
        rtComp.anchorMin = new Vector2(0.5f, 0.5f);
        rtComp.anchorMax = new Vector2(0.5f, 0.5f);
        var img = go.GetComponent<Image>();
        img.raycastTarget = false;
        img.sprite = FindSprite("F2_XY_stand_0001");
        var animator = go.GetComponent<Animator>();
        animator.runtimeAnimatorController = ctrl;
        PrefabUtility.SaveAsPrefabAsset(go, "Assets/Prefabs/Imported/Avatars/F_XY.prefab");
        Object.DestroyImmediate(go);
    }

    static void Build_F_YP()
    {
        string avatarName = "F_YP";
        // Stand clip: F2_YP (16f, 30.0fps)
        var standClip = BuildClip("F2_YP", 30.0f, 0.5333333611488342f, true, new string[] {
            "F2_YP_stand_0001",
            "F2_YP_stand_0002",
            "F2_YP_stand_0003",
            "F2_YP_stand_0004",
            "F2_YP_stand_0005",
            "F2_YP_stand_0006",
            "F2_YP_stand_0007",
            "F2_YP_stand_0008",
            "F2_YP_stand_0009",
            "F2_YP_stand_0010",
            "F2_YP_stand_0011",
            "F2_YP_stand_0012",
            "F2_YP_stand_0013",
            "F2_YP_stand_0014",
            "F2_YP_stand_0015",
            "F2_YP_stand_0016"
        });
        AssetDatabase.CreateAsset(standClip, "Assets/Animations/loginbg/F2_YP.anim");
        // Action clip: F2_YP_ACTION (38f, 30.0fps)
        var actionClip = BuildClip("F2_YP_ACTION", 30.0f, 1.2666666507720947f, false, new string[] {
            "F2_YP_action_0001",
            "F2_YP_action_0002",
            "F2_YP_action_0003",
            "F2_YP_action_0004",
            "F2_YP_action_0005",
            "F2_YP_action_0006",
            "F2_YP_action_0007",
            "F2_YP_action_0008",
            "F2_YP_action_0009",
            "F2_YP_action_0010",
            "F2_YP_action_0011",
            "F2_YP_action_0012",
            "F2_YP_action_0013",
            "F2_YP_action_0014",
            "F2_YP_action_0015",
            "F2_YP_action_0016",
            "F2_YP_action_0017",
            "F2_YP_action_0018",
            "F2_YP_action_0019",
            "F2_YP_action_0020",
            "F2_YP_action_0021",
            "F2_YP_action_0022",
            "F2_YP_action_0023",
            "F2_YP_action_0024",
            "F2_YP_action_0025",
            "F2_YP_action_0026",
            "F2_YP_action_0027",
            "F2_YP_action_0028",
            "F2_YP_action_0029",
            "F2_YP_action_0030",
            "F2_YP_action_0031",
            "F2_YP_action_0032",
            "F2_YP_action_0033",
            "F2_YP_action_0034",
            "F2_YP_action_0035",
            "F2_YP_action_0036",
            "F2_YP_action_0037",
            "F2_YP_action_0038"
        });
        AssetDatabase.CreateAsset(actionClip, "Assets/Animations/loginbg/F2_YP_ACTION.anim");
        // AnimatorController: F_YP
        var ctrl = AnimatorController.CreateAnimatorControllerAtPath("Assets/Animations/loginbg/F_YP.controller");
        ctrl.AddParameter("action", AnimatorControllerParameterType.Trigger);
        var rootSM = ctrl.layers[0].stateMachine;
        var standState = rootSM.AddState("stand");
        standState.motion = standClip;
        rootSM.defaultState = standState;
        var actionState = rootSM.AddState("action");
        actionState.motion = actionClip;
        // stand → action (trigger)
        var toAction = standState.AddTransition(actionState);
        toAction.AddCondition(AnimatorConditionMode.If, 0, "action");
        toAction.hasExitTime = false;
        toAction.duration = 0;
        // action → stand (exit time)
        var toStand = actionState.AddTransition(standState);
        toStand.hasExitTime = true;
        toStand.exitTime = 1f;
        toStand.duration = 0;
        // Prefab: F_YP
        var go = new GameObject("F_YP", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rtComp = go.GetComponent<RectTransform>();
        rtComp.anchoredPosition = new Vector2(205.1599884033203f, -321.3999938964844f);
        rtComp.sizeDelta = new Vector2(469.0f, 707.0f);
        rtComp.pivot = new Vector2(0.5199999809265137f, 0.0f);
        rtComp.anchorMin = new Vector2(0.5f, 0.5f);
        rtComp.anchorMax = new Vector2(0.5f, 0.5f);
        var img = go.GetComponent<Image>();
        img.raycastTarget = false;
        img.sprite = FindSprite("F2_YP_stand_0001");
        var animator = go.GetComponent<Animator>();
        animator.runtimeAnimatorController = ctrl;
        PrefabUtility.SaveAsPrefabAsset(go, "Assets/Prefabs/Imported/Avatars/F_YP.prefab");
        Object.DestroyImmediate(go);
    }

    static void Build_M_5D()
    {
        string avatarName = "M_5D";
        // Stand clip: M2_5D (32f, 30.0fps)
        var standClip = BuildClip("M2_5D", 30.0f, 1.066666603088379f, true, new string[] {
            "M2_5d_stand_0001",
            "M2_5d_stand_0002",
            "M2_5d_stand_0003",
            "M2_5d_stand_0004",
            "M2_5d_stand_0005",
            "M2_5d_stand_0006",
            "M2_5d_stand_0007",
            "M2_5d_stand_0008",
            "M2_5d_stand_0009",
            "M2_5d_stand_0010",
            "M2_5d_stand_0011",
            "M2_5d_stand_0012",
            "M2_5d_stand_0013",
            "M2_5d_stand_0014",
            "M2_5d_stand_0015",
            "M2_5d_stand_0016",
            "M2_5d_stand_0001",
            "M2_5d_stand_0002",
            "M2_5d_stand_0003",
            "M2_5d_stand_0004",
            "M2_5d_stand_0005",
            "M2_5d_stand_0006",
            "M2_5d_stand_0007",
            "M2_5d_stand_0008",
            "M2_5d_stand_0009",
            "M2_5d_stand_0010",
            "M2_5d_stand_0011",
            "M2_5d_stand_0012",
            "M2_5d_stand_0013",
            "M2_5d_stand_0014",
            "M2_5d_stand_0015",
            "M2_5d_stand_0016"
        });
        AssetDatabase.CreateAsset(standClip, "Assets/Animations/loginbg/M2_5D.anim");
        // Action clip: M2_5D_ACTION (28f, 30.0fps)
        var actionClip = BuildClip("M2_5D_ACTION", 30.0f, 0.9333333373069763f, false, new string[] {
            "M2_5d_action_0001",
            "M2_5d_action_0003",
            "M2_5d_action_0005",
            "M2_5d_action_0007",
            "M2_5d_action_0009",
            "M2_5d_action_0011",
            "M2_5d_action_0013",
            "M2_5d_action_0015",
            "M2_5d_action_0017",
            "M2_5d_action_0019",
            "M2_5d_action_0021",
            "M2_5d_action_0023",
            "M2_5d_action_0025",
            "M2_5d_action_0027",
            "M2_5d_action_0029",
            "M2_5d_action_0031",
            "M2_5d_action_0033",
            "M2_5d_action_0035",
            "M2_5d_action_0037",
            "M2_5d_action_0039",
            "M2_5d_action_0041",
            "M2_5d_action_0043",
            "M2_5d_action_0045",
            "M2_5d_action_0047",
            "M2_5d_action_0049",
            "M2_5d_action_0051",
            "M2_5d_action_0053",
            "M2_5d_action_0055"
        });
        AssetDatabase.CreateAsset(actionClip, "Assets/Animations/loginbg/M2_5D_ACTION.anim");
        // AnimatorController: M_5D
        var ctrl = AnimatorController.CreateAnimatorControllerAtPath("Assets/Animations/loginbg/M_5D.controller");
        ctrl.AddParameter("action", AnimatorControllerParameterType.Trigger);
        var rootSM = ctrl.layers[0].stateMachine;
        var standState = rootSM.AddState("stand");
        standState.motion = standClip;
        rootSM.defaultState = standState;
        var actionState = rootSM.AddState("action");
        actionState.motion = actionClip;
        // stand → action (trigger)
        var toAction = standState.AddTransition(actionState);
        toAction.AddCondition(AnimatorConditionMode.If, 0, "action");
        toAction.hasExitTime = false;
        toAction.duration = 0;
        // action → stand (exit time)
        var toStand = actionState.AddTransition(standState);
        toStand.hasExitTime = true;
        toStand.exitTime = 1f;
        toStand.duration = 0;
        // Prefab: M_5D
        var go = new GameObject("M_5D", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rtComp = go.GetComponent<RectTransform>();
        rtComp.anchoredPosition = new Vector2(-202.0f, -276.0f);
        rtComp.sizeDelta = new Vector2(390.0f, 512.0f);
        rtComp.pivot = new Vector2(0.6499999761581421f, 0.0f);
        rtComp.anchorMin = new Vector2(0.5f, 0.5f);
        rtComp.anchorMax = new Vector2(0.5f, 0.5f);
        var img = go.GetComponent<Image>();
        img.raycastTarget = false;
        img.sprite = FindSprite("M2_5d_stand_0001");
        var animator = go.GetComponent<Animator>();
        animator.runtimeAnimatorController = ctrl;
        PrefabUtility.SaveAsPrefabAsset(go, "Assets/Prefabs/Imported/Avatars/M_5D.prefab");
        Object.DestroyImmediate(go);
    }

    static void Build_M_BD()
    {
        string avatarName = "M_BD";
        // Stand clip: M2_BD (15f, 30.0fps)
        var standClip = BuildClip("M2_BD", 30.0f, 0.5f, true, new string[] {
            "M2_BD_stand_0001",
            "M2_BD_stand_0002",
            "M2_BD_stand_0003",
            "M2_BD_stand_0004",
            "M2_BD_stand_0005",
            "M2_BD_stand_0006",
            "M2_BD_stand_0007",
            "M2_BD_stand_0008",
            "M2_BD_stand_0009",
            "M2_BD_stand_0010",
            "M2_BD_stand_0011",
            "M2_BD_stand_0012",
            "M2_BD_stand_0013",
            "M2_BD_stand_0014",
            "M2_BD_stand_0015"
        });
        AssetDatabase.CreateAsset(standClip, "Assets/Animations/loginbg/M2_BD.anim");
        // Action clip: M2_BD_ACTION (32f, 30.0fps)
        var actionClip = BuildClip("M2_BD_ACTION", 30.0f, 1.066666603088379f, false, new string[] {
            "M2_BD_action_0001",
            "M2_BD_action_0003",
            "M2_BD_action_0005",
            "M2_BD_action_0007",
            "M2_BD_action_0009",
            "M2_BD_action_0011",
            "M2_BD_action_0013",
            "M2_BD_action_0015",
            "M2_BD_action_0017",
            "M2_BD_action_0019",
            "M2_BD_action_0021",
            "M2_BD_action_0023",
            "M2_BD_action_0025",
            "M2_BD_action_0027",
            "M2_BD_action_0029",
            "M2_BD_action_0031",
            "M2_BD_action_0033",
            "M2_BD_action_0035",
            "M2_BD_action_0037",
            "M2_BD_action_0039",
            "M2_BD_action_0041",
            "M2_BD_action_0043",
            "M2_BD_action_0045",
            "M2_BD_action_0047",
            "M2_BD_action_0049",
            "M2_BD_action_0051",
            "M2_BD_action_0053",
            "M2_BD_action_0055",
            "M2_BD_action_0057",
            "M2_BD_action_0058",
            "M2_BD_action_0059",
            "M2_BD_action_0060"
        });
        AssetDatabase.CreateAsset(actionClip, "Assets/Animations/loginbg/M2_BD_ACTION.anim");
        // AnimatorController: M_BD
        var ctrl = AnimatorController.CreateAnimatorControllerAtPath("Assets/Animations/loginbg/M_BD.controller");
        ctrl.AddParameter("action", AnimatorControllerParameterType.Trigger);
        var rootSM = ctrl.layers[0].stateMachine;
        var standState = rootSM.AddState("stand");
        standState.motion = standClip;
        rootSM.defaultState = standState;
        var actionState = rootSM.AddState("action");
        actionState.motion = actionClip;
        // stand → action (trigger)
        var toAction = standState.AddTransition(actionState);
        toAction.AddCondition(AnimatorConditionMode.If, 0, "action");
        toAction.hasExitTime = false;
        toAction.duration = 0;
        // action → stand (exit time)
        var toStand = actionState.AddTransition(standState);
        toStand.hasExitTime = true;
        toStand.exitTime = 1f;
        toStand.duration = 0;
        // Prefab: M_BD
        var go = new GameObject("M_BD", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rtComp = go.GetComponent<RectTransform>();
        rtComp.anchoredPosition = new Vector2(-220.449951171875f, -303.0f);
        rtComp.sizeDelta = new Vector2(603.0f, 665.0f);
        rtComp.pivot = new Vector2(0.5f, 0.0f);
        rtComp.anchorMin = new Vector2(0.5f, 0.5f);
        rtComp.anchorMax = new Vector2(0.5f, 0.5f);
        var img = go.GetComponent<Image>();
        img.raycastTarget = false;
        img.sprite = FindSprite("M2_BD_stand_0001");
        var animator = go.GetComponent<Animator>();
        animator.runtimeAnimatorController = ctrl;
        PrefabUtility.SaveAsPrefabAsset(go, "Assets/Prefabs/Imported/Avatars/M_BD.prefab");
        Object.DestroyImmediate(go);
    }

    static void Build_M_BTS()
    {
        string avatarName = "M_BTS";
        // Stand clip: M2_BTS (16f, 30.0fps)
        var standClip = BuildClip("M2_BTS", 30.0f, 0.5333333611488342f, true, new string[] {
            "M2_BTS_stand_0001",
            "M2_BTS_stand_0002",
            "M2_BTS_stand_0003",
            "M2_BTS_stand_0004",
            "M2_BTS_stand_0005",
            "M2_BTS_stand_0006",
            "M2_BTS_stand_0007",
            "M2_BTS_stand_0008",
            "M2_BTS_stand_0009",
            "M2_BTS_stand_0010",
            "M2_BTS_stand_0011",
            "M2_BTS_stand_0012",
            "M2_BTS_stand_0013",
            "M2_BTS_stand_0014",
            "M2_BTS_stand_0015",
            "M2_BTS_stand_0016"
        });
        AssetDatabase.CreateAsset(standClip, "Assets/Animations/loginbg/M2_BTS.anim");
        // Action clip: M2_BTS_ACTION (31f, 30.0fps)
        var actionClip = BuildClip("M2_BTS_ACTION", 30.0f, 1.0333333015441895f, false, new string[] {
            "M2_BTS_action_0001",
            "M2_BTS_action_0003",
            "M2_BTS_action_0005",
            "M2_BTS_action_0007",
            "M2_BTS_action_0009",
            "M2_BTS_action_0011",
            "M2_BTS_action_0013",
            "M2_BTS_action_0015",
            "M2_BTS_action_0017",
            "M2_BTS_action_0019",
            "M2_BTS_action_0021",
            "M2_BTS_action_0023",
            "M2_BTS_action_0025",
            "M2_BTS_action_0027",
            "M2_BTS_action_0029",
            "M2_BTS_action_0031",
            "M2_BTS_action_0033",
            "M2_BTS_action_0035",
            "M2_BTS_action_0037",
            "M2_BTS_action_0039",
            "M2_BTS_action_0041",
            "M2_BTS_action_0043",
            "M2_BTS_action_0045",
            "M2_BTS_action_0047",
            "M2_BTS_action_0049",
            "M2_BTS_action_0051",
            "M2_BTS_action_0053",
            "M2_BTS_action_0055",
            "M2_BTS_action_0057",
            "M2_BTS_action_0059",
            "M2_BTS_action_0061"
        });
        AssetDatabase.CreateAsset(actionClip, "Assets/Animations/loginbg/M2_BTS_ACTION.anim");
        // AnimatorController: M_BTS
        var ctrl = AnimatorController.CreateAnimatorControllerAtPath("Assets/Animations/loginbg/M_BTS.controller");
        ctrl.AddParameter("action", AnimatorControllerParameterType.Trigger);
        var rootSM = ctrl.layers[0].stateMachine;
        var standState = rootSM.AddState("stand");
        standState.motion = standClip;
        rootSM.defaultState = standState;
        var actionState = rootSM.AddState("action");
        actionState.motion = actionClip;
        // stand → action (trigger)
        var toAction = standState.AddTransition(actionState);
        toAction.AddCondition(AnimatorConditionMode.If, 0, "action");
        toAction.hasExitTime = false;
        toAction.duration = 0;
        // action → stand (exit time)
        var toStand = actionState.AddTransition(standState);
        toStand.hasExitTime = true;
        toStand.exitTime = 1f;
        toStand.duration = 0;
        // Prefab: M_BTS
        var go = new GameObject("M_BTS", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rtComp = go.GetComponent<RectTransform>();
        rtComp.anchoredPosition = new Vector2(-221.0f, -319.0f);
        rtComp.sizeDelta = new Vector2(448.0f, 563.0f);
        rtComp.pivot = new Vector2(0.5f, 0.0f);
        rtComp.anchorMin = new Vector2(0.5f, 0.5f);
        rtComp.anchorMax = new Vector2(0.5f, 0.5f);
        var img = go.GetComponent<Image>();
        img.raycastTarget = false;
        img.sprite = FindSprite("M2_BTS_stand_0001");
        var animator = go.GetComponent<Animator>();
        animator.runtimeAnimatorController = ctrl;
        PrefabUtility.SaveAsPrefabAsset(go, "Assets/Prefabs/Imported/Avatars/M_BTS.prefab");
        Object.DestroyImmediate(go);
    }

    static void Build_M_CGM()
    {
        string avatarName = "M_CGM";
        // Stand clip: M2_CGM (16f, 30.0fps)
        var standClip = BuildClip("M2_CGM", 30.0f, 0.5333333611488342f, true, new string[] {
            "M2_CGM_stand_0001",
            "M2_CGM_stand_0002",
            "M2_CGM_stand_0003",
            "M2_CGM_stand_0004",
            "M2_CGM_stand_0005",
            "M2_CGM_stand_0006",
            "M2_CGM_stand_0007",
            "M2_CGM_stand_0008",
            "M2_CGM_stand_0009",
            "M2_CGM_stand_0010",
            "M2_CGM_stand_0011",
            "M2_CGM_stand_0012",
            "M2_CGM_stand_0013",
            "M2_CGM_stand_0014",
            "M2_CGM_stand_0015",
            "M2_CGM_stand_0016"
        });
        AssetDatabase.CreateAsset(standClip, "Assets/Animations/loginbg/M2_CGM.anim");
        // Action clip: M2_CGM_ACTION (37f, 30.0fps)
        var actionClip = BuildClip("M2_CGM_ACTION", 30.0f, 1.2333333492279053f, false, new string[] {
            "M2_CGM_action_0001",
            "M2_CGM_action_0003",
            "M2_CGM_action_0005",
            "M2_CGM_action_0006",
            "M2_CGM_action_0007",
            "M2_CGM_action_0008",
            "M2_CGM_action_0009",
            "M2_CGM_action_0010",
            "M2_CGM_action_0011",
            "M2_CGM_action_0012",
            "M2_CGM_action_0013",
            "M2_CGM_action_0015",
            "M2_CGM_action_0017",
            "M2_CGM_action_0019",
            "M2_CGM_action_0021",
            "M2_CGM_action_0023",
            "M2_CGM_action_0025",
            "M2_CGM_action_0026",
            "M2_CGM_action_0027",
            "M2_CGM_action_0028",
            "M2_CGM_action_0029",
            "M2_CGM_action_0031",
            "M2_CGM_action_0033",
            "M2_CGM_action_0035",
            "M2_CGM_action_0037",
            "M2_CGM_action_0039",
            "M2_CGM_action_0041",
            "M2_CGM_action_0043",
            "M2_CGM_action_0045",
            "M2_CGM_action_0047",
            "M2_CGM_action_0049",
            "M2_CGM_action_0051",
            "M2_CGM_action_0053",
            "M2_CGM_action_0055",
            "M2_CGM_action_0057",
            "M2_CGM_action_0059",
            "M2_CGM_action_0061"
        });
        AssetDatabase.CreateAsset(actionClip, "Assets/Animations/loginbg/M2_CGM_ACTION.anim");
        // AnimatorController: M_CGM
        var ctrl = AnimatorController.CreateAnimatorControllerAtPath("Assets/Animations/loginbg/M_CGM.controller");
        ctrl.AddParameter("action", AnimatorControllerParameterType.Trigger);
        var rootSM = ctrl.layers[0].stateMachine;
        var standState = rootSM.AddState("stand");
        standState.motion = standClip;
        rootSM.defaultState = standState;
        var actionState = rootSM.AddState("action");
        actionState.motion = actionClip;
        // stand → action (trigger)
        var toAction = standState.AddTransition(actionState);
        toAction.AddCondition(AnimatorConditionMode.If, 0, "action");
        toAction.hasExitTime = false;
        toAction.duration = 0;
        // action → stand (exit time)
        var toStand = actionState.AddTransition(standState);
        toStand.hasExitTime = true;
        toStand.exitTime = 1f;
        toStand.duration = 0;
        // Prefab: M_CGM
        var go = new GameObject("M_CGM", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rtComp = go.GetComponent<RectTransform>();
        rtComp.anchoredPosition = new Vector2(-218.5800018310547f, -360.0f);
        rtComp.sizeDelta = new Vector2(551.0f, 645.0f);
        rtComp.pivot = new Vector2(0.5099999904632568f, 0.0f);
        rtComp.anchorMin = new Vector2(0.5f, 0.5f);
        rtComp.anchorMax = new Vector2(0.5f, 0.5f);
        var img = go.GetComponent<Image>();
        img.raycastTarget = false;
        img.sprite = FindSprite("M2_CGM_stand_0001");
        var animator = go.GetComponent<Animator>();
        animator.runtimeAnimatorController = ctrl;
        PrefabUtility.SaveAsPrefabAsset(go, "Assets/Prefabs/Imported/Avatars/M_CGM.prefab");
        Object.DestroyImmediate(go);
    }

    static void Build_M_CY()
    {
        string avatarName = "M_CY";
        // Stand clip: M2_CY (32f, 30.0fps)
        var standClip = BuildClip("M2_CY", 30.0f, 1.066666603088379f, true, new string[] {
            "M2_CY_stand_0001",
            "M2_CY_stand_0002",
            "M2_CY_stand_0003",
            "M2_CY_stand_0004",
            "M2_CY_stand_0005",
            "M2_CY_stand_0006",
            "M2_CY_stand_0007",
            "M2_CY_stand_0008",
            "M2_CY_stand_0009",
            "M2_CY_stand_0010",
            "M2_CY_stand_0011",
            "M2_CY_stand_0012",
            "M2_CY_stand_0013",
            "M2_CY_stand_0014",
            "M2_CY_stand_0015",
            "M2_CY_stand_0016",
            "M2_CY_stand_0001",
            "M2_CY_stand_0002",
            "M2_CY_stand_0003",
            "M2_CY_stand_0004",
            "M2_CY_stand_0005",
            "M2_CY_stand_0006",
            "M2_CY_stand_0007",
            "M2_CY_stand_0008",
            "M2_CY_stand_0009",
            "M2_CY_stand_0010",
            "M2_CY_stand_0011",
            "M2_CY_stand_0012",
            "M2_CY_stand_0013",
            "M2_CY_stand_0014",
            "M2_CY_stand_0015",
            "M2_CY_stand_0016"
        });
        AssetDatabase.CreateAsset(standClip, "Assets/Animations/loginbg/M2_CY.anim");
        // Action clip: M2_CY_ACTION (30f, 30.0fps)
        var actionClip = BuildClip("M2_CY_ACTION", 30.0f, 1.0f, false, new string[] {
            "M2_CY_action_0000",
            "M2_CY_action_0002",
            "M2_CY_action_0004",
            "M2_CY_action_0006",
            "M2_CY_action_0008",
            "M2_CY_action_0010",
            "M2_CY_action_0012",
            "M2_CY_action_0014",
            "M2_CY_action_0016",
            "M2_CY_action_0018",
            "M2_CY_action_0020",
            "M2_CY_action_0022",
            "M2_CY_action_0024",
            "M2_CY_action_0026",
            "M2_CY_action_0028",
            "M2_CY_action_0030",
            "M2_CY_action_0032",
            "M2_CY_action_0034",
            "M2_CY_action_0036",
            "M2_CY_action_0038",
            "M2_CY_action_0040",
            "M2_CY_action_0042",
            "M2_CY_action_0044",
            "M2_CY_action_0046",
            "M2_CY_action_0048",
            "M2_CY_action_0050",
            "M2_CY_action_0052",
            "M2_CY_action_0054",
            "M2_CY_action_0056",
            "M2_CY_action_0058"
        });
        AssetDatabase.CreateAsset(actionClip, "Assets/Animations/loginbg/M2_CY_ACTION.anim");
        // AnimatorController: M_CY
        var ctrl = AnimatorController.CreateAnimatorControllerAtPath("Assets/Animations/loginbg/M_CY.controller");
        ctrl.AddParameter("action", AnimatorControllerParameterType.Trigger);
        var rootSM = ctrl.layers[0].stateMachine;
        var standState = rootSM.AddState("stand");
        standState.motion = standClip;
        rootSM.defaultState = standState;
        var actionState = rootSM.AddState("action");
        actionState.motion = actionClip;
        // stand → action (trigger)
        var toAction = standState.AddTransition(actionState);
        toAction.AddCondition(AnimatorConditionMode.If, 0, "action");
        toAction.hasExitTime = false;
        toAction.duration = 0;
        // action → stand (exit time)
        var toStand = actionState.AddTransition(standState);
        toStand.hasExitTime = true;
        toStand.exitTime = 1f;
        toStand.duration = 0;
        // Prefab: M_CY
        var go = new GameObject("M_CY", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rtComp = go.GetComponent<RectTransform>();
        rtComp.anchoredPosition = new Vector2(-189.5999755859375f, -268.0f);
        rtComp.sizeDelta = new Vector2(384.0f, 512.0f);
        rtComp.pivot = new Vector2(0.6000000238418579f, 0.0f);
        rtComp.anchorMin = new Vector2(0.5f, 0.5f);
        rtComp.anchorMax = new Vector2(0.5f, 0.5f);
        var img = go.GetComponent<Image>();
        img.raycastTarget = false;
        img.sprite = FindSprite("M2_CY_stand_0001");
        var animator = go.GetComponent<Animator>();
        animator.runtimeAnimatorController = ctrl;
        PrefabUtility.SaveAsPrefabAsset(go, "Assets/Prefabs/Imported/Avatars/M_CY.prefab");
        Object.DestroyImmediate(go);
    }

    static void Build_M_DL()
    {
        string avatarName = "M_DL";
        // Stand clip: M2_DL (32f, 30.0fps)
        var standClip = BuildClip("M2_DL", 30.0f, 1.066666603088379f, true, new string[] {
            "M2_DL_stand_0001",
            "M2_DL_stand_0002",
            "M2_DL_stand_0003",
            "M2_DL_stand_0004",
            "M2_DL_stand_0005",
            "M2_DL_stand_0006",
            "M2_DL_stand_0007",
            "M2_DL_stand_0008",
            "M2_DL_stand_0009",
            "M2_DL_stand_0010",
            "M2_DL_stand_0011",
            "M2_DL_stand_0012",
            "M2_DL_stand_0013",
            "M2_DL_stand_0014",
            "M2_DL_stand_0015",
            "M2_DL_stand_0016",
            "M2_DL_stand_0001",
            "M2_DL_stand_0002",
            "M2_DL_stand_0003",
            "M2_DL_stand_0004",
            "M2_DL_stand_0005",
            "M2_DL_stand_0006",
            "M2_DL_stand_0007",
            "M2_DL_stand_0008",
            "M2_DL_stand_0009",
            "M2_DL_stand_0010",
            "M2_DL_stand_0011",
            "M2_DL_stand_0012",
            "M2_DL_stand_0013",
            "M2_DL_stand_0014",
            "M2_DL_stand_0015",
            "M2_DL_stand_0016"
        });
        AssetDatabase.CreateAsset(standClip, "Assets/Animations/loginbg/M2_DL.anim");
        // Action clip: M2_DL_action (31f, 30.0fps)
        var actionClip = BuildClip("M2_DL_action", 30.0f, 1.0333333015441895f, false, new string[] {
            "M2_DL_action_0001",
            "M2_DL_action_0003",
            "M2_DL_action_0005",
            "M2_DL_action_0007",
            "M2_DL_action_0009",
            "M2_DL_action_0011",
            "M2_DL_action_0013",
            "M2_DL_action_0015",
            "M2_DL_action_0017",
            "M2_DL_action_0019",
            "M2_DL_action_0021",
            "M2_DL_action_0023",
            "M2_DL_action_0025",
            "M2_DL_action_0027",
            "M2_DL_action_0029",
            "M2_DL_action_0031",
            "M2_DL_action_0033",
            "M2_DL_action_0035",
            "M2_DL_action_0037",
            "M2_DL_action_0039",
            "M2_DL_action_0041",
            "M2_DL_action_0043",
            "M2_DL_action_0045",
            "M2_DL_action_0047",
            "M2_DL_action_0049",
            "M2_DL_action_0051",
            "M2_DL_action_0053",
            "M2_DL_action_0055",
            "M2_DL_action_0057",
            "M2_DL_action_0059",
            "M2_DL_action_0061"
        });
        AssetDatabase.CreateAsset(actionClip, "Assets/Animations/loginbg/M2_DL_action.anim");
        // AnimatorController: M_DL
        var ctrl = AnimatorController.CreateAnimatorControllerAtPath("Assets/Animations/loginbg/M_DL.controller");
        ctrl.AddParameter("action", AnimatorControllerParameterType.Trigger);
        var rootSM = ctrl.layers[0].stateMachine;
        var standState = rootSM.AddState("stand");
        standState.motion = standClip;
        rootSM.defaultState = standState;
        var actionState = rootSM.AddState("action");
        actionState.motion = actionClip;
        // stand → action (trigger)
        var toAction = standState.AddTransition(actionState);
        toAction.AddCondition(AnimatorConditionMode.If, 0, "action");
        toAction.hasExitTime = false;
        toAction.duration = 0;
        // action → stand (exit time)
        var toStand = actionState.AddTransition(standState);
        toStand.hasExitTime = true;
        toStand.exitTime = 1f;
        toStand.duration = 0;
        // Prefab: M_DL
        var go = new GameObject("M_DL", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rtComp = go.GetComponent<RectTransform>();
        rtComp.anchoredPosition = new Vector2(-184.0f, -276.0f);
        rtComp.sizeDelta = new Vector2(384.0f, 512.0f);
        rtComp.pivot = new Vector2(0.5f, 0.0f);
        rtComp.anchorMin = new Vector2(0.5f, 0.5f);
        rtComp.anchorMax = new Vector2(0.5f, 0.5f);
        var img = go.GetComponent<Image>();
        img.raycastTarget = false;
        img.sprite = FindSprite("M2_DL_stand_0001");
        var animator = go.GetComponent<Animator>();
        animator.runtimeAnimatorController = ctrl;
        PrefabUtility.SaveAsPrefabAsset(go, "Assets/Prefabs/Imported/Avatars/M_DL.prefab");
        Object.DestroyImmediate(go);
    }

    static void Build_M_GB()
    {
        string avatarName = "M_GB";
        // Stand clip: M2_GB (32f, 30.0fps)
        var standClip = BuildClip("M2_GB", 30.0f, 1.066666603088379f, true, new string[] {
            "M2_GB_stand_0001",
            "M2_GB_stand_0002",
            "M2_GB_stand_0003",
            "M2_GB_stand_0004",
            "M2_GB_stand_0005",
            "M2_GB_stand_0006",
            "M2_GB_stand_0007",
            "M2_GB_stand_0008",
            "M2_GB_stand_0009",
            "M2_GB_stand_0010",
            "M2_GB_stand_0011",
            "M2_GB_stand_0012",
            "M2_GB_stand_0013",
            "M2_GB_stand_0014",
            "M2_GB_stand_0015",
            "M2_GB_stand_0016",
            "M2_GB_stand_0001",
            "M2_GB_stand_0002",
            "M2_GB_stand_0003",
            "M2_GB_stand_0004",
            "M2_GB_stand_0005",
            "M2_GB_stand_0006",
            "M2_GB_stand_0007",
            "M2_GB_stand_0008",
            "M2_GB_stand_0009",
            "M2_GB_stand_0010",
            "M2_GB_stand_0011",
            "M2_GB_stand_0012",
            "M2_GB_stand_0013",
            "M2_GB_stand_0014",
            "M2_GB_stand_0015",
            "M2_GB_stand_0016"
        });
        AssetDatabase.CreateAsset(standClip, "Assets/Animations/loginbg/M2_GB.anim");
        // Action clip: M2_GB_ACTION (45f, 30.0fps)
        var actionClip = BuildClip("M2_GB_ACTION", 30.0f, 1.600000023841858f, false, new string[] {
            "M2_GB_ACTION_0000",
            "M2_GB_ACTION_0002",
            "M2_GB_ACTION_0004",
            "M2_GB_ACTION_0006",
            "M2_GB_ACTION_0008",
            "M2_GB_ACTION_0010",
            "M2_GB_ACTION_0012",
            "M2_GB_ACTION_0014",
            "M2_GB_ACTION_0016",
            "M2_GB_ACTION_0018",
            "M2_GB_ACTION_0020",
            "M2_GB_ACTION_0022",
            "M2_GB_ACTION_0024",
            "M2_GB_ACTION_0026",
            "M2_GB_ACTION_0028",
            "M2_GB_ACTION_0030",
            "M2_GB_ACTION_0032",
            "M2_GB_ACTION_0034",
            "M2_GB_ACTION_0036",
            "M2_GB_ACTION_0038",
            "M2_GB_ACTION_0040",
            "M2_GB_ACTION_0042",
            "M2_GB_ACTION_0044",
            "M2_GB_ACTION_0046",
            "M2_GB_ACTION_0048",
            "M2_GB_ACTION_0050",
            "M2_GB_ACTION_0052",
            "M2_GB_ACTION_0054",
            "M2_GB_ACTION_0056",
            "M2_GB_ACTION_0058",
            "M2_GB_ACTION_0060",
            "M2_GB_ACTION_0062",
            "M2_GB_ACTION_0064",
            "M2_GB_ACTION_0066",
            "M2_GB_ACTION_0068",
            "M2_GB_ACTION_0070",
            "M2_GB_ACTION_0072",
            "M2_GB_ACTION_0074",
            "M2_GB_ACTION_0076",
            "M2_GB_ACTION_0078",
            "M2_GB_ACTION_0080",
            "M2_GB_ACTION_0082",
            "M2_GB_ACTION_0084",
            "M2_GB_ACTION_0086",
            "M2_GB_ACTION_0088"
        });
        AssetDatabase.CreateAsset(actionClip, "Assets/Animations/loginbg/M2_GB_ACTION.anim");
        // AnimatorController: M_GB
        var ctrl = AnimatorController.CreateAnimatorControllerAtPath("Assets/Animations/loginbg/M_GB.controller");
        ctrl.AddParameter("action", AnimatorControllerParameterType.Trigger);
        var rootSM = ctrl.layers[0].stateMachine;
        var standState = rootSM.AddState("stand");
        standState.motion = standClip;
        rootSM.defaultState = standState;
        var actionState = rootSM.AddState("action");
        actionState.motion = actionClip;
        // stand → action (trigger)
        var toAction = standState.AddTransition(actionState);
        toAction.AddCondition(AnimatorConditionMode.If, 0, "action");
        toAction.hasExitTime = false;
        toAction.duration = 0;
        // action → stand (exit time)
        var toStand = actionState.AddTransition(standState);
        toStand.hasExitTime = true;
        toStand.exitTime = 1f;
        toStand.duration = 0;
        // Prefab: M_GB
        var go = new GameObject("M_GB", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rtComp = go.GetComponent<RectTransform>();
        rtComp.anchoredPosition = new Vector2(-211.0f, -276.0f);
        rtComp.sizeDelta = new Vector2(384.0f, 512.0f);
        rtComp.pivot = new Vector2(0.5f, 0.0f);
        rtComp.anchorMin = new Vector2(0.5f, 0.5f);
        rtComp.anchorMax = new Vector2(0.5f, 0.5f);
        var img = go.GetComponent<Image>();
        img.raycastTarget = false;
        img.sprite = FindSprite("M2_GB_stand_0001");
        var animator = go.GetComponent<Animator>();
        animator.runtimeAnimatorController = ctrl;
        PrefabUtility.SaveAsPrefabAsset(go, "Assets/Prefabs/Imported/Avatars/M_GB.prefab");
        Object.DestroyImmediate(go);
    }

    static void Build_M_GM()
    {
        string avatarName = "M_GM";
        // Stand clip: M2_GM (16f, 30.0fps)
        var standClip = BuildClip("M2_GM", 30.0f, 1.0f, true, new string[] {
            "M2_GM_stand_0001",
            "M2_GM_stand_0002",
            "M2_GM_stand_0003",
            "M2_GM_stand_0004",
            "M2_GM_stand_0005",
            "M2_GM_stand_0006",
            "M2_GM_stand_0007",
            "M2_GM_stand_0008",
            "M2_GM_stand_0009",
            "M2_GM_stand_0010",
            "M2_GM_stand_0011",
            "M2_GM_stand_0012",
            "M2_GM_stand_0013",
            "M2_GM_stand_0014",
            "M2_GM_stand_0015",
            "M2_GM_stand_0016"
        });
        AssetDatabase.CreateAsset(standClip, "Assets/Animations/loginbg/M2_GM.anim");
        // Action clip: M2_GM_ACTION (27f, 30.0fps)
        var actionClip = BuildClip("M2_GM_ACTION", 30.0f, 1.0333333015441895f, false, new string[] {
            "M2_GM_action_0000",
            "M2_GM_action_0002",
            "M2_GM_action_0004",
            "M2_GM_action_0006",
            "M2_GM_action_0010",
            "M2_GM_action_0012",
            "M2_GM_action_0014",
            "M2_GM_action_0016",
            "M2_GM_action_0018",
            "M2_GM_action_0020",
            "M2_GM_action_0024",
            "M2_GM_action_0026",
            "M2_GM_action_0030",
            "M2_GM_action_0032",
            "M2_GM_action_0034",
            "M2_GM_action_0038",
            "M2_GM_action_0040",
            "M2_GM_action_0044",
            "M2_GM_action_0046",
            "M2_GM_action_0048",
            "M2_GM_action_0050",
            "M2_GM_action_0052",
            "M2_GM_action_0054",
            "M2_GM_action_0056",
            "M2_GM_action_0058",
            "M2_GM_action_0060",
            "M2_GM_action_0062"
        });
        AssetDatabase.CreateAsset(actionClip, "Assets/Animations/loginbg/M2_GM_ACTION.anim");
        // AnimatorController: M_GM
        var ctrl = AnimatorController.CreateAnimatorControllerAtPath("Assets/Animations/loginbg/M_GM.controller");
        ctrl.AddParameter("action", AnimatorControllerParameterType.Trigger);
        var rootSM = ctrl.layers[0].stateMachine;
        var standState = rootSM.AddState("stand");
        standState.motion = standClip;
        rootSM.defaultState = standState;
        var actionState = rootSM.AddState("action");
        actionState.motion = actionClip;
        // stand → action (trigger)
        var toAction = standState.AddTransition(actionState);
        toAction.AddCondition(AnimatorConditionMode.If, 0, "action");
        toAction.hasExitTime = false;
        toAction.duration = 0;
        // action → stand (exit time)
        var toStand = actionState.AddTransition(standState);
        toStand.hasExitTime = true;
        toStand.exitTime = 1f;
        toStand.duration = 0;
        // Prefab: M_GM
        var go = new GameObject("M_GM", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rtComp = go.GetComponent<RectTransform>();
        rtComp.anchoredPosition = new Vector2(-223.0f, -273.0f);
        rtComp.sizeDelta = new Vector2(368.0f, 491.0f);
        rtComp.pivot = new Vector2(0.5f, 0.0f);
        rtComp.anchorMin = new Vector2(0.5f, 0.5f);
        rtComp.anchorMax = new Vector2(0.5f, 0.5f);
        var img = go.GetComponent<Image>();
        img.raycastTarget = false;
        img.sprite = FindSprite("M2_GM_stand_0001");
        var animator = go.GetComponent<Animator>();
        animator.runtimeAnimatorController = ctrl;
        PrefabUtility.SaveAsPrefabAsset(go, "Assets/Prefabs/Imported/Avatars/M_GM.prefab");
        Object.DestroyImmediate(go);
    }

    static void Build_M_KL()
    {
        string avatarName = "M_KL";
        // Stand clip: M2_KL (32f, 30.0fps)
        var standClip = BuildClip("M2_KL", 30.0f, 1.066666603088379f, true, new string[] {
            "M2_KL_stand_0001",
            "M2_KL_stand_0002",
            "M2_KL_stand_0003",
            "M2_KL_stand_0004",
            "M2_KL_stand_0005",
            "M2_KL_stand_0006",
            "M2_KL_stand_0007",
            "M2_KL_stand_0008",
            "M2_KL_stand_0009",
            "M2_KL_stand_0010",
            "M2_KL_stand_0011",
            "M2_KL_stand_0012",
            "M2_KL_stand_0013",
            "M2_KL_stand_0014",
            "M2_KL_stand_0015",
            "M2_KL_stand_0016",
            "M2_KL_stand_0001",
            "M2_KL_stand_0002",
            "M2_KL_stand_0003",
            "M2_KL_stand_0004",
            "M2_KL_stand_0005",
            "M2_KL_stand_0006",
            "M2_KL_stand_0007",
            "M2_KL_stand_0008",
            "M2_KL_stand_0009",
            "M2_KL_stand_0010",
            "M2_KL_stand_0011",
            "M2_KL_stand_0012",
            "M2_KL_stand_0013",
            "M2_KL_stand_0014",
            "M2_KL_stand_0015",
            "M2_KL_stand_0016"
        });
        AssetDatabase.CreateAsset(standClip, "Assets/Animations/loginbg/M2_KL.anim");
        // Action clip: M2_KL_ACTION (38f, 30.0fps)
        var actionClip = BuildClip("M2_KL_ACTION", 30.0f, 1.4333332777023315f, false, new string[] {
            "M2_KL_action_0001",
            "M2_KL_action_0003",
            "M2_KL_action_0005",
            "M2_KL_action_0007",
            "M2_KL_action_0009",
            "M2_KL_action_0011",
            "M2_KL_action_0013",
            "M2_KL_action_0015",
            "M2_KL_action_0017",
            "M2_KL_action_0019",
            "M2_KL_action_0021",
            "M2_KL_action_0023",
            "M2_KL_action_0025",
            "M2_KL_action_0027",
            "M2_KL_action_0029",
            "M2_KL_action_0031",
            "M2_KL_action_0033",
            "M2_KL_action_0035",
            "M2_KL_action_0037",
            "M2_KL_action_0039",
            "M2_KL_action_0041",
            "M2_KL_action_0043",
            "M2_KL_action_0045",
            "M2_KL_action_0047",
            "M2_KL_action_0049",
            "M2_KL_action_0051",
            "M2_KL_action_0053",
            "M2_KL_action_0055",
            "M2_KL_action_0057",
            "M2_KL_action_0059",
            "M2_KL_action_0061",
            "M2_KL_action_0063",
            "M2_KL_action_0065",
            "M2_KL_action_0067",
            "M2_KL_action_0069",
            "M2_KL_action_0071",
            "M2_KL_action_0073",
            "M2_KL_action_0075"
        });
        AssetDatabase.CreateAsset(actionClip, "Assets/Animations/loginbg/M2_KL_ACTION.anim");
        // AnimatorController: M_KL
        var ctrl = AnimatorController.CreateAnimatorControllerAtPath("Assets/Animations/loginbg/M_KL.controller");
        ctrl.AddParameter("action", AnimatorControllerParameterType.Trigger);
        var rootSM = ctrl.layers[0].stateMachine;
        var standState = rootSM.AddState("stand");
        standState.motion = standClip;
        rootSM.defaultState = standState;
        var actionState = rootSM.AddState("action");
        actionState.motion = actionClip;
        // stand → action (trigger)
        var toAction = standState.AddTransition(actionState);
        toAction.AddCondition(AnimatorConditionMode.If, 0, "action");
        toAction.hasExitTime = false;
        toAction.duration = 0;
        // action → stand (exit time)
        var toStand = actionState.AddTransition(standState);
        toStand.hasExitTime = true;
        toStand.exitTime = 1f;
        toStand.duration = 0;
        // Prefab: M_KL
        var go = new GameObject("M_KL", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rtComp = go.GetComponent<RectTransform>();
        rtComp.anchoredPosition = new Vector2(-202.0f, -255.0f);
        rtComp.sizeDelta = new Vector2(583.0f, 583.0f);
        rtComp.pivot = new Vector2(0.5f, 0.0f);
        rtComp.anchorMin = new Vector2(0.5f, 0.5f);
        rtComp.anchorMax = new Vector2(0.5f, 0.5f);
        var img = go.GetComponent<Image>();
        img.raycastTarget = false;
        img.sprite = FindSprite("M2_KL_stand_0001");
        var animator = go.GetComponent<Animator>();
        animator.runtimeAnimatorController = ctrl;
        PrefabUtility.SaveAsPrefabAsset(go, "Assets/Prefabs/Imported/Avatars/M_KL.prefab");
        Object.DestroyImmediate(go);
    }

    static void Build_M_MJ()
    {
        string avatarName = "M_MJ";
        // Stand clip: M2_MJ (32f, 30.0fps)
        var standClip = BuildClip("M2_MJ", 30.0f, 1.066666603088379f, true, new string[] {
            "M2_MJ_stand_0001",
            "M2_MJ_stand_0002",
            "M2_MJ_stand_0003",
            "M2_MJ_stand_0004",
            "M2_MJ_stand_0005",
            "M2_MJ_stand_0006",
            "M2_MJ_stand_0007",
            "M2_MJ_stand_0008",
            "M2_MJ_stand_0009",
            "M2_MJ_stand_0010",
            "M2_MJ_stand_0011",
            "M2_MJ_stand_0012",
            "M2_MJ_stand_0013",
            "M2_MJ_stand_0014",
            "M2_MJ_stand_0015",
            "M2_MJ_stand_0016",
            "M2_MJ_stand_0001",
            "M2_MJ_stand_0002",
            "M2_MJ_stand_0003",
            "M2_MJ_stand_0004",
            "M2_MJ_stand_0005",
            "M2_MJ_stand_0006",
            "M2_MJ_stand_0007",
            "M2_MJ_stand_0008",
            "M2_MJ_stand_0009",
            "M2_MJ_stand_0010",
            "M2_MJ_stand_0011",
            "M2_MJ_stand_0012",
            "M2_MJ_stand_0013",
            "M2_MJ_stand_0014",
            "M2_MJ_stand_0015",
            "M2_MJ_stand_0016"
        });
        AssetDatabase.CreateAsset(standClip, "Assets/Animations/loginbg/M2_MJ.anim");
        // Action clip: M2_MJ_ACITION (29f, 30.0fps)
        var actionClip = BuildClip("M2_MJ_ACITION", 30.0f, 1.0333333015441895f, false, new string[] {
            "M2_MJ_action_0000",
            "M2_MJ_action_0002",
            "M2_MJ_action_0004",
            "M2_MJ_action_0006",
            "M2_MJ_action_0008",
            "M2_MJ_action_0010",
            "M2_MJ_action_0012",
            "M2_MJ_action_0014",
            "M2_MJ_action_0016",
            "M2_MJ_action_0018",
            "M2_MJ_action_0020",
            "M2_MJ_action_0022",
            "M2_MJ_action_0024",
            "M2_MJ_action_0026",
            "M2_MJ_action_0028",
            "M2_MJ_action_0030",
            "M2_MJ_action_0032",
            "M2_MJ_action_0034",
            "M2_MJ_action_0036",
            "M2_MJ_action_0038",
            "M2_MJ_action_0040",
            "M2_MJ_action_0042",
            "M2_MJ_action_0044",
            "M2_MJ_action_0046",
            "M2_MJ_action_0048",
            "M2_MJ_action_0050",
            "M2_MJ_action_0052",
            "M2_MJ_action_0054",
            "M2_MJ_action_0056"
        });
        AssetDatabase.CreateAsset(actionClip, "Assets/Animations/loginbg/M2_MJ_ACITION.anim");
        // AnimatorController: M_MJ
        var ctrl = AnimatorController.CreateAnimatorControllerAtPath("Assets/Animations/loginbg/M_MJ.controller");
        ctrl.AddParameter("action", AnimatorControllerParameterType.Trigger);
        var rootSM = ctrl.layers[0].stateMachine;
        var standState = rootSM.AddState("stand");
        standState.motion = standClip;
        rootSM.defaultState = standState;
        var actionState = rootSM.AddState("action");
        actionState.motion = actionClip;
        // stand → action (trigger)
        var toAction = standState.AddTransition(actionState);
        toAction.AddCondition(AnimatorConditionMode.If, 0, "action");
        toAction.hasExitTime = false;
        toAction.duration = 0;
        // action → stand (exit time)
        var toStand = actionState.AddTransition(standState);
        toStand.hasExitTime = true;
        toStand.exitTime = 1f;
        toStand.duration = 0;
        // Prefab: M_MJ
        var go = new GameObject("M_MJ", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rtComp = go.GetComponent<RectTransform>();
        rtComp.anchoredPosition = new Vector2(-228.0f, -268.0000305175781f);
        rtComp.sizeDelta = new Vector2(532.0f, 532.0f);
        rtComp.pivot = new Vector2(0.5f, 0.0f);
        rtComp.anchorMin = new Vector2(0.5f, 0.5f);
        rtComp.anchorMax = new Vector2(0.5f, 0.5f);
        var img = go.GetComponent<Image>();
        img.raycastTarget = false;
        img.sprite = FindSprite("M2_MJ_stand_0001");
        var animator = go.GetComponent<Animator>();
        animator.runtimeAnimatorController = ctrl;
        PrefabUtility.SaveAsPrefabAsset(go, "Assets/Prefabs/Imported/Avatars/M_MJ.prefab");
        Object.DestroyImmediate(go);
    }

    static void Build_M_SL()
    {
        string avatarName = "M_SL";
        // Stand clip: M2_SL (32f, 30.0fps)
        var standClip = BuildClip("M2_SL", 30.0f, 1.066666603088379f, true, new string[] {
            "M2_SL_stand_0001",
            "M2_SL_stand_0002",
            "M2_SL_stand_0003",
            "M2_SL_stand_0004",
            "M2_SL_stand_0005",
            "M2_SL_stand_0006",
            "M2_SL_stand_0007",
            "M2_SL_stand_0008",
            "M2_SL_stand_0009",
            "M2_SL_stand_0010",
            "M2_SL_stand_0011",
            "M2_SL_stand_0012",
            "M2_SL_stand_0013",
            "M2_SL_stand_0014",
            "M2_SL_stand_0015",
            "M2_SL_stand_0016",
            "M2_SL_stand_0001",
            "M2_SL_stand_0002",
            "M2_SL_stand_0003",
            "M2_SL_stand_0004",
            "M2_SL_stand_0005",
            "M2_SL_stand_0006",
            "M2_SL_stand_0007",
            "M2_SL_stand_0008",
            "M2_SL_stand_0009",
            "M2_SL_stand_0010",
            "M2_SL_stand_0011",
            "M2_SL_stand_0012",
            "M2_SL_stand_0013",
            "M2_SL_stand_0014",
            "M2_SL_stand_0015",
            "M2_SL_stand_0016"
        });
        AssetDatabase.CreateAsset(standClip, "Assets/Animations/loginbg/M2_SL.anim");
        // Action clip: M2_SL_ACTION (27f, 30.0fps)
        var actionClip = BuildClip("M2_SL_ACTION", 30.0f, 0.9000000357627869f, false, new string[] {
            "M2_SL_ACTION_0000",
            "M2_SL_ACTION_0002",
            "M2_SL_ACTION_0004",
            "M2_SL_ACTION_0006",
            "M2_SL_ACTION_0008",
            "M2_SL_ACTION_0010",
            "M2_SL_ACTION_0012",
            "M2_SL_ACTION_0014",
            "M2_SL_ACTION_0016",
            "M2_SL_ACTION_0018",
            "M2_SL_ACTION_0020",
            "M2_SL_ACTION_0022",
            "M2_SL_ACTION_0024",
            "M2_SL_ACTION_0026",
            "M2_SL_ACTION_0028",
            "M2_SL_ACTION_0030",
            "M2_SL_ACTION_0032",
            "M2_SL_ACTION_0034",
            "M2_SL_ACTION_0036",
            "M2_SL_ACTION_0038",
            "M2_SL_ACTION_0040",
            "M2_SL_ACTION_0042",
            "M2_SL_ACTION_0044",
            "M2_SL_ACTION_0046",
            "M2_SL_ACTION_0048",
            "M2_SL_ACTION_0050",
            "M2_SL_ACTION_0052"
        });
        AssetDatabase.CreateAsset(actionClip, "Assets/Animations/loginbg/M2_SL_ACTION.anim");
        // AnimatorController: M_SL
        var ctrl = AnimatorController.CreateAnimatorControllerAtPath("Assets/Animations/loginbg/M_SL.controller");
        ctrl.AddParameter("action", AnimatorControllerParameterType.Trigger);
        var rootSM = ctrl.layers[0].stateMachine;
        var standState = rootSM.AddState("stand");
        standState.motion = standClip;
        rootSM.defaultState = standState;
        var actionState = rootSM.AddState("action");
        actionState.motion = actionClip;
        // stand → action (trigger)
        var toAction = standState.AddTransition(actionState);
        toAction.AddCondition(AnimatorConditionMode.If, 0, "action");
        toAction.hasExitTime = false;
        toAction.duration = 0;
        // action → stand (exit time)
        var toStand = actionState.AddTransition(standState);
        toStand.hasExitTime = true;
        toStand.exitTime = 1f;
        toStand.duration = 0;
        // Prefab: M_SL
        var go = new GameObject("M_SL", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rtComp = go.GetComponent<RectTransform>();
        rtComp.anchoredPosition = new Vector2(-6.5f, -265.0000305175781f);
        rtComp.sizeDelta = new Vector2(448.0f, 512.0f);
        rtComp.pivot = new Vector2(0.5f, 0.0f);
        rtComp.anchorMin = new Vector2(0.5f, 0.5f);
        rtComp.anchorMax = new Vector2(0.5f, 0.5f);
        var img = go.GetComponent<Image>();
        img.raycastTarget = false;
        img.sprite = FindSprite("M2_SL_stand_0001");
        var animator = go.GetComponent<Animator>();
        animator.runtimeAnimatorController = ctrl;
        PrefabUtility.SaveAsPrefabAsset(go, "Assets/Prefabs/Imported/Avatars/M_SL.prefab");
        Object.DestroyImmediate(go);
    }

    static void Build_M_THD()
    {
        string avatarName = "M_THD";
        // Stand clip: M2_THD (15f, 30.0fps)
        var standClip = BuildClip("M2_THD", 30.0f, 0.5f, true, new string[] {
            "M2_THD_stand_0001",
            "M2_THD_stand_0002",
            "M2_THD_stand_0003",
            "M2_THD_stand_0004",
            "M2_THD_stand_0005",
            "M2_THD_stand_0006",
            "M2_THD_stand_0007",
            "M2_THD_stand_0008",
            "M2_THD_stand_0009",
            "M2_THD_stand_0010",
            "M2_THD_stand_0011",
            "M2_THD_stand_0012",
            "M2_THD_stand_0013",
            "M2_THD_stand_0014",
            "M2_THD_stand_0015"
        });
        AssetDatabase.CreateAsset(standClip, "Assets/Animations/loginbg/M2_THD.anim");
        // Action clip: M2_THD_ACTION (31f, 30.0fps)
        var actionClip = BuildClip("M2_THD_ACTION", 30.0f, 1.0333333015441895f, false, new string[] {
            "M2_THD_action_0001",
            "M2_THD_action_0003",
            "M2_THD_action_0005",
            "M2_THD_action_0007",
            "M2_THD_action_0009",
            "M2_THD_action_0011",
            "M2_THD_action_0013",
            "M2_THD_action_0015",
            "M2_THD_action_0017",
            "M2_THD_action_0019",
            "M2_THD_action_0021",
            "M2_THD_action_0023",
            "M2_THD_action_0025",
            "M2_THD_action_0027",
            "M2_THD_action_0029",
            "M2_THD_action_0031",
            "M2_THD_action_0033",
            "M2_THD_action_0035",
            "M2_THD_action_0037",
            "M2_THD_action_0039",
            "M2_THD_action_0041",
            "M2_THD_action_0043",
            "M2_THD_action_0045",
            "M2_THD_action_0047",
            "M2_THD_action_0049",
            "M2_THD_action_0051",
            "M2_THD_action_0053",
            "M2_THD_action_0055",
            "M2_THD_action_0057",
            "M2_THD_action_0059",
            "M2_THD_action_0061"
        });
        AssetDatabase.CreateAsset(actionClip, "Assets/Animations/loginbg/M2_THD_ACTION.anim");
        // AnimatorController: M_THD
        var ctrl = AnimatorController.CreateAnimatorControllerAtPath("Assets/Animations/loginbg/M_THD.controller");
        ctrl.AddParameter("action", AnimatorControllerParameterType.Trigger);
        var rootSM = ctrl.layers[0].stateMachine;
        var standState = rootSM.AddState("stand");
        standState.motion = standClip;
        rootSM.defaultState = standState;
        var actionState = rootSM.AddState("action");
        actionState.motion = actionClip;
        // stand → action (trigger)
        var toAction = standState.AddTransition(actionState);
        toAction.AddCondition(AnimatorConditionMode.If, 0, "action");
        toAction.hasExitTime = false;
        toAction.duration = 0;
        // action → stand (exit time)
        var toStand = actionState.AddTransition(standState);
        toStand.hasExitTime = true;
        toStand.exitTime = 1f;
        toStand.duration = 0;
        // Prefab: M_THD
        var go = new GameObject("M_THD", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rtComp = go.GetComponent<RectTransform>();
        rtComp.anchoredPosition = new Vector2(-207.55999755859375f, -319.0f);
        rtComp.sizeDelta = new Vector2(448.0f, 563.0f);
        rtComp.pivot = new Vector2(0.5299999713897705f, 0.0f);
        rtComp.anchorMin = new Vector2(0.5f, 0.5f);
        rtComp.anchorMax = new Vector2(0.5f, 0.5f);
        var img = go.GetComponent<Image>();
        img.raycastTarget = false;
        img.sprite = FindSprite("M2_THD_stand_0001");
        var animator = go.GetComponent<Animator>();
        animator.runtimeAnimatorController = ctrl;
        PrefabUtility.SaveAsPrefabAsset(go, "Assets/Prefabs/Imported/Avatars/M_THD.prefab");
        Object.DestroyImmediate(go);
    }

    static void Build_M_TM()
    {
        string avatarName = "M_TM";
        // Stand clip: M2_TM (32f, 30.0fps)
        var standClip = BuildClip("M2_TM", 30.0f, 1.066666603088379f, true, new string[] {
            "M2_TM_stand_0001",
            "M2_TM_stand_0002",
            "M2_TM_stand_0003",
            "M2_TM_stand_0004",
            "M2_TM_stand_0005",
            "M2_TM_stand_0006",
            "M2_TM_stand_0007",
            "M2_TM_stand_0008",
            "M2_TM_stand_0009",
            "M2_TM_stand_0010",
            "M2_TM_stand_0011",
            "M2_TM_stand_0012",
            "M2_TM_stand_0013",
            "M2_TM_stand_0014",
            "M2_TM_stand_0015",
            "M2_TM_stand_0016",
            "M2_TM_stand_0001",
            "M2_TM_stand_0002",
            "M2_TM_stand_0003",
            "M2_TM_stand_0004",
            "M2_TM_stand_0005",
            "M2_TM_stand_0006",
            "M2_TM_stand_0007",
            "M2_TM_stand_0008",
            "M2_TM_stand_0009",
            "M2_TM_stand_0010",
            "M2_TM_stand_0011",
            "M2_TM_stand_0012",
            "M2_TM_stand_0013",
            "M2_TM_stand_0014",
            "M2_TM_stand_0015",
            "M2_TM_stand_0016"
        });
        AssetDatabase.CreateAsset(standClip, "Assets/Animations/loginbg/M2_TM.anim");
        // Action clip: M2_TM_ACTION (40f, 30.0fps)
        var actionClip = BuildClip("M2_TM_ACTION", 30.0f, 1.3333332538604736f, false, new string[] {
            "M2_TM_action_0000",
            "M2_TM_action_0002",
            "M2_TM_action_0004",
            "M2_TM_action_0006",
            "M2_TM_action_0008",
            "M2_TM_action_0010",
            "M2_TM_action_0012",
            "M2_TM_action_0014",
            "M2_TM_action_0016",
            "M2_TM_action_0018",
            "M2_TM_action_0020",
            "M2_TM_action_0022",
            "M2_TM_action_0024",
            "M2_TM_action_0026",
            "M2_TM_action_0028",
            "M2_TM_action_0030",
            "M2_TM_action_0032",
            "M2_TM_action_0034",
            "M2_TM_action_0036",
            "M2_TM_action_0038",
            "M2_TM_action_0040",
            "M2_TM_action_0042",
            "M2_TM_action_0044",
            "M2_TM_action_0046",
            "M2_TM_action_0048",
            "M2_TM_action_0050",
            "M2_TM_action_0052",
            "M2_TM_action_0054",
            "M2_TM_action_0056",
            "M2_TM_action_0058",
            "M2_TM_action_0060",
            "M2_TM_action_0062",
            "M2_TM_action_0064",
            "M2_TM_action_0066",
            "M2_TM_action_0068",
            "M2_TM_action_0070",
            "M2_TM_action_0072",
            "M2_TM_action_0074",
            "M2_TM_action_0076",
            "M2_TM_action_0078"
        });
        AssetDatabase.CreateAsset(actionClip, "Assets/Animations/loginbg/M2_TM_ACTION.anim");
        // AnimatorController: M_TM
        var ctrl = AnimatorController.CreateAnimatorControllerAtPath("Assets/Animations/loginbg/M_TM.controller");
        ctrl.AddParameter("action", AnimatorControllerParameterType.Trigger);
        var rootSM = ctrl.layers[0].stateMachine;
        var standState = rootSM.AddState("stand");
        standState.motion = standClip;
        rootSM.defaultState = standState;
        var actionState = rootSM.AddState("action");
        actionState.motion = actionClip;
        // stand → action (trigger)
        var toAction = standState.AddTransition(actionState);
        toAction.AddCondition(AnimatorConditionMode.If, 0, "action");
        toAction.hasExitTime = false;
        toAction.duration = 0;
        // action → stand (exit time)
        var toStand = actionState.AddTransition(standState);
        toStand.hasExitTime = true;
        toStand.exitTime = 1f;
        toStand.duration = 0;
        // Prefab: M_TM
        var go = new GameObject("M_TM", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rtComp = go.GetComponent<RectTransform>();
        rtComp.anchoredPosition = new Vector2(-211.0f, -276.0f);
        rtComp.sizeDelta = new Vector2(384.0f, 512.0f);
        rtComp.pivot = new Vector2(0.5f, 0.0f);
        rtComp.anchorMin = new Vector2(0.5f, 0.5f);
        rtComp.anchorMax = new Vector2(0.5f, 0.5f);
        var img = go.GetComponent<Image>();
        img.raycastTarget = false;
        img.sprite = FindSprite("M2_TM_stand_0001");
        var animator = go.GetComponent<Animator>();
        animator.runtimeAnimatorController = ctrl;
        PrefabUtility.SaveAsPrefabAsset(go, "Assets/Prefabs/Imported/Avatars/M_TM.prefab");
        Object.DestroyImmediate(go);
    }

    static void Build_M_TR()
    {
        string avatarName = "M_TR";
        // Stand clip: M2_TR (32f, 30.0fps)
        var standClip = BuildClip("M2_TR", 30.0f, 1.066666603088379f, true, new string[] {
            "M2_TR_stand_0001",
            "M2_TR_stand_0002",
            "M2_TR_stand_0003",
            "M2_TR_stand_0004",
            "M2_TR_stand_0005",
            "M2_TR_stand_0006",
            "M2_TR_stand_0007",
            "M2_TR_stand_0008",
            "M2_TR_stand_0009",
            "M2_TR_stand_0010",
            "M2_TR_stand_0011",
            "M2_TR_stand_0012",
            "M2_TR_stand_0013",
            "M2_TR_stand_0014",
            "M2_TR_stand_0015",
            "M2_TR_stand_0016",
            "M2_TR_stand_0001",
            "M2_TR_stand_0002",
            "M2_TR_stand_0003",
            "M2_TR_stand_0004",
            "M2_TR_stand_0005",
            "M2_TR_stand_0006",
            "M2_TR_stand_0007",
            "M2_TR_stand_0008",
            "M2_TR_stand_0009",
            "M2_TR_stand_0010",
            "M2_TR_stand_0011",
            "M2_TR_stand_0012",
            "M2_TR_stand_0013",
            "M2_TR_stand_0014",
            "M2_TR_stand_0015",
            "M2_TR_stand_0016"
        });
        AssetDatabase.CreateAsset(standClip, "Assets/Animations/loginbg/M2_TR.anim");
        // Action clip: M2_TR_ACTION (31f, 30.0fps)
        var actionClip = BuildClip("M2_TR_ACTION", 30.0f, 1.0333333015441895f, false, new string[] {
            "M2_TR_action_0001",
            "M2_TR_action_0003",
            "M2_TR_action_0005",
            "M2_TR_action_0007",
            "M2_TR_action_0009",
            "M2_TR_action_0011",
            "M2_TR_action_0013",
            "M2_TR_action_0015",
            "M2_TR_action_0017",
            "M2_TR_action_0019",
            "M2_TR_action_0021",
            "M2_TR_action_0023",
            "M2_TR_action_0025",
            "M2_TR_action_0027",
            "M2_TR_action_0029",
            "M2_TR_action_0031",
            "M2_TR_action_0033",
            "M2_TR_action_0035",
            "M2_TR_action_0037",
            "M2_TR_action_0039",
            "M2_TR_action_0041",
            "M2_TR_action_0043",
            "M2_TR_action_0045",
            "M2_TR_action_0047",
            "M2_TR_action_0049",
            "M2_TR_action_0051",
            "M2_TR_action_0053",
            "M2_TR_action_0055",
            "M2_TR_action_0057",
            "M2_TR_action_0059",
            "M2_TR_action_0061"
        });
        AssetDatabase.CreateAsset(actionClip, "Assets/Animations/loginbg/M2_TR_ACTION.anim");
        // AnimatorController: M_TR
        var ctrl = AnimatorController.CreateAnimatorControllerAtPath("Assets/Animations/loginbg/M_TR.controller");
        ctrl.AddParameter("action", AnimatorControllerParameterType.Trigger);
        var rootSM = ctrl.layers[0].stateMachine;
        var standState = rootSM.AddState("stand");
        standState.motion = standClip;
        rootSM.defaultState = standState;
        var actionState = rootSM.AddState("action");
        actionState.motion = actionClip;
        // stand → action (trigger)
        var toAction = standState.AddTransition(actionState);
        toAction.AddCondition(AnimatorConditionMode.If, 0, "action");
        toAction.hasExitTime = false;
        toAction.duration = 0;
        // action → stand (exit time)
        var toStand = actionState.AddTransition(standState);
        toStand.hasExitTime = true;
        toStand.exitTime = 1f;
        toStand.duration = 0;
        // Prefab: M_TR
        var go = new GameObject("M_TR", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rtComp = go.GetComponent<RectTransform>();
        rtComp.anchoredPosition = new Vector2(-174.199951171875f, -389.0f);
        rtComp.sizeDelta = new Vector2(798.0f, 798.0f);
        rtComp.pivot = new Vector2(0.6000000238418579f, 0.0f);
        rtComp.anchorMin = new Vector2(0.5f, 0.5f);
        rtComp.anchorMax = new Vector2(0.5f, 0.5f);
        var img = go.GetComponent<Image>();
        img.raycastTarget = false;
        img.sprite = FindSprite("M2_TR_stand_0001");
        var animator = go.GetComponent<Animator>();
        animator.runtimeAnimatorController = ctrl;
        PrefabUtility.SaveAsPrefabAsset(go, "Assets/Prefabs/Imported/Avatars/M_TR.prefab");
        Object.DestroyImmediate(go);
    }

    static void Build_M_TW()
    {
        string avatarName = "M_TW";
        // Stand clip: M2_TW (32f, 30.0fps)
        var standClip = BuildClip("M2_TW", 30.0f, 1.066666603088379f, true, new string[] {
            "M2_TW_stand_0001",
            "M2_TW_stand_0002",
            "M2_TW_stand_0003",
            "M2_TW_stand_0004",
            "M2_TW_stand_0005",
            "M2_TW_stand_0006",
            "M2_TW_stand_0007",
            "M2_TW_stand_0008",
            "M2_TW_stand_0009",
            "M2_TW_stand_0010",
            "M2_TW_stand_0011",
            "M2_TW_stand_0012",
            "M2_TW_stand_0013",
            "M2_TW_stand_0014",
            "M2_TW_stand_0015",
            "M2_TW_stand_0016",
            "M2_TW_stand_0001",
            "M2_TW_stand_0002",
            "M2_TW_stand_0003",
            "M2_TW_stand_0004",
            "M2_TW_stand_0005",
            "M2_TW_stand_0006",
            "M2_TW_stand_0007",
            "M2_TW_stand_0008",
            "M2_TW_stand_0009",
            "M2_TW_stand_0010",
            "M2_TW_stand_0011",
            "M2_TW_stand_0012",
            "M2_TW_stand_0013",
            "M2_TW_stand_0014",
            "M2_TW_stand_0015",
            "M2_TW_stand_0016"
        });
        AssetDatabase.CreateAsset(standClip, "Assets/Animations/loginbg/M2_TW.anim");
        // Action clip: M2_TW_ACTION (31f, 30.0fps)
        var actionClip = BuildClip("M2_TW_ACTION", 30.0f, 1.0333333015441895f, false, new string[] {
            "M2_TW_action_0001",
            "M2_TW_action_0003",
            "M2_TW_action_0005",
            "M2_TW_action_0007",
            "M2_TW_action_0009",
            "M2_TW_action_0011",
            "M2_TW_action_0013",
            "M2_TW_action_0015",
            "M2_TW_action_0017",
            "M2_TW_action_0019",
            "M2_TW_action_0021",
            "M2_TW_action_0023",
            "M2_TW_action_0025",
            "M2_TW_action_0027",
            "M2_TW_action_0029",
            "M2_TW_action_0031",
            "M2_TW_action_0033",
            "M2_TW_action_0035",
            "M2_TW_action_0037",
            "M2_TW_action_0039",
            "M2_TW_action_0041",
            "M2_TW_action_0043",
            "M2_TW_action_0045",
            "M2_TW_action_0047",
            "M2_TW_action_0049",
            "M2_TW_action_0051",
            "M2_TW_action_0053",
            "M2_TW_action_0055",
            "M2_TW_action_0057",
            "M2_TW_action_0059",
            "M2_TW_action_0061"
        });
        AssetDatabase.CreateAsset(actionClip, "Assets/Animations/loginbg/M2_TW_ACTION.anim");
        // AnimatorController: M_TW
        var ctrl = AnimatorController.CreateAnimatorControllerAtPath("Assets/Animations/loginbg/M_TW.controller");
        ctrl.AddParameter("action", AnimatorControllerParameterType.Trigger);
        var rootSM = ctrl.layers[0].stateMachine;
        var standState = rootSM.AddState("stand");
        standState.motion = standClip;
        rootSM.defaultState = standState;
        var actionState = rootSM.AddState("action");
        actionState.motion = actionClip;
        // stand → action (trigger)
        var toAction = standState.AddTransition(actionState);
        toAction.AddCondition(AnimatorConditionMode.If, 0, "action");
        toAction.hasExitTime = false;
        toAction.duration = 0;
        // action → stand (exit time)
        var toStand = actionState.AddTransition(standState);
        toStand.hasExitTime = true;
        toStand.exitTime = 1f;
        toStand.duration = 0;
        // Prefab: M_TW
        var go = new GameObject("M_TW", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rtComp = go.GetComponent<RectTransform>();
        rtComp.anchoredPosition = new Vector2(-202.0f, -322.5f);
        rtComp.sizeDelta = new Vector2(839.0f, 672.0f);
        rtComp.pivot = new Vector2(0.5f, 0.0f);
        rtComp.anchorMin = new Vector2(0.5f, 0.5f);
        rtComp.anchorMax = new Vector2(0.5f, 0.5f);
        var img = go.GetComponent<Image>();
        img.raycastTarget = false;
        img.sprite = FindSprite("M2_TW_stand_0001");
        var animator = go.GetComponent<Animator>();
        animator.runtimeAnimatorController = ctrl;
        PrefabUtility.SaveAsPrefabAsset(go, "Assets/Prefabs/Imported/Avatars/M_TW.prefab");
        Object.DestroyImmediate(go);
    }

    static void Build_M_WD()
    {
        string avatarName = "M_WD";
        // Stand clip: M2_WD (32f, 30.0fps)
        var standClip = BuildClip("M2_WD", 30.0f, 1.066666603088379f, true, new string[] {
            "M2_WD_stand_0001",
            "M2_WD_stand_0002",
            "M2_WD_stand_0003",
            "M2_WD_stand_0004",
            "M2_WD_stand_0005",
            "M2_WD_stand_0006",
            "M2_WD_stand_0007",
            "M2_WD_stand_0008",
            "M2_WD_stand_0009",
            "M2_WD_stand_0010",
            "M2_WD_stand_0011",
            "M2_WD_stand_0012",
            "M2_WD_stand_0013",
            "M2_WD_stand_0014",
            "M2_WD_stand_0015",
            "M2_WD_stand_0016",
            "M2_WD_stand_0001",
            "M2_WD_stand_0002",
            "M2_WD_stand_0003",
            "M2_WD_stand_0004",
            "M2_WD_stand_0005",
            "M2_WD_stand_0006",
            "M2_WD_stand_0007",
            "M2_WD_stand_0008",
            "M2_WD_stand_0009",
            "M2_WD_stand_0010",
            "M2_WD_stand_0011",
            "M2_WD_stand_0012",
            "M2_WD_stand_0013",
            "M2_WD_stand_0014",
            "M2_WD_stand_0015",
            "M2_WD_stand_0016"
        });
        AssetDatabase.CreateAsset(standClip, "Assets/Animations/loginbg/M2_WD.anim");
        // Action clip: M2_WD_ACTION (31f, 30.0fps)
        var actionClip = BuildClip("M2_WD_ACTION", 30.0f, 1.0333333015441895f, false, new string[] {
            "M2_WD_action_0001",
            "M2_WD_action_0003",
            "M2_WD_action_0005",
            "M2_WD_action_0007",
            "M2_WD_action_0009",
            "M2_WD_action_0011",
            "M2_WD_action_0013",
            "M2_WD_action_0015",
            "M2_WD_action_0017",
            "M2_WD_action_0019",
            "M2_WD_action_0021",
            "M2_WD_action_0023",
            "M2_WD_action_0025",
            "M2_WD_action_0027",
            "M2_WD_action_0029",
            "M2_WD_action_0031",
            "M2_WD_action_0033",
            "M2_WD_action_0035",
            "M2_WD_action_0037",
            "M2_WD_action_0039",
            "M2_WD_action_0041",
            "M2_WD_action_0043",
            "M2_WD_action_0045",
            "M2_WD_action_0047",
            "M2_WD_action_0049",
            "M2_WD_action_0051",
            "M2_WD_action_0053",
            "M2_WD_action_0055",
            "M2_WD_action_0057",
            "M2_WD_action_0059",
            "M2_WD_action_0061"
        });
        AssetDatabase.CreateAsset(actionClip, "Assets/Animations/loginbg/M2_WD_ACTION.anim");
        // AnimatorController: M_WD
        var ctrl = AnimatorController.CreateAnimatorControllerAtPath("Assets/Animations/loginbg/M_WD.controller");
        ctrl.AddParameter("action", AnimatorControllerParameterType.Trigger);
        var rootSM = ctrl.layers[0].stateMachine;
        var standState = rootSM.AddState("stand");
        standState.motion = standClip;
        rootSM.defaultState = standState;
        var actionState = rootSM.AddState("action");
        actionState.motion = actionClip;
        // stand → action (trigger)
        var toAction = standState.AddTransition(actionState);
        toAction.AddCondition(AnimatorConditionMode.If, 0, "action");
        toAction.hasExitTime = false;
        toAction.duration = 0;
        // action → stand (exit time)
        var toStand = actionState.AddTransition(standState);
        toStand.hasExitTime = true;
        toStand.exitTime = 1f;
        toStand.duration = 0;
        // Prefab: M_WD
        var go = new GameObject("M_WD", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rtComp = go.GetComponent<RectTransform>();
        rtComp.anchoredPosition = new Vector2(-235.0f, -311.5f);
        rtComp.sizeDelta = new Vector2(583.0f, 583.0f);
        rtComp.pivot = new Vector2(0.5f, 0.0f);
        rtComp.anchorMin = new Vector2(0.5f, 0.5f);
        rtComp.anchorMax = new Vector2(0.5f, 0.5f);
        var img = go.GetComponent<Image>();
        img.raycastTarget = false;
        img.sprite = FindSprite("M2_WD_stand_0001");
        var animator = go.GetComponent<Animator>();
        animator.runtimeAnimatorController = ctrl;
        PrefabUtility.SaveAsPrefabAsset(go, "Assets/Prefabs/Imported/Avatars/M_WD.prefab");
        Object.DestroyImmediate(go);
    }

    static void Build_M_WHT()
    {
        string avatarName = "M_WHT";
        // Stand clip: M2_WHT (15f, 30.0fps)
        var standClip = BuildClip("M2_WHT", 30.0f, 0.5f, true, new string[] {
            "M2_WHT_stand_0001",
            "M2_WHT_stand_0002",
            "M2_WHT_stand_0003",
            "M2_WHT_stand_0004",
            "M2_WHT_stand_0005",
            "M2_WHT_stand_0006",
            "M2_WHT_stand_0007",
            "M2_WHT_stand_0008",
            "M2_WHT_stand_0009",
            "M2_WHT_stand_0010",
            "M2_WHT_stand_0011",
            "M2_WHT_stand_0012",
            "M2_WHT_stand_0013",
            "M2_WHT_stand_0014",
            "M2_WHT_stand_0015"
        });
        AssetDatabase.CreateAsset(standClip, "Assets/Animations/loginbg/M2_WHT.anim");
        // Action clip: M2_WHT_ACTION (31f, 30.0fps)
        var actionClip = BuildClip("M2_WHT_ACTION", 30.0f, 1.0333333015441895f, false, new string[] {
            "M2_WHT_action_0001",
            "M2_WHT_action_0002",
            "M2_WHT_action_0003",
            "M2_WHT_action_0004",
            "M2_WHT_action_0005",
            "M2_WHT_action_0006",
            "M2_WHT_action_0007",
            "M2_WHT_action_0008",
            "M2_WHT_action_0009",
            "M2_WHT_action_0010",
            "M2_WHT_action_0011",
            "M2_WHT_action_0012",
            "M2_WHT_action_0013",
            "M2_WHT_action_0014",
            "M2_WHT_action_0015",
            "M2_WHT_action_0016",
            "M2_WHT_action_0017",
            "M2_WHT_action_0018",
            "M2_WHT_action_0019",
            "M2_WHT_action_0020",
            "M2_WHT_action_0021",
            "M2_WHT_action_0022",
            "M2_WHT_action_0023",
            "M2_WHT_action_0024",
            "M2_WHT_action_0025",
            "M2_WHT_action_0026",
            "M2_WHT_action_0027",
            "M2_WHT_action_0028",
            "M2_WHT_action_0029",
            "M2_WHT_action_0030",
            "M2_WHT_action_0031"
        });
        AssetDatabase.CreateAsset(actionClip, "Assets/Animations/loginbg/M2_WHT_ACTION.anim");
        // AnimatorController: M_WHT
        var ctrl = AnimatorController.CreateAnimatorControllerAtPath("Assets/Animations/loginbg/M_WHT.controller");
        ctrl.AddParameter("action", AnimatorControllerParameterType.Trigger);
        var rootSM = ctrl.layers[0].stateMachine;
        var standState = rootSM.AddState("stand");
        standState.motion = standClip;
        rootSM.defaultState = standState;
        var actionState = rootSM.AddState("action");
        actionState.motion = actionClip;
        // stand → action (trigger)
        var toAction = standState.AddTransition(actionState);
        toAction.AddCondition(AnimatorConditionMode.If, 0, "action");
        toAction.hasExitTime = false;
        toAction.duration = 0;
        // action → stand (exit time)
        var toStand = actionState.AddTransition(standState);
        toStand.hasExitTime = true;
        toStand.exitTime = 1f;
        toStand.duration = 0;
        // Prefab: M_WHT
        var go = new GameObject("M_WHT", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rtComp = go.GetComponent<RectTransform>();
        rtComp.anchoredPosition = new Vector2(-180.0f, -240.0f);
        rtComp.sizeDelta = new Vector2(677.0f, 849.0f);
        rtComp.pivot = new Vector2(0.6000000238418579f, 0.2199999988079071f);
        rtComp.anchorMin = new Vector2(0.5f, 0.5f);
        rtComp.anchorMax = new Vector2(0.5f, 0.5f);
        var img = go.GetComponent<Image>();
        img.raycastTarget = false;
        img.sprite = FindSprite("M2_WHT_stand_0001");
        var animator = go.GetComponent<Animator>();
        animator.runtimeAnimatorController = ctrl;
        PrefabUtility.SaveAsPrefabAsset(go, "Assets/Prefabs/Imported/Avatars/M_WHT.prefab");
        Object.DestroyImmediate(go);
    }

    static void Build_M_XY()
    {
        string avatarName = "M_XY";
        // Stand clip: M2_XY (15f, 30.0fps)
        var standClip = BuildClip("M2_XY", 30.0f, 0.5f, true, new string[] {
            "M2_XY_stand_0001",
            "M2_XY_stand_0002",
            "M2_XY_stand_0003",
            "M2_XY_stand_0004",
            "M2_XY_stand_0005",
            "M2_XY_stand_0006",
            "M2_XY_stand_0007",
            "M2_XY_stand_0008",
            "M2_XY_stand_0009",
            "M2_XY_stand_0010",
            "M2_XY_stand_0011",
            "M2_XY_stand_0012",
            "M2_XY_stand_0013",
            "M2_XY_stand_0014",
            "M2_XY_stand_0015"
        });
        AssetDatabase.CreateAsset(standClip, "Assets/Animations/loginbg/M2_XY.anim");
        // Action clip: M2_XY_ACTION (35f, 30.0fps)
        var actionClip = BuildClip("M2_XY_ACTION", 30.0f, 1.1666666269302368f, false, new string[] {
            "M2_XY_action_0001",
            "M2_XY_action_0003",
            "M2_XY_action_0005",
            "M2_XY_action_0007",
            "M2_XY_action_0009",
            "M2_XY_action_0011",
            "M2_XY_action_0013",
            "M2_XY_action_0015",
            "M2_XY_action_0017",
            "M2_XY_action_0019",
            "M2_XY_action_0021",
            "M2_XY_action_0023",
            "M2_XY_action_0025",
            "M2_XY_action_0027",
            "M2_XY_action_0029",
            "M2_XY_action_0031",
            "M2_XY_action_0033",
            "M2_XY_action_0035",
            "M2_XY_action_0037",
            "M2_XY_action_0039",
            "M2_XY_action_0041",
            "M2_XY_action_0043",
            "M2_XY_action_0045",
            "M2_XY_action_0047",
            "M2_XY_action_0049",
            "M2_XY_action_0051",
            "M2_XY_action_0053",
            "M2_XY_action_0054",
            "M2_XY_action_0055",
            "M2_XY_action_0056",
            "M2_XY_action_0057",
            "M2_XY_action_0058",
            "M2_XY_action_0059",
            "M2_XY_action_0060",
            "M2_XY_action_0061"
        });
        AssetDatabase.CreateAsset(actionClip, "Assets/Animations/loginbg/M2_XY_ACTION.anim");
        // AnimatorController: M_XY
        var ctrl = AnimatorController.CreateAnimatorControllerAtPath("Assets/Animations/loginbg/M_XY.controller");
        ctrl.AddParameter("action", AnimatorControllerParameterType.Trigger);
        var rootSM = ctrl.layers[0].stateMachine;
        var standState = rootSM.AddState("stand");
        standState.motion = standClip;
        rootSM.defaultState = standState;
        var actionState = rootSM.AddState("action");
        actionState.motion = actionClip;
        // stand → action (trigger)
        var toAction = standState.AddTransition(actionState);
        toAction.AddCondition(AnimatorConditionMode.If, 0, "action");
        toAction.hasExitTime = false;
        toAction.duration = 0;
        // action → stand (exit time)
        var toStand = actionState.AddTransition(standState);
        toStand.hasExitTime = true;
        toStand.exitTime = 1f;
        toStand.duration = 0;
        // Prefab: M_XY
        var go = new GameObject("M_XY", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rtComp = go.GetComponent<RectTransform>();
        rtComp.anchoredPosition = new Vector2(-247.4000244140625f, -298.0f);
        rtComp.sizeDelta = new Vector2(716.0f, 716.0f);
        rtComp.pivot = new Vector2(0.5f, 0.0f);
        rtComp.anchorMin = new Vector2(0.5f, 0.5f);
        rtComp.anchorMax = new Vector2(0.5f, 0.5f);
        var img = go.GetComponent<Image>();
        img.raycastTarget = false;
        img.sprite = FindSprite("M2_XY_stand_0001");
        var animator = go.GetComponent<Animator>();
        animator.runtimeAnimatorController = ctrl;
        PrefabUtility.SaveAsPrefabAsset(go, "Assets/Prefabs/Imported/Avatars/M_XY.prefab");
        Object.DestroyImmediate(go);
    }

    static void Build_M_YP()
    {
        string avatarName = "M_YP";
        // Stand clip: M2_YP (16f, 30.0fps)
        var standClip = BuildClip("M2_YP", 30.0f, 0.5333333611488342f, true, new string[] {
            "M2_YP_stand_0001",
            "M2_YP_stand_0002",
            "M2_YP_stand_0003",
            "M2_YP_stand_0004",
            "M2_YP_stand_0005",
            "M2_YP_stand_0006",
            "M2_YP_stand_0007",
            "M2_YP_stand_0008",
            "M2_YP_stand_0009",
            "M2_YP_stand_0010",
            "M2_YP_stand_0011",
            "M2_YP_stand_0012",
            "M2_YP_stand_0013",
            "M2_YP_stand_0014",
            "M2_YP_stand_0015",
            "M2_YP_stand_0016"
        });
        AssetDatabase.CreateAsset(standClip, "Assets/Animations/loginbg/M2_YP.anim");
        // Action clip: M2_YP_ACTION (36f, 30.0fps)
        var actionClip = BuildClip("M2_YP_ACTION", 30.0f, 1.1999999284744263f, false, new string[] {
            "M2_YP_action_0001",
            "M2_YP_action_0002",
            "M2_YP_action_0003",
            "M2_YP_action_0004",
            "M2_YP_action_0005",
            "M2_YP_action_0006",
            "M2_YP_action_0007",
            "M2_YP_action_0008",
            "M2_YP_action_0009",
            "M2_YP_action_0010",
            "M2_YP_action_0011",
            "M2_YP_action_0012",
            "M2_YP_action_0013",
            "M2_YP_action_0014",
            "M2_YP_action_0015",
            "M2_YP_action_0016",
            "M2_YP_action_0017",
            "M2_YP_action_0018",
            "M2_YP_action_0019",
            "M2_YP_action_0020",
            "M2_YP_action_0021",
            "M2_YP_action_0022",
            "M2_YP_action_0023",
            "M2_YP_action_0024",
            "M2_YP_action_0025",
            "M2_YP_action_0026",
            "M2_YP_action_0027",
            "M2_YP_action_0028",
            "M2_YP_action_0029",
            "M2_YP_action_0030",
            "M2_YP_action_0031",
            "M2_YP_action_0032",
            "M2_YP_action_0033",
            "M2_YP_action_0034",
            "M2_YP_action_0035",
            "M2_YP_action_0036"
        });
        AssetDatabase.CreateAsset(actionClip, "Assets/Animations/loginbg/M2_YP_ACTION.anim");
        // AnimatorController: M_YP
        var ctrl = AnimatorController.CreateAnimatorControllerAtPath("Assets/Animations/loginbg/M_YP.controller");
        ctrl.AddParameter("action", AnimatorControllerParameterType.Trigger);
        var rootSM = ctrl.layers[0].stateMachine;
        var standState = rootSM.AddState("stand");
        standState.motion = standClip;
        rootSM.defaultState = standState;
        var actionState = rootSM.AddState("action");
        actionState.motion = actionClip;
        // stand → action (trigger)
        var toAction = standState.AddTransition(actionState);
        toAction.AddCondition(AnimatorConditionMode.If, 0, "action");
        toAction.hasExitTime = false;
        toAction.duration = 0;
        // action → stand (exit time)
        var toStand = actionState.AddTransition(standState);
        toStand.hasExitTime = true;
        toStand.exitTime = 1f;
        toStand.duration = 0;
        // Prefab: M_YP
        var go = new GameObject("M_YP", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Animator));
        var rtComp = go.GetComponent<RectTransform>();
        rtComp.anchoredPosition = new Vector2(-207.0f, -299.29998779296875f);
        rtComp.sizeDelta = new Vector2(456.0f, 573.0f);
        rtComp.pivot = new Vector2(0.5f, 0.0f);
        rtComp.anchorMin = new Vector2(0.5f, 0.5f);
        rtComp.anchorMax = new Vector2(0.5f, 0.5f);
        var img = go.GetComponent<Image>();
        img.raycastTarget = false;
        img.sprite = FindSprite("M2_YP_stand_0001");
        var animator = go.GetComponent<Animator>();
        animator.runtimeAnimatorController = ctrl;
        PrefabUtility.SaveAsPrefabAsset(go, "Assets/Prefabs/Imported/Avatars/M_YP.prefab");
        Object.DestroyImmediate(go);
    }

    static AnimationClip BuildClip(string clipName, float sampleRate, float stopTime, bool loop, string[] spriteNames)
    {
        var clip = new AnimationClip();
        clip.name = clipName;
        clip.frameRate = sampleRate;
        // Set loop
        var settings = AnimationUtility.GetAnimationClipSettings(clip);
        settings.loopTime = loop;
        AnimationUtility.SetAnimationClipSettings(clip, settings);
        // Build PPtrCurve keyframes (sprite swap on Image.m_Sprite)
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

    static Sprite FindSprite(string spriteName)
    {
        string path = "Assets/Sprite/loginbg/" + spriteName + ".png";
        var sprite = AssetDatabase.LoadAssetAtPath<Sprite>(path);
        if (sprite != null) return sprite;
        // Fallback: search by name
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