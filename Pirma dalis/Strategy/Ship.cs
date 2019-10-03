using System;
using System.Collections.Generic;
using System.Text;

namespace Pirma_dalis.Strategy
{
    class Ship
    {
        private string crewTier;
        private int lastMaintenance;
        private string weather;
        private IInsuranceCalculator pc;

        public Ship(string crewTier, int lastMaintenance, string weather, IInsuranceCalculator pc)
        {
            this.crewTier = crewTier;
            this.lastMaintenance = lastMaintenance;
            this.weather = weather;
            this.pc = pc;
        }

        public double calInsurace()
        {
            double sum = 0;

            sum = pc.checkLastMaintenance(lastMaintenance) + pc.checkPilotClass(crewTier) + pc.checkWeatherConditions(weather) + pc.checkFlightSpecificRisks();

            return sum;
        }
    }
}
