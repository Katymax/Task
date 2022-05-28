using System;

namespace Flags
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            long[] x = new long[N];
            x[0] = 2;
            x[1] = 2;
            if (x.Length > 1) x[1] = 2;
            for (int i = 2; i < x.Length; i++)
                x[i] = x[i - 2] + x[i - 1];

            Console.WriteLine(x[N - 1]);
        }
    }
}