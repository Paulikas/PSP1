using System;
using System.Collections.Generic;
using System.Text;

namespace Pirma_dalis.Trecia_Dalis
{
    class House
    {
        public int temp = 0;
        public bool windows_open = false;

        public void warmUp()
        {
            temp += 1;
            windows_open = false;
        }
        public void warmUp(int amount)
        {
            temp += amount;
            windows_open = false;
        }
        public void coolDown()
        {
            temp--;
            windows_open = true;
        }

        public void coolDown(int amount)
        {
            temp-=amount;
            windows_open = true;
        }

    }
}
