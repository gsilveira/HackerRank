using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class RepeatedStrings
    {

        public static long repeatedString(string s, long n)
        {   
            long totalFactor;
            long remaining;
            long count;
            long lettersA = 0;

            lettersA = countLettersA(s.ToCharArray(), s.Length);
            totalFactor = n / s.Length;
            remaining = n % s.Length;
            count = totalFactor * lettersA;

            lettersA = countLettersA(s.ToCharArray(), remaining);

            return lettersA + count;
        }

        private static long countLettersA(char[] repeat, long size)
        {
            long count = 0;
            for (int i = 0; i <= size; i++)
            {
                if (repeat[i].Equals('a'))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
