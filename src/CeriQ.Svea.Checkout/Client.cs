using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CeriQ.Svea.Checkout
{
    public abstract class Client
    {
        private readonly Http.IHttpClient _client;
        private readonly string _baseUrl;
        private readonly string _merchantId;
        private readonly string _sharedSecret;

        internal Client(Http.IHttpClient client, string baseUrl, string merchantId, string sharedSecret)
        {
            _client = client;
            _baseUrl = baseUrl;
            _merchantId = merchantId;
            _sharedSecret = sharedSecret;
        }

        private string GenerateSecurityHeader(string timestampString, string body)
        {
            byte[] hash;
            string hashString = body + _sharedSecret + timestampString;
            using (var sha = new System.Security.Cryptography.SHA512Managed())
            {
                hash = sha.ComputeHash(System.Text.Encoding.UTF8.GetBytes(hashString));
            }
            StringBuilder hashHexSb = new StringBuilder();
            foreach (var b in hash)
            {
                hashHexSb.Append(String.Format("{0:x2}", b));
            }
            return $"Svea {Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes($"{_merchantId}:{hashHexSb.ToString()}"))}";
        }

        private HttpRequestMessage CreateHttpRequestMessage(string uri, HttpMethod method, string content, DateTime timestamp)
        {
            var timestampString = timestamp.ToString("yyyy-MM-dd HH:mm");
            var httpMessage = new HttpRequestMessage();
            httpMessage.Headers.Add("Timestamp", timestampString);
            httpMessage.Headers.Add("Authorization", GenerateSecurityHeader(timestampString, content));
            if (!String.IsNullOrEmpty(content))
            {
                httpMessage.Content = new StringContent(content, Encoding.UTF8, "application/json");
            }
            httpMessage.Method = method;
            httpMessage.RequestUri = new Uri(uri);

            return httpMessage;
        }

        private async Task<T> Call<T>(string uri, HttpMethod method, object content)
        {
            string json = content != null ?
                Newtonsoft.Json.JsonConvert.SerializeObject(content) :
                null;

            var httpMessage = CreateHttpRequestMessage($"{_baseUrl}{uri}", method, json, DateTime.UtcNow);
            var response = await _client.SendAsync(httpMessage);

            if (!response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException($"Errorcode recieved from Svea: {response.StatusCode}. Body: {responseBody}.");
            }

            var respJson = await response.Content.ReadAsStringAsync();
            T ret = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(respJson);
            return ret;
        }

        protected async Task<T> Post<T>(string uri, object content)
        {
            return await Call<T>(uri, HttpMethod.Post, content);
        }

        protected async Task<T> Get<T>(string uri)
        {
            return await Call<T>(uri, HttpMethod.Get, null);
        }

        protected async Task<T> Put<T>(string uri, object content)
        {
            return await Call<T>(uri, HttpMethod.Put, content);
        }
    }
}
