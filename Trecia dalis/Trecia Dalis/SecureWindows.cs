using Pirma_dalis.Trecia_Dalis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trecia_dalis.Trecia_Dalis
{
    class SecureWindows : ISecurity
    {

        public void checkEntriePoints(bool entries)
        {
            if (entries)
                Console.WriteLine("Unsecure");
            else
                Console.WriteLine("Secure");
        }

        public void closeEntriePoints()
        {
            Console.WriteLine("Windows closed");
        }

        public void openEntriePoints()
        {
            Console.WriteLine("Windows opened");
        }
    }
}
