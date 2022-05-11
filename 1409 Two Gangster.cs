using System;

namespace Gangster
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] x = (Console.ReadLine()).Split(' ');
            int a = Int32.Parse(x[0]);
            int b = Int32.Parse(x[1]);
            Console.WriteLine((b - 1) + " " + (a - 1));
        }
    }
}