using System;
using System.Collections.Generic;
using System.Text;

namespace Pirma_dalis.Strategy
{
    class FlightStrategy
    {
        private string flightType;
        private int weight;
        private int distance;
        private const double FUEL_PRICE_PER_100 = 1.25;
        public double flightProfits;
        private IProfitCounter pc;


        public FlightStrategy(string flightType, int weight, int distance, IProfitCounter pc)
        {
            this.flightType = flightType;
            this.weight = weight;
            this.distance = distance;
            this.pc = pc;
        }



        public void calProfit()
        {
            double sum = 0;

            sum = pc.flightValue(weight);

            sum = sum - pc.fuelCost(distance, FUEL_PRICE_PER_100) - pc.insuranceCost() - pc.maintenance(distance, weight);

            flightProfits = sum;
        }
    }
}
