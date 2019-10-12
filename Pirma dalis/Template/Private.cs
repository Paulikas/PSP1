using System;
using System.Collections.Generic;
using System.Text;

namespace Pirma_dalis.Template
{
    class Private
    {
        public double crewCost()
        {
            return 2 * 500 + 2 * 300;
        }

        public double fuelCost(int distance)
        {
            return distance * 0.68;
        }

        public double permissionCost(string landingLocation)
        {
            if (landingLocation == "Busy")
                return 1000;
            else
                return 600;
        }
    }
}
