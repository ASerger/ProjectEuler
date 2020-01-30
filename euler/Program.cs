using System;
using System.Diagnostics;

namespace euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch time = new Stopwatch();

            time.Start();
            Number11.LargestProductInGrid();
            time.Stop();

            Console.WriteLine($"\n{time.Elapsed}");
            Console.ReadLine();
        }
    }
}
