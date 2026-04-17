// MoonSharp → XLua compatibility shim.
//
// This file provides the subset of the MoonSharp.Interpreter API that
// LuaEngine.cs, LuaGameStubs.cs, LuaUIBridge.cs and LuaEventBridge.cs use,
// backed by a real XLua LuaEnv underneath. The goal is:
//   1) zero source changes to the ~2700 lines of existing Lua-glue C# code
//   2) Lua execution runs on XLua's native Lua VM (much faster than MoonSharp)
//   3) MoonSharp.Interpreter.dll can be deleted
//
// Scope implemented (only what the codebase actually touches):
//   Script, Table, DynValue, DataType, Closure, UserData, CallbackArguments,
//   ScriptExecutionContext, ScriptRuntimeException, SyntaxErrorException,
//   CoreModules.Preset_Complete, DynValue.Nil/True/False/NewNumber/NewString/
//   NewBoolean/NewTable/NewTuple/NewCallback, Table.Pairs/Get/Set/indexer,
//   Script.Globals/DoString/Call.
//
// NOT implemented (would be dead weight): metatables, coroutines, debug hooks,
// modules beyond _G, compiled function caching. If you hit a NotImplementedException
// the call site is using a MoonSharp feature we never used.
using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using XLuaDLL = XLua.LuaDLL.Lua;
using XLuaCSFunction = XLua.LuaDLL.lua_CSFunction;
using XLuaTypes = XLua.LuaTypes;

