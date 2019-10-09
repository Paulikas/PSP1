using System;
using System.Collections.Generic;
using System.Text;

namespace Pirma_dalis.Trecia_Dalis
{
    class House
    {
        public int temp = 0;

        public void warmUp()
        {
            temp += 1;
        }
        public void warmUp(int amount)
        {
            temp += amount;
        }
    }
}
