namespace CeriQ.Svea.Checkout.Types
{
    public class CheckoutValidationCallback
    {
        public bool Valid { get; }
        public string ClientOrderNumber { get; }
        public CheckoutValidationCallback(bool valid, string clientOrderNumber)
        {
            Valid = valid;
            ClientOrderNumber = clientOrderNumber;
        }
    }
}
