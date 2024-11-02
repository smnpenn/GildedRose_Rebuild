using GildedRoseKata.Pricing;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public sealed class ProductCart
    {
        public List<Item> Items { get; set; } = [];

        public double GetTotalPrice(Currency currency = Currency.EUR)
        {
            return priceCalculator.GetTotalPrice(Items, currency);
        }

        public void AddDiscount(IDiscount discount)
        {
            priceCalculator.Discounts.Add(discount);
        }

        public void RemoveDiscount(IDiscount discount)
        {
            priceCalculator.Discounts.Remove(discount);
        }

        private readonly PriceCalculator priceCalculator = new PriceCalculator();
    }
}
