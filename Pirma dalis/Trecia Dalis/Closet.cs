using System;
using System.Collections.Generic;
using System.Text;

namespace Pirma_dalis.Trecia_Dalis
{
    class Closet
    {
        List<string> shirts = new List<string>();

        void addShirt(string shirt)
        {
            shirts.Add(shirt);
        }

        void showShirts()
        {
            foreach (string i in shirts)
            {
                Console.WriteLine(i);
            }
        }

        void removeShirt(string shirt)
        {
            shirts.Remove(shirt);
        }
    }
}
