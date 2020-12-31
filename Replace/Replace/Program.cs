using System;

namespace Replace
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayHello = "Olá mundo !";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Olá", "Oi");
            Console.WriteLine(sayHello);
        }
    }
}
