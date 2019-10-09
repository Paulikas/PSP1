using System;
using System.Collections.Generic;
using System.Text;

namespace Pirma_dalis.Trecia_Dalis
{
    class Closet
    {
        public List<string> shirts = new List<string>();

        public void addShirt(string shirt)
        {
            shirts.Add(shirt);
        }

        public void showShirts()
        {
            foreach(string i in shirts){
                Console.WriteLine(i);
            }
        }

        public void removeShirt(string shirt)
        {
            shirts.Remove(shirt);
        }
    }
}
