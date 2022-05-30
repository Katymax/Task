using System;

namespace Factorial
{

    class Program
    {
        static void Main()
        {
            string[] N = Console.ReadLine().Split(' ');
            int x = int.Parse(N[0]);
            int y = N[1].Length;
            int z = 0;
            int a = 1;
            int b = 1;
            while (b >= 1)
            {
                a *= b;
                b = x - (z * y);
                z++;
            }
            Console.WriteLine(a);
        }
    }
}
