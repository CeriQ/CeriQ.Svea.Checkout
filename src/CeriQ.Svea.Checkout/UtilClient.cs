using System.Collections.Generic;
using System.Threading.Tasks;

namespace CeriQ.Svea.Checkout
{
    /// <summary>
    /// Util client currently used to query for payment campaigns.
    /// </summary>
    public sealed class UtilClient : Client
    {
        /// <summary>
        /// Constructor for the UtilClient
        /// </summary>
        /// <param name="mode">The Mode is used to determine if the Test or Production system is to be used.</param>
        /// <param name="merchantId">The MerchantId that Svea Ekonomi has supplied</param>
        /// <param name="sharedSecret">The shared secret that Svea Ekonomi has supplied</param>
        public UtilClient(Mode mode, string merchantId, string sharedSecret)
            : this(mode == Mode.Production ?
                  Constant.ProductionUrl : 
                  Constant.TestUrl,
                  merchantId,
                  sharedSecret)
        {
        }

        /// <summary>
        /// Non standard constructor for the UtilClient. Used if connecting to a nonstandard endpoint.
        /// </summary>
        /// <param name="baseUrl">The baseurl for the endpoint to connect to</param>
        /// <param name="merchantId">The MerchantId that Svea Ekonomi has supplied</param>
        /// <param name="sharedSecret">The shared secret that Svea Ekonomi has supplied</param>
        public UtilClient(string baseUrl, string merchantId, string sharedSecret)
            : this(new Http.HttpClient(),
                  baseUrl, merchantId, sharedSecret)
        {
        }

        /// <summary>
        /// Non standard constructor for the UtilClient. Mostly used for testing.
        /// </summary>
        /// <param name="client">The HttpClient implementation to use to connect to the remote endpoint.</param>
        /// <param name="baseUrl">The baseurl for the endpoint to connect to</param>
        /// <param name="merchantId">The MerchantId that Svea Ekonomi has supplied</param>
        /// <param name="sharedSecret">The shared secret that Svea Ekonomi has supplied</param>
        public UtilClient(Http.IHttpClient client, string baseUrl, string merchantId, string sharedSecret)
            : base(client, baseUrl, merchantId, sharedSecret)
        {
        }

        /// <summary>
        /// Queries Svea Ekonomi for current campaigns
        /// </summary>
        /// <param name="forCompanies">True to query for campaigns available for companies, otherwise false</param>
        /// <returns>A list of valid and current <see cref="Types.CampaignCodeInfo"/></returns>
        public async Task<List<Types.CampaignCodeInfo>> PartpaymentCampaigns(bool forCompanies)
        {
            return await Get<List<Types.CampaignCodeInfo>>($"/api/getavailablepartpaymentcampaigns/{forCompanies}");
        }
    }
}
