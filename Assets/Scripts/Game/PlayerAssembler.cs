using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace KTO.Game
{
    public enum NpcAction
    {
        FightStand = 0,
        FightRun   = 1,
        Wound      = 2,
        Die        = 3,
        Attack1    = 4,
        Attack2    = 5,
        Magic      = 6,
        SitDown    = 7,
        JunpFly    = 8,
        Count      = 9,
    }

    [System.Serializable]
    public class PlayerNpcAssetJson
    {
        public string  name;
        public string  part;
        public float   interval;
        public int     dir_count;
        public int[]   frame_count;
        public string[] FightStand;
        public string[] FightRun;
        public string[] Wound;
        public string[] Die;
        public string[] Attack1;
        public string[] Attack2;
        public string[] Magic;
        public string[] SitDown;
        public string[] JunpFly;

        public string[] GetAction(NpcAction act)
        {
            switch (act)
            {
                case NpcAction.FightStand: return FightStand;
                case NpcAction.FightRun:   return FightRun;
                case NpcAction.Wound:      return Wound;
                case NpcAction.Die:        return Die;
                case NpcAction.Attack1:    return Attack1;
                case NpcAction.Attack2:    return Attack2;
                case NpcAction.Magic:      return Magic;
                case NpcAction.SitDown:    return SitDown;
                case NpcAction.JunpFly:    return JunpFly;
            }
            return null;
        }
    }

    public class PlayerAssembler : MonoBehaviour
    {
        public NpcAction CurrentAction = NpcAction.FightStand;
        public int       CurrentLogicDir = 0;
        public int       CurrentFrame    = 0;

        public float LocalScale = 1f;

        PlayerNpcAssetJson _body;
        PlayerNpcAssetJson _head;
        PlayerNpcAssetJson _shadow;

        PlayerPartSlot _bodySlot;
        PlayerPartSlot _headSlot;
        PlayerPartSlot _shadowSlot;

        float _frameTimer;

        static readonly Dictionary<string, Sprite> _spriteCache = new Dictionary<string, Sprite>();
        static bool _spriteCacheLoaded;

        public static PlayerAssembler Spawn(Vector3 worldPos,
                                             int classId    = 1,
                                             string variant = "free",
                                             string gender  = "m",
                                             string classCode = "ma_000a")
        {
            var go = new GameObject($"Player_{classCode}_{variant}");
            go.transform.position = worldPos;
            var pa = go.AddComponent<PlayerAssembler>();
            pa.Initialize(classId, variant, gender, classCode);
            return pa;
        }

        void Initialize(int classId, string variant, string gender, string classCode)
        {
            EnsureSpriteCache();

            _body   = LoadJson($"body_{classId}_{variant}");
            _head   = LoadJson($"head_{classId}_{variant}");
            _shadow = LoadJson($"{variant}");

            // Source: KTO_DecompiledReference/_root/Npc.c:6896-6931 (Npc$$CreateFeatureRoot
            //   @ 0x01c84ab6) — every NPC root gets a SortingGroup whose
            //   sortingLayerID is read from a static int field
            //   (`*(int*)(*(long*)(DAT_03561680 + 0xb8) + 4)`). The exact static
            //   class behind DAT_03561680 isn't in our extracted metadata, but
            //   the original TagManager defines a sortingLayer literally named
            //   "Player" (uniqueID 2651622445u, see _RegisterTagsLayers.cs) that
            //   sits AFTER Map/CoverGround/etc — i.e. designed for the local
            //   character to render in front of the ground tiles.
            //   Without an explicit sortingLayerName the default is "Default"
            //   (id=0), which Unity renders BEHIND every named sortingLayer →
            //   player invisible under map sprites. Verified 2026-04-17 with
            //   _PatchPlayerSortingLayer at runtime: setting "Player" makes the
            //   character visible on top of the grass + stone path tiles.
            var sortGroup = gameObject.AddComponent<SortingGroup>();
            sortGroup.sortingLayerName = "Player";
            sortGroup.sortingOrder = 1000;

            _shadowSlot = PlayerPartSlot.Create(transform, "shadow", -10);
            _bodySlot   = PlayerPartSlot.Create(transform, "body",    0);
            _headSlot   = PlayerPartSlot.Create(transform, "head",   10);

            transform.localScale = new Vector3(LocalScale, LocalScale, 1f);

            ApplyFrame();
        }

        static PlayerNpcAssetJson LoadJson(string name)
        {
            var ta = Resources.Load<TextAsset>($"PlayerNpcAssets/{name}");
            if (ta == null)
            {
                Debug.LogError($"[PlayerAssembler] Missing JSON: Resources/PlayerNpcAssets/{name}");
                return null;
            }
            return JsonUtility.FromJson<PlayerNpcAssetJson>(ta.text);
        }

        public static void ResetSpriteCache()
        {
            _spriteCache.Clear();
            _spriteCacheLoaded = false;
        }

        public static void EnsureSpriteCache()
        {
            if (_spriteCacheLoaded) return;
#if UNITY_EDITOR
            var root = "Assets/Sprite/Player";
            var guids = AssetDatabase.FindAssets("t:Texture2D", new[] { root });
            int loaded = 0;
            foreach (var g in guids)
            {
                var path = AssetDatabase.GUIDToAssetPath(g);
                var subs = AssetDatabase.LoadAllAssetRepresentationsAtPath(path);
                foreach (var o in subs)
                {
                    if (o is Sprite s && !_spriteCache.ContainsKey(s.name))
                    {
                        _spriteCache[s.name] = s;
                        loaded++;
                    }
                }
                if (subs.Length == 0)
                {
                    var main = AssetDatabase.LoadAssetAtPath<Sprite>(path);
                    if (main != null && !_spriteCache.ContainsKey(main.name))
                    {
                        _spriteCache[main.name] = main;
                        loaded++;
                    }
                }
            }
            Debug.Log($"[PlayerAssembler] Sprite cache: {loaded} entries from {root}");
#else
            Debug.LogWarning("[PlayerAssembler] Runtime sprite cache not implemented (editor-only for now)");
#endif
            _spriteCacheLoaded = true;
        }

        // Source: NpcAsset$$GetFlipX   @ 0x019177f3 — `return param_2 - 1U < 3`
        //         NpcAsset$$GetSprites @ 0x01917261 — `row = (repDir∈{5,6,7}) ? 8-repDir : repDir`
        //         NpcDef.LogicDirToRepDir  — int[16] at global-metadata.dat 0x5a0528
        //
        // The JSON sprite rows are stored in their RIGHT-side native orientation:
        //   row 0 = Bottom (front, symmetric)
        //   row 1 = RightBottom facing  →  used for LeftBottom with flipX
        //   row 2 = Right facing        →  used for Left with flipX
        //   row 3 = RightTop facing     →  used for LeftTop with flipX
        //   row 4 = Top (back, symmetric)
        //
        // Directions {1,2,3} (LeftBottom, Left, LeftTop) FLIP the sprite.
        // Directions {5,6,7} (RightTop, Right, RightBottom) use native orientation.
        public static void LogicDirToActionDir(int logicDir, out int actionDir, out bool flipX)
        {
            int d = ((logicDir % 256) + 256) % 256;
            int bin = ((d + 16) / 32) % 8;
            if (bin <= 4)
            {
                actionDir = bin;
                flipX = (bin >= 1 && bin <= 3);   // NpcAsset.GetFlipX: repDir-1U < 3
            }
            else
            {
                actionDir = 8 - bin;
                flipX = false;
            }
        }

        void Update()
        {
            if (_body == null) return;
            EnsureSpriteCache();
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
            LogicDirToActionDir(CurrentLogicDir, out int actionDir, out bool flipX);
            SetSlot(_bodySlot,   _body,   actionDir, flipX);
            SetSlot(_headSlot,   _head,   actionDir, flipX);
            SetSlot(_shadowSlot, _shadow, actionDir, flipX);
        }

        void SetSlot(PlayerPartSlot slot, PlayerNpcAssetJson asset, int actionDir, bool flipX)
        {
            if (slot == null || asset == null) return;
            int fc = FrameCount(asset, CurrentAction);
            if (fc <= 0) { slot.Renderer.sprite = null; return; }
            int frame = Mathf.Clamp(CurrentFrame, 0, fc - 1);
            var arr = asset.GetAction(CurrentAction);
            if (arr == null || arr.Length == 0) { slot.Renderer.sprite = null; return; }
            int idx = actionDir * fc + frame;
            if (idx < 0 || idx >= arr.Length) { slot.Renderer.sprite = null; return; }
            _spriteCache.TryGetValue(arr[idx], out Sprite sp);
            slot.Renderer.sprite = sp;
            slot.Renderer.flipX  = flipX;
        }

        static int FrameCount(PlayerNpcAssetJson a, NpcAction act)
        {
            if (a.frame_count == null || (int)act >= a.frame_count.Length) return 0;
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

    class PlayerPartSlot
    {
        public Transform Root;
        public SpriteRenderer Renderer;

        public static PlayerPartSlot Create(Transform parent, string name, int order)
        {
            var go = new GameObject(name);
            go.transform.SetParent(parent, false);
            var sr = go.AddComponent<SpriteRenderer>();
            sr.sortingOrder = order;
            return new PlayerPartSlot { Root = go.transform, Renderer = sr };
        }
    }
}
