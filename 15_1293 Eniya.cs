using System;
namespace Eniya
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] x = Console.ReadLine().Split(' ');
            Console.WriteLine(int.Parse(x[0]) * int.Parse(x[1]) * int.Parse(x[2]) * 2);
        }
    }
}
