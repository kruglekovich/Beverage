using System;
using System.Collections.Generic;
using System.Text;

namespace coffie
{
    class Soy : CondimentDecorator
    {
        public Soy(Bevarage bevarage)
        {
            this.bevarage = bevarage;

            price = 40;
            description = "soy";
        }
    }
}
