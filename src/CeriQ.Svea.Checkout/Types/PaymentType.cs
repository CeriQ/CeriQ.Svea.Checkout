namespace CeriQ.Svea.Checkout.Types
{
    /// <summary>
    /// Selected payment method for this order.
    /// </summary>
    public enum PaymentType
    {
        Null,
        INVOICE,
        ADMININVOICE,
        PAYMENTPLAN,
        SVEACARDPAY,
        SVEACARDPAY_PF,
        ACCOUNTCREDIT,
        CARD,
        ACCOUNT,
        // DirektBank types
        BANKAXESS,
        DBAKTIAFI,
        DBALANDSBANKENFI,
        DBDANSKEBANKSE,
        DBNORDEAFI,
        DBNORDEASE,
        DBPOHJOLAFI,
        DBSAMPOFI,
        DBSEBSE,
        DBSEBFTGSE,
        DBSHBSE,
        DBSPANKKIFI,
        DBSWEDBANKSE,
        DBTAPIOLAFI
    }
}
