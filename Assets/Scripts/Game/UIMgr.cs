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
                if (canvas != null && canvas.renderMode == RenderMode.ScreenSpaceCamera && canvas.worldCamera == null)
                    canvas.worldCamera = UICamera;
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
