using UnityEngine;
using UnityEngine.UI;
using TMPro;
using MoonSharp.Interpreter;
using System.Collections.Generic;
// Alias to avoid collision with Assembly-CSharp empty stubs (global namespace)
using KResourceModule = KTO.Resource.ResourceModule;

/// <summary>
/// Bridge layer: Lua gọi các hàm này để tương tác với Unity UI.
/// Map 1:1 với API gốc: self.pPanel:SetActive(), Label_SetText(), etc.
/// </summary>
[MoonSharpUserData]
public class LuaUIBridge
{
    private Transform _root;
    private string _windowName;
    private Dictionary<string, Transform> _cache = new Dictionary<string, Transform>();

    public LuaUIBridge(Transform root, string windowName)
    {
        _root = root;
        _windowName = windowName;
    }

    // ============================================================
    // pPanel:SetActive(path, bool)/SetActive(path, 0/1)
    // ============================================================
    public void SetActive(string path, DynValue val)
    {
        bool active;
        if (val.Type == DataType.Boolean)
            active = val.Boolean;
        else if (val.Type == DataType.Number)
            active = val.Number != 0;
        else
            active = val.CastToBool();

        var t = FindCached(path);
        if (t == null)
        {
            // UICreateRole convention: SetActive("Main", bActive) on a scrollview
            // element is meant to toggle the element root itself. No "Main" child
            // exists on Faction_<key> clones — fall back to root.
            if (path == "Main" && _root != null)
                _root.gameObject.SetActive(active);
            return;
        }

        t.gameObject.SetActive(active);
    }

    // ============================================================
    // pPanel:IsActive(path) → bool
    // ============================================================
    public bool IsActive(string path)
    {
        var t = FindCached(path);
        if (t == null) return false;
        return t.gameObject.activeSelf;
    }

    // ============================================================
    // pPanel:Label_SetText(path, text)
    // ============================================================
    public void Label_SetText(string path, DynValue textVal)
    {
        var t = FindCached(path);
        if (t == null) return;

        string text = textVal != null ? textVal.CastToString() ?? "" : "";

        var tmp = t.GetComponent<TextMeshProUGUI>();
        if (tmp != null) { tmp.text = text; return; }

        var legacy = t.GetComponent<Text>();
        if (legacy != null) { legacy.text = text; }
    }

    // ============================================================
    // pPanel:Label_SetColorByName(path, colorName)
    // Supported names: Green, Red, Gray1, White, Yellow, Blue
    // ============================================================
    public void Label_SetColorByName(string path, string colorName)
    {
        var t = FindCached(path);
        if (t == null) return;

        Color color;
        switch (colorName)
        {
            case "Green": color = new Color(0.2f, 0.85f, 0.3f); break;
            case "Red": color = new Color(0.9f, 0.2f, 0.2f); break;
            case "Gray1": case "Gray": color = new Color(0.6f, 0.6f, 0.6f); break;
            case "Yellow": color = new Color(1f, 0.85f, 0.2f); break;
            case "Blue": color = new Color(0.3f, 0.6f, 1f); break;
            case "White": default: color = Color.white; break;
        }

        var tmp = t.GetComponent<TextMeshProUGUI>();
        if (tmp != null) { tmp.color = color; return; }

        var legacy = t.GetComponent<Text>();
        if (legacy != null) { legacy.color = color; }
    }

    // ============================================================
    // pPanel:Sprite_SetSprite(path, spriteName)
    // ============================================================
    public void Sprite_SetSprite(string path, string spriteName)
    {
        var t = FindCached(path);
        if (t == null) return;

        var img = t.GetComponent<Image>();
        if (img == null) return;

        if (string.IsNullOrEmpty(spriteName)) return;

        var sprite = LookupSprite(spriteName);
        if (sprite != null) img.sprite = sprite;
    }

