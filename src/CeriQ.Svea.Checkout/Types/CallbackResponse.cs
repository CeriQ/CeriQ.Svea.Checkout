using System.Collections.Generic;

namespace CeriQ.Svea.Checkout.Types
{
    /// <summary>
    /// Data to send back in the response to a CheckoutValidationCallback request.
    /// </summary>
    public sealed class CallbackResponse
    {
        /// <summary>
        /// Dictionary for name, value pairs for the header values to respond with
        /// </summary>
        public IReadOnlyDictionary<string, string> Headers { get; }
        /// <summary>
        /// The response body to respond with
        /// </summary>
        public string Body { get; }

        internal CallbackResponse(Dictionary<string, string> headers, string body)
        {
            Headers = headers;
            Body = body;
        }
    }
}
