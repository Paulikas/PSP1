﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pirma_dalis.Strategy
{
    class Cargo : IInsuranceCalculator
    {
        public double checkFlightSpecificRisks()
        {
            return 1000.20;
        }

        public double checkLastMaintenance(int lastMaintenance)
        {
            return lastMaintenance * 1000.99;
        }

        public double checkPilotClass(string pilotClass)
        {
            if (pilotClass == "F")
                return 1600.15;
            else if (pilotClass == "E")
                return 1500.45;
            else
                return 1000.55;
        }

        public double checkWeatherConditions(string weather)
        {
            if (weather == "Bad")
                return 3000.16;
            else
                return 999.99;
        }

    }
}
