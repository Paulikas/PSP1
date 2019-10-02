using System;
using System.Collections.Generic;
using System.Text;

namespace Pirma_dalis.Strategy
{
    class Ship
    {
        private string tripType;
        private int weight;
        private int distance;
        private const double FUEL_PRICE_PER_100 = 6;
        public double tripProfits;
        private IProfitCounter pc;

        public Ship(string tripType, int weight, int distance, IProfitCounter pc)
        {
            this.tripType = tripType;
            this.weight = weight;
            this.distance = distance;
            this.pc = pc;
        }

        public void calProfit()
        {
            double sum = 0;

            sum = pc.tripValue(weight);

            sum = sum - pc.fuelCost(distance, FUEL_PRICE_PER_100) - pc.insuranceCost() - pc.maintenance(distance, weight);

            tripProfits = sum;
        }
    }
}
