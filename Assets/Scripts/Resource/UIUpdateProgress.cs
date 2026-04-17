// =======================================================================
//  UIUpdateProgress.cs — Download/Update progress UI (Phase R4.5)
//
//  Source: IL2CPP UIStartUp__SetLoadingProgress (0x01cd2bf1)
//           UIStartUp__OnLoadingProgress (0x01cd2d0f)
//           UIStartUp__OnLoadingFinished (0x01cd2d55)
//           DlcModule__ShowDownloadProgress (0x01cd6a35)
//
//  Original architecture:
//    - UIStartUp holds references to an Image (fillAmount bar) and Text
//    - SetLoadingProgress does DOFillAmount tween + sets "N%" text
//    - OnLoadingProgress calls SetLoadingProgress then sets info text
//      to ScriptLocalization.LoadingResource
//    - OnLoadingFinished sets progress to 100% and text to "ResLoadComplete"
//    - DlcModule.ShowDownloadProgress feeds downloaded/total bytes
//
//  This MonoBehaviour creates the UI programmatically and polls
//  DlcModule + KUpdaterMgr state every frame for progress.
// =======================================================================

using UnityEngine;
using UnityEngine.UI;

namespace KTO.Resource
{
    public class UIUpdateProgress : MonoBehaviour
    {
        // UI references (created in BuildUI)
        Canvas _canvas;
        Image _progressBarBg;
        Image _progressBarFill;
        Text _percentText;
        Text _infoText;
        Text _speedText;
        GameObject _rootPanel;

        // State
        bool _isShowing;
        float _targetFill;
        float _currentFill;

        public static UIUpdateProgress Instance { get; private set; }