    // Sprite lookup cache shared across all bridges. Used by Sprite_SetSprite to
    // resolve names like "img_factioninfo_shaolin" or "faction_wudang" from
    // atlas bundles via ResourceModule → SpriteAtlasMap.
    //
    // Source: UIPanel.Sprite_SetSprite (IL2CPP UIPanel.c:2665-2756)
    //   calls LoaderManager.Load(szPath) → gets sprite from atlas bundle
    //   then attaches ReferenceLoader to the Image's GameObject
    private static readonly Dictionary<string, Sprite> _spriteCache = new Dictionary<string, Sprite>();

    private static Sprite LookupSprite(string name)
    {
        if (_spriteCache.TryGetValue(name, out var s)) return s;

        // Load from atlas bundles via SpriteAtlasMap → ResourceModule
        // Source: Original flow is LoaderManager.Load(szPath) which resolves
        // the asset path to a bundle via BundleManager.s_fileAbInfo.
        // We use SpriteAtlasMap for the same purpose.
        s = KResourceModule.LoadSpriteByName(name);

        _spriteCache[name] = s; // cache misses too to avoid repeated scans
        return s;
    }

    // ============================================================
    // pPanel:Sprite_SetFill(path, fillAmount)
    // ============================================================
    public void Sprite_SetFill(string path, double fill)
    {
        var t = FindCached(path);
        if (t == null) return;

        var img = t.GetComponent<Image>();
        if (img != null)
        {
            img.type = Image.Type.Filled;
            img.fillAmount = Mathf.Clamp01((float)fill);
        }
    }

    // ============================================================
    // pPanel:Toggle_SetChecked(path, bool)
    // ============================================================
    public void Toggle_SetChecked(string path, bool isOn)
    {
        var t = FindCached(path);
        if (t == null) return;

        var toggle = t.GetComponent<Toggle>();
        if (toggle != null) toggle.isOn = isOn;
    }

    // ============================================================
    // pPanel:Toggle_GetChecked(path) → bool
    // ============================================================
    public bool Toggle_GetChecked(string path)
    {
        var t = FindCached(path);
        if (t == null) return false;

        var toggle = t.GetComponent<Toggle>();
        return toggle != null && toggle.isOn;
    }

    // ============================================================
    // pPanel:Toggle_SetEnable(path, bool)
    // ============================================================
    public void Toggle_SetEnable(string path, bool enabled)
    {
        var t = FindCached(path);
        if (t == null) return;

        var toggle = t.GetComponent<Toggle>();
        if (toggle != null) toggle.interactable = enabled;
    }

    // ============================================================
    // pPanel:GetObject(path) → returns a proxy
    //
    // NOTE: Return type is the concrete proxy class (not DynValue).
    // In MoonSharp native, DynValue was the stack currency and the
    // wrapped UserData was transparently unwrapped when Lua called a
    // method. In XLua, return values are pushed via reflection:
    // `ObjectTranslator.PushAny(L, ret)` first checks `custom_push_funcs`
    // *only for ValueType operands*, then for reference types falls
    // through to `Push(L, o)` which wraps the CLR object as generic
    // userdata. If we return `DynValue`, Lua sees a DynValue wrapper
    // with no GetComponent/Find/etc. method — every `:GetComponent(...)`
    // call after a GetObject() blew up as "attempt to call nil".
    // Returning the proxy directly lets XLua push it with the proper
    // typeid and Lua dispatches methods normally.
    // ============================================================
    public LuaGameObjectProxy GetObject(string path)
    {
        var t = FindCached(path);
        if (t == null) return null;
        return new LuaGameObjectProxy(t.gameObject);
    }

    // ============================================================
    // pPanel:GetTransform(path) → returns transform proxy
    // ============================================================
    public LuaTransformProxy GetTransform(string path)
    {
        var t = FindCached(path);
        if (t == null) return null;
        return new LuaTransformProxy(t);
    }

