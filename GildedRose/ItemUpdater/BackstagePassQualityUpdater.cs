namespace GildedRoseKata
{
    public class BackstagePassQualityUpdater : QualityUpdater
    {
        public BackstagePassQualityUpdater(Item item) : base(item) { }

        public override void UpdateQuality()
        {
            if (Item.SellIn < 6)
            {
                IncreaseQuality(3);
            }
            else if (Item.SellIn < 11)
            {
                IncreaseQuality(2);
            }
            else
            {
                IncreaseQuality(1);
            }

            DecreaseSellIn();

            if( Item.SellIn < 0)
            {
                Item.Quality = 0;
            }
        }
    }
}
