using GildedRoseKata.Services;
using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
        qualityUpdateService = new ItemUpdateService();
    }

    public void UpdateQuality()
    {
        qualityUpdateService.UpdateQuality(Items);
    }

    private IList<Item> Items;
    private ItemUpdateService qualityUpdateService;
}