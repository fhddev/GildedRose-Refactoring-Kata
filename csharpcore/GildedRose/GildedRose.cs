using System.Collections.Generic;
using System.Linq;
using GildedRose;
using GildedRose.ItemUpdaters;
using GildedRose.Models;

namespace GildedRoseKata;

public class GildedRose
{
    private readonly IList<Item> _items;

    private readonly List<BaseItemUpdater> _itemUpdaters;

    public GildedRose(IList<Item> items)
    {
        _items = items;

        _itemUpdaters = new List<BaseItemUpdater>
        {
            new NoUpdateItemUpdater(),
            new QualityIncreaseItemUpdater(),
            new QualityIncreaseDoubleNormalItemUpdater(),
            new TicketItemUpdater(),

            // always at the end
            new NormalItemUpdater()
        };

    }

    public void UpdateQuality()
    {
        foreach (var item in _items)
        {
            foreach (var itemUpdater in _itemUpdaters)
            {
                if (itemUpdater.CanUpdate(item))
                {
                    itemUpdater.Update(item);
                    break;
                }
            }
        }
    }
}