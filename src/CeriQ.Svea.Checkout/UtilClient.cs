using System.Collections.Generic;
using System.Threading.Tasks;

namespace CeriQ.Svea.Checkout
{
    public class UtilClient : Client
    {
        public UtilClient(Mode mode, string merchantId, string sharedSecret)
            : this(mode == Mode.Production ?
                  Constant.ProductionUrl : 
                  Constant.TestUrl,
                  merchantId,
                  sharedSecret)
        {
        }

        public UtilClient(string baseUrl, string merchantId, string sharedSecret)
            : this(new Http.HttpClient(),
                  baseUrl, merchantId, sharedSecret)
        {
        }

        public UtilClient(Http.IHttpClient client, string baseUrl, string merchantId, string sharedSecret)
            : base(client, baseUrl, merchantId, sharedSecret)
        {
        }

        public async Task<List<Types.CampaignCodeInfo>> PartpaymentCampaigns(bool forCompanies)
        {
            return await Get<List<Types.CampaignCodeInfo>>($"/api/getavailablepartpaymentcampaigns/{forCompanies}");
        }
    }
}
