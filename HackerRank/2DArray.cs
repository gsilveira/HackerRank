using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class _2DArray
    {
        public static int hourglassSum(int[][] arr)
        {
            //int[] hourglasses;
            int maxSum = 0;

            if (arr.GetLength(0) == 6)
            {
                for (int row = 0; row <= 3; row++)
                {
                    for (int col = 0; col <= 3; col++)
                    {
                        int sum = 0;

                        sum += arr[row][col];
                        sum += arr[row][col + 1];
                        sum += arr[row][col + 2];
                        sum += arr[row + 1][col + 1];
                        sum += arr[row + 2][col];
                        sum += arr[row + 2][col + 1];
                        sum += arr[row + 2][col + 2];

                        if (maxSum < sum)
                        {
                            maxSum = sum;
                        }
                    }
                }
            }

            return maxSum;
        }
    }
}
