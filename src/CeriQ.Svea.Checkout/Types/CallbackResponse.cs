using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeriQ.Svea.Checkout.Types
{
    public sealed class CallbackResponse
    {
        public IReadOnlyDictionary<string, string> Headers { get; }
        public string Body { get; }

        internal CallbackResponse(Dictionary<string, string> headers, string body)
        {
            Headers = headers;
            Body = body;
        }
    }
}
