using GildedRose.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose
{
    public abstract class BaseItemUpdater
    {

        protected readonly int MaxQualityValue = 50;

        public abstract bool CanUpdate(Item item);

        public abstract void Update(Item item);

    }
}
