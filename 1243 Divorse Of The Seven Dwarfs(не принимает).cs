using System;

namespace SevenDwarfs
{
    class Program
    {
        static void Main(string[] args)
        {
            long x = long.Parse(Console.ReadLine());
            long y = x % 7;

            Console.WriteLine(y);

        }
    }
}