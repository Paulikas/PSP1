using System;
using System.Collections.Generic;
using System.Text;

namespace Pirma_dalis.Template
{
    class PrivateAirBus : FlightTemplate2
    {
        public PrivateAirBus(string pilotClass, int lastMaintenance, string weather, int distance, string landingLocation) : base(pilotClass, lastMaintenance, weather, distance, landingLocation)
        {
        }

        public override double checkFlightSpecificRisks()
        {
            return 3000.99;
        }

        public override double checkLastMaintenance(int lastMaintenance)
        {
            return lastMaintenance * 250;
        }

        public override double checkPilotClass(string pilotClass)
        {
            if (pilotClass == "F")
                return 2000.66;
            else if (pilotClass == "E")
                return 1875.25;
            else if (pilotClass == "D")
                return 1605.23;
            else
                return 1540.36;
        }

        public override double checkWeatherConditions(string weather)
        {
            if (weather == "Bad")
                return 3000.16;
            else if (weather == "Decent")
                return 2600.12;
            else
                return 1500.99;
        }

        public override double crewCost()
        {
            return 2 * 500 + 2 * 300;
        }

        public override double fuelCost(int distance)
        {
            return distance * 0.68;
        }

        public override double permissionCost(string landingLocation)
        {
            if (landingLocation == "Busy")
                return 1000;
            else
                return 600;
        }
    }
}
