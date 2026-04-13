// VFXRingRenderer — DEPRECATED
// ==============================
// The secondary-camera + RenderTexture approach doesn't work for particles
// under a ScreenSpaceCamera Canvas in URP. Canvas-transformed particles
// have world positions outside the secondary camera's frustum, and the
// custom shader (effect/C_EffectStandard) doesn't render on secondary cameras.
//
// The correct approach: both UILoginBG and UICreateRole_Canvas use
// ScreenSpaceCamera mode (matching the original game's renderMode=1),
// so particles render naturally through the main camera's Canvas pipeline.
// This logic is now in UICreateRoleAvatarController.EnsureDualScreenSpaceCamera().
//
// This file is kept empty to avoid missing-script errors on any GameObjects
// that may still reference it. The component does nothing.

using UnityEngine;

public class VFXRingRenderer : MonoBehaviour
{
    // No-op. All VFX rendering logic moved to UICreateRoleAvatarController.
    // If this component exists on a GameObject, it will be harmlessly ignored.
}
