using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class ReverseWords
    {
        public static void reverseWords(char[] message)
        {
            // Decode the message by reversing the words
            ReverseChar(message, 0, message.Length - 1);
            int currentIndex = 0;

            for (int i = 0; i <= message.Length; i++)
            {
                if (i == message.Length || message[i] == ' ')
                {
                    ReverseChar(message, currentIndex, i-1);

                    currentIndex = i + 1;
                }
            }

            Console.WriteLine("{0}", new string(message));
        }

        private static void ReverseChar(char[] message, int leftIndex, int rightIndex)
        {
            char aux;

            while (leftIndex < rightIndex)
            {
                aux = message[leftIndex];
                message[leftIndex] = message[rightIndex];
                message[rightIndex] = aux;

                leftIndex++;
                rightIndex--;
            }
        }
    }
}
