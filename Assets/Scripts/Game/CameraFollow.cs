using UnityEngine;

namespace KTO.Game
{
    // Source: KTO_DecompiledReference/Game.RepresentLogic/SceneCameraController.c (LateUpdate @ 0x01c3af68)
    // Field layout: KiemTheOrigin_DeepExtract/_shared/DecompiledSource/Game.RepresentLogic/SceneCameraController.cs
    //   _Target GameObject @ 0x20, _Camera @ 0x28, _VecCache Vector3 @ 0x30,
    //   _OffsetY float @ 0x3C, _ViewSize Vector2 @ 0x50, _ViewChanged bool @ 0x58
    //
    // Original LateUpdate (translated from Ghidra pseudo-C):
    //   if (_Target == null || _Camera == null || IsSceneLoading) return;
    //   _VecCache.x = _Target.transform.position.x;
    //   _VecCache.y = _Target.transform.position.y + _OffsetY;
    //   _VecCache.z = _Camera.transform.position.z;          // preserve current z
    //   var delta = _VecCache - _Camera.transform.position;
    //   if (delta.sqrMagnitude < 1e-10f && !_ViewChanged) return;
    //   _Camera.transform.position = _VecCache;
    //   AudioModule.SetPos(_Target.transform.position);
    //   _ViewChanged = false;
    //   SceneOcclusion.Instance?.UpdateViewBound(_VecCache);
    //
    // Note: the original has NO camera bounds clamp. The camera simply snaps to
    // target.x, target.y + OffsetY every frame. Map edges are enforced by the
    // player-side obstacle check (NavigationModule.IsLogicPointObstacle) — the
    // player cannot walk past walkable bounds, so the camera never needs to.
    // No smoothing either (original is a direct assign, not SmoothDamp).
    //
    // AudioModule.SetPos and SceneOcclusion.UpdateViewBound are KTO subsystems
    // we don't have ported yet — Phase 7.2 intentionally omits them. See
    // PLAYER_SPAWN_PLAN.md open follow-ups.
    public class CameraFollow : MonoBehaviour
    {
        public Transform Target;
        public float OffsetY;

        Vector3 _vecCache;
        bool _viewChanged = true;

        void LateUpdate()
        {
            if (Target == null) return;

            var targetPos = Target.position;
            _vecCache.x = targetPos.x;
            _vecCache.y = targetPos.y + OffsetY;
            _vecCache.z = transform.position.z;

            var delta = _vecCache - transform.position;
            if (delta.sqrMagnitude < 1e-10f && !_viewChanged) return;

            transform.position = _vecCache;
            _viewChanged = false;
        }

        public void SetTarget(Transform target)
        {
            Target = target;
            _viewChanged = true;
        }

        public void MarkViewChanged()
        {
            _viewChanged = true;
        }
    }
}
