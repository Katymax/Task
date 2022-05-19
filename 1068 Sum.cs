using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int x = 0;
            if (N < 0 && N >= -10000)
            {
                for (int i = N; i <= 1; i++)
                    x += i;
            }
            else if (N > 0 && N <= 10000)
            {
                for (int i = 1; i <= N; i++)
                    x += i;
            }
            else 
                x = 1;
            Console.WriteLine(x);
        }
    }
}