using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace CeriQ.Svea.Checkout.Types
{
    public sealed class Data
    {
        public MerchantSettings MerchantSettings { get; }
        public Cart Cart { get; }
        public Gui Gui { get; }
        public Customer Customer { get; }
        public Address ShippingAddress { get; }
        public Address BillingAddress { get; }
        public string CustomerReference { get; }
        public string Locale { get; }
        public string Currency { get; }
        public string CountryCode { get; }
        public string ClientOrderNumber { get; }
        public List<PresetValue> PresetValues { get; }
        public long OrderId { get; }
        [JsonConverter(typeof(StringEnumConverter))]
        public CheckoutOrderStatus? Status { get; }
        public string EmailAddress { get; }
        public string PhoneNumber { get; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PaymentType? PaymentType { get; }
        public bool? SveaWillBuyOrder { get; }

        public Data(
            MerchantSettings merchantSettings,
            Cart cart,
            Gui gui,
            Customer customer,
            Address shippingAddress,
            Address billingAddress,
            string customerReference,
            string locale,
            string currency,
            string countryCode,
            string clientOrderNumber,
            List<PresetValue> presetValues,
            long orderId,
            CheckoutOrderStatus? status,
            string emailAddress,
            string phoneNumber,
            PaymentType? paymentType,
            bool? sveaWillBuyOrder)
        {
            MerchantSettings = merchantSettings;
            Cart = cart;
            Gui = gui;
            Customer = customer;
            ShippingAddress = shippingAddress;
            BillingAddress = billingAddress;
            CustomerReference = customerReference;
            Locale = locale;
            Currency = currency;
            CountryCode = countryCode;
            ClientOrderNumber = clientOrderNumber;
            PresetValues = presetValues;
            OrderId = orderId;
            Status = status;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
            PaymentType = paymentType;
            SveaWillBuyOrder = sveaWillBuyOrder;
        }
    }
}
