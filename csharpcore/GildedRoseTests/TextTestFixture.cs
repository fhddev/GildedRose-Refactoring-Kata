using System;
using System.Collections.Generic;
using GildedRose.Models;
using GildedRose.Repositories;

namespace GildedRoseTests;

public static class TextTestFixture
{
    public static void Main(string[] args)
    {
        Console.WriteLine("OMGHAI!");

        var itemRepository = new InMemoryItemRepository();

        var items = itemRepository.GetAll();

        var app = new GildedRoseKata.GildedRose(items);

        int days = 2;
        if (args.Length > 0)
        {
            days = int.Parse(args[0]) + 1;
        }

        for (var i = 0; i < days; i++)
        {
            Console.WriteLine("-------- day " + i + " --------");
            Console.WriteLine("name, sellIn, quality");
            for (var j = 0; j < items.Count; j++)
            {
                Console.WriteLine(items[j].Name + ", " + items[j].SellIn + ", " + items[j].Quality);
            }
            Console.WriteLine("");
            app.UpdateQuality();
        }
    }
}