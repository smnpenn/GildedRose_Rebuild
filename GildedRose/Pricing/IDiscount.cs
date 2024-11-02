using System.Collections.Generic;

namespace GildedRoseKata.Pricing
{
    public interface IDiscount
    {
        void ApplyDiscount(List<Item> items);
    }
}
