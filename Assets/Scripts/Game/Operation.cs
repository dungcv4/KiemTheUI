using UnityEngine;
using KTO.Network;

namespace KTO.Game
{
    // Source: 39_CommonUI/Lua/Script_Common_Operation.lua (module `Operation`)
    //   Init               line 12  — zeroes state, called once at module load
    //   EnableWalking      line 53  — bForbidClickMap = false
    //   DisableWalking     line 48  — bOnJoyStick = false, bForbidClickMap = true
    //   BlockTouch         line 57  — bBlock = bBlock
    //   GoDirection        line 71  — the main state machine
    //   StopGoDir          line 127 — settle-and-stop
    //   ClearLastDir       line 152 — nLastGoDir = nil, bOnJoyStick = false
    //
    // In the original client `Operation` is a Lua module (table) with singleton
    // state. Both keyboard hotkeys (Script_Common_Operation.lua:1020-1044
    // tbKeyOnTypeFun.Move.On) and the touch joystick (UIJoyStick.OnMove in
    // KTO_DecompiledReference/_root/UIJoyStick.c @ 0x01cc4c27) feed into the
    // same `Operation:GoDirection(nDir)` / `Operation:StopGoDir()` pair.
    //
    // Static-class port preserves that single-owner semantics without forcing
    // every input source to hold a PlayerMotor reference. The motor is
    // registered once (PlayerMotor.Awake) and used by every dispatcher.
    public static class Operation
    {
        static PlayerMotor _motor;

        // --- state (mirrors Lua `self` fields) ---
        //
        // In Lua these live on the `Operation` table. The default is nil for
        // nLastGoDir; we use -1 as the C# equivalent ("no key held").
        public static int  nLastGoDir         = -1;
        public static bool bOnJoyStick        = false;
        public static bool bBlock             = false;
        public static bool bForbidClickMap    = false;
        public static bool bIsClickMap        = false; // lua field set by AutoPath:InitGoAndDoSomethingDataAndfnAfterWalk
        public static bool bIsClickMapPathing = false; // lua:330 — gate for ignoring new clicks while pathing
        public static int  nKickFrame         = 0;     // lua:344 — kick counter reset by ClickMap

        // --- registration ---

        // Called by PlayerMotor.Awake. Not in the original (Lua uses the
        // global `me` reference). This is the C#-side wiring.
        public static void RegisterMotor(PlayerMotor motor)
        {
            _motor = motor;
            Init();
        }

        public static void UnregisterMotor(PlayerMotor motor)
        {
            if (_motor == motor) _motor = null;
        }

        // --- lua: Operation:Init ---
        // Line 12. Called at module load + OnMapLoaded. Safe to re-run.
        public static void Init()
        {
            bBlock          = false;
            nLastGoDir      = -1;
            bOnJoyStick     = false;
        }

        // --- lua: Operation:EnableWalking / DisableWalking ---
        public static void EnableWalking()  { bForbidClickMap = false; }
        public static void DisableWalking() { bOnJoyStick = false; bForbidClickMap = true; }

        // --- lua: Operation:BlockTouch ---
        public static void BlockTouch(bool block) { bBlock = block; }

        // --- lua: Operation:GoDirection (line 71-125) ---
        //
        // Original:
        //   if not nDir then return end
        //   if AFK:IsRunning() then AFK:InterruptStep_GoToFightPos() end
        //   AFK:Suspend()
        //   local nDoing = me.GetDoing()
        //   if self.nLastGoDir == nDir
        //      and nDoing ~= do_hover
        //      and nDoing ~= do_qingkung
        //      and nDoing ~= stand
        //   then return end
        //   ... (team-follow, event notify, special-move, block, ride, forbid-move) ...
        //   me.GoDirection(nDir, Env.GAME_FPS * 10)
        //   me.StartDirection(nDir)
        //   self.nLastGoDir = nDir
        //   self.bOnJoyStick = true
        //
        // Port: AFK / team-follow / special-move / ride are all server/Lua
        // subsystems we don't have yet. Phase 8.1 omits them — see open
        // follow-ups in PLAYER_SPAWN_PLAN.md. The core state machine (early-
        // out + GoDirection + StartDirection + nLastGoDir update) is verbatim.
        //
        // The early-out "nDoing != stand" branch is what lets a held direction
        // re-fire once the prior budget drains. We translate "doing == stand"
        // to "RemainingFrames == 0" on the motor, which is the same signal.
        public static void GoDirection(int nDir)
        {
            if (nDir < 0) return;
            if (_motor == null) return;

            // nLastGoDir == nDir AND !stand-ish  → skip
            // i.e. only re-fire when the direction changed OR the budget drained.
            bool dirChanged      = (nLastGoDir != nDir);
            bool budgetExhausted = (_motor.RemainingFrames == 0);
            if (!dirChanged && !budgetExhausted) return;

            if (bBlock) return;

            _motor.GoDirection(nDir, Env.GAME_FPS * 10);
            _motor.StartDirection(nDir);
            nLastGoDir  = nDir;
            bOnJoyStick = true;
        }

