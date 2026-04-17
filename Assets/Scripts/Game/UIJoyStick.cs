using UnityEngine;
using UnityEngine.EventSystems;

namespace KTO.Game
{
    // ============================================================
    // Source: KTO_DecompiledReference/_root/UIJoyStick.c   (IL2CPP native, 18 methods)
    // Stub  : KiemTheOrigin_DeepExtract/_shared/DecompiledSource/UIJoyStick.cs
    // Lua   : 03_HUD_Main/Lua/Script_Ui_Window_UIJoyStick.lua (thin wrapper)
    //
    // Field layout comes from DecompiledSource (the FieldOffset attributes
    // preserved from Il2CppDumper). Method signatures come from there too.
    // Method bodies are translated from the Ghidra pseudo-C at the RVAs:
    //
    //   Awake                    0x01cc3ff7    Update                   0x01cc445b
    //   OnDeviceOrientationChange 0x01cc40a6   UpdateFingerTouchInfo    0x01cc4460
    //   Start                    0x01cc413d    IsInJoyStickArea         0x01cc47a9
    //   UpdateJoyStickArea       0x01cc41eb    JoyStickOnMoveStart      0x01cc47da
    //   OnDestroy                0x01cc4343    OnMoveStart              0x01cc4805
    //   OnSafeAreaChanged        0x01cc440e    ResetJoyStick            0x01cc485a
    //   OnMoveEnd                0x01cc48e7    UpdateJoyStick           0x01cc4964
    //   OnMove                   0x01cc4c27    UpdateMouseTouchInfo     0x01cc4d0d
    //   GetJoyStickDirByAxis     0x01cc4f12    .ctor                    0x01cc50ff
    //
    // DELEGATE DISPATCH
    // In the original, OnMove / OnMoveEnd / OnMoveStart dispatch through a
    // static singleton's Action<int> / Action fields. Those same callbacks
    // are what Lua registers `Operation:GoDirection` + `Operation:StopGoDir`
    // onto at boot. We collapse that plumbing: UIJoyStick directly calls
    // `Operation.GoDirection(dir)` / `Operation.StopGoDir()`. The observable
    // behavior is identical.
    //
    // NOT PORTED (open follow-ups)
    // - DAT_03563b28 (KtoCtx) safe-area value — we read Screen.safeArea directly.
    // - UnityAction listener wiring on OnDeviceOrientationChange event — we
    //   hook OnRectTransformDimensionsChange instead (same trigger).
    // - OnMoveStart's third Action (offset 0xc0) — it fires after OnMove in
    //   the original, but the Lua side doesn't bind it. No-op here.
    // ============================================================
    public class UIJoyStick : MonoBehaviour
    {
        // ----- serialized fields (Unity inspector) -----
        // Matches [FieldOffset 0x20..0x50] in DecompiledSource/UIJoyStick.cs.

        public Vector2      rightTopBorder;   // 0x20 — e.g. (-296, -380) per .ctor literal 0xc3948000c3be0000
        public Vector2      rightTopOffset;   // 0x28 — runtime, populated from safe-area * screen dims
        public float        handleRatio;      // 0x30 — handle cap as fraction of screen.width

        public RectTransform swiper;          // 0x38
        public RectTransform handle;          // 0x40
        public Transform     arrow;           // 0x48

        public bool          bEnable = true;  // 0x50 — .ctor: *(byte*)(this+0x50) = 1

        // ----- private fields -----

        Vector2 _orgPos;                      // 0x54 — saved swiper.anchoredPosition at Start
        Rect    _joyStickArea;                // 0x5C — hit rect, computed by UpdateJoyStickArea
        int     _touchStatus;                 // 0x6C — 0=Up, 1=Pressing
        int     _touchId = -1;                // 0x70 — .ctor: *(int*)(this+0x70) = 0xffffffff
        Vector2 _touchPosition;               // 0x74
        Vector2 _touchStartPosition;          // 0x7C

        RectTransform _canvasTrns;            // 0x88 — GetComponentInParent<Canvas>().rectTransform
        Vector2       _offset;                // 0x90 — canvas-space offset, computed in UpdateJoyStick