    // ============================================================
    // pPanel:GetRectTransform(path) → returns proxy with rect/sizeDelta
    // ============================================================
    public LuaRectTransformProxy GetRectTransform(string path)
    {
        var t = FindCached(path);
        if (t == null) return null;
        var rt = t.GetComponent<RectTransform>();
        if (rt == null) return null;
        return new LuaRectTransformProxy(rt);
    }

    // ============================================================
    // pPanel:GetEmojiText(path) → returns a proxy with .text, .onClickLink, .raycastTarget
    // ============================================================
    public LuaTextProxy GetEmojiText(string path)
    {
        var t = FindCached(path);
        if (t == null) return null;
        return new LuaTextProxy(t);
    }

    // ============================================================
    // pPanel:Object_SetSize(path, w, h)
    // ============================================================
    public void Object_SetSize(string path, double w, double h)
    {
        var t = FindCached(path);
        if (t == null) return;
        var rt = t.GetComponent<RectTransform>();
        if (rt != null) rt.sizeDelta = new Vector2((float)w, (float)h);
    }

    // ============================================================
    // pPanel:ContentSizeFitter_Refresh(path) — force layout rebuild
    // ============================================================
    public void ContentSizeFitter_Refresh(string path)
    {
        var t = FindCached(path);
        if (t == null) return;
        LayoutRebuilder.ForceRebuildLayoutImmediate(t.GetComponent<RectTransform>());
    }

    // ============================================================
    // pPanel:SetLongPressLoopTime(path, delay, interval)
    // ============================================================
    public void SetLongPressLoopTime(string path, double delay, double interval) { }
    public void SetLongPressEndTime(string path, double endTime) { }

    // ============================================================
    // pPanel:CloneObject(template, name, parent?)
    // ============================================================
    public string CloneObject(string templatePath, string name, string parentPath = null)
    {
        var tmpl = FindCached(templatePath);
        if (tmpl == null) return templatePath;

        Transform parent = parentPath != null ? FindCached(parentPath) : tmpl.parent;
        if (parent == null) parent = tmpl.parent;

        var clone = Object.Instantiate(tmpl.gameObject, parent);
        clone.name = name;
        
        string clonePath = parentPath != null ? $"{parentPath}/{name}" : $"{GetPath(tmpl.parent)}/{name}";
        return clonePath;
    }

    // ============================================================
    // pPanel:Button_SetEnable(path, bool)
    // ============================================================
    public void Button_SetEnable(string path, bool enabled)
    {
        var t = FindCached(path);
        if (t == null) return;
        var btn = t.GetComponent<Button>();
        if (btn != null) btn.interactable = enabled;
    }

    // ============================================================
    // pPanel:Button_SetText(path, text)
    // ============================================================
    public void Button_SetText(string path, DynValue textVal)
    {
        var t = FindCached(path);
        if (t == null) return;

        string text = textVal != null ? textVal.CastToString() ?? "" : "";

        // Try child Text first, then self
        var tmp = t.GetComponentInChildren<TextMeshProUGUI>();
        if (tmp != null) { tmp.text = text; return; }

        var legacy = t.GetComponentInChildren<Text>();
        if (legacy != null) { legacy.text = text; }
    }

    // ============================================================
    // pPanel:Input_GetText(path) → string
    // ============================================================
    public string Input_GetText(string path)
    {
        var t = FindCached(path);
        if (t == null) return "";
        var input = t.GetComponent<InputField>();
        if (input != null) return input.text ?? "";
        return "";
    }

    // ============================================================
    // pPanel:Input_SetText(path, text)
    // ============================================================
    public void Input_SetText(string path, DynValue textVal)
    {
        var t = FindCached(path);
        if (t == null) return;
        string text = textVal != null ? textVal.CastToString() ?? "" : "";
        var input = t.GetComponent<InputField>();
        if (input != null) { input.text = text; return; }
        // Fallback: write to first child Text
        var legacy = t.GetComponentInChildren<Text>();
        if (legacy != null) legacy.text = text;
    }

