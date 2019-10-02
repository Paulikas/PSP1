using System;
using System.Collections.Generic;
using System.Text;

namespace Pirma_dalis.Strategy
{
    class Cargo : IProfitCounter
    {
        public double fuelCost(int distance, double fuelPrice)
        {
            return distance * fuelPrice;
        }

        public double insuranceCost()
        {
            return 200.15;
        }

        public double maintenance(int distance, int weight)
        {
            double value;
            if (distance > 1000)
                value = 350.55;
            else
                value = 50;
            return value + cargoMovingCost(weight);
        }

        public double cargoMovingCost(int weight)
        {
            return weight * 0.6;
        }

        public double tripValue(int weight)
        {
            return weight * 4.5;
        }
    }
}
