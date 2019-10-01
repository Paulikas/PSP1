using System;
using System.Collections.Generic;
using System.Text;

namespace Pirma_dalis.Template
{
    class Cargo : FlightTemplate
    {
        public Cargo(string flightType, int weight, int distance) : base(flightType, weight, distance)
        {
        }

        public override double flightValue(int weight)
        {
            return weight * 4.5;
        }

        public override double fuelCost(int distance, double fuelPrice)
        {
            return distance * fuelPrice;
        }

        public override double insuranceCost()
        {
            return 200.15;
        }

        public override double maintenance(int distance, int weight)
        {
            double value;
            if (distance > 1000)
                value = 350.55;
            else
                value = 50;
            return value + cargoMovingCost(weight);
        }

        private double cargoMovingCost(int weight)
        {
            return weight * 0.6;
        }
    }
}
