using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Pricing
{
    public class CurrencyConverter
    {
        public CurrencyConverter() 
        {
            exchangeRatesToEUR.Add(Currency.EUR, 1.0);
            exchangeRatesToEUR.Add(Currency.USD, 1.09);
            exchangeRatesToEUR.Add(Currency.GBP, 0.84);
        }

        public double GetPriceForCurrency(double price, Currency currency)
        {
            if( exchangeRatesToEUR.TryGetValue(currency, out double exchangeRate))
            {
                return price * exchangeRate;
            }

            // currency exchange rate not found
            return price;
        }

        private Dictionary<Currency, double> exchangeRatesToEUR = new Dictionary<Currency, double>();
    }

    public enum Currency
    {
        EUR,
        USD,
        GBP
    }
}
