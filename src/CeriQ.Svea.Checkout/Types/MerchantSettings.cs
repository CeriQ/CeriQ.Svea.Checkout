using Newtonsoft.Json;
using System.Collections.Generic;

namespace CeriQ.Svea.Checkout.Types
{
    public sealed class MerchantSettings
    {
        public string TermsUri { get; }
        public string CheckoutUri { get; }
        public string ConfirmationUri { get; }
        public string PushUri { get; }
        public string CheckoutValidationCallBackUri { get; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<int> ActivePartPaymentCampaigns { get; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? PromotedPartPaymentCampaign { get; }

        public MerchantSettings(
            string termsUri,
            string checkoutUri,
            string confirmationUri,
            string pushUri,
            string checkoutValidationCallBackUri,
            List<int> activePartPaymentCampaigns,
            int? promotedPartPaymentCampaign
            )
        {
            TermsUri = termsUri;
            CheckoutUri = checkoutUri;
            ConfirmationUri = confirmationUri;
            PushUri = pushUri;
            CheckoutValidationCallBackUri = checkoutValidationCallBackUri;
            ActivePartPaymentCampaigns = activePartPaymentCampaigns;
            PromotedPartPaymentCampaign = promotedPartPaymentCampaign;
        }
    }
}
