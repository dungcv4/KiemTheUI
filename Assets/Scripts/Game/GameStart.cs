using System.Collections;
using UnityEngine;
using KTO.Network;

namespace KTO.Game
{
    public class GameStart : MonoBehaviour
    {
        public int InitialMapCode = 1;

        [Header("Player spawn")]
        public bool      SpawnPlayerOnStart = true;
        public Vector3   PlayerSpawnPos     = new Vector3(43.36f, 25.76f, 0f);
        public int       PlayerClassId      = 1;
        public string    PlayerVariant      = "free";
        public string    PlayerGender       = "m";
        public string    PlayerClassCode    = "ma_000a";

        IEnumerator Start()
        {
            if (UIMgr.Instance == null)
            {
                Debug.LogError("[GameStart] UIMgr.Instance null — add UIMgr to this GameObject");
                yield break;
            }
            if (SceneLoadManager.Instance == null)
            {
                Debug.LogError("[GameStart] SceneLoadManager.Instance null — add SceneLoadManager to this GameObject");
                yield break;
            }

            // Phase 9.3: Initialize layer IDs + NPC entity system
            // Source: GameDefine.cctor resolves layers via LayerMask.NameToLayer
            //         NpcManager.Init creates NpcRoot/PlayerRoot/MeRoot
            GameDefine.Init();
            NpcManager.Init();

            // Phase 9.3: Ensure NpcNetworkHandler exists for server NPC packets
            // It's a DontDestroyOnLoad singleton — created once, survives scene loads.
            if (NpcNetworkHandler.Instance == null)
            {
                var handlerGo = new GameObject("[NpcNetworkHandler]");
                handlerGo.AddComponent<NpcNetworkHandler>();
            }

            yield return UIMgr.Instance.LoadHudAsync();
            yield return SceneLoadManager.Instance.LoadMapAsync(InitialMapCode);

            if (SpawnPlayerOnStart)
            {
                var player = PlayerAssembler.Spawn(PlayerSpawnPos, PlayerClassId, PlayerVariant, PlayerGender, PlayerClassCode);
                player.gameObject.AddComponent<PlayerInputController>();
                Debug.Log($"[GameStart] Player spawned at {player.transform.position}");
                HookCamera(player.transform);
            }

            Debug.Log("[GameStart] Bootstrap complete");
        }

        static void HookCamera(Transform target)
        {
            var sceneCamGo = GameObject.Find("SceneCamera");
            if (sceneCamGo == null)
            {
                Debug.LogWarning("[GameStart] SceneCamera not found — camera will not follow player");
                return;
            }
            var follow = sceneCamGo.GetComponent<CameraFollow>();
            if (follow == null) follow = sceneCamGo.AddComponent<CameraFollow>();
            follow.Target = target;
            Debug.Log($"[GameStart] CameraFollow targeting {target.name}");
        }
    }
}
