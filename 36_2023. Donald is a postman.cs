using System;

namespace Donald
{
    class Programm
    {
        static void Main()
        {
            int y = int.Parse(Console.ReadLine());
            int a = 1;
            int b = 0;
            
            
            for (int i = 0; i < y; ++i)
            {
                string x = Console.ReadLine();
                if (x[0] == 'A' || x[0] == 'P' || x[0] == 'O' || x[0] == 'R')
                {
                    b += Math.Abs(a - 1);
                    a = 1;
                }
                else if (x[0] == 'B' || x[0] == 'M' || x[0] == 'O' || x[0] == 'S')
                {
                    b += Math.Abs(a - 2);
                    a = 2;
                }
                else if (x[0] == 'D' || x[0] == 'G' || x[0] == 'J' || x[0] == 'K' || x[0] == 'T' || x[0] == 'W')
                {
                    b += Math.Abs(a - 3);
                    a = 3;
                }
            }
            
            Console.WriteLine(b);
        }
    }
}
