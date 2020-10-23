using System.Threading.Tasks;

namespace CeriQ.Svea.Checkout
{
    /// <summary>
    /// Client to Get, Create or Update an order
    /// </summary>
    public sealed class OrderClient : Client
    {
        /// <summary>
        /// Constructor for the OrderClient
        /// </summary>
        /// <param name="mode">The Mode is used to determine if the Test or Production system is to be used.</param>
        /// <param name="merchantId">The MerchantId that Svea Ekonomi has supplied</param>
        /// <param name="sharedSecret">The shared secret that Svea Ekonomi has supplied</param>
        public OrderClient(Mode mode, string merchantId, string sharedSecret)
            : this(mode == Mode.Production ?
                  Constant.ProductionUrl : 
                  Constant.TestUrl,
                  merchantId,
                  sharedSecret)
        {
        }

        /// <summary>
        /// Non standard constructor for the OrderClient. Used if connecting to a nonstandard endpoint.
        /// </summary>
        /// <param name="baseUrl">The baseurl for the endpoint to connect to</param>
        /// <param name="merchantId">The MerchantId that Svea Ekonomi has supplied</param>
        /// <param name="sharedSecret">The shared secret that Svea Ekonomi has supplied</param>
        public OrderClient(string baseUrl, string merchantId, string sharedSecret)
            : this(new Http.HttpClient(),
                  baseUrl, merchantId, sharedSecret)
        {
        }

        /// <summary>
        /// Non standard constructor for the OrderClient. Mostly used for testing.
        /// </summary>
        /// <param name="client">The HttpClient implementation to use to connect to the remote endpoint.</param>
        /// <param name="baseUrl">The baseurl for the endpoint to connect to</param>
        /// <param name="merchantId">The MerchantId that Svea Ekonomi has supplied</param>
        /// <param name="sharedSecret">The shared secret that Svea Ekonomi has supplied</param>
        public OrderClient(Http.IHttpClient client, string baseUrl, string merchantId, string sharedSecret)
            : base(client, baseUrl, merchantId, sharedSecret)
        {
        }

        /// <summary>
        /// Attempts to create an Order in Svea Ekonomis system.
        /// </summary>
        /// <param name="order">The order to create</param>
        /// <returns>A <see cref="Types.Data"/> containing the response from Svea Ekonomi.</returns>
        public async Task<Types.Data> Create(Types.Order order)
        {
            return await Post<Types.Data>("/api/orders/", order);
        }

        /// <summary>
        /// Gets the Data for an order that was created previously. 
        /// </summary>
        /// <param name="orderId">The OrderId to query for. Use <see cref="Types.Data.OrderId"/>.</param>
        /// <returns>The full, current <see cref="Types.Data"/> in it's current form.</returns>
        public async Task<Types.Data> Get(long orderId)
        {
            return await Get<Types.Data>($"/api/orders/{orderId}");
        }

        /// <summary>
        /// Updates a order with new data, such as changed <see cref="Types.OrderRow"/> rows.
        /// </summary>
        /// <param name="orderId">The OrderId to update. Use <see cref="Types.Data.OrderId"/>.</param>
        /// <param name="order">The order you want to update the fields for.</param>
        /// <returns>An updated <see cref="Types.Data"/> with the latest response from Svea ekonomi</returns>
        public async Task<Types.Data> Update(long orderId, Types.Order order)
        {
            return await Put<Types.Data>($"/api/orders/{orderId}", order);
        }
    }
}
