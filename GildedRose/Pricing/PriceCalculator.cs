using System;
using System.Collections.Generic;
using System.Linq;

namespace GildedRoseKata.Pricing
{
    public sealed class PriceCalculator
    {
        public List<IDiscount> Discounts { get; set; } = [];

        public double GetTotalPrice(List<Item> items, Currency currency = Currency.EUR)
        {
            foreach( IDiscount discount in Discounts)
            {
                discount.ApplyDiscount(items);
            }

            return Math.Round(currencyConverter.GetPriceForCurrency(items.Sum(e => e.CheckoutPriceInEUR), currency), 2);
        }

        private CurrencyConverter currencyConverter = new CurrencyConverter();
    }
}
