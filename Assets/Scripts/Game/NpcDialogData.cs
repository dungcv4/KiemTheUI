namespace KTO.Game
{
    // =======================================================================
    //  NpcDialogData.cs — Data structures for NPC dialog content
    //
    //  Source: Script_Ui_Window_UINpcDialog.lua:60-125
    //          Dialog.lua:CommonShow → pPlayer.CallClientScript("Ui:UpdateDialog",
    //            tbDlgToClient, false, szNpcName, nNpcTemplateId, soundId, npcId)
    //
    //  Original Lua table structure (tbDlgToClient):
    //    {
    //      Text = "string",           -- dialog message
    //      nCountdown = number,       -- optional auto-close
    //      bCanSkip = boolean,        -- can skip dialog
    //      OptList = {
    //        { Text="string", Callback=0|1, Type="Script", DelayClose=bool },
    //        ...
    //      }
    //    }
    //
    //  Phase 11: C# mirror of the Lua table for use without a server.
    // =======================================================================

    [System.Serializable]
    public class NpcDialogOption
    {
        /// <summary>Option button text (may contain i18n markers).</summary>
        public string Text;

        /// <summary>0 = no callback (just close), 1 = has callback.</summary>
        public int Callback;

        /// <summary>Handler type: "Script" for client-side Lua.</summary>
        public string Type;

        /// <summary>Whether to delay-close after selecting.</summary>
        public bool DelayClose;
    }

    [System.Serializable]
    public class NpcDialogData
    {
        /// <summary>Dialog message body text.</summary>
        public string Text;

        /// <summary>List of dialog options (buttons).</summary>
        public NpcDialogOption[] OptList;

        /// <summary>Auto-close countdown (seconds). 0 = no countdown.</summary>
        public float nCountdown;

        /// <summary>Whether the dialog can be skipped.</summary>
        public bool bCanSkip;

        // --- Context fields (passed alongside tbDlgToClient) ---

        /// <summary>True if this is a client-side dialog (no server round-trip).</summary>
        public bool bIsClient;

        /// <summary>NPC display name.</summary>
        public string szNpcName;

        /// <summary>NPC template ID (for default dialog lookup).</summary>
        public int nNpcTemplate;

        /// <summary>Sound effect ID (0 = none).</summary>
        public int nSoundId;

        /// <summary>NPC entity ID (for positioning / facing).</summary>
        public int nNpcID;
    }
}
