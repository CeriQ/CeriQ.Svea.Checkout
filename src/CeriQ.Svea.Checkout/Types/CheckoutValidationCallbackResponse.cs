namespace CeriQ.Svea.Checkout.Types
{
    public class CheckoutValidationCallbackResponse
    {
        public bool Valid { get; }
        public string ClientOrderNumber { get; }
        public CheckoutValidationCallbackResponse(bool valid, string clientOrderNumber)
        {
            Valid = valid;
            ClientOrderNumber = clientOrderNumber;
        }
    }
}