    // ============================================================
    // pPanel:ToggleGroup_SetSelect(path, bool)
    // ============================================================
    public void ToggleGroup_SetSelect(string path, bool isOn)
    {
        var t = FindCached(path);
        if (t == null) return;
        var toggle = t.GetComponent<Toggle>();
        if (toggle != null) toggle.isOn = isOn;
    }

    // ============================================================
    // pPanel:Sprite_SetNativeSize(path)
    // ============================================================
    public void Sprite_SetNativeSize(string path)
    {
        var t = FindCached(path);
        if (t == null) return;

        var img = t.GetComponent<Image>();
        if (img != null) img.SetNativeSize();
    }

    // ============================================================
    // pPanel:ResetCamera() — UILoginBG:OnCreate. Original resets the
    // UI-camera for panels that render 3D characters into a RawImage.
    // No 3D character pipeline yet → safe no-op.
    // ============================================================
    public void ResetCamera() { }

    // ============================================================
    // pPanel:DeleteObject(path) — destroy a nested GameObject.
    // Used by UILoginBG.OnPreDestroy() for dynamically loaded avatars.
    // ============================================================
    public void DeleteObject(string path)
    {
        var t = FindCached(path);
        if (t == null) return;
        _cache.Remove(path);
        Object.Destroy(t.gameObject);
    }

    // ============================================================
    // pPanel:Object_SetPosition(path, vec3)  — world position
    // pPanel:Object_GetPosition(path) → {x,y,z}
    // pPanel:Object_SetLocalPosition(path, vec3)
    // vec3 is a Lua table with x/y/z fields (produced by Ui.Vector3).
    // ============================================================
    public void Object_SetPosition(string path, DynValue vec)
    {
        var t = FindCached(path);
        if (t == null) return;
        t.position = ReadVec3(vec);
    }

    // Return XLua.LuaTable directly so XLua pushes a real Lua table
    // (LuaBase.push goes straight to lua_getref) instead of wrapping
    // a DynValue as opaque userdata. Lua side then accesses pos.x / .y / .z
    // as normal table fields without going through any compat shim.
    public XLua.LuaTable Object_GetPosition(string path)
    {
        var t = FindCached(path);
        return WriteVec3Table(t != null ? t.position : Vector3.zero);
    }

    public void Object_SetLocalPosition(string path, DynValue vec)
    {
        var t = FindCached(path);
        if (t == null) return;
        t.localPosition = ReadVec3(vec);
    }

    private static Vector3 ReadVec3(DynValue vec)
    {
        if (vec == null || vec.Type != DataType.Table) return Vector3.zero;
        var tbl = vec.Table;
        float x = ReadFloat(tbl.Get("x"));
        float y = ReadFloat(tbl.Get("y"));
        float z = ReadFloat(tbl.Get("z"));
        return new Vector3(x, y, z);
    }

    private static float ReadFloat(DynValue dv)
    {
        if (dv == null) return 0f;
        return dv.Type == DataType.Number ? (float)dv.Number : 0f;
    }

    // Build {x=,y=,z=} directly as an XLua.LuaTable so the caller can
    // return it straight to Lua without a DynValue wrapper in the middle.
    private XLua.LuaTable WriteVec3Table(Vector3 v)
    {
        var script = LuaEngine.Instance != null ? LuaEngine.Instance.Script : null;
        if (script == null) return null;
        var t = new Table(script);
        t["x"] = v.x;
        t["y"] = v.y;
        t["z"] = v.z;
        return t._xluaTable;
    }

    // ============================================================
    // pPanel:FindAnimator(path) → Animator component proxy (nil if none).
    // ============================================================
    public LuaAnimatorProxy FindAnimator(string path)
    {
        var t = FindCached(path);
        if (t == null) return null;
        var anim = t.GetComponent<Animator>();
        if (anim == null) anim = t.GetComponentInChildren<Animator>();
        if (anim == null) return null;
        return new LuaAnimatorProxy(anim);
    }

