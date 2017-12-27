namespace CeriQ.Svea.Checkout.Types
{
    public enum CheckoutOrderStatus
    {
        Cancelled,
        Created,
        Confirmed,
        PaymentGuaranteed,
        WaitingToBeSent,
        Final
    }
}
