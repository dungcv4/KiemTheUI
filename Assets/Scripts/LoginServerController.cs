// Wires UILoginServer prefab elements — the "lobby" screen after login.
// Shows selected server + "Vào giang hồ" button.
// Mirrors original Lua: UILoginServer.lua behavior.
using UnityEngine;
using UnityEngine.UI;
using KTO.Network;

public class LoginServerController : MonoBehaviour
{
    [Header("Auto-resolved from prefab hierarchy")]
    public Text   txtServerName;
    public Text   txtServerIndex;
    public Text   txtServerFlag;
    public Image  imgServerFlagGreen;
    public Image  imgServerFlagRed;
    public Image  imgServerFlagGray;
    public Button btnChange;
    public Button btnLoginServer;  // "Vào giang hồ"
    public Text   txtAppVersion;
    public Toggle togAgreement;    // Terms of service checkbox

    // Callbacks set by LoginSceneController
    public System.Action OnChangeServerClicked;
    public System.Action OnEnterGameClicked;

    void Start()
    {
        // ── Auto-wire from hierarchy ──
        if (txtServerName == null)   txtServerName   = FindInChild<Text>("imgBG/PanelServer/ServerName");
        if (txtServerIndex == null)  txtServerIndex  = FindInChild<Text>("imgBG/PanelServer/ServerIndex");
        if (txtServerFlag == null)   txtServerFlag   = FindInChild<Text>("imgBG/PanelServer/ServerFlag");
        if (imgServerFlagGreen == null) imgServerFlagGreen = FindInChild<Image>("imgBG/PanelServer/ServerFlagGreen");
        if (imgServerFlagRed == null)   imgServerFlagRed   = FindInChild<Image>("imgBG/PanelServer/ServerFlagRed");
        if (imgServerFlagGray == null)  imgServerFlagGray  = FindInChild<Image>("imgBG/PanelServer/ServerFlagGray");
        if (btnChange == null)       btnChange       = FindInChild<Button>("imgBG/PanelServer/btnChange");
        if (btnLoginServer == null)  btnLoginServer  = FindInChild<Button>("imgBG/btnLoginServer");
        if (txtAppVersion == null)   txtAppVersion   = FindInChild<Text>("imgBG/txtAppVersion");

        // Toggle: imgBG/Deal/ToggleCheck
        if (togAgreement == null) togAgreement = FindInChild<Toggle>("imgBG/Deal/ToggleCheck");

        // ── Translate Chinese → Vietnamese ──
        TranslateUI();

        // ── Version text ──
        if (txtAppVersion != null)
            txtAppVersion.text = $"v{Application.version}";

        // ── Wire buttons ──
        if (btnChange != null)
            btnChange.onClick.AddListener(() => OnChangeServerClicked?.Invoke());

        if (btnLoginServer != null)
            btnLoginServer.onClick.AddListener(OnBtnEnterGame);

        // ── Hide unused buttons ──
        HideChild("imgBG/BtnList/btnAgreement");
        HideChild("imgBG/BtnList/btnQRcode");
        HideChild("imgBG/BtnList/btnEwm");
        HideChild("imgBG/BtnList/btnAccount");
        HideChild("imgBG/BtnList/btnAnnounce");
        HideChild("imgBG/BtnList/btnSetting");
        HideChild("imgBG/imgCADPA");

        // ── Update server display ──
        UpdateServerDisplay();

        Debug.Log("[LoginServer] Panel ready");
    }

    void OnBtnEnterGame()
    {
        // Check agreement
        if (togAgreement != null && !togAgreement.isOn)
        {
            Debug.LogWarning("[LoginServer] Must agree to terms first");
            return;
        }

        var lm = LoginManager.Instance;
        if (lm == null || lm.SelectedServer == null)
        {
            Debug.LogWarning("[LoginServer] No server selected");
            return;
        }

        Debug.Log($"[LoginServer] Entering game on {lm.SelectedServer.ServerName}");
        OnEnterGameClicked?.Invoke();
    }

