using GildedRose.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.ItemUpdaters
{
    public class NoUpdateItemUpdater : BaseItemUpdater
    {
        public override bool CanUpdate(Item item)
        {
            return item.Name == "Sulfuras, Hand of Ragnaros";
        }

        public override void Update(Item item)
        {

        }
    }
}
