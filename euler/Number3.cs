using System;
using System.Collections.Generic;
using System.Linq;

namespace euler
{
    public class Number3
    {
        public static long LargestPrimeFactor(long limit)
        {
            //var number = 600851475143; //13195; // 600851475143; // largest prime factor
            var lastPrime = new long();

            for (long i = 1; i <= Math.Sqrt(limit); i++)
            {
                if (limit % i == 0)
                {
                    bool isPrime = true;
                    for (long j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        lastPrime = i;
                    }
                }
            }
            return lastPrime;
        }
    }
}
