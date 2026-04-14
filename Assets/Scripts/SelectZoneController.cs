// Wires UISelectZone prefab elements to server list from LoginManager.
// Mirrors original Lua: UISelectZone.lua — populates ZoneList with server buttons.
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using KTO.Network;

public class SelectZoneController : MonoBehaviour
{
    [Header("Auto-resolved from prefab hierarchy")]
    public Transform  zoneListContent;
    public GameObject btnTemplate;

    // Called when a server is selected
    public System.Action<ServerInfo> OnServerSelected;

    private readonly List<GameObject> _spawnedButtons = new List<GameObject>();

    void Start()
    {
        // Auto-wire from hierarchy
        // UISelectZone > imgBG > ZoneList > ZoneList (inner, with ContentSizeFitter) > btnTemplate
        if (zoneListContent == null)
        {
            // The inner ZoneList is the scroll content with ContentSizeFitter
            var outer = transform.Find("imgBG/ZoneList");
            if (outer != null)
            {
                // Inner ZoneList is the first child of outer ZoneList
                var inner = outer.Find("ZoneList");
                zoneListContent = inner ?? outer;
            }
        }

        if (btnTemplate == null && zoneListContent != null)
        {
            var tmpl = zoneListContent.Find("btnTemplate");
            if (tmpl != null)
            {
                btnTemplate = tmpl.gameObject;
                btnTemplate.SetActive(false); // hide template
            }
        }

        // Translate title
        var txtTitle = transform.Find("imgBG/txtTitle");
        if (txtTitle != null)
        {
            var t = txtTitle.GetComponent<UnityEngine.UI.Text>();
            if (t != null) t.text = "Chọn Server";
        }

        // Subscribe to server list updates
        if (LoginManager.Instance != null)
            LoginManager.Instance.OnServerListReceived += PopulateServers;
    }

    void OnDestroy()
    {
        if (LoginManager.Instance != null)
            LoginManager.Instance.OnServerListReceived -= PopulateServers;
    }

    void OnEnable()
    {
        // Refresh when panel opens
        var lm = LoginManager.Instance;
        if (lm != null && lm.Servers.Count > 0)
            PopulateServers(lm.Servers);
    }

    public void PopulateServers(List<ServerInfo> servers)
    {
        // Clear old buttons
        foreach (var go in _spawnedButtons)
            if (go != null) Destroy(go);
        _spawnedButtons.Clear();

        if (btnTemplate == null || zoneListContent == null)
        {
            Debug.LogWarning("[SelectZone] Missing template or content container");
            return;
        }

        foreach (var server in servers)
        {
            var btn = Instantiate(btnTemplate, zoneListContent);
            btn.SetActive(true);

            // Set server name text
            var txt = btn.GetComponentInChildren<Text>();
            if (txt != null)
            {
                string statusStr = server.Status switch
                {
                    LoginProtocol.STATUS_RECOMMEND => " <color=#00ff00>[HOT]</color>",
                    LoginProtocol.STATUS_NEW       => " <color=#ffff00>[NEW]</color>",
                    LoginProtocol.STATUS_FULL      => " <color=#ff0000>[FULL]</color>",
                    LoginProtocol.STATUS_OFFLINE   => " <color=#888888>[OFF]</color>",
                    _ => ""
                };
                txt.text = $"{server.ServerName}{statusStr}";
            }

            // Wire click
            var serverRef = server; // closure capture
            var button = btn.GetComponent<Button>();
            if (button != null)
            {
                button.onClick.AddListener(() =>
                {
                    Debug.Log($"[SelectZone] Selected: {serverRef.ServerName} ({serverRef.URL}:{serverRef.Port})");
                    OnServerSelected?.Invoke(serverRef);
                });
            }

            _spawnedButtons.Add(btn);
        }

        Debug.Log($"[SelectZone] Populated {servers.Count} servers");
    }
}
