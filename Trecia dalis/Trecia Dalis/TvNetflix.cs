using System;
using System.Collections.Generic;
using System.Text;
using Trecia_dalis.Trecia_Dalis;

namespace Pirma_dalis.Trecia_Dalis
{
    class TvNetflix : TV, INetflix
    {
        NetflixStandart ns = new NetflixStandart();

        public void browsMovie()
        {
            ns.browsMovie();
        }

        public void playMovie(string movie)
        {
            ns.playMovie(movie);
        }
    }
}
