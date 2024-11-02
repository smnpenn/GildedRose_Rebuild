namespace GildedRoseKata
{
    public static class ItemUpdaterFactory
    {
        public static QualityUpdater CreateQualityUpdater(Item item)
        {
            if (item.Type == ItemType.AgingWell)
            {
                return new AgingWellQualityUpdater(item);
            }
            else if (item.Type == ItemType.Legendary)
            {
                return new LegendaryQualityUpdater(item);
            }
            else if (item.Type == ItemType.BackstagePass)
            {
                return new BackstagePassQualityUpdater(item);
            }
            else if (item.Type == ItemType.Conjured)
            {
                return new ConjuredQualityUpdater(item);
            }

            return new NormalQualityUpdater(item);
        }

        public static PriceUpdater CreatePriceUpdater(Item item)
        {
            // return PriceUpdater based on ItemType
            return new PriceUpdater(item);
        }
    }
}
