using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace KTO.Game
{
    // =======================================================================
    //  NpcDialogUI.cs — NPC Dialog window controller (Phase 11)
    //
    //  Port of: Script_Ui_Window_UINpcDialog.lua (292 lines)
    //  Prefab:  Assets/Prefabs/Imported/UINpcDialog.prefab (res_p_151)
    //
    //  Original architecture:
    //    - Lua tbWnd = Ui:CreateWindow("UINpcDialog")
    //    - tbControls maps paths to UI elements
    //    - tbOnClick maps button names to click handlers
    //    - OnOpen(tbDlgToClient, bIsClient, szNpcName, ...) called by Ui:UpdateDialog
    //    - UpdateDialog populates txtMsg, txtNpcName, option buttons
    //    - OnSelectOption(nIndex) sends selection to server or local handler
    //
    //  Phase 11 C# port:
    //    - Manages the UINpcDialog prefab instance
    //    - Populates text and option buttons from NpcDialogData
    //    - Mock dialog data for testing without server
    //    - Wire: Operation.OnDialogerClicked → reach NPC → NpcDialogUI.ShowDialog
    //
    //  Source citations:
    //    tbControls (lua:17-29):
    //      btnClose = "Panel/imgBG/btnClose"
    //      txtMsg = "Panel/imgBG/top/txtMsg"
    //      txtNpcName = "Panel/imgBG/top/txtNpcName"
    //      btnOptionTemplate = "Panel/imgBG/panelButton/options/options/btnOptionTemplate"
    //      imgBG = "Panel/imgBG"
    //      btnSkip = "Panel/btnSkip"
    //      btnAutoNext = "Panel/imgBG/btnAutoNext"
    // =======================================================================

    public class NpcDialogUI : MonoBehaviour
    {
        public static NpcDialogUI Instance { get; private set; }

        // --- UI references (matching lua tbControls paths) ---
        Text _txtMsg;
        Text _txtNpcName;
        Button _btnClose;
        Button _btnSkip;
        GameObject _imgBG;
        GameObject _btnOptionTemplate;
        Transform _optionsContent;

        // --- State ---
        NpcDialogData _currentDialog;
        readonly List<GameObject> _spawnedOptions = new List<GameObject>();
        GameObject _dialogRoot;

        // --- Prefab path ---
        const string PREFAB_PATH = "Prefabs/Imported/UINpcDialog";

        void Awake()
        {
            if (Instance != null && Instance != this) { Destroy(gameObject); return; }
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        void OnDestroy()
        {
            if (Instance == this) Instance = null;
        }

        // =================================================================
        //  Init — Create the dialog UI from the imported prefab
        //
        //  Called once from GameStart or on first ShowDialog.
        //  Source: Lua Ui:CreateWindow("UINpcDialog") → instantiates prefab
        // =================================================================
        public void Init()
        {
            if (_dialogRoot != null) return;

            // Load the imported prefab
            // Source: UINpcDialog prefab built from res_p_151.ab via ONE-SHOT PIPELINE
            var prefab = Resources.Load<GameObject>(PREFAB_PATH);
            if (prefab == null)
            {
                // Try direct instantiation from AssetDatabase in editor
#if UNITY_EDITOR
                prefab = UnityEditor.AssetDatabase.LoadAssetAtPath<GameObject>(
                    "Assets/Prefabs/Imported/UINpcDialog.prefab");
#endif
                if (prefab == null)
                {
                    Debug.LogError("[NpcDialogUI] UINpcDialog prefab not found!");
                    return;
                }
            }

            _dialogRoot = Instantiate(prefab);
            _dialogRoot.name = "UINpcDialog";
            DontDestroyOnLoad(_dialogRoot);

            // Ensure the Canvas is set up for screen space overlay
            var canvas = _dialogRoot.GetComponent<Canvas>();
            if (canvas != null)
            {
                canvas.renderMode = RenderMode.ScreenSpaceOverlay;
                canvas.sortingOrder = 100;  // above game world, below top UI
            }

            // --- Resolve UI references from tbControls paths ---
            // Source: Script_Ui_Window_UINpcDialog.lua:17-29
            var panel = _dialogRoot.transform.Find("Panel");
            if (panel == null)
            {
                Debug.LogError("[NpcDialogUI] Panel not found in UINpcDialog prefab");
                return;
            }

            // txtMsg = "Panel/imgBG/top/txtMsg"
            var txtMsgTr = panel.Find("imgBG/top/txtMsg");
            if (txtMsgTr != null) _txtMsg = txtMsgTr.GetComponent<Text>();

            // txtNpcName = "Panel/imgBG/top/txtNpcName"
            var txtNameTr = panel.Find("imgBG/top/txtNpcName");
            if (txtNameTr != null) _txtNpcName = txtNameTr.GetComponent<Text>();

            // btnClose = "Panel/imgBG/btnClose"
            var btnCloseTr = panel.Find("imgBG/btnClose");
            if (btnCloseTr != null)
            {
                _btnClose = btnCloseTr.GetComponent<Button>();
                if (_btnClose == null) _btnClose = btnCloseTr.gameObject.AddComponent<Button>();
                _btnClose.onClick.AddListener(OnClose);
            }

            // btnSkip = "Panel/btnSkip"
            var btnSkipTr = panel.Find("btnSkip");
            if (btnSkipTr != null)
            {
                _btnSkip = btnSkipTr.GetComponent<Button>();
                if (_btnSkip == null) _btnSkip = btnSkipTr.gameObject.AddComponent<Button>();
                _btnSkip.onClick.AddListener(OnClose);
                btnSkipTr.gameObject.SetActive(false); // hidden by default
            }

            // imgBG = "Panel/imgBG"
            var imgBGTr = panel.Find("imgBG");
            if (imgBGTr != null) _imgBG = imgBGTr.gameObject;

            // btnOptionTemplate = "Panel/imgBG/panelButton/options/options/btnOptionTemplate"
            var templateTr = panel.Find("imgBG/panelButton/options/options/btnOptionTemplate");
            if (templateTr != null)
            {
                _btnOptionTemplate = templateTr.gameObject;
                _optionsContent = templateTr.parent;  // "options" content container
                _btnOptionTemplate.SetActive(false);   // hide template
            }

            // Also add click listener to imgBG for NextStep
            // Source: lua:44-46 — imgBG click → NextStep
            if (_imgBG != null)
            {
                var bgBtn = _imgBG.GetComponent<Button>();
                if (bgBtn == null) bgBtn = _imgBG.AddComponent<Button>();
                bgBtn.onClick.AddListener(OnNextStep);
            }

            // Start hidden
            _dialogRoot.SetActive(false);

            Debug.Log("[NpcDialogUI] Initialized");
        }

        // =================================================================
        //  ShowDialog — Open the dialog window with content
        //
        //  Source: Script_Ui_Window_UINpcDialog.lua:60-66 (OnOpen)
        //          Script_Ui_Window_UINpcDialog.lua:68-125 (UpdateDialog)
        //
        //  Called by Operation.OnDialogerClicked when player reaches NPC,
        //  or by NpcNetworkHandler when server sends CMD_KT_G2C_NPCDIALOG.
        // =================================================================
        public void ShowDialog(NpcDialogData data)
        {
            if (_dialogRoot == null) Init();
            if (_dialogRoot == null) return;

            _currentDialog = data;
            _dialogRoot.SetActive(true);

            // --- Set NPC name ---
            // Source: lua:96 — self.pPanel:Label_SetText(tbControls.txtNpcName, szNpcName .. "：")
            if (_txtNpcName != null)
                _txtNpcName.text = (data.szNpcName ?? "") + "\uff1a";  // fullwidth colon ：

            // --- Set dialog text ---
            // Source: lua:84 — szMsg = "　　" .. szDlgToClientText (indented with em spaces)
            if (_txtMsg != null)
            {
                string msgText = data.Text ?? "";
                // Strip <auto_next> prefix if present
                // Source: lua:85-89
                if (msgText.StartsWith("<auto_next>"))
                    msgText = msgText.Substring("<auto_next>".Length);
                _txtMsg.text = "\u3000\u3000" + msgText;  // ideographic space indent
            }

            // --- Populate option buttons ---
            // Source: lua:99-112 — tbScrollView:Reset then SetElement for each option
            ClearOptions();

            // If no options, add default "End" option
            // Source: lua:100-106
            if (data.OptList == null || data.OptList.Length == 0)
            {
                data.OptList = new NpcDialogOption[]
                {
                    new NpcDialogOption { Text = "K\u1ebft th\u00fac", Callback = 0, Type = "Script" }
                    // "Kết thúc" — Vietnamese for "End"
                };
            }

            for (int i = 0; i < data.OptList.Length; i++)
            {
                SpawnOptionButton(i, data.OptList[i]);
            }

            Debug.Log($"[NpcDialogUI] ShowDialog npc='{data.szNpcName}' text='{data.Text?.Substring(0, Mathf.Min(50, data.Text?.Length ?? 0))}...' opts={data.OptList.Length}");
        }

        // =================================================================
        //  SpawnOptionButton — Create one option button from the template
        //
        //  Source: lua:107-112 — tbScrollView:SetElement(i, function(tbElement)
        //            pPanel:Label_SetText("Text", i18n.Parse(opt.Text))
        //          end)
        // =================================================================
        void SpawnOptionButton(int index, NpcDialogOption opt)
        {
            if (_btnOptionTemplate == null || _optionsContent == null) return;

            var optGo = Instantiate(_btnOptionTemplate, _optionsContent);
            optGo.name = $"Option_{index}";
            optGo.SetActive(true);

            // Set the option text
            var text = optGo.GetComponentInChildren<Text>();
            if (text != null)
                text.text = opt.Text ?? "";

            // Add click handler
            var btn = optGo.GetComponent<Button>();
            if (btn == null) btn = optGo.AddComponent<Button>();
            int capturedIndex = index;
            btn.onClick.AddListener(() => OnSelectOption(capturedIndex));

            _spawnedOptions.Add(optGo);
        }

        void ClearOptions()
        {
            foreach (var go in _spawnedOptions)
            {
                if (go != null) Destroy(go);
            }
            _spawnedOptions.Clear();
        }

        // =================================================================
        //  OnSelectOption — Handle option button click
        //
        //  Source: Script_Ui_Window_UINpcDialog.lua:247-258
        //    function tbWnd:OnSelectOption(nIndex)
        //      local callBack = self.tbDlgToClient.OptList[nIndex].Callback
        //      if not callBack or 0 == callBack then
        //        self:Close()
        //      end
        //      self:DelayClose()
        //      if self.bIsClient then
        //        Dialog:OnDialogSelect(nIndex)
        //      else
        //        RemoteServer.OnDialogSelect(nIndex)
        //      end
        //    end
        // =================================================================
        void OnSelectOption(int index)
        {
            if (_currentDialog == null) return;
            if (index < 0 || index >= _currentDialog.OptList.Length) return;

            var opt = _currentDialog.OptList[index];
            Debug.Log($"[NpcDialogUI] Option selected: [{index}] '{opt.Text}' callback={opt.Callback}");

            // If no callback (callback == 0), just close
            // Source: lua:249-251
            if (opt.Callback == 0)
            {
                CloseDialog();
                return;
            }

            // With callback: delay close then send to server or local handler
            // Source: lua:252-257
            if (_currentDialog.bIsClient)
            {
                // Client-side dialog callback
                // Source: lua:254 — Dialog:OnDialogSelect(nIndex)
                Debug.Log($"[NpcDialogUI] Client dialog callback: index={index}");
            }
            else
            {
                // Server dialog: send selection via network
                // Source: lua:256 — RemoteServer.OnDialogSelect(nIndex)
                // Phase 11: stub — no server connection yet
                Debug.Log($"[NpcDialogUI] Would send dialog select to server: index={index}");
            }

            CloseDialog();
        }

        // =================================================================
        //  OnNextStep — Click on dialog background to advance
        //
        //  Source: lua:235-245
        //    function tbWnd:NextStep()
        //      if self.nCloseTimer or not self.bAutoNextDlg then return end
        //      if 1 ~= nOptNum then return end
        //      self:OnSelectOption(1)
        //    end
        // =================================================================
        void OnNextStep()
        {
            if (_currentDialog == null) return;
            // Auto-advance only works when there's exactly 1 option
            if (_currentDialog.OptList != null && _currentDialog.OptList.Length == 1)
            {
                OnSelectOption(0);
            }
        }

        // =================================================================
        //  OnClose — Close button handler
        //
        //  Source: lua:32-34 — btnClose = function(self) self:Close() end
        // =================================================================
        void OnClose()
        {
            CloseDialog();
        }

        // =================================================================
        //  CloseDialog — Hide the dialog window
        //
        //  Source: lua:170-173
        //    function tbWnd:OnClose()
        //      self:CloseTimer()
        //      self:SetBottomControlsActive(true)
        //    end
        // =================================================================
        public void CloseDialog()
        {
            if (_dialogRoot != null)
                _dialogRoot.SetActive(false);

            ClearOptions();
            _currentDialog = null;

            Debug.Log("[NpcDialogUI] Dialog closed");
        }

        /// <summary>Whether the dialog is currently showing.</summary>
        public bool IsOpen => _dialogRoot != null && _dialogRoot.activeSelf;

        // =================================================================
        //  ShowMockDialog — Create a test dialog for an NPC
        //
        //  DEVIATION — not from original source
        //  Reason: server-side dialog content (Dialog.lua:ShowNpcDialog calls
        //          CallClientScript). Without a server, we generate mock data
        //          to test the UI flow end-to-end.
        //  Original closest match: Dialog.lua:CommonShow
        // =================================================================
        public static NpcDialogData CreateMockDialog(Npc npc)
        {
            if (npc == null) return null;

            string npcName = npc.m_szName ?? $"NPC {npc.m_nNpcID}";

            return new NpcDialogData
            {
                Text = $"Chao mung ban den voi {npcName}! " +
                       "Ta co the giup gi cho nguoi?",
                szNpcName = npcName,
                nNpcID = npc.m_nNpcID,
                nNpcTemplate = 0,
                nSoundId = 0,
                bIsClient = true,
                OptList = new NpcDialogOption[]
                {
                    new NpcDialogOption
                    {
                        Text = "Nhiem vu",      // "Quest"
                        Callback = 1,
                        Type = "Script"
                    },
                    new NpcDialogOption
                    {
                        Text = "Cua hang",       // "Shop"
                        Callback = 1,
                        Type = "Script"
                    },
                    new NpcDialogOption
                    {
                        Text = "Tam biet",       // "Goodbye"
                        Callback = 0,
                        Type = "Script"
                    },
                }
            };
        }
    }
}
