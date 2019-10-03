using System;
using System.Collections.Generic;
using System.Text;

namespace Pirma_dalis.Template
{
    abstract class FlightTemplate1
    {
        private string pilotClass;
        private int lastMaintenance;
        private string weather;
        private int distance;
        private string landingLocation;

        protected FlightTemplate1(string pilotClass, int lastMaintenance, string weather)
        {
            this.pilotClass = pilotClass;
            this.lastMaintenance = lastMaintenance;
            this.weather = weather;
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

    }
}
