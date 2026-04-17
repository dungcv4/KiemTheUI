// =======================================================================
//  ResourceSystemDriver.cs — MonoBehaviour that drives the resource system
//
//  DEVIATION — not from original source
//  Reason: Original BundleManager.Update is called from the game's main
//          loop (likely via a static Update registration). In Unity, we
//          need a MonoBehaviour to receive Update callbacks.
//
//  Add this component to a persistent GameObject (e.g. via GameStart).
//  It initializes ResourceModule and pumps BundleManager.Update each frame.
// =======================================================================

using UnityEngine;

namespace KTO.Resource
{
    public class ResourceSystemDriver : MonoBehaviour
    {
        public static ResourceSystemDriver Instance { get; private set; }

        void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }
            Instance = this;
            DontDestroyOnLoad(gameObject);

            ResourceModule.Init();

            // Phase R5: Initialize object pool system
            // Source: PreloadResource.Init is called during game startup
            PreloadResource.Init();
        }

        void Update()
        {
            ResourceModule.Update();

            // Phase R5: Run object pool GC
            // Source: PreloadResource.Active is called from the main loop
            //   IL2CPP PreloadResource__Active (0x0191043d) → _CheckGc()
            PreloadResource.Active();
        }

        void OnDestroy()
        {
            if (Instance == this)
            {
                Instance = null;
                ResourceModule.Shutdown();
            }
        }
    }
}
