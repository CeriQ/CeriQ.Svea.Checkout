using Newtonsoft.Json;
using System;

namespace CeriQ.Svea.Checkout.Types
{
    public sealed class OrderRow
    {
        public string ArticleNumber { get; }
        public string Name { get; }
        public int Quantity { get; }
        public int UnitPrice { get; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? DiscountPercent { get; }
        public int VatPercent { get; }
        public string Unit { get; }
        public string TemporaryReference { get; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? RowNumber { get; }

        public OrderRow(
            string articleNumber,
            string name,
            int quantity,
            int unitPrice,
            int? discountPercent,
            int vatPercent,
            string unit,
            string temporaryReference,
            int? rowNumber
            )
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));
            if (name.Length < 1 || name.Length > 40)
                throw new ArgumentOutOfRangeException(nameof(name), "Length of the name must be between 1 and 40 characters.");

            if(unit != null && (unit.Length < 1 || unit.Length > 4))
                throw new ArgumentOutOfRangeException(nameof(unit), "Length of the unit must be between 1 and 4 characters.");

            ArticleNumber = articleNumber;
            Name = name;
            Quantity = quantity;
            UnitPrice = unitPrice;
            DiscountPercent = discountPercent;
            VatPercent = vatPercent;
            Unit = unit;
            TemporaryReference = temporaryReference;
            RowNumber = rowNumber;
        }
    }
}
