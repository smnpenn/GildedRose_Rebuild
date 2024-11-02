#nullable enable
namespace GildedRoseKata;

public class Item
{
    public Item(string name, int sellIn, int quality, ItemType type, double priceInEUR)
    {
        Name = name;
        SellIn = sellIn;
        Quality = quality;
        Type = type;
        BasePriceInEUR = priceInEUR;
        CheckoutPriceInEUR = priceInEUR;
    }

    public string Name { get; set; } = string.Empty;
    public int SellIn { get; set; }
    public int Quality { get; set; }
    public ItemType Type { get; set; } = ItemType.Normal;
    public double BasePriceInEUR { get; set; } = 100;
    public double CheckoutPriceInEUR { get; set; }
}

public enum ItemType
{
    Normal,
    AgingWell,
    Legendary,
    Conjured,
    BackstagePass
}