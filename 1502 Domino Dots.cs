using System;

namespace Domino
{
    class Program
    {
        static void Main(string[] args)
        {
            long x = long.Parse(Console.ReadLine());
            long y = 0;
            y = x * (x + 1) * (x + 2) / 2;
            Console.WriteLine(y);

        }
    }
}