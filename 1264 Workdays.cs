using System;


namespace Workdays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] x = Console.ReadLine().Split(' ');
            long n = int.Parse(x[0]);
            long m = int.Parse(x[1]);
            Console.WriteLine(n * (m + 1));

        }
    }
}