using System;

namespace Another
{
    class Program
    {
        static void Main(string[] args)
        {

            string N = Console.ReadLine();
            int a = int.Parse(N.Split()[0]);
            int b = int.Parse(N.Split()[1]);
            int c = int.Parse(N.Split()[2]);
            if (c == 0) 
            {
                Console.WriteLine(0 + " " + 0);
            }
            else if ( a > c && b >c)
            {
                Console.WriteLine(c + " " + 0);
            }
            else if (a + b < c)
            {
                Console.WriteLine("Impossible");
            }
            else if ((a == c) || (b == c))
            {
                Console.WriteLine(c + " " + 0);
            }
                
            else if (a >= b)
            {
                Console.WriteLine((c - b) + " " + b);
            } else
            {
                Console.WriteLine(a + " " + (c - a));
            }
            
        }
    }
}