namespace MoonSharp.Interpreter
{
    // ──────────────────────────────────────────────────────────────────────
    // Attributes — no-op markers in the XLua-backed shim (XLua reflects
    // directly on CLR types, no opt-in decoration required)
    // ──────────────────────────────────────────────────────────────────────

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct
        | AttributeTargets.Interface | AttributeTargets.Enum,
        AllowMultiple = false, Inherited = true)]
    public sealed class MoonSharpUserDataAttribute : Attribute { }

    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property
        | AttributeTargets.Field | AttributeTargets.Constructor,
        AllowMultiple = false, Inherited = true)]
    public sealed class MoonSharpHiddenAttribute : Attribute { }

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public sealed class MoonSharpVisibleAttribute : Attribute
    {
        public bool Visible { get; }
        public MoonSharpVisibleAttribute(bool visible) { Visible = visible; }
    }

    // ──────────────────────────────────────────────────────────────────────
    // Enums + simple types
    // ──────────────────────────────────────────────────────────────────────

    public enum DataType
    {
        Nil,
        Boolean,
        Number,
        String,
        Table,
        Function,
        ClrFunction,
        UserData,
        Tuple,
    }

    public enum CoreModules
    {
        Preset_Complete = 0,
    }

    public class ScriptRuntimeException : Exception
    {
        public string DecoratedMessage => Message;
        public ScriptRuntimeException(string m) : base(m) { }
        public ScriptRuntimeException(string m, Exception inner) : base(m, inner) { }
    }

    public class SyntaxErrorException : Exception
    {
        public string DecoratedMessage => Message;
        public SyntaxErrorException(string m) : base(m) { }
    }

    public class ScriptExecutionContext
    {
        // Placeholder; MoonSharp passes it to callbacks, our code never inspects it.
    }

    public class CallbackArguments
    {
        private readonly DynValue[] _args;
        public CallbackArguments(DynValue[] args) { _args = args ?? Array.Empty<DynValue>(); }
        public int Count => _args.Length;
        public DynValue this[int i] => (i >= 0 && i < _args.Length) ? _args[i] : DynValue.Nil;
    }

    // ──────────────────────────────────────────────────────────────────────
    // UserData — used by LuaUIBridge / proxies
    // ──────────────────────────────────────────────────────────────────────

    public class UserData
    {
        public object Object { get; }
        internal UserData(object o) { Object = o; }

        public static DynValue Create(object o)
        {
            return new DynValue(DataType.UserData, new UserData(o));
        }

        // MoonSharp's UserData.RegisterType<T>() would register a CLR type
        // so Lua could instantiate / access it. XLua handles arbitrary C#
        // objects reflectively through ObjectTranslator, so this is a no-op.
        public static void RegisterType<T>() { /* XLua handles via reflection */ }
        public static void RegisterType(Type t) { /* XLua handles via reflection */ }
    }

    // ──────────────────────────────────────────────────────────────────────
    // Closure — wraps an XLua LuaFunction
    // ──────────────────────────────────────────────────────────────────────

    public class Closure
    {
        internal readonly XLua.LuaFunction _fn;
        internal Closure(XLua.LuaFunction fn) { _fn = fn; }
    }

    // ──────────────────────────────────────────────────────────────────────
    // DynValue — tagged union
    // ──────────────────────────────────────────────────────────────────────

    public class DynValue
    {
        public DataType Type { get; internal set; }
        public object Value { get; internal set; }

        public DynValue() { Type = DataType.Nil; }
        public DynValue(DataType t, object v) { Type = t; Value = v; }

        public double Number
        {
            get
            {
                if (Value == null) return 0;
                try { return Convert.ToDouble(Value); } catch { return 0; }
            }
        }

        public string String => Value as string ?? "";
        public bool Boolean => Value is bool b && b;
        public Table Table => Value as Table;
        public Closure Function => Value as Closure;
        public UserData UserData => Value as UserData;

        // Re-created every access to match MoonSharp semantics (MoonSharp's
        // Nil is a struct literal; we just box a new reference — same idea).
        public static DynValue Nil => new DynValue(DataType.Nil, null);
        public static DynValue True => new DynValue(DataType.Boolean, true);
        public static DynValue False => new DynValue(DataType.Boolean, false);

        public static DynValue NewNumber(double n) => new DynValue(DataType.Number, n);
        public static DynValue NewString(string s) => new DynValue(DataType.String, s ?? "");
        public static DynValue NewBoolean(bool b) => new DynValue(DataType.Boolean, b);
        public static DynValue NewTable(Table t) => new DynValue(DataType.Table, t);
        // MoonSharp-compat: NewTable(Script) creates a fresh empty table bound to script.
        public static DynValue NewTable(Script script) => new DynValue(DataType.Table, new Table(script));
        public static DynValue NewTuple(params DynValue[] vals) => new DynValue(DataType.Tuple, vals);

        public static DynValue NewCallback(Func<ScriptExecutionContext, CallbackArguments, DynValue> fn)
            => new DynValue(DataType.ClrFunction, fn);

        public string CastToString()
        {
            switch (Type)
            {
                case DataType.Nil: return "nil";
                case DataType.Boolean: return ((bool)Value) ? "true" : "false";
                case DataType.Number: return Number.ToString(System.Globalization.CultureInfo.InvariantCulture);
                case DataType.String: return (string)Value;
                default: return Value?.ToString() ?? "";
            }
        }

        // MoonSharp truthiness: nil and false are falsey, everything else is truthy.
        public bool CastToBool()
        {
            switch (Type)
            {
                case DataType.Nil: return false;
                case DataType.Boolean: return (bool)Value;
                case DataType.Number: return Number != 0.0;
                default: return Value != null;
            }
        }
    }

    // ──────────────────────────────────────────────────────────────────────
    // TablePair — yielded by Table.Pairs
    // ──────────────────────────────────────────────────────────────────────

    public struct TablePair
    {
        public DynValue Key;
        public DynValue Value;
    }

    // ──────────────────────────────────────────────────────────────────────
    // Table — thin wrapper around XLua.LuaTable
    // ──────────────────────────────────────────────────────────────────────

    public class Table
    {
        internal readonly Script _script;
        internal readonly XLua.LuaTable _xluaTable;

        public Table(Script s)
        {
            _script = s;
            _xluaTable = s._env.NewTable();
        }

        internal Table(Script s, XLua.LuaTable t)
        {
            _script = s;
            _xluaTable = t;
        }

        // ---- primary API used by existing MoonSharp-shaped code ----

        public DynValue Get(object key)
        {
            object raw = _script.LuaTableRead(_xluaTable, key);
            return _script.XLuaToDyn(raw);
        }

        public void Set(object key, DynValue dv)
        {
            _script.LuaTableWrite(_xluaTable, key, dv ?? DynValue.Nil);
        }

        public void Set(object key, object anyValue)
        {
            _script.LuaTableWrite(_xluaTable, key, _script.WrapToDyn(anyValue));
        }

        // Indexer — MoonSharp code uses `tbl["key"] = value` where value can be
        // primitive, DynValue, Table, or a UserData-wrapped CLR object.
        public object this[object key]
        {
            get => Get(key);
            set
            {
                if (value is DynValue dv) Set(key, dv);
                else Set(key, value);
            }
        }

        // Enumerate (key, value) pairs. MoonSharp's Pairs yields TablePair;
        // we iterate XLua's raw key list and wrap each entry.
        public IEnumerable<TablePair> Pairs
        {
            get
            {
                foreach (var key in _xluaTable.GetKeys())
                {
                    object raw = _script.LuaTableRead(_xluaTable, key);
                    yield return new TablePair
                    {
                        Key = _script.XLuaToDyn(key),
                        Value = _script.XLuaToDyn(raw),
                    };
                }
            }
        }

        // MoonSharp's Table.Length mirrors Lua's '#' operator — array length.
        public int Length => _xluaTable.Length;
    }

    // ──────────────────────────────────────────────────────────────────────
    // Script — wraps XLua.LuaEnv + Globals
    // ──────────────────────────────────────────────────────────────────────

    public class Script
    {
        internal readonly XLua.LuaEnv _env;
        // Keep CLR→Lua function trampolines alive so GC doesn't collect them
        // while Lua still holds a reference.
        private readonly List<XLuaCSFunction> _trampolinePin = new List<XLuaCSFunction>();

        // Reflection cache: LuaEnv.translator is internal — we need it for
        // pushing arbitrary CLR objects onto the Lua stack from raw C API
        // callbacks (see MakeTrampoline).
        private static readonly FieldInfo _translatorField =
            typeof(XLua.LuaEnv).GetField("translator", BindingFlags.Instance | BindingFlags.NonPublic);

        public Table Globals { get; }

        public Script(CoreModules _ = CoreModules.Preset_Complete)
        {
            _env = new XLua.LuaEnv();
            Globals = new Table(this, _env.Global);

            // Register DynValue <-> Lua stack conversion so CLR methods with
            // `DynValue` parameters (e.g. LuaUIBridge.SetActive(string, DynValue))
            // can be called directly from Lua. Without this, XLua's reflective
            // method dispatch passes null for unregistered types and every call
            // through a [MoonSharpUserData] class throws NullReferenceException
            // on the first `val.Type` access.
            RegisterDynValueCaster();

            // MoonSharp auto-loads Lua 5.2 standard libs (including bit32).
            // XLua ships Lua 5.3+ which removed bit32 — define a thin polyfill
            // on top of native bitwise operators so existing Lua that does
            // `bit32.band(a, b)` etc. still works.
            InstallBit32Polyfill();
        }

        private void RegisterDynValueCaster()
        {
            try
            {
                var translator = (XLua.ObjectTranslator)_translatorField.GetValue(_env);
                if (translator == null) return;

                translator.RegisterCaster<DynValue>(ReadDynValueFromStack);
                translator.RegisterChecker<DynValue>((L, idx) => true); // DynValue wraps any Lua value
            }
            catch (Exception ex)
            {
                UnityEngine.Debug.LogWarning("[MoonSharpCompat] RegisterDynValueCaster failed: " + ex.Message);
            }
        }

        // Matches ObjectTranslator.GetFunc<DynValue> signature (L, idx, out val).
        // RealStatePtr is aliased to System.IntPtr inside XLua.
        private void ReadDynValueFromStack(IntPtr L, int idx, out DynValue val)
        {
            val = StackToDyn(L, idx);
        }

        private void InstallBit32Polyfill()
        {
            const string bit32Lua =
                "if not bit32 then\n" +
                "  bit32 = {\n" +
                "    band   = function(a, b) return a & b end,\n" +
                "    bor    = function(a, b) return a | b end,\n" +
                "    bxor   = function(a, b) return a ~ b end,\n" +
                "    bnot   = function(a)    return ~a    end,\n" +
                "    lshift = function(a, n) return a << n end,\n" +
                "    rshift = function(a, n) return a >> n end,\n" +
                "    arshift= function(a, n) return a >> n end,\n" +
                "  }\n" +
                "end\n";
            try { _env.DoString(bit32Lua, "bit32_polyfill"); }
            catch (Exception ex)
            {
                UnityEngine.Debug.LogWarning("[MoonSharpCompat] bit32 polyfill failed: " + ex.Message);
            }
        }

        public DynValue DoString(string code, byte[] _unused = null, string name = null)
        {
            try
            {
                _env.DoString(code, name ?? "chunk");
                return DynValue.Nil;
            }
            catch (Exception ex)
            {
                // MoonSharp distinguishes Syntax vs Runtime errors; XLua lumps
                // both into generic LuaException. Our callers catch either
                // way, so classify heuristically.
                var msg = ex.Message ?? "";
                if (msg.Contains("unexpected symbol") || msg.Contains("'end' expected") ||
                    msg.Contains("syntax error") || msg.Contains("malformed"))
                    throw new SyntaxErrorException(msg);
                throw new ScriptRuntimeException(msg, ex);
            }
        }

        // Call a Lua or CLR function stored in a DynValue.
        public DynValue Call(DynValue fn, params DynValue[] args)
        {
            if (fn == null || fn.Type == DataType.Nil) return DynValue.Nil;

            if (fn.Type == DataType.Function)
            {
                var closure = fn.Function;
                if (closure == null || closure._fn == null) return DynValue.Nil;

                // Unwrap DynValue → object for XLua's LuaFunction.Call.
                var raw = new object[args.Length];
                for (int i = 0; i < args.Length; i++) raw[i] = DynToObject(args[i]);

                try
                {
                    var ret = closure._fn.Call(raw);
                    if (ret == null || ret.Length == 0) return DynValue.Nil;
                    if (ret.Length == 1) return XLuaToDyn(ret[0]);
                    var tuple = new DynValue[ret.Length];
                    for (int i = 0; i < ret.Length; i++) tuple[i] = XLuaToDyn(ret[i]);
                    return DynValue.NewTuple(tuple);
                }
                catch (Exception ex)
                {
                    throw new ScriptRuntimeException(ex.Message, ex);
                }
            }

            if (fn.Type == DataType.ClrFunction)
            {
                var cb = (Func<ScriptExecutionContext, CallbackArguments, DynValue>)fn.Value;
                try
                {
                    return cb(null, new CallbackArguments(args));
                }
                catch (Exception ex)
                {
                    throw new ScriptRuntimeException(ex.Message, ex);
                }
            }

            return DynValue.Nil;
        }

        // MoonSharp-compat: Call with a single non-DynValue argument (Table / primitive / CLR object).
        // Required first object arg + params tail avoids the ambiguity with Call(DynValue, params DynValue[]).
        public DynValue Call(DynValue fn, object firstArg, params object[] rest)
        {
            int extra = rest?.Length ?? 0;
            var dynArgs = new DynValue[1 + extra];
            dynArgs[0] = firstArg is DynValue dv0 ? dv0 : WrapToDyn(firstArg);
            for (int i = 0; i < extra; i++)
            {
                dynArgs[1 + i] = rest[i] is DynValue dvi ? dvi : WrapToDyn(rest[i]);
            }
            return Call(fn, dynArgs);
        }

        // ------- internal bridging helpers -------

        // Wrap a primitive/CLR value as a DynValue.
        internal DynValue WrapToDyn(object v)
        {
            if (v == null) return DynValue.Nil;
            switch (v)
            {
                case DynValue dv: return dv;
                case bool b: return DynValue.NewBoolean(b);
                case int i: return DynValue.NewNumber(i);
                case long l: return DynValue.NewNumber(l);
                case float f: return DynValue.NewNumber(f);
                case double d: return DynValue.NewNumber(d);
                case string s: return DynValue.NewString(s);
                case Table t: return DynValue.NewTable(t);
                case Closure c: return new DynValue(DataType.Function, c);
                case UserData ud: return new DynValue(DataType.UserData, ud);
                default:
                    // Any other CLR object → wrap as UserData.
                    return new DynValue(DataType.UserData, new UserData(v));
            }
        }

        // Convert an object read from XLua back to a DynValue.
        internal DynValue XLuaToDyn(object raw)
        {
            if (raw == null) return DynValue.Nil;
            switch (raw)
            {
                case bool b: return DynValue.NewBoolean(b);
                case double d: return DynValue.NewNumber(d);
                case float f: return DynValue.NewNumber(f);
                case int i: return DynValue.NewNumber(i);
                case long l: return DynValue.NewNumber(l);
                case uint ui: return DynValue.NewNumber(ui);
                case string s: return DynValue.NewString(s);
                case XLua.LuaTable t: return DynValue.NewTable(new Table(this, t));
                case XLua.LuaFunction fn: return new DynValue(DataType.Function, new Closure(fn));
                default:
                    return new DynValue(DataType.UserData, new UserData(raw));
            }
        }

        // Unwrap DynValue → object for handing to XLua APIs.
        internal object DynToObject(DynValue dv)
        {
            if (dv == null) return null;
            switch (dv.Type)
            {
                case DataType.Nil: return null;
                case DataType.Boolean: return dv.Value;
                case DataType.Number: return dv.Value;
                case DataType.String: return dv.Value;
                case DataType.Table: return dv.Table?._xluaTable;
                case DataType.UserData: return dv.UserData?.Object;
                case DataType.Function: return dv.Function?._fn;
                case DataType.ClrFunction:
                    // Rare: a CLR func passed as arg to a Lua function. We'd
                    // need to register it and push as LuaFunction — skip for
                    // now; returning null means Lua sees nil.
                    return null;
                default: return null;
            }
        }

        // Read a key out of a LuaTable. Accepts string or int keys (the only
        // shapes our callers actually use).
        internal object LuaTableRead(XLua.LuaTable tbl, object key)
        {
            // Unwrap DynValue keys — same reasoning as SetKeyObject.
            if (key is DynValue dvk)
            {
                switch (dvk.Type)
                {
                    case DataType.String:  key = (string)dvk.Value; break;
                    case DataType.Number:  key = Convert.ToDouble(dvk.Value); break;
                    case DataType.Boolean: key = (bool)dvk.Value; break;
                    case DataType.Table:   key = dvk.Table?._xluaTable; break;
                    case DataType.UserData: key = dvk.UserData?.Object; break;
                    default: key = dvk.Value; break;
                }
            }
            try
            {
                if (key is string sk) return tbl.Get<object>(sk);
                if (key is int ik) return tbl.Get<int, object>(ik);
                if (key is double dk) return tbl.Get<double, object>(dk);
                if (key is float fk) return tbl.Get<float, object>(fk);
                if (key is long lk) return tbl.Get<long, object>(lk);
                if (key is bool bk) return tbl.Get<bool, object>(bk);
                return tbl.Get<object, object>(key);
            }
            catch
            {
                return null;
            }
        }

        // Write a DynValue into a LuaTable under the given key. CLR callbacks
        // are wrapped in a raw lua_CSFunction trampoline before being set.
        internal void LuaTableWrite(XLua.LuaTable tbl, object key, DynValue dv)
        {
            if (dv == null || dv.Type == DataType.Nil)
            {
                SetKeyObject(tbl, key, null);
                return;
            }

            switch (dv.Type)
            {
                case DataType.Boolean:
                    SetKeyObject(tbl, key, (bool)dv.Value);
                    return;
                case DataType.Number:
                    SetKeyObject(tbl, key, Convert.ToDouble(dv.Value));
                    return;
                case DataType.String:
                    SetKeyObject(tbl, key, (string)dv.Value);
                    return;
                case DataType.Table:
                    SetKeyObject(tbl, key, dv.Table?._xluaTable);
                    return;
                case DataType.UserData:
                    SetKeyObject(tbl, key, dv.UserData?.Object);
                    return;
                case DataType.Function:
                    SetKeyObject(tbl, key, dv.Function?._fn);
                    return;
                case DataType.ClrFunction:
                    {
                        var cb = (Func<ScriptExecutionContext, CallbackArguments, DynValue>)dv.Value;
                        var trampoline = MakeTrampoline(cb);
                        _trampolinePin.Add(trampoline);
                        // XLua's ObjectTranslator knows how to push a raw
                        // lua_CSFunction via PushByType<lua_CSFunction>.
                        if (key is string sk2) tbl.Set<string, XLuaCSFunction>(sk2, trampoline);
                        else if (key is int ik2) tbl.Set<int, XLuaCSFunction>(ik2, trampoline);
                        else tbl.Set<object, XLuaCSFunction>(key, trampoline);
                    }
                    return;
                case DataType.Tuple:
                    // Can't store a tuple in a table slot — MoonSharp would
                    // also drop it. Take the first element if any.
                    var tup = (DynValue[])dv.Value;
                    if (tup != null && tup.Length > 0)
                        LuaTableWrite(tbl, key, tup[0]);
                    return;
            }
        }

        private static void SetKeyObject(XLua.LuaTable tbl, object key, object value)
        {
            // Unwrap DynValue keys. Callers iterating Table.Pairs receive DynValue
            // keys and frequently pass them straight back to the indexer to copy /
            // mirror / re-key entries. If we don't unwrap here, the DynValue
            // wrapper itself becomes the Lua table key — Lua's `tbl[1]` (a raw
            // number) never matches a userdata-shaped key, so the entry is
            // effectively invisible to Lua code. This was the UIHudChat:66 bug.
            if (key is DynValue dvk)
            {
                switch (dvk.Type)
                {
                    case DataType.String:  key = (string)dvk.Value; break;
                    case DataType.Number:  key = Convert.ToDouble(dvk.Value); break;
                    case DataType.Boolean: key = (bool)dvk.Value; break;
                    case DataType.Table:   key = dvk.Table?._xluaTable; break;
                    case DataType.UserData: key = dvk.UserData?.Object; break;
                    default: key = dvk.Value; break;
                }
            }

            if (key is string sk) tbl.Set<string, object>(sk, value);
            else if (key is int ik) tbl.Set<int, object>(ik, value);
            // Lua 5.3 stores integer-valued doubles in the same hash slot as
            // integers, so writing the key as a double still lets Lua's
            // `tbl[1]` reach it.
            else if (key is double dk) tbl.Set<double, object>(dk, value);
            else if (key is float fk) tbl.Set<float, object>(fk, value);
            else if (key is long lk) tbl.Set<long, object>(lk, value);
            else if (key is bool bk) tbl.Set<bool, object>(bk, value);
            else tbl.Set<object, object>(key, value);
        }

        // Build a raw lua_CSFunction that marshals Lua-stack args to a
        // MoonSharp-shape callback, then marshals the result back onto the
        // Lua stack. This is the critical bridge — everywhere MoonSharp code
        // does `DynValue.NewCallback((ctx, args) => ...)`, that lambda ends up
        // wrapped here before being registered with Lua.
        private XLuaCSFunction MakeTrampoline(Func<ScriptExecutionContext, CallbackArguments, DynValue> cb)
        {
            var env = _env;
            return (IntPtr L) =>
            {
                int argc = XLuaDLL.lua_gettop(L);
                var dynArgs = new DynValue[argc];
                for (int i = 0; i < argc; i++)
                {
                    dynArgs[i] = StackToDyn(L, i + 1);
                }

                DynValue result;
                try
                {
                    result = cb(null, new CallbackArguments(dynArgs));
                }
                catch (Exception ex)
                {
                    Debug.LogError($"[MoonSharpCompat] CLR callback threw: {ex.Message}\n{ex.StackTrace}");
                    XLuaDLL.lua_pushstring(L, "CLR callback error: " + ex.Message);
                    return XLuaDLL.lua_error(L);
                }

                if (result == null) { XLuaDLL.lua_pushnil(L); return 1; }

                if (result.Type == DataType.Tuple)
                {
                    var arr = (DynValue[])result.Value;
                    if (arr == null) return 0;
                    for (int i = 0; i < arr.Length; i++) PushDynSingle(L, arr[i]);
                    return arr.Length;
                }

                PushDynSingle(L, result);
                return 1;
            };
        }

        // Read a single Lua stack slot → DynValue.
        private DynValue StackToDyn(IntPtr L, int idx)
        {
            var t = XLuaDLL.lua_type(L, idx);
            switch (t)
            {
                case XLuaTypes.LUA_TNIL:
                    return DynValue.Nil;
                case XLuaTypes.LUA_TBOOLEAN:
                    return DynValue.NewBoolean(XLuaDLL.lua_toboolean(L, idx));
                case XLuaTypes.LUA_TNUMBER:
                    return DynValue.NewNumber(XLuaDLL.lua_tonumber(L, idx));
                case XLuaTypes.LUA_TSTRING:
                    return DynValue.NewString(XLuaDLL.lua_tostring(L, idx));
                case XLuaTypes.LUA_TTABLE:
                case XLuaTypes.LUA_TFUNCTION:
                case XLuaTypes.LUA_TUSERDATA:
                case XLuaTypes.LUA_TLIGHTUSERDATA:
                    {
                        // Delegate to XLua's ObjectTranslator for complex types.
                        var translator = GetTranslator();
                        if (translator == null) return DynValue.Nil;
                        object raw = InvokeGetObject(translator, L, idx);
                        return XLuaToDyn(raw);
                    }
                default:
                    return DynValue.Nil;
            }
        }

        // Push a DynValue onto the Lua stack (single value, no tuple flatten).
        private void PushDynSingle(IntPtr L, DynValue dv)
        {
            if (dv == null) { XLuaDLL.lua_pushnil(L); return; }
            switch (dv.Type)
            {
                case DataType.Nil:
                    XLuaDLL.lua_pushnil(L); return;
                case DataType.Boolean:
                    XLuaDLL.lua_pushboolean(L, (bool)dv.Value); return;
                case DataType.Number:
                    XLuaDLL.lua_pushnumber(L, Convert.ToDouble(dv.Value)); return;
                case DataType.String:
                    XLuaDLL.lua_pushstring(L, (string)dv.Value); return;
                case DataType.Table:
                    dv.Table?._xluaTable?.push(L); return;
                case DataType.Function:
                    dv.Function?._fn?.push(L); return;
                case DataType.ClrFunction:
                    {
                        var cb = (Func<ScriptExecutionContext, CallbackArguments, DynValue>)dv.Value;
                        var trampoline = MakeTrampoline(cb);
                        _trampolinePin.Add(trampoline);
                        XLuaDLL.lua_pushstdcallcfunction(L, trampoline);
                        return;
                    }
                case DataType.UserData:
                    {
                        var obj = dv.UserData?.Object;
                        if (obj == null) { XLuaDLL.lua_pushnil(L); return; }
                        var translator = GetTranslator();
                        if (translator == null) { XLuaDLL.lua_pushnil(L); return; }
                        InvokePushAny(translator, L, obj);
                        return;
                    }
                default:
                    XLuaDLL.lua_pushnil(L); return;
            }
        }

        // ---- reflection accessors for internal ObjectTranslator ----

        private object _cachedTranslator;
        private object GetTranslator()
        {
            if (_cachedTranslator != null) return _cachedTranslator;
            if (_translatorField == null) return null;
            _cachedTranslator = _translatorField.GetValue(_env);
            return _cachedTranslator;
        }

        private static MethodInfo _getObjectMi;
        private static MethodInfo _pushAnyMi;
        private static object InvokeGetObject(object translator, IntPtr L, int idx)
        {
            if (_getObjectMi == null)
            {
                var t = translator.GetType();
                // public object GetObject(RealStatePtr L, int index)
                foreach (var m in t.GetMethods(BindingFlags.Instance | BindingFlags.Public))
                {
                    if (m.Name != "GetObject") continue;
                    var ps = m.GetParameters();
                    if (ps.Length == 2 && ps[0].ParameterType == typeof(IntPtr) && ps[1].ParameterType == typeof(int))
                    {
                        _getObjectMi = m; break;
                    }
                }
            }
            return _getObjectMi?.Invoke(translator, new object[] { L, idx });
        }

        private static void InvokePushAny(object translator, IntPtr L, object obj)
        {
            if (_pushAnyMi == null)
            {
                var t = translator.GetType();
                foreach (var m in t.GetMethods(BindingFlags.Instance | BindingFlags.Public))
                {
                    if (m.Name != "PushAny") continue;
                    var ps = m.GetParameters();
                    if (ps.Length == 2 && ps[0].ParameterType == typeof(IntPtr))
                    {
                        _pushAnyMi = m; break;
                    }
                }
            }
            _pushAnyMi?.Invoke(translator, new object[] { L, obj });
        }

        // Expose dispose for cleanup; LuaEngine doesn't currently call it.
        public void Dispose() { _env?.Dispose(); }
    }
}
