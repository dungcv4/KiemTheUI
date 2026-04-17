#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

namespace KTO.Editor.MapImport
{
    public static class _ReimportShaders
    {
        public static void Execute()
        {
            string[] paths = {
                "Assets/Shader/Game_SpriteDefault_0.shader",
                "Assets/Shader/GAME_SpriteBackground_0.shader",
            };
            foreach (var p in paths)
            {
                AssetDatabase.ImportAsset(p, ImportAssetOptions.ForceUpdate | ImportAssetOptions.ForceSynchronousImport);
                var sh = AssetDatabase.LoadAssetAtPath<Shader>(p);
                Debug.Log($"[_ReimportShaders] {p} -> name='{(sh != null ? sh.name : "<null>")}'  isSupported={(sh != null && sh.isSupported)}");
                // Print any compile errors
                if (sh != null)
                {
                    var msgs = UnityEditor.ShaderUtil.GetShaderMessages(sh);
                    if (msgs == null || msgs.Length == 0)
                        Debug.Log($"[_ReimportShaders]   no shader messages");
                    else
                        foreach (var m in msgs)
                            Debug.Log($"[_ReimportShaders]   [{m.severity}] {m.message}  ({m.file}:{m.line})  pass={m.platform}");
                }
            }
        }
    }
}
#endif
