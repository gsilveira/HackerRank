using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class HasPalindromePermutation
    {

        public static bool hasPalindromePermutation(string theString)
        {
            // Check if any permutation of the input is a palindrome
            HashSet<char> permu = new HashSet<char>();
            char[] letterArray = theString.ToCharArray();

            foreach (var letter in letterArray)
            {
                if (!permu.Contains(letter))
                {
                    permu.Add(letter);
                }
            }

            int lettersInHash = letterArray.Length - permu.Count;
            int lettersInArrayLeft = letterArray.Length / 2;

            if (lettersInHash == lettersInArrayLeft)
            {
                return true;
            }

            return false;
        }
    }
}
