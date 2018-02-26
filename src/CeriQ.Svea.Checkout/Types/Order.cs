using Newtonsoft.Json;
using System.Collections.Generic;

namespace CeriQ.Svea.Checkout.Types
{
    /// <summary>
    /// Represents an order fullfillment request to Svea Ekonomi
    /// </summary>
    public sealed class Order
    {
        public MerchantSettings MerchantSettings { get; }
        public Cart Cart { get; }
        public string Locale { get; }
        public string Currency { get; }
        public string CountryCode { get; }
        public string ClientOrderNumber { get; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<PresetValue> PresetValues { get; }

        /// <summary>
        /// Creates a new order request.
        /// </summary>
        /// <param name="merchantSettings">The settings and endpoints for this order to return on</param>
        /// <param name="cart">A cart object containing the order rows</param>
        /// <param name="locale">The locale for this order request.</param>
        /// <param name="currency">The currency for this orer request.</param>
        /// <param name="countryCode">The country code for this order request</param>
        /// <param name="clientOrderNumber">A order number to represent the order in the sending system. Can be updated in a ValidateCallbackResponse.</param>
        /// <param name="presetValues">Unknown. TODO</param>
        public Order(
            MerchantSettings merchantSettings,
            Cart cart,
            string locale,
            string currency,
            string  countryCode,
            string clientOrderNumber,
            List<PresetValue> presetValues
            )
        {
            MerchantSettings = merchantSettings;
            Cart = cart;
            Locale = locale;
            Currency = currency;
            CountryCode = countryCode;
            ClientOrderNumber = clientOrderNumber;
            PresetValues = presetValues;
        }
    }
}
