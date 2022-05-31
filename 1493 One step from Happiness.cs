using System;

namespace OneStep
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int x = 0;
            int y = 0;
            int c = 0;
            x = N % 10;
            for (int i = 0; i < 3; i++)
            {
                c += N % 10;
                N = N / 10;
            }
            for (int i = 0; i < 3; i++)
            {
                y += N % 10;
                N = N / 10;
            }
            if ((y > c) && (x == 9))
                Console.WriteLine("No");
            else if ((y < c) && (x == 0))
                Console.WriteLine("No");
            else
                Console.WriteLine("Yes");
        }
    }
}