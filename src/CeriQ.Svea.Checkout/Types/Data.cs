using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace CeriQ.Svea.Checkout.Types
{
    /// <summary>
    /// Response for when an order has been created, queried or updated.
    /// </summary>
    public sealed class Data
    {
        /// <summary>
        /// The merchant settings that were supplied in the latest <see cref="OrderClient.Create(Order)"/> or <see cref="OrderClient.Update(long, Order)"/> call.
        /// </summary>
        public MerchantSettings MerchantSettings { get; }
        /// <summary>
        /// The cart that were supplied in the latest <see cref="OrderClient.Create(Order)"/> or <see cref="OrderClient.Update(long, Order)"/> call.
        /// </summary>
        public Cart Cart { get; }
        /// <summary>
        /// Represents the GUI to display to the user to complete the Checkout procedure, or a thank you page if the order has been completed.
        /// </summary>
        public Gui Gui { get; }
        /// <summary>
        /// Information about the customer. Is prefilled when creating the order if the customer is known, otherwise will be filled on subsequent <see cref="OrderClient.Get(long)"/> requests.
        /// </summary>
        public Customer Customer { get; }
        /// <summary>
        /// The address to ship the order to. Available after the checkout is completed.
        /// </summary>
        public Address ShippingAddress { get; }
        /// <summary>
        /// The address to bill the order for. Available after the checkout is completed.
        /// </summary>
        public Address BillingAddress { get; }
        /// <summary>
        /// Contains a customer requested order reference.
        /// </summary>
        public string CustomerReference { get; }
        /// <summary>
        /// Returns the locale that was supplied in the latest <see cref="OrderClient.Create(Order)"/> or <see cref="OrderClient.Update(long, Order)"/> call.
        /// </summary>
        public string Locale { get; }
        /// <summary>
        /// The currency that was supplied in the latest <see cref="OrderClient.Create(Order)"/> or <see cref="OrderClient.Update(long, Order)"/> call.
        /// </summary>
        public string Currency { get; }
        /// <summary>
        /// The country code that was supplied in the latest <see cref="OrderClient.Create(Order)"/> or <see cref="OrderClient.Update(long, Order)"/> call.
        /// </summary>
        public string CountryCode { get; }
        /// <summary>
        /// The Order Number that was supplied in the latest <see cref="OrderClient.Create(Order)"/>, <see cref="OrderClient.Update(long, Order)"/> or OrderValidation call.
        /// </summary>
        public string ClientOrderNumber { get; }
        /// <summary>
        /// Unknown
        /// </summary>
        public List<PresetValue> PresetValues { get; }
        /// <summary>
        /// Sveas Order id.
        /// </summary>
        public long OrderId { get; }
        /// <summary>
        /// Status for this order.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public CheckoutOrderStatus? Status { get; }
        /// <summary>
        /// Customer email address.
        /// </summary>
        public string EmailAddress { get; }
        /// <summary>
        /// Customer phone number.
        /// </summary>
        public string PhoneNumber { get; }
        /// <summary>
        /// Selected payment method.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public PaymentType? PaymentType { get; }
        /// <summary>
        /// Sveas decision on wether to buy this order or not.
        /// </summary>
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
