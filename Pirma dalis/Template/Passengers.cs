using System;
using System.Collections.Generic;
using System.Text;

namespace Pirma_dalis.Template
{
    class Passengers : FlightTemplate1
    {
        public Passengers(string pilotClass, int lastMaintenance, string weather) : base(pilotClass, lastMaintenance, weather)
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
    }
}
