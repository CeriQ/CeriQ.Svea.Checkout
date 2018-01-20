using System;

namespace CeriQ.Svea.Checkout
{
    public sealed class Callback
    {
        private readonly string _merchantId;
        private readonly string _sharedSecret;

        public Callback(string merchantId, string sharedSecret)
        {
            _merchantId = merchantId;
            _sharedSecret = sharedSecret;
        }

        public Types.CallbackResponse CreateValidationCallbackResponseHeader(Types.CheckoutValidationCallback response)
        {
            var body = Newtonsoft.Json.JsonConvert.SerializeObject(response);
            var timeString = DateTime.Now.ToSveaString();
            return new Types.CallbackResponse(new System.Collections.Generic.Dictionary<string, string>()
            {
                { "Timestamp", timeString },
                { "Authorization", Client.GenerateSecurityHeader(_merchantId, _sharedSecret, timeString, body) }
            },
            body);
        }
    }
}
