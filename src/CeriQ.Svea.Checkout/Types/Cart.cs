using System.Collections.Generic;

namespace CeriQ.Svea.Checkout.Types
{
    public class Cart
    {
        public List<OrderRow> Items { get; }

        public Cart(List<OrderRow> items)
        {
            Items = items;
        }
    }
}