    // ============================================================
    // pPanel:DynamicLoadGameObjectAsync(mount, resPath, key, callback)
    // Used by UILoginBG to stream avatar prefabs at runtime. We don't
    // have the avatar bundles wired yet — fire the callback immediately
    // with the key so the Lua state machine advances past the load step.
    // ============================================================
    public void DynamicLoadGameObjectAsync(string mount, string resPath, string key, DynValue callback)
    {
        if (callback == null || callback.Type != DataType.Function) return;
        try
        {
            var luaEng = LuaEngine.Instance;
            if (luaEng != null && luaEng.Script != null)
                luaEng.Script.Call(callback, DynValue.NewString(key ?? ""));
        }
        catch (ScriptRuntimeException ex)
        {
            Debug.LogWarning($"[LuaUIBridge] DynamicLoadGameObjectAsync callback error: {ex.DecoratedMessage}");
        }
    }

    // ============================================================
    // Transform access
    // ============================================================
    public LuaTransformProxy transform { get { return new LuaTransformProxy(_root); } }
    [MoonSharpHidden]
    public Transform unityTransform { get { return _root; } }

    // ============================================================
    // Internal: cached find
    // ============================================================
    private Transform FindCached(string path)
    {
        if (string.IsNullOrEmpty(path)) return _root;

        if (_cache.TryGetValue(path, out var cached))
        {
            if (cached != null) return cached;
            _cache.Remove(path); // stale
        }

        var t = _root.Find(path);
        if (t != null) _cache[path] = t;
        return t;
    }

    private string GetPath(Transform t)
    {
        if (t == null || t == _root) return "";
        var path = t.name;
        var parent = t.parent;
        while (parent != null && parent != _root)
        {
            path = parent.name + "/" + path;
            parent = parent.parent;
        }
        return path;
    }
}

// ============================================================
// Proxy cho RectTransform — lua accesses .rect, .sizeDelta, .anchoredPosition
// ============================================================
[MoonSharpUserData]
public class LuaRectTransformProxy
{
    private RectTransform _rt;
    public LuaRectTransformProxy(RectTransform rt) { _rt = rt; }

    public LuaRect rect => new LuaRect(_rt.rect);
    
    public Vector2 sizeDelta
    {
        get => _rt != null ? _rt.sizeDelta : Vector2.zero;
        set { if (_rt) _rt.sizeDelta = value; }
    }

    public Vector2 anchoredPosition
    {
        get => _rt != null ? _rt.anchoredPosition : Vector2.zero;
        set { if (_rt) _rt.anchoredPosition = value; }
    }

    public Vector2 offsetMin
    {
        get => _rt != null ? _rt.offsetMin : Vector2.zero;
        set { if (_rt) _rt.offsetMin = value; }
    }

    public Vector2 offsetMax
    {
        get => _rt != null ? _rt.offsetMax : Vector2.zero;
        set { if (_rt) _rt.offsetMax = value; }
    }

    public Vector3 localEulerAngles
    {
        get => _rt != null ? _rt.localEulerAngles : Vector3.zero;
        set { if (_rt) _rt.localEulerAngles = value; }
    }
}

[MoonSharpUserData]
public class LuaRect
{
    public float width;
    public float height;
    public float x;
    public float y;

    public LuaRect(Rect r) { width = r.width; height = r.height; x = r.x; y = r.y; }
}

// ============================================================
// Proxy cho Text/TMP — lua accesses .text, .raycastTarget, .onClickLink
// ============================================================
[MoonSharpUserData]
public class LuaTextProxy
{
    private Transform _t;
    public LuaTextProxy(Transform t) { _t = t; }

    public string text
    {
        get
        {
            if (_t == null) return "";
            var tmp = _t.GetComponent<TextMeshProUGUI>();
            if (tmp) return tmp.text;
            var legacy = _t.GetComponent<Text>();
            return legacy ? legacy.text : "";
        }
        set
        {
            if (_t == null) return;
            var tmp = _t.GetComponent<TextMeshProUGUI>();
            if (tmp) { tmp.text = value ?? ""; return; }
            var legacy = _t.GetComponent<Text>();
            if (legacy) legacy.text = value ?? "";
        }
    }