        // --- lua: Operation:StopGoDir (line 127-150) ---
        //
        // Original:
        //   if not me then return end
        //   local nPlayerDoing = me.GetDoing()
        //   if nPlayerDoing == dospecial* then return end
        //   if not pMeNpc or forbid_move or self.bBlock then return end
        //   if self.nLastGoDir then me.GoDirection(self.nLastGoDir, 2) end
        //   me.StopDirection()
        //   self:ClearLastDir()
        public static void StopGoDir()
        {
            if (_motor == null) return;
            if (bBlock) return;

            if (nLastGoDir >= 0)
            {
                _motor.GoDirection(nLastGoDir, 2);
            }
            _motor.StopDirection();
            ClearLastDir();
        }

        // --- lua: Operation:ClearLastDir (line 152-155) ---
        public static void ClearLastDir()
        {
            nLastGoDir  = -1;
            bOnJoyStick = false;
        }

        // --- lua: Operation:ClickMap (line 293-346) ----------------------
        //
        // Ported verbatim with the omitted subsystems marked inline. The
        // arguments match the Lua signature 1:1:
        //
        //   nX, nY          — target LOGIC coords (despite the Lua name;
        //                      see AutoPath.cs:_GotoPosition comment on
        //                      `me.GetWorldPos` returning logic).
        //   isDoubleClick   — repeat-click detection; unused by the trimmed
        //                      port (TeamMgr / AFK paths only).
        //   bIsIgnoreFollow — bypass TeamMgr follow check. We don't have
        //                      TeamMgr so this is always effectively true.
        //
        // Omitted subsystems (lua refs inline):
        //   ❌ TeamMgr:IsFollowTeammateWithMsg          lua:295
        //   ❌ AFK:IsRunning / InterruptStep_GoToFightPos lua:298
        //   ❌ me.GetDoing() == dospecial*              lua:302
        //   ❌ pNpc.HaveRefFlag(npc_forbid_move)        lua:312
        //   ❌ Login.bEnterGame                         lua:315
        //   ❌ me.GetDoing() == do_qingkung             lua:327
        //   ❌ AFK:Suspend / AFK:Resume                 lua:331,342
        //   ❌ Client.NavigationModule.ClearPathLine    lua:332
        //
        // These branches are either gated on server state or on HUD
        // subsystems that aren't ported yet. They are ALL guards that
        // short-circuit the click; not skipping them in our port is safe
        // because the guards default to "allow click" when their state is
        // absent.
        public static bool ClickMap(int nX, int nY, bool isDoubleClick = false, bool bIsIgnoreFollow = false)
        {
            // lua:295 — TeamMgr follow gate (omitted; no TeamMgr)
            // lua:298-300 — AFK interrupt (omitted; no AFK)
            // lua:302-304 — special move state (omitted; no server sync)
            // lua:305-313 — me / pNpc / npc_forbid_move checks (omitted)
            // lua:315-317 — Login.bEnterGame (omitted; we're past login)

            // lua:318-320 — bOnJoyStick interlock: a held joystick cancels
            // any click-to-move request. This IS implemented.
            if (bOnJoyStick) return false;

            // lua:321-323 — bForbidClickMap gate (set by DisableWalking).
            if (bForbidClickMap) return false;

            // lua:324-326 — negative logic coords are rejected.
            if (nX < 0 || nY < 0) return false;

            // lua:327-329 — me.GetDoing() == do_qingkung (omitted; lightness
            // skill mode, not ported).

            // lua:330 — flag "we own the motor now"
            bIsClickMapPathing = true;

            // lua:331 — AFK:Suspend (omitted)
            // lua:332 — Client.NavigationModule.ClearPathLine (omitted; visual)

            // lua:333-343 — the single GotoAndCallEx call with three
            // identical-looking callbacks.
            //
            // In the Lua, fnSucceed / fnFail / fnFinish all just reset
            // bIsClickMapPathing and WalkFail additionally calls AFK:Resume.
            // We fold them into lambdas that clear the flag; AFK:Resume is
            // skipped as noted above.
            //
            // nMapId is passed as 0 since we only ever run on a single map
            // (cross-map switching is an omitted subsystem of AutoPath).
            AutoPath.GotoAndCallEx(
                nMapId:      0,
                nX:          nX,
                nY:          nY,
                fnSucceed:   () => { bIsClickMapPathing = false; },
                nNearLength: AutoPath.MIN_DISTANCE,
                // lua uses 4× nil for nTaskId..nTransY then fnFail+fnFinish
                fnFail:      () => { bIsClickMapPathing = false; },
                fnFinish:    () => { bIsClickMapPathing = false; /* AFK:Resume omitted */ });

            nKickFrame = 0; // lua:344
            return false;   // lua:345 — returns false explicitly
        }

