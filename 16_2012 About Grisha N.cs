using System;

namespace Grisha
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine().Trim());
            Console.WriteLine((x >= 7)? "YES" : "NO");
            Console.ReadLine(); 
        }
    }
}
