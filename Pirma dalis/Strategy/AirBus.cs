using System;
using System.Collections.Generic;
using System.Text;

namespace Pirma_dalis.Strategy
{
    public class AirBus : IInsuranceCalculator
    {
        public double checkFlightSpecificRisks()
        {
            return 3000.99;
        }

        public double checkLastMaintenance(int lastMaintenance)
        {
            return lastMaintenance * 250;
        }

        public double checkPilotClass(string pilotClass)
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

        public double checkWeatherConditions(string weather)
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
