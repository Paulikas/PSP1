using System;
using System.Collections.Generic;
using System.Text;

namespace Pirma_dalis.Template
{
    abstract class FlightTemplate
    {
        private string flightType;
        private int weight;
        private int distance;
        private const double FUEL_PRICE_PER_100 = 1.25;
        public double flightProfits;

        public FlightTemplate(string flightType, int weight, int distance)
        {
            this.flightType = flightType;
            this.weight = weight;
            this.distance = distance;
        }

        public abstract double insuranceCost();

        public abstract double fuelCost(int distance, double fuelPrice);

        public abstract double maintenance(int distance, int weight);

        public abstract double flightValue(int weight);

        public void calProfit()
        {
            double sum = 0;

            sum = flightValue(weight);

            sum = sum - fuelCost(distance, FUEL_PRICE_PER_100) - insuranceCost() - maintenance(distance, weight);

            flightProfits = sum;
        }
    }
}
