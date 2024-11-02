namespace GildedRoseKata
{
    public class ConjuredQualityUpdater : QualityUpdater
    {
        public ConjuredQualityUpdater(Item item) : base(item) { }

        public override void UpdateQuality()
        {
            DecreaseQuality(2);
            DecreaseSellIn();

            if (Item.SellIn < 0)
            {
                DecreaseQuality(2);
            }
        }
    }
}