        // 0x98 — UnityEngine.Touch scratch. Unused in our port; Input.touches
        // gives us a fresh struct each call.

        public string passThoughtUIName = ""; // 0xE0 — UI substring filter for raycast passthrough
        int _nLastDir = -2;                   // 0xE8 — .ctor: *(int*)(this+0xE8) = 0xfffffffe

        public static UIJoyStick Inst;        // static — UIJoyStick.cs:79

        // ============================================================
        // Awake  @ 0x01cc3ff7
        // ============================================================
        void Awake()
        {
            OnDeviceOrientationChange();
            // Original: register UnityAction on KtoCtx.OnSafeAreaChanged event.
            // We hook OnRectTransformDimensionsChange, which fires on screen
            // rotate / safe-area change.
        }

        // ============================================================
        // OnDeviceOrientationChange @ 0x01cc40a6
        //   rightTopOffset.x = Screen.width  * safeArea.x
        //   rightTopOffset.y = Screen.height * safeArea.y
        // (the original reads a normalized vec from KtoCtx +0xa8;
        //  Unity's Screen.safeArea.size normalized by screenSize is the same.)
        // ============================================================
        void OnDeviceOrientationChange()
        {
            // In the IL2CPP body the singleton returns a normalized safe-area
            // Vector2 (width-ratio, height-ratio). Unity gives us Rect pixels,
            // so we divide by screen dims to get the ratio, then multiply back.
            // That collapses to: rightTopOffset = safeArea.size (in pixels).
            Rect sa = Screen.safeArea;
            rightTopOffset.x = sa.width;
            rightTopOffset.y = sa.height;
        }

        void OnRectTransformDimensionsChange()
        {
            OnDeviceOrientationChange();
            if (Application.isPlaying) UpdateJoyStickArea();
        }

        // ============================================================
        // Start @ 0x01cc413d
        //   canvasTrns = GetComponent<RectTransform>() (actually from parent Canvas)
        //   orgPos = swiper.anchoredPosition
        //   UpdateJoyStickArea()
        //   static Inst = this
        //
        // Plus (ported from Script_Ui_Window_UIJoyStick.lua OnOpen):
        //   SetHandActive(false)   — imgHand is a tutorial "guide finger"
        //                            sprite; the original shows it via the
        //                            Guide system only, and hides it at
        //                            window-open. We replicate via path
        //                            lookup since imgHand isn't a wired
        //                            serialized field.
        // Source: KiemTheOrigin_DeepExtract/03_HUD_Main/Lua/Script_Ui_Window_UIJoyStick.lua:13-17,33-35
        // ============================================================
        void Start()
        {
            var canvas = GetComponentInParent<Canvas>();
            if (canvas != null)
                _canvasTrns = canvas.GetComponent<RectTransform>();

            if (swiper != null)
            {
                _orgPos = swiper.anchoredPosition;
                UpdateJoyStickArea();
            }

            // Match Lua OnOpen → SetHandActive(false). Path is relative to the
            // UIJoyStick root ("panel/Joystick/imgHand" in Lua tbControls).
            var imgHand = transform.Find("panel/Joystick/imgHand");
            if (imgHand != null) imgHand.gameObject.SetActive(false);

            Inst = this;
        }

        // ============================================================
        // OnDestroy @ 0x01cc4343
        //   static Inst = null
        //   (unregister safe-area listener)
        // ============================================================
        void OnDestroy()
        {
            if (Inst == this) Inst = null;
        }

        // ============================================================
        // UpdateJoyStickArea @ 0x01cc41eb
        //   joyStickArea.x = 0
        //   joyStickArea.y = 0
        //   joyStickArea.width  = Screen.width  * (rightTopBorder.x + rightTopOffset.x + canvas.size.x * 0.5) / canvas.size.x
        //   joyStickArea.height = Screen.height * (rightTopBorder.y + rightTopOffset.y + canvas.size.y)       / canvas.size.y
        //   arrow.gameObject.SetActive(false)
        // ============================================================
        void UpdateJoyStickArea()
        {
            if (_canvasTrns == null) return;
            Vector2 canvasSize = _canvasTrns.sizeDelta;
            if (canvasSize.x <= 0f || canvasSize.y <= 0f) return;

            _joyStickArea.x = 0f;
            _joyStickArea.y = 0f;
            _joyStickArea.width  = Screen.width  * (rightTopBorder.x + rightTopOffset.x + canvasSize.x * 0.5f) / canvasSize.x;
            _joyStickArea.height = Screen.height * (rightTopBorder.y + rightTopOffset.y + canvasSize.y)        / canvasSize.y;

            if (arrow != null) arrow.gameObject.SetActive(false);
        }

