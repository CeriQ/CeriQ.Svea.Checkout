using System.Net.Http;
using System.Threading.Tasks;

namespace CeriQ.Svea.Checkout.Http
{
    /// <summary>
    /// Interface for implementing a HttpClient. Used to mock automatic tests without actually calling out to the network.
    /// </summary>
    public interface IHttpClient
    {
        Task<HttpResponseMessage> SendAsync(HttpRequestMessage message);
    }
}
