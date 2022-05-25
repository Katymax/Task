using System;

namespace Penalty
{
    class Program
    {
        static void Main(string[] args)
        {

            string N = Console.ReadLine();
            int a = int.Parse(N.Split()[0]);
            int b = int.Parse(N.Split()[1]);
            N = Console.ReadLine();
            string[] s = N.Split();
            int x = 0;
            for (int i = 0; i < 10; i++)
            {
                x += int.Parse(s[i]) * 20;
            }
            b -= x;
            if (a <= b) 
                Console.WriteLine("No chance.");
            else
                Console.WriteLine("Dirty debug :(");

        }
    }
}
