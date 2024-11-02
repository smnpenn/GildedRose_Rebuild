using System.Collections.Generic;
using System.Linq;

namespace GildedRoseKata.Pricing
{
    // a bulk discount for a certain ItemType
    public class BulkDiscount : IDiscount
    {
        public BulkDiscount(ItemType discountedItemType, int minQuantity, double discountPercentage)
        {
            this.discountedItemType = discountedItemType;
            this.minQuantity = minQuantity;
            this.discountPercentage = discountPercentage;
        }

        public void ApplyDiscount(List<Item> items)
        {
            List<Item> itemsToApplyDiscount = items.Where(item => item.Type == discountedItemType).ToList();

            if (itemsToApplyDiscount.Count >= minQuantity)
            {
                foreach(Item item in itemsToApplyDiscount)
                {
                    item.CheckoutPriceInEUR = item.CheckoutPriceInEUR * (1 - discountPercentage);
                }
            }
        }

        private readonly ItemType discountedItemType;
        private readonly int minQuantity;
        private readonly double discountPercentage;
    }
}