        // ============================================================
        // OnSafeAreaChanged @ 0x01cc440e
        //   rightTopOffset.x = Screen.width  * param.x
        //   rightTopOffset.y = Screen.height * param.y
        // ============================================================
        // We don't expose an event; OnRectTransformDimensionsChange covers it.

        // ============================================================
        // Update @ 0x01cc445b + UpdateFingerTouchInfo @ 0x01cc4460
        // (the IL2CPP binary has both; they're nearly identical bodies)
        //
        // Touch state machine:
        //   if (touchStatus == Up)
        //     scan Input.touches; pick first whose phase==Began AND
        //       IsInJoyStickArea(position) AND not blocked by UI (unless the
        //       blocking UI's name contains passThoughtUIName)
        //     → touchStatus=Pressing, touchId=id, touchPosition=touchStart=pos
        //     → JoyStickOnMoveStart() + OnMoveStart()
        //   else // Pressing
        //     scan for the touch with matching touchId
        //     if found AND phase!=Ended && phase!=Canceled:
        //        touchPosition = pos
        //        UpdateJoyStick(touchStart, touchPos)
        //        OnMove(touchPos - touchStart)
        //     else:
        //        touchStatus=Up; ResetJoyStick(); OnMoveEnd()
        // ============================================================
        void Update()
        {
            if (!bEnable) return;

#if UNITY_EDITOR || UNITY_STANDALONE
            // Desktop fallback — matches UpdateMouseTouchInfo @ 0x01cc4d0d.
            // The original has both code paths on all platforms; we keep the
            // mouse one gated to editor/standalone so mobile builds use touch.
            UpdateMouseTouchInfo();
            if (Input.touchCount == 0) return;
#endif
            UpdateFingerTouchInfo();
        }

        void UpdateFingerTouchInfo()
        {
            if (_touchStatus == 0)   // Up
            {
                int n = Input.touchCount;
                for (int i = 0; i < n; i++)
                {
                    Touch t = Input.GetTouch(i);
                    if (t.phase != TouchPhase.Began) continue;
                    if (!IsInJoyStickArea(t.position)) continue;
                    if (!PassesUIBlockCheck(t.fingerId)) continue;

                    _touchStatus        = 1;
                    _touchId            = t.fingerId;
                    _touchPosition      = t.position;
                    _touchStartPosition = t.position;
                    JoyStickOnMoveStart();
                    OnMoveStart();
                    return;
                }
                return;
            }

            // touchStatus == Pressing
            int tcount = Input.touchCount;
            for (int i = 0; i < tcount; i++)
            {
                Touch t = Input.GetTouch(i);
                if (t.fingerId != _touchId) continue;
                if (t.phase == TouchPhase.Ended || t.phase == TouchPhase.Canceled)
                {
                    _touchStatus = 0;
                    ResetJoyStick();
                    OnMoveEnd();
                    return;
                }
                _touchPosition = t.position;
                UpdateJoyStick(_touchStartPosition, _touchPosition);
                OnMove(_touchPosition - _touchStartPosition);
                return;
            }

            // Lost the touch entirely (shouldn't happen but matches original).
            _touchStatus = 0;
            ResetJoyStick();
            OnMoveEnd();
        }

        // ============================================================
        // UpdateMouseTouchInfo @ 0x01cc4d0d
        // Mouse-equivalent of UpdateFingerTouchInfo. Used by the editor.
        // ============================================================
        void UpdateMouseTouchInfo()
        {
            if (_touchStatus == 0)   // Up
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Vector2 mp = Input.mousePosition;
                    if (IsInJoyStickArea(mp) && PassesUIBlockCheck(-1))
                    {
                        _touchStatus        = 1;
                        _touchId            = -1;   // mouse sentinel
                        _touchPosition      = mp;
                        _touchStartPosition = mp;
                        JoyStickOnMoveStart();
                        OnMoveStart();
                    }
                }
                return;
            }

