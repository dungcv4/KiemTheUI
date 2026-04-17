using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace KTO.Game
{
    // =======================================================================
    //  NpcAssembler.cs — Single-part sprite assembler for NPCs (Phase 9.4)
    //
    //  Source of truth:
    //    KiemTheOrigin_DeepExtract/_shared/DecompiledSource/NpcAsset.cs
    //      → 9 action arrays (FightStand/FightRun/.../JunpFly), each is
    //        Sprite[dir * frame_count + frame] with dir 0..4 (5 stored, 5..7
    //        derived via flipX) and frame 0..frame_count[action]-1
    //    KTO_DecompiledReference/_root/NpcAsset.c — GetFrame/GetSprites/
    //      GetFlipX/ConvertDir bodies
    //    Player counterpart: Assets/Scripts/Game/PlayerAssembler.cs
    //      (3-part body+head+shadow). NpcAssembler reuses its
    //      LogicDirToActionDir helper exactly.
    //
    //  Wire format on disk:
    //    Resources/NpcAssets/<resName>.json   — manifest (PlayerNpcAssetJson
    //                                            schema, "part" field unused)
    //    Assets/Sprite/Npc/<resName>/*.png   — extracted sprite files,
    //                                            one PNG per Sprite name
    //
    //  Both produced by /tmp/extract_npc_bundle.py.
    //
    //  Differences from PlayerAssembler:
    //    - One body slot (no head, no shadow split)
    //    - Per-resName sprite cache (player uses one global cache)
    //    - Loads from Assets/Sprite/Npc/<resName> not Assets/Sprite/Player
    // =======================================================================

    public class NpcAssembler : MonoBehaviour
    {
        public NpcAction CurrentAction = NpcAction.FightStand;
        public int       CurrentLogicDir = 0;
        public int       CurrentFrame    = 0;
        public float     LocalScale      = 1f;

        public string ResName { get; private set; }

        PlayerNpcAssetJson _body;
        SpriteRenderer     _bodyRenderer;
        float              _frameTimer;

        // Per-resName cache: avoids reloading sprites when many NPCs of
        // the same type spawn (typical for monsters).
        static readonly Dictionary<string, Dictionary<string, Sprite>> _spriteCacheByRes
            = new Dictionary<string, Dictionary<string, Sprite>>();

        public static NpcAssembler Attach(GameObject go, string resName, float scale = 1f)
        {
            var a = go.GetComponent<NpcAssembler>();
            if (a == null) a = go.AddComponent<NpcAssembler>();
            a.LocalScale = scale;
            a.Initialize(resName);
            return a;
        }

        void Initialize(string resName)
        {
            ResName = resName;
            _body = LoadJson(resName);
            if (_body == null)
            {
                Debug.LogWarning($"[NpcAssembler] No manifest for '{resName}' — NPC will be invisible");
                return;
            }

            // SortingGroup keeps body z-stable when nested under NpcRoot
            var sg = gameObject.GetComponent<SortingGroup>();
            if (sg == null) sg = gameObject.AddComponent<SortingGroup>();
            sg.sortingOrder = 500; // below player (1000) so player draws on top

            // Single body slot
            var bodyGo = new GameObject("body");
            bodyGo.transform.SetParent(transform, false);
            _bodyRenderer = bodyGo.AddComponent<SpriteRenderer>();
            _bodyRenderer.sortingOrder = 0;

            transform.localScale = new Vector3(LocalScale, LocalScale, 1f);
            EnsureSpriteCache(resName);
            ApplyFrame();
        }

        static PlayerNpcAssetJson LoadJson(string resName)
        {
            var ta = Resources.Load<TextAsset>($"NpcAssets/{resName}");
            if (ta == null)
            {
                Debug.LogError($"[NpcAssembler] Missing JSON: Resources/NpcAssets/{resName}");
                return null;
            }
            return JsonUtility.FromJson<PlayerNpcAssetJson>(ta.text);
        }

        public static void ResetSpriteCache(string resName = null)
        {
            if (resName == null) _spriteCacheByRes.Clear();
            else _spriteCacheByRes.Remove(resName);
        }

        public static void EnsureSpriteCache(string resName)
        {
            if (_spriteCacheByRes.ContainsKey(resName)) return;

            var dict = new Dictionary<string, Sprite>();
            _spriteCacheByRes[resName] = dict;

#if UNITY_EDITOR
            var root = $"Assets/Sprite/Npc/{resName}";
            if (!System.IO.Directory.Exists(root))
            {
                Debug.LogWarning($"[NpcAssembler] Sprite folder not found: {root}");
                return;
            }
            var guids = AssetDatabase.FindAssets("t:Texture2D", new[] { root });
            int loaded = 0;
            foreach (var g in guids)
            {
                var path = AssetDatabase.GUIDToAssetPath(g);
                // Extracted PNGs are import-set as Sprite (single mode).
                // Try sub-sprites first; fall back to main asset.
                var subs = AssetDatabase.LoadAllAssetRepresentationsAtPath(path);
                bool added = false;
                foreach (var o in subs)
                {
                    if (o is Sprite s && !dict.ContainsKey(s.name))
                    {
                        dict[s.name] = s;
                        loaded++;
                        added = true;
                    }
                }
                if (!added)
                {
                    var main = AssetDatabase.LoadAssetAtPath<Sprite>(path);
                    if (main != null && !dict.ContainsKey(main.name))
                    {
                        dict[main.name] = main;
                        loaded++;
                    }
                }
            }
            Debug.Log($"[NpcAssembler] Sprite cache '{resName}': {loaded} entries");
#else
            Debug.LogWarning($"[NpcAssembler] Runtime sprite cache for '{resName}' not implemented (editor-only for now)");
#endif
        }

        void Update()
        {
            if (_body == null || _bodyRenderer == null) return;

            float interval = _body.interval > 0f ? _body.interval : 0.1f;
            _frameTimer += Time.deltaTime;
            if (_frameTimer >= interval)
            {
                _frameTimer -= interval;
                int fc = FrameCount(_body, CurrentAction);
                if (fc > 0)
                    CurrentFrame = (CurrentFrame + 1) % fc;
                ApplyFrame();
            }
        }

        void ApplyFrame()
        {
            if (_body == null || _bodyRenderer == null) return;

            // Find a usable action: requested → FightStand → first non-empty.
            // Many NPCs only ship FightStand or only FightRun — falling back
            // keeps them visible regardless of what action the spawn code
            // requested.
            NpcAction act = CurrentAction;
            if (FrameCount(_body, act) <= 0)
            {
                if (FrameCount(_body, NpcAction.FightStand) > 0)
                    act = NpcAction.FightStand;
                else
                    act = FindFirstAvailable(_body);
            }

            PlayerAssembler.LogicDirToActionDir(CurrentLogicDir, out int actionDir, out bool flipX);
            int fc = FrameCount(_body, act);
            if (fc <= 0) { _bodyRenderer.sprite = null; return; }

            int frame = Mathf.Clamp(CurrentFrame, 0, fc - 1);
            var arr = _body.GetAction(act);
            if (arr == null || arr.Length == 0) { _bodyRenderer.sprite = null; return; }

            int idx = actionDir * fc + frame;
            if (idx < 0 || idx >= arr.Length) { _bodyRenderer.sprite = null; return; }

            if (_spriteCacheByRes.TryGetValue(ResName, out var cache))
            {
                cache.TryGetValue(arr[idx], out Sprite sp);
                _bodyRenderer.sprite = sp;
            }
            _bodyRenderer.flipX = flipX;
        }

        static NpcAction FindFirstAvailable(PlayerNpcAssetJson a)
        {
            for (int i = 0; i < (int)NpcAction.Count; i++)
            {
                var act = (NpcAction)i;
                if (FrameCount(a, act) > 0) return act;
            }
            return NpcAction.FightStand;
        }

        static int FrameCount(PlayerNpcAssetJson a, NpcAction act)
        {
            if (a == null || a.frame_count == null || (int)act >= a.frame_count.Length) return 0;
            return a.frame_count[(int)act];
        }

        public void SetAction(NpcAction act)
        {
            if (CurrentAction == act) return;
            CurrentAction = act;
            CurrentFrame  = 0;
            _frameTimer   = 0f;
            ApplyFrame();
        }

        public void SetLogicDir(int dir)
        {
            CurrentLogicDir = ((dir % 256) + 256) % 256;
            ApplyFrame();
        }
    }
}
