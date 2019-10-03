using System;
using System.Collections.Generic;
using System.Text;

namespace Pirma_dalis.Strategy
{
    class FlightStrategy
    {
        private string pilotClass;
        private int lastMaintenance;
        private string weather;
        private IInsuranceCalculator pc;
        private int distance;
        private string landingLocation;
        private ITripCost tc;

        public FlightStrategy(string pilotClass, int lastMaintenance, string weather, IInsuranceCalculator pc)
        {
            this.pilotClass = pilotClass;
            this.lastMaintenance = lastMaintenance;
            this.weather = weather;
            this.pc = pc;
        }

        public FlightStrategy(string pilotClass, int lastMaintenance, string weather, IInsuranceCalculator pc, int distance, string landingLocation, ITripCost tc) : this(pilotClass, lastMaintenance, weather, pc)
        {
            this.distance = distance;
            this.landingLocation = landingLocation;
            this.tc = tc;
        }

        public double calInsurace()
        {
            double sum = 0;

            sum = pc.checkLastMaintenance(lastMaintenance) + pc.checkPilotClass(pilotClass) + pc.checkWeatherConditions(weather) + pc.checkFlightSpecificRisks();

            return sum;
        }

        public double calTripCost()
        {
            double sum = 0;

            sum = tc.crewCost() + tc.fuelCost(distance) + tc.permissionCost(landingLocation);

            return sum;
        }

        public double calFlightExpences()
        {
            return calInsurace() + calTripCost();
        }

    }
}
