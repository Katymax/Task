using System;

namespace Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string a = "1 2 3";
            string b = "3 4 5";

            if (N != 1 && N != 2)
            {
                Console.WriteLine("-1");
                return;
            }

            Console.WriteLine(N == 1 ? a : b);

        }
    }
}


