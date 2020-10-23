using Newtonsoft.Json;
using System.Collections.Generic;

namespace CeriQ.Svea.Checkout.Types
{
    /// <summary>
    /// Endpoint and other settings for an order fullfillment request.
    /// </summary>
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

        /// <summary>
        /// Sets the merchant settings for an order fullfillment request.
        /// </summary>
        /// <param name="termsUri">The full URI to the Terms & Conditions page for this purchase.</param>
        /// <param name="checkoutUri">The full URI to the page where the checkout will be displayed</param>
        /// <param name="confirmationUri">The full URI to send the user to after a successfull purchase.</param>
        /// <param name="pushUri">The full URI to send updated for the order to. May contain the {checkout.order.uri} placeholder which Svea Ekonomi will replace with the order number.</param>
        /// <param name="checkoutValidationCallBackUri">Optional. The full URI to callback to to verify stock levels and give you the oportunity to change to ClientOrderNumber. May contain the {checkout.order.uri} placeholder which Svea Ekonomi will replace with the order number.</param>
        /// <param name="activePartPaymentCampaigns">Unknown</param>
        /// <param name="promotedPartPaymentCampaign">Unknown</param>
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
