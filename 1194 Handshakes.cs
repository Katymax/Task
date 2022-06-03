using System;

namespace Handshakes
{
    class Program
    {
        static void Main(string[] args)
        {
            string N = Console.ReadLine();
            int a = int.Parse(N.Split()[0]);
            int b = int.Parse(N.Split()[1]);
            Console.WriteLine((a - 1) * a / 2 - b);

        }
    }
}