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
