using System;

namespace coffie
{
    class Program
    {
        static void Main()
        {
            Bevarage espresso = new Espresso();
            espresso = new Milk(espresso);

            Console.WriteLine($"Описание: {espresso.GetDescription()} \nЦена: {espresso.GetPrice()}");

            Bevarage decaf = new Decaf();
            decaf = new Mocha(decaf);
            decaf = new Mocha(decaf);

            Console.WriteLine($"Описание: {decaf.GetDescription()} \nЦена: {decaf.GetPrice()}");
        }
    }
}
