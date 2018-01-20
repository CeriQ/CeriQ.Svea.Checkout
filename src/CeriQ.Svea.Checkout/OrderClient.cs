using System.Threading.Tasks;

namespace CeriQ.Svea.Checkout
{
    public sealed class OrderClient : Client
    {
        public OrderClient(Mode mode, string merchantId, string sharedSecret)
            : this(mode == Mode.Production ?
                  Constant.ProductionUrl : 
                  Constant.TestUrl,
                  merchantId,
                  sharedSecret)
        {
        }

        public OrderClient(string baseUrl, string merchantId, string sharedSecret)
            : this(new Http.HttpClient(),
                  baseUrl, merchantId, sharedSecret)
        {
        }

        public OrderClient(Http.IHttpClient client, string baseUrl, string merchantId, string sharedSecret)
            : base(client, baseUrl, merchantId, sharedSecret)
        {
        }

        public async Task<Types.Data> Create(Types.Order order)
        {
            return await Post<Types.Data>("/api/orders/", order);
        }

        public async Task<Types.Data> Get(long orderId)
        {
            return await Get<Types.Data>($"/api/orders/{orderId}");
        }

        public async Task<Types.Data> Update(long orderId, Types.Order order)
        {
            return await Put<Types.Data>($"/api/orders/{orderId}", order);
        }
    }
}
