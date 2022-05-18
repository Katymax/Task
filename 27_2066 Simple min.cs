using System;

namespace SimpleMin
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int z = 0;int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            x = a; z = b; y = c;
            int q = x - y * z;
            int i = x - z - y;
            Console.WriteLine(Math.Min(q,i));
        }
    }
}