        // ===================================================================
        //  SimpleTap — lua: Operation:SimpleTap (line 157-206)
        //
        //  Source: 39_CommonUI/Lua/Script_Common_Operation.lua:157-206
        //  Called from: InputModule.On_SimpleTap → LuaTables.SimpleTap delegate
        //               → Lua Operation:SimpleTap(nNpcID, isFriend)
        //
        //  Dispatches by NPC kind:
        //    - Dialoger (kind=2) → OnDialogerClicked → walk to NPC + interact
        //    - Normal hostile    → SimpleTapEnemy → target for attack
        //    - Player (kind=1)   → show role info popup
        //
        //  Phase 9.2: dialoger path is fully ported. Enemy targeting and
        //  player info popups are stubs (log only) until combat / UI phases.
        // ===================================================================
        public static void SimpleTap(int nNpcID, bool isFriend)
        {
            // Source: lua:158 — local pNpc = KNpc.GetById(nNpcID)
            Npc npc = NpcManager.GetNpc(nNpcID);
            if (npc == null) return;

            // Source: lua:159 — if pNpc.nPlayerID == me.dwID then return end
            // Skip self-click. bIsMe is the C# equivalent.
            if (npc.m_bIsMe) return;

            int nKind = npc.m_nKind;

            // Source: lua:161-189 — dispatch by kind
            if (nKind == (int)NpcKind.Player)
            {
                // Source: lua:162-186 — player kind
                // Two sub-cases: real player vs monster disguised as player
                // Phase 9.2: both just log + select. Full UI popup deferred.
                Debug.Log($"[Operation] SimpleTap player NPC id={nNpcID} isFriend={isFriend}");
                // TODO Phase 10+: show UIHud:ShowRoleHeadPop with player info

                if (!isFriend)
                {
                    SimpleTapEnemy(npc);
                }
            }
            else if (nKind == (int)NpcKind.Dialoger)
            {
                // Source: lua:187-190
                //   Operation:OnDialogerClicked(pNpc.nId)
                //   Operation:SetNpcSelected(nNpcID, false)
                OnDialogerClicked(nNpcID);
            }
            else if (nKind == (int)NpcKind.Normal && !isFriend)
            {
                // Source: lua:191-193 — normal hostile NPC
                SimpleTapEnemy(npc);
            }
            else
            {
                // Other kinds (partner, god, mechanism, etc.)
                Debug.Log($"[Operation] SimpleTap kind={nKind} id={nNpcID} — no handler yet");
            }
        }

        // ===================================================================
        //  SimpleTapEnemy — lua: Operation:SimpleTapEnemy (line 209-226)
        //
        //  Source: 39_CommonUI/Lua/Script_Common_Operation.lua:209-226
        //  Selects an enemy NPC as the attack target.
        //
        //  Phase 9.2: stub — logs the target. Combat system not ported yet.
        // ===================================================================
        static void SimpleTapEnemy(Npc npc)
        {
            if (npc == null) return;

            // Source: lua:211 — local nTargetId = self:GetLockTargetNpcId()
            // Source: lua:213-226 — AFK/AutoFight branch vs normal branch
            // Phase 9.2: no combat system. Just log.
            Debug.Log($"[Operation] SimpleTapEnemy id={npc.m_nNpcID} " +
                      $"— combat targeting not ported yet");
        }

