using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            CountDown(10);

            Console.ReadKey();
        }

        static void CountDown(int n)
        {
            if (n <= 0)
                return;

            Console.WriteLine(n);
            CountDown(n - 1);
        }
    }
}
