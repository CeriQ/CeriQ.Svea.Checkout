using System;

namespace CeriQ.Svea.Checkout
{
    /// <summary>
    /// Used to create a <see cref="Types.CallbackResponse"/> when an CheckoutValidationCallback request is made by Svea Ekonomi.
    /// </summary>
    public sealed class Callback
    {
        private readonly string _merchantId;
        private readonly string _sharedSecret;

        /// <summary>
        /// Constructs the callback handler.
        /// </summary>
        /// <param name="merchantId">The MerchantId that Svea Ekonomi has supplied</param>
        /// <param name="sharedSecret">The shared secret that Svea Ekonomi has supplied</param>
        public Callback(string merchantId, string sharedSecret)
        {
            _merchantId = merchantId;
            _sharedSecret = sharedSecret;
        }

        /// <summary>
        /// Creates the callbackresponse from the <see cref="Types.CheckoutValidationCallback"/>.
        /// </summary>
        /// <param name="response">The values to construct a response for.</param>
        /// <returns>A response object containing the headers and body to respond to the request with.</returns>
        public Types.CallbackResponse CreateValidationCallbackResponseHeader(Types.CheckoutValidationCallback response)
        {
            var body = Newtonsoft.Json.JsonConvert.SerializeObject(response);
            DateTime now = DateTime.Now;
            return new Types.CallbackResponse(
                new System.Collections.Generic.Dictionary<string, string>()
                {
                    { "Timestamp", now.ToSveaString() },
                    { "Authorization", body.ToSveaAuthorizationHeader(_merchantId, _sharedSecret, now) }
                },
                body);
        }
    }
}
