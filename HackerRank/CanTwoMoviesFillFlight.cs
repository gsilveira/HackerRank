using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class CanTwoMoviesFillFlight
    {
        public static bool arrangeTwoMoviesFillFlight(int[] movieLengths, int flightLength)
        {
            // Determine if two movies add up to the flight length
            var movieLengthsSeen = new HashSet<int>();

            foreach (var firstMovieLength in movieLengths)
            {
                int matchingSecondMovieLength = flightLength - firstMovieLength;
                if (movieLengthsSeen.Contains(matchingSecondMovieLength))
                {
                    return true;
                }

                movieLengthsSeen.Add(firstMovieLength);
            }

            // We never found a match, so return false
            return false;
        }
    }
}
