using System;

namespace Equal_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine().ToLower();
            string secondWord = Console.ReadLine().ToLower();

            if (firstWord == secondWord)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
