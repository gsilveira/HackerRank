using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class JumpingClouds
    {
        public static int jumpingOnClouds(int[] c)
        {
            int jumps = 0;
            int count = 0;

            while (count < c.Length -1)
            {

                if (count + 2 < c.Length && c[count + 2] == 0)
                {
                    count = count + 2;
                }
                else
                {
                    count++;
                }

                jumps++;
            }

            return jumps;
        }
    }
}
