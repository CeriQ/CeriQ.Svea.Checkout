namespace CeriQ.Svea.Checkout.Types
{
    /// <summary>
    /// Order status for the order.
    /// </summary>
    public enum CheckoutOrderStatus
    {
        Cancelled,
        Created,
        Confirmed,
        PaymentGuaranteed,
        WaitingToBeSent,
        /// <summary>
        /// The order is completed and ready to be activated and sent.
        /// </summary>
        Final 
    }
}
