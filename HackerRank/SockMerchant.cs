using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class SockMerchant
    {
        //usando hashset para verificar o numero de pares de meias
        public SockMerchant(int n, int[] ar)
        {
            int countPairs = 0;
            int key = 0;
            HashSet<int> socks = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int valor = ar[i];
                if (i == 0)
                {
                    socks.Add(valor);
                    key++;
                }
                else
                {
                    if (socks.Contains(valor))
                    {
                        countPairs++;
                        socks.Remove(valor);
                    }
                    else
                    {
                        socks.Add(valor);
                        key++;
                    }
                }
            }

            Console.WriteLine(countPairs);
        }
    }
}
