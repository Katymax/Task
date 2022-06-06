using System;

namespace Long
{
    class Long
    {

        static void Main(string[] args)
        {
            string N = Console.ReadLine();       
            int x = int.Parse(N.Split()[0]);
            int y = int.Parse(N.Split()[1]);
            int z = int.Parse(N.Split()[2]);
            
            double a; 
            int b = 0;
            int c = 0;
            for (int i = 0; i < z; i++)
            {
                int q = Console.ReadLine().Length;
                c += q;
                if (c < y)
                {
                    c++;
                }
                if (c >= y)
                {
                    b++;
                    if (c == y)
                        c = 0;
                    else c = q + 1;
                }
            }
            if (c != 0)
                b++;
            a = (Math.Ceiling((double)b / x));
            Console.WriteLine(a);

        }
    }
}
