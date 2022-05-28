using System;

namespace A380
{
    class Program
    {
        static void Main(string[] args)
        {

            string N = Console.ReadLine();
            char a = N[N.Length - 1];
            int b = int.Parse(N.Substring(0, N.Length - 1));

            if (b < 3)
            {
                if (a == 'A' | a == 'D')
                    Console.WriteLine("window");
                else
                    Console.WriteLine("aisle");
            }
            else if (b < 21)
            {
                if (a == 'A' | a == 'F')
                    Console.WriteLine("window");
                else
                    Console.WriteLine("aisle");
            }
            else
            {
                if (a == 'A' | a == 'K')
                    Console.WriteLine("window");
                else if (a == 'C' | a == 'D' | a == 'G' | a == 'H')
                    Console.WriteLine("aisle");
                else
                    Console.WriteLine("neither");

            }

        }
    }
}
