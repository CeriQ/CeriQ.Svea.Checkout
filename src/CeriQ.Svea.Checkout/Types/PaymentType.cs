namespace CeriQ.Svea.Checkout.Types
{
    public enum PaymentType
    {
        Null,
        INVOICE,
        ADMININVOICE,
        PAYMENTPLAN,
        SVEACARDPAY,
        SVEACARDPAY_PF,
        ACCOUNTCREDIT,
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
        DBTAPIOLAFI,
        TRUSTLY
    }
}
