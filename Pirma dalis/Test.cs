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

            FlightStrategy cargoStrat = new FlightStrategy("A",5,"Bad", new Strategy.Cargo());
            FlightStrategy airbusStrat = new FlightStrategy("C", 9, "Normal", new Strategy.Passengers());

            
            value = cargoStrat.calInsurace();

            Console.WriteLine("Value of Cargo is: " + value);

            airbusStrat.calInsurace();
            value = airbusStrat.calInsurace();

            Console.WriteLine("Value of AirBus is: " + value);

            Console.WriteLine();
            Console.WriteLine("Template:");

            Template.FlightTemplate1 airbusTemp = new Template.Passengers("AirBus", 5, "Bad");
            Template.FlightTemplate1 cargoTemp = new Template.Cargo("Cargo", 9, "Perfect");

            value = cargoTemp.calInsurace();

            Console.WriteLine("Value of Cargo is: " + value);

            value = airbusTemp.calInsurace();

            Console.WriteLine("Value of AirBus is: " + value);

            //A reikalvavimas - kita esybe
            Console.WriteLine();
            Console.WriteLine("Kita esybe:");
            Strategy.Ship cruise = new Strategy.Ship("S", 6, "Bad", new Passengers());

            value = cruise.calInsurace();

            Console.WriteLine("Value of cruise is " + value);

            Console.WriteLine();
            Console.WriteLine("Kitas funkcionalumas:");

            Console.WriteLine();
            Console.WriteLine("Strategy:");
            FlightStrategy cargo_private_strat = new FlightStrategy("A", 2, "Sunny", new Cargo(), 20000, "Scketchy", new Private());
            FlightStrategy airbus_line_strat = new FlightStrategy("SS", 9, "Sunny", new Passengers(), 3500, "Planned", new AirLines());

            Console.WriteLine("trip cost of private cargo flight " + cargo_private_strat.calTripCost());
            Console.WriteLine("trip cost of air lines bus flight " + airbus_line_strat.calTripCost());

            Console.WriteLine();
            Console.WriteLine("Template:");

            Template.FlightTemplate2 cargo_air_lines_temp = new Template.CargoAirLines("B", 4, "Bad", 6000, "Planned");
            Template.FlightTemplate2 private_air_bus_temp = new Template.PrivateAirBus("C", 2, "Decent", 2500, "Unbusy");

            Console.WriteLine("trip cost of air lines cargo flight " + cargo_air_lines_temp.calTripCost());
            Console.WriteLine("trip cost of private air bus flight " + private_air_bus_temp.calTripCost());

            Console.ReadKey();
        }
    }
}
