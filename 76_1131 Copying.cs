using System;

namespace Copying
{
    class Program
    {
        static void Main(string[] args)
        {
            string N = Console.ReadLine();
            int a = int.Parse(N.Split()[0]);
            int b = int.Parse(N.Split()[1]);
            int x = 0;
            int y = 1;

            while (y < a)
            {
                if (y < b)
                {
                    ++x;
                    y += Math.Min(y, b);
                }
                else
                {  
                    x += (a - y) / b;
                    if ((a - y) % b != 0)
                        ++x;
                    break;
                }
            }
            Console.WriteLine(x);
        }
    }
}
