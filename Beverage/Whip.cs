using System;
using System.Collections.Generic;
using System.Text;

namespace coffie
{
    class Whip : CondimentDecorator
    {
        public Whip(Bevarage bevarage)
        {
            this.bevarage = bevarage;

            price = 50;
            description = "whip";
        }
    }
}
