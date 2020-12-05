using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class ReverseString
    {
        public static void Reverse(char[] arrayOfChars)
        {
            // Reverse input array of characters in place
            char aux;
            int rightSide = arrayOfChars.Length-1;
            int leftSide = 0;

            if (arrayOfChars.Length > 1)
            {
                while (leftSide < rightSide) {
                    aux = arrayOfChars[leftSide];
                    arrayOfChars[leftSide] = arrayOfChars[rightSide];
                    arrayOfChars[rightSide] = aux;

                    rightSide--;
                    leftSide++;
                }
            }

        }
    }
}
