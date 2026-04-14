// HTTP client for KTO SDK server (Python, port 8887).
// Handles login, register, verify, server list via protobuf binary protocol.
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

namespace KTO.Network
{
    public class SDKClient
    {
        private string _baseUrl;

        public SDKClient(string host, int port)
        {
            _baseUrl = $"http://{host}:{port}";
        }

        public void SetBaseUrl(string host, int port)
        {
            _baseUrl = $"http://{host}:{port}";
        }

        // ── Login (form-encoded → protobuf response) ──────────────
        public async Task<SDKLoginResponse> Login(string userName, string password)
        {
            var form = new WWWForm();
            form.AddField("UserName", userName);
            form.AddField("Password", password);
            form.AddField("LoginType", "0");

            byte[] data = await PostForm("/loginsdk.aspx", form);
            if (data == null) return new SDKLoginResponse { ErrorCode = -999, ErrorMsg = "Network error" };
            return SDKLoginResponse.Parse(data);
        }

        // ── Register (form-encoded → protobuf response) ───────────
        public async Task<SDKRegisterResponse> Register(string userName, string password,
                                                         string email, string phone)
        {
            var form = new WWWForm();
            form.AddField("UserName", userName);
            form.AddField("Password", password);
            form.AddField("Email", email);
            form.AddField("PhoneNumber", phone);

            byte[] data = await PostForm("/registersdk.aspx", form);
            if (data == null) return new SDKRegisterResponse { ErrorCode = -999, ErrorMsg = "Network error" };
            return SDKRegisterResponse.Parse(data);
        }

        // ── Verify (binary protobuf → protobuf response) ──────────
        public async Task<SDKVerifyResponse> Verify(string accessToken)
        {
            var w = new PbWriter();
            w.WriteString(1, accessToken);
            byte[] reqBody = w.ToArray();

            byte[] data = await PostBinary("/verifyaccount.aspx", reqBody);
            if (data == null) return null;
            return SDKVerifyResponse.Parse(data);
        }

        // ── Server List (form or empty → protobuf response) ───────
        public async Task<SDKServerListResponse> GetServerList(string userID = "", string accessToken = "")
        {
            var form = new WWWForm();
            if (!string.IsNullOrEmpty(userID))
                form.AddField("strUID", userID);
            if (!string.IsNullOrEmpty(accessToken))
                form.AddField("AccessToken", accessToken);

            byte[] data = await PostForm("/getserverlist.aspx", form);
            if (data == null) return null;
            return SDKServerListResponse.Parse(data);
        }

        // ── Write last server login ───────────────────────────────
        public async Task WriteLastServer(int serverID, string userID)
        {
            var w = new PbWriter();
            w.WriteInt32(3, serverID);
            w.WriteString(4, userID);
            byte[] reqBody = w.ToArray();
            await PostBinary("/writeuserloginserverid.aspx", reqBody);
        }

        // ── HTTP helpers ──────────────────────────────────────────

        private async Task<byte[]> PostForm(string path, WWWForm form)
        {
            string url = _baseUrl + path;
            using (var req = UnityWebRequest.Post(url, form))
            {
                req.timeout = 10;
                var op = req.SendWebRequest();
                while (!op.isDone) await Task.Yield();

                if (req.result != UnityWebRequest.Result.Success)
                {
                    Debug.LogWarning($"[SDKClient] POST {path} failed: {req.error}");
                    return null;
                }
                return req.downloadHandler.data;
            }
        }

        private async Task<byte[]> PostBinary(string path, byte[] body)
        {
            string url = _baseUrl + path;
            using (var req = new UnityWebRequest(url, "POST"))
            {
                req.uploadHandler = new UploadHandlerRaw(body);
                req.downloadHandler = new DownloadHandlerBuffer();
                req.SetRequestHeader("Content-Type", "application/octet-stream");
                req.timeout = 10;

                var op = req.SendWebRequest();
                while (!op.isDone) await Task.Yield();

                if (req.result != UnityWebRequest.Result.Success)
                {
                    Debug.LogWarning($"[SDKClient] POST {path} binary failed: {req.error}");
                    return null;
                }
                return req.downloadHandler.data;
            }
        }
    }
}
