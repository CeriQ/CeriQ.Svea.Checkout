namespace CeriQ.Svea.Checkout.Types
{
    /// <summary>
    /// Response for a CheckoutValidationCallback. Send this to <see cref="Callback.CreateValidationCallbackResponseHeader(CheckoutValidationCallback)"/> to create a validation callback response.
    /// </summary>
    public sealed class CheckoutValidationCallback
    {
        public bool Valid { get; }
        public string ClientOrderNumber { get; }
        /// <summary>
        /// Constructor for the CheckoutValidationCallback
        /// </summary>
        /// <param name="valid">True if all the orderrows can be fullfilled and are in stock</param>
        /// <param name="clientOrderNumber">Optional, used to update the ClientOrderNumber for this order.</param>
        public CheckoutValidationCallback(bool valid, string clientOrderNumber)
        {
            Valid = valid;
            ClientOrderNumber = clientOrderNumber;
        }
    }
}
