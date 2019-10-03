using System;
using System.Collections.Generic;
using System.Text;

namespace Pirma_dalis.Template
{
    abstract class FlightTemplate2
    {
        private string pilotClass;
        private int lastMaintenance;
        private string weather;
        private int distance;
        private string landingLocation;

        protected FlightTemplate2(string pilotClass, int lastMaintenance, string weather)
        {
            this.pilotClass = pilotClass;
            this.lastMaintenance = lastMaintenance;
            this.weather = weather;
        }

        public FlightTemplate2(string pilotClass, int lastMaintenance, string weather, int distance, string landingLocation) : this(pilotClass, lastMaintenance, weather)
        {
            this.distance = distance;
            this.landingLocation = landingLocation;
        }

        public abstract double checkPilotClass(string pilotClass);

        public abstract double checkLastMaintenance(int lastMaintenance);

        public abstract double checkWeatherConditions(string weather);

        public abstract double checkFlightSpecificRisks();

        public double calInsurace()
        {
            double sum = 0;

            sum = checkLastMaintenance(lastMaintenance) + checkPilotClass(pilotClass) + checkWeatherConditions(weather) + checkFlightSpecificRisks();

            return sum;
        }

        public abstract double permissionCost(string landingLocation);

        public abstract double crewCost();

        public abstract double fuelCost(int distance);

        public double calTripCost()
        {
            double sum = 0;

            sum = crewCost() + fuelCost(distance) + permissionCost(landingLocation);

            return sum;
        }

        public double calFlightExpences()
        {
            return calInsurace() + calTripCost();
        }
    }
}
