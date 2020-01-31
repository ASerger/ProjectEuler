using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euler
{
    public static class Number10
    {
        /// <summary>
        /// ellen() method does not take into account the squares of primes =( we goofed
        /// </summary>
        /// <returns></returns>
        public static List<long> ELLEN()
        {
            List<long> ListoPrime = new List<long>();
            int Target = 1000;
            for (int i = 1; i < Target; i++)
            {
                int[] moduloSet = { 2, 3, 5, 7 };

                if (i % moduloSet[0] == 0 || i % moduloSet[1] == 0 || i % moduloSet[2] == 0 || i % moduloSet[3] == 0)
                {
                    continue;
                }
                else
                {
                    ListoPrime.Add(i);
                }
            }

            foreach (var item in ListoPrime)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"\n Count: {ListoPrime.Count()}");

            return ListoPrime;
        }

        public static void STACKOVERFLOW()
        {
            long num = 10;
            long retVal = -1; //set to -1 to offset 1 being a prime number
            char[] evens = new char[] { '0', '2', '4', '5', '6', '8' };
            for (long i = 0; i <= num; i++)
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
                if (isPrime) retVal += i;
            }
            Console.WriteLine(retVal);
        }
    }
}
