// =======================================================================
//  ReferenceLoader.cs — Bundle lifecycle for UI sprite references
//
//  Source: _shared/DecompiledSource/ReferenceLoader.cs (field layout)
//  IL2CPP: KTO_DecompiledReference/_root/ReferenceLoader.c
//
//  Attach this to an Image's GameObject. When Sprite_SetSprite loads a
//  sprite from a bundle via LoaderManager, it creates a ReferenceLoader
//  to keep the bundle alive. When the Image is destroyed, OnDestroy
//  releases the bundle.
// =======================================================================

using UnityEngine;

namespace KTO.Resource
{
    public class ReferenceLoader : MonoBehaviour
    {
        // Source: ReferenceLoader.cs offset 0x20 — public BaseLoader m_loader
        BaseLoader _loader;

        // Source: ReferenceLoader.c SetLoader — releases old, assigns new
        public void SetLoader(BaseLoader loader)
        {
            if (_loader != null)
                _loader.Release();
            _loader = loader;
        }

        // Source: ReferenceLoader.c OnDestroy — releases loader
        void OnDestroy()
        {
            if (_loader != null)
            {
                _loader.Release();
                _loader = null;
            }
        }
    }
}
