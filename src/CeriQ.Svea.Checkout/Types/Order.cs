using Newtonsoft.Json;
using System.Collections.Generic;

namespace CeriQ.Svea.Checkout.Types
{
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
