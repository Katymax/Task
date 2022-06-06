using System;

namespace Another
{
    class Program
    {
        static void Main(string[] args)
        {

            string N = Console.ReadLine();
            int a = int.Parse(N.Split()[0]);
            int b = int.Parse(N.Split()[1]);
            int c = int.Parse(N.Split()[2]);
            if (a + b < c)
            {
                Console.WriteLine("impossible");
            }
            else if (a <= c)
            {
                Console.WriteLine(a + " " + (c - a));

            }
            else 
            {
                Console.WriteLine(c + " " + 0);
            }

        }
    }
}