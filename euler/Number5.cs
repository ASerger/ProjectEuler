namespace euler
{
    public static class Number5
    {
        public static int EvenlyDivisible()
        {
            bool isTrue = true;
            int output = 20;
            int comparator = 20;

            while (isTrue)
            {
                for (int i = 10; i <= comparator; i++)
                {
                    if (output % i != 0)
                    {
                        output++;
                        break;
                    }
                    if (i == comparator) isTrue = false;
                }
            }

            return output;
        }
    }
}