    public bool raycastTarget
    {
        get
        {
            if (_t == null) return false;
            var tmp = _t.GetComponent<TextMeshProUGUI>();
            if (tmp) return tmp.raycastTarget;
            var legacy = _t.GetComponent<Text>();
            return legacy ? legacy.raycastTarget : false;
        }
        set
        {
            if (_t == null) return;
            var tmp = _t.GetComponent<TextMeshProUGUI>();
            if (tmp) { tmp.raycastTarget = value; return; }
            var legacy = _t.GetComponent<Text>();
            if (legacy) legacy.raycastTarget = value;
        }
    }

    // Stub — onClickLink callback
    public DynValue onClickLink { get; set; }
}

/// <summary>
/// Proxy cho GameObject trong Lua (để gọi GetComponent etc.)
/// </summary>
[MoonSharpUserData]
public class LuaGameObjectProxy
{
    private GameObject _go;

    public LuaGameObjectProxy(GameObject go) { _go = go; }

    public void SetActive(bool active) { if (_go) _go.SetActive(active); }

    // Returns self so `obj:GetComponent(Ui.XXXX):SomeMethod(...)` chains
    // work even though we don't have real component proxies for most
    // of the KTO UI types (MiniMap, SkillCountDown, MapPathLine, ...).
    // Every method Lua might call on the result is stubbed below so the
    // call graph completes without throwing.
    public LuaGameObjectProxy GetComponent(DynValue typeArg)
    {
        return this;
    }

    // === Transform proxy ===
    public LuaTransformProxy transform => _go != null ? new LuaTransformProxy(_go.transform) : null;

    // =======================================================================
    // Component resolution — resolves real components from the GameObject
    // When Lua calls obj:GetComponent(Ui.MiniMap), it returns this proxy.
    // These methods then forward to the actual component on _go.
    // =======================================================================

    // === Component-resolution methods (UISkillCountDown / MiniMap / MapPathLine) ===
    // The recon project shipped concrete C# components for these. We don't have
    // them in this project — the imported HUD prefabs only contain bare Image/
    // Text/Button GameObjects. So all of these become safe no-ops; lua can call
    // them without throwing, but they have no visible effect. If we ever need
    // working minimap/skill cooldowns we can fill these in later.
    public void Reset() { }
    public void SetUsePoint(bool a, int b, int c) { }
    public void Run(bool isUsePoint, int usePoint, int perUsePoint, double cdTime, double totalTime) { }

    public void SetUIPanel(DynValue panel, DynValue template, DynValue count) { }
    public void SetMiniMapInfo(DynValue scale, DynValue padW, DynValue padH) { }
    public void SetPlayerLogicPos(DynValue x, DynValue y) { }
    public void UpdateTeamMember() { }
    public void UpdatePlayerPos() { }
    public void AddTeamMemberNpcID(DynValue npcId) { }
    public void SetTeamMemberLogicPos(DynValue idx, DynValue x, DynValue y) { }

    public void SetMapData(DynValue w, DynValue h, DynValue scale, DynValue v) { }

    // === ManualSkillCaster stub methods ===
    public void OnLuaCreate(DynValue self) { }
    public void OpenManualSkillCaster(DynValue obj, DynValue castType, DynValue targetId) { }
    public void CloseManualSkillCaster(DynValue idx) { }
    // XLua maps `out` parameters to additional Lua return values, so
    // `local x, y = obj:GetCastingPos()` works. Returning a DynValue.NewTuple
    // did not — XLua wraps the DynValue as opaque userdata, not as two values.
    public void GetCastingPos(out double x, out double y) { x = 0; y = 0; }
    public double GetCastingDir() { return 0; }

    // === SetLayoutVertical (ContentSizeFitter) ===
    public void SetLayoutVertical() { }
}

/// <summary>
/// Proxy cho Transform trong Lua
/// </summary>
[MoonSharpUserData]
public class LuaTransformProxy
{
    private Transform _t;

