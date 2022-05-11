using System;
namespace Localization
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            if (x >= 1 && x <= 4)
                Console.WriteLine("few");
            if (x >= 5 && x <= 9)
                Console.WriteLine("several");
            if (x >= 10 && x <= 19)
                Console.WriteLine("pack");
            if (x >= 20 && x <= 49)
                Console.WriteLine("lots");
            if (x >= 50 && x <= 99)
                Console.WriteLine("horde");
            if (x >= 100 && x <= 249)
                Console.WriteLine("throng");
            if (x >= 250 && x <= 499)
                Console.WriteLine("swarm");
            if (x >= 500 && x <= 999)
                Console.WriteLine("zounds");
            if (x >= 1000)
                Console.WriteLine("legion");

        }

    }
}