using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class CountingValleys
    {
        internal static int countingValleys(int n, string s)
        {
            int seaLevel = 0;
            int valleysCount = 0;

            foreach (var step in s.ToCharArray())
            {
                if (step.Equals('U'))
                {
                    seaLevel++;
                }

                if (step.Equals('D'))
                {
                    seaLevel--;
                }

                if (seaLevel == 0 && step.Equals('U'))
                {
                    valleysCount++;
                }
            }

            return valleysCount;
        }
    }
}
