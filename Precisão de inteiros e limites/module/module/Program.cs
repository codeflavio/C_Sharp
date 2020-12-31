using System;

namespace module
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotiente: {d}");
            Console.WriteLine($"remainder: {e}");
        }
    }
}
