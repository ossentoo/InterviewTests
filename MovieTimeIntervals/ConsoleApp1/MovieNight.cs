using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class MovieNight
    {
        public static bool CanViewAll(IEnumerable<Movie> movies)
        {
            var sortedMovies = movies.OrderBy(x=>x.Start).ToList();
            var sortedMovies2 = movies.OrderBy(x=>x.Start).ToList();

            for (var i = 0; i < sortedMovies.Count; i++)
            {

                for (var j=0; j<sortedMovies2.Count; j++)
                {
                    if(i==j)
                        continue;

                    var first = sortedMovies[i];
                    var second = sortedMovies[j];

                    var case1 = sortedMovies[i].Start > second.Start && first.End< second.End;
                    var case2 = second.Start > first.Start && second.End < first.End;

                    if (case1 || case2)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}