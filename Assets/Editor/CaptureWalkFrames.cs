using UnityEditor;
using UnityEngine;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using KTO.Game;

public static class CaptureWalkFrames
{
    public static void Execute()
    {
        var go = GameObject.Find("Player_ma_000a_free");
        if (go == null) { Debug.LogError("Player not found"); return; }
        var pa = go.GetComponent<PlayerAssembler>();
        var ic = go.GetComponent<PlayerInputController>();
        if (ic != null) ic.enabled = false;
        pa.enabled = false;

        PlayerAssembler.EnsureSpriteCache();

        // Grab JSONs + cache via reflection
        var bodyFI   = typeof(PlayerAssembler).GetField("_body",   BindingFlags.Instance | BindingFlags.NonPublic);
        var headFI   = typeof(PlayerAssembler).GetField("_head",   BindingFlags.Instance | BindingFlags.NonPublic);
        var shadowFI = typeof(PlayerAssembler).GetField("_shadow", BindingFlags.Instance | BindingFlags.NonPublic);
        var cacheFI  = typeof(PlayerAssembler).GetField("_spriteCache", BindingFlags.Static | BindingFlags.NonPublic);

        var body   = (PlayerNpcAssetJson)bodyFI.GetValue(pa);
        var head   = (PlayerNpcAssetJson)headFI.GetValue(pa);
        var shadow = (PlayerNpcAssetJson)shadowFI.GetValue(pa);
        var cache  = (Dictionary<string, Sprite>)cacheFI.GetValue(null);

        Debug.Log($"[CaptureWalk] cache size={cache.Count} body?{body!=null} head?{head!=null} shadow?{shadow!=null}");

        // Find child renderers
        SpriteRenderer srBody = null, srHead = null, srShadow = null;
        foreach (Transform c in go.transform)
        {
            if (c.name == "body")   srBody   = c.GetComponent<SpriteRenderer>();
            if (c.name == "head")   srHead   = c.GetComponent<SpriteRenderer>();
            if (c.name == "shadow") srShadow = c.GetComponent<SpriteRenderer>();
        }
        Debug.Log($"[CaptureWalk] renderers body?{srBody!=null} head?{srHead!=null} shadow?{srShadow!=null}");

        // Close-up cam
        var camGo = new GameObject("__WalkCaptureCam");
        camGo.transform.position = go.transform.position + new Vector3(0f, 0f, -10f);
        var cam = camGo.AddComponent<Camera>();
        cam.orthographic = true;
        cam.orthographicSize = 2f;
        cam.clearFlags = CameraClearFlags.SolidColor;
        cam.backgroundColor = new Color(0.2f, 0.2f, 0.25f, 1f);
        cam.cullingMask = ~0;
        cam.nearClipPlane = 0.01f;
        cam.farClipPlane = 100f;

        int w = 256, h = 256;
        int[] dirs = { 0, 32, 64, 96, 128, 160, 192, 224 };
        string[] labels = { "00_bottom", "01_lb", "02_left", "03_lt", "04_top", "05_rt", "06_right", "07_rb" };

        var act = NpcAction.FightRun;
        int fcBody   = body.frame_count[(int)act];
        int fcHead   = head.frame_count[(int)act];
        int fcShadow = shadow.frame_count[(int)act];

        for (int i = 0; i < 8; i++)
        {
            int d = ((dirs[i] % 256) + 256) % 256;
            int bin = ((d + 16) / 32) % 8;
            int actionDir;
            bool flipX;
            // Source: NpcAsset$$GetFlipX @ 0x019177f3 — `return param_2 - 1U < 3`
            if (bin <= 4) { actionDir = bin; flipX = (bin >= 1 && bin <= 3); }
            else          { actionDir = 8 - bin; flipX = false; }

            // frame=0 for pose capture
            int idxBody   = actionDir * fcBody   + 0;
            int idxHead   = actionDir * fcHead   + 0;
            int idxShadow = actionDir * fcShadow + 0;

            var bName = body.FightRun[idxBody];
            var hName = head.FightRun[idxHead];
            var sName = shadow.FightRun[idxShadow];

            cache.TryGetValue(bName, out Sprite spB);
            cache.TryGetValue(hName, out Sprite spH);
            cache.TryGetValue(sName, out Sprite spS);

            srBody.sprite   = spB; srBody.flipX   = flipX;
            srHead.sprite   = spH; srHead.flipX   = flipX;
            srShadow.sprite = spS; srShadow.flipX = flipX;

            Debug.Log($"[CaptureWalk] {labels[i]} dir={dirs[i]} aDir={actionDir} flipX={flipX} body={bName} spB={(spB!=null?spB.name:"NULL")} srBody={(srBody.sprite!=null?srBody.sprite.name:"NULL")}");

            GL.Flush();
            var rt = new RenderTexture(w, h, 24);
            cam.targetTexture = rt;
            RenderTexture.active = rt;
            cam.Render();
            var tex = new Texture2D(w, h, TextureFormat.RGB24, false);
            tex.ReadPixels(new Rect(0, 0, w, h), 0, 0);
            tex.Apply();
            cam.targetTexture = null;
            RenderTexture.active = null;
            File.WriteAllBytes($"/tmp/player_walk_{labels[i]}.png", tex.EncodeToPNG());
            Object.DestroyImmediate(rt);
            Object.DestroyImmediate(tex);
        }

        Object.DestroyImmediate(camGo);
        pa.enabled = true;
        pa.SetAction(NpcAction.FightStand);
        if (ic != null) ic.enabled = true;
    }
}
