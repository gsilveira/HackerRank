using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class IsSingleRiffle
    {
        public static bool CheckSingleRiffle(int[] half1, int[] half2, int[] shuffledDeck)
        {
            bool isSingle = true;
            bool isHalf1Exhausted = false, isHalf2Exhausted = false;

            int indiceHalf1 = 0, indiceHalf2 = 0;

            foreach(var card in shuffledDeck)
            {
                isHalf1Exhausted = indiceHalf1 >= half1.Length;
                isHalf2Exhausted = indiceHalf2 >= half2.Length;

                    if (!isHalf1Exhausted && half1[indiceHalf1] == card)
                    {
                        indiceHalf1++;
                    }
                    else if (!isHalf2Exhausted && half2[indiceHalf2] == card)
                    {
                        indiceHalf2++;
                    }
                    else
                    {
                        isSingle = false;
                        break;
                    }
            }

            return isSingle;
        }
    }
}
