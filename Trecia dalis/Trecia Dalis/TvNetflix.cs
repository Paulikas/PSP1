using System;
using System.Collections.Generic;
using System.Text;

namespace Pirma_dalis.Trecia_Dalis
{
    class TvNetflix : TV, INetflix
    {
        List<string> movies = new List<string>()
        {
            "Movie1",
            "Movie2"
        };
        public void browsMovie()
        {
            foreach (string i in movies)
            {
                Console.WriteLine(i);
            }
        }

        public void playMovie(string movie)
        {
            if (movies.Contains(movie))
                Console.WriteLine("Now playing " + movie);
            else
                Console.WriteLine("There is no such movie");
        }
    }
}
