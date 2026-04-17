using System.Collections;
using UnityEngine;
using KTO.Network;
using KTO.Resource;

// Type aliases to avoid collision with AssetRipper empty stubs in global namespace
using KDlcModule = KTO.Resource.DlcModule;
using KServerConfig = KTO.Resource.ServerConfig;
using KResourceDef = KTO.Resource.ResourceDef;
using KUpdaterMgr = KTO.Resource.KUpdaterMgr;
using KUIUpdateProgress = KTO.Resource.UIUpdateProgress;

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

            // Phase: Load player stat tables (PlayerLevel.tab etc.) into PlayerStatCalculator
            KTO.Game.Player.PlayerStatCalculator.Load();

            // Phase: Create player data sync handler (CMD 200-207)
            if (KTO.Network.PlayerDataSyncHandler.Instance == null)
            {
                var psGo = new GameObject("[PlayerDataSyncHandler]");
                psGo.AddComponent<KTO.Network.PlayerDataSyncHandler>();
            }

            // Phase R1: Initialize resource loading system
            // Source: Original game initializes BundleManager in startup sequence
            if (ResourceSystemDriver.Instance == null)
            {
                var resGo = new GameObject("[ResourceSystem]");
                resGo.AddComponent<ResourceSystemDriver>();
            }

            // Phase R4: Initialize DLC download system
            // Source: IL2CPP DlcModule__Init (0x01bd7508) — called during game startup
            // Sets up 3-priority queue downloader, loads PatchFileList, creates HttpDownloadMgr
            if (KDlcModule.Instance == null)
            {
                // Apply CDN URLs from config before Init
                var config = KServerConfig.Instance;
                KDlcModule._updateUrl = config.cdnUrl;
                KDlcModule._updateUrlBackup = config.cdnUrlBackup;
                yield return KDlcModule.Init();
            }

            // Phase R4.5: Create update progress UI (hidden by default)
            // Source: UIStartUp creates the progress display during startup
            //   IL2CPP UIStartUp__SetLoadingProgress (0x01cd2bf1)
            if (KUIUpdateProgress.Instance == null)
            {
                var uiGo = new GameObject("[UIUpdateProgress]");
                uiGo.AddComponent<KUIUpdateProgress>();
            }

            // Phase R4: Check for updates via KUpdaterMgr
            // Source: IL2CPP KUpdaterMgr__ProcessCheckLocalMainVersion
            //   Compares local vs remote PatchFileList, computes diff
            var updater = KUpdaterMgr.Instance;
            string localPatchPath = System.IO.Path.Combine(
                KResourceDef.StreamingResPath, "PatchFileList.json");
            string remotePatchUrl = KServerConfig.Instance.versionUrl + "PatchFileList.json";
            yield return updater.CheckForUpdates(localPatchPath, remotePatchUrl);

            if (updater.IsNeedUpdate)
            {
                // Show progress UI and start downloading
                KUIUpdateProgress.Instance.Show();
                KUIUpdateProgress.Instance.SetInfoText(
                    $"Updating: {updater.PendingDownloads.Count} files");
                yield return updater.DoUpdate();
                KUIUpdateProgress.Instance.OnComplete();

                // Wait for UI to auto-hide
                yield return new WaitForSeconds(2f);
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

            // Phase 11: Initialize NPC dialog UI
            // Source: Lua Ui:CreateWindow("UINpcDialog") — singleton created on game start
            if (NpcDialogUI.Instance == null)
            {
                var dialogGo = new GameObject("[NpcDialogUI]");
                dialogGo.AddComponent<NpcDialogUI>();
            }
            NpcDialogUI.Instance.Init();

            yield return UIMgr.Instance.LoadHudAsync();
            yield return SceneLoadManager.Instance.LoadMapAsync(InitialMapCode);

            // Phase 2 UI Controllers — activate panel controllers that respond
            // to hotkeys + open their prefab on demand.
            //   'B' → UIBag (inventory/attribute/reputation/horse/closet)
            if (KTO.UI.UIBagController.Instance == null)
            {
                var bagGo = new GameObject("[UIBagController]");
                bagGo.AddComponent<KTO.UI.UIBagController>();
            }

            if (SpawnPlayerOnStart)
            {
                var player = PlayerAssembler.Spawn(PlayerSpawnPos, PlayerClassId, PlayerVariant, PlayerGender, PlayerClassCode);
                player.gameObject.AddComponent<PlayerInputController>();

                // ClickToMoveInput handles screen taps → Operation.ClickMap for
                // click-to-move + NPC tap detection. Placed on a scene-level GO
                // (not on the player) so it survives independently and can
                // reference the SceneCamera directly.
                var clickGo = new GameObject("[ClickToMoveInput]");
                var ctm = clickGo.AddComponent<ClickToMoveInput>();
                var sceneCam = GameObject.Find("SceneCamera");
                if (sceneCam != null) ctm.TargetCamera = sceneCam.GetComponent<Camera>();

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
