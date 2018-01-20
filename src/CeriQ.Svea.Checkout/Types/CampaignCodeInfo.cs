using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace CeriQ.Svea.Checkout.Types
{
    public sealed class CampaignCodeInfo
    {
        public int CampaignCode { get;  }
        public int ContractLengthInMonths { get;  }
        public string Description { get;  }
        public Decimal FromAmount { get;  }
        public Decimal ToAmount { get;  }
        public Decimal InitialFee { get;  }
        public Decimal InterestRatePercent { get;  }
        public Decimal MonthlyAnnuityFactor { get;  }
        public Decimal NotificationFee { get;  }
        public int NumberOfInterestFreeMonths { get;  }
        public int NumberOfPaymentFreeMonths { get;  }
        [JsonConverter(typeof(StringEnumConverter))]
        public PaymentPlanType PaymentPlanType { get;  }
        //public Decimal ToAmount { get;  } // Wrong name?
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
