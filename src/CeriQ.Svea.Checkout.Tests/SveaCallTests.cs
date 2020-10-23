using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CeriQ.Svea.Checkout.Tests
{
    [TestClass]
    public class SveaCallTests
    {
        [TestMethod]
        public void CreateOrder()
        {
            AsyncTestWrapper(CreateOrderAsync);
        }

        public void CreateOrderAsync()
        {
            var order = new Types.Order(
                new Types.MerchantSettings(
                    "https://test.se/terms",
                    "https://test.se/checkout",
                    "https://test.se/confirmation",
                    "https://test.se/push",
                    "https://test.se/callback",
                    null,
                    null),
                new Types.Cart(
                    new List<Types.OrderRow>()
                    {
                        new Types.OrderRow("testSku1", "Test Article 1", 1, 10000, null, 2500, "st", String.Empty, null)
                    }
                    ),
                "sv-SE",
                "SEK",
                "SE",
                "1",
                null);
            var orderClient = new OrderClient(Mode.Test, "MerchantId", "SharedSecret");

            //var resp = orderClient.Create(order).Result;
        }

        private void AsyncTestWrapper(Action func)
        {
            try
            {
                func();
            } catch(AggregateException aggr)
            {
                if (aggr.InnerException != null)
                    throw aggr.InnerException;
            }
        }
    }
}
