using Pirma_dalis.Strategy;
using System;

namespace Pirma_dalis
{
    class Test
    {
        static void Main(string[] args)
        {
            double value;

            Console.WriteLine("Strategy:");

            FlightStrategy cargoStrat = new FlightStrategy("Cargo",10000,600, new Strategy.Cargo());
            FlightStrategy airbusStrat = new FlightStrategy("AirBus", 36000, 25000, new Strategy.AirBus());

            cargoStrat.calProfit();
            value = cargoStrat.flightProfits;

            Console.WriteLine("Value of Cargo is: " + value);

            airbusStrat.calProfit();
            value = airbusStrat.flightProfits;

            Console.WriteLine("Value of AirBus is: " + value);

            Console.WriteLine();
            Console.WriteLine("Template:");

            Template.AirBus airbusTemp = new Template.AirBus("AirBus", 36000, 25000);
            Template.Cargo cargoTemp = new Template.Cargo("Cargo", 10000, 600);

            cargoTemp.calProfit();
            value = cargoTemp.flightProfits;

            Console.WriteLine("Value of Cargo is: " + value);

            airbusTemp.calProfit();
            value = airbusTemp.flightProfits;

            Console.WriteLine("Value of AirBus is: " + value);

            Console.ReadKey();
        }
    }
}