    public LuaTransformProxy(Transform t) { _t = t; }

    public LuaTransformProxy Find(string path)
    {
        if (_t == null) return null;
        var child = _t.Find(path);
        if (child == null) return null;
        return new LuaTransformProxy(child);
    }

    public Vector3 localEulerAngles
    {
        get => _t != null ? _t.localEulerAngles : Vector3.zero;
        set { if (_t) _t.localEulerAngles = value; }
    }

    public Vector2 anchoredPosition
    {
        get
        {
            if (_t == null) return Vector2.zero;
            var rt = _t.GetComponent<RectTransform>();
            return rt != null ? rt.anchoredPosition : Vector2.zero;
        }
        set
        {
            if (_t == null) return;
            var rt = _t.GetComponent<RectTransform>();
            if (rt) rt.anchoredPosition = value;
        }
    }

    public Vector2 sizeDelta
    {
        get
        {
            if (_t == null) return Vector2.zero;
            var rt = _t.GetComponent<RectTransform>();
            return rt != null ? rt.sizeDelta : Vector2.zero;
        }
        set
        {
            if (_t == null) return;
            var rt = _t.GetComponent<RectTransform>();
            if (rt) rt.sizeDelta = value;
        }
    }

    public LuaRect rect
    {
        get
        {
            if (_t == null) return new LuaRect(new Rect());
            var rt = _t.GetComponent<RectTransform>();
            return rt != null ? new LuaRect(rt.rect) : new LuaRect(new Rect());
        }
    }

    public Vector2 offsetMin
    {
        get { var rt = _t?.GetComponent<RectTransform>(); return rt ? rt.offsetMin : Vector2.zero; }
        set { var rt = _t?.GetComponent<RectTransform>(); if (rt) rt.offsetMin = value; }
    }

    public Vector2 offsetMax
    {
        get { var rt = _t?.GetComponent<RectTransform>(); return rt ? rt.offsetMax : Vector2.zero; }
        set { var rt = _t?.GetComponent<RectTransform>(); if (rt) rt.offsetMax = value; }
    }
}

/// <summary>
/// Proxy cho Animator — Lua calls Play/SetTrigger/SetBool after pPanel:FindAnimator(path).
/// Most KTO UI animators are intro/idle loops the original game drives via Play("StateName").
/// If no Animator exists (we haven't wired the rigged avatars yet), every call is a no-op
/// so Lua state machines don't crash.
/// </summary>
[MoonSharpUserData]
public class LuaAnimatorProxy
{
    private Animator _anim;
    public LuaAnimatorProxy(Animator a) { _anim = a; }

    public void Play(string stateName)
    {
        if (_anim != null && !string.IsNullOrEmpty(stateName))
            _anim.Play(stateName, 0, 0f);
    }

    public void Play(string stateName, int layer)
    {
        if (_anim != null && !string.IsNullOrEmpty(stateName))
            _anim.Play(stateName, layer, 0f);
    }

    public void SetTrigger(string name)
    {
        if (_anim != null && !string.IsNullOrEmpty(name))
            _anim.SetTrigger(name);
    }

    public void SetBool(string name, bool val)
    {
        if (_anim != null && !string.IsNullOrEmpty(name))
            _anim.SetBool(name, val);
    }

    public void SetFloat(string name, double val)
    {
        if (_anim != null && !string.IsNullOrEmpty(name))
            _anim.SetFloat(name, (float)val);
    }

    public void SetInteger(string name, int val)
    {
        if (_anim != null && !string.IsNullOrEmpty(name))
            _anim.SetInteger(name, val);
    }

    public bool enabled
    {
        get { return _anim != null && _anim.enabled; }
        set { if (_anim != null) _anim.enabled = value; }
    }

    public double speed
    {
        get { return _anim != null ? _anim.speed : 0; }
        set { if (_anim != null) _anim.speed = (float)value; }
    }
}