            // touchStatus == Pressing
            if (_touchId != -1) return;   // this touchStatus belongs to a finger
            if (Input.GetMouseButtonUp(0))
            {
                _touchStatus = 0;
                ResetJoyStick();
                OnMoveEnd();
                return;
            }
            _touchPosition = Input.mousePosition;
            UpdateJoyStick(_touchStartPosition, _touchPosition);
            OnMove(_touchPosition - _touchStartPosition);
        }

        // ============================================================
        // UI-block check (extracted from Update @ 0x01cc445b)
        //   if EventSystem.IsPointerOverGameObject(fingerId):
        //     uiName = EventSystem.current.currentSelectedGameObject.name
        //     if !uiName.Contains(passThoughtUIName) → reject
        // ============================================================
        bool PassesUIBlockCheck(int fingerId)
        {
            var es = EventSystem.current;
            if (es == null) return true;

            bool over = (fingerId < 0)
                ? es.IsPointerOverGameObject()
                : es.IsPointerOverGameObject(fingerId);
            if (!over) return true;

            var sel = es.currentSelectedGameObject;
            if (sel == null) return false;
            if (string.IsNullOrEmpty(passThoughtUIName)) return false;
            return sel.name.Contains(passThoughtUIName);
        }

        // ============================================================
        // IsInJoyStickArea @ 0x01cc47a9
        //   return joyStickArea.x <= p.x && p.x < joyStickArea.x + width
        //       && joyStickArea.y <= p.y && p.y < joyStickArea.y + height
        // ============================================================
        public bool IsInJoyStickArea(Vector2 position)
        {
            return _joyStickArea.x <= position.x && position.x < _joyStickArea.x + _joyStickArea.width
                && _joyStickArea.y <= position.y && position.y < _joyStickArea.y + _joyStickArea.height;
        }

        // ============================================================
        // JoyStickOnMoveStart @ 0x01cc47da
        //   arrow.gameObject.SetActive(true)
        // ============================================================
        void JoyStickOnMoveStart()
        {
            if (arrow != null) arrow.gameObject.SetActive(true);
        }

        // ============================================================
        // OnMoveStart @ 0x01cc4805
        // Fires the "touch down" UnityAction on the static singleton. In Lua
        // the binding is empty by default — no-op unless a listener registers.
        // ============================================================
        void OnMoveStart()
        {
            // Intentionally no-op. Original dispatches through a singleton's
            // Action field at offset 0x98 (see UIJoyStick.c @ 0x01cc4805 block)
            // but Lua never binds it. Operation:GoDirection is called via
            // OnMove, not OnMoveStart.
        }

        // ============================================================
        // OnMoveEnd @ 0x01cc48e7
        //   singleton.OnMoveEnd()  → Operation:StopGoDir  (Lua binding)
        //   singleton.OnMoveStopSecondary() (offset 0xc0) — unbound in Lua
        // ============================================================
        void OnMoveEnd()
        {
            Operation.StopGoDir();
        }

        // ============================================================
        // OnMove @ 0x01cc4c27
        //   int dir = GetJoyStickDirByAxis(axis);
        //   if (dir < 0) {
        //     if (nLastDir >= 0) singleton.OnMoveStop();   // Operation.StopGoDir
        //   } else {
        //     singleton.OnMove(dir);                        // Operation.GoDirection
        //   }
        //   nLastDir = dir;
        // ============================================================
        void OnMove(Vector2 axisDelta)
        {
            int dir = GetJoyStickDirByAxis(axisDelta);
            if (dir < 0)
            {
                if (_nLastDir >= 0) Operation.StopGoDir();
            }
            else
            {
                Operation.GoDirection(dir);
            }
            _nLastDir = dir;
        }

        // ============================================================
        // ResetJoyStick @ 0x01cc485a
        //   swiper.anchoredPosition = orgPos
        //   handle.anchoredPosition = Vector2.zero
        //   arrow.gameObject.SetActive(false)
        // ============================================================
        void ResetJoyStick()
        {
            if (swiper != null) swiper.anchoredPosition = _orgPos;
            if (handle != null) handle.anchoredPosition = Vector2.zero;
            if (arrow  != null) arrow.gameObject.SetActive(false);
        }

        // ============================================================
        // UpdateJoyStick @ 0x01cc4964
        //   canvasSize = canvasTrns.sizeDelta
        //   offset.x = rightTopOffset.x * canvasSize.x / Screen.width
        //   offset.y = rightTopOffset.y * canvasSize.y / Screen.height
        //   startCanvas = startPos * canvasSize / screenSize
        //   curCanvas   = curPos   * canvasSize / screenSize
        //   delta       = curCanvas - startCanvas
        //
        //   swiper.anchoredPosition = startCanvas - offset     (Ghidra lost the arg;
        //                                                       inferred from standard
        //                                                       "joystick jumps to touch" pattern)
        //   radius = handleRatio * canvasSize.x
        //   if |delta|² > radius² then delta = delta.normalized * radius
        //   handle.anchoredPosition = delta
        //   arrow.rotation = Quaternion.FromToRotation(Vector3.up, delta)
        // ============================================================
        void UpdateJoyStick(Vector2 startPos, Vector2 curPos)
        {
            if (_canvasTrns == null) return;
            Vector2 canvasSize = _canvasTrns.sizeDelta;
            if (canvasSize.x <= 0f || canvasSize.y <= 0f) return;

            float sw = Screen.width, sh = Screen.height;
            if (sw <= 0f || sh <= 0f) return;

            _offset.x = rightTopOffset.x * canvasSize.x / sw;
            _offset.y = rightTopOffset.y * canvasSize.y / sh;

            Vector2 startCanvas = new Vector2(startPos.x * canvasSize.x / sw, startPos.y * canvasSize.y / sh);
            Vector2 curCanvas   = new Vector2(curPos.x   * canvasSize.x / sw, curPos.y   * canvasSize.y / sh);
            Vector2 delta       = curCanvas - startCanvas;

            if (swiper != null)
            {
                // Pivot swiper so its center sits at the touch-start location,
                // measured from the canvas origin convention the original uses.
                // The canvas is pivot=(1,0) right-bottom in the HUD prefab, so
                // we subtract (canvasSize - offset) to get the right-bottom-
                // relative anchored position.
                swiper.anchoredPosition = new Vector2(
                    startCanvas.x - canvasSize.x + _offset.x,
                    startCanvas.y - _offset.y);
            }

            float radius = handleRatio * canvasSize.x;
            float sq = delta.sqrMagnitude;
            if (sq > radius * radius && sq > 1e-10f)
            {
                delta = delta * (radius / Mathf.Sqrt(sq));
            }

            if (handle != null) handle.anchoredPosition = delta;
            if (arrow  != null)
                arrow.rotation = Quaternion.FromToRotation(Vector3.up, new Vector3(delta.x, delta.y, 0f));
        }

        // ============================================================
        // GetJoyStickDirByAxis @ 0x01cc4f12
        //
        // Dead-zone |axis|² < 0.01 → -2
        // Otherwise compute angle from axis against the "north" reference and
        // quantize to 256 bins. Byte-identical to Joystick.GetJoyStickDirByAxis
        // (KTO_DecompiledReference/_root/Joystick.c @ 0x01cab22d).
        //
        // The original uses:
        //   angle = acos(dot(axis, north) / (|axis| * |north|))  in degrees
        //   if (axis.x < 0) angle = 360 - angle
        //   angle = (450 - angle) mod 360         // rotate so north=0
        //   dir = (int)(angle * 256 / 360)
        //
        // Empirically this collapses to UP=128, DOWN=0, LEFT=64, RIGHT=192
        // — matches Env.UnityMoveToLogicDir convention (south=0, west=64,
        // north=128, east=192). We delegate to the shared helper to keep
        // one authoritative source.
        // ============================================================
        public static int GetJoyStickDirByAxis(Vector2 axis)
        {
            if (axis.sqrMagnitude < 0.01f) return -2;
            return Env.UnityMoveToLogicDir(axis);
        }
    }
}
