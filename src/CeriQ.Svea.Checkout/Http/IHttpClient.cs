using System.Net.Http;
using System.Threading.Tasks;

namespace CeriQ.Svea.Checkout.Http
{
    public interface IHttpClient
    {
        Task<HttpResponseMessage> SendAsync(HttpRequestMessage message);
    }
}
