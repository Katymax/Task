using System;


namespace Morning
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = Console.ReadLine();
            int a = int.Parse(s.Split()[0]);
            int b = int.Parse(s.Split()[1]);
            int N = 0;
            int S = 0;

            N = 40 + 2 * b;
            S = 2 * a + 39;
            if (N > S)
                Console.WriteLine(N);

            else if (N < S)

            Console.WriteLine(S);

        }
    }
}

