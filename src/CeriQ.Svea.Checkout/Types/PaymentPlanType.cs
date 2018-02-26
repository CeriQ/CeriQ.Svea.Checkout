namespace CeriQ.Svea.Checkout.Types
{
    /// <summary>
    /// The type of payment plan
    /// </summary>
    public enum PaymentPlanType
    {
        Standard, // Carries interest and needs to be paid back from the first month.
        InterestFree, // Has a number of interest free months.
        InterestAndAmortizationFree // Has a number of interest and payback free months.
    }
}
