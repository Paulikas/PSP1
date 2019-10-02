namespace Pirma_dalis.Strategy
{
    public interface IProfitCounter
    {
        public double insuranceCost();

        public double fuelCost(int distance, double fuelPrice);

        public double maintenance(int distance, int weight);

        public double tripValue(int weight);
    }
}