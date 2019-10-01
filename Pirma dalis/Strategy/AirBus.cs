using System;
using System.Collections.Generic;
using System.Text;

namespace Pirma_dalis.Strategy
{
    class AirBus : IProfitCounter
    {
        public double flightValue(int weight)
        {
            return profitFromTickets(weight);
        }

        public double fuelCost(int distance, double fuelPrice)
        {
            return distance * fuelPrice;
        }

        public double insuranceCost()
        {
            return 600.23;
        }

        public double maintenance(int distance, int weight)
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
