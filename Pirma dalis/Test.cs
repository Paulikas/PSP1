using Pirma_dalis.Strategy;
using System;

namespace Pirma_dalis
{
    class Test
    {
        static void Main(string[] args)
        {
            double value;
            Flight cargo = new Flight("Cargo",10000,600, new Cargo());
            cargo.calProfit();
            value = cargo.flightProfits;

            Console.WriteLine("Value is: " + value);

            Console.ReadKey();
        }
    }
}
