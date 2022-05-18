
using System;

namespace Ural
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] x = Console.ReadLine().Split(' '); 
            int n = int.Parse(x[0]);  
            int k = int.Parse(x[1]);   
            if (n <= k)
                Console.WriteLine(2); 
            else if (n >= k)
            Console.WriteLine((2 * n - 1) / k + 1);
        }
    }
}
