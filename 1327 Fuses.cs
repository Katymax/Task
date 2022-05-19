using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int X = (B - A + (A % 2) + (B % 2));
            Console.WriteLine(X/2);

        }
    }
}