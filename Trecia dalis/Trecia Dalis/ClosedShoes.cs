using System;
using System.Collections.Generic;
using System.Text;
using Trecia_dalis.Trecia_Dalis;

namespace Pirma_dalis.Trecia_Dalis
{
    class ClosedShoes : Closet
    {
        Sneakers s = new Sneakers();
        public void addShoes(string shoe)
        {
            s.addShoes(shoe);
        }

        public void browsShoes()
        {
            s.browsShoes();
        }
    }
}
