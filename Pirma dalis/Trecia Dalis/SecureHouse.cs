using System;
using System.Collections.Generic;
using System.Text;

namespace Pirma_dalis.Trecia_Dalis
{
    class SecureHouse : House, ISecurity
    {
        public void checkWindows()
        {
            Console.WriteLine("Windows checked");
        }

        public void closeWindows()
        {
            Console.WriteLine("Windows closed");
        }

        public void openWindows()
        {
            Console.WriteLine("Windows opened");
        }
}
