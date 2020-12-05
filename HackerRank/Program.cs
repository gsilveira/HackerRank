using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using HackerRank;

class Solution
{

    // Complete the solve function below.
    static int[] solve(int[] a, int[] b)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < 3; i++)
        {
            if (a[i] > b[i])
            {
                result.Add(1);
            }
            if (a[i] < b[i])
            {
                result.Add(1);
            }
        }

        return result.ToArray();

    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

        //int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), bTemp => Convert.ToInt32(bTemp));
        //int[] result = solve(a, b);

        //textWriter.WriteLine(string.Join(" ", result));

        //textWriter.Flush();
        //textWriter.Close();

        // SockMerchant socks = new SockMerchant(9, new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 });

        //GetProductsOfAllIntsExceptAtIndex g = new GetProductsOfAllIntsExceptAtIndex();
        //g.getProductsOfAllIntsExceptAtIndex(new int[] { 1 });

        //var meetings = new List<Meeting>()
        //{
        //     //new Meeting(1, 4), new Meeting(2, 5), new Meeting (5, 8)
        //     new Meeting(5, 8), new Meeting(1, 4), new Meeting(6, 8)
        //};

        //Meeting.MergeRanges(meetings);

        //ReverseString.Reverse("ABCDE".ToCharArray());

        //ReverseWords.reverseWords("one another get".ToCharArray());

        //var myArray = new int[] { 2, 4, 6, 8, 9 };
        //var alicesArray = new int[] { 1, 7 };

        //MergeArrays.mergeArrays(myArray, alicesArray);

        //var half1 = new int[] { 1, 5 };
        //var half2 = new int[] { 2, 3, 6 };
        //var shuffledDeck = new int[] { 1, 2, 6, 3, 5 };

        //var half1 = new int[] { 1, 4, 5 };
        //var half2 = new int[] { 2, 3, 6 };
        //var shuffledDeck = new int[] { 1, 2, 3, 4, 5, 6 };

        //var half1 = new int[] { 1, 5 };
        //var half2 = new int[] { 2, 3, 6 };
        //var shuffledDeck = new int[] { 1, 2, 3, 5, 6, 8 };
        //IsSingleRiffle.CheckSingleRiffle(half1, half2, shuffledDeck);

        //CanTwoMoviesFillFlight.arrangeTwoMoviesFillFlight(new int[] { 3, 8, 3 }, 6);

        //HasPalindromePermutation.hasPalindromePermutation("aabccbdd");

        //var expected = new int[] { 1, 7, 3, 4 };
        //GetProductsOfAllIntsExceptAtIndex.getProductsOfAllIntsExceptAtIndex(expected);

        //BinarySearch.binarySearch()

        //CountingValleys.countingValleys(8, "UDDDUDUU");

        //JumpingClouds.jumpingOnClouds(new int[] {0, 0, 0, 1, 0, 0});
        //RepeatedStrings.repeatedString("a", 1000000000000);

        int[][] input = new int[][]
        {
           new[]{1, 1, 1, 0, 0, 0},
           new[]{0, 1, 0, 0, 0, 0},
           new[]{1, 1, 1, 0, 0, 0},
           new[]{0, 0, 2, 4, 4, 0},
           new[]{0, 0, 0, 2, 0, 0},
           new[]{0, 0, 1, 2, 4, 0}
        };

        _2DArray.hourglassSum(input);
    }
}