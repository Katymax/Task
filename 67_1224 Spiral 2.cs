using System;

namespace Spiral
{
    class Program
    {
        static void Main(string[] args)
        {
            string N = Console.ReadLine();
            long a = long.Parse(N.Split()[0]);
            long b = long.Parse(N.Split()[1]);

            Console.WriteLine(b >= a ? 2 * (a - 1) : 2 * (b - 1) + 1);
        }
    }
}

