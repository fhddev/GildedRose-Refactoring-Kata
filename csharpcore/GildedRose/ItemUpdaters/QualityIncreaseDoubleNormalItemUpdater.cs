using GildedRose.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.ItemUpdaters
{
    public class QualityIncreaseDoubleNormalItemUpdater : BaseItemUpdater
    {
        public override bool CanUpdate(Item item)
        {
            return item.Name == "Conjured";
        }

        public override void Update(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality = item.Quality - 1;
            }

            item.SellIn = item.SellIn - 1;

            if (item.SellIn < 0 && item.Quality > 0)
            {
                item.Quality = item.Quality - 1;
            }
        }
    }
}
