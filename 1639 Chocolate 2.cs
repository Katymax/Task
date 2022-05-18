using System;

namespace Chocolate
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] x = (Console.ReadLine()).Split(' ');
            int m = Int32.Parse(x[0]);
            int n = Int32.Parse(x[1]);

            if ((m * n) % 2 == 0)
                Console.WriteLine("[:=[first]");
            else if ((m * n) % 2 != 0)
                Console.WriteLine("[second]=:]");
        }
    }          
}