using System;
using System.Collections.Generic;
using System.Text;

namespace Pirma_dalis.Trecia_Dalis
{
    class House
    {
        int temp = 0;

        void warmUp()
        {
            temp += 1;
        }
        void warmUp(int amount)
        {
            temp += amount;
        }
    }
}
