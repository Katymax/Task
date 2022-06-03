using System;

namespace Dwarfs
{
    class Program
    {
        static void Main(string[] args)
        {
            string N = Console.ReadLine();
            int a = 0;
            int b = 1;
            for (int i = N.Length - 1; i >= 0; i--)
            {
                int x = N[i] - '0';
                a += b * x;
                b *= 3;
                b %= 7;
                a %= 7;
            }
            Console.WriteLine(a);

        }
    }
}
