using System;
using System.Collections.Generic;
namespace GildedRoseKata.Services
{
    public sealed class ItemUpdateService
    {
        public void UpdateQuality(Item item)
        {
            if(item == null)
            {
                throw new NullReferenceException("Item cannot be null");
            }

            ItemUpdaterFactory.CreateQualityUpdater(item).UpdateQuality();
        }

        public void UpdateQuality(IEnumerable<Item> items)
        {
            foreach(Item item in items)
            {
                UpdateQuality(item);
            }
        }

        public void UpdatePrice(Item item)
        {
            if (item == null)
            {
                throw new NullReferenceException("Item cannot be null");
            }

            ItemUpdaterFactory.CreatePriceUpdater(item).UpdatePrice();
        }

        public void UpdatePrice(IEnumerable<Item> items)
        {
            foreach (Item item in items)
            {
                UpdatePrice(item);
            }
        }
    }
}
