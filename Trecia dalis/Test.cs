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
            sh.closeEntriePoints();

            check(sh);
            newShoes(cs);
            movieList(tn);

            cs.addShirt("Blue");
            cs.showShirts();

            tn.changeChannel("Netflix");
            Console.WriteLine(tn.channel);
            tn.browsMovie();
        }

        static public void check(ISecurity s)
        {
            Console.WriteLine("method:");
            s.checkEntriePoints(false);
        }

        static public void newShoes(IShoes s)
        {
            s.addShoes("Sneaker");
            s.browsShoes();
        }

        static public void movieList(INetflix n)
        {
            n.browsMovie();
        }
    }
}
