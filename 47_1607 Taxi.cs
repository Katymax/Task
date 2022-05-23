using System;

namespace Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] N = Console.ReadLine().Split(' ');

            int x = int.Parse(N[0]);
            int y = int.Parse(N[1]);
            int a = int.Parse(N[2]);
            int b= int.Parse(N[3]);

            while (x <= a)
            {
               x += y;

                if (x > a)
                {
                    Console.WriteLine(a);
                    return;
                }

                a -= b;
            }

            Console.WriteLine(x);
        }
    }
}

