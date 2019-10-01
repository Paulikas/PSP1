using System;
using System.Collections.Generic;
using System.Text;

namespace Pirma_dalis.Template
{
    class AirBus : FlightTemplate
    {
        public AirBus(string flightType, int weight, int distance) : base(flightType, weight, distance)
        {
            
        }

        public override double flightValue(int weight)
        {
            return profitFromTickets(weight);
        }

        public override double fuelCost(int distance, double fuelPrice)
        {
            return distance * fuelPrice;
        }

        public override double insuranceCost()
        {
            return 600.23;
        }

        public override double maintenance(int distance, int weight)
        {
            if (distance > 5500)
                return 8000;
            else
                return 4000.12;
        }

        private double profitFromTickets(int weight)
        {
            int peopleCount = weight / 60;
            return peopleCount * 98.97;
        }
    }
}
