namespace Pirma_dalis.Strategy
{
    public interface IInsuranceCalculator
    {
        public double checkPilotClass(string pilotClass);

        public double checkLastMaintenance(int lastMaintenance);

        public double checkWeatherConditions(string weather);

        public double checkFlightSpecificRisks();
    }
}