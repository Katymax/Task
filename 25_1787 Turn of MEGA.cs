using System;

namespace MEGA
{

    class Program
    {
        static void Main()
        {
            string[] N = Console.ReadLine().Split(' ');
            int x = int.Parse(N[0]);
            int y = int.Parse(N[1]);
            int a;
            int b;
            int c = 0;
            N = Console.ReadLine().Split(' ');
            
            for (a = 0; a < y; a++)
            {
                b = int.Parse(N[a]);
                c = Math.Max(0, c + b - x);
            }
            Console.WriteLine(c);
        }
    }
}
