using System;

namespace Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] N = Console.ReadLine().Split(' ');
            string[] S = Console.ReadLine().Split(' ');
            int a = int.Parse(N[0]);
            int b = int.Parse(N[1]);

            int x = 0;
            int y = 0;

            for (int i = 0; i < a; i++)
            {
                int z = int.Parse(S[i]);
                if (z > b)

                    y += z - b;

                else if (b > z)

                    x += b - z;

            }

            Console.WriteLine( y + " " + x);

        }
    }
}