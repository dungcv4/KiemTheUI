// Wires UILoginChannelInner prefab elements to SDK login via LoginManager.
// Mirrors original Lua: UILoginChannelInner.lua behavior.
using UnityEngine;
using UnityEngine.UI;
using KTO.Network;

public class LoginController : MonoBehaviour
{
    [Header("Auto-resolved from prefab hierarchy")]
    public InputField inputAccount;
    public InputField inputPwd;
    public Button     btnEnterGame;
    public Button     btnSelectZone;
    public Button     btnRegister;
    public Text       txtCurZoneValue;
    public Text       txtAppVersion;
    public Toggle     togRememberAccount;
    public GameObject selectPlatformPanel;

    // Set by LoginSceneController
    public System.Action OnSelectZoneClicked;
    public System.Action OnRegisterClicked;

    void Start()
    {
        // Auto-wire if not assigned in inspector
        if (inputAccount == null) inputAccount = FindInChild<InputField>("imgBG/imgAccount/inputAccount");
        if (inputPwd == null)     inputPwd     = FindInChild<InputField>("imgBG/imgAccount/inputPwd");
        if (btnEnterGame == null) btnEnterGame = FindInChild<Button>("imgBG/btnEnterGame");
        if (btnSelectZone == null) btnSelectZone = FindInChild<Button>("imgBG/btnSelectZone");
        if (btnRegister == null)  btnRegister  = FindInChild<Button>("imgBG/imgAccount/btnRegister");
        if (txtCurZoneValue == null) txtCurZoneValue = FindInChild<Text>("imgBG/txtCurZoneValue");
        if (txtAppVersion == null) txtAppVersion = FindInChild<Text>("imgBG/txtAppVersion");
        if (togRememberAccount == null) togRememberAccount = FindInChild<Toggle>("imgBG/imgAccount/togRememberAccount");
        if (selectPlatformPanel == null)
        {
            var sp = transform.Find("imgBG/SelectPlatform");
            if (sp != null) selectPlatformPanel = sp.gameObject;
        }

        // Fix InputField wiring — importer adds UIDealEmojiInput but doesn't set
        // textComponent/placeholder references needed for InputField to work
        SetupInputField(inputAccount, "imgBG/imgAccount/inputAccount");
        SetupInputField(inputPwd, "imgBG/imgAccount/inputPwd");
        if (inputPwd != null)
            inputPwd.contentType = InputField.ContentType.Password;

        // Hide editor-only platform selector
        if (selectPlatformPanel != null)
            selectPlatformPanel.SetActive(false);

        // Hide server selection — it's a separate step after login
        HideChild("imgBG/txtCurZoneTip");
        HideChild("imgBG/txtCurZoneValue");
        HideChild("imgBG/btnSelectZone");

        // ── Translate Chinese → Vietnamese ──
        TranslateUI();

        // Restore saved account
        string saved = PlayerPrefs.GetString("KTO_Account", "");
        if (!string.IsNullOrEmpty(saved) && inputAccount != null)
            inputAccount.text = saved;

        // Remember account toggle — fix graphic reference (importer doesn't wire it)
        if (togRememberAccount != null)
        {
            // Wire Checkmark as toggle graphic so it shows/hides on click
            if (togRememberAccount.graphic == null)
            {
                var checkmark = togRememberAccount.transform.Find("Background/Checkmark");
                if (checkmark != null)
                    togRememberAccount.graphic = checkmark.GetComponent<Graphic>();
            }

            bool remember = PlayerPrefs.GetInt("KTO_RememberAccount", 1) == 1;
            togRememberAccount.isOn = remember;
            togRememberAccount.onValueChanged.AddListener(on =>
                PlayerPrefs.SetInt("KTO_RememberAccount", on ? 1 : 0));
        }

        // Version text
        if (txtAppVersion != null)
            txtAppVersion.text = $"v{Application.version}";

        // Wire buttons — "Đăng Nhập" triggers SDK login
        if (btnEnterGame != null)
            btnEnterGame.onClick.AddListener(OnEnterGame);
        if (btnRegister != null)
            btnRegister.onClick.AddListener(() => OnRegisterClicked?.Invoke());

        Debug.Log("[LoginCtrl] Login panel ready");
    }

    void OnEnterGame()
    {
        string account = inputAccount != null ? inputAccount.text.Trim() : "";
        string password = inputPwd != null ? inputPwd.text.Trim() : "";

        if (string.IsNullOrEmpty(account))
        {
            Debug.LogWarning("[LoginCtrl] Account is empty");
            return;
        }
        if (string.IsNullOrEmpty(password))
        {
            Debug.LogWarning("[LoginCtrl] Password is empty");
            return;
        }

        // Save account if toggle is on
        if (togRememberAccount != null && togRememberAccount.isOn)
            PlayerPrefs.SetString("KTO_Account", account);

        Debug.Log($"[LoginCtrl] Logging in as: {account}");
        LoginManager.Instance?.DoLogin(account, password);
    }

    public void UpdateServerName()
    {
        if (txtCurZoneValue == null) return;
        var lm = LoginManager.Instance;
        if (lm != null && lm.SelectedServer != null)
            txtCurZoneValue.text = lm.SelectedServer.ServerName;
        else
            txtCurZoneValue.text = "";
    }

    /// <summary>
    /// Wire InputField's textComponent and placeholder from child objects.
    /// The importer creates the children (Text, Placeholder) but doesn't link them.
    /// </summary>
    void SetupInputField(InputField field, string path)
    {
        if (field == null) return;
        var root = transform.Find(path);
        if (root == null) return;

        // Text child = typed text display
        if (field.textComponent == null)
        {
            var textChild = root.Find("Text");
            if (textChild != null)
                field.textComponent = textChild.GetComponent<Text>();
        }

        // Placeholder child
        if (field.placeholder == null)
        {
            var ph = root.Find("Placeholder");
            if (ph != null)
                field.placeholder = ph.GetComponent<Text>();
        }

        // Ensure the text area matches the input field rect
        if (field.textComponent != null)
        {
            field.textComponent.supportRichText = false;
            field.textComponent.color = Color.white;
        }
    }

    /// <summary>
    /// Replace all Chinese text with Vietnamese equivalents.
    /// </summary>
    void TranslateUI()
    {
        SetText("imgBG/imgAccount/txtID", "Tài khoản");
        SetText("imgBG/imgAccount/txtPwd", "Mật khẩu");
        SetText("imgBG/imgAccount/inputAccount/Placeholder", "Nhập tài khoản");
        SetText("imgBG/imgAccount/inputPwd/Placeholder", "Nhập mật khẩu");
        SetText("imgBG/imgAccount/togRememberAccount/Label", "Nhớ tài khoản");
        SetText("imgBG/btnEnterGame/Text", "Đăng Nhập");
        SetText("imgBG/txtCurZoneTip", "Server hiện tại");
        SetText("imgBG/btnSelectZone/Text", "Đổi Server");
        SetText("imgBG/imgAccount/btnRegister/Text", "Đăng ký");
        SetText("imgBG/imgAccount/btnFindPwd/Text", "Quên MK");
        SetText("imgBG/txtGameAdvice",
            "Lưu ý: Hãy bảo vệ tài khoản, không chia sẻ mật khẩu cho người khác.");
    }

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
            Debug.LogWarning($"[LoginCtrl] Child not found: {path}");
            return null;
        }
        return child.GetComponent<T>();
    }
}
