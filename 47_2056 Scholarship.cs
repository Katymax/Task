using System;

namespace Scholardhip
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            bool x = false;
            bool y = true;

            double q = 0;
            for (int i = 0; i < N && !x; i++)
            {
                int z = int.Parse(Console.ReadLine());
                if (z == 3) x = true;
                q += z;
                if (z < 5) y = false;
            }

            if (x) 
                Console.WriteLine("None");
            else if (y) 
                Console.WriteLine("Named");
            else if (q / N >= 4.5) 
                Console.WriteLine("High");
            else 
                Console.WriteLine("Common");

        }
    }
}
