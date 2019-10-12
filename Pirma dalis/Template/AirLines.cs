using System;
using System.Collections.Generic;
using System.Text;

namespace Pirma_dalis.Template
{
    class AirLines
    {
        public double crewCost()
        {
            return 2 * 600 + 3 * 300;
        }

        public double fuelCost(int distance)
        {
            return distance * 0.77;
        }

        public double permissionCost(string landingLocation)
        {
            if (landingLocation == "Planned")
                return 300;
            else
                return 1200.15;
        }
    }
}
