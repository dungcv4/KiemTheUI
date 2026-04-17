using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace KTO.Game
{
    public class SceneLoadManager : MonoBehaviour
    {
        public static SceneLoadManager Instance { get; private set; }

        public static readonly Dictionary<int, string> MapTable = new Dictionary<int, string>
        {
            { 1, "yunzhongzhen1_a" },
        };

        public int CurrentMapCode { get; private set; }
        public string CurrentMapScene { get; private set; }

        void Awake()
        {
            if (Instance != null && Instance != this) { Destroy(this); return; }
            Instance = this;
        }

        public IEnumerator LoadMapAsync(int mapCode, System.Action onDone = null)
        {
            if (!MapTable.TryGetValue(mapCode, out var sceneName))
            {
                Debug.LogError($"[SceneLoad] Unknown map code {mapCode}");
                yield break;
            }

            if (!string.IsNullOrEmpty(CurrentMapScene) && CurrentMapScene != sceneName)
            {
                var unload = SceneManager.UnloadSceneAsync(CurrentMapScene);
                if (unload != null) yield return unload;
            }

            var alreadyLoaded = SceneManager.GetSceneByName(sceneName);
            if (!alreadyLoaded.IsValid() || !alreadyLoaded.isLoaded)
            {
                var op = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
                if (op == null)
                {
                    Debug.LogError($"[SceneLoad] LoadSceneAsync returned null for '{sceneName}'. Check Build Settings.");
                    yield break;
                }
                yield return op;
            }

            CurrentMapCode = mapCode;
            CurrentMapScene = sceneName;
            Debug.Log($"[SceneLoad] Loaded map {mapCode} = '{sceneName}'");
            onDone?.Invoke();
        }
    }
}
