using System;

namespace euler
{
    public static class Number9
    {
        public static void ELLEN()
        {
            bool isExit = false;
            for (int c = 1000; c > 0; c--)
            {
                if (isExit) break;
                for (int b = 999; b > 0; b--)
                {
                    if (isExit) break;
                    for (int a = 998; a > 0; a--)
                    {
                        if (isExit) break;
                        if (a + b + c == 1000 && (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2)))
                        {
                            Console.WriteLine($"a: {a}, b: {b}, c: {c}");
                            Console.WriteLine($"{a * b * c}");
                            isExit = true;
                        }
                    }
                }
            }
        }
    }
}
