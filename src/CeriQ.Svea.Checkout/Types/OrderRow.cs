using Newtonsoft.Json;
using System;

namespace CeriQ.Svea.Checkout.Types
{
    /// <summary>
    /// Represents an order row in a order fullfillment request
    /// </summary>
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

        /// <summary>
        /// Creates an order row
        /// </summary>
        /// <param name="articleNumber">The article number to represent this item.</param>
        /// <param name="name">A descriptive text that will appear on an invoice´.</param>
        /// <param name="quantity">The quantity of the article that is being purchased. Uses minor currency. For example, 100 means 1, 50 means 0.5.</param>
        /// <param name="unitPrice">The price per unit of the order row. Uses minor currency. For example, 100 means 1, 50 means 0.5.</param>
        /// <param name="discountPercent">A discount to apply to this order row. Uses minor currency. For example, 100 means 1, 50 means 0.5.</param>
        /// <param name="vatPercent">The VAT percent to apply to this order row. Uses minor currency. For example, 100 means 1, 50 means 0.5.</param>
        /// <param name="unit">The name of the unit, for example "st", "ex", "liters".</param>
        /// <param name="temporaryReference">Temporary reference for this row.</param>
        /// <param name="rowNumber">The row number to use for sorting the rows on an invoice. If all rowNumbers are null, rows will be sorted in the order of the array.</param>
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
