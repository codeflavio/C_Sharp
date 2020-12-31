using System;

namespace Contains
{
    class Program
    {
        static void Main(string[] args)
        {
            string songLyrics = "you say goodbay, and y say hallo";
            Console.WriteLine(songLyrics.StartsWith("você"));
            Console.WriteLine(songLyrics.StartsWith("adeus"));
        }
    }
}
