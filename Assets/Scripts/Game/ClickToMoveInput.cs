using UnityEngine;
using UnityEngine.EventSystems;

namespace KTO.Game
{
    /// <summary>
    /// DEVIATION — not a literal port of an original class.
    ///
    /// The original client dispatches click-to-move inside Lua UI code
    /// (the minimap HUD + the world tap handler both end up calling
    /// <c>Operation:ClickMap(nX, nY, isDoubleClick)</c>). Those Lua
    /// handlers receive their input from native <c>OnTouch</c> bindings
    /// wired into the map scene by NGUI-era Unity bridge code we don't
    /// have visibility into.
    ///
    /// This component replaces that wiring with a single Unity-native
    /// MonoBehaviour that:
    ///   1. Polls <c>Input.GetMouseButtonDown(0)</c> (or touch.Began).
    ///   2. Skips the click if the pointer is over UI (same behavior the
    ///      original gets for free from NGUI's raycast-on-top handling).
    ///   3. Converts <c>Input.mousePosition</c> → world → logic coord.
    ///   4. Calls <see cref="Operation.ClickMap"/> with those logic coords.
    ///
    /// Approved by user via "phương án nào đúng 100% thì làm mở rộng đi"
    /// (2026-04-15) — this is the minimum-surface adapter that lets
    /// Operation.ClickMap run with inputs shaped exactly as the Lua
    /// pipeline expects them.
    ///
    /// ORIGINAL CALL SITES (for reference, kept for tracing):
    ///   - Script_Ui_Window_UIMiniMap.lua:398 — minimap click branch
    ///   - lua Operation:OnClickMap caller chain (not in extracted files)
    ///
    /// Phase 9.2 addition: NPC click detection
    ///   Source: KTO_DecompiledReference/_root/InputModule.c
    ///     On_TouchStart  (lines 780-977)  — Physics2D.Raycast on Npc layer
    ///     On_SimpleTap   (lines 1157-1221) — dispatch to LuaTables.SimpleTap
    ///   The original uses HedgehogTeam.EasyTouch for gesture recognition
    ///   with separate On_TouchStart (raycast) + On_SimpleTap (dispatch)
    ///   phases. Our simplified implementation does both in one step since
    ///   we use raw Input.GetMouseButtonDown.
    /// </summary>
    public class ClickToMoveInput : MonoBehaviour
    {
        [Tooltip("Camera used to project the click position to world space. " +
                 "Defaults to Camera.main if empty.")]
        public Camera TargetCamera;

        [Tooltip("When true, log each click with source + logic coords. " +
                 "Handy during smoke tests; leave off in normal play.")]
        public bool DebugLog = true;

        Camera _cam;

        // Source: InputModule.cs — `private static GameObject s_lastClickedNpcObj`
        // Stores the last clicked NPC object for the On_SimpleTap dispatch.
        // In our simplified flow this is set and consumed in the same frame.
        static GameObject _lastClickedNpcObj;

        /// <summary>Layer mask for NPC + OtherPlayer raycast (cached).</summary>
        int _npcLayerMask;

        void Awake()
        {
            _cam = TargetCamera != null ? TargetCamera : Camera.main;
        }

        void Start()
        {
            // Build layer mask for NPC click detection.
            // Source: InputModule.c:830 — `1 << LayerMask.NameToLayer("Npc")`
            //         InputModule.c:870 — fallback to OtherPlayerLayer
            int npcLayer = LayerMask.NameToLayer(GameDefine.NpcLayerName);
            int playerLayer = LayerMask.NameToLayer(GameDefine.OtherPlayerLayerName);
            _npcLayerMask = 0;
            if (npcLayer >= 0)    _npcLayerMask |= (1 << npcLayer);
            if (playerLayer >= 0) _npcLayerMask |= (1 << playerLayer);
        }

