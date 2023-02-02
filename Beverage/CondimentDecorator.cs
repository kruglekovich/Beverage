using System;
using System.Collections.Generic;
using System.Text;

namespace coffie
{
    public abstract class CondimentDecorator : Bevarage
    {
        protected Bevarage bevarage;

        public override float GetPrice()
        {
            return bevarage.GetPrice() + price;
        }

        public override string GetDescription()
        {
            return bevarage.GetDescription() + ", " + description;
        }
    }
}
