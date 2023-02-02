using System;
using System.Collections.Generic;
using System.Text;

namespace coffie
{
    class Mocha : CondimentDecorator
    {
        public Mocha(Bevarage bevarage)
        {
            this.bevarage = bevarage;

            price = 25;
            description = "mocha";
        }
    }
}
