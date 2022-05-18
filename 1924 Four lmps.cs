using System;

namespace Lmps
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Int32.Parse(Console.ReadLine());
            if (((x * (x + 1)) / 2) % 2 == 0)  
                Console.WriteLine("black"); 
            else 
                Console.WriteLine("grimy"); 
        }
    }
}