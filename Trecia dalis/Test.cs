using System;
using System.Collections.Generic;
using System.Text;

namespace Pirma_dalis.Trecia_Dalis
{
    class Test
    {
        static void Main()
        {
            SecureHouse sh = new SecureHouse();
            ClosedShoes cs = new ClosedShoes();
            TvNetflix tn = new TvNetflix();

            sh.warmUp();
            Console.WriteLine(sh.temp);
            sh.closeWindows();

            cs.addShirt("Blue");
            cs.showShirts();

            tn.changeChannel("Netflix");
            Console.WriteLine(tn.channel);
            tn.browsMovie();
        }
    }
}
