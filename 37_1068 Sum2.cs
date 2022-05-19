using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double sum = ((N > 0 ? N * N : 2 - N * N) + N) / 2;
            Console.WriteLine(sum);
        }
    }
}
