// Phase A "fake gate" — receives CMD_SPR_FIRE_EVENT from server and forwards
// the eventId to the MoonSharp Lua engine as `EventNotify:OnNotify(id)`.
//
// LuaEngine lives in MainUIScene and registers itself here on Awake().
// Because the server can fire events before the scene loads (ordering is
// "ack play game" → C# loads scene → Lua awakes → "fire event" arrives),
// we queue events that arrive while no engine is registered and replay
// them as soon as one binds.
using System.Collections.Generic;
using MoonSharp.Interpreter;
using UnityEngine;

namespace KTO.Network
{
    public static class LuaEventBridge
    {
        private static Script _lua;
        private static readonly Queue<int> _pending = new Queue<int>();

        /// <summary>Called by LuaEngine.InitializeLua() after the script is built.</summary>
        public static void Bind(Script lua)
        {
            _lua = lua;
            Debug.Log($"[LuaEventBridge] bound (replaying {_pending.Count} queued events)");
            while (_pending.Count > 0)
                Dispatch(_pending.Dequeue());
        }

        public static void Unbind(Script lua)
        {
            if (_lua == lua) _lua = null;
        }

        /// <summary>Called by LoginManager.OnRecvFireEvent.</summary>
        public static void Fire(int eventId)
        {
            if (_lua == null)
            {
                Debug.Log($"[LuaEventBridge] queue eventId={eventId} (engine not yet bound)");
                _pending.Enqueue(eventId);
                return;
            }
            Dispatch(eventId);
        }

        private static void Dispatch(int eventId)
        {
            try
            {
                var notify = _lua.Globals.Get("EventNotify");
                if (notify.Type != DataType.Table)
                {
                    // Phase A: EventNotify.lua not loaded yet — UIHud already auto-opened
                    // via LuaEngine, so this is just a no-op.
                    Debug.Log($"[LuaEventBridge] EventNotify global missing, eventId={eventId} ignored");
                    return;
                }
                var fn = notify.Table.Get("OnNotify");
                if (fn.Type != DataType.Function)
                {
                    Debug.Log($"[LuaEventBridge] EventNotify.OnNotify missing, eventId={eventId} ignored");
                    return;
                }
                _lua.Call(fn, notify, DynValue.NewNumber(eventId));
            }
            catch (System.Exception ex)
            {
                Debug.LogError($"[LuaEventBridge] dispatch eventId={eventId} failed: {ex.Message}");
            }
        }
    }
}
