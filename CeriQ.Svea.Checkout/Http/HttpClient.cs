using System.Net.Http;
using System.Threading.Tasks;

namespace CeriQ.Svea.Checkout.Http
{
    class HttpClient : IHttpClient
    {
        private readonly System.Net.Http.HttpClient _client;
        public HttpClient()
        {
            _client = new System.Net.Http.HttpClient();
        }

        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage message)
        {
            return _client.SendAsync(message);
        }
    }
}
