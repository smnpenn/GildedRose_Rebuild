using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public class AgingWellQualityUpdater : QualityUpdater
    {
        public AgingWellQualityUpdater(Item item) : base(item) { }

        public override void UpdateQuality()
        {
            DecreaseSellIn();

            if (Item.SellIn < 0)
            {
                IncreaseQuality(2);
            }
            else
            {
                IncreaseQuality();
            }
        }
    }
}
