using System;
using System.Collections.Generic;
using System.Text;

namespace coffie
{
    public abstract class Bevarage
    {
        protected string description;
        protected float price;

        public virtual string GetDescription()
        {
            return description;
        }

        public virtual float GetPrice()
        {
            return price;
        }
    }
}