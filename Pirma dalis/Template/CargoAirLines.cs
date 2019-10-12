using System;
using System.Collections.Generic;
using System.Text;

namespace Pirma_dalis.Template
{
    class CargoAirLines : FlightTemplate2
    {
        public CargoAirLines(string pilotClass, int lastMaintenance, string weather, int distance, string landingLocation) : base(pilotClass, lastMaintenance, weather, distance, landingLocation)
        {
        }
        AirLines al = new AirLines();

        public override double checkFlightSpecificRisks()
        {
            return 1000.20;
        }

        public override double checkLastMaintenance(int lastMaintenance)
        {
            return lastMaintenance * 1000.99;
        }

        public override double checkPilotClass(string pilotClass)
        {
            if (pilotClass == "F")
                return 1600.15;
            else if (pilotClass == "E")
                return 1500.45;
            else
                return 1000.55;
        }

        public override double checkWeatherConditions(string weather)
        {
            if (weather == "Bad")
                return 3000.16;
            else
                return 999.99;
        }

        public override double crewCost()
        {
            return al.crewCost();
        }

        public override double fuelCost(int distance)
        {
            return al.fuelCost(distance);
        }

        public override double permissionCost(string landingLocation)
        {
            return al.permissionCost(landingLocation);
        }
    }
}
