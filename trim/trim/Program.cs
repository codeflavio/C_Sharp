using System;

namespace trim
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "    Olá mundo !  ";
            Console.WriteLine($"[{greeting}]");

            string trimmedgreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedgreeting}]");

            trimmedgreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedgreeting}]");

            trimmedgreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedgreeting}]");
        }
    }
}
