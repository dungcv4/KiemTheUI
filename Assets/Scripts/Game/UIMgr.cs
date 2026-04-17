using System.Collections;
using UnityEngine;

namespace KTO.Game
{
    public class UIMgr : MonoBehaviour
    {
        public static UIMgr Instance { get; private set; }

        public Camera UICamera;
        public GameObject[] HudPrefabs;

        Transform _hudRoot;

        void Awake()
        {
            if (Instance != null && Instance != this) { Destroy(this); return; }
            Instance = this;
        }

        public IEnumerator LoadHudAsync()
        {
            if (UICamera == null)
            {
                var go = GameObject.FindGameObjectWithTag("UICamera");
                if (go != null) UICamera = go.GetComponent<Camera>();
            }
            if (UICamera == null)
            {
                Debug.LogError("[UIMgr] UICamera not found");
                yield break;
            }

            _hudRoot = new GameObject("HudRoot").transform;
            _hudRoot.localPosition = Vector3.zero;
            _hudRoot.localRotation = Quaternion.identity;
            _hudRoot.localScale = Vector3.one;

            if (HudPrefabs == null)
            {
                Debug.LogWarning("[UIMgr] HudPrefabs list empty");
                yield break;
            }

            int uiLayer = LayerMask.NameToLayer("UI");
            int spawned = 0;
            foreach (var prefab in HudPrefabs)
            {
                if (prefab == null) continue;
                var inst = Instantiate(prefab, _hudRoot);
                inst.name = prefab.name;
                SetLayerRecursive(inst, uiLayer);
                var canvas = inst.GetComponent<Canvas>();
                if (canvas != null)
                {
                    // Imported KTO prefabs arrive as WorldSpace Canvas; the original
                    // game re-assigns ScreenSpaceCamera at instantiate time. Force
                    // the render mode + hook our UICamera so the HUD actually draws.
                    canvas.renderMode = RenderMode.ScreenSpaceCamera;
                    canvas.worldCamera = UICamera;
                    canvas.planeDistance = 10f;
                    canvas.sortingLayerName = "Default";
                    canvas.sortingOrder = 0;

                    // CanvasScaler sizeDelta comes from reference resolution; force
                    // a rebuild so the Canvas isn't 0x0.
                    var rt = inst.transform as RectTransform;
                    if (rt != null)
                    {
                        rt.anchorMin = Vector2.zero;
                        rt.anchorMax = Vector2.one;
                        rt.offsetMin = Vector2.zero;
                        rt.offsetMax = Vector2.zero;
                    }
                }
                spawned++;
                yield return null;
            }
            Debug.Log($"[UIMgr] Instantiated {spawned} HUD prefabs under HudRoot");
        }

        static void SetLayerRecursive(GameObject go, int layer)
        {
            if (layer < 0) return;
            go.layer = layer;
            foreach (Transform child in go.transform)
                SetLayerRecursive(child.gameObject, layer);
        }
    }
}
