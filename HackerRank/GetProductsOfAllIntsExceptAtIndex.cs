using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class GetProductsOfAllIntsExceptAtIndex
    {
        /* Have an array of integers, and for each index you want to find the product of every integer except the integer at that index.
         * For example, given:
         *  [1, 7, 3, 4]
         * your method would return:
         *  [84, 12, 28, 21]
         * by calculating:
         *  [7 * 3 * 4,  1 * 3 * 4,  1 * 7 * 4,  1 * 7 * 3] 
         */
        public static int[] getProductsOfAllIntsExceptAtIndex(int[] intArray)
        {
            //int[] calculation = new int[intArray.Length];
            int[] productOfAllIntsExceptIndex = new int[intArray.Length];

            //para multiplicar, inicializar a variável com 1
            int productSoFar = 1;

            for (int i = 0; i < intArray.Length; i++)
            {
                productOfAllIntsExceptIndex[i] = productSoFar;
                productSoFar *= intArray[i];

            }

            productSoFar = 1;
            for (int i = intArray.Length - 1; i >= 0; i--)
            {
                productOfAllIntsExceptIndex[i] = productSoFar;
                productSoFar *= intArray[i];

            }
            //int count = 0;

            //// Make an array with the products
            //if (intArray.Length > 1)
            //{
            //    for (int i = 0; i < intArray.Length; i++)
            //    {
            //        int multiplyResult = 0;
            //        bool firstTime = true;
            //        for (int j = 0; j < intArray.Length; j++)
            //        {

            //            if (i != j)
            //            {
            //                if (multiplyResult == 0 && firstTime == true)
            //                {
            //                    multiplyResult = intArray[j];
            //                    firstTime = false;
            //                }
            //                else
            //                {
            //                    multiplyResult *= intArray[j];
            //                }
            //            }
            //        }

            //        calculation[count] = multiplyResult;
            //        count++;
            //    }
            //}
            //else
            //{
            //    throw new ArgumentException();
            //}

            return productOfAllIntsExceptIndex;
        }
    }
}