        void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }
            Instance = this;
            DontDestroyOnLoad(gameObject);
            BuildUI();
            Hide();
        }

        // =================================================================
        //  BuildUI — Create the progress UI programmatically
        //
        //  Source: Original UIStartUp prefab has:
        //    - offset 0x20: Image (progress bar, fillMethod = Horizontal)
        //    - offset 0x28: Text (percentage display)
        //    - offset 0x30: Text (info/status message)
        //  We also add a speed display text (from DownloadSpeed.FormatSpeed)
        //
        //  Layout: CanvasScaler 1280x720 (matches original CanvasScaler config
        //  from UILoading_res_p_267.json: refResolution 1280x720, screenMatchMode=1)
        // =================================================================
        void BuildUI()
        {
            // Canvas
            var canvasGo = new GameObject("UpdateProgressCanvas");
            canvasGo.transform.SetParent(transform, false);
            _canvas = canvasGo.AddComponent<Canvas>();
            _canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            _canvas.sortingOrder = 9999; // on top of everything

            var scaler = canvasGo.AddComponent<CanvasScaler>();
            scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
            scaler.referenceResolution = new Vector2(1280, 720);
            scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;
            scaler.matchWidthOrHeight = 0.5f;

            canvasGo.AddComponent<GraphicRaycaster>();

            // Dark overlay background
            _rootPanel = new GameObject("Panel");
            _rootPanel.transform.SetParent(canvasGo.transform, false);
            var panelRect = _rootPanel.AddComponent<RectTransform>();
            panelRect.anchorMin = Vector2.zero;
            panelRect.anchorMax = Vector2.one;
            panelRect.sizeDelta = Vector2.zero;
            var panelImg = _rootPanel.AddComponent<Image>();
            panelImg.color = new Color(0f, 0f, 0f, 0.85f);

            // Progress bar background (centered, 600x20)
            var barBgGo = new GameObject("ProgressBarBg");
            barBgGo.transform.SetParent(_rootPanel.transform, false);
            var barBgRect = barBgGo.AddComponent<RectTransform>();
            barBgRect.anchorMin = new Vector2(0.5f, 0.5f);
            barBgRect.anchorMax = new Vector2(0.5f, 0.5f);
            barBgRect.pivot = new Vector2(0.5f, 0.5f);
            barBgRect.anchoredPosition = new Vector2(0f, -20f);
            barBgRect.sizeDelta = new Vector2(600f, 20f);
            _progressBarBg = barBgGo.AddComponent<Image>();
            _progressBarBg.color = new Color(0.2f, 0.2f, 0.2f, 1f);

            // Progress bar fill (same size, Filled horizontal)
            // Source: UIStartUp__SetLoadingProgress uses DOFillAmount
            //   → Image.type = Filled, fillMethod = Horizontal
            var barFillGo = new GameObject("ProgressBarFill");
            barFillGo.transform.SetParent(barBgGo.transform, false);
            var barFillRect = barFillGo.AddComponent<RectTransform>();
            barFillRect.anchorMin = Vector2.zero;
            barFillRect.anchorMax = Vector2.one;
            barFillRect.sizeDelta = Vector2.zero;
            _progressBarFill = barFillGo.AddComponent<Image>();
            _progressBarFill.color = new Color(0.2f, 0.8f, 0.3f, 1f);
            _progressBarFill.type = Image.Type.Filled;
            _progressBarFill.fillMethod = Image.FillMethod.Horizontal;
            _progressBarFill.fillOrigin = 0; // left to right
            _progressBarFill.fillAmount = 0f;

            // Percentage text (above bar)
            // Source: UIStartUp__SetLoadingProgress sets text = progress + "%"
            var percentGo = new GameObject("PercentText");
            percentGo.transform.SetParent(_rootPanel.transform, false);
            var percentRect = percentGo.AddComponent<RectTransform>();
            percentRect.anchorMin = new Vector2(0.5f, 0.5f);
            percentRect.anchorMax = new Vector2(0.5f, 0.5f);
            percentRect.pivot = new Vector2(0.5f, 0.5f);
            percentRect.anchoredPosition = new Vector2(0f, 10f);
            percentRect.sizeDelta = new Vector2(200f, 30f);
            _percentText = percentGo.AddComponent<Text>();
            _percentText.text = "0%";
            _percentText.font = Font.CreateDynamicFontFromOSFont("Arial", 20);
            _percentText.fontSize = 20;
            _percentText.color = Color.white;
            _percentText.alignment = TextAnchor.MiddleCenter;

            // Info text (below bar — file count, status)
            var infoGo = new GameObject("InfoText");
            infoGo.transform.SetParent(_rootPanel.transform, false);
            var infoRect = infoGo.AddComponent<RectTransform>();
            infoRect.anchorMin = new Vector2(0.5f, 0.5f);
            infoRect.anchorMax = new Vector2(0.5f, 0.5f);
            infoRect.pivot = new Vector2(0.5f, 0.5f);
            infoRect.anchoredPosition = new Vector2(0f, -50f);
            infoRect.sizeDelta = new Vector2(600f, 24f);
            _infoText = infoGo.AddComponent<Text>();
            _infoText.text = "";
            _infoText.font = Font.CreateDynamicFontFromOSFont("Arial", 16);
            _infoText.fontSize = 16;
            _infoText.color = new Color(0.8f, 0.8f, 0.8f, 1f);
            _infoText.alignment = TextAnchor.MiddleCenter;

            // Speed text (below info — download speed)
            // Source: DlcModule.speedCalculator.FormatSpeed()
            var speedGo = new GameObject("SpeedText");
            speedGo.transform.SetParent(_rootPanel.transform, false);
            var speedRect = speedGo.AddComponent<RectTransform>();
            speedRect.anchorMin = new Vector2(0.5f, 0.5f);
            speedRect.anchorMax = new Vector2(0.5f, 0.5f);
            speedRect.pivot = new Vector2(0.5f, 0.5f);
            speedRect.anchoredPosition = new Vector2(0f, -75f);
            speedRect.sizeDelta = new Vector2(400f, 24f);
            _speedText = speedGo.AddComponent<Text>();
            _speedText.text = "";
            _speedText.font = Font.CreateDynamicFontFromOSFont("Arial", 14);
            _speedText.fontSize = 14;
            _speedText.color = new Color(0.6f, 0.6f, 0.6f, 1f);
            _speedText.alignment = TextAnchor.MiddleCenter;
        }

        // =================================================================
        //  Show/Hide
        // =================================================================
        public void Show()
        {
            _isShowing = true;
            _rootPanel.SetActive(true);
            _currentFill = 0f;
            _targetFill = 0f;
            Debug.Log("[UIUpdateProgress] Shown");
        }

        public void Hide()
        {
            _isShowing = false;
            _rootPanel.SetActive(false);
            Debug.Log("[UIUpdateProgress] Hidden");
        }

        // =================================================================
        //  SetProgress — Set the target fill amount
        //
        //  Source: UIStartUp__SetLoadingProgress (0x01cd2bf1)
        //    DOFillAmount(progress / 100f, 0.1f, imageRef)
        //    textRef.text = progress.ToString() + "%"
        //
        //  We replicate the DOTween fill with Lerp in Update (simpler,
        //  avoids DOTween dependency just for this one UI)
        // =================================================================
        public void SetProgress(float progress01)
        {
            _targetFill = Mathf.Clamp01(progress01);
            int pct = Mathf.RoundToInt(_targetFill * 100f);
            _percentText.text = pct + "%";
        }

        // =================================================================
        //  SetInfoText — Status message below the bar
        // =================================================================
        public void SetInfoText(string text)
        {
            _infoText.text = text;
        }

        // =================================================================
        //  SetSpeedText — Download speed display
        // =================================================================
        public void SetSpeedText(string text)
        {
            _speedText.text = text;
        }

        // =================================================================
        //  Update — Smooth fill + poll DlcModule state
        // =================================================================
        void Update()
        {
            if (!_isShowing) return;

            // Smooth fill (match original DOTween 0.1s duration)
            // Source: DOFillAmount(target, 0x3dcccccd ≈ 0.1f)
            _currentFill = Mathf.Lerp(_currentFill, _targetFill, Time.deltaTime * 10f);
            _progressBarFill.fillAmount = _currentFill;

            // Poll DlcModule for download progress
            if (DlcModule.Instance != null && DlcModule.nTotalSize > 0)
            {
                ulong downloaded = DlcModule.DownloadedSize();
                ulong total = DlcModule.nTotalSize;
                float progress = (float)downloaded / total;
                SetProgress(progress);

                // Info text: downloaded/total MB
                float dlMB = downloaded / (1024f * 1024f);
                float totalMB = total / (1024f * 1024f);
                SetInfoText($"{dlMB:F1} MB / {totalMB:F1} MB");

                // Speed
                SetSpeedText(DlcModule.speedCalculator.FormatSpeed());
            }
        }

        // =================================================================
        //  OnComplete — Called when all downloads finish
        //
        //  Source: UIStartUp__OnLoadingFinished (0x01cd2d55)
        //    SetLoadingProgress(100)  ← 0x42c80000 = 100.0f
        //    textRef.text = ScriptLocalization.ResLoadComplete
        // =================================================================
        public void OnComplete()
        {
            SetProgress(1f);
            SetInfoText("Update complete");
            SetSpeedText("");

            // Auto-hide after a short delay
            Invoke(nameof(Hide), 1.5f);
        }

        void OnDestroy()
        {
            if (Instance == this)
                Instance = null;
        }
    }
}
