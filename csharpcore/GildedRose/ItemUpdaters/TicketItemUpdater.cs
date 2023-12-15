using GildedRose.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.ItemUpdaters
{
    public class TicketItemUpdater : BaseItemUpdater
    {
        public override bool CanUpdate(Item item)
        {
            return item.Name == "Backstage passes to a TAFKAL80ETC concert";
        }

        public override void Update(Item item)
        {
            if (item.Quality < MaxQualityValue)
            {
                item.Quality = item.Quality + 1;

                if (item.SellIn < 11)
                {
                    if (item.Quality < MaxQualityValue)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }

                if (item.SellIn < 6)
                {
                    if (item.Quality < MaxQualityValue)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }
            }

            item.SellIn = item.SellIn - 1;

            if (item.SellIn < 0)
            {
                item.Quality = item.Quality - item.Quality;
            }
        }
    }
}