        // ===================================================================
        //  OnDialogerClicked — lua: Operation:OnDialogerClicked (line 348-382)
        //
        //  Source: 39_CommonUI/Lua/Script_Common_Operation.lua:348-382
        //
        //  Flow:
        //    1. Get NPC position + dialog distance
        //    2. If player is in range → open dialog immediately
        //    3. If too far → AutoPath to NPC, then retry on arrive
        //
        //  Phase 9.2: auto-path to NPC is ported via AutoPath.GotoAndCallEx.
        //  Dialog opening is a stub (log) — NPC dialog UI not ported yet.
        //
        //  Constants:
        //    Npc.MIN_DISTANCE    = 256 logic units (AutoPath.cs:55)
        //    Npc.DIALOG_DISTANCE = 614 logic units (AutoPath.cs:56)
        // ===================================================================
        public static void OnDialogerClicked(int nNpcID, int nTaskId = 0)
        {
            Npc npc = NpcManager.GetNpc(nNpcID);
            if (npc == null)
            {
                Debug.LogWarning($"[Operation] OnDialogerClicked: NPC {nNpcID} not found");
                return;
            }

            // Source: lua:350-351
            //   local nDistance = me.GetNpc().GetDistance(pNpc.nId)
            //   local nDialogDistance = GetNpcDialogDistance(pNpc.nTemplateId)
            //
            // Phase 9.2: compute distance in logic units between player and NPC.
            // Note: Player may be either an NpcManager entity (bIsMe=true) or
            //       a standalone PlayerAssembler. Try NpcManager first, then
            //       fall back to finding the player GameObject by tag/name.
            Vector3 playerWorldPos;
            Npc playerNpc = NpcManager.GetPlayer();
            if (playerNpc != null)
            {
                playerWorldPos = playerNpc.m_vePos;
            }
            else
            {
                // Fallback: find player GameObject directly
                var playerGo = GameObject.FindGameObjectWithTag("Player");
                if (playerGo == null) playerGo = GameObject.Find("Player_ma_000a_free");
                if (playerGo == null)
                {
                    Debug.LogWarning("[Operation] OnDialogerClicked: no player found");
                    return;
                }
                playerWorldPos = playerGo.transform.position;
            }

            // Source: Npc.GetDistance returns logic-space distance
            int playerLogicX = Env.World2Logic(playerWorldPos.x);
            int playerLogicY = Env.World2Logic(playerWorldPos.y);
            int npcLogicX    = Env.World2Logic(npc.m_vePos.x);
            int npcLogicY    = Env.World2Logic(npc.m_vePos.y);

            int dx = playerLogicX - npcLogicX;
            int dy = playerLogicY - npcLogicY;
            float distSq = (float)dx * dx + (float)dy * dy;
            float dist   = Mathf.Sqrt(distSq);

            // Source: lua:352 — GetNpcDialogDistance(nTemplateId)
            //   returns pNpc.nDialogDistance or default Npc.DIALOG_DISTANCE (614)
            // Phase 9.2: use dialog radius from NpcResTemplate if available,
            // converted to logic units. Fallback to DIALOG_DISTANCE.
            const int DIALOG_DISTANCE = 614; // AutoPath.cs:56
            const int MIN_DISTANCE    = 256; // AutoPath.cs:55
            int nDialogDistance = DIALOG_DISTANCE;
            if (npc.m_NpcResTemplate != null && npc.m_NpcResTemplate.m_fDialogRadius > 0f)
            {
                // Convert world-space dialog radius to logic units
                int templateDist = Env.World2Logic(npc.m_NpcResTemplate.m_fDialogRadius);
                if (templateDist > 0) nDialogDistance = templateDist;
            }

            Debug.Log($"[Operation] OnDialogerClicked id={nNpcID} dist={dist:F0} " +
                      $"dialogDist={nDialogDistance}");

            if (dist < 0f) return; // Source: lua:354 — if nDistance < 0

            if (dist > nDialogDistance)
            {
                // Source: lua:356-362 — too far, auto-path to NPC then retry
                //   AutoPath:GotoAndCallEx(nMapId, nX, nY, function()
                //     Operation:OnDialogerClicked(nNpcID)
                //   end, nDialogDistance - Npc.MIN_DISTANCE, nil, pNpc.nTemplateId)
                if (AutoPath.IsPathing())
                {
                    Debug.Log("[Operation] OnDialogerClicked: already pathing, skip");
                    return;
                }

                int nearLen = Mathf.Max(nDialogDistance - MIN_DISTANCE, MIN_DISTANCE);
                AutoPath.GotoAndCallEx(
                    nMapId:      0,
                    nX:          npcLogicX,
                    nY:          npcLogicY,
                    fnSucceed:   () => { OnDialogerClicked(nNpcID); },
                    nNearLength: nearLen,
                    fnFail:      () => { Debug.Log($"[Operation] OnDialogerClicked: path failed to NPC {nNpcID}"); },
                    fnFinish:    null);
                return;
            }

            // Source: lua:364-382 — in range, open dialog
            // Phase 9.3: send click to server for dialog handling
            //   lua:380 — RemoteServer.OnSimpleTapNpc(pNpc.nId)
            //   The server processes the click via CMD_KT_CLICKON_NPC (50004)
            //   and responds with CMD_KT_G2C_NPCDIALOG (50005) if applicable.
            NpcNetworkHandler.SendClickNpc(nNpcID);

            // Phase 11: Open dialog UI
            // In the full flow, the server responds with dialog content via
            // CMD_KT_G2C_NPCDIALOG → NpcNetworkHandler → NpcDialogUI.ShowDialog.
            // Without a server, show a mock dialog immediately.
            // Source: Dialog.lua:CommonShow → CallClientScript("Ui:UpdateDialog", ...)
            if (NpcDialogUI.Instance != null)
            {
                var mockData = NpcDialogUI.CreateMockDialog(npc);
                if (mockData != null)
                    NpcDialogUI.Instance.ShowDialog(mockData);
            }

            Debug.Log($"[Operation] OnDialogerClicked: NPC {nNpcID} in range — dialog opened");
        }
    }
}
