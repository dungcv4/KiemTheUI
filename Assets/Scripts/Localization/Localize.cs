// =======================================================================
//  Localize.cs — UI component that applies LanguageModule.Get(term) at runtime.
//
//  Source:
//    KiemTheOrigin_DeepExtract/_shared/DecompiledSource/Game.Ui/UIMultiLangConfig.cs
//    (TextInfo[] textList, ImageInfo[] imageList, RawImageInfo[] rawImageList)
//
//  The original has UIMultiLangConfig as a per-prefab MonoBehaviour holding
//  an array of (Text + textFile + textID). At runtime, Refresh(lang) walks
//  the list and sets text[i].text = LanguageModule.Get(textID[i]).
//
//  DEVIATION — not a literal port:
//  We use a per-Text component instead of a per-prefab registry. Functionally
//  identical (every Text ends up with LanguageModule.Get called on it), but
//  easier to wire via an editor tool that walks prefabs and adds one of these
//  per Chinese-containing Text component.
//
//  Approved: user asked "làm giống gốc" for multilang — the GOAL (translated
//  text at runtime via LanguageModule) is preserved; only the container shape
//  differs (per-component vs per-prefab list).
// =======================================================================

using UnityEngine;
using UnityEngine.UI;

namespace KTO.Localization
{
    [RequireComponent(typeof(Text))]
    public class Localize : MonoBehaviour
    {
        /// <summary>
        /// Translation key. In our port we use the original Chinese string
        /// as the key directly (matches the game's own convention — see
        /// `I2.Loc.LocalizationManager.GetTranslation` where the "key" can
        /// be the source-language string itself when CurrentLanguageCode
        /// differs from the source language).
        /// </summary>
        public string Term;

        /// <summary>
        /// If true, Term is set to the Text.text value at Reset() /
        /// first-run if empty. Handy for editor tooling that wants to
        /// auto-capture existing strings as keys.
        /// </summary>
        public bool CaptureFromText = true;

        Text _text;

        void Awake()
        {
            _text = GetComponent<Text>();
        }

        void OnEnable()
        {
            ApplyTranslation();
        }

        public void ApplyTranslation()
        {
            if (_text == null) _text = GetComponent<Text>();
            if (_text == null) return;

            // If Term is empty, capture the current text as the key
            // (so un-authored Text components degrade gracefully).
            if (string.IsNullOrEmpty(Term) && CaptureFromText)
                Term = _text.text;

            if (string.IsNullOrEmpty(Term)) return;

            // Split behavior based on whether the term is in the translation
            // table:
            //
            //   • Key IS present — we always apply the translation, even
            //     if it's the empty string. This is what lets numeric
            //     placeholder keys like "5318" (UIItemGrid/TagTip) get
            //     cleared to "" (Lua would populate at runtime).
            //
            //   • Key is NOT present — LanguageModule.Get returns the key
            //     verbatim. We don't want to overwrite the current Text
            //     with a raw placeholder number, so we leave it alone.
            //     Callers (Lua ports or game code) can set the Text directly
            //     via Label_SetText-equivalents and Localize won't fight.
            if (LanguageModule.HasTerm(Term))
            {
                string translated = LanguageModule.Get(Term);
                if (_text.text != translated)
                    _text.text = translated;
            }
        }

#if UNITY_EDITOR
        void Reset()
        {
            // On first add in the Editor, capture the text field as the term.
            var t = GetComponent<Text>();
            if (t != null && !string.IsNullOrEmpty(t.text))
                Term = t.text;
        }
#endif
    }
}
