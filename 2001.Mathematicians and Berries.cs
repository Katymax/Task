using System;

namespace _2001
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s1 = (Console.ReadLine()).Split(' ');
            string[] s2 = (Console.ReadLine()).Split(' ');
            string[] s3 = (Console.ReadLine()).Split(' ');
            int a1 = Int32.Parse(s1[0]);
            int a2 = Int32.Parse(s3[0]);
            int x1 = Int32.Parse(s1[1]);
            int x2 = Int32.Parse(s2[1]);

            Console.WriteLine((a1 - a2) + " " + (x1 - x2));
        }
    }
}