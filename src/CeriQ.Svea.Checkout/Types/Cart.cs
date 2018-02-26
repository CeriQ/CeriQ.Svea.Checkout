using System.Collections.Generic;

namespace CeriQ.Svea.Checkout.Types
{
    /// <summary>
    /// The shopping cart for the order to be fullfilled by Svea Ekonomi.
    /// </summary>
    public sealed class Cart
    {
        public List<OrderRow> Items { get; }

        /// <summary>
        /// Creates a cart
        /// </summary>
        /// <param name="items">A list of <see cref="Types.OrderRow"/> that the cart contains.</param>
        public Cart(List<OrderRow> items)
        {
            Items = items;
        }
    }
}
