using UnityEngine;

namespace KTO.Game
{
    /// <summary>
    /// Desktop WASD / arrow-key input source. Matches the
    /// <c>Operation:GoDirection</c> / <c>Operation:StopGoDir</c> flow from
    /// <c>39_CommonUI/Lua/Script_Common_Operation.lua</c> exactly.
    ///
    /// ORIGINAL MAPPING (source: Script_Common_Operation.lua lines 1020-1044):
    ///   tbKeyOnTypeFun = {
    ///     Move = {
    ///       Enter = OnMoveJoyStickStart,
    ///       Leave = StopGoDir + OnMoveJoyStickStop,
    ///       On = function(self, tbKey)
    ///         local nV = 0  -- X axis: LEFT=-1, RIGHT=+1
    ///         if tbKey.HOTKEY_MOVE_LEFT  then nV = -1
    ///         elseif tbKey.HOTKEY_MOVE_RIGHT then nV =  1 end
    ///         local nH = 0  -- Y axis: BACK=-1, FORWARD=+1
    ///         if tbKey.HOTKEY_MOVE_FORWARD then nH =  1
    ///         elseif tbKey.HOTKEY_MOVE_BACK then nH = -1 end
    ///         local nDir = CS.Joystick.GetJoyStickDirByAxis(Ui.Vector2(nV, nH))
    ///         self:GoDirection(nDir)
    ///       end
    ///     }
    ///   }
    ///
    /// And <c>Operation:GoDirection(nDir)</c> (line 71-125) early-outs if
    /// <c>nLastGoDir == nDir AND Npc.Doing ~= stand/hover/qingkung</c>, then
    /// fires:
    ///     me.GoDirection(nDir, Env.GAME_FPS * 10)
    ///     me.StartDirection(nDir)
    /// On key release, <c>Operation:StopGoDir</c> (line 127-149) fires:
    ///     me.GoDirection(nLastGoDir, 2)
    ///     me.StopDirection()
    ///
    /// We mirror this state machine via <see cref="PlayerMotor"/>.
    /// </summary>
    [RequireComponent(typeof(PlayerMotor))]
    public class PlayerInputController : MonoBehaviour
    {
        void Awake()
        {
            // PlayerMotor.Awake already calls Operation.RegisterMotor, so by
            // the time our Update ticks, Operation.GoDirection has a live
            // motor to dispatch to. Nothing to wire here.
        }

        void Update()
        {
            // Build the (nV, nH) axis exactly like the Lua hotkey handler.
            // Source: Script_Common_Operation.lua:1020-1044 tbKeyOnTypeFun.Move.On
            float nV = 0f, nH = 0f;
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))  nV = -1f;
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) nV = +1f;
            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))  nH = -1f;
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))    nH = +1f;

            // Lua: local nDir = CS.Joystick.GetJoyStickDirByAxis(Ui.Vector2(nV, nH))
            //      self:GoDirection(nDir)
            int dir = UIJoyStick.GetJoyStickDirByAxis(new Vector2(nV, nH));

            if (dir < 0)
            {
                // Leave branch in Lua: tbKeyOnTypeFun.Move.Leave → StopGoDir
                Operation.StopGoDir();
                return;
            }

            // On-hold branch: every frame re-posts GoDirection. Operation's
            // internal early-out (nLastGoDir == dir && !stand) handles the
            // re-fire gating, matching Script_Common_Operation.lua:80-82.
            Operation.GoDirection(dir);
        }

        // Legacy hook — CollisionSmokeTestDriver still calls this when it
        // takes control of the player. Forward to the singleton.
        public void ClearLastDir()
        {
            Operation.ClearLastDir();
        }
    }
}
