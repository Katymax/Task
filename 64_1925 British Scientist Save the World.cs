using System;

namespace British
{
    class Program
    {
        static void Main(string[] args)
        {
            string N = Console.ReadLine();
            int a = int.Parse(N.Split()[0]);
            int b = int.Parse(N.Split()[1]);
            int x = b;
            int y = 0;
            int q = 0;

            for (int i = 0; i < a; i++)
            {
                N = Console.ReadLine();
                x += int.Parse(N.Split()[0]);
                y += int.Parse(N.Split()[1]);
            }

             q = x - (2 * (a + 1)) - y;
            if (q < 0) 
                Console.WriteLine("Big Bang!");
            else if (q > 0) 
                Console.WriteLine(q);
        }
    }
}
