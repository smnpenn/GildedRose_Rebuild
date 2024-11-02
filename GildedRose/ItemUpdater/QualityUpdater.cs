using System;

namespace GildedRoseKata
{
    public abstract class QualityUpdater
    {
        protected Item Item;

        public QualityUpdater(Item item)
        {
            this.Item = item;
        }

        public abstract void UpdateQuality();

        protected void DecreaseSellIn()
        {
            if (Item.Type == ItemType.Legendary)
            {
                Item.SellIn--;
            }
        }

        protected void DecreaseQuality(int amount = 1)
        {
            Item.Quality = Math.Max(0, Item.Quality - amount);
        }

        protected void IncreaseQuality(int amount = 1)
        {
            Item.Quality = Math.Min(50, Item.Quality + amount);
        }
    }
}
