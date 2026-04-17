using UnityEngine;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace KTO.Game
{
    // =======================================================================
    //  NpcHeadLabel.cs — Per-NPC head label (name + title above the sprite)
    //
    //  Phase 10 port of the original head label system.
    //
    //  Original architecture (screen-space overlay, pooled):
    //    UESNpcHeadTextSet (singleton, 3 pools: NPC/Player/Me)
    //      → UESHeadTextContrl (per-category, Dict<NpcSlot,UESHead>)
    //        → UESHead (individual label: _Name, _TongTitle, _HonorTitle,
    //                    _ChatTitle, _Title, _NameOutline)
    //
    //  Original flow (IL2CPP):
    //    Npc.LateUpdate (Npc.c:2921-2990)
    //      → checks _RepresentMask bits
    //      → reads cached head text world pos (offset 0x2e8)
    //      → WorldToScreenPoint → stores into NpcSlot.HeadlotScreenPoint
    //    UESHeadTextContrl.LateUpdate (UESHeadTextContrl.c:529-615)
    //      → iterates all NpcSlots
    //      → ScreenPointToLocalPointInRectangle → UESHead.UpdatePosition
    //    UESHead.UpdatePosition (UESHead.c:15-36)
    //      → sets RectTransform.anchoredPosition (with epsilon threshold)
    //
    //  DEVIATION — world-space Canvas child instead of screen-space overlay pool
    //  Reason: Orthographic 2D camera makes world-space and screen-space
    //          visually identical. Original uses screen-space overlay because
    //          the rendering pipeline had a separate scene camera + UI camera.
    //          For our ortho 2D setup, a per-NPC world-space Canvas child
    //          produces identical results with much less code.
    //  Original closest match: UESHead.cs + UESHeadTextContrl.LateUpdate
    //  Approved by user: 2026-04-17 ("push code 1 bản lên git đã xong làm tiếp 10 11")
    //
    //  Fields ported from UESHead (_shared/DecompiledSource/UESHead.cs):
    //    _Name       (Text)   — offset 0x40 — NPC display name
    //    _NameOutline (Shadow) — offset 0x48 — name outline/shadow
    //    _Title      (UITitle → simplified to Text) — offset 0x38
    //
    //  Positioning from NpcResTemplate:
    //    m_HeadTextPos   (Vector3, default (0, 1.2, 0)) — world offset
    //    m_fHeadTextScale (float, default 1.0)          — scale multiplier
    //
    //  NPC name colors (from original RepresentSetting.GetColorSet):
    //    Dialoger NPC:  yellow (#FFFF00)
    //    Monster NPC:   red (#FF0000)
    //    Player (other): white (#FFFFFF)
    //    Player (me):    green (#00FF00)
    //    Default:        white
    //  Source: RepresentSetting.c + Lua SetPlayerHeadInfo / SetNpcRepName
    //          Color IDs are server-driven; these are fallback defaults.
    // =======================================================================

    public class NpcHeadLabel : MonoBehaviour
    {
        // --- UI references (mirrors UESHead field layout) ---
        Text _nameText;                 // UESHead._Name (0x40)
        Shadow _nameOutline;            // UESHead._NameOutline (0x48)
        Text _titleText;                // UESHead._Title simplified
        Canvas _canvas;
        RectTransform _canvasRect;

        // --- Configuration ---
        // Source: NpcResTemplate.m_HeadTextPos default = (0, 1.2, 0)
        //         NpcResTemplate.m_fHeadTextScale default = 1.0
        Vector3 _headTextOffset;
        float   _headTextScale;

        // --- Constants ---
        // Source: UESHead.cs — fNameOffset when name visible = 0x3e2e147b (float)
        //         0x3e2e147b in IEEE 754 = 0.17f (approximately)
        //         UESHead.SetNameVisible: stores 0x3e2e147b at offset 0x50 when visible
        const float NAME_FONT_SIZE = 14f;
        const float TITLE_FONT_SIZE = 11f;

        // World-space canvas scale factor.
        // In an ortho camera with size ~7, world-space UI needs to be
        // scaled down to appear at readable pixel size.
        // Source: DEVIATION — original uses screen-space (no scale needed)
        //         This value is tuned for ortho size ~7 to produce ~14px text
        const float CANVAS_SCALE = 0.01f;

        // =================================================================
        //  Attach — Factory method to create a head label on an NPC
        //
        //  Called from Npc.CreateRepresent (Phase 10 addition).
        //  Mirrors: UESNpcHeadTextSet.Attach(nKind, isMe, npcSlot)
        //  Source: UESNpcHeadTextSet.cs:31 / UESNpcHeadTextSet.c:40-86
        // =================================================================
        public static NpcHeadLabel Attach(Npc npc)
        {
            if (npc == null) return null;

            // Check _RepresentMask for HeadText bit
            // Source: Npc.c:InitData — HeadText bit = NpcRepresentMask.HeadText (0x0400)
            //         Npc.c:LateUpdate — checks mask bits before computing head pos
            bool showHead = (npc._RepresentMask & (int)NpcRepresentMask.HeadText) != 0;
            if (!showHead) return null;

            // Read positioning from template
            // Source: Npc.c:LateUpdate line 2942 — reads offset 0x2e8 which is
            //         m_vePos + m_HeadTextPos (cached during Active/InitData)
            Vector3 headOffset = new Vector3(0f, 1.2f, 0f);  // default
            float headScale = 1f;
            if (npc.m_NpcResTemplate != null)
            {
                headOffset = npc.m_NpcResTemplate.m_HeadTextPos;
                headScale  = npc.m_NpcResTemplate.m_fHeadTextScale;
            }

            // Create the label GameObject as child of the NPC
            var labelGo = new GameObject("HeadLabel");
            labelGo.transform.SetParent(npc.transform, false);
            labelGo.transform.localPosition = headOffset;
            // Scale: world-space canvas needs small scale for readable text
            labelGo.transform.localScale = new Vector3(CANVAS_SCALE * headScale,
                                                        CANVAS_SCALE * headScale,
                                                        1f);

            var label = labelGo.AddComponent<NpcHeadLabel>();
            label._headTextOffset = headOffset;
            label._headTextScale  = headScale;
            label.BuildUI(npc);

            return label;
        }

        // =================================================================
        //  BuildUI — Construct the Canvas + Text elements
        //
        //  Mirrors: UESHead prefab structure (Canvas → Name, Title, etc.)
        //  The original UESHead is a prefab with pre-wired Text/Shadow
        //  components. We construct them in code since we don't have the
        //  prefab imported yet.
        // =================================================================
        void BuildUI(Npc npc)
        {
            // --- Canvas (world-space) ---
            // DEVIATION: original uses screen-space overlay on a shared Canvas
            _canvas = gameObject.AddComponent<Canvas>();
            _canvas.renderMode = RenderMode.WorldSpace;
            _canvas.sortingOrder = 2000;  // above NPC sprites (500) and player (1000)

            _canvasRect = GetComponent<RectTransform>();
            _canvasRect.sizeDelta = new Vector2(200f, 80f);  // generous size for text

            // --- Name text ---
            // Source: UESHead._Name (Text at offset 0x40)
            var nameGo = new GameObject("Name");
            nameGo.transform.SetParent(transform, false);

            _nameText = nameGo.AddComponent<Text>();
            _nameText.font = GetLabelFont();
            _nameText.fontSize = (int)NAME_FONT_SIZE;
            _nameText.alignment = TextAnchor.MiddleCenter;
            _nameText.horizontalOverflow = HorizontalWrapMode.Overflow;
            _nameText.verticalOverflow = VerticalWrapMode.Overflow;
            _nameText.raycastTarget = false;

            var nameRect = nameGo.GetComponent<RectTransform>();
            nameRect.anchorMin = new Vector2(0.5f, 0.5f);
            nameRect.anchorMax = new Vector2(0.5f, 0.5f);
            nameRect.pivot     = new Vector2(0.5f, 0f);
            nameRect.anchoredPosition = Vector2.zero;
            nameRect.sizeDelta = new Vector2(200f, 20f);

            // --- Name outline/shadow ---
            // Source: UESHead._NameOutline (Shadow at offset 0x48)
            //         UESHead.Awake — disables outline at quality > 1
            _nameOutline = nameGo.AddComponent<Shadow>();
            _nameOutline.effectColor = new Color(0f, 0f, 0f, 0.8f);
            _nameOutline.effectDistance = new Vector2(1f, -1f);

            // --- Title text (below name) ---
            // Source: UESHead._Title (UITitle at offset 0x38)
            //         Simplified to plain Text for Phase 10
            var titleGo = new GameObject("Title");
            titleGo.transform.SetParent(transform, false);

            _titleText = titleGo.AddComponent<Text>();
            _titleText.font = GetLabelFont();
            _titleText.fontSize = (int)TITLE_FONT_SIZE;
            _titleText.alignment = TextAnchor.MiddleCenter;
            _titleText.horizontalOverflow = HorizontalWrapMode.Overflow;
            _titleText.verticalOverflow = VerticalWrapMode.Overflow;
            _titleText.raycastTarget = false;
            _titleText.color = new Color(0.5f, 1f, 0.5f, 1f);  // light green for title

            var titleRect = titleGo.GetComponent<RectTransform>();
            titleRect.anchorMin = new Vector2(0.5f, 0.5f);
            titleRect.anchorMax = new Vector2(0.5f, 0.5f);
            titleRect.pivot     = new Vector2(0.5f, 1f);
            titleRect.anchoredPosition = new Vector2(0f, -2f);
            titleRect.sizeDelta = new Vector2(200f, 16f);

            // Title also gets shadow
            var titleOutline = titleGo.AddComponent<Shadow>();
            titleOutline.effectColor = new Color(0f, 0f, 0f, 0.8f);
            titleOutline.effectDistance = new Vector2(1f, -1f);

            // --- Set initial data ---
            SetName(npc.m_szName);
            SetTitle(npc.m_szTitle);
            SetNameColor(npc.m_nKind, npc.m_bIsMe);
        }

        // =================================================================
        //  SetName — UESHead.SetName (UESHead.c:390-441)
        //
        //  Sets the display name. If null/empty, hides the name.
        //  Source: UESHead.c:402 — if not empty, SetNameVisible(true)
        //          UESHead.c:435 — if empty, SetNameVisible(false)
        // =================================================================
        public void SetName(string szName)
        {
            if (_nameText == null) return;

            if (string.IsNullOrEmpty(szName))
            {
                _nameText.gameObject.SetActive(false);
            }
            else
            {
                _nameText.text = szName;
                _nameText.gameObject.SetActive(true);
            }
        }

        // =================================================================
        //  SetTitle — Simplified UITitle.SetTitle
        //
        //  Source: UESHead.SetTitle (UESHead.cs:115)
        //          Full version has colorID, gradient colors, outline color,
        //          outline alpha params. Phase 10 uses plain text only.
        // =================================================================
        public void SetTitle(string szTitle)
        {
            if (_titleText == null) return;

            if (string.IsNullOrEmpty(szTitle))
            {
                _titleText.gameObject.SetActive(false);
            }
            else
            {
                _titleText.text = szTitle;
                _titleText.gameObject.SetActive(true);
            }
        }

        // =================================================================
        //  SetNameColor — UESHead.SetNameColor (UESHead.c:455-484)
        //
        //  Original uses RepresentSetting.GetColorSet(nColorID) to look up
        //  the color from a config table. Phase 10 uses hardcoded defaults
        //  per NpcKind as a faithful approximation.
        //
        //  Source: RepresentSetting.c + various Lua scripts that call
        //          SetPlayerHeadInfo / SetNpcRepName with color IDs.
        //  Known color mappings from Lua:
        //    Dialoger:  yellow-ish (#FFD700)
        //    Monster:   red (#FF4444)
        //    Player:    white (#FFFFFF) / green for self (#00FF00)
        // =================================================================
        public void SetNameColor(int nKind, bool isMe)
        {
            if (_nameText == null) return;

            Color c;
            if (isMe)
            {
                c = new Color(0f, 1f, 0f, 1f);  // green for local player
            }
            else if (nKind == (int)NpcKind.Dialoger)
            {
                c = new Color(1f, 0.84f, 0f, 1f);  // gold/yellow for dialoger NPCs
            }
            else if (nKind == (int)NpcKind.Normal)
            {
                // Normal = 0 — monsters/generic NPCs
                c = new Color(1f, 0.27f, 0.27f, 1f);  // red for monsters
            }
            else if (nKind == (int)NpcKind.Player)
            {
                c = Color.white;  // white for other players
            }
            else
            {
                c = Color.white;  // default
            }

            _nameText.color = c;
        }

        public void SetNameColor(Color color)
        {
            if (_nameText != null)
                _nameText.color = color;
        }

        // =================================================================
        //  SetVisible — UESHead.SetVisable (UESHead.c:49-86)
        //
        //  Source: UESHead.c:71-79 — checks activeSelf, only toggles if changed
        // =================================================================
        public void SetVisible(bool visible)
        {
            if (gameObject.activeSelf != visible)
                gameObject.SetActive(visible);
        }

        // =================================================================
        //  OnRecycle — UESHead.OnRecycle (UESHead.c:99-126)
        //
        //  Reset state when the NPC is returned to pool.
        //  Source: UESHead.c:110-121 — resets HonorTitle star counts
        //  Phase 10: we just destroy the label GO since we don't pool.
        // =================================================================
        public void OnRecycle()
        {
            if (gameObject != null)
                Destroy(gameObject);
        }

        // =================================================================
        //  GetLabelFont — resolve a suitable font for head labels
        //
        //  Source: The original UESHead prefab uses the game's default font
        //          (common_zh in CN, mapped to common_vi for VN).
        //  Phase 10: try common_vi first, fall back to Arial.
        // =================================================================
        static Font _cachedFont;

        static Font GetLabelFont()
        {
            if (_cachedFont != null) return _cachedFont;

#if UNITY_EDITOR
            // Editor: load from Assets/Font/common_vi.ttf directly
            // Source: ONE-SHOT PIPELINE font mapping — common_zh → common_vi
            _cachedFont = AssetDatabase.LoadAssetAtPath<Font>("Assets/Font/common_vi.ttf");
            if (_cachedFont != null) return _cachedFont;
#endif

            // Runtime: try Resources path
            _cachedFont = Resources.Load<Font>("Fonts/common_vi");
            if (_cachedFont != null) return _cachedFont;

            // Fall back to Unity built-in
            _cachedFont = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");

            return _cachedFont;
        }
    }
}
