using System;
using System.Collections.Generic;
using System.Text;

namespace Pirma_dalis.Strategy
{
    public interface ITripCost
    {
        public double permissionCost(string landingLocation);

        public double crewCost();

        public double fuelCost(int distance);


    }
}
