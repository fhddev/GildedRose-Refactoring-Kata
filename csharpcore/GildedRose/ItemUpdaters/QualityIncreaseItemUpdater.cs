using GildedRose.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.ItemUpdaters
{
    public class QualityIncreaseItemUpdater : BaseItemUpdater
    {
        public override bool CanUpdate(Item item)
        {
            return item.Name == "Aged Brie";
        }

        public override void Update(Item item)
        {

            if (item.Quality < MaxQualityValue)
            {
                item.Quality = item.Quality + 1;
            }

            item.SellIn = item.SellIn - 1;

            if (item.SellIn < 0)
            {
                if (item.Quality < MaxQualityValue)
                {
                    item.Quality = item.Quality + 1;
                }
            }
        }
    }
}
