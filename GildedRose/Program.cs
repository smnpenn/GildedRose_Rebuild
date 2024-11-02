using GildedRoseKata.Pricing;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GildedRoseKata;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("OMGHAI!");

        IList<Item> items = new List<Item>
        {
            new Item("+5 Dexterity Vest", 10, 20, ItemType.Normal, 20.00),
            new Item("Aged Brie", 2, 0, ItemType.AgingWell, 35.00),
            new Item("Elixir of the Mongoose", 5, 7, ItemType.Normal, 25.00),
            new Item("Sulfuras, Hand of Ragnaros", 0, 80, ItemType.Legendary, 100.00),
            new Item("Sulfuras, Hand of Ragnaros", -1, 80, ItemType.Legendary, 100.00),
            new Item("Backstage passes to a TAFKAL80ETC concert", 15, 20, ItemType.BackstagePass, 50.00),
            new Item("Backstage passes to a TAFKAL80ETC concert", 10, 49, ItemType.BackstagePass, 50.00),
            new Item("Backstage passes to a TAFKAL80ETC concert", 5, 49, ItemType.BackstagePass, 50.00),
            new Item("Conjured Mana Cake", 3, 6, ItemType.Conjured, 10.00)
        };

        var app = new GildedRose(items);

        ProductCart productCart = new ProductCart();
        productCart.Items = items.ToList();

        BulkDiscount bulkDiscount = new BulkDiscount(ItemType.Normal, 1, 0.1);
        BulkDiscount bulkDiscount2 = new BulkDiscount(ItemType.Normal, 1, 0.2);

        productCart.AddDiscount(bulkDiscount);
        productCart.AddDiscount(bulkDiscount2);

        double total = productCart.GetTotalPrice();
        double totalInUSD = productCart.GetTotalPrice(Currency.USD);
        double totalInGBP = productCart.GetTotalPrice(Currency.GBP);

        //int days = 2;
        //if (args.Length > 0)
        //{
        //    days = int.Parse(args[0]) + 1;
        //}

        //for (var i = 0; i < days; i++)
        //{
        //    Console.WriteLine("-------- day " + i + " --------");
        //    Console.WriteLine("name, sellIn, quality");
        //    for (var j = 0; j < items.Count; j++)
        //    {
        //        Console.WriteLine(items[j].Name + ", " + items[j].SellIn + ", " + items[j].Quality);
        //    }
        //    Console.WriteLine("");
        //    app.UpdateQuality();
        //}
    }
}