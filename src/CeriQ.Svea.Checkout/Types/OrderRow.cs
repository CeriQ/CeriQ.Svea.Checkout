using Newtonsoft.Json;

namespace CeriQ.Svea.Checkout.Types
{
    public class OrderRow
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
