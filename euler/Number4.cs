using System.Collections.Generic;
using System.Linq;

namespace euler
{
    public class Number4
    {
        public static int LargestPalindromicNumber()
        {
            // largest palindrome made from the product of two 2-digit numbers is 9009
            //int largestTwoDigitMultiple = 99 * 99;
            int largest = 0;

            for (int i = 999; i >= 100; i--)
            {
                for (int j = 999; j >= 100; j--)
                {
                    var res = i * j;

                    var reverse = FlipInt(res);

                    if (res == reverse)
                    {
                        if (res > largest)
                        {
                            largest = res;
                            break;
                        }
                    }
                }
            }

            return largest;
        }

        public static int FlipInt(int number)
        {
            var chArray = number.ToString().ToCharArray();
            var retString = string.Empty;

            for (int i = chArray.Length - 1; i >= 0; i--)
            {
                retString += chArray[i];
            }

            return int.Parse(retString);
        }
    }
}