        void Update()
        {
            // Re-resolve Camera.main if the scene main-cam was assigned
            // after Awake (common when scenes swap).
            if (_cam == null) _cam = Camera.main;
            if (_cam == null) return;

            if (!TryGetClickScreenPos(out Vector2 screenPos)) return;

            // Skip clicks over UI (buttons, HUD panels, etc). Matches the
            // original client's NGUI-raycast-first behavior.
            if (IsPointerOverUI(screenPos)) return;

            // Screen → world (orthographic or perspective; Unity handles
            // both via ScreenToWorldPoint).
            // For an ortho 2D camera the Z component is ignored by the
            // 2D motor, so we just pin it to the camera's near plane.
            Vector3 world = _cam.ScreenToWorldPoint(new Vector3(
                screenPos.x, screenPos.y, -_cam.transform.position.z));

            // --- Phase 9.2: NPC click detection ---
            // Source: InputModule.c:On_TouchStart (lines 780-977)
            //   Physics2D.Raycast(worldPos, direction, 1000f, 1 << npcLayer)
            //   if hit → s_lastClickedNpcObj = collider.gameObject
            //
            // We use OverlapPoint (2D point test) which is cleaner for an
            // ortho camera setup — the original's directional raycast with
            // distance 1000 is equivalent to a point test in 2D.
            if (_npcLayerMask != 0)
            {
                Vector2 point2D = new Vector2(world.x, world.y);
                Collider2D hitCollider = Physics2D.OverlapPoint(point2D, _npcLayerMask);

                if (hitCollider != null)
                {
                    // Source: InputModule.c:On_SimpleTap (lines 1157-1221)
                    //   Npc npc = s_lastClickedNpcObj.GetComponent<Npc>()
                    //   if (npc != null) → LuaTables.SimpleTap(lt, npc.m_nNpcID, npc._IsFriend)
                    Npc npc = hitCollider.GetComponent<Npc>();
                    if (npc != null)
                    {
                        _lastClickedNpcObj = hitCollider.gameObject;

                        if (DebugLog)
                            Debug.Log($"[ClickToMoveInput] NPC tap id={npc.m_nNpcID} " +
                                      $"kind={npc.m_nKind} isFriend={npc._IsFriend} " +
                                      $"world=({world.x:F3},{world.y:F3})");

                        Operation.SimpleTap(npc.m_nNpcID, npc._IsFriend);
                        return; // NPC click consumed — do NOT fall through to ClickMap
                    }
                }
            }

            // --- No NPC hit: fall through to map click ---
            // Source: InputModule.c:950-977 — when no NPC is hit, clear
            // s_lastClickedNpcObj if it was a dialoger, then dispatch map click
            _lastClickedNpcObj = null;

            int logicX = Env.World2Logic(world.x);
            int logicY = Env.World2Logic(world.y);

            if (DebugLog)
                Debug.Log($"[ClickToMoveInput] click screen={screenPos} " +
                          $"world=({world.x:F3},{world.y:F3}) " +
                          $"logic=({logicX},{logicY})");

            Operation.ClickMap(logicX, logicY, isDoubleClick: false, bIsIgnoreFollow: false);
        }

        static bool TryGetClickScreenPos(out Vector2 screenPos)
        {
            // Mouse path first (editor + desktop).
            if (Input.GetMouseButtonDown(0))
            {
                screenPos = Input.mousePosition;
                return true;
            }

            // Touch path (mobile). Only fire on Began phase to match the
            // mouse "button down" semantics.
            if (Input.touchCount > 0)
            {
                var t = Input.GetTouch(0);
                if (t.phase == TouchPhase.Began)
                {
                    screenPos = t.position;
                    return true;
                }
            }

            screenPos = default;
            return false;
        }

        static bool IsPointerOverUI(Vector2 screenPos)
        {
            if (EventSystem.current == null) return false;

            // On desktop: EventSystem.IsPointerOverGameObject with no
            // pointerId checks the mouse. On touch we need the touch's
            // finger id. Use the touch path if a touch is active.
            if (Input.touchCount > 0)
            {
                var t = Input.GetTouch(0);
                return EventSystem.current.IsPointerOverGameObject(t.fingerId);
            }
            return EventSystem.current.IsPointerOverGameObject();
        }
    }
}
