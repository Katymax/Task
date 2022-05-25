using System;

namespace Bookworm
{
    class Program
    {
        static void Main(string[] args)
        {
            string N = Console.ReadLine();
            int a = int.Parse(N.Split()[0]);
            int b = int.Parse(N.Split()[1]);
            int x = int.Parse(N.Split()[2]);
            int y = int.Parse(N.Split()[3]);
            

            Console.WriteLine(Math.Abs((y - x ) * (2 * b + a)-a));
        }
    }
}