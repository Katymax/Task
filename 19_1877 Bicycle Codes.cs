using System;

namespace Bicycle
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a % 2 == 0 || b % 2 == 1)
                Console.WriteLine("yes");
            else if (a % 2 != 0 || b % 2 == 1)
                Console.WriteLine("no");
        }
    }
}