    /// <summary>
    /// Update the server info display from LoginManager state.
    /// </summary>
    public void UpdateServerDisplay()
    {
        var lm = LoginManager.Instance;
        if (lm == null) return;

        ServerInfo server = lm.SelectedServer ?? lm.LastServer;
        if (server == null && lm.Servers.Count > 0)
        {
            // Auto-select first online server
            server = lm.Servers[0];
            foreach (var s in lm.Servers)
            {
                if (s.Status == LoginProtocol.STATUS_RECOMMEND ||
                    s.Status == LoginProtocol.STATUS_NORMAL)
                {
                    server = s;
                    break;
                }
            }
            lm.SelectedServer = server;
        }

        if (server == null) return;

        // Server name
        if (txtServerName != null)
            txtServerName.text = server.ServerName;

        // Server index (e.g. "S381")
        if (txtServerIndex != null)
            txtServerIndex.text = $"S{server.ServerID}";

        // Server status flag
        UpdateServerFlags(server.Status);
    }

    void UpdateServerFlags(int status)
    {
        // Hide all flags first
        if (imgServerFlagGreen != null) imgServerFlagGreen.gameObject.SetActive(false);
        if (imgServerFlagRed != null)   imgServerFlagRed.gameObject.SetActive(false);
        if (imgServerFlagGray != null)  imgServerFlagGray.gameObject.SetActive(false);

        // Show appropriate flag
        switch (status)
        {
            case LoginProtocol.STATUS_NORMAL:
            case LoginProtocol.STATUS_RECOMMEND:
                if (imgServerFlagGreen != null) imgServerFlagGreen.gameObject.SetActive(true);
                if (txtServerFlag != null) txtServerFlag.text = status == LoginProtocol.STATUS_RECOMMEND ? "Hot" : "Tốt";
                break;
            case LoginProtocol.STATUS_NEW:
                if (imgServerFlagGreen != null) imgServerFlagGreen.gameObject.SetActive(true);
                if (txtServerFlag != null) txtServerFlag.text = "Mới";
                break;
            case LoginProtocol.STATUS_FULL:
                if (imgServerFlagRed != null) imgServerFlagRed.gameObject.SetActive(true);
                if (txtServerFlag != null) txtServerFlag.text = "Đầy";
                break;
            case LoginProtocol.STATUS_OFFLINE:
            case LoginProtocol.STATUS_MAINTAIN:
                if (imgServerFlagGray != null) imgServerFlagGray.gameObject.SetActive(true);
                if (txtServerFlag != null) txtServerFlag.text = "Bảo trì";
                break;
            default:
                if (imgServerFlagGreen != null) imgServerFlagGreen.gameObject.SetActive(true);
                if (txtServerFlag != null) txtServerFlag.text = "";
                break;
        }
    }

    // ── Translation ──
    void TranslateUI()
    {
        SetText("imgBG/btnLoginServer/Text", "Vào giang hồ");
        SetText("imgBG/PanelServer/btnChange/Text", "Đổi");
        SetText("imgBG/Deal/Label1", "Tôi đã đọc chi tiết và đồng ý");
        SetText("imgBG/Deal/Label2", "《Điều khoản sử dụng》");
        SetText("imgBG/Deal/Label3", "và");
        SetText("imgBG/Deal/Label4", "《Chính sách bảo mật》");
        SetText("imgBG/txtGameAdvice",
            "Sắp xếp thời gian vui chơi hợp lý, giữ gìn sức khỏe!");
        SetText("imgBG/txtGameAdvice2", "");
    }

    // ── Helpers ──
    void SetText(string path, string text)
    {
        var child = transform.Find(path);
        if (child == null) return;
        var txt = child.GetComponent<Text>();
        if (txt != null) txt.text = text;
    }

    void HideChild(string path)
    {
        var child = transform.Find(path);
        if (child != null) child.gameObject.SetActive(false);
    }

    T FindInChild<T>(string path) where T : Component
    {
        var child = transform.Find(path);
        if (child == null)
        {
            Debug.LogWarning($"[LoginServer] Child not found: {path}");
            return null;
        }
        return child.GetComponent<T>();
    }
}
