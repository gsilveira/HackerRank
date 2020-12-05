using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class MergeArrays
    {
        public static int[] mergeArrays(int[] myArray, int[] alicesArray)
        {
            // Combine the sorted arrays into one large sorted array
            int myLenght = myArray.Length;
            int alicesLenght = alicesArray.Length;

            int[] aux = new int[(myLenght) + (alicesLenght)];

            int currentIndexMerged = 0;
            int currentIndexMine = 0;
            int currentIndexAlices = 0;

            if (myLenght == 0)
                aux = alicesArray;
            else if (alicesLenght == 0)
                aux = myArray;
            else
            {
                while (currentIndexMerged < aux.Length) {

                    bool isMyArrayExhausted = currentIndexMine >= myArray.Length;
                    bool isAlicesArrayExhausted = currentIndexAlices >= alicesArray.Length;

                    if (!isMyArrayExhausted && (isAlicesArrayExhausted
                        || (myArray[currentIndexMine] < alicesArray[currentIndexAlices])))
                    {
                        aux[currentIndexMerged] = myArray[currentIndexMine];
                        currentIndexMine++;
                    }
                    else
                    {
                        aux[currentIndexMerged] = alicesArray[currentIndexAlices];
                        currentIndexAlices++;
                    }
                }

                    currentIndexMerged++;
            }
            return aux;
        }
    }
}

