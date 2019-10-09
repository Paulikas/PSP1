using System;
using System.Collections.Generic;
using System.Text;

namespace Pirma_dalis.Trecia_Dalis
{
    class ClosedShoes : Closet, IShoes
    {
        List<string> shoes = new List<string>();
        public void addShoes(string shoe)
        {
            shoes.Add(shoe);
        }

        public void browsShoes()
        {
            foreach (string i in shoes)
            {
                Console.WriteLine(i);
            }
        }
    }
}
