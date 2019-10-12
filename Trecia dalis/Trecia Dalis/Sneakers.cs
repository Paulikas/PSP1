using Pirma_dalis.Trecia_Dalis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trecia_dalis.Trecia_Dalis
{
    class Sneakers: IShoes
    {
        List<string> shoes = new List<string>() {"Nike"};
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
