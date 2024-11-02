namespace GildedRoseKata
{
    public class NormalQualityUpdater : QualityUpdater
    {
        public NormalQualityUpdater(Item item) : base(item) { }

        public override void UpdateQuality()
        {
            DecreaseSellIn();

            if (Item.SellIn < 0)
            {
                DecreaseQuality(2);
            }
            else
            {
                DecreaseQuality();
            }
        }
    }
}
