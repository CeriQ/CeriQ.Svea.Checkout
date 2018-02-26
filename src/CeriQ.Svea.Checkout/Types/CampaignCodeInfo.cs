using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace CeriQ.Svea.Checkout.Types
{
    /// <summary>
    /// Represents a campaign offer that Svea Ekonomi is running.
    /// </summary>
    public sealed class CampaignCodeInfo
    {
        /// <summary>
        /// The id of this campaign
        /// </summary>
        public int CampaignCode { get; }
        /// <summary>
        /// The amount of months the customer can payback the campaign over.
        /// </summary>
        public int ContractLengthInMonths { get; }
        /// <summary>
        /// Description of the campaign
        /// </summary>
        public string Description { get; }
        /// <summary>
        /// Minimum purchase amount. Uses minor currency. For example, 100 means 1, 50 means 0.5.
        /// </summary>
        public Decimal FromAmount { get; }
        /// <summary>
        /// Maximum purchase amount. Uses minor currency. For example, 100 means 1, 50 means 0.5.
        /// </summary>
        public Decimal ToAmount { get; }
        /// <summary>
        /// Setup fee for the campaign. Uses minor currency. For example, 100 means 1, 50 means 0.5.
        /// </summary>
        public Decimal InitialFee { get; }
        /// <summary>
        /// Interest rate for the campaign. Uses minor currency. For example, 100 means 1, 50 means 0.5.
        /// </summary>
        public Decimal InterestRatePercent { get; }
        /// <summary>
        /// Monthly annuity factor. Uses minor currency. For example, 100 means 1, 50 means 0.5.
        /// </summary>
        public Decimal MonthlyAnnuityFactor { get; }
        /// <summary>
        /// Notification fee. Uses minor currency. For example, 100 means 1, 50 means 0.5.
        /// </summary>
        public Decimal NotificationFee { get; }
        /// <summary>
        /// Number of months before a campaign purchase starts accruing interest.
        /// </summary>
        public int NumberOfInterestFreeMonths { get; }
        /// <summary>
        /// Number of months before the campaign needs to be paid back upon
        /// </summary>
        public int NumberOfPaymentFreeMonths { get; }
        /// <summary>
        /// The type of campaign
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public PaymentPlanType PaymentPlanType { get; }
        public CampaignCodeInfo(
            int campaignCode,
            int contractLengthInMonths,
            string description,
            Decimal fromAmount,
            decimal toAmount,
            Decimal initialFee,
            Decimal interestRatePercent,
            Decimal monthlyAnnuityFactor,
            Decimal notificationFee,
            int numberOfInterestFreeMonths,
            int numberOfPaymentFreeMonths,
            PaymentPlanType paymentPlanType)
        {
            CampaignCode = campaignCode;
            ContractLengthInMonths = contractLengthInMonths;
            Description = description;
            FromAmount = fromAmount;
            ToAmount = toAmount;
            InitialFee = initialFee;
            InterestRatePercent = interestRatePercent;
            MonthlyAnnuityFactor = monthlyAnnuityFactor;
            NotificationFee = NotificationFee;
            NumberOfInterestFreeMonths = numberOfInterestFreeMonths;
            NumberOfPaymentFreeMonths = numberOfPaymentFreeMonths;
            PaymentPlanType = paymentPlanType;
        }
    }
}
