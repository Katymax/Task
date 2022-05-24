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
            long x = 0;
            if (a > b) 
                x = b + b - 1;
            else 
                x = (a - 1) * 2;
            Console.WriteLine(x);

        }
    }
}

