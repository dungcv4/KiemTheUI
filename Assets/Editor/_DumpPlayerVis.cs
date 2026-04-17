#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

namespace KTO.Editor.MapImport
{
    // Dumps everything that could explain "player invisible at runtime":
    //  - Player position vs MainCamera position + ortho size
    //  - Player SpriteRenderer sortingLayer/sortingOrder per piece
    //  - SortingGroup on the player root
    //  - Comparison to a representative map SR (so we can see if player is
    //    sorting BELOW ground/buildings)
    public static class _DumpPlayerVis
    {
        public static void Execute()
        {
            var player = GameObject.Find("Player_ma_000a_free");
            if (player == null) { Debug.LogError("[_DumpPlayerVis] Player_ma_000a_free not found"); return; }

            Debug.Log($"[_DumpPlayerVis] Player root pos = {player.transform.position}  active={player.activeInHierarchy}");

            var sg = player.GetComponent<UnityEngine.Rendering.SortingGroup>();
            if (sg != null)
                Debug.Log($"[_DumpPlayerVis] SortingGroup  layer='{sg.sortingLayerName}' (id={sg.sortingLayerID})  order={sg.sortingOrder}");
            else
                Debug.Log($"[_DumpPlayerVis] SortingGroup MISSING on player root");

            foreach (var sr in player.GetComponentsInChildren<SpriteRenderer>(true))
            {
                Debug.Log($"[_DumpPlayerVis]   SR '{sr.gameObject.name}'  active={sr.gameObject.activeInHierarchy}  enabled={sr.enabled}  pos={sr.transform.position}  sprite='{(sr.sprite!=null?sr.sprite.name:"<null>")}'  layer='{sr.sortingLayerName}'(id={sr.sortingLayerID}) order={sr.sortingOrder}  mat='{(sr.sharedMaterial!=null?sr.sharedMaterial.name:"<null>")}'  shader='{(sr.sharedMaterial!=null && sr.sharedMaterial.shader!=null?sr.sharedMaterial.shader.name:"<null>")}'");
            }

            // Camera
            var cam = Camera.main;
            if (cam != null)
            {
                Debug.Log($"[_DumpPlayerVis] Camera.main '{cam.name}'  pos={cam.transform.position}  ortho={cam.orthographic}  size={cam.orthographicSize}  near={cam.nearClipPlane}  far={cam.farClipPlane}  cullingMask=0x{cam.cullingMask:X}");
            }
            else
                Debug.Log($"[_DumpPlayerVis] Camera.main is NULL");

            // Find any other camera
            foreach (var c in Object.FindObjectsOfType<Camera>())
                Debug.Log($"[_DumpPlayerVis]   camera '{c.gameObject.name}'  pos={c.transform.position}  depth={c.depth}  enabled={c.enabled}  cullingMask=0x{c.cullingMask:X}  ortho={c.orthographic}/{c.orthographicSize}");

            // Sample one map SR for comparison
            var ground = GameObject.Find("yunzhongzhen1_a");
            if (ground != null)
            {
                int n = 0;
                foreach (var sr in ground.GetComponentsInChildren<SpriteRenderer>(true))
                {
                    Debug.Log($"[_DumpPlayerVis] map SR '{sr.gameObject.name}'  layer='{sr.sortingLayerName}'(id={sr.sortingLayerID}) order={sr.sortingOrder}  pos={sr.transform.position}  enabled={sr.enabled}");
                    if (++n >= 10) break;
                }
            }
        }
    }
}
#endif
