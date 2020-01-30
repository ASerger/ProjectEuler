using System;

namespace euler
{
    public static class Number6
    {
        public static double SumSquareDifference(int naturalNumberRange)
        {
            double retVal;
            double sumSquare = 0;
            double squareSum = 0;

            for (int i=1; i <= naturalNumberRange; i++)
            {
                sumSquare += Math.Pow(i, 2);
                squareSum += i;
            }
            squareSum = Math.Pow(squareSum, 2);
            retVal = squareSum - sumSquare;

            return retVal;
        }
    }
}
