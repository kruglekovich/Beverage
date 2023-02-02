using System;
using System.Collections.Generic;
using System.Text;

namespace coffie
{
    class Milk : CondimentDecorator
    {

        public Milk(Bevarage bevarage)
        {
            this.bevarage = bevarage;

            price = 15;
            description = "milk";
        }

    }
}
